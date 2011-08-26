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
	/// Summary description for Form_Vendor_Seq_Control.
	/// </summary>
	/// 


	public class Form_Vendor_Seq_Control : COM.SQMWinForm.Form_Top
	{
		
		private System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.DateTimePicker dpick_YMD;
		private System.Windows.Forms.Label lbl_PlanYMD;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1List.C1Combo cmb_Vendor;
		public C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.Label label3;
		private C1.Win.C1List.C1Combo cmb_Style;
		private System.Windows.Forms.TextBox txt_Style;
		private System.Windows.Forms.Label label4;
		private C1.Win.C1List.C1Combo cmb_Line;
		private CustomMergeFlex fgrid_Vendor_Control;
        private TextBox txtComponent;
        private C1.Win.C1List.C1Combo cmbComponent;
        private Label label6;
        private Panel panel3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form_Vendor_Seq_Control()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			Init_Control();
			SELECT_IN_OUT_SEQ_HEAD();
			Cal_Sum();

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
		private const int G_VENDOR_NAME		= 2;
		private const int G_LINE_CD			= 3;
		private const int G_LINE_NAME		= 4;
		private const int G_STYLE_NAME		= 5;
		private const int G_STYLE_CD		= 6;
		private const int G_COMP			= 7;
		private const int G_TASK			= 8;
		private const int G_IN_OUT			= 9;
		private const int G_LOT_NO			= 10;
        private const int G_COMP_CD         = 11;
        private const int G_DPO             = 12;
        private const int G_COL_1           = 13;
        private const int G_COL_2           = 14;
        private const int G_COL_3           = 15;
        private const int G_COL_4           = 16;
        private const int G_COL_5           = 17;
        private const int G_COL_6           = 18;
        private const int G_COL_7           = 19;
        private const int G_COL_8           = 20;
        private const int G_COL_9           = 21;
        private const int G_COL_10          = 22;
        private const int G_COL_11          = 23;
        private const int G_COL_12          = 24;
        private const int G_COL_13          = 25;
        private const int G_COL_14          = 26;
        private const int G_COL_15          = 27;
        private const int G_COL_16          = 28;
        private const int G_COL_17          = 29;



        private COM.OraDB MyOraDB = new COM.OraDB();
		
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Vendor_Seq_Control));
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.txtComponent = new System.Windows.Forms.TextBox();
            this.cmbComponent = new C1.Win.C1List.C1Combo();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Line = new C1.Win.C1List.C1Combo();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Style = new C1.Win.C1List.C1Combo();
            this.txt_Style = new System.Windows.Forms.TextBox();
            this.dpick_YMD = new System.Windows.Forms.DateTimePicker();
            this.lbl_PlanYMD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Vendor = new C1.Win.C1List.C1Combo();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_Factory = new System.Windows.Forms.Label();
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
            this.fgrid_Vendor_Control = new FlexSQM.CustomMergeFlex();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Vendor_Control)).BeginInit();
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
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4,
            this.c1CommandLink5,
            this.c1CommandLink6,
            this.c1CommandLink7});
            this.c1ToolBar1.Location = new System.Drawing.Point(742, 4);
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.tbtn_New);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Search);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Save);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Append);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Insert);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Delete);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Create);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Color);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Print);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Confirm);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 679);
            this.stbar.Size = new System.Drawing.Size(1028, 22);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(950, 23);
            this.lbl_MainTitle.Text = "Vendor Sequence Control";
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
            // tbtn_Confirm
            // 
            this.tbtn_Confirm.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Confirm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnl_SearchImage);
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 112);
            this.panel2.TabIndex = 29;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.txtComponent);
            this.pnl_SearchImage.Controls.Add(this.cmbComponent);
            this.pnl_SearchImage.Controls.Add(this.label6);
            this.pnl_SearchImage.Controls.Add(this.label4);
            this.pnl_SearchImage.Controls.Add(this.cmb_Line);
            this.pnl_SearchImage.Controls.Add(this.label3);
            this.pnl_SearchImage.Controls.Add(this.cmb_Style);
            this.pnl_SearchImage.Controls.Add(this.txt_Style);
            this.pnl_SearchImage.Controls.Add(this.dpick_YMD);
            this.pnl_SearchImage.Controls.Add(this.lbl_PlanYMD);
            this.pnl_SearchImage.Controls.Add(this.label2);
            this.pnl_SearchImage.Controls.Add(this.cmb_Vendor);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
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
            this.pnl_SearchImage.Size = new System.Drawing.Size(1032, 112);
            this.pnl_SearchImage.TabIndex = 19;
            // 
            // txtComponent
            // 
            this.txtComponent.BackColor = System.Drawing.Color.White;
            this.txtComponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtComponent.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtComponent.Location = new System.Drawing.Point(457, 65);
            this.txtComponent.MaxLength = 100;
            this.txtComponent.Name = "txtComponent";
            this.txtComponent.Size = new System.Drawing.Size(100, 21);
            this.txtComponent.TabIndex = 603;
            this.txtComponent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtComponent_KeyUp);
            // 
            // cmbComponent
            // 
            this.cmbComponent.AccessibleDescription = "";
            this.cmbComponent.AccessibleName = "";
            this.cmbComponent.AddItemSeparator = ';';
            this.cmbComponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbComponent.Caption = "";
            this.cmbComponent.CaptionHeight = 17;
            this.cmbComponent.CaptionStyle = style1;
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
            this.cmbComponent.EvenRowStyle = style2;
            this.cmbComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComponent.FooterStyle = style3;
            this.cmbComponent.HeadingStyle = style4;
            this.cmbComponent.HighLightRowStyle = style5;
            this.cmbComponent.Images.Add(((System.Drawing.Image)(resources.GetObject("cmbComponent.Images"))));
            this.cmbComponent.ItemHeight = 15;
            this.cmbComponent.Location = new System.Drawing.Point(557, 65);
            this.cmbComponent.MatchEntryTimeout = ((long)(2000));
            this.cmbComponent.MaxDropDownItems = ((short)(5));
            this.cmbComponent.MaxLength = 32767;
            this.cmbComponent.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbComponent.Name = "cmbComponent";
            this.cmbComponent.OddRowStyle = style6;
            this.cmbComponent.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbComponent.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbComponent.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbComponent.SelectedStyle = style7;
            this.cmbComponent.Size = new System.Drawing.Size(180, 21);
            this.cmbComponent.Style = style8;
            this.cmbComponent.TabIndex = 601;
            this.cmbComponent.PropBag = resources.GetString("cmbComponent.PropBag");
            // 
            // label6
            // 
            this.label6.ImageIndex = 1;
            this.label6.ImageList = this.img_Label;
            this.label6.Location = new System.Drawing.Point(353, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 602;
            this.label6.Text = "Component";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.ImageIndex = 1;
            this.label4.ImageList = this.img_Label;
            this.label4.Location = new System.Drawing.Point(748, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 600;
            this.label4.Text = "Line";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Line
            // 
            this.cmb_Line.AddItemSeparator = ';';
            this.cmb_Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Line.Caption = "";
            this.cmb_Line.CaptionHeight = 17;
            this.cmb_Line.CaptionStyle = style9;
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
            this.cmb_Line.EvenRowStyle = style10;
            this.cmb_Line.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Line.FooterStyle = style11;
            this.cmb_Line.HeadingStyle = style12;
            this.cmb_Line.HighLightRowStyle = style13;
            this.cmb_Line.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Line.Images"))));
            this.cmb_Line.ItemHeight = 15;
            this.cmb_Line.Location = new System.Drawing.Point(854, 65);
            this.cmb_Line.MatchEntryTimeout = ((long)(2000));
            this.cmb_Line.MaxDropDownItems = ((short)(5));
            this.cmb_Line.MaxLength = 32767;
            this.cmb_Line.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Line.Name = "cmb_Line";
            this.cmb_Line.OddRowStyle = style14;
            this.cmb_Line.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Line.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Line.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Line.SelectedStyle = style15;
            this.cmb_Line.Size = new System.Drawing.Size(150, 20);
            this.cmb_Line.Style = style16;
            this.cmb_Line.TabIndex = 599;
            this.cmb_Line.PropBag = resources.GetString("cmb_Line.PropBag");
            // 
            // label3
            // 
            this.label3.ImageIndex = 1;
            this.label3.ImageList = this.img_Label;
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 597;
            this.label3.Text = "Style Code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Style
            // 
            this.cmb_Style.AccessibleDescription = "";
            this.cmb_Style.AccessibleName = "";
            this.cmb_Style.AddItemSeparator = ';';
            this.cmb_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Style.Caption = "";
            this.cmb_Style.CaptionHeight = 17;
            this.cmb_Style.CaptionStyle = style17;
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
            this.cmb_Style.EvenRowStyle = style18;
            this.cmb_Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Style.FooterStyle = style19;
            this.cmb_Style.HeadingStyle = style20;
            this.cmb_Style.HighLightRowStyle = style21;
            this.cmb_Style.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Style.Images"))));
            this.cmb_Style.ItemHeight = 15;
            this.cmb_Style.Location = new System.Drawing.Point(192, 64);
            this.cmb_Style.MatchEntryTimeout = ((long)(2000));
            this.cmb_Style.MaxDropDownItems = ((short)(5));
            this.cmb_Style.MaxLength = 32767;
            this.cmb_Style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Style.Name = "cmb_Style";
            this.cmb_Style.OddRowStyle = style22;
            this.cmb_Style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Style.SelectedStyle = style23;
            this.cmb_Style.Size = new System.Drawing.Size(152, 21);
            this.cmb_Style.Style = style24;
            this.cmb_Style.TabIndex = 596;
            this.cmb_Style.SelectedValueChanged += new System.EventHandler(this.cmb_Style_SelectedValueChanged);
            this.cmb_Style.PropBag = resources.GetString("cmb_Style.PropBag");
            // 
            // txt_Style
            // 
            this.txt_Style.BackColor = System.Drawing.Color.White;
            this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Style.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Style.Location = new System.Drawing.Point(120, 64);
            this.txt_Style.MaxLength = 100;
            this.txt_Style.Name = "txt_Style";
            this.txt_Style.Size = new System.Drawing.Size(72, 21);
            this.txt_Style.TabIndex = 595;
            this.txt_Style.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Style_KeyUp);
            // 
            // dpick_YMD
            // 
            this.dpick_YMD.CustomFormat = "yyyy-MM-dd";
            this.dpick_YMD.Font = new System.Drawing.Font("Verdana", 9F);
            this.dpick_YMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_YMD.Location = new System.Drawing.Point(854, 32);
            this.dpick_YMD.Name = "dpick_YMD";
            this.dpick_YMD.Size = new System.Drawing.Size(102, 22);
            this.dpick_YMD.TabIndex = 191;
            // 
            // lbl_PlanYMD
            // 
            this.lbl_PlanYMD.ImageIndex = 1;
            this.lbl_PlanYMD.ImageList = this.img_Label;
            this.lbl_PlanYMD.Location = new System.Drawing.Point(750, 32);
            this.lbl_PlanYMD.Name = "lbl_PlanYMD";
            this.lbl_PlanYMD.Size = new System.Drawing.Size(100, 21);
            this.lbl_PlanYMD.TabIndex = 72;
            this.lbl_PlanYMD.Text = "D-2 Day";
            this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.ImageIndex = 1;
            this.label2.ImageList = this.img_Label;
            this.label2.Location = new System.Drawing.Point(352, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 536;
            this.label2.Text = "Vendor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Vendor
            // 
            this.cmb_Vendor.AddItemSeparator = ';';
            this.cmb_Vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Vendor.Caption = "";
            this.cmb_Vendor.CaptionHeight = 17;
            this.cmb_Vendor.CaptionStyle = style25;
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
            this.cmb_Vendor.EvenRowStyle = style26;
            this.cmb_Vendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vendor.FooterStyle = style27;
            this.cmb_Vendor.HeadingStyle = style28;
            this.cmb_Vendor.HighLightRowStyle = style29;
            this.cmb_Vendor.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Vendor.Images"))));
            this.cmb_Vendor.ItemHeight = 15;
            this.cmb_Vendor.Location = new System.Drawing.Point(458, 33);
            this.cmb_Vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_Vendor.MaxDropDownItems = ((short)(5));
            this.cmb_Vendor.MaxLength = 32767;
            this.cmb_Vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Vendor.Name = "cmb_Vendor";
            this.cmb_Vendor.OddRowStyle = style30;
            this.cmb_Vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.SelectedStyle = style31;
            this.cmb_Vendor.Size = new System.Drawing.Size(224, 20);
            this.cmb_Vendor.Style = style32;
            this.cmb_Vendor.TabIndex = 397;
            this.cmb_Vendor.PropBag = resources.GetString("cmb_Vendor.PropBag");
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style33;
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
            this.cmb_Factory.EvenRowStyle = style34;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style35;
            this.cmb_Factory.HeadingStyle = style36;
            this.cmb_Factory.HighLightRowStyle = style37;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(120, 32);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style38;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style39;
            this.cmb_Factory.Size = new System.Drawing.Size(224, 21);
            this.cmb_Factory.Style = style40;
            this.cmb_Factory.TabIndex = 34;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.ImageIndex = 1;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(16, 32);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 32;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(1015, 24);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(17, 72);
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
            this.picb_BR.Location = new System.Drawing.Point(1016, 97);
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
            this.picb_BM.Location = new System.Drawing.Point(144, 96);
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
            this.picb_BL.Location = new System.Drawing.Point(0, 97);
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
            this.picb_ML.Size = new System.Drawing.Size(168, 75);
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
            this.picb_MM.Size = new System.Drawing.Size(864, 72);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.fgrid_Vendor_Control);
            this.panel3.Location = new System.Drawing.Point(0, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 477);
            this.panel3.TabIndex = 180;
            // 
            // fgrid_Vendor_Control
            // 
            this.fgrid_Vendor_Control.ColumnInfo = "10,1,0,0,0,80,Columns:1{AllowMerging:True;}\t";
            this.fgrid_Vendor_Control.CustomMerging = false;
            this.fgrid_Vendor_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Vendor_Control.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.fgrid_Vendor_Control.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Vendor_Control.Name = "fgrid_Vendor_Control";
            this.fgrid_Vendor_Control.Rows.DefaultSize = 16;
            this.fgrid_Vendor_Control.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fgrid_Vendor_Control.Size = new System.Drawing.Size(1020, 477);
            this.fgrid_Vendor_Control.StyleInfo = resources.GetString("fgrid_Vendor_Control.StyleInfo");
            this.fgrid_Vendor_Control.TabIndex = 179;
            // 
            // Form_Vendor_Seq_Control
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1028, 701);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form_Vendor_Seq_Control";
            this.Text = "Vendor Sequence Control";
            this.Load += new System.EventHandler(this.Form_Vendor_Seq_Control_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Vendor_Control)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Init_Control()
		{
			DataTable dt_ret;

			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
	
			dt_ret = Select_Vendor_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 1, false,ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Vendor.SelectedIndex = 0;
			
			dt_ret = SELECT_LINE_INFO();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Line, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Line.SelectedIndex = 0;

			fgrid_Vendor_Control.Set_Grid("SQM_VENDOR_CTRL","1",3, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch , false);
			fgrid_Vendor_Control.Set_Action_Image(img_Action);
			//fgrid_Vendor_Control.Rows.Fixed = 4;
			
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

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;
				Clear_FlexGrid1();
                Display_FlexGrid1(SearchData1(Convert.ToString(cmb_Factory.SelectedValue), Convert.ToString(cmb_Vendor.SelectedValue), dpick_YMD.Value.ToString("yyyyMMdd"), Convert.ToString(cmb_Style.SelectedValue), Convert.ToString(cmb_Line.SelectedValue), Convert.ToString(cmbComponent.SelectedValue)));
                SELECT_IN_OUT_SEQ_HEAD();
				SELECT_IN_OUT_SEQ_VALUE();
				Cal_Sum();
				FormatGrid();
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
		
		private void Clear_FlexGrid1()
		{
			if (fgrid_Vendor_Control.Rows.Fixed != fgrid_Vendor_Control.Rows.Count)
			{				
				fgrid_Vendor_Control.Clear(ClearFlags.UserData, fgrid_Vendor_Control.Rows.Fixed, 1, fgrid_Vendor_Control.Rows.Count - 1, fgrid_Vendor_Control.Cols.Count - 1);

				fgrid_Vendor_Control.Rows.Count = fgrid_Vendor_Control.Rows.Fixed;	
			}
			for (int i = fgrid_Vendor_Control.Cols.Count -1; i >= 13  ; i --)
			{
				fgrid_Vendor_Control.Cols.Remove(i);
			}	
		}

		private void Display_FlexGrid1(DataTable arg_dt)
		{
			int iCount = arg_dt.Rows.Count;		

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{			
				C1.Win.C1FlexGrid.Node newRow = fgrid_Vendor_Control.Rows.InsertNode(fgrid_Vendor_Control.Rows.Fixed + iRow, 1);
				fgrid_Vendor_Control[newRow.Row.Index, 0] = "";

				for (int iCol = 1 ; iCol <= arg_dt.Columns.Count ; iCol++)
				{
					fgrid_Vendor_Control[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
				}
			}
			

			fgrid_Vendor_Control.AllowMerging = AllowMergingEnum.RestrictAll;
			
			fgrid_Vendor_Control.CustomMerging  = true;

			foreach (Column col in fgrid_Vendor_Control.Cols)
				col.AllowMerging = true;

			foreach (Row row in fgrid_Vendor_Control.Rows)
				row.AllowMerging = false;
			
		}

		private DataTable SearchData1(string p_factory, string p_vendor_cd,string p_d2_day , string p_style_cd,string p_line_cd,string p_comp_cd)
		{
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;
			
			try
			{
				string process_name = "pkg_sqm_cust.sp_sel_vend_ctrl_header";

				MyOraDB.ReDim_Parameter(7);  
				MyOraDB.Process_Name = process_name;
   
				MyOraDB.Parameter_Name[0] = "arg_factory"; 
				MyOraDB.Parameter_Name[1] = "arg_vendor_cd"; 
				MyOraDB.Parameter_Name[2] = "arg_d2_day";
				MyOraDB.Parameter_Name[3] = "arg_style_cd";
				MyOraDB.Parameter_Name[4] = "arg_line_cd";
                MyOraDB.Parameter_Name[5] = "arg_comp_cd";
				MyOraDB.Parameter_Name[6] = "out_cursor"; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

				MyOraDB.Parameter_Values[0] = p_factory;
				MyOraDB.Parameter_Values[1] = p_vendor_cd;
				MyOraDB.Parameter_Values[2] = p_d2_day;
				MyOraDB.Parameter_Values[3] = p_style_cd;
				MyOraDB.Parameter_Values[4] = p_line_cd;
                MyOraDB.Parameter_Values[5] = p_comp_cd;
				MyOraDB.Parameter_Values[6] = ""; 

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

		private void FormatGrid()
		{
			for(int i = 4 ; i<fgrid_Vendor_Control.Rows.Count;i++)
			{
				if(Convert.ToString(fgrid_Vendor_Control.Rows[i][G_IN_OUT])=="O")
				{
					fgrid_Vendor_Control.Rows[i].StyleNew.ForeColor=Color.Blue;
				}
				else
				{
					fgrid_Vendor_Control.Rows[i].StyleNew.ForeColor=Color.Red;
				}

			}
		
			fgrid_Vendor_Control.Cols[G_VENDOR_NAME].StyleNew.ForeColor = Color.Black;
			fgrid_Vendor_Control.Cols[G_STYLE_NAME].StyleNew.ForeColor = Color.Black;
			fgrid_Vendor_Control.Cols[G_STYLE_CD].StyleNew.ForeColor = Color.Black;
			fgrid_Vendor_Control.Cols[G_LINE_NAME].StyleNew.ForeColor = Color.Black;
			fgrid_Vendor_Control.Cols[G_COMP].StyleNew.ForeColor = Color.Black;
		}


		private void SELECT_IN_OUT_SEQ_HEAD()
		{
			DataTable dt = SELECT_IN_OUT_HEAD();
			if (dt != null)
			{
				if (dt.Rows.Count > 0)
				{
					for (int i = 0; i < dt.Rows.Count; i ++ )
					{
						fgrid_Vendor_Control.Cols.Add();
						fgrid_Vendor_Control.Cols[fgrid_Vendor_Control.Cols.Count -1].AllowSorting = false;
						fgrid_Vendor_Control.Cols[fgrid_Vendor_Control.Cols.Count -1].Caption = Convert.ToString(dt.Rows[i][0]);
						fgrid_Vendor_Control.Cols[fgrid_Vendor_Control.Cols.Count -1].UserData = Convert.ToString(dt.Rows[i][2]);

						fgrid_Vendor_Control.Cols[fgrid_Vendor_Control.Cols.Count -1].Width = 50;
						fgrid_Vendor_Control[2,fgrid_Vendor_Control.Cols.Count -1] = Convert.ToString(dt.Rows[i][1]);
						fgrid_Vendor_Control[3,fgrid_Vendor_Control.Cols.Count -1] = Convert.ToString(dt.Rows[i][3]);
						fgrid_Vendor_Control.Cols[fgrid_Vendor_Control.Cols.Count -1].AllowMerging=false;
						fgrid_Vendor_Control.Cols[fgrid_Vendor_Control.Cols.Count-1].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;
					}
                    int index = 0;
                    for (int i = 12; i < fgrid_Vendor_Control.Cols.Count; i++)
                    {
                        if (Convert.ToString(fgrid_Vendor_Control.Rows[3][i]) == "D-D")
                        {
                            index = i;
                            break;
                        }
                    }
                    int a = 0;
                    for (int i = index + 1; i < fgrid_Vendor_Control.Cols.Count; i++)
                    {
                        if (Convert.ToInt32(fgrid_Vendor_Control.Cols[i].UserData) != 1)
                        {
                            a = a + 1;
                            fgrid_Vendor_Control.Rows[3][i] = "D+" + Convert.ToString(a);
                        }

                    }

                    int b = 0;
                    for (int i = index - 1; i >= 13; i--)
                    {
                        if (Convert.ToInt32(fgrid_Vendor_Control.Cols[i].UserData) != 1)
                        {
                            b = b + 1;
                            fgrid_Vendor_Control.Rows[3][i] = "D-" + Convert.ToString(b);
                        }

                    }
				}
			}
		}

		private DataTable SELECT_IN_OUT_HEAD()
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;			
			try
			{
				string process_name = "pkg_sqm_cust.sp_sel_in_out_header";

				MyOraDB.ReDim_Parameter(2);  
				MyOraDB.Process_Name = process_name;

				MyOraDB.Parameter_Name[0] = "arg_d2_day";  
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR"; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = dpick_YMD.Value.ToString("yyyyMMdd") ;
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

		private DataTable SELECT_IN_OUT_VALUE(string p_vendor_cd,string p_line_cd,string p_style_cd,string p_in_out,string p_lot_no,string p_plan_ymd , string p_kind_day,string p_comp_cd,string p_dpo)
		{
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;	
			try
			{
				string process_name = "pkg_sqm_cust.sp_sel_in_out_seq_value";

				MyOraDB.ReDim_Parameter(10);  
				MyOraDB.Process_Name = process_name;
   

				MyOraDB.Parameter_Name[0] = "arg_vendor_cd"; 
				MyOraDB.Parameter_Name[1] = "arg_line_cd"; 
				MyOraDB.Parameter_Name[2] = "arg_style_cd"; 
				MyOraDB.Parameter_Name[3] = "arg_in_out"; 
				MyOraDB.Parameter_Name[4] = "arg_lot_no"; 
				MyOraDB.Parameter_Name[5] = "arg_plan_ymd"; 
				MyOraDB.Parameter_Name[6] = "arg_kind_day";
                MyOraDB.Parameter_Name[7] = "arg_comp_cd";
                MyOraDB.Parameter_Name[8] = "arg_dpo";
				MyOraDB.Parameter_Name[9] = "OUT_CURSOR"; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[9] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = p_vendor_cd;
				MyOraDB.Parameter_Values[1] = p_line_cd;
				MyOraDB.Parameter_Values[2] = p_style_cd;
				MyOraDB.Parameter_Values[3] = p_in_out;
				MyOraDB.Parameter_Values[4] = p_lot_no;
				MyOraDB.Parameter_Values[5] = p_plan_ymd;
				MyOraDB.Parameter_Values[6] = p_kind_day;
                MyOraDB.Parameter_Values[7] = p_comp_cd;
                MyOraDB.Parameter_Values[8] = p_dpo;
				MyOraDB.Parameter_Values[9] = ""; 

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

		private void SELECT_IN_OUT_SEQ_VALUE()
		{
			for (int i = 4 ; i <fgrid_Vendor_Control.Rows.Count;i++)
			{
				for (int j = 13 ; j < fgrid_Vendor_Control.Cols.Count;j++)
				{
					string p_vendor_cd = Convert.ToString(fgrid_Vendor_Control.Rows[i][G_VENDOR_CD]);
					string p_line_cd = Convert.ToString(fgrid_Vendor_Control.Rows[i][G_LINE_CD]);
					string p_style_cd = Convert.ToString(fgrid_Vendor_Control.Rows[i][G_STYLE_CD]);
					string p_in_out = Convert.ToString(fgrid_Vendor_Control.Rows[i][G_IN_OUT]);
					string p_lot_no = Convert.ToString(fgrid_Vendor_Control.Rows[i][G_LOT_NO]);
					string p_plan_ymd = Convert.ToString(fgrid_Vendor_Control.Cols[j].Caption);
					string p_kind_day = Convert.ToString(fgrid_Vendor_Control.Cols[j].UserData);
                    string p_comp_cd = Convert.ToString(fgrid_Vendor_Control.Rows[i][G_COMP_CD]);
                    string p_dpo = Convert.ToString(fgrid_Vendor_Control.Rows[i][G_DPO]);

                    DataTable dt = SELECT_IN_OUT_VALUE(p_vendor_cd, p_line_cd, p_style_cd, p_in_out, p_lot_no, p_plan_ymd, p_kind_day, p_comp_cd, p_dpo);
					if (dt != null)
					{
						fgrid_Vendor_Control.Rows[i][j]=dt.Rows[0][0];
					}

				}
			}
		}
		private void Cal_Sum()
		{
			fgrid_Vendor_Control.Cols.Add();
			fgrid_Vendor_Control.Cols[fgrid_Vendor_Control.Cols.Count-1].Width = 60 ;
			fgrid_Vendor_Control.Cols[fgrid_Vendor_Control.Cols.Count-1].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;
			fgrid_Vendor_Control.Cols[fgrid_Vendor_Control.Cols.Count-1].AllowMerging = true ;
			fgrid_Vendor_Control.Rows[1][fgrid_Vendor_Control.Cols.Count-1]="Total";
			fgrid_Vendor_Control.Rows[2][fgrid_Vendor_Control.Cols.Count-1]="Total";
			fgrid_Vendor_Control.Rows[3][fgrid_Vendor_Control.Cols.Count-1]="Total";

			for(int i = 4 ; i<fgrid_Vendor_Control.Rows.Count;i++)
			{
				int sum = 0 ;
				for (int j = 13 ; j<fgrid_Vendor_Control.Cols.Count;j++)
				{
					if(Convert.ToString(fgrid_Vendor_Control.Rows[i][j])=="")
					{
						continue;
					}
					else if(Convert.ToString(fgrid_Vendor_Control.Rows[i][j])=="OK")
					{
						continue;
					}
					else
					{
						sum = sum + Convert.ToInt32(fgrid_Vendor_Control.Rows[i][j]);
					}

				}
				if(sum != 0)
				{
					fgrid_Vendor_Control.Rows[i][fgrid_Vendor_Control.Cols.Count-1]=sum;
				}
			}
		}

		private void Form_Vendor_Seq_Control_Load(object sender, System.EventArgs e)
		{
			//tbtn_Search_Click(tbtn_Search,C1.Win.C1Command.ClickEventArgs.Empty);
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
            //MessageBox.Show(Convert.ToString(fgrid_Vendor_Control.Rows.Count - fgrid_Vendor_Control.Rows.Fixed));
            tbtn_Search_Click(sender,e);
            DELETE_DATA_TEMP();
            SAVE_DATA_TEMP();
            DISPLAY_REPORT();
        }
        private void DELETE_DATA_TEMP()
        {
            int iCount = 1;
            int para_ct = 0;
            MyOraDB.ReDim_Parameter(iCount);
            MyOraDB.Process_Name = "PKG_SQM_CUST.sp_del_in_out_seq_temp";
            MyOraDB.Parameter_Name[0] = "ARG_TEMP";
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Values[para_ct + 0] = "";
            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
                   
        }
        private void SAVE_DATA_TEMP()
        {
            try
            {
                int iCount = 61;
                MyOraDB.ReDim_Parameter(iCount);

                //01.PROCEDURE NAME
                MyOraDB.Process_Name = "PKG_SQM_CUST.SP_INS_IN_OUT_SEQ_TEMP";

                //02.ARGURMENT OF PROC
                MyOraDB.Parameter_Name[0] = "ARG_VENDOR_CD";
                MyOraDB.Parameter_Name[1] = "ARG_VENDOR_NM";
                MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[3] = "ARG_LINE_NM";
                MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[5] = "ARG_STYLE_NM";
                MyOraDB.Parameter_Name[6] = "ARG_COMP_CD";
                MyOraDB.Parameter_Name[7] = "ARG_COMP_NM";
                MyOraDB.Parameter_Name[8] = "ARG_IN_OUT";
                MyOraDB.Parameter_Name[9] = "ARG_LOT_NO";
                MyOraDB.Parameter_Name[10] = "ARG_YMD_1";
                MyOraDB.Parameter_Name[11] = "ARG_D_DT_1";
                MyOraDB.Parameter_Name[12] = "ARG_VALUE_1";
                MyOraDB.Parameter_Name[13] = "ARG_YMD_2";
                MyOraDB.Parameter_Name[14] = "ARG_D_DT_2";
                MyOraDB.Parameter_Name[15] = "ARG_VALUE_2";
                MyOraDB.Parameter_Name[16] = "ARG_YMD_3";
                MyOraDB.Parameter_Name[17] = "ARG_D_DT_3";
                MyOraDB.Parameter_Name[18] = "ARG_VALUE_3";
                MyOraDB.Parameter_Name[19] = "ARG_YMD_4";
                MyOraDB.Parameter_Name[20] = "ARG_D_DT_4";
                MyOraDB.Parameter_Name[21] = "ARG_VALUE_4";
                MyOraDB.Parameter_Name[22] = "ARG_YMD_5";
                MyOraDB.Parameter_Name[23] = "ARG_D_DT_5";
                MyOraDB.Parameter_Name[24] = "ARG_VALUE_5";
                MyOraDB.Parameter_Name[25] = "ARG_YMD_6";
                MyOraDB.Parameter_Name[26] = "ARG_D_DT_6";
                MyOraDB.Parameter_Name[27] = "ARG_VALUE_6";
                MyOraDB.Parameter_Name[28] = "ARG_YMD_7";
                MyOraDB.Parameter_Name[29] = "ARG_D_DT_7";
                MyOraDB.Parameter_Name[30] = "ARG_VALUE_7";
                MyOraDB.Parameter_Name[31] = "ARG_YMD_8";
                MyOraDB.Parameter_Name[32] = "ARG_D_DT_8";
                MyOraDB.Parameter_Name[33] = "ARG_VALUE_8";
                MyOraDB.Parameter_Name[34] = "ARG_YMD_9";
                MyOraDB.Parameter_Name[35] = "ARG_D_DT_9";
                MyOraDB.Parameter_Name[36] = "ARG_VALUE_9";
                MyOraDB.Parameter_Name[37] = "ARG_YMD_10";
                MyOraDB.Parameter_Name[38] = "ARG_D_DT_10";
                MyOraDB.Parameter_Name[39] = "ARG_VALUE_10";
                MyOraDB.Parameter_Name[40] = "ARG_YMD_11";
                MyOraDB.Parameter_Name[41] = "ARG_D_DT_11";
                MyOraDB.Parameter_Name[42] = "ARG_VALUE_11";
                MyOraDB.Parameter_Name[43] = "ARG_YMD_12";
                MyOraDB.Parameter_Name[44] = "ARG_D_DT_12";
                MyOraDB.Parameter_Name[45] = "ARG_VALUE_12";
                MyOraDB.Parameter_Name[46] = "ARG_YMD_13";
                MyOraDB.Parameter_Name[47] = "ARG_D_DT_13";
                MyOraDB.Parameter_Name[48] = "ARG_VALUE_13";
                MyOraDB.Parameter_Name[49] = "ARG_YMD_14";
                MyOraDB.Parameter_Name[50] = "ARG_D_DT_14";
                MyOraDB.Parameter_Name[51] = "ARG_VALUE_14";
                MyOraDB.Parameter_Name[52] = "ARG_YMD_15";
                MyOraDB.Parameter_Name[53] = "ARG_D_DT_15";
                MyOraDB.Parameter_Name[54] = "ARG_VALUE_15";
                MyOraDB.Parameter_Name[55] = "ARG_YMD_16";
                MyOraDB.Parameter_Name[56] = "ARG_D_DT_16";
                MyOraDB.Parameter_Name[57] = "ARG_VALUE_16";
                MyOraDB.Parameter_Name[58] = "ARG_YMD_17";
                MyOraDB.Parameter_Name[59] = "ARG_D_DT_17";
                MyOraDB.Parameter_Name[60] = "ARG_VALUE_17";

                //03. Type
                for (int iCol = 0; iCol < iCount; iCol++)
                {
                    MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
                }
                ArrayList temp = new ArrayList();

                for (int iRow = fgrid_Vendor_Control.Rows.Fixed; iRow < fgrid_Vendor_Control.Rows.Count; iRow++)
                {
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_VENDOR_CD]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_VENDOR_NAME]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_LINE_CD]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_LINE_NAME]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_STYLE_CD]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_STYLE_NAME]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COMP_CD]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COMP]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_IN_OUT]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_LOT_NO]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[2][G_COL_1]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[3][G_COL_1]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COL_1]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[2][G_COL_2]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[3][G_COL_2]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COL_2]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[2][G_COL_3]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[3][G_COL_3]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COL_3]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[2][G_COL_4]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[3][G_COL_4]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COL_4]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[2][G_COL_5]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[3][G_COL_5]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COL_5]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[2][G_COL_6]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[3][G_COL_6]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COL_6]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[2][G_COL_7]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[3][G_COL_7]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COL_7]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[2][G_COL_8]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[3][G_COL_8]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COL_8]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[2][G_COL_9]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[3][G_COL_9]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COL_9]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[2][G_COL_10]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[3][G_COL_10]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COL_10]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[2][G_COL_11]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[3][G_COL_11]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COL_11]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[2][G_COL_12]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[3][G_COL_12]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COL_12]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[2][G_COL_13]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[3][G_COL_13]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COL_13]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[2][G_COL_14]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[3][G_COL_14]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COL_14]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[2][G_COL_15]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[3][G_COL_15]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COL_15]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[2][G_COL_16]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[3][G_COL_16]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COL_16]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[2][G_COL_17]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[3][G_COL_17]));
                    temp.Add(Convert.ToString(fgrid_Vendor_Control.Rows[iRow][G_COL_17]));
                }
                MyOraDB.Parameter_Values = new string[temp.Count];

                for (int j = 0; j < temp.Count; j++)
                {
                    MyOraDB.Parameter_Values[j] = temp[j].ToString();
                }
                MyOraDB.Add_Modify_Parameter(true);

                MyOraDB.Exe_Modify_Procedure();

            }
            catch (System.Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DISPLAY_REPORT()
        {
            string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_Vendor_Seq_Control");
            string Para = " ";
            int iCnt = 1;
            string[] aHead = new string[iCnt];

            aHead[0] = "";
            Para = " /rp ";
            for (int i = 1; i <= iCnt; i++)
            {
                Para = Para + "[" + aHead[i - 1] + "] ";
            }
            FlexSQM.Report.Form_RdViewer report = new FlexSQM.Report.Form_RdViewer(mrd_Filename, Para);
            //FlexTraining.Report.Form_RdViewer report = new FlexTraining.Report.Form_RdViewer(mrd_Filename, Para);
            report.Show();
        }

        private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Form_Component_Payment fo = new Form_Component_Payment();
            fo.Show();
        }

        private void cmb_Style_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cmb_Style.SelectedValue) != "")
            {
                txt_Style.Text = Convert.ToString(cmb_Style.SelectedValue);
            }
        }

	}
	
	/// <summary>
	/// CustomMergeFlex
	/// Inherits from C1FlexGrid to provide custom merging logic.
	/// Set the CustomMerging to true and the grid will merge the
	/// header cells using custom logic. the default behavior is 
	/// used for the rest of the grid.
	/// </summary>
	public class CustomMergeFlex : COM.FSP
	{
		// ** ctor

		public CustomMergeFlex() {}

		// ** custom merging property

		protected bool _customMerging;
		public bool CustomMerging
		{
			get { return _customMerging; }
			set 
			{
				_customMerging = value;
				Invalidate();
			}
		}

		// ** override merging logic

		override public CellRange GetMergedRange(int row, int col, bool clip)
		{
			try
			{
				// use custom merging for fixed rows
				if (_customMerging && row < Rows.Fixed)
				{
					//merge cac cot duoc dinh nghia san va cot total
					if (col == 2 || col == 4 || col == 5 || col == 6 || col == 7 || col == 8 || col == this.Cols.Count - 1)
						return GetCellRange(1, col, this.Rows.Fixed -1, col);
					//mege tai dong 0(duoc invisable boi framwork
					if (row == 0 && col > 0 && col < this.Cols.Count)
						return GetCellRange(0, 2, 0, this.Cols.Count - 1);
					//merge cac cell tai vi tri cac cot duoc add dong vao(ngay thang)
					if(row ==1 && col >9 && col < this.Cols.Count - 1)
						return GetCellRange(1,col,1,this.Cols.Count-2);
				}
				//use custom merging for data row
				if(_customMerging && Rows.Count > Rows.Fixed)
				{					
						//merge cac cot duoc chu dinh
					if (col == 2 || col == 4 || col == 5 || col == 6 || col == 7)
					{
						CellRange rg = GetCellRange(row, col);
						int cnt = Cols.Count;
						int ifx = Cols.Fixed;
						int i;
						// expand up/down
						cnt = Rows.Count;
						ifx = Rows.Fixed;
						for (i = rg.r1; i < cnt-1; i++)
						{
							if (GetDataDisplay(i, rg.c1) != GetDataDisplay(i+1, rg.c1)) break;
							rg.r2 = i+1;
						}
						for (i = rg.r1; i > ifx; i--)
						{
							if (GetDataDisplay(i, rg.c1) != GetDataDisplay(i-1, rg.c1)) break;
							rg.r1 = i-1;
						}
						return rg;

					}
				}

				// use default implementation
				return base.GetMergedRange(row, col, clip);
			}
			catch//Neu co loi thi su dung phuong thuc merge default cua COM.FSP
			{
				return base.GetMergedRange(row, col, clip);
			}
		}
	}


}
