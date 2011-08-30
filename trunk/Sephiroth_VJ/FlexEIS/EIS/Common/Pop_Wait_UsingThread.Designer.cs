namespace FlexEIS.EIS.Common
{
    partial class Pop_Wait_UsingThread
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_state = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbl_state
            // 
            this.lbl_state.BackColor = System.Drawing.Color.Transparent;
            this.lbl_state.ForeColor = System.Drawing.Color.Red;
            this.lbl_state.Location = new System.Drawing.Point(32, 160);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(296, 24);
            this.lbl_state.TabIndex = 1;
            this.lbl_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Pop_Wait_UsingThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlexEIS.Properties.Resources.about1_bg;
            this.ClientSize = new System.Drawing.Size(359, 231);
            this.Controls.Add(this.lbl_state);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pop_Wait_UsingThread";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wait..";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pop_Wait_UsingThread_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl_state;

    }
}