namespace FlexBase.Yield_New
{
    partial class Pop_Yield_Input_Value
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Yield_Input_Value));
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.groupBox_Value = new System.Windows.Forms.GroupBox();
            this.btn_SearchSpec = new System.Windows.Forms.Label();
            this.img_SmallButton = new System.Windows.Forms.ImageList(this.components);
            this.txt_SpecName = new System.Windows.Forms.TextBox();
            this.cmb_Spec = new C1.Win.C1List.C1Combo();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SizeT = new System.Windows.Forms.TextBox();
            this.txt_YieldValue = new System.Windows.Forms.TextBox();
            this.txt_SizeF = new System.Windows.Forms.TextBox();
            this.lbl_Value = new System.Windows.Forms.Label();
            this.lbl_Spec = new System.Windows.Forms.Label();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.cmb_SpecDiv = new C1.Win.C1List.C1Combo();
            this.groupBox_Value.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Spec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SpecDiv)).BeginInit();
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
            this.lbl_MainTitle.Size = new System.Drawing.Size(429, 23);
            this.lbl_MainTitle.Text = "Yield Value";
            // 
            // groupBox_Value
            // 
            this.groupBox_Value.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Value.Controls.Add(this.cmb_SpecDiv);
            this.groupBox_Value.Controls.Add(this.btn_SearchSpec);
            this.groupBox_Value.Controls.Add(this.txt_SpecName);
            this.groupBox_Value.Controls.Add(this.cmb_Spec);
            this.groupBox_Value.Controls.Add(this.label1);
            this.groupBox_Value.Controls.Add(this.txt_SizeT);
            this.groupBox_Value.Controls.Add(this.txt_YieldValue);
            this.groupBox_Value.Controls.Add(this.txt_SizeF);
            this.groupBox_Value.Controls.Add(this.lbl_Value);
            this.groupBox_Value.Controls.Add(this.lbl_Spec);
            this.groupBox_Value.Controls.Add(this.lbl_Size);
            this.groupBox_Value.Location = new System.Drawing.Point(3, 34);
            this.groupBox_Value.Name = "groupBox_Value";
            this.groupBox_Value.Size = new System.Drawing.Size(385, 103);
            this.groupBox_Value.TabIndex = 29;
            this.groupBox_Value.TabStop = false;
            // 
            // btn_SearchSpec
            // 
            this.btn_SearchSpec.ImageIndex = 6;
            this.btn_SearchSpec.ImageList = this.img_SmallButton;
            this.btn_SearchSpec.Location = new System.Drawing.Point(356, 75);
            this.btn_SearchSpec.Name = "btn_SearchSpec";
            this.btn_SearchSpec.Size = new System.Drawing.Size(21, 21);
            this.btn_SearchSpec.TabIndex = 682;
            this.btn_SearchSpec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SearchSpec.Click += new System.EventHandler(this.btn_SearchSpec_Click);
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            this.img_SmallButton.Images.SetKeyName(2, "");
            this.img_SmallButton.Images.SetKeyName(3, "");
            this.img_SmallButton.Images.SetKeyName(4, "");
            this.img_SmallButton.Images.SetKeyName(5, "");
            this.img_SmallButton.Images.SetKeyName(6, "");
            this.img_SmallButton.Images.SetKeyName(7, "");
            this.img_SmallButton.Images.SetKeyName(8, "");
            this.img_SmallButton.Images.SetKeyName(9, "");
            // 
            // txt_SpecName
            // 
            this.txt_SpecName.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SpecName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SpecName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_SpecName.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_SpecName.Location = new System.Drawing.Point(108, 76);
            this.txt_SpecName.MaxLength = 18;
            this.txt_SpecName.Name = "txt_SpecName";
            this.txt_SpecName.Size = new System.Drawing.Size(123, 19);
            this.txt_SpecName.TabIndex = 549;
            this.txt_SpecName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SpecName_KeyUp);
            // 
            // cmb_Spec
            // 
            this.cmb_Spec.AddItemSeparator = ';';
            this.cmb_Spec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Spec.Caption = "";
            this.cmb_Spec.CaptionHeight = 17;
            this.cmb_Spec.CaptionStyle = style9;
            this.cmb_Spec.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Spec.ColumnCaptionHeight = 18;
            this.cmb_Spec.ColumnFooterHeight = 18;
            this.cmb_Spec.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Spec.ContentHeight = 15;
            this.cmb_Spec.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Spec.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Spec.EditorFont = new System.Drawing.Font("Verdana", 8F);
            this.cmb_Spec.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Spec.EditorHeight = 15;
            this.cmb_Spec.EvenRowStyle = style10;
            this.cmb_Spec.Font = new System.Drawing.Font("Verdana", 8F);
            this.cmb_Spec.FooterStyle = style11;
            this.cmb_Spec.HeadingStyle = style12;
            this.cmb_Spec.HighLightRowStyle = style13;
            this.cmb_Spec.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Spec.Images"))));
            this.cmb_Spec.ItemHeight = 15;
            this.cmb_Spec.Location = new System.Drawing.Point(232, 76);
            this.cmb_Spec.MatchEntryTimeout = ((long)(2000));
            this.cmb_Spec.MaxDropDownItems = ((short)(5));
            this.cmb_Spec.MaxLength = 32767;
            this.cmb_Spec.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Spec.Name = "cmb_Spec";
            this.cmb_Spec.OddRowStyle = style14;
            this.cmb_Spec.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Spec.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Spec.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Spec.SelectedStyle = style15;
            this.cmb_Spec.Size = new System.Drawing.Size(123, 19);
            this.cmb_Spec.Style = style16;
            this.cmb_Spec.TabIndex = 548;
            this.cmb_Spec.PropBag = resources.GetString("cmb_Spec.PropBag");
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(234, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 19);
            this.label1.TabIndex = 547;
            this.label1.Text = "~";
            // 
            // txt_SizeT
            // 
            this.txt_SizeT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SizeT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SizeT.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_SizeT.Location = new System.Drawing.Point(253, 16);
            this.txt_SizeT.MaxLength = 100;
            this.txt_SizeT.Name = "txt_SizeT";
            this.txt_SizeT.ReadOnly = true;
            this.txt_SizeT.Size = new System.Drawing.Size(123, 19);
            this.txt_SizeT.TabIndex = 546;
            this.txt_SizeT.TabStop = false;
            // 
            // txt_YieldValue
            // 
            this.txt_YieldValue.BackColor = System.Drawing.SystemColors.Window;
            this.txt_YieldValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_YieldValue.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_YieldValue.Location = new System.Drawing.Point(108, 36);
            this.txt_YieldValue.MaxLength = 18;
            this.txt_YieldValue.Name = "txt_YieldValue";
            this.txt_YieldValue.Size = new System.Drawing.Size(268, 19);
            this.txt_YieldValue.TabIndex = 2;
            this.txt_YieldValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_YieldValue_KeyUp);
            // 
            // txt_SizeF
            // 
            this.txt_SizeF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SizeF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SizeF.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_SizeF.Location = new System.Drawing.Point(108, 16);
            this.txt_SizeF.MaxLength = 100;
            this.txt_SizeF.Name = "txt_SizeF";
            this.txt_SizeF.ReadOnly = true;
            this.txt_SizeF.Size = new System.Drawing.Size(123, 19);
            this.txt_SizeF.TabIndex = 545;
            this.txt_SizeF.TabStop = false;
            // 
            // lbl_Value
            // 
            this.lbl_Value.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_Value.ImageIndex = 0;
            this.lbl_Value.ImageList = this.img_Label;
            this.lbl_Value.Location = new System.Drawing.Point(7, 36);
            this.lbl_Value.Name = "lbl_Value";
            this.lbl_Value.Size = new System.Drawing.Size(100, 21);
            this.lbl_Value.TabIndex = 542;
            this.lbl_Value.Text = "Value";
            this.lbl_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Spec
            // 
            this.lbl_Spec.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_Spec.ImageIndex = 0;
            this.lbl_Spec.ImageList = this.img_Label;
            this.lbl_Spec.Location = new System.Drawing.Point(7, 58);
            this.lbl_Spec.Name = "lbl_Spec";
            this.lbl_Spec.Size = new System.Drawing.Size(100, 21);
            this.lbl_Spec.TabIndex = 541;
            this.lbl_Spec.Text = "Spec";
            this.lbl_Spec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Size
            // 
            this.lbl_Size.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_Size.ImageIndex = 0;
            this.lbl_Size.ImageList = this.img_Label;
            this.lbl_Size.Location = new System.Drawing.Point(7, 14);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(100, 21);
            this.lbl_Size.TabIndex = 540;
            this.lbl_Size.Text = "Size";
            this.lbl_Size.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Apply
            // 
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apply.Font = new System.Drawing.Font("Verdana", 8F);
            this.btn_Apply.ImageIndex = 0;
            this.btn_Apply.Location = new System.Drawing.Point(246, 143);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(70, 21);
            this.btn_Apply.TabIndex = 681;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 8F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.Location = new System.Drawing.Point(318, 143);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 21);
            this.btn_Cancel.TabIndex = 680;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cmb_SpecDiv
            // 
            this.cmb_SpecDiv.AddItemSeparator = ';';
            this.cmb_SpecDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SpecDiv.Caption = "";
            this.cmb_SpecDiv.CaptionHeight = 17;
            this.cmb_SpecDiv.CaptionStyle = style1;
            this.cmb_SpecDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SpecDiv.ColumnCaptionHeight = 18;
            this.cmb_SpecDiv.ColumnFooterHeight = 18;
            this.cmb_SpecDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SpecDiv.ContentHeight = 15;
            this.cmb_SpecDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SpecDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SpecDiv.EditorFont = new System.Drawing.Font("Verdana", 8F);
            this.cmb_SpecDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SpecDiv.EditorHeight = 15;
            this.cmb_SpecDiv.EvenRowStyle = style2;
            this.cmb_SpecDiv.Font = new System.Drawing.Font("Verdana", 8F);
            this.cmb_SpecDiv.FooterStyle = style3;
            this.cmb_SpecDiv.HeadingStyle = style4;
            this.cmb_SpecDiv.HighLightRowStyle = style5;
            this.cmb_SpecDiv.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_SpecDiv.Images"))));
            this.cmb_SpecDiv.ItemHeight = 15;
            this.cmb_SpecDiv.Location = new System.Drawing.Point(108, 56);
            this.cmb_SpecDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_SpecDiv.MaxDropDownItems = ((short)(5));
            this.cmb_SpecDiv.MaxLength = 32767;
            this.cmb_SpecDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SpecDiv.Name = "cmb_SpecDiv";
            this.cmb_SpecDiv.OddRowStyle = style6;
            this.cmb_SpecDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SpecDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SpecDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SpecDiv.SelectedStyle = style7;
            this.cmb_SpecDiv.Size = new System.Drawing.Size(268, 19);
            this.cmb_SpecDiv.Style = style8;
            this.cmb_SpecDiv.TabIndex = 683;
            this.cmb_SpecDiv.SelectedValueChanged += new System.EventHandler(this.cmb_SpecDiv_SelectedValueChanged);
            this.cmb_SpecDiv.PropBag = resources.GetString("cmb_SpecDiv.PropBag");
            // 
            // Pop_Yield_Input_Value
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(394, 170);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.groupBox_Value);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.Name = "Pop_Yield_Input_Value";
            this.Text = "Yield Value";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pop_Input_Value_New_FormClosing);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.groupBox_Value, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.btn_Apply, 0);
            this.groupBox_Value.ResumeLayout(false);
            this.groupBox_Value.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Spec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SpecDiv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Value;
        private System.Windows.Forms.TextBox txt_YieldValue;
        private System.Windows.Forms.TextBox txt_SizeF;
        private System.Windows.Forms.Label lbl_Value;
        private System.Windows.Forms.Label lbl_Spec;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_SizeT;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1List.C1Combo cmb_Spec;
        private System.Windows.Forms.TextBox txt_SpecName;
        private System.Windows.Forms.Label btn_SearchSpec;
        public System.Windows.Forms.ImageList img_SmallButton;
        private C1.Win.C1List.C1Combo cmb_SpecDiv;
    }
}