namespace FlexBase.Yield_New
{
    partial class Pop_Yield_Backup_Restore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Yield_Backup_Restore));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Grid = new System.Windows.Forms.TabPage();
            this.fgrid_Detail = new COM.FSP();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cmb_TableName = new C1.Win.C1List.C1Combo();
            this.txt_SelectFileName = new System.Windows.Forms.TextBox();
            this.lbl_TableName = new System.Windows.Forms.Label();
            this.tabPage_XML = new System.Windows.Forms.TabPage();
            this.ax_xml_viewer = new AxSHDocVw.AxWebBrowser();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.groupBox_Search = new System.Windows.Forms.GroupBox();
            this.fgrid_Head = new COM.FSP();
            this.txt_Factory = new System.Windows.Forms.TextBox();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.txt_StyleName = new System.Windows.Forms.TextBox();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.txt_StyleCd = new System.Windows.Forms.TextBox();
            this.panel_Button = new System.Windows.Forms.Panel();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_GoTo_SizeGroup = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.panel_Body.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_TableName)).BeginInit();
            this.tabPage_XML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ax_xml_viewer)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.groupBox_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Head)).BeginInit();
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
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4,
            this.c1CommandLink5,
            this.c1CommandLink6,
            this.c1CommandLink7});
            this.c1ToolBar1.Location = new System.Drawing.Point(1013, 4);
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
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(1236, 23);
            this.lbl_MainTitle.Text = "Restore Yield Data";
            // 
            // panel_Body
            // 
            this.panel_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Body.Controls.Add(this.tabControl_Main);
            this.panel_Body.Controls.Add(this.panel_Top);
            this.panel_Body.Controls.Add(this.panel_Button);
            this.panel_Body.Location = new System.Drawing.Point(0, 56);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(792, 510);
            this.panel_Body.TabIndex = 31;
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_Grid);
            this.tabControl_Main.Controls.Add(this.tabPage_XML);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Font = new System.Drawing.Font("Verdana", 8F);
            this.tabControl_Main.Location = new System.Drawing.Point(0, 150);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(792, 335);
            this.tabControl_Main.TabIndex = 5;
            // 
            // tabPage_Grid
            // 
            this.tabPage_Grid.Controls.Add(this.fgrid_Detail);
            this.tabPage_Grid.Controls.Add(this.btn_Search);
            this.tabPage_Grid.Controls.Add(this.cmb_TableName);
            this.tabPage_Grid.Controls.Add(this.txt_SelectFileName);
            this.tabPage_Grid.Controls.Add(this.lbl_TableName);
            this.tabPage_Grid.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Grid.Name = "tabPage_Grid";
            this.tabPage_Grid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Grid.Size = new System.Drawing.Size(784, 309);
            this.tabPage_Grid.TabIndex = 0;
            this.tabPage_Grid.Text = "Grid";
            this.tabPage_Grid.UseVisualStyleBackColor = true;
            // 
            // fgrid_Detail
            // 
            this.fgrid_Detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fgrid_Detail.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.fgrid_Detail.Location = new System.Drawing.Point(3, 28);
            this.fgrid_Detail.Name = "fgrid_Detail";
            this.fgrid_Detail.Rows.DefaultSize = 17;
            this.fgrid_Detail.Size = new System.Drawing.Size(777, 273);
            this.fgrid_Detail.StyleInfo = resources.GetString("fgrid_Detail.StyleInfo");
            this.fgrid_Detail.TabIndex = 1565;
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 8F);
            this.btn_Search.ImageIndex = 0;
            this.btn_Search.Location = new System.Drawing.Point(332, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(70, 21);
            this.btn_Search.TabIndex = 684;
            this.btn_Search.Text = "Search";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cmb_TableName
            // 
            this.cmb_TableName.AddItemSeparator = ';';
            this.cmb_TableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_TableName.Caption = "";
            this.cmb_TableName.CaptionHeight = 17;
            this.cmb_TableName.CaptionStyle = style1;
            this.cmb_TableName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_TableName.ColumnCaptionHeight = 18;
            this.cmb_TableName.ColumnFooterHeight = 18;
            this.cmb_TableName.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_TableName.ContentHeight = 15;
            this.cmb_TableName.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_TableName.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_TableName.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_TableName.EditorFont = new System.Drawing.Font("Verdana", 8F);
            this.cmb_TableName.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_TableName.EditorHeight = 15;
            this.cmb_TableName.EvenRowStyle = style2;
            this.cmb_TableName.Font = new System.Drawing.Font("Verdana", 8F);
            this.cmb_TableName.FooterStyle = style3;
            this.cmb_TableName.HeadingStyle = style4;
            this.cmb_TableName.HighLightRowStyle = style5;
            this.cmb_TableName.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_TableName.Images"))));
            this.cmb_TableName.ItemHeight = 15;
            this.cmb_TableName.Location = new System.Drawing.Point(104, 4);
            this.cmb_TableName.MatchEntryTimeout = ((long)(2000));
            this.cmb_TableName.MaxDropDownItems = ((short)(5));
            this.cmb_TableName.MaxLength = 32767;
            this.cmb_TableName.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_TableName.Name = "cmb_TableName";
            this.cmb_TableName.OddRowStyle = style6;
            this.cmb_TableName.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_TableName.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_TableName.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_TableName.SelectedStyle = style7;
            this.cmb_TableName.Size = new System.Drawing.Size(226, 19);
            this.cmb_TableName.Style = style8;
            this.cmb_TableName.TabIndex = 639;
            this.cmb_TableName.SelectedValueChanged += new System.EventHandler(this.cmb_TableName_SelectedValueChanged);
            this.cmb_TableName.PropBag = resources.GetString("cmb_TableName.PropBag");
            // 
            // txt_SelectFileName
            // 
            this.txt_SelectFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SelectFileName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SelectFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SelectFileName.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_SelectFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_SelectFileName.Location = new System.Drawing.Point(412, 4);
            this.txt_SelectFileName.MaxLength = 100;
            this.txt_SelectFileName.Name = "txt_SelectFileName";
            this.txt_SelectFileName.ReadOnly = true;
            this.txt_SelectFileName.Size = new System.Drawing.Size(367, 19);
            this.txt_SelectFileName.TabIndex = 640;
            // 
            // lbl_TableName
            // 
            this.lbl_TableName.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_TableName.ImageIndex = 0;
            this.lbl_TableName.ImageList = this.img_Label;
            this.lbl_TableName.Location = new System.Drawing.Point(3, 3);
            this.lbl_TableName.Name = "lbl_TableName";
            this.lbl_TableName.Size = new System.Drawing.Size(100, 21);
            this.lbl_TableName.TabIndex = 638;
            this.lbl_TableName.Text = "Table Name";
            this.lbl_TableName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage_XML
            // 
            this.tabPage_XML.Controls.Add(this.ax_xml_viewer);
            this.tabPage_XML.Location = new System.Drawing.Point(4, 22);
            this.tabPage_XML.Name = "tabPage_XML";
            this.tabPage_XML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_XML.Size = new System.Drawing.Size(784, 309);
            this.tabPage_XML.TabIndex = 1;
            this.tabPage_XML.Text = "XML";
            this.tabPage_XML.UseVisualStyleBackColor = true;
            // 
            // ax_xml_viewer
            // 
            this.ax_xml_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ax_xml_viewer.Enabled = true;
            this.ax_xml_viewer.Location = new System.Drawing.Point(3, 3);
            this.ax_xml_viewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ax_xml_viewer.OcxState")));
            this.ax_xml_viewer.Size = new System.Drawing.Size(778, 303);
            this.ax_xml_viewer.TabIndex = 2;
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.groupBox_Search);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(792, 150);
            this.panel_Top.TabIndex = 4;
            // 
            // groupBox_Search
            // 
            this.groupBox_Search.Controls.Add(this.fgrid_Head);
            this.groupBox_Search.Controls.Add(this.txt_Factory);
            this.groupBox_Search.Controls.Add(this.lbl_Factory);
            this.groupBox_Search.Controls.Add(this.txt_StyleName);
            this.groupBox_Search.Controls.Add(this.lbl_Style);
            this.groupBox_Search.Controls.Add(this.txt_StyleCd);
            this.groupBox_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Search.Font = new System.Drawing.Font("Verdana", 8F);
            this.groupBox_Search.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Size = new System.Drawing.Size(792, 150);
            this.groupBox_Search.TabIndex = 1;
            this.groupBox_Search.TabStop = false;
            // 
            // fgrid_Head
            // 
            this.fgrid_Head.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fgrid_Head.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.fgrid_Head.Location = new System.Drawing.Point(7, 40);
            this.fgrid_Head.Name = "fgrid_Head";
            this.fgrid_Head.Rows.DefaultSize = 17;
            this.fgrid_Head.Size = new System.Drawing.Size(780, 104);
            this.fgrid_Head.StyleInfo = resources.GetString("fgrid_Head.StyleInfo");
            this.fgrid_Head.TabIndex = 1564;
            this.fgrid_Head.DoubleClick += new System.EventHandler(this.fgrid_Head_DoubleClick);
            // 
            // txt_Factory
            // 
            this.txt_Factory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Factory.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_Factory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Factory.Location = new System.Drawing.Point(108, 15);
            this.txt_Factory.MaxLength = 10;
            this.txt_Factory.Name = "txt_Factory";
            this.txt_Factory.ReadOnly = true;
            this.txt_Factory.Size = new System.Drawing.Size(75, 19);
            this.txt_Factory.TabIndex = 1563;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_Factory.ImageIndex = 0;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(7, 14);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 1562;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_StyleName
            // 
            this.txt_StyleName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_StyleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleName.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_StyleName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_StyleName.Location = new System.Drawing.Point(379, 15);
            this.txt_StyleName.MaxLength = 100;
            this.txt_StyleName.Name = "txt_StyleName";
            this.txt_StyleName.ReadOnly = true;
            this.txt_StyleName.Size = new System.Drawing.Size(150, 19);
            this.txt_StyleName.TabIndex = 1560;
            // 
            // lbl_Style
            // 
            this.lbl_Style.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_Style.ImageIndex = 0;
            this.lbl_Style.ImageList = this.img_Label;
            this.lbl_Style.Location = new System.Drawing.Point(202, 14);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style.TabIndex = 1561;
            this.lbl_Style.Text = "Style Code";
            this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_StyleCd
            // 
            this.txt_StyleCd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_StyleCd.Location = new System.Drawing.Point(303, 15);
            this.txt_StyleCd.MaxLength = 10;
            this.txt_StyleCd.Name = "txt_StyleCd";
            this.txt_StyleCd.ReadOnly = true;
            this.txt_StyleCd.Size = new System.Drawing.Size(75, 19);
            this.txt_StyleCd.TabIndex = 1558;
            // 
            // panel_Button
            // 
            this.panel_Button.Controls.Add(this.btn_Apply);
            this.panel_Button.Controls.Add(this.btn_GoTo_SizeGroup);
            this.panel_Button.Controls.Add(this.btn_Cancel);
            this.panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Button.Location = new System.Drawing.Point(0, 485);
            this.panel_Button.Name = "panel_Button";
            this.panel_Button.Size = new System.Drawing.Size(792, 25);
            this.panel_Button.TabIndex = 3;
            // 
            // btn_Apply
            // 
            this.btn_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apply.Font = new System.Drawing.Font("Verdana", 8F);
            this.btn_Apply.ImageIndex = 0;
            this.btn_Apply.Location = new System.Drawing.Point(648, 2);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(70, 21);
            this.btn_Apply.TabIndex = 683;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btn_GoTo_SizeGroup
            // 
            this.btn_GoTo_SizeGroup.ImageIndex = 8;
            this.btn_GoTo_SizeGroup.Location = new System.Drawing.Point(115, 2);
            this.btn_GoTo_SizeGroup.Name = "btn_GoTo_SizeGroup";
            this.btn_GoTo_SizeGroup.Size = new System.Drawing.Size(21, 21);
            this.btn_GoTo_SizeGroup.TabIndex = 690;
            this.btn_GoTo_SizeGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 8F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.Location = new System.Drawing.Point(720, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 21);
            this.btn_Cancel.TabIndex = 682;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Pop_Yield_Backup_Restore
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.panel_Body);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.Name = "Pop_Yield_Backup_Restore";
            this.Text = "Restore Yield Data";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.panel_Body, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.panel_Body.ResumeLayout(false);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Grid.ResumeLayout(false);
            this.tabPage_Grid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_TableName)).EndInit();
            this.tabPage_XML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ax_xml_viewer)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.groupBox_Search.ResumeLayout(false);
            this.groupBox_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Head)).EndInit();
            this.panel_Button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.TextBox txt_StyleName;
        private System.Windows.Forms.Label lbl_Style;
        private System.Windows.Forms.TextBox txt_StyleCd;
        private System.Windows.Forms.Panel panel_Button;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Label btn_GoTo_SizeGroup;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Factory;
        private System.Windows.Forms.TextBox txt_Factory;
        private COM.FSP fgrid_Head;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Grid;
        private System.Windows.Forms.TabPage tabPage_XML;
        private AxSHDocVw.AxWebBrowser ax_xml_viewer;
        private System.Windows.Forms.Label lbl_TableName;
        private C1.Win.C1List.C1Combo cmb_TableName;
        private System.Windows.Forms.TextBox txt_SelectFileName;
        private System.Windows.Forms.Button btn_Search;
        private COM.FSP fgrid_Detail;
    }
}