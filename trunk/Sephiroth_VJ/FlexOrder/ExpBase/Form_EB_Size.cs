using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.IO;



namespace FlexOrder.ExpBase
{

	public class Form_EB_Size : COM.OrderWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		public System.Windows.Forms.Panel panel1;
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
		private C1.Win.C1List.C1Combo cmb_Gen;
		private System.Windows.Forms.Label lbl_Presto;
		private System.Windows.Forms.Label lbl_Gen;
		private C1.Win.C1List.C1Combo cmb_Pst_yn;
		private System.ComponentModel.IContainer components = null;

		public Form_EB_Size()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EB_Size));
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnl_Search1_Image = new System.Windows.Forms.Panel();
			this.cmb_Pst_yn = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.cmb_Gen = new C1.Win.C1List.C1Combo();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.lbl_Presto = new System.Windows.Forms.Label();
			this.lbl_Gen = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			this.panel1.SuspendLayout();
			this.pnl_Search1_Image.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Pst_yn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Gen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
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
			// tbtn_Append
			// 
			this.tbtn_Append.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Append_Click);
			// 
			// tbtn_Insert
			// 
			this.tbtn_Insert.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Insert_Click);
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
			// tbtn_Color
			// 
			this.tbtn_Color.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_Color.Image")));
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
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
			this.pnl_Body.Location = new System.Drawing.Point(0, 193);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 460);
			this.pnl_Body.TabIndex = 37;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(10, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(996, 460);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;ForeColor:Black;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;ForeColor:Black;}	Focus{BackColor:236, 247, 187;ForeColor:Black;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 35;
			this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.pnl_Search1_Image);
			this.panel1.DockPadding.All = 8;
			this.panel1.Location = new System.Drawing.Point(0, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 128);
			this.panel1.TabIndex = 38;
			// 
			// pnl_Search1_Image
			// 
			this.pnl_Search1_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search1_Image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_Search1_Image.Controls.Add(this.cmb_Pst_yn);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Factory);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Gen);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Factory);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox2);
			this.pnl_Search1_Image.Controls.Add(this.lbl_SubTitle1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox5);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox8);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Presto);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Gen);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox3);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox4);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox6);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox9);
			this.pnl_Search1_Image.Location = new System.Drawing.Point(8, 8);
			this.pnl_Search1_Image.Name = "pnl_Search1_Image";
			this.pnl_Search1_Image.Size = new System.Drawing.Size(1000, 112);
			this.pnl_Search1_Image.TabIndex = 0;
			// 
			// cmb_Pst_yn
			// 
			this.cmb_Pst_yn.AddItemCols = 0;
			this.cmb_Pst_yn.AddItemSeparator = ';';
			this.cmb_Pst_yn.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Pst_yn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Pst_yn.Caption = "";
			this.cmb_Pst_yn.CaptionHeight = 17;
			this.cmb_Pst_yn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Pst_yn.ColumnCaptionHeight = 18;
			this.cmb_Pst_yn.ColumnFooterHeight = 18;
			this.cmb_Pst_yn.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Pst_yn.ContentHeight = 17;
			this.cmb_Pst_yn.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Pst_yn.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Pst_yn.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Pst_yn.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Pst_yn.EditorHeight = 17;
			this.cmb_Pst_yn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Pst_yn.GapHeight = 2;
			this.cmb_Pst_yn.ItemHeight = 15;
			this.cmb_Pst_yn.Location = new System.Drawing.Point(111, 80);
			this.cmb_Pst_yn.MatchEntryTimeout = ((long)(2000));
			this.cmb_Pst_yn.MaxDropDownItems = ((short)(5));
			this.cmb_Pst_yn.MaxLength = 32767;
			this.cmb_Pst_yn.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Pst_yn.Name = "cmb_Pst_yn";
			this.cmb_Pst_yn.PartialRightColumn = false;
			this.cmb_Pst_yn.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Pst_yn.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Pst_yn.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Pst_yn.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Pst_yn.Size = new System.Drawing.Size(210, 21);
			this.cmb_Pst_yn.TabIndex = 41;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 18;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Gen
			// 
			this.cmb_Gen.AddItemCols = 0;
			this.cmb_Gen.AddItemSeparator = ';';
			this.cmb_Gen.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Gen.Caption = "";
			this.cmb_Gen.CaptionHeight = 17;
			this.cmb_Gen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Gen.ColumnCaptionHeight = 18;
			this.cmb_Gen.ColumnFooterHeight = 18;
			this.cmb_Gen.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Gen.ContentHeight = 17;
			this.cmb_Gen.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Gen.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Gen.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Gen.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Gen.EditorHeight = 17;
			this.cmb_Gen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Gen.GapHeight = 2;
			this.cmb_Gen.ItemHeight = 15;
			this.cmb_Gen.Location = new System.Drawing.Point(111, 58);
			this.cmb_Gen.MatchEntryTimeout = ((long)(2000));
			this.cmb_Gen.MaxDropDownItems = ((short)(5));
			this.cmb_Gen.MaxLength = 32767;
			this.cmb_Gen.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Gen.Name = "cmb_Gen";
			this.cmb_Gen.PartialRightColumn = false;
			this.cmb_Gen.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Gen.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Gen.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Gen.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Gen.Size = new System.Drawing.Size(210, 21);
			this.cmb_Gen.TabIndex = 40;
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
			this.cmb_Factory.Size = new System.Drawing.Size(210, 21);
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
			this.lbl_SubTitle1.Text = "      OBS Info.";
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
			this.pictureBox5.Size = new System.Drawing.Size(19, 66);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.Color.Blue;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(910, 98);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(90, 14);
			this.pictureBox8.TabIndex = 8;
			this.pictureBox8.TabStop = false;
			// 
			// lbl_Presto
			// 
			this.lbl_Presto.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Presto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Presto.ImageIndex = 1;
			this.lbl_Presto.ImageList = this.img_Label;
			this.lbl_Presto.Location = new System.Drawing.Point(10, 80);
			this.lbl_Presto.Name = "lbl_Presto";
			this.lbl_Presto.Size = new System.Drawing.Size(100, 21);
			this.lbl_Presto.TabIndex = 20;
			this.lbl_Presto.Text = "Preato";
			this.lbl_Presto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Gen
			// 
			this.lbl_Gen.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Gen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Gen.ImageIndex = 1;
			this.lbl_Gen.ImageList = this.img_Label;
			this.lbl_Gen.Location = new System.Drawing.Point(10, 58);
			this.lbl_Gen.Name = "lbl_Gen";
			this.lbl_Gen.Size = new System.Drawing.Size(100, 21);
			this.lbl_Gen.TabIndex = 19;
			this.lbl_Gen.Text = "Gen";
			this.lbl_Gen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(0, 24);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 77);
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
			this.pictureBox4.Size = new System.Drawing.Size(952, 80);
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.Color.Blue;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 98);
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
			this.pictureBox9.Location = new System.Drawing.Point(72, 98);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(912, 14);
			this.pictureBox9.TabIndex = 9;
			this.pictureBox9.TabStop = false;
			// 
			// Form_EB_Size
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnl_Body);
			this.Name = "Form_EB_Size";
			this.Text = "Form_EB_Size";
			this.Load += new System.EventHandler(this.Form_EB_Size_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.panel1.ResumeLayout(false);
			this.pnl_Search1_Image.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Pst_yn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Gen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
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
			this.Text = "Size Information";
			this.lbl_MainTitle.Text = "Size Information"; 
			ClassLib.ComFunction.SetLangDic(this);


			#region 버튼 권한
//
//			try
//			{
//				COM.OraDB btn_control = new COM.OraDB();
//				DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
//				tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
//				btn_control = null;
//			}
//			catch
//			{
//			}

			#endregion

			DataTable dt_list;
		
			// 그리드 설정
			fgrid_Main.Set_Grid( "SEM_SIZE", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
			_Rowfixed = fgrid_Main.Rows.Fixed;
			fgrid_Main.Set_Action_Image(img_Action); 
			fgrid_Main.Font  = new Font("Verdana",8);
		

			// 콤보박스 설정
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			///
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxGen);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Gen, 1, 2, false);  
			cmb_Gen.SelectedIndex = 0;
			
			//
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxPst_yn);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Pst_yn, 1, 2, false);  
			cmb_Pst_yn.SelectedIndex = 0;
		
			/*
			Select_Size_List( ClassLib.ComVar.This_Factory, 
						      cmb_Gen.SelectedValue.ToString(), 
							  cmb_Pst_yn.SelectedValue.ToString(), 
							  fgrid_Main );
			*/
		}


		/// <summary>
		/// Set_Color : 배경색, 글자색 지정
		/// </summary>
		private void Set_Color()
		{
			ColorDialog clrdig = new ColorDialog();
			int r1, r2, sel_col;
			int from_row, to_row;
			int i; 

			r1 = fgrid_Main.Selection.r1;
			r2 = fgrid_Main.Selection.r2;
			sel_col = fgrid_Main.Selection.c1;

			from_row = (r1 < r2) ? r1 : r2;
			to_row = (r1 < r2) ? r2 : r1;

			if(clrdig.ShowDialog() == DialogResult.OK)
			{
				for(i = from_row; i <= to_row; i++)
				{
					fgrid_Main[i, sel_col] = clrdig.Color.ToArgb().ToString();

					if(fgrid_Main[i, 0].ToString() == "") fgrid_Main[i, 0] = "U";

					fgrid_Main.GetCellRange(i, sel_col).StyleNew.ForeColor = clrdig.Color;
				} //end for
			} // end if
		}


		#endregion 
	
		#region DB 컨트롤
		/// <summary>
		/// Select_Size_List : 사이즈 리스트 찾기 
		/// </summary>
		private void Select_Size_List(string arg_factory, string arg_gen, string arg_pst_yn, C1FlexGrid arg_fgrid)
		{
			try
			{
				string strRlt; int iCnt;
				DataSet ret; DataTable dt_list;
		    
				iCnt =  4;
				MyOraDB.ReDim_Parameter(iCnt); 
		    
				strRlt  = "PKG_SEM_SIZE.SELECT_SEM_SIZE";
				MyOraDB.Process_Name =strRlt;
	
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_GEN";   
				MyOraDB.Parameter_Name[2] = "ARG_PST_YN";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
				
				MyOraDB.Parameter_Type[0] =  (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] =  (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] =  (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] =  (int)OracleType.Cursor;						
	
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_gen;
				MyOraDB.Parameter_Values[2] = arg_pst_yn;  
				MyOraDB.Parameter_Values[3] = "";
				
				MyOraDB.Add_Select_Parameter(true); 
				ret = MyOraDB.Exe_Select_Procedure();
										
				if (ret == null)  return  ;
				dt_list  =  ret.Tables[strRlt];

				arg_fgrid.Rows.Count = _Rowfixed;  
	 
				for(int i = 0; i < dt_list.Rows.Count; i++)
				{
					arg_fgrid.AddItem(dt_list.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
					arg_fgrid[arg_fgrid.Rows.Count - 1, 0] = "";
				} 

				arg_fgrid.AutoSizeCols();
			}
			catch (Exception eMessage)
			{
				MessageBox.Show("Exception caught : " + eMessage);
			}
		}
		#endregion

		#region 이벤트 처리  

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				Select_Size_List( cmb_Factory.SelectedValue.ToString(), 
					cmb_Gen.SelectedValue.ToString(), 
					cmb_Pst_yn.SelectedValue.ToString(), 
					fgrid_Main );

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch,this);
			}
			catch 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch ,this);
			}

		}



		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			fgrid_Main.Add_Row(fgrid_Main.Rows.Count - 1);
			
			
			fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSEM_SIZE.lxFACTORY] = cmb_Factory.SelectedValue.ToString();
			fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSEM_SIZE.IxGEN]     = cmb_Gen.SelectedValue.ToString();
			fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSEM_SIZE.IxPST_YN]  = cmb_Pst_yn.SelectedValue.ToString();

			if(fgrid_Main.Rows.Count > _Rowfixed)
				fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSEM_SIZE.IxGEN_DESC] = fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSEM_SIZE.IxGEN_DESC];

 	
		}

		private void tbtn_Insert_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{


			fgrid_Main.Add_Row(fgrid_Main.Selection.r1);

			fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSEM_SIZE.lxFACTORY] = cmb_Factory.SelectedValue.ToString();
			fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSEM_SIZE.IxGEN]     = cmb_Gen.SelectedValue.ToString();
			fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSEM_SIZE.IxPST_YN]  = cmb_Pst_yn.SelectedValue.ToString();

			if(fgrid_Main.Rows.Count > _Rowfixed)
				fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSEM_SIZE.IxGEN_DESC] = fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBSEM_SIZE.IxGEN_DESC];

	
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Main.Delete_Row(fgrid_Main.Selection.r1);		
		}


		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
				if(DialogResult.Yes != dr) return;

				//행 수정 상태 해제
				fgrid_Main.Select(fgrid_Main.Selection.r1, 0, fgrid_Main.Selection.r1, fgrid_Main.Cols.Count-1, false);	 
				MyOraDB.Save_FlexGird ("01", "PKG_SEM_SIZE.SAVE_SEM_SIZE", fgrid_Main);			

				Select_Size_List( cmb_Factory.SelectedValue.ToString(), 
								  cmb_Gen.SelectedValue.ToString(), 
								  cmb_Pst_yn.SelectedValue.ToString(), 
								  fgrid_Main );
			}
			catch
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave,this);
			}	
		}




		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			cmb_Gen.SelectedIndex = -1;
			cmb_Pst_yn.SelectedIndex = -1;
					
			fgrid_Main.Rows.Count = _Rowfixed;
		
		}


		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_Main.Update_Row();


			if (fgrid_Main.Col == (int)ClassLib.TBSEM_SIZE.IxCM_SIZE)
			{
				string str = fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
				
				if ( COM.ComFunction.Check_Decimal(str) == false )
				{
					fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] = "";
				}

			}		
		}



		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			string mrd_Filename = "Form_EB_Size.mrd" ;
			string txt_Filename = this.Name + ".txt"; 
			string Para         = " ";

			FileInfo file = new FileInfo(txt_Filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}
			file = null;

			//조회조건들
			int  iCnt  = 3;
			string [] aHead =  new string[iCnt];	
			aHead[0]    = cmb_Factory.SelectedValue.ToString();
			aHead[1]    = cmb_Gen.SelectedValue.ToString();
			aHead[2]    = cmb_Pst_yn.SelectedValue.ToString();


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

		private void Form_EB_Size_Load(object sender, System.EventArgs e)
		{
			Init_Form();		
		}


	}

	
}

