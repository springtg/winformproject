using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data;
using System.Data.OracleClient;

namespace FlexCDC.Barcode
{

		
	public class Form_Barcode_List : COM.PCHWinForm.Form_Top
	{

		#region 컨트롤 및 리소스 정의 
        public System.Windows.Forms.Panel pnl_Top;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox9;
		public System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txt_Barcode;
        private System.Windows.Forms.Label lbl_Barcode;
		private System.Windows.Forms.Label lbl_PurUser;
        private System.Windows.Forms.Label lbl_Vendor;
		private System.Windows.Forms.Label lbl_PurNo;
		private System.Windows.Forms.Label lbl_SrfNo;
		private System.Windows.Forms.TextBox txt_SrfNo;
		private System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.Label lbl_PurYmd;
		private System.Windows.Forms.DateTimePicker dtp_Std_Ymd;
		private System.Windows.Forms.DateTimePicker dtp_Fin_Ymd;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.TextBox txt_MatName;
        private System.Windows.Forms.Label lbl_MatName;
		public System.Windows.Forms.Label lbl_title;
        private C1.Win.C1List.C1Combo cmb_Factory;
        private C1.Win.C1List.C1Combo cmb_PurUser;
        private C1.Win.C1List.C1Combo cmb_PurNo;
        private C1.Win.C1List.C1Combo cmb_Vendor;     

		private System.ComponentModel.IContainer components = null;

		public Form_Barcode_List()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Barcode_List));
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
            this.lbl = new System.Windows.Forms.Label();
            this.txt_MatName = new System.Windows.Forms.TextBox();
            this.lbl_MatName = new System.Windows.Forms.Label();
            this.dtp_Fin_Ymd = new System.Windows.Forms.DateTimePicker();
            this.dtp_Std_Ymd = new System.Windows.Forms.DateTimePicker();
            this.lbl_PurYmd = new System.Windows.Forms.Label();
            this.lbl_PurNo = new System.Windows.Forms.Label();
            this.lbl_Vendor = new System.Windows.Forms.Label();
            this.lbl_PurUser = new System.Windows.Forms.Label();
            this.txt_Barcode = new System.Windows.Forms.TextBox();
            this.lbl_Barcode = new System.Windows.Forms.Label();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.txt_SrfNo = new System.Windows.Forms.TextBox();
            this.lbl_SrfNo = new System.Windows.Forms.Label();
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
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.cmb_PurUser = new C1.Win.C1List.C1Combo();
            this.cmb_PurNo = new C1.Win.C1List.C1Combo();
            this.cmb_Vendor = new C1.Win.C1List.C1Combo();
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
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PurUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PurNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).BeginInit();
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
            // tbtn_New
            // 
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
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
            // pnl_Top
            // 
            this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Top.Controls.Add(this.lbl);
            this.pnl_Top.Controls.Add(this.txt_MatName);
            this.pnl_Top.Controls.Add(this.lbl_MatName);
            this.pnl_Top.Controls.Add(this.dtp_Fin_Ymd);
            this.pnl_Top.Controls.Add(this.dtp_Std_Ymd);
            this.pnl_Top.Controls.Add(this.lbl_PurYmd);
            this.pnl_Top.Controls.Add(this.lbl_PurNo);
            this.pnl_Top.Controls.Add(this.lbl_Vendor);
            this.pnl_Top.Controls.Add(this.lbl_PurUser);
            this.pnl_Top.Controls.Add(this.txt_Barcode);
            this.pnl_Top.Controls.Add(this.lbl_Barcode);
            this.pnl_Top.Controls.Add(this.lbl_factory);
            this.pnl_Top.Controls.Add(this.pnl_SearchImage);
            this.pnl_Top.Location = new System.Drawing.Point(0, 64);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_Top.Size = new System.Drawing.Size(1016, 120);
            this.pnl_Top.TabIndex = 126;
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(522, 36);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(16, 16);
            this.lbl.TabIndex = 292;
            this.lbl.Text = "~";
            // 
            // txt_MatName
            // 
            this.txt_MatName.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MatName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatName.Location = new System.Drawing.Point(429, 80);
            this.txt_MatName.Name = "txt_MatName";
            this.txt_MatName.Size = new System.Drawing.Size(200, 21);
            this.txt_MatName.TabIndex = 291;
            // 
            // lbl_MatName
            // 
            this.lbl_MatName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatName.ImageIndex = 0;
            this.lbl_MatName.ImageList = this.img_Label;
            this.lbl_MatName.Location = new System.Drawing.Point(328, 80);
            this.lbl_MatName.Name = "lbl_MatName";
            this.lbl_MatName.Size = new System.Drawing.Size(100, 21);
            this.lbl_MatName.TabIndex = 290;
            this.lbl_MatName.Tag = "1";
            this.lbl_MatName.Text = "Material";
            this.lbl_MatName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_Fin_Ymd
            // 
            this.dtp_Fin_Ymd.CustomFormat = "yyyyMMdd";
            this.dtp_Fin_Ymd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Fin_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Fin_Ymd.Location = new System.Drawing.Point(539, 36);
            this.dtp_Fin_Ymd.Name = "dtp_Fin_Ymd";
            this.dtp_Fin_Ymd.Size = new System.Drawing.Size(91, 21);
            this.dtp_Fin_Ymd.TabIndex = 288;
            this.dtp_Fin_Ymd.CloseUp += new System.EventHandler(this.dtp_Fin_Ymd_CloseUp);
            // 
            // dtp_Std_Ymd
            // 
            this.dtp_Std_Ymd.CustomFormat = "yyyyMMdd";
            this.dtp_Std_Ymd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Std_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Std_Ymd.Location = new System.Drawing.Point(429, 36);
            this.dtp_Std_Ymd.Name = "dtp_Std_Ymd";
            this.dtp_Std_Ymd.Size = new System.Drawing.Size(91, 21);
            this.dtp_Std_Ymd.TabIndex = 287;
            this.dtp_Std_Ymd.CloseUp += new System.EventHandler(this.dtp_Std_Ymd_CloseUp);
            // 
            // lbl_PurYmd
            // 
            this.lbl_PurYmd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PurYmd.ImageIndex = 0;
            this.lbl_PurYmd.ImageList = this.img_Label;
            this.lbl_PurYmd.Location = new System.Drawing.Point(328, 36);
            this.lbl_PurYmd.Name = "lbl_PurYmd";
            this.lbl_PurYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_PurYmd.TabIndex = 286;
            this.lbl_PurYmd.Tag = "1";
            this.lbl_PurYmd.Text = "Pur. Date";
            this.lbl_PurYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PurNo
            // 
            this.lbl_PurNo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PurNo.ImageIndex = 0;
            this.lbl_PurNo.ImageList = this.img_Label;
            this.lbl_PurNo.Location = new System.Drawing.Point(16, 58);
            this.lbl_PurNo.Name = "lbl_PurNo";
            this.lbl_PurNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_PurNo.TabIndex = 274;
            this.lbl_PurNo.Tag = "1";
            this.lbl_PurNo.Text = "Pur. No";
            this.lbl_PurNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Vendor
            // 
            this.lbl_Vendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vendor.ImageIndex = 0;
            this.lbl_Vendor.ImageList = this.img_Label;
            this.lbl_Vendor.Location = new System.Drawing.Point(328, 58);
            this.lbl_Vendor.Name = "lbl_Vendor";
            this.lbl_Vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_Vendor.TabIndex = 271;
            this.lbl_Vendor.Tag = "1";
            this.lbl_Vendor.Text = "Vendor";
            this.lbl_Vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PurUser
            // 
            this.lbl_PurUser.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PurUser.ImageIndex = 0;
            this.lbl_PurUser.ImageList = this.img_Label;
            this.lbl_PurUser.Location = new System.Drawing.Point(640, 36);
            this.lbl_PurUser.Name = "lbl_PurUser";
            this.lbl_PurUser.Size = new System.Drawing.Size(100, 21);
            this.lbl_PurUser.TabIndex = 268;
            this.lbl_PurUser.Tag = "1";
            this.lbl_PurUser.Text = "Pur. User";
            this.lbl_PurUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Barcode
            // 
            this.txt_Barcode.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Barcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Barcode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Barcode.Location = new System.Drawing.Point(741, 58);
            this.txt_Barcode.Name = "txt_Barcode";
            this.txt_Barcode.Size = new System.Drawing.Size(200, 21);
            this.txt_Barcode.TabIndex = 266;
            // 
            // lbl_Barcode
            // 
            this.lbl_Barcode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Barcode.ImageIndex = 0;
            this.lbl_Barcode.ImageList = this.img_Label;
            this.lbl_Barcode.Location = new System.Drawing.Point(640, 58);
            this.lbl_Barcode.Name = "lbl_Barcode";
            this.lbl_Barcode.Size = new System.Drawing.Size(100, 21);
            this.lbl_Barcode.TabIndex = 265;
            this.lbl_Barcode.Tag = "1";
            this.lbl_Barcode.Text = "Barcode";
            this.lbl_Barcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pnl_SearchImage.Controls.Add(this.cmb_Vendor);
            this.pnl_SearchImage.Controls.Add(this.cmb_PurNo);
            this.pnl_SearchImage.Controls.Add(this.cmb_PurUser);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.txt_SrfNo);
            this.pnl_SearchImage.Controls.Add(this.lbl_SrfNo);
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
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 112);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // txt_SrfNo
            // 
            this.txt_SrfNo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SrfNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SrfNo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SrfNo.Location = new System.Drawing.Point(109, 80);
            this.txt_SrfNo.Name = "txt_SrfNo";
            this.txt_SrfNo.Size = new System.Drawing.Size(200, 21);
            this.txt_SrfNo.TabIndex = 281;
            // 
            // lbl_SrfNo
            // 
            this.lbl_SrfNo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SrfNo.ImageIndex = 0;
            this.lbl_SrfNo.ImageList = this.img_Label;
            this.lbl_SrfNo.Location = new System.Drawing.Point(8, 80);
            this.lbl_SrfNo.Name = "lbl_SrfNo";
            this.lbl_SrfNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_SrfNo.TabIndex = 280;
            this.lbl_SrfNo.Tag = "1";
            this.lbl_SrfNo.Text = "SRF No";
            this.lbl_SrfNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.picb_MR.Size = new System.Drawing.Size(24, 69);
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
            this.lbl_title.Text = "      Barcode Information";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(984, 97);
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
            this.pictureBox5.Location = new System.Drawing.Point(144, 96);
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
            this.pictureBox6.Location = new System.Drawing.Point(0, 97);
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
            this.pictureBox7.Size = new System.Drawing.Size(168, 79);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 72);
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
            this.pictureBox9.Size = new System.Drawing.Size(1000, 72);
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
            this.pnl_Body.Location = new System.Drawing.Point(0, 184);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(1016, 458);
            this.pnl_Body.TabIndex = 140;
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.fgrid_Main.AutoResize = false;
            this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Main.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            this.fgrid_Main.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Rows.DefaultSize = 18;
            this.fgrid_Main.Rows.Fixed = 0;
            this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Main.Size = new System.Drawing.Size(1016, 458);
            this.fgrid_Main.StyleInfo = resources.GetString("fgrid_Main.StyleInfo");
            this.fgrid_Main.TabIndex = 318;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
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
            this.cmb_Factory.HeadingStyle = style28;
            this.cmb_Factory.HighLightRowStyle = style29;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(109, 36);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style30;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style31;
            this.cmb_Factory.Size = new System.Drawing.Size(200, 21);
            this.cmb_Factory.Style = style32;
            this.cmb_Factory.TabIndex = 352;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // cmb_PurUser
            // 
            this.cmb_PurUser.AddItemSeparator = ';';
            this.cmb_PurUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_PurUser.Caption = "";
            this.cmb_PurUser.CaptionHeight = 17;
            this.cmb_PurUser.CaptionStyle = style17;
            this.cmb_PurUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_PurUser.ColumnCaptionHeight = 18;
            this.cmb_PurUser.ColumnFooterHeight = 18;
            this.cmb_PurUser.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_PurUser.ContentHeight = 17;
            this.cmb_PurUser.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_PurUser.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_PurUser.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_PurUser.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_PurUser.EditorHeight = 17;
            this.cmb_PurUser.EvenRowStyle = style18;
            this.cmb_PurUser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_PurUser.FooterStyle = style19;
            this.cmb_PurUser.HeadingStyle = style20;
            this.cmb_PurUser.HighLightRowStyle = style21;
            this.cmb_PurUser.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_PurUser.Images"))));
            this.cmb_PurUser.ItemHeight = 15;
            this.cmb_PurUser.Location = new System.Drawing.Point(733, 36);
            this.cmb_PurUser.MatchEntryTimeout = ((long)(2000));
            this.cmb_PurUser.MaxDropDownItems = ((short)(5));
            this.cmb_PurUser.MaxLength = 32767;
            this.cmb_PurUser.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_PurUser.Name = "cmb_PurUser";
            this.cmb_PurUser.OddRowStyle = style22;
            this.cmb_PurUser.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_PurUser.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_PurUser.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_PurUser.SelectedStyle = style23;
            this.cmb_PurUser.Size = new System.Drawing.Size(200, 21);
            this.cmb_PurUser.Style = style24;
            this.cmb_PurUser.TabIndex = 353;
            this.cmb_PurUser.SelectedValueChanged += new System.EventHandler(this.cmb_PurUser_SelectedValueChanged);
            this.cmb_PurUser.PropBag = resources.GetString("cmb_PurUser.PropBag");
            // 
            // cmb_PurNo
            // 
            this.cmb_PurNo.AddItemSeparator = ';';
            this.cmb_PurNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_PurNo.Caption = "";
            this.cmb_PurNo.CaptionHeight = 17;
            this.cmb_PurNo.CaptionStyle = style9;
            this.cmb_PurNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_PurNo.ColumnCaptionHeight = 18;
            this.cmb_PurNo.ColumnFooterHeight = 18;
            this.cmb_PurNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_PurNo.ContentHeight = 17;
            this.cmb_PurNo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_PurNo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_PurNo.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_PurNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_PurNo.EditorHeight = 17;
            this.cmb_PurNo.EvenRowStyle = style10;
            this.cmb_PurNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_PurNo.FooterStyle = style11;
            this.cmb_PurNo.HeadingStyle = style12;
            this.cmb_PurNo.HighLightRowStyle = style13;
            this.cmb_PurNo.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_PurNo.Images"))));
            this.cmb_PurNo.ItemHeight = 15;
            this.cmb_PurNo.Location = new System.Drawing.Point(109, 58);
            this.cmb_PurNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_PurNo.MaxDropDownItems = ((short)(5));
            this.cmb_PurNo.MaxLength = 32767;
            this.cmb_PurNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_PurNo.Name = "cmb_PurNo";
            this.cmb_PurNo.OddRowStyle = style14;
            this.cmb_PurNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_PurNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_PurNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_PurNo.SelectedStyle = style15;
            this.cmb_PurNo.Size = new System.Drawing.Size(200, 21);
            this.cmb_PurNo.Style = style16;
            this.cmb_PurNo.TabIndex = 354;
            this.cmb_PurNo.SelectedValueChanged += new System.EventHandler(this.cmb_PurNo_SelectedValueChanged);
            this.cmb_PurNo.PropBag = resources.GetString("cmb_PurNo.PropBag");
            // 
            // cmb_Vendor
            // 
            this.cmb_Vendor.AddItemSeparator = ';';
            this.cmb_Vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Vendor.Caption = "";
            this.cmb_Vendor.CaptionHeight = 17;
            this.cmb_Vendor.CaptionStyle = style1;
            this.cmb_Vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Vendor.ColumnCaptionHeight = 18;
            this.cmb_Vendor.ColumnFooterHeight = 18;
            this.cmb_Vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Vendor.ContentHeight = 17;
            this.cmb_Vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Vendor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Vendor.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Vendor.EditorHeight = 17;
            this.cmb_Vendor.EvenRowStyle = style2;
            this.cmb_Vendor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vendor.FooterStyle = style3;
            this.cmb_Vendor.HeadingStyle = style4;
            this.cmb_Vendor.HighLightRowStyle = style5;
            this.cmb_Vendor.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Vendor.Images"))));
            this.cmb_Vendor.ItemHeight = 15;
            this.cmb_Vendor.Location = new System.Drawing.Point(421, 58);
            this.cmb_Vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_Vendor.MaxDropDownItems = ((short)(5));
            this.cmb_Vendor.MaxLength = 32767;
            this.cmb_Vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Vendor.Name = "cmb_Vendor";
            this.cmb_Vendor.OddRowStyle = style6;
            this.cmb_Vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.SelectedStyle = style7;
            this.cmb_Vendor.Size = new System.Drawing.Size(200, 21);
            this.cmb_Vendor.Style = style8;
            this.cmb_Vendor.TabIndex = 355;
            this.cmb_Vendor.PropBag = resources.GetString("cmb_Vendor.PropBag");
            // 
            // Form_Barcode_List
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_Body);
            this.Controls.Add(this.pnl_Top);
            this.Name = "Form_Barcode_List";
            this.Load += new System.EventHandler(this.Form_Barcode_List_Load);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.pnl_Body, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PurUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PurNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region User Define Variable

		private COM.OraDB MyOraDB = new COM.OraDB();
		private bool _Print_Flg = false;	
		
		#endregion

		#region Function
		private void Init_Form()
		{
            this.Text = "PCC_Barcode Information";
			this.lbl_MainTitle.Text = "PCC_Barcode Information";
			this.lbl_title.Text = "      Barcode Information";


			ClassLib.ComFunction.SetLangDic(this); 

			#region Button Setting 
			tbtn_Confirm.Enabled = false;
			tbtn_Save.Enabled    = false;
			tbtn_Delete.Enabled  = false;
			tbtn_Create.Enabled  = false;
			#endregion			

			#region ComboBox Setting 			
			//Std Ymd Setting
			dtp_Std_Ymd.Value = DateTime.Today;
			dtp_Fin_Ymd.Value = DateTime.Today;

			dtp_Std_Ymd.Text = dtp_Std_Ymd.Value.AddDays( -7 ).ToString();

	
			//Pur User Setting 
			DataTable dt_ret = Select_Sxs_Bar_Pur_User(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text );
			COM.ComCtl.Set_ComboList(dt_ret, cmb_PurUser, 0, 0, true , 0, 200);
			cmb_PurUser.SelectedIndex = 0;
			
			dt_ret.Dispose();
			#endregion

			#region Grid Setting
			fgrid_Main.Set_Grid_CDC("SXS_BAR_LIST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_Main.Set_Action_Image(img_Action);
			fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;						
			#endregion

			#region TextBox Setting 		
			txt_Barcode.CharacterCasing = CharacterCasing.Upper;			
			txt_SrfNo.CharacterCasing   = CharacterCasing.Upper;
			txt_MatName.CharacterCasing   = CharacterCasing.Upper;
			txt_Barcode.Focus();
			#endregion
			 
		}	
		private void DisplayGrid()
		{
           
			fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;				
			
			DataTable dt_ret = Select_Sxs_Bar_List( cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text, cmb_PurUser.SelectedValue.ToString(), cmb_PurNo.SelectedValue.ToString(), 
				                                    cmb_Vendor.SelectedValue.ToString(), COM.ComFunction.Empty_TextBox(txt_Barcode, ""), 
				                                    COM.ComFunction.Empty_TextBox(txt_MatName, ""), COM.ComFunction.Empty_TextBox(txt_SrfNo, "") );

			for(int i = 0; i < dt_ret.Rows.Count  ; i++)
			{					
				fgrid_Main.AddItem(dt_ret.Rows[i].ItemArray, fgrid_Main.Rows.Count, 1);	
			}	
			
		}
		private void Update_Print_Chk()
		{
            Update_Sxs_Bar_Print_Chk(cmb_Factory.SelectedValue.ToString(), "", "02");

			for(int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
			{
				if(fgrid_Main[i, (int)ClassLib.TBSXS_BAR_LIST.IxFLAG + 1] != null)
				{
					if(fgrid_Main[i, (int)ClassLib.TBSXS_BAR_LIST.IxFLAG + 1].ToString() == "True")
					{
						string vFactory = fgrid_Main[i,(int)ClassLib.TBSXS_BAR_LIST.IxFACTORY+1].ToString();
						string vBarcode = fgrid_Main[i,(int)ClassLib.TBSXS_BAR_LIST.IxBAR_CODE+1].ToString();
						Update_Sxs_Bar_Print_Chk(vFactory, vBarcode, "01" );
						_Print_Flg = true;
					}
				}
			}

		}
		private void PrintGrid()
		{

            //Update_Sxs_Bar_Print_Chk(cmb_Factory.SelectedValue.ToString(), "", "02");

			string mrd_Filename = "";
			string sPara = "";
			if(_Print_Flg)
			{
                mrd_Filename = Application.StartupPath  + "\\rd_Scan_InOut_Chk_vj" + ".mrd";
				sPara  = " /rp " + "["+cmb_Factory.SelectedValue.ToString()+"]";
			}
			else
			{
				mrd_Filename = Application.StartupPath + @"\rd_Scan_InOut" + ".mrd";					
				sPara  = " /rp " + "["+cmb_Factory.SelectedValue.ToString()+"]"+" ["+ dtp_Std_Ymd.Text+"]"+" ["+ dtp_Fin_Ymd.Text+"]"+" ["+ cmb_PurUser.SelectedValue.ToString()+"]"+ " ["+ cmb_PurNo.SelectedValue.ToString()+"]"+" ["+ cmb_Vendor.SelectedValue.ToString() +"]"+" ["+ COM.ComFunction.Empty_TextBox(txt_Barcode, "")+"]" +" ["+ COM.ComFunction.Empty_TextBox(txt_MatName, "")+"]"+" ["+ COM.ComFunction.Empty_TextBox(txt_SrfNo, "")+"]";	
			}
			
			FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
			report.ShowDialog();


			if(_Print_Flg)
			{
				Update_Sxs_Bar_Print_Chk(cmb_Factory.SelectedValue.ToString(), "", "02");
				_Print_Flg = false;
            }
		}		
		#endregion 

		#region Event	
        
        #region Control Event
        private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if(cmb_Factory.SelectedIndex == -1)
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
		private void dtp_Std_Ymd_CloseUp(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;				
				
				//Pur User Setting 
				DataTable dt_ret = Select_Sxs_Bar_Pur_User(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text );
				COM.ComCtl.Set_ComboList(dt_ret, cmb_PurUser, 0, 0, true , 0, 200);
				cmb_PurUser.SelectedIndex = 0;

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
		private void dtp_Fin_Ymd_CloseUp(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;				
				
				//Pur User Setting 
				DataTable dt_ret = Select_Sxs_Bar_Pur_User(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text );
				COM.ComCtl.Set_ComboList(dt_ret, cmb_PurUser, 0, 0, true , 0, 200);
				cmb_PurUser.SelectedIndex = 0;

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
		private void cmb_PurUser_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;				

				//PurNo Setting 
				DataTable dt_ret = Select_Sxs_Bar_Pur_No( cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text, COM.ComFunction.Empty_Combo(cmb_PurUser, "") );
				COM.ComCtl.Set_ComboList(dt_ret, cmb_PurNo, 0, 0, true , 0, 200);
				cmb_PurNo.SelectedIndex = 0;

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
		private void cmb_PurNo_SelectedValueChanged(object sender, System.EventArgs e)
		{

			try
			{
				this.Cursor = Cursors.WaitCursor;				

				//Vendor Setting 
				DataTable dt_ret = Select_Sxs_Bar_Vendor( cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text, COM.ComFunction.Empty_Combo(cmb_PurUser, ""), COM.ComFunction.Empty_Combo(cmb_PurNo, "") );
				COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 1, true , 0, 200);
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
        #endregion

        #region ToolBar Button Event
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;

				#region TextBox & ComboBox Clear
				txt_Barcode.Clear();
				txt_MatName.Clear();			
				txt_SrfNo.Clear();				
				
				cmb_Factory.SelectedValue = COM.ComVar.This_CDC_Factory;				
				cmb_PurUser.SelectedIndex = 0;				
				cmb_Vendor.SelectedIndex = 0;
				#endregion
			}
			catch
			{
				
			}
		
		}
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;				
				DisplayGrid();

			}
			catch
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch, this);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				COM.ComFunction.Status_Bar_Message( COM.ComVar.MgsEndSearch, this );
			}
		
		}	
		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				Update_Print_Chk();
				PrintGrid();
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

        #endregion

        #region DB Connect
        private DataTable Select_Sxs_Bar_Pur_User( string arg_factory, string arg_std_ymd, string arg_fin_ymd )
		{		

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXS_BAR_02_SELECT.SELECT_SXS_BAR_PUR_USER" ;

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

			
			return DS_Ret.Tables[MyOraDB.Process_Name];
		}

		private DataTable Select_Sxs_Bar_Pur_No( string arg_factory, string arg_std_ymd, string arg_fin_ymd, string arg_pur_user )
		{

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXS_BAR_02_SELECT.SELECT_SXS_BAR_PUR_NO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STD_YMD";	
			MyOraDB.Parameter_Name[2] = "ARG_FIN_YMD";
			MyOraDB.Parameter_Name[3] = "ARG_PUR_USER";				
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
			MyOraDB.Parameter_Values[3] = arg_pur_user;			
			MyOraDB.Parameter_Values[4] = "";
			

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();
			
			return DS_Ret.Tables[MyOraDB.Process_Name];

		}

		private DataTable Select_Sxs_Bar_Vendor( string arg_factory, string arg_std_ymd, string arg_fin_ymd, string arg_pur_user, string arg_pur_no )
		{

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXS_BAR_02_SELECT.SELECT_SXS_BAR_VENDOR";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STD_YMD";	
			MyOraDB.Parameter_Name[2] = "ARG_FIN_YMD";
			MyOraDB.Parameter_Name[3] = "ARG_PUR_USER";		
			MyOraDB.Parameter_Name[4] = "ARG_PUR_NO";			
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
			MyOraDB.Parameter_Values[3] = arg_pur_user;
			MyOraDB.Parameter_Values[4] = arg_pur_no;
			MyOraDB.Parameter_Values[5] = "";
			

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();
			
			return DS_Ret.Tables[MyOraDB.Process_Name];

		}

		private DataTable Select_Sxs_Bar_List(string arg_factory, string arg_std_ymd, string arg_fin_ymd, string arg_pur_user,
			string arg_pur_no, string arg_ven_seq, string arg_bar_code,  string arg_mat_name, string arg_srf_no)
		{

			MyOraDB.ReDim_Parameter(10);

			//01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXS_BAR_02_SELECT.SELECT_SXS_BAR_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_STD_YMD";	
			MyOraDB.Parameter_Name[2]  = "ARG_FIN_YMD";		
			MyOraDB.Parameter_Name[3]  = "ARG_PUR_USER";
			MyOraDB.Parameter_Name[4]  = "ARG_PUR_NO";
			MyOraDB.Parameter_Name[5]  = "ARG_VEN_SEQ";
			MyOraDB.Parameter_Name[6]  = "ARG_BAR_CODE";
			MyOraDB.Parameter_Name[7]  = "ARG_MAT_NAME";
			MyOraDB.Parameter_Name[8]  = "ARG_SRF_NO";
			MyOraDB.Parameter_Name[9] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[9] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]  = arg_factory;
			MyOraDB.Parameter_Values[1]  = arg_std_ymd;
			MyOraDB.Parameter_Values[2]  = arg_fin_ymd;
			MyOraDB.Parameter_Values[3]  = arg_pur_user;
			MyOraDB.Parameter_Values[4]  = arg_pur_no;
			MyOraDB.Parameter_Values[5]  = arg_ven_seq;
			MyOraDB.Parameter_Values[6]  = arg_bar_code;
			MyOraDB.Parameter_Values[7]  = arg_mat_name;
			MyOraDB.Parameter_Values[8]  = arg_srf_no;
			MyOraDB.Parameter_Values[9] = "";
			

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();
			
			return DS_Ret.Tables[MyOraDB.Process_Name];

		}
		private void Update_Sxs_Bar_Print_Chk( string arg_factory, string arg_bar_code, string arg_division )
		{

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXS_BAR_02_SELECT.UPDATE_SXS_BAR_PRINT_CHK";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_BAR_CODE";
			MyOraDB.Parameter_Name[2] = "ARG_DIVISION";
			

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;			

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_bar_code;
			MyOraDB.Parameter_Values[2] = arg_division;			

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();

		}
		#endregion 

		private void Form_Barcode_List_Load(object sender, System.EventArgs e)
		{
			try
			{
                //factory 
				DataTable dt_list = COM.ComFunction.Select_Factory_List_CDC();
				COM.ComCtl.Set_Factory_List(dt_list, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
                cmb_Factory.SelectedValue = COM.ComVar.This_CDC_Factory;
                cmb_Factory.Enabled = true;
                cmb_Factory.ReadOnly = false;
			}
			catch
			{

			}	
		}
	}
}

