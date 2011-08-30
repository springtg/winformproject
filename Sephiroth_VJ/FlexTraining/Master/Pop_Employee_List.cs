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

namespace FlexTraining.Master
{
	public class Pop_Employee_List : COM.TrainingWinForm.Pop_Large
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel1;
		private COM.FSP fgrid_main;
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_factory;
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
		private System.Windows.Forms.Panel pnl_Menu;
		private System.Windows.Forms.StatusBar stbar;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label lb_Dept;
		private C1.Win.C1List.C1Combo cmb_Dept;
		private System.Windows.Forms.TextBox txt_Dept;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_Emp_No;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label cmd_Excel_File;
		private System.Windows.Forms.TextBox txt_Emp_Name;
		private System.Windows.Forms.OpenFileDialog Open_dialog;
		private System.Windows.Forms.CheckBox chk_Outside;
		private System.ComponentModel.IContainer components = null;

		public Pop_Employee_List()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public Pop_Employee_List(string T_Code, string T_Seq)
		{
			// This call is required by the Windows Form Designer.
			_T_CODE=T_Code;
			_SEQ=T_Seq;
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
		private int _Rowfixed;
        private string _SEQ;  		
		private string _T_CODE;  

		private int _colEMP_No    =  2;
		private int	_colEMP_NAME  =  3;
		private int	_colDept_CODE =  4;
		private int	_colDept_NAME =  5;
		private int	_colPost_NAME =  6;
		
		private int _colFACTORY 	 = (int)ClassLib.TBSIM_TRAINING_MASTER.IxFACTORY;
		private int _colT_CODE 	     = (int)ClassLib.TBSIM_TRAINING_MASTER.IxT_CODE;
		private int _colREMARK   	 = (int)ClassLib.TBSIM_TRAINING_MASTER.IxREMARK;		 

		#endregion

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Employee_List));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.chk_Outside = new System.Windows.Forms.CheckBox();
			this.cmd_Excel_File = new System.Windows.Forms.Label();
			this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
			this.txt_Emp_Name = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_Emp_No = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmb_Dept = new C1.Win.C1List.C1Combo();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.txt_Dept = new System.Windows.Forms.TextBox();
			this.lb_Dept = new System.Windows.Forms.Label();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pnl_Menu = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_apply = new System.Windows.Forms.Label();
			this.stbar = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			this.Open_dialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Dept)).BeginInit();
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
			this.c1ToolBar1.Location = new System.Drawing.Point(545, 4);
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
			this.tbtn_Save.Enabled = false;
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// tbtn_Delete
			// 
			this.tbtn_Delete.Enabled = false;
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(768, 23);
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
			this.c1Sizer1.GridDefinition = "23.0125523012552:False:True;68.6192468619247:False:False;0:False:True;8.368200836" +
				"82008:False:True;\t0.961538461538462:False:True;98.0769230769231:False:False;0.96" +
				"1538461538462:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 82);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(832, 478);
			this.c1Sizer1.SplitterWidth = 0;
			this.c1Sizer1.TabIndex = 28;
			this.c1Sizer1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.fgrid_main);
			this.panel1.Location = new System.Drawing.Point(8, 110);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(816, 328);
			this.panel1.TabIndex = 46;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:31;TextAlign:RightCenter;ImageAlign:CenterCenter;}\t" +
				"1{Width:24;TextAlign:RightCenter;ImageAlign:CenterCenter;}\t";
			this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Size = new System.Drawing.Size(816, 328);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 32;
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
			this.pnl_Search.Size = new System.Drawing.Size(832, 110);
			this.pnl_Search.TabIndex = 45;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.chk_Outside);
			this.pnl_SearchImage.Controls.Add(this.cmd_Excel_File);
			this.pnl_SearchImage.Controls.Add(this.txt_Emp_Name);
			this.pnl_SearchImage.Controls.Add(this.label4);
			this.pnl_SearchImage.Controls.Add(this.txt_Emp_No);
			this.pnl_SearchImage.Controls.Add(this.label3);
			this.pnl_SearchImage.Controls.Add(this.cmb_Dept);
			this.pnl_SearchImage.Controls.Add(this.cmb_factory);
			this.pnl_SearchImage.Controls.Add(this.lbl_factory);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.txt_Dept);
			this.pnl_SearchImage.Controls.Add(this.lb_Dept);
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
			this.pnl_SearchImage.Size = new System.Drawing.Size(818, 96);
			this.pnl_SearchImage.TabIndex = 20;
			// 
			// chk_Outside
			// 
			this.chk_Outside.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chk_Outside.Location = new System.Drawing.Point(616, 68);
			this.chk_Outside.Name = "chk_Outside";
			this.chk_Outside.Size = new System.Drawing.Size(72, 16);
			this.chk_Outside.TabIndex = 568;
			this.chk_Outside.Text = "Outside";
			// 
			// cmd_Excel_File
			// 
			this.cmd_Excel_File.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_Excel_File.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.cmd_Excel_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmd_Excel_File.ImageIndex = 0;
			this.cmd_Excel_File.ImageList = this.img_LongButton;
			this.cmd_Excel_File.Location = new System.Drawing.Point(688, 64);
			this.cmd_Excel_File.Name = "cmd_Excel_File";
			this.cmd_Excel_File.Size = new System.Drawing.Size(104, 23);
			this.cmd_Excel_File.TabIndex = 567;
			this.cmd_Excel_File.Text = "Load Excel File";
			this.cmd_Excel_File.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.cmd_Excel_File.Click += new System.EventHandler(this.label5_Click);
			// 
			// img_LongButton
			// 
			this.img_LongButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_LongButton.ImageSize = new System.Drawing.Size(100, 23);
			this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
			this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// txt_Emp_Name
			// 
			this.txt_Emp_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Emp_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Emp_Name.Location = new System.Drawing.Point(408, 65);
			this.txt_Emp_Name.MaxLength = 50;
			this.txt_Emp_Name.Name = "txt_Emp_Name";
			this.txt_Emp_Name.Size = new System.Drawing.Size(200, 21);
			this.txt_Emp_Name.TabIndex = 157;
			this.txt_Emp_Name.Text = "";
			this.txt_Emp_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ImageIndex = 0;
			this.label4.ImageList = this.img_Label;
			this.label4.Location = new System.Drawing.Point(320, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 21);
			this.label4.TabIndex = 156;
			this.label4.Text = "Emp_Name";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Emp_No
			// 
			this.txt_Emp_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Emp_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Emp_No.Location = new System.Drawing.Point(88, 65);
			this.txt_Emp_No.MaxLength = 8;
			this.txt_Emp_No.Name = "txt_Emp_No";
			this.txt_Emp_No.Size = new System.Drawing.Size(200, 21);
			this.txt_Emp_No.TabIndex = 155;
			this.txt_Emp_No.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(8, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 21);
			this.label3.TabIndex = 154;
			this.label3.Text = "Emp_No";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Dept
			// 
			this.cmb_Dept.AddItemCols = 0;
			this.cmb_Dept.AddItemSeparator = ';';
			this.cmb_Dept.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Dept.AutoSize = false;
			this.cmb_Dept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Dept.Caption = "";
			this.cmb_Dept.CaptionHeight = 17;
			this.cmb_Dept.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Dept.ColumnCaptionHeight = 18;
			this.cmb_Dept.ColumnFooterHeight = 18;
			this.cmb_Dept.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Dept.ContentHeight = 17;
			this.cmb_Dept.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Dept.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Dept.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_Dept.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Dept.EditorHeight = 17;
			this.cmb_Dept.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Dept.GapHeight = 2;
			this.cmb_Dept.ItemHeight = 15;
			this.cmb_Dept.Location = new System.Drawing.Point(552, 40);
			this.cmb_Dept.MatchEntryTimeout = ((long)(2000));
			this.cmb_Dept.MaxDropDownItems = ((short)(5));
			this.cmb_Dept.MaxLength = 32767;
			this.cmb_Dept.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Dept.Name = "cmb_Dept";
			this.cmb_Dept.PartialRightColumn = false;
			this.cmb_Dept.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Dept.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Dept.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Dept.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Dept.Size = new System.Drawing.Size(240, 21);
			this.cmb_Dept.TabIndex = 153;
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
			this.cmb_factory.Location = new System.Drawing.Point(88, 40);
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
			this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 40);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(72, 21);
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
			this.picb_MR.Location = new System.Drawing.Point(717, 30);
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
			this.picb_BR.Location = new System.Drawing.Point(804, 81);
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
			this.picb_TM.Size = new System.Drawing.Size(583, 28);
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
			// txt_Dept
			// 
			this.txt_Dept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Dept.Location = new System.Drawing.Point(408, 40);
			this.txt_Dept.MaxLength = 8;
			this.txt_Dept.Name = "txt_Dept";
			this.txt_Dept.Size = new System.Drawing.Size(144, 21);
			this.txt_Dept.TabIndex = 150;
			this.txt_Dept.Text = "";
			this.txt_Dept.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dept_KeyPress);
			// 
			// lb_Dept
			// 
			this.lb_Dept.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lb_Dept.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_Dept.ImageIndex = 0;
			this.lb_Dept.ImageList = this.img_Label;
			this.lb_Dept.Location = new System.Drawing.Point(320, 40);
			this.lb_Dept.Name = "lb_Dept";
			this.lb_Dept.Size = new System.Drawing.Size(80, 21);
			this.lb_Dept.TabIndex = 149;
			this.lb_Dept.Text = "Dept";
			this.lb_Dept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(802, 0);
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
			this.picb_BM.Size = new System.Drawing.Size(682, 17);
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
			this.pictureBox6.Size = new System.Drawing.Size(716, 58);
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
			this.pnl_Menu.Controls.Add(this.label2);
			this.pnl_Menu.Controls.Add(this.label1);
			this.pnl_Menu.Controls.Add(this.btn_apply);
			this.pnl_Menu.Location = new System.Drawing.Point(8, 438);
			this.pnl_Menu.Name = "pnl_Menu";
			this.pnl_Menu.Size = new System.Drawing.Size(824, 40);
			this.pnl_Menu.TabIndex = 44;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label2.ImageIndex = 0;
			this.label2.ImageList = this.img_LongButton;
			this.label2.Location = new System.Drawing.Point(600, 8);
			this.label2.Name = "label2";
			this.label2.TabIndex = 568;
			this.label2.Text = "Clear All";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_LongButton;
			this.label1.Location = new System.Drawing.Point(496, 8);
			this.label1.Name = "label1";
			this.label1.TabIndex = 567;
			this.label1.Text = "Get All";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// btn_apply
			// 
			this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btn_apply.ImageIndex = 0;
			this.btn_apply.ImageList = this.img_LongButton;
			this.btn_apply.Location = new System.Drawing.Point(704, 8);
			this.btn_apply.Name = "btn_apply";
			this.btn_apply.TabIndex = 566;
			this.btn_apply.Text = "Apply";
			this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
			// 
			// stbar
			// 
			this.stbar.Location = new System.Drawing.Point(0, 438);
			this.stbar.Name = "stbar";
			this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																					 this.statusBarPanel1,
																					 this.statusBarPanel2});
			this.stbar.Size = new System.Drawing.Size(832, 40);
			this.stbar.TabIndex = 43;
			// 
			// Pop_Employee_List
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(832, 566);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Pop_Employee_List";
			this.Load += new System.EventHandler(this.Pop_Employee_List_Load);
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
			((System.ComponentModel.ISupportInitialize)(this.cmb_Dept)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.pnl_Menu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Pop_Employee_List_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		
		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "Employee List";
			this.Text		   = "Training";


			// grid set
			fgrid_main.Set_Grid("SIM_EMPLOYEE", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

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
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
			cmb_factory.SelectedValue    = ClassLib.ComVar.This_Factory;
			
			txt_Dept.Select();
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

				string vProcedure     = "PKG_SIM_TRAINEE.SELECT_SIM_EMPLOYEE";

				DataTable vDt = SELECT_SIM_EMPLOYEE(vProcedure);

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

		public DataTable SELECT_SIM_EMPLOYEE(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(8);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_T_CODE";
			MyOraDB.Parameter_Name[ 2]  = "ARG_SEQ";
			MyOraDB.Parameter_Name[ 3]  = "ARG_EMP_NO";
			MyOraDB.Parameter_Name[ 4]  = "ARG_EMP_NAME";
			MyOraDB.Parameter_Name[ 5]  = "ARG_DEPT_CODE";
			MyOraDB.Parameter_Name[ 6]  = "ARG_OUTSIDE";
			MyOraDB.Parameter_Name[ 7]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;			
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.VarChar;		
			MyOraDB.Parameter_Type[ 4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 6]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 7]	= (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = "VJ";
			MyOraDB.Parameter_Values[ 1]   = _T_CODE.ToString();
			MyOraDB.Parameter_Values[ 2]   = _SEQ.ToString();
			MyOraDB.Parameter_Values[ 3]   = ClassLib.ComFunction.Empty_TextBox(txt_Emp_No, "________");
			MyOraDB.Parameter_Values[ 4]   = ClassLib.ComFunction.Empty_TextBox(txt_Emp_Name, "________");
			MyOraDB.Parameter_Values[ 5]   = ClassLib.ComFunction.Empty_Combo(cmb_Dept, "");
			MyOraDB.Parameter_Values[ 6]   = (chk_Outside.Checked) ? "Y" : "N";
			MyOraDB.Parameter_Values[ 7]   = "";

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

		
		private void Get_Training_List(bool arg_enter)
		{
			if(! arg_enter) return;

			string vProcedure = "PKG_SIM_TRAINEE.SELECT_SIM_DEPT";

			DataTable dt_ret = SELECT_DEPT_LIST(vProcedure);			
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Dept, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
		}
		
		public DataTable SELECT_DEPT_LIST(string arg_procedure)
		{ 
			DataSet vDt;

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_DEPT_NAME";
			MyOraDB.Parameter_Name[ 1]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_TextBox(txt_Dept, "");
			MyOraDB.Parameter_Values[ 1]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void txt_Dept_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar != 13) return;

			Get_Training_List(true); 
		}

		private void label1_Click(object sender, System.EventArgs e)
		{
			for (int i=3;i<= fgrid_main.Rows.Count-1;i++)
			{
				fgrid_main[i,1]=true;
			}
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
            this.btn_ApplyProcess();
		}

		private void btn_ApplyProcess()
		{
			int _RowCount=0;
			for (int i=3;i<= fgrid_main.Rows.Count-1;i++)
			{
				if (fgrid_main[i,1].ToString()=="True")
				{
					_RowCount++;
				}
			}
			int _PopupPara =_RowCount*5;
			COM.ComVar.Parameter_PopUp		= new string[_PopupPara];
			_RowCount=0;
			for (int i=3;i<= fgrid_main.Rows.Count-1;i++)
			{
				if (fgrid_main[i,1].ToString()=="True")
				{
					COM.ComVar.Parameter_PopUp[(_RowCount*5)+0] = ClassLib.ComFunction.Empty_String(fgrid_main[i, _colEMP_No].ToString(),"");
					COM.ComVar.Parameter_PopUp[(_RowCount*5)+1] = ClassLib.ComFunction.Empty_String(fgrid_main[i, _colEMP_NAME].ToString(),"");
					//COM.ComVar.Parameter_PopUp[(_RowCount*5)+2] = ClassLib.ComFunction.Empty_Combo(cmb_Dept, "");
					COM.ComVar.Parameter_PopUp[(_RowCount*5)+2] = ClassLib.ComFunction.Empty_String(fgrid_main[i, _colDept_CODE].ToString(),"");
					COM.ComVar.Parameter_PopUp[(_RowCount*5)+3] = ClassLib.ComFunction.Empty_String(fgrid_main[i, _colDept_NAME].ToString(),"");
					COM.ComVar.Parameter_PopUp[(_RowCount*5)+4] = ClassLib.ComFunction.NullToBlank(fgrid_main[i, _colPost_NAME]);
					_RowCount++;
				}
			}
			this.Dispose();			
		}

		private void label2_Click(object sender, System.EventArgs e)
		{
			for (int i=3;i<= fgrid_main.Rows.Count-1;i++)
			{
				fgrid_main[i,1]=false;
			}
		}

		private void label5_Click(object sender, System.EventArgs e)
		{		
			string File_Path;
			Open_dialog.ShowDialog();
			File_Path=Open_dialog.FileName.ToString();
			Select_FOB_List(File_Path);
		}

		
		private void Select_FOB_List(string _Path)

		{

			string LST_EMP_NO;
			//OleDbDataReader reader;

 
//			string strSrc = txt_UploadFile.Text;
			
			string strSrc = _Path;

 

			OleDbConnection AdoConn = null;

//			OleDbDataAdapter oraDA = null;

			DataSet oraDS = new DataSet("OraDataSet");

   

 

//			string path = txt_UploadFile.Text.Trim(); 

			string path =_Path.Trim(); 

			string ExcelCon=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+path+";Excel 8.0;Imex=1;HDR=YES";                  

			

			AdoConn = new OleDbConnection(ExcelCon);

			AdoConn.Close();

			AdoConn.Open();

			OleDbCommand myCommand = new OleDbCommand("Select * from [Sheet1$];");
			
			myCommand.Connection = AdoConn;

			OleDbDataReader myReader = myCommand.ExecuteReader();

			LST_EMP_NO="'";

			while (myReader.Read())

			{

				// it can read upto 5 columns means A to E. In your case if the requirement is different then change the loop limits a/c to it.
				if (myReader.FieldCount > 1)
					LST_EMP_NO =  myReader.GetValue(1).ToString().PadLeft(8, '0');
				else
					LST_EMP_NO = myReader.GetValue(0).ToString().PadLeft(8,'0');
				Tbtn_Search_List(LST_EMP_NO);
			}
			
//			LST_EMP_NO = LST_EMP_NO.Substring(0,LST_EMP_NO.Length-1);
			AdoConn.Close();
		}
		
		private void Tbtn_Search_List( string LST_EMP_NO)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SIM_TRAINEE.SELECT_SIM_EMPLOYEE_LIST";

				DataTable vDt = SELECT_SIM_EMPLOYEE_LIST(vProcedure,LST_EMP_NO);

//				Clear_FlexGrid();
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

		public DataTable SELECT_SIM_EMPLOYEE_LIST(string arg_procedure ,string LST_EMP_NO)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_T_CODE";
			MyOraDB.Parameter_Name[ 2]  = "ARG_SEQ";
			MyOraDB.Parameter_Name[ 3]  = "ARG_EMP_NO_LIST";
			MyOraDB.Parameter_Name[ 4]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;			
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.VarChar;		
			MyOraDB.Parameter_Type[ 4]	= (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = "VJ";
			MyOraDB.Parameter_Values[ 1]   = _T_CODE.ToString();
			MyOraDB.Parameter_Values[ 2]   = _SEQ.ToString();
			MyOraDB.Parameter_Values[ 3]   = ClassLib.ComFunction.Empty_String(LST_EMP_NO,"________");
			MyOraDB.Parameter_Values[ 4]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}



		private void textBox2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			this.txt_Emp_No.Text="";
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
		}
	}
}

