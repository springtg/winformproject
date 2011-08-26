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
	/// Summary description for Form_In_Out_Seq.
	/// </summary>
	public class Form_In_Out_Seq : COM.SQMWinForm.Form_Top
	{
		private System.Windows.Forms.Panel panel2;
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
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Panel panel7;
		private COM.FSP fgrid_Seq_Out;
		private COM.FSP fgrid_Seq_In;
		private System.Windows.Forms.Label label4;
        private C1.Win.C1List.C1Combo cmb_Line;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_PlanYMD;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1List.C1Combo cmb_Vendor;
		private C1.Win.C1List.C1Combo cmb_Style;
		private System.Windows.Forms.TextBox txt_Style;
		private System.Windows.Forms.Label label5;
		public C1.Win.C1List.C1Combo cmb_Factory;
        private TextBox txtComponent;
        private C1.Win.C1List.C1Combo cmbComponent;
        private Label label6;
        private Label label7;
        private C1.Win.C1List.C1Combo cmb_obsid_fr;
        private TextBox txtPlan_Date;
        private TextBox txt_Lot_No;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form_In_Out_Seq()
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
		private const int G_YMD				= 1;
		private const int G_YMD_MS			= 2;
		private const int G_SIZE_1			= 3;
		private const int G_SIZE_2			= 4;
		private const int G_SIZE_3			= 5;
		private const int G_SIZE_4			= 6;
		private const int G_SIZE_5			= 7;
		private const int G_SIZE_6			= 8;
		private const int G_SIZE_7			= 9;
		private const int G_SIZE_8			= 10;
		private const int G_SIZE_9			= 11;
		private const int G_SIZE_10			= 12;
		private const int G_SIZE_11			= 13;
		private const int G_SIZE_12			= 14;
		private const int G_SIZE_13			= 15;
		private const int G_SIZE_14			= 16;
		private const int G_SIZE_15			= 17;
		private const int G_SIZE_16			= 18;
		private const int G_SIZE_17			= 19;
		private const int G_SIZE_18			= 20;
		private const int G_SIZE_19			= 21;
		private const int G_SIZE_20			= 22;
		private const int G_SIZE_21			= 23;
		private const int G_SIZE_22			= 24;
		private const int G_SIZE_23			= 25;
		private const int G_SIZE_24			= 26;
		private const int G_SIZE_25			= 27;
		private const int G_SIZE_26			= 28;
		private const int G_SIZE_27			= 29;
		private const int G_SIZE_28			= 30;
		private const int G_SIZE_29			= 31;
		private const int G_SIZE_30			= 32;
		private const int G_SIZE_31			= 33;
		private const int G_SIZE_32			= 34;
		private const int G_SIZE_33			= 35;
		private const int G_SIZE_34			= 36;
		private const int G_SIZE_35			= 37;
		private const int G_SIZE_36			= 38;
		private const int G_SIZE_37			= 39;
		private const int G_SIZE_38			= 40;
		private const int G_SIZE_39			= 41;
		private const int G_SIZE_40			= 42;
		private const int G_TOTAL			= 43;
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_In_Out_Seq));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style17 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style18 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style19 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style20 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style21 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style22 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style23 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style24 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style25 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style26 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style27 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style28 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style29 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style30 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style31 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style32 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style33 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style34 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style35 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style36 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style37 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style38 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style39 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style40 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style41 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style42 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style43 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style44 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style45 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style46 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style47 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style48 = new C1.Win.C1List.Style();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.txt_Lot_No = new System.Windows.Forms.TextBox();
            this.txtPlan_Date = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_obsid_fr = new C1.Win.C1List.C1Combo();
            this.txtComponent = new System.Windows.Forms.TextBox();
            this.cmbComponent = new C1.Win.C1List.C1Combo();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Vendor = new C1.Win.C1List.C1Combo();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Line = new C1.Win.C1List.C1Combo();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PlanYMD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Style = new C1.Win.C1List.C1Combo();
            this.txt_Style = new System.Windows.Forms.TextBox();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.fgrid_Seq_In = new COM.FSP();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.fgrid_Seq_Out = new COM.FSP();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsid_fr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Seq_In)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Seq_Out)).BeginInit();
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
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 674);
            this.stbar.Size = new System.Drawing.Size(1028, 22);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(914, 23);
            this.lbl_MainTitle.Text = "In Out Component Sequence";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.pnl_SearchImage);
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 100);
            this.panel2.TabIndex = 29;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.txt_Lot_No);
            this.pnl_SearchImage.Controls.Add(this.txtPlan_Date);
            this.pnl_SearchImage.Controls.Add(this.label7);
            this.pnl_SearchImage.Controls.Add(this.cmb_obsid_fr);
            this.pnl_SearchImage.Controls.Add(this.txtComponent);
            this.pnl_SearchImage.Controls.Add(this.cmbComponent);
            this.pnl_SearchImage.Controls.Add(this.label6);
            this.pnl_SearchImage.Controls.Add(this.cmb_Vendor);
            this.pnl_SearchImage.Controls.Add(this.label2);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.label4);
            this.pnl_SearchImage.Controls.Add(this.cmb_Line);
            this.pnl_SearchImage.Controls.Add(this.label1);
            this.pnl_SearchImage.Controls.Add(this.lbl_PlanYMD);
            this.pnl_SearchImage.Controls.Add(this.label3);
            this.pnl_SearchImage.Controls.Add(this.cmb_Style);
            this.pnl_SearchImage.Controls.Add(this.txt_Style);
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
            this.pnl_SearchImage.Size = new System.Drawing.Size(1040, 100);
            this.pnl_SearchImage.TabIndex = 30;
            // 
            // txt_Lot_No
            // 
            this.txt_Lot_No.BackColor = System.Drawing.Color.White;
            this.txt_Lot_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Lot_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Lot_No.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Lot_No.Location = new System.Drawing.Point(795, 3);
            this.txt_Lot_No.MaxLength = 100;
            this.txt_Lot_No.Name = "txt_Lot_No";
            this.txt_Lot_No.Size = new System.Drawing.Size(100, 21);
            this.txt_Lot_No.TabIndex = 618;
            this.txt_Lot_No.Visible = false;
            // 
            // txtPlan_Date
            // 
            this.txtPlan_Date.BackColor = System.Drawing.Color.White;
            this.txtPlan_Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlan_Date.Enabled = false;
            this.txtPlan_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlan_Date.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtPlan_Date.Location = new System.Drawing.Point(729, 33);
            this.txtPlan_Date.MaxLength = 100;
            this.txtPlan_Date.Name = "txtPlan_Date";
            this.txtPlan_Date.Size = new System.Drawing.Size(80, 21);
            this.txtPlan_Date.TabIndex = 617;
            // 
            // label7
            // 
            this.label7.ImageIndex = 1;
            this.label7.ImageList = this.img_Label;
            this.label7.Location = new System.Drawing.Point(3, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 616;
            this.label7.Text = "DPO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_obsid_fr
            // 
            this.cmb_obsid_fr.AddItemCols = 0;
            this.cmb_obsid_fr.AddItemSeparator = ';';
            this.cmb_obsid_fr.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_obsid_fr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_obsid_fr.Caption = "";
            this.cmb_obsid_fr.CaptionHeight = 17;
            this.cmb_obsid_fr.CaptionStyle = style1;
            this.cmb_obsid_fr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_obsid_fr.ColumnCaptionHeight = 18;
            this.cmb_obsid_fr.ColumnFooterHeight = 18;
            this.cmb_obsid_fr.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_obsid_fr.ContentHeight = 16;
            this.cmb_obsid_fr.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_obsid_fr.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_obsid_fr.EditorFont = new System.Drawing.Font("Gulim", 9F);
            this.cmb_obsid_fr.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_obsid_fr.EditorHeight = 16;
            this.cmb_obsid_fr.EvenRowStyle = style2;
            this.cmb_obsid_fr.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_obsid_fr.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_obsid_fr.FooterStyle = style3;
            this.cmb_obsid_fr.GapHeight = 2;
            this.cmb_obsid_fr.HeadingStyle = style4;
            this.cmb_obsid_fr.HighLightRowStyle = style5;
            this.cmb_obsid_fr.ItemHeight = 15;
            this.cmb_obsid_fr.Location = new System.Drawing.Point(107, 57);
            this.cmb_obsid_fr.MatchEntryTimeout = ((long)(2000));
            this.cmb_obsid_fr.MaxDropDownItems = ((short)(5));
            this.cmb_obsid_fr.MaxLength = 32767;
            this.cmb_obsid_fr.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_obsid_fr.Name = "cmb_obsid_fr";
            this.cmb_obsid_fr.OddRowStyle = style6;
            this.cmb_obsid_fr.PartialRightColumn = false;
            this.cmb_obsid_fr.PropBag = resources.GetString("cmb_obsid_fr.PropBag");
            this.cmb_obsid_fr.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_obsid_fr.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_obsid_fr.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_obsid_fr.SelectedStyle = style7;
            this.cmb_obsid_fr.Size = new System.Drawing.Size(100, 20);
            this.cmb_obsid_fr.Style = style8;
            this.cmb_obsid_fr.TabIndex = 615;
            // 
            // txtComponent
            // 
            this.txtComponent.BackColor = System.Drawing.Color.White;
            this.txtComponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtComponent.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtComponent.Location = new System.Drawing.Point(729, 56);
            this.txtComponent.MaxLength = 100;
            this.txtComponent.Name = "txtComponent";
            this.txtComponent.Size = new System.Drawing.Size(80, 21);
            this.txtComponent.TabIndex = 614;
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
            this.cmbComponent.CaptionStyle = style9;
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
            this.cmbComponent.EvenRowStyle = style10;
            this.cmbComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComponent.FooterStyle = style11;
            this.cmbComponent.GapHeight = 2;
            this.cmbComponent.HeadingStyle = style12;
            this.cmbComponent.HighLightRowStyle = style13;
            this.cmbComponent.ItemHeight = 15;
            this.cmbComponent.Location = new System.Drawing.Point(808, 56);
            this.cmbComponent.MatchEntryTimeout = ((long)(2000));
            this.cmbComponent.MaxDropDownItems = ((short)(5));
            this.cmbComponent.MaxLength = 32767;
            this.cmbComponent.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbComponent.Name = "cmbComponent";
            this.cmbComponent.OddRowStyle = style14;
            this.cmbComponent.PartialRightColumn = false;
            this.cmbComponent.PropBag = resources.GetString("cmbComponent.PropBag");
            this.cmbComponent.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbComponent.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbComponent.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbComponent.SelectedStyle = style15;
            this.cmbComponent.Size = new System.Drawing.Size(210, 21);
            this.cmbComponent.Style = style16;
            this.cmbComponent.TabIndex = 612;
            // 
            // label6
            // 
            this.label6.ImageIndex = 1;
            this.label6.ImageList = this.img_Label;
            this.label6.Location = new System.Drawing.Point(631, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 613;
            this.label6.Text = "Component";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Vendor
            // 
            this.cmb_Vendor.AddItemCols = 0;
            this.cmb_Vendor.AddItemSeparator = ';';
            this.cmb_Vendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Vendor.Caption = "";
            this.cmb_Vendor.CaptionHeight = 17;
            this.cmb_Vendor.CaptionStyle = style17;
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
            this.cmb_Vendor.EvenRowStyle = style18;
            this.cmb_Vendor.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Vendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vendor.FooterStyle = style19;
            this.cmb_Vendor.GapHeight = 2;
            this.cmb_Vendor.HeadingStyle = style20;
            this.cmb_Vendor.HighLightRowStyle = style21;
            this.cmb_Vendor.ItemHeight = 15;
            this.cmb_Vendor.Location = new System.Drawing.Point(401, 57);
            this.cmb_Vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_Vendor.MaxDropDownItems = ((short)(5));
            this.cmb_Vendor.MaxLength = 32767;
            this.cmb_Vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Vendor.Name = "cmb_Vendor";
            this.cmb_Vendor.OddRowStyle = style22;
            this.cmb_Vendor.PartialRightColumn = false;
            this.cmb_Vendor.PropBag = resources.GetString("cmb_Vendor.PropBag");
            this.cmb_Vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.SelectedStyle = style23;
            this.cmb_Vendor.Size = new System.Drawing.Size(222, 20);
            this.cmb_Vendor.Style = style24;
            this.cmb_Vendor.TabIndex = 603;
            // 
            // label2
            // 
            this.label2.ImageIndex = 1;
            this.label2.ImageList = this.img_Label;
            this.label2.Location = new System.Drawing.Point(295, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 606;
            this.label2.Text = "Vendor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style25;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 17;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 17;
            this.cmb_Factory.EvenRowStyle = style26;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style27;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style28;
            this.cmb_Factory.HighLightRowStyle = style29;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(107, 32);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style30;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style31;
            this.cmb_Factory.Size = new System.Drawing.Size(180, 21);
            this.cmb_Factory.Style = style32;
            this.cmb_Factory.TabIndex = 183;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.ImageIndex = 1;
            this.label4.ImageList = this.img_Label;
            this.label4.Location = new System.Drawing.Point(816, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 611;
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
            this.cmb_Line.CaptionStyle = style33;
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
            this.cmb_Line.Enabled = false;
            this.cmb_Line.EvenRowStyle = style34;
            this.cmb_Line.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Line.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Line.FooterStyle = style35;
            this.cmb_Line.GapHeight = 2;
            this.cmb_Line.HeadingStyle = style36;
            this.cmb_Line.HighLightRowStyle = style37;
            this.cmb_Line.ItemHeight = 15;
            this.cmb_Line.Location = new System.Drawing.Point(900, 33);
            this.cmb_Line.MatchEntryTimeout = ((long)(2000));
            this.cmb_Line.MaxDropDownItems = ((short)(5));
            this.cmb_Line.MaxLength = 32767;
            this.cmb_Line.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Line.Name = "cmb_Line";
            this.cmb_Line.OddRowStyle = style38;
            this.cmb_Line.PartialRightColumn = false;
            this.cmb_Line.PropBag = resources.GetString("cmb_Line.PropBag");
            this.cmb_Line.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Line.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Line.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Line.SelectedStyle = style39;
            this.cmb_Line.Size = new System.Drawing.Size(118, 20);
            this.cmb_Line.Style = style40;
            this.cmb_Line.TabIndex = 610;
            this.cmb_Line.SelectedValueChanged += new System.EventHandler(this.cmb_Line_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.ImageIndex = 1;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(685, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 608;
            this.label1.Text = "LOT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Visible = false;
            // 
            // lbl_PlanYMD
            // 
            this.lbl_PlanYMD.ImageIndex = 1;
            this.lbl_PlanYMD.ImageList = this.img_Label;
            this.lbl_PlanYMD.Location = new System.Drawing.Point(631, 32);
            this.lbl_PlanYMD.Name = "lbl_PlanYMD";
            this.lbl_PlanYMD.Size = new System.Drawing.Size(90, 21);
            this.lbl_PlanYMD.TabIndex = 601;
            this.lbl_PlanYMD.Text = "Plan Date";
            this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.ImageIndex = 1;
            this.label3.ImageList = this.img_Label;
            this.label3.Location = new System.Drawing.Point(295, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 607;
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
            this.cmb_Style.CaptionStyle = style41;
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
            this.cmb_Style.EvenRowStyle = style42;
            this.cmb_Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Style.FooterStyle = style43;
            this.cmb_Style.GapHeight = 2;
            this.cmb_Style.HeadingStyle = style44;
            this.cmb_Style.HighLightRowStyle = style45;
            this.cmb_Style.ItemHeight = 15;
            this.cmb_Style.Location = new System.Drawing.Point(473, 34);
            this.cmb_Style.MatchEntryTimeout = ((long)(2000));
            this.cmb_Style.MaxDropDownItems = ((short)(5));
            this.cmb_Style.MaxLength = 32767;
            this.cmb_Style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Style.Name = "cmb_Style";
            this.cmb_Style.OddRowStyle = style46;
            this.cmb_Style.PartialRightColumn = false;
            this.cmb_Style.PropBag = resources.GetString("cmb_Style.PropBag");
            this.cmb_Style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Style.SelectedStyle = style47;
            this.cmb_Style.Size = new System.Drawing.Size(150, 21);
            this.cmb_Style.Style = style48;
            this.cmb_Style.TabIndex = 605;
            this.cmb_Style.SelectedValueChanged += new System.EventHandler(this.cmb_Style_SelectedValueChanged_1);
            // 
            // txt_Style
            // 
            this.txt_Style.BackColor = System.Drawing.Color.White;
            this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Style.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Style.Location = new System.Drawing.Point(401, 34);
            this.txt_Style.MaxLength = 100;
            this.txt_Style.Name = "txt_Style";
            this.txt_Style.Size = new System.Drawing.Size(72, 21);
            this.txt_Style.TabIndex = 604;
            this.txt_Style.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Style_KeyUp);
            // 
            // label5
            // 
            this.label5.ImageIndex = 1;
            this.label5.ImageList = this.img_Label;
            this.label5.Location = new System.Drawing.Point(3, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 599;
            this.label5.Text = "Factory";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(1023, 24);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(17, 60);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(1024, 0);
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
            this.picb_TM.Size = new System.Drawing.Size(816, 32);
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
            this.picb_BR.Location = new System.Drawing.Point(1024, 85);
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
            this.picb_BM.Location = new System.Drawing.Point(144, 84);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(880, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 85);
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
            this.picb_ML.Size = new System.Drawing.Size(168, 63);
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
            this.picb_MM.Location = new System.Drawing.Point(152, 24);
            this.picb_MM.Name = "picb_MM";
            this.picb_MM.Size = new System.Drawing.Size(872, 60);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 232);
            this.panel3.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1024, 232);
            this.panel4.TabIndex = 183;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 232);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 182;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1016, 205);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Sequence Plan - Incoming";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.fgrid_Seq_In);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1016, 205);
            this.panel5.TabIndex = 182;
            // 
            // fgrid_Seq_In
            // 
            this.fgrid_Seq_In.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Seq_In.ColumnInfo = "7,1,0,0,0,95,Columns:";
            this.fgrid_Seq_In.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Seq_In.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Seq_In.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Seq_In.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Seq_In.Name = "fgrid_Seq_In";
            this.fgrid_Seq_In.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fgrid_Seq_In.Size = new System.Drawing.Size(1016, 205);
            this.fgrid_Seq_In.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Seq_In.Styles"));
            this.fgrid_Seq_In.TabIndex = 182;
            this.fgrid_Seq_In.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgrid_Seq_In_AfterScroll);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tabControl2);
            this.panel6.Location = new System.Drawing.Point(0, 416);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1024, 240);
            this.panel6.TabIndex = 31;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1024, 240);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl2.TabIndex = 183;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1016, 213);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sequence Plan - Outgoing";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.fgrid_Seq_Out);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1016, 213);
            this.panel7.TabIndex = 182;
            // 
            // fgrid_Seq_Out
            // 
            this.fgrid_Seq_Out.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Seq_Out.ColumnInfo = "7,1,0,0,0,95,Columns:";
            this.fgrid_Seq_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Seq_Out.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Seq_Out.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Seq_Out.Name = "fgrid_Seq_Out";
            this.fgrid_Seq_Out.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fgrid_Seq_Out.Size = new System.Drawing.Size(1016, 213);
            this.fgrid_Seq_Out.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Seq_Out.Styles"));
            this.fgrid_Seq_Out.TabIndex = 182;
            this.fgrid_Seq_Out.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgrid_Seq_Out_AfterScroll);
            // 
            // Form_In_Out_Seq
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1028, 696);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form_In_Out_Seq";
            this.Text = "Form In Out Sequence";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsid_fr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Seq_In)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Seq_Out)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion



        private void setDPO()
        {
            DataTable dt_ret = Select_DP_DPO_List(cmb_Factory.SelectedValue.ToString(), "2");

            COM.ComCtl.Set_ComboList(dt_ret, cmb_obsid_fr, 0, 0, true, ClassLib.ComVar.ComboList_Visible.Name);
            cmb_obsid_fr.SelectedIndex = 0;
        }

        public DataTable Select_DP_DPO_List(string arg_factory, string arg_division)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "PKG_SBM_LLT_PLAN_TRACKING_VJ.SELECT_SBM_DP_DPO_LIST";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

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
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }

        }

        private void cmb_Factory_SelectedValueChanged(object sender, EventArgs e)
        {
            setDPO();
        }


        public DataTable Select_Style_From_DPO()
        {

            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "pkg_sqm_cust.select_sqm_style_from_dpo";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_item";
                MyOraDB.Parameter_Name[1] = "arg_dpo";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = txt_Style.Text;
                MyOraDB.Parameter_Values[1] = Convert.ToString(cmb_obsid_fr.SelectedValue);
                MyOraDB.Parameter_Values[2] = "";

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

		private void Init_Control()
		{
			DataTable dt_ret;


			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			dt_ret = Select_Vendor_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 1, true,ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Vendor.SelectedValue = " ";
			
			fgrid_Seq_In.Set_Grid("SQM_SEQ_IN","1",1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			//fgrid_Seq_In.Cols[G_YMD_MS].Style.Format="yyyy-MM-dd";
			fgrid_Seq_In.Set_Action_Image(img_Action);

			fgrid_Seq_Out.Set_Grid("SQM_SEQ_OUT","1",1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Seq_Out.Set_Action_Image(img_Action);

			dt_ret = SELECT_LINE_INFO();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Line, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Line.SelectedIndex = 0;

			for (int i= 3;i<fgrid_Seq_In.Cols.Count;i++)
			{
				fgrid_Seq_In.Cols[i].StyleNew.ForeColor=Color.Red;
				fgrid_Seq_Out.Cols[i].StyleNew.ForeColor=Color.Red;
			}
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

		

		private void cmb_Style_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Search_Lot_No();
		}
		private void Search_Lot_No ()
		{
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            string process_name = "pkg_sqm_cust.select_lot_no";

            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = process_name;

            MyOraDB.Parameter_Name[0] = "arg_style_cd";
            MyOraDB.Parameter_Name[1] = "arg_dpo";
            MyOraDB.Parameter_Name[2] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = Convert.ToString(cmb_Style.SelectedValue).Replace("-", "");
            MyOraDB.Parameter_Values[1] = Convert.ToString(cmb_obsid_fr.SelectedValue);
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            ds_ret = MyOraDB.Exe_Select_Procedure();

            DataTable a = ds_ret.Tables[0];
            if (a.Rows.Count > 0)
            {
                txt_Lot_No.Text = Convert.ToString(a.Rows[0][0]);
                cmb_Line.SelectedValue = Convert.ToString(a.Rows[0][1]);
                txtPlan_Date.Text = Convert.ToString(a.Rows[0][2]);
            }
            else
            {
                txt_Lot_No.Text = "";
                cmb_Line.SelectedValue = "";
                txtPlan_Date.Text = "";
            }
		}

		private void cmb_Lot_No_Change(object sender, System.EventArgs e)
		{
			Check_vendor();
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
			MyOraDB.Parameter_Values[1] = Convert.ToString(txt_Lot_No.Text);
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
		private void Clear_FlexGrid()
		{
			if (fgrid_Seq_In.Rows.Fixed != fgrid_Seq_In.Rows.Count)
			{				
				fgrid_Seq_In.Clear(ClearFlags.UserData, fgrid_Seq_In.Rows.Fixed, 1, fgrid_Seq_In.Rows.Count - 1, fgrid_Seq_In.Cols.Count - 1);

				fgrid_Seq_In.Rows.Count = fgrid_Seq_In.Rows.Fixed;
					
			}
		}

		private void Clear_FlexGrid1()
		{
			if (fgrid_Seq_Out.Rows.Fixed != fgrid_Seq_Out.Rows.Count)
			{				
				fgrid_Seq_Out.Clear(ClearFlags.UserData, fgrid_Seq_Out.Rows.Fixed, 1, fgrid_Seq_Out.Rows.Count - 1, fgrid_Seq_Out.Cols.Count - 1);

				fgrid_Seq_Out.Rows.Count = fgrid_Seq_Out.Rows.Fixed;
					
			}
		}
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			SearchData();
		}

		private void SearchData()
		{
			Clear_FlexGrid();
			Display_Header();
			Display_Value();
			Cal_Sum();

			Clear_FlexGrid1();
			Display_Header1();
			Display_Value1();
			Cal_Sum1();
			
		}

		private void Cal_Sum()
		{
			for(int i=fgrid_Seq_In.Rows.Fixed;i<fgrid_Seq_In.Rows.Count;i++)
			{
				int Sum_in =0;
				for(int j=3;j<fgrid_Seq_In.Cols.Count-1;j++)
				{
					Sum_in=Sum_in +Convert.ToInt32(fgrid_Seq_In.Rows[i][j]);
				}
				if(Sum_in!=0)
				{
					fgrid_Seq_In.Rows[i][G_TOTAL]=Sum_in;
				}
				
			}
			
		}

		private void Cal_Sum1()
		{
			for(int i=fgrid_Seq_Out.Rows.Fixed;i<fgrid_Seq_Out.Rows.Count;i++)
			{
				int Sum_in =0;
				for(int j=3;j<fgrid_Seq_Out.Cols.Count-1;j++)
				{
					Sum_in=Sum_in +Convert.ToInt32(fgrid_Seq_Out.Rows[i][j]);
				}
				if(Sum_in!=0)
				{
					fgrid_Seq_Out.Rows[i][G_TOTAL]=Sum_in;
				}
			}
			
		}
		private void Display_Value()
		{
			//MessageBox.Show(Convert.ToString(fgrid_Seq_In.Rows.Count - fgrid_Seq_In.Rows.Fixed));
			for (int i=fgrid_Seq_In.Rows.Fixed ; i<fgrid_Seq_In.Rows.Count;i++)
			{
                string p_plan_ymd = Convert.ToString(fgrid_Seq_In.Rows[i][G_YMD]);
                string p_style_cd = Convert.ToString(cmb_Style.SelectedValue);
                string p_vendor_cd = Convert.ToString(cmb_Vendor.SelectedValue);
                string p_lot_no = Convert.ToString(txt_Lot_No.Text).Substring(0, 9);
                string p_lot_seq = Convert.ToString(txt_Lot_No.Text).Substring(10, 2);
                string p_comp_cd = Convert.ToString(cmbComponent.SelectedValue);
                string p_dpo = Convert.ToString(cmb_obsid_fr.SelectedValue);
                DataTable dt = SELECT_SEQ_IN_OUT_VALUE(true, p_plan_ymd, p_style_cd, p_vendor_cd, p_lot_no, p_lot_seq, p_comp_cd, p_dpo);
				
				if(dt!=null)
				{
					if(dt.Rows.Count>0)
					{
						//MessageBox.Show(Convert.ToString (dt.Rows[0]["size26"]));
						for(int j=3;j<fgrid_Seq_In.Cols.Count-1;j++)
						{
							fgrid_Seq_In.Rows[i][j]=dt.Rows[0][j-3];
						}
					}
				}
			}
		}

        private void Display_Value1()
        {
            //MessageBox.Show(Convert.ToString(fgrid_Seq_In.Rows.Count - fgrid_Seq_In.Rows.Fixed));
            for (int i = fgrid_Seq_Out.Rows.Fixed; i < fgrid_Seq_Out.Rows.Count; i++)
            {
                string p_plan_ymd = Convert.ToString(fgrid_Seq_Out.Rows[i][G_YMD]);
                string p_style_cd = Convert.ToString(cmb_Style.SelectedValue);
                string p_vendor_cd = Convert.ToString(cmb_Vendor.SelectedValue);
                string p_lot_no = Convert.ToString(txt_Lot_No.Text).Substring(0, 9);
                string p_lot_seq = Convert.ToString(txt_Lot_No.Text).Substring(10, 2);
                string p_comp_cd = Convert.ToString(cmbComponent.SelectedValue);
                string p_dpo = Convert.ToString(cmb_obsid_fr.SelectedValue);
                DataTable dt = SELECT_SEQ_IN_OUT_VALUE(false, p_plan_ymd, p_style_cd, p_vendor_cd, p_lot_no, p_lot_seq, p_comp_cd, p_dpo);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        //MessageBox.Show(Convert.ToString (dt.Rows[0]["size26"]));
                        for (int j = 3; j < fgrid_Seq_Out.Cols.Count - 1; j++)
                        {
                            fgrid_Seq_Out.Rows[i][j] = dt.Rows[0][j - 3];
                        }
                    }
                }
            }
        }

		private void Display_Header()
		{
			DataTable dt = SELECT_SEQ_IN_OUT_HEAD();

			if(dt!=null)
			{
				if(dt.Rows.Count>0)
				{
					for(int i=0;i<dt.Rows.Count;i++)
					{
						fgrid_Seq_In.Rows.Add();
						int _row_index=fgrid_Seq_In.Rows.Count-1;
						fgrid_Seq_In.Rows[_row_index][G_YMD]=dt.Rows[i][0];
						fgrid_Seq_In.Rows[_row_index][G_YMD_MS]=dt.Rows[i][1];
					}
				}
			}
		}

		private void Display_Header1()
		{
			DataTable dt = SELECT_SEQ_IN_OUT_HEAD();

			if(dt!=null)
			{
				if(dt.Rows.Count>0)
				{
					for(int i=0;i<dt.Rows.Count;i++)
					{
						fgrid_Seq_Out.Rows.Add();
						int _row_index=fgrid_Seq_Out.Rows.Count-1;
						fgrid_Seq_Out.Rows[_row_index][G_YMD]=dt.Rows[i][0];
						fgrid_Seq_Out.Rows[_row_index][G_YMD_MS]=dt.Rows[i][1];
					}
				}
			}
		}
		private DataTable SELECT_SEQ_IN_OUT_HEAD()
		{
			try
			{
				COM.OraDB MyOraDB = new COM.OraDB(); 
				DataSet ds_ret;

				string process_name = "pkg_sqm_cust.sp_sel_seq_header";

				MyOraDB.ReDim_Parameter(3);  
				MyOraDB.Process_Name = process_name;
   
				MyOraDB.Parameter_Name[0] = "arg_lot_no";
				MyOraDB.Parameter_Name[1] = "arg_lot_seq";
				MyOraDB.Parameter_Name[2] = "out_cursor"; 
			
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar ;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar ;
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = Convert.ToString(txt_Lot_No.Text).Substring(0,9);
				MyOraDB.Parameter_Values[1] = Convert.ToString(txt_Lot_No.Text).Substring(10,2);
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();
				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
				ds_ret.Dispose();
			}
			catch
			{
				return null;
			}
		}


		private DataTable SELECT_SEQ_IN_OUT_VALUE(bool inout ,string p_plan_ymd,string p_style_cd,string p_vendor_code,string p_lot_no,string p_lot_seq, string p_comp_cd,string p_dpo)
		{
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                DataSet ds_ret;
                string process_name = "";
                if (inout == true)
                {
                    process_name = "pkg_sqm_cust.sp_sel_seq_in_value";
                }
                else
                {
                    process_name = "pkg_sqm_cust.sp_sel_seq_out_value";
                }

                MyOraDB.ReDim_Parameter(8);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_plan_ymd";
                MyOraDB.Parameter_Name[1] = "arg_style_cd";
                MyOraDB.Parameter_Name[2] = "arg_vendor_cd";
                MyOraDB.Parameter_Name[3] = "arg_lot_no";
                MyOraDB.Parameter_Name[4] = "arg_lot_seq";
                MyOraDB.Parameter_Name[5] = "arg_comp_cd";
                MyOraDB.Parameter_Name[6] = "arg_dpo";
                MyOraDB.Parameter_Name[7] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = p_plan_ymd;
                MyOraDB.Parameter_Values[1] = p_style_cd;
                MyOraDB.Parameter_Values[2] = p_vendor_code;
                MyOraDB.Parameter_Values[3] = p_lot_no;
                MyOraDB.Parameter_Values[4] = p_lot_seq;
                MyOraDB.Parameter_Values[5] = p_comp_cd;
                MyOraDB.Parameter_Values[6] = p_dpo;
                MyOraDB.Parameter_Values[7] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();
                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
                ds_ret.Dispose();
            }
            catch
            {
                return null;
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

		private void cmb_Style_SelectedValueChanged_1(object sender, System.EventArgs e)
		{
            if (Convert.ToString(cmb_Style.SelectedValue) != "")
            {
                txt_Style.Text = Convert.ToString(cmb_Style.SelectedValue);
            }
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
            Pop_Print_In_Out_Ticket f = new Pop_Print_In_Out_Ticket();
            f.ShowDialog();
        }

        private void fgrid_Seq_In_AfterScroll(object sender, RangeEventArgs e)
        {
            fgrid_Seq_Out.ScrollPosition = new Point(fgrid_Seq_In.ScrollPosition.X,fgrid_Seq_Out.ScrollPosition.Y);
        }

        private void fgrid_Seq_Out_AfterScroll(object sender, RangeEventArgs e)
        {
            fgrid_Seq_In.ScrollPosition = new Point(fgrid_Seq_Out.ScrollPosition.X, fgrid_Seq_In.ScrollPosition.Y);
        }

        private void txt_Style_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter) return;

                DataTable dt_ret;
                dt_ret = Select_Style_From_DPO();

                ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_Style, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
                dt_ret.Dispose();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "txt_Style_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
	}
}
