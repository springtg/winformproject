using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.SysBase
{
	public class Pop_PS_NoticeUser_List : COM.APSWinForm.Form_Top
	{
		private C1.Win.C1Command.C1OutBar obar_Main;
		private C1.Win.C1Command.C1OutPage obarpg_SendMess;
		private System.Windows.Forms.Panel pnl_MLBody;
		private C1.Win.C1Command.C1OutPage obarpg_ReceiveMess;
		public System.Windows.Forms.Panel pnl_receive;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_ML;
		private C1.Win.C1Command.C1ToolBar c1ToolBar2;
		public System.Windows.Forms.PictureBox picb_MM;

		public System.Windows.Forms.Panel pnl_send;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		private C1.Win.C1Command.C1ToolBar c1ToolBar3;
		public System.Windows.Forms.PictureBox pictureBox8;
		private System.ComponentModel.IContainer components = null;




		#region 사용자 변수

		private int _RowFixed;
		private COM.FSP fgrid_send_list;
		public COM.FSP fgrid_receive_list;
		private System.Windows.Forms.Label lbl_Search;
		private C1.Win.C1List.C1Combo cmb_Seach;
		private System.Windows.Forms.TextBox txt_Search;
		private C1.Win.C1List.C1Combo cmb_Search_S;
		private System.Windows.Forms.Label lbl_Search_S;
		private System.Windows.Forms.TextBox txt_Search_S;
		private COM.OraDB oraDB = null;


		#endregion

		public Pop_PS_NoticeUser_List()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_NoticeUser_List));
			this.obar_Main = new C1.Win.C1Command.C1OutBar();
			this.obarpg_ReceiveMess = new C1.Win.C1Command.C1OutPage();
			this.fgrid_receive_list = new COM.FSP();
			this.pnl_receive = new System.Windows.Forms.Panel();
			this.txt_Search = new System.Windows.Forms.TextBox();
			this.lbl_Search = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.cmb_Seach = new C1.Win.C1List.C1Combo();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.c1ToolBar2 = new C1.Win.C1Command.C1ToolBar();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.obarpg_SendMess = new C1.Win.C1Command.C1OutPage();
			this.pnl_MLBody = new System.Windows.Forms.Panel();
			this.fgrid_send_list = new COM.FSP();
			this.pnl_send = new System.Windows.Forms.Panel();
			this.txt_Search_S = new System.Windows.Forms.TextBox();
			this.lbl_Search_S = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.cmb_Search_S = new C1.Win.C1List.C1Combo();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.c1ToolBar3 = new C1.Win.C1Command.C1ToolBar();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.obar_Main)).BeginInit();
			this.obar_Main.SuspendLayout();
			this.obarpg_ReceiveMess.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_receive_list)).BeginInit();
			this.pnl_receive.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Seach)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
			this.obarpg_SendMess.SuspendLayout();
			this.pnl_MLBody.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_send_list)).BeginInit();
			this.pnl_send.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Search_S)).BeginInit();
			this.panel2.SuspendLayout();
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
			// tbtn_Search
			// 
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// tbtn_Append
			// 
			this.tbtn_Append.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Append_Click);
			// 
			// tbtn_Delete
			// 
			this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
			// 
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// obar_Main
			// 
			this.obar_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.obar_Main.BackColor = System.Drawing.SystemColors.Window;
			this.obar_Main.Controls.Add(this.obarpg_ReceiveMess);
			this.obar_Main.Controls.Add(this.obarpg_SendMess);
			this.obar_Main.Location = new System.Drawing.Point(8, 64);
			this.obar_Main.Name = "obar_Main";
			this.obar_Main.Pages.Add(this.obarpg_ReceiveMess);
			this.obar_Main.Pages.Add(this.obarpg_SendMess);
			this.obar_Main.SelectedIndex = 1;
			this.obar_Main.Size = new System.Drawing.Size(1000, 576);
			this.obar_Main.Text = "c1OutBar1";
			this.obar_Main.SelectedPageChanged += new System.EventHandler(this.obar_Main_SelectedPageChanged);
			// 
			// obarpg_ReceiveMess
			// 
			this.obarpg_ReceiveMess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.obarpg_ReceiveMess.Controls.Add(this.fgrid_receive_list);
			this.obarpg_ReceiveMess.Controls.Add(this.pnl_receive);
			this.obarpg_ReceiveMess.DockPadding.All = 8;
			this.obarpg_ReceiveMess.Location = new System.Drawing.Point(0, 0);
			this.obarpg_ReceiveMess.Name = "obarpg_ReceiveMess";
			this.obarpg_ReceiveMess.Size = new System.Drawing.Size(0, 0);
			this.obarpg_ReceiveMess.TabIndex = 1;
			this.obarpg_ReceiveMess.Text = "Receive Message List";
			// 
			// fgrid_receive_list
			// 
			this.fgrid_receive_list.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_receive_list.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_receive_list.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_receive_list.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_receive_list.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_receive_list.Location = new System.Drawing.Point(8, 80);
			this.fgrid_receive_list.Name = "fgrid_receive_list";
			this.fgrid_receive_list.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_receive_list.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_receive_list.TabIndex = 98;
			this.fgrid_receive_list.DoubleClick += new System.EventHandler(this.fgrid_receive_list_DoubleClick);
			// 
			// pnl_receive
			// 
			this.pnl_receive.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_receive.Controls.Add(this.txt_Search);
			this.pnl_receive.Controls.Add(this.lbl_Search);
			this.pnl_receive.Controls.Add(this.picb_BR);
			this.pnl_receive.Controls.Add(this.picb_BL);
			this.pnl_receive.Controls.Add(this.cmb_Seach);
			this.pnl_receive.Controls.Add(this.pnl_SearchImage);
			this.pnl_receive.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_receive.DockPadding.Bottom = 8;
			this.pnl_receive.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_receive.Location = new System.Drawing.Point(8, 8);
			this.pnl_receive.Name = "pnl_receive";
			this.pnl_receive.Size = new System.Drawing.Size(0, 72);
			this.pnl_receive.TabIndex = 83;
			// 
			// txt_Search
			// 
			this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Search.Location = new System.Drawing.Point(292, 36);
			this.txt_Search.Name = "txt_Search";
			this.txt_Search.Size = new System.Drawing.Size(210, 21);
			this.txt_Search.TabIndex = 98;
			this.txt_Search.Text = "";
			// 
			// lbl_Search
			// 
			this.lbl_Search.ImageIndex = 0;
			this.lbl_Search.ImageList = this.img_Label;
			this.lbl_Search.Location = new System.Drawing.Point(10, 36);
			this.lbl_Search.Name = "lbl_Search";
			this.lbl_Search.Size = new System.Drawing.Size(100, 21);
			this.lbl_Search.TabIndex = 70;
			this.lbl_Search.Text = " 검색조건";
			this.lbl_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(-16, 48);
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
			this.picb_BL.Location = new System.Drawing.Point(0, 44);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(32, 20);
			this.picb_BL.TabIndex = 94;
			this.picb_BL.TabStop = false;
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
			this.cmb_Seach.Location = new System.Drawing.Point(111, 36);
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
			this.cmb_Seach.Size = new System.Drawing.Size(180, 21);
			this.cmb_Seach.TabIndex = 74;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.c1ToolBar2);
			this.pnl_SearchImage.Controls.Add(this.picb_MM);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(0, 64);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(-15, 26);
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
			this.picb_TR.Location = new System.Drawing.Point(-16, 0);
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
			this.picb_TM.Size = new System.Drawing.Size(984, 32);
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
			this.lbl_SubTitle1.Text = "      Message List";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BM
			// 
			this.picb_BM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
			this.picb_BM.Location = new System.Drawing.Point(-468, 46);
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
			this.picb_ML.Size = new System.Drawing.Size(168, 616);
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
			this.c1ToolBar2.Size = new System.Drawing.Size(0, 64);
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
			this.picb_MM.Size = new System.Drawing.Size(1040, 616);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// obarpg_SendMess
			// 
			this.obarpg_SendMess.Controls.Add(this.pnl_MLBody);
			this.obarpg_SendMess.Location = new System.Drawing.Point(0, 40);
			this.obarpg_SendMess.Name = "obarpg_SendMess";
			this.obarpg_SendMess.Size = new System.Drawing.Size(1000, 516);
			this.obarpg_SendMess.TabIndex = 2;
			this.obarpg_SendMess.Text = "Send Message List";
			// 
			// pnl_MLBody
			// 
			this.pnl_MLBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_MLBody.Controls.Add(this.fgrid_send_list);
			this.pnl_MLBody.Controls.Add(this.pnl_send);
			this.pnl_MLBody.DockPadding.All = 8;
			this.pnl_MLBody.Location = new System.Drawing.Point(0, 0);
			this.pnl_MLBody.Name = "pnl_MLBody";
			this.pnl_MLBody.Size = new System.Drawing.Size(1000, 516);
			this.pnl_MLBody.TabIndex = 30;
			// 
			// fgrid_send_list
			// 
			this.fgrid_send_list.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_send_list.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_send_list.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_send_list.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_send_list.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_send_list.Location = new System.Drawing.Point(8, 80);
			this.fgrid_send_list.Name = "fgrid_send_list";
			this.fgrid_send_list.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_send_list.Size = new System.Drawing.Size(984, 428);
			this.fgrid_send_list.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_send_list.TabIndex = 100;
			this.fgrid_send_list.DoubleClick += new System.EventHandler(this.fgrid_send_list_DoubleClick);
			// 
			// pnl_send
			// 
			this.pnl_send.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_send.Controls.Add(this.txt_Search_S);
			this.pnl_send.Controls.Add(this.lbl_Search_S);
			this.pnl_send.Controls.Add(this.pictureBox1);
			this.pnl_send.Controls.Add(this.pictureBox2);
			this.pnl_send.Controls.Add(this.cmb_Search_S);
			this.pnl_send.Controls.Add(this.panel2);
			this.pnl_send.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_send.DockPadding.Bottom = 8;
			this.pnl_send.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_send.Location = new System.Drawing.Point(8, 8);
			this.pnl_send.Name = "pnl_send";
			this.pnl_send.Size = new System.Drawing.Size(984, 72);
			this.pnl_send.TabIndex = 99;
			// 
			// txt_Search_S
			// 
			this.txt_Search_S.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Search_S.Location = new System.Drawing.Point(292, 36);
			this.txt_Search_S.Name = "txt_Search_S";
			this.txt_Search_S.Size = new System.Drawing.Size(210, 21);
			this.txt_Search_S.TabIndex = 99;
			this.txt_Search_S.Text = "";
			// 
			// lbl_Search_S
			// 
			this.lbl_Search_S.ImageIndex = 0;
			this.lbl_Search_S.ImageList = this.img_Label;
			this.lbl_Search_S.Location = new System.Drawing.Point(10, 36);
			this.lbl_Search_S.Name = "lbl_Search_S";
			this.lbl_Search_S.Size = new System.Drawing.Size(100, 21);
			this.lbl_Search_S.TabIndex = 70;
			this.lbl_Search_S.Text = " 검색조건";
			this.lbl_Search_S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(968, 48);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(16, 16);
			this.pictureBox1.TabIndex = 95;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(0, 44);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(32, 20);
			this.pictureBox2.TabIndex = 94;
			this.pictureBox2.TabStop = false;
			// 
			// cmb_Search_S
			// 
			this.cmb_Search_S.AddItemCols = 0;
			this.cmb_Search_S.AddItemSeparator = ';';
			this.cmb_Search_S.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Search_S.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Search_S.Caption = "";
			this.cmb_Search_S.CaptionHeight = 17;
			this.cmb_Search_S.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Search_S.ColumnCaptionHeight = 18;
			this.cmb_Search_S.ColumnFooterHeight = 18;
			this.cmb_Search_S.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Search_S.ContentHeight = 17;
			this.cmb_Search_S.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Search_S.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Search_S.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Search_S.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Search_S.EditorHeight = 17;
			this.cmb_Search_S.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Search_S.GapHeight = 2;
			this.cmb_Search_S.ItemHeight = 15;
			this.cmb_Search_S.Location = new System.Drawing.Point(111, 36);
			this.cmb_Search_S.MatchEntryTimeout = ((long)(2000));
			this.cmb_Search_S.MaxDropDownItems = ((short)(5));
			this.cmb_Search_S.MaxLength = 32767;
			this.cmb_Search_S.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Search_S.Name = "cmb_Search_S";
			this.cmb_Search_S.PartialRightColumn = false;
			this.cmb_Search_S.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Search_S.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Search_S.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Search_S.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Search_S.Size = new System.Drawing.Size(180, 21);
			this.cmb_Search_S.TabIndex = 74;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Controls.Add(this.pictureBox4);
			this.panel2.Controls.Add(this.pictureBox5);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.pictureBox6);
			this.panel2.Controls.Add(this.pictureBox7);
			this.panel2.Controls.Add(this.c1ToolBar3);
			this.panel2.Controls.Add(this.pictureBox8);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(984, 64);
			this.panel2.TabIndex = 18;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(969, 26);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(15, 23);
			this.pictureBox3.TabIndex = 26;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(968, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(16, 32);
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
			this.pictureBox5.Size = new System.Drawing.Size(1968, 32);
			this.pictureBox5.TabIndex = 0;
			this.pictureBox5.TabStop = false;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Window;
			this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Navy;
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(231, 30);
			this.label3.TabIndex = 28;
			this.label3.Text = "      언어 추출";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(24, 46);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(952, 18);
			this.pictureBox6.TabIndex = 24;
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
			this.pictureBox7.Size = new System.Drawing.Size(168, 616);
			this.pictureBox7.TabIndex = 25;
			this.pictureBox7.TabStop = false;
			// 
			// c1ToolBar3
			// 
			this.c1ToolBar3.AutoSize = false;
			this.c1ToolBar3.BackColor = System.Drawing.SystemColors.Window;
			this.c1ToolBar3.ButtonLookVert = C1.Win.C1Command.ButtonLookFlags.TextAndImage;
			this.c1ToolBar3.CommandHolder = null;
			this.c1ToolBar3.CustomizeOptions = C1.Win.C1Command.CustomizeOptionsFlags.AllowAll;
			this.c1ToolBar3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1ToolBar3.Horizontal = false;
			this.c1ToolBar3.Location = new System.Drawing.Point(0, 0);
			this.c1ToolBar3.Movable = false;
			this.c1ToolBar3.Name = "c1ToolBar3";
			this.c1ToolBar3.Size = new System.Drawing.Size(984, 64);
			this.c1ToolBar3.Text = "Page 1";
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
			this.pictureBox8.Size = new System.Drawing.Size(2024, 616);
			this.pictureBox8.TabIndex = 27;
			this.pictureBox8.TabStop = false;
			// 
			// Pop_PS_NoticeUser_List
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.obar_Main);
			this.Name = "Pop_PS_NoticeUser_List";
			this.Text = "Individual Message List";
			this.Load += new System.EventHandler(this.Form_PS_NoticeUser_List_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.obar_Main, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.obar_Main)).EndInit();
			this.obar_Main.ResumeLayout(false);
			this.obarpg_ReceiveMess.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_receive_list)).EndInit();
			this.pnl_receive.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Seach)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			this.obarpg_SendMess.ResumeLayout(false);
			this.pnl_MLBody.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_send_list)).EndInit();
			this.pnl_send.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Search_S)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PS_NoticeUser_List_Load(object sender, System.EventArgs e)
		{
			init_Form();
		}


		private void init_Form()
		{
			this.lbl_MainTitle.Text = "Individual Message List";

			oraDB = new COM.OraDB();

			Receive_Page();


		}


		private void Receive_Page()
		{
			obar_Main.SelectedIndex = 0;



			DataTable dt = oraDB.Select_ComCode(ClassLib.ComVar.This_Factory, "PS10");
			ClassLib.ComCtl.Set_ComboList(dt, cmb_Seach, 1, 2, true);
			cmb_Seach.SelectedIndex = 0;

			fgrid_receive_list.Set_Grid_Comm("SPS_NOTICE_USER","1",1,ClassLib.ComVar.This_Lang,ClassLib.ComVar.Grid_Type.ForModify ,true);
			fgrid_receive_list.Set_Action_Image(img_Action);
			_RowFixed = fgrid_receive_list.Rows.Fixed;
			Get_Grid_List(fgrid_receive_list, "R", "U", "");
			fgrid_receive_list.AutoSizeCols();
		}

		private void Send_Page()
		{
			obar_Main.SelectedIndex = 1;

			DataTable dt = oraDB.Select_ComCode(ClassLib.ComVar.This_Factory, "PS11");
			ClassLib.ComCtl.Set_ComboList(dt, cmb_Search_S, 1, 2, true);
			cmb_Search_S.SelectedIndex = 0;

			fgrid_send_list.Set_Grid_Comm("SPS_NOTICE_USER","2",1,ClassLib.ComVar.This_Lang,ClassLib.ComVar.Grid_Type.ForModify ,true);
			fgrid_send_list.Set_Action_Image(img_Action);
			_RowFixed = fgrid_send_list.Rows.Fixed;
			Get_Grid_List(fgrid_send_list, "S","U","");
			fgrid_send_list.AutoSizeCols();
		}


		/// <summary>
		/// Get_Grid_List : 그리드에 데이터 넣기
		/// </summary>
		/// <param name="arg_grid">입력될 그리드</param>
		/// <param name="arg_div">보냄/받음 구분자</param>
		private void Get_Grid_List(C1.Win.C1FlexGrid.C1FlexGrid arg_grid, string arg_div, string arg_division, string arg_value)
		{
			arg_grid.Rows.Count = _RowFixed;
			DataTable dt = Select_SPS_Notice_User(arg_div, arg_division, arg_value);

			int rowcount = dt.Rows.Count;
			int colcount = dt.Columns.Count;

			for(int i=0; i<rowcount; i++)
			{
				string[] ArrayItem = new string[colcount+1];
				ArrayItem[0] = "";
				for(int j=0; j<colcount; j++)
				{
					ArrayItem[j+1] = dt.Rows[i].ItemArray[j].ToString();
				}

				arg_grid.AddItem(ArrayItem,_RowFixed,0);
			}
		}


		private void Delete_Grid_Item(C1.Win.C1FlexGrid.C1FlexGrid arg_fgrid)
		{
			int rowcount = arg_fgrid.Rows.Count;

			for(int i=_RowFixed; i<rowcount; i++)
			{
				if(arg_fgrid[i,(int)ClassLib.TBSPS_NOTICE_USER.IxDIVISION].ToString() == "D")
				{
					string arg_factory = arg_fgrid[i,(int)ClassLib.TBSPS_NOTICE_USER.IxFACTORY].ToString();
					string arg_div     = arg_fgrid[i,(int)ClassLib.TBSPS_NOTICE_USER.IxDIV].ToString();
					string arg_seq	   = arg_fgrid[i,(int)ClassLib.TBSPS_NOTICE_USER.IxSEQ].ToString();

					Delete_SPS_Notice_User(arg_factory, arg_div,arg_seq);
				}
			}
		}

		#region 이벤트

		private void obar_Main_SelectedPageChanged(object sender, System.EventArgs e)
		{
			if(obar_Main.SelectedIndex == 0)
				Receive_Page();
			else
				Send_Page();
		}

		private void fgrid_receive_list_DoubleClick(object sender, System.EventArgs e)
		{
			int rownum = fgrid_receive_list.Selection.r1;

			string arg_factory = fgrid_receive_list[rownum, (int)ClassLib.TBSPS_NOTICE_USER.IxFACTORY].ToString();
			string arg_div     = fgrid_receive_list[rownum, (int)ClassLib.TBSPS_NOTICE_USER.IxDIV].ToString();
			string arg_seq	   = fgrid_receive_list[rownum, (int)ClassLib.TBSPS_NOTICE_USER.IxSEQ].ToString();

			//Pop_PS_NoticeUser_Receiver receiver = new Pop_PS_NoticeUser_Receiver(this, arg_factory, arg_div, arg_seq);
			//receiver.MdiParent = ClassLib.ComVar.arg_form;
			//ClassLib.ComVar.MenuClick_Flag = true;
			//receiver.Show();
		}

		private void fgrid_send_list_DoubleClick(object sender, System.EventArgs e)
		{
			int rownum = fgrid_send_list.Selection.r1;
			string arg_fastory = fgrid_send_list[rownum, (int)ClassLib.TBSPS_NOTICE_USER.IxFACTORY].ToString();
			string arg_div     = fgrid_send_list[rownum, (int)ClassLib.TBSPS_NOTICE_USER.IxDIV].ToString();
			string arg_seq     = fgrid_send_list[rownum, (int)ClassLib.TBSPS_NOTICE_USER.IxSEQ].ToString();
			//Pop_PS_NoticeUser_Receiver receiver = new Pop_PS_NoticeUser_Receiver(this, arg_fastory, arg_div,arg_seq);
			//receiver.MdiParent = ClassLib.ComVar.arg_form;
			//ClassLib.ComVar.MenuClick_Flag = true;
			//receiver.Show();
		}

		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Pop_PS_NoticeUser_Sender sender_Form = new Pop_PS_NoticeUser_Sender();
			sender_Form.Show();
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(obar_Main.SelectedIndex == 0 )
			{
				string cmb_search;
				string txt_search;
				if(cmb_Seach.SelectedIndex == 0)
				{
					cmb_search = "U";
					txt_search = "";
				}
				else
				{
					cmb_search = cmb_Seach.SelectedValue.ToString();
					txt_search = txt_Search.Text;
				}
				Get_Grid_List(fgrid_receive_list,"R", cmb_search, txt_search);
			}
			else if(obar_Main.SelectedIndex == 1)
			{
				string cmb_search;
				string txt_search;
				if(cmb_Search_S.SelectedIndex == 0)
				{
					cmb_search = "U";
					txt_search = "";
				}
				else
				{
					cmb_search =cmb_Search_S.SelectedValue.ToString();
					txt_search = txt_Search_S.Text;
				}
				Get_Grid_List(fgrid_send_list,"S", cmb_search, txt_search);
			}
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(obar_Main.SelectedIndex == 0 )
			{
				int rownum_r = fgrid_receive_list.Selection.r1;
				fgrid_receive_list[rownum_r,(int)ClassLib.TBSPS_NOTICE_USER.IxDIVISION] = "D";
			}
			else if(obar_Main.SelectedIndex == 1)
			{
				int rownum_s = fgrid_send_list.Selection.r1;
				fgrid_send_list[rownum_s, (int)ClassLib.TBSPS_NOTICE_USER.IxDIVISION] = "D"; 
			}
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			if(obar_Main.SelectedIndex == 0 )
			{
				Delete_Grid_Item(fgrid_receive_list);
				Get_Grid_List(fgrid_receive_list, "R", "U", "");
			}
			else if(obar_Main.SelectedIndex == 1)
			{
				Delete_Grid_Item(fgrid_send_list);
				Get_Grid_List(fgrid_send_list, "S", "U", "");
			}
		}

		#endregion

		#region DB 연결

		/// <summary>
		/// Select_SPS_Notice_User : 개인 업무 메시지 가져오기
		/// </summary>
		/// <param name="arg_div">받은/보낸 메시지 구분</param>
		/// <returns>정상:DataTable  오류:null</returns>
		private DataTable Select_SPS_Notice_User(string arg_div, string arg_division, string arg_value)
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_SPS_NOTICE_USER_SEARCH";

			oraDB.ReDim_Parameter(6);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_DIV";
			oraDB.Parameter_Name[2] = "ARG_USER_ID";
			oraDB.Parameter_Name[3] = "ARG_DIVISION";
			oraDB.Parameter_Name[4] = "ARG_VALUE";
			oraDB.Parameter_Name[5] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = arg_div;
			oraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;
			oraDB.Parameter_Values[3] = arg_division;
			oraDB.Parameter_Values[4] = arg_value;
			oraDB.Parameter_Values[5] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			return  DS_Ret.Tables[Proc_Name];
		}


		private void Delete_SPS_Notice_User(string arg_factory, string arg_div, string arg_seq)
		{
			string Proc_Name = "PKG_SPS_HOME.DELETE_SPS_NOTICE";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_DIV";
			oraDB.Parameter_Name[2] = "ARG_SEQ";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_div;
			oraDB.Parameter_Values[2] = arg_seq;

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}
		#endregion

		

		
	}
}

