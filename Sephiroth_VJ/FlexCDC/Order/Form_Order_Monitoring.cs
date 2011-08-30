using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using System.Reflection;
using C1.Win.C1FlexGrid;
using System.Xml;
using System.IO;
using System.Threading;

namespace FlexCDC.Order
{
	public class Form_Order_Monitoring : COM.CDCWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정의

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
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel pnl_Body;
        private System.Windows.Forms.Label lbl_Category;
		private System.Windows.Forms.Label lbl_SeasonCode;
		public System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Style;
		public COM.FSP fgrid_Main;
		//private System.Windows.Forms.TextBox txt_SRF_No;
		private System.Windows.Forms.TextBox txt_SRFNo;
        private C1.Win.C1List.C1Combo cmb_Style;
        private C1.Win.C1List.C1Combo cmb_SeasonCode;
        private C1.Win.C1List.C1Combo cmb_Category;
        private C1.Win.C1List.C1Combo cmb_Factory;
        private C1.Win.C1List.C1Combo cmb_SRF_No;
		private System.ComponentModel.IContainer components = null;

		public Form_Order_Monitoring()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Order_Monitoring));
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
            C1.Win.C1List.Style style33 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style34 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style35 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style36 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style37 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style38 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style39 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style40 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.lbl_SeasonCode = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.txt_SRFNo = new System.Windows.Forms.TextBox();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.cmb_Category = new C1.Win.C1List.C1Combo();
            this.cmb_SeasonCode = new C1.Win.C1List.C1Combo();
            this.cmb_SRF_No = new C1.Win.C1List.C1Combo();
            this.cmb_Style = new C1.Win.C1List.C1Combo();
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
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SeasonCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SRF_No)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).BeginInit();
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
            // tbtn_New
            // 
            this.tbtn_New.Text = "";
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Text = "";
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.Text = "";
            // 
            // tbtn_Append
            // 
            this.tbtn_Append.Text = "";
            // 
            // tbtn_Insert
            // 
            this.tbtn_Insert.Text = "";
            // 
            // tbtn_Delete
            // 
            this.tbtn_Delete.Text = "";
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 644);
            this.stbar.Size = new System.Drawing.Size(1016, 22);
            // 
            // tbtn_Color
            // 
            this.tbtn_Color.Text = "";
            // 
            // tbtn_Print
            // 
            this.tbtn_Print.Text = "";
            // 
            // pnl_Top
            // 
            this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Top.Controls.Add(this.cmb_Style);
            this.pnl_Top.Controls.Add(this.cmb_SeasonCode);
            this.pnl_Top.Controls.Add(this.cmb_Category);
            this.pnl_Top.Controls.Add(this.cmb_Factory);
            this.pnl_Top.Controls.Add(this.lbl_SeasonCode);
            this.pnl_Top.Controls.Add(this.lbl_Category);
            this.pnl_Top.Controls.Add(this.lbl_factory);
            this.pnl_Top.Controls.Add(this.pnl_SearchImage);
            this.pnl_Top.Location = new System.Drawing.Point(0, 64);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_Top.Size = new System.Drawing.Size(1016, 96);
            this.pnl_Top.TabIndex = 124;
            // 
            // lbl_SeasonCode
            // 
            this.lbl_SeasonCode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SeasonCode.ImageIndex = 0;
            this.lbl_SeasonCode.ImageList = this.img_Label;
            this.lbl_SeasonCode.Location = new System.Drawing.Point(680, 36);
            this.lbl_SeasonCode.Name = "lbl_SeasonCode";
            this.lbl_SeasonCode.Size = new System.Drawing.Size(100, 21);
            this.lbl_SeasonCode.TabIndex = 267;
            this.lbl_SeasonCode.Tag = "1";
            this.lbl_SeasonCode.Text = "Season Code";
            this.lbl_SeasonCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Category
            // 
            this.lbl_Category.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ImageIndex = 0;
            this.lbl_Category.ImageList = this.img_Label;
            this.lbl_Category.Location = new System.Drawing.Point(352, 36);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(100, 21);
            this.lbl_Category.TabIndex = 265;
            this.lbl_Category.Tag = "1";
            this.lbl_Category.Text = "Category";
            this.lbl_Category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pnl_SearchImage.Controls.Add(this.cmb_SRF_No);
            this.pnl_SearchImage.Controls.Add(this.txt_SRFNo);
            this.pnl_SearchImage.Controls.Add(this.lbl_Style);
            this.pnl_SearchImage.Controls.Add(this.label1);
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
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 88);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // txt_SRFNo
            // 
            this.txt_SRFNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SRFNo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SRFNo.Location = new System.Drawing.Point(109, 58);
            this.txt_SRFNo.Name = "txt_SRFNo";
            this.txt_SRFNo.Size = new System.Drawing.Size(80, 21);
            this.txt_SRFNo.TabIndex = 609;
            // 
            // lbl_Style
            // 
            this.lbl_Style.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Style.ImageIndex = 0;
            this.lbl_Style.ImageList = this.img_Label;
            this.lbl_Style.Location = new System.Drawing.Point(344, 58);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style.TabIndex = 607;
            this.lbl_Style.Tag = "1";
            this.lbl_Style.Text = "Style";
            this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 265;
            this.label1.Tag = "1";
            this.label1.Text = "SRF No";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.picb_MR.Size = new System.Drawing.Size(24, 45);
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
            this.lbl_title.Text = "      SRF Order Information";
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
            this.pictureBox5.Location = new System.Drawing.Point(144, 72);
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 48);
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
            this.pictureBox9.Size = new System.Drawing.Size(1000, 48);
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
            this.pnl_Body.Location = new System.Drawing.Point(0, 160);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Padding = new System.Windows.Forms.Padding(4);
            this.pnl_Body.Size = new System.Drawing.Size(1016, 480);
            this.pnl_Body.TabIndex = 138;
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
            this.fgrid_Main.Location = new System.Drawing.Point(4, 4);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Rows.DefaultSize = 18;
            this.fgrid_Main.Rows.Fixed = 0;
            this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Main.Size = new System.Drawing.Size(1008, 472);
            this.fgrid_Main.StyleInfo = resources.GetString("fgrid_Main.StyleInfo");
            this.fgrid_Main.TabIndex = 319;
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
            this.cmb_Factory.ContentHeight = 16;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 16;
            this.cmb_Factory.EvenRowStyle = style26;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style27;
            this.cmb_Factory.HeadingStyle = style28;
            this.cmb_Factory.HighLightRowStyle = style29;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(117, 36);
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
            this.cmb_Factory.Size = new System.Drawing.Size(200, 20);
            this.cmb_Factory.Style = style32;
            this.cmb_Factory.TabIndex = 273;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // cmb_Category
            // 
            this.cmb_Category.AddItemSeparator = ';';
            this.cmb_Category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Category.Caption = "";
            this.cmb_Category.CaptionHeight = 17;
            this.cmb_Category.CaptionStyle = style17;
            this.cmb_Category.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Category.ColumnCaptionHeight = 18;
            this.cmb_Category.ColumnFooterHeight = 18;
            this.cmb_Category.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Category.ContentHeight = 16;
            this.cmb_Category.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Category.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Category.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Category.EditorHeight = 16;
            this.cmb_Category.EvenRowStyle = style18;
            this.cmb_Category.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FooterStyle = style19;
            this.cmb_Category.HeadingStyle = style20;
            this.cmb_Category.HighLightRowStyle = style21;
            this.cmb_Category.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Category.Images"))));
            this.cmb_Category.ItemHeight = 15;
            this.cmb_Category.Location = new System.Drawing.Point(453, 37);
            this.cmb_Category.MatchEntryTimeout = ((long)(2000));
            this.cmb_Category.MaxDropDownItems = ((short)(5));
            this.cmb_Category.MaxLength = 32767;
            this.cmb_Category.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.OddRowStyle = style22;
            this.cmb_Category.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Category.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Category.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Category.SelectedStyle = style23;
            this.cmb_Category.Size = new System.Drawing.Size(200, 20);
            this.cmb_Category.Style = style24;
            this.cmb_Category.TabIndex = 274;
            this.cmb_Category.PropBag = resources.GetString("cmb_Category.PropBag");
            // 
            // cmb_SeasonCode
            // 
            this.cmb_SeasonCode.AddItemSeparator = ';';
            this.cmb_SeasonCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SeasonCode.Caption = "";
            this.cmb_SeasonCode.CaptionHeight = 17;
            this.cmb_SeasonCode.CaptionStyle = style9;
            this.cmb_SeasonCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SeasonCode.ColumnCaptionHeight = 18;
            this.cmb_SeasonCode.ColumnFooterHeight = 18;
            this.cmb_SeasonCode.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SeasonCode.ContentHeight = 16;
            this.cmb_SeasonCode.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SeasonCode.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SeasonCode.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SeasonCode.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SeasonCode.EditorHeight = 16;
            this.cmb_SeasonCode.EvenRowStyle = style10;
            this.cmb_SeasonCode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SeasonCode.FooterStyle = style11;
            this.cmb_SeasonCode.HeadingStyle = style12;
            this.cmb_SeasonCode.HighLightRowStyle = style13;
            this.cmb_SeasonCode.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_SeasonCode.Images"))));
            this.cmb_SeasonCode.ItemHeight = 15;
            this.cmb_SeasonCode.Location = new System.Drawing.Point(781, 37);
            this.cmb_SeasonCode.MatchEntryTimeout = ((long)(2000));
            this.cmb_SeasonCode.MaxDropDownItems = ((short)(5));
            this.cmb_SeasonCode.MaxLength = 32767;
            this.cmb_SeasonCode.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SeasonCode.Name = "cmb_SeasonCode";
            this.cmb_SeasonCode.OddRowStyle = style14;
            this.cmb_SeasonCode.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SeasonCode.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SeasonCode.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SeasonCode.SelectedStyle = style15;
            this.cmb_SeasonCode.Size = new System.Drawing.Size(200, 20);
            this.cmb_SeasonCode.Style = style16;
            this.cmb_SeasonCode.TabIndex = 275;
            this.cmb_SeasonCode.PropBag = resources.GetString("cmb_SeasonCode.PropBag");
            // 
            // cmb_SRF_No
            // 
            this.cmb_SRF_No.AddItemSeparator = ';';
            this.cmb_SRF_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SRF_No.Caption = "";
            this.cmb_SRF_No.CaptionHeight = 17;
            this.cmb_SRF_No.CaptionStyle = style33;
            this.cmb_SRF_No.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SRF_No.ColumnCaptionHeight = 18;
            this.cmb_SRF_No.ColumnFooterHeight = 18;
            this.cmb_SRF_No.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SRF_No.ContentHeight = 16;
            this.cmb_SRF_No.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SRF_No.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SRF_No.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SRF_No.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SRF_No.EditorHeight = 16;
            this.cmb_SRF_No.EvenRowStyle = style34;
            this.cmb_SRF_No.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SRF_No.FooterStyle = style35;
            this.cmb_SRF_No.HeadingStyle = style36;
            this.cmb_SRF_No.HighLightRowStyle = style37;
            this.cmb_SRF_No.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_SRF_No.Images"))));
            this.cmb_SRF_No.ItemHeight = 15;
            this.cmb_SRF_No.Location = new System.Drawing.Point(190, 58);
            this.cmb_SRF_No.MatchEntryTimeout = ((long)(2000));
            this.cmb_SRF_No.MaxDropDownItems = ((short)(5));
            this.cmb_SRF_No.MaxLength = 32767;
            this.cmb_SRF_No.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SRF_No.Name = "cmb_SRF_No";
            this.cmb_SRF_No.OddRowStyle = style38;
            this.cmb_SRF_No.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SRF_No.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SRF_No.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SRF_No.SelectedStyle = style39;
            this.cmb_SRF_No.Size = new System.Drawing.Size(119, 20);
            this.cmb_SRF_No.Style = style40;
            this.cmb_SRF_No.TabIndex = 276;
            this.cmb_SRF_No.SelectedValueChanged += new System.EventHandler(this.cmb_SRF_No_SelectedValueChanged);
            this.cmb_SRF_No.PropBag = resources.GetString("cmb_SRF_No.PropBag");
            // 
            // cmb_Style
            // 
            this.cmb_Style.AddItemSeparator = ';';
            this.cmb_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Style.Caption = "";
            this.cmb_Style.CaptionHeight = 17;
            this.cmb_Style.CaptionStyle = style1;
            this.cmb_Style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Style.ColumnCaptionHeight = 18;
            this.cmb_Style.ColumnFooterHeight = 18;
            this.cmb_Style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Style.ContentHeight = 16;
            this.cmb_Style.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Style.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Style.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Style.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Style.EditorHeight = 16;
            this.cmb_Style.EvenRowStyle = style2;
            this.cmb_Style.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Style.FooterStyle = style3;
            this.cmb_Style.HeadingStyle = style4;
            this.cmb_Style.HighLightRowStyle = style5;
            this.cmb_Style.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Style.Images"))));
            this.cmb_Style.ItemHeight = 15;
            this.cmb_Style.Location = new System.Drawing.Point(453, 59);
            this.cmb_Style.MatchEntryTimeout = ((long)(2000));
            this.cmb_Style.MaxDropDownItems = ((short)(5));
            this.cmb_Style.MaxLength = 32767;
            this.cmb_Style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Style.Name = "cmb_Style";
            this.cmb_Style.OddRowStyle = style6;
            this.cmb_Style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Style.SelectedStyle = style7;
            this.cmb_Style.Size = new System.Drawing.Size(200, 20);
            this.cmb_Style.Style = style8;
            this.cmb_Style.TabIndex = 276;
            this.cmb_Style.PropBag = resources.GetString("cmb_Style.PropBag");
            // 
            // Form_Order_Monitoring
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_Body);
            this.Controls.Add(this.pnl_Top);
            this.Name = "Form_Order_Monitoring";
            this.Load += new System.EventHandler(this.Form_Order_Monitoring_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.pnl_Body, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Top.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SeasonCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SRF_No)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수 

		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion

		#region 공통메서드

		private void Init_Form()
		{
			this.Text = "PCC_Order Analysis";
			this.lbl_MainTitle.Text = "PCC_Order Analysis";
			this.lbl_title.Text = "      Order Information";

			ClassLib.ComFunction.SetLangDic(this);			
			
			#region Button Setting
			tbtn_Save.Enabled   = false;
			tbtn_Delete.Enabled = false;
			tbtn_Color.Enabled  = false;
			tbtn_Print.Enabled  = false;
			tbtn_Insert.Enabled = false;
			tbtn_Append.Enabled = false;
			#endregion				
			
			#region ComboBox Setting
			//Category Setting
			DataTable dt_ret = Select_Category_List( cmb_Factory.SelectedValue.ToString() );
			COM.ComCtl.Set_ComboList (dt_ret, cmb_Category, 0, 1, true, 0, 200 );
			cmb_Category.SelectedIndex = 0 ;
	
			//Season Setting
			dt_ret = Select_Season_List( cmb_Factory.SelectedValue.ToString() );
			COM.ComCtl.Set_ComboList (dt_ret, cmb_SeasonCode, 0, 1, true, 0, 200 );
			cmb_SeasonCode.SelectedIndex = 0 ;			


			//srf
			dt_ret = Select_SRF_List( cmb_Factory.SelectedValue.ToString(),txt_SRFNo.Text);
			COM.ComCtl.Set_ComboList (dt_ret, cmb_SRF_No, 0, 0, true, 0, 200 );
			cmb_SRF_No.SelectedIndex = 0;


			//style
			dt_ret = Select_Style_List( cmb_Factory.SelectedValue.ToString(), cmb_SRF_No.SelectedValue.ToString() );
			COM.ComCtl.Set_ComboList (dt_ret, cmb_Style, 0, 1, true, 0, 200 );	
			cmb_Style.SelectedIndex = 0;
			dt_ret.Dispose();		
			#endregion
			
            #region Grid Setting 
			fgrid_Main.Set_Grid_CDC("SXC_PJ_MAST", "3", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Main.Set_Action_Image(img_Action);
			fgrid_Main.Font =new Font("Verdana", 8);			
			#endregion

			#region TextBox Setting
			txt_SRFNo.CharacterCasing = CharacterCasing.Upper;	
			txt_SRFNo.Focus();
			#endregion

		}

		private void Display_Grid(DataTable arg_list, COM.FSP arg_fgrid)
		{
			
			fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;
			
			for(int i=0; i< arg_list.Rows.Count  ; i++)
			{			
				
				arg_fgrid.AddItem(arg_list.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);			

			}			

		}
		private void Set_Merge_Col()
		{

			fgrid_Main.AllowMerging = AllowMergingEnum.Free;		

			//			for (int i = (int)FlexCDC.ClassLib.TBSXC_PJ_MAST.IxP_FACTORY  ; i <= (int)FlexCDC.ClassLib.TBSXC_PJ_MAST.IxLOAD_UPD_USER + 1 ; i++)
			//				fgrid_Main.Cols[i].AllowMerging = false;		
			
		}

		
		#endregion

		#region 이벤트 처리 
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

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			txt_SRFNo.Clear();

			cmb_Category.SelectedIndex = 0;
			cmb_SeasonCode.SelectedIndex = 0;
			cmb_SRF_No.SelectedIndex = 0;
			cmb_Style.SelectedIndex = 0;
			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

			//Init_Form();
			
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			try
			{				

				this.Cursor = Cursors.WaitCursor;

				fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;
				
				DataTable dt_ret;
				dt_ret = Select_SXC_PJ_Mast();
				Display_Grid(dt_ret, fgrid_Main); 

				Set_Merge_Col();


				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);				
				
				dt_ret.Dispose();

			}
			catch
			{
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch, this);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}
		
		private void txt_SRFNo_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{			

				DataTable dt_ret = Select_SRF_List( cmb_Factory.SelectedValue.ToString(), txt_SRFNo.Text );
				COM.ComCtl.Set_ComboList (dt_ret, cmb_SRF_No, 0, 0, true, 0, 200 );	
				cmb_SRF_No.SelectedIndex = 0;
				dt_ret.Dispose();


			}
		}

		private void cmb_SRF_No_SelectedValueChanged(object sender, System.EventArgs e)
		{

			if (cmb_SRF_No.SelectedIndex ==  -1) 
				return;			

			DataTable dt_ret = Select_Style_List( cmb_Factory.SelectedValue.ToString(), cmb_SRF_No.SelectedValue.ToString() );
			COM.ComCtl.Set_ComboList (dt_ret, cmb_Style, 0, 1, true, 0, 200 );
			cmb_Style.SelectedIndex = 0;
			dt_ret.Dispose();
			
			txt_SRFNo.Clear();
		}

		#endregion

		#region DB Connect

		private DataTable Select_Category_List( string arg_factory )
		{
			
			DataSet ds_list;

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXD_ORDER_01.SELECT_CATEGORY";

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
			ds_list = MyOraDB.Exe_Select_Procedure();
			

			return ds_list.Tables[MyOraDB.Process_Name];

		}

		private DataTable Select_Season_List( string arg_factory )
		{
			
			DataSet ds_list;

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXD_ORDER_01.SELECT_SEASON";

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
			ds_list = MyOraDB.Exe_Select_Procedure();
			

			return ds_list.Tables[MyOraDB.Process_Name];

		}


		private DataTable Select_SRF_List( string arg_factory, string arg_srf_cd )
		{
			
			DataSet ds_list;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXD_ORDER_01.SELECT_SRF_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SRF_NO";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;	
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;	
			MyOraDB.Parameter_Values[1] = arg_srf_cd;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			ds_list = MyOraDB.Exe_Select_Procedure();
			

			return ds_list.Tables[MyOraDB.Process_Name];

		}


		private DataTable Select_Style_List( string arg_factory, string arg_srf_no )
		{
			
			DataSet ds_list;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXD_ORDER_01.SELECT_STYLE_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SRF_NO";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;	
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;	
			MyOraDB.Parameter_Values[1] = arg_srf_no;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			ds_list = MyOraDB.Exe_Select_Procedure();
			

			return ds_list.Tables[MyOraDB.Process_Name];

		}


		private DataTable Select_SXC_PJ_Mast()
		{
			
			DataSet ds_list;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXD_ORDER_01.SELECT_SXC_PJ_MAST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_CATEGORY";	
			MyOraDB.Parameter_Name[2] = "ARG_SEASON_CD";
			MyOraDB.Parameter_Name[3] = "ARG_SRF_NO";
			MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_Combo(cmb_Category," ");	
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_Combo(cmb_SeasonCode," ");
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(cmb_SRF_No," ");
			MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_Combo(cmb_Style," ");
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
			ds_list = MyOraDB.Exe_Select_Procedure();
			

			return ds_list.Tables[MyOraDB.Process_Name];

		}

		
		#endregion 		

		private void Form_Order_Monitoring_Load(object sender, System.EventArgs e)
		{
			try
			{
				//factory 
				DataTable dt_list = COM.ComFunction.Select_Factory_List_CDC();
				COM.ComCtl.Set_Factory_List(dt_list, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;			
			}
			catch
			{

			}
		}

		
	}
}

