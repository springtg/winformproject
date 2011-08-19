using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexPurchase.Incoming
{
	public class Pop_BI_Incoming_Adjust_Desc : COM.PCHWinForm.Pop_Small
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_buyDiv;
		private System.Windows.Forms.Label lbl_vendor;
		private System.Windows.Forms.Label lbl_custYm;
		private System.Windows.Forms.TextBox txt_factLoc;
		private System.Windows.Forms.Label lbl_purUser;
		private System.Windows.Forms.Label lbl_usd;
		private System.Windows.Forms.Label lbl_krw;
		private System.Windows.Forms.TextBox txt_custYm;
		private System.Windows.Forms.TextBox txt_custName;
		private System.Windows.Forms.TextBox txt_buyDivName;
		private System.Windows.Forms.TextBox txt_adjustUsd;
		private System.Windows.Forms.TextBox txt_adjustKrw;
		private System.Windows.Forms.TextBox txt_buyDiv;
		private System.Windows.Forms.TextBox txt_custCd;
		private System.Windows.Forms.Label lbl_adjustDesc;
		private System.Windows.Forms.RichTextBox rtb_desc;
		private System.Windows.Forms.Label btn_save;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txt_vatKrw;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt_purUser;
		private Form_BI_Incoming_Vendor_Total account_from = null;
		private int sct_rows = 0;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB	= new COM.OraDB();

		#endregion

		#region 생성자 / 소멸자
		public Pop_BI_Incoming_Adjust_Desc(Form_BI_Incoming_Vendor_Total arg_from, int arg_sct_row)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			account_from = arg_from;
			sct_rows = arg_sct_row;
		}

		public Pop_BI_Incoming_Adjust_Desc()
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

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		#endregion
		
		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BI_Incoming_Adjust_Desc));
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_vatKrw = new System.Windows.Forms.TextBox();
            this.rtb_desc = new System.Windows.Forms.RichTextBox();
            this.lbl_adjustDesc = new System.Windows.Forms.Label();
            this.txt_custCd = new System.Windows.Forms.TextBox();
            this.txt_buyDiv = new System.Windows.Forms.TextBox();
            this.txt_adjustKrw = new System.Windows.Forms.TextBox();
            this.txt_adjustUsd = new System.Windows.Forms.TextBox();
            this.txt_buyDivName = new System.Windows.Forms.TextBox();
            this.txt_custName = new System.Windows.Forms.TextBox();
            this.txt_custYm = new System.Windows.Forms.TextBox();
            this.txt_purUser = new System.Windows.Forms.TextBox();
            this.lbl_krw = new System.Windows.Forms.Label();
            this.lbl_usd = new System.Windows.Forms.Label();
            this.txt_factLoc = new System.Windows.Forms.TextBox();
            this.lbl_purUser = new System.Windows.Forms.Label();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.lbl_buyDiv = new System.Windows.Forms.Label();
            this.lbl_custYm = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.panel2);
            this.c1Sizer1.GridDefinition = "84.5588235294118:False:True;11.0294117647059:False:True;\t1.01010101010101:False:T" +
                "rue;93.9393939393939:False:False;1.01010101010101:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(396, 272);
            this.c1Sizer1.TabIndex = 27;
            this.c1Sizer1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txt_vatKrw);
            this.panel1.Controls.Add(this.rtb_desc);
            this.panel1.Controls.Add(this.lbl_adjustDesc);
            this.panel1.Controls.Add(this.txt_custCd);
            this.panel1.Controls.Add(this.txt_buyDiv);
            this.panel1.Controls.Add(this.txt_adjustKrw);
            this.panel1.Controls.Add(this.txt_adjustUsd);
            this.panel1.Controls.Add(this.txt_buyDivName);
            this.panel1.Controls.Add(this.txt_custName);
            this.panel1.Controls.Add(this.txt_custYm);
            this.panel1.Controls.Add(this.txt_purUser);
            this.panel1.Controls.Add(this.lbl_krw);
            this.panel1.Controls.Add(this.lbl_usd);
            this.panel1.Controls.Add(this.txt_factLoc);
            this.panel1.Controls.Add(this.lbl_purUser);
            this.panel1.Controls.Add(this.lbl_vendor);
            this.panel1.Controls.Add(this.lbl_buyDiv);
            this.panel1.Controls.Add(this.lbl_custYm);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 230);
            this.panel1.TabIndex = 183;
            // 
            // txt_vatKrw
            // 
            this.txt_vatKrw.Location = new System.Drawing.Point(48, 184);
            this.txt_vatKrw.Name = "txt_vatKrw";
            this.txt_vatKrw.Size = new System.Drawing.Size(8, 21);
            this.txt_vatKrw.TabIndex = 409;
            this.txt_vatKrw.Visible = false;
            // 
            // rtb_desc
            // 
            this.rtb_desc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rtb_desc.Location = new System.Drawing.Point(110, 148);
            this.rtb_desc.Name = "rtb_desc";
            this.rtb_desc.Size = new System.Drawing.Size(256, 70);
            this.rtb_desc.TabIndex = 1;
            this.rtb_desc.Text = "";
            // 
            // lbl_adjustDesc
            // 
            this.lbl_adjustDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_adjustDesc.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adjustDesc.ImageIndex = 0;
            this.lbl_adjustDesc.ImageList = this.img_Label;
            this.lbl_adjustDesc.Location = new System.Drawing.Point(8, 148);
            this.lbl_adjustDesc.Name = "lbl_adjustDesc";
            this.lbl_adjustDesc.Size = new System.Drawing.Size(100, 21);
            this.lbl_adjustDesc.TabIndex = 407;
            this.lbl_adjustDesc.Text = "Reason";
            this.lbl_adjustDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_custCd
            // 
            this.txt_custCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_custCd.Location = new System.Drawing.Point(110, 60);
            this.txt_custCd.Name = "txt_custCd";
            this.txt_custCd.ReadOnly = true;
            this.txt_custCd.Size = new System.Drawing.Size(56, 21);
            this.txt_custCd.TabIndex = 0;
            // 
            // txt_buyDiv
            // 
            this.txt_buyDiv.Location = new System.Drawing.Point(16, 184);
            this.txt_buyDiv.Name = "txt_buyDiv";
            this.txt_buyDiv.Size = new System.Drawing.Size(8, 21);
            this.txt_buyDiv.TabIndex = 405;
            this.txt_buyDiv.Visible = false;
            // 
            // txt_adjustKrw
            // 
            this.txt_adjustKrw.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_adjustKrw.Location = new System.Drawing.Point(110, 126);
            this.txt_adjustKrw.Name = "txt_adjustKrw";
            this.txt_adjustKrw.Size = new System.Drawing.Size(256, 21);
            this.txt_adjustKrw.TabIndex = 5;
            // 
            // txt_adjustUsd
            // 
            this.txt_adjustUsd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_adjustUsd.Location = new System.Drawing.Point(110, 104);
            this.txt_adjustUsd.Name = "txt_adjustUsd";
            this.txt_adjustUsd.Size = new System.Drawing.Size(256, 21);
            this.txt_adjustUsd.TabIndex = 4;
            // 
            // txt_buyDivName
            // 
            this.txt_buyDivName.Location = new System.Drawing.Point(110, 82);
            this.txt_buyDivName.Name = "txt_buyDivName";
            this.txt_buyDivName.ReadOnly = true;
            this.txt_buyDivName.Size = new System.Drawing.Size(256, 21);
            this.txt_buyDivName.TabIndex = 0;
            // 
            // txt_custName
            // 
            this.txt_custName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_custName.Location = new System.Drawing.Point(166, 60);
            this.txt_custName.Name = "txt_custName";
            this.txt_custName.ReadOnly = true;
            this.txt_custName.Size = new System.Drawing.Size(200, 21);
            this.txt_custName.TabIndex = 0;
            // 
            // txt_custYm
            // 
            this.txt_custYm.Location = new System.Drawing.Point(110, 38);
            this.txt_custYm.Name = "txt_custYm";
            this.txt_custYm.ReadOnly = true;
            this.txt_custYm.Size = new System.Drawing.Size(256, 21);
            this.txt_custYm.TabIndex = 0;
            // 
            // txt_purUser
            // 
            this.txt_purUser.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txt_purUser.Location = new System.Drawing.Point(110, 16);
            this.txt_purUser.Name = "txt_purUser";
            this.txt_purUser.Size = new System.Drawing.Size(256, 21);
            this.txt_purUser.TabIndex = 0;
            // 
            // lbl_krw
            // 
            this.lbl_krw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_krw.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_krw.ImageIndex = 0;
            this.lbl_krw.ImageList = this.img_Label;
            this.lbl_krw.Location = new System.Drawing.Point(8, 126);
            this.lbl_krw.Name = "lbl_krw";
            this.lbl_krw.Size = new System.Drawing.Size(100, 21);
            this.lbl_krw.TabIndex = 398;
            this.lbl_krw.Text = "KRW";
            this.lbl_krw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_usd
            // 
            this.lbl_usd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_usd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usd.ImageIndex = 0;
            this.lbl_usd.ImageList = this.img_Label;
            this.lbl_usd.Location = new System.Drawing.Point(8, 104);
            this.lbl_usd.Name = "lbl_usd";
            this.lbl_usd.Size = new System.Drawing.Size(100, 21);
            this.lbl_usd.TabIndex = 397;
            this.lbl_usd.Text = "USD";
            this.lbl_usd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_factLoc
            // 
            this.txt_factLoc.Location = new System.Drawing.Point(32, 184);
            this.txt_factLoc.Name = "txt_factLoc";
            this.txt_factLoc.Size = new System.Drawing.Size(8, 21);
            this.txt_factLoc.TabIndex = 396;
            this.txt_factLoc.Visible = false;
            // 
            // lbl_purUser
            // 
            this.lbl_purUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_purUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purUser.ImageIndex = 1;
            this.lbl_purUser.ImageList = this.img_Label;
            this.lbl_purUser.Location = new System.Drawing.Point(8, 16);
            this.lbl_purUser.Name = "lbl_purUser";
            this.lbl_purUser.Size = new System.Drawing.Size(100, 21);
            this.lbl_purUser.TabIndex = 395;
            this.lbl_purUser.Text = "User";
            this.lbl_purUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 1;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(8, 60);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 393;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_buyDiv
            // 
            this.lbl_buyDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_buyDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buyDiv.ImageIndex = 1;
            this.lbl_buyDiv.ImageList = this.img_Label;
            this.lbl_buyDiv.Location = new System.Drawing.Point(8, 82);
            this.lbl_buyDiv.Name = "lbl_buyDiv";
            this.lbl_buyDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_buyDiv.TabIndex = 362;
            this.lbl_buyDiv.Text = "Buy Division";
            this.lbl_buyDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_custYm
            // 
            this.lbl_custYm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_custYm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_custYm.ImageIndex = 1;
            this.lbl_custYm.ImageList = this.img_Label;
            this.lbl_custYm.Location = new System.Drawing.Point(8, 38);
            this.lbl_custYm.Name = "lbl_custYm";
            this.lbl_custYm.Size = new System.Drawing.Size(100, 21);
            this.lbl_custYm.TabIndex = 52;
            this.lbl_custYm.Text = "Y/M";
            this.lbl_custYm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 226);
            this.groupBox1.TabIndex = 410;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(12, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 30);
            this.panel2.TabIndex = 182;
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageIndex = 1;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(272, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseDown);
            this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseUp);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_save.ImageIndex = 1;
            this.btn_save.ImageList = this.img_Button;
            this.btn_save.Location = new System.Drawing.Point(200, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(70, 24);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_save_MouseDown);
            this.btn_save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_save_MouseUp);
            // 
            // Pop_BI_Incoming_Adjust_Desc
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 312);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BI_Incoming_Adjust_Desc";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region 컨트롤 이벤트 처리



		private void btn_save_Click(object sender, System.EventArgs e)
		{
			Tbtn_SaveProcess();
			this.Close();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region 롤오버 이미지 처리
		private void btn_save_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_save.ImageIndex = 0; 
		}

		private void btn_save_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_save.ImageIndex = 1; 
		}
 
		private void btn_cancel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_cancel.ImageIndex = 0;
		}

		private void btn_cancel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_cancel.ImageIndex = 1;
		}
		#endregion

		#region 이벤트 처리 메서드

		private void Init_Form()
		{
			// Form Setting
            //			ClassLib.ComFunction.Init_Form_Control(this);
			lbl_MainTitle.Text = "Adjust Description";
            this.Text = "Adjust Description";
            ClassLib.ComFunction.SetLangDic(this);

			this.txt_factLoc.Text		= COM.ComVar.Parameter_PopUp[0];
			this.txt_custYm.Text		= COM.ComVar.Parameter_PopUp[1];
			this.txt_custCd.Text		= COM.ComVar.Parameter_PopUp[2];
			this.txt_custName.Text		= COM.ComVar.Parameter_PopUp[3];
			this.txt_buyDiv.Text		= COM.ComVar.Parameter_PopUp[4];
			this.txt_buyDivName.Text	= COM.ComVar.Parameter_PopUp[5];			
			this.txt_adjustUsd.Text		= COM.ComVar.Parameter_PopUp[6];
			this.txt_adjustKrw.Text		= COM.ComVar.Parameter_PopUp[7];
			this.txt_vatKrw.Text		= COM.ComVar.Parameter_PopUp[8];
			this.txt_purUser.Text		= COM.ComVar.Parameter_PopUp[9];

//			DataTable vTemp = this.SELECT_SBI_ACCOUNT_DESC(	COM.ComVar.Parameter_PopUp[0],
//															COM.ComVar.Parameter_PopUp[2],
//															COM.ComVar.Parameter_PopUp[1],
//															COM.ComVar.Parameter_PopUp[4], 
//															COM.ComVar.Parameter_PopUp[9]);
//			if (vTemp.Rows.Count > 0)
//			{
//				this.rtb_desc.Text		= vTemp.Rows[0].ItemArray[0].ToString();  // DESC
//			}

			rtb_desc.Text = COM.ComVar.Parameter_PopUp[10];
		}

		private void Tbtn_SaveProcess()
		{
			try
			{ 
				SAVE_SBI_ACCOUNT_HEAD();
			}
			catch (Exception ex)
			{			
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// SAVE_SBI_IN_HEAD : 헤더 정보 저장
		/// </summary>
		public void SAVE_SBI_ACCOUNT_HEAD()
		{
			MyOraDB.ReDim_Parameter(24);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_ADJUST_VENDOR.SAVE_SBI_ACCOUNT_HEAD";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]   = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1]   = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2]   = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[3]   = "ARG_CUST_NAME";
			MyOraDB.Parameter_Name[4]   = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[5]   = "ARG_ITEM_NAME";
			MyOraDB.Parameter_Name[6]   = "ARG_IN_QTY";
			MyOraDB.Parameter_Name[7]   = "ARG_USD_PRICE";
			MyOraDB.Parameter_Name[8]   = "ARG_CUR_PRICE";
			MyOraDB.Parameter_Name[9]   = "ARG_BUY_DIV";
			MyOraDB.Parameter_Name[10]  = "ARG_POS";
			MyOraDB.Parameter_Name[11]  = "ARG_AMOUNT_USD";
			MyOraDB.Parameter_Name[12]  = "ARG_AMOUNT_KRW";
			MyOraDB.Parameter_Name[13]  = "ARG_ADJUST_USD";
			MyOraDB.Parameter_Name[14]  = "ARG_ADJUST_KRW";
			MyOraDB.Parameter_Name[15]  = "ARG_VAT_KRW";
			MyOraDB.Parameter_Name[16]  = "ARG_ADJUST_DESC";
			MyOraDB.Parameter_Name[17]  = "ARG_PUR_USER";
			MyOraDB.Parameter_Name[18]  = "ARG_FACT_LOC";
			MyOraDB.Parameter_Name[19]  = "ARG_CUST_YM";
			MyOraDB.Parameter_Name[20]  = "ARG_ACCOUNT_STATUS";
			MyOraDB.Parameter_Name[21]  = "ARG_ACCOUNT_CONF";
			MyOraDB.Parameter_Name[22]  = "ARG_TREE_LEVEL";
			MyOraDB.Parameter_Name[23]  = "ARG_UPD_USER";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]   = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]   = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]   = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]   = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]   = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]   = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6]   = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7]   = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8]   = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[9]   = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[10]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[11]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[12]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[13]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[14]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[15]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[16]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[17]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[18]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[19]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[20]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[21]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[22]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[23]  = (int)OracleType.VarChar;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]   = "U";
			MyOraDB.Parameter_Values[1]   = ClassLib.ComVar.This_Factory;
			MyOraDB.Parameter_Values[2]   = COM.ComFunction.Empty_TextBox(txt_custCd, "");
			MyOraDB.Parameter_Values[3]   = "";
			MyOraDB.Parameter_Values[4]   = "";
			MyOraDB.Parameter_Values[5]   = "";
			MyOraDB.Parameter_Values[6]   = "";
			MyOraDB.Parameter_Values[7]   = "";
			MyOraDB.Parameter_Values[8]   = "";
			MyOraDB.Parameter_Values[9]   = COM.ComFunction.Empty_TextBox(txt_buyDiv, "");
			MyOraDB.Parameter_Values[10]  = "";
			MyOraDB.Parameter_Values[11]  = "";
			MyOraDB.Parameter_Values[12]  = "";
			MyOraDB.Parameter_Values[13]  = COM.ComFunction.Empty_TextBox(txt_adjustUsd, "");
			MyOraDB.Parameter_Values[14]  = COM.ComFunction.Empty_TextBox(txt_adjustKrw, "");
			MyOraDB.Parameter_Values[15]  = COM.ComFunction.Empty_TextBox(txt_vatKrw, "");
			MyOraDB.Parameter_Values[16]  = rtb_desc.Text.Trim();
			MyOraDB.Parameter_Values[17]  = COM.ComFunction.Empty_TextBox(txt_purUser, "").ToLower();;
			MyOraDB.Parameter_Values[18]  = COM.ComFunction.Empty_TextBox(txt_factLoc, "");
			MyOraDB.Parameter_Values[19]  = COM.ComFunction.Empty_TextBox(txt_custYm, "");
			MyOraDB.Parameter_Values[20]  = "";
			MyOraDB.Parameter_Values[21]  = "";
			MyOraDB.Parameter_Values[22]  = "";
			MyOraDB.Parameter_Values[23]  = COM.ComVar.This_User;

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();



			if(account_from != null)
			{
				account_from.fgrid_main[sct_rows, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxADJUST_DESC] = rtb_desc.Text;
			}
		}

		/// <summary>
		/// PKG_SBI_IN_ADJUST_VENDOR : 
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_style_cd">스타일코드</param>
		/// <param name="arg_gender">젠더</param>
		/// <param name="arg_dev">Dev</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBI_ACCOUNT_DESC(string arg_factLoc, string arg_custCd, string arg_custYm, string arg_buyDiv, string arg_purUser)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_ADJUST_VENDOR.SELECT_SBI_ACCOUNT_DESC";
															 
			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACT_LOC";
			MyOraDB.Parameter_Name[1] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[2] = "ARG_CUST_YM";
			MyOraDB.Parameter_Name[3] = "ARG_BUY_DIV";
			MyOraDB.Parameter_Name[4] = "ARG_PUR_USER";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factLoc;
			MyOraDB.Parameter_Values[1] = arg_custCd;
			MyOraDB.Parameter_Values[2] = arg_custYm;
			MyOraDB.Parameter_Values[3] = arg_buyDiv;
			MyOraDB.Parameter_Values[4] = arg_purUser;
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			for(int i=2; i<account_from.fgrid_main.Rows.Count; i++)
			{
				account_from.fgrid_main[i, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxADJUST_DESC] = rtb_desc.Text;
			}
		}


	}
}

