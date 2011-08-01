using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 

namespace FlexAPS.ProdBase
{
	public class Pop_SetCostCenterDiv : COM.APSWinForm.Pop_Large
	{


		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.Panel pnl_T;
		public System.Windows.Forms.Panel pnl_CSearchSplitLeft;
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.Label btn_Search;
		private System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.Label btn_Close;
		private System.Windows.Forms.ImageList img_Action;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.Label lbl_Factory;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private C1.Win.C1List.C1Combo cmb_OpCd;
		private System.Windows.Forms.Label lbl_OpCd;
		private C1.Win.C1List.C1Combo cmb_Line;
		private System.Windows.Forms.Label lbl_Line;
		private System.ComponentModel.IContainer components = null;

		public Pop_SetCostCenterDiv()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_SetCostCenterDiv));
			this.fgrid_Main = new COM.FSP();
			this.btn_Apply = new System.Windows.Forms.Label();
			this.btn_Close = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.pnl_T = new System.Windows.Forms.Panel();
			this.pnl_CSearchSplitLeft = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Search = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.img_Action = new System.Windows.Forms.ImageList(this.components);
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.cmb_OpCd = new C1.Win.C1List.C1Combo();
			this.lbl_OpCd = new System.Windows.Forms.Label();
			this.cmb_Line = new C1.Win.C1List.C1Combo();
			this.lbl_Line = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			this.pnl_T.SuspendLayout();
			this.pnl_CSearchSplitLeft.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OpCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(304, 23);
			this.lbl_MainTitle.Text = "Cost Center 1st Division";
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.Location = new System.Drawing.Point(8, 134);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(678, 302);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 32;
			this.fgrid_Main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_BeforeEdit);
			this.fgrid_Main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_Main_MouseUp);
			this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
			// 
			// btn_Apply
			// 
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(545, 448);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(70, 23);
			this.btn_Apply.TabIndex = 67;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Close
			// 
			this.btn_Close.ImageIndex = 0;
			this.btn_Close.ImageList = this.img_Button;
			this.btn_Close.Location = new System.Drawing.Point(616, 448);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(70, 23);
			this.btn_Close.TabIndex = 66;
			this.btn_Close.Text = "Close";
			this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			this.btn_Close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			// 
			// pnl_T
			// 
			this.pnl_T.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_T.Controls.Add(this.pnl_CSearchSplitLeft);
			this.pnl_T.DockPadding.Bottom = 2;
			this.pnl_T.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_T.Location = new System.Drawing.Point(8, 46);
			this.pnl_T.Name = "pnl_T";
			this.pnl_T.Size = new System.Drawing.Size(678, 85);
			this.pnl_T.TabIndex = 34;
			// 
			// pnl_CSearchSplitLeft
			// 
			this.pnl_CSearchSplitLeft.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_CSearchSplitLeft.Controls.Add(this.panel1);
			this.pnl_CSearchSplitLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_CSearchSplitLeft.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_CSearchSplitLeft.Location = new System.Drawing.Point(0, 0);
			this.pnl_CSearchSplitLeft.Name = "pnl_CSearchSplitLeft";
			this.pnl_CSearchSplitLeft.Size = new System.Drawing.Size(678, 83);
			this.pnl_CSearchSplitLeft.TabIndex = 26;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.cmb_Line);
			this.panel1.Controls.Add(this.lbl_Line);
			this.panel1.Controls.Add(this.cmb_OpCd);
			this.panel1.Controls.Add(this.lbl_OpCd);
			this.panel1.Controls.Add(this.cmb_Factory);
			this.panel1.Controls.Add(this.btn_Search);
			this.panel1.Controls.Add(this.lbl_Factory);
			this.panel1.Controls.Add(this.pictureBox8);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.pictureBox5);
			this.panel1.Controls.Add(this.pictureBox6);
			this.panel1.Controls.Add(this.lbl_SubTitle1);
			this.panel1.Controls.Add(this.pictureBox7);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(678, 83);
			this.panel1.TabIndex = 19;
			// 
			// btn_Search
			// 
			this.btn_Search.BackColor = System.Drawing.SystemColors.Control;
			this.btn_Search.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.btn_Search.ImageIndex = 0;
			this.btn_Search.ImageList = this.img_MiniButton;
			this.btn_Search.Location = new System.Drawing.Point(568, 58);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(21, 21);
			this.btn_Search.TabIndex = 213;
			this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			this.btn_Search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
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
			this.lbl_Factory.TabIndex = 13;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(0, 63);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(168, 20);
			this.pictureBox8.TabIndex = 22;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(662, 67);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(24, 16);
			this.pictureBox2.TabIndex = 23;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(663, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(23, 83);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(131, 65);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(678, 18);
			this.pictureBox3.TabIndex = 28;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(662, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(24, 32);
			this.pictureBox4.TabIndex = 21;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(224, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(678, 32);
			this.pictureBox5.TabIndex = 0;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(160, 24);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(678, 83);
			this.pictureBox6.TabIndex = 27;
			this.pictureBox6.TabStop = false;
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
			this.lbl_SubTitle1.TabIndex = 20;
			this.lbl_SubTitle1.Text = "      Define Production Operation";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(0, 24);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(168, 83);
			this.pictureBox7.TabIndex = 25;
			this.pictureBox7.TabStop = false;
			// 
			// img_Action
			// 
			this.img_Action.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Action.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
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
			this.cmb_Factory.Size = new System.Drawing.Size(169, 21);
			this.cmb_Factory.TabIndex = 214;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// cmb_OpCd
			// 
			this.cmb_OpCd.AddItemCols = 0;
			this.cmb_OpCd.AddItemSeparator = ';';
			this.cmb_OpCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OpCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OpCd.Caption = "";
			this.cmb_OpCd.CaptionHeight = 17;
			this.cmb_OpCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OpCd.ColumnCaptionHeight = 18;
			this.cmb_OpCd.ColumnFooterHeight = 18;
			this.cmb_OpCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OpCd.ContentHeight = 17;
			this.cmb_OpCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OpCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OpCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OpCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OpCd.EditorHeight = 17;
			this.cmb_OpCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OpCd.GapHeight = 2;
			this.cmb_OpCd.ItemHeight = 15;
			this.cmb_OpCd.Location = new System.Drawing.Point(111, 58);
			this.cmb_OpCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_OpCd.MaxDropDownItems = ((short)(5));
			this.cmb_OpCd.MaxLength = 32767;
			this.cmb_OpCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OpCd.Name = "cmb_OpCd";
			this.cmb_OpCd.PartialRightColumn = false;
			this.cmb_OpCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_OpCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OpCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OpCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OpCd.Size = new System.Drawing.Size(169, 21);
			this.cmb_OpCd.TabIndex = 216;
			this.cmb_OpCd.SelectedValueChanged += new System.EventHandler(this.cmb_OpCd_SelectedValueChanged);
			// 
			// lbl_OpCd
			// 
			this.lbl_OpCd.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OpCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_OpCd.ImageIndex = 0;
			this.lbl_OpCd.ImageList = this.img_Label;
			this.lbl_OpCd.Location = new System.Drawing.Point(10, 58);
			this.lbl_OpCd.Name = "lbl_OpCd";
			this.lbl_OpCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_OpCd.TabIndex = 215;
			this.lbl_OpCd.Text = "Production OP";
			this.lbl_OpCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Line
			// 
			this.cmb_Line.AddItemCols = 0;
			this.cmb_Line.AddItemSeparator = ';';
			this.cmb_Line.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Line.Caption = "";
			this.cmb_Line.CaptionHeight = 17;
			this.cmb_Line.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Line.ColumnCaptionHeight = 18;
			this.cmb_Line.ColumnFooterHeight = 18;
			this.cmb_Line.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Line.ContentHeight = 17;
			this.cmb_Line.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Line.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Line.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Line.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Line.EditorHeight = 17;
			this.cmb_Line.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Line.GapHeight = 2;
			this.cmb_Line.ItemHeight = 15;
			this.cmb_Line.Location = new System.Drawing.Point(389, 58);
			this.cmb_Line.MatchEntryTimeout = ((long)(2000));
			this.cmb_Line.MaxDropDownItems = ((short)(5));
			this.cmb_Line.MaxLength = 32767;
			this.cmb_Line.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Line.Name = "cmb_Line";
			this.cmb_Line.PartialRightColumn = false;
			this.cmb_Line.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Line.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Line.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Line.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Line.Size = new System.Drawing.Size(169, 21);
			this.cmb_Line.TabIndex = 218;
			this.cmb_Line.SelectedValueChanged += new System.EventHandler(this.cmb_Line_SelectedValueChanged);
			// 
			// lbl_Line
			// 
			this.lbl_Line.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Line.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Line.ImageIndex = 0;
			this.lbl_Line.ImageList = this.img_Label;
			this.lbl_Line.Location = new System.Drawing.Point(288, 58);
			this.lbl_Line.Name = "lbl_Line";
			this.lbl_Line.Size = new System.Drawing.Size(100, 21);
			this.lbl_Line.TabIndex = 217;
			this.lbl_Line.Text = "Line";
			this.lbl_Line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Pop_SetCostCenterDiv
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 479);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.pnl_T);
			this.Controls.Add(this.fgrid_Main);
			this.Name = "Pop_SetCostCenterDiv";
			this.Text = "Cost Center 1st Division";
			this.Load += new System.EventHandler(this.Pop_SetCostCenterDiv_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.fgrid_Main, 0);
			this.Controls.SetChildIndex(this.pnl_T, 0);
			this.Controls.SetChildIndex(this.btn_Close, 0);
			this.Controls.SetChildIndex(this.btn_Apply, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.pnl_T.ResumeLayout(false);
			this.pnl_CSearchSplitLeft.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OpCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();
 
		#endregion 

		#region 멤버 메서드

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			 
			try
			{
				//Title
				this.Text = "Cost Center 1st Division";
				this.lbl_MainTitle.Text = "Cost Center 1st Division";

				ClassLib.ComFunction.SetLangDic(this);

				fgrid_Main.Set_Grid("SPB_OPCD_LINE_DIV", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
				fgrid_Main.Set_Action_Image(img_Action);


				DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List(); 
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
				dt_ret.Dispose();
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;   
    
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		

		/// <summary>
		/// Event_Click_btn_Search : 
		/// </summary>
		private void Event_Click_btn_Search()
		{

			if(cmb_Factory.SelectedIndex == -1) return;

			string factory = cmb_Factory.SelectedValue.ToString();
			string op_cd = ClassLib.ComFunction.Empty_Combo(cmb_OpCd, " ");
			string line_cd = ClassLib.ComFunction.Empty_Combo(cmb_Line, " ");

			DataTable dt_ret = Select_SPB_OPCD_LINE_COST_CENTER(factory, op_cd, line_cd);
			fgrid_Main.Display_Grid(dt_ret, false);

			dt_ret.Dispose();


		}



		/// <summary>
		/// 여러 행 선택 후 데이터 일괄 수정 
		/// </summary>
		/// <param name="e"></param>
		private void Set_Update_SelectionRow(System.Windows.Forms.MouseEventArgs e)
		{

			// 마우스 오른쪽 이벤트에만 팝업창 실행
			if(! e.Button.Equals(MouseButtons.Right) ) return;

			if(fgrid_Main.Rows.Count < fgrid_Main.Rows.Fixed) return;


			int sel_row = fgrid_Main.Rows[fgrid_Main.Row].Index;  
			int sel_col = fgrid_Main.Cols[fgrid_Main.Col].Index;   


			if (! fgrid_Main.Cols[sel_col].AllowEditing) return;
 
	

			C1.Win.C1FlexGrid.CellRange cell = fgrid_Main.GetCellRange(sel_row, sel_col);
 
			
			// 헤더 Description
			string column_desc = fgrid_Main[1, sel_col].ToString();


			Pop_SelectionChange_FSP pop_form = new Pop_SelectionChange_FSP(fgrid_Main, cell, column_desc);
			pop_form.ShowDialog();




			if(! pop_form._Close_Save) return;

			//--------------------------------------------------------------------------------------
			// set update list
			//--------------------------------------------------------------------------------------
			int[] selection_range = fgrid_Main.Selections;

			foreach (int i in selection_range)
			{
				fgrid_Main[i, sel_col] = COM.ComVar.Parameter_PopUp[0];
				fgrid_Main.Update_Row(i);
			}
  
	  
			//--------------------------------------------------------------------------------------


		}



		#endregion 

		#region 이벤트 처리
 
		

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			src.ImageIndex = 1;
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			src.ImageIndex = 0;
		}

		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				 
				if(cmb_Factory.SelectedIndex == -1) return;

				string factory = cmb_Factory.SelectedValue.ToString();

				//DataTable dt_ret = FlexAPS.ProdBase.Form_PB_OpCd.Select_OpCd_List(factory);

				DataTable dt_ret = FlexAPS.ProdBase.Form_PB_OpCd.Select_OpCd_List_ForOpLine(factory);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OpCd, 0, 2, true, COM.ComVar.ComboList_Visible.Code_Name);
				if(cmb_OpCd.ListCount > 1) cmb_OpCd.SelectedIndex = 1;


				dt_ret = FlexAPS.ProdBase.Form_PB_Line.Select_SPB_LINE(factory);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Line, 1, 2, true, COM.ComVar.ComboList_Visible.Code_Name);
				if(cmb_Line.ListCount > 1) cmb_Line.SelectedIndex = 1;

				dt_ret.Dispose();



				Event_Click_btn_Search();



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 

		private void cmb_OpCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_btn_Search();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_OpCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}

		private void cmb_Line_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_btn_Search();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Line_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}

		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			
			try
			{
				Event_Click_btn_Search();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}  
 
		private void btn_Apply_Click(object sender, System.EventArgs e)
		{ 
			try
			{
				//행 수정 상태 해제
				fgrid_Main.Select(fgrid_Main.Selection.r1, 0, fgrid_Main.Selection.r1, fgrid_Main.Cols.Count - 1, false);
   
				int sel_row = fgrid_Main.Selection.r1;

				bool save_flag = MyOraDB.Save_FlexGird("PKG_SPB_OPCD.SAVE_SPB_OPCD_LINE_COST_DIV", fgrid_Main); 

				if(! save_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}
				else
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);

					Event_Click_btn_Search();

					fgrid_Main.TopRow = sel_row; 

				} 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				this.Close();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Close_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		private void fgrid_Main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if ((fgrid_Main.Rows.Fixed > 0) && (fgrid_Main.Row >= fgrid_Main.Rows.Fixed))
			{
				if(fgrid_Main.Cols[fgrid_Main.Col].DataType == typeof(bool))
				{
					fgrid_Main.Buffer_CellData = "";
				}
				else
				{
					fgrid_Main.Buffer_CellData = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
				}
			} // end if
		}

		
		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{ 
			fgrid_Main.Update_Row(); 
		}


		private void fgrid_Main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		
			try
			{
				Set_Update_SelectionRow(e); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Main_MouseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		 

		#endregion
 
		#region DB Connect
 
		
		/// <summary>
		/// Select_SPB_OPCD_LINE_COST_CENTER : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_op_cd"></param>
		/// <param name="arg_line_cd"></param>
		/// <returns></returns>
		private DataTable Select_SPB_OPCD_LINE_COST_CENTER(string arg_factory, string arg_op_cd, string arg_line_cd)
		{
			DataSet ds_ret; 

			try
			{ 
				string process_name = "PKG_SPB_OPCD.SELECT_SPB_OPCD_LINE_COST_DIV";

				MyOraDB.ReDim_Parameter(4); 
 
				MyOraDB.Process_Name = process_name;
   
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_OP_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_LINE_CD"; 
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			   
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_op_cd; 
				MyOraDB.Parameter_Values[2] = arg_line_cd; 
				MyOraDB.Parameter_Values[3] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[process_name]; 

			}
			catch
			{ 
				return null; 
			} 
		}


		#endregion
 

		private void Pop_SetCostCenterDiv_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		

		
	
		
		

	}
}

