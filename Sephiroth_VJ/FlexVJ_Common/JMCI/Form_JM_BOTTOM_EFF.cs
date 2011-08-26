using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;

namespace FlexVJ_Common.JMCI
{
	public class Form_JM_BOTTOM_EFF : COM.VJ_CommonWinForm.Form_Top
	{

		#region 디자이너에서 생성한 멤버

		private System.Windows.Forms.ContextMenu ctx_main;
		private System.Windows.Forms.MenuItem mnu_allSel;
		private System.Windows.Forms.MenuItem mnu_allDesel;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnu_tree;
		private System.Windows.Forms.MenuItem mnu_style;
		private System.Windows.Forms.MenuItem mnu_item;
		private System.Windows.Forms.MenuItem mnu_Purchase;
		private System.Windows.Forms.MenuItem mnu_PurchaseSearch;
		private System.Windows.Forms.Panel pnl_B;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbl_PlanYMD;
		private C1.Win.C1List.C1Combo cmbLine;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.Panel pnl_BB2;
		private System.Windows.Forms.TabControl tab_Main;
		private System.Windows.Forms.TabPage tabPageDesc;
		private COM.FSP fgrid_main_os;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblTheme;
		private System.Windows.Forms.Panel panel3;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rad_lvl2;
		private System.Windows.Forms.RadioButton rad_lvl1;
		private System.Windows.Forms.TextBox txtTooling;
		private C1.Win.C1List.C1Combo cmbCategory;
		private System.Windows.Forms.TextBox txtStyle;
		private System.Windows.Forms.Label btnSearch;
		private System.Windows.Forms.Label btnSave;
		private System.Windows.Forms.Label btnInsert;
		private System.Windows.Forms.DateTimePicker dpick_date_from;
		private System.Windows.Forms.DateTimePicker dpick_date_to;
		private System.Windows.Forms.Label label4;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 생성자 / 소멸자

		public Form_JM_BOTTOM_EFF()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_JM_BOTTOM_EFF));
			this.ctx_main = new System.Windows.Forms.ContextMenu();
			this.mnu_allSel = new System.Windows.Forms.MenuItem();
			this.mnu_allDesel = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.mnu_tree = new System.Windows.Forms.MenuItem();
			this.mnu_style = new System.Windows.Forms.MenuItem();
			this.mnu_item = new System.Windows.Forms.MenuItem();
			this.mnu_Purchase = new System.Windows.Forms.MenuItem();
			this.mnu_PurchaseSearch = new System.Windows.Forms.MenuItem();
			this.pnl_B = new System.Windows.Forms.Panel();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel3 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.pnl_BB2 = new System.Windows.Forms.Panel();
			this.tab_Main = new System.Windows.Forms.TabControl();
			this.tabPageDesc = new System.Windows.Forms.TabPage();
			this.fgrid_main_os = new COM.FSP();
			this.panel5 = new System.Windows.Forms.Panel();
			this.btnInsert = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTooling = new System.Windows.Forms.TextBox();
			this.cmbCategory = new C1.Win.C1List.C1Combo();
			this.label3 = new System.Windows.Forms.Label();
			this.lblTheme = new System.Windows.Forms.Label();
			this.txtStyle = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.dpick_date_from = new System.Windows.Forms.DateTimePicker();
			this.dpick_date_to = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rad_lvl2 = new System.Windows.Forms.RadioButton();
			this.rad_lvl1 = new System.Windows.Forms.RadioButton();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.lbl_PlanYMD = new System.Windows.Forms.Label();
			this.cmbLine = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.splitter1 = new System.Windows.Forms.Splitter();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_B.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_BB2.SuspendLayout();
			this.tab_Main.SuspendLayout();
			this.tabPageDesc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main_os)).BeginInit();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbCategory)).BeginInit();
			this.panel2.SuspendLayout();
			this.pnl_head.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbLine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Menu
			// 
			this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.UIStrings.Content = new string[0];
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
			// tbtn_Delete
			// 
			this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
			// 
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// ctx_main
			// 
			this.ctx_main.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.mnu_allSel,
																					 this.mnu_allDesel,
																					 this.menuItem1,
																					 this.mnu_tree,
																					 this.mnu_Purchase,
																					 this.mnu_PurchaseSearch});
			// 
			// mnu_allSel
			// 
			this.mnu_allSel.Index = 0;
			this.mnu_allSel.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
			this.mnu_allSel.Text = "All select";
			this.mnu_allSel.Click += new System.EventHandler(this.mnu_allSel_Click);
			// 
			// mnu_allDesel
			// 
			this.mnu_allDesel.Index = 1;
			this.mnu_allDesel.Text = "All Deselect";
			this.mnu_allDesel.Click += new System.EventHandler(this.mnu_allDesel_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 2;
			this.menuItem1.Text = "-";
			// 
			// mnu_tree
			// 
			this.mnu_tree.Index = 3;
			this.mnu_tree.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.mnu_style,
																					 this.mnu_item});
			this.mnu_tree.Text = "Tree View Option";
			// 
			// mnu_style
			// 
			this.mnu_style.Index = 0;
			this.mnu_style.Text = "Style";
			this.mnu_style.Click += new System.EventHandler(this.mnu_style_Click);
			// 
			// mnu_item
			// 
			this.mnu_item.Index = 1;
			this.mnu_item.Text = "Item";
			this.mnu_item.Click += new System.EventHandler(this.mnu_item_Click);
			// 
			// mnu_Purchase
			// 
			this.mnu_Purchase.Index = 4;
			this.mnu_Purchase.Text = "Purchaseing";
			// 
			// mnu_PurchaseSearch
			// 
			this.mnu_PurchaseSearch.Index = 5;
			this.mnu_PurchaseSearch.Text = "";
			// 
			// pnl_B
			// 
			this.pnl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_B.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_B.Controls.Add(this.splitter2);
			this.pnl_B.Controls.Add(this.panel3);
			this.pnl_B.Controls.Add(this.pnl_BB2);
			this.pnl_B.Controls.Add(this.panel2);
			this.pnl_B.Controls.Add(this.splitter1);
			this.pnl_B.DockPadding.Bottom = 5;
			this.pnl_B.DockPadding.Left = 5;
			this.pnl_B.DockPadding.Right = 5;
			this.pnl_B.Location = new System.Drawing.Point(0, 56);
			this.pnl_B.Name = "pnl_B";
			this.pnl_B.Size = new System.Drawing.Size(1024, 584);
			this.pnl_B.TabIndex = 29;
			// 
			// splitter2
			// 
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter2.Location = new System.Drawing.Point(5, 423);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(1014, 3);
			this.splitter2.TabIndex = 182;
			this.splitter2.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.fgrid_main);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(5, 96);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1014, 330);
			this.panel3.TabIndex = 181;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,80,Columns:";
			this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(2)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_main.Size = new System.Drawing.Size(1014, 330);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 7pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 177;
			this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
			this.fgrid_main.SelChange += new System.EventHandler(this.fgrid_main_SelChange);
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			// 
			// pnl_BB2
			// 
			this.pnl_BB2.Controls.Add(this.tab_Main);
			this.pnl_BB2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnl_BB2.DockPadding.Top = 2;
			this.pnl_BB2.Location = new System.Drawing.Point(5, 426);
			this.pnl_BB2.Name = "pnl_BB2";
			this.pnl_BB2.Size = new System.Drawing.Size(1014, 150);
			this.pnl_BB2.TabIndex = 180;
			// 
			// tab_Main
			// 
			this.tab_Main.Controls.Add(this.tabPageDesc);
			this.tab_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tab_Main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tab_Main.ItemSize = new System.Drawing.Size(73, 19);
			this.tab_Main.Location = new System.Drawing.Point(0, 2);
			this.tab_Main.Multiline = true;
			this.tab_Main.Name = "tab_Main";
			this.tab_Main.SelectedIndex = 0;
			this.tab_Main.Size = new System.Drawing.Size(1014, 148);
			this.tab_Main.TabIndex = 4;
			this.tab_Main.Click += new System.EventHandler(this.tab_Main_Click);
			// 
			// tabPageDesc
			// 
			this.tabPageDesc.BackColor = System.Drawing.SystemColors.Window;
			this.tabPageDesc.Controls.Add(this.fgrid_main_os);
			this.tabPageDesc.Controls.Add(this.panel5);
			this.tabPageDesc.DockPadding.Top = -6;
			this.tabPageDesc.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tabPageDesc.Location = new System.Drawing.Point(4, 23);
			this.tabPageDesc.Name = "tabPageDesc";
			this.tabPageDesc.Size = new System.Drawing.Size(1006, 121);
			this.tabPageDesc.TabIndex = 0;
			this.tabPageDesc.Text = "Tooling Master";
			// 
			// fgrid_main_os
			// 
			this.fgrid_main_os.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main_os.ColumnInfo = "10,1,0,0,0,80,Columns:";
			this.fgrid_main_os.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main_os.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(2)));
			this.fgrid_main_os.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main_os.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_main_os.Location = new System.Drawing.Point(0, 27);
			this.fgrid_main_os.Name = "fgrid_main_os";
			this.fgrid_main_os.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_main_os.Size = new System.Drawing.Size(1006, 94);
			this.fgrid_main_os.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 7pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main_os.TabIndex = 178;
			this.fgrid_main_os.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_os_BeforeEdit);
			this.fgrid_main_os.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_os_AfterEdit);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.btnInsert);
			this.panel5.Controls.Add(this.btnSave);
			this.panel5.Controls.Add(this.btnSearch);
			this.panel5.Controls.Add(this.label6);
			this.panel5.Controls.Add(this.txtTooling);
			this.panel5.Controls.Add(this.cmbCategory);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Controls.Add(this.lblTheme);
			this.panel5.Controls.Add(this.txtStyle);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, -6);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1006, 33);
			this.panel5.TabIndex = 0;
			// 
			// btnInsert
			// 
			this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btnInsert.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnInsert.ImageIndex = 9;
			this.btnInsert.ImageList = this.image_List;
			this.btnInsert.Location = new System.Drawing.Point(914, 8);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(80, 23);
			this.btnInsert.TabIndex = 681;
			this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			this.btnInsert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
			this.btnInsert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btnSave.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnSave.ImageIndex = 11;
			this.btnSave.ImageList = this.image_List;
			this.btnSave.Location = new System.Drawing.Point(833, 8);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(80, 23);
			this.btnSave.TabIndex = 680;
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnSave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
			this.btnSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btnSearch.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnSearch.ImageIndex = 13;
			this.btnSearch.ImageList = this.image_List;
			this.btnSearch.Location = new System.Drawing.Point(752, 8);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(80, 23);
			this.btnSearch.TabIndex = 679;
			this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			this.btnSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
			this.btnSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Gulim", 9F);
			this.label6.ImageIndex = 2;
			this.label6.ImageList = this.img_Label;
			this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label6.Location = new System.Drawing.Point(520, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 21);
			this.label6.TabIndex = 677;
			this.label6.Text = "Tooling Code";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtTooling
			// 
			this.txtTooling.BackColor = System.Drawing.Color.White;
			this.txtTooling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTooling.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txtTooling.Location = new System.Drawing.Point(621, 8);
			this.txtTooling.MaxLength = 100;
			this.txtTooling.Name = "txtTooling";
			this.txtTooling.Size = new System.Drawing.Size(115, 21);
			this.txtTooling.TabIndex = 676;
			this.txtTooling.Text = "";
			// 
			// cmbCategory
			// 
			this.cmbCategory.AddItemCols = 0;
			this.cmbCategory.AddItemSeparator = ';';
			this.cmbCategory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
			this.cmbCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbCategory.Caption = "";
			this.cmbCategory.CaptionHeight = 17;
			this.cmbCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbCategory.ColumnCaptionHeight = 18;
			this.cmbCategory.ColumnFooterHeight = 18;
			this.cmbCategory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbCategory.ContentHeight = 17;
			this.cmbCategory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbCategory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbCategory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbCategory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbCategory.EditorHeight = 17;
			this.cmbCategory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbCategory.GapHeight = 2;
			this.cmbCategory.ItemHeight = 15;
			this.cmbCategory.Location = new System.Drawing.Point(109, 8);
			this.cmbCategory.MatchEntryTimeout = ((long)(2000));
			this.cmbCategory.MaxDropDownItems = ((short)(5));
			this.cmbCategory.MaxLength = 32767;
			this.cmbCategory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.PartialRightColumn = false;
			this.cmbCategory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" AllowRowSizing=\"None\" CaptionHeight=\"18\" ColumnCaptionH" +
				"eight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup" +
				"=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScro" +
				"llBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" " +
				"me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"" +
				"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle pa" +
				"rent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6" +
				"\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" " +
				"me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Selec" +
				"tedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></" +
				"C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><" +
				"Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Styl" +
				"e parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style" +
				" parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Sty" +
				"le parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style pa" +
				"rent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></Name" +
				"dStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</La" +
				"yout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmbCategory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbCategory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbCategory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbCategory.Size = new System.Drawing.Size(163, 21);
			this.cmbCategory.TabIndex = 675;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Gulim", 9F);
			this.label3.ImageIndex = 2;
			this.label3.ImageList = this.img_Label;
			this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label3.Location = new System.Drawing.Point(8, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 674;
			this.label3.Text = "Category";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTheme
			// 
			this.lblTheme.Font = new System.Drawing.Font("Gulim", 9F);
			this.lblTheme.ImageIndex = 2;
			this.lblTheme.ImageList = this.img_Label;
			this.lblTheme.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblTheme.Location = new System.Drawing.Point(288, 8);
			this.lblTheme.Name = "lblTheme";
			this.lblTheme.Size = new System.Drawing.Size(100, 21);
			this.lblTheme.TabIndex = 665;
			this.lblTheme.Text = "Style";
			this.lblTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtStyle
			// 
			this.txtStyle.BackColor = System.Drawing.Color.White;
			this.txtStyle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStyle.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txtStyle.Location = new System.Drawing.Point(389, 8);
			this.txtStyle.MaxLength = 100;
			this.txtStyle.Name = "txtStyle";
			this.txtStyle.Size = new System.Drawing.Size(107, 21);
			this.txtStyle.TabIndex = 663;
			this.txtStyle.Text = "";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pnl_head);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(5, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1014, 96);
			this.panel2.TabIndex = 49;
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.dpick_date_from);
			this.pnl_head.Controls.Add(this.dpick_date_to);
			this.pnl_head.Controls.Add(this.label4);
			this.pnl_head.Controls.Add(this.groupBox1);
			this.pnl_head.Controls.Add(this.txt_StyleCd);
			this.pnl_head.Controls.Add(this.lbl_PlanYMD);
			this.pnl_head.Controls.Add(this.cmbLine);
			this.pnl_head.Controls.Add(this.label1);
			this.pnl_head.Controls.Add(this.lbl_Style);
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.cmb_Factory);
			this.pnl_head.Controls.Add(this.lbl_Factory);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Controls.Add(this.pic_head2);
			this.pnl_head.Controls.Add(this.pic_head5);
			this.pnl_head.Controls.Add(this.pic_head6);
			this.pnl_head.Controls.Add(this.pic_head1);
			this.pnl_head.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_head.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_head.Location = new System.Drawing.Point(0, 0);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(1014, 96);
			this.pnl_head.TabIndex = 3;
			// 
			// dpick_date_from
			// 
			this.dpick_date_from.CustomFormat = "";
			this.dpick_date_from.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_date_from.Location = new System.Drawing.Point(109, 62);
			this.dpick_date_from.Name = "dpick_date_from";
			this.dpick_date_from.Size = new System.Drawing.Size(90, 21);
			this.dpick_date_from.TabIndex = 564;
			// 
			// dpick_date_to
			// 
			this.dpick_date_to.CustomFormat = "";
			this.dpick_date_to.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_date_to.Location = new System.Drawing.Point(228, 62);
			this.dpick_date_to.Name = "dpick_date_to";
			this.dpick_date_to.Size = new System.Drawing.Size(91, 21);
			this.dpick_date_to.TabIndex = 565;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(205, 64);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(16, 16);
			this.label4.TabIndex = 566;
			this.label4.Text = "~";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.rad_lvl2);
			this.groupBox1.Controls.Add(this.rad_lvl1);
			this.groupBox1.Location = new System.Drawing.Point(832, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(168, 39);
			this.groupBox1.TabIndex = 563;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tree View Option";
			// 
			// rad_lvl2
			// 
			this.rad_lvl2.Location = new System.Drawing.Point(88, 19);
			this.rad_lvl2.Name = "rad_lvl2";
			this.rad_lvl2.Size = new System.Drawing.Size(72, 16);
			this.rad_lvl2.TabIndex = 35;
			this.rad_lvl2.Tag = "2";
			this.rad_lvl2.Text = "Detail";
			this.rad_lvl2.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// rad_lvl1
			// 
			this.rad_lvl1.Location = new System.Drawing.Point(16, 19);
			this.rad_lvl1.Name = "rad_lvl1";
			this.rad_lvl1.Size = new System.Drawing.Size(60, 16);
			this.rad_lvl1.TabIndex = 34;
			this.rad_lvl1.Tag = "1";
			this.rad_lvl1.Text = "Total";
			this.rad_lvl1.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.SystemColors.Window;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StyleCd.Location = new System.Drawing.Point(445, 40);
			this.txt_StyleCd.MaxLength = 10;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.Size = new System.Drawing.Size(210, 21);
			this.txt_StyleCd.TabIndex = 3;
			this.txt_StyleCd.Text = "";
			// 
			// lbl_PlanYMD
			// 
			this.lbl_PlanYMD.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_PlanYMD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_PlanYMD.ImageIndex = 1;
			this.lbl_PlanYMD.ImageList = this.img_Label;
			this.lbl_PlanYMD.Location = new System.Drawing.Point(8, 62);
			this.lbl_PlanYMD.Name = "lbl_PlanYMD";
			this.lbl_PlanYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_PlanYMD.TabIndex = 543;
			this.lbl_PlanYMD.Text = "Plan Date";
			this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbLine
			// 
			this.cmbLine.AddItemCols = 0;
			this.cmbLine.AddItemSeparator = ';';
			this.cmbLine.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
			this.cmbLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbLine.Caption = "";
			this.cmbLine.CaptionHeight = 17;
			this.cmbLine.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbLine.ColumnCaptionHeight = 18;
			this.cmbLine.ColumnFooterHeight = 18;
			this.cmbLine.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbLine.ContentHeight = 17;
			this.cmbLine.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbLine.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbLine.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbLine.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbLine.EditorHeight = 17;
			this.cmbLine.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbLine.GapHeight = 2;
			this.cmbLine.ItemHeight = 15;
			this.cmbLine.Location = new System.Drawing.Point(445, 62);
			this.cmbLine.MatchEntryTimeout = ((long)(2000));
			this.cmbLine.MaxDropDownItems = ((short)(5));
			this.cmbLine.MaxLength = 32767;
			this.cmbLine.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbLine.Name = "cmbLine";
			this.cmbLine.PartialRightColumn = false;
			this.cmbLine.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}Re" +
				"cordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Border:Raise" +
				"d,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{}Style11{}" +
				"Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" AllowRowSizing=\"None\" CaptionHeight=\"18\" ColumnCaptionH" +
				"eight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup" +
				"=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScro" +
				"llBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" " +
				"me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"" +
				"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle pa" +
				"rent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6" +
				"\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" " +
				"me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Selec" +
				"tedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></" +
				"C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><" +
				"Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Styl" +
				"e parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style" +
				" parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Sty" +
				"le parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style pa" +
				"rent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></Name" +
				"dStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</La" +
				"yout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmbLine.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbLine.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbLine.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbLine.Size = new System.Drawing.Size(210, 21);
			this.cmbLine.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(344, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 537;
			this.label1.Text = "Line";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Style
			// 
			this.lbl_Style.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Style.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(344, 40);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 405;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(231, 30);
			this.label2.TabIndex = 393;
			this.label2.Text = "      Search Information";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(998, 80);
			this.pic_head3.Name = "pic_head3";
			this.pic_head3.Size = new System.Drawing.Size(16, 16);
			this.pic_head3.TabIndex = 45;
			this.pic_head3.TabStop = false;
			// 
			// pic_head4
			// 
			this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
			this.pic_head4.Location = new System.Drawing.Point(136, 79);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(974, 18);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
			// 
			// cmb_Factory
			// 
			this.cmb_Factory.AddItemCols = 0;
			this.cmb_Factory.AddItemSeparator = ';';
			this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory.AutoSize = false;
			this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory.Caption = "";
			this.cmb_Factory.CaptionHeight = 17;
			this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory.ColumnCaptionHeight = 18;
			this.cmb_Factory.ColumnFooterHeight = 18;
			this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory.ContentHeight = 17;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Factory.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(109, 40);
			this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory.MaxDropDownItems = ((short)(5));
			this.cmb_Factory.MaxLength = 32767;
			this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory.Name = "cmb_Factory";
			this.cmb_Factory.PartialRightColumn = false;
			this.cmb_Factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Gulim, 9p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Cont" +
				"rol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}St" +
				"yle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.Li" +
				"stBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=" +
				"\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><" +
				"ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBar>" +
				"<HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"St" +
				"yle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer" +
				"\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"" +
				"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><I" +
				"nactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"St" +
				"yle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSty" +
				"le parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win" +
				".C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style " +
				"parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pare" +
				"nt=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style paren" +
				"t=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style par" +
				"ent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"" +
				"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyle" +
				"s><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><" +
				"DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 21);
			this.cmb_Factory.TabIndex = 10;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(8, 40);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 50;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head7
			// 
			this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pic_head7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
			this.pic_head7.Location = new System.Drawing.Point(913, 30);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.Size = new System.Drawing.Size(101, 55);
			this.pic_head7.TabIndex = 46;
			this.pic_head7.TabStop = false;
			// 
			// pic_head2
			// 
			this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
			this.pic_head2.Location = new System.Drawing.Point(998, 0);
			this.pic_head2.Name = "pic_head2";
			this.pic_head2.Size = new System.Drawing.Size(16, 32);
			this.pic_head2.TabIndex = 44;
			this.pic_head2.TabStop = false;
			// 
			// pic_head5
			// 
			this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
			this.pic_head5.Location = new System.Drawing.Point(0, 80);
			this.pic_head5.Name = "pic_head5";
			this.pic_head5.Size = new System.Drawing.Size(168, 20);
			this.pic_head5.TabIndex = 43;
			this.pic_head5.TabStop = false;
			// 
			// pic_head6
			// 
			this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
			this.pic_head6.Location = new System.Drawing.Point(0, 0);
			this.pic_head6.Name = "pic_head6";
			this.pic_head6.Size = new System.Drawing.Size(168, 78);
			this.pic_head6.TabIndex = 41;
			this.pic_head6.TabStop = false;
			// 
			// pic_head1
			// 
			this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
			this.pic_head1.Location = new System.Drawing.Point(160, 0);
			this.pic_head1.Name = "pic_head1";
			this.pic_head1.Size = new System.Drawing.Size(934, 32);
			this.pic_head1.TabIndex = 39;
			this.pic_head1.TabStop = false;
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter1.Location = new System.Drawing.Point(5, 576);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(1014, 3);
			this.splitter1.TabIndex = 48;
			this.splitter1.TabStop = false;
			// 
			// Form_JM_BOTTOM_EFF
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_B);
			this.Name = "Form_JM_BOTTOM_EFF";
			this.Text = "Bottom Efficiency";
			this.Load += new System.EventHandler(this.Form_JM_BOTTOM_EFF_Load);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_B, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_B.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.pnl_BB2.ResumeLayout(false);
			this.tab_Main.ResumeLayout(false);
			this.tabPageDesc.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main_os)).EndInit();
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmbCategory)).EndInit();
			this.panel2.ResumeLayout(false);
			this.pnl_head.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmbLine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 전역변수
 
		private COM.OraDB MyOraDB = new COM.OraDB(); 				
		private int _Rowfixed;
		private bool _bDiv = false;
		private bool _Upload_ON_Flag = false;
		private string BufCellData = "";		
		private Hashtable _columns = new Hashtable();


		private int _colT_LEVEL		= (int)ClassLib.TBSVM_BOTTOM_EFF.IxT_LEVEL;
		private int _colORDER_SEQ	= (int)ClassLib.TBSVM_BOTTOM_EFF.IXORDER_SEQ;
		private int _colFACTORY		= (int)ClassLib.TBSVM_BOTTOM_EFF.IxFACTORY;
		private int _colOBS_ID		= (int)ClassLib.TBSVM_BOTTOM_EFF.IxOBS_ID;
		private int _colLINE_CD		= (int)ClassLib.TBSVM_BOTTOM_EFF.IxLINE_CD;
		private int _colLINE_NAME	= (int)ClassLib.TBSVM_BOTTOM_EFF.IxLINE_NAME;
		private int _colSTYLE_CD	= (int)ClassLib.TBSVM_BOTTOM_EFF.IxSTYLE_CD;
		private int _colMODEL_NAME	= (int)ClassLib.TBSVM_BOTTOM_EFF.IxMODEL_NAME;
		private int _colOS_CODE		= (int)ClassLib.TBSVM_BOTTOM_EFF.IxOS_CODE;
		private int _colOS_CYCLE	= (int)ClassLib.TBSVM_BOTTOM_EFF.IxOS_CYCLE;
		private int _colDATE		= (int)ClassLib.TBSVM_BOTTOM_EFF.IxDATE;
												   
		
		#endregion

		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			try
			{ 
				Clear(); 			
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				_bDiv = false;

				this.Cursor = Cursors.WaitCursor;

				GET_TITLE_DATE();
								
				this.Tbtn_SearchProcess();

				_bDiv = true;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void GET_TITLE_DATE()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SVM_JMCI_BOTTOM_EFF.SELECT_DATE_TITLE";

				DataTable vDt = SELECT_DATE_TITLE(vProcedure);

				Clear_Title();

				if (vDt.Rows.Count > 0)
				{
					Display_Title(vDt);
					
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}

		public DataTable SELECT_DATE_TITLE(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[ 0]  = "ARG_DATE_FROM";
			MyOraDB.Parameter_Name[ 1]  = "ARG_DATE_TO";
			MyOraDB.Parameter_Name[ 2]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[ 0]   = this.dpick_date_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[ 1]   = this.dpick_date_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[ 2]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}


		private void Display_Title(DataTable arg_dt)
		{
			int iCount = arg_dt.Rows.Count;
			
			for ( int iCol = 0; iCol < iCount; iCol++)
			{
				fgrid_main.Cols.Count = _colDATE + iCol + 1;

				int iCurr_Col = _colDATE + iCol;

				fgrid_main.Cols[iCurr_Col].DataType = typeof(int);
				fgrid_main.Cols[iCurr_Col].Format = "#,###";
				fgrid_main.Cols[iCurr_Col].Width  = 50;	
				fgrid_main.Cols[iCurr_Col].AllowMerging = true;
				fgrid_main.AllowMerging = AllowMergingEnum.FixedOnly;
			
				fgrid_main[_Rowfixed-3, iCurr_Col] = arg_dt.Rows[iCol].ItemArray[0]; 
				//fgrid_main[_Rowfixed-2, iCurr_Col] = arg_dt.Rows[iCol].ItemArray[1];
				fgrid_main[_Rowfixed-1, iCurr_Col] = arg_dt.Rows[iCol].ItemArray[1];

			}

		}

		private void Clear_Title()
		{
			fgrid_main.Cols.Count = 15;
		}

		#endregion

		#region 컨트롤 이벤트 처리

		   
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_Factory.SelectedIndex == -1) return;
			fgrid_main.ClearAll();		
		}

		private void cmb_From_SelectedValueChanged(object sender, System.EventArgs e)
		{

		}

		private void cmb_To_SelectedValueChanged(object sender, System.EventArgs e)
		{

		}

		private void mnu_allSel_Click(object sender, System.EventArgs e)
		{
			fgrid_main.SelectAll();
		}

		private void mnu_allDesel_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Select(fgrid_main.Row, fgrid_main.Col);
		}

		private void mnu_style_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(1);
		}

		private void mnu_item_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(2);
		}
		

		#endregion 
		
		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form set
			this.Text = "JMCI";
			lbl_MainTitle.Text = "Bottom Efficiency";

			_bDiv = false;
			
			// grid set
			fgrid_main.Set_Grid("SVM_JMCI_BOTTOM_EFF", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);			
			fgrid_main.Rows[0].AllowMerging = true;
			fgrid_main.Rows[1].AllowMerging = true;
			fgrid_main.Set_Action_Image(img_Action);
			
			fgrid_main_os.Set_Grid("SVM_OS_MASTER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);			
			fgrid_main_os.Rows[0].AllowMerging = true;
			fgrid_main_os.Rows[1].AllowMerging = true;
			fgrid_main_os.Set_Action_Image(img_Action);

			_Rowfixed = fgrid_main.Rows.Fixed;			

			//combobox setting
			Init_Control(); 
		}

		/// <summary>
		/// Init_Control : combobox setting
		/// </summary>
		private void Init_Control()
		{
			DataTable dt_ret;

			// factory
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			// Line
			dt_ret = SELECT_LINE_INFO();
			COM.ComCtl.Set_ComboList(dt_ret, cmbLine, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmbLine.SelectedIndex = 0;

			dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SVM01");
			COM.ComCtl.Set_ComboList(dt_ret, cmbCategory, 1, 2, true, 80, 140);
			cmbCategory.SelectedIndex = 0;

			
			dt_ret.Dispose(); 

			// toolbar button disable setting
			tbtn_Delete.Enabled = false;
			tbtn_Confirm.Enabled = false; 						
   						
			fgrid_main.Font = new Font("Verdana", 7);

			pnl_BB2.Size = new Size(1006, 24); 

		}

		public DataTable SELECT_LINE_INFO()
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;
			
			try
			{
				string process_name = "PKG_SBM_LLT_PLAN_TRACKING.SELECT_LINE_INFO";

				MyOraDB.ReDim_Parameter(2);  
				MyOraDB.Process_Name = process_name;
   

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR"; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			}


		}


		#endregion

		#region 툴바 메뉴 이벤트
		
		/// <summary>
		/// Clear : 화면 초기화
		/// </summary>
		private void Clear()
		{
			Init_Control();

			fgrid_main.ClearAll();  
		}


		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SVM_JMCI_BOTTOM_EFF.SELECT_JMCI_BOTTOM";

				DataTable vDt = SELECT_JMCI_BOTTOM(vProcedure);

				Clear_FlexGrid(fgrid_main);
				Clear_FlexGrid(fgrid_main_os);

				if (vDt.Rows.Count > 0)
				{
					Display_FlexGrid(vDt);
					GridSetColor();
					
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}

		// set grid color
		private void GridSetColor()
		{
			for (int vRow = _Rowfixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				// design setting
				switch (fgrid_main.Rows[vRow].Node.Level)
				{
					case 1:
						fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						fgrid_main.Rows[vRow].AllowEditing = false;
						break;
					case 2:
						if (fgrid_main[vRow, _colORDER_SEQ].ToString().StartsWith("S02"))
						{
							fgrid_main.GetCellRange(vRow, 0, vRow, fgrid_main.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
							
							if (fgrid_main[vRow, _colORDER_SEQ].ToString().StartsWith("S0203") ||
								fgrid_main[vRow, _colORDER_SEQ].ToString().StartsWith("S0204")  )
							{
								fgrid_main.GetCellRange(vRow, fgrid_main.Cols.Frozen, vRow, fgrid_main.Cols.Count - 1).StyleNew.ForeColor = Color.Blue;
								fgrid_main.Rows[vRow].AllowEditing = true;
							}
							else if (fgrid_main[vRow, _colORDER_SEQ].ToString().StartsWith("S0205") ||
								     fgrid_main[vRow, _colORDER_SEQ].ToString().StartsWith("S0206")  )
							{
								fgrid_main.GetCellRange(vRow, fgrid_main.Cols.Frozen, vRow, fgrid_main.Cols.Count - 1).StyleNew.ForeColor = Color.Red;
								fgrid_main.Rows[vRow].AllowEditing = false;
							}
							else
							{
								fgrid_main.Rows[vRow].AllowEditing = false;
							}

						}
						else
						{
							fgrid_main.GetCellRange(vRow, 0, vRow, fgrid_main.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
							fgrid_main.GetCellRange(vRow, 0, vRow, fgrid_main.Cols.Count - 1).StyleNew.ForeColor = Color.DarkGray;

							fgrid_main.Rows[vRow].AllowEditing = false;
						}

						break;

				}
			}
		}

		public DataTable SELECT_JMCI_BOTTOM(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_DATE_FROM";
			MyOraDB.Parameter_Name[ 2]  = "ARG_DATE_TO";
			MyOraDB.Parameter_Name[ 3]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[ 4]  = "ARG_LINE_CD";
			MyOraDB.Parameter_Name[ 5]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 5]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");			
			MyOraDB.Parameter_Values[ 1]   = this.dpick_date_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[ 2]   = this.dpick_date_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[ 3]   = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "").Replace("-", "");				
			MyOraDB.Parameter_Values[ 4]   = ClassLib.ComFunction.Empty_Combo(cmbLine, "");
			MyOraDB.Parameter_Values[ 5]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}


		private void Display_FlexGrid(DataTable arg_dt)
		{
			int iRow_fixed = fgrid_main.Rows.Fixed;
			int iLevel = 0; 
			int iCount = arg_dt.Rows.Count;
			int iCurr_Col = _colDATE;
			string sCurr_Date  = "";
			string sCurr_Style = "";
			string sCurr_Line  = "";

			C1.Win.C1FlexGrid.Node newRow;

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{

				iLevel = Convert.ToInt32(arg_dt.Rows[iRow].ItemArray[_colT_LEVEL-1].ToString() );
				
				// design setting

				if (sCurr_Line != arg_dt.Rows[iRow].ItemArray[_colLINE_NAME-1].ToString())
				{
					newRow = fgrid_main.Rows.InsertNode(fgrid_main.Rows.Count, iLevel);

					fgrid_main[newRow.Row.Index, _colLINE_NAME]  = arg_dt.Rows[iRow].ItemArray[_colLINE_NAME  -1];
					fgrid_main[newRow.Row.Index, _colT_LEVEL  ]  = arg_dt.Rows[iRow].ItemArray[_colT_LEVEL    -1];
					fgrid_main[newRow.Row.Index, _colORDER_SEQ]  = arg_dt.Rows[iRow].ItemArray[_colORDER_SEQ  -1];
					fgrid_main[newRow.Row.Index, _colFACTORY  ]  = arg_dt.Rows[iRow].ItemArray[_colFACTORY    -1];

					sCurr_Line  = arg_dt.Rows[iRow].ItemArray[_colLINE_NAME -1].ToString();
					sCurr_Style = arg_dt.Rows[iRow].ItemArray[_colSTYLE_CD  -1].ToString();
					
				}
				else if (sCurr_Line  == arg_dt.Rows[iRow].ItemArray[_colLINE_NAME -1].ToString() &&
					     sCurr_Style != arg_dt.Rows[iRow].ItemArray[_colSTYLE_CD  -1].ToString() )
				{
					newRow = fgrid_main.Rows.InsertNode(fgrid_main.Rows.Count, iLevel);

					fgrid_main[newRow.Row.Index, _colOBS_ID]     = arg_dt.Rows[iRow].ItemArray[_colOBS_ID     -1];
					fgrid_main[newRow.Row.Index, _colLINE_CD]    = arg_dt.Rows[iRow].ItemArray[_colLINE_CD    -1];
					fgrid_main[newRow.Row.Index, _colLINE_NAME]  = "";
					fgrid_main[newRow.Row.Index, _colSTYLE_CD]   = arg_dt.Rows[iRow].ItemArray[_colSTYLE_CD   -1];
					fgrid_main[newRow.Row.Index, _colMODEL_NAME] = arg_dt.Rows[iRow].ItemArray[_colMODEL_NAME -1];
					fgrid_main[newRow.Row.Index, _colOS_CODE]    = arg_dt.Rows[iRow].ItemArray[_colOS_CODE    -1];
					fgrid_main[newRow.Row.Index, _colOS_CYCLE]   = arg_dt.Rows[iRow].ItemArray[_colOS_CYCLE   -1];

					fgrid_main[newRow.Row.Index, _colT_LEVEL]    = arg_dt.Rows[iRow].ItemArray[_colT_LEVEL    -1];
					fgrid_main[newRow.Row.Index, _colORDER_SEQ]  = arg_dt.Rows[iRow].ItemArray[_colORDER_SEQ  -1];
					fgrid_main[newRow.Row.Index, _colFACTORY]    = arg_dt.Rows[iRow].ItemArray[_colFACTORY    -1];

					sCurr_Style = arg_dt.Rows[iRow].ItemArray[_colSTYLE_CD-1].ToString();
				}
				
				iCurr_Col = _colDATE;
					
				for (int iCol = iCurr_Col; iCol < fgrid_main.Cols.Count; iCol++)
				{
					sCurr_Date = fgrid_main[_Rowfixed-3, iCol].ToString();

					if (sCurr_Line  != arg_dt.Rows[iRow].ItemArray[_colLINE_NAME -1].ToString() ||
						sCurr_Style != arg_dt.Rows[iRow].ItemArray[_colSTYLE_CD  -1].ToString() )
					{
						iRow--;
						break;
					}

					if (sCurr_Date == arg_dt.Rows[iRow].ItemArray[10].ToString())
					{
						fgrid_main[fgrid_main.Rows.Count-1, iCol] = arg_dt.Rows[iRow].ItemArray[12].ToString();

						if (fgrid_main[fgrid_main.Rows.Count-1, _colORDER_SEQ].ToString().StartsWith("S0205") ||
							fgrid_main[fgrid_main.Rows.Count-1, _colORDER_SEQ].ToString().StartsWith("S0206")  )
							fgrid_main[fgrid_main.Rows.Count-1, iCol] = CALCULATION_BALANCE(fgrid_main.Rows.Count-1, iCol);
						else
							fgrid_main[fgrid_main.Rows.Count-1, iCol] = arg_dt.Rows[iRow].ItemArray[12].ToString();

						if (iCol+1 < fgrid_main.Cols.Count) 
							iRow++;
					}

					iCurr_Col = iCol;

					if (iRow == iCount)
						break;

				}					

				fgrid_main.Tree.Column = _colLINE_NAME;

			}

			rad_lvl1.Checked = true;
			fgrid_main.Tree.Show(1); 


		}


		private string CALCULATION_BALANCE(int arg_row, int arg_col)
		{
			try
			{	
				string sResult;
				int iActual, iPlan;

				if (fgrid_main[arg_row-2, arg_col] == null)
					iActual = 0;
				else
					iActual = Convert.ToInt32(fgrid_main[arg_row-2, arg_col].ToString());

				if (fgrid_main[arg_row-4, arg_col] == null)
					iPlan   = 0;
				else
					iPlan   = Convert.ToInt32(fgrid_main[arg_row-4, arg_col].ToString());
				
				sResult = Convert.ToString(iActual-iPlan);

				//if (sResult == "0")

				

				return sResult;

			}
			catch
			{
				
				return "";
			}
		}



		private void Clear_FlexGrid(C1FlexGrid arg_grid)
		{
			if (arg_grid.Rows.Fixed != arg_grid.Rows.Count)
			{				
				arg_grid.Clear(ClearFlags.UserData, arg_grid.Rows.Fixed, 1, arg_grid.Rows.Count - 1, arg_grid.Cols.Count - 1);

				arg_grid.Rows.Count = arg_grid.Rows.Fixed;
			}
		}



		#endregion 


		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();
		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess();
		}


		private void Grid_AfterEditProcess()
		{
			Update_Cell();			
		}

		public void Update_Cell()
		{

			int sel_row = fgrid_main.Selection.r1;
			int sel_col = fgrid_main.Selection.c1;
					
			try
			{
				if(fgrid_main[sel_row, 0] == null) fgrid_main[sel_row, 0] = "";
				if(fgrid_main[sel_row, 0].ToString() == "I") return;

				if (fgrid_main[sel_row, sel_col].ToString() != BufCellData)  
				{
					if (fgrid_main[sel_row, _colORDER_SEQ].ToString().StartsWith("S0203"))
						fgrid_main[sel_row, 0] = "U";
					else
						fgrid_main[sel_row-1, 0] = "U";

					fgrid_main[_Rowfixed-2, sel_col] = "v";

					fgrid_main[sel_row+2, sel_col] = CALCULATION_BALANCE(sel_row+2, sel_col);

					BufCellData = "";
				}
 
			}

			catch (Exception ex)
			{
				MessageBox.Show( ex.Message.ToString(),"Update_Row",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				BufCellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DialogResult dr;

			if (Validate_Check())
			{
				if(ClassLib.ComFunction.User_Message("Do you want to save?","save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
				{
					this.Tbtn_SaveProcess();					
				}
			}
			else
			{
				dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave);
			}
		}

		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_SVM_JMCI_BOTTOM(true))
				{

					fgrid_main.Refresh_Division();
					//this.Tbtn_SearchProcess();		

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		public bool SAVE_SVM_JMCI_BOTTOM(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 7;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SVM_JMCI_BOTTOM_EFF.SAVE_SVM_JMCI_BOTTOM";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 2] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[ 3] = "ARG_PLAN_DATE";
				MyOraDB.Parameter_Name[ 4] = "ARG_ACTUAL_MACHINE";
				MyOraDB.Parameter_Name[ 5] = "ARG_ACTUAL_MANPOWER";
				MyOraDB.Parameter_Name[ 6] = "ARG_UPD_USER";


				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
						for(int iCol = _colDATE; iCol < fgrid_main.Cols.Count; iCol++)
							if (!ClassLib.ComFunction.NullToBlank(fgrid_main[_Rowfixed-2, iCol]).Equals("") )
								save_ct += 1;

				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if (fgrid_main[iRow, 0] == null)
						continue;

					if (fgrid_main[iRow, 0].ToString() != "")
					{
						for(int iCol = _colDATE; iCol < fgrid_main.Cols.Count; iCol++)
						{
							if (fgrid_main[_Rowfixed-2, iCol] == null)
								continue;

							if (fgrid_main[_Rowfixed-2, iCol].ToString() != "")
							{
								MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main[iRow, 0].ToString();
								MyOraDB.Parameter_Values[para_ct+ 1] = fgrid_main[iRow, _colFACTORY].ToString();
								MyOraDB.Parameter_Values[para_ct+ 2] = fgrid_main[iRow, _colLINE_CD].ToString();
								MyOraDB.Parameter_Values[para_ct+ 3] = fgrid_main[_Rowfixed-3, iCol].ToString();

								MyOraDB.Parameter_Values[para_ct+ 4] = fgrid_main[iRow,   iCol].ToString();
								MyOraDB.Parameter_Values[para_ct+ 5] = fgrid_main[iRow+1, iCol].ToString();

								MyOraDB.Parameter_Values[para_ct+ 6] = COM.ComVar.This_User;

								para_ct += iCount;	

							}
						
						}

						
					}
				
				}

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
				
				if (doExecute)
				{
					if (MyOraDB.Exe_Modify_Procedure() == null)
						return false;
					else
						return true;
				}

				return true;

			}
			catch
			{
				return false;
			}
		}


		private bool Validate_Check()
		{


			return true;
		}


		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_Print_Click();
		}



		public void Tbtn_Print_Click()
		{
//			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BM_Pre_Production_Plan") ;
//			string Para         = " ";
//		
//
//			int  iCnt  = 10;
//			string [] aHead =  new string[iCnt];    
//            
//			aHead[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");	
//			aHead[ 1]   = this.dpick_date_from.Text.Replace("-", "");
//			aHead[ 2]   = this.dpick_date_to.Text.Replace("-", "");
//			aHead[ 3]   = "";
//			aHead[ 4] = "";	
//
//			aHead[ 5]   = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "").Replace("-", "");				
//			aHead[ 6]   = ClassLib.ComFunction.Empty_Combo(cmbLine, "");
//			aHead[ 7]   = "";
//			aHead[ 8]   = "";
//
//			aHead[ 9] = "";	
//			
//						            
//			Para = 	" /rp ";
//			for (int i  = 1 ; i<= iCnt ; i++)
//			{				
//				Para = Para + "[" + aHead[i-1] + "] ";
//			}
//			
//			FlexVJ_Common.Report.Form_RdViewer report = new FlexVJ_Common.Report.Form_RdViewer (mrd_Filename, Para);
//			report.Show();		


		}

		private void tab_Main_Click(object sender, System.EventArgs e)
		{
			try
			{
				_Upload_ON_Flag = !_Upload_ON_Flag;

				if(_Upload_ON_Flag)
				{
					pnl_BB2.Size = new Size(1006, 120); 
				}
				else
				{
					pnl_BB2.Size = new Size(1006, 24);
				}

				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tab_Main_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
		}


		private void rad_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{
				RadioButton src = sender as RadioButton; 

				fgrid_main.Tree.Show(Convert.ToInt32(src.Tag.ToString() ) ); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
		}

		private void txtMonth_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

			if (e.KeyChar == 13)
				tbtn_Search_Click(null, null);	
		}


		private void SEARCH_OS_MASTER()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SVM_JMCI_BOTTOM_EFF.SELECT_OS_MASTER";

				DataTable vDt = SELECT_OS_MASTER(vProcedure);

				Clear_FlexGrid(fgrid_main_os);

				if (vDt.Rows.Count > 0)
				{
					Display_FlexGrid_OS(vDt);
					
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}

		public DataTable SELECT_OS_MASTER(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_CATEGORY";
			MyOraDB.Parameter_Name[ 2]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[ 3]  = "ARG_OS_CODE";
			MyOraDB.Parameter_Name[ 4]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 4]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");			
			MyOraDB.Parameter_Values[ 1]   = ClassLib.ComFunction.Empty_Combo(cmbCategory, "");		
			MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_TextBox(txtStyle, "").Replace("-", "");				
			MyOraDB.Parameter_Values[ 3]   = ClassLib.ComFunction.Empty_TextBox(txtTooling, "");
			MyOraDB.Parameter_Values[ 4]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}


		private void Display_FlexGrid_OS(DataTable arg_dt)
		{
			int iCount = arg_dt.Rows.Count;

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{				
				C1.Win.C1FlexGrid.Node newRow = fgrid_main_os.Rows.InsertNode(_Rowfixed + iRow, 1);

				fgrid_main_os[newRow.Row.Index, 0] = "";

				for (int iCol = 1 ; iCol <= arg_dt.Columns.Count ; iCol++)
				{
					fgrid_main_os[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
				}

			}

		}

				
		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				if (cmbCategory.SelectedIndex    == 0 &&
					txtStyle.ToString().Length   == 0 &&
					txtTooling.ToString().Length == 0  )
					return;
							
				this.SEARCH_OS_MASTER();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}		
		}


		private void btn_click_Effect_Plus(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex -= 1;
		}

		private void btn_click_Effect_Minus(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex += 1;		
		}

		private void btnInsert_Click(object sender, System.EventArgs e)
		{
			try
			{				
				fgrid_main_os.Add_Row(fgrid_main_os.Rows.Count-1);

				fgrid_main_os[fgrid_main_os.Rows.Count-1, 1] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
				fgrid_main_os[fgrid_main_os.Rows.Count-1, 3] = txtStyle.Text;
				fgrid_main_os[fgrid_main_os.Rows.Count-1, 6] = "84";

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}

		private void fgrid_main_SelChange(object sender, System.EventArgs e)
		{
			if (!_bDiv) 
				return;

			int sel_row = fgrid_main.Selection.r1;	
		
			if (sel_row < fgrid_main.Rows.Fixed)
				return;

			if (fgrid_main[sel_row, _colORDER_SEQ].ToString().StartsWith("S03"))
			{
				txtStyle.Text   = fgrid_main[sel_row, _colSTYLE_CD].ToString().Substring(0,6)+
					              fgrid_main[sel_row, _colSTYLE_CD].ToString().Substring(7,3);

				txtTooling.Text = (fgrid_main[sel_row, _colOS_CODE] == null) ? "" : fgrid_main[sel_row, _colOS_CODE].ToString();

				this.SEARCH_OS_MASTER();
			}
			
		}



		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if (Validate_Check_OS())
			{
				if(ClassLib.ComFunction.User_Message("Do you want to save?","save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
				{
					this.btn_SaveProcess();					
				}
			}				
		}

		private bool Validate_Check_OS()
		{
			
			return true;
		}

		private void btn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_SVM_OS_MASTER(true))
				{
					fgrid_main_os.Refresh_Division();
					this.SEARCH_OS_MASTER();
					MessageBox.Show("Save Complete","Save", MessageBoxButtons.OK ,MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		public bool SAVE_SVM_OS_MASTER(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 9;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SVM_JMCI_BOTTOM_EFF.SAVE_OS_MASTER";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 2] = "ARG_STYLE_CATEGORY";
				MyOraDB.Parameter_Name[ 3] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[ 4] = "ARG_OS_CODE";
				MyOraDB.Parameter_Name[ 5] = "ARG_OS_CYCLE";
				MyOraDB.Parameter_Name[ 6] = "ARG_OS_PAIR";
				MyOraDB.Parameter_Name[ 7] = "ARG_OS_SET";
				MyOraDB.Parameter_Name[ 8] = "ARG_UPD_USER";


				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				for(int iRow = fgrid_main_os.Rows.Fixed ; iRow < fgrid_main_os.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main_os[iRow, 0]).Equals("") )
						save_ct += 1;

				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[iCount * save_ct];

				for (int iRow = fgrid_main_os.Rows.Fixed ; iRow < fgrid_main_os.Rows.Count ; iRow++)
				{
					if(fgrid_main_os[iRow, 0].ToString() != "")
					{
						MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main_os[iRow, 0].ToString();
						MyOraDB.Parameter_Values[para_ct+ 1] = fgrid_main_os[iRow, 1].ToString();
						MyOraDB.Parameter_Values[para_ct+ 2] = fgrid_main_os[iRow, 2].ToString();
						MyOraDB.Parameter_Values[para_ct+ 3] = fgrid_main_os[iRow, 3].ToString().Replace("-", "");
						MyOraDB.Parameter_Values[para_ct+ 4] = fgrid_main_os[iRow, 5].ToString();
						MyOraDB.Parameter_Values[para_ct+ 5] = fgrid_main_os[iRow, 6].ToString();
						MyOraDB.Parameter_Values[para_ct+ 6] = fgrid_main_os[iRow, 7].ToString();
						MyOraDB.Parameter_Values[para_ct+ 7] = fgrid_main_os[iRow, 8].ToString();
						MyOraDB.Parameter_Values[para_ct+ 8] = COM.ComVar.This_User;

						para_ct += iCount;	
					}
				
				}

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
				
				if (doExecute)
				{
					if (MyOraDB.Exe_Modify_Procedure() == null)
						return false;
					else
						return true;
				}

				return true;

			}
			catch
			{
				return false;
			}
		}

		private void fgrid_main_os_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess_os();
		}

		private void Grid_BeforeEditProcess_os()
		{
			if ((fgrid_main_os.Rows.Fixed > 0) && (fgrid_main_os.Row >= fgrid_main_os.Rows.Fixed))
				BufCellData = (fgrid_main_os[fgrid_main_os.Row, fgrid_main_os.Col] == null) ? "" : fgrid_main_os[fgrid_main_os.Row, fgrid_main_os.Col].ToString();
		}

		private void fgrid_main_os_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			int sel_row = fgrid_main_os.Selection.r1;	
			int sel_col = fgrid_main_os.Selection.c1;	

			if (sel_col == 3)
			{
				if (fgrid_main_os[sel_row, 3].ToString().Replace("-", "").Length != 9)
					fgrid_main_os[sel_row, 3] = "";
			}

			fgrid_main_os.Update_Row();
	
		}

		private void Form_JM_BOTTOM_EFF_Load(object sender, System.EventArgs e)
		{
		
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
		}


	}
}
