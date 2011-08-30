namespace FlexCosting.Basic
{
    partial class Form_Item_Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Item_Master));
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.tab_main = new System.Windows.Forms.TabControl();
            this.tabp_supplier = new System.Windows.Forms.TabPage();
            this.sizer_supplier = new C1.Win.C1Sizer.C1Sizer();
            this.spc_mat = new System.Windows.Forms.SplitContainer();
            this.fgrid_mat = new COM.FSP();
            this.ctx_mat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxt_matInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxt_matDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxt_matCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_matBtn = new System.Windows.Forms.Panel();
            this.btn_MatAdd = new System.Windows.Forms.Label();
            this.btn_MatDel = new System.Windows.Forms.Label();
            this.btn_MatCancel = new System.Windows.Forms.Label();
            this.tab_detail = new System.Windows.Forms.TabControl();
            this.tabp_history = new System.Windows.Forms.TabPage();
            this.fgrid_history = new COM.FSP();
            this.pnl_charge = new System.Windows.Forms.Panel();
            this.btn_ChargeAdd = new System.Windows.Forms.Label();
            this.btn_ChargeDel = new System.Windows.Forms.Label();
            this.btn_ChargeCancel = new System.Windows.Forms.Label();
            this.tabp_part = new System.Windows.Forms.TabPage();
            this.fgrid_reinforce = new COM.FSP();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.lbl_ItemName = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.fgrid_cust_list = new COM.FSP();
            this.tabp_information = new System.Windows.Forms.TabPage();
            this.fgrid_cust = new COM.FSP();
            this.ctx_cust = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxt_custUserInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxt_custUserDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxt_custUserCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxt_bar2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxt_custInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxt_bar1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxt_view = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxt_view_supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxt_view_charger = new System.Windows.Forms.ToolStripMenuItem();
            this.tabp_conv = new System.Windows.Forms.TabPage();
            this.sizer_conv = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_convHead = new System.Windows.Forms.Panel();
            this.txt_conv_sup_name = new System.Windows.Forms.TextBox();
            this.txt_conv_sup_code = new System.Windows.Forms.TextBox();
            this.lbl_conv_sup = new System.Windows.Forms.Label();
            this.pnl_convTitle = new System.Windows.Forms.Label();
            this.fgrid_cust_list_conv = new COM.FSP();
            this.fgrid_conv = new COM.FSP();
            this.ctx_conv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxt_SearchExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxt_bar = new System.Windows.Forms.ToolStripSeparator();
            this.ctxt_convDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxt_convCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxt_convConfirm = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPanel1 = new FlexCosting.Basic.Ctl.SearchPanel();
            this.searchPanel2 = new FlexCosting.Basic.Ctl.SearchPanel();
            this.c1Sizer2 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_supHead = new System.Windows.Forms.Panel();
            this.txt_sup_name = new System.Windows.Forms.TextBox();
            this.txt_sup_code = new System.Windows.Forms.TextBox();
            this.lbl_sup = new System.Windows.Forms.Label();
            this.lbl_supTitle = new System.Windows.Forms.Label();
            this.searchPanel3 = new FlexCosting.Basic.Ctl.SearchPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.tab_main.SuspendLayout();
            this.tabp_supplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizer_supplier)).BeginInit();
            this.sizer_supplier.SuspendLayout();
            this.spc_mat.Panel1.SuspendLayout();
            this.spc_mat.Panel2.SuspendLayout();
            this.spc_mat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_mat)).BeginInit();
            this.ctx_mat.SuspendLayout();
            this.pnl_matBtn.SuspendLayout();
            this.tab_detail.SuspendLayout();
            this.tabp_history.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_history)).BeginInit();
            this.pnl_charge.SuspendLayout();
            this.tabp_part.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_reinforce)).BeginInit();
            this.pnl_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_cust_list)).BeginInit();
            this.tabp_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_cust)).BeginInit();
            this.ctx_cust.SuspendLayout();
            this.tabp_conv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizer_conv)).BeginInit();
            this.sizer_conv.SuspendLayout();
            this.pnl_convHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_cust_list_conv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_conv)).BeginInit();
            this.ctx_conv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer2)).BeginInit();
            this.c1Sizer2.SuspendLayout();
            this.pnl_supHead.SuspendLayout();
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
            // c1Sizer1
            // 
            this.c1Sizer1.Controls.Add(this.tab_main);
            this.c1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Sizer1.GridDefinition = "11.8965517241379:False:True;86.0344827586207:False:False;\t99.2125984251968:False:" +
                "False;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 580);
            this.c1Sizer1.TabIndex = 29;
            this.c1Sizer1.TabStop = false;
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.tabp_supplier);
            this.tab_main.Controls.Add(this.tabp_information);
            this.tab_main.Controls.Add(this.tabp_conv);
            this.tab_main.ItemSize = new System.Drawing.Size(100, 20);
            this.tab_main.Location = new System.Drawing.Point(4, 4);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(1008, 572);
            this.tab_main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_main.TabIndex = 8;
            // 
            // tabp_supplier
            // 
            this.tabp_supplier.Controls.Add(this.sizer_supplier);
            this.tabp_supplier.Location = new System.Drawing.Point(4, 24);
            this.tabp_supplier.Margin = new System.Windows.Forms.Padding(0);
            this.tabp_supplier.Name = "tabp_supplier";
            this.tabp_supplier.Size = new System.Drawing.Size(1000, 544);
            this.tabp_supplier.TabIndex = 0;
            this.tabp_supplier.Text = "Material";
            this.tabp_supplier.UseVisualStyleBackColor = true;
            // 
            // sizer_supplier
            // 
            this.sizer_supplier.BorderWidth = 0;
            this.sizer_supplier.Controls.Add(this.spc_mat);
            this.sizer_supplier.Controls.Add(this.pnl_search);
            this.sizer_supplier.Controls.Add(this.fgrid_cust_list);
            this.sizer_supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizer_supplier.GridDefinition = "12.6838235294118:False:True;87.3161764705882:False:False;\t24.2:True:True;75.8:Fal" +
                "se:False;";
            this.sizer_supplier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sizer_supplier.Location = new System.Drawing.Point(0, 0);
            this.sizer_supplier.Margin = new System.Windows.Forms.Padding(0);
            this.sizer_supplier.Name = "sizer_supplier";
            this.sizer_supplier.Size = new System.Drawing.Size(1000, 544);
            this.sizer_supplier.SplitterWidth = 0;
            this.sizer_supplier.TabIndex = 0;
            this.sizer_supplier.TabStop = false;
            // 
            // spc_mat
            // 
            this.spc_mat.Location = new System.Drawing.Point(242, 69);
            this.spc_mat.Margin = new System.Windows.Forms.Padding(0);
            this.spc_mat.Name = "spc_mat";
            this.spc_mat.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc_mat.Panel1
            // 
            this.spc_mat.Panel1.Controls.Add(this.fgrid_mat);
            this.spc_mat.Panel1.Controls.Add(this.pnl_matBtn);
            this.spc_mat.Panel1.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            // 
            // spc_mat.Panel2
            // 
            this.spc_mat.Panel2.Controls.Add(this.tab_detail);
            this.spc_mat.Size = new System.Drawing.Size(758, 475);
            this.spc_mat.SplitterDistance = 201;
            this.spc_mat.TabIndex = 5;
            // 
            // fgrid_mat
            // 
            this.fgrid_mat.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_mat.ContextMenuStrip = this.ctx_mat;
            this.fgrid_mat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_mat.Location = new System.Drawing.Point(7, 0);
            this.fgrid_mat.Name = "fgrid_mat";
            this.fgrid_mat.Rows.DefaultSize = 19;
            this.fgrid_mat.Size = new System.Drawing.Size(751, 178);
            this.fgrid_mat.StyleInfo = resources.GetString("fgrid_mat.StyleInfo");
            this.fgrid_mat.TabIndex = 0;
            this.fgrid_mat.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_mat_AfterEdit);
            this.fgrid_mat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_mat_MouseDown);
            this.fgrid_mat.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_mat_BeforeEdit);
            // 
            // ctx_mat
            // 
            this.ctx_mat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxt_matInsert,
            this.ctxt_matDelete,
            this.ctxt_matCancel});
            this.ctx_mat.Name = "ctx_mat";
            this.ctx_mat.Size = new System.Drawing.Size(117, 70);
            // 
            // ctxt_matInsert
            // 
            this.ctxt_matInsert.Name = "ctxt_matInsert";
            this.ctxt_matInsert.Size = new System.Drawing.Size(116, 22);
            this.ctxt_matInsert.Text = "Insert";
            this.ctxt_matInsert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MatAdd_MouseUp);
            // 
            // ctxt_matDelete
            // 
            this.ctxt_matDelete.Name = "ctxt_matDelete";
            this.ctxt_matDelete.Size = new System.Drawing.Size(116, 22);
            this.ctxt_matDelete.Text = "Delete";
            this.ctxt_matDelete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MatDel_MouseUp);
            // 
            // ctxt_matCancel
            // 
            this.ctxt_matCancel.Name = "ctxt_matCancel";
            this.ctxt_matCancel.Size = new System.Drawing.Size(116, 22);
            this.ctxt_matCancel.Text = "Cancel";
            this.ctxt_matCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MatCancel_MouseUp);
            // 
            // pnl_matBtn
            // 
            this.pnl_matBtn.Controls.Add(this.btn_MatAdd);
            this.pnl_matBtn.Controls.Add(this.btn_MatDel);
            this.pnl_matBtn.Controls.Add(this.btn_MatCancel);
            this.pnl_matBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_matBtn.Location = new System.Drawing.Point(7, 178);
            this.pnl_matBtn.Name = "pnl_matBtn";
            this.pnl_matBtn.Size = new System.Drawing.Size(751, 23);
            this.pnl_matBtn.TabIndex = 6;
            this.pnl_matBtn.Visible = false;
            // 
            // btn_MatAdd
            // 
            this.btn_MatAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MatAdd.BackColor = System.Drawing.Color.Black;
            this.btn_MatAdd.ImageIndex = 9;
            this.btn_MatAdd.ImageList = this.image_List;
            this.btn_MatAdd.Location = new System.Drawing.Point(508, 0);
            this.btn_MatAdd.Name = "btn_MatAdd";
            this.btn_MatAdd.Size = new System.Drawing.Size(80, 23);
            this.btn_MatAdd.TabIndex = 649;
            this.btn_MatAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_MatAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MatAdd_MouseUp);
            // 
            // btn_MatDel
            // 
            this.btn_MatDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MatDel.ImageIndex = 5;
            this.btn_MatDel.ImageList = this.image_List;
            this.btn_MatDel.Location = new System.Drawing.Point(589, 0);
            this.btn_MatDel.Name = "btn_MatDel";
            this.btn_MatDel.Size = new System.Drawing.Size(80, 23);
            this.btn_MatDel.TabIndex = 648;
            this.btn_MatDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_MatDel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MatDel_MouseUp);
            // 
            // btn_MatCancel
            // 
            this.btn_MatCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MatCancel.ImageIndex = 1;
            this.btn_MatCancel.ImageList = this.image_List;
            this.btn_MatCancel.Location = new System.Drawing.Point(670, 0);
            this.btn_MatCancel.Name = "btn_MatCancel";
            this.btn_MatCancel.Size = new System.Drawing.Size(80, 23);
            this.btn_MatCancel.TabIndex = 647;
            this.btn_MatCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_MatCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MatCancel_MouseUp);
            // 
            // tab_detail
            // 
            this.tab_detail.Controls.Add(this.tabp_history);
            this.tab_detail.Controls.Add(this.tabp_part);
            this.tab_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_detail.ItemSize = new System.Drawing.Size(100, 20);
            this.tab_detail.Location = new System.Drawing.Point(0, 0);
            this.tab_detail.Name = "tab_detail";
            this.tab_detail.SelectedIndex = 0;
            this.tab_detail.Size = new System.Drawing.Size(758, 270);
            this.tab_detail.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_detail.TabIndex = 1;
            // 
            // tabp_history
            // 
            this.tabp_history.Controls.Add(this.fgrid_history);
            this.tabp_history.Controls.Add(this.pnl_charge);
            this.tabp_history.Location = new System.Drawing.Point(4, 24);
            this.tabp_history.Name = "tabp_history";
            this.tabp_history.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_history.Size = new System.Drawing.Size(750, 242);
            this.tabp_history.TabIndex = 0;
            this.tabp_history.Text = "History";
            this.tabp_history.UseVisualStyleBackColor = true;
            // 
            // fgrid_history
            // 
            this.fgrid_history.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_history.Location = new System.Drawing.Point(3, 3);
            this.fgrid_history.Name = "fgrid_history";
            this.fgrid_history.Rows.DefaultSize = 19;
            this.fgrid_history.Size = new System.Drawing.Size(744, 213);
            this.fgrid_history.StyleInfo = resources.GetString("fgrid_history.StyleInfo");
            this.fgrid_history.TabIndex = 0;
            // 
            // pnl_charge
            // 
            this.pnl_charge.Controls.Add(this.btn_ChargeAdd);
            this.pnl_charge.Controls.Add(this.btn_ChargeDel);
            this.pnl_charge.Controls.Add(this.btn_ChargeCancel);
            this.pnl_charge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_charge.Location = new System.Drawing.Point(3, 216);
            this.pnl_charge.Name = "pnl_charge";
            this.pnl_charge.Size = new System.Drawing.Size(744, 23);
            this.pnl_charge.TabIndex = 7;
            this.pnl_charge.Visible = false;
            // 
            // btn_ChargeAdd
            // 
            this.btn_ChargeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChargeAdd.BackColor = System.Drawing.Color.Black;
            this.btn_ChargeAdd.ImageIndex = 9;
            this.btn_ChargeAdd.ImageList = this.image_List;
            this.btn_ChargeAdd.Location = new System.Drawing.Point(501, 0);
            this.btn_ChargeAdd.Name = "btn_ChargeAdd";
            this.btn_ChargeAdd.Size = new System.Drawing.Size(80, 23);
            this.btn_ChargeAdd.TabIndex = 649;
            this.btn_ChargeAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ChargeDel
            // 
            this.btn_ChargeDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChargeDel.ImageIndex = 5;
            this.btn_ChargeDel.ImageList = this.image_List;
            this.btn_ChargeDel.Location = new System.Drawing.Point(582, 0);
            this.btn_ChargeDel.Name = "btn_ChargeDel";
            this.btn_ChargeDel.Size = new System.Drawing.Size(80, 23);
            this.btn_ChargeDel.TabIndex = 648;
            this.btn_ChargeDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ChargeCancel
            // 
            this.btn_ChargeCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChargeCancel.ImageIndex = 1;
            this.btn_ChargeCancel.ImageList = this.image_List;
            this.btn_ChargeCancel.Location = new System.Drawing.Point(663, 0);
            this.btn_ChargeCancel.Name = "btn_ChargeCancel";
            this.btn_ChargeCancel.Size = new System.Drawing.Size(80, 23);
            this.btn_ChargeCancel.TabIndex = 647;
            this.btn_ChargeCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabp_part
            // 
            this.tabp_part.Controls.Add(this.fgrid_reinforce);
            this.tabp_part.Location = new System.Drawing.Point(4, 24);
            this.tabp_part.Name = "tabp_part";
            this.tabp_part.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_part.Size = new System.Drawing.Size(750, 242);
            this.tabp_part.TabIndex = 1;
            this.tabp_part.Text = "Part";
            this.tabp_part.UseVisualStyleBackColor = true;
            // 
            // fgrid_reinforce
            // 
            this.fgrid_reinforce.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_reinforce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_reinforce.Location = new System.Drawing.Point(3, 3);
            this.fgrid_reinforce.Name = "fgrid_reinforce";
            this.fgrid_reinforce.Rows.DefaultSize = 19;
            this.fgrid_reinforce.Size = new System.Drawing.Size(744, 236);
            this.fgrid_reinforce.StyleInfo = resources.GetString("fgrid_reinforce.StyleInfo");
            this.fgrid_reinforce.TabIndex = 0;
            // 
            // pnl_search
            // 
            this.pnl_search.Controls.Add(this.txt_itemName);
            this.pnl_search.Controls.Add(this.txt_itemCode);
            this.pnl_search.Controls.Add(this.lbl_ItemName);
            this.pnl_search.Controls.Add(this.lbl_title);
            this.pnl_search.Controls.Add(this.searchPanel1);
            this.pnl_search.Location = new System.Drawing.Point(0, 0);
            this.pnl_search.Name = "pnl_search";
            this.pnl_search.Size = new System.Drawing.Size(1000, 69);
            this.pnl_search.TabIndex = 3;
            // 
            // txt_itemName
            // 
            this.txt_itemName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_itemName.Location = new System.Drawing.Point(220, 36);
            this.txt_itemName.MaxLength = 40;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(210, 21);
            this.txt_itemName.TabIndex = 706;
            this.txt_itemName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SchText_KeyUp);
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCode.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_itemCode.Location = new System.Drawing.Point(109, 36);
            this.txt_itemCode.MaxLength = 40;
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(110, 21);
            this.txt_itemCode.TabIndex = 705;
            this.txt_itemCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SchText_KeyUp);
            // 
            // lbl_ItemName
            // 
            this.lbl_ItemName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemName.ImageIndex = 1;
            this.lbl_ItemName.ImageList = this.img_Label;
            this.lbl_ItemName.Location = new System.Drawing.Point(8, 36);
            this.lbl_ItemName.Name = "lbl_ItemName";
            this.lbl_ItemName.Size = new System.Drawing.Size(100, 21);
            this.lbl_ItemName.TabIndex = 596;
            this.lbl_ItemName.Tag = "0";
            this.lbl_ItemName.Text = "Item";
            this.lbl_ItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // fgrid_cust_list
            // 
            this.fgrid_cust_list.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_cust_list.Location = new System.Drawing.Point(0, 69);
            this.fgrid_cust_list.Name = "fgrid_cust_list";
            this.fgrid_cust_list.Rows.DefaultSize = 19;
            this.fgrid_cust_list.Size = new System.Drawing.Size(242, 475);
            this.fgrid_cust_list.StyleInfo = resources.GetString("fgrid_cust_list.StyleInfo");
            this.fgrid_cust_list.TabIndex = 4;
            this.fgrid_cust_list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fgrid_cust_list_MouseDoubleClick);
            // 
            // tabp_information
            // 
            this.tabp_information.Controls.Add(this.c1Sizer2);
            this.tabp_information.Location = new System.Drawing.Point(4, 24);
            this.tabp_information.Margin = new System.Windows.Forms.Padding(0);
            this.tabp_information.Name = "tabp_information";
            this.tabp_information.Size = new System.Drawing.Size(1000, 544);
            this.tabp_information.TabIndex = 1;
            this.tabp_information.Text = "Supplier";
            this.tabp_information.UseVisualStyleBackColor = true;
            // 
            // fgrid_cust
            // 
            this.fgrid_cust.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_cust.ContextMenuStrip = this.ctx_cust;
            this.fgrid_cust.Location = new System.Drawing.Point(0, 73);
            this.fgrid_cust.Name = "fgrid_cust";
            this.fgrid_cust.Rows.DefaultSize = 19;
            this.fgrid_cust.Size = new System.Drawing.Size(1000, 471);
            this.fgrid_cust.StyleInfo = resources.GetString("fgrid_cust.StyleInfo");
            this.fgrid_cust.TabIndex = 5;
            this.fgrid_cust.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_cust_AfterEdit);
            this.fgrid_cust.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_cust_BeforeEdit);
            // 
            // ctx_cust
            // 
            this.ctx_cust.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxt_custUserInsert,
            this.ctxt_custUserDelete,
            this.ctxt_custUserCancel,
            this.ctxt_bar2,
            this.ctxt_custInsert,
            this.ctxt_bar1,
            this.ctxt_view});
            this.ctx_cust.Name = "ctx_cust";
            this.ctx_cust.Size = new System.Drawing.Size(165, 126);
            // 
            // ctxt_custUserInsert
            // 
            this.ctxt_custUserInsert.Name = "ctxt_custUserInsert";
            this.ctxt_custUserInsert.Size = new System.Drawing.Size(164, 22);
            this.ctxt_custUserInsert.Text = "Insert";
            this.ctxt_custUserInsert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_InfoAdd_MouseUp);
            // 
            // ctxt_custUserDelete
            // 
            this.ctxt_custUserDelete.Name = "ctxt_custUserDelete";
            this.ctxt_custUserDelete.Size = new System.Drawing.Size(164, 22);
            this.ctxt_custUserDelete.Text = "Delete";
            this.ctxt_custUserDelete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_InfoDel_MouseUp);
            // 
            // ctxt_custUserCancel
            // 
            this.ctxt_custUserCancel.Name = "ctxt_custUserCancel";
            this.ctxt_custUserCancel.Size = new System.Drawing.Size(164, 22);
            this.ctxt_custUserCancel.Text = "Cancel";
            this.ctxt_custUserCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_InfoCancel_MouseUp);
            // 
            // ctxt_bar2
            // 
            this.ctxt_bar2.Name = "ctxt_bar2";
            this.ctxt_bar2.Size = new System.Drawing.Size(161, 6);
            // 
            // ctxt_custInsert
            // 
            this.ctxt_custInsert.Name = "ctxt_custInsert";
            this.ctxt_custInsert.Size = new System.Drawing.Size(164, 22);
            this.ctxt_custInsert.Text = "Insert customer";
            this.ctxt_custInsert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ctxt_custInsert_MouseUp);
            // 
            // ctxt_bar1
            // 
            this.ctxt_bar1.Name = "ctxt_bar1";
            this.ctxt_bar1.Size = new System.Drawing.Size(161, 6);
            // 
            // ctxt_view
            // 
            this.ctxt_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxt_view_supplier,
            this.ctxt_view_charger});
            this.ctxt_view.Name = "ctxt_view";
            this.ctxt_view.Size = new System.Drawing.Size(164, 22);
            this.ctxt_view.Text = "View";
            // 
            // ctxt_view_supplier
            // 
            this.ctxt_view_supplier.Name = "ctxt_view_supplier";
            this.ctxt_view_supplier.Size = new System.Drawing.Size(122, 22);
            this.ctxt_view_supplier.Text = "Supplier";
            this.ctxt_view_supplier.Click += new System.EventHandler(this.ctxt_view_supplier_Click);
            // 
            // ctxt_view_charger
            // 
            this.ctxt_view_charger.Name = "ctxt_view_charger";
            this.ctxt_view_charger.Size = new System.Drawing.Size(122, 22);
            this.ctxt_view_charger.Text = "Charger";
            this.ctxt_view_charger.Click += new System.EventHandler(this.ctxt_view_charger_Click);
            // 
            // tabp_conv
            // 
            this.tabp_conv.Controls.Add(this.sizer_conv);
            this.tabp_conv.Location = new System.Drawing.Point(4, 24);
            this.tabp_conv.Name = "tabp_conv";
            this.tabp_conv.Size = new System.Drawing.Size(1000, 544);
            this.tabp_conv.TabIndex = 2;
            this.tabp_conv.Text = "Conversion";
            this.tabp_conv.UseVisualStyleBackColor = true;
            // 
            // sizer_conv
            // 
            this.sizer_conv.BorderWidth = 0;
            this.sizer_conv.Controls.Add(this.pnl_convHead);
            this.sizer_conv.Controls.Add(this.fgrid_cust_list_conv);
            this.sizer_conv.Controls.Add(this.fgrid_conv);
            this.sizer_conv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizer_conv.GridDefinition = "12.6838235294118:False:True;86.5808823529412:False:False;\t28.8:True:True;70.8:Fal" +
                "se:False;";
            this.sizer_conv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sizer_conv.Location = new System.Drawing.Point(0, 0);
            this.sizer_conv.Name = "sizer_conv";
            this.sizer_conv.Size = new System.Drawing.Size(1000, 544);
            this.sizer_conv.TabIndex = 3;
            this.sizer_conv.TabStop = false;
            // 
            // pnl_convHead
            // 
            this.pnl_convHead.Controls.Add(this.txt_conv_sup_name);
            this.pnl_convHead.Controls.Add(this.txt_conv_sup_code);
            this.pnl_convHead.Controls.Add(this.lbl_conv_sup);
            this.pnl_convHead.Controls.Add(this.pnl_convTitle);
            this.pnl_convHead.Controls.Add(this.searchPanel2);
            this.pnl_convHead.Location = new System.Drawing.Point(0, 0);
            this.pnl_convHead.Name = "pnl_convHead";
            this.pnl_convHead.Size = new System.Drawing.Size(1000, 69);
            this.pnl_convHead.TabIndex = 4;
            // 
            // txt_conv_sup_name
            // 
            this.txt_conv_sup_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_conv_sup_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_conv_sup_name.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_conv_sup_name.Location = new System.Drawing.Point(220, 36);
            this.txt_conv_sup_name.MaxLength = 40;
            this.txt_conv_sup_name.Name = "txt_conv_sup_name";
            this.txt_conv_sup_name.Size = new System.Drawing.Size(210, 21);
            this.txt_conv_sup_name.TabIndex = 706;
            this.txt_conv_sup_name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_conv_sup_name_KeyUp);
            // 
            // txt_conv_sup_code
            // 
            this.txt_conv_sup_code.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_conv_sup_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_conv_sup_code.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_conv_sup_code.Location = new System.Drawing.Point(109, 36);
            this.txt_conv_sup_code.MaxLength = 40;
            this.txt_conv_sup_code.Name = "txt_conv_sup_code";
            this.txt_conv_sup_code.Size = new System.Drawing.Size(110, 21);
            this.txt_conv_sup_code.TabIndex = 705;
            this.txt_conv_sup_code.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_conv_sup_code_KeyUp);
            // 
            // lbl_conv_sup
            // 
            this.lbl_conv_sup.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conv_sup.ImageIndex = 1;
            this.lbl_conv_sup.ImageList = this.img_Label;
            this.lbl_conv_sup.Location = new System.Drawing.Point(8, 36);
            this.lbl_conv_sup.Name = "lbl_conv_sup";
            this.lbl_conv_sup.Size = new System.Drawing.Size(100, 21);
            this.lbl_conv_sup.TabIndex = 596;
            this.lbl_conv_sup.Tag = "0";
            this.lbl_conv_sup.Text = "Supplier";
            this.lbl_conv_sup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_convTitle
            // 
            this.pnl_convTitle.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_convTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_convTitle.ForeColor = System.Drawing.Color.Navy;
            this.pnl_convTitle.Image = ((System.Drawing.Image)(resources.GetObject("pnl_convTitle.Image")));
            this.pnl_convTitle.Location = new System.Drawing.Point(0, 0);
            this.pnl_convTitle.Name = "pnl_convTitle";
            this.pnl_convTitle.Size = new System.Drawing.Size(231, 30);
            this.pnl_convTitle.TabIndex = 595;
            this.pnl_convTitle.Text = "      Search Condition";
            this.pnl_convTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fgrid_cust_list_conv
            // 
            this.fgrid_cust_list_conv.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_cust_list_conv.Location = new System.Drawing.Point(0, 73);
            this.fgrid_cust_list_conv.Name = "fgrid_cust_list_conv";
            this.fgrid_cust_list_conv.Rows.DefaultSize = 19;
            this.fgrid_cust_list_conv.Size = new System.Drawing.Size(288, 471);
            this.fgrid_cust_list_conv.StyleInfo = resources.GetString("fgrid_cust_list_conv.StyleInfo");
            this.fgrid_cust_list_conv.TabIndex = 1;
            this.fgrid_cust_list_conv.DoubleClick += new System.EventHandler(this.fgrid_cust_list_conv_DoubleClick);
            // 
            // fgrid_conv
            // 
            this.fgrid_conv.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_conv.ContextMenuStrip = this.ctx_conv;
            this.fgrid_conv.Location = new System.Drawing.Point(292, 73);
            this.fgrid_conv.Name = "fgrid_conv";
            this.fgrid_conv.Rows.DefaultSize = 19;
            this.fgrid_conv.Size = new System.Drawing.Size(708, 471);
            this.fgrid_conv.StyleInfo = resources.GetString("fgrid_conv.StyleInfo");
            this.fgrid_conv.TabIndex = 0;
            this.fgrid_conv.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_conv_AfterEdit);
            this.fgrid_conv.DragDrop += new System.Windows.Forms.DragEventHandler(this.fgrid_conv_DragDrop);
            this.fgrid_conv.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_conv_BeforeEdit);
            // 
            // ctx_conv
            // 
            this.ctx_conv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxt_SearchExcel,
            this.ctxt_bar,
            this.ctxt_convDelete,
            this.ctxt_convCancel,
            this.ctxt_convConfirm});
            this.ctx_conv.Name = "ctx_conv";
            this.ctx_conv.Size = new System.Drawing.Size(172, 98);
            // 
            // ctxt_SearchExcel
            // 
            this.ctxt_SearchExcel.Name = "ctxt_SearchExcel";
            this.ctxt_SearchExcel.Size = new System.Drawing.Size(171, 22);
            this.ctxt_SearchExcel.Text = "Search excel file";
            this.ctxt_SearchExcel.Click += new System.EventHandler(this.ctxt_SearchExcel_Click);
            // 
            // ctxt_bar
            // 
            this.ctxt_bar.Name = "ctxt_bar";
            this.ctxt_bar.Size = new System.Drawing.Size(168, 6);
            // 
            // ctxt_convDelete
            // 
            this.ctxt_convDelete.Name = "ctxt_convDelete";
            this.ctxt_convDelete.Size = new System.Drawing.Size(171, 22);
            this.ctxt_convDelete.Text = "Delete";
            this.ctxt_convDelete.Visible = false;
            this.ctxt_convDelete.Click += new System.EventHandler(this.ctxt_convDelete_Click);
            // 
            // ctxt_convCancel
            // 
            this.ctxt_convCancel.Name = "ctxt_convCancel";
            this.ctxt_convCancel.Size = new System.Drawing.Size(171, 22);
            this.ctxt_convCancel.Text = "Cancel";
            this.ctxt_convCancel.Visible = false;
            this.ctxt_convCancel.Click += new System.EventHandler(this.ctxt_convCancel_Click);
            // 
            // ctxt_convConfirm
            // 
            this.ctxt_convConfirm.Name = "ctxt_convConfirm";
            this.ctxt_convConfirm.Size = new System.Drawing.Size(171, 22);
            this.ctxt_convConfirm.Text = "Confirm";
            this.ctxt_convConfirm.Click += new System.EventHandler(this.ctxt_convConfirm_Click);
            // 
            // searchPanel1
            // 
            this.searchPanel1.BackColor = System.Drawing.Color.White;
            this.searchPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel1.Location = new System.Drawing.Point(0, 0);
            this.searchPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.searchPanel1.Name = "searchPanel1";
            this.searchPanel1.Size = new System.Drawing.Size(1000, 69);
            this.searchPanel1.TabIndex = 0;
            // 
            // searchPanel2
            // 
            this.searchPanel2.BackColor = System.Drawing.Color.White;
            this.searchPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel2.Location = new System.Drawing.Point(0, 0);
            this.searchPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.searchPanel2.Name = "searchPanel2";
            this.searchPanel2.Size = new System.Drawing.Size(1000, 69);
            this.searchPanel2.TabIndex = 0;
            // 
            // c1Sizer2
            // 
            this.c1Sizer2.BorderWidth = 0;
            this.c1Sizer2.Controls.Add(this.pnl_supHead);
            this.c1Sizer2.Controls.Add(this.fgrid_cust);
            this.c1Sizer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Sizer2.GridDefinition = "12.6838235294118:False:True;86.5808823529412:False:False;\t100:False:False;";
            this.c1Sizer2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer2.Location = new System.Drawing.Point(0, 0);
            this.c1Sizer2.Name = "c1Sizer2";
            this.c1Sizer2.Size = new System.Drawing.Size(1000, 544);
            this.c1Sizer2.TabIndex = 8;
            this.c1Sizer2.TabStop = false;
            // 
            // pnl_supHead
            // 
            this.pnl_supHead.Controls.Add(this.txt_sup_name);
            this.pnl_supHead.Controls.Add(this.txt_sup_code);
            this.pnl_supHead.Controls.Add(this.lbl_sup);
            this.pnl_supHead.Controls.Add(this.lbl_supTitle);
            this.pnl_supHead.Controls.Add(this.searchPanel3);
            this.pnl_supHead.Location = new System.Drawing.Point(0, 0);
            this.pnl_supHead.Name = "pnl_supHead";
            this.pnl_supHead.Size = new System.Drawing.Size(1000, 69);
            this.pnl_supHead.TabIndex = 6;
            // 
            // txt_sup_name
            // 
            this.txt_sup_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_sup_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sup_name.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_sup_name.Location = new System.Drawing.Point(220, 36);
            this.txt_sup_name.MaxLength = 40;
            this.txt_sup_name.Name = "txt_sup_name";
            this.txt_sup_name.Size = new System.Drawing.Size(210, 21);
            this.txt_sup_name.TabIndex = 706;
            this.txt_sup_name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_sup_name_KeyUp);
            // 
            // txt_sup_code
            // 
            this.txt_sup_code.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_sup_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sup_code.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_sup_code.Location = new System.Drawing.Point(109, 36);
            this.txt_sup_code.MaxLength = 40;
            this.txt_sup_code.Name = "txt_sup_code";
            this.txt_sup_code.Size = new System.Drawing.Size(110, 21);
            this.txt_sup_code.TabIndex = 705;
            this.txt_sup_code.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_sup_code_KeyUp);
            // 
            // lbl_sup
            // 
            this.lbl_sup.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sup.ImageIndex = 1;
            this.lbl_sup.ImageList = this.img_Label;
            this.lbl_sup.Location = new System.Drawing.Point(8, 36);
            this.lbl_sup.Name = "lbl_sup";
            this.lbl_sup.Size = new System.Drawing.Size(100, 21);
            this.lbl_sup.TabIndex = 596;
            this.lbl_sup.Tag = "0";
            this.lbl_sup.Text = "Supplier";
            this.lbl_sup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_supTitle
            // 
            this.lbl_supTitle.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_supTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supTitle.ForeColor = System.Drawing.Color.Navy;
            this.lbl_supTitle.Image = ((System.Drawing.Image)(resources.GetObject("lbl_supTitle.Image")));
            this.lbl_supTitle.Location = new System.Drawing.Point(0, 0);
            this.lbl_supTitle.Name = "lbl_supTitle";
            this.lbl_supTitle.Size = new System.Drawing.Size(231, 30);
            this.lbl_supTitle.TabIndex = 595;
            this.lbl_supTitle.Text = "      Search Condition";
            this.lbl_supTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchPanel3
            // 
            this.searchPanel3.BackColor = System.Drawing.Color.White;
            this.searchPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel3.Location = new System.Drawing.Point(0, 0);
            this.searchPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.searchPanel3.Name = "searchPanel3";
            this.searchPanel3.Size = new System.Drawing.Size(1000, 69);
            this.searchPanel3.TabIndex = 0;
            // 
            // Form_Item_Master
            // 
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_Item_Master";
            this.Load += new System.EventHandler(this.Form_Item_Master_Load);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.tab_main.ResumeLayout(false);
            this.tabp_supplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sizer_supplier)).EndInit();
            this.sizer_supplier.ResumeLayout(false);
            this.spc_mat.Panel1.ResumeLayout(false);
            this.spc_mat.Panel2.ResumeLayout(false);
            this.spc_mat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_mat)).EndInit();
            this.ctx_mat.ResumeLayout(false);
            this.pnl_matBtn.ResumeLayout(false);
            this.tab_detail.ResumeLayout(false);
            this.tabp_history.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_history)).EndInit();
            this.pnl_charge.ResumeLayout(false);
            this.tabp_part.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_reinforce)).EndInit();
            this.pnl_search.ResumeLayout(false);
            this.pnl_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_cust_list)).EndInit();
            this.tabp_information.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_cust)).EndInit();
            this.ctx_cust.ResumeLayout(false);
            this.tabp_conv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sizer_conv)).EndInit();
            this.sizer_conv.ResumeLayout(false);
            this.pnl_convHead.ResumeLayout(false);
            this.pnl_convHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_cust_list_conv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_conv)).EndInit();
            this.ctx_conv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer2)).EndInit();
            this.c1Sizer2.ResumeLayout(false);
            this.pnl_supHead.ResumeLayout(false);
            this.pnl_supHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Sizer.C1Sizer c1Sizer1;
        private System.Windows.Forms.TabControl tab_detail;
        private System.Windows.Forms.TabPage tabp_history;
        private System.Windows.Forms.TabPage tabp_part;
        private COM.FSP fgrid_mat;
        private System.Windows.Forms.Panel pnl_search;
        public System.Windows.Forms.Label lbl_title;
        private FlexCosting.Basic.Ctl.SearchPanel searchPanel1;
        private COM.FSP fgrid_history;
        private COM.FSP fgrid_cust_list;
        private COM.FSP fgrid_reinforce;
        private System.Windows.Forms.Label lbl_ItemName;
        private System.Windows.Forms.TextBox txt_itemCode;
        private COM.FSP fgrid_cust;
        private System.Windows.Forms.Panel pnl_matBtn;
        private System.Windows.Forms.Label btn_MatAdd;
        private System.Windows.Forms.Label btn_MatDel;
        private System.Windows.Forms.Label btn_MatCancel;
        private System.Windows.Forms.Panel pnl_charge;
        private System.Windows.Forms.Label btn_ChargeAdd;
        private System.Windows.Forms.Label btn_ChargeDel;
        private System.Windows.Forms.Label btn_ChargeCancel;
        private System.Windows.Forms.TabControl tab_main;
        private System.Windows.Forms.TabPage tabp_supplier;
        private System.Windows.Forms.TabPage tabp_information;
        private C1.Win.C1Sizer.C1Sizer sizer_supplier;
        private System.Windows.Forms.SplitContainer spc_mat;
        private System.Windows.Forms.ContextMenuStrip ctx_mat;
        private System.Windows.Forms.ContextMenuStrip ctx_cust;
        private System.Windows.Forms.ToolStripMenuItem ctxt_view;
        private System.Windows.Forms.ToolStripMenuItem ctxt_view_supplier;
        private System.Windows.Forms.ToolStripMenuItem ctxt_view_charger;
        private System.Windows.Forms.ToolStripMenuItem ctxt_custUserInsert;
        private System.Windows.Forms.ToolStripMenuItem ctxt_custUserDelete;
        private System.Windows.Forms.ToolStripSeparator ctxt_bar1;
        private System.Windows.Forms.ToolStripMenuItem ctxt_custUserCancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ToolStripMenuItem ctxt_matInsert;
        private System.Windows.Forms.ToolStripMenuItem ctxt_matDelete;
        private System.Windows.Forms.ToolStripMenuItem ctxt_matCancel;
        private System.Windows.Forms.TextBox txt_itemName;
        private System.Windows.Forms.TabPage tabp_conv;
        private COM.FSP fgrid_conv;
        private COM.FSP fgrid_cust_list_conv;
        private System.Windows.Forms.ContextMenuStrip ctx_conv;
        private System.Windows.Forms.ToolStripMenuItem ctxt_SearchExcel;
        private System.Windows.Forms.ToolStripMenuItem ctxt_convDelete;
        private System.Windows.Forms.ToolStripMenuItem ctxt_convConfirm;
        private System.Windows.Forms.ToolStripSeparator ctxt_bar;
        private System.Windows.Forms.ToolStripMenuItem ctxt_convCancel;
        private System.Windows.Forms.ToolStripMenuItem ctxt_custInsert;
        private System.Windows.Forms.ToolStripSeparator ctxt_bar2;
        private C1.Win.C1Sizer.C1Sizer sizer_conv;
        private System.Windows.Forms.Panel pnl_convHead;
        private System.Windows.Forms.TextBox txt_conv_sup_name;
        private System.Windows.Forms.TextBox txt_conv_sup_code;
        private System.Windows.Forms.Label lbl_conv_sup;
        public System.Windows.Forms.Label pnl_convTitle;
        private FlexCosting.Basic.Ctl.SearchPanel searchPanel2;
        private C1.Win.C1Sizer.C1Sizer c1Sizer2;
        private System.Windows.Forms.Panel pnl_supHead;
        private System.Windows.Forms.TextBox txt_sup_name;
        private System.Windows.Forms.TextBox txt_sup_code;
        private System.Windows.Forms.Label lbl_sup;
        public System.Windows.Forms.Label lbl_supTitle;
        private FlexCosting.Basic.Ctl.SearchPanel searchPanel3;
    }
}
