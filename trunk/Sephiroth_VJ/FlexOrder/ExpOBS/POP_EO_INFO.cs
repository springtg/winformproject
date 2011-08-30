using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OleDb;
using Microsoft.Office.Core;
using System.Data.OracleClient;


namespace FlexOrder.ExpOBS
{
	public class POP_EO_INFO : COM.OrderWinForm.Pop_Large
	{
		#region 컨트롤 정의 및 리소스 정리
		private System.Windows.Forms.Label lbl_Save;
		private System.Windows.Forms.Label btn_Cancel;
		public System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel pnl_save_image;
		private System.Windows.Forms.TextBox txt_Seq_Nu;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_Chg_Nu;
		private System.Windows.Forms.TextBox txt_OBS_Nu;
		private System.Windows.Forms.TextBox txt_Style_cd;
		private System.Windows.Forms.Label lbl_STYLE;
		private System.Windows.Forms.PictureBox picture_etc;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private C1.Win.C1List.C1Combo cmb_OBS_ID;
		private System.Windows.Forms.Label lbl_Factory;
		private C1.Win.C1List.C1Combo cmb_OBS_Type;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_OBS_ID;
		private System.Windows.Forms.Label lbl_OBS_Type;
		private System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox19;
		private System.Windows.Forms.PictureBox pictureBox20;
		private System.Windows.Forms.PictureBox pictureBox21;
		private System.Windows.Forms.PictureBox pictureBox22;
		private System.Windows.Forms.PictureBox pictureBox23;
		private System.Windows.Forms.PictureBox pictureBox24;
		public System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_EKET;
		public COM.FSP fgrid_EKKO;
		public COM.FSP fgrid_Main;
		public System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox25;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.PictureBox pictureBox26;
		private System.Windows.Forms.PictureBox pictureBox27;
		private System.Windows.Forms.PictureBox pictureBox28;
		private System.Windows.Forms.PictureBox pictureBox29;
		private System.Windows.Forms.PictureBox pictureBox30;
		private System.Windows.Forms.PictureBox pictureBox31;
		private System.Windows.Forms.GroupBox grp_create;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_zero_order;
		private System.ComponentModel.IContainer components = null;

		public POP_EO_INFO()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(POP_EO_INFO));
			this.lbl_Save = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnl_save_image = new System.Windows.Forms.Panel();
			this.txt_Seq_Nu = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_Chg_Nu = new System.Windows.Forms.TextBox();
			this.txt_OBS_Nu = new System.Windows.Forms.TextBox();
			this.txt_Style_cd = new System.Windows.Forms.TextBox();
			this.lbl_STYLE = new System.Windows.Forms.Label();
			this.picture_etc = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.cmb_OBS_ID = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.cmb_OBS_Type = new C1.Win.C1List.C1Combo();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_OBS_ID = new System.Windows.Forms.Label();
			this.lbl_OBS_Type = new System.Windows.Forms.Label();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.pictureBox18 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox19 = new System.Windows.Forms.PictureBox();
			this.pictureBox20 = new System.Windows.Forms.PictureBox();
			this.pictureBox21 = new System.Windows.Forms.PictureBox();
			this.pictureBox22 = new System.Windows.Forms.PictureBox();
			this.pictureBox23 = new System.Windows.Forms.PictureBox();
			this.pictureBox24 = new System.Windows.Forms.PictureBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox25 = new System.Windows.Forms.PictureBox();
			this.label14 = new System.Windows.Forms.Label();
			this.pictureBox26 = new System.Windows.Forms.PictureBox();
			this.pictureBox27 = new System.Windows.Forms.PictureBox();
			this.pictureBox28 = new System.Windows.Forms.PictureBox();
			this.pictureBox29 = new System.Windows.Forms.PictureBox();
			this.pictureBox30 = new System.Windows.Forms.PictureBox();
			this.pictureBox31 = new System.Windows.Forms.PictureBox();
			this.grp_create = new System.Windows.Forms.GroupBox();
			this.btn_zero_order = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnl_save_image.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			this.panel5.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel9.SuspendLayout();
			this.grp_create.SuspendLayout();
			this.SuspendLayout();
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// lbl_Save
			// 
			this.lbl_Save.ImageIndex = 0;
			this.lbl_Save.ImageList = this.img_Button;
			this.lbl_Save.Location = new System.Drawing.Point(552, 233);
			this.lbl_Save.Name = "lbl_Save";
			this.lbl_Save.Size = new System.Drawing.Size(70, 23);
			this.lbl_Save.TabIndex = 243;
			this.lbl_Save.Text = "Save";
			this.lbl_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_Save.Click += new System.EventHandler(this.lbl_Save_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(624, 233);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 241;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.DockPadding.All = 8;
			this.panel1.Location = new System.Drawing.Point(0, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(696, 128);
			this.panel1.TabIndex = 244;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pnl_save_image);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(344, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(344, 112);
			this.panel2.TabIndex = 130;
			// 
			// pnl_save_image
			// 
			this.pnl_save_image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_save_image.Controls.Add(this.txt_Seq_Nu);
			this.pnl_save_image.Controls.Add(this.label12);
			this.pnl_save_image.Controls.Add(this.label1);
			this.pnl_save_image.Controls.Add(this.txt_Chg_Nu);
			this.pnl_save_image.Controls.Add(this.txt_OBS_Nu);
			this.pnl_save_image.Controls.Add(this.txt_Style_cd);
			this.pnl_save_image.Controls.Add(this.lbl_STYLE);
			this.pnl_save_image.Controls.Add(this.picture_etc);
			this.pnl_save_image.Controls.Add(this.pictureBox10);
			this.pnl_save_image.Controls.Add(this.label6);
			this.pnl_save_image.Controls.Add(this.pictureBox11);
			this.pnl_save_image.Controls.Add(this.pictureBox12);
			this.pnl_save_image.Controls.Add(this.pictureBox13);
			this.pnl_save_image.Controls.Add(this.pictureBox14);
			this.pnl_save_image.Controls.Add(this.pictureBox15);
			this.pnl_save_image.Controls.Add(this.pictureBox16);
			this.pnl_save_image.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_save_image.Location = new System.Drawing.Point(0, 0);
			this.pnl_save_image.Name = "pnl_save_image";
			this.pnl_save_image.Size = new System.Drawing.Size(344, 112);
			this.pnl_save_image.TabIndex = 128;
			// 
			// txt_Seq_Nu
			// 
			this.txt_Seq_Nu.BackColor = System.Drawing.Color.White;
			this.txt_Seq_Nu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Seq_Nu.Enabled = false;
			this.txt_Seq_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Seq_Nu.Location = new System.Drawing.Point(216, 58);
			this.txt_Seq_Nu.MaxLength = 100;
			this.txt_Seq_Nu.Name = "txt_Seq_Nu";
			this.txt_Seq_Nu.ReadOnly = true;
			this.txt_Seq_Nu.Size = new System.Drawing.Size(105, 20);
			this.txt_Seq_Nu.TabIndex = 134;
			this.txt_Seq_Nu.Text = "";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label12.Font = new System.Drawing.Font("Verdana", 8F);
			this.label12.ImageIndex = 0;
			this.label12.ImageList = this.img_Label;
			this.label12.Location = new System.Drawing.Point(10, 81);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 21);
			this.label12.TabIndex = 133;
			this.label12.Text = "Chg Nu";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Verdana", 8F);
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(10, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 132;
			this.label1.Text = "OBS/Seq Nu";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Chg_Nu
			// 
			this.txt_Chg_Nu.BackColor = System.Drawing.Color.White;
			this.txt_Chg_Nu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Chg_Nu.Enabled = false;
			this.txt_Chg_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Chg_Nu.Location = new System.Drawing.Point(111, 80);
			this.txt_Chg_Nu.MaxLength = 100;
			this.txt_Chg_Nu.Name = "txt_Chg_Nu";
			this.txt_Chg_Nu.ReadOnly = true;
			this.txt_Chg_Nu.Size = new System.Drawing.Size(210, 20);
			this.txt_Chg_Nu.TabIndex = 131;
			this.txt_Chg_Nu.Text = "";
			// 
			// txt_OBS_Nu
			// 
			this.txt_OBS_Nu.BackColor = System.Drawing.Color.White;
			this.txt_OBS_Nu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_Nu.Enabled = false;
			this.txt_OBS_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_Nu.Location = new System.Drawing.Point(111, 58);
			this.txt_OBS_Nu.MaxLength = 100;
			this.txt_OBS_Nu.Name = "txt_OBS_Nu";
			this.txt_OBS_Nu.ReadOnly = true;
			this.txt_OBS_Nu.Size = new System.Drawing.Size(105, 20);
			this.txt_OBS_Nu.TabIndex = 112;
			this.txt_OBS_Nu.Text = "";
			// 
			// txt_Style_cd
			// 
			this.txt_Style_cd.BackColor = System.Drawing.Color.White;
			this.txt_Style_cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_cd.Enabled = false;
			this.txt_Style_cd.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Style_cd.Location = new System.Drawing.Point(111, 36);
			this.txt_Style_cd.MaxLength = 100;
			this.txt_Style_cd.Name = "txt_Style_cd";
			this.txt_Style_cd.ReadOnly = true;
			this.txt_Style_cd.Size = new System.Drawing.Size(210, 20);
			this.txt_Style_cd.TabIndex = 111;
			this.txt_Style_cd.Text = "";
			// 
			// lbl_STYLE
			// 
			this.lbl_STYLE.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_STYLE.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_STYLE.ImageIndex = 0;
			this.lbl_STYLE.ImageList = this.img_Label;
			this.lbl_STYLE.Location = new System.Drawing.Point(10, 36);
			this.lbl_STYLE.Name = "lbl_STYLE";
			this.lbl_STYLE.Size = new System.Drawing.Size(100, 21);
			this.lbl_STYLE.TabIndex = 109;
			this.lbl_STYLE.Text = "Style";
			this.lbl_STYLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picture_etc
			// 
			this.picture_etc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picture_etc.BackColor = System.Drawing.SystemColors.Highlight;
			this.picture_etc.Image = ((System.Drawing.Image)(resources.GetObject("picture_etc.Image")));
			this.picture_etc.Location = new System.Drawing.Point(165, 0);
			this.picture_etc.Name = "picture_etc";
			this.picture_etc.Size = new System.Drawing.Size(168, 30);
			this.picture_etc.TabIndex = 2;
			this.picture_etc.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(331, 0);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(13, 30);
			this.pictureBox10.TabIndex = 1;
			this.pictureBox10.TabStop = false;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.Highlight;
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.Location = new System.Drawing.Point(0, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(165, 30);
			this.label6.TabIndex = 0;
			this.label6.Text = "      etc Info.";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox11.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(313, 30);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(31, 66);
			this.pictureBox11.TabIndex = 5;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.Color.Blue;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(319, 82);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(25, 30);
			this.pictureBox12.TabIndex = 8;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox13.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(0, 24);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(32, 77);
			this.pictureBox13.TabIndex = 3;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox14.BackColor = System.Drawing.Color.Blue;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(0, 82);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(72, 40);
			this.pictureBox14.TabIndex = 6;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox15.BackColor = System.Drawing.Color.Blue;
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(72, 82);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(256, 30);
			this.pictureBox15.TabIndex = 9;
			this.pictureBox15.TabStop = false;
			// 
			// pictureBox16
			// 
			this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox16.BackColor = System.Drawing.Color.Navy;
			this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
			this.pictureBox16.Location = new System.Drawing.Point(32, 24);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(296, 80);
			this.pictureBox16.TabIndex = 4;
			this.pictureBox16.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.DockPadding.Right = 4;
			this.panel3.Location = new System.Drawing.Point(8, 8);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(336, 112);
			this.panel3.TabIndex = 128;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.RosyBrown;
			this.panel4.Controls.Add(this.cmb_OBS_ID);
			this.panel4.Controls.Add(this.lbl_Factory);
			this.panel4.Controls.Add(this.cmb_OBS_Type);
			this.panel4.Controls.Add(this.cmb_Factory);
			this.panel4.Controls.Add(this.lbl_OBS_ID);
			this.panel4.Controls.Add(this.lbl_OBS_Type);
			this.panel4.Controls.Add(this.pictureBox17);
			this.panel4.Controls.Add(this.pictureBox18);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.pictureBox19);
			this.panel4.Controls.Add(this.pictureBox20);
			this.panel4.Controls.Add(this.pictureBox21);
			this.panel4.Controls.Add(this.pictureBox22);
			this.panel4.Controls.Add(this.pictureBox23);
			this.panel4.Controls.Add(this.pictureBox24);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(332, 112);
			this.panel4.TabIndex = 1;
			// 
			// cmb_OBS_ID
			// 
			this.cmb_OBS_ID.AddItemCols = 0;
			this.cmb_OBS_ID.AddItemSeparator = ';';
			this.cmb_OBS_ID.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_ID.Caption = "";
			this.cmb_OBS_ID.CaptionHeight = 17;
			this.cmb_OBS_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_ID.ColumnCaptionHeight = 18;
			this.cmb_OBS_ID.ColumnFooterHeight = 18;
			this.cmb_OBS_ID.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_ID.ContentHeight = 15;
			this.cmb_OBS_ID.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_ID.EditorBackColor = System.Drawing.SystemColors.Control;
			this.cmb_OBS_ID.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_ID.EditorHeight = 15;
			this.cmb_OBS_ID.Enabled = false;
			this.cmb_OBS_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID.GapHeight = 2;
			this.cmb_OBS_ID.ItemHeight = 15;
			this.cmb_OBS_ID.Location = new System.Drawing.Point(111, 80);
			this.cmb_OBS_ID.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_ID.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_ID.MaxLength = 32767;
			this.cmb_OBS_ID.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_ID.Name = "cmb_OBS_ID";
			this.cmb_OBS_ID.PartialRightColumn = false;
			this.cmb_OBS_ID.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Con" +
				"trol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}S" +
				"tyle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_OBS_ID.ReadOnly = true;
			this.cmb_OBS_ID.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_ID.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID.RowTracking = false;
			this.cmb_OBS_ID.Size = new System.Drawing.Size(210, 19);
			this.cmb_OBS_ID.TabIndex = 121;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 115;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_OBS_Type
			// 
			this.cmb_OBS_Type.AddItemCols = 0;
			this.cmb_OBS_Type.AddItemSeparator = ';';
			this.cmb_OBS_Type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_Type.Caption = "";
			this.cmb_OBS_Type.CaptionHeight = 17;
			this.cmb_OBS_Type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_Type.ColumnCaptionHeight = 18;
			this.cmb_OBS_Type.ColumnFooterHeight = 18;
			this.cmb_OBS_Type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_Type.ContentHeight = 15;
			this.cmb_OBS_Type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_Type.EditorBackColor = System.Drawing.SystemColors.Control;
			this.cmb_OBS_Type.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_Type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_Type.EditorHeight = 15;
			this.cmb_OBS_Type.Enabled = false;
			this.cmb_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_Type.GapHeight = 2;
			this.cmb_OBS_Type.ItemHeight = 15;
			this.cmb_OBS_Type.Location = new System.Drawing.Point(111, 58);
			this.cmb_OBS_Type.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_Type.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_Type.MaxLength = 32767;
			this.cmb_OBS_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_Type.Name = "cmb_OBS_Type";
			this.cmb_OBS_Type.PartialRightColumn = false;
			this.cmb_OBS_Type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tru" +
				"e;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Con" +
				"trol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_OBS_Type.ReadOnly = true;
			this.cmb_OBS_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type.Size = new System.Drawing.Size(210, 19);
			this.cmb_OBS_Type.TabIndex = 119;
			this.cmb_OBS_Type.TextChanged += new System.EventHandler(this.cmb_OBS_Type_TextChanged);
			// 
			// cmb_Factory
			// 
			this.cmb_Factory.AddItemCols = 0;
			this.cmb_Factory.AddItemSeparator = ';';
			this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory.Caption = "";
			this.cmb_Factory.CaptionHeight = 17;
			this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory.ColumnCaptionHeight = 18;
			this.cmb_Factory.ColumnFooterHeight = 18;
			this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory.ContentHeight = 15;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Control;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 15;
			this.cmb_Factory.Enabled = false;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(111, 36);
			this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory.MaxDropDownItems = ((short)(5));
			this.cmb_Factory.MaxLength = 32767;
			this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory.Name = "cmb_Factory";
			this.cmb_Factory.PartialRightColumn = false;
			this.cmb_Factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Con" +
				"trol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}S" +
				"tyle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.ReadOnly = true;
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory.TabIndex = 118;
			// 
			// lbl_OBS_ID
			// 
			this.lbl_OBS_ID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_ID.ImageIndex = 1;
			this.lbl_OBS_ID.ImageList = this.img_Label;
			this.lbl_OBS_ID.Location = new System.Drawing.Point(10, 80);
			this.lbl_OBS_ID.Name = "lbl_OBS_ID";
			this.lbl_OBS_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_ID.TabIndex = 117;
			this.lbl_OBS_ID.Text = "OBS ID";
			this.lbl_OBS_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_OBS_Type
			// 
			this.lbl_OBS_Type.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Type.ImageIndex = 1;
			this.lbl_OBS_Type.ImageList = this.img_Label;
			this.lbl_OBS_Type.Location = new System.Drawing.Point(10, 58);
			this.lbl_OBS_Type.Name = "lbl_OBS_Type";
			this.lbl_OBS_Type.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_Type.TabIndex = 116;
			this.lbl_OBS_Type.Text = "OBS Type";
			this.lbl_OBS_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox17
			// 
			this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox17.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox17.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
			this.pictureBox17.Location = new System.Drawing.Point(168, -1);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(148, 32);
			this.pictureBox17.TabIndex = 2;
			this.pictureBox17.TabStop = false;
			// 
			// pictureBox18
			// 
			this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox18.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
			this.pictureBox18.Location = new System.Drawing.Point(310, 0);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(22, 32);
			this.pictureBox18.TabIndex = 1;
			this.pictureBox18.TabStop = false;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.Highlight;
			this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
			this.label8.Location = new System.Drawing.Point(0, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(172, 32);
			this.label8.TabIndex = 0;
			this.label8.Text = "      OBS Info.";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox19
			// 
			this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox19.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
			this.pictureBox19.Location = new System.Drawing.Point(313, 32);
			this.pictureBox19.Name = "pictureBox19";
			this.pictureBox19.Size = new System.Drawing.Size(19, 66);
			this.pictureBox19.TabIndex = 5;
			this.pictureBox19.TabStop = false;
			// 
			// pictureBox20
			// 
			this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox20.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
			this.pictureBox20.Location = new System.Drawing.Point(0, 24);
			this.pictureBox20.Name = "pictureBox20";
			this.pictureBox20.Size = new System.Drawing.Size(32, 77);
			this.pictureBox20.TabIndex = 3;
			this.pictureBox20.TabStop = false;
			// 
			// pictureBox21
			// 
			this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox21.BackColor = System.Drawing.Color.Blue;
			this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
			this.pictureBox21.Location = new System.Drawing.Point(242, 98);
			this.pictureBox21.Name = "pictureBox21";
			this.pictureBox21.Size = new System.Drawing.Size(90, 14);
			this.pictureBox21.TabIndex = 8;
			this.pictureBox21.TabStop = false;
			// 
			// pictureBox22
			// 
			this.pictureBox22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox22.BackColor = System.Drawing.Color.Blue;
			this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
			this.pictureBox22.Location = new System.Drawing.Point(72, 98);
			this.pictureBox22.Name = "pictureBox22";
			this.pictureBox22.Size = new System.Drawing.Size(244, 14);
			this.pictureBox22.TabIndex = 9;
			this.pictureBox22.TabStop = false;
			// 
			// pictureBox23
			// 
			this.pictureBox23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox23.BackColor = System.Drawing.Color.Blue;
			this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
			this.pictureBox23.Location = new System.Drawing.Point(0, 98);
			this.pictureBox23.Name = "pictureBox23";
			this.pictureBox23.Size = new System.Drawing.Size(80, 14);
			this.pictureBox23.TabIndex = 6;
			this.pictureBox23.TabStop = false;
			// 
			// pictureBox24
			// 
			this.pictureBox24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox24.BackColor = System.Drawing.Color.Navy;
			this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
			this.pictureBox24.Location = new System.Drawing.Point(32, 24);
			this.pictureBox24.Name = "pictureBox24";
			this.pictureBox24.Size = new System.Drawing.Size(284, 80);
			this.pictureBox24.TabIndex = 4;
			this.pictureBox24.TabStop = false;
			// 
			// pnl_Body
			// 
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.DockPadding.All = 2;
			this.pnl_Body.Location = new System.Drawing.Point(1, 168);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(695, 62);
			this.pnl_Body.TabIndex = 245;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.AutoResize = false;
			this.fgrid_Main.BackColor = System.Drawing.Color.White;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "2,1,0,0,0,95,Columns:";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Main.ForeColor = System.Drawing.Color.Black;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(2, 2);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.Rows.Count = 2;
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(691, 58);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 47;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.Window;
			this.panel5.Controls.Add(this.panel8);
			this.panel5.DockPadding.All = 8;
			this.panel5.Location = new System.Drawing.Point(1, 266);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(696, 161);
			this.panel5.TabIndex = 247;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.panel9);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel8.DockPadding.Right = 4;
			this.panel8.Location = new System.Drawing.Point(8, 8);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(680, 145);
			this.panel8.TabIndex = 128;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.RosyBrown;
			this.panel9.Controls.Add(this.grp_create);
			this.panel9.Controls.Add(this.pictureBox9);
			this.panel9.Controls.Add(this.pictureBox25);
			this.panel9.Controls.Add(this.label14);
			this.panel9.Controls.Add(this.pictureBox26);
			this.panel9.Controls.Add(this.pictureBox27);
			this.panel9.Controls.Add(this.pictureBox28);
			this.panel9.Controls.Add(this.pictureBox29);
			this.panel9.Controls.Add(this.pictureBox30);
			this.panel9.Controls.Add(this.pictureBox31);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Location = new System.Drawing.Point(0, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(676, 145);
			this.panel9.TabIndex = 1;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox9.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(168, -1);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(492, 32);
			this.pictureBox9.TabIndex = 2;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox25
			// 
			this.pictureBox25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox25.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
			this.pictureBox25.Location = new System.Drawing.Point(654, 0);
			this.pictureBox25.Name = "pictureBox25";
			this.pictureBox25.Size = new System.Drawing.Size(22, 32);
			this.pictureBox25.TabIndex = 1;
			this.pictureBox25.TabStop = false;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.SystemColors.Highlight;
			this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
			this.label14.Location = new System.Drawing.Point(0, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(172, 32);
			this.label14.TabIndex = 0;
			this.label14.Text = "      OBS Info.";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox26
			// 
			this.pictureBox26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox26.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
			this.pictureBox26.Location = new System.Drawing.Point(657, 32);
			this.pictureBox26.Name = "pictureBox26";
			this.pictureBox26.Size = new System.Drawing.Size(19, 99);
			this.pictureBox26.TabIndex = 5;
			this.pictureBox26.TabStop = false;
			// 
			// pictureBox27
			// 
			this.pictureBox27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox27.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
			this.pictureBox27.Location = new System.Drawing.Point(0, 24);
			this.pictureBox27.Name = "pictureBox27";
			this.pictureBox27.Size = new System.Drawing.Size(32, 110);
			this.pictureBox27.TabIndex = 3;
			this.pictureBox27.TabStop = false;
			// 
			// pictureBox28
			// 
			this.pictureBox28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox28.BackColor = System.Drawing.Color.Blue;
			this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
			this.pictureBox28.Location = new System.Drawing.Point(586, 131);
			this.pictureBox28.Name = "pictureBox28";
			this.pictureBox28.Size = new System.Drawing.Size(90, 14);
			this.pictureBox28.TabIndex = 8;
			this.pictureBox28.TabStop = false;
			// 
			// pictureBox29
			// 
			this.pictureBox29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox29.BackColor = System.Drawing.Color.Blue;
			this.pictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox29.Image")));
			this.pictureBox29.Location = new System.Drawing.Point(72, 131);
			this.pictureBox29.Name = "pictureBox29";
			this.pictureBox29.Size = new System.Drawing.Size(588, 14);
			this.pictureBox29.TabIndex = 9;
			this.pictureBox29.TabStop = false;
			// 
			// pictureBox30
			// 
			this.pictureBox30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox30.BackColor = System.Drawing.Color.Blue;
			this.pictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox30.Image")));
			this.pictureBox30.Location = new System.Drawing.Point(0, 131);
			this.pictureBox30.Name = "pictureBox30";
			this.pictureBox30.Size = new System.Drawing.Size(80, 14);
			this.pictureBox30.TabIndex = 6;
			this.pictureBox30.TabStop = false;
			// 
			// pictureBox31
			// 
			this.pictureBox31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox31.BackColor = System.Drawing.Color.Navy;
			this.pictureBox31.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox31.Image")));
			this.pictureBox31.Location = new System.Drawing.Point(32, 24);
			this.pictureBox31.Name = "pictureBox31";
			this.pictureBox31.Size = new System.Drawing.Size(628, 113);
			this.pictureBox31.TabIndex = 4;
			this.pictureBox31.TabStop = false;
			// 
			// grp_create
			// 
			this.grp_create.BackColor = System.Drawing.Color.White;
			this.grp_create.Controls.Add(this.btn_zero_order);
			this.grp_create.Controls.Add(this.label3);
			this.grp_create.Controls.Add(this.label2);
			this.grp_create.Location = new System.Drawing.Point(16, 34);
			this.grp_create.Name = "grp_create";
			this.grp_create.Size = new System.Drawing.Size(656, 104);
			this.grp_create.TabIndex = 247;
			this.grp_create.TabStop = false;
			// 
			// btn_zero_order
			// 
			this.btn_zero_order.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.btn_zero_order.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_zero_order.Location = new System.Drawing.Point(25, 69);
			this.btn_zero_order.Name = "btn_zero_order";
			this.btn_zero_order.Size = new System.Drawing.Size(184, 27);
			this.btn_zero_order.TabIndex = 2;
			this.btn_zero_order.Text = "Create Zero Order";
			this.btn_zero_order.Click += new System.EventHandler(this.btn_zero_order_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(28, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(568, 24);
			this.label3.TabIndex = 1;
			this.label3.Text = "But nike don\'t give us zero order in Mercury";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(8, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(624, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "※ You can make zero quanity order for nike.  if you receive oa  which is 0 quntit" +
				"y ";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(48, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(176, 24);
			this.label4.TabIndex = 248;
			this.label4.Text = "Update Order Master";
			// 
			// POP_EO_INFO
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.ClientSize = new System.Drawing.Size(698, 439);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lbl_Save);
			this.Controls.Add(this.btn_Cancel);
			this.Font = new System.Drawing.Font("굴림", 8F);
			this.Name = "POP_EO_INFO";
			this.Load += new System.EventHandler(this.POP_EO_INFO_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.pnl_save_image.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.grp_create.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의
		string _RealYN ="Y";
		int   _Rowfixed = 2;
		

		COM.OraDB MyOraDB = new COM.OraDB();  
		private ClassLib.OraDB  MyClassLib = new ClassLib.OraDB();

		#endregion

		#region 멤버 메서드
		private void Init_Form()
		{ 
			//Title
			this.Text = "OBS Information";
			this.lbl_MainTitle.Text = "OBS Information";
			ClassLib.ComFunction.SetLangDic(this);
		
			// 콤보박스 설정
			///Factory
			DataTable dt_list;
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1); 
			cmb_Factory.SelectedValue = COM.ComVar.Parameter_PopUp[1];

			///OBS_Type
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxOBS_Type);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OBS_Type, 1, 2, true);  			
			cmb_OBS_Type.SelectedValue = COM.ComVar.Parameter_PopUp[2];

			#region 그리드 설정

			_RealYN =COM.ComVar.Parameter_PopUp[0];
			
			if (_RealYN =="N") 
				fgrid_Main.Set_Grid( "SEM_OBS_INFO", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			else
				fgrid_Main.Set_Grid( "SEM_OBS_INFO", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			fgrid_Main.Font  = new Font("Verdana",8);
			fgrid_Main.AllowMerging = AllowMergingEnum.Free;

			#endregion
			
			#region 초기값 설정

			cmb_Factory.SelectedValue  = COM.ComVar.Parameter_PopUp[1];
			cmb_OBS_Type.SelectedValue = COM.ComVar.Parameter_PopUp[2];
			cmb_OBS_ID.Text			   = COM.ComVar.Parameter_PopUp[3];
			txt_Style_cd.Text          = COM.ComVar.Parameter_PopUp[4];
			txt_OBS_Nu.Text = COM.ComVar.Parameter_PopUp[5];
			txt_Seq_Nu.Text = COM.ComVar.Parameter_PopUp[6];
			txt_Chg_Nu.Text = COM.ComVar.Parameter_PopUp[7];

			#endregion

			Sb_Select();
			//fgrid_Main.Set_Action_Image(img_Action); 
			fgrid_Main.Cols[0].Width   = 0 ;

		}

		/// <summary>
		/// Sb_Select : 조회하기
		/// </summary>
		private void Sb_Select()
		{
			try
			{
				DataTable dt_ret;

				//SEM_OBS/SEM_OBS_CS 정보를 읽어온다
				dt_ret = Select_OBS_Data();

				if (dt_ret  == null ) 
				{ ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch); return;}

				Display_Grid(dt_ret);

			}
			catch 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch);
			}		
		
		}
		

		/// <summary>
		/// Display_Grid : 조회 결과 
		/// </summary>
		private void Display_Grid(DataTable arg_ret)
		{

			fgrid_Main.Rows.Count = _Rowfixed;  
	 
			for(int i = 0; i < arg_ret.Rows.Count; i++)
			{
				fgrid_Main.AddItem(arg_ret.Rows[i].ItemArray, fgrid_Main.Rows.Count, 1);
				fgrid_Main[_Rowfixed,0]  = "U";   //한줄 update
				//fgrid_Main.Cols[0].Width = 0;
			} 

			fgrid_Main.AutoSizeCols();

		}

		#endregion

		#region DB 컨트롤



		public void Create_Zero()
		{


			DataSet ret;

			MyOraDB.ReDim_Parameter(6); 

			//Package Name
			MyOraDB.Process_Name=  "PKG_SEM_OBS.CREATE_ZERO_ORDER";
			
			//Parameter Name
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OBS_NU";
			MyOraDB.Parameter_Name[2] = "ARG_OBS_SEQ_NU";
			MyOraDB.Parameter_Name[3] = "ARG_CHG_NU";
			MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";
			MyOraDB.Parameter_Name[5] = "ARG_UPD_YMD";


				
			//Parameter Type
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
		    MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;


			//Parameter Value
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = txt_OBS_Nu.Text.Trim();
			MyOraDB.Parameter_Values[2] = txt_Seq_Nu.Text.Trim();
			MyOraDB.Parameter_Values[3] = txt_Chg_Nu.Text.Trim();
			MyOraDB.Parameter_Values[4] = ClassLib.ComVar.This_Factory;
			MyOraDB.Parameter_Values[5] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");   

		
			MyOraDB.Add_Modify_Parameter(true);	
			
			ret =  MyOraDB.Exe_Modify_Procedure();	
		    
		

		}




		/// <summary>
		/// Select_OBS_Data : SEM_OBS 리스트 찾기 
		/// </summary>
		private DataTable Select_OBS_Data()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_OBS.SELECT_SEM_OBS_POP";

			int iCnt  =9;
			MyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
		 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0]  = "ARG_REAL_YN";
			MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[3]  = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[4]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[5]  = "ARG_OBS_NU";
			MyOraDB.Parameter_Name[6]  = "ARG_OBS_SEQ_NU";
			MyOraDB.Parameter_Name[7]  = "ARG_CHG_NU";
			MyOraDB.Parameter_Name[8]   = "OUT_CURSOR";

			//03.DATA TYPE
			for (int i =0; i<iCnt-1 ;i++)
			MyOraDB.Parameter_Type[i]  = (int)OracleType.VarChar;
			
			MyOraDB.Parameter_Type[iCnt-1]  = (int)OracleType.Cursor;
					

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = _RealYN;
			MyOraDB.Parameter_Values[1]  = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2]  = cmb_OBS_ID.Text.ToString();
			MyOraDB.Parameter_Values[3]  = cmb_OBS_Type.SelectedValue.ToString();
			MyOraDB.Parameter_Values[4]  = ClassLib.ComFunction.Empty_String(txt_Style_cd.Text , " ");
			MyOraDB.Parameter_Values[5]  = ClassLib.ComFunction.Empty_String(txt_OBS_Nu.Text , " ");
			MyOraDB.Parameter_Values[6]  = ClassLib.ComFunction.Empty_String(txt_Seq_Nu.Text , " ");
			MyOraDB.Parameter_Values[7]  = ClassLib.ComFunction.Empty_String(txt_Chg_Nu.Text , " ");
			MyOraDB.Parameter_Values[8]  = "";
					

			MyOraDB.Add_Select_Parameter(true);
		 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
					
			return ds_ret.Tables[process_name]; 
		}
		#endregion

		#region 이벤트처리
		
		private void lbl_Save_Click(object sender, System.EventArgs e)
		{
			try
			{
				DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
				if(DialogResult.Yes != dr) return;

				fgrid_Main.Select(fgrid_Main.Selection.r1, 0, fgrid_Main.Selection.r1, fgrid_Main.Cols.Count-1, false);

				if (fgrid_Main[fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_OBS_POP.IxOBS_NU].ToString().Substring(0,1) =="C")
					MyOraDB.Save_FlexGird ("01", "PKG_SEM_OBS.UPDATE_SEM_OBS_CS_POP", fgrid_Main);
				else
					MyOraDB.Save_FlexGird ("01", "PKG_SEM_OBS.UPDATE_SEM_OBS_POP", fgrid_Main);

				fgrid_Main.Rows.Count = _Rowfixed;		

				Sb_Select();
			}
			catch 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave,this);
			}
		}


		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}


		private void cmb_OBS_Type_TextChanged(object sender, System.EventArgs e)
		{
			cmb_OBS_ID.ClearItems();

			if (cmb_OBS_Type.SelectedIndex != 0)
			{
				ClassLib.ComFunction.Set_OBSID_CmbList(cmb_OBS_Type.SelectedValue.ToString(), cmb_OBS_ID);  
			}
		}


		#endregion

		private void POP_EO_INFO_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void btn_zero_order_Click(object sender, System.EventArgs e)
		{
			try
			{
				

				DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
				if(DialogResult.Yes != dr) return;


				Create_Zero();

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave,this);




				this.Close();


			}
			catch 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave,this);
			}

		}

	}
}

