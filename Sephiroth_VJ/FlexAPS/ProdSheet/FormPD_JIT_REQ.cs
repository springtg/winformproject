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
	public class FormPD_JIT_REQ : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리


		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_Tail;
		private System.Windows.Forms.Panel pnl_Head;
		public System.Windows.Forms.Panel pnl_HeadSearch;
		public System.Windows.Forms.Panel panel1;
		private C1.Win.C1List.C1Combo cmb_LineCd;
		private System.Windows.Forms.Label lbl_LineCd;
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
		public System.Windows.Forms.Panel pnl_TailSearch;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle2;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.Label lbl_OpStartYMD;
		private System.Windows.Forms.Label lbl_Division;
		private C1.Win.C1List.C1Combo cmb_Division;
		private C1.Win.C1List.C1Combo cmb_Miniline;
		private System.Windows.Forms.Label lbl_MiniLine;
		private COM.FSP fgrid_LOT;
		public COM.FSP fgrid_JitReq;
		
		
		private System.ComponentModel.IContainer components = null;
   
		#endregion

		#region 생성자, 소멸자

		public FormPD_JIT_REQ()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormPD_JIT_REQ));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_Tail = new System.Windows.Forms.Panel();
			this.fgrid_JitReq = new COM.FSP();
			this.pnl_TailSearch = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.cmb_Miniline = new C1.Win.C1List.C1Combo();
			this.lbl_MiniLine = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle2 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.pnl_Head = new System.Windows.Forms.Panel();
			this.fgrid_LOT = new COM.FSP();
			this.pnl_HeadSearch = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmb_Division = new C1.Win.C1List.C1Combo();
			this.lbl_Division = new System.Windows.Forms.Label();
			this.lbl_OpStartYMD = new System.Windows.Forms.Label();
			this.cmb_LineCd = new C1.Win.C1List.C1Combo();
			this.lbl_LineCd = new System.Windows.Forms.Label();
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
			this.pnl_Tail.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_JitReq)).BeginInit();
			this.pnl_TailSearch.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Miniline)).BeginInit();
			this.pnl_Head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LOT)).BeginInit();
			this.pnl_HeadSearch.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Division)).BeginInit();
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
			// 
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Sizer1.BackColor = System.Drawing.SystemColors.Window;
			this.c1Sizer1.Controls.Add(this.pnl_Tail);
			this.c1Sizer1.Controls.Add(this.pnl_Head);
			this.c1Sizer1.GridDefinition = "59.2013888888889:True:False;38.7152777777778:False:True;\t99.2125984251968:False:F" +
				"alse;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 31;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_Tail
			// 
			this.pnl_Tail.Controls.Add(this.fgrid_JitReq);
			this.pnl_Tail.Controls.Add(this.pnl_TailSearch);
			this.pnl_Tail.Location = new System.Drawing.Point(4, 349);
			this.pnl_Tail.Name = "pnl_Tail";
			this.pnl_Tail.Size = new System.Drawing.Size(1008, 223);
			this.pnl_Tail.TabIndex = 1;
			// 
			// fgrid_JitReq
			// 
			this.fgrid_JitReq.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_JitReq.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_JitReq.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_JitReq.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_JitReq.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_JitReq.Location = new System.Drawing.Point(0, 43);
			this.fgrid_JitReq.Name = "fgrid_JitReq";
			this.fgrid_JitReq.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_JitReq.Size = new System.Drawing.Size(1008, 180);
			this.fgrid_JitReq.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_JitReq.TabIndex = 46;
			this.fgrid_JitReq.Click += new System.EventHandler(this.fgrid_JitReq_Click);
			this.fgrid_JitReq.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_JitReq_BeforeEdit);
			this.fgrid_JitReq.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_JitReq_AfterEdit);
			// 
			// pnl_TailSearch
			// 
			this.pnl_TailSearch.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_TailSearch.Controls.Add(this.pnl_SearchImage);
			this.pnl_TailSearch.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_TailSearch.DockPadding.Bottom = 5;
			this.pnl_TailSearch.Location = new System.Drawing.Point(0, 0);
			this.pnl_TailSearch.Name = "pnl_TailSearch";
			this.pnl_TailSearch.Size = new System.Drawing.Size(1008, 43);
			this.pnl_TailSearch.TabIndex = 45;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.cmb_Miniline);
			this.pnl_SearchImage.Controls.Add(this.lbl_MiniLine);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle2);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.picb_MM);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1008, 38);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// cmb_Miniline
			// 
			this.cmb_Miniline.AddItemCols = 0;
			this.cmb_Miniline.AddItemSeparator = ';';
			this.cmb_Miniline.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Miniline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Miniline.Caption = "";
			this.cmb_Miniline.CaptionHeight = 17;
			this.cmb_Miniline.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Miniline.ColumnCaptionHeight = 18;
			this.cmb_Miniline.ColumnFooterHeight = 18;
			this.cmb_Miniline.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Miniline.ContentHeight = 17;
			this.cmb_Miniline.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Miniline.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Miniline.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Miniline.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Miniline.EditorHeight = 17;
			this.cmb_Miniline.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Miniline.GapHeight = 2;
			this.cmb_Miniline.ItemHeight = 15;
			this.cmb_Miniline.Location = new System.Drawing.Point(111, 8);
			this.cmb_Miniline.MatchEntryTimeout = ((long)(2000));
			this.cmb_Miniline.MaxDropDownItems = ((short)(5));
			this.cmb_Miniline.MaxLength = 32767;
			this.cmb_Miniline.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Miniline.Name = "cmb_Miniline";
			this.cmb_Miniline.PartialRightColumn = false;
			this.cmb_Miniline.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Miniline.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Miniline.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Miniline.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Miniline.Size = new System.Drawing.Size(100, 21);
			this.cmb_Miniline.TabIndex = 120;
			// 
			// lbl_MiniLine
			// 
			this.lbl_MiniLine.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_MiniLine.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_MiniLine.ImageIndex = 0;
			this.lbl_MiniLine.ImageList = this.img_Label;
			this.lbl_MiniLine.Location = new System.Drawing.Point(10, 8);
			this.lbl_MiniLine.Name = "lbl_MiniLine";
			this.lbl_MiniLine.Size = new System.Drawing.Size(100, 21);
			this.lbl_MiniLine.TabIndex = 119;
			this.lbl_MiniLine.Text = "Miniline";
			this.lbl_MiniLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(991, 8);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(17, 22);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(992, -5);
			this.picb_TR.Name = "picb_TR";
			this.picb_TR.Size = new System.Drawing.Size(16, 13);
			this.picb_TR.TabIndex = 21;
			this.picb_TR.TabStop = false;
			// 
			// picb_TM
			// 
			this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
			this.picb_TM.Location = new System.Drawing.Point(16, 0);
			this.picb_TM.Name = "picb_TM";
			this.picb_TM.Size = new System.Drawing.Size(992, 32);
			this.picb_TM.TabIndex = 0;
			this.picb_TM.TabStop = false;
			// 
			// lbl_SubTitle2
			// 
			this.lbl_SubTitle2.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle2.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle2.Image")));
			this.lbl_SubTitle2.Location = new System.Drawing.Point(0, -2);
			this.lbl_SubTitle2.Name = "lbl_SubTitle2";
			this.lbl_SubTitle2.Size = new System.Drawing.Size(16, 8);
			this.lbl_SubTitle2.TabIndex = 28;
			this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(992, 23);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 22);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(848, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 23);
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
			this.picb_ML.Location = new System.Drawing.Point(0, 0);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(168, 30);
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
			this.picb_MM.Size = new System.Drawing.Size(840, 0);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// pnl_Head
			// 
			this.pnl_Head.Controls.Add(this.fgrid_LOT);
			this.pnl_Head.Controls.Add(this.pnl_HeadSearch);
			this.pnl_Head.Location = new System.Drawing.Point(4, 4);
			this.pnl_Head.Name = "pnl_Head";
			this.pnl_Head.Size = new System.Drawing.Size(1008, 341);
			this.pnl_Head.TabIndex = 0;
			// 
			// fgrid_LOT
			// 
			this.fgrid_LOT.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_LOT.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_LOT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_LOT.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_LOT.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_LOT.Location = new System.Drawing.Point(0, 65);
			this.fgrid_LOT.Name = "fgrid_LOT";
			this.fgrid_LOT.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_LOT.Size = new System.Drawing.Size(1008, 276);
			this.fgrid_LOT.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_LOT.TabIndex = 45;
			this.fgrid_LOT.Click += new System.EventHandler(this.fgrid_LOT_Click);
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
			this.pnl_HeadSearch.TabIndex = 44;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.cmb_Division);
			this.panel1.Controls.Add(this.lbl_Division);
			this.panel1.Controls.Add(this.lbl_OpStartYMD);
			this.panel1.Controls.Add(this.cmb_LineCd);
			this.panel1.Controls.Add(this.lbl_LineCd);
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
			// cmb_Division
			// 
			this.cmb_Division.AddItemCols = 0;
			this.cmb_Division.AddItemSeparator = ';';
			this.cmb_Division.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Division.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Division.Caption = "";
			this.cmb_Division.CaptionHeight = 17;
			this.cmb_Division.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Division.ColumnCaptionHeight = 18;
			this.cmb_Division.ColumnFooterHeight = 18;
			this.cmb_Division.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Division.ContentHeight = 17;
			this.cmb_Division.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Division.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Division.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Division.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Division.EditorHeight = 17;
			this.cmb_Division.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Division.GapHeight = 2;
			this.cmb_Division.ItemHeight = 15;
			this.cmb_Division.Location = new System.Drawing.Point(754, 34);
			this.cmb_Division.MatchEntryTimeout = ((long)(2000));
			this.cmb_Division.MaxDropDownItems = ((short)(5));
			this.cmb_Division.MaxLength = 32767;
			this.cmb_Division.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Division.Name = "cmb_Division";
			this.cmb_Division.PartialRightColumn = false;
			this.cmb_Division.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Division.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Division.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Division.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Division.Size = new System.Drawing.Size(100, 21);
			this.cmb_Division.TabIndex = 118;
			this.cmb_Division.SelectedValueChanged += new System.EventHandler(this.cmb_Division_SelectedValueChanged);
			// 
			// lbl_Division
			// 
			this.lbl_Division.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Division.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Division.ImageIndex = 0;
			this.lbl_Division.ImageList = this.img_Label;
			this.lbl_Division.Location = new System.Drawing.Point(653, 34);
			this.lbl_Division.Name = "lbl_Division";
			this.lbl_Division.Size = new System.Drawing.Size(100, 21);
			this.lbl_Division.TabIndex = 117;
			this.lbl_Division.Text = "Division";
			this.lbl_Division.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_OpStartYMD
			// 
			this.lbl_OpStartYMD.ImageIndex = 0;
			this.lbl_OpStartYMD.ImageList = this.img_Label;
			this.lbl_OpStartYMD.Location = new System.Drawing.Point(224, 34);
			this.lbl_OpStartYMD.Name = "lbl_OpStartYMD";
			this.lbl_OpStartYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_OpStartYMD.TabIndex = 35;
			this.lbl_OpStartYMD.Text = "OP Start Date";
			this.lbl_OpStartYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_LineCd.Location = new System.Drawing.Point(538, 34);
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
			this.lbl_LineCd.ImageList = this.img_Label;
			this.lbl_LineCd.Location = new System.Drawing.Point(437, 34);
			this.lbl_LineCd.Name = "lbl_LineCd";
			this.lbl_LineCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_LineCd.TabIndex = 72;
			this.lbl_LineCd.Text = "Line";
			this.lbl_LineCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_FromYMD
			// 
			this.dpick_FromYMD.CustomFormat = "yyyyMMdd";
			this.dpick_FromYMD.Enabled = false;
			this.dpick_FromYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.dpick_FromYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_FromYMD.Location = new System.Drawing.Point(325, 34);
			this.dpick_FromYMD.Name = "dpick_FromYMD";
			this.dpick_FromYMD.Size = new System.Drawing.Size(100, 22);
			this.dpick_FromYMD.TabIndex = 194;
			this.dpick_FromYMD.CloseUp += new System.EventHandler(this.dpick_FromYMD_CloseUp);
			this.dpick_FromYMD.ValueChanged += new System.EventHandler(this.dpick_FromYMD_ValueChanged);
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
			this.cmb_Factory.Location = new System.Drawing.Point(111, 34);
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
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 34);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
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
			// FormPD_JIT_REQ
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "FormPD_JIT_REQ";
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.pnl_Tail.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_JitReq)).EndInit();
			this.pnl_TailSearch.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Miniline)).EndInit();
			this.pnl_Head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LOT)).EndInit();
			this.pnl_HeadSearch.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Division)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LineCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 
		private COM.ComFunction MyComFunction = new COM.ComFunction();
 

		//수정하기 전 수량
		private string _BeforeQty;


 
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
				this.Text = "Shortage Production";
				lbl_MainTitle.Text = "Shortage Production"; 
  


				fgrid_LOT.Set_Grid("SPD_JIT_LOT", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);
				fgrid_LOT.ExtendLastCol = false;
				fgrid_LOT.AllowEditing = false;
				fgrid_LOT.Font = new Font("Verdana", 7);
 

				fgrid_JitReq.Set_Grid("SPD_JIT_REQ", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
				fgrid_JitReq.Set_Action_Image(img_Action);
				fgrid_JitReq.Mark_Grid_Menu();
				fgrid_JitReq.ExtendLastCol = false; 
				fgrid_JitReq.Font = new Font("Verdana", 7); 
 


				//Set Combo List
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
  

			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false; 
			tbtn_Color.Enabled = false;


			
//			// op_str_ymd 는 항상 오늘 이후로 설정되어야 함. 따라서, default : today + 1일
//			dpick_FromYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;  
//			dpick_FromYMD.Value = Convert.ToDateTime(MyComFunction.ConvertDate2Type(System.DateTime.Now.AddDays(1).ToString("yyyyMMdd")));


			DataTable dt_ret = null;



			cmb_Division.Enabled = false;


			dt_ret = COM.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);  
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
			 
			dt_ret.Dispose();



		} 
		
 



		#endregion
		  
		#region 조회
 

		/// <summary>
		/// Display_SPD_JIT_REQ_HEAD : 
		/// </summary>
		private void Display_SPD_JIT_REQ_HEAD()
		{

			if(cmb_Factory.SelectedIndex == -1 || cmb_LineCd.SelectedIndex == -1) return;

			fgrid_LOT.Rows.Count = fgrid_LOT.Rows.Fixed;
			fgrid_JitReq.Rows.Count = fgrid_JitReq.Rows.Fixed;

			string factory = cmb_Factory.SelectedValue.ToString();
			string op_str_ymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
			string line_cd = cmb_LineCd.SelectedValue.ToString();
			string jit_req_type = ClassLib.ComFunction.Empty_Combo(cmb_Division, "2"); // default : 2 (shortage)

			DataTable dt_ret = Select_SPD_JIT_REQ_HEAD(factory, op_str_ymd, line_cd, jit_req_type);
			
			if(dt_ret.Rows.Count == 0) return;

			fgrid_LOT.Display_Grid(dt_ret, true);

			//fgrid_LOT.AllowMerging = AllowMergingEnum.Free; 
			



		}



		/// <summary>
		/// Display_SPD_JIT_REQ_Size : 
		/// </summary> 
		private void Display_SPD_JIT_REQ_Size()
		{
 
			string factory = fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPD_JIT_REQ_BSC.IxFACTORY].ToString();
			string lot_no = fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPD_JIT_REQ_BSC.IxLOT_NO].ToString();
			string lot_seq = fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPD_JIT_REQ_BSC.IxLOT_SEQ].ToString();
			string req_no = fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPD_JIT_REQ_BSC.IxREQ_NO].ToString(); 
			string op_str_ymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
			string jit_req_type = ClassLib.ComFunction.Empty_Combo(cmb_Division, "2"); // default : 2 (shortage)


			DataTable dt_ret = Select_SPD_JIT_REQ_SIZE(factory, lot_no, lot_seq, req_no, op_str_ymd, jit_req_type);
			Display_SPD_JIT_REQ_Size(dt_ret); 

		}
			   

		/// <summary>
		/// Display_SPD_JIT_REQ_Size : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_SPD_JIT_REQ_Size(DataTable arg_dt)
		{


			string before_item = "", now_item = "";  
			int min_size_col = fgrid_JitReq.Cols.Count + 1;   //default : col max value
			int size_qty = 0, sum_size_qty = 0; 
			int insert_row = 0;


			fgrid_JitReq.Rows.Count = fgrid_JitReq.Rows.Fixed;

			if(arg_dt.Rows.Count == 0)
			{ 
				return; 
			}
			

			//--------------------------------------------------------------------------------------------------------
			// next jit req seq 구하기
			//--------------------------------------------------------------------------------------------------------
			string factory = fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPD_JIT_REQ_BSC.IxFACTORY].ToString(); 
			string op_str_ymd = dpick_FromYMD.Value.ToString("yyyyMMdd");

			DataTable dt_ret = Select_SPD_JIT_REQ_NEXT_SEQ(factory, op_str_ymd); 
			int next_seq = Convert.ToInt32(dt_ret.Rows[0].ItemArray[0].ToString() );
			//--------------------------------------------------------------------------------------------------------
 
			
			//--------------------------------------------------------------------------------------------------------
			// grid 표시
			//-------------------------------------------------------------------------------------------------------- 
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{

				now_item = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxJIT_REQ_TYPE - 1].ToString()
							+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxJIT_REQ_SEQ - 1].ToString()
							+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxCMP_CD - 1].ToString()
							+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxSTR_OP_CD - 1].ToString()
							+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxEND_OP_CD - 1].ToString();


				if(before_item != now_item)
				{
				 

					//--------------------------------------------------------------------------------------------------------
					// QD 일 경우, parent row 추가
					//--------------------------------------------------------------------------------------------------------
					if(cmb_Factory.SelectedValue.ToString() == "QD")
					{

						fgrid_JitReq.Rows.Add();

						insert_row = fgrid_JitReq.Rows.Count - 1;

						for(int j = 1; j <= (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxGEN; j++)
						{
							fgrid_JitReq[insert_row, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString(); 
						} // end for j

						fgrid_JitReq[insert_row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxOP_DIVISION] = "N";
						fgrid_JitReq[insert_row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxOP_TYPE] = "Parent";


						fgrid_JitReq.Rows[insert_row].AllowEditing = false;
						fgrid_JitReq.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrReadOnly;


						if(cmb_Division.SelectedValue.ToString() == "2") // shortage
						{
							fgrid_JitReq.Rows[insert_row].Visible = false;
						}


					}
					//--------------------------------------------------------------------------------------------------------


 
					fgrid_JitReq.Rows.Add();

					insert_row = fgrid_JitReq.Rows.Count - 1;

					for(int j = 1; j <= (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxGEN; j++)
					{
						fgrid_JitReq[insert_row, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString(); 
					} // end for j
	
					fgrid_JitReq[insert_row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxOP_DIVISION] = "Y";
					fgrid_JitReq[insert_row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxOP_TYPE] = "This OP";






					//--------------------------------------------------------------------------------------------------------
					// QD 일 경우 shortage, defective 구분에 따른 그리드 수정 권한 부여
					//--------------------------------------------------------------------------------------------------------
					if(cmb_Factory.SelectedValue.ToString() == "QD" && cmb_Division.SelectedValue.ToString() == "2") // shortage
					{
						 
						if(fgrid_JitReq[insert_row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxCMP_CD].ToString() == "FS"
							|| fgrid_JitReq[insert_row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxCMP_CD].ToString() == "UP")
						{
							fgrid_JitReq.Rows[insert_row].AllowEditing = true;
							fgrid_JitReq.Rows[insert_row].StyleNew.BackColor = Color.White;
						}
						else
						{ 
							fgrid_JitReq.Rows[insert_row].AllowEditing = false;
							fgrid_JitReq.Rows[insert_row].StyleNew.BackColor = ClassLib.ComVar.ClrReadOnly;
						}


					}
					//--------------------------------------------------------------------------------------------------------

 


					 

					//--------------------------------------------------------------------------------------------------------
					// 자동 seq 생성
					//-------------------------------------------------------------------------------------------------------- 
					if(fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPD_JIT_REQ_BSC.IxEXIST_YN].ToString().Trim() == "N")
					{
						if(cmb_Factory.SelectedValue.ToString() == "QD")
						{

							if(fgrid_JitReq[insert_row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxCMP_CD].ToString() == "FS"
								|| fgrid_JitReq[insert_row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxCMP_CD].ToString() == "UP")
							{
								fgrid_JitReq[insert_row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxJIT_REQ_SEQ] = next_seq.ToString(); 
								next_seq++;
							}


						}
						else
						{
							fgrid_JitReq[insert_row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxJIT_REQ_SEQ] = next_seq.ToString(); 
							next_seq++;
						}
						
						
						
					} 
					//--------------------------------------------------------------------------------------------------------


					//--------------------------------------------------------------------------------------------------------
					// plan_status = 'D' 이면 수정 불가
					//-------------------------------------------------------------------------------------------------------- 
					if(fgrid_JitReq[insert_row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxPLAN_STATUS].ToString() == "D")
					{
						fgrid_JitReq.Rows[insert_row].AllowEditing = false;
					}
					//--------------------------------------------------------------------------------------------------------
 
					 
					before_item = now_item;

					sum_size_qty = 0;


				} // end if



				//--------------------------------------------------------------------------------------------------------
				// 사이즈런 별 수량 표시
				//--------------------------------------------------------------------------------------------------------
				for(int j = (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxCS_SIZE_START; j < fgrid_JitReq.Cols.Count; j++)
				{
					if(fgrid_JitReq[2, j].ToString() == arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxCS_SIZE].ToString())
					{
						min_size_col = (min_size_col > j) ? j : min_size_col;

						if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxPRS_QTY] == null 
							|| arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxPRS_QTY].ToString().Trim().Equals("") )
						{
							continue;
						} 

						size_qty = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxPRS_QTY].ToString() );

						sum_size_qty += size_qty;

						fgrid_JitReq[insert_row, j] = (size_qty.ToString() == "0") ? "" : size_qty.ToString();

						
						 

						break; 
					} 
				}
				//--------------------------------------------------------------------------------------------------------

				

				//--------------------------------------------------------------------------------------------------------
				// total 수량 표시
				//--------------------------------------------------------------------------------------------------------
				fgrid_JitReq[insert_row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxTOTAL_QTY] = (sum_size_qty.ToString() == "0") ? "" : sum_size_qty.ToString();
				//--------------------------------------------------------------------------------------------------------
 


			} // end for i  
			
  

			fgrid_JitReq.LeftCol = min_size_col;






		}



		#endregion

		#region 툴바 이벤트 메서드


		/// <summary>
		/// Event_Tbtn_New : 
		/// </summary>
		private void Event_Tbtn_New()
		{
		
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
			dpick_FromYMD.Value = System.DateTime.Now;
			cmb_LineCd.SelectedIndex = -1;
			
			cmb_Division.SelectedIndex = -1;
			cmb_Miniline.SelectedIndex = -1;

			fgrid_LOT.Rows.Count = fgrid_LOT.Rows.Fixed;
			fgrid_JitReq.Rows.Count = fgrid_JitReq.Rows.Fixed;
			 

		}


		/// <summary>
		/// Event_Tbtn_Search : 
		/// </summary>
		private void Event_Tbtn_Search()
		{
 
			Display_SPD_JIT_REQ_HEAD(); 

		}


		/// <summary>
		/// Event_Tbtn_Save : 
		/// </summary>
		private void Event_Tbtn_Save()
		{
  

			// 1. jit_req
			// 2. jit_req_size
			// 3. jit_req_pcard


			
			//행 수정 상태 해제
			fgrid_JitReq.Select(fgrid_JitReq.Selection.r1, 0, fgrid_JitReq.Selection.r1, fgrid_JitReq.Cols.Count-1, false);
 


			bool save_flag = false;

			save_flag = Make_SPD_JIT_REQ(true);

			if(! save_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				return;
			}
			else
			{

				save_flag = Make_SPD_JIT_REQ_SIZE(false);

				if(! save_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}
				else
				{

					save_flag = Make_SPD_JIT_REQ_PCARD(false);

					if(! save_flag)
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						return;
					}
					else
					{

						DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

						if(ds_ret == null)
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
							return;
						}
						else
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this); 

							Event_Tbtn_Search();
						}


					} // end Make_SPD_JIT_REQ_PCARD(false);



				} // end Make_SPD_JIT_REQ_SIZE(false);



			} // end Make_SPD_JIT_REQ(true);

		}




		#endregion

		#region 그리드 이벤트 메서드


		/// <summary>
		/// Event_Click_fgrid_LOT : 
		/// </summary>
		private void Event_Click_fgrid_LOT()
		{

			if(cmb_Factory.SelectedIndex == -1) return;
			if(fgrid_LOT.Rows.Count <= fgrid_LOT.Rows.Fixed) return;

  

			// 사이즈 헤더 할당 
			fgrid_JitReq.Rows.Fixed = 2;
			ClassLib.ComFunction.Set_DefaultSize_Head(fgrid_JitReq, 
														cmb_Factory.SelectedValue.ToString(), 
														fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPD_JIT_REQ_BSC.IxGEN].ToString().Trim(), 
														fgrid_JitReq.Rows.Fixed,
														(int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxGEN,
														(int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxCS_SIZE_START);



			// 사이즈 데이터 표시
			Display_SPD_JIT_REQ_Size();
			 
 
		}


		private void Event_Click_fgrid_JitReq(System.EventArgs e)
		{
 

			if(fgrid_JitReq.Rows.Count <= fgrid_JitReq.Rows.Fixed) return;
			if(fgrid_JitReq.Selection.c1 != (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxSTR_OP_CD) return;

			
			string factory = fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPD_JIT_REQ_BSC.IxFACTORY].ToString();
			string lot_no = fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPD_JIT_REQ_BSC.IxLOT_NO].ToString();
			string lot_seq = fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPD_JIT_REQ_BSC.IxLOT_SEQ].ToString(); 
			string cmp_cd = fgrid_JitReq[fgrid_JitReq.Selection.r1, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxCMP_CD].ToString();


			DataTable dt_ret = Select_SPB_ROUT_BOM_OP_CD(factory, lot_no, lot_seq, cmp_cd);
			
			if(dt_ret == null) return;

			string new_op_cd_list = "";

			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
				new_op_cd_list += dt_ret.Rows[i].ItemArray[0].ToString() + "|";
			}

			fgrid_JitReq.Cols[(int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxSTR_OP_CD].ComboList = new_op_cd_list;


			dt_ret.Dispose();

		}


		private void Event_AfterEdit_fgrid_JitReq(C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			bool digit_flag = ClassLib.ComFunction.Check_Digit(fgrid_JitReq[e.Row, e.Col].ToString());

			if(digit_flag == false) 
			{
				fgrid_JitReq[e.Row, e.Col] = _BeforeQty;
				return;
			}
			 

			if(cmb_Factory.SelectedValue.ToString() == "QD")
			{
			

				if(cmb_Division.SelectedValue.ToString() == "2") // shortage
				{
			
					if( fgrid_JitReq[e.Row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxCMP_CD].ToString() == "FS")
					{
					 
						for(int i = e.Row + 1; i < fgrid_JitReq.Rows.Count; i++)
						{
						 
							fgrid_JitReq[i, e.Col] = fgrid_JitReq[e.Row, e.Col].ToString();
						
							Display_Total_Qty(i);

						 
						} // end for i
					} // end if

				}
				else if(cmb_Division.SelectedValue.ToString() == "3") // defective
				{



				} // end if


			}
			




			Display_Total_Qty(e.Row); 
			
 
			 

		}




		/// <summary>
		/// Display_Total_Qty : 
		/// </summary>
		/// <param name="arg_row"></param>
		private void Display_Total_Qty(int arg_row)
		{

			int sum_prs_qty = 0;


			for(int j = (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxCS_SIZE_START; j < fgrid_JitReq.Cols.Count; j++)
			{
				if(fgrid_JitReq[arg_row, j] == null || fgrid_JitReq[arg_row, j].ToString().Trim().Equals("") ) continue;

				sum_prs_qty += Convert.ToInt32(fgrid_JitReq[arg_row, j].ToString() ); 
 
			}

			fgrid_JitReq[arg_row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxTOTAL_QTY] = (sum_prs_qty == 0) ? "" : sum_prs_qty.ToString();

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

		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
		}

		
		 




		#endregion

		#region 그리드 이벤트
 

		private void fgrid_LOT_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Event_Click_fgrid_LOT();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_fgrid_LOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		private void fgrid_JitReq_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_fgrid_JitReq(e);
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_fgrid_JitReq", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  

		}

		private void fgrid_JitReq_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			try
			{
				if(fgrid_JitReq[e.Row, e.Col] == null)  fgrid_JitReq[e.Row, e.Col] = ""; 
				_BeforeQty = (fgrid_JitReq[e.Row, e.Col].ToString() == "") ? "0": fgrid_JitReq[e.Row, e.Col].ToString();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_JitReq_BeforeEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void fgrid_JitReq_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			try
			{
				Event_AfterEdit_fgrid_JitReq(e);
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_AfterEdit_fgrid_JitReq", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{

				if(cmb_Factory.SelectedIndex == -1) return;


				// 초기화
				fgrid_LOT.Rows.Count = fgrid_LOT.Rows.Fixed; 
				fgrid_JitReq.Rows.Count = fgrid_JitReq.Rows.Fixed; 



				DataTable dt_ret = null;

				string factory = cmb_Factory.SelectedValue.ToString();

				// op_str_ymd 는 항상 released date 이후로 설정되어야 함. 따라서, default : released date + 2일
				dt_ret = Select_SPD_JIT_REQ_OP_STR_DATE(factory);

				string op_str_date = "";

				if(dt_ret == null || dt_ret.Rows.Count == 0)
				{
					op_str_date = MyComFunction.ConvertDate2Type(System.DateTime.Now.AddDays(1).ToString("yyyyMMdd") );
				}
				else
				{
	
					if(dt_ret.Rows[0].ItemArray[0].ToString() == "________")
					{
						op_str_date = MyComFunction.ConvertDate2Type(System.DateTime.Now.AddDays(1).ToString("yyyyMMdd") );
					}
					else
					{
						op_str_date = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[0].ToString() );
					}


				}

				dpick_FromYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;  
				dpick_FromYMD.Value = Convert.ToDateTime(op_str_date);
 


				// 라인 정보 할당 
				dt_ret = FlexAPS.ProdBase.Form_PB_Line.Select_SPB_LINE_ROLE(factory);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LineCd, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
			
				// division 할당 (CxJitReqDivision = "SPO_JIT01")
				dt_ret = ClassLib.ComVar.Select_ComCode(factory, ClassLib.ComVar.CxJitReqDivision);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Division, 1, 2, false, COM.ComVar.ComboList_Visible.Name);
				cmb_Division.SelectedValue = "2";  // shortage

				dt_ret.Dispose();
 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void dpick_FromYMD_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{

				dpick_FromYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_FromYMD_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void dpick_FromYMD_CloseUp(object sender, System.EventArgs e)
		{

			try
			{


				// op_str_ymd 는 항상 오늘 이후로 설정되어야 함. 따라서, default : today + 1일
				string date_now = System.DateTime.Now.ToString("yyyyMMdd");
				string date_select = dpick_FromYMD.Value.ToString("yyyyMMdd");


				if(Convert.ToInt32(date_now) >= Convert.ToInt32(date_select))
				{
					string message = "You must select [op_str_date] after today.";
					ClassLib.ComFunction.User_Message(message, "Select op start day", MessageBoxButtons.OK, MessageBoxIcon.Warning);

					// default 일자 선택
					dpick_FromYMD.Value = Convert.ToDateTime(MyComFunction.ConvertDate2Type(System.DateTime.Now.AddDays(1).ToString("yyyyMMdd")));

					return;
				}


				Display_SPD_JIT_REQ_HEAD();


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
			
				if(cmb_Factory.SelectedIndex == -1 || cmb_LineCd.SelectedIndex == -1) return;


				// 미니라인 정보 할당 
				string factory = cmb_Factory.SelectedValue.ToString();
				string line_cd = cmb_LineCd.SelectedValue.ToString();
				string op_cd = ClassLib.ComVar.StdOpCd;

				DataTable dt_ret = Select_SPB_LINEOP_MINI_COMBO(factory, line_cd, op_cd);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Miniline, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
				
				if(cmb_Miniline.ListCount > 0)
				{
					cmb_Miniline.SelectedIndex = 0;
				}

				Display_SPD_JIT_REQ_HEAD();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_LineCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}
 


		
		private void cmb_Division_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				//Event_Click_fgrid_LOT();

				Event_Tbtn_Search();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Division_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		#endregion 

		#region 컨텍스트 메뉴 이벤트
 

		#endregion


		#endregion
		 
		#region 디비 연결

		#region 콤보

 
		/// <summary>
		/// Select_SPD_JIT_REQ_OP_STR_DATE : input op start date 구하기 : 현재 작업지시 완료 일자 + 2 일
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <returns></returns>
		private DataTable Select_SPD_JIT_REQ_OP_STR_DATE(string arg_factory)
		{
 
			try
			{
				string process_name = "PKG_SPD_JIT_REQ_BSC.SELECT_SPD_JIT_REQ_OP_STR_DATE";

				MyOraDB.ReDim_Parameter(2); 
  
				MyOraDB.Process_Name = process_name; 

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;  
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
				
			}
			catch
			{
				return null;
			}


		}



		/// <summary>
		/// Select_SPB_LINEOP_MINI_COMBO : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_line_cd"></param>
		/// <param name="arg_op_cd"></param>
		/// <returns></returns>
		private DataTable Select_SPB_LINEOP_MINI_COMBO(string arg_factory, string arg_line_cd, string arg_op_cd)
		{

			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPD_JIT_REQ_BSC.SELECT_SPB_LINEOP_MINI_COMBO";

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
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_line_cd;  
				MyOraDB.Parameter_Values[2] = arg_op_cd;  
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


		#endregion

		#region 조회


		/// <summary>
		/// Select_SPD_JIT_REQ_HEAD : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_op_str_ymd"></param>
		/// <param name="arg_line_cd"></param>
		/// <returns></returns>
		private DataTable Select_SPD_JIT_REQ_HEAD(string arg_factory, string arg_op_str_ymd, string arg_line_cd, string arg_jit_req_type)
		{

			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPD_JIT_REQ_BSC.SELECT_SPD_JIT_REQ_HEAD";

				MyOraDB.ReDim_Parameter(5); 
  
				MyOraDB.Process_Name = process_name; 

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_OP_STR_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_JIT_REQ_TYPE";
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor; 
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_op_str_ymd;  
				MyOraDB.Parameter_Values[2] = arg_line_cd;  
				MyOraDB.Parameter_Values[3] = arg_jit_req_type; 
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
		/// Select_SPD_JIT_REQ_SIZE : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <param name="arg_req_no"></param>
		/// <param name="arg_op_str_ymd"></param>
		/// <param name="arg_jit_req_type"></param>
		/// <returns></returns>
		private DataTable Select_SPD_JIT_REQ_SIZE(string arg_factory, 
			string arg_lot_no, 
			string arg_lot_seq, 
			string arg_req_no,
			string arg_op_str_ymd, 
			string arg_jit_req_type)
		{

			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPD_JIT_REQ_BSC.SELECT_SPD_JIT_REQ_SIZE";

				MyOraDB.ReDim_Parameter(7); 
  
				MyOraDB.Process_Name = process_name; 

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[3] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[4] = "ARG_OP_STR_YMD";
				MyOraDB.Parameter_Name[5] = "ARG_JIT_REQ_TYPE";
				MyOraDB.Parameter_Name[6] = "OUT_CURSOR"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;  
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_lot_no;  
				MyOraDB.Parameter_Values[2] = arg_lot_seq;  
				MyOraDB.Parameter_Values[3] = arg_req_no;  
				MyOraDB.Parameter_Values[4] = arg_op_str_ymd;  
				MyOraDB.Parameter_Values[5] = arg_jit_req_type;  
				MyOraDB.Parameter_Values[6] = ""; 

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
		/// Select_SPD_JIT_REQ_NEXT_SEQ : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_op_str_ymd"></param>
		/// <returns></returns>
		private DataTable Select_SPD_JIT_REQ_NEXT_SEQ(string arg_factory, string arg_op_str_ymd)
		{

			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPD_JIT_REQ_BSC.SELECT_SPD_JIT_REQ_NEXT_SEQ";

				MyOraDB.ReDim_Parameter(3); 
  
				MyOraDB.Process_Name = process_name; 

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_OP_STR_YMD"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;  
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_op_str_ymd;   
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
		/// Select_SPB_ROUT_BOM_OP_CD : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <param name="arg_cmp_cd"></param>
		/// <returns></returns>
		private DataTable Select_SPB_ROUT_BOM_OP_CD(string arg_factory, string arg_lot_no, string arg_lot_seq, string arg_cmp_cd)
		{

			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPD_JIT_REQ_BSC.SELECT_SPB_ROUT_BOM_OP_CD";

				MyOraDB.ReDim_Parameter(5); 
  
				MyOraDB.Process_Name = process_name; 

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[3] = "ARG_CMP_CD";
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;  
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_lot_no;  
				MyOraDB.Parameter_Values[2] = arg_lot_seq;  
				MyOraDB.Parameter_Values[3] = arg_cmp_cd;    
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
		/// Select_SPD_JIT_REQ_NEXT_SEQ : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_op_str_ymd"></param>
		/// <returns></returns>
		private DataTable Select_SPD_JIT_REQ_DIR_REQ_YMD(string arg_factory, string arg_op_str_ymd)
		{

			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPD_JIT_REQ_BSC.SELECT_SPD_JIT_REQ_DIR_REQ_YMD";

				MyOraDB.ReDim_Parameter(3); 
  
				MyOraDB.Process_Name = process_name; 

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_OP_STR_YMD"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;  
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_op_str_ymd;   
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


		  
		#endregion   
		
		#region 저장
 

		
		/// <summary>
		/// Make_SPD_JIT_REQ : 
		/// </summary>
		/// <param name="arg_para_clear"></param>
		/// <returns></returns>
		private bool Make_SPD_JIT_REQ(bool arg_para_clear)
		{
			
			try
			{
				int col_ct = 18;  						 
				int row;
				

				string factory = cmb_Factory.SelectedValue.ToString();
				string op_str_ymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
				string jit_req_type = ClassLib.ComFunction.Empty_Combo(cmb_Division, "2"); // shortage
				string line_cd = cmb_LineCd.SelectedValue.ToString();
				string mline_cd = cmb_Miniline.SelectedValue.ToString();
				string lot_no = fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPD_JIT_REQ_BSC.IxLOT_NO].ToString();
				string lot_seq = fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPD_JIT_REQ_BSC.IxLOT_SEQ].ToString();
				string req_no = fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPD_JIT_REQ_BSC.IxREQ_NO].ToString();
				string style_cd = fgrid_LOT[fgrid_LOT.Selection.r1, (int)ClassLib.TBSPD_JIT_REQ_BSC.IxSTYLE_CD].ToString().Replace("-", "");

				
				DataTable dt_ret1 = Select_SPD_JIT_REQ_DIR_REQ_YMD(factory, op_str_ymd);
				string dir_req_ymd = dt_ret1.Rows[0].ItemArray[0].ToString();
  




				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPD_JIT_REQ_BSC.SAVE_SPD_JIT_REQ";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_OP_STR_YMD";
				MyOraDB.Parameter_Name[3] = "ARG_JIT_REQ_TYPE";
				MyOraDB.Parameter_Name[4] = "ARG_JIT_REQ_SEQ";
				MyOraDB.Parameter_Name[5] = "ARG_CMP_CD";
				MyOraDB.Parameter_Name[6] = "ARG_STR_OP_CD";
				MyOraDB.Parameter_Name[7] = "ARG_END_OP_CD";
				MyOraDB.Parameter_Name[8] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[9] = "ARG_MLINE_CD";
				MyOraDB.Parameter_Name[10] = "ARG_AREA_FINISH_YN"; 
				MyOraDB.Parameter_Name[11] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[12] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[13] = "ARG_REQ_NO"; 
				MyOraDB.Parameter_Name[14] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[15] = "ARG_PLAN_STATUS";
				MyOraDB.Parameter_Name[16] = "ARG_DIR_REQ_YMD";
				MyOraDB.Parameter_Name[17] = "ARG_UPD_USER"; 


				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				 

				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList();  




				vList.Add("D"); 
				vList.Add(factory); 
				vList.Add(op_str_ymd); 
				vList.Add(jit_req_type);  
				vList.Add(""); 
				vList.Add("");
				vList.Add(""); 
				vList.Add(""); 
				vList.Add(""); 
				vList.Add("");  
				vList.Add("");  
				vList.Add(lot_no); 
				vList.Add(lot_seq); 
				vList.Add(req_no); 
				vList.Add(style_cd); 
				vList.Add(""); 
				vList.Add(""); 
				vList.Add("");  




				for(row = fgrid_JitReq.Rows.Fixed; row <= fgrid_JitReq.Rows.Count - 1; row++)
				{

					if(fgrid_JitReq[row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxJIT_REQ_SEQ] == null || 
						fgrid_JitReq[row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxJIT_REQ_SEQ].ToString().Trim().Equals("") ) continue;
						
 
						 
					vList.Add("I"); 
					vList.Add(factory); 
					vList.Add(op_str_ymd); 
					vList.Add(jit_req_type);  
					vList.Add(fgrid_JitReq[row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxJIT_REQ_SEQ].ToString()); 
					vList.Add(fgrid_JitReq[row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxCMP_CD].ToString());
					vList.Add(fgrid_JitReq[row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxSTR_OP_CD].ToString()); 
					vList.Add(fgrid_JitReq[row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxEND_OP_CD].ToString()); 
					vList.Add(line_cd); 
					vList.Add(mline_cd);  
					vList.Add("");  // arg_area_finish_yn
					vList.Add(lot_no); 
					vList.Add(lot_seq); 
					vList.Add(req_no); 
					vList.Add(style_cd); 
					vList.Add(fgrid_JitReq[row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxPLAN_STATUS].ToString()); 
					vList.Add(dir_req_ymd); 
					vList.Add(ClassLib.ComVar.This_User);  
 


				} // end for row

 
 

  
				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				MyOraDB.Add_Modify_Parameter(arg_para_clear);		// 파라미터 데이터를 DataSet에 추가 
				 
				return true;
				 

			}
			catch
			{
				return false;
			}

		}


		/// <summary>
		/// Make_SPD_JIT_REQ_SIZE : 
		/// </summary>
		/// <param name="arg_para_clear"></param>
		/// <returns></returns>
		private bool Make_SPD_JIT_REQ_SIZE(bool arg_para_clear)
		{
			
			try
			{
				int col_ct = 10;  						 
				int row, col;
				


				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPD_JIT_REQ_BSC.SAVE_SPD_JIT_REQ_SIZE";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_OP_STR_YMD";
				MyOraDB.Parameter_Name[3] = "ARG_JIT_REQ_TYPE";
				MyOraDB.Parameter_Name[4] = "ARG_JIT_REQ_SEQ";
				MyOraDB.Parameter_Name[5] = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[6] = "ARG_MM_AREA";
				MyOraDB.Parameter_Name[7] = "ARG_LEFT_PCS"; 
				MyOraDB.Parameter_Name[8] = "ARG_RIGHT_PCS";
				MyOraDB.Parameter_Name[9] = "ARG_PRS_QTY";  
  

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				 

				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList(); 



				string factory = cmb_Factory.SelectedValue.ToString();
				string op_str_ymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
				string jit_req_type = ClassLib.ComFunction.Empty_Combo(cmb_Division, "2"); // shortage
				 


				vList.Add("D"); 
				vList.Add(factory); 
				vList.Add(op_str_ymd); 
				vList.Add(jit_req_type);  
				vList.Add(""); 
				vList.Add("");
				vList.Add(""); 
				vList.Add(""); 
				vList.Add("");  
				vList.Add("");




				for(row = fgrid_JitReq.Rows.Fixed; row <= fgrid_JitReq.Rows.Count - 1; row++)
				{

					if(fgrid_JitReq[row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxJIT_REQ_SEQ] == null || 
						fgrid_JitReq[row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxJIT_REQ_SEQ].ToString().Trim().Equals("") ) continue;
						

					for(col = (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxCS_SIZE_START; col < fgrid_JitReq.Cols.Count; col++)
					{  
						
						if(fgrid_JitReq[row, col] == null 
							|| fgrid_JitReq[row, col].ToString() == "" 
							|| fgrid_JitReq[row, col].ToString() == "0") continue;
						
						 
						vList.Add("I"); 
						vList.Add(factory); 
						vList.Add(op_str_ymd); 
						vList.Add(jit_req_type);  
						vList.Add(fgrid_JitReq[row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxJIT_REQ_SEQ].ToString()); 
						vList.Add(fgrid_JitReq[2, col].ToString());
						vList.Add("000");  // arg_mat_area
						vList.Add(fgrid_JitReq[row, col].ToString()); // left_pcs
						vList.Add(fgrid_JitReq[row, col].ToString()); // right_pcs
						vList.Add(fgrid_JitReq[row, col].ToString()); // prs_qty


					} // end for col 


				} // end for row
  
  
				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				MyOraDB.Add_Modify_Parameter(arg_para_clear);		// 파라미터 데이터를 DataSet에 추가 
				 
				return true;
				 

			}
			catch
			{
				return false;
			}

		}


		/// <summary>
		/// Make_SPD_JIT_REQ_PCARD : 
		/// </summary>
		/// <param name="arg_para_clear"></param>
		/// <returns></returns>
		private bool Make_SPD_JIT_REQ_PCARD(bool arg_para_clear)
		{
			
			try
			{
				int col_ct = 4;   
				int row;
				 

				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPD_JIT_REQ_BSC.SAVE_SPD_JIT_REQ_PCARD";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OP_STR_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_JIT_REQ_TYPE";
				MyOraDB.Parameter_Name[3] = "ARG_JIT_REQ_SEQ";

  

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				 

				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList(); 



				string factory = cmb_Factory.SelectedValue.ToString();
				string op_str_ymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
				string jit_req_type = ClassLib.ComFunction.Empty_Combo(cmb_Division, "2"); // shortage
				  


				for(row = fgrid_JitReq.Rows.Fixed; row <= fgrid_JitReq.Rows.Count - 1; row++)
				{

					if(fgrid_JitReq[row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxJIT_REQ_SEQ] == null || 
						fgrid_JitReq[row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxJIT_REQ_SEQ].ToString().Trim().Equals("") ) continue;
						
 
					vList.Add(factory); 
					vList.Add(op_str_ymd); 
					vList.Add(jit_req_type);  
					vList.Add(fgrid_JitReq[row, (int)ClassLib.TBSPD_JIT_REQ_SIZE_BSC.IxJIT_REQ_SEQ].ToString());  

 
				} // end for row
  
  
				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				MyOraDB.Add_Modify_Parameter(arg_para_clear);		// 파라미터 데이터를 DataSet에 추가 
				 
				return true;
				 

			}
			catch
			{
				return false;
			}

		}





		#endregion   


		#endregion



		
	}
}

