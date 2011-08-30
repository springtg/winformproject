using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;

namespace FlexOrder.ExpOBS
{
	public class Form_EO_Hist : COM.OrderWinForm.Form_Top
	{
		#region 컨트롤 정의 및 리소스 정리 
		private System.Windows.Forms.Panel pnl_Search1_Image;
		private C1.Win.C1List.C1Combo cmb_OBS_Type;
		private System.Windows.Forms.PictureBox pictureBox2;
		private C1.Win.C1List.C1Combo cmb_OBS_ID;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label lbl_OBS_Type;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_OBS_Id;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Panel panel1;
		public COM.FSP fgrid_Main;
		public System.Windows.Forms.Panel pnl_Body;
		private C1.Win.C1List.C1Combo cmb_Real_YN;
		private System.Windows.Forms.Label lbl_OBS_Real;
		private System.Windows.Forms.Label lbl_OBS_Seq_Nu;
		private System.Windows.Forms.Label lbl_OBS_Nu;
		private System.Windows.Forms.TextBox txt_OBS_Seq_Nu;
		private System.Windows.Forms.TextBox txt_OBS_Nu;
		private System.Windows.Forms.TextBox txt_Style_Cd;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem ctm_OBS_REQ;
		private System.Windows.Forms.MenuItem ctm_CSOBS_REQ;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem ctm_OBS_Sel;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem ctm_OBS_Type_Change;
		private System.ComponentModel.IContainer components = null;

		public Form_EO_Hist()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EO_Hist));
			this.pnl_Search1_Image = new System.Windows.Forms.Panel();
			this.txt_Style_Cd = new System.Windows.Forms.TextBox();
			this.lbl_OBS_Nu = new System.Windows.Forms.Label();
			this.txt_OBS_Seq_Nu = new System.Windows.Forms.TextBox();
			this.lbl_OBS_Seq_Nu = new System.Windows.Forms.Label();
			this.txt_OBS_Nu = new System.Windows.Forms.TextBox();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.lbl_OBS_Real = new System.Windows.Forms.Label();
			this.cmb_Real_YN = new C1.Win.C1List.C1Combo();
			this.cmb_OBS_ID = new C1.Win.C1List.C1Combo();
			this.lbl_OBS_Id = new System.Windows.Forms.Label();
			this.cmb_OBS_Type = new C1.Win.C1List.C1Combo();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.lbl_OBS_Type = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.ctm_OBS_REQ = new System.Windows.Forms.MenuItem();
			this.ctm_CSOBS_REQ = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.ctm_OBS_Sel = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.ctm_OBS_Type_Change = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search1_Image.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Real_YN)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_Body.SuspendLayout();
			this.panel1.SuspendLayout();
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
			// pnl_Search1_Image
			// 
			this.pnl_Search1_Image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_Search1_Image.Controls.Add(this.txt_Style_Cd);
			this.pnl_Search1_Image.Controls.Add(this.lbl_OBS_Nu);
			this.pnl_Search1_Image.Controls.Add(this.txt_OBS_Seq_Nu);
			this.pnl_Search1_Image.Controls.Add(this.lbl_OBS_Seq_Nu);
			this.pnl_Search1_Image.Controls.Add(this.txt_OBS_Nu);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Style);
			this.pnl_Search1_Image.Controls.Add(this.lbl_OBS_Real);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Real_YN);
			this.pnl_Search1_Image.Controls.Add(this.cmb_OBS_ID);
			this.pnl_Search1_Image.Controls.Add(this.lbl_OBS_Id);
			this.pnl_Search1_Image.Controls.Add(this.cmb_OBS_Type);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox2);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Factory);
			this.pnl_Search1_Image.Controls.Add(this.lbl_OBS_Type);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Factory);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox1);
			this.pnl_Search1_Image.Controls.Add(this.lbl_SubTitle1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox5);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox8);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox3);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox6);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox9);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox4);
			this.pnl_Search1_Image.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search1_Image.Name = "pnl_Search1_Image";
			this.pnl_Search1_Image.Size = new System.Drawing.Size(1000, 110);
			this.pnl_Search1_Image.TabIndex = 28;
			// 
			// txt_Style_Cd
			// 
			this.txt_Style_Cd.BackColor = System.Drawing.Color.White;
			this.txt_Style_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_Cd.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Style_Cd.Location = new System.Drawing.Point(445, 55);
			this.txt_Style_Cd.MaxLength = 100;
			this.txt_Style_Cd.Name = "txt_Style_Cd";
			this.txt_Style_Cd.Size = new System.Drawing.Size(210, 20);
			this.txt_Style_Cd.TabIndex = 151;
			this.txt_Style_Cd.Text = "";
			// 
			// lbl_OBS_Nu
			// 
			this.lbl_OBS_Nu.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_OBS_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Nu.ImageIndex = 2;
			this.lbl_OBS_Nu.ImageList = this.img_Label;
			this.lbl_OBS_Nu.Location = new System.Drawing.Point(344, 74);
			this.lbl_OBS_Nu.Name = "lbl_OBS_Nu";
			this.lbl_OBS_Nu.Size = new System.Drawing.Size(100, 27);
			this.lbl_OBS_Nu.TabIndex = 150;
			this.lbl_OBS_Nu.Text = "OBS Nu";
			this.lbl_OBS_Nu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_OBS_Seq_Nu
			// 
			this.txt_OBS_Seq_Nu.BackColor = System.Drawing.Color.White;
			this.txt_OBS_Seq_Nu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_Seq_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_Seq_Nu.Location = new System.Drawing.Point(781, 33);
			this.txt_OBS_Seq_Nu.MaxLength = 100;
			this.txt_OBS_Seq_Nu.Name = "txt_OBS_Seq_Nu";
			this.txt_OBS_Seq_Nu.Size = new System.Drawing.Size(210, 20);
			this.txt_OBS_Seq_Nu.TabIndex = 147;
			this.txt_OBS_Seq_Nu.Text = "";
			// 
			// lbl_OBS_Seq_Nu
			// 
			this.lbl_OBS_Seq_Nu.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_OBS_Seq_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Seq_Nu.ImageIndex = 2;
			this.lbl_OBS_Seq_Nu.ImageList = this.img_Label;
			this.lbl_OBS_Seq_Nu.Location = new System.Drawing.Point(680, 29);
			this.lbl_OBS_Seq_Nu.Name = "lbl_OBS_Seq_Nu";
			this.lbl_OBS_Seq_Nu.Size = new System.Drawing.Size(100, 27);
			this.lbl_OBS_Seq_Nu.TabIndex = 146;
			this.lbl_OBS_Seq_Nu.Text = "OBS Seq Nu";
			this.lbl_OBS_Seq_Nu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_OBS_Nu
			// 
			this.txt_OBS_Nu.BackColor = System.Drawing.Color.White;
			this.txt_OBS_Nu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_Nu.Location = new System.Drawing.Point(445, 77);
			this.txt_OBS_Nu.MaxLength = 100;
			this.txt_OBS_Nu.Name = "txt_OBS_Nu";
			this.txt_OBS_Nu.Size = new System.Drawing.Size(210, 20);
			this.txt_OBS_Nu.TabIndex = 140;
			this.txt_OBS_Nu.Text = "";
			// 
			// lbl_Style
			// 
			this.lbl_Style.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Style.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Style.ImageIndex = 2;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(344, 52);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 27);
			this.lbl_Style.TabIndex = 129;
			this.lbl_Style.Text = "Style Code";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_OBS_Real
			// 
			this.lbl_OBS_Real.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_OBS_Real.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Real.ImageIndex = 1;
			this.lbl_OBS_Real.ImageList = this.img_Label;
			this.lbl_OBS_Real.Location = new System.Drawing.Point(344, 29);
			this.lbl_OBS_Real.Name = "lbl_OBS_Real";
			this.lbl_OBS_Real.Size = new System.Drawing.Size(100, 27);
			this.lbl_OBS_Real.TabIndex = 144;
			this.lbl_OBS_Real.Text = "OBS Real";
			this.lbl_OBS_Real.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Real_YN
			// 
			this.cmb_Real_YN.AddItemCols = 0;
			this.cmb_Real_YN.AddItemSeparator = ';';
			this.cmb_Real_YN.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Real_YN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Real_YN.Caption = "";
			this.cmb_Real_YN.CaptionHeight = 17;
			this.cmb_Real_YN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Real_YN.ColumnCaptionHeight = 18;
			this.cmb_Real_YN.ColumnFooterHeight = 18;
			this.cmb_Real_YN.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Real_YN.ContentHeight = 15;
			this.cmb_Real_YN.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Real_YN.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Real_YN.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Real_YN.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Real_YN.EditorHeight = 15;
			this.cmb_Real_YN.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Real_YN.GapHeight = 2;
			this.cmb_Real_YN.ItemHeight = 15;
			this.cmb_Real_YN.Location = new System.Drawing.Point(445, 33);
			this.cmb_Real_YN.MatchEntryTimeout = ((long)(2000));
			this.cmb_Real_YN.MaxDropDownItems = ((short)(5));
			this.cmb_Real_YN.MaxLength = 32767;
			this.cmb_Real_YN.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Real_YN.Name = "cmb_Real_YN";
			this.cmb_Real_YN.PartialRightColumn = false;
			this.cmb_Real_YN.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Real_YN.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Real_YN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Real_YN.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Real_YN.Size = new System.Drawing.Size(210, 19);
			this.cmb_Real_YN.TabIndex = 142;
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
			this.cmb_OBS_ID.Location = new System.Drawing.Point(111, 77);
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
			this.cmb_OBS_ID.TabIndex = 131;
			// 
			// lbl_OBS_Id
			// 
			this.lbl_OBS_Id.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_OBS_Id.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Id.ImageIndex = 1;
			this.lbl_OBS_Id.ImageList = this.img_Label;
			this.lbl_OBS_Id.Location = new System.Drawing.Point(10, 74);
			this.lbl_OBS_Id.Name = "lbl_OBS_Id";
			this.lbl_OBS_Id.Size = new System.Drawing.Size(100, 27);
			this.lbl_OBS_Id.TabIndex = 128;
			this.lbl_OBS_Id.Text = "OBS_ID";
			this.lbl_OBS_Id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_OBS_Type.Location = new System.Drawing.Point(111, 55);
			this.cmb_OBS_Type.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_Type.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_Type.MaxLength = 32767;
			this.cmb_OBS_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_Type.Name = "cmb_OBS_Type";
			this.cmb_OBS_Type.PartialRightColumn = false;
			this.cmb_OBS_Type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_OBS_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type.Size = new System.Drawing.Size(210, 19);
			this.cmb_OBS_Type.TabIndex = 138;
			this.cmb_OBS_Type.TextChanged += new System.EventHandler(this.cmb_OBS_Type_TextChanged);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(168, -1);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(810, 32);
			this.pictureBox2.TabIndex = 135;
			this.pictureBox2.TabStop = false;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 29);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 27);
			this.lbl_Factory.TabIndex = 126;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_OBS_Type
			// 
			this.lbl_OBS_Type.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Type.ImageIndex = 1;
			this.lbl_OBS_Type.ImageList = this.img_Label;
			this.lbl_OBS_Type.Location = new System.Drawing.Point(10, 51);
			this.lbl_OBS_Type.Name = "lbl_OBS_Type";
			this.lbl_OBS_Type.Size = new System.Drawing.Size(100, 27);
			this.lbl_OBS_Type.TabIndex = 127;
			this.lbl_OBS_Type.Text = "OBS_TYPE";
			this.lbl_OBS_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.Location = new System.Drawing.Point(111, 33);
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
			this.cmb_Factory.TabIndex = 125;
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
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(172, 32);
			this.lbl_SubTitle1.TabIndex = 0;
			this.lbl_SubTitle1.Text = "      OBS History";
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
			this.pictureBox5.Size = new System.Drawing.Size(19, 64);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.Color.Blue;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(910, 96);
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
			this.pictureBox3.Size = new System.Drawing.Size(32, 75);
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.Color.Blue;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 96);
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
			this.pictureBox9.Location = new System.Drawing.Point(72, 96);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(912, 14);
			this.pictureBox9.TabIndex = 9;
			this.pictureBox9.TabStop = false;
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
			this.pictureBox4.Size = new System.Drawing.Size(952, 78);
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.panel1);
			this.pnl_Body.DockPadding.Left = 10;
			this.pnl_Body.DockPadding.Right = 10;
			this.pnl_Body.Location = new System.Drawing.Point(0, 180);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 460);
			this.pnl_Body.TabIndex = 38;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.fgrid_Main);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(10, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(996, 460);
			this.panel1.TabIndex = 0;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this.fgrid_Main.ContextMenu = this.contextMenu1;
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(996, 460);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8pt;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;ForeColor:Black;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;ForeColor:Black;}	Focus{BackColor:236, 247, 187;ForeColor:Black;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 61;
			this.fgrid_Main.Click += new System.EventHandler(this.fgrid_Main_Click);
			this.fgrid_Main.DoubleClick += new System.EventHandler(this.fgrid_Main_DoubleClick);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.ctm_OBS_REQ,
																						 this.ctm_CSOBS_REQ,
																						 this.menuItem3,
																						 this.ctm_OBS_Sel,
																						 this.menuItem1,
																						 this.ctm_OBS_Type_Change});
			// 
			// ctm_OBS_REQ
			// 
			this.ctm_OBS_REQ.Index = 0;
			this.ctm_OBS_REQ.Text = "OBS Request";
			this.ctm_OBS_REQ.Click += new System.EventHandler(this.ctm_OBS_REQ_Click);
			// 
			// ctm_CSOBS_REQ
			// 
			this.ctm_CSOBS_REQ.Index = 1;
			this.ctm_CSOBS_REQ.Text = "CS OBS Request";
			this.ctm_CSOBS_REQ.Click += new System.EventHandler(this.ctm_CSOBS_REQ_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "-";
			// 
			// ctm_OBS_Sel
			// 
			this.ctm_OBS_Sel.Index = 3;
			this.ctm_OBS_Sel.Text = "OBS By Option";
			this.ctm_OBS_Sel.Click += new System.EventHandler(this.ctm_OBS_Sel_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 4;
			this.menuItem1.Text = "-";
			// 
			// ctm_OBS_Type_Change
			// 
			this.ctm_OBS_Type_Change.Index = 5;
			this.ctm_OBS_Type_Change.Text = "OBS Type Change";
			this.ctm_OBS_Type_Change.Click += new System.EventHandler(this.ctm_OBS_Type_Change_Click);
			// 
			// Form_EO_Hist
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Search1_Image);
			this.Font = new System.Drawing.Font("Verdana", 8F);
			this.Name = "Form_EO_Hist";
			this.Load += new System.EventHandler(this.Form_EO_Hist_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search1_Image, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search1_Image.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Real_YN)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의

		private int _Rowfixed = 6;

		private ClassLib.OraDB  MyOraDB = new ClassLib.OraDB();

		#endregion 

		#region 멤버 메서드 
		private void Init_Form()
		{ 
			DataTable dt_list;

			//Setting  Title
			this.Text = "OBS History";
			this.lbl_MainTitle.Text = "OBS History."; 
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
//
//				//Button 활성화
//				tbtn_Save.Enabled = false;  tbtn_Append.Enabled = false;   tbtn_Delete.Enabled = false;   tbtn_Insert.Enabled = false; 
//			}
//			catch
//			{
//			}

			#endregion
			
			#region  그리드 설정
			//Setting  Main Tail(TBSEM_OBS_HIST)
			fgrid_Main.Set_Grid( "SEM_OBS_HIST", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true); 
			fgrid_Main.Font  = new Font("Verdana",8);

			ClassLib.ComFunction.Set_Size_Grid(fgrid_Main, _Rowfixed, (int)ClassLib.TBSEM_OBS_HIST.lxGEN);
			for (int i=1; i<_Rowfixed; i++)
				fgrid_Main[i, (int)ClassLib.TBSEM_OBS_HIST.IxFACTORY-1] = " ";

			//Gender Size  색상 + Bold
			ClassLib.ComFunction.Set_Head_Bold("01", fgrid_Main, _Rowfixed, (int)ClassLib.TBSEM_OBS_HIST.lxGEN);
			ClassLib.ComFunction.Set_Gen_Color("01",fgrid_Main,_Rowfixed,1,(int)ClassLib.TBSEM_OBS_HIST.lxGEN);			

            #endregion

			//Setting Factory Combo
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			//Setting Po Type
			dt_list = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(),ClassLib.ComVar.CxOBS_Type);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OBS_Type, 1, 2); 
			cmb_OBS_Type.SelectedValue = "FT";

			//Setting Real Obs yn
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory,ClassLib.ComVar.CxReq_yn);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Real_YN, 1, 2); 
			cmb_Real_YN.SelectedValue = "01";

		}


		
		/// <summary>
		/// Sb_Pop_OBS: OBS Popup창
		/// </summary>
		private void  SB_Pop_Type_Change()
		{			
		

			FlexOrder.ExpOBS.POP_EO_Type_Change  pop_form = new ExpOBS.POP_EO_Type_Change();
	
			COM.ComVar.Parameter_PopUp = new string[]
									 {
										 cmb_Factory.SelectedValue.ToString(),
										 cmb_OBS_ID.Text ,
										 cmb_OBS_Type.Columns[0].Text,
										 fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_HIST.IxSTYLE_CD].ToString(),										 
										 fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_HIST.IxOBS_NU].ToString(),
										 fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_HIST.IxOBS_SEQ_NU].ToString(),
										 fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_HIST.IxCHG_NU].ToString(),
										 fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_HIST.IxTOT_QTY].ToString()
									 };
				
			pop_form.ShowDialog();


		}




		/// <summary>
		/// Sb_Pop_OBS: OBS Popup창
		/// </summary>
		private void Sb_Pop_OBS()
		{
			string sOBS_Real ="";

			if (fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_HIST.IxOBS_NU].ToString().Substring(0,1) == "C")
				sOBS_Real = ClassLib.ComVar.ConsReal_N;
			else
				sOBS_Real = ClassLib.ComVar.ConsReal_Y;

			ClassLib.ComFunction.Sb_Pop_OBS_Info
				(
				sOBS_Real,
				cmb_Factory.SelectedValue.ToString(),
				cmb_OBS_Type.SelectedValue.ToString(),
				cmb_OBS_ID.Text.ToString(),
				fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_HIST.IxSTYLE_CD].ToString(),
				fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_HIST.IxOBS_NU].ToString(),
				fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_HIST.IxOBS_SEQ_NU].ToString(),
				fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_HIST.IxCHG_NU].ToString()
				);
		}																						



		private bool Check_Select()
		{  
			if ((cmb_Factory.SelectedIndex == -1) || (cmb_OBS_Type.SelectedIndex == -1)||
				(cmb_OBS_ID.Text == null)|| (cmb_Real_YN.SelectedIndex == -1)) 
			{
				MessageBox.Show ("조회 체크");
				return false;
			}
			else
			{
				return true;
			}
		}



		private void Display_Main_Grid(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{ 
			string sOBS_Nu="", sOBS_Seq_Nu="", sChg_Nu="", sGen, sSize, sQty;
			int iOBS_Nu, iOBS_Seq_Nu, iChg_Nu,iGen,  iFixed_Gen; ;

			fgrid_Main.Rows.Count = _Rowfixed;

			iFixed_Gen  = 0;
			iOBS_Nu     = (int)ClassLib.TBSEM_OBS_HIST.IxOBS_NU;
		    iOBS_Seq_Nu = (int)ClassLib.TBSEM_OBS_HIST.IxOBS_SEQ_NU;
			iChg_Nu     = (int)ClassLib.TBSEM_OBS_HIST.IxCHG_NU;
			iGen        = (int)ClassLib.TBSEM_OBS_HIST.lxGEN;

			for(int i=0; i<arg_dt.Rows.Count; i++)
			{					
				sGen        = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_HIST.lxGEN-1].ToString();
				sSize       = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_HIST.IxCS_SIZE-1].ToString();
				sQty        = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_HIST.IxORD_QTY-1].ToString();

				if ((sOBS_Nu != arg_dt.Rows[i].ItemArray[iOBS_Nu-1].ToString())||
					(sOBS_Seq_Nu != arg_dt.Rows[i].ItemArray[iOBS_Seq_Nu -1].ToString()) ||
					(sChg_Nu !=arg_dt.Rows[i].ItemArray[iChg_Nu-1].ToString()))
				{
					arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);

					arg_fgrid[arg_fgrid.Rows.Count-1, iGen+1] = " ";
					arg_fgrid[arg_fgrid.Rows.Count-1, iGen+2] = " ";
						
					for(int j=1; j<_Rowfixed; j++)
						if (arg_fgrid[j, iGen].ToString() == sGen)
							iFixed_Gen = j;

					for(int j=(int)ClassLib.TBSEM_OBS_HIST.IxCS_SIZE; j<fgrid_Main.Cols.Count; j++)
						fgrid_Main[fgrid_Main.Rows.Count-1, j]=0;
				}

				for(int j=iGen; j<arg_fgrid.Cols.Count; j++)
				{
					if (arg_fgrid[iFixed_Gen, j].ToString() == sSize)
					{
						arg_fgrid[arg_fgrid.Rows.Count-1, j] = sQty;
						break;
					}
				}

			    sOBS_Nu     = arg_dt.Rows[i].ItemArray[iOBS_Nu-1].ToString();
				sOBS_Seq_Nu = arg_dt.Rows[i].ItemArray[iOBS_Seq_Nu-1].ToString();
			    sChg_Nu     = arg_dt.Rows[i].ItemArray[iChg_Nu -1].ToString();
			} 

			//Merge
			arg_fgrid.AllowMerging = AllowMergingEnum.Free;				
				
			for (int i = (int)ClassLib.TBSEM_OBS_HIST.IxOBS_SEQ_NU ; i <= (int)ClassLib.TBSEM_OBS_HIST.lxGEN; i++)
			{
				arg_fgrid.Cols[i].AllowMerging  =true;
			}

		}
		

		#endregion

		#region  DB 컨트롤
		private DataTable Select_Main_Grid()
		{
			string strRlt;
 
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(8);

			strRlt  = "PKG_SEM_OBS_HIST.SELECT_SEM_OBS";
			MyOraDB.Process_Name =strRlt;

			MyOraDB.Parameter_Name[0] = "ARG_DIV";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[3] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[5] = "ARG_OBS_NU";
			MyOraDB.Parameter_Name[6] = "ARG_OBS_SEQ_NU";
			MyOraDB.Parameter_Name[7] = "OUT_CURSOR"; 
				
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;
	
			MyOraDB.Parameter_Values[0] = cmb_Real_YN.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = cmb_OBS_ID.Text.ToString();
			MyOraDB.Parameter_Values[3] = cmb_OBS_Type.SelectedValue.ToString();
			MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_TextBox(txt_Style_Cd, " ");
			MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_TextBox(txt_OBS_Nu, " ");
			MyOraDB.Parameter_Values[6] = ClassLib.ComFunction.Empty_TextBox(txt_OBS_Seq_Nu, " ");
			MyOraDB.Parameter_Values[7] = "";
  

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();
			
	
			if(ds_ret == null) return null ;
		
			return ds_ret.Tables[strRlt]; 
	
		}


		#endregion
	
		#region 이벤트 처리  

		#region  버튼 이벤트
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{  
			try
			{
				DataTable ds_ret;

				if (Check_Select()  == false)  return;

				ds_ret = Select_Main_Grid();

				if (ds_ret.Rows.Count  == 0) 
				{ ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch, this ); return;}

				Display_Main_Grid(ds_ret,fgrid_Main);
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch,this);
			}
			catch
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch,this);
			}
		}


		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			string mrd_Filename = "Form_EO_Hist.mrd" ;
			string txt_Filename = this.Name + ".txt"; 
			string Para         = " ";


			//조회조건들----------------------------------------------------------------------
			int  iCnt  = 7;
			string [] aHead =  new string[iCnt];	
			aHead[0]    = cmb_Factory.SelectedValue.ToString();
			aHead[1]    = cmb_OBS_Type.SelectedValue.ToString();
			aHead[2]    = cmb_OBS_ID.Text.ToString();
			aHead[3]    = cmb_Real_YN.SelectedValue.ToString();
			aHead[4]    = txt_Style_Cd.Text;
			aHead[5]    = txt_OBS_Nu.Text.ToString();
			aHead[6]    = txt_OBS_Seq_Nu.Text.ToString();
			//------------------- ------------------------------------------------------------


			//Parameter만들기
			Para  = "/rfn [" + Application.StartupPath + @"\"+ txt_Filename+ "]  /rv "; 			
			for (int i  = 1 ; i<= iCnt ; i++)
			{
				Para = Para +  "V_" + i.ToString().PadLeft (2,'0').ToString() + "[" + aHead[i-1] + "] ";
			}
			Para = Para + "V_USER[" + ClassLib.ComVar.This_User + "]";

			//File 출력 리스트
			fgrid_Main.SaveGrid(txt_Filename, FileFormatEnum.TextComma);

			//Report Base Form호출..
			FlexOrder.Report.Form_RD_Base  report = new FlexOrder.Report.Form_RD_Base(txt_Filename,  mrd_Filename, Para);
			report.Show();
		}

		#endregion



		private void cmb_OBS_Type_TextChanged(object sender, System.EventArgs e)
		{
			if(cmb_OBS_Type.SelectedIndex == -1) return;
			cmb_OBS_ID.ClearItems();
			ClassLib.ComFunction.Set_OBSID_CmbList(cmb_OBS_Type.SelectedValue.ToString(), cmb_OBS_ID);  
			cmb_OBS_ID.SelectedIndex = 0;

			if(cmb_OBS_Type.SelectedIndex == -1) return;
		}

		private void fgrid_Main_Click(object sender, System.EventArgs e)
		{
			ClassLib.ComFunction.Set_Gen_Color("01",fgrid_Main,_Rowfixed,fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_HIST.lxGEN);
		}


		
		private void fgrid_Main_DoubleClick(object sender, System.EventArgs e)
		{
			Sb_Pop_OBS();
		}


		#endregion

		#region 콘텍스트 메뉴

		private void ctm_OBS_REQ_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBS.Form_EO_Req  frm = new ExpOBS.Form_EO_Req(); 
			frm.Show();
		}

		private void ctm_CSOBS_REQ_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBSCS.Form_EC_Req frm = new ExpOBSCS.Form_EC_Req();
			frm.Show();
		}

		private void ctm_OBS_Sel_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBS.Form_EO_SRCH frm = new ExpOBS.Form_EO_SRCH();
			frm.Show();
		}
		

		private void ctm_OBS_Type_Change_Click(object sender, System.EventArgs e)
		{
		    SB_Pop_Type_Change();
		}



		#endregion

		private void Form_EO_Hist_Load(object sender, System.EventArgs e)
		{
			//Initiate  Form
			Init_Form();

		}



	}
}

