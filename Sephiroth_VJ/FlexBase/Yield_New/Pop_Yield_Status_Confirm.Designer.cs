namespace FlexBase.Yield_New
{
    partial class Pop_Yield_Status_Confirm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Yield_Status_Confirm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dpick_ConfirmYMD = new System.Windows.Forms.DateTimePicker();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.lbl_ConfirmYMD = new System.Windows.Forms.Label();
            this.lbl_Remarks = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.lbl_MainTitle.Location = new System.Drawing.Point(46, 9);
            this.lbl_MainTitle.Size = new System.Drawing.Size(355, 27);
            this.lbl_MainTitle.Text = "Yield Status";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dpick_ConfirmYMD);
            this.groupBox1.Controls.Add(this.txt_Remarks);
            this.groupBox1.Controls.Add(this.txt_Status);
            this.groupBox1.Controls.Add(this.lbl_ConfirmYMD);
            this.groupBox1.Controls.Add(this.lbl_Remarks);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Location = new System.Drawing.Point(3, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 88);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // dpick_ConfirmYMD
            // 
            this.dpick_ConfirmYMD.Font = new System.Drawing.Font("Verdana", 8F);
            this.dpick_ConfirmYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_ConfirmYMD.Location = new System.Drawing.Point(108, 36);
            this.dpick_ConfirmYMD.Name = "dpick_ConfirmYMD";
            this.dpick_ConfirmYMD.Size = new System.Drawing.Size(270, 20);
            this.dpick_ConfirmYMD.TabIndex = 546;
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Remarks.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_Remarks.Location = new System.Drawing.Point(108, 59);
            this.txt_Remarks.MaxLength = 18;
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Size = new System.Drawing.Size(268, 19);
            this.txt_Remarks.TabIndex = 2;
            // 
            // txt_Status
            // 
            this.txt_Status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Status.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_Status.Location = new System.Drawing.Point(108, 15);
            this.txt_Status.MaxLength = 100;
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.ReadOnly = true;
            this.txt_Status.Size = new System.Drawing.Size(268, 19);
            this.txt_Status.TabIndex = 545;
            this.txt_Status.TabStop = false;
            // 
            // lbl_ConfirmYMD
            // 
            this.lbl_ConfirmYMD.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_ConfirmYMD.ImageIndex = 0;
            this.lbl_ConfirmYMD.ImageList = this.img_Label;
            this.lbl_ConfirmYMD.Location = new System.Drawing.Point(7, 36);
            this.lbl_ConfirmYMD.Name = "lbl_ConfirmYMD";
            this.lbl_ConfirmYMD.Size = new System.Drawing.Size(100, 21);
            this.lbl_ConfirmYMD.TabIndex = 542;
            this.lbl_ConfirmYMD.Text = "Confirm Date";
            this.lbl_ConfirmYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Remarks
            // 
            this.lbl_Remarks.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_Remarks.ImageIndex = 0;
            this.lbl_Remarks.ImageList = this.img_Label;
            this.lbl_Remarks.Location = new System.Drawing.Point(7, 58);
            this.lbl_Remarks.Name = "lbl_Remarks";
            this.lbl_Remarks.Size = new System.Drawing.Size(100, 21);
            this.lbl_Remarks.TabIndex = 541;
            this.lbl_Remarks.Text = "Remarks";
            this.lbl_Remarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Status
            // 
            this.lbl_Status.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_Status.ImageIndex = 0;
            this.lbl_Status.ImageList = this.img_Label;
            this.lbl_Status.Location = new System.Drawing.Point(7, 14);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(100, 21);
            this.lbl_Status.TabIndex = 540;
            this.lbl_Status.Text = "Status";
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 8F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.Location = new System.Drawing.Point(318, 127);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 21);
            this.btn_Cancel.TabIndex = 678;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Apply
            // 
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apply.Font = new System.Drawing.Font("Verdana", 8F);
            this.btn_Apply.ImageIndex = 0;
            this.btn_Apply.Location = new System.Drawing.Point(246, 127);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(70, 21);
            this.btn_Apply.TabIndex = 679;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // Pop_Status_Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 152);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.Name = "Pop_Status_Confirm";
            this.Text = "Yield Status";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.btn_Apply, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dpick_ConfirmYMD;
        private System.Windows.Forms.TextBox txt_Remarks;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label lbl_ConfirmYMD;
        private System.Windows.Forms.Label lbl_Remarks;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Apply;

    }
}