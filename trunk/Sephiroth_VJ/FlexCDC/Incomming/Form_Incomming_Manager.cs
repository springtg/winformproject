using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data;
using System.Data.OracleClient;

namespace FlexCDC.Incomming
{
	public class Form_Incomming_Manager : COM.PCHWinForm.Form_Top
	{
		#region Control Setting
        public System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label lbl_InUser;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Label lbl_InNo;
		private System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.DateTimePicker dtp_Fin_Ymd;
		private System.Windows.Forms.DateTimePicker dtp_Std_Ymd;
        private System.Windows.Forms.Label lbl_InDiv;
        private System.Windows.Forms.Label lbl_Vendor;
		private System.Windows.Forms.Label btn_Invoice;
		private System.Windows.Forms.Label btn_Barcode;
        private System.Windows.Forms.Label lbl_InDate;
		private System.Windows.Forms.Label lbl_PurDiv;
		public System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.Label btn_Dealing;
		private System.Windows.Forms.Label btn_Purchase;
		private System.Windows.Forms.ContextMenu ctMnu01;
		private System.Windows.Forms.MenuItem mnu_Mat;
        private System.Windows.Forms.MenuItem mnu_Bom;
        private C1.Win.C1List.C1Combo cmb_InUser;
        private C1.Win.C1List.C1Combo cmb_Factory;
        private C1.Win.C1List.C1Combo cmb_InDiv;
        private C1.Win.C1List.C1Combo cmb_Vendor;
        private C1.Win.C1List.C1Combo cmb_InNo;
        private C1.Win.C1List.C1Combo cmb_PurDiv;
		private System.ComponentModel.IContainer components = null;

		

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
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
		#endregion

		#region Designer
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Incomming_Manager));
            C1.Win.C1List.Style style41 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style42 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style43 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style44 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style45 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style46 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style47 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style48 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style33 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style34 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style35 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style36 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style37 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style38 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style39 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style40 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style25 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style26 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style27 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style28 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style29 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style30 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style31 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style32 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style17 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style18 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style19 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style20 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style21 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style22 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style23 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style24 = new C1.Win.C1List.Style();
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
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.btn_Purchase = new System.Windows.Forms.Label();
            this.btn_Invoice = new System.Windows.Forms.Label();
            this.btn_Barcode = new System.Windows.Forms.Label();
            this.btn_Dealing = new System.Windows.Forms.Label();
            this.lbl_Vendor = new System.Windows.Forms.Label();
            this.lbl_InDiv = new System.Windows.Forms.Label();
            this.lbl_PurDiv = new System.Windows.Forms.Label();
            this.dtp_Fin_Ymd = new System.Windows.Forms.DateTimePicker();
            this.dtp_Std_Ymd = new System.Windows.Forms.DateTimePicker();
            this.lbl_InDate = new System.Windows.Forms.Label();
            this.lbl_InUser = new System.Windows.Forms.Label();
            this.lbl_InNo = new System.Windows.Forms.Label();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.fgrid_Main = new COM.FSP();
            this.ctMnu01 = new System.Windows.Forms.ContextMenu();
            this.mnu_Mat = new System.Windows.Forms.MenuItem();
            this.mnu_Bom = new System.Windows.Forms.MenuItem();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.cmb_InUser = new C1.Win.C1List.C1Combo();
            this.cmb_InNo = new C1.Win.C1List.C1Combo();
            this.cmb_Vendor = new C1.Win.C1List.C1Combo();
            this.cmb_InDiv = new C1.Win.C1List.C1Combo();
            this.cmb_PurDiv = new C1.Win.C1List.C1Combo();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Top.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.pnl_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_InUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_InNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_InDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PurDiv)).BeginInit();
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
            // c1CommandLink1
            // 
            this.c1CommandLink1.Text = "Clear";
            // 
            // tbtn_New
            // 
            this.tbtn_New.Text = "";
            this.tbtn_New.ToolTipText = "";
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Text = "";
            this.tbtn_Search.ToolTipText = "";
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.Text = "";
            this.tbtn_Save.ToolTipText = "";
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
            // 
            // tbtn_Delete
            // 
            this.tbtn_Delete.Text = "";
            this.tbtn_Delete.ToolTipText = "";
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 644);
            this.stbar.Size = new System.Drawing.Size(1016, 22);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(952, 23);
            // 
            // tbtn_Print
            // 
            this.tbtn_Print.Text = "";
            this.tbtn_Print.ToolTipText = "";
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
            this.tbtn_Confirm.Text = "";
            this.tbtn_Confirm.ToolTipText = "";
            this.tbtn_Confirm.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Confirm_Click);
            // 
            // pnl_Top
            // 
            this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Top.Controls.Add(this.cmb_PurDiv);
            this.pnl_Top.Controls.Add(this.cmb_InDiv);
            this.pnl_Top.Controls.Add(this.cmb_Vendor);
            this.pnl_Top.Controls.Add(this.btn_Purchase);
            this.pnl_Top.Controls.Add(this.btn_Invoice);
            this.pnl_Top.Controls.Add(this.btn_Barcode);
            this.pnl_Top.Controls.Add(this.btn_Dealing);
            this.pnl_Top.Controls.Add(this.lbl_Vendor);
            this.pnl_Top.Controls.Add(this.lbl_InDiv);
            this.pnl_Top.Controls.Add(this.lbl_PurDiv);
            this.pnl_Top.Controls.Add(this.dtp_Fin_Ymd);
            this.pnl_Top.Controls.Add(this.dtp_Std_Ymd);
            this.pnl_Top.Controls.Add(this.lbl_InDate);
            this.pnl_Top.Controls.Add(this.lbl_InUser);
            this.pnl_Top.Controls.Add(this.lbl_InNo);
            this.pnl_Top.Controls.Add(this.lbl_factory);
            this.pnl_Top.Controls.Add(this.pnl_SearchImage);
            this.pnl_Top.Location = new System.Drawing.Point(0, 64);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_Top.Size = new System.Drawing.Size(1016, 95);
            this.pnl_Top.TabIndex = 125;
            // 
            // btn_Purchase
            // 
            this.btn_Purchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Purchase.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Purchase.Image = ((System.Drawing.Image)(resources.GetObject("btn_Purchase.Image")));
            this.btn_Purchase.Location = new System.Drawing.Point(790, 58);
            this.btn_Purchase.Name = "btn_Purchase";
            this.btn_Purchase.Size = new System.Drawing.Size(50, 24);
            this.btn_Purchase.TabIndex = 281;
            this.btn_Purchase.Text = "Pur.";
            this.btn_Purchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Purchase.Click += new System.EventHandler(this.btn_Purchase_Click);
            // 
            // btn_Invoice
            // 
            this.btn_Invoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Invoice.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Invoice.Image = ((System.Drawing.Image)(resources.GetObject("btn_Invoice.Image")));
            this.btn_Invoice.Location = new System.Drawing.Point(949, 58);
            this.btn_Invoice.Name = "btn_Invoice";
            this.btn_Invoice.Size = new System.Drawing.Size(50, 24);
            this.btn_Invoice.TabIndex = 280;
            this.btn_Invoice.Text = "Inv.";
            this.btn_Invoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Invoice.Click += new System.EventHandler(this.btn_Invoice_Click);
            // 
            // btn_Barcode
            // 
            this.btn_Barcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Barcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Barcode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Barcode.Image = ((System.Drawing.Image)(resources.GetObject("btn_Barcode.Image")));
            this.btn_Barcode.Location = new System.Drawing.Point(843, 58);
            this.btn_Barcode.Name = "btn_Barcode";
            this.btn_Barcode.Size = new System.Drawing.Size(50, 24);
            this.btn_Barcode.TabIndex = 279;
            this.btn_Barcode.Text = "Bar.";
            this.btn_Barcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Barcode.Click += new System.EventHandler(this.btn_Barcode_Click);
            // 
            // btn_Dealing
            // 
            this.btn_Dealing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Dealing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Dealing.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dealing.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dealing.Image")));
            this.btn_Dealing.Location = new System.Drawing.Point(896, 58);
            this.btn_Dealing.Name = "btn_Dealing";
            this.btn_Dealing.Size = new System.Drawing.Size(50, 24);
            this.btn_Dealing.TabIndex = 278;
            this.btn_Dealing.Text = "Deal";
            this.btn_Dealing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Dealing.Click += new System.EventHandler(this.btn_Dealing_Click);
            // 
            // lbl_Vendor
            // 
            this.lbl_Vendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vendor.ImageIndex = 0;
            this.lbl_Vendor.ImageList = this.img_Label;
            this.lbl_Vendor.Location = new System.Drawing.Point(16, 58);
            this.lbl_Vendor.Name = "lbl_Vendor";
            this.lbl_Vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_Vendor.TabIndex = 276;
            this.lbl_Vendor.Tag = "1";
            this.lbl_Vendor.Text = "Vendor";
            this.lbl_Vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_InDiv
            // 
            this.lbl_InDiv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InDiv.ImageIndex = 0;
            this.lbl_InDiv.ImageList = this.img_Label;
            this.lbl_InDiv.Location = new System.Drawing.Point(248, 58);
            this.lbl_InDiv.Name = "lbl_InDiv";
            this.lbl_InDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_InDiv.TabIndex = 274;
            this.lbl_InDiv.Tag = "1";
            this.lbl_InDiv.Text = "IN. Division";
            this.lbl_InDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PurDiv
            // 
            this.lbl_PurDiv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PurDiv.ImageIndex = 0;
            this.lbl_PurDiv.ImageList = this.img_Label;
            this.lbl_PurDiv.Location = new System.Drawing.Point(480, 58);
            this.lbl_PurDiv.Name = "lbl_PurDiv";
            this.lbl_PurDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_PurDiv.TabIndex = 272;
            this.lbl_PurDiv.Tag = "1";
            this.lbl_PurDiv.Text = "Pur. Division";
            this.lbl_PurDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_Fin_Ymd
            // 
            this.dtp_Fin_Ymd.CustomFormat = "yyyyMMdd";
            this.dtp_Fin_Ymd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Fin_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Fin_Ymd.Location = new System.Drawing.Point(679, 36);
            this.dtp_Fin_Ymd.Name = "dtp_Fin_Ymd";
            this.dtp_Fin_Ymd.Size = new System.Drawing.Size(87, 21);
            this.dtp_Fin_Ymd.TabIndex = 271;
            this.dtp_Fin_Ymd.CloseUp += new System.EventHandler(this.dtp_Fin_Ymd_CloseUp);
            // 
            // dtp_Std_Ymd
            // 
            this.dtp_Std_Ymd.CustomFormat = "yyyyMMdd";
            this.dtp_Std_Ymd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Std_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Std_Ymd.Location = new System.Drawing.Point(581, 36);
            this.dtp_Std_Ymd.Name = "dtp_Std_Ymd";
            this.dtp_Std_Ymd.Size = new System.Drawing.Size(88, 21);
            this.dtp_Std_Ymd.TabIndex = 270;
            this.dtp_Std_Ymd.CloseUp += new System.EventHandler(this.dtp_Std_Ymd_CloseUp);
            // 
            // lbl_InDate
            // 
            this.lbl_InDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InDate.ImageIndex = 0;
            this.lbl_InDate.ImageList = this.img_Label;
            this.lbl_InDate.Location = new System.Drawing.Point(480, 36);
            this.lbl_InDate.Name = "lbl_InDate";
            this.lbl_InDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_InDate.TabIndex = 267;
            this.lbl_InDate.Tag = "1";
            this.lbl_InDate.Text = "IN. Date";
            this.lbl_InDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_InUser
            // 
            this.lbl_InUser.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InUser.ImageIndex = 0;
            this.lbl_InUser.ImageList = this.img_Label;
            this.lbl_InUser.Location = new System.Drawing.Point(248, 36);
            this.lbl_InUser.Name = "lbl_InUser";
            this.lbl_InUser.Size = new System.Drawing.Size(100, 21);
            this.lbl_InUser.TabIndex = 265;
            this.lbl_InUser.Tag = "1";
            this.lbl_InUser.Text = "IN. User";
            this.lbl_InUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_InNo
            // 
            this.lbl_InNo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InNo.ImageIndex = 0;
            this.lbl_InNo.ImageList = this.img_Label;
            this.lbl_InNo.Location = new System.Drawing.Point(767, 36);
            this.lbl_InNo.Name = "lbl_InNo";
            this.lbl_InNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_InNo.TabIndex = 204;
            this.lbl_InNo.Tag = "1";
            this.lbl_InNo.Text = "IN. No";
            this.lbl_InNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(16, 36);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 203;
            this.lbl_factory.Tag = "1";
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.cmb_InNo);
            this.pnl_SearchImage.Controls.Add(this.cmb_InUser);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.lbl);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.pictureBox2);
            this.pnl_SearchImage.Controls.Add(this.pictureBox3);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.Controls.Add(this.pictureBox4);
            this.pnl_SearchImage.Controls.Add(this.pictureBox5);
            this.pnl_SearchImage.Controls.Add(this.pictureBox6);
            this.pnl_SearchImage.Controls.Add(this.pictureBox7);
            this.pnl_SearchImage.Controls.Add(this.pictureBox1);
            this.pnl_SearchImage.Controls.Add(this.pictureBox9);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 87);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(658, 36);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(16, 16);
            this.lbl.TabIndex = 29;
            this.lbl.Text = "~";
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(983, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(24, 44);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pictureBox3.Location = new System.Drawing.Point(224, 0);
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
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(231, 30);
            this.lbl_title.TabIndex = 28;
            this.lbl_title.Text = "      Incoming Information";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(984, 72);
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
            this.pictureBox5.Location = new System.Drawing.Point(144, 71);
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
            this.pictureBox6.Location = new System.Drawing.Point(0, 72);
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
            this.pictureBox7.Size = new System.Drawing.Size(168, 54);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 47);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
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
            this.pictureBox9.Size = new System.Drawing.Size(1000, 47);
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            // 
            // pnl_Body
            // 
            this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Body.Controls.Add(this.fgrid_Main);
            this.pnl_Body.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Body.Location = new System.Drawing.Point(0, 159);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(1016, 485);
            this.pnl_Body.TabIndex = 139;
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.fgrid_Main.AutoResize = false;
            this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Main.ContextMenu = this.ctMnu01;
            this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Main.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            this.fgrid_Main.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Rows.DefaultSize = 18;
            this.fgrid_Main.Rows.Fixed = 0;
            this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Main.Size = new System.Drawing.Size(1016, 485);
            this.fgrid_Main.StyleInfo = resources.GetString("fgrid_Main.StyleInfo");
            this.fgrid_Main.TabIndex = 318;
            this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
            this.fgrid_Main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_BeforeEdit);
            // 
            // ctMnu01
            // 
            this.ctMnu01.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_Mat,
            this.mnu_Bom});
            // 
            // mnu_Mat
            // 
            this.mnu_Mat.Index = 0;
            this.mnu_Mat.Text = "Material";
            this.mnu_Mat.Click += new System.EventHandler(this.mnu_Mat_Click);
            // 
            // mnu_Bom
            // 
            this.mnu_Bom.Index = 1;
            this.mnu_Bom.Text = "BOM";
            this.mnu_Bom.Click += new System.EventHandler(this.mnu_Bom_Click);
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style41;
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
            this.cmb_Factory.EvenRowStyle = style42;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style43;
            this.cmb_Factory.HeadingStyle = style44;
            this.cmb_Factory.HighLightRowStyle = style45;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(109, 36);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style46;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style47;
            this.cmb_Factory.Size = new System.Drawing.Size(130, 20);
            this.cmb_Factory.Style = style48;
            this.cmb_Factory.TabIndex = 282;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // cmb_InUser
            // 
            this.cmb_InUser.AddItemSeparator = ';';
            this.cmb_InUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_InUser.Caption = "";
            this.cmb_InUser.CaptionHeight = 17;
            this.cmb_InUser.CaptionStyle = style33;
            this.cmb_InUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_InUser.ColumnCaptionHeight = 18;
            this.cmb_InUser.ColumnFooterHeight = 18;
            this.cmb_InUser.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_InUser.ContentHeight = 16;
            this.cmb_InUser.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_InUser.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_InUser.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_InUser.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_InUser.EditorHeight = 16;
            this.cmb_InUser.EvenRowStyle = style34;
            this.cmb_InUser.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_InUser.FooterStyle = style35;
            this.cmb_InUser.HeadingStyle = style36;
            this.cmb_InUser.HighLightRowStyle = style37;
            this.cmb_InUser.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_InUser.Images"))));
            this.cmb_InUser.ItemHeight = 15;
            this.cmb_InUser.Location = new System.Drawing.Point(341, 37);
            this.cmb_InUser.MatchEntryTimeout = ((long)(2000));
            this.cmb_InUser.MaxDropDownItems = ((short)(5));
            this.cmb_InUser.MaxLength = 32767;
            this.cmb_InUser.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_InUser.Name = "cmb_InUser";
            this.cmb_InUser.OddRowStyle = style38;
            this.cmb_InUser.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_InUser.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_InUser.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_InUser.SelectedStyle = style39;
            this.cmb_InUser.Size = new System.Drawing.Size(130, 20);
            this.cmb_InUser.Style = style40;
            this.cmb_InUser.TabIndex = 283;
            this.cmb_InUser.SelectedValueChanged += new System.EventHandler(this.cmb_InUser_SelectedValueChanged);
            this.cmb_InUser.PropBag = resources.GetString("cmb_InUser.PropBag");
            // 
            // cmb_InNo
            // 
            this.cmb_InNo.AddItemSeparator = ';';
            this.cmb_InNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_InNo.Caption = "";
            this.cmb_InNo.CaptionHeight = 17;
            this.cmb_InNo.CaptionStyle = style25;
            this.cmb_InNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_InNo.ColumnCaptionHeight = 18;
            this.cmb_InNo.ColumnFooterHeight = 18;
            this.cmb_InNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_InNo.ContentHeight = 16;
            this.cmb_InNo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_InNo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_InNo.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_InNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_InNo.EditorHeight = 16;
            this.cmb_InNo.EvenRowStyle = style26;
            this.cmb_InNo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_InNo.FooterStyle = style27;
            this.cmb_InNo.HeadingStyle = style28;
            this.cmb_InNo.HighLightRowStyle = style29;
            this.cmb_InNo.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_InNo.Images"))));
            this.cmb_InNo.ItemHeight = 15;
            this.cmb_InNo.Location = new System.Drawing.Point(860, 37);
            this.cmb_InNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_InNo.MaxDropDownItems = ((short)(5));
            this.cmb_InNo.MaxLength = 32767;
            this.cmb_InNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_InNo.Name = "cmb_InNo";
            this.cmb_InNo.OddRowStyle = style30;
            this.cmb_InNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_InNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_InNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_InNo.SelectedStyle = style31;
            this.cmb_InNo.Size = new System.Drawing.Size(130, 20);
            this.cmb_InNo.Style = style32;
            this.cmb_InNo.TabIndex = 284;
            this.cmb_InNo.SelectedValueChanged += new System.EventHandler(this.cmb_InNo_SelectedValueChanged);
            this.cmb_InNo.PropBag = resources.GetString("cmb_InNo.PropBag");
            // 
            // cmb_Vendor
            // 
            this.cmb_Vendor.AddItemSeparator = ';';
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
            this.cmb_Vendor.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Vendor.EditorHeight = 16;
            this.cmb_Vendor.EvenRowStyle = style18;
            this.cmb_Vendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vendor.FooterStyle = style19;
            this.cmb_Vendor.HeadingStyle = style20;
            this.cmb_Vendor.HighLightRowStyle = style21;
            this.cmb_Vendor.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Vendor.Images"))));
            this.cmb_Vendor.ItemHeight = 15;
            this.cmb_Vendor.Location = new System.Drawing.Point(117, 58);
            this.cmb_Vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_Vendor.MaxDropDownItems = ((short)(5));
            this.cmb_Vendor.MaxLength = 32767;
            this.cmb_Vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Vendor.Name = "cmb_Vendor";
            this.cmb_Vendor.OddRowStyle = style22;
            this.cmb_Vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.SelectedStyle = style23;
            this.cmb_Vendor.Size = new System.Drawing.Size(130, 20);
            this.cmb_Vendor.Style = style24;
            this.cmb_Vendor.TabIndex = 283;
            this.cmb_Vendor.PropBag = resources.GetString("cmb_Vendor.PropBag");
            // 
            // cmb_InDiv
            // 
            this.cmb_InDiv.AddItemSeparator = ';';
            this.cmb_InDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_InDiv.Caption = "";
            this.cmb_InDiv.CaptionHeight = 17;
            this.cmb_InDiv.CaptionStyle = style9;
            this.cmb_InDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_InDiv.ColumnCaptionHeight = 18;
            this.cmb_InDiv.ColumnFooterHeight = 18;
            this.cmb_InDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_InDiv.ContentHeight = 16;
            this.cmb_InDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_InDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_InDiv.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_InDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_InDiv.EditorHeight = 16;
            this.cmb_InDiv.EvenRowStyle = style10;
            this.cmb_InDiv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_InDiv.FooterStyle = style11;
            this.cmb_InDiv.HeadingStyle = style12;
            this.cmb_InDiv.HighLightRowStyle = style13;
            this.cmb_InDiv.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_InDiv.Images"))));
            this.cmb_InDiv.ItemHeight = 15;
            this.cmb_InDiv.Location = new System.Drawing.Point(349, 59);
            this.cmb_InDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_InDiv.MaxDropDownItems = ((short)(5));
            this.cmb_InDiv.MaxLength = 32767;
            this.cmb_InDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_InDiv.Name = "cmb_InDiv";
            this.cmb_InDiv.OddRowStyle = style14;
            this.cmb_InDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_InDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_InDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_InDiv.SelectedStyle = style15;
            this.cmb_InDiv.Size = new System.Drawing.Size(130, 20);
            this.cmb_InDiv.Style = style16;
            this.cmb_InDiv.TabIndex = 284;
            this.cmb_InDiv.PropBag = resources.GetString("cmb_InDiv.PropBag");
            // 
            // cmb_PurDiv
            // 
            this.cmb_PurDiv.AddItemSeparator = ';';
            this.cmb_PurDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_PurDiv.Caption = "";
            this.cmb_PurDiv.CaptionHeight = 17;
            this.cmb_PurDiv.CaptionStyle = style1;
            this.cmb_PurDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_PurDiv.ColumnCaptionHeight = 18;
            this.cmb_PurDiv.ColumnFooterHeight = 18;
            this.cmb_PurDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_PurDiv.ContentHeight = 16;
            this.cmb_PurDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_PurDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_PurDiv.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_PurDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_PurDiv.EditorHeight = 16;
            this.cmb_PurDiv.EvenRowStyle = style2;
            this.cmb_PurDiv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_PurDiv.FooterStyle = style3;
            this.cmb_PurDiv.HeadingStyle = style4;
            this.cmb_PurDiv.HighLightRowStyle = style5;
            this.cmb_PurDiv.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_PurDiv.Images"))));
            this.cmb_PurDiv.ItemHeight = 15;
            this.cmb_PurDiv.Location = new System.Drawing.Point(581, 59);
            this.cmb_PurDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_PurDiv.MaxDropDownItems = ((short)(5));
            this.cmb_PurDiv.MaxLength = 32767;
            this.cmb_PurDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_PurDiv.Name = "cmb_PurDiv";
            this.cmb_PurDiv.OddRowStyle = style6;
            this.cmb_PurDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_PurDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_PurDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_PurDiv.SelectedStyle = style7;
            this.cmb_PurDiv.Size = new System.Drawing.Size(184, 20);
            this.cmb_PurDiv.Style = style8;
            this.cmb_PurDiv.TabIndex = 285;
            this.cmb_PurDiv.PropBag = resources.GetString("cmb_PurDiv.PropBag");
            // 
            // Form_Incomming_Manager
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_Body);
            this.Controls.Add(this.pnl_Top);
            this.Name = "Form_Incomming_Manager";
            this.Load += new System.EventHandler(this.Form_Incomming_Manager_Load);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.pnl_Body, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.pnl_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_InUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_InNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_InDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PurDiv)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region User Define Variable

		private COM.OraDB MyOraDB = new COM.OraDB();		
	    public bool _Update_Flag  = true;
        private bool _first_flg = true;
		private string _Value_In     = "";
		private string _Bl_No        = "";
		private string _Inv_No       = "";
		private string _Dec_No       = "";
		private string _Dec_Ymd      = "";
		private string _Pur_Currency = "";
		private string _Pur_Price    = "";
		private string _Remark       = "";
		public string _In_No         = "";		
		
		#endregion

        #region Resource
        public Form_Incomming_Manager()
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();

            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
        }
        #endregion

        #region Create Data
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_InNo.SelectedValue.ToString().Trim() == "" || cmb_InNo.Text.ToString().Substring(0, 1).Trim() == "C")
                {
                    fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
                }

                if (COM.ComVar.This_CDC_Factory.Equals("DS"))
                {
                    Incomming.Form_Purchase_Incomming_List PurchaseList = new FlexCDC.Incomming.Form_Purchase_Incomming_List(this);
                    PurchaseList.ShowDialog();
                }
                else
                {
                    Incomming.Form_Barcode_Incomming_List PurchaseList = new FlexCDC.Incomming.Form_Barcode_Incomming_List(this);
                    PurchaseList.ShowDialog();
                }
            }
            catch
            {
                this.Cursor = Cursors.Default;

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void btn_Purchase_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_InNo.SelectedValue.ToString().Trim() == "" || cmb_InNo.Text.ToString().Substring(0, 1).Trim() == "C")
                {
                    fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
                }

                Incomming.Form_Purchase_Incomming_List PurchaseList = new FlexCDC.Incomming.Form_Purchase_Incomming_List(this);
                PurchaseList.ShowDialog();
            }
            catch
            {
                this.Cursor = Cursors.Default;

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btn_Barcode_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_InNo.SelectedValue.ToString().Trim() == "" || cmb_InNo.Text.ToString().Substring(0, 1).Trim() == "C")
                {
                    fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
                }

                Incomming.Form_Barcode_Incomming_List BarcodeList = new FlexCDC.Incomming.Form_Barcode_Incomming_List(this);
                BarcodeList.ShowDialog();
            }
            catch
            {
                this.Cursor = Cursors.Default;

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btn_Dealing_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_InNo.SelectedValue.ToString().Trim() == "" || cmb_InNo.Text.ToString().Substring(0, 1).Trim() == "C")
                {
                    fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
                }

                Incomming.Form_Dealing_Incomming_List Dealing = new FlexCDC.Incomming.Form_Dealing_Incomming_List(this);
                Dealing.ShowDialog();
            }
            catch
            {
                this.Cursor = Cursors.Default;

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        private void btn_Invoice_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_InNo.SelectedValue.ToString().Trim() == "" || cmb_InNo.Text.ToString().Substring(0, 1).Trim() == "C")
                {
                    fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
                }

                Incomming.Form_Invoice_Incomming_List inv = new FlexCDC.Incomming.Form_Invoice_Incomming_List(this);
                inv.ShowDialog();
            }
            catch
            {
                this.Cursor = Cursors.Default;

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region Form Loading
        private void Form_Incomming_Manager_Load(object sender, System.EventArgs e)
        {
            try
            {
                //factory 
                DataTable dt_list = COM.ComFunction.Select_Factory_List_CDC();
                COM.ComCtl.Set_Factory_List(dt_list, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
            }
            catch
            {

            }
        }
        private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_Factory.SelectedIndex == -1)
                    return;

                COM.ComVar.This_CDC_Factory = cmb_Factory.SelectedValue.ToString();

                Init_Form();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }		

        private void Init_Form()
		{		
			this.Text = "PCC_Incoming Manager";
			this.lbl_MainTitle.Text = "PCC_Incoming Manager";
			this.lbl_title.Text = "      Incoming Information";
			ClassLib.ComFunction.SetLangDic(this); 

			#region Button Setting
			tbtn_Append.Enabled  = false;
			tbtn_Color.Enabled   = false;
			tbtn_Delete.Enabled  = false;
			tbtn_Create.Enabled  = false;
			tbtn_Insert.Enabled  = false;
			//tbtn_Print.Enabled   = false;
            tbtn_Confirm.Enabled = false;			
			#endregion
			
			#region ComboBox Setting	
            _first_flg = true;
			dtp_Std_Ymd.Value = DateTime.Today;
			dtp_Fin_Ymd.Value = DateTime.Today;

            //IN. User Setting
			DataTable dt_ret = Select_SXI_In_User(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text);
			cmb_InUser.Enabled = true;
			COM.ComCtl.Set_ComboList(dt_ret, cmb_InUser, 0, 0, true, 0, 130);
			cmb_InUser.SelectedIndex = 0;

			//Pur. Division Setting
            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_MatDiv);
			COM.ComCtl.Set_ComboList(dt_ret, cmb_PurDiv, 1, 2, true, 0, 184);
			cmb_PurDiv.SelectedIndex = 0;					

			//IN. Division Setting 
			dt_ret =  COM.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), COM.ComVar.CxCDC_Incomming_In_Div);
			COM.ComCtl.Set_ComboList(dt_ret, cmb_InDiv, 1, 2, true, 0, 130);
			cmb_InDiv.SelectedIndex = 0;		

			dt_ret.Dispose();
            _first_flg = false;
			#endregion

			#region Grid Setting
			fgrid_Main.Set_Grid_CDC("SXI_IN_LIST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_Main.Set_Action_Image(img_Action);
			fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;		
			fgrid_Main.Tree.Column = (int)ClassLib.TBSXI_IN_LIST.IxITEM01;			
			#endregion			

            if (!COM.ComVar.This_CDC_Factory.Equals("DS"))
            {
                btn_Dealing.Enabled = false;
                btn_Invoice.Enabled = false;
                btn_Purchase.Enabled = false;
            }
		}

        private DataTable Select_SXI_In_User(string arg_factory, string arg_std_ymd, string arg_fin_ymd)
        {

            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXI_IN_01_SELECT.SELECT_SXI_IN_USER";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_STD_YMD";
            MyOraDB.Parameter_Name[2] = "ARG_FIN_YMD";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_std_ymd;
            MyOraDB.Parameter_Values[2] = arg_fin_ymd;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;
            return DS_Ret.Tables[MyOraDB.Process_Name];

        }
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Display_Grid();
            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
            }
        }
        private void Display_Grid()
		{		
			
			fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;		

            string arg_factory   = cmb_Factory.SelectedValue.ToString();
            string arg_from_date = dtp_Std_Ymd.Text;
            string arg_to_date   = dtp_Fin_Ymd.Text;
            string arg_in_no     = cmb_InNo.SelectedValue.ToString();
            string arg_vendor    = (cmb_Vendor.SelectedValue == null)?"":cmb_Vendor.SelectedValue.ToString();
            string arg_in_div    = cmb_InDiv.SelectedValue.ToString();
            string arg_pur_div   = cmb_PurDiv.SelectedValue.ToString();
            string arg_in_user   = cmb_InUser.SelectedValue.ToString();

            DataTable dt_list = Select_SXI_In_List(arg_factory, arg_from_date, arg_to_date, arg_in_no, arg_vendor, arg_in_div, arg_pur_div, arg_in_user);
			
            #region Display Datalist 
			for(int i = 0; i < dt_list.Rows.Count; i++)
			{
				
				int tree_level    = int.Parse(dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXI_IN_LIST.IxLEVEL].ToString());				
				fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, tree_level);	
					
				#region Level에 따른 Grid Edit & BackColor 설정 
				if(tree_level == 1)
				{					
					fgrid_Main.Rows[fgrid_Main.Rows.Count -1].AllowEditing = true;
					fgrid_Main.Rows[fgrid_Main.Rows.Count -1].StyleNew.BackColor = Color.White;						
				}
				else if( tree_level == 2 )
				{
					fgrid_Main.Rows[fgrid_Main.Rows.Count -1].AllowEditing = false;
					fgrid_Main.Rows[fgrid_Main.Rows.Count -1].StyleNew.BackColor = Color.WhiteSmoke;
				}
				#endregion

				for(int j=0; j<dt_list.Columns.Count; j++)
				{
					fgrid_Main[fgrid_Main.Rows.Count-1,j] = dt_list.Rows[i].ItemArray[j].ToString();					
				}
				if(fgrid_Main[fgrid_Main.Rows.Count -1, (int)ClassLib.TBSXI_IN_LIST.IxSTATUS].ToString() == "Comfirmed")
				{
					fgrid_Main.Rows[fgrid_Main.Rows.Count -1].AllowEditing = false;
				}
			
			}
			#endregion	
		
			fgrid_Main.Tree.Show(1);           
		}

        private DataTable Select_SXI_In_List(string arg_factory, string arg_std_ymd, string arg_fin_ymd, string arg_in_no, string arg_vendor, string arg_in_div, string arg_pur_div, string arg_in_user)
        {

            MyOraDB.ReDim_Parameter(9);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXI_IN_01_SELECT.SELECT_SXI_IN_LIST";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_STD_YMD";
            MyOraDB.Parameter_Name[2] = "ARG_FIN_YMD";
            MyOraDB.Parameter_Name[3] = "ARG_IN_NO";
            MyOraDB.Parameter_Name[4] = "ARG_VENDOR";
            MyOraDB.Parameter_Name[5] = "ARG_IN_DIV";
            MyOraDB.Parameter_Name[6] = "ARG_PUR_DIV";
            MyOraDB.Parameter_Name[7] = "ARG_IN_USER";
            MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_std_ymd;
            MyOraDB.Parameter_Values[2] = arg_fin_ymd;
            MyOraDB.Parameter_Values[3] = arg_in_no;
            MyOraDB.Parameter_Values[4] = arg_vendor;
            MyOraDB.Parameter_Values[5] = arg_in_div;
            MyOraDB.Parameter_Values[6] = arg_pur_div;
            MyOraDB.Parameter_Values[7] = arg_in_user;
            MyOraDB.Parameter_Values[8] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();
            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (fgrid_Main.Rows.Count == fgrid_Main.Rows.Fixed)
                    return;
                //if(fgrid_Main.Rows.Count > fgrid_Main.Rows.Fixed)
                Save_Data();
                tbtn_Confirm.Enabled = true;
                COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSave, this);
            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void Save_Data()
		{
			//행 수정 상태 해제
			fgrid_Main.Select(fgrid_Main.Selection.r1, 0, fgrid_Main.Selection.r1, fgrid_Main.Cols.Count - 1, false);		
			
            DataTable dt_list = Select_Fn_Get_In_No(cmb_Factory.SelectedValue.ToString());						    
			_In_No = dt_list.Rows[0].ItemArray[0].ToString();

			bool InsertFlag = false;		

			#region Data Save
			for(int i = fgrid_Main.Rows.Fixed ; i < fgrid_Main.Rows.Count; i++)
			{				
				#region Update Data
				if(fgrid_Main[i,(int)ClassLib.TBSXI_IN_LIST.IxDIVISION].ToString() == "U")
				{					

					if(fgrid_Main[i,(int)ClassLib.TBSXI_IN_LIST.IxLEVEL].ToString() =="1")
					{
						double Value_Pur     = Convert.ToDouble( fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_PUR].ToString());
						double Value_Prev_In = Convert.ToDouble( fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_PREV_IN].ToString());
						double Value_In      = Convert.ToDouble( fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_IN].ToString());
                        
						if(Value_Pur >= Value_Prev_In + Value_In)
						{
							#region Update Data 
							_In_No    = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxIN_NO].ToString();
							_Value_In = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_IN].ToString();
							_Bl_No    = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxBL_NO].ToString();
							_Inv_No   = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxINV_NO].ToString();   
							_Dec_No   = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxDEC_NO].ToString(); 
							_Dec_Ymd  = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxDEC_YMD].ToString();
							_Pur_Currency = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxPUR_CURRENCY].ToString();
							_Pur_Price = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxPUR_PRICE].ToString();
							_Remark   = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxREMARKS].ToString(); 
							#endregion

                            Save_SXI_In_Tail(fgrid_Main, i);                                

							fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxDIVISION] = "";		
						}
						else 
						{						
							ClassLib.ComFunction.User_Message("Line : "+ i + "\r\n\r\n"
								+ " Material Name : "+ fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxITEM01].ToString() + "    Is Wrong Value. "+ "\r\n\r\n"
								+ " Save Failed..",
								"Save_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);                                
							break;
						}
					}
					else if(fgrid_Main[i,(int)ClassLib.TBSXI_IN_LIST.IxLEVEL].ToString() == "2")
					{							
						fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxDIVISION] = "";							
					}	
				}		
				#endregion				
				
				#region Insert Data
				if(fgrid_Main[i,(int)ClassLib.TBSXI_IN_LIST.IxDIVISION].ToString() == "I")
				{				
					if(fgrid_Main[i,(int)ClassLib.TBSXI_IN_LIST.IxLEVEL].ToString() =="1")
					{	
						double Value_Pur = Convert.ToDouble( fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_PUR].ToString());
						double Value_Prev_In = Convert.ToDouble( fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_PREV_IN].ToString());
						double Value_In = Convert.ToDouble( fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_IN].ToString());

                        InsertFlag = true;
						if(Value_Pur >= Value_Prev_In + Value_In)
						{
							_Value_In     = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_IN].ToString();
							_Bl_No        = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxBL_NO].ToString();
							_Inv_No       = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxINV_NO].ToString();   
							_Dec_No       = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxDEC_NO].ToString(); 
							_Dec_Ymd      = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxDEC_YMD].ToString();
							_Pur_Currency = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxPUR_CURRENCY].ToString();
							_Pur_Price    = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxPUR_PRICE].ToString();
							_Remark       = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxREMARKS].ToString();

                            Insert_SXI_In_Tail(fgrid_Main, i, _In_No);
                            
							fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxDIVISION] = "";	
						}
						else 
						{								
							ClassLib.ComFunction.User_Message("Line : "+ i + "\r\n\r\n"
								+ " Material Name : "+ fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxITEM01].ToString() + "    Is Wrong Value. "+ "\r\n\r\n"
								+ " Save Failed..",
								"Save_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            InsertFlag = false;
							break;								
						}

					}					
					else if(fgrid_Main[i,(int)ClassLib.TBSXI_IN_LIST.IxLEVEL].ToString() == "2")
					{
                        fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxDIVISION] = "";
					}										
				
				}
				#endregion														
			}
	
			Insert_SXI_In_Head( _In_No );

            if (InsertFlag)
			{		
				#region ComboBox Setting
				//IN. User Setting
				DataTable dt_ret = Select_SXI_In_User(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text);
				cmb_InUser.Enabled = true;
				COM.ComCtl.Set_ComboList(dt_ret, cmb_InUser, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
				cmb_InUser.SelectedIndex = 0;

                //IN. Number Setting
                dt_ret = Select_Get_In_No(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text, cmb_InUser.SelectedValue.ToString());
                COM.ComCtl.Set_ComboList(dt_ret, cmb_InNo, 0, 1, true, 0, 200);
                cmb_InNo.SelectedIndex = 1;
                                
				dt_ret.Dispose();
				#endregion		
				
                Display_Grid();				
			}				
			#endregion
		}
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string mrd_Filename = "";
                string sPara = "";
                string[] arg_value = new string[8];
                arg_value[0] = cmb_Factory.SelectedValue.ToString();
                arg_value[1] = dtp_Std_Ymd.Text;
                arg_value[2] = dtp_Fin_Ymd.Text;
                arg_value[3] = cmb_InNo.SelectedValue.ToString();
                arg_value[4] = (cmb_Vendor.SelectedValue == null) ? "" : cmb_Vendor.SelectedValue.ToString();
                arg_value[5] = cmb_InDiv.SelectedValue.ToString();
                arg_value[6] = cmb_PurDiv.SelectedValue.ToString();
                arg_value[7] = cmb_InUser.SelectedValue.ToString();

                sPara = " /rp " + "[" + arg_value[0] + "]"
                               + " [" + arg_value[1] + "]"
                               + " [" + arg_value[2] + "]"
                               + " [" + arg_value[3] + "]"
                               + " [" + arg_value[4] + "]"
                               + " [" + arg_value[5] + "]"
                               + " [" + arg_value[6] + "]"
                               + " [" + arg_value[7] + "]";

                if (ClassLib.ComVar.This_Factory == "DS")
                {
                    //if (cmb_pur_div.SelectedValue.ToString() == "12")
                    //    mrd_Filename = Application.StartupPath + @"\Order_sheet_list_new_02" + ".mrd";
                    //else if (cmb_pur_div.SelectedValue.ToString() == "21")
                    //    mrd_Filename = Application.StartupPath + @"\Order_sheet_list_import_new" + ".mrd";
                }
                else if (ClassLib.ComVar.This_Factory == "VJ")
                {
                    //if (cmb_pur_div.SelectedValue.ToString() == "12")
                    mrd_Filename = Application.StartupPath + @"\Incoming_List_Mat_VJ" + ".mrd";
                    // else if (cmb_pur_div.SelectedValue.ToString() == "21")
                    // mrd_Filename = Application.StartupPath + @"\Order_sheet_list_import_VJ_new" + ".mrd";
                }
                else if (ClassLib.ComVar.This_Factory == "QD")
                {
                    //if (cmb_pur_div.SelectedValue.ToString() == "12")
                    //    mrd_Filename = Application.StartupPath + @"\Order_sheet_list_QD_new" + ".mrd";
                    //else if (cmb_pur_div.SelectedValue.ToString() == "21")
                    //    mrd_Filename = Application.StartupPath + @"\Order_sheet_list_import_QD_new" + ".mrd";
                }

                FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                report.ShowDialog();
            }
                
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }
        private DataTable Select_Fn_Get_In_No(string arg_factory)
        {

            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXI_IN_01_SELECT.SELECT_FN_GET_IN_NO";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_YMD";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = dtp_Std_Ymd.Text;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];

        }
        private DataTable Select_Get_In_Ymd(string arg_factory)
        {

            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXI_IN_01_SELECT.SELECT_GET_IN_YMD";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];

        }
        private void Insert_SXI_In_Tail(C1FlexGrid arg_fgrid, int arg_rowcnt, string arg_in_no)
        {

            MyOraDB.ReDim_Parameter(13);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXI_IN_01.INSERT_SXI_IN_TAIL";


            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_IN_NO";
            MyOraDB.Parameter_Name[2] = "ARG_IN_DIV";
            MyOraDB.Parameter_Name[3] = "ARG_VALUE_IN";
            MyOraDB.Parameter_Name[4] = "ARG_BAR_CODE";
            MyOraDB.Parameter_Name[5] = "ARG_BL_NO";
            MyOraDB.Parameter_Name[6] = "ARG_INV_NO";
            MyOraDB.Parameter_Name[7] = "ARG_DEC_NO";
            MyOraDB.Parameter_Name[8] = "ARG_DEC_YMD";
            MyOraDB.Parameter_Name[9] = "ARG_PUR_CURRENCY";
            MyOraDB.Parameter_Name[10] = "ARG_PUR_PRICE";
            MyOraDB.Parameter_Name[11] = "ARG_REMARKS";
            MyOraDB.Parameter_Name[12] = "ARG_UPD_USER";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = arg_in_no;
            MyOraDB.Parameter_Values[2] = fgrid_Main[arg_rowcnt, (int)ClassLib.TBSXI_IN_LIST.IxIN_DIV].ToString();
            MyOraDB.Parameter_Values[3] = _Value_In;
            MyOraDB.Parameter_Values[4] = fgrid_Main[arg_rowcnt, (int)ClassLib.TBSXI_IN_LIST.IxBAR_CODE].ToString();
            MyOraDB.Parameter_Values[5] = _Bl_No;
            MyOraDB.Parameter_Values[6] = _Inv_No;
            MyOraDB.Parameter_Values[7] = _Dec_No;
            MyOraDB.Parameter_Values[8] = _Dec_Ymd;
            MyOraDB.Parameter_Values[9] = _Pur_Currency;
            MyOraDB.Parameter_Values[10] = _Pur_Price;
            MyOraDB.Parameter_Values[11] = fgrid_Main[arg_rowcnt, (int)ClassLib.TBSXI_IN_LIST.IxREMARKS].ToString();
            MyOraDB.Parameter_Values[12] = ClassLib.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();

        }
        private void Insert_SXI_In_Head(string arg_in_no)
        {

            MyOraDB.ReDim_Parameter(3);

            //01. PROCEDURE명 
            MyOraDB.Process_Name = "PKG_SXI_IN_01.INSERT_SXI_IN_HEAD";

            //02. ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_IN_NO";
            MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";


            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

            //04. DATA 정의 
            MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = arg_in_no;
            MyOraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }

        private void Save_SXI_In_Tail(C1FlexGrid arg_fgrid, int arg_rowcnt)
		{

			MyOraDB.ReDim_Parameter(13);

			//01. PROCEDURE명 
			MyOraDB.Process_Name = "PKG_SXI_IN_01.SAVE_SXI_IN_TAIL";

			//02. ARGURMENT명
			MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2]  = "ARG_IN_NO";
			MyOraDB.Parameter_Name[3]  = "ARG_BAR_CODE";
			MyOraDB.Parameter_Name[4]  = "ARG_VALUE_IN";		
			MyOraDB.Parameter_Name[5]  = "ARG_BL_NO";
			MyOraDB.Parameter_Name[6]  = "ARG_INV_NO";
			MyOraDB.Parameter_Name[7]  = "ARG_DEC_NO";
			MyOraDB.Parameter_Name[8]  = "ARG_DEC_YMD";
			MyOraDB.Parameter_Name[9]  = "ARG_PUR_CURRENCY";
			MyOraDB.Parameter_Name[10] = "ARG_PUR_PRICE";
			MyOraDB.Parameter_Name[11] = "ARG_REMARKS";
			MyOraDB.Parameter_Name[12] = "ARG_UPD_USER";			


			//03. DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;	

			//04. DATA 정의 			
			MyOraDB.Parameter_Values[0]  = fgrid_Main[arg_rowcnt, (int)ClassLib.TBSXI_IN_LIST.IxDIVISION].ToString();			
			MyOraDB.Parameter_Values[1]  = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2]  = fgrid_Main[arg_rowcnt, (int)ClassLib.TBSXI_IN_LIST.IxIN_NO].ToString();
			MyOraDB.Parameter_Values[3]  = fgrid_Main[arg_rowcnt, (int)ClassLib.TBSXI_IN_LIST.IxBAR_CODE].ToString();			
			MyOraDB.Parameter_Values[4]  = _Value_In;		
			MyOraDB.Parameter_Values[5]  = _Bl_No;
			MyOraDB.Parameter_Values[6]  = _Inv_No;
			MyOraDB.Parameter_Values[7]  = _Dec_No;
			MyOraDB.Parameter_Values[8]  = _Dec_Ymd;
			MyOraDB.Parameter_Values[9]  = _Pur_Currency;
			MyOraDB.Parameter_Values[10] = _Pur_Price;
			MyOraDB.Parameter_Values[11] = _Remark;
			MyOraDB.Parameter_Values[12] = ClassLib.ComVar.This_User;		

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
        }
        #endregion

        #region Confirm Data
        private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (fgrid_Main.Rows.Count == fgrid_Main.Rows.Fixed)
                    return;
                Confirm_Data();
                COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndRun, this);
            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;

            }

        }

        private void Confirm_Data()
        {
            string arg_factory  = cmb_Factory.SelectedValue.ToString();
            string arg_in_no    = cmb_InNo.SelectedValue.ToString();
            string arg_upd_user = ClassLib.ComVar.This_User;

            Save_Conform_SXI_In_Head(arg_factory, arg_in_no, arg_upd_user);

            for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
            {
                if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxLEVEL].ToString() == "1")
                {
                    string arg_bar_code = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxBAR_CODE].ToString();
                    string arg_value_in = fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_IN].ToString();

                    Bar_In_Update(arg_bar_code, arg_value_in, arg_upd_user);
                }
            }

            #region ComboBox Setting
            //IN. User Setting
            DataTable dt_ret = Select_SXI_In_User(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text);
            cmb_InUser.Enabled = true;
            COM.ComCtl.Set_ComboList(dt_ret, cmb_InUser, 0, 0, true, 0, 200);
            cmb_InUser.SelectedIndex = 0;

            //IN. Number Setting
            cmb_InNo.ClearItems();
            dt_ret = Select_Get_In_No(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text, cmb_InUser.SelectedValue.ToString());
            COM.ComCtl.Set_ComboList(dt_ret, cmb_InNo, 0, 1, true, 0, 200);
            cmb_InNo.SelectedValue = arg_in_no;
            #endregion

            Display_Grid();
        }

        private void Save_Conform_SXI_In_Head(string arg_factory, string arg_in_no, string arg_upd_user)
        {

            MyOraDB.ReDim_Parameter(3);

            //01. PROCEDURE명 
            MyOraDB.Process_Name = "PKG_SXI_IN_01.SAVE_CONFORM_SXI_IN_HEAD";

            //02. ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_IN_NO";
            MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

            //04. DATA 정의 
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_in_no;
            MyOraDB.Parameter_Values[2] = arg_upd_user;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();

        }
        private void Bar_In_Update(string arg_bar_code, string arg_value_in, string arg_upd_user)
        {
            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXI_IN_01.UPDATE_BAR_IN";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_BAR_CODE";
            MyOraDB.Parameter_Name[1] = "ARG_VALUE_IN";
            MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

            //04.DATA 정의                      
            MyOraDB.Parameter_Values[0] = arg_bar_code;
            MyOraDB.Parameter_Values[1] = arg_value_in;
            MyOraDB.Parameter_Values[2] = arg_upd_user;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }        
        #endregion

		#region Control Event
        private void cmb_InUser_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;			

				if(cmb_InUser.SelectedIndex == -1)
					return;

				//IN. Number Setting
				DataTable dt_ret =  Select_Get_In_No(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text, cmb_InUser.SelectedValue.ToString());
				COM.ComCtl.Set_ComboList(dt_ret, cmb_InNo, 0, 1, true, 0, 200);
				cmb_InNo.SelectedIndex = 0;

				dt_ret.Dispose();

			}
			catch
			{
				this.Cursor = Cursors.Default;					
			}
			finally
			{
				this.Cursor = Cursors.Default;										
			}
		
		}	
		private void cmb_InNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if(cmb_InNo.SelectedIndex == -1)
					return;

                if (cmb_InNo.SelectedText.Trim() == "")
                {
                    tbtn_Confirm.Enabled = false;
                }
                else
                {
                    if (cmb_InNo.SelectedText.Trim().Substring(0, 1) == "R")
                        tbtn_Confirm.Enabled = true;
                    else
                        tbtn_Confirm.Enabled = false;
                }

				//Vendor Setting
				DataTable dt_ret = Select_SXI_In_Vendor(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text, ClassLib.ComFunction.Empty_Combo(cmb_InNo, ""),  ClassLib.ComFunction.Empty_Combo(cmb_InUser, ""));
				COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 1, true,0, 200);
				cmb_Vendor.SelectedIndex = 0;			
				
				dt_ret.Dispose();					
			}
			catch
			{
				this.Cursor = Cursors.Default;
			}
			finally
			{
				this.Cursor = Cursors.Default;										
			}

		}
		private void dtp_Std_Ymd_CloseUp(object sender, System.EventArgs e)
		{

			try
			{
				this.Cursor = Cursors.WaitCursor;

                if (_first_flg)
                    return;

				if(int.Parse(dtp_Std_Ymd.Text) > int.Parse(dtp_Fin_Ymd.Text))
				{
					dtp_Fin_Ymd.Value = dtp_Std_Ymd.Value;
				}
                 
				//IN. User Setting
				DataTable dt_ret = Select_SXI_In_User(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text);
				cmb_InUser.Enabled = true;
				COM.ComCtl.Set_ComboList(dt_ret, cmb_InUser, 0, 0, true, 0, 200);
				cmb_InUser.SelectedIndex = 0;		

			}
			catch
			{
				this.Cursor = Cursors.Default;	
				
			}
			finally
			{
				this.Cursor = Cursors.Default;										
			}
		
		
		}
		private void dtp_Fin_Ymd_CloseUp(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                if (_first_flg)
                    return;

                if (int.Parse(dtp_Std_Ymd.Text) > int.Parse(dtp_Fin_Ymd.Text))
                {
                    dtp_Std_Ymd.Value = dtp_Fin_Ymd.Value;
                }

				//IN. User Setting
				DataTable dt_ret = Select_SXI_In_User(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text);
				cmb_InUser.Enabled = true;
				COM.ComCtl.Set_ComboList(dt_ret, cmb_InUser, 0, 0, true, 0, 200);
				cmb_InUser.SelectedIndex = 0;				
			}
			catch
			{
				this.Cursor = Cursors.Default;	
				
			}	
			finally
			{
				this.Cursor = Cursors.Default;										
			}
		
		}

        private DataTable Select_Get_In_No(string arg_factory, string arg_std_ymd, string arg_fin_ymd, string arg_in_user)
        {


            MyOraDB.ReDim_Parameter(5);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXI_IN_01_SELECT.SELECT_GET_IN_NO";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_STD_YMD";
            MyOraDB.Parameter_Name[2] = "ARG_FIN_YMD";
            MyOraDB.Parameter_Name[3] = "ARG_IN_USER";
            MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_std_ymd;
            MyOraDB.Parameter_Values[2] = arg_fin_ymd;
            MyOraDB.Parameter_Values[3] = arg_in_user;
            MyOraDB.Parameter_Values[4] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];

        }
        private DataTable Select_SXI_In_Vendor(string arg_factory, string arg_std_ymd, string arg_fin_ymd, string arg_in_no, string arg_in_user)
        {


            MyOraDB.ReDim_Parameter(6);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXI_IN_01_SELECT.SELECT_SXI_IN_VENDOR";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_STD_YMD";
            MyOraDB.Parameter_Name[2] = "ARG_FIN_YMD";
            MyOraDB.Parameter_Name[3] = "ARG_IN_NO";
            MyOraDB.Parameter_Name[4] = "ARG_IN_USER";
            MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_std_ymd;
            MyOraDB.Parameter_Values[2] = arg_fin_ymd;
            MyOraDB.Parameter_Values[3] = arg_in_no;
            MyOraDB.Parameter_Values[4] = arg_in_user;
            MyOraDB.Parameter_Values[5] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];
        }
		#endregion

		#region Grid Event
		private void fgrid_Main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if ((fgrid_Main.Rows.Fixed > 0) && (fgrid_Main.Row >= fgrid_Main.Rows.Fixed))
			{
				if(fgrid_Main.Cols[fgrid_Main.Col].DataType == typeof(bool))
				{
					fgrid_Main.Buffer_CellData = "";
				}
				else
				{
					fgrid_Main.Buffer_CellData = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
				}
			}
		
		}
		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{			

			try
			{				
			    fgrid_Main.Update_Row(fgrid_Main.Selection.r1);
			    				
	
				for(int i = fgrid_Main.Selection.r1; i < fgrid_Main.Rows.Count; i++)
				{

					if(fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxDIVISION].ToString() == "U") 
					{					
						if(fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxLEVEL].ToString() == "1")
						{
							for(int j = fgrid_Main.Selection.r1 + 1; j < fgrid_Main.Rows.Count; j++)
							{						
								if(fgrid_Main[j,(int)ClassLib.TBSXI_IN_LIST.IxLEVEL].ToString() != "2") 
									break;							
																
								fgrid_Main.Update_Row(j);
							}
						}
					}

				}
				
				tbtn_Save.Enabled = true;
					

			}
			catch
			{
							
			}

		}		
		
		#endregion			
		
		#region Context Menu Event
		private void mnu_Mat_Click(object sender, System.EventArgs e)
		{			
			fgrid_Main.Tree.Show(1);		
		}

		private void mnu_Bom_Click(object sender, System.EventArgs e)
		{			
			fgrid_Main.Tree.Show(2);		
		}

		#endregion
	}
}

