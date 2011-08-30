namespace FlexCosting.Basic.Pop
{
    partial class Pop_Type_And_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Type_And_Search));
            this.fgrid_main = new COM.FSP();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.SuspendLayout();
            // 
            // fgrid_main
            // 
            this.fgrid_main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_main.Font = new System.Drawing.Font("굴림", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fgrid_main.Location = new System.Drawing.Point(0, 0);
            this.fgrid_main.Margin = new System.Windows.Forms.Padding(0);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Rows.DefaultSize = 18;
            this.fgrid_main.ScrollOptions = ((C1.Win.C1FlexGrid.ScrollFlags)((C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible | C1.Win.C1FlexGrid.ScrollFlags.ScrollByRowColumn)));
            this.fgrid_main.Size = new System.Drawing.Size(192, 373);
            this.fgrid_main.StyleInfo = resources.GetString("fgrid_main.StyleInfo");
            this.fgrid_main.TabIndex = 0;
            this.fgrid_main.DoubleClick += new System.EventHandler(this.fgrid_main_DoubleClick);
            this.fgrid_main.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fgrid_main_KeyUp);
            // 
            // Pop_Type_And_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 373);
            this.Controls.Add(this.fgrid_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pop_Type_And_Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private COM.FSP fgrid_main;
    }
}