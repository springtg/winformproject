using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.IO;

namespace FlexOrder.ExpOBS
{
	public class Form_EO_SRCH: COM.OrderWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		public System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.PictureBox pictureBox19;
		private System.Windows.Forms.PictureBox pictureBox20;
		private System.Windows.Forms.PictureBox pictureBox21;
		private System.Windows.Forms.PictureBox pictureBox22;
		private System.Windows.Forms.PictureBox pictureBox23;
		private System.Windows.Forms.PictureBox pictureBox24;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.PictureBox pictureBox26;
		private System.Windows.Forms.PictureBox pictureBox27;
		private System.Windows.Forms.PictureBox pictureBox28;
		private System.Windows.Forms.PictureBox pictureBox29;
		private System.Windows.Forms.PictureBox pictureBox30;
		private System.Windows.Forms.PictureBox pictureBox31;
		private System.Windows.Forms.PictureBox pictureBox32;
		private System.Windows.Forms.DateTimePicker dpick_Date;
		private System.Windows.Forms.GroupBox gb_job_div;
		private System.Windows.Forms.RadioButton rad_obs;
		private System.Windows.Forms.RadioButton rad_obscs;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label lbl_Date;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label lbl_OBS_ID;
		private System.Windows.Forms.Label lbl_OBS_Type;
		private System.Windows.Forms.TextBox txt_OBS_SEQ_NU;
		private System.Windows.Forms.TextBox txt_OBS_NU;
		private System.Windows.Forms.TextBox txt_Style;
		private C1.Win.C1List.C1Combo cmb_OBS_ID1;
		private C1.Win.C1List.C1Combo cmb_OBS_Type;
		private C1.Win.C1List.C1Combo cmb_OBS_ID2;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo cmb_Gen;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem ctm_PGS_OBS;
		private System.Windows.Forms.MenuItem ctm_MCR_OBS;
		private System.Windows.Forms.MenuItem ctm_OA;
		private System.Windows.Forms.MenuItem ctm_OBS_REQ;
		private System.Windows.Forms.MenuItem ctm_CSOBS_REQ;
		private System.Windows.Forms.MenuItem ctm_Bar_Second;
		private System.Windows.Forms.MenuItem ctm_OBS_Hist;
		private System.Windows.Forms.MenuItem ctm_Bar_First;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem ctm_OBS_Type;
		private System.Windows.Forms.Label lbl_SubTitle2;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.Label lbl_OBS_Nu;
		private System.Windows.Forms.PictureBox pictureBox25;
		private System.ComponentModel.IContainer components = null;

		public Form_EO_SRCH()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EO_SRCH));
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.ctm_PGS_OBS = new System.Windows.Forms.MenuItem();
			this.ctm_MCR_OBS = new System.Windows.Forms.MenuItem();
			this.ctm_Bar_First = new System.Windows.Forms.MenuItem();
			this.ctm_OA = new System.Windows.Forms.MenuItem();
			this.ctm_OBS_REQ = new System.Windows.Forms.MenuItem();
			this.ctm_CSOBS_REQ = new System.Windows.Forms.MenuItem();
			this.ctm_Bar_Second = new System.Windows.Forms.MenuItem();
			this.ctm_OBS_Hist = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.ctm_OBS_Type = new System.Windows.Forms.MenuItem();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lbl_SubTitle2 = new System.Windows.Forms.Label();
			this.cmb_Gen = new C1.Win.C1List.C1Combo();
			this.txt_OBS_SEQ_NU = new System.Windows.Forms.TextBox();
			this.txt_OBS_NU = new System.Windows.Forms.TextBox();
			this.txt_Style = new System.Windows.Forms.TextBox();
			this.cmb_OBS_ID1 = new C1.Win.C1List.C1Combo();
			this.cmb_OBS_Type = new C1.Win.C1List.C1Combo();
			this.cmb_OBS_ID2 = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_OBS_Nu = new System.Windows.Forms.Label();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.lbl_OBS_ID = new System.Windows.Forms.Label();
			this.lbl_OBS_Type = new System.Windows.Forms.Label();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.pictureBox18 = new System.Windows.Forms.PictureBox();
			this.pictureBox19 = new System.Windows.Forms.PictureBox();
			this.pictureBox20 = new System.Windows.Forms.PictureBox();
			this.pictureBox21 = new System.Windows.Forms.PictureBox();
			this.pictureBox22 = new System.Windows.Forms.PictureBox();
			this.pictureBox23 = new System.Windows.Forms.PictureBox();
			this.pictureBox24 = new System.Windows.Forms.PictureBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.gb_job_div = new System.Windows.Forms.GroupBox();
			this.rad_obs = new System.Windows.Forms.RadioButton();
			this.rad_obscs = new System.Windows.Forms.RadioButton();
			this.dpick_Date = new System.Windows.Forms.DateTimePicker();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Date = new System.Windows.Forms.Label();
			this.pictureBox26 = new System.Windows.Forms.PictureBox();
			this.pictureBox27 = new System.Windows.Forms.PictureBox();
			this.pictureBox28 = new System.Windows.Forms.PictureBox();
			this.pictureBox29 = new System.Windows.Forms.PictureBox();
			this.pictureBox30 = new System.Windows.Forms.PictureBox();
			this.pictureBox31 = new System.Windows.Forms.PictureBox();
			this.pictureBox32 = new System.Windows.Forms.PictureBox();
			this.pictureBox25 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Gen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID2)).BeginInit();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.gb_job_div.SuspendLayout();
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
			this.c1ToolBar1.Location = new System.Drawing.Point(665, 3);
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
			this.stbar.Size = new System.Drawing.Size(1000, 22);
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Location = new System.Drawing.Point(75, 26);
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(364, 23);
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.DockPadding.Left = 9;
			this.pnl_Body.DockPadding.Right = 9;
			this.pnl_Body.Location = new System.Drawing.Point(0, 216);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1000, 426);
			this.pnl_Body.TabIndex = 46;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.AllowEditing = false;
			this.fgrid_Main.BackColor = System.Drawing.Color.White;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this.fgrid_Main.ContextMenu = this.contextMenu1;
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.Color.Black;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(9, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(982, 426);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 35;
			this.fgrid_Main.Click += new System.EventHandler(this.fgrid_Main_Click);
			this.fgrid_Main.DoubleClick += new System.EventHandler(this.fgrid_Main_DoubleClick);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.ctm_PGS_OBS,
																						 this.ctm_MCR_OBS,
																						 this.ctm_Bar_First,
																						 this.ctm_OA,
																						 this.ctm_OBS_REQ,
																						 this.ctm_CSOBS_REQ,
																						 this.ctm_Bar_Second,
																						 this.ctm_OBS_Hist,
																						 this.menuItem1,
																						 this.ctm_OBS_Type});
			// 
			// ctm_PGS_OBS
			// 
			this.ctm_PGS_OBS.Index = 0;
			this.ctm_PGS_OBS.Text = "OBS In Pegasus";
			this.ctm_PGS_OBS.Click += new System.EventHandler(this.ctm_PGS_OBS_Click);
			// 
			// ctm_MCR_OBS
			// 
			this.ctm_MCR_OBS.Index = 1;
			this.ctm_MCR_OBS.Text = "OBS In Mercury";
			this.ctm_MCR_OBS.Click += new System.EventHandler(this.ctm_MCR_OBS_Click);
			// 
			// ctm_Bar_First
			// 
			this.ctm_Bar_First.Index = 2;
			this.ctm_Bar_First.Text = "-";
			// 
			// ctm_OA
			// 
			this.ctm_OA.Index = 3;
			this.ctm_OA.Text = "OBS OA Create";
			this.ctm_OA.Click += new System.EventHandler(this.ctm_OA_Click);
			// 
			// ctm_OBS_REQ
			// 
			this.ctm_OBS_REQ.Index = 4;
			this.ctm_OBS_REQ.Text = "OBS Request";
			this.ctm_OBS_REQ.Click += new System.EventHandler(this.ctm_OBS_REQ_Click);
			// 
			// ctm_CSOBS_REQ
			// 
			this.ctm_CSOBS_REQ.Index = 5;
			this.ctm_CSOBS_REQ.Text = "CS OBS Request";
			this.ctm_CSOBS_REQ.Click += new System.EventHandler(this.ctm_CSOBS_REQ_Click);
			// 
			// ctm_Bar_Second
			// 
			this.ctm_Bar_Second.Index = 6;
			this.ctm_Bar_Second.Text = "-";
			// 
			// ctm_OBS_Hist
			// 
			this.ctm_OBS_Hist.Index = 7;
			this.ctm_OBS_Hist.Text = "OBS History";
			this.ctm_OBS_Hist.Click += new System.EventHandler(this.ctm_OBS_Hist_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 8;
			this.menuItem1.Text = "-";
			// 
			// ctm_OBS_Type
			// 
			this.ctm_OBS_Type.Index = 9;
			this.ctm_OBS_Type.Text = "OBS Type Change";
			this.ctm_OBS_Type.Click += new System.EventHandler(this.ctm_OBS_Type_Click);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.SystemColors.Window;
			this.panel3.Controls.Add(this.pictureBox25);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.panel6);
			this.panel3.DockPadding.All = 8;
			this.panel3.Location = new System.Drawing.Point(0, 64);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1000, 147);
			this.panel3.TabIndex = 47;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(512, 8);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(480, 131);
			this.panel4.TabIndex = 130;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.RosyBrown;
			this.panel5.Controls.Add(this.lbl_SubTitle2);
			this.panel5.Controls.Add(this.cmb_Gen);
			this.panel5.Controls.Add(this.txt_OBS_SEQ_NU);
			this.panel5.Controls.Add(this.txt_OBS_NU);
			this.panel5.Controls.Add(this.txt_Style);
			this.panel5.Controls.Add(this.cmb_OBS_ID1);
			this.panel5.Controls.Add(this.cmb_OBS_Type);
			this.panel5.Controls.Add(this.cmb_OBS_ID2);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.lbl_OBS_Nu);
			this.panel5.Controls.Add(this.lbl_Style);
			this.panel5.Controls.Add(this.lbl_OBS_ID);
			this.panel5.Controls.Add(this.lbl_OBS_Type);
			this.panel5.Controls.Add(this.pictureBox17);
			this.panel5.Controls.Add(this.pictureBox18);
			this.panel5.Controls.Add(this.pictureBox19);
			this.panel5.Controls.Add(this.pictureBox20);
			this.panel5.Controls.Add(this.pictureBox21);
			this.panel5.Controls.Add(this.pictureBox22);
			this.panel5.Controls.Add(this.pictureBox23);
			this.panel5.Controls.Add(this.pictureBox24);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(480, 131);
			this.panel5.TabIndex = 128;
			// 
			// lbl_SubTitle2
			// 
			this.lbl_SubTitle2.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_SubTitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle2.Image")));
			this.lbl_SubTitle2.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle2.Name = "lbl_SubTitle2";
			this.lbl_SubTitle2.Size = new System.Drawing.Size(165, 30);
			this.lbl_SubTitle2.TabIndex = 0;
			this.lbl_SubTitle2.Text = "      OBS Info.";
			this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Gen
			// 
			this.cmb_Gen.AddItemCols = 0;
			this.cmb_Gen.AddItemSeparator = ';';
			this.cmb_Gen.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Gen.Caption = "";
			this.cmb_Gen.CaptionHeight = 17;
			this.cmb_Gen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Gen.ColumnCaptionHeight = 18;
			this.cmb_Gen.ColumnFooterHeight = 18;
			this.cmb_Gen.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Gen.ContentHeight = 15;
			this.cmb_Gen.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Gen.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Gen.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Gen.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Gen.EditorHeight = 15;
			this.cmb_Gen.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Gen.GapHeight = 2;
			this.cmb_Gen.ItemHeight = 15;
			this.cmb_Gen.Location = new System.Drawing.Point(235, 80);
			this.cmb_Gen.MatchEntryTimeout = ((long)(2000));
			this.cmb_Gen.MaxDropDownItems = ((short)(5));
			this.cmb_Gen.MaxLength = 32767;
			this.cmb_Gen.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Gen.Name = "cmb_Gen";
			this.cmb_Gen.PartialRightColumn = false;
			this.cmb_Gen.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tru" +
				"e;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Con" +
				"trol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Gen.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Gen.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Gen.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Gen.RowTracking = false;
			this.cmb_Gen.Size = new System.Drawing.Size(121, 19);
			this.cmb_Gen.TabIndex = 189;
			// 
			// txt_OBS_SEQ_NU
			// 
			this.txt_OBS_SEQ_NU.BackColor = System.Drawing.Color.White;
			this.txt_OBS_SEQ_NU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_SEQ_NU.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_OBS_SEQ_NU.Location = new System.Drawing.Point(235, 102);
			this.txt_OBS_SEQ_NU.MaxLength = 100;
			this.txt_OBS_SEQ_NU.Name = "txt_OBS_SEQ_NU";
			this.txt_OBS_SEQ_NU.Size = new System.Drawing.Size(121, 21);
			this.txt_OBS_SEQ_NU.TabIndex = 188;
			this.txt_OBS_SEQ_NU.Text = "";
			// 
			// txt_OBS_NU
			// 
			this.txt_OBS_NU.BackColor = System.Drawing.Color.White;
			this.txt_OBS_NU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_NU.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_OBS_NU.Location = new System.Drawing.Point(111, 102);
			this.txt_OBS_NU.MaxLength = 100;
			this.txt_OBS_NU.Name = "txt_OBS_NU";
			this.txt_OBS_NU.Size = new System.Drawing.Size(123, 21);
			this.txt_OBS_NU.TabIndex = 187;
			this.txt_OBS_NU.Text = "";
			// 
			// txt_Style
			// 
			this.txt_Style.BackColor = System.Drawing.Color.White;
			this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Style.Location = new System.Drawing.Point(111, 80);
			this.txt_Style.MaxLength = 100;
			this.txt_Style.Name = "txt_Style";
			this.txt_Style.Size = new System.Drawing.Size(123, 21);
			this.txt_Style.TabIndex = 186;
			this.txt_Style.Text = "";
			// 
			// cmb_OBS_ID1
			// 
			this.cmb_OBS_ID1.AddItemCols = 0;
			this.cmb_OBS_ID1.AddItemSeparator = ';';
			this.cmb_OBS_ID1.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_ID1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_ID1.Caption = "";
			this.cmb_OBS_ID1.CaptionHeight = 17;
			this.cmb_OBS_ID1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_ID1.ColumnCaptionHeight = 18;
			this.cmb_OBS_ID1.ColumnFooterHeight = 18;
			this.cmb_OBS_ID1.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_ID1.ContentHeight = 15;
			this.cmb_OBS_ID1.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_ID1.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OBS_ID1.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID1.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_ID1.EditorHeight = 15;
			this.cmb_OBS_ID1.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID1.GapHeight = 2;
			this.cmb_OBS_ID1.ItemHeight = 15;
			this.cmb_OBS_ID1.Location = new System.Drawing.Point(111, 58);
			this.cmb_OBS_ID1.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_ID1.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_ID1.MaxLength = 32767;
			this.cmb_OBS_ID1.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_ID1.Name = "cmb_OBS_ID1";
			this.cmb_OBS_ID1.PartialRightColumn = false;
			this.cmb_OBS_ID1.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tru" +
				"e;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Con" +
				"trol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_OBS_ID1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_ID1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID1.RowTracking = false;
			this.cmb_OBS_ID1.Size = new System.Drawing.Size(117, 19);
			this.cmb_OBS_ID1.TabIndex = 184;
			// 
			// cmb_OBS_Type
			// 
			this.cmb_OBS_Type.AddItemCols = 0;
			this.cmb_OBS_Type.AddItemSeparator = ';';
			this.cmb_OBS_Type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_Type.Caption = "";
			this.cmb_OBS_Type.CaptionHeight = 17;
			this.cmb_OBS_Type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_Type.ColumnCaptionHeight = 18;
			this.cmb_OBS_Type.ColumnFooterHeight = 18;
			this.cmb_OBS_Type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_Type.ContentHeight = 15;
			this.cmb_OBS_Type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_Type.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OBS_Type.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_Type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_Type.EditorHeight = 15;
			this.cmb_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_Type.GapHeight = 2;
			this.cmb_OBS_Type.ItemHeight = 15;
			this.cmb_OBS_Type.Location = new System.Drawing.Point(111, 36);
			this.cmb_OBS_Type.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_Type.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_Type.MaxLength = 32767;
			this.cmb_OBS_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_Type.Name = "cmb_OBS_Type";
			this.cmb_OBS_Type.PartialRightColumn = false;
			this.cmb_OBS_Type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Con" +
				"trol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}S" +
				"tyle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_OBS_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type.Size = new System.Drawing.Size(245, 19);
			this.cmb_OBS_Type.TabIndex = 182;
			this.cmb_OBS_Type.TextChanged += new System.EventHandler(this.cmb_OBS_Type_TextChanged);
			// 
			// cmb_OBS_ID2
			// 
			this.cmb_OBS_ID2.AddItemCols = 0;
			this.cmb_OBS_ID2.AddItemSeparator = ';';
			this.cmb_OBS_ID2.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_ID2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_ID2.Caption = "";
			this.cmb_OBS_ID2.CaptionHeight = 17;
			this.cmb_OBS_ID2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_ID2.ColumnCaptionHeight = 18;
			this.cmb_OBS_ID2.ColumnFooterHeight = 18;
			this.cmb_OBS_ID2.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_ID2.ContentHeight = 15;
			this.cmb_OBS_ID2.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_ID2.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OBS_ID2.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID2.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_ID2.EditorHeight = 15;
			this.cmb_OBS_ID2.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID2.GapHeight = 2;
			this.cmb_OBS_ID2.ItemHeight = 15;
			this.cmb_OBS_ID2.Location = new System.Drawing.Point(240, 58);
			this.cmb_OBS_ID2.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_ID2.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_ID2.MaxLength = 32767;
			this.cmb_OBS_ID2.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_ID2.Name = "cmb_OBS_ID2";
			this.cmb_OBS_ID2.PartialRightColumn = false;
			this.cmb_OBS_ID2.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Con" +
				"trol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}S" +
				"tyle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_OBS_ID2.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_ID2.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID2.RowTracking = false;
			this.cmb_OBS_ID2.Size = new System.Drawing.Size(116, 19);
			this.cmb_OBS_ID2.TabIndex = 183;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(228, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 23);
			this.label1.TabIndex = 185;
			this.label1.Text = "~";
			// 
			// lbl_OBS_Nu
			// 
			this.lbl_OBS_Nu.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Nu.ImageIndex = 0;
			this.lbl_OBS_Nu.ImageList = this.img_Label;
			this.lbl_OBS_Nu.Location = new System.Drawing.Point(10, 102);
			this.lbl_OBS_Nu.Name = "lbl_OBS_Nu";
			this.lbl_OBS_Nu.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_Nu.TabIndex = 118;
			this.lbl_OBS_Nu.Text = "OBS No/SeqNo";
			this.lbl_OBS_Nu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Style
			// 
			this.lbl_Style.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Style.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(10, 80);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 117;
			this.lbl_Style.Text = "Style/Gen";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_OBS_ID
			// 
			this.lbl_OBS_ID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_ID.ImageIndex = 0;
			this.lbl_OBS_ID.ImageList = this.img_Label;
			this.lbl_OBS_ID.Location = new System.Drawing.Point(10, 58);
			this.lbl_OBS_ID.Name = "lbl_OBS_ID";
			this.lbl_OBS_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_ID.TabIndex = 116;
			this.lbl_OBS_ID.Text = "OBS ID";
			this.lbl_OBS_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_OBS_Type
			// 
			this.lbl_OBS_Type.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Type.ImageIndex = 0;
			this.lbl_OBS_Type.ImageList = this.img_Label;
			this.lbl_OBS_Type.Location = new System.Drawing.Point(10, 36);
			this.lbl_OBS_Type.Name = "lbl_OBS_Type";
			this.lbl_OBS_Type.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_Type.TabIndex = 115;
			this.lbl_OBS_Type.Text = "OBS Type";
			this.lbl_OBS_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox17
			// 
			this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox17.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
			this.pictureBox17.Location = new System.Drawing.Point(165, 0);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(304, 30);
			this.pictureBox17.TabIndex = 2;
			this.pictureBox17.TabStop = false;
			// 
			// pictureBox18
			// 
			this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox18.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox18.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
			this.pictureBox18.Location = new System.Drawing.Point(467, 0);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(13, 30);
			this.pictureBox18.TabIndex = 1;
			this.pictureBox18.TabStop = false;
			// 
			// pictureBox19
			// 
			this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox19.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
			this.pictureBox19.Location = new System.Drawing.Point(449, 30);
			this.pictureBox19.Name = "pictureBox19";
			this.pictureBox19.Size = new System.Drawing.Size(31, 85);
			this.pictureBox19.TabIndex = 5;
			this.pictureBox19.TabStop = false;
			// 
			// pictureBox20
			// 
			this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox20.BackColor = System.Drawing.Color.Blue;
			this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
			this.pictureBox20.Location = new System.Drawing.Point(455, 101);
			this.pictureBox20.Name = "pictureBox20";
			this.pictureBox20.Size = new System.Drawing.Size(25, 30);
			this.pictureBox20.TabIndex = 8;
			this.pictureBox20.TabStop = false;
			// 
			// pictureBox21
			// 
			this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox21.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
			this.pictureBox21.Location = new System.Drawing.Point(0, 24);
			this.pictureBox21.Name = "pictureBox21";
			this.pictureBox21.Size = new System.Drawing.Size(32, 96);
			this.pictureBox21.TabIndex = 3;
			this.pictureBox21.TabStop = false;
			// 
			// pictureBox22
			// 
			this.pictureBox22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox22.BackColor = System.Drawing.Color.Blue;
			this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
			this.pictureBox22.Location = new System.Drawing.Point(0, 101);
			this.pictureBox22.Name = "pictureBox22";
			this.pictureBox22.Size = new System.Drawing.Size(72, 40);
			this.pictureBox22.TabIndex = 6;
			this.pictureBox22.TabStop = false;
			// 
			// pictureBox23
			// 
			this.pictureBox23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox23.BackColor = System.Drawing.Color.Blue;
			this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
			this.pictureBox23.Location = new System.Drawing.Point(72, 101);
			this.pictureBox23.Name = "pictureBox23";
			this.pictureBox23.Size = new System.Drawing.Size(392, 30);
			this.pictureBox23.TabIndex = 9;
			this.pictureBox23.TabStop = false;
			// 
			// pictureBox24
			// 
			this.pictureBox24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox24.BackColor = System.Drawing.Color.Navy;
			this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
			this.pictureBox24.Location = new System.Drawing.Point(32, 24);
			this.pictureBox24.Name = "pictureBox24";
			this.pictureBox24.Size = new System.Drawing.Size(432, 99);
			this.pictureBox24.TabIndex = 4;
			this.pictureBox24.TabStop = false;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel6.DockPadding.Right = 4;
			this.panel6.Location = new System.Drawing.Point(8, 8);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(504, 131);
			this.panel6.TabIndex = 128;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.RosyBrown;
			this.panel7.Controls.Add(this.lbl_SubTitle1);
			this.panel7.Controls.Add(this.gb_job_div);
			this.panel7.Controls.Add(this.dpick_Date);
			this.panel7.Controls.Add(this.lbl_Factory);
			this.panel7.Controls.Add(this.cmb_Factory);
			this.panel7.Controls.Add(this.lbl_Date);
			this.panel7.Controls.Add(this.pictureBox26);
			this.panel7.Controls.Add(this.pictureBox27);
			this.panel7.Controls.Add(this.pictureBox28);
			this.panel7.Controls.Add(this.pictureBox29);
			this.panel7.Controls.Add(this.pictureBox30);
			this.panel7.Controls.Add(this.pictureBox31);
			this.panel7.Controls.Add(this.pictureBox32);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(500, 131);
			this.panel7.TabIndex = 1;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(172, 32);
			this.lbl_SubTitle1.TabIndex = 0;
			this.lbl_SubTitle1.Text = "      Search Date";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gb_job_div
			// 
			this.gb_job_div.BackColor = System.Drawing.Color.White;
			this.gb_job_div.Controls.Add(this.rad_obs);
			this.gb_job_div.Controls.Add(this.rad_obscs);
			this.gb_job_div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gb_job_div.Location = new System.Drawing.Point(10, 80);
			this.gb_job_div.Name = "gb_job_div";
			this.gb_job_div.Size = new System.Drawing.Size(310, 40);
			this.gb_job_div.TabIndex = 167;
			this.gb_job_div.TabStop = false;
			this.gb_job_div.Text = "Job Division";
			// 
			// rad_obs
			// 
			this.rad_obs.Location = new System.Drawing.Point(112, 17);
			this.rad_obs.Name = "rad_obs";
			this.rad_obs.Size = new System.Drawing.Size(65, 14);
			this.rad_obs.TabIndex = 1;
			this.rad_obs.Text = "OBS";
			// 
			// rad_obscs
			// 
			this.rad_obscs.Location = new System.Drawing.Point(208, 17);
			this.rad_obscs.Name = "rad_obscs";
			this.rad_obscs.Size = new System.Drawing.Size(84, 14);
			this.rad_obscs.TabIndex = 0;
			this.rad_obscs.Text = "OBS CS";
			// 
			// dpick_Date
			// 
			this.dpick_Date.CustomFormat = "yyyy-MM-dd";
			this.dpick_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_Date.Location = new System.Drawing.Point(111, 57);
			this.dpick_Date.Name = "dpick_Date";
			this.dpick_Date.Size = new System.Drawing.Size(212, 20);
			this.dpick_Date.TabIndex = 163;
			this.dpick_Date.ValueChanged += new System.EventHandler(this.dpick_Date_ValueChanged);
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 115;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.ContentHeight = 15;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 15;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8F);
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
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tru" +
				"e;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Con" +
				"trol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory.TabIndex = 118;
			// 
			// lbl_Date
			// 
			this.lbl_Date.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Date.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Date.ImageIndex = 1;
			this.lbl_Date.ImageList = this.img_Label;
			this.lbl_Date.Location = new System.Drawing.Point(10, 58);
			this.lbl_Date.Name = "lbl_Date";
			this.lbl_Date.Size = new System.Drawing.Size(100, 21);
			this.lbl_Date.TabIndex = 116;
			this.lbl_Date.Text = "Date";
			this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox26
			// 
			this.pictureBox26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox26.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
			this.pictureBox26.Location = new System.Drawing.Point(478, 0);
			this.pictureBox26.Name = "pictureBox26";
			this.pictureBox26.Size = new System.Drawing.Size(22, 32);
			this.pictureBox26.TabIndex = 1;
			this.pictureBox26.TabStop = false;
			// 
			// pictureBox27
			// 
			this.pictureBox27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox27.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
			this.pictureBox27.Location = new System.Drawing.Point(481, 32);
			this.pictureBox27.Name = "pictureBox27";
			this.pictureBox27.Size = new System.Drawing.Size(19, 85);
			this.pictureBox27.TabIndex = 5;
			this.pictureBox27.TabStop = false;
			// 
			// pictureBox28
			// 
			this.pictureBox28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox28.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
			this.pictureBox28.Location = new System.Drawing.Point(0, 24);
			this.pictureBox28.Name = "pictureBox28";
			this.pictureBox28.Size = new System.Drawing.Size(32, 96);
			this.pictureBox28.TabIndex = 3;
			this.pictureBox28.TabStop = false;
			// 
			// pictureBox29
			// 
			this.pictureBox29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox29.BackColor = System.Drawing.Color.Blue;
			this.pictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox29.Image")));
			this.pictureBox29.Location = new System.Drawing.Point(410, 117);
			this.pictureBox29.Name = "pictureBox29";
			this.pictureBox29.Size = new System.Drawing.Size(90, 14);
			this.pictureBox29.TabIndex = 8;
			this.pictureBox29.TabStop = false;
			// 
			// pictureBox30
			// 
			this.pictureBox30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox30.BackColor = System.Drawing.Color.Blue;
			this.pictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox30.Image")));
			this.pictureBox30.Location = new System.Drawing.Point(72, 117);
			this.pictureBox30.Name = "pictureBox30";
			this.pictureBox30.Size = new System.Drawing.Size(412, 14);
			this.pictureBox30.TabIndex = 9;
			this.pictureBox30.TabStop = false;
			// 
			// pictureBox31
			// 
			this.pictureBox31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox31.BackColor = System.Drawing.Color.Blue;
			this.pictureBox31.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox31.Image")));
			this.pictureBox31.Location = new System.Drawing.Point(0, 117);
			this.pictureBox31.Name = "pictureBox31";
			this.pictureBox31.Size = new System.Drawing.Size(80, 14);
			this.pictureBox31.TabIndex = 6;
			this.pictureBox31.TabStop = false;
			// 
			// pictureBox32
			// 
			this.pictureBox32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox32.BackColor = System.Drawing.Color.Navy;
			this.pictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox32.Image")));
			this.pictureBox32.Location = new System.Drawing.Point(32, 24);
			this.pictureBox32.Name = "pictureBox32";
			this.pictureBox32.Size = new System.Drawing.Size(452, 99);
			this.pictureBox32.TabIndex = 4;
			this.pictureBox32.TabStop = false;
			// 
			// pictureBox25
			// 
			this.pictureBox25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox25.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox25.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
			this.pictureBox25.Location = new System.Drawing.Point(176, 7);
			this.pictureBox25.Name = "pictureBox25";
			this.pictureBox25.Size = new System.Drawing.Size(316, 32);
			this.pictureBox25.TabIndex = 168;
			this.pictureBox25.TabStop = false;
			// 
			// Form_EO_SRCH
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.ClientSize = new System.Drawing.Size(1000, 666);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.pnl_Body);
			this.Font = new System.Drawing.Font("Verdana", 8F);
			this.Name = "Form_EO_SRCH";
			this.Text = "OBS By Option";
			this.Load += new System.EventHandler(this.Form_EO_SRCH_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.Controls.SetChildIndex(this.panel3, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Gen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID2)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.gb_job_div.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의
   
		private int _Rowfixed; 
		private COM.OraDB MyOraDB = new COM.OraDB();  
		private COM.ComFunction MyComFunction    = new COM.ComFunction();

		#endregion 	

		#region 멤버 메서드 

		private void Init_Form()
		{ 
			DataTable dt_list; 
			DateTime CurDate = DateTime.Now;
		
			//Title
			this.Text = "OBS/OBS CS";
			this.lbl_MainTitle.Text = "Search OBS/OBS CS"; 
			ClassLib.ComFunction.SetLangDic(this);


			#region 버튼 권한

//			try
//			{
//				COM.OraDB btn_control = new COM.OraDB();
//				DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
//				tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
//
//				btn_control = null;
//
//				//Button 활성화
//				tbtn_Append.Enabled = false;   tbtn_Delete.Enabled = false;   tbtn_Insert.Enabled = false; 
//			}
//			catch
//			{
//			}

			#endregion
			
			// 그리드 설정(TBSEM_OBS_Search)
			_Rowfixed = 6;
			fgrid_Main.Set_Grid( "SEM_OBS", "3", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
			ClassLib.ComFunction.Set_Size_Grid(fgrid_Main, _Rowfixed, (int)ClassLib.TBSEM_OBS_Search.IxGEN);
			fgrid_Main.Font  = new Font("Verdana",8);		

			ClassLib.ComFunction.Set_Head_Bold("01", fgrid_Main, _Rowfixed, (int)ClassLib.TBSEM_OBS_Search.IxGEN);

			
			///Factory
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			///OBS_Type
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxOBS_Type);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OBS_Type, 1, 2, true);  			
			cmb_OBS_Type.SelectedIndex = 0;

			///Gender
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxGen);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Gen, 1, 2, true);  			
			cmb_Gen.SelectedIndex = 0;

			///날짜
			dpick_Date.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			string now  = System.DateTime.Now.ToString("yyyyMMdd");
			dpick_Date.Text = MyComFunction.ConvertDate2Type(now);
				
			rad_obs.Checked = true;

			// set up Subtotal
			fgrid_Main.Tree.Column = 1;
			CellStyle s = fgrid_Main.Styles[CellStyleEnum.Subtotal0];
			s.BackColor = Color.YellowGreen;
			s.ForeColor = Color.White;
			s.Font = new Font(fgrid_Main.Font, FontStyle.Bold);


			//ClassLib.ComFunction.Get_Values(this, dpick_Date.Name);
		}

		/// <summary>
		/// Convert_ToDate : 스트링을 날짜형으로 
		/// </summary>
		/// <param name="arg_dateString"></param>
		/// <returns></returns>
		private static DateTime Convert_ToDate(string arg_dateString)
		{
			string date_string;

			date_string = arg_dateString.Substring(0, 4) + "-";
			date_string = date_string + arg_dateString.Substring(4, 2) + "-";
			date_string = date_string + arg_dateString.Substring(6, 2);
		
			return Convert.ToDateTime(date_string);
			 
 
		}


		/// <summary>
		/// Display_fgrid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_fgrid(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{
			fgrid_Main.Rows.Count = _Rowfixed;

			// Set List
			int iRow_Gen=0;
			int iOBS_NU     = (int)ClassLib.TBSEM_OBS_Search.IxOBS_NU;
			int iOBS_SEQ_NU = (int)ClassLib.TBSEM_OBS_Search.IxOBS_SEQ_NU;
			int iCHG_NU     = (int)ClassLib.TBSEM_OBS_Search.IxCHG_NU;
			int iGEN        = (int)ClassLib.TBSEM_OBS_Search.IxGEN;
			//int iTOT_QTY    = (int)ClassLib.TBSEM_OBS_Search.IxTOT_QTY;
			for(int i=0; i<arg_dt.Rows.Count; i++)
			{					
				string sOBS_NU     = arg_dt.Rows[i].ItemArray[iOBS_NU-1].ToString();
				string sOBS_SEQ_NU = arg_dt.Rows[i].ItemArray[iOBS_SEQ_NU-1].ToString();
				string sCHG_NU     = arg_dt.Rows[i].ItemArray[iCHG_NU-1].ToString();					
				string sSIZE       = arg_dt.Rows[i].ItemArray[iGEN].ToString();
				string sQTY        = arg_dt.Rows[i].ItemArray[iGEN+1].ToString();

				if (( fgrid_Main.Rows.Count == _Rowfixed ) ||
					( sOBS_NU     != fgrid_Main[fgrid_Main.Rows.Count-1, iOBS_NU].ToString()     ) || 
					( sOBS_SEQ_NU != fgrid_Main[fgrid_Main.Rows.Count-1, iOBS_SEQ_NU].ToString() ) || 
					( sCHG_NU     != fgrid_Main[fgrid_Main.Rows.Count-1, iCHG_NU].ToString()     )  )
				{
					fgrid_Main.AddItem(arg_dt.Rows[i].ItemArray, fgrid_Main.Rows.Count, 1);
					fgrid_Main[fgrid_Main.Rows.Count-1, iGEN+1] = " ";
					fgrid_Main[fgrid_Main.Rows.Count-1, iGEN+2] = " ";
											
					string sGEN = arg_dt.Rows[i].ItemArray[iGEN-1].ToString();
					for(int j=1; j<_Rowfixed; j++)
						if (fgrid_Main[j, iGEN].ToString() == sGEN)
							iRow_Gen = j;
				}

				for(int j=iGEN; j<fgrid_Main.Cols.Count; j++)
				{
					if (fgrid_Main[iRow_Gen, j].ToString() == sSIZE)
					{
						fgrid_Main[fgrid_Main.Rows.Count-1, j] = sQTY;
						break;
					}
				}

			} 
			
			arg_fgrid.SubtotalPosition = SubtotalPositionEnum.AboveData;
            arg_fgrid.Tree.Column = 1;

			CellStyle cStyle = arg_fgrid.Styles[CellStyleEnum.Subtotal0];
			cStyle.Font = new Font(arg_fgrid.Font , FontStyle.Bold);

			for (int c = (int)ClassLib.TBSEM_OBS_Search.IxGEN +1 ; c < arg_fgrid.Cols.Count; c++)
			{
				arg_fgrid.Subtotal(AggregateEnum.Sum, 0, 0, (int)ClassLib.TBSEM_OBS_Search.IxTOT_QTY, "Style Total {0}");
				arg_fgrid.Subtotal(AggregateEnum.Sum, 0, 0, c, "Grand Total {0}");		
				arg_fgrid.Styles[CellStyleEnum.Subtotal0].BackColor  = ClassLib.ComVar.Clr_Head_RYellow;
				arg_fgrid.Styles[CellStyleEnum.Subtotal0].ForeColor  = ClassLib.ComVar.Clr_Text_Red;
				arg_fgrid.Styles[CellStyleEnum.Subtotal0].Font       = cStyle.Font;

				arg_fgrid.Subtotal(AggregateEnum.Sum, 1, 1, (int)ClassLib.TBSEM_OBS_Search.IxTOT_QTY, "Style Total {0}");
				arg_fgrid.Subtotal(AggregateEnum.Sum, 1, 1, c, "Style Total {0}");
				arg_fgrid.Styles[CellStyleEnum.Subtotal1].BackColor  = ClassLib.ComVar.Clr_Head_RYellow;
				arg_fgrid.Styles[CellStyleEnum.Subtotal1].ForeColor  = ClassLib.ComVar.Clr_Text_Blue;
				arg_fgrid.Styles[CellStyleEnum.Subtotal1].Font       = cStyle.Font;

			
			}


		}


		
		/// <summary>
		/// Sb_Pop_OBS: OBS Popup창
		/// </summary>
		private void  SB_Pop_Type_Change()
		{			
		

			FlexOrder.ExpOBS.POP_EO_Type_Change  pop_form = new ExpOBS.POP_EO_Type_Change();
	
			COM.ComVar.Parameter_PopUp = new string[]
									 {
										 cmb_Factory.SelectedValue.ToString(),
										 cmb_OBS_ID1.Text ,
										 cmb_OBS_Type.Columns[0].Text,
										 fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_Search.IxSTYLE_CD].ToString(),										 
										 fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_Search.IxOBS_NU].ToString(),
										 fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_Search.IxOBS_SEQ_NU].ToString(),
										 fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_Search.IxCHG_NU].ToString(),
										 fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_Search.IxTOT_QTY].ToString()
									 };
				
			pop_form.ShowDialog();


		}



		#endregion 	

        #region  DB컨트롤
		/// <summary>
		/// Select_OBS_List : SEM_OBS 리스트 찾기 
		/// </summary>
		private DataTable Select_OBS_Data_List()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_OBS.SELECT_SEM_OBS";

			MyOraDB.ReDim_Parameter(11); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2]  = "ARG_DATE";
			MyOraDB.Parameter_Name[3]  = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[4]  = "ARG_OBS_ID1";
			MyOraDB.Parameter_Name[5]  = "ARG_OBS_ID2";
			MyOraDB.Parameter_Name[6]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[7]  = "ARG_GEN";
			MyOraDB.Parameter_Name[8]  = "ARG_OBS_NU";
			MyOraDB.Parameter_Name[9]  = "ARG_OBS_SEQ_NU";
			MyOraDB.Parameter_Name[10]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[10]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			if (rad_obs.Checked) MyOraDB.Parameter_Values[0]  = "O";
			else                 MyOraDB.Parameter_Values[0]  = "C";

			MyOraDB.Parameter_Values[1]  = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2]  = Convert.ToDateTime(dpick_Date.Text).ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[3]  = ClassLib.ComFunction.Empty_Combo(cmb_OBS_Type,      " ");
			MyOraDB.Parameter_Values[4]  = ClassLib.ComFunction.Empty_String(cmb_OBS_ID1.Text, " ");
			MyOraDB.Parameter_Values[5]  = ClassLib.ComFunction.Empty_String(cmb_OBS_ID2.Text, " ");
			MyOraDB.Parameter_Values[6]  = ClassLib.ComFunction.Empty_TextBox(txt_Style,       " ");
			MyOraDB.Parameter_Values[7]  = ClassLib.ComFunction.Empty_Combo(cmb_Gen,      " ");
			MyOraDB.Parameter_Values[8]  = ClassLib.ComFunction.Empty_TextBox(txt_OBS_NU,      " ");
			MyOraDB.Parameter_Values[9]  = ClassLib.ComFunction.Empty_TextBox(txt_OBS_SEQ_NU,  " ");
			MyOraDB.Parameter_Values[10] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
		}

		#endregion

		#region 이벤트 처리
  
			#region 버튼 
			private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
			{
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;		
				dpick_Date.Text = System.DateTime.Now.ToString();
				cmb_OBS_Type.SelectedIndex = 0;			
				txt_Style.Clear();
				txt_OBS_NU.Clear();
				txt_OBS_SEQ_NU.Clear();
				rad_obs.Checked = true;
			}

			private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
			{
				try
				{
					DataTable dt_ret;

					//SEM_OBS/SEM_OBS_CS 정보를 읽어온다
					dt_ret = Select_OBS_Data_List();

					if (dt_ret.Rows.Count  == 0) 
					{ ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch); return;}

					Display_fgrid(dt_ret, fgrid_Main);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch,this);
				}
				catch
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch,this);
				}											
			}

			
			private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
			{
				string mrd_Filename = "Form_EO_SRCH.mrd" ;
				string txt_Filename = this.Name + ".txt"; 
				string Para         = " ";

				#region 출력조건
				int  iCnt  = 10;
				string [] aHead =  new string[iCnt];	
				aHead[0]    = cmb_Factory.SelectedValue.ToString();
				aHead[1]    = dpick_Date.Text.ToString();
				if (rad_obs.Checked)   aHead[2]    =  "OBS"; else aHead[2]    =  "CS OBS";
				aHead[3]    = cmb_OBS_Type.SelectedValue.ToString();
				aHead[4]    = cmb_OBS_ID1.Text;
				aHead[5]    = cmb_OBS_ID2.Text;
				aHead[6]    = txt_Style.Text;
				aHead[7]    = ClassLib.ComFunction.Empty_Combo(cmb_Gen," ");
				aHead[8]    = txt_OBS_NU.Text; 
				aHead[9]    = txt_OBS_SEQ_NU.Text;
				#endregion

				#region 파라미터 
				Para  = "/rfn [" + Application.StartupPath + @"\"+ txt_Filename+ "]  /rv "; 			
				for (int i  = 1 ; i<= iCnt ; i++)
				{
					Para = Para +  "V_" + i.ToString().PadLeft (2,'0').ToString() + "[" + aHead[i-1] + "] ";
				}
				Para = Para + "V_USER[" + ClassLib.ComVar.This_User + "]";
				#endregion 

				#region 파일만들기
				FileInfo file = new FileInfo( Application.StartupPath + @"\"+ txt_Filename);
				if(!file.Exists)
				{
					file.Create().Close();
				}
				file = null;

				FileStream sDatalist = new FileStream(txt_Filename , FileMode.Create, FileAccess.Write);
				StreamWriter sw = new StreamWriter(sDatalist);
            
			
				for (int i  = _Rowfixed ; i<fgrid_Main.Rows.Count ; i++)
				{
					string sData = " ";

					if (fgrid_Main[i, (int)ClassLib.TBSEM_OBS_Search.IxSTYLE_CD].ToString().Length  != 9 ) continue;

					for(int j = 0 ; j<fgrid_Main.Cols.Count ;j++)
					{
						if (fgrid_Main[i,j]==null) 
							sData  = sData + "@" ;
						else
							sData  = sData + fgrid_Main[i,j].ToString() + "@";
					}
					sw.WriteLine(sData);
					//sw.Flush();
				}

			
				sw.Flush();
				sw.Close();
				sDatalist.Close();

				#endregion

				//Report Base Form호출..
				FlexOrder.Report.Form_RD_Base report = new FlexOrder.Report.Form_RD_Base(txt_Filename,  mrd_Filename, Para);
				report.Show();

			}
			#endregion

			#region 기타 이벤트
			private void fgrid_Main_Click(object sender, System.EventArgs e)
			{	
				 ClassLib.ComFunction.Set_Gen_Color("01",fgrid_Main,_Rowfixed,fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_Search.IxGEN);
			}

			private void cmb_OBS_Type_TextChanged(object sender, System.EventArgs e)
			{
				cmb_OBS_ID1.ClearItems();
				cmb_OBS_ID2.ClearItems();

				if (cmb_OBS_Type.SelectedIndex != 0)
				{
					ClassLib.ComFunction.Set_OBSID_CmbList(cmb_OBS_Type.SelectedValue.ToString(), cmb_OBS_ID1);  
					ClassLib.ComFunction.Set_OBSID_CmbList(cmb_OBS_Type.SelectedValue.ToString(), cmb_OBS_ID2);  				
				}
			}


			private void fgrid_Main_DoubleClick(object sender, System.EventArgs e)
			{
				
				string sOBS_Real ="";

				if (fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_Search.IxOBS_NU].ToString().Substring(0,1) == "C")
					sOBS_Real = ClassLib.ComVar.ConsReal_N;
				else
					sOBS_Real = ClassLib.ComVar.ConsReal_Y;

				ClassLib.ComFunction.Sb_Pop_OBS_Info
					(
					sOBS_Real,
					cmb_Factory.SelectedValue.ToString(),
					fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_Search.IxOBS_TYPE].ToString(),
					fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_Search.IxOBS_ID].ToString(),
					fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_Search.IxSTYLE_CD].ToString(),
					fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_Search.IxOBS_NU].ToString(),
					fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_Search.IxOBS_SEQ_NU].ToString(),
					fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_Search.IxCHG_NU].ToString()
					);
			}


			private void dpick_Date_ValueChanged(object sender, System.EventArgs e)
			{
				//ClassLib.ComFunction.Set_Values(this, dpick_Date.Name);
			}


			#endregion

		#endregion 	

		#region 콘텍스트 메뉴
		private void ctm_PGS_OBS_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpLoad.Form_EL_PGS  frm = new ExpLoad.Form_EL_PGS(); 
			frm.Show();
		}


		private void ctm_MCR_OBS_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpLoad.Form_EL_MCR  frm = new ExpLoad.Form_EL_MCR(); 
			frm.Show();
		
		}

		private void ctm_OA_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOA.Form_OA_CRT01  frm = new ExpOA.Form_OA_CRT01(); 
			frm.Show();
		
		}

		private void ctm_OBS_REQ_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBS.Form_EO_Req  frm = new ExpOBS.Form_EO_Req(); 
			frm.Show();
		
		}

		private void ctm_CSOBS_REQ_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBSCS.Form_EC_Req  frm = new ExpOBSCS.Form_EC_Req(); 
			frm.Show();
		
		}

		private void ctm_OBS_Hist_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBS.Form_EO_Hist  frm = new ExpOBS.Form_EO_Hist(); 
			frm.Show();		
		}


		private void ctm_OBS_Type_Click(object sender, System.EventArgs e)
		{
		   SB_Pop_Type_Change();
		}






		#endregion

		private void Form_EO_SRCH_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}



	}
}

