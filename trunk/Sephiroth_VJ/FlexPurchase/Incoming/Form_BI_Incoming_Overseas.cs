using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;


namespace FlexPurchase.Incoming
{
	public class Form_BI_Incoming_Overseas : COM.PCHWinForm.Form_Top
	{


		#region 컨트롤 정의 및 리소스 정리


		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		public COM.FSP fgrid_main;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.TextBox txt_inStatus;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_chgInYmd;
		private System.Windows.Forms.Label btn_change;
		private System.Windows.Forms.DateTimePicker dpick_chgInYmd;
		private System.Windows.Forms.Label btn_invoice;
		private System.Windows.Forms.Label btn_purchase;
		private System.Windows.Forms.DateTimePicker dpick_inYmd;
		private System.Windows.Forms.Label lbl_inStatus;
		private C1.Win.C1List.C1Combo cmb_purDiv;
		private System.Windows.Forms.TextBox txt_invNo;
		private System.Windows.Forms.TextBox txt_lcNo;
		private System.Windows.Forms.Label lbl_invNo;
		private System.Windows.Forms.Label lbl_lcNo;
		private System.Windows.Forms.TextBox txt_remarks;
		private C1.Win.C1List.C1Combo cmb_inSize;
		private System.Windows.Forms.Label lbl_inSize;
		private System.Windows.Forms.Label btn_sizeSearch;
		private C1.Win.C1List.C1Combo cmb_buyDiv;
		private System.Windows.Forms.Label lbl_buyDiv;
		private System.Windows.Forms.Label lbl_purDiv;
		private C1.Win.C1List.C1Combo cmb_inType;
		private System.Windows.Forms.Label lbl_inType;
		private C1.Win.C1List.C1Combo cmb_inNo;
		private System.Windows.Forms.Label lbl_inNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.Label lbl_inYmd;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.Panel pnl_menu;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label btn_insert;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.ContextMenu cmenu_Main;
		private System.Windows.Forms.MenuItem menuItem_TreeViewOption;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem_ValueChange;
		private System.Windows.Forms.MenuItem menuItem_RateExchange;
		private System.Windows.Forms.MenuItem menuItem_TreeViewHead;
		private System.Windows.Forms.MenuItem menuItem_TreeViewDetail;
		private System.Windows.Forms.Label btn_Tree;
        private TextBox txtChangeRate;
        private Label label3;
        private TextBox txtVND_AMT;
        private TextBox txtUSD_AMT;
        private Label label4;
        private Label label5;
        private C1.Win.C1List.C1Combo cmb_PayDiv;
        private Label label6;
		private System.ComponentModel.IContainer components = null;


		#endregion

		#region 생성자, 소멸자


		public Form_BI_Incoming_Overseas()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.



			Init_Form();
            Select_Exhange_Rate();



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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BI_Incoming_Overseas));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_main = new COM.FSP();
            this.cmenu_Main = new System.Windows.Forms.ContextMenu();
            this.menuItem_TreeViewOption = new System.Windows.Forms.MenuItem();
            this.menuItem_TreeViewHead = new System.Windows.Forms.MenuItem();
            this.menuItem_TreeViewDetail = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem_ValueChange = new System.Windows.Forms.MenuItem();
            this.menuItem_RateExchange = new System.Windows.Forms.MenuItem();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.cmb_PayDiv = new C1.Win.C1List.C1Combo();
            this.txtChangeRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_inStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_chgInYmd = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Label();
            this.dpick_chgInYmd = new System.Windows.Forms.DateTimePicker();
            this.btn_invoice = new System.Windows.Forms.Label();
            this.btn_purchase = new System.Windows.Forms.Label();
            this.dpick_inYmd = new System.Windows.Forms.DateTimePicker();
            this.lbl_inStatus = new System.Windows.Forms.Label();
            this.cmb_purDiv = new C1.Win.C1List.C1Combo();
            this.txt_invNo = new System.Windows.Forms.TextBox();
            this.txt_lcNo = new System.Windows.Forms.TextBox();
            this.lbl_invNo = new System.Windows.Forms.Label();
            this.lbl_lcNo = new System.Windows.Forms.Label();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.cmb_inSize = new C1.Win.C1List.C1Combo();
            this.lbl_inSize = new System.Windows.Forms.Label();
            this.btn_sizeSearch = new System.Windows.Forms.Label();
            this.cmb_buyDiv = new C1.Win.C1List.C1Combo();
            this.lbl_buyDiv = new System.Windows.Forms.Label();
            this.lbl_purDiv = new System.Windows.Forms.Label();
            this.cmb_inType = new C1.Win.C1List.C1Combo();
            this.lbl_inType = new System.Windows.Forms.Label();
            this.cmb_inNo = new C1.Win.C1List.C1Combo();
            this.lbl_inNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.btn_search = new System.Windows.Forms.Label();
            this.lbl_inYmd = new System.Windows.Forms.Label();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVND_AMT = new System.Windows.Forms.TextBox();
            this.txtUSD_AMT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Tree = new System.Windows.Forms.Label();
            this.btn_recover = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PayDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_buyDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            this.pnl_menu.SuspendLayout();
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
            // tbtn_Delete
            // 
            this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
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
            // tbtn_Confirm
            // 
            this.tbtn_Confirm.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Confirm_Click);
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.pnl_menu);
            this.c1Sizer1.GridDefinition = "25:False:True;67.1232876712329:False:False;5.13698630136986:False:True;\t0.3937007" +
                "87401575:False:True;97.6377952755905:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 584);
            this.c1Sizer1.TabIndex = 29;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.Color.White;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ContextMenu = this.cmenu_Main;
            this.fgrid_main.Location = new System.Drawing.Point(12, 154);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Rows.DefaultSize = 19;
            this.fgrid_main.Size = new System.Drawing.Size(992, 392);
            this.fgrid_main.StyleInfo = resources.GetString("fgrid_main.StyleInfo");
            this.fgrid_main.TabIndex = 171;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            this.fgrid_main.DoubleClick += new System.EventHandler(this.fgrid_main_DoubleClick);
            // 
            // cmenu_Main
            // 
            this.cmenu_Main.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_TreeViewOption,
            this.menuItem1,
            this.menuItem_ValueChange,
            this.menuItem_RateExchange});
            // 
            // menuItem_TreeViewOption
            // 
            this.menuItem_TreeViewOption.Index = 0;
            this.menuItem_TreeViewOption.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_TreeViewHead,
            this.menuItem_TreeViewDetail});
            this.menuItem_TreeViewOption.Text = "Tree View Option";
            // 
            // menuItem_TreeViewHead
            // 
            this.menuItem_TreeViewHead.Index = 0;
            this.menuItem_TreeViewHead.Text = "Head";
            this.menuItem_TreeViewHead.Click += new System.EventHandler(this.menuItem_TreeViewHead_Click);
            // 
            // menuItem_TreeViewDetail
            // 
            this.menuItem_TreeViewDetail.Index = 1;
            this.menuItem_TreeViewDetail.Text = "Detail";
            this.menuItem_TreeViewDetail.Click += new System.EventHandler(this.menuItem_TreeViewDetail_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.Text = "-";
            // 
            // menuItem_ValueChange
            // 
            this.menuItem_ValueChange.Index = 2;
            this.menuItem_ValueChange.Text = "Value Change";
            this.menuItem_ValueChange.Click += new System.EventHandler(this.menuItem_ValueChange_Click);
            // 
            // menuItem_RateExchange
            // 
            this.menuItem_RateExchange.Index = 3;
            this.menuItem_RateExchange.Text = "Rate Exchange";
            this.menuItem_RateExchange.Click += new System.EventHandler(this.menuItem_RateExchange_Click);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.label6);
            this.pnl_head.Controls.Add(this.cmb_PayDiv);
            this.pnl_head.Controls.Add(this.txtChangeRate);
            this.pnl_head.Controls.Add(this.label3);
            this.pnl_head.Controls.Add(this.txt_inStatus);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.lbl_chgInYmd);
            this.pnl_head.Controls.Add(this.btn_change);
            this.pnl_head.Controls.Add(this.dpick_chgInYmd);
            this.pnl_head.Controls.Add(this.btn_invoice);
            this.pnl_head.Controls.Add(this.btn_purchase);
            this.pnl_head.Controls.Add(this.dpick_inYmd);
            this.pnl_head.Controls.Add(this.lbl_inStatus);
            this.pnl_head.Controls.Add(this.cmb_purDiv);
            this.pnl_head.Controls.Add(this.txt_invNo);
            this.pnl_head.Controls.Add(this.txt_lcNo);
            this.pnl_head.Controls.Add(this.lbl_invNo);
            this.pnl_head.Controls.Add(this.lbl_lcNo);
            this.pnl_head.Controls.Add(this.txt_remarks);
            this.pnl_head.Controls.Add(this.cmb_inSize);
            this.pnl_head.Controls.Add(this.lbl_inSize);
            this.pnl_head.Controls.Add(this.btn_sizeSearch);
            this.pnl_head.Controls.Add(this.cmb_buyDiv);
            this.pnl_head.Controls.Add(this.lbl_buyDiv);
            this.pnl_head.Controls.Add(this.lbl_purDiv);
            this.pnl_head.Controls.Add(this.cmb_inType);
            this.pnl_head.Controls.Add(this.lbl_inType);
            this.pnl_head.Controls.Add(this.cmb_inNo);
            this.pnl_head.Controls.Add(this.lbl_inNo);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.btn_search);
            this.pnl_head.Controls.Add(this.lbl_inYmd);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(992, 146);
            this.pnl_head.TabIndex = 1;
            // 
            // cmb_PayDiv
            // 
            this.cmb_PayDiv.AddItemSeparator = ';';
            this.cmb_PayDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_PayDiv.Caption = "";
            this.cmb_PayDiv.CaptionHeight = 17;
            this.cmb_PayDiv.CaptionStyle = style1;
            this.cmb_PayDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_PayDiv.ColumnCaptionHeight = 18;
            this.cmb_PayDiv.ColumnFooterHeight = 18;
            this.cmb_PayDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_PayDiv.ContentHeight = 16;
            this.cmb_PayDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_PayDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_PayDiv.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_PayDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_PayDiv.EditorHeight = 16;
            this.cmb_PayDiv.EvenRowStyle = style2;
            this.cmb_PayDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_PayDiv.FooterStyle = style3;
            this.cmb_PayDiv.HeadingStyle = style4;
            this.cmb_PayDiv.HighLightRowStyle = style5;
            this.cmb_PayDiv.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_PayDiv.Images"))));
            this.cmb_PayDiv.ItemHeight = 15;
            this.cmb_PayDiv.Location = new System.Drawing.Point(765, 77);
            this.cmb_PayDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_PayDiv.MaxDropDownItems = ((short)(5));
            this.cmb_PayDiv.MaxLength = 32767;
            this.cmb_PayDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_PayDiv.Name = "cmb_PayDiv";
            this.cmb_PayDiv.OddRowStyle = style6;
            this.cmb_PayDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_PayDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_PayDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_PayDiv.SelectedStyle = style7;
            this.cmb_PayDiv.Size = new System.Drawing.Size(220, 20);
            this.cmb_PayDiv.Style = style8;
            this.cmb_PayDiv.TabIndex = 402;
            this.cmb_PayDiv.PropBag = resources.GetString("cmb_PayDiv.PropBag");
            // 
            // txtChangeRate
            // 
            this.txtChangeRate.BackColor = System.Drawing.Color.White;
            this.txtChangeRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChangeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtChangeRate.Location = new System.Drawing.Point(765, 99);
            this.txtChangeRate.MaxLength = 20;
            this.txtChangeRate.Name = "txtChangeRate";
            this.txtChangeRate.ReadOnly = true;
            this.txtChangeRate.Size = new System.Drawing.Size(100, 21);
            this.txtChangeRate.TabIndex = 401;
            this.txtChangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ImageIndex = 0;
            this.label3.ImageList = this.img_Label;
            this.label3.Location = new System.Drawing.Point(664, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 400;
            this.label3.Text = "Exchange Rate";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_inStatus
            // 
            this.txt_inStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_inStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_inStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_inStatus.Location = new System.Drawing.Point(109, 99);
            this.txt_inStatus.MaxLength = 20;
            this.txt_inStatus.Name = "txt_inStatus";
            this.txt_inStatus.ReadOnly = true;
            this.txt_inStatus.Size = new System.Drawing.Size(220, 21);
            this.txt_inStatus.TabIndex = 395;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 30);
            this.label2.TabIndex = 393;
            this.label2.Text = "      Incoming Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_chgInYmd
            // 
            this.lbl_chgInYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_chgInYmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_chgInYmd.ImageIndex = 0;
            this.lbl_chgInYmd.ImageList = this.img_Label;
            this.lbl_chgInYmd.Location = new System.Drawing.Point(676, 121);
            this.lbl_chgInYmd.Name = "lbl_chgInYmd";
            this.lbl_chgInYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_chgInYmd.TabIndex = 387;
            this.lbl_chgInYmd.Text = "Change Ymd";
            this.lbl_chgInYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_chgInYmd.Visible = false;
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_change.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_change.ImageIndex = 0;
            this.btn_change.ImageList = this.img_Button;
            this.btn_change.Location = new System.Drawing.Point(905, 77);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(80, 23);
            this.btn_change.TabIndex = 386;
            this.btn_change.Text = "Change";
            this.btn_change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_change.Visible = false;
            this.btn_change.MouseLeave += new System.EventHandler(this.btn_MouseHover);
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            this.btn_change.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            this.btn_change.MouseHover += new System.EventHandler(this.btn_MouseLeave);
            this.btn_change.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // dpick_chgInYmd
            // 
            this.dpick_chgInYmd.CustomFormat = "";
            this.dpick_chgInYmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dpick_chgInYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_chgInYmd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dpick_chgInYmd.Location = new System.Drawing.Point(678, 119);
            this.dpick_chgInYmd.Name = "dpick_chgInYmd";
            this.dpick_chgInYmd.Size = new System.Drawing.Size(140, 21);
            this.dpick_chgInYmd.TabIndex = 385;
            this.dpick_chgInYmd.Visible = false;
            // 
            // btn_invoice
            // 
            this.btn_invoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_invoice.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_invoice.ImageIndex = 0;
            this.btn_invoice.ImageList = this.img_Button;
            this.btn_invoice.Location = new System.Drawing.Point(905, 119);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.Size = new System.Drawing.Size(80, 23);
            this.btn_invoice.TabIndex = 383;
            this.btn_invoice.Text = "Invoice";
            this.btn_invoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_invoice.MouseLeave += new System.EventHandler(this.btn_MouseHover);
            this.btn_invoice.Click += new System.EventHandler(this.btn_invoice_Click);
            this.btn_invoice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            this.btn_invoice.MouseHover += new System.EventHandler(this.btn_MouseLeave);
            this.btn_invoice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btn_purchase
            // 
            this.btn_purchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_purchase.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_purchase.ImageIndex = 0;
            this.btn_purchase.ImageList = this.img_Button;
            this.btn_purchase.Location = new System.Drawing.Point(824, 119);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(80, 23);
            this.btn_purchase.TabIndex = 382;
            this.btn_purchase.Text = "Purchase";
            this.btn_purchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_purchase.MouseLeave += new System.EventHandler(this.btn_MouseHover);
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            this.btn_purchase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            this.btn_purchase.MouseHover += new System.EventHandler(this.btn_MouseLeave);
            this.btn_purchase.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // dpick_inYmd
            // 
            this.dpick_inYmd.CustomFormat = "";
            this.dpick_inYmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dpick_inYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_inYmd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dpick_inYmd.Location = new System.Drawing.Point(109, 55);
            this.dpick_inYmd.Name = "dpick_inYmd";
            this.dpick_inYmd.Size = new System.Drawing.Size(221, 21);
            this.dpick_inYmd.TabIndex = 381;
            this.dpick_inYmd.ValueChanged += new System.EventHandler(this.dpick_inYmd_ValueChanged);
            this.dpick_inYmd.CloseUp += new System.EventHandler(this.dpick_inYmd_CloseUp);
            // 
            // lbl_inStatus
            // 
            this.lbl_inStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_inStatus.ImageIndex = 0;
            this.lbl_inStatus.ImageList = this.img_Label;
            this.lbl_inStatus.Location = new System.Drawing.Point(8, 99);
            this.lbl_inStatus.Name = "lbl_inStatus";
            this.lbl_inStatus.Size = new System.Drawing.Size(100, 21);
            this.lbl_inStatus.TabIndex = 379;
            this.lbl_inStatus.Text = "Incoming Status";
            this.lbl_inStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_purDiv
            // 
            this.cmb_purDiv.AddItemSeparator = ';';
            this.cmb_purDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_purDiv.Caption = "";
            this.cmb_purDiv.CaptionHeight = 17;
            this.cmb_purDiv.CaptionStyle = style9;
            this.cmb_purDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_purDiv.ColumnCaptionHeight = 18;
            this.cmb_purDiv.ColumnFooterHeight = 18;
            this.cmb_purDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_purDiv.ContentHeight = 16;
            this.cmb_purDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_purDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_purDiv.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_purDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_purDiv.EditorHeight = 16;
            this.cmb_purDiv.EvenRowStyle = style10;
            this.cmb_purDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_purDiv.FooterStyle = style11;
            this.cmb_purDiv.HeadingStyle = style12;
            this.cmb_purDiv.HighLightRowStyle = style13;
            this.cmb_purDiv.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_purDiv.Images"))));
            this.cmb_purDiv.ItemHeight = 15;
            this.cmb_purDiv.Location = new System.Drawing.Point(765, 33);
            this.cmb_purDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_purDiv.MaxDropDownItems = ((short)(5));
            this.cmb_purDiv.MaxLength = 32767;
            this.cmb_purDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_purDiv.Name = "cmb_purDiv";
            this.cmb_purDiv.OddRowStyle = style14;
            this.cmb_purDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_purDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_purDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_purDiv.SelectedStyle = style15;
            this.cmb_purDiv.Size = new System.Drawing.Size(220, 20);
            this.cmb_purDiv.Style = style16;
            this.cmb_purDiv.TabIndex = 362;
            this.cmb_purDiv.PropBag = resources.GetString("cmb_purDiv.PropBag");
            // 
            // txt_invNo
            // 
            this.txt_invNo.BackColor = System.Drawing.Color.White;
            this.txt_invNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_invNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_invNo.Location = new System.Drawing.Point(437, 99);
            this.txt_invNo.MaxLength = 20;
            this.txt_invNo.Name = "txt_invNo";
            this.txt_invNo.Size = new System.Drawing.Size(220, 21);
            this.txt_invNo.TabIndex = 378;
            // 
            // txt_lcNo
            // 
            this.txt_lcNo.BackColor = System.Drawing.Color.White;
            this.txt_lcNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_lcNo.Location = new System.Drawing.Point(437, 77);
            this.txt_lcNo.MaxLength = 20;
            this.txt_lcNo.Name = "txt_lcNo";
            this.txt_lcNo.Size = new System.Drawing.Size(220, 21);
            this.txt_lcNo.TabIndex = 377;
            // 
            // lbl_invNo
            // 
            this.lbl_invNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_invNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_invNo.ImageIndex = 0;
            this.lbl_invNo.ImageList = this.img_Label;
            this.lbl_invNo.Location = new System.Drawing.Point(336, 99);
            this.lbl_invNo.Name = "lbl_invNo";
            this.lbl_invNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_invNo.TabIndex = 376;
            this.lbl_invNo.Text = "Invoice No";
            this.lbl_invNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_lcNo
            // 
            this.lbl_lcNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_lcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_lcNo.ImageIndex = 0;
            this.lbl_lcNo.ImageList = this.img_Label;
            this.lbl_lcNo.Location = new System.Drawing.Point(336, 77);
            this.lbl_lcNo.Name = "lbl_lcNo";
            this.lbl_lcNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_lcNo.TabIndex = 375;
            this.lbl_lcNo.Text = "LC No";
            this.lbl_lcNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_remarks
            // 
            this.txt_remarks.BackColor = System.Drawing.Color.White;
            this.txt_remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_remarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_remarks.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_remarks.Location = new System.Drawing.Point(109, 121);
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(548, 21);
            this.txt_remarks.TabIndex = 374;
            // 
            // cmb_inSize
            // 
            this.cmb_inSize.AddItemSeparator = ';';
            this.cmb_inSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_inSize.Caption = "";
            this.cmb_inSize.CaptionHeight = 17;
            this.cmb_inSize.CaptionStyle = style17;
            this.cmb_inSize.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_inSize.ColumnCaptionHeight = 18;
            this.cmb_inSize.ColumnFooterHeight = 18;
            this.cmb_inSize.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_inSize.ContentHeight = 16;
            this.cmb_inSize.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_inSize.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_inSize.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_inSize.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_inSize.EditorHeight = 16;
            this.cmb_inSize.EvenRowStyle = style18;
            this.cmb_inSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_inSize.FooterStyle = style19;
            this.cmb_inSize.HeadingStyle = style20;
            this.cmb_inSize.HighLightRowStyle = style21;
            this.cmb_inSize.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_inSize.Images"))));
            this.cmb_inSize.ItemHeight = 15;
            this.cmb_inSize.Location = new System.Drawing.Point(109, 77);
            this.cmb_inSize.MatchEntryTimeout = ((long)(2000));
            this.cmb_inSize.MaxDropDownItems = ((short)(5));
            this.cmb_inSize.MaxLength = 32767;
            this.cmb_inSize.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_inSize.Name = "cmb_inSize";
            this.cmb_inSize.OddRowStyle = style22;
            this.cmb_inSize.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_inSize.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_inSize.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_inSize.SelectedStyle = style23;
            this.cmb_inSize.Size = new System.Drawing.Size(197, 20);
            this.cmb_inSize.Style = style24;
            this.cmb_inSize.TabIndex = 363;
            this.cmb_inSize.SelectedValueChanged += new System.EventHandler(this.cmb_inSize_SelectedValueChanged);
            this.cmb_inSize.PropBag = resources.GetString("cmb_inSize.PropBag");
            // 
            // lbl_inSize
            // 
            this.lbl_inSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_inSize.ImageIndex = 0;
            this.lbl_inSize.ImageList = this.img_Label;
            this.lbl_inSize.Location = new System.Drawing.Point(8, 77);
            this.lbl_inSize.Name = "lbl_inSize";
            this.lbl_inSize.Size = new System.Drawing.Size(100, 21);
            this.lbl_inSize.TabIndex = 364;
            this.lbl_inSize.Text = "Incoming Size";
            this.lbl_inSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_sizeSearch
            // 
            this.btn_sizeSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_sizeSearch.Enabled = false;
            this.btn_sizeSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sizeSearch.ImageIndex = 27;
            this.btn_sizeSearch.ImageList = this.img_SmallButton;
            this.btn_sizeSearch.Location = new System.Drawing.Point(306, 77);
            this.btn_sizeSearch.Name = "btn_sizeSearch";
            this.btn_sizeSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_sizeSearch.TabIndex = 365;
            this.btn_sizeSearch.Tag = "Search";
            this.btn_sizeSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sizeSearch.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_sizeSearch.Click += new System.EventHandler(this.btn_sizeSearch_Click);
            this.btn_sizeSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_sizeSearch.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_sizeSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // cmb_buyDiv
            // 
            this.cmb_buyDiv.AddItemSeparator = ';';
            this.cmb_buyDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_buyDiv.Caption = "";
            this.cmb_buyDiv.CaptionHeight = 17;
            this.cmb_buyDiv.CaptionStyle = style25;
            this.cmb_buyDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_buyDiv.ColumnCaptionHeight = 18;
            this.cmb_buyDiv.ColumnFooterHeight = 18;
            this.cmb_buyDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_buyDiv.ContentHeight = 16;
            this.cmb_buyDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_buyDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_buyDiv.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_buyDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_buyDiv.EditorHeight = 16;
            this.cmb_buyDiv.EvenRowStyle = style26;
            this.cmb_buyDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_buyDiv.FooterStyle = style27;
            this.cmb_buyDiv.HeadingStyle = style28;
            this.cmb_buyDiv.HighLightRowStyle = style29;
            this.cmb_buyDiv.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_buyDiv.Images"))));
            this.cmb_buyDiv.ItemHeight = 15;
            this.cmb_buyDiv.Location = new System.Drawing.Point(765, 55);
            this.cmb_buyDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_buyDiv.MaxDropDownItems = ((short)(5));
            this.cmb_buyDiv.MaxLength = 32767;
            this.cmb_buyDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_buyDiv.Name = "cmb_buyDiv";
            this.cmb_buyDiv.OddRowStyle = style30;
            this.cmb_buyDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_buyDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_buyDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_buyDiv.SelectedStyle = style31;
            this.cmb_buyDiv.Size = new System.Drawing.Size(220, 20);
            this.cmb_buyDiv.Style = style32;
            this.cmb_buyDiv.TabIndex = 361;
            this.cmb_buyDiv.PropBag = resources.GetString("cmb_buyDiv.PropBag");
            // 
            // lbl_buyDiv
            // 
            this.lbl_buyDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_buyDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_buyDiv.ImageIndex = 0;
            this.lbl_buyDiv.ImageList = this.img_Label;
            this.lbl_buyDiv.Location = new System.Drawing.Point(664, 55);
            this.lbl_buyDiv.Name = "lbl_buyDiv";
            this.lbl_buyDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_buyDiv.TabIndex = 360;
            this.lbl_buyDiv.Text = "Buy Division";
            this.lbl_buyDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_purDiv
            // 
            this.lbl_purDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_purDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_purDiv.ImageIndex = 0;
            this.lbl_purDiv.ImageList = this.img_Label;
            this.lbl_purDiv.Location = new System.Drawing.Point(664, 33);
            this.lbl_purDiv.Name = "lbl_purDiv";
            this.lbl_purDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_purDiv.TabIndex = 359;
            this.lbl_purDiv.Text = "Pur  Division";
            this.lbl_purDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_inType
            // 
            this.cmb_inType.AddItemSeparator = ';';
            this.cmb_inType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_inType.Caption = "";
            this.cmb_inType.CaptionHeight = 17;
            this.cmb_inType.CaptionStyle = style33;
            this.cmb_inType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_inType.ColumnCaptionHeight = 18;
            this.cmb_inType.ColumnFooterHeight = 18;
            this.cmb_inType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_inType.ContentHeight = 16;
            this.cmb_inType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_inType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_inType.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_inType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_inType.EditorHeight = 16;
            this.cmb_inType.EvenRowStyle = style34;
            this.cmb_inType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_inType.FooterStyle = style35;
            this.cmb_inType.HeadingStyle = style36;
            this.cmb_inType.HighLightRowStyle = style37;
            this.cmb_inType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_inType.Images"))));
            this.cmb_inType.ItemHeight = 15;
            this.cmb_inType.Location = new System.Drawing.Point(437, 55);
            this.cmb_inType.MatchEntryTimeout = ((long)(2000));
            this.cmb_inType.MaxDropDownItems = ((short)(5));
            this.cmb_inType.MaxLength = 32767;
            this.cmb_inType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_inType.Name = "cmb_inType";
            this.cmb_inType.OddRowStyle = style38;
            this.cmb_inType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_inType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_inType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_inType.SelectedStyle = style39;
            this.cmb_inType.Size = new System.Drawing.Size(220, 20);
            this.cmb_inType.Style = style40;
            this.cmb_inType.TabIndex = 358;
            this.cmb_inType.PropBag = resources.GetString("cmb_inType.PropBag");
            // 
            // lbl_inType
            // 
            this.lbl_inType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_inType.ImageIndex = 1;
            this.lbl_inType.ImageList = this.img_Label;
            this.lbl_inType.Location = new System.Drawing.Point(336, 55);
            this.lbl_inType.Name = "lbl_inType";
            this.lbl_inType.Size = new System.Drawing.Size(100, 21);
            this.lbl_inType.TabIndex = 357;
            this.lbl_inType.Text = "Incoming Type";
            this.lbl_inType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_inNo
            // 
            this.cmb_inNo.AddItemSeparator = ';';
            this.cmb_inNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_inNo.Caption = "";
            this.cmb_inNo.CaptionHeight = 17;
            this.cmb_inNo.CaptionStyle = style41;
            this.cmb_inNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_inNo.ColumnCaptionHeight = 18;
            this.cmb_inNo.ColumnFooterHeight = 18;
            this.cmb_inNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_inNo.ContentHeight = 16;
            this.cmb_inNo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_inNo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_inNo.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_inNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_inNo.EditorHeight = 16;
            this.cmb_inNo.EvenRowStyle = style42;
            this.cmb_inNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_inNo.FooterStyle = style43;
            this.cmb_inNo.HeadingStyle = style44;
            this.cmb_inNo.HighLightRowStyle = style45;
            this.cmb_inNo.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_inNo.Images"))));
            this.cmb_inNo.ItemHeight = 15;
            this.cmb_inNo.Location = new System.Drawing.Point(437, 33);
            this.cmb_inNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_inNo.MaxDropDownItems = ((short)(5));
            this.cmb_inNo.MaxLength = 32767;
            this.cmb_inNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_inNo.Name = "cmb_inNo";
            this.cmb_inNo.OddRowStyle = style46;
            this.cmb_inNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_inNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_inNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_inNo.SelectedStyle = style47;
            this.cmb_inNo.Size = new System.Drawing.Size(197, 20);
            this.cmb_inNo.Style = style48;
            this.cmb_inNo.TabIndex = 5;
            this.cmb_inNo.SelectedValueChanged += new System.EventHandler(this.cmb_inNo_SelectedValueChanged);
            this.cmb_inNo.PropBag = resources.GetString("cmb_inNo.PropBag");
            // 
            // lbl_inNo
            // 
            this.lbl_inNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_inNo.ImageIndex = 1;
            this.lbl_inNo.ImageList = this.img_Label;
            this.lbl_inNo.Location = new System.Drawing.Point(336, 33);
            this.lbl_inNo.Name = "lbl_inNo";
            this.lbl_inNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_inNo.TabIndex = 50;
            this.lbl_inNo.Text = "Incoming No";
            this.lbl_inNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(8, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 356;
            this.label1.Text = "Remark";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(976, 130);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Window;
            this.btn_search.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ImageIndex = 27;
            this.btn_search.ImageList = this.img_SmallButton;
            this.btn_search.Location = new System.Drawing.Point(634, 33);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(24, 21);
            this.btn_search.TabIndex = 54;
            this.btn_search.Tag = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            this.btn_search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_search.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // lbl_inYmd
            // 
            this.lbl_inYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inYmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_inYmd.ImageIndex = 1;
            this.lbl_inYmd.ImageList = this.img_Label;
            this.lbl_inYmd.Location = new System.Drawing.Point(8, 55);
            this.lbl_inYmd.Name = "lbl_inYmd";
            this.lbl_inYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_inYmd.TabIndex = 50;
            this.lbl_inYmd.Text = "Incoming Date";
            this.lbl_inYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 129);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(952, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style49;
            this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_factory.ColumnCaptionHeight = 18;
            this.cmb_factory.ColumnFooterHeight = 18;
            this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_factory.ContentHeight = 16;
            this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_factory.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory.EditorHeight = 16;
            this.cmb_factory.EvenRowStyle = style50;
            this.cmb_factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_factory.FooterStyle = style51;
            this.cmb_factory.HeadingStyle = style52;
            this.cmb_factory.HighLightRowStyle = style53;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 33);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style54;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style55;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style56;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 33);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 50;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(891, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 105);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(976, 0);
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
            this.pic_head5.Location = new System.Drawing.Point(0, 130);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 128);
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
            this.pic_head1.Size = new System.Drawing.Size(912, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pnl_menu
            // 
            this.pnl_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_menu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_menu.Controls.Add(this.label5);
            this.pnl_menu.Controls.Add(this.txtVND_AMT);
            this.pnl_menu.Controls.Add(this.txtUSD_AMT);
            this.pnl_menu.Controls.Add(this.label4);
            this.pnl_menu.Controls.Add(this.btn_Tree);
            this.pnl_menu.Controls.Add(this.btn_recover);
            this.pnl_menu.Controls.Add(this.btn_insert);
            this.pnl_menu.Controls.Add(this.btn_cancel);
            this.pnl_menu.Location = new System.Drawing.Point(12, 550);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(992, 30);
            this.pnl_menu.TabIndex = 170;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ImageIndex = 0;
            this.label5.ImageList = this.img_Label;
            this.label5.Location = new System.Drawing.Point(191, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 407;
            this.label5.Text = "VND AMT";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVND_AMT
            // 
            this.txtVND_AMT.BackColor = System.Drawing.Color.White;
            this.txtVND_AMT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVND_AMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtVND_AMT.Location = new System.Drawing.Point(267, 3);
            this.txtVND_AMT.MaxLength = 20;
            this.txtVND_AMT.Name = "txtVND_AMT";
            this.txtVND_AMT.ReadOnly = true;
            this.txtVND_AMT.Size = new System.Drawing.Size(100, 21);
            this.txtVND_AMT.TabIndex = 406;
            this.txtVND_AMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSD_AMT
            // 
            this.txtUSD_AMT.BackColor = System.Drawing.Color.White;
            this.txtUSD_AMT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUSD_AMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtUSD_AMT.Location = new System.Drawing.Point(68, 2);
            this.txtUSD_AMT.MaxLength = 20;
            this.txtUSD_AMT.Name = "txtUSD_AMT";
            this.txtUSD_AMT.ReadOnly = true;
            this.txtUSD_AMT.Size = new System.Drawing.Size(100, 21);
            this.txtUSD_AMT.TabIndex = 405;
            this.txtUSD_AMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ImageIndex = 0;
            this.label4.ImageList = this.img_Label;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 404;
            this.label4.Text = "USD AMT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Tree
            // 
            this.btn_Tree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Tree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tree.ImageIndex = 13;
            this.btn_Tree.ImageList = this.image_List;
            this.btn_Tree.Location = new System.Drawing.Point(664, 4);
            this.btn_Tree.Name = "btn_Tree";
            this.btn_Tree.Size = new System.Drawing.Size(80, 24);
            this.btn_Tree.TabIndex = 368;
            this.btn_Tree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Tree.Click += new System.EventHandler(this.btn_Tree_Click);
            // 
            // btn_recover
            // 
            this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_recover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recover.ImageIndex = 1;
            this.btn_recover.ImageList = this.image_List;
            this.btn_recover.Location = new System.Drawing.Point(907, 4);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(80, 24);
            this.btn_recover.TabIndex = 367;
            this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_recover.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
            this.btn_recover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_recover.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_recover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_insert.ImageIndex = 9;
            this.btn_insert.ImageList = this.image_List;
            this.btn_insert.Location = new System.Drawing.Point(745, 3);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(80, 26);
            this.btn_insert.TabIndex = 360;
            this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_insert.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            this.btn_insert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_insert.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_insert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ImageIndex = 5;
            this.btn_cancel.ImageList = this.image_List;
            this.btn_cancel.Location = new System.Drawing.Point(826, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 23);
            this.btn_cancel.TabIndex = 359;
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ImageIndex = 0;
            this.label6.ImageList = this.img_Label;
            this.label6.Location = new System.Drawing.Point(664, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 403;
            this.label6.Text = "Pay Division";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_BI_Incoming_Overseas
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BI_Incoming_Overseas";
            this.Load += new System.EventHandler(this.Form_BI_Incoming_Overseas_Load);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PayDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_buyDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            this.pnl_menu.ResumeLayout(false);
            this.pnl_menu.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

 
		private bool _practicable	= false;
		private int _seqCol				= (int)ClassLib.TBSBI_IN_TAIL.IxSEQ;
		private int _factoryCol			= (int)ClassLib.TBSBI_IN_TAIL.IxFACTORY;
		private int _inNoCol			= (int)ClassLib.TBSBI_IN_TAIL.IxIN_NO;
		private int _inSeqCol			= (int)ClassLib.TBSBI_IN_TAIL.IxIN_SEQ;
		//		private int _itemCol			= (int)ClassLib.TBSBI_IN_TAIL.IxITEM;
		private int _itemNameCol		= (int)ClassLib.TBSBI_IN_TAIL.IxITEM_NAME;
		private int _colorNameCol		= (int)ClassLib.TBSBI_IN_TAIL.IxCOLOR_NAME;
		private int _specNameCol		= (int)ClassLib.TBSBI_IN_TAIL.IxSPEC_NAME;
		private int _purNoCol			= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_NO;
		private int _unitCol			= (int)ClassLib.TBSBI_IN_TAIL.IxUNIT;
		private int _styleCdCol			= (int)ClassLib.TBSBI_IN_TAIL.IxSTYLE_CD;
		private int _itemCdCol			= (int)ClassLib.TBSBI_IN_TAIL.IxITEM_CD;
		private int _specCdCol			= (int)ClassLib.TBSBI_IN_TAIL.IxSPEC_CD;
		private int _colorCdCol			= (int)ClassLib.TBSBI_IN_TAIL.IxCOLOR_CD;
		private int _custCdCol			= (int)ClassLib.TBSBI_IN_TAIL.IxCUST_CD;
		private int _barCodeCol			= (int)ClassLib.TBSBI_IN_TAIL.IxBAR_CODE;
		private int _inQtyCol			= (int)ClassLib.TBSBI_IN_TAIL.IxIN_QTY;
		private int _modQtyCol			= (int)ClassLib.TBSBI_IN_TAIL.IxMOD_QTY;
		
		private int _whCdCol			= (int)ClassLib.TBSBI_IN_TAIL.IxWH_CD;

		//		private int _payCdCol			= (int)ClassLib.TBSBI_IN_TAIL.IxPAY_CD;
		private int _custNameCol		= (int)ClassLib.TBSBI_IN_TAIL.IxCUST_NAME;
		//		private int _lotNoCol			= (int)ClassLib.TBSBI_IN_TAIL.IxLOT_NO;
		//		private int _lotSeqCol			= (int)ClassLib.TBSBI_IN_TAIL.IxLOT_SEQ;
		//		private int _shipQtyCol			= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_QTY;
		//		private int _taxCdCol			= (int)ClassLib.TBSBI_IN_TAIL.IxTAX_CD;
		//		private int _barKindCol			= (int)ClassLib.TBSBI_IN_TAIL.IxBAR_KIND;
		//		private int _contNoCol			= (int)ClassLib.TBSBI_IN_TAIL.IxCONT_NO;
		//		private int _shipYmdCol			= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_YMD;
		//		private int _shipNoCol			= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_NO;
		//		private int _shipSeqCol			= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_SEQ;
		//		private int _shipPriceCol		= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_PRICE;
		//		private int _whNameCol			= (int)ClassLib.TBSBI_IN_TAIL.IxWH_NAME;
		//		private int _pkUnitQtyCol		= (int)ClassLib.TBSBI_IN_TAIL.IxPK_UNIT_QTY;
		
		private int _purPriceCol		= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_PRICE;
		private int _purCurrencyCol		= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_CURRENCY;
		private int _outsideCurrencyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxOUTSIDE_CURRENCY;
		private int _outsidePriceCol	= (int)ClassLib.TBSBI_IN_TAIL.IxOUTSIDE_PRICE ;
		private int _cbdCurrencyCol		= (int)ClassLib.TBSBI_IN_TAIL.IxCBD_CURRENCY;
		private int _cbdPriceCol		= (int)ClassLib.TBSBI_IN_TAIL.IxCBD_PRICE;
		private int _shipCurrencyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_CURRENCY;
		private int _shipPriceCol       = (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_PRICE;
		private int _ledgerCurrencyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxLEDGER_CURRENCY;
		private COM.OraDB MyOraDB = new COM.OraDB();  
		private COM.ComFunction MyComFunction = new COM.ComFunction(); 


		// 재고 마감 여부
		private bool _Close_Flag = false;

		// tree level
		private int _LevelHead = 0;
		private int _LevelDetail = 1;




		#endregion 

		#region 멤버 메서드


		#region 초기화

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			
			try
			{


                //Title
                this.Text = "Incoming";
                lbl_MainTitle.Text = "Incoming";
                ClassLib.ComFunction.SetLangDic(this);
 

				fgrid_main.Set_Grid("SBI_IN_OVERSEAS", "2", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_main.Set_Action_Image(img_Action);
				fgrid_main.ExtendLastCol = false; 
				//fgrid_main.Font = new Font("Verdana", 7);
				fgrid_main.AllowSorting = AllowSortingEnum.None;
				fgrid_main.AllowDragging = AllowDraggingEnum.None;
				fgrid_main.Tree.Style = TreeStyleFlags.Complete;
				fgrid_main.Tree.Column = (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxDESC1; 




				Init_Control();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

  
		}


		
		/// <summary>
		/// Init_Control : 
		/// </summary>
		private void Init_Control()
		{
  

			// Disabled tbutton
			tbtn_Confirm.Enabled	= false;
			tbtn_Create.Enabled		= false;



//			// 해외는 소숫점 이하 4자리 표시
//			// 한국은 소숫점 이하 2자리 표시
//			for (int sel_col = 1; sel_col < fgrid_main.Cols.Count ; sel_col++)
//			{
// 
//				 
//
//				if(sel_col == (int)ClassLib.TBSBI_IN_TAIL.IxPUR_PRICE
//					|| sel_col ==  (int)ClassLib.TBSBI_IN_TAIL.IxOUTSIDE_PRICE
//					|| sel_col == (int)ClassLib.TBSBI_IN_TAIL.IxCBD_PRICE
//					|| sel_col ==  (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_PRICE
//					|| sel_col ==  (int)ClassLib.TBSBI_IN_TAIL.IxLEDGER_PRICE)
//				{
//
//				
////				if(ClassLib.ComVar.This_Factory == "QD" || ClassLib.ComVar.This_Factory == "VJ")
////				{
////					fgrid_main.Cols[sel_col].Format = "#,##0.0000";
////				}
//////									else
//////									{
//////										fgrid_main.Cols[sel_col].Format = "#,##0.00";
//////									}
//
// 
//
//				}
//				
//
//				fgrid_main.Cols[sel_col].Format = "#,##0.00";
//
// 
//			} // end for sel_col




			 
			// Factory Combobox Add Items
			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
			dt_ret.Dispose();

			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

            //Set_Date();


		}

        



		#endregion
		  
		#region 조회

 
		#endregion
 
		#region 툴바 이벤트 메서드



		/// <summary>
		/// Event_Tbtn_New : 
		/// </summary>
		/// <param name="arg_clear_flag"></param>
		private void Event_Tbtn_New(bool arg_clear_flag)
		{


			if(arg_clear_flag)
			{
				//cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
				dpick_inYmd.Value = System.DateTime.Now;
				cmb_inNo.SelectedIndex = -1;


			}
			

			cmb_inType.SelectedIndex	= -1;
			cmb_purDiv.SelectedIndex	= -1;				
			cmb_buyDiv.SelectedIndex	= -1;
            cmb_PayDiv.SelectedIndex    = -1;	
			cmb_inSize.SelectedIndex	= -1;	
			btn_sizeSearch.Enabled		= false;
			
			txt_inStatus.Text = "";	
			txt_lcNo.Text	= "";	
			txt_invNo.Text = "";
			txt_remarks.Text = "";
            txtUSD_AMT.Text = "";
            txtVND_AMT.Text = "";

			btn_insert.Enabled = true;
			btn_cancel.Enabled = true;
			btn_recover.Enabled = true;
			
			tbtn_Save.Enabled = true;
			tbtn_Delete.Enabled = true;
			tbtn_Confirm.Enabled	= false;
			
			fgrid_main.AllowEditing = true;  
			fgrid_main.ClearAll();



			if(arg_clear_flag)
			{
				
				// 자재 재고 마감 여부 체크 후 버튼 권한 관리
				Check_Closing_Process();
			}
			




		}



		/// <summary>
		/// Event_Tbtn_Search : 
		/// </summary>
		private void Event_Tbtn_Search()
		{


			// 조회시 필수조건 체크 
			C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_inNo}; 
			System.Windows.Forms.TextBox[] txt_array = {};  
			bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
            txtUSD_AMT.Text = "";
            txtVND_AMT.Text = "";
			if(! previous_check) return;


			string factory = cmb_factory.SelectedValue.ToString();
			string in_ymd = dpick_inYmd.Value.ToString("yyyyMMdd");
			string in_no = cmb_inNo.SelectedValue.ToString();
			string this_factory = ClassLib.ComVar.This_Factory;

		
			DataTable dt_ret = Select_SBI_IN(factory, in_ymd, in_no, this_factory); 
			Display_Grid(dt_ret); 
			dt_ret.Dispose();
            Add_Row_Total();

			// 자재 재고 마감 여부 체크 후 버튼 권한 관리
			Check_Closing_Process();



		}


		/// <summary>
		/// 
		/// </summary>
        /// 
        private void Add_Row_Total()
        {
            //fgrid_main.Rows.InsertNode(fgrid_main.Rows.Count, -1);
            
            //fgrid_main.Rows[fgrid_main.Rows.Count - 1][2] = "TOTAL";

            txtUSD_AMT.Text = "";
            txtVND_AMT.Text = "";
            decimal VND_PRICE = 0;
            decimal USD_PRICE = 0;
            int QTY = 0;
            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(fgrid_main.Rows[i][1]) == 0)
                {
                    VND_PRICE = VND_PRICE + (Convert.ToDecimal(fgrid_main.Rows[i][(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE]) * Convert.ToInt32(fgrid_main.Rows[i][(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_QTY]));
                    USD_PRICE = USD_PRICE + (Convert.ToDecimal(fgrid_main.Rows[i][(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_CURRENCY]) * Convert.ToInt32(fgrid_main.Rows[i][(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_QTY]));
                    QTY = QTY + Convert.ToInt32(fgrid_main.Rows[i][(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_QTY]);
                }
            }

            txtUSD_AMT.Text = string.Format("{0:0,0.0000}", USD_PRICE);
            txtVND_AMT.Text = string.Format("{0:0,0}", VND_PRICE);
            //fgrid_main.Rows[fgrid_main.Rows.Count - 1][(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_CURRENCY] = VND_PRICE;
            //fgrid_main.Rows[fgrid_main.Rows.Count - 1][(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE] = USD_PRICE;
            //fgrid_main.Rows[fgrid_main.Rows.Count - 1][(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_QTY] = QTY;
            //fgrid_main.Rows[fgrid_main.Rows.Count - 1].AllowEditing = false;
        }
        private void Event_Tbtn_Save()
		{


			//---------------------------------------------------------------------------------------------------------------------------------------------
			// 행 수정상태 해제
			//---------------------------------------------------------------------------------------------------------------------------------------------
			fgrid_main.Select(fgrid_main.Selection.r1, fgrid_main.Selection.c1, fgrid_main.Selection.r1, fgrid_main.Selection.c1, false); 
			//---------------------------------------------------------------------------------------------------------------------------------------------


			//---------------------------------------------------------------------------------------------------------------------------------------------
			// 조회조건의 필수입력 체크
			//---------------------------------------------------------------------------------------------------------------------------------------------
            C1.Win.C1List.C1Combo[] cmb_array = { cmb_factory, cmb_inType, cmb_purDiv, cmb_buyDiv, cmb_PayDiv }; ;
            System.Windows.Forms.TextBox[] txt_array = { txt_invNo };
			bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);
            bool Check_Cust = Check_Cust_Code();
			if(! previous_check) return;
            if (!Check_Cust) return;
            if (Convert.ToDecimal(txtChangeRate.Text) == 0 || txtChangeRate.Text == "")
            {
                MessageBox.Show("Exchange Rate don't have , Please contact Purchase Dept to get new Rate !!!");
                return;
            }
            
			DialogResult result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
			if(result == DialogResult.No) return;
			//---------------------------------------------------------------------------------------------------------------------------------------------


			//---------------------------------------------------------------------------------------------------------------------------------------------
			// 입고 TYPE이 '3'(RETURN)인 경우 반품이므로 - 값으로 처리
			//--------------------------------------------------------------------------------------------------------------------------------------------- 
			if(cmb_inType.SelectedIndex != -1 && cmb_inType.SelectedValue.ToString() == "3")
			{

				for(int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
				{

					if(decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_QTY].ToString() ) > 0)
					{

						ClassLib.ComFunction.User_Message("If select incoming type [Return], then you input data - (minus) value.");
						return;

					} // end if

				} // end for i


			} // end if
			//---------------------------------------------------------------------------------------------------------------------------------------------


			//---------------------------------------------------------------------------------------------------------------------------------------------
			// 저장
			//--------------------------------------------------------------------------------------------------------------------------------------------- 
			// 1. document no 
    
			string in_no_new = "";

			if(cmb_inNo.SelectedIndex == -1)
			{
				string factory = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
				string doc_division = ClassLib.ComVar.INCOMING;
				string doc_type = ClassLib.ComFunction.Empty_Combo(cmb_inType, "");
				string doc_date = dpick_inYmd.Value.ToString("yyyyMMdd");
				string upd_user = ClassLib.ComVar.This_User;
						 
				DataTable dt_ret = ClassLib.ComFunction.SELECT_DOCUMENT_NO(factory, doc_division, doc_type, doc_date, upd_user);  

				if(dt_ret == null || dt_ret.Rows.Count == 0)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}


				in_no_new = dt_ret.Rows[0].ItemArray[0].ToString().Trim();
				dt_ret.Dispose();

			}
			else
			{
				in_no_new = cmb_inNo.SelectedValue.ToString().Trim();
			}


			bool save_flag;
			// 2. tail
			if (ClassLib.ComFunction.Empty_Combo(cmb_factory, "") == "VJ")
				save_flag = SAVE_SBI_IN_TAIL_VJ_NEW(in_no_new);
			else
				save_flag = Save_SBI_IN_TAIL(in_no_new);		

			if(save_flag)
			{ 

				// 3. head
				save_flag = Save_SBI_IN_HEAD(in_no_new, false, false);

				if(save_flag)
				{ 

					// 4. db apply
					DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

					if(ds_ret == null)
					{

						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						return;

					}
					else
					{

						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);

						Init_Control_cmb_InNo();
						cmb_inNo.SelectedValue = in_no_new;

					}


				}
				else
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;

				}  // end if save_flag = Save_SBI_IN_HEAD(in_no_new, false, false);


			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				return;

			} // end if save_flag = Save_SBI_IN_TAIL(in_no_new);


			//--------------------------------------------------------------------------------------------------------------------------------------------- 

  


 

			
		}
		 

		/// <summary>
		/// 
		/// </summary>
        /// 
        private bool Check_Cust_Code()
        {
            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count - 1; i++)
            {
                if (fgrid_main.Rows[i][(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCUST_CD] == null)
                {
                    MessageBox.Show("No have Cust Code at Row " + i);
                    return false;
                }
            }
            return true;
        }


		private void Event_Tbtn_Delete()
		{

			//---------------------------------------------------------------------------------------------------------------------------------------------
			// 행 수정상태 해제
			//---------------------------------------------------------------------------------------------------------------------------------------------
			fgrid_main.Select(fgrid_main.Selection.r1, fgrid_main.Selection.c1, fgrid_main.Selection.r1, fgrid_main.Selection.c1, false); 
			//---------------------------------------------------------------------------------------------------------------------------------------------


			//---------------------------------------------------------------------------------------------------------------------------------------------
			// 조회조건의 필수입력 체크
			//---------------------------------------------------------------------------------------------------------------------------------------------
			C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_inNo}; 
			System.Windows.Forms.TextBox[] txt_array = {}; 
			bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array); 
			if(! previous_check) return;



			DialogResult result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete, this);
			if(result == DialogResult.No) return;
			//---------------------------------------------------------------------------------------------------------------------------------------------

 

			//---------------------------------------------------------------------------------------------------------------------------------------------
			// 저장
			//---------------------------------------------------------------------------------------------------------------------------------------------  
			bool save_flag = Save_SBI_IN_HEAD(cmb_inNo.SelectedValue.ToString(), true, true);

			if(save_flag)
			{ 

				//  db apply
				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

				if(ds_ret == null)
				{

					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotDelete, this);
					return;

				}
				else
				{

					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndDelete, this);

					Init_Control_cmb_InNo();

				}


			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				return;

			}

 
			//--------------------------------------------------------------------------------------------------------------------------------------------- 



		}


		/// <summary>
		/// 
		/// </summary>
		private void Event_Tbtn_Confirm()
		{

			//---------------------------------------------------------------------------------------------------------------------------------------------
			// 조회조건의 필수입력 체크
			//---------------------------------------------------------------------------------------------------------------------------------------------
			C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_inNo}; 
			System.Windows.Forms.TextBox[] txt_array = {}; 
			bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array); 
			if(! previous_check) return;
			//---------------------------------------------------------------------------------------------------------------------------------------------


			//---------------------------------------------------------------------------------------------------------------------------------------------
			// 그리드의 필수입력 체크
			//---------------------------------------------------------------------------------------------------------------------------------------------
			// int_array 에 정의된 컬럼 데이타를 체크하여 null인경우 해당 컬럼으로 커서를 이동
			int[] int_array = {(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_QTY,
										(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_CURRENCY,
										(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE,
										(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCUST_CD,
										(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxWH_CD};

			bool essential_check = ClassLib.ComFunction.EmptyCellCheck(fgrid_main, int_array);
			if(essential_check) return;
			//---------------------------------------------------------------------------------------------------------------------------------------------


			//---------------------------------------------------------------------------------------------------------------------------------------------
			//저장되지 않은 데이터 있을 때 조회하면 경고 메시지 표시
			//---------------------------------------------------------------------------------------------------------------------------------------------
			bool exist_modify = Check_NotSave_Data("Confirm");
			if(exist_modify) return;
			//---------------------------------------------------------------------------------------------------------------------------------------------



			DialogResult result = ClassLib.ComFunction.Data_Message("Confirm", ClassLib.ComVar.MgsChooseRun, this);
			if(result == DialogResult.No) return;


			string factory = cmb_factory.SelectedValue.ToString();
			string in_no = cmb_inNo.SelectedValue.ToString();
			string in_status = "C";
			string confirm_yn = "Y";

			bool save_flag = Save_SBI_IN_CONFIRM(factory, in_no, in_status, confirm_yn);

			if(save_flag)
			{

 
				// 회계 연결 전표 위한 데이터 제공 
				bool save_acc_flag = false;


				if(ClassLib.ComVar.This_Factory == "QD")
				{

					this.Cursor = Cursors.WaitCursor; 

					save_acc_flag = Save_SBI_ACCOUNT_INF(factory, in_no); 

					

				} 
				else
				{
					save_acc_flag = true;

				}// end if(ClassLib.ComVar.This_Factory == "QD")

					  
				this.Cursor = Cursors.Default;


				if(save_acc_flag)
				{
				  
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);

					Event_Tbtn_Search();

				}
				else
				{
					ClassLib.ComFunction.Data_Message("Account", ClassLib.ComVar.MgsDoNotRun, this);
					return;

				} // end if save_acc_flag = SAVE_SBI_ACCOUNT_INF(); 

 
			}
			else
			{
				ClassLib.ComFunction.Data_Message("Confirm", ClassLib.ComVar.MgsDoNotRun, this);
				return;
			
			} // end if save_flag = Save_SBI_IN_CONFIRM();




		}




		/// <summary>
		/// Check_NotSave_Data : 저장되지 않은 데이터 있을 때 조회하면 경고 메시지 표시
		/// </summary>
		private bool Check_NotSave_Data(string arg_part_message)
		{
			
			bool exist_modify = false;

			if (fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
			{
				
				string vTemp = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0).Clip.Replace("\r", "");
	
				if (vTemp.Length > 0)
				{
					if (MessageBox.Show(this, "Exist modify data. Do you want " + arg_part_message + "?", arg_part_message, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
					{
						exist_modify = true;
					}
				}// end if (vTemp.Length > 0)
			}
			 

			return exist_modify;
		} 




		private void Event_Tbtn_Print()
		{


			// 조회시 필수조건 체크 
			C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_inNo}; 
			System.Windows.Forms.TextBox[] txt_array = {};  
			bool previous_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array); 
			if(! previous_check) return; 

			 
			string sDir = ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Overseas");

			string sPara  = " /rp ";
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_factory, "") +		"' ";
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_inNo, "") +		"' ";
			sPara += "'" + dpick_inYmd.Value.ToString("yyyyMMdd") +		"' ";
			sPara += "'" + ClassLib.ComVar.This_Factory +		"' ";
			FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "Material Incoming List (Overseas)";
			MyReport.Show();	


		}



		#region Event_Tbtn_Search



		/// <summary>
		/// Display_Grid : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Grid(DataTable arg_dt)
		{

			Event_Tbtn_New(false);



			if(arg_dt.Rows.Count == 0) return;

			//-------------------------------------------------------------------------------------------------------------------------------------------------
			// head
			//-------------------------------------------------------------------------------------------------------------------------------------------------

			//			cmb_factory.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxFACTORY - 1].ToString();	
			//			cmb_inNo.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_NO - 1].ToString();	
			//			dpick_inYmd.Text = MyComFunction.ConvertDate2Type(arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_YMD - 1].ToString() );	
			
			cmb_inType.SelectedValue	= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_TYPE - 1].ToString();
			cmb_purDiv.SelectedValue	= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_DIV - 1].ToString();		
			cmb_buyDiv.SelectedValue    = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxBUY_DIV - 1].ToString();
            cmb_PayDiv.SelectedValue    = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPAY_DIV - 1].ToString();
            txtChangeRate.Text          = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxEX_RATE - 1].ToString();	
			cmb_inSize.SelectedValue    = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_SIZE - 1].ToString();  
			
			// btn_sizeSearch Enalbed setting
			btn_sizeSearch.Enabled = (arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_SIZE - 1].ToString().Trim().Equals("Y") ) ? true : false;

			txt_inStatus.Text = ( arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_STATUS - 1].ToString().Trim().Equals("C") ) ? ClassLib.ComVar.Status_CONFIRM : ClassLib.ComVar.Status_SAVE;	
			txt_lcNo.Text	= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLC_NO - 1].ToString();	
			txt_invNo.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxINV_NO - 1].ToString();	
			txt_remarks.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxREMARKS - 1].ToString();	



			//-------------------------------------------------------------------------------------------------------------------------------------------------
			// detail
			//-------------------------------------------------------------------------------------------------------------------------------------------------
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{

				int level = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxTREE_LEVEL - 1].ToString() );
				fgrid_main.Rows.InsertNode(fgrid_main.Rows.Count, level);

				fgrid_main[fgrid_main.Rows.Count - 1, 0] = "";

				for(int j = (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxTREE_LEVEL; j <= (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCOLOR_CD; j++)
				{

					fgrid_main[fgrid_main.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();

				} // end for j


				CellRange cr = fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, 1, fgrid_main.Rows.Count - 1, fgrid_main.Cols.Count - 1);

				if(level == _LevelHead)
				{
					cr.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;	
					//fgrid_main.Rows[fgrid_main.Rows.Count - 1].AllowEditing = false; 
				}
				else
				{
					cr.StyleNew.BackColor = Color.Empty;
					//fgrid_main.Rows[fgrid_main.Rows.Count - 1].AllowEditing = true; 
				}

			} // end for i
			//-------------------------------------------------------------------------------------------------------------------------------------------------

 
			fgrid_main.Tree.Show(_LevelHead);
			fgrid_main.Tree.Style = TreeStyleFlags.Complete;
			fgrid_main.Tree.Column = (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxDESC1; 


		}



		/// <summary>
		/// Display_Grid_Add : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Grid_Add(DataTable arg_dt)
		{
 

			if(arg_dt.Rows.Count == 0) return;



			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{

				int level = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxTREE_LEVEL - 1].ToString() );
				//fgrid_main.Rows.InsertNode(fgrid_main.Rows.Count, level);
				
				fgrid_main.Rows.Add();

				fgrid_main[fgrid_main.Rows.Count - 1, 0] = "I";

				for(int j = (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxTREE_LEVEL; j <= (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCOLOR_CD; j++)
				{

					fgrid_main[fgrid_main.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();

				} // end for j
                if (Convert.ToString(arg_dt.Rows[i][(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_CURRENCY - 1]) == "USD")
                {
                    fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_CURRENCY] = arg_dt.Rows[i][(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE - 1];
                    fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE] = Math.Round(Convert.ToDecimal(arg_dt.Rows[i][(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE - 1]) * Convert.ToDecimal(txtChangeRate.Text), 0);
                }
                else if (Convert.ToString(arg_dt.Rows[i][(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_CURRENCY - 1]) == "VND")
                {
                    fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE] = arg_dt.Rows[i][(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE - 1];
                    fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_CURRENCY] = Math.Round(Convert.ToDecimal(arg_dt.Rows[i][(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE - 1]) / Convert.ToDecimal(txtChangeRate.Text), 4);
                }

				CellRange cr = fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, 1, fgrid_main.Rows.Count - 1, fgrid_main.Cols.Count - 1);

				if(level == _LevelHead)
				{
					cr.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;	
					//fgrid_main.Rows[fgrid_main.Rows.Count - 1].AllowEditing = false; 
				}
				else
				{
					cr.StyleNew.BackColor = Color.Empty;
					//fgrid_main.Rows[fgrid_main.Rows.Count - 1].AllowEditing = true; 
				}



				fgrid_main.Rows[fgrid_main.Rows.Count - 1].IsNode = true;
				fgrid_main.Rows[fgrid_main.Rows.Count - 1].Node.Level = level;



			} // end for i 

 
			//fgrid_main.Tree.Show(_LevelHead);
//			fgrid_main.Tree.Style = TreeStyleFlags.Complete;
//			fgrid_main.Tree.Column = (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxDESC1; 


			fgrid_main.TopRow = fgrid_main.Rows.Count - 1 - arg_dt.Rows.Count;




		}



		#endregion


		#endregion 

		#region 그리드 이벤트 메서드


		/// <summary>
		/// Event_fgrid_main_BeforeEdit : 
		/// </summary>
		private void Event_fgrid_main_BeforeEdit()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
			{
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
			}

		}


		/// <summary>
		/// Event_fgrid_main_AfterEdit : 
		/// </summary>
		private void Event_fgrid_main_AfterEdit()
		{


			int sel_row = fgrid_main.Rows[fgrid_main.Row].Index;  
			int sel_col = fgrid_main.Cols[fgrid_main.Col].Index;


            
			foreach (int i in fgrid_main.Selections)
			{
 

				// 상위 아이템별 입고 수량 자동 계산 : 합계 처리(in_qty), 동일 데이터 처리
				if (fgrid_main.Rows[i].AllowEditing && fgrid_main.Rows[i].Node.Level == _LevelDetail)
				{
					

					C1.Win.C1FlexGrid.Node parent_node = fgrid_main.Rows[i].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent);
					int first_child_row = parent_node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.FirstChild).Row.Index;
					int last_child_row = parent_node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.LastChild).Row.Index;


                    if (sel_col == (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_CURRENCY)
                    {
                        fgrid_main.Rows[sel_row][(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE] =Math.Round(Convert.ToDecimal(fgrid_main.Rows[sel_row][sel_col]) * Convert.ToDecimal(txtChangeRate.Text),0);
                    }
                    if (sel_col == (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE)
                    {
                        fgrid_main.Rows[sel_row][(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_CURRENCY] = Math.Round(Convert.ToDecimal(fgrid_main.Rows[sel_row][sel_col]) / Convert.ToDecimal(txtChangeRate.Text),4);
                    }
                    Add_Row_Total();
					if(sel_col == (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_QTY)
					{
						//------------------------------------------------------------------------------------------------------------------------------------------- 
						decimal in_qty = 0;
						decimal sum_child_in_qty = 0;

						for(int a = first_child_row; a <= last_child_row; a++)
						{

							if(fgrid_main[a, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_QTY] == null || fgrid_main[a, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_QTY].ToString().Trim().Equals("") )
							{
								in_qty = 0;
							}
							else
							{
								//in_qty = Convert.ToInt32(fgrid_main[a, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_QTY].ToString().Trim() );
								in_qty = decimal.Parse(fgrid_main[a, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_QTY].ToString().Trim() );
							}

							sum_child_in_qty += in_qty;

						} // end for a
 


						fgrid_main[parent_node.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_QTY] = sum_child_in_qty.ToString(); 
						//-------------------------------------------------------------------------------------------------------------------------------------------
					}
//					else
//					{
//
//						fgrid_main[parent_node.Row.Index, sel_col] = fgrid_main[first_child_row, sel_col].ToString();
//
//					}



					fgrid_main.Update_Row(i);
					fgrid_main.Update_Row(parent_node.Row.Index);



				} // end if(level == level_detail)
				// head 일때, 수량은 적절 배분, 나머지는 동일 할당
				else if (fgrid_main.Rows[i].AllowEditing && fgrid_main.Rows[i].Node.Level == _LevelHead)
				{

					// 입고 수량
					if(sel_col == (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_QTY)
					{
						Grid_QtyCalculation(i, sel_col);
					}
					// 기타
					else
					{

//						for(int a = fgrid_main.Rows[i].Node.GetNode(NodeTypeEnum.FirstChild).Row.Index; a <= fgrid_main.Rows[i].Node.GetNode(NodeTypeEnum.LastChild).Row.Index; a++)
//						{
//							fgrid_main[a, sel_col] = fgrid_main[i, sel_col].ToString();
//						} // end for a
						 
						fgrid_main[i, sel_col] = (fgrid_main[fgrid_main.Rows[i].Node.GetNode(NodeTypeEnum.FirstChild).Row.Index, sel_col] == null) 
															? "" : fgrid_main[fgrid_main.Rows[i].Node.GetNode(NodeTypeEnum.FirstChild).Row.Index, sel_col].ToString();

					} // end if




				}


			} // end foreach


		}



		/// <summary>
		/// Grid_QtyCalculation : 
		/// </summary>
		/// <param name="arg_row"></param>
		/// <param name="arg_col"></param>
		private void Grid_QtyCalculation(int arg_row, int arg_col)
		{
			try
			{
				int vStartRow	= arg_row + 1;
				Node vNode = fgrid_main.Rows[arg_row].Node.GetNode(NodeTypeEnum.NextSibling);
				int vEndRow = (vNode == null) ? fgrid_main.Rows.Count : vNode.Row.Index;


				double vNewQty = Convert.ToDouble(fgrid_main[arg_row, arg_col]);
				int vSumQty	= 0;
				int vTempQty = 0;


				// 수정 전 총 수량이 0 인 경우는 균등 일괄 분배
				if(Convert.ToDouble(fgrid_main.Buffer_CellData) == 0)
				{
					vTempQty = Convert.ToInt32(vNewQty) / ( (vEndRow - 1) - vStartRow + 1);

					for(int vRow = vStartRow ; vRow < vEndRow ; vRow++)
					{
						fgrid_main[vRow, arg_col] = vTempQty;
						vSumQty += vTempQty;

						fgrid_main.Update_Row(vRow);
					} // end for vRow


				}
				// 할당된 수량 비율로 분배
				else
				{

					for(int vRow = vStartRow ; vRow < vEndRow ; vRow++)
					{

						double vCurQty = Convert.ToDouble(fgrid_main[vRow, arg_col]);

						vCurQty = (vCurQty == 0) ? 1 : vCurQty;

						vTempQty = Convert.ToInt32((vCurQty / Convert.ToDouble(fgrid_main.Buffer_CellData) ) * vNewQty);


						fgrid_main[vRow, arg_col] = Convert.ToInt32(vTempQty);
						vSumQty += vTempQty;

						fgrid_main.Update_Row(vRow);

					}  // end for vRow
 
					
				} // end if(Convert.ToDouble(fgrid_main.Buffer_CellData) == 0)

 

				if ( vSumQty != vNewQty )
				{
					double vDiv = (vSumQty - vNewQty);

					for (int vRow2 = vEndRow - 1 ; vRow2 >= vStartRow ; vRow2--)
					{ 
						if (Convert.ToInt32(fgrid_main[vRow2, arg_col]) >= vDiv)
						{
							fgrid_main[vRow2, arg_col] = Convert.ToInt32(fgrid_main[vRow2, arg_col]) - vDiv;
							break;
						}
						else
						{
							vDiv = vDiv - Convert.ToInt32(fgrid_main[vRow2, arg_col]);
							fgrid_main[vRow2, arg_col] = 0;
						} 

					} // end for vRow2
				} // if ( vSumQty != vNewQty )



				
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Grid_QtyCalculation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}



		
		/// <summary>
		/// Event_fgrid_main_DoubleClick : 
		/// </summary>
		private void Event_fgrid_main_DoubleClick()
		{
		}


  
		#endregion

		#region 버튼 및 기타 이벤트 메서드

	 

		/// <summary>
		/// Event_cmb_factory_SelectedValueChanged : 
		/// </summary>
		private void Event_cmb_factory_SelectedValueChanged()
		{


			if(cmb_factory.SelectedIndex == -1) return;


			Event_Tbtn_New(true);




			string factory = cmb_factory.SelectedValue.ToString();


			// size yn set    cmb_inSize
			DataTable dt_ret = ClassLib.ComVar.Select_ComCode(factory, ClassLib.ComVar.CxUseYN);  // "SBC00"
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_inSize, 1, 2, false, COM.ComVar.ComboList_Visible.Code_Name);  
			cmb_inSize.SelectedIndex = -1;

			// pur_div set    cmb_purDiv
			dt_ret = ClassLib.ComVar.Select_ComCode(factory, ClassLib.ComVar.CxReqReason);  // "SBM07"
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_purDiv, 1, 2, false, COM.ComVar.ComboList_Visible.Code_Name);   
			cmb_purDiv.SelectedIndex = -1;

			// buy_div set    cmb_buyDiv
			dt_ret = ClassLib.ComVar.Select_ComCode(factory, ClassLib.ComVar.CxPurDiv);  // "SBC01"
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_buyDiv, 1, 2, false, COM.ComVar.ComboList_Visible.Code_Name);    
			cmb_buyDiv.SelectedIndex = -1;

			// pay_div set    cmb_PayDiv
			dt_ret = ClassLib.ComVar.Select_ComCode(factory, "SIM08");  // "SBC01"
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_PayDiv, 1, 2, false, COM.ComVar.ComboList_Visible.Code_Name);    
			cmb_PayDiv.SelectedIndex = -1;


			// in_type set    cmb_inType
			dt_ret = ClassLib.ComVar.Select_ComCode(factory, ClassLib.ComVar.CxInType);  // "SBI01"
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_inType, 1, 2, false, COM.ComVar.ComboList_Visible.Code_Name);   
			cmb_inType.SelectedIndex = -1;


			// 자재 재고 마감 여부 체크 후 버튼 권한 관리
			Check_Closing_Process();


			// in_no
			Init_Control_cmb_InNo();

			dt_ret.Dispose();



		}


		/// <summary>
		/// Check_Closing_Process : 자재 재고 마감 여부 체크
		/// </summary>
		private void Check_Closing_Process()
		{


			string factory = cmb_factory.SelectedValue.ToString();
			string in_ymd = dpick_inYmd.Value.ToString("yyyyMM");

			DataTable dt_ret = ClassLib.ComFunction.Select_Close_Yn(factory, ClassLib.ComVar.Month, in_ymd, ClassLib.ComVar.Stock);

			if(dt_ret != null && dt_ret.Rows.Count > 0)
			{
				_Close_Flag = (dt_ret.Rows[0].ItemArray[0].ToString().Trim().Equals("Y") ) ? true : false;

				if(_Close_Flag)
				{
					ClassLib.ComFunction.User_Message("Already Closed Stock At This Month.", "Check_Closing_Process", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

			}
			else
			{
				_Close_Flag = false;
			}
 
 

			// button control
			Enable_ControlCheckProcess();



		}



		/// <summary>
		/// Enable_ControlCheckProcess : button control
		/// </summary>
		private void Enable_ControlCheckProcess()
		{

			if(_Close_Flag)   // 재고마감이 된 경우 조회를 제외한 모든 작업은 불가하다. 
			{
				 
				fgrid_main.AllowEditing = false;

				tbtn_Save.Enabled = false;
				tbtn_Delete.Enabled = false;
				tbtn_Confirm.Enabled	= false;
				
				btn_insert.Enabled = false;
				btn_cancel.Enabled = false;
				btn_recover.Enabled = false;

				btn_invoice.Enabled = false; 
				btn_purchase.Enabled	= false;
				btn_change.Enabled = false;

			}
			else
			{


				if (fgrid_main.Rows.Count > 0 && fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
				{
					tbtn_Confirm.Enabled  = true;
				}
				else
				{
					tbtn_Confirm.Enabled  = false;
				}
 




				// 확정된 상태
				if (txt_inStatus.Text.Trim() != "" && txt_inStatus.Text.Trim().Substring(0, 1) == "C") 
				{										 
					
					// 해당 입고번호에 따른 입고내역에 대한 모든 작업은 불가하다. 
					// 단, 신규로 입고번호를 부여하고 입고내역을 잡는 작업만 가능하다.

					fgrid_main.AllowEditing = false;

					tbtn_Save.Enabled = false;
					tbtn_Delete.Enabled = false;
					tbtn_Confirm.Enabled	= false;
				
					btn_insert.Enabled = false;
					btn_cancel.Enabled = false;
					btn_recover.Enabled = false;

					btn_invoice.Enabled = false; 
					btn_purchase.Enabled	= false;
					btn_change.Enabled = false;
  
				}
				else									
				{									
	
					// 저장된 상태
					// 모든 작업 가능하다.
					fgrid_main.AllowEditing = true;

					tbtn_Save.Enabled = true; 
					tbtn_Delete.Enabled = true;
					btn_insert.Enabled = true;
					btn_cancel.Enabled= true;
					btn_recover.Enabled= true;

					btn_invoice.Enabled = true; 
					btn_purchase.Enabled	= true;
					btn_change.Enabled = true;

				} // end if (txt_inStatus.Text.Trim() != "" && txt_inStatus.Text.Trim().Substring(0, 1) == "C") 

			} // end if(_Close_Flag)




		}



		/// <summary>
		/// Init_Control_cmb_InNo : in_no 할당
		/// </summary>
		private void Init_Control_cmb_InNo()
		{


			if(cmb_factory.SelectedIndex == -1) return;  

			Event_Tbtn_New(false);


			string factory = cmb_factory.SelectedValue.ToString();
			string in_ymd = dpick_inYmd.Value.ToString("yyyyMMdd");

			DataTable dt_ret = Select_In_No(factory, in_ymd);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_inNo, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
			dt_ret.Dispose();


		}




		/// <summary>
		/// Event_dpick_inYmd_CloseUp : 
		/// </summary>
        /// 
        
		private void Event_dpick_inYmd_CloseUp()
		{

			Init_Control_cmb_InNo();

			// 자재 재고 마감 여부 체크 후 버튼 권한 관리
			Check_Closing_Process();

		}



		/// <summary>
		/// 
		/// </summary>
		private void Event_btn_search()
		{

			FlexPurchase.Incoming.Pop_BI_Incoming_InNo pop_form = new FlexPurchase.Incoming.Pop_BI_Incoming_InNo();
			
			ClassLib.ComVar.Parameter_PopUp		= new string[1];
			ClassLib.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");

			pop_form.ShowDialog();

			if(ClassLib.ComVar.Parameter_PopUp == null || ClassLib.ComVar.Parameter_PopUp.Length == 1) return;

 
			cmb_factory.SelectedValue = ClassLib.ComVar.Parameter_PopUp[0];
			dpick_inYmd.Value = ClassLib.ComFunction.StringToDateTime(ClassLib.ComVar.Parameter_PopUp[1]);

			Init_Control_cmb_InNo();
			cmb_inNo.SelectedValue = ClassLib.ComVar.Parameter_PopUp[2];

			pop_form.Dispose();

		}


		/// <summary>
		/// 
		/// </summary>
		private void Event_btn_sizeSearch()
		{

			FlexPurchase.Incoming.Pop_BI_Incoming_InSize pop_form = new FlexPurchase.Incoming.Pop_BI_Incoming_InSize();
		
			ClassLib.ComVar.Parameter_PopUp		= new string[3];
			ClassLib.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			ClassLib.ComVar.Parameter_PopUp[1]	= dpick_inYmd.Value.ToString("yyyyMMdd");
			ClassLib.ComVar.Parameter_PopUp[2]	= ClassLib.ComFunction.Empty_Combo(cmb_inNo, "");

			pop_form.ShowDialog();
			pop_form.Dispose();

		}


		private void Event_btn_insert()
		{

			// Item을 팝업에서 선택하면 입고내역을 한줄 추가한다. 
			FlexBase.MaterialBase.Pop_Item_List pop_form = new FlexBase.MaterialBase.Pop_Item_List();
			pop_form.ShowDialog(); 
			 

			if (ClassLib.ComVar.Parameter_PopUp[0].Trim().Length < 1)
				return;

			//-----------------------------------------------------------------------------------------------------------------------------------------------
			// level 1 : item 별 데이터
			//----------------------------------------------------------------------------------------------------------------------------------------------- 
			int insert_row = fgrid_main.Rows.Count; 
			C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(insert_row, _LevelHead);


			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxFACTORY] = cmb_factory.SelectedValue.ToString();
			//fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.Ix] = vInSeq + 1 ;
			//fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_SEQ]	 = row +1 - fgrid_main.Rows.Fixed ;
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxITEM_CD]	= ClassLib.ComVar.Parameter_PopUp[0];
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxITEM_NAME]	= ClassLib.ComVar.Parameter_PopUp[1];
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSPEC_CD] = ClassLib.ComVar.Parameter_PopUp[2];
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSPEC_NAME]	= ClassLib.ComVar.Parameter_PopUp[3];
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCOLOR_CD] = ClassLib.ComVar.Parameter_PopUp[4];
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCOLOR_NAME] = ClassLib.ComVar.Parameter_PopUp[5];
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxUNIT] = ClassLib.ComVar.Parameter_PopUp[6]; 
   
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxDESC1] = ClassLib.ComVar.Parameter_PopUp[1];
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxDESC2] = ClassLib.ComVar.Parameter_PopUp[3];
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxDESC3] = ClassLib.ComVar.Parameter_PopUp[5];


			fgrid_main[newRow.Row.Index, 0] = ClassLib.ComVar.Insert;
			//fgrid_main.Rows[newRow.Row.Index].AllowEditing = false;
			fgrid_main.Rows[newRow.Row.Index].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
			//-----------------------------------------------------------------------------------------------------------------------------------------------
				

			//-----------------------------------------------------------------------------------------------------------------------------------------------
			// level 2 : style 별 데이터
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			insert_row = fgrid_main.Rows.Count; 
			newRow = fgrid_main.Rows.InsertNode(insert_row, _LevelDetail);


			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxFACTORY] = cmb_factory.SelectedValue.ToString();
			//fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.Ix] = vInSeq + 1 ;
			//fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_SEQ]	 = row +1 - fgrid_main.Rows.Fixed ;
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxITEM_CD]	= ClassLib.ComVar.Parameter_PopUp[0];
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxITEM_NAME]	= ClassLib.ComVar.Parameter_PopUp[1];
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSPEC_CD] = ClassLib.ComVar.Parameter_PopUp[2];
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSPEC_NAME]	= ClassLib.ComVar.Parameter_PopUp[3];
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCOLOR_CD] = ClassLib.ComVar.Parameter_PopUp[4];
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCOLOR_NAME] = ClassLib.ComVar.Parameter_PopUp[5];
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxUNIT] = ClassLib.ComVar.Parameter_PopUp[6]; 
   
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxDESC1] = "NONE";
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxDESC2] = "NONE";
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxDESC3] = "NONE-00";

			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSTYLE_CD] = "NONE";
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSTYLE_NAME] = "NONE";
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLOT_NO] = "NONE";
			fgrid_main[newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLOT_SEQ]	= "00";


			fgrid_main[newRow.Row.Index, 0] = ClassLib.ComVar.Insert;
			fgrid_main.Rows[newRow.Row.Index].StyleNew.BackColor = Color.White;

			fgrid_main.Select(newRow.Row.Index, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_QTY, true);  
			//-----------------------------------------------------------------------------------------------------------------------------------------------




			 

		}

		private void Event_btn_cancel()
		{

//			if (fgrid_main.Rows[fgrid_main.Row].Node.Level == _LevelDetail)
//			{
//				fgrid_main.Delete_Row();
//			}


			foreach (int sel_row in fgrid_main.Selections)
			{
//				if (fgrid_main.Rows[sel_row].AllowEditing && fgrid_main.Rows[sel_row].Node.Level == _LevelDetail)
//				{
					fgrid_main.Delete_Row(sel_row);
//				}
			} 



		}

		private void Event_btn_recover()
		{ 

			DialogResult message_result = ClassLib.ComFunction.User_Message("Do you want to recover?", "Recover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if(message_result == DialogResult.No) return;

			fgrid_main.Recover_Row();

				
		}

		private void Event_btn_purchase()
		{

//			ClassLib.ComVar.Parameter_PopUp	= new string[2];
//			ClassLib.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
//			ClassLib.ComVar.Parameter_PopUp[1]	= dpick_inYmd.Value.ToString("yyyyMMdd");
//
//			int[] checks = new int[]{(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSTYLE_CD, 
//													(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxITEM_CD, 
//													(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSPEC_CD,
//													(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCOLOR_CD, 
//													(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_NO};
//
//			Pop_BI_Incoming_Purchase pop_form = new Pop_BI_Incoming_Purchase("OVERSEAS", fgrid_main, checks); 
//			pop_form.Show();


			string factory = ClassLib.ComFunction.Empty_Combo(cmb_factory, ClassLib.ComVar.This_Factory);
			string in_ymd = dpick_inYmd.Value.ToString("yyyyMMdd");

			Pop_BI_Incoming_Purchase_Overseas pop_form = new Pop_BI_Incoming_Purchase_Overseas(fgrid_main, factory, in_ymd);
			pop_form.ShowDialog();

			if(pop_form._DT_Return == null) return;

			Display_Grid_Add(pop_form._DT_Return); 




		}

		private void Event_btn_invoice()
		{

			ClassLib.ComVar.Parameter_PopUp = new string[2];
			ClassLib.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			ClassLib.ComVar.Parameter_PopUp[1]	= dpick_inYmd.Value.ToString("yyyyMMdd");

			int[] checks = new int[]{(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSTYLE_CD, 
													(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxITEM_CD, 
													(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSPEC_CD,
													(int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCOLOR_CD};

			Pop_BI_Incoming_Invoice pop_form = new Pop_BI_Incoming_Invoice("OVERSEAS", fgrid_main, checks); 
			pop_form.Show();


		}

		private void Event_btn_change()
		{
		}




		#endregion
		
		#region 컨텍스트 메뉴 이벤트 메서드

  
		
		private void Event_menuItem_TreeViewHead()
		{
			fgrid_main.Tree.Show(_LevelHead);
		}

		private void Event_menuItem_TreeViewDetail()
		{
			fgrid_main.Tree.Show(_LevelDetail);
		}

		private void Event_menuItem_ValueChange()
		{

			if (! fgrid_main.AllowEditing || ! fgrid_main.Cols[fgrid_main.Col].AllowEditing) return;


			int sel_row = fgrid_main.Rows[fgrid_main.Row].Index;  
			int sel_col = fgrid_main.Cols[fgrid_main.Col].Index;  
			

			// 헤더 Description 
			if(sel_col == (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCUST_CD || sel_col == (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCUST_NAME)
			{
				
				COM.ComVar.Parameter_PopUp = new string[] { ClassLib.ComVar.Vendor }; 
				FlexBase.MaterialBase.Pop_SelectionChange_Box pop_form = new FlexBase.MaterialBase.Pop_SelectionChange_Box();
				pop_form.ShowDialog();

				// 0: name
				// 1: code
				
			}
			else
			{
				
				C1.Win.C1FlexGrid.CellRange cell = fgrid_main.GetCellRange(sel_row, sel_col); 
				string column_desc = fgrid_main[1, sel_col].ToString(); 
				FlexBase.MaterialBase.Pop_SelectionChange_FSP pop_form = new FlexBase.MaterialBase.Pop_SelectionChange_FSP(fgrid_main, cell, column_desc, false);
				pop_form.ShowDialog();

			}

			



			if (ClassLib.ComVar.Parameter_PopUp == null) return; 
				

			foreach (int i in fgrid_main.Selections)
			{
				if (fgrid_main.Rows[i].AllowEditing && fgrid_main.Rows[i].Node.Level == _LevelDetail)
				{
					

					if(sel_col == (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCUST_CD || sel_col == (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCUST_NAME)
					{
						fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCUST_NAME] = ClassLib.ComVar.Parameter_PopUp[0];
						fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCUST_CD] = ClassLib.ComVar.Parameter_PopUp[1];
					}
					else
					{
							fgrid_main[i, fgrid_main.Col] = ClassLib.ComVar.Parameter_PopUp[0];
					}


					fgrid_main.Update_Row(i);
				}
			} 




			// 아이템별 표시 레벨 데이터 자동 처리
			Event_fgrid_main_AfterEdit();

			 


		}

		private void Event_menuItem_RateExchange()
		{
 

			if (fgrid_main.Rows.Count <= fgrid_main.Rows.Fixed) return;
			if (! fgrid_main.AllowEditing || ! fgrid_main.Cols[fgrid_main.Col].AllowEditing) return;

			int sel_row = fgrid_main.Selection.r1;
			int sel_col = fgrid_main.Selection.c1;

			if(sel_col != (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_CURRENCY
				&& sel_col != (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_CURRENCY
				&& sel_col != (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_CURRENCY
				&& sel_col != (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_CURRENCY
				&& sel_col != (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_CURRENCY) return;
 

			int[] vSelectionRange = fgrid_main.Selections;

 
			Pop_BI_Incoming_Rate_Exchanger pop_changer = new Pop_BI_Incoming_Rate_Exchanger();

			COM.ComVar.Parameter_PopUp = new string[1];
			COM.ComVar.Parameter_PopUp[0]	= fgrid_main[sel_row, sel_col].ToString();

			pop_changer.ShowDialog();



			if (COM.ComVar.Parameter_PopUp == null) return;
			
			foreach (int i in vSelectionRange)
			{
				
				if (! fgrid_main.Rows[i].AllowEditing ) continue;
				if (fgrid_main.Rows[i].AllowEditing && fgrid_main.Rows[i].Node.Level != _LevelDetail) continue;


				string vCurKind = ClassLib.ComVar.Parameter_PopUp[0];

				decimal vRate, vPrice, vContPrice = 0; 

				switch (vCurKind)
				{
					case "00" :
						if (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_CURRENCY].ToString() == ClassLib.ComVar.Parameter_PopUp[1])
						{
							vRate		=	decimal.Parse(ClassLib.ComVar.Parameter_PopUp[3]);
							vPrice		=	decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE].ToString() == "" ? "0" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE].ToString());
							//vContPrice	=	decimal.Round(vRate * vPrice, 2);
							vContPrice	=	vPrice / vRate;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE]		= vContPrice;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_CURRENCY]	= ClassLib.ComVar.Parameter_PopUp[2];
						}
						if (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_CURRENCY].ToString() == ClassLib.ComVar.Parameter_PopUp[1])
						{
							vRate		=	decimal.Parse(ClassLib.ComVar.Parameter_PopUp[3]);
							vPrice		=	decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_PRICE].ToString() == "" ? "0" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_PRICE].ToString());
							//vContPrice	=	decimal.Round(vRate * vPrice, 2);
							vContPrice	=	vPrice / vRate;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_PRICE]		= vContPrice;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_CURRENCY]	= ClassLib.ComVar.Parameter_PopUp[2];
						}
						if (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_CURRENCY].ToString() == COM.ComVar.Parameter_PopUp[1])
						{
							vRate		=	decimal.Parse(ClassLib.ComVar.Parameter_PopUp[3]);
							vPrice		=	decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_PRICE].ToString() == "" ? "0" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_PRICE].ToString());
							//vContPrice	=	decimal.Round(vRate * vPrice, 2);
							vContPrice	=	vPrice / vRate;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_PRICE]		= vContPrice;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_CURRENCY]	= ClassLib.ComVar.Parameter_PopUp[2];
						}
						if (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_CURRENCY].ToString() == ClassLib.ComVar.Parameter_PopUp[1])
						{
							vRate		=	decimal.Parse(ClassLib.ComVar.Parameter_PopUp[3]);
							vPrice		=	decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_PRICE].ToString() == "" ? "0" :fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_PRICE].ToString());
							//vContPrice	=	decimal.Round(vRate * vPrice, 2);
							vContPrice	=	vPrice / vRate;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_PRICE]	= vContPrice;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_CURRENCY]	= ClassLib.ComVar.Parameter_PopUp[2];
						}
						if (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_CURRENCY].ToString() == COM.ComVar.Parameter_PopUp[1])
						{
							vRate		=	decimal.Parse(ClassLib.ComVar.Parameter_PopUp[3]);
							vPrice		=	decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_PRICE].ToString() == "" ? "0" :fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_PRICE].ToString());
							//vContPrice	=	decimal.Round(vRate * vPrice, 2);
							vContPrice	=	vPrice / vRate;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_PRICE]	= vContPrice;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_CURRENCY]	= ClassLib.ComVar.Parameter_PopUp[2];
						}
						break;

					case "10" :
						if (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_CURRENCY].ToString() == ClassLib.ComVar.Parameter_PopUp[1])
						{
							vRate		=	decimal.Parse(ClassLib.ComVar.Parameter_PopUp[3]);
							vPrice		=	decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE].ToString() == "" ? "0" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE].ToString());
							//vContPrice	=	decimal.Round(vRate * vPrice, 2);
							vContPrice	=	vPrice / vRate;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE]		= vContPrice;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_CURRENCY]	= ClassLib.ComVar.Parameter_PopUp[2];
						}
						break;

					case "20" :
						if (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_CURRENCY].ToString() == ClassLib.ComVar.Parameter_PopUp[1])
						{
							vRate		=	decimal.Parse(ClassLib.ComVar.Parameter_PopUp[3]);
							vPrice		=	decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_PRICE].ToString() == "" ? "0" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_PRICE].ToString());
							//vContPrice	=	decimal.Round(vRate * vPrice, 2);
							vContPrice	=	vPrice / vRate;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_PRICE]		= vContPrice;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_CURRENCY]	= ClassLib.ComVar.Parameter_PopUp[2];
						}
						break;

					case "30" :
						if (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_CURRENCY].ToString() == ClassLib.ComVar.Parameter_PopUp[1])
						{
							vRate		=	decimal.Parse(ClassLib.ComVar.Parameter_PopUp[3]);
							vPrice		=	decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_PRICE].ToString() == "" ? "0" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_PRICE].ToString());
							//vContPrice	=	decimal.Round(vRate * vPrice, 2);
							vContPrice	=	vPrice / vRate;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_PRICE]		= vContPrice;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_CURRENCY]	= ClassLib.ComVar.Parameter_PopUp[2];
						}
						break;

					case "40" :
						if (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_CURRENCY].ToString() == ClassLib.ComVar.Parameter_PopUp[1])
						{
							vRate		=	decimal.Parse(ClassLib.ComVar.Parameter_PopUp[3]);
							vPrice		=	decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_PRICE].ToString() == "" ? "0" :fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_PRICE].ToString());
							//vContPrice	=	decimal.Round(vRate * vPrice, 2);
							vContPrice	=	vPrice / vRate;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_PRICE]	= vContPrice;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_CURRENCY]	= ClassLib.ComVar.Parameter_PopUp[2];
						}
						break;

					case "50":
						if (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_CURRENCY].ToString() == ClassLib.ComVar.Parameter_PopUp[1])
						{
							vRate		=	decimal.Parse(ClassLib.ComVar.Parameter_PopUp[3]);
							vPrice		=	decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_PRICE].ToString() == "" ? "0" :fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_PRICE].ToString());
							//vContPrice	=	decimal.Round(vRate * vPrice, 2);
							vContPrice	=	vPrice / vRate;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_PRICE]	= vContPrice;
							fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_CURRENCY]	= ClassLib.ComVar.Parameter_PopUp[2];
						}
						break;
				}



				fgrid_main.Update_Row(i);
			

			} // end foreach (int i in vSelectionRange) 



			// 아이템별 표시 레벨 데이터 자동 처리 
			// 1. currency 컬럼 수정
			Event_fgrid_main_AfterEdit();
			// 2. 자동 계산된 price 컬럼 수정
			fgrid_main.Select(vSelectionRange[0], sel_col + 1, vSelectionRange[vSelectionRange.Length - 1], sel_col + 1, false);
			Event_fgrid_main_AfterEdit();


			pop_changer.Dispose();


		}


		#endregion
 
 

		#endregion   
		
		#region 이벤트 처리

		#region 툴바 이벤트


		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_New(true);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_New", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Search(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		} 

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Save();
                //Event_Tbtn_Search();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Delete(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}
		
		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Confirm(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Print(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}
 


		#endregion

		#region 그리드 이벤트

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			try
			{
				Event_fgrid_main_AfterEdit();
                
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_main_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			try
			{
				Event_fgrid_main_BeforeEdit();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_main_BeforeEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void fgrid_main_DoubleClick(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_fgrid_main_DoubleClick();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_main_DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}
	 
		


		#endregion

		#region 버튼 및 기타 이벤트


		#region 버튼 이미지 이벤트

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			}  

		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			}  
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			} 
		}

		#endregion

		 

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_cmb_factory_SelectedValueChanged();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 

		private void dpick_inYmd_CloseUp(object sender, System.EventArgs e)
		{
			try
			{
				Event_dpick_inYmd_CloseUp();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_dpick_inYmd_CloseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		private void cmb_inSize_SelectedValueChanged(object sender, System.EventArgs e)
		{
			
			try
			{  
				if(cmb_inSize.SelectedIndex == -1) return;

				btn_sizeSearch.Enabled = (cmb_inSize.SelectedValue.ToString().Trim().Equals("Y") ) ? true : false;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_inSize_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}
 
		private void cmb_inNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			
			try
			{
				
				this.Cursor = Cursors.WaitCursor;

				if(cmb_inNo.SelectedIndex == -1) return;


				Event_Tbtn_Search();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_inNo_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}

	
		private void btn_search_Click(object sender, System.EventArgs e)
		{

			try
			{
				
				this.Cursor = Cursors.WaitCursor;


				Event_btn_search();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}
		
		}

		private void btn_sizeSearch_Click(object sender, System.EventArgs e)
		{

			try
			{
				
				this.Cursor = Cursors.WaitCursor;


				Event_btn_sizeSearch();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_sizeSearch", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		} 

		private void btn_insert_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Event_btn_insert();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			
			try
			{ 
				Event_btn_cancel();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 
		
		private void btn_recover_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Event_btn_recover();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_recover", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void btn_purchase_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Event_btn_purchase();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_purchase", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 

		private void btn_invoice_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Event_btn_invoice();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_invoice", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void btn_change_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Event_btn_change();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_change", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

	

	

		#endregion   

		#region 컨텍스트 메뉴 이벤트


		private void menuItem_TreeViewHead_Click(object sender, System.EventArgs e)
		{

			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_menuItem_TreeViewHead(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_TreeViewHead", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void menuItem_TreeViewDetail_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_menuItem_TreeViewDetail(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_TreeViewDetail", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void menuItem_ValueChange_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_menuItem_ValueChange(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_ValueChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void menuItem_RateExchange_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_menuItem_RateExchange(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_RateExchange", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		#endregion

		#endregion
		 
		#region 디비 연결

		#region 콤보
  


		/// <summary>
		/// Select_In_No : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_in_ymd"></param>
		/// <returns></returns>
		private DataTable Select_In_No(string arg_factory, string arg_in_ymd)
		{

			try
			{

				DataSet ds_rert;

				MyOraDB.ReDim_Parameter(3);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBI_IN_NO.SELECT_SBI_IN_NO";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_IN_YMD";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_in_ymd;
				MyOraDB.Parameter_Values[2] = "";

				MyOraDB.Add_Select_Parameter(true);
				ds_rert = MyOraDB.Exe_Select_Procedure();

				if(ds_rert == null) return null;
				return ds_rert.Tables[MyOraDB.Process_Name];

			}
			catch
			{
				return null;
			}

		}


		#endregion

		#region 조회

		 
		/// <summary>
		/// Select_SBI_IN : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_in_ymd"></param>
		/// <param name="arg_in_no"></param>
		/// <param name="arg_this_factory"></param>
		/// <returns></returns>
		private DataTable Select_SBI_IN(string arg_factory, string arg_in_ymd, string arg_in_no, string arg_this_factory)
		{
			
			try
			{ 

				DataSet ds_ret;


                string process_name = "PKG_SBI_IN_OVERSEAS.SELECT_SBI_IN_OVERSEAS_NEW";

				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_IN_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_IN_NO";
				MyOraDB.Parameter_Name[3] = "ARG_THIS_FACTORY"; 
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor; 
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_in_ymd; 
				MyOraDB.Parameter_Values[2] = arg_in_no;  
				MyOraDB.Parameter_Values[3] = arg_this_factory; 
				MyOraDB.Parameter_Values[4] = ""; 

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

		#region 저장


	

		/// <summary>
		/// Save_SBI_IN_TAIL : 
		/// </summary>
		/// <param name="arg_in_no_new"></param>
		/// <returns></returns>
		private bool Save_SBI_IN_TAIL(string arg_in_no_new)
		{


			try
			{

				int col_ct = 46;  	
 

				MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_SBI_IN_OVERSEAS.SAVE_SBI_IN_TAIL_NEW";


				#region 파라미터 이름 설정

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0]    = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1]    = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[2]    = "ARG_IN_NO";
				MyOraDB.Parameter_Name[3]    = "ARG_IN_SEQ";
				MyOraDB.Parameter_Name[4]    = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[5]    = "ARG_SPEC_CD";
				MyOraDB.Parameter_Name[6]    = "ARG_COLOR_CD";
				MyOraDB.Parameter_Name[7]    = "ARG_IN_QTY";
				MyOraDB.Parameter_Name[8]    = "ARG_PK_UNIT_QTY";
				MyOraDB.Parameter_Name[9]    = "ARG_PUR_CURRENCY";
				MyOraDB.Parameter_Name[10]  = "ARG_PUR_PRICE";
				MyOraDB.Parameter_Name[11]  = "ARG_OUTSIDE_CURRENCY";
				MyOraDB.Parameter_Name[12]  = "ARG_OUTSIDE_PRICE";
				MyOraDB.Parameter_Name[13]  = "ARG_CBD_CURRENCY";
				MyOraDB.Parameter_Name[14]  = "ARG_CBD_PRICE";
				MyOraDB.Parameter_Name[15]  = "ARG_SHIP_CURRENCY";
				MyOraDB.Parameter_Name[16]  = "ARG_SHIP_PRICE";
				MyOraDB.Parameter_Name[17]  = "ARG_LEDGER_CURRENCY";
				MyOraDB.Parameter_Name[18]  = "ARG_LEDGER_PRICE";
				MyOraDB.Parameter_Name[19]  = "ARG_PRICE_YN";
				MyOraDB.Parameter_Name[20]  = "ARG_CUST_CD";
				MyOraDB.Parameter_Name[21]  = "ARG_TAX_CD";
				MyOraDB.Parameter_Name[22]  = "ARG_BAR_CODE";
				MyOraDB.Parameter_Name[23]  = "ARG_BAR_KIND";
				MyOraDB.Parameter_Name[24]  = "ARG_BAR_MOVE";
				MyOraDB.Parameter_Name[25]  = "ARG_CONT_NO";
				MyOraDB.Parameter_Name[26]  = "ARG_SHIP_YMD";
				MyOraDB.Parameter_Name[27]  = "ARG_SHIP_NO";
				MyOraDB.Parameter_Name[28]  = "ARG_SHIP_SEQ";
				MyOraDB.Parameter_Name[29]  = "ARG_SHIP_QTY";
				MyOraDB.Parameter_Name[30]  = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[31]  = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[32]  = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[33]  = "ARG_WH_CD";
				MyOraDB.Parameter_Name[34]  = "ARG_PAY_CD";
				MyOraDB.Parameter_Name[35]  = "ARG_PUR_NO";
				MyOraDB.Parameter_Name[36]  = "ARG_PUR_SEQ";
				MyOraDB.Parameter_Name[37]  = "ARG_PUR_USER";
				MyOraDB.Parameter_Name[38]  = "ARG_PUR_DEPT";
				MyOraDB.Parameter_Name[39]  = "ARG_IN_STATUS";
				MyOraDB.Parameter_Name[40]  = "ARG_MOD_QTY";
				MyOraDB.Parameter_Name[41]  = "ARG_TRAN_DIV";
				MyOraDB.Parameter_Name[42]  = "ARG_REMARKS";
				MyOraDB.Parameter_Name[43]  = "ARG_UPD_USER";
				MyOraDB.Parameter_Name[44]  = "ARG_PUR_DIV";
				MyOraDB.Parameter_Name[45]  = "ARG_BUY_DIV";
 
				#endregion

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 


				
				#region 파라미터 값에 저장할 배열

				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList(); 
 
  
				for(int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
				{

					if(fgrid_main.Rows[i].Node.Level != _LevelDetail) continue;
					if(fgrid_main[i, 0] == null || fgrid_main[i, 0].ToString().Trim().Equals("") ) continue;


					vList.Add(fgrid_main[i, 0].ToString() ); 
					vList.Add(ClassLib.ComFunction.Empty_Combo(cmb_factory, "") ); 
					vList.Add(arg_in_no_new); 
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_SEQ] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_SEQ].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxITEM_CD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxITEM_CD].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSPEC_CD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSPEC_CD].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCOLOR_CD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCOLOR_CD].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_QTY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_QTY].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPK_UNIT_QTY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPK_UNIT_QTY].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_CURRENCY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_CURRENCY].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_CURRENCY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_CURRENCY].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_PRICE] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_PRICE].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_CURRENCY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_CURRENCY].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_PRICE] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_PRICE].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_CURRENCY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_CURRENCY].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_PRICE] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_PRICE].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_CURRENCY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_CURRENCY].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_PRICE] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_PRICE].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPRICE_YN] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPRICE_YN].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCUST_CD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCUST_CD].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxTAX_CD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxTAX_CD].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxBAR_CODE] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxBAR_CODE].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxBAR_KIND] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxBAR_KIND].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxBAR_MOVE] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxBAR_MOVE].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCONT_NO] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCONT_NO].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_YMD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_YMD].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_NO] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_NO].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_SEQ] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_SEQ].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_QTY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_QTY].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLOT_NO] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLOT_NO].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLOT_SEQ] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLOT_SEQ].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSTYLE_CD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSTYLE_CD].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxWH_CD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxWH_CD].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPAY_CD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPAY_CD].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_NO] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_NO].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_SEQ] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_SEQ].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_USER] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_USER].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_DEPT] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_DEPT].ToString() ); 
					vList.Add("S");  // in_status
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxMOD_QTY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxMOD_QTY].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxTRAN_DIV] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxTRAN_DIV].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxREMARKS] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxREMARKS].ToString() );
					vList.Add(ClassLib.ComVar.This_User);  
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_DIV] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_DIV].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxBUY_DIV] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxBUY_DIV].ToString() );


				}

  
				#endregion
  
				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가  
				return true;


			}
			catch(Exception ex)
			{ 
				MessageBox.Show(ex.ToString() );
				return false;  
			} 




		}

		/// <summary>
		/// SAVE_SBI_IN_TAIL_VJ_NEW : 
		/// Updated by KE.Park 2009.02.12
		/// </summary>
		/// <param name="arg_in_no_new"></param>
		/// <returns></returns>
		private bool SAVE_SBI_IN_TAIL_VJ_NEW(string arg_in_no_new)
		{


			try
			{

				int col_ct = 47;  	
 

				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBI_IN_OVERSEAS.SAVE_SBI_IN_TAIL_VJ_NEW";


				#region 파라미터 이름 설정

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0]    = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1]    = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[2]    = "ARG_IN_NO";
				MyOraDB.Parameter_Name[3]    = "ARG_IN_SEQ";
				MyOraDB.Parameter_Name[4]    = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[5]    = "ARG_SPEC_CD";
				MyOraDB.Parameter_Name[6]    = "ARG_COLOR_CD";
				MyOraDB.Parameter_Name[7]    = "ARG_IN_QTY";
				MyOraDB.Parameter_Name[8]    = "ARG_PK_UNIT_QTY";
				MyOraDB.Parameter_Name[9]    = "ARG_PUR_PRICE_USD";
				MyOraDB.Parameter_Name[10]  = "ARG_PUR_PRICE_VND";
				MyOraDB.Parameter_Name[11]  = "ARG_OUTSIDE_CURRENCY";
				MyOraDB.Parameter_Name[12]  = "ARG_OUTSIDE_PRICE";
				MyOraDB.Parameter_Name[13]  = "ARG_CBD_CURRENCY";
				MyOraDB.Parameter_Name[14]  = "ARG_CBD_PRICE";
				MyOraDB.Parameter_Name[15]  = "ARG_SHIP_CURRENCY";
				MyOraDB.Parameter_Name[16]  = "ARG_SHIP_PRICE";
				MyOraDB.Parameter_Name[17]  = "ARG_LEDGER_CURRENCY";
				MyOraDB.Parameter_Name[18]  = "ARG_LEDGER_PRICE";
				MyOraDB.Parameter_Name[19]  = "ARG_PRICE_YN";
				MyOraDB.Parameter_Name[20]  = "ARG_CUST_CD";
				MyOraDB.Parameter_Name[21]  = "ARG_TAX_CD";
				MyOraDB.Parameter_Name[22]  = "ARG_BAR_CODE";
				MyOraDB.Parameter_Name[23]  = "ARG_BAR_KIND";
				MyOraDB.Parameter_Name[24]  = "ARG_BAR_MOVE";
				MyOraDB.Parameter_Name[25]  = "ARG_CONT_NO";
				MyOraDB.Parameter_Name[26]  = "ARG_SHIP_YMD";
				MyOraDB.Parameter_Name[27]  = "ARG_SHIP_NO";
				MyOraDB.Parameter_Name[28]  = "ARG_SHIP_SEQ";
				MyOraDB.Parameter_Name[29]  = "ARG_SHIP_QTY";
				MyOraDB.Parameter_Name[30]  = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[31]  = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[32]  = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[33]  = "ARG_WH_CD";
				MyOraDB.Parameter_Name[34]  = "ARG_PAY_CD";
				MyOraDB.Parameter_Name[35]  = "ARG_PUR_NO";
				MyOraDB.Parameter_Name[36]  = "ARG_PUR_SEQ";
				MyOraDB.Parameter_Name[37]  = "ARG_PUR_USER";
				MyOraDB.Parameter_Name[38]  = "ARG_PUR_DEPT";
				MyOraDB.Parameter_Name[39]  = "ARG_IN_STATUS";
				MyOraDB.Parameter_Name[40]  = "ARG_MOD_QTY";
				MyOraDB.Parameter_Name[41]  = "ARG_TRAN_DIV";
				MyOraDB.Parameter_Name[42]  = "ARG_REMARKS";
				MyOraDB.Parameter_Name[43]  = "ARG_UPD_USER";
				MyOraDB.Parameter_Name[44]  = "ARG_PUR_DIV";
				MyOraDB.Parameter_Name[45]  = "ARG_BUY_DIV";
				MyOraDB.Parameter_Name[46]  = "ARG_INV_NO";
 
				#endregion

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 


				
				#region 파라미터 값에 저장할 배열

				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList(); 
 
  
				for(int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
				{

					if(fgrid_main.Rows[i].Node.Level != _LevelDetail) continue;
					if(fgrid_main[i, 0] == null || fgrid_main[i, 0].ToString().Trim().Equals("") ) continue;


					vList.Add(fgrid_main[i, 0].ToString() ); 
					vList.Add(ClassLib.ComFunction.Empty_Combo(cmb_factory, "") ); 
					vList.Add(arg_in_no_new); 
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_SEQ] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_SEQ].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxITEM_CD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxITEM_CD].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSPEC_CD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSPEC_CD].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCOLOR_CD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCOLOR_CD].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_QTY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxIN_QTY].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPK_UNIT_QTY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPK_UNIT_QTY].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_CURRENCY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_CURRENCY].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_PRICE].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_CURRENCY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_CURRENCY].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_PRICE] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxOUTSIDE_PRICE].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_CURRENCY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_CURRENCY].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_PRICE] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCBD_PRICE].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_CURRENCY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_CURRENCY].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_PRICE] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_PRICE].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_CURRENCY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_CURRENCY].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_PRICE] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLEDGER_PRICE].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPRICE_YN] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPRICE_YN].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCUST_CD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCUST_CD].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxTAX_CD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxTAX_CD].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxBAR_CODE] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxBAR_CODE].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxBAR_KIND] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxBAR_KIND].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxBAR_MOVE] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxBAR_MOVE].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCONT_NO] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxCONT_NO].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_YMD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_YMD].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_NO] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_NO].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_SEQ] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_SEQ].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_QTY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSHIP_QTY].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLOT_NO] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLOT_NO].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLOT_SEQ] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxLOT_SEQ].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSTYLE_CD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxSTYLE_CD].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxWH_CD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxWH_CD].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPAY_CD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPAY_CD].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_NO] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_NO].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_SEQ] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_SEQ].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_USER] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_USER].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_DEPT] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_DEPT].ToString() ); 
					vList.Add("S");  // in_status
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxMOD_QTY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxMOD_QTY].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxTRAN_DIV] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxTRAN_DIV].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxREMARKS] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxREMARKS].ToString() );
					vList.Add(ClassLib.ComVar.This_User);  
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_DIV] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxPUR_DIV].ToString() );
					vList.Add( (fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxBUY_DIV] == null) ? "" : fgrid_main[i, (int)ClassLib.TBSBI_IN_OVERSEAS_VJ.IxBUY_DIV].ToString() );
					vList.Add(ClassLib.ComFunction.Empty_TextBox(txt_invNo, "") ); 

				}

  
				#endregion
  
				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가  
				return true;


			}
			catch(Exception ex)
			{ 
				MessageBox.Show(ex.ToString() );
				return false;  
			} 




		}





		/// <summary>
		/// Save_SBI_IN_HEAD : 
		/// </summary>
		/// <param name="arg_in_no_new"></param>
		/// <param name="arg_all_delete"></param>
		/// <param name="arg_para_clear"></param>
		/// <returns></returns>
		private bool Save_SBI_IN_HEAD(string arg_in_no_new, bool arg_all_delete, bool arg_para_clear)
		{


			try
			{

				int col_ct = 17;  	
 

				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBI_IN_OVERSEAS.SAVE_SBI_IN_HEAD_VJ";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1]  = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[2]  = "ARG_IN_NO";
				MyOraDB.Parameter_Name[3]  = "ARG_IN_YMD";
				MyOraDB.Parameter_Name[4]  = "ARG_IN_TYPE";
				MyOraDB.Parameter_Name[5]  = "ARG_PUR_DIV";
				MyOraDB.Parameter_Name[6]  = "ARG_BUY_DIV";
				MyOraDB.Parameter_Name[7]  = "ARG_IN_SIZE";
				MyOraDB.Parameter_Name[8]  = "ARG_LC_NO"; 
				MyOraDB.Parameter_Name[9]  = "ARG_INV_NO"; 
				MyOraDB.Parameter_Name[10] = "ARG_IN_STATUS";
				MyOraDB.Parameter_Name[11] = "ARG_CONFIRM_YN";
				MyOraDB.Parameter_Name[12] = "ARG_ACC_UPD_YN";
				MyOraDB.Parameter_Name[13] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[14] = "ARG_EXC_RATE";
                MyOraDB.Parameter_Name[15] = "ARG_PAY_DIV";
				MyOraDB.Parameter_Name[16] = "ARG_UPD_USER";   

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
 

				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList(); 
 
  
				string division = "";
				string in_no = ""; 

				in_no = ClassLib.ComFunction.Empty_Combo(cmb_inNo, "-1");

				if(in_no == "-1")
				{
					division = "I";
					in_no = arg_in_no_new;
				}
				else
				{ 

					if(arg_all_delete)
					{
						division = "D";
					}
					else
					{
						division = "U";
					}


				} // end if(in_no == "-1")
				
				


				vList.Add(division); 
				vList.Add(ClassLib.ComFunction.Empty_Combo(cmb_factory, "") ); 
				vList.Add(in_no); 
				vList.Add(dpick_inYmd.Value.ToString("yyyyMMdd") ); 
				vList.Add(ClassLib.ComFunction.Empty_Combo(cmb_inType, "") ); 
				vList.Add(ClassLib.ComFunction.Empty_Combo(cmb_purDiv, "") ); 
				vList.Add(ClassLib.ComFunction.Empty_Combo(cmb_buyDiv, "") ); 
				vList.Add(ClassLib.ComFunction.Empty_Combo(cmb_inSize, "") ); 
				vList.Add(ClassLib.ComFunction.Empty_TextBox(txt_lcNo, "") ); 
				vList.Add(ClassLib.ComFunction.Empty_TextBox(txt_invNo, "") ); 
				vList.Add("S");  // in_status
				vList.Add("N");  // confirm_yn
				vList.Add("");    // acc_upd_yn
				vList.Add(ClassLib.ComFunction.Empty_TextBox(txt_remarks, "") );
                vList.Add(Convert.ToString(txtChangeRate.Text).Replace(",",""));
                vList.Add(ClassLib.ComFunction.Empty_Combo(cmb_PayDiv, "")); 
				vList.Add(ClassLib.ComVar.This_User);  


 
  
				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				MyOraDB.Add_Modify_Parameter(arg_para_clear);		// 파라미터 데이터를 DataSet에 추가  
				return true;

			}
			catch(Exception ex)
			{ 
				MessageBox.Show(ex.ToString() );  
				return false;
			} 



		}




		/// <summary>
		/// Save_SBI_IN_CONFIRM : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_in_no"></param>
		/// <param name="arg_in_status"></param>
		/// <param name="arg_confirm_yn"></param>
		/// <returns></returns>
		private bool Save_SBI_IN_CONFIRM(string arg_factory, string arg_in_no, string arg_in_status, string arg_confirm_yn)
		{

			try
			{

				MyOraDB.ReDim_Parameter(5);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBI_IN_OVERSEAS.SAVE_SBI_IN_CONFIRM";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1]  = "ARG_IN_NO"; 
				MyOraDB.Parameter_Name[2]  = "ARG_IN_STATUS"; 
				MyOraDB.Parameter_Name[3]  = "ARG_CONFIRM_YN"; 
				MyOraDB.Parameter_Name[4]  = "ARG_UPD_USER";  


				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar; 


				//04.DATA 정의
				MyOraDB.Parameter_Values[0]  = arg_factory;
				MyOraDB.Parameter_Values[1]  = arg_in_no;
				MyOraDB.Parameter_Values[2]  = arg_in_status; 
				MyOraDB.Parameter_Values[3]  = arg_confirm_yn; 
				MyOraDB.Parameter_Values[4]  = ClassLib.ComVar.This_User; 

		
				MyOraDB.Add_Modify_Parameter(true); 
				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();			 
				
				if (ds_ret == null) return false; 
				return true;   		
				
			}
			catch 
			{  
				return false;
			}


		}
		


		/// <summary>
		/// Save_SBI_ACCOUNT_INF : 회계 연결 전표 위한 데이터 제공
		/// </summary> 
		/// <returns></returns>
		private bool Save_SBI_ACCOUNT_INF(string arg_factory, string arg_in_no)
		{

			try
			{

				MyOraDB.ReDim_Parameter(3);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBI_IN_ADJUST_ACC.SAVE_SBI_ACCOUNT_INF";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1]  = "ARG_IN_NO"; 
				MyOraDB.Parameter_Name[2]  = "ARG_UPD_USER"; 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0]  = arg_factory;
				MyOraDB.Parameter_Values[1]  = arg_in_no;
				MyOraDB.Parameter_Values[2]  = ClassLib.ComVar.This_User; 
		
				MyOraDB.Add_Modify_Parameter(true); 
				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();			 
				
				if (ds_ret == null) return false; 
				return true;   		
				
			}
			catch 
			{  
				return false;
			}


		}
		





		#endregion

		#endregion


		private void btn_Tree_Click(object sender, System.EventArgs e)
		{
			FlexPurchase.Shipping.Pop_BP_Purchase_Order_SearchType  sPop = new FlexPurchase.Shipping.Pop_BP_Purchase_Order_SearchType();
			if (sPop.ShowDialog() == DialogResult.OK)
			{
				if (COM.ComVar.Parameter_PopUp[0].Equals("01"))
				{
					Show_Tree_Popup();
				}
				else
				{
					Show_LLT_Item_Popup();
				}
			}
		}


		#region 자재 추가


		/// <summary>
		/// Show_Tree_Popup : 데이터 입력하는 팝업을 Tree로 실행
		/// </summary>
		private void Show_Tree_Popup()
		{
			try
			{
				int[] vChecks = new int[]{_styleCdCol, _itemCdCol, _specCdCol, _colorCdCol};
				ClassLib.ComVar.Parameter_PopUp = new string[]{COM.ComFunction.Empty_Combo(cmb_factory, COM.ComVar.This_Factory), "P"};
				FlexPurchase.Purchase.Pop_BC_Yield_Info  vPop = new FlexPurchase.Purchase.Pop_BC_Yield_Info(fgrid_main, vChecks);
				vPop.ShowDialog();

				if ( ClassLib.ComVar.Parameter_PopUpTable.Rows.Count > 0 && vPop.DialogResult == DialogResult.OK)
					Etc_SizeCalculation();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		private void Etc_SizeCalculation()
		{
			try
			{	
				_practicable = false;

				int vRowCount = ClassLib.ComVar.Parameter_PopUpTable.Rows.Count;			
				for(int i = 0 ; i < vRowCount; i++)
				{	
					int row = fgrid_main.Rows.Count;
					fgrid_main.Add_Row(row - 1);
					int vInSeq = 0;
					
					if (!row.Equals(fgrid_main.Rows.Fixed))
						vInSeq = int.Parse(fgrid_main[row -1, _inSeqCol].ToString());

					fgrid_main[row, (int)ClassLib.TBSBI_IN_TAIL.IxFACTORY] = cmb_factory.SelectedValue;
					fgrid_main[row, _inSeqCol]		= vInSeq + 1 ;
					fgrid_main[row, _seqCol]		= row +1 - fgrid_main.Rows.Fixed ;

					fgrid_main[row, _itemCdCol]		= ClassLib.ComVar.Parameter_PopUpTable.Rows[i][0].ToString();
					fgrid_main[row, _itemNameCol]	= ClassLib.ComVar.Parameter_PopUpTable.Rows[i][1].ToString();
					fgrid_main[row, _specCdCol]		= ClassLib.ComVar.Parameter_PopUpTable.Rows[i][2].ToString();
					fgrid_main[row, _specNameCol]	= ClassLib.ComVar.Parameter_PopUpTable.Rows[i][3].ToString();
					fgrid_main[row, _colorCdCol]	= ClassLib.ComVar.Parameter_PopUpTable.Rows[i][4].ToString();
					fgrid_main[row, _colorNameCol]	= ClassLib.ComVar.Parameter_PopUpTable.Rows[i][5].ToString();
					fgrid_main[row, _unitCol]		= ClassLib.ComVar.Parameter_PopUpTable.Rows[i][6].ToString();
 
					fgrid_main[row, (int)ClassLib.TBSBI_IN_TAIL.IxSTYLE_CD ]  = ClassLib.ComVar.Parameter_PopUpTable.Rows[i][8].ToString();
				
				}

				_practicable = true; 
				ClassLib.ComVar.Parameter_PopUpTable.Dispose();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		/// <summary>
		/// Show_Item_Popup : Item 기타 데이터 입력하는 팝업 실행 : Item/ Specification/ Color
		/// </summary>
		private void Show_LLT_Item_Popup()
		{
			try
			{
				FlexPurchase.Purchase.Pop_BP_Item_List iPop = new FlexPurchase.Purchase.Pop_BP_Item_List();
				iPop.factory = this.cmb_factory.SelectedValue;
				
				if(iPop.ShowDialog() == DialogResult.OK)
				{
					DataTable vDt = iPop.SelectedData;

					if (vDt == null)	return;


					for (int idx = 0 ; idx < vDt.Rows.Count ; idx++)
					{ 
						int row = fgrid_main.Rows.Count;
						fgrid_main.Add_Row(row - 1);
						int vInSeq = 0;
					
						if (!row.Equals(fgrid_main.Rows.Fixed))
							vInSeq = int.Parse(fgrid_main[row -1, _inSeqCol].ToString());

						fgrid_main[row, (int)ClassLib.TBSBI_IN_TAIL.IxFACTORY] = cmb_factory.SelectedValue;
						fgrid_main[row, _inSeqCol]		 = vInSeq + 1 ;
						fgrid_main[row, _seqCol]		 = row +1 - fgrid_main.Rows.Fixed ;

						fgrid_main[row, _itemCdCol]		 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxITEM_CD].ToString();
						fgrid_main[row, _itemNameCol]	 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxITEM_NAME].ToString();
						fgrid_main[row, _specCdCol]		 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxSPEC_CD].ToString();
						fgrid_main[row, _specNameCol]	 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxSPEC_NAME].ToString();
						fgrid_main[row, _colorCdCol]	 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCOLOR_CD].ToString();
						fgrid_main[row, _colorNameCol]	 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCOLOR_NAME].ToString();
						fgrid_main[row, _unitCol]		 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxUNIT].ToString();

						fgrid_main[row, _custCdCol]		 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCUST_CD].ToString();
						fgrid_main[row, _custNameCol]	 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCUST_NAME].ToString();

						fgrid_main[row, _purPriceCol]	 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxPUR_PRICE].ToString();
						fgrid_main[row, _purCurrencyCol] = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxPUR_CURRENCY].ToString();
						fgrid_main[row, _cbdPriceCol]    = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCBD_PRICE].ToString();
						fgrid_main[row, _cbdCurrencyCol] = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxOUTSIDE_CURRENCY].ToString();

					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	
		#endregion

        private void Form_BI_Incoming_Overseas_Load(object sender, EventArgs e)
        {
            //Select_Exhange_Rate();
        }

        public static DataTable Select_Exchange_rate(string income_day)
        {

            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "PKG_SBI_IN_OVERSEAS.sp_sel_exchange_rate";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_TODAY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = income_day;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null ;
            }
        }
        private void Select_Exhange_Rate()
        {
            string income_day = dpick_inYmd.Value.ToString("yyyyMMdd");
            DataTable dt_ret = Select_Exchange_rate(income_day);
            if (dt_ret.Rows.Count > 0)
            {
                txtChangeRate.Text = Convert.ToString(dt_ret.Rows[0][1]);
            }
            else
            {
                txtChangeRate.Text = "0";
            }
        }
        private void dpick_inYmd_ValueChanged(object sender, EventArgs e)
        {
            Select_Exhange_Rate();
        }



	}
}

