namespace FlexEIS.EIS.Production
{
    partial class Pop_Production_Daily_Report_Style
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Production_Daily_Report_Style));
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
            this.cmb_model = new C1.Win.C1List.C1Combo();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.lbl_model = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Label();
            this.lbl_obsType = new System.Windows.Forms.Label();
            this.cmb_obsType = new C1.Win.C1List.C1Combo();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsType)).BeginInit();
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
            // cmb_model
            // 
            this.cmb_model.AddItemSeparator = ';';
            this.cmb_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_model.Caption = "";
            this.cmb_model.CaptionHeight = 17;
            this.cmb_model.CaptionStyle = style1;
            this.cmb_model.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_model.ColumnCaptionHeight = 18;
            this.cmb_model.ColumnFooterHeight = 18;
            this.cmb_model.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_model.ContentHeight = 17;
            this.cmb_model.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_model.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_model.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_model.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_model.EditorHeight = 17;
            this.cmb_model.EvenRowStyle = style2;
            this.cmb_model.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_model.FooterStyle = style3;
            this.cmb_model.HeadingStyle = style4;
            this.cmb_model.HighLightRowStyle = style5;
            this.cmb_model.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_model.Images"))));
            this.cmb_model.ItemHeight = 15;
            this.cmb_model.Location = new System.Drawing.Point(109, 58);
            this.cmb_model.MatchEntryTimeout = ((long)(2000));
            this.cmb_model.MaxDropDownItems = ((short)(5));
            this.cmb_model.MaxLength = 32767;
            this.cmb_model.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_model.Name = "cmb_model";
            this.cmb_model.OddRowStyle = style6;
            this.cmb_model.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_model.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_model.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_model.SelectedStyle = style7;
            this.cmb_model.Size = new System.Drawing.Size(220, 21);
            this.cmb_model.Style = style8;
            this.cmb_model.TabIndex = 359;
            this.cmb_model.SelectedValueChanged += new System.EventHandler(this.cmb_model_SelectedValueChanged);
            this.cmb_model.PropBag = resources.GetString("cmb_model.PropBag");
            // 
            // txt_model
            // 
            this.txt_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_model.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_model.Location = new System.Drawing.Point(109, 36);
            this.txt_model.MaxLength = 20;
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(220, 21);
            this.txt_model.TabIndex = 358;
            this.txt_model.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_model_KeyUp);
            // 
            // lbl_model
            // 
            this.lbl_model.ImageIndex = 0;
            this.lbl_model.ImageList = this.img_Label;
            this.lbl_model.Location = new System.Drawing.Point(8, 36);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(100, 21);
            this.lbl_model.TabIndex = 357;
            this.lbl_model.Text = "Model search";
            this.lbl_model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_close
            // 
            this.btn_close.ImageIndex = 0;
            this.btn_close.ImageList = this.img_Button;
            this.btn_close.Location = new System.Drawing.Point(259, 102);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(70, 23);
            this.btn_close.TabIndex = 356;
            this.btn_close.Text = "Cancel";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.ImageIndex = 0;
            this.btn_save.ImageList = this.img_Button;
            this.btn_save.Location = new System.Drawing.Point(188, 102);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(70, 23);
            this.btn_save.TabIndex = 355;
            this.btn_save.Text = "Apply";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // lbl_obsType
            // 
            this.lbl_obsType.ImageIndex = 0;
            this.lbl_obsType.ImageList = this.img_Label;
            this.lbl_obsType.Location = new System.Drawing.Point(8, 80);
            this.lbl_obsType.Name = "lbl_obsType";
            this.lbl_obsType.Size = new System.Drawing.Size(100, 21);
            this.lbl_obsType.TabIndex = 361;
            this.lbl_obsType.Text = "Type";
            this.lbl_obsType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_obsType
            // 
            this.cmb_obsType.AddItemSeparator = ';';
            this.cmb_obsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_obsType.Caption = "";
            this.cmb_obsType.CaptionHeight = 17;
            this.cmb_obsType.CaptionStyle = style9;
            this.cmb_obsType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_obsType.ColumnCaptionHeight = 18;
            this.cmb_obsType.ColumnFooterHeight = 18;
            this.cmb_obsType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_obsType.ContentHeight = 17;
            this.cmb_obsType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_obsType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_obsType.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_obsType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_obsType.EditorHeight = 17;
            this.cmb_obsType.EvenRowStyle = style10;
            this.cmb_obsType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_obsType.FooterStyle = style11;
            this.cmb_obsType.HeadingStyle = style12;
            this.cmb_obsType.HighLightRowStyle = style13;
            this.cmb_obsType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_obsType.Images"))));
            this.cmb_obsType.ItemHeight = 15;
            this.cmb_obsType.Location = new System.Drawing.Point(109, 80);
            this.cmb_obsType.MatchEntryTimeout = ((long)(2000));
            this.cmb_obsType.MaxDropDownItems = ((short)(5));
            this.cmb_obsType.MaxLength = 32767;
            this.cmb_obsType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_obsType.Name = "cmb_obsType";
            this.cmb_obsType.OddRowStyle = style14;
            this.cmb_obsType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_obsType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_obsType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_obsType.SelectedStyle = style15;
            this.cmb_obsType.Size = new System.Drawing.Size(220, 21);
            this.cmb_obsType.Style = style16;
            this.cmb_obsType.TabIndex = 362;
            this.cmb_obsType.PropBag = resources.GetString("cmb_obsType.PropBag");
            // 
            // label1
            // 
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 363;
            this.label1.Text = "Model select";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pop_Production_Daily_Report_Style
            // 
            this.ClientSize = new System.Drawing.Size(341, 136);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_obsType);
            this.Controls.Add(this.lbl_obsType);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cmb_model);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.btn_close);
            this.Name = "Pop_Production_Daily_Report_Style";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pop_Production_Daily_Report_Style_FormClosing);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.btn_close, 0);
            this.Controls.SetChildIndex(this.lbl_model, 0);
            this.Controls.SetChildIndex(this.txt_model, 0);
            this.Controls.SetChildIndex(this.cmb_model, 0);
            this.Controls.SetChildIndex(this.btn_save, 0);
            this.Controls.SetChildIndex(this.lbl_obsType, 0);
            this.Controls.SetChildIndex(this.cmb_obsType, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1List.C1Combo cmb_model;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label btn_close;
        private System.Windows.Forms.Label btn_save;
        private System.Windows.Forms.Label lbl_obsType;
        private C1.Win.C1List.C1Combo cmb_obsType;
        private System.Windows.Forms.Label label1;
    }
}
