namespace FlexEIS.EIS.Report
{
    partial class Form_RdViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RdViewer));
            this.axRdviewer401 = new AxRDVIEWER40Lib.AxRdviewer40();
            ((System.ComponentModel.ISupportInitialize)(this.axRdviewer401)).BeginInit();
            this.SuspendLayout();
            // 
            // axRdviewer401
            // 
            this.axRdviewer401.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axRdviewer401.Enabled = true;
            this.axRdviewer401.Location = new System.Drawing.Point(0, 0);
            this.axRdviewer401.Name = "axRdviewer401";
            this.axRdviewer401.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axRdviewer401.OcxState")));
            this.axRdviewer401.Size = new System.Drawing.Size(1016, 666);
            this.axRdviewer401.TabIndex = 0;
            // 
            // Form_RdViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.axRdviewer401);
            this.Name = "Form_RdViewer";
            this.Text = "Form_RdViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_RdViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axRdviewer401)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxRDVIEWER40Lib.AxRdviewer40 axRdviewer401;
    }
}