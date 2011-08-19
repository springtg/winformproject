using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.IO;

namespace FlexPurchase.Search
{
	public class Form_EO_Analysis : COM.OrderWinForm.Form_Top
	{
		#region 컨트롤정의 및 리소스 정의

		private System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		public System.Windows.Forms.Panel pnl_Search;
		private C1.Win.C1List.C1Combo cmb_OBS_ID_To;
		private C1.Win.C1List.C1Combo cmb_OBS_ID_From;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel pnl_Search1_Image;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.GroupBox grp_Option;
		private System.Windows.Forms.Label lbl_Descrition;
		private System.Windows.Forms.RadioButton rad_Factory;
		private System.Windows.Forms.RadioButton rad_Style;
		private System.Windows.Forms.RadioButton rad_OBS_ID;
		private System.Windows.Forms.Button btn_Monthly_Fob;
		private System.Windows.Forms.Button btn_Monthly_Budget;
		private System.ComponentModel.IContainer components = null;

		public Form_EO_Analysis()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EO_Analysis));
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_Search1_Image = new System.Windows.Forms.Panel();
			this.btn_Monthly_Fob = new System.Windows.Forms.Button();
			this.lbl_Descrition = new System.Windows.Forms.Label();
			this.grp_Option = new System.Windows.Forms.GroupBox();
			this.rad_OBS_ID = new System.Windows.Forms.RadioButton();
			this.rad_Style = new System.Windows.Forms.RadioButton();
			this.rad_Factory = new System.Windows.Forms.RadioButton();
			this.cmb_OBS_ID_To = new C1.Win.C1List.C1Combo();
			this.cmb_OBS_ID_From = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.btn_Monthly_Budget = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_Search1_Image.SuspendLayout();
			this.grp_Option.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID_To)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID_From)).BeginInit();
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
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(216, 40);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(812, 32);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.DockPadding.Left = 10;
			this.pnl_Body.DockPadding.Right = 10;
			this.pnl_Body.DockPadding.Top = 10;
			this.pnl_Body.Location = new System.Drawing.Point(0, 160);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 504);
			this.pnl_Body.TabIndex = 44;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.AutoResize = false;
			this.fgrid_Main.BackColor = System.Drawing.Color.White;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.Color.Black;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(10, 10);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(996, 494);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 36;
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_Search1_Image);
			this.pnl_Search.DockPadding.All = 8;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1012, 100);
			this.pnl_Search.TabIndex = 45;
			// 
			// pnl_Search1_Image
			// 
			this.pnl_Search1_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search1_Image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_Search1_Image.Controls.Add(this.btn_Monthly_Budget);
			this.pnl_Search1_Image.Controls.Add(this.btn_Monthly_Fob);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Descrition);
			this.pnl_Search1_Image.Controls.Add(this.grp_Option);
			this.pnl_Search1_Image.Controls.Add(this.cmb_OBS_ID_To);
			this.pnl_Search1_Image.Controls.Add(this.cmb_OBS_ID_From);
			this.pnl_Search1_Image.Controls.Add(this.label1);
			this.pnl_Search1_Image.Controls.Add(this.label2);
			this.pnl_Search1_Image.Controls.Add(this.label3);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Factory);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox3);
			this.pnl_Search1_Image.Controls.Add(this.lbl_SubTitle1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox5);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox8);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox7);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox10);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox11);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox12);
			this.pnl_Search1_Image.Location = new System.Drawing.Point(8, 8);
			this.pnl_Search1_Image.Name = "pnl_Search1_Image";
			this.pnl_Search1_Image.Size = new System.Drawing.Size(996, 88);
			this.pnl_Search1_Image.TabIndex = 0;
			// 
			// btn_Monthly_Fob
			// 
			this.btn_Monthly_Fob.BackColor = System.Drawing.Color.White;
			this.btn_Monthly_Fob.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Monthly_Fob.Location = new System.Drawing.Point(712, 60);
			this.btn_Monthly_Fob.Name = "btn_Monthly_Fob";
			this.btn_Monthly_Fob.Size = new System.Drawing.Size(120, 23);
			this.btn_Monthly_Fob.TabIndex = 182;
			this.btn_Monthly_Fob.Text = "Monthly Fob";
			this.btn_Monthly_Fob.Visible = false;
			this.btn_Monthly_Fob.Click += new System.EventHandler(this.btn_Monthly_Fob_Click);
			// 
			// lbl_Descrition
			// 
			this.lbl_Descrition.BackColor = System.Drawing.Color.White;
			this.lbl_Descrition.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Descrition.Location = new System.Drawing.Point(384, 32);
			this.lbl_Descrition.Name = "lbl_Descrition";
			this.lbl_Descrition.Size = new System.Drawing.Size(240, 18);
			this.lbl_Descrition.TabIndex = 181;
			this.lbl_Descrition.Text = "** Description : PS/SS --> Per Year..";
			// 
			// grp_Option
			// 
			this.grp_Option.BackColor = System.Drawing.Color.White;
			this.grp_Option.Controls.Add(this.rad_OBS_ID);
			this.grp_Option.Controls.Add(this.rad_Style);
			this.grp_Option.Controls.Add(this.rad_Factory);
			this.grp_Option.ForeColor = System.Drawing.Color.Black;
			this.grp_Option.Location = new System.Drawing.Point(648, 24);
			this.grp_Option.Name = "grp_Option";
			this.grp_Option.Size = new System.Drawing.Size(336, 32);
			this.grp_Option.TabIndex = 180;
			this.grp_Option.TabStop = false;
			// 
			// rad_OBS_ID
			// 
			this.rad_OBS_ID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rad_OBS_ID.Location = new System.Drawing.Point(138, 9);
			this.rad_OBS_ID.Name = "rad_OBS_ID";
			this.rad_OBS_ID.Size = new System.Drawing.Size(70, 20);
			this.rad_OBS_ID.TabIndex = 186;
			this.rad_OBS_ID.Text = "OBS";
			this.rad_OBS_ID.CheckedChanged += new System.EventHandler(this.rad_OBS_ID_CheckedChanged);
			// 
			// rad_Style
			// 
			this.rad_Style.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rad_Style.Location = new System.Drawing.Point(247, 9);
			this.rad_Style.Name = "rad_Style";
			this.rad_Style.Size = new System.Drawing.Size(56, 20);
			this.rad_Style.TabIndex = 185;
			this.rad_Style.Text = "Style";
			this.rad_Style.CheckedChanged += new System.EventHandler(this.rad_Style_CheckedChanged);
			// 
			// rad_Factory
			// 
			this.rad_Factory.Checked = true;
			this.rad_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rad_Factory.Location = new System.Drawing.Point(15, 9);
			this.rad_Factory.Name = "rad_Factory";
			this.rad_Factory.Size = new System.Drawing.Size(104, 20);
			this.rad_Factory.TabIndex = 184;
			this.rad_Factory.TabStop = true;
			this.rad_Factory.Text = "Factory";
			this.rad_Factory.CheckedChanged += new System.EventHandler(this.rad_Factory_CheckedChanged);
			// 
			// cmb_OBS_ID_To
			// 
			this.cmb_OBS_ID_To.AddItemCols = 0;
			this.cmb_OBS_ID_To.AddItemSeparator = ';';
			this.cmb_OBS_ID_To.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_ID_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_ID_To.Caption = "";
			this.cmb_OBS_ID_To.CaptionHeight = 17;
			this.cmb_OBS_ID_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_ID_To.ColumnCaptionHeight = 18;
			this.cmb_OBS_ID_To.ColumnFooterHeight = 18;
			this.cmb_OBS_ID_To.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_ID_To.ContentHeight = 15;
			this.cmb_OBS_ID_To.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_ID_To.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OBS_ID_To.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID_To.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_ID_To.EditorHeight = 15;
			this.cmb_OBS_ID_To.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID_To.GapHeight = 2;
			this.cmb_OBS_ID_To.ItemHeight = 15;
			this.cmb_OBS_ID_To.Location = new System.Drawing.Point(233, 56);
			this.cmb_OBS_ID_To.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_ID_To.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_ID_To.MaxLength = 32767;
			this.cmb_OBS_ID_To.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_ID_To.Name = "cmb_OBS_ID_To";
			this.cmb_OBS_ID_To.PartialRightColumn = false;
			this.cmb_OBS_ID_To.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
			this.cmb_OBS_ID_To.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_ID_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID_To.Size = new System.Drawing.Size(95, 19);
			this.cmb_OBS_ID_To.TabIndex = 178;
			// 
			// cmb_OBS_ID_From
			// 
			this.cmb_OBS_ID_From.AddItemCols = 0;
			this.cmb_OBS_ID_From.AddItemSeparator = ';';
			this.cmb_OBS_ID_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_ID_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_ID_From.Caption = "";
			this.cmb_OBS_ID_From.CaptionHeight = 17;
			this.cmb_OBS_ID_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_ID_From.ColumnCaptionHeight = 18;
			this.cmb_OBS_ID_From.ColumnFooterHeight = 18;
			this.cmb_OBS_ID_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_ID_From.ContentHeight = 15;
			this.cmb_OBS_ID_From.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_ID_From.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OBS_ID_From.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_ID_From.EditorHeight = 15;
			this.cmb_OBS_ID_From.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID_From.GapHeight = 2;
			this.cmb_OBS_ID_From.ItemHeight = 15;
			this.cmb_OBS_ID_From.Location = new System.Drawing.Point(117, 56);
			this.cmb_OBS_ID_From.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_ID_From.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_ID_From.MaxLength = 32767;
			this.cmb_OBS_ID_From.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_ID_From.Name = "cmb_OBS_ID_From";
			this.cmb_OBS_ID_From.PartialRightColumn = false;
			this.cmb_OBS_ID_From.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
			this.cmb_OBS_ID_From.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_ID_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID_From.Size = new System.Drawing.Size(95, 19);
			this.cmb_OBS_ID_From.TabIndex = 177;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Verdana", 8F);
			this.label1.ImageIndex = 1;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(16, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 176;
			this.label1.Text = "OBS ID";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(216, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 16);
			this.label2.TabIndex = 175;
			this.label2.Text = "~";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Verdana", 8F);
			this.label3.ImageIndex = 1;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(16, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 173;
			this.label3.Text = "Factory";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.Location = new System.Drawing.Point(117, 33);
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
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory.TabIndex = 174;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(974, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(22, 32);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(168, -1);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(812, 32);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(172, 32);
			this.lbl_SubTitle1.TabIndex = 0;
			this.lbl_SubTitle1.Text = "      Order Analysis";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(977, 32);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(19, 42);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.Color.Blue;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(906, 74);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(90, 14);
			this.pictureBox8.TabIndex = 8;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(0, 24);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(32, 53);
			this.pictureBox7.TabIndex = 3;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.Color.Navy;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(32, 24);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(948, 56);
			this.pictureBox10.TabIndex = 4;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox11.BackColor = System.Drawing.Color.Blue;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(0, 74);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(80, 14);
			this.pictureBox11.TabIndex = 6;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.Color.Blue;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(72, 74);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(908, 14);
			this.pictureBox12.TabIndex = 9;
			this.pictureBox12.TabStop = false;
			// 
			// btn_Monthly_Budget
			// 
			this.btn_Monthly_Budget.BackColor = System.Drawing.Color.White;
			this.btn_Monthly_Budget.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Monthly_Budget.Location = new System.Drawing.Point(864, 58);
			this.btn_Monthly_Budget.Name = "btn_Monthly_Budget";
			this.btn_Monthly_Budget.Size = new System.Drawing.Size(120, 23);
			this.btn_Monthly_Budget.TabIndex = 185;
			this.btn_Monthly_Budget.Text = "Monthly Budget";
			this.btn_Monthly_Budget.Click += new System.EventHandler(this.btn_Monthly_Budget_Click);
			// 
			// Form_EO_Analysis
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Search);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pictureBox2);
			this.Name = "Form_EO_Analysis";
			this.Load += new System.EventHandler(this.Form_EO_Analysis_Load);
			this.Controls.SetChildIndex(this.pictureBox2, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_Search1_Image.ResumeLayout(false);
			this.grp_Option.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID_To)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID_From)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수
		int _Rowfixed  =3;
		private COM.OraDB MyOraDB = new COM.OraDB(); 

		#endregion 

		#region 공통메쏘드
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			DataTable dt_list;
		
			//Title
			this.Text = "Order Monitoring";
			this.lbl_MainTitle.Text = "Order Monitoring"; 
			ClassLib.ComFunction.SetLangDic(this);

			#region 버튼 권한
//
//			try
//			{
//				COM.OraDB btn_control = new COM.OraDB();
//				DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
//				tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
//				btn_control = null;
//
//				
//				//Button 활성화
//				tbtn_Append.Enabled = false;   tbtn_Delete.Enabled = false;   tbtn_Insert.Enabled = false; 
//				tbtn_Save.Enabled = false;   tbtn_Print.Enabled = false; 
//				tbtn_Search.Enabled  = true;
//					 
//			}
//			catch
//			{
//			}

			#endregion
		
		
			// 그리드 설정(TBSEM_OBS_ANALYSIS)
			fgrid_Main.Set_Grid( "SEM_OBS_ANALYSIS", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch,false);
			fgrid_Main.Set_Grid( "SEM_OBS_ANALYSIS", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch,false);
			fgrid_Main.Font  = new Font("Verdana",8);
			fgrid_Main.AutoResize = false;

			// 공장설정
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			//OBSID
			ClassLib.ComFunction.Set_OBSID_CmbList(ClassLib.ComVar.ConsType, cmb_OBS_ID_From);  
			ClassLib.ComFunction.Set_OBSID_CmbList(ClassLib.ComVar.ConsType, cmb_OBS_ID_To);  			

			rad_OBS_ID.Checked   =  true;

		}

	
		private void Display_Order(DataTable arg_dt)
		{

			for (int i =0 ;   i< arg_dt.Rows.Count ; i++)
			{

				fgrid_Main.AddItem(arg_dt.Rows[i].ItemArray, fgrid_Main.Rows.Count, 1); 
				
	

			}


		}



		private  void Display_Change()
		{   

			#region ***Merge*****

			fgrid_Main.AllowMerging = AllowMergingEnum.Free;
			fgrid_Main.Rows[1].AllowMerging = true;
			for (int i = (int)ClassLib.TBSEM_OBS_ANALYSIS.IxFACTORY  ; i < (int)ClassLib.TBSEM_OBS_ANALYSIS.lxGROUP_SORT_QTY ; i++)
				fgrid_Main.Cols[i].AllowMerging = true;

			#endregion


			#region ****서브토털 *****
			CellStyle cStyle = fgrid_Main.Styles[CellStyleEnum.Subtotal0];
			cStyle.Font = new Font(fgrid_Main.Font , FontStyle.Regular);

			
			int iFactory =  (int)ClassLib.TBSEM_OBS_ANALYSIS.IxFACTORY;
			int iOBS_ID =   (int)ClassLib.TBSEM_OBS_ANALYSIS.IxOBS_ID;
		

			fgrid_Main.SubtotalPosition = SubtotalPositionEnum.AboveData;

			//BY Factory
			fgrid_Main.Tree.Column = iFactory;
			for (int i = (int)ClassLib.TBSEM_OBS_ANALYSIS.lxAMOUNT ; i<=(int)ClassLib.TBSEM_OBS_ANALYSIS.IxOBS_TYPE_SS_RATE; i++)
			{
				if ( (i == (int)ClassLib.TBSEM_OBS_ANALYSIS.IxOBS_TYPE_FT_RATE ) ||
				     (i == (int)ClassLib.TBSEM_OBS_ANALYSIS.IxOBS_TYPE_ID_RATE ) ||
					 (i == (int)ClassLib.TBSEM_OBS_ANALYSIS.IxOBS_TYPE_TS_RATE ) ||
					 (i == (int)ClassLib.TBSEM_OBS_ANALYSIS.IxOBS_TYPE_PS_RATE ) ||
					 (i == (int)ClassLib.TBSEM_OBS_ANALYSIS.IxOBS_TYPE_SS_RATE ) )
					continue;

				fgrid_Main.Cols[iFactory].TextAlign = TextAlignEnum.RightCenter;
				fgrid_Main.Cols[iFactory].Format    =  "###,###,###.##";
				fgrid_Main.Subtotal(AggregateEnum.Sum, iFactory, iFactory,i,"Sum - {0}");
				fgrid_Main.Styles[CellStyleEnum.Subtotal1].BackColor  = ClassLib.ComVar.ClrTransparent;
				fgrid_Main.Styles[CellStyleEnum.Subtotal1].ForeColor  = Color.Red;
				fgrid_Main.Styles[CellStyleEnum.Subtotal1].Font       = cStyle.Font;

			}

            //by OBS Type
			for (int i = (int)ClassLib.TBSEM_OBS_ANALYSIS.lxAMOUNT; i<=(int)ClassLib.TBSEM_OBS_ANALYSIS.IxOBS_TYPE_SS_RATE; i++)
			{

				fgrid_Main.Cols[i].TextAlign = TextAlignEnum.RightCenter;
				fgrid_Main.Cols[i].Format    =  "###,###,###.##";

				fgrid_Main.Subtotal(AggregateEnum.Sum, iOBS_ID, iOBS_ID,i,"Sum - {0}");
				fgrid_Main.Styles[CellStyleEnum.Subtotal3].BackColor  = ClassLib.ComVar.ClrTransparent;
				fgrid_Main.Styles[CellStyleEnum.Subtotal3].ForeColor  = Color.Blue;
				fgrid_Main.Styles[CellStyleEnum.Subtotal3].Font       = cStyle.Font;
			}
			

			Set_Display_Option();

		


			#endregion


			
			#region ****지난 자료칼라 변경 *****

             
			for (int i = fgrid_Main.Rows.Fixed  ; i < fgrid_Main.Rows.Count  ; i++)
			{

				
				if (fgrid_Main[ i,(int)ClassLib.TBSEM_OBS_ANALYSIS.IxCOLOR_FLAG] == null) continue;

				
				


				if (fgrid_Main[ i,(int)ClassLib.TBSEM_OBS_ANALYSIS.IxCOLOR_FLAG].ToString() =="F")
				{

					fgrid_Main.GetCellRange(i-1, 0, fgrid_Main.Rows.Count -1 ,fgrid_Main.Cols.Count -1).StyleNew.BackColor  =ClassLib.ComVar.ClrTransparent;
					fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed , 0, i-2 ,fgrid_Main.Cols.Count -1).StyleNew.BackColor  =ClassLib.ComVar.ClrSel_Yellow;


					break;

				}
			}
	
			
			fgrid_Main.Cols[(int)ClassLib.TBSEM_OBS_PROFIT.lxFACTORY].Width  = 150;

			#endregion 

            

		}


		private void Set_Display_Option()
		{
			if  (rad_Factory.Checked     == true) fgrid_Main .Tree.Show((int)ClassLib.TBSEM_OBS_ANALYSIS.IxFACTORY);
			if  (rad_OBS_ID.Checked     == true) fgrid_Main.Tree.Show((int)ClassLib.TBSEM_OBS_ANALYSIS.IxOBS_ID);
			if  (rad_Style.Checked     == true) fgrid_Main.Tree.Show((int)ClassLib.TBSEM_OBS_ANALYSIS.IxSTYLE_CD);
		}

		#endregion 

		#region 이벤트처리


		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				DataTable  vDt;
				fgrid_Main.Rows.Count   = _Rowfixed;

				vDt  = SELECT_ORDER_ANALYSIS();

				Display_Order(vDt);

				Display_Change();

				this.Cursor = Cursors.Default;



			}
			catch(Exception ex)
			{

				ClassLib.ComFunction.User_Message(ex.ToString(),  "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

			}
			finally
			{
				this.Cursor = Cursors.Default;

			}

		}


		private void btn_Monthly_Budget_Click(object sender, System.EventArgs e)
		{
			FlexPurchase.Search.POP_Monthly_Budget  pop_form = new FlexPurchase.Search.POP_Monthly_Budget();
			COM.ComVar.Parameter_PopUp = new string[] 
			{
				cmb_Factory.SelectedValue.ToString(),
				cmb_OBS_ID_From.Text.ToString(),
			};
			 
			pop_form.ShowDialog();
		}



		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Main.Rows.Count =_Rowfixed;
		}


		private void rad_Factory_CheckedChanged(object sender, System.EventArgs e)
		{
			
			Set_Display_Option();

		}

		private void rad_OBS_ID_CheckedChanged(object sender, System.EventArgs e)
		{
			Set_Display_Option();
		}

		private void rad_Style_CheckedChanged(object sender, System.EventArgs e)
		{
			Set_Display_Option();
		}


		private void btn_Monthly_Fob_Click(object sender, System.EventArgs e)
		{
			FlexPurchase.Search.POP_Monthly_Fob  pop_form = new FlexPurchase.Search.POP_Monthly_Fob();
			COM.ComVar.Parameter_PopUp = new string[] 
			{
				cmb_Factory.SelectedValue.ToString(),
				cmb_OBS_ID_From.Text.ToString(),
			};
			 
			pop_form.ShowDialog();
			  
		}





		#endregion 

		#region DB컨넥트

		/// <summary>
		/// SELECT_ORDER_ANALYSIS 
		/// </summary>
		private DataTable SELECT_ORDER_ANALYSIS()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_MNT.SELECT_SEM_OBS_ANALYSIS";

			MyOraDB.ReDim_Parameter(4); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OBS_ID_FROM";
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_ID_TO";
			MyOraDB.Parameter_Name[3]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]  = cmb_OBS_ID_From.Text;
			MyOraDB.Parameter_Values[2]  = cmb_OBS_ID_To.Text;
			MyOraDB.Parameter_Values[3]  = "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}

		#endregion  


		private void Form_EO_Analysis_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}



	

	}
}

