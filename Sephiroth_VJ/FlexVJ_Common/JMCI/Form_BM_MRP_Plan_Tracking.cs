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
	public class Form_BM_MRP_Plan_Tracking : COM.VJ_CommonWinForm.Form_Top
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
		private System.Windows.Forms.Panel pnl_BB2;
		private System.Windows.Forms.TabControl tab_Main;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.TabPage tabPageDesc;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.TextBox txtTheme;
		private System.Windows.Forms.Label lblTheme;
		public System.Windows.Forms.DateTimePicker dpickDate;
		private System.Windows.Forms.Label btnSave;
		private System.Windows.Forms.Label lblStyle_cd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblModel;
		private System.Windows.Forms.Label lblobs_id;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbl_PlanYMD;
		private C1.Win.C1List.C1Combo cmbStatus;
		private System.Windows.Forms.Label lblStatus;
		private C1.Win.C1List.C1Combo cmbLoc;
		private System.Windows.Forms.Label lblLocation;
		private C1.Win.C1List.C1Combo cmbLine;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_dpo;
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
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chkNew_Style;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.DateTimePicker dpick_date_from;
		private System.Windows.Forms.DateTimePicker dpick_date_to;
		private System.Windows.Forms.CheckBox chkLLT_YN;
		private System.Windows.Forms.Label label6;
		private C1.Win.C1List.C1Combo cmbCategory;
		private System.Windows.Forms.Label label7;
		private C1.Win.C1List.C1Combo cmb_obsid_fr;
		private System.Windows.Forms.Label label8;
		private C1.Win.C1List.C1Combo cmb_obsid_to;
		private System.Windows.Forms.Label label9;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 생성자 / 소멸자

		public Form_BM_MRP_Plan_Tracking()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_BM_MRP_Plan_Tracking));
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
			this.panel3 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.cmb_obsid_to = new C1.Win.C1List.C1Combo();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbCategory = new C1.Win.C1List.C1Combo();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.chkLLT_YN = new System.Windows.Forms.CheckBox();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.chkNew_Style = new System.Windows.Forms.CheckBox();
			this.dpick_date_from = new System.Windows.Forms.DateTimePicker();
			this.dpick_date_to = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.lbl_PlanYMD = new System.Windows.Forms.Label();
			this.cmbStatus = new C1.Win.C1List.C1Combo();
			this.lblStatus = new System.Windows.Forms.Label();
			this.cmbLoc = new C1.Win.C1List.C1Combo();
			this.lblLocation = new System.Windows.Forms.Label();
			this.cmbLine = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.cmb_obsid_fr = new C1.Win.C1List.C1Combo();
			this.lbl_dpo = new System.Windows.Forms.Label();
			this.lbl_Style = new System.Windows.Forms.Label();
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
			this.pnl_BB2 = new System.Windows.Forms.Panel();
			this.tab_Main = new System.Windows.Forms.TabControl();
			this.tabPageDesc = new System.Windows.Forms.TabPage();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblStyle_cd = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Label();
			this.dpickDate = new System.Windows.Forms.DateTimePicker();
			this.lblTheme = new System.Windows.Forms.Label();
			this.txtTheme = new System.Windows.Forms.TextBox();
			this.lblDate = new System.Windows.Forms.Label();
			this.lblobs_id = new System.Windows.Forms.Label();
			this.lblModel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_B.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.panel2.SuspendLayout();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_obsid_to)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbCategory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbStatus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbLoc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbLine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_obsid_fr)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_BB2.SuspendLayout();
			this.tab_Main.SuspendLayout();
			this.tabPageDesc.SuspendLayout();
			this.panel4.SuspendLayout();
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
			this.mnu_PurchaseSearch.Text = "Purchase Search";
			this.mnu_PurchaseSearch.Click += new System.EventHandler(this.mnu_PurchaseSearch_Click);
			// 
			// pnl_B
			// 
			this.pnl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_B.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_B.Controls.Add(this.panel3);
			this.pnl_B.Controls.Add(this.panel2);
			this.pnl_B.Controls.Add(this.splitter1);
			this.pnl_B.Controls.Add(this.pnl_BB2);
			this.pnl_B.DockPadding.Bottom = 5;
			this.pnl_B.DockPadding.Left = 5;
			this.pnl_B.DockPadding.Right = 5;
			this.pnl_B.Location = new System.Drawing.Point(0, 56);
			this.pnl_B.Name = "pnl_B";
			this.pnl_B.Size = new System.Drawing.Size(1024, 584);
			this.pnl_B.TabIndex = 29;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.fgrid_main);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(5, 136);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1014, 290);
			this.panel3.TabIndex = 50;
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
			this.fgrid_main.Size = new System.Drawing.Size(1014, 290);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 7pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 177;
			this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
			this.fgrid_main.SelChange += new System.EventHandler(this.fgrid_main_SelChange);
			this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			this.fgrid_main.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fgrid_main_KeyUp);
			this.fgrid_main.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fgrid_main_KeyDown);
			this.fgrid_main.KeyPressEdit += new C1.Win.C1FlexGrid.KeyPressEditEventHandler(this.fgrid_main_KeyPressEdit);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pnl_head);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(5, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1014, 136);
			this.panel2.TabIndex = 49;
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.label9);
			this.pnl_head.Controls.Add(this.cmb_obsid_to);
			this.pnl_head.Controls.Add(this.label8);
			this.pnl_head.Controls.Add(this.cmbCategory);
			this.pnl_head.Controls.Add(this.label7);
			this.pnl_head.Controls.Add(this.label6);
			this.pnl_head.Controls.Add(this.chkLLT_YN);
			this.pnl_head.Controls.Add(this.txt_StyleCd);
			this.pnl_head.Controls.Add(this.chkNew_Style);
			this.pnl_head.Controls.Add(this.dpick_date_from);
			this.pnl_head.Controls.Add(this.dpick_date_to);
			this.pnl_head.Controls.Add(this.label5);
			this.pnl_head.Controls.Add(this.lbl_PlanYMD);
			this.pnl_head.Controls.Add(this.cmbStatus);
			this.pnl_head.Controls.Add(this.lblStatus);
			this.pnl_head.Controls.Add(this.cmbLoc);
			this.pnl_head.Controls.Add(this.lblLocation);
			this.pnl_head.Controls.Add(this.cmbLine);
			this.pnl_head.Controls.Add(this.label1);
			this.pnl_head.Controls.Add(this.cmb_obsid_fr);
			this.pnl_head.Controls.Add(this.lbl_dpo);
			this.pnl_head.Controls.Add(this.lbl_Style);
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
			this.pnl_head.Size = new System.Drawing.Size(1014, 136);
			this.pnl_head.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(231, 30);
			this.label2.TabIndex = 393;
			this.label2.Text = "      Search Information";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(199, 87);
			this.label9.Name = "label9";
			this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label9.Size = new System.Drawing.Size(16, 16);
			this.label9.TabIndex = 569;
			this.label9.Text = "~";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmb_obsid_to
			// 
			this.cmb_obsid_to.AddItemCols = 0;
			this.cmb_obsid_to.AddItemSeparator = ';';
			this.cmb_obsid_to.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_obsid_to.AutoSize = false;
			this.cmb_obsid_to.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_obsid_to.Caption = "";
			this.cmb_obsid_to.CaptionHeight = 17;
			this.cmb_obsid_to.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_obsid_to.ColumnCaptionHeight = 18;
			this.cmb_obsid_to.ColumnFooterHeight = 18;
			this.cmb_obsid_to.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_obsid_to.ContentHeight = 17;
			this.cmb_obsid_to.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_obsid_to.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_obsid_to.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_obsid_to.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_obsid_to.EditorHeight = 17;
			this.cmb_obsid_to.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_obsid_to.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_obsid_to.GapHeight = 2;
			this.cmb_obsid_to.ItemHeight = 15;
			this.cmb_obsid_to.Location = new System.Drawing.Point(215, 84);
			this.cmb_obsid_to.MatchEntryTimeout = ((long)(2000));
			this.cmb_obsid_to.MaxDropDownItems = ((short)(5));
			this.cmb_obsid_to.MaxLength = 32767;
			this.cmb_obsid_to.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_obsid_to.Name = "cmb_obsid_to";
			this.cmb_obsid_to.PartialRightColumn = false;
			this.cmb_obsid_to.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Gulim, 9p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True" +
				";AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Cont" +
				"rol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.Li" +
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
			this.cmb_obsid_to.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_obsid_to.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_obsid_to.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_obsid_to.Size = new System.Drawing.Size(90, 21);
			this.cmb_obsid_to.TabIndex = 568;
			this.cmb_obsid_to.SelectedValueChanged += new System.EventHandler(this.cmb_obs_id_SelectedValueChanged);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label8.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ImageIndex = 0;
			this.label8.ImageList = this.img_Label;
			this.label8.Location = new System.Drawing.Point(8, 106);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 21);
			this.label8.TabIndex = 565;
			this.label8.Text = "New Style";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmbCategory.Location = new System.Drawing.Point(445, 62);
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
			this.cmbCategory.Size = new System.Drawing.Size(200, 21);
			this.cmbCategory.TabIndex = 564;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label7.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ImageIndex = 0;
			this.label7.ImageList = this.img_Label;
			this.label7.Location = new System.Drawing.Point(344, 62);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 21);
			this.label7.TabIndex = 563;
			this.label7.Text = "Category";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label6.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ImageIndex = 0;
			this.label6.ImageList = this.img_Label;
			this.label6.Location = new System.Drawing.Point(689, 84);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 21);
			this.label6.TabIndex = 562;
			this.label6.Text = "LLT Y/N";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label6.Visible = false;
			// 
			// chkLLT_YN
			// 
			this.chkLLT_YN.Location = new System.Drawing.Point(793, 88);
			this.chkLLT_YN.Name = "chkLLT_YN";
			this.chkLLT_YN.Size = new System.Drawing.Size(96, 16);
			this.chkLLT_YN.TabIndex = 561;
			this.chkLLT_YN.Visible = false;
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.SystemColors.Window;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StyleCd.Location = new System.Drawing.Point(445, 40);
			this.txt_StyleCd.MaxLength = 10;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.Size = new System.Drawing.Size(200, 21);
			this.txt_StyleCd.TabIndex = 560;
			this.txt_StyleCd.Text = "";
			// 
			// chkNew_Style
			// 
			this.chkNew_Style.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkNew_Style.Enabled = false;
			this.chkNew_Style.Location = new System.Drawing.Point(108, 110);
			this.chkNew_Style.Name = "chkNew_Style";
			this.chkNew_Style.Size = new System.Drawing.Size(16, 16);
			this.chkNew_Style.TabIndex = 558;
			// 
			// dpick_date_from
			// 
			this.dpick_date_from.CustomFormat = "yyyy-MM-dd";
			this.dpick_date_from.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_date_from.Location = new System.Drawing.Point(109, 63);
			this.dpick_date_from.Name = "dpick_date_from";
			this.dpick_date_from.Size = new System.Drawing.Size(90, 21);
			this.dpick_date_from.TabIndex = 555;
			// 
			// dpick_date_to
			// 
			this.dpick_date_to.CustomFormat = "yyyy-MM-dd";
			this.dpick_date_to.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_date_to.Location = new System.Drawing.Point(215, 63);
			this.dpick_date_to.Name = "dpick_date_to";
			this.dpick_date_to.Size = new System.Drawing.Size(91, 21);
			this.dpick_date_to.TabIndex = 556;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(199, 64);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(16, 16);
			this.label5.TabIndex = 557;
			this.label5.Text = "~";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// cmbStatus
			// 
			this.cmbStatus.AddItemCols = 0;
			this.cmbStatus.AddItemSeparator = ';';
			this.cmbStatus.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
			this.cmbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbStatus.Caption = "";
			this.cmbStatus.CaptionHeight = 17;
			this.cmbStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbStatus.ColumnCaptionHeight = 18;
			this.cmbStatus.ColumnFooterHeight = 18;
			this.cmbStatus.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbStatus.ContentHeight = 17;
			this.cmbStatus.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbStatus.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbStatus.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbStatus.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbStatus.EditorHeight = 17;
			this.cmbStatus.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbStatus.GapHeight = 2;
			this.cmbStatus.ItemHeight = 15;
			this.cmbStatus.Location = new System.Drawing.Point(789, 62);
			this.cmbStatus.MatchEntryTimeout = ((long)(2000));
			this.cmbStatus.MaxDropDownItems = ((short)(5));
			this.cmbStatus.MaxLength = 32767;
			this.cmbStatus.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.PartialRightColumn = false;
			this.cmbStatus.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmbStatus.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbStatus.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbStatus.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbStatus.Size = new System.Drawing.Size(200, 21);
			this.cmbStatus.TabIndex = 542;
			// 
			// lblStatus
			// 
			this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lblStatus.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblStatus.ImageIndex = 0;
			this.lblStatus.ImageList = this.img_Label;
			this.lblStatus.Location = new System.Drawing.Point(688, 62);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(100, 21);
			this.lblStatus.TabIndex = 541;
			this.lblStatus.Text = "State";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbLoc
			// 
			this.cmbLoc.AddItemCols = 0;
			this.cmbLoc.AddItemSeparator = ';';
			this.cmbLoc.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
			this.cmbLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbLoc.Caption = "";
			this.cmbLoc.CaptionHeight = 17;
			this.cmbLoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbLoc.ColumnCaptionHeight = 18;
			this.cmbLoc.ColumnFooterHeight = 18;
			this.cmbLoc.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbLoc.ContentHeight = 17;
			this.cmbLoc.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbLoc.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbLoc.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbLoc.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbLoc.EditorHeight = 17;
			this.cmbLoc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbLoc.GapHeight = 2;
			this.cmbLoc.ItemHeight = 15;
			this.cmbLoc.Location = new System.Drawing.Point(445, 84);
			this.cmbLoc.MatchEntryTimeout = ((long)(2000));
			this.cmbLoc.MaxDropDownItems = ((short)(5));
			this.cmbLoc.MaxLength = 32767;
			this.cmbLoc.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbLoc.Name = "cmbLoc";
			this.cmbLoc.PartialRightColumn = false;
			this.cmbLoc.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmbLoc.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbLoc.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbLoc.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbLoc.Size = new System.Drawing.Size(200, 21);
			this.cmbLoc.TabIndex = 540;
			// 
			// lblLocation
			// 
			this.lblLocation.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lblLocation.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblLocation.ImageIndex = 0;
			this.lblLocation.ImageList = this.img_Label;
			this.lblLocation.Location = new System.Drawing.Point(344, 84);
			this.lblLocation.Name = "lblLocation";
			this.lblLocation.Size = new System.Drawing.Size(100, 21);
			this.lblLocation.TabIndex = 539;
			this.lblLocation.Text = "Location";
			this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmbLine.Location = new System.Drawing.Point(789, 40);
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
			this.cmbLine.Size = new System.Drawing.Size(200, 21);
			this.cmbLine.TabIndex = 538;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(688, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 537;
			this.label1.Text = "Line";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_obsid_fr
			// 
			this.cmb_obsid_fr.AddItemCols = 0;
			this.cmb_obsid_fr.AddItemSeparator = ';';
			this.cmb_obsid_fr.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_obsid_fr.AutoSize = false;
			this.cmb_obsid_fr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_obsid_fr.Caption = "";
			this.cmb_obsid_fr.CaptionHeight = 17;
			this.cmb_obsid_fr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_obsid_fr.ColumnCaptionHeight = 18;
			this.cmb_obsid_fr.ColumnFooterHeight = 18;
			this.cmb_obsid_fr.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_obsid_fr.ContentHeight = 17;
			this.cmb_obsid_fr.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_obsid_fr.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_obsid_fr.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_obsid_fr.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_obsid_fr.EditorHeight = 17;
			this.cmb_obsid_fr.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_obsid_fr.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_obsid_fr.GapHeight = 2;
			this.cmb_obsid_fr.ItemHeight = 15;
			this.cmb_obsid_fr.Location = new System.Drawing.Point(109, 84);
			this.cmb_obsid_fr.MatchEntryTimeout = ((long)(2000));
			this.cmb_obsid_fr.MaxDropDownItems = ((short)(5));
			this.cmb_obsid_fr.MaxLength = 32767;
			this.cmb_obsid_fr.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_obsid_fr.Name = "cmb_obsid_fr";
			this.cmb_obsid_fr.PartialRightColumn = false;
			this.cmb_obsid_fr.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_obsid_fr.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_obsid_fr.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_obsid_fr.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_obsid_fr.Size = new System.Drawing.Size(90, 21);
			this.cmb_obsid_fr.TabIndex = 415;
			this.cmb_obsid_fr.SelectedValueChanged += new System.EventHandler(this.cmb_obs_id_SelectedValueChanged);
			// 
			// lbl_dpo
			// 
			this.lbl_dpo.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_dpo.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_dpo.ImageIndex = 0;
			this.lbl_dpo.ImageList = this.img_Label;
			this.lbl_dpo.Location = new System.Drawing.Point(8, 84);
			this.lbl_dpo.Name = "lbl_dpo";
			this.lbl_dpo.Size = new System.Drawing.Size(100, 21);
			this.lbl_dpo.TabIndex = 414;
			this.lbl_dpo.Text = "DPO";
			this.lbl_dpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head3.Location = new System.Drawing.Point(998, 120);
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
			this.pic_head4.Location = new System.Drawing.Point(136, 119);
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
			this.cmb_Factory.Size = new System.Drawing.Size(196, 21);
			this.cmb_Factory.TabIndex = 1;
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
			this.pic_head7.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head7.Location = new System.Drawing.Point(913, 30);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.Size = new System.Drawing.Size(101, 95);
			this.pic_head7.TabIndex = 46;
			this.pic_head7.TabStop = false;
			// 
			// pic_head2
			// 
			this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.pic_head5.Location = new System.Drawing.Point(0, 120);
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
			this.pic_head6.Location = new System.Drawing.Point(0, 0);
			this.pic_head6.Name = "pic_head6";
			this.pic_head6.Size = new System.Drawing.Size(168, 118);
			this.pic_head6.TabIndex = 41;
			this.pic_head6.TabStop = false;
			// 
			// pic_head1
			// 
			this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head1.Location = new System.Drawing.Point(160, 0);
			this.pic_head1.Name = "pic_head1";
			this.pic_head1.Size = new System.Drawing.Size(934, 32);
			this.pic_head1.TabIndex = 39;
			this.pic_head1.TabStop = false;
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter1.Location = new System.Drawing.Point(5, 426);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(1014, 3);
			this.splitter1.TabIndex = 48;
			this.splitter1.TabStop = false;
			// 
			// pnl_BB2
			// 
			this.pnl_BB2.Controls.Add(this.tab_Main);
			this.pnl_BB2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnl_BB2.DockPadding.Top = 2;
			this.pnl_BB2.Location = new System.Drawing.Point(5, 429);
			this.pnl_BB2.Name = "pnl_BB2";
			this.pnl_BB2.Size = new System.Drawing.Size(1014, 150);
			this.pnl_BB2.TabIndex = 47;
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
			this.tab_Main.TabIndex = 3;
			this.tab_Main.Click += new System.EventHandler(this.tab_Main_Click);
			// 
			// tabPageDesc
			// 
			this.tabPageDesc.BackColor = System.Drawing.SystemColors.Window;
			this.tabPageDesc.Controls.Add(this.textBox1);
			this.tabPageDesc.Controls.Add(this.panel4);
			this.tabPageDesc.DockPadding.Top = -6;
			this.tabPageDesc.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tabPageDesc.Location = new System.Drawing.Point(4, 23);
			this.tabPageDesc.Name = "tabPageDesc";
			this.tabPageDesc.Size = new System.Drawing.Size(1006, 121);
			this.tabPageDesc.TabIndex = 0;
			this.tabPageDesc.Text = "Description";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(0, 27);
			this.textBox1.MaxLength = 4000;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(1006, 94);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.lblStyle_cd);
			this.panel4.Controls.Add(this.btnSave);
			this.panel4.Controls.Add(this.dpickDate);
			this.panel4.Controls.Add(this.lblTheme);
			this.panel4.Controls.Add(this.txtTheme);
			this.panel4.Controls.Add(this.lblDate);
			this.panel4.Controls.Add(this.lblobs_id);
			this.panel4.Controls.Add(this.lblModel);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, -6);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1006, 33);
			this.panel4.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label4.Font = new System.Drawing.Font("Verdana", 9F);
			this.label4.ImageIndex = 0;
			this.label4.ImageList = this.img_Button;
			this.label4.Location = new System.Drawing.Point(921, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 673;
			this.label4.Text = "Delete";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.Gray;
			this.label3.Location = new System.Drawing.Point(584, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 23);
			this.label3.TabIndex = 670;
			this.label3.Text = "※";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblStyle_cd
			// 
			this.lblStyle_cd.ForeColor = System.Drawing.Color.Gray;
			this.lblStyle_cd.Location = new System.Drawing.Point(600, 8);
			this.lblStyle_cd.Name = "lblStyle_cd";
			this.lblStyle_cd.Size = new System.Drawing.Size(88, 23);
			this.lblStyle_cd.TabIndex = 669;
			this.lblStyle_cd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btnSave.Font = new System.Drawing.Font("Verdana", 9F);
			this.btnSave.ImageIndex = 0;
			this.btnSave.ImageList = this.img_Button;
			this.btnSave.Location = new System.Drawing.Point(840, 7);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(80, 23);
			this.btnSave.TabIndex = 668;
			this.btnSave.Text = "Save";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// dpickDate
			// 
			this.dpickDate.CustomFormat = "";
			this.dpickDate.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpickDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpickDate.Location = new System.Drawing.Point(469, 9);
			this.dpickDate.Name = "dpickDate";
			this.dpickDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dpickDate.Size = new System.Drawing.Size(96, 21);
			this.dpickDate.TabIndex = 666;
			// 
			// lblTheme
			// 
			this.lblTheme.Font = new System.Drawing.Font("Gulim", 9F);
			this.lblTheme.ImageIndex = 2;
			this.lblTheme.ImageList = this.img_Label;
			this.lblTheme.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblTheme.Location = new System.Drawing.Point(3, 9);
			this.lblTheme.Name = "lblTheme";
			this.lblTheme.Size = new System.Drawing.Size(100, 21);
			this.lblTheme.TabIndex = 665;
			this.lblTheme.Text = "Theme";
			this.lblTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtTheme
			// 
			this.txtTheme.BackColor = System.Drawing.Color.White;
			this.txtTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTheme.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txtTheme.Location = new System.Drawing.Point(104, 9);
			this.txtTheme.MaxLength = 100;
			this.txtTheme.Name = "txtTheme";
			this.txtTheme.Size = new System.Drawing.Size(256, 21);
			this.txtTheme.TabIndex = 663;
			this.txtTheme.Text = "";
			// 
			// lblDate
			// 
			this.lblDate.Font = new System.Drawing.Font("Gulim", 9F);
			this.lblDate.ImageIndex = 2;
			this.lblDate.ImageList = this.img_Label;
			this.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblDate.Location = new System.Drawing.Point(368, 9);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(100, 21);
			this.lblDate.TabIndex = 662;
			this.lblDate.Text = "Date";
			this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblobs_id
			// 
			this.lblobs_id.ForeColor = System.Drawing.Color.Gray;
			this.lblobs_id.Location = new System.Drawing.Point(608, 8);
			this.lblobs_id.Name = "lblobs_id";
			this.lblobs_id.Size = new System.Drawing.Size(88, 23);
			this.lblobs_id.TabIndex = 672;
			this.lblobs_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblModel
			// 
			this.lblModel.ForeColor = System.Drawing.Color.Gray;
			this.lblModel.Location = new System.Drawing.Point(694, 8);
			this.lblModel.Name = "lblModel";
			this.lblModel.Size = new System.Drawing.Size(298, 23);
			this.lblModel.TabIndex = 671;
			this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Form_BM_MRP_Plan_Tracking
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_B);
			this.Name = "Form_BM_MRP_Plan_Tracking";
			this.Text = "Tracking for Pre-production Planning";
			this.Load += new System.EventHandler(this.Form_BM_MRP_Plan_Tracking_Load);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_B, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_B.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.panel2.ResumeLayout(false);
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_obsid_to)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbCategory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbStatus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbLoc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbLine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_obsid_fr)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_BB2.ResumeLayout(false);
			this.tab_Main.ResumeLayout(false);
			this.tabPageDesc.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Column_define
 
		private COM.OraDB MyOraDB = new COM.OraDB(); 				
		private int _Rowfixed;
		private bool _Upload_ON_Flag = false;
		private bool _bDiv = false;
		private string _sDPO;
		private string _sStyle;

		//private bool _flag = true;

		// search option value
		//private const string PKG = "PKG_SBM_MRP_MONITORING_LOCAL";		
		private Hashtable _columns = new Hashtable();

		private int _colFACTORY                   = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxFACTORY;
		private int _colOBS_ID                    = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxOBS_ID;                  
		private int _colVER                       = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxVER;                     
		private int _colMODEL_CD                  = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxMODEL_CD;
		private int _colREASON_DIV                = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxREASON_DIV;
		//private int _colMODEL_NAME                = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxMODEL_NAME;
		private int _colSTYLE_CD                  = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxSTYLE_CD;
		private int _colCATEGORY                  = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxCATEGORY;
		private int _colMODEL_INF                 = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxMODEL_INF;
		private int _colMODEL_NAME                = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxMODEL_NAME;
		private int _colLINE_NAME                 = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxLINE_NAME;
		private int _colORDER_QTY                 = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxORDER_QTY;
		private int _colRGAC_YMD                  = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxRGAC_YMD;
		private int _colPLAN_YMD_1                = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxPLAN_YMD_1;
		private int _colPLAN_YMD_2                = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxPLAN_YMD_2;
		private int _colLOCATION_CD               = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxLOCATION_CD;

		private int _colTARGET_SILHOUETTE_MAT     = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxTARGET_SILHOUETTE_MAT;
		private int _colACTUAL_SILHOUETTE_MAT     = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxACTUAL_SILHOUETTE_MAT;
		private int _colWARNING_SILHOUETTE_MAT    = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxWARNING_SILHOUETTE_MAT;
		private int _colTARGET_SILHOUETTE_WS      = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxTARGET_SILHOUETTE_WS;
		private int _colACTUAL_SILHOUETTE_WS      = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxACTUAL_SILHOUETTE_WS;
		private int _colWARNING_SILHOUETTE_WS     = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxWARNING_SILHOUETTE_WS;

		private int _colLLT_YN                    = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxLLT_YN;
		private int _colTARGET_MBOM               = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxTARGET_MBOM;
		private int _colACTUAL_MBOM               = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxACTUAL_MBOM;
		private int _colWARNING_MBOM              = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxWARNING_MBOM;
		private int _colTARGET_MUL                = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxTARGET_MUL;
		private int _colACTUAL_MUL                = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxACTUAL_MUL;
		private int _colWARNING_MUL               = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxWARNING_MUL;
		private int _colTARGET_CFM_SAMPLE_MAT     = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxTARGET_CFM_SAMPLE_MAT;
		private int _colACTUAL_CFM_SAMPLE_MAT     = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxACTUAL_CFM_SAMPLE_MAT;
		private int _colWARNING_CFM_SAMPLE_MAT    = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxWARNING_CFM_SAMPLE_MAT;
		private int _colTARGET_COLOR_SWATCH       = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxTARGET_COLOR_SWATCH;
		private int _colACTUAL_COLOR_SWATCH       = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxACTUAL_COLOR_SWATCH;
		private int _colWARNING_COLOR_SWATCH      = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxWARNING_COLOR_SWATCH;
		private int _colWARNING_COLOR_SWATCH_RECV = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxWARNING_COLOR_SWATCH_RECV;
		private int _colTARGET_REF_PFC            = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxTARGET_REF_PFC;
		private int _colACTUAL_REF_PFC            = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxACTUAL_REF_PFC;
		private int _colWARNING_REF_PFC           = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxWARNING_REF_PFC;
		private int _colTARGET_CFM_SAMPLE         = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxTARGET_CFM_SAMPLE;
		private int _colETC_CFM_SAMPLE            = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxETC_CFM_SAMPLE;
		private int _colWARNING_ETC_CFM_SAMPLE    = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxWARNING_ETC_CFM_SAMPLE;
		private int _colACTUAL_CFM_SAMPLE         = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxACTUAL_CFM_SAMPLE;
		private int _colWARNING_CFM_SAMPLE        = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxWARNING_CFM_SAMPLE;
		private int _colVENDOR_LEAD_TIME          = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxVENDOR_LEAD_TIME;
		private int _colACTUAL_COLOR_SWATCH_RECV  = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxACTUAL_COLOR_SWATCH_RECV;
		private int _colTARGET_PURCHASING         = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxTARGET_PURCHASING;
		private int _colACTUAL_PURCHASING         = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxACTUAL_PURCHASING;
		private int _colWARNING_PURCHASING        = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxWARNING_PURCHASING;
		private int _colTARGET_ETD                = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxTARGET_ETD;
		private int _colACTUAL_ETD                = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxACTUAL_ETD;
		private int _colWARNING_ETD               = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxWARNING_ETD;
		private int _colTARGET_ETA_PORT           = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxTARGET_ETA_PORT;
		private int _colACTUAL_ETA_PORT           = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxACTUAL_ETA_PORT;
		private int _colWARNING_ETA_PORT          = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxWARNING_ETA_PORT;
		private int _colACTUAL_ETA_VJ             = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxACTUAL_ETA_VJ;
		private int _colWARNING_ETA_VJ            = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxWARNING_ETA_VJ;
		private int _colD_HOW_MANY_DAYS           = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxD_HOW_MANY_DAYS;
		private int _colAGREE_DATE                = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxAGREE_DATE;
		private int _colTHEME                     = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxTHEME;
		private int _colREASON                    = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxREASON;
		private int _colSTYLE_DIV                 = (int)ClassLib.TSBM_MRP_LLT_PLAN_TRACKING.IxSTYLE_DIV;

												   
		
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
				this.Cursor = Cursors.WaitCursor;
								
				this.Tbtn_SearchProcess();
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

		#endregion

		#region 컨트롤 이벤트 처리

		   
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_Factory.SelectedIndex == -1) return;
			fgrid_main.ClearAll();
			setDPO();
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

		private void mnu_PurchaseSearch_Click(object sender, System.EventArgs e)
		{
			this.Btn_SearchPurClickProcess();
		}

		
		private void Btn_SearchPurClickProcess()
		{
//			int vRow = fgrid_main.Row; 
//
//			COM.ComVar.Parameter_PopUp		= new string[9];
//			COM.ComVar.Parameter_PopUp[0]	= cmb_Factory.SelectedValue.ToString();
//			COM.ComVar.Parameter_PopUp[1]	= fgrid_main[vRow,  19].ToString();
//			COM.ComVar.Parameter_PopUp[2]	= fgrid_main[vRow,  20].ToString();
//			COM.ComVar.Parameter_PopUp[3]	= fgrid_main[vRow,  15].ToString();
//			COM.ComVar.Parameter_PopUp[4]	= fgrid_main[vRow,  16].ToString();
//			COM.ComVar.Parameter_PopUp[5]	= fgrid_main[vRow,  17].ToString(); 
//			COM.ComVar.Parameter_PopUp[6]	= fgrid_main[vRow,   2].ToString();
//			COM.ComVar.Parameter_PopUp[7]	= fgrid_main[vRow,   3].ToString();
//			COM.ComVar.Parameter_PopUp[8]	= fgrid_main[vRow,   4].ToString();
//
//			Pop_BM_InOut_Infomation  pop_bp_purchase     = new Pop_BM_InOut_Infomation();
//			 
//			pop_bp_purchase.ShowDialog();
//			pop_bp_purchase.Dispose();

		}



		#endregion 
		
		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form set
			this.Text = "Tracking for Pre-Production Planning";
			lbl_MainTitle.Text = "Tracking for Pre-Production Planning";
			
			// grid set
			fgrid_main.Set_Grid("SBM_MRP_LLT_PLAN_TRACKING", "5", 3, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);			
			fgrid_main.Rows[0].AllowMerging = true;
			fgrid_main.Rows[1].AllowMerging = true;
			fgrid_main.Set_Action_Image(img_Action);

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

			//	cmbCategory
			//dt_ret = SELECT_CATEGORY_INFO();
			dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SXB03");
			COM.ComCtl.Set_ComboList(dt_ret, cmbCategory, 1, 2, true, 80, 140);
			cmbCategory.SelectedIndex = 0;

			//	cmbLoc
			dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SPP02");
			COM.ComCtl.Set_ComboList(dt_ret, cmbLoc, 1, 2, true, 80, 140);
			cmbLoc.SelectedIndex = 0;
			
			//	cmbStatus
			dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SPP04");
			COM.ComCtl.Set_ComboList(dt_ret, cmbStatus, 1, 2, true, 80, 140);
			cmbStatus.SelectedIndex = 1;
			
			dt_ret.Dispose(); 


			//일자 초기화
			string sFrom_date = System.DateTime.Now.ToString("yyyy-MM-dd");
			string sTo_date   = System.DateTime.Now.AddDays(70).ToString("yyyy-MM-dd");
						 
			dpick_date_from.Text = sFrom_date;
			dpick_date_to.Text   = sTo_date;

			// toolbar button disable setting
			tbtn_Delete.Enabled = false;
			tbtn_Confirm.Enabled = false; 		
			

			fgrid_main.Cols[_colPLAN_YMD_1].Style.Format                = "yyyy-MM-dd";
			fgrid_main.Cols[_colPLAN_YMD_2].Style.Format                = "yyyy-MM-dd";
			fgrid_main.Cols[_colTARGET_SILHOUETTE_MAT].Style.Format     = "yyyy-MM-dd";
			fgrid_main.Cols[_colACTUAL_SILHOUETTE_MAT].Style.Format     = "yyyy-MM-dd";
			fgrid_main.Cols[_colTARGET_SILHOUETTE_WS].Style.Format      = "yyyy-MM-dd";
			fgrid_main.Cols[_colACTUAL_SILHOUETTE_WS].Style.Format      = "yyyy-MM-dd";
		    fgrid_main.Cols[_colTARGET_MBOM].Style.Format               = "yyyy-MM-dd";
			fgrid_main.Cols[_colACTUAL_MBOM].Style.Format               = "yyyy-MM-dd";              
			fgrid_main.Cols[_colTARGET_MUL].Style.Format                = "yyyy-MM-dd";               
			fgrid_main.Cols[_colACTUAL_MUL].Style.Format                = "yyyy-MM-dd";               
			fgrid_main.Cols[_colTARGET_CFM_SAMPLE_MAT].Style.Format     = "yyyy-MM-dd";    
			fgrid_main.Cols[_colACTUAL_CFM_SAMPLE_MAT].Style.Format     = "yyyy-MM-dd";    
			fgrid_main.Cols[_colTARGET_COLOR_SWATCH].Style.Format       = "yyyy-MM-dd";      
			fgrid_main.Cols[_colACTUAL_COLOR_SWATCH].Style.Format       = "yyyy-MM-dd";      
			fgrid_main.Cols[_colTARGET_REF_PFC].Style.Format            = "yyyy-MM-dd";           
			fgrid_main.Cols[_colACTUAL_REF_PFC].Style.Format            = "yyyy-MM-dd";           
			fgrid_main.Cols[_colTARGET_CFM_SAMPLE].Style.Format         = "yyyy-MM-dd";        
			fgrid_main.Cols[_colETC_CFM_SAMPLE].Style.Format            = "yyyy-MM-dd";        
			fgrid_main.Cols[_colACTUAL_CFM_SAMPLE].Style.Format         = "yyyy-MM-dd";        
			fgrid_main.Cols[_colACTUAL_COLOR_SWATCH_RECV].Style.Format  = "yyyy-MM-dd"; 
			fgrid_main.Cols[_colTARGET_PURCHASING].Style.Format         = "yyyy-MM-dd";        
			fgrid_main.Cols[_colACTUAL_PURCHASING].Style.Format         = "yyyy-MM-dd";        
			fgrid_main.Cols[_colTARGET_ETD].Style.Format                = "yyyy-MM-dd";        
			fgrid_main.Cols[_colACTUAL_ETD].Style.Format                = "yyyy-MM-dd";     
            fgrid_main.Cols[_colTARGET_ETA_PORT].Style.Format           = "yyyy-MM-dd";          
			fgrid_main.Cols[_colACTUAL_ETA_PORT].Style.Format           = "yyyy-MM-dd";          
			fgrid_main.Cols[_colACTUAL_ETA_VJ].Style.Format             = "yyyy-MM-dd";            
						
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

		public DataTable SELECT_CATEGORY_INFO()
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;
			
			try
			{
				string process_name = "PKG_SBM_LLT_PLAN_TRACKING_VJ01.SELECT_CATEGORY_INFO";

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


		private void setDPO()
		{			
			DataTable dt_ret = Select_DP_DPO_List(cmb_Factory.SelectedValue.ToString(), "2" );

			COM.ComCtl.Set_ComboList(dt_ret, cmb_obsid_fr, 0, 0, true, ClassLib.ComVar.ComboList_Visible.Name); 
			cmb_obsid_fr.SelectedIndex = 0;

			COM.ComCtl.Set_ComboList(dt_ret, cmb_obsid_to, 0, 0, true, ClassLib.ComVar.ComboList_Visible.Name); 
			cmb_obsid_to.SelectedIndex = 0;
		}

		/// <summary>
		/// Select_DP_DPO_List : dp, dpo list 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_division"></param>
		/// <returns></returns>
		public DataTable Select_DP_DPO_List(string arg_factory, string arg_division)
		{


			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;
			
			try
			{
				string process_name = "PKG_SBM_LLT_PLAN_TRACKING_VJ.SELECT_SBM_DP_DPO_LIST";

				MyOraDB.ReDim_Parameter(3);  
				MyOraDB.Process_Name = process_name;

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR"; 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_division;
				MyOraDB.Parameter_Values[2] = ""; 

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

		private void setStyleList()
		{
//			if (cmb_obs_id.SelectedIndex == -1)
//				return;
//
//			string[] args = new string[5];
//			
//			args[0] = COM.ComFunction.Empty_Combo(cmb_Factory, "");
//			args[1] = COM.ComFunction.Empty_Combo(cmb_obs_id, "");
//			args[2] = COM.ComFunction.Empty_Combo(cmb_obs_id, "");
//			args[3] = "2";
//
//			DataTable dt_ret = this.SELECT_STYLE_LIST_DPDPO(args);
//			if (dt_ret.Rows.Count > 0)
//			{
//				ClassLib.ComCtl.Set_ComboList(dt_ret, cmd_StyleCd, 0, 1, true, 80, 130);
//				cmd_StyleCd.SelectedIndex = 0;
//
//			}
//			dt_ret.Dispose();
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
				_bDiv = false;
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SBM_LLT_PLAN_TRACKING_VJ.SELECT_PPP_TRACKING_1";

				DataTable vDt = SELECT_PPP_TRACKING(vProcedure);

				Clear_FlexGrid();

				if (vDt.Rows.Count > 0)
				{
					Display_FlexGrid(vDt);
					SET_COLOR_WARNING();
					Grid_SetColor();

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
				}

				_bDiv = true;
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

		public DataTable SELECT_PPP_TRACKING(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(14);

			//01.PROCEDURE명
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_DATE_FROM";
			MyOraDB.Parameter_Name[ 2]  = "ARG_DATE_TO";
			MyOraDB.Parameter_Name[ 3]  = "ARG_OBS_ID_FR";
			MyOraDB.Parameter_Name[ 4]  = "ARG_OBS_ID_TO";
			MyOraDB.Parameter_Name[ 5]  = "ARG_NEW_STYLE";
			MyOraDB.Parameter_Name[ 6]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[ 7]  = "ARG_CATEGORY_CD";
			MyOraDB.Parameter_Name[ 8]  = "ARG_LINE_CD";
			MyOraDB.Parameter_Name[ 9]  = "ARG_LOCATION_CD";
			MyOraDB.Parameter_Name[10]  = "ARG_STATUS";
			MyOraDB.Parameter_Name[11]  = "ARG_LLT_YN";
			MyOraDB.Parameter_Name[12]  = "ARG_UPD_USER";
			MyOraDB.Parameter_Name[13]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 6]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 7]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 8]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 9]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[10]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[11]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[12]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[13]  = (int)OracleType.Cursor;


			//04.DATA 정의
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");			
			MyOraDB.Parameter_Values[ 1]   = this.dpick_date_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[ 2]   = this.dpick_date_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[ 3]   = ClassLib.ComFunction.Empty_Combo(cmb_obsid_fr, "");
			MyOraDB.Parameter_Values[ 4]   = ClassLib.ComFunction.Empty_Combo(cmb_obsid_to, "");

			if (chkNew_Style.Checked)
				MyOraDB.Parameter_Values[ 5] = chkNew_Style.Checked.ToString();
			else
				MyOraDB.Parameter_Values[ 5] = "";	

			MyOraDB.Parameter_Values[ 6]   = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "").Replace("-", "");				
			MyOraDB.Parameter_Values[ 7]   = ClassLib.ComFunction.Empty_Combo(cmbCategory, "");
			MyOraDB.Parameter_Values[ 8]   = ClassLib.ComFunction.Empty_Combo(cmbLine, "");
			MyOraDB.Parameter_Values[ 9]   = ClassLib.ComFunction.Empty_Combo(cmbLoc, "");
			MyOraDB.Parameter_Values[10]   = ClassLib.ComFunction.Empty_Combo(cmbStatus, "");

			if (chkLLT_YN.Checked)
				MyOraDB.Parameter_Values[ 11] = "TRUE";
			else
				MyOraDB.Parameter_Values[ 11] = "";	

			MyOraDB.Parameter_Values[12] = COM.ComVar.This_User;			
			MyOraDB.Parameter_Values[13]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}


		private void Display_FlexGrid(DataTable arg_dt)
		{
			int iCount = arg_dt.Rows.Count;

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{				
				C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(_Rowfixed + iRow, 1);

				fgrid_main[newRow.Row.Index, 0] = "";

				for (int iCol = 1 ; iCol <= arg_dt.Columns.Count ; iCol++)
				{
					fgrid_main[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
				}

			}

		}

		private void SET_COLOR_WARNING()
		{
			
			for (int iCol = 1 ; iCol < fgrid_main.Cols.Count; iCol++)
			{



				if (( iCol == _colWARNING_SILHOUETTE_MAT      ) ||
					( iCol == _colWARNING_SILHOUETTE_WS       ) ||
					( iCol == _colWARNING_MBOM                ) ||
				    ( iCol == _colWARNING_MUL                 ) ||  
				    ( iCol == _colWARNING_CFM_SAMPLE_MAT      ) ||  
				    ( iCol == _colWARNING_COLOR_SWATCH        ) ||  
					( iCol == _colWARNING_COLOR_SWATCH_RECV   ) ||  
				    ( iCol == _colWARNING_REF_PFC             ) ||  
					( iCol == _colWARNING_ETC_CFM_SAMPLE      ) ||  
				    ( iCol == _colWARNING_CFM_SAMPLE          ) ||  
				    ( iCol == _colWARNING_PURCHASING          ) ||  
				    ( iCol == _colWARNING_ETD                 ) ||  
				    ( iCol == _colWARNING_ETA_PORT            ) ||  
				    ( iCol == _colWARNING_ETA_VJ              )  )
				   {

						for (int iRow = _Rowfixed; iRow < fgrid_main.Rows.Count; iRow++)
						{
							if (fgrid_main[iRow, _colWARNING_ETD].ToString() != "NO")
							{

								if (fgrid_main[iRow, iCol].ToString() == "RT")

									fgrid_main.GetCellRange(iRow, iCol-1, iRow, iCol).StyleNew.BackColor = Color.Red;

								else if (fgrid_main[iRow, iCol].ToString() == "YT")

									fgrid_main.GetCellRange(iRow, iCol-1, iRow, iCol).StyleNew.BackColor = Color.Yellow;

								else if (fgrid_main[iRow, iCol].ToString() == "RF")

									fgrid_main.GetCellRange(iRow, iCol-1, iRow, iCol).StyleNew.BackColor = Color.Red;

								else if (fgrid_main[iRow, iCol].ToString() == "YF")

									fgrid_main.GetCellRange(iRow, iCol-1, iRow, iCol).StyleNew.BackColor = Color.Yellow;

							}
							else
							{
							
								if (fgrid_main[iRow, iCol].ToString() == "RT")

									fgrid_main.GetCellRange(iRow, iCol-1, iRow, iCol).StyleNew.BackColor = Color.Yellow;

								else if (fgrid_main[iRow, iCol].ToString() == "YT")

									fgrid_main.GetCellRange(iRow, iCol-1, iRow, iCol).StyleNew.BackColor = Color.Yellow;

								else if (fgrid_main[iRow, iCol].ToString() == "RF")

									fgrid_main.GetCellRange(iRow, iCol-1, iRow, iCol).StyleNew.BackColor = Color.Yellow;

								else if (fgrid_main[iRow, iCol].ToString() == "YF")

									fgrid_main.GetCellRange(iRow, iCol-1, iRow, iCol).StyleNew.BackColor = Color.Yellow;
							
							}



						}

				   }

			}

		}

		private void Clear_FlexGrid()
		{
			if (fgrid_main.Rows.Fixed != fgrid_main.Rows.Count)
			{				
				fgrid_main.Clear(ClearFlags.UserData, fgrid_main.Rows.Fixed, 1, fgrid_main.Rows.Count - 1, fgrid_main.Cols.Count - 1);

				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

				txtTheme.Clear();
				textBox1.Clear();
				dpickDate.Text = DateTime.Now.ToString();
					
			}
		}

//		private void SET_GRID_COLOR()
//		{
//			
//			for (int iRow = _Rowfixed; iRow < fgrid_main.Rows.Count; iRow++)
//			{
//				if ( Convert.ToInt16(fgrid_main[iRow, _colBALANCE].ToString()) >= 3)
//					fgrid_main.GetCellRange(iRow, _colACTUAL_DATE, iRow, _colACTUAL_DATE).StyleNew.BackColor = Color.Red;
//				else if (Convert.ToInt16 (fgrid_main[iRow, _colBALANCE].ToString()) == 2)
//					fgrid_main.GetCellRange(iRow, _colACTUAL_DATE, iRow, _colACTUAL_DATE).StyleNew.BackColor = Color.Yellow;
//				else if ((Convert.ToInt16(fgrid_main[iRow, _colBALANCE].ToString()) <=1 ) &&
//					(Convert.ToInt16(fgrid_main[iRow, _colBALANCE].ToString()) >= -10))
//					fgrid_main.GetCellRange(iRow, _colACTUAL_DATE, iRow, _colACTUAL_DATE).StyleNew.BackColor = Color.LightGreen;
//			}
//		}


		// grid color set
		private void Grid_SetColor()
		{
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				if ( fgrid_main[vRow, _colSTYLE_DIV].ToString().Trim()== "False")
					fgrid_main.GetCellRange(vRow, _colMODEL_NAME ,vRow, _colCATEGORY ).StyleNew.BackColor = Color.Lavender;
				/*switch (fgrid_main.Rows[vRow].Node.Level)
				{
					case 1:
						fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						break;
					case 2:
						fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
						fgrid_main.Cols[11].StyleNew.BackColor = ClassLib.ComVar.ClrPink;
						fgrid_main.Cols[12].StyleNew.BackColor = ClassLib.ComVar.ClrPink;  
							
						//						if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _shipYnCol]).Equals("") 
						//							|| ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _shipYnCol]).Substring(0, 1).Equals("N"))
						//						{
						//							fgrid_main.Rows[vRow].StyleNew.ForeColor = ClassLib.ComVar.RightRed;
						//						} 
						//
						//						if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ADJUST.IxSTATUS]).Equals("S"))
						//						{
						//							fgrid_main.Rows[vRow].AllowEditing = true;
						//						}
						//						else
						//						{
						//							fgrid_main.Rows[vRow].AllowEditing = false;
						//						}
						break;
				}*/
			}
		}



		#endregion 

		#region DB Connect

		
		/// <summary>
		/// PKG_SBM_READY : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_DPO_BALANCE(string[] parameter)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(13);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_MRP_MONITORING_LOCAL.SELECT_DPO_BALANCE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_THIS_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2]  = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[3]  = "ARG_MRP_SHIP_NO";
			MyOraDB.Parameter_Name[4]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[5]  = "ARG_FROM_DATE";
			MyOraDB.Parameter_Name[6]  = "ARG_TO_DATE";
			MyOraDB.Parameter_Name[7]  = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[8]  = "ARG_PUR_USER";
			MyOraDB.Parameter_Name[9]  = "ARG_GROUP_CD";
			MyOraDB.Parameter_Name[10] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[11] = "ARG_ITEM_NAME"; 
			MyOraDB.Parameter_Name[12] = "OUT_CURSOR";


			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[12] = (int)OracleType.Cursor;


			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[1]  = parameter[0];
			MyOraDB.Parameter_Values[2]  = parameter[1];
			MyOraDB.Parameter_Values[3]  = parameter[2]; 
			MyOraDB.Parameter_Values[4]  = parameter[3];
			MyOraDB.Parameter_Values[5]  = parameter[4];
			MyOraDB.Parameter_Values[6]  = parameter[5];
			MyOraDB.Parameter_Values[7]  = parameter[6];
			MyOraDB.Parameter_Values[8]  = parameter[7];
			MyOraDB.Parameter_Values[9]  = parameter[8];
			MyOraDB.Parameter_Values[10] = parameter[9];
			MyOraDB.Parameter_Values[11] = parameter[10];
			MyOraDB.Parameter_Values[12] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}



		/// <summary>
		/// SELECT_STYLE_LIST_DPDPO : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		private DataTable SELECT_STYLE_LIST_DPDPO(string[] arg_parameter)
		{
			try 
			{
				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(5); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_READY_LOCAL.SELECT_STYLE_LIST_DPDPO"; 

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE";
				MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";
				MyOraDB.Parameter_Name[3] = "ARG_SEARCH_TYPE";
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR"; 
      
				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_parameter[2]; 
				MyOraDB.Parameter_Values[3] = arg_parameter[3];
				MyOraDB.Parameter_Values[4] = ""; 

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_STYLE_LIST_DPDPO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}
		}

		
		

		/// <summary>
		/// PKG_SBM_MRP_MONITORING_LOCAL : 
		/// </summary>
		public bool SAVE_SBM_DPO_ITEM()
		{
			//_pop.Message = "Data Creating..";

			MyOraDB.ReDim_Parameter(12);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_MRP_MONITORING_LOCAL.RUN_DPO_PURCHASE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[3] = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[4] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[5] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[6] = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[7] = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[8] = "ARG_NEED_QTY";
			MyOraDB.Parameter_Name[9] = "ARG_PUR_USER";
			MyOraDB.Parameter_Name[10] = "ARG_PUR_YMD";
			MyOraDB.Parameter_Name[11] = "ARG_UPD_USER";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar; 


			//04.DATA 정의
			ArrayList vModifyList	= new ArrayList(fgrid_main.Rows.Count);

			vModifyList.Add("D");
			vModifyList.Add("");
			vModifyList.Add("");
			vModifyList.Add("");
			vModifyList.Add("");
			vModifyList.Add("");
			vModifyList.Add("");
			vModifyList.Add("");
			vModifyList.Add("");
			vModifyList.Add("");
			vModifyList.Add("");
			vModifyList.Add("");

			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{ 
				if (ClassLib.ComFunction.NullCheck(fgrid_main[vRow, 0], "").ToString().Equals("U"))
				{
					vModifyList.Add(ClassLib.ComFunction.NullCheck(fgrid_main[vRow, 0], "").ToString());
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 18]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 2]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 19]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 20]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 15]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 16]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 17]));
					vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 12]));
					vModifyList.Add(COM.ComVar.Parameter_PopUp[1]);
					vModifyList.Add("jaesung.cho");
					vModifyList.Add(COM.ComVar.This_User); 
				}
			}


			vModifyList.Add("R");
			vModifyList.Add(cmb_Factory.SelectedValue.ToString());
			vModifyList.Add("");
			vModifyList.Add("");
			vModifyList.Add("");
			vModifyList.Add("");
			vModifyList.Add("");
			vModifyList.Add("");
			vModifyList.Add("");
			vModifyList.Add(COM.ComVar.Parameter_PopUp[2]);
			vModifyList.Add(COM.ComVar.Parameter_PopUp[1]);
			vModifyList.Add(COM.ComVar.This_User); 

			MyOraDB.Parameter_Values = (string[])vModifyList.ToArray(Type.GetType("System.String"));


			//_pop.Message = "Saving...";

			MyOraDB.Add_Modify_Parameter(true);
			DataSet vDs = MyOraDB.Exe_Modify_Procedure();

			if (vDs != null)
				return true;
			else 
				return false;
		}


		private bool isCtrlDown = false;

		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (isCtrlDown)
			{
				int curLev = fgrid_main.Rows[fgrid_main.Row].Node.Level;
				int strRow = fgrid_main.Row;

				if (curLev == 1)
				{
					int endRow = fgrid_main.Rows[strRow].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;

					for (int row = strRow ; row <= endRow ; row++)
					{
						fgrid_main.Rows[row].Selected = true;
					}
				}
			}
		}

		private void fgrid_main_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
//			if (e.KeyCode == Keys.ControlKey)
//			{
//				isCtrlDown = true;
//			}
		}

		private void fgrid_main_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
//			if (e.KeyCode == Keys.ControlKey)
//			{
//				isCtrlDown = false;
//			}
		}

		#endregion

		private void fgrid_main_KeyPressEdit(object sender, C1.Win.C1FlexGrid.KeyPressEditEventArgs e)
		{
			int iRow = fgrid_main.Selection.r1;
			int iCol = fgrid_main.Selection.c1;			

			if (fgrid_main.Cols[iCol].DataType.Equals(typeof(DateTime)))				
			{
				if (e.KeyChar == 8)
				{
					fgrid_main.Col = iCol+1;
					fgrid_main[iRow, iCol] = null;
				}
			}		
		}

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
			fgrid_main.Update_Row();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
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

				if (SAVE_SBM_TRACKING(true))
				{

					_sDPO   = lblobs_id.Text;
					_sStyle = lblStyle_cd.Text;

					fgrid_main.Refresh_Division();
					this.Tbtn_SearchProcess();		
			
					FIND_FOCUS();
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

		public bool SAVE_SBM_TRACKING(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 31;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_LLT_PLAN_TRACKING_VJ.SAVE_PPP_TRACKING";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 2] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[ 3] = "ARG_VER";
				MyOraDB.Parameter_Name[ 4] = "ARG_MODEL_CD";
				MyOraDB.Parameter_Name[ 5] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[ 6] = "ARG_MODEL_INF";
				MyOraDB.Parameter_Name[ 7] = "ARG_LINE_NAME";
				MyOraDB.Parameter_Name[ 8] = "ARG_ORDER_QTY";
				MyOraDB.Parameter_Name[ 9] = "ARG_RGAC_YMD";
				MyOraDB.Parameter_Name[10] = "ARG_PLAN_YMD_1";
				MyOraDB.Parameter_Name[11] = "ARG_PLAN_YMD_2";
				MyOraDB.Parameter_Name[12] = "ARG_LOCATION_CD";
				MyOraDB.Parameter_Name[13] = "ARG_LLT_YN";
				MyOraDB.Parameter_Name[14] = "ARG_ACTUAL_SILHOUETTE_MAT";
				MyOraDB.Parameter_Name[15] = "ARG_ACTUAL_SILHOUETTE_WS";
				MyOraDB.Parameter_Name[16] = "ARG_ACTUAL_MBOM";
				MyOraDB.Parameter_Name[17] = "ARG_ACTUAL_MUL";
				MyOraDB.Parameter_Name[18] = "ARG_ACTUAL_CFM_SAMPLE_MAT";
				MyOraDB.Parameter_Name[19] = "ARG_ACTUAL_COLOR_SWATCH";
				MyOraDB.Parameter_Name[20] = "ARG_ACTUAL_REF_PFC";
				MyOraDB.Parameter_Name[21] = "ARG_ETC_CFM_SAMPLE";
				MyOraDB.Parameter_Name[22] = "ARG_ACTUAL_CFM_SAMPLE";
				MyOraDB.Parameter_Name[23] = "ARG_VENDOR_LEAD_TIME";
				MyOraDB.Parameter_Name[24] = "ARG_ACTUAL_COLOR_SWATCH_RECV";
				MyOraDB.Parameter_Name[25] = "ARG_ACTUAL_PURCHASING";
				MyOraDB.Parameter_Name[26] = "ARG_ACTUAL_ETD";
				MyOraDB.Parameter_Name[27] = "ARG_ACTUAL_ETA_PORT";
				MyOraDB.Parameter_Name[28] = "ARG_ACTUAL_ETA_VJ";
				MyOraDB.Parameter_Name[29] = "ARG_D_HOW_MANY_DAYS";
				MyOraDB.Parameter_Name[30] = "ARG_UPD_USER";


				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
						save_ct += 1;

				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if(fgrid_main[iRow, 0].ToString() != "")
					{
						MyOraDB.Parameter_Values[para_ct+ 0] = COM.ComVar.This_JobCdoe;
						MyOraDB.Parameter_Values[para_ct+ 1] = fgrid_main[iRow, _colFACTORY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 2] = fgrid_main[iRow, _colOBS_ID].ToString();
						MyOraDB.Parameter_Values[para_ct+ 3] = fgrid_main[iRow, _colVER].ToString();
						MyOraDB.Parameter_Values[para_ct+ 4] = fgrid_main[iRow, _colMODEL_CD].ToString();
						MyOraDB.Parameter_Values[para_ct+ 5] = fgrid_main[iRow, _colSTYLE_CD].ToString().Substring(0, 6) + fgrid_main[iRow, _colSTYLE_CD].ToString().Substring(7, 3);
						MyOraDB.Parameter_Values[para_ct+ 6] = (fgrid_main[iRow, _colMODEL_INF]                == null) ? "" : fgrid_main[iRow, _colMODEL_INF].ToString();
						MyOraDB.Parameter_Values[para_ct+ 7] = (fgrid_main[iRow, _colLINE_NAME]                == null) ? "" : fgrid_main[iRow, _colLINE_NAME].ToString();
					    MyOraDB.Parameter_Values[para_ct+ 8] = (fgrid_main[iRow, _colORDER_QTY]                == null) ? "" : fgrid_main[iRow, _colORDER_QTY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 9] = (fgrid_main[iRow, _colRGAC_YMD].ToString()      ==   "") ? "" : Convert.ToDateTime(fgrid_main[iRow, _colRGAC_YMD]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+10] = (fgrid_main[iRow, _colPLAN_YMD_1]               == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colPLAN_YMD_1]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+11] = (fgrid_main[iRow, _colPLAN_YMD_2]               == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colPLAN_YMD_2]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+12] = (fgrid_main[iRow, _colLOCATION_CD]              == null) ? "" : fgrid_main[iRow, _colLOCATION_CD].ToString();
						MyOraDB.Parameter_Values[para_ct+13] = (fgrid_main[iRow, _colLLT_YN].ToString()        == "True") ? "Y" : "N";

						MyOraDB.Parameter_Values[para_ct+14] = (fgrid_main[iRow, _colACTUAL_SILHOUETTE_MAT]    == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colACTUAL_SILHOUETTE_MAT]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+15] = (fgrid_main[iRow, _colACTUAL_SILHOUETTE_WS]     == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colACTUAL_SILHOUETTE_WS]).ToString("yyyyMMdd");

						MyOraDB.Parameter_Values[para_ct+16] = (fgrid_main[iRow, _colACTUAL_MBOM]              == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colACTUAL_MBOM]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+17] = (fgrid_main[iRow, _colACTUAL_MUL]               == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colACTUAL_MUL]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+18] = (fgrid_main[iRow, _colACTUAL_CFM_SAMPLE_MAT]    == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colACTUAL_CFM_SAMPLE_MAT]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+19] = (fgrid_main[iRow, _colACTUAL_COLOR_SWATCH]      == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colACTUAL_COLOR_SWATCH]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+20] = (fgrid_main[iRow, _colACTUAL_REF_PFC]           == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colACTUAL_REF_PFC]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+21] = (fgrid_main[iRow, _colETC_CFM_SAMPLE]        == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colETC_CFM_SAMPLE]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+22] = (fgrid_main[iRow, _colACTUAL_CFM_SAMPLE]        == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colACTUAL_CFM_SAMPLE]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+23] = (fgrid_main[iRow, _colVENDOR_LEAD_TIME]         == null) ? "" : fgrid_main[iRow, _colVENDOR_LEAD_TIME].ToString();
						MyOraDB.Parameter_Values[para_ct+24] = (fgrid_main[iRow, _colACTUAL_COLOR_SWATCH_RECV] == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colACTUAL_COLOR_SWATCH_RECV]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+25] = (fgrid_main[iRow, _colACTUAL_PURCHASING]        == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colACTUAL_PURCHASING]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+26] = (fgrid_main[iRow, _colACTUAL_ETD]               == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colACTUAL_ETD]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+27] = (fgrid_main[iRow, _colACTUAL_ETA_PORT]          == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colACTUAL_ETA_PORT]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+28] = (fgrid_main[iRow, _colACTUAL_ETA_VJ]            == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colACTUAL_ETA_VJ]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+29] = (fgrid_main[iRow, _colD_HOW_MANY_DAYS]          == null) ? "" : fgrid_main[iRow, _colD_HOW_MANY_DAYS].ToString();
						MyOraDB.Parameter_Values[para_ct+30] = COM.ComVar.This_User;

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


		private bool Validate_Check()
		{


			return true;
		}

		private void cmb_obs_id_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if ((cmb_obsid_fr.SelectedIndex == 0)&&(cmb_obsid_to.SelectedIndex == 0))
					chkNew_Style.Enabled = false;
				else
					chkNew_Style.Enabled = true;

				//setStyleList();
				fgrid_main.ClearAll(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_To_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
		}

		
		private void tab_Main_Click(object sender, System.EventArgs e)
		{
			try
			{
				_Upload_ON_Flag = !_Upload_ON_Flag;

				if(_Upload_ON_Flag)
				{
					pnl_BB2.Size = new Size(1006, 222); 
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


		private void btnSave_Click(object sender, System.EventArgs e)
		{
			DialogResult dr;

			if (Validate_Check_Reason())
			{
				if(ClassLib.ComFunction.User_Message("Do you want to save?","save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
				{
					this.btn_SaveProcess();					
				}
			}
			else
			{
				dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave);
			}		
		}

		private void btn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				_sDPO   = lblobs_id.Text;
				_sStyle = lblStyle_cd.Text;

				SAVE_SBM_TRACKING_REASON("I");
				this.Tbtn_SearchProcess();

				MessageBox.Show("Save Complete","Reason", MessageBoxButtons.OK ,MessageBoxIcon.Information);

				FIND_FOCUS();
				
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

		public void FIND_FOCUS()
		{
			for(int iRow=_Rowfixed; iRow<fgrid_main.Rows.Count; iRow++)
			{
				if ((fgrid_main[iRow, _colOBS_ID].ToString()   == _sDPO  )&&
					(fgrid_main[iRow, _colSTYLE_CD].ToString() == _sStyle) )
					fgrid_main.Select(iRow, _colFACTORY);
			}

			_sDPO   = "";
			_sStyle = "";				
		}

		public void SAVE_SBM_TRACKING_REASON(string arg_division)
		{
				int para_ct = 0; 
				int iCount  = 9;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_LLT_PLAN_TRACKING_VJ.SAVE_PPP_REASON";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 2] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[ 3] = "ARG_VER";
				MyOraDB.Parameter_Name[ 4] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[ 5] = "ARG_AGREE_DATE";
				MyOraDB.Parameter_Name[ 6] = "ARG_THEME";
				MyOraDB.Parameter_Name[ 7] = "ARG_REASON";
				MyOraDB.Parameter_Name[ 8] = "ARG_UPD_USER";


				MyOraDB.Parameter_Type[ 0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[ 1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[ 2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[ 3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[ 4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[ 5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[ 6] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[ 7] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[ 8] = (int)OracleType.VarChar;
				
				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[iCount];

				MyOraDB.Parameter_Values[para_ct+ 0] = arg_division;
				MyOraDB.Parameter_Values[para_ct+ 1] = fgrid_main[_Rowfixed, _colFACTORY].ToString();
				MyOraDB.Parameter_Values[para_ct+ 2] = lblobs_id.Text;
				MyOraDB.Parameter_Values[para_ct+ 3] = "1";
				MyOraDB.Parameter_Values[para_ct+ 4] = lblStyle_cd.Text.ToString().Substring(0, 6) + lblStyle_cd.Text.ToString().Substring(7, 3);
				MyOraDB.Parameter_Values[para_ct+ 5] = this.dpickDate.Text.Replace("-", "");
				MyOraDB.Parameter_Values[para_ct+ 6] = ClassLib.ComFunction.Empty_TextBox(txtTheme, "");
				MyOraDB.Parameter_Values[para_ct+ 7] = ClassLib.ComFunction.Empty_TextBox(textBox1, "");
				MyOraDB.Parameter_Values[para_ct+ 8] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가

			    MyOraDB.Exe_Modify_Procedure();
				
		}


		private bool Validate_Check_Reason()
		{	
			if (txtTheme.Text.Trim().Replace(" ", "").Length < 1)
				return false;
			else if (textBox1.Text.Trim().Replace(" ", "").Length < 1)
				return false;
			else
				return true;
		}

		private void fgrid_main_SelChange(object sender, System.EventArgs e)
		{
			if (!_bDiv) 
				return;

			int isel_row = fgrid_main.Selection.r1;

			if (isel_row < fgrid_main.Rows.Fixed)
				return;

			lblStyle_cd.Text = fgrid_main[isel_row, _colSTYLE_CD].ToString();
			lblobs_id.Text   = fgrid_main[isel_row, _colOBS_ID].ToString();
			lblModel.Text    = fgrid_main[isel_row, _colMODEL_NAME].ToString();

			if (fgrid_main[isel_row, _colREASON_DIV].ToString() == "False")
			{
				dpickDate.Text = DateTime.Now.ToString();
				txtTheme.Text  = "";
				textBox1.Text  = "";				
			}
			else
			{
				dpickDate.Text = fgrid_main[isel_row, _colAGREE_DATE].ToString().Substring(0,4)+"-"+fgrid_main[isel_row, _colAGREE_DATE].ToString().Substring(4,2)+"-"+fgrid_main[isel_row, _colAGREE_DATE].ToString().Substring(6,2);
				txtTheme.Text  = fgrid_main[isel_row, _colTHEME].ToString();
				textBox1.Text  = fgrid_main[isel_row, _colREASON].ToString();			
			}
			
			

			//string sText = fgrid_main[isel_row, _colREASON].ToString();
		}

		private void label4_Click(object sender, System.EventArgs e)
		{
			DialogResult dr;

			if(ClassLib.ComFunction.User_Message("Do you want to delete?","delete", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
			{
					this.btn_DeleteProcess();					
			}			
			else
			{
				dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotDelete);
			}			
		}

		private void btn_DeleteProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				_sDPO   = lblobs_id.Text;
				_sStyle = lblStyle_cd.Text;

				SAVE_SBM_TRACKING_REASON("D");
				this.Tbtn_SearchProcess();

				MessageBox.Show("Delete Complete","Reason", MessageBoxButtons.OK ,MessageBoxIcon.Information);			
	
				FIND_FOCUS();
				
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

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_Print_Click();
		}



		public void Tbtn_Print_Click()
		{
			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BM_Pre_Production_Plan") ;
			string Para         = " ";
		

			int  iCnt  = 13;
			string [] aHead =  new string[iCnt];    
            
			aHead[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");	
			aHead[ 1]   = this.dpick_date_from.Text.Replace("-", "");
			aHead[ 2]   = this.dpick_date_to.Text.Replace("-", "");
			aHead[ 3]   = ClassLib.ComFunction.Empty_Combo(cmb_obsid_fr, "");
			aHead[ 4]   = ClassLib.ComFunction.Empty_Combo(cmb_obsid_to, "");

			if (chkNew_Style.Checked)
				aHead[ 5] = chkNew_Style.Checked.ToString();
			else
				aHead[ 5] = " ";	

			aHead[ 6]   = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "");				
			aHead[ 7]   = ClassLib.ComFunction.Empty_Combo(cmbCategory, "");
			aHead[ 8]   = ClassLib.ComFunction.Empty_Combo(cmbLine, "");
			aHead[ 9]   = ClassLib.ComFunction.Empty_Combo(cmbLoc, "");
			aHead[10]   = ClassLib.ComFunction.Empty_Combo(cmbStatus, "");			

			if (chkLLT_YN.Checked)
				aHead[ 11] = "TRUE";
			else
				aHead[ 11] = " ";	

			aHead[12] = COM.ComVar.This_User;			
						            
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			
			FlexVJ_Common.Report.Form_RdViewer report = new FlexVJ_Common.Report.Form_RdViewer(mrd_Filename, Para);

			
			//FlexTraining.Report.Form_RdViewer report = new FlexTraining.Report.Form_RdViewer(mrd_Filename, Para);

			report.Show();		


		}

		private void Form_BM_MRP_Plan_Tracking_Load(object sender, System.EventArgs e)
		{
		
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
		}

	}
}