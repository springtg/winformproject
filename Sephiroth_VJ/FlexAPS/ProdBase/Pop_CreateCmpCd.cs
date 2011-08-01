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
	public class Pop_CreateCmpCd : COM.APSWinForm.Pop_Large
	{
		#region 컨트롤 정의 및 리소스 정리 

		public COM.FSP fgrid_Cmp;
		private System.Windows.Forms.GroupBox groupBox1;
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
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label btn_Search;
		private System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.Label btn_Close;
		private System.Windows.Forms.Label btn_Append;
		private System.Windows.Forms.Label btn_Delete;
		private System.Windows.Forms.ImageList img_Action;
		private System.Windows.Forms.Label lbl_FS;
		private System.Windows.Forms.Label lbl_SG;
		private System.Windows.Forms.Label lbl_BM;
		private System.Windows.Forms.Label lbl_CG;
		private System.Windows.Forms.Label lbl_PT;
		private System.ComponentModel.IContainer components = null;

		public Pop_CreateCmpCd()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_CreateCmpCd));
			this.fgrid_Cmp = new COM.FSP();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbl_FS = new System.Windows.Forms.Label();
			this.lbl_SG = new System.Windows.Forms.Label();
			this.lbl_PT = new System.Windows.Forms.Label();
			this.lbl_CG = new System.Windows.Forms.Label();
			this.lbl_BM = new System.Windows.Forms.Label();
			this.btn_Append = new System.Windows.Forms.Label();
			this.btn_Delete = new System.Windows.Forms.Label();
			this.btn_Apply = new System.Windows.Forms.Label();
			this.btn_Close = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.pnl_T = new System.Windows.Forms.Panel();
			this.pnl_CSearchSplitLeft = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Search = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
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
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Cmp)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.pnl_T.SuspendLayout();
			this.pnl_CSearchSplitLeft.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
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
			this.lbl_MainTitle.Text = "Create BOM Component";
			// 
			// fgrid_Cmp
			// 
			this.fgrid_Cmp.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Cmp.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Cmp.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Cmp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Cmp.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Cmp.Location = new System.Drawing.Point(8, 114);
			this.fgrid_Cmp.Name = "fgrid_Cmp";
			this.fgrid_Cmp.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Cmp.Size = new System.Drawing.Size(678, 262);
			this.fgrid_Cmp.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Cmp.TabIndex = 32;
			this.fgrid_Cmp.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Cmp_BeforeEdit);
			this.fgrid_Cmp.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Cmp_AfterEdit);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.lbl_FS);
			this.groupBox1.Controls.Add(this.lbl_SG);
			this.groupBox1.Controls.Add(this.lbl_PT);
			this.groupBox1.Controls.Add(this.lbl_CG);
			this.groupBox1.Controls.Add(this.lbl_BM);
			this.groupBox1.Controls.Add(this.btn_Append);
			this.groupBox1.Controls.Add(this.btn_Delete);
			this.groupBox1.Controls.Add(this.btn_Apply);
			this.groupBox1.Controls.Add(this.btn_Close);
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(8, 379);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(680, 77);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Abbreviation";
			// 
			// lbl_FS
			// 
			this.lbl_FS.BackColor = System.Drawing.Color.Transparent;
			this.lbl_FS.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_FS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_FS.Location = new System.Drawing.Point(8, 22);
			this.lbl_FS.Name = "lbl_FS";
			this.lbl_FS.Size = new System.Drawing.Size(124, 21);
			this.lbl_FS.TabIndex = 14;
			this.lbl_FS.Text = "FS : Final Goods";
			this.lbl_FS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_SG
			// 
			this.lbl_SG.BackColor = System.Drawing.Color.Transparent;
			this.lbl_SG.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_SG.Location = new System.Drawing.Point(184, 22);
			this.lbl_SG.Name = "lbl_SG";
			this.lbl_SG.Size = new System.Drawing.Size(168, 21);
			this.lbl_SG.TabIndex = 15;
			this.lbl_SG.Text = "SG : Semi Finished Goods";
			this.lbl_SG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_PT
			// 
			this.lbl_PT.BackColor = System.Drawing.Color.Transparent;
			this.lbl_PT.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_PT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_PT.Location = new System.Drawing.Point(184, 48);
			this.lbl_PT.Name = "lbl_PT";
			this.lbl_PT.Size = new System.Drawing.Size(144, 21);
			this.lbl_PT.TabIndex = 18;
			this.lbl_PT.Text = "PT : Phantom Goods";
			this.lbl_PT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_CG
			// 
			this.lbl_CG.BackColor = System.Drawing.Color.Transparent;
			this.lbl_CG.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_CG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_CG.Location = new System.Drawing.Point(8, 48);
			this.lbl_CG.Name = "lbl_CG";
			this.lbl_CG.Size = new System.Drawing.Size(160, 21);
			this.lbl_CG.TabIndex = 17;
			this.lbl_CG.Text = "CG : Component Goods";
			this.lbl_CG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_BM
			// 
			this.lbl_BM.BackColor = System.Drawing.Color.Transparent;
			this.lbl_BM.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_BM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_BM.Location = new System.Drawing.Point(392, 22);
			this.lbl_BM.Name = "lbl_BM";
			this.lbl_BM.Size = new System.Drawing.Size(128, 21);
			this.lbl_BM.TabIndex = 16;
			this.lbl_BM.Text = "BM : Base Material";
			this.lbl_BM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Append
			// 
			this.btn_Append.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Append.ImageIndex = 0;
			this.btn_Append.ImageList = this.img_Button;
			this.btn_Append.Location = new System.Drawing.Point(387, 48);
			this.btn_Append.Name = "btn_Append";
			this.btn_Append.Size = new System.Drawing.Size(70, 23);
			this.btn_Append.TabIndex = 68;
			this.btn_Append.Text = "Add";
			this.btn_Append.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Append.Click += new System.EventHandler(this.btn_Append_Click);
			this.btn_Append.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Append.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Delete
			// 
			this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Delete.ImageIndex = 0;
			this.btn_Delete.ImageList = this.img_Button;
			this.btn_Delete.Location = new System.Drawing.Point(458, 48);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(70, 23);
			this.btn_Delete.TabIndex = 69;
			this.btn_Delete.Text = "Delete";
			this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			this.btn_Delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Apply
			// 
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(529, 48);
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
			this.btn_Close.Location = new System.Drawing.Point(600, 48);
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
			this.pnl_T.DockPadding.Bottom = 5;
			this.pnl_T.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_T.Location = new System.Drawing.Point(8, 46);
			this.pnl_T.Name = "pnl_T";
			this.pnl_T.Size = new System.Drawing.Size(678, 68);
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
			this.pnl_CSearchSplitLeft.Size = new System.Drawing.Size(678, 63);
			this.pnl_CSearchSplitLeft.TabIndex = 26;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.btn_Search);
			this.panel1.Controls.Add(this.cmb_Factory);
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
			this.panel1.Size = new System.Drawing.Size(678, 63);
			this.panel1.TabIndex = 19;
			// 
			// btn_Search
			// 
			this.btn_Search.BackColor = System.Drawing.SystemColors.Control;
			this.btn_Search.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.btn_Search.ImageIndex = 0;
			this.btn_Search.ImageList = this.img_MiniButton;
			this.btn_Search.Location = new System.Drawing.Point(331, 36);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(21, 21);
			this.btn_Search.TabIndex = 213;
			this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			this.btn_Search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
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
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(219, 21);
			this.cmb_Factory.TabIndex = 14;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 0;
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
			this.pictureBox8.Location = new System.Drawing.Point(0, 43);
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
			this.pictureBox2.Location = new System.Drawing.Point(662, 47);
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
			this.pictureBox1.Size = new System.Drawing.Size(23, 63);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(131, 45);
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
			this.pictureBox6.Size = new System.Drawing.Size(678, 63);
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
			this.lbl_SubTitle1.Text = "      Define Component ";
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
			this.pictureBox7.Size = new System.Drawing.Size(168, 63);
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
			// Pop_CreateCmpCd
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 464);
			this.Controls.Add(this.pnl_T);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.fgrid_Cmp);
			this.Name = "Pop_CreateCmpCd";
			this.Text = "Create BOM Component";
			this.Load += new System.EventHandler(this.Pop_CreateCmpCd_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.fgrid_Cmp, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.pnl_T, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Cmp)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.pnl_T.ResumeLayout(false);
			this.pnl_CSearchSplitLeft.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의 

		private COM.OraDB MyOraDB = new COM.OraDB();

		private string _Factory;
		private int _Rowfixed; 

		#endregion 

		#region 멤버 메서드

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			DataTable dt_ret;

			try
			{
				//Title
				this.Text = "Create BOM Component";
				this.lbl_MainTitle.Text = "Create BOM Component";

				ClassLib.ComFunction.SetLangDic(this);
 
				//cmb_Factory.Enabled = false;


				 
				fgrid_Cmp.Set_Grid("SPB_CMP", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
				fgrid_Cmp.Set_Action_Image(img_Action);
				_Rowfixed = fgrid_Cmp.Rows.Fixed;

				
				dt_ret = ClassLib.ComFunction.Select_Factory_List(); 
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 

				if(ClassLib.ComVar.FormClick_Flag == true)
				{
					//cmb_Factory.Enabled = false;
					_Factory = ClassLib.ComVar.Parameter_PopUp[0]; 
					cmb_Factory.SelectedValue = _Factory;
				}
				else
				{
					//cmb_Factory.Enabled = true;
					cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
				} 
			

				dt_ret = Select_SPB_CMP();
				Display_Grid(dt_ret, fgrid_Cmp);
			}
			catch
			{
			} 

		}

		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_Grid(DataTable arg_dt, COM.FSP arg_fgrid)
		{
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1; 
 
			try
			{
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
					arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = ""; 
				} 

				arg_fgrid.AutoSizeCols();
			}
			catch
			{
			}
 
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

		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				dt_ret = Select_SPB_CMP();
				Display_Grid(dt_ret, fgrid_Cmp);
			}
			catch
			{
			}
		}

		
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				dt_ret = Select_SPB_CMP();
				Display_Grid(dt_ret, fgrid_Cmp);
			}
			catch
			{
			}
		}

		private void btn_Append_Click(object sender, System.EventArgs e)
		{
			try
			{
				fgrid_Cmp.Add_Row(fgrid_Cmp.Rows.Count - 1);
				fgrid_Cmp[fgrid_Cmp.Rows.Count - 1, (int)ClassLib.TBSPB_CMP.IxFACTORY] = cmb_Factory.SelectedValue.ToString();
			}
			catch
			{
			}
		}

		private void btn_Delete_Click(object sender, System.EventArgs e)
		{
			try
			{
				fgrid_Cmp.Delete_Row();
			}
			catch
			{
			}
		}

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				//행 수정 상태 해제
				fgrid_Cmp.Select(fgrid_Cmp.Selection.r1, 0, fgrid_Cmp.Selection.r1, fgrid_Cmp.Cols.Count - 1, false);
  
				MyOraDB.Save_FlexGird("PKG_SPB_RSC.SAVE_SPB_CMP", fgrid_Cmp); 

				dt_ret = Select_SPB_CMP();
				Display_Grid(dt_ret, fgrid_Cmp);
				fgrid_Cmp.TopRow = fgrid_Cmp.Rows.Count - 1;  //fgrid_Cmp.Selection.r1;

			}
			catch
			{
			}
		}

		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				this.Close();
			}
			catch
			{
			}
		}

		private void fgrid_Cmp_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if ((fgrid_Cmp.Rows.Fixed > 0) && (fgrid_Cmp.Row >= fgrid_Cmp.Rows.Fixed))
			{
				if(fgrid_Cmp.Cols[fgrid_Cmp.Col].DataType == typeof(bool))
				{
					fgrid_Cmp.Buffer_CellData = "";
				}
				else
				{
					fgrid_Cmp.Buffer_CellData = (fgrid_Cmp[fgrid_Cmp.Row, fgrid_Cmp.Col] == null) ? "" : fgrid_Cmp[fgrid_Cmp.Row, fgrid_Cmp.Col].ToString();
				}
			} // end if
		}

		
		private void fgrid_Cmp_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_Cmp.Update_Row(); 
			fgrid_Cmp.AutoSizeCols();
		}


		#endregion
 
		#region DB Connect
 
		/// <summary>
		/// Select_SPB_CMP : Component 코드 리스트 찾기
		/// </summary>
		private DataTable Select_SPB_CMP()
		{
			DataSet ds_ret; 

			try
			{ 
				string process_name = "PKG_SPB_RSC.SELECT_CMP_LIST";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = ""; 

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
 

		private void Pop_CreateCmpCd_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		
		

	}
}

