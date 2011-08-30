using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Outgoing
{
	public class Form_Outgoing_req_list : COM.PCHWinForm.Form_Top
	{
		public System.Windows.Forms.Panel pnl_Top;
		private System.Windows.Forms.Label lbl_srf_no;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.Label btn_openfile;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox9;
		public COM.FSP flg_out_req;
		private System.ComponentModel.IContainer components = null;
		private COM.OraDB OraDB = new COM.OraDB();
		private System.Windows.Forms.DateTimePicker dpk_req_date;
		private System.Windows.Forms.Label lbl_req_div;
		private System.Windows.Forms.Label lbl_req_date;
		private System.Windows.Forms.TextBox txt_srf_no;
		private System.Windows.Forms.Label lbl_req_reason;
		private System.Windows.Forms.TextBox txt_mat_name;
		private System.Windows.Forms.Label lbl_req_no;
		public C1.Win.C1List.C1Combo cmb_req_div;
		public C1.Win.C1List.C1Combo cmb_req_no;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private int show_lev = 0;

		private string req_no = null;
		private System.Windows.Forms.TextBox txt_style_name;
		private System.Windows.Forms.Label lbl_style_name;
		private C1.Win.C1List.C1Combo cmb_req_status;

		private int _RowFixed = 0;

		private int tmp_req_status = 0;
		private int tmp_req_no = 0;
		private int tmp_req_div = 0;
		public C1.Win.C1List.C1Combo cmb_scj_type;
		private System.Windows.Forms.Label lbl_sch_type;
		private string tmp_req_no_detail = null;

		public Form_Outgoing_req_list()
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Outgoing_req_list));
			this.pnl_Top = new System.Windows.Forms.Panel();
			this.cmb_scj_type = new C1.Win.C1List.C1Combo();
			this.lbl_sch_type = new System.Windows.Forms.Label();
			this.cmb_req_status = new C1.Win.C1List.C1Combo();
			this.cmb_req_no = new C1.Win.C1List.C1Combo();
			this.lbl_req_no = new System.Windows.Forms.Label();
			this.txt_srf_no = new System.Windows.Forms.TextBox();
			this.lbl_srf_no = new System.Windows.Forms.Label();
			this.txt_mat_name = new System.Windows.Forms.TextBox();
			this.txt_style_name = new System.Windows.Forms.TextBox();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_req_reason = new System.Windows.Forms.Label();
			this.lbl_style_name = new System.Windows.Forms.Label();
			this.dpk_req_date = new System.Windows.Forms.DateTimePicker();
			this.cmb_req_div = new C1.Win.C1List.C1Combo();
			this.lbl_req_div = new System.Windows.Forms.Label();
			this.lbl_req_date = new System.Windows.Forms.Label();
			this.lbl_status = new System.Windows.Forms.Label();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_title = new System.Windows.Forms.Label();
			this.btn_openfile = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.flg_out_req = new COM.FSP();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Top.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_scj_type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_req_status)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_req_no)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_req_div)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.flg_out_req)).BeginInit();
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
			// tbtn_Create
			// 
			this.tbtn_Create.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Create_Click);
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// tbtn_Confirm
			// 
			this.tbtn_Confirm.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Confirm_Click);
			// 
			// pnl_Top
			// 
			this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Top.Controls.Add(this.cmb_scj_type);
			this.pnl_Top.Controls.Add(this.lbl_sch_type);
			this.pnl_Top.Controls.Add(this.cmb_req_status);
			this.pnl_Top.Controls.Add(this.cmb_req_no);
			this.pnl_Top.Controls.Add(this.lbl_req_no);
			this.pnl_Top.Controls.Add(this.txt_srf_no);
			this.pnl_Top.Controls.Add(this.lbl_srf_no);
			this.pnl_Top.Controls.Add(this.txt_mat_name);
			this.pnl_Top.Controls.Add(this.txt_style_name);
			this.pnl_Top.Controls.Add(this.cmb_factory);
			this.pnl_Top.Controls.Add(this.lbl_req_reason);
			this.pnl_Top.Controls.Add(this.lbl_style_name);
			this.pnl_Top.Controls.Add(this.dpk_req_date);
			this.pnl_Top.Controls.Add(this.cmb_req_div);
			this.pnl_Top.Controls.Add(this.lbl_req_div);
			this.pnl_Top.Controls.Add(this.lbl_req_date);
			this.pnl_Top.Controls.Add(this.lbl_status);
			this.pnl_Top.Controls.Add(this.lbl_factory);
			this.pnl_Top.Controls.Add(this.pnl_SearchImage);
			this.pnl_Top.DockPadding.Bottom = 8;
			this.pnl_Top.DockPadding.Left = 8;
			this.pnl_Top.DockPadding.Right = 8;
			this.pnl_Top.Location = new System.Drawing.Point(0, 80);
			this.pnl_Top.Name = "pnl_Top";
			this.pnl_Top.Size = new System.Drawing.Size(1016, 120);
			this.pnl_Top.TabIndex = 138;
			// 
			// cmb_scj_type
			// 
			this.cmb_scj_type.AddItemCols = 0;
			this.cmb_scj_type.AddItemSeparator = ';';
			this.cmb_scj_type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_scj_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_scj_type.Caption = "";
			this.cmb_scj_type.CaptionHeight = 17;
			this.cmb_scj_type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_scj_type.ColumnCaptionHeight = 18;
			this.cmb_scj_type.ColumnFooterHeight = 18;
			this.cmb_scj_type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_scj_type.ContentHeight = 17;
			this.cmb_scj_type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_scj_type.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_scj_type.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_scj_type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_scj_type.EditorHeight = 17;
			this.cmb_scj_type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_scj_type.GapHeight = 2;
			this.cmb_scj_type.ItemHeight = 15;
			this.cmb_scj_type.Location = new System.Drawing.Point(773, 58);
			this.cmb_scj_type.MatchEntryTimeout = ((long)(2000));
			this.cmb_scj_type.MaxDropDownItems = ((short)(5));
			this.cmb_scj_type.MaxLength = 32767;
			this.cmb_scj_type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_scj_type.Name = "cmb_scj_type";
			this.cmb_scj_type.PartialRightColumn = false;
			this.cmb_scj_type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_scj_type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_scj_type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_scj_type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_scj_type.Size = new System.Drawing.Size(210, 21);
			this.cmb_scj_type.TabIndex = 365;
			this.cmb_scj_type.SelectedValueChanged += new System.EventHandler(this.cmb_scj_type_SelectedValueChanged);
			// 
			// lbl_sch_type
			// 
			this.lbl_sch_type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_sch_type.ImageIndex = 0;
			this.lbl_sch_type.ImageList = this.img_Label;
			this.lbl_sch_type.Location = new System.Drawing.Point(672, 58);
			this.lbl_sch_type.Name = "lbl_sch_type";
			this.lbl_sch_type.Size = new System.Drawing.Size(100, 21);
			this.lbl_sch_type.TabIndex = 364;
			this.lbl_sch_type.Text = "Search Type";
			this.lbl_sch_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_req_status
			// 
			this.cmb_req_status.AddItemCols = 0;
			this.cmb_req_status.AddItemSeparator = ';';
			this.cmb_req_status.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_req_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_req_status.Caption = "";
			this.cmb_req_status.CaptionHeight = 17;
			this.cmb_req_status.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_req_status.ColumnCaptionHeight = 18;
			this.cmb_req_status.ColumnFooterHeight = 18;
			this.cmb_req_status.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_req_status.ContentHeight = 17;
			this.cmb_req_status.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_req_status.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_req_status.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_req_status.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_req_status.EditorHeight = 17;
			this.cmb_req_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_req_status.GapHeight = 2;
			this.cmb_req_status.ItemHeight = 15;
			this.cmb_req_status.Location = new System.Drawing.Point(445, 36);
			this.cmb_req_status.MatchEntryTimeout = ((long)(2000));
			this.cmb_req_status.MaxDropDownItems = ((short)(5));
			this.cmb_req_status.MaxLength = 32767;
			this.cmb_req_status.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_req_status.Name = "cmb_req_status";
			this.cmb_req_status.PartialRightColumn = false;
			this.cmb_req_status.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_req_status.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_req_status.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_req_status.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_req_status.Size = new System.Drawing.Size(211, 21);
			this.cmb_req_status.TabIndex = 363;
			this.cmb_req_status.SelectedValueChanged += new System.EventHandler(this.cmb_req_status_SelectedValueChanged);
			// 
			// cmb_req_no
			// 
			this.cmb_req_no.AddItemCols = 0;
			this.cmb_req_no.AddItemSeparator = ';';
			this.cmb_req_no.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_req_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_req_no.Caption = "";
			this.cmb_req_no.CaptionHeight = 17;
			this.cmb_req_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_req_no.ColumnCaptionHeight = 18;
			this.cmb_req_no.ColumnFooterHeight = 18;
			this.cmb_req_no.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_req_no.ContentHeight = 17;
			this.cmb_req_no.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_req_no.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_req_no.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_req_no.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_req_no.EditorHeight = 17;
			this.cmb_req_no.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_req_no.GapHeight = 2;
			this.cmb_req_no.ItemHeight = 15;
			this.cmb_req_no.Location = new System.Drawing.Point(117, 58);
			this.cmb_req_no.MatchEntryTimeout = ((long)(2000));
			this.cmb_req_no.MaxDropDownItems = ((short)(5));
			this.cmb_req_no.MaxLength = 32767;
			this.cmb_req_no.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_req_no.Name = "cmb_req_no";
			this.cmb_req_no.PartialRightColumn = false;
			this.cmb_req_no.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_req_no.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_req_no.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_req_no.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_req_no.Size = new System.Drawing.Size(210, 21);
			this.cmb_req_no.TabIndex = 359;
			this.cmb_req_no.SelectedValueChanged += new System.EventHandler(this.cmb_req_no_SelectedValueChanged);
			// 
			// lbl_req_no
			// 
			this.lbl_req_no.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_req_no.ImageIndex = 0;
			this.lbl_req_no.ImageList = this.img_Label;
			this.lbl_req_no.Location = new System.Drawing.Point(16, 58);
			this.lbl_req_no.Name = "lbl_req_no";
			this.lbl_req_no.Size = new System.Drawing.Size(100, 21);
			this.lbl_req_no.TabIndex = 358;
			this.lbl_req_no.Text = "Request No.";
			this.lbl_req_no.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_srf_no
			// 
			this.txt_srf_no.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_srf_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_srf_no.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_srf_no.ForeColor = System.Drawing.Color.Black;
			this.txt_srf_no.Location = new System.Drawing.Point(445, 80);
			this.txt_srf_no.MaxLength = 100;
			this.txt_srf_no.Name = "txt_srf_no";
			this.txt_srf_no.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_srf_no.Size = new System.Drawing.Size(211, 20);
			this.txt_srf_no.TabIndex = 357;
			this.txt_srf_no.Text = "";
			// 
			// lbl_srf_no
			// 
			this.lbl_srf_no.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_srf_no.ImageIndex = 0;
			this.lbl_srf_no.ImageList = this.img_Label;
			this.lbl_srf_no.Location = new System.Drawing.Point(344, 80);
			this.lbl_srf_no.Name = "lbl_srf_no";
			this.lbl_srf_no.Size = new System.Drawing.Size(100, 21);
			this.lbl_srf_no.TabIndex = 356;
			this.lbl_srf_no.Text = "SRF. NO.";
			this.lbl_srf_no.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_mat_name
			// 
			this.txt_mat_name.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_mat_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_mat_name.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_mat_name.ForeColor = System.Drawing.Color.Black;
			this.txt_mat_name.Location = new System.Drawing.Point(773, 80);
			this.txt_mat_name.MaxLength = 100;
			this.txt_mat_name.Name = "txt_mat_name";
			this.txt_mat_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_mat_name.Size = new System.Drawing.Size(211, 20);
			this.txt_mat_name.TabIndex = 354;
			this.txt_mat_name.Text = "";
			// 
			// txt_style_name
			// 
			this.txt_style_name.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_style_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_style_name.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_style_name.ForeColor = System.Drawing.Color.Black;
			this.txt_style_name.Location = new System.Drawing.Point(117, 80);
			this.txt_style_name.MaxLength = 100;
			this.txt_style_name.Name = "txt_style_name";
			this.txt_style_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_style_name.Size = new System.Drawing.Size(211, 20);
			this.txt_style_name.TabIndex = 353;
			this.txt_style_name.Text = "";
			// 
			// cmb_factory
			// 
			this.cmb_factory.AddItemCols = 0;
			this.cmb_factory.AddItemSeparator = ';';
			this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
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
			this.cmb_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_factory.EditorHeight = 17;
			this.cmb_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_factory.GapHeight = 2;
			this.cmb_factory.ItemHeight = 15;
			this.cmb_factory.Location = new System.Drawing.Point(117, 36);
			this.cmb_factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_factory.MaxDropDownItems = ((short)(5));
			this.cmb_factory.MaxLength = 32767;
			this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_factory.Name = "cmb_factory";
			this.cmb_factory.PartialRightColumn = false;
			this.cmb_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(211, 21);
			this.cmb_factory.TabIndex = 350;
			this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
			// 
			// lbl_req_reason
			// 
			this.lbl_req_reason.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_req_reason.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_req_reason.ImageIndex = 0;
			this.lbl_req_reason.ImageList = this.img_Label;
			this.lbl_req_reason.Location = new System.Drawing.Point(672, 80);
			this.lbl_req_reason.Name = "lbl_req_reason";
			this.lbl_req_reason.Size = new System.Drawing.Size(100, 21);
			this.lbl_req_reason.TabIndex = 327;
			this.lbl_req_reason.Text = "Mat. Name";
			this.lbl_req_reason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_style_name
			// 
			this.lbl_style_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_style_name.ImageIndex = 0;
			this.lbl_style_name.ImageList = this.img_Label;
			this.lbl_style_name.Location = new System.Drawing.Point(16, 80);
			this.lbl_style_name.Name = "lbl_style_name";
			this.lbl_style_name.Size = new System.Drawing.Size(100, 21);
			this.lbl_style_name.TabIndex = 325;
			this.lbl_style_name.Text = "Style Name";
			this.lbl_style_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpk_req_date
			// 
			this.dpk_req_date.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpk_req_date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpk_req_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpk_req_date.Location = new System.Drawing.Point(773, 35);
			this.dpk_req_date.Name = "dpk_req_date";
			this.dpk_req_date.Size = new System.Drawing.Size(211, 22);
			this.dpk_req_date.TabIndex = 324;
			this.dpk_req_date.Value = new System.DateTime(2007, 11, 19, 14, 18, 56, 968);
			this.dpk_req_date.CloseUp += new System.EventHandler(this.dpk_req_date_CloseUp);
			// 
			// cmb_req_div
			// 
			this.cmb_req_div.AddItemCols = 0;
			this.cmb_req_div.AddItemSeparator = ';';
			this.cmb_req_div.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_req_div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_req_div.Caption = "";
			this.cmb_req_div.CaptionHeight = 17;
			this.cmb_req_div.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_req_div.ColumnCaptionHeight = 18;
			this.cmb_req_div.ColumnFooterHeight = 18;
			this.cmb_req_div.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_req_div.ContentHeight = 17;
			this.cmb_req_div.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_req_div.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_req_div.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_req_div.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_req_div.EditorHeight = 17;
			this.cmb_req_div.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_req_div.GapHeight = 2;
			this.cmb_req_div.ItemHeight = 15;
			this.cmb_req_div.Location = new System.Drawing.Point(445, 58);
			this.cmb_req_div.MatchEntryTimeout = ((long)(2000));
			this.cmb_req_div.MaxDropDownItems = ((short)(5));
			this.cmb_req_div.MaxLength = 32767;
			this.cmb_req_div.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_req_div.Name = "cmb_req_div";
			this.cmb_req_div.PartialRightColumn = false;
			this.cmb_req_div.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_req_div.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_req_div.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_req_div.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_req_div.Size = new System.Drawing.Size(210, 21);
			this.cmb_req_div.TabIndex = 320;
			this.cmb_req_div.SelectedValueChanged += new System.EventHandler(this.cmb_req_div_SelectedValueChanged);
			// 
			// lbl_req_div
			// 
			this.lbl_req_div.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_req_div.ImageIndex = 0;
			this.lbl_req_div.ImageList = this.img_Label;
			this.lbl_req_div.Location = new System.Drawing.Point(344, 58);
			this.lbl_req_div.Name = "lbl_req_div";
			this.lbl_req_div.Size = new System.Drawing.Size(100, 21);
			this.lbl_req_div.TabIndex = 319;
			this.lbl_req_div.Text = "Request Div.";
			this.lbl_req_div.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_req_date
			// 
			this.lbl_req_date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_req_date.ImageIndex = 0;
			this.lbl_req_date.ImageList = this.img_Label;
			this.lbl_req_date.Location = new System.Drawing.Point(672, 36);
			this.lbl_req_date.Name = "lbl_req_date";
			this.lbl_req_date.Size = new System.Drawing.Size(100, 21);
			this.lbl_req_date.TabIndex = 313;
			this.lbl_req_date.Text = "Request Date";
			this.lbl_req_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_status
			// 
			this.lbl_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_status.ImageIndex = 0;
			this.lbl_status.ImageList = this.img_Label;
			this.lbl_status.Location = new System.Drawing.Point(344, 36);
			this.lbl_status.Name = "lbl_status";
			this.lbl_status.Size = new System.Drawing.Size(100, 21);
			this.lbl_status.TabIndex = 309;
			this.lbl_status.Text = "Status";
			this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_factory
			// 
			this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 1;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(16, 36);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 271;
			this.lbl_factory.Tag = "0";
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_title);
			this.pnl_SearchImage.Controls.Add(this.btn_openfile);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.pictureBox2);
			this.pnl_SearchImage.Controls.Add(this.pictureBox4);
			this.pnl_SearchImage.Controls.Add(this.pictureBox5);
			this.pnl_SearchImage.Controls.Add(this.pictureBox6);
			this.pnl_SearchImage.Controls.Add(this.pictureBox7);
			this.pnl_SearchImage.Controls.Add(this.pictureBox8);
			this.pnl_SearchImage.Controls.Add(this.pictureBox9);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 112);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// picb_TM
			// 
			this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
			this.picb_TM.Location = new System.Drawing.Point(219, 0);
			this.picb_TM.Name = "picb_TM";
			this.picb_TM.Size = new System.Drawing.Size(776, 32);
			this.picb_TM.TabIndex = 113;
			this.picb_TM.TabStop = false;
			// 
			// lbl_title
			// 
			this.lbl_title.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_title.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_title.ForeColor = System.Drawing.Color.Navy;
			this.lbl_title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_title.Image")));
			this.lbl_title.Location = new System.Drawing.Point(0, 0);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(231, 30);
			this.lbl_title.TabIndex = 28;
			this.lbl_title.Text = "      Request Information";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_openfile
			// 
			this.btn_openfile.BackColor = System.Drawing.SystemColors.Window;
			this.btn_openfile.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_openfile.Location = new System.Drawing.Point(426, 36);
			this.btn_openfile.Name = "btn_openfile";
			this.btn_openfile.Size = new System.Drawing.Size(21, 21);
			this.btn_openfile.TabIndex = 112;
			this.btn_openfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(983, 30);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(24, 69);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(984, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 32);
			this.pictureBox2.TabIndex = 21;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(984, 97);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(16, 16);
			this.pictureBox4.TabIndex = 23;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(144, 96);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(1000, 18);
			this.pictureBox5.TabIndex = 24;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 97);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(168, 20);
			this.pictureBox6.TabIndex = 22;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(0, 24);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(168, 79);
			this.pictureBox7.TabIndex = 25;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(150, 24);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(1000, 72);
			this.pictureBox8.TabIndex = 27;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(472, 72);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(1000, 72);
			this.pictureBox9.TabIndex = 27;
			this.pictureBox9.TabStop = false;
			// 
			// flg_out_req
			// 
			this.flg_out_req.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
			this.flg_out_req.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.flg_out_req.AutoResize = false;
			this.flg_out_req.BackColor = System.Drawing.SystemColors.Window;
			this.flg_out_req.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.flg_out_req.ColumnInfo = "10,1,0,0,0,90,Columns:";
			this.flg_out_req.ContextMenu = this.contextMenu1;
			this.flg_out_req.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.flg_out_req.ForeColor = System.Drawing.SystemColors.WindowText;
			this.flg_out_req.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
			this.flg_out_req.Location = new System.Drawing.Point(4, 200);
			this.flg_out_req.Name = "flg_out_req";
			this.flg_out_req.Rows.Fixed = 0;
			this.flg_out_req.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.flg_out_req.Size = new System.Drawing.Size(1008, 440);
			this.flg_out_req.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8.25pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.flg_out_req.TabIndex = 322;
			this.flg_out_req.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.flg_out_req_AfterEdit);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem1,
																						 this.menuItem2,
																						 this.menuItem3,
																						 this.menuItem4});
			this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "Material";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "BOM";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "-";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 3;
			this.menuItem4.Text = "Add Material";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// Form_Outgoing_req_list
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.flg_out_req);
			this.Controls.Add(this.pnl_Top);
			this.Name = "Form_Outgoing_req_list";
			this.Load += new System.EventHandler(this.Form_Outgoing_req_list_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.pnl_Top, 0);
			this.Controls.SetChildIndex(this.flg_out_req, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Top.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_scj_type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_req_status)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_req_no)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_req_div)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.flg_out_req)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_Outgoing_req_list_Load(object sender, System.EventArgs e)
		{
			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
			ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
			cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
			Init_Form();
		}

		private void Init_Form()
		{
			this.Text               = "Request Outgoing";
			this.lbl_MainTitle.Text = "Request Outgoing";
			ClassLib.ComFunction.SetLangDic(this);



	
			
			
			//Factory Setting 
//			DataTable dt_ret = COM.ComFunction.Select_Factory_List_CDC();
//			COM.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
//			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;



			DataTable dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), "SXP07");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_req_status, 1, 2, true, false);
			cmb_req_status.SelectedIndex = 0;
			
			
			
			dpk_req_date.Value = DateTime.Now;




			//pur master Status
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_OutRequest_Div);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_req_div, 1, 2, true, false);
			cmb_req_div.SelectedIndex = 2;
            cmb_req_div.Enabled = false;


			//get_req_no();


			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), "SXP13");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_scj_type, 1, 2, false, false);
			cmb_scj_type.SelectedIndex = 0;




			flg_out_req.Set_Grid_CDC("SXO_REQ_TAIL", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			flg_out_req.Set_Action_Image(img_Action);
			_RowFixed = flg_out_req.Rows.Count;
			flg_out_req.ExtendLastCol = false;
			flg_out_req.Tree.Column = (int)ClassLib.TBSXO_REQ_TAIL01.IxMAT_NAME;


			butten_control();


		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(tmp_req_no_detail != null)
			{

				tmp_req_status = cmb_req_status.SelectedIndex;
				tmp_req_no = cmb_req_no.SelectedIndex;
				tmp_req_div = cmb_req_div.SelectedIndex;
			}
			//			else
			//			{
			//				cmb_req_status.SelectedIndex = tmp_req_status;
			//				cmb_req_no.SelectedIndex = tmp_req_no;
			//				cmb_req_div.SelectedIndex = tmp_req_div;
			//			}

			contextMenu1.MenuItems[2].Visible = false;
			contextMenu1.MenuItems[3].Visible = false;
			tbtn_New.Enabled = false;




			
			flg_out_req.Select(flg_out_req.Selection.r1, 0, flg_out_req.Selection.r1, flg_out_req.Cols.Count-1, false);
			
			flg_out_req.Rows.Count = _RowFixed;





			string arg_factory = cmb_factory.SelectedValue.ToString();
			string arg_status = cmb_req_status.SelectedValue.ToString();
			string arg_req_ymd = dpk_req_date.Value.ToString("yyyyMMdd");
			string arg_req_div = cmb_req_div.SelectedValue.ToString();

			string arg_req_no = " ";

			try
			{
				arg_req_no = cmb_req_no.SelectedValue.ToString();
			}
			catch
			{
			}
			string arg_style_name = txt_style_name.Text.Trim().ToUpper();
			string arg_mat_name = txt_mat_name.Text.Trim().ToUpper();
			string arg_srf_no = txt_srf_no.Text.Trim();
			string arg_sct_mode = cmb_scj_type.SelectedValue.ToString();


			
				DataTable dt =  Search_pur_order(arg_factory,arg_status ,arg_req_ymd, arg_req_div, arg_req_no, arg_style_name, arg_mat_name, arg_srf_no,arg_sct_mode);


				int dt_rows = dt.Rows.Count;
				int dt_cols = dt.Columns.Count;

			
				if(dt_rows > 0)
				{
					if(arg_sct_mode.Equals("M"))
					{
						for(int i = 0; i<dt_rows; i++)
						{
							int t_level = int.Parse(dt.Rows[i].ItemArray[(int)ClassLib.TBSXO_REQ_TAIL01.IxT_LEVEL].ToString());
							flg_out_req.Rows.InsertNode(flg_out_req.Rows.Count, t_level);



							for(int j=0; j<dt_cols; j++)
							{
								flg_out_req[flg_out_req.Rows.Count-1, j] = dt.Rows[i].ItemArray[j].ToString();

								if(j==(int)ClassLib.TBSXO_REQ_TAIL01.IxT_LEVEL)
								{
									if(!dt.Rows[i].ItemArray[j].ToString().Equals("0"))
									{
										flg_out_req.Rows[flg_out_req.Rows.Count-1].AllowEditing = false;
										flg_out_req.Rows[flg_out_req.Rows.Count-1].StyleNew.BackColor =  Color.Bisque;
									}


									if(dt.Rows[i].ItemArray[j].ToString().Equals("0") && dt.Rows[i].ItemArray[(int)ClassLib.TBSXO_REQ_TAIL01.IxSTATUS].ToString().Equals("C"))
									{
										flg_out_req.Rows[flg_out_req.Rows.Count-1].AllowEditing = false;
									}
								}	
							}
						}
					}
					else
					{
						for(int i = 0; i<dt_rows; i++)
						{
							int t_level = int.Parse(dt.Rows[i].ItemArray[(int)ClassLib.TBSXO_REQ_TAIL02.IxT_LEVEL].ToString());
							flg_out_req.Rows.InsertNode(flg_out_req.Rows.Count, t_level);



							for(int j=0; j<dt_cols; j++)
							{
								flg_out_req[flg_out_req.Rows.Count-1, j] = dt.Rows[i].ItemArray[j].ToString();

								if(j==(int)ClassLib.TBSXO_REQ_TAIL02.IxT_LEVEL)
								{
									if(!dt.Rows[i].ItemArray[j].ToString().Equals("0"))
									{
										flg_out_req.Rows[flg_out_req.Rows.Count-1].AllowEditing = false;
										flg_out_req.Rows[flg_out_req.Rows.Count-1].StyleNew.BackColor =  Color.Bisque;
									}


									if(dt.Rows[i].ItemArray[j].ToString().Equals("0") && dt.Rows[i].ItemArray[(int)ClassLib.TBSXO_REQ_TAIL01.IxSTATUS].ToString().Equals("C"))
									{
										flg_out_req.Rows[flg_out_req.Rows.Count-1].AllowEditing = false;
									}
								}	
							}
						}
					}

					flg_out_req.Tree.Show(show_lev);
				}
			
		
		}

		private DataTable Search_pur_order(string arg_factory, string arg_status, string arg_req_ymd, string arg_req_div, string arg_req_no, string arg_style_name, string arg_mat_name, string arg_srf_no, string arg_sct_mode)
		{

			DataSet ds_Search ; 

			OraDB.ReDim_Parameter(10);

			//01.PROCEDURE명
			OraDB.Process_Name = "pkg_sxo_out_01_select.select_req" ; 

			//02.ARGURMENT명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_STATUS";
			OraDB.Parameter_Name[2] = "ARG_REQ_YMD";
			OraDB.Parameter_Name[3] = "ARG_REQ_DIV";
			OraDB.Parameter_Name[4] = "ARG_REQ_NO";
			OraDB.Parameter_Name[5] = "ARG_STYLE_NAME";
			OraDB.Parameter_Name[6] = "ARG_MAT_NAME";
			OraDB.Parameter_Name[7] = "ARG_SRF_NO";
			OraDB.Parameter_Name[8] = "ARG_SCT_MODE";
			OraDB.Parameter_Name[9] = "OUT_CURSOR";

			//03. DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[8] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[9] = (int)OracleType.Cursor; 

			//04. DATA 정의
			OraDB.Parameter_Values[0] = arg_factory;
			OraDB.Parameter_Values[1] = arg_status;
			OraDB.Parameter_Values[2] = arg_req_ymd;
			OraDB.Parameter_Values[3] = arg_req_div;
			OraDB.Parameter_Values[4] = arg_req_no;
			OraDB.Parameter_Values[5] = arg_style_name;
			OraDB.Parameter_Values[6] = arg_mat_name;
			OraDB.Parameter_Values[7] = arg_srf_no;
			OraDB.Parameter_Values[8] = arg_sct_mode;
			OraDB.Parameter_Values[9] = "";




			OraDB.Add_Select_Parameter(true);
			ds_Search = OraDB.Exe_Select_Procedure();	

			return ds_Search.Tables[OraDB.Process_Name];

		}

		private void flg_out_req_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			int sct_row = flg_out_req.Selection.r1;
			int sct_col = flg_out_req.Selection.c1;
			flg_out_req.Update_Row(sct_row);
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
//			tmp_req_status = cmb_req_status.SelectedIndex;
//			tmp_req_no = cmb_req_no.SelectedIndex;
//			tmp_req_div = cmb_req_div.SelectedIndex;
//			create_mode(false);

			contextMenu1.MenuItems[2].Visible = false;
			contextMenu1.MenuItems[3].Visible = false;

			for(int i = _RowFixed; i<flg_out_req.Rows.Count; i++)
			{
				if(flg_out_req[i,(int)ClassLib.TBSXO_REQ_TAIL01.IxDIVISION].ToString().Trim().Length>0)
				{
					string arg_division = flg_out_req[i,(int)ClassLib.TBSXO_REQ_TAIL01.IxDIVISION].ToString();

					

					string arg_factory = cmb_factory.SelectedValue.ToString();
					string arg_req_ymd = dpk_req_date.Value.ToString("yyyyMMdd");
					string arg_req_div = cmb_req_div.SelectedValue.ToString();
					string arg_req_no = null;
					string arg_mat_cd = null;
					string arg_spec_cd = null;
					string arg_color_cd = null;
					string arg_unit_cd = null;
					string arg_value = null;
					string arg_remarks = null;


					if(tmp_req_no_detail != null)
					{
						arg_req_div = cmb_req_div.SelectedValue.ToString();
						arg_req_no = tmp_req_no_detail;
						arg_mat_cd  = flg_out_req[i,(int)ClassLib.TBSXO_REQ_TAIL01.IxMAT_CD].ToString();
						arg_spec_cd = flg_out_req[i,(int)ClassLib.TBSXO_REQ_TAIL01.IxPCC_SPEC_CD].ToString();
						arg_color_cd = flg_out_req[i,(int)ClassLib.TBSXO_REQ_TAIL01.IxCOLOR_CD].ToString();
						arg_unit_cd = flg_out_req[i,(int)ClassLib.TBSXO_REQ_TAIL01.IxPCC_UNIT_NAME].ToString();
						arg_value = flg_out_req[i,(int)ClassLib.TBSXO_REQ_TAIL01.IxVALUE].ToString();
						//string arg_mcs_cd = "";
					}
					else
					{
						arg_factory = flg_out_req[i,(int)ClassLib.TBSXO_REQ_TAIL01.IxFACTORY].ToString();
						arg_req_ymd = flg_out_req[i,(int)ClassLib.TBSXO_REQ_TAIL01.IxREQ_YMD].ToString();
						arg_req_div = flg_out_req[i,(int)ClassLib.TBSXO_REQ_TAIL01.IxREQ_DIV_V].ToString();
						arg_req_no = flg_out_req[i,(int)ClassLib.TBSXO_REQ_TAIL01.IXREQ_NO].ToString();
						arg_mat_cd  = flg_out_req[i,(int)ClassLib.TBSXO_REQ_TAIL01.IxMAT_CD].ToString();
						arg_spec_cd = flg_out_req[i,(int)ClassLib.TBSXO_REQ_TAIL01.IxPCC_SPEC_CD].ToString();
						arg_color_cd = flg_out_req[i,(int)ClassLib.TBSXO_REQ_TAIL01.IxCOLOR_CD].ToString();
						arg_unit_cd = flg_out_req[i,(int)ClassLib.TBSXO_REQ_TAIL01.IxPCC_UNIT_NAME].ToString();
						arg_value = flg_out_req[i,(int)ClassLib.TBSXO_REQ_TAIL01.IxVALUE].ToString();
						//string arg_mcs_cd = "";
					}

					arg_remarks = flg_out_req[i,(int)ClassLib.TBSXO_REQ_TAIL01.IxREMARKS].ToString();



					




					save_req_tail(arg_division, arg_factory, arg_req_ymd, arg_req_div, arg_req_no, arg_mat_cd, arg_spec_cd, arg_color_cd,arg_unit_cd, arg_value, arg_remarks);
				}
			}

			int x_point = flg_out_req.ScrollPosition.X;
			int y_point = flg_out_req.ScrollPosition.Y;


			if(tmp_req_no_detail != null)
			{
				get_req_no(tmp_req_no_detail);
				tmp_req_no_detail = null;
			}



			tbtn_Search_Click(null, null);

			flg_out_req.ScrollPosition = new Point(x_point, y_point);
		}


		private void save_req_tail(string arg_division, string arg_factory, string arg_req_ymd, string arg_req_div, string arg_req_no, string arg_mat_cd, string arg_spec_cd, string arg_clor_cd, string arg_unit_cd, string arg_value, string arg_remarks)
		{

			string Proc_Name = "pkg_sxo_out_01.UPDATE_SXO_REQ";

			OraDB.ReDim_Parameter(12);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "ARG_DIVISION"; 
			OraDB.Parameter_Name[1] = "ARG_FACTORY";        
			OraDB.Parameter_Name[2] = "ARG_REQ_YMD";
			OraDB.Parameter_Name[3] = "ARG_REQ_DIV";
			OraDB.Parameter_Name[4] = "ARG_REQ_NO"; 
			OraDB.Parameter_Name[5] = "ARG_MAT_CD";        
			OraDB.Parameter_Name[6] = "ARG_SPEC_CD";
			OraDB.Parameter_Name[7] = "ARG_COLOR_CD";
			OraDB.Parameter_Name[8] = "ARG_UNIT_CD";
			OraDB.Parameter_Name[9] = "ARG_VALUE";     
			OraDB.Parameter_Name[10] = "ARG_REMARKS";     
			OraDB.Parameter_Name[11] = "ARG_UPD_USER";  


			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[8] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[9] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[10] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[11] = (int)OracleType.VarChar;

			OraDB.Parameter_Values[0] = arg_division;
			OraDB.Parameter_Values[1] = arg_factory;
			OraDB.Parameter_Values[2] = arg_req_ymd;
			OraDB.Parameter_Values[3] = arg_req_div;
			OraDB.Parameter_Values[4] = arg_req_no;
			OraDB.Parameter_Values[5] = arg_mat_cd;
			OraDB.Parameter_Values[6] = arg_spec_cd;
			OraDB.Parameter_Values[7] = arg_clor_cd;
			OraDB.Parameter_Values[8] = arg_unit_cd;
			OraDB.Parameter_Values[9] = arg_value;
			OraDB.Parameter_Values[10] = arg_remarks;
			OraDB.Parameter_Values[11] = ClassLib.ComVar.This_User;

			OraDB.Add_Modify_Parameter(true);
			OraDB.Exe_Modify_Procedure();
		}


		private DataTable Search_req_no(string arg_factory, string arg_req_ymd, string arg_req_div)
		{

			DataSet ds_Search ; 

			OraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			OraDB.Process_Name = "pkg_sxo_out_01_select.SELECT_REQ_NO" ; 

			//02.ARGURMENT명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_REQ_YMD";
			OraDB.Parameter_Name[2] = "ARG_REQ_DIV";
			OraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03. DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor; 

			//04. DATA 정의
			OraDB.Parameter_Values[0] = arg_factory;
			OraDB.Parameter_Values[1] = arg_req_ymd;
			OraDB.Parameter_Values[2] = arg_req_div;
			OraDB.Parameter_Values[3] = "";




			OraDB.Add_Select_Parameter(true);
			ds_Search = OraDB.Exe_Select_Procedure();	

			return ds_Search.Tables[OraDB.Process_Name];

		}

		private void dpk_req_date_CloseUp(object sender, System.EventArgs e)
		{
			get_req_no();
		}

		private void cmb_req_div_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_req_div.SelectedIndex == -1) return;

            butten_control();

            get_req_no();
		}


		private void get_req_no()
		{
			DataTable dt_ret = Search_req_no(cmb_factory.SelectedValue.ToString(), dpk_req_date.Value.ToString("yyyyMMdd"), cmb_req_div.SelectedValue.ToString());
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_req_no, 0, 0, true, false);
			cmb_req_no.SelectedIndex = 0;
		}

		private void get_req_no(string arg_req_no)
		{
			DataTable dt_ret = Search_req_no(cmb_factory.SelectedValue.ToString(), dpk_req_date.Value.ToString("yyyyMMdd"), cmb_req_div.SelectedValue.ToString());
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_req_no, 0, 0, true, false);
			cmb_req_no.SelectedValue = arg_req_no;
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			create_mode();
			menuItem4_Click(null, null);
		}


		private void create_mode()
		{
			if(tmp_req_no_detail == null)
			{
				tmp_req_status = cmb_req_status.SelectedIndex;
				tmp_req_no = cmb_req_no.SelectedIndex;
				tmp_req_div = cmb_req_div.SelectedIndex;


				cmb_req_status.SelectedIndex = 1; // 상태를 R로 바꾼다.
				cmb_req_no.SelectedIndex = -1; //새로운 req_no를 따기 위한 대기 상태
				tmp_req_no_detail  = create_req_no(cmb_factory.SelectedValue.ToString(), dpk_req_date.Value.ToString("yyyyMMdd")).Rows[0].ItemArray[0].ToString();
				cmb_req_div.SelectedIndex = 2; //U로 바꾼다.

				contextMenu1.MenuItems[2].Visible = true;
				contextMenu1.MenuItems[3].Visible = true;

				tbtn_New.Enabled = false;

				flg_out_req.Rows.Count = _RowFixed;
			}
			else
			{
				tmp_req_no_detail = null;
				cmb_req_status.SelectedIndex = tmp_req_status;
				cmb_req_no.SelectedIndex = tmp_req_no;
				cmb_req_div.SelectedIndex = tmp_req_div;

				contextMenu1.MenuItems[2].Visible = false;
				contextMenu1.MenuItems[3].Visible = false;
			}
		}


		private void get_req_data(string arg_factory, string arg_req_ymd)
		{

			string Proc_Name = "pkg_sxo_out_01.SAVE_SXO_REQ";

			OraDB.ReDim_Parameter(3);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";        
			OraDB.Parameter_Name[1] = "ARG_REQ_YMD";
			OraDB.Parameter_Name[2] = "ARG_UPD_USER";  


			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;

			OraDB.Parameter_Values[0] = arg_factory;
			OraDB.Parameter_Values[1] = arg_req_ymd;
			OraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;

			OraDB.Add_Modify_Parameter(true);
			OraDB.Exe_Modify_Procedure();
		}

		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			contextMenu1.MenuItems[2].Visible = false;
			contextMenu1.MenuItems[3].Visible = false;
			confirm_req_data(cmb_factory.SelectedValue.ToString(), dpk_req_date.Value.ToString("yyyyMMdd"), cmb_req_no.SelectedValue.ToString());
			tbtn_Search_Click(null, null);


		}

		private void confirm_req_data(string arg_factory, string arg_req_ymd, string arg_req_no)
		{

			string Proc_Name = "pkg_sxo_out_01.CONFIRM_PROD_REQ_01";

			OraDB.ReDim_Parameter(4);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";        
			OraDB.Parameter_Name[1] = "ARG_REQ_YMD";
            OraDB.Parameter_Name[2] = "ARG_REQ_NO";
			OraDB.Parameter_Name[3] = "ARG_UPD_USER";  


			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;

			OraDB.Parameter_Values[0] = arg_factory;
			OraDB.Parameter_Values[1] = arg_req_ymd;
            OraDB.Parameter_Values[2] = arg_req_no;
			OraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;

			OraDB.Add_Modify_Parameter(true);
			OraDB.Exe_Modify_Procedure();
		}

		private void cmb_req_no_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_req_no.SelectedIndex == -1) return;
			//get_req_status();

            butten_control();


		}

		private void get_req_status()
		{
//			DataTable dt_ret = Search_req_status(cmb_factory.SelectedValue.ToString(), cmb_req_no.SelectedValue.ToString());
//			if(dt_ret.Rows.Count > 0)
//			{
//				cmb.Text = dt_ret.Rows[0].ItemArray[0].ToString();
//			}
//			else
//			{
//				txt_status.Text = "";
//			}
		}

		private DataTable Search_req_status(string arg_factory, string arg_req_no)
		{

			DataSet ds_Search ; 

			OraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			OraDB.Process_Name = "pkg_sxo_out_01_select.SELECT_REQ_STATUS" ; 

			//02.ARGURMENT명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_REQ_NO";
			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03. DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor; 

			//04. DATA 정의
			OraDB.Parameter_Values[0] = arg_factory;
			OraDB.Parameter_Values[1] = arg_req_no;
			OraDB.Parameter_Values[2] = "";




			OraDB.Add_Select_Parameter(true);
			ds_Search = OraDB.Exe_Select_Procedure();	

			return ds_Search.Tables[OraDB.Process_Name];

		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			show_lev = 0;
			flg_out_req.Tree.Show(show_lev);
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			show_lev = 1;
			flg_out_req.Tree.Show(show_lev);
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			try
			{
//				if(create_mode)
//				{
//
//					cmb_req_status.SelectedIndex = 1; // 상태를 R로 바꾼다.
//					cmb_req_no.SelectedIndex = -1; //새로운 req_no를 따기 위한 대기 상태
//					cmb_req_div.SelectedIndex = 2; //U로 바꾼다.
//
//					flg_out_req.Rows.Count = _RowFixed;
//				}




				int t_level = 0;
				flg_out_req.Rows.InsertNode(_RowFixed, t_level);
				



				int sct_row = _RowFixed;

				for(int i=0; i<flg_out_req.Cols.Count; i++)
				{
					flg_out_req[sct_row, i] = " ";
				}

				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxDIVISION] = "I";
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxREQ_YMD] = dpk_req_date.Value.ToString("yyyyMMdd");
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxFACTORY] = cmb_factory.SelectedValue.ToString();
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxT_LEVEL] = "0";
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxREQ_YMD_V] = dpk_req_date.Value.ToString("yyyyMMdd");
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxREQ_DIV] = "U";

				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxVALUE] = "0";
//
//
//
//
//
//
//				//sct_row = sct_row+1;
//
//
//
				int vCount = 16;
				COM.ComVar.Parameter_PopUp = new string[vCount];

				COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxFACTORY -1] = cmb_factory.SelectedValue.ToString();

				//COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_SEQ -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPART_SEQ].ToString();
				//COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_TYPE -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPART_TYPE].ToString();
				//COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_DESC -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPART_DESC].ToString();

				COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxMAT_CD].ToString();

				COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxMAT_COMMENT].ToString();
				COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxMAT_NAME].ToString();
					
					
					


				COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxCOLOR_CD].ToString();
				COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxCOLOR_NAME].ToString();
				//COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_COMMENT -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxCOLOR_COMMENT].ToString();


				COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPCC_SPEC_CD].ToString();
				COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPCC_SPEC_NAME].ToString();


				//COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMCS_CD -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxMCS_CD].ToString();
				COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPCC_UNIT_NAME].ToString();


				BaseInfo.Pop_Material_Master codeMaster = new FlexCDC.BaseInfo.Pop_Material_Master();
				codeMaster.ShowDialog();


				if(!flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxDIVISION].ToString().Equals("I"))
				{

					flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxDIVISION] = "U";
				}

				//flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPART_SEQ] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_SEQ -1];
				//flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPART_TYPE] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_TYPE -1];
				//flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPART_DESC]= COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_DESC -1];
					
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxMAT_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD -1];
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxMAT_COMMENT] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT -1];
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxMAT_NAME] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME -1];
					
					
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxCOLOR_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD -1];
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxCOLOR_NAME] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC -1];
				//flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxCOLOR_COMMENT] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_COMMENT -1];
					
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPCC_SPEC_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD -1];
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPCC_SPEC_NAME] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME -1];
					
				//flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxMCS_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMCS_CD -1];
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPCC_UNIT_NAME] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD -1];


			}
			catch
			{

			}
		}

		private DataTable create_req_no(string arg_factory, string arg_req_ymd)
		{

			DataSet ds_Search ; 

			OraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SXO_OUT_01_SELECT.GET_REQ_NO" ; 

			//02.ARGURMENT명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_REQ_YMD";
			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03. DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor; 

			//04. DATA 정의
			OraDB.Parameter_Values[0] = arg_factory;
			OraDB.Parameter_Values[1] = arg_req_ymd;
			OraDB.Parameter_Values[2] = "";




			OraDB.Add_Select_Parameter(true);
			ds_Search = OraDB.Exe_Select_Procedure();	

			return ds_Search.Tables[OraDB.Process_Name];

		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			try
			{


				int t_level = 0;
				flg_out_req.Rows.InsertNode(_RowFixed, t_level);
				



				int sct_row = _RowFixed;

				for(int i=0; i<flg_out_req.Cols.Count; i++)
				{
					flg_out_req[sct_row, i] = " ";
				}

				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxDIVISION] = "I";
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxREQ_YMD] = dpk_req_date.Value.ToString("yyyyMMdd");
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxFACTORY] = cmb_factory.SelectedValue.ToString();
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxT_LEVEL] = "0";
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxREQ_YMD_V] = dpk_req_date.Value.ToString("yyyyMMdd");
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxREQ_DIV] = "N";

				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxVALUE] = "0";
				//
				//
				//
				//
				//
				//
				//				//sct_row = sct_row+1;
				//
				//
				//
				int vCount = 16;
				COM.ComVar.Parameter_PopUp = new string[vCount];

				COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxFACTORY -1] = cmb_factory.SelectedValue.ToString();

				//COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_SEQ -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPART_SEQ].ToString();
				//COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_TYPE -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPART_TYPE].ToString();
				//COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_DESC -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPART_DESC].ToString();

				COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxMAT_CD].ToString();

				COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxMAT_COMMENT].ToString();
				COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxMAT_NAME].ToString();
					
					
					


				COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxCOLOR_CD].ToString();
				COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxCOLOR_NAME].ToString();
				//COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_COMMENT -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxCOLOR_COMMENT].ToString();


				COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPCC_SPEC_CD].ToString();
				COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPCC_SPEC_NAME].ToString();


				//COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMCS_CD -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxMCS_CD].ToString();
				COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD -1] = flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPCC_UNIT_NAME].ToString();


				BaseInfo.Pop_Material_Master codeMaster = new FlexCDC.BaseInfo.Pop_Material_Master();
				codeMaster.ShowDialog();


				if(!flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxDIVISION].ToString().Equals("I"))
				{

					flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxDIVISION] = "U";
				}

				//flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPART_SEQ] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_SEQ -1];
				//flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPART_TYPE] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_TYPE -1];
				//flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPART_DESC]= COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_DESC -1];
					
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxMAT_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD -1];
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxMAT_COMMENT] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT -1];
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxMAT_NAME] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME -1];
					
					
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxCOLOR_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD -1];
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxCOLOR_NAME] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC -1];
				//flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxCOLOR_COMMENT] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_COMMENT -1];
					
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPCC_SPEC_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD -1];
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPCC_SPEC_NAME] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME -1];
					
				//flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxMCS_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMCS_CD -1];
				flg_out_req[sct_row, (int)ClassLib.TBSXO_REQ_TAIL01.IxPCC_UNIT_NAME] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD -1];


			}
			catch
			{

			}
		}

		private void tbtn_Create_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
//			tmp_req_status = cmb_req_status.SelectedIndex;
//			tmp_req_no = cmb_req_no.SelectedIndex;
//			tmp_req_div = cmb_req_div.SelectedIndex;
//			create_mode(false);

			contextMenu1.MenuItems[2].Visible = false;
			contextMenu1.MenuItems[3].Visible = false;


			get_req_data(cmb_factory.SelectedValue.ToString(), dpk_req_date.Value.ToString("yyyyMMdd"));
			
			get_req_no();
			tbtn_Search_Click(null, null);
		}

		private void butten_control()
		{


            if (cmb_req_status.SelectedIndex.Equals(0))//상태 값이 ALL 일때만 데이터 수정 가능
            {
                if (cmb_req_no.SelectedIndex > 1 && cmb_req_div.SelectedIndex.Equals(2)/*U일때*/)
                {
                    tbtn_New.Enabled = true;
                    tbtn_Create.Enabled = true;
                    tbtn_Save.Enabled = true;
                    tbtn_Confirm.Enabled = false;
                }
                else
                {
                    tbtn_New.Enabled = false;
                    tbtn_Create.Enabled = false;
                    tbtn_Save.Enabled = false;
                    tbtn_Confirm.Enabled = false;
                }
            }
            else
            {
                tbtn_New.Enabled = false;
                tbtn_Create.Enabled = false;
                tbtn_Save.Enabled = false;
                tbtn_Confirm.Enabled = false;
            }

            tbtn_Create.Enabled = false;
            tbtn_Delete.Enabled = false;
		}

		private void cmb_req_status_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_req_status.SelectedIndex == -1)return;

			butten_control();
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_factory.SelectedIndex == -1) return;
			COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
			Init_Form();
		}

		private void contextMenu1_Popup(object sender, System.EventArgs e)
		{
		
		}

		private void cmb_scj_type_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_scj_type.SelectedIndex.Equals(-1))
			{
				return;
			}
			else if(cmb_scj_type.SelectedIndex.Equals(0))
			{
				flg_out_req.Set_Grid_CDC("SXO_REQ_TAIL", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				flg_out_req.Set_Action_Image(img_Action);
				_RowFixed = flg_out_req.Rows.Count;
				flg_out_req.ExtendLastCol = false;
				flg_out_req.Tree.Column = (int)ClassLib.TBSXO_REQ_TAIL01.IxMAT_NAME;
			}
			else if(cmb_scj_type.SelectedIndex.Equals(1))
			{
				flg_out_req.Set_Grid_CDC("SXO_REQ_TAIL", "3", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				flg_out_req.Set_Action_Image(img_Action);
				_RowFixed = flg_out_req.Rows.Count;
				flg_out_req.ExtendLastCol = false;
				flg_out_req.Tree.Column = (int)ClassLib.TBSXO_REQ_TAIL02.IxLOT_SEQ_V;
			}

		}
	}
}

