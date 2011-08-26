using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data;
using System.Data.OracleClient;
using System.Drawing.Printing;
//using C1.C1Excel;

namespace FlexVJ_Common.DPUFE
{
	public class Form_Everyday_Fit_Delivery_Plan : COM.VJ_CommonWinForm.Form_Top
	{
//		private SolidBrush  _bdrBrush;
//		private int         _bdrOutside;
//		private int         _bdrInside;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.Label lbl_dpo;
		private System.Windows.Forms.Label lbl_line;
		private C1.Win.C1List.C1Combo cmb_Line;
		private System.Windows.Forms.Label lbl_style;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Panel pnl_grid;
		private COM.FSP fgrid_main;	
		private System.Windows.Forms.TextBox txt_style;
		private C1.Win.C1List.C1Combo cmb_obsid_to;
		private C1.Win.C1List.C1Combo cmb_obsid_fr;
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		//private C1.C1Excel.C1XLBook _c1xl;
		private System.ComponentModel.IContainer components = null;

		public Form_Everyday_Fit_Delivery_Plan()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Everyday_Fit_Delivery_Plan));
			this.pnl_head = new System.Windows.Forms.Panel();
			this.cmb_obsid_to = new C1.Win.C1List.C1Combo();
			this.cmb_obsid_fr = new C1.Win.C1List.C1Combo();
			this.lbl_style = new System.Windows.Forms.Label();
			this.cmb_Line = new C1.Win.C1List.C1Combo();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_line = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.btn_groupSearch = new System.Windows.Forms.Label();
			this.lbl_dpo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_style = new System.Windows.Forms.TextBox();
			this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.pnl_grid = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_obsid_to)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_obsid_fr)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
			this.pnl_grid.SuspendLayout();
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
			// tbtn_New
			// 
			this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
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
			this.lbl_MainTitle.Text = "Delivery Plan";
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.cmb_obsid_to);
			this.pnl_head.Controls.Add(this.cmb_obsid_fr);
			this.pnl_head.Controls.Add(this.lbl_style);
			this.pnl_head.Controls.Add(this.cmb_Line);
			this.pnl_head.Controls.Add(this.cmb_factory);
			this.pnl_head.Controls.Add(this.lbl_line);
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.lbl_Factory);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Controls.Add(this.pic_head2);
			this.pnl_head.Controls.Add(this.pic_head5);
			this.pnl_head.Controls.Add(this.pic_head1);
			this.pnl_head.Controls.Add(this.btn_groupSearch);
			this.pnl_head.Controls.Add(this.lbl_dpo);
			this.pnl_head.Controls.Add(this.label1);
			this.pnl_head.Controls.Add(this.txt_style);
			this.pnl_head.Controls.Add(this.cmb_StyleCd);
			this.pnl_head.Controls.Add(this.pic_head6);
			this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_head.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_head.Location = new System.Drawing.Point(0, 80);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(1016, 96);
			this.pnl_head.TabIndex = 29;
			// 
			// cmb_obsid_to
			// 
			this.cmb_obsid_to.AddItemCols = 0;
			this.cmb_obsid_to.AddItemSeparator = ';';
			this.cmb_obsid_to.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_obsid_to.AutoSize = false;
			this.cmb_obsid_to.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_obsid_to.Caption = "";
			this.cmb_obsid_to.CaptionHeight = 17;
			this.cmb_obsid_to.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_obsid_to.ColumnCaptionHeight = 18;
			this.cmb_obsid_to.ColumnFooterHeight = 18;
			this.cmb_obsid_to.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_obsid_to.ContentHeight = 17;
			this.cmb_obsid_to.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_obsid_to.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_obsid_to.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_obsid_to.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_obsid_to.EditorHeight = 17;
			this.cmb_obsid_to.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_obsid_to.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_obsid_to.GapHeight = 2;
			this.cmb_obsid_to.ItemHeight = 15;
			this.cmb_obsid_to.Location = new System.Drawing.Point(229, 64);
			this.cmb_obsid_to.MatchEntryTimeout = ((long)(2000));
			this.cmb_obsid_to.MaxDropDownItems = ((short)(5));
			this.cmb_obsid_to.MaxLength = 32767;
			this.cmb_obsid_to.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_obsid_to.Name = "cmb_obsid_to";
			this.cmb_obsid_to.PartialRightColumn = false;
			this.cmb_obsid_to.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Gulim, 9p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True" +
				";AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Cont" +
				"rol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.Li" +
				"stBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=" +
				"\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><" +
				"ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar>" +
				"<HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"St" +
				"yle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer" +
				"\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"" +
				"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><I" +
				"nactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"St" +
				"yle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSty" +
				"le parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win" +
				".C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style " +
				"parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pare" +
				"nt=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style paren" +
				"t=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style par" +
				"ent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"" +
				"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyle" +
				"s><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><" +
				"DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_obsid_to.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_obsid_to.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_obsid_to.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_obsid_to.Size = new System.Drawing.Size(100, 21);
			this.cmb_obsid_to.TabIndex = 587;
			// 
			// cmb_obsid_fr
			// 
			this.cmb_obsid_fr.AddItemCols = 0;
			this.cmb_obsid_fr.AddItemSeparator = ';';
			this.cmb_obsid_fr.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_obsid_fr.AutoSize = false;
			this.cmb_obsid_fr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_obsid_fr.Caption = "";
			this.cmb_obsid_fr.CaptionHeight = 17;
			this.cmb_obsid_fr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_obsid_fr.ColumnCaptionHeight = 18;
			this.cmb_obsid_fr.ColumnFooterHeight = 18;
			this.cmb_obsid_fr.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_obsid_fr.ContentHeight = 17;
			this.cmb_obsid_fr.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_obsid_fr.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_obsid_fr.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_obsid_fr.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_obsid_fr.EditorHeight = 17;
			this.cmb_obsid_fr.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_obsid_fr.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_obsid_fr.GapHeight = 2;
			this.cmb_obsid_fr.ItemHeight = 15;
			this.cmb_obsid_fr.Location = new System.Drawing.Point(109, 64);
			this.cmb_obsid_fr.MatchEntryTimeout = ((long)(2000));
			this.cmb_obsid_fr.MaxDropDownItems = ((short)(5));
			this.cmb_obsid_fr.MaxLength = 32767;
			this.cmb_obsid_fr.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_obsid_fr.Name = "cmb_obsid_fr";
			this.cmb_obsid_fr.PartialRightColumn = false;
			this.cmb_obsid_fr.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Gulim, 9p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Cont" +
				"rol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}St" +
				"yle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.Li" +
				"stBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=" +
				"\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><" +
				"ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar>" +
				"<HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"St" +
				"yle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer" +
				"\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"" +
				"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><I" +
				"nactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"St" +
				"yle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSty" +
				"le parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win" +
				".C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style " +
				"parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pare" +
				"nt=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style paren" +
				"t=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style par" +
				"ent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"" +
				"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyle" +
				"s><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><" +
				"DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_obsid_fr.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_obsid_fr.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_obsid_fr.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_obsid_fr.Size = new System.Drawing.Size(100, 21);
			this.cmb_obsid_fr.TabIndex = 586;
			this.cmb_obsid_fr.TextChanged += new System.EventHandler(this.cmb_obsid_fr_TextChanged);
			// 
			// lbl_style
			// 
			this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_style.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_style.ImageIndex = 0;
			this.lbl_style.ImageList = this.img_Label;
			this.lbl_style.Location = new System.Drawing.Point(344, 40);
			this.lbl_style.Name = "lbl_style";
			this.lbl_style.Size = new System.Drawing.Size(100, 21);
			this.lbl_style.TabIndex = 573;
			this.lbl_style.Text = "Style";
			this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Line
			// 
			this.cmb_Line.AddItemCols = 0;
			this.cmb_Line.AddItemSeparator = ';';
			this.cmb_Line.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Line.AutoSize = false;
			this.cmb_Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Line.Caption = "";
			this.cmb_Line.CaptionHeight = 17;
			this.cmb_Line.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Line.ColumnCaptionHeight = 18;
			this.cmb_Line.ColumnFooterHeight = 18;
			this.cmb_Line.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Line.ContentHeight = 17;
			this.cmb_Line.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Line.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Line.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_Line.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Line.EditorHeight = 17;
			this.cmb_Line.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Line.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Line.GapHeight = 2;
			this.cmb_Line.ItemHeight = 15;
			this.cmb_Line.Location = new System.Drawing.Point(445, 63);
			this.cmb_Line.MatchEntryTimeout = ((long)(2000));
			this.cmb_Line.MaxDropDownItems = ((short)(5));
			this.cmb_Line.MaxLength = 32767;
			this.cmb_Line.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Line.Name = "cmb_Line";
			this.cmb_Line.PartialRightColumn = false;
			this.cmb_Line.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Gulim, 9p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True" +
				";AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Cont" +
				"rol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.Li" +
				"stBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=" +
				"\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><" +
				"ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar>" +
				"<HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"St" +
				"yle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer" +
				"\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"" +
				"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><I" +
				"nactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"St" +
				"yle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSty" +
				"le parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win" +
				".C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style " +
				"parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pare" +
				"nt=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style paren" +
				"t=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style par" +
				"ent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"" +
				"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyle" +
				"s><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><" +
				"DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Line.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Line.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Line.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Line.Size = new System.Drawing.Size(220, 21);
			this.cmb_Line.TabIndex = 582;
			// 
			// cmb_factory
			// 
			this.cmb_factory.AddItemCols = 0;
			this.cmb_factory.AddItemSeparator = ';';
			this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_factory.AutoSize = false;
			this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_factory.Caption = "";
			this.cmb_factory.CaptionHeight = 17;
			this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_factory.ColumnCaptionHeight = 18;
			this.cmb_factory.ColumnFooterHeight = 18;
			this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_factory.ContentHeight = 17;
			this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_factory.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_factory.EditorHeight = 17;
			this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_factory.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_factory.GapHeight = 2;
			this.cmb_factory.ItemHeight = 15;
			this.cmb_factory.Location = new System.Drawing.Point(109, 40);
			this.cmb_factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_factory.MaxDropDownItems = ((short)(5));
			this.cmb_factory.MaxLength = 32767;
			this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_factory.Name = "cmb_factory";
			this.cmb_factory.PartialRightColumn = false;
			this.cmb_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Gulim, 9p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True" +
				";AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Cont" +
				"rol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.Li" +
				"stBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=" +
				"\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><" +
				"ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar>" +
				"<HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"St" +
				"yle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer" +
				"\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"" +
				"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><I" +
				"nactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"St" +
				"yle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSty" +
				"le parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win" +
				".C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style " +
				"parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pare" +
				"nt=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style paren" +
				"t=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style par" +
				"ent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"" +
				"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyle" +
				"s><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><" +
				"DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(220, 21);
			this.cmb_factory.TabIndex = 563;
			this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
			// 
			// lbl_line
			// 
			this.lbl_line.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_line.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_line.ImageIndex = 0;
			this.lbl_line.ImageList = this.img_Label;
			this.lbl_line.Location = new System.Drawing.Point(344, 64);
			this.lbl_line.Name = "lbl_line";
			this.lbl_line.Size = new System.Drawing.Size(100, 21);
			this.lbl_line.TabIndex = 405;
			this.lbl_line.Text = "Line";
			this.lbl_line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(224, 30);
			this.label2.TabIndex = 393;
			this.label2.Text = "      Search Information";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(1000, 80);
			this.pic_head3.Name = "pic_head3";
			this.pic_head3.Size = new System.Drawing.Size(16, 16);
			this.pic_head3.TabIndex = 45;
			this.pic_head3.TabStop = false;
			// 
			// pic_head4
			// 
			this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
			this.pic_head4.Location = new System.Drawing.Point(136, 79);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(976, 18);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(8, 40);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 50;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head7
			// 
			this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pic_head7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
			this.pic_head7.Location = new System.Drawing.Point(915, 30);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.Size = new System.Drawing.Size(101, 55);
			this.pic_head7.TabIndex = 46;
			this.pic_head7.TabStop = false;
			// 
			// pic_head2
			// 
			this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
			this.pic_head2.Location = new System.Drawing.Point(1000, 0);
			this.pic_head2.Name = "pic_head2";
			this.pic_head2.Size = new System.Drawing.Size(16, 32);
			this.pic_head2.TabIndex = 44;
			this.pic_head2.TabStop = false;
			// 
			// pic_head5
			// 
			this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
			this.pic_head5.Location = new System.Drawing.Point(0, 80);
			this.pic_head5.Name = "pic_head5";
			this.pic_head5.Size = new System.Drawing.Size(168, 20);
			this.pic_head5.TabIndex = 43;
			this.pic_head5.TabStop = false;
			// 
			// pic_head1
			// 
			this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
			this.pic_head1.Location = new System.Drawing.Point(152, 0);
			this.pic_head1.Name = "pic_head1";
			this.pic_head1.Size = new System.Drawing.Size(944, 32);
			this.pic_head1.TabIndex = 39;
			this.pic_head1.TabStop = false;
			// 
			// btn_groupSearch
			// 
			this.btn_groupSearch.Location = new System.Drawing.Point(0, 0);
			this.btn_groupSearch.Name = "btn_groupSearch";
			this.btn_groupSearch.TabIndex = 583;
			// 
			// lbl_dpo
			// 
			this.lbl_dpo.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_dpo.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_dpo.ImageIndex = 0;
			this.lbl_dpo.ImageList = this.img_Label;
			this.lbl_dpo.Location = new System.Drawing.Point(8, 64);
			this.lbl_dpo.Name = "lbl_dpo";
			this.lbl_dpo.Size = new System.Drawing.Size(100, 21);
			this.lbl_dpo.TabIndex = 566;
			this.lbl_dpo.Text = "PO ID";
			this.lbl_dpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(213, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 18);
			this.label1.TabIndex = 584;
			this.label1.Text = "~";
			// 
			// txt_style
			// 
			this.txt_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_style.Font = new System.Drawing.Font("Gulim", 9F);
			this.txt_style.Location = new System.Drawing.Point(445, 40);
			this.txt_style.MaxLength = 10;
			this.txt_style.Name = "txt_style";
			this.txt_style.Size = new System.Drawing.Size(99, 21);
			this.txt_style.TabIndex = 568;
			this.txt_style.Text = "";
			this.txt_style.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_style_KeyDown);
			// 
			// cmb_StyleCd
			// 
			this.cmb_StyleCd.AddItemCols = 0;
			this.cmb_StyleCd.AddItemSeparator = ';';
			this.cmb_StyleCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_StyleCd.AutoSize = false;
			this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_StyleCd.Caption = "";
			this.cmb_StyleCd.CaptionHeight = 17;
			this.cmb_StyleCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_StyleCd.ColumnCaptionHeight = 18;
			this.cmb_StyleCd.ColumnFooterHeight = 18;
			this.cmb_StyleCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_StyleCd.ContentHeight = 17;
			this.cmb_StyleCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_StyleCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_StyleCd.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_StyleCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_StyleCd.EditorHeight = 17;
			this.cmb_StyleCd.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_StyleCd.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_StyleCd.GapHeight = 2;
			this.cmb_StyleCd.ItemHeight = 15;
			this.cmb_StyleCd.Location = new System.Drawing.Point(547, 40);
			this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
			this.cmb_StyleCd.MaxLength = 32767;
			this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_StyleCd.Name = "cmb_StyleCd";
			this.cmb_StyleCd.PartialRightColumn = false;
			this.cmb_StyleCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Gulim, 9p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Cont" +
				"rol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}St" +
				"yle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.Li" +
				"stBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=" +
				"\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><" +
				"ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar>" +
				"<HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"St" +
				"yle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer" +
				"\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"" +
				"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><I" +
				"nactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"St" +
				"yle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSty" +
				"le parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win" +
				".C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style " +
				"parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pare" +
				"nt=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style paren" +
				"t=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style par" +
				"ent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"" +
				"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyle" +
				"s><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><" +
				"DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_StyleCd.Size = new System.Drawing.Size(118, 21);
			this.cmb_StyleCd.TabIndex = 587;
			// 
			// pic_head6
			// 
			this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
			this.pic_head6.Location = new System.Drawing.Point(0, 0);
			this.pic_head6.Name = "pic_head6";
			this.pic_head6.Size = new System.Drawing.Size(168, 78);
			this.pic_head6.TabIndex = 41;
			this.pic_head6.TabStop = false;
			// 
			// pnl_grid
			// 
			this.pnl_grid.Controls.Add(this.fgrid_main);
			this.pnl_grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_grid.Location = new System.Drawing.Point(0, 176);
			this.pnl_grid.Name = "pnl_grid";
			this.pnl_grid.Size = new System.Drawing.Size(1016, 468);
			this.pnl_grid.TabIndex = 30;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,80,Columns:1{TextAlign:RightCenter;}\t";
			this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(2)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_main.Size = new System.Drawing.Size(1016, 468);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 7pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 178;
			// 
			// Form_Everyday_Fit_Delivery_Plan
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_grid);
			this.Controls.Add(this.pnl_head);
			this.Name = "Form_Everyday_Fit_Delivery_Plan";
			this.Text = "Delivery Plan";
			this.Load += new System.EventHandler(this.Form_Everyday_Fit_Delivery_Plan_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.pnl_head, 0);
			this.Controls.SetChildIndex(this.pnl_grid, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_obsid_to)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_obsid_fr)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
			this.pnl_grid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region "Constant Argument"
		private const string ARG_FACTORY = "ARG_FACTORY";
		private const string ARG_MONTH = "ARG_MONTH";
		private const string ARG_LINE_CD = "ARG_LINE_CD";
		private const string ARG_OS_CODE = "ARG_OS_CODE";
		private const string ARG_DEV_NAME = "ARG_DEV_NAME";
		private const string OUT_CURSOR = "OUT_CURSOR";
		private const string ARG_TO_OBS_ID = "ARG_TO_OBS_ID";
		private const string ARG_FROM_OBS_ID = "ARG_FROM_OBS_ID";
		private const string ARG_OBS_ID_FROM = "ARG_OBS_ID_FROM";
		private const string ARG_OBS_ID_TO = "ARG_OBS_ID_TO";
		private const string ARG_STYLE_CD = "ARG_STYLE_CD";

		#endregion

		#region "Constant Grid Column"
		private const int G1_COL_LINE = 1;
		private const int G1_COL_STYLE = 3;
		private const int G1_COL_DPO = 2;
		private const int G1_COL_COL4 = 4;


		#endregion

		#region "variable Declare"
		private int _MainRowfixed = 0;
		private string _FontName = "Verdana";
		private float _FontSize = 7;
		private int _MaxCol = 4;
		private int _DynamicColWidth = 50;
		private CellStyle _CellBal = null;
		private CellStyle _CellPlan = null;
		private CellStyle _CellProd = null;
		private CellStyle _CellOther = null;
		private const string RowRGAC = "RGAC";
		private const string RowOGAC = "OGAC";
		private const string RowPLAN = "PLAN";
		private const string RowPROD = "PROD";
		private const string RowDAILYPLAN = "DAILYPLAN";
		private const string RowDAILYACTUAL = "DAILYACTUAL";
		private const string RowVAR = "VAR";
		private DataTable _tbPOID = null;
		#endregion

		#region "Mothods"
		private void InitControl()
		{
			//tool bar button
			tbtn_Append.Enabled=false;
			tbtn_Color.Enabled=false;
			tbtn_Confirm.Enabled=false;
			tbtn_Create.Enabled=false;
			tbtn_Delete.Enabled=false;
			tbtn_Insert.Enabled=false;
			//tbtn_New.Enabled=false;
			//tbtn_Print.Enabled=false;
			tbtn_Save.Enabled=false;
			//tbtn_Search.Enabled=false;

			//init header control
			DataTable dt_ret;

			// cmb factory
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			//cbm  Line
			dt_ret = SELECT_LINE_INFO();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Line, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Line.SelectedIndex = 0;

			dt_ret.Dispose();

			//txt style
			txt_style.Text=string.Empty;

			//init gird main
			fgrid_main.Set_Grid("LST_EVERYDAY_FIT_DELIVERY_PLAN","1",2,COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);	
			_MainRowfixed = fgrid_main.Rows.Fixed;
			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.AllowMerging = AllowMergingEnum.Free;				
			
			fgrid_main.Font = new Font(_FontName, _FontSize);

			
		}

		private void ResetControl()
		{
			// cmb factory
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			//cbm  Line
			cmb_Line.SelectedIndex = 0;

			//txt dpo
			cmb_obsid_fr.SelectedIndex = 0;
			cmb_obsid_to.SelectedIndex = 0;
			//txt style
			txt_style.Text=string.Empty;
			setStyleList();
		}
		
		private DataTable SELECT_LINE_INFO()
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;			
			try
			{
				string process_name = "PKG_SBM_LLT_PLAN_TRACKING.SELECT_LINE_INFO";

				MyOraDB.ReDim_Parameter(2);  
				MyOraDB.Process_Name = process_name;
   

				MyOraDB.Parameter_Name[0] = ARG_FACTORY; 
				MyOraDB.Parameter_Name[1] = OUT_CURSOR; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			}
		}

		private void ProcessSearch()
		{
			if(cmb_obsid_fr.SelectedValue.ToString()!=""||cmb_obsid_to.SelectedValue.ToString()!="")
			{
				Clear_FlexGrid(fgrid_main);

				InitHeader(fgrid_main, COM.ComFunction.Empty_Combo(cmb_obsid_fr,""),COM.ComFunction.Empty_Combo(cmb_obsid_to,""));
				Get_Delivery_Plan_Gac2(fgrid_main,cmb_factory.SelectedValue.ToString(),cmb_obsid_fr.SelectedValue.ToString(),cmb_obsid_to.SelectedValue.ToString(),
					cmb_Line.SelectedValue.ToString(),COM.ComFunction.Empty_Combo(cmb_StyleCd,"").Replace("-",""));

				CalRowSum(fgrid_main);
				CalBal(fgrid_main);
			}
			else
			{
				MessageBox.Show("Please select OBS_ID");
			}
		}

		private DataTable SELECT_PLAN_SCHEDULE_HEAD(string arg_Factory,string arg_from_poid, string arg_to_poid, string arg_line_cd)
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;			
			try
			{
				MyOraDB.ReDim_Parameter(5);  
				MyOraDB.Process_Name = "PKG_SVM_DELIVERY_PLAN.SP_SEL_PLAN_SCHEDULE_Head";;

				MyOraDB.Parameter_Name[0] = ARG_FACTORY; 
				MyOraDB.Parameter_Name[1] = ARG_FROM_OBS_ID; 
				MyOraDB.Parameter_Name[2] = ARG_TO_OBS_ID; 
				MyOraDB.Parameter_Name[3] = OUT_CURSOR; 
				MyOraDB.Parameter_Name[4] = ARG_LINE_CD;

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 

				MyOraDB.Parameter_Values[0] = arg_Factory;
				MyOraDB.Parameter_Values[1] = arg_from_poid;
				MyOraDB.Parameter_Values[2] = arg_to_poid;
				MyOraDB.Parameter_Values[3] = ""; 
				MyOraDB.Parameter_Values[4] = arg_line_cd;

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[MyOraDB.Process_Name]; 
			}
			catch
			{
				return null;
			}
		}


		private void Clear_FlexGrid(COM.FSP p_fgControl)
		{
			if (p_fgControl.Rows.Fixed != p_fgControl.Rows.Count)
			{				
				p_fgControl.Clear(ClearFlags.UserData, p_fgControl.Rows.Fixed, 1, p_fgControl.Rows.Count - 1, p_fgControl.Cols.Count - 1);
				p_fgControl.Rows.Count = p_fgControl.Rows.Fixed;					
			}
			for (int i = p_fgControl.Cols.Count -1; i > _MaxCol  ; i --)
			{
				p_fgControl.Cols.Remove(i);
			}			
		}

		private void InitHeader(COM.FSP p_fgControl, string arg_from_poid, string arg_to_poid)
		{
			//TODO: can cap nhat
			DataTable dt = SELECT_PLAN_SCHEDULE_HEAD(COM.ComFunction.Empty_Combo(cmb_factory,""),arg_from_poid,arg_to_poid,
				COM.ComFunction.Empty_Combo(cmb_Line,""));
			if(dt==null) return;
			if(dt.Rows.Count<1) return;
			for(int i = 0; i < dt.Rows.Count; i++)
			{
				object objymd = dt.Rows[i][0];//ymd
				object objqty = dt.Rows[i][1];//qty

				DateTime l_DateTime = ConvertToDateTime(objymd.ToString());
				p_fgControl.Cols.Add();
				int _Colindex = p_fgControl.Cols.Count - 1;
				p_fgControl.Cols[_Colindex].Caption = objymd.ToString();
				p_fgControl.Cols[_Colindex].DataType = typeof(Int32);
				p_fgControl.Cols[_Colindex].AllowEditing = false;
				p_fgControl.Cols[_Colindex].AllowSorting = false;
				p_fgControl.Set_CellStyle_Number(_Colindex);
						
				p_fgControl[1,_Colindex] = l_DateTime.ToString("MM-dd");
				fgrid_main.Cols[_Colindex].AllowMerging=false;
				fgrid_main.Rows[2].AllowMerging=false;
				fgrid_main.Cols[_Colindex].Width = _DynamicColWidth;
				fgrid_main[2,_Colindex] = objqty;
			}
		}

		private DateTime ConvertToDateTime(string p_yyyyMMdd)
		{
			return DateTime.ParseExact(p_yyyyMMdd,"yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture );
		}

		private void InitCellStyle()
		{
			if(_CellBal == null)
			{
				_CellBal = fgrid_main.Styles.Add("BAL");
				_CellBal.ForeColor = Color.Red;
				//_CellBal.Border.Style = BorderStyleEnum.Dotted;	
				//_CellBal.Border.Color = Color.LightBlue;
				_CellBal.DataType = typeof(double);
				_CellBal.Format = "#,##0.##########";  
				_CellBal.Font =new Font(_FontName,_FontSize,FontStyle.Bold,GraphicsUnit.Point);
			}
			if(_CellPlan == null)
			{
				_CellPlan = fgrid_main.Styles.Add("PLAN");
				_CellPlan.ForeColor = Color.RoyalBlue;
				_CellPlan.Font=new Font(_FontName,_FontSize,FontStyle.Regular,GraphicsUnit.Point);
				//_CellPlan.Border.Style = BorderStyleEnum.Dotted;	
				//_CellPlan.Border.Direction = BorderDirEnum.Both;
				//_CellPlan.Border.Color = Color.RoyalBlue;
			}
			if(_CellProd == null)
			{
				_CellProd = fgrid_main.Styles.Add("PROD");
				_CellProd.ForeColor = Color.Black;
				_CellProd.Font=new Font(_FontName,_FontSize,FontStyle.Regular,GraphicsUnit.Point);
				//_CellProd.Border.Style = BorderStyleEnum.Dotted;	
				//_CellProd.Border.Color = Color.LightBlue;
				//_CellProd.Border.Direction = BorderDirEnum.Both;
			}
			if(_CellOther == null)
			{
				_CellOther = fgrid_main.Styles.Add("OTHER");
				_CellOther.ForeColor = Color.Black;
				_CellOther.Font=new Font(_FontName,_FontSize,FontStyle.Regular,GraphicsUnit.Point);
				//_CellOther.Border.Style = BorderStyleEnum.Dotted;	
				//_CellOther.Border.Color = Color.LightBlue;
			}
		}

		private void CalBal(COM.FSP arg_grid)
		{
			if(arg_grid == null) return;
			if(arg_grid.Rows.Count <= _MainRowfixed) return;			
			arg_grid.Cols.Add();
			int _index = arg_grid.Cols.Count - 1;
			arg_grid.Cols[_index].Style = _CellBal;
			arg_grid.Cols[_index].AllowEditing = false;
			arg_grid[1,_index] = "Bal.";
			arg_grid[2,_index] = "Bal.";
			arg_grid.Cols[_index].AllowMerging = true;
			arg_grid.SetCellStyle(1,_index,_CellBal);
			arg_grid.SetCellStyle(2,_index,_CellBal);
			arg_grid.Cols[_index].Style = _CellBal;
			for(int i = _MainRowfixed; i < fgrid_main.Rows.Count - 3; i++)
			{
				if(arg_grid.Rows[i].Caption != RowPLAN) continue;
				else
				{
					double _plan = 0;
					double _prod = 0;
					for(int j = G1_COL_COL4 + 1; j < arg_grid.Cols.Count -1; j ++)
					{
						if(arg_grid[i + 1,j] != null)
						{
							_prod += double.Parse(arg_grid[i + 1,j].ToString());
						}
						if(arg_grid[i  ,j] != null)
						{
							_plan += double.Parse(arg_grid[i,j].ToString());
						}
					}
					arg_grid[i + 1,_index] = _plan  - _prod;
				}
			}
		}
		
		
		private void CalRowSum(COM.FSP arg_grid)
		{
			if(arg_grid == null) return;
			if(arg_grid.Rows.Count <= _MainRowfixed) return;
			int _RowCount = arg_grid.Rows.Count;
			arg_grid.Rows.Add();
			int _index = arg_grid.Rows.Count -1;
			arg_grid.Rows[_index].Style = _CellPlan;
			arg_grid.Rows[_index].AllowEditing = false;
			arg_grid[_index,G1_COL_COL4] = "Daily plan";
			arg_grid.Rows.Add();
			_index = arg_grid.Rows.Count -1;
			arg_grid.Rows[_index].Style = _CellProd;
			arg_grid.Rows[_index].AllowEditing = false;
			arg_grid[_index,G1_COL_COL4] = "Daily actual";
			arg_grid.Rows.Add();
			_index = arg_grid.Rows.Count -1;
			arg_grid.Rows[_index].Style = _CellProd;
			arg_grid.Rows[_index].AllowEditing = false;
			arg_grid[_index ,G1_COL_COL4] = "Var";

			for(int j = _MaxCol + 1; j < arg_grid.Cols.Count - 1; j ++)
			{
				double _sumPlan = 0;
				double _sumProd = 0;
				for(int i = _MainRowfixed; i< _RowCount; i++)
				{
					if(arg_grid.Rows[i].Caption.Equals(RowPLAN))
					{
						if(Convert.ToString( arg_grid[i,j])!="")
						{
							_sumPlan += Convert.ToDouble(Convert.ToString( arg_grid[i,j]));
						}
					}
					if(arg_grid.Rows[i].Caption.Equals(RowPROD))
					{
						if(Convert.ToString( arg_grid[i,j])!="")
						{
							_sumProd += Convert.ToDouble(Convert.ToString( arg_grid[i,j]));
						}
					}
				}	
				//_sumPlan = Math.Round(_sumPlan,0);
				//_sumProd = Math.Round(_sumProd,0);
				_sumPlan = Math.Round(_sumPlan / Convert.ToDouble(fgrid_main[2,j]),0);
				_sumProd = Math.Round(_sumProd / Convert.ToDouble(fgrid_main[2,j]),0);
				arg_grid[_index - 2,j] = _sumPlan ;
				arg_grid[_index - 1,j] = _sumProd;
				arg_grid[_index,j] = _sumPlan - _sumProd;
			}
		}

		

		

		private DataTable Get_Delivery_Plan_Gac(string arg_Factory,string arg_obs_id_from, string arg_obs_id_to, string arg_line_cd, string arg_style_cd, string arg_gac_type)
		{
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;	
			DataTable dt = null;
			try
			{
				MyOraDB.ReDim_Parameter(6);  
				if(arg_gac_type=="R")
				{
					MyOraDB.Process_Name = "PKG_SVM_DELIVERY_PLAN.SP_SEL_DELIVERY_PLAN_RGAC";
				}
				else
				{
					MyOraDB.Process_Name = "PKG_SVM_DELIVERY_PLAN.SP_SEL_DELIVERY_PLAN_OGAC";
				}
				MyOraDB.Parameter_Name[0] = ARG_FACTORY; 
				MyOraDB.Parameter_Name[1] = ARG_OBS_ID_FROM; 
				MyOraDB.Parameter_Name[2] = ARG_OBS_ID_TO; 
				MyOraDB.Parameter_Name[3] = ARG_LINE_CD; 
				MyOraDB.Parameter_Name[4] = ARG_STYLE_CD; 
				MyOraDB.Parameter_Name[5] = OUT_CURSOR; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = arg_Factory;
				MyOraDB.Parameter_Values[1] = arg_obs_id_from;
				MyOraDB.Parameter_Values[2] = arg_obs_id_to;
				MyOraDB.Parameter_Values[3] = arg_line_cd;
				MyOraDB.Parameter_Values[4] = arg_style_cd.Replace("-","");
				MyOraDB.Parameter_Values[5] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) dt = null ; 
				dt = ds_ret.Tables[MyOraDB.Process_Name]; 
			}
			catch
			{
				dt = null;
			}

			return dt;
		}

		private void Get_Delivery_Plan_Gac2(COM.FSP arg_Grid, string arg_Factory,
			string arg_obs_id_from, string arg_obs_id_to, string arg_line_cd,
			string arg_style_cd)
		{
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;	
			DataTable dt = null;
			try
			{
				MyOraDB.ReDim_Parameter(6);  
				MyOraDB.Process_Name = "PKG_SVM_DELIVERY_PLAN.SP_SEL_DELIVERY_PLAN_GAC2";

				MyOraDB.Parameter_Name[0] = ARG_FACTORY; 
				MyOraDB.Parameter_Name[1] = ARG_OBS_ID_FROM; 
				MyOraDB.Parameter_Name[2] = ARG_OBS_ID_TO; 
				MyOraDB.Parameter_Name[3] = ARG_LINE_CD; 
				MyOraDB.Parameter_Name[4] = ARG_STYLE_CD; 
				MyOraDB.Parameter_Name[5] = OUT_CURSOR; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = arg_Factory;
				MyOraDB.Parameter_Values[1] = arg_obs_id_from;
				MyOraDB.Parameter_Values[2] = arg_obs_id_to;
				MyOraDB.Parameter_Values[3] = arg_line_cd;
				MyOraDB.Parameter_Values[4] = arg_style_cd.Replace("-","");
				MyOraDB.Parameter_Values[5] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) dt = null ; 
				dt = ds_ret.Tables[MyOraDB.Process_Name]; 
			}
			catch
			{
				dt = null;
			}

			if(dt == null) return;
			if(dt.Rows.Count < 1 ) return;
			DataTable l_TB = Get_Delivery_Plan_Mps(arg_Factory,arg_obs_id_from,arg_obs_id_to, arg_line_cd, arg_style_cd);
			DataTable l_TBRGac = Get_Delivery_Plan_Gac(arg_Factory,arg_obs_id_from,arg_obs_id_to, arg_line_cd, arg_style_cd,"R");
			DataTable l_TBOGac = Get_Delivery_Plan_Gac(arg_Factory,arg_obs_id_from,arg_obs_id_to, arg_line_cd, arg_style_cd,"O");
			DataTable l_TBMes = Get_Delivery_Plan_Mes(arg_Factory,arg_obs_id_from,arg_obs_id_to, arg_line_cd, arg_style_cd);

			for(int i = 0; i < dt.Rows.Count; i++)
			{
				object objFactory = dt.Rows[i]["FACTORY"];
				object objLine_cd = dt.Rows[i]["LINE_CD"];
				object objLine_name = dt.Rows[i]["LINE_NAME"];
				object objObs_id = dt.Rows[i]["OBS_ID"];
				object objStyle_cd = dt.Rows[i]["STYLE_CD"];
				//object objRgac_ymd = dt.Rows[i]["RGAC_YMD"];
				//object objOgac_ymd = dt.Rows[i]["OGAC_YMD"];
				//object objTot_qty = dt.Rows[i]["TOT_QTY"];
				
				arg_Grid.Rows.Add();
				int _RowIndex = arg_Grid.Rows.Count - 1;
				//RGAC
				arg_Grid.Rows[_RowIndex].Caption = RowRGAC;
				arg_Grid[_RowIndex,G1_COL_LINE] = objLine_name;
				arg_Grid[_RowIndex,G1_COL_DPO] = objObs_id.ToString();
				arg_Grid[_RowIndex,G1_COL_STYLE] = objStyle_cd.ToString().Insert(objStyle_cd.ToString().Length-3,"-");
				arg_Grid[_RowIndex,G1_COL_COL4] = RowRGAC;
				arg_Grid.SetCellStyle(_RowIndex,G1_COL_COL4,_CellOther);
				//OGAC
				arg_Grid.Rows.Add();
				_RowIndex = arg_Grid.Rows.Count - 1;				
				arg_Grid.Rows[_RowIndex].Caption = RowOGAC;
				arg_Grid[_RowIndex,G1_COL_LINE] = objLine_name;
				arg_Grid[_RowIndex,G1_COL_DPO] = objObs_id.ToString();
				arg_Grid[_RowIndex,G1_COL_STYLE] = objStyle_cd.ToString().Insert(objStyle_cd.ToString().Length-3,"-");
				arg_Grid[_RowIndex,G1_COL_COL4] = RowOGAC;
				arg_Grid.SetCellStyle(_RowIndex,G1_COL_COL4,_CellOther);
				//PLAN
				arg_Grid.Rows.Add();
				_RowIndex = arg_Grid.Rows.Count - 1;
				arg_Grid.Rows[_RowIndex].Caption = RowPLAN;
				arg_Grid[_RowIndex,G1_COL_COL4] = "Plan";
				arg_Grid.SetCellStyle(_RowIndex,G1_COL_COL4,_CellPlan);

				arg_Grid[_RowIndex,G1_COL_LINE] = objLine_name;
				arg_Grid[_RowIndex,G1_COL_DPO] = objObs_id.ToString();
				arg_Grid[_RowIndex,G1_COL_STYLE] = objStyle_cd.ToString().Insert(objStyle_cd.ToString().Length-3,"-");

				//PROD
				arg_Grid.Rows.Add();
				_RowIndex = arg_Grid.Rows.Count - 1;
				arg_Grid.Rows[_RowIndex].Caption = RowPROD;
				arg_Grid[_RowIndex,G1_COL_COL4] = "Prod";
				arg_Grid.SetCellStyle(_RowIndex,G1_COL_COL4,_CellProd);
				
				arg_Grid[_RowIndex,G1_COL_LINE] = objLine_name;
				arg_Grid[_RowIndex,G1_COL_DPO] = objObs_id.ToString();
				arg_Grid[_RowIndex,G1_COL_STYLE] = objStyle_cd.ToString().Insert(objStyle_cd.ToString().Length-3,"-");

				

				for(int iCol = G1_COL_COL4 + 1; iCol < fgrid_main.Cols.Count; iCol ++)
				{
					string l_DateTmp = fgrid_main.Cols[iCol].Caption;
					DateTime l_Tmp = ConvertToDateTime(l_DateTmp);	
					//rgac value	
					if(l_TBRGac != null)
					{
						if(l_TBRGac.Rows.Count > 0)
						{
							object l_valueRGac =  Get_Delivery_Plan_Gac_Value(l_TBRGac,Convert.ToString( objFactory), Convert.ToString( objObs_id),
								Convert.ToString( objLine_cd),Convert.ToString( objStyle_cd),l_DateTmp);
							if(l_valueRGac != null)
								arg_Grid[_RowIndex - 3,iCol]  = Convert.ToDouble(l_valueRGac);
						}
					}
					arg_Grid.SetCellStyle(_RowIndex - 3,iCol,_CellProd);
					//ogac value					
					if(l_TBOGac != null)
					{
						if(l_TBOGac.Rows.Count > 0)
						{
							object l_valueOGac =  Get_Delivery_Plan_Gac_Value(l_TBOGac,Convert.ToString( objFactory), Convert.ToString( objObs_id),
								Convert.ToString( objLine_cd),Convert.ToString( objStyle_cd),l_DateTmp);
							if(l_valueOGac != null)
								arg_Grid[_RowIndex - 2,iCol]  = Convert.ToDouble(l_valueOGac);
						}
					}
					arg_Grid.SetCellStyle(_RowIndex - 2,iCol,_CellProd);
					
					//plan value
					if(l_TB != null)
					{
						if(l_TB.Rows.Count > 0)
						{
							object l_Qty = Get_Delivery_Plan_Mps_Value(l_TB,Convert.ToString( objFactory),Convert.ToString( objObs_id),Convert.ToString( objObs_id), 
								Convert.ToString( objLine_cd), Convert.ToString( objStyle_cd),l_DateTmp);
							if(l_Qty != null)
								arg_Grid[_RowIndex -1 ,iCol] = Convert.ToDouble(l_Qty);
						}
					}
					arg_Grid.SetCellStyle(_RowIndex -1,iCol,_CellPlan);
					
					//prod value
					if(l_TBMes != null)
					{
						if(l_TBMes.Rows.Count > 0)
						{
							object l_Qty = Get_Delivery_Plan_Mes_Value(l_TBMes,Convert.ToString( objFactory),Convert.ToString( objObs_id),Convert.ToString( objObs_id), 
								Convert.ToString( objLine_cd), Convert.ToString( objStyle_cd),l_DateTmp);
							if(l_Qty != null)
								arg_Grid[_RowIndex,iCol] = Convert.ToDouble(l_Qty);
						}
					}
					arg_Grid.SetCellStyle(_RowIndex,iCol,_CellProd);
					
				}
				
			}
		}

		private object Get_Delivery_Plan_Gac_Value(DataTable arg_TableSource, string arg_Factory,
			string arg_obs_id, string arg_line_cd,
			string arg_style_cd, string arg_to_date)
		{
			if(arg_TableSource == null) return null;
			if(arg_TableSource.Rows.Count < 1) return null;
			DataRow[] dr = null;
			dr = arg_TableSource.Select("FACTORY = '" + arg_Factory + "' and OBS_ID = '" + arg_obs_id + 
				"' and LINE_CD = '"  + arg_line_cd + "' and STYLE_CD = '" + arg_style_cd +"' and PLAN_YMD ='" + arg_to_date + "'");
			if(dr.Length > 0)
			{
				return Convert.ToDouble(dr[0]["QTYW"].ToString());
			}
			else
				return null;
		}

		private object Get_Delivery_Plan_Mps_Value(DataTable arg_TableSource, string arg_Factory,
			string arg_obs_id_from, string arg_obs_id_to, string arg_line_cd,
			string arg_style_cd, string arg_from_date)
		{
			if(arg_TableSource == null) return null;
			if(arg_TableSource.Rows.Count < 1) return null;
			DataRow[] dr = arg_TableSource.Select("FACTORY = '" + arg_Factory + "' and OBS_ID = '" + arg_obs_id_from + 
				"' and LINE_CD = '"  + arg_line_cd + "' and STYLE_CD = '" + arg_style_cd + "' and PLAN_YMD = '" + arg_from_date+"'");
			if(dr.Length > 0)
			{
				return Convert.ToDouble(dr[0]["QTYW"].ToString());
			}
			else
				return null;
		}

		
		private DataTable Get_Delivery_Plan_Mps(string arg_Factory,
			string arg_obs_id_from, string arg_obs_id_to, string arg_line_cd,
			string arg_style_cd)
		{
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;	
			DataTable dt = null;
			try
			{
				MyOraDB.ReDim_Parameter(6);  
				MyOraDB.Process_Name = "PKG_SVM_DELIVERY_PLAN.SP_SEL_DELIVERY_PLAN_MPS_2";

				MyOraDB.Parameter_Name[0] = ARG_FACTORY; 
				MyOraDB.Parameter_Name[1] = ARG_OBS_ID_FROM; 
				MyOraDB.Parameter_Name[2] = ARG_OBS_ID_TO; 
				MyOraDB.Parameter_Name[3] = ARG_LINE_CD; 
				MyOraDB.Parameter_Name[4] = ARG_STYLE_CD;  
				MyOraDB.Parameter_Name[5] = OUT_CURSOR; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = arg_Factory;
				MyOraDB.Parameter_Values[1] = arg_obs_id_from;
				MyOraDB.Parameter_Values[2] = arg_obs_id_to;
				MyOraDB.Parameter_Values[3] = arg_line_cd;
				MyOraDB.Parameter_Values[4] = arg_style_cd;
				MyOraDB.Parameter_Values[5] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) dt = null ; 
				dt = ds_ret.Tables[MyOraDB.Process_Name]; 
			}
			catch
			{
				dt = null;
			}

			if(dt == null) return null;
			if(dt.Rows.Count < 1 ) return null;
			return dt;
		}

		
		private object Get_Delivery_Plan_Mes_Value(DataTable arg_TableSource, string arg_Factory,
			string arg_obs_id_from, string arg_obs_id_to, string arg_line_cd,
			string arg_style_cd, string arg_from_date)
		{
			if(arg_TableSource == null) return null;
			if(arg_TableSource.Rows.Count < 1) return null;
			DataRow[] dr = arg_TableSource.Select("OBS_ID = '" + arg_obs_id_from + 
				"' and LINE_CD = '"  + arg_line_cd + "' and STYLE_CD= '"+ arg_style_cd + "' and PLAN_YMD = '" + arg_from_date +"'");
			if(dr.Length > 0)
			{
				return Convert.ToDouble(dr[0]["QTYW"].ToString());
			}
			else
				return null;
		}

		
		private DataTable Get_Delivery_Plan_Mes(string arg_Factory,
			string arg_obs_id_from, string arg_obs_id_to, string arg_line_cd,
			string arg_style_cd)
		{
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;	
			DataTable dt = null;
			try
			{
				MyOraDB.ReDim_Parameter(6);  
				MyOraDB.Process_Name = "PKG_SVM_DELIVERY_PLAN.SP_SEL_DELIVERY_PLAN_MES_2";

				MyOraDB.Parameter_Name[0] = ARG_FACTORY; 
				MyOraDB.Parameter_Name[1] = ARG_OBS_ID_FROM; 
				MyOraDB.Parameter_Name[2] = ARG_OBS_ID_TO; 
				MyOraDB.Parameter_Name[3] = ARG_LINE_CD; 
				MyOraDB.Parameter_Name[4] = ARG_STYLE_CD; 
				MyOraDB.Parameter_Name[5] = OUT_CURSOR; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = arg_Factory;
				MyOraDB.Parameter_Values[1] = arg_obs_id_from;
				MyOraDB.Parameter_Values[2] = arg_obs_id_to;
				MyOraDB.Parameter_Values[3] = arg_line_cd;
				MyOraDB.Parameter_Values[4] = arg_style_cd.Replace("-","");
				MyOraDB.Parameter_Values[5] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) dt = null ; 
				dt = ds_ret.Tables[MyOraDB.Process_Name]; 
			}
			catch
			{
				dt = null;
			}

			if(dt == null) return null;
			if(dt.Rows.Count < 1 ) return null;
			return dt;
		}



		#endregion

		#region "Event"

		private void Form_Everyday_Fit_Delivery_Plan_Load(object sender, System.EventArgs e)
		{
			InitCellStyle();
			InitControl();
			Clear_FlexGrid(fgrid_main);
			InitHeader(fgrid_main, COM.ComFunction.Empty_Combo(cmb_obsid_fr,""),COM.ComFunction.Empty_Combo(cmb_obsid_to,""));
			setStyleList();

		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;				
				ResetControl();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;				
				ProcessSearch();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
	
		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Clear_FlexGrid(fgrid_main);
			setDPO();
		}

		private void txt_dpo_from_TextChanged(object sender, System.EventArgs e)
		{
			TextBox l_TextBox =(TextBox)sender;
			if(l_TextBox.Text.Length <8) return;
			tbtn_Search_Click(tbtn_Search,null);
		}

		private void txt_dpo_to_TextChanged(object sender, System.EventArgs e)
		{
			TextBox l_TextBox =(TextBox)sender;
			if(l_TextBox.Text.Length <8) return;
			tbtn_Search_Click(tbtn_Search,null);
		}

		private void txt_style_TextChanged(object sender, System.EventArgs e)
		{
			TextBox l_TextBox =(TextBox)sender;
			tbtn_Search_Click(tbtn_Search,null);
		}
		private void cmb_Line_SelectedValueChanged(object sender, EventArgs e)
		{
			tbtn_Search_Click(tbtn_Search,null);
		}
	
		#endregion
		
		private void setDPO()
		{			
			DataTable dt_ret = Select_DP_DPO_List(cmb_factory.SelectedValue.ToString(), "2" );
			_tbPOID = dt_ret;
			COM.ComCtl.Set_ComboList(dt_ret, cmb_obsid_fr, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
			cmb_obsid_fr.SelectedIndex = 0;

			COM.ComCtl.Set_ComboList(dt_ret, cmb_obsid_to, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
			cmb_obsid_to.SelectedIndex = 0;
		}

		/// <summary>
		/// Select_DP_DPO_List : dp, dpo list 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_division"></param>
		/// <returns></returns>
		public DataTable Select_DP_DPO_List(string arg_factory, string arg_division)
		{
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;			
			try
			{
				string process_name = "PKG_SBM_LLT_PLAN_TRACKING_VJ.SELECT_SBM_DP_DPO_LIST";

				MyOraDB.ReDim_Parameter(3);  
				MyOraDB.Process_Name = process_name;

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR"; 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_division;
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			}

		}

	
		private void setStyleList()
		{
			//			if (cmb_obs_id.SelectedIndex == -1)
			//				return;

			string[] args = new string[5];
			
			args[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			args[1] = COM.ComFunction.Empty_Combo(cmb_obsid_fr, "");
			args[2] = COM.ComFunction.Empty_Combo(cmb_obsid_to, "");
			args[3] = COM.ComFunction.Empty_TextBox(txt_style, "");
			args[4] = "2";

			DataTable dt_ret = this.SELECT_STYLE_LIST_DPDPO(args);
			if (dt_ret.Rows.Count > 0)
			{
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_StyleCd, 0, 1, true, 80, 130);
				cmb_StyleCd.SelectedIndex = 0;

			}
			dt_ret.Dispose();
		}

		
		/// <summary>
		/// SELECT_STYLE_LIST_DPDPO : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		private DataTable SELECT_STYLE_LIST_DPDPO(string[] arg_parameter)
		{
			COM.OraDB MyOraDB = new COM.OraDB(); 
			try 
			{
				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(6); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SVM_DELIVERY_PLAN.SELECT_STYLE_LIST_DPDPO"; 

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = ARG_FACTORY;
				MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE";
				MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";
				MyOraDB.Parameter_Name[3] = "ARG_SEARCH_TYPE";
				MyOraDB.Parameter_Name[4] = "ARG_STYLE";
				MyOraDB.Parameter_Name[5] = OUT_CURSOR;
      
				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_parameter[2]; 
				MyOraDB.Parameter_Values[3] = arg_parameter[4];
				MyOraDB.Parameter_Values[4] = arg_parameter[3];
				MyOraDB.Parameter_Values[5] = ""; 

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_STYLE_LIST_DPDPO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}
		}

		
		private void txt_style_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyData == Keys.Enter)
			{
				setStyleList();
			}
		}

		private void cmb_obsid_fr_TextChanged(object sender, System.EventArgs e)
		{
		
		}
		Margins _m = new Margins(0,0,0,0);

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_Print_Click();
		}


		public void Tbtn_Print_Click()
		{	
			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_Everyday_Fit_Delivery_Plan") ;
			string Para         = " ";
		

			int  iCnt  = 5;
			string [] aHead =  new string[iCnt];    
            
			aHead[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");	
			aHead[ 1]   = Convert.ToString(this.cmb_obsid_fr.SelectedValue);
			aHead[ 2]   = Convert.ToString(this.cmb_obsid_to.SelectedValue); 
			aHead[ 3]   = Convert.ToString(this.cmb_Line.SelectedValue) ; 
			aHead[ 4]   = Convert.ToString(this.cmb_StyleCd.SelectedValue).Replace("-",""); 
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			
			FlexVJ_Common.Report.Form_RdViewer report = new FlexVJ_Common.Report.Form_RdViewer(mrd_Filename, Para);			
			report.Show();
		}


	}
}

