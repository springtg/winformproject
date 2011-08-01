using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexAPS.ProdSheet
{
	public class Form_PD_LOTDaily_Out : COM.APSWinForm.Form_Top
	{
		
		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.Panel pnl_B;
		private System.Windows.Forms.ImageList img_SmallLabel;
		private System.Windows.Forms.ContextMenu cmenu_OutMLine;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_OpCd;
		private System.Windows.Forms.Label lbl_OpCd;
		public System.Windows.Forms.DateTimePicker dpick_PlanYMD;
		private System.Windows.Forms.Label lbl_PlanYMD;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		public System.Windows.Forms.Panel pnl_BT;
		private System.Windows.Forms.Panel pnl_BL;
		private COM.FSP fgrid_Daily;
		private System.Windows.Forms.Splitter splitter1;
		private COM.FSP fgrid_DailySize;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 생성자, 소멸자
 

		public Form_PD_LOTDaily_Out()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}



		private string _Div;     // _Div = '1' (정상), '2' (불량)
		private string _Factory;
		private string _PlanYMD;
		private string _NextYMD;


		public Form_PD_LOTDaily_Out(string arg_division, string arg_factory, string arg_confirm_ymd, string arg_next_work_ymd)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			_Div = arg_division;
			_Factory = arg_factory;
			_PlanYMD = arg_confirm_ymd;
			_NextYMD = arg_next_work_ymd;


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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PD_LOTDaily_Out));
			this.pnl_B = new System.Windows.Forms.Panel();
			this.fgrid_DailySize = new COM.FSP();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.pnl_BL = new System.Windows.Forms.Panel();
			this.fgrid_Daily = new COM.FSP();
			this.pnl_BT = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.cmb_OpCd = new C1.Win.C1List.C1Combo();
			this.lbl_OpCd = new System.Windows.Forms.Label();
			this.dpick_PlanYMD = new System.Windows.Forms.DateTimePicker();
			this.lbl_PlanYMD = new System.Windows.Forms.Label();
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
			this.cmenu_OutMLine = new System.Windows.Forms.ContextMenu();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_B.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_DailySize)).BeginInit();
			this.pnl_BL.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Daily)).BeginInit();
			this.pnl_BT.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OpCd)).BeginInit();
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
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Text = "Operation Work Area";
			// 
			// pnl_B
			// 
			this.pnl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_B.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_B.Controls.Add(this.fgrid_DailySize);
			this.pnl_B.Controls.Add(this.splitter1);
			this.pnl_B.Controls.Add(this.pnl_BL);
			this.pnl_B.Controls.Add(this.pnl_BT);
			this.pnl_B.DockPadding.All = 8;
			this.pnl_B.Location = new System.Drawing.Point(0, 64);
			this.pnl_B.Name = "pnl_B";
			this.pnl_B.Size = new System.Drawing.Size(1016, 576);
			this.pnl_B.TabIndex = 29;
			// 
			// fgrid_DailySize
			// 
			this.fgrid_DailySize.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_DailySize.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_DailySize.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_DailySize.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_DailySize.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_DailySize.Location = new System.Drawing.Point(675, 78);
			this.fgrid_DailySize.Name = "fgrid_DailySize";
			this.fgrid_DailySize.Size = new System.Drawing.Size(333, 490);
			this.fgrid_DailySize.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:137, 179, 234;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:217, 250, 216;ForeColor:Black;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_DailySize.TabIndex = 49;
			this.fgrid_DailySize.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_DailySize_AfterEdit);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(672, 78);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 490);
			this.splitter1.TabIndex = 48;
			this.splitter1.TabStop = false;
			// 
			// pnl_BL
			// 
			this.pnl_BL.Controls.Add(this.fgrid_Daily);
			this.pnl_BL.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnl_BL.DockPadding.Right = 5;
			this.pnl_BL.Location = new System.Drawing.Point(8, 78);
			this.pnl_BL.Name = "pnl_BL";
			this.pnl_BL.Size = new System.Drawing.Size(664, 490);
			this.pnl_BL.TabIndex = 47;
			// 
			// fgrid_Daily
			// 
			this.fgrid_Daily.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Daily.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Daily.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Daily.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Daily.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Daily.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Daily.Name = "fgrid_Daily";
			this.fgrid_Daily.Size = new System.Drawing.Size(659, 490);
			this.fgrid_Daily.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:137, 179, 234;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:217, 250, 216;ForeColor:Black;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Daily.TabIndex = 43;
			this.fgrid_Daily.Click += new System.EventHandler(this.fgrid_Daily_Click);
			this.fgrid_Daily.AfterSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgrid_Daily_AfterSelChange);
			// 
			// pnl_BT
			// 
			this.pnl_BT.BackColor = System.Drawing.Color.Transparent;
			this.pnl_BT.Controls.Add(this.pnl_SearchImage);
			this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_BT.DockPadding.Bottom = 5;
			this.pnl_BT.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_BT.Location = new System.Drawing.Point(8, 8);
			this.pnl_BT.Name = "pnl_BT";
			this.pnl_BT.Size = new System.Drawing.Size(1000, 70);
			this.pnl_BT.TabIndex = 44;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.cmb_OpCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_OpCd);
			this.pnl_SearchImage.Controls.Add(this.dpick_PlanYMD);
			this.pnl_SearchImage.Controls.Add(this.lbl_PlanYMD);
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
			this.cmb_OpCd.Location = new System.Drawing.Point(336, 36);
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
			this.cmb_OpCd.Size = new System.Drawing.Size(110, 21);
			this.cmb_OpCd.TabIndex = 39;
			// 
			// lbl_OpCd
			// 
			this.lbl_OpCd.ImageIndex = 0;
			this.lbl_OpCd.ImageList = this.img_Label;
			this.lbl_OpCd.Location = new System.Drawing.Point(235, 36);
			this.lbl_OpCd.Name = "lbl_OpCd";
			this.lbl_OpCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_OpCd.TabIndex = 38;
			this.lbl_OpCd.Text = "Out Proc.";
			this.lbl_OpCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_PlanYMD
			// 
			this.dpick_PlanYMD.CustomFormat = "yyyyMMdd";
			this.dpick_PlanYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.dpick_PlanYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_PlanYMD.Location = new System.Drawing.Point(111, 36);
			this.dpick_PlanYMD.Name = "dpick_PlanYMD";
			this.dpick_PlanYMD.Size = new System.Drawing.Size(112, 22);
			this.dpick_PlanYMD.TabIndex = 192;
			this.dpick_PlanYMD.Value = new System.DateTime(2005, 10, 10, 12, 5, 37, 216);
			this.dpick_PlanYMD.ValueChanged += new System.EventHandler(this.dpick_PlanYMD_ValueChanged);
			// 
			// lbl_PlanYMD
			// 
			this.lbl_PlanYMD.ImageIndex = 0;
			this.lbl_PlanYMD.ImageList = this.img_Label;
			this.lbl_PlanYMD.Location = new System.Drawing.Point(10, 36);
			this.lbl_PlanYMD.Name = "lbl_PlanYMD";
			this.lbl_PlanYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_PlanYMD.TabIndex = 40;
			this.lbl_PlanYMD.Text = "Confirm Day";
			this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.lbl_SubTitle1.Text = "      Daily WorkSheet";
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
			this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
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
			this.picb_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
			this.picb_MM.Location = new System.Drawing.Point(160, 24);
			this.picb_MM.Name = "picb_MM";
			this.picb_MM.Size = new System.Drawing.Size(832, 25);
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
			// Form_PD_LOTDaily_Out
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_B);
			this.Name = "Form_PD_LOTDaily_Out";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Operation Work Area";
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_B, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_B.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_DailySize)).EndInit();
			this.pnl_BL.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Daily)).EndInit();
			this.pnl_BT.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_OpCd)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
 
		#region 변수 정의

		 
		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction MyComFunction = new COM.ComFunction(); 


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
				this.Text = "Operation Work Area";
				lbl_MainTitle.Text = "Operation Work Area";


				switch(_Div)
				{
					case "1":
	
						lbl_OpCd.Visible = true;
						cmb_OpCd.Visible = true;

						fgrid_Daily.Set_Grid("SPD_RELEASE_OUT_BSC", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
						fgrid_Daily.ExtendLastCol = false;
						fgrid_Daily.Font = new Font("Verdana", 7); 
					
						break;

					case "2":
					
						lbl_OpCd.Visible = false;
						cmb_OpCd.Visible = false;

						fgrid_Daily.Set_Grid("SPD_RELEASE_DEF_OUT_BSC", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
						fgrid_Daily.ExtendLastCol = false;
						fgrid_Daily.Font = new Font("Verdana", 7); 

						break;      
				}



				//fgrid_DailySize.Set_Grid("SPD_RELEASE_OUT_SIZE_BSC", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_DailySize.Set_Grid("SPD_RELEASE_OUT_SIZE_AREA_BSC", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_DailySize.Set_Action_Image(img_Action);
				fgrid_DailySize.ExtendLastCol = false;
				fgrid_DailySize.Font = new Font("Verdana", 7); 

 

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
			tbtn_Print.Enabled = false; 

			dpick_PlanYMD.CustomFormat = " "; 



//			if(_PlanYMD == _NextYMD)
//			{
//				tbtn_Save.Enabled = true;
//			}
//			else
//			{
//				tbtn_Save.Enabled = false;
//			}




			dpick_PlanYMD.Text = MyComFunction.ConvertDate2Type(_PlanYMD);
			dpick_PlanYMD.Enabled = false; 
			 

			//작업장 나눠지는 공정만 콤보리스트로 추출
			DataTable dt_ret = Select_SPB_OPCD_DIV_AREA(_Factory);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OpCd, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
			cmb_OpCd.SelectedValue = ClassLib.ComVar.StdOpCd;



  
		}



		#endregion
		  
		#region 조회



		/// <summary>
		/// Display_OpArea : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_OpArea(DataTable arg_dt)
		{ 	

			CellStyle cellst;
			cellst = fgrid_DailySize.Styles.Add("CHECKBOX");
			cellst.DataType = typeof(bool);		
			cellst.ImageAlign = ImageAlignEnum.CenterCenter;
   
			
			fgrid_DailySize.Rows.Count = 2;
			fgrid_DailySize.Cols.Count = (int)ClassLib.TBSPD_RELEASE_OUT_SIZE_AREA_BSC.IxAREA_START;
		
			//total, sum 표시 Row
			fgrid_DailySize.Rows.Add();   //row num : 2
			fgrid_DailySize.Rows.Add();   //row num : 3
			fgrid_DailySize.Rows.Fixed = fgrid_DailySize.Rows.Fixed + 2;  
			//전체 선택 Row
			fgrid_DailySize.Rows.Add();   //row num : 4
			

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{ 
				fgrid_DailySize.Cols.Add();
				fgrid_DailySize.Cols[fgrid_DailySize.Cols.Count - 1].Style = fgrid_DailySize.Styles["CHECKBOX"];
				fgrid_DailySize.Cols[fgrid_DailySize.Cols.Count - 1].Width = 90;
				fgrid_DailySize[0, fgrid_DailySize.Cols.Count - 1] = arg_dt.Rows[i].ItemArray[0].ToString();  //mline_cd
				fgrid_DailySize[1, fgrid_DailySize.Cols.Count - 1] = arg_dt.Rows[i].ItemArray[1].ToString();  //mline_name
				fgrid_DailySize[2, fgrid_DailySize.Cols.Count - 1] = (arg_dt.Rows[i].ItemArray[2].ToString() == "") ? "0" : arg_dt.Rows[i].ItemArray[2].ToString();  //tot_qty
				fgrid_DailySize[3, fgrid_DailySize.Cols.Count - 1] = (arg_dt.Rows[i].ItemArray[3].ToString() == "") ? "0" : arg_dt.Rows[i].ItemArray[3].ToString();  //sum_qty

				
			}  

			fgrid_DailySize.GetCellRange(2, 1, 2, fgrid_DailySize.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrSel_Green;
			fgrid_DailySize.GetCellRange(2, 1, 2, fgrid_DailySize.Cols.Count - 1).StyleNew.ForeColor = Color.Black;
			fgrid_DailySize.GetCellRange(3, 1, 3, fgrid_DailySize.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrSel_Yellow;
			fgrid_DailySize.GetCellRange(3, 1, 3, fgrid_DailySize.Cols.Count - 1).StyleNew.ForeColor = Color.Black;
			fgrid_DailySize.GetCellRange(4, 1, 4, fgrid_DailySize.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrDarkSel;

			fgrid_DailySize.Rows[2].TextAlign = TextAlignEnum.CenterCenter;
			fgrid_DailySize.Rows[3].TextAlign = TextAlignEnum.CenterCenter;

			fgrid_DailySize[2, (int)ClassLib.TBSPD_RELEASE_OUT_SIZE_AREA_BSC.IxCS_SIZE] = "Total";
			fgrid_DailySize[3, (int)ClassLib.TBSPD_RELEASE_OUT_SIZE_AREA_BSC.IxCS_SIZE] = "Sum";
			fgrid_DailySize[4, (int)ClassLib.TBSPD_RELEASE_OUT_SIZE_AREA_BSC.IxCS_SIZE] = "All";
			
			

		}



		/// <summary>
		/// Display_OpSize : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_OpSize(DataTable arg_dt)
		{ 
			 
			fgrid_DailySize.Rows.Count = fgrid_DailySize.Rows.Fixed + 1;  

			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				fgrid_DailySize.AddItem(arg_dt.Rows[i].ItemArray, fgrid_DailySize.Rows.Count, 1);
				fgrid_DailySize[i + fgrid_DailySize.Rows.Fixed, 0] = ""; 
			} 

			for(int i = fgrid_DailySize.Rows.Fixed + 1; i < fgrid_DailySize.Rows.Count; i++)
			{
				for(int j = (int)ClassLib.TBSPD_RELEASE_OUT_SIZE_AREA_BSC.IxAREA_START; j < fgrid_DailySize.Cols.Count; j++)
				{
					if(fgrid_DailySize[i, (int)ClassLib.TBSPD_RELEASE_OUT_SIZE_AREA_BSC.IxMAT_AREA].ToString() == fgrid_DailySize[0, j].ToString() )
					{
						fgrid_DailySize[i, j] = "TRUE";
						break;
					}
				} // end for j
			} // end for i
			
        
		}



		#endregion

		#region 툴바 이벤트 메서드
 

		/// <summary>
		/// Event_Tbtn_New : 
		/// </summary>
		private void Event_Tbtn_New()
		{
		
			fgrid_Daily.Rows.Count = fgrid_Daily.Rows.Fixed;
			fgrid_DailySize.Rows.Count = 2;
			fgrid_DailySize.Cols.Count = (int)ClassLib.TBSPD_RELEASE_OUT_SIZE_AREA_BSC.IxAREA_START;

		}


		/// <summary>
		/// Event_Tbtn_Search : 
		/// </summary>
		private void Event_Tbtn_Search()
		{
			 

			string division = _Div;
			string factory = _Factory;
			string dir_req_ymd = dpick_PlanYMD.Value.ToString("yyyyMMdd");
			string line_cd = ClassLib.ComFunction.Empty_String(ClassLib.ComVar.This_Line, " "); 
			string all_linecd = "";

			if(ClassLib.ComVar.This_Line.Replace("0", "").Length == 0) 
			{
				all_linecd = "";
			}
			else
			{
				all_linecd = "000";
			}
				
			DataTable dt_ret = Select_SPD_DAILY_WORKSHEET_OUT(division, factory, dir_req_ymd, line_cd, all_linecd);  
			fgrid_Daily.Display_Grid(dt_ret, false); 


		}


		/// <summary>
		/// Event_Tbtn_Save : 
		/// </summary>
		private void Event_Tbtn_Save()
		{
  


			bool check_flag = false, save_flag = false;
 

			// 누락없이 모두 선택되었는지 체크
			check_flag = Check_Save();

			if(!check_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				return;
			}

			switch(_Div)
			{
				case "1": 


					string factory = _Factory;
					
					string[] token = fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxLOT].ToString().Split('-');
					string lot_no = token[0];
					string lot_seq = token[1];

					string req_no = fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxREQ_NO].ToString();
					string day_seq = fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxDESC1].ToString();
					string op_cd = ClassLib.ComFunction.Empty_Combo(cmb_OpCd, " "); 
					string line_cd = fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxLINE_CD].ToString(); 
 

					save_flag = Update_SPD_DAILY_OUT_MAT_AREA(factory, lot_no, lot_seq, req_no, day_seq, op_cd, line_cd);
					break;

				case "2": 


					string factory_def = _Factory;
					string op_str_ymd_def = dpick_PlanYMD.Value.ToString("yyyyMMdd");

					string[] token_def = fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxLOT].ToString().Split('-');
					string lot_no_def = token_def[0];
					string lot_seq_def = token_def[1];

					string req_no_def = fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxREQ_NO].ToString();
					string cmp_cd_def = fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxDESC2].ToString();
					string str_op_cd_def = fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxDESC3].ToString();
					string end_op_cd_def = fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxDESC4].ToString(); 
   

					save_flag = Update_SPD_DAILY_OUT_DEF_MAT_AREA(factory_def, op_str_ymd_def, lot_no_def, lot_seq_def, req_no_def, cmp_cd_def, str_op_cd_def, end_op_cd_def); 
					break;      
			} 
				
			if(save_flag)
			{

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);

				Event_AfterSelChange_fgrid_Daily(); 

				
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
			}
		


		}




		/// <summary>
		/// Check_Save : 누락없이 모두 선택되었는지 체크
		/// </summary>
		/// <returns></returns>
		private bool Check_Save()
		{
			int count = 0;

			try
			{
				for(int i = fgrid_DailySize.Rows.Fixed + 1; i < fgrid_DailySize.Rows.Count; i++)
				{
					for(int j = (int)ClassLib.TBSPD_RELEASE_OUT_SIZE_AREA_BSC.IxAREA_START; j < fgrid_DailySize.Cols.Count; j++)
					{
						fgrid_DailySize[i, j] = (fgrid_DailySize[i, j] == null) ? "FALSE" : fgrid_DailySize[i, j].ToString();
						if(Convert.ToBoolean(fgrid_DailySize[i, j].ToString()))
						{
							count++;
							break;
						}
					}

				}

				if(count == fgrid_DailySize.Rows.Count - fgrid_DailySize.Rows.Fixed - 1)
					return true;
				else
					return false;
			}
			catch
			{
				return false;
			}
		}






		#endregion

		#region 그리드 이벤트 메서드
 

		/// <summary>
		/// Event_AfterSelChange_fgrid_Daily : 
		/// </summary>
		private void Event_AfterSelChange_fgrid_Daily()
		{

			if(fgrid_Daily.Rows.Count <= fgrid_Daily.Rows.Fixed) return;  
				
			DataTable dt_ret = null;


			if(fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxLOT] == null) return;


			switch(_Div)
			{
				case "1": 

					//공정 작업장 리스트 표시


					string factory = _Factory;
					
					string[] token = fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxLOT].ToString().Split('-');
					string lot_no = token[0];
					string lot_seq = token[1];

					string req_no = fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxREQ_NO].ToString();
					string day_seq = fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxDESC1].ToString();
					string op_cd = ClassLib.ComFunction.Empty_Combo(cmb_OpCd, " "); 
					string line_cd = fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxLINE_CD].ToString();
					string dir_req_ymd = dpick_PlanYMD.Value.ToString("yyyyMMdd"); 
  

					dt_ret = Select_SPB_OPCD_LINE_AREA(factory, lot_no, lot_seq, req_no, day_seq, op_cd, line_cd, dir_req_ymd);
					Display_OpArea(dt_ret);
				
					//SPD_LOT_DAILY_OPSIZE 사이즈 데이터 추출  
					dt_ret = Select_SPD_WORKSHEET_OUT_SIZE(factory, lot_no, lot_seq, req_no, day_seq, op_cd, line_cd);
					Display_OpSize(dt_ret); 
 

					break;

				case "2": 

					//UP 아니면 실행 안되도록
					if(fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxDESC2].ToString()  // cmp_cd
						!= cmb_OpCd.SelectedValue.ToString().Substring(0, 2)) 
					{
						fgrid_DailySize.Rows.Count = 2;
						fgrid_DailySize.Cols.Count = (int)ClassLib.TBSPD_RELEASE_OUT_SIZE_AREA_BSC.IxAREA_START;
						return;
					}

					//공정 작업장 리스트 표시


					string factory_def = _Factory;
					string op_str_ymd_def = dpick_PlanYMD.Value.ToString("yyyyMMdd");

					string[] token_def = fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxLOT].ToString().Split('-');
					string lot_no_def = token_def[0];
					string lot_seq_def = token_def[1];

					string req_no_def = fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxREQ_NO].ToString();
					string cmp_cd_def = fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxDESC2].ToString();
					string str_op_cd_def = fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxDESC3].ToString();
					string end_op_cd_def = fgrid_Daily[fgrid_Daily.Selection.r1, (int)ClassLib.TBSPD_RELEASE_OUT_BSC.IxDESC4].ToString(); 
  

					dt_ret = Select_SPB_OPCD_LINE_AREA_DEF(factory_def, op_str_ymd_def, lot_no_def, lot_seq_def, req_no_def, cmp_cd_def, str_op_cd_def, end_op_cd_def);
					Display_OpArea(dt_ret);

					//SPD_JIT_REQ 사이즈 데이터 추출  
					dt_ret = Select_SPD_WORKSHEET_OUT_SIZE_DEF(factory_def, op_str_ymd_def, lot_no_def, lot_seq_def, req_no_def, cmp_cd_def, str_op_cd_def, end_op_cd_def);
					Display_OpSize(dt_ret); 

					 
					break;      
			} 


		}


		/// <summary>
		/// Event_Click_fgrid_Daily : 
		/// </summary>
		private void Event_Click_fgrid_Daily()
		{

			Event_AfterSelChange_fgrid_Daily();

		}


		/// <summary>
		/// Event_AfterEdit_fgrid_DailySize :  
		/// </summary>
		private void Event_AfterEdit_fgrid_DailySize(C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			if(e.Col < (int)ClassLib.TBSPD_RELEASE_OUT_SIZE_AREA_BSC.IxAREA_START) return;
			 
			//전체 선택 
			if(e.Row == fgrid_DailySize.Rows.Fixed)
			{
 
				for(int i = (int)ClassLib.TBSPD_RELEASE_OUT_SIZE_AREA_BSC.IxAREA_START; i < fgrid_DailySize.Cols.Count; i++)
				{
					if(i == e.Col) continue;
					
					for(int j = e.Row; j < fgrid_DailySize.Rows.Count; j++)
					{
						fgrid_DailySize[j, i] = "FALSE";
					} // end for j

				} // end for i

				for(int i = e.Row + 1; i < fgrid_DailySize.Rows.Count; i++) 
				{
					fgrid_DailySize[i, e.Col] = fgrid_DailySize[e.Row, e.Col].ToString();
					fgrid_DailySize[i, (int)ClassLib.TBSPD_RELEASE_OUT_SIZE_AREA_BSC.IxMAT_AREA] = fgrid_DailySize[0, e.Col].ToString();
				}
			 
			}
			//한개씩 선택
			else
			{
				for(int i = (int)ClassLib.TBSPD_RELEASE_OUT_SIZE_AREA_BSC.IxAREA_START; i < fgrid_DailySize.Cols.Count; i++)
				{
					if(i == e.Col) continue; 
					fgrid_DailySize[e.Row, i] = "FALSE"; 
				}

				fgrid_DailySize[e.Row, (int)ClassLib.TBSPD_RELEASE_OUT_SIZE_AREA_BSC.IxMAT_AREA] = fgrid_DailySize[0, e.Col].ToString();

			} // end if


		}



		#endregion

		#region 버튼 및 기타 이벤트 메서드


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

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Save(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		} 


		#endregion 

		#region 그리드 이벤트
  

		
		private void fgrid_Daily_AfterSelChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			try
			{ 
				Event_AfterSelChange_fgrid_Daily();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_AfterSelChange_fgrid_Daily", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void fgrid_Daily_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Event_Click_fgrid_Daily();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_fgrid_Daily", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void fgrid_DailySize_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			try
			{ 
				Event_AfterEdit_fgrid_DailySize(e);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_AfterEdit_fgrid_DailySize", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}
 


		#endregion

		#region 버튼 및 기타 이벤트

	 
		private void dpick_PlanYMD_ValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{

				dpick_PlanYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType; 


				Event_Tbtn_Search();
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Change Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}
    


		#endregion 

		#region 컨텍스트 메뉴 이벤트

  

		#endregion


		#endregion
		 
		#region 디비 연결
 
 
		#region search


		/// <summary>
		/// Select_SPB_OPCD_DIV_AREA : 작업장 나눠지는 공정만 콤보리스트로 추출
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SPB_OPCD_DIV_AREA(string arg_factory)
		{
			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPD_WORKSHEET_BSC.SELECT_SPB_OPCD_DIV_AREA";

				MyOraDB.ReDim_Parameter(2);  
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
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
		/// Select_SPD_DAILY_WORKSHEET_OUT : 
		/// </summary>
		/// <param name="arg_division"></param>
		/// <param name="arg_factory"></param>
		/// <param name="arg_dir_req_ymd"></param>
		/// <param name="arg_line_cd"></param>
		/// <returns></returns>
		private DataTable Select_SPD_DAILY_WORKSHEET_OUT(string arg_division, 
			string arg_factory, 
			string arg_dir_req_ymd, 
			string arg_line_cd,
			string arg_all_linecd)
		{
			try
			{

				
				DataSet ds_ret;
 

				string process_name = "";

				if(arg_division == "1")
				{
					process_name = "PKG_SPD_WORKSHEET_BSC.SELECT_SPD_WORKSHEET_OUT";
				}
				else if(arg_division == "2")
				{
					process_name = "PKG_SPD_WORKSHEET_BSC.SELECT_SPD_WORKSHEET_DEF_OUT";
				}


				MyOraDB.ReDim_Parameter(5);  
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_DIR_REQ_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_ALL_LINE_CD";
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_dir_req_ymd;
				MyOraDB.Parameter_Values[2] = arg_line_cd;
				MyOraDB.Parameter_Values[3] = arg_all_linecd;
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


 


		/// <summary>
		/// Select_SPB_OPCD_LINE_AREA : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <param name="arg_req_no"></param>
		/// <param name="arg_day_seq"></param>
		/// <param name="arg_op_cd"></param>
		/// <param name="arg_line_cd"></param>
		/// <param name="arg_dir_req_ymd"></param>
		/// <returns></returns>
		private DataTable Select_SPB_OPCD_LINE_AREA(string arg_factory, 
			string arg_lot_no, 
			string arg_lot_seq,
			string arg_req_no,
			string arg_day_seq,
			string arg_op_cd,
			string arg_line_cd,
			string arg_dir_req_ymd)
		{
			
			try
			{

				DataSet ds_ret;


				string process_name = "PKG_SPD_WORKSHEET_BSC.SELECT_SPB_OPCD_LINE_AREA";

				MyOraDB.ReDim_Parameter(9);  
				MyOraDB.Process_Name = process_name;
   
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";  
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[3] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[4] = "ARG_DAY_SEQ"; 
				MyOraDB.Parameter_Name[5] = "ARG_OP_CD"; 
				MyOraDB.Parameter_Name[6] = "ARG_LINE_CD"; 
				MyOraDB.Parameter_Name[7] = "ARG_DIR_REQ_YMD";
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
				MyOraDB.Parameter_Values[1] = arg_lot_no;
				MyOraDB.Parameter_Values[2] = arg_lot_seq;
				MyOraDB.Parameter_Values[3] = arg_req_no;
				MyOraDB.Parameter_Values[4] = arg_day_seq;
				MyOraDB.Parameter_Values[5] = arg_op_cd;
				MyOraDB.Parameter_Values[6] = arg_line_cd;
				MyOraDB.Parameter_Values[7] = arg_dir_req_ymd;
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



		/// <summary>
		/// Select_SPB_OPCD_LINE_AREA_DEF : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_op_str_ymd"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <param name="arg_cmp_cd"></param>
		/// <param name="arg_str_op_cd"></param>
		/// <param name="arg_end_op_cd"></param>
		/// <returns></returns>
		private DataTable Select_SPB_OPCD_LINE_AREA_DEF(string arg_factory,
			string arg_op_str_ymd,
			string arg_lot_no,
			string arg_lot_seq,
			string arg_req_no,
			string arg_cmp_cd,
			string arg_str_op_cd,
			string arg_end_op_cd)
		{
			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPD_WORKSHEET_BSC.SELECT_SPB_OPCD_LINE_AREA_DEF"; 

				MyOraDB.ReDim_Parameter(9);  
				MyOraDB.Process_Name = process_name;
   
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_OP_STR_YMD";  
				MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";  
				MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[4] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[5] = "ARG_CMP_CD"; 
				MyOraDB.Parameter_Name[6] = "ARG_STR_OP_CD"; 
				MyOraDB.Parameter_Name[7] = "ARG_END_OP_CD";  
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
				MyOraDB.Parameter_Values[1] = arg_op_str_ymd;
				MyOraDB.Parameter_Values[2] = arg_lot_no;
				MyOraDB.Parameter_Values[3] = arg_req_no;
				MyOraDB.Parameter_Values[4] = arg_lot_seq;
				MyOraDB.Parameter_Values[5] = arg_cmp_cd;
				MyOraDB.Parameter_Values[6] = arg_str_op_cd;
				MyOraDB.Parameter_Values[7] = arg_end_op_cd;
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


		 


		/// <summary>
		/// Select_SPD_WORKSHEET_OUT_SIZE : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <param name="arg_day_seq"></param>
		/// <param name="arg_op_cd"></param>
		/// <param name="arg_line_cd"></param>
		/// <returns></returns>
		private DataTable Select_SPD_WORKSHEET_OUT_SIZE(string arg_factory, 
			string arg_lot_no, 
			string arg_lot_seq,
			string arg_req_no,
			string arg_day_seq,
			string arg_op_cd,
			string arg_line_cd)
		{
			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPD_WORKSHEET_BSC.SELECT_SPD_DAILY_OUT_SIZE_AREA";  //"PKG_SPD_WORKSHEET_BSC.SELECT_SPD_DAILY_OUT_SIZE";

				MyOraDB.ReDim_Parameter(8);  
				MyOraDB.Process_Name = process_name;
   
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";  
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[3] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[4] = "ARG_DAY_SEQ"; 
				MyOraDB.Parameter_Name[5] = "ARG_OP_CD"; 
				MyOraDB.Parameter_Name[6] = "ARG_LINE_CD";  
				MyOraDB.Parameter_Name[7] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_lot_no;
				MyOraDB.Parameter_Values[2] = arg_lot_seq;
				MyOraDB.Parameter_Values[3] = arg_req_no;
				MyOraDB.Parameter_Values[4] = arg_day_seq;
				MyOraDB.Parameter_Values[5] = arg_op_cd;
				MyOraDB.Parameter_Values[6] = arg_line_cd; 
				MyOraDB.Parameter_Values[7] = "";

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



		private DataTable Select_SPD_WORKSHEET_OUT_SIZE_DEF(string arg_factory,
			string arg_op_str_ymd,
			string arg_lot_no,
			string arg_lot_seq,
			string arg_req_no,
			string arg_cmp_cd,
			string arg_str_op_cd,
			string arg_end_op_cd)
		{
			DataSet ds_ret;

			try
			{
				string process_name =  "PKG_SPD_WORKSHEET_BSC.SELECT_SPD_DAILY_OUT_SIZE_DEF_"; // "PKG_SPD_WORKSHEET_BSC.SELECT_SPD_DAILY_OUT_SIZE_DEF";
 
				MyOraDB.ReDim_Parameter(9);  
				MyOraDB.Process_Name = process_name;
   
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_OP_STR_YMD";  
				MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";  
				MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[4] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[5] = "ARG_CMP_CD"; 
				MyOraDB.Parameter_Name[6] = "ARG_STR_OP_CD"; 
				MyOraDB.Parameter_Name[7] = "ARG_END_OP_CD";  
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
				MyOraDB.Parameter_Values[1] = arg_op_str_ymd;
				MyOraDB.Parameter_Values[2] = arg_lot_no;
				MyOraDB.Parameter_Values[3] = arg_req_no;
				MyOraDB.Parameter_Values[4] = arg_lot_seq;
				MyOraDB.Parameter_Values[5] = arg_cmp_cd;
				MyOraDB.Parameter_Values[6] = arg_str_op_cd;
				MyOraDB.Parameter_Values[7] = arg_end_op_cd;
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

		#region save



		/// <summary>
		/// Update_SPD_DAILY_OUT_MAT_AREA : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <param name="arg_req_no"></param>
		/// <param name="arg_day_seq"></param>
		/// <param name="arg_op_cd"></param>
		/// <param name="arg_line_cd"></param>
		/// <returns></returns>
		private bool Update_SPD_DAILY_OUT_MAT_AREA(string arg_factory,
			string arg_lot_no,
			string arg_lot_seq,
			string arg_req_no,
			string arg_day_seq,
			string arg_op_cd,
			string arg_line_cd)
		{     
			try
			{

				int col_ct = 10;	

				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPD_WORKSHEET_BSC.UPDATE_SPD_DAILY_OUT_AREA";

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[3] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[4] = "ARG_DAY_SEQ";
				MyOraDB.Parameter_Name[5] = "ARG_OP_CD";
				MyOraDB.Parameter_Name[6] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[7] = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[8] = "ARG_MAT_AREA";
				MyOraDB.Parameter_Name[9] = "ARG_UPD_USER";

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  
				} 
			


				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList();  

				// 각 행의 변경값 Setting
				for(int row = fgrid_DailySize.Rows.Fixed + 1; row < fgrid_DailySize.Rows.Count ; row++)
				{  
 
					vList.Add(arg_factory); 
					vList.Add(arg_lot_no); 
					vList.Add(arg_lot_seq); 
					vList.Add(arg_req_no);  
					vList.Add(arg_day_seq);
					vList.Add(arg_op_cd); 
					vList.Add(arg_line_cd); 
					vList.Add(fgrid_DailySize[row, (int)ClassLib.TBSPD_RELEASE_OUT_SIZE_AREA_BSC.IxCS_SIZE].ToString()); 
					vList.Add(fgrid_DailySize[row, (int)ClassLib.TBSPD_RELEASE_OUT_SIZE_AREA_BSC.IxMAT_AREA].ToString());  
					vList.Add(ClassLib.ComVar.This_User); 
 

				} // end for row
  
  
				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));  

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
				MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Update_SPD_DAILY_OUT_MAT_AREA",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}




		/// <summary>
		/// Update_SPD_DAILY_OUT_DEF_MAT_AREA : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_op_str_ymd"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <param name="arg_req_no"></param>
		/// <param name="arg_cmp_cd"></param>
		/// <param name="arg_str_op_cd"></param>
		/// <param name="arg_end_op_cd"></param>
		/// <returns></returns>
		private bool Update_SPD_DAILY_OUT_DEF_MAT_AREA(string arg_factory,
			string arg_op_str_ymd,
			string arg_lot_no,
			string arg_lot_seq,
			string arg_req_no,
			string arg_cmp_cd,
			string arg_str_op_cd,
			string arg_end_op_cd)
		{     

			try
			{

				int col_ct = 11; 

				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPD_WORKSHEET_BSC.UPDATE_SPD_DAILY_OUT_DEF_AREA";

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OP_STR_YMD"; 
				MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";  
				MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[4] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[5] = "ARG_CMP_CD"; 
				MyOraDB.Parameter_Name[6] = "ARG_STR_OP_CD"; 
				MyOraDB.Parameter_Name[7] = "ARG_END_OP_CD"; 
				MyOraDB.Parameter_Name[8] = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[9] = "ARG_MM_AREA";
				MyOraDB.Parameter_Name[10] = "ARG_UPD_USER";

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  
				} 
			 


				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList();  

				// 각 행의 변경값 Setting
				for(int row = fgrid_DailySize.Rows.Fixed + 1; row < fgrid_DailySize.Rows.Count ; row++)
				{  
 
					vList.Add(arg_factory); 
					vList.Add(arg_op_str_ymd); 
					vList.Add(arg_lot_no); 
					vList.Add(arg_lot_seq); 
					vList.Add(arg_req_no);  
					vList.Add(arg_cmp_cd);
					vList.Add(arg_str_op_cd); 
					vList.Add(arg_end_op_cd); 
					vList.Add(fgrid_DailySize[row, (int)ClassLib.TBSPD_RELEASE_OUT_SIZE_AREA_BSC.IxCS_SIZE].ToString()); 
					vList.Add(fgrid_DailySize[row, (int)ClassLib.TBSPD_RELEASE_OUT_SIZE_AREA_BSC.IxMAT_AREA].ToString());  
					vList.Add(ClassLib.ComVar.This_User); 
 

				} // end for row
  
  
				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));   
 
				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
				MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Update_SPD_JIT_REQ_MAT_AREA",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}





		#endregion

		
		#endregion

 



	}
}

