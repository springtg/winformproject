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
	public class Form_EB_SRCH : COM.OrderWinForm.Form_Top
	{
		#region 컨트롤 정의 및 리소스 정리

		public COM.FSP fsp1;
		public System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		public System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label lbl_Region;
		private System.Windows.Forms.Label lbl_BP_NO;
		private System.Windows.Forms.Label lbl_Del_Month;
		private System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.PictureBox pictureBox19;
		private System.Windows.Forms.PictureBox pictureBox20;
		private System.Windows.Forms.PictureBox pictureBox21;
		private System.Windows.Forms.PictureBox pictureBox22;
		private System.Windows.Forms.PictureBox pictureBox23;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.DateTimePicker dpick_Date;
		private System.Windows.Forms.Label lbl_Factory;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Date;
		private System.Windows.Forms.PictureBox pictureBox25;
		private System.Windows.Forms.PictureBox pictureBox26;
		private System.Windows.Forms.PictureBox pictureBox27;
		private System.Windows.Forms.PictureBox pictureBox28;
		private System.Windows.Forms.PictureBox pictureBox29;
		private System.Windows.Forms.PictureBox pictureBox30;
		private System.Windows.Forms.PictureBox pictureBox31;
		private System.Windows.Forms.PictureBox pictureBox32;
		private System.Windows.Forms.PictureBox pictureBox24;
		private System.Windows.Forms.TextBox txt_Style;
		private System.Windows.Forms.TextBox txt_Region;
		private System.Windows.Forms.DateTimePicker dpick_BP_From;
		private System.Windows.Forms.DateTimePicker dpick_BP_To;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gb_job_div;
		private System.Windows.Forms.RadioButton rad_lasting;
		private System.Windows.Forms.RadioButton rad_obs;
		private System.Windows.Forms.RadioButton rad_del;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1List.C1Combo cmb_Del_From;
		private C1.Win.C1List.C1Combo cmb_Del_To;
		private System.Windows.Forms.Label lbl_BP_Info;
		private System.Windows.Forms.Label lbl_History_info;
		
		private System.ComponentModel.IContainer components = null;

		public Form_EB_SRCH()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EB_SRCH));
			this.fsp1 = new COM.FSP();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.cmb_Del_To = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.dpick_BP_To = new System.Windows.Forms.DateTimePicker();
			this.dpick_BP_From = new System.Windows.Forms.DateTimePicker();
			this.cmb_Del_From = new C1.Win.C1List.C1Combo();
			this.txt_Style = new System.Windows.Forms.TextBox();
			this.txt_Region = new System.Windows.Forms.TextBox();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.lbl_Region = new System.Windows.Forms.Label();
			this.lbl_BP_NO = new System.Windows.Forms.Label();
			this.lbl_Del_Month = new System.Windows.Forms.Label();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.pictureBox18 = new System.Windows.Forms.PictureBox();
			this.lbl_BP_Info = new System.Windows.Forms.Label();
			this.pictureBox19 = new System.Windows.Forms.PictureBox();
			this.pictureBox20 = new System.Windows.Forms.PictureBox();
			this.pictureBox21 = new System.Windows.Forms.PictureBox();
			this.pictureBox22 = new System.Windows.Forms.PictureBox();
			this.pictureBox23 = new System.Windows.Forms.PictureBox();
			this.pictureBox24 = new System.Windows.Forms.PictureBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lbl_History_info = new System.Windows.Forms.Label();
			this.gb_job_div = new System.Windows.Forms.GroupBox();
			this.rad_del = new System.Windows.Forms.RadioButton();
			this.rad_lasting = new System.Windows.Forms.RadioButton();
			this.rad_obs = new System.Windows.Forms.RadioButton();
			this.dpick_Date = new System.Windows.Forms.DateTimePicker();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Date = new System.Windows.Forms.Label();
			this.pictureBox25 = new System.Windows.Forms.PictureBox();
			this.pictureBox26 = new System.Windows.Forms.PictureBox();
			this.pictureBox27 = new System.Windows.Forms.PictureBox();
			this.pictureBox28 = new System.Windows.Forms.PictureBox();
			this.pictureBox29 = new System.Windows.Forms.PictureBox();
			this.pictureBox30 = new System.Windows.Forms.PictureBox();
			this.pictureBox31 = new System.Windows.Forms.PictureBox();
			this.pictureBox32 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fsp1)).BeginInit();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Del_To)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Del_From)).BeginInit();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.gb_job_div.SuspendLayout();
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
			this.c1ToolBar1.Location = new System.Drawing.Point(620, 3);
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
			// stbar
			// 
			this.stbar.Name = "stbar";
			this.stbar.Size = new System.Drawing.Size(1000, 22);
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Location = new System.Drawing.Point(80, 26);
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(425, 23);
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// fsp1
			// 
			this.fsp1.BackColor = System.Drawing.SystemColors.Window;
			this.fsp1.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this.fsp1.Location = new System.Drawing.Point(0, 0);
			this.fsp1.Name = "fsp1";
			this.fsp1.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fsp1.TabIndex = 0;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.DockPadding.Left = 9;
			this.pnl_Body.DockPadding.Right = 9;
			this.pnl_Body.Location = new System.Drawing.Point(0, 216);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1000, 426);
			this.pnl_Body.TabIndex = 46;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.Color.White;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.Color.Black;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(9, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(982, 426);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 35;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.SystemColors.Window;
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.panel6);
			this.panel3.DockPadding.All = 8;
			this.panel3.Location = new System.Drawing.Point(0, 64);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1000, 147);
			this.panel3.TabIndex = 48;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(512, 8);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(480, 131);
			this.panel4.TabIndex = 130;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.RosyBrown;
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.cmb_Del_To);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.dpick_BP_To);
			this.panel5.Controls.Add(this.dpick_BP_From);
			this.panel5.Controls.Add(this.cmb_Del_From);
			this.panel5.Controls.Add(this.txt_Style);
			this.panel5.Controls.Add(this.txt_Region);
			this.panel5.Controls.Add(this.lbl_Style);
			this.panel5.Controls.Add(this.lbl_Region);
			this.panel5.Controls.Add(this.lbl_BP_NO);
			this.panel5.Controls.Add(this.lbl_Del_Month);
			this.panel5.Controls.Add(this.pictureBox17);
			this.panel5.Controls.Add(this.pictureBox18);
			this.panel5.Controls.Add(this.lbl_BP_Info);
			this.panel5.Controls.Add(this.pictureBox19);
			this.panel5.Controls.Add(this.pictureBox20);
			this.panel5.Controls.Add(this.pictureBox21);
			this.panel5.Controls.Add(this.pictureBox22);
			this.panel5.Controls.Add(this.pictureBox23);
			this.panel5.Controls.Add(this.pictureBox24);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(480, 131);
			this.panel5.TabIndex = 128;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(228, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 16);
			this.label2.TabIndex = 194;
			this.label2.Text = "~";
			// 
			// cmb_Del_To
			// 
			this.cmb_Del_To.AddItemCols = 0;
			this.cmb_Del_To.AddItemSeparator = ';';
			this.cmb_Del_To.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Del_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Del_To.Caption = "";
			this.cmb_Del_To.CaptionHeight = 17;
			this.cmb_Del_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Del_To.ColumnCaptionHeight = 18;
			this.cmb_Del_To.ColumnFooterHeight = 18;
			this.cmb_Del_To.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Del_To.ContentHeight = 15;
			this.cmb_Del_To.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Del_To.EditorBackColor = System.Drawing.Color.White;
			this.cmb_Del_To.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Del_To.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Del_To.EditorHeight = 15;
			this.cmb_Del_To.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Del_To.GapHeight = 2;
			this.cmb_Del_To.ItemHeight = 15;
			this.cmb_Del_To.Location = new System.Drawing.Point(246, 58);
			this.cmb_Del_To.MatchEntryTimeout = ((long)(2000));
			this.cmb_Del_To.MaxDropDownItems = ((short)(5));
			this.cmb_Del_To.MaxLength = 32767;
			this.cmb_Del_To.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Del_To.Name = "cmb_Del_To";
			this.cmb_Del_To.PartialRightColumn = false;
			this.cmb_Del_To.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Del_To.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Del_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Del_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Del_To.Size = new System.Drawing.Size(110, 19);
			this.cmb_Del_To.TabIndex = 193;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(227, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 16);
			this.label1.TabIndex = 192;
			this.label1.Text = "~";
			// 
			// dpick_BP_To
			// 
			this.dpick_BP_To.CustomFormat = "yyyyMMdd";
			this.dpick_BP_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dpick_BP_To.Location = new System.Drawing.Point(247, 35);
			this.dpick_BP_To.Name = "dpick_BP_To";
			this.dpick_BP_To.Size = new System.Drawing.Size(110, 20);
			this.dpick_BP_To.TabIndex = 191;
			this.dpick_BP_To.ValueChanged += new System.EventHandler(this.dpick_BP_To_ValueChanged);
			// 
			// dpick_BP_From
			// 
			this.dpick_BP_From.CustomFormat = "yyyyMMdd";
			this.dpick_BP_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dpick_BP_From.Location = new System.Drawing.Point(111, 35);
			this.dpick_BP_From.Name = "dpick_BP_From";
			this.dpick_BP_From.Size = new System.Drawing.Size(110, 20);
			this.dpick_BP_From.TabIndex = 185;
			this.dpick_BP_From.ValueChanged += new System.EventHandler(this.dpick_BP_From_ValueChanged);
			// 
			// cmb_Del_From
			// 
			this.cmb_Del_From.AddItemCols = 0;
			this.cmb_Del_From.AddItemSeparator = ';';
			this.cmb_Del_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Del_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Del_From.Caption = "";
			this.cmb_Del_From.CaptionHeight = 17;
			this.cmb_Del_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Del_From.ColumnCaptionHeight = 18;
			this.cmb_Del_From.ColumnFooterHeight = 18;
			this.cmb_Del_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Del_From.ContentHeight = 15;
			this.cmb_Del_From.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Del_From.EditorBackColor = System.Drawing.Color.White;
			this.cmb_Del_From.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Del_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Del_From.EditorHeight = 15;
			this.cmb_Del_From.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Del_From.GapHeight = 2;
			this.cmb_Del_From.ItemHeight = 15;
			this.cmb_Del_From.Location = new System.Drawing.Point(111, 58);
			this.cmb_Del_From.MatchEntryTimeout = ((long)(2000));
			this.cmb_Del_From.MaxDropDownItems = ((short)(5));
			this.cmb_Del_From.MaxLength = 32767;
			this.cmb_Del_From.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Del_From.Name = "cmb_Del_From";
			this.cmb_Del_From.PartialRightColumn = false;
			this.cmb_Del_From.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Del_From.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Del_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Del_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Del_From.Size = new System.Drawing.Size(110, 19);
			this.cmb_Del_From.TabIndex = 189;
			// 
			// txt_Style
			// 
			this.txt_Style.BackColor = System.Drawing.Color.White;
			this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Style.Location = new System.Drawing.Point(111, 102);
			this.txt_Style.MaxLength = 100;
			this.txt_Style.Name = "txt_Style";
			this.txt_Style.Size = new System.Drawing.Size(245, 20);
			this.txt_Style.TabIndex = 188;
			this.txt_Style.Text = "";
			// 
			// txt_Region
			// 
			this.txt_Region.BackColor = System.Drawing.Color.White;
			this.txt_Region.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Region.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Region.Location = new System.Drawing.Point(111, 80);
			this.txt_Region.MaxLength = 100;
			this.txt_Region.Name = "txt_Region";
			this.txt_Region.Size = new System.Drawing.Size(245, 20);
			this.txt_Region.TabIndex = 187;
			this.txt_Region.Text = "";
			// 
			// lbl_Style
			// 
			this.lbl_Style.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Style.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(10, 102);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 118;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Region
			// 
			this.lbl_Region.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Region.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Region.ImageIndex = 0;
			this.lbl_Region.ImageList = this.img_Label;
			this.lbl_Region.Location = new System.Drawing.Point(10, 80);
			this.lbl_Region.Name = "lbl_Region";
			this.lbl_Region.Size = new System.Drawing.Size(100, 21);
			this.lbl_Region.TabIndex = 117;
			this.lbl_Region.Text = "Region";
			this.lbl_Region.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_BP_NO
			// 
			this.lbl_BP_NO.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_BP_NO.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_BP_NO.ImageIndex = 0;
			this.lbl_BP_NO.ImageList = this.img_Label;
			this.lbl_BP_NO.Location = new System.Drawing.Point(10, 36);
			this.lbl_BP_NO.Name = "lbl_BP_NO";
			this.lbl_BP_NO.Size = new System.Drawing.Size(100, 21);
			this.lbl_BP_NO.TabIndex = 116;
			this.lbl_BP_NO.Text = "Lasting Week";
			this.lbl_BP_NO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Del_Month
			// 
			this.lbl_Del_Month.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Del_Month.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Del_Month.ImageIndex = 0;
			this.lbl_Del_Month.ImageList = this.img_Label;
			this.lbl_Del_Month.Location = new System.Drawing.Point(10, 58);
			this.lbl_Del_Month.Name = "lbl_Del_Month";
			this.lbl_Del_Month.Size = new System.Drawing.Size(100, 21);
			this.lbl_Del_Month.TabIndex = 115;
			this.lbl_Del_Month.Text = "Delivery Month";
			this.lbl_Del_Month.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox17
			// 
			this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox17.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
			this.pictureBox17.Location = new System.Drawing.Point(165, 0);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(304, 30);
			this.pictureBox17.TabIndex = 2;
			this.pictureBox17.TabStop = false;
			// 
			// pictureBox18
			// 
			this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox18.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox18.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
			this.pictureBox18.Location = new System.Drawing.Point(467, 0);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(13, 30);
			this.pictureBox18.TabIndex = 1;
			this.pictureBox18.TabStop = false;
			// 
			// lbl_BP_Info
			// 
			this.lbl_BP_Info.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_BP_Info.Image = ((System.Drawing.Image)(resources.GetObject("lbl_BP_Info.Image")));
			this.lbl_BP_Info.Location = new System.Drawing.Point(0, 0);
			this.lbl_BP_Info.Name = "lbl_BP_Info";
			this.lbl_BP_Info.Size = new System.Drawing.Size(165, 30);
			this.lbl_BP_Info.TabIndex = 0;
			this.lbl_BP_Info.Text = "      BP Info.";
			this.lbl_BP_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox19
			// 
			this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox19.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
			this.pictureBox19.Location = new System.Drawing.Point(449, 30);
			this.pictureBox19.Name = "pictureBox19";
			this.pictureBox19.Size = new System.Drawing.Size(31, 85);
			this.pictureBox19.TabIndex = 5;
			this.pictureBox19.TabStop = false;
			// 
			// pictureBox20
			// 
			this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox20.BackColor = System.Drawing.Color.Blue;
			this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
			this.pictureBox20.Location = new System.Drawing.Point(455, 101);
			this.pictureBox20.Name = "pictureBox20";
			this.pictureBox20.Size = new System.Drawing.Size(25, 30);
			this.pictureBox20.TabIndex = 8;
			this.pictureBox20.TabStop = false;
			// 
			// pictureBox21
			// 
			this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox21.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
			this.pictureBox21.Location = new System.Drawing.Point(0, 24);
			this.pictureBox21.Name = "pictureBox21";
			this.pictureBox21.Size = new System.Drawing.Size(32, 96);
			this.pictureBox21.TabIndex = 3;
			this.pictureBox21.TabStop = false;
			// 
			// pictureBox22
			// 
			this.pictureBox22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox22.BackColor = System.Drawing.Color.Blue;
			this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
			this.pictureBox22.Location = new System.Drawing.Point(0, 101);
			this.pictureBox22.Name = "pictureBox22";
			this.pictureBox22.Size = new System.Drawing.Size(72, 40);
			this.pictureBox22.TabIndex = 6;
			this.pictureBox22.TabStop = false;
			// 
			// pictureBox23
			// 
			this.pictureBox23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox23.BackColor = System.Drawing.Color.Blue;
			this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
			this.pictureBox23.Location = new System.Drawing.Point(72, 101);
			this.pictureBox23.Name = "pictureBox23";
			this.pictureBox23.Size = new System.Drawing.Size(392, 30);
			this.pictureBox23.TabIndex = 9;
			this.pictureBox23.TabStop = false;
			// 
			// pictureBox24
			// 
			this.pictureBox24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox24.BackColor = System.Drawing.Color.Navy;
			this.pictureBox24.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
			this.pictureBox24.Location = new System.Drawing.Point(32, 24);
			this.pictureBox24.Name = "pictureBox24";
			this.pictureBox24.Size = new System.Drawing.Size(432, 99);
			this.pictureBox24.TabIndex = 4;
			this.pictureBox24.TabStop = false;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel6.DockPadding.Right = 4;
			this.panel6.Location = new System.Drawing.Point(8, 8);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(504, 131);
			this.panel6.TabIndex = 128;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.RosyBrown;
			this.panel7.Controls.Add(this.lbl_History_info);
			this.panel7.Controls.Add(this.gb_job_div);
			this.panel7.Controls.Add(this.dpick_Date);
			this.panel7.Controls.Add(this.lbl_Factory);
			this.panel7.Controls.Add(this.cmb_Factory);
			this.panel7.Controls.Add(this.lbl_Date);
			this.panel7.Controls.Add(this.pictureBox25);
			this.panel7.Controls.Add(this.pictureBox26);
			this.panel7.Controls.Add(this.pictureBox27);
			this.panel7.Controls.Add(this.pictureBox28);
			this.panel7.Controls.Add(this.pictureBox29);
			this.panel7.Controls.Add(this.pictureBox30);
			this.panel7.Controls.Add(this.pictureBox31);
			this.panel7.Controls.Add(this.pictureBox32);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(500, 131);
			this.panel7.TabIndex = 1;
			// 
			// lbl_History_info
			// 
			this.lbl_History_info.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_History_info.Image = ((System.Drawing.Image)(resources.GetObject("lbl_History_info.Image")));
			this.lbl_History_info.Location = new System.Drawing.Point(1, 0);
			this.lbl_History_info.Name = "lbl_History_info";
			this.lbl_History_info.Size = new System.Drawing.Size(165, 30);
			this.lbl_History_info.TabIndex = 169;
			this.lbl_History_info.Text = "      BP Info.";
			this.lbl_History_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gb_job_div
			// 
			this.gb_job_div.BackColor = System.Drawing.Color.White;
			this.gb_job_div.Controls.Add(this.rad_del);
			this.gb_job_div.Controls.Add(this.rad_lasting);
			this.gb_job_div.Controls.Add(this.rad_obs);
			this.gb_job_div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gb_job_div.Location = new System.Drawing.Point(11, 81);
			this.gb_job_div.Name = "gb_job_div";
			this.gb_job_div.Size = new System.Drawing.Size(310, 40);
			this.gb_job_div.TabIndex = 168;
			this.gb_job_div.TabStop = false;
			this.gb_job_div.Text = "Job Division";
			// 
			// rad_del
			// 
			this.rad_del.Location = new System.Drawing.Point(123, 17);
			this.rad_del.Name = "rad_del";
			this.rad_del.Size = new System.Drawing.Size(77, 14);
			this.rad_del.TabIndex = 2;
			this.rad_del.Text = "Delivery";
			this.rad_del.CheckedChanged += new System.EventHandler(this.rad_del_CheckedChanged);
			// 
			// rad_lasting
			// 
			this.rad_lasting.Location = new System.Drawing.Point(24, 17);
			this.rad_lasting.Name = "rad_lasting";
			this.rad_lasting.Size = new System.Drawing.Size(80, 14);
			this.rad_lasting.TabIndex = 1;
			this.rad_lasting.Text = "Lasting";
			this.rad_lasting.CheckedChanged += new System.EventHandler(this.rad_lasting_CheckedChanged);
			// 
			// rad_obs
			// 
			this.rad_obs.Location = new System.Drawing.Point(208, 17);
			this.rad_obs.Name = "rad_obs";
			this.rad_obs.Size = new System.Drawing.Size(84, 14);
			this.rad_obs.TabIndex = 0;
			this.rad_obs.Text = "OBS";
			this.rad_obs.CheckedChanged += new System.EventHandler(this.rad_obs_CheckedChanged);
			// 
			// dpick_Date
			// 
			this.dpick_Date.CustomFormat = "yyyyMMdd";
			this.dpick_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dpick_Date.Location = new System.Drawing.Point(111, 57);
			this.dpick_Date.Name = "dpick_Date";
			this.dpick_Date.Size = new System.Drawing.Size(212, 20);
			this.dpick_Date.TabIndex = 163;
			this.dpick_Date.ValueChanged += new System.EventHandler(this.dpick_Date_ValueChanged);
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
			this.lbl_Factory.TabIndex = 115;
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
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory.TabIndex = 118;
			// 
			// lbl_Date
			// 
			this.lbl_Date.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Date.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Date.ImageIndex = 1;
			this.lbl_Date.ImageList = this.img_Label;
			this.lbl_Date.Location = new System.Drawing.Point(10, 58);
			this.lbl_Date.Name = "lbl_Date";
			this.lbl_Date.Size = new System.Drawing.Size(100, 21);
			this.lbl_Date.TabIndex = 116;
			this.lbl_Date.Text = "Date";
			this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox25
			// 
			this.pictureBox25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox25.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox25.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
			this.pictureBox25.Location = new System.Drawing.Point(162, -1);
			this.pictureBox25.Name = "pictureBox25";
			this.pictureBox25.Size = new System.Drawing.Size(316, 32);
			this.pictureBox25.TabIndex = 2;
			this.pictureBox25.TabStop = false;
			// 
			// pictureBox26
			// 
			this.pictureBox26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox26.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
			this.pictureBox26.Location = new System.Drawing.Point(478, 0);
			this.pictureBox26.Name = "pictureBox26";
			this.pictureBox26.Size = new System.Drawing.Size(22, 32);
			this.pictureBox26.TabIndex = 1;
			this.pictureBox26.TabStop = false;
			// 
			// pictureBox27
			// 
			this.pictureBox27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox27.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
			this.pictureBox27.Location = new System.Drawing.Point(481, 32);
			this.pictureBox27.Name = "pictureBox27";
			this.pictureBox27.Size = new System.Drawing.Size(19, 85);
			this.pictureBox27.TabIndex = 5;
			this.pictureBox27.TabStop = false;
			// 
			// pictureBox28
			// 
			this.pictureBox28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox28.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
			this.pictureBox28.Location = new System.Drawing.Point(0, 24);
			this.pictureBox28.Name = "pictureBox28";
			this.pictureBox28.Size = new System.Drawing.Size(32, 96);
			this.pictureBox28.TabIndex = 3;
			this.pictureBox28.TabStop = false;
			// 
			// pictureBox29
			// 
			this.pictureBox29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox29.BackColor = System.Drawing.Color.Blue;
			this.pictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox29.Image")));
			this.pictureBox29.Location = new System.Drawing.Point(410, 117);
			this.pictureBox29.Name = "pictureBox29";
			this.pictureBox29.Size = new System.Drawing.Size(90, 14);
			this.pictureBox29.TabIndex = 8;
			this.pictureBox29.TabStop = false;
			// 
			// pictureBox30
			// 
			this.pictureBox30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox30.BackColor = System.Drawing.Color.Blue;
			this.pictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox30.Image")));
			this.pictureBox30.Location = new System.Drawing.Point(72, 117);
			this.pictureBox30.Name = "pictureBox30";
			this.pictureBox30.Size = new System.Drawing.Size(412, 14);
			this.pictureBox30.TabIndex = 9;
			this.pictureBox30.TabStop = false;
			// 
			// pictureBox31
			// 
			this.pictureBox31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox31.BackColor = System.Drawing.Color.Blue;
			this.pictureBox31.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox31.Image")));
			this.pictureBox31.Location = new System.Drawing.Point(0, 117);
			this.pictureBox31.Name = "pictureBox31";
			this.pictureBox31.Size = new System.Drawing.Size(80, 14);
			this.pictureBox31.TabIndex = 6;
			this.pictureBox31.TabStop = false;
			// 
			// pictureBox32
			// 
			this.pictureBox32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox32.BackColor = System.Drawing.Color.Navy;
			this.pictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox32.Image")));
			this.pictureBox32.Location = new System.Drawing.Point(32, 24);
			this.pictureBox32.Name = "pictureBox32";
			this.pictureBox32.Size = new System.Drawing.Size(452, 99);
			this.pictureBox32.TabIndex = 4;
			this.pictureBox32.TabStop = false;
			// 
			// Form_EB_SRCH
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.ClientSize = new System.Drawing.Size(1000, 666);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.pnl_Body);
			this.Font = new System.Drawing.Font("Verdana", 8F);
			this.Name = "Form_EB_SRCH";
			this.Text = "Search Build Plan";
			this.Load += new System.EventHandler(this.Form_EB_Search_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.Controls.SetChildIndex(this.panel3, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fsp1)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Del_To)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Del_From)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.gb_job_div.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의
   
		private int _Rowfixed;   
		COM.OraDB MyOraDB = new COM.OraDB();      

		#endregion 	

		#region 멤버 메서드 

		private void Init_Form()
		{ 
			
			//Title
			this.Text = "Search Build Plan";
			this.lbl_MainTitle.Text = "Search BP"; 
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
//				tbtn_Delete.Enabled = false;
//			}
//			catch
//			{
//			}

			#endregion

			DataTable dt_list; 
						
			// 그리드 설정(TBSEM_BP_SEARCH)
			fgrid_Main.Set_Grid( "SEM_BP", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
			_Rowfixed = fgrid_Main.Rows.Fixed;	
			fgrid_Main.Font  = new Font("Verdana",8);
	
			// 콤보박스 설정
			///Factory
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0);; 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
			 
			// 버튼 
			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Save.Enabled   = false;

			rad_lasting.Enabled= false;
			dpick_BP_From.Enabled =false;
			dpick_BP_To.Enabled =false;

			//ClassLib.ComFunction.Get_Values(this, dpick_Date.Name,  dpick_BP_From.Name, dpick_BP_To.Name);

		}


		private void SB_Set_Flag()
		{
			int i;

			DateTime CurDate = DateTime.Now;

			fgrid_Main.Rows.Count = _Rowfixed; 
			dpick_BP_From.Enabled = false  ;   dpick_BP_To.Enabled  = false;
			cmb_Del_From.Enabled  = false  ;   cmb_Del_To.Enabled = false;

			if (rad_lasting.Checked) 
			{
				dpick_BP_From.Enabled = true; dpick_BP_To.Enabled= true;
			}

			if (rad_del.Checked) 
			{
				lbl_Del_Month.Text = "Delievery";
				cmb_Del_From.Enabled  = true; cmb_Del_To.Enabled  = true;

				cmb_Del_From.ClearItems();
				cmb_Del_To.ClearItems();

				///del_month_From
				cmb_Del_From.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
				cmb_Del_From.ClearItems();
				cmb_Del_From.ExtendRightColumn = true;
				cmb_Del_From.ColumnHeaders = false;
				cmb_Del_From.AddItem(" ");
				for(i = -5; i <= 5; i++)
					cmb_Del_From.AddItem( CurDate.AddMonths(i).ToString("yyyyMM") + "01" );
				cmb_Del_From.MaxDropDownItems = Convert.ToInt16(cmb_Del_From.ListCount);


				///del_month_To
				cmb_Del_To.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
				cmb_Del_To.ClearItems();
				cmb_Del_To.ExtendRightColumn = true;
				cmb_Del_To.ColumnHeaders = false;
				cmb_Del_To.AddItem(" ");
				for(i = -5; i <= 5; i++)
					cmb_Del_To.AddItem( CurDate.AddMonths(i).ToString("yyyyMM") + "01" );
				cmb_Del_To.MaxDropDownItems = Convert.ToInt16(cmb_Del_To.ListCount);

			}

			if (rad_obs.Checked) 
			{
				lbl_Del_Month.Text = "OBS ID";
				cmb_Del_From.Enabled  = true; cmb_Del_To.Enabled  = true;

				cmb_Del_From.ClearItems();
				cmb_Del_To.ClearItems();

				ClassLib.ComFunction.Set_OBSID_CmbList(ClassLib.ComVar.CxOBS_Type , cmb_Del_From);  
				ClassLib.ComFunction.Set_OBSID_CmbList(ClassLib.ComVar.CxOBS_Type, cmb_Del_To);  				
			}
				
		}




		/// <summary>
		/// Display_fgrid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_bpno">데이터 테이블</param>
		/// <param name="arg_bp">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_fgrid(DataTable arg_bpno, DataTable arg_bp, C1FlexGrid arg_fgrid)
		{
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 
			arg_fgrid.Cols.Count = (int)ClassLib.TBSEM_BP_SEARCH.lxTOT_QTY+1;

			// Set BPNO List
			for(int i = 0; i < arg_bpno.Rows.Count; i++)
			{
				arg_fgrid.Cols.Count = arg_fgrid.Cols.Count+1;
				arg_fgrid[1,arg_fgrid.Cols.Count-1] = arg_bpno.Rows[i].ItemArray[0].ToString();
			} 

			// Set BP List
			string sSTYLE =" ";
			int iSTYLE     = (int)ClassLib.TBSEM_BP_SEARCH.lxSTYLE_CD;
			int iTOT_QTY   = (int)ClassLib.TBSEM_BP_SEARCH.lxTOT_QTY;
			int iBP_NO     = (int)ClassLib.TBSEM_BP_SEARCH.lxBP_NO;
			int iPRD_QTY   = (int)ClassLib.TBSEM_BP_SEARCH.lxPRD_QTY;
			int iSum  = 0;

			for(int i = 0; i < arg_bp.Rows.Count; i++)
			{    
				
				if (sSTYLE != arg_bp.Rows[i].ItemArray[iSTYLE-1].ToString())  
				{   
					fgrid_Main.AddItem(arg_bp.Rows[i].ItemArray, fgrid_Main.Rows.Count, 1);
					fgrid_Main[fgrid_Main.Rows.Count-1, iTOT_QTY+1] = null;   //bp no
					fgrid_Main[fgrid_Main.Rows.Count-1, iTOT_QTY+2] = null;   //prod qty
					iSum  = 0;
				}

				for(int j=iBP_NO;j<arg_fgrid.Cols.Count;j++)
				{
					if(arg_fgrid[1,j].ToString() == arg_bp.Rows[i].ItemArray[iBP_NO-1].ToString())
					{
						arg_fgrid[arg_fgrid.Rows.Count  -1 ,j] = arg_bp.Rows[i].ItemArray[iPRD_QTY-1].ToString();
						iSum = iSum+ Convert.ToInt32(arg_bp.Rows[i].ItemArray[iPRD_QTY-1].ToString());
					}
				}

				arg_fgrid[arg_fgrid.Rows.Count -1,iTOT_QTY] = iSum;
				sSTYLE = arg_fgrid[arg_fgrid.Rows.Count -1,iSTYLE].ToString();

			} 

			//arg_fgrid.AutoSizeCols();

		}


		/// <summary>
		/// Set_SubTotal : 부분합 구하기
		/// </summary>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Set_SubTotal( C1FlexGrid arg_fgrid)
		{
			//Sub Total 구하기
			arg_fgrid.SubtotalPosition = SubtotalPositionEnum.AboveData;
			arg_fgrid.Tree.Column = 1;

			for (int c = (int)ClassLib.TBSEM_BP_SEARCH.lxBP_NO ; c < arg_fgrid.Cols.Count; c++)
			{
				arg_fgrid.Subtotal(AggregateEnum.Sum, 1, 1, (int)ClassLib.TBSEM_BP_SEARCH.lxTOT_QTY, "Dev Total {0}");
				arg_fgrid.Subtotal(AggregateEnum.Sum, 1, 1, c, "Dev Total {0}");
				arg_fgrid.Styles[CellStyleEnum.Subtotal1].BackColor  = ClassLib.ComVar.ClrTotFirst;
				arg_fgrid.Styles[CellStyleEnum.Subtotal1].ForeColor  = Color.Black;

				arg_fgrid.Subtotal(AggregateEnum.Sum, 0, 0, (int)ClassLib.TBSEM_BP_SEARCH.lxTOT_QTY, "Grand Total {0}");
				arg_fgrid.Subtotal(AggregateEnum.Sum, 0, 0, c, "Grand Total {0}");		
				arg_fgrid.Styles[CellStyleEnum.Subtotal0].BackColor  = ClassLib.ComVar.ClrTotSecond;
				arg_fgrid.Styles[CellStyleEnum.Subtotal0].ForeColor  = Color.Black;
			}

		}



		#endregion 	

	    #region DB 컨트롤

		/// <summary>
		/// Select_BP_List : Build Plan 리스트 찾기 
		/// </summary>
		private DataTable Select_NO_List()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_BP.SELECT_SEM_BPNO";
            
			int iCnt  = 5;
			MyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FLAG";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_TO";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE
			for (int i =0 ; i <  iCnt-1 ;i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

			MyOraDB.Parameter_Type[iCnt-1] = (int)OracleType.Cursor;


			//04.DATA 정의  
			
			if (rad_lasting.Checked) 
			{   
				MyOraDB.Parameter_Values[0] = "L";
				MyOraDB.Parameter_Values[1] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[2] = Convert.ToDateTime(dpick_BP_From.Text).ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[3] = Convert.ToDateTime(dpick_BP_To.Text).ToString("yyyyMMdd");
			}
			else if(rad_del.Checked)
			{
				MyOraDB.Parameter_Values[0] = "D";
				MyOraDB.Parameter_Values[1] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[2] = cmb_Del_From.Text;
				MyOraDB.Parameter_Values[3] = cmb_Del_To.Text;
			}
			else
			{
				MyOraDB.Parameter_Values[0] = "O";
				MyOraDB.Parameter_Values[1] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[2] = cmb_Del_From.Text;
				MyOraDB.Parameter_Values[3] = cmb_Del_To.Text;
			}

			MyOraDB.Parameter_Values[4] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
		}



		/// <summary>
		/// Select_BP_List : Build Plan 리스트 찾기 
		/// </summary>
		private DataTable Select_Data_List()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_BP.SELECT_SEM_BP";
            
			int iCnt  = 8;
			MyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FLAG";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_DATE";
			MyOraDB.Parameter_Name[3] = "ARG_FROM";
			MyOraDB.Parameter_Name[4] = "ARG_TO";
			MyOraDB.Parameter_Name[5] = "ARG_REGION";
			MyOraDB.Parameter_Name[6] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[7] = "OUT_CURSOR";

			//03.DATA TYPE
			for (int i =0 ; i <  iCnt-1 ;i++)
			MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

			MyOraDB.Parameter_Type[iCnt-1] = (int)OracleType.Cursor;


			//04.DATA 정의  
			if (rad_lasting.Checked) MyOraDB.Parameter_Values[0]  = "L";
			else if (rad_del.Checked)  MyOraDB.Parameter_Values[0]  = "D";
			else MyOraDB.Parameter_Values[0]  = "O";

			MyOraDB.Parameter_Values[1] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = Convert.ToDateTime(dpick_Date.Text).ToString("yyyyMMdd");

			if (rad_lasting.Checked) 
			{
				MyOraDB.Parameter_Values[3]  = Convert.ToDateTime(dpick_BP_From.Text).ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[4]  = Convert.ToDateTime(dpick_BP_To.Text).ToString("yyyyMMdd");
			}
			else if (rad_del.Checked)
			{
				MyOraDB.Parameter_Values[3]  = cmb_Del_From.Text;
				MyOraDB.Parameter_Values[4]  = cmb_Del_To.Text;
			}
			else 
			{
				MyOraDB.Parameter_Values[3]  = cmb_Del_From.Text;
				MyOraDB.Parameter_Values[4]  = cmb_Del_To.Text;
			}

			MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_TextBox(txt_Region, " ");
			MyOraDB.Parameter_Values[6] = ClassLib.ComFunction.Empty_TextBox(txt_Style,  " ");
			MyOraDB.Parameter_Values[7] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
		}
		#endregion

		#region 이벤트 처리  

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;	
			cmb_Del_From.SelectedIndex = 0;
			cmb_Del_To.SelectedIndex = 0;
			txt_Region.Clear();
			txt_Style.Clear();				
			dpick_Date.Text = DateTime.Now.ToString();
			dpick_BP_From.Text = DateTime.Now.ToString();
			dpick_BP_To.Text = DateTime.Now.ToString();
			fgrid_Main.Rows.Count = _Rowfixed;								
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				DataTable dt_bpno , dt_bp;

				//SEM_BP NO 정보
				dt_bpno = Select_NO_List();

				//SEM_BP 상세 정보
				dt_bp = Select_Data_List();
				Display_fgrid(dt_bpno, dt_bp, fgrid_Main);

				//SubTatal
				Set_SubTotal(fgrid_Main);

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch, this); 


			}
			catch
			{
				ClassLib.ComFunction.User_Message("Exception caught :Error");
			}									
		}


		private void rad_lasting_CheckedChanged(object sender, System.EventArgs e)
		{
			SB_Set_Flag();
		}

		private void rad_del_CheckedChanged(object sender, System.EventArgs e)
		{
			SB_Set_Flag();
		}

		private void rad_obs_CheckedChanged(object sender, System.EventArgs e)
		{
			SB_Set_Flag();
		}


		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			string mrd_Filename = "Form_EB_SRCH.mrd" ;
			string txt_Filename = this.Name + ".txt"; 
			string Para         = " ";


			//조회조건들
			int  iCnt  = 6;
			string [] aHead =  new string[iCnt];	
			aHead[0]    = cmb_Factory.SelectedValue.ToString();
			aHead[1]    = dpick_Date.Text;

			if (rad_lasting.Checked) 
			{aHead[2]    = dpick_BP_From.Text; aHead[3]    = dpick_BP_To.Text;}
			else if(rad_del.Checked) 
			{aHead[2]    = cmb_Del_From.Text; aHead[3]    = cmb_Del_To.Text;}
            else
			{aHead[2]    = dpick_BP_From.Text; aHead[3]    = dpick_BP_To.Text;}
			aHead[4]    = txt_Region.Text;
			aHead[5]    = txt_Style.Text;

			//Parameter만들기
			Para  = "/rfn [" + Application.StartupPath + @"\"+ txt_Filename+ "]  /rv "; 			
			for (int i  = 1 ; i<= iCnt ; i++)
			{
				Para = Para +  "V_" + i.ToString().PadLeft (2,'0').ToString() + "[" + aHead[i-1] + "] ";
			}
			Para = Para + "V_USER[" + ClassLib.ComVar.This_User + "]";
			

            //File 내용 추출 
			iCnt = 0;   //배열 로우 갯수 구하기...
			for (int i = _Rowfixed ; i <fgrid_Main.Rows.Count ; i++)
			{
				for (int j = (int)ClassLib.TBSEM_BP_SEARCH.lxBP_NO ; j< fgrid_Main.Cols.Count ; j++)
				{
					if ((fgrid_Main[i,(int)ClassLib.TBSEM_BP_SEARCH.lxSTYLE_CD] == null) || 
						(fgrid_Main[i,(int)ClassLib.TBSEM_BP_SEARCH.lxSTYLE_CD].ToString().Length < 6)) break;

						iCnt  = iCnt+1;						
				}
			}
          

            string [] aData =  new string[iCnt];
			iCnt = 0;
			for (int i =  _Rowfixed ; i <fgrid_Main.Rows.Count ; i++)
			{
				for (int j = (int)ClassLib.TBSEM_BP_SEARCH.lxBP_NO ; j< fgrid_Main.Cols.Count ; j++)
				{   
					aData[iCnt] = " ";

					if ((fgrid_Main[i,(int)ClassLib.TBSEM_BP_SEARCH.lxSTYLE_CD] == null) || 
						(fgrid_Main[i,(int)ClassLib.TBSEM_BP_SEARCH.lxSTYLE_CD].ToString().Length < 6)) break;

					//스타일정보 채우기
					for (int k = 0 ; k < (int)ClassLib.TBSEM_BP_SEARCH.lxTOT_QTY ; k++)
					{   
						if (fgrid_Main[i,k] == null )  	aData[iCnt] = aData[iCnt] + " "+ "@";
						else  aData[iCnt] = aData[iCnt] + fgrid_Main[i,k].ToString() + "@";
					}
					//BPNO + Quantity
					if (fgrid_Main[i,j]== null)  fgrid_Main[i,j]= 0;
					aData[iCnt] = aData[iCnt]+ fgrid_Main[1,j].ToString()+"@" + fgrid_Main[i,j].ToString()+"@";
					iCnt  = iCnt+1;			
				}

			}

			//File만들기..
			ClassLib.ComFunction.PrintFile(txt_Filename,aData);


			//Report Base Form호출..
			FlexOrder.Report.Form_RD_Base report 
				            = new FlexOrder.Report.Form_RD_Base(txt_Filename,  mrd_Filename, Para);
			report.Show();

		}


		private void dpick_Date_ValueChanged(object sender, System.EventArgs e)
		{
			//ClassLib.ComFunction.Set_Values(this, dpick_Date.Name, dpick_BP_From.Name, dpick_BP_To.Name);
		}

		private void dpick_BP_From_ValueChanged(object sender, System.EventArgs e)
		{
			//ClassLib.ComFunction.Set_Values(this, dpick_Date.Name, dpick_BP_From.Name, dpick_BP_To.Name);
		}

		private void dpick_BP_To_ValueChanged(object sender, System.EventArgs e)
		{
			//ClassLib.ComFunction.Set_Values(this, dpick_Date.Name, dpick_BP_From.Name, dpick_BP_To.Name);
		}

		#endregion 	

		private void Form_EB_Search_Load(object sender, System.EventArgs e)
		{
			Init_Form(); 						
		}



	}
}

