using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OleDb;
using Microsoft.Office.Core;
using System.Data.OracleClient;
using System.Text;
using System.IO;
using System.Threading;





namespace FlexOrder.ExpLoad
{
	public class Form_EL_PA : COM.OrderWinForm.Form_Top
	{
		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Panel pnl_Search;
		private System.Windows.Forms.Panel pnl_Search1_Image;
		private System.Windows.Forms.Label lbl_Factory;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox9;
		private C1.Win.C1List.C1Combo cmb_Season;
		private System.Windows.Forms.Label lbl_Season;
		private C1.Win.C1List.C1Combo cmb_Date;
		private System.Windows.Forms.Label lbl_Date;
		private System.Windows.Forms.Label lbl_Dev;
		private System.Windows.Forms.TextBox txt_Style;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.TextBox txt_Dev;
		public System.Windows.Forms.Panel pnl_Body;		
		public COM.FSP fgrid_PA;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox txt_sheet;
		private System.Windows.Forms.Label lbl_sheet;
		private System.Windows.Forms.Label lbl_sheet_name;

		private System.ComponentModel.IContainer components = null;

		public Form_EL_PA()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EL_PA));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_Search1_Image = new System.Windows.Forms.Panel();
			this.lbl_sheet_name = new System.Windows.Forms.Label();
			this.lbl_Dev = new System.Windows.Forms.Label();
			this.lbl_Date = new System.Windows.Forms.Label();
			this.lbl_Season = new System.Windows.Forms.Label();
			this.txt_sheet = new System.Windows.Forms.TextBox();
			this.txt_Dev = new System.Windows.Forms.TextBox();
			this.txt_Style = new System.Windows.Forms.TextBox();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.cmb_Date = new C1.Win.C1List.C1Combo();
			this.cmb_Season = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.lbl_sheet = new System.Windows.Forms.Label();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_PA = new COM.FSP();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_Search1_Image.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Date)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_PA)).BeginInit();
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
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_Search1_Image);
			this.pnl_Search.DockPadding.All = 8;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1016, 104);
			this.pnl_Search.TabIndex = 37;
			// 
			// pnl_Search1_Image
			// 
			this.pnl_Search1_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search1_Image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_Search1_Image.Controls.Add(this.lbl_sheet_name);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Dev);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Date);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Season);
			this.pnl_Search1_Image.Controls.Add(this.txt_sheet);
			this.pnl_Search1_Image.Controls.Add(this.txt_Dev);
			this.pnl_Search1_Image.Controls.Add(this.txt_Style);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Style);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Date);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Season);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Factory);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Factory);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox2);
			this.pnl_Search1_Image.Controls.Add(this.lbl_SubTitle1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox5);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox8);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox3);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox4);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox6);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox9);
			this.pnl_Search1_Image.Location = new System.Drawing.Point(8, 8);
			this.pnl_Search1_Image.Name = "pnl_Search1_Image";
			this.pnl_Search1_Image.Size = new System.Drawing.Size(1000, 88);
			this.pnl_Search1_Image.TabIndex = 0;
			// 
			// lbl_sheet_name
			// 
			this.lbl_sheet_name.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_sheet_name.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_sheet_name.ImageIndex = 0;
			this.lbl_sheet_name.ImageList = this.img_Label;
			this.lbl_sheet_name.Location = new System.Drawing.Point(670, 57);
			this.lbl_sheet_name.Name = "lbl_sheet_name";
			this.lbl_sheet_name.Size = new System.Drawing.Size(100, 21);
			this.lbl_sheet_name.TabIndex = 200;
			this.lbl_sheet_name.Text = "Sheet Name";
			this.lbl_sheet_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Dev
			// 
			this.lbl_Dev.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Dev.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Dev.ImageIndex = 2;
			this.lbl_Dev.ImageList = this.img_Label;
			this.lbl_Dev.Location = new System.Drawing.Point(337, 57);
			this.lbl_Dev.Name = "lbl_Dev";
			this.lbl_Dev.Size = new System.Drawing.Size(100, 21);
			this.lbl_Dev.TabIndex = 196;
			this.lbl_Dev.Text = "Dev Code";
			this.lbl_Dev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Date
			// 
			this.lbl_Date.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Date.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Date.ImageIndex = 0;
			this.lbl_Date.ImageList = this.img_Label;
			this.lbl_Date.Location = new System.Drawing.Point(670, 36);
			this.lbl_Date.Name = "lbl_Date";
			this.lbl_Date.Size = new System.Drawing.Size(100, 21);
			this.lbl_Date.TabIndex = 192;
			this.lbl_Date.Text = "Date";
			this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Season
			// 
			this.lbl_Season.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Season.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Season.ImageIndex = 0;
			this.lbl_Season.ImageList = this.img_Label;
			this.lbl_Season.Location = new System.Drawing.Point(337, 36);
			this.lbl_Season.Name = "lbl_Season";
			this.lbl_Season.Size = new System.Drawing.Size(100, 21);
			this.lbl_Season.TabIndex = 190;
			this.lbl_Season.Text = "Season";
			this.lbl_Season.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_sheet
			// 
			this.txt_sheet.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_sheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_sheet.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_sheet.ForeColor = System.Drawing.Color.Black;
			this.txt_sheet.Location = new System.Drawing.Point(773, 58);
			this.txt_sheet.MaxLength = 100;
			this.txt_sheet.Name = "txt_sheet";
			this.txt_sheet.ReadOnly = true;
			this.txt_sheet.Size = new System.Drawing.Size(210, 20);
			this.txt_sheet.TabIndex = 199;
			this.txt_sheet.Text = "Detail";
			// 
			// txt_Dev
			// 
			this.txt_Dev.BackColor = System.Drawing.Color.White;
			this.txt_Dev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Dev.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Dev.Location = new System.Drawing.Point(438, 58);
			this.txt_Dev.MaxLength = 100;
			this.txt_Dev.Name = "txt_Dev";
			this.txt_Dev.Size = new System.Drawing.Size(210, 20);
			this.txt_Dev.TabIndex = 197;
			this.txt_Dev.Text = "";
			// 
			// txt_Style
			// 
			this.txt_Style.BackColor = System.Drawing.Color.White;
			this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Style.Location = new System.Drawing.Point(111, 56);
			this.txt_Style.MaxLength = 100;
			this.txt_Style.Name = "txt_Style";
			this.txt_Style.Size = new System.Drawing.Size(210, 20);
			this.txt_Style.TabIndex = 195;
			this.txt_Style.Text = "";
			// 
			// lbl_Style
			// 
			this.lbl_Style.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Style.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(10, 56);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 194;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Date
			// 
			this.cmb_Date.AddItemCols = 0;
			this.cmb_Date.AddItemSeparator = ';';
			this.cmb_Date.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Date.Caption = "";
			this.cmb_Date.CaptionHeight = 17;
			this.cmb_Date.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Date.ColumnCaptionHeight = 18;
			this.cmb_Date.ColumnFooterHeight = 18;
			this.cmb_Date.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Date.ContentHeight = 15;
			this.cmb_Date.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Date.EditorBackColor = System.Drawing.Color.White;
			this.cmb_Date.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Date.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Date.EditorHeight = 15;
			this.cmb_Date.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Date.GapHeight = 2;
			this.cmb_Date.ItemHeight = 15;
			this.cmb_Date.Location = new System.Drawing.Point(773, 38);
			this.cmb_Date.MatchEntryTimeout = ((long)(2000));
			this.cmb_Date.MaxDropDownItems = ((short)(5));
			this.cmb_Date.MaxLength = 32767;
			this.cmb_Date.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Date.Name = "cmb_Date";
			this.cmb_Date.PartialRightColumn = false;
			this.cmb_Date.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Date.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Date.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Date.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Date.Size = new System.Drawing.Size(211, 19);
			this.cmb_Date.TabIndex = 193;
			// 
			// cmb_Season
			// 
			this.cmb_Season.AddItemCols = 0;
			this.cmb_Season.AddItemSeparator = ';';
			this.cmb_Season.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Season.Caption = "";
			this.cmb_Season.CaptionHeight = 17;
			this.cmb_Season.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Season.ColumnCaptionHeight = 18;
			this.cmb_Season.ColumnFooterHeight = 18;
			this.cmb_Season.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Season.ContentHeight = 15;
			this.cmb_Season.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Season.EditorBackColor = System.Drawing.Color.White;
			this.cmb_Season.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Season.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Season.EditorHeight = 15;
			this.cmb_Season.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Season.GapHeight = 2;
			this.cmb_Season.ItemHeight = 15;
			this.cmb_Season.Location = new System.Drawing.Point(438, 38);
			this.cmb_Season.MatchEntryTimeout = ((long)(2000));
			this.cmb_Season.MaxDropDownItems = ((short)(5));
			this.cmb_Season.MaxLength = 32767;
			this.cmb_Season.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Season.Name = "cmb_Season";
			this.cmb_Season.PartialRightColumn = false;
			this.cmb_Season.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Season.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Season.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Season.Size = new System.Drawing.Size(211, 19);
			this.cmb_Season.TabIndex = 191;
			this.cmb_Season.TextChanged += new System.EventHandler(this.cmb_Season_TextChanged);
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 34);
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
			this.cmb_Factory.FetchRowStyles = true;
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
				"t=\"18\" ColumnFooterHeight=\"18\" FetchRowStyles=\"True\" VerticalScrollGroup=\"1\" Hor" +
				"izontalScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width" +
				">17</Width></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyl" +
				"e parent=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><Fo" +
				"oterStyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" " +
				"/><HeadingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"Highli" +
				"ghtRow\" me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyl" +
				"e parent=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=" +
				"\"Style10\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal" +
				"\" me=\"Style1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=" +
				"\"\" me=\"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" m" +
				"e=\"Footer\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"" +
				"Inactive\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Hi" +
				"ghlightRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"O" +
				"ddRow\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" m" +
				"e=\"Group\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><L" +
				"ayout>Modified</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory.TabIndex = 37;
			this.cmb_Factory.TextChanged += new System.EventHandler(this.cmb_Factory_TextChanged);
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
			this.lbl_SubTitle1.Text = "      PA Info.";
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
			this.pictureBox5.Size = new System.Drawing.Size(19, 42);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.Color.Blue;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(910, 74);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(90, 14);
			this.pictureBox8.TabIndex = 8;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(0, 24);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 53);
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
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
			this.pictureBox4.Size = new System.Drawing.Size(952, 56);
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.Color.Blue;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 74);
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
			this.pictureBox9.Location = new System.Drawing.Point(72, 74);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(912, 14);
			this.pictureBox9.TabIndex = 9;
			this.pictureBox9.TabStop = false;
			// 
			// lbl_sheet
			// 
			this.lbl_sheet.Location = new System.Drawing.Point(0, 0);
			this.lbl_sheet.Name = "lbl_sheet";
			this.lbl_sheet.TabIndex = 0;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_PA);
			this.pnl_Body.DockPadding.Left = 9;
			this.pnl_Body.DockPadding.Right = 9;
			this.pnl_Body.Location = new System.Drawing.Point(0, 168);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 472);
			this.pnl_Body.TabIndex = 47;
			// 
			// fgrid_PA
			// 
			this.fgrid_PA.AllowEditing = false;
			this.fgrid_PA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_PA.BackColor = System.Drawing.Color.White;
			this.fgrid_PA.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_PA.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_PA.ForeColor = System.Drawing.Color.Black;
			this.fgrid_PA.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_PA.Location = new System.Drawing.Point(9, 0);
			this.fgrid_PA.Name = "fgrid_PA";
			this.fgrid_PA.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_PA.Size = new System.Drawing.Size(998, 472);
			this.fgrid_PA.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_PA.TabIndex = 36;
			// 
			// Form_EL_PA
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Search);
			this.Name = "Form_EL_PA";
			this.Load += new System.EventHandler(this.Form_EL_PA_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_Search1_Image.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Date)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_PA)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		
		#region 속성 정의 
	
		private COM.OraDB MyOraDB = new COM.OraDB();  
		private COM.ComFunction MyComFunction    = new COM.ComFunction();
		private string  _flag ="S";

		private Pop_Thread _popWait = null;
		private Thread temp_thread            = null;



		#endregion 

		#region 멤버 메서드 

		private void Init_Form()
		{ 
			try
			{
				this.Text = "PA Uploading";
				lbl_MainTitle.Text = "PA Uploading";

			
				tbtn_Append.Enabled  = false;
				tbtn_Delete.Enabled  = false;
				tbtn_Insert.Enabled  = false;
				tbtn_Print.Enabled   = false;


				fgrid_PA.Set_Grid("SEM_PA", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_PA.Set_Action_Image(img_Action);
				fgrid_PA.Font  = new Font("Verdana",8);
				fgrid_PA.ExtendLastCol = false;
				fgrid_PA.AllowEditing = true;
				fgrid_PA.AllowSorting  = AllowSortingEnum.None;
				fgrid_PA.AllowDragging = AllowDraggingEnum.None;
				
				_flag  = "S";	


				DataTable dt_list;
						
				///Factory
				dt_list = ClassLib.ComFunction.Select_Factory_List();
				ClassLib.ComCtl.Set_ComboList(dt_list,cmb_Factory,0,1,false,COM.ComVar.ComboList_Visible.Name);
				cmb_Factory.SelectedValue  ="QD";
				
	
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}



		private void Event_Tbtn_Save()
		{
			try
			{
				// 행 수정상태 해제 
				fgrid_PA.Select(fgrid_PA.Selection.r1, fgrid_PA.Selection.c1, fgrid_PA.Selection.r1, fgrid_PA.Selection.c1, false);


				DialogResult result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
				if (result == DialogResult.No) return;



				_popWait = new Pop_Thread();
				temp_thread = new Thread(new ThreadStart(_popWait.Start));

				if (temp_thread != null)
				{
					temp_thread.Start();
				}                            


				bool save_flag = Save_PA();


				if (save_flag)
				{
					//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
					fgrid_PA.Rows.Count  = fgrid_PA.Rows.Fixed;

					//data최신것 설정...
					DataTable  dt_list;

					dt_list = Select_Date_List();
					ClassLib.ComCtl.Set_ComboList(dt_list,cmb_Date,0,1,false,COM.ComVar.ComboList_Visible.Name);
					cmb_Date.SelectedIndex =0;


								
					tbtn_Search_Click(null,null);
				}
				else
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}
			}
			catch
			{

			}
			finally
			{

				this.Cursor = Cursors.Default;
				if (temp_thread != null) temp_thread.Abort();
			}
		}



		private void Event_Tbtn_New()
		{

			// 조회시 필수조건 체크 
			C1.Win.C1List.C1Combo[] cmb_array = { cmb_Factory, cmb_Season};
			System.Windows.Forms.TextBox[] txt_array = { };
			bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
			if (!previous_check) return;


			if (((cmb_Factory.SelectedValue.ToString() == "QD") || (cmb_Factory.SelectedValue.ToString() == "VJ") || (cmb_Factory.SelectedValue.ToString() == "JJ")) ==false)
			{
				ClassLib.ComFunction.User_Message("Factory Check ", "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}



			fgrid_PA.Set_Grid("SEM_PA", "1",1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_PA.Set_Action_Image(img_Action);
			fgrid_PA.Font  = new Font("Verdana",8);
			
			fgrid_PA.ForeColor = Color.Black;
			fgrid_PA.AllowEditing = true;
			fgrid_PA.AllowSorting  = AllowSortingEnum.None;
			fgrid_PA.AllowDragging = AllowDraggingEnum.None;
			fgrid_PA.ExtendLastCol = false;
			_flag="L"; 




			txt_Style.Text = "";
			txt_Dev.Text = "";


			fgrid_PA.Rows.Count = fgrid_PA.Rows.Fixed;
			btn_upload_Click(null, null);

		}



		private void btn_upload_Click(object sender, EventArgs e)
		{
			try
			{
				OleDbDataReader reader;


				string strSrc = "";
				string strSheet = "Detail";
			

				openFileDialog1.InitialDirectory = "";

				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					strSrc = openFileDialog1.FileName;
				}



				
				_popWait = new Pop_Thread();
				temp_thread = new Thread(new ThreadStart(_popWait.Start));


				if (temp_thread != null)
				{
					temp_thread.Start();
				}                            




				string strSql = " SELECT A.*" +
					"   FROM [" + strSheet + "$] A ";
					
			
				
				reader = ClassLib.ComFunction.Read_Excel(strSrc, strSql);
							
				
				string[] str_d = new string[reader.FieldCount+1];			

				while (reader.Read())
				{
					for(int i=0; i<reader.FieldCount; i++)
					{
						str_d[i] = ClassLib.ComFunction.Convert_dtType(reader[i].GetType().Name.ToString(), reader[i].ToString());
						str_d[reader.FieldCount-1] = cmb_Factory.SelectedValue.ToString();
					}


		

					fgrid_PA.AddItem(str_d, fgrid_PA.Rows.Count,1);
					//fgrid_PA[fgrid_PA.Rows.Count - 1, 0] = "I";


					str_d.Initialize();							
				}

				
				Set_OBS_ID();
				//Merge
//				fgrid_PA.AllowMerging = AllowMergingEnum.Free;
//				for (int j=1  ; j<=fgrid_PA.Cols.Count -1;j++)
//					fgrid_PA.Cols[j].AllowMerging = true;

				


			}
			catch
			{

			}
			finally
			{
				this.Cursor = Cursors.Default;
				if (temp_thread != null) temp_thread.Abort();

			}


		}


		private void Set_OBS_ID()
		{
			
			

			DataTable dt_ret; 
			dt_ret = Select_OBS_ID();
			
			if (_flag  ==  "L")
			{
				fgrid_PA[1,(int)ClassLib.TBSEM_PA_UPLOAD.IxOBS_QTY_1] = dt_ret.Rows[0].ItemArray[0].ToString();
				fgrid_PA[1,(int)ClassLib.TBSEM_PA_UPLOAD.IxOBS_QTY_2] = dt_ret.Rows[1].ItemArray[0].ToString();
				fgrid_PA[1,(int)ClassLib.TBSEM_PA_UPLOAD.IxOBS_QTY_3] = dt_ret.Rows[2].ItemArray[0].ToString();
			}
			else
			{
				fgrid_PA[1,(int)ClassLib.TBSEM_PA.IxOBS_QTY_1] = dt_ret.Rows[0].ItemArray[0].ToString();
				fgrid_PA[1,(int)ClassLib.TBSEM_PA.IxOBS_QTY_2] = dt_ret.Rows[1].ItemArray[0].ToString();
				fgrid_PA[1,(int)ClassLib.TBSEM_PA.IxOBS_QTY_3] = dt_ret.Rows[2].ItemArray[0].ToString();
				

			}

			


		}


		private void Event_Tbtn_Search()
		{
			// 조회시 필수조건 체크 
			C1.Win.C1List.C1Combo[] cmb_array = { cmb_Factory, cmb_Season, cmb_Date };
			System.Windows.Forms.TextBox[] txt_array = { };
			bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
			if (!previous_check) return;


			string factory  = cmb_Factory.SelectedValue.ToString();
			string season   = ClassLib.ComFunction.Empty_Combo(cmb_Season, " ");
			string date   = ClassLib.ComFunction.Empty_Combo(cmb_Date, " ");
			string style    = ClassLib.ComFunction.Empty_TextBox(txt_Style, " ").Replace("-", "").ToUpper().Trim();
			string dev   = ClassLib.ComFunction.Empty_TextBox(txt_Dev, " ").ToUpper().Trim();

			System.Data.DataTable dt_ret = Select_PA_List(factory, season, date, style, dev);
			Display_Grid(dt_ret);
			dt_ret.Dispose();

			Set_OBS_ID();
		}


		private void Display_Grid (DataTable arg_ret)
		{
			fgrid_PA.Rows.Count  = fgrid_PA.Rows.Fixed;

			for(int i = 0; i < arg_ret.Rows.Count; i++)
			{  
				fgrid_PA.AddItem(arg_ret.Rows[i].ItemArray, fgrid_PA.Rows.Count, 1);

				if (fgrid_PA[fgrid_PA.Rows.Count -1,(int)ClassLib.TBSEM_PA.IxCHANGE_R_FLG_01].ToString() == "I")
					fgrid_PA.GetCellRange(fgrid_PA.Rows.Count -1,1 ,fgrid_PA.Rows.Count -1,fgrid_PA.Cols.Count -1).StyleNew.ForeColor =   Color.Blue;

				if (fgrid_PA[fgrid_PA.Rows.Count -1,(int)ClassLib.TBSEM_PA.IxCHANGE_R_FLG_01].ToString() == "U")
					fgrid_PA.GetCellRange(fgrid_PA.Rows.Count -1,1 ,fgrid_PA.Rows.Count -1,fgrid_PA.Cols.Count -1).StyleNew.ForeColor =   Color.Green;

				if (fgrid_PA[fgrid_PA.Rows.Count -1,(int)ClassLib.TBSEM_PA.IxCHANGE_R_FLG_01].ToString() == "D")
					fgrid_PA.GetCellRange(fgrid_PA.Rows.Count -1,1 ,fgrid_PA.Rows.Count -1,fgrid_PA.Cols.Count -1).StyleNew.ForeColor =   Color.Red;
			}


			//Merge
//			fgrid_PA.AllowMerging = AllowMergingEnum.Free;
//			for (int j=1  ; j<=fgrid_PA.Cols.Count -1;j++)
//				fgrid_PA.Cols[j].AllowMerging = true;


		}



		#endregion

		#region 이벤트 처리

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{

							
				fgrid_PA.Set_Grid("SEM_PA", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_PA.Set_Action_Image(img_Action);
				fgrid_PA.Font  = new Font("Verdana",8);
				fgrid_PA.ExtendLastCol = false;
				fgrid_PA.ForeColor = Color.Black;
				fgrid_PA.AllowEditing = true;
				fgrid_PA.AllowSorting  = AllowSortingEnum.None;
				fgrid_PA.AllowDragging = AllowDraggingEnum.None;
				
				_flag  = "S";				
   
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Search();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}


		private void cmb_Factory_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				DataTable  dt_list;
			
				dt_list = Select_Season_List();
				ClassLib.ComCtl.Set_ComboList(dt_list,cmb_Season,0,1,false,COM.ComVar.ComboList_Visible.Name);
				cmb_Season.SelectedIndex = 0;
			}
			catch
			{
				
			}
	
		}


		private void cmb_Season_TextChanged(object sender, System.EventArgs e)
		{
			
			try
			{
				
				DataTable  dt_list;

				dt_list = Select_Date_List();
				ClassLib.ComCtl.Set_ComboList(dt_list,cmb_Date,0,1,false,COM.ComVar.ComboList_Visible.Name);
				cmb_Date.SelectedIndex =0;
			}
			catch
			{

				
			}


		}


		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				


				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_New();
			}
			catch (Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_New", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
			
		}


		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				


				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Save();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
			
		}

	
		
	

		#endregion 

		#region DB
 
//
//		update  sem_pa set upload_ymd ='20090408'  
//		where season_cd  ='202002'
//		and upload_ymd ='20090410'
//
//		select *
//		from sem_season  
//		where season_name ='SU20'

		private bool Save_PA( )
		{
			try
			{ 
					

				DataSet ret;

				#region  Save PA Upload 처리	
		
				MyOraDB.ReDim_Parameter(11); 

				//Package Name
				MyOraDB.Process_Name= "PKG_SEM_PA.SAVE_SEM_PA_UPLOAD";
				
		     
				MyOraDB.Parameter_Name[0]  = "ARG_PRO_CATEGORY";      
				MyOraDB.Parameter_Name[1]  = "ARG_OS_CODE";        
				MyOraDB.Parameter_Name[2]  = "ARG_MODEL_OFFERING";      
				MyOraDB.Parameter_Name[3]  = "ARG_DEV_CODE";   
				MyOraDB.Parameter_Name[4]  = "ARG_STYLE_CD";       
				MyOraDB.Parameter_Name[5]  = "ARG_STYLE_CLR";     
				MyOraDB.Parameter_Name[6]  = "ARG_DEV_NAME";     
				MyOraDB.Parameter_Name[7]  = "ARG_OBS_QTY_1";       
				MyOraDB.Parameter_Name[8]  = "ARG_OBS_QTY_2"; 	  	 
				MyOraDB.Parameter_Name[9]  = "ARG_OBS_QTY_3";       
				MyOraDB.Parameter_Name[10] = "ARG_FACTORY";       
				 
			
				//Parameter Type
				for (int i =0 ; i< 11; i++)
					MyOraDB.Parameter_Type[i] = 1; 
				

				MyOraDB.Parameter_Values = new string[(fgrid_PA.Rows.Count  - fgrid_PA.Rows.Fixed)*
												   (fgrid_PA.Cols.Count-1)] ;

				int k =0;
				for (int i=fgrid_PA.Rows.Fixed ; i < fgrid_PA.Rows.Count ; i++)
					for (int j = 1; j<fgrid_PA.Cols.Count ; j++)
						MyOraDB.Parameter_Values[k++] =  (fgrid_PA[i,j] == null) ? " ": fgrid_PA[i,j].ToString().ToUpper().Trim();    
				

						
				MyOraDB.Add_Modify_Parameter(true);   //첫번째....
 	 

				#endregion


				#region  Save PA					
			

				MyOraDB.ReDim_Parameter(4); 

				MyOraDB.Process_Name= "PKG_SEM_PA.SAVE_SEM_PA";
				
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SEASON_CD";
				MyOraDB.Parameter_Name[2] = "ARG_UPLOAD_YMD";
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

		
				for (int i =0 ; i< 4; i++)
					MyOraDB.Parameter_Type[i] = 1; 
				

				//Data부
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = cmb_Season.Columns[0].Text;
				MyOraDB.Parameter_Values[2] =  System.DateTime.Now.ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;
				
				
				MyOraDB.Add_Modify_Parameter(false);	

				#endregion 

				ret= MyOraDB.Exe_Modify_Procedure();


				return true;

				

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_PA",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}

		}

	
		private DataTable Select_OBS_ID()
		{ 
			//COM.OraDB MyOraDB = new COM.OraDB(); 


			DataSet ds_ret;
			
			

			string process_name = "PKG_SEM_PA_SELECT.SELECT_OBS_ID";

			
			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_SEASON";
			MyOraDB.Parameter_Name[2]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.Cursor;

		
			MyOraDB.Parameter_Values[0]  = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]  = cmb_Season.SelectedValue.ToString();

			
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}

		
		private DataTable Select_Season_List()
		{ 
			

			DataSet ds_ret;
			
			

			string process_name = "PKG_SEM_PA_SELECT.SELECT_SEASON";

			
			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.Cursor;

		
			MyOraDB.Parameter_Values[0]  = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}


		private DataTable Select_Date_List()
		{ 
			
			DataSet ds_ret;
			
			

			string process_name = "PKG_SEM_PA_SELECT.SELECT_DATE";

			
			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_SEASON";
			MyOraDB.Parameter_Name[2]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.Cursor;

		
			MyOraDB.Parameter_Values[0]  = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]  = cmb_Season.Columns[0].Text;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}

	
		private DataTable Select_PA_List(string arg_factory, string arg_season, string arg_date, string arg_style, string arg_dev)
		{ 
			//COM.OraDB MyOraDB = new COM.OraDB(); 


			DataSet ds_ret;
			
			

			string process_name = "PKG_SEM_PA_SELECT.SELECT_PA";

			
			MyOraDB.ReDim_Parameter(6); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_SEASON";
			MyOraDB.Parameter_Name[2]  = "ARG_DATE";
			MyOraDB.Parameter_Name[3]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4]  = "ARG_DEV_CD";
			MyOraDB.Parameter_Name[5]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;		
			MyOraDB.Parameter_Type[5]  = (int)OracleType.Cursor;

		
			MyOraDB.Parameter_Values[0]  = arg_factory;
			MyOraDB.Parameter_Values[1]  = arg_season;
			MyOraDB.Parameter_Values[2]  = arg_date;
			MyOraDB.Parameter_Values[3]  = arg_style;
			MyOraDB.Parameter_Values[4]  = arg_dev;			
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}

		

		#endregion 

		private void Form_EL_PA_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

	
		
	}

}

