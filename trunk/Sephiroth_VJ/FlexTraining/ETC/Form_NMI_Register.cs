using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OleDb;

namespace FlexTraining.ETC
{
	public class Form_NMI_Register : COM.TrainingWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel2;
		private COM.FSP fgrid_main;
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.PictureBox picb_BR;
		private System.Windows.Forms.Label lbl_Month;
		private System.Windows.Forms.Label lbl_Acc;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.Label lbl_Dep;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_Season;
		private System.Windows.Forms.TextBox txt_VSM;
		private System.Windows.Forms.DateTimePicker dpick_D_Day;
		private C1.Win.C1List.C1Combo cmb_TD_Code;
		private System.Windows.Forms.DateTimePicker dpick_FSR;
		private C1.Win.C1List.C1Combo cmb_OBS_ID;
		private C1.Win.C1List.C1Combo cmb_Style;
		private C1.Win.C1List.C1Combo cmb_Line;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.TextBox txt_Category;
		private System.Windows.Forms.CheckBox chk_Style;
		private System.ComponentModel.IContainer components = null;

		public Form_NMI_Register()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
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

		#region User Define Variable

		private COM.OraDB MyOraDB  = new COM.OraDB();

		private int _Rowfixed=0;

		private int _colFACTORY                = (int) ClassLib.TBSIV_NMI_TRACKING.IxFACTORY;
		private int _colOBS_ID                 = (int) ClassLib.TBSIV_NMI_TRACKING.IxOBS_ID;
		private int _colSTYLE_CD               = (int) ClassLib.TBSIV_NMI_TRACKING.IxSTYLE_CD;             
		private int _colSTYLE_NM               = (int) ClassLib.TBSIV_NMI_TRACKING.IxSTYLE_NM;             
		private int _colLINE_CD                = (int) ClassLib.TBSIV_NMI_TRACKING.IxLINE_CD;             
		private int _colLINE_NM                = (int) ClassLib.TBSIV_NMI_TRACKING.IxLINE_NM;              
		private int _colCHECK_ITEM             = (int) ClassLib.TBSIV_NMI_TRACKING.IxCHECK_ITEM;
		private int _colCHECK_DATE_VALUE       = (int) ClassLib.TBSIV_NMI_TRACKING.IxCHECK_DATE_VALUE;
		private int _colCHECK_DATE_VALUE_DSC   = (int) ClassLib.TBSIV_NMI_TRACKING.IxCHECK_DATE_VALUE_DSC;
		private int _colCHECK_ITEM_NM          = (int) ClassLib.TBSIV_NMI_TRACKING.IxCHECK_ITEM_NM;     
		private int _colCHECK_ITEM_VNM         = (int) ClassLib.TBSIV_NMI_TRACKING.IxCHECK_ITEM_VNM;
		private int _colSEASON                 = (int) ClassLib.TBSIV_NMI_TRACKING.IxSEASON;
		private int _colTD_CODE                = (int) ClassLib.TBSIV_NMI_TRACKING.IxTD_CODE;
		private int _colFSR_DATE               = (int) ClassLib.TBSIV_NMI_TRACKING.IxFSR_DATE;
		private int _colD_DATE                 = (int) ClassLib.TBSIV_NMI_TRACKING.IxD_DATE;
		private int _colFINISH_DATE            = (int) ClassLib.TBSIV_NMI_TRACKING.IxFINISH_DATE;
		private int _colACTUAL_DATE            = (int) ClassLib.TBSIV_NMI_TRACKING.IxACTUAL_DATE;
		private int _colMAIN_DEPT              = (int) ClassLib.TBSIV_NMI_TRACKING.IxMAIN_DEPT;
		private int _colPIC1                   = (int) ClassLib.TBSIV_NMI_TRACKING.IxPIC1;
		private int _colPIC2                   = (int) ClassLib.TBSIV_NMI_TRACKING.IxPIC2;
		private int _colPIC3                   = (int) ClassLib.TBSIV_NMI_TRACKING.IxPIC3;
		private int _colPIC4                   = (int) ClassLib.TBSIV_NMI_TRACKING.IxPIC4;
		private int _colREMARK                 = (int) ClassLib.TBSIV_NMI_TRACKING.IxREMARK;
		private int _colADMIN_USER             = (int) ClassLib.TBSIV_NMI_TRACKING.IxADMIN_USER;
		private int _colBALANCE                = (int) ClassLib.TBSIV_NMI_TRACKING.IxBALANCE;
		private int _colCHECK_USER             = (int) ClassLib.TBSIV_NMI_TRACKING.IxCHECK_USER;

		#endregion

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_NMI_Register));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.chk_Style = new System.Windows.Forms.CheckBox();
			this.txt_Category = new System.Windows.Forms.TextBox();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.cmb_Line = new C1.Win.C1List.C1Combo();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dpick_FSR = new System.Windows.Forms.DateTimePicker();
			this.cmb_TD_Code = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.dpick_D_Day = new System.Windows.Forms.DateTimePicker();
			this.txt_VSM = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_Season = new System.Windows.Forms.TextBox();
			this.cmb_Style = new C1.Win.C1List.C1Combo();
			this.label3 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.cmb_OBS_ID = new C1.Win.C1List.C1Combo();
			this.lbl_Month = new System.Windows.Forms.Label();
			this.lbl_Acc = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.lbl_Dep = new System.Windows.Forms.Label();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_TD_Code)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
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
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
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
			this.c1Sizer1.Controls.Add(this.panel2);
			this.c1Sizer1.Controls.Add(this.pnl_Search);
			this.c1Sizer1.Controls.Add(this.statusBar1);
			this.c1Sizer1.GridDefinition = "19.7368421052632:False:True;75.8223684210526:False:False;0.822368421052632:False:" +
				"True;3.61842105263158:False:True;\t0.784313725490196:False:True;98.1372549019608:" +
				"False:False;1.07843137254902:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1020, 608);
			this.c1Sizer1.SplitterWidth = 0;
			this.c1Sizer1.TabIndex = 33;
			this.c1Sizer1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.fgrid_main);
			this.panel2.Location = new System.Drawing.Point(8, 120);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1001, 461);
			this.panel2.TabIndex = 46;
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
			this.fgrid_main.Size = new System.Drawing.Size(1001, 461);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 34;
			this.fgrid_main.Click += new System.EventHandler(this.fgrid_main_Click);
			this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
			this.fgrid_main.DoubleClick += new System.EventHandler(this.fgrid_main_DoubleClick);
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			this.fgrid_main.KeyPressEdit += new C1.Win.C1FlexGrid.KeyPressEditEventHandler(this.fgrid_main_KeyPressEdit);
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.panel3);
			this.pnl_Search.DockPadding.All = 7;
			this.pnl_Search.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_Search.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.pnl_Search.Location = new System.Drawing.Point(0, 0);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1020, 120);
			this.pnl_Search.TabIndex = 45;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Window;
			this.panel3.Controls.Add(this.chk_Style);
			this.panel3.Controls.Add(this.txt_Category);
			this.panel3.Controls.Add(this.txt_StyleCd);
			this.panel3.Controls.Add(this.cmb_Line);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.dpick_FSR);
			this.panel3.Controls.Add(this.cmb_TD_Code);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.dpick_D_Day);
			this.panel3.Controls.Add(this.txt_VSM);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.txt_Season);
			this.panel3.Controls.Add(this.cmb_Style);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.picb_BR);
			this.panel3.Controls.Add(this.cmb_OBS_ID);
			this.panel3.Controls.Add(this.lbl_Month);
			this.panel3.Controls.Add(this.lbl_Acc);
			this.panel3.Controls.Add(this.cmb_Factory);
			this.panel3.Controls.Add(this.lbl_factory);
			this.panel3.Controls.Add(this.picb_MR);
			this.panel3.Controls.Add(this.picb_TM);
			this.panel3.Controls.Add(this.lbl_SubTitle1);
			this.panel3.Controls.Add(this.lbl_Dep);
			this.panel3.Controls.Add(this.picb_TR);
			this.panel3.Controls.Add(this.picb_BM);
			this.panel3.Controls.Add(this.picb_BL);
			this.panel3.Controls.Add(this.picb_ML);
			this.panel3.Controls.Add(this.pictureBox6);
			this.panel3.Controls.Add(this.textBox1);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel3.Location = new System.Drawing.Point(7, 7);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1006, 106);
			this.panel3.TabIndex = 18;
			// 
			// chk_Style
			// 
			this.chk_Style.Location = new System.Drawing.Point(413, 79);
			this.chk_Style.Name = "chk_Style";
			this.chk_Style.Size = new System.Drawing.Size(19, 23);
			this.chk_Style.TabIndex = 607;
			this.chk_Style.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// txt_Category
			// 
			this.txt_Category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Category.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Category.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Category.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_Category.Location = new System.Drawing.Point(617, 33);
			this.txt_Category.MaxLength = 20;
			this.txt_Category.Name = "txt_Category";
			this.txt_Category.Size = new System.Drawing.Size(119, 22);
			this.txt_Category.TabIndex = 606;
			this.txt_Category.Text = "";
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_StyleCd.Location = new System.Drawing.Point(109, 78);
			this.txt_StyleCd.MaxLength = 20;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.Size = new System.Drawing.Size(104, 22);
			this.txt_StyleCd.TabIndex = 605;
			this.txt_StyleCd.Text = "";
			this.txt_StyleCd.TextChanged += new System.EventHandler(this.txt_StyleCd_TextChanged);
			this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
			// 
			// cmb_Line
			// 
			this.cmb_Line.AddItemCols = 0;
			this.cmb_Line.AddItemSeparator = ';';
			this.cmb_Line.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Line.AutoSize = false;
			this.cmb_Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Line.Caption = "";
			this.cmb_Line.CaptionHeight = 17;
			this.cmb_Line.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Line.ColumnCaptionHeight = 18;
			this.cmb_Line.ColumnFooterHeight = 18;
			this.cmb_Line.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Line.ContentHeight = 17;
			this.cmb_Line.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Line.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Line.EditorFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Line.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Line.EditorHeight = 17;
			this.cmb_Line.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Line.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Line.GapHeight = 2;
			this.cmb_Line.ItemHeight = 15;
			this.cmb_Line.Location = new System.Drawing.Point(544, 56);
			this.cmb_Line.MatchEntryTimeout = ((long)(2000));
			this.cmb_Line.MaxDropDownItems = ((short)(5));
			this.cmb_Line.MaxLength = 32767;
			this.cmb_Line.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Line.Name = "cmb_Line";
			this.cmb_Line.PartialRightColumn = false;
			this.cmb_Line.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
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
			this.cmb_Line.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Line.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Line.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Line.Size = new System.Drawing.Size(192, 21);
			this.cmb_Line.TabIndex = 604;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ImageIndex = 0;
			this.label6.ImageList = this.img_Label;
			this.label6.Location = new System.Drawing.Point(760, 34);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 21);
			this.label6.TabIndex = 603;
			this.label6.Text = "D-Day";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ImageIndex = 0;
			this.label5.ImageList = this.img_Label;
			this.label5.Location = new System.Drawing.Point(760, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 21);
			this.label5.TabIndex = 602;
			this.label5.Text = "FSR";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_FSR
			// 
			this.dpick_FSR.CustomFormat = "";
			this.dpick_FSR.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_FSR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_FSR.Location = new System.Drawing.Point(862, 56);
			this.dpick_FSR.Name = "dpick_FSR";
			this.dpick_FSR.Size = new System.Drawing.Size(122, 22);
			this.dpick_FSR.TabIndex = 601;
			// 
			// cmb_TD_Code
			// 
			this.cmb_TD_Code.AddItemCols = 0;
			this.cmb_TD_Code.AddItemSeparator = ';';
			this.cmb_TD_Code.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_TD_Code.AutoSize = false;
			this.cmb_TD_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_TD_Code.Caption = "";
			this.cmb_TD_Code.CaptionHeight = 17;
			this.cmb_TD_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_TD_Code.ColumnCaptionHeight = 18;
			this.cmb_TD_Code.ColumnFooterHeight = 18;
			this.cmb_TD_Code.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_TD_Code.ContentHeight = 17;
			this.cmb_TD_Code.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_TD_Code.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_TD_Code.EditorFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_TD_Code.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_TD_Code.EditorHeight = 17;
			this.cmb_TD_Code.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_TD_Code.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_TD_Code.GapHeight = 2;
			this.cmb_TD_Code.ItemHeight = 15;
			this.cmb_TD_Code.Location = new System.Drawing.Point(862, 78);
			this.cmb_TD_Code.MatchEntryTimeout = ((long)(2000));
			this.cmb_TD_Code.MaxDropDownItems = ((short)(5));
			this.cmb_TD_Code.MaxLength = 32767;
			this.cmb_TD_Code.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_TD_Code.Name = "cmb_TD_Code";
			this.cmb_TD_Code.PartialRightColumn = false;
			this.cmb_TD_Code.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
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
			this.cmb_TD_Code.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_TD_Code.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_TD_Code.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_TD_Code.Size = new System.Drawing.Size(122, 21);
			this.cmb_TD_Code.TabIndex = 600;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(760, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 599;
			this.label1.Text = "TD Code";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_D_Day
			// 
			this.dpick_D_Day.CustomFormat = "";
			this.dpick_D_Day.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_D_Day.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_D_Day.Location = new System.Drawing.Point(862, 34);
			this.dpick_D_Day.Name = "dpick_D_Day";
			this.dpick_D_Day.Size = new System.Drawing.Size(122, 22);
			this.dpick_D_Day.TabIndex = 598;
			// 
			// txt_VSM
			// 
			this.txt_VSM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_VSM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_VSM.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_VSM.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_VSM.Location = new System.Drawing.Point(544, 79);
			this.txt_VSM.MaxLength = 20;
			this.txt_VSM.Name = "txt_VSM";
			this.txt_VSM.Size = new System.Drawing.Size(192, 22);
			this.txt_VSM.TabIndex = 597;
			this.txt_VSM.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ImageIndex = 0;
			this.label4.ImageList = this.img_Label;
			this.label4.Location = new System.Drawing.Point(440, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 21);
			this.label4.TabIndex = 596;
			this.label4.Text = "VSM";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Season
			// 
			this.txt_Season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Season.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Season.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Season.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_Season.Location = new System.Drawing.Point(544, 33);
			this.txt_Season.MaxLength = 20;
			this.txt_Season.Name = "txt_Season";
			this.txt_Season.Size = new System.Drawing.Size(72, 22);
			this.txt_Season.TabIndex = 594;
			this.txt_Season.Text = "";
			// 
			// cmb_Style
			// 
			this.cmb_Style.AddItemCols = 0;
			this.cmb_Style.AddItemSeparator = ';';
			this.cmb_Style.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Style.AutoSize = false;
			this.cmb_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Style.Caption = "";
			this.cmb_Style.CaptionHeight = 17;
			this.cmb_Style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Style.ColumnCaptionHeight = 18;
			this.cmb_Style.ColumnFooterHeight = 18;
			this.cmb_Style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Style.ContentHeight = 18;
			this.cmb_Style.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Style.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Style.EditorFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Style.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Style.EditorHeight = 18;
			this.cmb_Style.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Style.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Style.GapHeight = 2;
			this.cmb_Style.ItemHeight = 15;
			this.cmb_Style.Location = new System.Drawing.Point(214, 78);
			this.cmb_Style.MatchEntryTimeout = ((long)(2000));
			this.cmb_Style.MaxDropDownItems = ((short)(5));
			this.cmb_Style.MaxLength = 32767;
			this.cmb_Style.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Style.Name = "cmb_Style";
			this.cmb_Style.PartialRightColumn = false;
			this.cmb_Style.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
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
			this.cmb_Style.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Style.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Style.Size = new System.Drawing.Size(195, 22);
			this.cmb_Style.TabIndex = 593;
			this.cmb_Style.TextChanged += new System.EventHandler(this.cmb_Style_TextChanged);
			this.cmb_Style.SelectedValueChanged += new System.EventHandler(this.cmb_Style_SelectedValueChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(8, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 592;
			this.label3.Text = "Style";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(992, 91);
			this.picb_BR.Name = "picb_BR";
			this.picb_BR.Size = new System.Drawing.Size(13, 15);
			this.picb_BR.TabIndex = 23;
			this.picb_BR.TabStop = false;
			// 
			// cmb_OBS_ID
			// 
			this.cmb_OBS_ID.AddItemCols = 0;
			this.cmb_OBS_ID.AddItemSeparator = ';';
			this.cmb_OBS_ID.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_ID.AutoSize = false;
			this.cmb_OBS_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_ID.Caption = "";
			this.cmb_OBS_ID.CaptionHeight = 17;
			this.cmb_OBS_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_ID.ColumnCaptionHeight = 18;
			this.cmb_OBS_ID.ColumnFooterHeight = 18;
			this.cmb_OBS_ID.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_ID.ContentHeight = 17;
			this.cmb_OBS_ID.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_ID.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OBS_ID.EditorFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OBS_ID.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_ID.EditorHeight = 17;
			this.cmb_OBS_ID.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_OBS_ID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OBS_ID.GapHeight = 2;
			this.cmb_OBS_ID.ItemHeight = 15;
			this.cmb_OBS_ID.Location = new System.Drawing.Point(109, 56);
			this.cmb_OBS_ID.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_ID.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_ID.MaxLength = 32767;
			this.cmb_OBS_ID.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_ID.Name = "cmb_OBS_ID";
			this.cmb_OBS_ID.PartialRightColumn = false;
			this.cmb_OBS_ID.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
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
			this.cmb_OBS_ID.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_ID.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID.Size = new System.Drawing.Size(299, 21);
			this.cmb_OBS_ID.TabIndex = 567;
			this.cmb_OBS_ID.TextChanged += new System.EventHandler(this.cmb_OBS_ID_TextChanged);
			this.cmb_OBS_ID.SelectedValueChanged += new System.EventHandler(this.cmb_OBS_ID_SelectedValueChanged);
			// 
			// lbl_Month
			// 
			this.lbl_Month.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Month.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Month.ImageIndex = 0;
			this.lbl_Month.ImageList = this.img_Label;
			this.lbl_Month.Location = new System.Drawing.Point(440, 34);
			this.lbl_Month.Name = "lbl_Month";
			this.lbl_Month.Size = new System.Drawing.Size(100, 21);
			this.lbl_Month.TabIndex = 160;
			this.lbl_Month.Text = "Season";
			this.lbl_Month.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Acc
			// 
			this.lbl_Acc.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Acc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Acc.ImageIndex = 0;
			this.lbl_Acc.ImageList = this.img_Label;
			this.lbl_Acc.Location = new System.Drawing.Point(440, 56);
			this.lbl_Acc.Name = "lbl_Acc";
			this.lbl_Acc.Size = new System.Drawing.Size(100, 21);
			this.lbl_Acc.TabIndex = 156;
			this.lbl_Acc.Text = "Line";
			this.lbl_Acc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Factory
			// 
			this.cmb_Factory.AddItemCols = 0;
			this.cmb_Factory.AddItemSeparator = ';';
			this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory.AutoSize = false;
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
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(109, 34);
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
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
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
			this.cmb_Factory.Size = new System.Drawing.Size(299, 21);
			this.cmb_Factory.TabIndex = 151;
			this.cmb_Factory.TextChanged += new System.EventHandler(this.cmb_Factory_TextChanged);
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 34);
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
			this.picb_MR.Location = new System.Drawing.Point(905, 30);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(101, 68);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TM
			// 
			this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
			this.picb_TM.Location = new System.Drawing.Point(224, 0);
			this.picb_TM.Name = "picb_TM";
			this.picb_TM.Size = new System.Drawing.Size(771, 28);
			this.picb_TM.TabIndex = 0;
			this.picb_TM.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle1.TabIndex = 28;
			this.lbl_SubTitle1.Text = "      Search Info.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Dep
			// 
			this.lbl_Dep.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Dep.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Dep.ImageIndex = 0;
			this.lbl_Dep.ImageList = this.img_Label;
			this.lbl_Dep.Location = new System.Drawing.Point(8, 56);
			this.lbl_Dep.Name = "lbl_Dep";
			this.lbl_Dep.Size = new System.Drawing.Size(100, 21);
			this.lbl_Dep.TabIndex = 149;
			this.lbl_Dep.Text = "DPO";
			this.lbl_Dep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(990, 0);
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
			this.picb_BM.Location = new System.Drawing.Point(123, 90);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(870, 17);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 91);
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
			this.picb_ML.Size = new System.Drawing.Size(144, 75);
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
			this.pictureBox6.Size = new System.Drawing.Size(904, 68);
			this.pictureBox6.TabIndex = 27;
			this.pictureBox6.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(137, 22);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(86, 22);
			this.textBox1.TabIndex = 145;
			this.textBox1.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ImageIndex = 0;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(392, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 21);
			this.label2.TabIndex = 155;
			this.label2.Text = "Training";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// statusBar1
			// 
			this.statusBar1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.statusBar1.Location = new System.Drawing.Point(0, 120);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1,
																						  this.statusBarPanel2});
			this.statusBar1.Size = new System.Drawing.Size(1020, 488);
			this.statusBar1.TabIndex = 43;
			// 
			// Form_NMI_Register
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_NMI_Register";
			this.Click += new System.EventHandler(this.cmb_Style_SelectedValueChanged);
			this.Load += new System.EventHandler(this.Form_NMI_Register_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_TD_Code)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_NMI_Register_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "New Product Introduction";
			this.Text		   = "NPI";
			fgrid_main.Set_Grid("SIV_NMI_TRACKING", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			_Rowfixed = fgrid_main.Rows.Fixed;
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";

			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

			fgrid_main.Styles.Frozen.BackColor = Color.Lavender; 			
			fgrid_main.KeyActionEnter = KeyActionEnum.MoveAcross;
			fgrid_main.KeyActionTab = KeyActionEnum.MoveAcross;  
			fgrid_main.SelectionMode = SelectionModeEnum.Cell;
			DataTable vDt;
			
			//=========== Set Combobox: Begin =================================

			// factory set
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
			cmb_Factory.SelectedValue    = ClassLib.ComVar.This_Factory;	

			// Line
			vDt = SELECT_LINE_INFO();
			COM.ComCtl.Set_ComboList(vDt, cmb_Line, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Line.SelectedIndex = 0;


			// cmb_TD_code Set
			vDt = Select_TD_Code("");
			COM.ComCtl.Set_ComboList(vDt, cmb_TD_Code, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Name);
			cmb_TD_Code.SelectedIndex = 0;

			//=========== Set Combobox: End =================================

			fgrid_main.Cols[_colFINISH_DATE].Style.Format        = "yyyy-MM-dd";
			fgrid_main.Cols[_colACTUAL_DATE].Style.Format        = "yyyy-MM-dd";

		}

		public DataTable SELECT_LINE_INFO()
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;
			
			try
			{
				string process_name = "PKG_SBM_LLT_PLAN_TRACKING.SELECT_LINE_INFO";

				MyOraDB.ReDim_Parameter(2);  
				MyOraDB.Process_Name = process_name;
   

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR"; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
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
        
		private DataTable Select_TD_Code(string arg_t_name)
		{
			 
			DataSet ds_ret;
			string process_name = "PKG_SCM_CODE.SELECT_COM_FILTER_CODE_LIST";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_COM_CD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


			//03.DATA TYPE 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의   
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
			MyOraDB.Parameter_Values[1] = "CM06";
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}

		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			
		}

		private void setDPO()
		{			
			DataTable dt_ret = Select_DP_DPO_List(cmb_Factory.SelectedValue.ToString(), "2" );
			COM.ComCtl.Set_ComboList(dt_ret, cmb_OBS_ID, 0, 0, true, ClassLib.ComVar.ComboList_Visible.Name); 
			cmb_OBS_ID.SelectedIndex = 0;
		}

		private DataTable Select_DP_DPO_List(string arg_factory, string arg_division)
		{

			try 
			{

				MyOraDB.ReDim_Parameter(3);  

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_SHIPPING_LOCAL.SELECT_SBM_DP_DPO_LIST";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR"; 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_division;
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true);
				DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

				if(DS_Ret == null) return null;
				return DS_Ret.Tables[MyOraDB.Process_Name];

			}
			catch(Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "SELECT_SBM_DP_DPO_LIST", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}


		}

		private void cmb_OBS_ID_SelectedValueChanged(object sender, System.EventArgs e)
		{
			cmb_Style.ClearFields();
			cmb_Style.Text = "";
			txt_StyleCd.Text = "";
			setStyleList();
		}

		private void setStyleList()
		{
			if (cmb_OBS_ID.SelectedIndex == -1)
				return;

			//string[] args = new string[2];
			
			//args[0] = COM.ComFunction.Empty_Combo(cmb_Factory, "");
			//args[1] = COM.ComFunction.Empty_Combo(cmb_OBS_ID, "");
			
//			cmb_Style.ClearFields();
//			cmb_Style.Text = "";
//			txt_StyleCd.Text = "";

			DataTable dt_ret = SELECT_STYLE_LIST_DPDPO();
			if (dt_ret.Rows.Count > 0)
			{
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Style, 0, 1, true, 90, 120);
				//cmb_Style.SelectedIndex = 0;

			}
			dt_ret.Dispose();
		}

		private DataTable SELECT_STYLE_LIST_DPDPO()
		{
			try 
			{
				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(5); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SIV_NMI_TRACKING.SELECT_STYLE_LIST_DPDPO"; 

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_FILTER";
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR"; 
      
				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory, "");
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_OBS_ID, "");
				MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "");
				MyOraDB.Parameter_Values[3] = (chk_Style.Checked == true)? "Y" : "N";
				MyOraDB.Parameter_Values[4] = ""; 

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_STYLE_LIST_DPDPO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}
		}

		private void cmb_Factory_TextChanged(object sender, System.EventArgs e)
		{
			if(cmb_Factory.SelectedIndex == -1) return;
			fgrid_main.ClearAll();
			setDPO();
		}

		private void cmb_OBS_ID_TextChanged(object sender, System.EventArgs e)
		{
			
		}

		private void cmb_Style_SelectedValueChanged(object sender, System.EventArgs e)
		{
//			string tmp_Season;
//			txt_Season.Text = "";
			try
			{
				if (cmb_Style.Text == "")
					return;
				txt_StyleCd.Text = cmb_Style.Columns[0].Text;
				Set_Season_Line_PlanDate();
//				tmp_Season = cmb_Style.Columns[1].Text.Trim();
//				if (tmp_Season.Length  > 20)
//				{
//					txt_Season.Text = tmp_Season.Substring( tmp_Season.Length - 6, 6);
//				}
			}
			catch (Exception ex)
			{
			}
			
		}

		private void Set_Season_Line_PlanDate()
		{
			if (cmb_Style.SelectedIndex == -1)
				return;

			string[] args = new string[3];

			try
			{
				args[0] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
				args[1] = ClassLib.ComFunction.Empty_Combo(cmb_OBS_ID, "");
				args[2] = ClassLib.ComFunction.Empty_Combo(cmb_Style, "").Replace("-", "");

				DataTable dt_ret = this.SELECT_LINE_INFOR(args);
				txt_Season.Text = "";
				cmb_Line.SelectedIndex  = 0;
				if (dt_ret.Rows.Count > 0)
				{
					cmb_Line.SelectedValue  = dt_ret.Rows[0].ItemArray[0].ToString();
					txt_Season.Text         = dt_ret.Rows[0].ItemArray[2].ToString();
					dpick_D_Day.Text        = Convert.ToDateTime(dt_ret.Rows[0].ItemArray[3]).ToString("yyyy-MM-dd");
					txt_Category.Text       = dt_ret.Rows[0].ItemArray[4].ToString();
					dpick_FSR.Value         = dpick_D_Day.Value;
				}
				dt_ret.Dispose();
			}
			catch (Exception Ex)
			{
			}
		}

		private DataTable SELECT_LINE_INFOR(string[] arg_parameter)
		{
			try 
			{
				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(4); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SIV_NMI_TRACKING.SELECT_LINE_INFOR"; 

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR"; 
      
				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_parameter[2];
				MyOraDB.Parameter_Values[3] = ""; 

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_LINE_INFOR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				if (txt_StyleCd.Text.Trim() == "")
				{
					return;
				}
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SIV_NMI_TRACKING.SELECT_NMI_TRACKING";

				DataTable vDt = SELECT_NMI_TRACKING(vProcedure);

				Clear_FlexGrid();
				if (vDt.Rows.Count > 0)
				{
					//fgrid_main.Tree.Column = _colT_LEVEL; 

					Display_FlexGrid(vDt);

					SET_GRID_COLOR();

					//GridSetColor();
					for (int iRow = _Rowfixed; iRow <= fgrid_main.Rows.Count-1; iRow ++)
					{
						if (fgrid_main[iRow, _colSTYLE_CD].ToString()=="-")
						{
							fgrid_main[iRow, 0] = "I";
						}
					}

					if (vDt.Rows[0].ItemArray[04].ToString()!="")
					{
						cmb_Line.SelectedValue = vDt.Rows[0].ItemArray[04];
					    //txt_Season.Text = vDt.Rows[0].ItemArray[11].ToString();
						dpick_FSR.Value = Convert.ToDateTime(vDt.Rows[0].ItemArray[13]);
						dpick_D_Day.Value = Convert.ToDateTime(vDt.Rows[0].ItemArray[14]);
					}
					cmb_TD_Code.SelectedValue = vDt.Rows[0].ItemArray[12];
					txt_VSM.Text = vDt.Rows[0].ItemArray[25].ToString();

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

		private void SET_GRID_COLOR()
		{
			
			for (int iRow = _Rowfixed; iRow < fgrid_main.Rows.Count; iRow++)
			{
				if ( Convert.ToInt16(fgrid_main[iRow, _colBALANCE].ToString()) >= 3)
					fgrid_main.GetCellRange(iRow, _colACTUAL_DATE, iRow, _colACTUAL_DATE).StyleNew.BackColor = Color.Red;
				else if (Convert.ToInt16 (fgrid_main[iRow, _colBALANCE].ToString()) == 2)
					fgrid_main.GetCellRange(iRow, _colACTUAL_DATE, iRow, _colACTUAL_DATE).StyleNew.BackColor = Color.Yellow;
				else if ((Convert.ToInt16(fgrid_main[iRow, _colBALANCE].ToString()) <=1 ) &&
					     (Convert.ToInt16(fgrid_main[iRow, _colBALANCE].ToString()) >= -10))
					fgrid_main.GetCellRange(iRow, _colACTUAL_DATE, iRow, _colACTUAL_DATE).StyleNew.BackColor = Color.LightGreen;
				}
		}

		public DataTable SELECT_NMI_TRACKING(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[ 2]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[ 3]  = "ARG_LINE_CD";
			MyOraDB.Parameter_Name[ 4]  = "ARG_D_DATE";
			MyOraDB.Parameter_Name[ 5]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 5]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
			MyOraDB.Parameter_Values[ 1]   = ClassLib.ComFunction.Empty_Combo(cmb_OBS_ID, "");
			MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_Combo(cmb_Style, "");
			MyOraDB.Parameter_Values[ 3]   = ClassLib.ComFunction.Empty_Combo(cmb_Line, "");
			MyOraDB.Parameter_Values[ 4]   = dpick_D_Day.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[ 5]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

							   
		private void Clear_FlexGrid()
		{
			if (_Rowfixed != fgrid_main.Rows.Count)
			{				
				fgrid_main.Clear(ClearFlags.UserData, _Rowfixed, 1, fgrid_main.Rows.Count - 1, fgrid_main.Cols.Count - 1);

				fgrid_main.Rows.Count = _Rowfixed;
			}
		}

		private void Display_FlexGrid(DataTable arg_dt)
		{
			int iCount = arg_dt.Rows.Count;

			try
			{
				for (int iRow = 0 ; iRow < iCount ; iRow++)
				{				
					C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(_Rowfixed + iRow, 1);

					fgrid_main[newRow.Row.Index, 0] = "";

					for (int iCol = 1 ; iCol <= arg_dt.Columns.Count ; iCol++)
						fgrid_main[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
				}

//				cmb_Line.SelectedValue = arg_dt.Rows[0].ItemArray[04];
//				txt_Season.Text = arg_dt.Rows[0].ItemArray[11].ToString();
//				cmb_TD_Code.SelectedValue = arg_dt.Rows[0].ItemArray[12];
//				dpick_FSR.Value = Convert.ToDateTime(arg_dt.Rows[0].ItemArray[13]);
//				dpick_D_Day.Value = Convert.ToDateTime(arg_dt.Rows[0].ItemArray[14]);
			}
			catch {}

		}

		private void fgrid_main_KeyPressEdit(object sender, C1.Win.C1FlexGrid.KeyPressEditEventArgs e)
		{
			int iRow = fgrid_main.Selection.r1;
			int iCol = fgrid_main.Selection.c1;			

			//if (fgrid_main.Cols[iCol].DataType.Equals(typeof(DateTime)))				
			if (iCol == _colACTUAL_DATE)
			{
				if (e.KeyChar == 8)
				{
					fgrid_main.Col = iCol+1;
					fgrid_main[iRow, iCol] = null;
				}
			}		
		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();
		}

		private void Grid_AfterEditProcess()
		{
			fgrid_main.Update_Row();
		}

		private void fgrid_main_DoubleClick(object sender, System.EventArgs e)
		{
//			int    iRow   = fgrid_main.Selection.r1;
//			int    iCol   = fgrid_main.Selection.c1;
//
//			if (iCol == _colPIC1)
//			{
//				if (fgrid_main.Cols[_colPIC2].Width > 0)
//				{
//					fgrid_main.Cols[_colPIC2].Width = 0;
//				}
//				else
//				{
//					fgrid_main.Cols[_colPIC2].Width = 120;
//				}
//			}
//			else if (iCol == _colPIC2)
//			{
//				if (fgrid_main.Cols[_colPIC3].Width > 0)
//				{
//					fgrid_main.Cols[_colPIC3].Width = 0;
//				}
//				else
//				{
//					fgrid_main.Cols[_colPIC3].Width = 120;
//				}
//			}
//			if (iCol == _colPIC3)
//			{
//				if (fgrid_main.Cols[_colPIC4].Width > 0)
//				{
//					fgrid_main.Cols[_colPIC4].Width = 0;
//				}
//				else
//				{
//					fgrid_main.Cols[_colPIC4].Width = 120;
//				}
//			}

		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Validate_Check())
			{
				if(ClassLib.ComFunction.User_Message("Do you want to save the changes you made?","Save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
				{
					this.Tbtn_SaveProcess();					
				}
			}		
		}

		private bool Validate_Check()
		{
			bool b = true;
//			for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
//			{
//				if ((fgrid_main[iRow, _colT_NAME].ToString()  == "") ||
//					(fgrid_main[iRow, _colGRP_CODE].ToString()     == "") ||
//					(fgrid_main[iRow, _colWAVE].ToString()         == "") ||
//					(fgrid_main[iRow, _colLOCATION_DIV ].ToString()== ""))
//				{
//					b = false;
//					break;
//				}
//
//				if ((fgrid_main[iRow, _colT_CODE].ToString().Replace(" ", "").Trim().Length == 0) )
//				{
//					fgrid_main[iRow, 0] = "";					
//				}
//			}			
//
			return b;
		}

		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_SIV_NMI_TRACKING(true))
				{
					fgrid_main.Refresh_Division();
					this.Tbtn_SearchProcess();
					MessageBox.Show("Save Completed","Create", MessageBoxButtons.OK ,MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		public bool SAVE_SIV_NMI_TRACKING(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 19;

				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SIV_NMI_TRACKING.SAVE_SIV_NMI_TRACKING";

                // FACTORY, OBS_ID, STYLE_CD, LINE_CD, CHECK_ITEM, 
				// SEASON, TD_CODE, FSR_DATE, D_DATE, FINISH_DATE, 
	            // ACTUAL_DATE, PIC1, PIC2, PIC3, PIC4, REMARK1, REMARK2, REMARK3, UPD_USER, UPD_YMD

				//02.ARGURMENT NAME
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 2] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[ 3] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[ 4] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[ 5] = "ARG_CHECK_ITEM";
				MyOraDB.Parameter_Name[ 6] = "ARG_SEASON";
				MyOraDB.Parameter_Name[ 7] = "ARG_TD_CODE";
				MyOraDB.Parameter_Name[ 8] = "ARG_FSR_DATE";
				MyOraDB.Parameter_Name[ 9] = "ARG_D_DATE";
				MyOraDB.Parameter_Name[ 10] = "ARG_FINISH_DATE";
				MyOraDB.Parameter_Name[ 11] = "ARG_ACTUAL_DATE";
				MyOraDB.Parameter_Name[ 12] = "ARG_PIC1";
				MyOraDB.Parameter_Name[ 13] = "ARG_PIC2";
				MyOraDB.Parameter_Name[ 14] = "ARG_PIC3";
				MyOraDB.Parameter_Name[ 15] = "ARG_PIC4";
				MyOraDB.Parameter_Name[ 16] = "ARG_REMARK";
				MyOraDB.Parameter_Name[ 17] = "ARG_UPD_USER";
				MyOraDB.Parameter_Name[ 18] = "ARG_VSM";
				

				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
						save_ct += 1;
				
				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

				// FACTORY, OBS_ID, STYLE_CD, LINE_CD, CHECK_ITEM, 
				// SEASON, TD_CODE, FSR_DATE, D_DATE, FINISH_DATE, 
				// ACTUAL_DATE, PIC1, PIC2, PIC3, PIC4, REMARK1, REMARK2, REMARK3, UPD_USER, UPD_YMD

				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if(fgrid_main[iRow, 0].ToString() != "")
					{
						MyOraDB.Parameter_Values[para_ct+ 0 ]  = fgrid_main[iRow, 0].ToString();
						MyOraDB.Parameter_Values[para_ct+ 1 ]  = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
						//MyOraDB.Parameter_Values[para_ct+ 2 ] = fgrid_main[iRow, _colOBS_ID].ToString();
						MyOraDB.Parameter_Values[para_ct+ 2 ]  = ClassLib.ComFunction.Empty_Combo(cmb_OBS_ID, "");
						MyOraDB.Parameter_Values[para_ct+ 3 ]  = ClassLib.ComFunction.Empty_Combo(cmb_Style, "").Replace("-", "");;
						MyOraDB.Parameter_Values[para_ct+ 4 ]  = ClassLib.ComFunction.Empty_Combo(cmb_Line, "");
						MyOraDB.Parameter_Values[para_ct+ 5 ]  = fgrid_main[iRow, _colCHECK_ITEM].ToString();
						MyOraDB.Parameter_Values[para_ct+ 6 ]  = ClassLib.ComFunction.Empty_TextBox(txt_Season, "");
						MyOraDB.Parameter_Values[para_ct+ 7 ]  = ClassLib.ComFunction.Empty_Combo(cmb_TD_Code, "");
						MyOraDB.Parameter_Values[para_ct+ 8 ]  = dpick_FSR.Value.ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+ 9 ]  = dpick_D_Day.Value.ToString("yyyyMMdd");
						//(fgrid_main[iRow, _colD_DATE] == null) ? "________" : Convert.ToDateTime(fgrid_main[iRow, _colD_DATE]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+ 10 ] = (fgrid_main[iRow, _colFINISH_DATE] == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colFINISH_DATE]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+ 11]  = (fgrid_main[iRow, _colACTUAL_DATE] == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colACTUAL_DATE]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+ 12]  = fgrid_main[iRow, _colPIC1].ToString();
						MyOraDB.Parameter_Values[para_ct+ 13]  = fgrid_main[iRow, _colPIC2].ToString();
						MyOraDB.Parameter_Values[para_ct+ 14]  = fgrid_main[iRow, _colPIC3].ToString();
						MyOraDB.Parameter_Values[para_ct+ 15]  = fgrid_main[iRow, _colPIC4].ToString();
						MyOraDB.Parameter_Values[para_ct+ 16]  = fgrid_main[iRow, _colREMARK].ToString();
						MyOraDB.Parameter_Values[para_ct+ 17]  = COM.ComVar.This_User;
						MyOraDB.Parameter_Values[para_ct+ 18]  = ClassLib.ComFunction.Empty_TextBox(txt_VSM, "");
						
						para_ct += iCount;	
					}				
				}

				MyOraDB.Add_Modify_Parameter(true);		
				
				if (doExecute)
				{
					if (MyOraDB.Exe_Modify_Procedure() == null)
						return false;
					else
						return true;
				}

				return true;

			}
			catch
			{
				return false;
			}
		}

		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
			int iRow = fgrid_main.Selection.r1 ;
			
			try
			{
				if (fgrid_main[_Rowfixed, _colCHECK_USER].ToString ()== "Y")
				{
					Check_User_Right();
				}
				cmb_TD_Code.SelectedValue = fgrid_main[iRow, _colTD_CODE].ToString ();
				dpick_FSR.Value  = Convert.ToDateTime(fgrid_main[iRow, _colFSR_DATE].ToString());
			}
			catch (Exception Ex)
			{
			}

		}

		private void Check_User_Right()
		{
			int    iRow   = fgrid_main.Selection.r1;
		    int    iCol   = fgrid_main.Selection.c1;
			int    iCnt   = 2;
			string sUser = COM.ComVar.This_User;
			string [] update_user = {fgrid_main[iRow, _colPIC1].ToString().ToUpper(), 
								     fgrid_main[iRow, _colPIC2].ToString().ToUpper(),
								     fgrid_main[iRow, _colPIC3].ToString().ToUpper(),
									 fgrid_main[iRow, _colPIC4].ToString().ToUpper()};
			
			string sValues = fgrid_main[iRow, _colADMIN_USER].ToString();
			char[] delimiters = new char[] { ';' };
			string [] sAdmin = sValues.Split(delimiters, 3);
			try
			{

				fgrid_main.Rows[iRow].AllowEditing = false;
				if ((sUser.ToUpper() == sAdmin[0])||(sUser.ToUpper() == sAdmin[1]) ||(sUser.ToUpper() == sAdmin[2]))
				{
					fgrid_main.Rows[iRow].AllowEditing = true;
				}
				else if ( (sUser.ToUpper()== update_user[0])|| (sUser.ToUpper()== update_user[1]) ||(sUser.ToUpper()== update_user[2])||(sUser.ToUpper()== update_user[3]) )
				{
					if (iCol == _colACTUAL_DATE)
				
					{
						fgrid_main.Rows[iRow].AllowEditing = true;
					}
				}

				if (iCol == _colREMARK)
				{
					fgrid_main.Rows[iRow].AllowEditing = true;
				}
			}
			catch
			{
			}
		}

		private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;
				setStyleList();
				cmb_Style.SelectedValue = txt_StyleCd.Text.Trim();
			}
			catch{}


		}

		private void cmb_Style_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

		private void txt_StyleCd_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}

