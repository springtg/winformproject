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
	/// Summary description for Form_Select_Item.
	/// </summary>
	public class Form_Select_Style : COM.SQMWinForm.Pop_Small
	{
		public System.Windows.Forms.Panel pnl_BT;
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
		public System.Windows.Forms.PictureBox pictureBox1;
		private int _RowFixed = 1;

		private COM.OraDB MyOraDB = new COM.OraDB();
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        private C1.Win.C1Input.C1Label btn_Search;
        private COM.FSP fgrid_Style;
        private TextBox txtItem;
        private Label lbl_Item;
        
        private Label label7;
        private C1.Win.C1List.C1Combo cmb_obsid_fr;
        public C1.Win.C1List.C1Combo cmb_Factory;
        private Label lbl_Factory;
        


        public Form_Select_Style()
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Select_Style));
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.pnl_BT = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lbl_Item = new System.Windows.Forms.Label();
            this.btn_Search = new C1.Win.C1Input.C1Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.fgrid_Style = new COM.FSP();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_obsid_fr = new C1.Win.C1List.C1Combo();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.pnl_BT.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsid_fr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(251, 23);
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
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
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
            // pnl_BT
            // 
            this.pnl_BT.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_BT.Controls.Add(this.pnl_SearchImage);
            this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BT.Location = new System.Drawing.Point(0, 0);
            this.pnl_BT.Name = "pnl_BT";
            this.pnl_BT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnl_BT.Size = new System.Drawing.Size(589, 112);
            this.pnl_BT.TabIndex = 45;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
            this.pnl_SearchImage.Controls.Add(this.label7);
            this.pnl_SearchImage.Controls.Add(this.cmb_obsid_fr);
            this.pnl_SearchImage.Controls.Add(this.txtItem);
            this.pnl_SearchImage.Controls.Add(this.lbl_Item);
            this.pnl_SearchImage.Controls.Add(this.btn_Search);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Controls.Add(this.pictureBox1);
            this.pnl_SearchImage.Controls.Add(this.picb_MM);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(589, 107);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(336, 76);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(164, 21);
            this.txtItem.TabIndex = 569;
            // 
            // lbl_Item
            // 
            this.lbl_Item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Item.ImageIndex = 1;
            this.lbl_Item.ImageList = this.img_Label;
            this.lbl_Item.Location = new System.Drawing.Point(224, 74);
            this.lbl_Item.Name = "lbl_Item";
            this.lbl_Item.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbl_Item.Size = new System.Drawing.Size(108, 22);
            this.lbl_Item.TabIndex = 568;
            this.lbl_Item.Text = "Item";
            this.lbl_Item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ImageIndex = 0;
            this.btn_Search.ImageList = this.img_Button;
            this.btn_Search.Location = new System.Drawing.Point(500, 74);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(72, 23);
            this.btn_Search.TabIndex = 567;
            this.btn_Search.Tag = null;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Search.TextDetached = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(852, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(101, 67);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(573, 0);
            this.picb_TR.Name = "picb_TR";
            this.picb_TR.Size = new System.Drawing.Size(16, 40);
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
            this.picb_TM.Size = new System.Drawing.Size(365, 40);
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
            this.lbl_SubTitle1.Text = "      Style Code Info.";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(573, 92);
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
            this.picb_BM.Location = new System.Drawing.Point(144, 91);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(429, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 92);
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
            this.picb_ML.Size = new System.Drawing.Size(168, 74);
            this.picb_ML.TabIndex = 25;
            this.picb_ML.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-72, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 75);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // picb_MM
            // 
            this.picb_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
            this.picb_MM.Location = new System.Drawing.Point(120, 24);
            this.picb_MM.Name = "picb_MM";
            this.picb_MM.Size = new System.Drawing.Size(475, 75);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // fgrid_Style
            // 
            this.fgrid_Style.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Style.ColumnInfo = "10,1,0,0,0,80,Columns:";
            this.fgrid_Style.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Style.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.fgrid_Style.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Style.Location = new System.Drawing.Point(0, 112);
            this.fgrid_Style.Name = "fgrid_Style";
            this.fgrid_Style.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fgrid_Style.Size = new System.Drawing.Size(589, 374);
            this.fgrid_Style.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Style.Styles"));
            this.fgrid_Style.TabIndex = 180;
            this.fgrid_Style.DoubleClick += new System.EventHandler(this.fgrid_Style_DoubleClick);
            // 
            // label7
            // 
            this.label7.ImageIndex = 1;
            this.label7.ImageList = this.img_Label;
            this.label7.Location = new System.Drawing.Point(12, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 603;
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
            this.cmb_obsid_fr.CaptionStyle = style9;
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
            this.cmb_obsid_fr.EvenRowStyle = style10;
            this.cmb_obsid_fr.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_obsid_fr.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_obsid_fr.FooterStyle = style11;
            this.cmb_obsid_fr.GapHeight = 2;
            this.cmb_obsid_fr.HeadingStyle = style12;
            this.cmb_obsid_fr.HighLightRowStyle = style13;
            this.cmb_obsid_fr.ItemHeight = 15;
            this.cmb_obsid_fr.Location = new System.Drawing.Point(117, 76);
            this.cmb_obsid_fr.MatchEntryTimeout = ((long)(2000));
            this.cmb_obsid_fr.MaxDropDownItems = ((short)(5));
            this.cmb_obsid_fr.MaxLength = 32767;
            this.cmb_obsid_fr.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_obsid_fr.Name = "cmb_obsid_fr";
            this.cmb_obsid_fr.OddRowStyle = style14;
            this.cmb_obsid_fr.PartialRightColumn = false;
            this.cmb_obsid_fr.PropBag = resources.GetString("cmb_obsid_fr.PropBag");
            this.cmb_obsid_fr.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_obsid_fr.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_obsid_fr.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_obsid_fr.SelectedStyle = style15;
            this.cmb_obsid_fr.Size = new System.Drawing.Size(100, 20);
            this.cmb_obsid_fr.Style = style16;
            this.cmb_obsid_fr.TabIndex = 602;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style1;
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
            this.cmb_Factory.EvenRowStyle = style2;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style3;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style4;
            this.cmb_Factory.HighLightRowStyle = style5;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(117, 46);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style6;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style7;
            this.cmb_Factory.Size = new System.Drawing.Size(195, 21);
            this.cmb_Factory.Style = style8;
            this.cmb_Factory.TabIndex = 605;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.ImageIndex = 1;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(12, 47);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 604;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_Select_Style
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(589, 486);
            this.Controls.Add(this.fgrid_Style);
            this.Controls.Add(this.pnl_BT);
            this.Name = "Form_Select_Style";
            this.ShowInTaskbar = false;
            this.Text = "Select Item";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.pnl_BT, 0);
            this.Controls.SetChildIndex(this.fgrid_Style, 0);
            this.pnl_BT.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsid_fr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


        public string l_style_cd = "";
        public string l_style_nm = "";
        public string l_dpo = "";
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

        private void Init_Control()
        {
            DataTable dt_ret;
            dt_ret = COM.ComFunction.Select_Factory_List();
            COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

            dt_ret.Dispose(); 

            fgrid_Style.Set_Grid("SQM_SELECT_STYLE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Style.Set_Action_Image(img_Action);

            setDPO();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Clear_FlexGrid();
                Display_FlexGrid(SELECT_STYLE());
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "SearchData", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;

            }
        }

        private void Clear_FlexGrid()
        {
            if (fgrid_Style.Rows.Fixed != fgrid_Style.Rows.Count)
            {
                fgrid_Style.Clear(ClearFlags.UserData, fgrid_Style.Rows.Fixed, 1, fgrid_Style.Rows.Count - 1, fgrid_Style.Cols.Count - 1);

                fgrid_Style.Rows.Count = fgrid_Style.Rows.Fixed;

            }
        }
        private void Display_FlexGrid(DataTable arg_dt)
        {
            int iCount = arg_dt.Rows.Count;

            for (int iRow = 0; iRow < iCount; iRow++)
            {
                C1.Win.C1FlexGrid.Node newRow = fgrid_Style.Rows.InsertNode(fgrid_Style.Rows.Fixed + iRow, 1);
                fgrid_Style[newRow.Row.Index, 0] = "";

                for (int iCol = 1; iCol <= arg_dt.Columns.Count; iCol++)
                {
                    fgrid_Style[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol - 1];
                }
            }
        }

        public DataTable SELECT_STYLE()
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sqm_cust.select_style_cd";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_ITEM";
            MyOraDB.Parameter_Name[1] = "ARG_DPO";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = txtItem.Text.Replace("-", "");
            MyOraDB.Parameter_Values[1] = Convert.ToString(cmb_obsid_fr.SelectedValue);
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
        }

        private void fgrid_Style_DoubleClick(object sender, EventArgs e)
        {
            COM.FSP l_fgrid_Style = (COM.FSP)sender;
            if (l_fgrid_Style.Rows.Count <= _RowFixed)
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                l_style_cd = fgrid_Style[fgrid_Style.RowSel, 1].ToString();
                l_style_nm = fgrid_Style[fgrid_Style.RowSel, 2].ToString();
                l_dpo = fgrid_Style[fgrid_Style.RowSel, 5].ToString();
                DialogResult = DialogResult.OK;
            }
        }	
	}
}
