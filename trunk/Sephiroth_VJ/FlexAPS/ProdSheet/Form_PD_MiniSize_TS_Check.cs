using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;

namespace FlexAPS.ProdSheet
{
	public class Form_PD_MiniSize_TS_Check : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리


		private System.ComponentModel.IContainer components = null;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_Head;
		public System.Windows.Forms.Panel pnl_HeadSearch;
		public System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_PlanYMD;
		private C1.Win.C1List.C1Combo cmb_LineCd;
		private System.Windows.Forms.Label lbl_LineCd;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.DateTimePicker dpick_ToYMD;
		public System.Windows.Forms.DateTimePicker dpick_FromYMD;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		private COM.FSP fgrid_TS;
		private System.Windows.Forms.ImageList img_SmallLabel;


		#endregion

		#region 생성자, 소멸자


		public Form_PD_MiniSize_TS_Check()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}



		private string _Factory;
		private string _Line;
		private string _PlanYMD;
		private string _OpCd;


		public Form_PD_MiniSize_TS_Check(string arg_factory, string arg_line_cd, string arg_from_date, string arg_op_cd)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_Factory = arg_factory;
			_Line = arg_line_cd;
			_PlanYMD = arg_from_date;
			_OpCd = arg_op_cd;


			Init_Form();


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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PD_MiniSize_TS_Check));
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_Head = new System.Windows.Forms.Panel();
			this.fgrid_TS = new COM.FSP();
			this.pnl_HeadSearch = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbl_PlanYMD = new System.Windows.Forms.Label();
			this.cmb_LineCd = new C1.Win.C1List.C1Combo();
			this.lbl_LineCd = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dpick_ToYMD = new System.Windows.Forms.DateTimePicker();
			this.dpick_FromYMD = new System.Windows.Forms.DateTimePicker();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.pnl_Head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_TS)).BeginInit();
			this.pnl_HeadSearch.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LineCd)).BeginInit();
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
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Sizer1.BackColor = System.Drawing.SystemColors.Window;
			this.c1Sizer1.Controls.Add(this.pnl_Head);
			this.c1Sizer1.GridDefinition = "35.4166666666667:False:False;62.5:False:False;\t99.2125984251968:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 31;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_Head
			// 
			this.pnl_Head.Controls.Add(this.fgrid_TS);
			this.pnl_Head.Controls.Add(this.pnl_HeadSearch);
			this.pnl_Head.Location = new System.Drawing.Point(4, 4);
			this.pnl_Head.Name = "pnl_Head";
			this.pnl_Head.Size = new System.Drawing.Size(1008, 568);
			this.pnl_Head.TabIndex = 1;
			// 
			// fgrid_TS
			// 
			this.fgrid_TS.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_TS.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_TS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_TS.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_TS.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_TS.Location = new System.Drawing.Point(0, 65);
			this.fgrid_TS.Name = "fgrid_TS";
			this.fgrid_TS.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_TS.Size = new System.Drawing.Size(1008, 503);
			this.fgrid_TS.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_TS.TabIndex = 43;
			this.fgrid_TS.Click += new System.EventHandler(this.fgrid_TS_Click);
			// 
			// pnl_HeadSearch
			// 
			this.pnl_HeadSearch.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_HeadSearch.Controls.Add(this.panel1);
			this.pnl_HeadSearch.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_HeadSearch.DockPadding.Bottom = 3;
			this.pnl_HeadSearch.Location = new System.Drawing.Point(0, 0);
			this.pnl_HeadSearch.Name = "pnl_HeadSearch";
			this.pnl_HeadSearch.Size = new System.Drawing.Size(1008, 65);
			this.pnl_HeadSearch.TabIndex = 42;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.lbl_PlanYMD);
			this.panel1.Controls.Add(this.cmb_LineCd);
			this.panel1.Controls.Add(this.lbl_LineCd);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.dpick_ToYMD);
			this.panel1.Controls.Add(this.dpick_FromYMD);
			this.panel1.Controls.Add(this.cmb_Factory);
			this.panel1.Controls.Add(this.lbl_Factory);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.lbl_SubTitle1);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.pictureBox5);
			this.panel1.Controls.Add(this.pictureBox6);
			this.panel1.Controls.Add(this.pictureBox7);
			this.panel1.Controls.Add(this.pictureBox8);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1008, 62);
			this.panel1.TabIndex = 18;
			// 
			// lbl_PlanYMD
			// 
			this.lbl_PlanYMD.ImageIndex = 0;
			this.lbl_PlanYMD.ImageList = this.img_Label;
			this.lbl_PlanYMD.Location = new System.Drawing.Point(176, 34);
			this.lbl_PlanYMD.Name = "lbl_PlanYMD";
			this.lbl_PlanYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_PlanYMD.TabIndex = 35;
			this.lbl_PlanYMD.Text = "Assy. Date";
			this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_LineCd
			// 
			this.cmb_LineCd.AddItemCols = 0;
			this.cmb_LineCd.AddItemSeparator = ';';
			this.cmb_LineCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_LineCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_LineCd.Caption = "";
			this.cmb_LineCd.CaptionHeight = 17;
			this.cmb_LineCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_LineCd.ColumnCaptionHeight = 18;
			this.cmb_LineCd.ColumnFooterHeight = 18;
			this.cmb_LineCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_LineCd.ContentHeight = 17;
			this.cmb_LineCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_LineCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_LineCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LineCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_LineCd.EditorHeight = 17;
			this.cmb_LineCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LineCd.GapHeight = 2;
			this.cmb_LineCd.ItemHeight = 15;
			this.cmb_LineCd.Location = new System.Drawing.Point(441, 34);
			this.cmb_LineCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_LineCd.MaxDropDownItems = ((short)(5));
			this.cmb_LineCd.MaxLength = 32767;
			this.cmb_LineCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_LineCd.Name = "cmb_LineCd";
			this.cmb_LineCd.PartialRightColumn = false;
			this.cmb_LineCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_LineCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_LineCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_LineCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_LineCd.Size = new System.Drawing.Size(100, 21);
			this.cmb_LineCd.TabIndex = 73;
			this.cmb_LineCd.SelectedValueChanged += new System.EventHandler(this.cmb_LineCd_SelectedValueChanged);
			// 
			// lbl_LineCd
			// 
			this.lbl_LineCd.ImageIndex = 0;
			this.lbl_LineCd.ImageList = this.img_SmallLabel;
			this.lbl_LineCd.Location = new System.Drawing.Point(390, 34);
			this.lbl_LineCd.Name = "lbl_LineCd";
			this.lbl_LineCd.Size = new System.Drawing.Size(50, 21);
			this.lbl_LineCd.TabIndex = 72;
			this.lbl_LineCd.Text = "Line";
			this.lbl_LineCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(280, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 21);
			this.label1.TabIndex = 193;
			this.label1.Text = "~";
			this.label1.Visible = false;
			// 
			// dpick_ToYMD
			// 
			this.dpick_ToYMD.CustomFormat = "yyyyMMdd";
			this.dpick_ToYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.dpick_ToYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ToYMD.Location = new System.Drawing.Point(296, 8);
			this.dpick_ToYMD.Name = "dpick_ToYMD";
			this.dpick_ToYMD.Size = new System.Drawing.Size(100, 22);
			this.dpick_ToYMD.TabIndex = 195;
			this.dpick_ToYMD.Visible = false;
			this.dpick_ToYMD.CloseUp += new System.EventHandler(this.dpick_CloseUp);
			this.dpick_ToYMD.ValueChanged += new System.EventHandler(this.dpick_ValueChanged);
			// 
			// dpick_FromYMD
			// 
			this.dpick_FromYMD.CustomFormat = "yyyyMMdd";
			this.dpick_FromYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.dpick_FromYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_FromYMD.Location = new System.Drawing.Point(277, 34);
			this.dpick_FromYMD.Name = "dpick_FromYMD";
			this.dpick_FromYMD.Size = new System.Drawing.Size(100, 22);
			this.dpick_FromYMD.TabIndex = 194;
			this.dpick_FromYMD.CloseUp += new System.EventHandler(this.dpick_CloseUp);
			this.dpick_FromYMD.ValueChanged += new System.EventHandler(this.dpick_ValueChanged);
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
			this.cmb_Factory.Location = new System.Drawing.Point(61, 34);
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
			this.cmb_Factory.Size = new System.Drawing.Size(100, 21);
			this.cmb_Factory.TabIndex = 33;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_SmallLabel;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 34);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(50, 21);
			this.lbl_Factory.TabIndex = 32;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(993, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(15, 22);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(992, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 32);
			this.pictureBox2.TabIndex = 21;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(224, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(784, 32);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle1.TabIndex = 28;
			this.lbl_SubTitle1.Text = "      LOT Information";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(992, 46);
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
			this.pictureBox5.Location = new System.Drawing.Point(144, 44);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(848, 18);
			this.pictureBox5.TabIndex = 24;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 42);
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
			this.pictureBox7.Size = new System.Drawing.Size(168, 22);
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
			this.pictureBox8.Location = new System.Drawing.Point(160, 24);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(840, 22);
			this.pictureBox8.TabIndex = 27;
			this.pictureBox8.TabStop = false;
			// 
			// Form_PD_MiniSize_TS_Check
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_PD_MiniSize_TS_Check";
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.pnl_Head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_TS)).EndInit();
			this.pnl_HeadSearch.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_LineCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 
		private COM.ComFunction MyComFunction = new COM.ComFunction();
  

		//선택되어졌던 젠더 행
		private int _BeforeGenRow = -1;



		#endregion 

		#region 멤버 메서드


		#region 초기화

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			
			try
			{ 
  

				//Title
				this.Text = "Time Sequence";
				this.lbl_MainTitle.Text = "Time Sequence"; 
 

				//Set Combo List
				Init_Control(); 



				fgrid_TS.Set_Grid("SPD_LOT_DAILY_MINI_TS_SIZE", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
				fgrid_TS.ExtendLastCol = false;
				fgrid_TS.AllowEditing = false;
				fgrid_TS.AllowSorting = AllowSortingEnum.None;
				fgrid_TS.Font = new Font("Verdana", 7);
				fgrid_TS.Styles.Alternate.BackColor = Color.White; 

 

				dpick_FromYMD.Text = MyComFunction.ConvertDate2Type(_PlanYMD); 
				dpick_ToYMD.Text = MyComFunction.ConvertDate2Type(_PlanYMD);  

				cmb_Factory.SelectedValue = _Factory;


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

  
		}


		
		/// <summary>
		/// Init_Control : 
		/// </summary>
		private void Init_Control()
		{
   

			tbtn_Save.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Color.Enabled = false;



			dpick_FromYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			dpick_ToYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;


			DataTable dt_ret = COM.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);

			



		} 
		
 



		#endregion
		  
		#region 조회

 
		/// <summary>
		/// Display_LOT_DAILY_MINI_TS_SIZE : 
		/// </summary>
		private void Display_LOT_DAILY_MINI_TS_SIZE()
		{

			string before_item = "", now_item = ""; 
			int gen_row = 0;   
			string sel_gen = "";
			int min_size_col = fgrid_TS.Cols.Count + 1;   //default : col max value
			int size_qty = 0, sum_size_qty = 0;


			

			string factory = cmb_Factory.SelectedValue.ToString(); 
			string fromymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
			string toymd = dpick_ToYMD.Value.ToString("yyyyMMdd");
			string line_cd = ClassLib.ComFunction.Empty_Combo(cmb_LineCd, " ");
			string lot = " ";

			DataTable dt_ret = Select_SPD_MINI_TS_SIZE_CHECK(factory, fromymd, toymd, line_cd, lot);
 
			fgrid_TS.Rows.Count = fgrid_TS.Rows.Fixed; 

			if(dt_ret.Rows.Count == 0) return; 


  
			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
      	 
				now_item = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxLOT - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxINPUT_PRIO - 1].ToString();
 
				if(before_item != now_item)
				{
  
					fgrid_TS.Rows.Add();
								
					//default data setting
					for(int j = 1; j <= (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxGEN; j++)
					{
						fgrid_TS[fgrid_TS.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j - 1].ToString();
					}
 					 
					//gen
					for(int j = 1; j <= fgrid_TS.Rows.Fixed; j++)
					{
						if(fgrid_TS[j, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxGEN].ToString() == dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxGEN - 1].ToString())
						{
							gen_row = j;
							sel_gen = sel_gen + "/" + fgrid_TS[gen_row, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxGEN].ToString();

							break;
						} 
					}


					before_item = now_item; 

					sum_size_qty = 0;
					

				}
 

				//--------------------------------------------------------------

				for(int j = (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxCS_SIZE_START; j < fgrid_TS.Cols.Count; j++)
				{
					if(fgrid_TS[gen_row, j].ToString() == dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxCS_SIZE - 1].ToString())
					{
						min_size_col = (min_size_col > j) ? j : min_size_col;

						size_qty = Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxSIZE_QTY - 1].ToString()); 
						fgrid_TS[fgrid_TS.Rows.Count - 1, j] = (size_qty.ToString() == "0") ? "" : size_qty.ToString();

						sum_size_qty += size_qty;
						

						break; 
					} 
				}
  


				fgrid_TS[fgrid_TS.Rows.Count - 1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxTOT_QTY] = sum_size_qty.ToString();

 	 



			} // end for 



			//--------------------------------------------------------------
			//LOT에 대한 젠더만 표시
			string[] token = sel_gen.Split('/');

			for(int i = 1; i < fgrid_TS.Rows.Fixed; i++) 
				fgrid_TS.Rows[i].Visible = false;   

			for(int i = 1; i < fgrid_TS.Rows.Fixed; i++) 
			{
				for(int j = 0; j < token.Length; j++)
				{
					if(fgrid_TS[i, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxGEN].ToString() == token[j])
					{
						fgrid_TS.Rows[i].Visible = true; 
						break;
					} 
				} // end for j 
			} // end for i
  

			//--------------------------------------------------------------
			//Merge 속성 
			fgrid_TS.AllowMerging = AllowMergingEnum.Free; 
			for(int i = fgrid_TS.Rows.Fixed; i < fgrid_TS.Rows.Count; i++) fgrid_TS.Rows[i].AllowMerging = false;  
			fgrid_TS.Cols[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxMODEL_NAME].AllowMerging = true;
			fgrid_TS.Cols[(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxSTYLE_CD].AllowMerging = true;


			//--------------------------------------------------------------
			// subtotal 
			fgrid_TS.Subtotal(AggregateEnum.Clear);
			fgrid_TS.SubtotalPosition = SubtotalPositionEnum.BelowData;  
//			fgrid_TS.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;
//			fgrid_TS.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;   
			fgrid_TS.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrSubTotal1;
			fgrid_TS.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black;   
			fgrid_TS.Styles[CellStyleEnum.Subtotal2].BackColor = ClassLib.ComVar.ClrSubTotal2;
			fgrid_TS.Styles[CellStyleEnum.Subtotal2].ForeColor = Color.Black;    
  
 
			fgrid_TS.Subtotal(AggregateEnum.Sum,2, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxINPUT_PRIO, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxTOT_QTY, "");

			for(int i = (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxCS_SIZE_START; i < fgrid_TS.Cols.Count; i++)
			{
				fgrid_TS.Subtotal(AggregateEnum.Sum, 2, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxINPUT_PRIO, i, "");
			}
 


			fgrid_TS.Subtotal(AggregateEnum.Sum, 1, -1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxTOT_QTY, "");

			for(int i = (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxCS_SIZE_START; i < fgrid_TS.Cols.Count; i++)
			{
				fgrid_TS.Subtotal(AggregateEnum.Sum, 1, -1, i, "");
			}
 

 

			//--------------------------------------------------------------
			//기타 속성 
			fgrid_TS.Cols.Frozen = (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxCS_SIZE_START;
			fgrid_TS.LeftCol = min_size_col;


		}



		#endregion

		#region 툴바 이벤트 메서드


		/// <summary>
		/// Event_Tbtn_New : 
		/// </summary>
		private void Event_Tbtn_New()
		{
		
			fgrid_TS.Rows.Count = fgrid_TS.Rows.Fixed;

		}


		/// <summary>
		/// Event_Tbtn_Search : 
		/// </summary>
		private void Event_Tbtn_Search()
		{
 
			Display_LOT_DAILY_MINI_TS_SIZE();

		}

 

		/// <summary>
		/// Event_Tbtn_Print : 
		/// </summary>
		private void Event_Tbtn_Print()
		{

			if(fgrid_TS.Rows.Count < fgrid_TS.Rows.Fixed) return;

 
			string filename = Application.StartupPath + @"\Report\Production\" + this.Name + ".txt";
			string sDir = ClassLib.ComFunction.Set_RD_Directory(this.Name); 

			FileInfo file = new FileInfo(filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}

			file = null; 
			 

			fgrid_TS.ClipSeparators = "@ ";
			fgrid_TS.SaveGrid( filename, FileFormatEnum.TextCustom);
 
			string title = "Size to Time Sequence (Check).";

			string para = "/rfn [" + filename + "] /rv V_LINE[" + cmb_LineCd.Columns[1].Text + "] V_ASYDATE[" + dpick_FromYMD.Value.ToString("yyyy-MM-dd") + "]";
			
			COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report(title, sDir, para);


			report.ShowDialog(); 
		


		}




		#endregion

		#region 그리드 이벤트 메서드

  
		/// <summary>
		/// Event_Click_fgrid_TS 
		/// </summary>
		private void Event_Click_fgrid_TS()
		{

			if(fgrid_TS.Rows.Count <= fgrid_TS.Rows.Fixed) return;


			if(fgrid_TS[fgrid_TS.Selection.r1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxLOT] == null
				|| fgrid_TS[fgrid_TS.Selection.r1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxLOT].ToString().Trim().Equals("") ) return;


			//------------------------------------------------
			//선택한 젠더행 색깔 표시
			string sel_gen = fgrid_TS[fgrid_TS.Selection.r1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxGEN].ToString();

			int findrow = fgrid_TS.FindRow(sel_gen, 1, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxGEN, false, true, false);

			if(findrow == -1) return;

			fgrid_TS.GetCellRange(findrow, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxGEN, findrow, fgrid_TS.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrSel_Yellow; 
			fgrid_TS.GetCellRange(findrow, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxGEN, findrow, fgrid_TS.Cols.Count - 1).StyleNew.ForeColor = Color.Black;
 
			if(_BeforeGenRow != -1 && _BeforeGenRow != findrow) 
				fgrid_TS.GetCellRange(_BeforeGenRow, (int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxGEN, _BeforeGenRow, fgrid_TS.Cols.Count - 1).StyleNew.Clear(); 

			_BeforeGenRow = findrow;

			  
		}



		#endregion

		#region 버튼 및 기타 이벤트 메서드

 


		#endregion

		#region 컨텍스트 메뉴 이벤트 메서드

 

		#endregion
 

		#endregion   
		
		#region 이벤트 처리

		#region 툴바 이벤트


		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				Event_Tbtn_New();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_New", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Search(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}
 

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Print(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}
		} 




		#endregion 

		#region 그리드 이벤트
 
		private void fgrid_TS_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_fgrid_TS(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_fgrid_TS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
		
		}
 


		#endregion

		#region 버튼 및 기타 이벤트
  

		
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{

				if(cmb_Factory.SelectedIndex == -1) return;

				string factory = cmb_Factory.SelectedValue.ToString();
				DataTable dt_ret = FlexAPS.ProdBase.Form_PB_Line.Select_SPB_LINE_ROLE(factory);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LineCd, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
				dt_ret.Dispose();


				// 사이즈 헤더 할당
				fgrid_TS.Rows.Count = 2;

				ClassLib.ComFunction.Set_DefaultSize_Head_CM_SIZE(fgrid_TS, 
															factory, 
															"", 
															fgrid_TS.Rows.Fixed,
															(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxGEN,
															(int)ClassLib.TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC.IxCS_SIZE_START);




				cmb_LineCd.SelectedValue = _Line; 



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		

		private void dpick_ValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{

				DateTimePicker src = sender as DateTimePicker;

				src.CustomFormat = ClassLib.ComVar.This_SetedDateType;
  
				if(src.Equals(dpick_FromYMD))
				{
					dpick_ToYMD.Text = dpick_FromYMD.Text;  
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		
		private void dpick_CloseUp(object sender, System.EventArgs e)
		{
			try
			{

				DateTimePicker src = sender as DateTimePicker; 
  
				fgrid_TS.Rows.Count = fgrid_TS.Rows.Fixed; 


				if(src.Equals(dpick_ToYMD))
				{
					Display_LOT_DAILY_MINI_TS_SIZE();
				}
 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_FromYMD_CloseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		} 


		private void cmb_LineCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{ 
				Display_LOT_DAILY_MINI_TS_SIZE();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_LineCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		

		 
		#endregion

		#region 컨텍스트 메뉴 이벤트

  

		#endregion


		#endregion
		 
		#region 디비 연결
 

		/// <summary>
		/// Select_SPD_MINI_TS_SIZE_CHECK : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_fromymd"></param>
		/// <param name="arg_toymd"></param>
		/// <param name="arg_line_cd"></param>
		/// <param name="arg_lot"></param>
		/// <returns></returns>
		private DataTable Select_SPD_MINI_TS_SIZE_CHECK(string arg_factory, string arg_fromymd, string arg_toymd, string arg_line_cd, string arg_lot)
		{

		
			try
			{
				
				DataSet ds_ret;

				string process_name = "PKG_SPD_DAILY_BSC.SELECT_SPD_MINI_TS_SIZE_CHECK";

				MyOraDB.ReDim_Parameter(6); 
  
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_FROMYMD";
				MyOraDB.Parameter_Name[2] = "ARG_TOYMD";
				MyOraDB.Parameter_Name[3] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[4] = "ARG_LOT";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_fromymd;  
				MyOraDB.Parameter_Values[2] = arg_toymd; 
				MyOraDB.Parameter_Values[3] = arg_line_cd; 
				MyOraDB.Parameter_Values[4] = arg_lot;
				MyOraDB.Parameter_Values[5] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
				
			}
			catch
			{
				return null;
			}


		}

		#endregion

		



	}
}

