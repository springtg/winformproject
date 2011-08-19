namespace FlexBase.Yield_New
{
    partial class Pop_Yield_Status_Check
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Yield_Status_Check));
            C1.Win.C1List.Style style25 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style26 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style27 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style28 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style29 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style30 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style31 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style32 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style33 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style34 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style35 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style36 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style37 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style38 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style39 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style40 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style41 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style42 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style43 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style44 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style45 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style46 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style47 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style48 = new C1.Win.C1List.Style();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.fgrid_Main = new COM.FSP();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.groupBox_Select = new System.Windows.Forms.GroupBox();
            this.dpick_ToYMD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dpick_FromYMD = new System.Windows.Forms.DateTimePicker();
            this.cmb_YieldStatus = new C1.Win.C1List.C1Combo();
            this.lbl_StyleCd = new System.Windows.Forms.Label();
            this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
            this.lbl_YieldStatus = new System.Windows.Forms.Label();
            this.txt_StyleCd = new System.Windows.Forms.TextBox();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_JobDate = new System.Windows.Forms.Label();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.img_SmallButton = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.groupBox_Select.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_YieldStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
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
            // img_Menu
            // 
            this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
            this.img_Menu.Images.SetKeyName(0, "");
            this.img_Menu.Images.SetKeyName(1, "");
            this.img_Menu.Images.SetKeyName(2, "");
            this.img_Menu.Images.SetKeyName(3, "");
            this.img_Menu.Images.SetKeyName(4, "");
            this.img_Menu.Images.SetKeyName(5, "");
            this.img_Menu.Images.SetKeyName(6, "");
            this.img_Menu.Images.SetKeyName(7, "");
            this.img_Menu.Images.SetKeyName(8, "");
            // 
            // c1ToolBar1
            // 
            this.c1ToolBar1.AccessibleName = "Tool Bar";
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4,
            this.c1CommandLink5,
            this.c1CommandLink6,
            this.c1CommandLink7});
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.tbtn_New);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Search);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Save);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Append);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Insert);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Delete);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Create);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Color);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Print);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Conform);
            // 
            // tbtn_New
            // 
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(900, 23);
            this.lbl_MainTitle.Text = "Check Status";
            // 
            // panel_Body
            // 
            this.panel_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Body.Controls.Add(this.fgrid_Main);
            this.panel_Body.Controls.Add(this.panel_Top);
            this.panel_Body.Location = new System.Drawing.Point(0, 56);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(792, 510);
            this.panel_Body.TabIndex = 26;
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Main.Location = new System.Drawing.Point(0, 66);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Rows.DefaultSize = 19;
            this.fgrid_Main.Size = new System.Drawing.Size(792, 444);
            this.fgrid_Main.StyleInfo = resources.GetString("fgrid_Main.StyleInfo");
            this.fgrid_Main.TabIndex = 667;
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.groupBox_Select);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(792, 66);
            this.panel_Top.TabIndex = 4;
            // 
            // groupBox_Select
            // 
            this.groupBox_Select.Controls.Add(this.dpick_ToYMD);
            this.groupBox_Select.Controls.Add(this.label1);
            this.groupBox_Select.Controls.Add(this.dpick_FromYMD);
            this.groupBox_Select.Controls.Add(this.cmb_YieldStatus);
            this.groupBox_Select.Controls.Add(this.lbl_StyleCd);
            this.groupBox_Select.Controls.Add(this.cmb_StyleCd);
            this.groupBox_Select.Controls.Add(this.lbl_YieldStatus);
            this.groupBox_Select.Controls.Add(this.txt_StyleCd);
            this.groupBox_Select.Controls.Add(this.cmb_Factory);
            this.groupBox_Select.Controls.Add(this.lbl_JobDate);
            this.groupBox_Select.Controls.Add(this.lbl_Factory);
            this.groupBox_Select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Select.Font = new System.Drawing.Font("Verdana", 8F);
            this.groupBox_Select.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Select.Name = "groupBox_Select";
            this.groupBox_Select.Size = new System.Drawing.Size(792, 66);
            this.groupBox_Select.TabIndex = 1;
            this.groupBox_Select.TabStop = false;
            // 
            // dpick_ToYMD
            // 
            this.dpick_ToYMD.Font = new System.Drawing.Font("Verdana", 8F);
            this.dpick_ToYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_ToYMD.Location = new System.Drawing.Point(232, 37);
            this.dpick_ToYMD.Name = "dpick_ToYMD";
            this.dpick_ToYMD.Size = new System.Drawing.Size(103, 20);
            this.dpick_ToYMD.TabIndex = 1568;
            this.dpick_ToYMD.ValueChanged += new System.EventHandler(this.dpick_ToYMD_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(213, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 19);
            this.label1.TabIndex = 1567;
            this.label1.Text = "~";
            // 
            // dpick_FromYMD
            // 
            this.dpick_FromYMD.Font = new System.Drawing.Font("Verdana", 8F);
            this.dpick_FromYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_FromYMD.Location = new System.Drawing.Point(108, 37);
            this.dpick_FromYMD.Name = "dpick_FromYMD";
            this.dpick_FromYMD.Size = new System.Drawing.Size(103, 20);
            this.dpick_FromYMD.TabIndex = 1566;
            this.dpick_FromYMD.ValueChanged += new System.EventHandler(this.dpick_FromYMD_ValueChanged);
            // 
            // cmb_YieldStatus
            // 
            this.cmb_YieldStatus.AddItemSeparator = ';';
            this.cmb_YieldStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_YieldStatus.Caption = "";
            this.cmb_YieldStatus.CaptionHeight = 17;
            this.cmb_YieldStatus.CaptionStyle = style25;
            this.cmb_YieldStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_YieldStatus.ColumnCaptionHeight = 18;
            this.cmb_YieldStatus.ColumnFooterHeight = 18;
            this.cmb_YieldStatus.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_YieldStatus.ContentHeight = 15;
            this.cmb_YieldStatus.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_YieldStatus.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_YieldStatus.EditorFont = new System.Drawing.Font("Verdana", 8F);
            this.cmb_YieldStatus.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_YieldStatus.EditorHeight = 15;
            this.cmb_YieldStatus.EvenRowStyle = style26;
            this.cmb_YieldStatus.Font = new System.Drawing.Font("Verdana", 8F);
            this.cmb_YieldStatus.FooterStyle = style27;
            this.cmb_YieldStatus.HeadingStyle = style28;
            this.cmb_YieldStatus.HighLightRowStyle = style29;
            this.cmb_YieldStatus.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_YieldStatus.Images"))));
            this.cmb_YieldStatus.ItemHeight = 15;
            this.cmb_YieldStatus.Location = new System.Drawing.Point(454, 16);
            this.cmb_YieldStatus.MatchEntryTimeout = ((long)(2000));
            this.cmb_YieldStatus.MaxDropDownItems = ((short)(5));
            this.cmb_YieldStatus.MaxLength = 32767;
            this.cmb_YieldStatus.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_YieldStatus.Name = "cmb_YieldStatus";
            this.cmb_YieldStatus.OddRowStyle = style30;
            this.cmb_YieldStatus.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_YieldStatus.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_YieldStatus.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_YieldStatus.SelectedStyle = style31;
            this.cmb_YieldStatus.Size = new System.Drawing.Size(226, 19);
            this.cmb_YieldStatus.Style = style32;
            this.cmb_YieldStatus.TabIndex = 670;
            this.cmb_YieldStatus.SelectedValueChanged += new System.EventHandler(this.cmb_YieldStatus_SelectedValueChanged);
            this.cmb_YieldStatus.PropBag = resources.GetString("cmb_YieldStatus.PropBag");
            // 
            // lbl_StyleCd
            // 
            this.lbl_StyleCd.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_StyleCd.ImageIndex = 0;
            this.lbl_StyleCd.ImageList = this.img_Label;
            this.lbl_StyleCd.Location = new System.Drawing.Point(353, 36);
            this.lbl_StyleCd.Name = "lbl_StyleCd";
            this.lbl_StyleCd.Size = new System.Drawing.Size(100, 21);
            this.lbl_StyleCd.TabIndex = 1565;
            this.lbl_StyleCd.Text = "Style Code";
            this.lbl_StyleCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_StyleCd
            // 
            this.cmb_StyleCd.AddItemSeparator = ';';
            this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_StyleCd.Caption = "";
            this.cmb_StyleCd.CaptionHeight = 17;
            this.cmb_StyleCd.CaptionStyle = style33;
            this.cmb_StyleCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_StyleCd.ColumnCaptionHeight = 18;
            this.cmb_StyleCd.ColumnFooterHeight = 18;
            this.cmb_StyleCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_StyleCd.ContentHeight = 15;
            this.cmb_StyleCd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_StyleCd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_StyleCd.EditorFont = new System.Drawing.Font("Verdana", 8F);
            this.cmb_StyleCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_StyleCd.EditorHeight = 15;
            this.cmb_StyleCd.EvenRowStyle = style34;
            this.cmb_StyleCd.Font = new System.Drawing.Font("Verdana", 8F);
            this.cmb_StyleCd.FooterStyle = style35;
            this.cmb_StyleCd.HeadingStyle = style36;
            this.cmb_StyleCd.HighLightRowStyle = style37;
            this.cmb_StyleCd.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_StyleCd.Images"))));
            this.cmb_StyleCd.ItemHeight = 15;
            this.cmb_StyleCd.Location = new System.Drawing.Point(530, 37);
            this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
            this.cmb_StyleCd.MaxLength = 32767;
            this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_StyleCd.Name = "cmb_StyleCd";
            this.cmb_StyleCd.OddRowStyle = style38;
            this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.SelectedStyle = style39;
            this.cmb_StyleCd.Size = new System.Drawing.Size(150, 19);
            this.cmb_StyleCd.Style = style40;
            this.cmb_StyleCd.TabIndex = 669;
            this.cmb_StyleCd.SelectedValueChanged += new System.EventHandler(this.cmb_StyleCd_SelectedValueChanged);
            this.cmb_StyleCd.PropBag = resources.GetString("cmb_StyleCd.PropBag");
            // 
            // lbl_YieldStatus
            // 
            this.lbl_YieldStatus.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_YieldStatus.ImageIndex = 0;
            this.lbl_YieldStatus.ImageList = this.img_Label;
            this.lbl_YieldStatus.Location = new System.Drawing.Point(353, 14);
            this.lbl_YieldStatus.Name = "lbl_YieldStatus";
            this.lbl_YieldStatus.Size = new System.Drawing.Size(100, 21);
            this.lbl_YieldStatus.TabIndex = 1564;
            this.lbl_YieldStatus.Text = "Yield Status";
            this.lbl_YieldStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_StyleCd
            // 
            this.txt_StyleCd.BackColor = System.Drawing.Color.White;
            this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_StyleCd.Location = new System.Drawing.Point(454, 37);
            this.txt_StyleCd.MaxLength = 10;
            this.txt_StyleCd.Name = "txt_StyleCd";
            this.txt_StyleCd.Size = new System.Drawing.Size(75, 19);
            this.txt_StyleCd.TabIndex = 668;
            this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style41;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 15;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8F);
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 15;
            this.cmb_Factory.EvenRowStyle = style42;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8F);
            this.cmb_Factory.FooterStyle = style43;
            this.cmb_Factory.HeadingStyle = style44;
            this.cmb_Factory.HighLightRowStyle = style45;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(108, 16);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style46;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style47;
            this.cmb_Factory.Size = new System.Drawing.Size(226, 19);
            this.cmb_Factory.Style = style48;
            this.cmb_Factory.TabIndex = 667;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // lbl_JobDate
            // 
            this.lbl_JobDate.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_JobDate.ImageIndex = 0;
            this.lbl_JobDate.ImageList = this.img_Label;
            this.lbl_JobDate.Location = new System.Drawing.Point(7, 36);
            this.lbl_JobDate.Name = "lbl_JobDate";
            this.lbl_JobDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_JobDate.TabIndex = 1563;
            this.lbl_JobDate.Text = "Job Date";
            this.lbl_JobDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_Factory.ImageIndex = 0;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(7, 14);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 1557;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // Pop_Status_Check
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.panel_Body);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.Name = "Pop_Status_Check";
            this.Text = "Check Status";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.panel_Body, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.groupBox_Select.ResumeLayout(false);
            this.groupBox_Select.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_YieldStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        public System.Windows.Forms.ImageList img_SmallButton;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.GroupBox groupBox_Select;
        private System.Windows.Forms.Label lbl_JobDate;
        private System.Windows.Forms.Label lbl_Factory;
        private C1.Win.C1List.C1Combo cmb_YieldStatus;
        private C1.Win.C1List.C1Combo cmb_Factory;
        private C1.Win.C1List.C1Combo cmb_StyleCd;
        private System.Windows.Forms.TextBox txt_StyleCd;
        private System.Windows.Forms.Label lbl_StyleCd;
        private System.Windows.Forms.Label lbl_YieldStatus;
        private System.Windows.Forms.DateTimePicker dpick_FromYMD;
        private System.Windows.Forms.DateTimePicker dpick_ToYMD;
        private System.Windows.Forms.Label label1;
        public COM.FSP fgrid_Main;
    }
}