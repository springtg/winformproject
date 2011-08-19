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
	public class Form_CM_Rate : COM.PCHWinForm.Pop_Large
	{
		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.Panel pnl_BT;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_TR;
		private System.Windows.Forms.Label lblexcep_mark;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel pnl_B;
		private System.Windows.Forms.StatusBar stbar;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.Label lbl_Date;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.DateTimePicker dpick_FromYMD;
		private System.Windows.Forms.DateTimePicker dpick_ToYMD; 
		private System.ComponentModel.IContainer components = null;

		public Form_CM_Rate()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CM_Rate));
            this.pnl_B = new System.Windows.Forms.Panel();
            this.fgrid_Main = new COM.FSP();
            this.pnl_BT = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.dpick_FromYMD = new System.Windows.Forms.DateTimePicker();
            this.dpick_ToYMD = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.stbar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_B.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
            this.pnl_BT.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
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
            this.c1ToolBar1.Location = new System.Drawing.Point(505, 5);
            // 
            // tbtn_New
            // 
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Location = new System.Drawing.Point(55, 24);
            this.lbl_MainTitle.Size = new System.Drawing.Size(449, 22);
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
            // pnl_B
            // 
            this.pnl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_B.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_B.Controls.Add(this.fgrid_Main);
            this.pnl_B.Controls.Add(this.pnl_BT);
            this.pnl_B.Location = new System.Drawing.Point(0, 60);
            this.pnl_B.Name = "pnl_B";
            this.pnl_B.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.pnl_B.Size = new System.Drawing.Size(792, 484);
            this.pnl_B.TabIndex = 25;
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Main.Location = new System.Drawing.Point(4, 60);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Size = new System.Drawing.Size(784, 420);
            this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Main.Styles"));
            this.fgrid_Main.TabIndex = 164;
            // 
            // pnl_BT
            // 
            this.pnl_BT.Controls.Add(this.pnl_SearchImage);
            this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BT.Location = new System.Drawing.Point(4, 0);
            this.pnl_BT.Name = "pnl_BT";
            this.pnl_BT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.pnl_BT.Size = new System.Drawing.Size(784, 60);
            this.pnl_BT.TabIndex = 0;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.lblexcep_mark);
            this.pnl_SearchImage.Controls.Add(this.dpick_FromYMD);
            this.pnl_SearchImage.Controls.Add(this.dpick_ToYMD);
            this.pnl_SearchImage.Controls.Add(this.lbl_Date);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Controls.Add(this.pictureBox6);
            this.pnl_SearchImage.Controls.Add(this.textBox1);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(784, 56);
            this.pnl_SearchImage.TabIndex = 20;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(683, 32);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(101, 18);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(768, 0);
            this.picb_TR.Name = "picb_TR";
            this.picb_TR.Size = new System.Drawing.Size(16, 32);
            this.picb_TR.TabIndex = 21;
            this.picb_TR.TabStop = false;
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(228, 35);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(14, 18);
            this.lblexcep_mark.TabIndex = 146;
            this.lblexcep_mark.Text = "~";
            // 
            // dpick_FromYMD
            // 
            this.dpick_FromYMD.CustomFormat = "";
            this.dpick_FromYMD.Font = new System.Drawing.Font("Verdana", 9F);
            this.dpick_FromYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_FromYMD.Location = new System.Drawing.Point(108, 30);
            this.dpick_FromYMD.Name = "dpick_FromYMD";
            this.dpick_FromYMD.Size = new System.Drawing.Size(120, 22);
            this.dpick_FromYMD.TabIndex = 150;
            this.dpick_FromYMD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dpick_FromYMD_KeyPress);
            // 
            // dpick_ToYMD
            // 
            this.dpick_ToYMD.CustomFormat = "";
            this.dpick_ToYMD.Font = new System.Drawing.Font("Verdana", 9F);
            this.dpick_ToYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_ToYMD.Location = new System.Drawing.Point(242, 30);
            this.dpick_ToYMD.Name = "dpick_ToYMD";
            this.dpick_ToYMD.Size = new System.Drawing.Size(120, 22);
            this.dpick_ToYMD.TabIndex = 149;
            this.dpick_ToYMD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dpick_ToYMD_KeyPress);
            // 
            // lbl_Date
            // 
            this.lbl_Date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ImageIndex = 0;
            this.lbl_Date.ImageList = this.img_Label;
            this.lbl_Date.Location = new System.Drawing.Point(7, 30);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(100, 21);
            this.lbl_Date.TabIndex = 148;
            this.lbl_Date.Text = "Date";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_TM
            // 
            this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
            this.picb_TM.Location = new System.Drawing.Point(224, 0);
            this.picb_TM.Name = "picb_TM";
            this.picb_TM.Size = new System.Drawing.Size(544, 30);
            this.picb_TM.TabIndex = 0;
            this.picb_TM.TabStop = false;
            // 
            // lbl_SubTitle1
            // 
            this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
            this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle1.Name = "lbl_SubTitle1";
            this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle1.TabIndex = 28;
            this.lbl_SubTitle1.Text = "      Common Component Info.";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(771, 41);
            this.picb_BR.Name = "picb_BR";
            this.picb_BR.Size = new System.Drawing.Size(13, 15);
            this.picb_BR.TabIndex = 23;
            this.picb_BR.TabStop = false;
            // 
            // picb_BM
            // 
            this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
            this.picb_BM.Location = new System.Drawing.Point(123, 40);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(648, 17);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 41);
            this.picb_BL.Name = "picb_BL";
            this.picb_BL.Size = new System.Drawing.Size(144, 19);
            this.picb_BL.TabIndex = 22;
            this.picb_BL.TabStop = false;
            // 
            // picb_ML
            // 
            this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
            this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
            this.picb_ML.Location = new System.Drawing.Point(0, 22);
            this.picb_ML.Name = "picb_ML";
            this.picb_ML.Size = new System.Drawing.Size(144, 26);
            this.picb_ML.TabIndex = 25;
            this.picb_ML.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(137, 22);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(640, 19);
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 21);
            this.textBox1.TabIndex = 145;
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 546);
            this.stbar.Name = "stbar";
            this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.stbar.ShowPanels = true;
            this.stbar.Size = new System.Drawing.Size(792, 20);
            this.stbar.TabIndex = 43;
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            // 
            // Form_CM_Rate
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.stbar);
            this.Controls.Add(this.pnl_B);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_CM_Rate";
            this.Controls.SetChildIndex(this.pnl_B, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_B.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.pnl_BT.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion  

		#region 사용자 변수

		private COM.ComFunction MyComFunction = new COM.ComFunction();

		#endregion 

		#region 멤버 메서드
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			try
			{ 
				//Title
				this.Text = "Rate Information";
				lbl_MainTitle.Text	= "Rate Information";

				ClassLib.ComFunction.SetLangDic(this);
			
				tbtn_New.Enabled	= false;
				tbtn_Save.Enabled	= false;
				tbtn_Append.Enabled = false;
				tbtn_Insert.Enabled = false;
				tbtn_Delete.Enabled = false;
				tbtn_Conform.Enabled  = false;
				tbtn_Print.Enabled  = false;
			 
				// 그리드 설정 Tree
				fgrid_Main.Set_Grid("SCM_EXCH_RATE", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, false);
				//ClassLib.ComFunction.Set_TreeHeader(fgrid_Main);
 
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
 
				//date 초기화  
				string nowymd = System.DateTime.Now.ToString("yyyyMMdd");

				dpick_FromYMD.Text = MyComFunction.ConvertDate2Type(nowymd);
				dpick_ToYMD.Text = MyComFunction.ConvertDate2Type(nowymd); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
  

		#endregion

		#region 이벤트 처리

		#region 툴바 메뉴 이벤트 처리
				
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				Clear();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		/// <summary>
		/// Clear : 
		/// </summary>
		private void Clear()
		{
			//date 초기화  
			string nowymd = System.DateTime.Now.ToString("yyyyMMdd");

			dpick_FromYMD.Text = MyComFunction.ConvertDate2Type(nowymd);
			dpick_ToYMD.Text = MyComFunction.ConvertDate2Type(nowymd); 

			//그리드 초기화
			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
		}


		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 	
				DataTable dt_ret; 

				this.Cursor = System.Windows.Forms.Cursors.WaitCursor; 
			
				dt_ret = Select_SCM_EXCH_RATE();
				Display_Tree(dt_ret);
				dt_ret.Dispose();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
			}
		}


		/// <summary>
		/// Display_Tree : 
		/// </summary>
		/// <param name="dt_ret"></param>
		private void Display_Tree(DataTable arg_dt)
		{
			int row_fixed = fgrid_Main.Rows.Fixed;
			int level = -1;

			fgrid_Main.Rows.Count = row_fixed;

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				level = int.Parse(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSCM_EXCH_RATE.IxTB_TREE_LEVEL].ToString()) - 1;

				fgrid_Main.Rows.InsertNode(i + row_fixed, level);
				
				if(level == 0)
				{
					fgrid_Main[i + row_fixed, (int)ClassLib.TBSCM_EXCH_RATE.IxYMD_CURRCD] 
						= MyComFunction.ConvertDate2Type(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSCM_EXCH_RATE.IxTB_YMD].ToString() ); 

					fgrid_Main[i + row_fixed, (int)ClassLib.TBSCM_EXCH_RATE.IxSTDEXCH] = "";


					fgrid_Main.Rows[i + row_fixed].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;

				}
				else if(level == 1)
				{
					fgrid_Main[i + row_fixed, (int)ClassLib.TBSCM_EXCH_RATE.IxYMD_CURRCD] 
						= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSCM_EXCH_RATE.IxTB_CURRCD].ToString();

					fgrid_Main[i + row_fixed, (int)ClassLib.TBSCM_EXCH_RATE.IxSTDEXCH] 
						= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSCM_EXCH_RATE.IxTB_STDEXCH].ToString();
 	
				} 
 
			}

			fgrid_Main.Tree.Column = (int)ClassLib.TBSCM_EXCH_RATE.IxYMD_CURRCD;
			fgrid_Main.Tree.Style = TreeStyleFlags.Complete;
			fgrid_Main.Tree.Show(-1); 

		}


		#endregion		

		#region 컨트롤 이벤트 처리
	 
		private void dpick_FromYMD_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);  
		}

		private void dpick_ToYMD_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e); 
		}
		 

		#endregion

		#endregion 

		#region DB Connect

		public DataTable Select_SCM_EXCH_RATE()
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;
 
			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SCM_EXCH_RATE.SELECT_RATE";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_YMD_FROM";
			MyOraDB.Parameter_Name[1] = "ARG_YMD_TO";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
			     
			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = MyComFunction.ConvertDate2DbType(dpick_FromYMD.Text);
			MyOraDB.Parameter_Values[1] = MyComFunction.ConvertDate2DbType(dpick_ToYMD.Text); 
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}
 
		
		#endregion																								

		
		
	
	}
}

