using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.IO;


namespace FlexOrder.ExpOA
{
	public class Form_OA_CRT01 : COM.OrderWinForm.Form_Top
	{
		#region 컨트롤 정의 및 리소스 정리
		public System.Windows.Forms.Panel pnl_Search;
		private System.Windows.Forms.Panel pnl_Search1_Image;
		private System.Windows.Forms.Label lbl_STYLE;
		private C1.Win.C1List.C1Combo cmb_Style;
		private C1.Win.C1List.C1Combo cmb_OBS_ID;
		private System.Windows.Forms.Label lbl_PO_ID;
		private System.Windows.Forms.Label lbl_Factory;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.Panel pnl_Body;
		private System.Windows.Forms.Panel pnl_Left;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel pnl_Bottom;
		private System.Windows.Forms.GroupBox gb_style_info;
		public COM.FSP fsp_Style;
		private System.Windows.Forms.Panel pnl_Right;
		private System.Windows.Forms.GroupBox gb_styletail_infol;
		public COM.FSP fsp_Stylebal;
		public COM.FSP fsp_Styletail;
		private System.Windows.Forms.DateTimePicker dtp_OA_Ymd;
		private System.Windows.Forms.TextBox txt_Remarks;
		private System.Windows.Forms.Label label8;
		private C1.Win.C1List.C1Combo cmb_Season_Year;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_Qual_Iseq;
		private C1.Win.C1List.C1Combo cmb_Season_Cd;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txt_Order_Rsn;
		private System.Windows.Forms.Label lbl_Order_Rsn;
		private System.Windows.Forms.TextBox txt_Pur_Grp;
		private System.Windows.Forms.TextBox txt_Your_Ref;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txt_Ref_No;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_Pur_No;
		private System.Windows.Forms.DateTimePicker dtp_Chg_Ymd;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label11;
		private C1.Win.C1List.C1Combo cmb_OA_Div;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_OA_Nu;
		private System.Windows.Forms.Label label4;
		private C1.Win.C1List.C1Combo cmb_OA_OBS_Div;
		private C1.Win.C1List.C1Combo cmb_OA_Nu;
		private System.Windows.Forms.Label btn_OA;
		private C1.Win.C1List.C1Combo cmb_OBS_Type;
		private System.Windows.Forms.Label lbl_OBS_Type;
		private System.ComponentModel.IContainer components = null;

		public Form_OA_CRT01()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_OA_CRT01));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_Search1_Image = new System.Windows.Forms.Panel();
			this.lbl_OBS_Type = new System.Windows.Forms.Label();
			this.cmb_OBS_Type = new C1.Win.C1List.C1Combo();
			this.lbl_STYLE = new System.Windows.Forms.Label();
			this.cmb_Style = new C1.Win.C1List.C1Combo();
			this.cmb_OBS_ID = new C1.Win.C1List.C1Combo();
			this.lbl_PO_ID = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.pnl_Right = new System.Windows.Forms.Panel();
			this.gb_styletail_infol = new System.Windows.Forms.GroupBox();
			this.fsp_Stylebal = new COM.FSP();
			this.fsp_Styletail = new COM.FSP();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.pnl_Left = new System.Windows.Forms.Panel();
			this.gb_style_info = new System.Windows.Forms.GroupBox();
			this.fsp_Style = new COM.FSP();
			this.pnl_Bottom = new System.Windows.Forms.Panel();
			this.btn_OA = new System.Windows.Forms.Label();
			this.cmb_OA_Nu = new C1.Win.C1List.C1Combo();
			this.cmb_OA_OBS_Div = new C1.Win.C1List.C1Combo();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_OA_Nu = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dtp_OA_Ymd = new System.Windows.Forms.DateTimePicker();
			this.txt_Remarks = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cmb_Season_Year = new C1.Win.C1List.C1Combo();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_Qual_Iseq = new System.Windows.Forms.TextBox();
			this.cmb_Season_Cd = new C1.Win.C1List.C1Combo();
			this.label16 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_Order_Rsn = new System.Windows.Forms.TextBox();
			this.lbl_Order_Rsn = new System.Windows.Forms.Label();
			this.txt_Pur_Grp = new System.Windows.Forms.TextBox();
			this.txt_Your_Ref = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_Ref_No = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_Pur_No = new System.Windows.Forms.TextBox();
			this.dtp_Chg_Ymd = new System.Windows.Forms.DateTimePicker();
			this.label18 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.cmb_OA_Div = new C1.Win.C1List.C1Combo();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_Search1_Image.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_Body.SuspendLayout();
			this.pnl_Right.SuspendLayout();
			this.gb_styletail_infol.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fsp_Stylebal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fsp_Styletail)).BeginInit();
			this.pnl_Left.SuspendLayout();
			this.gb_style_info.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fsp_Style)).BeginInit();
			this.pnl_Bottom.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OA_Nu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OA_OBS_Div)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season_Year)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season_Cd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OA_Div)).BeginInit();
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
			// tbtn_Append
			// 
			this.tbtn_Append.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Append_Click);
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
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_Search1_Image);
			this.pnl_Search.DockPadding.All = 8;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1012, 72);
			this.pnl_Search.TabIndex = 46;
			// 
			// pnl_Search1_Image
			// 
			this.pnl_Search1_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search1_Image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_Search1_Image.Controls.Add(this.lbl_OBS_Type);
			this.pnl_Search1_Image.Controls.Add(this.cmb_OBS_Type);
			this.pnl_Search1_Image.Controls.Add(this.lbl_STYLE);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Style);
			this.pnl_Search1_Image.Controls.Add(this.cmb_OBS_ID);
			this.pnl_Search1_Image.Controls.Add(this.lbl_PO_ID);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Factory);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Factory);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox2);
			this.pnl_Search1_Image.Controls.Add(this.lbl_SubTitle1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox5);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox8);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox7);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox10);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox11);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox12);
			this.pnl_Search1_Image.Location = new System.Drawing.Point(8, 8);
			this.pnl_Search1_Image.Name = "pnl_Search1_Image";
			this.pnl_Search1_Image.Size = new System.Drawing.Size(996, 56);
			this.pnl_Search1_Image.TabIndex = 0;
			// 
			// lbl_OBS_Type
			// 
			this.lbl_OBS_Type.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Type.ImageIndex = 1;
			this.lbl_OBS_Type.ImageList = this.img_Label;
			this.lbl_OBS_Type.Location = new System.Drawing.Point(258, 26);
			this.lbl_OBS_Type.Name = "lbl_OBS_Type";
			this.lbl_OBS_Type.Size = new System.Drawing.Size(100, 27);
			this.lbl_OBS_Type.TabIndex = 176;
			this.lbl_OBS_Type.Text = "OBS Type";
			this.lbl_OBS_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_OBS_Type
			// 
			this.cmb_OBS_Type.AddItemCols = 0;
			this.cmb_OBS_Type.AddItemSeparator = ';';
			this.cmb_OBS_Type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_Type.Caption = "";
			this.cmb_OBS_Type.CaptionHeight = 17;
			this.cmb_OBS_Type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_Type.ColumnCaptionHeight = 18;
			this.cmb_OBS_Type.ColumnFooterHeight = 18;
			this.cmb_OBS_Type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_Type.ContentHeight = 15;
			this.cmb_OBS_Type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_Type.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OBS_Type.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_Type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_Type.EditorHeight = 15;
			this.cmb_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_Type.GapHeight = 2;
			this.cmb_OBS_Type.ItemHeight = 15;
			this.cmb_OBS_Type.Location = new System.Drawing.Point(358, 31);
			this.cmb_OBS_Type.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_Type.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_Type.MaxLength = 32767;
			this.cmb_OBS_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_Type.Name = "cmb_OBS_Type";
			this.cmb_OBS_Type.PartialRightColumn = false;
			this.cmb_OBS_Type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Con" +
				"trol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}S" +
				"tyle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_OBS_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type.Size = new System.Drawing.Size(120, 19);
			this.cmb_OBS_Type.TabIndex = 174;
			this.cmb_OBS_Type.TextChanged += new System.EventHandler(this.cmb_OBS_Type_TextChanged);
			// 
			// lbl_STYLE
			// 
			this.lbl_STYLE.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_STYLE.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_STYLE.ImageIndex = 0;
			this.lbl_STYLE.ImageList = this.img_Label;
			this.lbl_STYLE.Location = new System.Drawing.Point(768, 29);
			this.lbl_STYLE.Name = "lbl_STYLE";
			this.lbl_STYLE.Size = new System.Drawing.Size(100, 21);
			this.lbl_STYLE.TabIndex = 173;
			this.lbl_STYLE.Text = "Style Code";
			this.lbl_STYLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Style
			// 
			this.cmb_Style.AddItemCols = 0;
			this.cmb_Style.AddItemSeparator = ';';
			this.cmb_Style.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Style.Caption = "";
			this.cmb_Style.CaptionHeight = 17;
			this.cmb_Style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Style.ColumnCaptionHeight = 18;
			this.cmb_Style.ColumnFooterHeight = 18;
			this.cmb_Style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Style.ContentHeight = 15;
			this.cmb_Style.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Style.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Style.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Style.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Style.EditorHeight = 15;
			this.cmb_Style.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Style.GapHeight = 2;
			this.cmb_Style.ItemHeight = 15;
			this.cmb_Style.Location = new System.Drawing.Point(868, 30);
			this.cmb_Style.MatchEntryTimeout = ((long)(2000));
			this.cmb_Style.MaxDropDownItems = ((short)(5));
			this.cmb_Style.MaxLength = 32767;
			this.cmb_Style.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Style.Name = "cmb_Style";
			this.cmb_Style.PartialRightColumn = false;
			this.cmb_Style.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Style.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Style.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Style.Size = new System.Drawing.Size(124, 19);
			this.cmb_Style.TabIndex = 172;
			this.cmb_Style.TextChanged += new System.EventHandler(this.cmb_Style_TextChanged);
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
			this.cmb_OBS_ID.Location = new System.Drawing.Point(612, 30);
			this.cmb_OBS_ID.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_ID.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_ID.MaxLength = 32767;
			this.cmb_OBS_ID.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_ID.Name = "cmb_OBS_ID";
			this.cmb_OBS_ID.PartialRightColumn = false;
			this.cmb_OBS_ID.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_OBS_ID.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_ID.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID.Size = new System.Drawing.Size(124, 19);
			this.cmb_OBS_ID.TabIndex = 171;
			this.cmb_OBS_ID.TextChanged += new System.EventHandler(this.cmb_OBS_ID_TextChanged);
			// 
			// lbl_PO_ID
			// 
			this.lbl_PO_ID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_PO_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_PO_ID.ImageIndex = 1;
			this.lbl_PO_ID.ImageList = this.img_Label;
			this.lbl_PO_ID.Location = new System.Drawing.Point(512, 29);
			this.lbl_PO_ID.Name = "lbl_PO_ID";
			this.lbl_PO_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_PO_ID.TabIndex = 165;
			this.lbl_PO_ID.Text = "OBS ID";
			this.lbl_PO_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 28);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 18;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.Location = new System.Drawing.Point(110, 30);
			this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory.MaxDropDownItems = ((short)(5));
			this.cmb_Factory.MaxLength = 32767;
			this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory.Name = "cmb_Factory";
			this.cmb_Factory.PartialRightColumn = false;
			this.cmb_Factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(120, 19);
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
			this.pictureBox5.Size = new System.Drawing.Size(19, 10);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.Color.Blue;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(906, 42);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(90, 14);
			this.pictureBox8.TabIndex = 8;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(0, 24);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(32, 21);
			this.pictureBox7.TabIndex = 3;
			this.pictureBox7.TabStop = false;
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
			this.pictureBox10.Size = new System.Drawing.Size(948, 24);
			this.pictureBox10.TabIndex = 4;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox11.BackColor = System.Drawing.Color.Blue;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(0, 42);
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
			this.pictureBox12.Location = new System.Drawing.Point(72, 42);
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
			this.pnl_Body.Controls.Add(this.pnl_Right);
			this.pnl_Body.Controls.Add(this.splitter1);
			this.pnl_Body.Controls.Add(this.pnl_Left);
			this.pnl_Body.Controls.Add(this.pnl_Bottom);
			this.pnl_Body.Location = new System.Drawing.Point(0, 132);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 512);
			this.pnl_Body.TabIndex = 47;
			// 
			// pnl_Right
			// 
			this.pnl_Right.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Right.Controls.Add(this.gb_styletail_infol);
			this.pnl_Right.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_Right.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_Right.Location = new System.Drawing.Point(205, 0);
			this.pnl_Right.Name = "pnl_Right";
			this.pnl_Right.Size = new System.Drawing.Size(811, 384);
			this.pnl_Right.TabIndex = 4;
			// 
			// gb_styletail_infol
			// 
			this.gb_styletail_infol.Controls.Add(this.fsp_Stylebal);
			this.gb_styletail_infol.Controls.Add(this.fsp_Styletail);
			this.gb_styletail_infol.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_styletail_infol.Font = new System.Drawing.Font("Verdana", 8F);
			this.gb_styletail_infol.Location = new System.Drawing.Point(0, 0);
			this.gb_styletail_infol.Name = "gb_styletail_infol";
			this.gb_styletail_infol.Size = new System.Drawing.Size(811, 384);
			this.gb_styletail_infol.TabIndex = 7;
			this.gb_styletail_infol.TabStop = false;
			this.gb_styletail_infol.Text = "Style Detail Info";
			// 
			// fsp_Stylebal
			// 
			this.fsp_Stylebal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fsp_Stylebal.AutoResize = false;
			this.fsp_Stylebal.BackColor = System.Drawing.Color.White;
			this.fsp_Stylebal.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fsp_Stylebal.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fsp_Stylebal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fsp_Stylebal.ForeColor = System.Drawing.Color.Black;
			this.fsp_Stylebal.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fsp_Stylebal.Location = new System.Drawing.Point(8, 248);
			this.fsp_Stylebal.Name = "fsp_Stylebal";
			this.fsp_Stylebal.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fsp_Stylebal.Size = new System.Drawing.Size(795, 128);
			this.fsp_Stylebal.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fsp_Stylebal.TabIndex = 58;
			// 
			// fsp_Styletail
			// 
			this.fsp_Styletail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fsp_Styletail.AutoResize = false;
			this.fsp_Styletail.BackColor = System.Drawing.Color.White;
			this.fsp_Styletail.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fsp_Styletail.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fsp_Styletail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fsp_Styletail.ForeColor = System.Drawing.Color.Black;
			this.fsp_Styletail.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fsp_Styletail.Location = new System.Drawing.Point(16, 24);
			this.fsp_Styletail.Name = "fsp_Styletail";
			this.fsp_Styletail.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fsp_Styletail.Size = new System.Drawing.Size(795, 215);
			this.fsp_Styletail.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fsp_Styletail.TabIndex = 57;
			this.fsp_Styletail.DoubleClick += new System.EventHandler(this.fsp_Styletail_DoubleClick);
			this.fsp_Styletail.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fsp_Styletail_AfterEdit);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(200, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(5, 384);
			this.splitter1.TabIndex = 2;
			this.splitter1.TabStop = false;
			// 
			// pnl_Left
			// 
			this.pnl_Left.Controls.Add(this.gb_style_info);
			this.pnl_Left.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnl_Left.DockPadding.Left = 5;
			this.pnl_Left.DockPadding.Right = 5;
			this.pnl_Left.Location = new System.Drawing.Point(0, 0);
			this.pnl_Left.Name = "pnl_Left";
			this.pnl_Left.Size = new System.Drawing.Size(200, 384);
			this.pnl_Left.TabIndex = 1;
			// 
			// gb_style_info
			// 
			this.gb_style_info.Controls.Add(this.fsp_Style);
			this.gb_style_info.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_style_info.Location = new System.Drawing.Point(5, 0);
			this.gb_style_info.Name = "gb_style_info";
			this.gb_style_info.Size = new System.Drawing.Size(190, 384);
			this.gb_style_info.TabIndex = 6;
			this.gb_style_info.TabStop = false;
			this.gb_style_info.Text = "Style Info";
			// 
			// fsp_Style
			// 
			this.fsp_Style.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fsp_Style.AutoResize = false;
			this.fsp_Style.BackColor = System.Drawing.Color.White;
			this.fsp_Style.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fsp_Style.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fsp_Style.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fsp_Style.ForeColor = System.Drawing.Color.Black;
			this.fsp_Style.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fsp_Style.Location = new System.Drawing.Point(8, 30);
			this.fsp_Style.Name = "fsp_Style";
			this.fsp_Style.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fsp_Style.Size = new System.Drawing.Size(174, 346);
			this.fsp_Style.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fsp_Style.TabIndex = 57;
			this.fsp_Style.Click += new System.EventHandler(this.fsp_Style_Click);
			// 
			// pnl_Bottom
			// 
			this.pnl_Bottom.Controls.Add(this.btn_OA);
			this.pnl_Bottom.Controls.Add(this.cmb_OA_Nu);
			this.pnl_Bottom.Controls.Add(this.cmb_OA_OBS_Div);
			this.pnl_Bottom.Controls.Add(this.label4);
			this.pnl_Bottom.Controls.Add(this.txt_OA_Nu);
			this.pnl_Bottom.Controls.Add(this.label3);
			this.pnl_Bottom.Controls.Add(this.label2);
			this.pnl_Bottom.Controls.Add(this.label1);
			this.pnl_Bottom.Controls.Add(this.dtp_OA_Ymd);
			this.pnl_Bottom.Controls.Add(this.txt_Remarks);
			this.pnl_Bottom.Controls.Add(this.label8);
			this.pnl_Bottom.Controls.Add(this.cmb_Season_Year);
			this.pnl_Bottom.Controls.Add(this.label7);
			this.pnl_Bottom.Controls.Add(this.txt_Qual_Iseq);
			this.pnl_Bottom.Controls.Add(this.cmb_Season_Cd);
			this.pnl_Bottom.Controls.Add(this.label16);
			this.pnl_Bottom.Controls.Add(this.label9);
			this.pnl_Bottom.Controls.Add(this.txt_Order_Rsn);
			this.pnl_Bottom.Controls.Add(this.lbl_Order_Rsn);
			this.pnl_Bottom.Controls.Add(this.txt_Pur_Grp);
			this.pnl_Bottom.Controls.Add(this.txt_Your_Ref);
			this.pnl_Bottom.Controls.Add(this.label17);
			this.pnl_Bottom.Controls.Add(this.label10);
			this.pnl_Bottom.Controls.Add(this.txt_Ref_No);
			this.pnl_Bottom.Controls.Add(this.label5);
			this.pnl_Bottom.Controls.Add(this.txt_Pur_No);
			this.pnl_Bottom.Controls.Add(this.dtp_Chg_Ymd);
			this.pnl_Bottom.Controls.Add(this.label18);
			this.pnl_Bottom.Controls.Add(this.label11);
			this.pnl_Bottom.Controls.Add(this.cmb_OA_Div);
			this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnl_Bottom.Location = new System.Drawing.Point(0, 384);
			this.pnl_Bottom.Name = "pnl_Bottom";
			this.pnl_Bottom.Size = new System.Drawing.Size(1016, 128);
			this.pnl_Bottom.TabIndex = 0;
			// 
			// btn_OA
			// 
			this.btn_OA.Image = ((System.Drawing.Image)(resources.GetObject("btn_OA.Image")));
			this.btn_OA.Location = new System.Drawing.Point(321, 8);
			this.btn_OA.Name = "btn_OA";
			this.btn_OA.Size = new System.Drawing.Size(21, 21);
			this.btn_OA.TabIndex = 232;
			this.btn_OA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_OA.Click += new System.EventHandler(this.btn_OA_Click);
			// 
			// cmb_OA_Nu
			// 
			this.cmb_OA_Nu.AddItemCols = 0;
			this.cmb_OA_Nu.AddItemSeparator = ';';
			this.cmb_OA_Nu.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OA_Nu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OA_Nu.Caption = "";
			this.cmb_OA_Nu.CaptionHeight = 17;
			this.cmb_OA_Nu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OA_Nu.ColumnCaptionHeight = 18;
			this.cmb_OA_Nu.ColumnFooterHeight = 18;
			this.cmb_OA_Nu.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OA_Nu.ContentHeight = 16;
			this.cmb_OA_Nu.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OA_Nu.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OA_Nu.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OA_Nu.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OA_Nu.EditorHeight = 16;
			this.cmb_OA_Nu.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OA_Nu.GapHeight = 2;
			this.cmb_OA_Nu.ItemHeight = 15;
			this.cmb_OA_Nu.Location = new System.Drawing.Point(217, 8);
			this.cmb_OA_Nu.MatchEntryTimeout = ((long)(2000));
			this.cmb_OA_Nu.MaxDropDownItems = ((short)(5));
			this.cmb_OA_Nu.MaxLength = 32767;
			this.cmb_OA_Nu.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OA_Nu.Name = "cmb_OA_Nu";
			this.cmb_OA_Nu.PartialRightColumn = false;
			this.cmb_OA_Nu.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight" +
				";}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:" +
				"True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:" +
				"Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1Lis" +
				"t.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHei" +
				"ght=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"" +
				"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScroll" +
				"Bar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me" +
				"=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Fo" +
				"oter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle pare" +
				"nt=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" " +
				"/><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me" +
				"=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Selecte" +
				"dStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1" +
				".Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><St" +
				"yle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style " +
				"parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style p" +
				"arent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style" +
				" parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style pare" +
				"nt=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedS" +
				"tyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layo" +
				"ut><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_OA_Nu.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OA_Nu.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OA_Nu.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OA_Nu.Size = new System.Drawing.Size(105, 20);
			this.cmb_OA_Nu.TabIndex = 231;
			this.cmb_OA_Nu.TextChanged += new System.EventHandler(this.cmb_OA_Nu_TextChanged);
			// 
			// cmb_OA_OBS_Div
			// 
			this.cmb_OA_OBS_Div.AddItemCols = 0;
			this.cmb_OA_OBS_Div.AddItemSeparator = ';';
			this.cmb_OA_OBS_Div.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OA_OBS_Div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OA_OBS_Div.Caption = "";
			this.cmb_OA_OBS_Div.CaptionHeight = 17;
			this.cmb_OA_OBS_Div.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OA_OBS_Div.ColumnCaptionHeight = 18;
			this.cmb_OA_OBS_Div.ColumnFooterHeight = 18;
			this.cmb_OA_OBS_Div.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OA_OBS_Div.ContentHeight = 16;
			this.cmb_OA_OBS_Div.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OA_OBS_Div.EditorBackColor = System.Drawing.SystemColors.Control;
			this.cmb_OA_OBS_Div.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OA_OBS_Div.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OA_OBS_Div.EditorHeight = 16;
			this.cmb_OA_OBS_Div.Enabled = false;
			this.cmb_OA_OBS_Div.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OA_OBS_Div.GapHeight = 2;
			this.cmb_OA_OBS_Div.ItemHeight = 15;
			this.cmb_OA_OBS_Div.Location = new System.Drawing.Point(455, 8);
			this.cmb_OA_OBS_Div.MatchEntryTimeout = ((long)(2000));
			this.cmb_OA_OBS_Div.MaxDropDownItems = ((short)(5));
			this.cmb_OA_OBS_Div.MaxLength = 32767;
			this.cmb_OA_OBS_Div.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OA_OBS_Div.Name = "cmb_OA_OBS_Div";
			this.cmb_OA_OBS_Div.PartialRightColumn = false;
			this.cmb_OA_OBS_Div.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight" +
				";}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:" +
				"Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8" +
				"{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1Lis" +
				"t.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHei" +
				"ght=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"" +
				"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScroll" +
				"Bar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me" +
				"=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Fo" +
				"oter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle pare" +
				"nt=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" " +
				"/><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me" +
				"=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Selecte" +
				"dStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1" +
				".Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><St" +
				"yle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style " +
				"parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style p" +
				"arent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style" +
				" parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style pare" +
				"nt=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedS" +
				"tyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layo" +
				"ut><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_OA_OBS_Div.ReadOnly = true;
			this.cmb_OA_OBS_Div.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OA_OBS_Div.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OA_OBS_Div.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OA_OBS_Div.Size = new System.Drawing.Size(210, 20);
			this.cmb_OA_OBS_Div.TabIndex = 230;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label4.Font = new System.Drawing.Font("Verdana", 8F);
			this.label4.ImageIndex = 1;
			this.label4.ImageList = this.img_Label;
			this.label4.Location = new System.Drawing.Point(8, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 21);
			this.label4.TabIndex = 229;
			this.label4.Text = "OA Nu";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_OA_Nu
			// 
			this.txt_OA_Nu.BackColor = System.Drawing.Color.LightYellow;
			this.txt_OA_Nu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OA_Nu.Enabled = false;
			this.txt_OA_Nu.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_OA_Nu.Location = new System.Drawing.Point(112, 8);
			this.txt_OA_Nu.MaxLength = 10;
			this.txt_OA_Nu.Name = "txt_OA_Nu";
			this.txt_OA_Nu.ReadOnly = true;
			this.txt_OA_Nu.Size = new System.Drawing.Size(105, 20);
			this.txt_OA_Nu.TabIndex = 228;
			this.txt_OA_Nu.Text = "";
			this.txt_OA_Nu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_OA_Nu_KeyDown);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Verdana", 8F);
			this.label3.ImageIndex = 1;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(8, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 226;
			this.label3.Text = "OA DIV";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label2.Font = new System.Drawing.Font("Verdana", 8F);
			this.label2.ImageIndex = 1;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(696, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 225;
			this.label2.Text = "OA Date";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Verdana", 8F);
			this.label1.ImageIndex = 1;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(352, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 224;
			this.label1.Text = "OBS OA Div";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtp_OA_Ymd
			// 
			this.dtp_OA_Ymd.CustomFormat = "yyyy-MM-dd";
			this.dtp_OA_Ymd.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.dtp_OA_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_OA_Ymd.Location = new System.Drawing.Point(800, 8);
			this.dtp_OA_Ymd.Name = "dtp_OA_Ymd";
			this.dtp_OA_Ymd.Size = new System.Drawing.Size(210, 20);
			this.dtp_OA_Ymd.TabIndex = 223;
			// 
			// txt_Remarks
			// 
			this.txt_Remarks.BackColor = System.Drawing.Color.White;
			this.txt_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Remarks.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Remarks.Location = new System.Drawing.Point(455, 103);
			this.txt_Remarks.MaxLength = 100;
			this.txt_Remarks.Name = "txt_Remarks";
			this.txt_Remarks.Size = new System.Drawing.Size(210, 20);
			this.txt_Remarks.TabIndex = 221;
			this.txt_Remarks.Text = "";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label8.Font = new System.Drawing.Font("Verdana", 8F);
			this.label8.ImageIndex = 2;
			this.label8.ImageList = this.img_Label;
			this.label8.Location = new System.Drawing.Point(352, 103);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 21);
			this.label8.TabIndex = 220;
			this.label8.Text = "REMARKS";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Season_Year
			// 
			this.cmb_Season_Year.AddItemCols = 0;
			this.cmb_Season_Year.AddItemSeparator = ';';
			this.cmb_Season_Year.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Season_Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Season_Year.Caption = "";
			this.cmb_Season_Year.CaptionHeight = 17;
			this.cmb_Season_Year.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Season_Year.ColumnCaptionHeight = 18;
			this.cmb_Season_Year.ColumnFooterHeight = 18;
			this.cmb_Season_Year.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Season_Year.ContentHeight = 16;
			this.cmb_Season_Year.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Season_Year.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Season_Year.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Season_Year.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Season_Year.EditorHeight = 16;
			this.cmb_Season_Year.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Season_Year.GapHeight = 2;
			this.cmb_Season_Year.ItemHeight = 15;
			this.cmb_Season_Year.Location = new System.Drawing.Point(112, 104);
			this.cmb_Season_Year.MatchEntryTimeout = ((long)(2000));
			this.cmb_Season_Year.MaxDropDownItems = ((short)(5));
			this.cmb_Season_Year.MaxLength = 32767;
			this.cmb_Season_Year.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Season_Year.Name = "cmb_Season_Year";
			this.cmb_Season_Year.PartialRightColumn = false;
			this.cmb_Season_Year.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight" +
				";}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:" +
				"Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8" +
				"{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1Lis" +
				"t.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHei" +
				"ght=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"" +
				"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScroll" +
				"Bar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me" +
				"=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Fo" +
				"oter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle pare" +
				"nt=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" " +
				"/><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me" +
				"=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Selecte" +
				"dStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1" +
				".Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><St" +
				"yle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style " +
				"parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style p" +
				"arent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style" +
				" parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style pare" +
				"nt=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedS" +
				"tyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layo" +
				"ut><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Season_Year.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Season_Year.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Season_Year.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Season_Year.Size = new System.Drawing.Size(210, 20);
			this.cmb_Season_Year.TabIndex = 219;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label7.Font = new System.Drawing.Font("Verdana", 8F);
			this.label7.ImageIndex = 2;
			this.label7.ImageList = this.img_Label;
			this.label7.Location = new System.Drawing.Point(8, 104);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 21);
			this.label7.TabIndex = 218;
			this.label7.Text = "SEASON_YEAR";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Qual_Iseq
			// 
			this.txt_Qual_Iseq.BackColor = System.Drawing.Color.White;
			this.txt_Qual_Iseq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Qual_Iseq.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Qual_Iseq.Location = new System.Drawing.Point(455, 80);
			this.txt_Qual_Iseq.MaxLength = 10;
			this.txt_Qual_Iseq.Name = "txt_Qual_Iseq";
			this.txt_Qual_Iseq.Size = new System.Drawing.Size(210, 20);
			this.txt_Qual_Iseq.TabIndex = 217;
			this.txt_Qual_Iseq.Text = "";
			// 
			// cmb_Season_Cd
			// 
			this.cmb_Season_Cd.AddItemCols = 0;
			this.cmb_Season_Cd.AddItemSeparator = ';';
			this.cmb_Season_Cd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Season_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Season_Cd.Caption = "";
			this.cmb_Season_Cd.CaptionHeight = 17;
			this.cmb_Season_Cd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Season_Cd.ColumnCaptionHeight = 18;
			this.cmb_Season_Cd.ColumnFooterHeight = 18;
			this.cmb_Season_Cd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Season_Cd.ContentHeight = 16;
			this.cmb_Season_Cd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Season_Cd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Season_Cd.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Season_Cd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Season_Cd.EditorHeight = 16;
			this.cmb_Season_Cd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Season_Cd.GapHeight = 2;
			this.cmb_Season_Cd.ItemHeight = 15;
			this.cmb_Season_Cd.Location = new System.Drawing.Point(800, 80);
			this.cmb_Season_Cd.MatchEntryTimeout = ((long)(2000));
			this.cmb_Season_Cd.MaxDropDownItems = ((short)(5));
			this.cmb_Season_Cd.MaxLength = 32767;
			this.cmb_Season_Cd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Season_Cd.Name = "cmb_Season_Cd";
			this.cmb_Season_Cd.PartialRightColumn = false;
			this.cmb_Season_Cd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight" +
				";}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:" +
				"True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:" +
				"Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1Lis" +
				"t.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHei" +
				"ght=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"" +
				"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScroll" +
				"Bar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me" +
				"=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Fo" +
				"oter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle pare" +
				"nt=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" " +
				"/><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me" +
				"=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Selecte" +
				"dStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1" +
				".Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><St" +
				"yle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style " +
				"parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style p" +
				"arent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style" +
				" parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style pare" +
				"nt=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedS" +
				"tyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layo" +
				"ut><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Season_Cd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Season_Cd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Season_Cd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Season_Cd.Size = new System.Drawing.Size(210, 20);
			this.cmb_Season_Cd.TabIndex = 216;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label16.Font = new System.Drawing.Font("Verdana", 8F);
			this.label16.ImageIndex = 2;
			this.label16.ImageList = this.img_Label;
			this.label16.Location = new System.Drawing.Point(696, 80);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(100, 21);
			this.label16.TabIndex = 215;
			this.label16.Text = "SEASON_CD";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label9.Font = new System.Drawing.Font("Verdana", 8F);
			this.label9.ImageIndex = 2;
			this.label9.ImageList = this.img_Label;
			this.label9.Location = new System.Drawing.Point(352, 80);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 21);
			this.label9.TabIndex = 214;
			this.label9.Text = "QUAL_ISEQ";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Order_Rsn
			// 
			this.txt_Order_Rsn.BackColor = System.Drawing.Color.White;
			this.txt_Order_Rsn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Order_Rsn.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Order_Rsn.Location = new System.Drawing.Point(112, 80);
			this.txt_Order_Rsn.MaxLength = 20;
			this.txt_Order_Rsn.Name = "txt_Order_Rsn";
			this.txt_Order_Rsn.Size = new System.Drawing.Size(210, 20);
			this.txt_Order_Rsn.TabIndex = 213;
			this.txt_Order_Rsn.Text = "";
			// 
			// lbl_Order_Rsn
			// 
			this.lbl_Order_Rsn.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Order_Rsn.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Order_Rsn.ImageIndex = 2;
			this.lbl_Order_Rsn.ImageList = this.img_Label;
			this.lbl_Order_Rsn.Location = new System.Drawing.Point(8, 80);
			this.lbl_Order_Rsn.Name = "lbl_Order_Rsn";
			this.lbl_Order_Rsn.Size = new System.Drawing.Size(100, 21);
			this.lbl_Order_Rsn.TabIndex = 212;
			this.lbl_Order_Rsn.Text = "ORDER_RSN";
			this.lbl_Order_Rsn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Pur_Grp
			// 
			this.txt_Pur_Grp.BackColor = System.Drawing.Color.White;
			this.txt_Pur_Grp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Pur_Grp.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Pur_Grp.Location = new System.Drawing.Point(455, 56);
			this.txt_Pur_Grp.MaxLength = 10;
			this.txt_Pur_Grp.Name = "txt_Pur_Grp";
			this.txt_Pur_Grp.Size = new System.Drawing.Size(210, 20);
			this.txt_Pur_Grp.TabIndex = 211;
			this.txt_Pur_Grp.Text = "";
			// 
			// txt_Your_Ref
			// 
			this.txt_Your_Ref.BackColor = System.Drawing.Color.White;
			this.txt_Your_Ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Your_Ref.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Your_Ref.Location = new System.Drawing.Point(800, 56);
			this.txt_Your_Ref.MaxLength = 10;
			this.txt_Your_Ref.Name = "txt_Your_Ref";
			this.txt_Your_Ref.Size = new System.Drawing.Size(210, 20);
			this.txt_Your_Ref.TabIndex = 210;
			this.txt_Your_Ref.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label17.Font = new System.Drawing.Font("Verdana", 8F);
			this.label17.ImageIndex = 2;
			this.label17.ImageList = this.img_Label;
			this.label17.Location = new System.Drawing.Point(696, 56);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 21);
			this.label17.TabIndex = 209;
			this.label17.Text = "YOUR_REF";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label10.Font = new System.Drawing.Font("Verdana", 8F);
			this.label10.ImageIndex = 2;
			this.label10.ImageList = this.img_Label;
			this.label10.Location = new System.Drawing.Point(352, 56);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 21);
			this.label10.TabIndex = 208;
			this.label10.Text = "PUR_GRP";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Ref_No
			// 
			this.txt_Ref_No.BackColor = System.Drawing.Color.White;
			this.txt_Ref_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Ref_No.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Ref_No.Location = new System.Drawing.Point(112, 56);
			this.txt_Ref_No.MaxLength = 10;
			this.txt_Ref_No.Name = "txt_Ref_No";
			this.txt_Ref_No.Size = new System.Drawing.Size(210, 20);
			this.txt_Ref_No.TabIndex = 207;
			this.txt_Ref_No.Text = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label5.Font = new System.Drawing.Font("Verdana", 8F);
			this.label5.ImageIndex = 2;
			this.label5.ImageList = this.img_Label;
			this.label5.Location = new System.Drawing.Point(8, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 21);
			this.label5.TabIndex = 206;
			this.label5.Text = "OUR_REF_NO ";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Pur_No
			// 
			this.txt_Pur_No.BackColor = System.Drawing.Color.White;
			this.txt_Pur_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Pur_No.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Pur_No.Location = new System.Drawing.Point(800, 32);
			this.txt_Pur_No.MaxLength = 15;
			this.txt_Pur_No.Name = "txt_Pur_No";
			this.txt_Pur_No.Size = new System.Drawing.Size(210, 20);
			this.txt_Pur_No.TabIndex = 205;
			this.txt_Pur_No.Text = "";
			// 
			// dtp_Chg_Ymd
			// 
			this.dtp_Chg_Ymd.CustomFormat = "yyyy-MM-dd";
			this.dtp_Chg_Ymd.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.dtp_Chg_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_Chg_Ymd.Location = new System.Drawing.Point(455, 32);
			this.dtp_Chg_Ymd.Name = "dtp_Chg_Ymd";
			this.dtp_Chg_Ymd.Size = new System.Drawing.Size(210, 20);
			this.dtp_Chg_Ymd.TabIndex = 204;
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label18.Font = new System.Drawing.Font("Verdana", 8F);
			this.label18.ImageIndex = 2;
			this.label18.ImageList = this.img_Label;
			this.label18.Location = new System.Drawing.Point(696, 32);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(100, 21);
			this.label18.TabIndex = 203;
			this.label18.Text = "PUR_NO";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label11.Font = new System.Drawing.Font("Verdana", 8F);
			this.label11.ImageIndex = 2;
			this.label11.ImageList = this.img_Label;
			this.label11.Location = new System.Drawing.Point(352, 32);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 21);
			this.label11.TabIndex = 202;
			this.label11.Text = "CHG_YMD";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_OA_Div
			// 
			this.cmb_OA_Div.AddItemCols = 0;
			this.cmb_OA_Div.AddItemSeparator = ';';
			this.cmb_OA_Div.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OA_Div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OA_Div.Caption = "";
			this.cmb_OA_Div.CaptionHeight = 17;
			this.cmb_OA_Div.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OA_Div.ColumnCaptionHeight = 18;
			this.cmb_OA_Div.ColumnFooterHeight = 18;
			this.cmb_OA_Div.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OA_Div.ContentHeight = 16;
			this.cmb_OA_Div.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OA_Div.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OA_Div.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OA_Div.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OA_Div.EditorHeight = 16;
			this.cmb_OA_Div.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OA_Div.GapHeight = 2;
			this.cmb_OA_Div.ItemHeight = 15;
			this.cmb_OA_Div.Location = new System.Drawing.Point(112, 32);
			this.cmb_OA_Div.MatchEntryTimeout = ((long)(2000));
			this.cmb_OA_Div.MaxDropDownItems = ((short)(5));
			this.cmb_OA_Div.MaxLength = 32767;
			this.cmb_OA_Div.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OA_Div.Name = "cmb_OA_Div";
			this.cmb_OA_Div.PartialRightColumn = false;
			this.cmb_OA_Div.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight" +
				";}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:" +
				"True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:" +
				"Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1Lis" +
				"t.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHei" +
				"ght=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"" +
				"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScroll" +
				"Bar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me" +
				"=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Fo" +
				"oter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle pare" +
				"nt=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" " +
				"/><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me" +
				"=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Selecte" +
				"dStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1" +
				".Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><St" +
				"yle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style " +
				"parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style p" +
				"arent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style" +
				" parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style pare" +
				"nt=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedS" +
				"tyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layo" +
				"ut><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_OA_Div.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OA_Div.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OA_Div.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OA_Div.Size = new System.Drawing.Size(210, 20);
			this.cmb_OA_Div.TabIndex = 200;
			// 
			// Form_OA_CRT01
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Search);
			this.Font = new System.Drawing.Font("Verdana", 8F);
			this.Name = "Form_OA_CRT01";
			this.Load += new System.EventHandler(this.Form_OA_CRT01_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_Search1_Image.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			this.pnl_Right.ResumeLayout(false);
			this.gb_styletail_infol.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fsp_Stylebal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fsp_Styletail)).EndInit();
			this.pnl_Left.ResumeLayout(false);
			this.gb_style_info.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fsp_Style)).EndInit();
			this.pnl_Bottom.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_OA_Nu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OA_OBS_Div)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season_Year)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season_Cd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OA_Div)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의

		int     _Rowfixed = 2;
		string   _Style_Cd =" ", _Division = "I";

		private ClassLib.OraDB  MyOraDB = new ClassLib.OraDB();
		private ClassLib.OraDB  MyClassLib = new ClassLib.OraDB();
		private COM.ComFunction MyComFunction    = new COM.ComFunction();

		#endregion

		#region 멤버 메서드 
		private void Init_Form()
		{ 
			DataTable dt_list;

			//Setting  Title
			this.Text = "OBS OA Creation";
			this.lbl_MainTitle.Text = "OBS OA Creation"; 
			ClassLib.ComFunction.SetLangDic(this);

			#region 버튼 권한

//			try
//			{
//				COM.OraDB btn_control = new COM.OraDB();
//				DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
//				tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
//				btn_control = null;
//
//				//Button 활성화
//				tbtn_Insert.Enabled = false;    tbtn_Append.Enabled = false;  tbtn_Print.Enabled = false;   	
//				
//			}
//			catch
//			{
//			}

			#endregion		

			#region 그리드 적용
			//Setting Grid(TBSEM_OA04)
			fsp_Style.Set_Grid( "SEM_OA", "4", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
			fsp_Style.Rows.Count = _Rowfixed;
			fsp_Style.Font = new Font("Verdana",8);

			//Setting Grid(TBSEM_OA05) 
			fsp_Styletail.Set_Grid(  "SEM_OA", "5", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
			fsp_Styletail.Rows.Count = _Rowfixed;
			fsp_Styletail.Font = new Font("Verdana",8);
			fsp_Styletail.Set_Action_Image(img_Action); 


			//Setting Grid(TBSEM_OA06) 
			fsp_Stylebal.Set_Grid(  "SEM_OA", "6", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
			fsp_Stylebal.Rows.Count = _Rowfixed;
			fsp_Stylebal.Font = new Font("Verdana",8);

            #endregion 

			//Setting Factory Combo
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			//Setting Po Type
			dt_list = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(),"SEM10");
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OBS_Type, 1, 2); 
			cmb_OBS_Type.SelectedValue = ClassLib.ComVar.ConsType;	

			//Setting obs div
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory,"SEM05");
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OA_OBS_Div, 1, 2); 
			cmb_OA_OBS_Div.SelectedValue = "01";

			//Setting OA Div
			dt_list = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(),"SEM06");
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OA_Div, 1, 2); 
			cmb_OA_Div.SelectedIndex = -1;
            
			//Setting Season
			dt_list = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(),"SEM15");
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Season_Cd, 1, 2);
			cmb_Season_Cd.SelectedValue = "SP";

			//Date
			dtp_Chg_Ymd.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			string now  = System.DateTime.Now.ToString("yyyyMMdd");
			dtp_Chg_Ymd.Text = MyComFunction.ConvertDate2Type(now);

			dtp_OA_Ymd.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			now  = System.DateTime.Now.ToString("yyyyMMdd");
			dtp_OA_Ymd.Text = MyComFunction.ConvertDate2Type(now);


			ClassLib.ComFunction.Set_Year(cmb_Season_Year);

			SB_Init();

		}


		

		private void SB_Init()
		{
			txt_OA_Nu.Text				   = "";
			cmb_OA_Nu.ClearItems();

			cmb_OA_Div.SelectedValue       =  cmb_OA_Div.SelectedIndex = -1;
			dtp_OA_Ymd.Text                = System.DateTime.Now.ToString("yyyy-MM-dd");

			dtp_Chg_Ymd.Text               = System.DateTime.Now.ToString("yyyy-MM-dd");
			txt_Pur_No.Text				   = "";
			txt_Ref_No.Text				   = ""; 

			txt_Pur_Grp.Text               = "";
			txt_Your_Ref.Text			   = ""; 
			txt_Order_Rsn.Text			   = ""; 

			txt_Qual_Iseq.Text             = ""; 
			cmb_Season_Cd.Text			   = ""; 
			cmb_Season_Year.Text		   = ""; 

			txt_Remarks.Text               = ""; 

		}

		private bool Check_Save()
		{
			try
			{
				int iCnt  = 0 ; 


				//이번에 걸리는 OA대상의 모든 OBS_NU, OBS_SEQ_NU, CHG_NU에
				//해당 하는 것 중에 생산계획에 반영이 안된것이 있다면 새로운
				//OA발행 불가능....
				//이 경우 앞의 OA를 생산 계획에서 적용 완료하여만 새로운
				//OA를 발행할 수 있다
	
				if (!Check_Plan_Staus())   //만들기
				{
					MessageBox.Show("Not Apply Order adjust in Plan !!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning) ;
					return false;
				}
			





				//I Flag가 없는 경우 무조건 Error : 계획과의 협의 사항
				for (int i =_Rowfixed; i<fsp_Stylebal.Rows.Count ;i++)
				{	
					if (fsp_Stylebal[i,(int)ClassLib.TBSEM_OA06.lxJOB].ToString()
						== ClassLib.ComVar.ConsJob_I)
						iCnt  ++;
				
				}

				if (iCnt  == 0) 
				{
					MessageBox.Show("Job Flag Error!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning) ;
					return false;

				}

				return true;
			}
			catch
			{
					ClassLib.ComFunction.Data_Message (ClassLib.ComVar.MgsEndSearch,this);
					return false;
			}

		}


	
		private bool  Check_Plan_Staus()
		{

			try
			{
			
				DataTable dt_list; 

			   //miyoung
				string  sResult = ClassLib.ComVar.ConsReal_Y;
			 
				for (int i  = _Rowfixed+1; i < fsp_Stylebal.Rows.Count  ;i++)
				{


					dt_list =   Check_Order_Row(
								cmb_Factory.SelectedValue.ToString(),
								cmb_OBS_ID.Text,
								cmb_OBS_Type.SelectedValue.ToString(),
								fsp_Stylebal[i,(int)ClassLib.TBSEM_OA06.lxOBS_NU].ToString(),
								fsp_Stylebal[i,(int)ClassLib.TBSEM_OA06.lxOBS_SEQ_NU].ToString(),
								fsp_Stylebal[i,(int)ClassLib.TBSEM_OA06.lxCHG_NU ].ToString()
						);   //조회결과 넣기

					if (dt_list.Rows[0].ItemArray[0].ToString()  !=ClassLib.ComVar.ConsCFM_P) 
					{
						sResult  = ClassLib.ComVar.ConsReal_N;
						break;
					}

				}

				if( sResult  == "Y")
					return true;
			    else
					return false;


			}
			catch
			{

				return false;

			}

		}



		private DataTable  Check_Order_Row( string  arg_factory,    string arg_obs_id, 
										string  arg_obs_type,  string  arg_obs_nu, 
										string  arg_obs_seq_nu, string arg_chg_nu)
		{
			
			DataSet ds_ret;

			string process_name = "PKG_SEM_OA_CRT01.CHECK_SEM_OBS_OA";

			MyOraDB.ReDim_Parameter(7); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[3]  = "ARG_OBS_NU";
			MyOraDB.Parameter_Name[4]  = "ARG_OBS_SEQ_NU";
			MyOraDB.Parameter_Name[5]  = "ARG_CHG_NU";
			MyOraDB.Parameter_Name[6]  = "OUT_CURSOR";


			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = arg_factory;
			MyOraDB.Parameter_Values[1]  = arg_obs_id;
			MyOraDB.Parameter_Values[2]  = arg_obs_type;
			MyOraDB.Parameter_Values[3]  = arg_obs_nu;
			MyOraDB.Parameter_Values[4]  = arg_obs_seq_nu;
			MyOraDB.Parameter_Values[5]  = arg_chg_nu;
			MyOraDB.Parameter_Values[6]  = "";

			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 


		}
	
		private void Sb_Style_Info()
		{
			DataTable dt_list;

			dt_list = Select_Style_Info();

			if (dt_list.Rows.Count  == 0) 
			{ ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch); return;}

			Display_Style_Info(dt_list);
			ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch,this);
		}


		private void Sb_Style_Tail()
		{

			DataTable dt_list;
            
			//Style code 할당하기
			if (_Style_Cd == " ")
			{
				for (int i = 0; i<fsp_Style.Rows.Count  ;i++)
					if ( fsp_Style[i,(int)ClassLib.TBSEM_OA04.IxSTYLE_CD].ToString().Length == 9)
						_Style_Cd = fsp_Style[i,(int)ClassLib.TBSEM_OA04.IxSTYLE_CD].ToString();
			}
			else
				_Style_Cd = fsp_Style[fsp_Style.Selection.r1,(int)ClassLib.TBSEM_OA04.IxSTYLE_CD].ToString();


            fsp_Styletail.Rows.Count  = _Rowfixed;
			fsp_Stylebal.Rows.Count   = _Rowfixed;
			
			if(fsp_Style[fsp_Style.Selection.r1,(int)ClassLib.TBSEM_OA04.IxSTYLE_CD] == null) return;

			dt_list = Select_Style_Tail();

			if (dt_list.Rows.Count  == 0) 
			{ ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch); return;}

			Display_Style_Tail(dt_list);
			ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch,this);
		}


		private void Display_OA(DataTable arg_dt)
		{ 

			cmb_OA_OBS_Div.SelectedValue   =  arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA.IxOA_OBS_DIV-1].ToString();
			//cmb_OA_OBS_Div.Text          =  arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA.IxOBS_DIV-1].ToString();
			cmb_OA_Div.SelectedValue       =  arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA.IxOA_DIV-1].ToString();
			dtp_OA_Ymd.Text                =  ClassLib.ComFunction.Convert_ToDate(arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA.IxOA_YMD-1].ToString()).ToString();

			dtp_Chg_Ymd.Text               =  ClassLib.ComFunction.Convert_ToDate(arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA.IxCHG_YMD-1].ToString()).ToString();
			txt_Pur_No.Text				   =  arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA.IxPUR_NO-1].ToString();
			txt_Ref_No.Text				   =  arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA.IxOUR_REF_NO-1].ToString();

			txt_Pur_Grp.Text               =  arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA.IxPUR_GRP-1].ToString();
			txt_Your_Ref.Text			   =  arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA.IxYOUR_REF-1].ToString();
			txt_Order_Rsn.Text			   =  arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA.IxORDER_RSN-1].ToString();

			txt_Qual_Iseq.Text             =  arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA.IxQUAL_ISEQ-1].ToString();
			cmb_Season_Cd.Text			   =  arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA.IxSEASON_CD-1].ToString();
			cmb_Season_Year.Text		   =  arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA.IxSEASON_YEAR-1].ToString();

			txt_Remarks.Text               =  arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSEM_OBS_OA.IxREMARKS-1].ToString();
		}


		private  void Display_Style_Info(DataTable dt_list)
		{
			fsp_Style.Rows.Count = _Rowfixed;  

			// Set List
			for(int i = 0; i < dt_list.Rows.Count; i++)
			{
				fsp_Style.AddItem(dt_list.Rows[i].ItemArray, fsp_Style.Rows.Count, 1);
				
			} 
   
			fsp_Style.Cols[0].Width = 0;
			fsp_Style.Cols[(int)ClassLib.TBSEM_OA04.IxSTYLE_CD].Width = 110;

			Sub_Total();


		}


		/// <summary>
		/// Sb_Check_Job : Correct Job Verification
		/// </summary>
		private  void Sb_Check_Job()
		{

			int iRow = fsp_Styletail.Selection.r1;

			if (fsp_Styletail[iRow,(int)ClassLib.TBSEM_OA05.IxJOB_DIV].ToString()=="N") return;

			if( (fsp_Styletail[iRow,(int)ClassLib.TBSEM_OA05.IxJOB_DIV].ToString()=="D") &&
				(fsp_Styletail[iRow,(int)ClassLib.TBSEM_OA05.IxOA_NU_BEF].ToString()!="__________"))
			{
				MessageBox.Show("Impossible data to delete (Deletion Aready!!)",	"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning) ;
				fsp_Styletail[iRow,(int)ClassLib.TBSEM_OA05.IxJOB_DIV]="N";
			}

			
			if( (fsp_Styletail[iRow,(int)ClassLib.TBSEM_OA05.IxJOB_DIV].ToString()=="I") &&
				(fsp_Styletail[iRow,(int)ClassLib.TBSEM_OA05.IxOA_NU_AFT].ToString()!="__________"))
			{
				MessageBox.Show("Impossible data to insert (Insertion Aready!!)",	"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning) ;
				fsp_Styletail[iRow,(int)ClassLib.TBSEM_OA05.IxJOB_DIV]="N";
			}

		}

		/// <summary>
		/// Sb_Set_OA_Div : Setting OBS OA Division
		/// </summary>
		private  void Sb_Set_OA_Div()
		{
			string sCS ="N", sNike ="N";

			for (int i=_Rowfixed; i < fsp_Styletail.Rows.Count ; i++)
			{
				if (fsp_Styletail[i,(int)ClassLib.TBSEM_OA05.IxJOB_DIV].ToString()=="N") continue;

				if (fsp_Styletail[i,(int)ClassLib.TBSEM_OA05.IxOBS_NU].ToString().Substring(0,1)=="C")
					sCS ="Y";

				if (fsp_Styletail[i,(int)ClassLib.TBSEM_OA05.IxOBS_NU].ToString().Substring(0,1)!="C") 
					sNike ="Y";

			}		

		
			if((sCS =="Y") && (sNike=="N"))   cmb_OA_OBS_Div.SelectedValue  = "01";
			if((sCS =="Y") && (sNike=="Y"))   cmb_OA_OBS_Div.SelectedValue  = "02";
			if((sCS =="N") && (sNike=="Y"))   cmb_OA_OBS_Div.SelectedValue  = "03";
             
		}



		private  void Display_Style_Tail(DataTable arg_dt)
		{
			fsp_Styletail.Rows.Count = _Rowfixed;
  
			
			//Size Run Setting
			int colfixed = (int)ClassLib.TBSEM_OA05.IxCS_SIZE; Sb_Set_Size(fsp_Styletail,colfixed);
			    colfixed = (int)ClassLib.TBSEM_OA06.lxCS_SIZE; Sb_Set_Size(fsp_Stylebal, colfixed);
			

			//Size 별 수량 Setting
			int iOBS_NU     = (int)ClassLib.TBSEM_OA05.IxOBS_NU;
			int iOBS_SEQ_NU = (int)ClassLib.TBSEM_OA05.IxOBS_SEQ_NU;
			int iCHG_NU     = (int)ClassLib.TBSEM_OA05.IxCHG_NU;
			int iGEN        = (int)ClassLib.TBSEM_OA05.IxGEN;
			int iCS_SIZE    = (int)ClassLib.TBSEM_OA05.IxCS_SIZE;
			int iQTY        = (int)ClassLib.TBSEM_OA05.IxORD_QTY;

			//merge
			fsp_Styletail.AllowMerging = AllowMergingEnum.Free;
			for (int j=(int)ClassLib.TBSEM_OA05.IxFACTORY ; j<=(int)ClassLib.TBSEM_OA05.IxGEN;j++)
				fsp_Styletail.Cols[j].AllowMerging = true;
			fsp_Styletail.Cols[(int)ClassLib.TBSEM_OA05.IxJOB_DIV].AllowMerging = false;

			//Size Setting
			for(int i=0; i<arg_dt.Rows.Count; i++)
			{
				string sOBS_NU     = arg_dt.Rows[i].ItemArray[iOBS_NU-1].ToString();
				string sOBS_SEQ_NU = arg_dt.Rows[i].ItemArray[iOBS_SEQ_NU-1].ToString();
				string sCHG_NU     = arg_dt.Rows[i].ItemArray[iCHG_NU-1].ToString();					
				string sSIZE       = arg_dt.Rows[i].ItemArray[iCS_SIZE-1].ToString();
				string sQTY        = arg_dt.Rows[i].ItemArray[iQTY-1].ToString();

				if (( fsp_Styletail.Rows.Count == _Rowfixed ) ||
					( sOBS_NU     != fsp_Styletail[fsp_Styletail.Rows.Count-1, iOBS_NU].ToString()     ) || 
					( sOBS_SEQ_NU != fsp_Styletail[fsp_Styletail.Rows.Count-1, iOBS_SEQ_NU].ToString() ) || 
					( sCHG_NU     != fsp_Styletail[fsp_Styletail.Rows.Count-1, iCHG_NU].ToString()     )  )
				{
					fsp_Styletail.AddItem(arg_dt.Rows[i].ItemArray, fsp_Styletail.Rows.Count, 1);
					fsp_Styletail[fsp_Styletail.Rows.Count-1, iCS_SIZE] = " ";
					fsp_Styletail[fsp_Styletail.Rows.Count-1, iQTY ] = " ";
					fsp_Styletail[fsp_Styletail.Rows.Count-1,0 ] = " ";

											
				}

				for(int j=iGEN; j<fsp_Styletail.Cols.Count; j++)
				{
					if (fsp_Styletail[1, j].ToString() == sSIZE)
					{
						fsp_Styletail[fsp_Styletail.Rows.Count-1, j] = sQTY;
						fsp_Styletail.LeftCol = Convert.ToInt32(fsp_Styletail.Cols.Count/2);
						break;
					}
				}

			} 
			
			fsp_Styletail.Cols[0].Width = 0;
 

		}


		//생성후 oa  balance sheet
		private  void Display_OA_Rel(DataTable arg_dt)
		{
			fsp_Stylebal .Rows.Count = _Rowfixed;
  		
			//Size 별 수량 Setting
			int iOBS_NU     = (int)ClassLib.TBSEM_OA06.lxOBS_NU;
			int iOBS_SEQ_NU = (int)ClassLib.TBSEM_OA06.lxOBS_SEQ_NU;
			int iCHG_NU     = (int)ClassLib.TBSEM_OA06.lxCHG_NU;
			int iGEN        = (int)ClassLib.TBSEM_OA06.lxGEN;
			int iCS_SIZE    = (int)ClassLib.TBSEM_OA06.lxCS_SIZE;
			int iQTY        = (int)ClassLib.TBSEM_OA06.lxORD_QTY;

			//merge
			for(int i=0; i<arg_dt.Rows.Count; i++)
			{
				string sOBS_NU     = arg_dt.Rows[i].ItemArray[iOBS_NU-1].ToString();
				string sOBS_SEQ_NU = arg_dt.Rows[i].ItemArray[iOBS_SEQ_NU-1].ToString();
				string sCHG_NU     = arg_dt.Rows[i].ItemArray[iCHG_NU-1].ToString();					
				string sSIZE       = arg_dt.Rows[i].ItemArray[iCS_SIZE-1].ToString();
				string sQTY        = arg_dt.Rows[i].ItemArray[iQTY-1].ToString();

				if (( fsp_Stylebal .Rows.Count == _Rowfixed ) ||
					( sOBS_NU     != fsp_Stylebal [fsp_Stylebal .Rows.Count-1, iOBS_NU].ToString()     ) || 
					( sOBS_SEQ_NU != fsp_Stylebal [fsp_Stylebal .Rows.Count-1, iOBS_SEQ_NU].ToString() ) || 
					( sCHG_NU     != fsp_Stylebal [fsp_Stylebal .Rows.Count-1, iCHG_NU].ToString()     )  )
				{
					fsp_Stylebal .AddItem(arg_dt.Rows[i].ItemArray, fsp_Stylebal .Rows.Count, 1);
					fsp_Stylebal [fsp_Stylebal .Rows.Count-1, iCS_SIZE] = " ";
					fsp_Stylebal [fsp_Stylebal .Rows.Count-1, iQTY ] = " ";
					fsp_Stylebal [fsp_Stylebal .Rows.Count-1,0 ] = " ";

											
				}

				for(int j=iGEN; j<fsp_Stylebal .Cols.Count; j++)
				{
					if (fsp_Stylebal [1, j].ToString() == sSIZE)
					{
						fsp_Stylebal [fsp_Stylebal .Rows.Count-1, j] = sQTY;
						fsp_Stylebal .LeftCol = Convert.ToInt32(fsp_Stylebal .Cols.Count/2);
						break;
					}
				}

			} 
			

			Sub_Total_Bal();
		}


		//생성전 oa  balance sheet
		private  void Display_Balance(DataTable arg_dt)
		{
			int iGEN        = (int)ClassLib.TBSEM_OA06.lxGEN;
			int iCS_SIZE    = (int)ClassLib.TBSEM_OA06.lxCS_SIZE;
			int iQTY        = (int)ClassLib.TBSEM_OA06.lxORD_QTY;
			
			for(int i=0; i<arg_dt.Rows.Count; i++)
			{
				//merge
				fsp_Stylebal.AllowMerging = AllowMergingEnum.Free;
				if (i<= (int)ClassLib.TBSEM_OA06.lxJOB)
					fsp_Stylebal.Cols[i].AllowMerging = true;
				fsp_Stylebal.Cols[(int)ClassLib.TBSEM_OA06.lxGEN].AllowMerging = true;

				string sSIZE       = arg_dt.Rows[i].ItemArray[iCS_SIZE-1].ToString();
				string sQTY        = arg_dt.Rows[i].ItemArray[iQTY-1].ToString();
				if (i==0)
				{
					fsp_Stylebal.AddItem(arg_dt.Rows[i].ItemArray, fsp_Stylebal.Rows.Count, 1);
					fsp_Stylebal[fsp_Stylebal.Rows.Count-1, iCS_SIZE] = " ";
					fsp_Stylebal[fsp_Stylebal.Rows.Count-1, iQTY ] = " ";						
				}

				for(int j=iGEN; j<fsp_Stylebal.Cols.Count; j++)
				{
					if (fsp_Stylebal[1, j].ToString() == sSIZE)
					{
						fsp_Stylebal[fsp_Stylebal.Rows.Count-1, j] = sQTY;
						fsp_Stylebal.LeftCol = Convert.ToInt32(fsp_Stylebal.Cols.Count/2);
						break;
					}
				}

			} 
			


			fsp_Stylebal.Cols[0].Width = 0;
 

		}


		private void Sb_Set_Size(C1FlexGrid arg_fgrid, int arg_colfixed)
		{  
			DataTable dt_list;

			string  sGen=fsp_Style[fsp_Style.Selection.r1,(int)ClassLib.TBSEM_OA04.IxGEN].ToString();
			string  sPst=fsp_Style[fsp_Style.Selection.r1,(int)ClassLib.TBSEM_OA04.IxPST_YN].ToString();

			//16,7
			arg_fgrid.Cols.Count  = arg_colfixed;

			dt_list = MyClassLib.Select_Gen_Size(cmb_Factory.SelectedValue.ToString(),
				sGen,sPst);

			if (dt_list == null) return;

			arg_fgrid.Cols.Count   =  arg_fgrid.Cols.Count + dt_list.Rows.Count;
			for (int i = 0; i < dt_list.Rows.Count; i++)
			{
				arg_fgrid[1,arg_colfixed+i] =dt_list.Rows[i].ItemArray[0];
				arg_fgrid.Cols[arg_colfixed+i].Width = 50;
				
			}

			arg_fgrid.GetCellRange(1,arg_colfixed,1,arg_fgrid.Cols.Count-1).StyleNew.BackColor
				= ClassLib.ComVar.Clr_Head_RYellow;           

		}


		private  void Sub_Total()
		{   
			CellStyle cStyle = fsp_Style.Styles[CellStyleEnum.Subtotal0];
			cStyle.Font = new Font(fsp_Style.Font , FontStyle.Bold);

			//Subtotal Area
			int iFactory		=  (int)ClassLib.TBSEM_OA04.IxFACTORY;;
			int iSTYLE_CD		=  (int)ClassLib.TBSEM_OA04.IxSTYLE_CD;
			int iTOT_QTY		=  (int)ClassLib.TBSEM_OA04.IxTOT_QTY;
			

			fsp_Style.SubtotalPosition = SubtotalPositionEnum.AboveData;
			fsp_Style.Tree.Column = iSTYLE_CD;
			fsp_Style.Cols[iTOT_QTY].TextAlign = TextAlignEnum.RightCenter;
			fsp_Style.Cols[iTOT_QTY].Format     =  "###,###,###";

			fsp_Style.Subtotal(AggregateEnum.Sum, iFactory, iFactory, (int)ClassLib.TBSEM_OA04.IxTOT_QTY,"Grand Total");
			fsp_Style.Styles[CellStyleEnum.Subtotal1].BackColor  = ClassLib.ComVar.ClrTransparent ;
			fsp_Style.Styles[CellStyleEnum.Subtotal1].ForeColor  = ClassLib.ComVar.Clr_Text_Red;
			fsp_Style.Styles[CellStyleEnum.Subtotal1].Font       = cStyle.Font;


		}


		private void  Sb_Set_Balance()
		{  

			DataTable dt_list;
			fsp_Stylebal.Rows.Count = _Rowfixed;

			for (int i  = _Rowfixed ; i< fsp_Styletail.Rows.Count  ; i++)
				if(fsp_Styletail[i,fsp_Styletail.Selection.c1].ToString() 
					== ClassLib.ComVar.ConsJob_D) 
				{
					dt_list  = Select_Bal_List(i);
					Display_Balance(dt_list);
				}

			for (int i  = _Rowfixed ; i< fsp_Styletail.Rows.Count  ; i++)
				if(fsp_Styletail[i,fsp_Styletail.Selection.c1].ToString() 
					== ClassLib.ComVar.ConsJob_I) 
				{
					dt_list  = Select_Bal_List(i);
					Display_Balance(dt_list);
				}

			Sub_Total_Bal();


		}

		
		private void  Sub_Total_Bal()
		{  
			//Subtotal
			fsp_Stylebal.SubtotalPosition = SubtotalPositionEnum.AboveData;
			fsp_Stylebal.Tree.Column = (int)ClassLib.TBSEM_OA06.lxJOB;

			fsp_Stylebal.Cols[(int)ClassLib.TBSEM_OA06.lxTOT_QTY].TextAlign = TextAlignEnum.RightCenter;
			fsp_Stylebal.Cols[(int)ClassLib.TBSEM_OA06.lxTOT_QTY].Format     =  "###,###,###";

			int iFactory = (int)ClassLib.TBSEM_OA06.lxFACTORY;
			for (int c = (int)ClassLib.TBSEM_OA06.lxTOT_QTY; c <fsp_Stylebal.Cols.Count; c++)
			{                      
				fsp_Stylebal.Subtotal(AggregateEnum.Sum, iFactory, iFactory, c, "+/- ");
				fsp_Stylebal.Styles[CellStyleEnum.Subtotal1].BackColor  =  ClassLib.ComVar.ClrTransparent;
				fsp_Stylebal.Styles[CellStyleEnum.Subtotal1].ForeColor  =  ClassLib.ComVar.Clr_Text_Red;
//				fsp_Stylebal.GetCellRange(_Rowfixed,(int)ClassLib.TBSEM_OA06.lxFACTORY,_Rowfixed,fsp_Stylebal.Cols.Count -1).StyleNew.Font
//						= new Font(fsp_Stylebal.Font , FontStyle.Bold);
				

			}
		}


		private void SB_Pop_CFM(string arg_OA_Nu)
		{

			FlexOrder.ExpOA.Form_OA_CFM  pop_form = new ExpOA.Form_OA_CFM();
			COM.ComVar.Parameter_PopUp = new string[] 
			{
				cmb_Factory.SelectedValue.ToString(),
				fsp_Styletail[fsp_Styletail.Selection.r1,(int)ClassLib.TBSEM_OA05.IxOBS_ID].ToString(),
				fsp_Styletail[fsp_Styletail.Selection.r1,(int)ClassLib.TBSEM_OA05.IxOBS_TYPE].ToString(),
				fsp_Style[fsp_Style.Selection.r1,(int)ClassLib.TBSEM_OA04.IxSTYLE_CD].ToString(),
				txt_OA_Nu.Text,
				fsp_Style[fsp_Style.Selection.r1,(int)ClassLib.TBSEM_OA04.IxGEN].ToString(),
				fsp_Style[fsp_Style.Selection.r1,(int)ClassLib.TBSEM_OA04.IxPST_YN].ToString(),
				arg_OA_Nu
			};
			 
			pop_form.ShowDialog();
		}



		#endregion

		#region DB 컨트롤

		private DataTable Make_OA_Nu()
		{
			string strJob;
 
			DataSet ret; 

			MyOraDB.ReDim_Parameter(2); 
            
			strJob  = "PKG_SEM_OA_CRT01.MAKE_SEM_OA_NU";
			MyOraDB.Process_Name =strJob;
			
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR"; 
				
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
	
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = "";
				
			MyOraDB.Add_Select_Parameter(true); 
			ret = MyOraDB.Exe_Select_Procedure();
			
			//setting grid
			if(ret == null) 
			{
				MessageBox.Show("Error");
				return null;
			}
			else
			{
				return ret.Tables[strJob];
			}
			
		}


//		private DataTable Select_Style_Info()
//		{
//			DataSet ds_ret;
//
//			string process_name = "PKG_SEM_OA_CRT01.SELECT_SEM_OBS_STYLE";
//
//			MyOraDB.ReDim_Parameter(5); 
//
//			//01.PROCEDURE명
//			MyOraDB.Process_Name = process_name;
//
//			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
//			MyOraDB.Parameter_Name[1]  = "ARG_OBS_ID";
//			MyOraDB.Parameter_Name[2]  = "ARG_OBS_TYPE";
//			MyOraDB.Parameter_Name[3]  = "ARG_STYLE_CD";
//			MyOraDB.Parameter_Name[4]  = "OUT_CURSOR";
//
//			//03.DATA TYPE
//			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
//			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
//			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
//			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
//			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;
//
//			//04.DATA 정의  
//			MyOraDB.Parameter_Values[0]  = cmb_Factory.SelectedValue.ToString();
//			MyOraDB.Parameter_Values[1]  = cmb_OBS_ID.Text.ToString();
//			MyOraDB.Parameter_Values[2]  = cmb_OBS_Type.SelectedValue.ToString();
//			MyOraDB.Parameter_Values[3]  = ClassLib.ComFunction.Empty_Combo(cmb_Style," ");
//			MyOraDB.Parameter_Values[4]  = "";
//			
//			MyOraDB.Add_Select_Parameter(true);
// 
//			ds_ret = MyOraDB.Exe_Select_Procedure();
//
//			if(ds_ret == null) return null ;
//			
//			return ds_ret.Tables[process_name]; 
//
//		}


		
		private DataTable Select_Style_Info()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_OA_CRT01.SELECT_SEM_OBS_STYLE";

			MyOraDB.ReDim_Parameter(5); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[3]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]  = cmb_OBS_ID.Text.ToString();
			MyOraDB.Parameter_Values[2]  = cmb_OBS_Type.SelectedValue.ToString();
			MyOraDB.Parameter_Values[3]  = ClassLib.ComFunction.Empty_Combo(cmb_Style," ");
			MyOraDB.Parameter_Values[4]  = "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}


		private DataTable Select_Style_Tail()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_OA_CRT01.SELECT_SEM_OBS_SIZE";

			MyOraDB.ReDim_Parameter(5); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[3]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]  = cmb_OBS_ID.Text.ToString();
			MyOraDB.Parameter_Values[2]  = cmb_OBS_Type.SelectedValue.ToString();
			MyOraDB.Parameter_Values[3]  = fsp_Style[fsp_Style.Selection.r1,(int)ClassLib.TBSEM_OA04.IxSTYLE_CD].ToString();
			MyOraDB.Parameter_Values[4]  = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}


		private DataTable Select_Bal_List(int arg_row)
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_OA_CRT01.SELECT_SEM_OBS_SIZEBAL";
       
			MyOraDB.ReDim_Parameter(6); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OBS_NU";
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_SEQ_NU";
			MyOraDB.Parameter_Name[3]  = "ARG_CHG_NU";
			MyOraDB.Parameter_Name[4]  = "ARG_JOB";
			MyOraDB.Parameter_Name[5]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			int  iRow = arg_row;

			MyOraDB.Parameter_Values[0]  = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]  = fsp_Styletail[iRow,(int)ClassLib.TBSEM_OA05.IxOBS_NU].ToString();
			MyOraDB.Parameter_Values[2]  = fsp_Styletail[iRow,(int)ClassLib.TBSEM_OA05.IxOBS_SEQ_NU].ToString();
			MyOraDB.Parameter_Values[3]  = fsp_Styletail[iRow,(int)ClassLib.TBSEM_OA05.IxCHG_NU].ToString();
			MyOraDB.Parameter_Values[4]  = fsp_Styletail[iRow,(int)ClassLib.TBSEM_OA05.IxJOB_DIV].ToString();
			MyOraDB.Parameter_Values[5]  = "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}



		
			
		private void Select_OA_Rel()
		{
			string strJob;
 
			DataSet ret;  DataTable  dt_list;

			int iCnt = 5;
			MyOraDB.ReDim_Parameter(iCnt); 
            
			strJob  = "PKG_SEM_OA_CRT01.SELECT_SEM_OBS_OABAL";
			MyOraDB.Process_Name =strJob;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[3] = "ARG_OA_NU";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR"; 
			
			for(int i = 0; i<iCnt; i++)
			{MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;}
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
	
			MyOraDB.Parameter_Values[0] = fsp_Styletail[fsp_Styletail.Selection.r1,
													(int)ClassLib.TBSEM_OA05.IxFACTORY].ToString(); 
			MyOraDB.Parameter_Values[1] = fsp_Styletail[fsp_Styletail.Selection.r1,
													(int)ClassLib.TBSEM_OA05.IxOBS_ID].ToString(); 
			MyOraDB.Parameter_Values[2] = fsp_Styletail[fsp_Styletail.Selection.r1,
													(int)ClassLib.TBSEM_OA05.IxOBS_TYPE].ToString();
			MyOraDB.Parameter_Values[3] = txt_OA_Nu.Text ;

			MyOraDB.Parameter_Values[4] = "";
				
			MyOraDB.Add_Select_Parameter(true); 
			ret = MyOraDB.Exe_Select_Procedure();
			
			//setting grid
			if(ret == null) 
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch,this);
			}
			else
			{
				dt_list =  ret.Tables[strJob];
				Display_OA_Rel(dt_list);
				
			}
			
		}

		private void Select_OA ()
		{
			string strRlt;
 
			DataSet ret; DataTable dt_list;

			MyOraDB.ReDim_Parameter(4); 
            
			strRlt  = "PKG_SEM_OA_CRT01.SELECT_SEM_OBS_OA";
			MyOraDB.Process_Name =strRlt;

			MyOraDB.Parameter_Name[0] = "ARG_DIV";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_OA_NU";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR"; 
				
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
	
			MyOraDB.Parameter_Values[0] = "00";
			MyOraDB.Parameter_Values[1] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = txt_OA_Nu.Text ;
			MyOraDB.Parameter_Values[3] = "";
				

			MyOraDB.Add_Select_Parameter(true); 
			ret = MyOraDB.Exe_Select_Procedure();

			if(ret == null) 
			{
				return ;
			}
			else
			{
				dt_list =  ret.Tables[strRlt];
				Display_OA(dt_list);
			}

		}


	
		private bool Save_OA_List( )
		{
			int intParm;			

			DataSet ret;

			#region SAVE_SEM_OBS_OA		

			//OA NO 만들기
			if (_Division == "I") 
			{
				DataTable dt_list;
				dt_list = Make_OA_Nu();
				txt_OA_Nu.Text= Convert.ToString(dt_list.Rows[0].ItemArray[0]);
			}

			intParm = 23;
			MyOraDB.ReDim_Parameter(intParm); 

			//Package Name
			MyOraDB.Process_Name= "PKG_SEM_OA_CRT01.SAVE_SEM_OBS_OA";

			MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";      
			MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";      
			MyOraDB.Parameter_Name[2]  = "ARG_OA_NU";        
			MyOraDB.Parameter_Name[3]  = "ARG_OBS_DIV";      
			MyOraDB.Parameter_Name[4]  = "ARG_OA_OBS_DIV";   

			MyOraDB.Parameter_Name[5]  = "ARG_OBS_ID";       
			MyOraDB.Parameter_Name[6]  = "ARG_OBS_TYPE";     
			MyOraDB.Parameter_Name[7]  = "ARG_STYLE_CD";     
			MyOraDB.Parameter_Name[8]  = "ARG_OA_DIV";       
			MyOraDB.Parameter_Name[9]  = "ARG_OA_YMD"; 	  	 

			MyOraDB.Parameter_Name[10] = "ARG_OA_CFM";       
			MyOraDB.Parameter_Name[11] = "ARG_CHG_YMD";     
			MyOraDB.Parameter_Name[12] = "ARG_PUR_NO"; 	  	
			MyOraDB.Parameter_Name[13] = "ARG_OUR_REF_NO";  
			MyOraDB.Parameter_Name[14] = "ARG_PUR_GRP";     

			MyOraDB.Parameter_Name[15] = "ARG_YOUR_REF";    
			MyOraDB.Parameter_Name[16] = "ARG_ORDER_RSN";   
			MyOraDB.Parameter_Name[17] = "ARG_QUAL_ISEQ";   
			MyOraDB.Parameter_Name[18] = "ARG_SEASON_CD";   
			MyOraDB.Parameter_Name[19] = "ARG_SEASON_YEAR"; 

			MyOraDB.Parameter_Name[20] = "ARG_REMARKS";     
			MyOraDB.Parameter_Name[21] = "ARG_UPD_USER";    
			MyOraDB.Parameter_Name[22] = "ARG_UPD_YMD";     

			//Parameter Type
			for (int i =0 ; i< intParm; i++)
				MyOraDB.Parameter_Type[i] = 1; 

			//Data부
			MyOraDB.Parameter_Values[0] = _Division;
			MyOraDB.Parameter_Values[1] = cmb_Factory.SelectedValue.ToString();   
			MyOraDB.Parameter_Values[2] = txt_OA_Nu.Text;
			MyOraDB.Parameter_Values[3] = ClassLib.ComVar.ConsOBS_G;
			MyOraDB.Parameter_Values[4] = cmb_OA_OBS_Div.SelectedValue.ToString();

			MyOraDB.Parameter_Values[5] = cmb_OBS_ID.Text.ToString();
			MyOraDB.Parameter_Values[6] = cmb_OBS_Type.SelectedValue.ToString();
			MyOraDB.Parameter_Values[7] = _Style_Cd;
			MyOraDB.Parameter_Values[8] = cmb_OA_Div.SelectedValue.ToString();
			MyOraDB.Parameter_Values[9] = Convert.ToDateTime(dtp_OA_Ymd.Text).ToString("yyyyMMdd");

			MyOraDB.Parameter_Values[10] = "R";
			MyOraDB.Parameter_Values[11] = Convert.ToDateTime(dtp_Chg_Ymd.Text).ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[12] = ClassLib.ComFunction.Empty_TextBox(txt_Pur_No," ");
			MyOraDB.Parameter_Values[13] = ClassLib.ComFunction.Empty_TextBox(txt_Ref_No," ");
			MyOraDB.Parameter_Values[14] = ClassLib.ComFunction.Empty_TextBox(txt_Pur_Grp," ");

			MyOraDB.Parameter_Values[15] = ClassLib.ComFunction.Empty_TextBox(txt_Your_Ref," ");
			MyOraDB.Parameter_Values[16] = ClassLib.ComFunction.Empty_TextBox(txt_Order_Rsn," ");
			MyOraDB.Parameter_Values[17] = ClassLib.ComFunction.Empty_TextBox(txt_Qual_Iseq," ");
			MyOraDB.Parameter_Values[18] = cmb_Season_Cd.SelectedValue.ToString ();
			MyOraDB.Parameter_Values[19] = cmb_Season_Year.Text.ToString();

			MyOraDB.Parameter_Values[20] = ClassLib.ComFunction.Empty_TextBox(txt_Remarks," ");
			MyOraDB.Parameter_Values[21] = ClassLib.ComVar.This_User;
			MyOraDB.Parameter_Values[22] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

			MyOraDB.Add_Modify_Parameter(true);	

			#endregion
						
			#region SAVE_SEM_OA_REL
			intParm = 17; int iCnt  = 0, iSeq=0;
			
			MyOraDB.ReDim_Parameter(intParm); 

			MyOraDB.Process_Name= "PKG_SEM_OA_CRT01.SAVE_SEM_OA_REL";
			
			MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2]  = "ARG_OA_NU";;
			MyOraDB.Parameter_Name[3]  = "ARG_OA_SEQ_NU";
			MyOraDB.Parameter_Name[4]  = "ARG_OA_POSITION";
			MyOraDB.Parameter_Name[5]  = "ARG_OBS_DIV";
			MyOraDB.Parameter_Name[6]  = "ARG_OA_OBS_DIV";
			MyOraDB.Parameter_Name[7]  = "ARG_OBS_ID";			  
			MyOraDB.Parameter_Name[8]  = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[9]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[10] = "ARG_OA_CFM";
			MyOraDB.Parameter_Name[11] = "ARG_OBS_NU";
			MyOraDB.Parameter_Name[12] = "ARG_OBS_SEQ_NU";
			MyOraDB.Parameter_Name[13] = "ARG_CHG_NU";
			MyOraDB.Parameter_Name[14] = "ARG_OA_FLAG";
			MyOraDB.Parameter_Name[15] = "ARG_REMARKS";
			MyOraDB.Parameter_Name[16] = "ARG_UPD_USER";
	
			for (int i =0 ; i< intParm; i++)
				MyOraDB.Parameter_Type[i] = 1; 
			

			//Data부
			MyOraDB.Parameter_Values = new string[intParm*(fsp_Stylebal.Rows.Count-_Rowfixed-1)] ;
			for (int j = _Rowfixed+1 ;  j< fsp_Stylebal.Rows.Count; j++)
			{   
				if (fsp_Stylebal[j,(int)ClassLib.TBSEM_OA06.lxOBS_NU] == null) continue;
					
				MyOraDB.Parameter_Values[iCnt] = _Division;									iCnt = iCnt +1;
				MyOraDB.Parameter_Values[iCnt] = cmb_Factory.SelectedValue.ToString();		iCnt = iCnt +1;
				MyOraDB.Parameter_Values[iCnt] = txt_OA_Nu.Text;								iCnt = iCnt +1;
				MyOraDB.Parameter_Values[iCnt] = iSeq.ToString().PadLeft(5,'0');           iSeq = iSeq +1; iCnt = iCnt +1;       
				MyOraDB.Parameter_Values[iCnt] = 
					fsp_Stylebal[j,(int)ClassLib.TBSEM_OA06.lxJOB].ToString();              iCnt = iCnt +1;
				MyOraDB.Parameter_Values[iCnt] = ClassLib.ComVar.ConsOBS_G;                 iCnt = iCnt +1;
				MyOraDB.Parameter_Values[iCnt] = cmb_OA_OBS_Div.SelectedValue.ToString();   iCnt = iCnt +1;
				MyOraDB.Parameter_Values[iCnt] = cmb_OBS_ID.Text;                           iCnt = iCnt +1;
				MyOraDB.Parameter_Values[iCnt] = cmb_OBS_Type.SelectedValue.ToString();		iCnt = iCnt +1;
				MyOraDB.Parameter_Values[iCnt] = _Style_Cd;									iCnt = iCnt +1;
				MyOraDB.Parameter_Values[iCnt] = ClassLib.ComVar.ConsCFM_R;                 iCnt = iCnt +1;
				MyOraDB.Parameter_Values[iCnt] = 
					fsp_Stylebal[j,(int)ClassLib.TBSEM_OA06.lxOBS_NU].ToString();			iCnt = iCnt +1;
				MyOraDB.Parameter_Values[iCnt] = 
					fsp_Stylebal[j,(int)ClassLib.TBSEM_OA06.lxOBS_SEQ_NU].ToString();       iCnt = iCnt +1;
				MyOraDB.Parameter_Values[iCnt] =											
					fsp_Stylebal[j,(int)ClassLib.TBSEM_OA06.lxCHG_NU].ToString();           iCnt = iCnt +1;
				MyOraDB.Parameter_Values[iCnt] = 
					fsp_Stylebal[j,(int)ClassLib.TBSEM_OA06.lxJOB].ToString();              iCnt = iCnt +1;
				MyOraDB.Parameter_Values[iCnt] = 
					ClassLib.ComFunction.Empty_TextBox(txt_Remarks," ");                    iCnt = iCnt +1;
				MyOraDB.Parameter_Values[iCnt] = ClassLib.ComVar.This_User;                 iCnt = iCnt +1;
				
			}

			MyOraDB.Add_Modify_Parameter(false);   //첫번째.... 	 
			
			#endregion		

			ret= MyOraDB.Exe_Modify_Procedure();

			return true;

		}


		private bool Delete_OA_Rel()
		{	

			#region 임시
//			int iParm;
//									
//			iParm = 2;
//			MyOraDB.ReDim_Parameter(iParm); 
//
//			//Package Name
//			string sproc_name  = "PKG_SEM_OA_CRT01.DELETE_SEM_OA";
//			MyOraDB.Process_Name= sproc_name;
//		
//			//Parameter Name
//			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
//			MyOraDB.Parameter_Name[1] = "ARG_OA_NU";
//		
//			//Parameter Type
//			for (int i =0 ; i< iParm; i++)
//				MyOraDB.Parameter_Type[i] = 1; 
//
//			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
//			MyOraDB.Parameter_Values[1] = cmb_OA_Nu.Columns[1].Text.ToString();
//
//			MyOraDB.Add_Modify_Parameter(true);	
//			MyOraDB.Exe_Modify_Procedure();
//
//			return true;
			#endregion


			#region 수정중
			int iParm;
									
			iParm = 7;
			MyOraDB.ReDim_Parameter(iParm); 

			//Package Name
			string sproc_name  = "PKG_SEM_OA_CRT01.DELETE_SEM_OA";
			MyOraDB.Process_Name= sproc_name;
		
			//Parameter Name
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OA_FLAG";
			MyOraDB.Parameter_Name[2] = "ARG_OA_NU";
			MyOraDB.Parameter_Name[3] = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[4] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";
			MyOraDB.Parameter_Name[6] = "ARG_UPD_YMD";
		
			//Parameter Type
			for (int i =0 ; i< iParm; i++)
				MyOraDB.Parameter_Type[i] = 1; 

			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_OA_Nu.Columns[0].Text.ToString();
			MyOraDB.Parameter_Values[2] = cmb_OA_Nu.Columns[1].Text.ToString();
			MyOraDB.Parameter_Values[3] = cmb_OBS_ID.Text.ToString();
			MyOraDB.Parameter_Values[4] = cmb_OBS_Type.SelectedValue.ToString();
			MyOraDB.Parameter_Values[5] = ClassLib.ComVar.This_User;
			MyOraDB.Parameter_Values[6] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

			MyOraDB.Add_Modify_Parameter(true);	
			MyOraDB.Exe_Modify_Procedure();

			return true;

			#endregion

		}


		#endregion

		#region 이벤트처리

		#region 버튼 이벤트
		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			//COM.ComFunction comfunc = new COM.ComFunction();
			//comfunc.Common_WorkInfo();
		}

	    
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				SB_Init();

				Sb_Style_Info();

				Sb_Style_Tail();

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
			    if (Check_Save()!= true) return;
				

				if (Save_OA_List() != true) 
				{	
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave , this);
					return;
				}

				//Popup창을 올리기 위해 OA_NU Field로 강제 이동.
				fsp_Styletail.Select(fsp_Styletail.Selection.r1,(int)ClassLib.TBSEM_OA05.IxOA_NU_AFT);
	
				fsp_Styletail_DoubleClick(null,null);

				tbtn_Search_Click(null,null);  

			}
			catch 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave,this);
			}	
			
		}


		
		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{   
				DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete, this);

				if(DialogResult.Yes != dr) return;

//				if (cmb_OA_Nu.Columns[0].Text.ToString() =="C") 
//				{	
//					ClassLib.ComFunction.User_Message("Aready Confrimed . So You can not delete data");
//					return;
//				}


				if (Delete_OA_Rel() != true) 
				{	
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotDelete  , this);
					return;
				}
	
				fsp_Styletail_DoubleClick(null,null);
				tbtn_Search_Click(null,null);  

			}
			catch 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotDelete,this);
			}	
		}


		private void cmb_Style_TextChanged(object sender, System.EventArgs e)
		{
		    tbtn_Search_Click(null,null);
		}

		#endregion

		#region 기타 event
		private void cmb_OBS_Type_TextChanged(object sender, System.EventArgs e)
		{
			if(cmb_OBS_Type.SelectedIndex == -1) return;

			cmb_OBS_ID.ClearItems();
			ClassLib.ComFunction.Set_OBSID_CmbList(cmb_OBS_Type.SelectedValue.ToString(), cmb_OBS_ID);  

		}


		private void cmb_OBS_ID_TextChanged(object sender, System.EventArgs e)
		{
			DataTable dt_list;
			cmb_Style.ClearItems();
	
			if (cmb_OBS_ID.Text  != null)
			{
				dt_list =MyClassLib.Select_OBS_Style(cmb_Factory.SelectedValue.ToString(),
					cmb_OBS_ID.Text.ToString(),
					cmb_OBS_Type.SelectedValue.ToString(),
					" ");
				ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Style, 0, 1,true); 
				cmb_Style.SelectedIndex  = 0;;
			}
		}

		
		private void btn_OA_Click(object sender, System.EventArgs e)
		{
			if (txt_OA_Nu.Text  == null) return;

			SB_Pop_CFM(txt_OA_Nu.Text);
		}


		private void fsp_Style_Click(object sender, System.EventArgs e)
		{
			try
			{
				SB_Init();

				Sb_Style_Tail();

				//Set OA Nu
				DataTable dt_list;
				dt_list = MyClassLib.Select_OA_Nu(cmb_Factory.SelectedValue.ToString(),
					cmb_OBS_ID.Text.ToString (), 
					cmb_OBS_Type.SelectedValue.ToString(),
					fsp_Style[fsp_Style.Selection.r1,(int)ClassLib.TBSEM_OA04.IxSTYLE_CD].ToString());
				ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OA_Nu, 0, 1);  

			}
			catch
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch,this);
			}	
		}


		private void fsp_Styletail_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			Sb_Check_Job();

			if (fsp_Styletail.Selection.c1 ==(int)ClassLib.TBSEM_OA05.IxJOB_DIV)
			{   
				txt_OA_Nu.Text = fsp_Styletail[ fsp_Styletail.Selection.r1, fsp_Styletail.Selection.c1].ToString();
				fsp_Styletail[fsp_Styletail.Selection.r1,0]= "I"; _Division ="I";
				Sb_Set_Balance();
			}
			
			Sb_Set_OA_Div();

		}


		private void txt_OA_Nu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			DataTable dt_list;
			
			
			if (e.KeyValue == 13)
			{
				
				dt_list = MyClassLib.Select_OA_Nu(cmb_Factory.SelectedValue.ToString(),
					cmb_OBS_ID.Text.ToString (), 
					cmb_OBS_Type.SelectedValue.ToString(),
					fsp_Style[fsp_Style.Selection.r1,(int)ClassLib.TBSEM_OA04.IxSTYLE_CD].ToString());
				ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OA_Nu, 0, 1);  
			}
		}



		private void cmb_OA_Nu_TextChanged(object sender, System.EventArgs e)
		{
			
			if (cmb_OA_Nu.SelectedValue == null) return;
			
			txt_OA_Nu.Text = cmb_OA_Nu.Columns[1].Text;
			//Display OA  속성; 
			Select_OA();

			//Display Balance 
			Select_OA_Rel();

		}



		private void fsp_Styletail_DoubleClick(object sender, System.EventArgs e)
		{

			try
			{

				if (fsp_Styletail.Selection.c1  == (int)ClassLib.TBSEM_OA05.IxJOB_DIV) return;

				string sOA_Nu_Old  =txt_OA_Nu.Text;

				SB_Init();

				if (fsp_Styletail[ fsp_Styletail.Selection.r1,(int)ClassLib.TBSEM_OA05.IxOA_NU_BEF].ToString() == "__________")
				{txt_OA_Nu.Text =fsp_Styletail[fsp_Styletail.Selection.r1,(int)ClassLib.TBSEM_OA05.IxOA_NU_AFT].ToString();
					fsp_Styletail[fsp_Styletail.Selection.r1,0]= "U"; _Division ="U";}
				else
				{txt_OA_Nu.Text =fsp_Styletail[fsp_Styletail.Selection.r1,(int)ClassLib.TBSEM_OA05.IxOA_NU_BEF].ToString();
					fsp_Styletail[fsp_Styletail.Selection.r1,0]= "U"; _Division ="U";}
		
				//Display OA  속성; 
				if (txt_OA_Nu.Text == "__________")
				txt_OA_Nu.Text = sOA_Nu_Old ;
				Select_OA();

				//Display Balance 
				Select_OA_Rel();

				SB_Pop_CFM(txt_OA_Nu.Text );

			}
			catch 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch,this);
			}	

		}
		#endregion

		#endregion

		private void Form_OA_CRT01_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

	}
}

