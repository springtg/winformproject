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
	public class Form_PB_Mold_Moving_Paper : COM.MoldWinForm.Form_Top
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTot;
		private C1.Win.C1List.C1Combo cbo_Wh_to;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtp_Out;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private C1.Win.C1List.C1Combo cbo_Out_type;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1List.C1Combo cbo_wh;
		private System.Windows.Forms.Label label12;
		private C1.Win.C1List.C1Combo cbo_factory;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo cbo_Mold_CD;
		private System.ComponentModel.IContainer components = null;
		public COM.FSP fgrid_main;

		private COM.OraDB OraDB = new COM.OraDB();
		private System.Data.DataTable dt_list;

		public Form_PB_Mold_Moving_Paper()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_Moving_Paper));
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbo_Mold_CD = new C1.Win.C1List.C1Combo();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTot = new System.Windows.Forms.TextBox();
			this.cbo_Wh_to = new C1.Win.C1List.C1Combo();
			this.label6 = new System.Windows.Forms.Label();
			this.dtp_Out = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbo_Out_type = new C1.Win.C1List.C1Combo();
			this.label2 = new System.Windows.Forms.Label();
			this.cbo_wh = new C1.Win.C1List.C1Combo();
			this.label12 = new System.Windows.Forms.Label();
			this.cbo_factory = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.fgrid_main = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbo_Mold_CD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_Wh_to)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_Out_type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).BeginInit();
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
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.cbo_Mold_CD);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtTot);
			this.panel1.Controls.Add(this.cbo_Wh_to);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.dtp_Out);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.cbo_Out_type);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cbo_wh);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.cbo_factory);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 72);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 72);
			this.panel1.TabIndex = 30;
			// 
			// cbo_Mold_CD
			// 
			this.cbo_Mold_CD.AddItemCols = 0;
			this.cbo_Mold_CD.AddItemSeparator = ';';
			this.cbo_Mold_CD.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_Mold_CD.Caption = "";
			this.cbo_Mold_CD.CaptionHeight = 17;
			this.cbo_Mold_CD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_Mold_CD.ColumnCaptionHeight = 17;
			this.cbo_Mold_CD.ColumnFooterHeight = 17;
			this.cbo_Mold_CD.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbo_Mold_CD.ContentHeight = 17;
			this.cbo_Mold_CD.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_Mold_CD.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_Mold_CD.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_Mold_CD.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_Mold_CD.EditorHeight = 17;
			this.cbo_Mold_CD.GapHeight = 2;
			this.cbo_Mold_CD.ItemHeight = 15;
			this.cbo_Mold_CD.Location = new System.Drawing.Point(600, 8);
			this.cbo_Mold_CD.MatchEntryTimeout = ((long)(2000));
			this.cbo_Mold_CD.MaxDropDownItems = ((short)(5));
			this.cbo_Mold_CD.MaxLength = 32767;
			this.cbo_Mold_CD.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_Mold_CD.Name = "cbo_Mold_CD";
			this.cbo_Mold_CD.PartialRightColumn = false;
			this.cbo_Mold_CD.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_Mold_CD.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_Mold_CD.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_Mold_CD.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_Mold_CD.Size = new System.Drawing.Size(280, 23);
			this.cbo_Mold_CD.TabIndex = 83;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(891, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 24);
			this.label3.TabIndex = 82;
			this.label3.Text = "Tot Out";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// txtTot
			// 
			this.txtTot.Enabled = false;
			this.txtTot.Location = new System.Drawing.Point(960, 40);
			this.txtTot.Name = "txtTot";
			this.txtTot.Size = new System.Drawing.Size(48, 22);
			this.txtTot.TabIndex = 81;
			this.txtTot.Text = "";
			// 
			// cbo_Wh_to
			// 
			this.cbo_Wh_to.AddItemCols = 0;
			this.cbo_Wh_to.AddItemSeparator = ';';
			this.cbo_Wh_to.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_Wh_to.Caption = "";
			this.cbo_Wh_to.CaptionHeight = 17;
			this.cbo_Wh_to.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_Wh_to.ColumnCaptionHeight = 17;
			this.cbo_Wh_to.ColumnFooterHeight = 17;
			this.cbo_Wh_to.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbo_Wh_to.ContentHeight = 17;
			this.cbo_Wh_to.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_Wh_to.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_Wh_to.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_Wh_to.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_Wh_to.EditorHeight = 17;
			this.cbo_Wh_to.GapHeight = 2;
			this.cbo_Wh_to.ItemHeight = 15;
			this.cbo_Wh_to.Location = new System.Drawing.Point(600, 40);
			this.cbo_Wh_to.MatchEntryTimeout = ((long)(2000));
			this.cbo_Wh_to.MaxDropDownItems = ((short)(5));
			this.cbo_Wh_to.MaxLength = 32767;
			this.cbo_Wh_to.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_Wh_to.Name = "cbo_Wh_to";
			this.cbo_Wh_to.PartialRightColumn = false;
			this.cbo_Wh_to.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_Wh_to.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_Wh_to.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_Wh_to.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_Wh_to.Size = new System.Drawing.Size(128, 23);
			this.cbo_Wh_to.TabIndex = 80;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(504, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 21);
			this.label6.TabIndex = 77;
			this.label6.Text = "To W/h";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtp_Out
			// 
			this.dtp_Out.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_Out.Location = new System.Drawing.Point(80, 35);
			this.dtp_Out.Name = "dtp_Out";
			this.dtp_Out.Size = new System.Drawing.Size(112, 22);
			this.dtp_Out.TabIndex = 73;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(8, 37);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 21);
			this.label5.TabIndex = 72;
			this.label5.Text = "Out_Date";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(240, 11);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 21);
			this.label4.TabIndex = 71;
			this.label4.Text = "Outgoing type";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbo_Out_type
			// 
			this.cbo_Out_type.AddItemCols = 0;
			this.cbo_Out_type.AddItemSeparator = ';';
			this.cbo_Out_type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_Out_type.Caption = "";
			this.cbo_Out_type.CaptionHeight = 17;
			this.cbo_Out_type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_Out_type.ColumnCaptionHeight = 17;
			this.cbo_Out_type.ColumnFooterHeight = 17;
			this.cbo_Out_type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbo_Out_type.ContentHeight = 17;
			this.cbo_Out_type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_Out_type.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_Out_type.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_Out_type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_Out_type.EditorHeight = 17;
			this.cbo_Out_type.GapHeight = 2;
			this.cbo_Out_type.ItemHeight = 15;
			this.cbo_Out_type.Location = new System.Drawing.Point(344, 8);
			this.cbo_Out_type.MatchEntryTimeout = ((long)(2000));
			this.cbo_Out_type.MaxDropDownItems = ((short)(5));
			this.cbo_Out_type.MaxLength = 32767;
			this.cbo_Out_type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_Out_type.Name = "cbo_Out_type";
			this.cbo_Out_type.PartialRightColumn = false;
			this.cbo_Out_type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_Out_type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_Out_type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_Out_type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_Out_type.Size = new System.Drawing.Size(128, 23);
			this.cbo_Out_type.TabIndex = 0;
			this.cbo_Out_type.SelectedValueChanged += new System.EventHandler(this.cbo_Out_type_SelectedValueChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(504, 8);
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
			this.cbo_wh.Location = new System.Drawing.Point(344, 40);
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
			this.cbo_wh.TabIndex = 63;
			this.cbo_wh.SelectedValueChanged += new System.EventHandler(this.cbo_wh_SelectedValueChanged);
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Blue;
			this.label12.Location = new System.Drawing.Point(248, 43);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(88, 18);
			this.label12.TabIndex = 62;
			this.label12.Text = "Out W/h";
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
			this.cbo_factory.Size = new System.Drawing.Size(152, 23);
			this.cbo_factory.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Factory";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fgrid_main
			// 
			this.fgrid_main.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_main.BackColor = System.Drawing.Color.Transparent;
			this.fgrid_main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_main.ColumnInfo = "30,0,0,0,0,95,Columns:0{Width:29;}\t";
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(0, 144);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Rows.Count = 27;
			this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
			this.fgrid_main.Size = new System.Drawing.Size(1016, 496);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:Transparent;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{Font:Verdana, 11.25pt, style=Bold;BackColor:255, 255, 192;ForeColor:Red;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 51;
			// 
			// Form_PB_Mold_Moving_Paper
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_main);
			this.Controls.Add(this.panel1);
			this.Name = "Form_PB_Mold_Moving_Paper";
			this.Text = "Mold_Moving_Paper";
			this.Load += new System.EventHandler(this.Form_PB_Mold_Moving_Paper_Load);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.fgrid_main, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cbo_Mold_CD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_Wh_to)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_Out_type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PB_Mold_Moving_Paper_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			FlexMold.ClassLib.ComVar.This_Win_ID = lbl_MainTitle.Text;
			FlexMold.ClassLib.ComVar.This_Computer = Environment.MachineName;
			tbtn_Insert.Enabled = false;
			tbtn_Save.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Color.Enabled = false;
			tbtn_New.Enabled = false;
			cbo_Out_type.Focus();

		}

		private void Init_Form()	
		{
			this.lbl_MainTitle.Text = "Mold Outgoing Paper";
			ClassLib.ComFunction.SetLangDic(this);

			DataTable dt_ret = Select_com_filter_code_List("SBC21");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_factory, 0, 1, false, false);
			cbo_factory.SelectedValue = "VJ";
			dt_ret = Select_com_filter_code_List("SDV35");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_Out_type, 0, 1, false, false);

			dt_ret = Select_com_filter_code_List1("SDV15",ClassLib.ComVar.This_Dept);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_wh, 0, 1, false, false);

			dt_ret = Select_com_filter_code_List("SDV15");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_Wh_to, 0, 1, false, false);

			fgrid_main.Tree.Column = 0;
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

		private void label3_Click(object sender, System.EventArgs e)
		{
		
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DisplaceDetail();	
		}

		private void DisplaceDetail()
		{			
			Search_Seq_Stand();
			Search_Size();
			FlexMold.ClassLib.ComVar.This_Action ="S" ;
			FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
			FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);
			Search_Seq();
			Select_tot();
			SubTotalGrid();
		}
		private void SubTotalGrid()
		{
			fgrid_main.Subtotal(AggregateEnum.Clear);
			fgrid_main.SubtotalPosition = SubtotalPositionEnum.BelowData;
			for (int j = 1 ; j < fgrid_main.Cols.Count ; j++)
			{
				if (fgrid_main[0,j] != null)
					fgrid_main.Subtotal(AggregateEnum.Count, -1, -1, j, "GTotal");
			}
			fgrid_main.AutoSizeCols();
		}

		private void Search_Seq_Stand()
		{
			System.Data.DataTable vDt = null;
			try
			{
				

				vDt = SELECT_MOLD_SEQ_STAND();    
				fgrid_main.Clear();    
				if(vDt.Rows.Count > 0)
				{
					for(int i = 0; i < vDt.Rows.Count ; i++)
					{
						fgrid_main.Rows.Count  = vDt.Rows.Count + 1 ; 						
						fgrid_main[i+1,0] = vDt.Rows[i].ItemArray[0].ToString() ;						
					}
				}
				else
				{
					
				}
				vDt.Dispose();
			}
			finally
			{
				if (vDt != null) 
					vDt.Dispose();
			}	
		}
		private System.Data.DataTable SELECT_MOLD_SEQ_STAND()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
//			if ((cbo_Out_type.SelectedValue.ToString() == "10")||(cbo_Out_type.SelectedValue.ToString() == "3"))
				OraDB.Process_Name = "PKG_SDT_MOLD.SEARCH_OUTTAIL_SEQ";
//			else	
//				OraDB.Process_Name = "PKG_SDT_MOLD.SEARCH_INTAIL_SEQ";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_MOLD_CD";

			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
					
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = cbo_factory.SelectedValue.ToString();
//			OraDB.Parameter_Values[1] = txt_mold.Text.Trim();
			OraDB.Parameter_Values[1] = cbo_Mold_CD.SelectedValue.ToString();
			OraDB.Parameter_Values[2] = "";
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;
			return retDS.Tables[OraDB.Process_Name];
		}

		private void Search_Size()
		{
			System.Data.DataTable vDt = null;
			try
			{
				vDt = SELECT_MOLD_SIZE();    
				if(vDt.Rows.Count > 0)
				{
					for(int i = 0; i < vDt.Rows.Count ; i++)
					{
//						fgrid_main.Cols.Count  = vDt.Rows.Count + 1 ; 						
						fgrid_main[0,i+1] = vDt.Rows[i].ItemArray[0].ToString() ;						
						fgrid_main.AutoSizeCols();
						fgrid_main.Cols[i+1].TextAlign = TextAlignEnum.CenterCenter;
					}
				}
				else
				{
				}
				vDt.Dispose();
			}
			finally
			{
				if (vDt != null) 
					vDt.Dispose();
			}	
		}

		private System.Data.DataTable SELECT_MOLD_SIZE()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD.SEARCH_TAIL_SIZE";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_PUR_NU";
			OraDB.Parameter_Name[2] = "ARG_MOLD_CD";
			OraDB.Parameter_Name[3] = "ARG_DIVISION";
			OraDB.Parameter_Name[4] = "ARG_WH_CD";

			OraDB.Parameter_Name[5] = "OUT_CURSOR";
			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
					
			OraDB.Parameter_Type[5] = (int)OracleType.Cursor;
			//04.DATA 정의
			OraDB.Parameter_Values[0] = cbo_factory.SelectedValue.ToString();
			OraDB.Parameter_Values[1] = "";
//			OraDB.Parameter_Values[2] = txt_mold.Text.Trim() ;
			OraDB.Parameter_Values[2] = cbo_Mold_CD.SelectedValue.ToString();
	
			if (cbo_Out_type.SelectedValue.ToString() == "6") //ORDER IN
				OraDB.Parameter_Values[3] = "1";
			else if (cbo_Out_type.SelectedValue.ToString() == "8")
				OraDB.Parameter_Values[3] = "3 8";
			else if (cbo_Out_type.SelectedValue.ToString() == "16")
				OraDB.Parameter_Values[3] = "316";
			else if (cbo_Out_type.SelectedValue.ToString() == "10")
				OraDB.Parameter_Values[3] = "310";
			else if (cbo_Out_type.SelectedValue.ToString() == "18")
				OraDB.Parameter_Values[3] = "318";
			else if (cbo_Out_type.SelectedValue.ToString() == "13")
				OraDB.Parameter_Values[3] = "313";	
			else if (cbo_Out_type.SelectedValue.ToString() == "3")
				OraDB.Parameter_Values[3] = "3 3";
			else
				OraDB.Parameter_Values[3] = "2";
			if ((cbo_Out_type.SelectedValue.ToString() == "10")||(cbo_Out_type.SelectedValue.ToString() == "3"))
				OraDB.Parameter_Values[4] = cbo_wh.SelectedValue.ToString();
//			OraDB.Parameter_Values[4] = cbo_wh.SelectedValue.ToString();
			else
			OraDB.Parameter_Values[4] = cbo_Wh_to.SelectedValue.ToString();
		
			OraDB.Parameter_Values[5] = "";
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
		}

		private void Search_Seq()
		{
			System.Data.DataTable vDt = null;
			string [] _usesize = null;
			char [] _determid ="/".ToCharArray();
			try
			{
				vDt = SELECT_MOLD_SEQ();    
				if(vDt.Rows.Count > 0)
				{				
					for(int i = 0; i < vDt.Rows.Count ; i++)
					{
						for (int k = 0 ; k < fgrid_main.Cols.Count-1 ; k++)
						{
							if(fgrid_main[0,k+1] != null)
							{
								_usesize = fgrid_main[0,k+1].ToString().Split(_determid);								
								if (vDt.Rows[i].ItemArray[1].ToString() == _usesize[0])
								{
									for (int j = 0 ; j <fgrid_main.Rows.Count -1 ; j++)
									{
										if (vDt.Rows[i].ItemArray[0].ToString()== fgrid_main[j+1,0].ToString())								
											fgrid_main[j+1,k+1] = vDt.Rows[i].ItemArray[2].ToString();
									}
								}
							}
						}
					}
				}
				else
				{
				}
				vDt.Dispose();
			}
			finally
			{
				if (vDt != null) 
					vDt.Dispose();
			}	
		}

		private System.Data.DataTable SELECT_MOLD_SEQ()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD.SEARCH_TAIL_SEQ";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_PUR_NU";
			OraDB.Parameter_Name[2] = "ARG_MOLD_CD";
			OraDB.Parameter_Name[3] = "ARG_DIVISION";
			OraDB.Parameter_Name[4] = "ARG_WH_CD";

			OraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
					
			OraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = cbo_factory.SelectedValue.ToString();
			OraDB.Parameter_Values[1] = "" ;
//			OraDB.Parameter_Values[2] = txt_mold.Text.Trim();
			OraDB.Parameter_Values[2] = cbo_Mold_CD.SelectedValue.ToString();
			
			if (cbo_Out_type.SelectedValue.ToString() == "6")
				OraDB.Parameter_Values[3] = "1";
			else if (cbo_Out_type.SelectedValue.ToString() == "8")
				OraDB.Parameter_Values[3] = "3 8";
			else if (cbo_Out_type.SelectedValue.ToString() == "16")
				OraDB.Parameter_Values[3] = "316";
			else if (cbo_Out_type.SelectedValue.ToString() == "10")
				OraDB.Parameter_Values[3] = "310";
			else if (cbo_Out_type.SelectedValue.ToString() == "18")
				OraDB.Parameter_Values[3] = "318";
			else if (cbo_Out_type.SelectedValue.ToString() == "13")
				OraDB.Parameter_Values[3] = "313";
			else if (cbo_Out_type.SelectedValue.ToString() == "3")
				OraDB.Parameter_Values[3] = "3 3";
			else
				OraDB.Parameter_Values[3] = "2";
			
			if ((cbo_Out_type.SelectedValue.ToString() == "10")||(cbo_Out_type.SelectedValue.ToString() == "3"))
				OraDB.Parameter_Values[4] = cbo_wh.SelectedValue.ToString();
			else
//			OraDB.Parameter_Values[4] = cbo_wh.SelectedValue.ToString();
				OraDB.Parameter_Values[4] = cbo_Wh_to.SelectedValue.ToString();
			OraDB.Parameter_Values[5] = "";
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
		}
		
		private void Select_tot()
		{
			int k = 0;
			for (int i = 0; i < fgrid_main.Cols.Count-1 ; i++)
			{
				for (int j= 0 ; j<fgrid_main.Rows.Count -1 ;j++)
				{
					if (fgrid_main[j+1,i+1]!= null && fgrid_main[j+1,i+1]!= "")
					{
						if ( fgrid_main[j+1,i+1].ToString() =="G")
						{
							k = k + 1 ;
						}
					}  
					else
					{
					}
				}
			}
			txtTot.Text = k.ToString();
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{			
			fgrid_main.AddItem("",0);	
			
			string filename = this.Name + ".txt";
			FileInfo file = new FileInfo(filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}

			file = null;
			
            //fgrid_main.SaveGrid(filename, FileFormatEnum.TextComma, false);
            fgrid_main.SaveGrid(filename, FileFormatEnum.TextComma);

			string mold_code = cbo_Out_type.Text; //cbo_Mold_CD.Text;

			string mold_wh = cbo_wh.Text;

			string mold_wh_to = cbo_Wh_to.Text;

			string Total = txtTot.Text ;

			string out_type = cbo_Mold_CD.Text; // cbo_Out_type.Text ;
	
			string para = "/rfn [" + Application.StartupPath + @"\" + this.Name + ".txt] /rv V_MTYPE[" + mold_code + "] V_MWH_TO[" + mold_wh_to + "] V_OTYPE[" + out_type + "] V_MWH[" + mold_wh
						+ "] V_TOT[" + Total + "]";
			COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report("MOLD IN & OUT", this.Name +".mrd", para);
			report.ShowDialog();
			fgrid_main.RemoveItem(0);
		}

		private void cbo_wh_SelectedValueChanged(object sender, System.EventArgs e)
		{
			dt_list = Select_Mold();
			COM.ComCtl.Set_ComboList(dt_list, cbo_Mold_CD, 0, 1, true);  			
			cbo_Mold_CD.SelectedIndex = 0;
		}

		private System.Data.DataTable Select_Mold()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD_WH.SELECT_MOLD_CD_OUT";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_WH_CD";
			OraDB.Parameter_Name[2] = "ARG_WH_CD_TO";
			OraDB.Parameter_Name[3] = "ARG_OUT_TYPE";
			OraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			
			OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = cbo_factory.SelectedValue.ToString();
			OraDB.Parameter_Values[1] = cbo_wh.SelectedValue.ToString();
			if (cbo_Wh_to.Text == "")
				OraDB.Parameter_Values[2] = "";
			else
				OraDB.Parameter_Values[2] = cbo_Wh_to.SelectedValue.ToString();
			OraDB.Parameter_Values[3] = cbo_Out_type.SelectedValue.ToString();

			OraDB.Parameter_Values[4] = "";
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
		}

		private void cbo_Out_type_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (cbo_wh.Text != "")
			{
				dt_list = Select_Mold();
				COM.ComCtl.Set_ComboList(dt_list, cbo_Mold_CD, 0, 1, true);  			
				cbo_Mold_CD.SelectedIndex = 0;
			}
		}


	}
}


