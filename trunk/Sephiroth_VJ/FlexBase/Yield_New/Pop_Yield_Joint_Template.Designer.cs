namespace FlexBase.Yield_New
{
    partial class Pop_Yield_Joint_Template
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Yield_Joint_Template));
            this.panel_Body = new System.Windows.Forms.Panel();
            this.fgrid_Main = new COM.FSP();
            this.groupBox_Item = new System.Windows.Forms.GroupBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.chk_Favorite = new System.Windows.Forms.CheckBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.panel_Button = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
            this.groupBox_Item.SuspendLayout();
            this.panel_Button.SuspendLayout();
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
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Location = new System.Drawing.Point(35, 7);
            this.lbl_MainTitle.Size = new System.Drawing.Size(460, 21);
            this.lbl_MainTitle.Text = "Select Joint Template";
            // 
            // panel_Body
            // 
            this.panel_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Body.Controls.Add(this.fgrid_Main);
            this.panel_Body.Controls.Add(this.groupBox_Item);
            this.panel_Body.Controls.Add(this.panel_Button);
            this.panel_Body.Location = new System.Drawing.Point(0, 32);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(393, 443);
            this.panel_Body.TabIndex = 27;
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Main.Location = new System.Drawing.Point(0, 43);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Rows.DefaultSize = 17;
            this.fgrid_Main.Size = new System.Drawing.Size(393, 370);
            this.fgrid_Main.StyleInfo = resources.GetString("fgrid_Main.StyleInfo");
            this.fgrid_Main.TabIndex = 676;
            this.fgrid_Main.DoubleClick += new System.EventHandler(this.fgrid_DoubleClick);
            // 
            // groupBox_Item
            // 
            this.groupBox_Item.BackColor = System.Drawing.Color.White;
            this.groupBox_Item.Controls.Add(this.lbl_Name);
            this.groupBox_Item.Controls.Add(this.chk_Favorite);
            this.groupBox_Item.Controls.Add(this.txt_Name);
            this.groupBox_Item.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Item.Font = new System.Drawing.Font("Verdana", 8F);
            this.groupBox_Item.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Item.Name = "groupBox_Item";
            this.groupBox_Item.Size = new System.Drawing.Size(393, 43);
            this.groupBox_Item.TabIndex = 675;
            this.groupBox_Item.TabStop = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_Name.ImageIndex = 0;
            this.lbl_Name.ImageList = this.img_Label;
            this.lbl_Name.Location = new System.Drawing.Point(7, 15);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(88, 19);
            this.lbl_Name.TabIndex = 667;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chk_Favorite
            // 
            this.chk_Favorite.BackColor = System.Drawing.SystemColors.Window;
            this.chk_Favorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_Favorite.Font = new System.Drawing.Font("Verdana", 8F);
            this.chk_Favorite.Location = new System.Drawing.Point(321, 15);
            this.chk_Favorite.Name = "chk_Favorite";
            this.chk_Favorite.Size = new System.Drawing.Size(70, 19);
            this.chk_Favorite.TabIndex = 666;
            this.chk_Favorite.Text = "Favorite";
            this.chk_Favorite.UseVisualStyleBackColor = false;
            this.chk_Favorite.CheckedChanged += new System.EventHandler(this.chk_Favorite_CheckedChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.White;
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Name.Location = new System.Drawing.Point(96, 15);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(219, 19);
            this.txt_Name.TabIndex = 664;
            this.txt_Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Name_KeyUp);
            // 
            // panel_Button
            // 
            this.panel_Button.Controls.Add(this.btn_Cancel);
            this.panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Button.Location = new System.Drawing.Point(0, 413);
            this.panel_Button.Name = "panel_Button";
            this.panel_Button.Size = new System.Drawing.Size(393, 30);
            this.panel_Button.TabIndex = 2;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 8F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.Location = new System.Drawing.Point(320, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 21);
            this.btn_Cancel.TabIndex = 677;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Pop_Yield_Joint_Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 472);
            this.Controls.Add(this.panel_Body);
            this.Font = new System.Drawing.Font("Verdana", 8F);
            this.Name = "Pop_Yield_Joint_Template";
            this.Text = "Select Joint Template";
            this.Controls.SetChildIndex(this.panel_Body, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.groupBox_Item.ResumeLayout(false);
            this.groupBox_Item.PerformLayout();
            this.panel_Button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Panel panel_Button;
        private System.Windows.Forms.Button btn_Cancel;
        public System.Windows.Forms.CheckBox chk_Favorite;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.GroupBox groupBox_Item;
        private System.Windows.Forms.Label lbl_Name;
        private COM.FSP fgrid_Main;

    }
}