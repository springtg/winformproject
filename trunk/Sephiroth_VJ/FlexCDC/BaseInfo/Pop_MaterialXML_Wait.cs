using System;
using System.Threading;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FlexCDC.BaseInfo
{
	/// <summary>
	/// Pop_MaterialXML_Wait에 대한 요약 설명입니다.
	/// </summary>
	public class Pop_BS_Shipping_List_Wait : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Timer timer;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label lbl_state;
		private bool _flag = true;
		public System.Windows.Forms.ImageList img_Button;

        public Pop_BS_Shipping_List_Wait()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BS_Shipping_List_Wait));
            this.lbl_state = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.img_Button = new System.Windows.Forms.ImageList(this.components);
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
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // Pop_BS_Shipping_List_Wait
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(360, 233);
            this.Controls.Add(this.lbl_state);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pop_BS_Shipping_List_Wait";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wait..";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_BS_Shipping_Wait_Closing);
            this.ResumeLayout(false);

		}
		#endregion

		public void Start()
		{
			this.timer.Start();
			Processing();
			this.ShowDialog();
		}        

        #region only use VJ

        public void Searching_Start()
        {
            this.timer.Start();
            Searching();
        }

        public void Searching()
        {
            lbl_state.Text = "Searching Data in Korea Database";
        }

        #endregion

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
			//lbl_state.Visible = _flag = !_flag;
		}

		private void Pop_BS_Shipping_Wait_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			timer.Stop();
			this.Dispose(true);
		}

        
	}
}
