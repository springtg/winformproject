using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace COM.APSWinForm
{
	/// <summary>
	/// PopUp_Small에 대한 요약 설명입니다.
	/// </summary>
	public class Pop_Small : System.Windows.Forms.Form
	{
		public System.Windows.Forms.ImageList img_Label;
		public System.Windows.Forms.ImageList img_Button;
		public System.Windows.Forms.Label lbl_MainTitle;
		private System.ComponentModel.IContainer components;

		public Pop_Small()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
		}

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Small));
            this.img_Label = new System.Windows.Forms.ImageList(this.components);
            this.img_Button = new System.Windows.Forms.ImageList(this.components);
            this.lbl_MainTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MainTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MainTitle.ForeColor = System.Drawing.Color.Navy;
            this.lbl_MainTitle.Location = new System.Drawing.Point(40, 8);
            this.lbl_MainTitle.Name = "lbl_MainTitle";
            this.lbl_MainTitle.Size = new System.Drawing.Size(224, 23);
            this.lbl_MainTitle.TabIndex = 26;
            this.lbl_MainTitle.Text = "title";
            this.lbl_MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pop_Small
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(394, 268);
            this.Controls.Add(this.lbl_MainTitle);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pop_Small";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pop_Small";
            this.ResumeLayout(false);

		}
		#endregion
	}
}
