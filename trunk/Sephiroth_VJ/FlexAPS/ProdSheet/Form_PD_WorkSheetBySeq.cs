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
	public class Form_PD_WorkSheetBySeq : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.Panel pnl_B;
		private COM.FSP fgrid_WorkSheet;
		public System.Windows.Forms.Panel pnl_BT;
		public System.Windows.Forms.Panel pnl_SearchImage;
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
		private System.Windows.Forms.Label lbl_MLineCd;
		private C1.Win.C1List.C1Combo cmb_MLineCd;
		private System.Windows.Forms.Label lbl_CmpCd;
		private C1.Win.C1List.C1Combo cmb_CmpCd;
		private C1.Win.C1List.C1Combo cmb_LineGroup;
		private System.Windows.Forms.Label lbl_LineGroup;
		public System.Windows.Forms.DateTimePicker dpick_PlanYMD;
		private C1.Win.C1List.C1Combo cmb_Area;
		private System.Windows.Forms.Label lbl_Area;
		private System.ComponentModel.IContainer components = null;


		#endregion

		#region 생성자, 소멸자


		public Form_PD_WorkSheetBySeq()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PD_WorkSheetBySeq));
			this.pnl_B = new System.Windows.Forms.Panel();
			this.fgrid_WorkSheet = new COM.FSP();
			this.pnl_BT = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.cmb_Area = new C1.Win.C1List.C1Combo();
			this.lbl_Area = new System.Windows.Forms.Label();
			this.dpick_PlanYMD = new System.Windows.Forms.DateTimePicker();
			this.cmb_LineGroup = new C1.Win.C1List.C1Combo();
			this.lbl_LineGroup = new System.Windows.Forms.Label();
			this.cmb_CmpCd = new C1.Win.C1List.C1Combo();
			this.lbl_CmpCd = new System.Windows.Forms.Label();
			this.lbl_MLineCd = new System.Windows.Forms.Label();
			this.cmb_MLineCd = new C1.Win.C1List.C1Combo();
			this.lbl_OpCd = new System.Windows.Forms.Label();
			this.cmb_OpCd = new C1.Win.C1List.C1Combo();
			this.lbl_OpStrYMD = new System.Windows.Forms.Label();
			this.cmb_LineCd = new C1.Win.C1List.C1Combo();
			this.lbl_Line = new System.Windows.Forms.Label();
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
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_B.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_WorkSheet)).BeginInit();
			this.pnl_BT.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Area)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LineGroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_CmpCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_MLineCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OpCd)).BeginInit();
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
			// pnl_B
			// 
			this.pnl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_B.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_B.Controls.Add(this.fgrid_WorkSheet);
			this.pnl_B.Controls.Add(this.pnl_BT);
			this.pnl_B.DockPadding.All = 8;
			this.pnl_B.Location = new System.Drawing.Point(0, 64);
			this.pnl_B.Name = "pnl_B";
			this.pnl_B.Size = new System.Drawing.Size(1016, 576);
			this.pnl_B.TabIndex = 30;
			// 
			// fgrid_WorkSheet
			// 
			this.fgrid_WorkSheet.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_WorkSheet.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_WorkSheet.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_WorkSheet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_WorkSheet.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_WorkSheet.Location = new System.Drawing.Point(8, 98);
			this.fgrid_WorkSheet.Name = "fgrid_WorkSheet";
			this.fgrid_WorkSheet.Size = new System.Drawing.Size(1000, 470);
			this.fgrid_WorkSheet.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:137, 179, 234;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:Lavender;ForeColor:Black;}	Subtotal2{BackColor:217, 250, 216;ForeColor:Black;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_WorkSheet.TabIndex = 43;
			this.fgrid_WorkSheet.Click += new System.EventHandler(this.fgrid_WorkSheet_Click);
			// 
			// pnl_BT
			// 
			this.pnl_BT.BackColor = System.Drawing.Color.Transparent;
			this.pnl_BT.Controls.Add(this.pnl_SearchImage);
			this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_BT.DockPadding.Bottom = 5;
			this.pnl_BT.Location = new System.Drawing.Point(8, 8);
			this.pnl_BT.Name = "pnl_BT";
			this.pnl_BT.Size = new System.Drawing.Size(1000, 90);
			this.pnl_BT.TabIndex = 42;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.cmb_Area);
			this.pnl_SearchImage.Controls.Add(this.lbl_Area);
			this.pnl_SearchImage.Controls.Add(this.dpick_PlanYMD);
			this.pnl_SearchImage.Controls.Add(this.cmb_LineGroup);
			this.pnl_SearchImage.Controls.Add(this.lbl_LineGroup);
			this.pnl_SearchImage.Controls.Add(this.cmb_CmpCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_CmpCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_MLineCd);
			this.pnl_SearchImage.Controls.Add(this.cmb_MLineCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_OpCd);
			this.pnl_SearchImage.Controls.Add(this.cmb_OpCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_OpStrYMD);
			this.pnl_SearchImage.Controls.Add(this.cmb_LineCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_Line);
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
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 85);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// cmb_Area
			// 
			this.cmb_Area.AddItemCols = 0;
			this.cmb_Area.AddItemSeparator = ';';
			this.cmb_Area.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Area.Caption = "";
			this.cmb_Area.CaptionHeight = 17;
			this.cmb_Area.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Area.ColumnCaptionHeight = 18;
			this.cmb_Area.ColumnFooterHeight = 18;
			this.cmb_Area.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Area.ContentHeight = 17;
			this.cmb_Area.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Area.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Area.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Area.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Area.EditorHeight = 17;
			this.cmb_Area.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Area.GapHeight = 2;
			this.cmb_Area.ItemHeight = 15;
			this.cmb_Area.Location = new System.Drawing.Point(825, 58);
			this.cmb_Area.MatchEntryTimeout = ((long)(2000));
			this.cmb_Area.MaxDropDownItems = ((short)(5));
			this.cmb_Area.MaxLength = 32767;
			this.cmb_Area.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Area.Name = "cmb_Area";
			this.cmb_Area.PartialRightColumn = false;
			this.cmb_Area.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Area.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Area.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Area.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Area.Size = new System.Drawing.Size(115, 21);
			this.cmb_Area.TabIndex = 297;
			// 
			// lbl_Area
			// 
			this.lbl_Area.ImageIndex = 0;
			this.lbl_Area.ImageList = this.img_Label;
			this.lbl_Area.Location = new System.Drawing.Point(724, 58);
			this.lbl_Area.Name = "lbl_Area";
			this.lbl_Area.Size = new System.Drawing.Size(100, 21);
			this.lbl_Area.TabIndex = 296;
			this.lbl_Area.Text = "Area";
			this.lbl_Area.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_PlanYMD
			// 
			this.dpick_PlanYMD.CustomFormat = "yyyyMMdd";
			this.dpick_PlanYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.dpick_PlanYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_PlanYMD.Location = new System.Drawing.Point(111, 58);
			this.dpick_PlanYMD.Name = "dpick_PlanYMD";
			this.dpick_PlanYMD.Size = new System.Drawing.Size(117, 22);
			this.dpick_PlanYMD.TabIndex = 295;
			this.dpick_PlanYMD.ValueChanged += new System.EventHandler(this.dpick_PlanYMD_ValueChanged);
			// 
			// cmb_LineGroup
			// 
			this.cmb_LineGroup.AddItemCols = 0;
			this.cmb_LineGroup.AddItemSeparator = ';';
			this.cmb_LineGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_LineGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_LineGroup.Caption = "";
			this.cmb_LineGroup.CaptionHeight = 17;
			this.cmb_LineGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_LineGroup.ColumnCaptionHeight = 18;
			this.cmb_LineGroup.ColumnFooterHeight = 18;
			this.cmb_LineGroup.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_LineGroup.ContentHeight = 17;
			this.cmb_LineGroup.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_LineGroup.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_LineGroup.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LineGroup.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_LineGroup.EditorHeight = 17;
			this.cmb_LineGroup.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LineGroup.GapHeight = 2;
			this.cmb_LineGroup.ItemHeight = 15;
			this.cmb_LineGroup.Location = new System.Drawing.Point(349, 36);
			this.cmb_LineGroup.MatchEntryTimeout = ((long)(2000));
			this.cmb_LineGroup.MaxDropDownItems = ((short)(5));
			this.cmb_LineGroup.MaxLength = 32767;
			this.cmb_LineGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_LineGroup.Name = "cmb_LineGroup";
			this.cmb_LineGroup.PartialRightColumn = false;
			this.cmb_LineGroup.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_LineGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_LineGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_LineGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_LineGroup.Size = new System.Drawing.Size(115, 21);
			this.cmb_LineGroup.TabIndex = 198;
			this.cmb_LineGroup.SelectedValueChanged += new System.EventHandler(this.cmb_LineGroup_SelectedValueChanged);
			// 
			// lbl_LineGroup
			// 
			this.lbl_LineGroup.ImageIndex = 0;
			this.lbl_LineGroup.ImageList = this.img_Label;
			this.lbl_LineGroup.Location = new System.Drawing.Point(248, 36);
			this.lbl_LineGroup.Name = "lbl_LineGroup";
			this.lbl_LineGroup.Size = new System.Drawing.Size(100, 21);
			this.lbl_LineGroup.TabIndex = 197;
			this.lbl_LineGroup.Text = "Line Group";
			this.lbl_LineGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_CmpCd.Location = new System.Drawing.Point(589, 58);
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_CmpCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_CmpCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_CmpCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_CmpCd.Size = new System.Drawing.Size(115, 21);
			this.cmb_CmpCd.TabIndex = 196;
			this.cmb_CmpCd.SelectedValueChanged += new System.EventHandler(this.cmb_CmpCd_SelectedValueChanged);
			// 
			// lbl_CmpCd
			// 
			this.lbl_CmpCd.ImageIndex = 0;
			this.lbl_CmpCd.ImageList = this.img_Label;
			this.lbl_CmpCd.Location = new System.Drawing.Point(488, 58);
			this.lbl_CmpCd.Name = "lbl_CmpCd";
			this.lbl_CmpCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_CmpCd.TabIndex = 195;
			this.lbl_CmpCd.Text = "Component";
			this.lbl_CmpCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_MLineCd
			// 
			this.lbl_MLineCd.ImageIndex = 0;
			this.lbl_MLineCd.ImageList = this.img_Label;
			this.lbl_MLineCd.Location = new System.Drawing.Point(724, 36);
			this.lbl_MLineCd.Name = "lbl_MLineCd";
			this.lbl_MLineCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_MLineCd.TabIndex = 42;
			this.lbl_MLineCd.Text = "MiniLine";
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
			this.cmb_MLineCd.Location = new System.Drawing.Point(825, 36);
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_MLineCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_MLineCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_MLineCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_MLineCd.Size = new System.Drawing.Size(115, 21);
			this.cmb_MLineCd.TabIndex = 43;
			this.cmb_MLineCd.SelectedValueChanged += new System.EventHandler(this.cmb_MLineCd_SelectedValueChanged);
			// 
			// lbl_OpCd
			// 
			this.lbl_OpCd.ImageIndex = 0;
			this.lbl_OpCd.ImageList = this.img_Label;
			this.lbl_OpCd.Location = new System.Drawing.Point(248, 58);
			this.lbl_OpCd.Name = "lbl_OpCd";
			this.lbl_OpCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_OpCd.TabIndex = 38;
			this.lbl_OpCd.Text = "Proc";
			this.lbl_OpCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_OpCd.Location = new System.Drawing.Point(349, 58);
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_OpCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OpCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OpCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OpCd.Size = new System.Drawing.Size(115, 21);
			this.cmb_OpCd.TabIndex = 39;
			this.cmb_OpCd.SelectedValueChanged += new System.EventHandler(this.cmb_OpCd_SelectedValueChanged);
			// 
			// lbl_OpStrYMD
			// 
			this.lbl_OpStrYMD.ImageIndex = 0;
			this.lbl_OpStrYMD.ImageList = this.img_Label;
			this.lbl_OpStrYMD.Location = new System.Drawing.Point(10, 58);
			this.lbl_OpStrYMD.Name = "lbl_OpStrYMD";
			this.lbl_OpStrYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_OpStrYMD.TabIndex = 40;
			this.lbl_OpStrYMD.Text = "Dir. Date";
			this.lbl_OpStrYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_LineCd.Location = new System.Drawing.Point(589, 36);
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_LineCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_LineCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_LineCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_LineCd.Size = new System.Drawing.Size(115, 21);
			this.cmb_LineCd.TabIndex = 35;
			this.cmb_LineCd.SelectedValueChanged += new System.EventHandler(this.cmb_LineCd_SelectedValueChanged);
			// 
			// lbl_Line
			// 
			this.lbl_Line.ImageIndex = 0;
			this.lbl_Line.ImageList = this.img_Label;
			this.lbl_Line.Location = new System.Drawing.Point(488, 36);
			this.lbl_Line.Name = "lbl_Line";
			this.lbl_Line.Size = new System.Drawing.Size(100, 21);
			this.lbl_Line.TabIndex = 34;
			this.lbl_Line.Text = "Line";
			this.lbl_Line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.Size = new System.Drawing.Size(115, 21);
			this.cmb_Factory.TabIndex = 33;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
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
			this.picb_MR.Size = new System.Drawing.Size(15, 45);
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
			this.picb_BR.Location = new System.Drawing.Point(984, 69);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 67);
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
			this.picb_BL.Location = new System.Drawing.Point(0, 65);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(168, 20);
			this.picb_BL.TabIndex = 22;
			this.picb_BL.TabStop = false;
			// 
			// picb_ML
			// 
			this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 24);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(168, 48);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// picb_MM
			// 
			this.picb_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
			this.picb_MM.Location = new System.Drawing.Point(160, 24);
			this.picb_MM.Name = "picb_MM";
			this.picb_MM.Size = new System.Drawing.Size(832, 48);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Form_PD_WorkSheetBySeq
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_B);
			this.Name = "Form_PD_WorkSheetBySeq";
			this.Text = "Daily WorkSheet By Sequence ";
			this.Load += new System.EventHandler(this.Form_PD_WorkSheetBySeq_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_B, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_B.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_WorkSheet)).EndInit();
			this.pnl_BT.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Area)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LineGroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_CmpCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_MLineCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OpCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LineCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion  

		#region 변수 정의

 
		private COM.OraDB MyOraDB = new COM.OraDB();  
		private COM.ComFunction MyComFunction = new COM.ComFunction();
 


		private string _SelCmpCd = "";
		private string _SelOpCd = ""; 
		private string _SelArea = "";



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
				this.Text = "Daily WorkSheet By Sequence";
				lbl_MainTitle.Text = "Daily WorkSheet By Sequence";
 

				fgrid_WorkSheet.Set_Grid("SPD_DAILY_WORKSHEET_TS_BSC", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
				fgrid_WorkSheet.ExtendLastCol = false;
				fgrid_WorkSheet.AllowEditing = false;
				fgrid_WorkSheet.Font = new Font("Verdana", 7);
				fgrid_WorkSheet.AllowSorting = AllowSortingEnum.None;
				fgrid_WorkSheet.AllowDragging = AllowDraggingEnum.None;



				Init_Control();


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
  

			dpick_PlanYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			
			if(ClassLib.ComVar.This_FormDate != "") 
			{
				dpick_PlanYMD.Text = MyComFunction.ConvertDate2Type(ClassLib.ComVar.This_FormDate); 
			} 



			// Factory Combobox Add Items
			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
			dt_ret.Dispose();

			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory; 



		}  



		#endregion
		  
		#region 조회


		/// <summary>
		/// Display_Data : 
		/// </summary>
		private void Display_WorkSheet()
		{


			string before_item = "", now_item = ""; 
			int gen_row = 0;   
			string sel_gen = "";
			int min_size_col = fgrid_WorkSheet.Cols.Count + 1;   //default : col max value
			int size_qty = 0, sum_size_qty = 0;
 

			string factory = cmb_Factory.SelectedValue.ToString(); 
			string line_group = ClassLib.ComFunction.Empty_Combo(cmb_LineGroup, " ");
			string line_cd = ClassLib.ComFunction.Empty_Combo(cmb_LineCd, " ");
			string op_str_ymd = dpick_PlanYMD.Value.ToString("yyyyMMdd");
			string cmp_cd = ClassLib.ComFunction.Empty_Combo(cmb_CmpCd, " ");
			string op_cd = ClassLib.ComFunction.Empty_Combo(cmb_OpCd, " ");
			string mline_cd = ClassLib.ComFunction.Empty_Combo(cmb_MLineCd, " ");
			string mat_area = ClassLib.ComFunction.Empty_Combo(cmb_Area, " ");


			DataTable dt_ret = Select_SPD_DAILY_WORKSHEET_TS(factory, line_group, line_cd, op_str_ymd, cmp_cd, op_cd, mline_cd, mat_area);
 


			fgrid_WorkSheet.Rows.Count = fgrid_WorkSheet.Rows.Fixed;  

			if(dt_ret.Rows.Count == 0) 
			{ 
				return; 
			}


  
			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
      	 
				
				now_item = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxLINE_CD - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxMLINE_CD - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxOP_CD - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxCMP_CD - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxLOT - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxREQ_NO - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxDAY_SEQ - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxINPUT_PRIO - 1].ToString(); 




				if(before_item != now_item)
				{
  
					fgrid_WorkSheet.Rows.Add();
								

					//default data setting
					for(int j = 1; j <= (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxGEN; j++)
					{
						fgrid_WorkSheet[fgrid_WorkSheet.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j - 1].ToString();
					}
 					 
					//gen
					for(int j = 1; j <= fgrid_WorkSheet.Rows.Fixed; j++)
					{
						if(fgrid_WorkSheet[j, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxGEN].ToString() == dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxGEN - 1].ToString())
						{
							gen_row = j;
							sel_gen = sel_gen + "/" + fgrid_WorkSheet[gen_row, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxGEN].ToString();

							break;
						} 
					}


					before_item = now_item; 

					sum_size_qty = 0;
					

				}
 


				//-------------------------------------------------------------- 
				for(int j = (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxCS_SIZE_START; j < fgrid_WorkSheet.Cols.Count; j++)
				{
					if(fgrid_WorkSheet[gen_row, j].ToString() == dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxCS_SIZE - 1].ToString())
					{
						min_size_col = (min_size_col > j) ? j : min_size_col;

						size_qty = Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxDIR_QTY - 1].ToString()); 
						fgrid_WorkSheet[fgrid_WorkSheet.Rows.Count - 1, j] = (size_qty.ToString() == "0") ? "" : size_qty.ToString();

						sum_size_qty += size_qty;
						

						break; 
					} 
				}
  


				fgrid_WorkSheet[fgrid_WorkSheet.Rows.Count - 1, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxTOT_QTY] = sum_size_qty.ToString();

 	 



			} // end for 



			//			//--------------------------------------------------------------
			//			//LOT에 대한 젠더만 표시
			//			string[] token = sel_gen.Split('/');
			//
			//			for(int i = 1; i < fgrid_WorkSheet.Rows.Fixed; i++) 
			//				fgrid_WorkSheet.Rows[i].Visible = false;   
			//
			//			for(int i = 1; i < fgrid_WorkSheet.Rows.Fixed; i++) 
			//			{
			//				for(int j = 0; j < token.Length; j++)
			//				{
			//					if(fgrid_WorkSheet[i, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxGEN].ToString() == token[j])
			//					{
			//						fgrid_WorkSheet.Rows[i].Visible = true; 
			//						break;
			//					} 
			//				} // end for j 
			//			} // end for i
  


			//--------------------------------------------------------------
			//Merge 속성 
			fgrid_WorkSheet.AllowMerging = AllowMergingEnum.Free; 
			for(int i = fgrid_WorkSheet.Rows.Fixed; i < fgrid_WorkSheet.Rows.Count; i++) fgrid_WorkSheet.Rows[i].AllowMerging = false;  
			fgrid_WorkSheet.Cols[(int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxMODEL_NAME].AllowMerging = true;
			fgrid_WorkSheet.Cols[(int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxSTYLE_CD].AllowMerging = true;


			//--------------------------------------------------------------
			// subtotal 
			fgrid_WorkSheet.Subtotal(AggregateEnum.Clear);
			fgrid_WorkSheet.SubtotalPosition = SubtotalPositionEnum.BelowData;  
			fgrid_WorkSheet.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;
			fgrid_WorkSheet.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;   
			fgrid_WorkSheet.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrSubTotal1;
			fgrid_WorkSheet.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black;   
			fgrid_WorkSheet.Styles[CellStyleEnum.Subtotal2].BackColor = ClassLib.ComVar.ClrSubTotal2;
			fgrid_WorkSheet.Styles[CellStyleEnum.Subtotal2].ForeColor = Color.Black;   
 
  

//			fgrid_WorkSheet.Subtotal(AggregateEnum.Sum, 2, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxMLINE_CD, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxTOT_QTY, "Line Sum.");
//
//			for (int i = (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxCS_SIZE_START; i < fgrid_WorkSheet.Cols.Count; i++) 
//				fgrid_WorkSheet.Subtotal(AggregateEnum.Sum, 2, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxMLINE_CD, i, "Line Sum.");


			fgrid_WorkSheet.Subtotal(AggregateEnum.Sum, 2, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxREQ_NO, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxTOT_QTY, "Req. Sum.");

			for (int i = (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxCS_SIZE_START; i < fgrid_WorkSheet.Cols.Count; i++) 
				fgrid_WorkSheet.Subtotal(AggregateEnum.Sum, 2, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxREQ_NO, i, "Req. Sum.");


			fgrid_WorkSheet.Subtotal(AggregateEnum.Sum, 1, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxLINE_CD, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxTOT_QTY, "Line Sum.");

			for (int i = (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxCS_SIZE_START; i < fgrid_WorkSheet.Cols.Count; i++) 
				fgrid_WorkSheet.Subtotal(AggregateEnum.Sum, 1, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxLINE_CD, i, "Line Sum.");
 

			fgrid_WorkSheet.Subtotal(AggregateEnum.Sum, 0, -1, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxTOT_QTY, "Total");

			for (int i = (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxCS_SIZE_START; i < fgrid_WorkSheet.Cols.Count; i++) 
				fgrid_WorkSheet.Subtotal(AggregateEnum.Sum, 0, -1, i, "Total");
  
			  


			//--------------------------------------------------------------
			//기타 속성 
			fgrid_WorkSheet.Cols.Frozen = (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxCS_SIZE_START;
			fgrid_WorkSheet.LeftCol = min_size_col; 




		}

 


		#endregion

		#region 툴바 이벤트 메서드


		/// <summary>
		/// Event_Tbtn_New : 
		/// </summary>
		private void Event_Tbtn_New()
		{
			fgrid_WorkSheet.Rows.Count = fgrid_WorkSheet.Rows.Fixed;
		}


		/// <summary>
		/// Event_Tbtn_Search : 
		/// </summary>
		private void Event_Tbtn_Search()
		{ 
			 
			fgrid_WorkSheet.Rows.Count = fgrid_WorkSheet.Rows.Fixed;

			if(cmb_Factory.SelectedIndex == -1 || cmb_LineCd.SelectedIndex == -1 
				|| dpick_PlanYMD.CustomFormat == " " || cmb_OpCd.SelectedIndex == -1 || cmb_MLineCd.SelectedIndex == -1) return;
 
			Display_WorkSheet(); 
			
		}


		/// <summary>
		/// Event_Tbtn_Print : 
		/// </summary>
		private void Event_Tbtn_Print()
		{

			this.Cursor = Cursors.WaitCursor;

			 
			if(fgrid_WorkSheet.Rows.Count < fgrid_WorkSheet.Rows.Fixed) return;

			if(cmb_Factory.SelectedIndex == -1 || cmb_LineCd.SelectedIndex == -1 
				|| dpick_PlanYMD.CustomFormat == " " || cmb_OpCd.SelectedIndex == -1) return; 



			string filename = Application.StartupPath + @"\Report\Production\" + this.Name + ".txt";
			string sDir = ClassLib.ComFunction.Set_RD_Directory(this.Name); 

			FileInfo file = new FileInfo(filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}

			file = null;

 
			 

			fgrid_WorkSheet.ClipSeparators = "@ ";
			fgrid_WorkSheet.SaveGrid( filename, FileFormatEnum.TextCustom);



			string factory_report = cmb_Factory.SelectedValue.ToString();
			
			string line_report = "";
			if(cmb_LineCd.SelectedIndex == 0)
			{
				line_report = "ALL";
			}
			else
			{
				//line_report = cmb_LineCd.SelectedValue.ToString();
				line_report = cmb_LineCd.Columns[1].Text;
			}

			
			string workingdate_report = dpick_PlanYMD.Text; //dpick_PlanYMD.Value.ToString("yyyy-MM-dd");
			string op_cd_report = cmb_OpCd.SelectedValue.ToString(); 
			
			//string cmp_report = ClassLib.ComFunction.Empty_Combo(cmb_CmpCd, "ALL");
			string cmp_report = "";
			if(cmb_LineCd.SelectedIndex == 0)
			{
				cmp_report = "ALL";
			}
			else
			{
				cmp_report = ClassLib.ComFunction.Empty_Combo(cmb_CmpCd, "ALL");
			}

			string mline_report = "";
			if(cmb_MLineCd.SelectedIndex == 0)
			{
				mline_report = "ALL";
			}
			else
			{ 
				mline_report = cmb_MLineCd.Columns[1].Text;
			}



			string para = "/rfn [" + filename + "] /rv V_DATE[" + workingdate_report 
				+ "] V_cmp[" + cmp_report + "] V_OPER[" + op_cd_report
				+ "] V_LINE[" + line_report  + "] V_MLINE[" + mline_report + "]";
  
				


			COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report("DAILY PRODUCTION ORDER SHEET BY SEQUENCE", sDir, para);
			report.Show();


			this.Cursor = Cursors.Default;


		}
 

		#endregion

		#region 그리드 이벤트 메서드


		private void Event_Click_fgrid_WorkSheet()
		{

			if(fgrid_WorkSheet.Rows.Count <= fgrid_WorkSheet.Rows.Fixed) return;


			int sel_row = fgrid_WorkSheet.Selection.r1;


			if(fgrid_WorkSheet[sel_row, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxLOT] == null
				|| fgrid_WorkSheet[sel_row, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxLOT].ToString() == "") return;


			string sel_gen = fgrid_WorkSheet[sel_row, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxGEN].ToString();

			//----------------------------------------------------------------------
			//선택한 젠더 Row 표시
			int findrow = fgrid_WorkSheet.FindRow(sel_gen, 2, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxGEN, false, true, false);

			if(findrow == -1) return;

			fgrid_WorkSheet.GetCellRange(findrow, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxGEN, findrow, fgrid_WorkSheet.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrSel_Yellow; 
			fgrid_WorkSheet.GetCellRange(findrow, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxGEN, findrow, fgrid_WorkSheet.Cols.Count - 1).StyleNew.ForeColor = Color.Black;
 
			if(_BeforeGenRow != -1 && _BeforeGenRow != findrow) 
				fgrid_WorkSheet.GetCellRange(_BeforeGenRow, (int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxGEN, _BeforeGenRow, fgrid_WorkSheet.Cols.Count - 1).StyleNew.Clear(); 

			_BeforeGenRow = findrow;


		}



  
		#endregion

		#region 버튼 및 기타 이벤트 메서드

	
		/// <summary>
		/// Event_SelectedValueChanged_cmb_Factory : 
		/// </summary>
		private void Event_SelectedValueChanged_cmb_Factory()
		{

			if(cmb_Factory.SelectedIndex == -1) return; 

			string factory = cmb_Factory.SelectedValue.ToString();

  	 
			// 사이즈 헤더 할당
			fgrid_WorkSheet.Rows.Count = 2;
			ClassLib.ComFunction.Set_DefaultSize_Head(fgrid_WorkSheet, 
														factory, 
														"", 
														fgrid_WorkSheet.Rows.Fixed,
														(int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxGEN,
														(int)ClassLib.TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC.IxCS_SIZE_START);




			//라인 그룹 설정
			DataTable dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxLineType);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LineGroup, 1, 2, true, COM.ComVar.ComboList_Visible.Name); 
			cmb_LineGroup.SelectedIndex = 0;

  
			dt_ret = FlexAPS.ProdSheet.Form_PD_MPSByOP.Select_SPB_OPCD(factory);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OpCd, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 

			if(_SelOpCd == "") 
			{
				cmb_OpCd.SelectedIndex = 0; 
			}
			else 
			{
				cmb_OpCd.SelectedValue = _SelOpCd;  
			}


		}



		/// <summary>
		/// Event_SelectedValueChanged_cmb_LineGroup : 
		/// </summary>
		private void Event_SelectedValueChanged_cmb_LineGroup()
		{

			if(cmb_Factory.SelectedIndex == -1 || cmb_LineGroup.SelectedIndex == -1) return; 

			fgrid_WorkSheet.Rows.Count = fgrid_WorkSheet.Rows.Fixed;
			
			string factory = cmb_Factory.SelectedValue.ToString();
			string line_group = cmb_LineGroup.SelectedValue.ToString();

			DataTable dt_ret = FlexAPS.ProdSheet.Form_PD_MPSByOP.Select_SPB_LINE(factory, line_group);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LineCd, 0, 1, true, COM.ComVar.ComboList_Visible.Name);

			cmb_LineCd.SelectedIndex = 0;  


		}



		/// <summary>
		/// Event_SelectedValueChanged_cmb_LineCd : 
		/// </summary>
		private void Event_SelectedValueChanged_cmb_LineCd()
		{

			if(cmb_Factory.SelectedIndex == -1 || cmb_LineCd.SelectedIndex == -1 
				|| dpick_PlanYMD.CustomFormat == " " || cmb_CmpCd.SelectedIndex == -1 || cmb_OpCd.SelectedIndex == -1) return;
    

			fgrid_WorkSheet.Rows.Count = fgrid_WorkSheet.Rows.Fixed;
		 
			_SelCmpCd = cmb_CmpCd.SelectedValue.ToString();



			string factory = cmb_Factory.SelectedValue.ToString();
			string line_group = ClassLib.ComFunction.Empty_Combo(cmb_LineGroup, " ");
			string line_cd = ClassLib.ComFunction.Empty_Combo(cmb_LineCd, " "); 
			string op_str_ymd = dpick_PlanYMD.Value.ToString("yyyyMMdd");
			string cmp_cd = cmb_CmpCd.SelectedValue.ToString();
			string op_cd = cmb_OpCd.SelectedValue.ToString();

			DataTable dt_ret = FlexAPS.ProdSheet.Form_PD_MPSByOP.Select_SPD_DAILY_WORKSHEET_TS_MLINECD(factory, line_group, line_cd, op_str_ymd, cmp_cd, op_cd);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MLineCd, 0, 1, true, COM.ComVar.ComboList_Visible.Name);

			cmb_MLineCd.SelectedIndex = 0;   


		}


		/// <summary>
		/// Event_SelectedValueChanged_cmb_OpCd : 
		/// </summary>
		private void Event_SelectedValueChanged_cmb_OpCd()
		{

			fgrid_WorkSheet.Rows.Count = fgrid_WorkSheet.Rows.Fixed;

			if(cmb_Factory.SelectedIndex == -1 || cmb_LineCd.SelectedIndex == -1 
				|| dpick_PlanYMD.CustomFormat == " " || cmb_OpCd.SelectedIndex == -1) return;
    

			_SelOpCd = cmb_OpCd.SelectedValue.ToString();

  
			string factory = cmb_Factory.SelectedValue.ToString();
			string op_cd = cmb_OpCd.SelectedValue.ToString();

			DataTable dt_ret = FlexAPS.ProdSheet.Form_PD_MPSByOP.Select_SPB_OPCD_CMPCD(factory, op_cd);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_CmpCd, 0, 1, true, COM.ComVar.ComboList_Visible.Code);
            
			if(_SelCmpCd == "") 
			{
				cmb_CmpCd.SelectedIndex = 0; 
			}
			else 
			{
				cmb_CmpCd.SelectedValue = _SelCmpCd; 
			}

 
			dt_ret = FlexAPS.ProdSheet.Form_PD_MPSByOP.Select_SPB_OPCD_LINE_AREA(factory, op_cd);    
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Area, 0, 1, true, COM.ComVar.ComboList_Visible.Name);

			if(_SelArea == "") 
			{
				cmb_Area.SelectedIndex = 0; 
			}
			else 
			{
				cmb_Area.SelectedValue = _SelArea;
			}

 

		}



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

		
		private void fgrid_WorkSheet_Click(object sender, System.EventArgs e)
		{ 
			 
			try
			{ 
				Event_Click_fgrid_WorkSheet(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_fgrid_WorkSheet", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		

		#endregion

		#region 버튼 및 기타 이벤트


		#region 버튼 이미지 이벤트

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
			

		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{

			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			}  

		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			}  

		}

		#endregion

		private void Form_PD_WorkSheetBySeq_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		} 

		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Event_SelectedValueChanged_cmb_Factory();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_SelectedValueChanged_cmb_Factory", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}

		private void cmb_LineGroup_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_SelectedValueChanged_cmb_LineGroup(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_SelectedValueChanged_cmb_LineGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 

		private void cmb_LineCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_SelectedValueChanged_cmb_LineCd(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_SelectedValueChanged_cmb_LineCd", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void cmb_MLineCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				fgrid_WorkSheet.Rows.Count = fgrid_WorkSheet.Rows.Fixed;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_MLineCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void cmb_OpCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_SelectedValueChanged_cmb_OpCd();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_SelectedValueChanged_cmb_OpCd", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 

		
		private void cmb_CmpCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_SelectedValueChanged_cmb_LineCd(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_SelectedValueChanged_cmb_LineCd", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void dpick_PlanYMD_ValueChanged(object sender, System.EventArgs e)
		{
			
			try
			{
				fgrid_WorkSheet.Rows.Count = fgrid_WorkSheet.Rows.Fixed;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_PlanYMD_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			
		}


		#endregion   

		#region 컨텍스트 메뉴 이벤트


	 

		#endregion


		#endregion
		 
		#region 디비 연결


		#region 콤보
  
		#endregion

		#region 조회

		
		/// <summary>
		/// Select_SPD_DAILY_WORKSHEET_TS : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_line_group"></param>
		/// <param name="arg_line_cd"></param>
		/// <param name="arg_op_str_ymd"></param>
		/// <param name="arg_cmp_cd"></param>
		/// <param name="arg_op_cd"></param>
		/// <param name="arg_mline_cd"></param>
		/// <param name="arg_mat_area"></param>
		/// <returns></returns>
		private DataTable Select_SPD_DAILY_WORKSHEET_TS(string arg_factory,
			string arg_line_group,
			string arg_line_cd,
			string arg_op_str_ymd,
			string arg_cmp_cd,
			string arg_op_cd,
			string arg_mline_cd,
			string arg_mat_area)
		{
			DataSet ds_ret;

			try
			{ 

				string process_name = "PKG_SPD_WORKSHEET_SEARCH_BSC.SELECT_DAILY_WORKSHEET_TS";

				MyOraDB.ReDim_Parameter(9); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_LINE_GROUP";
				MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_OP_STR_YMD";
				MyOraDB.Parameter_Name[4] = "ARG_CMP_CD";
				MyOraDB.Parameter_Name[5] = "ARG_OP_CD";
				MyOraDB.Parameter_Name[6] = "ARG_MLINE_CD";
				MyOraDB.Parameter_Name[7] = "ARG_MAT_AREA";
				MyOraDB.Parameter_Name[8] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_line_group; 
				MyOraDB.Parameter_Values[2] = arg_line_cd; 
				MyOraDB.Parameter_Values[3] = arg_op_str_ymd;
				MyOraDB.Parameter_Values[4] = arg_cmp_cd;  
				MyOraDB.Parameter_Values[5] = arg_op_cd; 
				MyOraDB.Parameter_Values[6] = arg_mline_cd; 
				MyOraDB.Parameter_Values[7] = arg_mat_area; 
				MyOraDB.Parameter_Values[8] = ""; 

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

	


		
 
	
		#endregion




	}
}

