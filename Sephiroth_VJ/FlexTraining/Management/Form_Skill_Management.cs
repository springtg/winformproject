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
	public class Form_Skill_Management : COM.TrainingWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_Menu;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label btn_Apply;
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
		public System.Windows.Forms.Panel pnl_Search;
		private C1.Win.C1List.C1Combo cmb_Department;
		private C1.Win.C1List.C1Combo c1Combo1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label lbl_Dept;
		private System.Windows.Forms.ImageList img_Skill;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_Dep;
		private COM.FSP fgrid_history;
		private System.Windows.Forms.RadioButton chk_value4;
		private System.Windows.Forms.RadioButton chk_value2;
		private System.Windows.Forms.RadioButton chk_value3;
		private System.Windows.Forms.RadioButton chk_value1;
		private System.Windows.Forms.Label lbl_value4;
		private System.Windows.Forms.Label lbl_value2;
		private System.Windows.Forms.Label lbl_value3;
		private System.Windows.Forms.Label lbl_value1;
		private System.Windows.Forms.Label lbl_value0;
		private System.Windows.Forms.RadioButton chk_value0;
		private System.Windows.Forms.TextBox txt_EmpNo;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;

		public Form_Skill_Management()
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
		private int _Rowfixed;
		private string _EMP_NO, fgrid_status = "fail";  		

		private int _colEMP_NO   	          = (int)ClassLib.TBSIM_SKILL_MANAGEMENT.IxEMP_NO;
		private int _colWORK_SKILL_LEVEL   	  = (int)ClassLib.TBSIM_SKILL_MANAGEMENT.IxWORK_SKILL_LEVEL;

		#endregion
		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Skill_Management));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.fgrid_history = new COM.FSP();
			this.panel3 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.chk_value4 = new System.Windows.Forms.RadioButton();
			this.chk_value2 = new System.Windows.Forms.RadioButton();
			this.chk_value3 = new System.Windows.Forms.RadioButton();
			this.chk_value1 = new System.Windows.Forms.RadioButton();
			this.chk_value0 = new System.Windows.Forms.RadioButton();
			this.lbl_value4 = new System.Windows.Forms.Label();
			this.img_Skill = new System.Windows.Forms.ImageList(this.components);
			this.lbl_value2 = new System.Windows.Forms.Label();
			this.lbl_value3 = new System.Windows.Forms.Label();
			this.lbl_value1 = new System.Windows.Forms.Label();
			this.lbl_value0 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.txt_EmpNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_Dep = new System.Windows.Forms.TextBox();
			this.cmb_Department = new C1.Win.C1List.C1Combo();
			this.btn_Apply = new System.Windows.Forms.Label();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.lbl_Dept = new System.Windows.Forms.Label();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pnl_Menu = new System.Windows.Forms.Panel();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			this.c1Combo1 = new C1.Win.C1List.C1Combo();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_history)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.panel2.SuspendLayout();
			this.pnl_Search.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Department)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
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
			this.c1Sizer1.Controls.Add(this.panel7);
			this.c1Sizer1.Controls.Add(this.panel6);
			this.c1Sizer1.Controls.Add(this.panel3);
			this.c1Sizer1.Controls.Add(this.panel2);
			this.c1Sizer1.Controls.Add(this.panel5);
			this.c1Sizer1.Controls.Add(this.panel4);
			this.c1Sizer1.Controls.Add(this.pnl_Search);
			this.c1Sizer1.Controls.Add(this.pnl_Menu);
			this.c1Sizer1.Controls.Add(this.statusBar1);
			this.c1Sizer1.GridDefinition = "16.6666666666667:False:True;44:False:False;1.83333333333333:False:False;23.333333" +
				"3333333:False:False;7.16666666666667:False:True;3.66666666666667:False:True;\t89." +
				"7536945812808:False:False;9.85221674876847:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1015, 600);
			this.c1Sizer1.TabIndex = 31;
			this.c1Sizer1.TabStop = false;
			// 
			// panel7
			// 
			this.panel7.Location = new System.Drawing.Point(0, 372);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(1015, 11);
			this.panel7.TabIndex = 53;
			// 
			// panel6
			// 
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Controls.Add(this.fgrid_history);
			this.panel6.Location = new System.Drawing.Point(0, 387);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(911, 187);
			this.panel6.TabIndex = 52;
			// 
			// fgrid_history
			// 
			this.fgrid_history.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_history.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_history.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_history.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_history.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_history.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.fgrid_history.Location = new System.Drawing.Point(0, 0);
			this.fgrid_history.Name = "fgrid_history";
			this.fgrid_history.Size = new System.Drawing.Size(909, 185);
			this.fgrid_history.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_history.TabIndex = 33;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.fgrid_main);
			this.panel3.Location = new System.Drawing.Point(0, 104);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1015, 264);
			this.panel3.TabIndex = 51;
			// 
			// fgrid_main
			// 
			this.fgrid_main.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop;
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Size = new System.Drawing.Size(1015, 264);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 33;
			this.fgrid_main.Click += new System.EventHandler(this.fgrid_main_Click);
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.LightBlue;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.chk_value4);
			this.panel2.Controls.Add(this.chk_value2);
			this.panel2.Controls.Add(this.chk_value3);
			this.panel2.Controls.Add(this.chk_value1);
			this.panel2.Controls.Add(this.chk_value0);
			this.panel2.Controls.Add(this.lbl_value4);
			this.panel2.Controls.Add(this.lbl_value2);
			this.panel2.Controls.Add(this.lbl_value3);
			this.panel2.Controls.Add(this.lbl_value1);
			this.panel2.Controls.Add(this.lbl_value0);
			this.panel2.Location = new System.Drawing.Point(915, 387);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(100, 187);
			this.panel2.TabIndex = 50;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.RoyalBlue;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Dock = System.Windows.Forms.DockStyle.Top;
			this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(0, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 16);
			this.label6.TabIndex = 10;
			this.label6.Text = "Skill Level";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chk_value4
			// 
			this.chk_value4.Location = new System.Drawing.Point(5, 151);
			this.chk_value4.Name = "chk_value4";
			this.chk_value4.Size = new System.Drawing.Size(16, 32);
			this.chk_value4.TabIndex = 9;
			this.chk_value4.CheckedChanged += new System.EventHandler(this.chk_value4_CheckedChanged);
			// 
			// chk_value2
			// 
			this.chk_value2.Location = new System.Drawing.Point(5, 87);
			this.chk_value2.Name = "chk_value2";
			this.chk_value2.Size = new System.Drawing.Size(16, 32);
			this.chk_value2.TabIndex = 8;
			this.chk_value2.CheckedChanged += new System.EventHandler(this.chk_value2_CheckedChanged);
			// 
			// chk_value3
			// 
			this.chk_value3.Location = new System.Drawing.Point(5, 119);
			this.chk_value3.Name = "chk_value3";
			this.chk_value3.Size = new System.Drawing.Size(16, 32);
			this.chk_value3.TabIndex = 7;
			this.chk_value3.CheckedChanged += new System.EventHandler(this.chk_value3_CheckedChanged);
			// 
			// chk_value1
			// 
			this.chk_value1.Location = new System.Drawing.Point(5, 55);
			this.chk_value1.Name = "chk_value1";
			this.chk_value1.Size = new System.Drawing.Size(16, 32);
			this.chk_value1.TabIndex = 6;
			this.chk_value1.CheckedChanged += new System.EventHandler(this.chk_value1_CheckedChanged);
			// 
			// chk_value0
			// 
			this.chk_value0.Location = new System.Drawing.Point(5, 23);
			this.chk_value0.Name = "chk_value0";
			this.chk_value0.Size = new System.Drawing.Size(16, 32);
			this.chk_value0.TabIndex = 5;
			this.chk_value0.CheckedChanged += new System.EventHandler(this.chk_value0_CheckedChanged);
			// 
			// lbl_value4
			// 
			this.lbl_value4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_value4.ImageIndex = 4;
			this.lbl_value4.ImageList = this.img_Skill;
			this.lbl_value4.Location = new System.Drawing.Point(32, 151);
			this.lbl_value4.Name = "lbl_value4";
			this.lbl_value4.Size = new System.Drawing.Size(72, 32);
			this.lbl_value4.TabIndex = 4;
			this.lbl_value4.Text = "100%";
			this.lbl_value4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// img_Skill
			// 
			this.img_Skill.ImageSize = new System.Drawing.Size(30, 30);
			this.img_Skill.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Skill.ImageStream")));
			this.img_Skill.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lbl_value2
			// 
			this.lbl_value2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_value2.ImageIndex = 2;
			this.lbl_value2.ImageList = this.img_Skill;
			this.lbl_value2.Location = new System.Drawing.Point(32, 87);
			this.lbl_value2.Name = "lbl_value2";
			this.lbl_value2.Size = new System.Drawing.Size(72, 32);
			this.lbl_value2.TabIndex = 3;
			this.lbl_value2.Text = "50 %";
			this.lbl_value2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_value3
			// 
			this.lbl_value3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_value3.ImageIndex = 3;
			this.lbl_value3.ImageList = this.img_Skill;
			this.lbl_value3.Location = new System.Drawing.Point(32, 119);
			this.lbl_value3.Name = "lbl_value3";
			this.lbl_value3.Size = new System.Drawing.Size(72, 32);
			this.lbl_value3.TabIndex = 2;
			this.lbl_value3.Text = "75 %";
			this.lbl_value3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_value1
			// 
			this.lbl_value1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_value1.ImageIndex = 1;
			this.lbl_value1.ImageList = this.img_Skill;
			this.lbl_value1.Location = new System.Drawing.Point(32, 55);
			this.lbl_value1.Name = "lbl_value1";
			this.lbl_value1.Size = new System.Drawing.Size(72, 32);
			this.lbl_value1.TabIndex = 1;
			this.lbl_value1.Text = "25 %";
			this.lbl_value1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_value0
			// 
			this.lbl_value0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_value0.ImageIndex = 0;
			this.lbl_value0.ImageList = this.img_Skill;
			this.lbl_value0.Location = new System.Drawing.Point(32, 23);
			this.lbl_value0.Name = "lbl_value0";
			this.lbl_value0.Size = new System.Drawing.Size(72, 32);
			this.lbl_value0.TabIndex = 0;
			this.lbl_value0.Text = "0 %";
			this.lbl_value0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel5
			// 
			this.panel5.Location = new System.Drawing.Point(915, 531);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(100, 43);
			this.panel5.TabIndex = 49;
			// 
			// panel4
			// 
			this.panel4.Location = new System.Drawing.Point(0, 531);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(911, 43);
			this.panel4.TabIndex = 48;
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.Controls.Add(this.pictureBox6);
			this.pnl_Search.DockPadding.All = 7;
			this.pnl_Search.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_Search.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.pnl_Search.Location = new System.Drawing.Point(0, 0);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1015, 100);
			this.pnl_Search.TabIndex = 45;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.txt_EmpNo);
			this.pnl_SearchImage.Controls.Add(this.label1);
			this.pnl_SearchImage.Controls.Add(this.txt_Dep);
			this.pnl_SearchImage.Controls.Add(this.cmb_Department);
			this.pnl_SearchImage.Controls.Add(this.btn_Apply);
			this.pnl_SearchImage.Controls.Add(this.cmb_factory);
			this.pnl_SearchImage.Controls.Add(this.lbl_factory);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.lbl_Dept);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.pnl_SearchImage.Location = new System.Drawing.Point(7, 7);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1001, 86);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// txt_EmpNo
			// 
			this.txt_EmpNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_EmpNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_EmpNo.Location = new System.Drawing.Point(433, 37);
			this.txt_EmpNo.MaxLength = 8;
			this.txt_EmpNo.Name = "txt_EmpNo";
			this.txt_EmpNo.Size = new System.Drawing.Size(200, 21);
			this.txt_EmpNo.TabIndex = 570;
			this.txt_EmpNo.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(331, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 569;
			this.label1.Text = "Emp No";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Dep
			// 
			this.txt_Dep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Dep.Location = new System.Drawing.Point(110, 59);
			this.txt_Dep.MaxLength = 5;
			this.txt_Dep.Name = "txt_Dep";
			this.txt_Dep.Size = new System.Drawing.Size(200, 21);
			this.txt_Dep.TabIndex = 568;
			this.txt_Dep.Text = "";
			this.txt_Dep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Dep_KeyPress);
			this.txt_Dep.TextChanged += new System.EventHandler(this.txt_Dep_TextChanged);
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
			this.cmb_Department.Location = new System.Drawing.Point(311, 59);
			this.cmb_Department.MatchEntryTimeout = ((long)(2000));
			this.cmb_Department.MaxDropDownItems = ((short)(5));
			this.cmb_Department.MaxLength = 32767;
			this.cmb_Department.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Department.Name = "cmb_Department";
			this.cmb_Department.PartialRightColumn = false;
			this.cmb_Department.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Department.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Department.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Department.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Department.Size = new System.Drawing.Size(322, 21);
			this.cmb_Department.TabIndex = 567;
			// 
			// btn_Apply
			// 
			this.btn_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(903, 88);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(80, 23);
			this.btn_Apply.TabIndex = 566;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.cmb_factory.Location = new System.Drawing.Point(110, 37);
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
			this.cmb_factory.Size = new System.Drawing.Size(162, 21);
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
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(900, 30);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(101, 48);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(987, 71);
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
			this.picb_TM.Size = new System.Drawing.Size(766, 28);
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
			// lbl_Dept
			// 
			this.lbl_Dept.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Dept.ImageIndex = 0;
			this.lbl_Dept.ImageList = this.img_Label;
			this.lbl_Dept.Location = new System.Drawing.Point(8, 58);
			this.lbl_Dept.Name = "lbl_Dept";
			this.lbl_Dept.Size = new System.Drawing.Size(100, 21);
			this.lbl_Dept.TabIndex = 149;
			this.lbl_Dept.Text = "Department";
			this.lbl_Dept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(985, 0);
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
			this.picb_BM.Size = new System.Drawing.Size(865, 17);
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
			this.picb_ML.Location = new System.Drawing.Point(0, 0);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(8, 210);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(136, 0);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(899, 287);
			this.pictureBox6.TabIndex = 27;
			this.pictureBox6.TabStop = false;
			// 
			// pnl_Menu
			// 
			this.pnl_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Menu.Location = new System.Drawing.Point(0, 531);
			this.pnl_Menu.Name = "pnl_Menu";
			this.pnl_Menu.Size = new System.Drawing.Size(1015, 43);
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
			this.statusBar1.Size = new System.Drawing.Size(1015, 22);
			this.statusBar1.TabIndex = 43;
			// 
			// c1Combo1
			// 
			this.c1Combo1.AddItemCols = 0;
			this.c1Combo1.AddItemSeparator = ';';
			this.c1Combo1.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.c1Combo1.Caption = "";
			this.c1Combo1.CaptionHeight = 17;
			this.c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.c1Combo1.ColumnCaptionHeight = 17;
			this.c1Combo1.ColumnFooterHeight = 17;
			this.c1Combo1.ContentHeight = 15;
			this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
			this.c1Combo1.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo1.EditorHeight = 15;
			this.c1Combo1.GapHeight = 2;
			this.c1Combo1.ItemHeight = 15;
			this.c1Combo1.Location = new System.Drawing.Point(110, 59);
			this.c1Combo1.MatchEntryTimeout = ((long)(2000));
			this.c1Combo1.MaxDropDownItems = ((short)(5));
			this.c1Combo1.MaxLength = 32767;
			this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.c1Combo1.Name = "c1Combo1";
			this.c1Combo1.PartialRightColumn = false;
			this.c1Combo1.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}Re" +
				"cordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Border:Raise" +
				"d,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{}Style11{}" +
				"Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFoote" +
				"rHeight=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><Hei" +
				"ght>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
				"Style parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" me=\"Style3\" />" +
				"<GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Heading\" me=\"Sty" +
				"le2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><InactiveStyle par" +
				"ent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style8\" /><RecordS" +
				"electorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle parent=\"Selec" +
				"ted\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1List.ListBoxV" +
				"iew></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=\"Normal\" " +
				"me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Heading\" me=" +
				"\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Normal\" me=\"S" +
				"elected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=" +
				"\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"Rec" +
				"ordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSplits>1<" +
				"/vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWid" +
				"th>17</DefaultRecSelWidth></Blob>";
			this.c1Combo1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo1.Size = new System.Drawing.Size(200, 21);
			this.c1Combo1.TabIndex = 0;
			// 
			// Form_Skill_Management
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_Skill_Management";
			this.Load += new System.EventHandler(this.Form_Skill_Management_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_history)).EndInit();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.panel2.ResumeLayout(false);
			this.pnl_Search.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Department)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_Skill_Management_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{						
			// Form Setting
			lbl_MainTitle.Text = "Skill Management";
			this.Text		   = "Training";

			//Enable_Label_Skill_Level(lbl_value0, chk_value0);

			// grid set
			fgrid_main.Set_Grid("SIM_SKILL_MANAGEMENT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_history.Set_Grid("SIM_SKILL_MANAGEMENT", "3", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			_Rowfixed = fgrid_main.Rows.Fixed;
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";

			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

			fgrid_main.Styles.Frozen.BackColor = Color.Lavender; 			
			fgrid_main.KeyActionEnter = KeyActionEnum.MoveAcross;
			fgrid_main.KeyActionTab = KeyActionEnum.MoveAcross;  
			fgrid_main.SelectionMode = SelectionModeEnum.Row;
			fgrid_status = "good";

			DataTable vDt;
				
			// factory set
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
			cmb_factory.SelectedValue    = ClassLib.ComVar.This_Factory;
			
			// Set cmb Dept
			vDt = SELECT_DEPT_LIST("");			
			COM.ComCtl.Set_ComboList(vDt, cmb_Department, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
		}

		public static DataTable Select_Factory_List()
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;
			
			try
			{
				string process_name = "PKG_SCM_FACTORY.SELECT_FACTORY_LIST";

				MyOraDB.ReDim_Parameter(1);  
				MyOraDB.Process_Name = process_name;
   
				MyOraDB.Parameter_Name[0] = "OUT_CURSOR"; 
				MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor; 
				MyOraDB.Parameter_Values[0] = ""; 

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

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SIM_SKILL_MANAGEMENT.SELECT_SIM_EMPLOYEE";

				DataTable vDt = SELECT_SIM_EMPLOYEE(vProcedure);

				Clear_FlexGrid(fgrid_main);
				Clear_FlexGrid(fgrid_history);
				if (vDt.Rows.Count > 0)
				{
					Display_FlexGrid(vDt, fgrid_main);

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

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_DEP_CODE";
			MyOraDB.Parameter_Name[ 1]  = "ARG_EMP_NO";
			MyOraDB.Parameter_Name[ 2]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]	= (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_Department, "");
			MyOraDB.Parameter_Values[ 1]   = COM.ComFunction.Empty_TextBox(txt_EmpNo, "________");
			MyOraDB.Parameter_Values[ 2]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}


		private void Clear_FlexGrid(COM.FSP arg_fgrid)
		{
			if (arg_fgrid.Rows.Fixed != arg_fgrid.Rows.Count)
			{				
				arg_fgrid.Clear(ClearFlags.UserData, arg_fgrid.Rows.Fixed, 1, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1);

				arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;
			}
		}

		private void Display_FlexGrid(DataTable arg_dt, COM.FSP arg_fgrid)
		{
			int iCount = arg_dt.Rows.Count;

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{				
				C1.Win.C1FlexGrid.Node newRow = arg_fgrid.Rows.InsertNode(_Rowfixed + iRow, 1);

				arg_fgrid[newRow.Row.Index, 0] = "";

				for (int iCol = 0; iCol < arg_dt.Columns.Count ; iCol++)
					arg_fgrid[newRow.Row.Index, iCol+1] = arg_dt.Rows[iRow].ItemArray[iCol];
			}

		}
		private void Display_FlexGrid_Tree(DataTable arg_dt)
		{
			int iRow_fixed = fgrid_history.Rows.Fixed;
			int iLevel = 0; 
			int iCount = arg_dt.Rows.Count;

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{
				iLevel = Convert.ToInt32(arg_dt.Rows[iRow].ItemArray[0].ToString() );
				C1.Win.C1FlexGrid.Node newRow = fgrid_history.Rows.InsertNode(iRow_fixed + iRow, iLevel);

				for (int iCol = 1 ; iCol <= arg_dt.Columns.Count ; iCol++)
				{
					fgrid_history[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
				}

				fgrid_history.Tree.Column = 3;
				

			}
			//GridSetColor();

			//rad_lvl1.Checked = true;
			fgrid_history.Tree.Show(1); 

		}

		private void Enable_Label_Skill_Level(Label arg_lbl, RadioButton arg_radio)
		{
			lbl_value0.Enabled = false;
			lbl_value1.Enabled = false;
			lbl_value2.Enabled = false;
			lbl_value3.Enabled = false;
			lbl_value4.Enabled = false;
			arg_lbl.Enabled = true;
			if (arg_radio != null)
			{
				arg_radio.Enabled = true;
				arg_radio.Checked = true;
			}
		}


		private void txt_Dep_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar != 13) return;

			DataTable dt_ret = SELECT_DEPT_LIST (ClassLib.ComFunction.Empty_TextBox(txt_Dep , "") );
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Department, 0, 1, false);
		}

		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
			Event_Grid_Click();
		}

		private void Event_Grid_Click()
		{
			int iRow = fgrid_main.Selection.r1; 
			string _Skill_Level;

			if ((iRow >= _Rowfixed)&& (_Rowfixed > 0))
			{
				_EMP_NO = fgrid_main[iRow, _colEMP_NO].ToString();

				this.Search_Skill_History_Process();
				_Skill_Level = fgrid_main[iRow, _colWORK_SKILL_LEVEL].ToString();

				switch (_Skill_Level)
				{
					case "000":
						Enable_Label_Skill_Level(lbl_value0, chk_value0);
						break;
					case "001":
						Enable_Label_Skill_Level(lbl_value1, chk_value1);
						break;
					case "002":
						Enable_Label_Skill_Level(lbl_value2, chk_value2);
						break;
					case "003":
						Enable_Label_Skill_Level(lbl_value3, chk_value3);
						break;
					case "004":
						Enable_Label_Skill_Level(lbl_value4, chk_value4);
						break;
					default:
						Enable_Label_Skill_Level(lbl_value0, chk_value0);
						break;
				}
			}

		}

		private void Search_Skill_History_Process()
		{
			try
			{
				//this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SIM_SKILL_MANAGEMENT.SELECT_SKILL_HISTORY_TAIL";

				DataTable vDt = SELECT_SKILL_HISTORY(vProcedure);

				Clear_FlexGrid(fgrid_history);
				if (vDt.Rows.Count > 0)
				{
					//Display_FlexGrid(vDt, fgrid_history);
					Display_FlexGrid_Tree(vDt);

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
				//this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}

		public DataTable SELECT_SKILL_HISTORY(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_EMP_NO";
			MyOraDB.Parameter_Name[ 2]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]	= (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = "VJ";
			MyOraDB.Parameter_Values[ 1]   = _EMP_NO;
			MyOraDB.Parameter_Values[ 2]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void chk_value0_CheckedChanged(object sender, System.EventArgs e)
		{
			int iRow = fgrid_main.Selection.r1;
			Enable_Label_Skill_Level(lbl_value0, null);
			fgrid_main[iRow, _colWORK_SKILL_LEVEL] = "000";
		}

		private void chk_value1_CheckedChanged(object sender, System.EventArgs e)
		{
			int iRow = fgrid_main.Selection.r1;
			Enable_Label_Skill_Level(lbl_value1, null);
			fgrid_main[iRow, _colWORK_SKILL_LEVEL] = "001";
		}

		private void chk_value2_CheckedChanged(object sender, System.EventArgs e)
		{
			int iRow = fgrid_main.Selection.r1;
			Enable_Label_Skill_Level(lbl_value2, null);
			fgrid_main[iRow, _colWORK_SKILL_LEVEL] = "002";
		}

		private void chk_value3_CheckedChanged(object sender, System.EventArgs e)
		{
			int iRow = fgrid_main.Selection.r1;
			Enable_Label_Skill_Level(lbl_value3, null);
			fgrid_main[iRow, _colWORK_SKILL_LEVEL] = "003";
		}

		private void chk_value4_CheckedChanged(object sender, System.EventArgs e)
		{
			int iRow = fgrid_main.Selection.r1;
			Enable_Label_Skill_Level(lbl_value4, null);
			fgrid_main[iRow, _colWORK_SKILL_LEVEL] = "004";
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

				if (SAVE_SIM_SKILL_MANAGEMENT(true))
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

		public bool SAVE_SIM_SKILL_MANAGEMENT(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 4;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SIM_SKILL_MANAGEMENT.SAVE_SIM_SKILL_MANAGEMENT";

				//02.ARGURMENT NAME
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_EMP_NO";
				MyOraDB.Parameter_Name[ 2] = "ARG_WORK_SKILL_LEVEL";
				MyOraDB.Parameter_Name[ 3] = "ARG_UPDATE_USER";

				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
						save_ct += 1;
				
				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

				int iR = fgrid_main.Selection.r1;

				if(fgrid_main[iR, 0].ToString() == "U")
				{
					MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main[iR, 0].ToString();
					MyOraDB.Parameter_Values[para_ct+ 1] = fgrid_main[iR, _colEMP_NO].ToString();
					MyOraDB.Parameter_Values[para_ct+ 2] = fgrid_main[iR, _colWORK_SKILL_LEVEL].ToString();;
					MyOraDB.Parameter_Values[para_ct+ 3] = COM.ComVar.This_User;
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
			int iRow = fgrid_main.Selection.r1 ;
			fgrid_main[iRow, 0] = "U";	
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess();
		}

		private void Tbtn_PrintProcess()
		{
			try
			{
				PRINT();
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

		private void PRINT()
		{
			string sDir;
			
			sDir = FlexTraining.ClassLib.ComFunction.Set_RD_Directory("Form_Training_History");

			string sPara;
			
			sPara  = " /rp ";
			sPara += "'" + ClassLib.ComVar.This_Factory  +	"' ";
			sPara += "'" + cmb_Department.Columns[0].Text  +	"' ";
			sPara += "'" + " " +	"' ";
			sPara += "'" + " "  +	"' ";
			sPara += "'" + " "  +	"' ";

			FlexTraining.Report.Form_RdViewer MyReport = new FlexTraining.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "Training Attendance List";
			MyReport.Show();
				
		}

		private void txt_Dep_TextChanged(object sender, System.EventArgs e)
		{
		
		}

	}
}

