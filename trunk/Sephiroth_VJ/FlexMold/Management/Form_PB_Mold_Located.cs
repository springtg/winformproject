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
	public class Form_PB_Mold_Located : COM.MoldWinForm.Form_Top
	{
		public COM.FSP fgrid_main;
		private C1.Win.C1List.C1Combo cbo_intype;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_intype;
		private C1.Win.C1List.C1Combo cbo_factory;
		private C1.Win.C1List.C1Combo cbo_wh;
		private C1.Win.C1List.C1Combo cbo_Incom_type;
		private System.ComponentModel.IContainer components = null;
		public COM.FSP fgrid_wh;
		private C1.Win.C1Command.C1ContextMenu cmenu_diagram;
		private C1.Win.C1Command.C1CommandLink c1CommandLink9;
		private C1.Win.C1Command.C1Command c1Command1;
		private C1.Win.C1Command.C1CommandLink c1CommandLink10;
		private C1.Win.C1Command.C1Command c1Command2;
		private C1.Win.C1Command.C1CommandLink c1CommandLink11;
		private C1.Win.C1Command.C1Command c1Command3;
		private System.Windows.Forms.Label lbl_moldcode;
		private System.Windows.Forms.TextBox txt_moldcode;
		private System.Windows.Forms.Label lbl_rank;
		private System.Windows.Forms.Label lbl_shelf;
		private System.Windows.Forms.Label lbl_level;
		private C1.Win.C1List.C1Combo cbo_shelf;
		private C1.Win.C1List.C1Combo cbo_level;
		private System.Windows.Forms.Button btn_wh;
		private System.Windows.Forms.TextBox txtTot;
		private C1.Win.C1List.C1Combo cbo_area;
		private System.Windows.Forms.Label lbl_wp;
		private System.Windows.Forms.Panel pnel1;
		private C1.Win.C1List.C1Combo cbo_rank;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel pnel3;
		private System.Windows.Forms.Panel pnel2;
		private C1.Win.C1List.C1Combo cbo_mc;
		private C1.Win.C1List.C1Combo cbo_sec;
		private System.Windows.Forms.Button btn_sf;
		private System.Windows.Forms.TextBox txtPro_Out;
		private System.Windows.Forms.TextBox txtOther;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private C1.Win.C1List.C1Combo CboMold_CD;
		
		private System.Data.DataTable dt_list;
		private COM.OraDB OraDB = new COM.OraDB();

		public Form_PB_Mold_Located()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_Located));
			this.pnel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtOther = new System.Windows.Forms.TextBox();
			this.txtPro_Out = new System.Windows.Forms.TextBox();
			this.pnel3 = new System.Windows.Forms.Panel();
			this.cbo_mc = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.cbo_sec = new C1.Win.C1List.C1Combo();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_sf = new System.Windows.Forms.Button();
			this.pnel2 = new System.Windows.Forms.Panel();
			this.cbo_rank = new C1.Win.C1List.C1Combo();
			this.lbl_level = new System.Windows.Forms.Label();
			this.cbo_level = new C1.Win.C1List.C1Combo();
			this.lbl_rank = new System.Windows.Forms.Label();
			this.lbl_shelf = new System.Windows.Forms.Label();
			this.cbo_shelf = new C1.Win.C1List.C1Combo();
			this.btn_wh = new System.Windows.Forms.Button();
			this.lbl_wp = new System.Windows.Forms.Label();
			this.cbo_area = new C1.Win.C1List.C1Combo();
			this.txtTot = new System.Windows.Forms.TextBox();
			this.txt_moldcode = new System.Windows.Forms.TextBox();
			this.lbl_moldcode = new System.Windows.Forms.Label();
			this.cbo_Incom_type = new C1.Win.C1List.C1Combo();
			this.cbo_wh = new C1.Win.C1List.C1Combo();
			this.cbo_factory = new C1.Win.C1List.C1Combo();
			this.lbl_intype = new System.Windows.Forms.Label();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.CboMold_CD = new C1.Win.C1List.C1Combo();
			this.cbo_intype = new C1.Win.C1List.C1Combo();
			this.fgrid_main = new COM.FSP();
			this.fgrid_wh = new COM.FSP();
			this.cmenu_diagram = new C1.Win.C1Command.C1ContextMenu();
			this.c1CommandLink9 = new C1.Win.C1Command.C1CommandLink();
			this.c1Command1 = new C1.Win.C1Command.C1Command();
			this.c1CommandLink10 = new C1.Win.C1Command.C1CommandLink();
			this.c1Command2 = new C1.Win.C1Command.C1Command();
			this.c1CommandLink11 = new C1.Win.C1Command.C1CommandLink();
			this.c1Command3 = new C1.Win.C1Command.C1Command();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnel1.SuspendLayout();
			this.pnel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbo_mc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_sec)).BeginInit();
			this.pnel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbo_rank)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_level)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_shelf)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_area)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_Incom_type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CboMold_CD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_intype)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_wh)).BeginInit();
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
			this.c1CommandHolder1.Commands.Add(this.cmenu_diagram);
			this.c1CommandHolder1.Commands.Add(this.c1Command1);
			this.c1CommandHolder1.Commands.Add(this.c1Command2);
			this.c1CommandHolder1.Commands.Add(this.c1Command3);
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
			// pnel1
			// 
			this.pnel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnel1.BackColor = System.Drawing.Color.Transparent;
			this.pnel1.Controls.Add(this.label5);
			this.pnel1.Controls.Add(this.label4);
			this.pnel1.Controls.Add(this.label3);
			this.pnel1.Controls.Add(this.txtOther);
			this.pnel1.Controls.Add(this.txtPro_Out);
			this.pnel1.Controls.Add(this.pnel3);
			this.pnel1.Controls.Add(this.pnel2);
			this.pnel1.Controls.Add(this.lbl_wp);
			this.pnel1.Controls.Add(this.cbo_area);
			this.pnel1.Controls.Add(this.txtTot);
			this.pnel1.Controls.Add(this.txt_moldcode);
			this.pnel1.Controls.Add(this.lbl_moldcode);
			this.pnel1.Controls.Add(this.cbo_Incom_type);
			this.pnel1.Controls.Add(this.cbo_wh);
			this.pnel1.Controls.Add(this.cbo_factory);
			this.pnel1.Controls.Add(this.lbl_intype);
			this.pnel1.Controls.Add(this.lbl_factory);
			this.pnel1.Controls.Add(this.CboMold_CD);
			this.pnel1.Location = new System.Drawing.Point(8, 56);
			this.pnel1.Name = "pnel1";
			this.pnel1.Size = new System.Drawing.Size(1000, 72);
			this.pnel1.TabIndex = 28;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(600, 4);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 29);
			this.label5.TabIndex = 24;
			this.label5.Text = "Re   pair";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(565, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 29);
			this.label4.TabIndex = 23;
			this.label4.Text = "Out  Prod";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Magenta;
			this.label3.Location = new System.Drawing.Point(531, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 29);
			this.label3.TabIndex = 22;
			this.label3.Text = "In Wh";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtOther
			// 
			this.txtOther.Enabled = false;
			this.txtOther.ForeColor = System.Drawing.Color.Red;
			this.txtOther.Location = new System.Drawing.Point(598, 40);
			this.txtOther.Name = "txtOther";
			this.txtOther.Size = new System.Drawing.Size(32, 22);
			this.txtOther.TabIndex = 21;
			this.txtOther.Text = "";
			this.txtOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtPro_Out
			// 
			this.txtPro_Out.Enabled = false;
			this.txtPro_Out.ForeColor = System.Drawing.Color.Red;
			this.txtPro_Out.Location = new System.Drawing.Point(564, 40);
			this.txtPro_Out.Name = "txtPro_Out";
			this.txtPro_Out.Size = new System.Drawing.Size(32, 22);
			this.txtPro_Out.TabIndex = 20;
			this.txtPro_Out.Text = "";
			this.txtPro_Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pnel3
			// 
			this.pnel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnel3.Controls.Add(this.cbo_mc);
			this.pnel3.Controls.Add(this.label1);
			this.pnel3.Controls.Add(this.cbo_sec);
			this.pnel3.Controls.Add(this.label2);
			this.pnel3.Controls.Add(this.btn_sf);
			this.pnel3.Location = new System.Drawing.Point(648, 0);
			this.pnel3.Name = "pnel3";
			this.pnel3.Size = new System.Drawing.Size(352, 72);
			this.pnel3.TabIndex = 19;
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
			this.cbo_sec.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_sec.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_sec.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_sec.Size = new System.Drawing.Size(96, 23);
			this.cbo_sec.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(6, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 8;
			this.label2.Text = "M/C(May)";
			// 
			// btn_sf
			// 
			this.btn_sf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_sf.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn_sf.Location = new System.Drawing.Point(191, 33);
			this.btn_sf.Name = "btn_sf";
			this.btn_sf.Size = new System.Drawing.Size(152, 24);
			this.btn_sf.TabIndex = 14;
			this.btn_sf.Text = "S/F Info";
			this.btn_sf.Click += new System.EventHandler(this.btn_sf_Click);
			// 
			// pnel2
			// 
			this.pnel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnel2.Controls.Add(this.cbo_rank);
			this.pnel2.Controls.Add(this.lbl_level);
			this.pnel2.Controls.Add(this.cbo_level);
			this.pnel2.Controls.Add(this.lbl_rank);
			this.pnel2.Controls.Add(this.lbl_shelf);
			this.pnel2.Controls.Add(this.cbo_shelf);
			this.pnel2.Controls.Add(this.btn_wh);
			this.pnel2.Location = new System.Drawing.Point(648, 0);
			this.pnel2.Name = "pnel2";
			this.pnel2.Size = new System.Drawing.Size(360, 72);
			this.pnel2.TabIndex = 18;
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
			this.cbo_shelf.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_shelf.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_shelf.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_shelf.Size = new System.Drawing.Size(97, 23);
			this.cbo_shelf.TabIndex = 12;
			this.cbo_shelf.SelectedValueChanged += new System.EventHandler(this.cbo_shelf_SelectedValueChanged);
			// 
			// btn_wh
			// 
			this.btn_wh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_wh.Location = new System.Drawing.Point(199, 33);
			this.btn_wh.Name = "btn_wh";
			this.btn_wh.Size = new System.Drawing.Size(152, 24);
			this.btn_wh.TabIndex = 14;
			this.btn_wh.Text = "WH Info";
			this.btn_wh.Click += new System.EventHandler(this.btn_wh_Click);
			// 
			// lbl_wp
			// 
			this.lbl_wp.Location = new System.Drawing.Point(184, 8);
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
			this.cbo_area.Location = new System.Drawing.Point(376, 8);
			this.cbo_area.MatchEntryTimeout = ((long)(2000));
			this.cbo_area.MaxDropDownItems = ((short)(5));
			this.cbo_area.MaxLength = 32767;
			this.cbo_area.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_area.Name = "cbo_area";
			this.cbo_area.PartialRightColumn = false;
			this.cbo_area.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_area.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_area.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_area.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_area.Size = new System.Drawing.Size(112, 23);
			this.cbo_area.TabIndex = 16;
			this.cbo_area.SelectedValueChanged += new System.EventHandler(this.cbo_area_SelectedValueChanged);
			// 
			// txtTot
			// 
			this.txtTot.Enabled = false;
			this.txtTot.Location = new System.Drawing.Point(530, 40);
			this.txtTot.Name = "txtTot";
			this.txtTot.Size = new System.Drawing.Size(32, 22);
			this.txtTot.TabIndex = 15;
			this.txtTot.Text = "";
			this.txtTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txt_moldcode
			// 
			this.txt_moldcode.Location = new System.Drawing.Point(424, 40);
			this.txt_moldcode.Name = "txt_moldcode";
			this.txt_moldcode.Size = new System.Drawing.Size(104, 22);
			this.txt_moldcode.TabIndex = 7;
			this.txt_moldcode.Text = "";
			this.txt_moldcode.Visible = false;
			// 
			// lbl_moldcode
			// 
			this.lbl_moldcode.Location = new System.Drawing.Point(184, 43);
			this.lbl_moldcode.Name = "lbl_moldcode";
			this.lbl_moldcode.Size = new System.Drawing.Size(75, 16);
			this.lbl_moldcode.TabIndex = 6;
			this.lbl_moldcode.Text = "Mold Code";
			// 
			// cbo_Incom_type
			// 
			this.cbo_Incom_type.AddItemCols = 0;
			this.cbo_Incom_type.AddItemSeparator = ';';
			this.cbo_Incom_type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_Incom_type.Caption = "";
			this.cbo_Incom_type.CaptionHeight = 17;
			this.cbo_Incom_type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_Incom_type.ColumnCaptionHeight = 17;
			this.cbo_Incom_type.ColumnFooterHeight = 17;
			this.cbo_Incom_type.ContentHeight = 17;
			this.cbo_Incom_type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_Incom_type.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_Incom_type.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_Incom_type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_Incom_type.EditorHeight = 17;
			this.cbo_Incom_type.GapHeight = 2;
			this.cbo_Incom_type.ItemHeight = 15;
			this.cbo_Incom_type.Location = new System.Drawing.Point(72, 40);
			this.cbo_Incom_type.MatchEntryTimeout = ((long)(2000));
			this.cbo_Incom_type.MaxDropDownItems = ((short)(5));
			this.cbo_Incom_type.MaxLength = 32767;
			this.cbo_Incom_type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_Incom_type.Name = "cbo_Incom_type";
			this.cbo_Incom_type.PartialRightColumn = false;
			this.cbo_Incom_type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_Incom_type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_Incom_type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_Incom_type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_Incom_type.Size = new System.Drawing.Size(112, 23);
			this.cbo_Incom_type.TabIndex = 5;
			this.cbo_Incom_type.SelectedValueChanged += new System.EventHandler(this.cbo_Incom_type_SelectedValueChanged);
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
			this.cbo_wh.Location = new System.Drawing.Point(264, 8);
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
			this.cbo_factory.Location = new System.Drawing.Point(72, 8);
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
			// lbl_intype
			// 
			this.lbl_intype.Location = new System.Drawing.Point(4, 33);
			this.lbl_intype.Name = "lbl_intype";
			this.lbl_intype.Size = new System.Drawing.Size(68, 32);
			this.lbl_intype.TabIndex = 2;
			this.lbl_intype.Text = "Incoming Type";
			// 
			// lbl_factory
			// 
			this.lbl_factory.Location = new System.Drawing.Point(8, 10);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(56, 16);
			this.lbl_factory.TabIndex = 0;
			this.lbl_factory.Text = "Factory";
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
			this.CboMold_CD.Location = new System.Drawing.Point(264, 40);
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
			this.CboMold_CD.Size = new System.Drawing.Size(264, 23);
			this.CboMold_CD.TabIndex = 76;
			// 
			// cbo_intype
			// 
			this.cbo_intype.AddItemCols = 0;
			this.cbo_intype.AddItemSeparator = ';';
			this.cbo_intype.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_intype.Caption = "";
			this.cbo_intype.CaptionHeight = 17;
			this.cbo_intype.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_intype.ColumnCaptionHeight = 17;
			this.cbo_intype.ColumnFooterHeight = 17;
			this.cbo_intype.ContentHeight = 15;
			this.cbo_intype.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_intype.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_intype.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.cbo_intype.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_intype.EditorHeight = 15;
			this.cbo_intype.GapHeight = 2;
			this.cbo_intype.ItemHeight = 15;
			this.cbo_intype.Location = new System.Drawing.Point(0, 0);
			this.cbo_intype.MatchEntryTimeout = ((long)(2000));
			this.cbo_intype.MaxDropDownItems = ((short)(5));
			this.cbo_intype.MaxLength = 32767;
			this.cbo_intype.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_intype.Name = "cbo_intype";
			this.cbo_intype.PartialRightColumn = false;
			this.cbo_intype.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_intype.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_intype.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_intype.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_intype.TabIndex = 0;
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
			this.fgrid_main.Location = new System.Drawing.Point(9, 128);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_main.Size = new System.Drawing.Size(663, 512);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 49;
			this.fgrid_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseDown);
			this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
			// 
			// fgrid_wh
			// 
			this.fgrid_wh.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_wh.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_wh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_wh.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_wh.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_wh.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:22;}\t";
			this.fgrid_wh.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_wh.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_wh.Location = new System.Drawing.Point(688, 128);
			this.fgrid_wh.Name = "fgrid_wh";
			this.fgrid_wh.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_wh.Size = new System.Drawing.Size(320, 512);
			this.fgrid_wh.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_wh.TabIndex = 50;
			this.fgrid_wh.DoubleClick += new System.EventHandler(this.fgrid_wh_DoubleClick);
			// 
			// cmenu_diagram
			// 
			this.cmenu_diagram.CommandLinks.Add(this.c1CommandLink9);
			this.cmenu_diagram.CommandLinks.Add(this.c1CommandLink10);
			this.cmenu_diagram.CommandLinks.Add(this.c1CommandLink11);
			this.cmenu_diagram.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.cmenu_diagram.Name = "cmenu_diagram";
			// 
			// c1CommandLink9
			// 
			this.c1CommandLink9.Command = this.c1Command1;
			// 
			// c1Command1
			// 
			this.c1Command1.Name = "c1Command1";
			this.c1Command1.Text = "Good";
			this.c1Command1.Click += new C1.Win.C1Command.ClickEventHandler(this.c1Command1_Click);
			// 
			// c1CommandLink10
			// 
			this.c1CommandLink10.Command = this.c1Command2;
			// 
			// c1Command2
			// 
			this.c1Command2.Name = "c1Command2";
			this.c1Command2.Text = "Repair";
			this.c1Command2.Click += new C1.Win.C1Command.ClickEventHandler(this.c1Command2_Click);
			// 
			// c1CommandLink11
			// 
			this.c1CommandLink11.Command = this.c1Command3;
			// 
			// c1Command3
			// 
			this.c1Command3.Name = "c1Command3";
			this.c1Command3.Text = "Destroy";
			this.c1Command3.Click += new C1.Win.C1Command.ClickEventHandler(this.c1Command3_Click);
			// 
			// Form_PB_Mold_Located
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_wh);
			this.Controls.Add(this.fgrid_main);
			this.Controls.Add(this.pnel1);
			this.Name = "Form_PB_Mold_Located";
			this.Text = "Form_Mold_Located";
			this.Load += new System.EventHandler(this.Form_PB_Mold_Located_Load);
			this.Controls.SetChildIndex(this.pnel1, 0);
			this.Controls.SetChildIndex(this.fgrid_main, 0);
			this.Controls.SetChildIndex(this.fgrid_wh, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnel1.ResumeLayout(false);
			this.pnel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cbo_mc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_sec)).EndInit();
			this.pnel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cbo_rank)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_level)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_shelf)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_area)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_Incom_type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CboMold_CD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_intype)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_wh)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PB_Mold_Located_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			FlexMold.ClassLib.ComVar.This_Win_ID = lbl_MainTitle.Text;
			FlexMold.ClassLib.ComVar.This_Computer = Environment.MachineName;

			tbtn_Print.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Color.Enabled = false;
			tbtn_New.Enabled = false;
			
			if((ClassLib.ComVar.This_Dept.ToString() =="110000")||(FlexMold.ClassLib.ComVar.This_Dept.ToString() =="0000"))
			{
				tbtn_Delete.Enabled = true ;
			}
			else
			{
				tbtn_Delete.Enabled = false ;
			}
		}
		private void Init_Form()
		{
			this.Text = "Mold Located Management";
			//rBtn_P.Checked = false;
			//rBtn_I.Checked = false;
			cbo_factory.Text = "VJ";
			this.lbl_MainTitle.Text = "Mold Located Management";
			ClassLib.ComFunction.SetLangDic(this);
		
			fgrid_main.Set_Grid("SDT_MOLD_LOCATE_MANAGER1", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
			//_RowFixed_desc = fgrip_main.Rows.Fixed;
			fgrid_main.ExtendLastCol = false;
			fgrid_main.AutoSizeCols();
 
			DataTable dt_ret = Select_com_filter_code_List("SDV34");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_Incom_type, 0, 1, false, false);

//			dt_ret = Select_com_filter_code_List("SDV15");
			dt_ret = Select_com_filter_code_List1("SDV15",ClassLib.ComVar.This_Dept);
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
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_main.Clear();
			fgrid_main.Set_Grid("SDT_MOLD_LOCATE_MANAGER", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			Search_Main();

			FlexMold.ClassLib.ComVar.This_Action ="S" ;
			FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
			FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);
//			int k = fgrid_main.Rows.Count-2 ;
//			txtTot.Text = k.ToString();
			Total();
		}
		private void Total()
		{	
			int sl = 0;
			int s = 0 ;
			int p = 0 ;
			for ( int i = 1 ; i < fgrid_main.Rows.Count -1 ; i++)
			{
				if (fgrid_main[i+1,7].ToString() == "")	
					p = p + 1;
				else if (fgrid_main[i+1,7].ToString().Substring(0,1)!= "P")	
				    s = s + 1;
				else if (fgrid_main[i+1,7].ToString().Substring(0,1)== "P")
					sl = sl + 1  ;				
			}
			txtOther.Text = p.ToString();
			txtPro_Out.Text = sl.ToString();
			txtTot.Text = s.ToString();
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
						fgrid_main.AddItem(vDt1.Rows[i].ItemArray, fgrid_main.Rows.Count, 1);
						fgrid_main.ExtendLastCol = false;
						fgrid_main.AutoSizeCols();
					}
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
		private void Search_wh()
		{
			DataTable vDt1 = null;
			try
			{
				vDt1 = SELECT_MOLD_WH_DETAIL();    
				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						fgrid_wh.AddItem(vDt1.Rows[i].ItemArray, fgrid_wh.Rows.Count, 1);		
						//fgrid_wh.ExtendLastCol = false;
						//fgrid_wh.AutoSizeCols();
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

			if (cbo_Incom_type.Text == "")
				OraDB.Parameter_Values[2] = "";
			else
			    OraDB.Parameter_Values[2] = cbo_Incom_type.SelectedValue.ToString();

			if (cbo_Incom_type.Text == "" )
				OraDB.Parameter_Values[3] = "M";
			else
				OraDB.Parameter_Values[3] = "N" ;

//			OraDB.Parameter_Values[4] = txt_moldcode.Text.Trim().ToString();
			OraDB.Parameter_Values[4] = CboMold_CD.SelectedValue.ToString();
			OraDB.Parameter_Values[5] = "" ;

			OraDB.Add_Select_Parameter(true);

			retDS = OraDB.Exe_Select_Procedure();

			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
		}

		private System.Data.DataTable SELECT_MOLD_WH_DETAIL()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD_WH.SEARCH_MOLD_WH_DETAIL";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_WH_CD";
			OraDB.Parameter_Name[2] = "ARG_RANK_CD";
			OraDB.Parameter_Name[3] = "ARG_SHELF_CD";
			OraDB.Parameter_Name[4] = "ARG_LEVEL_CD";
			OraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = cbo_factory.Text.ToString()  ;
			if(cbo_wh.Text != "")
				OraDB.Parameter_Values[1] = cbo_wh.SelectedValue.ToString();
			else
				OraDB.Parameter_Values[1] ="%";
			if(cbo_rank.Text != "")
				OraDB.Parameter_Values[2] = cbo_rank.SelectedValue.ToString();
			else
				OraDB.Parameter_Values[2] ="%";
			if(cbo_shelf.Text != "")
				OraDB.Parameter_Values[3] = cbo_shelf.SelectedValue.ToString();
			else
				OraDB.Parameter_Values[3] ="%";
			if(cbo_level.Text != "")
				OraDB.Parameter_Values[4] = cbo_level.SelectedValue.ToString();
			else
				OraDB.Parameter_Values[4] ="%";

			OraDB.Parameter_Values[5] = "" ;

			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
		}

		private void fgrid_main_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ClassLib.ComVar._startmouse = fgrid_main.RowSel;
			}
			else if(e.Button == MouseButtons.Right)
			{
				//e.ReturnStatus = VcReturnStatus.vcRetStatNoPopup;  
				cmenu_diagram.ShowContextMenu(fgrid_main, new Point(e.X, e.Y)); 
				//cmenu_Grid.Show(
				//_SelNode = e.Node;
			}
		}

		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ClassLib.ComVar._endmouse = fgrid_main.RowSel;
			}
		}

		private void fgrid_wh_DoubleClick(object sender, System.EventArgs e)
		{
			string locate = "";
			//string flag="";
		
			locate = fgrid_wh[fgrid_wh.RowSel,1].ToString () + fgrid_wh[fgrid_wh.RowSel,2].ToString() + fgrid_wh[fgrid_wh.RowSel,3].ToString();			
			insert_location(locate);
		}
		private void insert_location(string _locate)
		{
			for ( int i = ClassLib.ComVar._startmouse; i <= ClassLib.ComVar._endmouse; i++)
			{
				if((fgrid_main[i,9].ToString()=="O")||(fgrid_main[i,8].ToString()=="REPAIR"))
					MessageBox.Show("Mold Is Out Now");
				else
				{
					fgrid_main[i,7] = _locate;
					fgrid_main[i,0] = "U";
				}
			}
		}
		
	
		private void c1Command1_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			for ( int i = ClassLib.ComVar._startmouse; i <= ClassLib.ComVar._endmouse; i++)
			{
				fgrid_main[i,8] = "GOOD";
			}
		}

		private void c1Command2_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			for ( int i = ClassLib.ComVar._startmouse; i <= ClassLib.ComVar._endmouse; i++)
			{
				fgrid_main[i,8] = "REPAIR";
			}
		}

		private void c1Command3_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			for ( int i = ClassLib.ComVar._startmouse; i <= ClassLib.ComVar._endmouse; i++)
			{
				fgrid_main[i,8] = "DESTROY";
			}
		}		
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			//SAVE MOLD LOCATED TABLE.
			for(int i =2 ; i<fgrid_main.Rows.Count;i++)
			{
				if(fgrid_main[i,0].ToString()=="U")
					save_mold_located(i);				
				else if (fgrid_main[i,0].ToString()=="D")
				{
					delete_mold();	
					FlexMold.ClassLib.ComVar.This_Action ="D" ;
					FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
					FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);
					break ;
				}
			}
			FlexMold.ClassLib.ComVar.This_Action ="I" ;
			FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
			FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);

			fgrid_main.Clear();
			fgrid_main.Set_Grid("SDT_MOLD_LOCATE_MANAGER", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			Search_Main();
		}
		private void save_mold_located(int _row)
		{
			string process_name = "PKG_SDT_MOLD.SAVE_MOLD_LOCATE";
			OraDB.ReDim_Parameter(10); 

			//01.PROCEDURE명
			OraDB.Process_Name = process_name;
			OraDB.Parameter_Name[0]  = "ARG_FACTORY";
			OraDB.Parameter_Name[1]  = "ARG_MOLD_CD";
			OraDB.Parameter_Name[2]  = "ARG_USE_SIZE";
			OraDB.Parameter_Name[3]  = "ARG_SEQ_NO";
			OraDB.Parameter_Name[4]  = "ARG_WH_CD";
			OraDB.Parameter_Name[5]  = "ARG_LOCATE";
			OraDB.Parameter_Name[6]  = "ARG_STATUS";
			OraDB.Parameter_Name[7]  = "ARG_REMARKS";
			OraDB.Parameter_Name[8]  = "ARG_UPD_USER";
			OraDB.Parameter_Name[9] = "ARG_UPD_YMD";
//
			for(int i=0; i< 10; i++)
			{
				OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}
			
			OraDB.Parameter_Values[0] = "VJ"; 
			OraDB.Parameter_Values[1] = fgrid_main[_row,2].ToString(); 

			OraDB.Parameter_Values[2] = fgrid_main[_row,3].ToString(); 
			OraDB.Parameter_Values[3] = fgrid_main[_row,4].ToString(); 

			OraDB.Parameter_Values[4] = fgrid_main[_row,5].ToString(); 
			//OraDB.Parameter_Values[5] = fgrid_main[_row,6].ToString(); 

			OraDB.Parameter_Values[5] = fgrid_main[_row,7].ToString();  
			if(fgrid_main[_row,8].ToString().Trim() =="GOOD")
			{
				OraDB.Parameter_Values[6] = "10";    //rta
			}
			else if (fgrid_main[_row,8].ToString().Trim()=="REPAIR")
			{
				OraDB.Parameter_Values[6] = "20";
			}
			else if (fgrid_main[_row,8].ToString().Trim() =="DESTROY")
			{
				OraDB.Parameter_Values[6] = "30";
			}
			else 
			{
				OraDB.Parameter_Values[6] = "";
			}
			OraDB.Parameter_Values[7] = fgrid_main[_row,9].ToString().Trim();    //ets
			OraDB.Parameter_Values[8] = COM.ComVar.This_User; 
			OraDB.Parameter_Values[9] = "";

			OraDB.Add_Modify_Parameter(true);	
			OraDB.Exe_Modify_Procedure();
			
		}
		private void delete_mold()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (DELETE_TAIL(true))
				{
					//fgrid_main.Refresh_Division();
					MessageBox.Show("Delete Complete","Delete", MessageBoxButtons.OK ,MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		public bool DELETE_TAIL(bool doExecute)
		{
			try
			{
				int vArrayLength = 0;
				string [] _usesize = null;
				char [] _determid = "/".ToCharArray(); 									

				for (int vCol = 1 ; vCol < 6 ; vCol++)
				{
					vArrayLength++;
				}
				OraDB.ReDim_Parameter(vArrayLength);

				OraDB.Process_Name = "PKG_SDT_MOLD.DELETE_IN_TAIL";
								
				int vTempIndex = 0;
				
				OraDB.Parameter_Name[vTempIndex] = "ARG_FACTORY" ;
				OraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				vTempIndex++;

				OraDB.Parameter_Name[vTempIndex] = "ARG_MOLD_CD";
				OraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				vTempIndex++;

				OraDB.Parameter_Name[vTempIndex] = "ARG_USE_SIZE";
				OraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				vTempIndex++;

				OraDB.Parameter_Name[vTempIndex] = "ARG_SEQ_NO";
				OraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				vTempIndex++;				

				OraDB.Parameter_Name[vTempIndex] = "ARG_WH_CD";
				OraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				vTempIndex++;		

				ArrayList vValues = new ArrayList();

				for (int j= 0 ; j<fgrid_main.Rows.Count -1 ;j++)
				{
					if ( fgrid_main[j+1,0]=="D")
						{	
							vValues.Add("VJ");
							vValues.Add(CboMold_CD.SelectedValue.ToString());	
//							vValues.Add(txt_moldcode.Text.Trim().ToString());								
							_usesize = fgrid_main[j+1,3].ToString().Split(_determid);
							vValues.Add(_usesize[0].ToString());								
							vValues.Add(fgrid_main[j+1,4].ToString());
							vValues.Add(cbo_wh.SelectedValue.ToString());
						}					
				}
				
				OraDB.Parameter_Values = (string[])vValues.ToArray(Type.GetType("System.String"));
				
				OraDB.Add_Modify_Parameter(true);
				
				if (doExecute)
				{
					if (OraDB.Exe_Modify_Procedure() == null)
						return false;
					else
						return true;
				}

				return true;
			}
			catch
			{
				return false;
			}
		}

		private void cbo_Incom_type_SelectedValueChanged(object sender, System.EventArgs e)
		{
			//
			
		}

		private void cbo_wh_SelectedValueChanged(object sender, System.EventArgs e)
		{
//			cbo_area.ClearItems();
//			DataTable dt_ret = Select_com_filter_code_List("SDV37");
//			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_area, 0, 1, false, false);
			cbo_area.SelectedIndex = 0;
			init_cbo_rank();

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

		private void cbo_rank_SelectedValueChanged(object sender, System.EventArgs e)
		{
			//INIT SHELF
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

		private void btn_wh_Click(object sender, System.EventArgs e)
		{
			fgrid_wh.Clear();
			fgrid_wh.Set_Grid("SDT_MOLD_BASIC_WH", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			cbo_Incom_type.Text ="";
			Search_wh();
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			for (int i = ClassLib.ComVar._startmouse; i <= ClassLib.ComVar._endmouse; i++)
//			for (int i = 1; i <= fgrid_main.Rows.Count-1 ; i++)
			{
				fgrid_main[i, 0] = "D";
				fgrid_main.Cols[0].StyleDisplay.ForeColor = Color.Red ; 				
			}			
//			fgrid_main.Cols[0].StyleDisplay.ForeColor = Color.Red ; 
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
			//DSDS
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

		private void btn_sf_Click(object sender, System.EventArgs e)
		{
			fgrid_wh.Clear();
			fgrid_wh.Set_Grid("SDT_MOLD_BASIC_SF", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			cbo_Incom_type.Text ="";
			Search_mc();
		}
		private void Search_mc()
		{
			DataTable vDt1 = null;
						
			try
			{
				vDt1 = SELECT_MOLD_SF_DETAIL();    

				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						fgrid_wh.AddItem(vDt1.Rows[i].ItemArray, fgrid_wh.Rows.Count, 1);		
						//fgrid_wh.ExtendLastCol = false;
						//fgrid_wh.AutoSizeCols();
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
		private System.Data.DataTable SELECT_MOLD_SF_DETAIL()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD_WH.SEARCH_MOLD_SF_DETAIL";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_WH_CD";
			OraDB.Parameter_Name[2] = "ARG_MC_CD";
			OraDB.Parameter_Name[3] = "ARG_SEC_CD";
			OraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = cbo_factory.Text.ToString()  ;
			if(cbo_wh.Text != "")
				OraDB.Parameter_Values[1] = cbo_wh.SelectedValue.ToString();
			else
				OraDB.Parameter_Values[1] ="%";
			if(cbo_mc.Text != "")
				OraDB.Parameter_Values[2] = cbo_mc.SelectedValue.ToString();
			else
				OraDB.Parameter_Values[2] ="%";
			if(cbo_sec.Text != "")
				OraDB.Parameter_Values[3] = cbo_sec.SelectedValue.ToString();
			else
				OraDB.Parameter_Values[3] ="%";
			OraDB.Parameter_Values[4] = "" ;

			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
			
		}

		

		
		
	}
}

