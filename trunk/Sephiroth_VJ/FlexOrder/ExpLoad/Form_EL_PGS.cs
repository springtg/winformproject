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
	public class Form_EL_PGS : COM.OrderWinForm.Form_Top
	{
		#region 컨트롤 속성정의
		public System.Windows.Forms.Panel pnl_Search;
		private System.Windows.Forms.Panel pnl_Search1_Image;
		private C1.Win.C1List.C1Combo cmb_OBS_ID;
		private System.Windows.Forms.TextBox txt_OBS_Nu;
		private System.Windows.Forms.Label lbl_OBS_Nu;
		private C1.Win.C1List.C1Combo cmb_PO_TYPE;
		private System.Windows.Forms.Label lbl_PO_TYPE;
		private System.Windows.Forms.Label lbl_PO_ID;
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
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Label lbl_STYLE_CD;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_EKPO;
		private System.Windows.Forms.Label lbl_Path;
		private System.Windows.Forms.Label btn_path;
		private System.Windows.Forms.TextBox txt_Path;
		private System.Windows.Forms.Label lbl_Sheet_Name;
		private System.Windows.Forms.TextBox txt_sheet;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dpick_BEDAT2;
		private System.Windows.Forms.DateTimePicker dpick_BEDAT1;
		private System.Windows.Forms.Label lbl_BEDAT;
		private System.Windows.Forms.Panel pnl_progress;
		private System.Windows.Forms.Label lbl_m;
		private System.Windows.Forms.Label lbl_u;
		private System.Windows.Forms.Label lbl_s;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_3;
		private System.Windows.Forms.Label lbl_2;
		private System.Windows.Forms.Label lbl_1;
		public COM.FSP fgrid_EKET;
		public COM.FSP fgrid_EKKO;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem ctm_OBS_REQ;
		private System.Windows.Forms.MenuItem ctm_OBS_Sel;
		private System.Windows.Forms.MenuItem ctm_OBS_Hist;
		private System.Windows.Forms.MenuItem ctm_Bar_First;
		private System.Windows.Forms.MenuItem ctm_Verification;
		private System.ComponentModel.IContainer components = null;

		public Form_EL_PGS()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EL_PGS));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_Search1_Image = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dpick_BEDAT2 = new System.Windows.Forms.DateTimePicker();
			this.dpick_BEDAT1 = new System.Windows.Forms.DateTimePicker();
			this.lbl_BEDAT = new System.Windows.Forms.Label();
			this.lbl_Sheet_Name = new System.Windows.Forms.Label();
			this.txt_sheet = new System.Windows.Forms.TextBox();
			this.btn_path = new System.Windows.Forms.Label();
			this.txt_Path = new System.Windows.Forms.TextBox();
			this.cmb_OBS_ID = new C1.Win.C1List.C1Combo();
			this.txt_OBS_Nu = new System.Windows.Forms.TextBox();
			this.lbl_OBS_Nu = new System.Windows.Forms.Label();
			this.cmb_PO_TYPE = new C1.Win.C1List.C1Combo();
			this.lbl_PO_TYPE = new System.Windows.Forms.Label();
			this.lbl_PO_ID = new System.Windows.Forms.Label();
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
			this.lbl_Path = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.lbl_STYLE_CD = new System.Windows.Forms.Label();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_EKET = new COM.FSP();
			this.fgrid_EKKO = new COM.FSP();
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
			this.ctm_OBS_REQ = new System.Windows.Forms.MenuItem();
			this.ctm_Bar_First = new System.Windows.Forms.MenuItem();
			this.ctm_OBS_Sel = new System.Windows.Forms.MenuItem();
			this.ctm_OBS_Hist = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_Search1_Image.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_PO_TYPE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EKET)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EKKO)).BeginInit();
			this.pnl_progress.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EKPO)).BeginInit();
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
			this.pnl_Search.Size = new System.Drawing.Size(1012, 168);
			this.pnl_Search.TabIndex = 38;
			// 
			// pnl_Search1_Image
			// 
			this.pnl_Search1_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search1_Image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_Search1_Image.Controls.Add(this.label1);
			this.pnl_Search1_Image.Controls.Add(this.dpick_BEDAT2);
			this.pnl_Search1_Image.Controls.Add(this.dpick_BEDAT1);
			this.pnl_Search1_Image.Controls.Add(this.lbl_BEDAT);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Sheet_Name);
			this.pnl_Search1_Image.Controls.Add(this.txt_sheet);
			this.pnl_Search1_Image.Controls.Add(this.btn_path);
			this.pnl_Search1_Image.Controls.Add(this.txt_Path);
			this.pnl_Search1_Image.Controls.Add(this.cmb_OBS_ID);
			this.pnl_Search1_Image.Controls.Add(this.txt_OBS_Nu);
			this.pnl_Search1_Image.Controls.Add(this.lbl_OBS_Nu);
			this.pnl_Search1_Image.Controls.Add(this.cmb_PO_TYPE);
			this.pnl_Search1_Image.Controls.Add(this.lbl_PO_TYPE);
			this.pnl_Search1_Image.Controls.Add(this.lbl_PO_ID);
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
			this.pnl_Search1_Image.Controls.Add(this.lbl_Path);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox7);
			this.pnl_Search1_Image.Controls.Add(this.lbl_STYLE_CD);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox10);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox11);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox12);
			this.pnl_Search1_Image.Location = new System.Drawing.Point(8, 8);
			this.pnl_Search1_Image.Name = "pnl_Search1_Image";
			this.pnl_Search1_Image.Size = new System.Drawing.Size(996, 152);
			this.pnl_Search1_Image.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(208, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 13);
			this.label1.TabIndex = 179;
			this.label1.Text = "~";
			// 
			// dpick_BEDAT2
			// 
			this.dpick_BEDAT2.CustomFormat = "yyyy-MM-dd";
			this.dpick_BEDAT2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_BEDAT2.Location = new System.Drawing.Point(225, 80);
			this.dpick_BEDAT2.Name = "dpick_BEDAT2";
			this.dpick_BEDAT2.Size = new System.Drawing.Size(97, 20);
			this.dpick_BEDAT2.TabIndex = 178;
			this.dpick_BEDAT2.Value = new System.DateTime(2005, 9, 30, 0, 0, 0, 0);
			// 
			// dpick_BEDAT1
			// 
			this.dpick_BEDAT1.CustomFormat = "yyyy-MM-dd";
			this.dpick_BEDAT1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_BEDAT1.Location = new System.Drawing.Point(111, 80);
			this.dpick_BEDAT1.Name = "dpick_BEDAT1";
			this.dpick_BEDAT1.Size = new System.Drawing.Size(97, 20);
			this.dpick_BEDAT1.TabIndex = 177;
			this.dpick_BEDAT1.Value = new System.DateTime(2005, 9, 1, 0, 0, 0, 0);
			// 
			// lbl_BEDAT
			// 
			this.lbl_BEDAT.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_BEDAT.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_BEDAT.ImageIndex = 1;
			this.lbl_BEDAT.ImageList = this.img_Label;
			this.lbl_BEDAT.Location = new System.Drawing.Point(10, 81);
			this.lbl_BEDAT.Name = "lbl_BEDAT";
			this.lbl_BEDAT.Size = new System.Drawing.Size(100, 21);
			this.lbl_BEDAT.TabIndex = 176;
			this.lbl_BEDAT.Text = "Doc Date";
			this.lbl_BEDAT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Sheet_Name
			// 
			this.lbl_Sheet_Name.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Sheet_Name.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Sheet_Name.ImageIndex = 1;
			this.lbl_Sheet_Name.ImageList = this.img_Label;
			this.lbl_Sheet_Name.Location = new System.Drawing.Point(672, 36);
			this.lbl_Sheet_Name.Name = "lbl_Sheet_Name";
			this.lbl_Sheet_Name.Size = new System.Drawing.Size(100, 21);
			this.lbl_Sheet_Name.TabIndex = 175;
			this.lbl_Sheet_Name.Text = "Sheet Name";
			this.lbl_Sheet_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_sheet
			// 
			this.txt_sheet.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_sheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_sheet.Enabled = false;
			this.txt_sheet.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_sheet.ForeColor = System.Drawing.Color.Black;
			this.txt_sheet.Location = new System.Drawing.Point(773, 36);
			this.txt_sheet.MaxLength = 100;
			this.txt_sheet.Name = "txt_sheet";
			this.txt_sheet.Size = new System.Drawing.Size(210, 21);
			this.txt_sheet.TabIndex = 174;
			this.txt_sheet.Text = "PO HEADER, PO ITEM, PO SIZE";
			// 
			// btn_path
			// 
			this.btn_path.Image = ((System.Drawing.Image)(resources.GetObject("btn_path.Image")));
			this.btn_path.Location = new System.Drawing.Point(300, 58);
			this.btn_path.Name = "btn_path";
			this.btn_path.Size = new System.Drawing.Size(21, 21);
			this.btn_path.TabIndex = 173;
			this.btn_path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
			// 
			// txt_Path
			// 
			this.txt_Path.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Path.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Path.ForeColor = System.Drawing.Color.Black;
			this.txt_Path.Location = new System.Drawing.Point(111, 58);
			this.txt_Path.MaxLength = 100;
			this.txt_Path.Name = "txt_Path";
			this.txt_Path.ReadOnly = true;
			this.txt_Path.Size = new System.Drawing.Size(188, 21);
			this.txt_Path.TabIndex = 172;
			this.txt_Path.Text = "C:\\PO_Extractor_Rpt_VJ.xls";
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
			this.cmb_OBS_ID.Location = new System.Drawing.Point(111, 125);
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
			this.cmb_PO_TYPE.Location = new System.Drawing.Point(111, 103);
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
			this.lbl_PO_TYPE.Location = new System.Drawing.Point(10, 103);
			this.lbl_PO_TYPE.Name = "lbl_PO_TYPE";
			this.lbl_PO_TYPE.Size = new System.Drawing.Size(100, 21);
			this.lbl_PO_TYPE.TabIndex = 167;
			this.lbl_PO_TYPE.Text = "PO Type";
			this.lbl_PO_TYPE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_PO_ID
			// 
			this.lbl_PO_ID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_PO_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_PO_ID.ImageIndex = 1;
			this.lbl_PO_ID.ImageList = this.img_Label;
			this.lbl_PO_ID.Location = new System.Drawing.Point(10, 125);
			this.lbl_PO_ID.Name = "lbl_PO_ID";
			this.lbl_PO_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_PO_ID.TabIndex = 165;
			this.lbl_PO_ID.Text = "PO ID";
			this.lbl_PO_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.txt_Style.MaxLength = 6;
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
			this.cmb_Factory.Location = new System.Drawing.Point(111, 36);
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
			this.pictureBox5.Size = new System.Drawing.Size(19, 106);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.Color.Blue;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(906, 138);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(90, 14);
			this.pictureBox8.TabIndex = 8;
			this.pictureBox8.TabStop = false;
			// 
			// lbl_Path
			// 
			this.lbl_Path.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Path.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Path.ImageIndex = 1;
			this.lbl_Path.ImageList = this.img_Label;
			this.lbl_Path.Location = new System.Drawing.Point(10, 58);
			this.lbl_Path.Name = "lbl_Path";
			this.lbl_Path.Size = new System.Drawing.Size(100, 21);
			this.lbl_Path.TabIndex = 19;
			this.lbl_Path.Text = "File Name";
			this.lbl_Path.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(0, 24);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(32, 117);
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
			this.pictureBox10.Size = new System.Drawing.Size(948, 120);
			this.pictureBox10.TabIndex = 4;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox11.BackColor = System.Drawing.Color.Blue;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(0, 138);
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
			this.pictureBox12.Location = new System.Drawing.Point(72, 138);
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
			this.pnl_Body.Controls.Add(this.fgrid_EKET);
			this.pnl_Body.Controls.Add(this.fgrid_EKKO);
			this.pnl_Body.Controls.Add(this.pnl_progress);
			this.pnl_Body.Controls.Add(this.fgrid_EKPO);
			this.pnl_Body.DockPadding.Left = 8;
			this.pnl_Body.DockPadding.Right = 8;
			this.pnl_Body.Location = new System.Drawing.Point(0, 232);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1012, 408);
			this.pnl_Body.TabIndex = 41;
			// 
			// fgrid_EKET
			// 
			this.fgrid_EKET.AutoResize = false;
			this.fgrid_EKET.BackColor = System.Drawing.Color.White;
			this.fgrid_EKET.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_EKET.ColumnInfo = "2,1,0,0,0,85,Columns:";
			this.fgrid_EKET.ForeColor = System.Drawing.Color.Black;
			this.fgrid_EKET.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_EKET.Location = new System.Drawing.Point(736, 208);
			this.fgrid_EKET.Name = "fgrid_EKET";
			this.fgrid_EKET.Rows.Count = 2;
			this.fgrid_EKET.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_EKET.Size = new System.Drawing.Size(200, 176);
			this.fgrid_EKET.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_EKET.TabIndex = 45;
			// 
			// fgrid_EKKO
			// 
			this.fgrid_EKKO.AutoResize = false;
			this.fgrid_EKKO.BackColor = System.Drawing.Color.White;
			this.fgrid_EKKO.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_EKKO.ColumnInfo = "2,1,0,0,0,85,Columns:";
			this.fgrid_EKKO.ForeColor = System.Drawing.Color.Black;
			this.fgrid_EKKO.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_EKKO.Location = new System.Drawing.Point(736, 16);
			this.fgrid_EKKO.Name = "fgrid_EKKO";
			this.fgrid_EKKO.Rows.Count = 2;
			this.fgrid_EKKO.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_EKKO.Size = new System.Drawing.Size(200, 176);
			this.fgrid_EKKO.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_EKKO.TabIndex = 44;
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
			this.pnl_progress.Location = new System.Drawing.Point(322, 113);
			this.pnl_progress.Name = "pnl_progress";
			this.pnl_progress.Size = new System.Drawing.Size(368, 175);
			this.pnl_progress.TabIndex = 43;
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
			this.fgrid_EKPO.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_EKPO.ForeColor = System.Drawing.Color.Black;
			this.fgrid_EKPO.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_EKPO.Location = new System.Drawing.Point(8, 0);
			this.fgrid_EKPO.Name = "fgrid_EKPO";
			this.fgrid_EKPO.Rows.Count = 2;
			this.fgrid_EKPO.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_EKPO.Size = new System.Drawing.Size(996, 408);
			this.fgrid_EKPO.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_EKPO.TabIndex = 38;
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.ctm_Verification,
																						 this.ctm_OBS_REQ,
																						 this.ctm_Bar_First,
																						 this.ctm_OBS_Sel,
																						 this.ctm_OBS_Hist});
			// 
			// ctm_Verification
			// 
			this.ctm_Verification.Index = 0;
			this.ctm_Verification.Text = "OBS Verification";
			this.ctm_Verification.Click += new System.EventHandler(this.ctm_Verification_Click);
			// 
			// ctm_OBS_REQ
			// 
			this.ctm_OBS_REQ.Index = 1;
			this.ctm_OBS_REQ.Text = "OBS Request";
			this.ctm_OBS_REQ.Click += new System.EventHandler(this.ctm_OBS_REQ_Click);
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
			this.ctm_OBS_Sel.Click += new System.EventHandler(this.ctm_OBS_Sel_Click);
			// 
			// ctm_OBS_Hist
			// 
			this.ctm_OBS_Hist.Index = 4;
			this.ctm_OBS_Hist.Text = "OBS History";
			this.ctm_OBS_Hist.Click += new System.EventHandler(this.ctm_OBS_Hist_Click);
			// 
			// Form_EL_PGS
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Search);
			this.Font = new System.Drawing.Font("Verdana", 8F);
			this.Name = "Form_EL_PGS";
			this.Load += new System.EventHandler(this.Form_EL_PGS_Load);
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
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EKET)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EKKO)).EndInit();
			this.pnl_progress.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EKPO)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		
		#region 속성 정의
		private int _Rowfixed=2; 
		private string _sheet1, _sheet2, _sheet3;
		
		private OleDbDataReader reader_ekko;
		private OleDbDataReader reader_ekpo;
		private OleDbDataReader reader_eket;

		COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction MyComFunction    = new COM.ComFunction();
		#endregion

		#region 멤버 메서드
		private void Init_Form()
		{ 
			//Title
			this.Text = "Pegasus Loading";
			this.lbl_MainTitle.Text = "Pegasus Loading"; 
			ClassLib.ComFunction.SetLangDic(this);

			

			#region 버튼 권한
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
		
			// 그리드 설정
			fgrid_EKKO.Set_Grid( "SEM_EKKO", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);  
			fgrid_EKKO.Font  = new Font("Verdana",8);
			fgrid_EKKO.Visible  = false;

			fgrid_EKPO.Set_Grid( "SEM_EKPO", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);  
			fgrid_EKPO.Font  = new Font("Verdana",8);

			fgrid_EKET.Set_Grid( "SEM_EKET", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);  
			fgrid_EKET.Font  = new Font("Verdana",8);
			fgrid_EKET.Visible = false;

			// 콤보박스 설정
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
			dpick_BEDAT2.Text = MyComFunction.ConvertDate2Type(now);

			// Get target Excel File Path
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxPGS_Path);
			txt_Path.Text = dt_list.Rows[0].ItemArray[1].ToString();

			// Get target Excel File Sheetname
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxPGS_Sheet);
			_sheet1 = dt_list.Rows[0].ItemArray[1].ToString();
			_sheet2 = dt_list.Rows[1].ItemArray[1].ToString();
			_sheet3 = dt_list.Rows[2].ItemArray[1].ToString();
			txt_sheet.Text = _sheet1 + ", " + _sheet2 + ", " + _sheet3; 		


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


		#endregion

		#region DB 컨트롤
		private static DataTable Select_PO_TYPE()
		{
 
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet ds_ret;
 
			MyOraDB.ReDim_Parameter(1); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SEM_GPO.SELECT_PO_TYPE";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 
 
		}


		/// <summary>
		/// Select_PGS_List
		/// </summary>
		private void Select_PGS_List()
		{
			string strSrc = txt_Path.Text;
				
			fgrid_EKKO.Rows.Count = _Rowfixed;
			fgrid_EKPO.Rows.Count = _Rowfixed;
			fgrid_EKET.Rows.Count = _Rowfixed;

			string strSql_EKKO =
				" SELECT "+ 
						" Factory_Vendor_Code  AS FACTORY   ," +
						" PO_Number     AS OBS_NU           ," + 
						" '" + cmb_OBS_ID.Text  + "' AS PO_ID," + 
						" PO_Number     AS EBELN            ," + 
						" PO_Doc_Date   AS BEDAT            ," + 
						" Company_Code  AS BUKRS            ," + 
						" PO_Org        AS EKORG            ," + 
						" PO_Group      AS EKGRP            ," + 
						" ' '           AS LIFN2            ," + 
						" PO_Type       AS BSART            ," + 
						" Currency_Type AS WAERS            ," + 
						" ' '           AS WKURS            ," + 
						" Ship_Via_Instructions AS  INCO1   ," + 
						" ' '           AS INCO2            ," + 
						" ' '           AS AEDAT            ," + 
						" ' '           AS ERNAM            ," + 
						" ' '           AS FFS_CHNG_DTTM    ," +  
						" ' '           AS SNDPRN           ," + 
						" ' '           AS ZTERM            ," +
						" BUY_SEASON    AS ZZSESN_CD        ," + 
						" BUY_YEAR      AS ZZSESN_YR        ," + 
						" BUY_GROUP     AS BUY_GRP_CD       ," + 
						" Factory_Vendor_Code AS LIFNR      ," + 
						" Vendor_Location_Code_MCO AS FFS_VNDR_LOC_CD," +
						"'" + ClassLib.ComVar.This_User+ "',"+
						"'"+ System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +"'"+
						"   FROM [" + _sheet1 + "$]  "+
						"  WHERE PO_Number LIKE '"         + txt_OBS_Nu.Text + "%'" + 
						"    AND Factory_Vendor_Code  = '" + cmb_Factory.SelectedValue.ToString()  + "'" +
						"    AND PO_Doc_Date          >=  '" + Convert.ToDateTime(dpick_BEDAT1.Text).ToString("yyyyMMdd") + "'"+     
						"    AND PO_Doc_Date          <=  '" + Convert.ToDateTime(dpick_BEDAT2.Text).ToString("yyyyMMdd") + "'"+  
//						"    AND PO_Doc_Date         >= '" + dpick_BEDAT1.Text                     + "'" +
//						"    AND PO_Doc_Date         <= '" + dpick_BEDAT2.Text                     + "'" +
//										"    AND PO_Doc_Date         >= '20050901'" +
//										"    AND PO_Doc_Date         <= '20050931'" +
						"    AND BUY_GROUP           = '" + cmb_PO_TYPE.SelectedValue.ToString()  + "'" ;

			
			string strSql_EKPO =
               " SELECT " + 
						"  K.Factory_Vendor_Code   AS FACTORY             ,"+
						"  K.PO_Number             AS OBS_NU              ,"+
						"  P.PO_Item               AS OBS_SEQ_NU          ,"+ 
						"  '" + cmb_OBS_ID.Text.ToString() +"' AS OBS_ID  ,"+
						"  K.PO_Doc_Date           AS DOC_YMD             ,"+
						"  P.MSR_Indicator         AS MSR_DIV             ,"+
						"  P.Launch_Indicator      AS LCH_DIV             ,"+
						"  P.PO_Number             AS EBELN               ,"+
						"  P.PO_Item               AS EBELP               ,"+
				        "  P.Material_Number       AS MATNR              ,"+
						"  P.Material_Description  AS TXZ01              ,"+
						"  P.Company_Code          AS BUKRS              ,"+
						"  P.Plant                 AS WERKS              ,"+
						"  P.Nike_Division_Code    AS SPART              ,"+
						"  P.Quantity              AS MENGE              ,"+
						"  P.UOM                   AS MEINS              ,"+
						"  ' '   AS NETPR,  ' '    AS NTGEW              ,"+
						"  P.Mode_Code             AS EVERS              ,"+
						"  P.Mode_Code_Description AS EVTXT              ,"+
						"  ' ' AS PSTYP,	 ' '   AS KNTTP              ,"+
						"  P.OGAC_Date             AS J_3AEXFCP          ,"+
						"  P.GAC_Date              AS ZZ_GAC_DT          ,"+
						"  P.GAC_Reason_Code       AS ZZ_GAC_RSN_CD      ,"+
						"  ' '                     AS FFS_GAC_DT_RQST    ,"+
						"  ' '                     AS FFS_GAC_RSN_CD_RQST,"+
						"  ' '                     AS FFS_GAC_SND_RQST_FL,"+
						"  Customer_PO             AS BSTNK              ,"+
						"  ' '                     AS VDATU              ,"+
						"  ' '                     AS FKDAT              ,"+
						"  P.Delivery_Date         AS EINDT              ,"+
						"  P.Customer_Request_Date AS SLFDT              ,"+
						"  ' '  AS MVGR2,     ' '  AS BSGRU              ,"+
						"  P.Material_Dev_Code     AS BISMT              ,"+
						"  P.Silhhouette_Code      AS ZZ_SILH_CD         ,"+ 
						"  P.Gender_Age_Code       AS ZZ_GNDRAGE         ,"+
						"  P.SO_NUMBER             AS SOVBELN            ,"+
						"  P.SO_ITEM               AS SOVBELP            ,"+
						"  ' '                     AS SO_CUST_DEPT       ,"+
						"  ' '					   AS SO_CUST_DEPT_DESC  ,"+
						"  P.AFS_STOCK_CATEGORY    AS J_4KSCAT           ,"+
						"  P.Address_Code_Id       AS KUNNR              ,"+
						"  P.Ship_To_Account       AS FFS_SHP_TO_ACCT    ,"+
						"  ' ' AS   WAERS,     ' ' AS PO_ITEM_STATUS     ,"+
				        "  P.Color_Combo_Name      AS COLORCOMBNAME      ,"+
				        "  P.Color_Combo_ShortName AS COLORCOMBSHORTNAME ,"+				
				        "  P.RGAC_Date             AS RGAC_DATE          ,"+
				        "  'R'                     AS OBS_DIV            ,"+
						"'" +   ClassLib.ComVar.This_User+             "',"+
						"'"+    System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +"'"+
						"  FROM [" + _sheet1 + "$] K, [" + _sheet2 + "$] P             "+ 
						" WHERE K.PO_Number  = P.PO_Number                "+
						"   AND K.Factory_Vendor_Code  = '" + cmb_Factory.SelectedValue.ToString()  + "'" +
						"   AND K.PO_Doc_Date         >= '" + Convert.ToDateTime(dpick_BEDAT1.Text).ToString("yyyyMMdd") + "'"+             					"   AND K.PO_Doc_Date         <= '" + Convert.ToDateTime(dpick_BEDAT2.Text).ToString("yyyyMMdd") + "'"+        
//				"    AND PO_Doc_Date         >= '20050901'" +
//				"    AND PO_Doc_Date         <= '20050931'" +
						"   AND K.BUY_GROUP           = '" + cmb_PO_TYPE.SelectedValue.ToString()   + "'" +
						"   AND P.PO_Number LIKE   '" + txt_OBS_Nu.Text					            + "%'" +
						"   AND P.PO_Item LIKE     '" + txt_Seq.Text						   	    + "%'"+ 
						"   AND P.Material_Number  LIKE '" +  txt_Style.Text.Replace("-","")        + "%'" +
						" ORDER BY K.PO_Number, P.PO_Item                                           "; 

			string strSql_EKET =
				  " SELECT " + 
				  " K.Factory_Vendor_Code  AS FACTORY        ,"+  
				  " E.PO_Number            AS OBS_NU         ,"+  
			      " E.PO_Item              AS OBS_SEQ_NU     ,"+  
			      " E.SIZE_GRID_VALUE      AS CS_SIZE        ,"+  
				  " E.PO_Number            AS EBELN          ,"+  
				  " E.PO_Item              AS EBELP          ,"+  
				  " E.PO_Size_Index        AS ETENR          ,"+  
				  " E.SIZE_GRID_VALUE      AS J_3ASIZE       ,"+  
				  " E.Quantity             AS MENGE          ,"+  
				  " ' '                    AS MEINS          ,"+  
				  " E.FOB                  AS J_3ANETP       ,"+ 
				  " 0                      AS KEBTR          ," + 
				  " UPC_Number             AS EAN11          ,"+  
				  " ' '                    AS J_4KSCAT       ,"+  
				  " ' '                    AS EINDT          ," + 
				  " ' '                    AS SLFDT          ," + 
				  " ' '                    AS FFS_CHNG_DTTM  ," +  
				  " ' '                    AS BAR_CODE       ," + 
				  " 0                      AS CHECK_DIGIT    ," +
				  " E.PO_Size_Index        AS FIRST_DIV      ," +     //Excel에서  PO_Size_Index =1이면 삭제
				  " 'G'                    AS OBS_DIV      ," +     //Excel에서  PO_Size_Index =1이면 삭제
				  "'" +   ClassLib.ComVar.This_User+ "'      ,"+
				  "'" +   System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +"'"+
				  "   FROM [" + _sheet1 + "$] K, [" + _sheet3 + "$] E, [" + _sheet2 + "$] P " + 
				  "  WHERE K.PO_Number = E.PO_Number                      " +
				  "    AND E.PO_Number = P.PO_Number                      " +
				  "    AND E.PO_Item   = P.PO_Item                        " +
				  "    AND K.Factory_Vendor_Code   = '" + cmb_Factory.SelectedValue.ToString()  + "'" +
				  "    AND K.PO_Doc_Date          >=  '" + Convert.ToDateTime(dpick_BEDAT1.Text).ToString("yyyyMMdd") + "'"+      
				  "    AND K.PO_Doc_Date          <=  '" + Convert.ToDateTime(dpick_BEDAT2.Text).ToString("yyyyMMdd") + "'"+      
//				"    AND PO_Doc_Date         >= '20050901'" +
//				"    AND PO_Doc_Date         <= '20050931'" +
				  "    AND K.BUY_GROUP             = '" + cmb_PO_TYPE.SelectedValue.ToString()  + "'" +
				  "    AND P.PO_Number LIKE          '" + txt_OBS_Nu.Text						+ "%'" +
				  "    AND P.PO_Item LIKE            '" + txt_Seq.Text							+ "%'" +
				  "    AND P.Material_Number  LIKE   '" + txt_Style.Text.Replace("-","")        + "%'" +
				  "  ORDER BY E.PO_Number, E.PO_Item , E.PO_Size_Index ";   


			//-----------EKKO Setting하기-----------------
			fgrid_EKKO.Rows.Count = _Rowfixed;
			reader_ekko = ClassLib.ComFunction.Read_Excel(strSrc, strSql_EKKO); 
			string[] str_k = new string[reader_ekko.FieldCount];			
			while (reader_ekko.Read())
			{
				for(int i=0; i<reader_ekko.FieldCount; i++)				
					str_k[i] = ClassLib.ComFunction.Convert_dtType(reader_ekko[i].GetType().Name.ToString(), reader_ekko[i].ToString());

				for(int i=0; i<reader_ekko.FieldCount; i++)				
				{
					if (i==2)
						str_k[i] = reader_ekko[i].ToString().PadLeft(6, '0').ToString();
					else
						str_k[i] = ClassLib.ComFunction.Convert_dtType(reader_ekko[i].GetType().Name.ToString(), reader_ekko[i].ToString());
				}

				fgrid_EKKO.AddItem(str_k, fgrid_EKKO.Rows.Count, 1);			
				str_k.Initialize();							
			}
			fgrid_EKKO.AutoSizeCols();
			fgrid_EKKO.Cols[0].Width = 20;


			//-----------EKPO Setting하기-----------------
			fgrid_EKPO.Rows.Count = _Rowfixed;
			reader_ekpo = ClassLib.ComFunction.Read_Excel(strSrc, strSql_EKPO); 
			string[] str_p = new string[reader_ekpo.FieldCount];			
			while (reader_ekpo.Read())
			{
				for(int i=0; i<reader_ekpo.FieldCount; i++)
				{	
					if (i==2)
						str_p[i] = reader_ekpo[i].ToString().PadLeft(10, '0').ToString();
					else if (i==3)
						str_p[i] = reader_ekpo[i].ToString().PadLeft(6, '0').ToString();
					else
						str_p[i] = ClassLib.ComFunction.Convert_dtType(reader_ekpo[i].GetType().Name.ToString(), reader_ekpo[i].ToString());
				}
				fgrid_EKPO.AddItem(str_p, fgrid_EKPO.Rows.Count, 9);			
				str_p.Initialize();							
			}
			fgrid_EKPO.AutoSizeCols();
			fgrid_EKPO.Cols[0].Width = 20;


			//-------------EKET Setting하기-----------------
			fgrid_EKET.Rows.Count = _Rowfixed;
			reader_eket = ClassLib.ComFunction.Read_Excel(strSrc, strSql_EKET);                                  
			string[] str_e = new string[reader_eket.FieldCount];			
			while (reader_eket.Read())
			{
				for(int i=0; i<reader_eket.FieldCount; i++)				
				{
					if (i==2)
						str_e[i] = reader_eket[i].ToString().PadLeft(10, '0').ToString();
					else
						str_e[i] = ClassLib.ComFunction.Convert_dtType(reader_eket[i].GetType().Name.ToString(), reader_eket[i].ToString());
				}

				fgrid_EKET.AddItem(str_e, fgrid_EKET.Rows.Count, 1);			
				str_e.Initialize();							
			}
			fgrid_EKET.AutoSizeCols();
			fgrid_EKET.Cols[0].Width = 20;


		}




		/// <summary>
		/// GPO LOADING시 STYLE 정보 체크, SEM_GSSC 체크, SEM_DEST 체크
		/// </summary>
		/// <param name="arg_factory"factory></param>
		/// <param name="arg_fgrid">작업그리드</param>
		public bool Check_Style(C1FlexGrid arg_fgrid)
		{			
			try
			{

				//공장코드/ OBS ID  재 검증
				if((fgrid_EKPO[_Rowfixed,(int)ClassLib.TBSEM_EKPO.IxFACTORY].ToString() != cmb_Factory.SelectedValue.ToString()) ||
					(fgrid_EKPO[_Rowfixed,(int)ClassLib.TBSEM_EKPO.IxOBS_ID].ToString() != cmb_OBS_ID.Text.ToString()))
				{ClassLib.ComFunction.User_Message("Factory or OBS ID") ; return false;}


				string strRlt; int iCnt;
				DataSet ret;  DataTable dt_list; 	
				DateTime CurDate = DateTime.Now;	

				lbl_2.ForeColor = Color.SaddleBrown;
				lbl_2.Text = "▶Data Check"; 
				lbl_2.Refresh();
				
				progressBar1.Maximum = arg_fgrid.Rows.Count-1;

				for (int i=arg_fgrid.Rows.Fixed; i<arg_fgrid.Rows.Count; i++)
				{		
	                 
					string arg_fact  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxFACTORY].ToString().Trim();
					string arg_ponu  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxOBS_NU].ToString().Trim();
					string arg_posq  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxOBS_SEQ_NU].ToString().Trim();			
	                
					//*************************************
					//      1차 Style정보 검증
					//*************************************
					string arg_style = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxMATNR].ToString().Replace("-","");
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
	 
						//추출한 스타일 정보에서 
						//if (cmb_PO_TYPE.SelectedValue.ToString() == "05")  
						//Pegasus는 gssc검증 안함.
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
					//      2차 Mercury Order Check
					//*************************************
					#region  Mercury Order Check
//					
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
				return true;
				#endregion
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
				lbl_1.Text = "▶OBS ID Check"; 
				lbl_1.Refresh();
				
				progressBar1.Maximum = arg_fgrid.Rows.Count-1;

				for (int i=_Rowfixed; i<arg_fgrid.Rows.Count; i++)
				{		
	                
					string arg_fact  = cmb_Factory.SelectedValue.ToString();
					string arg_ponu  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxEBELN].ToString().Trim();
					string arg_posq  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxEBELP].ToString().PadLeft(10,'0');			
	               
			    
					iCnt =  4;
					MyOraDB.ReDim_Parameter(iCnt); 		   

					strRlt  =  "PKG_SEM_GPO.SELECT_SEM_OBSID";
					MyOraDB.Process_Name =strRlt;
		
					MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
					MyOraDB.Parameter_Name[1] = "ARG_OBS_NU";  
					MyOraDB.Parameter_Name[2] = "ARG_OBS_SEQ_NU";  
					MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
					
					MyOraDB.Parameter_Type[0] =  (int)OracleType.VarChar;
					MyOraDB.Parameter_Type[1] =  (int)OracleType.VarChar;
					MyOraDB.Parameter_Type[2] =  (int)OracleType.VarChar;
					MyOraDB.Parameter_Type[3] =  (int)OracleType.Cursor;						
		
					MyOraDB.Parameter_Values[0] = arg_fact;
					MyOraDB.Parameter_Values[1] = arg_ponu;  
					MyOraDB.Parameter_Values[2] = arg_posq; 
					MyOraDB.Parameter_Values[3] = "";
					
					MyOraDB.Add_Select_Parameter(true); 
					ret = MyOraDB.Exe_Select_Procedure();
											
					if (ret == null)  return false  ;
					dt_list  =  ret.Tables[strRlt];

					//obs id 가 두개 이상인 경우.
					if (dt_list.Rows.Count > 1) 
					{ ClassLib.ComFunction.User_Message("OBS ID is wrong !!!  OBS_Nu:" + arg_ponu +"OBS_Seq_Nu"+ arg_posq );return false;}

					//obs id가 user가 입력한 것이랑 다를 경우.
					if ((dt_list.Rows.Count ==1) &&(dt_list.Rows[0].ItemArray[0].ToString() != cmb_OBS_ID.Text))
					{ ClassLib.ComFunction.User_Message("OBS ID is wrong !!!  OBS_Nu:" + arg_ponu +"OBS_Seq_Nu"+ arg_posq );return false;}

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
		/// SAVE SEM_OBS
		/// </summary>
		private bool Save_SEM_GPO(C1FlexGrid arg_fgrid)  
		{   
		
			lbl_1.ForeColor = Color.SaddleBrown;
			lbl_1.Text = "▶ GPO Move"; 
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

				lbl_1.Text = "▶ EKKO Move"; 
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
				lbl_1.Text = "▶ EKPO Move"; 
				lbl_1.Refresh();

				
				progressBar1.Value = 0;
				progressBar1.Maximum = fgrid_EKPO.Rows.Count-1;

				int intParm = (int)ClassLib.TBSEM_EKPO.IxMaxCt-8;

				MyOraDB.ReDim_Parameter(intParm); 

				MyOraDB.Process_Name = "PKG_SEM_GPO.SAVE_SEM_EKPO";

				for(int i = 0; i < intParm; i++)
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 

				#region  파라미터 정의 	
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
				MyOraDB.Parameter_Name[10]  = "ARG_TXZ01";   	
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
				MyOraDB.Parameter_Name[40] = "ARG_SO_CUST_DEPT"; 
				MyOraDB.Parameter_Name[41] = "ARG_SO_CUST_DEPT_DESC"; 
				MyOraDB.Parameter_Name[42] = "ARG_J_4KSCAT"; 		    
				MyOraDB.Parameter_Name[43] = "ARG_KUNNR"; 			    
				MyOraDB.Parameter_Name[44] = "ARG_FFS_SHP_TO_ACCT";     
				MyOraDB.Parameter_Name[45] = "ARG_WAERS";   			
				MyOraDB.Parameter_Name[46] = "ARG_PO_ITEM_STATUS";  
				MyOraDB.Parameter_Name[47] = "ARG_COLORCOMBNAME";
				MyOraDB.Parameter_Name[48] = "ARG_COLORCOMBSHORTNAME";
				MyOraDB.Parameter_Name[49] = "ARG_RGACYMD";
				MyOraDB.Parameter_Name[50] = "ARG_OBS_DIV";
				MyOraDB.Parameter_Name[51] = "ARG_UPD_USER"; 			
				MyOraDB.Parameter_Name[52] = "ARG_UPD_YMD";

				#endregion

				for(int i=_Rowfixed ; i<fgrid_EKPO.Rows.Count ; i++)
				{   
					int iRow=0;
					for(int j=(int)ClassLib.TBSEM_EKPO.IxFACTORY ; j<fgrid_EKPO.Cols.Count; j++)				
					{  
						if (j==(int)ClassLib.TBSEM_EKPO.IxMATNR)  //스타일 코드 편집하기
						{
							MyOraDB.Parameter_Values[iRow]  = fgrid_EKPO[i,j].ToString().Replace("-","");
							iRow = iRow +1;
						}
						else
						{
							MyOraDB.Parameter_Values[iRow]  = fgrid_EKPO[i,j].ToString().Replace("'","`");
							iRow = iRow +1;
						}

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
		/// Save_SEM_GPO_EKET
		/// </summary>
		private bool Save_SEM_GPO_EKET()  
		{
			try
			{
				lbl_1.Text = "▶ EKET Move"; 
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
					int iRow=0;
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
				lbl_1.Text = "▶ MARA Move"; 
				lbl_1.Refresh();

				progressBar1.Value = 0;
				progressBar1.Maximum = fgrid_EKPO.Rows.Count;    //fgrid_EKPO를 이용해서 SEM_MARA가공하기

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
				MyOraDB.Parameter_Name[10] = "ARG_CATEGORYNAME"; 
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
				

				for(int i=_Rowfixed ; i< fgrid_EKPO.Rows.Count ; i++)
				{
					for(int j=1; j<(int)ClassLib.TBSEM_MARA.IxMaxCt+1; j++)				
					{
						//나머지공백 처리
						MyOraDB.Parameter_Values[j]  = " ";

						MyOraDB.Parameter_Values[0]  = "I";
						MyOraDB.Parameter_Values[1]  = cmb_Factory.SelectedValue.ToString();
						MyOraDB.Parameter_Values[2]  = fgrid_EKPO[i,(int)ClassLib.TBSEM_EKPO.IxMATNR ].ToString().Replace("-","");
						MyOraDB.Parameter_Values[3]  = fgrid_EKPO[i,(int)ClassLib.TBSEM_EKPO.IxMATNR ].ToString();
						MyOraDB.Parameter_Values[4]  = fgrid_EKPO[i,(int)ClassLib.TBSEM_EKPO.IxTXZ01].ToString();
						MyOraDB.Parameter_Values[5]  = fgrid_EKPO[i,(int)ClassLib.TBSEM_EKPO.IxTXZ01].ToString();
						MyOraDB.Parameter_Values[7]  = fgrid_EKPO[i,(int)ClassLib.TBSEM_EKPO.lxCOLORCOMBNAME].ToString();
						MyOraDB.Parameter_Values[6]  = fgrid_EKPO[i,(int)ClassLib.TBSEM_EKPO.lxCOLORCOMBSHORTNAME].ToString();
						MyOraDB.Parameter_Values[25]   = fgrid_EKPO[i,(int)ClassLib.TBSEM_EKPO.IxUPD_USER].ToString();
						MyOraDB.Parameter_Values[26]   = fgrid_EKPO[i,(int)ClassLib.TBSEM_EKPO.IxUPD_YMD].ToString();	
						
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
		/// SAVE SEM_OBS
		/// </summary>
		private bool Save_SEM_OBS(C1FlexGrid arg_fgrid)  
		{
			try
			{
				progressBar1.Value = 0;
				lbl_3.ForeColor = Color.SaddleBrown;
				lbl_3.Text = "▶ OBS ";
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
					MyOraDB.Parameter_Values[8]  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.IxMATNR].ToString().Replace("-","");
					MyOraDB.Parameter_Values[9]  = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.lxchkStyle].ToString();
					MyOraDB.Parameter_Values[10] = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.lxchkModel].ToString();
					MyOraDB.Parameter_Values[11] = arg_fgrid[i, (int)ClassLib.TBSEM_EKPO.lxchkGen].ToString();
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


		#endregion

		#region 이벤트처리
		private void cmb_PO_TYPE_TextChanged(object sender, System.EventArgs e)
		{
			if(cmb_PO_TYPE.SelectedIndex == -1) return;

			cmb_OBS_ID.ClearItems();
			ClassLib.ComFunction.Set_OBSID_CmbList(cmb_PO_TYPE.Text.ToString(), cmb_OBS_ID);  

		}

		private void btn_path_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dir  = new OpenFileDialog();
			dir.Filter = "(*.*)|*.xls";

			if (dir.ShowDialog() == DialogResult.OK)
			{
				txt_Path.Text  = dir.FileName.Trim();
			}

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{		
				//Pegasus Order정보
				 Select_PGS_List();		
		
				if (fgrid_EKPO.Rows.Count == _Rowfixed) 
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch,this);
				}
		 
			}
			catch
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch,this);
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


				//스타일등 정보 체크
				if (Check_Style(fgrid_EKPO) == false) 
				{ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); pnl_progress.Visible = false;return; }

				//OBS ID정보 체크
				if (Check_OBS_ID(fgrid_EKPO) == false) 
				{ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);pnl_progress.Visible = false;return; }		

				//MOVE GPO
				if (Save_SEM_GPO(fgrid_EKPO) == false) 
				{ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); pnl_progress.Visible = false;return; }

				//UPLOAD..
				if (Save_SEM_OBS(fgrid_EKPO) == false) 
				{ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); pnl_progress.Visible = false;return; }

				//저장 완료
				pnl_progress.Visible = false;
				SB_Pop_Up("01");
						
			}
			catch 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this); return;
			}
		}


		#endregion

		#region 콘텍스 메뉴
		
		private void ctm_Verification_Click(object sender, System.EventArgs e)
		{
			SB_Pop_Up("02");
		}

		
		private void ctm_OBS_REQ_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBSCS.Form_EC_Req frm = new ExpOBSCS.Form_EC_Req();  
			frm.Show();
		}

		private void ctm_OBS_Sel_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBS.Form_EO_SRCH frm = new ExpOBS.Form_EO_SRCH();  
			frm.Show();
		}


		private void ctm_OBS_Hist_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBS.Form_EO_Hist frm = new ExpOBS.Form_EO_Hist();  
			frm.Show();		
		}
		#endregion

		private void Form_EL_PGS_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}


	}
}

