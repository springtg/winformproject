using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;

namespace FlexVJ_Common.Purchase
{
	public class Form_BM_Material_Tracking : COM.VJ_CommonWinForm.Form_Top
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
		private System.Windows.Forms.Panel panel3;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.Label lbl_dpo;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.Panel pnl_head;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private C1.Win.C1List.C1Combo cmb_obs_id;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.TextBox txt_itemName;
		private System.Windows.Forms.TextBox txt_itemCode;
		private System.Windows.Forms.Label lbl_itemgroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo cmbItemType;
		private System.Windows.Forms.CheckBox chkNew_Style;
		private System.Windows.Forms.Label lblPur_YN;
		private System.Windows.Forms.Label lblIn_YN;
		private C1.Win.C1List.C1Combo cmbIn_YN;
		private C1.Win.C1List.C1Combo cmbPur_YN;
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		private System.Windows.Forms.Label lbl_vendor;
		private System.Windows.Forms.TextBox txt_vendorCode;
		private C1.Win.C1List.C1Combo cmb_vendor;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 생성자 / 소멸자

		public Form_BM_Material_Tracking()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_BM_Material_Tracking));
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
			this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
			this.cmbPur_YN = new C1.Win.C1List.C1Combo();
			this.cmbIn_YN = new C1.Win.C1List.C1Combo();
			this.lblIn_YN = new System.Windows.Forms.Label();
			this.lblPur_YN = new System.Windows.Forms.Label();
			this.chkNew_Style = new System.Windows.Forms.CheckBox();
			this.cmbItemType = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_itemGroup = new System.Windows.Forms.TextBox();
			this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
			this.txt_itemName = new System.Windows.Forms.TextBox();
			this.txt_itemCode = new System.Windows.Forms.TextBox();
			this.lbl_itemgroup = new System.Windows.Forms.Label();
			this.lbl_item = new System.Windows.Forms.Label();
			this.cmb_obs_id = new C1.Win.C1List.C1Combo();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_dpo = new System.Windows.Forms.Label();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.btn_groupSearch = new System.Windows.Forms.Label();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.lbl_vendor = new System.Windows.Forms.Label();
			this.txt_vendorCode = new System.Windows.Forms.TextBox();
			this.cmb_vendor = new C1.Win.C1List.C1Combo();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_B.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.panel2.SuspendLayout();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbPur_YN)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbIn_YN)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbItemType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_obs_id)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
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
			this.panel3.Location = new System.Drawing.Point(5, 115);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1014, 461);
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
			this.fgrid_main.Size = new System.Drawing.Size(1014, 461);
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
			this.panel2.Size = new System.Drawing.Size(1014, 115);
			this.panel2.TabIndex = 49;
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.lbl_vendor);
			this.pnl_head.Controls.Add(this.txt_vendorCode);
			this.pnl_head.Controls.Add(this.cmb_vendor);
			this.pnl_head.Controls.Add(this.cmb_StyleCd);
			this.pnl_head.Controls.Add(this.cmbPur_YN);
			this.pnl_head.Controls.Add(this.cmbIn_YN);
			this.pnl_head.Controls.Add(this.lblIn_YN);
			this.pnl_head.Controls.Add(this.lblPur_YN);
			this.pnl_head.Controls.Add(this.chkNew_Style);
			this.pnl_head.Controls.Add(this.cmbItemType);
			this.pnl_head.Controls.Add(this.label1);
			this.pnl_head.Controls.Add(this.txt_itemGroup);
			this.pnl_head.Controls.Add(this.cmb_itemGroup);
			this.pnl_head.Controls.Add(this.txt_itemName);
			this.pnl_head.Controls.Add(this.txt_itemCode);
			this.pnl_head.Controls.Add(this.lbl_itemgroup);
			this.pnl_head.Controls.Add(this.lbl_item);
			this.pnl_head.Controls.Add(this.cmb_obs_id);
			this.pnl_head.Controls.Add(this.cmb_Factory);
			this.pnl_head.Controls.Add(this.lbl_dpo);
			this.pnl_head.Controls.Add(this.lbl_Style);
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.lbl_Factory);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Controls.Add(this.pic_head2);
			this.pnl_head.Controls.Add(this.pic_head5);
			this.pnl_head.Controls.Add(this.pic_head6);
			this.pnl_head.Controls.Add(this.pic_head1);
			this.pnl_head.Controls.Add(this.btn_groupSearch);
			this.pnl_head.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_head.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_head.Location = new System.Drawing.Point(0, 0);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(1014, 115);
			this.pnl_head.TabIndex = 3;
			// 
			// cmb_StyleCd
			// 
			this.cmb_StyleCd.AddItemCols = 0;
			this.cmb_StyleCd.AddItemSeparator = ';';
			this.cmb_StyleCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_StyleCd.AutoSize = false;
			this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_StyleCd.Caption = "";
			this.cmb_StyleCd.CaptionHeight = 17;
			this.cmb_StyleCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_StyleCd.ColumnCaptionHeight = 18;
			this.cmb_StyleCd.ColumnFooterHeight = 18;
			this.cmb_StyleCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_StyleCd.ContentHeight = 17;
			this.cmb_StyleCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_StyleCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_StyleCd.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_StyleCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_StyleCd.EditorHeight = 17;
			this.cmb_StyleCd.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_StyleCd.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_StyleCd.GapHeight = 2;
			this.cmb_StyleCd.ItemHeight = 15;
			this.cmb_StyleCd.Location = new System.Drawing.Point(109, 84);
			this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
			this.cmb_StyleCd.MaxLength = 32767;
			this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_StyleCd.Name = "cmb_StyleCd";
			this.cmb_StyleCd.PartialRightColumn = false;
			this.cmb_StyleCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_StyleCd.Size = new System.Drawing.Size(220, 21);
			this.cmb_StyleCd.TabIndex = 582;
			// 
			// cmbPur_YN
			// 
			this.cmbPur_YN.AddItemCols = 0;
			this.cmbPur_YN.AddItemSeparator = ';';
			this.cmbPur_YN.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmbPur_YN.AutoSize = false;
			this.cmbPur_YN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbPur_YN.Caption = "";
			this.cmbPur_YN.CaptionHeight = 17;
			this.cmbPur_YN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbPur_YN.ColumnCaptionHeight = 18;
			this.cmbPur_YN.ColumnFooterHeight = 18;
			this.cmbPur_YN.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbPur_YN.ContentHeight = 17;
			this.cmbPur_YN.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbPur_YN.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbPur_YN.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmbPur_YN.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbPur_YN.EditorHeight = 17;
			this.cmbPur_YN.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmbPur_YN.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbPur_YN.GapHeight = 2;
			this.cmbPur_YN.ItemHeight = 15;
			this.cmbPur_YN.Location = new System.Drawing.Point(781, 40);
			this.cmbPur_YN.MatchEntryTimeout = ((long)(2000));
			this.cmbPur_YN.MaxDropDownItems = ((short)(5));
			this.cmbPur_YN.MaxLength = 32767;
			this.cmbPur_YN.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbPur_YN.Name = "cmbPur_YN";
			this.cmbPur_YN.PartialRightColumn = false;
			this.cmbPur_YN.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmbPur_YN.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbPur_YN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbPur_YN.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbPur_YN.Size = new System.Drawing.Size(220, 21);
			this.cmbPur_YN.TabIndex = 581;
			// 
			// cmbIn_YN
			// 
			this.cmbIn_YN.AddItemCols = 0;
			this.cmbIn_YN.AddItemSeparator = ';';
			this.cmbIn_YN.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmbIn_YN.AutoSize = false;
			this.cmbIn_YN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbIn_YN.Caption = "";
			this.cmbIn_YN.CaptionHeight = 17;
			this.cmbIn_YN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbIn_YN.ColumnCaptionHeight = 18;
			this.cmbIn_YN.ColumnFooterHeight = 18;
			this.cmbIn_YN.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbIn_YN.ContentHeight = 17;
			this.cmbIn_YN.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbIn_YN.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbIn_YN.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmbIn_YN.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbIn_YN.EditorHeight = 17;
			this.cmbIn_YN.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmbIn_YN.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbIn_YN.GapHeight = 2;
			this.cmbIn_YN.ItemHeight = 15;
			this.cmbIn_YN.Location = new System.Drawing.Point(781, 62);
			this.cmbIn_YN.MatchEntryTimeout = ((long)(2000));
			this.cmbIn_YN.MaxDropDownItems = ((short)(5));
			this.cmbIn_YN.MaxLength = 32767;
			this.cmbIn_YN.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbIn_YN.Name = "cmbIn_YN";
			this.cmbIn_YN.PartialRightColumn = false;
			this.cmbIn_YN.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmbIn_YN.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbIn_YN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbIn_YN.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbIn_YN.Size = new System.Drawing.Size(220, 21);
			this.cmbIn_YN.TabIndex = 580;
			// 
			// lblIn_YN
			// 
			this.lblIn_YN.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lblIn_YN.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblIn_YN.ImageIndex = 0;
			this.lblIn_YN.ImageList = this.img_Label;
			this.lblIn_YN.Location = new System.Drawing.Point(680, 62);
			this.lblIn_YN.Name = "lblIn_YN";
			this.lblIn_YN.Size = new System.Drawing.Size(100, 21);
			this.lblIn_YN.TabIndex = 578;
			this.lblIn_YN.Text = "Incoming Y/N";
			this.lblIn_YN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPur_YN
			// 
			this.lblPur_YN.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lblPur_YN.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblPur_YN.ImageIndex = 0;
			this.lblPur_YN.ImageList = this.img_Label;
			this.lblPur_YN.Location = new System.Drawing.Point(680, 40);
			this.lblPur_YN.Name = "lblPur_YN";
			this.lblPur_YN.Size = new System.Drawing.Size(100, 21);
			this.lblPur_YN.TabIndex = 576;
			this.lblPur_YN.Text = "Purchase Y/N";
			this.lblPur_YN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chkNew_Style
			// 
			this.chkNew_Style.Checked = true;
			this.chkNew_Style.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkNew_Style.Enabled = false;
			this.chkNew_Style.Location = new System.Drawing.Point(240, 66);
			this.chkNew_Style.Name = "chkNew_Style";
			this.chkNew_Style.Size = new System.Drawing.Size(87, 16);
			this.chkNew_Style.TabIndex = 575;
			this.chkNew_Style.Text = "New Style";
			// 
			// cmbItemType
			// 
			this.cmbItemType.AddItemCols = 0;
			this.cmbItemType.AddItemSeparator = ';';
			this.cmbItemType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmbItemType.AutoSize = false;
			this.cmbItemType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbItemType.Caption = "";
			this.cmbItemType.CaptionHeight = 17;
			this.cmbItemType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbItemType.ColumnCaptionHeight = 18;
			this.cmbItemType.ColumnFooterHeight = 18;
			this.cmbItemType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbItemType.ContentHeight = 17;
			this.cmbItemType.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbItemType.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbItemType.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmbItemType.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbItemType.EditorHeight = 17;
			this.cmbItemType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmbItemType.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbItemType.GapHeight = 2;
			this.cmbItemType.ItemHeight = 15;
			this.cmbItemType.Location = new System.Drawing.Point(445, 62);
			this.cmbItemType.MatchEntryTimeout = ((long)(2000));
			this.cmbItemType.MaxDropDownItems = ((short)(5));
			this.cmbItemType.MaxLength = 32767;
			this.cmbItemType.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbItemType.Name = "cmbItemType";
			this.cmbItemType.PartialRightColumn = false;
			this.cmbItemType.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmbItemType.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbItemType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbItemType.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbItemType.Size = new System.Drawing.Size(220, 21);
			this.cmbItemType.TabIndex = 574;
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
			this.label1.TabIndex = 573;
			this.label1.Text = "Semi Good";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_itemGroup
			// 
			this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_itemGroup.Font = new System.Drawing.Font("Gulim", 9F);
			this.txt_itemGroup.Location = new System.Drawing.Point(536, 40);
			this.txt_itemGroup.MaxLength = 10;
			this.txt_itemGroup.Name = "txt_itemGroup";
			this.txt_itemGroup.ReadOnly = true;
			this.txt_itemGroup.Size = new System.Drawing.Size(128, 21);
			this.txt_itemGroup.TabIndex = 571;
			this.txt_itemGroup.Text = "";
			this.txt_itemGroup.TextChanged += new System.EventHandler(this.txt_itemGroup_TextChanged);
			// 
			// cmb_itemGroup
			// 
			this.cmb_itemGroup.AddItemCols = 0;
			this.cmb_itemGroup.AddItemSeparator = ';';
			this.cmb_itemGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_itemGroup.AutoSize = false;
			this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_itemGroup.Caption = "";
			this.cmb_itemGroup.CaptionHeight = 17;
			this.cmb_itemGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_itemGroup.ColumnCaptionHeight = 18;
			this.cmb_itemGroup.ColumnFooterHeight = 18;
			this.cmb_itemGroup.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_itemGroup.ContentHeight = 17;
			this.cmb_itemGroup.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_itemGroup.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_itemGroup.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_itemGroup.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_itemGroup.EditorHeight = 17;
			this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_itemGroup.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_itemGroup.GapHeight = 2;
			this.cmb_itemGroup.ItemHeight = 15;
			this.cmb_itemGroup.Location = new System.Drawing.Point(445, 40);
			this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
			this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
			this.cmb_itemGroup.MaxLength = 32767;
			this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_itemGroup.Name = "cmb_itemGroup";
			this.cmb_itemGroup.PartialRightColumn = false;
			this.cmb_itemGroup.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_itemGroup.Size = new System.Drawing.Size(90, 21);
			this.cmb_itemGroup.TabIndex = 570;
			this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
			// 
			// txt_itemName
			// 
			this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_itemName.Font = new System.Drawing.Font("Gulim", 9F);
			this.txt_itemName.Location = new System.Drawing.Point(505, 84);
			this.txt_itemName.MaxLength = 100;
			this.txt_itemName.Name = "txt_itemName";
			this.txt_itemName.Size = new System.Drawing.Size(159, 21);
			this.txt_itemName.TabIndex = 572;
			this.txt_itemName.Text = "";
			// 
			// txt_itemCode
			// 
			this.txt_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_itemCode.Font = new System.Drawing.Font("Gulim", 9F);
			this.txt_itemCode.Location = new System.Drawing.Point(445, 84);
			this.txt_itemCode.MaxLength = 10;
			this.txt_itemCode.Name = "txt_itemCode";
			this.txt_itemCode.Size = new System.Drawing.Size(59, 21);
			this.txt_itemCode.TabIndex = 568;
			this.txt_itemCode.Text = "";
			// 
			// lbl_itemgroup
			// 
			this.lbl_itemgroup.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_itemgroup.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_itemgroup.ImageIndex = 0;
			this.lbl_itemgroup.ImageList = this.img_Label;
			this.lbl_itemgroup.Location = new System.Drawing.Point(344, 40);
			this.lbl_itemgroup.Name = "lbl_itemgroup";
			this.lbl_itemgroup.Size = new System.Drawing.Size(100, 21);
			this.lbl_itemgroup.TabIndex = 566;
			this.lbl_itemgroup.Text = "Item Group";
			this.lbl_itemgroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_item
			// 
			this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_item.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_item.ImageIndex = 0;
			this.lbl_item.ImageList = this.img_Label;
			this.lbl_item.Location = new System.Drawing.Point(344, 84);
			this.lbl_item.Name = "lbl_item";
			this.lbl_item.Size = new System.Drawing.Size(100, 21);
			this.lbl_item.TabIndex = 567;
			this.lbl_item.Text = "Item";
			this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_obs_id
			// 
			this.cmb_obs_id.AddItemCols = 0;
			this.cmb_obs_id.AddItemSeparator = ';';
			this.cmb_obs_id.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_obs_id.AutoSize = false;
			this.cmb_obs_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_obs_id.Caption = "";
			this.cmb_obs_id.CaptionHeight = 17;
			this.cmb_obs_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_obs_id.ColumnCaptionHeight = 18;
			this.cmb_obs_id.ColumnFooterHeight = 18;
			this.cmb_obs_id.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_obs_id.ContentHeight = 17;
			this.cmb_obs_id.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_obs_id.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_obs_id.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_obs_id.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_obs_id.EditorHeight = 17;
			this.cmb_obs_id.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_obs_id.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_obs_id.GapHeight = 2;
			this.cmb_obs_id.ItemHeight = 15;
			this.cmb_obs_id.Location = new System.Drawing.Point(109, 62);
			this.cmb_obs_id.MatchEntryTimeout = ((long)(2000));
			this.cmb_obs_id.MaxDropDownItems = ((short)(5));
			this.cmb_obs_id.MaxLength = 32767;
			this.cmb_obs_id.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_obs_id.Name = "cmb_obs_id";
			this.cmb_obs_id.PartialRightColumn = false;
			this.cmb_obs_id.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_obs_id.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_obs_id.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_obs_id.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_obs_id.Size = new System.Drawing.Size(123, 21);
			this.cmb_obs_id.TabIndex = 564;
			this.cmb_obs_id.SelectedValueChanged += new System.EventHandler(this.cmb_obs_id_SelectedValueChanged);
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
			this.cmb_Factory.Size = new System.Drawing.Size(220, 21);
			this.cmb_Factory.TabIndex = 563;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_dpo
			// 
			this.lbl_dpo.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_dpo.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_dpo.ImageIndex = 0;
			this.lbl_dpo.ImageList = this.img_Label;
			this.lbl_dpo.Location = new System.Drawing.Point(8, 62);
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
			this.lbl_Style.Location = new System.Drawing.Point(8, 84);
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
			this.pic_head3.Location = new System.Drawing.Point(998, 99);
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
			this.pic_head4.Location = new System.Drawing.Point(136, 98);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(974, 18);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
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
			this.pic_head7.Size = new System.Drawing.Size(101, 74);
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
			this.pic_head5.Location = new System.Drawing.Point(0, 99);
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
			this.pic_head6.Size = new System.Drawing.Size(168, 97);
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
			// btn_groupSearch
			// 
			this.btn_groupSearch.Location = new System.Drawing.Point(0, 0);
			this.btn_groupSearch.Name = "btn_groupSearch";
			this.btn_groupSearch.TabIndex = 583;
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
			// lbl_vendor
			// 
			this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_vendor.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_vendor.ImageIndex = 0;
			this.lbl_vendor.ImageList = this.img_Label;
			this.lbl_vendor.Location = new System.Drawing.Point(680, 84);
			this.lbl_vendor.Name = "lbl_vendor";
			this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
			this.lbl_vendor.TabIndex = 586;
			this.lbl_vendor.Text = "Vendor";
			this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_vendorCode
			// 
			this.txt_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_vendorCode.Font = new System.Drawing.Font("Gulim", 9F);
			this.txt_vendorCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_vendorCode.Location = new System.Drawing.Point(781, 84);
			this.txt_vendorCode.MaxLength = 10;
			this.txt_vendorCode.Name = "txt_vendorCode";
			this.txt_vendorCode.Size = new System.Drawing.Size(79, 21);
			this.txt_vendorCode.TabIndex = 584;
			this.txt_vendorCode.Text = "";
			this.txt_vendorCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vendorCode_KeyPress);
			// 
			// cmb_vendor
			// 
			this.cmb_vendor.AddItemCols = 0;
			this.cmb_vendor.AddItemSeparator = ';';
			this.cmb_vendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_vendor.AutoSize = false;
			this.cmb_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_vendor.Caption = "";
			this.cmb_vendor.CaptionHeight = 17;
			this.cmb_vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_vendor.ColumnCaptionHeight = 18;
			this.cmb_vendor.ColumnFooterHeight = 18;
			this.cmb_vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_vendor.ContentHeight = 17;
			this.cmb_vendor.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
			this.cmb_vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_vendor.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_vendor.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_vendor.EditorHeight = 17;
			this.cmb_vendor.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_vendor.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_vendor.GapHeight = 2;
			this.cmb_vendor.ItemHeight = 15;
			this.cmb_vendor.Location = new System.Drawing.Point(861, 84);
			this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
			this.cmb_vendor.MaxDropDownItems = ((short)(5));
			this.cmb_vendor.MaxLength = 32767;
			this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_vendor.Name = "cmb_vendor";
			this.cmb_vendor.PartialRightColumn = false;
			this.cmb_vendor.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_vendor.Size = new System.Drawing.Size(140, 21);
			this.cmb_vendor.TabIndex = 585;
			this.cmb_vendor.SelectedValueChanged += new System.EventHandler(this.cmb_vendor_SelectedValueChanged);
			// 
			// Form_BM_Material_Tracking
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_B);
			this.Name = "Form_BM_Material_Tracking";
			this.Text = "Material Resource Monitoring";
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_B, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_B.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.panel2.ResumeLayout(false);
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbPur_YN)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbIn_YN)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbItemType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_obs_id)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 전역변수
 
		private COM.OraDB MyOraDB = new COM.OraDB(); 				
		private int _Rowfixed;
		private bool _isAccessible	= false;

		private string _itemGroupCode = " ";

		//private bool _flag = true;

		// search option value
		//private const string PKG = "PKG_SBM_MRP_MONITORING_LOCAL";		
		private Hashtable _columns = new Hashtable();


		private int _colLEVEL 			     = (int)ClassLib.TSBM_MATERIAL_TRACKING.IxLEVEL;
		private int _colITEM_NAME		     = (int)ClassLib.TSBM_MATERIAL_TRACKING.IxITEM_NAME;
		private int _colPLAN_YMD		     = (int)ClassLib.TSBM_MATERIAL_TRACKING.IxPLAN_YMD;

		private int _colFACTORY		         = (int)ClassLib.TSBM_MATERIAL_TRACKING.IxFACTORY;
		private int _colPUR_NO		         = (int)ClassLib.TSBM_MATERIAL_TRACKING.IxPUR_NO;
		private int _colSTYLE_CD             = (int)ClassLib.TSBM_MATERIAL_TRACKING.IxSTYLE_CD;

		private int _colITEM_CD		         = (int)ClassLib.TSBM_MATERIAL_TRACKING.IxITEM_CD;
		private int _colSPEC_CD		         = (int)ClassLib.TSBM_MATERIAL_TRACKING.IxSPEC_CD;
		private int _colCOLOR_CD		     = (int)ClassLib.TSBM_MATERIAL_TRACKING.IxCOLOR_CD;
		private int _colETD		             = (int)ClassLib.TSBM_MATERIAL_TRACKING.IxETD;
		private int _colETA		             = (int)ClassLib.TSBM_MATERIAL_TRACKING.IxETA;
		private int _colSWATCH               = (int)ClassLib.TSBM_MATERIAL_TRACKING.IxSWATCH;
												   
		
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
			int vRow = fgrid_main.Row; 

			COM.ComVar.Parameter_PopUp		= new string[9];
			COM.ComVar.Parameter_PopUp[0]	= cmb_Factory.SelectedValue.ToString();
			COM.ComVar.Parameter_PopUp[1]	= fgrid_main[vRow,  19].ToString();
			COM.ComVar.Parameter_PopUp[2]	= fgrid_main[vRow,  20].ToString();
			COM.ComVar.Parameter_PopUp[3]	= fgrid_main[vRow,  15].ToString();
			COM.ComVar.Parameter_PopUp[4]	= fgrid_main[vRow,  16].ToString();
			COM.ComVar.Parameter_PopUp[5]	= fgrid_main[vRow,  17].ToString(); 
			COM.ComVar.Parameter_PopUp[6]	= fgrid_main[vRow,   2].ToString();
			COM.ComVar.Parameter_PopUp[7]	= fgrid_main[vRow,   3].ToString();
			COM.ComVar.Parameter_PopUp[8]	= fgrid_main[vRow,   4].ToString();

			Pop_BM_InOut_Infomation  pop_bp_purchase     = new Pop_BM_InOut_Infomation();
			 
			pop_bp_purchase.ShowDialog();
			pop_bp_purchase.Dispose();

		}



		#endregion 
		
		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form set
			this.Text = "Material Resource Monitoring";
			lbl_MainTitle.Text = "Material Resource Monitoring";
			
			// grid set
			fgrid_main.Set_Grid("SBM_MRP_LLT_PLAN_TRACKING", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);			
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

			// Item Type
			dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBC04");
			COM.ComCtl.Set_ComboList(dt_ret, cmbItemType, 1, 2, true, 80, 140);
			cmbItemType.SelectedIndex = 1;

			// group type
			dt_ret = ClassLib.ComFunction.Select_GroupTypeCode();  
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_itemGroup, 0, 1, false,  0, 130);  

			// Pur Y/N
			dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBC00");
			COM.ComCtl.Set_ComboList(dt_ret, cmbPur_YN, 1, 2, true, 80, 140);
			cmbPur_YN.SelectedIndex = 0;

			// In Y/N
			dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBC00");
			COM.ComCtl.Set_ComboList(dt_ret, cmbIn_YN, 1, 2, true, 80, 140);
			cmbIn_YN.SelectedIndex = 0;

			
			// toolbar button disable setting
			tbtn_Delete.Enabled = false;
			tbtn_Confirm.Enabled = false; 						



			dt_ret = this.SELECT_SG_LIST(ClassLib.ComVar.This_Factory);
			if (dt_ret.Rows.Count > 0)
			{
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmbItemType, 0, 1, true, false);
			}
			dt_ret.Dispose();

			cmbItemType.SelectedIndex = 10;
			         

			fgrid_main.Cols[_colSWATCH].Style.Format = "yyyy-MM-dd";
			fgrid_main.Cols[_colETA].Style.Format    = "yyyy-MM-dd";
			fgrid_main.Cols[_colETD].Style.Format    = "yyyy-MM-dd";
						
			fgrid_main.Font = new Font("Verdana", 7);


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

		private void setDPO()
		{			
			DataTable dt_ret = ClassLib.ComVar.Select_DP_DPO_List(cmb_Factory.SelectedValue.ToString(), "2" );
			COM.ComCtl.Set_ComboList(dt_ret, cmb_obs_id, 0, 0, true, ClassLib.ComVar.ComboList_Visible.Name); 
			cmb_obs_id.SelectedIndex = 0;
		}

		private void setStyleList()
		{
			if (cmb_obs_id.SelectedIndex == -1)
				return;

			string[] args = new string[5];
			
			args[0] = COM.ComFunction.Empty_Combo(cmb_Factory, "");
			args[1] = COM.ComFunction.Empty_Combo(cmb_obs_id, "");
			args[2] = COM.ComFunction.Empty_Combo(cmb_obs_id, "");
			args[3] = "2";

			DataTable dt_ret = this.SELECT_STYLE_LIST_DPDPO(args);
			if (dt_ret.Rows.Count > 0)
			{
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_StyleCd, 0, 1, true, 80, 130);
				cmb_StyleCd.SelectedIndex = 0;

			}
			dt_ret.Dispose();
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
                
				string vProcedure     = "PKG_SBM_LLT_PLAN_TRACKING_M.SELECT_MATERIAL_TRACKING";

				DataTable vDt = SELECT_MATERIAL_TRACKING(vProcedure);

				Clear_FlexGrid();

				if (vDt.Rows.Count > 0)
				{
					fgrid_main.Tree.Column = _colLEVEL; 

					Display_FlexGrid(vDt);

					Grid_SetColor();
					
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

		public DataTable SELECT_MATERIAL_TRACKING(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(12);

			//01.PROCEDURE명
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[ 2]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[ 3]  = "ARG_GROUP_CD";
			MyOraDB.Parameter_Name[ 4]  = "ARG_ITEM_TYPE";
			MyOraDB.Parameter_Name[ 5]  = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[ 6]  = "ARG_ITEM_NM";
			MyOraDB.Parameter_Name[ 7]  = "ARG_NEW_STYLE";
			MyOraDB.Parameter_Name[ 8]  = "ARG_PUR_YN";
			MyOraDB.Parameter_Name[ 9]  = "ARG_IN_YN";
			MyOraDB.Parameter_Name[10]  = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[11]  = "OUT_CURSOR";

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
			MyOraDB.Parameter_Type[11]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");			
			MyOraDB.Parameter_Values[ 1]   = ClassLib.ComFunction.Empty_Combo(cmb_obs_id, "");
			MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_Combo(cmb_StyleCd, "").Replace("-", "");				
			MyOraDB.Parameter_Values[ 3]   = _itemGroupCode.Replace("00", " "); 
			MyOraDB.Parameter_Values[ 4]   = ClassLib.ComFunction.Empty_Combo(cmbItemType, "");
			MyOraDB.Parameter_Values[ 5]   = txt_itemCode.Text;
			MyOraDB.Parameter_Values[ 6]   = txt_itemName.Text;

			if (chkNew_Style.Checked)
				MyOraDB.Parameter_Values[ 7] = chkNew_Style.Checked.ToString();
			else
				MyOraDB.Parameter_Values[ 7] = "";	

			MyOraDB.Parameter_Values[ 8]   = ClassLib.ComFunction.Empty_Combo(cmbPur_YN, "");
			MyOraDB.Parameter_Values[ 9]   = ClassLib.ComFunction.Empty_Combo(cmbIn_YN,  "");

			MyOraDB.Parameter_Values[10]   = this.cmb_vendor.SelectedIndex  > -1 ? this.cmb_vendor.SelectedValue.ToString()  : "";
 
			MyOraDB.Parameter_Values[11]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null;

			return vDt.Tables[MyOraDB.Process_Name];
		}


		private void Display_FlexGrid(DataTable arg_dt)
		{
			int iCount = arg_dt.Rows.Count;
			int iLevel = 0; 

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{				
				iLevel = Convert.ToInt32(arg_dt.Rows[iRow].ItemArray[0].ToString() );
				C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(_Rowfixed + iRow, iLevel);


				fgrid_main[newRow.Row.Index, 0] = "";

				for (int iCol = 1 ; iCol <= arg_dt.Columns.Count ; iCol++)
				{
					fgrid_main[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
				}

				//fgrid_main.Tree.Column = _colPLAN_YMD;

			}

		}

		private void Clear_FlexGrid()
		{
			if (fgrid_main.Rows.Fixed != fgrid_main.Rows.Count)
			{				
				fgrid_main.Clear(ClearFlags.UserData, fgrid_main.Rows.Fixed, 1, fgrid_main.Rows.Count - 1, fgrid_main.Cols.Count - 1);

				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

					
			}
		}


		// grid color set
		private void Grid_SetColor()
		{
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{

				fgrid_main.Cols[_colSWATCH].StyleNew.BackColor = Color.LightYellow;
				fgrid_main.Cols[_colETA].StyleNew.BackColor    = Color.LightYellow;
				fgrid_main.Cols[_colETD].StyleNew.BackColor    = Color.LightYellow;

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


		private DataTable SELECT_SG_LIST(string arg_parameter)
		{
			try 
			{
				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(2); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_LLT_PLAN_TRACKING_M.SELECT_SG_LIST"; 

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR"; 
      
				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter;
				MyOraDB.Parameter_Values[1] = ""; 

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

				if (SAVE_SBM_MORNITORING(true))
				{
					fgrid_main.Refresh_Division();
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


		public bool SAVE_SBM_MORNITORING(bool doExecute)
		{
			try
			{
				int save_ct =  0;   
				int para_ct =  0; 
				int iCount  = 10;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_LLT_PLAN_TRACKING_M.SAVE_MATERIAL_TRACKING";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 2] = "ARG_PUR_NO";
				MyOraDB.Parameter_Name[ 3] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[ 4] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[ 5] = "ARG_SPEC_CD";
				MyOraDB.Parameter_Name[ 6] = "ARG_COLOR_CD";
				MyOraDB.Parameter_Name[ 7] = "ARG_ETD";
				MyOraDB.Parameter_Name[ 8] = "ARG_ETA";
				MyOraDB.Parameter_Name[ 9] = "ARG_UPD_USER";


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
						MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main[iRow, 0].ToString();
						MyOraDB.Parameter_Values[para_ct+ 1] = fgrid_main[iRow, _colFACTORY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 2] = fgrid_main[iRow, _colPUR_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+ 3] = fgrid_main[iRow, _colSTYLE_CD].ToString().Replace("-", "");
						MyOraDB.Parameter_Values[para_ct+ 4] = fgrid_main[iRow, _colITEM_CD].ToString();
						MyOraDB.Parameter_Values[para_ct+ 5] = fgrid_main[iRow, _colSPEC_CD].ToString();
						MyOraDB.Parameter_Values[para_ct+ 6] = fgrid_main[iRow, _colCOLOR_CD].ToString();
						MyOraDB.Parameter_Values[para_ct+ 7] = (fgrid_main[iRow, _colETD] == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colETD]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+ 8] = (fgrid_main[iRow, _colETA] == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colETA]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+ 9] = COM.ComVar.This_User;

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
				fgrid_main.ClearAll(); 

				setStyleList();

				if (cmb_obs_id.SelectedIndex == 0)
					chkNew_Style.Enabled = false;
				else
				{
					chkNew_Style.Enabled = true;
					chkNew_Style.Checked = true;
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_To_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		
		private void tab_Main_Click(object sender, System.EventArgs e)
		{
		}


		private void btnSave_Click(object sender, System.EventArgs e)
		{
			DialogResult dr;

			if(ClassLib.ComFunction.User_Message("Do you want to save?","save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
			{
				this.btn_SaveProcess();					
			}
					
		}

		private void btn_SaveProcess()
		{
			try
			{
//				this.Cursor = Cursors.WaitCursor;
//
//				_sDPO   = lblobs_id.Text;
//				_sStyle = lblStyle_cd.Text;
//
//				SAVE_SBM_TRACKING_REASON("I");
//				this.Tbtn_SearchProcess();
//
//				MessageBox.Show("Save Complete","Reason", MessageBoxButtons.OK ,MessageBoxIcon.Information);
//
//				FIND_FOCUS();
//				
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





		private void fgrid_main_SelChange(object sender, System.EventArgs e)
		{

		}

		private void label4_Click(object sender, System.EventArgs e)
		{
	
		}

		private void btn_DeleteProcess()
		{

		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_Print_Click();
		}



		public void Tbtn_Print_Click()
		{
			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_Material_Resource_Mon") ;
			string Para         = " ";
		
			int  iCnt  = 11;
			string [] aHead =  new string[iCnt];    
            
			aHead[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");	
			aHead[ 1]   = ClassLib.ComFunction.Empty_Combo(cmb_obs_id, "");
			aHead[ 2]   = ClassLib.ComFunction.Empty_Combo(cmb_StyleCd, "").Replace("-", "");	
			aHead[ 3]   = _itemGroupCode.Replace("00", " "); 
			aHead[ 4]   = ClassLib.ComFunction.Empty_Combo(cmbItemType, "");
			aHead[ 5]   = txt_itemCode.Text;
			aHead[ 6]   = txt_itemName.Text;

			if (chkNew_Style.Checked)
				aHead[ 7] = chkNew_Style.Checked.ToString();
			else
				aHead[ 7] = "";	

			aHead[ 8]   = ClassLib.ComFunction.Empty_Combo(cmbPur_YN, "");
			aHead[ 9]   = ClassLib.ComFunction.Empty_Combo(cmbIn_YN,  "");

			aHead[10]   = this.cmb_vendor.SelectedIndex  > -1 ? this.cmb_vendor.SelectedValue.ToString()  : "";
						            
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			
			FlexVJ_Common.Report.Form_RdViewer report = new FlexVJ_Common.Report.Form_RdViewer (mrd_Filename, Para);
			report.Show();				


		}

		private void cmb_itemGroup_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try 
			{
				if ( cmb_itemGroup.SelectedIndex != -1 )
				{
					btn_groupSearch.Enabled = true;
					txt_itemGroup.Text = "";
					_itemGroupCode = cmb_itemGroup.SelectedValue.ToString();
				}
				else
				{
					btn_groupSearch.Enabled = false;
					txt_itemGroup.Text = "";
					_itemGroupCode = " ";
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_itemGroup_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txt_itemGroup_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void txt_vendorCode_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			try
			{
				if ((int)e.KeyChar != 13) return;

				cmb_vendor.SelectedIndex = -1;

				Txt_VendorCodeTextChangedProcess();		
				ClassLib.ComFunction.Control_MoveNextByFocus(sender, e.KeyChar);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_styleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmb_vendor_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_vendor.SelectedIndex == -1) return;

				Cmb_VendorSelectedValueChangedProcess();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_vendor_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
		}

		private void Txt_VendorCodeTextChangedProcess()
		{
			try
			{
				_isAccessible = false;
				DataTable vDt = new DataTable();
				vDt = ClassLib.ComFunction.SELECT_SCM_CUST_LIST(COM.ComVar.This_Factory, txt_vendorCode.Text.Trim());
				COM.ComCtl.Set_ComboList(vDt, cmb_vendor, 0, 1, true, 79, 141);

				if (vDt.Rows.Count > 0 && vDt.Rows.Count < 2)
					cmb_vendor.SelectedIndex = 1; 
				else if (vDt == null || vDt.Rows.Count <= 0) 
					cmb_vendor.SelectedIndex = 0; 
					
				vDt.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				_isAccessible = true;
			}
		}

		private void Cmb_VendorSelectedValueChangedProcess()
		{
			try
			{
				if (_isAccessible)
				{
					txt_vendorCode.Text		 = cmb_vendor.SelectedValue.ToString();
					cmb_vendor.SelectedValue = txt_vendorCode.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}



	}
}
