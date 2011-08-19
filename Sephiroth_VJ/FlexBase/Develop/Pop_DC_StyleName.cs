using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FlexBase.Develop
{
	public class Pop_DC_StyleName : COM.PCHWinForm.Pop_Small
	{
		#region 디자이너에서 생성한 코드
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.TextBox txt_Name;
		private System.Windows.Forms.Label lbl_StyleName;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.ComponentModel.IContainer components = null;

		public Pop_DC_StyleName()
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

		
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_DC_StyleName));
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.btn_apply = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_StyleName = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnl_Search.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(344, 23);
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
            // pnl_Search
            // 
            this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Search.Controls.Add(this.btn_apply);
            this.pnl_Search.Controls.Add(this.btn_cancel);
            this.pnl_Search.Controls.Add(this.pnl_SearchImage);
            this.pnl_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Search.Location = new System.Drawing.Point(0, 0);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Search.Size = new System.Drawing.Size(378, 108);
            this.pnl_Search.TabIndex = 46;
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(225, 80);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 23);
            this.btn_apply.TabIndex = 19;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(298, 80);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 20;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.txt_Name);
            this.pnl_SearchImage.Controls.Add(this.lbl_StyleName);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(360, 70);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.White;
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("굴림", 8.5F);
            this.txt_Name.Location = new System.Drawing.Point(111, 36);
            this.txt_Name.MaxLength = 60;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Name.Size = new System.Drawing.Size(241, 21);
            this.txt_Name.TabIndex = 149;
            // 
            // lbl_StyleName
            // 
            this.lbl_StyleName.ImageIndex = 0;
            this.lbl_StyleName.ImageList = this.img_Label;
            this.lbl_StyleName.Location = new System.Drawing.Point(10, 36);
            this.lbl_StyleName.Name = "lbl_StyleName";
            this.lbl_StyleName.Size = new System.Drawing.Size(100, 21);
            this.lbl_StyleName.TabIndex = 146;
            this.lbl_StyleName.Text = "Style Name";
            this.lbl_StyleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(259, 32);
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
            this.picb_TR.Location = new System.Drawing.Point(344, 0);
            this.picb_TR.Name = "picb_TR";
            this.picb_TR.Size = new System.Drawing.Size(16, 16);
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
            this.picb_TM.Size = new System.Drawing.Size(136, 32);
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
            this.picb_BR.Location = new System.Drawing.Point(344, 55);
            this.picb_BR.Name = "picb_BR";
            this.picb_BR.Size = new System.Drawing.Size(16, 16);
            this.picb_BR.TabIndex = 23;
            this.picb_BR.TabStop = false;
            // 
            // picb_BM
            // 
            this.picb_BM.Location = new System.Drawing.Point(0, 0);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(100, 50);
            this.picb_BM.TabIndex = 0;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Location = new System.Drawing.Point(0, 0);
            this.picb_BL.Name = "picb_BL";
            this.picb_BL.Size = new System.Drawing.Size(100, 50);
            this.picb_BL.TabIndex = 0;
            this.picb_BL.TabStop = false;
            // 
            // picb_ML
            // 
            this.picb_ML.Location = new System.Drawing.Point(0, 0);
            this.picb_ML.Name = "picb_ML";
            this.picb_ML.Size = new System.Drawing.Size(100, 50);
            this.picb_ML.TabIndex = 0;
            this.picb_ML.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            // 
            // Pop_DC_StyleName
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(378, 108);
            this.Controls.Add(this.pnl_Search);
            this.Name = "Pop_DC_StyleName";
            this.Load += new System.EventHandler(this.Pop_DC_StyleName_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.pnl_Search, 0);
            this.pnl_Search.ResumeLayout(false);
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
            this.ResumeLayout(false);

		}
		#endregion


        private void Pop_DC_StyleName_Load(object sender, EventArgs e)
        {

            //Title
            this.Text = "Style Name";
            lbl_MainTitle.Text = "Style Name";
            ClassLib.ComFunction.SetLangDic(this);

        }


		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			COM.ComVar.Parameter_PopUp = new string[1]; 
			COM.ComVar.Parameter_PopUp[0] = "null";
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			
			COM.ComVar.Parameter_PopUp = new string[1]; 
			COM.ComVar.Parameter_PopUp[0] = txt_Name.Text.Replace("'","");

			 
			this.DialogResult = DialogResult.OK;
			this.Close(); 
		}

	}
}

