namespace FlexEIS.EIS.Common
{
    partial class Pop_ItemGroupSearchAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_ItemGroupSearchAll));
            this.fgrid_Main = new COM.FSP();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,0,Columns:";
            this.fgrid_Main.Location = new System.Drawing.Point(7, 40);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Rows.DefaultSize = 18;
            this.fgrid_Main.Size = new System.Drawing.Size(380, 325);
            this.fgrid_Main.TabIndex = 27;
            this.fgrid_Main.DoubleClick += new System.EventHandler(this.fgrid_Main_DoubleClick);
            // 
            // Pop_ItemGroupSearchAll
            // 
            this.ClientSize = new System.Drawing.Size(392, 373);
            this.Controls.Add(this.fgrid_Main);
            this.Name = "Pop_ItemGroupSearchAll";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pop_ItemGroupSearchAll_FormClosing);
            this.Controls.SetChildIndex(this.fgrid_Main, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private COM.FSP fgrid_Main;
    }
}
