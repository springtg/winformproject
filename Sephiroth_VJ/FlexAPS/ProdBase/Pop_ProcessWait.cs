using System;
using System.Threading;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FlexAPS.ProdBase
{
	/// <summary>
	/// Pop_BS_Shipping_List_Wait에 대한 요약 설명입니다.
	/// </summary>
	public class Pop_ProcessWait : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label lbl_state;
		private System.Windows.Forms.Timer timer;
		public System.Windows.Forms.ImageList img_Button;
		private bool _flag = true;
		private string _msg = "Processing...";

		public Pop_ProcessWait()
		{
			InitializeComponent();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_ProcessWait));
			this.lbl_state = new System.Windows.Forms.Label();
			this.img_Button = new System.Windows.Forms.ImageList(this.components);
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lbl_state
			// 
			this.lbl_state.BackColor = System.Drawing.Color.Transparent;
			this.lbl_state.ForeColor = System.Drawing.Color.Red;
			this.lbl_state.Location = new System.Drawing.Point(32, 160);
			this.lbl_state.Name = "lbl_state";
			this.lbl_state.Size = new System.Drawing.Size(296, 24);
			this.lbl_state.TabIndex = 0;
			this.lbl_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// img_Button
			// 
			this.img_Button.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Button.ImageSize = new System.Drawing.Size(80, 23);
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			this.img_Button.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// Pop_ProcessWait
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(360, 233);
			this.Controls.Add(this.lbl_state);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Pop_ProcessWait";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wait..";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_BS_Shipping_Wait_Closing);
			this.ResumeLayout(false);

		}
		#endregion

		public string Message
		{
			set
			{
				lbl_state.Text = value;
			}
		}

		public void Start()
		{
			timer.Start();
			Processing();
			this.ShowDialog();
		}

		public void Stop()
		{
			this.Close();
		}

		public void Loading()
		{
			lbl_state.Text = "Loading...";
		}

		public void Processing()
		{
			lbl_state.Text = "Processing...";
		}

		public void Complete()
		{
			lbl_state.Text = "Complete...";
		}

		public void Saveing()
		{
			lbl_state.Text = "Saving...";
		}

		private void timer_Tick(object sender, System.EventArgs e)
		{
			lbl_state.Visible = _flag = !_flag;
		}

		private void Pop_BS_Shipping_Wait_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			timer.Stop();
			this.Dispose(true);
		}
	}
}
