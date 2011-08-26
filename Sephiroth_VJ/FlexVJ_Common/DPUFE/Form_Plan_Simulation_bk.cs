using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data;
using System.Data.OracleClient;
using System.Text.RegularExpressions;

namespace FlexVJ_Common.DPUFE
{
	public class Form_Plan_Simulation : COM.VJ_CommonWinForm.Form_Top
	{
		private System.Windows.Forms.TabControl tab_Main;
		private System.Windows.Forms.TabPage tabPageDemandPlan;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label lblOs;
		private System.Windows.Forms.Label lblMonth;
		private System.Windows.Forms.Label lblDevName;
		private COM.FSP fgrid_DemandPlan;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.DateTimePicker dpick_date_from;
		private System.Windows.Forms.Label lbl_PlanYMD;
		private System.Windows.Forms.Label lbl_HeaderTitle;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.Label lbl_Line;
		private C1.Win.C1List.C1Combo cbm_Line;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label btn_Search;
		private System.Windows.Forms.TextBox txt_Os;
		private System.Windows.Forms.TextBox txt_DevName;
		private System.Windows.Forms.DateTimePicker dpick_date_To;
		private C1.Win.C1Command.C1ContextMenu cmenu_Menu1;
		private C1.Win.C1Command.C1CommandLink c1CommandLink8;
		private C1.Win.C1Command.C1Command cmenu_PlanComplete;
		private C1.Win.C1Command.C1CommandLink c1CommandLink9;
		private C1.Win.C1Command.C1Command cmenu_InsertNewMiniLine;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbt_Line;
		private System.Windows.Forms.RadioButton rbt_Model;
		private System.Windows.Forms.TabControl tab_Content;
		private System.Windows.Forms.TabPage Pag_Summary;
		private System.Windows.Forms.TabPage Pag_01;
		private System.Windows.Forms.TabPage Pag_02;
		private System.Windows.Forms.TabPage Pag_03;
		private System.Windows.Forms.TabPage Pag_04;
		private System.Windows.Forms.TabPage Pag_05;
		private COM.FSP fgrid_SP1;
		private COM.FSP fgrid_SU;
		private COM.FSP fgrid_FA;
		private COM.FSP fgrid_HO;
		private COM.FSP fgrid_SP2;
		private System.ComponentModel.IContainer components = null;



		private CellStyle cs0305 = null;
		private CellStyle cs0406 = null;
		private CellStyle cs0507 = null;
		private CellStyle cs0608 = null;
		private CellStyle cs0709 = null;
		private CellStyle cs0810 = null;
		private CellStyle cs0911 = null;
		private CellStyle cs1012 = null;
		private CellStyle cs1101 = null;
		private CellStyle cs1202 = null;
		private CellStyle cs0103 = null;
		private CellStyle cs0204 = null;
		public System.Windows.Forms.DateTimePicker dpickDate_From;
		public System.Windows.Forms.DateTimePicker dpickDate_To;
		private System.Windows.Forms.TextBox txtFontSize;
		private System.Windows.Forms.Label label1;

		private void InitCellStyle()
		{
			if(cs0305 == null)
			{
				cs0305 = fgrid_main.Styles.Add("l_cs0305");
				cs0305.BackColor = T6_Color;
			}
			if(cs0406 == null)
			{
				cs0406 = fgrid_main.Styles.Add("l_cs0406");
				cs0406.BackColor = T7_Color;
			}
			if(cs0507 == null)
			{
				cs0507 = fgrid_main.Styles.Add("l_cs0507");
				cs0507.BackColor = T8_Color;
			}
			if(cs0608 == null)
			{
				cs0608 = fgrid_main.Styles.Add("l_cs0608");
				cs0608.BackColor = T9_Color;
			}
			if(cs0709 == null)
			{
				cs0709 = fgrid_main.Styles.Add("l_cs0709");
				cs0709.BackColor = T10_Color;
			}
			if(cs0810 == null)
			{
				cs0810 = fgrid_main.Styles.Add("l_cs0810");
				cs0810.BackColor = T11_Color;
			}
			if(cs0911 == null)
			{
				cs0911 = fgrid_main.Styles.Add("l_cs0911");
				cs0911.BackColor = T12_Color;
			}
			if(cs1012 == null)
			{
				cs1012 = fgrid_main.Styles.Add("l_cs1012");
				cs1012.BackColor = T1_Color;
			}
			if(cs1101 == null)
			{
				cs1101 = fgrid_main.Styles.Add("l_cs1101");
				cs1101.BackColor = T2_Color;
			}
			if(cs1202 == null)
			{
				cs1202 = fgrid_main.Styles.Add("l_cs1202");
				cs1202.BackColor = T3_Color;
			}
			if(cs0103 == null)
			{
				cs0103 = fgrid_main.Styles.Add("l_cs0103");
				cs0103.BackColor = T4_Color;
			}
			if(cs0204 == null)
			{
				cs0204 = fgrid_main.Styles.Add("l_cs0204");
				cs0204.BackColor = T5_Color;
			}
		}
		public Form_Plan_Simulation()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Plan_Simulation));
			this.tab_Main = new System.Windows.Forms.TabControl();
			this.tabPageDemandPlan = new System.Windows.Forms.TabPage();
			this.fgrid_DemandPlan = new COM.FSP();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dpickDate_To = new System.Windows.Forms.DateTimePicker();
			this.btn_Search = new System.Windows.Forms.Label();
			this.dpickDate_From = new System.Windows.Forms.DateTimePicker();
			this.lblOs = new System.Windows.Forms.Label();
			this.txt_Os = new System.Windows.Forms.TextBox();
			this.lblMonth = new System.Windows.Forms.Label();
			this.lblDevName = new System.Windows.Forms.Label();
			this.txt_DevName = new System.Windows.Forms.TextBox();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.txtFontSize = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbt_Model = new System.Windows.Forms.RadioButton();
			this.rbt_Line = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.cbm_Line = new C1.Win.C1List.C1Combo();
			this.dpick_date_from = new System.Windows.Forms.DateTimePicker();
			this.lbl_PlanYMD = new System.Windows.Forms.Label();
			this.lbl_Line = new System.Windows.Forms.Label();
			this.lbl_HeaderTitle = new System.Windows.Forms.Label();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.dpick_date_To = new System.Windows.Forms.DateTimePicker();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.fgrid_main = new COM.FSP();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.tab_Content = new System.Windows.Forms.TabControl();
			this.Pag_Summary = new System.Windows.Forms.TabPage();
			this.Pag_01 = new System.Windows.Forms.TabPage();
			this.fgrid_SP1 = new COM.FSP();
			this.Pag_02 = new System.Windows.Forms.TabPage();
			this.fgrid_SU = new COM.FSP();
			this.Pag_03 = new System.Windows.Forms.TabPage();
			this.fgrid_FA = new COM.FSP();
			this.Pag_04 = new System.Windows.Forms.TabPage();
			this.fgrid_HO = new COM.FSP();
			this.Pag_05 = new System.Windows.Forms.TabPage();
			this.fgrid_SP2 = new COM.FSP();
			this.cmenu_Menu1 = new C1.Win.C1Command.C1ContextMenu();
			this.c1CommandLink8 = new C1.Win.C1Command.C1CommandLink();
			this.cmenu_PlanComplete = new C1.Win.C1Command.C1Command();
			this.c1CommandLink9 = new C1.Win.C1Command.C1CommandLink();
			this.cmenu_InsertNewMiniLine = new C1.Win.C1Command.C1Command();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.tab_Main.SuspendLayout();
			this.tabPageDemandPlan.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_DemandPlan)).BeginInit();
			this.panel4.SuspendLayout();
			this.pnl_head.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbm_Line)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			this.tab_Content.SuspendLayout();
			this.Pag_Summary.SuspendLayout();
			this.Pag_01.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_SP1)).BeginInit();
			this.Pag_02.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_SU)).BeginInit();
			this.Pag_03.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_FA)).BeginInit();
			this.Pag_04.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_HO)).BeginInit();
			this.Pag_05.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_SP2)).BeginInit();
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
			this.c1CommandHolder1.Commands.Add(this.cmenu_Menu1);
			this.c1CommandHolder1.Commands.Add(this.cmenu_PlanComplete);
			this.c1CommandHolder1.Commands.Add(this.cmenu_InsertNewMiniLine);
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
			// tbtn_Delete
			// 
			this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
			// 
			// stbar
			// 
			this.stbar.Name = "stbar";
			this.stbar.Text = "Month";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Text = "Plan Simulation";
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
			// c1CommandLink1
			// 
			this.c1CommandLink1.Text = "New";
			this.c1CommandLink1.ToolTipText = "New";
			// 
			// tab_Main
			// 
			this.tab_Main.Controls.Add(this.tabPageDemandPlan);
			this.tab_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tab_Main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tab_Main.ItemSize = new System.Drawing.Size(73, 19);
			this.tab_Main.Location = new System.Drawing.Point(0, 0);
			this.tab_Main.Multiline = true;
			this.tab_Main.Name = "tab_Main";
			this.tab_Main.SelectedIndex = 0;
			this.tab_Main.Size = new System.Drawing.Size(1016, 160);
			this.tab_Main.TabIndex = 29;
			this.tab_Main.Click += new System.EventHandler(this.tab_Main_Click);
			// 
			// tabPageDemandPlan
			// 
			this.tabPageDemandPlan.BackColor = System.Drawing.SystemColors.Window;
			this.tabPageDemandPlan.Controls.Add(this.fgrid_DemandPlan);
			this.tabPageDemandPlan.Controls.Add(this.panel4);
			this.tabPageDemandPlan.DockPadding.Top = -6;
			this.tabPageDemandPlan.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tabPageDemandPlan.Location = new System.Drawing.Point(4, 23);
			this.tabPageDemandPlan.Name = "tabPageDemandPlan";
			this.tabPageDemandPlan.Size = new System.Drawing.Size(1008, 133);
			this.tabPageDemandPlan.TabIndex = 0;
			this.tabPageDemandPlan.Text = "Demand Plan";
			// 
			// fgrid_DemandPlan
			// 
			this.fgrid_DemandPlan.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Rows;
			this.fgrid_DemandPlan.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_DemandPlan.ColumnInfo = "0,0,0,0,0,80,Columns:";
			this.fgrid_DemandPlan.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_DemandPlan.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(2)));
			this.fgrid_DemandPlan.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_DemandPlan.Location = new System.Drawing.Point(0, 27);
			this.fgrid_DemandPlan.Name = "fgrid_DemandPlan";
			this.fgrid_DemandPlan.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_DemandPlan.Size = new System.Drawing.Size(1008, 106);
			this.fgrid_DemandPlan.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 7pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_DemandPlan.TabIndex = 178;
			this.fgrid_DemandPlan.BeforeMouseDown += new C1.Win.C1FlexGrid.BeforeMouseDownEventHandler(this.fgrid_DemandPlan_BeforeMouseDown);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.dpickDate_To);
			this.panel4.Controls.Add(this.btn_Search);
			this.panel4.Controls.Add(this.dpickDate_From);
			this.panel4.Controls.Add(this.lblOs);
			this.panel4.Controls.Add(this.txt_Os);
			this.panel4.Controls.Add(this.lblMonth);
			this.panel4.Controls.Add(this.lblDevName);
			this.panel4.Controls.Add(this.txt_DevName);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, -6);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1008, 33);
			this.panel4.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(208, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 16);
			this.label1.TabIndex = 675;
			this.label1.Text = "~";
			// 
			// dpickDate_To
			// 
			this.dpickDate_To.CustomFormat = "yyyy-MM";
			this.dpickDate_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpickDate_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpickDate_To.Location = new System.Drawing.Point(224, 8);
			this.dpickDate_To.Name = "dpickDate_To";
			this.dpickDate_To.Size = new System.Drawing.Size(96, 21);
			this.dpickDate_To.TabIndex = 674;
			// 
			// btn_Search
			// 
			this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Search.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_Search.ImageIndex = 12;
			this.btn_Search.ImageList = this.image_List;
			this.btn_Search.Location = new System.Drawing.Point(923, 7);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(80, 23);
			this.btn_Search.TabIndex = 673;
			this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// dpickDate_From
			// 
			this.dpickDate_From.CustomFormat = "yyyy-MM";
			this.dpickDate_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpickDate_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpickDate_From.Location = new System.Drawing.Point(112, 9);
			this.dpickDate_From.Name = "dpickDate_From";
			this.dpickDate_From.Size = new System.Drawing.Size(96, 21);
			this.dpickDate_From.TabIndex = 666;
			this.dpickDate_From.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dpickDate_KeyDown);
			// 
			// lblOs
			// 
			this.lblOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.lblOs.ImageIndex = 2;
			this.lblOs.ImageList = this.img_Label;
			this.lblOs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblOs.Location = new System.Drawing.Point(336, 8);
			this.lblOs.Name = "lblOs";
			this.lblOs.Size = new System.Drawing.Size(100, 21);
			this.lblOs.TabIndex = 665;
			this.lblOs.Text = "Os";
			this.lblOs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Os
			// 
			this.txt_Os.BackColor = System.Drawing.Color.White;
			this.txt_Os.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Os.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Os.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Os.Location = new System.Drawing.Point(440, 8);
			this.txt_Os.MaxLength = 100;
			this.txt_Os.Name = "txt_Os";
			this.txt_Os.Size = new System.Drawing.Size(120, 21);
			this.txt_Os.TabIndex = 663;
			this.txt_Os.Text = "";
			this.txt_Os.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Os_KeyDown);
			// 
			// lblMonth
			// 
			this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.lblMonth.ImageIndex = 2;
			this.lblMonth.ImageList = this.img_Label;
			this.lblMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblMonth.Location = new System.Drawing.Point(8, 9);
			this.lblMonth.Name = "lblMonth";
			this.lblMonth.Size = new System.Drawing.Size(100, 21);
			this.lblMonth.TabIndex = 662;
			this.lblMonth.Text = "Date";
			this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDevName
			// 
			this.lblDevName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.lblDevName.ImageIndex = 2;
			this.lblDevName.ImageList = this.img_Label;
			this.lblDevName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblDevName.Location = new System.Drawing.Point(568, 8);
			this.lblDevName.Name = "lblDevName";
			this.lblDevName.Size = new System.Drawing.Size(100, 21);
			this.lblDevName.TabIndex = 665;
			this.lblDevName.Text = "Dev Name";
			this.lblDevName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_DevName
			// 
			this.txt_DevName.BackColor = System.Drawing.Color.White;
			this.txt_DevName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_DevName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_DevName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_DevName.Location = new System.Drawing.Point(672, 8);
			this.txt_DevName.MaxLength = 100;
			this.txt_DevName.Name = "txt_DevName";
			this.txt_DevName.Size = new System.Drawing.Size(120, 21);
			this.txt_DevName.TabIndex = 663;
			this.txt_DevName.Text = "";
			this.txt_DevName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_DevName_KeyDown);
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.txtFontSize);
			this.pnl_head.Controls.Add(this.groupBox1);
			this.pnl_head.Controls.Add(this.label5);
			this.pnl_head.Controls.Add(this.cbm_Line);
			this.pnl_head.Controls.Add(this.dpick_date_from);
			this.pnl_head.Controls.Add(this.lbl_PlanYMD);
			this.pnl_head.Controls.Add(this.lbl_Line);
			this.pnl_head.Controls.Add(this.lbl_HeaderTitle);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.cmb_Factory);
			this.pnl_head.Controls.Add(this.lbl_Factory);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Controls.Add(this.pictureBox2);
			this.pnl_head.Controls.Add(this.pictureBox3);
			this.pnl_head.Controls.Add(this.pictureBox4);
			this.pnl_head.Controls.Add(this.dpick_date_To);
			this.pnl_head.Controls.Add(this.pictureBox5);
			this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_head.Location = new System.Drawing.Point(0, 0);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(1016, 100);
			this.pnl_head.TabIndex = 31;
			// 
			// txtFontSize
			// 
			this.txtFontSize.Location = new System.Drawing.Point(976, 48);
			this.txtFontSize.MaxLength = 2;
			this.txtFontSize.Name = "txtFontSize";
			this.txtFontSize.Size = new System.Drawing.Size(32, 22);
			this.txtFontSize.TabIndex = 567;
			this.txtFontSize.Text = "6";
			this.txtFontSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFontSize_KeyPress);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbt_Model);
			this.groupBox1.Controls.Add(this.rbt_Line);
			this.groupBox1.Location = new System.Drawing.Point(816, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(144, 32);
			this.groupBox1.TabIndex = 566;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "View Option";
			// 
			// rbt_Model
			// 
			this.rbt_Model.BackColor = System.Drawing.Color.Transparent;
			this.rbt_Model.Location = new System.Drawing.Point(64, 12);
			this.rbt_Model.Name = "rbt_Model";
			this.rbt_Model.Size = new System.Drawing.Size(64, 22);
			this.rbt_Model.TabIndex = 0;
			this.rbt_Model.Text = "Model";
			this.rbt_Model.CheckedChanged += new System.EventHandler(this.rbt_Model_CheckedChanged);
			// 
			// rbt_Line
			// 
			this.rbt_Line.BackColor = System.Drawing.Color.Transparent;
			this.rbt_Line.Checked = true;
			this.rbt_Line.Location = new System.Drawing.Point(8, 12);
			this.rbt_Line.Name = "rbt_Line";
			this.rbt_Line.Size = new System.Drawing.Size(48, 22);
			this.rbt_Line.TabIndex = 0;
			this.rbt_Line.TabStop = true;
			this.rbt_Line.Text = "Line";
			this.rbt_Line.CheckedChanged += new System.EventHandler(this.rbt_Line_CheckedChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(456, 50);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(16, 16);
			this.label5.TabIndex = 565;
			this.label5.Text = "~";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbm_Line
			// 
			this.cbm_Line.AddItemCols = 0;
			this.cbm_Line.AddItemSeparator = ';';
			this.cbm_Line.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbm_Line.AutoSize = false;
			this.cbm_Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cbm_Line.Caption = "";
			this.cbm_Line.CaptionHeight = 17;
			this.cbm_Line.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbm_Line.ColumnCaptionHeight = 18;
			this.cbm_Line.ColumnFooterHeight = 18;
			this.cbm_Line.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbm_Line.ContentHeight = 17;
			this.cbm_Line.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbm_Line.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbm_Line.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cbm_Line.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbm_Line.EditorHeight = 17;
			this.cbm_Line.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cbm_Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbm_Line.GapHeight = 2;
			this.cbm_Line.ItemHeight = 15;
			this.cbm_Line.Location = new System.Drawing.Point(664, 48);
			this.cbm_Line.MatchEntryTimeout = ((long)(2000));
			this.cbm_Line.MaxDropDownItems = ((short)(5));
			this.cbm_Line.MaxLength = 32767;
			this.cbm_Line.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbm_Line.Name = "cbm_Line";
			this.cbm_Line.PartialRightColumn = false;
			this.cbm_Line.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"rollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Widt" +
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
				"ified</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cbm_Line.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbm_Line.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbm_Line.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbm_Line.Size = new System.Drawing.Size(144, 21);
			this.cbm_Line.TabIndex = 10;
			// 
			// dpick_date_from
			// 
			this.dpick_date_from.CustomFormat = "yyyy-MM-dd";
			this.dpick_date_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_date_from.Location = new System.Drawing.Point(368, 48);
			this.dpick_date_from.Name = "dpick_date_from";
			this.dpick_date_from.Size = new System.Drawing.Size(88, 21);
			this.dpick_date_from.TabIndex = 564;
			this.dpick_date_from.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dpick_date_from_KeyDown);
			// 
			// lbl_PlanYMD
			// 
			this.lbl_PlanYMD.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_PlanYMD.ImageIndex = 1;
			this.lbl_PlanYMD.ImageList = this.img_Label;
			this.lbl_PlanYMD.Location = new System.Drawing.Point(264, 48);
			this.lbl_PlanYMD.Name = "lbl_PlanYMD";
			this.lbl_PlanYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_PlanYMD.TabIndex = 543;
			this.lbl_PlanYMD.Text = "Plan Month";
			this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Line
			// 
			this.lbl_Line.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Line.ImageIndex = 1;
			this.lbl_Line.ImageList = this.img_Label;
			this.lbl_Line.Location = new System.Drawing.Point(560, 48);
			this.lbl_Line.Name = "lbl_Line";
			this.lbl_Line.Size = new System.Drawing.Size(104, 21);
			this.lbl_Line.TabIndex = 405;
			this.lbl_Line.Text = "Line";
			this.lbl_Line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_HeaderTitle
			// 
			this.lbl_HeaderTitle.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_HeaderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.lbl_HeaderTitle.ForeColor = System.Drawing.Color.Navy;
			this.lbl_HeaderTitle.Image = ((System.Drawing.Image)(resources.GetObject("lbl_HeaderTitle.Image")));
			this.lbl_HeaderTitle.Location = new System.Drawing.Point(0, 0);
			this.lbl_HeaderTitle.Name = "lbl_HeaderTitle";
			this.lbl_HeaderTitle.Size = new System.Drawing.Size(231, 30);
			this.lbl_HeaderTitle.TabIndex = 393;
			this.lbl_HeaderTitle.Text = "      Search Information";
			this.lbl_HeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(1000, 84);
			this.pic_head3.Name = "pic_head3";
			this.pic_head3.Size = new System.Drawing.Size(16, 16);
			this.pic_head3.TabIndex = 45;
			this.pic_head3.TabStop = false;
			// 
			// pic_head4
			// 
			this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
			this.pic_head4.Location = new System.Drawing.Point(136, 83);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(976, 18);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
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
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(109, 48);
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
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}He" +
				"ading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText" +
				";BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Widt" +
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
				"ified</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(147, 21);
			this.cmb_Factory.TabIndex = 10;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(8, 48);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 50;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head7
			// 
			this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
			this.pic_head7.Location = new System.Drawing.Point(915, 30);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.Size = new System.Drawing.Size(101, 59);
			this.pic_head7.TabIndex = 46;
			this.pic_head7.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(1000, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 32);
			this.pictureBox2.TabIndex = 44;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(0, 84);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(168, 20);
			this.pictureBox3.TabIndex = 43;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(0, 4);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(168, 82);
			this.pictureBox4.TabIndex = 41;
			this.pictureBox4.TabStop = false;
			// 
			// dpick_date_To
			// 
			this.dpick_date_To.CustomFormat = "yyyy-MM-dd";
			this.dpick_date_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_date_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_date_To.Location = new System.Drawing.Point(472, 48);
			this.dpick_date_To.Name = "dpick_date_To";
			this.dpick_date_To.Size = new System.Drawing.Size(88, 21);
			this.dpick_date_To.TabIndex = 564;
			this.dpick_date_To.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dpick_date_To_KeyDown);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(160, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(936, 32);
			this.pictureBox5.TabIndex = 39;
			this.pictureBox5.TabStop = false;
			// 
			// fgrid_main
			// 
			this.fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Rows;
			this.fgrid_main.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free;
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.c1CommandHolder1.SetC1ContextMenu(this.fgrid_main, this.cmenu_Menu1);
			this.fgrid_main.ColumnInfo = "0,0,0,0,0,80,Columns:";
			this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual;
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(2)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ColumnRange;
			this.fgrid_main.Size = new System.Drawing.Size(1008, 297);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 178;
			this.fgrid_main.DragOver += new System.Windows.Forms.DragEventHandler(this.fgrid_main_DragOver);
			this.fgrid_main.MouseLeave += new System.EventHandler(this.fgrid_main_MouseLeave);
			this.fgrid_main.BeforeMouseDown += new C1.Win.C1FlexGrid.BeforeMouseDownEventHandler(this.fgrid_main_BeforeMouseDown);
			this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
			this.fgrid_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseDown);
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			this.fgrid_main.DragDrop += new System.Windows.Forms.DragEventHandler(this.fgrid_main_DragDrop);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tab_Main);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 484);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1016, 160);
			this.panel2.TabIndex = 179;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.pnl_head);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 80);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1016, 80);
			this.panel3.TabIndex = 180;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.tab_Content);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 160);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1016, 324);
			this.panel5.TabIndex = 181;
			// 
			// tab_Content
			// 
			this.tab_Content.Controls.Add(this.Pag_Summary);
			this.tab_Content.Controls.Add(this.Pag_01);
			this.tab_Content.Controls.Add(this.Pag_02);
			this.tab_Content.Controls.Add(this.Pag_03);
			this.tab_Content.Controls.Add(this.Pag_04);
			this.tab_Content.Controls.Add(this.Pag_05);
			this.tab_Content.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tab_Content.Location = new System.Drawing.Point(0, 0);
			this.tab_Content.Name = "tab_Content";
			this.tab_Content.SelectedIndex = 0;
			this.tab_Content.Size = new System.Drawing.Size(1016, 324);
			this.tab_Content.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tab_Content.TabIndex = 179;
			this.tab_Content.SelectedIndexChanged += new System.EventHandler(this.tab_Content_SelectedIndexChanged);
			// 
			// Pag_Summary
			// 
			this.Pag_Summary.Controls.Add(this.fgrid_main);
			this.Pag_Summary.Location = new System.Drawing.Point(4, 23);
			this.Pag_Summary.Name = "Pag_Summary";
			this.Pag_Summary.Size = new System.Drawing.Size(1008, 297);
			this.Pag_Summary.TabIndex = 0;
			this.Pag_Summary.Text = "Summary";
			// 
			// Pag_01
			// 
			this.Pag_01.Controls.Add(this.fgrid_SP1);
			this.Pag_01.Location = new System.Drawing.Point(4, 23);
			this.Pag_01.Name = "Pag_01";
			this.Pag_01.Size = new System.Drawing.Size(1008, 297);
			this.Pag_01.TabIndex = 1;
			this.Pag_01.Tag = "SP{0}";
			this.Pag_01.Text = "SP{0}";
			// 
			// fgrid_SP1
			// 
			this.fgrid_SP1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_SP1.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free;
			this.fgrid_SP1.BackColor = System.Drawing.SystemColors.Window;
			this.c1CommandHolder1.SetC1ContextMenu(this.fgrid_SP1, this.cmenu_Menu1);
			this.fgrid_SP1.ColumnInfo = "0,0,0,0,0,80,Columns:";
			this.fgrid_SP1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_SP1.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual;
			this.fgrid_SP1.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(2)));
			this.fgrid_SP1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_SP1.Location = new System.Drawing.Point(0, 0);
			this.fgrid_SP1.Name = "fgrid_SP1";
			this.fgrid_SP1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_SP1.Size = new System.Drawing.Size(1008, 297);
			this.fgrid_SP1.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_SP1.TabIndex = 179;
			// 
			// Pag_02
			// 
			this.Pag_02.Controls.Add(this.fgrid_SU);
			this.Pag_02.Location = new System.Drawing.Point(4, 23);
			this.Pag_02.Name = "Pag_02";
			this.Pag_02.Size = new System.Drawing.Size(1008, 297);
			this.Pag_02.TabIndex = 2;
			this.Pag_02.Tag = "SU{0}";
			this.Pag_02.Text = "SU{0}";
			// 
			// fgrid_SU
			// 
			this.fgrid_SU.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_SU.ColumnInfo = "10,1,0,0,0,80,Columns:";
			this.fgrid_SU.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_SU.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(2)));
			this.fgrid_SU.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_SU.Location = new System.Drawing.Point(0, 0);
			this.fgrid_SU.Name = "fgrid_SU";
			this.fgrid_SU.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_SU.Size = new System.Drawing.Size(1008, 297);
			this.fgrid_SU.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 7pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_SU.TabIndex = 180;
			// 
			// Pag_03
			// 
			this.Pag_03.Controls.Add(this.fgrid_FA);
			this.Pag_03.Location = new System.Drawing.Point(4, 23);
			this.Pag_03.Name = "Pag_03";
			this.Pag_03.Size = new System.Drawing.Size(1008, 297);
			this.Pag_03.TabIndex = 3;
			this.Pag_03.Tag = "FA{0}";
			this.Pag_03.Text = "FA{0}";
			// 
			// fgrid_FA
			// 
			this.fgrid_FA.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_FA.ColumnInfo = "10,1,0,0,0,80,Columns:";
			this.fgrid_FA.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_FA.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(2)));
			this.fgrid_FA.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_FA.Location = new System.Drawing.Point(0, 0);
			this.fgrid_FA.Name = "fgrid_FA";
			this.fgrid_FA.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_FA.Size = new System.Drawing.Size(1008, 297);
			this.fgrid_FA.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 7pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_FA.TabIndex = 180;
			// 
			// Pag_04
			// 
			this.Pag_04.Controls.Add(this.fgrid_HO);
			this.Pag_04.Location = new System.Drawing.Point(4, 23);
			this.Pag_04.Name = "Pag_04";
			this.Pag_04.Size = new System.Drawing.Size(1008, 297);
			this.Pag_04.TabIndex = 4;
			this.Pag_04.Tag = "HO{0}";
			this.Pag_04.Text = "HO{0}";
			// 
			// fgrid_HO
			// 
			this.fgrid_HO.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_HO.ColumnInfo = "10,1,0,0,0,80,Columns:";
			this.fgrid_HO.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_HO.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(2)));
			this.fgrid_HO.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_HO.Location = new System.Drawing.Point(0, 0);
			this.fgrid_HO.Name = "fgrid_HO";
			this.fgrid_HO.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_HO.Size = new System.Drawing.Size(1008, 297);
			this.fgrid_HO.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 7pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_HO.TabIndex = 180;
			// 
			// Pag_05
			// 
			this.Pag_05.Controls.Add(this.fgrid_SP2);
			this.Pag_05.Location = new System.Drawing.Point(4, 23);
			this.Pag_05.Name = "Pag_05";
			this.Pag_05.Size = new System.Drawing.Size(1008, 297);
			this.Pag_05.TabIndex = 5;
			this.Pag_05.Tag = "SP{0}";
			this.Pag_05.Text = "SP{0}";
			// 
			// fgrid_SP2
			// 
			this.fgrid_SP2.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_SP2.ColumnInfo = "10,1,0,0,0,80,Columns:";
			this.fgrid_SP2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_SP2.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(2)));
			this.fgrid_SP2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_SP2.Location = new System.Drawing.Point(0, 0);
			this.fgrid_SP2.Name = "fgrid_SP2";
			this.fgrid_SP2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_SP2.Size = new System.Drawing.Size(1008, 297);
			this.fgrid_SP2.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 7pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_SP2.TabIndex = 180;
			// 
			// cmenu_Menu1
			// 
			this.cmenu_Menu1.CommandLinks.Add(this.c1CommandLink8);
			this.cmenu_Menu1.CommandLinks.Add(this.c1CommandLink9);
			this.cmenu_Menu1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.cmenu_Menu1.Name = "cmenu_Menu1";
			// 
			// c1CommandLink8
			// 
			this.c1CommandLink8.Command = this.cmenu_PlanComplete;
			// 
			// cmenu_PlanComplete
			// 
			this.cmenu_PlanComplete.Name = "cmenu_PlanComplete";
			this.cmenu_PlanComplete.Text = "Plan Complete";
			this.cmenu_PlanComplete.Click += new C1.Win.C1Command.ClickEventHandler(this.cmenu_PlanComplete_Click);
			// 
			// c1CommandLink9
			// 
			this.c1CommandLink9.Command = this.cmenu_InsertNewMiniLine;
			// 
			// cmenu_InsertNewMiniLine
			// 
			this.cmenu_InsertNewMiniLine.Name = "cmenu_InsertNewMiniLine";
			this.cmenu_InsertNewMiniLine.Text = "Insert New M/L";
			this.cmenu_InsertNewMiniLine.Click += new C1.Win.C1Command.ClickEventHandler(this.cmenu_InsertNewMiniLine_Click);
			// 
			// Form_Plan_Simulation
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Name = "Form_Plan_Simulation";
			this.Text = "Plan Simulation";
			this.Load += new System.EventHandler(this.Form_Plan_Simulation_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.panel3, 0);
			this.Controls.SetChildIndex(this.panel5, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.tab_Main.ResumeLayout(false);
			this.tabPageDemandPlan.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_DemandPlan)).EndInit();
			this.panel4.ResumeLayout(false);
			this.pnl_head.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cbm_Line)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.tab_Content.ResumeLayout(false);
			this.Pag_Summary.ResumeLayout(false);
			this.Pag_01.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_SP1)).EndInit();
			this.Pag_02.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_SU)).EndInit();
			this.Pag_03.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_FA)).EndInit();
			this.Pag_04.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_HO)).EndInit();
			this.Pag_05.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_SP2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		
	
		#region "Declarce Variable"
		private bool _DemandPlan_ON_Flag = false;
		private int _Rowfixed = 1;
		private int _MainRowfixed = 1;
		private int _MainRowfixedSP1 = 1;
		private int _MainRowfixedSU = 1;
		private int _MainRowfixedFA = 1;
		private int _MainRowfixedHO = 1;
		private int _MainRowfixedSP2 = 1;
		private int _DynamicColWidth = 34;
		private COM.OraDB MyOraDB = new COM.OraDB();
		private bool _Flag_ItemMove =false;
		private int _MaxCol = 13;
		private int _MaxColGS = 9;
		private object _CurrBuff=null;
		private CellStyle _Style_edit = null;

		private  Color T1_Color = Color.FromArgb(255,255,0);
		private  Color T2_Color = Color.FromArgb(246,150,10);
		private  Color T3_Color = Color.FromArgb(181,255,4);
		private  Color T4_Color = Color.FromArgb(22,252,4);
		private  Color T5_Color = Color.FromArgb(4,222,252);
		private  Color T6_Color = Color.FromArgb(5,134,251);
		private  Color T7_Color = Color.FromArgb(209,7,249);
		private  Color T8_Color = Color.FromArgb(249,7,111);
		private  Color T9_Color = Color.FromArgb(99,157,139);
		private  Color T10_Color = Color.FromArgb(166,164,92);
		private  Color T11_Color = Color.FromArgb(236,87,20);
		private  Color T12_Color = Color.FromArgb(38,218,218);
		private Color ColCompletePlan = Color.LightGray;

		private CellStyle _CellTotal = null;

		private string _FontName = "Verdana";
		private float _FontSize = 6;
		#endregion

		#region "Constant Argument"
		private const string ARG_FACTORY = "ARG_FACTORY";
		private const string ARG_MONTH = "ARG_MONTH";
		private const string ARG_LINE_CD = "ARG_LINE_CD";
		private const string ARG_OS_CODE = "ARG_OS_CODE";
		private const string ARG_DEV_NAME = "ARG_DEV_NAME";
	    private const string OUT_CURSOR = "OUT_CURSOR";
		private const string ARG_FROM_DATE = "ARG_FROM_DATE";
		private const string ARG_TO_DATE = "ARG_TO_DATE";

		private const string ARG_FROM_OBS_ID = "ARG_FROM_OBS_ID";
		private const string ARG_TO_OBS_ID = "ARG_TO_OBS_ID";
		private const string ARG_SEASON = "ARG_SEASON";
		private const string ARG_YEAR = "ARG_YEAR";

		private const string ARG_MINI_LINE = "ARG_MINI_LINE";
		private const string ARG_PLAN_YMD = "ARG_PLAN_YMD";
		//private const string ARG_MID_SOLE_1 = "ARG_MID_SOLE_1";
		//private const string ARG_MID_SOLE_2 = "ARG_MID_SOLE_2";
		//private const string ARG_MID_SOLE_3 = "ARG_MID_SOLE_3";
		private const string ARG_ITEM = "ARG_ITEM";
		private const string ARG_PLAN_QTY = "ARG_PLAN_QTY";
		private const string ARG_UPD_USER = "ARG_UPD_USER";
		private const string ARG_MPS_YN = "ARG_MPS_YN";
		private const string ARG_WORK_DAYS = "ARG_WORK_DAYS";
		private const string ARG_DAILY_CAPA = "ARG_DAILY_CAPA";


		#endregion

		#region "Constant Column Grid"
		private static int  G1_COL_FACTORY = 1;
		private static int  G1_COL_SEQ = 2;
		private static int 	G1_COL_LINE_CD = 3;
		//private static int 	G1_COL_MINI_LINE    = 4;
		private static int  G1_COL_PLAN_YMD = 4;
		private static int 	G1_COL_MID_SOLE_1 = 5;
		private static int 	G1_COL_MID_SOLE_2 = 6;
		private static int 	G1_COL_MID_SOLE_3 = 7;
		private static int  G1_COL_MODEL_CD =8;
		private static int  G1_COL_OS_CODE = 9;
		private static int  G1_COL_ITEM = 10;
		private static int  G1_COL_ODS_ID = 11;
		private static int	G1_COL_PLAN_QTY = 12;
		//private static int	G1_COL_CAPA_QTY = 14;

		
		private static int G2_COL_FACTORY= 1;
		private static int G2_COL_CATEGORY_NAME = 2;
		private static int G2_COL_OBS_ID = 3;
		private static int G2_COL_OS_CODE = 4;
		private static int G2_COL_LINE_CD = 5;
		private static int G2_COL_MINI_LINE = 6;
		private static int G2_COL_MID_SOLE1 = 7;
		private static int G2_COL_MID_SOLE2 = 8;
		private static int G2_COL_MID_SOLE3 = 9;
		private static int G2_COL_MODEL_CD = 10;
		private static int G2_COL_DEV_NAME = 11;		
		private static int G2_COL_PLAN_MONTH = 12;
		private static int G2_COL_PLAN_QTY = 13;
		private static int G2_COL_REMARK01 = 14;
		private static int G2_COL_REMARK02 = 15;
		private static int G2_COL_REMARK03 = 16;

		private static int GS_COL_FACTORY = 1;
		private static int GS_COL_SEQ = 2;
		private static int GS_COL_LINE_CD = 3;
		private static int GS_COL_MODEL = 4;
		private static int GS_COL_TOTAL = 5;
		private static int GS_COL_OS_CODE = 8;
		private static int GS_COL_OBS_ID_2 = 6;
		private static int GS_COL_MODEL_CD = 7;


		#endregion 

		#region "Init"

		private void Init_Form()
		{
			Init_Control();
			InitCellStyle();
			//fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
			
		}
		
		private void Init_Grid(ref COM.FSP arg_fgrid, string arg_seq, int arg_hcount)
		{
			if(fgrid_main.Name == "fgrid_main")
			{
				arg_fgrid.Set_Grid("LST_SVM_PLAN_SIMULATION",arg_seq,arg_hcount,COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);	
			}
			else
			{
				arg_fgrid.Set_Grid("LST_SVM_PLAN_SIMULATION",arg_seq,arg_hcount,COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);	
			}
			arg_fgrid.Set_Action_Image(img_Action);
			arg_fgrid.AllowMerging = AllowMergingEnum.FixedOnly;				
			arg_fgrid.Cols[G1_COL_LINE_CD].AllowMerging = true;
			arg_fgrid.SelectionMode = SelectionModeEnum.Default;
			arg_fgrid.Font = new Font(_FontName,_FontSize);
		}

		private void Init_Control()
		{
			tbtn_Insert.Enabled=false;
			//tbtn_Print.Enabled=false;
			tbtn_Confirm.Enabled=false;
			tbtn_Create.Enabled=false;
			//tbtn_New.Enabled=false;


			//init tab demand plan
			tab_Main_Click(tab_Main,null);
			

			fgrid_DemandPlan.Set_Grid("LST_SVM_DP_LOAD","2",2,COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);	
			_Rowfixed = fgrid_DemandPlan.Rows.Fixed;
			fgrid_DemandPlan.Cols[G2_COL_PLAN_MONTH].Style.Format = "yyyy-MM-dd";
			fgrid_DemandPlan.Font = new Font(_FontName,_FontSize);

			//init gird main
			Init_Grid(ref fgrid_main,"2",3);
			_MainRowfixed = fgrid_main.Rows.Fixed;
			fgrid_main.FocusRect = FocusRectEnum.None;
			/*fgrid_main.Set_Grid("LST_SVM_PLAN_SIMULATION","2",3,COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);				
			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.AllowMerging = AllowMergingEnum.FixedOnly;				
			fgrid_main.Cols[G1_COL_LINE_CD].AllowMerging = true;
			fgrid_main.SelectionMode = SelectionModeEnum.Default;
			fgrid_DemandPlan.Font = new Font("Verdana", 6);
			fgrid_main.Font = new Font("Verdana", 6);*/
			//init grid at tab SP 1
			Init_Grid(ref fgrid_SP1,"3",3);
			_MainRowfixedSP1 = fgrid_SP1.Rows.Fixed;
			/*fgrid_SP1.Set_Grid("LST_SVM_PLAN_SIMULATION","3",3,COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);				
			fgrid_SP1.Set_Action_Image(img_Action);
			fgrid_SP1.AllowMerging = AllowMergingEnum.FixedOnly;				
			fgrid_SP1.Cols[G1_COL_LINE_CD].AllowMerging = true;
			fgrid_SP1.SelectionMode = SelectionModeEnum.Default;
			fgrid_DemandPlan.Font = new Font("Verdana", 6);
			fgrid_main.Font = new Font("Verdana", 6);*/
			
			//init grid at tab SU
			Init_Grid(ref fgrid_SU,"3",3);
			_MainRowfixedSU = fgrid_SP1.Rows.Fixed;

			//init grid at tab FA
			Init_Grid(ref fgrid_FA,"3",3);
			_MainRowfixedFA = fgrid_SP1.Rows.Fixed;

			//init grid at tab HO
			Init_Grid(ref fgrid_HO,"3",3);
			_MainRowfixedHO = fgrid_SP1.Rows.Fixed;

			//init grid at tab SP 2
			Init_Grid(ref fgrid_SP2,"3",3);
			_MainRowfixedSP2 = fgrid_SP1.Rows.Fixed;

			//init header control
			DataTable dt_ret;

			// factory
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			// Line
			dt_ret = SELECT_LINE_INFO();
			COM.ComCtl.Set_ComboList(dt_ret, cbm_Line, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cbm_Line.SelectedIndex = 0;

			dt_ret.Dispose();

			//init datetime control
			Init_Time_Control();
			Init_Tab_Control(Convert.ToInt32( dpick_date_from.Value.Year.ToString().Substring(2,2)));
		
	
			

		}
		
		private void Init_Tab_Control(int arg_Year)
		{
			//tab sumary not init
			//tab sp 1
			Pag_01.Text = string.Format(Pag_01.Tag.ToString(),arg_Year);
			//tab su
			Pag_02.Text = string.Format(Pag_02.Tag.ToString(),arg_Year);
			//tab fa
			Pag_03.Text = string.Format(Pag_03.Tag.ToString(),arg_Year);
			//tab ho
			Pag_04.Text = string.Format(Pag_04.Tag.ToString(),arg_Year);
			//tab sp 2
			Pag_05.Text = string.Format(Pag_05.Tag.ToString(),arg_Year + 1);
		}
		private void Init_CellStyle ()
		{

		}
		private void Init_Time_Control()
		{
			DateTime _CurTime = System.DateTime.Now;
			string sFrom_date = _CurTime.AddDays(42).ToString("yyyy-MM-dd");//current time + 6 week
			string sTo_date   = _CurTime.AddDays(42).AddMonths(2).ToString("yyyy-MM-dd");//from time add 2 months
						 
			dpick_date_from.Text = sFrom_date;
			dpick_date_To.Text   = sTo_date;
		}

		
		#endregion

		#region "Event"
		
		private void tab_Main_Click(object sender, System.EventArgs e)
		{
			try
			{
				_DemandPlan_ON_Flag = !_DemandPlan_ON_Flag;
				if(_DemandPlan_ON_Flag)
				{
					panel2.Size = new Size(1008, 160); 
				}
				else
				{	
					panel2.Size = new Size(1008, 24);
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tab_Main_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}				
		}
		
		
		private void Form_Plan_Simulation_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			cmb_Factory.SelectedValueChanged+=new EventHandler(cmb_Factory_SelectedValueChanged);
			cbm_Line.SelectedValueChanged+=new EventHandler(cbm_Line_SelectedValueChanged);
			//dpick_date_from.ValueChanged+=new EventHandler(dpick_date_from_ValueChanged);
			//dpick_date_To.ValueChanged+=new EventHandler(dpick_date_To_ValueChanged);
			//ExeSearch(6);

		}

		
		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;
				
				this.Tbtn_SearchProcess();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		
		private void txt_Os_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (!e.KeyData.Equals(Keys.Enter))
			{
				return;
			}
			btn_Search_Click(btn_Search,null);		
		}

		
		private void txt_DevName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (!e.KeyData.Equals(Keys.Enter))
			{
				return;
			}
			btn_Search_Click(btn_Search,null);
		}


		private void dpickDate_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (!e.KeyData.Equals(Keys.Enter))
			{
				return;
			}
			btn_Search_Click(btn_Search,null);
		}

		
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DialogResult dr;

//			if (Validate_Check())
//			{
				if(ClassLib.ComFunction.User_Message("Do you want to save?","save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
				{
					fgrid_main.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None;
					this.Tbtn_SaveProcess();					
				}
//			}
//			else
//			{
//				dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave);
//			}
		}

		private void FormatGird(ref COM.FSP gridTab)
		{
			DataSet vDt;
			MyOraDB.ReDim_Parameter(5);
			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION.SP_GET_MPS_YN";
			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = ARG_FACTORY;
			MyOraDB.Parameter_Name[1]  = ARG_FROM_DATE;
			MyOraDB.Parameter_Name[2]  = ARG_TO_DATE;
			MyOraDB.Parameter_Name[3]  = ARG_LINE_CD;
			MyOraDB.Parameter_Name[4]  = OUT_CURSOR;

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]   = dpick_date_from.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[2]   = dpick_date_To.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[3]   = cbm_Line.SelectedValue.ToString();
			MyOraDB.Parameter_Values[4]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return ;
			DataTable dt = vDt.Tables[MyOraDB.Process_Name];
			if (dt.Rows.Count < 1)
			{
				return;
			}
			
			for (int i = _MainRowfixed; i < gridTab.Rows.Count; i ++)
			{
				if (gridTab.Rows[i].AllowEditing==false)
				{
					continue;
				}
				for (int j = _MaxCol + 1; j < gridTab.Cols.Count; j ++)
				{
					for (int k =0 ; k< dt.Rows.Count; k++)
					{
						
                        if (gridTab[i,G1_COL_LINE_CD].ToString().Equals(dt.Rows[k][1].ToString())//mini lineTODO
							&& 
							gridTab.Cols[j].Caption.Equals(dt.Rows[k][0].ToString())//plan ymd
							&& dt.Rows[k][2].ToString().Equals("Y")//mps yn
							&& gridTab.Rows[i].UserData.ToString().Equals(dt.Rows[k][3].ToString())//LINE_CD
							&& gridTab[i,G1_COL_SEQ].ToString().Equals(dt.Rows[k][4].ToString())//SEQ
							)
                        {
							if (gridTab.GetCellStyle(i,j) == null)
							{
								CellStyle cs1=gridTab.Styles.Add("PlanComplete");
								cs1.BackColor =  ColCompletePlan;
								gridTab.SetCellStyle(i,j,cs1);
							}
                        }
					}
				}
			}
			//format color for grid
//			for(int iRow = fgrid_main.Rows.Fixed; iRow < fgrid_main.Rows.Count; iRow ++)
//			{
//				for(int iCol=_MaxCol + 1; iCol<fgrid_main.Rows.Count; iCol++)
//				{
//					//if(fgrid_main[iRow,iCol].ToString()="")
//						//continuos
//					---
//
//				}
//			}
			
		}
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 	
				this.Cursor = Cursors.WaitCursor;	
				fgrid_main.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None;
				ExeSearch(tab_Content.SelectedIndex);
				//fgrid_main.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Light;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void ExeSearch(int arg_TabIndex)
		{
			switch(arg_TabIndex)
			{
				case 0:
					
					this.Tbtn_SearchProcess_2();
//					if(rbt_Line.Checked == true)
//					{
//						SetViewOption(fgrid_main,ViewOption.Line);
//					}
//					else
//					{
//						SetViewOption(fgrid_main,ViewOption.Model);
//					}
					break;
				case 1://tab sp 1 selected
					//ActiveViewOption(ViewOption.Model);
					ExeTab(1,ref fgrid_SP1);
					break;
				case 2://tab su selected
					//ActiveViewOption(ViewOption.Model);
					ExeTab(2,ref fgrid_SU);
					break;
				case 3://tab fa selected
					//ActiveViewOption(ViewOption.Model);
					ExeTab(3,ref fgrid_FA);
					break;
				case 4://tab ho selected
					//ActiveViewOption(ViewOption.Model);
					ExeTab(4,ref fgrid_HO);
					break;
				case 5://tab sp 2 selected
					//ActiveViewOption(ViewOption.Model);
					ExeTab(5,ref fgrid_SP2);
					break;
				case 6:
					this.Tbtn_SearchProcess_2();
					
					ExeTab(1,ref fgrid_SP1);

					ExeTab(2,ref fgrid_SU);

					ExeTab(3,ref fgrid_FA);

					ExeTab(4,ref fgrid_HO);

					ExeTab(5,ref fgrid_SP2);

					break;
			}
		}
		private DataTable SEL_PLAN_COMPLETE()
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION.auto_sel_plan_complete";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = ARG_FACTORY;
			MyOraDB.Parameter_Name[1]  = ARG_LINE_CD;
			MyOraDB.Parameter_Name[2]  = OUT_CURSOR;

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]   = cbm_Line.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null;
			return vDt.Tables[MyOraDB.Process_Name];
		}
		private void Auto_Set_Plan_Complete ()
		{
			DataTable dt = SEL_PLAN_COMPLETE();
			MessageBox.Show(dt.Rows.Count.ToString());
			MessageBox.Show(Convert.ToString (dt.Rows[0][2]));
			if(dt.Rows.Count>0)
			{
				
//				string data1=Convert.ToString(dt.Rows[0][1]);
//				string data2=Convert.ToString(dt.Rows[0][2]);
//				double data3=Convert.ToDouble(dt.Rows[0][0]);

				string data1= dt.Rows[0].ItemArray[1].ToString();
				string data2= dt.Rows[0].ItemArray[2].ToString();
				double data3=Convert.ToDouble(dt.Rows[0].ItemArray[0].ToString());
				MessageBox.Show(data2);
				int indexRow = 0;
				int indexCol = 0 ;
				for (int i=13;i<fgrid_main.Cols.Count-1;i++)
				{
//					string tem = Convert.ToString(fgrid_main.Rows[0][i]);
//					if(data1== Convert.ToString(fgrid_main.Rows[0][i]))
					MessageBox.Show(fgrid_main[0,i].ToString());
                    if(data1== fgrid_main[0,i].ToString()) 
					{
						indexCol=i;
						break;
					}
				}
				if(indexCol!=0)
				{
					for (int j=4;j<fgrid_main.Rows.Count;j++)
					{
						indexRow=j;
						if (indexRow == -1)
						{
							return;
						}
						if (fgrid_main.Rows.Count <= _MainRowfixed)
						{
							return;
						}
						if (indexCol <= _MaxCol || indexCol > fgrid_main.Cols.Count)
						{
							return;
						}
						if (fgrid_main.Rows[indexRow].AllowEditing==false)
						{
							continue;
						}
						//clear plan complete
						for (int i = _MaxCol + 1; i < fgrid_main.Cols.Count; i++)
						{
							CellStyle cs1=fgrid_main.GetCellStyle(indexRow,G1_COL_LINE_CD);
							fgrid_main.SetCellStyle(indexRow,i,cs1);
						}

						//set plan complete
						if (fgrid_main.GetCellStyle(indexRow,indexCol) == null)
						{
							CellStyle cs1=fgrid_main.Styles.Add("PlanComplete");
							cs1.BackColor =  ColCompletePlan;
							cs1.ForeColor = ColCompletePlan;
							fgrid_main.SetCellStyle(indexRow,indexCol,cs1);		
						}
					}

					for (int k=4;k<fgrid_main.Rows.Count;k++)
					{
						indexRow=k;
						if (indexRow == -1)
						{
							return;
						}
						if (fgrid_main.Rows.Count <= _MainRowfixed)
						{
							return;
						}
						if (indexCol <= _MaxCol || indexCol > fgrid_main.Cols.Count)
						{
							return;
						}
						if (fgrid_main.Rows[indexRow].AllowEditing==false)
						{
							fgrid_main.Rows[indexRow][indexCol]=data3;
							break;
						}
						
						
					}
				}
				else
				{
					MessageBox.Show("Line Complete in "+data2+".Please Select period to this date !!!");
				}

			}
		}
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				if (cbm_Line.SelectedValue.ToString().Equals(" "))
				{
					ClassLib.ComFunction.User_Message("You must choose one line to create new!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					this.Tbtn_NewProcess();
					CalRowSum(ref fgrid_main);
					this.Tbtn_SearchProcess();
				}
			}
			catch (System.Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}		
		}
	
		
		private void cbm_Line_SelectedValueChanged(object sender, System.EventArgs e)
		{
			C1.Win.C1List.C1Combo l_Tmp = (C1.Win.C1List.C1Combo) sender;
//			if (l_Tmp.SelectedValue.Equals(" "))
//			{
//				tbtn_Save.Enabled = false;
//			}
//			else
//			{
//				tbtn_Save.Enabled = true;
//			}
			tbtn_Search_Click(tbtn_Search,null);
			this.Tbtn_SearchProcess();
		}

		
		private void fgrid_DemandPlan_BeforeMouseDown(object sender, C1.Win.C1FlexGrid.BeforeMouseDownEventArgs e)
		{
			_Flag_ItemMove = false;
			// start dragging when the user clicks the row headers 
			HitTestInfo hti = fgrid_DemandPlan.HitTest(e.X, e.Y);
 
			// select the row
			int index = hti.Row;
			if(index < fgrid_DemandPlan.Rows.Fixed) return;

			fgrid_DemandPlan.Select(index, 0, index, fgrid_DemandPlan.Cols.Count - 1, false);		
  
			// do drag drop
			DragDropEffects dd = fgrid_DemandPlan.DoDragDrop(fgrid_DemandPlan.Clip, DragDropEffects.Move);
			temp =  fgrid_DemandPlan.Name;
		}

		private CellStyle ResetCellWhiteColor()
		{
			CellStyle csTmp = fgrid_main.Styles.Add("CellWhiteColor");
			csTmp.ForeColor = Color.Black;
			csTmp.BackColor = Color.White;
			return csTmp;
		}
			
		private string temp ="";
		private void fgrid_main_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{

			if(temp=="fgrid_main")
			{
				COM.FSP l_fgrid_main = (COM.FSP)sender;
				int numcol =Convert.ToInt32(l_fgrid_main.Selection.c2.ToString())-Convert.ToInt32(l_fgrid_main.Selection.c1.ToString())+1;
				int endcol =0;
				int freecell =1;
				// find the drop position 
				Point pt = l_fgrid_main.PointToClient(new Point(e.X, e.Y));
				HitTestInfo hti = l_fgrid_main.HitTest(pt.X, pt.Y);
				int index = hti.Row;              // after fixed row
				int indexcolum = hti.Column;
				if(Convert.ToString(l_fgrid_main.Rows[l_fgrid_main.Selection.r1][l_fgrid_main.Selection.c1])=="")
				{
					return;
				}
				if(l_fgrid_main.Rows[index].AllowEditing == false)
				{
					return;
				}
				if(l_fgrid_main.Selection.r1!=l_fgrid_main.Selection.r2)
				{
					return;
				}
				else
				{
					if(index==l_fgrid_main.Selection.r1)
					{
						return;
					}

					// keo tha vao cell ko co du lieu
					if (Convert.ToString(l_fgrid_main.Rows[index][indexcolum])==""||Convert.ToInt32(l_fgrid_main.Rows[index][indexcolum])==0)
					{

						for(int t=indexcolum;t<l_fgrid_main.Cols.Count-1;t++)
						{
							if(Convert.ToInt32(l_fgrid_main.Rows[index][t])!=0)
							{
								endcol=t;
								break;
							}
						}
						if(endcol-indexcolum<0)
						{
							freecell=0;
						}
						else
						{
							freecell=endcol-indexcolum;
						}
						int _plancomplete = FindPlanComplete(index);
						if(indexcolum<= _plancomplete)
						{
							return;
						}
						int old_col=0;
						//neu khoang cach du voi so luong cell keo theo
						if(freecell>=numcol)
						{
							for (int s=indexcolum;s<indexcolum+numcol;s++)
							{
								//gan du lieu moi
								l_fgrid_main.Rows[index][s] = l_fgrid_main.Rows[l_fgrid_main.Selection.r1][l_fgrid_main.Selection.c1+old_col];
								//gan cell style moi
								l_fgrid_main.SetCellStyle(index,s,l_fgrid_main.GetCellStyle(l_fgrid_main.Selection.r1,l_fgrid_main.Selection.c1+old_col));
								//xoa cell style cu
								l_fgrid_main.SetCellStyle(l_fgrid_main.Selection.r1,l_fgrid_main.Selection.c1+old_col,ResetCellWhiteColor());
								//xoa du lieu cu
								if(index!=l_fgrid_main.Selection.r1||s!=l_fgrid_main.Selection.c1+old_col)
								{
									l_fgrid_main.Rows[l_fgrid_main.Selection.r1][l_fgrid_main.Selection.c1+old_col]=null;
								}
								old_col++;
							}
						}
						//neu khoang cach khong du voi so luong cell keo theo
						else
						{
							for(int i=l_fgrid_main.Cols.Count-1;indexcolum<i;i--)
							{
								l_fgrid_main.Rows[index][i]=l_fgrid_main.Rows[index][i-(numcol-freecell)];
								l_fgrid_main.SetCellStyle(index,i,l_fgrid_main.GetCellStyle(index,i-(numcol-freecell)));
							
							}
							for (int s=indexcolum;s<indexcolum+numcol;s++)
							{
							
								l_fgrid_main.Rows[index][s] = l_fgrid_main.Rows[l_fgrid_main.Selection.r1][l_fgrid_main.Selection.c1+old_col];
								l_fgrid_main.SetCellStyle(index,s,l_fgrid_main.GetCellStyle(l_fgrid_main.Selection.r1,l_fgrid_main.Selection.c1+old_col));
								//xoa cell style cu
								l_fgrid_main.SetCellStyle(l_fgrid_main.Selection.r1,l_fgrid_main.Selection.c1+old_col,ResetCellWhiteColor());
								//xoa du lieu cu
								if(index!=l_fgrid_main.Selection.r1||s!=l_fgrid_main.Selection.c1+old_col)
								{
									l_fgrid_main.Rows[l_fgrid_main.Selection.r1][l_fgrid_main.Selection.c1+old_col]=null;
								}
								old_col++;
							}
						}
						
						// keo du lieu lai sau khi cat
						for(int j=l_fgrid_main.Selection.c1;j<l_fgrid_main.Cols.Count-2;j++)
						{
							if(_plancomplete>=j)
							{
								break;
							}
							else
							{
								
								l_fgrid_main.Rows[l_fgrid_main.Selection.r1][j] = l_fgrid_main.Rows[l_fgrid_main.Selection.r1][j+numcol];
								l_fgrid_main.SetCellStyle(l_fgrid_main.Selection.r1,j,l_fgrid_main.GetCellStyle(l_fgrid_main.Selection.r1,j+numcol));
								l_fgrid_main.Rows[l_fgrid_main.Selection.r1][j+numcol]=null;
								l_fgrid_main.SetCellStyle(l_fgrid_main.Selection.r1,j+numcol,ResetCellWhiteColor());
							}
						}
						CalSum(fgrid_main,true);
						temp="";
					}
					//keo tha vao cell co du lieu
					else
					{
						int _plancomplete = FindPlanComplete(l_fgrid_main.Selection.r1);
						if(indexcolum<= _plancomplete)
						{
							return;
						}
						//keo du lieu ra cho du khoang cach 
						for(int i=l_fgrid_main.Cols.Count-1;indexcolum<i;i--)
						{
							l_fgrid_main.Rows[index][i]=l_fgrid_main.Rows[index][i-numcol];
							l_fgrid_main.SetCellStyle(index,i,l_fgrid_main.GetCellStyle(index,i-numcol));
							
						}
						//gan du lieu vao khoang trong da gian ra
						int old_col=0;
						for (int s=indexcolum;s<indexcolum+numcol;s++)
						{
							
							l_fgrid_main.Rows[index][s] = l_fgrid_main.Rows[l_fgrid_main.Selection.r1][l_fgrid_main.Selection.c1+old_col];
							l_fgrid_main.SetCellStyle(index,s,l_fgrid_main.GetCellStyle(l_fgrid_main.Selection.r1,l_fgrid_main.Selection.c1+old_col));
							l_fgrid_main.SetCellStyle(l_fgrid_main.Selection.r1,l_fgrid_main.Selection.c1+old_col,ResetCellWhiteColor());
							if(index!=l_fgrid_main.Selection.r1||indexcolum!=l_fgrid_main.Selection.c1+old_col)
							{
								l_fgrid_main.Rows[l_fgrid_main.Selection.r1][l_fgrid_main.Selection.c1+old_col]=null;
							}
							old_col++;
						}

						//xoa du lieu cu
						for(int j=l_fgrid_main.Selection.c1;j<l_fgrid_main.Cols.Count-2;j++)
						{
							if(_plancomplete>=j)
							{
								break;
							}
							else
							{
								l_fgrid_main.Rows[l_fgrid_main.Selection.r1][j] = l_fgrid_main.Rows[l_fgrid_main.Selection.r1][j+1];
								l_fgrid_main.SetCellStyle(l_fgrid_main.Selection.r1,j,l_fgrid_main.GetCellStyle(l_fgrid_main.Selection.r1,j+1));
								l_fgrid_main.SetCellStyle(l_fgrid_main.Selection.r1,j+1,ResetCellWhiteColor());
								l_fgrid_main.Rows[l_fgrid_main.Selection.r1][j+1]=null;
							}
						}
						CalSum(fgrid_main,true);
						temp="";
					}
				}
				
			}
			else
			{
				COM.FSP l_fgrid_main = (COM.FSP)sender;
				// find the drop position 
				Point pt = l_fgrid_main.PointToClient(new Point(e.X, e.Y));
				HitTestInfo hti = l_fgrid_main.HitTest(pt.X, pt.Y);
				int index = hti.Row;              // after fixed row
				if(l_fgrid_main.Rows.Count == l_fgrid_main.Rows.Fixed) return;
			
				int _startColIndex = FindPlanComplete(index);
				if (_startColIndex != -1)
				{
					_startColIndex = _startColIndex + 1;
					if (_startColIndex > fgrid_main.Cols.Count)
					{
						return;
					}
					if (l_fgrid_main.Rows[index].AllowEditing==false)
					{
						return;
					}
					l_fgrid_main.Rows[index][G1_COL_MODEL_CD] = fgrid_DemandPlan.Rows[fgrid_DemandPlan.Selection.r1][G2_COL_MODEL_CD];
					l_fgrid_main.Rows[index][G1_COL_ODS_ID] = fgrid_DemandPlan.Rows[fgrid_DemandPlan.Selection.r1][G2_COL_OBS_ID];
					l_fgrid_main.Rows[index][G1_COL_ITEM] = fgrid_DemandPlan.Rows[fgrid_DemandPlan.Selection.r1][G2_COL_DEV_NAME];
					l_fgrid_main.Rows[index][G1_COL_OS_CODE] = fgrid_DemandPlan.Rows[fgrid_DemandPlan.Selection.r1][G2_COL_OS_CODE];
					
					l_fgrid_main.Rows[index][G1_COL_MID_SOLE_1] = fgrid_DemandPlan.Rows[fgrid_DemandPlan.Selection.r1][G2_COL_MID_SOLE1];
					l_fgrid_main.Rows[index][G1_COL_MID_SOLE_2] = fgrid_DemandPlan.Rows[fgrid_DemandPlan.Selection.r1][G2_COL_MID_SOLE2];
					l_fgrid_main.Rows[index][G1_COL_MID_SOLE_3] = fgrid_DemandPlan.Rows[fgrid_DemandPlan.Selection.r1][G2_COL_MID_SOLE3];

					double CurQty = Convert.ToInt32( fgrid_DemandPlan.Rows[fgrid_DemandPlan.Selection.r1][G2_COL_PLAN_QTY]);
				
				
					for (int j = _startColIndex ; j < l_fgrid_main.Cols.Count - 1; j++)
					{
						//clear all value
						l_fgrid_main[index,j] = null ;
						l_fgrid_main.Rows[index][_startColIndex-1]=fgrid_DemandPlan.Rows[fgrid_DemandPlan.Selection.r1][G2_COL_OBS_ID];
						//set new value
						double CapaQty = 
							Convert.ToInt32(l_fgrid_main[3,j].ToString()) * Convert.ToDouble(l_fgrid_main.Cols[j].UserData.ToString());
						if (CurQty - CapaQty  > 0 )
						{
							l_fgrid_main[index,j] = Math.Round(CapaQty,0);
							l_fgrid_main.SetCellStyle(index,j,GetCellStyleFromOBSID(fgrid_DemandPlan.Rows[fgrid_DemandPlan.Selection.r1][G2_COL_OBS_ID].ToString()));
							CurQty = CurQty - CapaQty;
						}
						else
						{
							if (CurQty <= 0 )
							{
								continue;
							}
							else
							{
								l_fgrid_main[index,j] = Math.Round(CurQty,0);
								l_fgrid_main.SetCellStyle(index,j,GetCellStyleFromOBSID(fgrid_DemandPlan.Rows[fgrid_DemandPlan.Selection.r1][G2_COL_OBS_ID].ToString()));
							}
							CurQty = 0;
						}
					
					}
					CalSum(fgrid_main,true);
					CalRowSum(ref fgrid_main);
				}
				else
				{
					ClassLib.ComFunction.User_Message("The Mini Line is not Compete Plan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					//TODO: hien thi mess plan not complete
				}
			}
		}

		
		private void fgrid_main_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{
			// check whether we can drop here: 			
			// check that we have the type of data we want
			if (e.Data.GetDataPresent(typeof(string) ) )
			{
				e.Effect = DragDropEffects.Move; 
			} 
		}

		
		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{			
			try
			{ 
				this.Cursor = Cursors.WaitCursor;								
				for (int i = fgrid_main.Selection.r1; i<= fgrid_main.Selection.r2; i++)
				{

					//if (fgrid_main.Rows[i].Selected)
					//{
						if (fgrid_main.Rows[i].AllowEditing== false)
						{
							for (int j = i+1; j <= fgrid_main.Rows.Count; j++)
							{
								if(j == fgrid_main.Rows.Count)
								{
									break;
								}
								if(fgrid_main.Rows[j].Node.Level == 0 )
								{
									break;
								}
								//if (fgrid_main.Rows[j][G1_COL_LINE_CD].ToString().Equals(fgrid_main.Rows[j].UserData.ToString()))
								//{
									fgrid_main.Delete_Row(j);
								//}
								
								
							}
						}
						else
							fgrid_main.Delete_Row(i);
					//}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		


		
		private void cmenu_PlanComplete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Point pt = fgrid_main.PointToClient(e.ContextInfo.Location);
			HitTestInfo hti = fgrid_main.HitTest(pt.X, pt.Y);
			int indexRow = hti.Row;              // after fixed row
			int indexCol = hti.Column;   
			if (indexRow == -1)
			{
				return;
			}
			if (fgrid_main.Rows.Count <= _MainRowfixed)
			{
				return;
			}
			if (indexCol <= _MaxCol || indexCol > fgrid_main.Cols.Count)
			{
				return;
			}
			if (fgrid_main.Rows[indexRow].AllowEditing==false)
			{
				return;
			}
			//clear plan complete
			for (int i = _MaxCol + 1; i < fgrid_main.Cols.Count; i++)
			{
				CellStyle cs1=fgrid_main.GetCellStyle(indexRow,G1_COL_LINE_CD);
				fgrid_main.SetCellStyle(indexRow,i,cs1);
			}

			//set plan complete
			if (fgrid_main.GetCellStyle(indexRow,indexCol) == null)
			{
				CellStyle cs1=fgrid_main.Styles.Add("PlanComplete");
				cs1.BackColor =  ColCompletePlan;
				//UPDATE: 2011 - 01 - 10: Only Set cell style at complete cell
				//for (int i = _MaxCol + 1; i <= indexCol; i++)
				//{
					fgrid_main.SetCellStyle(indexRow,indexCol,cs1);
				//}				
			}
		}		
		
		
		private void cmenu_InsertNewMiniLine_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Point pt = fgrid_main.PointToClient(e.ContextInfo.Location);
			HitTestInfo hti = fgrid_main.HitTest(pt.X, pt.Y);
			int indexRow = hti.Row;              // after fixed row
			int indexCol = hti.Column;   
			if (indexRow == -1)
			{
				return;
			}
			if (fgrid_main.Rows.Count <= _MainRowfixed)
			{
				return;
			}			
			if (fgrid_main.Rows[indexRow].AllowEditing==false)
			{
				return;
			}
			//insert new row, copy some date from select row
			int _atIndex = indexRow + 1;
			fgrid_main.Rows.InsertNode(_atIndex,1);
			for (int i = 1; i <G1_COL_MODEL_CD; i ++)
			{
				fgrid_main[_atIndex,i] = fgrid_main[indexRow,i];
			}
			fgrid_main.Rows[_atIndex].UserData = fgrid_main.Rows[indexRow].UserData;
			fgrid_main[_atIndex,G1_COL_SEQ] = CalSeq(fgrid_main.Rows[_atIndex].UserData.ToString(),
				fgrid_main[_atIndex,G1_COL_LINE_CD].ToString());
			fgrid_main[_atIndex,0] = "I";
		}
	
		
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			tbtn_Search_Click(tbtn_Search,null);
		}

		
//		private void dpick_date_from_ValueChanged(object sender, System.EventArgs e)
//		{
//			tbtn_Search_Click(tbtn_Search,null);
//		}
//
//		
//		private void dpick_date_To_ValueChanged(object sender, System.EventArgs e)
//		{
//			tbtn_Search_Click(tbtn_Search,null);
//		}


		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			
			COM.FSP l_fgrid_main=(COM.FSP)sender;
			
			if (_CurrBuff != null)
			{

				if (int.Parse(Convert.ToString(l_fgrid_main[e.Row,e.Col]).Replace(",",""))!=0)
				{
					//so du sau khi edit
					double l_temp =  double.Parse(Convert.ToString(_CurrBuff).Replace(",",""))- double.Parse(l_fgrid_main[e.Row,e.Col].ToString().Replace(",",""));
					
					for (int i=e.Col+1;i<l_fgrid_main.Cols.Count-1;i++)
					{
						l_temp = l_temp + Convert.ToInt32(l_fgrid_main.Rows[e.Row][i]);
					}
					
					for (int i=e.Col+1;i<l_fgrid_main.Cols.Count-1;i++)
					{
						DateTime l_DateTime = ConvertToDateTime(l_fgrid_main.Cols[i].Caption.ToString());
						string l_value = ConvertOBS_ID(l_DateTime.Year,l_DateTime.Month);
						double CapaQty = Convert.ToInt32(l_fgrid_main[3,i].ToString()) * Convert.ToDouble(GET_CAPA_QTY(cmb_Factory.SelectedValue.ToString(),
							l_fgrid_main.Cols[i].Caption.ToString(),l_value.Substring(0,2), l_fgrid_main.Rows[e.Row].UserData.ToString()));
						if (l_temp - CapaQty  > 0 )
						{
							l_fgrid_main[e.Row,i] = Math.Round(CapaQty,0);
							l_temp = l_temp - CapaQty;
						}
						else
						{
							if (l_temp <= 0 )
							{
								continue;
							}
							else
							{
								l_fgrid_main[e.Row,i] = Math.Round(l_temp,0);								
							}
							l_temp = 0;
						}
					}
					for (int i=e.Col+1;i<l_fgrid_main.Cols.Count-1;i++)
					{
						if(Convert.ToString(l_fgrid_main.Rows[e.Row][i])!="" && l_fgrid_main.GetCellStyle(e.Row,i).Name.ToString() == "Normal")
						{
							l_fgrid_main.SetCellStyle(e.Row,i,_Style_edit);
						}
					}
					l_fgrid_main.Update_Row(e.Row);
					
					
				}
				else
				{
					if(l_fgrid_main[e.Row,e.Col]!=null)
						if(l_fgrid_main[e.Row,e.Col].ToString()!=string.Empty)
						{
							if (int.Parse(Convert.ToString(l_fgrid_main[e.Row,e.Col]).Replace(",",""))==0)
							{
								l_fgrid_main[e.Row,e.Col]=Convert.ToString(_CurrBuff);
							}
						}
				}

			}
			_CurrBuff = null;
			CalSum(fgrid_main,true);
			CalRowSum(ref fgrid_main);
		}

		
		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			_Style_edit=null;
			COM.FSP l_fgrid_main=(COM.FSP)sender;
			_CurrBuff = l_fgrid_main[e.Row,e.Col];
			_Style_edit = l_fgrid_main.GetCellStyle(e.Row,e.Col);
		
		}

		
		
		#endregion

		#region "Methods"

		private int isNoEmptyFiled(int arg_rowIndex)
		{
			if(fgrid_main.Rows.Count < _Rowfixed) return -1;
			for (int i = _MaxCol + 1; i < fgrid_main.Cols.Count; i++)
			{
				if (ClassLib.ComFunction.NullToBlank(fgrid_main[arg_rowIndex, i]).Equals(""))
				{
					return i;
				}
			}
			return -1;
		}

		
		private int FindPlanComplete(int arg_rowIndex)
		{
			int rs = -1;
			if(fgrid_main.Rows.Count < _Rowfixed) return -1;
			for (int i = _MaxCol + 1; i < fgrid_main.Cols.Count; i++)
			{
				if (fgrid_main.GetCellStyle(arg_rowIndex,i)!=null)
				{
					if (fgrid_main.GetCellStyle(arg_rowIndex,i).BackColor == ColCompletePlan)
					{
						rs = i;
					}					
				}
			}
			return rs;
		}

		
		private void Tbtn_SearchProcess()
		{
			try
			{
				//_bDiv = false;
				this.Cursor = Cursors.WaitCursor;

				DataTable vDt = SELECT_DEMAND_PLAN();

				Clear_FlexGrid1(fgrid_DemandPlan);

				if (vDt.Rows.Count > 0)
				{
					Display_FlexGrid(vDt,ref fgrid_DemandPlan);

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
				}

				//_bDiv = true;
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
		
		
		private void Tbtn_SearchProcess_2()
		{
			try
			{
				DataTable vDt = SELECT_PLAN_SIMULATION();
				Clear_FlexGrid(fgrid_main,true);
				if (vDt.Rows.Count > 0)
				{
					Display_FlexGrid_3(vDt,ref fgrid_main,false);
					SELECT_PLAN_SIMULATION_HEAD();
					
					SELECT_PLAN_SIMULATION_VALUES();
					FormatGird();
					FormatGird2();
					CalSum(fgrid_main,true);
					CalRowSum(ref fgrid_main);
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
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}
		
		
		private void Tbtn_NewProcess()
		{
			try
			{
				DataTable vDt = NEW_PLAN_SIMULATION();
				Clear_FlexGrid(fgrid_main, true);
				if (vDt.Rows.Count > 0)
				{
					if (vDt == null)
					{
						return;
					}
					Display_FlexGrid_3(vDt,ref fgrid_main,true);
					NEW_PLAN_SIMULATION_HEAD();
					this.Auto_Set_Plan_Complete ();
					
					for (int i = _MainRowfixed; i < fgrid_main.Rows.Count;i++)
					{		
						if (fgrid_main.Rows[i].AllowEditing==false)
						{
							continue;
						}
						fgrid_main[i, 0] = "I";
					}
					
					
					fgrid_main.AllowMerging = AllowMergingEnum.Free;
					fgrid_main.Cols[G1_COL_LINE_CD].AllowMerging = true;
					//Tu dong do du lieu ra cell sau khi nhan create new
					for (int i=1;i<vDt.Rows.Count;i++)
					{
						int _startColIndex = FindPlanComplete(i+_MainRowfixed);
						if (_startColIndex != -1)
						{	
							double _last_qty = 0;
							//do du lieu voi seq khac 1
							if(Convert.ToInt32(fgrid_main.Rows[i+_MainRowfixed][G1_COL_SEQ].ToString())==1)
							{
								//tim diem bat dau neu seq miniline la 1
								_startColIndex = _startColIndex + 1;
								double CurQty = Convert.ToInt32( vDt.Rows[i]["PLAN_QTY"]);
								for (int j = _startColIndex ; j < fgrid_main.Cols.Count ; j++)
								{
									double CapaQty = Convert.ToInt32(fgrid_main[3,j].ToString()) * Convert.ToDouble(fgrid_main.Cols[j].UserData.ToString());
									if (CurQty - CapaQty  > 0 )
									{
										fgrid_main[i+_MainRowfixed,j] = Math.Round(CapaQty,0);
										fgrid_main.SetCellStyle(i+_MainRowfixed,j,GetCellStyleFromOBSID(vDt.Rows[i]["OBS_ID"].ToString()));
										CurQty = CurQty - CapaQty;
									}
									else
									{
										if (CurQty <= 0 )
										{
											continue;
										}
										else
										{
											fgrid_main[i+_MainRowfixed,j] = Math.Round(CurQty,0);
											fgrid_main.SetCellStyle(i+_MainRowfixed,j,GetCellStyleFromOBSID(vDt.Rows[i]["OBS_ID"].ToString()));
										}
										CurQty = 0;
									}
			
								}	
							}

							//do du lieu voi seq khac 1
							else
							{
								//tim diem bat dau neu seq miniline khac 1
								for(int h =fgrid_main.Cols.Count-1 ;h>=_startColIndex+1;h-- )
								{
									if(Convert.ToString(fgrid_main.Rows[i+_MainRowfixed-1][h])!="")
									{
										_startColIndex = h;
										break;
									}
									if(h==_startColIndex)
									{
										_startColIndex =fgrid_main.Cols.Count;
										break;
									}
								}

								//bat dau do du lieu tai dong co seq khac 1
								double CurQty = Convert.ToInt32( vDt.Rows[i]["PLAN_QTY"]);
								for (int d =_MainRowfixed;d<fgrid_main.Rows.Count-1;d++)
								{
									if(Convert.ToString(fgrid_main.Rows[d].UserData)==Convert.ToString(fgrid_main.Rows[i+_MainRowfixed].UserData)&&
										Convert.ToString(fgrid_main.Rows[d][G1_COL_LINE_CD])==Convert.ToString(fgrid_main.Rows[i+_MainRowfixed][G1_COL_LINE_CD]))
									{
										_last_qty=_last_qty + Convert.ToInt32(fgrid_main.Rows[d][_startColIndex]);
									}
								}
								//MessageBox.Show(_last_qty.ToString());
								//_last_qty=Convert.ToInt32(fgrid_main.Rows[i+_MainRowfixed-1][_startColIndex]);
								for (int j = _startColIndex ; j < fgrid_main.Cols.Count ; j++)
								{
									
									double CapaQty = Convert.ToInt32(fgrid_main[3,j].ToString()) * Convert.ToDouble(fgrid_main.Cols[j].UserData.ToString());
									//neu so luong cuoi cung vua du voi capa
									if(CapaQty==_last_qty)
									{
										if (CurQty - CapaQty  > 0 )
										{
											fgrid_main[i+_MainRowfixed,j+1] = Math.Round(CapaQty,0);
											fgrid_main.SetCellStyle(i+_MainRowfixed,j+1,GetCellStyleFromOBSID(vDt.Rows[i]["OBS_ID"].ToString()));
											CurQty = CurQty - CapaQty;
										}
										else
										{
											if (CurQty <= 0 )
											{
												continue;
											}
											else
											{
												fgrid_main[i+_MainRowfixed,j+1] = Math.Round(CurQty,0);
												fgrid_main.SetCellStyle(i+_MainRowfixed,j+1,GetCellStyleFromOBSID(vDt.Rows[i]["OBS_ID"].ToString()));
											}
											CurQty = 0;
										}
									}


									//neu so luong cuoi cung chua bang capa
									else
									{
										if(j==_startColIndex)
										{
											if(CurQty-(CapaQty-_last_qty)>0)
											{
												fgrid_main[i+_MainRowfixed,_startColIndex] = Math.Round(CapaQty-_last_qty,0);
												fgrid_main.SetCellStyle(i+_MainRowfixed,_startColIndex,GetCellStyleFromOBSID(vDt.Rows[i]["OBS_ID"].ToString()));
												CurQty = CurQty -(CapaQty-_last_qty);
											}
											else
											{
												fgrid_main[i+_MainRowfixed,_startColIndex] = Math.Round(CurQty,0);
												fgrid_main.SetCellStyle(i+_MainRowfixed,_startColIndex,GetCellStyleFromOBSID(vDt.Rows[i]["OBS_ID"].ToString()));
												CurQty = 0;
											}
										}
										else
										{
											if (CurQty - CapaQty  > 0 )
											{
												fgrid_main[i+_MainRowfixed,j] = Math.Round(CapaQty,0);
												fgrid_main.SetCellStyle(i+_MainRowfixed,j,GetCellStyleFromOBSID(vDt.Rows[i]["OBS_ID"].ToString()));
												CurQty = CurQty - CapaQty;
											}
											else
											{
												if (CurQty <= 0 )
												{
													continue;
												}
												else
												{
													fgrid_main[i+_MainRowfixed,j] = Math.Round(CurQty,0);
													fgrid_main.SetCellStyle(i+_MainRowfixed,j,GetCellStyleFromOBSID(vDt.Rows[i]["OBS_ID"].ToString()));
												}
												CurQty = 0;
											}
										}
									}
								}
							}
						}
					}
					CalSum(fgrid_main,true);
					AddEmptyColumn(ref fgrid_main);
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
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}

			
		}
		
		
		private DataTable NEW_PLAN_SIMULATION()
		{
			//TODO: not yet
			DataSet vDt;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION.SP_SEL_DEMAND_PLAN_2";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = ARG_FACTORY;
			MyOraDB.Parameter_Name[1]  = ARG_LINE_CD;
			MyOraDB.Parameter_Name[2]  = "ARG_MONTH_FROM";
			MyOraDB.Parameter_Name[3]  = "ARG_MONTH_TO";
			MyOraDB.Parameter_Name[4]  = OUT_CURSOR;
			
			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]   = cbm_Line.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2]   = dpickDate_From.Value.ToString("yyyyMM") ;
			MyOraDB.Parameter_Values[3]   = dpickDate_To.Value.ToString("yyyyMM");
			MyOraDB.Parameter_Values[4]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null;
			return vDt.Tables[MyOraDB.Process_Name];
		}


//		private DataTable NEW_PLAN_SIMULATION()
//		{
//			//TODO: not yet
//			DataSet vDt;
//
//			MyOraDB.ReDim_Parameter(5);
//
//			//01.PROCEDURE명
//			MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION.SEL_NEW_PLAN_SIMULATION";
//
//			//02.ARGURMENT 명
//			MyOraDB.Parameter_Name[0]  = ARG_FACTORY;
//			MyOraDB.Parameter_Name[1]  = ARG_FROM_DATE;
//			MyOraDB.Parameter_Name[2]  = ARG_TO_DATE;
//			MyOraDB.Parameter_Name[3]  = ARG_LINE_CD;
//			MyOraDB.Parameter_Name[4]  = OUT_CURSOR;
//
//			//03.DATA TYPE 정의
//			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
//			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
//			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
//			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
//			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;
//
//			//04.DATA 정의
//			MyOraDB.Parameter_Values[0]   = cmb_Factory.SelectedValue.ToString();
//			MyOraDB.Parameter_Values[1]   = dpick_date_from.Value.ToString("yyyyMMdd");
//			MyOraDB.Parameter_Values[2]   = dpick_date_To.Value.ToString("yyyyMMdd");
//			MyOraDB.Parameter_Values[3]   = cbm_Line.SelectedValue.ToString();
//			MyOraDB.Parameter_Values[4]   = "";
//
//			MyOraDB.Add_Select_Parameter(true);
//			vDt = MyOraDB.Exe_Select_Procedure();
//			if(vDt == null) return null;
//			return vDt.Tables[MyOraDB.Process_Name];
//		}

		
		private void NEW_PLAN_SIMULATION_HEAD()
		{
			DataTable dt = SELECT_SPB_CAL_WORK();
			if (dt != null)
			{
				if (dt.Rows.Count > 0)
				{
					for (int i = 0; i < dt.Rows.Count; i ++ )
					{
						DateTime l_DateTime = ConvertToDateTime(dt.Rows[i][0].ToString());


						string l_value = ConvertOBS_ID(l_DateTime.Year,l_DateTime.Month);
						fgrid_main.Cols.Add();
						fgrid_main.Cols[fgrid_main.Cols.Count -1].AllowSorting = false;
						fgrid_main.Cols[fgrid_main.Cols.Count -1].Caption = dt.Rows[i][0].ToString();
						string l_Str = GET_CAPA_QTY(cmb_Factory.SelectedValue.ToString(),
							dt.Rows[i][0].ToString(), l_value.Substring(0,2), cbm_Line.SelectedValue.ToString()).ToString();
						DateTime _dtime = ConvertToDateTime(dt.Rows[i][0].ToString());
						while(l_Str == "0")
						{
							
							_dtime = _dtime.AddMonths(-1);
							l_Str = GET_CAPA_QTY(cmb_Factory.SelectedValue.ToString(),
								_dtime.ToString("yyyyMMdd"), l_value.Substring(0,2), cbm_Line.SelectedValue.ToString()).ToString();
						}
						fgrid_main.Cols[fgrid_main.Cols.Count -1].UserData = l_Str;
						fgrid_main.Cols[fgrid_main.Cols.Count -1].DataType = typeof(Int32);
						fgrid_main.Set_CellStyle_Number(fgrid_main.Cols.Count -1);
						
						fgrid_main[1,fgrid_main.Cols.Count -1] = l_value;
						CellStyle c1 = fgrid_main.Styles.Add("ColColor"+l_DateTime.Month.ToString());
						c1.ForeColor = Color.Black;
						c1.BackColor = GetColor(l_DateTime.Month);

						fgrid_main.SetCellStyle(1,fgrid_main.Cols.Count -1,c1);
						fgrid_main.Cols[fgrid_main.Cols.Count -1].Width= _DynamicColWidth;

						fgrid_main[1,fgrid_main.Cols.Count -1] = l_value;
						fgrid_main[2,fgrid_main.Cols.Count -1] = l_DateTime.ToString("MM/dd");
						fgrid_main[3,fgrid_main.Cols.Count -1] = dt.Rows[i][1].ToString();
						fgrid_main.Cols[fgrid_main.Cols.Count -1].AllowMerging=false;
						fgrid_main.Rows[3].AllowMerging=false;
					}
				}
			}
		}

		
		private string getValueData(DataTable p_DataTable, 
			string p_line_cd,
			string p_seq,
			string p_mini_line, 
			string p_plan_ymd,
			string p_obs_id_2,
			string p_model_cd)
		{
			DataRow[]  rs = p_DataTable.Select("LINE_CD = '" +p_line_cd +"' AND SEQ = "+p_seq+ " AND MINI_LINE = '" + p_mini_line + "' AND PLAN_YMD='"+p_plan_ymd +"'AND OBS_ID_2='"+p_obs_id_2+"'AND MODEL_CD='"+p_model_cd+"'");
			if (rs.Length == 0)
			{
				return "";
			}
			return rs[0]["PLAN_QTY"].ToString();
		}


		private string getValueData(DataTable p_DataTable, 
			string p_line_cd,
			string p_seq,
			string p_mini_line, 
			string p_plan_ymd,string p_obs_id_2 ,
			string p_model_cd,
			ref string p_Color)
		{
			DataRow[]  rs = p_DataTable.Select("LINE_CD = '" +p_line_cd +"' AND SEQ = "+p_seq+ " AND MINI_LINE = '" + p_mini_line + "' AND PLAN_YMD='"+p_plan_ymd +"'AND OBS_ID_2='"+p_obs_id_2+"'AND MODEL_CD='"+p_model_cd+"'");
			if (rs.Length == 0)
			{
				return "";
			}
			p_Color = rs[0]["CELL_COLOR"].ToString();
			return rs[0]["PLAN_QTY"].ToString();
		}

		
	
		private object GET_CAPA_QTY(string p_factory, string p_plan_month,string p_year,string p_line_cd)
		{
			//TODO: not yet
			DataSet vDt;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION.SP_GET_CAPA_QTY";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = ARG_FACTORY;
			MyOraDB.Parameter_Name[1]  = "ARG_PLAN_MONTH";
			MyOraDB.Parameter_Name[2]  = ARG_LINE_CD;
			MyOraDB.Parameter_Name[3]  = "ARG_YEAR";
			MyOraDB.Parameter_Name[4]  = OUT_CURSOR;

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = p_factory;
			MyOraDB.Parameter_Values[1]   = p_plan_month;
			MyOraDB.Parameter_Values[2]   = p_line_cd;
			MyOraDB.Parameter_Values[3]   = p_year;
			MyOraDB.Parameter_Values[4]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null;
			return vDt.Tables[MyOraDB.Process_Name].Rows[0][0];
		}

		
		private void SELECT_PLAN_SIMULATION_HEAD()
		{
			DataTable dt = SELECT_PLAN_SIMULA_SCHE_HEAD();
			/*for (int i =0 ; i < dt_header.Rows.Count; i++)
			{
				fgrid_main.Cols.Add();
				fgrid_main.Cols[fgrid_main.Cols.Count -1].DataType = typeof(Int32);
				fgrid_main.Cols[fgrid_main.Cols.Count -1].Caption = dt_header.Rows[i]["PLAN_YMD"].ToString();
				fgrid_main.Set_CellStyle_Number(fgrid_main.Cols.Count -1);
				fgrid_main[1,fgrid_main.Cols.Count -1] = ConvertToDateTime(dt_header.Rows[i]["PLAN_YMD"].ToString()).ToString("MM/dd");
				fgrid_main[2,fgrid_main.Cols.Count -1] = ConvertToDateTime(dt_header.Rows[i]["PLAN_YMD"].ToString()).ToString("MM/dd");
				fgrid_main.Cols[fgrid_main.Cols.Count -1].AllowMerging=true;
			}*/

			if (dt != null)
			{
				if (dt.Rows.Count > 0)
				{
					for (int i = 0; i < dt.Rows.Count; i ++ )
					{
						DateTime l_DateTime = ConvertToDateTime(dt.Rows[i][0].ToString());
						string l_value = ConvertOBS_ID(l_DateTime.Year,l_DateTime.Month);
						fgrid_main.Cols.Add();
						fgrid_main.Cols[fgrid_main.Cols.Count -1].AllowSorting = false;
						fgrid_main.Cols[fgrid_main.Cols.Count -1].Caption = dt.Rows[i][0].ToString();
						fgrid_main.Cols[fgrid_main.Cols.Count -1].UserData = GET_CAPA_QTY(cmb_Factory.SelectedValue.ToString(),
							dt.Rows[i][0].ToString(),l_value.Substring(0,2), cbm_Line.SelectedValue.ToString());
						fgrid_main.Cols[fgrid_main.Cols.Count -1].DataType = typeof(Int32);
						fgrid_main.Set_CellStyle_Number(fgrid_main.Cols.Count -1);
						
						fgrid_main[1,fgrid_main.Cols.Count -1] = l_value;
						CellStyle c1 = fgrid_main.Styles.Add("ColColor" +  l_DateTime.Month.ToString());
						c1.ForeColor = Color.Black;

						c1.BackColor = GetColor(l_DateTime.Month);
						fgrid_main.Cols[fgrid_main.Cols.Count -1].Width = _DynamicColWidth;
						fgrid_main.SetCellStyle(1,fgrid_main.Cols.Count -1,c1);
						fgrid_main[2,fgrid_main.Cols.Count -1] = l_DateTime.ToString("MM/dd");
						fgrid_main[3,fgrid_main.Cols.Count -1] = dt.Rows[i][1].ToString();
						fgrid_main.Cols[fgrid_main.Cols.Count -1].AllowMerging=false;
						fgrid_main.Rows[3].AllowMerging=false;
					}
					//Empty column 
					AddEmptyColumn(ref fgrid_main);
				}
			}
		}

		private void AddEmptyColumn(ref COM.FSP arg_fgrid)
		{
			//Empty column 
			arg_fgrid.Cols.Add();
			arg_fgrid[1,arg_fgrid.Cols.Count -1] = "Remark";
			arg_fgrid[2,arg_fgrid.Cols.Count -1] = arg_fgrid[1,arg_fgrid.Cols.Count -1];
			arg_fgrid[3,arg_fgrid.Cols.Count -1] = arg_fgrid[1,arg_fgrid.Cols.Count -1];
			arg_fgrid.Cols[arg_fgrid.Cols.Count -1].AllowMerging = true;
			arg_fgrid.Cols[arg_fgrid.Cols.Count -1].AllowSorting = false;
		}
//		private string ConvertOBS_ID(int arg_year, int arg_month)
//		{
//			string rs = string.Empty;
//			string objMonth = string.Empty;
//			string[] arr_ObjMonth=new string[]{
//												  "1012",//1
//												  "1101",//2
//												  "1202",//3
//												  "0103",//4
//												  "0204",//5
//												  "0305",//6
//												  "0406",//7
//												  "0507",//8
//												  "0608",//9
//												  "0709",//10
//												  "0810",//11
//												  "0911",//12
//			};
//			int tmp = int.Parse(arg_year.ToString().Substring(2,2));
//			if(arg_month > 10)
//			{
//				tmp = tmp + 1;
//			}
//			objMonth = arr_ObjMonth[arg_month - 1];
//			rs = tmp.ToString("0#")+objMonth;
//			return rs;
//		}

		private string ConvertOBS_ID(int arg_year, int arg_month)
		{
			string rs = string.Empty;
			int year = int.Parse(arg_year.ToString().Substring(2,2));
			if (arg_month==4)
			{
				rs=year.ToString("0#")+"0103";
			}
			if (arg_month==5)
			{
				rs=year.ToString("0#")+"0204";
			}
			if (arg_month==6)
			{
				rs=year.ToString("0#")+"0305";
			}
			if (arg_month==7)
			{
				rs=year.ToString("0#")+"0406";
			}
			if (arg_month==8)
			{
				rs=year.ToString("0#")+"0507";
			}
			if (arg_month==9)
			{
				rs=year.ToString("0#")+"0608";
			}
			if (arg_month==10)
			{
				rs=year.ToString("0#")+"0709";
			}
			if (arg_month==11)
			{
				rs=year.ToString("0#")+"0810";
			}
			if (arg_month==12)
			{
				year=year;
				rs=(year).ToString("0#")+"0911";
			}
			if (arg_month==1)
			{
				year=year-1;
				rs=year.ToString("0#")+"1012";
			}
			if (arg_month==2)
			{
				year=year-1;
				rs=year.ToString("0#")+"1101";
			}
			if (arg_month==3)
			{
				year=year-1;
				rs=year.ToString("0#")+"1202";
			}
			return rs;
		}

		
		private Color GetColor(int month)
		{
			switch (month)
			{
				case 1:
					return T1_Color;
				case 2:
					return T2_Color;
				case 3:
					return T3_Color;
				case 4:
					return T4_Color;
				case 5:
					return T5_Color;
				case 6:
					return T6_Color;
				case 7:
					return T7_Color;
				case 8:
					return T8_Color;
				case 9:
					return T9_Color;
				case 10:
					return T10_Color;
				case 11:
					return T11_Color;
				case 12:
					return T12_Color;
			}
			return Color.Empty;
		}

		
		private void SELECT_PLAN_SIMULATION_VALUES()
		{
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataTable dt1 = null;
			DataSet ds_ret;			
			try
			{
				string process_name = "PKG_SVM_PLAN_SIMULATION.SP_SEL_PLAN_SIMULA_SCHE_Values";

				MyOraDB.ReDim_Parameter(5);  
				MyOraDB.Process_Name = process_name;
   

				MyOraDB.Parameter_Name[0] = ARG_FACTORY; 
				MyOraDB.Parameter_Name[1] = ARG_FROM_DATE; 
				MyOraDB.Parameter_Name[2] = ARG_TO_DATE; 
				MyOraDB.Parameter_Name[3] = ARG_LINE_CD; 
				MyOraDB.Parameter_Name[4] = OUT_CURSOR; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1]   = dpick_date_from.Value.ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[2]   = dpick_date_To.Value.ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[3] = cbm_Line.SelectedValue.ToString();
				MyOraDB.Parameter_Values[4] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return ; 
				dt1 =  ds_ret.Tables[process_name]; 
			}
			catch
			{
				dt1 = null;
			}

			if (dt1 != null)
			{
				if (dt1.Rows.Count > 0)
				{
								
					for (int i =_MainRowfixed; i < fgrid_main.Rows.Count; i ++ )
					{
						if (fgrid_main.Rows[i].AllowEditing==false)
						{
							continue;
						}
						
						for (int j = _MaxCol + 1; j < fgrid_main.Cols.Count; j++)
						{
							string _strColor = "-1";

							string tmp = getValueData(dt1,
								fgrid_main.Rows[i].UserData.ToString(),
								fgrid_main[i,G1_COL_SEQ].ToString(),
								fgrid_main[i,G1_COL_LINE_CD].ToString(),
								fgrid_main.Cols[j].Caption,fgrid_main[i,G1_COL_ODS_ID].ToString(),
								fgrid_main[i,G1_COL_MODEL_CD].ToString(),
								ref _strColor);
							if (tmp != "0")
							{
								//MessageBox.Show(_strColor);
								fgrid_main.Rows[i][j] = tmp	;
								fgrid_main.SetCellStyle(i,j,GetCellStyleFromAGRB(_strColor));
							}
						
						}
					}
				}
			}
		}
		private CellStyle GetCellStyleFromAGRB(string arg_Agrb)
		{
			foreach(CellStyle cs in fgrid_main.Styles)
			{
				if(cs == null)
				{
					return ResetCellWhiteColor();
				}
				if(cs.BackColor.ToArgb().ToString() == arg_Agrb)
				{
					return cs;
				}
			}
			return ResetCellWhiteColor();
		}

		private CellStyle GetCellStyleFromOBSID(string obs_id)
		{
			//Color color_data ;
			string temp=obs_id.Substring(2,4);
			switch(temp)
			{
				case "0305":
					return  cs0305;				
				case "0406":						
					return cs0406;
				case "0507":
					return cs0507;						
				case "0608":						
					return cs0608;						
				case "0709":						
					return cs0709;						
				case "0810":						
					return cs0810;
				case "0911":						
					return cs0911;
				case "1012":						
					return cs1012;						
				case "1101":
					return cs1101;
				case "1202":
					return cs1202;
				case "0103" :						
					return cs0103;
				case "0204" :
					return cs0204;		
			}
			return ResetCellWhiteColor();
			

		}
		private void FormatGird2()
		{
			CellStyle csRowLevel1 = fgrid_main.Styles.Add("RowLevel1");
			csRowLevel1.BackColor = Color.FromArgb(241,236,248);
			
			CellStyle csRowLevel2 = fgrid_main.Styles.Add("RowLevel2");
			csRowLevel2.BackColor = Color.FromArgb(217,247,197);

			CellStyle csRowLevel3 = fgrid_main.Styles.Add("RowLevel3");
			csRowLevel3.BackColor = Color.FromArgb(255,255,255);


			

			if(fgrid_main.Rows.Count<= fgrid_main.Rows.Fixed) return;
			for(int i =  fgrid_main.Rows.Fixed; i <  fgrid_main.Rows.Count; i ++)
			{
				CellStyle csTmp = null;
				//CellStyle csTmp = csRowLevel2;
				int aa=FindPlanComplete(i);
				//row is level 1

				if(fgrid_main.Rows[i].AllowEditing == false)
				{
					fgrid_main.Rows[i].Style = csRowLevel1;
				}
				else//row is level 2
				{	
					string data="";
					for(int j = 1; j < fgrid_main.Cols.Count; j++)
					{
						try
						{
							int y= FindPlanComplete(i);
							data= Convert.ToString(fgrid_main[i,y]);

						}
						catch(Exception ex)
						{
							//MessageBox.Show("cho nay");
						}
						if(j >= 1 && j < _MaxCol) 
							fgrid_main.SetCellStyle(i,j,csRowLevel2);
						if(j > _MaxCol && j!=aa)
						{
							if(Convert.ToString( fgrid_main[i,j])=="" )
							{
								if ( fgrid_main.GetCellStyle(i,j)== null)
								{
									//if( fgrid_main.GetCellStyle(i,j).BackColor != Color.Gray)
									fgrid_main.SetCellStyle(i,j,csRowLevel3);
								}
							}
							/*if(Convert.ToString( fgrid_main[i,j])!="" )
							{
								if ( fgrid_main.GetCellStyle(i,j)== null)
								{
									if(data.Length>1)
									{
										if(data.Substring(2,4)=="0103")
										{
											fgrid_main.SetCellStyle(i,j,cs0103);
										}
										if(data.Substring(2,4)=="0204")
										{
											fgrid_main.SetCellStyle(i,j,cs0204);
										}
										if(data.Substring(2,4)=="0305")
										{
											fgrid_main.SetCellStyle(i,j,cs0305);
										}
										if(data.Substring(2,4)=="0406")
										{
											fgrid_main.SetCellStyle(i,j,cs0406);
										}
										if(data.Substring(2,4)=="0507")
										{
											fgrid_main.SetCellStyle(i,j,cs0507);
										}
										if(data.Substring(2,4)=="0608")
										{
											fgrid_main.SetCellStyle(i,j,cs0608);
										}
										if(data.Substring(2,4)=="0709")
										{
											fgrid_main.SetCellStyle(i,j,cs0709);
										}
										if(data.Substring(2,4)=="0810")
										{
											fgrid_main.SetCellStyle(i,j,cs0810);
										}
										if(data.Substring(2,4)=="0911")
										{
											fgrid_main.SetCellStyle(i,j,cs0911);
										}
										if(data.Substring(2,4)=="1012")
										{
											fgrid_main.SetCellStyle(i,j,cs1012);
										}
										if(data.Substring(2,4)=="1101")
										{
											fgrid_main.SetCellStyle(i,j,cs1101);
										}
										if(data.Substring(2,4)=="1202")
										{
											fgrid_main.SetCellStyle(i,j,cs1202);
										}
									}
								}
								
							}*/
						}

					}
				}
			}
		}

		private void fgrid_main_MouseLeave(object sender, System.EventArgs e)
		{
//			fgrid_main.Selections.Clone();
//			for(int i = _MainRowfixed ; i<fgrid_main.Rows.Count-1;i++)
//			{
//				for(int j =_MaxCol ;j<fgrid_main.Cols.Count-1;j++ )
//				{
//					if(Convert.ToString(fgrid_main.Rows[i][j])=="")
//					{
//						fgrid_main.CursorCell.Clear(C1.Win.C1FlexGrid.ClearFlags.All);
//						fgrid_main.SetCellCheck(i,j,C1.Win.C1FlexGrid.CheckEnum.Checked);
//						break;
//					}
//				}
//			}
		}

		private void txtFontSize_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (!Regex.IsMatch(e.KeyChar.ToString(), "\\d+") && e.KeyChar != (char)Keys.Back)
				e.Handled = true;
			if(e.KeyChar == (char)Keys.Enter)
			{
				TextBox l_TextBox =(TextBox )sender;
				string tmp = l_TextBox.Text;
				if(tmp==string.Empty)
					l_TextBox.Text = "6";
				float _Size = float.Parse(l_TextBox.Text);
				if(_Size<6)
				{
					_Size = 6F;
					l_TextBox.Text = _Size.ToString();
				}
				_FontSize = _Size;
				fgrid_DemandPlan.Font = new Font(_FontName,_FontSize);
				fgrid_main.Font = new Font(_FontName,_FontSize);
				fgrid_FA.Font = new Font(_FontName,_FontSize);
				fgrid_HO.Font = new Font(_FontName,_FontSize);
				fgrid_SP1.Font = new Font(_FontName,_FontSize);
				fgrid_SP2.Font = new Font(_FontName,_FontSize);
				fgrid_SU.Font = new Font(_FontName,_FontSize);
			}
		}



		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_Print_Click();
		}


		public void Tbtn_Print_Click()
		{	
			if(tab_Content.SelectedTab.Name.ToString()=="Pag_Summary")
			{
				string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_Plan_Simulation") ;
				string Para         = " ";
		

				int  iCnt  = 4;
				string [] aHead =  new string[iCnt];    
            
				aHead[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");	
				aHead[ 1]   = this.dpick_date_from.Value.ToString("yyyyMMdd");
				aHead[ 2]   = this.dpick_date_To.Value.ToString("yyyyMMdd"); 
				aHead[ 3]   = Convert.ToString(this.cbm_Line.SelectedValue) ; 
				Para = 	" /rp ";
				for (int i  = 1 ; i<= iCnt ; i++)
				{				
					Para = Para + "[" + aHead[i-1] + "] ";
				}
			
				FlexVJ_Common.Report.Form_RdViewer report = new FlexVJ_Common.Report.Form_RdViewer(mrd_Filename, Para);			
				report.Show();
			}
			else
			{
				int tab_index = 0;
				if (tab_Content.SelectedTab.Name.ToString()=="Pag_01")
				{
					tab_index = 1;
				}
				if (tab_Content.SelectedTab.Name.ToString()=="Pag_02")
				{
					tab_index = 2;
				}
				if (tab_Content.SelectedTab.Name.ToString()=="Pag_03")
				{
					tab_index = 3;
				}
				if (tab_Content.SelectedTab.Name.ToString()=="Pag_04")
				{
					tab_index = 4;
				}
				if (tab_Content.SelectedTab.Name.ToString()=="Pag_05")
				{
					tab_index = 5;
				}

				DataTable l_DataTable = SELECT_SVM_SEASON_MASTER(tab_Content.TabPages[tab_index].Text.Substring(0,2),
					tab_Content.TabPages[tab_index].Text.Substring(2,2));
				if(l_DataTable != null)
				{
					string _from_obs_id = " ";
					try
					{
						_from_obs_id = Convert.ToString(l_DataTable.Rows[0]["from_obsid"]);
					}
					catch
					{
						_from_obs_id = " ";
					}
					string _to_obs_id = " ";
					try
					{
						_to_obs_id = Convert.ToString(l_DataTable.Rows[0]["to_obsid"]);
					}
					catch
					{
						_to_obs_id = " ";
					}


					string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_Plan_Simulation_Season") ;
					string Para         = " ";
		

					int  iCnt  = 4;
					string [] aHead =  new string[iCnt];    
            
					aHead[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");	
					aHead[ 1]   = _from_obs_id;
					aHead[ 2]   = _to_obs_id; 
					aHead[ 3]   = Convert.ToString(this.cbm_Line.SelectedValue) ; 
					Para = 	" /rp ";
					for (int i  = 1 ; i<= iCnt ; i++)
					{				
						Para = Para + "[" + aHead[i-1] + "] ";
					}
			
					FlexVJ_Common.Report.Form_RdViewer report = new FlexVJ_Common.Report.Form_RdViewer(mrd_Filename, Para);			
					report.Show();

				}
				
			}
		}


		private void fgrid_main_BeforeMouseDown(object sender, C1.Win.C1FlexGrid.BeforeMouseDownEventArgs e)
		{
			temp="fgrid_main";
			//_Flag_ItemMove = false;
			// start dragging when the user clicks the row headers 
			HitTestInfo hti = fgrid_main.HitTest(e.X, e.Y);
 
			// select the row
			int index = hti.Row;
			int indexcolumn = hti.Column;
			if(index < fgrid_main.Rows.Fixed) return;
			if(fgrid_main.Rows[index].AllowEditing == false)
				return;
			if(Convert.ToString(fgrid_main.Rows[index][indexcolumn])=="")
				return;
			if(indexcolumn == FindPlanComplete(index))
			{
					return;
			}
			if(indexcolumn<_MaxCol)
			{
				return; 
			}
			//fgrid_main.Select(fgrid_main.Selection.r1, fgrid_main.Selection.c1 , false);	
			//MessageBox.Show(fgrid_main.Rows[fgrid_main.Selection.r1][0].ToString());
			//MessageBox.Show(fgrid_main.Rows[fgrid_main.Selection.r1][fgrid_main.Selection.c1].ToString());
  
			// do drag drop
			DragDropEffects dd = fgrid_DemandPlan.DoDragDrop(fgrid_DemandPlan.Clip, DragDropEffects.Move);
			
		}

		
	
		private void FormatGird()
		{
			DataSet vDt;
			MyOraDB.ReDim_Parameter(5);
			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION.SP_GET_MPS_YN";
			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = ARG_FACTORY;
			MyOraDB.Parameter_Name[1]  = ARG_FROM_DATE;
			MyOraDB.Parameter_Name[2]  = ARG_TO_DATE;
			MyOraDB.Parameter_Name[3]  = ARG_LINE_CD;
			MyOraDB.Parameter_Name[4]  = OUT_CURSOR;

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]   = dpick_date_from.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[2]   = dpick_date_To.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[3]   = cbm_Line.SelectedValue.ToString();
			MyOraDB.Parameter_Values[4]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return ;
			DataTable dt = vDt.Tables[MyOraDB.Process_Name];
			if (dt.Rows.Count < 1)
			{
				return;
			}
			
			for (int i = _MainRowfixed; i < fgrid_main.Rows.Count; i ++)
			{
				if (fgrid_main.Rows[i].AllowEditing==false)
				{
					continue;
				}
				for (int j = _MaxCol + 1; j < fgrid_main.Cols.Count; j ++)
				{
					for (int k =0 ; k< dt.Rows.Count; k++)
					{
						
                        if (fgrid_main[i,G1_COL_LINE_CD].ToString().Equals(dt.Rows[k][1].ToString())//mini lineTODO
							&& 
							fgrid_main.Cols[j].Caption.Equals(dt.Rows[k][0].ToString())//plan ymd
							&& dt.Rows[k][2].ToString().Equals("Y")//mps yn
							&& fgrid_main.Rows[i].UserData.ToString().Equals(dt.Rows[k][3].ToString())//LINE_CD
							&& fgrid_main[i,G1_COL_SEQ].ToString().Equals(dt.Rows[k][4].ToString())//SEQ
							)
                        {
							if (fgrid_main.GetCellStyle(i,j) == null)
							{
								CellStyle cs1=fgrid_main.Styles.Add("PlanComplete");
								cs1.BackColor =  ColCompletePlan;
								cs1.ForeColor = ColCompletePlan;
								fgrid_main.SetCellStyle(i,j,cs1);
							}
                        }
					}
				}
			}
			//format color for grid
//			for(int iRow = fgrid_main.Rows.Fixed; iRow < fgrid_main.Rows.Count; iRow ++)
//			{
//				for(int iCol=_MaxCol + 1; iCol<fgrid_main.Rows.Count; iCol++)
//				{
//					//if(fgrid_main[iRow,iCol].ToString()="")
//						//continuos
//					---
//
//				}
//			}
			
		}


		private void CalSum(COM.FSP arg_fgrid, bool arg_Is_Summary)
		{
			if(arg_Is_Summary == true)//xu ly cho grid nam tren tab summary
			{
				int rs = 0;
				for (int i =arg_fgrid.Rows.Fixed ; i < arg_fgrid.Rows.Count; i++)
				{
					if (arg_fgrid.Rows[i].Node.Level == 0)
					{
						continue;
					}
					int xx= FindPlanComplete(i);
					for (int j =  _MaxCol; j < arg_fgrid.Cols.Count; j++)
					{
						if(xx==j)
							continue;
						if(arg_fgrid[i,j] == null) continue;
						if(arg_fgrid[i,j].ToString() == "")
							continue;
						else
						{
							string _str = arg_fgrid[i,j].ToString();

							if(_str.IndexOf(",",0,_str.Length)!=-1)
							{
								rs += Convert.ToInt32(arg_fgrid[i,j].ToString().Replace(",",""));
							}
							else
							{
								rs += Convert.ToInt32(arg_fgrid[i,j]);
							}

						}
					}
					arg_fgrid[i,G1_COL_PLAN_QTY] = rs;
					rs = 0;
				}
			}
			else//xu ly cho cac tab con lai
			{
				int rs = 0;
				for (int i =arg_fgrid.Rows.Fixed ; i < arg_fgrid.Rows.Count; i++)
				{
					if (arg_fgrid.Rows[i].AllowEditing==false)
					{
						continue;
					}
					for (int j =  _MaxColGS + 1; j < arg_fgrid.Cols.Count-2; j++)
					{
						if(arg_fgrid[i,j] == null) continue;
						if(arg_fgrid[i,j].ToString() == "")
							continue;
						else
							rs += int.Parse(arg_fgrid[i,j].ToString().Replace(",",""));
					}
					arg_fgrid[i,GS_COL_TOTAL] = rs;
					rs = 0;
				}
			}
		}

		
		private void CalRowSum(ref COM.FSP arg_fgrid)
		{
			if(arg_fgrid.Rows.Count <= _MainRowfixed)
			{
				return;
			}
			for(int i = _MainRowfixed; i < arg_fgrid.Rows.Count; i ++)
			{
				if(arg_fgrid.Rows[i].Node.Level == 0)
				{
					CalRowSum(ref arg_fgrid, i);
				}
			}
		}

		private void CalRowSum(ref COM.FSP arg_fgrid, int arg_Row_Index)
		{
			int _Sumvalue = 0;
			for(int j = _MaxCol; j < arg_fgrid.Cols.Count - 1; j ++)
			{
				for(int i = arg_Row_Index + 1; i < arg_fgrid.Rows.Count; i ++)
				{
					CellStyle xx= arg_fgrid.GetCellStyle(i,j);
					if(xx!=null)
					{
						if(xx.BackColor==ColCompletePlan)
						{
							continue;
						}
					}
					if(arg_fgrid.Rows[i].Node.Level == 0 || i == arg_fgrid.Rows.Count)
					{
						break;
					}
					else
					{
						if(arg_fgrid[i,j]!=null)
							if(arg_fgrid[i,j].ToString()!=string.Empty)
								_Sumvalue += Convert.ToInt32(arg_fgrid[i,j]);
					}
					
				}
				if(_Sumvalue > 0)
				{
					arg_fgrid[arg_Row_Index,j] = _Sumvalue;
					CellStyle _cs = arg_fgrid.Styles.Add("ROWSUMVALUE");//(arg_Row_Index,j);
					_cs.ForeColor = Color.Black;
					_cs.Font = new Font(_FontName,_FontSize,FontStyle.Bold ,GraphicsUnit.Point) ;
					arg_fgrid.SetCellStyle(arg_Row_Index,j,_cs);
				}
				_Sumvalue = 0;
			}
		}

		
		private void AddColumnOver(ref COM.FSP arg_fgrid)
		{
			int _index = arg_fgrid.Cols.Count - 1;
			arg_fgrid.Cols.Insert(_index);
			arg_fgrid.Cols[_index].AllowSorting = false;
			arg_fgrid.Cols[_index].Caption = "TotalOver";
			arg_fgrid.Cols[_index].DataType = typeof(Int32);						
			arg_fgrid[1,_index] = "Total";
			arg_fgrid[2,_index] = "Total";
			arg_fgrid[3,_index] = "Total";
			arg_fgrid.Cols[_index].AllowMerging = true;

			//arg_fgrid.Set_CellStyle_Number(_index);
			//arg_fgrid.Cols[_index].StyleNew.ForeColor = Color.Red;
			if(_CellTotal == null)
			{
				_CellTotal = fgrid_main.Styles.Add("TOTAL");
				_CellTotal.ForeColor = Color.Red;
				_CellTotal.DataType = typeof(double);
				_CellTotal.Format = "#,##0.##########";
				_CellTotal.Font=new Font(_FontName,_FontSize,FontStyle.Bold ,GraphicsUnit.Point);				
			}
			int min = GetMinCol(arg_fgrid);
			//MessageBox.Show(min.ToString());
			for(int i = arg_fgrid.Rows.Fixed; i < arg_fgrid.Rows.Count; i ++)
			{
				int total =0;
				if(arg_fgrid.Rows[i].Node.Level==0)
				{
					continue;
				}
				for (int j=min;j<arg_fgrid.Cols.Count-2;j++)
				{
					if(arg_fgrid[i,j] == null) continue;
					if(arg_fgrid[i,j].ToString() == "")
						continue;
					else
					total += int.Parse(arg_fgrid[i,j].ToString().Replace(",",""));
				}
				if(total>0)
				{
					arg_fgrid[i,arg_fgrid.Cols.Count-2]=total;
				}
				total=0;
				arg_fgrid.SetCellStyle(i,arg_fgrid.Cols.Count-2,_CellTotal);
			}
			

		}
			
		private void Display_FlexGrid(DataTable arg_dt,ref COM.FSP  p_fgControl)
		{
			int iCount = arg_dt.Rows.Count;
			_Rowfixed = p_fgControl.Rows.Fixed;
			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{				
				C1.Win.C1FlexGrid.Node newRow = p_fgControl.Rows.InsertNode(_Rowfixed + iRow, 1);

				p_fgControl[newRow.Row.Index, 0] = "";

				for (int iCol = 1 ; iCol < arg_dt.Columns.Count ; iCol++)
				{
					p_fgControl[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
				}
			}
		}
		// 메뉴 최상단 표시
		private string _RootDesc = "Root";
		private int _RootLevel = 0; 
		private string _TypeRoot = "R";
		private string _RootMenuKey = "-1";

		private int _MenuLevel = 1;

		private string _SeparatorDesc = "-";


		private void Display_FlexGrid_3(DataTable arg_dt,ref COM.FSP  p_fgControl, bool arg_is_new)
		{
			int level = 0;

			p_fgControl.Tree.Column = G1_COL_LINE_CD;
			p_fgControl.Tree.Style = TreeStyleFlags.Complete;
			p_fgControl.Tree.Show(-1);
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{

				level = Convert.ToInt32( arg_dt.Rows[i]["LV"].ToString() );

				p_fgControl.Rows.InsertNode(i + _MainRowfixed, level);

					if (level == 0)
					{
						p_fgControl[i + _MainRowfixed, G1_COL_LINE_CD ] = arg_dt.Rows[i]["LINE_CD"].ToString();
						p_fgControl.Rows[i + _MainRowfixed].AllowEditing = false;						
					}
					else
					{
						p_fgControl.Rows[i + _MainRowfixed].AllowEditing = true;
						p_fgControl[i + _MainRowfixed, G1_COL_FACTORY ] = arg_dt.Rows[i]["FACTORY"].ToString();
						//p_fgControl[i + _MainRowfixed, G1_COL_SEQ ] = arg_dt.Rows[i]["SEQ"].ToString();
						
						p_fgControl.Rows[i + _MainRowfixed].UserData = arg_dt.Rows[i]["LINE_CD"].ToString();
						p_fgControl[i + _MainRowfixed, G1_COL_LINE_CD ] = arg_dt.Rows[i]["MINI_LINE"].ToString();
						p_fgControl[i + _MainRowfixed, G1_COL_SEQ ] = CalSeq1(fgrid_main.Rows[i + _MainRowfixed].UserData.ToString(),
							fgrid_main[i + _MainRowfixed,G1_COL_LINE_CD].ToString());
						
						if (!arg_is_new)
						{						
							p_fgControl[i + _MainRowfixed, G1_COL_PLAN_YMD ] = arg_dt.Rows[i]["PLAN_YMD"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_MID_SOLE_1 ] = arg_dt.Rows[i]["MID_SOLE_1"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_MID_SOLE_2 ] = arg_dt.Rows[i]["MID_SOLE_2"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_MID_SOLE_3 ] = arg_dt.Rows[i]["MID_SOLE_3"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_MODEL_CD ] = arg_dt.Rows[i]["MODEL_CD"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_OS_CODE ] = arg_dt.Rows[i]["OS_CODE"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_ITEM ] = arg_dt.Rows[i]["ITEM"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_ODS_ID ] = arg_dt.Rows[i]["OBS_ID_2"].ToString();
						}
						if(arg_is_new)
						{
							p_fgControl[i + _MainRowfixed, G1_COL_MID_SOLE_1 ] = arg_dt.Rows[i]["MID_SOLE1"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_MID_SOLE_2 ] = arg_dt.Rows[i]["MID_SOLE2"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_MID_SOLE_3 ] = arg_dt.Rows[i]["MID_SOLE3"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_MODEL_CD ] = arg_dt.Rows[i]["MODEL_CD"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_ITEM ] = arg_dt.Rows[i]["DEV_NAME"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_OS_CODE ] = arg_dt.Rows[i]["OS_CODE"].ToString();
							p_fgControl[i + _MainRowfixed, G1_COL_ODS_ID ] = arg_dt.Rows[i]["OBS_ID"].ToString();
						}
						
					}

			} 
		}

		
		private void Display_FlexGrid_Season_Tab(DataTable arg_dt,ref COM.FSP  p_fgControl)
		{
			int level = 0;
			p_fgControl.Tree.Column = GS_COL_LINE_CD;
			p_fgControl.Tree.Style = TreeStyleFlags.Complete;
			p_fgControl.Tree.Show(-1);
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{

				level = Convert.ToInt32( arg_dt.Rows[i]["LV"].ToString() );

				p_fgControl.Rows.InsertNode(i + p_fgControl.Rows.Fixed, level);

				if (level == 0)
				{
					p_fgControl[i + p_fgControl.Rows.Fixed, GS_COL_LINE_CD ] = arg_dt.Rows[i]["LINE_CD"].ToString();
					p_fgControl.Rows[i + p_fgControl.Rows.Fixed].AllowEditing = false;						
				}
				else
				{
					p_fgControl.Rows[i + p_fgControl.Rows.Fixed].AllowEditing = true;
					p_fgControl[i + p_fgControl.Rows.Fixed, GS_COL_FACTORY ] = arg_dt.Rows[i]["FACTORY"].ToString();
					p_fgControl[i + p_fgControl.Rows.Fixed, GS_COL_SEQ ] = arg_dt.Rows[i]["SEQ"].ToString();
					p_fgControl.Rows[i + p_fgControl.Rows.Fixed].UserData = arg_dt.Rows[i]["LINE_CD"].ToString();
					p_fgControl[i + p_fgControl.Rows.Fixed, GS_COL_LINE_CD ] = arg_dt.Rows[i]["MINI_LINE"].ToString();
					p_fgControl[i + p_fgControl.Rows.Fixed,GS_COL_OBS_ID_2]=arg_dt.Rows[i]["obs_id_2"].ToString();
					p_fgControl[i + p_fgControl.Rows.Fixed,GS_COL_OS_CODE]=arg_dt.Rows[i]["OS_CODE"].ToString();
					p_fgControl[i+p_fgControl.Rows.Fixed,GS_COL_MODEL_CD]=arg_dt.Rows[i]["MODEL_CD"].ToString();
					//if (!arg_is_new)
					//{						
						//p_fgControl[i + _MainRowfixed, G1_COL_PLAN_YMD ] = arg_dt.Rows[i]["PLAN_YMD"].ToString();
						//p_fgControl[i + _MainRowfixed, G1_COL_MID_SOLE_1 ] = arg_dt.Rows[i]["MID_SOLE_1"].ToString();
						//p_fgControl[i + _MainRowfixed, G1_COL_MID_SOLE_2 ] = arg_dt.Rows[i]["MID_SOLE_2"].ToString();
						//p_fgControl[i + _MainRowfixed, G1_COL_MID_SOLE_3 ] = arg_dt.Rows[i]["MID_SOLE_3"].ToString();
						//p_fgControl[i + _MainRowfixed, G1_COL_MODEL_CD ] = arg_dt.Rows[i]["MODEL_CD"].ToString();
						//p_fgControl[i + _MainRowfixed, G1_COL_OS_CODE ] = arg_dt.Rows[i]["OS_CODE"].ToString();
						p_fgControl[i + p_fgControl.Rows.Fixed, GS_COL_MODEL ] = arg_dt.Rows[i]["ITEM"].ToString();
						//p_fgControl[i + _MainRowfixed, G1_COL_ODS_ID ] = arg_dt.Rows[i]["OBS_ID"].ToString();
					//}
						
				}

			} 
		}

		
		private void Clear_FlexGrid(COM.FSP p_fgControl, bool arg_Is_Summary)
		{
			int l_MaxCol = _MaxColGS;
			if(arg_Is_Summary == true)
			{
				l_MaxCol = _MaxCol;
			}
			if (p_fgControl.Rows.Fixed != p_fgControl.Rows.Count)
			{				
				p_fgControl.Clear(ClearFlags.UserData, p_fgControl.Rows.Fixed, 1, p_fgControl.Rows.Count - 1, p_fgControl.Cols.Count - 1);
				p_fgControl.Rows.Count = p_fgControl.Rows.Fixed;					
			}
			for (int i = p_fgControl.Cols.Count -1; i >= l_MaxCol  ; i --)
			{
				p_fgControl.Cols.Remove(i);
			}			
		}

		
		private void Clear_FlexGrid1(COM.FSP p_fgControl)
		{
			if (p_fgControl.Rows.Fixed != p_fgControl.Rows.Count)
			{				
				p_fgControl.Clear(ClearFlags.UserData, p_fgControl.Rows.Fixed, 1, p_fgControl.Rows.Count - 1, p_fgControl.Cols.Count - 1);
				p_fgControl.Rows.Count = p_fgControl.Rows.Fixed;					
			}	
		}
		
		
		private DataTable SELECT_DEMAND_PLAN()
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION.SP_SEL_DEMAND_PLAN";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = ARG_FACTORY;
			MyOraDB.Parameter_Name[1]  = ARG_OS_CODE;
			MyOraDB.Parameter_Name[2]  = ARG_DEV_NAME;
			MyOraDB.Parameter_Name[3]  = ARG_LINE_CD;
			MyOraDB.Parameter_Name[4]  = "ARG_MONTH_FROM";
			MyOraDB.Parameter_Name[5]  = "ARG_MONTH_TO";
			MyOraDB.Parameter_Name[6]  = OUT_CURSOR;

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			//MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = COM.ComVar.This_Factory;
			//MyOraDB.Parameter_Values[1]   = dpickDate.Value.ToString("yyyyMM");
			MyOraDB.Parameter_Values[1]   = txt_Os.Text;
			MyOraDB.Parameter_Values[2]   = txt_DevName.Text;
			MyOraDB.Parameter_Values[3]   = cbm_Line.SelectedValue.ToString();
			MyOraDB.Parameter_Values[4]   = dpickDate_From.Value.ToString("yyyyMM");
			MyOraDB.Parameter_Values[5]   = dpickDate_To.Value.ToString("yyyyMM");
			MyOraDB.Parameter_Values[6]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null;
			return vDt.Tables[MyOraDB.Process_Name];
		}

		
		private DataTable SELECT_LINE_INFO()
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;			
			try
			{
				string process_name = "PKG_SBM_LLT_PLAN_TRACKING.SELECT_LINE_INFO";

				MyOraDB.ReDim_Parameter(2);  
				MyOraDB.Process_Name = process_name;
   

				MyOraDB.Parameter_Name[0] = ARG_FACTORY; 
				MyOraDB.Parameter_Name[1] = OUT_CURSOR; 

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


		private DataTable SELECT_PLAN_SIMULA_SCHE_HEAD()
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;			
			try
			{
				string process_name = "PKG_SVM_PLAN_SIMULATION.SP_SEL_PLAN_SIMULA_SCHE_Head";

				MyOraDB.ReDim_Parameter(5);  
				MyOraDB.Process_Name = process_name;

				MyOraDB.Parameter_Name[0] = ARG_FACTORY; 
				MyOraDB.Parameter_Name[1] = ARG_FROM_DATE; 
				MyOraDB.Parameter_Name[2] = ARG_TO_DATE; 
				MyOraDB.Parameter_Name[3] = ARG_LINE_CD; 
				MyOraDB.Parameter_Name[4] = OUT_CURSOR; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1]   = dpick_date_from.Value.ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[2]   = dpick_date_To.Value.ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[3] = cbm_Line.SelectedValue.ToString();
				MyOraDB.Parameter_Values[4] = ""; 

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


		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				if (SAVE_PLAN_SIMULATION(true))
				{
					fgrid_main.Refresh_Division();
					this.Tbtn_SearchProcess_2();
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message,"Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
		
		
		private bool Validate_Check()
		{
			if (fgrid_main.Rows.Count <= _MainRowfixed)
			{
				return false;
			}
//			if (cbm_Line.SelectedValue.Equals(" "))
//			{
//				return false;
//			}
			for(int i = _MainRowfixed; i < fgrid_main.Rows.Count; i++)
			{
				if(fgrid_main.Rows[i].AllowEditing == false) continue;
				object objMid1 = fgrid_main.Rows[i][G1_COL_MID_SOLE_1];
				if(objMid1 != null)
				{
					for(int j = _MainRowfixed ; j< fgrid_main.Rows.Count; j++)
					{
						object objTmp = fgrid_main[j,G1_COL_MID_SOLE_2];
						if(objTmp != null)
						{
							if(objMid1.ToString() == objTmp.ToString()) 
							{
								if(objMid1.ToString() != "" || objTmp.ToString() != "")
									return false;
							}
						}
					}
					for(int k = _MainRowfixed ; k< fgrid_main.Rows.Count; k++)
					{
						object objTmp = fgrid_main[k,G1_COL_MID_SOLE_3];
						if(objTmp != null)
						{
							if(objMid1.ToString() == objTmp.ToString())
							{
								if(objMid1.ToString() != "" || objTmp.ToString() != "")
									return false;
							}
						}
					}
				}
				object objMid2 = fgrid_main.Rows[i][G1_COL_MID_SOLE_2];
				if(objMid2 != null)
				{
					for(int h = _MainRowfixed; h< fgrid_main.Rows.Count; h++)
					{
						object objTmp = fgrid_main[h,G1_COL_MID_SOLE_3];
						if(objTmp != null)
						{
							if(objMid2.ToString() == objTmp.ToString())
							{
								if(objMid2.ToString() != "" || objTmp.ToString() != "")
									return false;
							}
						}
					}
				}
			}
			return true;
		}

				
		private DataTable SELECT_PLAN_SIMULATION()
		{
			//TODO: not yet
			DataSet vDt;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION.SP_SEL_PLAN_SIMULATION";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = ARG_FACTORY;
			MyOraDB.Parameter_Name[1]  = ARG_FROM_DATE;
			MyOraDB.Parameter_Name[2]  = ARG_TO_DATE;
			MyOraDB.Parameter_Name[3]  = ARG_LINE_CD;
			MyOraDB.Parameter_Name[4]  = OUT_CURSOR;

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]   = dpick_date_from.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[2]   = dpick_date_To.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[3]   = cbm_Line.SelectedValue.ToString();
			MyOraDB.Parameter_Values[4]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null;
			return vDt.Tables[MyOraDB.Process_Name];
		}

		
		private DataTable SELECT_PLAN_SIMULATION_BY_SEASON(string arg_Season, int arg_Year, string arg_Form_OBS_ID, string arg_To_OBS_ID)
		{
			//TODO: not yet
			DataSet vDt;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION.SP_SEL_PLAN_SIMULATION_BY_SEA";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = ARG_FACTORY;
			MyOraDB.Parameter_Name[1]  = ARG_FROM_DATE;
			MyOraDB.Parameter_Name[2]  = ARG_TO_DATE;
			MyOraDB.Parameter_Name[3]  = ARG_LINE_CD;
			MyOraDB.Parameter_Name[4]  = ARG_FROM_OBS_ID;
			MyOraDB.Parameter_Name[5]  = ARG_TO_OBS_ID;
			MyOraDB.Parameter_Name[6]  = OUT_CURSOR;

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]   = dpick_date_from.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[2]   = dpick_date_To.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[3]   = cbm_Line.SelectedValue.ToString();
			MyOraDB.Parameter_Values[4]   = arg_Form_OBS_ID;
			MyOraDB.Parameter_Values[5]   = arg_To_OBS_ID;
			MyOraDB.Parameter_Values[6]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null;
			return vDt.Tables[MyOraDB.Process_Name];
		}


		private DataTable SELECT_GROWTH_PLAN()
		{
			//TODO: not yet
			DataSet vDt;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION.SP_SEL_SVM_GROWTH_PLAN";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = ARG_FACTORY;
			MyOraDB.Parameter_Name[1]  = ARG_LINE_CD;
			MyOraDB.Parameter_Name[2]  = ARG_FROM_DATE;
			MyOraDB.Parameter_Name[3]  = ARG_TO_DATE;
			MyOraDB.Parameter_Name[4]  = OUT_CURSOR;

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   =cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]   = cbm_Line.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2]   = dpick_date_from.Value.ToString("yyyyMM");
			MyOraDB.Parameter_Values[3]   = dpick_date_To.Value.ToString("yyyyMM");
			MyOraDB.Parameter_Values[4]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null;
			return vDt.Tables[MyOraDB.Process_Name];
		}
		
		
		private bool SAVE_PLAN_SIMULATION(bool doExecute)
		{
			try
			{
				int para_ct = 0; 
				int iCount  = 17;
				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION.SP_INS_SVM_PLAN_SIMULATION";

				//02.ARGURMENT OF PROC
				MyOraDB.Parameter_Name[0] = ARG_FACTORY;
				MyOraDB.Parameter_Name[1] = ARG_LINE_CD;
				MyOraDB.Parameter_Name[2] = ARG_MINI_LINE;
				MyOraDB.Parameter_Name[3] = ARG_PLAN_YMD;
				MyOraDB.Parameter_Name[4] = ARG_OS_CODE;
				MyOraDB.Parameter_Name[5] = ARG_ITEM;
				MyOraDB.Parameter_Name[6] = ARG_PLAN_QTY;
				MyOraDB.Parameter_Name[7] = ARG_UPD_USER;
				MyOraDB.Parameter_Name[8] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[9] = ARG_MPS_YN;
				MyOraDB.Parameter_Name[10] = ARG_WORK_DAYS;
				MyOraDB.Parameter_Name[11] = ARG_DAILY_CAPA;
				MyOraDB.Parameter_Name[12] = "ARG_MODEL_CD";
				MyOraDB.Parameter_Name[13] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[14] = "ARG_OBS_ID_2";
				MyOraDB.Parameter_Name[15] = "ARG_SEQ";
				MyOraDB.Parameter_Name[16] = "ARG_CELL_COLOR";
				
				//03. Type
				for (int iCol = 0 ; iCol < iCount ; iCol++)
				{
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				}
				MyOraDB.Parameter_Type[6] = (int)OracleType.Number;
				MyOraDB.Parameter_Type[15] = (int)OracleType.Number;
				ArrayList temp = new ArrayList();
				
				////////////////////////////////////////////////////////////////
				for (int iRow = _MainRowfixed; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if (fgrid_main.Rows[iRow].AllowEditing==false)
					{
						continue;
					}
					int _colPlanComplete = -1;
					_colPlanComplete = FindPlanComplete(iRow);
					for (int iCol = _MaxCol + 1;iCol < fgrid_main.Cols.Count - 1; iCol ++)
					{					
						temp.Add(Convert.ToString(cmb_Factory.SelectedValue));
						temp.Add(Convert.ToString(fgrid_main.Rows[iRow].UserData));//line cd
						temp.Add(Convert.ToString(fgrid_main[iRow, G1_COL_LINE_CD]));//mini line
						temp.Add(fgrid_main.Cols[iCol].Caption);
						temp.Add(Convert.ToString(fgrid_main[iRow, G1_COL_OS_CODE]));
						temp.Add(Convert.ToString(fgrid_main[iRow, G1_COL_ITEM]));
						if (  fgrid_main[iRow, iCol] == null)
						{
							temp.Add("0");
						} 
						else
						{
							if(iCol==_colPlanComplete)
							{
								temp.Add("0");
							}
							else
							{
								temp.Add(Convert.ToString(fgrid_main[iRow, iCol]).Replace(",",""));
							}
						}
						temp.Add(COM.ComVar.This_User);
						if (ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("D"))
						{
							temp.Add(fgrid_main[iRow, 0].ToString());
						}
						else
						{
							if (ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("I"))
							{
								temp.Add(fgrid_main[iRow, 0].ToString());
							}
							else
							{
								temp.Add("U");
							}
						}
						
						
						if (_colPlanComplete != -1)
						{
							if (_MaxCol < iCol && iCol <= _colPlanComplete)
							{
								if(_colPlanComplete == iCol)
								{
									temp.Add("Y");
								}
								else
								{
									temp.Add("N");
								}
							}
							else
							{
								temp.Add("N");
							}
						}
						else
							temp.Add("N");

						temp.Add(Convert.ToString(fgrid_main[3, iCol]));
						temp.Add(Convert.ToString(fgrid_main.Cols[iCol].UserData));
						temp.Add(Convert.ToString(fgrid_main[iRow, G1_COL_MODEL_CD]));
						temp.Add(Convert.ToString(fgrid_main[1, iCol]));
						temp.Add(Convert.ToString(fgrid_main[iRow, G1_COL_ODS_ID]));
//						if (_colPlanComplete != -1)
//						{
//							if (_colPlanComplete == iCol)
//							{
//								temp.Add(Convert.ToString(fgrid_main[iRow,_colPlanComplete]).Replace(",",""));
//							}
//							else
//							{
//								temp.Add("");
//							}
//						}
//						else
//						{
//							temp.Add("");
//						}
						temp.Add(Convert.ToString(fgrid_main[iRow, G1_COL_SEQ]));
						if(fgrid_main.GetCellStyle(iRow, iCol)!=null)

						temp.Add(fgrid_main.GetCellStyle(iRow, iCol).BackColor.ToArgb());
						else
						temp.Add(-1);
					}
				}


				//MessageBox.Show(temp.Count.ToString());
				//////////////////////////////////////////////////////////////////


				MyOraDB.Parameter_Values  = new string[temp.Count];
//				for (int iRow = _MainRowfixed; iRow < fgrid_main.Rows.Count ; iRow++)
//				{
//					if (fgrid_main.Rows[iRow].AllowEditing==false)
//					{
//						continue;
//					}
//					int _colPlanComplete = -1;
//					_colPlanComplete = FindPlanComplete(iRow);
//					for (int iCol = _MaxCol + 1;iCol < fgrid_main.Cols.Count - 1; iCol ++)
//					{					
//						MyOraDB.Parameter_Values[para_ct + 0] = Convert.ToString(cmb_Factory.SelectedValue);
//						MyOraDB.Parameter_Values[para_ct + 1] = Convert.ToString(fgrid_main.Rows[iRow].UserData);//line cd
//						MyOraDB.Parameter_Values[para_ct + 2] = Convert.ToString(fgrid_main[iRow, G1_COL_LINE_CD]);//mini line
//						MyOraDB.Parameter_Values[para_ct + 3] =  fgrid_main.Cols[iCol].Caption;
//						MyOraDB.Parameter_Values[para_ct + 4] = Convert.ToString(fgrid_main[iRow, G1_COL_OS_CODE]);
//						MyOraDB.Parameter_Values[para_ct + 5] = Convert.ToString(fgrid_main[iRow, G1_COL_ITEM]);
//						if (  fgrid_main[iRow, iCol] == null)
//						{
//							MyOraDB.Parameter_Values[para_ct+ 6] = "0";
//						} 
//						else
//						{
//							MyOraDB.Parameter_Values[para_ct+ 6] = Convert.ToString(fgrid_main[iRow, iCol]).Replace(",","");
//						}
//						MyOraDB.Parameter_Values[para_ct+ 7] = COM.ComVar.This_User;
//						if (ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("D"))
//							MyOraDB.Parameter_Values[para_ct+ 8] = fgrid_main[iRow, 0].ToString();
//						else
//							MyOraDB.Parameter_Values[para_ct+ 8] = "O";
//						
//						
//						if (_colPlanComplete != -1)
//						{
//							if (_MaxCol <iCol && iCol <= _colPlanComplete)
//							{
//								if(_colPlanComplete == iCol)
//								{
//									MyOraDB.Parameter_Values[para_ct+ 9] = "Y";
//								}
//								else
//								{
//									MyOraDB.Parameter_Values[para_ct+ 9] = "N";
//								}
//							}
//							else
//							{
//								MyOraDB.Parameter_Values[para_ct+ 9] = "N";
//							}
//						}
//						else
//							MyOraDB.Parameter_Values[para_ct+ 9] = "N";
//
//						MyOraDB.Parameter_Values[para_ct+ 10] = Convert.ToString(fgrid_main[3, iCol]);
//						MyOraDB.Parameter_Values[para_ct+ 11] = Convert.ToString(fgrid_main.Cols[iCol].UserData);
//						MyOraDB.Parameter_Values[para_ct+ 12] = Convert.ToString(fgrid_main[iRow, G1_COL_MODEL_CD]);
//						MyOraDB.Parameter_Values[para_ct+ 13] = Convert.ToString(fgrid_main[1, iCol]);
//						MyOraDB.Parameter_Values[para_ct+ 14] = Convert.ToString(fgrid_main[iRow, G1_COL_SEQ]);
//
//						para_ct += iCount;	
//					}
//				}
				for (int j=0; j<temp.Count;j++)
				{
					MyOraDB.Parameter_Values[j] = temp[j].ToString();
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
			catch(System.Exception ex)
			{
				return false;
			}
		
			//return true;
		}

		
		private DataTable SELECT_SPB_CAL_WORK()
		{
			//TODO: not yet
			DataSet vDt;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_PLAN_SIMULATION.SEL_NEW_PLAN_SIMULATION_HEAD";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = ARG_FACTORY;
			MyOraDB.Parameter_Name[1]  = ARG_FROM_DATE;
			MyOraDB.Parameter_Name[2]  = ARG_TO_DATE;
			MyOraDB.Parameter_Name[3]  = OUT_CURSOR;

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]   = dpick_date_from.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[2]   = dpick_date_To.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[3]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null;
			return vDt.Tables[MyOraDB.Process_Name];
		}

		
		private DateTime ConvertToDateTime(string p_yyyyMMdd)
		{
			return DateTime.ParseExact(p_yyyyMMdd,"yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture );
		}
		

		private string CalSeq(string arg_line_cd,string arg_mini_line)
		{
			int l_tmp = 1;
			for (int i = 0;i < fgrid_main.Rows.Count; i++)
			{
				if (fgrid_main.Rows[i].AllowEditing==false)
				{
					continue;
				}
				if(fgrid_main[i,G1_COL_LINE_CD].ToString().Equals(arg_mini_line)
					&& arg_line_cd == fgrid_main.Rows[i].UserData.ToString())
				{
					int curSeq = 1;
					if (fgrid_main[i,G1_COL_SEQ]!=null)
					{
						if (fgrid_main[i,G1_COL_SEQ].ToString()!="")
						{
							curSeq = int.Parse(fgrid_main[i,G1_COL_SEQ].ToString());
							if (curSeq > l_tmp)
							{
								l_tmp = curSeq;
							}							
						}
					}
				}	
				else
					continue;
			}
			return Convert.ToString(l_tmp + 1);
		}

		private string CalSeq1(string arg_line_cd,string arg_mini_line)
		{
			int l_tmp = 0;
			for (int i = 0;i < fgrid_main.Rows.Count; i++)
			{
				if (fgrid_main.Rows[i].AllowEditing==false)
				{
					continue;
				}
				if(fgrid_main[i,G1_COL_LINE_CD].ToString().Equals(arg_mini_line)
					&& arg_line_cd == fgrid_main.Rows[i].UserData.ToString())
				{
					int curSeq = 1;
					if (fgrid_main[i,G1_COL_SEQ]!=null)
					{
						if (fgrid_main[i,G1_COL_SEQ].ToString()!="")
						{
							curSeq = int.Parse(fgrid_main[i,G1_COL_SEQ].ToString());
							if (curSeq > l_tmp)
							{
								l_tmp = curSeq;
							}							
						}
					}
				}	
				else
					continue;
			}
			return Convert.ToString(l_tmp + 1);
		}
		
		
		private void SetViewOption(COM.FSP arg_fgrid, ViewOption arg_ViewOption)
		{
			if(arg_ViewOption == ViewOption.Line)//view Line
			{
				arg_fgrid.Tree.Show(0);
			}
			if(arg_ViewOption == ViewOption.Model)//view Model
			{
				arg_fgrid.Tree.Show(1);
			}
		}

		
		private void ActiveViewOption(ViewOption arg_ViewOption)
		{
			if(ViewOption.Line == arg_ViewOption)
			{
				rbt_Line.Checked = true;
			}
			else
			{
				rbt_Model.Checked = true;
			}
		}

		
		#endregion

		private void dpick_date_from_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			tbtn_Search_Click(tbtn_Search,null);
		}

		
		private void dpick_date_To_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			tbtn_Search_Click(tbtn_Search,null);
		}

		
		private void rbt_Line_CheckedChanged(object sender, System.EventArgs e)
		{
			RadioButton l_RadioButton = (RadioButton)sender;
			if(l_RadioButton.Checked == true)
			{
				switch(tab_Content.SelectedIndex)
				{
					case 0:
						SetViewOption(fgrid_main,ViewOption.Line);
						break;
					case 1:
						SetViewOption(fgrid_SP1,ViewOption.Line);
						break;
					case 2:
						SetViewOption(fgrid_SU,ViewOption.Line);
						break;
					case 3:
						SetViewOption(fgrid_FA,ViewOption.Line);
						break;
					case 4:
						SetViewOption(fgrid_HO,ViewOption.Line);
						break;
					case 5:
						SetViewOption(fgrid_SP2,ViewOption.Line);
						break;
				}
				
			}
		}

		
		private void rbt_Model_CheckedChanged(object sender, System.EventArgs e)
		{
			RadioButton l_RadioButton = (RadioButton)sender;
			if(l_RadioButton.Checked == true)
			{
				switch(tab_Content.SelectedIndex)
				{
					case 0:
						SetViewOption(fgrid_main,ViewOption.Model);
						break;
					case 1:
						SetViewOption(fgrid_SP1,ViewOption.Model);
						break;
					case 2:
						SetViewOption(fgrid_SU,ViewOption.Model);
						break;
					case 3:
						SetViewOption(fgrid_FA,ViewOption.Model);
						break;
					case 4:
						SetViewOption(fgrid_HO,ViewOption.Model);
						break;
					case 5:
						SetViewOption(fgrid_SP2,ViewOption.Model);
						break;
				}
				
			}
		}

		
		private void tab_Content_SelectedIndexChanged(object sender, System.EventArgs e)
		{

			TabControl l_TabControl =(TabControl)sender;
			tbtn_New.Enabled = false;
			tbtn_Delete.Enabled=false;
			tbtn_Save.Enabled=false;
			tbtn_Search.Enabled=false;
			try
			{
				this.Cursor = Cursors.WaitCursor;
				switch(l_TabControl.SelectedIndex)
				{
					case 0://tab summary selected
						ActiveViewOption(ViewOption.Line);
						tbtn_New.Enabled = true;
						tbtn_Delete.Enabled=true;
						tbtn_Save.Enabled=true;
						tbtn_Search.Enabled=true;

						break;
					case 1://tab sp 1 selected
						ActiveViewOption(ViewOption.Model);
						tbtn_New.Enabled = false;
						tbtn_Delete.Enabled=false;
						tbtn_Save.Enabled=false;
						tbtn_Search.Enabled=true;
						//ExeTab(1,ref fgrid_SP1);
						break;
					case 2://tab su selected
						ActiveViewOption(ViewOption.Model);
						tbtn_New.Enabled = false;
						tbtn_Delete.Enabled=false;
						tbtn_Save.Enabled=false;
						tbtn_Search.Enabled=true;
						//ExeTab(2,ref fgrid_SU);
						break;
					case 3://tab fa selected
						ActiveViewOption(ViewOption.Model);
						tbtn_New.Enabled = false;
						tbtn_Delete.Enabled=false;
						tbtn_Save.Enabled=false;
						tbtn_Search.Enabled=true;
						//ExeTab(3,ref fgrid_FA);
						break;
					case 4://tab ho selected
						ActiveViewOption(ViewOption.Model);
						tbtn_New.Enabled = false;
						tbtn_Delete.Enabled=false;
						tbtn_Save.Enabled=false;
						tbtn_Search.Enabled=true;
						//ExeTab(4,ref fgrid_HO);
						break;
					case 5://tab sp 2 selected
						ActiveViewOption(ViewOption.Model);
						tbtn_New.Enabled = false;
						tbtn_Delete.Enabled=false;
						tbtn_Save.Enabled=false;
						tbtn_Search.Enabled=true;
						//ExeTab(5,ref fgrid_SP2);
						break;
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message,"Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
			
		}

		private void ExeTab(int arg_Tab_Index, ref COM.FSP arg_fgrid)
		{
			DataTable l_DataTable = SELECT_SVM_SEASON_MASTER(tab_Content.TabPages[arg_Tab_Index].Text.Substring(0,2),
				tab_Content.TabPages[arg_Tab_Index].Text.Substring(2,2));
			Clear_FlexGrid(arg_fgrid,false);
			if(l_DataTable != null)
			{
				string _from_obs_id = " ";
				try
				{
					_from_obs_id = Convert.ToString(l_DataTable.Rows[0]["from_obsid"]);
				}
				catch
				{
					_from_obs_id = " ";
				}
				string _to_obs_id = " ";
				try
				{
					_to_obs_id = Convert.ToString(l_DataTable.Rows[0]["to_obsid"]);
				}
				catch
				{
					_to_obs_id = " ";
				}

				DataTable dt = SELECT_PLAN_SIMULATION_BY_SEASON(tab_Content.TabPages[arg_Tab_Index].Text.Substring(0,2),
					int.Parse(	tab_Content.TabPages[arg_Tab_Index].Text.Substring(2,2)), _from_obs_id,_to_obs_id);
				Display_FlexGrid_Season_Tab(dt,ref arg_fgrid);
				if(dt != null)
				{
					if(dt.Rows.Count > 0)
					{
						SELECT_PLAN_SIMULATION_HEAD_BY_SEASON(_from_obs_id,_to_obs_id,ref arg_fgrid);
						SELECT_PLAN_SIMULATION_VALUES_BY_SEASON(_from_obs_id,_to_obs_id,ref arg_fgrid);
					}
				}
				AddEmptyColumn(ref arg_fgrid);
				CalSum(arg_fgrid, false);
				CalRowSum(ref arg_fgrid);
				FormatGird(ref arg_fgrid);
				FormatGird2(ref arg_fgrid);
				AddColumnOver(ref arg_fgrid);
			}
		
		}
		
		private void fgrid_main_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button != MouseButtons.Right)
			{
				return;
				//COM.FSP l_fgrid1 = (COM.FSP)sender;
				//HitTestInfo _hit1 = l_fgrid1.HitTest(e.X,e.Y);
				//MessageBox.Show(_hit1.Row.ToString()+","+_hit1.Column.ToString());
			}
			COM.FSP l_fgrid = (COM.FSP)sender;
			HitTestInfo _hit = l_fgrid.HitTest(e.X,e.Y);
			MessageBox.Show(_hit.Row.ToString()+","+_hit.Column.ToString());
			DateTime l_DateTime = ConvertToDateTime(l_fgrid.Cols[_hit.Column].Caption.ToString());
			string l_value = ConvertOBS_ID(l_DateTime.Year,l_DateTime.Month);
			int a= Convert.ToInt32(GET_CAPA_QTY(cmb_Factory.SelectedValue.ToString(),l_fgrid.Cols[_hit.Column].Caption.ToString(),l_value.Substring(0,2),l_fgrid.Rows[_hit.Row].UserData.ToString()));
			int b =Convert.ToInt32(Convert.ToString(l_fgrid.Rows[3][_hit.Column]));
			MessageBox.Show(Convert.ToString(a*b));
			MessageBox.Show(l_fgrid.Cols[_hit.Column].UserData.ToString());
			if(l_fgrid.Rows[_hit.Row].Node.Level == 0)
			{
				cmenu_Menu1.Enabled = false;
			}
			else
			{
				cmenu_Menu1.Enabled = true;
			}

		}

		
		#region "Method for 5 new tab"

		private DataTable SELECT_SVM_SEASON_MASTER(string arg_season, string arg_year)
		{
			//TODO: not yet
			DataSet vDt;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_GROWTH_PLAN.sp_sel_svm_season_master1";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = ARG_FACTORY;
			MyOraDB.Parameter_Name[1]  = ARG_SEASON;
			MyOraDB.Parameter_Name[2]  = ARG_YEAR;
			MyOraDB.Parameter_Name[3]  = OUT_CURSOR;

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]   = arg_season;
			MyOraDB.Parameter_Values[2]   = arg_year;
			MyOraDB.Parameter_Values[3]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null;
			return vDt.Tables[MyOraDB.Process_Name];
		}


		private DataTable SELECT_PLAN_SIMULA_SCHE_HEAD_BY_SEASON(string arg_From_OBS_ID, string arg_To_OBS_ID)
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;			
			try
			{
				string process_name = "PKG_SVM_PLAN_SIMULATION.SP_SEL_SCHE_HEAD_SEASON_MS";

				MyOraDB.ReDim_Parameter(5);  
				MyOraDB.Process_Name = process_name;

				MyOraDB.Parameter_Name[0] = ARG_FACTORY; 
				MyOraDB.Parameter_Name[1] = ARG_FROM_OBS_ID; 
				MyOraDB.Parameter_Name[2] = ARG_TO_OBS_ID; 
				MyOraDB.Parameter_Name[3] = ARG_LINE_CD; 
				MyOraDB.Parameter_Name[4] = OUT_CURSOR; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1]   = arg_From_OBS_ID;
				MyOraDB.Parameter_Values[2]   = arg_To_OBS_ID;
				MyOraDB.Parameter_Values[3] = cbm_Line.SelectedValue.ToString();
				MyOraDB.Parameter_Values[4] = ""; 

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

		
		private void SELECT_PLAN_SIMULATION_HEAD_BY_SEASON(string arg_From_OBS_ID, string arg_To_OBS_ID, ref COM.FSP arg_fgrid)
		{
			DataTable dt = SELECT_PLAN_SIMULA_SCHE_HEAD_BY_SEASON(arg_From_OBS_ID,arg_To_OBS_ID);
			if (dt != null)
			{
				if (dt.Rows.Count > 0)
				{
					for (int i = 0; i < dt.Rows.Count; i ++ )
					{
						DateTime l_DateTime = ConvertToDateTime(dt.Rows[i][0].ToString());
						string l_value = ConvertOBS_ID(l_DateTime.Year,l_DateTime.Month);
						arg_fgrid.Cols.Add();
						arg_fgrid.Cols[arg_fgrid.Cols.Count -1].AllowSorting = false;
						arg_fgrid.Cols[arg_fgrid.Cols.Count -1].Caption = dt.Rows[i][0].ToString();
						arg_fgrid.Cols[arg_fgrid.Cols.Count -1].UserData = GET_CAPA_QTY(cmb_Factory.SelectedValue.ToString(),
							dt.Rows[i][0].ToString(),l_value.Substring(0,2), cbm_Line.SelectedValue.ToString());
						arg_fgrid.Cols[arg_fgrid.Cols.Count -1].DataType = typeof(Int32);
						arg_fgrid.Set_CellStyle_Number(arg_fgrid.Cols.Count -1);
						
						arg_fgrid[1,arg_fgrid.Cols.Count -1] = l_value;
						CellStyle c1 = arg_fgrid.Styles.Add("ColColor" +  l_DateTime.Month.ToString());
						c1.ForeColor = Color.Black;

						c1.BackColor = GetColor(l_DateTime.Month);
						arg_fgrid.Cols[arg_fgrid.Cols.Count -1].Width = _DynamicColWidth;
						arg_fgrid.SetCellStyle(1,arg_fgrid.Cols.Count -1,c1);
						arg_fgrid[2,arg_fgrid.Cols.Count -1] = l_DateTime.ToString("MM/dd");
						arg_fgrid[3,arg_fgrid.Cols.Count -1] = dt.Rows[i][1].ToString();
						arg_fgrid.Cols[arg_fgrid.Cols.Count -1].AllowMerging=false;
						arg_fgrid.Rows[3].AllowMerging=false;
					}
					//Empty column 
					//AddEmptyColumn(ref arg_fgrid);
				}
			}
		}

		
		private void SELECT_PLAN_SIMULATION_VALUES_BY_SEASON(string arg_From_OBS_ID, string arg_To_OBS_ID, ref COM.FSP arg_fgrid)
		{
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataTable dt1 = null;
			DataSet ds_ret;			
			try
			{
				string process_name = "PKG_SVM_PLAN_SIMULATION.SP_SEL_SCHE_VALUES_SEASON_MS";

				MyOraDB.ReDim_Parameter(5);  
				MyOraDB.Process_Name = process_name;   

				MyOraDB.Parameter_Name[0] = ARG_FACTORY; 
				MyOraDB.Parameter_Name[1] = ARG_FROM_OBS_ID; 
				MyOraDB.Parameter_Name[2] = ARG_TO_OBS_ID; 
				MyOraDB.Parameter_Name[3] = ARG_LINE_CD; 
				MyOraDB.Parameter_Name[4] = OUT_CURSOR; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory," ");
				MyOraDB.Parameter_Values[1]   = arg_From_OBS_ID;
				MyOraDB.Parameter_Values[2]   = arg_To_OBS_ID;
				MyOraDB.Parameter_Values[3] = cbm_Line.SelectedValue.ToString();
				MyOraDB.Parameter_Values[4] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return ; 
				dt1 =  ds_ret.Tables[process_name]; 
			}
			catch
			{
				dt1 = null;
			}

			if (dt1 != null)
			{
				if (dt1.Rows.Count > 0)
				{
								
					for (int i =arg_fgrid.Rows.Fixed; i < arg_fgrid.Rows.Count; i ++ )
					{
						if (arg_fgrid.Rows[i].AllowEditing==false)
						{
							continue;
						}
						for (int j = _MaxColGS + 1; j < arg_fgrid.Cols.Count; j++)
						{
							string _strColor = "-1";
							string tmp = getValueData(dt1,
								Convert.ToString(arg_fgrid.Rows[i].UserData),
								Convert.ToString(arg_fgrid[i,GS_COL_SEQ]),
								Convert.ToString(arg_fgrid[i,GS_COL_LINE_CD]),
								arg_fgrid.Cols[j].Caption,
								Convert.ToString(arg_fgrid[i,GS_COL_OBS_ID_2]),
								//fgrid_main[i,G1_COL_ODS_ID].ToString(),
								Convert.ToString(arg_fgrid[i,GS_COL_MODEL_CD]),
								ref _strColor);
							if (tmp != "0")
							{
								arg_fgrid.Rows[i][j] = tmp	;
								arg_fgrid.SetCellStyle(i,j,GetCellStyleFromAGRB(_strColor));
							}
						
						}
					}
				}
			}
		}

		private int GetMinCol (COM.FSP arg_fgrid)
		{
			string obs_id= Convert.ToString(arg_fgrid[1,arg_fgrid.Cols.Count-3]);
			//MessageBox.Show(obs_id);
			int min_col =0;
			for (int i=arg_fgrid.Cols.Count-3;i>0;i--)
			{
				if(obs_id==Convert.ToString(arg_fgrid.Rows[1][i]))
				{
					min_col = i;
				}
			}
			return min_col;
		}
		
		private int GetMaxCol (COM.FSP arg_fgrid)
		{
			string obs_id = Convert.ToString(arg_fgrid[1,_MaxColGS]) ;
			//MessageBox.Show(obs_id);
			int max_col =0;
			for (int i=_MaxColGS;i<arg_fgrid.Cols.Count;i++)
			{
				if(obs_id==Convert.ToString(arg_fgrid.Rows[1][i]))
				{
					max_col = i;
				}
			}
			return max_col;
		}
		private void FormatGird2(ref COM.FSP gridTab)
		{
			CellStyle csRowLevel1 = gridTab.Styles.Add("RowLevel1");
			csRowLevel1.BackColor = Color.FromArgb(241,236,248);

			CellStyle csRowLevel2 = gridTab.Styles.Add("RowLevel2");
			csRowLevel2.BackColor = Color.FromArgb(217,247,197);

			CellStyle csRowLevel3 = gridTab.Styles.Add("RowLevel3");
			csRowLevel3.BackColor = Color.FromArgb(255,255,255);

			CellStyle csColFrist = gridTab.Styles.Add("ColFrist");
			csColFrist.BackColor = Color.LightGray;

			CellStyle csColLast = gridTab.Styles.Add("ColLast");
			csColLast.BackColor = Color.FromArgb(255,230,255);

			if(gridTab.Rows.Count<= gridTab.Rows.Fixed) return;
			for(int i =  gridTab.Rows.Fixed; i <  gridTab.Rows.Count; i ++)
			{
				CellStyle csTmp =null;
				//row is level 1
				if(gridTab.Rows[i].AllowEditing == false)
					gridTab.Rows[i].Style = csRowLevel1;
				else//row is level 2
				{
					int _min=GetMinCol(gridTab);
					int _max=GetMaxCol(gridTab);
					for(int j = 1; j < gridTab.Cols.Count; j++)
					{
						if(j >= 1 && j < _MaxColGS + 1) 
							gridTab.SetCellStyle(i,j,csRowLevel2);
						if(j > _MaxColGS)
							if(Convert.ToString( gridTab[i,j])=="" )
							{
								if ( gridTab.GetCellStyle(i,j)== null)
									//if( fgrid_main.GetCellStyle(i,j).BackColor != Color.Gray)
									gridTab.SetCellStyle(i,j,csRowLevel3);
							}
					}
					for(int j = _max; j < _min; j++)
					{
						try
						{
							if(csTmp==null&&Convert.ToString(gridTab[i,j])!="") csTmp = gridTab.GetCellStyle(1,j);
						}
						catch(Exception ex)
						{
							//MessageBox.Show("cho nay");
						}
//						if(Convert.ToString(gridTab[i,j])!="")
//						{
//							gridTab.SetCellStyle(i,j,csTmp);
//						}
					}
				}
			}
			//fill color group col frist
			if(_MaxColGS >= gridTab.Cols.Count-2)
			{
				return;
			}
			string obs_id = Convert.ToString(gridTab[1,_MaxColGS]) ;
			string obs_id2= Convert.ToString(gridTab[1,gridTab.Cols.Count-2]);
			int max_col = 0;
			int min_col2= 0;
			//MessageBox.Show(obs_id2);
			for (int i=_MaxColGS;i<gridTab.Cols.Count;i++)
			{
				if(obs_id==Convert.ToString(gridTab.Rows[1][i]))
				{
					max_col = i;
				}
			}
			for (int i=gridTab.Cols.Count-2;i>0;i--)
			{
				if(obs_id2==Convert.ToString(gridTab.Rows[1][i]))
				{
					min_col2 = i;
				}
			}
			//MessageBox.Show(min_col2.ToString());
			for(int i =  gridTab.Rows.Fixed; i <  gridTab.Rows.Count; i ++)
			{
				
				for(int j = _MaxColGS; j < max_col+1; j++)
				{
					try
					{
						if(gridTab.Rows[i].Node.Level!=0)
						{
							gridTab.SetCellStyle(i,j,csColFrist);
						}
						
					}
					catch(Exception ex)
					{
						//MessageBox.Show("cho nay");
					}
					
				}
		
			}
			for(int i =  gridTab.Rows.Fixed; i <  gridTab.Rows.Count; i ++)
			{
				
				for(int j = min_col2; j < gridTab.Cols.Count-1 ; j++)
				{
					try
					{
						if(gridTab.Rows[i].Node.Level!=0)
						{
							if(gridTab[i,j].ToString()!="")
							{
								gridTab.SetCellStyle(i,j,csColLast);
							}
							
						}
						
					}
					catch(Exception ex)
					{
						//MessageBox.Show("cho nay");
					}
					
				}
		
			}
		}
		#endregion

	}
	public enum ViewOption 
	{	
		Line,
		Model
	}

}
