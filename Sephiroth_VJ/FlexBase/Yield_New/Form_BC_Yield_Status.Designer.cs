namespace FlexBase.Yield_New
{
    partial class Form_BC_Yield_Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BC_Yield_Status));
            C1.Win.C1List.Style style65 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style66 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style67 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style68 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style69 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style70 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style71 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style72 = new C1.Win.C1List.Style();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.fgrid_Main = new COM.FSP();
            this.contextMenu_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItem_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Search = new System.Windows.Forms.Panel();
            this.panel_SearchImage = new System.Windows.Forms.Panel();
            this.txt_Gender = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
            this.txt_StyleCd = new System.Windows.Forms.TextBox();
            this.groupBox_Depth = new System.Windows.Forms.GroupBox();
            this.rad_All = new System.Windows.Forms.RadioButton();
            this.rad_Style = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.checkedListBox_Status = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
            this.contextMenu_Main.SuspendLayout();
            this.panel_Search.SuspendLayout();
            this.panel_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
            this.groupBox_Depth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
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
            this.c1CommandHolder1.Commands.Add(this.tbtn_Confirm);
            // 
            // tbtn_New
            // 
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 644);
            this.stbar.Size = new System.Drawing.Size(1016, 22);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(952, 23);
            this.lbl_MainTitle.Text = "Yield Status";
            // 
            // panel_Body
            // 
            this.panel_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Body.Controls.Add(this.checkedListBox_Status);
            this.panel_Body.Controls.Add(this.fgrid_Main);
            this.panel_Body.Controls.Add(this.panel_Search);
            this.panel_Body.Location = new System.Drawing.Point(0, 56);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1016, 588);
            this.panel_Body.TabIndex = 30;
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Main.ContextMenuStrip = this.contextMenu_Main;
            this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Main.Location = new System.Drawing.Point(0, 77);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Rows.DefaultSize = 19;
            this.fgrid_Main.Size = new System.Drawing.Size(1016, 511);
            this.fgrid_Main.StyleInfo = resources.GetString("fgrid_Main.StyleInfo");
            this.fgrid_Main.TabIndex = 1;
            this.fgrid_Main.Click += new System.EventHandler(this.fgrid_Main_Click);
            this.fgrid_Main.StartEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_StartEdit);
            this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
            // 
            // contextMenu_Main
            // 
            this.contextMenu_Main.Font = new System.Drawing.Font("Verdana", 8F);
            this.contextMenu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Insert,
            this.menuItem_Delete});
            this.contextMenu_Main.Name = "contextMenu_Yield";
            this.contextMenu_Main.Size = new System.Drawing.Size(112, 48);
            this.contextMenu_Main.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Main_Opening);
            // 
            // menuItem_Insert
            // 
            this.menuItem_Insert.Name = "menuItem_Insert";
            this.menuItem_Insert.Size = new System.Drawing.Size(111, 22);
            this.menuItem_Insert.Text = "Insert";
            this.menuItem_Insert.Click += new System.EventHandler(this.menuItem_Insert_Click);
            // 
            // menuItem_Delete
            // 
            this.menuItem_Delete.Name = "menuItem_Delete";
            this.menuItem_Delete.Size = new System.Drawing.Size(111, 22);
            this.menuItem_Delete.Text = "Delete";
            this.menuItem_Delete.Click += new System.EventHandler(this.menuItem_Delete_Click);
            // 
            // panel_Search
            // 
            this.panel_Search.Controls.Add(this.panel_SearchImage);
            this.panel_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Search.Location = new System.Drawing.Point(0, 0);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(1016, 77);
            this.panel_Search.TabIndex = 0;
            // 
            // panel_SearchImage
            // 
            this.panel_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.panel_SearchImage.Controls.Add(this.txt_Gender);
            this.panel_SearchImage.Controls.Add(this.lbl_Gender);
            this.panel_SearchImage.Controls.Add(this.cmb_StyleCd);
            this.panel_SearchImage.Controls.Add(this.txt_StyleCd);
            this.panel_SearchImage.Controls.Add(this.groupBox_Depth);
            this.panel_SearchImage.Controls.Add(this.pictureBox3);
            this.panel_SearchImage.Controls.Add(this.pictureBox2);
            this.panel_SearchImage.Controls.Add(this.lbl_Style);
            this.panel_SearchImage.Controls.Add(this.pictureBox1);
            this.panel_SearchImage.Controls.Add(this.lbl_SubTitle1);
            this.panel_SearchImage.Controls.Add(this.pictureBox4);
            this.panel_SearchImage.Controls.Add(this.pictureBox5);
            this.panel_SearchImage.Controls.Add(this.pictureBox6);
            this.panel_SearchImage.Controls.Add(this.pictureBox7);
            this.panel_SearchImage.Controls.Add(this.pictureBox8);
            this.panel_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_SearchImage.Location = new System.Drawing.Point(0, 0);
            this.panel_SearchImage.Name = "panel_SearchImage";
            this.panel_SearchImage.Size = new System.Drawing.Size(1016, 77);
            this.panel_SearchImage.TabIndex = 22;
            // 
            // txt_Gender
            // 
            this.txt_Gender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Gender.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_Gender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Gender.Location = new System.Drawing.Point(109, 51);
            this.txt_Gender.MaxLength = 100;
            this.txt_Gender.Name = "txt_Gender";
            this.txt_Gender.ReadOnly = true;
            this.txt_Gender.Size = new System.Drawing.Size(226, 19);
            this.txt_Gender.TabIndex = 1565;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_Gender.ImageIndex = 0;
            this.lbl_Gender.ImageList = this.img_Label;
            this.lbl_Gender.Location = new System.Drawing.Point(8, 51);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(100, 21);
            this.lbl_Gender.TabIndex = 1566;
            this.lbl_Gender.Text = "Gender/ Presto";
            this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_StyleCd
            // 
            this.cmb_StyleCd.AddItemSeparator = ';';
            this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_StyleCd.Caption = "";
            this.cmb_StyleCd.CaptionHeight = 17;
            this.cmb_StyleCd.CaptionStyle = style65;
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
            this.cmb_StyleCd.EvenRowStyle = style66;
            this.cmb_StyleCd.Font = new System.Drawing.Font("Verdana", 8F);
            this.cmb_StyleCd.FooterStyle = style67;
            this.cmb_StyleCd.HeadingStyle = style68;
            this.cmb_StyleCd.HighLightRowStyle = style69;
            this.cmb_StyleCd.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_StyleCd.Images"))));
            this.cmb_StyleCd.ItemHeight = 15;
            this.cmb_StyleCd.Location = new System.Drawing.Point(185, 30);
            this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
            this.cmb_StyleCd.MaxLength = 32767;
            this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_StyleCd.Name = "cmb_StyleCd";
            this.cmb_StyleCd.OddRowStyle = style70;
            this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.SelectedStyle = style71;
            this.cmb_StyleCd.Size = new System.Drawing.Size(150, 19);
            this.cmb_StyleCd.Style = style72;
            this.cmb_StyleCd.TabIndex = 1564;
            this.cmb_StyleCd.SelectedValueChanged += new System.EventHandler(this.cmb_StyleCd_SelectedValueChanged);
            this.cmb_StyleCd.PropBag = resources.GetString("cmb_StyleCd.PropBag");
            // 
            // txt_StyleCd
            // 
            this.txt_StyleCd.BackColor = System.Drawing.Color.White;
            this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_StyleCd.Location = new System.Drawing.Point(109, 30);
            this.txt_StyleCd.MaxLength = 10;
            this.txt_StyleCd.Name = "txt_StyleCd";
            this.txt_StyleCd.Size = new System.Drawing.Size(75, 19);
            this.txt_StyleCd.TabIndex = 1563;
            this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
            // 
            // groupBox_Depth
            // 
            this.groupBox_Depth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Depth.Controls.Add(this.rad_All);
            this.groupBox_Depth.Controls.Add(this.rad_Style);
            this.groupBox_Depth.Location = new System.Drawing.Point(900, 0);
            this.groupBox_Depth.Name = "groupBox_Depth";
            this.groupBox_Depth.Size = new System.Drawing.Size(108, 29);
            this.groupBox_Depth.TabIndex = 540;
            this.groupBox_Depth.TabStop = false;
            // 
            // rad_All
            // 
            this.rad_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rad_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rad_All.Font = new System.Drawing.Font("Verdana", 8F);
            this.rad_All.Location = new System.Drawing.Point(63, 8);
            this.rad_All.Name = "rad_All";
            this.rad_All.Size = new System.Drawing.Size(40, 18);
            this.rad_All.TabIndex = 675;
            this.rad_All.Tag = "-1";
            this.rad_All.Text = "All";
            this.rad_All.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // rad_Style
            // 
            this.rad_Style.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rad_Style.Checked = true;
            this.rad_Style.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rad_Style.Font = new System.Drawing.Font("Verdana", 8F);
            this.rad_Style.Location = new System.Drawing.Point(5, 8);
            this.rad_Style.Name = "rad_Style";
            this.rad_Style.Size = new System.Drawing.Size(55, 18);
            this.rad_Style.TabIndex = 674;
            this.rad_Style.TabStop = true;
            this.rad_Style.Tag = "0";
            this.rad_Style.Text = "Style";
            this.rad_Style.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(224, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(786, 40);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1000, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 40);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Style
            // 
            this.lbl_Style.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_Style.ImageIndex = 0;
            this.lbl_Style.ImageList = this.img_Label;
            this.lbl_Style.Location = new System.Drawing.Point(8, 29);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style.TabIndex = 527;
            this.lbl_Style.Text = "Style Code";
            this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(915, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 37);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_SubTitle1
            // 
            this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
            this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle1.Name = "lbl_SubTitle1";
            this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle1.TabIndex = 28;
            this.lbl_SubTitle1.Text = "      Search Condition";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1000, 62);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(144, 61);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(856, 18);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 62);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(168, 20);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(144, 32);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(848, 45);
            this.pictureBox7.TabIndex = 27;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(0, 24);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(168, 44);
            this.pictureBox8.TabIndex = 25;
            this.pictureBox8.TabStop = false;
            // 
            // checkedListBox_Status
            // 
            this.checkedListBox_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_Status.Font = new System.Drawing.Font("Verdana", 8F);
            this.checkedListBox_Status.FormattingEnabled = true;
            this.checkedListBox_Status.Location = new System.Drawing.Point(356, 38);
            this.checkedListBox_Status.Name = "checkedListBox_Status";
            this.checkedListBox_Status.Size = new System.Drawing.Size(650, 30);
            this.checkedListBox_Status.TabIndex = 1567;
            this.checkedListBox_Status.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_Status_ItemCheck);
            // 
            // Form_BC_Yield_Status
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.panel_Body);
            this.Name = "Form_BC_Yield_Status";
            this.Text = "Yield Status";
            this.Controls.SetChildIndex(this.panel_Body, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.contextMenu_Main.ResumeLayout(false);
            this.panel_Search.ResumeLayout(false);
            this.panel_SearchImage.ResumeLayout(false);
            this.panel_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
            this.groupBox_Depth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Panel panel_Search;
        public System.Windows.Forms.Panel panel_SearchImage;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Style;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbl_SubTitle1;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.PictureBox pictureBox8;
        private COM.FSP fgrid_Main;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Insert;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Delete;
        private System.Windows.Forms.ContextMenuStrip contextMenu_Main;
        private System.Windows.Forms.RadioButton rad_All;
        private System.Windows.Forms.RadioButton rad_Style;
        private System.Windows.Forms.GroupBox groupBox_Depth;
        private C1.Win.C1List.C1Combo cmb_StyleCd;
        private System.Windows.Forms.TextBox txt_StyleCd;
        private System.Windows.Forms.TextBox txt_Gender;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.CheckedListBox checkedListBox_Status;
    }
}