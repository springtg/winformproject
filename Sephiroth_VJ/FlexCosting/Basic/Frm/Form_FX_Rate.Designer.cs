namespace FlexCosting.Basic.Frm
{
    partial class Form_FX_Rate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FX_Rate));
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
            this.fgrid_main = new COM.FSP();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_desh1 = new System.Windows.Forms.Label();
            this.cmb_seasonTo = new C1.Win.C1List.C1Combo();
            this.cmb_seasonFrom = new C1.Win.C1List.C1Combo();
            this.lbl_season = new System.Windows.Forms.Label();
            this.searchPanel1 = new FlexCosting.Basic.Ctl.SearchPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizer_Main)).BeginInit();
            this.sizer_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_seasonTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_seasonFrom)).BeginInit();
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
            this.sizer_Main.Controls.Add(this.fgrid_main);
            this.sizer_Main.Controls.Add(this.pnl_search);
            this.sizer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizer_Main.GridDefinition = "11.7747440273038:False:True;85.4948805460751:False:False;0:False:True;\t0:False:Tr" +
                "ue;98.4251968503937:False:False;0:False:True;";
            this.sizer_Main.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sizer_Main.Location = new System.Drawing.Point(0, 80);
            this.sizer_Main.Name = "sizer_Main";
            this.sizer_Main.Size = new System.Drawing.Size(1016, 586);
            this.sizer_Main.TabIndex = 30;
            this.sizer_Main.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.Location = new System.Drawing.Point(8, 77);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Rows.DefaultSize = 19;
            this.fgrid_main.Size = new System.Drawing.Size(1000, 501);
            this.fgrid_main.StyleInfo = resources.GetString("fgrid_main.StyleInfo");
            this.fgrid_main.TabIndex = 1;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            // 
            // pnl_search
            // 
            this.pnl_search.Controls.Add(this.lbl_title);
            this.pnl_search.Controls.Add(this.lbl_desh1);
            this.pnl_search.Controls.Add(this.cmb_seasonTo);
            this.pnl_search.Controls.Add(this.cmb_seasonFrom);
            this.pnl_search.Controls.Add(this.lbl_season);
            this.pnl_search.Controls.Add(this.searchPanel1);
            this.pnl_search.Location = new System.Drawing.Point(8, 4);
            this.pnl_search.Name = "pnl_search";
            this.pnl_search.Size = new System.Drawing.Size(1000, 69);
            this.pnl_search.TabIndex = 2;
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
            // lbl_desh1
            // 
            this.lbl_desh1.Location = new System.Drawing.Point(204, 36);
            this.lbl_desh1.Name = "lbl_desh1";
            this.lbl_desh1.Size = new System.Drawing.Size(20, 21);
            this.lbl_desh1.TabIndex = 356;
            this.lbl_desh1.Text = "~";
            this.lbl_desh1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_seasonTo
            // 
            this.cmb_seasonTo.AddItemSeparator = ';';
            this.cmb_seasonTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_seasonTo.Caption = "";
            this.cmb_seasonTo.CaptionHeight = 17;
            this.cmb_seasonTo.CaptionStyle = style1;
            this.cmb_seasonTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_seasonTo.ColumnCaptionHeight = 18;
            this.cmb_seasonTo.ColumnFooterHeight = 18;
            this.cmb_seasonTo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_seasonTo.ContentHeight = 17;
            this.cmb_seasonTo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_seasonTo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_seasonTo.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_seasonTo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_seasonTo.EditorHeight = 17;
            this.cmb_seasonTo.EvenRowStyle = style2;
            this.cmb_seasonTo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_seasonTo.FooterStyle = style3;
            this.cmb_seasonTo.HeadingStyle = style4;
            this.cmb_seasonTo.HighLightRowStyle = style5;
            this.cmb_seasonTo.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_seasonTo.Images"))));
            this.cmb_seasonTo.ItemHeight = 15;
            this.cmb_seasonTo.Location = new System.Drawing.Point(224, 36);
            this.cmb_seasonTo.MatchEntryTimeout = ((long)(2000));
            this.cmb_seasonTo.MaxDropDownItems = ((short)(5));
            this.cmb_seasonTo.MaxLength = 32767;
            this.cmb_seasonTo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_seasonTo.Name = "cmb_seasonTo";
            this.cmb_seasonTo.OddRowStyle = style6;
            this.cmb_seasonTo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_seasonTo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_seasonTo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_seasonTo.SelectedStyle = style7;
            this.cmb_seasonTo.Size = new System.Drawing.Size(95, 21);
            this.cmb_seasonTo.Style = style8;
            this.cmb_seasonTo.TabIndex = 355;
            this.cmb_seasonTo.SelectedValueChanged += new System.EventHandler(this.cmb_seasonTo_SelectedValueChanged);
            this.cmb_seasonTo.PropBag = resources.GetString("cmb_seasonTo.PropBag");
            // 
            // cmb_seasonFrom
            // 
            this.cmb_seasonFrom.AddItemSeparator = ';';
            this.cmb_seasonFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_seasonFrom.Caption = "";
            this.cmb_seasonFrom.CaptionHeight = 17;
            this.cmb_seasonFrom.CaptionStyle = style9;
            this.cmb_seasonFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_seasonFrom.ColumnCaptionHeight = 18;
            this.cmb_seasonFrom.ColumnFooterHeight = 18;
            this.cmb_seasonFrom.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_seasonFrom.ContentHeight = 17;
            this.cmb_seasonFrom.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_seasonFrom.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_seasonFrom.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_seasonFrom.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_seasonFrom.EditorHeight = 17;
            this.cmb_seasonFrom.EvenRowStyle = style10;
            this.cmb_seasonFrom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_seasonFrom.FooterStyle = style11;
            this.cmb_seasonFrom.HeadingStyle = style12;
            this.cmb_seasonFrom.HighLightRowStyle = style13;
            this.cmb_seasonFrom.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_seasonFrom.Images"))));
            this.cmb_seasonFrom.ItemHeight = 15;
            this.cmb_seasonFrom.Location = new System.Drawing.Point(109, 36);
            this.cmb_seasonFrom.MatchEntryTimeout = ((long)(2000));
            this.cmb_seasonFrom.MaxDropDownItems = ((short)(5));
            this.cmb_seasonFrom.MaxLength = 32767;
            this.cmb_seasonFrom.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_seasonFrom.Name = "cmb_seasonFrom";
            this.cmb_seasonFrom.OddRowStyle = style14;
            this.cmb_seasonFrom.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_seasonFrom.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_seasonFrom.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_seasonFrom.SelectedStyle = style15;
            this.cmb_seasonFrom.Size = new System.Drawing.Size(95, 21);
            this.cmb_seasonFrom.Style = style16;
            this.cmb_seasonFrom.TabIndex = 354;
            this.cmb_seasonFrom.SelectedValueChanged += new System.EventHandler(this.cmb_seasonFrom_SelectedValueChanged);
            this.cmb_seasonFrom.PropBag = resources.GetString("cmb_seasonFrom.PropBag");
            // 
            // lbl_season
            // 
            this.lbl_season.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_season.ImageIndex = 1;
            this.lbl_season.ImageList = this.img_Label;
            this.lbl_season.Location = new System.Drawing.Point(8, 36);
            this.lbl_season.Name = "lbl_season";
            this.lbl_season.Size = new System.Drawing.Size(100, 21);
            this.lbl_season.TabIndex = 353;
            this.lbl_season.Tag = "0";
            this.lbl_season.Text = "Season";
            this.lbl_season.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchPanel1
            // 
            this.searchPanel1.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel1.Location = new System.Drawing.Point(0, 0);
            this.searchPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.searchPanel1.Name = "searchPanel1";
            this.searchPanel1.Size = new System.Drawing.Size(1000, 69);
            this.searchPanel1.TabIndex = 0;
            // 
            // Form_FX_Rate
            // 
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.sizer_Main);
            this.Name = "Form_FX_Rate";
            this.Controls.SetChildIndex(this.sizer_Main, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizer_Main)).EndInit();
            this.sizer_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.pnl_search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_seasonTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_seasonFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Sizer.C1Sizer sizer_Main;
        private FlexCosting.Basic.Ctl.SearchPanel searchPanel1;
        private COM.FSP fgrid_main;
        private System.Windows.Forms.Panel pnl_search;
        private C1.Win.C1List.C1Combo cmb_seasonFrom;
        private System.Windows.Forms.Label lbl_season;
        private System.Windows.Forms.Label lbl_desh1;
        private C1.Win.C1List.C1Combo cmb_seasonTo;
        public System.Windows.Forms.Label lbl_title;
    }
}
