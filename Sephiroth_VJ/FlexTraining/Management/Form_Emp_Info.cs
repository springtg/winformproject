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

namespace FlexTraining.Management
{
	public class Form_Emp_Info : COM.TrainingWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel2;
		private COM.FSP fgrid_main;
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.PictureBox Pic_Emp;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Label label11;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_ML;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_Dep;
		private C1.Win.C1List.C1Combo cmb_Department;
		private System.Windows.Forms.TextBox txt_Training;
		private System.Windows.Forms.Label lbl_Training;
		private C1.Win.C1List.C1Combo cmb_Training;
		private C1.Win.C1List.C1Combo cmb_Position;
		private System.Windows.Forms.TextBox txt_Position;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;

		public Form_Emp_Info()
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
//		private string _Emp_Name;		

		private int _colTRAINED    =  8;

	#endregion

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Emp_Info));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.cmb_Position = new C1.Win.C1List.C1Combo();
			this.txt_Position = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmb_Training = new C1.Win.C1List.C1Combo();
			this.txt_Training = new System.Windows.Forms.TextBox();
			this.lbl_Training = new System.Windows.Forms.Label();
			this.txt_Dep = new System.Windows.Forms.TextBox();
			this.cmb_Department = new C1.Win.C1List.C1Combo();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label11 = new System.Windows.Forms.Label();
			this.Pic_Emp = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
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
			((System.ComponentModel.ISupportInitialize)(this.cmb_Position)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Training)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Department)).BeginInit();
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
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// stbar
			// 
			this.stbar.Location = new System.Drawing.Point(0, 512);
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
			this.c1Sizer1.Controls.Add(this.statusBar1);
			this.c1Sizer1.GridDefinition = "34.4827586206897:False:True;64.6551724137931:False:False;\t99.609375:False:False;0" +
				":False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(-4, 48);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1024, 464);
			this.c1Sizer1.TabIndex = 31;
			this.c1Sizer1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.fgrid_main);
			this.panel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel2.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.panel2.Location = new System.Drawing.Point(0, 164);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1020, 300);
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
			this.fgrid_main.Size = new System.Drawing.Size(1020, 300);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 32;
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.Controls.Add(this.pictureBox6);
			this.pnl_Search.DockPadding.All = 7;
			this.pnl_Search.Location = new System.Drawing.Point(0, 0);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1024, 160);
			this.pnl_Search.TabIndex = 45;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.cmb_Position);
			this.pnl_SearchImage.Controls.Add(this.txt_Position);
			this.pnl_SearchImage.Controls.Add(this.label1);
			this.pnl_SearchImage.Controls.Add(this.cmb_Training);
			this.pnl_SearchImage.Controls.Add(this.txt_Training);
			this.pnl_SearchImage.Controls.Add(this.lbl_Training);
			this.pnl_SearchImage.Controls.Add(this.txt_Dep);
			this.pnl_SearchImage.Controls.Add(this.cmb_Department);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.pictureBox1);
			this.pnl_SearchImage.Controls.Add(this.label11);
			this.pnl_SearchImage.Controls.Add(this.Pic_Emp);
			this.pnl_SearchImage.Controls.Add(this.label2);
			this.pnl_SearchImage.Controls.Add(this.cmb_factory);
			this.pnl_SearchImage.Controls.Add(this.lbl_factory);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(7, 7);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1010, 146);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// cmb_Position
			// 
			this.cmb_Position.AddItemCols = 0;
			this.cmb_Position.AddItemSeparator = ';';
			this.cmb_Position.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Position.AutoSize = false;
			this.cmb_Position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Position.Caption = "";
			this.cmb_Position.CaptionHeight = 17;
			this.cmb_Position.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Position.ColumnCaptionHeight = 18;
			this.cmb_Position.ColumnFooterHeight = 18;
			this.cmb_Position.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Position.ContentHeight = 17;
			this.cmb_Position.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Position.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Position.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_Position.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Position.EditorHeight = 17;
			this.cmb_Position.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Position.GapHeight = 2;
			this.cmb_Position.ItemHeight = 15;
			this.cmb_Position.Location = new System.Drawing.Point(312, 81);
			this.cmb_Position.MatchEntryTimeout = ((long)(2000));
			this.cmb_Position.MaxDropDownItems = ((short)(5));
			this.cmb_Position.MaxLength = 32767;
			this.cmb_Position.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Position.Name = "cmb_Position";
			this.cmb_Position.PartialRightColumn = false;
			this.cmb_Position.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Position.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Position.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Position.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Position.Size = new System.Drawing.Size(322, 21);
			this.cmb_Position.TabIndex = 577;
			// 
			// txt_Position
			// 
			this.txt_Position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Position.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Position.Location = new System.Drawing.Point(112, 81);
			this.txt_Position.MaxLength = 20;
			this.txt_Position.Name = "txt_Position";
			this.txt_Position.Size = new System.Drawing.Size(200, 21);
			this.txt_Position.TabIndex = 576;
			this.txt_Position.Text = "";
			this.txt_Position.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Position_KeyPress);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(8, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 24);
			this.label1.TabIndex = 575;
			this.label1.Text = "Position";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Training.Location = new System.Drawing.Point(313, 104);
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
			this.cmb_Training.Size = new System.Drawing.Size(322, 21);
			this.cmb_Training.TabIndex = 574;
			// 
			// txt_Training
			// 
			this.txt_Training.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Training.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Training.Location = new System.Drawing.Point(112, 104);
			this.txt_Training.MaxLength = 20;
			this.txt_Training.Name = "txt_Training";
			this.txt_Training.Size = new System.Drawing.Size(200, 21);
			this.txt_Training.TabIndex = 573;
			this.txt_Training.Text = "";
			this.txt_Training.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Training_KeyPress);
			// 
			// lbl_Training
			// 
			this.lbl_Training.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Training.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Training.ImageIndex = 0;
			this.lbl_Training.ImageList = this.img_Label;
			this.lbl_Training.Location = new System.Drawing.Point(8, 104);
			this.lbl_Training.Name = "lbl_Training";
			this.lbl_Training.Size = new System.Drawing.Size(104, 24);
			this.lbl_Training.TabIndex = 571;
			this.lbl_Training.Text = "Program";
			this.lbl_Training.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Dep
			// 
			this.txt_Dep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Dep.Location = new System.Drawing.Point(112, 59);
			this.txt_Dep.MaxLength = 5;
			this.txt_Dep.Name = "txt_Dep";
			this.txt_Dep.Size = new System.Drawing.Size(200, 21);
			this.txt_Dep.TabIndex = 570;
			this.txt_Dep.Text = "";
			this.txt_Dep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dep_KeyPress);
			// 
			// cmb_Department
			// 
			this.cmb_Department.AddItemCols = 0;
			this.cmb_Department.AddItemSeparator = ';';
			this.cmb_Department.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Department.AutoSize = false;
			this.cmb_Department.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Department.Caption = "";
			this.cmb_Department.CaptionHeight = 17;
			this.cmb_Department.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Department.ColumnCaptionHeight = 18;
			this.cmb_Department.ColumnFooterHeight = 18;
			this.cmb_Department.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Department.ContentHeight = 17;
			this.cmb_Department.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Department.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Department.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_Department.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Department.EditorHeight = 17;
			this.cmb_Department.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Department.GapHeight = 2;
			this.cmb_Department.ItemHeight = 15;
			this.cmb_Department.Location = new System.Drawing.Point(313, 59);
			this.cmb_Department.MatchEntryTimeout = ((long)(2000));
			this.cmb_Department.MaxDropDownItems = ((short)(5));
			this.cmb_Department.MaxLength = 32767;
			this.cmb_Department.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Department.Name = "cmb_Department";
			this.cmb_Department.PartialRightColumn = false;
			this.cmb_Department.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Department.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Department.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Department.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Department.Size = new System.Drawing.Size(322, 21);
			this.cmb_Department.TabIndex = 569;
			this.cmb_Department.TextChanged += new System.EventHandler(this.cmb_Department_TextChanged);
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(992, 131);
			this.picb_BR.Name = "picb_BR";
			this.picb_BR.Size = new System.Drawing.Size(13, 15);
			this.picb_BR.TabIndex = 186;
			this.picb_BR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(992, 0);
			this.picb_TR.Name = "picb_TR";
			this.picb_TR.Size = new System.Drawing.Size(24, 24);
			this.picb_TR.TabIndex = 185;
			this.picb_TR.TabStop = false;
			// 
			// picb_BM
			// 
			this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
			this.picb_BM.Location = new System.Drawing.Point(120, 130);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(880, 17);
			this.picb_BM.TabIndex = 184;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 131);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(144, 19);
			this.picb_BL.TabIndex = 183;
			this.picb_BL.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(216, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(792, 28);
			this.pictureBox1.TabIndex = 181;
			this.pictureBox1.TabStop = false;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.SystemColors.Window;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Navy;
			this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
			this.label11.Location = new System.Drawing.Point(-8, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(231, 30);
			this.label11.TabIndex = 182;
			this.label11.Text = "      Search Info.";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Pic_Emp
			// 
			this.Pic_Emp.Location = new System.Drawing.Point(887, 32);
			this.Pic_Emp.Name = "Pic_Emp";
			this.Pic_Emp.Size = new System.Drawing.Size(112, 104);
			this.Pic_Emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Pic_Emp.TabIndex = 180;
			this.Pic_Emp.TabStop = false;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ImageIndex = 0;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(8, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 24);
			this.label2.TabIndex = 157;
			this.label2.Text = "Dept Name";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_factory.Location = new System.Drawing.Point(112, 36);
			this.cmb_factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_factory.MaxDropDownItems = ((short)(5));
			this.cmb_factory.MaxLength = 32767;
			this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_factory.Name = "cmb_factory";
			this.cmb_factory.PartialRightColumn = false;
			this.cmb_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.lbl_factory.Location = new System.Drawing.Point(8, 36);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 152;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_ML
			// 
			this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 24);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(40, 112);
			this.picb_ML.TabIndex = 188;
			this.picb_ML.TabStop = false;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(907, 32);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(101, 112);
			this.picb_MR.TabIndex = 187;
			this.picb_MR.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Location = new System.Drawing.Point(1024, -104);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(908, 419);
			this.pictureBox6.TabIndex = 27;
			this.pictureBox6.TabStop = false;
			// 
			// statusBar1
			// 
			this.statusBar1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.statusBar1.Location = new System.Drawing.Point(0, 164);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1,
																						  this.statusBarPanel2});
			this.statusBar1.Size = new System.Drawing.Size(1024, 300);
			this.statusBar1.TabIndex = 43;
			// 
			// Form_Emp_Info
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 534);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_Emp_Info";
			this.Load += new System.EventHandler(this.Form_Emp_Info_Load);
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
			((System.ComponentModel.ISupportInitialize)(this.cmb_Position)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Training)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Department)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_Emp_Info_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "Employee Information";
			this.Text		   = "Training";
			fgrid_main.Set_Grid("SIM_EMPLOYEE_INFOR", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

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
				
			// factory set
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);
			cmb_factory.SelectedValue    = ClassLib.ComVar.This_Factory;	

			// Set cmb Dept
			vDt = SELECT_DEPT_LIST("");			
			COM.ComCtl.Set_ComboList(vDt, cmb_Department, 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);

			// cmb_Training set
			DataTable dt_ret = Select_TrainingList("");
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Training, 0, 1, true);

			// cmb_Position Set
			dt_ret = Select_PositionList("");
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Position, 0, 1, true);

		}

		public DataTable SELECT_DEPT_LIST(string arg_dep_name)
		{ 
			DataSet vDt;

			MyOraDB.ReDim_Parameter(2);

			string vProcedure = "PKG_SIM_TRAINEE.SELECT_SIM_DEPT";

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = vProcedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_DEPT_NAME";
			MyOraDB.Parameter_Name[ 1]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = COM.ComFunction.Empty_TextBox(txt_Dep, "");
			MyOraDB.Parameter_Values[ 1]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private DataTable Select_TrainingList(string arg_t_name)
		{
			 
			DataSet ds_ret;
			string process_name = "PKG_SIM_MASTER.SELECT_SIM_TRAINING_LIST";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_T_NAME";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


			//03.DATA TYPE 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의   
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = arg_t_name;
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}

		private DataTable Select_PositionList(string arg_t_name)
		{
			 
			DataSet ds_ret;
			string process_name = "PKG_SIM_MASTER.SELECT_EMP_POSITION";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_POSITION";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


			//03.DATA TYPE 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의   
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_Combo(cmb_Position, "");
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}

		private void txt_Emp_No_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
//			txt_Emp_Name.Text="";
//			if(e.KeyChar != 13 ||txt_Emp_No.Text =="") return;
//			Get_Emp_List(true); 
		}

		/*private void Get_Emp_List(bool arg_enter)
		{
			string vProcedure;
			try
			{
				if(! arg_enter) return;
				SELECT_EMP_LIST();
				vProcedure = "PKG_SIM_MASTER.SELECT_HISTORY_TRAINING";
				DataTable vDt = SELECT_HISTORY_TRAINING(vProcedure,txt_Emp_No.Text );		
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
				
				vProcedure = "PKG_SIM_MASTER.SELECT_EMP_INFOR";
				vDt = SELECT_HISTORY_TRAINING(vProcedure,txt_Emp_No.Text );		

				if (vDt.Rows.Count > 0)
				{
					txt_Address.Text= vDt.Rows[0].ItemArray[_Adress].ToString();
					txt_Dep_Name.Text= vDt.Rows[0].ItemArray[_Dep_Name].ToString();
					txt_Emp_Name.Text= vDt.Rows[0].ItemArray[_Emp_Name].ToString();
					txt_Join_Date.Text= vDt.Rows[0].ItemArray[_Join_Date].ToString();
					txt_Male.Text= vDt.Rows[0].ItemArray[_Male].ToString();
					txt_Position.Text= vDt.Rows[0].ItemArray[_Position].ToString();
					txt_Remark.Text= vDt.Rows[0].ItemArray[_Remark].ToString();
					txt_Resident.Text= vDt.Rows[0].ItemArray[_Resident].ToString();
					txt_Working.Text= vDt.Rows[0].ItemArray[_Working].ToString();
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
				}
				vProcedure = "PKG_SIM_MASTER.SELECT_EMP_PIC";
				vDt = SELECT_HISTORY_TRAINING(vProcedure,txt_Emp_No.Text );	
				if (vDt.Rows.Count > 0)
				{			
					byte[] t= (byte[])vDt.Rows[0].ItemArray[_Pic];
					System.IO.MemoryStream st= new System.IO.MemoryStream();
					st.Write(t,0,t.Length);
					System.Drawing.Image i =System.Drawing.Image.FromStream(st);
					Pic_Emp.Image=  i;
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
		}*/
		
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

		private void GridSetColor()
		{
			try
			{				
				string sLevel = "";
				CellRange vRange;

				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					vRange      = fgrid_main.GetCellRange(iRow, 1, iRow, fgrid_main.Cols.Count - 1);
					if (fgrid_main[iRow, _colTRAINED].ToString() == "N")
					{						
						vRange.StyleNew.BackColor = Color.LightBlue;
						//						if (fgrid_main[iRow, _colFOB_DIV].ToString() == "1")
						//							fgrid_main.GetCellRange(iRow, _colTRADE_CS_FOB, iRow, _colTRADE_FACTORY_FOB).StyleNew.BackColor = Color.FromArgb(240, 244, 250);
						//						else
						//							fgrid_main.GetCellRange(iRow, _colTRADE_CS_FOB, iRow, _colTRADE_FACTORY_FOB).StyleNew.BackColor = Color.Red;		

					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "GridSetColor", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}				
		}

		private void SELECT_EMP_LIST ()
		{
//			int iRow=fgrid_main.Rows.Count-1;
//
//			COM.ComVar.Parameter_PopUp		= new string[0];
//			Pop_Emp_List Pop_Emp  = new Pop_Emp_List(ClassLib.ComFunction.Empty_TextBox(txt_Emp_No,""),ClassLib.ComFunction.Empty_TextBox(txt_Emp_Name,""));
//			Pop_Emp.ShowDialog();
//
//			//Display Employee List
//			if (COM.ComVar.Parameter_PopUp.Length > 0)
//			{   
//				txt_Emp_No.Text=COM.ComVar.Parameter_PopUp[0];
//				COM.ComVar.Parameter_PopUp		= new string[0];
//			}
//
//			///////////////////////
//				
//			Pop_Emp.Dispose();		
		}

		
		public DataTable SELECT_HISTORY_TRAINING(string arg_procedure,string Emp_no)
		{ 
			DataSet vDt;

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_EMP_NO";
			MyOraDB.Parameter_Name[ 1]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_String (Emp_no, "");
			MyOraDB.Parameter_Values[ 1]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void txt_Emp_Name_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
//			txt_Emp_No.Text="";
//			if(e.KeyChar != 13|| txt_Emp_Name.Text =="") return;
//			Get_Emp_List(true); 
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			btn_New_Trainee();
		}
		private void btn_New_Trainee()
		{
			int iRow=fgrid_main.Rows.Count-1;

			COM.ComVar.Parameter_PopUp		= new string[0];
			Pop_Trainee_Outside Pop_Emp  = new Pop_Trainee_Outside();
			Pop_Emp.ShowDialog();				
			Pop_Emp.Dispose();		
		}

		private void txt_Dep_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar != 13) return;

			DataTable dt_ret = SELECT_DEPT_LIST (ClassLib.ComFunction.Empty_TextBox(txt_Dep , "") );
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Department, 0, 1, false);
		}

		private void txt_Training_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar != 13) return;

			Event_KeyPress_txt_Training(true); 
		}

		private void Event_KeyPress_txt_Training(bool arg_enter)
		{

			if(! arg_enter) return;

			DataTable dt_ret = Select_TrainingList(ClassLib.ComFunction.Empty_TextBox(txt_Training , "") );
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Training, 0, 1, false);
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
//			if (ClassLib.ComFunction.Empty_Combo(cmb_Department, "")== "" && ClassLib.ComFunction.Empty_Combo(cmb_Position, "")=="")
//			{
//				return;
//			}
			this.Tbtn_SearchProcess();
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SIM_MASTER.SELECT_EMP_LIST_BY_DEP";

				DataTable vDt = SELECT_EMP_LIST_BY_DEP(vProcedure);

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


		public DataTable SELECT_EMP_LIST_BY_DEP(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_DEP_CODE";
			MyOraDB.Parameter_Name[ 2]  = "ARG_POSITION";
			MyOraDB.Parameter_Name[ 3]  = "ARG_T_CODE";
			MyOraDB.Parameter_Name[ 4]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 4]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[ 1]   = ClassLib.ComFunction.Empty_Combo(cmb_Department, "");
			MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_Combo(cmb_Position, "");
			MyOraDB.Parameter_Values[ 3]   = ClassLib.ComFunction.Empty_Combo(cmb_Training, "");
			MyOraDB.Parameter_Values[ 4]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess();
		}

		private void Tbtn_PrintProcess()
		{
			try
			{
				PRINT_EMP_LIST_BY_DEP();
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

		private void PRINT_EMP_LIST_BY_DEP()
		{
			string sDir;
			
			sDir = FlexTraining.ClassLib.ComFunction.Set_RD_Directory("Form_Emp_List_By_Dep");

			string sPara;
			
			sPara  = " /rp ";
			sPara += "'" +  ClassLib.ComFunction.Empty_Combo(cmb_factory, " ")  +  "' ";			            //Parm1: Factory
			sPara += "'" +  ClassLib.ComFunction.Empty_Combo(cmb_Department , " ")+ "' ";					//Parm2: Dep
			sPara += "'" +  ClassLib.ComFunction.Empty_Combo(cmb_Position , " ")  + "' ";					    //Parm3: Position
			sPara += "'" +  ClassLib.ComFunction.Empty_Combo(cmb_Training , " ")  + "' ";						//Parm4: Program
			//sPara += "'" +  ""  +	"' ";                           							                //Parm5: Start date
			//sPara += "'" +  ""  +	"' ";														                //Parm6: Start date

			FlexTraining.Report.Form_RdViewer MyReport = new FlexTraining.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "Check List by Department and Program";
			MyReport.Show();
		}

		private void txt_Position_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar != 13) return;

			Event_KeyPress_txt_Position(true); 
		}

		private void Event_KeyPress_txt_Position(bool arg_enter)
		{

			if(! arg_enter) return;

			DataTable dt_ret = Select_PositionList(ClassLib.ComFunction.Empty_TextBox(txt_Position , "") );
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Position, 0, 1, true);
		}

		private void cmb_Department_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
		}
	}
}

