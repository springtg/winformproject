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
using COM;

namespace FlexTraining.Evaluation
{
	public class Form_Evaluation : COM.TrainingWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel2;
		private COM.FSP fgrid_main;
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.TextBox txt_Training;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.Label lbl_Training;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel pnl_Menu;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.Label lbl_Group;
		private System.Windows.Forms.Label lbl_wave;
		private System.Windows.Forms.Label lbl_Seq;
		private System.Windows.Forms.TextBox txt_Wave;
		private System.Windows.Forms.TextBox txt_Group;
		private C1.Win.C1List.C1Combo cmb_Sequence;
		private C1.Win.C1List.C1Combo cmb_Training;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.ComponentModel.IContainer components = null;

		public Form_Evaluation()
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

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Evaluation));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.cmb_Training = new C1.Win.C1List.C1Combo();
			this.cmb_Sequence = new C1.Win.C1List.C1Combo();
			this.txt_Group = new System.Windows.Forms.TextBox();
			this.txt_Wave = new System.Windows.Forms.TextBox();
			this.lbl_wave = new System.Windows.Forms.Label();
			this.lbl_Seq = new System.Windows.Forms.Label();
			this.lbl_Group = new System.Windows.Forms.Label();
			this.txt_Training = new System.Windows.Forms.TextBox();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.lbl_Training = new System.Windows.Forms.Label();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pnl_Menu = new System.Windows.Forms.Panel();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Training)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Sequence)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
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
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
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
			this.c1Sizer1.Controls.Add(this.pnl_Menu);
			this.c1Sizer1.Controls.Add(this.statusBar1);
			this.c1Sizer1.GridDefinition = "23.3333333333333:False:True;65.1666666666667:False:False;7.83333333333333:False:T" +
				"rue;3.66666666666667:False:True;\t0.784313725490196:False:True;98.1372549019608:F" +
				"alse:False;1.07843137254902:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1020, 600);
			this.c1Sizer1.SplitterWidth = 0;
			this.c1Sizer1.TabIndex = 31;
			this.c1Sizer1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.fgrid_main);
			this.panel2.Location = new System.Drawing.Point(8, 140);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1001, 391);
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
			this.fgrid_main.Size = new System.Drawing.Size(1001, 391);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 32;
			this.fgrid_main.Click += new System.EventHandler(this.fgrid_main_Click);
			this.fgrid_main.StartEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_StartEdit);
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem1,
																						 this.menuItem2,
																						 this.menuItem3,
																						 this.menuItem4});
			this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "Skill Evaluation";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "-";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "Head View";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 3;
			this.menuItem4.Text = "Detail View";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
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
			this.pnl_Search.Size = new System.Drawing.Size(1020, 140);
			this.pnl_Search.TabIndex = 45;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.cmb_Training);
			this.pnl_SearchImage.Controls.Add(this.cmb_Sequence);
			this.pnl_SearchImage.Controls.Add(this.txt_Group);
			this.pnl_SearchImage.Controls.Add(this.txt_Wave);
			this.pnl_SearchImage.Controls.Add(this.lbl_wave);
			this.pnl_SearchImage.Controls.Add(this.lbl_Seq);
			this.pnl_SearchImage.Controls.Add(this.lbl_Group);
			this.pnl_SearchImage.Controls.Add(this.txt_Training);
			this.pnl_SearchImage.Controls.Add(this.cmb_factory);
			this.pnl_SearchImage.Controls.Add(this.lbl_factory);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.lbl_Training);
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
			this.pnl_SearchImage.Size = new System.Drawing.Size(1006, 126);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// cmb_Training
			// 
			this.cmb_Training.AddItemCols = 0;
			this.cmb_Training.AddItemSeparator = ';';
			this.cmb_Training.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Training.AutoSize = false;
			this.cmb_Training.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Training.Caption = "";
			this.cmb_Training.CaptionHeight = 17;
			this.cmb_Training.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Training.ColumnCaptionHeight = 18;
			this.cmb_Training.ColumnFooterHeight = 18;
			this.cmb_Training.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Training.ContentHeight = 17;
			this.cmb_Training.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Training.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Training.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_Training.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Training.EditorHeight = 17;
			this.cmb_Training.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Training.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Training.GapHeight = 2;
			this.cmb_Training.ItemHeight = 15;
			this.cmb_Training.Location = new System.Drawing.Point(280, 64);
			this.cmb_Training.MatchEntryTimeout = ((long)(2000));
			this.cmb_Training.MaxDropDownItems = ((short)(5));
			this.cmb_Training.MaxLength = 32767;
			this.cmb_Training.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Training.Name = "cmb_Training";
			this.cmb_Training.PartialRightColumn = false;
			this.cmb_Training.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}He" +
				"ading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText" +
				";BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Training.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Training.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Training.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Training.Size = new System.Drawing.Size(304, 21);
			this.cmb_Training.TabIndex = 570;
			this.cmb_Training.TextChanged += new System.EventHandler(this.cmb_Training_TextChanged);
			this.cmb_Training.Change += new C1.Win.C1List.ChangeEventHandler(this.cmb_Training_Change);
			// 
			// cmb_Sequence
			// 
			this.cmb_Sequence.AddItemCols = 0;
			this.cmb_Sequence.AddItemSeparator = ';';
			this.cmb_Sequence.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Sequence.AutoSize = false;
			this.cmb_Sequence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Sequence.Caption = "";
			this.cmb_Sequence.CaptionHeight = 17;
			this.cmb_Sequence.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Sequence.ColumnCaptionHeight = 18;
			this.cmb_Sequence.ColumnFooterHeight = 18;
			this.cmb_Sequence.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Sequence.ContentHeight = 17;
			this.cmb_Sequence.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Sequence.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Sequence.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_Sequence.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Sequence.EditorHeight = 17;
			this.cmb_Sequence.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Sequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Sequence.GapHeight = 2;
			this.cmb_Sequence.ItemHeight = 15;
			this.cmb_Sequence.Location = new System.Drawing.Point(108, 88);
			this.cmb_Sequence.MatchEntryTimeout = ((long)(2000));
			this.cmb_Sequence.MaxDropDownItems = ((short)(5));
			this.cmb_Sequence.MaxLength = 32767;
			this.cmb_Sequence.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Sequence.Name = "cmb_Sequence";
			this.cmb_Sequence.PartialRightColumn = false;
			this.cmb_Sequence.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True" +
				";BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Cen" +
				"ter;}Style8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Sequence.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Sequence.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Sequence.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Sequence.Size = new System.Drawing.Size(284, 21);
			this.cmb_Sequence.TabIndex = 569;
			this.cmb_Sequence.TextChanged += new System.EventHandler(this.cmb_Sequence_TextChanged);
			this.cmb_Sequence.Change += new C1.Win.C1List.ChangeEventHandler(this.cmb_Sequence_Change);
			// 
			// txt_Group
			// 
			this.txt_Group.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txt_Group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Group.Enabled = false;
			this.txt_Group.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Group.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txt_Group.Location = new System.Drawing.Point(704, 64);
			this.txt_Group.MaxLength = 20;
			this.txt_Group.Name = "txt_Group";
			this.txt_Group.Size = new System.Drawing.Size(304, 22);
			this.txt_Group.TabIndex = 568;
			this.txt_Group.Text = "";
			// 
			// txt_Wave
			// 
			this.txt_Wave.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txt_Wave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Wave.Enabled = false;
			this.txt_Wave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Wave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txt_Wave.Location = new System.Drawing.Point(704, 88);
			this.txt_Wave.MaxLength = 20;
			this.txt_Wave.Name = "txt_Wave";
			this.txt_Wave.Size = new System.Drawing.Size(200, 22);
			this.txt_Wave.TabIndex = 567;
			this.txt_Wave.Text = "";
			// 
			// lbl_wave
			// 
			this.lbl_wave.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_wave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_wave.ImageIndex = 0;
			this.lbl_wave.ImageList = this.img_Label;
			this.lbl_wave.Location = new System.Drawing.Point(600, 84);
			this.lbl_wave.Name = "lbl_wave";
			this.lbl_wave.Size = new System.Drawing.Size(100, 21);
			this.lbl_wave.TabIndex = 160;
			this.lbl_wave.Text = "Wave";
			this.lbl_wave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Seq
			// 
			this.lbl_Seq.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Seq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Seq.ImageIndex = 0;
			this.lbl_Seq.ImageList = this.img_Label;
			this.lbl_Seq.Location = new System.Drawing.Point(8, 84);
			this.lbl_Seq.Name = "lbl_Seq";
			this.lbl_Seq.Size = new System.Drawing.Size(100, 21);
			this.lbl_Seq.TabIndex = 157;
			this.lbl_Seq.Text = "Objectives";
			this.lbl_Seq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Group
			// 
			this.lbl_Group.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Group.ImageIndex = 0;
			this.lbl_Group.ImageList = this.img_Label;
			this.lbl_Group.Location = new System.Drawing.Point(600, 62);
			this.lbl_Group.Name = "lbl_Group";
			this.lbl_Group.Size = new System.Drawing.Size(100, 21);
			this.lbl_Group.TabIndex = 155;
			this.lbl_Group.Text = "Group";
			this.lbl_Group.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Training
			// 
			this.txt_Training.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Training.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Training.Location = new System.Drawing.Point(109, 64);
			this.txt_Training.MaxLength = 20;
			this.txt_Training.Name = "txt_Training";
			this.txt_Training.Size = new System.Drawing.Size(171, 21);
			this.txt_Training.TabIndex = 154;
			this.txt_Training.Text = "";
			this.txt_Training.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Training_KeyPress);
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
			this.cmb_factory.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_factory.EditorHeight = 17;
			this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True" +
				";BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Cen" +
				"ter;}Style8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(200, 21);
			this.cmb_factory.TabIndex = 151;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.picb_MR.Location = new System.Drawing.Point(905, 30);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(101, 88);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(992, 111);
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
			// lbl_Training
			// 
			this.lbl_Training.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Training.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Training.ImageIndex = 0;
			this.lbl_Training.ImageList = this.img_Label;
			this.lbl_Training.Location = new System.Drawing.Point(8, 62);
			this.lbl_Training.Name = "lbl_Training";
			this.lbl_Training.Size = new System.Drawing.Size(100, 21);
			this.lbl_Training.TabIndex = 149;
			this.lbl_Training.Text = "Program";
			this.lbl_Training.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.picb_BM.Location = new System.Drawing.Point(123, 110);
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
			this.picb_BL.Location = new System.Drawing.Point(0, 111);
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
			this.picb_ML.Size = new System.Drawing.Size(144, 95);
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
			this.pictureBox6.Size = new System.Drawing.Size(904, 88);
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
			// pnl_Menu
			// 
			this.pnl_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Menu.Location = new System.Drawing.Point(8, 531);
			this.pnl_Menu.Name = "pnl_Menu";
			this.pnl_Menu.Size = new System.Drawing.Size(1012, 47);
			this.pnl_Menu.TabIndex = 44;
			// 
			// statusBar1
			// 
			this.statusBar1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.statusBar1.Location = new System.Drawing.Point(0, 578);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1,
																						  this.statusBarPanel2});
			this.statusBar1.Size = new System.Drawing.Size(1020, 22);
			this.statusBar1.TabIndex = 43;
			// 
			// Form_Evaluation
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_Evaluation";
			this.Load += new System.EventHandler(this.Form_Evaluation_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Training)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Sequence)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region User Define Variable

		private COM.OraDB MyOraDB  = new COM.OraDB();
		private int _Rowfixed;
		private int _temp_row = 0, _temp_col = 0;

		private int _colT_LEVEL 	 = (int)ClassLib.TBSIM_EVALUATION.IxT_LEVEL;
		private int _colFACTORY 	 = (int)ClassLib.TBSIM_EVALUATION.IxFACTORY;
		private int _colT_CODE 	     = (int)ClassLib.TBSIM_EVALUATION.IxT_CODE;
		private int _colT_NAME 	     = (int)ClassLib.TBSIM_EVALUATION.IxT_NAME;
		private int _colSEQ          = (int)ClassLib.TBSIM_EVALUATION.IxSEQ;
		private int _colEMP_NO       = (int)ClassLib.TBSIM_EVALUATION.IxEMP_NO;
		private int _colEMP_NO2      = (int)ClassLib.TBSIM_EVALUATION.IxEMP_NO2;
		private int _colNAME 	     = (int)ClassLib.TBSIM_EVALUATION.IxNAME;
		private int _colDEP_CODE 	 = (int)ClassLib.TBSIM_EVALUATION.IxDEP_CODE;
		private int _colDEP_NAME 	 = (int)ClassLib.TBSIM_EVALUATION.IxDEP_NAME;
		private int _colDEP_NAME2 	 = (int)ClassLib.TBSIM_EVALUATION.IxDEP_NAME2;
		private int _colPOSITION   	 = (int)ClassLib.TBSIM_EVALUATION.IxPOSITION;
		private int _colGOAL_VALUE 	 = (int)ClassLib.TBSIM_EVALUATION.IxGOAL_VALUE;
		private int _colGOAL_DESC 	 = (int)ClassLib.TBSIM_EVALUATION.IxGOAL_DESC;
		private int _colFULL_ATTEND	 = (int)ClassLib.TBSIM_EVALUATION.IxFULL_ATTEND;
		private int _colPLAN         = (int)ClassLib.TBSIM_EVALUATION.IxPLAN;
		private int _colATTEND       = (int)ClassLib.TBSIM_EVALUATION.IxATTEND;
		private int _colMEASURE 	 = (int)ClassLib.TBSIM_EVALUATION.IxMEASURE;
		private int _colRESULT_VALUE = (int)ClassLib.TBSIM_EVALUATION.IxRESULT_VALUE;
		private int _colREASON   	 = (int)ClassLib.TBSIM_EVALUATION.IxREASON;
		private int _colREMARK   	 = (int)ClassLib.TBSIM_EVALUATION.IxREMARK;

		#endregion

		private void Form_Evaluation_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		private void Init_Form()
		{						
			
			
			
			// Form Setting
			lbl_MainTitle.Text = "Evaluation";
			this.Text		   = "Evaluation";

			// grid set
			fgrid_main.Set_Grid("SIM_EVALUATION", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			_Rowfixed = fgrid_main.Rows.Fixed;
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";

			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

//			fgrid_main.Styles.Frozen.BackColor = Color.Lavender; 			
//			fgrid_main.KeyActionEnter = KeyActionEnum.MoveAcross;
//			fgrid_main.KeyActionTab = KeyActionEnum.MoveAcross;  
//			fgrid_main.SelectionMode = SelectionModeEnum.Cell;

			DataTable vDt;

			// factory set
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
			cmb_factory.SelectedValue    = ClassLib.ComVar.This_Factory;
			//set Traing cmb
			Get_Training_List(true);
			
			txt_Training.Select();				

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.btn_refresh_Process();
			this.Tbtn_SearchProcess();		
		}
		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SIM_EVALUATION.SELECT_SIM_EVALUATION_TAIL";

				DataTable vDt = SELECT_SIM_EVALUATION(vProcedure);

				Clear_FlexGrid();
				if (vDt.Rows.Count > 0)
				{
					Display_FlexGrid(vDt);
					GridSetColor();

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
		public DataTable SELECT_SIM_EVALUATION(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_T_CODE";
			MyOraDB.Parameter_Name[ 2]  = "ARG_SEQ";
			MyOraDB.Parameter_Name[ 3]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[ 1]   = ClassLib.ComFunction.Empty_Combo(cmb_Training, "");
			MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_Combo(cmb_Sequence, "");
			MyOraDB.Parameter_Values[ 3]   = "";

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
			int iRow_fixed = fgrid_main.Rows.Fixed;
			int iLevel = 0; 
			int iCount = arg_dt.Rows.Count;

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{
				iLevel = Convert.ToInt32(arg_dt.Rows[iRow].ItemArray[_colT_LEVEL-1].ToString() );
				C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(iRow_fixed + iRow, iLevel);

				for (int iCol = 1 ; iCol <= arg_dt.Columns.Count ; iCol++)
				{
					fgrid_main[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
				}

				fgrid_main.Tree.Column = _colNAME;
				

			}
			//GridSetColor();

			//rad_lvl1.Checked = true;
			fgrid_main.Tree.Show(1); 

		}

		private void GridSetColor()
		{
			try
			{				
				string sLevel = "";
				CellRange vRange;

				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					sLevel      = fgrid_main[iRow, _colT_LEVEL].ToString();
					vRange      = fgrid_main.GetCellRange(iRow, 1, iRow, fgrid_main.Cols.Count - 1);
					if (sLevel.Equals("1"))
					{						
						//vRange.StyleNew.BackColor = Color.Lavender;
						vRange.StyleNew.BackColor = Color.WhiteSmoke;
						//						if (fgrid_main[iRow, _colFOB_DIV].ToString() == "1")
						//							fgrid_main.GetCellRange(iRow, _colTRADE_CS_FOB, iRow, _colTRADE_FACTORY_FOB).StyleNew.BackColor = Color.FromArgb(240, 244, 250);
						//						else
						//							fgrid_main.GetCellRange(iRow, _colTRADE_CS_FOB, iRow, _colTRADE_FACTORY_FOB).StyleNew.BackColor = Color.Red;		

					}
					else if (sLevel.Equals("2"))
					{
						vRange.StyleNew.BackColor = Color.LightYellow;
//						fgrid_main.GetCellRange(iRow, _colNAME).StyleNew.ForeColor = Color.RoyalBlue;
//						fgrid_main.GetCellRange(iRow, _colRESULT_VALUE).StyleNew.ForeColor = Color.Red;
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "GridSetColor", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}				
		}

		private void Display_FlexGrid_1(DataTable arg_dt)
		{
			int iCount = arg_dt.Rows.Count;

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{				
				C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(_Rowfixed + iRow, 1);

				fgrid_main[newRow.Row.Index, 0] = "";

				for (int iCol = 0; iCol < arg_dt.Columns.Count ; iCol++)
					fgrid_main[newRow.Row.Index, iCol+1] = arg_dt.Rows[iRow].ItemArray[iCol];
			}
		}

		private void txt_Training_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar != 13) return;
			Get_Training_List(true); 
		}
		private void Get_Training_List(bool arg_enter)
		{
			if(! arg_enter) return;

			string vProcedure = "PKG_SIM_MASTER.SELECT_SIM_TRAINING_LIST";

			DataTable dt_ret = SELECT_TRAINING_LIST(vProcedure);			
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Training, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
		}
		
		private DataTable SELECT_TRAINING_LIST(string arg_procedure)
		{ 
			DataSet vDt;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_T_NAME";
			MyOraDB.Parameter_Name[ 2]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[ 1]   = ClassLib.ComFunction.Empty_TextBox(txt_Training, "");
			MyOraDB.Parameter_Values[ 2]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void cmb_Sequence_Change(object sender, System.EventArgs e)
		{
			DataTable dt_ret =GET_GROUPWAVE();	
			if (dt_ret.Rows.Count>0)
			{
				txt_Group.Text=dt_ret.Rows[0].ItemArray[0].ToString();
				txt_Wave.Text=dt_ret.Rows[0].ItemArray[1].ToString();
			}
		}
		private DataTable GET_GROUPWAVE()
		{
			string vProcedure = "PKG_SIM_TRAINEE.SELECT_TRAINING_GROUPWAVE";
			DataTable dt_ret = SELECT_GROUPWAVE_LIST(vProcedure);	
			return dt_ret;
		}
		private DataTable SELECT_GROUPWAVE_LIST(string arg_procedure)
		{ 
			DataSet vDt;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_T_CODE";
			MyOraDB.Parameter_Name[ 2]  = "ARG_SEQ";
			MyOraDB.Parameter_Name[ 3]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[ 1]   = ClassLib.ComFunction.Empty_Combo(cmb_Training, "");
			MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_Combo(cmb_Sequence, "");
			MyOraDB.Parameter_Values[ 3]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void cmb_Training_Change(object sender, System.EventArgs e)
		{
			DataTable dt_ret = Get_Group_List(); 
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Sequence , 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
		}
		private DataTable Get_Group_List()
		{
			string vProcedure = "PKG_SIM_TRAINEE.SELECT_SIM_TRAINING_GROUP";
			DataTable dt_ret = SELECT_SEQ_LIST(vProcedure);	
			return dt_ret;
		}
		private DataTable SELECT_SEQ_LIST(string arg_procedure)
		{ 
			DataSet vDt;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_T_CODE";
			MyOraDB.Parameter_Name[ 2]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[ 1]   = ClassLib.ComFunction.Empty_Combo(cmb_Training, "");
			MyOraDB.Parameter_Values[ 2]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Validate_Check())
			{
				if(ClassLib.ComFunction.User_Message("Do you want to save?","save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
				{
					this.Tbtn_SaveProcess();					
				}
			}		
		}
		private bool Validate_Check()
		{
			for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
			{
				if ((fgrid_main[iRow, _colEMP_NO].ToString().Replace(" ", "").Trim().Length == 0) )
				{
					fgrid_main[iRow, 0] = "";					
				}
			}			

			return true;
		}
		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_SIM_EVALUATION(true))
				{
					fgrid_main.Refresh_Division();
					this.Tbtn_SearchProcess();
					MessageBox.Show("Create Complete","Create", MessageBoxButtons.OK ,MessageBoxIcon.Information);
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

		public bool SAVE_SIM_EVALUATION(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 13;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SIM_EVALUATION.SAVE_SIM_EVALUATION";

				//02.ARGURMENT NAME
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 2] = "ARG_T_CODE";
				MyOraDB.Parameter_Name[ 3] = "ARG_SEQ";
				MyOraDB.Parameter_Name[ 4] = "ARG_EMP_NO";
				MyOraDB.Parameter_Name[ 5] = "ARG_FULL_ATTEND";
				MyOraDB.Parameter_Name[ 6] = "ARG_PLAN";
				MyOraDB.Parameter_Name[ 7] = "ARG_ATTENDANCE";
				MyOraDB.Parameter_Name[ 8] = "ARG_MEASURE_CODE";
				MyOraDB.Parameter_Name[ 9] = "ARG_RESULT_VALUE";
				MyOraDB.Parameter_Name[10] = "ARG_REASON";
				MyOraDB.Parameter_Name[11] = "ARG_REMARK";
				MyOraDB.Parameter_Name[12] = "ARG_UPDATE_USER";


				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
						save_ct += 1;
				
				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					//if(fgrid_main[iRow, 0].ToString() != "")
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
					{
						MyOraDB.Parameter_Values[para_ct+ 0] = ClassLib.ComFunction.Empty_String(fgrid_main[iRow, 0].ToString(),"");
						MyOraDB.Parameter_Values[para_ct+ 1] = ClassLib.ComFunction.Empty_String(fgrid_main[iRow, _colFACTORY].ToString(),"");
						MyOraDB.Parameter_Values[para_ct+ 2] = ClassLib.ComFunction.Empty_String(fgrid_main[iRow, _colT_CODE].ToString(),"");
						MyOraDB.Parameter_Values[para_ct+ 3] = ClassLib.ComFunction.Empty_String(fgrid_main[iRow, _colSEQ].ToString(),"");
						MyOraDB.Parameter_Values[para_ct+ 4] = ClassLib.ComFunction.Empty_String(fgrid_main[iRow, _colEMP_NO].ToString(),"");
						//MyOraDB.Parameter_Values[para_ct+ 5] = ClassLib.ComFunction.Empty_String(fgrid_main[iRow, _colFULL_ATTEND].ToString(),"");
						MyOraDB.Parameter_Values[para_ct+ 5] = (fgrid_main[iRow, _colFULL_ATTEND].ToString()== "True") ? "Y" : "N";

						MyOraDB.Parameter_Values[para_ct+ 6] = ClassLib.ComFunction.Empty_String(fgrid_main[iRow, _colPLAN].ToString(),"");
						MyOraDB.Parameter_Values[para_ct+ 7] = ClassLib.ComFunction.Empty_String(fgrid_main[iRow, _colATTEND].ToString(),"");
						MyOraDB.Parameter_Values[para_ct+ 8] = ClassLib.ComFunction.Empty_String(fgrid_main[iRow, _colMEASURE].ToString(),"");
						MyOraDB.Parameter_Values[para_ct+ 9] = ClassLib.ComFunction.Empty_String(fgrid_main[iRow, _colRESULT_VALUE].ToString(),"");
						MyOraDB.Parameter_Values[para_ct+ 10] = ClassLib.ComFunction.Empty_String(fgrid_main[iRow, _colREASON].ToString(),"");
						MyOraDB.Parameter_Values[para_ct+ 11] = ClassLib.ComFunction.Empty_String(ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colREMARK]),"");
						MyOraDB.Parameter_Values[para_ct+ 12] = COM.ComVar.This_User;
 
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


		private void fgrid_main_StartEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			//fgrid_main.Update_Row(fgrid_main.Selection.r1);		
		}

		private void btn_refresh_Process()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (GETNEW_SIM_EVALUATION(true))
				{
					//fgrid_main.Refresh_Division();
					//this.Tbtn_SearchProcess();
					//MessageBox.Show("Refresh Completed","Refresh", MessageBoxButtons.OK ,MessageBoxIcon.Information);
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
		public bool GETNEW_SIM_EVALUATION(bool doExecute)
		{
			try
			{
				int iCount  = 4;

				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SIM_EVALUATION.GETNEW_SIM_EVALUATION";

				//02.ARGURMENT NAME
				MyOraDB.Parameter_Name[ 0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 1] = "ARG_T_CODE";
				MyOraDB.Parameter_Name[ 2] = "ARG_SEQ";
				MyOraDB.Parameter_Name[ 3] = "ARG_UPDATE_USER";

				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[ 1]   = ClassLib.ComFunction.Empty_Combo(cmb_Training , "");
				MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_Combo(cmb_Sequence , "");
				MyOraDB.Parameter_Values[ 3]   = COM.ComVar.This_User;

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

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			//this.Tbtn_PrintProcess();
		}

//		private void Tbtn_PrintProcess()
//		{
//			string sDir = "";
//			sDir = FlexTraining.ClassLib.ComFunction.Set_RD_Directory("Form_Evaluation");
//			
//			string sPara;
//			
//			sPara  = " /rp ";
//			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_factory, "")  +	"' ";	
//			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_Training , "")  +	"' ";		
//			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_Sequence , "")  +	"' ";
//			FlexTraining.Report.Form_RdViewer MyReport = new FlexTraining.Report.Form_RdViewer(sDir, sPara);
//
//			MyReport.Text = "Invoice LIst";
//			MyReport.Show();
//		}

		private void cmb_Training_TextChanged(object sender, System.EventArgs e)
		{
//			
		}

		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
//			string sLevel = fgrid_main[fgrid_main.Selection.r1, _colT_LEVEL].ToString();
//			int    iRow   = fgrid_main.Selection.r1;
//			int    iCol   = fgrid_main.Selection.c1;
//
////			string vProcedure     = "PKG_SIM_EVALUATION.SELECT_SIM_SKILL_MASTER";
////			DataTable dt_cmblist = SELECT_SIM_SKILL_MASTER(vProcedure);
////			fgrid_main.Cols[_colNAME].ComboList = fgrid_main.Make_CmbDataList(ComVar.ComboList_Type.ComCode_Name, dt_cmblist);
//			
//			if (sLevel.Equals("1"))
//			{
//				fgrid_main.Cols[_colNAME].AllowEditing = false;
//			}
//			else if ((iCol == _colNAME)&&(fgrid_main.Cols[iCol].ComboList == "...")&&(_temp_row==iRow)&&(_temp_col==iCol))
//			{
//				Get_Skill_Master();
//				fgrid_main.Cols[iCol].ComboList = "";
//			}
//			else if (iCol == _colNAME)
//			{
//				fgrid_main.Cols[_colNAME].AllowEditing = true;
//				fgrid_main.Rows[iRow].AllowEditing   = true;
//				fgrid_main.Cols[iCol].Style.DataType = typeof(string);
//				fgrid_main.Cols[iCol].ComboList = "...";
//
//				_temp_row = iRow;
//				_temp_col = iCol;
//			}
//			else
//			{
//				//fgrid_main.Rows[iRow].AllowEditing   = false;
//			}			
		}

		private void Get_Skill_Master()
		{
			int iRow = fgrid_main.Selection.r1;

			string[] keys = new string[]{ fgrid_main[iRow, _colFACTORY].ToString(),
										  fgrid_main[iRow, _colT_CODE].ToString(),
										  fgrid_main[iRow, _colT_NAME].ToString(),
										  fgrid_main[iRow, _colSEQ].ToString(),
										  fgrid_main[iRow, _colEMP_NO2].ToString()
										};
						
			COM.ComVar.Parameter_PopUp		= new string[0];
			Pop_SIM_Skill_Master pop_skill_master = new Pop_SIM_Skill_Master(keys);
			pop_skill_master.ShowDialog();

//			if (COM.ComVar.Parameter_PopUp.Length > 1)
//			{
//				fgrid_main[iRow, _colNAME]          = COM.ComVar.Parameter_PopUp[0];
//				//fgrid_main[iRow, _colFFS_SOLDTO_CD] = COM.ComVar.Parameter_PopUp[1];
//				//fgrid_main[iRow, _colFFS_NAME2]     = COM.ComVar.Parameter_PopUp[2];
//
//				fgrid_main.Update_Row(iRow);
//
//				COM.ComVar.Parameter_PopUp		= new string[0];
//			}			

			pop_skill_master.Dispose();
		}

		private void cmb_Sequence_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private DataTable SELECT_SIM_SKILL_MASTER(string arg_procedure)
		{ 
			DataSet vDt;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_T_CODE";
			MyOraDB.Parameter_Name[ 2]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[ 1]   = ClassLib.ComFunction.Empty_Combo(cmb_Training, "");
			MyOraDB.Parameter_Values[ 2]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			try
			{				
				//Insert_Skill_Evaluation();
				Get_Skill_Master();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
			Tbtn_SearchProcess ();

		}

		private void contextMenu1_Popup(object sender, System.EventArgs e)
		{
			if (fgrid_main[fgrid_main.Selection.r1, _colT_LEVEL].ToString() == "1")		
				menuItem1.Enabled = true;
			else
				menuItem1.Enabled = false;
		}

		private void Insert_Skill_Evaluation()
		{
			int sel_row = fgrid_main.Selection.r1;

			add_row(sel_row);
			//GridSetColor();

		}


		/// <summary>
		/// add_row : 
		/// </summary>
		/// <param name="arg_rownum"></param>
		private void add_row(int arg_sel_row)
		{
			try
			{
				C1.Win.C1FlexGrid.Node node = fgrid_main.Rows[arg_sel_row].Node;
	
				/*if ((arg_sel_row < fgrid_main.Rows.Count-1) &&
					(fgrid_main[arg_sel_row+1, _colT_LEVEL].ToString() != "1"))
				{
					int previous_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index; 
				
					if (fgrid_main[previous_row, _colLOT_DIV].ToString() != "P")
					{					
						MessageBox.Show("This Order completed invoice creation already!","Create Invoice", MessageBoxButtons.OK ,MessageBoxIcon.Information);
						return;
					}
				}*/

				node.AddNode(NodeTypeEnum.LastChild, "");

				int current_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index; 

				// Set Default Value //
				fgrid_main[current_row, 0]                       = "I";
				fgrid_main[current_row, _colT_LEVEL]	         = "2";
				fgrid_main[current_row, _colFACTORY]             = fgrid_main[current_row-1, _colFACTORY].ToString();
				fgrid_main[current_row, _colT_CODE]              = fgrid_main[current_row-1, _colT_CODE].ToString();
				fgrid_main[current_row, _colT_NAME]              = fgrid_main[current_row-1, _colT_NAME].ToString();
				fgrid_main[current_row, _colSEQ]                 = fgrid_main[current_row-1, _colSEQ].ToString();
				fgrid_main[current_row, _colEMP_NO2]             = fgrid_main[current_row-1, _colEMP_NO2].ToString();
				fgrid_main[current_row, _colRESULT_VALUE ]       = "";
				fgrid_main[current_row, _colREMARK]              = "";

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}

		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(1);
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(2);
		}

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			string sLevel = fgrid_main[fgrid_main.Selection.r1, _colT_LEVEL].ToString();

			if (sLevel == "1")
			{
				fgrid_main.Update_Row(fgrid_main.Selection.r1);
			}
		}


	}
}

