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
	public class Form_EO_Req : COM.OrderWinForm.Form_Top
	{
		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.TextBox txt_OBS_Seq_Nu;
		private C1.Win.C1Command.C1Command c1Command1;
		public System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel pnl_save_image;
		private C1.Win.C1List.C1Combo cmb_Req_yn;
		private System.Windows.Forms.Label lbl_Req_yn;
		private System.Windows.Forms.TextBox txt_OBS_Nu;
		private System.Windows.Forms.TextBox txt_Style_cd;
		private System.Windows.Forms.Label lbl_OBD_Nu;
		private System.Windows.Forms.Label lbl_STYLE;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private C1.Win.C1List.C1Combo cmb_OBS_ID1;
		private System.Windows.Forms.Label lbl_Factory;
		private C1.Win.C1List.C1Combo cmb_OBS_Type;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private C1.Win.C1List.C1Combo cmb_OBS_ID2;
		private System.Windows.Forms.Label lbl_OBS_ID;
		private System.Windows.Forms.Label lbl_OBS_Type;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.PictureBox pictureBox19;
		private System.Windows.Forms.PictureBox pictureBox20;
		private System.Windows.Forms.PictureBox pictureBox21;
		private System.Windows.Forms.PictureBox pictureBox22;
		private System.Windows.Forms.PictureBox pictureBox23;
		private System.Windows.Forms.PictureBox pictureBox24;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem ctm_OBS_Sel;
		private System.Windows.Forms.MenuItem ctm_OBSHist_Sel;
		private System.Windows.Forms.CheckBox chk_Option;
		private System.Windows.Forms.MenuItem ctm_MCR_Load;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem ctm_OBS_Type_Change;
		private System.Windows.Forms.MenuItem ctm_Order_Adjsut;
		private System.Windows.Forms.MenuItem ctm_Request_History;
		private System.Windows.Forms.Label lbl_SubTitle2;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.PictureBox pictureBox17;
		private System.ComponentModel.IContainer components = null;

		public Form_EO_Req()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EO_Req));
			this.txt_OBS_Seq_Nu = new System.Windows.Forms.TextBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.ctm_MCR_Load = new System.Windows.Forms.MenuItem();
			this.ctm_OBS_Sel = new System.Windows.Forms.MenuItem();
			this.ctm_OBSHist_Sel = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.ctm_Order_Adjsut = new System.Windows.Forms.MenuItem();
			this.ctm_OBS_Type_Change = new System.Windows.Forms.MenuItem();
			this.ctm_Request_History = new System.Windows.Forms.MenuItem();
			this.c1Command1 = new C1.Win.C1Command.C1Command();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnl_save_image = new System.Windows.Forms.Panel();
			this.lbl_SubTitle2 = new System.Windows.Forms.Label();
			this.chk_Option = new System.Windows.Forms.CheckBox();
			this.cmb_Req_yn = new C1.Win.C1List.C1Combo();
			this.lbl_Req_yn = new System.Windows.Forms.Label();
			this.txt_OBS_Nu = new System.Windows.Forms.TextBox();
			this.txt_Style_cd = new System.Windows.Forms.TextBox();
			this.lbl_OBD_Nu = new System.Windows.Forms.Label();
			this.lbl_STYLE = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.cmb_OBS_ID1 = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.cmb_OBS_Type = new C1.Win.C1List.C1Combo();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.cmb_OBS_ID2 = new C1.Win.C1List.C1Combo();
			this.lbl_OBS_ID = new System.Windows.Forms.Label();
			this.lbl_OBS_Type = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox18 = new System.Windows.Forms.PictureBox();
			this.pictureBox19 = new System.Windows.Forms.PictureBox();
			this.pictureBox20 = new System.Windows.Forms.PictureBox();
			this.pictureBox21 = new System.Windows.Forms.PictureBox();
			this.pictureBox22 = new System.Windows.Forms.PictureBox();
			this.pictureBox23 = new System.Windows.Forms.PictureBox();
			this.pictureBox24 = new System.Windows.Forms.PictureBox();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnl_save_image.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Req_yn)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID2)).BeginInit();
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
			this.c1ToolBar1.Location = new System.Drawing.Point(712, 3);
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.c1Command1);
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
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// tbtn_Append
			// 
			this.tbtn_Append.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Append_Click);
			// 
			// stbar
			// 
			this.stbar.Name = "stbar";
			this.stbar.Size = new System.Drawing.Size(1000, 22);
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// txt_OBS_Seq_Nu
			// 
			this.txt_OBS_Seq_Nu.Location = new System.Drawing.Point(0, 0);
			this.txt_OBS_Seq_Nu.Name = "txt_OBS_Seq_Nu";
			this.txt_OBS_Seq_Nu.TabIndex = 0;
			this.txt_OBS_Seq_Nu.Text = "";
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.DockPadding.Left = 8;
			this.pnl_Body.DockPadding.Right = 8;
			this.pnl_Body.Location = new System.Drawing.Point(0, 192);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1000, 453);
			this.pnl_Body.TabIndex = 42;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.AutoResize = false;
			this.fgrid_Main.BackColor = System.Drawing.Color.White;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this.fgrid_Main.ContextMenu = this.contextMenu1;
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.Color.Black;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(8, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(984, 453);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 35;
			this.fgrid_Main.Click += new System.EventHandler(this.fgrid_Main_Click);
			this.fgrid_Main.DoubleClick += new System.EventHandler(this.fgrid_Main_DoubleClick);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.ctm_MCR_Load,
																						 this.ctm_OBS_Sel,
																						 this.ctm_OBSHist_Sel,
																						 this.menuItem1,
																						 this.ctm_Order_Adjsut,
																						 this.ctm_OBS_Type_Change,
																						 this.ctm_Request_History});
			// 
			// ctm_MCR_Load
			// 
			this.ctm_MCR_Load.Index = 0;
			this.ctm_MCR_Load.Text = "Mercury Loading";
			this.ctm_MCR_Load.Click += new System.EventHandler(this.ctm_MCR_Load_Click);
			// 
			// ctm_OBS_Sel
			// 
			this.ctm_OBS_Sel.Index = 1;
			this.ctm_OBS_Sel.Text = "Search By OBS";
			this.ctm_OBS_Sel.Click += new System.EventHandler(this.ctm_OBS_Sel_Click);
			// 
			// ctm_OBSHist_Sel
			// 
			this.ctm_OBSHist_Sel.Index = 2;
			this.ctm_OBSHist_Sel.Text = "Search By OBS History";
			this.ctm_OBSHist_Sel.Click += new System.EventHandler(this.ctm_OBSHist_Sel_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 3;
			this.menuItem1.Text = "-";
			// 
			// ctm_Order_Adjsut
			// 
			this.ctm_Order_Adjsut.Index = 4;
			this.ctm_Order_Adjsut.Text = "Create Order Adjust";
			this.ctm_Order_Adjsut.Click += new System.EventHandler(this.ctm_Order_Adjsut_Click);
			// 
			// ctm_OBS_Type_Change
			// 
			this.ctm_OBS_Type_Change.Index = 5;
			this.ctm_OBS_Type_Change.Text = "OBS Type Change";
			this.ctm_OBS_Type_Change.Click += new System.EventHandler(this.ctm_OBS_Type_Change_Click);
			// 
			// ctm_Request_History
			// 
			this.ctm_Request_History.Index = 6;
			this.ctm_Request_History.Text = "Request History";
			this.ctm_Request_History.Click += new System.EventHandler(this.ctm_Request_History_Click);
			// 
			// c1Command1
			// 
			this.c1Command1.Name = "c1Command1";
			this.c1Command1.Text = "All check";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.pictureBox17);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.DockPadding.All = 8;
			this.panel1.Location = new System.Drawing.Point(0, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1000, 128);
			this.panel1.TabIndex = 47;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pnl_save_image);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(512, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(480, 112);
			this.panel2.TabIndex = 130;
			// 
			// pnl_save_image
			// 
			this.pnl_save_image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_save_image.Controls.Add(this.lbl_SubTitle2);
			this.pnl_save_image.Controls.Add(this.chk_Option);
			this.pnl_save_image.Controls.Add(this.cmb_Req_yn);
			this.pnl_save_image.Controls.Add(this.lbl_Req_yn);
			this.pnl_save_image.Controls.Add(this.txt_OBS_Nu);
			this.pnl_save_image.Controls.Add(this.txt_Style_cd);
			this.pnl_save_image.Controls.Add(this.lbl_OBD_Nu);
			this.pnl_save_image.Controls.Add(this.lbl_STYLE);
			this.pnl_save_image.Controls.Add(this.pictureBox7);
			this.pnl_save_image.Controls.Add(this.pictureBox10);
			this.pnl_save_image.Controls.Add(this.pictureBox11);
			this.pnl_save_image.Controls.Add(this.pictureBox12);
			this.pnl_save_image.Controls.Add(this.pictureBox13);
			this.pnl_save_image.Controls.Add(this.pictureBox14);
			this.pnl_save_image.Controls.Add(this.pictureBox15);
			this.pnl_save_image.Controls.Add(this.pictureBox16);
			this.pnl_save_image.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_save_image.Location = new System.Drawing.Point(0, 0);
			this.pnl_save_image.Name = "pnl_save_image";
			this.pnl_save_image.Size = new System.Drawing.Size(480, 112);
			this.pnl_save_image.TabIndex = 128;
			// 
			// lbl_SubTitle2
			// 
			this.lbl_SubTitle2.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_SubTitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle2.Image")));
			this.lbl_SubTitle2.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle2.Name = "lbl_SubTitle2";
			this.lbl_SubTitle2.Size = new System.Drawing.Size(165, 30);
			this.lbl_SubTitle2.TabIndex = 0;
			this.lbl_SubTitle2.Text = "      etc Info.";
			this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chk_Option
			// 
			this.chk_Option.BackColor = System.Drawing.Color.White;
			this.chk_Option.Location = new System.Drawing.Point(325, 82);
			this.chk_Option.Name = "chk_Option";
			this.chk_Option.Size = new System.Drawing.Size(14, 21);
			this.chk_Option.TabIndex = 188;
			this.chk_Option.CheckedChanged += new System.EventHandler(this.chk_Option_CheckedChanged);
			// 
			// cmb_Req_yn
			// 
			this.cmb_Req_yn.AddItemCols = 0;
			this.cmb_Req_yn.AddItemSeparator = ';';
			this.cmb_Req_yn.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Req_yn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Req_yn.Caption = "";
			this.cmb_Req_yn.CaptionHeight = 17;
			this.cmb_Req_yn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Req_yn.ColumnCaptionHeight = 18;
			this.cmb_Req_yn.ColumnFooterHeight = 18;
			this.cmb_Req_yn.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Req_yn.ContentHeight = 15;
			this.cmb_Req_yn.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Req_yn.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Req_yn.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Req_yn.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Req_yn.EditorHeight = 15;
			this.cmb_Req_yn.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Req_yn.GapHeight = 2;
			this.cmb_Req_yn.ItemHeight = 15;
			this.cmb_Req_yn.Location = new System.Drawing.Point(111, 80);
			this.cmb_Req_yn.MatchEntryTimeout = ((long)(2000));
			this.cmb_Req_yn.MaxDropDownItems = ((short)(5));
			this.cmb_Req_yn.MaxLength = 32767;
			this.cmb_Req_yn.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Req_yn.Name = "cmb_Req_yn";
			this.cmb_Req_yn.PartialRightColumn = false;
			this.cmb_Req_yn.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Req_yn.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Req_yn.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Req_yn.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Req_yn.Size = new System.Drawing.Size(210, 19);
			this.cmb_Req_yn.TabIndex = 115;
			// 
			// lbl_Req_yn
			// 
			this.lbl_Req_yn.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Req_yn.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Req_yn.ImageIndex = 0;
			this.lbl_Req_yn.ImageList = this.img_Label;
			this.lbl_Req_yn.Location = new System.Drawing.Point(10, 80);
			this.lbl_Req_yn.Name = "lbl_Req_yn";
			this.lbl_Req_yn.Size = new System.Drawing.Size(100, 21);
			this.lbl_Req_yn.TabIndex = 114;
			this.lbl_Req_yn.Text = "Request";
			this.lbl_Req_yn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_OBS_Nu
			// 
			this.txt_OBS_Nu.BackColor = System.Drawing.Color.White;
			this.txt_OBS_Nu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_Nu.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_OBS_Nu.Location = new System.Drawing.Point(111, 58);
			this.txt_OBS_Nu.MaxLength = 100;
			this.txt_OBS_Nu.Name = "txt_OBS_Nu";
			this.txt_OBS_Nu.Size = new System.Drawing.Size(210, 21);
			this.txt_OBS_Nu.TabIndex = 112;
			this.txt_OBS_Nu.Text = "";
			// 
			// txt_Style_cd
			// 
			this.txt_Style_cd.BackColor = System.Drawing.Color.White;
			this.txt_Style_cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_cd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Style_cd.Location = new System.Drawing.Point(111, 36);
			this.txt_Style_cd.MaxLength = 100;
			this.txt_Style_cd.Name = "txt_Style_cd";
			this.txt_Style_cd.Size = new System.Drawing.Size(210, 21);
			this.txt_Style_cd.TabIndex = 111;
			this.txt_Style_cd.Text = "";
			// 
			// lbl_OBD_Nu
			// 
			this.lbl_OBD_Nu.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBD_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBD_Nu.ImageIndex = 0;
			this.lbl_OBD_Nu.ImageList = this.img_Label;
			this.lbl_OBD_Nu.Location = new System.Drawing.Point(10, 58);
			this.lbl_OBD_Nu.Name = "lbl_OBD_Nu";
			this.lbl_OBD_Nu.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBD_Nu.TabIndex = 110;
			this.lbl_OBD_Nu.Text = "OBS No";
			this.lbl_OBD_Nu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_STYLE
			// 
			this.lbl_STYLE.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_STYLE.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_STYLE.ImageIndex = 0;
			this.lbl_STYLE.ImageList = this.img_Label;
			this.lbl_STYLE.Location = new System.Drawing.Point(10, 36);
			this.lbl_STYLE.Name = "lbl_STYLE";
			this.lbl_STYLE.Size = new System.Drawing.Size(100, 21);
			this.lbl_STYLE.TabIndex = 109;
			this.lbl_STYLE.Text = "Style";
			this.lbl_STYLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(165, 0);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(304, 30);
			this.pictureBox7.TabIndex = 2;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(467, 0);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(13, 30);
			this.pictureBox10.TabIndex = 1;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox11.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(449, 30);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(31, 66);
			this.pictureBox11.TabIndex = 5;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.Color.Blue;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(455, 82);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(25, 30);
			this.pictureBox12.TabIndex = 8;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox13.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(0, 24);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(32, 77);
			this.pictureBox13.TabIndex = 3;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox14.BackColor = System.Drawing.Color.Blue;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(0, 82);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(72, 40);
			this.pictureBox14.TabIndex = 6;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox15.BackColor = System.Drawing.Color.Blue;
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(72, 82);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(392, 30);
			this.pictureBox15.TabIndex = 9;
			this.pictureBox15.TabStop = false;
			// 
			// pictureBox16
			// 
			this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox16.BackColor = System.Drawing.Color.Navy;
			this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
			this.pictureBox16.Location = new System.Drawing.Point(32, 24);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(432, 80);
			this.pictureBox16.TabIndex = 4;
			this.pictureBox16.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.DockPadding.Right = 4;
			this.panel3.Location = new System.Drawing.Point(8, 8);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(504, 112);
			this.panel3.TabIndex = 128;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.RosyBrown;
			this.panel4.Controls.Add(this.lbl_SubTitle1);
			this.panel4.Controls.Add(this.cmb_OBS_ID1);
			this.panel4.Controls.Add(this.lbl_Factory);
			this.panel4.Controls.Add(this.cmb_OBS_Type);
			this.panel4.Controls.Add(this.cmb_Factory);
			this.panel4.Controls.Add(this.cmb_OBS_ID2);
			this.panel4.Controls.Add(this.lbl_OBS_ID);
			this.panel4.Controls.Add(this.lbl_OBS_Type);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.pictureBox18);
			this.panel4.Controls.Add(this.pictureBox19);
			this.panel4.Controls.Add(this.pictureBox20);
			this.panel4.Controls.Add(this.pictureBox21);
			this.panel4.Controls.Add(this.pictureBox22);
			this.panel4.Controls.Add(this.pictureBox23);
			this.panel4.Controls.Add(this.pictureBox24);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(500, 112);
			this.panel4.TabIndex = 1;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(172, 32);
			this.lbl_SubTitle1.TabIndex = 0;
			this.lbl_SubTitle1.Text = "      Request Info.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_OBS_ID1.Location = new System.Drawing.Point(111, 80);
			this.cmb_OBS_ID1.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_ID1.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_ID1.MaxLength = 32767;
			this.cmb_OBS_ID1.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_ID1.Name = "cmb_OBS_ID1";
			this.cmb_OBS_ID1.PartialRightColumn = false;
			this.cmb_OBS_ID1.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_OBS_ID1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_ID1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID1.RowTracking = false;
			this.cmb_OBS_ID1.Size = new System.Drawing.Size(100, 19);
			this.cmb_OBS_ID1.TabIndex = 121;
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
			this.cmb_OBS_Type.Location = new System.Drawing.Point(111, 58);
			this.cmb_OBS_Type.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_Type.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_Type.MaxLength = 32767;
			this.cmb_OBS_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_Type.Name = "cmb_OBS_Type";
			this.cmb_OBS_Type.PartialRightColumn = false;
			this.cmb_OBS_Type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_OBS_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type.Size = new System.Drawing.Size(210, 19);
			this.cmb_OBS_Type.TabIndex = 119;
			this.cmb_OBS_Type.TextChanged += new System.EventHandler(this.cmb_OBS_Type_TextChanged);
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
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory.TabIndex = 118;
			this.cmb_Factory.TextChanged += new System.EventHandler(this.cmb_Factory_TextChanged);
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
			this.cmb_OBS_ID2.Location = new System.Drawing.Point(221, 80);
			this.cmb_OBS_ID2.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_ID2.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_ID2.MaxLength = 32767;
			this.cmb_OBS_ID2.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_ID2.Name = "cmb_OBS_ID2";
			this.cmb_OBS_ID2.PartialRightColumn = false;
			this.cmb_OBS_ID2.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_OBS_ID2.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_ID2.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID2.RowTracking = false;
			this.cmb_OBS_ID2.Size = new System.Drawing.Size(100, 19);
			this.cmb_OBS_ID2.TabIndex = 120;
			// 
			// lbl_OBS_ID
			// 
			this.lbl_OBS_ID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_ID.ImageIndex = 1;
			this.lbl_OBS_ID.ImageList = this.img_Label;
			this.lbl_OBS_ID.Location = new System.Drawing.Point(10, 80);
			this.lbl_OBS_ID.Name = "lbl_OBS_ID";
			this.lbl_OBS_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_ID.TabIndex = 117;
			this.lbl_OBS_ID.Text = "OBS ID";
			this.lbl_OBS_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_OBS_Type
			// 
			this.lbl_OBS_Type.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Type.ImageIndex = 1;
			this.lbl_OBS_Type.ImageList = this.img_Label;
			this.lbl_OBS_Type.Location = new System.Drawing.Point(10, 58);
			this.lbl_OBS_Type.Name = "lbl_OBS_Type";
			this.lbl_OBS_Type.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_Type.TabIndex = 116;
			this.lbl_OBS_Type.Text = "OBS Type";
			this.lbl_OBS_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(209, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 23);
			this.label1.TabIndex = 122;
			this.label1.Text = "~";
			// 
			// pictureBox18
			// 
			this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox18.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
			this.pictureBox18.Location = new System.Drawing.Point(478, 0);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(22, 32);
			this.pictureBox18.TabIndex = 1;
			this.pictureBox18.TabStop = false;
			// 
			// pictureBox19
			// 
			this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox19.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
			this.pictureBox19.Location = new System.Drawing.Point(481, 32);
			this.pictureBox19.Name = "pictureBox19";
			this.pictureBox19.Size = new System.Drawing.Size(19, 66);
			this.pictureBox19.TabIndex = 5;
			this.pictureBox19.TabStop = false;
			// 
			// pictureBox20
			// 
			this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox20.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
			this.pictureBox20.Location = new System.Drawing.Point(0, 24);
			this.pictureBox20.Name = "pictureBox20";
			this.pictureBox20.Size = new System.Drawing.Size(32, 77);
			this.pictureBox20.TabIndex = 3;
			this.pictureBox20.TabStop = false;
			// 
			// pictureBox21
			// 
			this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox21.BackColor = System.Drawing.Color.Blue;
			this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
			this.pictureBox21.Location = new System.Drawing.Point(410, 98);
			this.pictureBox21.Name = "pictureBox21";
			this.pictureBox21.Size = new System.Drawing.Size(90, 14);
			this.pictureBox21.TabIndex = 8;
			this.pictureBox21.TabStop = false;
			// 
			// pictureBox22
			// 
			this.pictureBox22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox22.BackColor = System.Drawing.Color.Blue;
			this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
			this.pictureBox22.Location = new System.Drawing.Point(72, 98);
			this.pictureBox22.Name = "pictureBox22";
			this.pictureBox22.Size = new System.Drawing.Size(412, 14);
			this.pictureBox22.TabIndex = 9;
			this.pictureBox22.TabStop = false;
			// 
			// pictureBox23
			// 
			this.pictureBox23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox23.BackColor = System.Drawing.Color.Blue;
			this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
			this.pictureBox23.Location = new System.Drawing.Point(0, 98);
			this.pictureBox23.Name = "pictureBox23";
			this.pictureBox23.Size = new System.Drawing.Size(80, 14);
			this.pictureBox23.TabIndex = 6;
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
			this.pictureBox24.Size = new System.Drawing.Size(452, 80);
			this.pictureBox24.TabIndex = 4;
			this.pictureBox24.TabStop = false;
			// 
			// pictureBox17
			// 
			this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox17.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox17.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
			this.pictureBox17.Location = new System.Drawing.Point(170, 7);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(316, 32);
			this.pictureBox17.TabIndex = 123;
			this.pictureBox17.TabStop = false;
			// 
			// Form_EO_Req
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.ClientSize = new System.Drawing.Size(1000, 666);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnl_Body);
			this.Font = new System.Drawing.Font("Verdana", 8F);
			this.Name = "Form_EO_Req";
			this.Text = "OBS Product Request ";
			this.Load += new System.EventHandler(this.Form_EO_Req_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.pnl_save_image.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Req_yn)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의
   
		private int _Rowfixed;    
		COM.OraDB MyOraDB = new COM.OraDB();        

		#endregion 	
	
		#region 멤버 메서드 
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			try
			{
				DataTable dt_list; 
		
				//Title
				this.Text = "OBS Product Request";
				this.lbl_MainTitle.Text = "OBS Product Request"; 
				ClassLib.ComFunction.SetLangDic(this);

				#region 버튼 권한
				tbtn_Append.Enabled = true;
				tbtn_Color.Enabled =false;
				tbtn_Create.Enabled =false;
				tbtn_Delete.Enabled =false;
				tbtn_Insert.Enabled =false;
				tbtn_New.Enabled =true;
				tbtn_Print.Enabled =true;
				tbtn_Save.Enabled =true;
				tbtn_Search.Enabled =true;


				#endregion


			
				#region 그리드 설정
				// fgrid_main(TBSEM_OBS_REQ)
				_Rowfixed = 6;
				//fgrid_Main.Set_Grid( "SEM_OBS", "4", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
				fgrid_Main.Set_Grid( "SEM_OBS", "4", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
				ClassLib.ComFunction.Set_Size_Grid(fgrid_Main, _Rowfixed, (int)ClassLib.TBSEM_OBS_REQ.IxGEN);
				for (int i=1; i<_Rowfixed; i++)
				{
					fgrid_Main[i, (int)ClassLib.TBSEM_OBS_REQ.lxFLAG]   = "Flag ";
				}
				fgrid_Main.Font  = new Font("Verdana",8);


				//merge
				fgrid_Main.AllowMerging = AllowMergingEnum.FixedOnly;
				for (int i=(int)ClassLib.TBSEM_OBS_REQ.IxFACTORY    ; i<=(int)ClassLib.TBSEM_OBS_REQ.IxSTYLE_NM ;i++)
				{
					fgrid_Main.Cols[i] .AllowMerging = true;
				}
				ClassLib.ComFunction.Set_Head_Bold("01", fgrid_Main, _Rowfixed, (int)ClassLib.TBSEM_OBS_CS_SIZE.IxGEN);

				#endregion 

		
				// 콤보박스 설정
				///Factory
				dt_list = ClassLib.ComFunction.Select_Factory_List();
				ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0);
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
				

				///Req_yn
				dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxReq_yn);
				ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Req_yn, 1, 2, true);  			
				cmb_Req_yn.SelectedIndex = 0;			

				///OBS_Type
				dt_list = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxOBS_Type);
				ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OBS_Type, 1, 2, false);  			
				cmb_OBS_Type.SelectedIndex = 0;			

				txt_Style_cd.Text  = "";
				txt_OBS_Nu.Text = "";

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default; 

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
										 fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_REQ.IxSTYLE_CD].ToString(),										 
										 fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_REQ.IxOBS_NU].ToString(),
										 fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_REQ.IxOBS_SEQ_NU].ToString(),
										 fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_REQ.IxCHG_NU].ToString(),
										 fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_REQ.IxTOT_QTY].ToString()
									 };
				
			pop_form.ShowDialog();


		}




		/// <summary>
		/// SB_Request_History
		/// </summary>
		private void  SB_Request_History()
		{			
		

			FlexOrder.ExpOBS.POP_EO_Request_History  pop_form = new ExpOBS.POP_EO_Request_History();
	
			COM.ComVar.Parameter_PopUp = new string[]
									 {
										 cmb_Factory.SelectedValue.ToString(),
										 cmb_OBS_ID1.Text ,
										 cmb_OBS_Type.Columns[0].Text,
										 fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_REQ.IxSTYLE_CD].ToString(),										 
									 };
				
			pop_form.ShowDialog();


		}



		



		/// <summary>
		/// Sb_Pop_OBS: OBS Popup창
		/// </summary>
		private void Sb_Pop_OBS()
		{
			string sOBS_Real ="";

			if (fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_REQ.IxOBS_NU].ToString().Substring(0,1) == "C")
				sOBS_Real = ClassLib.ComVar.ConsReal_N;
			else
				sOBS_Real = ClassLib.ComVar.ConsReal_Y;

			ClassLib.ComFunction.Sb_Pop_OBS_Info
				(
					sOBS_Real,
					cmb_Factory.SelectedValue.ToString(),
					fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_REQ.IxOBS_TYPE].ToString(),
					fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_REQ.IxOBS_ID].ToString(),
					fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_REQ.IxSTYLE_CD].ToString(),
					fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_REQ.IxOBS_NU].ToString(),
					fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_REQ.IxOBS_SEQ_NU].ToString(),
					fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_REQ.IxCHG_NU].ToString()
			    );
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
			int iPLAN_DIV   = (int)ClassLib.TBSEM_OBS_REQ.lxPLAN_DIV;
			int iOBS_NU     = (int)ClassLib.TBSEM_OBS_REQ.IxOBS_NU;
			int iOBS_SEQ_NU = (int)ClassLib.TBSEM_OBS_REQ.IxOBS_SEQ_NU;
			int iCHG_NU     = (int)ClassLib.TBSEM_OBS_REQ.IxCHG_NU;
			int iGEN        = (int)ClassLib.TBSEM_OBS_REQ.IxGEN;

			for(int i=0; i<arg_dt.Rows.Count; i++)
			{					
				string sOBS_NU     = arg_dt.Rows[i].ItemArray[iOBS_NU-1].ToString();
				string sOBS_SEQ_NU = arg_dt.Rows[i].ItemArray[iOBS_SEQ_NU-1].ToString();
				string sCHG_NU     = arg_dt.Rows[i].ItemArray[iCHG_NU-1].ToString();					
				string sSIZE       = arg_dt.Rows[i].ItemArray[iGEN].ToString();
				string sQTY        = arg_dt.Rows[i].ItemArray[iGEN+1].ToString();		

				//Row변경 
				if (( fgrid_Main.Rows.Count == _Rowfixed ) ||
					( sOBS_NU     != fgrid_Main[fgrid_Main.Rows.Count-1, iOBS_NU].ToString()     ) || 
					( sOBS_SEQ_NU != fgrid_Main[fgrid_Main.Rows.Count-1, iOBS_SEQ_NU].ToString() ) || 
					( sCHG_NU     != fgrid_Main[fgrid_Main.Rows.Count-1, iCHG_NU].ToString()     )  )
				{
					fgrid_Main.AddItem(arg_dt.Rows[i].ItemArray, fgrid_Main.Rows.Count, 1);
					fgrid_Main[fgrid_Main.Rows.Count-1, iGEN+1] = " ";
					fgrid_Main[fgrid_Main.Rows.Count-1, iGEN+2] = " ";

					if (fgrid_Main[fgrid_Main.Rows.Count - 1, iPLAN_DIV].ToString().Trim() == "P")
						fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1,  (int)ClassLib.TBSEM_OBS_REQ.lxPLAN_DIV,
							                fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSEM_OBS_REQ.lxPLAN_DIV).StyleNew.ForeColor = ClassLib.ComVar.Clr_Text_Red ;

					string sGEN = arg_dt.Rows[i].ItemArray[iGEN-1].ToString();
					for(int j=1; j<_Rowfixed; j++)
						if (fgrid_Main[j, iGEN].ToString() == sGEN)
							iRow_Gen = j;
				}

				//Size 별 수량 
				for(int j=iGEN; j<fgrid_Main.Cols.Count; j++)
				{
					if (fgrid_Main[iRow_Gen, j].ToString() == sSIZE)
					{
						fgrid_Main[fgrid_Main.Rows.Count-1, j] = sQTY;
						break;
					}
				}
			}

			//Column Position잡기
			for(int k = iGEN+1 ; k<fgrid_Main.Cols.Count ; k++)
			{
				if (fgrid_Main[_Rowfixed, k].ToString() != null)
				{
					fgrid_Main.LeftCol = k;
					break;
				}
			}

			Display_Subtotal(fgrid_Main);
			
		}
  


		private void Display_Subtotal(C1FlexGrid arg_fgrid)
		{
		   arg_fgrid.SubtotalPosition = SubtotalPositionEnum.AboveData;
		   arg_fgrid.Tree.Column = 2;

			CellStyle cStyle = arg_fgrid.Styles[CellStyleEnum.Subtotal0];
			cStyle.Font = new Font(arg_fgrid.Font , FontStyle.Bold);

			for (int c = (int)ClassLib.TBSEM_OBS_REQ.IxGEN +1 ; c < arg_fgrid.Cols.Count; c++)
		    {
				arg_fgrid.Subtotal(AggregateEnum.Sum, 1, 1, (int)ClassLib.TBSEM_OBS_REQ.IxTOT_QTY, "Style Total {0}");
				arg_fgrid.Subtotal(AggregateEnum.Sum, 1, 1, c, "Grand Total {0}");		
				arg_fgrid.Styles[CellStyleEnum.Subtotal1].BackColor  = ClassLib.ComVar.Clr_Head_RYellow;
				arg_fgrid.Styles[CellStyleEnum.Subtotal1].ForeColor  = ClassLib.ComVar.Clr_Text_Red;
				arg_fgrid.Styles[CellStyleEnum.Subtotal1].Font       = cStyle.Font;

				arg_fgrid.Subtotal(AggregateEnum.Sum, 2, 2, (int)ClassLib.TBSEM_OBS_REQ.IxTOT_QTY, "Style Total {0}");
				arg_fgrid.Subtotal(AggregateEnum.Sum, 2, 2, c, "Style Total {0}");
				arg_fgrid.Styles[CellStyleEnum.Subtotal2].BackColor  = ClassLib.ComVar.Clr_Head_RYellow;
				arg_fgrid.Styles[CellStyleEnum.Subtotal2].ForeColor  = ClassLib.ComVar.Clr_Text_Blue;
				arg_fgrid.Styles[CellStyleEnum.Subtotal2].Font       = cStyle.Font;

		   }
       }


		#endregion

        #region DB 컨트롤
		/// <summary>
		/// Select_OBS_List : OBS/REQ 리스트 찾기 
		/// </summary>
		private DataTable Select_OBS_List()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_REQ.SELECT_SEM_REQ";

			MyOraDB.ReDim_Parameter(8); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_REQ_YN";  
			MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";  
			MyOraDB.Parameter_Name[3] = "ARG_OBS_ID1";  
			MyOraDB.Parameter_Name[4] = "ARG_OBS_ID2";  
			MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";  
			MyOraDB.Parameter_Name[6] = "ARG_OBS_NU";  
			MyOraDB.Parameter_Name[7] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_Req_yn.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = cmb_OBS_Type.SelectedValue.ToString();
			MyOraDB.Parameter_Values[3] = cmb_OBS_ID1.Text;
			MyOraDB.Parameter_Values[4] = cmb_OBS_ID2.Text;
			MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_TextBox(txt_Style_cd, " ");
			MyOraDB.Parameter_Values[6] = ClassLib.ComFunction.Empty_TextBox(txt_OBS_Nu,   " ");
			MyOraDB.Parameter_Values[7] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
		}


		/// <summary>
		/// Save_Req_List : Request 리스트 저장
		/// </summary>
		/// <param name="arg_para_count">파라미터 개수</param>
		/// <param name="arg_proc_name">프로세스 이름</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		public void Save_Req_List()
		{
			int i,row_count = 0, intParm,  iCnt  =0;
			
			DataSet ret;
									    
			intParm =9;
			MyOraDB.ReDim_Parameter(intParm); 

			//Package Name
			MyOraDB.Process_Name=  "PKG_SEM_REQ.SAVE_SEM_REQ";
			
			//Parameter Name
			MyOraDB.Parameter_Name[iCnt] = "ARG_FACTORY";
			iCnt  = iCnt +1;
			for(i = (int)ClassLib.TBSEM_OBS_REQ.lxREQ_NO; i <= (int)ClassLib.TBSEM_OBS_REQ.IxJOB_ID; i++)
			{
				MyOraDB.Parameter_Name[iCnt] = "ARG_" + fgrid_Main[0, i].ToString(); 
				iCnt  = iCnt +1;
			}
			
			MyOraDB.Parameter_Name[iCnt ]   = "ARG_UPD_USER";  iCnt  = iCnt +1;
			MyOraDB.Parameter_Name[iCnt ] = "ARG_UPD_YMD";

			//Parameter Type
			for (i =0 ; i< intParm-1; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

			MyOraDB.Parameter_Type[intParm-1] = (int)OracleType.Cursor;


			for(i =  _Rowfixed; i < fgrid_Main.Rows.Count; i++)
			{
				if(Convert.ToBoolean(fgrid_Main[i, (int)ClassLib.TBSEM_OBS_REQ.lxFLAG]))
				{
					row_count += 1;
				}
			}

			MyOraDB.Parameter_Values = new string[intParm * row_count];
            iCnt  = 0;
			for(i =  _Rowfixed; i < fgrid_Main.Rows.Count; i++)
			{
				if(Convert.ToBoolean(fgrid_Main[i, (int)ClassLib.TBSEM_OBS_REQ.lxFLAG]))
				{  
					MyOraDB.Parameter_Values[iCnt] = fgrid_Main[i,(int)ClassLib.TBSEM_OBS_REQ.IxFACTORY].ToString();     iCnt  = iCnt  +1;
					MyOraDB.Parameter_Values[iCnt] = ((fgrid_Main[i,(int)ClassLib.TBSEM_OBS_REQ.lxREQ_NO]== null) ||
						                              (fgrid_Main[i,(int)ClassLib.TBSEM_OBS_REQ.lxREQ_NO].ToString()== "" ))?" ":
						                              fgrid_Main[i,(int)ClassLib.TBSEM_OBS_REQ.lxREQ_NO].ToString();      iCnt  = iCnt  +1;
					MyOraDB.Parameter_Values[iCnt] = (( fgrid_Main[i,(int)ClassLib.TBSEM_OBS_REQ.lxREQ_SESQ_NU] == null) ||
						                              ( fgrid_Main[i,(int)ClassLib.TBSEM_OBS_REQ.lxREQ_SESQ_NU].ToString() == ""))? " ":
						                             fgrid_Main[i,(int)ClassLib.TBSEM_OBS_REQ.lxREQ_SESQ_NU].ToString();      iCnt  = iCnt  +1;
					MyOraDB.Parameter_Values[iCnt] = fgrid_Main[i,(int)ClassLib.TBSEM_OBS_REQ.IxOBS_NU].ToString();      iCnt  = iCnt  +1;
					MyOraDB.Parameter_Values[iCnt] = fgrid_Main[i,(int)ClassLib.TBSEM_OBS_REQ.IxOBS_SEQ_NU].ToString();  iCnt  = iCnt  +1;
					MyOraDB.Parameter_Values[iCnt] = fgrid_Main[i,(int)ClassLib.TBSEM_OBS_REQ.IxCHG_NU].ToString();      iCnt  = iCnt  +1;
					MyOraDB.Parameter_Values[iCnt] = fgrid_Main[i,(int)ClassLib.TBSEM_OBS_REQ.IxJOB_ID].ToString();      iCnt  = iCnt  +1;
					MyOraDB.Parameter_Values[iCnt] = ClassLib.ComVar.This_User;                                          iCnt  = iCnt  +1;
					MyOraDB.Parameter_Values[iCnt] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");                iCnt  = iCnt  +1;
				}				
			}  
					
			MyOraDB.Add_Modify_Parameter(true);	
			
			ret =  MyOraDB.Exe_Modify_Procedure();	
		    
		

		}


		#endregion

		#region 이벤트 처리  

		#region 버튼 이벤트
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;	

			cmb_OBS_ID1.ClearItems();
			cmb_OBS_ID2.ClearItems();
			cmb_OBS_Type.SelectedIndex = 0;
			cmb_Req_yn.SelectedIndex   = 2;

			txt_Style_cd.Clear();
			txt_OBS_Nu.Clear();

			fgrid_Main.Rows.Count = _Rowfixed;  		
		}


		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			COM.ComFunction comfunc = new COM.ComFunction();
			comfunc.Common_WorkInfo();
		}


		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor ;

				DataTable dt_ret;

				//SEM_OBS 정보를 읽어온다

				dt_ret = Select_OBS_List();
                
				if (dt_ret.Rows.Count == 0 ) 
				{ ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch,this); return;}
    
				Display_fgrid(dt_ret, fgrid_Main);

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch,this);

			}
			catch 
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch ,this);
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
				DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
				if(DialogResult.Yes != dr) return;

				this.Cursor = Cursors.WaitCursor ;


				//행 수정 상태 해제
				fgrid_Main.Select(fgrid_Main.Selection.r1, 0, fgrid_Main.Selection.r1, fgrid_Main.Cols.Count-1, false);
	 
				Save_Req_List();
				
				fgrid_Main.Rows.Count = _Rowfixed;		

				//SEM_OBS 정보를 읽어온다
				tbtn_Search_Click(null,null);
				
			}
			catch 
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave ,this);
			}
			finally
			{
				this.Cursor = Cursors.Default;


			}
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			string mrd_Filename = "Form_EO_REQ.mrd" ;
			string txt_Filename = this.Name + ".txt"; 
			string Para         = " ";


			//조회조건들----------------------------------------------------------------------
			int  iCnt  = 7;
			string [] aHead =  new string[iCnt];	
			aHead[0]    = cmb_Factory.SelectedValue.ToString();
			aHead[1]    = cmb_OBS_Type.SelectedValue.ToString();
			aHead[2]    = cmb_OBS_ID1.Text.ToString();
			aHead[3]    = cmb_OBS_ID2.Text.ToString();
			aHead[4]    = txt_Style_cd.Text;
			aHead[5]    = txt_OBS_Nu.Text;
			aHead[6]    = cmb_Req_yn.SelectedValue.ToString();
			
			//------------------- ------------------------------------------------------------


			//Parameter만들기
			Para  = "/rfn [" + Application.StartupPath + @"\"+ txt_Filename+ "]  /rv "; 			
			for (int i  = 1 ; i<= iCnt ; i++)
			{
				Para = Para +  "V_" + i.ToString().PadLeft (2,'0').ToString() + "[" + aHead[i-1] + "] ";
			}
			Para = Para + "V_USER[" + ClassLib.ComVar.This_User + "]";

			//File 출력 리스트
			//			fgrid_Main.SaveGrid(txt_Filename, FileFormatEnum.TextComma, false);

			//txt 파일 내용 구성 ------------------------------------------------------------
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

				if (fgrid_Main[i,(int)ClassLib.TBSEM_OBS_REQ.IxSTYLE_CD ].ToString().Length  != 9 ) continue;

				for(int j = 0 ; j<fgrid_Main.Cols.Count ;j++)
				{
					if (fgrid_Main[i,j]==null) 
						sData  = sData + "," ;
					else
						sData  = sData + fgrid_Main[i,j].ToString() + ",";
				}
				sw.WriteLine(sData);
				//sw.Flush();
			}
	
			//sw.Write(sData);
			sw.Flush();
			sw.Close();
			sDatalist.Close();
			//------------------- ------------------------------------------------------------


			//Report Base Form호출..
			FlexOrder.Report.Form_RD_Base  report = new FlexOrder.Report.Form_RD_Base(txt_Filename,  mrd_Filename, Para);
			report.Show();

		}
	
		#endregion

		#region 기타 이벤트
		private void cmb_OBS_Type_TextChanged(object sender, System.EventArgs e)
		{
			cmb_OBS_ID1.ClearItems();
			cmb_OBS_ID2.ClearItems();
			ClassLib.ComFunction.Set_OBSID_CmbList(cmb_OBS_Type.SelectedValue.ToString(), cmb_OBS_ID1);  
			ClassLib.ComFunction.Set_OBSID_CmbList(cmb_OBS_Type.SelectedValue.ToString(), cmb_OBS_ID2);  		


			cmb_Factory_TextChanged(null, null);		
		}

		private void cmb_Factory_TextChanged(object sender, System.EventArgs e)
		{
			fgrid_Main.Rows.Count = _Rowfixed;
		}

		private void fgrid_Main_Click(object sender, System.EventArgs e)
		{
			//subtotal 자리는 생산의뢰 구분 변경불가
			if (fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSEM_OBS_REQ.IxSTYLE_NM] == null) return;

			if ((fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSEM_OBS_REQ.lxFLAG].ToString() == "True") &&
				(fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSEM_OBS_REQ.lxOLD_REQ_NO].ToString().Length > 1))
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave,this);
				fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSEM_OBS_REQ.lxFLAG] = "False";
				return;
			}				


			if ((fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSEM_OBS_REQ.lxFLAG].ToString() == "True") &&
				(fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSEM_OBS_REQ.IxCS_REQ].ToString() =="Y") &&
				(fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSEM_OBS_REQ.IxREQ_YN].ToString() == "N"))
			{
				string vmessage = "1. Changshin Order is requested.."  + "\r\n\r\n" + 
					              "2. Same po#, item# is requested.."  + "\r\n\r\n" + 
					              "Follow OA Process.";
																					    
				ClassLib.ComFunction.User_Message(vmessage);
				fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSEM_OBS_REQ.lxFLAG] = "False";
				return;
			}



			if ((fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSEM_OBS_REQ.lxFLAG].ToString() == "True") &&
				(fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSEM_OBS_REQ.lxPLAN_DIV].ToString() == "P"))
			{
				ClassLib.ComFunction.User_Message("This Reuqest is applied by planning..");
				fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSEM_OBS_REQ.lxFLAG] = "False";
				return;
			}

        

			ClassLib.ComFunction.Set_Gen_Color("01",fgrid_Main,_Rowfixed,fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_REQ.IxGEN);

		}


		private void chk_Option_CheckedChanged(object sender, System.EventArgs e)
		{   
			int iCnt=0  ;

			for (int  k=_Rowfixed ; k<fgrid_Main.Rows.Count; k++)
				if (fgrid_Main[k,(int)ClassLib.TBSEM_OBS_REQ.lxFLAG]  != null)
				{ 
					iCnt  = k;
					break;
				}
            


			if (fgrid_Main[iCnt, (int)ClassLib.TBSEM_OBS_REQ.lxFLAG].ToString()=="True")
			{   
				for (int i=_Rowfixed ; i<fgrid_Main.Rows.Count; i++)
				{
					if (fgrid_Main[i,(int)ClassLib.TBSEM_OBS_REQ.IxSTYLE_NM] == null) continue;

					fgrid_Main[i,(int)ClassLib.TBSEM_OBS_REQ.lxFLAG] ="False";
				}

			}
			else
			{   
				for (int i=_Rowfixed ; i<fgrid_Main.Rows.Count; i++)
				{
					if (fgrid_Main[i,(int)ClassLib.TBSEM_OBS_CS_SIZE.IxSTYLE_NM] == null) continue;

					fgrid_Main[i,(int)ClassLib.TBSEM_OBS_CS_SIZE.lxFLAG] ="True";


					if ((fgrid_Main[i, (int)ClassLib.TBSEM_OBS_CS_SIZE.lxFLAG].ToString() == "True") &&
						(fgrid_Main[i, (int)ClassLib.TBSEM_OBS_CS_SIZE.lxPLAN_DIV].ToString() == "P"))
					{
						//ClassLib.ComFunction.User_Message("This Reuqest is applied by planning..");
						fgrid_Main[i, (int)ClassLib.TBSEM_OBS_CS_SIZE.lxFLAG] = "False";
					}	


				}
			}
		}

		private void fgrid_Main_DoubleClick(object sender, System.EventArgs e)
		{
			Sb_Pop_OBS();
		}

		#endregion

		#region 콘텍스트 메뉴
		private void ctm_MCR_Load_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpLoad.Form_EL_MCR  frm = new ExpLoad.Form_EL_MCR();  
			frm.Show();
		}

		private void ctm_OBS_Sel_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBS.Form_EO_SRCH frm = new ExpOBS.Form_EO_SRCH();  
			frm.Show();
		}

		private void ctm_OBSHist_Sel_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBS.Form_EO_Hist frm = new ExpOBS.Form_EO_Hist();  
			frm.Show();
		}

		private void ctm_OBS_Type_Change_Click(object sender, System.EventArgs e)
		{
		   SB_Pop_Type_Change();
			

		}



		private void ctm_Request_History_Click(object sender, System.EventArgs e)
		{

			 SB_Request_History();
		
		}



		private void ctm_Order_Adjsut_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOA.Form_OA_Create frm = new ExpOA.Form_OA_Create();
			frm.Show();
		}



		#endregion

		
		#endregion

		private void Form_EO_Req_Load(object sender, System.EventArgs e)
		{
			Init_Form();				
		}





	
	}
}

