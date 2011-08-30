using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;

namespace FlexOrder.ExpBP
{
	public class Form_EB_BAL : COM.OrderWinForm.Form_Top
	{
		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Panel pnl_Search;
		private System.Windows.Forms.Panel pnl_Search1_Image;
		private C1.Win.C1List.C1Combo cmb_OBS_ID1;
		private System.Windows.Forms.Label lbl_Factory;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox8;
		private C1.Win.C1List.C1Combo cmb_OBS_ID2;
		private System.Windows.Forms.Label lbl_OBS_ID;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label lbl_STYLE;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label lbl_Out_Sole;
		private C1.Win.C1List.C1Combo cmb_Out_Sole;
		private C1.Win.C1List.C1Combo cmb_Style_Cd;
		public System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.CheckBox chk_Region;
		private System.Windows.Forms.CheckBox chk_Style;
		private System.ComponentModel.IContainer components = null;

		public Form_EB_BAL()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EB_BAL));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_Search1_Image = new System.Windows.Forms.Panel();
			this.chk_Style = new System.Windows.Forms.CheckBox();
			this.chk_Region = new System.Windows.Forms.CheckBox();
			this.cmb_Style_Cd = new C1.Win.C1List.C1Combo();
			this.cmb_Out_Sole = new C1.Win.C1List.C1Combo();
			this.cmb_OBS_ID1 = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.cmb_OBS_ID2 = new C1.Win.C1List.C1Combo();
			this.lbl_OBS_ID = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lbl_Out_Sole = new System.Windows.Forms.Label();
			this.lbl_STYLE = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_Search1_Image.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Style_Cd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Out_Sole)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID2)).BeginInit();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
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
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_Search1_Image);
			this.pnl_Search.DockPadding.All = 8;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1016, 112);
			this.pnl_Search.TabIndex = 44;
			// 
			// pnl_Search1_Image
			// 
			this.pnl_Search1_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search1_Image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_Search1_Image.Controls.Add(this.chk_Style);
			this.pnl_Search1_Image.Controls.Add(this.chk_Region);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Style_Cd);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Out_Sole);
			this.pnl_Search1_Image.Controls.Add(this.cmb_OBS_ID1);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Factory);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Factory);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox2);
			this.pnl_Search1_Image.Controls.Add(this.lbl_SubTitle1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox5);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox8);
			this.pnl_Search1_Image.Controls.Add(this.cmb_OBS_ID2);
			this.pnl_Search1_Image.Controls.Add(this.lbl_OBS_ID);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox3);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Out_Sole);
			this.pnl_Search1_Image.Controls.Add(this.lbl_STYLE);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox6);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox9);
			this.pnl_Search1_Image.Controls.Add(this.label1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox4);
			this.pnl_Search1_Image.Location = new System.Drawing.Point(8, 8);
			this.pnl_Search1_Image.Name = "pnl_Search1_Image";
			this.pnl_Search1_Image.Size = new System.Drawing.Size(1000, 96);
			this.pnl_Search1_Image.TabIndex = 0;
			// 
			// chk_Style
			// 
			this.chk_Style.BackColor = System.Drawing.SystemColors.Window;
			this.chk_Style.Checked = true;
			this.chk_Style.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_Style.Location = new System.Drawing.Point(752, 56);
			this.chk_Style.Name = "chk_Style";
			this.chk_Style.TabIndex = 124;
			this.chk_Style.Text = "By Style";
			this.chk_Style.Click += new System.EventHandler(this.chk_Style_Click);
			// 
			// chk_Region
			// 
			this.chk_Region.BackColor = System.Drawing.SystemColors.Window;
			this.chk_Region.Location = new System.Drawing.Point(872, 56);
			this.chk_Region.Name = "chk_Region";
			this.chk_Region.TabIndex = 123;
			this.chk_Region.Text = "By Region";
			this.chk_Region.Click += new System.EventHandler(this.chk_Region_Click);
			// 
			// cmb_Style_Cd
			// 
			this.cmb_Style_Cd.AddItemCols = 0;
			this.cmb_Style_Cd.AddItemSeparator = ';';
			this.cmb_Style_Cd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Style_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Style_Cd.Caption = "";
			this.cmb_Style_Cd.CaptionHeight = 17;
			this.cmb_Style_Cd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Style_Cd.ColumnCaptionHeight = 18;
			this.cmb_Style_Cd.ColumnFooterHeight = 18;
			this.cmb_Style_Cd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Style_Cd.ContentHeight = 15;
			this.cmb_Style_Cd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Style_Cd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Style_Cd.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Style_Cd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Style_Cd.EditorHeight = 15;
			this.cmb_Style_Cd.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Style_Cd.GapHeight = 2;
			this.cmb_Style_Cd.ItemHeight = 15;
			this.cmb_Style_Cd.Location = new System.Drawing.Point(445, 36);
			this.cmb_Style_Cd.MatchEntryTimeout = ((long)(2000));
			this.cmb_Style_Cd.MaxDropDownItems = ((short)(5));
			this.cmb_Style_Cd.MaxLength = 32767;
			this.cmb_Style_Cd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Style_Cd.Name = "cmb_Style_Cd";
			this.cmb_Style_Cd.PartialRightColumn = false;
			this.cmb_Style_Cd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"<DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Style_Cd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Style_Cd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Style_Cd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Style_Cd.Size = new System.Drawing.Size(210, 19);
			this.cmb_Style_Cd.SuperBack = true;
			this.cmb_Style_Cd.TabIndex = 116;
			// 
			// cmb_Out_Sole
			// 
			this.cmb_Out_Sole.AddItemCols = 0;
			this.cmb_Out_Sole.AddItemSeparator = ';';
			this.cmb_Out_Sole.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Out_Sole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Out_Sole.Caption = "";
			this.cmb_Out_Sole.CaptionHeight = 17;
			this.cmb_Out_Sole.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Out_Sole.ColumnCaptionHeight = 18;
			this.cmb_Out_Sole.ColumnFooterHeight = 18;
			this.cmb_Out_Sole.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Out_Sole.ContentHeight = 15;
			this.cmb_Out_Sole.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Out_Sole.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Out_Sole.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Out_Sole.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Out_Sole.EditorHeight = 15;
			this.cmb_Out_Sole.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Out_Sole.GapHeight = 2;
			this.cmb_Out_Sole.ItemHeight = 15;
			this.cmb_Out_Sole.Location = new System.Drawing.Point(445, 58);
			this.cmb_Out_Sole.MatchEntryTimeout = ((long)(2000));
			this.cmb_Out_Sole.MaxDropDownItems = ((short)(5));
			this.cmb_Out_Sole.MaxLength = 32767;
			this.cmb_Out_Sole.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Out_Sole.Name = "cmb_Out_Sole";
			this.cmb_Out_Sole.PartialRightColumn = false;
			this.cmb_Out_Sole.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tru" +
				"e;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Con" +
				"trol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.L" +
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
				"<DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Out_Sole.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Out_Sole.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Out_Sole.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Out_Sole.Size = new System.Drawing.Size(210, 19);
			this.cmb_Out_Sole.SuperBack = true;
			this.cmb_Out_Sole.TabIndex = 115;
			// 
			// cmb_OBS_ID1
			// 
			this.cmb_OBS_ID1.AddItemCols = 0;
			this.cmb_OBS_ID1.AddItemSeparator = ';';
			this.cmb_OBS_ID1.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_ID1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_ID1.Caption = "";
			this.cmb_OBS_ID1.CaptionHeight = 17;
			this.cmb_OBS_ID1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_ID1.ColumnCaptionHeight = 18;
			this.cmb_OBS_ID1.ColumnFooterHeight = 18;
			this.cmb_OBS_ID1.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_ID1.ContentHeight = 15;
			this.cmb_OBS_ID1.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_ID1.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OBS_ID1.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID1.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_ID1.EditorHeight = 15;
			this.cmb_OBS_ID1.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID1.GapHeight = 2;
			this.cmb_OBS_ID1.ItemHeight = 15;
			this.cmb_OBS_ID1.Location = new System.Drawing.Point(111, 58);
			this.cmb_OBS_ID1.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_ID1.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_ID1.MaxLength = 32767;
			this.cmb_OBS_ID1.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_ID1.Name = "cmb_OBS_ID1";
			this.cmb_OBS_ID1.PartialRightColumn = false;
			this.cmb_OBS_ID1.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"<DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_OBS_ID1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_ID1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID1.RowTracking = false;
			this.cmb_OBS_ID1.Size = new System.Drawing.Size(100, 19);
			this.cmb_OBS_ID1.TabIndex = 111;
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
				"<DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory.SuperBack = true;
			this.cmb_Factory.TabIndex = 37;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(978, 0);
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
			this.pictureBox2.Size = new System.Drawing.Size(816, 32);
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
			this.lbl_SubTitle1.Text = "      Request Info.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(981, 32);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(19, 50);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.Color.Blue;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(910, 82);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(90, 14);
			this.pictureBox8.TabIndex = 8;
			this.pictureBox8.TabStop = false;
			// 
			// cmb_OBS_ID2
			// 
			this.cmb_OBS_ID2.AddItemCols = 0;
			this.cmb_OBS_ID2.AddItemSeparator = ';';
			this.cmb_OBS_ID2.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_ID2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_ID2.Caption = "";
			this.cmb_OBS_ID2.CaptionHeight = 17;
			this.cmb_OBS_ID2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_ID2.ColumnCaptionHeight = 18;
			this.cmb_OBS_ID2.ColumnFooterHeight = 18;
			this.cmb_OBS_ID2.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_ID2.ContentHeight = 15;
			this.cmb_OBS_ID2.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_ID2.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OBS_ID2.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID2.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_ID2.EditorHeight = 15;
			this.cmb_OBS_ID2.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID2.GapHeight = 2;
			this.cmb_OBS_ID2.ItemHeight = 15;
			this.cmb_OBS_ID2.Location = new System.Drawing.Point(221, 58);
			this.cmb_OBS_ID2.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_ID2.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_ID2.MaxLength = 32767;
			this.cmb_OBS_ID2.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_ID2.Name = "cmb_OBS_ID2";
			this.cmb_OBS_ID2.PartialRightColumn = false;
			this.cmb_OBS_ID2.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tru" +
				"e;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Con" +
				"trol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.L" +
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
				"<DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_OBS_ID2.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_ID2.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID2.RowTracking = false;
			this.cmb_OBS_ID2.Size = new System.Drawing.Size(100, 19);
			this.cmb_OBS_ID2.TabIndex = 43;
			this.cmb_OBS_ID2.TextChanged += new System.EventHandler(this.cmb_OBS_ID2_TextChanged);
			// 
			// lbl_OBS_ID
			// 
			this.lbl_OBS_ID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_ID.ImageIndex = 1;
			this.lbl_OBS_ID.ImageList = this.img_Label;
			this.lbl_OBS_ID.Location = new System.Drawing.Point(10, 58);
			this.lbl_OBS_ID.Name = "lbl_OBS_ID";
			this.lbl_OBS_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_ID.TabIndex = 20;
			this.lbl_OBS_ID.Text = "OBS ID";
			this.lbl_OBS_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(0, 24);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 61);
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			// 
			// lbl_Out_Sole
			// 
			this.lbl_Out_Sole.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Out_Sole.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Out_Sole.ImageIndex = 0;
			this.lbl_Out_Sole.ImageList = this.img_Label;
			this.lbl_Out_Sole.Location = new System.Drawing.Point(344, 58);
			this.lbl_Out_Sole.Name = "lbl_Out_Sole";
			this.lbl_Out_Sole.Size = new System.Drawing.Size(100, 21);
			this.lbl_Out_Sole.TabIndex = 21;
			this.lbl_Out_Sole.Text = "Out Sole";
			this.lbl_Out_Sole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_STYLE
			// 
			this.lbl_STYLE.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_STYLE.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_STYLE.ImageIndex = 0;
			this.lbl_STYLE.ImageList = this.img_Label;
			this.lbl_STYLE.Location = new System.Drawing.Point(344, 36);
			this.lbl_STYLE.Name = "lbl_STYLE";
			this.lbl_STYLE.Size = new System.Drawing.Size(100, 21);
			this.lbl_STYLE.TabIndex = 20;
			this.lbl_STYLE.Text = "Style";
			this.lbl_STYLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.Color.Blue;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 82);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(80, 14);
			this.pictureBox6.TabIndex = 6;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox9.BackColor = System.Drawing.Color.Blue;
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(72, 82);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(912, 14);
			this.pictureBox9.TabIndex = 9;
			this.pictureBox9.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(209, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 23);
			this.label1.TabIndex = 114;
			this.label1.Text = "~";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.Color.Navy;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(32, 24);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(952, 64);
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.DockPadding.Left = 10;
			this.pnl_Body.DockPadding.Right = 10;
			this.pnl_Body.Location = new System.Drawing.Point(0, 175);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 460);
			this.pnl_Body.TabIndex = 45;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(10, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(996, 460);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8pt;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;ForeColor:Black;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;ForeColor:Black;}	Focus{BackColor:236, 247, 187;ForeColor:Black;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 35;
			// 
			// Form_EB_BAL
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Search);
			this.Font = new System.Drawing.Font("Verdana", 8F);
			this.Name = "Form_EB_BAL";
			this.Load += new System.EventHandler(this.Form_EB_BAL_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_Search1_Image.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Style_Cd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Out_Sole)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID2)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의
   
		private int _Rowfixed;  

		private ClassLib.OraDB  MyOraDB = new ClassLib.OraDB();

		#endregion 

		#region 멤버 메서드 
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			
			//Title
			this.Text = "Balnace Sheet";
			this.lbl_MainTitle.Text = "Balnace Sheet"; 
			ClassLib.ComFunction.SetLangDic(this);

			#region 버튼 권한

			//try
//			{
//				COM.OraDB btn_control = new COM.OraDB();
//				DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
//				tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
//				btn_control = null;
//
//				//Button 활성화
//				tbtn_Save.Enabled = false;   tbtn_Append.Enabled = false;   tbtn_Delete.Enabled = false;   
//				tbtn_Insert.Enabled = false; tbtn_Print.Enabled = false;    tbtn_Print.Enabled = false;   
//			}
//			catch
//			{
//			}

			#endregion

			DataTable dt_list; 

			// 그리드 설정(TBSEM_BP_BAL)
			fgrid_Main.Set_Grid( "SEM_BP_BAL", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
			_Rowfixed = fgrid_Main.Rows.Fixed;
			fgrid_Main.Set_Action_Image(img_Action); 
			fgrid_Main.Rows[0].Visible = true;
			fgrid_Main.Font  = new Font("Verdana",8);


			for (int i  =1; i<= (int)ClassLib.TBSEM_BP_BAL.IxSTYLE_NAME ;  i++)
			{fgrid_Main[0,i] = " ";   fgrid_Main.Cols[i].Width =100;}


           // 체크 설정
			chk_Style.Checked = true;
		

			///Factory
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			//OBS ID
			cmb_OBS_ID1.ClearItems();
			cmb_OBS_ID2.ClearItems();
			ClassLib.ComFunction.Set_OBSID_CmbList("FT", cmb_OBS_ID1);  
			ClassLib.ComFunction.Set_OBSID_CmbList("FT", cmb_OBS_ID2);  		

		}



		
		private bool Check_Select()
		{   

			if ((cmb_Factory.SelectedIndex == -1)||
				(cmb_OBS_ID1.SelectedIndex == -1)|| (cmb_OBS_ID1.SelectedIndex == -1))
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsWrongInput  ,this);
				return false;
			}
			else
			{
				return true;
			}

			
		}

		private void Display_Grid_Head(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{ 
			  
			int intCnt = 0 ;

			arg_fgrid.Rows.Count =  _Rowfixed;
			// grid col수 
			if (chk_Region.Checked == false) 
				arg_fgrid.Cols.Count =  (int)ClassLib.TBSEM_BP_BAL.IxMaxCt+1;
			else
				arg_fgrid.Cols.Count =  (int)ClassLib.TBSEM_BP_BAL.IxMaxCt+2;

			if (arg_dt.Rows.Count > 0) 	
			{ 
				arg_fgrid.Cols.Count =  arg_fgrid.Cols.Count +  (arg_dt.Rows.Count*3);
				
				//data setting 시작 col
				if (chk_Region.Checked == false) 
					intCnt = (int)ClassLib.TBSEM_BP_BAL.IxMaxCt+1;
				else
					intCnt = (int)ClassLib.TBSEM_BP_BAL.IxMaxCt+2;

				for (int i = 0 ; i< arg_dt.Rows.Count; i++)
				{  
					arg_fgrid[0,intCnt] =  arg_dt.Rows[i].ItemArray[0].ToString();
					arg_fgrid[1,intCnt] =  "BP Q'ty";
					arg_fgrid.Cols[intCnt].Width  =  70;
					intCnt  = intCnt+1 ;
					arg_fgrid[0,intCnt] =  arg_dt.Rows[i].ItemArray[0].ToString();
					arg_fgrid[1,intCnt] =  "OBS Q'ty";
					arg_fgrid.Cols[intCnt].Width  =  70;
					intCnt  = intCnt+1 ;
					arg_fgrid[0,intCnt] =  arg_dt.Rows[i].ItemArray[0].ToString();
					arg_fgrid[1,intCnt] =  "Bal Q'ty";
					arg_fgrid.Cols[intCnt].Width  =  70;
					intCnt  = intCnt+1 ;
				}
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch  ,this);
			}

		}



		private void Display_Grid_Data(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{ 
			//DPO별 BALANCE 넣기  --BP수량,  OBS수량,  BP수량  -  OBS수량
			string strStyle = ""; string strRegion = ""; int intStrCol;
 
			if (arg_dt.Rows.Count > 0) 
			{ 
				for (int i = 0 ; i< arg_dt.Rows.Count; i++)     //data뿌리기
				{  
					if (chk_Style.Checked == true) //Style
					{
						if (strStyle  != arg_dt.Rows[i].ItemArray[3].ToString())
						{
							arg_fgrid.Rows.Count = 	arg_fgrid.Rows.Count+1;
							arg_fgrid[arg_fgrid.Rows.Count-1,(int)ClassLib.TBSEM_BP_BAL.IxFACTORY]     = arg_dt.Rows[i].ItemArray[0].ToString();
							arg_fgrid[arg_fgrid.Rows.Count-1,(int)ClassLib.TBSEM_BP_BAL.IxOUT_SOLE_01] = arg_dt.Rows[i].ItemArray[1].ToString();
							arg_fgrid[arg_fgrid.Rows.Count-1,(int)ClassLib.TBSEM_BP_BAL.IxDEV_CD]      = arg_dt.Rows[i].ItemArray[2].ToString();
							arg_fgrid[arg_fgrid.Rows.Count-1,(int)ClassLib.TBSEM_BP_BAL.IxSTYLE_CD]    = arg_dt.Rows[i].ItemArray[3].ToString();
							arg_fgrid[arg_fgrid.Rows.Count-1,(int)ClassLib.TBSEM_BP_BAL.IxSTYLE_NAME]  = arg_dt.Rows[i].ItemArray[4].ToString();
						}
					
						intStrCol = (int)ClassLib.TBSEM_BP_BAL.IxMaxCt+1;
						for(int j= intStrCol ; j< arg_fgrid.Cols.Count  ; j++)   //obs id 찾기
						{  
							if (arg_fgrid[0,j].ToString() == arg_dt.Rows[i].ItemArray[5].ToString())
							{
								arg_fgrid[arg_fgrid.Rows.Count-1,j]   = arg_dt.Rows[i].ItemArray[6].ToString();
								arg_fgrid[arg_fgrid.Rows.Count-1,j+1] = arg_dt.Rows[i].ItemArray[7].ToString();
								arg_fgrid[arg_fgrid.Rows.Count-1,j+2] = arg_dt.Rows[i].ItemArray[8].ToString();
							}
							j = j+2;					    
						}
						strStyle  = arg_dt.Rows[i].ItemArray[3].ToString();	
					}
					else  //Region
					{
						if ((strStyle  != arg_dt.Rows[i].ItemArray[3].ToString()) || 
							(strRegion  != arg_dt.Rows[i].ItemArray[5].ToString()))
						{
							arg_fgrid.Rows.Count = 	arg_fgrid.Rows.Count+1;
							arg_fgrid[arg_fgrid.Rows.Count-1,(int)ClassLib.TBSEM_BP_BAL.IxFACTORY]     = arg_dt.Rows[i].ItemArray[0].ToString();
							arg_fgrid[arg_fgrid.Rows.Count-1,(int)ClassLib.TBSEM_BP_BAL.IxOUT_SOLE_01] = arg_dt.Rows[i].ItemArray[1].ToString();
							arg_fgrid[arg_fgrid.Rows.Count-1,(int)ClassLib.TBSEM_BP_BAL.IxDEV_CD]      = arg_dt.Rows[i].ItemArray[2].ToString();
							arg_fgrid[arg_fgrid.Rows.Count-1,(int)ClassLib.TBSEM_BP_BAL.IxSTYLE_CD]    = arg_dt.Rows[i].ItemArray[3].ToString();
							arg_fgrid[arg_fgrid.Rows.Count-1,(int)ClassLib.TBSEM_BP_BAL.IxSTYLE_NAME]  = arg_dt.Rows[i].ItemArray[4].ToString();

							if (chk_Region.Checked == true) //region col 추가
								arg_fgrid[arg_fgrid.Rows.Count-1,(int)ClassLib.TBSEM_BP_BAL.IxSTYLE_NAME+1]  = arg_dt.Rows[i].ItemArray[5].ToString();

						}						

						intStrCol = (int)ClassLib.TBSEM_BP_BAL.IxMaxCt+2;
						for(int j= intStrCol ; j< arg_fgrid.Cols.Count  ; j++)   //obs id 찾기
						{  
							if (arg_fgrid[0,j].ToString() == arg_dt.Rows[i].ItemArray[6].ToString())
							{
								arg_fgrid[arg_fgrid.Rows.Count-1,j]   = arg_dt.Rows[i].ItemArray[7].ToString();
								arg_fgrid[arg_fgrid.Rows.Count-1,j+1] = arg_dt.Rows[i].ItemArray[8].ToString();
								arg_fgrid[arg_fgrid.Rows.Count-1,j+2] = arg_dt.Rows[i].ItemArray[9].ToString();
							}
							j = j+2;					    
						}
						strStyle   = arg_dt.Rows[i].ItemArray[3].ToString();	
						strRegion  = arg_dt.Rows[i].ItemArray[5].ToString();	
					}

				}
		
				//Merge
				//arg_fgrid.SubtotalPosition = SubtotalPositionEnum.AboveData;
				//arg_fgrid.AllowMerging = AllowMergingEnum.Free;				
				for (int i = 0 ; i < 3; i++)
				{
					arg_fgrid.Cols[i].AllowMerging  =true;
				}
				arg_fgrid.Rows[0].AllowMerging = true;	

				Display_Subtotal(arg_fgrid);
			}


			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch  ,this);
			}

		}

		private void Display_Subtotal(C1FlexGrid arg_fgrid)
		{

			arg_fgrid.SubtotalPosition = SubtotalPositionEnum.AboveData;
			arg_fgrid.Tree.Column = (int)ClassLib.TBSEM_BP_BAL.IxOUT_SOLE_01;

			for (int c = (int)ClassLib.TBSEM_BP_BAL.IxSTYLE_NAME +1 ; c < arg_fgrid.Cols.Count; c++)
			{
				arg_fgrid.Subtotal(AggregateEnum.Sum, 2, 2, 0, "OS Total: " +"{0}");
				arg_fgrid.Subtotal(AggregateEnum.Sum, 2, 2, c, "OS Total: " +" {0}");
				arg_fgrid.Styles[CellStyleEnum.Subtotal2].BackColor  = ClassLib.ComVar.ClrTotFirst;
				arg_fgrid.Styles[CellStyleEnum.Subtotal2].ForeColor  = Color.Black;

				arg_fgrid.Subtotal(AggregateEnum.Sum, 1, 1, 0, "Grand Total ");
				arg_fgrid.Subtotal(AggregateEnum.Sum, 1, 1, c, "Grand Total ");		
				arg_fgrid.Styles[CellStyleEnum.Subtotal1].BackColor  = ClassLib.ComVar.ClrTotSecond;
				arg_fgrid.Styles[CellStyleEnum.Subtotal1].ForeColor  = Color.Black;

			}

		}

		#endregion

		#region 이벤트 처리  
		private void cmb_OBS_ID2_TextChanged(object sender, System.EventArgs e)
		{
			DataTable dt_list;

			if(cmb_OBS_ID1.SelectedIndex == -1) return;
			if(cmb_OBS_ID2.SelectedIndex == -1) return;

			//style
			dt_list = MyOraDB.Select_BP_Style(
				cmb_Factory.SelectedValue.ToString(),
				cmb_OBS_ID1.Text.ToString(), 
				cmb_OBS_ID2.Text.ToString());

			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Style_Cd, 0, 1);

			//outsole
			dt_list = MyOraDB.Select_BP_OutSole(
				cmb_Factory.SelectedValue.ToString(),
				cmb_OBS_ID1.Text.ToString(), 
				cmb_OBS_ID2.Text.ToString());

			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Out_Sole, 0, 1);
			
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable ds_ret;

			if (Check_Select() == false) return;

			//grid head(obs id)
			ds_ret = Select_OBS_List();
			Display_Grid_Head(ds_ret, fgrid_Main);

			//grid head(obs data)
			ds_ret  =  Select_BP_Balance();
			Display_Grid_Data (ds_ret, fgrid_Main);


		}

				
		private void chk_Region_Click(object sender, System.EventArgs e)
		{
			
			// 그리드 설정
			chk_Region.Checked = true;
			chk_Style.Checked = false;

			fgrid_Main.Set_Grid( "SEM_BP_BAL", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true); 
			_Rowfixed = fgrid_Main.Rows.Fixed;
			fgrid_Main.Set_Action_Image(img_Action); 
			fgrid_Main.Rows[0].Visible = true;
		
		}

		private void chk_Style_Click(object sender, System.EventArgs e)
		{
			chk_Region.Checked = false;
			chk_Style.Checked = true;

			fgrid_Main.Set_Grid( "SEM_BP_BAL", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true); 
			_Rowfixed = fgrid_Main.Rows.Fixed;
			fgrid_Main.Set_Action_Image(img_Action); 
			fgrid_Main.Rows[0].Visible = true;
		}

	

		#endregion

		#region DB 컨트롤


		public DataTable Select_OBS_List()
		{
			string strRlt;
 
			DataSet ret;
			
			MyOraDB.ReDim_Parameter(4); 
            
			strRlt  = "PKG_SEM_BP_BAL.SELECT_SEM_OBS_LIST";
			MyOraDB.Process_Name =strRlt;
			
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OBS_ID_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_OBS_ID_TO";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR"; 
				
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
	
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_OBS_ID1.Text.ToString();
			MyOraDB.Parameter_Values[2] = cmb_OBS_ID2.Text.ToString();
			MyOraDB.Parameter_Values[3] = "";
				
			MyOraDB.Add_Select_Parameter(true); 
			ret =  MyOraDB.Exe_Select_Procedure();
			
			if(ret == null) 
			{
				return null;
			}
			else
			{
				return ret.Tables[strRlt];
			}
				
		}

		public DataTable Select_BP_Balance()
		{
			string strRlt;
 
			DataSet ret;
			
			MyOraDB.ReDim_Parameter(7); 
            
			strRlt  = "PKG_SEM_BP_BAL.SELECT_SEM_BALANCE";
			MyOraDB.Process_Name =strRlt;
			
			MyOraDB.Parameter_Name[0] = "ARG_DIV";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_OBS_ID_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_OBS_ID_TO";
			MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[5] = "ARG_OUT_SOLE";
			MyOraDB.Parameter_Name[6] = "OUT_CURSOR"; 
				
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;
	
			
			if(chk_Region.Checked == false )
				MyOraDB.Parameter_Values[0] ="01";
			else
				MyOraDB.Parameter_Values[0] ="02";

			MyOraDB.Parameter_Values[1] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = cmb_OBS_ID1.Text.ToString();
			MyOraDB.Parameter_Values[3] = cmb_OBS_ID2.Text.ToString();
			MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_Combo(cmb_Style_Cd," ");
			MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_Combo(cmb_Out_Sole," ");
			MyOraDB.Parameter_Values[6] = "";
				
			MyOraDB.Add_Select_Parameter(true); 
			ret =  MyOraDB.Exe_Select_Procedure();
			
			if(ret == null) 
			{
				return null;
			}
			else
			{
				return ret.Tables[strRlt];
			}
				
		}


		#endregion

		private void Form_EB_BAL_Load(object sender, System.EventArgs e)
		{
			Init_Form();				
		}
		
	}
}







