namespace FlexCDC.Analisys
{
    partial class Pop_CheckUser_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_CheckUser_List));
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_grid = new System.Windows.Forms.Panel();
            this.fgrid_main = new COM.FSP();
            this.pnl_buttom = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Label();
            this.pnl_main.SuspendLayout();
            this.pnl_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_buttom.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_main.Controls.Add(this.pnl_grid);
            this.pnl_main.Controls.Add(this.pnl_buttom);
            this.pnl_main.Location = new System.Drawing.Point(0, 51);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(695, 417);
            this.pnl_main.TabIndex = 26;
            // 
            // pnl_grid
            // 
            this.pnl_grid.Controls.Add(this.fgrid_main);
            this.pnl_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_grid.Location = new System.Drawing.Point(0, 0);
            this.pnl_grid.Name = "pnl_grid";
            this.pnl_grid.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.pnl_grid.Size = new System.Drawing.Size(695, 384);
            this.pnl_grid.TabIndex = 28;
            // 
            // fgrid_main
            // 
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            this.fgrid_main.Location = new System.Drawing.Point(8, 4);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Rows.DefaultSize = 18;
            this.fgrid_main.Size = new System.Drawing.Size(679, 376);
            this.fgrid_main.TabIndex = 24;
            // 
            // pnl_buttom
            // 
            this.pnl_buttom.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_buttom.Controls.Add(this.btn_cancel);
            this.pnl_buttom.Controls.Add(this.btn_print);
            this.pnl_buttom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_buttom.Location = new System.Drawing.Point(0, 384);
            this.pnl_buttom.Name = "pnl_buttom";
            this.pnl_buttom.Size = new System.Drawing.Size(695, 33);
            this.pnl_buttom.TabIndex = 27;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel.Font = new System.Drawing.Font("굴림", 8F);
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(622, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(71, 23);
            this.btn_cancel.TabIndex = 357;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_print.Font = new System.Drawing.Font("굴림", 8F);
            this.btn_print.ImageIndex = 0;
            this.btn_print.ImageList = this.img_Button;
            this.btn_print.Location = new System.Drawing.Point(547, 5);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(71, 23);
            this.btn_print.TabIndex = 356;
            this.btn_print.Text = "Print List";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // Pop_CheckUser_List
            // 
            this.ClientSize = new System.Drawing.Size(695, 468);
            this.Controls.Add(this.pnl_main);
            this.Name = "Pop_CheckUser_List";
            this.Load += new System.EventHandler(this.Pop_CheckUser_List_Load);
            this.Controls.SetChildIndex(this.pnl_main, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.pnl_main.ResumeLayout(false);
            this.pnl_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.pnl_buttom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel pnl_grid;
        private System.Windows.Forms.Panel pnl_buttom;
        private COM.FSP fgrid_main;
        private System.Windows.Forms.Label btn_print;
        private System.Windows.Forms.Label btn_cancel;
    }
}
