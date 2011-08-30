namespace FlexCosting.Basic.Ctl
{
    partial class TextSearch
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextSearch));
            this.txt_schText = new System.Windows.Forms.TextBox();
            this.lbl_title2 = new System.Windows.Forms.Label();
            this.searchPanel1 = new FlexCosting.Basic.Ctl.SearchPanel();
            this.SuspendLayout();
            // 
            // txt_schText
            // 
            this.txt_schText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_schText.Location = new System.Drawing.Point(8, 36);
            this.txt_schText.Name = "txt_schText";
            this.txt_schText.Size = new System.Drawing.Size(283, 21);
            this.txt_schText.TabIndex = 0;
            this.txt_schText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_schText_KeyUp);
            // 
            // lbl_title2
            // 
            this.lbl_title2.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_title2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title2.ForeColor = System.Drawing.Color.Navy;
            this.lbl_title2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_title2.Image")));
            this.lbl_title2.Location = new System.Drawing.Point(0, 0);
            this.lbl_title2.Name = "lbl_title2";
            this.lbl_title2.Size = new System.Drawing.Size(231, 30);
            this.lbl_title2.TabIndex = 598;
            this.lbl_title2.Text = "      Search Condition";
            this.lbl_title2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchPanel1
            // 
            this.searchPanel1.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel1.Location = new System.Drawing.Point(0, 0);
            this.searchPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.searchPanel1.Name = "searchPanel1";
            this.searchPanel1.Size = new System.Drawing.Size(300, 70);
            this.searchPanel1.TabIndex = 599;
            // 
            // TextSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_title2);
            this.Controls.Add(this.txt_schText);
            this.Controls.Add(this.searchPanel1);
            this.Name = "TextSearch";
            this.Size = new System.Drawing.Size(300, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_schText;
        public System.Windows.Forms.Label lbl_title2;
        private SearchPanel searchPanel1;
    }
}
