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
	public class Form_Training_PGM_Schedule : COM.TrainingWinForm.Form_Top
	{
		private System.Windows.Forms.Panel panel2;
		private COM.FSP fgrid_main;
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label label1;
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
		private System.Windows.Forms.Panel pnl_Menu;
		private System.Windows.Forms.Label btn_Insert;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_Wave;
		private System.Windows.Forms.TextBox txt_Seq;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem mnu_Create;
		private System.Windows.Forms.Panel pnl_Create;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dpick_date_from;
		private System.Windows.Forms.DateTimePicker dpick_date_to;
		private System.Windows.Forms.MenuItem mnu_ClearGrid;
		private System.Windows.Forms.MenuItem mnu_DeleteAll;
		private System.Windows.Forms.TextBox txt_T_Code;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_Group;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox txt_Content;
		private System.Windows.Forms.CheckBox chk_Content;
		private System.ComponentModel.IContainer components = null;

		public Form_Training_PGM_Schedule(string [] arg_keys)
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			_vfactory	= arg_keys[0];
			_vt_code	= arg_keys[1];
			_vt_name	= arg_keys[2];
			_vseq	    = arg_keys[3];

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Training_PGM_Schedule));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel6 = new System.Windows.Forms.Panel();
			this.chk_Content = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.txt_Content = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnl_Create = new System.Windows.Forms.Panel();
			this.btn_Apply = new System.Windows.Forms.Label();
			this.dpick_date_from = new System.Windows.Forms.DateTimePicker();
			this.dpick_date_to = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.fgrid_main = new COM.FSP();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.mnu_Create = new System.Windows.Forms.MenuItem();
			this.mnu_ClearGrid = new System.Windows.Forms.MenuItem();
			this.mnu_DeleteAll = new System.Windows.Forms.MenuItem();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.txt_Group = new System.Windows.Forms.TextBox();
			this.txt_T_Code = new System.Windows.Forms.TextBox();
			this.txt_Seq = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
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
			this.txt_Wave = new System.Windows.Forms.TextBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pnl_Menu = new System.Windows.Forms.Panel();
			this.btn_Insert = new System.Windows.Forms.Label();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnl_Create.SuspendLayout();
			this.panel3.SuspendLayout();
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
			this.c1Sizer1.Controls.Add(this.panel6);
			this.c1Sizer1.Controls.Add(this.panel5);
			this.c1Sizer1.Controls.Add(this.panel4);
			this.c1Sizer1.Controls.Add(this.panel2);
			this.c1Sizer1.Controls.Add(this.pnl_Search);
			this.c1Sizer1.Controls.Add(this.pnl_Menu);
			this.c1Sizer1.Controls.Add(this.statusBar1);
			this.c1Sizer1.GridDefinition = "22.6666666666667:False:True;3.33333333333333:False:True;29.8333333333333:False:Fa" +
				"lse;30:False:False;7.16666666666667:False:True;3.66666666666667:False:True;\t68.3" +
				"59375:False:False;31.25:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1024, 600);
			this.c1Sizer1.TabIndex = 29;
			this.c1Sizer1.TabStop = false;
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel6.BackColor = System.Drawing.Color.Moccasin;
			this.panel6.Controls.Add(this.chk_Content);
			this.panel6.Controls.Add(this.label7);
			this.panel6.Location = new System.Drawing.Point(704, 140);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(320, 20);
			this.panel6.TabIndex = 49;
			// 
			// chk_Content
			// 
			this.chk_Content.Location = new System.Drawing.Point(8, 3);
			this.chk_Content.Name = "chk_Content";
			this.chk_Content.Size = new System.Drawing.Size(16, 13);
			this.chk_Content.TabIndex = 1;
			this.chk_Content.CheckedChanged += new System.EventHandler(this.chk_Content_CheckedChanged);
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(0, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(320, 20);
			this.label7.TabIndex = 0;
			this.label7.Text = "Details";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.textBox1);
			this.panel5.Location = new System.Drawing.Point(704, 347);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(320, 180);
			this.panel5.TabIndex = 48;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.MaxLength = 4000;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(320, 180);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.txt_Content);
			this.panel4.Location = new System.Drawing.Point(704, 164);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(320, 179);
			this.panel4.TabIndex = 47;
			// 
			// txt_Content
			// 
			this.txt_Content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Content.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txt_Content.Enabled = false;
			this.txt_Content.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Content.Location = new System.Drawing.Point(0, 0);
			this.txt_Content.MaxLength = 4000;
			this.txt_Content.Multiline = true;
			this.txt_Content.Name = "txt_Content";
			this.txt_Content.Size = new System.Drawing.Size(320, 179);
			this.txt_Content.TabIndex = 165;
			this.txt_Content.Text = "";
			this.txt_Content.TextChanged += new System.EventHandler(this.txt_Content_TextChanged);
			this.txt_Content.MouseLeave += new System.EventHandler(this.txt_Content_MouseLeave);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.pnl_Create);
			this.panel2.Controls.Add(this.fgrid_main);
			this.panel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel2.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.panel2.Location = new System.Drawing.Point(0, 140);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(700, 387);
			this.panel2.TabIndex = 46;
			// 
			// pnl_Create
			// 
			this.pnl_Create.BackColor = System.Drawing.Color.AliceBlue;
			this.pnl_Create.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Create.Controls.Add(this.btn_Apply);
			this.pnl_Create.Controls.Add(this.dpick_date_from);
			this.pnl_Create.Controls.Add(this.dpick_date_to);
			this.pnl_Create.Controls.Add(this.label5);
			this.pnl_Create.Controls.Add(this.label4);
			this.pnl_Create.Controls.Add(this.panel3);
			this.pnl_Create.Location = new System.Drawing.Point(280, 64);
			this.pnl_Create.Name = "pnl_Create";
			this.pnl_Create.Size = new System.Drawing.Size(368, 136);
			this.pnl_Create.TabIndex = 34;
			// 
			// btn_Apply
			// 
			this.btn_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(254, 96);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(80, 23);
			this.btn_Apply.TabIndex = 564;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			// 
			// dpick_date_from
			// 
			this.dpick_date_from.CustomFormat = "";
			this.dpick_date_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_date_from.Location = new System.Drawing.Point(128, 56);
			this.dpick_date_from.Name = "dpick_date_from";
			this.dpick_date_from.Size = new System.Drawing.Size(90, 21);
			this.dpick_date_from.TabIndex = 555;
			this.dpick_date_from.ValueChanged += new System.EventHandler(this.dpick_date_from_ValueChanged);
			// 
			// dpick_date_to
			// 
			this.dpick_date_to.CustomFormat = "";
			this.dpick_date_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_date_to.Location = new System.Drawing.Point(242, 56);
			this.dpick_date_to.Name = "dpick_date_to";
			this.dpick_date_to.Size = new System.Drawing.Size(91, 21);
			this.dpick_date_to.TabIndex = 556;
			this.dpick_date_to.ValueChanged += new System.EventHandler(this.dpick_date_to_ValueChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(226, 60);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(8, 16);
			this.label5.TabIndex = 558;
			this.label5.Text = "~";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ImageIndex = 1;
			this.label4.ImageList = this.img_Label;
			this.label4.Location = new System.Drawing.Point(24, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 21);
			this.label4.TabIndex = 557;
			this.label4.Text = "Training Date";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(400, 24);
			this.panel3.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(10, 4);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(222, 16);
			this.label6.TabIndex = 1;
			this.label6.Text = "Auto Create PGM  Schedule";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(344, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(24, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "X";
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			this.fgrid_main.Size = new System.Drawing.Size(700, 387);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 32;
			this.fgrid_main.Click += new System.EventHandler(this.fgrid_main_Click);
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.mnu_Create,
																						 this.mnu_ClearGrid,
																						 this.mnu_DeleteAll});
			// 
			// mnu_Create
			// 
			this.mnu_Create.Index = 0;
			this.mnu_Create.Text = "Schedule Creation";
			this.mnu_Create.Click += new System.EventHandler(this.mnu_Create_Click);
			// 
			// mnu_ClearGrid
			// 
			this.mnu_ClearGrid.Index = 1;
			this.mnu_ClearGrid.Text = "Clear Grid";
			this.mnu_ClearGrid.Click += new System.EventHandler(this.mnu_ClearGrid_Click);
			// 
			// mnu_DeleteAll
			// 
			this.mnu_DeleteAll.Index = 2;
			this.mnu_DeleteAll.Text = "Delete All";
			this.mnu_DeleteAll.Click += new System.EventHandler(this.mnu_DeleteAll_Click);
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
			this.pnl_Search.Size = new System.Drawing.Size(1024, 136);
			this.pnl_Search.TabIndex = 45;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.txt_Group);
			this.pnl_SearchImage.Controls.Add(this.txt_T_Code);
			this.pnl_SearchImage.Controls.Add(this.txt_Seq);
			this.pnl_SearchImage.Controls.Add(this.label3);
			this.pnl_SearchImage.Controls.Add(this.label2);
			this.pnl_SearchImage.Controls.Add(this.label1);
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
			this.pnl_SearchImage.Controls.Add(this.txt_Wave);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(7, 7);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1010, 122);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// txt_Group
			// 
			this.txt_Group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Group.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Group.Location = new System.Drawing.Point(709, 36);
			this.txt_Group.MaxLength = 100;
			this.txt_Group.Name = "txt_Group";
			this.txt_Group.Size = new System.Drawing.Size(291, 21);
			this.txt_Group.TabIndex = 167;
			this.txt_Group.Text = "";
			// 
			// txt_T_Code
			// 
			this.txt_T_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_T_Code.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_T_Code.Location = new System.Drawing.Point(110, 59);
			this.txt_T_Code.MaxLength = 20;
			this.txt_T_Code.Name = "txt_T_Code";
			this.txt_T_Code.Size = new System.Drawing.Size(104, 21);
			this.txt_T_Code.TabIndex = 166;
			this.txt_T_Code.Text = "";
			// 
			// txt_Seq
			// 
			this.txt_Seq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Seq.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Seq.Location = new System.Drawing.Point(110, 81);
			this.txt_Seq.MaxLength = 20;
			this.txt_Seq.Name = "txt_Seq";
			this.txt_Seq.Size = new System.Drawing.Size(104, 21);
			this.txt_Seq.TabIndex = 162;
			this.txt_Seq.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(608, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 159;
			this.label3.Text = "Wave";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ImageIndex = 0;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(8, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 157;
			this.label2.Text = "Sequence";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(608, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 155;
			this.label1.Text = "Group";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Training
			// 
			this.txt_Training.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Training.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Training.Location = new System.Drawing.Point(215, 59);
			this.txt_Training.MaxLength = 100;
			this.txt_Training.Name = "txt_Training";
			this.txt_Training.Size = new System.Drawing.Size(329, 21);
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
			this.cmb_factory.Location = new System.Drawing.Point(110, 37);
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
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(909, 30);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(101, 84);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(996, 107);
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
			this.picb_TM.Size = new System.Drawing.Size(775, 28);
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
			this.lbl_Training.Location = new System.Drawing.Point(8, 58);
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
			this.picb_TR.Location = new System.Drawing.Point(994, 0);
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
			this.picb_BM.Location = new System.Drawing.Point(123, 106);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(874, 17);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 107);
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
			this.picb_ML.Size = new System.Drawing.Size(8, 246);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// txt_Wave
			// 
			this.txt_Wave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Wave.Enabled = false;
			this.txt_Wave.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Wave.Location = new System.Drawing.Point(709, 58);
			this.txt_Wave.MaxLength = 20;
			this.txt_Wave.Name = "txt_Wave";
			this.txt_Wave.Size = new System.Drawing.Size(80, 21);
			this.txt_Wave.TabIndex = 164;
			this.txt_Wave.Text = "";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(136, 0);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(908, 395);
			this.pictureBox6.TabIndex = 27;
			this.pictureBox6.TabStop = false;
			// 
			// pnl_Menu
			// 
			this.pnl_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Menu.Controls.Add(this.btn_Insert);
			this.pnl_Menu.Location = new System.Drawing.Point(0, 531);
			this.pnl_Menu.Name = "pnl_Menu";
			this.pnl_Menu.Size = new System.Drawing.Size(1024, 43);
			this.pnl_Menu.TabIndex = 44;
			// 
			// btn_Insert
			// 
			this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Insert.ImageIndex = 9;
			this.btn_Insert.ImageList = this.image_List;
			this.btn_Insert.Location = new System.Drawing.Point(920, 8);
			this.btn_Insert.Name = "btn_Insert";
			this.btn_Insert.Size = new System.Drawing.Size(80, 23);
			this.btn_Insert.TabIndex = 350;
			this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
			// 
			// statusBar1
			// 
			this.statusBar1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.statusBar1.Location = new System.Drawing.Point(0, 578);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1,
																						  this.statusBarPanel2});
			this.statusBar1.Size = new System.Drawing.Size(1024, 22);
			this.statusBar1.TabIndex = 43;
			// 
			// Form_Training_PGM_Schedule
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_Training_PGM_Schedule";
			this.Load += new System.EventHandler(this.Form_Training_PGM_Schedule_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.pnl_Create.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
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
		private int _Rowfixed, _vFlag;  //0: Normal; 1: Save; 2:Delete
		private string _vfactory, _vt_code, _vt_name, _vseq;

		//		private int _temp_row = 0, _temp_col = 0;
       
		private int _colFACTORY			= (int) ClassLib.TBSIM_PGM_SCHEDULE.IxFACTORY;
		private int _colT_CODE			= (int) ClassLib.TBSIM_PGM_SCHEDULE.IxT_CODE;
		private int _colSEQ				= (int) ClassLib.TBSIM_PGM_SCHEDULE.IxSEQ;
		private int _colTRAINED_DATE	= (int) ClassLib.TBSIM_PGM_SCHEDULE.IxTRAINED_DATE;
		private int _colPGM_DESC		= (int) ClassLib.TBSIM_PGM_SCHEDULE.IxPGM_DESC;
		private int _colSCHEDULE_YN		= (int) ClassLib.TBSIM_PGM_SCHEDULE.IxSCHEDULE_YN;
		private int _colREASON			= (int) ClassLib.TBSIM_PGM_SCHEDULE.IxREASON;
		private int _colREMARK			= (int) ClassLib.TBSIM_PGM_SCHEDULE.IxREMARK;

   
		
		#endregion

		private void Form_Training_PGM_Schedule_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			_vFlag = 0;
		}

		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "Training Program Scheduling";
			this.Text		   = "Training";
			pnl_Create.Visible = false;
			mnu_ClearGrid.Enabled = false;
			mnu_DeleteAll.Enabled = false;
			cmb_factory.Enabled = false;
			txt_Training.Enabled = false;
			txt_T_Code.Enabled = false;
			txt_Seq.Enabled = false;
			txt_Group.Enabled = false;
			txt_Wave.Enabled = false;
			txt_Content.Enabled = false;


			// grid set
			fgrid_main.Set_Grid("SIM_PGM_SCHEDULE", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			_Rowfixed = fgrid_main.Rows.Fixed;
			fgrid_main.Cols[_colTRAINED_DATE].Style.Format   = "yyyy-MM-dd";
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";

			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

			DataTable vDt;
				
			// factory set
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
			cmb_factory.SelectedValue    = _vfactory;
			txt_T_Code.Text              = _vt_code;
			txt_Training.Text            = _vt_name;
			txt_Seq.Text                 = _vseq;
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


		private void mnu_Create_Click(object sender, System.EventArgs e)
		{
			pnl_Create.Visible = true;
			
		}


		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			pnl_Create.Visible = false;
			this.Tbtn_Apply_Process();
		}

		private void Tbtn_Apply_Process()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SIM_PGM_SCHEDULE.SELECT_SIM_CALENDAR";

				DataTable vDt = SELECT_SIM_CALENDAR(vProcedure);

				this.Tbtn_SearchProcess ();
										

				for (int iRow = 0 ; iRow < vDt.Rows.Count ; iRow++)
				{
					// Add Training Date to Grid

					fgrid_main.Add_Row(_Rowfixed + iRow -1);
					//fgrid_main[newRow.Row.Index, 0] = "I";

					fgrid_main[_Rowfixed + iRow, _colFACTORY]		= _vfactory;
					fgrid_main[_Rowfixed + iRow, _colT_CODE]		= _vt_code;
					fgrid_main[_Rowfixed + iRow, _colSEQ]			= _vseq;
					fgrid_main[_Rowfixed + iRow, _colTRAINED_DATE]	= vDt.Rows[iRow].ItemArray[0].ToString();
					fgrid_main[_Rowfixed + iRow, _colSCHEDULE_YN]	= vDt.Rows[iRow].ItemArray[1].ToString();
					fgrid_main[_Rowfixed + iRow, _colREASON]	    = vDt.Rows[iRow].ItemArray[2].ToString();

					//-------------------------
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
				mnu_ClearGrid.Enabled = true;
				mnu_DeleteAll.Enabled = false;
			}
		}

		public DataTable SELECT_SIM_CALENDAR(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_T_CODE";
			MyOraDB.Parameter_Name[ 2]  = "ARG_SEQ";
			MyOraDB.Parameter_Name[ 3]  = "ARG_FROM_DATE";
			MyOraDB.Parameter_Name[ 4]  = "ARG_TO_DATE";
			MyOraDB.Parameter_Name[ 5]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 5]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = _vfactory ;
			MyOraDB.Parameter_Values[ 1]   = _vt_code;
			MyOraDB.Parameter_Values[ 2]   = _vseq;
			MyOraDB.Parameter_Values[ 3]   = dpick_date_from.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[ 4]   = dpick_date_to.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[ 5]   = "";

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


		private void button1_Click(object sender, System.EventArgs e)
		{
			pnl_Create.Visible = false;
		}

		private void btn_Insert_Click(object sender, System.EventArgs e)
		{
//			try
//			{				
//				int iRow = fgrid_main.Rows.Count;
//
//				fgrid_main.Add_Row(iRow-1);
//			
//				fgrid_main[iRow, _colFACTORY] = COM.ComVar.This_Factory.ToString();
//			    fgrid_main.Cols[_colTRAINED_DATE].Style.DataType = typeof(DateTime);
//				fgrid_main.Cols[_colTRAINED_DATE].Style.Format   = "yyyy-MM-dd";	
//
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

		private void mnu_ClearGrid_Click(object sender, System.EventArgs e)
		{
			Clear_FlexGrid();
			this.Tbtn_SearchProcess();
			mnu_ClearGrid.Enabled = false;
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
                
				string vProcedure     = "PKG_SIM_PGM_SCHEDULE.SELECT_SIM_PGM_SCHEDULE";

				DataTable vDt = SELECT_SIM_PGM_SCHEDULE(vProcedure);

				Clear_FlexGrid();
				_vFlag = 0;
				if (vDt.Rows.Count > 0)
				{
					Display_FlexGrid(vDt);
					mnu_DeleteAll.Enabled = true;
					txt_Content.Enabled = false;
					chk_Content.Checked = false;
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


		public DataTable SELECT_SIM_PGM_SCHEDULE(string arg_procedure)
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
			MyOraDB.Parameter_Values[ 0]   = _vfactory ;
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
				if ((fgrid_main[iRow, _colTRAINED_DATE].ToString().Replace(" ", "").Trim().Length == 0) )
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

				if (SAVE_SIM_PGM_SCHEDULE(true))
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
		public bool SAVE_SIM_PGM_SCHEDULE(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 10;

				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SIM_PGM_SCHEDULE.SAVE_SIM_PGM_SCHEDULE";

				//02.ARGURMENT NAME
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 2] = "ARG_T_CODE";
				MyOraDB.Parameter_Name[ 3] = "ARG_SEQ";
				MyOraDB.Parameter_Name[ 4] = "ARG_TRAINED_DATE";
				MyOraDB.Parameter_Name[ 5] = "ARG_PGM_DESC";
				MyOraDB.Parameter_Name[ 6] = "ARG_SCHEDULE_YN";
				MyOraDB.Parameter_Name[ 7] = "ARG_REASON";
				MyOraDB.Parameter_Name[ 8] = "ARG_REMARK";
				MyOraDB.Parameter_Name[ 9] = "ARG_UPDATE_USER";

				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
//				if (chk_Content.Checked == true)
//				{
//					int iRow = fgrid_main.Selection.r1 ;
//					if(fgrid_main[iRow, 0].ToString() != "")
//					{
//						MyOraDB.Parameter_Values[para_ct + 0 ] = fgrid_main[iRow, 0].ToString();
//						MyOraDB.Parameter_Values[para_ct + 1 ] = fgrid_main[iRow, _colFACTORY].ToString();
//						MyOraDB.Parameter_Values[para_ct + 2 ] = fgrid_main[iRow, _colT_CODE].ToString();
//						MyOraDB.Parameter_Values[para_ct + 3 ] = fgrid_main[iRow, _colSEQ].ToString();
//						MyOraDB.Parameter_Values[para_ct + 4 ] = (fgrid_main[iRow, _colTRAINED_DATE] == null) ? "________" : Convert.ToDateTime(fgrid_main[iRow, _colTRAINED_DATE]).ToString("yyyyMMdd");
//						MyOraDB.Parameter_Values[para_ct + 5 ] = fgrid_main[iRow, _colPGM_DESC].ToString();
//						MyOraDB.Parameter_Values[para_ct + 6 ] = (fgrid_main[iRow, _colSCHEDULE_YN].ToString()== "True") ? "Y" : "N";
//						MyOraDB.Parameter_Values[para_ct + 7 ] = fgrid_main[iRow, _colREASON].ToString();
//						//MyOraDB.Parameter_Values[para_ct + 8 ] = fgrid_main[iRow, _colREMARK].ToString();
//						MyOraDB.Parameter_Values[para_ct + 8 ] = COM.ComFunction.Empty_TextBox(txt_Content, "");
//						MyOraDB.Parameter_Values[para_ct + 9 ] = COM.ComVar.This_User;
//					}
//				}
//				else
//				{
					
					for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
						if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
							save_ct += 1;
				
					MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

					for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
					{
						if(fgrid_main[iRow, 0].ToString() != "")
						{
							MyOraDB.Parameter_Values[para_ct + 0 ] = fgrid_main[iRow, 0].ToString();
							MyOraDB.Parameter_Values[para_ct + 1 ] = fgrid_main[iRow, _colFACTORY].ToString();
							MyOraDB.Parameter_Values[para_ct + 2 ] = fgrid_main[iRow, _colT_CODE].ToString();
							MyOraDB.Parameter_Values[para_ct + 3 ] = fgrid_main[iRow, _colSEQ].ToString();
							MyOraDB.Parameter_Values[para_ct + 4 ] = (fgrid_main[iRow, _colTRAINED_DATE] == null) ? "________" : Convert.ToDateTime(fgrid_main[iRow, _colTRAINED_DATE]).ToString("yyyyMMdd");
							MyOraDB.Parameter_Values[para_ct + 5 ] = fgrid_main[iRow, _colPGM_DESC].ToString();
							MyOraDB.Parameter_Values[para_ct + 6 ] = (fgrid_main[iRow, _colSCHEDULE_YN].ToString()== "True") ? "Y" : "N";
							MyOraDB.Parameter_Values[para_ct + 7 ] = fgrid_main[iRow, _colREASON].ToString();
							MyOraDB.Parameter_Values[para_ct + 8 ] = fgrid_main[iRow, _colREMARK].ToString();
							MyOraDB.Parameter_Values[para_ct + 9 ] = COM.ComVar.This_User;

							para_ct += iCount;	
						}				
					}
//				}


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


		public bool SAVE_SIM_PGM_SCHEDULE_BAK(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 10;

				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SIM_PGM_SCHEDULE.SAVE_SIM_PGM_SCHEDULE";

				//02.ARGURMENT NAME
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 2] = "ARG_T_CODE";
				MyOraDB.Parameter_Name[ 3] = "ARG_SEQ";
				MyOraDB.Parameter_Name[ 4] = "ARG_TRAINED_DATE";
				MyOraDB.Parameter_Name[ 5] = "ARG_PGM_DESC";
				MyOraDB.Parameter_Name[ 6] = "ARG_SCHEDULE_YN";
				MyOraDB.Parameter_Name[ 7] = "ARG_REASON";
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
					if(fgrid_main[iRow, 0].ToString() != "")
					{
						MyOraDB.Parameter_Values[para_ct + 0 ] = fgrid_main[iRow, 0].ToString();
						MyOraDB.Parameter_Values[para_ct + 1 ] = fgrid_main[iRow, _colFACTORY].ToString();
						MyOraDB.Parameter_Values[para_ct + 2 ] = fgrid_main[iRow, _colT_CODE].ToString();
						MyOraDB.Parameter_Values[para_ct + 3 ] = fgrid_main[iRow, _colSEQ].ToString();
						MyOraDB.Parameter_Values[para_ct + 4 ] = (fgrid_main[iRow, _colTRAINED_DATE] == null) ? "________" : Convert.ToDateTime(fgrid_main[iRow, _colTRAINED_DATE]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct + 5 ] = fgrid_main[iRow, _colPGM_DESC].ToString();
						MyOraDB.Parameter_Values[para_ct + 6 ] = (fgrid_main[iRow, _colSCHEDULE_YN].ToString()== "True") ? "Y" : "N";
						MyOraDB.Parameter_Values[para_ct + 7 ] = fgrid_main[iRow, _colREASON].ToString();
						MyOraDB.Parameter_Values[para_ct + 8 ] = fgrid_main[iRow, _colREMARK].ToString();
						MyOraDB.Parameter_Values[para_ct + 9 ] = COM.ComVar.This_User;

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

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();
		}

		private void Grid_AfterEditProcess()
		{
			int iCol = fgrid_main.Selection.c1;
			int iRow = fgrid_main.Selection.r1;
			
			if (iCol != _colTRAINED_DATE)
			{
				fgrid_main.Update_Row(iRow);
			}
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			int sel_row = fgrid_main.Selection.r1;

			if (sel_row < _Rowfixed) 
				return;
			fgrid_main.Delete_Row();
			_vFlag = 2;
		}

		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
			if (fgrid_main.Row >= _Rowfixed)
				txt_Content.Text = fgrid_main[fgrid_main.Row, _colREMARK].ToString ();
		}

		private void mnu_DeleteAll_Click(object sender, System.EventArgs e)
		{
			for (int iRow = _Rowfixed; iRow < fgrid_main.Rows.Count; iRow ++)
			{
				fgrid_main.Delete_Row(iRow);
			}
			mnu_DeleteAll.Enabled = false;
		}

		private void txt_Memo_TextChanged(object sender, System.EventArgs e)
		{
//			int iRow = fgrid_main.Selection.r1;
//			fgrid_main.Update_Row(iRow);
		}

		private void dpick_date_from_ValueChanged(object sender, System.EventArgs e)
		{
			dpick_date_to.Value = dpick_date_from.Value;
		}

		private void dpick_date_to_ValueChanged(object sender, System.EventArgs e)
		{
			if (dpick_date_to.Value < dpick_date_from.Value)
			{
				dpick_date_to.Value = dpick_date_from.Value;
			}
		}

		private void txt_Content_TextChanged(object sender, System.EventArgs e)
		{
//			int iRow = fgrid_main.Selection.r1;
//			if (chk_Content.Checked)
//			{
//				fgrid_main.Update_Row(iRow);
//				//fgrid_main[iRow, _colREMARK] = txt_Content.Text;
//			}

		}

		private void chk_Content_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chk_Content.Checked == true)
			{
				txt_Content.Enabled = true;
				txt_Content.Select();
			}
			else
				txt_Content.Enabled = false;
			
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess();
		}

		private void Tbtn_PrintProcess()
		{
			try
			{
				PRINT_PGM_SCHEDULE();
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

		private void PRINT_PGM_SCHEDULE()
		{
			string sDir;
			
			sDir = FlexTraining.ClassLib.ComFunction.Set_RD_Directory("Form_PGM_Schedule");

			string sPara;
			
			sPara  = " /rp ";
			sPara += "'" + _vfactory  +	"' ";
			sPara += "'" + _vt_code  +	"' ";
			sPara += "'" + " "  +	"' ";
			sPara += "'" + _vseq  +	"' ";
			sPara += "'" + " " +	"' ";
			sPara += "'" + " "  +	"' ";




			FlexTraining.Report.Form_RdViewer MyReport = new FlexTraining.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "Training Attendance List";
			MyReport.Show();
				
		}

		private void txt_Content_MouseLeave(object sender, System.EventArgs e)
		{
			int iRow = fgrid_main.Selection.r1;
			if (chk_Content.Checked)
			{
				fgrid_main.Update_Row(iRow);
				fgrid_main[iRow, _colREMARK] = txt_Content.Text;
			}
		}

	}
}

