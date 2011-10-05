using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexTrade.Nego
{
	public class Pop_TN_Bank : COM.TradeWinForm.Pop_Large
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		public System.Windows.Forms.Panel pnl_Search;
		private System.Windows.Forms.Panel pnl_Menu;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label btn_Insert;
		private System.Windows.Forms.StatusBar stbar;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.Panel panel1;
		private COM.FSP fgrid_main;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.TextBox txt_Search;
		private System.Windows.Forms.Label lbl_SFactory;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.Label btn_apply;
		private System.ComponentModel.IContainer components = null;

		public Pop_TN_Bank(string[] arg_keys)
		{
			// �� ȣ���� Windows Form �����̳ʿ� �ʿ��մϴ�.
			InitializeComponent();

			_vfactory	= arg_keys[0];

			// TODO: InitializeComponent�� ȣ���� ���� �ʱ�ȭ �۾��� �߰��մϴ�.
		}

		/// <summary>
		/// ��� ���� ��� ���ҽ��� �����մϴ�.
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

		#region �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_TN_Bank));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.txt_Search = new System.Windows.Forms.TextBox();
			this.lbl_SFactory = new System.Windows.Forms.Label();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pnl_Menu = new System.Windows.Forms.Panel();
			this.btn_recover = new System.Windows.Forms.Label();
			this.btn_Insert = new System.Windows.Forms.Label();
			this.stbar = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
			this.btn_apply = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			this.pnl_Menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
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
			this.c1ToolBar1.Location = new System.Drawing.Point(377, 4);
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.UIStrings.Content = new string[0];
			// 
			// tbtn_New
			// 
			this.tbtn_New.Enabled = false;
			// 
			// tbtn_Search
			// 
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// tbtn_Delete
			// 
			this.tbtn_Delete.Enabled = false;
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(600, 23);
			// 
			// tbtn_Create
			// 
			this.tbtn_Create.Enabled = false;
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Enabled = false;
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// tbtn_Conform
			// 
			this.tbtn_Conform.Enabled = false;
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
			this.c1Sizer1.BorderWidth = 0;
			this.c1Sizer1.Controls.Add(this.panel1);
			this.c1Sizer1.Controls.Add(this.pnl_Search);
			this.c1Sizer1.Controls.Add(this.pnl_Menu);
			this.c1Sizer1.Controls.Add(this.stbar);
			this.c1Sizer1.GridDefinition = "21.484375:False:True;74.21875:False:False;0:False:True;4.296875:False:True;\t1.203" +
				"00751879699:False:True;97.7443609022556:False:False;1.05263157894737:False:False" +
				";";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 56);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(665, 512);
			this.c1Sizer1.SplitterWidth = 0;
			this.c1Sizer1.TabIndex = 27;
			this.c1Sizer1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.fgrid_main);
			this.panel1.Location = new System.Drawing.Point(8, 110);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(650, 380);
			this.panel1.TabIndex = 46;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Size = new System.Drawing.Size(650, 380);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 32;
			this.fgrid_main.Click += new System.EventHandler(this.fgrid_main_Click);
			this.fgrid_main.DoubleClick += new System.EventHandler(this.fgrid_main_DoubleClick);
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.DockPadding.All = 7;
			this.pnl_Search.Location = new System.Drawing.Point(0, 0);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(658, 110);
			this.pnl_Search.TabIndex = 45;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.btn_apply);
			this.pnl_SearchImage.Controls.Add(this.cmb_factory);
			this.pnl_SearchImage.Controls.Add(this.lbl_factory);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.txt_Search);
			this.pnl_SearchImage.Controls.Add(this.lbl_SFactory);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.pictureBox6);
			this.pnl_SearchImage.Controls.Add(this.textBox1);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(7, 7);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(644, 96);
			this.pnl_SearchImage.TabIndex = 20;
			// 
			// cmb_factory
			// 
			this.cmb_factory.AddItemCols = 0;
			this.cmb_factory.AddItemSeparator = ';';
			this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_factory.AutoSize = false;
			this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_factory.Caption = "";
			this.cmb_factory.CaptionHeight = 17;
			this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_factory.ColumnCaptionHeight = 18;
			this.cmb_factory.ColumnFooterHeight = 18;
			this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_factory.ContentHeight = 17;
			this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_factory.EditorFont = new System.Drawing.Font("����", 9F);
			this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_factory.EditorHeight = 17;
			this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_factory.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_factory.GapHeight = 2;
			this.cmb_factory.ItemHeight = 15;
			this.cmb_factory.Location = new System.Drawing.Point(109, 40);
			this.cmb_factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_factory.MaxDropDownItems = ((short)(5));
			this.cmb_factory.MaxLength = 32767;
			this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_factory.Name = "cmb_factory";
			this.cmb_factory.PartialRightColumn = false;
			this.cmb_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:����, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control" +
				";Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style" +
				"10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18" +
				"\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><Cli" +
				"entRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
				"crollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style" +
				"9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" m" +
				"e=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Hea" +
				"ding\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><Inac" +
				"tiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style" +
				"8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle " +
				"parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1" +
				"List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style par" +
				"ent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=" +
				"\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"" +
				"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent" +
				"=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Hea" +
				"ding\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><" +
				"vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Def" +
				"aultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(200, 21);
			this.cmb_factory.TabIndex = 151;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 40);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 152;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(543, 30);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(101, 58);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(630, 81);
			this.picb_BR.Name = "picb_BR";
			this.picb_BR.Size = new System.Drawing.Size(13, 15);
			this.picb_BR.TabIndex = 23;
			this.picb_BR.TabStop = false;
			// 
			// picb_TM
			// 
			this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
			this.picb_TM.Location = new System.Drawing.Point(224, 0);
			this.picb_TM.Name = "picb_TM";
			this.picb_TM.Size = new System.Drawing.Size(409, 28);
			this.picb_TM.TabIndex = 0;
			this.picb_TM.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle1.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle1.TabIndex = 28;
			this.lbl_SubTitle1.Text = "      Search Info.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Search
			// 
			this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Search.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Search.Location = new System.Drawing.Point(109, 62);
			this.txt_Search.MaxLength = 5;
			this.txt_Search.Name = "txt_Search";
			this.txt_Search.Size = new System.Drawing.Size(200, 21);
			this.txt_Search.TabIndex = 150;
			this.txt_Search.Text = "";
			this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_KeyPress);
			// 
			// lbl_SFactory
			// 
			this.lbl_SFactory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_SFactory.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SFactory.ImageIndex = 0;
			this.lbl_SFactory.ImageList = this.img_Label;
			this.lbl_SFactory.Location = new System.Drawing.Point(8, 62);
			this.lbl_SFactory.Name = "lbl_SFactory";
			this.lbl_SFactory.Size = new System.Drawing.Size(100, 21);
			this.lbl_SFactory.TabIndex = 149;
			this.lbl_SFactory.Text = "Filter";
			this.lbl_SFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(628, 0);
			this.picb_TR.Name = "picb_TR";
			this.picb_TR.Size = new System.Drawing.Size(24, 67);
			this.picb_TR.TabIndex = 21;
			this.picb_TR.TabStop = false;
			// 
			// picb_BM
			// 
			this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
			this.picb_BM.Location = new System.Drawing.Point(123, 80);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(508, 17);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 81);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(144, 19);
			this.picb_BL.TabIndex = 22;
			this.picb_BL.TabStop = false;
			// 
			// picb_ML
			// 
			this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 22);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(144, 65);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(137, 22);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(542, 58);
			this.pictureBox6.TabIndex = 27;
			this.pictureBox6.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(137, 22);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(86, 21);
			this.textBox1.TabIndex = 145;
			this.textBox1.Text = "";
			// 
			// pnl_Menu
			// 
			this.pnl_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Menu.Controls.Add(this.btn_recover);
			this.pnl_Menu.Controls.Add(this.btn_Insert);
			this.pnl_Menu.Location = new System.Drawing.Point(8, 490);
			this.pnl_Menu.Name = "pnl_Menu";
			this.pnl_Menu.Size = new System.Drawing.Size(650, 0);
			this.pnl_Menu.TabIndex = 44;
			// 
			// btn_recover
			// 
			this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_recover.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_recover.ImageIndex = 1;
			this.btn_recover.ImageList = this.image_List;
			this.btn_recover.Location = new System.Drawing.Point(560, 8);
			this.btn_recover.Name = "btn_recover";
			this.btn_recover.Size = new System.Drawing.Size(80, 23);
			this.btn_recover.TabIndex = 351;
			this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_recover.Visible = false;
			this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
			// 
			// btn_Insert
			// 
			this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Insert.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Insert.ImageIndex = 9;
			this.btn_Insert.ImageList = this.image_List;
			this.btn_Insert.Location = new System.Drawing.Point(479, 8);
			this.btn_Insert.Name = "btn_Insert";
			this.btn_Insert.Size = new System.Drawing.Size(80, 23);
			this.btn_Insert.TabIndex = 350;
			this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Insert.Visible = false;
			this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
			// 
			// stbar
			// 
			this.stbar.Location = new System.Drawing.Point(0, 490);
			this.stbar.Name = "stbar";
			this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																					 this.statusBarPanel1,
																					 this.statusBarPanel2});
			this.stbar.Size = new System.Drawing.Size(665, 22);
			this.stbar.TabIndex = 43;
			// 
			// img_LongButton
			// 
			this.img_LongButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_LongButton.ImageSize = new System.Drawing.Size(100, 23);
			this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
			this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_apply
			// 
			this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_apply.Font = new System.Drawing.Font("����", 9F);
			this.btn_apply.ImageIndex = 0;
			this.btn_apply.ImageList = this.img_LongButton;
			this.btn_apply.Location = new System.Drawing.Point(520, 64);
			this.btn_apply.Name = "btn_apply";
			this.btn_apply.TabIndex = 565;
			this.btn_apply.Text = "Apply";
			this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
			this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseUp);
			this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseDown);
			// 
			// Pop_TN_Bank
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(664, 566);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Pop_TN_Bank";
			this.Load += new System.EventHandler(this.Pop_TN_Bank_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.pnl_Menu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		#region User Define Variable

		private COM.OraDB MyOraDB  = new COM.OraDB();
		private int _Rowfixed;
		private string _vfactory;

		private int _colFACTORY		 = (int)ClassLib.TBSTM_BANK_MASTER.IxFACTORY;	
		private int _colBANK_CD		 = (int)ClassLib.TBSTM_BANK_MASTER.IxBANK_CD;	
		private int _colBANK_NAME1	 = (int)ClassLib.TBSTM_BANK_MASTER.IxBANK_NAME1;
		private int _colBANK_NAME2	 = (int)ClassLib.TBSTM_BANK_MASTER.IxBANK_NAME2;
		private int _colBANK_NAME3	 = (int)ClassLib.TBSTM_BANK_MASTER.IxBANK_NAME3;
		private int _colBANK_NAME4	 = (int)ClassLib.TBSTM_BANK_MASTER.IxBANK_NAME4;
		



		#endregion

		private void Pop_TN_Bank_Load(object sender, System.EventArgs e)
		{
			Init_Form();		
		}

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "Bank Master";
			this.Text		   = "Bank";


			// grid set
			fgrid_main.Set_Grid("STM_BANK", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			_Rowfixed = fgrid_main.Rows.Fixed;

//			fgrid_main.Set_Action_Image(img_Action);
//			fgrid_main.Rows[1].AllowMerging = true;

			fgrid_main.Styles.Frozen.BackColor = Color.Lavender; 			
			fgrid_main.KeyActionEnter = KeyActionEnum.MoveAcross;
			fgrid_main.KeyActionTab = KeyActionEnum.MoveAcross;  
			fgrid_main.SelectionMode = SelectionModeEnum.Cell;

			DataTable vDt;
				
			// factory set
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
			cmb_factory.SelectedValue    = ClassLib.ComVar.This_Factory;

			txt_Search.Select();


		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_STM_MASTER.SELECT_STM_BANK";

				DataTable vDt = SELECT_STM_BANK(vProcedure);

				Clear_FlexGrid();
				if (vDt.Rows.Count > 0)
				{
					Display_FlexGrid(vDt);

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}

		public DataTable SELECT_STM_BANK(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE��
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT ��
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_FILTER";
			MyOraDB.Parameter_Name[ 2]  = "OUT_CURSOR";

			//03.DATA TYPE ����
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.Cursor;

			//04.DATA ����
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[ 1]   = ClassLib.ComFunction.Empty_TextBox(txt_Search, "");
			MyOraDB.Parameter_Values[ 2]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void Clear_FlexGrid()
		{
			if (fgrid_main.Rows.Fixed != fgrid_main.Rows.Count)
			{				
				fgrid_main.Clear(ClearFlags.UserData, fgrid_main.Rows.Fixed, 1, fgrid_main.Rows.Count - 1, fgrid_main.Cols.Count - 1);

				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
			}
		}


		private void Display_FlexGrid(DataTable arg_dt)
		{
			int iCount = arg_dt.Rows.Count;

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{				
				C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(_Rowfixed + iRow, 1);

				fgrid_main[newRow.Row.Index, 0] = "";

				for (int iCol = 1 ; iCol < arg_dt.Columns.Count ; iCol++)
					fgrid_main[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];

			}

		}

		private void txt_Search_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				this.Tbtn_SearchProcess();
		}

		private void fgrid_main_DoubleClick(object sender, System.EventArgs e)
		{
			int iRow = fgrid_main.Selection.r1;
			int iCol = fgrid_main.Selection.c1;

			if ((iRow >= _Rowfixed) && (iCol == _colBANK_CD))
				this.btn_ApplyProcess();
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			this.btn_ApplyProcess();
		}

		private void btn_ApplyProcess()
		{
			int iRow = fgrid_main.Selection.r1;

			COM.ComVar.Parameter_PopUp		= new string[2];
			
			COM.ComVar.Parameter_PopUp[0] = fgrid_main[iRow, _colBANK_CD].ToString();
			COM.ComVar.Parameter_PopUp[1] = fgrid_main[iRow, _colBANK_NAME1].ToString();

			this.Dispose();			
		}


		private void btn_recover_Click(object sender, System.EventArgs e)
		{
			COM.ComVar.Parameter_PopUp		= new string[0];
			this.Dispose();		
		}

		private void btn_Insert_Click(object sender, System.EventArgs e)
		{
//			try
//			{				
//				int iRow = fgrid_main.Rows.Count;
//
//				fgrid_main.Add_Row(iRow-1);
//			
//				fgrid_main[iRow, _colFACTORY]       = _vfactory;
//				fgrid_main[iRow, _colNOTIFY_KEY]    = "New";
//				fgrid_main[iRow, _colSHIP_TO]       = "0000000000";
//				fgrid_main[iRow, _colWERKS]         = "00000";
//				fgrid_main.GetCellRange(iRow, _colNOTIFY_KEY).StyleNew.ForeColor = Color.Red;
//			}
//			catch (Exception ex)
//			{
//				MessageBox.Show(ex.Message);
//			}			
//			finally
//			{
//				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
//			}		
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
//			if (Validate_Check())
//			{
//				if(ClassLib.ComFunction.User_Message("Do you want to save?","save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
//				{
//					this.Tbtn_SaveProcess();					
//				}
//			}				
		}

//		private bool Validate_Check()
//		{
//			for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
//			{
//				if ((fgrid_main[iRow, _colNOTIFY_NAME1].ToString().Replace(" ", "").Trim().Length == 0))
//				{
//					fgrid_main[iRow, 0] = "";
//				}
//			}			
//
//			return true;
//		}

		private void Tbtn_SaveProcess()
		{
//			try
//			{
//				this.Cursor = Cursors.WaitCursor;
//
//				if (SAVE_STM_NOTIFY_MASTER(true))
//				{
//					fgrid_main.Refresh_Division();
//					this.Tbtn_SearchProcess();
//					MessageBox.Show("Create Complete","Create", MessageBoxButtons.OK ,MessageBoxIcon.Information);
//				}
//			}
//			catch (Exception ex)
//			{
//				MessageBox.Show(ex.Message);
//			}
//			finally
//			{
//				this.Cursor = Cursors.Default;
//			}
		}

		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
		
		}

		private void btn_Apply_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_apply.ImageIndex = 1;
		}

		private void btn_Apply_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_apply.ImageIndex = 0;
		}

//		public bool SAVE_STM_NOTIFY_MASTER(bool doExecute)
//		{
//			try
//			{
//				int save_ct = 0;   
//				int para_ct = 0; 
//				int iCount  = 11;
//
//
//				MyOraDB.ReDim_Parameter(iCount);
//
//				//01.PROCEDURE��
//				MyOraDB.Process_Name = "PKG_STM_MASTER.SAVE_STM_NOTIFY";
//
//				//02.ARGURMENT ��
//				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
//				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
//				MyOraDB.Parameter_Name[ 2] = "ARG_NOTIFY_KEY";
//				MyOraDB.Parameter_Name[ 3] = "ARG_SHIP_TO";
//				MyOraDB.Parameter_Name[ 4] = "ARG_WERKS";
//				MyOraDB.Parameter_Name[ 5] = "ARG_NOTIFY_NAME1";
//				MyOraDB.Parameter_Name[ 6] = "ARG_NOTIFY_NAME2";
//				MyOraDB.Parameter_Name[ 7] = "ARG_NOTIFY_NAME3";
//				MyOraDB.Parameter_Name[ 8] = "ARG_NOTIFY_NAME4";
//				MyOraDB.Parameter_Name[ 9] = "ARG_NOTIFY_NAME5";				
//				MyOraDB.Parameter_Name[10] = "ARG_UPD_USER";
//
//
//
//				for (int iCol = 0 ; iCol < iCount ; iCol++)
//					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
//				
//				for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
//					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
//						save_ct += 1;
//
//				// �Ķ���� ���� ������ �迭
//				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];
//
//				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
//				{
//					if(fgrid_main[iRow, 0].ToString() != "")
//					{
//						MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main[iRow, 0].ToString();
//						MyOraDB.Parameter_Values[para_ct+ 1] = fgrid_main[iRow, _colFACTORY].ToString();
//						MyOraDB.Parameter_Values[para_ct+ 2] = fgrid_main[iRow, _colNOTIFY_KEY].ToString();
//						MyOraDB.Parameter_Values[para_ct+ 3] = fgrid_main[iRow, _colSHIP_TO].ToString();
//						MyOraDB.Parameter_Values[para_ct+ 4] = fgrid_main[iRow, _colWERKS].ToString();
//
//						if (fgrid_main[iRow, _colNOTIFY_NAME1] == null)
//							MyOraDB.Parameter_Values[para_ct+ 5] = "";
//						else 
//							MyOraDB.Parameter_Values[para_ct+ 5] = fgrid_main[iRow, _colNOTIFY_NAME1].ToString();
//
//						if (fgrid_main[iRow, _colNOTIFY_NAME2] == null)
//							MyOraDB.Parameter_Values[para_ct+ 6] = "";
//						else 
//							MyOraDB.Parameter_Values[para_ct+ 6] = fgrid_main[iRow, _colNOTIFY_NAME2].ToString();
//
//						if (fgrid_main[iRow, _colNOTIFY_NAME3] == null)
//							MyOraDB.Parameter_Values[para_ct+ 7] = "";
//						else 
//							MyOraDB.Parameter_Values[para_ct+ 7] = fgrid_main[iRow, _colNOTIFY_NAME3].ToString();
//
//						if (fgrid_main[iRow, _colNOTIFY_NAME4] == null)
//							MyOraDB.Parameter_Values[para_ct+ 8] = "";
//						else 
//							MyOraDB.Parameter_Values[para_ct+ 8] = fgrid_main[iRow, _colNOTIFY_NAME4].ToString();
//
//						if (fgrid_main[iRow, _colNOTIFY_NAME5] == null)
//							MyOraDB.Parameter_Values[para_ct+ 9] = "";
//						else 
//							MyOraDB.Parameter_Values[para_ct+ 9] = fgrid_main[iRow, _colNOTIFY_NAME5].ToString();
//
//						MyOraDB.Parameter_Values[para_ct+10] = COM.ComVar.This_User;
//
//						para_ct += iCount;	
//					}
//				
//				}
//
//				MyOraDB.Add_Modify_Parameter(true);		// �Ķ���� �����͸� DataSet�� �߰�
//				
//				if (doExecute)
//				{
//					if (MyOraDB.Exe_Modify_Procedure() == null)
//						return false;
//					else
//						return true;
//				}
//
//				return true;
//
//			}
//			catch
//			{
//				return false;
//			}
//		}


	}
}
