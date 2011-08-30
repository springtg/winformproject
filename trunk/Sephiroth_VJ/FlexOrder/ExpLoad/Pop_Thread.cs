using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FlexOrder.ExpLoad
{
	public class Pop_Thread : COM.OrderWinForm.Pop_Small
	{
		#region 컨트롤정의 및 리소스 정의

		private System.Windows.Forms.Panel pnl_progress;
		private System.Windows.Forms.Label lbl_m;
		private System.Windows.Forms.Label lbl_u;
		private System.Windows.Forms.Label lbl_s;
		private System.Windows.Forms.Label lbl_state;
		private System.Windows.Forms.Timer timer;
		private System.ComponentModel.IContainer components = null;

		public Pop_Thread()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Thread));
			this.pnl_progress = new System.Windows.Forms.Panel();
			this.lbl_m = new System.Windows.Forms.Label();
			this.lbl_u = new System.Windows.Forms.Label();
			this.lbl_s = new System.Windows.Forms.Label();
			this.lbl_state = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.pnl_progress.SuspendLayout();
			this.SuspendLayout();
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// pnl_progress
			// 
			this.pnl_progress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_progress.BackgroundImage")));
			this.pnl_progress.Controls.Add(this.lbl_m);
			this.pnl_progress.Controls.Add(this.lbl_u);
			this.pnl_progress.Controls.Add(this.lbl_s);
			this.pnl_progress.Controls.Add(this.lbl_state);
			this.pnl_progress.Location = new System.Drawing.Point(0, 0);
			this.pnl_progress.Name = "pnl_progress";
			this.pnl_progress.Size = new System.Drawing.Size(368, 175);
			this.pnl_progress.TabIndex = 47;
			// 
			// lbl_m
			// 
			this.lbl_m.BackColor = System.Drawing.Color.Transparent;
			this.lbl_m.Location = new System.Drawing.Point(144, 126);
			this.lbl_m.Name = "lbl_m";
			this.lbl_m.Size = new System.Drawing.Size(208, 14);
			this.lbl_m.TabIndex = 33;
			// 
			// lbl_u
			// 
			this.lbl_u.BackColor = System.Drawing.Color.Transparent;
			this.lbl_u.Location = new System.Drawing.Point(144, 108);
			this.lbl_u.Name = "lbl_u";
			this.lbl_u.Size = new System.Drawing.Size(208, 14);
			this.lbl_u.TabIndex = 32;
			// 
			// lbl_s
			// 
			this.lbl_s.BackColor = System.Drawing.Color.Transparent;
			this.lbl_s.Location = new System.Drawing.Point(144, 88);
			this.lbl_s.Name = "lbl_s";
			this.lbl_s.Size = new System.Drawing.Size(216, 14);
			this.lbl_s.TabIndex = 31;
			// 
			// lbl_state
			// 
			this.lbl_state.BackColor = System.Drawing.Color.Transparent;
			this.lbl_state.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_state.ForeColor = System.Drawing.Color.Red;
			this.lbl_state.Location = new System.Drawing.Point(32, 64);
			this.lbl_state.Name = "lbl_state";
			this.lbl_state.Size = new System.Drawing.Size(136, 14);
			this.lbl_state.TabIndex = 17;
			this.lbl_state.Text = "Upload Status...";
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// Pop_Thread
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(362, 175);
			this.Controls.Add(this.pnl_progress);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Pop_Thread";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_Thread_Closing);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.pnl_progress, 0);
			this.pnl_progress.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의


		private bool _flag = true;
		private string _msg = "Processing...";


		#endregion

		#region 멤버 메서드


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


		#endregion


		private void Pop_Thread_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			timer.Stop();
			this.Dispose(true);
		}

		private void timer_Tick(object sender, System.EventArgs e)
		{
			lbl_state.Visible = _flag = !_flag;
		}
	}
}

