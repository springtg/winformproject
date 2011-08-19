using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 
using Lassalle.Flow;
using Lassalle.Flow.Layout.Tree;  


namespace FlexBase.Yield
{
	public class Form_BC_BOMTemplate : COM.PCHWinForm.Pop_Large
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.Panel pnl_B;
		private System.Windows.Forms.StatusBar stbar;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		public System.Windows.Forms.Panel pnl_BT;
		public System.Windows.Forms.Panel panel6;
		private C1.Win.C1List.C1Combo cmb_bom_template;
		private System.Windows.Forms.Label lbl_bom_template;
		public System.Windows.Forms.PictureBox pictureBox36;
		public System.Windows.Forms.PictureBox pictureBox37;
		public System.Windows.Forms.PictureBox pictureBox38;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.PictureBox pictureBox39;
		public System.Windows.Forms.PictureBox pictureBox40;
		public System.Windows.Forms.PictureBox pictureBox41;
		public System.Windows.Forms.PictureBox pictureBox42;
		public System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel pnl_BB;
		private System.Windows.Forms.Splitter splitter1;
		private Lassalle.Flow.AddFlow addflow_bom_temp;
		private COM.FSP fgrid_templatelink;
		private COM.FSP fgrid_templatenode;
		private C1.Win.C1Command.C1ContextMenu ContextMenu;
		private C1.Win.C1Command.C1CommandLink c1CommandLink8;
		private C1.Win.C1Command.C1Command cmenu_NodeDelete;
		private C1.Win.C1Command.C1CommandLink c1CommandLink9;
		private C1.Win.C1Command.C1CommandMenu cmenu_Tree;
		private C1.Win.C1Command.C1CommandLink c1CommandLink10;
		private C1.Win.C1Command.C1Command cmenu_Tree_North;
		private C1.Win.C1Command.C1CommandLink c1CommandLink11;
		private C1.Win.C1Command.C1Command cmenu_Tree_West;
		private C1.Win.C1Command.C1CommandLink c1CommandLink12;
		private C1.Win.C1Command.C1Command cmenu_Seperator1;
		private C1.Win.C1Command.C1CommandLink c1CommandLink13;
		private C1.Win.C1Command.C1CommandMenu cmenu_Property;
		private C1.Win.C1Command.C1CommandLink c1CommandLink14;
		private C1.Win.C1Command.C1Command cmenu_NodeProp;
		private C1.Win.C1Command.C1CommandLink c1CommandLink15;
		private C1.Win.C1Command.C1Command cmenu_LinkProp;
		private C1.Win.C1Command.C1CommandLink c1CommandLink16;
		private C1.Win.C1Command.C1Command cmenu_Seperator2;
		private System.Windows.Forms.ToolTip toolTip1;
		public COM.FSP fgrid_template_tree;
		private System.Windows.Forms.ContextMenu cmenu_grid;
		private System.Windows.Forms.MenuItem menuItem_Copy;
		private System.Windows.Forms.MenuItem menuItem_Paste;
		private System.Windows.Forms.MenuItem menuItem_OneByOne;
		private System.Windows.Forms.Label btn_Rename;
		private System.Windows.Forms.Label btn_Refresh;
		private System.Windows.Forms.Label btn_New;
		private System.Windows.Forms.Label btn_Save;
		private System.Windows.Forms.Label btn_SaveAs;
		private System.Windows.Forms.Label btn_DeleteAll;
        private System.Windows.Forms.TextBox txt_BOMTemp;
		private System.ComponentModel.IContainer components = null;

		public Form_BC_BOMTemplate()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			Init_Form();


		}

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion	

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BC_BOMTemplate));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.pnl_B = new System.Windows.Forms.Panel();
            this.fgrid_templatelink = new COM.FSP();
            this.fgrid_templatenode = new COM.FSP();
            this.addflow_bom_temp = new Lassalle.Flow.AddFlow();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnl_BB = new System.Windows.Forms.Panel();
            this.fgrid_template_tree = new COM.FSP();
            this.cmenu_grid = new System.Windows.Forms.ContextMenu();
            this.menuItem_Copy = new System.Windows.Forms.MenuItem();
            this.menuItem_Paste = new System.Windows.Forms.MenuItem();
            this.menuItem_OneByOne = new System.Windows.Forms.MenuItem();
            this.pnl_BT = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_BOMTemp = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Label();
            this.btn_New = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Label();
            this.btn_SaveAs = new System.Windows.Forms.Label();
            this.btn_Rename = new System.Windows.Forms.Label();
            this.btn_DeleteAll = new System.Windows.Forms.Label();
            this.cmb_bom_template = new C1.Win.C1List.C1Combo();
            this.lbl_bom_template = new System.Windows.Forms.Label();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stbar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.ContextMenu = new C1.Win.C1Command.C1ContextMenu();
            this.c1CommandLink8 = new C1.Win.C1Command.C1CommandLink();
            this.cmenu_NodeDelete = new C1.Win.C1Command.C1Command();
            this.c1CommandLink9 = new C1.Win.C1Command.C1CommandLink();
            this.cmenu_Tree = new C1.Win.C1Command.C1CommandMenu();
            this.c1CommandLink10 = new C1.Win.C1Command.C1CommandLink();
            this.cmenu_Tree_North = new C1.Win.C1Command.C1Command();
            this.c1CommandLink11 = new C1.Win.C1Command.C1CommandLink();
            this.cmenu_Tree_West = new C1.Win.C1Command.C1Command();
            this.c1CommandLink12 = new C1.Win.C1Command.C1CommandLink();
            this.cmenu_Seperator1 = new C1.Win.C1Command.C1Command();
            this.c1CommandLink13 = new C1.Win.C1Command.C1CommandLink();
            this.cmenu_Property = new C1.Win.C1Command.C1CommandMenu();
            this.c1CommandLink14 = new C1.Win.C1Command.C1CommandLink();
            this.cmenu_NodeProp = new C1.Win.C1Command.C1Command();
            this.c1CommandLink15 = new C1.Win.C1Command.C1CommandLink();
            this.cmenu_LinkProp = new C1.Win.C1Command.C1Command();
            this.c1CommandLink16 = new C1.Win.C1Command.C1CommandLink();
            this.cmenu_Seperator2 = new C1.Win.C1Command.C1Command();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_B.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_templatelink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_templatenode)).BeginInit();
            this.pnl_BB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_template_tree)).BeginInit();
            this.pnl_BT.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_bom_template)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
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
            this.c1CommandHolder1.Commands.Add(this.ContextMenu);
            this.c1CommandHolder1.Commands.Add(this.cmenu_NodeDelete);
            this.c1CommandHolder1.Commands.Add(this.cmenu_Tree);
            this.c1CommandHolder1.Commands.Add(this.cmenu_Tree_North);
            this.c1CommandHolder1.Commands.Add(this.cmenu_Tree_West);
            this.c1CommandHolder1.Commands.Add(this.cmenu_Seperator1);
            this.c1CommandHolder1.Commands.Add(this.cmenu_Property);
            this.c1CommandHolder1.Commands.Add(this.cmenu_NodeProp);
            this.c1CommandHolder1.Commands.Add(this.cmenu_LinkProp);
            this.c1CommandHolder1.Commands.Add(this.cmenu_Seperator2);
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
            // pnl_B
            // 
            this.pnl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_B.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_B.Controls.Add(this.fgrid_templatelink);
            this.pnl_B.Controls.Add(this.fgrid_templatenode);
            this.pnl_B.Controls.Add(this.addflow_bom_temp);
            this.pnl_B.Controls.Add(this.splitter1);
            this.pnl_B.Controls.Add(this.pnl_BB);
            this.pnl_B.Controls.Add(this.pnl_BT);
            this.pnl_B.Location = new System.Drawing.Point(0, 64);
            this.pnl_B.Name = "pnl_B";
            this.pnl_B.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.pnl_B.Size = new System.Drawing.Size(792, 480);
            this.pnl_B.TabIndex = 25;
            // 
            // fgrid_templatelink
            // 
            this.fgrid_templatelink.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:136;Caption:\"Link 디비 헤더 정보\";}\t";
            this.fgrid_templatelink.Location = new System.Drawing.Point(624, 272);
            this.fgrid_templatelink.Name = "fgrid_templatelink";
            this.fgrid_templatelink.Rows.DefaultSize = 18;
            this.fgrid_templatelink.Size = new System.Drawing.Size(152, 40);
            this.fgrid_templatelink.StyleInfo = resources.GetString("fgrid_templatelink.StyleInfo");
            this.fgrid_templatelink.TabIndex = 553;
            this.fgrid_templatelink.Visible = false;
            // 
            // fgrid_templatenode
            // 
            this.fgrid_templatenode.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:136;Caption:\"Node 디비 헤더 정보\";}\t";
            this.fgrid_templatenode.Location = new System.Drawing.Point(624, 232);
            this.fgrid_templatenode.Name = "fgrid_templatenode";
            this.fgrid_templatenode.Rows.DefaultSize = 18;
            this.fgrid_templatenode.Size = new System.Drawing.Size(152, 40);
            this.fgrid_templatenode.StyleInfo = resources.GetString("fgrid_templatenode.StyleInfo");
            this.fgrid_templatenode.TabIndex = 552;
            this.fgrid_templatenode.Visible = false;
            // 
            // addflow_bom_temp
            // 
            this.addflow_bom_temp.BackColor = System.Drawing.SystemColors.Window;
            this.c1CommandHolder1.SetC1ContextMenu(this.addflow_bom_temp, this.ContextMenu);
            this.addflow_bom_temp.CanDrawLink = false;
            this.addflow_bom_temp.CanDrawNode = false;
            this.addflow_bom_temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addflow_bom_temp.Location = new System.Drawing.Point(5, 93);
            this.addflow_bom_temp.Name = "addflow_bom_temp";
            this.addflow_bom_temp.Size = new System.Drawing.Size(782, 227);
            this.addflow_bom_temp.TabIndex = 550;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(5, 320);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(782, 3);
            this.splitter1.TabIndex = 546;
            this.splitter1.TabStop = false;
            // 
            // pnl_BB
            // 
            this.pnl_BB.Controls.Add(this.fgrid_template_tree);
            this.pnl_BB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_BB.Location = new System.Drawing.Point(5, 323);
            this.pnl_BB.Name = "pnl_BB";
            this.pnl_BB.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnl_BB.Size = new System.Drawing.Size(782, 152);
            this.pnl_BB.TabIndex = 545;
            // 
            // fgrid_template_tree
            // 
            this.fgrid_template_tree.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_template_tree.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_template_tree.ContextMenu = this.cmenu_grid;
            this.fgrid_template_tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_template_tree.Location = new System.Drawing.Point(0, 5);
            this.fgrid_template_tree.Name = "fgrid_template_tree";
            this.fgrid_template_tree.Rows.DefaultSize = 18;
            this.fgrid_template_tree.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_template_tree.Size = new System.Drawing.Size(782, 147);
            this.fgrid_template_tree.StyleInfo = resources.GetString("fgrid_template_tree.StyleInfo");
            this.fgrid_template_tree.TabIndex = 34;
            this.fgrid_template_tree.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_template_tree_AfterEdit);
            this.fgrid_template_tree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_template_tree_MouseUp);
            this.fgrid_template_tree.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_template_tree_BeforeEdit);
            this.fgrid_template_tree.EnterCell += new System.EventHandler(this.fgrid_template_tree_EnterCell);
            // 
            // cmenu_grid
            // 
            this.cmenu_grid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_Copy,
            this.menuItem_Paste,
            this.menuItem_OneByOne});
            // 
            // menuItem_Copy
            // 
            this.menuItem_Copy.Index = 0;
            this.menuItem_Copy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.menuItem_Copy.Text = "Copy";
            this.menuItem_Copy.Click += new System.EventHandler(this.menuItem_Copy_Click);
            // 
            // menuItem_Paste
            // 
            this.menuItem_Paste.Index = 1;
            this.menuItem_Paste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.menuItem_Paste.Text = "Paste";
            this.menuItem_Paste.Click += new System.EventHandler(this.menuItem_Paste_Click);
            // 
            // menuItem_OneByOne
            // 
            this.menuItem_OneByOne.Index = 2;
            this.menuItem_OneByOne.Text = "Set size group (one by one)";
            this.menuItem_OneByOne.Click += new System.EventHandler(this.menuItem_OneByOne_Click);
            // 
            // pnl_BT
            // 
            this.pnl_BT.Controls.Add(this.panel6);
            this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BT.Location = new System.Drawing.Point(5, 0);
            this.pnl_BT.Name = "pnl_BT";
            this.pnl_BT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnl_BT.Size = new System.Drawing.Size(782, 93);
            this.pnl_BT.TabIndex = 544;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.Controls.Add(this.txt_BOMTemp);
            this.panel6.Controls.Add(this.btn_Refresh);
            this.panel6.Controls.Add(this.btn_New);
            this.panel6.Controls.Add(this.btn_Save);
            this.panel6.Controls.Add(this.btn_SaveAs);
            this.panel6.Controls.Add(this.btn_Rename);
            this.panel6.Controls.Add(this.btn_DeleteAll);
            this.panel6.Controls.Add(this.cmb_bom_template);
            this.panel6.Controls.Add(this.lbl_bom_template);
            this.panel6.Controls.Add(this.pictureBox36);
            this.panel6.Controls.Add(this.pictureBox37);
            this.panel6.Controls.Add(this.pictureBox38);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.pictureBox39);
            this.panel6.Controls.Add(this.pictureBox40);
            this.panel6.Controls.Add(this.pictureBox41);
            this.panel6.Controls.Add(this.pictureBox42);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(782, 88);
            this.panel6.TabIndex = 20;
            // 
            // txt_BOMTemp
            // 
            this.txt_BOMTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BOMTemp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_BOMTemp.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BOMTemp.Location = new System.Drawing.Point(111, 36);
            this.txt_BOMTemp.Name = "txt_BOMTemp";
            this.txt_BOMTemp.Size = new System.Drawing.Size(103, 21);
            this.txt_BOMTemp.TabIndex = 675;
            this.txt_BOMTemp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_BOMTemp_KeyUp);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Refresh.ImageIndex = 0;
            this.btn_Refresh.ImageList = this.img_Button;
            this.btn_Refresh.Location = new System.Drawing.Point(182, 58);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(70, 23);
            this.btn_Refresh.TabIndex = 555;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Refresh.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            this.btn_Refresh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Refresh.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Refresh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_New.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_New.ImageIndex = 0;
            this.btn_New.ImageList = this.img_Button;
            this.btn_New.Location = new System.Drawing.Point(111, 58);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(70, 23);
            this.btn_New.TabIndex = 556;
            this.btn_New.Text = "New";
            this.btn_New.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_New.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            this.btn_New.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_New.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_New.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Save.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Save.ImageIndex = 0;
            this.btn_Save.ImageList = this.img_Button;
            this.btn_Save.Location = new System.Drawing.Point(395, 58);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(70, 23);
            this.btn_Save.TabIndex = 557;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Save.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            this.btn_Save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Save.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_SaveAs
            // 
            this.btn_SaveAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_SaveAs.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_SaveAs.ImageIndex = 0;
            this.btn_SaveAs.ImageList = this.img_Button;
            this.btn_SaveAs.Location = new System.Drawing.Point(466, 58);
            this.btn_SaveAs.Name = "btn_SaveAs";
            this.btn_SaveAs.Size = new System.Drawing.Size(70, 23);
            this.btn_SaveAs.TabIndex = 558;
            this.btn_SaveAs.Text = "Save As";
            this.btn_SaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SaveAs.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_SaveAs.Click += new System.EventHandler(this.btn_SaveAs_Click);
            this.btn_SaveAs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_SaveAs.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_SaveAs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Rename
            // 
            this.btn_Rename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Rename.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Rename.ImageIndex = 0;
            this.btn_Rename.ImageList = this.img_Button;
            this.btn_Rename.Location = new System.Drawing.Point(324, 58);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Size = new System.Drawing.Size(70, 23);
            this.btn_Rename.TabIndex = 554;
            this.btn_Rename.Text = "Rename";
            this.btn_Rename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Rename.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Rename.Click += new System.EventHandler(this.btn_Rename_Click);
            this.btn_Rename.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Rename.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Rename.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_DeleteAll
            // 
            this.btn_DeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_DeleteAll.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_DeleteAll.ImageIndex = 0;
            this.btn_DeleteAll.ImageList = this.img_Button;
            this.btn_DeleteAll.Location = new System.Drawing.Point(253, 58);
            this.btn_DeleteAll.Name = "btn_DeleteAll";
            this.btn_DeleteAll.Size = new System.Drawing.Size(70, 23);
            this.btn_DeleteAll.TabIndex = 559;
            this.btn_DeleteAll.Text = "Delete";
            this.btn_DeleteAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_DeleteAll.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_DeleteAll.Click += new System.EventHandler(this.btn_DeleteAll_Click);
            this.btn_DeleteAll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_DeleteAll.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_DeleteAll.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // cmb_bom_template
            // 
            this.cmb_bom_template.AccessibleDescription = "";
            this.cmb_bom_template.AccessibleName = "";
            this.cmb_bom_template.AddItemSeparator = ';';
            this.cmb_bom_template.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_bom_template.Caption = "";
            this.cmb_bom_template.CaptionHeight = 17;
            this.cmb_bom_template.CaptionStyle = style1;
            this.cmb_bom_template.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_bom_template.ColumnCaptionHeight = 18;
            this.cmb_bom_template.ColumnFooterHeight = 18;
            this.cmb_bom_template.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_bom_template.ContentHeight = 16;
            this.cmb_bom_template.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_bom_template.EditorBackColor = System.Drawing.Color.White;
            this.cmb_bom_template.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_bom_template.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_bom_template.EditorHeight = 16;
            this.cmb_bom_template.EvenRowStyle = style2;
            this.cmb_bom_template.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_bom_template.FooterStyle = style3;
            this.cmb_bom_template.HeadingStyle = style4;
            this.cmb_bom_template.HighLightRowStyle = style5;
            this.cmb_bom_template.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_bom_template.Images"))));
            this.cmb_bom_template.ItemHeight = 15;
            this.cmb_bom_template.Location = new System.Drawing.Point(215, 36);
            this.cmb_bom_template.MatchEntryTimeout = ((long)(2000));
            this.cmb_bom_template.MaxDropDownItems = ((short)(5));
            this.cmb_bom_template.MaxLength = 2;
            this.cmb_bom_template.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_bom_template.Name = "cmb_bom_template";
            this.cmb_bom_template.OddRowStyle = style6;
            this.cmb_bom_template.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_bom_template.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_bom_template.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_bom_template.SelectedStyle = style7;
            this.cmb_bom_template.Size = new System.Drawing.Size(321, 20);
            this.cmb_bom_template.Style = style8;
            this.cmb_bom_template.TabIndex = 104;
            this.cmb_bom_template.SelectedValueChanged += new System.EventHandler(this.cmb_bom_template_SelectedValueChanged);
            this.cmb_bom_template.PropBag = resources.GetString("cmb_bom_template.PropBag");
            // 
            // lbl_bom_template
            // 
            this.lbl_bom_template.ImageIndex = 0;
            this.lbl_bom_template.ImageList = this.img_Label;
            this.lbl_bom_template.Location = new System.Drawing.Point(10, 36);
            this.lbl_bom_template.Name = "lbl_bom_template";
            this.lbl_bom_template.Size = new System.Drawing.Size(100, 21);
            this.lbl_bom_template.TabIndex = 99;
            this.lbl_bom_template.Text = "BOM Template";
            this.lbl_bom_template.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox36
            // 
            this.pictureBox36.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox36.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox36.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox36.Image")));
            this.pictureBox36.Location = new System.Drawing.Point(767, 24);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(15, 47);
            this.pictureBox36.TabIndex = 26;
            this.pictureBox36.TabStop = false;
            // 
            // pictureBox37
            // 
            this.pictureBox37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox37.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox37.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox37.Image")));
            this.pictureBox37.Location = new System.Drawing.Point(766, 0);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(16, 32);
            this.pictureBox37.TabIndex = 21;
            this.pictureBox37.TabStop = false;
            // 
            // pictureBox38
            // 
            this.pictureBox38.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox38.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox38.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox38.Image")));
            this.pictureBox38.Location = new System.Drawing.Point(216, 0);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(784, 40);
            this.pictureBox38.TabIndex = 0;
            this.pictureBox38.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 30);
            this.label3.TabIndex = 20;
            this.label3.Text = "      Selected BOM Template .";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox39
            // 
            this.pictureBox39.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox39.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox39.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox39.Image")));
            this.pictureBox39.Location = new System.Drawing.Point(160, 24);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(781, 47);
            this.pictureBox39.TabIndex = 27;
            this.pictureBox39.TabStop = false;
            // 
            // pictureBox40
            // 
            this.pictureBox40.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox40.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox40.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox40.Image")));
            this.pictureBox40.Location = new System.Drawing.Point(766, 71);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(16, 17);
            this.pictureBox40.TabIndex = 23;
            this.pictureBox40.TabStop = false;
            // 
            // pictureBox41
            // 
            this.pictureBox41.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox41.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox41.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox41.Image")));
            this.pictureBox41.Location = new System.Drawing.Point(144, 69);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(782, 19);
            this.pictureBox41.TabIndex = 24;
            this.pictureBox41.TabStop = false;
            // 
            // pictureBox42
            // 
            this.pictureBox42.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox42.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox42.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox42.Image")));
            this.pictureBox42.Location = new System.Drawing.Point(0, 67);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(168, 21);
            this.pictureBox42.TabIndex = 22;
            this.pictureBox42.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 47);
            this.pictureBox1.TabIndex = 358;
            this.pictureBox1.TabStop = false;
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 546);
            this.stbar.Name = "stbar";
            this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.stbar.ShowPanels = true;
            this.stbar.Size = new System.Drawing.Size(792, 20);
            this.stbar.TabIndex = 44;
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            // 
            // ContextMenu
            // 
            this.ContextMenu.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink8,
            this.c1CommandLink9,
            this.c1CommandLink12,
            this.c1CommandLink13,
            this.c1CommandLink16});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Popup += new System.EventHandler(this.ContextMenu_Popup);
            // 
            // c1CommandLink8
            // 
            this.c1CommandLink8.Command = this.cmenu_NodeDelete;
            // 
            // cmenu_NodeDelete
            // 
            this.cmenu_NodeDelete.Name = "cmenu_NodeDelete";
            this.cmenu_NodeDelete.Text = "Delete Node";
            this.cmenu_NodeDelete.Click += new C1.Win.C1Command.ClickEventHandler(this.cmenu_NodeDelete_Click);
            // 
            // c1CommandLink9
            // 
            this.c1CommandLink9.Command = this.cmenu_Tree;
            // 
            // cmenu_Tree
            // 
            this.cmenu_Tree.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink10,
            this.c1CommandLink11});
            this.cmenu_Tree.Name = "cmenu_Tree";
            this.cmenu_Tree.Text = "Process Tree";
            // 
            // c1CommandLink10
            // 
            this.c1CommandLink10.Command = this.cmenu_Tree_North;
            // 
            // cmenu_Tree_North
            // 
            this.cmenu_Tree_North.Name = "cmenu_Tree_North";
            this.cmenu_Tree_North.Text = "North";
            this.cmenu_Tree_North.Click += new C1.Win.C1Command.ClickEventHandler(this.cmenu_Tree_North_Click);
            // 
            // c1CommandLink11
            // 
            this.c1CommandLink11.Command = this.cmenu_Tree_West;
            // 
            // cmenu_Tree_West
            // 
            this.cmenu_Tree_West.Name = "cmenu_Tree_West";
            this.cmenu_Tree_West.Text = "West";
            this.cmenu_Tree_West.Click += new C1.Win.C1Command.ClickEventHandler(this.cmenu_Tree_West_Click);
            // 
            // c1CommandLink12
            // 
            this.c1CommandLink12.Command = this.cmenu_Seperator1;
            // 
            // cmenu_Seperator1
            // 
            this.cmenu_Seperator1.Name = "cmenu_Seperator1";
            this.cmenu_Seperator1.Text = "-";
            // 
            // c1CommandLink13
            // 
            this.c1CommandLink13.Command = this.cmenu_Property;
            // 
            // cmenu_Property
            // 
            this.cmenu_Property.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink14,
            this.c1CommandLink15});
            this.cmenu_Property.Name = "cmenu_Property";
            this.cmenu_Property.Text = "Property";
            // 
            // c1CommandLink14
            // 
            this.c1CommandLink14.Command = this.cmenu_NodeProp;
            // 
            // cmenu_NodeProp
            // 
            this.cmenu_NodeProp.Name = "cmenu_NodeProp";
            this.cmenu_NodeProp.Text = "Node";
            this.cmenu_NodeProp.Click += new C1.Win.C1Command.ClickEventHandler(this.cmenu_NodeProp_Click);
            // 
            // c1CommandLink15
            // 
            this.c1CommandLink15.Command = this.cmenu_LinkProp;
            // 
            // cmenu_LinkProp
            // 
            this.cmenu_LinkProp.Name = "cmenu_LinkProp";
            this.cmenu_LinkProp.Text = "Link";
            this.cmenu_LinkProp.Click += new C1.Win.C1Command.ClickEventHandler(this.cmenu_LinkProp_Click);
            // 
            // c1CommandLink16
            // 
            this.c1CommandLink16.Command = this.cmenu_Seperator2;
            // 
            // cmenu_Seperator2
            // 
            this.cmenu_Seperator2.Name = "cmenu_Seperator2";
            this.cmenu_Seperator2.Text = "-";
            // 
            // Form_BC_BOMTemplate
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.stbar);
            this.Controls.Add(this.pnl_B);
            this.Name = "Form_BC_BOMTemplate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.pnl_B, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_B.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_templatelink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_templatenode)).EndInit();
            this.pnl_BB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_template_tree)).EndInit();
            this.pnl_BT.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_bom_template)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
 
		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 

		//새로 생기는 노드, 링크 순번, 중복 없애기 위함  
		private int _Link_Index = 0;   

		//선택한 임가공 코드, 코드명
		string _ProcessCode, _ProcessName; 
 
		//콤보박스에서 선택한 템플릿 코드, 코드명
		private string _SelectTempCode = "", _SelectTempName = "";
		//Save As 할때 기준이 되는 템플릿 코드
		private string _OrgTempCode = ""; 

		//Node Tag 
		private string _TagSeparator = ":";

		//Node Default Width, Height
		private float _NodeWidth = 60, _NodeHeight = 20;

		//Max Level Length
		private int _MaxLevelLength = 0;
		
		//그리드 기본 행 고정 값
		private int _Rowfixed = 2; 

		//Raw Material Key Code Value
		private string _RawMatKeyCd = "13";

		//Raw Material Code Value
		private string _RawMatCd = "02J13000";




		#endregion 

		#region 멤버 메서드

 
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			try
			{
                //Title
				this.Text = "BOM Template";
				lbl_MainTitle.Text = "BOM Template";

				ClassLib.ComFunction.SetLangDic(this);
 
				//폼 크기 최대화 버튼 허용
				this.MaximizeBox = true; 
				this.c1ToolBar1.Visible = false;


				// template_tree 그리드 설정
				//fgrid_template_tree.Set_Grid("SBC_BOM_TEMPLATE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);   


				fgrid_template_tree.Set_Grid("SBC_BOM_TEMPLATE", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);   
				fgrid_template_tree.Set_Action_Image(img_Action); 
				fgrid_template_tree.SelectionMode = SelectionModeEnum.CellRange;

				// 사이즈 그룹 설정위한 사이즈 문대 표시
				Set_SizeHead();
 

				// node, link 디비 헤더 정보 위해서 그리드 설정
				fgrid_templatenode.Set_Grid("NODE_TEMPLATE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_templatelink.Set_Grid("LINK_TEMPLATE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
 

				// Template_Tree_code 콤보 
				DataTable dt_ret;
				dt_ret = Select_TemplateTree_Code(" ");

				ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_bom_template, 0, 1, 2);
				cmb_bom_template.Splits[0].DisplayColumns[0].Width = 0;
				cmb_bom_template.Splits[0].DisplayColumns[1].Width = 321;
				cmb_bom_template.Splits[0].DisplayColumns[2].Width = 0;
				cmb_bom_template.DropDownWidth = 321;


				//ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_bom_template, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name); 
				dt_ret.Dispose();

				// addflow 초기화
				ClassLib.ComFunction.Clear_AddFlow(addflow_bom_temp);


				menuItem_Copy.Visible = false;
				menuItem_Paste.Visible = false;
				menuItem_OneByOne.Visible = false;


  	 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		/// <summary>
		/// Set_SizeHead : 사이즈 그룹 설정위한 사이즈 문대 표시 
		/// </summary>
		private void Set_SizeHead()
		{

			DataTable dt_ret;

			dt_ret = ClassLib.ComFunction.Select_SIZE_COLHEAD_ALL(ClassLib.ComVar.This_Factory);
			fgrid_template_tree.Display_CrossTab_Head(dt_ret, 25, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxCS_SIZE_START);

			dt_ret.Dispose();

		}



		#region Display addflow 

		/// <summary>
		/// 
		/// </summary>
		private void BOMTemplate_Tree_View()
		{
			try
			{
				DataSet ds_ret;
				DataTable dt_tree, dt_tree_tail;
				DataTable dt_node, dt_link;
				
				// addflow 초기화
				ClassLib.ComFunction.Clear_AddFlow(addflow_bom_temp);

				ds_ret = Select_BOM_Template(_SelectTempCode); 
				dt_tree = ds_ret.Tables[0];
				dt_tree_tail = ds_ret.Tables[1];

				fgrid_template_tree.Tree.Column = 1; 
				fgrid_template_tree.Rows.Count = _Rowfixed;

				if(dt_tree.Rows.Count == 0) 
				{
					dt_tree.Dispose();
					return;
				}
				 
				//템플릿 트리로 표시
				Display_GridTree(dt_tree);  
				Display_GridTree_SizeGroup(dt_tree_tail);
				 
				dt_node = Select_BomTemplate_Node_List();	//노드정보 조회	
				Display_Node(dt_node);	//노드 Display
		            
				dt_link = Select_BomTemplate_Link_List();	//링크정보 조회
				Display_Link(dt_node, dt_link);	//링크 Display
				

				dt_tree.Dispose();
				dt_tree_tail.Dispose();
				dt_node.Dispose();
				dt_link.Dispose();
				ds_ret.Dispose();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "BOMTemplate_Tree_View", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
		}




		/// <summary>
		/// 노드정보 그리드 데이타로 노드 Display
		/// </summary>
		private void Display_Node(DataTable arg_dt)
		{
			 
			Lassalle.Flow.Node node; 

			string[] token = null;
			_MaxLevelLength = 0;

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				node = new Lassalle.Flow.Node();

				node = addflow_bom_temp.Nodes.Add(Convert.ToSingle(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_NODE_TEMPLATE.IxLEFT].ToString() ),
					Convert.ToSingle(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_NODE_TEMPLATE.IxTOP].ToString() ), 
					Convert.ToSingle(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_NODE_TEMPLATE.IxWIDTH].ToString() ), 
					Convert.ToSingle(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_NODE_TEMPLATE.IxHEIGHT].ToString() ) );

 
				node.Text = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_NODE_TEMPLATE.IxTEXT].ToString();
				node.Tooltip = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_NODE_TEMPLATE.IxTEXT].ToString();

				// Item Code + ":" + Attribute + ":" + Templeate_Level 
				node.Tag = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_NODE_TEMPLATE.IxTAG].ToString();
 

				ClassLib.ComFunction.Set_NodeProp(arg_dt, node, i);


				token = node.Tag.ToString().Split(_TagSeparator.ToCharArray() );
				_MaxLevelLength = (_MaxLevelLength > token[2].Length) ? _MaxLevelLength : token[2].Length;


			}
 
			 

		}

		/// <summary>
		/// 링크정보 그리드 데이타로 링크 Display
		/// </summary>
		private void Display_Link(DataTable arg_dt_node, DataTable arg_dt_link)
		{
			 
			Lassalle.Flow.Link link;
			 
			int org_node, dst_node;
			int max_index = _Link_Index;
 

			for(int i = 0; i < arg_dt_link.Rows.Count; i++)
			{
				link = new Lassalle.Flow.Link(); 
	  
				org_node = ClassLib.ComFunction.Get_Index(arg_dt_node, arg_dt_link.Rows[i].ItemArray[(int)ClassLib.TBSBC_LINK_TEMPLATE.IxORG_NODE].ToString(), (int)ClassLib.TBSBC_NODE_TEMPLATE.IxNODE_CD);
				dst_node = ClassLib.ComFunction.Get_Index(arg_dt_node, arg_dt_link.Rows[i].ItemArray[(int)ClassLib.TBSBC_LINK_TEMPLATE.IxDST_NODE].ToString(), (int)ClassLib.TBSBC_NODE_TEMPLATE.IxNODE_CD);
 
				link = addflow_bom_temp.Nodes[org_node].OutLinks.Add(addflow_bom_temp.Nodes[dst_node]);
				
				link.Tag = arg_dt_link.Rows[i].ItemArray[(int)ClassLib.TBSBC_LINK_TEMPLATE.IxTAG].ToString(); 
				link.Tooltip = arg_dt_link.Rows[i].ItemArray[(int)ClassLib.TBSBC_LINK_TEMPLATE.IxTOOLTIP].ToString(); 
 
				ClassLib.ComFunction.Set_LinkProp(arg_dt_link, link, i); 

				if(max_index <= Convert.ToInt32(link.Tag))  max_index = Convert.ToInt32(link.Tag); 

			} 

			_Link_Index = max_index + 1; 

		}

 

 



		#endregion 

		#region 그리드 트리

		private void Display_GridTree(DataTable dt_ret)
		{  
			fgrid_template_tree.Rows.Count = fgrid_template_tree.Rows.Fixed;   

			fgrid_template_tree.Tree.Column = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_NAME; 

			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
				fgrid_template_tree.Rows.InsertNode(i + fgrid_template_tree.Rows.Fixed,
					dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_LEVEL - 1].ToString().Length - 1);	
		
				insertcell(i, dt_ret.Rows[i].ItemArray);  
			} 
			 

			//SetCols();

			dt_ret.Dispose(); 
		}


		
		 
		/// <summary>
		/// insertcell : 그리드에 값 넣기
		/// </summary>
		/// <param name="arg_row"></param>
		/// <param name="arg_incell"></param>
		private void insertcell(int arg_row, object[] arg_incell)
		{
			int row_fixed = fgrid_template_tree.Rows.Fixed;

			 
			fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxDIVISION] = "";
			fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_TREE_CD]		= arg_incell[0].ToString();
			fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_LEVEL]			= arg_incell[1].ToString();
			fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_STAGE]			= arg_incell[2].ToString();
			fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_TREE_NAME]		= arg_incell[3].ToString();
			fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_CD]			= arg_incell[4].ToString();
			fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_NAME]			= arg_incell[5].ToString();
			
			fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY5]				= arg_incell[10].ToString();
			fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_KEY]			= arg_incell[11].ToString();
			fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxREMARK]					= arg_incell[12].ToString();
			fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxFAVORITE_YN]			= arg_incell[13].ToString();
			fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxSEND_CHK]				= arg_incell[14].ToString();
			fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxSEND_DATE]				= arg_incell[15].ToString();
			fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxUPD_USER]				= arg_incell[16].ToString();
			fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxUPD_YMD]				= arg_incell[17].ToString();
			 


			if(fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_CD].ToString() == _RawMatCd)
			{
				fgrid_template_tree.GetCellRange(arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY1,
												arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY4).StyleNew.DataType = typeof(string);


				fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY1] = "";
				fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY2] = "";
				fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY3] = "";
				fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY4] = "";

				fgrid_template_tree.Rows[arg_row + row_fixed].AllowEditing = false;


			}
			else
			{
				fgrid_template_tree.GetCellRange(arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY1,
												arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY4).StyleNew.DataType = typeof(bool);

				fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY1] = arg_incell[6].ToString();
				fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY2] = arg_incell[7].ToString();
				fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY3] = arg_incell[8].ToString();
				fgrid_template_tree[arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY4] = arg_incell[9].ToString();


			}





			// size column default value setting
			CellRange cr = fgrid_template_tree.GetCellRange(arg_row + row_fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxCS_SIZE_START,
				                                            arg_row + row_fixed, fgrid_template_tree.Cols.Count - 1);
			
			cr.UserData = "";


		}


		/// <summary>
		/// setCols : 그리드를 트리 형식으로 표시
		/// </summary>
		private void SetCols()
		{
			//fgrid_template_tree.Tree.Column = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_NAME;
			//fgrid_template_tree.Tree.Style = TreeStyleFlags.Complete;
			//fgrid_template_tree.Tree.Show(-1);
		}
  







		private void fgrid_template_tree_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				CellRange cr = fgrid_template_tree.Selection;

				if(cr.c1 < (int)ClassLib.TBSBC_BOM_TEMPLATE.IxCS_SIZE_START)
				{
					menuItem_OneByOne.Visible = true;
				}
				else
				{
					menuItem_OneByOne.Visible = false;
				}



				Set_SizeGroup(e.Button);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_template_tree_MouseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		/// <summary>
		/// Display_GridTree_SizeGroup : 사이즈 그룹 표시
		/// </summary>
		/// <param name="dt_ret"></param>
		private void Display_GridTree_SizeGroup(DataTable dt_ret)
		{  
			string template_level = "";
			string condition = "";
			DataRow[] findrow = null;
			string cs_size_from = "", cs_size_to = "";
			int size_f = -1, size_t = -1;
			string size_yn = "", mng_unit = "";

			int group_count = 0;
			CellRange cr = fgrid_template_tree.GetCellRange(fgrid_template_tree.Rows.Fixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxCS_SIZE_START);


 
			

			for(int i = fgrid_template_tree.Rows.Fixed; i < fgrid_template_tree.Rows.Count; i++)
			{
				template_level = fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_LEVEL].ToString();
	 

				condition = "TEMPLATE_LEVEL = '" + template_level + "'";
				findrow = dt_ret.Select(condition);

				//-----------------------------------------------------------------------------------------------
				// size group setting
				if(findrow.Length == 0)
				{
					
					size_yn = "False";
					mng_unit = "";

					  
					cr = fgrid_template_tree.GetCellRange(i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxCS_SIZE_START, i, fgrid_template_tree.Cols.Count - 1);
					cr.UserData = group_count++; 
					
				}
				else
				{

					size_yn = findrow[0].ItemArray[(int)ClassLib.TBSBC_BOM_TEMPLATE_TAIL.IxSIZE_YN].ToString();
					mng_unit = findrow[0].ItemArray[(int)ClassLib.TBSBC_BOM_TEMPLATE_TAIL.IxMNG_UNIT].ToString();


					for(int j = 0; j < findrow.Length; j++)
					{
						cs_size_from = findrow[j].ItemArray[(int)ClassLib.TBSBC_BOM_TEMPLATE_TAIL.IxCS_SIZE_FROM].ToString();
						cs_size_to = findrow[j].ItemArray[(int)ClassLib.TBSBC_BOM_TEMPLATE_TAIL.IxCS_SIZE_TO].ToString();

						for(int a = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxCS_SIZE_START; a < fgrid_template_tree.Cols.Count; a++)
						{
							if(cs_size_from == fgrid_template_tree[1, a].ToString())
							{
								size_f = a;
								break;
							} 

						}

						for(int a = size_f; a < fgrid_template_tree.Cols.Count; a++)
						{
							if(cs_size_to == fgrid_template_tree[1, a].ToString())
							{
								size_t = a;
								break;
							} 

						} 
  

						cr = fgrid_template_tree.GetCellRange(i, size_f, i, size_t); 
						cr.UserData = group_count++; 

					} 


					

				} // end if(findrow.Length == 0)
				//-----------------------------------------------------------------------------------------------


				//-----------------------------------------------------------------------------------------------
				// size_yn, unit setting
				if(fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_CD].ToString() != _RawMatCd)
				{ 
					fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxSIZE_YN] = Convert.ToBoolean(size_yn);
					fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxMNG_UNIT] = mng_unit;
				}
				//-----------------------------------------------------------------------------------------------




				// Set Size Group Color
				Display_SizeGroup_Color(i);

			} 
			 

			//SetCols();

			dt_ret.Dispose(); 
		}
 




		// group_count : 사이즈 선택 그룹별로 색깔 처리하기 위한 플래그 
		private int _GroupCount = 0;


		// 사이즈 선택 그룹별로 색깔 구분
		private Color _SizeColor1 = ClassLib.ComVar.ClrSel_Green;
		private Color _SizeColor2 = ClassLib.ComVar.ClrSel_Yellow;
		private Color _CurrentColor; 


		/// <summary>
		/// Set_SizeGroup : 사이즈 그룹 세팅
		/// </summary>
		/// <param name="arg_mousebutton"></param>
		private void Set_SizeGroup(MouseButtons arg_mousebutton)
		{

			if(fgrid_template_tree.Rows.Count <= fgrid_template_tree.Rows.Fixed) return;
		
			int sel_row = fgrid_template_tree.Selection.r1;
			int sel_col1 = fgrid_template_tree.Selection.c1;
			int sel_col2 = fgrid_template_tree.Selection.c2;

			int start_col = (sel_col1 < sel_col2) ? sel_col1 : sel_col2;

			if(start_col < (int)ClassLib.TBSBC_BOM_TEMPLATE.IxCS_SIZE_START) return;


			if(arg_mousebutton != MouseButtons.Right) return;


			_GroupCount++;
			 


			CellRange cr;
			cr = fgrid_template_tree.GetCellRange(sel_row, sel_col1, sel_row, sel_col2);
			cr.UserData = _GroupCount.ToString();
 


			Display_SizeGroup_Color(sel_row);

			// update 표시
			fgrid_template_tree.Update_Row(sel_row);
		

		}



		/// <summary>
		/// Display_SizeGroup_Color : 색깔 표시
		/// </summary>
		private void Display_SizeGroup_Color(int arg_row)
		{

			int size_f = -1, size_t = -1;
			string before_flag = "", now_flag = "";
			_CurrentColor = _SizeColor2;

			size_f = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxCS_SIZE_START;

			CellRange cr;

			while(true)
			{
				cr = fgrid_template_tree.GetCellRange(arg_row, size_f); 

				before_flag = (cr.UserData == null) ? "" : cr.UserData.ToString(); 


				for(int k = size_f; k < fgrid_template_tree.Cols.Count; k++)
				{   

					cr = fgrid_template_tree.GetCellRange(arg_row, k); 

					now_flag = (cr.UserData == null) ? "" : cr.UserData.ToString(); 

					if(before_flag == now_flag)
					{
						size_t = k;
					}
					else
					{
						break;
					}

				}
 


				// 색깔 표시
				if(_CurrentColor.Equals(_SizeColor1) )
				{
					_CurrentColor = _SizeColor2;
				}
				else
				{
					_CurrentColor = _SizeColor1;
				}


				//fgrid_template_tree.GetCellRange(arg_row, size_f, arg_row, size_t).StyleNew.BackColor = _CurrentColor;

				for(int i = size_f; i <= size_t; i++)
				{
					fgrid_template_tree.GetCellRange(arg_row, i, arg_row, i).StyleNew.BackColor = _CurrentColor;
				}
 
 


				size_f = size_t + 1;

				if(size_f == fgrid_template_tree.Cols.Count) break;

			} // end while 


		}



		#endregion

		
		/// <summary>
		/// bom template tree code 전체 노드 삭제
		/// </summary>
		private void Delete_All()
		{
			DialogResult dr; 
			bool save_flag = false;
    

			
			dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete, this); 
			if(dr == DialogResult.No) return;  
 
 
			save_flag = Delete_SBC_BOM_TEMPLATE();
 

			if(!save_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotDelete, this);
				return;
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndDelete, this); 

				// Workflow 코드 콤보 리스트 세팅
				txt_BOMTemp.Text = "";
				cmb_bom_template.SelectedIndex = -1;
				
				// Template_Tree_code 콤보 
				DataTable dt_ret;
				dt_ret = Select_TemplateTree_Code(" ");
				//ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_bom_template, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name); 

				ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_bom_template, 0, 1, 2);
				cmb_bom_template.Splits[0].DisplayColumns[0].Width = 0;
				cmb_bom_template.Splits[0].DisplayColumns[1].Width = 321;
				cmb_bom_template.Splits[0].DisplayColumns[2].Width = 0;
				cmb_bom_template.DropDownWidth = 321;

				dt_ret.Dispose();

				// addflow 초기화
				ClassLib.ComFunction.Clear_AddFlow(addflow_bom_temp);

				// 그리드 초기화
				fgrid_template_tree.Rows.Count = fgrid_template_tree.Rows.Fixed;


			} 
		}


		/// <summary>
		/// ReName_Template_Tree_Cd : template tree name 변경
		/// </summary>
		private void ReName_Template_Tree_Cd()
		{

			FlexBase.MaterialBase.Pop_SaveName pop_form = new FlexBase.MaterialBase.Pop_SaveName(this.Name.ToString(), _SelectTempName);
			pop_form.ShowDialog();

			if(!pop_form._Close_Save || ClassLib.ComVar.Parameter_PopUp[0] == "") return;
			 		  
			_SelectTempName = ClassLib.ComVar.Parameter_PopUp[0];

			bool save_flag = Save_ReName_Template_Tree_Cd(); 


			if(!save_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				return;
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);

				// Template_Tree_code 콤보
				DataTable dt_ret;
				dt_ret = Select_TemplateTree_Code(" ");
				//ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_bom_template, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name); 
				
				ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_bom_template, 0, 1, 2);
				cmb_bom_template.Splits[0].DisplayColumns[0].Width = 0;
				cmb_bom_template.Splits[0].DisplayColumns[1].Width = 321;
				cmb_bom_template.Splits[0].DisplayColumns[2].Width = 0;
				cmb_bom_template.DropDownWidth = 321;

				cmb_bom_template.SelectedValue = _SelectTempCode;
				dt_ret.Dispose();




				BOMTemplate_Tree_View();

			}

				
			 


		}
  



		#region Save with SizeGroup 


		/// <summary>
		/// Save_BOMTemplate : 
		/// </summary>
		/// <param name="arg_saveas_flag">if (save_as) then true else false</param>
		private void Save_BOMTemplate(bool arg_saveas_flag)
		{
			try
			{
				
				
				bool make_flag = false;

				// Next Template Code 추출
				string next_cd = Get_Next_Template_Cd();

				_SelectTempCode = (_SelectTempCode == "") ? next_cd : _SelectTempCode;
				
				// Template Key 조합
				string template_key = Get_Template_Key();

				bool check_rawmat_exist = Check_RawMat_Exist(template_key);

				if(! check_rawmat_exist)
				{
					//					_SelectTempCode = "";
					//					_SelectTempName = "";
					ClassLib.ComFunction.User_Message("At least one [Raw Material]", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				for(int i = _Rowfixed; i < fgrid_template_tree.Rows.Count; i++)
				{
					// [다른이름으로 저장하기] 일때는 모두 신규처리
					if(arg_saveas_flag)
					{
						fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxDIVISION] = "I";
					}

					fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_TREE_CD] = _SelectTempCode;
					fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_TREE_NAME] = _SelectTempName;
					fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_KEY] = template_key;
				}

 
				// 하나 이상의 속성이 세팅되어야 함, 속성 설정 체크
				bool check_set_property = Check_Set_Property();

				if(!check_set_property)
				{
					//					_SelectTempCode = "";
					//					_SelectTempName = "";
					ClassLib.ComFunction.User_Message("At least set one [Attribute]", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}


				
				bool exist_yn = Check_Duplicate(template_key);

 
				// 중복, 저장 불가능
				if(exist_yn)
				{
					//					_SelectTempCode = "";
					//					_SelectTempName = "";
					ClassLib.ComFunction.User_Message("Duplicate BOM Template Tree", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error); 


					// [다른이름으로 저장하기] 일때는 모두 신규처리 -> cancel
					if(arg_saveas_flag)
					{
						for(int i = _Rowfixed; i < fgrid_template_tree.Rows.Count; i++)
						{  
							fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxDIVISION] = ""; 
						}
					}


					return;
				}
				 
				 
				

				// 1. Make Save Node List
				// 2. Make Save Link List
				// 3. Make Save Grid Data
				// 4. Exe_Modify_Procedure 실행  


				make_flag = Save_BomTemplate_Node_List(true);

				if(!make_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}
				else
				{
					make_flag = Save_BomTemplate_Link_List(false);

					if(!make_flag)
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						return;
					}
					else
					{
						make_flag = Save_BomTemplate_Tree_Tail(false);

						if(!make_flag)
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
							return;
						}
						else
						{

							make_flag = Save_BomTemplate_Tree(false);

							if(!make_flag)
							{
								ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
								return;
							}
							else
							{
								DataSet ds_ret;

								ds_ret = MyOraDB.Exe_Modify_Procedure();

								if(ds_ret == null)  // error
								{
									ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
									return;
								}
								else
								{
									ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
									ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);

									// Template_Tree_code 콤보
									DataTable dt_ret;
									dt_ret = Select_TemplateTree_Code(" ");
									//ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_bom_template, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name); 

									ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_bom_template, 0, 1, 2);
									cmb_bom_template.Splits[0].DisplayColumns[0].Width = 0;
									cmb_bom_template.Splits[0].DisplayColumns[1].Width = 321;
									cmb_bom_template.Splits[0].DisplayColumns[2].Width = 0;
									cmb_bom_template.DropDownWidth = 321;


									cmb_bom_template.SelectedValue = _SelectTempCode;
									dt_ret.Dispose();

									BOMTemplate_Tree_View();
								}
 

							} // end if save 4  
 

						} // end if save 3 
					} // end if save 2
				} // end if save 1


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_BOMTemplate", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}





		/// <summary>
		/// Check_Duplicate : 구조 중복 체크
		/// </summary>
		/// <param name="arg_template_key"></param>
		/// <returns></returns>
		private bool Check_Duplicate(string arg_template_key)
		{

			int template_key_count = fgrid_template_tree.Rows.Count - fgrid_template_tree.Rows.Fixed;
			string template_level = "";
			string template_cd = "";
			string property1 = "", property2 = "", property3 = "", property4 = "", property5 = "";
			string mng_unit = "";
			string template_key = "";
			string template_sizegroup = "";
			int template_sizegroup_count = 0;

			int size_f = -1, size_t = -1;
			string before_flag = "", now_flag = "";
			CellRange cr;
			string cs_size_from = "", cs_size_to = "";

			for(int i = fgrid_template_tree.Rows.Fixed; i < fgrid_template_tree.Rows.Count; i++)
			{



				template_level = fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_LEVEL].ToString();

				template_cd = fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_CD].ToString();

				if(template_cd == _RawMatCd)
				{
					property1 = "N";
					property2 = "N"; 
					property3 = "N"; 
					property4 = "N"; 
				}
				else
				{
					property1 = (Convert.ToBoolean(fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY1].ToString() ) ) ? "Y" : "N";
					property2 = (Convert.ToBoolean(fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY2].ToString() ) ) ? "Y" : "N"; 
					property3 = (Convert.ToBoolean(fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY3].ToString() ) ) ? "Y" : "N"; 
					property4 = (Convert.ToBoolean(fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY4].ToString() ) ) ? "Y" : "N";

				}


				property5 = fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY5].ToString().Trim();

				if(fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxMNG_UNIT] == null)
				{
					mng_unit = "";
				}
				else
				{
					mng_unit = fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxMNG_UNIT].ToString().Trim();
				}



				if(template_key.Equals("") )
				{
					template_key = @"'" + arg_template_key + template_level + property1 + property2 + property3 + property4 + property5 + @"'";
				}
				else
				{
					template_key += @", '" + arg_template_key + template_level + property1 + property2 + property3 + property4 + property5 + @"'";
				} 




				size_f = -1;
				size_t = -1;
				before_flag = "";
				now_flag = "";

				size_f = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxCS_SIZE_START;

						

				while(true)
				{
					cr = fgrid_template_tree.GetCellRange(i, size_f); 

					before_flag = (cr.UserData == null) ? "" : cr.UserData.ToString(); 


					for(int k = size_f; k < fgrid_template_tree.Cols.Count; k++)
					{   

						cr = fgrid_template_tree.GetCellRange(i, k); 

						now_flag = (cr.UserData == null) ? "" : cr.UserData.ToString(); 

						if(before_flag == now_flag)
						{
							size_t = k;
						}
						else
						{
							break;
						}

					}
  
					
					cs_size_from = fgrid_template_tree[1, size_f].ToString();
					cs_size_to = fgrid_template_tree[1, size_t].ToString();


					if(template_sizegroup.Equals("") )
					{
						template_sizegroup = @"'" + template_level + cs_size_from + cs_size_to + mng_unit + @"'";
					}
					else
					{
						template_sizegroup += @", '" + template_level + cs_size_from + cs_size_to + mng_unit + @"'";
					} 


				 

					template_sizegroup_count++;

					size_f = size_t + 1;

					if(size_f == fgrid_template_tree.Cols.Count) break;

				} // end while




			} // end for i

 

			bool exist_yn = Check_Duplicate_DB(_SelectTempCode, 
				template_key, 
				template_key_count.ToString(), 
				template_sizegroup, 
				template_sizegroup_count.ToString() );


			return exist_yn;





		}






		/// <summary>
		/// 
		/// </summary>
		/// <param name="arg_templatekey"></param>
		/// <returns></returns>
		private bool Check_Duplicate_DB(string arg_template_tree_cd,
			string arg_template_key,
			string arg_template_key_count,
			string arg_template_sizegroup,
			string arg_template_sizegroup_count)
		{  
			try
			{
				COM.OraDB MyOraDB = new COM.OraDB(); 
				DataSet ds_ret;  
				DataTable dt_ret;
 


				MyOraDB.ReDim_Parameter(6);
				MyOraDB.Process_Name = "PKG_SBC_BOM_TEMPLATE.CHECK_EXIST_EQUAL_TEMPLATE"; 
				
				MyOraDB.Parameter_Name[0] = "ARG_TEMPLATE_TREE_CD";
				MyOraDB.Parameter_Name[1] = "ARG_TEMPLATE_KEY"; 
				MyOraDB.Parameter_Name[2] = "ARG_TEMPLATE_KEY_COUNT";
				MyOraDB.Parameter_Name[3] = "ARG_TEMPLATE_SIZE_GROUP";
				MyOraDB.Parameter_Name[4] = "ARG_TEMPLATE_SIZE_GROUP_COUNT"; 
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

				MyOraDB.Parameter_Values[0] = arg_template_tree_cd;
				MyOraDB.Parameter_Values[1] = arg_template_key;
				MyOraDB.Parameter_Values[2] = arg_template_key_count; 
				MyOraDB.Parameter_Values[3] = arg_template_sizegroup;
				MyOraDB.Parameter_Values[4] = arg_template_sizegroup_count;
				MyOraDB.Parameter_Values[5] = ""; 
				 
				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return true; 
				dt_ret = ds_ret.Tables[MyOraDB.Process_Name]; 
				
				if(dt_ret.Rows[0].ItemArray[0].ToString() == "Y")
				{
					return true;
				}
				else
				{
					return false;
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Check_Duplicate_DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return true;
			} 
		}



		#endregion

		#endregion  

		#region 이벤트


		#region combobox 이벤트


		private void txt_BOMTemp_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{

				if(e.KeyCode != Keys.Enter) return;

				this.Cursor = Cursors.WaitCursor;

//				//template bom code combo list 
//				DataTable dt_ret = Select_TemplateTree_Code(txt_BOMTemp.Text.Trim() ); 
//
//				//ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_bom_template, 0, 1, false, 0, 210);
//				
//				ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_bom_template, 0, 1, 2);
//				cmb_bom_template.Splits[0].DisplayColumns[0].Width = 0;
//				cmb_bom_template.Splits[0].DisplayColumns[1].Width = 321;
//				cmb_bom_template.Splits[0].DisplayColumns[2].Width = 0;
//				cmb_bom_template.DropDownWidth = 321;
//
//				dt_ret.Dispose();





				DataTable dt_ret;
				dt_ret = Select_TemplateTree_Code(txt_BOMTemp.Text.Trim() );   

				ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_bom_template, 0, 1, 2);
				cmb_bom_template.Splits[0].DisplayColumns[0].Width = 0;
				cmb_bom_template.Splits[0].DisplayColumns[1].Width = 321;
				cmb_bom_template.Splits[0].DisplayColumns[2].Width = 0;
				cmb_bom_template.DropDownWidth = 321;

				dt_ret.Dispose();




				fgrid_template_tree.Rows.Count = fgrid_template_tree.Rows.Fixed;


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_BOMTemp_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}



		private void cmb_bom_template_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{  
				if(cmb_bom_template.SelectedIndex == -1) return;

				_SelectTempCode = cmb_bom_template.SelectedValue.ToString();
				_SelectTempName = cmb_bom_template.Columns[1].Text; 
				  
				txt_BOMTemp.Text = _SelectTempCode;


				BOMTemplate_Tree_View();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_bom_template_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
 
		#endregion 

		#region 이벤트_그리드 공통

		/// <summary>
		/// 조회한 데이타 그리드에...
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_fgrid"></param>
		private void Display_Grid(DataTable arg_dt, C1FlexGrid arg_fgrid)//dt_ret, fgrid_templatenode)
		{
			arg_fgrid.Rows.Count = _Rowfixed;
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1;
 
			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1); 
			} 
		}

		
		private void fgrid_template_tree_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if ((fgrid_template_tree.Rows.Fixed > 0) && (fgrid_template_tree.Row >= fgrid_template_tree.Rows.Fixed))
			{
				fgrid_template_tree.Buffer_CellData = (fgrid_template_tree[fgrid_template_tree.Row, fgrid_template_tree.Col] == null) ? "" : fgrid_template_tree[fgrid_template_tree.Row, fgrid_template_tree.Col].ToString();
			}
		}


		private void fgrid_template_tree_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			try
			{

				fgrid_template_tree.Update_Row();

				if(fgrid_template_tree[e.Row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_CD].ToString() == _RawMatCd) return;

				//그리드 property 속성 변경에 따른 addflow Node Tag 값 변경 (token[1])
				string sel_level = fgrid_template_tree[e.Row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_LEVEL].ToString();

				Lassalle.Flow.Node node;
				string[] token = null;
				string attribute = "";


				foreach(Item item in addflow_bom_temp.Items)
				{
					if(item is Lassalle.Flow.Node)
					{
						node = (Lassalle.Flow.Node)item;

						token = node.Tag.ToString().Split(_TagSeparator.ToCharArray() );

						if(sel_level != token[2]) continue;

						//그리드 property 속성 변경에 따른 addflow Node Tag 값 변경 (token[1])
						attribute = (Convert.ToBoolean(fgrid_template_tree[e.Row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY1].ToString()) ) ? "1" : "0";
						attribute += (Convert.ToBoolean(fgrid_template_tree[e.Row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY2].ToString()) ) ? "1" : "0";
						attribute += (Convert.ToBoolean(fgrid_template_tree[e.Row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY3].ToString()) ) ? "1" : "0";
						attribute += (Convert.ToBoolean(fgrid_template_tree[e.Row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY4].ToString()) ) ? "1" : "0";


						node.Tag = token[0] + _TagSeparator + attribute + _TagSeparator + token[2];

					} // end if

				} // end foreach

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_template_tree_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		private void fgrid_template_tree_EnterCell(object sender, System.EventArgs e)
		{
			try
			{

				if(fgrid_template_tree.Rows.Count == fgrid_template_tree.Rows.Fixed) return;

				int sel_row = fgrid_template_tree.Selection.r1;
				int sel_col = fgrid_template_tree.Selection.c1;
				int template_code_col = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_CD;
				int remarks_col = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxREMARK;

				//초기 조회 단계는 제외
				if(fgrid_template_tree[sel_row, template_code_col] == null) return;

				if(fgrid_template_tree[sel_row, template_code_col].ToString() != _RawMatCd) return;
				
				if(sel_col != remarks_col) 
				{
					fgrid_template_tree.Rows[sel_row].AllowEditing = false;
				}
				else
				{
					fgrid_template_tree.Rows[sel_row].AllowEditing = true;
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_template_tree_EnterCell", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		#endregion
 
		#region addFlow 이벤트 

		/// <summary>
		/// TreeLayout : 트리로 재구성
		/// </summary>
		/// <param name="orientation"></param>
		private void TreeLayout(Lassalle.Flow.Layout.Tree.Orientation orientation)
		{ 
			try
			{
				addflow_bom_temp.BeginAction(1003);
 
				// Create the TFlow component and perform the Tree Layout

                Lassalle.Flow.Layout.Tree.TFlow tflow = new Lassalle.Flow.Layout.Tree.TFlow();

                tflow.LayerDistance = 30;
                tflow.VertexDistance = 30;
                tflow.DrawingStyle = Lassalle.Flow.Layout.Tree.DrawingStyle.Layered;
				tflow.Orientation = orientation;
                tflow.Layout(addflow_bom_temp); 
				 
				addflow_bom_temp.EndAction();
			}
			catch (TFlowException e)
			{      
				MessageBox.Show(e.Message, this.Text);                
			}	 
		}


		#endregion

		#region 버튼클릭시 이미지변경
 

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
			
		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 

		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
		}

		
 

		#endregion  

		#region 버튼 클릭 이벤트

		private void btn_DeleteAll_Click(object sender, System.EventArgs e)
		{
			try
			{    
				Delete_All();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_DeleteAll_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
 
		   
		


		private void btn_Refresh_Click(object sender, System.EventArgs e)
		{
			try
			{  
				if(cmb_bom_template.SelectedIndex == -1) return;

				_SelectTempCode = cmb_bom_template.SelectedValue.ToString();
				_SelectTempName = cmb_bom_template.Columns[1].Text; 
				  
				BOMTemplate_Tree_View();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Refresh_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void btn_New_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Template_Tree_code 콤보
				DataTable dt_ret = Select_TemplateTree_Code(" ");   
				//COM.ComCtl.Set_ComboList(dt_ret, cmb_bom_template, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name);

				//ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_bom_template, 0, 1, false, 0, 210);
				
				ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_bom_template, 0, 1, 2);
				cmb_bom_template.Splits[0].DisplayColumns[0].Width = 0;
				cmb_bom_template.Splits[0].DisplayColumns[1].Width = 321;
				cmb_bom_template.Splits[0].DisplayColumns[2].Width = 0;
				cmb_bom_template.DropDownWidth = 321;

		   
				ClassLib.ComFunction.Clear_AddFlow(addflow_bom_temp);

				txt_BOMTemp.Text = "";
				cmb_bom_template.SelectedIndex = -1; 
				
				_SelectTempCode = "";
				_SelectTempName = "";

				fgrid_template_tree.Rows.Count = fgrid_template_tree.Rows.Fixed;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


 

		private void btn_Save_Click(object sender, System.EventArgs e)
		{
			try
			{  

				// 신규 저장 이므로 팝업창 처리
				if(_SelectTempCode == "")
				{  
					//FlexBase.Yield.Pop_BOMTemplateName pop_form = new Pop_BOMTemplateName(_SelectTempName);
					FlexBase.MaterialBase.Pop_SaveName pop_form = new FlexBase.MaterialBase.Pop_SaveName(this.Name.ToString(), _SelectTempName);
					pop_form.ShowDialog();

					if(pop_form._Close_Save && ClassLib.ComVar.Parameter_PopUp[0] != "")
					{
						 
						//_SelectTempCode = "";
						_SelectTempName = ClassLib.ComVar.Parameter_PopUp[0];

						//BOM Template 저장 
						//Save_BOMTemplate(); 

 
						Save_BOMTemplate(false);
						
					}

				}
				// 신규 아니므로 기존 이름 그대로 저장 처리
				else
				{
					//BOM Template 저장 
					//Save_BOMTemplate(); 

 
					Save_BOMTemplate(false);
										

				}

				
				

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		private void btn_SaveAs_Click(object sender, System.EventArgs e)
		{
			try
			{
				//FlexBase.Yield.Pop_BOMTemplateName pop_form = new Pop_BOMTemplateName("");
				FlexBase.MaterialBase.Pop_SaveName pop_form = new FlexBase.MaterialBase.Pop_SaveName(this.Name.ToString(), "");
				pop_form.ShowDialog();

				if(pop_form._Close_Save)
				{  
//					//Save As 복사 원본
//					_OrgTempCode = _SelectTempCode;

					string next_cd = Get_Next_Template_Cd(); 
					_SelectTempCode = next_cd;
					_SelectTempName = ClassLib.ComVar.Parameter_PopUp[0];
 
////					//BOM Template 저장 
////					Save_BOMTemplate(); 
//
//					Save_AS_BOMTemplate();

					Save_BOMTemplate(true);



				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_SaveAs_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}




		private void btn_Rename_Click(object sender, System.EventArgs e)
		{
			try
			{
				ReName_Template_Tree_Cd();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Rename_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		#region 저장

		/// <summary>
		/// Save_AS_BOMTemplate : 
		/// </summary>
		private void Save_AS_BOMTemplate()
		{
			try
			{
				
				DataTable dt_ret;
				bool make_flag = false;
 
				// Template Key 조합
				string template_key = Get_Template_Key();

				bool check_rawmat_exist = Check_RawMat_Exist(template_key);

				if(! check_rawmat_exist)
				{
					ClassLib.ComFunction.User_Message("At least one [Raw Material]", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				for(int i = _Rowfixed; i < fgrid_template_tree.Rows.Count; i++)
				{
					fgrid_template_tree[i, 0] = "I";
					fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_TREE_CD] = _SelectTempCode;
					fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_TREE_NAME] = _SelectTempName;
					fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_KEY] = template_key;
				}

  

				bool exist_yn = Check_Duplicate(template_key);

 
				// 중복, 저장 불가능
				if(exist_yn)
				{
					_SelectTempCode = "";
					_SelectTempName = "";
					ClassLib.ComFunction.User_Message("Duplicate BOM Template Tree", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error); 
					return;
				}



				// 1. Make Save Node List
				// 2. Make Save Link List
				// 3. Make Save As Data
				// 4. Make Save Grid Data
				// 5. Exe_Modify_Procedure 실행  


				make_flag = Save_BomTemplate_Node_List(true);

				if(!make_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}
				else
				{
					make_flag = Save_BomTemplate_Link_List(false);

					if(!make_flag)
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						return;
					}
					else
					{
						make_flag = Save_AS_BomTemplate_Tree(false, template_key);
						
						if(!make_flag)
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
							return;
						}
						else
						{  
							 
							DataSet ds_ret;

							ds_ret = MyOraDB.Exe_Modify_Procedure();

							if(ds_ret == null)  // error
							{
								ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
								return;
							}
							else
							{
								ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
								ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);

								// Template_Tree_code 콤보
								dt_ret = Select_TemplateTree_Code(" ");
								//ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_bom_template, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name); 

								ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_bom_template, 0, 1, 2);
								cmb_bom_template.Splits[0].DisplayColumns[0].Width = 0;
								cmb_bom_template.Splits[0].DisplayColumns[1].Width = 321;
								cmb_bom_template.Splits[0].DisplayColumns[2].Width = 0;
								cmb_bom_template.DropDownWidth = 321;


								cmb_bom_template.SelectedValue = _SelectTempCode;
								dt_ret.Dispose();

								BOMTemplate_Tree_View();
							}
							 
 
						} // end if save 3 
					} // end if save 2
				} // end if save 1


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_BOMTemplate", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Save_BOMTemplate : 
		/// </summary>
		private void Save_BOMTemplate()
		{
			try
			{
				
				DataTable dt_ret;
				bool make_flag = false;

				// Next Template Code 추출
				string next_cd = Get_Next_Template_Cd();

				_SelectTempCode = (_SelectTempCode == "") ? next_cd : _SelectTempCode;
				
				// Template Key 조합
				string template_key = Get_Template_Key();

				bool check_rawmat_exist = Check_RawMat_Exist(template_key);

				if(! check_rawmat_exist)
				{
					_SelectTempCode = "";
					_SelectTempName = "";
					ClassLib.ComFunction.User_Message("At least one [Raw Material]", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				for(int i = _Rowfixed; i < fgrid_template_tree.Rows.Count; i++)
				{
					fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_TREE_CD] = _SelectTempCode;
					fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_TREE_NAME] = _SelectTempName;
					fgrid_template_tree[i, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_KEY] = template_key;
				}

 
				// Template Key (Template 구조) 중복 체크
				dt_ret = Check_Duplicate_DB(template_key);

				// 중복, 저장 불가능
				if(! Convert.IsDBNull(dt_ret.Rows[0].ItemArray[0]) )
				{
					_SelectTempCode = "";
					_SelectTempName = "";
					ClassLib.ComFunction.User_Message("Duplicate BOM Template Tree", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
					dt_ret.Dispose();  
					return;
				}
				 
				
				// 중복 아님, 저장 가능
				dt_ret.Dispose();

				// 하나 이상의 속성이 세팅되어야 함, 속성 설정 체크
				bool check_set_property = Check_Set_Property();

				if(!check_set_property)
				{
					_SelectTempCode = "";
					_SelectTempName = "";
					ClassLib.ComFunction.User_Message("At least set one [Attribute]", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// 1. Make Save Node List
				// 2. Make Save Link List
				// 3. Make Save Grid Data
				// 4. Exe_Modify_Procedure 실행  


				make_flag = Save_BomTemplate_Node_List(true);

				if(!make_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}
				else
				{
					make_flag = Save_BomTemplate_Link_List(false);

					if(!make_flag)
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						return;
					}
					else
					{
						make_flag = Save_BomTemplate_Tree(false);

						if(!make_flag)
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
							return;
						}
						else
						{

							make_flag = Save_BomTemplate_Tree_Tail(false);

							if(!make_flag)
							{
								ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
								return;
							}
							else
							{
								DataSet ds_ret;

								ds_ret = MyOraDB.Exe_Modify_Procedure();

								if(ds_ret == null)  // error
								{
									ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
									return;
								}
								else
								{
									ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
									ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);

									// Template_Tree_code 콤보
									dt_ret = Select_TemplateTree_Code(" ");
									//ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_bom_template, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name); 

									ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_bom_template, 0, 1, 2);
									cmb_bom_template.Splits[0].DisplayColumns[0].Width = 0;
									cmb_bom_template.Splits[0].DisplayColumns[1].Width = 321;
									cmb_bom_template.Splits[0].DisplayColumns[2].Width = 0;
									cmb_bom_template.DropDownWidth = 321;

									cmb_bom_template.SelectedValue = _SelectTempCode;
									dt_ret.Dispose();

									BOMTemplate_Tree_View();
								}
 

							} // end if save 4  
 

						} // end if save 3 
					} // end if save 2
				} // end if save 1


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_BOMTemplate", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

 

		/// <summary>
		/// 하나 이상의 속성이 세팅되어야 함, 속성 설정 체크
		/// </summary>
		/// <returns>true : 모두 세팅</returns>
		private bool Check_Set_Property()
		{

			bool not_set = true;

			int template_code_col = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_CD;
			int attribute_model_col = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY1;
			int attribute_style_col = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY2;
			int attribute_cmp_col = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY3;
			int attribute_gen_col = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY4;
			int property5_col = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY5;

			
			for(int i = fgrid_template_tree.Rows.Fixed; i < fgrid_template_tree.Rows.Count; i++)
			{
				if(fgrid_template_tree[i, template_code_col].ToString() == _RawMatCd) continue;

				if(! Convert.ToBoolean(fgrid_template_tree[i, attribute_model_col].ToString() ) 
					&& ! Convert.ToBoolean(fgrid_template_tree[i, attribute_style_col].ToString() )
					&& ! Convert.ToBoolean(fgrid_template_tree[i, attribute_cmp_col].ToString() )
					&& ! Convert.ToBoolean(fgrid_template_tree[i, attribute_gen_col].ToString() )
					&& fgrid_template_tree[i, property5_col].ToString().Equals("") )
				{
					not_set = false;
					fgrid_template_tree.Select(i, 1, i, fgrid_template_tree.Cols.Count - 1, false);
					break;
				}

			} // ennd for i

			if(not_set)
				return true;
			else
				return false;


		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="arg_templatekey"></param>
		/// <returns></returns>
		private DataTable Check_Duplicate_DB(string arg_templatekey)
		{  
			try
			{
				COM.OraDB MyOraDB = new COM.OraDB(); 
				DataSet ds_ret;  

				MyOraDB.ReDim_Parameter(3);
				MyOraDB.Process_Name = "PKG_SBC_BOM_TEMPLATE.CHECK_TEMPLATE_KEY_EXIST"; 
				
				MyOraDB.Parameter_Name[0] = "ARG_TEMPLATE_TREE_NAME";
				MyOraDB.Parameter_Name[1] = "ARG_TEMPLATE_KEY"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = _SelectTempCode;
				MyOraDB.Parameter_Values[1] = arg_templatekey;
				MyOraDB.Parameter_Values[2] = ""; 
				 
				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[MyOraDB.Process_Name]; 
				  

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Check_Duplicate_DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			} 
		}


		/// <summary>
		/// Check_RawMat_Exist : 
		/// </summary>
		/// <param name="arg_templatekey"></param>
		/// <returns></returns>
		private bool Check_RawMat_Exist(string arg_templatekey)
		{
			Lassalle.Flow.Node node;
			string[] token = null;
			int end_node_count = 0, end_raw_count = 0;

			foreach(Item item in addflow_bom_temp.Items)
			{
				if(item is Lassalle.Flow.Node)
				{
					node = new Lassalle.Flow.Node()	;
					
					node = (Lassalle.Flow.Node)item;

					// outlink count == 0 : end node
					if(node.OutLinks.Count != 0) continue;
 
					end_node_count++;

					//token[0] : Template cd (Item cd)
					token = node.Tag.ToString().Split(_TagSeparator.ToCharArray() );

					//end node : always [Raw Material]
					if(token[0].Substring(3, 2) == _RawMatKeyCd) end_raw_count++; 

				} // end if
			} // end foreach


			//equal qty : end node all [Raw Material]
			if(end_node_count == end_raw_count)
				return true;
			else
				return false;

		}


		/// <summary>
		/// Get_Template_Key : 
		/// </summary>
		/// <returns></returns>
		private string Get_Template_Key()
		{
			Lassalle.Flow.Node node;
			string[] token = null;
			string return_key = "";

			for(int i = 1; i <= _MaxLevelLength; i++)
			{ 
				foreach(Item item in addflow_bom_temp.Items)
				{
					if(item is Lassalle.Flow.Node)
					{
						node = (Lassalle.Flow.Node)item;

						//token[0] : template_cd (item_cd)
						//token[1] : group_attribute
						//token[2] : template_level
						token = node.Tag.ToString().Split(_TagSeparator.ToCharArray() );
						
						// 키 조합 만들때 같은 레벨끼리 구성
						if(token[2].Length != i) continue;
						
						//키 구성 : Item_cd 중 second class 코드 2자리로 구성
						// ex : 02J07000 -> 07 이 키가 됨
						return_key += token[0].Substring(3, 2); 

					} // end if
				} // end foreach


			} // end for i 

			return return_key;
		}



		/// <summary>
		/// Get_Next_Template_Cd : 
		/// </summary>
		/// <returns></returns>
		private string Get_Next_Template_Cd()
		{  
			DataSet ds_ret;
 
			MyOraDB.ReDim_Parameter(1); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_BOM_TEMPLATE.GET_NEXT_TEMPLATE_CD";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString(); 

		}



		/// <summary>
		/// Save_StdBom_Node_List : 노드 리스트 저장
		/// </summary>
		private bool Save_BomTemplate_Node_List(bool arg_clear)
		{
			int col_ct = 24;		 
			int save_ct =0 ;							// 저장 행 수
			int para_ct =0;								// 파라미터 값의 저장 배열의 수 

			Lassalle.Flow.Node node;
			string[] token = null;

			try
			{
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_BOM_TEMPLATE.SAVE_TEMPLATE_NODE_LIST"; 
				 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_TEMPLATE_TREE_CD";
				for(int i = (int)ClassLib.TBSBC_NODE_TEMPLATE.IxTEMPLATE_CD + 1; i <= (int)ClassLib.TBSBC_NODE_TEMPLATE.IxWIDTH + 1; i++) 
				{
					MyOraDB.Parameter_Name[i + 1] = "ARG_" + fgrid_templatenode[0, i].ToString();
				}
				MyOraDB.Parameter_Name[23] = "ARG_UPD_USER";
  
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}

				foreach(Item item in addflow_bom_temp.Items)
				{
					if(item is Lassalle.Flow.Node) save_ct++; 
				}
 
				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[col_ct * (save_ct + 1)];
 
				// 각 행의 변경값 Setting
 
				//전부 삭제 후 다시 Insert 작업
				MyOraDB.Parameter_Values[para_ct + 0] = "D";
				MyOraDB.Parameter_Values[para_ct + 1] = _SelectTempCode;  
				for(int i = 2; i <= 23; i++)	//
					MyOraDB.Parameter_Values[para_ct + i] = "";
				para_ct += col_ct; 

				foreach(Item item in addflow_bom_temp.Items)
				{
					if(item is Lassalle.Flow.Node)
					{
						node = (Lassalle.Flow.Node)item;

						int index = node.Index;
						RectangleF rc = node.Rect; 

						//node.Tag = 

						MyOraDB.Parameter_Values[para_ct + 0] = "I";
						MyOraDB.Parameter_Values[para_ct + 1] = _SelectTempCode;  

						token = node.Tag.ToString().Split(_TagSeparator.ToCharArray() );
						MyOraDB.Parameter_Values[para_ct + 2] = token[0];

						MyOraDB.Parameter_Values[para_ct + 3] = string.Format("{0:0000}", index);
						MyOraDB.Parameter_Values[para_ct + 4] = rc.Left.ToString();
						MyOraDB.Parameter_Values[para_ct + 5] = rc.Top.ToString();
						MyOraDB.Parameter_Values[para_ct + 6] = node.Alignment.GetHashCode().ToString();
						MyOraDB.Parameter_Values[para_ct + 7] = node.DashStyle.GetHashCode().ToString();
						MyOraDB.Parameter_Values[para_ct + 8] = node.DrawColor.ToArgb().ToString();
						MyOraDB.Parameter_Values[para_ct + 9] = node.DrawWidth.ToString();
						MyOraDB.Parameter_Values[para_ct + 10] = node.FillColor.ToArgb().ToString();
						MyOraDB.Parameter_Values[para_ct + 11] = node.Font.Name + "/"
							+ node.Font.Size + "/"
							+ node.Font.Bold + "/"
							+ (node.Font.Italic ? true : false) + "/"
							+ (node.Font.Strikeout ? true : false) + "/"
							+ (node.Font.Underline ? true : false); 
						MyOraDB.Parameter_Values[para_ct + 12] = (node.Gradient ? "Y" : "N");
						MyOraDB.Parameter_Values[para_ct + 13] = node.GradientColor.ToArgb().ToString();
						MyOraDB.Parameter_Values[para_ct + 14] = node.GradientMode.GetHashCode().ToString();
						MyOraDB.Parameter_Values[para_ct + 15] = rc.Height.ToString();
						MyOraDB.Parameter_Values[para_ct + 16] = node.Shadow.Style.GetHashCode().ToString() + "/"
							+ node.Shadow.Color.ToArgb().ToString() + "/"
							+ node.Shadow.Size.Width.ToString() + "/"
							+ node.Shadow.Size.Height.ToString();
						MyOraDB.Parameter_Values[para_ct + 17] = node.Shape.Style.GetHashCode().ToString();
						MyOraDB.Parameter_Values[para_ct + 18] = node.Tag.ToString();
						MyOraDB.Parameter_Values[para_ct + 19] = node.Text.ToString();
						MyOraDB.Parameter_Values[para_ct + 20] = node.TextColor.ToArgb().ToString();
						MyOraDB.Parameter_Values[para_ct + 21] = node.Tooltip.ToString();
						MyOraDB.Parameter_Values[para_ct + 22] = rc.Width.ToString(); 
						MyOraDB.Parameter_Values[para_ct + 23] = ClassLib.ComVar.This_User;
	
						para_ct += col_ct;  
					} 
				}

				MyOraDB.Add_Modify_Parameter(arg_clear); 
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_BomTemplate_Node_List",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}
 
		/// <summary>
		/// Save_StdBom_Link_List : 링크 리스트 저장
		/// </summary>
		private bool Save_BomTemplate_Link_List(bool arg_clear)
		{
			int col_ct = 21;		 
			int save_ct =0 ;							// 저장 행 수
			int para_ct =0;								// 파라미터 값의 저장 배열의 수 
			int index = 0;
 
			Lassalle.Flow.Link link;
  
			try
			{
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_BOM_TEMPLATE.SAVE_TEMPLATE_LINK_LIST"; 
				 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_TEMPLATE_TREE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_LINK_SEQ"; 
				MyOraDB.Parameter_Name[3] = "ARG_ORG_NODE"; 
				MyOraDB.Parameter_Name[4] = "ARG_DST_NODE"; 
				MyOraDB.Parameter_Name[5] = "ARG_POINT";  

				for(int i = (int)ClassLib.TBSBC_LINK_TEMPLATE.IxARROW_DST + 1; i <= (int)ClassLib.TBSBC_LINK_TEMPLATE.IxTOOLTIP + 1; i++) 
				{
					MyOraDB.Parameter_Name[i + 3] = "ARG_" + fgrid_templatelink[0, i].ToString();	//
				}
				MyOraDB.Parameter_Name[20] = "ARG_UPD_USER";
  
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}
				 
				// 저장 행 수 구하기 
				foreach(Item item in addflow_bom_temp.Items)
				{
					if(item is Lassalle.Flow.Link) save_ct++;
				} // end foreach 
				  
				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[col_ct * (save_ct + 1)];
 
				// 각 행의 변경값 Setting 
				//전부 삭제 후 다시 Insert 작업
				MyOraDB.Parameter_Values[para_ct + 0] = "D";
				MyOraDB.Parameter_Values[para_ct + 1] = _SelectTempCode;  

				for(int i = 2; i <= 20; i++)
					MyOraDB.Parameter_Values[para_ct + i] = "";
 
				para_ct += col_ct; 

				foreach(Item item in addflow_bom_temp.Items)
				{
					if(item is Lassalle.Flow.Link)
					{
						link = (Lassalle.Flow.Link)item;
 
						//						index = Convert.ToInt32(link.Tag.ToString()); 

						MyOraDB.Parameter_Values[para_ct + 0] = "I";
						MyOraDB.Parameter_Values[para_ct + 1] = _SelectTempCode;
						MyOraDB.Parameter_Values[para_ct + 2] = string.Format("{0:000000}", index);
						MyOraDB.Parameter_Values[para_ct + 3] = link.Org.Index.ToString();
						MyOraDB.Parameter_Values[para_ct + 4] = link.Dst.Index.ToString();
						MyOraDB.Parameter_Values[para_ct + 5] = "";  //point
						MyOraDB.Parameter_Values[para_ct + 6] = link.ArrowDst.Style.GetHashCode().ToString() + "/"
							+ link.ArrowDst.Size.GetHashCode().ToString() + "/"
							+ link.ArrowDst.Angle.GetHashCode().ToString() + "/"
							+ link.ArrowDst.Filled.ToString();
						MyOraDB.Parameter_Values[para_ct + 7] = link.ArrowMid.Style.GetHashCode().ToString() + "/"
							+ link.ArrowMid.Size.GetHashCode().ToString() + "/"
							+ link.ArrowMid.Angle.GetHashCode().ToString() + "/"
							+ link.ArrowMid.Filled.ToString();
						MyOraDB.Parameter_Values[para_ct + 8] = link.ArrowOrg.Style.GetHashCode().ToString() + "/"
							+ link.ArrowOrg.Size.GetHashCode().ToString() + "/"
							+ link.ArrowOrg.Angle.GetHashCode().ToString() + "/"
							+ link.ArrowOrg.Filled.ToString();
						MyOraDB.Parameter_Values[para_ct + 9] = link.DashStyle.GetHashCode().ToString();
						MyOraDB.Parameter_Values[para_ct + 10] = link.DrawColor.ToArgb().ToString();
						MyOraDB.Parameter_Values[para_ct + 11] = link.DrawWidth.ToString(); 
						MyOraDB.Parameter_Values[para_ct + 12] = link.Font.Name + "/"
							+ link.Font.Size + "/"
							+ link.Font.Bold + "/"
							+ (link.Font.Italic ? true : false) + "/"
							+ (link.Font.Strikeout ? true : false) + "/"
							+ (link.Font.Underline ? true : false) ;
						MyOraDB.Parameter_Values[para_ct + 13] = link.Jump.GetHashCode().ToString(); 
						MyOraDB.Parameter_Values[para_ct + 14] = link.Line.Style.GetHashCode().ToString(); 
						MyOraDB.Parameter_Values[para_ct + 15] = link.Line.RoundedCorner.ToString(); 
						MyOraDB.Parameter_Values[para_ct + 16] = link.Tag.ToString();
						MyOraDB.Parameter_Values[para_ct + 17] = "";     //link.Text.ToString();
						MyOraDB.Parameter_Values[para_ct + 18] = "";     //link.TextColor.ToArgb().ToString();
						MyOraDB.Parameter_Values[para_ct + 19] = "";     //link.Tooltip.ToString(); 
						MyOraDB.Parameter_Values[para_ct + 20] = ClassLib.ComVar.This_User;  
						
						para_ct += col_ct;  
						index++;
					}
				}

				MyOraDB.Add_Modify_Parameter(arg_clear);	
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_BomTemplate_Link_List",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}


		/// <summary>
		/// BomTemplate_Tree 저장
		/// </summary>
		private bool Save_BomTemplate_Tree(bool arg_clear)
		{
			try
			{
				//행 수정 상태 해제
				fgrid_template_tree.Select(fgrid_template_tree.Selection.r1, 0, fgrid_template_tree.Selection.r1, fgrid_template_tree.Cols.Count-1, false);

				int col_ct = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxUPD_YMD;  // fgrid_template_tree.Cols.Count - 1;		 
				int row_fixed = fgrid_template_tree.Rows.Fixed;		 
				int save_ct =0 ; 
				int para_ct =0;								 
				int row, col;

				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_BOM_TEMPLATE.SAVE_SBC_BOM_TEMPLATE";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				for(int i = 1; i < col_ct; i++)
				{
					MyOraDB.Parameter_Name[i] = "ARG_" + fgrid_template_tree[0, i].ToString(); 
				}

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}

				// 저장 행 수 구하기
				for(int i = row_fixed ; i < fgrid_template_tree.Rows.Count; i++)
				{
					if(fgrid_template_tree[i, 0].ToString() != "")
					{
						save_ct += 1;
					}
				}
		
				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[col_ct * save_ct ];


				// 각 행의 변경값 Setting
				for(row = row_fixed; row < fgrid_template_tree.Rows.Count ; row++)
				{
					if(fgrid_template_tree[row, 0].ToString() != "")
					{ 
						for(col = 0; col < col_ct ; col++)	// 각 열의 값 Setting
						{  
							// 데이터값 설정 
							if(fgrid_template_tree.Cols[col].Style.DataType != null
								&& fgrid_template_tree.Cols[col].DataType.Equals(typeof(bool)) )
							{ 
								fgrid_template_tree[row, col] = (fgrid_template_tree[row, col] == null) ? "False" : fgrid_template_tree[row, col].ToString();
								MyOraDB.Parameter_Values[para_ct] = (fgrid_template_tree[row,col].ToString() == "True") ? "Y" : "N"; 

								para_ct ++;
							}  
							else if(fgrid_template_tree[0, (col == 0) ? 1 : col].ToString() == "UPD_USER")
							{
								MyOraDB.Parameter_Values[para_ct] = ClassLib.ComVar.This_User ;
								para_ct ++;
							}
							else
							{ 
								MyOraDB.Parameter_Values[para_ct] = (fgrid_template_tree[row, col] == null) ? "" : fgrid_template_tree[row,col].ToString();
								para_ct ++;
							}			
						} 
					}
				}

				MyOraDB.Add_Modify_Parameter(arg_clear); 
			
				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message,"Save_BomTemplate_Tree",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}





		/// <summary>
		/// BomTemplate_Tree_Tail 저장
		/// </summary>
		private bool Save_BomTemplate_Tree_Tail(bool arg_clear)
		{
			try
			{
				//행 수정 상태 해제
				fgrid_template_tree.Select(fgrid_template_tree.Selection.r1, 0, fgrid_template_tree.Selection.r1, fgrid_template_tree.Cols.Count-1, false);

				int col_ct = 11;		 
				int row_fixed = fgrid_template_tree.Rows.Fixed;		 
				int save_ct =0 ; 
				int para_ct =0;								 
				int row;
 


				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_BOM_TEMPLATE.SAVE_SBC_BOM_TEMPLATE_TAIL";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION"; 
				MyOraDB.Parameter_Name[1] = "ARG_TEMPLATE_TREE_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_TEMPLATE_LEVEL"; 
				MyOraDB.Parameter_Name[3] = "ARG_CS_SIZE_FROM"; 
				MyOraDB.Parameter_Name[4] = "ARG_CS_SIZE_TO"; 
				MyOraDB.Parameter_Name[5] = "ARG_SIZE_YN"; 
				MyOraDB.Parameter_Name[6] = "ARG_MNG_UNIT"; 
				MyOraDB.Parameter_Name[7] = "ARG_REMARKS"; 
				MyOraDB.Parameter_Name[8] = "ARG_SEND_CHK"; 
				MyOraDB.Parameter_Name[9] = "ARG_SEND_DATE"; 
				MyOraDB.Parameter_Name[10] = "ARG_UPD_USER"; 

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}




				CellRange cr;
				int size_f = -1, size_t = -1;
				string before_flag = "", now_flag = ""; 
				string size_yn = "", mng_unit = "";



				// 저장 행 수 구하기
				for(int i = row_fixed ; i < fgrid_template_tree.Rows.Count; i++)
				{
					if(fgrid_template_tree[i, 0].ToString() != "")
					{
						// delete
						save_ct++;

						if(fgrid_template_tree[i, 0].ToString() == "D") continue;


						
						size_f = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxCS_SIZE_START;

						

						while(true)
						{
							cr = fgrid_template_tree.GetCellRange(i, size_f); 

							before_flag = (cr.UserData == null) ? "" : cr.UserData.ToString(); 


							for(int k = size_f; k < fgrid_template_tree.Cols.Count; k++)
							{   

								cr = fgrid_template_tree.GetCellRange(i, k); 

								now_flag = (cr.UserData == null) ? "" : cr.UserData.ToString(); 

								if(before_flag == now_flag)
								{
									size_t = k;
								}
								else
								{
									break;
								}

							}
  

							save_ct++;

							size_f = size_t + 1;

							if(size_f == fgrid_template_tree.Cols.Count) break;

						} // end while



					}
				}
		
				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[col_ct * save_ct];


				// 각 행의 변경값 Setting
				for(row = row_fixed; row < fgrid_template_tree.Rows.Count ; row++)
				{
					if(fgrid_template_tree[row, 0].ToString() != "")
					{ 
						MyOraDB.Parameter_Values[para_ct++] = "D";
						MyOraDB.Parameter_Values[para_ct++] = fgrid_template_tree[row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_TREE_CD].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_template_tree[row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_LEVEL].ToString();
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = ""; 



						if(fgrid_template_tree[row, 0].ToString() == "D") continue;


						size_f = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxCS_SIZE_START;

						

						while(true)
						{
							cr = fgrid_template_tree.GetCellRange(row, size_f); 

							before_flag = (cr.UserData == null) ? "" : cr.UserData.ToString(); 


							for(int k = size_f; k < fgrid_template_tree.Cols.Count; k++)
							{   

								cr = fgrid_template_tree.GetCellRange(row, k); 

								now_flag = (cr.UserData == null) ? "" : cr.UserData.ToString(); 

								if(before_flag == now_flag)
								{
									size_t = k;
								}
								else
								{
									break;
								}

							}
  

							MyOraDB.Parameter_Values[para_ct++] = "I";
							MyOraDB.Parameter_Values[para_ct++] = fgrid_template_tree[row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_TREE_CD].ToString();
							MyOraDB.Parameter_Values[para_ct++] = fgrid_template_tree[row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_LEVEL].ToString();
							MyOraDB.Parameter_Values[para_ct++] = fgrid_template_tree[1, size_f].ToString();
							MyOraDB.Parameter_Values[para_ct++] = fgrid_template_tree[1, size_t].ToString();

							size_yn = (fgrid_template_tree[row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxSIZE_YN] == null) ? "False" : fgrid_template_tree[row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxSIZE_YN].ToString();
							size_yn = (Convert.ToBoolean(size_yn)) ? "Y" : "N"; 
							MyOraDB.Parameter_Values[para_ct++] = size_yn;  //size_yn

							mng_unit = (fgrid_template_tree[row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxMNG_UNIT] == null) ? "" : fgrid_template_tree[row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxMNG_UNIT].ToString();
							MyOraDB.Parameter_Values[para_ct++] = mng_unit;  //unit

							MyOraDB.Parameter_Values[para_ct++] = "";  //remarks
							MyOraDB.Parameter_Values[para_ct++] = "";  //send_chk
							MyOraDB.Parameter_Values[para_ct++] = "";  //send_ymd
							MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User;


							size_f = size_t + 1;

							if(size_f == fgrid_template_tree.Cols.Count) break;

						} // end while

					}
				}

				MyOraDB.Add_Modify_Parameter(arg_clear); 
			
				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message,"Save_BomTemplate_Tree_Tail",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}




		/// <summary>
		/// Save_AS_BomTemplate_Tree : 
		/// </summary>
		/// <returns></returns>
		private bool Save_AS_BomTemplate_Tree(bool arg_clear, string arg_templatekey)
		{
			try
			{ 
				int col_ct = 5;  
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_BOM_TEMPLATE.SAVE_AS_SBC_BOM_TEMPLATE";
 
				MyOraDB.Parameter_Name[0] = "ARG_TEMPLATE_TREE_CD_ORG";
				MyOraDB.Parameter_Name[1] = "ARG_TEMPLATE_TREE_CD_NOW";
				MyOraDB.Parameter_Name[2] = "ARG_TEMPLATE_TREE_NAME";
				MyOraDB.Parameter_Name[3] = "ARG_TEMPLATE_KEY";
				MyOraDB.Parameter_Name[4] = "ARG_UPD_USER"; 
 
				for(int i = 0; i < col_ct ; i++) MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;   
 
				MyOraDB.Parameter_Values[0] = _OrgTempCode;
				MyOraDB.Parameter_Values[1] = _SelectTempCode;
				MyOraDB.Parameter_Values[2] = _SelectTempName;
				MyOraDB.Parameter_Values[3] = arg_templatekey;
				MyOraDB.Parameter_Values[4] = ClassLib.ComVar.This_User; 

				MyOraDB.Add_Modify_Parameter(arg_clear); 
			
				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message,"Save_AS_BomTemplate_Tree",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}


		#endregion


 


		#endregion   

		#region C1 Context Menu 클릭 이벤트

		private void cmenu_NodeDelete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
  
				Lassalle.Flow.Node node_org = new Lassalle.Flow.Node();  
				Lassalle.Flow.Node node_now;  

				Item item = addflow_bom_temp.PointedItem;

				string[] token = null;
				string org_level = "", now_level = "";
				int findrow = -1;

				if (item is Lassalle.Flow.Node)
				{
					node_org = (Lassalle.Flow.Node)item;

					token = node_org.Tag.ToString().Split(_TagSeparator.ToCharArray() );
					org_level = token[2];

					//grid에 delete 표시 적용
					findrow = -1;
					findrow = fgrid_template_tree.FindRow(org_level, _Rowfixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_LEVEL, false, true, false);
					
					if(findrow != -1)
					{

						if(fgrid_template_tree[findrow, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxDIVISION].ToString() == "I")
						{
							fgrid_template_tree.Rows.Remove(findrow);
						}
						else
						{
							fgrid_template_tree.Delete_Row(findrow);
						}
					}  // end if(findrow != -1)


					foreach(Item item1 in addflow_bom_temp.Items)
					{
						if(item1 is Lassalle.Flow.Node)
						{
							node_now = new Lassalle.Flow.Node();

							node_now = (Lassalle.Flow.Node)item1;

							token = node_now.Tag.ToString().Split(_TagSeparator.ToCharArray() );
							now_level = token[2];

							//하위 레벨만 삭제
							if(now_level.Length <= org_level.Length) continue;
							if(now_level.Substring(0, org_level.Length) != org_level) continue; 
 

							//하단에서 선택된 노드들 일괄 삭제 하기 위해서 선택 처리만 함
							node_now.Selected = true;
 
							
							//grid에 delete 표시 적용
							findrow = -1;
							findrow = fgrid_template_tree.FindRow(now_level, _Rowfixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_LEVEL, false, true, false);
							 
							if(findrow != -1)
							{
								if(fgrid_template_tree[findrow, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxDIVISION].ToString() == "I")
								{
									fgrid_template_tree.Rows.Remove(findrow);
								}
								else
								{
									fgrid_template_tree.Delete_Row(findrow);
								}
							} // end if(findrow != -1)
							
							  

						} // end if

					} // end foreach 


					//addflow 화면상에서 삭제
					addflow_bom_temp.DeleteSel();  
					
					//자동 트리 구현
					TreeLayout(Lassalle.Flow.Layout.Tree.Orientation.North); 

				} // end if

				 
				// template max level 계산
				foreach(Item item2 in addflow_bom_temp.Items)
				{
					if(item2 is Lassalle.Flow.Node)
					{
						node_now = new Lassalle.Flow.Node();

						node_now = (Lassalle.Flow.Node)item2;

						token = node_now.Tag.ToString().Split(_TagSeparator.ToCharArray() ); 
						_MaxLevelLength = (_MaxLevelLength > token[2].Length) ? _MaxLevelLength : token[2].Length;

					} // end if 
				} // end foreach


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_NodeDelete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


 



		private void cmenu_Tree_North_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				//트리형태로 변형, 링크 속성 재설정
				TreeLayout(Lassalle.Flow.Layout.Tree.Orientation.North); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_Tree_North_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void cmenu_Tree_West_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				//트리형태로 변형, 링크 속성 재설정
				TreeLayout(Lassalle.Flow.Layout.Tree.Orientation.West); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_Tree_West_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void cmenu_NodeProp_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				Lassalle.DlgFlow.DlgFlow dlgflow = new Lassalle.DlgFlow.DlgFlow();
				Lassalle.Flow.Node node = new Lassalle.Flow.Node();   
				
				Item item = addflow_bom_temp.PointedItem;

				if (item is Lassalle.Flow.Node)
				{
					node = (Lassalle.Flow.Node)item;
					dlgflow.NodePropertyPage(addflow_bom_temp, node); 
				}

				Save_BomTemplate_Node_List(true);
				MyOraDB.Exe_Modify_Procedure();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_NodeProp_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void cmenu_LinkProp_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				Lassalle.DlgFlow.DlgFlow dlgflow = new Lassalle.DlgFlow.DlgFlow();
				Lassalle.Flow.Link link = new Lassalle.Flow.Link(); 
			
				Item item = addflow_bom_temp.PointedItem;

				if (item is Lassalle.Flow.Link)
				{
					link = (Lassalle.Flow.Link)item;
					dlgflow.LinkPropertyPage(addflow_bom_temp, link); 
				}
				Save_BomTemplate_Link_List(true);
				MyOraDB.Exe_Modify_Procedure();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_LinkProp_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}




		// Process add
		private void ContextMenu_Popup(object sender, System.EventArgs e)
		{ 
			try
			{
				ContextMenu.CommandLinks.Clear();
				cmenu_Tree.CommandLinks.Clear(); 
				cmenu_Property.CommandLinks.Clear();
 

				ContextMenu.CommandLinks.Add(new C1.Win.C1Command.C1CommandLink(cmenu_NodeDelete) );

				ContextMenu.CommandLinks.Add(new C1.Win.C1Command.C1CommandLink(cmenu_Tree) );  
				cmenu_Tree.CommandLinks.Add(new C1.Win.C1Command.C1CommandLink(cmenu_Tree_North) );
				cmenu_Tree.CommandLinks.Add(new C1.Win.C1Command.C1CommandLink(cmenu_Tree_West) );
			 
				ContextMenu.CommandLinks.Add(new C1.Win.C1Command.C1CommandLink(cmenu_Seperator1) );

				ContextMenu.CommandLinks.Add(new C1.Win.C1Command.C1CommandLink(cmenu_Property) );  
				cmenu_Property.CommandLinks.Add(new C1.Win.C1Command.C1CommandLink(cmenu_NodeProp) );
				cmenu_Property.CommandLinks.Add(new C1.Win.C1Command.C1CommandLink(cmenu_LinkProp) );

				ContextMenu.CommandLinks.Add(new C1.Win.C1Command.C1CommandLink(cmenu_Seperator2) );
			 


				DataTable dt_ret;
				dt_ret = Select_Template_Code();

				C1.Win.C1Command.C1Command cmenu_pross;

				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{ 
					cmenu_pross = new C1.Win.C1Command.C1Command();
					cmenu_pross.Text = dt_ret.Rows[i].ItemArray[0].ToString();
					cmenu_pross.UserData = dt_ret.Rows[i].ItemArray[1].ToString(); 
  
					// 이벤트 매핑 
					cmenu_pross.Click += new C1.Win.C1Command.ClickEventHandler(this.ContextMenu_Menu_Click);

					// 메뉴에 아이템 추가
					ContextMenu.CommandLinks.Add(new C1.Win.C1Command.C1CommandLink(cmenu_pross) );  
				} 

				dt_ret.Dispose();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "ContextMenu_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
	
		}
 



		/// <summary>
		/// ContextMenu_Menu_Click : 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ContextMenu_Menu_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{ 
			C1.Win.C1Command.C1Command sel_process = (C1.Win.C1Command.C1Command)sender; 
			_ProcessCode = sel_process.UserData.ToString();
			_ProcessName = sel_process.Text;
 

			//root
			if(addflow_bom_temp.Items.Count == 0)
			{
				Lassalle.Flow.Node node_dest = new Lassalle.Flow.Node();

				node_dest = addflow_bom_temp.Nodes.Add(10, 10, _NodeWidth, _NodeHeight, _ProcessName);  

				Select_DefNodeProp(_ProcessName, node_dest);

				node_dest.Tooltip = _ProcessName;

				//item_cd:group_attribute:template level 형태로 tag 저장
				node_dest.Tag = _ProcessCode + _TagSeparator + "1";
 

				// parameter : add node data, up level
				Insert_fgrid_template_tree(node_dest, ""); 
					 
				string[] token = node_dest.Tag.ToString().Split(_TagSeparator.ToCharArray() );
				_MaxLevelLength = (_MaxLevelLength > token[2].Length) ? _MaxLevelLength : token[2].Length;

			}

			else
			{ 
				 
				Lassalle.Flow.Node node_org = new Lassalle.Flow.Node(); 
				Lassalle.Flow.Node node_dest = new Lassalle.Flow.Node();

				Item item = addflow_bom_temp.PointedItem;

				if (item is Lassalle.Flow.Node)
				{
					node_org = (Lassalle.Flow.Node)item; 

					switch(node_org.Text)
					{
//						case "LAMINATION":
//							
//							if(_ProcessName == "RAW MATERIAL")
//							{
//								Add_Node_Tree(node_org, node_dest);
//							}
//							else
//							{
//								ClassLib.ComFunction.User_Message("Select another process", "Select Process", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//							}
//							break;

						case "RAW MATERIAL":

							ClassLib.ComFunction.User_Message("Can't add process", "Select Process", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							break;

						default:
							
							Add_Node_Tree(node_org, node_dest);
							break;  
					}


				} // end if

			} // end if root
		 
		 
		}


		#region Process 추가 될 때 


		/// <summary>
		/// Add_Node_Tree : 
		/// </summary>
		/// <param name="arg_orgnode"></param>
		/// <param name="arg_destnode"></param>
		private void Add_Node_Tree(Lassalle.Flow.Node arg_orgnode, Lassalle.Flow.Node arg_destnode)
		{
			//노드 만들때 위치....
			int _x = Convert.ToInt16(arg_orgnode.Location.X);
			int _y = Convert.ToInt16(arg_orgnode.Location.Y);
			
			float maxNodeWidth = 0;
			float maxNodeHeight = 0;

			foreach(Lassalle.Flow.Node node in addflow_bom_temp.Nodes)
			{
				maxNodeWidth = Math.Max(maxNodeWidth, node.Rect.Left);
				maxNodeHeight = Math.Max(maxNodeHeight, node.Rect.Bottom);
			}

			//노드 추가
			arg_destnode = addflow_bom_temp.Nodes.Add(maxNodeWidth + 50, maxNodeHeight + 20, _NodeWidth, _NodeHeight, _ProcessName); 

			//-----------------------------------------------------------------------------------------------------------
			//노드 레벨 지정
			string[] token = null;
			

			token = arg_orgnode.Tag.ToString().Split(_TagSeparator.ToCharArray() );
			string org_level = token[2]; 
			
			string current_level = "";
			string next_level = "";
			int max_level = -1;
			 

			Lassalle.Flow.Node current_node = new Lassalle.Flow.Node(); 

			foreach(Item item in addflow_bom_temp.Items)
			{
				if(item is Lassalle.Flow.Node)
				{
					current_node = (Lassalle.Flow.Node)item;
 
					if(current_node.Tag == null) continue;

					token = current_node.Tag.ToString().Split(_TagSeparator.ToCharArray() );
					current_level = token[2];

					// 1. 선택한 노드 레벨 길이 + 1이 새로 생길 노드 레벨의 길이(스테이지) 가 됨
					// 2. 그 중 선택한 노드 레벨과 선택 노드 레벨 길이와 일치하고,
					// 3. 그 중 최대 레벨 + 1이 새로 생길 노드 레벨
					if(org_level.Length + 1 != current_level.Length) continue;
					if(org_level != current_level.Substring(0, org_level.Length) ) continue;

					current_level = current_level.Substring(org_level.Length); 
					max_level = (max_level > Convert.ToInt32(current_level) ) ? max_level : Convert.ToInt32(current_level);
								
				} // end if (node) 
			} // end foreach

			//만들려는 노드에 같은 레벨이 없을경우(상위레벨만 존재할때)
			max_level = (max_level == -1) ? 0 : max_level;

			next_level = org_level + Convert.ToString(max_level + 1);

			//-----------------------------------------------------------------------------------------------------------

			arg_destnode.Tag = _ProcessCode + _TagSeparator + next_level.ToString(); 
			arg_destnode.Tooltip = _ProcessName;

			Select_DefNodeProp(_ProcessName, arg_destnode);
 

			//-----------------------------------------------------------------------------------------------------------
			//링크 그리기
			Lassalle.Flow.Link addlink = new Lassalle.Flow.Link();

			addlink = addflow_bom_temp.Nodes[arg_orgnode.Index].OutLinks.Add(addflow_bom_temp.Nodes[arg_destnode.Index]); 

			if(_Link_Index == -1) _Link_Index = 0;
			addlink.Tag = _Link_Index;
			_Link_Index++;
			//-----------------------------------------------------------------------------------------------------------

			Insert_fgrid_template_tree(arg_destnode, org_level);  

			
			token = arg_destnode.Tag.ToString().Split(_TagSeparator.ToCharArray() );
			_MaxLevelLength = (_MaxLevelLength > token[2].Length) ? _MaxLevelLength : token[2].Length;



			//자동 트리 구현
			TreeLayout(Lassalle.Flow.Layout.Tree.Orientation.North);

		}



		/// <summary>
		/// 그리드 트리에 데이타 Insert
		/// </summary>
		/// <param name="arg_node"></param>
		private void Insert_fgrid_template_tree(Lassalle.Flow.Node arg_node, string arg_up_level)
		{ 
			int add_row = _Rowfixed;

			int findrow = -1;
			
			 
			if(arg_up_level != "") 
			{
				findrow = fgrid_template_tree.FindRow(arg_up_level, _Rowfixed, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_LEVEL, false, true, false);
			}
			  
			
			if(findrow == -1) //root
			{
				add_row = _Rowfixed - 1;
			}
			else
			{
				add_row = findrow;
			}


			string[] token = arg_node.Tag.ToString().Split(_TagSeparator.ToCharArray() );
			string template_cd = token[0];
			string attribute = token[1];
			string template_level = token[2]; 
   
			int current_row = -1;

			if(add_row == _Rowfixed - 1) //root
			{
				fgrid_template_tree.Tree.Column = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_NAME; 

				fgrid_template_tree.Add_Row(_Rowfixed - 1); 

				fgrid_template_tree.Rows[_Rowfixed].IsNode = true;
				fgrid_template_tree.Rows[_Rowfixed].Node.Level = 0;
				 
				current_row = _Rowfixed;  
			}
			else
			{
				C1.Win.C1FlexGrid.Node node = fgrid_template_tree.Rows[add_row].Node;  

				node.AddNode(NodeTypeEnum.LastChild, ""); 

				current_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;  
			}


			
			fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxDIVISION]	        = "I";
			fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_TREE_CD]	= _SelectTempCode;
			fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_LEVEL]		= template_level;
			fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_STAGE]		= template_level.Length;
			fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_TREE_NAME]	= _SelectTempName; 
			fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_CD]		= template_cd; 
			fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxTEMPLATE_NAME]		= arg_node.Text;

			if(template_cd == _RawMatCd)
			{
				fgrid_template_tree.GetCellRange(current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY1,
												current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY4).StyleNew.DataType = typeof(string);


				fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY1] = "";
				fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY2] = "";
				fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY3] = "";
				fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY4] = "";

				fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxSIZE_YN] = "";



			}
			else
			{
				fgrid_template_tree.GetCellRange(current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY1,
												current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY4).StyleNew.DataType = typeof(bool);

				fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY1] = (attribute.Substring(0, 1) == "1") ? "True" : "False";
				fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY2] = (attribute.Substring(1, 1) == "1") ? "True" : "False";
				fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY3] = (attribute.Substring(2, 1) == "1") ? "True" : "False";
				fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY4] = (attribute.Substring(3, 1) == "1") ? "True" : "False";
			 

				fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxSIZE_YN] = "False";


			}

			
			fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxPROPERTY5] = "";
            fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxREMARK] = "";
            fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxFAVORITE_YN] = ""; 
			fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxSEND_CHK] = "";
			fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxSEND_DATE] = "";
			fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxUPD_USER] = "";
            fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxUPD_YMD] = "";
			
			fgrid_template_tree[current_row, (int)ClassLib.TBSBC_BOM_TEMPLATE.IxMNG_UNIT] = "";
 
 

			fgrid_template_tree.Tree.Style = TreeStyleFlags.Complete;
		}
 
 

		/// <summary>
		/// Select_DefNodeProp : Default Node 속성을 최근 Node 속성으로 재할당
		/// </summary>fgrid_template_tree
		private void Select_DefNodeProp(string _menu_item_name, Lassalle.Flow.Node arg_node)
		{
			addflow_bom_temp.DefNodeProp.Alignment = arg_node.Alignment;
			addflow_bom_temp.DefNodeProp.DashStyle = arg_node.DashStyle; 
			addflow_bom_temp.DefNodeProp.DrawColor = arg_node.DrawColor;
			addflow_bom_temp.DefNodeProp.DrawWidth = arg_node.DrawWidth; 
			addflow_bom_temp.DefNodeProp.Font = arg_node.Font; 
			addflow_bom_temp.DefNodeProp.Gradient = arg_node.Gradient; 
			addflow_bom_temp.DefNodeProp.GradientColor = arg_node.GradientColor; 
			addflow_bom_temp.DefNodeProp.GradientMode = arg_node.GradientMode; 
			addflow_bom_temp.DefNodeProp.Shadow.Style = arg_node.Shadow.Style;  
			addflow_bom_temp.DefNodeProp.Shadow.Color = arg_node.Shadow.Color;
			addflow_bom_temp.DefNodeProp.Shadow.Size = arg_node.Shadow.Size; 
			addflow_bom_temp.DefNodeProp.Shape.Style = arg_node.Shape.Style; 
			addflow_bom_temp.DefNodeProp.Shape.Orientation = arg_node.Shape.Orientation; 
			addflow_bom_temp.DefNodeProp.TextColor = arg_node.TextColor;
  
  

			switch(_menu_item_name)
			{
				case "CUP IN SOLE":
					arg_node.FillColor = Color.MistyRose;
					break;

				case "CUTTING":
					arg_node.FillColor = Color.SeaShell;
					break;

				case "H/F":
					arg_node.FillColor = Color.AntiqueWhite;
					break;

				case "HOT MELT":
					arg_node.FillColor = Color.LemonChiffon;
					break;

				case "INJECTED MOLDING":
					arg_node.FillColor = Color.Khaki;
					break;

				case "LAMINATION":
					arg_node.FillColor = Color.Violet;
					break;

				case "P/R MOLDING":
					arg_node.FillColor = Color.LightGreen;
					break;

				case "PAINTING":
					arg_node.FillColor = Color.LightSteelBlue;
					break;

				case "PERFS":
					arg_node.FillColor = Color.Honeydew;
					break;

				case "RUBBER LAMINATION":
					arg_node.FillColor = Color.Lavender;
					break;

				case "STIKER":
					arg_node.FillColor = Color.Thistle;
					break;

				case "SUBLIMATION":
					arg_node.FillColor = Color.LavenderBlush;
					break;

				case "RAW MATERIAL":
					arg_node.FillColor = Color.MediumPurple;
					break;

				default:
					break;
			}
		}



		#endregion


		#endregion 
		
		#region copy and paste


		private void menuItem_Copy_Click(object sender, System.EventArgs e)
		{
			try
			{  
				Copy_SizeGroup(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_Copy_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void menuItem_Paste_Click(object sender, System.EventArgs e)
		{
			try
			{  
				Paste_SizeGroup(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_Paste_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void menuItem_OneByOne_Click(object sender, System.EventArgs e)
		{
			try
			{  
				Set_OnebyOne_SizeGroup(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_Copy_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	 

		string[] _CopyData;


		/// <summary>
		/// Copy_SizeGroup : 
		/// </summary>
		private void Copy_SizeGroup()
		{

			_CopyData = new string[fgrid_template_tree.Cols.Count - (int)ClassLib.TBSBC_BOM_TEMPLATE.IxCS_SIZE_START];
	

			CellRange cr;
			int sel_row = fgrid_template_tree.Selection.r1;
			int count = 0;


			for(int i = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxCS_SIZE_START; i < fgrid_template_tree.Cols.Count; i++)
			{
				cr = fgrid_template_tree.GetCellRange(sel_row, i);
				_CopyData[count++] = (cr.UserData == null) ? "" : cr.UserData.ToString();
			}

			 
			
		}



		/// <summary>
		/// Paste_SizeGroup : 
		/// </summary>
		private void Paste_SizeGroup()
		{

			CellRange cr;
			int sel_row = fgrid_template_tree.Selection.r1;

			for(int i = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxCS_SIZE_START; i < fgrid_template_tree.Cols.Count; i++)
			{
				cr = fgrid_template_tree.GetCellRange(sel_row, i);
				cr.UserData = _CopyData[i - (int)ClassLib.TBSBC_BOM_TEMPLATE.IxCS_SIZE_START];
			}


			// 색깔 처리
			Display_SizeGroup_Color(sel_row);

			fgrid_template_tree.Update_Row(sel_row);


		}


		/// <summary>
		/// Set_OnebyOne_SizeGroup : 한 사이즈 문대씩 사이즈 그룹 설정
		/// </summary>
		private void Set_OnebyOne_SizeGroup()
		{

			if(fgrid_template_tree.Rows.Count <= fgrid_template_tree.Rows.Fixed) return;
		
			int sel_row = fgrid_template_tree.Selection.r1;
			int sel_col1 = fgrid_template_tree.Selection.c1;
			int sel_col2 = fgrid_template_tree.Selection.c2;

			int start_col = (sel_col1 < sel_col2) ? sel_col1 : sel_col2;

			if(start_col >= (int)ClassLib.TBSBC_BOM_TEMPLATE.IxCS_SIZE_START) return;
 
			

			CellRange cr;

			for(int i = (int)ClassLib.TBSBC_BOM_TEMPLATE.IxCS_SIZE_START; i < fgrid_template_tree.Cols.Count; i++)
			{
				_GroupCount++;

				cr = fgrid_template_tree.GetCellRange(sel_row, i, sel_row, i);
				cr.UserData = _GroupCount.ToString();
 
			} 
			


			Display_SizeGroup_Color(sel_row);

			// update 표시
			fgrid_template_tree.Update_Row(sel_row);

		}


		#endregion



		#endregion  

		#region DB Connect

		/// <summary>
		/// Select_TemplateTree_Code : Template Tree Code 조회
		/// </summary>
		/// <returns></returns>
		public static DataTable Select_TemplateTree_Code(string arg_Value)
		{
			COM.OraDB oraDB = new COM.OraDB();

			string Proc_Name = "PKG_SBC_BOM_TEMPLATE.SELECT_SBC_BOM_TEMPLATE_COMBO";

			oraDB.ReDim_Parameter(2);
			oraDB.Process_Name = Proc_Name ;
 
			oraDB.Parameter_Name[0] = "ARG_TEMPLATE_TREE";
			oraDB.Parameter_Name[1] = "OUT_CURSOR";
 
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
			oraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_String(arg_Value, " ");
			oraDB.Parameter_Values[1] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null; 
			return  DS_Ret.Tables[Proc_Name];
		}

        
		/// <summary>
		/// Select_Template_Code
		/// </summary>
		/// <returns></returns>
		private DataTable Select_Template_Code()
		{
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet ds_ret;
			string process_name = "PKG_SBC_BOM_TEMPLATE.SELECT_SBC_TEMPLATE_CODE";

			MyOraDB.ReDim_Parameter(1); 
 
			MyOraDB.Process_Name = process_name; 

			MyOraDB.Parameter_Name[0] = "OUT_CURSOR"; 
			MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor; 
			MyOraDB.Parameter_Values[0] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ; 
			return ds_ret.Tables[process_name]; 
		}


		/// <summary>
		/// Select_BOM_Template : TemplateTree 조회
		/// </summary>
		/// <returns></returns>
		private DataSet Select_BOM_Template(string arg_template_tree_code)
		{
 
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet ds_ret;

			//---------------------------------------------------------------------
            // SELECT_SBC_BOM_TEMPLATE
			//---------------------------------------------------------------------
			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_BOM_TEMPLATE.SELECT_SBC_BOM_TEMPLATE";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_TEMPLATE_TREE_CD";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_template_tree_code; 
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(true);



			//---------------------------------------------------------------------
			// SELECT_SBC_BOM_TEMPLATE
			//---------------------------------------------------------------------
			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_BOM_TEMPLATE.SELECT_SBC_BOM_TEMPLATE_TAIL";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_TEMPLATE_TREE_CD";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_template_tree_code; 
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(false);


 
			//---------------------------------------------------------------------
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret; 
		}


 

		/// <summary>
		/// Select_BomTemplate_Node_List : Template Node 리스트 찾기  
		/// </summary>
		private DataTable Select_BomTemplate_Node_List()
		{  
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_BOM_TEMPLATE.SELECT_TEMPLATE_NODE_LIST";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_TEMPLATE_TREE_CD";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = _SelectTempCode; 
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name];  
			 
		}


		/// <summary>
		/// Select_BomTemplate_Link_List : Template Link 리스트 찾기  
		/// </summary>
		private DataTable Select_BomTemplate_Link_List()
		{  
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_BOM_TEMPLATE.SELECT_TEMPLATE_LINK_LIST";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_TEMPLATE_TREE_CD";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = _SelectTempCode; 
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name];  
			 
		}

		
		/// <summary>
		/// Delete_SBC_BOM_TEMPLATE : 
		/// </summary>
		/// <returns></returns>
		private bool Delete_SBC_BOM_TEMPLATE()
		{
			try
			{ 
				int col_ct = 1;  
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_BOM_TEMPLATE.DELETE_SBC_BOM_TEMPLATE";
 
				MyOraDB.Parameter_Name[0] = "ARG_TEMPLATE_TREE_CD";  
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Values[0] = _SelectTempCode;
				
 
				MyOraDB.Add_Modify_Parameter(true); 
				MyOraDB.Exe_Modify_Procedure();
			
				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Delete_SBC_BOM_TEMPLATE", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}




		/// <summary>
		/// Save_ReName_Template_Tree_Cd : 
		/// </summary>
		/// <returns></returns>
		private bool Save_ReName_Template_Tree_Cd()
		{
			try
			{ 
				DataSet ds_ret;

				int col_ct = 2;  
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_BOM_TEMPLATE.RENAME_SBC_BOM_TEMPLATE";
 
				MyOraDB.Parameter_Name[0] = "ARG_TEMPLATE_TREE_CD";  
				MyOraDB.Parameter_Name[1] = "ARG_TEMPLATE_TREE_NAME";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 

				MyOraDB.Parameter_Values[0] = _SelectTempCode;
				MyOraDB.Parameter_Values[1] = _SelectTempName;
				
 
				MyOraDB.Add_Modify_Parameter(true); 
				ds_ret = MyOraDB.Exe_Modify_Procedure();

				if(ds_ret == null)
				{
					return false;
				}
				else
				{ 
					return true;
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Delete_SBC_BOM_TEMPLATE", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}


		#endregion 

		 

	 
	}
}

