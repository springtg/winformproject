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
	public class Form_PD_MiniSize_TS_Search : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.Panel pnl_B;
		public System.Windows.Forms.Panel pnl_BT;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.DateTimePicker dpick_PlanYMD;
		private System.Windows.Forms.Label lbl_MLineCd;
		private C1.Win.C1List.C1Combo cmb_MLineCd;
		private System.Windows.Forms.Label lbl_OpCd;
		private C1.Win.C1List.C1Combo cmb_OpCd;
		private System.Windows.Forms.Label lbl_OpStrYMD;
		private C1.Win.C1List.C1Combo cmb_LineCd;
		private System.Windows.Forms.Label lbl_Line;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.ImageList img_SmallLabel;
		private COM.FSP fgrid_TS;
		private System.ComponentModel.IContainer components = null;

		public Form_PD_MiniSize_TS_Search()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PD_MiniSize_TS_Search));
			this.pnl_B = new System.Windows.Forms.Panel();
			this.fgrid_TS = new COM.FSP();
			this.pnl_BT = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.lbl_OpCd = new System.Windows.Forms.Label();
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			this.cmb_OpCd = new C1.Win.C1List.C1Combo();
			this.lbl_Line = new System.Windows.Forms.Label();
			this.cmb_LineCd = new C1.Win.C1List.C1Combo();
			this.dpick_PlanYMD = new System.Windows.Forms.DateTimePicker();
			this.lbl_MLineCd = new System.Windows.Forms.Label();
			this.cmb_MLineCd = new C1.Win.C1List.C1Combo();
			this.lbl_OpStrYMD = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_B.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_TS)).BeginInit();
			this.pnl_BT.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OpCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LineCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_MLineCd)).BeginInit();
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
			// pnl_B
			// 
			this.pnl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_B.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_B.Controls.Add(this.fgrid_TS);
			this.pnl_B.Controls.Add(this.pnl_BT);
			this.pnl_B.DockPadding.All = 8;
			this.pnl_B.Location = new System.Drawing.Point(0, 64);
			this.pnl_B.Name = "pnl_B";
			this.pnl_B.Size = new System.Drawing.Size(1016, 576);
			this.pnl_B.TabIndex = 31;
			// 
			// fgrid_TS
			// 
			this.fgrid_TS.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_TS.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_TS.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_TS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_TS.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_TS.Location = new System.Drawing.Point(8, 78);
			this.fgrid_TS.Name = "fgrid_TS";
			this.fgrid_TS.Size = new System.Drawing.Size(1000, 490);
			this.fgrid_TS.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:137, 179, 234;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:Lavender;ForeColor:Black;}	Subtotal2{BackColor:217, 250, 216;ForeColor:Black;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_TS.TabIndex = 43;
			this.fgrid_TS.Click += new System.EventHandler(this.fgrid_TS_Click);
			// 
			// pnl_BT
			// 
			this.pnl_BT.BackColor = System.Drawing.Color.Transparent;
			this.pnl_BT.Controls.Add(this.pnl_SearchImage);
			this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_BT.DockPadding.Bottom = 5;
			this.pnl_BT.Location = new System.Drawing.Point(8, 8);
			this.pnl_BT.Name = "pnl_BT";
			this.pnl_BT.Size = new System.Drawing.Size(1000, 70);
			this.pnl_BT.TabIndex = 42;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.lbl_OpCd);
			this.pnl_SearchImage.Controls.Add(this.cmb_OpCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_Line);
			this.pnl_SearchImage.Controls.Add(this.cmb_LineCd);
			this.pnl_SearchImage.Controls.Add(this.dpick_PlanYMD);
			this.pnl_SearchImage.Controls.Add(this.lbl_MLineCd);
			this.pnl_SearchImage.Controls.Add(this.cmb_MLineCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_OpStrYMD);
			this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
			this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.picb_MM);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 65);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// lbl_OpCd
			// 
			this.lbl_OpCd.ImageIndex = 0;
			this.lbl_OpCd.ImageList = this.img_SmallLabel;
			this.lbl_OpCd.Location = new System.Drawing.Point(800, 32);
			this.lbl_OpCd.Name = "lbl_OpCd";
			this.lbl_OpCd.Size = new System.Drawing.Size(50, 21);
			this.lbl_OpCd.TabIndex = 38;
			this.lbl_OpCd.Text = "Proc.";
			this.lbl_OpCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_OpCd.Visible = false;
			// 
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
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
			this.cmb_OpCd.Location = new System.Drawing.Point(848, 32);
			this.cmb_OpCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_OpCd.MaxDropDownItems = ((short)(5));
			this.cmb_OpCd.MaxLength = 32767;
			this.cmb_OpCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OpCd.Name = "cmb_OpCd";
			this.cmb_OpCd.PartialRightColumn = false;
			this.cmb_OpCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_OpCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OpCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OpCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OpCd.Size = new System.Drawing.Size(110, 21);
			this.cmb_OpCd.TabIndex = 39;
			this.cmb_OpCd.Visible = false;
			this.cmb_OpCd.SelectedValueChanged += new System.EventHandler(this.cmb_OpCd_SelectedValueChanged);
			// 
			// lbl_Line
			// 
			this.lbl_Line.ImageIndex = 0;
			this.lbl_Line.ImageList = this.img_SmallLabel;
			this.lbl_Line.Location = new System.Drawing.Point(394, 36);
			this.lbl_Line.Name = "lbl_Line";
			this.lbl_Line.Size = new System.Drawing.Size(50, 21);
			this.lbl_Line.TabIndex = 34;
			this.lbl_Line.Text = "Line";
			this.lbl_Line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_LineCd.Location = new System.Drawing.Point(445, 36);
			this.cmb_LineCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_LineCd.MaxDropDownItems = ((short)(5));
			this.cmb_LineCd.MaxLength = 32767;
			this.cmb_LineCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_LineCd.Name = "cmb_LineCd";
			this.cmb_LineCd.PartialRightColumn = false;
			this.cmb_LineCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_LineCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_LineCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_LineCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_LineCd.Size = new System.Drawing.Size(115, 21);
			this.cmb_LineCd.TabIndex = 35;
			this.cmb_LineCd.SelectedValueChanged += new System.EventHandler(this.cmb_LineCd_SelectedValueChanged);
			// 
			// dpick_PlanYMD
			// 
			this.dpick_PlanYMD.CustomFormat = "yyyyMMdd";
			this.dpick_PlanYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.dpick_PlanYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_PlanYMD.Location = new System.Drawing.Point(278, 36);
			this.dpick_PlanYMD.Name = "dpick_PlanYMD";
			this.dpick_PlanYMD.Size = new System.Drawing.Size(115, 22);
			this.dpick_PlanYMD.TabIndex = 197;
			this.dpick_PlanYMD.Value = new System.DateTime(2005, 10, 6, 13, 44, 5, 151);
			this.dpick_PlanYMD.ValueChanged += new System.EventHandler(this.dpick_PlanYMD_ValueChanged);
			// 
			// lbl_MLineCd
			// 
			this.lbl_MLineCd.ImageIndex = 0;
			this.lbl_MLineCd.ImageList = this.img_Label;
			this.lbl_MLineCd.Location = new System.Drawing.Point(561, 36);
			this.lbl_MLineCd.Name = "lbl_MLineCd";
			this.lbl_MLineCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_MLineCd.TabIndex = 42;
			this.lbl_MLineCd.Text = "Mini Line";
			this.lbl_MLineCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_MLineCd
			// 
			this.cmb_MLineCd.AddItemCols = 0;
			this.cmb_MLineCd.AddItemSeparator = ';';
			this.cmb_MLineCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_MLineCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_MLineCd.Caption = "";
			this.cmb_MLineCd.CaptionHeight = 17;
			this.cmb_MLineCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_MLineCd.ColumnCaptionHeight = 18;
			this.cmb_MLineCd.ColumnFooterHeight = 18;
			this.cmb_MLineCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_MLineCd.ContentHeight = 17;
			this.cmb_MLineCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_MLineCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_MLineCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_MLineCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_MLineCd.EditorHeight = 17;
			this.cmb_MLineCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_MLineCd.GapHeight = 2;
			this.cmb_MLineCd.ItemHeight = 15;
			this.cmb_MLineCd.Location = new System.Drawing.Point(662, 36);
			this.cmb_MLineCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_MLineCd.MaxDropDownItems = ((short)(5));
			this.cmb_MLineCd.MaxLength = 32767;
			this.cmb_MLineCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_MLineCd.Name = "cmb_MLineCd";
			this.cmb_MLineCd.PartialRightColumn = false;
			this.cmb_MLineCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_MLineCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_MLineCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_MLineCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_MLineCd.Size = new System.Drawing.Size(110, 21);
			this.cmb_MLineCd.TabIndex = 43;
			this.cmb_MLineCd.SelectedValueChanged += new System.EventHandler(this.cmb_MLineCd_SelectedValueChanged);
			// 
			// lbl_OpStrYMD
			// 
			this.lbl_OpStrYMD.ImageIndex = 0;
			this.lbl_OpStrYMD.ImageList = this.img_Label;
			this.lbl_OpStrYMD.Location = new System.Drawing.Point(177, 36);
			this.lbl_OpStrYMD.Name = "lbl_OpStrYMD";
			this.lbl_OpStrYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_OpStrYMD.TabIndex = 40;
			this.lbl_OpStrYMD.Text = "Plan Date";
			this.lbl_OpStrYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.Size = new System.Drawing.Size(115, 21);
			this.cmb_Factory.TabIndex = 33;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_SmallLabel;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(50, 21);
			this.lbl_Factory.TabIndex = 32;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(985, 24);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(15, 25);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(984, 0);
			this.picb_TR.Name = "picb_TR";
			this.picb_TR.Size = new System.Drawing.Size(16, 32);
			this.picb_TR.TabIndex = 21;
			this.picb_TR.TabStop = false;
			// 
			// picb_TM
			// 
			this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
			this.picb_TM.Location = new System.Drawing.Point(224, 0);
			this.picb_TM.Name = "picb_TM";
			this.picb_TM.Size = new System.Drawing.Size(776, 32);
			this.picb_TM.TabIndex = 0;
			this.picb_TM.TabStop = false;
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
			this.lbl_SubTitle1.Text = "      Selected Information";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(984, 49);
			this.picb_BR.Name = "picb_BR";
			this.picb_BR.Size = new System.Drawing.Size(16, 16);
			this.picb_BR.TabIndex = 23;
			this.picb_BR.TabStop = false;
			// 
			// picb_BM
			// 
			this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
			this.picb_BM.Location = new System.Drawing.Point(144, 47);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(840, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 45);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(168, 20);
			this.picb_BL.TabIndex = 22;
			this.picb_BL.TabStop = false;
			// 
			// picb_ML
			// 
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 24);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(168, 25);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// picb_MM
			// 
			this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
			this.picb_MM.Location = new System.Drawing.Point(160, 24);
			this.picb_MM.Name = "picb_MM";
			this.picb_MM.Size = new System.Drawing.Size(832, 25);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// Form_PD_MiniSize_TS_Search
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_B);
			this.Name = "Form_PD_MiniSize_TS_Search";
			this.Text = "Time Sequence";
			this.Load += new System.EventHandler(this.Form_PD_MiniSize_TS_Search_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_B, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_B.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_TS)).EndInit();
			this.pnl_BT.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_OpCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LineCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_MLineCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의 

		
		private COM.OraDB MyOraDB = new COM.OraDB(); 
		private COM.ComFunction MyComFunction = new COM.ComFunction();

		//사이즈 헤더 그리기 위함
		private int _Rowfixed; 

		//파라미터로 넘어오는 값 
		private string _Factory, _PlanYMD, _Line, _MLine, _OpCd;


		#endregion

		#region 멤버 메서드
 

		/// <summary>
		/// Init_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			DataTable dt_ret;

			//Title
			this.Text = "Time Sequence";
			this.lbl_MainTitle.Text = "Time Sequence"; 

			ClassLib.ComFunction.SetLangDic(this);
 
			tbtn_Save.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Color.Enabled = false;
 

			dpick_PlanYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;


			fgrid_TS.Set_Grid("SPD_DMINI_SIZE_TS", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_TS.ExtendLastCol = false;
			fgrid_TS.AllowEditing = false;
			fgrid_TS.AllowSorting = AllowSortingEnum.None;
			fgrid_TS.Font = new Font("Verdana", 7);
			fgrid_TS.Styles.Alternate.BackColor = Color.White;
			_Rowfixed = fgrid_TS.Rows.Fixed; 


			_Factory = ClassLib.ComVar.Parameter_PopUp[0];
			_Line = ClassLib.ComVar.Parameter_PopUp[1];
			_PlanYMD = ClassLib.ComVar.Parameter_PopUp[2]; 
			_OpCd = ClassLib.ComVar.Parameter_PopUp[3]; 
			_MLine = ClassLib.ComVar.Parameter_PopUp[4]; 
 
			// Factory Combobox Add Items
			dt_ret = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
   
			 
			if(ClassLib.ComVar.This_FormDate == "") ClassLib.ComVar.This_FormDate = _PlanYMD;
				 
			dpick_PlanYMD.Text = MyComFunction.ConvertDate2Type(_PlanYMD);
			cmb_Factory.SelectedValue = _Factory;
 


		}



		/// <summary>
		/// Set_Default_SizeHead : 사이즈 문대 모두 표시 
		/// </summary>
		/// <param name="arg_fgrid"></param>
		private void Set_Default_SizeHead(COM.FSP arg_fgrid)
		{
			DataTable dt_gen; 
			DataTable dt_size;

			try
			{
				string[] new_data = new string[(int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxGEN + 1]; 
			
				int size_count = 0; 

				arg_fgrid.Rows.Count = _Rowfixed;
				arg_fgrid.Cols.Count = (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxGEN + 1;
				arg_fgrid.Rows[1].Visible = false; 

				//------------------------------------------------
				//젠더 표시 
				dt_gen = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxGen);  
 
				new_data[0] = "";

				for(int i = 0; i < dt_gen.Rows.Count; i++)
				{
					for(int j = 1; j < (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxGEN; j++)
					{
						new_data[j] = arg_fgrid[1, j].ToString();
					}  

					new_data[(int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxTOT_QTY] = "";
					new_data[(int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxGEN] = dt_gen.Rows[i].ItemArray[(int)COM.TBSCM_CODE.IxCOM_VALUE2].ToString();

					arg_fgrid.AddItem(new_data, arg_fgrid.Rows.Count, 0);
					arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].TextAlign = TextAlignEnum.CenterCenter;


				} // end for i
 
			    arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxTOT_QTY] = "Qty.";
				arg_fgrid.Rows.Fixed = dt_gen.Rows.Count + _Rowfixed;
  
				//------------------------------------------------
				//사이즈 문대 표시 
				for(int i = _Rowfixed; i < arg_fgrid.Rows.Count; i++) 
				{
					dt_size = Select_Gen_Size(arg_fgrid[i, (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxGEN].ToString());   

					//------------------------------------------------------
					//젠더 중 제일 긴 사이즈 문대 갯수만큼 그리드 컬럼 조절
					size_count = dt_size.Rows.Count + (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxCS_SIZE_START;

					if(size_count > arg_fgrid.Cols.Count) arg_fgrid.Cols.Count = size_count; 

					//------------------------------------------------------
					//문대 표시
					for(int j = 0; j < dt_size.Rows.Count; j++)
					{
						arg_fgrid.Cols[(int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxCS_SIZE_START + j].Width = 45; 
						arg_fgrid[i, (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxCS_SIZE_START + j] = dt_size.Rows[j].ItemArray[0].ToString();
 
					} // end for j 
				}  // end for i 
			 
				//------------------------------------------------------
				for(int i = _Rowfixed; i < arg_fgrid.Rows.Count; i++) 
				{
					for(int j = (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxCS_SIZE_START; j < arg_fgrid.Cols.Count; j++)
					{
						if(arg_fgrid[i, j] == null) arg_fgrid[i, j] = "x";
					}
				}
				//------------------------------------------------------

				arg_fgrid.Cols.Frozen = (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxCS_SIZE_START;
				arg_fgrid.AutoSizeCols(1, (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxGEN, 2);
 

			}
			catch
			{
			}
		}


		/// <summary>
		/// Display_WorkSheet : 사이즈 데이터 표시
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Grid(DataTable arg_dt)
		{  
			string before_item = "", now_item = "";
			int gen_row = 0;  
			string sel_gen = "";

			try
			{ 
				fgrid_TS.Rows.Count = fgrid_TS.Rows.Fixed;

				if(arg_dt.Rows.Count == 0) return; 
  
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{ 
					now_item = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxTBLINE_CD].ToString()
						+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxTBMLINE_CD].ToString()
						+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxTBLOT].ToString()
						+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxTBDAY_SEQ].ToString()
						+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxTBINPUT_PRIO].ToString(); 
					  
					if(before_item != now_item)
					{  
						fgrid_TS.Rows.Add(); 
						 
						fgrid_TS[fgrid_TS.Rows.Count - 1, 0] = ""; 
  
						 for(int a = (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxLINE_CD; a <= (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxGEN; a++)
						{ 
							fgrid_TS[fgrid_TS.Rows.Count - 1, a] = arg_dt.Rows[i].ItemArray[a - 1].ToString();
						}
						
						 
					 
						//--------------------------------------------------------------------
						//gen
						for(int j = 1; j <= fgrid_TS.Rows.Fixed; j++)
						{
							if(fgrid_TS[j, (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxGEN].ToString() == arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxTBGEN].ToString())
							{
								gen_row = j;
								sel_gen = sel_gen + "/" + fgrid_TS[gen_row, (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxGEN].ToString();

								break;
							} 
						}

						before_item = now_item;  
						

					}

					//사이즈별 수량 표시
					for(int j = (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxCS_SIZE_START; j < fgrid_TS.Cols.Count; j++)
					{
						if(fgrid_TS[gen_row, j].ToString() == arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxTBCS_SIZE].ToString())
						{
							if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxTBINPUT_QTY].ToString() == "0") continue;

							fgrid_TS[fgrid_TS.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxTBINPUT_QTY].ToString();
					
							break;  
						} 
					} 
   
 
 
				} // end for i

				//--------------------------------------------------------------
				//LOT에 대한 젠더만 표시
				string[] token = sel_gen.Split('/');

				for(int i = _Rowfixed; i < fgrid_TS.Rows.Fixed; i++) 
					fgrid_TS.Rows[i].Visible = false;   

				for(int i = _Rowfixed; i < fgrid_TS.Rows.Fixed; i++) 
				{
					for(int j = 0; j < token.Length; j++)
					{
						if(fgrid_TS[i, (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxGEN].ToString() == token[j])
						{
							fgrid_TS.Rows[i].Visible = true; 
							break;
						} 
					} // end for j 
				} // end for i

				 
				//--------------------------------------------------------------
				//기타 속성
				// 1. Merge
				fgrid_TS.AllowMerging = AllowMergingEnum.Free;
 
				fgrid_TS.Cols[(int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxTOT_QTY].AllowMerging = false;

				for(int i = (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxCS_SIZE_START; i < fgrid_TS.Cols.Count; i++)
					fgrid_TS.Cols[i].AllowMerging = false;
    

				//2. SubTotals
				//2-1. col별 
				fgrid_TS.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;
				fgrid_TS.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;
				fgrid_TS.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrSubTotal1;
				fgrid_TS.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black; 
				fgrid_TS.Styles[CellStyleEnum.Subtotal2].BackColor = ClassLib.ComVar.ClrSubTotal2;
				fgrid_TS.Styles[CellStyleEnum.Subtotal2].ForeColor = Color.Black;

				fgrid_TS.Tree.Column = (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxMODEL_NAME;
				fgrid_TS.Subtotal(AggregateEnum.Clear); 
				fgrid_TS.SubtotalPosition = SubtotalPositionEnum.BelowData;

				for (int i = (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxCS_SIZE_START; i < fgrid_TS.Cols.Count; i++) 
					fgrid_TS.Subtotal(AggregateEnum.Sum, 1, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH.IxMLINE_CD, i, "Mini Line Sum.");

				for (int i = (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxCS_SIZE_START; i < fgrid_TS.Cols.Count; i++) 
					fgrid_TS.Subtotal(AggregateEnum.Sum, 0, (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxLINE_CD, i, "Line Sum.");
 
//				for (int i = (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxCS_SIZE_START; i < fgrid_TS.Cols.Count; i++) 
//					fgrid_TS.Subtotal(AggregateEnum.Sum, 0, -1, i, "Total");

				//2-2 row별
				Set_SubTotals(); 
				
				//3. AutoSizeCols
				fgrid_TS.AutoSizeCols(1, (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxGEN, 2);


			}
			catch
			{
			}

		}

		/// <summary>
		/// Set_SubTotals: 
		/// </summary>
		private void Set_SubTotals()
		{
			int sumrow = 0;

			try
			{
				for(int i = fgrid_TS.Rows.Fixed; i < fgrid_TS.Rows.Count; i++)
				{
					
					for(int j = (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxCS_SIZE_START; j < fgrid_TS.Cols.Count; j++)
					{
						if(fgrid_TS[i, j] == null || fgrid_TS[i, j].ToString() == "") continue;

						sumrow += Convert.ToInt32(fgrid_TS[i, j].ToString() );
					}

					fgrid_TS[i, (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxTOT_QTY] = sumrow.ToString();
					sumrow = 0;

				}

			}
			catch
			{
			}
		}


		#endregion

		#region 이벤트 처리 

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				fgrid_TS.Rows.Count = fgrid_TS.Rows.Fixed;
			}
			catch
			{
			}
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_ret;  

			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_LineCd.SelectedIndex == -1 || dpick_PlanYMD.CustomFormat == " ") return;

				dt_ret = Select_LOT_DAILY_SIZE_TS(); 
				Display_Grid(dt_ret);  
				 
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
				if(cmb_Factory.SelectedIndex == -1) return;

				cmb_LineCd.SelectedIndex = -1; 
				cmb_MLineCd.SelectedIndex = -1;
				cmb_OpCd.SelectedIndex = -1; 
 

				//사이즈 헤더 표시 
				Set_Default_SizeHead(fgrid_TS); 
 
 
				dt_ret = Select_SPB_LINE();
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LineCd, 1, 2, false, COM.ComVar.ComboList_Visible.Name);
				cmb_LineCd.SelectedValue = _Line;  

 
			}
			catch
			{
			} 
		}

		private void dpick_PlanYMD_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				dpick_PlanYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
				COM.ComFunction comfunc = new COM.ComFunction();
				ClassLib.ComVar.This_FormDate = comfunc.ConvertDate2DbType(dpick_PlanYMD.Text);
			}
			catch
			{
			}
		}

		private void cmb_LineCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_LineCd.SelectedIndex == -1) return;

				fgrid_TS.Rows.Count = fgrid_TS.Rows.Fixed;  
				cmb_MLineCd.SelectedIndex = -1;
				cmb_OpCd.SelectedIndex = -1;  
 				 
				dt_ret = Select_SPO_LOT_DMINI_OPCD(); 
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OpCd, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 
				cmb_OpCd.SelectedValue = _OpCd;
  
			}
			catch
			{
			}
		}


		private void cmb_OpCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;  
		
			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_LineCd.SelectedIndex == -1 || cmb_OpCd.SelectedIndex == -1) return;
  
				fgrid_TS.Rows.Count = fgrid_TS.Rows.Fixed; 

				dt_ret = Select_SPB_LINEOP_MINI_MLINECD();
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MLineCd, 0, 1, true, COM.ComVar.ComboList_Visible.Name); 
				cmb_MLineCd.SelectedValue = _MLine; 
			}
			catch
			{
			} 
		}


		private void cmb_MLineCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				//tbtn_Search_Click(null, null);
			}
			catch
			{
			}
		}


		//선택되어졌던 젠더 행, 컬럼
		private int _BeforeGenRow = -1;

		
		private void fgrid_TS_Click(object sender, System.EventArgs e)
		{
			int findrow = 0;    

			try
			{ 
				if(fgrid_TS.Rows.Count <= fgrid_TS.Rows.Fixed) return;

				//----------------------------------------------------------------------
				//선택한 젠더 Row 표시
				int sel_row = fgrid_TS.Selection.r1;
				string sel_gen = fgrid_TS[sel_row, (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxGEN].ToString();

				findrow = fgrid_TS.FindRow(sel_gen, _Rowfixed, (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxGEN, false, true, false);

				if(findrow == -1) return;

				fgrid_TS.GetCellRange(findrow, (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxGEN, findrow, fgrid_TS.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrSel_Yellow; 
				fgrid_TS.GetCellRange(findrow, (int)ClassLib.TBSPD_LOT_DMINI_SIZE_TS_SEARCH.IxGEN, findrow, fgrid_TS.Cols.Count - 1).StyleNew.ForeColor = Color.Black;

				
				if(_BeforeGenRow != -1 && _BeforeGenRow != findrow) 
					fgrid_TS.GetCellRange(_BeforeGenRow, (int)ClassLib.TBSPD_LOT_DAILY_MINI_SIZE_TS.IxGEN, _BeforeGenRow, fgrid_TS.Cols.Count - 1).StyleNew.Clear(); 

				_BeforeGenRow = findrow; 

			}
			catch
			{
			}
		
		}


		#endregion

		#region DB Connect

		/// <summary>
		/// Select_SPB_LINE : 라인 리스트 가져오기
		/// </summary>
		private DataTable Select_SPB_LINE()
		{
			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPB_LINE.SELECT_LINE_LIST";

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

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			} 
		}
	 

		/// <summary>
		/// Select_SPO_LOT_DMINI_OPCD : SPB_LINEOP 의 라인별 공정 정보 리스트
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SPO_LOT_DMINI_OPCD()
		{
			DataSet ds_ret; 
 
			try
			{ 
				MyOraDB.ReDim_Parameter(2);  
				MyOraDB.Process_Name = "PKG_SPB_OPCD.SELECT_SPB_OPCD_CMB";  //"PKG_SPB_OPCD.SELECT_SPB_OPCD_H";
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = "";

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ;
				return ds_ret.Tables[MyOraDB.Process_Name]; 
			}
			catch
			{
				return null;
			}
		}
 

		/// <summary>
		/// Select_SPB_LINEOP_MINI_MLINECD : SPB_LINEOP_MINI 의 라인별 미니라인 정보 리스트
		/// </summary>
		private DataTable Select_SPB_LINEOP_MINI_MLINECD()
		{
			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPD_DAILY_BSC.SELECT_SPB_LINEOP_MINI_MLINECD";

				MyOraDB.ReDim_Parameter(4); 

				MyOraDB.Process_Name = process_name;
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_LINE_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_OP_CD"; 
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = cmb_LineCd.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[2] = cmb_OpCd.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[3] = ""; 

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
 
		
		/// <summary>
		/// Select_Gen_Size : 젠더에 따른 사이즈 문대 리스트
		/// </summary>
		/// <param name="arg_gen"></param>
		/// <returns></returns>
		private DataTable Select_Gen_Size(string arg_gen)
		{
			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPO_ORDER_BSC.SELECT_GEN_SIZE";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_GEN";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = arg_gen;
				MyOraDB.Parameter_Values[2] = ""; 

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
 

		/// <summary>
		/// Select_LOT_DAILY_SIZE_TS :  
		/// </summary>
		/// <param name="arg_gen"></param>
		/// <returns></returns>
		private DataTable Select_LOT_DAILY_SIZE_TS()
		{
			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPD_DAILY_BSC.SELECT_SPD_MINI_TS_SIZE_SEARCH";

				MyOraDB.ReDim_Parameter(6); 
 
				MyOraDB.Process_Name = process_name; 
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_PLAN_YMD";
				MyOraDB.Parameter_Name[3] = "ARG_OP_CD"; 
				MyOraDB.Parameter_Name[4] = "ARG_MLINE_CD";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = cmb_LineCd.SelectedValue.ToString();
				MyOraDB.Parameter_Values[2] = MyComFunction.ConvertDate2DbType(dpick_PlanYMD.Text);
				MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(cmb_OpCd, " "); 
				MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_Combo(cmb_MLineCd, " "); 
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


		
		private void Form_PD_MiniSize_TS_Search_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		
		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{


			this.Cursor = Cursors.WaitCursor;



			if(fgrid_TS.Rows.Count < _Rowfixed+2) return;


			string filename = this.Name + ".txt";
			FileInfo file = new FileInfo(filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}

			file = null;


			fgrid_TS.SaveGrid( filename, FileFormatEnum.TextComma);

			
			string mini = cmb_MLineCd.Columns[1].Text;

			if(cmb_MLineCd.SelectedIndex == 0)
			{
				mini = "ALL";
			}
			

			string para = "/rfn [" + Application.StartupPath + @"\" + this.Name + ".txt] /rv V_SDATE["+ dpick_PlanYMD.Text +"] V_LINE[" + cmb_LineCd.Columns[1].Text 
				+ "] V_MINI[" + mini + "]";

			COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report(this.Text, this.Name +".mrd", para);
			report.ShowDialog();

			this.Cursor = Cursors.Default;

		
		}

		

		
		
	}
}

