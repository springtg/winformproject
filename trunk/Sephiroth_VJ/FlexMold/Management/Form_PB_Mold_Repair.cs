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
	public class Form_PB_Mold_Repair : COM.MoldWinForm.Form_Top
	{
		private System.Windows.Forms.Panel pnel1;
		private System.Windows.Forms.Label lbl_wp;
		private System.Windows.Forms.TextBox txt_moldcode;
		private System.Windows.Forms.Label lbl_moldcode;
		private C1.Win.C1List.C1Combo cbo_wh;
		private C1.Win.C1List.C1Combo cbo_factory;
		private System.Windows.Forms.Label lbl_factory;
		public COM.FSP fgrid_moldrepair;
		public COM.FSP fgrid_mold;
		private System.Windows.Forms.Panel panel2;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_work_ymd;
		private System.Windows.Forms.DateTimePicker cmb_workday;
		public COM.FSP fgrid_err;
		private System.Windows.Forms.Label lbl_parttype;
		private C1.Win.C1List.C1Combo cbo_parttype;
		private System.Windows.Forms.Label lbl_repairarea;
		private C1.Win.C1List.C1Combo cmb_repairarea;
		private C1.Win.C1List.C1Combo cmb_repairarea1;
		private System.Windows.Forms.Button btn_Search;
		private C1.Win.C1List.C1Combo CboMold_CD;

		private System.Data.DataTable dt_list;
		private COM.OraDB OraDB = new COM.OraDB();
		public Form_PB_Mold_Repair()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_Repair));
			this.pnel1 = new System.Windows.Forms.Panel();
			this.CboMold_CD = new C1.Win.C1List.C1Combo();
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
			this.cmb_repairarea = new C1.Win.C1List.C1Combo();
			this.fgrid_moldrepair = new COM.FSP();
			this.fgrid_mold = new COM.FSP();
			this.panel2 = new System.Windows.Forms.Panel();
			this.fgrid_err = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CboMold_CD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_repairarea1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_parttype)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_repairarea)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_moldrepair)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_mold)).BeginInit();
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
			// tbtn_Search
			// 
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// tbtn_Delete
			// 
			this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
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
			// pnel1
			// 
			this.pnel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnel1.BackColor = System.Drawing.Color.Transparent;
			this.pnel1.Controls.Add(this.CboMold_CD);
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
			this.pnel1.Location = new System.Drawing.Point(0, 48);
			this.pnel1.Name = "pnel1";
			this.pnel1.Size = new System.Drawing.Size(1008, 72);
			this.pnel1.TabIndex = 29;
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
			this.CboMold_CD.Location = new System.Drawing.Point(280, 40);
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
			this.CboMold_CD.Size = new System.Drawing.Size(320, 23);
			this.CboMold_CD.TabIndex = 76;
			// 
			// btn_Search
			// 
			this.btn_Search.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Search.ForeColor = System.Drawing.Color.Red;
			this.btn_Search.Location = new System.Drawing.Point(819, 8);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(72, 24);
			this.btn_Search.TabIndex = 25;
			this.btn_Search.Text = "Search";
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
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
			this.cmb_repairarea1.Location = new System.Drawing.Point(712, 40);
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
			this.lbl_repairarea.Location = new System.Drawing.Point(608, 43);
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
			this.cbo_parttype.ContentHeight = 17;
			this.cbo_parttype.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_parttype.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_parttype.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_parttype.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_parttype.EditorHeight = 17;
			this.cbo_parttype.GapHeight = 2;
			this.cbo_parttype.ItemHeight = 15;
			this.cbo_parttype.Location = new System.Drawing.Point(80, 40);
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
			this.cbo_parttype.Size = new System.Drawing.Size(112, 23);
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
			this.cmb_workday.Location = new System.Drawing.Point(712, 9);
			this.cmb_workday.Name = "cmb_workday";
			this.cmb_workday.Size = new System.Drawing.Size(104, 22);
			this.cmb_workday.TabIndex = 19;
			// 
			// lbl_work_ymd
			// 
			this.lbl_work_ymd.Location = new System.Drawing.Point(608, 15);
			this.lbl_work_ymd.Name = "lbl_work_ymd";
			this.lbl_work_ymd.Size = new System.Drawing.Size(96, 16);
			this.lbl_work_ymd.TabIndex = 18;
			this.lbl_work_ymd.Text = "Working Date";
			// 
			// lbl_wp
			// 
			this.lbl_wp.Location = new System.Drawing.Point(200, 15);
			this.lbl_wp.Name = "lbl_wp";
			this.lbl_wp.Size = new System.Drawing.Size(80, 16);
			this.lbl_wp.TabIndex = 17;
			this.lbl_wp.Text = "Work Place";
			// 
			// txt_moldcode
			// 
			this.txt_moldcode.Location = new System.Drawing.Point(872, 40);
			this.txt_moldcode.Name = "txt_moldcode";
			this.txt_moldcode.Size = new System.Drawing.Size(128, 22);
			this.txt_moldcode.TabIndex = 7;
			this.txt_moldcode.Text = "";
			this.txt_moldcode.Visible = false;
			this.txt_moldcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_moldcode_KeyDown);
			// 
			// lbl_moldcode
			// 
			this.lbl_moldcode.Location = new System.Drawing.Point(200, 48);
			this.lbl_moldcode.Name = "lbl_moldcode";
			this.lbl_moldcode.Size = new System.Drawing.Size(80, 16);
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
			this.cbo_wh.ContentHeight = 17;
			this.cbo_wh.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_wh.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_wh.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_wh.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_wh.EditorHeight = 17;
			this.cbo_wh.GapHeight = 2;
			this.cbo_wh.ItemHeight = 15;
			this.cbo_wh.Location = new System.Drawing.Point(280, 8);
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
			this.cbo_wh.Size = new System.Drawing.Size(112, 23);
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
			this.cbo_factory.Size = new System.Drawing.Size(112, 23);
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
			// cmb_repairarea
			// 
			this.cmb_repairarea.AddItemCols = 0;
			this.cmb_repairarea.AddItemSeparator = ';';
			this.cmb_repairarea.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_repairarea.Caption = "";
			this.cmb_repairarea.CaptionHeight = 17;
			this.cmb_repairarea.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_repairarea.ColumnCaptionHeight = 17;
			this.cmb_repairarea.ColumnFooterHeight = 17;
			this.cmb_repairarea.ContentHeight = 15;
			this.cmb_repairarea.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_repairarea.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_repairarea.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_repairarea.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_repairarea.EditorHeight = 15;
			this.cmb_repairarea.GapHeight = 2;
			this.cmb_repairarea.ItemHeight = 15;
			this.cmb_repairarea.Location = new System.Drawing.Point(0, 0);
			this.cmb_repairarea.MatchEntryTimeout = ((long)(2000));
			this.cmb_repairarea.MaxDropDownItems = ((short)(5));
			this.cmb_repairarea.MaxLength = 32767;
			this.cmb_repairarea.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_repairarea.Name = "cmb_repairarea";
			this.cmb_repairarea.PartialRightColumn = false;
			this.cmb_repairarea.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_repairarea.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_repairarea.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_repairarea.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_repairarea.TabIndex = 0;
			// 
			// fgrid_moldrepair
			// 
			this.fgrid_moldrepair.AllowDelete = true;
			this.fgrid_moldrepair.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_moldrepair.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_moldrepair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_moldrepair.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_moldrepair.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_moldrepair.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:22;}\t";
			this.fgrid_moldrepair.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_moldrepair.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_moldrepair.Location = new System.Drawing.Point(600, 320);
			this.fgrid_moldrepair.Name = "fgrid_moldrepair";
			this.fgrid_moldrepair.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_moldrepair.Size = new System.Drawing.Size(408, 320);
			this.fgrid_moldrepair.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_moldrepair.TabIndex = 52;
			this.fgrid_moldrepair.CellChanged += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_moldrepair_CellChanged);
			this.fgrid_moldrepair.ComboCloseUp += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_moldrepair_ComboCloseUp);
			this.fgrid_moldrepair.DoubleClick += new System.EventHandler(this.fgrid_moldrepair_DoubleClick);
			// 
			// fgrid_mold
			// 
			this.fgrid_mold.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_mold.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_mold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.fgrid_mold.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_mold.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_mold.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this.fgrid_mold.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_mold.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_mold.Location = new System.Drawing.Point(3, 120);
			this.fgrid_mold.Name = "fgrid_mold";
			this.fgrid_mold.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_mold.Size = new System.Drawing.Size(591, 520);
			this.fgrid_mold.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_mold.TabIndex = 51;
			this.fgrid_mold.DoubleClick += new System.EventHandler(this.fgrid_mold_DoubleClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Location = new System.Drawing.Point(624, 128);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(8, 72);
			this.panel2.TabIndex = 53;
			// 
			// fgrid_err
			// 
			this.fgrid_err.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_err.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_err.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_err.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_err.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_err.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:22;}\t";
			this.fgrid_err.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_err.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_err.Location = new System.Drawing.Point(600, 120);
			this.fgrid_err.Name = "fgrid_err";
			this.fgrid_err.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_err.Size = new System.Drawing.Size(408, 192);
			this.fgrid_err.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_err.TabIndex = 54;
			this.fgrid_err.DoubleClick += new System.EventHandler(this.fgrid_err_DoubleClick);
			// 
			// Form_PB_Mold_Repair
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_err);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.fgrid_moldrepair);
			this.Controls.Add(this.fgrid_mold);
			this.Controls.Add(this.pnel1);
			this.Name = "Form_PB_Mold_Repair";
			this.Text = "Form_PB_Mold_Repair";
			this.Load += new System.EventHandler(this.Form_PB_Mold__Repair_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnel1, 0);
			this.Controls.SetChildIndex(this.fgrid_mold, 0);
			this.Controls.SetChildIndex(this.fgrid_moldrepair, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.fgrid_err, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.CboMold_CD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_repairarea1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_parttype)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_repairarea)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_moldrepair)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_mold)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_err)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PB_Mold__Repair_Load(object sender, System.EventArgs e)
		{
//			COM.ComVar.This_Partcode = "R";
			FlexMold.ClassLib.ComVar.This_Partcode = "R";
			Init_Form();
			FlexMold.ClassLib.ComVar.This_Win_ID = lbl_MainTitle.Text;
			FlexMold.ClassLib.ComVar.This_Computer = Environment.MachineName;
			this.tbtn_New.Enabled = false;
			this.tbtn_Append.Enabled = false;
			this.tbtn_Color.Enabled = false;
			this.tbtn_Insert.Enabled = false;
			this.tbtn_Print.Enabled = false;
		}
		private void Init_Form()
		{
			cbo_factory.Text = "VJ";
			this.lbl_MainTitle.Text = "Mold Repairing Management";
			ClassLib.ComFunction.SetLangDic(this);
			
			fgrid_mold.Set_Grid("SDT_MOLD_LOCATE_MANAGER1", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			
			fgrid_mold.Set_Action_Image(img_Action);
			fgrid_mold.ExtendLastCol = false;
			fgrid_mold.AutoSizeCols();

			fgrid_moldrepair.Set_Grid("SDT_MOLD_REPAIR_TAIL", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_moldrepair.Set_Action_Image(img_Action);
			fgrid_moldrepair.ExtendLastCol = false;
			fgrid_moldrepair.AutoSizeCols();

			fgrid_err.Set_Grid("SDT_MOLD_BASIC_ERROR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_err.Set_Action_Image(img_Action);
			fgrid_err.ExtendLastCol = false;
			fgrid_err.AutoSizeCols();
 
//			DataTable dt_ret = Select_com_filter_code_List("SDV15");
//			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_wh, 0, 1, false, false);

			DataTable dt_ret = Select_com_filter_code_List1("SDV15",ClassLib.ComVar.This_Dept);
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

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_mold.Clear();
			fgrid_mold.Set_Grid("SDT_MOLD_LOCATE_MANAGER1", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			Search_Main();
			FlexMold.ClassLib.ComVar.This_Action ="S" ;
			FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
			FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);

			FlexMold.ClassLib.ComVar.This_Action ="S" ;
			FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
			FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);

			fgrid_moldrepair.Clear();
			fgrid_moldrepair.Set_Grid("SDT_MOLD_REPAIR_TAIL", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_moldrepair.Set_Action_Image(img_Action);
			//_RowFixed_desc = fgrip_main.Rows.Fixed;fgrid_moldrepair
			fgrid_moldrepair.ExtendLastCol = false;
			fgrid_moldrepair.AutoSizeCols();
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
						fgrid_mold.Cols.Frozen = 4;
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

			OraDB.ReDim_Parameter(6); 

			//01.PROCEDURE¸i

			//			OraDB.Process_Name = "PKG_SDT_MOLD.SELECT_MOLD_LOCATE_MANAGER";
			OraDB.Process_Name = "PKG_SDT_MOLD_WH.SELECT_MOLD_LOCATE_MANAGER";

			//02.ARGURMENT ¸i

			OraDB.Parameter_Name[0] = "ARG_FACTORY";

			OraDB.Parameter_Name[1] = "ARG_WH";

			OraDB.Parameter_Name[2] = "ARG_INTYPE";

			OraDB.Parameter_Name[3] = "ARG_DIV";

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

			OraDB.Parameter_Values[1] = cbo_wh.SelectedValue.ToString();

			OraDB.Parameter_Values[2] = "";

			OraDB.Parameter_Values[3] = "M";
			OraDB.Parameter_Values[4] = CboMold_CD.SelectedValue.ToString();
//			OraDB.Parameter_Values[4] = txt_moldcode.Text.Trim().ToString();

			OraDB.Parameter_Values[5] = "" ;


			OraDB.Add_Select_Parameter(true);

			retDS = OraDB.Exe_Select_Procedure();

			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
                  
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
		private void Search_mold_repair()
		{
			DataTable vDt1 = null;
			fgrid_moldrepair.Clear();

			fgrid_moldrepair.Set_Grid("SDT_MOLD_REPAIR_TAIL", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
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
			OraDB.Process_Name = "PKG_SDT_MOLD.SEARCH_MOLD_REPAIR";

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
			OraDB.Parameter_Values[3] = cbo_parttype.SelectedValue.ToString();
			OraDB.Parameter_Values[4] = CboMold_CD.SelectedValue.ToString();
//			OraDB.Parameter_Values[4] = txt_moldcode.Text.Trim();
			OraDB.Parameter_Values[5] = "" ;

			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
			
		}
		private void fgrid_mold_DoubleClick(object sender, System.EventArgs e)
		{
			//move mold that need to repair 
			if(fgrid_mold.ColSel < 4)
			{
				fgrid_moldrepair.Rows.Add();
				fgrid_moldrepair.RowSel = fgrid_moldrepair.Rows.Count -1 ;
				insert_moldrepair(fgrid_moldrepair.RowSel);
				fgrid_mold[fgrid_mold.RowSel,7] ="";
				fgrid_mold[fgrid_mold.RowSel,8] ="REPAIR";
				fgrid_mold[fgrid_mold.RowSel,9] ="";

			}
		}
		private void insert_moldrepair(int rowsel)
		{
			string model_code="";
			string model_name="";
			DataTable vDt1 = null;
						
			try
			{
				vDt1 = SELECT_MOLD_MODEL();    

				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						
						model_code = vDt1.Rows[0].ItemArray[0].ToString();
						model_name = vDt1.Rows[0].ItemArray[1].ToString();
						
					}

				}
				else            
				{
					MessageBox.Show("No Data !!");
					return;
				}
				//for(int i =2; i<fgrid_mold.Rows.Count;i++)
					//fgrid_mold[i,0] = "  ";
			}
			catch
			{

			} 
			fgrid_moldrepair[rowsel,0] = "I";
			fgrid_moldrepair[rowsel,1] = "VJ";
			fgrid_moldrepair[rowsel,2] = cmb_workday.Value.ToString().Substring(0,10);
			fgrid_moldrepair[rowsel,3] = cbo_wh.SelectedValue.ToString();
			fgrid_moldrepair[rowsel,4] = cbo_parttype.SelectedValue.ToString();
			fgrid_moldrepair[rowsel,5] = model_code;
			fgrid_moldrepair[rowsel,6] = model_name;
			fgrid_moldrepair[rowsel,7] = fgrid_mold[fgrid_mold.RowSel,2].ToString();
			fgrid_moldrepair[rowsel,8] = fgrid_mold[fgrid_mold.RowSel,3].ToString();
			fgrid_moldrepair[rowsel,9] = fgrid_mold[fgrid_mold.RowSel,4].ToString();
			fgrid_moldrepair[rowsel,10] = "1";
			fgrid_moldrepair[rowsel,11] = "10";
			fgrid_moldrepair[rowsel,12] = "";
			fgrid_moldrepair[rowsel,13] = "";
			fgrid_moldrepair[rowsel,14] = "";
			fgrid_moldrepair[rowsel,15] = "";
			fgrid_moldrepair[rowsel,16] = "";
			fgrid_moldrepair[rowsel,17] = "30";
			fgrid_moldrepair[rowsel,18] = cmb_repairarea1.SelectedValue.ToString();
			fgrid_moldrepair[rowsel,19] = COM.ComVar.This_User;
			fgrid_moldrepair[rowsel,20] = cmb_workday.Value.ToString().Substring(0,10);
			fgrid_moldrepair.Cols.Frozen = 3;
		}
		private System.Data.DataTable SELECT_MOLD_MODEL()

		{

			System.Data.DataSet retDS;                  

			OraDB.ReDim_Parameter(3); 

			//01.PROCEDURE¸i

			OraDB.Process_Name = "PKG_SDT_MOLD_WH.SEARCH_MOLD_MODEL";

			//02.ARGURMENT ¸i

			OraDB.Parameter_Name[0] = "ARG_FACTORY";

			OraDB.Parameter_Name[1] = "ARG_MOLD_CD";	

			OraDB.Parameter_Name[2] = "OUT_CURSOR";


			//03.DATA TYPE A¤AC

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;

			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;

			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

 
			OraDB.Parameter_Values[0] = cbo_factory.Text.ToString()  ;

			OraDB.Parameter_Values[1] = fgrid_mold[fgrid_mold.RowSel,2].ToString();

			OraDB.Parameter_Values[2] = "" ;


			OraDB.Add_Select_Parameter(true);

			retDS = OraDB.Exe_Select_Procedure();

			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
                  
		}

		private void cbo_wh_SelectedValueChanged(object sender, System.EventArgs e)
		{
//			COM.ComVar.This_Partcode = cbo_wh.SelectedValue.ToString();
//			fgrid_mold.Set_Grid("SDT_MOLD_LOCATE_MANAGER1", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
//			fgrid_mold.Set_Action_Image(img_Action);
//			//_RowFixed_desc = fgrip_main.Rows.Fixed;fgrid_moldrepair
//			fgrid_mold.ExtendLastCol = false;
//			fgrid_mold.AutoSizeCols();
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
			OraDB.Parameter_Values[0] = "VJ";
			OraDB.Parameter_Values[1] = cbo_wh.SelectedValue.ToString();
			
			OraDB.Parameter_Values[2] = "";
			
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
			fgrid_moldrepair[fgrid_moldrepair.RowSel,12] = fgrid_err[fgrid_err.RowSel,2].ToString();
			fgrid_moldrepair[fgrid_moldrepair.RowSel,13] = fgrid_err[fgrid_err.RowSel,3].ToString();
			fgrid_moldrepair[fgrid_moldrepair.RowSel,14] = fgrid_err[fgrid_err.RowSel,5].ToString();
			fgrid_moldrepair[fgrid_moldrepair.RowSel,15] = fgrid_err[fgrid_err.RowSel,4].ToString();
			cost = System.Convert.ToInt32(fgrid_moldrepair[fgrid_moldrepair.RowSel,14].ToString());
			qty  = 1;
			amount = cost * qty;
			fgrid_moldrepair[fgrid_moldrepair.RowSel,16] = amount.ToString();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				for (int i = 2; i < fgrid_moldrepair.Rows.Count; i++)
				{
					if(fgrid_moldrepair[i, 0]!= null)
					{
						if (fgrid_moldrepair[i, 0]== "I") 
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
						else if(fgrid_moldrepair[i, 0]== "U")
						{
							string[] arr_save = new string[fgrid_moldrepair.Cols.Count];
							for(int j=0;j< fgrid_moldrepair.Cols.Count;j++)
							{
								if(fgrid_moldrepair[i,j] != null)
									arr_save[j] = fgrid_moldrepair[i,j].ToString();
								else 
									arr_save[j] = "";
							}
							//save_mold_repair_head(arr_save);  
							save_mold_repair_tail(arr_save);
							save_mold_repair_head(arr_save); 
							//Search_mold_repair();
						}
						else if(fgrid_moldrepair[i, 0]== "D")
						{
							string[] arr_upgrade = new string[fgrid_moldrepair.Cols.Count];
							for(int j=0;j< fgrid_moldrepair.Cols.Count;j++)
							{
								arr_upgrade[j] = fgrid_moldrepair[i,j].ToString();
							}
							//save_mold_repair_head(arr_upgrade);  
							save_mold_repair_tail(arr_upgrade);
							save_mold_repair_head(arr_upgrade); 
							//Search_mold_repair();
						}
					}
					
				}

				FlexMold.ClassLib.ComVar.This_Action ="I" ;
				FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
				FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);

			}
			catch
			{
			}
			finally
			{
			}
			//save_mold_repair_head(arr_save); 
			Search_mold_repair();
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
			//OraDB.Parameter_Name[7]  = "ARG_USE_SIZE";
			//OraDB.Parameter_Name[8]  = "ARG_SEQ";
			//OraDB.Parameter_Name[9]  = "ARG_QTY";
			OraDB.Parameter_Name[7]  = "ARG_AMOUNT";
			OraDB.Parameter_Name[8]  = "ARG_REMARK";
			OraDB.Parameter_Name[9] = "ARG_UPD_USER";
			OraDB.Parameter_Name[10] = "ARG_UPD_YMD";

			

			for(int i=0; i< 11; i++)
			{
				OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}
			 
			OraDB.Parameter_Values[0] = arg_array[0].ToString(); 
			OraDB.Parameter_Values[1] = arg_array[1].ToString(); 
			OraDB.Parameter_Values[2] = arg_array[2].ToString().Replace("-","").Replace("/","").Trim(); 
			OraDB.Parameter_Values[3] = cbo_wh.SelectedValue.ToString(); 
			OraDB.Parameter_Values[4] = arg_array[4].ToString(); 
			OraDB.Parameter_Values[5] = arg_array[5].ToString(); 
			OraDB.Parameter_Values[6] = arg_array[7].ToString(); 
			//OraDB.Parameter_Values[7] = arg_array[8].ToString(); 
			//OraDB.Parameter_Values[8] = arg_array[9].ToString(); 
			//OraDB.Parameter_Values[9] = arg_array[10].ToString();
			OraDB.Parameter_Values[7] = "";
			OraDB.Parameter_Values[8] = arg_array[17].ToString();
			OraDB.Parameter_Values[9] = arg_array[19].ToString();
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
			 
			OraDB.Parameter_Values[0]  = arg_array[0].ToString(); 
			OraDB.Parameter_Values[1]  = arg_array[1].ToString(); 
			OraDB.Parameter_Values[2]  = arg_array[2].ToString().Replace("-","").Replace("/",""); 
			OraDB.Parameter_Values[3]  = cbo_wh.SelectedValue.ToString().Trim(); 
			OraDB.Parameter_Values[4]  = arg_array[4].ToString(); 
			OraDB.Parameter_Values[5]  = arg_array[5].ToString(); 
			OraDB.Parameter_Values[6]  = arg_array[7].ToString(); 
			OraDB.Parameter_Values[7]  = arg_array[8].ToString(); 
			OraDB.Parameter_Values[8]  = arg_array[9].ToString();
//			OraDB.Parameter_Values[9]  = cmb_repairarea1.SelectedValue.ToString();
			OraDB.Parameter_Values[9] = arg_array[18].ToString(); 
			OraDB.Parameter_Values[10] = arg_array[11].ToString();
			OraDB.Parameter_Values[11] = arg_array[10].ToString();
			OraDB.Parameter_Values[12] = arg_array[12].ToString();
			OraDB.Parameter_Values[13] = arg_array[14].ToString();
			OraDB.Parameter_Values[14] = arg_array[15].ToString(); 
			OraDB.Parameter_Values[15] = arg_array[16].ToString();
			OraDB.Parameter_Values[16] = arg_array[17].ToString();

			OraDB.Parameter_Values[17] = arg_array[19].ToString(); 
			OraDB.Parameter_Values[18] = cmb_workday.Text.Substring(0,10).Replace("-","")  ;

			OraDB.Add_Modify_Parameter(true);	
			OraDB.Exe_Modify_Procedure();
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_moldrepair[fgrid_moldrepair.RowSel,0] = "D";
		}

		private void fgrid_moldrepair_CellChanged(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			//MessageBox.Show("OK");
		}

		private void fgrid_moldrepair_DoubleClick(object sender, System.EventArgs e)
		{
			if(fgrid_moldrepair[fgrid_moldrepair.RowSel,0]!= "I")
			{
				fgrid_moldrepair[fgrid_moldrepair.RowSel,0] = "U";
			}
		}

		private void txt_moldcode_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			//if (e.KeyCode = 
		}

		private void txt_moldcode_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Enter)
				{
					Search_mold_repair();
				}
			}
			catch
			{
				this.Cursor = Cursors.Default;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			FlexMold.Management.Form_PB_Mold_Slip fr = new Form_PB_Mold_Slip();
//			fr.MdiParent = this;
			fr.ShowDialog();
//			string mrd_Filename;
//
//			mrd_Filename = FlexMold.ClassLib.ComFunction.Set_RD_Directory("Form_Mold_Repairing_Req");
//
//			string Para = " ";
//
//			int iCnt = 5;
//
//			string [] aHead = new string[iCnt]; 
//
//			string[] vProviso = GetSearchProviso();
//			
//			aHead[0] = cbo_factory.Text;
//			aHead[1] = cbo_wh.SelectedValue.ToString();
//			aHead[2] = cmb_workday.Text.Replace("-","").Replace("/","");
//			aHead[3] = cbo_parttype.SelectedValue.ToString();
//			aHead[4] = txt_moldcode.Text;
//
//			Para = " /rp ";
//
//			for (int i = 1 ; i<= iCnt ; i++)
//			{ 
//				Para = Para + "[" + aHead[i-1] + "] ";
//			}
//
//			FlexMold.Report.Form_RdViewer report = new FlexMold.Report.Form_RdViewer (mrd_Filename, Para);
//
//			report.Show(); 
		}

		private string[] GetSearchProviso()
		{
			string[] vProviso = new string[30];

			// for (int i=1 ; i <= fgrid_main.Cols.Count-1 ; i++)

			// {

			// for (int j=1 ; j <= fgrid_main.Cols.Count ; j++)

			// vProviso[i-1] = fgrid_main[2,i].ToString();

			// }

			// vProviso[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");

			return vProviso;
		}

		private void fgrid_moldrepair_ComboCloseUp(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(fgrid_moldrepair[fgrid_moldrepair.RowSel,0]!= "I" )			
			fgrid_moldrepair[fgrid_moldrepair.RowSel,0] = "U";
		}

		private void btn_Search_Click(object sender, System.EventArgs e)
		{
//			fgrid_err.Clear();
//			fgrid_err.Set_Grid("SDT_MOLD_BASIC_ERROR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
//			Search_err();
			Search_mold_repair();	
			FlexMold.ClassLib.ComVar.This_Action ="S" ;
			FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
			FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);
		}

		private void cbo_parttype_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Search_err();						
		}

		

		
	}
}

