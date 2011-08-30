namespace FlexCosting.Basic.Pop_00
{
    partial class Pop_Tooling_History
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
            this.fgrid_main = new COM.FSP();
            this.sizer_Main = new C1.Win.C1Sizer.C1Sizer();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizer_Main)).BeginInit();
            this.sizer_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // fgrid_main
            // 
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,0,Columns:";
            this.fgrid_main.Location = new System.Drawing.Point(0, 0);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Rows.DefaultSize = 18;
            this.fgrid_main.Size = new System.Drawing.Size(692, 466);
            this.fgrid_main.TabIndex = 1;
            // 
            // sizer_Main
            // 
            this.sizer_Main.BorderWidth = 0;
            this.sizer_Main.Controls.Add(this.fgrid_main);
            this.sizer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizer_Main.GridDefinition = "100:False:False;0:False:True;\t0:False:True;100:False:False;0:False:True;";
            this.sizer_Main.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sizer_Main.Location = new System.Drawing.Point(0, 0);
            this.sizer_Main.Name = "sizer_Main";
            this.sizer_Main.Size = new System.Drawing.Size(692, 466);
            this.sizer_Main.SplitterWidth = 0;
            this.sizer_Main.TabIndex = 32;
            this.sizer_Main.TabStop = false;
            // 
            // Pop_Tooling_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 466);
            this.Controls.Add(this.sizer_Main);
            this.Name = "Pop_Tooling_History";
            this.Text = "Pop_Tooling_History";
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizer_Main)).EndInit();
            this.sizer_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private COM.FSP fgrid_main;
        private C1.Win.C1Sizer.C1Sizer sizer_Main;
    }
}