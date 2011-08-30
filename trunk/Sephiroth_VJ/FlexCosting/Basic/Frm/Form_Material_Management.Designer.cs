namespace FlexCosting.Basic.Frm
{
    partial class Form_Material_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Material_Management));
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
            this.sizer_Main = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_schText = new System.Windows.Forms.TextBox();
            this.lbl_schText = new System.Windows.Forms.Label();
            this.cmb_div = new C1.Win.C1List.C1Combo();
            this.lbl_class = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.searchPanel1 = new FlexCosting.Basic.Ctl.SearchPanel();
            this.fgrid_main = new COM.FSP();
            this.ctx_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxm_priceHistory = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizer_Main)).BeginInit();
            this.sizer_Main.SuspendLayout();
            this.pnl_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_div)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.ctx_main.SuspendLayout();
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
            // 
            // image_List
            // 
            this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
            this.image_List.Images.SetKeyName(0, "");
            this.image_List.Images.SetKeyName(1, "");
            this.image_List.Images.SetKeyName(2, "");
            this.image_List.Images.SetKeyName(3, "");
            this.image_List.Images.SetKeyName(4, "");
            this.image_List.Images.SetKeyName(5, "");
            this.image_List.Images.SetKeyName(6, "");
            this.image_List.Images.SetKeyName(7, "");
            this.image_List.Images.SetKeyName(8, "");
            this.image_List.Images.SetKeyName(9, "");
            this.image_List.Images.SetKeyName(10, "");
            this.image_List.Images.SetKeyName(11, "");
            this.image_List.Images.SetKeyName(12, "");
            this.image_List.Images.SetKeyName(13, "");
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
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
            this.img_SmallButton.Images.SetKeyName(10, "");
            this.img_SmallButton.Images.SetKeyName(11, "");
            this.img_SmallButton.Images.SetKeyName(12, "");
            this.img_SmallButton.Images.SetKeyName(13, "");
            this.img_SmallButton.Images.SetKeyName(14, "");
            this.img_SmallButton.Images.SetKeyName(15, "");
            this.img_SmallButton.Images.SetKeyName(16, "");
            this.img_SmallButton.Images.SetKeyName(17, "");
            this.img_SmallButton.Images.SetKeyName(18, "");
            this.img_SmallButton.Images.SetKeyName(19, "");
            this.img_SmallButton.Images.SetKeyName(20, "");
            this.img_SmallButton.Images.SetKeyName(21, "");
            this.img_SmallButton.Images.SetKeyName(22, "");
            this.img_SmallButton.Images.SetKeyName(23, "");
            this.img_SmallButton.Images.SetKeyName(24, "");
            this.img_SmallButton.Images.SetKeyName(25, "");
            this.img_SmallButton.Images.SetKeyName(26, "");
            this.img_SmallButton.Images.SetKeyName(27, "");
            this.img_SmallButton.Images.SetKeyName(28, "");
            this.img_SmallButton.Images.SetKeyName(29, "");
            // 
            // sizer_Main
            // 
            this.sizer_Main.Controls.Add(this.pnl_search);
            this.sizer_Main.Controls.Add(this.fgrid_main);
            this.sizer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizer_Main.GridDefinition = "12.0567375886525:False:True;85.1063829787234:False:False;0:False:True;\t0:False:Tr" +
                "ue;98.4251968503937:False:False;0:False:True;";
            this.sizer_Main.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sizer_Main.Location = new System.Drawing.Point(0, 80);
            this.sizer_Main.Name = "sizer_Main";
            this.sizer_Main.Size = new System.Drawing.Size(1016, 564);
            this.sizer_Main.TabIndex = 30;
            this.sizer_Main.TabStop = false;
            // 
            // pnl_search
            // 
            this.pnl_search.Controls.Add(this.lbl_title);
            this.pnl_search.Controls.Add(this.txt_schText);
            this.pnl_search.Controls.Add(this.lbl_schText);
            this.pnl_search.Controls.Add(this.cmb_div);
            this.pnl_search.Controls.Add(this.lbl_class);
            this.pnl_search.Controls.Add(this.cmb_factory);
            this.pnl_search.Controls.Add(this.lbl_factory);
            this.pnl_search.Controls.Add(this.searchPanel1);
            this.pnl_search.Location = new System.Drawing.Point(8, 4);
            this.pnl_search.Name = "pnl_search";
            this.pnl_search.Size = new System.Drawing.Size(1004, 68);
            this.pnl_search.TabIndex = 3;
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
            this.lbl_title.TabIndex = 595;
            this.lbl_title.Text = "      Search Condition";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_schText
            // 
            this.txt_schText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_schText.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_schText.Location = new System.Drawing.Point(765, 36);
            this.txt_schText.MaxLength = 40;
            this.txt_schText.Name = "txt_schText";
            this.txt_schText.Size = new System.Drawing.Size(220, 21);
            this.txt_schText.TabIndex = 593;
            // 
            // lbl_schText
            // 
            this.lbl_schText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_schText.ImageIndex = 0;
            this.lbl_schText.ImageList = this.img_Label;
            this.lbl_schText.Location = new System.Drawing.Point(664, 36);
            this.lbl_schText.Name = "lbl_schText";
            this.lbl_schText.Size = new System.Drawing.Size(100, 21);
            this.lbl_schText.TabIndex = 357;
            this.lbl_schText.Tag = "0";
            this.lbl_schText.Text = "Search Text";
            this.lbl_schText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_div
            // 
            this.cmb_div.AddItemSeparator = ';';
            this.cmb_div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_div.Caption = "";
            this.cmb_div.CaptionHeight = 17;
            this.cmb_div.CaptionStyle = style1;
            this.cmb_div.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_div.ColumnCaptionHeight = 18;
            this.cmb_div.ColumnFooterHeight = 18;
            this.cmb_div.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_div.ContentHeight = 17;
            this.cmb_div.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_div.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_div.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_div.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_div.EditorHeight = 17;
            this.cmb_div.EvenRowStyle = style2;
            this.cmb_div.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_div.FooterStyle = style3;
            this.cmb_div.HeadingStyle = style4;
            this.cmb_div.HighLightRowStyle = style5;
            this.cmb_div.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_div.Images"))));
            this.cmb_div.ItemHeight = 15;
            this.cmb_div.Location = new System.Drawing.Point(437, 36);
            this.cmb_div.MatchEntryTimeout = ((long)(2000));
            this.cmb_div.MaxDropDownItems = ((short)(5));
            this.cmb_div.MaxLength = 32767;
            this.cmb_div.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_div.Name = "cmb_div";
            this.cmb_div.OddRowStyle = style6;
            this.cmb_div.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_div.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_div.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_div.SelectedStyle = style7;
            this.cmb_div.Size = new System.Drawing.Size(210, 21);
            this.cmb_div.Style = style8;
            this.cmb_div.TabIndex = 356;
            this.cmb_div.PropBag = resources.GetString("cmb_div.PropBag");
            // 
            // lbl_class
            // 
            this.lbl_class.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class.ImageIndex = 0;
            this.lbl_class.ImageList = this.img_Label;
            this.lbl_class.Location = new System.Drawing.Point(336, 36);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(100, 21);
            this.lbl_class.TabIndex = 355;
            this.lbl_class.Tag = "0";
            this.lbl_class.Text = "Class";
            this.lbl_class.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style9;
            this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_factory.ColumnCaptionHeight = 18;
            this.cmb_factory.ColumnFooterHeight = 18;
            this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_factory.ContentHeight = 17;
            this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory.EditorHeight = 17;
            this.cmb_factory.EvenRowStyle = style10;
            this.cmb_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style11;
            this.cmb_factory.HeadingStyle = style12;
            this.cmb_factory.HighLightRowStyle = style13;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 36);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style14;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style15;
            this.cmb_factory.Size = new System.Drawing.Size(210, 21);
            this.cmb_factory.Style = style16;
            this.cmb_factory.TabIndex = 354;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 36);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 353;
            this.lbl_factory.Tag = "0";
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchPanel1
            // 
            this.searchPanel1.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel1.Location = new System.Drawing.Point(0, 0);
            this.searchPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.searchPanel1.Name = "searchPanel1";
            this.searchPanel1.Size = new System.Drawing.Size(1004, 68);
            this.searchPanel1.TabIndex = 0;
            // 
            // fgrid_main
            // 
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ContextMenuStrip = this.ctx_main;
            this.fgrid_main.Location = new System.Drawing.Point(8, 76);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Rows.DefaultSize = 19;
            this.fgrid_main.Size = new System.Drawing.Size(1004, 480);
            this.fgrid_main.StyleInfo = resources.GetString("fgrid_main.StyleInfo");
            this.fgrid_main.TabIndex = 1;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.KeyDownEdit += new C1.Win.C1FlexGrid.KeyEditEventHandler(this.fgrid_main_KeyDownEdit);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            // 
            // ctx_main
            // 
            this.ctx_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxm_priceHistory});
            this.ctx_main.Name = "ctx_main";
            this.ctx_main.Size = new System.Drawing.Size(172, 26);
            // 
            // ctxm_priceHistory
            // 
            this.ctxm_priceHistory.Name = "ctxm_priceHistory";
            this.ctxm_priceHistory.Size = new System.Drawing.Size(171, 22);
            this.ctxm_priceHistory.Text = "Unit price history";
            this.ctxm_priceHistory.Click += new System.EventHandler(this.ctxm_priceHistory_Click);
            // 
            // Form_Material_Management
            // 
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.sizer_Main);
            this.Name = "Form_Material_Management";
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.sizer_Main, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizer_Main)).EndInit();
            this.sizer_Main.ResumeLayout(false);
            this.pnl_search.ResumeLayout(false);
            this.pnl_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_div)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.ctx_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Sizer.C1Sizer sizer_Main;
        private COM.FSP fgrid_main;
        private System.Windows.Forms.Panel pnl_search;
        private C1.Win.C1List.C1Combo cmb_factory;
        private System.Windows.Forms.Label lbl_factory;
        private FlexCosting.Basic.Ctl.SearchPanel searchPanel1;
        private C1.Win.C1List.C1Combo cmb_div;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.TextBox txt_schText;
        private System.Windows.Forms.ContextMenuStrip ctx_main;
        private System.Windows.Forms.ToolStripMenuItem ctxm_priceHistory;
        public System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_schText;
    }
}
