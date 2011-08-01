using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace COM.PCHWinForm
{
	/// <summary>
	/// PopUp_Small에 대한 요약 설명입니다.
	/// </summary>
	public class Pop_Normal_Light : System.Windows.Forms.Form
	{
		public System.Windows.Forms.ImageList img_Label;
		public System.Windows.Forms.Label lbl_MainTitle;
		private System.Windows.Forms.Panel pnl_BackImage;
		public System.Windows.Forms.ImageList img_Button;
		private System.ComponentModel.IContainer components;

		public Pop_Normal_Light()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Normal_Light));
			this.img_Label = new System.Windows.Forms.ImageList(this.components);
			this.lbl_MainTitle = new System.Windows.Forms.Label();
			this.pnl_BackImage = new System.Windows.Forms.Panel();
			this.img_Button = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// img_Label
			// 
			this.img_Label.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Label.ImageSize = new System.Drawing.Size(100, 21);
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			this.img_Label.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_MainTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(240)), ((System.Byte)(247)), ((System.Byte)(255)));
			this.lbl_MainTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_MainTitle.ForeColor = System.Drawing.Color.Navy;
			this.lbl_MainTitle.Location = new System.Drawing.Point(40, 8);
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(456, 23);
			this.lbl_MainTitle.TabIndex = 26;
			this.lbl_MainTitle.Text = "title";
			this.lbl_MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_BackImage
			// 
			this.pnl_BackImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_BackImage.BackgroundImage")));
			this.pnl_BackImage.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_BackImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_BackImage.Name = "pnl_BackImage";
			this.pnl_BackImage.Size = new System.Drawing.Size(494, 80);
			this.pnl_BackImage.TabIndex = 27;
			// 
			// img_Button
			// 
			this.img_Button.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Button.ImageSize = new System.Drawing.Size(70, 23);
			this.img_Button.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Pop_Normal_Light
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(494, 368);
			this.Controls.Add(this.lbl_MainTitle);
			this.Controls.Add(this.pnl_BackImage);
			this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Pop_Normal_Light";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pop_Normal_Light";
			this.Load += new System.EventHandler(this.Pop_Normal_Light_Load);
			this.Closed += new System.EventHandler(this.Pop_Normal_Light_Closed);
			this.ResumeLayout(false);

		}
		#endregion

 
		private void Pop_Normal_Light_Load(object sender, System.EventArgs e)
		{
			 
		}

		private void Pop_Normal_Light_Closed(object sender, System.EventArgs e)
		{
			try
			{
				string menu_pg = this.GetType().ToString(); 
				COM.ComFunction.Delete_Window_Menu(this.ParentForm, menu_pg);

				//this.Dispose(true);
 
			}
			catch(Exception ex)
			{
				COM.ComFunction.User_Message(ex.Message, "Form Closed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}




		}


		
	}
}
