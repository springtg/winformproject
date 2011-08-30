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

	public class Form_EB_Dest : COM.OrderWinForm.Form_Top
	{
		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		public System.Windows.Forms.Panel pnl_Search;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Panel pnl_Search1_Image;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.Label lbl_Destination;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private C1.Win.C1List.C1Combo cmb_Dest;
		private System.Windows.Forms.TextBox txt_Dest;
		private System.ComponentModel.IContainer components = null;

		public Form_EB_Dest()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EB_Dest));
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.cmb_Dest = new C1.Win.C1List.C1Combo();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Destination = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pnl_Search1_Image = new System.Windows.Forms.Panel();
			this.txt_Dest = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			this.pnl_Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Dest)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_Search1_Image.SuspendLayout();
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
			this.pnl_Body.Location = new System.Drawing.Point(0, 155);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 480);
			this.pnl_Body.TabIndex = 43;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.AutoResize = false;
			this.fgrid_Main.BackColor = System.Drawing.Color.White;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.Color.Black;
			this.fgrid_Main.Location = new System.Drawing.Point(10, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(996, 480);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 35;
			this.fgrid_Main.EnterCell += new System.EventHandler(this.fgrid_Main_EnterCell);
			this.fgrid_Main.Click += new System.EventHandler(this.fgrid_Main_EnterCell);
			this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.cmb_Dest);
			this.pnl_Search.Controls.Add(this.cmb_Factory);
			this.pnl_Search.Controls.Add(this.lbl_Destination);
			this.pnl_Search.Controls.Add(this.lbl_Factory);
			this.pnl_Search.Controls.Add(this.pnl_Search1_Image);
			this.pnl_Search.DockPadding.All = 8;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1016, 90);
			this.pnl_Search.TabIndex = 44;
			// 
			// cmb_Dest
			// 
			this.cmb_Dest.AddItemCols = 0;
			this.cmb_Dest.AddItemSeparator = ';';
			this.cmb_Dest.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Dest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Dest.Caption = "";
			this.cmb_Dest.CaptionHeight = 17;
			this.cmb_Dest.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Dest.ColumnCaptionHeight = 18;
			this.cmb_Dest.ColumnFooterHeight = 18;
			this.cmb_Dest.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Dest.ContentHeight = 17;
			this.cmb_Dest.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Dest.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Dest.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Dest.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Dest.EditorHeight = 17;
			this.cmb_Dest.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Dest.GapHeight = 2;
			this.cmb_Dest.ItemHeight = 15;
			this.cmb_Dest.Location = new System.Drawing.Point(261, 58);
			this.cmb_Dest.MatchEntryTimeout = ((long)(2000));
			this.cmb_Dest.MaxDropDownItems = ((short)(5));
			this.cmb_Dest.MaxLength = 32767;
			this.cmb_Dest.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Dest.Name = "cmb_Dest";
			this.cmb_Dest.PartialRightColumn = false;
			this.cmb_Dest.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Dest.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Dest.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Dest.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Dest.Size = new System.Drawing.Size(150, 21);
			this.cmb_Dest.TabIndex = 42;
			this.cmb_Dest.TextChanged += new System.EventHandler(this.cmb_Dest_TextChanged);
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
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(300, 21);
			this.cmb_Factory.TabIndex = 41;
		
			// 
			// lbl_Destination
			// 
			this.lbl_Destination.ImageIndex = 1;
			this.lbl_Destination.ImageList = this.img_Label;
			this.lbl_Destination.Location = new System.Drawing.Point(10, 58);
			this.lbl_Destination.Name = "lbl_Destination";
			this.lbl_Destination.Size = new System.Drawing.Size(100, 21);
			this.lbl_Destination.TabIndex = 40;
			this.lbl_Destination.Text = "Destination";
			this.lbl_Destination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 39;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_Search1_Image
			// 
			this.pnl_Search1_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search1_Image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_Search1_Image.Controls.Add(this.txt_Dest);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox2);
			this.pnl_Search1_Image.Controls.Add(this.lbl_SubTitle1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox5);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox7);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox10);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox11);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox12);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox13);
			this.pnl_Search1_Image.Location = new System.Drawing.Point(8, 8);
			this.pnl_Search1_Image.Name = "pnl_Search1_Image";
			this.pnl_Search1_Image.Size = new System.Drawing.Size(992, 88);
			this.pnl_Search1_Image.TabIndex = 0;
			// 
			// txt_Dest
			// 
			this.txt_Dest.BackColor = System.Drawing.Color.White;
			this.txt_Dest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Dest.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Dest.Location = new System.Drawing.Point(103, 50);
			this.txt_Dest.MaxLength = 100;
			this.txt_Dest.Name = "txt_Dest";
			this.txt_Dest.Size = new System.Drawing.Size(150, 21);
			this.txt_Dest.TabIndex = 183;
			this.txt_Dest.Text = "";
			this.txt_Dest.Leave += new System.EventHandler(this.txt_Dest_Leave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(970, 0);
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
			this.pictureBox2.Size = new System.Drawing.Size(808, 32);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(172, 32);
			this.lbl_SubTitle1.TabIndex = 0;
			this.lbl_SubTitle1.Text = "      Destination Info.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(973, 32);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(19, 42);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox7.BackColor = System.Drawing.Color.Navy;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(32, 24);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(944, 56);
			this.pictureBox7.TabIndex = 4;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox10.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(0, 24);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(32, 53);
			this.pictureBox10.TabIndex = 3;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox11.BackColor = System.Drawing.Color.Blue;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(902, 74);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(90, 14);
			this.pictureBox11.TabIndex = 8;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.Color.Blue;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(72, 74);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(904, 14);
			this.pictureBox12.TabIndex = 9;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.BackColor = System.Drawing.Color.Blue;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(0, 74);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(80, 14);
			this.pictureBox13.TabIndex = 6;
			this.pictureBox13.TabStop = false;
			// 
			// Form_EB_Dest
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Search);
			this.Controls.Add(this.pnl_Body);
			this.Name = "Form_EB_Dest";
			this.Text = "Form_EB_Dest";
			this.Load += new System.EventHandler(this.Form_EB_Dest_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Dest)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_Search1_Image.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의
   
		private int _Rowfixed;    
		
		private ClassLib.OraDB  MyOraDB = new ClassLib.OraDB();

		#endregion 

		#region 멤버 메서드 
		/// <summary>
		/// initiating _Form : Form Load
		/// </summary>
		private void Init_Form()
		{ 
			//Setting  Title
			this.Text = "Dest Information";
			this.lbl_MainTitle.Text = "Dest Information"; 
			ClassLib.ComFunction.SetLangDic(this);

			#region 버튼 권한

			try
			{
//				COM.OraDB btn_control = new COM.OraDB();
//				DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
//				tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
//				btn_control = null;
			}
			catch
			{
			}

			#endregion

			DataTable dt_list;


			//Setting Grid
			fgrid_Main.Set_Grid( "SEM_DEST_CODE", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
			_Rowfixed = fgrid_Main.Rows.Fixed;
			fgrid_Main.Set_Action_Image(img_Action); 
			fgrid_Main.Font  = new Font("Verdana",8);

		
			//Setting Factory Combo
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;


			//Set_Dest_List();

		}


		private void Set_Dest_List()
		{   
			DataTable dt_list;

			if (cmb_Factory.SelectedIndex == -1 ) return;

			cmb_Dest.ClearItems();

			dt_list = Select_Dest_Combo(cmb_Factory.SelectedValue.ToString(),
				                        ClassLib.ComFunction.Empty_TextBox(txt_Dest," "));		
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Dest, 1,2, true);

		}
 

		#endregion 

		#region DB 컨트롤

		private  DataTable Select_Dest_Combo(string arg_factory, string arg_dest_cd)
		{  

			string strRlt; int iCnt;
 
			DataSet ret; DataTable dt_list;
            
			iCnt =  3;
			MyOraDB.ReDim_Parameter(iCnt); 
            
			strRlt  = "PKG_SEM_DEST.SELECT_SEM_DEST_C";
			MyOraDB.Process_Name =strRlt;
	
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[1] = "ARG_DEST_CD"; 
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR"; 
	
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;		
			
	
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_dest_cd;
			MyOraDB.Parameter_Values[2] ="";
			
			MyOraDB.Add_Select_Parameter(true); 
			ret = MyOraDB.Exe_Select_Procedure();
			
			if(ret == null)  return null ;
			
			return dt_list  =  ret.Tables[strRlt];
			
		}


		private void Select_Dest_Grid(string arg_factory, string arg_dest_cd,  C1FlexGrid arg_fgrid)
		{

			string strRlt; int iCnt;
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 

			DataSet ret; DataTable dt_list;
        
			iCnt =  3;
			MyOraDB.ReDim_Parameter(iCnt); 
        
			strRlt  = "PKG_SEM_DEST.SELECT_SEM_DEST";
			MyOraDB.Process_Name =strRlt;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_DEST_CD"; 
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR"; 
			
			MyOraDB.Parameter_Type[0] =  (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] =  (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] =  (int)OracleType.Cursor;						

			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_dest_cd," ");
			MyOraDB.Parameter_Values[2] = "";
			
			MyOraDB.Add_Select_Parameter(true); 
			ret = MyOraDB.Exe_Select_Procedure();

			if(ret == null)  return  ;

			dt_list  =  ret.Tables[strRlt];


			for(int i=0; i < dt_list.Rows.Count; i++)
			{	
				arg_fgrid.AddItem(dt_list.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
				arg_fgrid[i + _Rowfixed, 0] = " "; 

			} 

		}


		#endregion 

		#region 이벤트 처리  

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;	
			cmb_Dest.SelectedIndex = -1;		
					
			fgrid_Main.Rows.Count = _Rowfixed;		
		}
	

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				if (txt_Dest.TextLength == 0) 
				 {ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsWrongInput,this) ; return;}

				Select_Dest_Grid(cmb_Factory.SelectedValue.ToString(), 
					             ClassLib.ComFunction.Empty_TextBox(txt_Dest," "), 
					             fgrid_Main);

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch,this);
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
				DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
				if(DialogResult.Yes != dr) return;

				fgrid_Main.Select(fgrid_Main.Selection.r1, 0, fgrid_Main.Selection.r1, fgrid_Main.Cols.Count-1, false);

//				if (Check_Save != true) 
//				{ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave,this);  return;}

			    MyOraDB.Save_FlexGird ("01", "PKG_SEM_DEST.SAVE_SEM_DEST", fgrid_Main);
				fgrid_Main.Rows.Count = _Rowfixed;		

				tbtn_Search_Click(null, null);		
			}
			catch 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave,this);
			}			
		}


		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{	//Select_Data_List();
			fgrid_Main.Add_Row(fgrid_Main.Rows.Count - 1);
			
			fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSEM_DEST.IxFACTORY] = cmb_Factory.SelectedValue.ToString();
		}


		private void tbtn_Insert_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Main.Add_Row(fgrid_Main.Selection.r1);

			fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSEM_DEST.IxFACTORY] = cmb_Factory.SelectedValue.ToString();
		}


		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Main.Delete_Row(fgrid_Main.Selection.r1);				
		}


		private void fgrid_Main_EnterCell(object sender, System.EventArgs e)
		{	
			if ( (_Rowfixed > 0) && (fgrid_Main.Row > _Rowfixed) )				
				fgrid_Main.Buffer_CellData = fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
		}


		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			string stemp1 = fgrid_Main[fgrid_Main.Selection.r1, fgrid_Main.Selection.c1].ToString();
			
			
			//행선지 코드 추출
			int pos  = 0 ;
			string real_dest = ""; 
			
			if ((fgrid_Main.Col == (int)ClassLib.TBSEM_DEST.IxDEST_CD) &&
                (fgrid_Main[fgrid_Main.Selection.r1,0].ToString() =="U"))
			{
              fgrid_Main[fgrid_Main.Selection.r1,fgrid_Main.Selection.c1] = fgrid_Main.Buffer_CellData;
			}

			if ((fgrid_Main.Selection.c1 == (int)ClassLib.TBSEM_DEST.IxDEST_PRITY) ||
                (fgrid_Main.Selection.c1 == (int)ClassLib.TBSEM_DEST.IxVL_TERM) ||
				(fgrid_Main.Selection.c1 == (int)ClassLib.TBSEM_DEST.IxAF_TERM))
				if (COM.ComFunction.Check_Digit(stemp1) == false)
					fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] = fgrid_Main.Buffer_CellData;
		

			if (fgrid_Main.Col == (int)ClassLib.TBSEM_DEST.IxREGION)
			{
				pos  = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSEM_DEST.IxREGION].ToString().IndexOf("-");
				real_dest  =  fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSEM_DEST.IxREGION].ToString().Substring(0,pos);
				fgrid_Main[fgrid_Main.Selection.r1,fgrid_Main.Selection.c1] = real_dest;
			}

			//숫자형 필드 검증
			if (fgrid_Main.Col == (int)ClassLib.TBSEM_DEST.IxDEST_PRITY)
			{
				string str = fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
				
				if (  COM.ComFunction.Check_Digit(str) == false )
				{
					fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] = fgrid_Main.Buffer_CellData;
				}

			}	
			else if (fgrid_Main.Col == (int)ClassLib.TBSEM_DEST.IxAF_TERM)
			{
				string str = fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
				
				if (  COM.ComFunction.Check_Digit(str) == false )
					
				{
					fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] = fgrid_Main.Buffer_CellData;
				}
			}
			else if (fgrid_Main.Col == (int)ClassLib.TBSEM_DEST.IxVL_TERM)
			{
				string str = fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
				
				if (  COM.ComFunction.Check_Digit(str) == false )
				{
					fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] = fgrid_Main.Buffer_CellData;
				}
			}
			else
			{
			
			}


			//수정 검증
			fgrid_Main.Update_Row(fgrid_Main.Selection.r1);

		}

		private void txt_Dest_Leave(object sender, System.EventArgs e)
		{
			Set_Dest_List();
		}

		
		private void cmb_Dest_TextChanged(object sender, System.EventArgs e)
		{
			txt_Dest.Text  = cmb_Dest.SelectedValue.ToString();
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			string mrd_Filename = "Form_EB_Dest.mrd" ;
			string txt_Filename = this.Name + ".txt"; 
			string Para         = " ";

			FileInfo file = new FileInfo(txt_Filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}
			file = null;

			//조회조건들
			int  iCnt  = 2;
			string [] aHead =  new string[iCnt];	
			aHead[0]    = cmb_Factory.SelectedValue.ToString();
			aHead[1]    = ClassLib.ComFunction.Empty_Combo(cmb_Dest," ");


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

		private void Form_EB_Dest_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}


	}
}

