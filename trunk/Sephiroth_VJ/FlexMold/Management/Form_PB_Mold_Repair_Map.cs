using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using C1.Win.C1FlexGrid;
using System.Threading;
using System.Data.OleDb;
using System.Reflection; 
using COMExcel = Microsoft.Office.Interop.Excel;

namespace FlexMold.Management
{
	public class Form_PB_Mold_Repair_Map : COM.MoldWinForm.Form_Top
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker dtpdate_to;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker cmb_workday;
		private System.Windows.Forms.Label lbl_work_ymd;
		private C1.Win.C1List.C1Combo cbo_wh;
		private System.Windows.Forms.Label label12;
		private C1.Win.C1List.C1Combo CboMold_CD;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo Cbo_Size;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1List.C1Combo cmb_Seq;
		private System.Windows.Forms.Label lbl_repairarea;
		private C1.Win.C1List.C1Combo cbo_factory;
		private System.Windows.Forms.Label lbl_factory;
		public COM.FSP fgrid_main;
		private System.ComponentModel.IContainer components = null;

		private COM.OraDB OraDB = new COM.OraDB();
		private C1.Win.C1Chart.C1Chart Chart;
		private System.Data.DataTable dt_list;

		public Form_PB_Mold_Repair_Map()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_Repair_Map));
			this.panel1 = new System.Windows.Forms.Panel();
			this.dtpdate_to = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.cmb_workday = new System.Windows.Forms.DateTimePicker();
			this.lbl_work_ymd = new System.Windows.Forms.Label();
			this.cbo_wh = new C1.Win.C1List.C1Combo();
			this.label12 = new System.Windows.Forms.Label();
			this.CboMold_CD = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.Cbo_Size = new C1.Win.C1List.C1Combo();
			this.label2 = new System.Windows.Forms.Label();
			this.cmb_Seq = new C1.Win.C1List.C1Combo();
			this.lbl_repairarea = new System.Windows.Forms.Label();
			this.cbo_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.fgrid_main = new COM.FSP();
			this.Chart = new C1.Win.C1Chart.C1Chart();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CboMold_CD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Cbo_Size)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Seq)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
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
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.dtpdate_to);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.cmb_workday);
			this.panel1.Controls.Add(this.lbl_work_ymd);
			this.panel1.Controls.Add(this.cbo_wh);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.CboMold_CD);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.Cbo_Size);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cmb_Seq);
			this.panel1.Controls.Add(this.lbl_repairarea);
			this.panel1.Controls.Add(this.cbo_factory);
			this.panel1.Controls.Add(this.lbl_factory);
			this.panel1.Location = new System.Drawing.Point(0, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 72);
			this.panel1.TabIndex = 32;
			// 
			// dtpdate_to
			// 
			this.dtpdate_to.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dtpdate_to.CustomFormat = "yyyy-MM";
			this.dtpdate_to.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dtpdate_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpdate_to.Location = new System.Drawing.Point(536, 8);
			this.dtpdate_to.Name = "dtpdate_to";
			this.dtpdate_to.ShowUpDown = true;
			this.dtpdate_to.Size = new System.Drawing.Size(96, 26);
			this.dtpdate_to.TabIndex = 83;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(480, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 20);
			this.label3.TabIndex = 82;
			this.label3.Text = "To";
			// 
			// cmb_workday
			// 
			this.cmb_workday.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_workday.CustomFormat = "yyyy-MM";
			this.cmb_workday.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_workday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.cmb_workday.Location = new System.Drawing.Point(352, 8);
			this.cmb_workday.Name = "cmb_workday";
			this.cmb_workday.ShowUpDown = true;
			this.cmb_workday.Size = new System.Drawing.Size(96, 26);
			this.cmb_workday.TabIndex = 81;
			// 
			// lbl_work_ymd
			// 
			this.lbl_work_ymd.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_work_ymd.ForeColor = System.Drawing.Color.Blue;
			this.lbl_work_ymd.Location = new System.Drawing.Point(280, 13);
			this.lbl_work_ymd.Name = "lbl_work_ymd";
			this.lbl_work_ymd.Size = new System.Drawing.Size(56, 22);
			this.lbl_work_ymd.TabIndex = 80;
			this.lbl_work_ymd.Text = "From";
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
			this.cbo_wh.Location = new System.Drawing.Point(104, 40);
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
			this.cbo_wh.Size = new System.Drawing.Size(152, 23);
			this.cbo_wh.TabIndex = 79;
			this.cbo_wh.SelectedValueChanged += new System.EventHandler(this.cbo_wh_SelectedValueChanged);
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Blue;
			this.label12.Location = new System.Drawing.Point(8, 40);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(96, 18);
			this.label12.TabIndex = 78;
			this.label12.Text = "Warehouse";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.CboMold_CD.Location = new System.Drawing.Point(352, 40);
			this.CboMold_CD.MatchEntryTimeout = ((long)(2000));
			this.CboMold_CD.MaxDropDownItems = ((short)(5));
			this.CboMold_CD.MaxLength = 32767;
			this.CboMold_CD.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.CboMold_CD.Name = "CboMold_CD";
			this.CboMold_CD.PartialRightColumn = false;
			this.CboMold_CD.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.CboMold_CD.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.CboMold_CD.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.CboMold_CD.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.CboMold_CD.Size = new System.Drawing.Size(280, 23);
			this.CboMold_CD.TabIndex = 77;
			this.CboMold_CD.SelectedValueChanged += new System.EventHandler(this.CboMold_CD_SelectedValueChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(264, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 24);
			this.label1.TabIndex = 76;
			this.label1.Text = "Mold Code";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Cbo_Size
			// 
			this.Cbo_Size.AddItemCols = 0;
			this.Cbo_Size.AddItemSeparator = ';';
			this.Cbo_Size.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.Cbo_Size.Caption = "";
			this.Cbo_Size.CaptionHeight = 17;
			this.Cbo_Size.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.Cbo_Size.ColumnCaptionHeight = 17;
			this.Cbo_Size.ColumnFooterHeight = 17;
			this.Cbo_Size.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.Cbo_Size.ContentHeight = 17;
			this.Cbo_Size.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.Cbo_Size.EditorBackColor = System.Drawing.SystemColors.Window;
			this.Cbo_Size.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Cbo_Size.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.Cbo_Size.EditorHeight = 17;
			this.Cbo_Size.GapHeight = 2;
			this.Cbo_Size.ItemHeight = 15;
			this.Cbo_Size.Location = new System.Drawing.Point(712, 40);
			this.Cbo_Size.MatchEntryTimeout = ((long)(2000));
			this.Cbo_Size.MaxDropDownItems = ((short)(5));
			this.Cbo_Size.MaxLength = 32767;
			this.Cbo_Size.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.Cbo_Size.Name = "Cbo_Size";
			this.Cbo_Size.PartialRightColumn = false;
			this.Cbo_Size.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.Cbo_Size.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.Cbo_Size.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.Cbo_Size.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.Cbo_Size.Size = new System.Drawing.Size(96, 23);
			this.Cbo_Size.TabIndex = 35;
			this.Cbo_Size.Visible = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(656, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 22);
			this.label2.TabIndex = 34;
			this.label2.Text = "Size";
			this.label2.Visible = false;
			// 
			// cmb_Seq
			// 
			this.cmb_Seq.AddItemCols = 0;
			this.cmb_Seq.AddItemSeparator = ';';
			this.cmb_Seq.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Seq.Caption = "";
			this.cmb_Seq.CaptionHeight = 17;
			this.cmb_Seq.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Seq.ColumnCaptionHeight = 17;
			this.cmb_Seq.ColumnFooterHeight = 17;
			this.cmb_Seq.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Seq.ContentHeight = 17;
			this.cmb_Seq.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Seq.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Seq.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Seq.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Seq.EditorHeight = 17;
			this.cmb_Seq.GapHeight = 2;
			this.cmb_Seq.ItemHeight = 15;
			this.cmb_Seq.Location = new System.Drawing.Point(880, 40);
			this.cmb_Seq.MatchEntryTimeout = ((long)(2000));
			this.cmb_Seq.MaxDropDownItems = ((short)(5));
			this.cmb_Seq.MaxLength = 32767;
			this.cmb_Seq.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Seq.Name = "cmb_Seq";
			this.cmb_Seq.PartialRightColumn = false;
			this.cmb_Seq.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Seq.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Seq.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Seq.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Seq.Size = new System.Drawing.Size(104, 23);
			this.cmb_Seq.TabIndex = 26;
			this.cmb_Seq.Visible = false;
			// 
			// lbl_repairarea
			// 
			this.lbl_repairarea.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_repairarea.ForeColor = System.Drawing.Color.Blue;
			this.lbl_repairarea.Location = new System.Drawing.Point(816, 44);
			this.lbl_repairarea.Name = "lbl_repairarea";
			this.lbl_repairarea.Size = new System.Drawing.Size(56, 16);
			this.lbl_repairarea.TabIndex = 25;
			this.lbl_repairarea.Text = "Seq No";
			this.lbl_repairarea.Visible = false;
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
			this.cbo_factory.Location = new System.Drawing.Point(72, 7);
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
			this.fgrid_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
			this.fgrid_main.Size = new System.Drawing.Size(1016, 64);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{Font:Verdana, 9pt, style=Bold;BackColor:128, 255, 255;ForeColor:Red;}	Subtotal0{BackColor:MistyRose;ForeColor:Blue;Border:Flat,1,255, 224, 192,Both;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 55;
			// 
			// Chart
			// 
			this.Chart.DataSource = null;
			this.Chart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Chart.Location = new System.Drawing.Point(0, 208);
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
				"s=\"1\" Color=\"255, 192, 128\" Pattern=\"Solid\" /><SymbolStyle Color=\"Coral\" Outline" +
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
				"ightGray\" Pattern=\"Dash\" /></Axis><Axis Max=\"36\" Min=\"18\" UnitMajor=\"2\" UnitMino" +
				"r=\"1\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\"" +
				" Compass=\"West\"><Text /><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGr" +
				"ay\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\"" +
				" Pattern=\"Dash\" /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoM" +
				"ajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"E" +
				"ast\"><Text /><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern" +
				"=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"D" +
				"ash\" /></Axis></Axes></Chart2DPropBag>";
			this.Chart.Size = new System.Drawing.Size(1016, 432);
			this.Chart.TabIndex = 62;
			// 
			// Form_PB_Mold_Repair_Map
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.Chart);
			this.Controls.Add(this.fgrid_main);
			this.Controls.Add(this.panel1);
			this.Name = "Form_PB_Mold_Repair_Map";
			this.Text = "Form_Mold_Repair_Map";
			this.Load += new System.EventHandler(this.Form_PB_Mold_Repair_Map_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.fgrid_main, 0);
			this.Controls.SetChildIndex(this.Chart, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CboMold_CD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Cbo_Size)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Seq)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PB_Mold_Repair_Map_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			this.tbtn_Append.Enabled = false;
			this.tbtn_Color.Enabled = false;
			this.tbtn_Delete.Enabled = false;
			this.tbtn_Insert.Enabled = false;
			
			cmb_workday.Value = FirstDayOfYear(cmb_workday.Value);
		}
		private void Init_Form()	
		{
			this.lbl_MainTitle.Text = "Mold Repair Monthly Amount";
			ClassLib.ComFunction.SetLangDic(this);

//			fgrid_main.Set_Grid("SDT_MOLD_ERR_REPORT", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
//			fgrid_main.Set_Action_Image(img_Action);
//			fgrid_main.ExtendLastCol = false;

			DataTable dt_ret = Select_com_filter_code_List("SBC21");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_factory, 0, 1, false, false);
			cbo_factory.SelectedValue = "VJ";			

			dt_ret = Select_com_filter_code_List("SDV15");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_wh, 0, 1, false, false);			

//			fgrid_main.Tree.Column = 2;
//			CellStyle s = fgrid_main.Styles[CellStyleEnum.Subtotal0];
//			s.BackColor = Color.YellowGreen;
//			s.ForeColor = Color.White;
//			s.Font = new Font(fgrid_main.Font, FontStyle.Bold);

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
		static DateTime FirstDayOfYear(DateTime y)
		{
			return new DateTime(y.Year, 1, 1);
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Search();			
		}
		private void Search()
		{
			DataTable vDt2 = null;
			try
			{
				vDt2 = SELECT_AMOUN();    
				fgrid_main.Clear();    
				if(vDt2.Rows.Count > 0)
				{
					for(int i = 0; i < vDt2.Rows.Count ; i++)
					{
						fgrid_main.Cols.Count  = vDt2.Rows.Count + 1 ; 
						fgrid_main[0,0] = "Month";
						fgrid_main[1,0] = "Amount";
						fgrid_main[0,i+1] = vDt2.Rows[i].ItemArray[0].ToString();
						fgrid_main[1,i+1] = vDt2.Rows[i].ItemArray[1].ToString();		
						fgrid_main.Cols[i+1].StyleNew.TextAlign = TextAlignEnum.CenterCenter ; //   chinh vao giua
					}
					fgrid_main.Rows[0].StyleNew.TextAlign = TextAlignEnum.CenterCenter;
					fgrid_main.AutoSizeCols();
					fgrid_main.Cols.Frozen = 1;
					fgrid_main.Rows[1].StyleNew.ForeColor = Color.Blue ;  // chinh mau chu 
					Chart_PGM();
				}
				else
				{
		
				}
				vDt2.Dispose();
			}
			finally
			{
				if (vDt2 != null) 
					vDt2.Dispose();
			}	
		}
		private System.Data.DataTable SELECT_AMOUN()
		{
			System.Data.DataSet retDS;                  

			OraDB.ReDim_Parameter(6); 

			//01.PROCEDURE¸i

			OraDB.Process_Name  = "PKG_SDT_MOLD.SELECT_AMOUN_REPAIR";

			//02.ARGURMENT ¸i
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_FROM_YMD";
			OraDB.Parameter_Name[2] = "ARG_TO_YMD";
			OraDB.Parameter_Name[3] = "ARG_WH";
			OraDB.Parameter_Name[4] = "ARG_MOLD_CD";

			OraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE A¤AC
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;

			OraDB.Parameter_Type[5] = (int)OracleType.Cursor;

 
			OraDB.Parameter_Values[0] = cbo_factory.Text.ToString()  ;
			OraDB.Parameter_Values[1] = cmb_workday.Value.ToString("yyyyMM");
			OraDB.Parameter_Values[2] = dtpdate_to.Value.ToString("yyyyMM");
			OraDB.Parameter_Values[3] = cbo_wh.SelectedValue.ToString();
			if ((CboMold_CD.SelectedValue.ToString() == "ALL")||(CboMold_CD.Text == "ALL"))
				OraDB.Parameter_Values[4] = "";
			else
				OraDB.Parameter_Values[4] = CboMold_CD.SelectedValue.ToString().Trim();

			OraDB.Parameter_Values[5] = "";

			OraDB.Add_Select_Parameter(true);

			retDS = OraDB.Exe_Select_Procedure();

			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
		}

		private void CboMold_CD_SelectedValueChanged(object sender, System.EventArgs e)
		{
//			dt_list = Select_Mold();
//			COM.ComCtl.Set_ComboList(dt_list, CboMold_CD, 0, 1, true);  			
//			CboMold_CD.SelectedIndex = 0;
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

		private void cbo_wh_SelectedValueChanged(object sender, System.EventArgs e)
		{
			dt_list = Select_Mold();
			COM.ComCtl.Set_ComboList(dt_list, CboMold_CD, 0, 1, true);  			
			CboMold_CD.SelectedIndex = 0;
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			COMExcel.Application exApp = new COMExcel.Application();

			string workbookPath = "C:/Program Files/CSI/Sephiroth New/Repair_Mold_Month_Report.xls";
			COMExcel.Workbook exBook = exApp.Workbooks.Open(workbookPath,
				0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "",
				true, false, 0, true, false, false);
			COMExcel.Worksheet exSheet = (COMExcel.Worksheet)exBook.Worksheets[1];			

			for (int k = 1 ; k < fgrid_main.Cols.Count; k++)
			{	
				for(int n = 3 ; n <= 26 ;n++)
				{
					COMExcel.Range rr = (COMExcel.Range) exSheet.Cells[22, n];
					COMExcel.Range rex = (COMExcel.Range) exSheet.Cells[21, n];
					if(fgrid_main[0,k].ToString() == Convert.ToString(rex.Value2).ToString())
						rr.Value2 = fgrid_main[1,k];							
				}
			}

			if ((CboMold_CD.SelectedValue.ToString() != " ")||(CboMold_CD.Text != "ALL"))
			{
				COMExcel.Range r_mold = (COMExcel.Range) exSheet.Cells[2, 18];
				r_mold.Value2 = CboMold_CD.Text.ToString();
			}
			COMExcel.Range r_wh = (COMExcel.Range) exSheet.Cells[2, 10];
			r_wh.Value2 = cbo_wh.Text.ToString();

			exApp.Visible = true;

//		----	in so do  -------
//			Chart.PrintChart( (C1.Win.C1Chart.PrintScaleEnum)getScale(), getRect());

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
//			for( int j = 2 ; j <= fgrid_main.Rows.Count-1 ; j++) 
			for( int j = 1 ; j <= fgrid_main.Cols.Count-1 ; j++) 
			{
				string temp = fgrid_main[0,j].ToString();
				C1.Win.C1Chart.ValueLabel vlbl = ax.ValueLabels.AddNewLabel();
				vlbl.NumericValue = j;
				vlbl.Text = temp ;
			}

			ArrayList arrQty	= new ArrayList();

//			for ( int i = 2 ; i<fgrid_main.Rows.Count; i++)
			for ( int i = 1 ; i <= fgrid_main.Cols.Count-1; i++)
				arrQty.Add(double.Parse(Convert.ToString(fgrid_main[1,(short)i])));

			Chart.ChartGroups[0].ChartData[0].Y.CopyDataIn((double[])arrQty.ToArray(typeof(double)));
//			Chart.ChartGroups[0].ChartData[0].X.CopyDataIn((double[])arrQty.ToArray(typeof(double)));

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
			Chart.Header.Text="MOLD REPAIR";
			Chart.Header.Style.Border.BorderStyle=C1.Win.C1Chart.BorderStyleEnum.Raised;
			Chart.Header.Style.Font = new Font( "Arial", 12);

			//setup the chart area
			Chart.ChartArea.Style.BackColor = Color.LightYellow;
			Chart.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel;
			Chart.ChartArea.Style.Border.Thickness = 2;

			//setup axes
			Chart.ChartArea.AxisX.ForeColor = Color.Red;
			Chart.ChartArea.AxisX.Min = 0;
			Chart.ChartArea.AxisX.Max = fgrid_main.Cols.Count;

			Chart.ChartArea.AxisY.ForeColor = Color.Blue;

		}

		C1.Win.C1Chart.PrintScaleEnum getScale()
		{
//			if( rbNone.Checked)
//				return C1.Win.C1Chart.PrintScaleEnum.ScaleNone;
//			else if( rbFit.Checked)
//				return C1.Win.C1Chart.PrintScaleEnum.ScaleToFit;
//			else if( rbMax.Checked)
//				return C1.Win.C1Chart.PrintScaleEnum.ScaleToMax;
//			else if( rbHeight.Checked)
//				return C1.Win.C1Chart.PrintScaleEnum.ScaleToHeight;
//			else
				return C1.Win.C1Chart.PrintScaleEnum.ScaleToWidth;
		}
		Rectangle getRect()
		{
			Rectangle rect = Rectangle.Empty;

			try
			{
//				rect.X = int.Parse( tbLeft.Text);
//				rect.Y = int.Parse( tbTop.Text);
//				rect.Width = int.Parse( tbWidth.Text);
//				rect.Height = int.Parse( tbHeigth.Text);
			}
			catch
			{
				rect.X = 0;
				rect.Y = 0;
				if( Chart.Visible)
				{
					rect.Width = Chart.Width;
					rect.Height = Chart.Height;
				}
				else
				{
					rect.Width = Chart.Width;
					rect.Height = Chart.Height;
				}
			}

			return rect;
		}
		
		
	}
}

