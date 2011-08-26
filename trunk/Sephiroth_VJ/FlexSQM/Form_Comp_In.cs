using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Xml;
using System.Reflection;
using C1.Win.C1FlexGrid;  
using System.Data.OleDb;
using Microsoft.Office.Core;
using System.Runtime.InteropServices;

namespace FlexSQM
{
	/// <summary>
	/// Summary description for Form_Comp_In.
	/// </summary>
	public class Form_Comp_In : COM.SQMWinForm.Form_Top
	{
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel4;
		private COM.FSP fgrid_Comp_In;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label label4;
		private C1.Win.C1List.C1Combo cmb_Line;
		public System.Windows.Forms.DateTimePicker dpick_YMD;
		private C1.Win.C1List.C1Combo cmb_Lot_No;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_PlanYMD;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1List.C1Combo cmb_Vendor;
		private C1.Win.C1List.C1Combo cmb_Style;
		private System.Windows.Forms.TextBox txt_Style;
		private System.Windows.Forms.Label label5;
		public C1.Win.C1List.C1Combo cmb_Factor;
        private Panel panel5;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private Panel panel7;
        private COM.FSP fgrid_Lot_Size_Mps;
        private TabPage tabPage1;
        private Panel panel6;
        private COM.FSP fsp1;
        private TextBox txtComponent;
        private C1.Win.C1List.C1Combo cmbComponent;
        private Label label6;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form_Comp_In()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			Init_Control();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		

		private const int G_VENDOR_CD		= 1;
		private const int G_STYLE_CD		= 2;
		private const int G_LOT_NO			= 3;
		private const int G_IN_YMD			= 4;
		private const int G_SIZE_1			= 5;
		private const int G_SIZE_2			= 6;
		private const int G_SIZE_3			= 7;
		private const int G_SIZE_4			= 8;
		private const int G_SIZE_5			= 9;
		private const int G_SIZE_6			= 10;
		private const int G_SIZE_7			= 11;
		private const int G_SIZE_8			= 12;
		private const int G_SIZE_9			= 13;
		private const int G_SIZE_10			= 14;
		private const int G_SIZE_11			= 15;
		private const int G_SIZE_12			= 16;
		private const int G_SIZE_13			= 17;
		private const int G_SIZE_14			= 18;
		private const int G_SIZE_15			= 19;
		private const int G_SIZE_16			= 20;
		private const int G_SIZE_17			= 21;
		private const int G_SIZE_18			= 22;
		private const int G_SIZE_19			= 23;
		private const int G_SIZE_20			= 24;
		private const int G_SIZE_21			= 25;
		private const int G_SIZE_22			= 26;
		private const int G_SIZE_23			= 27;
		private const int G_SIZE_24			= 28;
		private const int G_SIZE_25			= 29;
		private const int G_SIZE_26			= 30;
		private const int G_SIZE_27			= 31;
		private const int G_SIZE_28			= 32;
		private const int G_SIZE_29			= 33;
		private const int G_SIZE_30			= 34;
		private const int G_SIZE_31			= 35;
		private const int G_SIZE_32			= 36;
		private const int G_SIZE_33			= 37;
		private const int G_SIZE_34			= 38;
		private const int G_SIZE_35			= 39;
		private const int G_SIZE_36			= 40;
		private const int G_SIZE_37			= 41;
		private const int G_SIZE_38			= 42;
		private const int G_SIZE_39			= 43;
        private const int G_SIZE_40         = 44;
        private const int G_TOTAL           = 45;
		private const int G_LINE_CD			= 46;
        private const int G_COMP_CD         = 47;
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Comp_In));
            C1.Win.C1List.Style style97 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style98 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style99 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style100 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style101 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style102 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style103 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style104 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style105 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style106 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style107 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style108 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style109 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style110 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style111 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style112 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style113 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style114 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style115 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style116 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style117 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style118 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style119 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style120 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style121 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style122 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style123 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style124 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style125 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style126 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style127 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style128 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style129 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style130 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style131 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style132 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style133 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style134 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style135 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style136 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style137 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style138 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style139 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style140 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style141 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style142 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style143 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style144 = new C1.Win.C1List.Style();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Line = new C1.Win.C1List.C1Combo();
            this.dpick_YMD = new System.Windows.Forms.DateTimePicker();
            this.cmb_Lot_No = new C1.Win.C1List.C1Combo();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PlanYMD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Style = new C1.Win.C1List.C1Combo();
            this.txt_Style = new System.Windows.Forms.TextBox();
            this.cmb_Factor = new C1.Win.C1List.C1Combo();
            this.label5 = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Vendor = new C1.Win.C1List.C1Combo();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fgrid_Comp_In = new COM.FSP();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.fgrid_Lot_Size_Mps = new COM.FSP();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.fsp1 = new COM.FSP();
            this.txtComponent = new System.Windows.Forms.TextBox();
            this.cmbComponent = new C1.Win.C1List.C1Combo();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Lot_No)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Comp_In)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Lot_Size_Mps)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fsp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComponent)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Menu
            // 
            this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
            this.img_Menu.Images.SetKeyName(0, "");
            this.img_Menu.Images.SetKeyName(1, "");
            this.img_Menu.Images.SetKeyName(2, "");
            this.img_Menu.Images.SetKeyName(3, "");
            this.img_Menu.Images.SetKeyName(4, "");
            this.img_Menu.Images.SetKeyName(5, "");
            this.img_Menu.Images.SetKeyName(6, "");
            this.img_Menu.Images.SetKeyName(7, "");
            this.img_Menu.Images.SetKeyName(8, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // c1ToolBar1
            // 
            this.c1ToolBar1.Location = new System.Drawing.Point(742, 4);
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
            this.stbar.Location = new System.Drawing.Point(0, 679);
            this.stbar.Size = new System.Drawing.Size(1028, 22);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(818, 23);
            this.lbl_MainTitle.Text = "Component InComing";
            // 
            // tbtn_Print
            // 
            this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
            // 
            // image_List
            // 
            this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
            this.image_List.Images.SetKeyName(0, "");
            this.image_List.Images.SetKeyName(1, "");
            this.image_List.Images.SetKeyName(2, "");
            this.image_List.Images.SetKeyName(3, "");
            this.image_List.Images.SetKeyName(4, "");
            this.image_List.Images.SetKeyName(5, "");
            this.image_List.Images.SetKeyName(6, "");
            this.image_List.Images.SetKeyName(7, "");
            this.image_List.Images.SetKeyName(8, "");
            this.image_List.Images.SetKeyName(9, "");
            this.image_List.Images.SetKeyName(10, "");
            this.image_List.Images.SetKeyName(11, "");
            this.image_List.Images.SetKeyName(12, "");
            this.image_List.Images.SetKeyName(13, "");
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            this.img_SmallButton.Images.SetKeyName(2, "");
            this.img_SmallButton.Images.SetKeyName(3, "");
            this.img_SmallButton.Images.SetKeyName(4, "");
            this.img_SmallButton.Images.SetKeyName(5, "");
            this.img_SmallButton.Images.SetKeyName(6, "");
            this.img_SmallButton.Images.SetKeyName(7, "");
            this.img_SmallButton.Images.SetKeyName(8, "");
            this.img_SmallButton.Images.SetKeyName(9, "");
            this.img_SmallButton.Images.SetKeyName(10, "");
            this.img_SmallButton.Images.SetKeyName(11, "");
            this.img_SmallButton.Images.SetKeyName(12, "");
            this.img_SmallButton.Images.SetKeyName(13, "");
            this.img_SmallButton.Images.SetKeyName(14, "");
            this.img_SmallButton.Images.SetKeyName(15, "");
            this.img_SmallButton.Images.SetKeyName(16, "");
            this.img_SmallButton.Images.SetKeyName(17, "");
            this.img_SmallButton.Images.SetKeyName(18, "");
            this.img_SmallButton.Images.SetKeyName(19, "");
            this.img_SmallButton.Images.SetKeyName(20, "");
            this.img_SmallButton.Images.SetKeyName(21, "");
            this.img_SmallButton.Images.SetKeyName(22, "");
            this.img_SmallButton.Images.SetKeyName(23, "");
            this.img_SmallButton.Images.SetKeyName(24, "");
            this.img_SmallButton.Images.SetKeyName(25, "");
            this.img_SmallButton.Images.SetKeyName(26, "");
            this.img_SmallButton.Images.SetKeyName(27, "");
            this.img_SmallButton.Images.SetKeyName(28, "");
            this.img_SmallButton.Images.SetKeyName(29, "");
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.label4);
            this.pnl_SearchImage.Controls.Add(this.cmb_Line);
            this.pnl_SearchImage.Controls.Add(this.dpick_YMD);
            this.pnl_SearchImage.Controls.Add(this.cmb_Lot_No);
            this.pnl_SearchImage.Controls.Add(this.label1);
            this.pnl_SearchImage.Controls.Add(this.lbl_PlanYMD);
            this.pnl_SearchImage.Controls.Add(this.label3);
            this.pnl_SearchImage.Controls.Add(this.cmb_Style);
            this.pnl_SearchImage.Controls.Add(this.txt_Style);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factor);
            this.pnl_SearchImage.Controls.Add(this.label5);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Controls.Add(this.picb_MM);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1032, 96);
            this.pnl_SearchImage.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.ImageIndex = 1;
            this.label4.ImageList = this.img_Label;
            this.label4.Location = new System.Drawing.Point(384, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 598;
            this.label4.Text = "Line";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Line
            // 
            this.cmb_Line.AddItemCols = 0;
            this.cmb_Line.AddItemSeparator = ';';
            this.cmb_Line.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Line.Caption = "";
            this.cmb_Line.CaptionHeight = 17;
            this.cmb_Line.CaptionStyle = style97;
            this.cmb_Line.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Line.ColumnCaptionHeight = 18;
            this.cmb_Line.ColumnFooterHeight = 18;
            this.cmb_Line.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Line.ContentHeight = 16;
            this.cmb_Line.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Line.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Line.EditorFont = new System.Drawing.Font("Gulim", 9F);
            this.cmb_Line.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Line.EditorHeight = 16;
            this.cmb_Line.EvenRowStyle = style98;
            this.cmb_Line.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Line.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Line.FooterStyle = style99;
            this.cmb_Line.GapHeight = 2;
            this.cmb_Line.HeadingStyle = style100;
            this.cmb_Line.HighLightRowStyle = style101;
            this.cmb_Line.ItemHeight = 15;
            this.cmb_Line.Location = new System.Drawing.Point(496, 32);
            this.cmb_Line.MatchEntryTimeout = ((long)(2000));
            this.cmb_Line.MaxDropDownItems = ((short)(5));
            this.cmb_Line.MaxLength = 32767;
            this.cmb_Line.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Line.Name = "cmb_Line";
            this.cmb_Line.OddRowStyle = style102;
            this.cmb_Line.PartialRightColumn = false;
            this.cmb_Line.PropBag = resources.GetString("cmb_Line.PropBag");
            this.cmb_Line.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Line.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Line.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Line.SelectedStyle = style103;
            this.cmb_Line.Size = new System.Drawing.Size(152, 20);
            this.cmb_Line.Style = style104;
            this.cmb_Line.TabIndex = 597;
            this.cmb_Line.SelectedValueChanged += new System.EventHandler(this.cmb_Line_SelectedValueChanged);
            // 
            // dpick_YMD
            // 
            this.dpick_YMD.CustomFormat = "yyyy-MM-dd";
            this.dpick_YMD.Font = new System.Drawing.Font("Verdana", 9F);
            this.dpick_YMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_YMD.Location = new System.Drawing.Point(776, 32);
            this.dpick_YMD.Name = "dpick_YMD";
            this.dpick_YMD.Size = new System.Drawing.Size(102, 22);
            this.dpick_YMD.TabIndex = 589;
            this.dpick_YMD.ValueChanged += new System.EventHandler(this.dpick_YMD_ValueChanged);
            // 
            // cmb_Lot_No
            // 
            this.cmb_Lot_No.AccessibleDescription = "";
            this.cmb_Lot_No.AccessibleName = "";
            this.cmb_Lot_No.AddItemCols = 0;
            this.cmb_Lot_No.AddItemSeparator = ';';
            this.cmb_Lot_No.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_Lot_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Lot_No.Caption = "";
            this.cmb_Lot_No.CaptionHeight = 17;
            this.cmb_Lot_No.CaptionStyle = style105;
            this.cmb_Lot_No.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Lot_No.ColumnCaptionHeight = 18;
            this.cmb_Lot_No.ColumnFooterHeight = 18;
            this.cmb_Lot_No.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Lot_No.ContentHeight = 17;
            this.cmb_Lot_No.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Lot_No.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Lot_No.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Lot_No.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Lot_No.EditorHeight = 17;
            this.cmb_Lot_No.EvenRowStyle = style106;
            this.cmb_Lot_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Lot_No.FooterStyle = style107;
            this.cmb_Lot_No.GapHeight = 2;
            this.cmb_Lot_No.HeadingStyle = style108;
            this.cmb_Lot_No.HighLightRowStyle = style109;
            this.cmb_Lot_No.ItemHeight = 15;
            this.cmb_Lot_No.Location = new System.Drawing.Point(496, 64);
            this.cmb_Lot_No.MatchEntryTimeout = ((long)(2000));
            this.cmb_Lot_No.MaxDropDownItems = ((short)(5));
            this.cmb_Lot_No.MaxLength = 32767;
            this.cmb_Lot_No.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Lot_No.Name = "cmb_Lot_No";
            this.cmb_Lot_No.OddRowStyle = style110;
            this.cmb_Lot_No.PartialRightColumn = false;
            this.cmb_Lot_No.PropBag = resources.GetString("cmb_Lot_No.PropBag");
            this.cmb_Lot_No.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Lot_No.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Lot_No.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Lot_No.SelectedStyle = style111;
            this.cmb_Lot_No.Size = new System.Drawing.Size(152, 21);
            this.cmb_Lot_No.Style = style112;
            this.cmb_Lot_No.TabIndex = 596;
            this.cmb_Lot_No.Change += new C1.Win.C1List.ChangeEventHandler(this.cmb_Lot_No_Change_1);
            // 
            // label1
            // 
            this.label1.ImageIndex = 1;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(384, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 595;
            this.label1.Text = "LOT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PlanYMD
            // 
            this.lbl_PlanYMD.ImageIndex = 1;
            this.lbl_PlanYMD.ImageList = this.img_Label;
            this.lbl_PlanYMD.Location = new System.Drawing.Point(672, 32);
            this.lbl_PlanYMD.Name = "lbl_PlanYMD";
            this.lbl_PlanYMD.Size = new System.Drawing.Size(100, 21);
            this.lbl_PlanYMD.TabIndex = 588;
            this.lbl_PlanYMD.Text = "Scheduled Day";
            this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.ImageIndex = 1;
            this.label3.ImageList = this.img_Label;
            this.label3.Location = new System.Drawing.Point(32, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 594;
            this.label3.Text = "Style Code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Style
            // 
            this.cmb_Style.AccessibleDescription = "";
            this.cmb_Style.AccessibleName = "";
            this.cmb_Style.AddItemCols = 0;
            this.cmb_Style.AddItemSeparator = ';';
            this.cmb_Style.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Style.Caption = "";
            this.cmb_Style.CaptionHeight = 17;
            this.cmb_Style.CaptionStyle = style113;
            this.cmb_Style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Style.ColumnCaptionHeight = 18;
            this.cmb_Style.ColumnFooterHeight = 18;
            this.cmb_Style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Style.ContentHeight = 17;
            this.cmb_Style.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Style.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Style.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Style.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Style.EditorHeight = 17;
            this.cmb_Style.EvenRowStyle = style114;
            this.cmb_Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Style.FooterStyle = style115;
            this.cmb_Style.GapHeight = 2;
            this.cmb_Style.HeadingStyle = style116;
            this.cmb_Style.HighLightRowStyle = style117;
            this.cmb_Style.ItemHeight = 15;
            this.cmb_Style.Location = new System.Drawing.Point(208, 32);
            this.cmb_Style.MatchEntryTimeout = ((long)(2000));
            this.cmb_Style.MaxDropDownItems = ((short)(5));
            this.cmb_Style.MaxLength = 32767;
            this.cmb_Style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Style.Name = "cmb_Style";
            this.cmb_Style.OddRowStyle = style118;
            this.cmb_Style.PartialRightColumn = false;
            this.cmb_Style.PropBag = resources.GetString("cmb_Style.PropBag");
            this.cmb_Style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Style.SelectedStyle = style119;
            this.cmb_Style.Size = new System.Drawing.Size(152, 21);
            this.cmb_Style.Style = style120;
            this.cmb_Style.TabIndex = 592;
            this.cmb_Style.SelectedValueChanged += new System.EventHandler(this.cmb_Style_SelectedValueChanged_1);
            // 
            // txt_Style
            // 
            this.txt_Style.BackColor = System.Drawing.Color.White;
            this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Style.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Style.Location = new System.Drawing.Point(136, 32);
            this.txt_Style.MaxLength = 100;
            this.txt_Style.Name = "txt_Style";
            this.txt_Style.Size = new System.Drawing.Size(72, 21);
            this.txt_Style.TabIndex = 591;
            this.txt_Style.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Style_KeyUp_1);
            // 
            // cmb_Factor
            // 
            this.cmb_Factor.AddItemCols = 0;
            this.cmb_Factor.AddItemSeparator = ';';
            this.cmb_Factor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Factor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factor.Caption = "";
            this.cmb_Factor.CaptionHeight = 17;
            this.cmb_Factor.CaptionStyle = style121;
            this.cmb_Factor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factor.ColumnCaptionHeight = 18;
            this.cmb_Factor.ColumnFooterHeight = 18;
            this.cmb_Factor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factor.ContentHeight = 17;
            this.cmb_Factor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factor.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factor.EditorHeight = 17;
            this.cmb_Factor.EvenRowStyle = style122;
            this.cmb_Factor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factor.FooterStyle = style123;
            this.cmb_Factor.GapHeight = 2;
            this.cmb_Factor.HeadingStyle = style124;
            this.cmb_Factor.HighLightRowStyle = style125;
            this.cmb_Factor.ItemHeight = 15;
            this.cmb_Factor.Location = new System.Drawing.Point(136, 64);
            this.cmb_Factor.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factor.MaxDropDownItems = ((short)(5));
            this.cmb_Factor.MaxLength = 32767;
            this.cmb_Factor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factor.Name = "cmb_Factor";
            this.cmb_Factor.OddRowStyle = style126;
            this.cmb_Factor.PartialRightColumn = false;
            this.cmb_Factor.PropBag = resources.GetString("cmb_Factor.PropBag");
            this.cmb_Factor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factor.SelectedStyle = style127;
            this.cmb_Factor.Size = new System.Drawing.Size(224, 21);
            this.cmb_Factor.Style = style128;
            this.cmb_Factor.TabIndex = 587;
            // 
            // label5
            // 
            this.label5.ImageIndex = 1;
            this.label5.ImageList = this.img_Label;
            this.label5.Location = new System.Drawing.Point(32, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 586;
            this.label5.Text = "Factory";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(1015, 24);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(17, 56);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(1016, 0);
            this.picb_TR.Name = "picb_TR";
            this.picb_TR.Size = new System.Drawing.Size(16, 32);
            this.picb_TR.TabIndex = 21;
            this.picb_TR.TabStop = false;
            // 
            // picb_TM
            // 
            this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
            this.picb_TM.Location = new System.Drawing.Point(224, 0);
            this.picb_TM.Name = "picb_TM";
            this.picb_TM.Size = new System.Drawing.Size(808, 32);
            this.picb_TM.TabIndex = 0;
            this.picb_TM.TabStop = false;
            // 
            // lbl_SubTitle1
            // 
            this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
            this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle1.Name = "lbl_SubTitle1";
            this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle1.TabIndex = 28;
            this.lbl_SubTitle1.Text = "      LOT Information";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(1016, 81);
            this.picb_BR.Name = "picb_BR";
            this.picb_BR.Size = new System.Drawing.Size(16, 16);
            this.picb_BR.TabIndex = 23;
            this.picb_BR.TabStop = false;
            // 
            // picb_BM
            // 
            this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
            this.picb_BM.Location = new System.Drawing.Point(144, 80);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(872, 18);
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
            this.picb_BL.Size = new System.Drawing.Size(168, 20);
            this.picb_BL.TabIndex = 22;
            this.picb_BL.TabStop = false;
            // 
            // picb_ML
            // 
            this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
            this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
            this.picb_ML.Location = new System.Drawing.Point(0, 24);
            this.picb_ML.Name = "picb_ML";
            this.picb_ML.Size = new System.Drawing.Size(168, 59);
            this.picb_ML.TabIndex = 25;
            this.picb_ML.TabStop = false;
            // 
            // picb_MM
            // 
            this.picb_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
            this.picb_MM.Location = new System.Drawing.Point(160, 24);
            this.picb_MM.Name = "picb_MM";
            this.picb_MM.Size = new System.Drawing.Size(864, 56);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // label2
            // 
            this.label2.ImageIndex = 1;
            this.label2.ImageList = this.img_Label;
            this.label2.Location = new System.Drawing.Point(25, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 593;
            this.label2.Text = "Vendor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Vendor
            // 
            this.cmb_Vendor.AddItemCols = 0;
            this.cmb_Vendor.AddItemSeparator = ';';
            this.cmb_Vendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Vendor.Caption = "";
            this.cmb_Vendor.CaptionHeight = 17;
            this.cmb_Vendor.CaptionStyle = style129;
            this.cmb_Vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Vendor.ColumnCaptionHeight = 18;
            this.cmb_Vendor.ColumnFooterHeight = 18;
            this.cmb_Vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Vendor.ContentHeight = 16;
            this.cmb_Vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Vendor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Vendor.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_Vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Vendor.EditorHeight = 16;
            this.cmb_Vendor.EvenRowStyle = style130;
            this.cmb_Vendor.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Vendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vendor.FooterStyle = style131;
            this.cmb_Vendor.GapHeight = 2;
            this.cmb_Vendor.HeadingStyle = style132;
            this.cmb_Vendor.HighLightRowStyle = style133;
            this.cmb_Vendor.ItemHeight = 15;
            this.cmb_Vendor.Location = new System.Drawing.Point(129, 429);
            this.cmb_Vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_Vendor.MaxDropDownItems = ((short)(5));
            this.cmb_Vendor.MaxLength = 32767;
            this.cmb_Vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Vendor.Name = "cmb_Vendor";
            this.cmb_Vendor.OddRowStyle = style134;
            this.cmb_Vendor.PartialRightColumn = false;
            this.cmb_Vendor.PropBag = resources.GetString("cmb_Vendor.PropBag");
            this.cmb_Vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.SelectedStyle = style135;
            this.cmb_Vendor.Size = new System.Drawing.Size(224, 20);
            this.cmb_Vendor.Style = style136;
            this.cmb_Vendor.TabIndex = 590;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.Location = new System.Drawing.Point(0, 0);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 23);
            this.lbl_Factory.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnl_SearchImage);
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 96);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Location = new System.Drawing.Point(0, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 220);
            this.panel3.TabIndex = 31;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 220);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 181;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1016, 193);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "InComing Component";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.fgrid_Comp_In);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1016, 193);
            this.panel4.TabIndex = 182;
            // 
            // fgrid_Comp_In
            // 
            this.fgrid_Comp_In.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Comp_In.ColumnInfo = "7,1,0,0,0,95,Columns:";
            this.fgrid_Comp_In.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Comp_In.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Comp_In.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Comp_In.Name = "fgrid_Comp_In";
            this.fgrid_Comp_In.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fgrid_Comp_In.Size = new System.Drawing.Size(1016, 193);
            this.fgrid_Comp_In.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Comp_In.Styles"));
            this.fgrid_Comp_In.TabIndex = 181;
            this.fgrid_Comp_In.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Comp_In_AfterEdit);
            this.fgrid_Comp_In.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgrid_Comp_In_AfterScroll);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tabControl2);
            this.panel5.Location = new System.Drawing.Point(0, 184);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1024, 240);
            this.panel5.TabIndex = 32;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1024, 240);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl2.TabIndex = 182;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1016, 213);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "MPS Size Dialy";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.fgrid_Lot_Size_Mps);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1016, 213);
            this.panel7.TabIndex = 182;
            // 
            // fgrid_Lot_Size_Mps
            // 
            this.fgrid_Lot_Size_Mps.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Lot_Size_Mps.ColumnInfo = "7,1,0,0,0,95,Columns:";
            this.fgrid_Lot_Size_Mps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Lot_Size_Mps.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Lot_Size_Mps.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Lot_Size_Mps.Name = "fgrid_Lot_Size_Mps";
            this.fgrid_Lot_Size_Mps.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fgrid_Lot_Size_Mps.Size = new System.Drawing.Size(1016, 213);
            this.fgrid_Lot_Size_Mps.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Lot_Size_Mps.Styles"));
            this.fgrid_Lot_Size_Mps.TabIndex = 181;
            this.fgrid_Lot_Size_Mps.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgrid_Lot_Size_Mps_AfterScroll);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1016, 193);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "InComming Component";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.fsp1);
            this.panel6.Location = new System.Drawing.Point(31, 25);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1016, 477);
            this.panel6.TabIndex = 182;
            // 
            // fsp1
            // 
            this.fsp1.BackColor = System.Drawing.SystemColors.Window;
            this.fsp1.ColumnInfo = "7,1,0,0,0,95,Columns:";
            this.fsp1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fsp1.Location = new System.Drawing.Point(63, 56);
            this.fsp1.Name = "fsp1";
            this.fsp1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fsp1.Size = new System.Drawing.Size(1016, 477);
            this.fsp1.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fsp1.Styles"));
            this.fsp1.TabIndex = 181;
            // 
            // txtComponent
            // 
            this.txtComponent.BackColor = System.Drawing.Color.White;
            this.txtComponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtComponent.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtComponent.Location = new System.Drawing.Point(496, 429);
            this.txtComponent.MaxLength = 100;
            this.txtComponent.Name = "txtComponent";
            this.txtComponent.Size = new System.Drawing.Size(100, 21);
            this.txtComponent.TabIndex = 596;
            this.txtComponent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtComponent_KeyUp);
            // 
            // cmbComponent
            // 
            this.cmbComponent.AccessibleDescription = "";
            this.cmbComponent.AccessibleName = "";
            this.cmbComponent.AddItemCols = 0;
            this.cmbComponent.AddItemSeparator = ';';
            this.cmbComponent.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmbComponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbComponent.Caption = "";
            this.cmbComponent.CaptionHeight = 17;
            this.cmbComponent.CaptionStyle = style137;
            this.cmbComponent.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbComponent.ColumnCaptionHeight = 18;
            this.cmbComponent.ColumnFooterHeight = 18;
            this.cmbComponent.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmbComponent.ContentHeight = 17;
            this.cmbComponent.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmbComponent.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmbComponent.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComponent.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbComponent.EditorHeight = 17;
            this.cmbComponent.EvenRowStyle = style138;
            this.cmbComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComponent.FooterStyle = style139;
            this.cmbComponent.GapHeight = 2;
            this.cmbComponent.HeadingStyle = style140;
            this.cmbComponent.HighLightRowStyle = style141;
            this.cmbComponent.ItemHeight = 15;
            this.cmbComponent.Location = new System.Drawing.Point(596, 429);
            this.cmbComponent.MatchEntryTimeout = ((long)(2000));
            this.cmbComponent.MaxDropDownItems = ((short)(5));
            this.cmbComponent.MaxLength = 32767;
            this.cmbComponent.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbComponent.Name = "cmbComponent";
            this.cmbComponent.OddRowStyle = style142;
            this.cmbComponent.PartialRightColumn = false;
            this.cmbComponent.PropBag = resources.GetString("cmbComponent.PropBag");
            this.cmbComponent.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbComponent.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbComponent.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbComponent.SelectedStyle = style143;
            this.cmbComponent.Size = new System.Drawing.Size(200, 21);
            this.cmbComponent.Style = style144;
            this.cmbComponent.TabIndex = 594;
            // 
            // label6
            // 
            this.label6.ImageIndex = 1;
            this.label6.ImageList = this.img_Label;
            this.label6.Location = new System.Drawing.Point(384, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 595;
            this.label6.Text = "Component";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_Comp_In
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1028, 701);
            this.Controls.Add(this.txtComponent);
            this.Controls.Add(this.cmbComponent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Vendor);
            this.Name = "Form_Comp_In";
            this.Text = "Form Component Incoming";
            this.Controls.SetChildIndex(this.cmb_Vendor, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cmbComponent, 0);
            this.Controls.SetChildIndex(this.txtComponent, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Lot_No)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Comp_In)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Lot_Size_Mps)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fsp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComponent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void Init_Control()
		{
			DataTable dt_ret;

			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Factor, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factor.SelectedValue = ClassLib.ComVar.This_Factory;
	
			dt_ret = Select_Vendor_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 1, true,ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Vendor.SelectedValue = " ";

            fgrid_Lot_Size_Mps.Set_Grid("SQM_LOT_SIZE_MPS", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Lot_Size_Mps.Set_Action_Image(img_Action);

			fgrid_Comp_In.Set_Grid("SQM_COMP_IN","1",1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Comp_In.Cols[G_IN_YMD].Style.Format="yyyy-MM-dd";
			fgrid_Comp_In.Set_Action_Image(img_Action);

			dt_ret = SELECT_LINE_INFO();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Line, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Line.SelectedIndex = 0;

			
		}

		public static DataTable Select_Vendor_List()
		{ 
			
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;
			
			try
			{
				string process_name = "pkg_sqm_cust.select_sqm_cust";

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

		private void txt_Style_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;

				//-------------------------------------------------------------------------
				
				cmb_Style.SelectedIndex = -1;

				//-------------------------------------------------------------------------

				DataTable dt_ret;
				
				dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_Style, " ") ); 
				 
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_Style, 0, 1, 2, 3, 4, false, 80, 200); 
 

				//				string stylecd = "";
				//				int exist_index = -1;
				//
				//				stylecd = txt_Style.Text.Trim();
				//
				//				exist_index = txt_Style.Text.IndexOf("-", 0);
				//
				//				if(exist_index == -1 && stylecd.Length == 9)
				//				{
				//					stylecd = stylecd.Substring(0, 6) + "-" + stylecd.Substring(6, 3);
				//				}
				// 
				//				cmb_Style.SelectedValue = stylecd;

				dt_ret.Dispose();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_Style_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmb_Style_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Search_Lot_No();
		}

		private void Search_Lot_No ()
		{
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;

			string process_name = "pkg_sqm_cust.select_lot_no";

			MyOraDB.ReDim_Parameter(4);  
			MyOraDB.Process_Name = process_name;
   
			MyOraDB.Parameter_Name[0] = "arg_style_cd"; 
			MyOraDB.Parameter_Name[1] = "arg_ymd"; 
			MyOraDB.Parameter_Name[2] = "arg_line_cd"; 
			MyOraDB.Parameter_Name[3] = "out_cursor"; 
			
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar ;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar ;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor; 

			MyOraDB.Parameter_Values[0] = Convert.ToString(cmb_Style.SelectedValue).Replace("-","") ;
			MyOraDB.Parameter_Values[1] = dpick_YMD.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[2] = Convert.ToString(cmb_Line.SelectedValue);
			MyOraDB.Parameter_Values[3] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();
			
			DataTable a= ds_ret.Tables[0];
			COM.ComCtl.Set_ComboList(a,cmb_Lot_No,0,1,false,false,false);
			cmb_Lot_No.SelectedIndex=0;
		}
		private void Check_vendor()
		{
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;

			string process_name = "pkg_sqm_cust.select_check_exist_vendor";

			MyOraDB.ReDim_Parameter(3);  
			MyOraDB.Process_Name = process_name;
   
			MyOraDB.Parameter_Name[0] = "arg_style_cd";
			MyOraDB.Parameter_Name[1] = "arg_lot_no";
			MyOraDB.Parameter_Name[2] = "out_cursor"; 
			
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar ;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar ;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor; 

			MyOraDB.Parameter_Values[0] = Convert.ToString(cmb_Style.SelectedValue);
			MyOraDB.Parameter_Values[1] = Convert.ToString(cmb_Lot_No.SelectedValue);
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();
			if(Convert.ToString(ds_ret.Tables[0].Rows[0][0])!="")
			{
				cmb_Vendor.SelectedValue=Convert.ToString(ds_ret.Tables[0].Rows[0][0]);
				//cmb_Vendor.DisplayMember=Convert.ToString(ds_ret.Tables[0].Rows[0][0]);
			}
			else
			{
				cmb_Vendor.SelectedValue= " ";
			}
			ds_ret.Dispose();
		}
		private void dpick_FromYMD_ValueChanged(object sender, System.EventArgs e)
		{
			Search_Lot_No ();
		}

		private void dpick_ToYMD_ValueChanged(object sender, System.EventArgs e)
		{
			Search_Lot_No ();
		}

		private void cmb_Lot_No_Change(object sender, System.EventArgs e)
		{
			Check_vendor();
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			
            if (Convert.ToString(cmb_Vendor.SelectedValue) != " " && Convert.ToString(cmb_Lot_No.SelectedValue) != "" && Convert.ToString(cmb_Style.SelectedValue) != "" && Convert.ToString(cmbComponent.SelectedValue) != "")
			{
                if (fgrid_Comp_In.Rows.Count > 2)
                {
                    fgrid_Comp_In.Add_Row(fgrid_Comp_In.Rows.Count - 2);
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 2][G_IN_YMD] = DateTime.Now.ToString("yyyy-MM-dd");
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 2][G_VENDOR_CD] = cmb_Vendor.SelectedValue;
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 2][G_LOT_NO] = cmb_Lot_No.SelectedValue;
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 2][G_STYLE_CD] = cmb_Style.SelectedValue;
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 2][G_LINE_CD] = cmb_Line.SelectedValue;
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 2][G_COMP_CD] = cmbComponent.SelectedValue;
                }
                else
                {
                    fgrid_Comp_In.Add_Row(fgrid_Comp_In.Rows.Count - 1);
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_IN_YMD] = DateTime.Now.ToString("yyyy-MM-dd");
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_VENDOR_CD] = cmb_Vendor.SelectedValue;
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_LOT_NO] = cmb_Lot_No.SelectedValue;
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_STYLE_CD] = cmb_Style.SelectedValue;
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_LINE_CD] = cmb_Line.SelectedValue;
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_COMP_CD] = cmbComponent.SelectedValue;
                }
				
			}
			else
			{
				MessageBox.Show("Please Select Condition To Add New");
			}
		}
        private void Clear_FlexGrid()
        {
            if (fgrid_Lot_Size_Mps.Rows.Fixed != fgrid_Lot_Size_Mps.Rows.Count)
            {
                fgrid_Lot_Size_Mps.Clear(ClearFlags.UserData, fgrid_Lot_Size_Mps.Rows.Fixed, 1, fgrid_Lot_Size_Mps.Rows.Count - 1, fgrid_Lot_Size_Mps.Cols.Count - 1);

                fgrid_Lot_Size_Mps.Rows.Count = fgrid_Lot_Size_Mps.Rows.Fixed;

            }
        }

		private void Clear_FlexGrid1()
		{
			if (fgrid_Comp_In.Rows.Fixed != fgrid_Comp_In.Rows.Count)
			{				
				fgrid_Comp_In.Clear(ClearFlags.UserData, fgrid_Comp_In.Rows.Fixed, 1, fgrid_Comp_In.Rows.Count - 1, fgrid_Comp_In.Cols.Count - 1);

				fgrid_Comp_In.Rows.Count = fgrid_Comp_In.Rows.Fixed;
					
			}
		}

        private void Display_FlexGrid(DataTable arg_dt)
        {
            int iCount = arg_dt.Rows.Count;

            for (int iRow = 0; iRow < iCount; iRow++)
            {
                C1.Win.C1FlexGrid.Node newRow = fgrid_Lot_Size_Mps.Rows.InsertNode(fgrid_Lot_Size_Mps.Rows.Fixed + iRow, 1);
                fgrid_Lot_Size_Mps[newRow.Row.Index, 0] = "";

                for (int iCol = 1; iCol <= arg_dt.Columns.Count; iCol++)
                {
                    fgrid_Lot_Size_Mps[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol - 1];
                }
            }
        }

		private void Display_FlexGrid1(DataTable arg_dt)
		{
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                string p_vendor_cd = Convert.ToString(arg_dt.Rows[i][0]);
                string p_style_cd = Convert.ToString(arg_dt.Rows[i][1]);
                string p_lot_no = Convert.ToString(arg_dt.Rows[i][2]);
                string p_out_ymd = Convert.ToString(arg_dt.Rows[i][3]);
                string p_size_nm = Convert.ToString(arg_dt.Rows[i][4]);
                string p_line_cd = Convert.ToString(arg_dt.Rows[i][6]);
                string p_comp_cd = Convert.ToString(arg_dt.Rows[i][7]);
                int p_qty = Convert.ToInt32(arg_dt.Rows[i][5]);
                for (int j = fgrid_Comp_In.Rows.Fixed; j < fgrid_Comp_In.Rows.Count; j++)
                {
                    for (int z = 5; z < fgrid_Comp_In.Cols.Count - 3; z++)
                    {
                        string f_vendor_cd = Convert.ToString(fgrid_Comp_In.Rows[j][G_VENDOR_CD]);
                        string f_style_cd = Convert.ToString(fgrid_Comp_In.Rows[j][G_STYLE_CD]);
                        string f_lot_no = Convert.ToString(fgrid_Comp_In.Rows[j][G_LOT_NO]);
                        string f_out_ymd = Convert.ToString(fgrid_Comp_In.Rows[j][G_IN_YMD]).Substring(0, 10);
                        string f_size_nm = Convert.ToString(fgrid_Comp_In.Rows[1][z]);
                        string f_line_cd = Convert.ToString(fgrid_Comp_In.Rows[j][G_LINE_CD]);
                        string f_comp_cd = Convert.ToString(fgrid_Comp_In.Rows[j][G_COMP_CD]);
                        if (f_vendor_cd == p_vendor_cd && f_style_cd == p_style_cd && f_lot_no == p_lot_no && f_out_ymd == p_out_ymd
                            && f_size_nm == p_size_nm && f_line_cd == p_line_cd && f_comp_cd == p_comp_cd)
                        {
                            fgrid_Comp_In.Rows[j][z] = p_qty;
                        }
                    }

                }
            }
	
		}

        private DataTable SearchData(string p_factory, string p_lot_no, string p_lot_seq)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "pkg_sqm_cust.select_mps_lot_daily_size";

                MyOraDB.ReDim_Parameter(4);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_lot_no";
                MyOraDB.Parameter_Name[2] = "arg_lot_seq";
                MyOraDB.Parameter_Name[3] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = p_factory;
                MyOraDB.Parameter_Values[1] = p_lot_no;
                MyOraDB.Parameter_Values[2] = p_lot_seq;
                MyOraDB.Parameter_Values[3] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }

        private DataTable SearchData1(string p_style_cd, string p_vendor_cd, string p_lot_no, string p_comp_cd, string p_factory)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "pkg_sqm_cust.select_incomming_daily_size";

                MyOraDB.ReDim_Parameter(6);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_style_cd";
                MyOraDB.Parameter_Name[2] = "arg_vendor_cd";
                MyOraDB.Parameter_Name[3] = "arg_lot_no";
                MyOraDB.Parameter_Name[4] = "arg_comp_cd";
                MyOraDB.Parameter_Name[5] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = p_factory;
                MyOraDB.Parameter_Values[1] = p_style_cd;
                MyOraDB.Parameter_Values[2] = p_vendor_cd;
                MyOraDB.Parameter_Values[3] = p_lot_no;
                MyOraDB.Parameter_Values[4] = p_comp_cd;
                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }

        private void Cal_row_sum()
        {
            fgrid_Lot_Size_Mps.Rows.Add();
            fgrid_Lot_Size_Mps.Rows[fgrid_Lot_Size_Mps.Rows.Count - 1][2] = "Total";
            int total = 0;
            for (int j = 3; j < fgrid_Lot_Size_Mps.Cols.Count; j++)
            {
                total = 0;
                for (int i = 2; i < fgrid_Lot_Size_Mps.Rows.Count - 1; i++)
                {
                    total = total + Convert.ToInt32(fgrid_Lot_Size_Mps.Rows[i][j]);
                }
                if (total != 0)
                {
                    fgrid_Lot_Size_Mps.Rows[fgrid_Lot_Size_Mps.Rows.Count - 1][j] = total;
                }
            }

        }

		private void Cal_row_sum1()
		{
			fgrid_Comp_In.Rows.Add();
			fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count-1][G_IN_YMD]="Total";
			int total = 0;
			for(int j=6;j<fgrid_Comp_In.Cols.Count-1;j++)
			{
				total=0;
				for(int i=2;i<fgrid_Comp_In.Rows.Count-1;i++)
				{
					total=total+Convert.ToInt32(fgrid_Comp_In.Rows[i][j]);
				}
				if(total!=0)
				{
					fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count-1][j]=total;
				}
			}
			
		}

        private void Cal_col_sum()
        {
            for (int i = fgrid_Comp_In.Rows.Fixed; i < fgrid_Comp_In.Rows.Count; i++)
            {
                int total = 0;
                for (int j = 5; j < fgrid_Comp_In.Cols.Count - 3; j++)
                {
                    total = total + Convert.ToInt32(fgrid_Comp_In.Rows[i][j]);
                }
                fgrid_Comp_In.Rows[i][G_TOTAL] = total;
            }
        }
        private void DISPLAY_IN_DAILY_HEAD(string p_style_cd, string p_vendor_cd, string p_lot_no, string p_comp_cd, string p_factory)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            string process_name = "pkg_sqm_cust.select_in_daily_size_head";

            MyOraDB.ReDim_Parameter(6);
            MyOraDB.Process_Name = process_name;

            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_style_cd";
            MyOraDB.Parameter_Name[2] = "arg_vendor_cd";
            MyOraDB.Parameter_Name[3] = "arg_lot_no";
            MyOraDB.Parameter_Name[4] = "arg_comp_cd";
            MyOraDB.Parameter_Name[5] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = p_factory;
            MyOraDB.Parameter_Values[1] = p_style_cd;
            MyOraDB.Parameter_Values[2] = p_vendor_cd;
            MyOraDB.Parameter_Values[3] = p_lot_no;
            MyOraDB.Parameter_Values[4] = p_comp_cd;
            MyOraDB.Parameter_Values[5] = "";

            MyOraDB.Add_Select_Parameter(true);
            ds_ret = MyOraDB.Exe_Select_Procedure();
            if (ds_ret != null)
            {
                DataTable dt = ds_ret.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    C1.Win.C1FlexGrid.Node newRow = fgrid_Comp_In.Rows.InsertNode(fgrid_Comp_In.Rows.Fixed + i, 1);
                    fgrid_Comp_In[newRow.Row.Index, 0] = "";
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_VENDOR_CD] = dt.Rows[i][0];
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_STYLE_CD] = dt.Rows[i][1];
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_LOT_NO] = dt.Rows[i][2];
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_IN_YMD] = dt.Rows[i][3];
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_LINE_CD] = dt.Rows[i][4];
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_COMP_CD] = dt.Rows[i][5];
                }
            }
        }
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;
                Clear_FlexGrid();
				Clear_FlexGrid1();
                if (Convert.ToString(cmb_Lot_No.SelectedValue) != "" || Convert.ToString(cmbComponent.SelectedValue) != "")
				{
                    Display_FlexGrid(SearchData(Convert.ToString(cmb_Factor.SelectedValue), Convert.ToString(cmb_Lot_No.SelectedValue).Substring(0, 9), Convert.ToString(cmb_Lot_No.SelectedValue).Substring(10, 2)));
                    Cal_row_sum();
                    fgrid_Lot_Size_Mps.Rows[fgrid_Lot_Size_Mps.Rows.Count - 1].StyleNew.BackColor = Color.LightGray;
                    fgrid_Lot_Size_Mps.Cols[fgrid_Lot_Size_Mps.Cols.Count - 1].StyleNew.BackColor = Color.LightGray;

                    DISPLAY_IN_DAILY_HEAD(Convert.ToString(cmb_Style.SelectedValue), Convert.ToString(cmb_Vendor.SelectedValue), Convert.ToString(cmb_Lot_No.SelectedValue), Convert.ToString(cmbComponent.SelectedValue), Convert.ToString(cmb_Factor.SelectedValue));
                    Display_FlexGrid1(SearchData1(Convert.ToString(cmb_Style.SelectedValue), Convert.ToString(cmb_Vendor.SelectedValue), Convert.ToString(cmb_Lot_No.SelectedValue), Convert.ToString(cmbComponent.SelectedValue), Convert.ToString(cmb_Factor.SelectedValue)));
                    Cal_row_sum1();
                    Cal_col_sum();
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count-1].StyleNew.BackColor=Color.LightGray;
                    fgrid_Comp_In.Cols[fgrid_Comp_In.Cols.Count-3].StyleNew.BackColor=Color.LightGray;
				}
				else
				{
					MessageBox.Show("Please Select Condition to Search");
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SearchData", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;

			}
		}
		

		private bool Savedata(bool doExecute)
		{
            try
            {
                COM.OraDB oraDB = new COM.OraDB();
                int para_ct = 0;
                int iCount = 11;
                oraDB.ReDim_Parameter(iCount);

                //01.PROCEDURE NAME
                oraDB.Process_Name = "pkg_sqm_cust.sp_ins_incomming_daily";

                //02.ARGURMENT OF PROC
                oraDB.Parameter_Name[0] = "arg_division";
                oraDB.Parameter_Name[1] = "arg_vendor_cd";
                oraDB.Parameter_Name[2] = "arg_style_cd";
                oraDB.Parameter_Name[3] = "arg_lot_no";
                oraDB.Parameter_Name[4] = "arg_in_ymd";
                oraDB.Parameter_Name[5] = "arg_size_nm";
                oraDB.Parameter_Name[6] = "arg_qty";
                oraDB.Parameter_Name[7] = "arg_line_cd";
                oraDB.Parameter_Name[8] = "arg_comp_cd";
                oraDB.Parameter_Name[9] = "arg_user_upd";
                oraDB.Parameter_Name[10] = "arg_factory";

                for (int iCol = 0; iCol < iCount; iCol++)
                {
                    oraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
                }
                oraDB.Parameter_Type[7] = (int)OracleType.Number;

                ArrayList temp = new ArrayList();

                //oraDB.Parameter_Values  = new string[iCount * (fgrid_Comp_Out.Rows.Count - fgrid_Comp_Out.Rows.Fixed)*40 ];

                for (int iRow = fgrid_Comp_In.Rows.Fixed; iRow < fgrid_Comp_In.Rows.Count; iRow++)
                {
                    if (fgrid_Comp_In.Rows[iRow][0] == null)
                    {
                        continue;
                    }
                    for (int iCol = 5; iCol < fgrid_Comp_In.Cols.Count - 3; iCol++)
                    {
                        temp.Add(Convert.ToString(fgrid_Comp_In[iRow, 0]));
                        temp.Add(Convert.ToString(fgrid_Comp_In[iRow, G_VENDOR_CD]));
                        temp.Add(Convert.ToString(fgrid_Comp_In[iRow, G_STYLE_CD]));
                        temp.Add(Convert.ToString(fgrid_Comp_In[iRow, G_LOT_NO]));
                        temp.Add(Convert.ToString(fgrid_Comp_In[iRow, G_IN_YMD]).Replace("-", "").Substring(0, 8));
                        temp.Add(Convert.ToString(fgrid_Comp_In[1, iCol]));
                        temp.Add(Convert.ToInt32(fgrid_Comp_In[iRow, iCol]));
                        temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_LINE_CD]));
                        temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_COMP_CD]));
                        temp.Add(COM.ComVar.This_User);
                        temp.Add(Convert.ToString(cmb_Factor.SelectedValue));
                    }
                }
                oraDB.Parameter_Values = new string[temp.Count];
                for (int j = 0; j < temp.Count; j++)
                {
                    oraDB.Parameter_Values[j] = temp[j].ToString();
                }
                oraDB.Add_Modify_Parameter(true);

                if (doExecute)
                {
                    if (oraDB.Exe_Modify_Procedure() == null)
                        return false;
                    else
                        return true;
                }

                return true;

            }
            catch (System.Exception ex)
            {
                return false;
            }
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(Savedata(true))
			{
				tbtn_Search_Click(tbtn_Search,null);
				ClassLib.ComFunction.User_Message("Upload Data Sucess!","Infomation",MessageBoxButtons.OK ,MessageBoxIcon.Information);
			}
		}

		private void fgrid_Comp_In_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_Comp_In.Update_Row(e.Row);
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				for (int i = fgrid_Comp_In.Selections.Length-1 ; i>=0; i--)
				{
                    if (Convert.ToString(fgrid_Comp_In.Rows[fgrid_Comp_In.Selections[i]][0]) != "I")
					{
						//MessageBox.Show(Convert.ToString(fgrid_Item_Price.Rows[fgrid_Item_Price.Selections[i]][G_SEQ]));
						fgrid_Comp_In.Delete_Row(fgrid_Comp_In.Selections[i]);
					}
					else
					{
						fgrid_Comp_In.Rows.Remove(fgrid_Comp_In.Selections[i]);
					}
				}
			}
			catch (System.Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message,"tbtn_Delete_Click", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
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

		private void txt_Style_KeyUp_1(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;

				//-------------------------------------------------------------------------
				
				cmb_Style.SelectedIndex = -1;

				//-------------------------------------------------------------------------

				DataTable dt_ret;
				
				dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_Style, " ") ); 
				 
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_Style, 0, 1, 2, 3, 4, false, 80, 200); 
 

				//				string stylecd = "";
				//				int exist_index = -1;
				//
				//				stylecd = txt_Style.Text.Trim();
				//
				//				exist_index = txt_Style.Text.IndexOf("-", 0);
				//
				//				if(exist_index == -1 && stylecd.Length == 9)
				//				{
				//					stylecd = stylecd.Substring(0, 6) + "-" + stylecd.Substring(6, 3);
				//				}
				// 
				//				cmb_Style.SelectedValue = stylecd;

				dt_ret.Dispose();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_Style_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmb_Style_SelectedValueChanged_1(object sender, System.EventArgs e)
		{
			Search_Lot_No();
		}

		private void cmb_Line_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Search_Lot_No ();
		}

		private void dpick_YMD_ValueChanged(object sender, System.EventArgs e)
		{
			Search_Lot_No ();
		}
		
		private void cmb_Lot_No_Change_1(object sender, System.EventArgs e)
		{
			Check_vendor();
		}

        private void txtComponent_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter) return;
                DataTable dt_ret = Search_Component();
                COM.ComCtl.Set_ComboList(dt_ret, cmbComponent, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
                dt_ret.Dispose();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "txt_Component_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable Search_Component()
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                DataSet ds_ret;

                string process_name = "pkg_sqm_cust.select_component";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_style_cd";
                MyOraDB.Parameter_Name[1] = "arg_comp_nm";
                MyOraDB.Parameter_Name[2] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = Convert.ToString(cmb_Style.SelectedValue);
                MyOraDB.Parameter_Values[1] = Convert.ToString(txtComponent.Text);
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                DataTable a = ds_ret.Tables[0];
                return a;
            }
            catch
            {
                return null;
            }
        }

        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            string p_factory = Convert.ToString(cmb_Factor.SelectedValue);
            string p_style_cd = Convert.ToString(cmb_Style.SelectedValue);
            string p_vendor_cd = Convert.ToString(cmb_Vendor.SelectedValue);
            string p_lot_no = Convert.ToString(cmb_Lot_No.SelectedValue);
            string p_comp_cd = Convert.ToString(cmbComponent.SelectedValue);

            string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_MPS_Comp_In");
            string Para = " ";


            int iCnt = 6;
            string[] aHead = new string[iCnt];

            aHead[0] = p_factory;
            aHead[1] = p_style_cd;
            aHead[2] = p_vendor_cd;
            aHead[3] = p_lot_no;
            aHead[4] = p_comp_cd;
            aHead[5] = "";
            Para = " /rp ";
            for (int i = 1; i <= iCnt; i++)
            {
                Para = Para + "[" + aHead[i - 1] + "] ";
            }
            FlexSQM.Report.Form_RdViewer report = new FlexSQM.Report.Form_RdViewer(mrd_Filename, Para);
            //FlexTraining.Report.Form_RdViewer report = new FlexTraining.Report.Form_RdViewer(mrd_Filename, Para);

            report.Show();
        }

        private void fgrid_Lot_Size_Mps_AfterScroll(object sender, RangeEventArgs e)
        {
            fgrid_Comp_In.ScrollPosition = new Point(fgrid_Lot_Size_Mps.ScrollPosition.X, fgrid_Comp_In.ScrollPosition.Y);
        }

        private void fgrid_Comp_In_AfterScroll(object sender, RangeEventArgs e)
        {
            fgrid_Lot_Size_Mps.ScrollPosition = new Point(fgrid_Comp_In.ScrollPosition.X, fgrid_Lot_Size_Mps.ScrollPosition.Y);
        }
	}
}
