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
	public class Form_SIV_TCM_Register : COM.TrainingWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
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
		private C1.Win.C1List.C1Combo cmb_Dep;
		private C1.Win.C1List.C1Combo cmb_Acc;
		private System.Windows.Forms.Label lbl_Month;
		private System.Windows.Forms.Label lbl_Acc;
		private System.Windows.Forms.Label lbl_Dep;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo cmbMonth;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.Label btnClosing;
		private System.Windows.Forms.TextBox txtStatus;
		private System.ComponentModel.IContainer components = null;

		public Form_SIV_TCM_Register()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		#region User Define Variable

		private COM.OraDB MyOraDB  = new COM.OraDB();
		private int _Rowfixed;

		private int _colT_LEVEL           = (int) ClassLib.TBSIV_TCM_REGISTER.IxT_LEVEL;	
		private int _colFACTORY           = (int) ClassLib.TBSIV_TCM_REGISTER.IxFACTORY;	
		private int _colACC_MONTH         = (int) ClassLib.TBSIV_TCM_REGISTER.IxACC_MONTH;	
		private int _colORG_CD            = (int) ClassLib.TBSIV_TCM_REGISTER.IxORD_CD;	
		private int _colACC_CD            = (int) ClassLib.TBSIV_TCM_REGISTER.IxACC_CD;	
		private int _colTOTAL		      = (int) ClassLib.TBSIV_TCM_REGISTER.IxTOTAL;
		private int _colVALUE_DIV	      = (int) ClassLib.TBSIV_TCM_REGISTER.IxVALUE_DIV;
		private int _colSUB_FACTORY	      = (int) ClassLib.TBSIV_TCM_REGISTER.IxSUB_FACTORY;
		private int _colSUB_FACTORY_NAME  = (int) ClassLib.TBSIV_TCM_REGISTER.IxSUB_FACTORY_NAME;

		
      
		#endregion
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

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_SIV_TCM_Register));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cmbMonth = new C1.Win.C1List.C1Combo();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmb_Acc = new C1.Win.C1List.C1Combo();
			this.cmb_Dep = new C1.Win.C1List.C1Combo();
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
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
			this.btnClosing = new System.Windows.Forms.Label();
			this.txtStatus = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbMonth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Acc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Dep)).BeginInit();
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
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// tbtn_Create
			// 
			this.tbtn_Create.Enabled = false;
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// tbtn_Confirm
			// 
			this.tbtn_Confirm.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Confirm_Click);
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
			this.c1Sizer1.GridDefinition = "16.4473684210526:False:True;79.1118421052632:False:False;0.822368421052632:False:" +
				"True;3.61842105263158:False:True;\t0.784313725490196:False:True;98.1372549019608:" +
				"False:False;1.07843137254902:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1020, 608);
			this.c1Sizer1.SplitterWidth = 0;
			this.c1Sizer1.TabIndex = 32;
			this.c1Sizer1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.fgrid_main);
			this.panel2.Location = new System.Drawing.Point(8, 100);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1001, 481);
			this.panel2.TabIndex = 46;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main.ContextMenu = this.contextMenu1;
			this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Size = new System.Drawing.Size(1001, 481);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 34;
			this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
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
			this.pnl_Search.Size = new System.Drawing.Size(1020, 100);
			this.pnl_Search.TabIndex = 45;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Window;
			this.panel3.Controls.Add(this.txtStatus);
			this.panel3.Controls.Add(this.btnClosing);
			this.panel3.Controls.Add(this.cmbMonth);
			this.panel3.Controls.Add(this.picb_BR);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.cmb_Acc);
			this.panel3.Controls.Add(this.cmb_Dep);
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
			this.panel3.Size = new System.Drawing.Size(1006, 86);
			this.panel3.TabIndex = 18;
			// 
			// cmbMonth
			// 
			this.cmbMonth.AddItemCols = 0;
			this.cmbMonth.AddItemSeparator = ';';
			this.cmbMonth.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmbMonth.AutoSize = false;
			this.cmbMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbMonth.Caption = "";
			this.cmbMonth.CaptionHeight = 17;
			this.cmbMonth.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbMonth.ColumnCaptionHeight = 18;
			this.cmbMonth.ColumnFooterHeight = 18;
			this.cmbMonth.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbMonth.ContentHeight = 17;
			this.cmbMonth.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbMonth.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbMonth.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbMonth.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbMonth.EditorHeight = 17;
			this.cmbMonth.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmbMonth.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbMonth.GapHeight = 2;
			this.cmbMonth.ItemHeight = 15;
			this.cmbMonth.Location = new System.Drawing.Point(549, 34);
			this.cmbMonth.MatchEntryTimeout = ((long)(2000));
			this.cmbMonth.MaxDropDownItems = ((short)(5));
			this.cmbMonth.MaxLength = 32767;
			this.cmbMonth.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbMonth.Name = "cmbMonth";
			this.cmbMonth.PartialRightColumn = false;
			this.cmbMonth.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmbMonth.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbMonth.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbMonth.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbMonth.Size = new System.Drawing.Size(200, 21);
			this.cmbMonth.TabIndex = 589;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(992, 71);
			this.picb_BR.Name = "picb_BR";
			this.picb_BR.Size = new System.Drawing.Size(13, 15);
			this.picb_BR.TabIndex = 23;
			this.picb_BR.TabStop = false;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(877, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 16);
			this.label1.TabIndex = 588;
			this.label1.Text = "(Currency : USD)";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmb_Acc
			// 
			this.cmb_Acc.AddItemCols = 0;
			this.cmb_Acc.AddItemSeparator = ';';
			this.cmb_Acc.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Acc.AutoSize = false;
			this.cmb_Acc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Acc.Caption = "";
			this.cmb_Acc.CaptionHeight = 17;
			this.cmb_Acc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Acc.ColumnCaptionHeight = 18;
			this.cmb_Acc.ColumnFooterHeight = 18;
			this.cmb_Acc.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Acc.ContentHeight = 17;
			this.cmb_Acc.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Acc.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Acc.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Acc.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Acc.EditorHeight = 17;
			this.cmb_Acc.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Acc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Acc.GapHeight = 2;
			this.cmb_Acc.ItemHeight = 15;
			this.cmb_Acc.Location = new System.Drawing.Point(549, 56);
			this.cmb_Acc.MatchEntryTimeout = ((long)(2000));
			this.cmb_Acc.MaxDropDownItems = ((short)(5));
			this.cmb_Acc.MaxLength = 32767;
			this.cmb_Acc.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Acc.Name = "cmb_Acc";
			this.cmb_Acc.PartialRightColumn = false;
			this.cmb_Acc.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Acc.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Acc.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Acc.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Acc.Size = new System.Drawing.Size(200, 21);
			this.cmb_Acc.TabIndex = 587;
			// 
			// cmb_Dep
			// 
			this.cmb_Dep.AddItemCols = 0;
			this.cmb_Dep.AddItemSeparator = ';';
			this.cmb_Dep.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Dep.AutoSize = false;
			this.cmb_Dep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Dep.Caption = "";
			this.cmb_Dep.CaptionHeight = 17;
			this.cmb_Dep.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Dep.ColumnCaptionHeight = 18;
			this.cmb_Dep.ColumnFooterHeight = 18;
			this.cmb_Dep.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Dep.ContentHeight = 17;
			this.cmb_Dep.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Dep.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Dep.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Dep.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Dep.EditorHeight = 17;
			this.cmb_Dep.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Dep.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Dep.GapHeight = 2;
			this.cmb_Dep.ItemHeight = 15;
			this.cmb_Dep.Location = new System.Drawing.Point(109, 56);
			this.cmb_Dep.MatchEntryTimeout = ((long)(2000));
			this.cmb_Dep.MaxDropDownItems = ((short)(5));
			this.cmb_Dep.MaxLength = 32767;
			this.cmb_Dep.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Dep.Name = "cmb_Dep";
			this.cmb_Dep.PartialRightColumn = false;
			this.cmb_Dep.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Dep.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Dep.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Dep.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Dep.Size = new System.Drawing.Size(200, 21);
			this.cmb_Dep.TabIndex = 567;
			// 
			// lbl_Month
			// 
			this.lbl_Month.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Month.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Month.ImageIndex = 0;
			this.lbl_Month.ImageList = this.img_Label;
			this.lbl_Month.Location = new System.Drawing.Point(448, 34);
			this.lbl_Month.Name = "lbl_Month";
			this.lbl_Month.Size = new System.Drawing.Size(100, 21);
			this.lbl_Month.TabIndex = 160;
			this.lbl_Month.Text = "Month";
			this.lbl_Month.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Acc
			// 
			this.lbl_Acc.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Acc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Acc.ImageIndex = 0;
			this.lbl_Acc.ImageList = this.img_Label;
			this.lbl_Acc.Location = new System.Drawing.Point(448, 56);
			this.lbl_Acc.Name = "lbl_Acc";
			this.lbl_Acc.Size = new System.Drawing.Size(100, 21);
			this.lbl_Acc.TabIndex = 156;
			this.lbl_Acc.Text = "Account";
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
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.cmb_Factory.Size = new System.Drawing.Size(200, 21);
			this.cmb_Factory.TabIndex = 151;
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
			this.picb_MR.Size = new System.Drawing.Size(101, 48);
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
			this.lbl_SubTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.lbl_Dep.Text = "Department";
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
			this.picb_BM.Location = new System.Drawing.Point(123, 70);
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
			this.picb_BL.Location = new System.Drawing.Point(0, 71);
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
			this.picb_ML.Size = new System.Drawing.Size(144, 55);
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
			this.pictureBox6.Size = new System.Drawing.Size(904, 48);
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
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.statusBar1.Location = new System.Drawing.Point(0, 100);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1,
																						  this.statusBarPanel2});
			this.statusBar1.Size = new System.Drawing.Size(1020, 508);
			this.statusBar1.TabIndex = 43;
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem3,
																						 this.menuItem5});
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Text = "Closing";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "Cancel Closing";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// img_LongButton
			// 
			this.img_LongButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_LongButton.ImageSize = new System.Drawing.Size(100, 23);
			this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
			this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btnClosing
			// 
			this.btnClosing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClosing.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btnClosing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btnClosing.ImageIndex = 0;
			this.btnClosing.ImageList = this.img_LongButton;
			this.btnClosing.Location = new System.Drawing.Point(800, 32);
			this.btnClosing.Name = "btnClosing";
			this.btnClosing.TabIndex = 590;
			this.btnClosing.Text = "Plan Closing";
			this.btnClosing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnClosing.Click += new System.EventHandler(this.btnClosing_Click);
			// 
			// txtStatus
			// 
			this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.txtStatus.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtStatus.Location = new System.Drawing.Point(901, 33);
			this.txtStatus.MaxLength = 20;
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(77, 21);
			this.txtStatus.TabIndex = 591;
			this.txtStatus.Text = "";
			// 
			// Form_SIV_TCM_Register
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_SIV_TCM_Register";
			this.Load += new System.EventHandler(this.Form_SIV_TCM_Manage_Load);
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
			((System.ComponentModel.ISupportInitialize)(this.cmbMonth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Acc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Dep)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_SIV_TCM_Manage_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{						
			DateTime CurDate = DateTime.Now;

			// Form Setting
			lbl_MainTitle.Text = "Daily TCM Register";
			this.Text		   = "TCM Management";

			// grid set
			fgrid_main.Set_Grid("SIV_TCM_MANAGE", "2", 3, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			_Rowfixed = fgrid_main.Rows.Fixed;
			fgrid_main[_Rowfixed-3, 0] = " ";
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";

			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

			fgrid_main.Styles.Frozen.BackColor = Color.Lavender; 			
			fgrid_main.KeyActionEnter = KeyActionEnum.MoveAcross;
			fgrid_main.KeyActionTab = KeyActionEnum.MoveAcross;  

			//fgrid_main.SelectionMode = SelectionModeEnum.Cell;

			fgrid_main.SelectionMode = SelectionModeEnum.Column;

			DataTable vDt;
				
			// factory set
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
			cmb_Factory.SelectedValue    = ClassLib.ComVar.This_Factory;


			// cmb DEP set
			vDt = Select_Dep("SIV01");
			COM.ComCtl.Set_ComboList(vDt, cmb_Dep , 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);


			// cmb DEP set
			vDt = Select_Acc("SIV02");
			COM.ComCtl.Set_ComboList(vDt, cmb_Acc , 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);


			vDt = SELECT_WORK_MONTH();
			
			cmbMonth.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
			cmbMonth.ClearItems();
			cmbMonth.ExtendRightColumn = true;
			cmbMonth.ColumnHeaders = false;

			cmbMonth.AddItem( CurDate.AddMonths(1).ToString("yyyy-MM") );
			
			for(int iRow = 0; iRow < vDt.Rows.Count; iRow++)
				if (CurDate.AddMonths(1).ToString("yyyy-MM") != vDt.Rows[iRow].ItemArray[0].ToString())
				    cmbMonth.AddItem( vDt.Rows[iRow].ItemArray[0].ToString() );
			
		}

		public DataTable SELECT_WORK_MONTH()
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = "PKG_SIV_TCM_MANAGE.SELECT_WORK_MONTH";

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
			MyOraDB.Parameter_Values[ 1]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}


		private DataTable Select_Dep(string com_cd)
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;
			
			try
			{
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
				MyOraDB.Parameter_Values[1] = com_cd;
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

		private DataTable Select_Acc(string com_cd)
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;
			
			try
			{
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
				MyOraDB.Parameter_Values[1] = com_cd;
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

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			this.btn_Apply_Process();
		}

		private void btn_Apply_Process()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (GET_SIV_TCM_MANAGE_DATE(true))
				{
					fgrid_main.Refresh_Division();
					this.Tbtn_SearchProcess();
					MessageBox.Show("Apply Completed","Create", MessageBoxButtons.OK ,MessageBoxIcon.Information);
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

		public bool GET_SIV_TCM_MANAGE_DATE(bool doExecute)
		{
			try
			{
				int iCount  = 5;

				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SIV_TCM_MANAGE.GET_SIV_TCM_MANAGE_DATA";

				//02.ARGURMENT NAME
				MyOraDB.Parameter_Name[ 0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 1] = "ARG_ACC_DATE";
				MyOraDB.Parameter_Name[ 2] = "ARG_ORG_CD";
				MyOraDB.Parameter_Name[ 3] = "ARG_ACC_CD";
				MyOraDB.Parameter_Name[ 4] = "ARG_UPD_USER";

				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
				MyOraDB.Parameter_Values[ 1]   = cmbMonth.ToString().Substring(1,4)+cmbMonth.ToString().Substring(5,2);
				MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_Combo(cmb_Dep, "");
				MyOraDB.Parameter_Values[ 3]   = ClassLib.ComFunction.Empty_Combo(cmb_Acc, "");
				MyOraDB.Parameter_Values[ 4]   = COM.ComVar.This_User;

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

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SIV_TCM_MANAGE.SELECT_SIV_TCM_REGISTER";

				DataTable vDt = SELECT_SIV_TCM_REGISTER(vProcedure);

				Clear_FlexGrid();
				if (vDt.Rows.Count > 0)
				{
					fgrid_main.Tree.Column = _colT_LEVEL; 

					Display_FlexGrid(vDt);

					GridSetColor();

					for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
					{				
						if (fgrid_main[iRow, _colVALUE_DIV].ToString() == "Actual")	
						{
							for (int iCol=_colTOTAL; iCol<fgrid_main.Cols.Count; iCol++)
								if (fgrid_main[1, iCol].ToString() != "Sun")
									UPDATE_BALANCE(iRow, iCol);
						}
					}


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
			int iLevel = 0;

			if ( arg_dt.Columns.Count > 12 )
			{
				fgrid_main.Cols.Count = 13; 

				fgrid_main.Cols[11].Format = "#,##0";

				for (int iCol = 12; iCol < arg_dt.Columns.Count ; iCol++)
				{
					if (arg_dt.Rows[0].ItemArray[iCol].ToString() != "F") 
					{
						fgrid_main.Cols.Count += 1;

						fgrid_main.Cols[iCol+1].Style = fgrid_main.Styles["TEXT"];				
						fgrid_main.Cols[iCol+1].Style = fgrid_main.Styles["RIGHT"]; 
						fgrid_main.Cols[iCol+1].DataType = typeof(int);
						fgrid_main.Cols[iCol+1].Format = "#,##0";
						fgrid_main.Cols[iCol+1].Width = 65;

						fgrid_main[1, iCol+1] = arg_dt.Rows[0].ItemArray[iCol].ToString();
						fgrid_main[2, iCol+1] = iCol-11;
						
					}
				}

			}


			for (int iRow = 0 ; iRow < iCount-1 ; iRow++)
			{				
				iLevel = Convert.ToInt32(arg_dt.Rows[iRow+1].ItemArray[_colT_LEVEL-1].ToString() );
				C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(_Rowfixed + iRow, iLevel);

				for (int iCol = 0 ; iCol < arg_dt.Columns.Count ; iCol++)	
					if (iCol+1 < fgrid_main.Cols.Count )
					{
						if (fgrid_main[1, iCol+1].ToString() == "Sun")
						{
							fgrid_main[newRow.Row.Index, iCol+1] = "";
							fgrid_main.Cols[iCol+1].AllowEditing = false;							
						}
						else
						{
							fgrid_main[newRow.Row.Index, iCol+1] = arg_dt.Rows[iRow+1].ItemArray[iCol];
						}
					}
			
				fgrid_main.Tree.Column = _colVALUE_DIV;
			}

			fgrid_main.Tree.Show(2); 

		}

		private void GridSetColor()
		{
			try
			{				
				string sLevel = "";
				CellRange vRange_1;
				CellRange vRange_2;
				CellRange vRange_3;


				for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{				
					sLevel      = fgrid_main[iRow, _colT_LEVEL].ToString();
					vRange_1    = fgrid_main.GetCellRange(iRow, 1, iRow, _colTOTAL);				
					vRange_2    = fgrid_main.GetCellRange(iRow, 1, iRow, fgrid_main.Cols.Count-1);	
					vRange_3    = fgrid_main.GetCellRange(iRow, _colTOTAL, iRow, _colTOTAL);	

					if (sLevel.Equals("1"))
					{
						vRange_2.StyleNew.BackColor = Color.SeaShell;

						if (fgrid_main[iRow, _colSUB_FACTORY].ToString() == "TOTAL")
							vRange_2.StyleNew.BackColor = Color.Lavender;

						fgrid_main.Rows[iRow].AllowEditing = false;		
					}
					if (sLevel.Equals("2"))
					{
						fgrid_main.GetCellRange(iRow, _colSUB_FACTORY_NAME).StyleNew.BackColor = Color.White;
						fgrid_main.GetCellRange(iRow, _colVALUE_DIV).StyleNew.BackColor = Color.White;
						fgrid_main.GetCellRange(iRow, _colTOTAL).StyleNew.BackColor = Color.White;

						for (int iCol=_colTOTAL+1; iCol<fgrid_main.Cols.Count; iCol++)
						{

							if (fgrid_main[1, iCol].ToString() == "Sun")
								fgrid_main.GetCellRange(iRow, iCol).StyleNew.BackColor = Color.WhiteSmoke;
							else
								fgrid_main.GetCellRange(iRow, iCol).StyleNew.BackColor = Color.White;

						}

						if (fgrid_main[iRow, _colSUB_FACTORY].ToString() == "TOTAL")
							fgrid_main.Rows[iRow].AllowEditing = false;	
						else if (fgrid_main[iRow, _colVALUE_DIV].ToString() == "Balance")
							fgrid_main.Rows[iRow].AllowEditing = false;	

					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "GridSetColor", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}				
		}

		public DataTable SELECT_SIV_TCM_REGISTER(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1] = "ARG_ACC_MONTH";
			MyOraDB.Parameter_Name[ 2] = "ARG_ORG_CD";
			MyOraDB.Parameter_Name[ 3] = "ARG_ACC_CD";
			MyOraDB.Parameter_Name[ 4] = "ARG_UPD_USER";
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
			MyOraDB.Parameter_Values[ 1]   = cmbMonth.Text.Substring(0,4)+cmbMonth.Text.Substring(5,2);
			MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_Combo(cmb_Dep, "");
			MyOraDB.Parameter_Values[ 3]   = ClassLib.ComFunction.Empty_Combo(cmb_Acc, "");
			MyOraDB.Parameter_Values[ 4]   = ClassLib.ComVar.This_User;
			MyOraDB.Parameter_Values[ 5]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
		
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			
			if (Validate_Check())
			{
				if(ClassLib.ComFunction.User_Message("Do you want to save?","Save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
				{
					this.Tbtn_SaveProcess();					
				}
			}	
		
		}

		private bool Validate_Check()
		{
			//			for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
			//			{
			//				if ((fgrid_main[iRow, _colEMP_NO].ToString().Replace(" ", "").Trim().Length == 0) )
			//				{
			//					fgrid_main[iRow, 0] = "";					
			//				}
			//			}			

			return true;
		}

		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_SIV_TCM_REGISTER(true))
				{
					fgrid_main.Refresh_Division();

					for(int i = fgrid_main.Cols.Count - 1; i >= fgrid_main.Rows.Fixed; i--)
					{
						if(fgrid_main[0, i] == null || fgrid_main[0, i].ToString() == "") continue;

						fgrid_main[i, 0] = "";
					}

				
					//this.Tbtn_SearchProcess();
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

		public bool SAVE_SIV_TCM_REGISTER(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 8;

				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SIV_TCM_MANAGE.SAVE_SIV_TCM_REGISTER";

				//02.ARGURMENT NAME
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[ 2] = "ARG_ACC_DATE"; 
				MyOraDB.Parameter_Name[ 3] = "ARG_ORG_CD"; 
				MyOraDB.Parameter_Name[ 4] = "ARG_ACC_CD"; 
				MyOraDB.Parameter_Name[ 5] = "ARG_SUB_FACTORY"; 			
				MyOraDB.Parameter_Name[ 6] = "ARG_VALUE"; 
				MyOraDB.Parameter_Name[ 7] = "ARG_UPD_USER"; 

				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				for(int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
					{
						for (int iCol = _colTOTAL+1 ; iCol < fgrid_main.Cols.Count; iCol++)
							if (ClassLib.ComFunction.NullToBlank(fgrid_main[0, iCol]).Equals("U") )
								save_ct += 1;	
					}
				


				MyOraDB.Parameter_Values  = new string[iCount * save_ct];

				for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals(""))
					{

						for (int iCol=_colTOTAL+1; iCol<fgrid_main.Cols.Count; iCol++)
						{
							if (fgrid_main[0, iCol] == null)
								continue;

							if (fgrid_main[0, iCol].ToString() == "U")
							{
								MyOraDB.Parameter_Values[para_ct + 0 ] = fgrid_main[iRow, _colVALUE_DIV].ToString();
								MyOraDB.Parameter_Values[para_ct + 1 ] = fgrid_main[iRow, _colFACTORY].ToString();
								MyOraDB.Parameter_Values[para_ct + 2 ] = fgrid_main[iRow, _colACC_MONTH].ToString() + fgrid_main[2, iCol].ToString().PadLeft(2, '0');
								MyOraDB.Parameter_Values[para_ct + 3 ] = fgrid_main[iRow, _colORG_CD].ToString();
								MyOraDB.Parameter_Values[para_ct + 4 ] = fgrid_main[iRow, _colACC_CD].ToString();
								MyOraDB.Parameter_Values[para_ct + 5 ] = fgrid_main[iRow, _colSUB_FACTORY].ToString();
								MyOraDB.Parameter_Values[para_ct + 6 ] = fgrid_main[iRow, iCol].ToString();
								MyOraDB.Parameter_Values[para_ct + 7 ] = COM.ComVar.This_User;
							}
						
							para_ct += iCount;
						}
																		
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

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();
		}

		private void Grid_AfterEditProcess()
		{
			int iSel_Col = fgrid_main.Selection.c1;
			int iSel_Row = fgrid_main.Selection.r1;

			fgrid_main[0, iSel_Col] = "U";
			if (fgrid_main[iSel_Row, iSel_Col].ToString() != fgrid_main.Buffer_CellData)  
			{
				CALCUTE_SUM_HORIZON(iSel_Row);
				CALCUTE_SUM_VERTICAL(iSel_Col);

				UPDATE_BALANCE(iSel_Row, iSel_Col);
				UPDATE_BALANCE(iSel_Row, _colTOTAL);
				UPDATE_BALANCE(fgrid_main.Rows.Count-3, iSel_Col);

				fgrid_main[iSel_Row, 0] = "U";
				fgrid_main.Buffer_CellData = "";
			}

		}


		private void UPDATE_BALANCE(int arg_row, int arg_col)
		{
			int iBalance=0;

			if (fgrid_main[arg_row, _colVALUE_DIV].ToString() == "Plan")
			{
				if ( (fgrid_main[arg_row+1, arg_col].ToString() == "0")&&(fgrid_main[arg_row, arg_col].ToString() == "0") )
					return;

				iBalance = Convert.ToInt32(fgrid_main[arg_row+1, arg_col])-Convert.ToInt32(fgrid_main[arg_row, arg_col]);
				fgrid_main[arg_row+2, arg_col] = iBalance.ToString();

				if (Convert.ToInt32(fgrid_main[arg_row+1, arg_col])>=Convert.ToInt32(fgrid_main[arg_row, arg_col]))
					fgrid_main.GetCellRange(arg_row+2, arg_col).Style.BackColor = Color.Red;
				else if (95 >= (Convert.ToDouble(fgrid_main[arg_row+1, arg_col])/Convert.ToInt32(fgrid_main[arg_row, arg_col])*100))
					fgrid_main.GetCellRange(arg_row+2, arg_col).Style.BackColor = Color.LightGreen;
				else if ( (100 > (Convert.ToDouble(fgrid_main[arg_row+1, arg_col])/Convert.ToInt32(fgrid_main[arg_row, arg_col])*100))||
					      (95 <= (Convert.ToDouble(fgrid_main[arg_row+1, arg_col])/Convert.ToInt32(fgrid_main[arg_row, arg_col])*100)) )
					fgrid_main.GetCellRange(arg_row+2, arg_col).Style.BackColor = Color.Yellow;

			}
			else if (fgrid_main[arg_row, _colVALUE_DIV].ToString() == "Actual")
			{
				if ( (fgrid_main[arg_row, arg_col].ToString() == "0")&&(fgrid_main[arg_row-1, arg_col].ToString() == "0") )
					return;

				iBalance = Convert.ToInt32(fgrid_main[arg_row, arg_col])-Convert.ToInt32(fgrid_main[arg_row-1, arg_col]);
				fgrid_main[arg_row+1, arg_col] = iBalance.ToString();

				if (Convert.ToInt32(fgrid_main[arg_row, arg_col])>=Convert.ToInt32(fgrid_main[arg_row-1, arg_col]))
					fgrid_main.GetCellRange(arg_row+1, arg_col).Style.BackColor = Color.Red;
				else if (95 >= (Convert.ToDouble(fgrid_main[arg_row, arg_col])/Convert.ToInt32(fgrid_main[arg_row-1, arg_col])*100))
					fgrid_main.GetCellRange(arg_row+1, arg_col).Style.BackColor = Color.LightGreen;
				else if ( (100 > (Convert.ToDouble(fgrid_main[arg_row, arg_col])/Convert.ToInt32(fgrid_main[arg_row-1, arg_col])*100))||
					(95 <= (Convert.ToDouble(fgrid_main[arg_row, arg_col])/Convert.ToInt32(fgrid_main[arg_row-1, arg_col])*100)) )
					fgrid_main.GetCellRange(arg_row+1, arg_col).Style.BackColor = Color.Yellow;
			}
		}

		private void CALCUTE_SUM_HORIZON(int arg_row)
		{
			int iSum=0;

			for(int iCol=_colTOTAL+1; iCol<fgrid_main.Cols.Count; iCol++)
				iSum += Convert.ToInt32(fgrid_main[arg_row, iCol]);
			
			fgrid_main[arg_row, _colTOTAL] = iSum.ToString();
		}

		private void CALCUTE_SUM_VERTICAL(int arg_col)
		{
			int iSum_Plan=0;
			int iSum_Actual=0;

			for(int iRow=_Rowfixed+1; iRow<fgrid_main.Rows.Count-4; iRow++)
			{
				if (fgrid_main[iRow, _colVALUE_DIV].ToString() == "Plan")
					iSum_Plan   += Convert.ToInt32(fgrid_main[iRow, arg_col]);

				if (fgrid_main[iRow, _colVALUE_DIV].ToString() == "Actual")
					iSum_Actual += Convert.ToInt32(fgrid_main[iRow, arg_col]);
			}

			fgrid_main[fgrid_main.Rows.Count-3, arg_col] = iSum_Plan.ToString();
			fgrid_main[fgrid_main.Rows.Count-2, arg_col] = iSum_Actual.ToString();
		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((_Rowfixed > 0) && (fgrid_main.Row >= _Rowfixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}

		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			string sACC_DATE = cmbMonth.Text.Substring(0,4) + cmbMonth.Text.Substring(5,2) + fgrid_main[0, fgrid_main.Selection.c1].ToString().PadLeft(2, '0');

			EXEC_CLOSING("AT", sACC_DATE);
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			string sACC_DATE = cmbMonth.Text.Substring(0,4) + cmbMonth.Text.Substring(5,2) + fgrid_main[0, fgrid_main.Selection.c1].ToString().PadLeft(2, '0');

			EXEC_CLOSING("AF", sACC_DATE);
		}

		private void btnClosing_Click(object sender, System.EventArgs e)
		{
			string sACC_MONTH = cmbMonth.Text.Substring(0,4) + cmbMonth.Text.Substring(5,2);

			if (txtStatus.Text == "Closing") 
			{
				EXEC_CLOSING("PF", sACC_MONTH);
				txtStatus.Text = "Not Yet";
			}
			else
			{
				EXEC_CLOSING("PT", sACC_MONTH);
				txtStatus.Text = "Closing";
			}
		}


		private void EXEC_CLOSING(string arg_div, string arg_acc_date)
		{
				int para_ct = 0; 
				int iCount  = 6;

				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SIV_TCM_MANAGE.SAVE_SIV_TCM_CLOSING";

				//02.ARGURMENT NAME
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[ 2] = "ARG_ACC_DATE"; 
				MyOraDB.Parameter_Name[ 3] = "ARG_ORG_CD"; 
				MyOraDB.Parameter_Name[ 4] = "ARG_ACC_CD"; 
				MyOraDB.Parameter_Name[ 5] = "ARG_UPD_USER"; 

				MyOraDB.Parameter_Type[ 0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[ 1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[ 2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[ 3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[ 4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[ 5] = (int)OracleType.VarChar;
				

				MyOraDB.Parameter_Values  = new string[iCount];


				MyOraDB.Parameter_Values[para_ct + 0] = arg_div;
				MyOraDB.Parameter_Values[para_ct + 1] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct + 2] = arg_acc_date;
				MyOraDB.Parameter_Values[para_ct + 3] = cmb_Dep.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct + 4] = cmb_Acc.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct + 5] = COM.ComVar.This_User; 
				MyOraDB.Add_Modify_Parameter(true);		

				this.Tbtn_SearchProcess();

		}







	}
}

