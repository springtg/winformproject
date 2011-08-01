using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data;
using System.Data.OracleClient;

namespace FlexAPS.ProdBase
{
	public class Pop_CreateCopyBom : COM.APSWinForm.Pop_Large
	{

		#region 컨트롤 정의 및 리소스 정리 

		private System.Windows.Forms.Label lbl_OBomCd;
		public System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox9;
		public System.Windows.Forms.Label lbl_SubTitle2;
		public COM.FSP fgrid_OrgBOM;
		public System.Windows.Forms.Panel pnl_Copy;
		public COM.FSP fgrid_CopyBOM;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.Label lbl_CFactory;
		private System.Windows.Forms.Label btn_OSearch;
		private System.Windows.Forms.Label btn_CSearch;
		private C1.Win.C1List.C1Combo cmb_OBomCd;
		private C1.Win.C1List.C1Combo cmb_CBomCd;
		private System.Windows.Forms.Label btn_One;
		private System.Windows.Forms.Label btn_Group;
		private System.Windows.Forms.ImageList img_Move;
		private System.Windows.Forms.ImageList img_Tree;
		public System.Windows.Forms.ImageList img_Action;
		public System.Windows.Forms.Panel pnl_LOBodyLeftTop;
		public System.Windows.Forms.Panel panel5;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox pictureBox15;
		public System.Windows.Forms.PictureBox pictureBox16;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private C1.Win.C1Command.C1Command tbtn_Save;
		private C1.Win.C1Command.C1Command tbtn_Delete;
		private C1.Win.C1Command.C1ToolBar c1ToolBar1;
		private C1.Win.C1Command.C1CommandLink c1CommandLink2;
		private C1.Win.C1Command.C1CommandLink c1CommandLink5;
		private System.Windows.Forms.ImageList img_ToolBar;
		private C1.Win.C1Command.C1CommandLink c1CommandLink1;
		private C1.Win.C1Command.C1Command tbtn_New;
		private System.ComponentModel.IContainer components = null;

		public Pop_CreateCopyBom()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_CreateCopyBom));
			this.fgrid_OrgBOM = new COM.FSP();
			this.cmb_OBomCd = new C1.Win.C1List.C1Combo();
			this.btn_OSearch = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.lbl_OBomCd = new System.Windows.Forms.Label();
			this.pnl_Copy = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cmb_CBomCd = new C1.Win.C1List.C1Combo();
			this.btn_CSearch = new System.Windows.Forms.Label();
			this.lbl_CFactory = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle2 = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.fgrid_CopyBOM = new COM.FSP();
			this.btn_One = new System.Windows.Forms.Label();
			this.img_Move = new System.Windows.Forms.ImageList(this.components);
			this.btn_Group = new System.Windows.Forms.Label();
			this.img_Tree = new System.Windows.Forms.ImageList(this.components);
			this.img_Action = new System.Windows.Forms.ImageList(this.components);
			this.pnl_LOBodyLeftTop = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.tbtn_Save = new C1.Win.C1Command.C1Command();
			this.tbtn_Delete = new C1.Win.C1Command.C1Command();
			this.tbtn_New = new C1.Win.C1Command.C1Command();
			this.img_ToolBar = new System.Windows.Forms.ImageList(this.components);
			this.c1ToolBar1 = new C1.Win.C1Command.C1ToolBar();
			this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
			this.c1CommandLink2 = new C1.Win.C1Command.C1CommandLink();
			this.c1CommandLink5 = new C1.Win.C1Command.C1CommandLink();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_OrgBOM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBomCd)).BeginInit();
			this.pnl_Copy.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_CBomCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_CopyBOM)).BeginInit();
			this.pnl_LOBodyLeftTop.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
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
			// 
			// fgrid_OrgBOM
			// 
			this.fgrid_OrgBOM.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_OrgBOM.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_OrgBOM.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_OrgBOM.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_OrgBOM.Location = new System.Drawing.Point(8, 120);
			this.fgrid_OrgBOM.Name = "fgrid_OrgBOM";
			this.fgrid_OrgBOM.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_OrgBOM.Size = new System.Drawing.Size(320, 340);
			this.fgrid_OrgBOM.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Fixed{BackColor:Control;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_OrgBOM.TabIndex = 54;
			// 
			// cmb_OBomCd
			// 
			this.cmb_OBomCd.AddItemCols = 0;
			this.cmb_OBomCd.AddItemSeparator = ';';
			this.cmb_OBomCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBomCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBomCd.Caption = "";
			this.cmb_OBomCd.CaptionHeight = 17;
			this.cmb_OBomCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBomCd.ColumnCaptionHeight = 18;
			this.cmb_OBomCd.ColumnFooterHeight = 18;
			this.cmb_OBomCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBomCd.ContentHeight = 17;
			this.cmb_OBomCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBomCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OBomCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OBomCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBomCd.EditorHeight = 17;
			this.cmb_OBomCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OBomCd.GapHeight = 2;
			this.cmb_OBomCd.ItemHeight = 15;
			this.cmb_OBomCd.Location = new System.Drawing.Point(111, 36);
			this.cmb_OBomCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBomCd.MaxDropDownItems = ((short)(5));
			this.cmb_OBomCd.MaxLength = 32767;
			this.cmb_OBomCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBomCd.Name = "cmb_OBomCd";
			this.cmb_OBomCd.PartialRightColumn = false;
			this.cmb_OBomCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_OBomCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBomCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBomCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBomCd.Size = new System.Drawing.Size(180, 21);
			this.cmb_OBomCd.TabIndex = 213;
			this.cmb_OBomCd.SelectedValueChanged += new System.EventHandler(this.cmb_OBomCd_SelectedValueChanged);
			// 
			// btn_OSearch
			// 
			this.btn_OSearch.BackColor = System.Drawing.SystemColors.Control;
			this.btn_OSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.btn_OSearch.ImageIndex = 0;
			this.btn_OSearch.ImageList = this.img_MiniButton;
			this.btn_OSearch.Location = new System.Drawing.Point(292, 36);
			this.btn_OSearch.Name = "btn_OSearch";
			this.btn_OSearch.Size = new System.Drawing.Size(21, 21);
			this.btn_OSearch.TabIndex = 212;
			this.btn_OSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_OSearch.Click += new System.EventHandler(this.btn_OSearch_Click);
			this.btn_OSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_OSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			// 
			// lbl_OBomCd
			// 
			this.lbl_OBomCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_OBomCd.ImageIndex = 0;
			this.lbl_OBomCd.ImageList = this.img_Label;
			this.lbl_OBomCd.Location = new System.Drawing.Point(10, 36);
			this.lbl_OBomCd.Name = "lbl_OBomCd";
			this.lbl_OBomCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBomCd.TabIndex = 210;
			this.lbl_OBomCd.Text = "BOM Code";
			this.lbl_OBomCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_Copy
			// 
			this.pnl_Copy.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Copy.Controls.Add(this.panel2);
			this.pnl_Copy.DockPadding.Bottom = 8;
			this.pnl_Copy.Font = new System.Drawing.Font("굴림", 9F);
			this.pnl_Copy.Location = new System.Drawing.Point(366, 46);
			this.pnl_Copy.Name = "pnl_Copy";
			this.pnl_Copy.Size = new System.Drawing.Size(320, 74);
			this.pnl_Copy.TabIndex = 211;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Controls.Add(this.cmb_CBomCd);
			this.panel2.Controls.Add(this.btn_CSearch);
			this.panel2.Controls.Add(this.lbl_CFactory);
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Controls.Add(this.pictureBox4);
			this.panel2.Controls.Add(this.pictureBox5);
			this.panel2.Controls.Add(this.lbl_SubTitle2);
			this.panel2.Controls.Add(this.pictureBox6);
			this.panel2.Controls.Add(this.pictureBox7);
			this.panel2.Controls.Add(this.pictureBox8);
			this.panel2.Controls.Add(this.pictureBox9);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("굴림", 9F);
			this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(320, 66);
			this.panel2.TabIndex = 18;
			// 
			// cmb_CBomCd
			// 
			this.cmb_CBomCd.AddItemCols = 0;
			this.cmb_CBomCd.AddItemSeparator = ';';
			this.cmb_CBomCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_CBomCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_CBomCd.Caption = "";
			this.cmb_CBomCd.CaptionHeight = 17;
			this.cmb_CBomCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_CBomCd.ColumnCaptionHeight = 18;
			this.cmb_CBomCd.ColumnFooterHeight = 18;
			this.cmb_CBomCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_CBomCd.ContentHeight = 17;
			this.cmb_CBomCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_CBomCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_CBomCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_CBomCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_CBomCd.EditorHeight = 17;
			this.cmb_CBomCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_CBomCd.GapHeight = 2;
			this.cmb_CBomCd.ItemHeight = 15;
			this.cmb_CBomCd.Location = new System.Drawing.Point(111, 36);
			this.cmb_CBomCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_CBomCd.MaxDropDownItems = ((short)(5));
			this.cmb_CBomCd.MaxLength = 32767;
			this.cmb_CBomCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_CBomCd.Name = "cmb_CBomCd";
			this.cmb_CBomCd.PartialRightColumn = false;
			this.cmb_CBomCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_CBomCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_CBomCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_CBomCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_CBomCd.Size = new System.Drawing.Size(180, 21);
			this.cmb_CBomCd.TabIndex = 214;
			this.cmb_CBomCd.SelectedValueChanged += new System.EventHandler(this.cmb_CBomCd_SelectedValueChanged);
			// 
			// btn_CSearch
			// 
			this.btn_CSearch.BackColor = System.Drawing.SystemColors.Control;
			this.btn_CSearch.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.btn_CSearch.ImageIndex = 0;
			this.btn_CSearch.ImageList = this.img_MiniButton;
			this.btn_CSearch.Location = new System.Drawing.Point(292, 36);
			this.btn_CSearch.Name = "btn_CSearch";
			this.btn_CSearch.Size = new System.Drawing.Size(21, 21);
			this.btn_CSearch.TabIndex = 213;
			this.btn_CSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_CSearch.Click += new System.EventHandler(this.btn_CSearch_Click);
			this.btn_CSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_CSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// lbl_CFactory
			// 
			this.lbl_CFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_CFactory.ImageIndex = 0;
			this.lbl_CFactory.ImageList = this.img_Label;
			this.lbl_CFactory.Location = new System.Drawing.Point(10, 36);
			this.lbl_CFactory.Name = "lbl_CFactory";
			this.lbl_CFactory.Size = new System.Drawing.Size(100, 21);
			this.lbl_CFactory.TabIndex = 210;
			this.lbl_CFactory.Text = "BOM Code";
			this.lbl_CFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(152, 32);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(153, 19);
			this.pictureBox2.TabIndex = 208;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(303, 27);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(24, 26);
			this.pictureBox3.TabIndex = 26;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(304, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(16, 32);
			this.pictureBox4.TabIndex = 21;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(224, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(96, 32);
			this.pictureBox5.TabIndex = 0;
			this.pictureBox5.TabStop = false;
			// 
			// lbl_SubTitle2
			// 
			this.lbl_SubTitle2.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle2.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle2.Image")));
			this.lbl_SubTitle2.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle2.Name = "lbl_SubTitle2";
			this.lbl_SubTitle2.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle2.TabIndex = 28;
			this.lbl_SubTitle2.Text = "      Copy BOM";
			this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(304, 51);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(16, 16);
			this.pictureBox6.TabIndex = 23;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(144, 50);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(160, 18);
			this.pictureBox7.TabIndex = 24;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(0, 51);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(168, 20);
			this.pictureBox8.TabIndex = 22;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(0, 24);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(168, 33);
			this.pictureBox9.TabIndex = 25;
			this.pictureBox9.TabStop = false;
			// 
			// fgrid_CopyBOM
			// 
			this.fgrid_CopyBOM.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_CopyBOM.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_CopyBOM.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_CopyBOM.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_CopyBOM.Location = new System.Drawing.Point(368, 120);
			this.fgrid_CopyBOM.Name = "fgrid_CopyBOM";
			this.fgrid_CopyBOM.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_CopyBOM.Size = new System.Drawing.Size(320, 340);
			this.fgrid_CopyBOM.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Fixed{BackColor:Control;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_CopyBOM.TabIndex = 210;
			// 
			// btn_One
			// 
			this.btn_One.BackColor = System.Drawing.SystemColors.Control;
			this.btn_One.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.btn_One.ImageIndex = 0;
			this.btn_One.ImageList = this.img_Move;
			this.btn_One.Location = new System.Drawing.Point(333, 240);
			this.btn_One.Name = "btn_One";
			this.btn_One.Size = new System.Drawing.Size(30, 30);
			this.btn_One.TabIndex = 213;
			this.btn_One.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_One.Click += new System.EventHandler(this.btn_One_Click);
			this.btn_One.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_One_MouseUp);
			this.btn_One.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_One_MouseDown);
			// 
			// img_Move
			// 
			this.img_Move.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Move.ImageSize = new System.Drawing.Size(32, 32);
			this.img_Move.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Move.ImageStream")));
			this.img_Move.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_Group
			// 
			this.btn_Group.BackColor = System.Drawing.SystemColors.Control;
			this.btn_Group.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.btn_Group.ImageIndex = 2;
			this.btn_Group.ImageList = this.img_Move;
			this.btn_Group.Location = new System.Drawing.Point(333, 272);
			this.btn_Group.Name = "btn_Group";
			this.btn_Group.Size = new System.Drawing.Size(30, 30);
			this.btn_Group.TabIndex = 214;
			this.btn_Group.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Group.Click += new System.EventHandler(this.btn_Group_Click);
			this.btn_Group.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Group_MouseUp);
			this.btn_Group.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Group_MouseDown);
			// 
			// img_Tree
			// 
			this.img_Tree.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Tree.ImageSize = new System.Drawing.Size(27, 16);
			this.img_Tree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Tree.ImageStream")));
			this.img_Tree.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// img_Action
			// 
			this.img_Action.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Action.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pnl_LOBodyLeftTop
			// 
			this.pnl_LOBodyLeftTop.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_LOBodyLeftTop.Controls.Add(this.panel5);
			this.pnl_LOBodyLeftTop.DockPadding.Bottom = 8;
			this.pnl_LOBodyLeftTop.Location = new System.Drawing.Point(8, 46);
			this.pnl_LOBodyLeftTop.Name = "pnl_LOBodyLeftTop";
			this.pnl_LOBodyLeftTop.Size = new System.Drawing.Size(320, 74);
			this.pnl_LOBodyLeftTop.TabIndex = 216;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.Window;
			this.panel5.Controls.Add(this.cmb_OBomCd);
			this.panel5.Controls.Add(this.lbl_OBomCd);
			this.panel5.Controls.Add(this.btn_OSearch);
			this.panel5.Controls.Add(this.pictureBox1);
			this.panel5.Controls.Add(this.pictureBox10);
			this.panel5.Controls.Add(this.pictureBox11);
			this.panel5.Controls.Add(this.pictureBox12);
			this.panel5.Controls.Add(this.pictureBox13);
			this.panel5.Controls.Add(this.pictureBox14);
			this.panel5.Controls.Add(this.lbl_SubTitle1);
			this.panel5.Controls.Add(this.pictureBox15);
			this.panel5.Controls.Add(this.pictureBox16);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(320, 66);
			this.panel5.TabIndex = 19;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(304, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(20, 26);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(303, 50);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(21, 16);
			this.pictureBox10.TabIndex = 23;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(131, 48);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(320, 18);
			this.pictureBox11.TabIndex = 28;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(303, 0);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(21, 32);
			this.pictureBox12.TabIndex = 21;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(224, 0);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(320, 32);
			this.pictureBox13.TabIndex = 0;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(160, 24);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(320, 26);
			this.pictureBox14.TabIndex = 27;
			this.pictureBox14.TabStop = false;
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
			this.lbl_SubTitle1.Text = "      Original BOM";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox15
			// 
			this.pictureBox15.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(0, 24);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(168, 26);
			this.pictureBox15.TabIndex = 25;
			this.pictureBox15.TabStop = false;
			// 
			// pictureBox16
			// 
			this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox16.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
			this.pictureBox16.Location = new System.Drawing.Point(0, 46);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(168, 20);
			this.pictureBox16.TabIndex = 22;
			this.pictureBox16.TabStop = false;
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.tbtn_Save);
			this.c1CommandHolder1.Commands.Add(this.tbtn_Delete);
			this.c1CommandHolder1.Commands.Add(this.tbtn_New);
			this.c1CommandHolder1.ImageList = this.img_ToolBar;
			this.c1CommandHolder1.ImageTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			this.c1CommandHolder1.LookAndFeel = C1.Win.C1Command.LookAndFeelEnum.Classic;
			this.c1CommandHolder1.Owner = this;
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.ImageIndex = 1;
			this.tbtn_Save.Name = "tbtn_Save";
			this.tbtn_Save.Text = "Save";
			this.tbtn_Save.ToolTipText = "Save";
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// tbtn_Delete
			// 
			this.tbtn_Delete.ImageIndex = 2;
			this.tbtn_Delete.Name = "tbtn_Delete";
			this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
			// 
			// tbtn_New
			// 
			this.tbtn_New.ImageIndex = 0;
			this.tbtn_New.Name = "tbtn_New";
			this.tbtn_New.Text = "Clear";
			this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
			// 
			// img_ToolBar
			// 
			this.img_ToolBar.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_ToolBar.ImageSize = new System.Drawing.Size(30, 30);
			this.img_ToolBar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_ToolBar.ImageStream")));
			this.img_ToolBar.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			this.c1ToolBar1.BackHiColor = System.Drawing.Color.Transparent;
			this.c1ToolBar1.ButtonWidth = 30;
			this.c1ToolBar1.CommandHolder = this.c1CommandHolder1;
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink1);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink2);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink5);
			this.c1ToolBar1.CustomizeOptions = C1.Win.C1Command.CustomizeOptionsFlags.AllowAll;
			this.c1ToolBar1.Location = new System.Drawing.Point(597, 8);
			this.c1ToolBar1.MinButtonSize = 30;
			this.c1ToolBar1.Movable = false;
			this.c1ToolBar1.Name = "c1ToolBar1";
			this.c1ToolBar1.Size = new System.Drawing.Size(90, 30);
			this.c1ToolBar1.Text = "c1ToolBar1";
			// 
			// c1CommandLink1
			// 
			this.c1CommandLink1.Command = this.tbtn_New;
			// 
			// c1CommandLink2
			// 
			this.c1CommandLink2.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Image;
			this.c1CommandLink2.Command = this.tbtn_Save;
			// 
			// c1CommandLink5
			// 
			this.c1CommandLink5.Command = this.tbtn_Delete;
			this.c1CommandLink5.Text = "New Command";
			// 
			// Pop_CreateCopyBom
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 468);
			this.Controls.Add(this.c1ToolBar1);
			this.Controls.Add(this.pnl_LOBodyLeftTop);
			this.Controls.Add(this.btn_Group);
			this.Controls.Add(this.btn_One);
			this.Controls.Add(this.pnl_Copy);
			this.Controls.Add(this.fgrid_CopyBOM);
			this.Controls.Add(this.fgrid_OrgBOM);
			this.Name = "Pop_CreateCopyBom";
			this.Text = "Copy BOM";
			this.Load += new System.EventHandler(this.Pop_CreateCopyBom_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.fgrid_OrgBOM, 0);
			this.Controls.SetChildIndex(this.fgrid_CopyBOM, 0);
			this.Controls.SetChildIndex(this.pnl_Copy, 0);
			this.Controls.SetChildIndex(this.btn_One, 0);
			this.Controls.SetChildIndex(this.btn_Group, 0);
			this.Controls.SetChildIndex(this.pnl_LOBodyLeftTop, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_OrgBOM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBomCd)).EndInit();
			this.pnl_Copy.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_CBomCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_CopyBOM)).EndInit();
			this.pnl_LOBodyLeftTop.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		
		#region 변수 정의 

		private COM.OraDB MyOraDB = new COM.OraDB();
		private Hashtable _ImgTree = new Hashtable(); 
 
		//콤보박스 바꿀때 초기 맨 처음에는 메시지 박스 안나오도록 하기 위함
		private static bool _FirstFormLoad = false;

		private string _Factory, _CopyBomCd;
		
		private string _Root_UpCmpCd = "-1";


		#endregion 

		#region 멤버 메서드

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			 
			//Title
			this.Text = "Copy BOM";
			this.lbl_MainTitle.Text = "Copy BOM";
			ClassLib.ComFunction.SetLangDic(this);


			_FirstFormLoad = true;
			_Factory = ClassLib.ComVar.Parameter_PopUp[0];  
			_CopyBomCd = ClassLib.ComVar.Parameter_PopUp[1];
 
			fgrid_OrgBOM.Set_Grid("STANDARD_BOM", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForSearch, true); 
			fgrid_OrgBOM.ExtendLastCol = true;
			fgrid_OrgBOM.Tree.Column = 1;  
			fgrid_OrgBOM.SelectionMode = SelectionModeEnum.Row; 

			fgrid_CopyBOM.Set_Grid("STANDARD_BOM", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, true); 
			fgrid_CopyBOM.Set_Action_Image(img_Action);  
			fgrid_CopyBOM.ExtendLastCol = true;
			fgrid_CopyBOM.Tree.Column = 1;   
			
			//BOM 코드 콤보박스 리스트
			Set_Combo_BOM();

			cmb_CBomCd.Enabled = false;


		}


		/// <summary>
		/// Set_Combo_BOM : BOM 코드 콤보박스 리스트
		/// </summary>
		private void Set_Combo_BOM()
		{
			DataTable dt_ret;
			
			try
			{   
				fgrid_OrgBOM.Rows.Count = fgrid_OrgBOM.Rows.Fixed;
				fgrid_CopyBOM.Rows.Count = fgrid_CopyBOM.Rows.Fixed;

				dt_ret = Select_BomCd_CmbList();
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OBomCd, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code); 
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_CBomCd, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code); 

				//cmb_OBomCd.SelectedValue = ClassLib.ComVar.FactoryBomCd;

				cmb_OBomCd.SelectedIndex = 0;
				cmb_CBomCd.SelectedValue = _CopyBomCd;

			}
			catch
			{
			}
		}


		/// <summary>
		/// Close_Form : Form Close 시 작업
		/// </summary>
		private void Close_Form()
		{
			this.Close();
		}

		/// <summary>
		/// Display_Tree : 그리드에 트리 형태로 데이터 구현
		/// </summary>
		/// <param name="arg_dt">트리로 적용될 데이터테이블</param>
		private void Display_Tree(DataTable arg_dt, COM.FSP arg_fgrid)
		{
			int row_fixed = arg_fgrid.Rows.Fixed; 
			arg_fgrid.Tree.Column = 1; 
			arg_fgrid.Rows.Count = row_fixed;
  
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_fgrid.Rows.InsertNode(i + row_fixed, Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_BOM.IxCMP_LEVEL - 1].ToString()) - 1);

				arg_fgrid[i + row_fixed, 0] = "";

				for(int j = 1; j < arg_fgrid.Cols.Count; j++)
				{
					arg_fgrid[i + row_fixed, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
				} 
 
			}
	    
			Set_Tree_Img(arg_fgrid); 

			arg_fgrid.Tree.Style = TreeStyleFlags.Complete; 
			arg_fgrid.AutoSizeCols();
			 
		}


		/// <summary>
		/// Set_Tree_Img : CMP Type 에 따라 그리드 트리에 이미지 표시
		/// </summary>
		private void Set_Tree_Img(COM.FSP arg_fgrid)
		{ 
			_ImgTree.Clear();

			_ImgTree.Add("SG", img_Tree.Images[0]);
			_ImgTree.Add("TY", img_Tree.Images[1]);
			_ImgTree.Add("GP", img_Tree.Images[2]);
			_ImgTree.Add("BM", img_Tree.Images[3]);  
			
			arg_fgrid.Cols[(int)ClassLib.TBSPB_BOM.IxCMP_TYPE].Clear(ClearFlags.Style); 
			arg_fgrid.Cols[(int)ClassLib.TBSPB_BOM.IxCMP_TYPE].ImageAndText = false; 
			arg_fgrid.Cols[(int)ClassLib.TBSPB_BOM.IxCMP_TYPE].ImageMap = _ImgTree;  
 
 
		}

		/// <summary>
		/// Insert_CmpCd : Copy BOM으로 CmpCode 이동
		/// </summary>
		/// <param name="arg_row">선택된(시작) 행</param>
		/// <returns>상위 코드 없는 경우만 true, 중복되더라도 다음 행 작업위해서 false</returns>
		private bool Insert_CmpCd(int arg_row)
		{
			try
			{ 
				int find_up_row = 0;
				int insert_row = 0;

				string cmp = "", up_cmp = ""; 
				int my_level = 0; 
				bool exist_flag = false;

				cmp = fgrid_OrgBOM[arg_row, (int)ClassLib.TBSPB_BOM.IxCMP_CD].ToString();
				up_cmp = fgrid_OrgBOM[arg_row, (int)ClassLib.TBSPB_BOM.IxUP_CMP_CD].ToString();
				my_level = Convert.ToInt32(fgrid_OrgBOM[arg_row, (int)ClassLib.TBSPB_BOM.IxCMP_LEVEL].ToString() );

				//-------------------------------------------------
				//코드 중복 여부 체크
				exist_flag = Check_ExistCode(cmp); 
				if (exist_flag) return false; 
				//-------------------------------------------------
 
				if (up_cmp != _Root_UpCmpCd)
				{
					find_up_row = fgrid_CopyBOM.FindRow(up_cmp, fgrid_CopyBOM.Rows.Fixed, (int)ClassLib.TBSPB_BOM.IxCMP_CD, false, true, false);

					//상위 코드 없으므로 옮길 수 없음
					if (find_up_row == -1) 
					{
						//COM.ComFunction.Data_Message("UP Component", ClassLib.ComVar.MgsNotnoHaveData, this);
						return true;
					}


					insert_row = Get_Insert_Row(up_cmp, my_level, find_up_row); 

				} 
				else
				{
					insert_row = fgrid_CopyBOM.Rows.Count; 
				}


				fgrid_CopyBOM.Rows.InsertNode(insert_row, my_level - 1);
				fgrid_CopyBOM[insert_row, 0] = "I";

				for(int i = 1; i < fgrid_CopyBOM.Cols.Count; i++)
				{
					fgrid_CopyBOM[insert_row, i] = fgrid_OrgBOM[arg_row, i].ToString();
				}

				fgrid_CopyBOM.AutoSizeCols();

				return false; 

			}
			catch
			{
				return true;
			}

		}


		/// <summary>
		/// Check_ExistCode : 코드 중복 여부 체크
		/// </summary>
		/// <param name="arg_cmpcd">옮길 코드</param>
		/// <returns></returns>
		private bool Check_ExistCode(string arg_cmpcd)
		{
			int findrow = 0;

			findrow = fgrid_CopyBOM.FindRow(arg_cmpcd, fgrid_CopyBOM.Rows.Fixed, (int)ClassLib.TBSPB_BOM.IxCMP_CD, false, true, false);

			if (findrow == -1)
				return false;     //코드 중복 아님
			else
				return true;      //코드 중복
		}


		/// <summary>
		/// Get_Insert_Row : 상위 코드의 Row로 부터 현재 옮기고자 하는 코드의 Insert Row 값 구하기
		/// </summary>
		/// <param name="arg_upcmp">옮길 코드의 상위코드</param>
		/// <param name="arg_mylevel">옮길 코드의 레벨</param>
		/// <param name="arg_uprow">옮길 코드의 상위코드 행값</param>
		/// <returns></returns>
		private int Get_Insert_Row(string arg_upcmp, int arg_mylevel, int arg_uprow)
		{
			int insert_row = 0;

			for(int i = arg_uprow; i < fgrid_CopyBOM.Rows.Count; i++)
			{
				if(arg_mylevel > Convert.ToInt32(fgrid_CopyBOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_LEVEL].ToString() ) )
				{
					insert_row = i + 1;
					break;
				} 
			} // end for i

			
			if (insert_row == 0) insert_row = fgrid_CopyBOM.Rows.Count;

			return insert_row;

		}

		/// <summary>
		/// Delete_CmpCd : 복사된 품목 코드 삭제
		/// </summary>
		/// <param name="arg_startrow"></param>
		/// <param name="arg_endrow"></param>
		private void Delete_CmpCd(int arg_startrow, int arg_endrow)
		{
			for(int i = arg_endrow; i >= arg_startrow; i--)
			{
				switch (fgrid_CopyBOM[i, 0].ToString())
				{
					case "I":
						fgrid_CopyBOM.Rows.Remove(i);
						break;

					default:
						fgrid_CopyBOM[i, 0] = "D"; 
						tbtn_Save_Click(null, null);
						break;
				}
				
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

		private void btn_One_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_One.ImageIndex = 1;
		}

		private void btn_One_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_One.ImageIndex = 0;
		}

		private void btn_Group_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Group.ImageIndex = 3;
		}

		private void btn_Group_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Group.ImageIndex = 2;
		}

 
		private void cmb_OBomCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			dt_ret = Select_SPB_BOM(cmb_OBomCd.SelectedValue.ToString());
			Display_Tree(dt_ret, fgrid_OrgBOM);
 

		}

		private void cmb_CBomCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_CBomCd.SelectedIndex == -1) return;

				dt_ret = Select_SPB_BOM(cmb_CBomCd.SelectedValue.ToString());
				Display_Tree(dt_ret, fgrid_CopyBOM);

			}
			catch
			{
			}

		}

		private void btn_OSearch_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_OBomCd.SelectedIndex == -1) return;

				dt_ret = Select_SPB_BOM(cmb_OBomCd.SelectedValue.ToString());
				Display_Tree(dt_ret, fgrid_OrgBOM);

			}
			catch
			{
			}
		}

		private void btn_CSearch_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_CBomCd.SelectedIndex == -1) return;

				dt_ret = Select_SPB_BOM(cmb_CBomCd.SelectedValue.ToString());
				Display_Tree(dt_ret, fgrid_CopyBOM);

			}
			catch
			{
			}
		}

		private void btn_One_Click(object sender, System.EventArgs e)
		{ 
			Insert_CmpCd(fgrid_OrgBOM.Selection.r1); 
		}

		private void btn_Group_Click(object sender, System.EventArgs e)
		{
			try
			{
				int start_row = fgrid_OrgBOM.Selection.r1; 
				int end_row = 0;
				int my_level = 0; 
				bool error_flag = false;
 
				//-------------------------------------------------
				//그룹으로 옮길 마지막 행 계산
				my_level = Convert.ToInt32(fgrid_OrgBOM[start_row, (int)ClassLib.TBSPB_BOM.IxCMP_LEVEL].ToString() );

				for(int i = start_row + 1; i < fgrid_OrgBOM.Rows.Count; i++)
				{
					if(my_level >= Convert.ToInt32(fgrid_OrgBOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_LEVEL].ToString() ) )
					{
						end_row = i - 1;
						break;
					} 
				}  
			
				if (end_row == 0) end_row = fgrid_OrgBOM.Rows.Count - 1;
				//-------------------------------------------------
	
				for(int i = start_row; i <= end_row; i++) 
				{
					error_flag = Insert_CmpCd(i); 
					if(error_flag) break;
				}

			}
			catch
			{
			}

		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{ 
			fgrid_CopyBOM.Rows.Count = fgrid_CopyBOM.Rows.Fixed; 
		}


		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				int start_row = fgrid_CopyBOM.Selection.r1; 
				int end_row = 0;
				int my_level = 0; 

				DialogResult message_result;  
 
				//-------------------------------------------------
				//그룹 마지막 행 계산
				my_level = Convert.ToInt32(fgrid_CopyBOM[start_row, (int)ClassLib.TBSPB_BOM.IxCMP_LEVEL].ToString() );

				for(int i = start_row + 1; i < fgrid_CopyBOM.Rows.Count; i++)
				{
					if(my_level >= Convert.ToInt32(fgrid_CopyBOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_LEVEL].ToString() ) )
					{
						end_row = i - 1;
						break;
					} 
				}  
			
				if (end_row == 0) end_row = fgrid_CopyBOM.Rows.Count - 1;
				//-------------------------------------------------
	
				//-------------------------------------------------
				//메시지 표준안 적용 안함
				//삭제 여부  
//				if(start_row == end_row) 
//					del_string = "삭제하시겠습니까?";
//				else
//					del_string = "하위 품목까지 삭제됩니다." + "\r\n\r\n" + "삭제하시겠습니까?";
//
//				message_result = MessageBox.Show(del_string, "", MessageBoxButtons.YesNo);

				message_result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete, this);

				if(message_result == DialogResult.No) return; 

				//품목코드 삭제
				Delete_CmpCd(start_row, end_row);
				 

			}
			catch
			{
			}

		}  
		
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_ret;

			try
			{
				Save_SPB_BOM();
				Save_SPB_BOM_COPY();  

				MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행

				dt_ret = Select_SPB_BOM(cmb_CBomCd.SelectedValue.ToString());
				Display_Tree(dt_ret, fgrid_CopyBOM);
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"tbtn_Save_Click",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
			} 
		}


		#endregion 

		#region DB Connect
 
		/// <summary>
		/// Select_BomCd_CmbList : BOM Code Combo List 찾기
		/// </summary>
		private DataTable Select_BomCd_CmbList()
		{
		 
			DataSet ds_ret;
			string process_name = "PKG_SPB_BOM.SELECT_SPB_BOM_CD";

			MyOraDB.ReDim_Parameter(2); 
 
			MyOraDB.Process_Name = process_name;
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
			MyOraDB.Parameter_Values[0] = _Factory; 
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
		} 


		/// <summary>
		/// Select_SPB_BOM : BOM Data Search
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SPB_BOM(string arg_bomcd)
		{
			
			DataSet ds_ret;
			string process_name = "PKG_SPB_BOM.SELECT_STDBOM_LIST";

			MyOraDB.ReDim_Parameter(3); 
 
			MyOraDB.Process_Name = process_name;
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
			MyOraDB.Parameter_Values[0] = _Factory; 
			MyOraDB.Parameter_Values[1] = arg_bomcd; 
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
 
		} 

		/// <summary>
		/// Save_SPB_BOM : SPB_BOM 저장
		/// </summary>
		private void Save_SPB_BOM()
		{
			int col_ct = 13;		 
			int row_fixed = fgrid_CopyBOM.Rows.Fixed;	// 그리드 고정행 값
			int save_ct =0 ;							// 저장 행 수
 
			int para_ct =0;								// 파라미터 값의 저장 배열의 수 

			try
			{
			 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPB_BOM.SAVE_SPB_BOM";
 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_BOM_CD"; 
				for(int i = 1; i < fgrid_CopyBOM.Cols.Count; i++) 
				{
					MyOraDB.Parameter_Name[i + 2] = "ARG_" + fgrid_CopyBOM[0, i].ToString(); 
				}
				MyOraDB.Parameter_Name[12] = "ARG_UPD_USER";
  
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}
	
				// 저장 행 수 구하기
				for(int i = row_fixed ; i < fgrid_CopyBOM.Rows.Count; i++)
				{
					if(fgrid_CopyBOM[i, 0].ToString() != "")
					{
						save_ct += 1;
					}
				}
			
				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[col_ct * save_ct ];


				// 각 행의 변경값 Setting
				for(int row = row_fixed; row < fgrid_CopyBOM.Rows.Count ; row++)
				{
					if(fgrid_CopyBOM[row, 0].ToString() != "")
					{ 
						MyOraDB.Parameter_Values[para_ct + 0] = fgrid_CopyBOM[row, 0].ToString();
						MyOraDB.Parameter_Values[para_ct + 1] = _Factory;
						MyOraDB.Parameter_Values[para_ct + 2] = cmb_CBomCd.SelectedValue.ToString();

						for(int col = 1; col < fgrid_CopyBOM.Cols.Count ; col++)	 
						{  
							MyOraDB.Parameter_Values[para_ct + 2 + col] = (fgrid_CopyBOM[row, col] == null) ? "" : fgrid_CopyBOM[row, col].ToString();
						} 

						MyOraDB.Parameter_Values[para_ct + 12] = ClassLib.ComVar.This_User; 
						para_ct += col_ct; 
					}

				} //end for


				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_SPB_BOM",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
			}

		}
			 

		/// <summary>
		/// Save_SPB_BOM_COPY : addflow table 저장 (SPB_NODE_BOM)
		/// </summary>
		private void Save_SPB_BOM_COPY()
		{
			int col_ct = 6;		 
			int row_fixed = fgrid_CopyBOM.Rows.Fixed;		// 그리드 고정행 값
			int save_ct =0 ;							// 저장 행 수
 
			int para_ct =0;								// 파라미터 값의 저장 배열의 수 

			bool first = true;
			string division = "";
 
			try
			{
			 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPB_BOM.SAVE_SPB_BOM_COPY";
 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_ORG_BOM_CD";
				MyOraDB.Parameter_Name[3] = "ARG_COPY_BOM_CD";
				MyOraDB.Parameter_Name[4] = "ARG_CMP_CD";   
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";

				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}
	
				// 저장 행 수 구하기
				for(int i = row_fixed ; i < fgrid_CopyBOM.Rows.Count; i++)
				{
					if(fgrid_CopyBOM[i, 0].ToString() != "")
					{
						save_ct += 1;
					}
				}
			
				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[col_ct * save_ct ];


				// 각 행의 변경값 Setting
				for(int row = row_fixed; row < fgrid_CopyBOM.Rows.Count ; row++)
				{
					if(fgrid_CopyBOM[row, 0].ToString() != "")
					{ 
						if(first) 
						{
							division = fgrid_CopyBOM[row, 0].ToString() + "Y";
							first = false;
						}
						else
						{
							division = fgrid_CopyBOM[row, 0].ToString() + "N";
						}

						MyOraDB.Parameter_Values[para_ct + 0] = division;
						MyOraDB.Parameter_Values[para_ct + 1] = _Factory;
						MyOraDB.Parameter_Values[para_ct + 2] = ClassLib.ComFunction.Empty_Combo(cmb_OBomCd, " ");
						MyOraDB.Parameter_Values[para_ct + 3] = cmb_CBomCd.SelectedValue.ToString();
						MyOraDB.Parameter_Values[para_ct + 4] = fgrid_CopyBOM[row, (int)ClassLib.TBSPB_BOM.IxCMP_CD].ToString();
						MyOraDB.Parameter_Values[para_ct + 5] = ClassLib.ComVar.This_User; 
						para_ct += col_ct; 
					}

				} //end for


				MyOraDB.Add_Modify_Parameter(false);		 
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_SPB_NODE_BOM_COPY",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
			}

		}

 
		#endregion


		private void Pop_CreateCopyBom_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

 

	}
}

