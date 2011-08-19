using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.SysBase
{
	public class Pop_PS_NoticeUser : COM.APSWinForm.Pop_Large
	{
		public COM.FSP fgrid_Notice;
		private System.ComponentModel.IContainer components = null;

		#region 사용자 변수
		private int _RowFixed;
		public System.Windows.Forms.Panel pnl_Semlpe;
		private System.Windows.Forms.TextBox txt_Search;
		private C1.Win.C1List.C1Combo cmb_Seach;
		private System.Windows.Forms.Label lbl_Search;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label btn_SelectFile;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		private System.Windows.Forms.Label btn_PopPgId;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_ML;
		private C1.Win.C1Command.C1ToolBar c1ToolBar2;
		public System.Windows.Forms.PictureBox picb_MM;
		private C1.Win.C1Command.C1ToolBar c1ToolBar1;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private C1.Win.C1Command.C1CommandLink c1CommandLink1;
		private System.Windows.Forms.ImageList img_MiniButton;
		private C1.Win.C1Command.C1Command tbtn_search;
		private COM.OraDB oraDB = null;
		#endregion

		public Pop_PS_NoticeUser()
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_NoticeUser));
			this.fgrid_Notice = new COM.FSP();
			this.pnl_Semlpe = new System.Windows.Forms.Panel();
			this.txt_Search = new System.Windows.Forms.TextBox();
			this.cmb_Seach = new C1.Win.C1List.C1Combo();
			this.lbl_Search = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.btn_SelectFile = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.btn_PopPgId = new System.Windows.Forms.Label();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.c1ToolBar2 = new C1.Win.C1Command.C1ToolBar();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.c1ToolBar1 = new C1.Win.C1Command.C1ToolBar();
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.tbtn_search = new C1.Win.C1Command.C1Command();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Notice)).BeginInit();
			this.pnl_Semlpe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Seach)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
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
			// fgrid_Notice
			// 
			this.fgrid_Notice.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Notice.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Notice.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Notice.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Notice.Location = new System.Drawing.Point(8, 136);
			this.fgrid_Notice.Name = "fgrid_Notice";
			this.fgrid_Notice.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Notice.Size = new System.Drawing.Size(680, 296);
			this.fgrid_Notice.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Notice.TabIndex = 97;
			this.fgrid_Notice.DoubleClick += new System.EventHandler(this.fgrid_Notice_DoubleClick);
			// 
			// pnl_Semlpe
			// 
			this.pnl_Semlpe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Semlpe.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Semlpe.Controls.Add(this.txt_Search);
			this.pnl_Semlpe.Controls.Add(this.cmb_Seach);
			this.pnl_Semlpe.Controls.Add(this.lbl_Search);
			this.pnl_Semlpe.Controls.Add(this.picb_BR);
			this.pnl_Semlpe.Controls.Add(this.picb_BL);
			this.pnl_Semlpe.Controls.Add(this.pnl_SearchImage);
			this.pnl_Semlpe.DockPadding.All = 8;
			this.pnl_Semlpe.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_Semlpe.Location = new System.Drawing.Point(0, 64);
			this.pnl_Semlpe.Name = "pnl_Semlpe";
			this.pnl_Semlpe.Size = new System.Drawing.Size(696, 72);
			this.pnl_Semlpe.TabIndex = 101;
			// 
			// txt_Search
			// 
			this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Search.Location = new System.Drawing.Point(330, 36);
			this.txt_Search.Name = "txt_Search";
			this.txt_Search.Size = new System.Drawing.Size(210, 21);
			this.txt_Search.TabIndex = 97;
			this.txt_Search.Text = "";
			// 
			// cmb_Seach
			// 
			this.cmb_Seach.AddItemCols = 0;
			this.cmb_Seach.AddItemSeparator = ';';
			this.cmb_Seach.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Seach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Seach.Caption = "";
			this.cmb_Seach.CaptionHeight = 17;
			this.cmb_Seach.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Seach.ColumnCaptionHeight = 18;
			this.cmb_Seach.ColumnFooterHeight = 18;
			this.cmb_Seach.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Seach.ContentHeight = 17;
			this.cmb_Seach.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Seach.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Seach.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Seach.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Seach.EditorHeight = 17;
			this.cmb_Seach.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Seach.GapHeight = 2;
			this.cmb_Seach.ItemHeight = 15;
			this.cmb_Seach.Location = new System.Drawing.Point(119, 36);
			this.cmb_Seach.MatchEntryTimeout = ((long)(2000));
			this.cmb_Seach.MaxDropDownItems = ((short)(5));
			this.cmb_Seach.MaxLength = 32767;
			this.cmb_Seach.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Seach.Name = "cmb_Seach";
			this.cmb_Seach.PartialRightColumn = false;
			this.cmb_Seach.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Seach.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Seach.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Seach.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Seach.Size = new System.Drawing.Size(210, 21);
			this.cmb_Seach.TabIndex = 96;
			// 
			// lbl_Search
			// 
			this.lbl_Search.ImageIndex = 0;
			this.lbl_Search.ImageList = this.img_Label;
			this.lbl_Search.Location = new System.Drawing.Point(18, 36);
			this.lbl_Search.Name = "lbl_Search";
			this.lbl_Search.Size = new System.Drawing.Size(100, 21);
			this.lbl_Search.TabIndex = 70;
			this.lbl_Search.Text = " 검색 조건";
			this.lbl_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(672, 48);
			this.picb_BR.Name = "picb_BR";
			this.picb_BR.Size = new System.Drawing.Size(16, 16);
			this.picb_BR.TabIndex = 95;
			this.picb_BR.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(8, 44);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(32, 20);
			this.picb_BL.TabIndex = 94;
			this.picb_BL.TabStop = false;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.btn_SelectFile);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.btn_PopPgId);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.c1ToolBar2);
			this.pnl_SearchImage.Controls.Add(this.picb_MM);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(680, 56);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// btn_SelectFile
			// 
			this.btn_SelectFile.Location = new System.Drawing.Point(270, 58);
			this.btn_SelectFile.Name = "btn_SelectFile";
			this.btn_SelectFile.Size = new System.Drawing.Size(21, 21);
			this.btn_SelectFile.TabIndex = 36;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(665, 26);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(15, 15);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(664, 0);
			this.picb_TR.Name = "picb_TR";
			this.picb_TR.Size = new System.Drawing.Size(16, 32);
			this.picb_TR.TabIndex = 21;
			this.picb_TR.TabStop = false;
			// 
			// btn_PopPgId
			// 
			this.btn_PopPgId.BackColor = System.Drawing.SystemColors.Window;
			this.btn_PopPgId.Location = new System.Drawing.Point(412, 24);
			this.btn_PopPgId.Name = "btn_PopPgId";
			this.btn_PopPgId.Size = new System.Drawing.Size(21, 21);
			this.btn_PopPgId.TabIndex = 34;
			this.btn_PopPgId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picb_TM
			// 
			this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
			this.picb_TM.Location = new System.Drawing.Point(224, 0);
			this.picb_TM.Name = "picb_TM";
			this.picb_TM.Size = new System.Drawing.Size(1664, 32);
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
			this.lbl_SubTitle1.Text = "      Notice List";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BM
			// 
			this.picb_BM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
			this.picb_BM.Location = new System.Drawing.Point(-128, 38);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(952, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_ML
			// 
			this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 24);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(168, 608);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// c1ToolBar2
			// 
			this.c1ToolBar2.AutoSize = false;
			this.c1ToolBar2.BackColor = System.Drawing.SystemColors.Window;
			this.c1ToolBar2.ButtonLookVert = C1.Win.C1Command.ButtonLookFlags.TextAndImage;
			this.c1ToolBar2.CommandHolder = null;
			this.c1ToolBar2.CustomizeOptions = C1.Win.C1Command.CustomizeOptionsFlags.AllowAll;
			this.c1ToolBar2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1ToolBar2.Horizontal = false;
			this.c1ToolBar2.Location = new System.Drawing.Point(0, 0);
			this.c1ToolBar2.Movable = false;
			this.c1ToolBar2.Name = "c1ToolBar2";
			this.c1ToolBar2.Size = new System.Drawing.Size(680, 56);
			this.c1ToolBar2.Text = "Page 1";
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
			this.picb_MM.Size = new System.Drawing.Size(1720, 608);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.CommandHolder = this.c1CommandHolder1;
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink1);
			this.c1ToolBar1.CustomizeOptions = C1.Win.C1Command.CustomizeOptionsFlags.AllowAll;
			this.c1ToolBar1.Location = new System.Drawing.Point(658, 8);
			this.c1ToolBar1.MinButtonSize = 30;
			this.c1ToolBar1.Movable = false;
			this.c1ToolBar1.Name = "c1ToolBar1";
			this.c1ToolBar1.Size = new System.Drawing.Size(30, 30);
			this.c1ToolBar1.Text = "c1ToolBar1";
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.tbtn_search);
			this.c1CommandHolder1.ImageList = this.img_MiniButton;
			this.c1CommandHolder1.ImageTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			this.c1CommandHolder1.LookAndFeel = C1.Win.C1Command.LookAndFeelEnum.Classic;
			this.c1CommandHolder1.Owner = this;
			// 
			// tbtn_search
			// 
			this.tbtn_search.ImageIndex = 10;
			this.tbtn_search.Name = "tbtn_search";
			this.tbtn_search.Text = "Search";
			this.tbtn_search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_search_Click);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			// 
			// c1CommandLink1
			// 
			this.c1CommandLink1.Command = this.tbtn_search;
			// 
			// Pop_PS_NoticeUser
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 440);
			this.Controls.Add(this.c1ToolBar1);
			this.Controls.Add(this.pnl_Semlpe);
			this.Controls.Add(this.fgrid_Notice);
			this.Name = "Pop_PS_NoticeUser";
			this.Text = "Notice";
			this.Load += new System.EventHandler(this.Form_PS_NoticeAdmin_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.fgrid_Notice, 0);
			this.Controls.SetChildIndex(this.pnl_Semlpe, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Notice)).EndInit();
			this.pnl_Semlpe.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Seach)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PS_NoticeAdmin_Load(object sender, System.EventArgs e)
		{
			init_Form();
		}

		private void init_Form()
		{

			this.lbl_MainTitle.Text = "Notice List";
			


			oraDB = new COM.OraDB();

			DataTable dt = oraDB.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSearchHome);
			ClassLib.ComCtl.Set_ComboList(dt, cmb_Seach, 1, 2, true);
			cmb_Seach.SelectedIndex = 0;

			//그리드 설정
			fgrid_Notice.Set_Grid_Comm("SPS_NOTICE","1", 1,ClassLib.ComVar.This_Lang,COM.ComVar.Grid_Type.ForSearch, true);
			_RowFixed = fgrid_Notice.Rows.Fixed;
			Get_Notice_List("U", "");
		}

		public void Get_Notice_List(string arg_div, string arg_value)
		{
			fgrid_Notice.Rows.Count = _RowFixed;

			DataTable dt = Select_SPS_Notice(arg_div, arg_value);

			int rowcount = dt.Rows.Count;
			int colcount = dt.Columns.Count;
			string data  = null;

			COM.ComFunction comfunc = new COM.ComFunction();

			for(int i=0; i<rowcount; i++)
			{
				string[] ArrayItem = new string[colcount+1];

				ArrayItem[0] = "";

				for(int j=0; j<colcount; j++)
				{
					if(j == 4 || j == 5)
					{
						data = comfunc.ConvertDate2Type(dt.Rows[i].ItemArray[j].ToString());//DateType 변환
					}
					else if(j == 6)
					{
						data = Return_TrueFalse(dt.Rows[i].ItemArray[j].ToString()).ToString(); //Show_YN
					}
					else
					{
						data = dt.Rows[i].ItemArray[j].ToString();
					}


					ArrayItem[j+1] = data;


				}

				fgrid_Notice.AddItem(ArrayItem, _RowFixed, 0);
			}

			fgrid_Notice.AutoSizeCols();
			fgrid_Notice.Cols[7].Visible = false;
		}

		/// <summary>
		/// Return_TrueFalse : Y, N을 bool형 으로
		/// </summary>
		/// <param name="arg_yn">Y/N</param>
		/// <returns>Y:true, N:false</returns>
		private bool Return_TrueFalse(string arg_yn)
		{
			bool TrueFalse;

			if(arg_yn == "Y")
				TrueFalse = true;
			else
				TrueFalse = false;

			return TrueFalse;
		}

		/// <summary>
		/// ViweNotice : 공지 사항 상세 보기
		/// </summary>
		/// <param name="arg_rownum">선택 ROW수</param>
		private void ViweNotice(int arg_rownum)
		{
			int rownum = arg_rownum;
			string arg_factory = fgrid_Notice[rownum, (int)ClassLib.TBSPS_NOTICE.IxFACTORY].ToString();
			string arg_seq     = fgrid_Notice[rownum, (int)ClassLib.TBSPS_NOTICE.IxSEQ].ToString();
			Pop_PS_NoticeView psNoticeView = new Pop_PS_NoticeView(arg_factory, arg_seq);
			psNoticeView.MdiParent = ClassLib.ComVar.arg_form;
			ClassLib.ComVar.MenuClick_Flag = true;
			psNoticeView.Show();
		}


		#region 이벤트


		

		private void fgrid_Notice_DoubleClick(object sender, System.EventArgs e)
		{
			int rownum = fgrid_Notice.Selection.r1;
			ViweNotice(rownum);
		}
		
		private void tbtn_search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			string arg_value = txt_Search.Text;

			if(cmb_Seach.SelectedIndex == 0)
				Get_Notice_List("U", "");
			else if(cmb_Seach.SelectedValue.ToString() == "T")
				Get_Notice_List("T", arg_value);
			else if(cmb_Seach.SelectedValue.ToString() == "C")
				Get_Notice_List("C", arg_value);
		}

		#endregion

		#region DB 접속

		/// <summary>
		/// Select_SPS_Notice : 공지사항 리스트 가져오기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <returns>정상:DATETABLE 오류:NULL</returns>
		private DataTable Select_SPS_Notice(string arg_div, string arg_value)
		{

			string Proc_Name = "PKG_SPS_HOME.SELECT_SPS_NOTICE_USER";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_DIVISION";
			oraDB.Parameter_Name[2] = "ARG_VALUE";
			oraDB.Parameter_Name[3] = "OUT_CURSOR"; 
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = arg_div;
			oraDB.Parameter_Values[2] = arg_value;
			oraDB.Parameter_Values[3] = "";


			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		/// <summary>
		///  Delete_Notic : 공지사항 삭제
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_seq">SEQ</param>
		private void Delete_Notice(string arg_factory, string arg_seq)
		{

			string Proc_Name = "PKG_SPS_HOME.Delete_SPS_NOTICE";

		
			oraDB.ReDim_Parameter(2);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_SEQ";
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_seq;

			oraDB.Add_Modify_Parameter(false).ToString();
			oraDB.Exe_Modify_Procedure().ToString();
		}

		#endregion

		

		

		
	}
}

