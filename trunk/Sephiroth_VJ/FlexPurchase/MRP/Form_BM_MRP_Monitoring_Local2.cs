using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;

namespace FlexMRP.MRP
{
	public class Form_BM_MRP_Monitoring_Local2 : COM.PCHWinForm.Form_Top
	{

		#region 디자이너에서 생성한 멤버

		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.TextBox txt_vendorCode;
		private System.Windows.Forms.Label lbl_vendor;
		private System.Windows.Forms.Label lbl_reqUser;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private System.Windows.Forms.TextBox txt_itemName;
		private System.Windows.Forms.TextBox txt_itemCode;
		private System.Windows.Forms.Label lbl_itemgroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.Label lbl_item;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private C1.Win.C1List.C1Combo cmb_purUser;
		private C1.Win.C1List.C1Combo cmb_To;
		private C1.Win.C1List.C1Combo cmb_From;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private C1.Win.C1List.C1Combo cmb_vendor;
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_searchType;
		private System.Windows.Forms.Label lbl_dpo;
		private C1.Win.C1List.C1Combo cmb_shipType;
		private System.Windows.Forms.Label lbl_shipType;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.ContextMenu ctx_main;
		private System.Windows.Forms.MenuItem mnu_allSel;
		private System.Windows.Forms.MenuItem mnu_allDesel;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnu_tree;
		private System.Windows.Forms.MenuItem mnu_style;
		private System.Windows.Forms.MenuItem mnu_item;
		private System.Windows.Forms.TextBox txt_SearchRate;
		private System.Windows.Forms.MenuItem mnu_Purchase;
		private System.Windows.Forms.Label btn_Usage;
		private System.Windows.Forms.MenuItem mnu_PurchaseSearch;
		private System.Windows.Forms.MenuItem mnu_Rate;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 생성자 / 소멸자

		public Form_BM_MRP_Monitoring_Local2()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BM_MRP_Monitoring_Local2));
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
            C1.Win.C1List.Style style33 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style34 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style35 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style36 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style37 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style38 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style39 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style40 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style41 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style42 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style43 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style44 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style45 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style46 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style47 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style48 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style49 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style50 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style51 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style52 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style53 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style54 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style55 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style56 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style57 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style58 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style59 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style60 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style61 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style62 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style63 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style64 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_main = new COM.FSP();
            this.ctx_main = new System.Windows.Forms.ContextMenu();
            this.mnu_allSel = new System.Windows.Forms.MenuItem();
            this.mnu_allDesel = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnu_tree = new System.Windows.Forms.MenuItem();
            this.mnu_style = new System.Windows.Forms.MenuItem();
            this.mnu_item = new System.Windows.Forms.MenuItem();
            this.mnu_Purchase = new System.Windows.Forms.MenuItem();
            this.mnu_PurchaseSearch = new System.Windows.Forms.MenuItem();
            this.mnu_Rate = new System.Windows.Forms.MenuItem();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.btn_Usage = new System.Windows.Forms.Label();
            this.txt_SearchRate = new System.Windows.Forms.TextBox();
            this.lbl_searchType = new System.Windows.Forms.Label();
            this.txt_itemGroup = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.lbl_itemgroup = new System.Windows.Forms.Label();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.cmb_purUser = new C1.Win.C1List.C1Combo();
            this.lbl_reqUser = new System.Windows.Forms.Label();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
            this.cmb_To = new C1.Win.C1List.C1Combo();
            this.cmb_From = new C1.Win.C1List.C1Combo();
            this.lbl_dpo = new System.Windows.Forms.Label();
            this.cmb_shipType = new C1.Win.C1List.C1Combo();
            this.lbl_shipType = new System.Windows.Forms.Label();
            this.lblexcep_mark = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_To)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_From)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
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
            // tbtn_Print
            // 
            this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
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
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = "24.4791666666667:False:True;73.4375:False:False;0.694444444444444:False:True;\t0.3" +
                "93700787401575:False:True;98.4251968503937:False:False;0.393700787401575:False:T" +
                "rue;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ContextMenu = this.ctx_main;
            this.fgrid_main.Location = new System.Drawing.Point(8, 145);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Rows.DefaultSize = 19;
            this.fgrid_main.Size = new System.Drawing.Size(1000, 423);
            this.fgrid_main.StyleInfo = resources.GetString("fgrid_main.StyleInfo");
            this.fgrid_main.TabIndex = 176;
            this.fgrid_main.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fgrid_main_KeyDown);
            this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
            this.fgrid_main.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fgrid_main_KeyUp);
            // 
            // ctx_main
            // 
            this.ctx_main.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_allSel,
            this.mnu_allDesel,
            this.menuItem1,
            this.mnu_tree,
            this.mnu_Purchase,
            this.mnu_PurchaseSearch,
            this.mnu_Rate});
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
            this.mnu_Purchase.Click += new System.EventHandler(this.mnu_Purchase_Click);
            // 
            // mnu_PurchaseSearch
            // 
            this.mnu_PurchaseSearch.Index = 5;
            this.mnu_PurchaseSearch.Text = "Purchase Search";
            this.mnu_PurchaseSearch.Click += new System.EventHandler(this.mnu_PurchaseSearch_Click);
            // 
            // mnu_Rate
            // 
            this.mnu_Rate.Index = 6;
            this.mnu_Rate.Text = "Deduction Rate";
            this.mnu_Rate.Click += new System.EventHandler(this.mnu_Rate_Click);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.btn_Usage);
            this.pnl_head.Controls.Add(this.txt_SearchRate);
            this.pnl_head.Controls.Add(this.lbl_searchType);
            this.pnl_head.Controls.Add(this.txt_itemGroup);
            this.pnl_head.Controls.Add(this.cmb_itemGroup);
            this.pnl_head.Controls.Add(this.txt_itemName);
            this.pnl_head.Controls.Add(this.txt_itemCode);
            this.pnl_head.Controls.Add(this.lbl_itemgroup);
            this.pnl_head.Controls.Add(this.btn_groupSearch);
            this.pnl_head.Controls.Add(this.lbl_item);
            this.pnl_head.Controls.Add(this.cmb_purUser);
            this.pnl_head.Controls.Add(this.lbl_reqUser);
            this.pnl_head.Controls.Add(this.txt_vendorCode);
            this.pnl_head.Controls.Add(this.cmb_vendor);
            this.pnl_head.Controls.Add(this.lbl_vendor);
            this.pnl_head.Controls.Add(this.cmb_StyleCd);
            this.pnl_head.Controls.Add(this.cmb_To);
            this.pnl_head.Controls.Add(this.cmb_From);
            this.pnl_head.Controls.Add(this.lbl_dpo);
            this.pnl_head.Controls.Add(this.cmb_shipType);
            this.pnl_head.Controls.Add(this.lbl_shipType);
            this.pnl_head.Controls.Add(this.lblexcep_mark);
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
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 141);
            this.pnl_head.TabIndex = 2;
            // 
            // btn_Usage
            // 
            this.btn_Usage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Usage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Usage.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Usage.ImageIndex = 0;
            this.btn_Usage.ImageList = this.img_Button;
            this.btn_Usage.Location = new System.Drawing.Point(911, 111);
            this.btn_Usage.Name = "btn_Usage";
            this.btn_Usage.Size = new System.Drawing.Size(80, 23);
            this.btn_Usage.TabIndex = 549;
            this.btn_Usage.Text = "DPO Usage";
            this.btn_Usage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Usage.Click += new System.EventHandler(this.btn_Usage_Click);
            this.btn_Usage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Usage_MouseDown);
            this.btn_Usage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Usage_MouseUp);
            // 
            // txt_SearchRate
            // 
            this.txt_SearchRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SearchRate.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_SearchRate.Location = new System.Drawing.Point(781, 84);
            this.txt_SearchRate.MaxLength = 10;
            this.txt_SearchRate.Name = "txt_SearchRate";
            this.txt_SearchRate.Size = new System.Drawing.Size(210, 21);
            this.txt_SearchRate.TabIndex = 548;
          
            // 
            // lbl_searchType
            // 
            this.lbl_searchType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_searchType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_searchType.ImageIndex = 0;
            this.lbl_searchType.ImageList = this.img_Label;
            this.lbl_searchType.Location = new System.Drawing.Point(680, 84);
            this.lbl_searchType.Name = "lbl_searchType";
            this.lbl_searchType.Size = new System.Drawing.Size(100, 21);
            this.lbl_searchType.TabIndex = 417;
            this.lbl_searchType.Text = "Search Rate";
            this.lbl_searchType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            // 
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.Location = new System.Drawing.Point(872, 40);
            this.txt_itemGroup.MaxLength = 10;
            this.txt_itemGroup.Name = "txt_itemGroup";
            this.txt_itemGroup.ReadOnly = true;
            this.txt_itemGroup.Size = new System.Drawing.Size(96, 21);
            this.txt_itemGroup.TabIndex = 547;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style1;
            this.cmb_itemGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_itemGroup.ColumnCaptionHeight = 18;
            this.cmb_itemGroup.ColumnFooterHeight = 18;
            this.cmb_itemGroup.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_itemGroup.ContentHeight = 16;
            this.cmb_itemGroup.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_itemGroup.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_itemGroup.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_itemGroup.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_itemGroup.EditorHeight = 16;
            this.cmb_itemGroup.EvenRowStyle = style2;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style3;
            this.cmb_itemGroup.HeadingStyle = style4;
            this.cmb_itemGroup.HighLightRowStyle = style5;
            this.cmb_itemGroup.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_itemGroup.Images"))));
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(781, 40);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style6;
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style7;
            this.cmb_itemGroup.Size = new System.Drawing.Size(90, 20);
            this.cmb_itemGroup.Style = style8;
            this.cmb_itemGroup.TabIndex = 546;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            // 
            // txt_itemName
            // 
            this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemName.Location = new System.Drawing.Point(841, 62);
            this.txt_itemName.MaxLength = 10;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(150, 21);
            this.txt_itemName.TabIndex = 548;
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCode.Location = new System.Drawing.Point(781, 62);
            this.txt_itemCode.MaxLength = 10;
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(59, 21);
            this.txt_itemCode.TabIndex = 544;
            // 
            // lbl_itemgroup
            // 
            this.lbl_itemgroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_itemgroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemgroup.ImageIndex = 0;
            this.lbl_itemgroup.ImageList = this.img_Label;
            this.lbl_itemgroup.Location = new System.Drawing.Point(680, 40);
            this.lbl_itemgroup.Name = "lbl_itemgroup";
            this.lbl_itemgroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemgroup.TabIndex = 542;
            this.lbl_itemgroup.Text = "Item Group";
            this.lbl_itemgroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Enabled = false;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(969, 40);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 545;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(680, 62);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 543;
            this.lbl_item.Text = "Item";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_purUser
            // 
            this.cmb_purUser.AddItemSeparator = ';';
            this.cmb_purUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_purUser.Caption = "";
            this.cmb_purUser.CaptionHeight = 17;
            this.cmb_purUser.CaptionStyle = style9;
            this.cmb_purUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_purUser.ColumnCaptionHeight = 18;
            this.cmb_purUser.ColumnFooterHeight = 18;
            this.cmb_purUser.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_purUser.ContentHeight = 16;
            this.cmb_purUser.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_purUser.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_purUser.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_purUser.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_purUser.EditorHeight = 16;
            this.cmb_purUser.EvenRowStyle = style10;
            this.cmb_purUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_purUser.FooterStyle = style11;
            this.cmb_purUser.HeadingStyle = style12;
            this.cmb_purUser.HighLightRowStyle = style13;
            this.cmb_purUser.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_purUser.Images"))));
            this.cmb_purUser.ItemHeight = 15;
            this.cmb_purUser.Location = new System.Drawing.Point(445, 84);
            this.cmb_purUser.MatchEntryTimeout = ((long)(2000));
            this.cmb_purUser.MaxDropDownItems = ((short)(5));
            this.cmb_purUser.MaxLength = 32767;
            this.cmb_purUser.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_purUser.Name = "cmb_purUser";
            this.cmb_purUser.OddRowStyle = style14;
            this.cmb_purUser.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_purUser.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_purUser.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_purUser.SelectedStyle = style15;
            this.cmb_purUser.Size = new System.Drawing.Size(210, 20);
            this.cmb_purUser.Style = style16;
            this.cmb_purUser.TabIndex = 541;
            this.cmb_purUser.PropBag = resources.GetString("cmb_purUser.PropBag");
            // 
            // lbl_reqUser
            // 
            this.lbl_reqUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqUser.ImageIndex = 0;
            this.lbl_reqUser.ImageList = this.img_Label;
            this.lbl_reqUser.Location = new System.Drawing.Point(344, 84);
            this.lbl_reqUser.Name = "lbl_reqUser";
            this.lbl_reqUser.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqUser.TabIndex = 540;
            this.lbl_reqUser.Text = "Purchase User";
            this.lbl_reqUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_vendorCode
            // 
            this.txt_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendorCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_vendorCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_vendorCode.Location = new System.Drawing.Point(445, 62);
            this.txt_vendorCode.MaxLength = 10;
            this.txt_vendorCode.Name = "txt_vendorCode";
            this.txt_vendorCode.Size = new System.Drawing.Size(75, 21);
            this.txt_vendorCode.TabIndex = 537;
            this.txt_vendorCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_vendorCode_KeyUp);
            // 
            // cmb_vendor
            // 
            this.cmb_vendor.AddItemSeparator = ';';
            this.cmb_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_vendor.Caption = "";
            this.cmb_vendor.CaptionHeight = 17;
            this.cmb_vendor.CaptionStyle = style17;
            this.cmb_vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_vendor.ColumnCaptionHeight = 18;
            this.cmb_vendor.ColumnFooterHeight = 18;
            this.cmb_vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_vendor.ContentHeight = 16;
            this.cmb_vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_vendor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_vendor.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_vendor.EditorHeight = 16;
            this.cmb_vendor.EvenRowStyle = style18;
            this.cmb_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.FooterStyle = style19;
            this.cmb_vendor.HeadingStyle = style20;
            this.cmb_vendor.HighLightRowStyle = style21;
            this.cmb_vendor.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_vendor.Images"))));
            this.cmb_vendor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_vendor.ItemHeight = 15;
            this.cmb_vendor.Location = new System.Drawing.Point(521, 62);
            this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_vendor.MaxDropDownItems = ((short)(5));
            this.cmb_vendor.MaxLength = 32767;
            this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.OddRowStyle = style22;
            this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_vendor.SelectedStyle = style23;
            this.cmb_vendor.Size = new System.Drawing.Size(134, 20);
            this.cmb_vendor.Style = style24;
            this.cmb_vendor.TabIndex = 538;
            this.cmb_vendor.SelectedValueChanged += new System.EventHandler(this.cmb_vendor_SelectedValueChanged);
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 0;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(344, 62);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 539;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_StyleCd
            // 
            this.cmb_StyleCd.AddItemSeparator = ';';
            this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_StyleCd.Caption = "";
            this.cmb_StyleCd.CaptionHeight = 17;
            this.cmb_StyleCd.CaptionStyle = style25;
            this.cmb_StyleCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_StyleCd.ColumnCaptionHeight = 18;
            this.cmb_StyleCd.ColumnFooterHeight = 18;
            this.cmb_StyleCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_StyleCd.ContentHeight = 17;
            this.cmb_StyleCd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_StyleCd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_StyleCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_StyleCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_StyleCd.EditorHeight = 17;
            this.cmb_StyleCd.EvenRowStyle = style26;
            this.cmb_StyleCd.FooterStyle = style27;
            this.cmb_StyleCd.HeadingStyle = style28;
            this.cmb_StyleCd.HighLightRowStyle = style29;
            this.cmb_StyleCd.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_StyleCd.Images"))));
            this.cmb_StyleCd.ItemHeight = 15;
            this.cmb_StyleCd.Location = new System.Drawing.Point(445, 40);
            this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
            this.cmb_StyleCd.MaxLength = 32767;
            this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_StyleCd.Name = "cmb_StyleCd";
            this.cmb_StyleCd.OddRowStyle = style30;
            this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.SelectedStyle = style31;
            this.cmb_StyleCd.Size = new System.Drawing.Size(210, 21);
            this.cmb_StyleCd.Style = style32;
            this.cmb_StyleCd.TabIndex = 535;
            this.cmb_StyleCd.PropBag = resources.GetString("cmb_StyleCd.PropBag");
            // 
            // cmb_To
            // 
            this.cmb_To.AddItemSeparator = ';';
            this.cmb_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_To.Caption = "";
            this.cmb_To.CaptionHeight = 17;
            this.cmb_To.CaptionStyle = style33;
            this.cmb_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_To.ColumnCaptionHeight = 18;
            this.cmb_To.ColumnFooterHeight = 18;
            this.cmb_To.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_To.ContentHeight = 16;
            this.cmb_To.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_To.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_To.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_To.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_To.EditorHeight = 16;
            this.cmb_To.EvenRowStyle = style34;
            this.cmb_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_To.FooterStyle = style35;
            this.cmb_To.HeadingStyle = style36;
            this.cmb_To.HighLightRowStyle = style37;
            this.cmb_To.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_To.Images"))));
            this.cmb_To.ItemHeight = 15;
            this.cmb_To.Location = new System.Drawing.Point(220, 84);
            this.cmb_To.MatchEntryTimeout = ((long)(2000));
            this.cmb_To.MaxDropDownItems = ((short)(5));
            this.cmb_To.MaxLength = 32767;
            this.cmb_To.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_To.Name = "cmb_To";
            this.cmb_To.OddRowStyle = style38;
            this.cmb_To.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_To.SelectedStyle = style39;
            this.cmb_To.Size = new System.Drawing.Size(99, 20);
            this.cmb_To.Style = style40;
            this.cmb_To.TabIndex = 416;
            this.cmb_To.SelectedValueChanged += new System.EventHandler(this.cmb_To_SelectedValueChanged);
            this.cmb_To.PropBag = resources.GetString("cmb_To.PropBag");
            // 
            // cmb_From
            // 
            this.cmb_From.AddItemSeparator = ';';
            this.cmb_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_From.Caption = "";
            this.cmb_From.CaptionHeight = 17;
            this.cmb_From.CaptionStyle = style41;
            this.cmb_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_From.ColumnCaptionHeight = 18;
            this.cmb_From.ColumnFooterHeight = 18;
            this.cmb_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_From.ContentHeight = 16;
            this.cmb_From.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_From.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_From.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_From.EditorHeight = 16;
            this.cmb_From.EvenRowStyle = style42;
            this.cmb_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_From.FooterStyle = style43;
            this.cmb_From.HeadingStyle = style44;
            this.cmb_From.HighLightRowStyle = style45;
            this.cmb_From.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_From.Images"))));
            this.cmb_From.ItemHeight = 15;
            this.cmb_From.Location = new System.Drawing.Point(109, 84);
            this.cmb_From.MatchEntryTimeout = ((long)(2000));
            this.cmb_From.MaxDropDownItems = ((short)(5));
            this.cmb_From.MaxLength = 32767;
            this.cmb_From.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_From.Name = "cmb_From";
            this.cmb_From.OddRowStyle = style46;
            this.cmb_From.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_From.SelectedStyle = style47;
            this.cmb_From.Size = new System.Drawing.Size(99, 20);
            this.cmb_From.Style = style48;
            this.cmb_From.TabIndex = 415;
            this.cmb_From.SelectedValueChanged += new System.EventHandler(this.cmb_From_SelectedValueChanged);
            this.cmb_From.PropBag = resources.GetString("cmb_From.PropBag");
            // 
            // lbl_dpo
            // 
            this.lbl_dpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_dpo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dpo.ImageIndex = 1;
            this.lbl_dpo.ImageList = this.img_Label;
            this.lbl_dpo.Location = new System.Drawing.Point(8, 84);
            this.lbl_dpo.Name = "lbl_dpo";
            this.lbl_dpo.Size = new System.Drawing.Size(100, 21);
            this.lbl_dpo.TabIndex = 414;
            this.lbl_dpo.Text = "DPO";
            this.lbl_dpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_shipType
            // 
            this.cmb_shipType.AddItemSeparator = ';';
            this.cmb_shipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipType.Caption = "";
            this.cmb_shipType.CaptionHeight = 17;
            this.cmb_shipType.CaptionStyle = style49;
            this.cmb_shipType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_shipType.ColumnCaptionHeight = 18;
            this.cmb_shipType.ColumnFooterHeight = 18;
            this.cmb_shipType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_shipType.ContentHeight = 16;
            this.cmb_shipType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_shipType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_shipType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_shipType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_shipType.EditorHeight = 16;
            this.cmb_shipType.EvenRowStyle = style50;
            this.cmb_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipType.FooterStyle = style51;
            this.cmb_shipType.HeadingStyle = style52;
            this.cmb_shipType.HighLightRowStyle = style53;
            this.cmb_shipType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_shipType.Images"))));
            this.cmb_shipType.ItemHeight = 15;
            this.cmb_shipType.Location = new System.Drawing.Point(109, 62);
            this.cmb_shipType.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipType.MaxDropDownItems = ((short)(5));
            this.cmb_shipType.MaxLength = 32767;
            this.cmb_shipType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipType.Name = "cmb_shipType";
            this.cmb_shipType.OddRowStyle = style54;
            this.cmb_shipType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipType.SelectedStyle = style55;
            this.cmb_shipType.Size = new System.Drawing.Size(210, 20);
            this.cmb_shipType.Style = style56;
            this.cmb_shipType.TabIndex = 413;
            this.cmb_shipType.SelectedValueChanged += new System.EventHandler(this.cmb_SearchOption_SelectedValueChanged);
            this.cmb_shipType.PropBag = resources.GetString("cmb_shipType.PropBag");
            // 
            // lbl_shipType
            // 
            this.lbl_shipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipType.ImageIndex = 1;
            this.lbl_shipType.ImageList = this.img_Label;
            this.lbl_shipType.Location = new System.Drawing.Point(8, 62);
            this.lbl_shipType.Name = "lbl_shipType";
            this.lbl_shipType.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipType.TabIndex = 412;
            this.lbl_shipType.Text = "Ship Type";
            this.lbl_shipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(208, 86);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(12, 16);
            this.lblexcep_mark.TabIndex = 411;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Style
            // 
            this.lbl_Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
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
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 125);
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
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 124);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(960, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style57;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 16;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 16;
            this.cmb_Factory.EvenRowStyle = style58;
            this.cmb_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style59;
            this.cmb_Factory.HeadingStyle = style60;
            this.cmb_Factory.HighLightRowStyle = style61;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style62;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style63;
            this.cmb_Factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_Factory.Style = style64;
            this.cmb_Factory.TabIndex = 1;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(899, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 100);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(984, 0);
            this.pic_head2.Name = "pic_head2";
            this.pic_head2.Size = new System.Drawing.Size(16, 32);
            this.pic_head2.TabIndex = 44;
            this.pic_head2.TabStop = false;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 125);
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
            this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
            this.pic_head6.Location = new System.Drawing.Point(0, 0);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 123);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(160, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(920, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // Form_BM_MRP_Monitoring_Local2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BM_MRP_Monitoring_Local2";
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_To)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_From)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 전역변수
 
		private COM.OraDB MyOraDB = new COM.OraDB(); 
		private string _mrpDate;
		private Pop_BM_Shipping_Wait _pop;

		// search option value
		private const string PKG = "PKG_SBM_MRP_MONITORING_LOCAL";
		private const string SEARCH_TYPE_MRP = "10", SEARCH_TYPE_PURCHASE = "20";
		private string _itemGroupCode = " ";
		private Hashtable _columns = new Hashtable();


        private Thread tRun = null;
        delegate void DelegateSetn(); // 대리자 선언     

		
		#endregion

		#region 툴바 메뉴 이벤트 처리

        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            SetPrint();
        }

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

				Search();
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

		private void cmb_SearchOption_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				fgrid_main.ClearAll();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_SearchOption_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void cmb_From_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_From.SelectedIndex == -1) return;
					cmb_To.SelectedValue = cmb_From.SelectedValue.ToString();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_From_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void cmb_To_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				setStyleList();
				fgrid_main.ClearAll(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_To_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

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

		private void btn_groupSearch_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				string vTyep = cmb_itemGroup.SelectedValue.ToString();
				FlexBase.MaterialBase.Pop_GroupSearchAll vPopup = new FlexBase.MaterialBase.Pop_GroupSearchAll(vTyep);
				
				vPopup.ShowDialog();
			
				_itemGroupCode = COM.ComVar.Parameter_PopUp[3];
				txt_itemGroup.Text	= COM.ComVar.Parameter_PopUp[4];

				vPopup.Dispose(); 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_groupSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void txt_vendorCode_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				DataTable vDt;
				vDt = ClassLib.ComFunction.SELECT_SCM_CUST_LIST(COM.ComVar.This_Factory, txt_vendorCode.Text);
				COM.ComCtl.Set_ComboList(vDt, cmb_vendor, 0, 1, true, 79, 141);
				vDt.Dispose();

				cmb_vendor.SelectedValue = txt_vendorCode.Text;
			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
		}

		private void cmb_vendor_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if (cmb_vendor.SelectedIndex != -1)
					txt_vendorCode.Text		 = cmb_vendor.SelectedValue.ToString();
			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
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


		private void mnu_Purchase_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				if (ClassLib.ComFunction.User_Message("Do you want process run?", "Run", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
				{
					return;
				}
				else
				{
					COM.ComVar.Parameter_PopUp = new string[] { COM.ComFunction.Empty_Combo(cmb_Factory, ""), "12"};

					Pop_BM_MRP_Usage_Local_Purchase vPop = new Pop_BM_MRP_Usage_Local_Purchase();

					if (vPop.ShowDialog() == DialogResult.OK)
					{
						_mrpDate = vPop.mrpDate;
					}
					else
					{
						//ClassLib.ComFunction.User_Message("Select process information!", "run", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}


                    tRun = new Thread(new ThreadStart(RunPurchase));

                    if (tRun != null)
                    {
                        tRun.Start();
                        _pop = new Pop_BM_Shipping_Wait();
                        _pop.Start();

                    }

                    tRun.Abort();



				} 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Check_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				Search();
			}
		}





        public void RunPurchase()
        {

            Invoke(new DelegateSetn(Purchase)); // 폼 스레드에 작업 넘김

        }






        private void Purchase()
        {
            try
            {

                // 임시 테이블 저장
                if (Save_Item_Temp())
                {
                    //					if (!RUN_DPO_PURCHASE(_mrpDate))
                    //					{
                    //						ClassLib.ComFunction.User_Message("First usage calculation fail!!", "Run", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //					}

                    ClassLib.ComFunction.User_Message("Process Complate!!", "Run", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _pop.Close();
            }
        }



		private void btn_Usage_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
			((Label)sender).ImageIndex = 1;
		}

		private void btn_Usage_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{ 
			((Label)sender).ImageIndex = 0;
		}

		private void btn_Usage_Click(object sender, System.EventArgs e)
		{
			if (MessageBox.Show(this, "Do you want to run DPO Usage Process?", "Run", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{

                if (MessageBox.Show(this, "Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tRun = new Thread(new ThreadStart(RunUsage));

                    if (tRun != null)
                    {
                        tRun.Start();
                        _pop = new Pop_BM_Shipping_Wait();
                        _pop.Start();

                    }

                    tRun.Abort();
                }

			}
		}


        public void RunUsage()
        {
        
            Invoke(new DelegateSetn(Usage)); // 폼 스레드에 작업 넘김

        }


		private void Usage()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (RUN_SBM_DPO_USAGE())
				{
					//_pop.Close();
					//ClassLib.ComFunction.User_Message("Processing Complete.", "Processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Run Process", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				_pop.Close();

				Search();
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.User_Message("Processing Complete.", "Processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}		
			
		}


      





		private Pop_BM_Shipping_Wait getWaitPopup()
		{
			return new Pop_BM_Shipping_Wait();
		}




		private bool Save_Item_Temp()
		{

			try
			{
				int[] vSel = fgrid_main.Selections;

				foreach (int vRow in vSel)
				{
					if (fgrid_main.Rows[vRow].Node.Level == 1)
					{
						int vstr = vRow + 1;
						int vend = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;

						for (int i = vstr ; i <= vend ; i++)
						{
							fgrid_main.Update_Row(i);
						}
					}
					if (fgrid_main.Rows[vRow].Node.Level > 1)
					{
						fgrid_main.Update_Row(vRow);  
					}
				}

				/*
				int vStart = vSel[vSel.Length - 1];
				int vEnd = vSel[vSel.Length - 1];

				int vLevel = fgrid_main.Rows[vStart].Node.Level;
				if (vLevel == 1)
					vEnd = fgrid_main.Rows[vStart].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;

				for (int vTemp = vStart ; vTemp <= vEnd ; vTemp++)
				{
					if (fgrid_main.Rows[vTemp].Node.Level > 1)
					{
						fgrid_main.Update_Row(vTemp);
					}
				}
				*/

				if (this.SAVE_SBM_DPO_ITEM())
				{

					MessageBox.Show("Purchase Complete (Temp Date)","Purchase", MessageBoxButtons.OK ,MessageBoxIcon.Information);
//					if (RUN_SBP_PURCHASE_ORDER())
//					{
//						if (MyOraDB.Exe_Modify_Procedure() != null)
//						{
//							foreach (int vRow in vSel)
//							{
//								fgrid_main[vRow, _statusCol] = "PURCHASE";
//							}
//
//							MessageBox.Show("Purchase Complete","Purchase", MessageBoxButtons.OK ,MessageBoxIcon.Information);
//							fgrid_main.Refresh_Division();
//							Grid_SetColor();
//							return;
//						}
//					}
				}
				return true;

			}
			catch
			{	
				return false;
			}
			finally
			{
			}

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

                    for (int row = strRow; row <= endRow; row++)
                    {
                        fgrid_main.Rows[row].Selected = true;
                    }
                }
            }
        }

        private void fgrid_main_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                isCtrlDown = true;
            }
        }

        private void fgrid_main_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                isCtrlDown = false;
            }
        }

        private void mnu_Rate_Click(object sender, System.EventArgs e)
        {
            Mnu_Rate();
        }

        private void Mnu_Rate()
        {
            try
            {
                int vCol = fgrid_main.Col;

                ClassLib.ComVar.Parameter_PopUp = new string[] { "Value", "100" };
                //ClassLib.ComVar.Parameter_PopUp_Object = new object[]{fgrid_main.GetDataSourceWithCode(_confirmQtyCol)};
                Pop_BM_Changer _pop = new Pop_BM_Changer();
                _pop.ShowDialog();

                if (ClassLib.ComVar.Parameter_PopUp != null)
                {
                    foreach (int vRow in fgrid_main.Selections)
                    {
                        if (fgrid_main.Rows[vRow].Node.Level == 2)
                        {
                            int _ConfirmQty = Convert.ToInt32(fgrid_main[vRow, 9]);
                            double _PurchaseQty = _ConfirmQty * (Convert.ToDouble(ClassLib.ComVar.Parameter_PopUp[0]) / 100);
                            double _Rate = (Convert.ToDouble(ClassLib.ComVar.Parameter_PopUp[0]) / 100);
                            //string _Temp       = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxREMARKS]);
                            //string _Remarks    = _Temp + ", Rate : " + ClassLib.ComVar.Parameter_PopUp[0] + "%";

                            fgrid_main[vRow, 10] = _PurchaseQty;
                            fgrid_main[vRow, 14] = ClassLib.ComVar.Parameter_PopUp[0];
                            //fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxREMARKS] = _Remarks;

                            //fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxCONFIRM_QTY] = ClassLib.ComVar.Parameter_PopUp[0]
                            fgrid_main.Update_Row(vRow);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Rate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



		#endregion 

		#region 이벤트 처리 로직

		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form set
            this.Text = "Local/LLT MRP Monitoring by Purchasing";
            lbl_MainTitle.Text = "Local/LLT MRP Monitoring by Purchasing";

            ClassLib.ComFunction.SetLangDic(this);


			// grid set
			fgrid_main.Set_Grid("SBM_MRP_MONITORING_LOCAL", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
			fgrid_main.Rows[0].AllowMerging = true;
			fgrid_main.Rows[1].AllowMerging = true;
            fgrid_main.Set_Action_Image(img_Action);

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

			// ship type
			dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBM09");
			COM.ComCtl.Set_ComboList(dt_ret, cmb_shipType, 1, 2, false, 80, 140);
			cmb_shipType.SelectedIndex = 1;

			// purchase user
			dt_ret = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory,"");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_purUser, 1, 1, true, 0, 200);
			cmb_purUser.SelectedValue = COM.ComVar.This_User;
		  
			// group type
			dt_ret = ClassLib.ComFunction.Select_GroupTypeCode();  
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_itemGroup, 0, 1, false,  0, 130);  

			dt_ret.Dispose(); 

			// toolbar button disable setting
			tbtn_Delete.Enabled = false;
			tbtn_Confirm.Enabled = false; 
			tbtn_Save.Enabled = false; 
			
		}

		private void setDPO()
		{			
			DataTable dt_ret = ClassLib.ComVar.Select_DP_DPO_List(cmb_Factory.SelectedValue.ToString(), "2" );
			COM.ComCtl.Set_ComboList(dt_ret, cmb_From, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
			COM.ComCtl.Set_ComboList(dt_ret, cmb_To, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
			cmb_StyleCd.ClearItems();
		}

		private void setStyleList()
		{
			if (cmb_From.SelectedIndex == -1 || cmb_To.SelectedIndex == -1)
				return;

			string[] args = new string[5];
			
			args[0] = COM.ComFunction.Empty_Combo(cmb_Factory, "");
			args[1] = COM.ComFunction.Empty_Combo(cmb_From, "");
			args[2] = COM.ComFunction.Empty_Combo(cmb_To, "");
			args[3] = "2";

			DataTable dt_ret = this.SELECT_STYLE_LIST_DPDPO(args);
			if (dt_ret.Rows.Count > 0)
			{
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_StyleCd, 0, 1, true, 80, 130);
			}
			dt_ret.Dispose();
		}



        private void SetPrint()
        {
            try
            {


                C1.Win.C1List.C1Combo[] cmb_array = { cmb_Factory, cmb_From, cmb_To };

                bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);

                if (!essential_check) return;


                string mrd_Filename = Application.StartupPath + @"\Report\MRP\Form_BM_MRP_Monitoring_Local.mrd";
                string Para = " ";

                #region 출력조건

                int iCnt = 15;
                string[] aHead = new string[iCnt];


                aHead[0] = ClassLib.ComVar.This_Factory;
                aHead[1] = cmb_Factory.SelectedValue.ToString();
                aHead[2] = ClassLib.ComFunction.Empty_Combo(cmb_shipType, " ");
                aHead[3] = "";//ClassLib.ComFunction.Empty_Combo(cmb_mrpNo, " ");
                aHead[4] = ClassLib.ComFunction.Empty_Combo(cmb_StyleCd, " ").Replace("-", "");
                aHead[5] = cmb_From.SelectedValue.ToString();
                aHead[6] = cmb_To.SelectedValue.ToString();
                aHead[7] = ClassLib.ComFunction.Empty_Combo(cmb_vendor, " ");
                aHead[8] = ClassLib.ComFunction.Empty_Combo(cmb_purUser, " ");
                aHead[9] = _itemGroupCode.Replace("00", " ");
                aHead[10] = ClassLib.ComFunction.Empty_TextBox(txt_itemCode, " ");
                aHead[11] = ClassLib.ComFunction.Empty_TextBox(txt_itemName, " ");


                aHead[12] = ClassLib.ComFunction.Empty_String(cmb_shipType.SelectedText.ToString(), " ");
                aHead[13] = ClassLib.ComFunction.Empty_String(cmb_vendor.SelectedText.ToString(), " ");
                aHead[14] = ClassLib.ComFunction.Empty_String(cmb_itemGroup.SelectedText.ToString(), "00");
                				

                #endregion

                Para = " /rp ";
                for (int i = 1; i <= iCnt; i++)
                {
                    Para = Para + "[" + aHead[i - 1] + "] ";
                }

                FlexBase.Report.Form_RdViewer report = new FlexBase.Report.Form_RdViewer(mrd_Filename, Para);
                report.Show();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "SetPrintYield", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


		#endregion

		#region 툴바 메뉴 이벤트
		
		/// <summary>
		/// Clear : 화면 초기화
		/// </summary>
		private void Clear()
		{
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
			cmb_From.SelectedIndex = -1; 
			cmb_To.SelectedIndex = -1;
			cmb_StyleCd.SelectedIndex = -1;
			cmb_purUser.SelectedIndex = -1;
			cmb_vendor.SelectedIndex = -1;
			txt_vendorCode.Text = "";
			txt_itemCode.Text = "";
			txt_itemName.Text = "";
			 
			fgrid_main.ClearAll();  
		}

		/// <summary>
		/// Search : 조회
		/// </summary>
		private void Search()
		{
  			C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_From, cmb_To};

			bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);

			if(! essential_check) return;

			fgrid_main.ClearAll();

			string factory = cmb_Factory.SelectedValue.ToString();
			string ship_type = ClassLib.ComFunction.Empty_Combo(cmb_shipType, " ");
			string mrp_ship_no = "";//ClassLib.ComFunction.Empty_Combo(cmb_mrpNo, " ");
			string style_cd = ClassLib.ComFunction.Empty_Combo(cmb_StyleCd, " ").Replace("-", "");
			string from = cmb_From.SelectedValue.ToString();
			string to = cmb_To.SelectedValue.ToString();

			// 추가
			string vendor = ClassLib.ComFunction.Empty_Combo(cmb_vendor, " ");
			string pur_user = ClassLib.ComFunction.Empty_Combo(cmb_purUser, " "); 
			string group_cd = _itemGroupCode.Replace("00", " "); 
			string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_itemCode, " "); 
			string item_name = ClassLib.ComFunction.Empty_TextBox(txt_itemName, " "); 

			string[] parameter = new string[] {factory, ship_type, mrp_ship_no, style_cd, from, to, vendor, pur_user, group_cd, item_cd, item_name};

			try
			{
				this.Cursor = Cursors.WaitCursor;

				DataTable vDt = SELECT_DPO_BALANCE(parameter);
				if (vDt.Rows.Count > 0)
				{
					ClassLib.ComFunction.Display_FlexGrid_Tree(fgrid_main, vDt, 0);
					fgrid_main.Tree.Column = 2;
					Grid_SetColor();
					fgrid_main.Tree.Show(1);	
				}
				else
				{
					fgrid_main.ClearAll();
				}

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}


		// grid color set
		private void Grid_SetColor()
		{
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				switch (fgrid_main.Rows[vRow].Node.Level)
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
				}
			}
		}

		private double blankToZero(object arg_obj)
		{
			if (arg_obj != null)
			{
				if (arg_obj.ToString().Equals(""))
					return 0;
				else
					return Convert.ToDouble(arg_obj.ToString());
			}

			return 0;
		}


		private void setGridDesign()
		{
			for (int row = fgrid_main.Rows.Fixed ; row < fgrid_main.Rows.Count ; row++)
			{
				CellRange range = fgrid_main.GetCellRange(row, 1, row, fgrid_main.Cols.Count - 1);

				switch (fgrid_main.Rows[row].Node.Level)
				{
					case 1:
						range.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						break;
					case 2:
                        range.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
						break;
				}
			}
		}

		#endregion 

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
					//vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 12]));                  
                    vModifyList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 10]));
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



		
		/// <summary>
		/// PKG_SBM_MRP_MONITORING_LOCAL : 
		/// </summary>
		public bool RUN_SBM_DPO_USAGE()
		{
			//_pop.Message = "Data Creating..";

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_MRP_MONITORING_LOCAL.RUN_DPO_USAGE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = COM.ComFunction.Empty_Combo(cmb_Factory, "");
			MyOraDB.Parameter_Values[1]  = COM.ComFunction.Empty_Combo(cmb_From, "");
			MyOraDB.Parameter_Values[2]  = "FT";
			MyOraDB.Parameter_Values[3]  = COM.ComVar.This_User;


			//_pop.Message = "Saving...";

			MyOraDB.Add_Modify_Parameter(true);
			DataSet vDs = MyOraDB.Exe_Modify_Procedure(); 

			if (vDs != null)
				return true;
			else 
				return false;
		}

		#endregion	

	

	}
}
