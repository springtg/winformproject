using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using System.Reflection;
using C1.Win.C1FlexGrid;
namespace FlexCDC.Purchase
{
	public class Form_Pur_manager : COM.PCHWinForm.Form_Top
	{
		
		#region 컨트롤정의 및 리소스 정의 
		public System.Windows.Forms.Panel pnl_Top;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_hp;
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
		public COM.FSP flg_pur_manager;
		private System.ComponentModel.IContainer components = null;
		private COM.OraDB MyOraDB = new COM.OraDB();
		private C1.Win.C1List.C1Combo cmb_status;
		private C1.Win.C1List.C1Combo cmb_pur_user;
		private System.Windows.Forms.DateTimePicker dpk_get_from;
		private System.Windows.Forms.Label lbl_pur_user;
		private System.Windows.Forms.Label lbl_data_type;
		public C1.Win.C1List.C1Combo cmb_data_type;
		private System.Windows.Forms.DateTimePicker dpk_get_to;
		private System.Windows.Forms.Label lbl_get_date;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.TextBox txt_mat_name;
		public C1.Win.C1List.C1Combo cmb_pur_div;
		private System.Windows.Forms.Label lbl_pur_div;
		private System.Windows.Forms.ContextMenu contextMenu;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.TextBox txt_style_name;
		private System.Windows.Forms.MenuItem cmt_Material;
		private System.Windows.Forms.Label lbl_material;
		private System.Windows.Forms.MenuItem cmt_User;
		private System.Windows.Forms.MenuItem cmt_Bar1;
		private System.Windows.Forms.Label lbl_style_name;
		
		

		public Form_Pur_manager()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Pur_manager));
			this.pnl_Top = new System.Windows.Forms.Panel();
			this.txt_mat_name = new System.Windows.Forms.TextBox();
			this.txt_style_name = new System.Windows.Forms.TextBox();
			this.cmb_status = new C1.Win.C1List.C1Combo();
			this.cmb_pur_user = new C1.Win.C1List.C1Combo();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_material = new System.Windows.Forms.Label();
			this.lbl_style_name = new System.Windows.Forms.Label();
			this.dpk_get_from = new System.Windows.Forms.DateTimePicker();
			this.lbl_pur_user = new System.Windows.Forms.Label();
			this.lbl_data_type = new System.Windows.Forms.Label();
			this.cmb_pur_div = new C1.Win.C1List.C1Combo();
			this.lbl_pur_div = new System.Windows.Forms.Label();
			this.cmb_data_type = new C1.Win.C1List.C1Combo();
			this.lbl_hp = new System.Windows.Forms.Label();
			this.dpk_get_to = new System.Windows.Forms.DateTimePicker();
			this.lbl_get_date = new System.Windows.Forms.Label();
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
			this.flg_pur_manager = new COM.FSP();
			this.contextMenu = new System.Windows.Forms.ContextMenu();
			this.cmt_Material = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.cmt_Bar1 = new System.Windows.Forms.MenuItem();
			this.cmt_User = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Top.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_status)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_pur_user)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_pur_div)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_data_type)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.flg_pur_manager)).BeginInit();
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
			this.pnl_Top.Controls.Add(this.txt_mat_name);
			this.pnl_Top.Controls.Add(this.txt_style_name);
			this.pnl_Top.Controls.Add(this.cmb_status);
			this.pnl_Top.Controls.Add(this.cmb_pur_user);
			this.pnl_Top.Controls.Add(this.cmb_Factory);
			this.pnl_Top.Controls.Add(this.lbl_material);
			this.pnl_Top.Controls.Add(this.lbl_style_name);
			this.pnl_Top.Controls.Add(this.dpk_get_from);
			this.pnl_Top.Controls.Add(this.lbl_pur_user);
			this.pnl_Top.Controls.Add(this.lbl_data_type);
			this.pnl_Top.Controls.Add(this.cmb_pur_div);
			this.pnl_Top.Controls.Add(this.lbl_pur_div);
			this.pnl_Top.Controls.Add(this.cmb_data_type);
			this.pnl_Top.Controls.Add(this.lbl_hp);
			this.pnl_Top.Controls.Add(this.dpk_get_to);
			this.pnl_Top.Controls.Add(this.lbl_get_date);
			this.pnl_Top.Controls.Add(this.lbl_status);
			this.pnl_Top.Controls.Add(this.lbl_factory);
			this.pnl_Top.Controls.Add(this.pnl_SearchImage);
			this.pnl_Top.DockPadding.Bottom = 8;
			this.pnl_Top.DockPadding.Left = 8;
			this.pnl_Top.DockPadding.Right = 8;
			this.pnl_Top.Location = new System.Drawing.Point(0, 80);
			this.pnl_Top.Name = "pnl_Top";
			this.pnl_Top.Size = new System.Drawing.Size(1016, 120);
			this.pnl_Top.TabIndex = 136;
			// 
			// txt_mat_name
			// 
			this.txt_mat_name.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_mat_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_mat_name.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_mat_name.ForeColor = System.Drawing.Color.Black;
			this.txt_mat_name.Location = new System.Drawing.Point(445, 80);
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
			// cmb_status
			// 
			this.cmb_status.AddItemCols = 0;
			this.cmb_status.AddItemSeparator = ';';
			this.cmb_status.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_status.Caption = "";
			this.cmb_status.CaptionHeight = 17;
			this.cmb_status.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_status.ColumnCaptionHeight = 18;
			this.cmb_status.ColumnFooterHeight = 18;
			this.cmb_status.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_status.ContentHeight = 17;
			this.cmb_status.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_status.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_status.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_status.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_status.EditorHeight = 17;
			this.cmb_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_status.GapHeight = 2;
			this.cmb_status.ItemHeight = 15;
			this.cmb_status.Location = new System.Drawing.Point(117, 58);
			this.cmb_status.MatchEntryTimeout = ((long)(2000));
			this.cmb_status.MaxDropDownItems = ((short)(5));
			this.cmb_status.MaxLength = 32767;
			this.cmb_status.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_status.Name = "cmb_status";
			this.cmb_status.PartialRightColumn = false;
			this.cmb_status.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_status.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_status.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_status.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_status.Size = new System.Drawing.Size(211, 21);
			this.cmb_status.TabIndex = 352;
			this.cmb_status.SelectedValueChanged += new System.EventHandler(this.cmb_status_SelectedValueChanged);
			// 
			// cmb_pur_user
			// 
			this.cmb_pur_user.AddItemCols = 0;
			this.cmb_pur_user.AddItemSeparator = ';';
			this.cmb_pur_user.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_pur_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_pur_user.Caption = "";
			this.cmb_pur_user.CaptionHeight = 17;
			this.cmb_pur_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_pur_user.ColumnCaptionHeight = 18;
			this.cmb_pur_user.ColumnFooterHeight = 18;
			this.cmb_pur_user.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_pur_user.ContentHeight = 17;
			this.cmb_pur_user.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_pur_user.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_pur_user.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_pur_user.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_pur_user.EditorHeight = 17;
			this.cmb_pur_user.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_pur_user.GapHeight = 2;
			this.cmb_pur_user.ItemHeight = 15;
			this.cmb_pur_user.Location = new System.Drawing.Point(773, 36);
			this.cmb_pur_user.MatchEntryTimeout = ((long)(2000));
			this.cmb_pur_user.MaxDropDownItems = ((short)(5));
			this.cmb_pur_user.MaxLength = 32767;
			this.cmb_pur_user.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_pur_user.Name = "cmb_pur_user";
			this.cmb_pur_user.PartialRightColumn = false;
			this.cmb_pur_user.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_pur_user.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_pur_user.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_pur_user.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_pur_user.Size = new System.Drawing.Size(211, 21);
			this.cmb_pur_user.TabIndex = 351;
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
			this.cmb_Factory.ContentHeight = 17;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(117, 36);
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
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(211, 21);
			this.cmb_Factory.TabIndex = 350;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_material
			// 
			this.lbl_material.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_material.ImageIndex = 0;
			this.lbl_material.ImageList = this.img_Label;
			this.lbl_material.Location = new System.Drawing.Point(344, 80);
			this.lbl_material.Name = "lbl_material";
			this.lbl_material.Size = new System.Drawing.Size(100, 21);
			this.lbl_material.TabIndex = 327;
			this.lbl_material.Text = "Material";
			this.lbl_material.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.lbl_style_name.Text = "Style";
			this.lbl_style_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpk_get_from
			// 
			this.dpk_get_from.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpk_get_from.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpk_get_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpk_get_from.Location = new System.Drawing.Point(445, 35);
			this.dpk_get_from.Name = "dpk_get_from";
			this.dpk_get_from.Size = new System.Drawing.Size(100, 22);
			this.dpk_get_from.TabIndex = 324;
			this.dpk_get_from.Value = new System.DateTime(2007, 11, 19, 14, 18, 56, 968);
			// 
			// lbl_pur_user
			// 
			this.lbl_pur_user.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_pur_user.ImageIndex = 0;
			this.lbl_pur_user.ImageList = this.img_Label;
			this.lbl_pur_user.Location = new System.Drawing.Point(672, 36);
			this.lbl_pur_user.Name = "lbl_pur_user";
			this.lbl_pur_user.Size = new System.Drawing.Size(100, 21);
			this.lbl_pur_user.TabIndex = 322;
			this.lbl_pur_user.Text = "User";
			this.lbl_pur_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_data_type
			// 
			this.lbl_data_type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_data_type.ImageIndex = 0;
			this.lbl_data_type.ImageList = this.img_Label;
			this.lbl_data_type.Location = new System.Drawing.Point(344, 58);
			this.lbl_data_type.Name = "lbl_data_type";
			this.lbl_data_type.Size = new System.Drawing.Size(100, 21);
			this.lbl_data_type.TabIndex = 321;
			this.lbl_data_type.Text = "Type";
			this.lbl_data_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_pur_div
			// 
			this.cmb_pur_div.AddItemCols = 0;
			this.cmb_pur_div.AddItemSeparator = ';';
			this.cmb_pur_div.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_pur_div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_pur_div.Caption = "";
			this.cmb_pur_div.CaptionHeight = 17;
			this.cmb_pur_div.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_pur_div.ColumnCaptionHeight = 18;
			this.cmb_pur_div.ColumnFooterHeight = 18;
			this.cmb_pur_div.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_pur_div.ContentHeight = 17;
			this.cmb_pur_div.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_pur_div.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_pur_div.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_pur_div.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_pur_div.EditorHeight = 17;
			this.cmb_pur_div.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_pur_div.GapHeight = 2;
			this.cmb_pur_div.ItemHeight = 15;
			this.cmb_pur_div.Location = new System.Drawing.Point(773, 58);
			this.cmb_pur_div.MatchEntryTimeout = ((long)(2000));
			this.cmb_pur_div.MaxDropDownItems = ((short)(5));
			this.cmb_pur_div.MaxLength = 32767;
			this.cmb_pur_div.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_pur_div.Name = "cmb_pur_div";
			this.cmb_pur_div.PartialRightColumn = false;
			this.cmb_pur_div.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_pur_div.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_pur_div.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_pur_div.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_pur_div.Size = new System.Drawing.Size(210, 21);
			this.cmb_pur_div.TabIndex = 320;
			// 
			// lbl_pur_div
			// 
			this.lbl_pur_div.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_pur_div.ImageIndex = 0;
			this.lbl_pur_div.ImageList = this.img_Label;
			this.lbl_pur_div.Location = new System.Drawing.Point(672, 58);
			this.lbl_pur_div.Name = "lbl_pur_div";
			this.lbl_pur_div.Size = new System.Drawing.Size(100, 21);
			this.lbl_pur_div.TabIndex = 319;
			this.lbl_pur_div.Text = "Division";
			this.lbl_pur_div.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_data_type
			// 
			this.cmb_data_type.AddItemCols = 0;
			this.cmb_data_type.AddItemSeparator = ';';
			this.cmb_data_type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_data_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_data_type.Caption = "";
			this.cmb_data_type.CaptionHeight = 17;
			this.cmb_data_type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_data_type.ColumnCaptionHeight = 18;
			this.cmb_data_type.ColumnFooterHeight = 18;
			this.cmb_data_type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_data_type.ContentHeight = 17;
			this.cmb_data_type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_data_type.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_data_type.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_data_type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_data_type.EditorHeight = 17;
			this.cmb_data_type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_data_type.GapHeight = 2;
			this.cmb_data_type.ItemHeight = 15;
			this.cmb_data_type.Location = new System.Drawing.Point(445, 58);
			this.cmb_data_type.MatchEntryTimeout = ((long)(2000));
			this.cmb_data_type.MaxDropDownItems = ((short)(5));
			this.cmb_data_type.MaxLength = 32767;
			this.cmb_data_type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_data_type.Name = "cmb_data_type";
			this.cmb_data_type.PartialRightColumn = false;
			this.cmb_data_type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_data_type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_data_type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_data_type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_data_type.Size = new System.Drawing.Size(210, 21);
			this.cmb_data_type.TabIndex = 318;
			// 
			// lbl_hp
			// 
			this.lbl_hp.BackColor = System.Drawing.Color.Transparent;
			this.lbl_hp.Location = new System.Drawing.Point(545, 36);
			this.lbl_hp.Name = "lbl_hp";
			this.lbl_hp.Size = new System.Drawing.Size(10, 21);
			this.lbl_hp.TabIndex = 315;
			this.lbl_hp.Text = "~";
			this.lbl_hp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dpk_get_to
			// 
			this.dpk_get_to.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpk_get_to.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpk_get_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpk_get_to.Location = new System.Drawing.Point(557, 35);
			this.dpk_get_to.Name = "dpk_get_to";
			this.dpk_get_to.Size = new System.Drawing.Size(100, 22);
			this.dpk_get_to.TabIndex = 314;
			// 
			// lbl_get_date
			// 
			this.lbl_get_date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_get_date.ImageIndex = 0;
			this.lbl_get_date.ImageList = this.img_Label;
			this.lbl_get_date.Location = new System.Drawing.Point(344, 36);
			this.lbl_get_date.Name = "lbl_get_date";
			this.lbl_get_date.Size = new System.Drawing.Size(100, 21);
			this.lbl_get_date.TabIndex = 313;
			this.lbl_get_date.Text = "Get Date";
			this.lbl_get_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_status
			// 
			this.lbl_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_status.ImageIndex = 0;
			this.lbl_status.ImageList = this.img_Label;
			this.lbl_status.Location = new System.Drawing.Point(16, 58);
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
			this.lbl_title.Text = "      Purchase Infomation";
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
			// flg_pur_manager
			// 
			this.flg_pur_manager.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
			this.flg_pur_manager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.flg_pur_manager.AutoResize = false;
			this.flg_pur_manager.BackColor = System.Drawing.SystemColors.Window;
			this.flg_pur_manager.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.flg_pur_manager.ColumnInfo = "10,1,0,0,0,90,Columns:";
			this.flg_pur_manager.ContextMenu = this.contextMenu;
			this.flg_pur_manager.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.flg_pur_manager.ForeColor = System.Drawing.SystemColors.WindowText;
			this.flg_pur_manager.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
			this.flg_pur_manager.Location = new System.Drawing.Point(4, 200);
			this.flg_pur_manager.Name = "flg_pur_manager";
			this.flg_pur_manager.Rows.Fixed = 0;
			this.flg_pur_manager.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.flg_pur_manager.Size = new System.Drawing.Size(1008, 440);
			this.flg_pur_manager.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8.25pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.flg_pur_manager.TabIndex = 320;
			this.flg_pur_manager.EnterCell += new System.EventHandler(this.flg_pur_manager_EnterCell);
			this.flg_pur_manager.ComboCloseUp += new C1.Win.C1FlexGrid.RowColEventHandler(this.flg_pur_manager_ComboCloseUp);
			this.flg_pur_manager.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.flg_pur_manager_AfterEdit);
			// 
			// contextMenu
			// 
			this.contextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.cmt_Material,
																						this.menuItem6,
																						this.cmt_Bar1,
																						this.cmt_User});
			// 
			// cmt_Material
			// 
			this.cmt_Material.Index = 0;
			this.cmt_Material.Text = "Material";
			this.cmt_Material.Click += new System.EventHandler(this.cmt_Material_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.Text = "BOM";
			this.menuItem6.Click += new System.EventHandler(this.cmt_Bom);
			// 
			// cmt_Bar1
			// 
			this.cmt_Bar1.Index = 2;
			this.cmt_Bar1.Text = "-";
			// 
			// cmt_User
			// 
			this.cmt_User.Index = 3;
			this.cmt_User.Text = "Change Purchaser";
			this.cmt_User.Click += new System.EventHandler(this.cmt_User_Click);
			// 
			// Form_Pur_manager
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.flg_pur_manager);
			this.Controls.Add(this.pnl_Top);
			this.Name = "Form_Pur_manager";
			this.Load += new System.EventHandler(this.Form_Pur_manager_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.pnl_Top, 0);
			this.Controls.SetChildIndex(this.flg_pur_manager, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Top.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_status)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_pur_user)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_pur_div)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_data_type)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.flg_pur_manager)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
         
		#region 사용자 정의 변수 

		private int _RowFixed;
		private int show_lev = 1;
		private int show_level = 1;
		#endregion  

		#region 공통 메쏘드
		private void Init_Form()
		{

			this.Text               = "PCC_Purchase Manager";
			this.lbl_MainTitle.Text = "PCC_Purchase Manager";
			ClassLib.ComFunction.SetLangDic(this);

            #region ComboBox Setting
            dpk_get_from.Value = DateTime.Now.AddDays(-7);
			dpk_get_to.Value = DateTime.Now;
            DataTable dt_ret = null;
            
            //Status
            try
            {                
                dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_Status);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_status, 1, 2, true, false);
                cmb_status.SelectedIndex = 1;                
            }
            catch
            {
                cmb_status.SelectedIndex = 0;
            }

            //Purchase Division
            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_MatDiv);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_pur_div, 1, 2, true, false);
            cmb_pur_div.SelectedIndex = 0;

            //Data Type (MRP/Request)
            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_DataType);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_data_type, 1, 2, true, false);
            cmb_data_type.SelectedIndex = 0;

			#region Upload  User설정
            DataTable dt_list = Select_sxp_pur_user();

            cmb_pur_user.Enabled = false;
            ClassLib.ComCtl.Set_ComboList(dt_list, cmb_pur_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            cmb_pur_user.SelectedIndex = 0;

            if (ClassLib.ComVar.This_CDCPower_Level == "S00" || ClassLib.ComVar.This_CDCPower_Level.Substring(0, 1) == "P")
            {
                cmb_pur_user.Enabled = true;
                ClassLib.ComCtl.Set_ComboList(dt_list, cmb_pur_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
                cmb_pur_user.SelectedIndex = 0;
                

                //PMC Worker 일때 사용자 이름으로 세팅 (고정)
                if (ClassLib.ComVar.This_CDCPower_Level.ToString() == "P02")
                {
                    cmb_pur_user.Enabled = false;

                    DataTable user_datatable = new DataTable("UserList");
                    DataRow newrow;

                    user_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
                    user_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

                    newrow = user_datatable.NewRow();
                    newrow["Code"] = ClassLib.ComVar.This_User;
                    newrow["Name"] = ClassLib.ComVar.This_User;

                    user_datatable.Rows.Add(newrow);

                    ClassLib.ComCtl.Set_ComboList(user_datatable, cmb_pur_user, 0, 0, false, COM.ComVar.ComboList_Visible.Name);
                    cmb_pur_user.SelectedValue = ClassLib.ComVar.This_User;
                }

            }          

			#endregion  
                     
            #endregion




            #region Grid Setting
            flg_pur_manager.Set_Grid_CDC("SXP_PUR_MANAGER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			flg_pur_manager.Set_Action_Image(img_Action);
			_RowFixed = flg_pur_manager.Rows.Count;
			flg_pur_manager.ExtendLastCol = false;
			flg_pur_manager.Tree.Column = (int)ClassLib.TBSXP_PUR_MANAGER.IxMAT_NAME;
            #endregion

            show_level = 1;

            #region Button Setting 
            tbtn_Print.Enabled   = false;
			tbtn_Delete.Enabled  = false;
			tbtn_New.Enabled     = false;
            tbtn_Save.Enabled    = false;
            tbtn_Confirm.Enabled = false;
            #endregion


            button_control();

            //MRP Data 가져오기
			Get_pur_data(cmb_Factory.SelectedValue.ToString());
            
			tbtn_Search_Click(null, null);            
		}
		private void button_control()
		{
            
            if (ClassLib.ComVar.This_CDCPower_Level.ToString() == "S00" || ClassLib.ComVar.This_CDCPower_Level.ToString().Substring(0,1) == "P") // 권한이 PMC 일때
            {
                tbtn_Confirm.Enabled = false;
                tbtn_Save.Enabled    = false;
                tbtn_Create.Enabled  = false;               
            }

            // PMC System, Super - 'P00', PMC Manager - 'P01'
            if ((ClassLib.ComVar.This_CDCPower_Level.ToString() == "S00") ||
                (ClassLib.ComVar.This_CDCPower_Level.ToString() == "P00") ||
                (ClassLib.ComVar.This_CDCPower_Level.ToString() == "P01"))
            {
                if (cmb_status.SelectedIndex.Equals(0))//status : ALL
                {
                    tbtn_Confirm.Enabled = false;
                    tbtn_Save.Enabled    = false;
                    tbtn_Create.Enabled  = false;
                }
                else if (cmb_status.SelectedIndex.Equals(1))//status : No Editing
                {
                    tbtn_Confirm.Enabled = false;
                    tbtn_Save.Enabled    = true;
                    tbtn_Create.Enabled  = true;
                }
                else if (cmb_status.SelectedIndex.Equals(2) || cmb_status.SelectedIndex.Equals(3))//status : Save
                {
                    tbtn_Confirm.Enabled = true;
                    tbtn_Save.Enabled    = true;
                    tbtn_Create.Enabled  = false;
                }
                else if (cmb_status.SelectedIndex.Equals(4))//status : comfirm
                {
                    tbtn_Confirm.Enabled = false;
                    tbtn_Save.Enabled    = false;
                    tbtn_Create.Enabled  = false;
                }
            }
		}
		#endregion 

		#region 이벤트 처리 

		#region 버튼 이벤트
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            try
            {
                flg_pur_manager.Rows.Count = _RowFixed;
                DataTable dt = Search_pur_list(cmb_Factory.SelectedValue.ToString(), cmb_pur_user.SelectedValue.ToString(), "Y", dpk_get_from.Value.ToString("yyyyMMdd"), dpk_get_to.Value.ToString("yyyyMMdd"),
                    cmb_data_type.SelectedValue.ToString(), cmb_pur_div.SelectedValue.ToString(), txt_style_name.Text.Trim().ToUpper(), txt_mat_name.Text.Trim().ToUpper(), cmb_status.SelectedValue.ToString());


                int dt_rows = dt.Rows.Count;
                int dt_cols = dt.Columns.Count - 1;

                if (dt_rows > 0)
                {

                    for (int i = 0; i < dt_rows; i++)
                    {
                        int t_level = int.Parse(dt.Rows[i].ItemArray[(int)ClassLib.TBSXP_PUR_MANAGER.IxT_LEVEL].ToString());
                        flg_pur_manager.Rows.InsertNode(flg_pur_manager.Rows.Count, t_level);

                        for (int j = 0; j < dt_cols; j++)
                        {
                            flg_pur_manager[flg_pur_manager.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString();

                            if (j == (int)ClassLib.TBSXP_PUR_MANAGER.IxT_LEVEL)
                            {
                                if (!dt.Rows[i].ItemArray[j].ToString().Equals("1"))
                                {
                                    flg_pur_manager.Rows[flg_pur_manager.Rows.Count - 1].AllowEditing = false;
                                    flg_pur_manager.Rows[flg_pur_manager.Rows.Count - 1].StyleNew.BackColor = Color.Bisque;
                                }
                            }
                            if (j == (int)ClassLib.TBSXP_PUR_MANAGER.IxSTATUS)
                            {
                                if (dt.Rows[i].ItemArray[j].ToString().Equals("C"))
                                    flg_pur_manager.Rows[flg_pur_manager.Rows.Count - 1].AllowEditing = false;
                            }
                        }
                    }
                }

                flg_pur_manager.Tree.Show(show_level);

                button_control();
            }
            catch
            {
 
            }
		}


		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            try
            {
                for (int i = _RowFixed; i < flg_pur_manager.Rows.Count; i++)
                {
                    if (flg_pur_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER.IxDIVISION].Equals("U"))
                    {
                        if (flg_pur_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER.IxPUR_USER].ToString().Trim().Length > 0 && flg_pur_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER.IxL_MAT_CD].ToString().Trim().Length > 0)
                        {
                            save(cmb_Factory.SelectedValue.ToString(),
                                dpk_get_from.Value.ToString("yyyyMMdd"),
                                dpk_get_to.Value.ToString("yyyyMMdd"),
                                cmb_data_type.SelectedValue.ToString(),
                                cmb_pur_div.SelectedValue.ToString(),
                                flg_pur_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER.IxL_MAT_CD].ToString(),
                                flg_pur_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER.IxMAT_NAME].ToString(),
                                cmb_status.SelectedValue.ToString(),
                                flg_pur_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER.IxPUR_USER].ToString());
                        }
                    }
                }
                tbtn_Search_Click(null, null);
            }
            catch
            {
 
            }
		}


		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            try
            {
                conform(cmb_Factory.SelectedValue.ToString(), dpk_get_from.Value.ToString("yyyyMMdd"), dpk_get_to.Value.ToString("yyyyMMdd"), cmb_data_type.SelectedValue.ToString(), cmb_pur_div.SelectedValue.ToString(), txt_style_name.Text.Trim(), txt_mat_name.Text.Trim(), cmb_pur_user.SelectedValue.ToString());
                tbtn_Search_Click(null, null);
            }
            catch
            {
 
            }
		}

		private void btn_level_Click(object sender, System.EventArgs e)
		{
		}


		private void tbtn_Create_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            try
            {
                Get_pur_data(cmb_Factory.SelectedValue.ToString());
                tbtn_Search_Click(null, null);
            }
            catch
            {
 
            }
		}
		#endregion  
		
		#region 콘텍스트 메뉴

		private void cmt_Bom(object sender, System.EventArgs e)
		{		
			show_lev = 2;
			flg_pur_manager.Tree.Show(show_lev);
		}

		private void cmt_Material_Click(object sender, System.EventArgs e)
		{
			show_lev = 1;
			flg_pur_manager.Tree.Show(show_lev);
		}

		
		private void cmt_User_Click(object sender, System.EventArgs e)
		{				
			try
			{		   
				int  sct_col  = flg_pur_manager.Selection.c1;

				COM.ComVar.Parameter_PopUp		= new string[2]; 
				COM.ComVar.Parameter_PopUp[0] = ClassLib.ComVar.ConsCDC_User;
				COM.ComVar.Parameter_PopUp[1] = flg_pur_manager[flg_pur_manager.Selection.r1,(int)ClassLib.TBSXP_PUR_MANAGER.IxL_FACTORY].ToString();

				FlexCDC.BaseInfo.Pop_Common_Combo vEditor = new FlexCDC.BaseInfo.Pop_Common_Combo();
				vEditor.ShowDialog();

                for (int i = flg_pur_manager.Rows.Fixed; i < flg_pur_manager.Rows.Count; i++)
                {
                    if (flg_pur_manager.Rows[i].Selected)
                    {
                        if (flg_pur_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER.IxT_LEVEL].ToString() == "1")
                        {
                            //0 - factory, 1- code,, 2-name
                            flg_pur_manager[i, (int)ClassLib.TBSXO_PUR_REQ.IxFACTORY] = COM.ComVar.Parameter_PopUp[0];
                            flg_pur_manager[i, sct_col] = COM.ComVar.Parameter_PopUp[1];
                            flg_pur_manager.Update_Row(i);
                        }
                    }
                }  
			}
			catch
			{

			}		
		}	
		#endregion

		#region 그리드 이벤트
		private void flg_pur_manager_EnterCell(object sender, System.EventArgs e)
		{			
			cmt_Bar1.Visible = false;
			cmt_User.Visible = false;

			if (flg_pur_manager.Selection.c1 == (int)ClassLib.TBSXP_PUR_MANAGER.IxPUR_USER && flg_pur_manager[flg_pur_manager.Selection.r1, (int)ClassLib.TBSXP_PUR_MANAGER.IxSTATUS].ToString() != "Confirm") 	
			{
				cmt_Bar1.Visible  = true;
				cmt_User.Visible = true;
			}
		}


		private void flg_pur_manager_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{           
            int sct_col = flg_pur_manager.Selection.c1;
            int sct_row  = flg_pur_manager.Selection.r1;

            for (int i = flg_pur_manager.Rows.Fixed; i < flg_pur_manager.Rows.Count; i++)
            {
                if (flg_pur_manager.Rows[i].Selected)
                {
                    if (flg_pur_manager[i, (int)ClassLib.TBSXP_PUR_MANAGER.IxT_LEVEL].ToString() == "1")
                    {
                        flg_pur_manager[i, sct_col] = flg_pur_manager[sct_row, sct_col].ToString();
                        flg_pur_manager.Update_Row(i);
                    }
                }
            }
		}

		private void flg_pur_manager_ComboCloseUp(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		}

		#endregion  

		#region 기타 이벤트
		private void cmb_status_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_status.SelectedIndex == -1)return;

			button_control();
		}        
		#endregion  

		#endregion  
	
		#region DB컨넥트
		private DataTable Select_sxp_pur_user()
		{
			string Proc_Name = "PKG_SXP_PUR_01_SELECT.SELECT_SXP_PURUSER";

			MyOraDB.ReDim_Parameter(2);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "arg_factory";
			MyOraDB.Parameter_Name[1] = "out_cursor";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}
		private void Get_pur_data( string arg_factory )
		{	
			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXP_PUR_01.GET_SXP_PUR_MANAGER" ; 

			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";

			//03. DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

			//04. DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = COM.ComVar.This_User;

            
			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
		}
		private DataTable Search_pur_list(string arg_factory, string arg_pur_user, string arg_user_div, string  arg_get_from, string arg_get_to, string arg_data_type, string arg_pur_div, string arg_mat_cd, string arg_mat_name, string arg_status)
		{
			DataSet ds_Search ; 

			MyOraDB.ReDim_Parameter(11);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXP_PUR_01_SELECT.SELECT_SXP_PUR_MANAGER" ; 

			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_PUR_USER";
			MyOraDB.Parameter_Name[2] = "ARG_USER_DIV";
			MyOraDB.Parameter_Name[3] = "ARG_GET_FROM";
			MyOraDB.Parameter_Name[4] = "ARG_GET_TO";
			MyOraDB.Parameter_Name[5] = "ARG_DATA_TYPE";
			MyOraDB.Parameter_Name[6] = "ARG_PUR_DIV";
			MyOraDB.Parameter_Name[7] = "ARG_STYLE_NAME";
			MyOraDB.Parameter_Name[8] = "ARG_MAT_NAME";
			MyOraDB.Parameter_Name[9] = "ARG_STATUS";
			MyOraDB.Parameter_Name[10] = "OUT_CURSOR";

			//03. DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[10] = (int)OracleType.Cursor ; 

			//04. DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_pur_user;
			MyOraDB.Parameter_Values[2] = arg_user_div;
			MyOraDB.Parameter_Values[3] = arg_get_from;
			MyOraDB.Parameter_Values[4] = arg_get_to;
			MyOraDB.Parameter_Values[5] = arg_data_type;
			MyOraDB.Parameter_Values[6] = arg_pur_div;
			MyOraDB.Parameter_Values[7] = arg_mat_cd;
			MyOraDB.Parameter_Values[8] = arg_mat_name;
			MyOraDB.Parameter_Values[9] = arg_status;
			MyOraDB.Parameter_Values[10] = "";

			MyOraDB.Add_Select_Parameter(true);
			ds_Search = MyOraDB.Exe_Select_Procedure();	

			return ds_Search.Tables[MyOraDB.Process_Name];
		}
        private void conform(string arg_factory, string arg_get_from, string arg_get_to, string arg_data_type, string arg_pur_div, string arg_mat_cd, string arg_mat_name, string arg_pur_user)
		{
			string Proc_Name = "PKG_SXP_PUR_01.COMFIRM_SXP_PUR_MANAGER";

			MyOraDB.ReDim_Parameter(10);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "arg_factory";        
			MyOraDB.Parameter_Name[1] = "arg_get_from";
			MyOraDB.Parameter_Name[2] = "arg_get_to";
			MyOraDB.Parameter_Name[3] = "arg_data_type";
			MyOraDB.Parameter_Name[4] = "arg_pur_div";
			MyOraDB.Parameter_Name[5] = "arg_mat_cd";
			MyOraDB.Parameter_Name[6] = "arg_mat_name";
			MyOraDB.Parameter_Name[7] = "arg_status";
			MyOraDB.Parameter_Name[8] = "arg_pur_user";    
			MyOraDB.Parameter_Name[9] = "arg_upd_user";     


			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;

			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_get_from;
			MyOraDB.Parameter_Values[2] = arg_get_to;
			MyOraDB.Parameter_Values[3] = arg_data_type;
			MyOraDB.Parameter_Values[4] = arg_pur_div;
			MyOraDB.Parameter_Values[5] = arg_mat_cd;
			MyOraDB.Parameter_Values[6] = arg_mat_name;
			MyOraDB.Parameter_Values[7] = cmb_status.SelectedValue.ToString();
			MyOraDB.Parameter_Values[8] = arg_pur_user;
			MyOraDB.Parameter_Values[9] = ClassLib.ComVar.This_User;

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
		}
        private void save(string arg_factory, string arg_get_from, string arg_get_to, string arg_data_type, string arg_pur_div, string arg_mat_cd, string arg_mat_name, string arg_status, string arg_pur_user)
		{
			string Proc_Name = "PKG_SXP_PUR_01.SAVE_SXP_PUR_MANAGER";

			MyOraDB.ReDim_Parameter(10);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "arg_factory";        
			MyOraDB.Parameter_Name[1] = "arg_get_from";
			MyOraDB.Parameter_Name[2] = "arg_get_to";
			MyOraDB.Parameter_Name[3] = "arg_data_type";
			MyOraDB.Parameter_Name[4] = "arg_pur_div";
			MyOraDB.Parameter_Name[5] = "arg_mat_cd";
			MyOraDB.Parameter_Name[6] = "arg_mat_name";
			MyOraDB.Parameter_Name[7] = "arg_status";
			MyOraDB.Parameter_Name[8] = "arg_pur_user";
			MyOraDB.Parameter_Name[9] = "arg_upd_user";   


			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;

			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_get_from;
			MyOraDB.Parameter_Values[2] = arg_get_to;
			MyOraDB.Parameter_Values[3] = arg_data_type;
			MyOraDB.Parameter_Values[4] = arg_pur_div;
			MyOraDB.Parameter_Values[5] = arg_mat_cd;
			MyOraDB.Parameter_Values[6] = arg_mat_name;
			MyOraDB.Parameter_Values[7] = arg_status;
			MyOraDB.Parameter_Values[8] = arg_pur_user;
			MyOraDB.Parameter_Values[9] = ClassLib.ComVar.This_User;

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
		}
		#endregion  

		private void Form_Pur_manager_Load(object sender, System.EventArgs e)
		{            
			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
			ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
			//Init_Form();
		}
        private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_Factory.SelectedIndex == -1) return;
			COM.ComVar.This_CDC_Factory = cmb_Factory.SelectedValue.ToString();
			Init_Form();
		}        
	}
}

