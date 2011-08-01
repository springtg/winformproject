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
	public class Form_PD_JIT_List : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.Panel pnl_B;
		public System.Windows.Forms.Panel pnl_BT;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label lbl_OpStrYMD;
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
		private C1.Win.C1List.C1Combo cmb_div;
		private System.Windows.Forms.Label lbl_div;
		private System.Windows.Forms.DateTimePicker dpick_Stop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dpick_Start;
		private COM.FSP fgrid_WorkSheet; 
		private System.ComponentModel.IContainer components = null;
 
		#endregion

		#region 생성자, 소멸자


		public Form_PD_JIT_List()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PD_JIT_List));
			this.pnl_B = new System.Windows.Forms.Panel();
			this.fgrid_WorkSheet = new COM.FSP();
			this.pnl_BT = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.cmb_div = new C1.Win.C1List.C1Combo();
			this.lbl_div = new System.Windows.Forms.Label();
			this.dpick_Stop = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dpick_Start = new System.Windows.Forms.DateTimePicker();
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
			((System.ComponentModel.ISupportInitialize)(this.fgrid_WorkSheet)).BeginInit();
			this.pnl_BT.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_div)).BeginInit();
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
			this.fgrid_WorkSheet.Location = new System.Drawing.Point(8, 76);
			this.fgrid_WorkSheet.Name = "fgrid_WorkSheet";
			this.fgrid_WorkSheet.Size = new System.Drawing.Size(1000, 492);
			this.fgrid_WorkSheet.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:137, 179, 234;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:217, 250, 216;ForeColor:Black;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_WorkSheet.TabIndex = 43;
			// 
			// pnl_BT
			// 
			this.pnl_BT.BackColor = System.Drawing.Color.Transparent;
			this.pnl_BT.Controls.Add(this.pnl_SearchImage);
			this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_BT.DockPadding.Bottom = 5;
			this.pnl_BT.Location = new System.Drawing.Point(8, 8);
			this.pnl_BT.Name = "pnl_BT";
			this.pnl_BT.Size = new System.Drawing.Size(1000, 68);
			this.pnl_BT.TabIndex = 42;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.cmb_div);
			this.pnl_SearchImage.Controls.Add(this.lbl_div);
			this.pnl_SearchImage.Controls.Add(this.dpick_Stop);
			this.pnl_SearchImage.Controls.Add(this.label1);
			this.pnl_SearchImage.Controls.Add(this.dpick_Start);
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
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 63);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// cmb_div
			// 
			this.cmb_div.AddItemCols = 0;
			this.cmb_div.AddItemSeparator = ';';
			this.cmb_div.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_div.Caption = "";
			this.cmb_div.CaptionHeight = 17;
			this.cmb_div.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_div.ColumnCaptionHeight = 18;
			this.cmb_div.ColumnFooterHeight = 18;
			this.cmb_div.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_div.ContentHeight = 17;
			this.cmb_div.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_div.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_div.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_div.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_div.EditorHeight = 17;
			this.cmb_div.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_div.GapHeight = 2;
			this.cmb_div.ItemHeight = 15;
			this.cmb_div.Location = new System.Drawing.Point(725, 36);
			this.cmb_div.MatchEntryTimeout = ((long)(2000));
			this.cmb_div.MaxDropDownItems = ((short)(5));
			this.cmb_div.MaxLength = 32767;
			this.cmb_div.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_div.Name = "cmb_div";
			this.cmb_div.PartialRightColumn = false;
			this.cmb_div.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_div.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_div.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_div.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_div.Size = new System.Drawing.Size(115, 21);
			this.cmb_div.TabIndex = 204;
			this.cmb_div.SelectedValueChanged += new System.EventHandler(this.cmb_div_SelectedValueChanged);
			// 
			// lbl_div
			// 
			this.lbl_div.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_div.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_div.ImageIndex = 0;
			this.lbl_div.ImageList = this.img_Label;
			this.lbl_div.Location = new System.Drawing.Point(624, 36);
			this.lbl_div.Name = "lbl_div";
			this.lbl_div.Size = new System.Drawing.Size(100, 21);
			this.lbl_div.TabIndex = 203;
			this.lbl_div.Text = "Division";
			this.lbl_div.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_Stop
			// 
			this.dpick_Stop.CustomFormat = "";
			this.dpick_Stop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_Stop.Location = new System.Drawing.Point(488, 36);
			this.dpick_Stop.Name = "dpick_Stop";
			this.dpick_Stop.Size = new System.Drawing.Size(117, 22);
			this.dpick_Stop.TabIndex = 202;
			this.dpick_Stop.ValueChanged += new System.EventHandler(this.dpick_Stop_ValueChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(466, 36);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(22, 22);
			this.label1.TabIndex = 201;
			this.label1.Text = "~";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dpick_Start
			// 
			this.dpick_Start.CustomFormat = "";
			this.dpick_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_Start.Location = new System.Drawing.Point(349, 36);
			this.dpick_Start.Name = "dpick_Start";
			this.dpick_Start.Size = new System.Drawing.Size(117, 22);
			this.dpick_Start.TabIndex = 200;
			this.dpick_Start.ValueChanged += new System.EventHandler(this.dpick_Start_ValueChanged);
			// 
			// lbl_OpStrYMD
			// 
			this.lbl_OpStrYMD.ImageIndex = 0;
			this.lbl_OpStrYMD.ImageList = this.img_Label;
			this.lbl_OpStrYMD.Location = new System.Drawing.Point(248, 36);
			this.lbl_OpStrYMD.Name = "lbl_OpStrYMD";
			this.lbl_OpStrYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_OpStrYMD.TabIndex = 40;
			this.lbl_OpStrYMD.Text = "Dir. Date";
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
			this.picb_MR.Size = new System.Drawing.Size(15, 23);
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
			this.picb_BR.Location = new System.Drawing.Point(984, 47);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 45);
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
			this.picb_BL.Location = new System.Drawing.Point(0, 43);
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
			this.picb_ML.Size = new System.Drawing.Size(168, 20);
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
			this.picb_MM.Size = new System.Drawing.Size(832, 28);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// Form_PD_JIT_List
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_B);
			this.Name = "Form_PD_JIT_List";
			this.Load += new System.EventHandler(this.Form_PD_JIT_List_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_B, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_B.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_WorkSheet)).EndInit();
			this.pnl_BT.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_div)).EndInit();
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
				this.Text = "Daily WorkSheet By Shortage";
				lbl_MainTitle.Text = "Daily WorkSheet By Shortage"; 
 
				fgrid_WorkSheet.Set_Grid("SPD_DAILY_WORKSHEET_TS_DEF_BSC", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
				fgrid_WorkSheet.ExtendLastCol = false;
				fgrid_WorkSheet.AllowEditing = false;
				fgrid_WorkSheet.Font = new Font("Verdana", 7);



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
 
			
			dpick_Start.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			dpick_Stop.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			
			if(ClassLib.ComVar.This_FormDate != "") 
			{
				dpick_Start.Text = MyComFunction.ConvertDate2Type(ClassLib.ComVar.This_FormDate); 
				dpick_Stop.Text = MyComFunction.ConvertDate2Type(ClassLib.ComVar.This_FormDate); 
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
			string jit_req_type = ClassLib.ComFunction.Empty_Combo(cmb_div, " ");
			string op_str_ymd_from = dpick_Start.Value.ToString("yyyyMMdd");
			string op_srt_ymd_to = dpick_Stop.Value.ToString("yyyyMMdd");


			DataTable dt_ret = Select_DAILY_WORKSHEET_TS_DEF(factory, jit_req_type, op_str_ymd_from, op_srt_ymd_to);
 


			fgrid_WorkSheet.Rows.Count = fgrid_WorkSheet.Rows.Fixed;  

			if(dt_ret.Rows.Count == 0) 
			{ 
				return; 
			}


  
			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
      	 
				
				now_item = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxLINE_CD - 1].ToString() 
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxLOT - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxREQ_NO - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxJIT_REQ_TYPE - 1].ToString() 
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxCMP_CD - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxSTR_OP_CD - 1].ToString()
					+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxEND_OP_CD - 1].ToString(); 
 
					


				if(before_item != now_item)
				{
  
					fgrid_WorkSheet.Rows.Add();
								

					//default data setting
					for(int j = 1; j <= (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxGEN; j++)
					{
						fgrid_WorkSheet[fgrid_WorkSheet.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j - 1].ToString();
					}
 					 
					//gen
					for(int j = 1; j <= fgrid_WorkSheet.Rows.Fixed; j++)
					{
						if(fgrid_WorkSheet[j, (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxGEN].ToString() == dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxGEN - 1].ToString())
						{
							gen_row = j;
							sel_gen = sel_gen + "/" + fgrid_WorkSheet[gen_row, (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxGEN].ToString();

							break;
						} 
					}


					before_item = now_item; 

					sum_size_qty = 0;
					

				}
 


				//-------------------------------------------------------------- 
				for(int j = (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxCS_SIZE_START; j < fgrid_WorkSheet.Cols.Count; j++)
				{
					if(fgrid_WorkSheet[gen_row, j].ToString() == dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxCS_SIZE - 1].ToString())
					{
						min_size_col = (min_size_col > j) ? j : min_size_col;

						size_qty = Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxSIZE_QTY - 1].ToString()); 
						fgrid_WorkSheet[fgrid_WorkSheet.Rows.Count - 1, j] = (size_qty.ToString() == "0") ? "" : size_qty.ToString();

						sum_size_qty += size_qty;
						

						break; 
					} 
				}
  


				fgrid_WorkSheet[fgrid_WorkSheet.Rows.Count - 1, (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxTOT_QTY] = sum_size_qty.ToString();

 	 



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
			//					if(fgrid_WorkSheet[i, (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxGEN].ToString() == token[j])
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
			fgrid_WorkSheet.Cols[(int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxMODEL_NAME].AllowMerging = true;
			fgrid_WorkSheet.Cols[(int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxSTYLE_CD].AllowMerging = true;


			//--------------------------------------------------------------
			// subtotal 
			fgrid_WorkSheet.Subtotal(AggregateEnum.Clear);
			fgrid_WorkSheet.SubtotalPosition = SubtotalPositionEnum.BelowData;  
			//			fgrid_WorkSheet.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;
			//			fgrid_WorkSheet.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;   
			fgrid_WorkSheet.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrSubTotal1;
			fgrid_WorkSheet.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black;   
			fgrid_WorkSheet.Styles[CellStyleEnum.Subtotal2].BackColor = ClassLib.ComVar.ClrSubTotal2;
			fgrid_WorkSheet.Styles[CellStyleEnum.Subtotal2].ForeColor = Color.Black;   
 
  

			fgrid_WorkSheet.Subtotal(AggregateEnum.Sum, 2, (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxLINE_CD, (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxTOT_QTY, "Line Sum.");

			for (int i = (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxCS_SIZE_START; i < fgrid_WorkSheet.Cols.Count; i++) 
				fgrid_WorkSheet.Subtotal(AggregateEnum.Sum, 2, (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxLINE_CD, i, "Line Sum.");


			fgrid_WorkSheet.Subtotal(AggregateEnum.Sum, 1, -1, (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxTOT_QTY, "Total");

			for (int i = (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxCS_SIZE_START; i < fgrid_WorkSheet.Cols.Count; i++) 
				fgrid_WorkSheet.Subtotal(AggregateEnum.Sum, 1, -1, i, "Total");
 

			  


			//--------------------------------------------------------------
			//기타 속성 
			fgrid_WorkSheet.Cols.Frozen = (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxCS_SIZE_START;
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

			if(cmb_Factory.SelectedIndex == -1 || dpick_Start.CustomFormat == " " || dpick_Stop.CustomFormat == " ") return; 
 
			Display_WorkSheet(); 
			
		}


		/// <summary>
		/// Event_Tbtn_Print : 
		/// </summary>
		private void Event_Tbtn_Print()
		{

			this.Cursor = Cursors.WaitCursor;

			 
			if(fgrid_WorkSheet.Rows.Count < fgrid_WorkSheet.Rows.Fixed) return;

			if(cmb_Factory.SelectedIndex == -1 || dpick_Start.CustomFormat == " " || dpick_Stop.CustomFormat == " ") return; 
 


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


 
			string fromdate = dpick_Start.Text;
			string todate = dpick_Stop.Text;
			string div = cmb_div.Columns[1].Text;


			string para = "/rfn [" + filename + "] /rv V_FROMDATE[" + fromdate 
				+ "] V_TODATE[" + todate + "] V_TYPE[" + div + "]";
			 

			COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report("DAILY PRODUCTION ORDER SHEET BY SHORTAGE", sDir, para);
			report.Show();


			this.Cursor = Cursors.Default;


		}
 

		#endregion

		#region 그리드 이벤트 메서드


		private void Event_Click_fgrid_WorkSheet()
		{

			if(fgrid_WorkSheet.Rows.Count <= fgrid_WorkSheet.Rows.Fixed) return;


			int sel_row = fgrid_WorkSheet.Selection.r1;


			if(fgrid_WorkSheet[sel_row, (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxLOT] == null
				|| fgrid_WorkSheet[sel_row, (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxLOT].ToString() == "") return;


			string sel_gen = fgrid_WorkSheet[sel_row, (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxGEN].ToString();

			//----------------------------------------------------------------------
			//선택한 젠더 Row 표시
			int findrow = fgrid_WorkSheet.FindRow(sel_gen, 2, (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxGEN, false, true, false);

			if(findrow == -1) return;

			fgrid_WorkSheet.GetCellRange(findrow, (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxGEN, findrow, fgrid_WorkSheet.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrSel_Yellow; 
			fgrid_WorkSheet.GetCellRange(findrow, (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxGEN, findrow, fgrid_WorkSheet.Cols.Count - 1).StyleNew.ForeColor = Color.Black;
 
			if(_BeforeGenRow != -1 && _BeforeGenRow != findrow) 
				fgrid_WorkSheet.GetCellRange(_BeforeGenRow, (int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxGEN, _BeforeGenRow, fgrid_WorkSheet.Cols.Count - 1).StyleNew.Clear(); 

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
														(int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxGEN,
														(int)ClassLib.TBSPD_JIT_REQ_LIST_SEARCH_BSC.IxCS_SIZE_START);




			// division 할당 (CxJitReqDivision = "SPO_JIT01")
			DataTable dt_ret = ClassLib.ComVar.Select_ComCode(factory, ClassLib.ComVar.CxJitReqDivision);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_div, 1, 2, false, COM.ComVar.ComboList_Visible.Name);
			dt_ret.Dispose();

			cmb_div.SelectedValue = "2";  // shortage



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

		private void Form_PD_JIT_List_Load(object sender, System.EventArgs e)
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

		private void dpick_Start_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				fgrid_WorkSheet.Rows.Count = fgrid_WorkSheet.Rows.Fixed;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_Start_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void dpick_Stop_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				fgrid_WorkSheet.Rows.Count = fgrid_WorkSheet.Rows.Fixed;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_Stop_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void cmb_div_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				fgrid_WorkSheet.Rows.Count = fgrid_WorkSheet.Rows.Fixed;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_div_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
		/// Select_DAILY_WORKSHEET_TS_DEF : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_jit_req_type"></param>
		/// <param name="arg_op_str_ymd_from"></param>
		/// <param name="arg_op_str_ymd_to"></param>
		/// <returns></returns>
		private DataTable Select_DAILY_WORKSHEET_TS_DEF(string arg_factory,
			string arg_jit_req_type,
			string arg_op_str_ymd_from,
			string arg_op_str_ymd_to)
		{
			DataSet ds_ret;

			try
			{ 


				string process_name = "PKG_SPD_WORKSHEET_SEARCH_BSC.SELECT_DAILY_WORKSHEET_TS_DEF";

				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_JIT_REQ_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_OP_STR_YMD_FROM";
				MyOraDB.Parameter_Name[3] = "ARG_OP_STR_YMD_TO"; 
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR"; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_jit_req_type; 
				MyOraDB.Parameter_Values[2] = arg_op_str_ymd_from;  
				MyOraDB.Parameter_Values[3] = arg_op_str_ymd_to; 
				MyOraDB.Parameter_Values[4] = ""; 

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

