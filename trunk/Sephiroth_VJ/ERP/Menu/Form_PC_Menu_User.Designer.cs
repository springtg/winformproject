namespace ERP.Menu
{
    partial class Form_PC_Menu_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PC_Menu_User));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.btn_CreateRoleID = new System.Windows.Forms.Label();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_Menu = new COM.FSP();
            this.fgrid_User = new COM.FSP();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.cmb_Role = new C1.Win.C1List.C1Combo();
            this.btn_AdUpdate = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_User)).BeginInit();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Role)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
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
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
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
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Text = "User/ Role Menu";
            // 
            // btn_CreateRoleID
            // 
            this.btn_CreateRoleID.BackColor = System.Drawing.SystemColors.Window;
            this.btn_CreateRoleID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateRoleID.ImageIndex = 29;
            this.btn_CreateRoleID.Location = new System.Drawing.Point(496, 323);
            this.btn_CreateRoleID.Name = "btn_CreateRoleID";
            this.btn_CreateRoleID.Size = new System.Drawing.Size(24, 21);
            this.btn_CreateRoleID.TabIndex = 612;
            this.btn_CreateRoleID.Tag = "Search";
            this.btn_CreateRoleID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.SystemColors.Window;
            this.c1Sizer1.Controls.Add(this.fgrid_Menu);
            this.c1Sizer1.Controls.Add(this.fgrid_User);
            this.c1Sizer1.Controls.Add(this.pnl_SearchImage);
            this.c1Sizer1.GridDefinition = "10.8620689655172:False:True;17.2413793103448:True:True;69.1379310344828:False:Fal" +
                "se;\t99.2141453831041:True:False;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1018, 580);
            this.c1Sizer1.TabIndex = 613;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_Menu
            // 
            this.fgrid_Menu.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Menu.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Menu.Location = new System.Drawing.Point(4, 175);
            this.fgrid_Menu.Name = "fgrid_Menu";
            this.fgrid_Menu.Size = new System.Drawing.Size(1010, 401);
            this.fgrid_Menu.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Menu.Styles"));
            this.fgrid_Menu.TabIndex = 573;
            this.fgrid_Menu.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Menu_AfterEdit);
            this.fgrid_Menu.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Menu_BeforeEdit);
            // 
            // fgrid_User
            // 
            this.fgrid_User.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_User.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_User.Location = new System.Drawing.Point(4, 71);
            this.fgrid_User.Name = "fgrid_User";
            this.fgrid_User.Size = new System.Drawing.Size(1010, 100);
            this.fgrid_User.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_User.Styles"));
            this.fgrid_User.TabIndex = 571;
            this.fgrid_User.Click += new System.EventHandler(this.fgrid_User_Click);
            this.fgrid_User.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_User_AfterEdit);
            this.fgrid_User.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_User_BeforeEdit);
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.lbl_Role);
            this.pnl_SearchImage.Controls.Add(this.cmb_Role);
            this.pnl_SearchImage.Controls.Add(this.btn_AdUpdate);
            this.pnl_SearchImage.Controls.Add(this.txt_User);
            this.pnl_SearchImage.Controls.Add(this.lbl_User);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.pictureBox2);
            this.pnl_SearchImage.Controls.Add(this.pictureBox4);
            this.pnl_SearchImage.Controls.Add(this.pictureBox5);
            this.pnl_SearchImage.Controls.Add(this.pictureBox6);
            this.pnl_SearchImage.Controls.Add(this.pictureBox7);
            this.pnl_SearchImage.Controls.Add(this.pictureBox8);
            this.pnl_SearchImage.Controls.Add(this.pictureBox9);
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(4, 4);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1010, 63);
            this.pnl_SearchImage.TabIndex = 570;
            // 
            // lbl_Role
            // 
            this.lbl_Role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Role.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_Role.ImageIndex = 0;
            this.lbl_Role.ImageList = this.img_Label;
            this.lbl_Role.Location = new System.Drawing.Point(305, 36);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(100, 21);
            this.lbl_Role.TabIndex = 590;
            this.lbl_Role.Text = "Role";
            this.lbl_Role.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Role
            // 
            this.cmb_Role.AddItemCols = 0;
            this.cmb_Role.AddItemSeparator = ';';
            this.cmb_Role.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Role.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Role.Caption = "";
            this.cmb_Role.CaptionHeight = 17;
            this.cmb_Role.CaptionStyle = style1;
            this.cmb_Role.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Role.ColumnCaptionHeight = 18;
            this.cmb_Role.ColumnFooterHeight = 18;
            this.cmb_Role.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Role.ContentHeight = 17;
            this.cmb_Role.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Role.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Role.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Role.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Role.EditorHeight = 17;
            this.cmb_Role.EvenRowStyle = style2;
            this.cmb_Role.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Role.FooterStyle = style3;
            this.cmb_Role.GapHeight = 2;
            this.cmb_Role.HeadingStyle = style4;
            this.cmb_Role.HighLightRowStyle = style5;
            this.cmb_Role.ItemHeight = 15;
            this.cmb_Role.Location = new System.Drawing.Point(405, 36);
            this.cmb_Role.MatchEntryTimeout = ((long)(2000));
            this.cmb_Role.MaxDropDownItems = ((short)(5));
            this.cmb_Role.MaxLength = 32767;
            this.cmb_Role.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Role.Name = "cmb_Role";
            this.cmb_Role.OddRowStyle = style6;
            this.cmb_Role.PartialRightColumn = false;
            this.cmb_Role.PropBag = resources.GetString("cmb_Role.PropBag");
            this.cmb_Role.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Role.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Role.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Role.SelectedStyle = style7;
            this.cmb_Role.Size = new System.Drawing.Size(180, 21);
            this.cmb_Role.Style = style8;
            this.cmb_Role.TabIndex = 589;
            this.cmb_Role.SelectedValueChanged += new System.EventHandler(this.cmb_Role_SelectedValueChanged);
            // 
            // btn_AdUpdate
            // 
            this.btn_AdUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AdUpdate.ImageIndex = 0;
            this.btn_AdUpdate.ImageList = this.img_Button;
            this.btn_AdUpdate.Location = new System.Drawing.Point(861, 34);
            this.btn_AdUpdate.Name = "btn_AdUpdate";
            this.btn_AdUpdate.Size = new System.Drawing.Size(140, 23);
            this.btn_AdUpdate.TabIndex = 613;
            this.btn_AdUpdate.Text = "Create user from AD";
            this.btn_AdUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AdUpdate.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_AdUpdate.Click += new System.EventHandler(this.btn_AdUpdate_Click);
            this.btn_AdUpdate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_AdUpdate.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_AdUpdate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // txt_User
            // 
            this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_User.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_User.Location = new System.Drawing.Point(109, 36);
            this.txt_User.MaxLength = 500;
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(180, 21);
            this.txt_User.TabIndex = 300;
            this.txt_User.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_User_KeyUp);
            // 
            // lbl_User
            // 
            this.lbl_User.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ImageIndex = 0;
            this.lbl_User.ImageList = this.img_Label;
            this.lbl_User.Location = new System.Drawing.Point(8, 36);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(100, 21);
            this.lbl_User.TabIndex = 351;
            this.lbl_User.Tag = "0";
            this.lbl_User.Text = "User";
            this.lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_TM
            // 
            this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
            this.picb_TM.Location = new System.Drawing.Point(219, 0);
            this.picb_TM.Name = "picb_TM";
            this.picb_TM.Size = new System.Drawing.Size(786, 32);
            this.picb_TM.TabIndex = 113;
            this.picb_TM.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_title.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Navy;
            this.lbl_title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_title.Image")));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(231, 30);
            this.lbl_title.TabIndex = 28;
            this.lbl_title.Text = "      Search Condition";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(993, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(24, 20);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(994, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 32);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(994, 48);
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
            this.pictureBox5.Location = new System.Drawing.Point(144, 47);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1010, 18);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 48);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(168, 20);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 24);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(168, 30);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(150, 24);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(851, 23);
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(472, 72);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(1010, 23);
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            // 
            // Form_PC_Menu_User
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Controls.Add(this.btn_CreateRoleID);
            this.Name = "Form_PC_Menu_User";
            this.Text = "User/ Role Menu";
            this.Load += new System.EventHandler(this.Form_EIS_Menu_User_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.btn_CreateRoleID, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_User)).EndInit();
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Role)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label btn_CreateRoleID;
        private C1.Win.C1Sizer.C1Sizer c1Sizer1;
        private COM.FSP fgrid_Menu;
        private COM.FSP fgrid_User;
        public System.Windows.Forms.Panel pnl_SearchImage;
        private System.Windows.Forms.Label lbl_Role;
        private C1.Win.C1List.C1Combo cmb_Role;
        private System.Windows.Forms.Label btn_AdUpdate;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label lbl_User;
        public System.Windows.Forms.PictureBox picb_TM;
        public System.Windows.Forms.Label lbl_title;
        public System.Windows.Forms.PictureBox picb_MR;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.PictureBox pictureBox8;
        public System.Windows.Forms.PictureBox pictureBox9;


    }
}