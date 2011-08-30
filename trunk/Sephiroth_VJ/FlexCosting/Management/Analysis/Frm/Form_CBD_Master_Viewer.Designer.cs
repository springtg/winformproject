namespace FlexCosting.Management.Analysis.Frm
{
    partial class Form_CBD_Master_Viewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CBD_Master_Viewer));
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
            C1.Win.C1List.Style style17 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style18 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style19 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style20 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style21 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style22 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style23 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style24 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style25 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style26 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style27 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style28 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style29 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style30 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style31 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style32 = new C1.Win.C1List.Style();
            this.sizer_Main = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_SchPnl1 = new System.Windows.Forms.Panel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.txt_MOID = new System.Windows.Forms.TextBox();
            this.txt_BOMID = new System.Windows.Forms.TextBox();
            this.cmb_Season = new C1.Win.C1List.C1Combo();
            this.lbl_Season = new System.Windows.Forms.Label();
            this.lbl_MOID = new System.Windows.Forms.Label();
            this.lbl_BOMID = new System.Windows.Forms.Label();
            this.cmb_DPO = new C1.Win.C1List.C1Combo();
            this.lbl_DPO = new System.Windows.Forms.Label();
            this.cmb_ProdFac = new C1.Win.C1List.C1Combo();
            this.lbl_ProdFac = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_SchPnl2 = new FlexCosting.Basic.Ctl.SearchPanel();
            this.fgrid_head = new COM.FSP();
            this.ctx_head = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxt_excel = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_detail = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fgrid_upper = new COM.FSP();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fgrid_packaging = new COM.FSP();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fgrid_midsole = new COM.FSP();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.fgrid_outsole = new COM.FSP();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.fgrid_labor = new COM.FSP();
            this.pnl_laborComment = new System.Windows.Forms.Panel();
            this.txt_hLABOR_CMT = new System.Windows.Forms.TextBox();
            this.lbl_hLaborCmt = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.fgrid_overhead = new COM.FSP();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_hOVERHEAD_CMT = new System.Windows.Forms.TextBox();
            this.lbl_hOverheadCmt = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.pnl_CBDDetailSummary = new System.Windows.Forms.Panel();
            this.lbl_pct1 = new System.Windows.Forms.Label();
            this.txt_hPROFIT = new System.Windows.Forms.TextBox();
            this.txt_hLEAN_SAVE_TGT = new System.Windows.Forms.TextBox();
            this.txt_hTOT_FOB = new System.Windows.Forms.TextBox();
            this.txt_hTOT_TOOLING = new System.Windows.Forms.TextBox();
            this.txt_hSIZERUN = new System.Windows.Forms.TextBox();
            this.txt_hTOT_SIZERUN = new System.Windows.Forms.TextBox();
            this.txt_hOTHER_ADJUST = new System.Windows.Forms.TextBox();
            this.txt_hPROFIT_PCT = new System.Windows.Forms.TextBox();
            this.txt_hTOT_MLOS = new System.Windows.Forms.TextBox();
            this.lbl_hTotSizeRun = new System.Windows.Forms.Label();
            this.lbl_hSizeRun = new System.Windows.Forms.Label();
            this.lbl_hLean = new System.Windows.Forms.Label();
            this.lbl_hTotFOB = new System.Windows.Forms.Label();
            this.lbl_hTooling = new System.Windows.Forms.Label();
            this.lbl_hOtherAdj2 = new System.Windows.Forms.Label();
            this.lbl_hProfit2 = new System.Windows.Forms.Label();
            this.lbl_hTotMLOS = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.fgrid_sampMold = new COM.FSP();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.fgrid_prodMold = new COM.FSP();
            this.split_mef1 = new System.Windows.Forms.Splitter();
            this.fgrid_pm_meof_head = new COM.FSP();
            this.split_mef2 = new System.Windows.Forms.Splitter();
            this.fgrid_pm_meof_size = new COM.FSP();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.splitc_5523 = new System.Windows.Forms.SplitContainer();
            this.cmb_region = new C1.Win.C1List.C1Combo();
            this.lbl_region = new System.Windows.Forms.Label();
            this.txt_leather_5523 = new System.Windows.Forms.TextBox();
            this.txt_synthetic_5523 = new System.Windows.Forms.TextBox();
            this.txt_textile_5523 = new System.Windows.Forms.TextBox();
            this.txt_other_5523 = new System.Windows.Forms.TextBox();
            this.txt_devCode_5523 = new System.Windows.Forms.TextBox();
            this.txt_prodName_5523 = new System.Windows.Forms.TextBox();
            this.txt_prodType_5523 = new System.Windows.Forms.TextBox();
            this.txt_factory_5523 = new System.Windows.Forms.TextBox();
            this.txt_date_5523 = new System.Windows.Forms.TextBox();
            this.txt_season_5523 = new System.Windows.Forms.TextBox();
            this.txt_prodCode_5523 = new System.Windows.Forms.TextBox();
            this.lbl_other_5523 = new System.Windows.Forms.Label();
            this.lbl_textile_5523 = new System.Windows.Forms.Label();
            this.lbl_synthetic_5523 = new System.Windows.Forms.Label();
            this.lbl_leather_5523 = new System.Windows.Forms.Label();
            this.lbl_date_5523 = new System.Windows.Forms.Label();
            this.lbl_season_5523 = new System.Windows.Forms.Label();
            this.lbl_factory_5523 = new System.Windows.Forms.Label();
            this.lbl_prodType_5523 = new System.Windows.Forms.Label();
            this.lbl_prodName_5523 = new System.Windows.Forms.Label();
            this.lbl_devCode_5523 = new System.Windows.Forms.Label();
            this.lbl_prodCode_5523 = new System.Windows.Forms.Label();
            this.fgrid_5523 = new COM.FSP();
            this.timer_excel = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizer_Main)).BeginInit();
            this.sizer_Main.SuspendLayout();
            this.pnl_SchPnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_DPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ProdFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_head)).BeginInit();
            this.ctx_head.SuspendLayout();
            this.tab_detail.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_upper)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_packaging)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_midsole)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_outsole)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_labor)).BeginInit();
            this.pnl_laborComment.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_overhead)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.pnl_CBDDetailSummary.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_sampMold)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_prodMold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_pm_meof_head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_pm_meof_size)).BeginInit();
            this.tabPage10.SuspendLayout();
            this.splitc_5523.Panel1.SuspendLayout();
            this.splitc_5523.Panel2.SuspendLayout();
            this.splitc_5523.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_region)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_5523)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            this.img_Action.Images.SetKeyName(3, "btn_delete_n.gif");
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
            this.sizer_Main.Controls.Add(this.pnl_SchPnl1);
            this.sizer_Main.Controls.Add(this.fgrid_head);
            this.sizer_Main.Controls.Add(this.tab_detail);
            this.sizer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizer_Main.GridDefinition = "15.1877133105802:False:True;30.5460750853242:True:False;48.2935153583618:False:Fa" +
                "lse;2.55972696245734:False:True;\t0:False:True;98.4251968503937:False:False;0:Fal" +
                "se:True;";
            this.sizer_Main.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sizer_Main.Location = new System.Drawing.Point(0, 80);
            this.sizer_Main.Name = "sizer_Main";
            this.sizer_Main.Size = new System.Drawing.Size(1016, 586);
            this.sizer_Main.TabIndex = 37;
            this.sizer_Main.TabStop = false;
            // 
            // pnl_SchPnl1
            // 
            this.pnl_SchPnl1.Controls.Add(this.lbl_status);
            this.pnl_SchPnl1.Controls.Add(this.txt_MOID);
            this.pnl_SchPnl1.Controls.Add(this.txt_BOMID);
            this.pnl_SchPnl1.Controls.Add(this.cmb_Season);
            this.pnl_SchPnl1.Controls.Add(this.lbl_Season);
            this.pnl_SchPnl1.Controls.Add(this.lbl_MOID);
            this.pnl_SchPnl1.Controls.Add(this.lbl_BOMID);
            this.pnl_SchPnl1.Controls.Add(this.cmb_DPO);
            this.pnl_SchPnl1.Controls.Add(this.lbl_DPO);
            this.pnl_SchPnl1.Controls.Add(this.cmb_ProdFac);
            this.pnl_SchPnl1.Controls.Add(this.lbl_ProdFac);
            this.pnl_SchPnl1.Controls.Add(this.lbl_title);
            this.pnl_SchPnl1.Controls.Add(this.pnl_SchPnl2);
            this.pnl_SchPnl1.Location = new System.Drawing.Point(8, 4);
            this.pnl_SchPnl1.Name = "pnl_SchPnl1";
            this.pnl_SchPnl1.Size = new System.Drawing.Size(1004, 89);
            this.pnl_SchPnl1.TabIndex = 604;
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.lbl_status.Location = new System.Drawing.Point(630, 58);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(301, 21);
            this.lbl_status.TabIndex = 647;
            this.lbl_status.Tag = "0";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_MOID
            // 
            this.txt_MOID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MOID.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_MOID.Location = new System.Drawing.Point(109, 58);
            this.txt_MOID.MaxLength = 40;
            this.txt_MOID.Name = "txt_MOID";
            this.txt_MOID.Size = new System.Drawing.Size(200, 21);
            this.txt_MOID.TabIndex = 646;
            this.txt_MOID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SearchText_KeyUp);
            // 
            // txt_BOMID
            // 
            this.txt_BOMID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BOMID.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_BOMID.Location = new System.Drawing.Point(420, 58);
            this.txt_BOMID.MaxLength = 40;
            this.txt_BOMID.Name = "txt_BOMID";
            this.txt_BOMID.Size = new System.Drawing.Size(200, 21);
            this.txt_BOMID.TabIndex = 645;
            this.txt_BOMID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SearchText_KeyUp);
            // 
            // cmb_Season
            // 
            this.cmb_Season.AddItemSeparator = ';';
            this.cmb_Season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Season.Caption = "";
            this.cmb_Season.CaptionHeight = 17;
            this.cmb_Season.CaptionStyle = style1;
            this.cmb_Season.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Season.ColumnCaptionHeight = 18;
            this.cmb_Season.ColumnFooterHeight = 18;
            this.cmb_Season.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Season.ContentHeight = 17;
            this.cmb_Season.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Season.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Season.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Season.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Season.EditorHeight = 17;
            this.cmb_Season.EvenRowStyle = style2;
            this.cmb_Season.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Season.FooterStyle = style3;
            this.cmb_Season.HeadingStyle = style4;
            this.cmb_Season.HighLightRowStyle = style5;
            this.cmb_Season.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Season.Images"))));
            this.cmb_Season.ItemHeight = 15;
            this.cmb_Season.Location = new System.Drawing.Point(420, 36);
            this.cmb_Season.MatchEntryTimeout = ((long)(2000));
            this.cmb_Season.MaxDropDownItems = ((short)(5));
            this.cmb_Season.MaxLength = 32767;
            this.cmb_Season.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Season.Name = "cmb_Season";
            this.cmb_Season.OddRowStyle = style6;
            this.cmb_Season.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Season.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Season.SelectedStyle = style7;
            this.cmb_Season.Size = new System.Drawing.Size(200, 21);
            this.cmb_Season.Style = style8;
            this.cmb_Season.TabIndex = 644;
            this.cmb_Season.SelectedValueChanged += new System.EventHandler(this.cmb_Season_SelectedValueChanged);
            this.cmb_Season.PropBag = resources.GetString("cmb_Season.PropBag");
            // 
            // lbl_Season
            // 
            this.lbl_Season.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Season.ImageIndex = 0;
            this.lbl_Season.ImageList = this.img_Label;
            this.lbl_Season.Location = new System.Drawing.Point(319, 36);
            this.lbl_Season.Name = "lbl_Season";
            this.lbl_Season.Size = new System.Drawing.Size(100, 21);
            this.lbl_Season.TabIndex = 643;
            this.lbl_Season.Tag = "0";
            this.lbl_Season.Text = "Season";
            this.lbl_Season.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_MOID
            // 
            this.lbl_MOID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MOID.ImageIndex = 0;
            this.lbl_MOID.ImageList = this.img_Label;
            this.lbl_MOID.Location = new System.Drawing.Point(8, 58);
            this.lbl_MOID.Name = "lbl_MOID";
            this.lbl_MOID.Size = new System.Drawing.Size(100, 21);
            this.lbl_MOID.TabIndex = 641;
            this.lbl_MOID.Tag = "0";
            this.lbl_MOID.Text = "MOID";
            this.lbl_MOID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_BOMID
            // 
            this.lbl_BOMID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BOMID.ImageIndex = 0;
            this.lbl_BOMID.ImageList = this.img_Label;
            this.lbl_BOMID.Location = new System.Drawing.Point(319, 58);
            this.lbl_BOMID.Name = "lbl_BOMID";
            this.lbl_BOMID.Size = new System.Drawing.Size(100, 21);
            this.lbl_BOMID.TabIndex = 600;
            this.lbl_BOMID.Tag = "0";
            this.lbl_BOMID.Text = "BOM ID";
            this.lbl_BOMID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_DPO
            // 
            this.cmb_DPO.AddItemSeparator = ';';
            this.cmb_DPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_DPO.Caption = "";
            this.cmb_DPO.CaptionHeight = 17;
            this.cmb_DPO.CaptionStyle = style9;
            this.cmb_DPO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_DPO.ColumnCaptionHeight = 18;
            this.cmb_DPO.ColumnFooterHeight = 18;
            this.cmb_DPO.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_DPO.ContentHeight = 17;
            this.cmb_DPO.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_DPO.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_DPO.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_DPO.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_DPO.EditorHeight = 17;
            this.cmb_DPO.EvenRowStyle = style10;
            this.cmb_DPO.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_DPO.FooterStyle = style11;
            this.cmb_DPO.HeadingStyle = style12;
            this.cmb_DPO.HighLightRowStyle = style13;
            this.cmb_DPO.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_DPO.Images"))));
            this.cmb_DPO.ItemHeight = 15;
            this.cmb_DPO.Location = new System.Drawing.Point(731, 36);
            this.cmb_DPO.MatchEntryTimeout = ((long)(2000));
            this.cmb_DPO.MaxDropDownItems = ((short)(5));
            this.cmb_DPO.MaxLength = 32767;
            this.cmb_DPO.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_DPO.Name = "cmb_DPO";
            this.cmb_DPO.OddRowStyle = style14;
            this.cmb_DPO.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_DPO.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_DPO.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_DPO.SelectedStyle = style15;
            this.cmb_DPO.Size = new System.Drawing.Size(200, 21);
            this.cmb_DPO.Style = style16;
            this.cmb_DPO.TabIndex = 599;
            this.cmb_DPO.SelectedValueChanged += new System.EventHandler(this.cmb_DPO_SelectedValueChanged);
            this.cmb_DPO.PropBag = resources.GetString("cmb_DPO.PropBag");
            // 
            // lbl_DPO
            // 
            this.lbl_DPO.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DPO.ImageIndex = 0;
            this.lbl_DPO.ImageList = this.img_Label;
            this.lbl_DPO.Location = new System.Drawing.Point(630, 36);
            this.lbl_DPO.Name = "lbl_DPO";
            this.lbl_DPO.Size = new System.Drawing.Size(100, 21);
            this.lbl_DPO.TabIndex = 598;
            this.lbl_DPO.Tag = "0";
            this.lbl_DPO.Text = "DPO";
            this.lbl_DPO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_ProdFac
            // 
            this.cmb_ProdFac.AddItemSeparator = ';';
            this.cmb_ProdFac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ProdFac.Caption = "";
            this.cmb_ProdFac.CaptionHeight = 17;
            this.cmb_ProdFac.CaptionStyle = style17;
            this.cmb_ProdFac.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_ProdFac.ColumnCaptionHeight = 18;
            this.cmb_ProdFac.ColumnFooterHeight = 18;
            this.cmb_ProdFac.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_ProdFac.ContentHeight = 17;
            this.cmb_ProdFac.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_ProdFac.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_ProdFac.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ProdFac.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_ProdFac.EditorHeight = 17;
            this.cmb_ProdFac.EvenRowStyle = style18;
            this.cmb_ProdFac.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ProdFac.FooterStyle = style19;
            this.cmb_ProdFac.HeadingStyle = style20;
            this.cmb_ProdFac.HighLightRowStyle = style21;
            this.cmb_ProdFac.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_ProdFac.Images"))));
            this.cmb_ProdFac.ItemHeight = 15;
            this.cmb_ProdFac.Location = new System.Drawing.Point(109, 36);
            this.cmb_ProdFac.MatchEntryTimeout = ((long)(2000));
            this.cmb_ProdFac.MaxDropDownItems = ((short)(5));
            this.cmb_ProdFac.MaxLength = 32767;
            this.cmb_ProdFac.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ProdFac.Name = "cmb_ProdFac";
            this.cmb_ProdFac.OddRowStyle = style22;
            this.cmb_ProdFac.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ProdFac.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ProdFac.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ProdFac.SelectedStyle = style23;
            this.cmb_ProdFac.Size = new System.Drawing.Size(200, 21);
            this.cmb_ProdFac.Style = style24;
            this.cmb_ProdFac.TabIndex = 597;
            this.cmb_ProdFac.SelectedValueChanged += new System.EventHandler(this.cmb_ProdFac_SelectedValueChanged);
            this.cmb_ProdFac.PropBag = resources.GetString("cmb_ProdFac.PropBag");
            // 
            // lbl_ProdFac
            // 
            this.lbl_ProdFac.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProdFac.ImageIndex = 0;
            this.lbl_ProdFac.ImageList = this.img_Label;
            this.lbl_ProdFac.Location = new System.Drawing.Point(8, 36);
            this.lbl_ProdFac.Name = "lbl_ProdFac";
            this.lbl_ProdFac.Size = new System.Drawing.Size(100, 21);
            this.lbl_ProdFac.TabIndex = 596;
            this.lbl_ProdFac.Tag = "0";
            this.lbl_ProdFac.Text = "Prod Fac.";
            this.lbl_ProdFac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // pnl_SchPnl2
            // 
            this.pnl_SchPnl2.BackColor = System.Drawing.Color.Transparent;
            this.pnl_SchPnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SchPnl2.Location = new System.Drawing.Point(0, 0);
            this.pnl_SchPnl2.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_SchPnl2.Name = "pnl_SchPnl2";
            this.pnl_SchPnl2.Size = new System.Drawing.Size(1004, 89);
            this.pnl_SchPnl2.TabIndex = 0;
            // 
            // fgrid_head
            // 
            this.fgrid_head.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_head.ContextMenuStrip = this.ctx_head;
            this.fgrid_head.Location = new System.Drawing.Point(8, 97);
            this.fgrid_head.Name = "fgrid_head";
            this.fgrid_head.Rows.DefaultSize = 19;
            this.fgrid_head.Size = new System.Drawing.Size(1000, 179);
            this.fgrid_head.StyleInfo = resources.GetString("fgrid_head.StyleInfo");
            this.fgrid_head.TabIndex = 603;
            this.fgrid_head.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fgrid_head_MouseDoubleClick);
            // 
            // ctx_head
            // 
            this.ctx_head.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxt_excel});
            this.ctx_head.Name = "ctx_head";
            this.ctx_head.Size = new System.Drawing.Size(152, 26);
            // 
            // ctxt_excel
            // 
            this.ctxt_excel.Name = "ctxt_excel";
            this.ctxt_excel.Size = new System.Drawing.Size(151, 22);
            this.ctxt_excel.Text = "Export excel ";
            this.ctxt_excel.Click += new System.EventHandler(this.ctxt_exl_Click);
            // 
            // tab_detail
            // 
            this.tab_detail.Controls.Add(this.tabPage1);
            this.tab_detail.Controls.Add(this.tabPage2);
            this.tab_detail.Controls.Add(this.tabPage3);
            this.tab_detail.Controls.Add(this.tabPage4);
            this.tab_detail.Controls.Add(this.tabPage5);
            this.tab_detail.Controls.Add(this.tabPage6);
            this.tab_detail.Controls.Add(this.tabPage7);
            this.tab_detail.Controls.Add(this.tabPage8);
            this.tab_detail.Controls.Add(this.tabPage9);
            this.tab_detail.Controls.Add(this.tabPage10);
            this.tab_detail.Location = new System.Drawing.Point(8, 280);
            this.tab_detail.Name = "tab_detail";
            this.tab_detail.SelectedIndex = 0;
            this.tab_detail.Size = new System.Drawing.Size(1004, 283);
            this.tab_detail.TabIndex = 602;
            this.tab_detail.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tab_detail_MouseUp);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.fgrid_upper);
            this.tabPage1.Font = new System.Drawing.Font("굴림", 8F);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(996, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "UPPER";
            this.tabPage1.Text = "UPPER";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // fgrid_upper
            // 
            this.fgrid_upper.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.fgrid_upper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_upper.EditOptions = ((C1.Win.C1FlexGrid.EditFlags)((((C1.Win.C1FlexGrid.EditFlags.AutoSearch | C1.Win.C1FlexGrid.EditFlags.CycleOnDoubleClick)
                        | C1.Win.C1FlexGrid.EditFlags.MultiCheck)
                        | C1.Win.C1FlexGrid.EditFlags.DelayedCommit)));
            this.fgrid_upper.Location = new System.Drawing.Point(0, 0);
            this.fgrid_upper.Name = "fgrid_upper";
            this.fgrid_upper.Rows.DefaultSize = 17;
            this.fgrid_upper.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.Always;
            this.fgrid_upper.Size = new System.Drawing.Size(996, 256);
            this.fgrid_upper.StyleInfo = resources.GetString("fgrid_upper.StyleInfo");
            this.fgrid_upper.TabIndex = 1003;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fgrid_packaging);
            this.tabPage2.Font = new System.Drawing.Font("굴림", 8F);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(996, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "PACKAGING";
            this.tabPage2.Text = "PACKAGING";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fgrid_packaging
            // 
            this.fgrid_packaging.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.fgrid_packaging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_packaging.EditOptions = ((C1.Win.C1FlexGrid.EditFlags)((((C1.Win.C1FlexGrid.EditFlags.AutoSearch | C1.Win.C1FlexGrid.EditFlags.CycleOnDoubleClick)
                        | C1.Win.C1FlexGrid.EditFlags.MultiCheck)
                        | C1.Win.C1FlexGrid.EditFlags.DelayedCommit)));
            this.fgrid_packaging.Location = new System.Drawing.Point(0, 0);
            this.fgrid_packaging.Name = "fgrid_packaging";
            this.fgrid_packaging.Rows.DefaultSize = 17;
            this.fgrid_packaging.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.Always;
            this.fgrid_packaging.Size = new System.Drawing.Size(996, 256);
            this.fgrid_packaging.StyleInfo = resources.GetString("fgrid_packaging.StyleInfo");
            this.fgrid_packaging.TabIndex = 1005;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.fgrid_midsole);
            this.tabPage3.Font = new System.Drawing.Font("굴림", 8F);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(996, 256);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Tag = "MIDSOLE";
            this.tabPage3.Text = "MIDSOLE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // fgrid_midsole
            // 
            this.fgrid_midsole.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.fgrid_midsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_midsole.EditOptions = ((C1.Win.C1FlexGrid.EditFlags)((((C1.Win.C1FlexGrid.EditFlags.AutoSearch | C1.Win.C1FlexGrid.EditFlags.CycleOnDoubleClick)
                        | C1.Win.C1FlexGrid.EditFlags.MultiCheck)
                        | C1.Win.C1FlexGrid.EditFlags.DelayedCommit)));
            this.fgrid_midsole.Location = new System.Drawing.Point(0, 0);
            this.fgrid_midsole.Name = "fgrid_midsole";
            this.fgrid_midsole.Rows.DefaultSize = 17;
            this.fgrid_midsole.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_midsole.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.Always;
            this.fgrid_midsole.Size = new System.Drawing.Size(996, 256);
            this.fgrid_midsole.StyleInfo = resources.GetString("fgrid_midsole.StyleInfo");
            this.fgrid_midsole.TabIndex = 1007;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.fgrid_outsole);
            this.tabPage4.Font = new System.Drawing.Font("굴림", 8F);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(996, 256);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Tag = "OUTSOLE";
            this.tabPage4.Text = "OUTSOLE";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // fgrid_outsole
            // 
            this.fgrid_outsole.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.fgrid_outsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_outsole.EditOptions = ((C1.Win.C1FlexGrid.EditFlags)((((C1.Win.C1FlexGrid.EditFlags.AutoSearch | C1.Win.C1FlexGrid.EditFlags.CycleOnDoubleClick)
                        | C1.Win.C1FlexGrid.EditFlags.MultiCheck)
                        | C1.Win.C1FlexGrid.EditFlags.DelayedCommit)));
            this.fgrid_outsole.Location = new System.Drawing.Point(0, 0);
            this.fgrid_outsole.Name = "fgrid_outsole";
            this.fgrid_outsole.Rows.DefaultSize = 17;
            this.fgrid_outsole.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_outsole.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.Always;
            this.fgrid_outsole.Size = new System.Drawing.Size(996, 256);
            this.fgrid_outsole.StyleInfo = resources.GetString("fgrid_outsole.StyleInfo");
            this.fgrid_outsole.TabIndex = 1009;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.fgrid_labor);
            this.tabPage5.Controls.Add(this.pnl_laborComment);
            this.tabPage5.Font = new System.Drawing.Font("굴림", 8F);
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(996, 256);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Tag = "LABOR";
            this.tabPage5.Text = "LABOR";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // fgrid_labor
            // 
            this.fgrid_labor.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.fgrid_labor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_labor.EditOptions = ((C1.Win.C1FlexGrid.EditFlags)((((C1.Win.C1FlexGrid.EditFlags.AutoSearch | C1.Win.C1FlexGrid.EditFlags.CycleOnDoubleClick)
                        | C1.Win.C1FlexGrid.EditFlags.MultiCheck)
                        | C1.Win.C1FlexGrid.EditFlags.DelayedCommit)));
            this.fgrid_labor.Location = new System.Drawing.Point(0, 0);
            this.fgrid_labor.Name = "fgrid_labor";
            this.fgrid_labor.Rows.DefaultSize = 17;
            this.fgrid_labor.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_labor.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.Always;
            this.fgrid_labor.Size = new System.Drawing.Size(996, 226);
            this.fgrid_labor.StyleInfo = resources.GetString("fgrid_labor.StyleInfo");
            this.fgrid_labor.TabIndex = 1011;
            // 
            // pnl_laborComment
            // 
            this.pnl_laborComment.Controls.Add(this.txt_hLABOR_CMT);
            this.pnl_laborComment.Controls.Add(this.lbl_hLaborCmt);
            this.pnl_laborComment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_laborComment.Location = new System.Drawing.Point(0, 226);
            this.pnl_laborComment.Name = "pnl_laborComment";
            this.pnl_laborComment.Size = new System.Drawing.Size(996, 30);
            this.pnl_laborComment.TabIndex = 1012;
            // 
            // txt_hLABOR_CMT
            // 
            this.txt_hLABOR_CMT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_hLABOR_CMT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hLABOR_CMT.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_hLABOR_CMT.Location = new System.Drawing.Point(208, 4);
            this.txt_hLABOR_CMT.MaxLength = 40;
            this.txt_hLABOR_CMT.Name = "txt_hLABOR_CMT";
            this.txt_hLABOR_CMT.ReadOnly = true;
            this.txt_hLABOR_CMT.Size = new System.Drawing.Size(300, 20);
            this.txt_hLABOR_CMT.TabIndex = 731;
            // 
            // lbl_hLaborCmt
            // 
            this.lbl_hLaborCmt.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_hLaborCmt.Location = new System.Drawing.Point(8, 4);
            this.lbl_hLaborCmt.Name = "lbl_hLaborCmt";
            this.lbl_hLaborCmt.Size = new System.Drawing.Size(200, 21);
            this.lbl_hLaborCmt.TabIndex = 730;
            this.lbl_hLaborCmt.Tag = "0";
            this.lbl_hLaborCmt.Text = "LABOR COMMENTS";
            this.lbl_hLaborCmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.fgrid_overhead);
            this.tabPage6.Controls.Add(this.panel2);
            this.tabPage6.Font = new System.Drawing.Font("굴림", 8F);
            this.tabPage6.Location = new System.Drawing.Point(4, 23);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(996, 256);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Tag = "OVERHEAD";
            this.tabPage6.Text = "OVERHEAD";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // fgrid_overhead
            // 
            this.fgrid_overhead.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.fgrid_overhead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_overhead.EditOptions = ((C1.Win.C1FlexGrid.EditFlags)((((C1.Win.C1FlexGrid.EditFlags.AutoSearch | C1.Win.C1FlexGrid.EditFlags.CycleOnDoubleClick)
                        | C1.Win.C1FlexGrid.EditFlags.MultiCheck)
                        | C1.Win.C1FlexGrid.EditFlags.DelayedCommit)));
            this.fgrid_overhead.Location = new System.Drawing.Point(0, 0);
            this.fgrid_overhead.Name = "fgrid_overhead";
            this.fgrid_overhead.Rows.DefaultSize = 17;
            this.fgrid_overhead.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_overhead.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.Always;
            this.fgrid_overhead.Size = new System.Drawing.Size(996, 226);
            this.fgrid_overhead.StyleInfo = resources.GetString("fgrid_overhead.StyleInfo");
            this.fgrid_overhead.TabIndex = 1013;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_hOVERHEAD_CMT);
            this.panel2.Controls.Add(this.lbl_hOverheadCmt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 30);
            this.panel2.TabIndex = 1014;
            // 
            // txt_hOVERHEAD_CMT
            // 
            this.txt_hOVERHEAD_CMT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_hOVERHEAD_CMT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hOVERHEAD_CMT.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_hOVERHEAD_CMT.Location = new System.Drawing.Point(208, 4);
            this.txt_hOVERHEAD_CMT.MaxLength = 40;
            this.txt_hOVERHEAD_CMT.Name = "txt_hOVERHEAD_CMT";
            this.txt_hOVERHEAD_CMT.ReadOnly = true;
            this.txt_hOVERHEAD_CMT.Size = new System.Drawing.Size(300, 20);
            this.txt_hOVERHEAD_CMT.TabIndex = 731;
            // 
            // lbl_hOverheadCmt
            // 
            this.lbl_hOverheadCmt.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_hOverheadCmt.Location = new System.Drawing.Point(8, 4);
            this.lbl_hOverheadCmt.Name = "lbl_hOverheadCmt";
            this.lbl_hOverheadCmt.Size = new System.Drawing.Size(200, 21);
            this.lbl_hOverheadCmt.TabIndex = 730;
            this.lbl_hOverheadCmt.Tag = "0";
            this.lbl_hOverheadCmt.Text = "OVERHEAD COMMENTS";
            this.lbl_hOverheadCmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.pnl_CBDDetailSummary);
            this.tabPage7.Font = new System.Drawing.Font("굴림", 8F);
            this.tabPage7.Location = new System.Drawing.Point(4, 23);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(996, 256);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Tag = "ETC";
            this.tabPage7.Text = "ETC";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // pnl_CBDDetailSummary
            // 
            this.pnl_CBDDetailSummary.AutoScroll = true;
            this.pnl_CBDDetailSummary.BackColor = System.Drawing.Color.White;
            this.pnl_CBDDetailSummary.Controls.Add(this.lbl_pct1);
            this.pnl_CBDDetailSummary.Controls.Add(this.txt_hPROFIT);
            this.pnl_CBDDetailSummary.Controls.Add(this.txt_hLEAN_SAVE_TGT);
            this.pnl_CBDDetailSummary.Controls.Add(this.txt_hTOT_FOB);
            this.pnl_CBDDetailSummary.Controls.Add(this.txt_hTOT_TOOLING);
            this.pnl_CBDDetailSummary.Controls.Add(this.txt_hSIZERUN);
            this.pnl_CBDDetailSummary.Controls.Add(this.txt_hTOT_SIZERUN);
            this.pnl_CBDDetailSummary.Controls.Add(this.txt_hOTHER_ADJUST);
            this.pnl_CBDDetailSummary.Controls.Add(this.txt_hPROFIT_PCT);
            this.pnl_CBDDetailSummary.Controls.Add(this.txt_hTOT_MLOS);
            this.pnl_CBDDetailSummary.Controls.Add(this.lbl_hTotSizeRun);
            this.pnl_CBDDetailSummary.Controls.Add(this.lbl_hSizeRun);
            this.pnl_CBDDetailSummary.Controls.Add(this.lbl_hLean);
            this.pnl_CBDDetailSummary.Controls.Add(this.lbl_hTotFOB);
            this.pnl_CBDDetailSummary.Controls.Add(this.lbl_hTooling);
            this.pnl_CBDDetailSummary.Controls.Add(this.lbl_hOtherAdj2);
            this.pnl_CBDDetailSummary.Controls.Add(this.lbl_hProfit2);
            this.pnl_CBDDetailSummary.Controls.Add(this.lbl_hTotMLOS);
            this.pnl_CBDDetailSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_CBDDetailSummary.Location = new System.Drawing.Point(0, 0);
            this.pnl_CBDDetailSummary.Name = "pnl_CBDDetailSummary";
            this.pnl_CBDDetailSummary.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.pnl_CBDDetailSummary.Size = new System.Drawing.Size(996, 256);
            this.pnl_CBDDetailSummary.TabIndex = 1014;
            // 
            // lbl_pct1
            // 
            this.lbl_pct1.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_pct1.Location = new System.Drawing.Point(447, 32);
            this.lbl_pct1.Name = "lbl_pct1";
            this.lbl_pct1.Size = new System.Drawing.Size(20, 17);
            this.lbl_pct1.TabIndex = 749;
            this.lbl_pct1.Tag = "0";
            this.lbl_pct1.Text = "%";
            this.lbl_pct1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_hPROFIT
            // 
            this.txt_hPROFIT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_hPROFIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hPROFIT.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_hPROFIT.Location = new System.Drawing.Point(308, 30);
            this.txt_hPROFIT.MaxLength = 40;
            this.txt_hPROFIT.Name = "txt_hPROFIT";
            this.txt_hPROFIT.ReadOnly = true;
            this.txt_hPROFIT.Size = new System.Drawing.Size(69, 20);
            this.txt_hPROFIT.TabIndex = 747;
            this.txt_hPROFIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_hLEAN_SAVE_TGT
            // 
            this.txt_hLEAN_SAVE_TGT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_hLEAN_SAVE_TGT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hLEAN_SAVE_TGT.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_hLEAN_SAVE_TGT.Location = new System.Drawing.Point(308, 118);
            this.txt_hLEAN_SAVE_TGT.MaxLength = 40;
            this.txt_hLEAN_SAVE_TGT.Name = "txt_hLEAN_SAVE_TGT";
            this.txt_hLEAN_SAVE_TGT.ReadOnly = true;
            this.txt_hLEAN_SAVE_TGT.Size = new System.Drawing.Size(69, 20);
            this.txt_hLEAN_SAVE_TGT.TabIndex = 746;
            this.txt_hLEAN_SAVE_TGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_hTOT_FOB
            // 
            this.txt_hTOT_FOB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_hTOT_FOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hTOT_FOB.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_hTOT_FOB.Location = new System.Drawing.Point(308, 96);
            this.txt_hTOT_FOB.MaxLength = 40;
            this.txt_hTOT_FOB.Name = "txt_hTOT_FOB";
            this.txt_hTOT_FOB.ReadOnly = true;
            this.txt_hTOT_FOB.Size = new System.Drawing.Size(69, 20);
            this.txt_hTOT_FOB.TabIndex = 745;
            this.txt_hTOT_FOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_hTOT_TOOLING
            // 
            this.txt_hTOT_TOOLING.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_hTOT_TOOLING.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hTOT_TOOLING.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_hTOT_TOOLING.Location = new System.Drawing.Point(308, 74);
            this.txt_hTOT_TOOLING.MaxLength = 40;
            this.txt_hTOT_TOOLING.Name = "txt_hTOT_TOOLING";
            this.txt_hTOT_TOOLING.ReadOnly = true;
            this.txt_hTOT_TOOLING.Size = new System.Drawing.Size(69, 20);
            this.txt_hTOT_TOOLING.TabIndex = 744;
            this.txt_hTOT_TOOLING.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_hSIZERUN
            // 
            this.txt_hSIZERUN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_hSIZERUN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hSIZERUN.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_hSIZERUN.Location = new System.Drawing.Point(308, 152);
            this.txt_hSIZERUN.MaxLength = 40;
            this.txt_hSIZERUN.Name = "txt_hSIZERUN";
            this.txt_hSIZERUN.ReadOnly = true;
            this.txt_hSIZERUN.Size = new System.Drawing.Size(69, 20);
            this.txt_hSIZERUN.TabIndex = 743;
            this.txt_hSIZERUN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_hTOT_SIZERUN
            // 
            this.txt_hTOT_SIZERUN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_hTOT_SIZERUN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hTOT_SIZERUN.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_hTOT_SIZERUN.Location = new System.Drawing.Point(308, 174);
            this.txt_hTOT_SIZERUN.MaxLength = 40;
            this.txt_hTOT_SIZERUN.Name = "txt_hTOT_SIZERUN";
            this.txt_hTOT_SIZERUN.ReadOnly = true;
            this.txt_hTOT_SIZERUN.Size = new System.Drawing.Size(69, 20);
            this.txt_hTOT_SIZERUN.TabIndex = 742;
            this.txt_hTOT_SIZERUN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_hOTHER_ADJUST
            // 
            this.txt_hOTHER_ADJUST.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_hOTHER_ADJUST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hOTHER_ADJUST.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_hOTHER_ADJUST.Location = new System.Drawing.Point(308, 52);
            this.txt_hOTHER_ADJUST.MaxLength = 40;
            this.txt_hOTHER_ADJUST.Name = "txt_hOTHER_ADJUST";
            this.txt_hOTHER_ADJUST.ReadOnly = true;
            this.txt_hOTHER_ADJUST.Size = new System.Drawing.Size(69, 20);
            this.txt_hOTHER_ADJUST.TabIndex = 741;
            this.txt_hOTHER_ADJUST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_hPROFIT_PCT
            // 
            this.txt_hPROFIT_PCT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_hPROFIT_PCT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hPROFIT_PCT.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_hPROFIT_PCT.Location = new System.Drawing.Point(378, 30);
            this.txt_hPROFIT_PCT.MaxLength = 40;
            this.txt_hPROFIT_PCT.Name = "txt_hPROFIT_PCT";
            this.txt_hPROFIT_PCT.ReadOnly = true;
            this.txt_hPROFIT_PCT.Size = new System.Drawing.Size(69, 20);
            this.txt_hPROFIT_PCT.TabIndex = 740;
            this.txt_hPROFIT_PCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_hTOT_MLOS
            // 
            this.txt_hTOT_MLOS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_hTOT_MLOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hTOT_MLOS.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_hTOT_MLOS.Location = new System.Drawing.Point(308, 8);
            this.txt_hTOT_MLOS.MaxLength = 40;
            this.txt_hTOT_MLOS.Name = "txt_hTOT_MLOS";
            this.txt_hTOT_MLOS.ReadOnly = true;
            this.txt_hTOT_MLOS.Size = new System.Drawing.Size(69, 20);
            this.txt_hTOT_MLOS.TabIndex = 739;
            this.txt_hTOT_MLOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_hTotSizeRun
            // 
            this.lbl_hTotSizeRun.Font = new System.Drawing.Font("Verdana", 7F);
            this.lbl_hTotSizeRun.Location = new System.Drawing.Point(8, 174);
            this.lbl_hTotSizeRun.Name = "lbl_hTotSizeRun";
            this.lbl_hTotSizeRun.Size = new System.Drawing.Size(200, 17);
            this.lbl_hTotSizeRun.TabIndex = 738;
            this.lbl_hTotSizeRun.Tag = "0";
            this.lbl_hTotSizeRun.Text = "TOTAL SIZE RUN";
            this.lbl_hTotSizeRun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_hSizeRun
            // 
            this.lbl_hSizeRun.Font = new System.Drawing.Font("Verdana", 7F);
            this.lbl_hSizeRun.Location = new System.Drawing.Point(8, 152);
            this.lbl_hSizeRun.Name = "lbl_hSizeRun";
            this.lbl_hSizeRun.Size = new System.Drawing.Size(200, 17);
            this.lbl_hSizeRun.TabIndex = 737;
            this.lbl_hSizeRun.Tag = "0";
            this.lbl_hSizeRun.Text = "SIZE RUN";
            this.lbl_hSizeRun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_hLean
            // 
            this.lbl_hLean.Font = new System.Drawing.Font("Verdana", 7F);
            this.lbl_hLean.Location = new System.Drawing.Point(8, 118);
            this.lbl_hLean.Name = "lbl_hLean";
            this.lbl_hLean.Size = new System.Drawing.Size(300, 17);
            this.lbl_hLean.TabIndex = 735;
            this.lbl_hLean.Tag = "0";
            this.lbl_hLean.Text = "LEAN SAVINGS TARGET";
            this.lbl_hLean.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_hTotFOB
            // 
            this.lbl_hTotFOB.Font = new System.Drawing.Font("Verdana", 7F);
            this.lbl_hTotFOB.Location = new System.Drawing.Point(8, 96);
            this.lbl_hTotFOB.Name = "lbl_hTotFOB";
            this.lbl_hTotFOB.Size = new System.Drawing.Size(300, 17);
            this.lbl_hTotFOB.TabIndex = 734;
            this.lbl_hTotFOB.Tag = "0";
            this.lbl_hTotFOB.Text = "TOTAL FOB";
            this.lbl_hTotFOB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_hTooling
            // 
            this.lbl_hTooling.Font = new System.Drawing.Font("Verdana", 7F);
            this.lbl_hTooling.Location = new System.Drawing.Point(8, 74);
            this.lbl_hTooling.Name = "lbl_hTooling";
            this.lbl_hTooling.Size = new System.Drawing.Size(300, 17);
            this.lbl_hTooling.TabIndex = 733;
            this.lbl_hTooling.Tag = "0";
            this.lbl_hTooling.Text = "TOOLING (SAMPLE + PRODUCTION MOLDS)";
            this.lbl_hTooling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_hOtherAdj2
            // 
            this.lbl_hOtherAdj2.Font = new System.Drawing.Font("Verdana", 7F);
            this.lbl_hOtherAdj2.Location = new System.Drawing.Point(8, 52);
            this.lbl_hOtherAdj2.Name = "lbl_hOtherAdj2";
            this.lbl_hOtherAdj2.Size = new System.Drawing.Size(300, 17);
            this.lbl_hOtherAdj2.TabIndex = 732;
            this.lbl_hOtherAdj2.Tag = "0";
            this.lbl_hOtherAdj2.Text = "OTHER ADJUSTMENTS";
            this.lbl_hOtherAdj2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_hProfit2
            // 
            this.lbl_hProfit2.Font = new System.Drawing.Font("Verdana", 7F);
            this.lbl_hProfit2.Location = new System.Drawing.Point(8, 30);
            this.lbl_hProfit2.Name = "lbl_hProfit2";
            this.lbl_hProfit2.Size = new System.Drawing.Size(300, 17);
            this.lbl_hProfit2.TabIndex = 731;
            this.lbl_hProfit2.Tag = "0";
            this.lbl_hProfit2.Text = "PROFIT";
            this.lbl_hProfit2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_hTotMLOS
            // 
            this.lbl_hTotMLOS.Font = new System.Drawing.Font("Verdana", 7F);
            this.lbl_hTotMLOS.Location = new System.Drawing.Point(8, 8);
            this.lbl_hTotMLOS.Name = "lbl_hTotMLOS";
            this.lbl_hTotMLOS.Size = new System.Drawing.Size(300, 17);
            this.lbl_hTotMLOS.TabIndex = 730;
            this.lbl_hTotMLOS.Tag = "0";
            this.lbl_hTotMLOS.Text = "TOTAL MATERIALS, LABOR, OVERHEAD, SIZE UP";
            this.lbl_hTotMLOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.fgrid_sampMold);
            this.tabPage8.Font = new System.Drawing.Font("굴림", 8F);
            this.tabPage8.Location = new System.Drawing.Point(4, 23);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(996, 256);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Tag = "SAMPLE MOLD";
            this.tabPage8.Text = "SAMPLE MOLD";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // fgrid_sampMold
            // 
            this.fgrid_sampMold.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.fgrid_sampMold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_sampMold.EditOptions = ((C1.Win.C1FlexGrid.EditFlags)((((C1.Win.C1FlexGrid.EditFlags.AutoSearch | C1.Win.C1FlexGrid.EditFlags.CycleOnDoubleClick)
                        | C1.Win.C1FlexGrid.EditFlags.MultiCheck)
                        | C1.Win.C1FlexGrid.EditFlags.DelayedCommit)));
            this.fgrid_sampMold.Location = new System.Drawing.Point(0, 0);
            this.fgrid_sampMold.Name = "fgrid_sampMold";
            this.fgrid_sampMold.Rows.DefaultSize = 17;
            this.fgrid_sampMold.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_sampMold.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.Always;
            this.fgrid_sampMold.Size = new System.Drawing.Size(996, 256);
            this.fgrid_sampMold.StyleInfo = resources.GetString("fgrid_sampMold.StyleInfo");
            this.fgrid_sampMold.TabIndex = 1016;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.fgrid_prodMold);
            this.tabPage9.Controls.Add(this.split_mef1);
            this.tabPage9.Controls.Add(this.fgrid_pm_meof_head);
            this.tabPage9.Controls.Add(this.split_mef2);
            this.tabPage9.Controls.Add(this.fgrid_pm_meof_size);
            this.tabPage9.Font = new System.Drawing.Font("굴림", 8F);
            this.tabPage9.Location = new System.Drawing.Point(4, 23);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(996, 256);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Tag = "PRODUCTION MOLD";
            this.tabPage9.Text = "PRODUCTION MOLD";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // fgrid_prodMold
            // 
            this.fgrid_prodMold.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.fgrid_prodMold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_prodMold.EditOptions = ((C1.Win.C1FlexGrid.EditFlags)((((C1.Win.C1FlexGrid.EditFlags.AutoSearch | C1.Win.C1FlexGrid.EditFlags.CycleOnDoubleClick)
                        | C1.Win.C1FlexGrid.EditFlags.MultiCheck)
                        | C1.Win.C1FlexGrid.EditFlags.DelayedCommit)));
            this.fgrid_prodMold.Location = new System.Drawing.Point(0, 0);
            this.fgrid_prodMold.Name = "fgrid_prodMold";
            this.fgrid_prodMold.Rows.DefaultSize = 17;
            this.fgrid_prodMold.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_prodMold.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.Always;
            this.fgrid_prodMold.Size = new System.Drawing.Size(786, 256);
            this.fgrid_prodMold.StyleInfo = resources.GetString("fgrid_prodMold.StyleInfo");
            this.fgrid_prodMold.TabIndex = 1018;
            // 
            // split_mef1
            // 
            this.split_mef1.Dock = System.Windows.Forms.DockStyle.Right;
            this.split_mef1.Location = new System.Drawing.Point(786, 0);
            this.split_mef1.Name = "split_mef1";
            this.split_mef1.Size = new System.Drawing.Size(5, 256);
            this.split_mef1.TabIndex = 1019;
            this.split_mef1.TabStop = false;
            // 
            // fgrid_pm_meof_head
            // 
            this.fgrid_pm_meof_head.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.fgrid_pm_meof_head.Dock = System.Windows.Forms.DockStyle.Right;
            this.fgrid_pm_meof_head.Location = new System.Drawing.Point(791, 0);
            this.fgrid_pm_meof_head.Name = "fgrid_pm_meof_head";
            this.fgrid_pm_meof_head.Rows.DefaultSize = 17;
            this.fgrid_pm_meof_head.Size = new System.Drawing.Size(100, 256);
            this.fgrid_pm_meof_head.StyleInfo = resources.GetString("fgrid_pm_meof_head.StyleInfo");
            this.fgrid_pm_meof_head.TabIndex = 1020;
            // 
            // split_mef2
            // 
            this.split_mef2.Dock = System.Windows.Forms.DockStyle.Right;
            this.split_mef2.Location = new System.Drawing.Point(891, 0);
            this.split_mef2.Name = "split_mef2";
            this.split_mef2.Size = new System.Drawing.Size(5, 256);
            this.split_mef2.TabIndex = 1021;
            this.split_mef2.TabStop = false;
            // 
            // fgrid_pm_meof_size
            // 
            this.fgrid_pm_meof_size.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this.fgrid_pm_meof_size.Dock = System.Windows.Forms.DockStyle.Right;
            this.fgrid_pm_meof_size.Location = new System.Drawing.Point(896, 0);
            this.fgrid_pm_meof_size.Name = "fgrid_pm_meof_size";
            this.fgrid_pm_meof_size.Rows.DefaultSize = 17;
            this.fgrid_pm_meof_size.Size = new System.Drawing.Size(100, 256);
            this.fgrid_pm_meof_size.StyleInfo = resources.GetString("fgrid_pm_meof_size.StyleInfo");
            this.fgrid_pm_meof_size.TabIndex = 1022;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.splitc_5523);
            this.tabPage10.Location = new System.Drawing.Point(4, 23);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(996, 256);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Tag = "5523";
            this.tabPage10.Text = "5523";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // splitc_5523
            // 
            this.splitc_5523.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitc_5523.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitc_5523.Location = new System.Drawing.Point(0, 0);
            this.splitc_5523.Name = "splitc_5523";
            // 
            // splitc_5523.Panel1
            // 
            this.splitc_5523.Panel1.BackColor = System.Drawing.Color.White;
            this.splitc_5523.Panel1.Controls.Add(this.cmb_region);
            this.splitc_5523.Panel1.Controls.Add(this.lbl_region);
            this.splitc_5523.Panel1.Controls.Add(this.txt_leather_5523);
            this.splitc_5523.Panel1.Controls.Add(this.txt_synthetic_5523);
            this.splitc_5523.Panel1.Controls.Add(this.txt_textile_5523);
            this.splitc_5523.Panel1.Controls.Add(this.txt_other_5523);
            this.splitc_5523.Panel1.Controls.Add(this.txt_devCode_5523);
            this.splitc_5523.Panel1.Controls.Add(this.txt_prodName_5523);
            this.splitc_5523.Panel1.Controls.Add(this.txt_prodType_5523);
            this.splitc_5523.Panel1.Controls.Add(this.txt_factory_5523);
            this.splitc_5523.Panel1.Controls.Add(this.txt_date_5523);
            this.splitc_5523.Panel1.Controls.Add(this.txt_season_5523);
            this.splitc_5523.Panel1.Controls.Add(this.txt_prodCode_5523);
            this.splitc_5523.Panel1.Controls.Add(this.lbl_other_5523);
            this.splitc_5523.Panel1.Controls.Add(this.lbl_textile_5523);
            this.splitc_5523.Panel1.Controls.Add(this.lbl_synthetic_5523);
            this.splitc_5523.Panel1.Controls.Add(this.lbl_leather_5523);
            this.splitc_5523.Panel1.Controls.Add(this.lbl_date_5523);
            this.splitc_5523.Panel1.Controls.Add(this.lbl_season_5523);
            this.splitc_5523.Panel1.Controls.Add(this.lbl_factory_5523);
            this.splitc_5523.Panel1.Controls.Add(this.lbl_prodType_5523);
            this.splitc_5523.Panel1.Controls.Add(this.lbl_prodName_5523);
            this.splitc_5523.Panel1.Controls.Add(this.lbl_devCode_5523);
            this.splitc_5523.Panel1.Controls.Add(this.lbl_prodCode_5523);
            // 
            // splitc_5523.Panel2
            // 
            this.splitc_5523.Panel2.Controls.Add(this.fgrid_5523);
            this.splitc_5523.Size = new System.Drawing.Size(996, 256);
            this.splitc_5523.SplitterDistance = 489;
            this.splitc_5523.TabIndex = 1;
            // 
            // cmb_region
            // 
            this.cmb_region.AddItemSeparator = ';';
            this.cmb_region.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_region.Caption = "";
            this.cmb_region.CaptionHeight = 17;
            this.cmb_region.CaptionStyle = style25;
            this.cmb_region.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_region.ColumnCaptionHeight = 18;
            this.cmb_region.ColumnFooterHeight = 18;
            this.cmb_region.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_region.ContentHeight = 17;
            this.cmb_region.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_region.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_region.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_region.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_region.EditorHeight = 17;
            this.cmb_region.EvenRowStyle = style26;
            this.cmb_region.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_region.FooterStyle = style27;
            this.cmb_region.HeadingStyle = style28;
            this.cmb_region.HighLightRowStyle = style29;
            this.cmb_region.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_region.Images"))));
            this.cmb_region.ItemHeight = 15;
            this.cmb_region.Location = new System.Drawing.Point(109, 8);
            this.cmb_region.MatchEntryTimeout = ((long)(2000));
            this.cmb_region.MaxDropDownItems = ((short)(5));
            this.cmb_region.MaxLength = 32767;
            this.cmb_region.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_region.Name = "cmb_region";
            this.cmb_region.OddRowStyle = style30;
            this.cmb_region.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_region.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_region.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_region.SelectedStyle = style31;
            this.cmb_region.Size = new System.Drawing.Size(130, 21);
            this.cmb_region.Style = style32;
            this.cmb_region.TabIndex = 603;
            this.cmb_region.PropBag = resources.GetString("cmb_region.PropBag");
            // 
            // lbl_region
            // 
            this.lbl_region.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.lbl_region.ImageIndex = 0;
            this.lbl_region.ImageList = this.img_Label;
            this.lbl_region.Location = new System.Drawing.Point(8, 8);
            this.lbl_region.Name = "lbl_region";
            this.lbl_region.Size = new System.Drawing.Size(100, 21);
            this.lbl_region.TabIndex = 602;
            this.lbl_region.Tag = "0";
            this.lbl_region.Text = "Region";
            this.lbl_region.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_leather_5523
            // 
            this.txt_leather_5523.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_leather_5523.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_leather_5523.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_leather_5523.Location = new System.Drawing.Point(349, 30);
            this.txt_leather_5523.MaxLength = 40;
            this.txt_leather_5523.Name = "txt_leather_5523";
            this.txt_leather_5523.ReadOnly = true;
            this.txt_leather_5523.Size = new System.Drawing.Size(130, 21);
            this.txt_leather_5523.TabIndex = 601;
            // 
            // txt_synthetic_5523
            // 
            this.txt_synthetic_5523.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_synthetic_5523.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_synthetic_5523.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_synthetic_5523.Location = new System.Drawing.Point(349, 52);
            this.txt_synthetic_5523.MaxLength = 40;
            this.txt_synthetic_5523.Name = "txt_synthetic_5523";
            this.txt_synthetic_5523.ReadOnly = true;
            this.txt_synthetic_5523.Size = new System.Drawing.Size(130, 21);
            this.txt_synthetic_5523.TabIndex = 600;
            // 
            // txt_textile_5523
            // 
            this.txt_textile_5523.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_textile_5523.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_textile_5523.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_textile_5523.Location = new System.Drawing.Point(349, 74);
            this.txt_textile_5523.MaxLength = 40;
            this.txt_textile_5523.Name = "txt_textile_5523";
            this.txt_textile_5523.ReadOnly = true;
            this.txt_textile_5523.Size = new System.Drawing.Size(130, 21);
            this.txt_textile_5523.TabIndex = 599;
            // 
            // txt_other_5523
            // 
            this.txt_other_5523.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_other_5523.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_other_5523.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_other_5523.Location = new System.Drawing.Point(349, 96);
            this.txt_other_5523.MaxLength = 40;
            this.txt_other_5523.Name = "txt_other_5523";
            this.txt_other_5523.ReadOnly = true;
            this.txt_other_5523.Size = new System.Drawing.Size(130, 21);
            this.txt_other_5523.TabIndex = 598;
            // 
            // txt_devCode_5523
            // 
            this.txt_devCode_5523.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_devCode_5523.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_devCode_5523.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_devCode_5523.Location = new System.Drawing.Point(109, 52);
            this.txt_devCode_5523.MaxLength = 40;
            this.txt_devCode_5523.Name = "txt_devCode_5523";
            this.txt_devCode_5523.ReadOnly = true;
            this.txt_devCode_5523.Size = new System.Drawing.Size(130, 21);
            this.txt_devCode_5523.TabIndex = 597;
            // 
            // txt_prodName_5523
            // 
            this.txt_prodName_5523.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_prodName_5523.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_prodName_5523.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_prodName_5523.Location = new System.Drawing.Point(109, 74);
            this.txt_prodName_5523.MaxLength = 40;
            this.txt_prodName_5523.Name = "txt_prodName_5523";
            this.txt_prodName_5523.ReadOnly = true;
            this.txt_prodName_5523.Size = new System.Drawing.Size(130, 21);
            this.txt_prodName_5523.TabIndex = 596;
            // 
            // txt_prodType_5523
            // 
            this.txt_prodType_5523.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_prodType_5523.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_prodType_5523.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_prodType_5523.Location = new System.Drawing.Point(109, 96);
            this.txt_prodType_5523.MaxLength = 40;
            this.txt_prodType_5523.Name = "txt_prodType_5523";
            this.txt_prodType_5523.ReadOnly = true;
            this.txt_prodType_5523.Size = new System.Drawing.Size(130, 21);
            this.txt_prodType_5523.TabIndex = 595;
            // 
            // txt_factory_5523
            // 
            this.txt_factory_5523.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_factory_5523.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_factory_5523.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_factory_5523.Location = new System.Drawing.Point(109, 118);
            this.txt_factory_5523.MaxLength = 40;
            this.txt_factory_5523.Name = "txt_factory_5523";
            this.txt_factory_5523.ReadOnly = true;
            this.txt_factory_5523.Size = new System.Drawing.Size(130, 21);
            this.txt_factory_5523.TabIndex = 594;
            // 
            // txt_date_5523
            // 
            this.txt_date_5523.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_date_5523.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_date_5523.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_date_5523.Location = new System.Drawing.Point(109, 162);
            this.txt_date_5523.MaxLength = 40;
            this.txt_date_5523.Name = "txt_date_5523";
            this.txt_date_5523.ReadOnly = true;
            this.txt_date_5523.Size = new System.Drawing.Size(130, 21);
            this.txt_date_5523.TabIndex = 592;
            // 
            // txt_season_5523
            // 
            this.txt_season_5523.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_season_5523.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_season_5523.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_season_5523.Location = new System.Drawing.Point(109, 140);
            this.txt_season_5523.MaxLength = 40;
            this.txt_season_5523.Name = "txt_season_5523";
            this.txt_season_5523.ReadOnly = true;
            this.txt_season_5523.Size = new System.Drawing.Size(130, 21);
            this.txt_season_5523.TabIndex = 591;
            // 
            // txt_prodCode_5523
            // 
            this.txt_prodCode_5523.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_prodCode_5523.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_prodCode_5523.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_prodCode_5523.Location = new System.Drawing.Point(109, 30);
            this.txt_prodCode_5523.MaxLength = 40;
            this.txt_prodCode_5523.Name = "txt_prodCode_5523";
            this.txt_prodCode_5523.ReadOnly = true;
            this.txt_prodCode_5523.Size = new System.Drawing.Size(130, 21);
            this.txt_prodCode_5523.TabIndex = 590;
            // 
            // lbl_other_5523
            // 
            this.lbl_other_5523.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.lbl_other_5523.ImageIndex = 0;
            this.lbl_other_5523.ImageList = this.img_Label;
            this.lbl_other_5523.Location = new System.Drawing.Point(248, 96);
            this.lbl_other_5523.Name = "lbl_other_5523";
            this.lbl_other_5523.Size = new System.Drawing.Size(100, 21);
            this.lbl_other_5523.TabIndex = 589;
            this.lbl_other_5523.Tag = "0";
            this.lbl_other_5523.Text = "OTHERS";
            this.lbl_other_5523.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_textile_5523
            // 
            this.lbl_textile_5523.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.lbl_textile_5523.ImageIndex = 0;
            this.lbl_textile_5523.ImageList = this.img_Label;
            this.lbl_textile_5523.Location = new System.Drawing.Point(248, 74);
            this.lbl_textile_5523.Name = "lbl_textile_5523";
            this.lbl_textile_5523.Size = new System.Drawing.Size(100, 21);
            this.lbl_textile_5523.TabIndex = 588;
            this.lbl_textile_5523.Tag = "0";
            this.lbl_textile_5523.Text = "TEXTILE";
            this.lbl_textile_5523.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_synthetic_5523
            // 
            this.lbl_synthetic_5523.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.lbl_synthetic_5523.ImageIndex = 0;
            this.lbl_synthetic_5523.ImageList = this.img_Label;
            this.lbl_synthetic_5523.Location = new System.Drawing.Point(248, 52);
            this.lbl_synthetic_5523.Name = "lbl_synthetic_5523";
            this.lbl_synthetic_5523.Size = new System.Drawing.Size(100, 21);
            this.lbl_synthetic_5523.TabIndex = 587;
            this.lbl_synthetic_5523.Tag = "0";
            this.lbl_synthetic_5523.Text = "SYNTHETIC";
            this.lbl_synthetic_5523.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_leather_5523
            // 
            this.lbl_leather_5523.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.lbl_leather_5523.ImageIndex = 0;
            this.lbl_leather_5523.ImageList = this.img_Label;
            this.lbl_leather_5523.Location = new System.Drawing.Point(248, 30);
            this.lbl_leather_5523.Name = "lbl_leather_5523";
            this.lbl_leather_5523.Size = new System.Drawing.Size(100, 21);
            this.lbl_leather_5523.TabIndex = 586;
            this.lbl_leather_5523.Tag = "0";
            this.lbl_leather_5523.Text = "LEATHER";
            this.lbl_leather_5523.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_date_5523
            // 
            this.lbl_date_5523.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.lbl_date_5523.ImageIndex = 0;
            this.lbl_date_5523.ImageList = this.img_Label;
            this.lbl_date_5523.Location = new System.Drawing.Point(8, 162);
            this.lbl_date_5523.Name = "lbl_date_5523";
            this.lbl_date_5523.Size = new System.Drawing.Size(100, 21);
            this.lbl_date_5523.TabIndex = 584;
            this.lbl_date_5523.Tag = "0";
            this.lbl_date_5523.Text = "Date";
            this.lbl_date_5523.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_season_5523
            // 
            this.lbl_season_5523.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.lbl_season_5523.ImageIndex = 0;
            this.lbl_season_5523.ImageList = this.img_Label;
            this.lbl_season_5523.Location = new System.Drawing.Point(8, 140);
            this.lbl_season_5523.Name = "lbl_season_5523";
            this.lbl_season_5523.Size = new System.Drawing.Size(100, 21);
            this.lbl_season_5523.TabIndex = 583;
            this.lbl_season_5523.Tag = "0";
            this.lbl_season_5523.Text = "Season";
            this.lbl_season_5523.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_factory_5523
            // 
            this.lbl_factory_5523.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.lbl_factory_5523.ImageIndex = 0;
            this.lbl_factory_5523.ImageList = this.img_Label;
            this.lbl_factory_5523.Location = new System.Drawing.Point(8, 118);
            this.lbl_factory_5523.Name = "lbl_factory_5523";
            this.lbl_factory_5523.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory_5523.TabIndex = 582;
            this.lbl_factory_5523.Tag = "0";
            this.lbl_factory_5523.Text = "Factory";
            this.lbl_factory_5523.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_prodType_5523
            // 
            this.lbl_prodType_5523.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.lbl_prodType_5523.ImageIndex = 0;
            this.lbl_prodType_5523.ImageList = this.img_Label;
            this.lbl_prodType_5523.Location = new System.Drawing.Point(8, 96);
            this.lbl_prodType_5523.Name = "lbl_prodType_5523";
            this.lbl_prodType_5523.Size = new System.Drawing.Size(100, 21);
            this.lbl_prodType_5523.TabIndex = 581;
            this.lbl_prodType_5523.Tag = "0";
            this.lbl_prodType_5523.Text = "Product Type";
            this.lbl_prodType_5523.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_prodName_5523
            // 
            this.lbl_prodName_5523.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.lbl_prodName_5523.ImageIndex = 0;
            this.lbl_prodName_5523.ImageList = this.img_Label;
            this.lbl_prodName_5523.Location = new System.Drawing.Point(8, 74);
            this.lbl_prodName_5523.Name = "lbl_prodName_5523";
            this.lbl_prodName_5523.Size = new System.Drawing.Size(100, 21);
            this.lbl_prodName_5523.TabIndex = 580;
            this.lbl_prodName_5523.Tag = "0";
            this.lbl_prodName_5523.Text = "Product Name";
            this.lbl_prodName_5523.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_devCode_5523
            // 
            this.lbl_devCode_5523.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.lbl_devCode_5523.ImageIndex = 0;
            this.lbl_devCode_5523.ImageList = this.img_Label;
            this.lbl_devCode_5523.Location = new System.Drawing.Point(8, 52);
            this.lbl_devCode_5523.Name = "lbl_devCode_5523";
            this.lbl_devCode_5523.Size = new System.Drawing.Size(100, 21);
            this.lbl_devCode_5523.TabIndex = 579;
            this.lbl_devCode_5523.Tag = "0";
            this.lbl_devCode_5523.Text = "Dev Code";
            this.lbl_devCode_5523.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_prodCode_5523
            // 
            this.lbl_prodCode_5523.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.lbl_prodCode_5523.ImageIndex = 0;
            this.lbl_prodCode_5523.ImageList = this.img_Label;
            this.lbl_prodCode_5523.Location = new System.Drawing.Point(8, 30);
            this.lbl_prodCode_5523.Name = "lbl_prodCode_5523";
            this.lbl_prodCode_5523.Size = new System.Drawing.Size(100, 21);
            this.lbl_prodCode_5523.TabIndex = 578;
            this.lbl_prodCode_5523.Tag = "0";
            this.lbl_prodCode_5523.Text = "Product Code";
            this.lbl_prodCode_5523.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fgrid_5523
            // 
            this.fgrid_5523.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_5523.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_5523.Location = new System.Drawing.Point(0, 0);
            this.fgrid_5523.Name = "fgrid_5523";
            this.fgrid_5523.Rows.DefaultSize = 19;
            this.fgrid_5523.Size = new System.Drawing.Size(503, 256);
            this.fgrid_5523.StyleInfo = resources.GetString("fgrid_5523.StyleInfo");
            this.fgrid_5523.TabIndex = 21;
            // 
            // timer_excel
            // 
            this.timer_excel.Interval = 1000;
            this.timer_excel.Tick += new System.EventHandler(this.timer_Excel_Tick);
            // 
            // Form_CBD_Master_Viewer
            // 
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.sizer_Main);
            this.Name = "Form_CBD_Master_Viewer";
            this.Controls.SetChildIndex(this.sizer_Main, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizer_Main)).EndInit();
            this.sizer_Main.ResumeLayout(false);
            this.pnl_SchPnl1.ResumeLayout(false);
            this.pnl_SchPnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_DPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ProdFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_head)).EndInit();
            this.ctx_head.ResumeLayout(false);
            this.tab_detail.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_upper)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_packaging)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_midsole)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_outsole)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_labor)).EndInit();
            this.pnl_laborComment.ResumeLayout(false);
            this.pnl_laborComment.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_overhead)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.pnl_CBDDetailSummary.ResumeLayout(false);
            this.pnl_CBDDetailSummary.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_sampMold)).EndInit();
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_prodMold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_pm_meof_head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_pm_meof_size)).EndInit();
            this.tabPage10.ResumeLayout(false);
            this.splitc_5523.Panel1.ResumeLayout(false);
            this.splitc_5523.Panel1.PerformLayout();
            this.splitc_5523.Panel2.ResumeLayout(false);
            this.splitc_5523.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_region)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_5523)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Sizer.C1Sizer sizer_Main;
        private System.Windows.Forms.TabControl tab_detail;
        private System.Windows.Forms.TabPage tabPage1;
        private COM.FSP fgrid_upper;
        private System.Windows.Forms.TabPage tabPage2;
        private COM.FSP fgrid_packaging;
        private System.Windows.Forms.TabPage tabPage3;
        private COM.FSP fgrid_midsole;
        private System.Windows.Forms.TabPage tabPage4;
        private COM.FSP fgrid_outsole;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel pnl_laborComment;
        private System.Windows.Forms.TextBox txt_hLABOR_CMT;
        private System.Windows.Forms.Label lbl_hLaborCmt;
        private COM.FSP fgrid_labor;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_hOVERHEAD_CMT;
        private System.Windows.Forms.Label lbl_hOverheadCmt;
        private COM.FSP fgrid_overhead;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Panel pnl_CBDDetailSummary;
        private System.Windows.Forms.Label lbl_pct1;
        private System.Windows.Forms.TextBox txt_hPROFIT;
        private System.Windows.Forms.TextBox txt_hLEAN_SAVE_TGT;
        private System.Windows.Forms.TextBox txt_hTOT_FOB;
        private System.Windows.Forms.TextBox txt_hTOT_TOOLING;
        private System.Windows.Forms.TextBox txt_hSIZERUN;
        private System.Windows.Forms.TextBox txt_hTOT_SIZERUN;
        private System.Windows.Forms.TextBox txt_hOTHER_ADJUST;
        private System.Windows.Forms.TextBox txt_hPROFIT_PCT;
        private System.Windows.Forms.TextBox txt_hTOT_MLOS;
        private System.Windows.Forms.Label lbl_hTotSizeRun;
        private System.Windows.Forms.Label lbl_hSizeRun;
        private System.Windows.Forms.Label lbl_hLean;
        private System.Windows.Forms.Label lbl_hTotFOB;
        private System.Windows.Forms.Label lbl_hTooling;
        private System.Windows.Forms.Label lbl_hOtherAdj2;
        private System.Windows.Forms.Label lbl_hProfit2;
        private System.Windows.Forms.Label lbl_hTotMLOS;
        private System.Windows.Forms.TabPage tabPage8;
        private COM.FSP fgrid_sampMold;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.SplitContainer splitc_5523;
        private C1.Win.C1List.C1Combo cmb_region;
        private System.Windows.Forms.Label lbl_region;
        private System.Windows.Forms.TextBox txt_leather_5523;
        private System.Windows.Forms.TextBox txt_synthetic_5523;
        private System.Windows.Forms.TextBox txt_textile_5523;
        private System.Windows.Forms.TextBox txt_other_5523;
        private System.Windows.Forms.TextBox txt_devCode_5523;
        private System.Windows.Forms.TextBox txt_prodName_5523;
        private System.Windows.Forms.TextBox txt_prodType_5523;
        private System.Windows.Forms.TextBox txt_factory_5523;
        private System.Windows.Forms.TextBox txt_date_5523;
        private System.Windows.Forms.TextBox txt_season_5523;
        private System.Windows.Forms.TextBox txt_prodCode_5523;
        private System.Windows.Forms.Label lbl_other_5523;
        private System.Windows.Forms.Label lbl_textile_5523;
        private System.Windows.Forms.Label lbl_synthetic_5523;
        private System.Windows.Forms.Label lbl_leather_5523;
        private System.Windows.Forms.Label lbl_date_5523;
        private System.Windows.Forms.Label lbl_season_5523;
        private System.Windows.Forms.Label lbl_factory_5523;
        private System.Windows.Forms.Label lbl_prodType_5523;
        private System.Windows.Forms.Label lbl_prodName_5523;
        private System.Windows.Forms.Label lbl_devCode_5523;
        private System.Windows.Forms.Label lbl_prodCode_5523;
        private COM.FSP fgrid_5523;
        private System.Windows.Forms.TabPage tabPage9;
        private COM.FSP fgrid_pm_meof_size;
        private System.Windows.Forms.Splitter split_mef2;
        private COM.FSP fgrid_pm_meof_head;
        private System.Windows.Forms.Splitter split_mef1;
        private COM.FSP fgrid_prodMold;
        private COM.FSP fgrid_head;
        private System.Windows.Forms.Panel pnl_SchPnl1;
        private System.Windows.Forms.TextBox txt_BOMID;
        private C1.Win.C1List.C1Combo cmb_Season;
        private System.Windows.Forms.Label lbl_Season;
        private System.Windows.Forms.Label lbl_MOID;
        private System.Windows.Forms.Label lbl_BOMID;
        private C1.Win.C1List.C1Combo cmb_DPO;
        private System.Windows.Forms.Label lbl_DPO;
        private C1.Win.C1List.C1Combo cmb_ProdFac;
        private System.Windows.Forms.Label lbl_ProdFac;
        public System.Windows.Forms.Label lbl_title;
        private FlexCosting.Basic.Ctl.SearchPanel pnl_SchPnl2;
        private System.Windows.Forms.TextBox txt_MOID;
        private System.Windows.Forms.Timer timer_excel;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ContextMenuStrip ctx_head;
        private System.Windows.Forms.ToolStripMenuItem ctxt_excel;
    }
}
