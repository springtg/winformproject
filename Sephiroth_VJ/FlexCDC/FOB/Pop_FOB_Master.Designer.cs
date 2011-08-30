namespace FlexCDC.FOB
{
    partial class Pop_FOB_Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_FOB_Master));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            this.btn_save = new System.Windows.Forms.Label();
            this.cmb_Style = new C1.Win.C1List.C1Combo();
            this.txt_Style = new System.Windows.Forms.TextBox();
            this.lbl_style = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.lbl_obs_id = new System.Windows.Forms.Label();
            this.txt_obs_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
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
            // btn_save
            // 
            this.btn_save.ImageIndex = 0;
            this.btn_save.ImageList = this.img_Button;
            this.btn_save.Location = new System.Drawing.Point(191, 115);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(70, 23);
            this.btn_save.TabIndex = 360;
            this.btn_save.Text = "Apply";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cmb_Style
            // 
            this.cmb_Style.AddItemSeparator = ';';
            this.cmb_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Style.Caption = "";
            this.cmb_Style.CaptionHeight = 17;
            this.cmb_Style.CaptionStyle = style1;
            this.cmb_Style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Style.ColumnCaptionHeight = 18;
            this.cmb_Style.ColumnFooterHeight = 18;
            this.cmb_Style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Style.ContentHeight = 17;
            this.cmb_Style.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Style.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Style.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Style.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Style.EditorHeight = 17;
            this.cmb_Style.EvenRowStyle = style2;
            this.cmb_Style.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Style.FooterStyle = style3;
            this.cmb_Style.HeadingStyle = style4;
            this.cmb_Style.HighLightRowStyle = style5;
            //this.cmb_Style.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Style.Images"))));
            this.cmb_Style.ItemHeight = 15;
            this.cmb_Style.Location = new System.Drawing.Point(193, 91);
            this.cmb_Style.MatchEntryTimeout = ((long)(2000));
            this.cmb_Style.MaxDropDownItems = ((short)(5));
            this.cmb_Style.MaxLength = 32767;
            this.cmb_Style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Style.Name = "cmb_Style";
            this.cmb_Style.OddRowStyle = style6;
            this.cmb_Style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Style.SelectedStyle = style7;
            this.cmb_Style.Size = new System.Drawing.Size(138, 21);
            this.cmb_Style.Style = style8;
            this.cmb_Style.TabIndex = 364;
            this.cmb_Style.SelectedValueChanged += new System.EventHandler(this.cmb_style_SelectedValueChanged);
            this.cmb_Style.PropBag = resources.GetString("cmb_Style.PropBag");
            // 
            // txt_Style
            // 
            this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Style.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Style.Location = new System.Drawing.Point(113, 91);
            this.txt_Style.MaxLength = 20;
            this.txt_Style.Name = "txt_Style";
            this.txt_Style.Size = new System.Drawing.Size(79, 21);
            this.txt_Style.TabIndex = 363;
            this.txt_Style.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_style_KeyUp);
            // 
            // lbl_style
            // 
            this.lbl_style.ImageIndex = 0;
            this.lbl_style.ImageList = this.img_Label;
            this.lbl_style.Location = new System.Drawing.Point(13, 90);
            this.lbl_style.Name = "lbl_style";
            this.lbl_style.Size = new System.Drawing.Size(100, 21);
            this.lbl_style.TabIndex = 362;
            this.lbl_style.Text = "Style";
            this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_close
            // 
            this.btn_close.ImageIndex = 0;
            this.btn_close.ImageList = this.img_Button;
            this.btn_close.Location = new System.Drawing.Point(262, 115);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(70, 23);
            this.btn_close.TabIndex = 361;
            this.btn_close.Text = "Cancel";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style9;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 17;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 17;
            this.cmb_Factory.EvenRowStyle = style10;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style11;
            this.cmb_Factory.HeadingStyle = style12;
            this.cmb_Factory.HighLightRowStyle = style13;
            //this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(113, 46);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style14;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style15;
            this.cmb_Factory.Size = new System.Drawing.Size(218, 21);
            this.cmb_Factory.Style = style16;
            this.cmb_Factory.TabIndex = 366;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Factory.ImageIndex = 0;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(12, 46);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 365;
            this.lbl_Factory.Tag = "0";
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_obs_id
            // 
            this.lbl_obs_id.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obs_id.ImageIndex = 0;
            this.lbl_obs_id.ImageList = this.img_Label;
            this.lbl_obs_id.Location = new System.Drawing.Point(12, 68);
            this.lbl_obs_id.Name = "lbl_obs_id";
            this.lbl_obs_id.Size = new System.Drawing.Size(100, 21);
            this.lbl_obs_id.TabIndex = 367;
            this.lbl_obs_id.Tag = "0";
            this.lbl_obs_id.Text = "DPO";
            this.lbl_obs_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_obs_id
            // 
            this.txt_obs_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_obs_id.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_obs_id.Location = new System.Drawing.Point(113, 68);
            this.txt_obs_id.MaxLength = 20;
            this.txt_obs_id.Name = "txt_obs_id";
            this.txt_obs_id.Size = new System.Drawing.Size(218, 21);
            this.txt_obs_id.TabIndex = 368;
            // 
            // Pop_FOB_Master
            // 
            this.ClientSize = new System.Drawing.Size(341, 144);
            this.Controls.Add(this.txt_obs_id);
            this.Controls.Add(this.lbl_obs_id);
            this.Controls.Add(this.cmb_Factory);
            this.Controls.Add(this.lbl_Factory);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cmb_Style);
            this.Controls.Add(this.txt_Style);
            this.Controls.Add(this.lbl_style);
            this.Controls.Add(this.btn_close);
            this.Name = "Pop_FOB_Master";
            this.Load += new System.EventHandler(this.Pop_FOB_Master_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.btn_close, 0);
            this.Controls.SetChildIndex(this.lbl_style, 0);
            this.Controls.SetChildIndex(this.txt_Style, 0);
            this.Controls.SetChildIndex(this.cmb_Style, 0);
            this.Controls.SetChildIndex(this.btn_save, 0);
            this.Controls.SetChildIndex(this.lbl_Factory, 0);
            this.Controls.SetChildIndex(this.cmb_Factory, 0);
            this.Controls.SetChildIndex(this.lbl_obs_id, 0);
            this.Controls.SetChildIndex(this.txt_obs_id, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btn_save;
        private C1.Win.C1List.C1Combo cmb_Style;
        private System.Windows.Forms.TextBox txt_Style;
        private System.Windows.Forms.Label lbl_style;
        private System.Windows.Forms.Label btn_close;
        private C1.Win.C1List.C1Combo cmb_Factory;
        private System.Windows.Forms.Label lbl_Factory;
        private System.Windows.Forms.Label lbl_obs_id;
        private System.Windows.Forms.TextBox txt_obs_id;
    }
}
