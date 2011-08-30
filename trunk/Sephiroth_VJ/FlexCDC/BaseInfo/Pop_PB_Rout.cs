using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 
using Lassalle.Flow;

namespace FlexCDC.BaseInfo
{ 
	public class Pop_PB_Rout : COM.APSWinForm.Pop_Large
	{
		
		#region 컨트롤 정의 및 리소스 정리 

		private System.Windows.Forms.Panel pnl_BodyLeft;
		public System.Windows.Forms.Panel panel14;
		public System.Windows.Forms.Panel panel15;
		public System.Windows.Forms.PictureBox pictureBox50;
		public System.Windows.Forms.PictureBox pictureBox51;
		public System.Windows.Forms.PictureBox pictureBox52;
		public System.Windows.Forms.PictureBox pictureBox53;
		public System.Windows.Forms.PictureBox pictureBox54;
		public System.Windows.Forms.PictureBox pictureBox55;
		public System.Windows.Forms.PictureBox pictureBox56;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox pictureBox57;
		private System.Windows.Forms.Label lbl_RoutType;
		private C1.Win.C1List.C1Combo cmb_CmpCd;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private C1.Win.C1List.C1Combo cmb_RoutType;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label lbl_CmpCd;
		private System.Windows.Forms.ImageList img_SmallLabel;
		private Lassalle.Flow.AddFlow addflow_StdRout;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.Label btn_Return;
		private System.Windows.Forms.Label btn_Close;
		public COM.FSP fgrid_Rout;
		public COM.FSP fgrid_LinkDef;
		public COM.FSP fgrid_NodeDef;
		public COM.FSP fgrid_LinkRout;
		public COM.FSP fgrid_NodeRout;
		private System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.ContextMenu cmenu_StdRout;
		private System.Windows.Forms.MenuItem menuItem_Add;
		private System.Windows.Forms.MenuItem menuItem_Update;
		private System.Windows.Forms.MenuItem menuItem_Delete;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem_NodeProp;
		private System.Windows.Forms.MenuItem menuItem_LinkProp;
		private System.Windows.Forms.Label btn_CreateCd;
		private System.Windows.Forms.Label btn_Refresh;
		private System.Windows.Forms.ImageList img_Action;
		private System.ComponentModel.IContainer components = null;

		public Pop_PB_Rout()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PB_Rout));
			this.pnl_BodyLeft = new System.Windows.Forms.Panel();
			this.panel14 = new System.Windows.Forms.Panel();
			this.panel15 = new System.Windows.Forms.Panel();
			this.btn_CreateCd = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.btn_Return = new System.Windows.Forms.Label();
			this.lbl_RoutType = new System.Windows.Forms.Label();
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			this.cmb_CmpCd = new C1.Win.C1List.C1Combo();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.cmb_RoutType = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.lbl_CmpCd = new System.Windows.Forms.Label();
			this.pictureBox50 = new System.Windows.Forms.PictureBox();
			this.pictureBox51 = new System.Windows.Forms.PictureBox();
			this.pictureBox52 = new System.Windows.Forms.PictureBox();
			this.pictureBox53 = new System.Windows.Forms.PictureBox();
			this.pictureBox54 = new System.Windows.Forms.PictureBox();
			this.pictureBox55 = new System.Windows.Forms.PictureBox();
			this.pictureBox56 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox57 = new System.Windows.Forms.PictureBox();
			this.addflow_StdRout = new Lassalle.Flow.AddFlow();
			this.cmenu_StdRout = new System.Windows.Forms.ContextMenu();
			this.menuItem_Add = new System.Windows.Forms.MenuItem();
			this.menuItem_Update = new System.Windows.Forms.MenuItem();
			this.menuItem_Delete = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem_NodeProp = new System.Windows.Forms.MenuItem();
			this.menuItem_LinkProp = new System.Windows.Forms.MenuItem();
			this.btn_Close = new System.Windows.Forms.Label();
			this.btn_Apply = new System.Windows.Forms.Label();
			this.fgrid_Rout = new COM.FSP();
			this.fgrid_LinkDef = new COM.FSP();
			this.fgrid_NodeDef = new COM.FSP();
			this.fgrid_LinkRout = new COM.FSP();
			this.fgrid_NodeRout = new COM.FSP();
			this.btn_Refresh = new System.Windows.Forms.Label();
			this.img_Action = new System.Windows.Forms.ImageList(this.components);
			this.pnl_BodyLeft.SuspendLayout();
			this.panel14.SuspendLayout();
			this.panel15.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_CmpCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_RoutType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Rout)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LinkDef)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_NodeDef)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LinkRout)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_NodeRout)).BeginInit();
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
			this.lbl_MainTitle.Text = "Component Routing";
			// 
			// pnl_BodyLeft
			// 
			this.pnl_BodyLeft.BackColor = System.Drawing.Color.Transparent;
			this.pnl_BodyLeft.Controls.Add(this.panel14);
			this.pnl_BodyLeft.DockPadding.Bottom = 5;
			this.pnl_BodyLeft.DockPadding.Left = 6;
			this.pnl_BodyLeft.DockPadding.Right = 6;
			this.pnl_BodyLeft.Location = new System.Drawing.Point(0, 46);
			this.pnl_BodyLeft.Name = "pnl_BodyLeft";
			this.pnl_BodyLeft.Size = new System.Drawing.Size(696, 70);
			this.pnl_BodyLeft.TabIndex = 26;
			// 
			// panel14
			// 
			this.panel14.Controls.Add(this.panel15);
			this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel14.Location = new System.Drawing.Point(6, 0);
			this.panel14.Name = "panel14";
			this.panel14.Size = new System.Drawing.Size(684, 65);
			this.panel14.TabIndex = 20;
			// 
			// panel15
			// 
			this.panel15.BackColor = System.Drawing.SystemColors.Window;
			this.panel15.Controls.Add(this.btn_CreateCd);
			this.panel15.Controls.Add(this.btn_Return);
			this.panel15.Controls.Add(this.lbl_RoutType);
			this.panel15.Controls.Add(this.cmb_CmpCd);
			this.panel15.Controls.Add(this.cmb_Factory);
			this.panel15.Controls.Add(this.cmb_RoutType);
			this.panel15.Controls.Add(this.lbl_Factory);
			this.panel15.Controls.Add(this.lbl_CmpCd);
			this.panel15.Controls.Add(this.pictureBox50);
			this.panel15.Controls.Add(this.pictureBox51);
			this.panel15.Controls.Add(this.pictureBox52);
			this.panel15.Controls.Add(this.pictureBox53);
			this.panel15.Controls.Add(this.pictureBox54);
			this.panel15.Controls.Add(this.pictureBox55);
			this.panel15.Controls.Add(this.pictureBox56);
			this.panel15.Controls.Add(this.lbl_SubTitle1);
			this.panel15.Controls.Add(this.pictureBox57);
			this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel15.Location = new System.Drawing.Point(0, 0);
			this.panel15.Name = "panel15";
			this.panel15.Size = new System.Drawing.Size(684, 65);
			this.panel15.TabIndex = 19;
			// 
			// btn_CreateCd
			// 
			this.btn_CreateCd.ImageIndex = 2;
			this.btn_CreateCd.ImageList = this.img_MiniButton;
			this.btn_CreateCd.Location = new System.Drawing.Point(626, 36);
			this.btn_CreateCd.Name = "btn_CreateCd";
			this.btn_CreateCd.Size = new System.Drawing.Size(21, 21);
			this.btn_CreateCd.TabIndex = 104;
			this.btn_CreateCd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_CreateCd.Click += new System.EventHandler(this.btn_CreateCd_Click);
			this.btn_CreateCd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_CreateCd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_Return
			// 
			this.btn_Return.ImageIndex = 0;
			this.btn_Return.ImageList = this.img_MiniButton;
			this.btn_Return.Location = new System.Drawing.Point(648, 36);
			this.btn_Return.Name = "btn_Return";
			this.btn_Return.Size = new System.Drawing.Size(21, 21);
			this.btn_Return.TabIndex = 103;
			this.btn_Return.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Return.Visible = false;
			this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
			this.btn_Return.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Return.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// lbl_RoutType
			// 
			this.lbl_RoutType.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_RoutType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_RoutType.ImageIndex = 0;
			this.lbl_RoutType.ImageList = this.img_SmallLabel;
			this.lbl_RoutType.Location = new System.Drawing.Point(424, 36);
			this.lbl_RoutType.Name = "lbl_RoutType";
			this.lbl_RoutType.Size = new System.Drawing.Size(50, 21);
			this.lbl_RoutType.TabIndex = 31;
			this.lbl_RoutType.Text = "Type";
			this.lbl_RoutType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// cmb_CmpCd
			// 
			this.cmb_CmpCd.AddItemCols = 0;
			this.cmb_CmpCd.AddItemSeparator = ';';
			this.cmb_CmpCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_CmpCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_CmpCd.Caption = "";
			this.cmb_CmpCd.CaptionHeight = 17;
			this.cmb_CmpCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_CmpCd.ColumnCaptionHeight = 18;
			this.cmb_CmpCd.ColumnFooterHeight = 18;
			this.cmb_CmpCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_CmpCd.ContentHeight = 17;
			this.cmb_CmpCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_CmpCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_CmpCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_CmpCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_CmpCd.EditorHeight = 17;
			this.cmb_CmpCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_CmpCd.GapHeight = 2;
			this.cmb_CmpCd.ItemHeight = 15;
			this.cmb_CmpCd.Location = new System.Drawing.Point(267, 36);
			this.cmb_CmpCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_CmpCd.MaxDropDownItems = ((short)(5));
			this.cmb_CmpCd.MaxLength = 32767;
			this.cmb_CmpCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_CmpCd.Name = "cmb_CmpCd";
			this.cmb_CmpCd.PartialRightColumn = false;
			this.cmb_CmpCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_CmpCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_CmpCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_CmpCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_CmpCd.Size = new System.Drawing.Size(150, 21);
			this.cmb_CmpCd.TabIndex = 30;
			this.cmb_CmpCd.SelectedValueChanged += new System.EventHandler(this.cmb_CmpCd_SelectedValueChanged);
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
			this.cmb_Factory.Enabled = false;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(61, 36);
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
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(150, 21);
			this.cmb_Factory.TabIndex = 14;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// cmb_RoutType
			// 
			this.cmb_RoutType.AddItemCols = 0;
			this.cmb_RoutType.AddItemSeparator = ';';
			this.cmb_RoutType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_RoutType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_RoutType.Caption = "";
			this.cmb_RoutType.CaptionHeight = 17;
			this.cmb_RoutType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_RoutType.ColumnCaptionHeight = 18;
			this.cmb_RoutType.ColumnFooterHeight = 18;
			this.cmb_RoutType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_RoutType.ContentHeight = 17;
			this.cmb_RoutType.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_RoutType.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_RoutType.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_RoutType.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_RoutType.EditorHeight = 17;
			this.cmb_RoutType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_RoutType.GapHeight = 2;
			this.cmb_RoutType.ItemHeight = 15;
			this.cmb_RoutType.Location = new System.Drawing.Point(475, 36);
			this.cmb_RoutType.MatchEntryTimeout = ((long)(2000));
			this.cmb_RoutType.MaxDropDownItems = ((short)(5));
			this.cmb_RoutType.MaxLength = 32767;
			this.cmb_RoutType.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_RoutType.Name = "cmb_RoutType";
			this.cmb_RoutType.PartialRightColumn = false;
			this.cmb_RoutType.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_RoutType.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_RoutType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_RoutType.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_RoutType.Size = new System.Drawing.Size(150, 21);
			this.cmb_RoutType.TabIndex = 32;
			this.cmb_RoutType.SelectedValueChanged += new System.EventHandler(this.cmb_RoutType_SelectedValueChanged);
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_SmallLabel;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(50, 21);
			this.lbl_Factory.TabIndex = 13;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_CmpCd
			// 
			this.lbl_CmpCd.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_CmpCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_CmpCd.ImageIndex = 0;
			this.lbl_CmpCd.ImageList = this.img_SmallLabel;
			this.lbl_CmpCd.Location = new System.Drawing.Point(216, 36);
			this.lbl_CmpCd.Name = "lbl_CmpCd";
			this.lbl_CmpCd.Size = new System.Drawing.Size(50, 21);
			this.lbl_CmpCd.TabIndex = 29;
			this.lbl_CmpCd.Text = "CMP";
			this.lbl_CmpCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox50
			// 
			this.pictureBox50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox50.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox50.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox50.Image")));
			this.pictureBox50.Location = new System.Drawing.Point(0, 45);
			this.pictureBox50.Name = "pictureBox50";
			this.pictureBox50.Size = new System.Drawing.Size(168, 20);
			this.pictureBox50.TabIndex = 22;
			this.pictureBox50.TabStop = false;
			// 
			// pictureBox51
			// 
			this.pictureBox51.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox51.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox51.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox51.Image")));
			this.pictureBox51.Location = new System.Drawing.Point(668, 49);
			this.pictureBox51.Name = "pictureBox51";
			this.pictureBox51.Size = new System.Drawing.Size(16, 16);
			this.pictureBox51.TabIndex = 23;
			this.pictureBox51.TabStop = false;
			// 
			// pictureBox52
			// 
			this.pictureBox52.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox52.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox52.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox52.Image")));
			this.pictureBox52.Location = new System.Drawing.Point(131, 47);
			this.pictureBox52.Name = "pictureBox52";
			this.pictureBox52.Size = new System.Drawing.Size(537, 18);
			this.pictureBox52.TabIndex = 28;
			this.pictureBox52.TabStop = false;
			// 
			// pictureBox53
			// 
			this.pictureBox53.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox53.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox53.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox53.Image")));
			this.pictureBox53.Location = new System.Drawing.Point(669, 24);
			this.pictureBox53.Name = "pictureBox53";
			this.pictureBox53.Size = new System.Drawing.Size(15, 65);
			this.pictureBox53.TabIndex = 26;
			this.pictureBox53.TabStop = false;
			// 
			// pictureBox54
			// 
			this.pictureBox54.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox54.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox54.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox54.Image")));
			this.pictureBox54.Location = new System.Drawing.Point(668, 0);
			this.pictureBox54.Name = "pictureBox54";
			this.pictureBox54.Size = new System.Drawing.Size(16, 32);
			this.pictureBox54.TabIndex = 21;
			this.pictureBox54.TabStop = false;
			// 
			// pictureBox55
			// 
			this.pictureBox55.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox55.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox55.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox55.Image")));
			this.pictureBox55.Location = new System.Drawing.Point(224, 0);
			this.pictureBox55.Name = "pictureBox55";
			this.pictureBox55.Size = new System.Drawing.Size(484, 32);
			this.pictureBox55.TabIndex = 0;
			this.pictureBox55.TabStop = false;
			// 
			// pictureBox56
			// 
			this.pictureBox56.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox56.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox56.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox56.Image")));
			this.pictureBox56.Location = new System.Drawing.Point(160, 24);
			this.pictureBox56.Name = "pictureBox56";
			this.pictureBox56.Size = new System.Drawing.Size(516, 65);
			this.pictureBox56.TabIndex = 27;
			this.pictureBox56.TabStop = false;
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
			this.lbl_SubTitle1.Text = "      Standard Routing";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox57
			// 
			this.pictureBox57.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox57.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox57.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox57.Image")));
			this.pictureBox57.Location = new System.Drawing.Point(0, 24);
			this.pictureBox57.Name = "pictureBox57";
			this.pictureBox57.Size = new System.Drawing.Size(168, 65);
			this.pictureBox57.TabIndex = 25;
			this.pictureBox57.TabStop = false;
			// 
			// addflow_StdRout
			// 
			this.addflow_StdRout.AutoScroll = true;
			this.addflow_StdRout.AutoScrollMinSize = new System.Drawing.Size(614, 442);
			this.addflow_StdRout.BackColor = System.Drawing.SystemColors.Window;
			this.addflow_StdRout.CanDrawNode = false;
			this.addflow_StdRout.ContextMenu = this.cmenu_StdRout;
			this.addflow_StdRout.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.addflow_StdRout.Location = new System.Drawing.Point(232, 116);
			this.addflow_StdRout.Name = "addflow_StdRout";
			this.addflow_StdRout.Size = new System.Drawing.Size(458, 312);
			this.addflow_StdRout.TabIndex = 29;
			this.addflow_StdRout.AfterResize += new Lassalle.Flow.AddFlow.AfterResizeEventHandler(this.addflow_StdRout_AfterResize);
			this.addflow_StdRout.AfterAddLink += new Lassalle.Flow.AddFlow.AfterAddLinkEventHandler(this.addflow_StdRout_AfterAddLink);
			this.addflow_StdRout.AfterMove += new Lassalle.Flow.AddFlow.AfterMoveEventHandler(this.addflow_StdRout_AfterMove);
			// 
			// cmenu_StdRout
			// 
			this.cmenu_StdRout.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						  this.menuItem_Add,
																						  this.menuItem_Update,
																						  this.menuItem_Delete,
																						  this.menuItem1,
																						  this.menuItem_NodeProp,
																						  this.menuItem_LinkProp});
			// 
			// menuItem_Add
			// 
			this.menuItem_Add.Index = 0;
			this.menuItem_Add.Text = "Add";
			this.menuItem_Add.Click += new System.EventHandler(this.menuItem_Add_Click);
			// 
			// menuItem_Update
			// 
			this.menuItem_Update.Index = 1;
			this.menuItem_Update.Text = "Update ";
			this.menuItem_Update.Click += new System.EventHandler(this.menuItem_Update_Click);
			// 
			// menuItem_Delete
			// 
			this.menuItem_Delete.Index = 2;
			this.menuItem_Delete.Text = "Delete";
			this.menuItem_Delete.Click += new System.EventHandler(this.menuItem_Delete_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 3;
			this.menuItem1.Text = "-";
			// 
			// menuItem_NodeProp
			// 
			this.menuItem_NodeProp.Index = 4;
			this.menuItem_NodeProp.Text = "Node Property";
			this.menuItem_NodeProp.Click += new System.EventHandler(this.menuItem_NodeProp_Click);
			// 
			// menuItem_LinkProp
			// 
			this.menuItem_LinkProp.Index = 5;
			this.menuItem_LinkProp.Text = "Link Property";
			this.menuItem_LinkProp.Click += new System.EventHandler(this.menuItem_LinkProp_Click);
			// 
			// btn_Close
			// 
			this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Close.ImageIndex = 0;
			this.btn_Close.ImageList = this.img_Button;
			this.btn_Close.Location = new System.Drawing.Point(619, 438);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(70, 23);
			this.btn_Close.TabIndex = 51;
			this.btn_Close.Text = "Close";
			this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			this.btn_Close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Apply
			// 
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(548, 438);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(70, 23);
			this.btn_Apply.TabIndex = 50;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// fgrid_Rout
			// 
			this.fgrid_Rout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_Rout.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Rout.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Rout.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Rout.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Rout.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Rout.Location = new System.Drawing.Point(8, 116);
			this.fgrid_Rout.Name = "fgrid_Rout";
			this.fgrid_Rout.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Rout.Size = new System.Drawing.Size(224, 312);
			this.fgrid_Rout.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Rout.TabIndex = 52;
			this.fgrid_Rout.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Rout_AfterEdit);
			// 
			// fgrid_LinkDef
			// 
			this.fgrid_LinkDef.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_LinkDef.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_LinkDef.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"link def\";}\t";
			this.fgrid_LinkDef.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_LinkDef.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_LinkDef.Location = new System.Drawing.Point(520, 232);
			this.fgrid_LinkDef.Name = "fgrid_LinkDef";
			this.fgrid_LinkDef.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_LinkDef.Size = new System.Drawing.Size(152, 80);
			this.fgrid_LinkDef.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_LinkDef.TabIndex = 54;
			this.fgrid_LinkDef.Visible = false;
			// 
			// fgrid_NodeDef
			// 
			this.fgrid_NodeDef.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_NodeDef.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_NodeDef.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"node def\";}\t";
			this.fgrid_NodeDef.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_NodeDef.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_NodeDef.Location = new System.Drawing.Point(368, 232);
			this.fgrid_NodeDef.Name = "fgrid_NodeDef";
			this.fgrid_NodeDef.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_NodeDef.Size = new System.Drawing.Size(152, 80);
			this.fgrid_NodeDef.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_NodeDef.TabIndex = 53;
			this.fgrid_NodeDef.Visible = false;
			// 
			// fgrid_LinkRout
			// 
			this.fgrid_LinkRout.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_LinkRout.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_LinkRout.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"link rout\";}\t";
			this.fgrid_LinkRout.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_LinkRout.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_LinkRout.Location = new System.Drawing.Point(520, 312);
			this.fgrid_LinkRout.Name = "fgrid_LinkRout";
			this.fgrid_LinkRout.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_LinkRout.Size = new System.Drawing.Size(152, 80);
			this.fgrid_LinkRout.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_LinkRout.TabIndex = 56;
			this.fgrid_LinkRout.Visible = false;
			// 
			// fgrid_NodeRout
			// 
			this.fgrid_NodeRout.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_NodeRout.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_NodeRout.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"node rout\";}\t";
			this.fgrid_NodeRout.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_NodeRout.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_NodeRout.Location = new System.Drawing.Point(368, 312);
			this.fgrid_NodeRout.Name = "fgrid_NodeRout";
			this.fgrid_NodeRout.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_NodeRout.Size = new System.Drawing.Size(152, 80);
			this.fgrid_NodeRout.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_NodeRout.TabIndex = 55;
			this.fgrid_NodeRout.Visible = false;
			// 
			// btn_Refresh
			// 
			this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Refresh.ImageIndex = 0;
			this.btn_Refresh.ImageList = this.img_Button;
			this.btn_Refresh.Location = new System.Drawing.Point(477, 438);
			this.btn_Refresh.Name = "btn_Refresh";
			this.btn_Refresh.Size = new System.Drawing.Size(70, 23);
			this.btn_Refresh.TabIndex = 57;
			this.btn_Refresh.Text = "Refresh";
			this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
			this.btn_Refresh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Refresh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// img_Action
			// 
			this.img_Action.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Action.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Pop_PB_Rout
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 468);
			this.Controls.Add(this.btn_Refresh);
			this.Controls.Add(this.fgrid_LinkRout);
			this.Controls.Add(this.fgrid_NodeRout);
			this.Controls.Add(this.fgrid_LinkDef);
			this.Controls.Add(this.fgrid_NodeDef);
			this.Controls.Add(this.fgrid_Rout);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.addflow_StdRout);
			this.Controls.Add(this.pnl_BodyLeft);
			this.Name = "Pop_PB_Rout";
			this.Text = "Component Routing";
			this.Load += new System.EventHandler(this.Form_PB_Rout_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.pnl_BodyLeft, 0);
			this.Controls.SetChildIndex(this.addflow_StdRout, 0);
			this.Controls.SetChildIndex(this.btn_Apply, 0);
			this.Controls.SetChildIndex(this.btn_Close, 0);
			this.Controls.SetChildIndex(this.fgrid_Rout, 0);
			this.Controls.SetChildIndex(this.fgrid_NodeDef, 0);
			this.Controls.SetChildIndex(this.fgrid_LinkDef, 0);
			this.Controls.SetChildIndex(this.fgrid_NodeRout, 0);
			this.Controls.SetChildIndex(this.fgrid_LinkRout, 0);
			this.Controls.SetChildIndex(this.btn_Refresh, 0);
			this.pnl_BodyLeft.ResumeLayout(false);
			this.panel14.ResumeLayout(false);
			this.panel15.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_CmpCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_RoutType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Rout)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LinkDef)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_NodeDef)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LinkRout)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_NodeRout)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

 
		#region 변수 정의 

		private COM.OraDB MyOraDB = new COM.OraDB();

		//파라미터로 넘어온 데이터 저장
		private string _Factory, _BomCd, _CmpCd, _RoutType;
		private int _Rowfixed;
		private Lassalle.Flow.Node _AddNode;
		//새로 생기는 노드, 링크 순번, 중복 없애기 위함 
		private int _Node_Index = 0;
		private int _Link_Index = 0;
		//링크 삭제 처리를 저장에서 하지 않고 바로 하기 위해서 플래그 저장
		private bool _Link_Delete; 
		private string _Link_Delete_Org, _Link_Delete_Dst;

		#endregion 

		#region 멤버 메서드


		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{  
			DataTable dt_ret; 

			//Title
			this.Text = "Component Routing";
			this.lbl_MainTitle.Text = "Component Routing";  

			ClassLib.ComFunction.SetLangDic(this);
 

			fgrid_Rout.Set_Grid("STANDARD_ROUT", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
			fgrid_Rout.Set_Action_Image(img_Action);
 			_Rowfixed = fgrid_Rout.Rows.Fixed;

 			fgrid_NodeRout.Set_Grid("NODE_ROUT", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
 			fgrid_LinkRout.Set_Grid("LINK_ROUT", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
 			
			ClassLib.ComFunction.Clear_AddFlow(addflow_StdRout);
  
			dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
			ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 

			//////////////////////////////////////////////////////////////////
			if(ClassLib.ComVar.FormClick_Flag == true)
			{
				btn_Return.Visible = true;

				//라우팅 존재 여부 ClassLib.ComVar.Parameter_PopUp[0]값으로 버튼 활성화, 비활성화 작업

				_Factory = ClassLib.ComVar.Parameter_PopUp[0];
				_BomCd = ClassLib.ComVar.Parameter_PopUp[1];
				_CmpCd = ClassLib.ComVar.Parameter_PopUp[2];
				_RoutType = ClassLib.ComVar.Parameter_PopUp[3];

				cmb_Factory.SelectedValue = _Factory;

			}
			else
			{
				btn_Return.Visible = false;
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
			}

		}

		/// <summary>
		/// Display_Rout_Info : Rout 데이터 표시
		/// </summary>
		private void Display_Rout_Info()
		{
			
			DataSet ds_ret;
			DataTable dt_ret, dt_node, dt_link;

			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_CmpCd.SelectedIndex == -1 || cmb_RoutType.SelectedIndex == -1) return;

				dt_ret = Select_SPB_ROUT();
				Display_Grid(dt_ret, fgrid_Rout);
				ClassLib.ComFunction.Clear_AddFlow(addflow_StdRout);

				ds_ret = Select_SPB_ROUT_NodeLink();
				dt_node = ds_ret.Tables["PKG_SPB_ROUT.SELECT_STDROUT_NODE"];
				dt_link = ds_ret.Tables["PKG_SPB_ROUT.SELECT_STDROUT_LINK"];
				Display_Grid(dt_node, fgrid_NodeRout);
				Display_Node();
				Display_Grid(dt_link, fgrid_LinkRout);
				Display_Link();

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
		/// <summary>
		/// Display_Node : Addflow에 노드 표시
		/// </summary>
		private void Display_Node()
		{
			Lassalle.Flow.Node node;
			_Node_Index = 0;

			for(int i = _Rowfixed; i < fgrid_NodeRout.Rows.Count; i++)
			{ 
				node = new Lassalle.Flow.Node();

				node = addflow_StdRout.Nodes.Add(Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxLEFT].ToString()), 
													Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxTOP].ToString()), 
													Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxWIDTH].ToString()), 
													Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxHEIGHT].ToString()), "");
				node.Text =  fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxTEXT].ToString();
				node.Tooltip = fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxTOOLTIP].ToString();
				node.Tag = fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString(); 
 				
				ClassLib.ComFunction.Set_NodeProp(fgrid_NodeRout, node, i);

				for(int j = _Rowfixed; j < fgrid_Rout.Rows.Count; j++)
				{
					if(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString() == fgrid_Rout[j, (int)ClassLib.TBSPB_ROUT.IxROUT_SEQ].ToString())
					{
						fgrid_Rout[j, (int)ClassLib.TBSPB_ROUT.IxNODE_NO] = _Node_Index;
						break;
					}
				}

				_Node_Index++;
  
			} //end for 
		}

		/// <summary>
		/// Display_Link : Addflow에 링크 표시
		/// </summary>
		private void Display_Link()
		{
			Lassalle.Flow.Link link;
			int max_index = _Link_Index;

			for(int i = _Rowfixed; i < fgrid_LinkRout.Rows.Count; i++)
			{ 
				link = new Lassalle.Flow.Link(); 
	  
				link = addflow_StdRout.Nodes[ClassLib.ComFunction.Get_Index(fgrid_NodeRout, fgrid_LinkRout[i, (int)ClassLib.TBSPB_LINK_ROUT.IxORG_NODE].ToString(), (int)ClassLib.TBSPB_NODE_ROUT.IxNODE_CD, _Rowfixed)]
					.OutLinks.Add(addflow_StdRout.Nodes[ClassLib.ComFunction.Get_Index(fgrid_NodeRout, fgrid_LinkRout[i, (int)ClassLib.TBSPB_LINK_ROUT.IxDST_NODE].ToString(), (int)ClassLib.TBSPB_NODE_ROUT.IxNODE_CD, _Rowfixed)]);
				
				link.Tag = fgrid_LinkRout[i, (int)ClassLib.TBSPB_LINK_ROUT.IxTAG].ToString(); 
 
				ClassLib.ComFunction.Set_LinkProp(fgrid_LinkRout, link, i);


				if(max_index <= Convert.ToInt32(link.Tag))  max_index = Convert.ToInt32(link.Tag); 
				 
				
			} // end for

			_Link_Index = max_index + 1;
   
		}


		#endregion 

		#region 이벤트 처리

		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataSet ds_ret;
			DataTable dt_ret, dt_node, dt_link;

			try
			{
				if(cmb_Factory.SelectedIndex == -1) return;
	
				//cmp_cd
				dt_ret = Select_SPB_CMP();
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_CmpCd, 1, 2, false, COM.ComVar.ComboList_Visible.Code); 

				//rout_type
				dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxRoutType);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_RoutType, 1, 2, false, COM.ComVar.ComboList_Visible.Code_Name); 

				if(ClassLib.ComVar.FormClick_Flag == true)
				{
					cmb_CmpCd.SelectedValue = _CmpCd;
					cmb_RoutType.SelectedValue = _RoutType;
				} 
				
				//Default Node, Link 속성 세팅
				ds_ret = Select_Default_NodeLinkProp();
				dt_node = ds_ret.Tables["PKG_SPB_OPCD.SELECT_OPTYPE_LIST"];
				dt_link = ds_ret.Tables["PKG_SPB_BOM.SELECT_LINKPROP_LIST"];
				Display_Grid(dt_node, fgrid_NodeDef);
				Display_Grid(dt_link, fgrid_LinkDef);
				 
			}
			catch
			{
			}

		} 

		private void cmb_CmpCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Display_Rout_Info();
		}

		private void cmb_RoutType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Display_Rout_Info();
		}

		private void addflow_StdRout_AfterMove(object sender, System.EventArgs e)
		{
			try
			{
				for(int i = _Rowfixed; i < fgrid_Rout.Rows.Count; i++)
				{
					if(addflow_StdRout.SelectedItem.Tag.ToString() == fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT.IxROUT_SEQ].ToString())
					{
						if(fgrid_Rout[i, 0].ToString() != "I") fgrid_Rout[i, 0] = "U";
					}
				}
			}
			catch
			{
			}
		}

		private void addflow_StdRout_AfterResize(object sender, System.EventArgs e)
		{
			try
			{
				for(int i = _Rowfixed; i < fgrid_Rout.Rows.Count; i++)
				{
					if(addflow_StdRout.SelectedItem.Tag.ToString() == fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT.IxROUT_SEQ].ToString())
					{
						if(fgrid_Rout[i, 0].ToString() != "I") fgrid_Rout[i, 0] = "U";
					}
				}
			}
			catch
			{
			}
		}

		private void addflow_StdRout_AfterAddLink(object sender, Lassalle.Flow.AfterAddLinkEventArgs e)
		{
			for(int i = fgrid_LinkDef.Rows.Fixed; i < fgrid_LinkDef.Rows.Count; i++)
			{
				if(fgrid_LinkDef[i, (int)ClassLib.TBSPB_LINK_DEF.IxLINK_TYPE].ToString() == ClassLib.ComVar.RoutLinkType)
				{ 
					ClassLib.ComFunction.Set_LinkProp(fgrid_LinkDef, e.Link, i);

					if(_Link_Index == -1) _Link_Index = 0;
			 
					e.Link.Tag = _Link_Index;
					_Link_Index++;

					break;
				}
			}
		}

		

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;

			if(!src.Equals(btn_CreateCd))
				src.ImageIndex = 1;
			else if(src.Equals(btn_CreateCd))
				src.ImageIndex = 3;
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			
			if(!src.Equals(btn_CreateCd))
				src.ImageIndex = 0;
			else if(src.Equals(btn_CreateCd))
				src.ImageIndex = 2;
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

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			bool save_flag = false; 

			try
			{ 
				save_flag = Save_StdRout(); 
				if(!save_flag) return;

				Display_Rout_Info(); 
			}
			catch
			{
			}
		} 

		#region 저장 관련

		#region 컬럼 자동 소트 클래스

		/// <summary>
		/// MyComparer
		/// compares two grid rows using all columns
		/// </summary>
		public class MyComparer : IComparer
		{
			C1FlexGrid _flex;
			public MyComparer(C1FlexGrid flex)
			{
				_flex = flex;
			}
			int IComparer.Compare(object x, object y)
			{
				// get row indices
				int r1 = ((Row)x).Index;
				int r2 = ((Row)y).Index;

				// scan all columns looking for differences
				for (int c = 0; c < _flex.Cols.Count; c++)
				{
					// get display values
					string s1 = _flex.GetDataDisplay(r1, c);
					string s2 = _flex.GetDataDisplay(r2, c);

					// compare, done when a difference is found
					int cmp = string.Compare(s1, s2);
					if (cmp != 0) return cmp;
				}

				// all values are the same, use row indices
				// to keep sort stable
				return r1 - r2;
			}
		}


		#endregion 

		/// <summary>
		/// Save_StdRout : SPB_ROUT, SPB_NODE_ROUT, SPB_LINK_ROUT 저장
		/// </summary>
		/// <returns></returns>
		private bool Save_StdRout()
		{
			try
			{
				//행 수정 상태 해제
				fgrid_Rout.Select(fgrid_Rout.Selection.r1, 0, fgrid_Rout.Selection.r1, fgrid_Rout.Cols.Count-1, false);
 
				fgrid_Rout.Sort(new MyComparer(fgrid_Rout)); 

				Make_SAVE_SPB_ROUT();
				Make_SAVE_SPB_NODE_ROUT();
				Make_SAVE_SPB_LINK_ROUT();

				MyOraDB.Exe_Modify_Procedure(); 
				return true;
			}
			catch
			{
				return false;
			}
		}


		/// <summary>
		/// Make_SAVE_SPB_ROUT : SPB_ROUT 저장 테이블 구성
		/// </summary>
		private void Make_SAVE_SPB_ROUT()
		{
			int col_ct = fgrid_Rout.Cols.Count - 3;		// 칼럼의 수 
			int save_ct =0 ;							// 저장 행 수 
			int para_ct =0;								// 파라미터 값의 저장 배열의 수 

			try
			{
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPB_ROUT.SAVE_SPB_ROUT";
 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				for(int i = 1; i < col_ct; i++)
				{
					MyOraDB.Parameter_Name[i] = "ARG_" + fgrid_Rout[0, i].ToString(); 
				}
 
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}
	 
				for(int i = _Rowfixed ; i < fgrid_Rout.Rows.Count; i++)
				{
					if(fgrid_Rout[i, 0].ToString() != "") save_ct += 1; 
				}
			 
				MyOraDB.Parameter_Values  = new string[col_ct * save_ct ];

 
				//for(int row = _Rowfixed; row < fgrid_Rout.Rows.Count ; row++)

				for(int row = fgrid_Rout.Rows.Count - 1; row >= _Rowfixed; row--)
				{
					if(fgrid_Rout[row, 0].ToString() != "")
					{ 
						for(int col = 0; col < col_ct ; col++)	// 각 열의 값 Setting
						{  
							// 데이터값 설정 
							if(fgrid_Rout.Cols[col].Style.DataType != null
								&& fgrid_Rout.Cols[col].DataType.Equals(typeof(bool)) )
							{ 
								fgrid_Rout[row, col] = (fgrid_Rout[row, col] == null) ? "False" : fgrid_Rout[row, col].ToString();
								MyOraDB.Parameter_Values[para_ct] = (fgrid_Rout[row,col].ToString() == "True") ? "Y" : "N"; 

								para_ct ++;
							} 
							else
							{
								MyOraDB.Parameter_Values[para_ct] = (fgrid_Rout[row, col] == null) ? "" : fgrid_Rout[row,col].ToString();
								para_ct ++;
							}			
						} 
					}
				}

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가  
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Make_SAVE_SPB_ROUT",MessageBoxButtons.OK,MessageBoxIcon.Error); 
			}
		}

		
		/// <summary>
		/// Make_SAVE_SPB_NODE_ROUT : SPB_NODE_ROUT 저장 테이블 구성
		/// </summary>
		private void Make_SAVE_SPB_NODE_ROUT()
		{
			int col_ct = 27;		 
			int save_ct =0 ;							 
			int para_ct =0;	 
			int index = 0;
			Lassalle.Flow.Node node;

			try
			{
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPB_ROUT.SAVE_SPB_NODE_ROUT";
 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION"; 
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_CMP_CD";
				MyOraDB.Parameter_Name[3] = "ARG_ROUT_TYPE";
				MyOraDB.Parameter_Name[4] = "ARG_ROUT_SEQ";
				for(int i = (int)ClassLib.TBSPB_NODE_ROUT.IxNODE_CD; i <= (int)ClassLib.TBSPB_NODE_ROUT.IxWIDTH; i++)
				{
					MyOraDB.Parameter_Name[i + 3] = "ARG_" + fgrid_NodeRout[0, i].ToString(); 
				}
				MyOraDB.Parameter_Name[25] = "ARG_UPD_USER";
				MyOraDB.Parameter_Name[26] = "ARG_H_ROUT_SEQ";

				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}
	 
				for(int i = _Rowfixed ; i < fgrid_Rout.Rows.Count; i++) save_ct += 1;  
			 
				MyOraDB.Parameter_Values  = new string[col_ct * save_ct ];  

// 				for(int i = _Rowfixed; i < fgrid_Rout.Rows.Count; i++)

				for(int i = fgrid_Rout.Rows.Count - 1; i >= _Rowfixed; i--)
  				{ 
					foreach(Item item in addflow_StdRout.Items)
					{
						if(item is Lassalle.Flow.Node)
						{
							node = (Lassalle.Flow.Node)item;
 
							//저장 대상 품목 코드와 일치하는 노드
							if((node.Tag).ToString() == fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT.IxH_ROUT_SEQ].ToString())
							{
								index = Convert.ToInt32(fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT.IxNODE_NO].ToString());  //node.Index;
								RectangleF rc = node.Rect; 

								MyOraDB.Parameter_Values[para_ct] = (fgrid_Rout[i, 0].ToString() == "") ? "U" : fgrid_Rout[i, 0].ToString();
								MyOraDB.Parameter_Values[para_ct + 1] = cmb_Factory.SelectedValue.ToString();  
								MyOraDB.Parameter_Values[para_ct + 2] = cmb_CmpCd.SelectedValue.ToString();
								MyOraDB.Parameter_Values[para_ct + 3] = cmb_RoutType.SelectedValue.ToString();
								MyOraDB.Parameter_Values[para_ct + 4] = fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT.IxROUT_SEQ].ToString();  
								MyOraDB.Parameter_Values[para_ct + 5] = string.Format("{0:0000}", index); //cmb_RFactory.SelectedValue.ToString() + cmb_RCmpCd.SelectedValue.ToString() + string.Format("{0:0000}", index);
								MyOraDB.Parameter_Values[para_ct + 6] = rc.Left.ToString();
								MyOraDB.Parameter_Values[para_ct + 7] = rc.Top.ToString();
								MyOraDB.Parameter_Values[para_ct + 8] = node.Alignment.GetHashCode().ToString();
								MyOraDB.Parameter_Values[para_ct + 9] = node.DashStyle.GetHashCode().ToString();
								MyOraDB.Parameter_Values[para_ct + 10] = node.DrawColor.ToArgb().ToString();
								MyOraDB.Parameter_Values[para_ct + 11] = node.DrawWidth.ToString();
								MyOraDB.Parameter_Values[para_ct + 12] = node.FillColor.ToArgb().ToString();
								MyOraDB.Parameter_Values[para_ct + 13] = node.Font.Name + "/"
									+ node.Font.Size + "/"
									+ node.Font.Bold + "/"
									+ (node.Font.Italic ? true : false) + "/"
									+ (node.Font.Strikeout ? true : false) + "/"
									+ (node.Font.Underline ? true : false);  

								MyOraDB.Parameter_Values[para_ct + 14] = (node.Gradient ? "Y" : "N");
								MyOraDB.Parameter_Values[para_ct + 15] = node.GradientColor.ToArgb().ToString();
								MyOraDB.Parameter_Values[para_ct + 16] = node.GradientMode.GetHashCode().ToString();
								MyOraDB.Parameter_Values[para_ct + 17] = rc.Height.ToString();
								MyOraDB.Parameter_Values[para_ct + 18] = node.Shadow.Style.GetHashCode().ToString() + "/"
									+ node.Shadow.Color.ToArgb().ToString() + "/"
									+ node.Shadow.Size.Width.ToString() + "/"
									+ node.Shadow.Size.Height.ToString();
								MyOraDB.Parameter_Values[para_ct + 19] = node.Shape.Style.GetHashCode().ToString();
								MyOraDB.Parameter_Values[para_ct + 20] = fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT.IxROUT_SEQ].ToString();
								MyOraDB.Parameter_Values[para_ct + 21] = fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT.IxOP_CD].ToString();
								MyOraDB.Parameter_Values[para_ct + 22] = node.TextColor.ToArgb().ToString();
								MyOraDB.Parameter_Values[para_ct + 23] = fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT.IxOP_CD].ToString() 
																		+ "(" + fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT.IxROUT_SEQ].ToString() + ")";
								MyOraDB.Parameter_Values[para_ct + 24] = rc.Width.ToString(); 
								MyOraDB.Parameter_Values[para_ct + 25] = ClassLib.ComVar.This_User;
								MyOraDB.Parameter_Values[para_ct + 26] = fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT.IxH_ROUT_SEQ].ToString();
		
								para_ct += col_ct;  
							} 

 						}//end if 
 					}//end foreach  
 				}// end for

				MyOraDB.Add_Modify_Parameter(false);		   
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Make_SAVE_SPB_NODE_ROUT",MessageBoxButtons.OK,MessageBoxIcon.Error); 
			}

		}

		/// <summary>
		/// Make_SAVE_SPB_LINK_ROUT : SPB_LINK_ROUT 저장 테이블 구성
		/// </summary>
		private void Make_SAVE_SPB_LINK_ROUT()
		{
			int col_ct = 23;		 
			int save_ct =0 ;							 
			int para_ct =0;	 
			int index = 0;
			Lassalle.Flow.Link link;

			try
			{
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPB_ROUT.SAVE_SPB_LINK_ROUT";
  
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION"; 
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_CMP_CD";
				MyOraDB.Parameter_Name[3] = "ARG_ROUT_TYPE";
				MyOraDB.Parameter_Name[4] = "ARG_LINK_SEQ";
				MyOraDB.Parameter_Name[5] = "ARG_ORG_NODE";
				MyOraDB.Parameter_Name[6] = "ARG_DST_NODE";
				MyOraDB.Parameter_Name[7] = "ARG_POINT";
				for(int i = (int)ClassLib.TBSPB_LINK_ROUT.IxARROW_DST; i <= (int)ClassLib.TBSPB_LINK_ROUT.IxTOOLTIP; i++)
				{
					MyOraDB.Parameter_Name[i + 5] = "ARG_" + fgrid_LinkRout[0, i].ToString(); 
				}
				
				MyOraDB.Parameter_Name[22] = "ARG_UPD_USER";

				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}
	 
				foreach(Item item in addflow_StdRout.Items)
				{
					if(item is Lassalle.Flow.Link) save_ct += 1;
				} 
 
			 
				MyOraDB.Parameter_Values  = new string[col_ct * save_ct ];  

				foreach(Item item in addflow_StdRout.Items)
				{
					if(item is Lassalle.Flow.Link)
					{
						link = (Lassalle.Flow.Link)item;
 
						index = Convert.ToInt32(link.Tag.ToString());
  
						if(_Link_Delete_Org == link.Org.Index.ToString() && _Link_Delete_Dst == link.Dst.Index.ToString())
						{
							if(_Link_Delete)
							{
								MyOraDB.Parameter_Values[para_ct] = "D"; 
								_Link_Delete = false;
							}
							else
							{
								MyOraDB.Parameter_Values[para_ct] = "I"; 
							}
							
						}
						else
						{
							MyOraDB.Parameter_Values[para_ct] = "I"; 
						}
   
						MyOraDB.Parameter_Values[para_ct + 1] = cmb_Factory.SelectedValue.ToString();  
						MyOraDB.Parameter_Values[para_ct + 2] = cmb_CmpCd.SelectedValue.ToString();  
						MyOraDB.Parameter_Values[para_ct + 3] = cmb_RoutType.SelectedValue.ToString();  
						MyOraDB.Parameter_Values[para_ct + 4] = string.Format("{0:000000}", index);
						MyOraDB.Parameter_Values[para_ct + 5] = link.Org.Index.ToString();
						MyOraDB.Parameter_Values[para_ct + 6] = link.Dst.Index.ToString();
						MyOraDB.Parameter_Values[para_ct + 7] = "";  //point
						MyOraDB.Parameter_Values[para_ct + 8] = link.ArrowDst.Style.GetHashCode().ToString() + "/"
							+ link.ArrowDst.Size.GetHashCode().ToString() + "/"
							+ link.ArrowDst.Angle.GetHashCode().ToString() + "/"
							+ link.ArrowDst.Filled.ToString();
						MyOraDB.Parameter_Values[para_ct + 9] = link.ArrowMid.Style.GetHashCode().ToString() + "/"
							+ link.ArrowMid.Size.GetHashCode().ToString() + "/"
							+ link.ArrowMid.Angle.GetHashCode().ToString() + "/"
							+ link.ArrowMid.Filled.ToString();
						MyOraDB.Parameter_Values[para_ct + 10] = link.ArrowOrg.Style.GetHashCode().ToString() + "/"
							+ link.ArrowOrg.Size.GetHashCode().ToString() + "/"
							+ link.ArrowOrg.Angle.GetHashCode().ToString() + "/"
							+ link.ArrowOrg.Filled.ToString();
						MyOraDB.Parameter_Values[para_ct + 11] = link.DashStyle.GetHashCode().ToString();
						MyOraDB.Parameter_Values[para_ct + 12] = link.DrawColor.ToArgb().ToString();
						MyOraDB.Parameter_Values[para_ct + 13] = link.DrawWidth.ToString(); 
						MyOraDB.Parameter_Values[para_ct + 14] = link.Font.Name + "/"
							+ link.Font.Size + "/"
							+ link.Font.Bold + "/"
							+ (link.Font.Italic ? true : false) + "/"
							+ (link.Font.Strikeout ? true : false) + "/"
							+ (link.Font.Underline ? true : false) ;
						MyOraDB.Parameter_Values[para_ct + 15] = link.Jump.GetHashCode().ToString(); 
						MyOraDB.Parameter_Values[para_ct + 16] = link.Line.Style.GetHashCode().ToString(); 
						MyOraDB.Parameter_Values[para_ct + 17] = link.Line.RoundedCorner.ToString(); 
						MyOraDB.Parameter_Values[para_ct + 18] = link.Tag.ToString();
						MyOraDB.Parameter_Values[para_ct + 19] = "";     //link.Text.ToString();
						MyOraDB.Parameter_Values[para_ct + 20] = "";     //link.TextColor.ToArgb().ToString();
						MyOraDB.Parameter_Values[para_ct + 21] = "";     //link.Tooltip.ToString(); 
						MyOraDB.Parameter_Values[para_ct + 22] = ClassLib.ComVar.This_User; 
 
						para_ct += col_ct;   
					}  
				} 
 

				MyOraDB.Add_Modify_Parameter(false);		   
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Make_SAVE_SPB_LINK_ROUT",MessageBoxButtons.OK,MessageBoxIcon.Error); 
			}
		}

		#endregion

		//rout_type 공통코드 추가
		private void btn_CreateCd_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_Factory.SelectedIndex == -1) return;

				COM.APSWinForm.Form_CM_CodeAdd pop_form = new COM.APSWinForm.Form_CM_CodeAdd();
				ClassLib.ComVar.Parameter_PopUp = new string[] {cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxRoutType, ""};
				pop_form.ShowDialog(); 
 
				dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxRoutType);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_RoutType, 1, 2, false); 

			}
			catch
			{
			}

		}

		private void btn_Refresh_Click(object sender, System.EventArgs e)
		{
			Display_Rout_Info();
		}

		


		private void fgrid_Rout_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{ 
			bool digit_flag = false;

			try
			{
				digit_flag = ClassLib.ComFunction.Check_Digit(fgrid_Rout[e.Row, e.Col].ToString());
				if(digit_flag == false) return;

				fgrid_Rout[e.Row, e.Col] = fgrid_Rout[e.Row, e.Col].ToString().PadLeft(3, '0');
				fgrid_Rout.Update_Row(e.Row); 
				fgrid_Rout.AutoSizeCols(); 
			}
			catch
			{
			}
		}

		
		private void menuItem_NodeProp_Click(object sender, System.EventArgs e)
		{
			try
			{
				Item item;
				Lassalle.DlgFlow.DlgFlow dlgflow = new Lassalle.DlgFlow.DlgFlow();
				Lassalle.Flow.Node node = new Lassalle.Flow.Node();  
			 
				item = addflow_StdRout.PointedItem;

				if (item is Lassalle.Flow.Node)
				{
					node = (Lassalle.Flow.Node)item;
					dlgflow.NodePropertyPage(addflow_StdRout, node); 
				}

				//바로 저장
				Save_StdRout(); 

			}
			catch
			{
			}

		}

		private void menuItem_LinkProp_Click(object sender, System.EventArgs e)
		{
			Item item;
			Lassalle.DlgFlow.DlgFlow dlgflow = new Lassalle.DlgFlow.DlgFlow();
			Lassalle.Flow.Link link = new Lassalle.Flow.Link(); 
			
			try
			{
				item = addflow_StdRout.PointedItem;

				if (item is Lassalle.Flow.Link)
				{
					link = (Lassalle.Flow.Link)item;
					dlgflow.LinkPropertyPage(addflow_StdRout, link); 
				}

				//바로 저장
				Save_StdRout(); 
			}
			catch
			{
			}

		}

		private void menuItem_Add_Click(object sender, System.EventArgs e)
		{ 
			try
			{
				if(cmb_Factory.SelectedIndex == -1) return;

				Pop_SetRoutInfo pop_form = new Pop_SetRoutInfo();

				//factory, rout_seq, op_cd
				ClassLib.ComVar.Parameter_PopUp = new string[] {cmb_Factory.SelectedValue.ToString(), "", ""};
				pop_form.ShowDialog(); 

				if(!pop_form._CloseSave) return;

				//routseq, opcd, optype
				//---------------------------------------------------------------
				//Add Node
				_AddNode = addflow_StdRout.Nodes.Add(200, 50, 70, 20); 
				_AddNode.Tag = ClassLib.ComVar.Parameter_PopUp[0];
				_AddNode.Text = ClassLib.ComVar.Parameter_PopUp[1];
             
				for(int i = fgrid_NodeDef.Rows.Fixed; i < fgrid_NodeDef.Rows.Count; i++)
				{
					if(ClassLib.ComVar.Parameter_PopUp[2] == fgrid_NodeDef[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxOP_TYPE].ToString())
					{
						ClassLib.ComFunction.Set_NodeProp(fgrid_NodeDef, _AddNode,  i);
						break;
					}
					else
					{
						ClassLib.ComFunction.Set_DefNodeProp(addflow_StdRout);
					}
				}

				fgrid_Rout.Add_Row(fgrid_Rout.Rows.Count - 1); 

				fgrid_Rout[fgrid_Rout.Rows.Count - 1, (int)ClassLib.TBSPB_ROUT.IxFACTORY] = cmb_Factory.SelectedValue.ToString();
				fgrid_Rout[fgrid_Rout.Rows.Count - 1, (int)ClassLib.TBSPB_ROUT.IxCMP_CD] = cmb_CmpCd.SelectedValue.ToString();
				fgrid_Rout[fgrid_Rout.Rows.Count - 1, (int)ClassLib.TBSPB_ROUT.IxROUT_TYPE] = cmb_RoutType.SelectedValue.ToString();
				fgrid_Rout[fgrid_Rout.Rows.Count - 1, (int)ClassLib.TBSPB_ROUT.IxROUT_NAME] = cmb_RoutType.Columns[1].Text;
				fgrid_Rout[fgrid_Rout.Rows.Count - 1, (int)ClassLib.TBSPB_ROUT.IxROUT_SEQ] = ClassLib.ComVar.Parameter_PopUp[0];
				fgrid_Rout[fgrid_Rout.Rows.Count - 1, (int)ClassLib.TBSPB_ROUT.IxOP_LEVEL] = "";
				fgrid_Rout[fgrid_Rout.Rows.Count - 1, (int)ClassLib.TBSPB_ROUT.IxOP_CD] = ClassLib.ComVar.Parameter_PopUp[1];
				fgrid_Rout[fgrid_Rout.Rows.Count - 1, (int)ClassLib.TBSPB_ROUT.IxNODE_NO] = _Node_Index;
				fgrid_Rout[fgrid_Rout.Rows.Count - 1, (int)ClassLib.TBSPB_ROUT.IxH_ROUT_SEQ] = ClassLib.ComVar.Parameter_PopUp[0];

				_Node_Index++;


			}
			catch
			{
			}
		}

		private void menuItem_Update_Click(object sender, System.EventArgs e)
		{
			Item item; 
			Lassalle.Flow.Node node = new Lassalle.Flow.Node();  
			 
			try
			{
				if(cmb_Factory.SelectedIndex == -1) return; 

				item = addflow_StdRout.PointedItem;

				if (item is Lassalle.Flow.Node)
				{
					node = (Lassalle.Flow.Node)item; 
					
					//factory, rout_seq, op_cd
					ClassLib.ComVar.Parameter_PopUp = new string[] {cmb_Factory.SelectedValue.ToString(), 
																	   node.Tag.ToString(),
																	   node.Text.ToString()}; 
				}


				Pop_SetRoutInfo pop_form = new Pop_SetRoutInfo(); 
				pop_form.ShowDialog(); 

				if(!pop_form._CloseSave) return;

				//-----------------------------------------------

				for(int i = _Rowfixed; i < fgrid_Rout.Rows.Count; i++)
				{
					//저장 대상 품목 코드와 일치하는 노드
					if((node.Tag).ToString() == fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT.IxH_ROUT_SEQ].ToString())
					{
						if(fgrid_Rout[i, 0].ToString() != "I") fgrid_Rout[i, 0] = "U"; 
 
						fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT.IxROUT_SEQ] = ClassLib.ComVar.Parameter_PopUp[0]; 
						fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT.IxOP_CD] = ClassLib.ComVar.Parameter_PopUp[1]; 
					}
				}

				node.Text = ClassLib.ComVar.Parameter_PopUp[1]; 
			}
			catch
			{
			}

		}

		private void menuItem_Delete_Click(object sender, System.EventArgs e)
		{
			Item item; 
			Lassalle.Flow.Link link;

			try
			{ 
				item = addflow_StdRout.PointedItem;

				if (item is Lassalle.Flow.Node)
				{
					Delete_Node((Lassalle.Flow.Node)item);
				}
			
				if (item is Lassalle.Flow.Link)
				{ 
					link = (Lassalle.Flow.Link)item;

					_Link_Delete = true; 
					_Link_Delete_Org = link.Org.Index.ToString();
					_Link_Delete_Dst = link.Dst.Index.ToString();
 
					//addflow_StdRout.DeleteSel();
					Save_StdRout();
					Display_Rout_Info();
				} 
			}
			catch
			{
			}
		}

		 
		/// <summary>
		/// Delete_Node : 노드 및 링크 삭제
		/// </summary>
		private void Delete_Node(Lassalle.Flow.Node arg_node)
		{
			
			//품목코드 삭제, 노드삭제, 링크삭제
			int sel_row = 0;   
 
			Lassalle.Flow.Link link = new Lassalle.Flow.Link();
			Lassalle.Flow.Node current_node = new Lassalle.Flow.Node(); 
			Lassalle.Flow.Link current_link = new Lassalle.Flow.Link();
      
			bool link_exist = false;

			try
			{
				current_node = arg_node;

				for(int i = _Rowfixed; i < fgrid_Rout.Rows.Count; i++)
				{
					if(current_node.Tag.ToString() == fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT.IxH_ROUT_SEQ].ToString())
					{
						sel_row = i;
						break;
					}
				}

				foreach(Item item in addflow_StdRout.Items)
				{ 
					if(item is Lassalle.Flow.Link)
					{
						link = (Lassalle.Flow.Link)item;

						if(link.Dst.Index.ToString() == current_node.Index.ToString() )
						{
							link_exist = true;
							current_link = link;  
							break;
						} 

					}// end if(link) 
				}// end foreach

				//if(current_link != null) _Link_Delete = true; 

				switch(fgrid_Rout[sel_row, 0].ToString())
				{
					case "I": 
 				
						//delete node
						
						if(link_exist) addflow_StdRout.Nodes[current_node.Index].Links.Remove(current_link);  
						addflow_StdRout.Nodes.Remove(current_node);  

						//delete fgrid_BOM
						fgrid_Rout.Rows.Remove(sel_row); 

						break;

					default:
 
						fgrid_Rout.Delete_Row(sel_row);

						//delete node
						if(link_exist) 
						{
							_Link_Delete = true;
							_Link_Delete_Org = current_link.Org.Index.ToString();
							_Link_Delete_Dst = current_link.Dst.Index.ToString();
							//addflow_StdRout.Nodes[current_node.Index].Links.Remove(current_link);  
						}
						else
						{
							_Link_Delete = false;
						}

						//addflow_StdRout.Nodes.Remove(current_node);  

						Save_StdRout(); 
						Display_Rout_Info();

						break;
					
				} //end if
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Delete_Node",MessageBoxButtons.OK,MessageBoxIcon.Error); 
			}
		}

		private void btn_Return_Click(object sender, System.EventArgs e)
		{
			if(cmb_Factory.SelectedIndex == -1 || cmb_CmpCd.SelectedIndex == -1 || cmb_RoutType.SelectedIndex == -1) return;

			Insert_Default_BomRout();
			this.Close();
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

		/// <summary>
		/// Select_SPB_ROUT : 표준 라우팅 리스트 
		/// </summary>
		private DataTable Select_SPB_ROUT()
		{
			DataSet ds_ret; 

			try
			{ 
				string process_name = "PKG_SPB_ROUT.SELECT_SPB_ROUT";

				MyOraDB.ReDim_Parameter(4); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_CMP_CD";
				MyOraDB.Parameter_Name[2] = "ARG_ROUT_TYPE"; 
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = cmb_CmpCd.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[2] = cmb_RoutType.SelectedValue.ToString(); 
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


		/// <summary>
		/// Select_Default_NodeLinkProp :Default Node, Link 속성
		/// </summary>
		private DataSet Select_Default_NodeLinkProp()
		{
			DataSet ds_ret; 

			try
			{ 
				//Default Node 속성
				string process_name = "PKG_SPB_OPCD.SELECT_OPTYPE_LIST";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true);
 
				//Default Link 속성
				process_name = "PKG_SPB_BOM.SELECT_LINKPROP_LIST";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(false);

				ds_ret = MyOraDB.Exe_Select_Procedure(); 
				if(ds_ret == null) return null; 
				return ds_ret; 
			}
			catch
			{ 
				return null; 
			}  
 
		} 
  

		/// <summary>
		/// Select_SPB_ROUT_NodeLink : 표준 라우팅 Node, Link 속성
		/// </summary>
		private DataSet Select_SPB_ROUT_NodeLink()
		{
			DataSet ds_ret; 

			try
			{ 
				//Node Rout
				string process_name = "PKG_SPB_ROUT.SELECT_STDROUT_NODE";

				MyOraDB.ReDim_Parameter(4); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_CMP_CD";
				MyOraDB.Parameter_Name[2] = "ARG_ROUT_TYPE"; 
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = cmb_CmpCd.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[2] = cmb_RoutType.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[3] = "";  

				MyOraDB.Add_Select_Parameter(true); 

				//Link Rout
				process_name = "PKG_SPB_ROUT.SELECT_STDROUT_LINK";

				MyOraDB.ReDim_Parameter(4); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_CMP_CD";
				MyOraDB.Parameter_Name[2] = "ARG_ROUT_TYPE"; 
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = cmb_CmpCd.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[2] = cmb_RoutType.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[3] = "";  

				MyOraDB.Add_Select_Parameter(false);

				ds_ret = MyOraDB.Exe_Select_Procedure();
				if(ds_ret == null) return null; 
				return ds_ret; 

			}
			catch
			{ 
				return null; 
			}  
		}


		/// <summary>
		/// Insert_Default_BomRout : 초기상태로 기본 표준 라우팅 그대로 디비에 반영
		/// </summary>
		private void Insert_Default_BomRout()
		{ 
			try
			{
				string process_name = "PKG_SPB_ROUT.INSERT_SPB_ROUT_BOM";

				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD";
				MyOraDB.Parameter_Name[2] = "ARG_CMP_CD";
				MyOraDB.Parameter_Name[3] = "ARG_ROUT_TYPE"; 
				MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			  
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = _BomCd;
				MyOraDB.Parameter_Values[2] = _CmpCd;  
				MyOraDB.Parameter_Values[3] = cmb_RoutType.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[4] = ClassLib.ComVar.This_User;  

				MyOraDB.Add_Modify_Parameter(true); 
				MyOraDB.Exe_Modify_Procedure();
 
			}
			catch
			{
			}

		}

		#endregion

		
		private void Form_PB_Rout_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

	
		
		
		



	}
}

