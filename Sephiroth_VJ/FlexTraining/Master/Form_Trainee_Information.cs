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
	public class Form_Trainee_Information : COM.TrainingWinForm.Form_Top
	{
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.ImageList img_LongButton;
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txt_T_Code;
		private System.Windows.Forms.TextBox txt_Seq;
		private System.Windows.Forms.TextBox txt_Wave;
		private System.Windows.Forms.TextBox txt_Group;
		private System.Windows.Forms.Label btn_trainee;
		private System.Windows.Forms.Label lbl_Wave;
		private System.Windows.Forms.Label lbl_Sequence;
		private System.Windows.Forms.Label lbl_Group;
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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel pnl_Menu;
		private System.Windows.Forms.Label btn_Delete;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel2;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.PictureBox Pic_Emp;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rad_lvl2;
		private System.Windows.Forms.RadioButton rad_lvl1;
		private System.ComponentModel.IContainer components = null;

		public Form_Trainee_Information(string [] arg_keys)
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			_vfactory	= arg_keys[0];
			_vt_code	= arg_keys[1];
			_vt_name	= arg_keys[2];
			_vseq	    = arg_keys[3];

			// TODO: Add any initialization after the InitializeComponent call
		}

		#region User Define Variable

		private COM.OraDB MyOraDB  = new COM.OraDB();
		private int _Rowfixed, _vFlag;
		private string _vfactory, _vt_code, _vt_name, _vseq;

		private int _colLEVEL     =  1;
		private int _colEMP_No    =  2;
		private int _colEMP_No2   =  3;
		private int	_colEMP_NAME  =  4;
		private int	_colDept_CODE =  5;
		private int	_colDept_NAME =  6;
		private int	_colDept_NAME2 =  7;
		private int	_colPost_NAME =  8;
		private int _colGRADE	  =	 9;
		private int _colUNSCHEDULE	  =	 10;
		private int	_colREMARK    =  11;
		private int _Pic = 0;
		
		private int _colT_NAME	    	= (int) ClassLib.TBSIM_TRAINING_MGNT.IxT_NAME;
		private int _colSEQ	        	= (int) ClassLib.TBSIM_TRAINING_MGNT.IxSEQ;
		
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Trainee_Information));
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rad_lvl2 = new System.Windows.Forms.RadioButton();
			this.rad_lvl1 = new System.Windows.Forms.RadioButton();
			this.Pic_Emp = new System.Windows.Forms.PictureBox();
			this.txt_T_Code = new System.Windows.Forms.TextBox();
			this.txt_Seq = new System.Windows.Forms.TextBox();
			this.txt_Wave = new System.Windows.Forms.TextBox();
			this.txt_Group = new System.Windows.Forms.TextBox();
			this.btn_trainee = new System.Windows.Forms.Label();
			this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
			this.lbl_Wave = new System.Windows.Forms.Label();
			this.lbl_Sequence = new System.Windows.Forms.Label();
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
			this.label2 = new System.Windows.Forms.Label();
			this.pnl_Menu = new System.Windows.Forms.Panel();
			this.btn_Delete = new System.Windows.Forms.Label();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.panel3.SuspendLayout();
			this.groupBox1.SuspendLayout();
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
			// tbtn_Delete
			// 
			this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
			// 
			// stbar
			// 
			this.stbar.Location = new System.Drawing.Point(0, 624);
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
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.c1Sizer1);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(0, 80);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1016, 544);
			this.pnl_SearchImage.TabIndex = 29;
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
			this.c1Sizer1.GridDefinition = "26.7857142857143:False:True;60.8928571428571:False:False;8.39285714285714:False:T" +
				"rue;3.92857142857143:False:True;\t0.784313725490196:False:True;98.1372549019608:F" +
				"alse:False;1.07843137254902:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(-2, -8);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1020, 560);
			this.c1Sizer1.SplitterWidth = 0;
			this.c1Sizer1.TabIndex = 31;
			this.c1Sizer1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.fgrid_main);
			this.panel2.Location = new System.Drawing.Point(8, 150);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1001, 341);
			this.panel2.TabIndex = 46;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.Color.Lavender;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Size = new System.Drawing.Size(1001, 341);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:Lavender;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 33;
			this.fgrid_main.Click += new System.EventHandler(this.fgrid_main_Click);
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
			this.pnl_Search.Size = new System.Drawing.Size(1009, 150);
			this.pnl_Search.TabIndex = 45;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Window;
			this.panel3.Controls.Add(this.groupBox1);
			this.panel3.Controls.Add(this.Pic_Emp);
			this.panel3.Controls.Add(this.txt_T_Code);
			this.panel3.Controls.Add(this.txt_Seq);
			this.panel3.Controls.Add(this.txt_Wave);
			this.panel3.Controls.Add(this.txt_Group);
			this.panel3.Controls.Add(this.btn_trainee);
			this.panel3.Controls.Add(this.lbl_Wave);
			this.panel3.Controls.Add(this.lbl_Sequence);
			this.panel3.Controls.Add(this.lbl_Group);
			this.panel3.Controls.Add(this.txt_Training);
			this.panel3.Controls.Add(this.cmb_factory);
			this.panel3.Controls.Add(this.lbl_factory);
			this.panel3.Controls.Add(this.picb_MR);
			this.panel3.Controls.Add(this.picb_BR);
			this.panel3.Controls.Add(this.picb_TM);
			this.panel3.Controls.Add(this.lbl_SubTitle1);
			this.panel3.Controls.Add(this.lbl_Training);
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
			this.panel3.Size = new System.Drawing.Size(995, 136);
			this.panel3.TabIndex = 18;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.rad_lvl2);
			this.groupBox1.Controls.Add(this.rad_lvl1);
			this.groupBox1.Location = new System.Drawing.Point(656, 93);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(192, 39);
			this.groupBox1.TabIndex = 570;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tree View Option";
			// 
			// rad_lvl2
			// 
			this.rad_lvl2.Location = new System.Drawing.Point(112, 19);
			this.rad_lvl2.Name = "rad_lvl2";
			this.rad_lvl2.Size = new System.Drawing.Size(72, 16);
			this.rad_lvl2.TabIndex = 35;
			this.rad_lvl2.Tag = "2";
			this.rad_lvl2.Text = "Detail";
			this.rad_lvl2.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// rad_lvl1
			// 
			this.rad_lvl1.Location = new System.Drawing.Point(16, 19);
			this.rad_lvl1.Name = "rad_lvl1";
			this.rad_lvl1.Size = new System.Drawing.Size(80, 16);
			this.rad_lvl1.TabIndex = 34;
			this.rad_lvl1.Tag = "1";
			this.rad_lvl1.Text = "Trainee";
			this.rad_lvl1.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// Pic_Emp
			// 
			this.Pic_Emp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Pic_Emp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Pic_Emp.Location = new System.Drawing.Point(872, 24);
			this.Pic_Emp.Name = "Pic_Emp";
			this.Pic_Emp.Size = new System.Drawing.Size(120, 112);
			this.Pic_Emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Pic_Emp.TabIndex = 569;
			this.Pic_Emp.TabStop = false;
			// 
			// txt_T_Code
			// 
			this.txt_T_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_T_Code.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_T_Code.Location = new System.Drawing.Point(109, 64);
			this.txt_T_Code.MaxLength = 20;
			this.txt_T_Code.Name = "txt_T_Code";
			this.txt_T_Code.Size = new System.Drawing.Size(112, 21);
			this.txt_T_Code.TabIndex = 568;
			this.txt_T_Code.Text = "";
			// 
			// txt_Seq
			// 
			this.txt_Seq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Seq.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Seq.Location = new System.Drawing.Point(109, 88);
			this.txt_Seq.MaxLength = 20;
			this.txt_Seq.Name = "txt_Seq";
			this.txt_Seq.Size = new System.Drawing.Size(112, 21);
			this.txt_Seq.TabIndex = 567;
			this.txt_Seq.Text = "";
			// 
			// txt_Wave
			// 
			this.txt_Wave.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txt_Wave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Wave.Enabled = false;
			this.txt_Wave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Wave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txt_Wave.Location = new System.Drawing.Point(616, 64);
			this.txt_Wave.MaxLength = 20;
			this.txt_Wave.Name = "txt_Wave";
			this.txt_Wave.Size = new System.Drawing.Size(112, 22);
			this.txt_Wave.TabIndex = 566;
			this.txt_Wave.Text = "";
			// 
			// txt_Group
			// 
			this.txt_Group.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txt_Group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Group.Enabled = false;
			this.txt_Group.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Group.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txt_Group.Location = new System.Drawing.Point(616, 40);
			this.txt_Group.MaxLength = 20;
			this.txt_Group.Name = "txt_Group";
			this.txt_Group.Size = new System.Drawing.Size(232, 22);
			this.txt_Group.TabIndex = 565;
			this.txt_Group.Text = "";
			// 
			// btn_trainee
			// 
			this.btn_trainee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_trainee.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_trainee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btn_trainee.ImageIndex = 0;
			this.btn_trainee.ImageList = this.img_LongButton;
			this.btn_trainee.Location = new System.Drawing.Point(746, 64);
			this.btn_trainee.Name = "btn_trainee";
			this.btn_trainee.TabIndex = 564;
			this.btn_trainee.Text = "Creating Trainee";
			this.btn_trainee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_trainee.Click += new System.EventHandler(this.btn_trainee_Click);
			// 
			// img_LongButton
			// 
			this.img_LongButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_LongButton.ImageSize = new System.Drawing.Size(100, 23);
			this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
			this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lbl_Wave
			// 
			this.lbl_Wave.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Wave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Wave.ImageIndex = 0;
			this.lbl_Wave.ImageList = this.img_Label;
			this.lbl_Wave.Location = new System.Drawing.Point(520, 64);
			this.lbl_Wave.Name = "lbl_Wave";
			this.lbl_Wave.Size = new System.Drawing.Size(100, 21);
			this.lbl_Wave.TabIndex = 160;
			this.lbl_Wave.Text = "Wave";
			this.lbl_Wave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Sequence
			// 
			this.lbl_Sequence.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Sequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Sequence.ImageIndex = 0;
			this.lbl_Sequence.ImageList = this.img_Label;
			this.lbl_Sequence.Location = new System.Drawing.Point(8, 87);
			this.lbl_Sequence.Name = "lbl_Sequence";
			this.lbl_Sequence.Size = new System.Drawing.Size(100, 21);
			this.lbl_Sequence.TabIndex = 158;
			this.lbl_Sequence.Text = "Sequence";
			this.lbl_Sequence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Group
			// 
			this.lbl_Group.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Group.ImageIndex = 0;
			this.lbl_Group.ImageList = this.img_Label;
			this.lbl_Group.Location = new System.Drawing.Point(520, 40);
			this.lbl_Group.Name = "lbl_Group";
			this.lbl_Group.Size = new System.Drawing.Size(100, 21);
			this.lbl_Group.TabIndex = 156;
			this.lbl_Group.Text = "Group";
			this.lbl_Group.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Training
			// 
			this.txt_Training.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Training.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Training.Location = new System.Drawing.Point(223, 64);
			this.txt_Training.MaxLength = 20;
			this.txt_Training.Name = "txt_Training";
			this.txt_Training.Size = new System.Drawing.Size(272, 21);
			this.txt_Training.TabIndex = 154;
			this.txt_Training.Text = "";
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
			this.picb_MR.Location = new System.Drawing.Point(894, 30);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(101, 98);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(981, 121);
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
			this.picb_TM.Size = new System.Drawing.Size(760, 28);
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
			this.lbl_Training.Location = new System.Drawing.Point(8, 64);
			this.lbl_Training.Name = "lbl_Training";
			this.lbl_Training.Size = new System.Drawing.Size(100, 21);
			this.lbl_Training.TabIndex = 149;
			this.lbl_Training.Text = "Training";
			this.lbl_Training.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(979, 0);
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
			this.picb_BM.Location = new System.Drawing.Point(123, 120);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(859, 17);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 121);
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
			this.picb_ML.Size = new System.Drawing.Size(144, 105);
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
			this.pictureBox6.Size = new System.Drawing.Size(893, 98);
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
			// pnl_Menu
			// 
			this.pnl_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Menu.BackColor = System.Drawing.Color.Transparent;
			this.pnl_Menu.Controls.Add(this.btn_Delete);
			this.pnl_Menu.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_Menu.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.pnl_Menu.Location = new System.Drawing.Point(8, 491);
			this.pnl_Menu.Name = "pnl_Menu";
			this.pnl_Menu.Size = new System.Drawing.Size(1001, 47);
			this.pnl_Menu.TabIndex = 44;
			// 
			// btn_Delete
			// 
			this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Delete.ImageIndex = 1;
			this.btn_Delete.ImageList = this.img_Button;
			this.btn_Delete.Location = new System.Drawing.Point(901, 8);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(80, 23);
			this.btn_Delete.TabIndex = 351;
			this.btn_Delete.Text = "Delete All";
			this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			this.btn_Delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Delete_MouseUp);
			this.btn_Delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Delete_MouseDown);
			// 
			// statusBar1
			// 
			this.statusBar1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.statusBar1.Location = new System.Drawing.Point(0, 491);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1,
																						  this.statusBarPanel2});
			this.statusBar1.Size = new System.Drawing.Size(1020, 69);
			this.statusBar1.TabIndex = 43;
			// 
			// Form_Trainee_Information
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1016, 646);
			this.Controls.Add(this.pnl_SearchImage);
			this.Name = "Form_Trainee_Information";
			this.Load += new System.EventHandler(this.Form_Trainee_Information_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.pnl_SearchImage, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.pnl_Menu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

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
			MyOraDB.Parameter_Values[ 0]   = _vfactory;
			MyOraDB.Parameter_Values[ 1]   = _vt_code;
			MyOraDB.Parameter_Values[ 2]   = _vseq;
			MyOraDB.Parameter_Values[ 3]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}


		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Validate_Check())
			{
				if (_vFlag == 2)
				{
					if(ClassLib.ComFunction.User_Message("If you delete this data, also delete Attendance data. Are you sure?","Delete", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
						this.Tbtn_SaveProcess();					
				}
				else
					if(ClassLib.ComFunction.User_Message("Do you want to save the changes you made?","Save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
					this.Tbtn_SaveProcess();					
			}			
		
		}

		private bool Validate_Check()
		{
			for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
			{
				if ((fgrid_main[iRow, _colEMP_NAME].ToString().Replace(" ", "").Trim().Length == 0) )
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

				if (SAVE_SIM_TRAINEE_INFO(true))
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

		public bool SAVE_SIM_TRAINEE_INFO(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 10;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SIM_TRAINEE.SAVE_SIM_TRAINEE_INFO";

				//02.ARGURMENT NAME
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 2] = "ARG_T_CODE";
				MyOraDB.Parameter_Name[ 3] = "ARG_SEQ";
				MyOraDB.Parameter_Name[ 4] = "ARG_EMP_NO";
				MyOraDB.Parameter_Name[ 5] = "ARG_DEPT_CODE";
				MyOraDB.Parameter_Name[ 6] = "ARG_GRADE";
				MyOraDB.Parameter_Name[ 7] = "ARG_UNSCHEDULE";
				MyOraDB.Parameter_Name[ 8] = "ARG_REMARK";
				MyOraDB.Parameter_Name[ 9] = "ARG_UPDATE_USER";

				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
						save_ct += 1;
				
				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					//if(fgrid_main[iRow, 0].ToString() != "")
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals(""))
					{
						MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main[iRow, 0].ToString();
						MyOraDB.Parameter_Values[para_ct+ 1] = _vfactory;
						MyOraDB.Parameter_Values[para_ct+ 2] = _vt_code;
						MyOraDB.Parameter_Values[para_ct+ 3] = _vseq;
						MyOraDB.Parameter_Values[para_ct+ 4] = fgrid_main[iRow, _colEMP_No].ToString();
						MyOraDB.Parameter_Values[para_ct+ 5] = fgrid_main[iRow, _colDept_CODE].ToString();
						MyOraDB.Parameter_Values[para_ct+ 6] = ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colGRADE]);
						if ( ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colUNSCHEDULE])=="False"||ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colUNSCHEDULE])==""							)
							MyOraDB.Parameter_Values[para_ct+ 7] = "Y";
						else
							MyOraDB.Parameter_Values[para_ct+ 7] = "N";

						MyOraDB.Parameter_Values[para_ct+ 8] = ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colREMARK]);
						MyOraDB.Parameter_Values[para_ct+ 9] = COM.ComVar.This_User;

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

		private void btn_trainee_Click(object sender, System.EventArgs e)
		{
			int _i;
			int _Addrows;
			int iRow=fgrid_main.Rows.Count-1;

			COM.ComVar.Parameter_PopUp		= new string[0];
			Pop_Employee_List pop_employee  = new Pop_Employee_List(_vt_code,_vseq);
			pop_employee.ShowDialog();

			//Display Employee List
			if (COM.ComVar.Parameter_PopUp.Length > 1)
			{   
				_Addrows=(int)COM.ComVar.Parameter_PopUp.Length /5;				
				fgrid_main.Rows.Count=iRow+_Addrows+1;
				for (_i=0;_i<_Addrows;_i++)
				{
					//					fgrid_main.Add_Row(iRow);
					fgrid_main[iRow+_i+1, 0]    = "I";
					fgrid_main[iRow+_i+1, _colEMP_No]    = COM.ComVar.Parameter_PopUp[(_i*5)+0];
					fgrid_main[iRow+_i+1, _colEMP_NAME]  = COM.ComVar.Parameter_PopUp[(_i*5)+1];
					fgrid_main[iRow+_i+1, _colDept_CODE] = COM.ComVar.Parameter_PopUp[(_i*5)+2];
					fgrid_main[iRow+_i+1, _colDept_NAME] = COM.ComVar.Parameter_PopUp[(_i*5)+3];
					fgrid_main[iRow+_i+1, _colPost_NAME] = COM.ComVar.Parameter_PopUp[(_i*5)+4];
					fgrid_main.Update_Row (iRow+_i+1);
				}
				COM.ComVar.Parameter_PopUp		= new string[0];
			}

			///////////////////////
			
			pop_employee.Dispose();		
		}
		
		private void btn_Delete_Click(object sender, System.EventArgs e)
		{			
			int iLevel;

			for (int iRow = _Rowfixed; iRow < fgrid_main.Rows.Count; iRow++)
			{
				iLevel = Convert.ToInt32(fgrid_main[iRow,_colLEVEL].ToString() );
				if (iLevel == 1)
					fgrid_main.Delete_Row(iRow);
			}
			_vFlag = 2;
		}
        
		private void Form_Trainee_Information_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		

		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "Trainee Information";
			this.Text		   = "Trainee Infomation";
			cmb_factory.Enabled = false;
			txt_Training.Enabled = false;
			txt_T_Code.Enabled = false;
			txt_Seq.Enabled = false;
			txt_Group.Enabled = false;
			txt_Wave.Enabled = false;
			_vFlag = 0;


			// grid set
			fgrid_main.Set_Grid("SIM_TRAINEE_INFO", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			_Rowfixed = fgrid_main.Rows.Fixed;
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";

			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

			//fgrid_main.Styles.Frozen.BackColor = Color.Lavender; 			
			//fgrid_main.KeyActionEnter = KeyActionEnum.MoveAcross;
			//fgrid_main.KeyActionTab = KeyActionEnum.MoveAcross;  
			//fgrid_main.SelectionMode = SelectionModeEnum.Cell;

			DataTable vDt;
				
			// factory set
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
			cmb_factory.SelectedValue    = ClassLib.ComVar.This_Factory;

			txt_T_Code.Text    = _vt_code;
			txt_Training.Text  = _vt_name;
			txt_Seq.Text       = _vseq;
			
			if (txt_Seq.Text != null)
			{
				DataTable dt_ret =GET_GROUPWAVE();	
				if (dt_ret.Rows.Count>0)
				{
					txt_Group.Text=dt_ret.Rows[0].ItemArray[0].ToString();
					txt_Wave.Text=dt_ret.Rows[0].ItemArray[1].ToString();
				}
			}
		}
		private void btn_Insert_Click(object sender, System.EventArgs e)
		{
			try
			{				
				int iRow = fgrid_main.Rows.Count;

				fgrid_main.Add_Row(iRow-1);

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

		private void btn_Delete_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Delete.ImageIndex=5;
		}

		private void btn_Delete_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Delete.ImageIndex=4;
		}
		
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();
			_vFlag = 0;
		}
		
		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SIM_TRAINEE.SELECT_SIM_TRAINEE_INFO1";

				DataTable vDt = SELECT_SIM_TRAINEE(vProcedure);

				Clear_FlexGrid();
				_vFlag = 0;
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

		private void Display_FlexGrid(DataTable arg_dt)
		{
			int iRow_fixed = fgrid_main.Rows.Fixed;
			int iLevel = 0; 
			int iCount = arg_dt.Rows.Count;

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{
				iLevel = Convert.ToInt32(arg_dt.Rows[iRow].ItemArray[_colLEVEL-1].ToString() );
				C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(iRow_fixed + iRow, iLevel);


				// design setting
//				if (iLevel == 1)
//				{										
//					
//					fgrid_main.Cols[_colSTYLE_CD].Style.DataType = typeof(string);
//					fgrid_main.Cols[  _colGEN_NM].Style.DataType = typeof(string);
//
//					fgrid_main.Rows[newRow.Row.Index].AllowEditing = false;
//					
//				}

				for (int iCol = 1 ; iCol <= arg_dt.Columns.Count ; iCol++)
				{
					fgrid_main[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
				}

				fgrid_main.Tree.Column = _colEMP_No;
				

			}
			GridSetColor();

			rad_lvl1.Checked = true;
			fgrid_main.Tree.Show(1); 

		}

		private void Display_FlexGrid_1(DataTable arg_dt)
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

		// set grid color
		private void GridSetColor()
		{
			try
			{				
				string sLevel = "";
				CellRange vRange;

				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					sLevel      = fgrid_main[iRow, _colLEVEL].ToString();
					vRange      = fgrid_main.GetCellRange(iRow, 1, iRow, fgrid_main.Cols.Count - 1);
					if (sLevel.Equals("1"))
					{						
						vRange.StyleNew.BackColor = Color.Lavender;
//						if (fgrid_main[iRow, _colFOB_DIV].ToString() == "1")
//							fgrid_main.GetCellRange(iRow, _colTRADE_CS_FOB, iRow, _colTRADE_FACTORY_FOB).StyleNew.BackColor = Color.FromArgb(240, 244, 250);
//						else
//							fgrid_main.GetCellRange(iRow, _colTRADE_CS_FOB, iRow, _colTRADE_FACTORY_FOB).StyleNew.BackColor = Color.Red;		

					}
					else if (sLevel.Equals("2"))
					{
						vRange.StyleNew.BackColor = Color.LightYellow;
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "GridSetColor", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}				
		}

		private void Clear_FlexGrid()
		{
			if (fgrid_main.Rows.Fixed != fgrid_main.Rows.Count)
			{				
				fgrid_main.Clear(ClearFlags.UserData, fgrid_main.Rows.Fixed, 1, fgrid_main.Rows.Count - 1, fgrid_main.Cols.Count - 1);

				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
			}
		}

		public DataTable SELECT_SIM_TRAINEE(string arg_procedure)
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
			MyOraDB.Parameter_Values[ 0]   = _vfactory;
			MyOraDB.Parameter_Values[ 1]   = _vt_code;
			MyOraDB.Parameter_Values[ 2]   = _vseq;
			MyOraDB.Parameter_Values[ 3]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void fgrid_main_StartEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_main.Update_Row(fgrid_main.RowSel);
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			int sel_row = fgrid_main.Selection.r1;
			int iLevel;

			iLevel = Convert.ToInt32(fgrid_main[sel_row,_colLEVEL].ToString() );

			if (iLevel == 2)
				return;

			if (sel_row < _Rowfixed) 
				return;
			fgrid_main.Delete_Row();
			_vFlag = 2;
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess();
		}

		private void Tbtn_PrintProcess()
		{
			try
			{
				PRINT_TRAINEE_LIST();
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

		private void PRINT_TRAINEE_LIST()
		{
			string sDir;
			
			sDir = FlexTraining.ClassLib.ComFunction.Set_RD_Directory("Form_Trainee_List");

			string sPara;
			
//			sPara  = " /rp ";
//			sPara += "'" + _vfactory  +	"' ";
//			sPara += "'" + _vt_code  +	"' ";
//			sPara += "'" + _vseq  +	"' ";

			sPara  = " /rp ";
			sPara += "'" + _vfactory +	"' ";			            //Parm1: Factory
			sPara += "'" + _vt_code +	"' ";						//Parm2: Training Group
			sPara += "'" + " " +	"' ";							//Parm3: Objectives
			sPara += "'" + _vseq  +	"' ";							//Parm4: Wave
			sPara += "'" +  " " +	"' ";                           //Parm5: Start date
			sPara += "'" +  " "   +	"' ";							//Parm5: Start date

			FlexTraining.Report.Form_RdViewer MyReport = new FlexTraining.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "Trainee List";
			MyReport.Show();
		}

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();
		}

		private void Grid_AfterEditProcess()
		{
			int iCol = fgrid_main.Selection.c1;
			int iRow = fgrid_main.Selection.r1;
			
			//if ((iCol == _colWAVE)||(iCol == _colGRP_CODE)||(iCol == _colLOCATION_DIV)||(iCol == _colLANG_DIV)||(iCol == _colTRAINER_ID)||(iCol == _colREMARK))
			if ((iCol != _colT_NAME) && (iCol != _colSEQ))
			{
				fgrid_main.Update_Row(iRow);
			}
			
			//fgrid_main.Update_Row();
		}

		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
			try
			{
				string vProcedure;
				string sLevel = fgrid_main[fgrid_main.Selection.r1, _colLEVEL].ToString();
				int iRow = fgrid_main.Selection.r1;
				if (sLevel.Equals("2"))
					return;

				vProcedure = "PKG_SIM_MASTER.SELECT_EMP_PIC";
				DataTable vDt = SELECT_EMP_PIC(vProcedure,fgrid_main[iRow,_colEMP_No].ToString() );	
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
			catch
			{
				Pic_Emp.Image=null;
			}
		}
		public DataTable SELECT_EMP_PIC(string arg_procedure,string Emp_no)
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

		
		private void rad_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{
				RadioButton src = sender as RadioButton; 

				fgrid_main.Tree.Show(Convert.ToInt32(src.Tag.ToString() ) ); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
		}
	}

}

