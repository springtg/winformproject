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
	public class Form_Select_Item : COM.SQMWinForm.Pop_Small
	{
		public System.Windows.Forms.Panel pnl_BT;
        public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.TextBox txt_Item_Name;
		private System.Windows.Forms.Label lbl_Item_Name;
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
		private COM.FSP fgrid_Item;
        public string l_comp_cd = "";
        private Label label3;
        private C1.Win.C1List.C1Combo cmb_Style;
        private TextBox txt_Style;
        public string l_comp_nm = "";
		public Form_Select_Item(string p_temp)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			txt_Style.Text = p_temp;
            Search_Style_cd();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Select_Item));
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            this.pnl_BT = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.btn_Search = new C1.Win.C1Input.C1Label();
            this.txt_Item_Name = new System.Windows.Forms.TextBox();
            this.lbl_Item_Name = new System.Windows.Forms.Label();
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
            this.fgrid_Item = new COM.FSP();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Style = new C1.Win.C1List.C1Combo();
            this.txt_Style = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).BeginInit();
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
            this.pnl_BT.Size = new System.Drawing.Size(698, 112);
            this.pnl_BT.TabIndex = 45;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.label3);
            this.pnl_SearchImage.Controls.Add(this.cmb_Style);
            this.pnl_SearchImage.Controls.Add(this.txt_Style);
            this.pnl_SearchImage.Controls.Add(this.btn_Search);
            this.pnl_SearchImage.Controls.Add(this.txt_Item_Name);
            this.pnl_SearchImage.Controls.Add(this.lbl_Item_Name);
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
            this.pnl_SearchImage.Size = new System.Drawing.Size(698, 107);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ImageIndex = 0;
            this.btn_Search.ImageList = this.img_Button;
            this.btn_Search.Location = new System.Drawing.Point(623, 50);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(72, 23);
            this.btn_Search.TabIndex = 567;
            this.btn_Search.Tag = null;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Search.TextDetached = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Item_Name
            // 
            this.txt_Item_Name.BackColor = System.Drawing.Color.White;
            this.txt_Item_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Item_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Item_Name.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_Item_Name.Location = new System.Drawing.Point(441, 50);
            this.txt_Item_Name.MaxLength = 100;
            this.txt_Item_Name.Name = "txt_Item_Name";
            this.txt_Item_Name.Size = new System.Drawing.Size(168, 21);
            this.txt_Item_Name.TabIndex = 6;
            this.txt_Item_Name.TextChanged += new System.EventHandler(this.txt_Item_Name_TextChanged);
            // 
            // lbl_Item_Name
            // 
            this.lbl_Item_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Item_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Item_Name.ImageIndex = 0;
            this.lbl_Item_Name.ImageList = this.img_Label;
            this.lbl_Item_Name.Location = new System.Drawing.Point(337, 50);
            this.lbl_Item_Name.Name = "lbl_Item_Name";
            this.lbl_Item_Name.Size = new System.Drawing.Size(96, 21);
            this.lbl_Item_Name.TabIndex = 36;
            this.lbl_Item_Name.Text = "Item Name";
            this.lbl_Item_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(961, 30);
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
            this.picb_TR.Location = new System.Drawing.Point(682, 0);
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
            this.picb_TM.Size = new System.Drawing.Size(474, 40);
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
            this.lbl_SubTitle1.Text = "      Item Code Info.";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(682, 92);
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
            this.picb_BM.Size = new System.Drawing.Size(538, 18);
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
            this.pictureBox1.Size = new System.Drawing.Size(530, 75);
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
            this.picb_MM.Size = new System.Drawing.Size(584, 75);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // fgrid_Item
            // 
            this.fgrid_Item.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Item.ColumnInfo = "10,1,0,0,0,80,Columns:";
            this.fgrid_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Item.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.fgrid_Item.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Item.Location = new System.Drawing.Point(0, 112);
            this.fgrid_Item.Name = "fgrid_Item";
            this.fgrid_Item.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fgrid_Item.Size = new System.Drawing.Size(698, 391);
            this.fgrid_Item.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Item.Styles"));
            this.fgrid_Item.TabIndex = 180;
            this.fgrid_Item.DoubleClick += new System.EventHandler(this.fgrid_Item_DoubleClick);
            // 
            // label3
            // 
            this.label3.ImageIndex = 1;
            this.label3.ImageList = this.img_Label;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 570;
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
            this.cmb_Style.CaptionStyle = style9;
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
            this.cmb_Style.EvenRowStyle = style10;
            this.cmb_Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Style.FooterStyle = style11;
            this.cmb_Style.GapHeight = 2;
            this.cmb_Style.HeadingStyle = style12;
            this.cmb_Style.HighLightRowStyle = style13;
            this.cmb_Style.ItemHeight = 15;
            this.cmb_Style.Location = new System.Drawing.Point(179, 50);
            this.cmb_Style.MatchEntryTimeout = ((long)(2000));
            this.cmb_Style.MaxDropDownItems = ((short)(5));
            this.cmb_Style.MaxLength = 32767;
            this.cmb_Style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Style.Name = "cmb_Style";
            this.cmb_Style.OddRowStyle = style14;
            this.cmb_Style.PartialRightColumn = false;
            this.cmb_Style.PropBag = resources.GetString("cmb_Style.PropBag");
            this.cmb_Style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Style.SelectedStyle = style15;
            this.cmb_Style.Size = new System.Drawing.Size(152, 21);
            this.cmb_Style.Style = style16;
            this.cmb_Style.TabIndex = 569;
            // 
            // txt_Style
            // 
            this.txt_Style.BackColor = System.Drawing.Color.White;
            this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Style.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Style.Location = new System.Drawing.Point(107, 50);
            this.txt_Style.MaxLength = 100;
            this.txt_Style.Name = "txt_Style";
            this.txt_Style.Size = new System.Drawing.Size(72, 21);
            this.txt_Style.TabIndex = 568;
            // 
            // Form_Select_Item
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(698, 503);
            this.Controls.Add(this.fgrid_Item);
            this.Controls.Add(this.pnl_BT);
            this.Name = "Form_Select_Item";
            this.ShowInTaskbar = false;
            this.Text = "Select Item";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.pnl_BT, 0);
            this.Controls.SetChildIndex(this.fgrid_Item, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Init_Control()
		{			
			fgrid_Item.Set_Grid("SQM_SELECT_ITEM","1",1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            _RowFixed = fgrid_Item.Rows.Fixed;
            fgrid_Item.Set_Action_Image(img_Action);

            txt_Style.Enabled = false;
            cmb_Style.Enabled = false;

		}
		

		private void txt_Item_Name_TextChanged(object sender, System.EventArgs e)
		{
		
		}
		
		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			Item_Search();
		}
		private void Clear_FlexGrid()
		{
			if (fgrid_Item.Rows.Fixed != fgrid_Item.Rows.Count)
			{				
				fgrid_Item.Clear(ClearFlags.UserData, fgrid_Item.Rows.Fixed, 1, fgrid_Item.Rows.Count - 1, fgrid_Item.Cols.Count - 1);

				fgrid_Item.Rows.Count = fgrid_Item.Rows.Fixed;
					
			}
		}

		private void Display_FlexGrid(DataTable arg_dt)
		{
			int iCount = arg_dt.Rows.Count;		

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{								
				C1.Win.C1FlexGrid.Node newRow = fgrid_Item.Rows.InsertNode(fgrid_Item.Rows.Fixed + iRow, 1);
				fgrid_Item[newRow.Row.Index, 0] = "";

				for (int iCol = 1 ; iCol <= arg_dt.Columns.Count ; iCol++)
				{
					fgrid_Item[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
				}
			}
		}
		public void Item_Search()
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;
				Clear_FlexGrid();
				Display_FlexGrid(SELECT_SBC_ITEM());
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
        
		public DataTable SELECT_SBC_ITEM()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sqm_cust.sp_sel_component";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[1] = "ARG_ITEM";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
            MyOraDB.Parameter_Values[0] = Convert.ToString(cmb_Style.SelectedValue).Replace("-","");
            MyOraDB.Parameter_Values[1] = txt_Item_Name.Text.Trim();
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}
		

		//=============================================================================

		public string l_item_code="";
		public string l_item_name="";
		//=============================================================================
		private void fgrid_Item_DoubleClick(object sender, System.EventArgs e)
		{			
			COM.FSP l_fgrid_Item=(COM.FSP)sender;
			if (l_fgrid_Item.Rows.Count <= _RowFixed)
			{
				DialogResult = DialogResult.Cancel;
			}
			else
			{
				l_comp_cd =  fgrid_Item[fgrid_Item.RowSel,1].ToString();
				l_comp_nm =  fgrid_Item[fgrid_Item.RowSel,2].ToString();
				DialogResult = DialogResult.OK;
			}
		}
        private void Search_Style_cd()
        {
            try
            {
                cmb_Style.SelectedIndex = -1;
                DataTable dt_ret;
                dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_Style, " "));
                ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_Style, 0, 1, 2, 3, 4, false, 80, 200);
                dt_ret.Dispose();
                cmb_Style.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "txt_Style_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
	}
}
