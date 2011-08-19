using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexBase.MaterialBase
{
	public class Form_CM_Customer : COM.PCHWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
        public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.TextBox txt_cust_name;
		private System.Windows.Forms.Label lbl_cust_name;
		private System.Windows.Forms.TextBox txt_cust_cd;
		private System.Windows.Forms.Label lbl_cust_cd;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.TextBox txt_web_cust_cd;
		private System.Windows.Forms.Label lbl_web_cust_cd;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
        public System.Windows.Forms.PictureBox picb_TR;
        private Panel panel2;
        private Panel panel3;
        private Label btn_recover;
        private Label btn_Insert;
        public COM.FSP fgrid_Cust;
		private System.ComponentModel.IContainer components = null;

		public Form_CM_Customer()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			
			Init_Form();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CM_Customer));
            C1.Win.C1List.Style style25 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style26 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style27 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style28 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style29 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style30 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style31 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style32 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_Cust = new COM.FSP();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_recover = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Label();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.txt_web_cust_cd = new System.Windows.Forms.TextBox();
            this.lbl_web_cust_cd = new System.Windows.Forms.Label();
            this.txt_cust_name = new System.Windows.Forms.TextBox();
            this.lbl_cust_name = new System.Windows.Forms.Label();
            this.txt_cust_cd = new System.Windows.Forms.TextBox();
            this.lbl_cust_cd = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Cust)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
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
            this.c1ToolBar1.Location = new System.Drawing.Point(729, 8);
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
            // tbtn_Save
            // 
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 643);
            this.stbar.Size = new System.Drawing.Size(1016, 23);
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
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.SystemColors.Window;
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.fgrid_Cust);
            this.c1Sizer1.Controls.Add(this.panel2);
            this.c1Sizer1.Controls.Add(this.pnl_Search);
            this.c1Sizer1.GridDefinition = "17.3611111111111:False:True;75.6944444444444:False:False;6.94444444444444:False:T" +
                "rue;\t0.589970501474926:False:True;98.4267453294002:False:False;0.983284169124877" +
                ":False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1017, 576);
            this.c1Sizer1.SplitterWidth = 0;
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_Cust
            // 
            this.fgrid_Cust.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Cust.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Cust.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Cust.Location = new System.Drawing.Point(6, 100);
            this.fgrid_Cust.Name = "fgrid_Cust";
            this.fgrid_Cust.Rows.DefaultSize = 19;
            this.fgrid_Cust.Size = new System.Drawing.Size(1001, 436);
            this.fgrid_Cust.StyleInfo = resources.GetString("fgrid_Cust.StyleInfo");
            this.fgrid_Cust.TabIndex = 169;
            this.fgrid_Cust.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Cust_AfterEdit);
            this.fgrid_Cust.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_Cust_MouseUp);
            this.fgrid_Cust.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Cust_BeforeEdit);
            this.fgrid_Cust.DoubleClick += new System.EventHandler(this.fgrid_Cust_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(6, 536);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 40);
            this.panel2.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_recover);
            this.panel3.Controls.Add(this.btn_Insert);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(801, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 40);
            this.panel3.TabIndex = 0;
            // 
            // btn_recover
            // 
            this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_recover.ImageIndex = 1;
            this.btn_recover.ImageList = this.image_List;
            this.btn_recover.Location = new System.Drawing.Point(101, 9);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(80, 23);
            this.btn_recover.TabIndex = 348;
            this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Insert.ImageIndex = 9;
            this.btn_Insert.ImageList = this.image_List;
            this.btn_Insert.Location = new System.Drawing.Point(20, 9);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 23);
            this.btn_Insert.TabIndex = 347;
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // pnl_Search
            // 
            this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Search.Controls.Add(this.pnl_SearchImage);
            this.pnl_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Search.Location = new System.Drawing.Point(0, 0);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Padding = new System.Windows.Forms.Padding(7);
            this.pnl_Search.Size = new System.Drawing.Size(1017, 100);
            this.pnl_Search.TabIndex = 44;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.txt_web_cust_cd);
            this.pnl_SearchImage.Controls.Add(this.lbl_web_cust_cd);
            this.pnl_SearchImage.Controls.Add(this.txt_cust_name);
            this.pnl_SearchImage.Controls.Add(this.lbl_cust_name);
            this.pnl_SearchImage.Controls.Add(this.txt_cust_cd);
            this.pnl_SearchImage.Controls.Add(this.lbl_cust_cd);
            this.pnl_SearchImage.Controls.Add(this.cmb_factory);
            this.pnl_SearchImage.Controls.Add(this.lbl_factory);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Controls.Add(this.picb_MM);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(7, 7);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1003, 86);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // picb_TM
            // 
            this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
            this.picb_TM.Location = new System.Drawing.Point(224, 0);
            this.picb_TM.Name = "picb_TM";
            this.picb_TM.Size = new System.Drawing.Size(762, 32);
            this.picb_TM.TabIndex = 535;
            this.picb_TM.TabStop = false;
            // 
            // lbl_SubTitle1
            // 
            this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
            this.lbl_SubTitle1.Location = new System.Drawing.Point(-22, -1);
            this.lbl_SubTitle1.Name = "lbl_SubTitle1";
            this.lbl_SubTitle1.Size = new System.Drawing.Size(275, 32);
            this.lbl_SubTitle1.TabIndex = 536;
            this.lbl_SubTitle1.Text = "           Vendor Info.";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(985, 69);
            this.picb_BR.Name = "picb_BR";
            this.picb_BR.Size = new System.Drawing.Size(18, 17);
            this.picb_BR.TabIndex = 534;
            this.picb_BR.TabStop = false;
            // 
            // txt_web_cust_cd
            // 
            this.txt_web_cust_cd.BackColor = System.Drawing.Color.White;
            this.txt_web_cust_cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_web_cust_cd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_web_cust_cd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_web_cust_cd.Location = new System.Drawing.Point(717, 55);
            this.txt_web_cust_cd.MaxLength = 6;
            this.txt_web_cust_cd.Name = "txt_web_cust_cd";
            this.txt_web_cust_cd.Size = new System.Drawing.Size(184, 21);
            this.txt_web_cust_cd.TabIndex = 3;
            this.txt_web_cust_cd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_web_cust_cd_KeyPress);
            // 
            // lbl_web_cust_cd
            // 
            this.lbl_web_cust_cd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_web_cust_cd.ImageIndex = 0;
            this.lbl_web_cust_cd.ImageList = this.img_Label;
            this.lbl_web_cust_cd.Location = new System.Drawing.Point(616, 55);
            this.lbl_web_cust_cd.Name = "lbl_web_cust_cd";
            this.lbl_web_cust_cd.Size = new System.Drawing.Size(100, 21);
            this.lbl_web_cust_cd.TabIndex = 533;
            this.lbl_web_cust_cd.Text = "Web Code";
            this.lbl_web_cust_cd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cust_name
            // 
            this.txt_cust_name.BackColor = System.Drawing.Color.White;
            this.txt_cust_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cust_name.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_cust_name.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_cust_name.Location = new System.Drawing.Point(413, 55);
            this.txt_cust_name.MaxLength = 100;
            this.txt_cust_name.Name = "txt_cust_name";
            this.txt_cust_name.Size = new System.Drawing.Size(184, 21);
            this.txt_cust_name.TabIndex = 2;
            this.txt_cust_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cust_name_KeyPress);
            // 
            // lbl_cust_name
            // 
            this.lbl_cust_name.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_cust_name.ImageIndex = 0;
            this.lbl_cust_name.ImageList = this.img_Label;
            this.lbl_cust_name.Location = new System.Drawing.Point(312, 55);
            this.lbl_cust_name.Name = "lbl_cust_name";
            this.lbl_cust_name.Size = new System.Drawing.Size(100, 21);
            this.lbl_cust_name.TabIndex = 531;
            this.lbl_cust_name.Text = "Vendor Name";
            this.lbl_cust_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cust_cd
            // 
            this.txt_cust_cd.BackColor = System.Drawing.Color.White;
            this.txt_cust_cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cust_cd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_cust_cd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_cust_cd.Location = new System.Drawing.Point(109, 55);
            this.txt_cust_cd.MaxLength = 6;
            this.txt_cust_cd.Name = "txt_cust_cd";
            this.txt_cust_cd.Size = new System.Drawing.Size(184, 21);
            this.txt_cust_cd.TabIndex = 1;
            this.txt_cust_cd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cust_cd_KeyPress);
            // 
            // lbl_cust_cd
            // 
            this.lbl_cust_cd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_cust_cd.ImageIndex = 0;
            this.lbl_cust_cd.ImageList = this.img_Label;
            this.lbl_cust_cd.Location = new System.Drawing.Point(8, 54);
            this.lbl_cust_cd.Name = "lbl_cust_cd";
            this.lbl_cust_cd.Size = new System.Drawing.Size(100, 21);
            this.lbl_cust_cd.TabIndex = 529;
            this.lbl_cust_cd.Text = "Vendor Code";
            this.lbl_cust_cd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AccessibleDescription = "";
            this.cmb_factory.AccessibleName = "";
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style25;
            this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_factory.ColumnCaptionHeight = 18;
            this.cmb_factory.ColumnFooterHeight = 18;
            this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_factory.ContentHeight = 16;
            this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_factory.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory.EditorHeight = 16;
            this.cmb_factory.EvenRowStyle = style26;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style27;
            this.cmb_factory.HeadingStyle = style28;
            this.cmb_factory.HighLightRowStyle = style29;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 33);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 5;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style30;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style31;
            this.cmb_factory.Size = new System.Drawing.Size(184, 20);
            this.cmb_factory.Style = style32;
            this.cmb_factory.TabIndex = 0;
            this.cmb_factory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_factory_KeyPress);
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 32);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 526;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(900, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(122, 40);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_BM
            // 
            this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
            this.picb_BM.Location = new System.Drawing.Point(143, 68);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(844, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 69);
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
            this.picb_ML.Size = new System.Drawing.Size(168, 48);
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
            this.picb_MM.Location = new System.Drawing.Point(143, 32);
            this.picb_MM.Name = "picb_MM";
            this.picb_MM.Size = new System.Drawing.Size(836, 52);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(985, 0);
            this.picb_TR.Name = "picb_TR";
            this.picb_TR.Size = new System.Drawing.Size(18, 43);
            this.picb_TR.TabIndex = 29;
            this.picb_TR.TabStop = false;
            // 
            // Form_CM_Customer
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_CM_Customer";
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Cust)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnl_Search.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
 
		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion  

		#region 멤버 메서드

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			try
			{
				DataTable dt_ret;

				//Title
				this.Text = "Vendor Master";
				lbl_MainTitle.Text = "Vendor Master";

				//영문변환 사용
				ClassLib.ComFunction.SetLangDic(this);
 
				tbtn_Delete.Enabled  = false;
				tbtn_Confirm.Enabled = false;


//				// 그리드 설정
//				fgrid_Cust.Set_Grid("SCM_CUST", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);  
//				fgrid_Cust.Set_Action_Image(img_Action); 


				//-------------------------------------------------------------------------------------------------------------------
				// 그리드 설정  
				// 업무코드에 따라서 그리드 헤더 설정 
				//-------------------------------------------------------------------------------------------------------------------
				switch( ClassLib.ComVar.This_JobCdoe )
				{
					case ClassLib.ComVar.CxJobCd_Material:
                        if (ClassLib.ComVar.This_Factory != "DS")
                        {
                            fgrid_Cust.Set_Grid("SCM_CUST_B", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                            break;

                        }
                        else
                        {
                            fgrid_Cust.Set_Grid("SCM_CUST_B", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                            break;
                        }
						
 

					case ClassLib.ComVar.CxJobCd_Trade:
						
						fgrid_Cust.Set_Grid("SCM_CUST_T", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);  
						break; 

				} // end switch

				fgrid_Cust.Set_Action_Image(img_Action); 

				//-------------------------------------------------------------------------------------------------------------------
				 



				// 공장 콤보
				dt_ret = ClassLib.ComFunction.Select_Factory_List();
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 

				cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
			
				//담당자 콤보
				Set_Combo_ManCharge(); 




				dt_ret.Dispose();


                btn_Insert.Enabled  =false;
                btn_recover.Enabled = false;

                if (ClassLib.ComVar.This_Factory != "DS")
                {
                    btn_Insert.Enabled  =true;
                    btn_recover.Enabled =true;

                }
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



		/// <summary>
		/// Set_Combo_ManCharge : 담당자 콤보
		/// </summary>
		private void Set_Combo_ManCharge()
		{

			if(cmb_factory.SelectedIndex == -1) return;


			DataTable dt_ret;

			dt_ret = ClassLib.ComFunction.Select_Man_Charge(cmb_factory.SelectedValue.ToString() ); 




			int col_code = 1; 
			//int col_name = 2; 

			System.Collections.Specialized.ListDictionary ld = new System.Collections.Specialized.ListDictionary(); 


			ld.Add("", "");

			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
				ld.Add(dt_ret.Rows[i].ItemArray[col_code].ToString(), dt_ret.Rows[i].ItemArray[col_code].ToString());
			}
 

			fgrid_Cust.Cols[(int)ClassLib.TBSCM_CUST.IxMAN_CHARGE].DataMap = ld;  




			dt_ret.Dispose();


		}

 

		/// <summary>
		/// Search_Customer : 데이터 조회
		/// </summary>
		public void Search_Customer()
		{
			DataTable dt_ret;

			try
			{
				if(cmb_factory.SelectedIndex == -1) return;

				this.Cursor = Cursors.WaitCursor;

				dt_ret = Select_Customer(cmb_factory.SelectedValue.ToString(), 
					ClassLib.ComFunction.Empty_String(txt_cust_cd.Text, " "), 
					ClassLib.ComFunction.Empty_String(txt_cust_name.Text, " "), 
					ClassLib.ComFunction.Empty_String(txt_web_cust_cd.Text, " ") );

				Display_Grid(dt_ret, fgrid_Cust); 
				UseYN_RowColor(dt_ret);
				
				dt_ret.Dispose();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Customer", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}	
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}




		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_Grid(DataTable arg_dt, COM.FSP arg_fgrid)
		{
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;  
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1;
  
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
				arg_fgrid[arg_fgrid.Rows.Count - 1, 0] = ""; 
			}
			arg_dt.Dispose();
		}


		/// <summary>
		/// UseYN이 Flase 일경우 해당 RowData 글자색을 빨간색으로...
		/// </summary>
		public void UseYN_RowColor(DataTable arg_dt)
		{
			int row_fixed = fgrid_Cust.Rows.Fixed;

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSCM_CUST.IxUSE_YN - 1].ToString() == "Y" ) continue;
				  
				fgrid_Cust.GetCellRange(i + row_fixed, 0, i + row_fixed, fgrid_Cust.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrWarning; 
			}

			arg_dt.Dispose();
		}



		/// <summary>
		/// Save_Customer : 
		/// </summary>
		public void Save_Customer()
		{
			try
			{
				int sel_row = fgrid_Cust.Selection.r1;
				bool save_flag = false;

				//행 수정 상태 해제
				fgrid_Cust.Select(sel_row, 0, sel_row, fgrid_Cust.Cols.Count - 1, false);

				//저장
				save_flag = MyOraDB.Save_FlexGird("PKG_SCM_CUST.SAVE_SCM_CUST", fgrid_Cust);

				if(save_flag)
				{
					//수정후 조회
 					Search_Customer();  

					//Refresh_Customer();

					fgrid_Cust.TopRow = sel_row;

					//메세지처리
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
				}
				else
				{
					//메세지처리
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
				}

				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Customer", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}
		}




		/// <summary>
		/// Refresh_Customer : 
		/// </summary>
		private void Refresh_Customer()
		{

			string use_yn = "";

			for(int i = fgrid_Cust.Rows.Count - 1; i >= fgrid_Cust.Rows.Fixed ; i--)
			{
				if(fgrid_Cust[i, 0].ToString() == "") continue;

				if(fgrid_Cust[i, 0].ToString() == "D")
				{
					fgrid_Cust.Rows.Remove(i);
				}
				else
				{
					fgrid_Cust[i, 0] = "";

				} // end if



				use_yn = fgrid_Cust[i, (int)ClassLib.TBSCM_CUST.IxUSE_YN].ToString();

				if(use_yn == "Y")
				{
					fgrid_Cust.GetCellRange(i, 0, i, fgrid_Cust.Cols.Count - 1).StyleNew.Clear();
				}
				else
				{ 
					fgrid_Cust.GetCellRange(i, 0, i, fgrid_Cust.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrWarning; 
				}


			} // end for i 

		}


		private void  SetPrintYield()
		{
			try
			{   
	
						 
				string mrd_Filename = "Report/Material/Form_CM_Vendor_Master.mrd" ;
				string Para         = " ";

				#region 출력조건

				int  iCnt  = 4;
				string [] aHead =  new string[iCnt];	

				aHead[0]    = cmb_factory.SelectedValue.ToString();
				aHead[1]    = ClassLib.ComFunction.Empty_String(txt_cust_cd.Text, " ");
				aHead[2]    = ClassLib.ComFunction.Empty_String(txt_cust_name.Text, " ");
				aHead[3]    = ClassLib.ComFunction.Empty_String(txt_web_cust_cd.Text, " ");

				#endregion
	
				Para = 	" /rp ";
				for (int i  = 1 ; i<= iCnt ; i++)
				{				
					Para = Para + "[" + aHead[i-1] + "] ";
				}
	
				FlexBase.Report.Form_RdViewer   report = new FlexBase.Report.Form_RdViewer ( mrd_Filename, Para);
				report.Show();	

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetPrintYield", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}
		

		#endregion
 
		#region 이벤트 처리


		#region 이벤트_상속버튼

		/// <summary>
		/// 조회조건, 그리드 Clear
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			cmb_factory.SelectedIndex = -1;
			txt_cust_cd.Text = "";
			txt_cust_name.Text = "";
			txt_web_cust_cd.Text = "";
			fgrid_Cust.Rows.Count = fgrid_Cust.Rows.Fixed;
		}

		/// <summary>
		/// 조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Search_Customer();
		}

		/// <summary>
		/// 저장
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Save_Customer();
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			SetPrintYield();
		}


        private void btn_Insert_Click(object sender, EventArgs e)
        {
            fgrid_Cust.Rows.Count = fgrid_Cust.Rows.Count + 1;
            fgrid_Cust[fgrid_Cust.Rows.Count - 1, 0] = "I"; fgrid_Cust[fgrid_Cust.Rows.Count - 1, 1] = cmb_factory.SelectedValue.ToString();
        }


        private void btn_recover_Click(object sender, EventArgs e)
        {

            if (fgrid_Cust[fgrid_Cust.Selection.r1, 0].ToString() == "I")
                fgrid_Cust.RemoveItem(fgrid_Cust.Selection.r1);
            
        }




		#endregion 

		#region 이벤트_그리드관련

		private void fgrid_Cust_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if ((fgrid_Cust.Rows.Fixed > 0) && (fgrid_Cust.Row >= fgrid_Cust.Rows.Fixed))
			{
				fgrid_Cust.Buffer_CellData = (fgrid_Cust[fgrid_Cust.Row, fgrid_Cust.Col] == null) ? "" : fgrid_Cust[fgrid_Cust.Row, fgrid_Cust.Col].ToString();
			}
		}

		private void fgrid_Cust_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_Cust.Update_Row(); 
		}

		/// <summary>
		/// 그리드 더블 클릭시 상세정보 팝업
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fgrid_Cust_DoubleClick(object sender, System.EventArgs e)
		{
			try
			{

				//------------------------------------------------------------------------------------------------------------------- 
				// 업무코드에 따라서 팝업 실행 여부 설정
				//-------------------------------------------------------------------------------------------------------------------
				if( ClassLib.ComVar.This_JobCdoe !=  ClassLib.ComVar.CxJobCd_Material) return;
				//-------------------------------------------------------------------------------------------------------------------
				 



				//행 수정 상태 해제
				fgrid_Cust.Select(fgrid_Cust.Selection.r1, 0, fgrid_Cust.Selection.r1, fgrid_Cust.Cols.Count - 1, false);
				int sel_row = fgrid_Cust.Selection.r1;

				if(sel_row < fgrid_Cust.Rows.Fixed) return; 

				ClassLib.ComVar.Parameter_PopUp = new string[]
				{
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxFACTORY].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxCUST_CD].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxENTPREGNO].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxUPCUST_CD].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxCUST_NAME].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxCUST_OMITNM].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxLAWREGNO].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxREPNM].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxREPJUMIN].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxUPTNM].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxITEMNM].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxAGTTYPE].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxCASHMOVEBANKNO].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxCASHACCOUNTNO].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxCASHACCOUNTNM].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxBILLMOVEBANKNO].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxBILLACCOUNTNO].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxBILLACCOUNTNM].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxADDR].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxTELNO].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxFAXNO].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxZIPNO1].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxZIPNO2].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxPAYTYPE].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxPAYTIME].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxWEB_CUST_CD].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxWEB_PASS].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxEMAIL].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxBAR_YN].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxRETURN_YN].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxCUST_PUR_TYPE].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxREMARKS].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxTRADE_CUST].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxMAN_CUST].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxMAN_CHARGE].ToString(),
					fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxUSE_YN].ToString()
				};

				Pop_Customer pop_form = new Pop_Customer();
				pop_form.ShowDialog();
				
				if(!pop_form._Close_Save) return; 

				//팝업 닫고 난뒤에 저장 메세지, 그리드 다시 조회 
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
				//Search_Customer();


				fgrid_Cust.TopRow = sel_row;



//				COM.ComVar.Parameter_PopUp = new string[] { ClassLib.ComFunction.Empty_TextBox(txt_Webcountcd, ""),
//															  ClassLib.ComFunction.Empty_TextBox(txt_Webpass, ""), 
//															  ClassLib.ComFunction.Empty_TextBox(txt_Email, ""),
//															  ClassLib.ComFunction.Empty_Combo(cmb_Baryn, ""),
//															  ClassLib.ComFunction.Empty_Combo(cmb_Returnyn, ""),
//															  ClassLib.ComFunction.Empty_Combo(cmb_Custpurtype, ""),
//															  ClassLib.ComFunction.Empty_TextBox(txt_Remarks, ""),
//															  ClassLib.ComFunction.Empty_TextBox(txt_Tradecust, ""),
//															  ClassLib.ComFunction.Empty_TextBox(txt_Mancust, ""),
//															  ClassLib.ComFunction.Empty_Combo(cmb_Mancharge, ""),
//															  ClassLib.ComFunction.Empty_Combo(cmb_UseYN, "") };



                fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxWEB_CUST_CD] = COM.ComVar.Parameter_PopUp[0];
				fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxWEB_PASS] = COM.ComVar.Parameter_PopUp[1];
				fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxEMAIL] = COM.ComVar.Parameter_PopUp[2];
				fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxBAR_YN] = COM.ComVar.Parameter_PopUp[3];
				fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxRETURN_YN] = COM.ComVar.Parameter_PopUp[4];
				fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxCUST_PUR_TYPE] = COM.ComVar.Parameter_PopUp[5];
				fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxREMARKS] = COM.ComVar.Parameter_PopUp[6];
				fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxTRADE_CUST] = COM.ComVar.Parameter_PopUp[7];
				fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxMAN_CUST] = COM.ComVar.Parameter_PopUp[8];
				fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxMAN_CHARGE] = COM.ComVar.Parameter_PopUp[9];
				fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxUSE_YN] = COM.ComVar.Parameter_PopUp[10];
				

				string use_yn = fgrid_Cust[sel_row, (int)ClassLib.TBSCM_CUST.IxUSE_YN].ToString();

				if(use_yn == "Y")
				{
					fgrid_Cust.GetCellRange(sel_row, 0, sel_row, fgrid_Cust.Cols.Count - 1).StyleNew.Clear();
				}
				else
				{ 
					fgrid_Cust.GetCellRange(sel_row, 0, sel_row, fgrid_Cust.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrWarning; 
				}





				  
			}

			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Cust_DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}
		}

		#endregion 

		#region 이벤트_ Enter키 이동

		private void cmb_factory_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void txt_cust_cd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);

			if(e.KeyChar == (char)13) Search_Customer();
		}

		private void txt_cust_name_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);

			if(e.KeyChar == (char)13) Search_Customer();
		}

		private void txt_web_cust_cd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)13) Search_Customer();
		}

		#endregion

		private void fgrid_Cust_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				Set_Update_SelectionRow(e);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "sgrid_Item_MouseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}
 



		/// <summary>
		/// 여러 행 선택 후 데이터 일괄 수정 
		/// </summary>
		/// <param name="e"></param>
		private void Set_Update_SelectionRow(System.Windows.Forms.MouseEventArgs e)
		{

			// 마우스 오른쪽 이벤트에만 팝업창 실행
			if(! e.Button.Equals(MouseButtons.Right) ) return;

			if(fgrid_Cust.Rows.Count < fgrid_Cust.Rows.Fixed) return;


			int sel_row = fgrid_Cust.Rows[fgrid_Cust.Row].Index;  
			int sel_col = fgrid_Cust.Cols[fgrid_Cust.Col].Index;  
			 

			if (! fgrid_Cust.Cols[sel_col].AllowEditing) return;


	

			C1.Win.C1FlexGrid.CellRange cell = fgrid_Cust.GetCellRange(sel_row, sel_col);
 
			
			// 헤더 Description
			string column_desc = fgrid_Cust[1, sel_col].ToString();


			Pop_SelectionChange_FSP pop_form = new Pop_SelectionChange_FSP(fgrid_Cust, cell, column_desc);
			pop_form.ShowDialog();




			if(! pop_form._Close_Save) return;

			//--------------------------------------------------------------------------------------
			// set update list
			//--------------------------------------------------------------------------------------
			int[] selection_range = fgrid_Cust.Selections;

			foreach (int i in selection_range)
			{
				fgrid_Cust[i, sel_col] = COM.ComVar.Parameter_PopUp[0];
				fgrid_Cust.Update_Row(i);
			}
  
	  
			//--------------------------------------------------------------------------------------
  
			


		}

		 
		#endregion 

		#region DB Connect


		/// <summary>
		/// 거래처 조회
		/// </summary>
		/// <returns></returns>
		public static DataTable Select_Customer(string arg_factory, string arg_cust_cd, string arg_cust_name, string arg_web_cust_cd)
		{
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet ds_ret;
 
			MyOraDB.ReDim_Parameter(5); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SCM_CUST.SELECT_SCM_CUST_LIKE";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[2] = "ARG_CUST_NAME";
			MyOraDB.Parameter_Name[3] = "ARG_WEB_CUST_CD";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_factory; 
			MyOraDB.Parameter_Values[1] = arg_cust_cd; 
			MyOraDB.Parameter_Values[2] = arg_cust_name; 
			MyOraDB.Parameter_Values[3] = arg_web_cust_cd; 
			MyOraDB.Parameter_Values[4] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}
	
		#endregion

     

     

	}
}

