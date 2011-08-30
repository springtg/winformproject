using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCDC.BaseInfo
{
    public partial class Form_SMS_EMP : COM.CDCWinForm.Form_Top
    {
        public Form_SMS_EMP()
        {
            InitializeComponent();
        }

         private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SMS_EMP));
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
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.cmb_CSC_Vendor = new C1.Win.C1List.C1Combo();
            this.lbl_sabun = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.chk_Use = new System.Windows.Forms.CheckBox();
            this.cmb_Search = new C1.Win.C1List.C1Combo();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.txt_CSC_Vendor = new System.Windows.Forms.TextBox();
            this.lbl_CSCVendor = new System.Windows.Forms.Label();
            this.txt_sabun = new System.Windows.Forms.TextBox();
            this.txt_sabun_name = new System.Windows.Forms.TextBox();
            this.lbl_sabun_name = new System.Windows.Forms.Label();
            this.btn_openfile = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.fgrid_Main = new COM.FSP();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CSC_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
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
            this.c1ToolBar1.AccessibleName = "Tool Bar";
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4,
            this.c1CommandLink5,
            this.c1CommandLink6,
            this.c1CommandLink8,
            this.c1CommandLink7});
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
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 644);
            this.stbar.Size = new System.Drawing.Size(1016, 22);
            // 
            // pnl_Top
            // 
            this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Top.Controls.Add(this.cmb_CSC_Vendor);
            this.pnl_Top.Controls.Add(this.lbl_sabun);
            this.pnl_Top.Controls.Add(this.cmb_Factory);
            this.pnl_Top.Controls.Add(this.lbl_factory);
            this.pnl_Top.Controls.Add(this.pnl_SearchImage);
            this.pnl_Top.Location = new System.Drawing.Point(0, 62);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_Top.Size = new System.Drawing.Size(1016, 96);
            this.pnl_Top.TabIndex = 138;
            // 
            // cmb_CSC_Vendor
            // 
            this.cmb_CSC_Vendor.AddItemSeparator = ';';
            this.cmb_CSC_Vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_CSC_Vendor.Caption = "";
            this.cmb_CSC_Vendor.CaptionHeight = 17;
            this.cmb_CSC_Vendor.CaptionStyle = style121;
            this.cmb_CSC_Vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_CSC_Vendor.ColumnCaptionHeight = 18;
            this.cmb_CSC_Vendor.ColumnFooterHeight = 18;
            this.cmb_CSC_Vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_CSC_Vendor.ContentHeight = 16;
            this.cmb_CSC_Vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_CSC_Vendor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_CSC_Vendor.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CSC_Vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_CSC_Vendor.EditorHeight = 16;
            this.cmb_CSC_Vendor.EvenRowStyle = style122;
            this.cmb_CSC_Vendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CSC_Vendor.FooterStyle = style123;
            this.cmb_CSC_Vendor.HeadingStyle = style124;
            this.cmb_CSC_Vendor.HighLightRowStyle = style125;
            this.cmb_CSC_Vendor.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_CSC_Vendor.Images"))));
            this.cmb_CSC_Vendor.ItemHeight = 15;
            this.cmb_CSC_Vendor.Location = new System.Drawing.Point(853, 58);
            this.cmb_CSC_Vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_CSC_Vendor.MaxDropDownItems = ((short)(5));
            this.cmb_CSC_Vendor.MaxLength = 32767;
            this.cmb_CSC_Vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_CSC_Vendor.Name = "cmb_CSC_Vendor";
            this.cmb_CSC_Vendor.OddRowStyle = style126;
            this.cmb_CSC_Vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_CSC_Vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_CSC_Vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_CSC_Vendor.SelectedStyle = style127;
            this.cmb_CSC_Vendor.Size = new System.Drawing.Size(150, 20);
            this.cmb_CSC_Vendor.Style = style128;
            this.cmb_CSC_Vendor.TabIndex = 345;
            this.cmb_CSC_Vendor.PropBag = resources.GetString("cmb_CSC_Vendor.PropBag");
            // 
            // lbl_sabun
            // 
            this.lbl_sabun.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_sabun.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sabun.ImageIndex = 0;
            this.lbl_sabun.ImageList = this.img_Label;
            this.lbl_sabun.Location = new System.Drawing.Point(16, 58);
            this.lbl_sabun.Name = "lbl_sabun";
            this.lbl_sabun.Size = new System.Drawing.Size(100, 21);
            this.lbl_sabun.TabIndex = 344;
            this.lbl_sabun.Tag = "1";
            this.lbl_sabun.Text = "Sabun";
            this.lbl_sabun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style129;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 16;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 16;
            this.cmb_Factory.EvenRowStyle = style130;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style131;
            this.cmb_Factory.HeadingStyle = style132;
            this.cmb_Factory.HighLightRowStyle = style133;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(117, 35);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style134;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style135;
            this.cmb_Factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_Factory.Style = style136;
            this.cmb_Factory.TabIndex = 272;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(16, 35);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 271;
            this.lbl_factory.Tag = "0";
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.chk_Use);
            this.pnl_SearchImage.Controls.Add(this.cmb_Search);
            this.pnl_SearchImage.Controls.Add(this.lbl_Search);
            this.pnl_SearchImage.Controls.Add(this.txt_CSC_Vendor);
            this.pnl_SearchImage.Controls.Add(this.lbl_CSCVendor);
            this.pnl_SearchImage.Controls.Add(this.txt_sabun);
            this.pnl_SearchImage.Controls.Add(this.txt_sabun_name);
            this.pnl_SearchImage.Controls.Add(this.lbl_sabun_name);
            this.pnl_SearchImage.Controls.Add(this.btn_openfile);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.pictureBox2);
            this.pnl_SearchImage.Controls.Add(this.pictureBox3);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.Controls.Add(this.pictureBox4);
            this.pnl_SearchImage.Controls.Add(this.pictureBox5);
            this.pnl_SearchImage.Controls.Add(this.pictureBox6);
            this.pnl_SearchImage.Controls.Add(this.pictureBox7);
            this.pnl_SearchImage.Controls.Add(this.pictureBox8);
            this.pnl_SearchImage.Controls.Add(this.pictureBox9);
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 88);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // chk_Use
            // 
            this.chk_Use.AutoSize = true;
            this.chk_Use.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Use.Location = new System.Drawing.Point(343, 35);
            this.chk_Use.Name = "chk_Use";
            this.chk_Use.Size = new System.Drawing.Size(51, 18);
            this.chk_Use.TabIndex = 549;
            this.chk_Use.Text = "Use";
            this.chk_Use.UseVisualStyleBackColor = true;
            // 
            // cmb_Search
            // 
            this.cmb_Search.AddItemSeparator = ';';
            this.cmb_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Search.Caption = "";
            this.cmb_Search.CaptionHeight = 17;
            this.cmb_Search.CaptionStyle = style137;
            this.cmb_Search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Search.ColumnCaptionHeight = 18;
            this.cmb_Search.ColumnFooterHeight = 18;
            this.cmb_Search.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Search.ContentHeight = 16;
            this.cmb_Search.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Search.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Search.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Search.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Search.EditorHeight = 16;
            this.cmb_Search.EvenRowStyle = style138;
            this.cmb_Search.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Search.FooterStyle = style139;
            this.cmb_Search.HeadingStyle = style140;
            this.cmb_Search.HighLightRowStyle = style141;
            this.cmb_Search.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Search.Images"))));
            this.cmb_Search.ItemHeight = 15;
            this.cmb_Search.Location = new System.Drawing.Point(775, 35);
            this.cmb_Search.MatchEntryTimeout = ((long)(2000));
            this.cmb_Search.MaxDropDownItems = ((short)(5));
            this.cmb_Search.MaxLength = 32767;
            this.cmb_Search.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Search.Name = "cmb_Search";
            this.cmb_Search.OddRowStyle = style142;
            this.cmb_Search.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Search.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Search.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Search.SelectedStyle = style143;
            this.cmb_Search.Size = new System.Drawing.Size(220, 20);
            this.cmb_Search.Style = style144;
            this.cmb_Search.TabIndex = 347;
            this.cmb_Search.PropBag = resources.GetString("cmb_Search.PropBag");
            // 
            // lbl_Search
            // 
            this.lbl_Search.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.ImageIndex = 0;
            this.lbl_Search.ImageList = this.img_Label;
            this.lbl_Search.Location = new System.Drawing.Point(674, 35);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(100, 21);
            this.lbl_Search.TabIndex = 346;
            this.lbl_Search.Tag = "0";
            this.lbl_Search.Text = "Option";
            this.lbl_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_CSC_Vendor
            // 
            this.txt_CSC_Vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CSC_Vendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CSC_Vendor.Location = new System.Drawing.Point(775, 58);
            this.txt_CSC_Vendor.Name = "txt_CSC_Vendor";
            this.txt_CSC_Vendor.Size = new System.Drawing.Size(69, 21);
            this.txt_CSC_Vendor.TabIndex = 548;
            // 
            // lbl_CSCVendor
            // 
            this.lbl_CSCVendor.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_CSCVendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CSCVendor.ImageIndex = 0;
            this.lbl_CSCVendor.ImageList = this.img_Label;
            this.lbl_CSCVendor.Location = new System.Drawing.Point(674, 58);
            this.lbl_CSCVendor.Name = "lbl_CSCVendor";
            this.lbl_CSCVendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_CSCVendor.TabIndex = 545;
            this.lbl_CSCVendor.Tag = "1";
            this.lbl_CSCVendor.Text = "Web Vendor";
            this.lbl_CSCVendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_sabun
            // 
            this.txt_sabun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sabun.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sabun.Location = new System.Drawing.Point(109, 58);
            this.txt_sabun.Name = "txt_sabun";
            this.txt_sabun.Size = new System.Drawing.Size(210, 21);
            this.txt_sabun.TabIndex = 544;
            // 
            // txt_sabun_name
            // 
            this.txt_sabun_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sabun_name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sabun_name.Location = new System.Drawing.Point(441, 58);
            this.txt_sabun_name.Name = "txt_sabun_name";
            this.txt_sabun_name.Size = new System.Drawing.Size(210, 21);
            this.txt_sabun_name.TabIndex = 543;
            // 
            // lbl_sabun_name
            // 
            this.lbl_sabun_name.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_sabun_name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sabun_name.ImageIndex = 0;
            this.lbl_sabun_name.ImageList = this.img_Label;
            this.lbl_sabun_name.Location = new System.Drawing.Point(340, 58);
            this.lbl_sabun_name.Name = "lbl_sabun_name";
            this.lbl_sabun_name.Size = new System.Drawing.Size(100, 21);
            this.lbl_sabun_name.TabIndex = 542;
            this.lbl_sabun_name.Tag = "1";
            this.lbl_sabun_name.Text = "Sabun Name";
            this.lbl_sabun_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_openfile
            // 
            this.btn_openfile.BackColor = System.Drawing.SystemColors.Window;
            this.btn_openfile.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openfile.Location = new System.Drawing.Point(426, 36);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(21, 21);
            this.btn_openfile.TabIndex = 112;
            this.btn_openfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(983, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(24, 45);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(984, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 32);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(212, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1000, 40);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_title.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Navy;
            this.lbl_title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_title.Image")));
            this.lbl_title.Location = new System.Drawing.Point(0, 5);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(231, 30);
            this.lbl_title.TabIndex = 28;
            this.lbl_title.Text = "         Register SMS Employee";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(984, 73);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(136, 72);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1000, 18);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 73);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(168, 20);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 24);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(168, 55);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(152, 24);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(1000, 48);
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(472, 72);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(1000, 48);
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.fgrid_Main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fgrid_Main.AutoResize = false;
            this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Main.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            this.fgrid_Main.Location = new System.Drawing.Point(0, 159);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Rows.DefaultSize = 18;
            this.fgrid_Main.Rows.Fixed = 0;
            this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Main.Size = new System.Drawing.Size(1016, 483);
            this.fgrid_Main.StyleInfo = resources.GetString("fgrid_Main.StyleInfo");
            this.fgrid_Main.TabIndex = 319;
            // 
            // Form_SMS_EMP
            // 
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.fgrid_Main);
            this.Controls.Add(this.pnl_Top);
            this.Name = "Form_SMS_EMP";
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.fgrid_Main, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CSC_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.ResumeLayout(false);

        }

        
        public System.Windows.Forms.Panel pnl_Top;
        private C1.Win.C1List.C1Combo cmb_CSC_Vendor;
        private System.Windows.Forms.Label lbl_sabun;
        private C1.Win.C1List.C1Combo cmb_Factory;
        private System.Windows.Forms.Label lbl_factory;
        public System.Windows.Forms.Panel pnl_SearchImage;
        private System.Windows.Forms.CheckBox chk_Use;
        private C1.Win.C1List.C1Combo cmb_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox txt_CSC_Vendor;
        private System.Windows.Forms.Label lbl_CSCVendor;
        private System.Windows.Forms.TextBox txt_sabun;
        private System.Windows.Forms.TextBox txt_sabun_name;
        private System.Windows.Forms.Label lbl_sabun_name;
        private System.Windows.Forms.Label btn_openfile;
        public System.Windows.Forms.PictureBox picb_MR;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label lbl_title;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.PictureBox pictureBox8;
        public System.Windows.Forms.PictureBox pictureBox9;
        public COM.FSP fgrid_Main;
    
    }
}

