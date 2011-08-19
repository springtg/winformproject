using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing; 
using System.Windows.Forms;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType; 
using System.Data.OleDb;
using Microsoft.Office.Core;


namespace FlexPurchase.Search
{
	public class Form_BW_Pegasus_Upload : COM.PCHWinForm.Form_Top
	{

		#region 디자이너에서 생성한 멤버

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView sheetView1; 
		
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.Label lbl_OpenFile;
		private System.Windows.Forms.TextBox txt_OpenFile;
		private System.Windows.Forms.Label btn_OpenFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label lbl_UploadOption;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rad_DayGAC;
		private System.Windows.Forms.RadioButton rad_RGACOGAC;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 멤버
 
		private COM.OraDB MyOraDB = new COM.OraDB();
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_RGACFence;
		private System.Windows.Forms.DateTimePicker dpick_From;
		private System.Windows.Forms.DateTimePicker dpick_To;
		private COM.ComFunction MyComFunction = new COM.ComFunction();  
 

		#endregion

		#region 생성자 / 소멸자

		public Form_BW_Pegasus_Upload()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BW_Pegasus_Upload));
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.dpick_From = new System.Windows.Forms.DateTimePicker();
            this.dpick_To = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_RGACFence = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_RGACOGAC = new System.Windows.Forms.RadioButton();
            this.rad_DayGAC = new System.Windows.Forms.RadioButton();
            this.txt_OpenFile = new System.Windows.Forms.TextBox();
            this.lbl_OpenFile = new System.Windows.Forms.Label();
            this.lbl_UploadOption = new System.Windows.Forms.Label();
            this.btn_OpenFile = new System.Windows.Forms.Label();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.spd_main = new COM.SSP();
            this.sheetView1 = new FarPoint.Win.Spread.SheetView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_head.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetView1)).BeginInit();
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
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.GridDefinition = "15.7986111111111:False:True;82.8125:True:False;0:False:True;\t0.393700787401575:Fa" +
                "lse:True;98.4251968503937:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.dpick_From);
            this.pnl_head.Controls.Add(this.dpick_To);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.lbl_RGACFence);
            this.pnl_head.Controls.Add(this.groupBox1);
            this.pnl_head.Controls.Add(this.txt_OpenFile);
            this.pnl_head.Controls.Add(this.lbl_OpenFile);
            this.pnl_head.Controls.Add(this.lbl_UploadOption);
            this.pnl_head.Controls.Add(this.btn_OpenFile);
            this.pnl_head.Controls.Add(this.lbl_SubTitle1);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1008, 91);
            this.pnl_head.TabIndex = 175;
            // 
            // dpick_From
            // 
            this.dpick_From.CustomFormat = "";
            this.dpick_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_From.Location = new System.Drawing.Point(437, 41);
            this.dpick_From.Name = "dpick_From";
            this.dpick_From.Size = new System.Drawing.Size(101, 21);
            this.dpick_From.TabIndex = 675;
            // 
            // dpick_To
            // 
            this.dpick_To.CustomFormat = "";
            this.dpick_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_To.Location = new System.Drawing.Point(551, 41);
            this.dpick_To.Name = "dpick_To";
            this.dpick_To.Size = new System.Drawing.Size(101, 21);
            this.dpick_To.TabIndex = 676;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(538, 43);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 674;
            this.label1.Text = "~";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_RGACFence
            // 
            this.lbl_RGACFence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_RGACFence.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RGACFence.ImageIndex = 0;
            this.lbl_RGACFence.ImageList = this.img_Label;
            this.lbl_RGACFence.Location = new System.Drawing.Point(336, 40);
            this.lbl_RGACFence.Name = "lbl_RGACFence";
            this.lbl_RGACFence.Size = new System.Drawing.Size(100, 21);
            this.lbl_RGACFence.TabIndex = 673;
            this.lbl_RGACFence.Text = "RGAC Fence";
            this.lbl_RGACFence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_RGACOGAC);
            this.groupBox1.Controls.Add(this.rad_DayGAC);
            this.groupBox1.Location = new System.Drawing.Point(109, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 28);
            this.groupBox1.TabIndex = 672;
            this.groupBox1.TabStop = false;
            // 
            // rad_RGACOGAC
            // 
            this.rad_RGACOGAC.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.rad_RGACOGAC.Location = new System.Drawing.Point(96, 10);
            this.rad_RGACOGAC.Name = "rad_RGACOGAC";
            this.rad_RGACOGAC.Size = new System.Drawing.Size(104, 16);
            this.rad_RGACOGAC.TabIndex = 670;
            this.rad_RGACOGAC.Tag = "2";
            this.rad_RGACOGAC.Text = "RGAC, OGAC";
            this.rad_RGACOGAC.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // rad_DayGAC
            // 
            this.rad_DayGAC.Checked = true;
            this.rad_DayGAC.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.rad_DayGAC.Location = new System.Drawing.Point(8, 10);
            this.rad_DayGAC.Name = "rad_DayGAC";
            this.rad_DayGAC.Size = new System.Drawing.Size(80, 16);
            this.rad_DayGAC.TabIndex = 671;
            this.rad_DayGAC.TabStop = true;
            this.rad_DayGAC.Tag = "-1";
            this.rad_DayGAC.Text = "Day GAC";
            this.rad_DayGAC.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // txt_OpenFile
            // 
            this.txt_OpenFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_OpenFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OpenFile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OpenFile.Location = new System.Drawing.Point(109, 62);
            this.txt_OpenFile.Name = "txt_OpenFile";
            this.txt_OpenFile.ReadOnly = true;
            this.txt_OpenFile.Size = new System.Drawing.Size(542, 21);
            this.txt_OpenFile.TabIndex = 394;
            // 
            // lbl_OpenFile
            // 
            this.lbl_OpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OpenFile.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OpenFile.ImageIndex = 0;
            this.lbl_OpenFile.ImageList = this.img_Label;
            this.lbl_OpenFile.Location = new System.Drawing.Point(8, 62);
            this.lbl_OpenFile.Name = "lbl_OpenFile";
            this.lbl_OpenFile.Size = new System.Drawing.Size(100, 21);
            this.lbl_OpenFile.TabIndex = 50;
            this.lbl_OpenFile.Text = "Open File";
            this.lbl_OpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_UploadOption
            // 
            this.lbl_UploadOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_UploadOption.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UploadOption.ImageIndex = 0;
            this.lbl_UploadOption.ImageList = this.img_Label;
            this.lbl_UploadOption.Location = new System.Drawing.Point(8, 40);
            this.lbl_UploadOption.Name = "lbl_UploadOption";
            this.lbl_UploadOption.Size = new System.Drawing.Size(100, 21);
            this.lbl_UploadOption.TabIndex = 669;
            this.lbl_UploadOption.Text = "Upload Option";
            this.lbl_UploadOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.ImageIndex = 19;
            this.btn_OpenFile.ImageList = this.img_SmallButton;
            this.btn_OpenFile.Location = new System.Drawing.Point(652, 62);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(22, 22);
            this.btn_OpenFile.TabIndex = 663;
            this.btn_OpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_OpenFile.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            this.btn_OpenFile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_OpenFile.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_OpenFile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // lbl_SubTitle1
            // 
            this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
            this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle1.Name = "lbl_SubTitle1";
            this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle1.TabIndex = 393;
            this.lbl_SubTitle1.Text = "      Open File";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(992, 75);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 74);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(968, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(907, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 50);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(992, 0);
            this.pic_head2.Name = "pic_head2";
            this.pic_head2.Size = new System.Drawing.Size(16, 32);
            this.pic_head2.TabIndex = 44;
            this.pic_head2.TabStop = false;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 75);
            this.pic_head5.Name = "pic_head5";
            this.pic_head5.Size = new System.Drawing.Size(168, 20);
            this.pic_head5.TabIndex = 43;
            this.pic_head5.TabStop = false;
            // 
            // pic_head6
            // 
            this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
            this.pic_head6.Location = new System.Drawing.Point(0, 0);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 73);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(160, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(928, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // spd_main
            // 
            this.spd_main.BackColor = System.Drawing.Color.Transparent;
            this.spd_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spd_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.spd_main.Location = new System.Drawing.Point(8, 95);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.sheetView1);
            this.spd_main.Size = new System.Drawing.Size(1000, 477);
            this.spd_main.TabIndex = 174;
            // 
            // sheetView1
            // 
            this.sheetView1.SheetName = "Sheet1";
            // 
            // Form_BW_Pegasus_Upload
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BW_Pegasus_Upload";
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetView1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion 

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

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				Upload();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}


		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				Save();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}
 


		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				Print();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Print_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		#endregion

		#region 컨트롤 이벤트 처리

	 
		private void rad_CheckedChanged(object sender, System.EventArgs e)
		{
		
			//spd_main.ActiveSheet.ColumnHeaderRowCount = 0;

			//date 초기화  
			string nowymd = System.DateTime.Now.ToString("yyyyMMdd");

			dpick_From.Text = MyComFunction.ConvertDate2Type(nowymd);
			dpick_To.Text = MyComFunction.ConvertDate2Type(nowymd);  


			RadioButton src = sender as RadioButton;

			if(src.Name == "rad_DayGAC")
			{
				spd_main.Set_Spread_Comm("SBW_PEGASUS_UPLOAD", "1", 3, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
    

				dpick_From.Enabled = false;
				dpick_To.Enabled = false; 


			}
			else if(src.Name == "rad_RGACOGAC")
			{
				spd_main.Set_Spread_Comm("SBW_PEGASUS_UPLOAD", "2", 3, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);  


				dpick_From.Enabled = true;
				dpick_To.Enabled = true; 


			}


			// Farpoint Spread Header Merge
			if(spd_main.ActiveSheet.ColumnHeaderRowCount > 0)
			{
				Mearge_GridHead();
			}




		}




		private void btn_OpenFile_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				OpenFile();	 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_OpenFile_Click", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}


		}

 
 

		#endregion 

		#region 이벤트 처리 메서드

		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form set
			this.Text = "Pegasus Upload";
            lbl_MainTitle.Text = "Pegasus Upload"; 
            ClassLib.ComFunction.SetLangDic(this);

			// grid set
			spd_main.Set_Spread_Comm("SBW_PEGASUS_UPLOAD", "1", 3, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);  
			// Farpoint Spread Header Merge
			Mearge_GridHead();

			//combobox setting
			Init_Control(); 

			

		}


		/// <summary>
		/// Mearge_GridHead : Farpoint Spread Header Merge
		/// </summary>
		private void Mearge_GridHead()
		{
			
			try
			{

				for (int vCol = 0 ; vCol < spd_main.ActiveSheet.ColumnCount ; vCol++)
				{
					
					if (spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() == spd_main.ActiveSheet.ColumnHeader.Cells[2, vCol].Text.ToString().Trim()
						&& spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() == spd_main.ActiveSheet.ColumnHeader.Cells[3, vCol].Text.ToString().Trim() )
					{
						spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].RowSpan = 3;
					}
					else
					{
						int vCnt  = 0;
						
						for ( int j = vCol ; j <= spd_main.ActiveSheet.ColumnCount ; j++)
						{
							if(j == spd_main.ActiveSheet.ColumnCount)
							{
								spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
								vCol = j + 1;
								break;
							}
							else
							{
								if( vCnt > 0 &&  spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() != spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )
								{
									spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
									break;
								}
								else if ( spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() == spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )	
								{
									vCnt++;
								}
							} // end if(j == spd_main.ActiveSheet.ColumnCount - 1)

						}

						vCol = vCol + vCnt-1;
					}
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Mearge_GridHead", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

 

		/// <summary>
		/// Init_Control : combobox setting
		/// </summary>
		private void Init_Control()
		{ 

			// toolbar button disable setting 
			tbtn_Delete.Enabled = false; 
			tbtn_Confirm.Enabled = false;  

			dpick_From.Enabled = false;
			dpick_To.Enabled = false; 


		}

   


		#endregion

		#region 툴바 메뉴 이벤트 처리 메서드
		
		/// <summary>
		/// Clear : 화면 초기화
		/// </summary>
		private void Clear()
		{
			 
			txt_OpenFile.Text = "";
			spd_main.ClearAll(); 

		}

 

		/// <summary>
		/// Save : 
		/// </summary>
		private void Save()
		{

			bool save_flag = false;

			if(rad_DayGAC.Checked)
			{ 
				save_flag = SAVE_SBW_GAC(); 
			}
			else if(rad_RGACOGAC.Checked)
			{

				save_flag = SAVE_SBW_RGAC_PRECISION();  
			}


			

			if(! save_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
			}

		}
	



		/// <summary>
		/// Print : 프린트
		/// </summary>
		private void Print()
		{
 
			string file_name = @"DeliveryRiskManagement(Pegasus)_" + System.DateTime.Now.ToString("yyyyMMdd_hhmmss") + @".xls";
			bool save_flag = spd_main.SaveExcel(@"C:\" + file_name, FarPoint.Win.Spread.Model.IncludeHeaders.ColumnHeadersCustomOnly);  

			if(save_flag)
			{
				ClassLib.ComFunction.User_Message("Complete Save to Excel file." , "Pegasus Upload Data Save to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				ClassLib.ComFunction.User_Message("PROBLEM: Could not save file." , "Pegasus Upload Data Save to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}



		}


		#region 버튼클릭시 이미지변경
 

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
			
		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 

		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
		}

		
 

		#endregion 



		private void OpenFile()
		{
			
			openFileDialog1.DefaultExt = "xls";
			openFileDialog1.Filter = "Excel File (*.xls)|*.xls"; 


			if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
				 
			txt_OpenFile.Text = openFileDialog1.FileName; 

			spd_main.ClearAll();


		}


		private void Upload()
		{

			string path = txt_OpenFile.Text.Trim(); 

			DataSet ds_ret = Read_Excel(path);

			if(ds_ret == null) return;  
 
			DataTable dt_ret = ds_ret.Tables[0];   

			bool check_ok = Check_Validation_Excel_Data(dt_ret); 
			

			if(check_ok)
			{
				Display_Grid(dt_ret);
			}


		}


		/// <summary>
		/// Read_Excel : Read Excel File -> Return : DataSet
		/// </summary>
		/// <param name="arg_dtsrc">엑셀 파일 경로 (파일 이름까지 풀 경로)</param>
		/// <param name="arg_sql"></param>
		/// <returns></returns>
		private DataSet Read_Excel(string arg_dtsrc)
		{  

			/*

			<소스 추가>
			using System.Data.OleDb;
			using Microsoft.Office.Core;

			<참조 추가>
			Interop.Excel.dll
			Interop.Microsoft.Office.Core.dll
			
			*/
  


			try
			{
				OleDbConnection AdoConn = null;
				OleDbDataAdapter oraDA = null;
				DataSet oraDS = new DataSet("OraDataSet"); 


				// imex = 0 : export, 1 : import, 2 : update
				//string ExcelCon=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + arg_dtsrc + @";Extended Properties=""Excel 8.0;HDR=No;IMEX=1""";  

				// excel 읽을 때, provider hdr = yes 로 읽어서, 컬럼명(excel 첫번째행) 이 공백인 것은 F1 과 같이 시작됨
				// 컬럼명 사이의 공백은 _ 로 인식
				// 컬럼명 사이의 점 (.) 은 # 으로 인식
				string ExcelCon=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + arg_dtsrc + @";Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1""";  
 

				AdoConn = new OleDbConnection(ExcelCon);
				AdoConn.Close();
				AdoConn.Open();
                        

				DataTable sheetNameTable = AdoConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] {null, null, null, "TABLE"});  
				string sheetName = sheetNameTable.Rows[0].ItemArray.GetValue(2).ToString(); 
				string AdoSQL = @"SELECT * FROM [" + sheetName + "]";
  
				 



				OleDbCommand Cmd = new OleDbCommand(AdoSQL, AdoConn);  
				oraDA = new OleDbDataAdapter(Cmd); 
				oraDA.Fill(oraDS);

				oraDS.Namespace = sheetName;

				return oraDS;  
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString() );
				
				return null;

			}
	
			 
		}



		private bool Check_Validation_Excel_Data(DataTable arg_dt)
		{



			// SBW03, SBW05 : GAC Upload Column Property
			// column : 
			// 1 -> Column Order 
			// 2 -> Column Description 
			// 3 -> Column Type
			// 4 -> Format Delete	
			// 5 -> Format Change	
			// 6 -> Acceptance Character  
			

			string org_head_comcd = "";

			if(rad_DayGAC.Checked)
			{ 
				org_head_comcd = ClassLib.ComVar.CxGACUploadProperty01;
			}
			else if(rad_RGACOGAC.Checked)
			{ 
				org_head_comcd = ClassLib.ComVar.CxGACUploadProperty02;
			}



			DataTable dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, org_head_comcd);

			string org_head_desc = "";
			string excel_head_desc = "";

			// 컬럼 순서, 컬럼 명
			for(int i = 0; i < arg_dt.Columns.Count; i++)
			{
				org_head_desc = dt_ret.Rows[i].ItemArray[2].ToString().Replace(" ", "").Replace("\n", "").Replace("\r", "").Replace("_", "").Replace(".", "").Replace("#", ""); 
				
				//excel_head_desc = arg_dt.Rows[0].ItemArray[i].ToString().Replace(" ", "").Replace("\n", "").Replace("\r", "");

				// excel 읽을 때, provider hdr = yes 로 읽어서, 컬럼명 사이의 공백은 _ 로 인식
				// 컬럼명 사이의 점 (.) 은 # 으로 인식
				excel_head_desc = arg_dt.Columns[i].ColumnName.ToString().Replace(" ", "").Replace("\n", "").Replace("\r", "").Replace("_", "").Replace(".", "").Replace("#", "");


				// excel 읽을 때, provider hdr = yes 로 읽어서, 컬럼명(excel 첫번째행) 이 공백인 것은 F1 과 같이 시작되므로,
				// F 로 시작하는 것은 공백으로 인식하여 처리
				if(excel_head_desc.Length > 0 && excel_head_desc.Substring(0, 1) == "F")
				{
					excel_head_desc = "";
				}



				if(org_head_desc != excel_head_desc)
				{
					string message = "Mismatch excel select column item." + "\r\n\r\n"
						+ "Origin Column Item : [" + org_head_desc + "]" + "\r\n\r\n"
						+ "Excel  Column Item : [" + excel_head_desc + "]"; 
					ClassLib.ComFunction.User_Message(message, "Upload", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return false;
				}
			}


			return true;



		}




		/// <summary>
		/// Display_Grid : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Grid(DataTable arg_dt)
		{
 			 					
			 	

			// SBW03, SBW05 : GAC Upload Column Property
			// column : 
			// 1 -> Column Order 
			// 2 -> Column Description 
			// 3 -> Column Type
			// 4 -> Format Delete	
			// 5 -> Format Change	
			// 6 -> Acceptance Character  

			
			 

			string org_head_comcd = "";

			if(rad_DayGAC.Checked)
			{ 
				org_head_comcd = ClassLib.ComVar.CxGACUploadProperty01;
			}
			else if(rad_RGACOGAC.Checked)
			{ 
				org_head_comcd = ClassLib.ComVar.CxGACUploadProperty02;
			}



			DataTable dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, org_head_comcd);


			string column_type = "";
			string format_delete = "";
			string format_change = "";
			string acceptance_char = "";



			spd_main.ActiveSheet.ClearRange(0,0,spd_main.ActiveSheet.Rows.Count,spd_main.ActiveSheet.Columns.Count, false);						
			spd_main.ActiveSheet.ClearRange(0,0,spd_main.ActiveSheet.Rows.Count,1,false);						
			spd_main.ActiveSheet.RowCount = arg_dt.Rows.Count;				
									
			object[,] arr = new object[arg_dt.Rows.Count,arg_dt.Columns.Count];
			
			string delete_row_division = "";
 
			for(int i = 0; i < arg_dt.Rows.Count; i++) 
			{
 
				//------------------------------------------------------------------------------------------
				// 엑셀의"Overall Result" or  "Result" subtotal row 는 화면에 표시하지 않음
				if(rad_DayGAC.Checked)
				{  
					delete_row_division = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxFACTORY - 1].ToString(); 
				}
				else if(rad_RGACOGAC.Checked)
				{  
					delete_row_division = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxFACTORY - 1].ToString();
				}


				if(delete_row_division.Length > 0 && (delete_row_division.Substring(0, 1) == "O" || delete_row_division.Substring(0, 1) == "R") ) continue; 
				//------------------------------------------------------------------------------------------ 
				
				//------------------------------------------------------------------------------------------
				// 중복 데이터 공백 처리 된 경우, 데이터 채워 넣기
				if(rad_DayGAC.Checked)
				{ 
					
					for(int a = (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxFACTORY - 1; a <= (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxOBS_NU - 1; a++)
					{

						// 공백일때
						if(arg_dt.Rows[i].ItemArray[a] == null || arg_dt.Rows[i].ItemArray[a].ToString().Trim().Equals("") )
						{
							arg_dt.Rows[i][a] = arg_dt.Rows[i - 1].ItemArray[a].ToString();
						}

					} // end for a

				}
				else if(rad_RGACOGAC.Checked)
				{ 
					
					for(int a = (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxPLAN_MONTH - 1; a <= (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOBS_NU - 1; a++)
					{

						// 공백일때
						if(arg_dt.Rows[i].ItemArray[a] == null || arg_dt.Rows[i].ItemArray[a].ToString().Trim().Equals("") )
						{
							arg_dt.Rows[i][a] = arg_dt.Rows[i - 1].ItemArray[a].ToString();
						}

					} // end for a


				} // end if
				//------------------------------------------------------------------------------------------

				for(int j = 0; j < arg_dt.Columns.Count; j++)
				{											


					arr[i,j] = arg_dt.Rows[i].ItemArray[j];


					//------------------------------------------------------------------------------------------
					// 허용 문자 일때, null 로 모두 재 정의
					acceptance_char = dt_ret.Rows[j].ItemArray[6].ToString();

					if(acceptance_char.Length > 0)
					{
						if(arr[i, j].ToString() == acceptance_char)
						{
							arr[i,j] = "";
						}
					} // end if(acceptance_char.Length > 0)
					//------------------------------------------------------------------------------------------


					//------------------------------------------------------------------------------------------
					// 포맷 중 특정 문자 삭제 처리
					format_delete = dt_ret.Rows[j].ItemArray[4].ToString();

					if(format_delete.Length > 0)
					{
						arr[i,j] = arr[i,j].ToString().Replace(format_delete, ""); 

						// 데이터가 있는 경우 처리
						if(arr[i,j] != null && ! arr[i,j].ToString().Trim().Equals("") )
						{
						
							if(format_delete == ",")
							{
								arr[i,j] = Convert.ToDouble(arr[i,j]);
							}

							if(format_delete == "%")
							{
								arr[i,j] = Convert.ToDouble(arr[i,j]) * 100;
							}

						}

					} 
					//------------------------------------------------------------------------------------------


					//------------------------------------------------------------------------------------------
					// 컬럼 타입이 데이트 형일때, 포맷에 맞게 변경
					column_type = dt_ret.Rows[j].ItemArray[3].ToString();

					if(column_type == "DATE")
					{

						string mm = "";
						string dd = "";
						string yyyy = "";

						// pegasus upload 된 date 형식은 항상 mm-dd-yyyy 이므로
						format_change = dt_ret.Rows[j].ItemArray[5].ToString();


						//System.Type old_type_code = arr[i,j].GetType();


						if(arr[i,j].ToString().Length == 10)  
						{
							mm = arr[i,j].ToString().Substring(0, 2);
							dd = arr[i,j].ToString().Substring(3, 2);
							yyyy = arr[i,j].ToString().Substring(6);
 
							arr[i,j] = format_change.Replace("yyyy", yyyy).Replace("mm", mm).Replace("dd", dd);


						}
						else if(arr[i,j].ToString().Length == 7) // mm-yyyy 
						{
							mm = arr[i,j].ToString().Substring(0, 2); 
							yyyy = arr[i,j].ToString().Substring(3);  

							arr[i,j] = format_change.Replace("yyyy", yyyy).Replace("mm", mm);

						}  // end if(arr[i,j].ToString().Length)  
						 

						//arr[i,j] = Convert.ChangeType(arr[i,j], old_type_code);


					} // ehd if(column_type == "DATE")
					//------------------------------------------------------------------------------------------


					
					
					

					
				} // end for j -> column
			} // end for i
			
  

			spd_main.ActiveSheet.SetArray(0,1,arr) ;

			spd_main.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
			spd_main.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
			 
 
		}



		#endregion  

		
		
		#endregion

		#region DB Connect

		 
		/// <summary>
		/// SAVE_SBW_GAC : pegasus gac 데이터 저장
		/// </summary>
		/// <returns></returns>
		private bool SAVE_SBW_GAC()
		{


			try
			{
 
				int col_ct = 29;
				MyOraDB.ReDim_Parameter(col_ct);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBW_GAC.SAVE_SBW_GAC";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OBS_NU";
				MyOraDB.Parameter_Name[2] = "ARG_OBS_SEQ_NU";
				MyOraDB.Parameter_Name[3]  = "ARG_CGAC";
				MyOraDB.Parameter_Name[4] = "ARG_ORD";
				MyOraDB.Parameter_Name[5] = "ARG_OGAC"; 
				MyOraDB.Parameter_Name[6] = "ARG_RGAC";
				MyOraDB.Parameter_Name[7] = "ARG_GAC14";
				MyOraDB.Parameter_Name[8] = "ARG_GAC30";
				MyOraDB.Parameter_Name[9] = "ARG_GAC45";
				MyOraDB.Parameter_Name[10]= "ARG_ORDER_QTY"; 
				MyOraDB.Parameter_Name[11] = "ARG_OR_QTY";
				MyOraDB.Parameter_Name[12] = "ARG_DAY0_QTY";
				MyOraDB.Parameter_Name[13] = "ARG_DAY0_ONTIME";
				MyOraDB.Parameter_Name[14] = "ARG_DAY0_RATE";
				MyOraDB.Parameter_Name[15] = "ARG_DAY14_QTY"; 
				MyOraDB.Parameter_Name[16] = "ARG_DAY14_ONTIME";
				MyOraDB.Parameter_Name[17] = "ARG_DAY14_RATE";
				MyOraDB.Parameter_Name[18] = "ARG_DAY30_QTY";
				MyOraDB.Parameter_Name[19] = "ARG_DAY30_ONTIME";
				MyOraDB.Parameter_Name[20] = "ARG_DAY30_RATE"; 
				MyOraDB.Parameter_Name[21] = "ARG_DAY45_QTY"; 
				MyOraDB.Parameter_Name[22] = "ARG_DAY45_ONTIME"; 
				MyOraDB.Parameter_Name[23] = "ARG_DAY45_RATE"; 
				MyOraDB.Parameter_Name[24] = "ARG_OGAC_QTY"; 
				MyOraDB.Parameter_Name[25] = "ARG_OGAC_ONTIME"; 
				MyOraDB.Parameter_Name[26] = "ARG_OGAC_RATE"; 
				MyOraDB.Parameter_Name[27] = "ARG_REMARKS"; 
				MyOraDB.Parameter_Name[28] = "ARG_UPD_USER";  

				//03.DATA TYPE 정의
				for(int i = 0; i < col_ct; i++)
				{
					MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				} 

				//04.DATA 정의
				ArrayList vList = new ArrayList(); 
 
//				string from_rgac_fence = dpick_From.Value.ToString("yyyyMMdd");
//				string to_rgac_fence = dpick_To.Value.ToString("yyyyMMdd");
//
//				string rgac = "";

				for(int i = 0 ; i < spd_main.ActiveSheet.RowCount ; i++)
				{  


					if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxOBS_NU].Value == null
						|| spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxOBS_NU].Value.ToString() == "") continue;

					
//					rgac = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxRGAC].Value.ToString().Replace("-", "");
//
//					// RGAC Fence 범위 내의 데이터만 upload 대상이 됨
//					if(Convert.ToInt32(rgac) < Convert.ToInt32(from_rgac_fence)
//						|| Convert.ToInt32(rgac) > Convert.ToInt32(to_rgac_fence) ) continue;


					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxFACTORY].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxOBS_NU].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxOBS_SEQ_NU].Value.ToString().PadLeft(10, '0') ); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxCGAC].Value.ToString().Replace("-", "")); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxORIGIN_RECEIPT].Value.ToString().Replace("-", ""));
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxOGAC].Value.ToString().Replace("-", "")); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxRGAC].Value.ToString().Replace("-", "")); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxGAC14].Value.ToString().Replace("-", "")); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxGAC30].Value.ToString().Replace("-", "")); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxGAC45].Value.ToString().Replace("-", "")); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxORDER_QTY].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxOR_QTY].Value.ToString());  
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxDAY0_QTY].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxDAY0_ONTIME].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxDAY0_RATE].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxDAY14_QTY].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxDAY14_ONTIME].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxDAY14_RATE].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxDAY30_QTY].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxDAY30_ONTIME].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxDAY30_RATE].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxDAY45_QTY].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxDAY45_ONTIME].Value.ToString());  
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxDAY45_RATE].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxOGAC_QTY].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxOGAC_ONTIME].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_01.IxOGAC_RATE].Value.ToString());  
					vList.Add("");   //"ARG_REMARKS"
					vList.Add(ClassLib.ComVar.This_User);   


				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(true);
				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

				if(ds_ret == null)
				{
					return false;
				}
				else
				{ 
					return true;
				} 
 


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SAVE_SBW_GAC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}



		}
 
		/// <summary>
		/// SAVE_SBW_RGAC_PRECISION : pegasus gac 데이터 저장
		/// </summary>
		/// <returns></returns>
		private bool SAVE_SBW_RGAC_PRECISION()
		{


			try
			{
 
				int col_ct = 46;
				MyOraDB.ReDim_Parameter(col_ct);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBW_GAC.SAVE_SBW_RGAC_PRECISION";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OBS_NU";
				MyOraDB.Parameter_Name[2] = "ARG_OBS_SEQ_NU";
				MyOraDB.Parameter_Name[3] = "ARG_CGAC";
				MyOraDB.Parameter_Name[4] = "ARG_ORD"; 
				MyOraDB.Parameter_Name[5] = "ARG_OGAC";
				MyOraDB.Parameter_Name[6] = "ARG_RGAC";
				MyOraDB.Parameter_Name[7] = "ARG_PLAN_MONTH"; 
				MyOraDB.Parameter_Name[8] = "ARG_FACTORY_NAME";
				MyOraDB.Parameter_Name[9] = "ARG_CATEGORY";
				MyOraDB.Parameter_Name[10] = "ARG_MATERIAL";
				MyOraDB.Parameter_Name[11] = "ARG_MATERIAL_NAME";
				MyOraDB.Parameter_Name[12] = "ARG_OUTSOLE_1_CD";
				MyOraDB.Parameter_Name[13] = "ARG_PO_ACCEPTANCE_DATE"; 
				MyOraDB.Parameter_Name[14] = "ARG_PO_QTY";
				MyOraDB.Parameter_Name[15] = "ARG_OR_QTY"; 
				MyOraDB.Parameter_Name[16] = "ARG_TOLERANCE_MARGIN_EARLY_RGA";
				MyOraDB.Parameter_Name[17] = "ARG_TOLERANCE_MARGIN_LATE_RGA";
				MyOraDB.Parameter_Name[18] = "ARG_TOLERANCE_MARGIN_EARLY_OGA";
				MyOraDB.Parameter_Name[19] = "ARG_TOLERANCE_MARGIN_LATE_OGA"; 
				MyOraDB.Parameter_Name[20] = "ARG_RGAC_ONTIME_QTY";
				MyOraDB.Parameter_Name[21] = "ARG_RGAC_ONTIME_RATE";
				MyOraDB.Parameter_Name[22] = "ARG_RGAC_PROJECT_QTY";
				MyOraDB.Parameter_Name[23] = "ARG_RGAC_PROJECT_RATE";
				MyOraDB.Parameter_Name[24] = "ARG_RGAC_TOTAL_QTY";
				MyOraDB.Parameter_Name[25] = "ARG_RGAC_TOTAL_RATE";
				MyOraDB.Parameter_Name[26] = "ARG_RGAC_MARGIN_ONTIME_QTY";
				MyOraDB.Parameter_Name[27] = "ARG_RGAC_MARGIN_ONTIME_RATE";
				MyOraDB.Parameter_Name[28] = "ARG_RGAC_MARGIN_PROJECT_QTY";
				MyOraDB.Parameter_Name[29] = "ARG_RGAC_MARGIN_PROJECT_RATE";
				MyOraDB.Parameter_Name[30] = "ARG_RGAC_MARGIN_TOTAL_QTY";
				MyOraDB.Parameter_Name[31] = "ARG_RGAC_MARGIN_TOTAL_RATE";
				MyOraDB.Parameter_Name[32] = "ARG_OGAC_ONTIME_QTY";
				MyOraDB.Parameter_Name[33] = "ARG_OGAC_ONTIME_RATE";
				MyOraDB.Parameter_Name[34] = "ARG_OGAC_PROJECT_QTY";
				MyOraDB.Parameter_Name[35] = "ARG_OGAC_PROJECT_RATE";
				MyOraDB.Parameter_Name[36] = "ARG_OGAC_TOTAL_QTY"; 
				MyOraDB.Parameter_Name[37] = "ARG_OGAC_TOTAL_RATE";
				MyOraDB.Parameter_Name[38] = "ARG_OGAC_MARGIN_ONTIME_QTY";
				MyOraDB.Parameter_Name[39] = "ARG_OGAC_MARGIN_ONTIME_RATE";
				MyOraDB.Parameter_Name[40] = "ARG_OGAC_MARGIN_PROJECT_QTY";
				MyOraDB.Parameter_Name[41] = "ARG_OGAC_MARGIN_PROJECT_RATE";
				MyOraDB.Parameter_Name[42] = "ARG_OGAC_MARGIN_TOTAL_QTY";
				MyOraDB.Parameter_Name[43] = "ARG_OGAC_MARGIN_TOTAL_RATE";
				MyOraDB.Parameter_Name[44] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[45] = "ARG_UPD_USER"; 
    

				 
				//03.DATA TYPE 정의			  
				for(int i = 0; i < col_ct; i++)
				{
					MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				} 

				//04.DATA 정의
				ArrayList vList = new ArrayList(); 
 

				string from_rgac_fence = dpick_From.Value.ToString("yyyyMMdd");
				string to_rgac_fence = dpick_To.Value.ToString("yyyyMMdd");

				string rgac = "";


				for(int i = 0 ; i < spd_main.ActiveSheet.RowCount ; i++)
				{  
  
					if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOBS_NU].Value == null
						|| spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOBS_NU].Value.ToString() == "") continue;


					rgac = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxRGAC].Value.ToString().Replace("-", "");

					// RGAC Fence 범위 내의 데이터만 upload 대상이 됨
					if(Convert.ToInt32(rgac) < Convert.ToInt32(from_rgac_fence)
						|| Convert.ToInt32(rgac) > Convert.ToInt32(to_rgac_fence) ) continue;


					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxFACTORY].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOBS_NU].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOBS_SEQ_NU].Value.ToString().PadLeft(10, '0') ); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxCGAC].Value.ToString().Replace("-", "")); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxORD].Value.ToString().Replace("-", ""));
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOGAC].Value.ToString().Replace("-", "")); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxRGAC].Value.ToString().Replace("-", "")); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxPLAN_MONTH].Value.ToString().Replace("-", ""));   
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxFACTORY_NAME].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxCATEGORY].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxMATERIAL].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxMATERIAL_NAME].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOUTSOLE_1_CD].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxPO_ACCEPTANCE_DATE].Value.ToString().Replace("-", ""));  
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxPO_QTY].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOR_QTY].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxTOLERANCE_MARGIN_EARLY_RGAC].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxTOLERANCE_MARGIN_LATE_RGAC].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxTOLERANCE_MARGIN_EARLY_OGAC].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxTOLERANCE_MARGIN_LATE_OGAC].Value.ToString()); 
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxRGAC_ONTIME_QTY].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxRGAC_ONTIME_RATE].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxRGAC_PROJECT_QTY].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxRGAC_PROJECT_RATE].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxRGAC_TOTAL_QTY].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxRGAC_TOTAL_RATE].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxRGAC_MARGIN_ONTIME_QTY].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxRGAC_MARGIN_ONTIME_RATE].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxRGAC_MARGIN_PROJECT_QTY].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxRGAC_MARGIN_PROJECT_RATE].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxRGAC_MARGIN_TOTAL_QTY].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxRGAC_MARGIN_TOTAL_RATE].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOGAC_ONTIME_QTY].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOGAC_ONTIME_RATE].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOGAC_PROJECT_QTY].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOGAC_PROJECT_RATE].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOGAC_TOTAL_QTY].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOGAC_TOTAL_RATE].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOGAC_MARGIN_ONTIME_QTY].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOGAC_MARGIN_ONTIME_RATE].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOGAC_MARGIN_PROJECT_QTY].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOGAC_MARGIN_PROJECT_RATE].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOGAC_MARGIN_TOTAL_QTY].Value.ToString());
					vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_PEGASUS_GAC_UPLOAD_02.IxOGAC_MARGIN_TOTAL_RATE].Value.ToString()); 
					vList.Add("");   //"ARG_REMARKS"
					vList.Add(ClassLib.ComVar.This_User);   


				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(true);
				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

				if(ds_ret == null)
				{
					return false;
				}
				else
				{ 
					return true;
				} 
 


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SAVE_SBW_RGAC_PRECISION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}



		}


		#endregion	 

		

		 


	}
}

