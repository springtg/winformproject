using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.Data.SqlClient; 
using System.Data.OleDb;


namespace FlexOrder.ExpLoad
{
	public class Form_EL_MCR : COM.OrderWinForm.Form_Top
	{
		#region ��Ʈ�� �Ӽ�����
		public System.Windows.Forms.Panel pnl_Search;
		private System.Windows.Forms.Panel pnl_Search1_Image;
		private System.Windows.Forms.TextBox txt_OBS_Nu;
		private System.Windows.Forms.Label lbl_OBS_Nu;
		private C1.Win.C1List.C1Combo cmb_PO_TYPE;
		private System.Windows.Forms.Label lbl_PO_TYPE;
		private System.Windows.Forms.Label lbl_PO_ID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dpick_BEDAT2;
		private System.Windows.Forms.DateTimePicker dpick_BEDAT1;
		private System.Windows.Forms.TextBox txt_Seq;
		private System.Windows.Forms.Label lbl_OBS_SEQ_NU;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.TextBox txt_Style;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Label lbl_BEDAT;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Label lbl_STYLE_CD;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.Panel pnl_Body;
		private System.Windows.Forms.Panel pnl_progress;
		private System.Windows.Forms.Label lbl_m;
		private System.Windows.Forms.Label lbl_u;
		private System.Windows.Forms.Label lbl_s;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_3;
		private System.Windows.Forms.Label lbl_2;
		private System.Windows.Forms.Label lbl_1;
		public COM.FSP fgrid_EKPO;
		public COM.FSP fgrid_MARA;
		public COM.FSP fgrid_EKKO;
		public COM.FSP fgrid_EKET;
		private C1.Win.C1List.C1Combo cmb_OBS_ID;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem ctm_Request;
		private System.Windows.Forms.MenuItem ctm_OBS_Sel;
		private System.Windows.Forms.MenuItem ctm_OBS_HistSel;
		private System.Windows.Forms.MenuItem ctm_Bar_First;
		private System.Windows.Forms.MenuItem ctm_Verification;
		private System.Windows.Forms.Label btn_Upc_Load;
		private System.Windows.Forms.Label btn_Gac;
		private System.ComponentModel.IContainer components = null;

		public Form_EL_MCR()
		{
			// �� ȣ���� Windows Form �����̳ʿ� �ʿ��մϴ�.
			InitializeComponent();

			// TODO: InitializeComponent�� ȣ���� ���� �ʱ�ȭ �۾��� �߰��մϴ�.
		}

		/// <summary>
		/// ��� ���� ��� ���ҽ��� �����մϴ�.
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

		#endregion

		#region �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EL_MCR));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_Search1_Image = new System.Windows.Forms.Panel();
			this.btn_Gac = new System.Windows.Forms.Label();
			this.btn_Upc_Load = new System.Windows.Forms.Label();
			this.cmb_OBS_ID = new C1.Win.C1List.C1Combo();
			this.txt_OBS_Nu = new System.Windows.Forms.TextBox();
			this.lbl_OBS_Nu = new System.Windows.Forms.Label();
			this.cmb_PO_TYPE = new C1.Win.C1List.C1Combo();
			this.lbl_PO_TYPE = new System.Windows.Forms.Label();
			this.lbl_PO_ID = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dpick_BEDAT2 = new System.Windows.Forms.DateTimePicker();
			this.dpick_BEDAT1 = new System.Windows.Forms.DateTimePicker();
			this.txt_Seq = new System.Windows.Forms.TextBox();
			this.lbl_OBS_SEQ_NU = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.txt_Style = new System.Windows.Forms.TextBox();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.lbl_BEDAT = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.lbl_STYLE_CD = new System.Windows.Forms.Label();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.pnl_progress = new System.Windows.Forms.Panel();
			this.lbl_m = new System.Windows.Forms.Label();
			this.lbl_u = new System.Windows.Forms.Label();
			this.lbl_s = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_3 = new System.Windows.Forms.Label();
			this.lbl_2 = new System.Windows.Forms.Label();
			this.lbl_1 = new System.Windows.Forms.Label();
			this.fgrid_EKPO = new COM.FSP();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.ctm_Verification = new System.Windows.Forms.MenuItem();
			this.ctm_Request = new System.Windows.Forms.MenuItem();
			this.ctm_Bar_First = new System.Windows.Forms.MenuItem();
			this.ctm_OBS_Sel = new System.Windows.Forms.MenuItem();
			this.ctm_OBS_HistSel = new System.Windows.Forms.MenuItem();
			this.fgrid_MARA = new COM.FSP();
			this.fgrid_EKET = new COM.FSP();
			this.fgrid_EKKO = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_Search1_Image.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_PO_TYPE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_Body.SuspendLayout();
			this.pnl_progress.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EKPO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MARA)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EKET)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EKKO)).BeginInit();
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
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_Search1_Image);
			this.pnl_Search.DockPadding.All = 8;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1012, 152);
			this.pnl_Search.TabIndex = 37;
			// 
			// pnl_Search1_Image
			// 
			this.pnl_Search1_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search1_Image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_Search1_Image.Controls.Add(this.btn_Gac);
			this.pnl_Search1_Image.Controls.Add(this.btn_Upc_Load);
			this.pnl_Search1_Image.Controls.Add(this.cmb_OBS_ID);
			this.pnl_Search1_Image.Controls.Add(this.txt_OBS_Nu);
			this.pnl_Search1_Image.Controls.Add(this.lbl_OBS_Nu);
			this.pnl_Search1_Image.Controls.Add(this.cmb_PO_TYPE);
			this.pnl_Search1_Image.Controls.Add(this.lbl_PO_TYPE);
			this.pnl_Search1_Image.Controls.Add(this.lbl_PO_ID);
			this.pnl_Search1_Image.Controls.Add(this.label1);
			this.pnl_Search1_Image.Controls.Add(this.dpick_BEDAT2);
			this.pnl_Search1_Image.Controls.Add(this.dpick_BEDAT1);
			this.pnl_Search1_Image.Controls.Add(this.txt_Seq);
			this.pnl_Search1_Image.Controls.Add(this.lbl_OBS_SEQ_NU);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Factory);
			this.pnl_Search1_Image.Controls.Add(this.txt_Style);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Factory);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox2);
			this.pnl_Search1_Image.Controls.Add(this.lbl_SubTitle1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox5);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox8);
			this.pnl_Search1_Image.Controls.Add(this.lbl_BEDAT);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox7);
			this.pnl_Search1_Image.Controls.Add(this.lbl_STYLE_CD);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox10);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox11);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox12);
			this.pnl_Search1_Image.Location = new System.Drawing.Point(8, 8);
			this.pnl_Search1_Image.Name = "pnl_Search1_Image";
			this.pnl_Search1_Image.Size = new System.Drawing.Size(996, 136);
			this.pnl_Search1_Image.TabIndex = 0;
			// 
			// btn_Gac
			// 
			this.btn_Gac.ImageIndex = 0;
			this.btn_Gac.ImageList = this.img_Button;
			this.btn_Gac.Location = new System.Drawing.Point(680, 64);
			this.btn_Gac.Name = "btn_Gac";
			this.btn_Gac.Size = new System.Drawing.Size(80, 23);
			this.btn_Gac.TabIndex = 238;
			this.btn_Gac.Text = "GAC Load";
			this.btn_Gac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Gac.Click += new System.EventHandler(this.btn_Gac_Click);
			// 
			// btn_Upc_Load
			// 
			this.btn_Upc_Load.ImageIndex = 0;
			this.btn_Upc_Load.ImageList = this.img_Button;
			this.btn_Upc_Load.Location = new System.Drawing.Point(680, 36);
			this.btn_Upc_Load.Name = "btn_Upc_Load";
			this.btn_Upc_Load.Size = new System.Drawing.Size(80, 23);
			this.btn_Upc_Load.TabIndex = 237;
			this.btn_Upc_Load.Text = "UPC Load";
			this.btn_Upc_Load.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Upc_Load.Click += new System.EventHandler(this.btn_Upc_Load_Click);
			// 
			// cmb_OBS_ID
			// 
			this.cmb_OBS_ID.AddItemCols = 0;
			this.cmb_OBS_ID.AddItemSeparator = ';';
			this.cmb_OBS_ID.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_ID.Caption = "";
			this.cmb_OBS_ID.CaptionHeight = 17;
			this.cmb_OBS_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_ID.ColumnCaptionHeight = 18;
			this.cmb_OBS_ID.ColumnFooterHeight = 18;
			this.cmb_OBS_ID.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_ID.ContentHeight = 15;
			this.cmb_OBS_ID.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_ID.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OBS_ID.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_ID.EditorHeight = 15;
			this.cmb_OBS_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID.GapHeight = 2;
			this.cmb_OBS_ID.ItemHeight = 15;
			this.cmb_OBS_ID.Location = new System.Drawing.Point(111, 80);
			this.cmb_OBS_ID.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_ID.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_ID.MaxLength = 32767;
			this.cmb_OBS_ID.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_ID.Name = "cmb_OBS_ID";
			this.cmb_OBS_ID.PartialRightColumn = false;
			this.cmb_OBS_ID.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_OBS_ID.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_ID.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID.Size = new System.Drawing.Size(210, 19);
			this.cmb_OBS_ID.TabIndex = 171;
			// 
			// txt_OBS_Nu
			// 
			this.txt_OBS_Nu.BackColor = System.Drawing.Color.White;
			this.txt_OBS_Nu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_Nu.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_OBS_Nu.Location = new System.Drawing.Point(445, 58);
			this.txt_OBS_Nu.MaxLength = 10;
			this.txt_OBS_Nu.Name = "txt_OBS_Nu";
			this.txt_OBS_Nu.Size = new System.Drawing.Size(210, 21);
			this.txt_OBS_Nu.TabIndex = 170;
			this.txt_OBS_Nu.Text = "";
			// 
			// lbl_OBS_Nu
			// 
			this.lbl_OBS_Nu.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Nu.ImageIndex = 0;
			this.lbl_OBS_Nu.ImageList = this.img_Label;
			this.lbl_OBS_Nu.Location = new System.Drawing.Point(344, 58);
			this.lbl_OBS_Nu.Name = "lbl_OBS_Nu";
			this.lbl_OBS_Nu.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_Nu.TabIndex = 169;
			this.lbl_OBS_Nu.Text = "OBS Nu";
			this.lbl_OBS_Nu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_PO_TYPE
			// 
			this.cmb_PO_TYPE.AddItemCols = 0;
			this.cmb_PO_TYPE.AddItemSeparator = ';';
			this.cmb_PO_TYPE.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_PO_TYPE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_PO_TYPE.Caption = "";
			this.cmb_PO_TYPE.CaptionHeight = 17;
			this.cmb_PO_TYPE.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_PO_TYPE.ColumnCaptionHeight = 18;
			this.cmb_PO_TYPE.ColumnFooterHeight = 18;
			this.cmb_PO_TYPE.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_PO_TYPE.ContentHeight = 15;
			this.cmb_PO_TYPE.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_PO_TYPE.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_PO_TYPE.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_PO_TYPE.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_PO_TYPE.EditorHeight = 15;
			this.cmb_PO_TYPE.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_PO_TYPE.GapHeight = 2;
			this.cmb_PO_TYPE.ItemHeight = 15;
			this.cmb_PO_TYPE.Location = new System.Drawing.Point(111, 58);
			this.cmb_PO_TYPE.MatchEntryTimeout = ((long)(2000));
			this.cmb_PO_TYPE.MaxDropDownItems = ((short)(5));
			this.cmb_PO_TYPE.MaxLength = 32767;
			this.cmb_PO_TYPE.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_PO_TYPE.Name = "cmb_PO_TYPE";
			this.cmb_PO_TYPE.PartialRightColumn = false;
			this.cmb_PO_TYPE.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_PO_TYPE.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_PO_TYPE.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_PO_TYPE.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_PO_TYPE.Size = new System.Drawing.Size(210, 19);
			this.cmb_PO_TYPE.TabIndex = 168;
			this.cmb_PO_TYPE.TextChanged += new System.EventHandler(this.cmb_PO_TYPE_TextChanged);
			// 
			// lbl_PO_TYPE
			// 
			this.lbl_PO_TYPE.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_PO_TYPE.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_PO_TYPE.ImageIndex = 1;
			this.lbl_PO_TYPE.ImageList = this.img_Label;
			this.lbl_PO_TYPE.Location = new System.Drawing.Point(10, 58);
			this.lbl_PO_TYPE.Name = "lbl_PO_TYPE";
			this.lbl_PO_TYPE.Size = new System.Drawing.Size(100, 21);
			this.lbl_PO_TYPE.TabIndex = 167;
			this.lbl_PO_TYPE.Text = "OBS Type";
			this.lbl_PO_TYPE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_PO_ID
			// 
			this.lbl_PO_ID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_PO_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_PO_ID.ImageIndex = 1;
			this.lbl_PO_ID.ImageList = this.img_Label;
			this.lbl_PO_ID.Location = new System.Drawing.Point(10, 80);
			this.lbl_PO_ID.Name = "lbl_PO_ID";
			this.lbl_PO_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_PO_ID.TabIndex = 165;
			this.lbl_PO_ID.Text = "OBS ID";
			this.lbl_PO_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(210, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 16);
			this.label1.TabIndex = 164;
			this.label1.Text = "~";
			// 
			// dpick_BEDAT2
			// 
			this.dpick_BEDAT2.CustomFormat = "yyyy-MM-dd";
			this.dpick_BEDAT2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_BEDAT2.Location = new System.Drawing.Point(225, 103);
			this.dpick_BEDAT2.Name = "dpick_BEDAT2";
			this.dpick_BEDAT2.Size = new System.Drawing.Size(97, 20);
			this.dpick_BEDAT2.TabIndex = 163;
			this.dpick_BEDAT2.Value = new System.DateTime(2006, 9, 1, 0, 0, 0, 0);
			// 
			// dpick_BEDAT1
			// 
			this.dpick_BEDAT1.CustomFormat = "yyyy-MM-dd";
			this.dpick_BEDAT1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_BEDAT1.Location = new System.Drawing.Point(111, 103);
			this.dpick_BEDAT1.MaxDate = new System.DateTime(9998, 12, 19, 0, 0, 0, 0);
			this.dpick_BEDAT1.Name = "dpick_BEDAT1";
			this.dpick_BEDAT1.Size = new System.Drawing.Size(97, 20);
			this.dpick_BEDAT1.TabIndex = 162;
			this.dpick_BEDAT1.Value = new System.DateTime(2006, 9, 1, 0, 0, 0, 0);
			// 
			// txt_Seq
			// 
			this.txt_Seq.BackColor = System.Drawing.Color.White;
			this.txt_Seq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Seq.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Seq.Location = new System.Drawing.Point(445, 80);
			this.txt_Seq.MaxLength = 10;
			this.txt_Seq.Name = "txt_Seq";
			this.txt_Seq.Size = new System.Drawing.Size(210, 21);
			this.txt_Seq.TabIndex = 113;
			this.txt_Seq.Text = "";
			// 
			// lbl_OBS_SEQ_NU
			// 
			this.lbl_OBS_SEQ_NU.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_SEQ_NU.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_SEQ_NU.ImageIndex = 0;
			this.lbl_OBS_SEQ_NU.ImageList = this.img_Label;
			this.lbl_OBS_SEQ_NU.Location = new System.Drawing.Point(344, 80);
			this.lbl_OBS_SEQ_NU.Name = "lbl_OBS_SEQ_NU";
			this.lbl_OBS_SEQ_NU.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_SEQ_NU.TabIndex = 112;
			this.lbl_OBS_SEQ_NU.Text = "Seq No";
			this.lbl_OBS_SEQ_NU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 18;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Style
			// 
			this.txt_Style.BackColor = System.Drawing.Color.White;
			this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Style.Location = new System.Drawing.Point(445, 36);
			this.txt_Style.MaxLength = 10;
			this.txt_Style.Name = "txt_Style";
			this.txt_Style.Size = new System.Drawing.Size(210, 21);
			this.txt_Style.TabIndex = 108;
			this.txt_Style.Text = "";
			// 
			// cmb_Factory
			// 
			this.cmb_Factory.AddItemCols = 0;
			this.cmb_Factory.AddItemSeparator = ';';
			this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory.Caption = "";
			this.cmb_Factory.CaptionHeight = 17;
			this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory.ColumnCaptionHeight = 18;
			this.cmb_Factory.ColumnFooterHeight = 18;
			this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory.ContentHeight = 15;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 15;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(111, 37);
			this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory.MaxDropDownItems = ((short)(5));
			this.cmb_Factory.MaxLength = 32767;
			this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory.Name = "cmb_Factory";
			this.cmb_Factory.PartialRightColumn = false;
			this.cmb_Factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory.TabIndex = 37;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(974, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(22, 32);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(168, -1);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(812, 32);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(172, 32);
			this.lbl_SubTitle1.TabIndex = 0;
			this.lbl_SubTitle1.Text = "      OBS Info.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(977, 32);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(19, 90);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.Color.Blue;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(906, 122);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(90, 14);
			this.pictureBox8.TabIndex = 8;
			this.pictureBox8.TabStop = false;
			// 
			// lbl_BEDAT
			// 
			this.lbl_BEDAT.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_BEDAT.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_BEDAT.ImageIndex = 1;
			this.lbl_BEDAT.ImageList = this.img_Label;
			this.lbl_BEDAT.Location = new System.Drawing.Point(10, 102);
			this.lbl_BEDAT.Name = "lbl_BEDAT";
			this.lbl_BEDAT.Size = new System.Drawing.Size(100, 21);
			this.lbl_BEDAT.TabIndex = 19;
			this.lbl_BEDAT.Text = "Doc Date";
			this.lbl_BEDAT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(0, 24);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(32, 101);
			this.pictureBox7.TabIndex = 3;
			this.pictureBox7.TabStop = false;
			// 
			// lbl_STYLE_CD
			// 
			this.lbl_STYLE_CD.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_STYLE_CD.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_STYLE_CD.ImageIndex = 0;
			this.lbl_STYLE_CD.ImageList = this.img_Label;
			this.lbl_STYLE_CD.Location = new System.Drawing.Point(344, 36);
			this.lbl_STYLE_CD.Name = "lbl_STYLE_CD";
			this.lbl_STYLE_CD.Size = new System.Drawing.Size(100, 21);
			this.lbl_STYLE_CD.TabIndex = 21;
			this.lbl_STYLE_CD.Text = "Style";
			this.lbl_STYLE_CD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.Color.Navy;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(32, 24);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(948, 104);
			this.pictureBox10.TabIndex = 4;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox11.BackColor = System.Drawing.Color.Blue;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(0, 122);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(80, 14);
			this.pictureBox11.TabIndex = 6;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.Color.Blue;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(72, 122);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(908, 14);
			this.pictureBox12.TabIndex = 9;
			this.pictureBox12.TabStop = false;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.pnl_progress);
			this.pnl_Body.Controls.Add(this.fgrid_EKPO);
			this.pnl_Body.Controls.Add(this.fgrid_MARA);
			this.pnl_Body.Controls.Add(this.fgrid_EKET);
			this.pnl_Body.Controls.Add(this.fgrid_EKKO);
			this.pnl_Body.DockPadding.Left = 8;
			this.pnl_Body.DockPadding.Right = 8;
			this.pnl_Body.Location = new System.Drawing.Point(0, 224);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1012, 416);
			this.pnl_Body.TabIndex = 40;
			// 
			// pnl_progress
			// 
			this.pnl_progress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_progress.BackgroundImage")));
			this.pnl_progress.Controls.Add(this.lbl_m);
			this.pnl_progress.Controls.Add(this.lbl_u);
			this.pnl_progress.Controls.Add(this.lbl_s);
			this.pnl_progress.Controls.Add(this.progressBar1);
			this.pnl_progress.Controls.Add(this.label3);
			this.pnl_progress.Controls.Add(this.lbl_3);
			this.pnl_progress.Controls.Add(this.lbl_2);
			this.pnl_progress.Controls.Add(this.lbl_1);
			this.pnl_progress.Location = new System.Drawing.Point(632, 200);
			this.pnl_progress.Name = "pnl_progress";
			this.pnl_progress.Size = new System.Drawing.Size(368, 175);
			this.pnl_progress.TabIndex = 42;
			// 
			// lbl_m
			// 
			this.lbl_m.BackColor = System.Drawing.Color.Transparent;
			this.lbl_m.Location = new System.Drawing.Point(144, 126);
			this.lbl_m.Name = "lbl_m";
			this.lbl_m.Size = new System.Drawing.Size(208, 14);
			this.lbl_m.TabIndex = 33;
			// 
			// lbl_u
			// 
			this.lbl_u.BackColor = System.Drawing.Color.Transparent;
			this.lbl_u.Location = new System.Drawing.Point(144, 108);
			this.lbl_u.Name = "lbl_u";
			this.lbl_u.Size = new System.Drawing.Size(208, 14);
			this.lbl_u.TabIndex = 32;
			// 
			// lbl_s
			// 
			this.lbl_s.BackColor = System.Drawing.Color.Transparent;
			this.lbl_s.Location = new System.Drawing.Point(144, 88);
			this.lbl_s.Name = "lbl_s";
			this.lbl_s.Size = new System.Drawing.Size(216, 14);
			this.lbl_s.TabIndex = 31;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(27, 144);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(317, 20);
			this.progressBar1.TabIndex = 30;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkGreen;
			this.label3.Location = new System.Drawing.Point(32, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 14);
			this.label3.TabIndex = 17;
			this.label3.Text = "Upload Status...";
			// 
			// lbl_3
			// 
			this.lbl_3.BackColor = System.Drawing.Color.Transparent;
			this.lbl_3.ForeColor = System.Drawing.Color.Silver;
			this.lbl_3.Location = new System.Drawing.Point(27, 124);
			this.lbl_3.Name = "lbl_3";
			this.lbl_3.Size = new System.Drawing.Size(104, 16);
			this.lbl_3.TabIndex = 16;
			this.lbl_3.Text = "   Style Upload";
			// 
			// lbl_2
			// 
			this.lbl_2.BackColor = System.Drawing.Color.Transparent;
			this.lbl_2.ForeColor = System.Drawing.Color.Silver;
			this.lbl_2.Location = new System.Drawing.Point(27, 106);
			this.lbl_2.Name = "lbl_2";
			this.lbl_2.Size = new System.Drawing.Size(104, 16);
			this.lbl_2.TabIndex = 15;
			this.lbl_2.Text = "   Data Upload";
			// 
			// lbl_1
			// 
			this.lbl_1.BackColor = System.Drawing.Color.Transparent;
			this.lbl_1.ForeColor = System.Drawing.Color.SaddleBrown;
			this.lbl_1.Location = new System.Drawing.Point(27, 88);
			this.lbl_1.Name = "lbl_1";
			this.lbl_1.Size = new System.Drawing.Size(101, 14);
			this.lbl_1.TabIndex = 11;
			this.lbl_1.Text = "   Style Check ";
			// 
			// fgrid_EKPO
			// 
			this.fgrid_EKPO.AutoResize = false;
			this.fgrid_EKPO.BackColor = System.Drawing.Color.White;
			this.fgrid_EKPO.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_EKPO.ColumnInfo = "2,1,0,0,0,85,Columns:";
			this.fgrid_EKPO.ContextMenu = this.contextMenu1;
			this.fgrid_EKPO.ForeColor = System.Drawing.Color.Black;
			this.fgrid_EKPO.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_EKPO.Location = new System.Drawing.Point(8, 32);
			this.fgrid_EKPO.Name = "fgrid_EKPO";
			this.fgrid_EKPO.Rows.Count = 2;
			this.fgrid_EKPO.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_EKPO.Size = new System.Drawing.Size(992, 144);
			this.fgrid_EKPO.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_EKPO.TabIndex = 38;
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.ctm_Verification,
																						 this.ctm_Request,
																						 this.ctm_Bar_First,
																						 this.ctm_OBS_Sel,
																						 this.ctm_OBS_HistSel});
			// 
			// ctm_Verification
			// 
			this.ctm_Verification.Index = 0;
			this.ctm_Verification.Text = "OBS Verification";
			// 
			// ctm_Request
			// 
			this.ctm_Request.Index = 1;
			this.ctm_Request.Text = "OBS Request";
			// 
			// ctm_Bar_First
			// 
			this.ctm_Bar_First.Index = 2;
			this.ctm_Bar_First.Text = "-";
			// 
			// ctm_OBS_Sel
			// 
			this.ctm_OBS_Sel.Index = 3;
			this.ctm_OBS_Sel.Text = "OBS By Option";
			// 
			// ctm_OBS_HistSel
			// 
			this.ctm_OBS_HistSel.Index = 4;
			this.ctm_OBS_HistSel.Text = "OBS History";
			// 
			// fgrid_MARA
			// 
			this.fgrid_MARA.AutoResize = false;
			this.fgrid_MARA.BackColor = System.Drawing.Color.White;
			this.fgrid_MARA.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_MARA.ColumnInfo = "2,1,0,0,0,85,Columns:";
			this.fgrid_MARA.ForeColor = System.Drawing.Color.Black;
			this.fgrid_MARA.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_MARA.Location = new System.Drawing.Point(424, 200);
			this.fgrid_MARA.Name = "fgrid_MARA";
			this.fgrid_MARA.Rows.Count = 2;
			this.fgrid_MARA.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_MARA.Size = new System.Drawing.Size(192, 176);
			this.fgrid_MARA.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_MARA.TabIndex = 41;
			// 
			// fgrid_EKET
			// 
			this.fgrid_EKET.AutoResize = false;
			this.fgrid_EKET.BackColor = System.Drawing.Color.White;
			this.fgrid_EKET.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_EKET.ColumnInfo = "2,1,0,0,0,85,Columns:";
			this.fgrid_EKET.ForeColor = System.Drawing.Color.Black;
			this.fgrid_EKET.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_EKET.Location = new System.Drawing.Point(216, 200);
			this.fgrid_EKET.Name = "fgrid_EKET";
			this.fgrid_EKET.Rows.Count = 2;
			this.fgrid_EKET.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_EKET.Size = new System.Drawing.Size(200, 176);
			this.fgrid_EKET.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_EKET.TabIndex = 39;
			// 
			// fgrid_EKKO
			// 
			this.fgrid_EKKO.AutoResize = false;
			this.fgrid_EKKO.BackColor = System.Drawing.Color.White;
			this.fgrid_EKKO.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_EKKO.ColumnInfo = "2,1,0,0,0,85,Columns:";
			this.fgrid_EKKO.ForeColor = System.Drawing.Color.Black;
			this.fgrid_EKKO.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_EKKO.Location = new System.Drawing.Point(8, 200);
			this.fgrid_EKKO.Name = "fgrid_EKKO";
			this.fgrid_EKKO.Rows.Count = 2;
			this.fgrid_EKKO.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_EKKO.Size = new System.Drawing.Size(200, 176);
			this.fgrid_EKKO.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_EKKO.TabIndex = 37;
			// 
			// Form_EL_MCR
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Search);
			this.Font = new System.Drawing.Font("Verdana", 8F);
			this.Name = "Form_EL_MCR";
			this.Load += new System.EventHandler(this.Form_EL_MCR_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_Search1_Image.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_PO_TYPE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			this.pnl_progress.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EKPO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MARA)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EKET)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EKKO)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region �Ӽ� ����

		private int _Rowfixed=2; 

		private OleDbDataReader reader_EKKO;
		private OleDbDataReader reader_EKPO;
		private OleDbDataReader reader_EKET;
		private OleDbDataReader reader_MARA;
		private DateTime CurDate = DateTime.Now;
		private COM.ComFunction MyComFunction    = new COM.ComFunction();

		
		private COM.OraDB MyOraDB = new COM.OraDB(); 
		private ClassLib.OraDB  MyClassLib = new ClassLib.OraDB(); 

		#endregion

		#region ��� �޼��� 

		private void Init_Form()
		{ 
			//Title
			this.Text = "GPO Loading";
			this.lbl_MainTitle.Text = "GPO Loading"; 
			ClassLib.ComFunction.SetLangDic(this);

			#region ��ư ����
			tbtn_Append.Enabled = false;
			tbtn_Color.Enabled =false;
			tbtn_Create.Enabled =false;
			tbtn_Delete.Enabled =false;
			tbtn_Insert.Enabled =false;
			tbtn_New.Enabled =true;
			tbtn_Print.Enabled =false;
			tbtn_Save.Enabled =true;
			tbtn_Search.Enabled =true;


			#endregion


			DataTable dt_list; 
			//DateTime CurDate = DateTime.Now;			
		
			// �׸��� ����
			fgrid_EKKO.Set_Grid( "SEM_EKKO", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);  
			_Rowfixed = fgrid_EKKO.Rows.Fixed;	

			fgrid_EKPO.Set_Grid( "SEM_EKPO", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);
			fgrid_EKPO.Font  = new Font("Verdana",8);

			fgrid_EKET.Set_Grid( "SEM_EKET", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);  
			fgrid_EKET.Font  = new Font("Verdana",8);

			fgrid_MARA.Set_Grid( "SEM_MARA", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);  
			fgrid_MARA.Font  = new Font("Verdana",8);

			// �޺��ڽ� ����
			///Factory
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			///PO_TYPE
			dt_list = Select_PO_TYPE();
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_PO_TYPE, 0, 1); 
			cmb_PO_TYPE.SelectedIndex = 0;


			//Date			
			dpick_BEDAT1.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			string now  = System.DateTime.Now.ToString("yyyyMMdd");
			dpick_BEDAT1.Text = MyComFunction.ConvertDate2Type(now);
			
		    
			
			dpick_BEDAT2.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			now  = System.DateTime.Now.ToString("yyyyMMdd");
			dpick_BEDAT2.Text =  MyComFunction.ConvertDate2Type(now);

			fgrid_EKPO.Dock = DockStyle.Fill;
			pnl_progress.Visible = false;
			pnl_progress.Location = new Point(344, 64);

		}

		

		private void SB_Pop_Up(string arg_flag)
		{
			FlexOrder.ExpLoad.POP_EL_RPM  pop_form = new ExpLoad.POP_EL_RPM();

			COM.ComVar.Parameter_PopUp = new string[] 
			{
				cmb_Factory.SelectedValue.ToString(),
				cmb_OBS_ID.Text,
				cmb_PO_TYPE.Columns[1].Text,
				(arg_flag=="01")?txt_Style.Text:
				fgrid_EKPO[fgrid_EKPO.Selection.r1 ,(int)(int)ClassLib.TBSEM_EKPO.IxMATNR].ToString().Replace("-",""),

				(arg_flag=="01")?txt_OBS_Nu.Text: 
				fgrid_EKPO[fgrid_EKPO.Selection.r1 ,(int)(int)ClassLib.TBSEM_EKPO.IxOBS_NU].ToString(),

				(arg_flag=="01")?txt_Seq.Text:
				fgrid_EKPO[fgrid_EKPO.Selection.r1 ,(int)(int)ClassLib.TBSEM_EKPO.IxOBS_SEQ_NU].ToString(),
			};
				
			pop_form.ShowDialog();

		}


		private void SB_Pop_UPC_Load()
		{
			FlexOrder.ExpLoad.POP_EL_UPC_LOAD  pop_form = new ExpLoad.POP_EL_UPC_LOAD();
	
			COM.ComVar.Parameter_PopUp = new string[]
			{
				cmb_Factory.SelectedValue.ToString(),
				cmb_OBS_ID.Text,
				cmb_PO_TYPE.Columns[1].Text
			};
				
			pop_form.ShowDialog();



		}



		
		private void SB_Pop_GAC_Load()
		{
			FlexOrder.ExpLoad.POP_EL_GAC_LOAD  pop_form = new ExpLoad.POP_EL_GAC_LOAD();
	
			COM.ComVar.Parameter_PopUp = new string[]
			{
				cmb_Factory.SelectedValue.ToString(),
				dpick_BEDAT1.Text,
				dpick_BEDAT2.Text
			};
				
			pop_form.ShowDialog();



		}





		private bool Check_Select()
		{
		  
			if (cmb_PO_TYPE.SelectedValue  == null)
				return false;

			if (cmb_OBS_ID.Text == null)
				return false;

			return true;

		}


//
//		private bool Check_Document_Data(string arg_type)
//		{
//
////			string vFromDate  = dpick_BEDAT1.Text.Substring(0,8).ToString());
////			string vToDate    = dpick_BEDAT2.Text.Substring(0,8).ToString());
////				
////			switch(arg_type)       
////			{         
////				case "OR" :
////
////				case "ID" :
////				for(i = -7; i <= 3; i++)					
////				{					
////					sDate1 = CurDate.AddMonths(i).ToString("yyyy-MM-dd");						
////					sDate1 = sDate1.Substring(2,2) + sDate1.Substring(5,2) + "01";
////
////					arg_cmb.AddItem(sDate1);
////				}
////
////					arg_cmb.SelectedIndex = 3;													
////					break;		
////
////					case "QQ" :            
////
////					for(i = -3; i <= 3; i++)					
////					{					
////						sDate1 = CurDate.AddMonths(i).ToString("yyyy-MM-dd");						
////						sDate2 = CurDate.AddMonths(i+1).ToString("yyyy-MM-dd");
////										
////						sDate1 = sDate1.Substring(2,2) + sDate1.Substring(5,2) + sDate2.Substring(5,2);;
////
////						arg_cmb.AddItem(sDate1);
////					}
////
////					arg_cmb.SelectedIndex = 3;													
////					break;					
////
////					default:            
////					for(i = -7; i <= 3; i++)										
////				{
////					sDate1 = CurDate.AddMonths(i).ToString("yyyy-MM-dd");						
////					sDate2 = CurDate.AddMonths(i+2).ToString("yyyy-MM-dd");
////										
////					sDate1 = sDate1.Substring(2,2) + sDate1.Substring(5,2) + sDate2.Substring(5,2);						
////
////					arg_cmb.AddItem(sDate1);
////				}
////										
////										
////					arg_cmb.SelectedIndex = 5;																
////					break;
////				}
//
//			   return;
//
//			}



		#endregion

		#region DB ��Ʈ��
		private static DataTable Select_PO_TYPE()
		{
 
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet ds_ret;
 
			MyOraDB.ReDim_Parameter(1); 

			//01.PROCEDURE��
			MyOraDB.Process_Name = "PKG_SEM_GPO.SELECT_PO_TYPE";
 
			//02.ARGURMENT��
			MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
			 
			//04.DATA ����  
			MyOraDB.Parameter_Values[0] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 
 
		}


		private static DataTable Select_Last_OBSID(string arg_factory, string arg_obs_type)
		{

			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE��
			MyOraDB.Process_Name = "PKG_SEM_GPO.SELECT_LAST_OBSID";

			//02.ARGURMENT��
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA ����  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_obs_type;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);

			ds_ret = MyOraDB.Exe_Select_Procedure();

			if (ds_ret == null) return null;

			return ds_ret.Tables[MyOraDB.Process_Name];

		}



		/// <summary>
		/// Select_DPO_List
		/// </summary>
		private void Select_GPO_List()
		{
			fgrid_EKKO.Rows.Count = _Rowfixed;
			fgrid_EKPO.Rows.Count = _Rowfixed;
			fgrid_EKET.Rows.Count = _Rowfixed;
			fgrid_MARA.Rows.Count = _Rowfixed;


			string strSql_EKKO = " SELECT LIFNR AS FACTORY, (CASE WHEN PO_REF IS NULL THEN  EBELN ELSE PO_REF END)  AS OBS_NU, " + cmb_OBS_ID.Text.ToString() +    "," +
				"         EBELN, REPLACE(CONVERT(VARCHAR(10),BEDAT,120),'-',''), BUKRS, EKORG, EKGRP, LIFN2, BSART, WAERS, WKURS,      " +
				"        INCO1, INCO2, REPLACE(CONVERT(VARCHAR(10),AEDAT,120),'-',''), ERNAM,  REPLACE(CONVERT(VARCHAR(10),FFS_CHNG_DTTM,120),'-',''), SNDPRN, ZTERM,    " +
				"        ZZSESN_CD, ZZSESN_YR, BUY_GRP_CD, LIFNR, FFS_VNDR_LOC_CD,     " +
				"'" + ClassLib.ComVar.This_User+ "',"+
				"'"+ System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +"'"+
				"   FROM EKKO" +
				"  WHERE LIFNR       = '" + cmb_Factory.SelectedValue.ToString()  + "'" +
				"    AND BEDAT      >= '" + dpick_BEDAT1.Text                     + "'" +
				"    AND BEDAT      <= '" +
				dpick_BEDAT2.Text                     + "'" +
				"    AND (EBELN LIKE '" + txt_OBS_Nu.Text																+ "%' OR " +
				"         PO_REF LIKE '" + txt_OBS_Nu.Text 															+ "%')" +
				"    AND BUY_GRP_CD  = '" + cmb_PO_TYPE.SelectedValue.ToString()  + "'" ;


			

      
			string strSql_EKPO ="   SELECT K.LIFNR AS FACTORY,  (CASE WHEN K.PO_REF IS NULL THEN  K.EBELN ELSE K.PO_REF END) AS OBS_NU,   " +
				"       P.EBELP AS OBS_SEQ_NU, " + cmb_OBS_ID.Text.ToString() +  "," +
				"		REPLACE(CONVERT(VARCHAR(10),K.BEDAT,120),'-','') , P.FFS_MSR_IND AS MSR_DIV,   P.MVGR2 AS LCH_DIV,                       " +
				"		P.EBELN, P.EBELP, (SUBSTRING(MATNR, 1, 6)+SUBSTRING(MATNR, 8, 3)) AS MATNR,             " +
				"	    P.TXZ01,  P.BUKRS,   P.WERKS,   P.SPART,  FLOOR(P.MENGE), P.MEINS,   P.NETPR,          " +
				"		P.NTGEW,  P.EVERS,   P.EVTXT,      P.PSTYP,					" +
				"       P.KNTTP,   REPLACE(CONVERT(VARCHAR(10),P.J_3AEXFCP,120),'-',''), REPLACE(CONVERT(VARCHAR(10),P.ZZ_GAC_DT,120),'-',''),  REPLACE(CONVERT(VARCHAR(10),P.ZZ_GAC_RSN_CD,120),'-',''),   REPLACE(CONVERT(VARCHAR(10),P.FFS_GAC_DT_RQST,120),'-','')," +
				"		P.FFS_GAC_RSN_CD_RQST,   P.FFS_GAC_SND_RQST_FL,  P.BSTNK,   REPLACE(CONVERT(VARCHAR(10),P.VDATU,120),'-',''),   REPLACE(CONVERT(VARCHAR(10),P.FKDAT,120),'-',''),         " +
				"		REPLACE(CONVERT(VARCHAR(10),P.EINDT,120),'-',''), REPLACE(CONVERT(VARCHAR(10),P.SLFDT,120),'-',''),   P.MVGR2,   P.BSGRU,   P.BISMT, P.ZZ_SILH_CD,				" +
				"		P.ZZ_GNDRAGE, P.SOVBELN, P.SOVBELP, ' ' AS SO_CUST_DEPT, ' ' AS  SO_CUST_DEPT_DESC,  " +
				"		P.J_4KSCAT, P.FFS_STENCIL_SHIPTO , P.FFS_STENCIL_DEST, P.FFS_STENCIL_ORIGIN, P.KUNNR, " +
				"		P.FFS_SHP_TO_ACCT, P.WAERS,  P.PO_ITEM_STATUS,    " +
				"       ' '   AS COLORCOMBNAME      ,"+
				"       ' '   AS COLORCOMBSHORTNAME ,"+	
				"       REPLACE(CONVERT(VARCHAR(10),RGAC_DT_DTTM,120),'-','')            AS RGAC_DATE          ,"+
				"       'G'                     AS OBS_DIV            ,"+
				"'" +   ClassLib.ComVar.This_User+ "',"+
				"'" +    System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +"',"+
				"       (CASE WHEN K.PO_REF IS  NULL THEN  NULL ELSE K.EBELN END) AS TRADE_CO_PO_NU, "+
				"       ' ' AS TRADE_CO_PLANT, ' ' AS TRADE_CO_PLANT_DESC, ' ' AS UOM, K.TTMI AS TTMI, K.PO_REF "+
				"   FROM EKKO K, EKPO P LEFT OUTER JOIN EKETVAS V 									                 " +  
				"         ON P.EBELN = V.EBELN																		 " +
				"        AND P.EBELP = V.EBELP                                                                       " + 
				"        AND V.ETENR = '1'                                                                           " + 
				"  WHERE K.EBELN  = P.EBELN  																		 " +
				"    AND K.LIFNR  =  '" + cmb_Factory.SelectedValue.ToString()                                          + "'" +
				"    AND K.BEDAT >= '" + dpick_BEDAT1.Text                                                              + "'" +
				"    AND K.BEDAT <= '" + dpick_BEDAT2.Text                                                              + "'" +
				"    AND K.BUY_GRP_CD = '" + cmb_PO_TYPE.SelectedValue.ToString()                                       + "'" +
				"    AND (K.EBELN LIKE '" + txt_OBS_Nu.Text																+ "%' OR " +
				"         K.PO_REF LIKE '" + txt_OBS_Nu.Text 															+ "%')" +
				"    AND P.EBELP LIKE '" + txt_Seq.Text																    + "%'" +
				"    AND REPLACE(P.MATNR,'-','') LIKE '" + txt_Style.Text												+ "%'" +
				"  ORDER BY K.EBELN, P.EBELP																			     " ;


	

			string strSql_EKET =" SELECT K.LIFNR AS FACTORY, (CASE WHEN K.PO_REF IS NULL THEN  K.EBELN ELSE K.PO_REF END) AS OBS_NU, "+
				"        E.EBELP AS OBS_SEQ_NU, E.J_3ASIZE AS CS_SIZE, " +
				"        E.EBELN, E.EBELP, E.ETENR, E.J_3ASIZE, E.MENGE, E.MEINS, E.J_3ANETP, E.KEBTR,        " + 
				"        E.EAN11, E.J_4KSCAT, E.EINDT, E.SLFDT, E.FFS_CHNG_DTTM, E.BAR_CODE, E.CHECK_DIGIT,   " +
				"        (CASE WHEN E.ETENR = 1 THEN 'Y' ELSE 'N' END)  FIRST_DIV,							  " +
				"       'G'  AS OBS_DIV,							  " +
				"'" +   ClassLib.ComVar.This_User+ "',"+
				"'" +   System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +"'"+
				"   FROM EKKO K, EKET E, EKPO P                                                               " + 
				"  WHERE K.EBELN = E.EBELN                                                                    " +
				"    AND E.EBELN = P.EBELN                                                                    " +
				"    AND E.EBELP = P.EBELP                                                                    " +
				"    AND K.LIFNR  =  '" + cmb_Factory.SelectedValue.ToString()                            + "'" +
				"    AND K.BEDAT >= '" + dpick_BEDAT1.Text                                                + "'" +
				"    AND K.BEDAT <= '" + dpick_BEDAT2.Text                                                + "'" +
				"    AND K.BUY_GRP_CD = '" + cmb_PO_TYPE.SelectedValue.ToString()                                       + "'" +
				"    AND (K.EBELN LIKE '" + txt_OBS_Nu.Text																+ "%' OR " +
				"         K.PO_REF LIKE '" + txt_OBS_Nu.Text 															+ "%')" +
				"    AND P.EBELP LIKE '" + txt_Seq.Text																 + "%'" +
				"    AND REPLACE(P.MATNR,'-','') LIKE '" + txt_Style.Text												 + "%'" +
				"    AND E.MENGE IS NOT NULL " +
				"  ORDER BY E.EBELN, E.EBELP, E.ETENR                                                         " ;



			string strSql_MARA =" SELECT B.LIFNR AS FACTORY,A.STYLE_CD, A.STYLE_CD,																   "+
				"		 A.MATERIALNAME, A.MATERIALSHORTNAME, A.COLORCOMBNAME, A.COLORCOMBSHORTNAME,               " +
				"		 A.DIVISION, A.CATEGORY,A.CATEGORYNAME, A.SUBCATEGORY, A.SUBCATEGORYNAME,                  " +
				"		 A.GENDERAGE, A.GENDERAGENAME,A.FIRSTPRODUCTOFFER_DTTM, A.ENDFUTUREOFFER_DTTM,             " + 
				"		 A.ENDPRODUCTOFFER_DTTM,                                                                   " + 
				"		 A.WIDTH, A.MATERIALCONTENT, A.OUTSOLE,                                                    " +
				"		 ISNULL(A.FFS_TEXTILE_CAT, 0), ISNULL(A.FFS_CRTN_TYP, 0), ISNULL(A.FFS_PACK_FACTOR, 0),    " +         
				"		 A.FFS_CHNG_DTTM,																		   " +
				"'" +    ClassLib.ComVar.This_User+ "',"+
				"'" +	 System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +"'"+
				"  FROM																						       " +
				"		(SELECT P.EBELN, (SUBSTRING(M.MATNR,1,6)+SUBSTRING(M.MATNR,8,3)) AS STYLE_CD, M.MATNR ,    " +    
				"				M.MATERIALNAME, M.MATERIALSHORTNAME, M.COLORCOMBNAME, M.COLORCOMBSHORTNAME,		   " +
				"				M.DIVISION, M.CATEGORY,M.CATEGORYNAME, M.SUBCATEGORY, M.SUBCATEGORYNAME,		   " +
				"				M.GENDERAGE, M.GENDERAGENAME,M.FIRSTPRODUCTOFFER_DTTM, M.ENDFUTUREOFFER_DTTM,	   " +
				"				M.ENDPRODUCTOFFER_DTTM,                                                            " +
				"				M.WIDTH, M.MATERIALCONTENT, M.OUTSOLE,											   " +
				"				ISNULL(M.FFS_TEXTILE_CAT, 0) FFS_TEXTILE_CAT,									   " +
				"       		ISNULL(M.FFS_CRTN_TYP, 0)  FFS_CRTN_TYP,										   " +
				"               ISNULL(M.FFS_PACK_FACTOR, 0) FFS_PACK_FACTOR,                                      " +  
				"				M.FFS_CHNG_DTTM																	   " +
				"		   FROM MARA M , EKPO P																	   " +
				"		  WHERE M.MATNR = P.MATNR) A,															   " +
				"				EKKO B										       " +
				" WHERE B.LIFNR  = '" + cmb_Factory.SelectedValue.ToString()	   + "'" +
				"   AND B.BEDAT >= '" + dpick_BEDAT1.Text						   + "'" +
				"   AND B.BEDAT <= '" + dpick_BEDAT2.Text						   + "'" +
				"   AND B.BUY_GRP_CD = '" + cmb_PO_TYPE.SelectedValue.ToString()   + "'" +
				"   AND (B.EBELN LIKE '" + txt_OBS_Nu.Text																+ "%' OR " +
				"         B.PO_REF LIKE '" + txt_OBS_Nu.Text 															+ "%')" +
				"   AND REPLACE(A.MATNR,'-','') LIKE '" + txt_Style.Text												 + "%'" +
				"   AND A.EBELN  = B.EBELN";


			fgrid_EKKO.Rows.Count = _Rowfixed;  
			
			DataTable dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSQL);

			reader_EKKO = ClassLib.ComFunction.Read_MSSQL(strSql_EKKO, 
				dt_list.Rows[0].ItemArray[1].ToString(), 
				dt_list.Rows[0].ItemArray[3].ToString(), 
				dt_list.Rows[0].ItemArray[5].ToString() );	       

			
			reader_EKPO = ClassLib.ComFunction.Read_MSSQL(strSql_EKPO, 
				dt_list.Rows[0].ItemArray[1].ToString(), 
				dt_list.Rows[0].ItemArray[3].ToString(), 
				dt_list.Rows[0].ItemArray[5].ToString() );	       

            
			reader_EKET = ClassLib.ComFunction.Read_MSSQL(strSql_EKET, 
				dt_list.Rows[0].ItemArray[1].ToString(), 
				dt_list.Rows[0].ItemArray[3].ToString(), 
				dt_list.Rows[0].ItemArray[5].ToString() );	     

			reader_MARA = ClassLib.ComFunction.Read_MSSQL(strSql_MARA, 
				dt_list.Rows[0].ItemArray[1].ToString(), 
				dt_list.Rows[0].ItemArray[3].ToString(), 
				dt_list.Rows[0].ItemArray[5].ToString() );	     
			

			string[] str_d = new string[reader_EKKO.FieldCount];			
			while (reader_EKKO.Read())
			{
				for(int i=0; i<reader_EKKO.FieldCount; i++)				
					str_d[i] = ClassLib.ComFunction.Convert_dtType(reader_EKKO[i].GetType().Name.ToString(), reader_EKKO[i].ToString());

				for(int i=0; i<reader_EKKO.FieldCount; i++)				
				{
					if (i==2)
						str_d[i] = reader_EKKO[i].ToString().PadLeft(6, '0').ToString();
					else
						str_d[i] = ClassLib.ComFunction.Convert_dtType(reader_EKKO[i].GetType().Name.ToString(), reader_EKKO[i].ToString());
				}
			
				fgrid_EKKO.AddItem(str_d, fgrid_EKKO.Rows.Count, (int)ClassLib.TBSEM_EKKO.IxFACTORY);

				str_d.Initialize();							
			}			          		
			fgrid_EKKO.AutoSizeCols();
			fgrid_EKKO.Cols[0].Width = 20;


			str_d = new string[reader_EKPO.FieldCount];			
			while (reader_EKPO.Read())
			{
				for(int i=0; i<reader_EKPO.FieldCount; i++)				
				{
					if (i==2)
						str_d[i] = reader_EKPO[i].ToString().PadLeft(10, '0').ToString();
					else if (i==8)
						str_d[i] = reader_EKPO[i].ToString().PadLeft(10, '0').ToString();
					else if (i==3)
						str_d[i] = reader_EKPO[i].ToString().PadLeft(6, '0').ToString();
					else
						str_d[i] = ClassLib.ComFunction.Convert_dtType(reader_EKPO[i].GetType().Name.ToString(), reader_EKPO[i].ToString());
				}
			
				fgrid_EKPO.AddItem(str_d, fgrid_EKPO.Rows.Count, (int)ClassLib.TBSEM_EKPO.IxFACTORY);				
				//fgrid_EKKO[fgrid_EKPO.Rows.Count-1, (int)ClassLib.TBSEM_EKPO.lxDiv] = " ";

				str_d.Initialize();							
			}			          		
			fgrid_EKPO.AutoSizeCols();
			fgrid_EKPO.Cols[0].Width = 20;


			str_d = new string[reader_EKET.FieldCount];			
			while (reader_EKET.Read())
			{
				for(int i=0; i<reader_EKET.FieldCount; i++)				
				{
					if (i==2)
						str_d[i] = reader_EKET[i].ToString().PadLeft(10, '0').ToString();
					else
						str_d[i] = ClassLib.ComFunction.Convert_dtType(reader_EKET[i].GetType().Name.ToString(), reader_EKET[i].ToString());
				}

			
				fgrid_EKET.AddItem(str_d, fgrid_EKET.Rows.Count, 1);
				str_d.Initialize();							
			}			          		
			fgrid_EKET.AutoSizeCols();
			fgrid_EKET.Cols[0].Width = 20;


			str_d = new string[reader_MARA.FieldCount];			
			while (reader_MARA.Read())
			{
				for(int i=0; i<reader_MARA.FieldCount; i++)				
					str_d[i] = ClassLib.ComFunction.Convert_dtType(reader_MARA[i].GetType().Name.ToString(), reader_MARA[i].ToString());
							
				fgrid_MARA.AddItem(str_d, fgrid_MARA.Rows.Count, 1);
				str_d.Initialize();							
			}			          		
			fgrid_MARA.AutoSizeCols();
			fgrid_MARA.Cols[0].Width = 20;
			
		}	


		/// <summary>
		/// SAVE SEM_OBS
		/// </summary>
		private bool Save_SEM_GPO(C1FlexGrid arg_fgrid)  
		{   
			
			lbl_1.ForeColor = Color.SaddleBrown;
			lbl_1.Text = "�� GPO Move"; 
			lbl_1.Refresh();
		
			progressBar1.Maximum = arg_fgrid.Rows.Count-1;


			if  (Save_SEM_GPO_EKKO() == false)  
			{ 	MessageBox.Show ("Move EKKO Error"); return false;}
			
			if	(Save_SEM_GPO_EKPO() == false) 
			{ 	MessageBox.Show ("Move EKPO Error"); return false;}
			
			if	(Save_SEM_GPO_EKET() == false) 
			{ 	MessageBox.Show ("Move EKET Error"); return false;}

			if	(Save_SEM_GPO_MARA()==false)
			{ 	MessageBox.Show ("Move MARA Error"); return false;}

			return true;
		}


		/// <summary>
		/// Save_SEM_GPO_EKKO
		/// </summary>
		private bool Save_SEM_GPO_EKKO()  
		{
			try
			{
				lbl_1.Text = "�� EKKO Move"; 
				lbl_1.Refresh();
				
				progressBar1.Value = 0;
				progressBar1.Maximum = fgrid_EKKO.Rows.Count-1;

				int intParm = (int)ClassLib.TBSEM_EKKO.IxMaxCt;

				MyOraDB.ReDim_Parameter(intParm); 

				MyOraDB.Process_Name = "PKG_SEM_GPO.SAVE_SEM_EKKO";

				for(int i = 0; i < intParm; i++)
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 

				MyOraDB.Parameter_Name[0]  = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1]  = "ARG_OBS_NU";
				MyOraDB.Parameter_Name[2]  = "ARG_PO_ID"; 
				MyOraDB.Parameter_Name[3]  = "ARG_EBELN";  
				MyOraDB.Parameter_Name[4]  = "ARG_BEDAT";  
				MyOraDB.Parameter_Name[5]  = "ARG_BUKRS";  	
				MyOraDB.Parameter_Name[6]  = "ARG_EKORG";  
				MyOraDB.Parameter_Name[7]  = "ARG_EKGRP";  
				MyOraDB.Parameter_Name[8]  = "ARG_LIFN2";  	
				MyOraDB.Parameter_Name[9]  = "ARG_BSART";  
				MyOraDB.Parameter_Name[10] = "ARG_WAERS";  
				MyOraDB.Parameter_Name[11] = "ARG_WKURS";  	
				MyOraDB.Parameter_Name[12] = "ARG_INCO1";  
				MyOraDB.Parameter_Name[13] = "ARG_INCO2";  
				MyOraDB.Parameter_Name[14] = "ARG_AEDAT";  	
				MyOraDB.Parameter_Name[15] = "ARG_ERNAM";  
				MyOraDB.Parameter_Name[16] = "ARG_FFS_CHNG_DTTM";
				MyOraDB.Parameter_Name[17] = "ARG_SNDPRN"; 
				MyOraDB.Parameter_Name[18] = "ARG_ZTERM";  
				MyOraDB.Parameter_Name[19] = "ARG_ZZSESN_CD";  
				MyOraDB.Parameter_Name[20] = "ARG_ZZSESN_YR";  	
				MyOraDB.Parameter_Name[21] = "ARG_BUY_GRP_CD";  
				MyOraDB.Parameter_Name[22] = "ARG_LIFNR"; 
				MyOraDB.Parameter_Name[23] = "ARG_FFS_VNDR_LOC_CD";
				MyOraDB.Parameter_Name[24] = "ARG_UPD_USER";
				MyOraDB.Parameter_Name[25] = "ARG_UPD_YMD"; 
					

				for(int i=_Rowfixed ; i<fgrid_EKKO.Rows.Count ; i++)
				{   
					int iRow=0;
					for(int j=1; j<fgrid_EKKO.Cols.Count; j++)				
					{
						MyOraDB.Parameter_Values[iRow]  = fgrid_EKKO[i,j].ToString().Replace("'","`");
						iRow = iRow +1;
						
					}

					MyOraDB.Add_Modify_Parameter(true);
					MyOraDB.Exe_Modify_Procedure();

					progressBar1.Value =  i;

					float rate = progressBar1.Value/progressBar1.Maximum;
					lbl_s.Text = ": " + rate.ToString() + "% (" + i.ToString() + "/" + (fgrid_EKPO.Rows.Count-1).ToString() + ")";			
					lbl_s.Text = ": " + (Math.Ceiling(rate*100)).ToString() + "% (" + i.ToString() + "/" + (fgrid_EKPO.Rows.Count-1).ToString() + ")";			
					lbl_s.Refresh();
				}
				return true;
			}
			catch
			{
				//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				return false;
			}
		}


		/// <summary>
		/// Save_SEM_GPO_EKPO
		/// </summary>
		private bool Save_SEM_GPO_EKPO()  
		{
			try
			{

				lbl_1.Text = "�� EKPO Move"; 
				lbl_1.Refresh();

				
				progressBar1.Value = 0;
				progressBar1.Maximum = fgrid_EKPO.Rows.Count-1;

				int intParm = (int)ClassLib.TBSEM_EKPO.IxMaxCt-8;

				MyOraDB.ReDim_Parameter(intParm); 

				MyOraDB.Process_Name = "PKG_SEM_GPO.SAVE_SEM_EKPO";

				for(int i = 0; i < intParm; i++)
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 

				MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";                       
				MyOraDB.Parameter_Name[1]  = "ARG_OBS_NU";						  
				MyOraDB.Parameter_Name[2]  = "ARG_OBS_SEQ_NU";   				  
				MyOraDB.Parameter_Name[3]  = "ARG_OBS_ID";						  
				MyOraDB.Parameter_Name[4]  = "ARG_DOC_YMD";						  
				MyOraDB.Parameter_Name[5]  = "ARG_MSR_DIV";						  
				MyOraDB.Parameter_Name[6]  = "ARG_LCH_DIV";						  
				MyOraDB.Parameter_Name[7]  = "ARG_EBELN";   					  
				MyOraDB.Parameter_Name[8]  = "ARG_EBELP";						  
				MyOraDB.Parameter_Name[9]  = "ARG_MATNR";						  
				MyOraDB.Parameter_Name[10] = "ARG_TXZ01";   					  
				MyOraDB.Parameter_Name[11] = "ARG_BUKRS";						  
				MyOraDB.Parameter_Name[12] = "ARG_WERKS";						  
				MyOraDB.Parameter_Name[13] = "ARG_SPART";   					  
				MyOraDB.Parameter_Name[14] = "ARG_MENGE";						  
				MyOraDB.Parameter_Name[15] = "ARG_MEINS";						  
				MyOraDB.Parameter_Name[16] = "ARG_NETPR";   					  
				MyOraDB.Parameter_Name[17] = "ARG_NTGEW";						  
				MyOraDB.Parameter_Name[18] = "ARG_EVERS";						  
				MyOraDB.Parameter_Name[19] = "ARG_EVTXT";						  
				MyOraDB.Parameter_Name[20] = "ARG_PSTYP";   	  				  
				MyOraDB.Parameter_Name[21] = "ARG_KNTTP"; 		  				  
				MyOraDB.Parameter_Name[22] = "ARG_J_3AEXFCP";					  
				MyOraDB.Parameter_Name[23] = "ARG_ZZ_GAC_DT";					  
				MyOraDB.Parameter_Name[24] = "ARG_ZZ_GAC_RSN_CD"; 				  
				MyOraDB.Parameter_Name[25] = "ARG_FFS_GAC_DT_RQST";				  
				MyOraDB.Parameter_Name[26] = "ARG_FFS_GAC_RSN_CD_RQST";			  
				MyOraDB.Parameter_Name[27] = "ARG_FFS_GAC_SND_RQST_FL";			  
				MyOraDB.Parameter_Name[28] = "ARG_BSTNK";   					  
				MyOraDB.Parameter_Name[29] = "ARG_VDATU";						  
				MyOraDB.Parameter_Name[30] = "ARG_FKDAT";   					  
				MyOraDB.Parameter_Name[31] = "ARG_EINDT";   					  
				MyOraDB.Parameter_Name[32] = "ARG_SLFDT";						  
				MyOraDB.Parameter_Name[33] = "ARG_MVGR2";   					  
				MyOraDB.Parameter_Name[34] = "ARG_BSGRU";   					  
				MyOraDB.Parameter_Name[35] = "ARG_BISMT";						  
				MyOraDB.Parameter_Name[36] = "ARG_ZZ_SILH_CD";   				  
				MyOraDB.Parameter_Name[37] = "ARG_ZZ_GNDRAGE"; 					  
				MyOraDB.Parameter_Name[38] = "ARG_SOVBELN"; 					  
				MyOraDB.Parameter_Name[39] = "ARG_SOVBELP"; 	 				  
				MyOraDB.Parameter_Name[40] = "ARG_J_4KSCAT"; 					  
				MyOraDB.Parameter_Name[41] = "ARG_SO_CUST_DEPT";				  
				MyOraDB.Parameter_Name[42] = "ARG_SO_CUST_DEPT_DESC";			  
				MyOraDB.Parameter_Name[43] = "ARG_FFS_STENCIL_SHIP_TO"; 		  
				MyOraDB.Parameter_Name[44] = "ARG_FFS_STENCIL_DEST"; 			  
				MyOraDB.Parameter_Name[45] = "ARG_FFS_STENCIL_ORIGIN"; 			  
				MyOraDB.Parameter_Name[46] = "ARG_KUNNR"; 						  
				MyOraDB.Parameter_Name[47] = "ARG_FFS_SHP_TO_ACCT";				  
				MyOraDB.Parameter_Name[48] = "ARG_WAERS";   					  
				MyOraDB.Parameter_Name[49] = "ARG_PO_ITEM_STATUS";				  
				MyOraDB.Parameter_Name[50] = "ARG_COLORCOMBNAME";				  
				MyOraDB.Parameter_Name[51] = "ARG_COLORCOMBSHORTNAME";			  
				MyOraDB.Parameter_Name[52] = "ARG_RGACYMD";						  
				MyOraDB.Parameter_Name[53] = "ARG_OBS_DIV";						  
				MyOraDB.Parameter_Name[54] = "ARG_UPD_USER"; 					  
				MyOraDB.Parameter_Name[55] = "ARG_UPD_YMD";		
				MyOraDB.Parameter_Name[56] = "ARG_TRADE_CO_PO_NU";		
				MyOraDB.Parameter_Name[57] = "ARG_TRADE_CO_PLANT";		
				MyOraDB.Parameter_Name[58] = "ARG_TRADE_CO_PLANT_DESC";		
				MyOraDB.Parameter_Name[59] = "ARG_UOM";		
				MyOraDB.Parameter_Name[60] = "ARG_TTMI";	
				MyOraDB.Parameter_Name[61] = "ARG_OBS_NU_REF";		
			 
 
				
				
				for(int i=_Rowfixed ; i<fgrid_EKPO.Rows.Count ; i++)
				{   
					int iRow=0;

					for(int j=(int)ClassLib.TBSEM_EKPO.IxFACTORY ; j<fgrid_EKPO.Cols.Count; j++)				
					{
						MyOraDB.Parameter_Values[iRow]  = fgrid_EKPO[i,j].ToString().Replace("'","`");
						iRow = iRow +1;
						
					}

					MyOraDB.Add_Modify_Parameter(true);
					MyOraDB.Exe_Modify_Procedure();

					progressBar1.Value =  i;

					float rate = progressBar1.Value/progressBar1.Maximum;
					lbl_s.Text = ": " + rate.ToString() + "% (" + i.ToString() + "/" + (fgrid_EKPO.Rows.Count-1).ToString() + ")";			
					lbl_s.Text = ": " + (Math.Ceiling(rate*100)).ToString() + "% (" + i.ToString() + "/" + (fgrid_EKPO.Rows.Count-1).ToString() + ")";			
					lbl_s.Refresh();
			
				}
				return true;
			}
			catch
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				return false;
			}
		}




		/// <summary>
		/// Save_SEM_GPO_EKET
		/// </summary>
		private bool Save_SEM_GPO_EKET()  
		{	
			int iErr = 0;

			try
			{
				lbl_1.Text = "�� EKET Move"; 
				lbl_1.Refresh();

				
				progressBar1.Value = 0;
				progressBar1.Maximum = fgrid_EKET.Rows.Count-1;

				int intParm = (int)ClassLib.TBSEM_EKET.IxMaxCt;

				MyOraDB.ReDim_Parameter(intParm); 

				MyOraDB.Process_Name = "PKG_SEM_GPO.SAVE_SEM_EKET";

				for(int i = 0; i < intParm; i++)
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 

				MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1]  = "ARG_OBS_NU";  
				MyOraDB.Parameter_Name[2]  = "ARG_OBS_SEQ_NU"; 
				MyOraDB.Parameter_Name[3]  = "ARG_CS_SIZE";  
				MyOraDB.Parameter_Name[4]  = "ARG_EBELN";   
				MyOraDB.Parameter_Name[5]  = "ARG_EBELP";	  
				MyOraDB.Parameter_Name[6]  = "ARG_ETENR";  
				MyOraDB.Parameter_Name[7]  = "ARG_J_3ASIZE";  
				MyOraDB.Parameter_Name[8]  = "ARG_MENGE"; 
				MyOraDB.Parameter_Name[9]  = "ARG_MEINS";  
				MyOraDB.Parameter_Name[10] = "ARG_J_3ANETP";  
				MyOraDB.Parameter_Name[11] = "ARG_KEBTR"; 
				MyOraDB.Parameter_Name[12] = "ARG_EAN11";  
				MyOraDB.Parameter_Name[13] = "ARG_J_4KSCAT";  
				MyOraDB.Parameter_Name[14] = "ARG_EINDT"; 
				MyOraDB.Parameter_Name[15] = "ARG_SLFDT";  
				MyOraDB.Parameter_Name[16] = "ARG_FFS_CHNG_DTTM";
				MyOraDB.Parameter_Name[17] = "ARG_BAR_CODE"; 
				MyOraDB.Parameter_Name[18] = "ARG_CHECK_DIGIT"; 
				MyOraDB.Parameter_Name[19] = "ARG_FIRST_DIV"; 
				MyOraDB.Parameter_Name[20] = "ARG_OBS_DIV"; 
				MyOraDB.Parameter_Name[21] = "ARG_UPD_USER"; 
				MyOraDB.Parameter_Name[22] = "ARG_UPD_YMD"; 

				for(int i=_Rowfixed ; i<fgrid_EKET.Rows.Count ; i++)
				{
					int iRow=0;   iErr = i;
					for(int j=1; j<fgrid_EKET.Cols.Count; j++)				
					{
						MyOraDB.Parameter_Values[iRow]  = fgrid_EKET[i,j].ToString().Replace("'","`");
						iRow = iRow +1;
						
					}

										
					MyOraDB.Add_Modify_Parameter(true);										
					MyOraDB.Exe_Modify_Procedure();

					progressBar1.Value =  i;

					float rate = progressBar1.Value/progressBar1.Maximum;
					lbl_s.Text = ": " + rate.ToString() + "% (" + i.ToString() + "/" + (fgrid_EKET.Rows.Count-1).ToString() + ")";			
					lbl_s.Text = ": " + (Math.Ceiling(rate*100)).ToString() + "% (" + i.ToString() + "/" + (fgrid_EKET.Rows.Count-1).ToString() + ")";			
					lbl_s.Refresh();
				
				}
				return true;
			}
			catch
			{
				//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				MessageBox.Show("PO Nu:" + fgrid_EKET[iErr,(int)ClassLib.TBSEM_EKPO.IxEBELN].ToString() +"-Item_Seq_Nu:"+
					fgrid_EKET[iErr,(int)ClassLib.TBSEM_EKPO.IxEBELP].ToString());   
					              
				return false;
			}
		}



		/// <summary>
		/// Save_SEM_GPO_MARA
		/// </summary>
		private bool Save_SEM_GPO_MARA()  
		{
			try
			{
				lbl_1.Text = "�� MARA Move"; 
				lbl_1.Refresh();

				progressBar1.Value = 0;
				progressBar1.Maximum = fgrid_MARA.Rows.Count;

				int intParm = (int)ClassLib.TBSEM_MARA.IxMaxCt+1;

				MyOraDB.ReDim_Parameter(intParm); 

				MyOraDB.Process_Name = "PKG_SEM_GPO.SAVE_SEM_MARA";

				for(int i = 0; i < intParm; i++)
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 

				MyOraDB.Parameter_Name[0]  = "ARG_FLAG"; 
				MyOraDB.Parameter_Name[1]  = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[2]  = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[3]  = "ARG_MATNR";
				MyOraDB.Parameter_Name[4]  = "ARG_MATERIALNAME"; 
				MyOraDB.Parameter_Name[5]  = "ARG_MATERIALSHORTNAME";
				MyOraDB.Parameter_Name[6]  = "ARG_COLORCOMBNAME";
				MyOraDB.Parameter_Name[7]  = "ARG_COLORCOMBSHORTNAME";
				MyOraDB.Parameter_Name[8]  = "ARG_DIVISION";
				MyOraDB.Parameter_Name[9]  = "ARG_CATEGORY"; 
				MyOraDB.Parameter_Name[10]  = "ARG_CATEGORYNAME"; 
				MyOraDB.Parameter_Name[11] = "ARG_SUBCATEGORY";
				MyOraDB.Parameter_Name[12] = "ARG_SUBCATEGORYNAME";
				MyOraDB.Parameter_Name[13] = "ARG_GENDERAGE";
				MyOraDB.Parameter_Name[14] = "ARG_GENDERAGENAME"; 
				MyOraDB.Parameter_Name[15] = "ARG_FIRSTPRODUCTOFFER_DTTM";
				MyOraDB.Parameter_Name[16] = "ARG_ENDFUTUREOFFER_DTTM";
				MyOraDB.Parameter_Name[17] = "ARG_ENDPRODUCTOFFER_DTTM";
				MyOraDB.Parameter_Name[18] = "ARG_WIDTH";
				MyOraDB.Parameter_Name[19] = "ARG_MATERIALCONTENT";
				MyOraDB.Parameter_Name[20] = "ARG_OUTSOLE";
				MyOraDB.Parameter_Name[21] = "ARG_FFS_TEXTILE_CAT"; 	
				MyOraDB.Parameter_Name[22] = "ARG_FFS_CRTN_TYP";
				MyOraDB.Parameter_Name[23] = "ARG_FFS_PACK_FACTOR";
				MyOraDB.Parameter_Name[24] = "ARG_FFS_CHNG_DTTM";
				MyOraDB.Parameter_Name[25] = "ARG_UPD_USER";
				MyOraDB.Parameter_Name[26] = "ARG_UPD_YMD";
				

				for(int i=_Rowfixed ; i<fgrid_MARA.Rows.Count ; i++)
				{
					for(int j=1; j<fgrid_MARA.Cols.Count; j++)				
					{
						MyOraDB.Parameter_Values[0]  = "I";
						MyOraDB.Parameter_Values[j]  = fgrid_MARA[i,j].ToString().Replace("'","`");
						
					}

					
					MyOraDB.Add_Modify_Parameter(true);
					MyOraDB.Exe_Modify_Procedure();

					progressBar1.Value =  i;

					float rate = progressBar1.Value/progressBar1.Maximum;
					lbl_s.Text = ": " + rate.ToString() + "% (" + i.ToString() + "/" + (fgrid_MARA.Rows.Count-1).ToString() + ")";			
					lbl_s.Text = ": " + (Math.Ceiling(rate*100)).ToString() + "% (" + i.ToString() + "/" + (fgrid_MARA.Rows.Count-1).ToString() + ")";			
					lbl_s.Refresh();
				}
				return true;
			}
			catch
			{
				//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				return false;
			}
		}



		/// <summary>
		/// SAVE SEM_OBS
		/// </summary>
		private bool Save_SEM_OBS(C1FlexGrid arg_fgrid)  
		{
			try
			{
				progressBar1.Value = 0;
				lbl_3.ForeColor = Color.SaddleBrown;
				lbl_3.Text = "�� Data Upload";
				lbl_3.Refresh();

				progressBar1.Value = 0;
				progressBar1.Maximum = arg_fgrid.Rows.Count-1;

				int col_ct = 18;

				MyOraDB.ReDim_Parameter(col_ct); 

				MyOraDB.Process_Name = "PKG_SEM_GPO.SAVE_SEM_OBS";

				for(int i = 0; i < col_ct; i++)
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 

				MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1]  = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[2]  = "ARG_OBS_NU"; 
				MyOraDB.Parameter_Name[3]  = "ARG_OBS_SEQ_NU";
				MyOraDB.Parameter_Name[4]  = "ARG_DOC_YMD";
				MyOraDB.Parameter_Name[5]  = "ARG_MSR_DIV";
				MyOraDB.Parameter_Name[6]  = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[7]  = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[8]  = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[9]  = "ARG_CK_STYLE"; 
				MyOraDB.Parameter_Name[10] = "ARG_CK_MODEL";
				MyOraDB.Parameter_Name[11] = "ARG_CK_GEN"; 
				MyOraDB.Parameter_Name[12] = "ARG_CK_PRESTO"; 
				MyOraDB.Parameter_Name[13] = "ARG_CK_GSSC";
				MyOraDB.Parameter_Name[14] = "ARG_CK_DEST";
				MyOraDB.Parameter_Name[15] = "ARG_OBS_DIV";
				MyOraDB.Parameter_Name[16] = "ARG_UPD_USER";
				MyOraDB.Parameter_Name[17] = "ARG_UPD_YMD";


				for(int i=_Rowfixed; i<arg_fgrid.Rows.Count; i++)
				{
					
					MyOraDB.Parameter_Values[0]  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.lxDiv].ToString();
					MyOraDB.Parameter_Values[1]  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxFACTORY].ToString();
					MyOraDB.Parameter_Values[2]  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxOBS_NU].ToString();
					MyOraDB.Parameter_Values[3]  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxOBS_SEQ_NU].ToString();
					MyOraDB.Parameter_Values[4]  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxDOC_YMD].ToString();
					MyOraDB.Parameter_Values[5]  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxMSR_DIV].ToString();
					MyOraDB.Parameter_Values[6]  = cmb_OBS_ID.Text.ToString();
					MyOraDB.Parameter_Values[7]  = cmb_PO_TYPE.Text;
					MyOraDB.Parameter_Values[8]  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxMATNR].ToString();
					MyOraDB.Parameter_Values[9]  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.lxchkStyle].ToString();
					MyOraDB.Parameter_Values[10]  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.lxchkModel].ToString();
					MyOraDB.Parameter_Values[11]  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.lxchkGen].ToString();
					MyOraDB.Parameter_Values[12] = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.lxchkPresto].ToString();
					MyOraDB.Parameter_Values[13] = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.lxchkGSSC].ToString();
					MyOraDB.Parameter_Values[14] = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.lxchkDest].ToString();
					MyOraDB.Parameter_Values[15] = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxOBS_DIV].ToString();
					MyOraDB.Parameter_Values[16] = ClassLib.ComVar.This_User;
					MyOraDB.Parameter_Values[17] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

					MyOraDB.Add_Modify_Parameter(true);
					MyOraDB.Exe_Modify_Procedure();


					progressBar1.Value =  i;

					float rate = progressBar1.Value/progressBar1.Maximum;
					lbl_m.Text = ": " + rate.ToString() + "% (" + i.ToString() + "/" + (arg_fgrid.Rows.Count-1).ToString() + ")";			
					lbl_m.Text = ": " + (Math.Ceiling(rate*100)).ToString() + "% (" + i.ToString() + "/" + (arg_fgrid.Rows.Count-1).ToString() + ")";			
					lbl_m.Refresh();
				}
				return true;
			}
			catch
			{
				//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				return false;
			}
		}


		/// <summary>
		/// GPO LOADING�� STYLE ���� üũ, SEM_GSSC üũ, SEM_DEST üũ
		/// </summary>
		/// <param name="arg_factory"factory></param>
		/// <param name="arg_fgrid">�۾��׸���</param>
		public bool Check_Style(C1FlexGrid arg_fgrid)
		{
			try
			{   


				//�����ڵ�/ OBS ID  �� ����
				if((fgrid_EKPO[_Rowfixed,(int)ClassLib.TBSEM_EKPO.IxFACTORY].ToString() != cmb_Factory.SelectedValue.ToString()) ||
					(fgrid_EKPO[_Rowfixed,(int)ClassLib.TBSEM_EKPO.IxOBS_ID].ToString() != cmb_OBS_ID.Text.ToString()))
				{ClassLib.ComFunction.User_Message("Factory or OBS ID") ; return false;}
				   	
					
				string strRlt; int iCnt;
				DataSet ret;  DataTable dt_list; 	
				DateTime CurDate = DateTime.Now;	

				lbl_2.ForeColor = Color.SaddleBrown;
				lbl_2.Text = "��Data Check"; 
				lbl_2.Refresh();
				
				progressBar1.Maximum = arg_fgrid.Rows.Count-1;

				for (int i=arg_fgrid.Rows.Fixed; i<arg_fgrid.Rows.Count; i++)
				{		
	                 
					string arg_fact  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxFACTORY].ToString().Trim();
					string arg_ponu  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxOBS_NU].ToString().Trim();
					string arg_posq  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxOBS_SEQ_NU].ToString().Trim();			
	                
					//*************************************
					//      1�� Style���� ����
					//*************************************
					string arg_style = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxMATNR].ToString().Trim();
					string arg_dest  = (arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxFFS_SHP_TO_ACCT].ToString().Trim().Length > 0) ?
						arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxFFS_SHP_TO_ACCT].ToString().Trim() :
						arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxWERKS].ToString().Trim() ; 
					

					arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxFFS_SHP_TO_ACCT] = arg_dest;				
			    
					iCnt =  4;
					MyOraDB.ReDim_Parameter(iCnt); 
			    
					strRlt  =  "PKG_SEM_GPO.SELECT_SEM_STYLE";
					MyOraDB.Process_Name =strRlt;
		
					MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
					MyOraDB.Parameter_Name[1] = "ARG_STYLE";  
					MyOraDB.Parameter_Name[2] = "ARG_DEST";  
					MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
					
					MyOraDB.Parameter_Type[0] =  (int)OracleType.VarChar;
					MyOraDB.Parameter_Type[1] =  (int)OracleType.VarChar;
					MyOraDB.Parameter_Type[2] =  (int)OracleType.VarChar;
					MyOraDB.Parameter_Type[3] =  (int)OracleType.Cursor;						
		
					MyOraDB.Parameter_Values[0] = arg_fact;
					MyOraDB.Parameter_Values[1] = arg_style;  
					MyOraDB.Parameter_Values[2] = arg_dest; 
					MyOraDB.Parameter_Values[3] = "";
					
					MyOraDB.Add_Select_Parameter(true); 
					ret = MyOraDB.Exe_Select_Procedure();
											
					if (ret == null)  return  false ;
					dt_list  =  ret.Tables[strRlt];


					arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.lxDiv] = "I";
					
					
					for(int j=0; j<dt_list.Columns.Count; j++)
					{
						
						arg_fgrid[i, j+2] = dt_list.Rows[0].ItemArray[j].ToString();										
	 
						//������ ��Ÿ�� �������� 
						//if (cmb_PO_TYPE.SelectedValue.ToString() == "05")  
						arg_fgrid[i,(int)ClassLib.TBSEM_EKPO.lxchkGSSC]  = "True";
						//cmb_PO_TYPE.Text.ToString()

						if (arg_fgrid[i, j+2].ToString().Trim() == "False")
						{
							arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.lxDiv] = "F";
							arg_fgrid.GetCellRange(i, 0, i, arg_fgrid.Cols.Count-1).StyleNew.ForeColor = ClassLib.ComVar.ClrError;
							arg_fgrid.GetCellRange(i, 0, i, arg_fgrid.Cols.Count-1).StyleNew.BackColor = ClassLib.ComVar.ClrHead;
						}						
					}	
					

					//*************************************
					//      2�� Mercury Order Check
					//*************************************
					#region Mercury Order Check
					//					iCnt =  4;
					//					MyOraDB.ReDim_Parameter(iCnt); 
					//			    
					//					strRlt  =  "PKG_SEM_GPO.SELECT_SEM_EKETTOT";
					//					MyOraDB.Process_Name =strRlt;
					//		
					//					MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
					//					MyOraDB.Parameter_Name[1] = "ARG_OBS_NU";  
					//					MyOraDB.Parameter_Name[2] = "ARG_OBS_SEQ_NU";  
					//					MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
					//					
					//					MyOraDB.Parameter_Type[0] =  (int)OracleType.VarChar;
					//					MyOraDB.Parameter_Type[1] =  (int)OracleType.VarChar;
					//					MyOraDB.Parameter_Type[2] =  (int)OracleType.VarChar;
					//					MyOraDB.Parameter_Type[3] =  (int)OracleType.Cursor;						
					//		
					//					MyOraDB.Parameter_Values[0] = arg_fact;
					//					MyOraDB.Parameter_Values[1] = arg_ponu;  
					//					MyOraDB.Parameter_Values[2] = arg_posq; 
					//					MyOraDB.Parameter_Values[3] = "";
					//					
					//					MyOraDB.Add_Select_Parameter(true); 
					//					ret = MyOraDB.Exe_Select_Procedure();
					//											
					//					if (ret == null)  return  false ;
					//					dt_list  =  ret.Tables[strRlt];
					//
					//					
					//					arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.lxchkEket] = "True";
					//
					//					string sQty = arg_fgrid[i,(int)ClassLib.TBSEM_EKPO.IxMENGE].ToString();
					//					
					//					if (arg_fgrid[i,(int)ClassLib.TBSEM_EKPO.IxMENGE].ToString()
					//						!= dt_list.Rows[0].ItemArray[0].ToString())
					//					{
					//						arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.lxDiv] = "F";
					//						arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.lxchkEket] = "False";
					//						arg_fgrid.GetCellRange(i, 0, i, arg_fgrid.Cols.Count-1).StyleNew.ForeColor = ClassLib.ComVar.ClrError;
					//						arg_fgrid.GetCellRange(i, 0, i, arg_fgrid.Cols.Count-1).StyleNew.BackColor = ClassLib.ComVar.ClrHead;
					//					}	
					//
					//					progressBar1.Value =  i;
					//					float rate = progressBar1.Value/progressBar1.Maximum;
					//					lbl_u.Text = ": " + (Math.Ceiling(rate*100)).ToString() + "% (" + i.ToString() + "/" + (arg_fgrid.Rows.Count-1).ToString() + ")";			
					//					lbl_u.Refresh();
				}
				#endregion

				return true;
			}
			catch
			{
				//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				return false;
			}
		}


		public bool Check_OBS_ID(C1FlexGrid arg_fgrid)
		{		
			try
			{
				string strRlt; int iCnt;
				DataSet ret;  DataTable dt_list; 	
				DateTime CurDate = DateTime.Now;	

				lbl_1.ForeColor = Color.SaddleBrown;
				lbl_1.Text = "��OBS ID Check"; 
				lbl_1.Refresh();
				
				progressBar1.Maximum = arg_fgrid.Rows.Count-1;

				for (int i=_Rowfixed; i<arg_fgrid.Rows.Count; i++)
				{		
	                
					//if (arg_fgrid[i, (int)ClassLib.TBSEM_RPM_L.lxOBS_NU].ToString() =="")  continue ;

					string arg_fact  = cmb_Factory.SelectedValue.ToString();
					string arg_ponu  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxOBS_NU].ToString().Trim();
					string arg_posq  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxOBS_SEQ_NU].ToString().PadLeft(10,'0');		
					string arg_potype  = "%"; //cmb_PO_TYPE.SelectedValue.ToString();
	               
			    
					iCnt =  5;
					MyOraDB.ReDim_Parameter(iCnt); 		   

					strRlt  =  "PKG_SEM_GPO.SELECT_SEM_OBSID";
					MyOraDB.Process_Name =strRlt;
		
					MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
					MyOraDB.Parameter_Name[1] = "ARG_OBS_NU";  
					MyOraDB.Parameter_Name[2] = "ARG_OBS_SEQ_NU";  
					MyOraDB.Parameter_Name[3] = "ARG_OBS_TYPE"; 
					MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
					
					MyOraDB.Parameter_Type[0] =  (int)OracleType.VarChar;
					MyOraDB.Parameter_Type[1] =  (int)OracleType.VarChar;
					MyOraDB.Parameter_Type[2] =  (int)OracleType.VarChar;
					MyOraDB.Parameter_Type[3] =  (int)OracleType.VarChar;
					MyOraDB.Parameter_Type[4] =  (int)OracleType.Cursor;						
		
					MyOraDB.Parameter_Values[0] = arg_fact;
					MyOraDB.Parameter_Values[1] = arg_ponu;  
					MyOraDB.Parameter_Values[2] = arg_posq; 
					MyOraDB.Parameter_Values[3] = arg_potype; 
					MyOraDB.Parameter_Values[4] = "";
					
					
					MyOraDB.Add_Select_Parameter(true); 
					ret = MyOraDB.Exe_Select_Procedure();
											
					if (ret == null)  return false  ;
					dt_list  =  ret.Tables[strRlt];

	
					
					
					if (dt_list.Rows[0].ItemArray[0].ToString() != "NONE") 
					{
						
					
						if (dt_list.Rows[0].ItemArray[0].ToString() != cmb_OBS_ID.Text)
						{ ClassLib.ComFunction.User_Message("OBS ID is wrong !!!  OBS_Nu:" + arg_ponu +"OBS_Seq_Nu"+ arg_posq  + "("+dt_list.Rows[0].ItemArray[0].ToString()+")");return false;}
					}
					
					
					progressBar1.Value =  i;

					float rate = progressBar1.Value/progressBar1.Maximum;
					lbl_s.Text = ": " + rate.ToString() + "% (" + i.ToString() + "/" + (fgrid_EKPO.Rows.Count-1).ToString() + ")";			
					lbl_s.Text = ": " + (Math.Ceiling(rate*100)).ToString() + "% (" + i.ToString() + "/" + (fgrid_EKPO.Rows.Count-1).ToString() + ")";			
					lbl_s.Refresh();

				}
				return true;
			}
			catch
			{
				//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				return false;
			}
		}





		#endregion

		#region �̺�Ʈó��


	


		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				//GPO����(MSSQL SERVER)�� �о�´�

				if (Check_Select()  == false)   
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsWrongInput, this); return;
				}

				Select_GPO_List();	

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch,this);

			}
			catch
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch, this); 
			}		
		}


		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{

				//progress initial
				pnl_progress.Visible = true;

				lbl_1.Text = "   GPO Move";
				lbl_2.Text = "   Data Check";
				lbl_3.Text = "   GPO Upload";

				lbl_1.ForeColor = Color.Silver;
				lbl_2.ForeColor = Color.Silver;
				lbl_3.ForeColor = Color.Silver;

				lbl_s.Text = "";
				lbl_u.Text = "";
				lbl_m.Text = "";

				//��Ÿ�ϵ� ���� üũ 
				if (Check_Style(fgrid_EKPO) == false) 
				{ClassLib.ComFunction.Data_Message("Error:Check_Style", this); pnl_progress.Visible = false;return; }

				//OBS ID���� üũ
				if (Check_OBS_ID(fgrid_EKPO) == false) 
				{ClassLib.ComFunction.Data_Message("Error:Check_OBS_ID", this); pnl_progress.Visible = false;return; }		

				//MOVE GPO
				if (Save_SEM_GPO(fgrid_EKPO) == false) 
				{ClassLib.ComFunction.Data_Message("Error:Save_SEM_GPO", this); pnl_progress.Visible = false;return; }

				//UPLOAD..
				if (Save_SEM_OBS(fgrid_EKPO) == false) 
				{ClassLib.ComFunction.Data_Message("Error:Save_SEM_OBS", this); pnl_progress.Visible = false;return; }

				pnl_progress.Visible = false; 

				SB_Pop_Up("01"); // �ε� ���� ��

				SB_Pop_UPC_Load(); // �θ� �� UPC���°�.

			}
			catch 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); return;
			}
		}
	

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			cmb_Factory.SelectedIndex = -1;
			dpick_BEDAT1.Text = DateTime.Now.ToString();
			dpick_BEDAT2.Text = DateTime.Now.ToString();
			txt_OBS_Nu.Clear();
			txt_Seq.Clear();
			txt_Style.Clear();

			pnl_progress.Visible = false;

		}


		private void cmb_PO_TYPE_TextChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				if(cmb_PO_TYPE.SelectedIndex == -1) return;

				cmb_OBS_ID.ClearItems();
				ClassLib.ComFunction.Set_OBSID_CmbList(cmb_PO_TYPE.Text.ToString(), cmb_OBS_ID);  

				DataTable vDt  = Select_Last_OBSID(cmb_Factory.SelectedValue.ToString(), cmb_PO_TYPE.GetItemText(cmb_PO_TYPE.SelectedIndex,1).ToString());
			

				for ( int i =0; i< cmb_OBS_ID.ListCount; i++)
				{

				//	MessageBox.Show(cmb_OBS_ID.GetItemText(i,0) +"-"+ vDt.Rows[0].ItemArray[0].ToString());

					if  (cmb_OBS_ID.GetItemText(i,0)  == vDt.Rows[0].ItemArray[0].ToString())  
						cmb_OBS_ID.SelectedIndex =i;
					

				}

			}
			catch
			{
				cmb_OBS_ID.SelectedIndex = 1;
			}

			

		}

		
		private void dpick_BEDAT1_ValueChanged(object sender, System.EventArgs e)
		{
			//ClassLib.ComFunction.Set_Values(this, dpick_BEDAT1.Name, dpick_BEDAT2.Name);

			//			sDate1 = CurDate.AddMonths(i).ToString();						
			//			sDate2 = CurDate.AddMonths(i+1).ToString();
			//					
			//			sDate1 = sDate1.Substring(2,2) + sDate1.Substring(5,2) + sDate2.Substring(5,2);
			//
			//			sDate1 = dpick_BEDAT1.Text;
			//			sDate2 = sDate1.
			//
			//			dpick_BEDAT2.Text = dpick_BEDAT1.

			


				

		}



		private void btn_Upc_Load_Click(object sender, System.EventArgs e)
		{
		   
			
			SB_Pop_UPC_Load();


		}


		private void btn_Gac_Click(object sender, System.EventArgs e)
		{
		
			MessageBox.Show("Don't Use Now");

			return;

			//SB_Pop_GAC_Load();

		}

		




		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			string mrd_Filename = "Form_EL_MCR.mrd" ;
			string Para         = " ";

			#region �������

			int  iCnt  = 4;
			string [] aHead =  new string[iCnt];	


			aHead[0]    = cmb_Factory.SelectedValue.ToString().Trim();
			aHead[1]    = cmb_OBS_ID.Text.Trim();
			aHead[2]    = cmb_PO_TYPE.Columns[1].Text.Trim();
			aHead[3]    = ClassLib.ComVar.This_User.Trim();
			
			
			#endregion
	
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
	
			//Report Base Formȣ��..
			FlexOrder.Report.Form_RD_PKG_Base  report = new FlexOrder.Report.Form_RD_PKG_Base( mrd_Filename, Para);
			report.Show();

			


		}

		private void dpick_BEDAT2_ValueChanged(object sender, System.EventArgs e)
		{
			//ClassLib.ComFunction.Set_Values(this, dpick_BEDAT1.Name, dpick_BEDAT2.Name);
//			Check_Document_Date();


		}






		#endregion

		#region ���ؽ�Ʈ �޴�
		
		private void ctm_Verification_Click(object sender, System.EventArgs e)
		{
			SB_Pop_Up("02");
		}

		private void ctm_Request_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBSCS.Form_EC_Req frm = new ExpOBSCS.Form_EC_Req();  
			frm.Show();
		}


		private void ctm_OBS_Sel_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBS.Form_EO_SRCH frm = new ExpOBS.Form_EO_SRCH();  
			frm.Show();
		}

		private void ctm_OBS_HistSel_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBS.Form_EO_Hist frm = new ExpOBS.Form_EO_Hist();  
			frm.Show();		
		}

		#endregion

		private void Form_EL_MCR_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}






	}
}
		

