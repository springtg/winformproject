using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;
using System.Threading; 

namespace FlexPurchase.Stock
{
	public class Form_BK_Stock_Closing : COM.PCHWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbl_headInfo;
        private System.Windows.Forms.Label lbl_StockYm;
		private C1.Win.C1List.C1Combo cmb_wareHouse;
		private System.Windows.Forms.Label lbl_wareHouse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_printType;
		private System.Windows.Forms.Label lbl_currency;
		private System.Windows.Forms.Label btn_closing;
		private System.Windows.Forms.TextBox txt_stockStatus;
		private System.Windows.Forms.Label lbl_stockStatus;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.TextBox txt_itemName;
		private System.Windows.Forms.TextBox txt_itemCode;
		private System.Windows.Forms.Label lbl_itemgroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.Label btn_Tree;
		private System.Windows.Forms.Label btn_delete;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label btn_Insert;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.Windows.Forms.ContextMenu cmenu_grid;
		private System.Windows.Forms.MenuItem menuItem_ValueChange;
		private System.Windows.Forms.MenuItem menuItem_MovingWH;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem_CBD;


		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB	= new COM.OraDB();
 
		private Hashtable _cellTypes = null;
		private Hashtable _cellData  = null;

        private Thread tRun = null;
        delegate void DelegateSetn(); // 대리자 선언    


		private System.Windows.Forms.Label btn_RemakeQty;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem_In;
		private System.Windows.Forms.MenuItem menuItem_Out;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem_ItemRelation;
		private System.Windows.Forms.MenuItem menuItem_SpecRelation;
        private C1.Win.C1List.C1Combo cmb_stockMM;
        private C1.Win.C1List.C1Combo cmb_stockYY;
        private C1.Win.C1List.C1Combo cmb_printType;
        private C1.Win.C1List.C1Combo cmb_currency;
        private MenuItem menuItem4;
        private MenuItem menuItem_MakeStock;
		private System.Windows.Forms.MenuItem menuItem_ColorRelation;
		 
	 
		#endregion

		#region 생성자 / 소멸자


		public Form_BK_Stock_Closing()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BK_Stock_Closing));
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
            this.spd_main = new COM.SSP();
            this.cmenu_grid = new System.Windows.Forms.ContextMenu();
            this.menuItem_ValueChange = new System.Windows.Forms.MenuItem();
            this.menuItem_MovingWH = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem_CBD = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem_In = new System.Windows.Forms.MenuItem();
            this.menuItem_Out = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem_ItemRelation = new System.Windows.Forms.MenuItem();
            this.menuItem_SpecRelation = new System.Windows.Forms.MenuItem();
            this.menuItem_ColorRelation = new System.Windows.Forms.MenuItem();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.cmb_currency = new C1.Win.C1List.C1Combo();
            this.cmb_printType = new C1.Win.C1List.C1Combo();
            this.cmb_stockMM = new C1.Win.C1List.C1Combo();
            this.cmb_stockYY = new C1.Win.C1List.C1Combo();
            this.btn_RemakeQty = new System.Windows.Forms.Label();
            this.txt_itemGroup = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.lbl_itemgroup = new System.Windows.Forms.Label();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.txt_stockStatus = new System.Windows.Forms.TextBox();
            this.lbl_stockStatus = new System.Windows.Forms.Label();
            this.btn_closing = new System.Windows.Forms.Label();
            this.lbl_currency = new System.Windows.Forms.Label();
            this.lbl_printType = new System.Windows.Forms.Label();
            this.cmb_wareHouse = new C1.Win.C1List.C1Combo();
            this.lbl_wareHouse = new System.Windows.Forms.Label();
            this.lbl_headInfo = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_StockYm = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Tree = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Label();
            this.btn_recover = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Label();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem_MakeStock = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_currency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_printType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_stockMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_stockYY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_wareHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.pic_head4);
            this.c1Sizer1.GridDefinition = "18.3673469387755:False:True;73.8095238095238:False:False;5.10204081632653:False:T" +
                "rue;\t0.393700787401575:False:True;97.6377952755905:False:False;0.393700787401575" +
                ":False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 588);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // spd_main
            // 
            this.spd_main.BackColor = System.Drawing.Color.Transparent;
            this.spd_main.ContextMenu = this.cmenu_grid;
            this.spd_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spd_main.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.spd_main.Location = new System.Drawing.Point(12, 116);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(992, 434);
            this.spd_main.TabIndex = 173;
            this.spd_main.EditModeOn += new System.EventHandler(this.spd_main_EditModeOn);
            this.spd_main.EditModeOff += new System.EventHandler(this.spd_main_EditModeOff);
            this.spd_main.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellClick);
            this.spd_main.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_EditChange);
            // 
            // cmenu_grid
            // 
            this.cmenu_grid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_ValueChange,
            this.menuItem_MovingWH,
            this.menuItem1,
            this.menuItem_CBD,
            this.menuItem2,
            this.menuItem_In,
            this.menuItem_Out,
            this.menuItem3,
            this.menuItem_ItemRelation,
            this.menuItem_SpecRelation,
            this.menuItem_ColorRelation,
            this.menuItem4,
            this.menuItem_MakeStock});
            this.cmenu_grid.Popup += new System.EventHandler(this.cmenu_grid_Popup);
            // 
            // menuItem_ValueChange
            // 
            this.menuItem_ValueChange.Index = 0;
            this.menuItem_ValueChange.Text = "Value Change";
            this.menuItem_ValueChange.Click += new System.EventHandler(this.menuItem_ValueChange_Click);
            // 
            // menuItem_MovingWH
            // 
            this.menuItem_MovingWH.Index = 1;
            this.menuItem_MovingWH.Text = "Moving Warehouse";
            this.menuItem_MovingWH.Click += new System.EventHandler(this.menuItem_MovingWH_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "-";
            // 
            // menuItem_CBD
            // 
            this.menuItem_CBD.Index = 3;
            this.menuItem_CBD.Text = "CBD Information";
            this.menuItem_CBD.Click += new System.EventHandler(this.menuItem_CBD_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 4;
            this.menuItem2.Text = "-";
            // 
            // menuItem_In
            // 
            this.menuItem_In.Index = 5;
            this.menuItem_In.Text = "Incoming Infomation";
            this.menuItem_In.Click += new System.EventHandler(this.menuItem_InOut_Click);
            // 
            // menuItem_Out
            // 
            this.menuItem_Out.Index = 6;
            this.menuItem_Out.Text = "Outgoing Infomation";
            this.menuItem_Out.Click += new System.EventHandler(this.menuItem_InOut_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 7;
            this.menuItem3.Text = "-";
            this.menuItem3.Visible = false;
            // 
            // menuItem_ItemRelation
            // 
            this.menuItem_ItemRelation.Index = 8;
            this.menuItem_ItemRelation.Text = "Make Item Relation";
            this.menuItem_ItemRelation.Visible = false;
            this.menuItem_ItemRelation.Click += new System.EventHandler(this.menuItem_MakeRelation_Click);
            // 
            // menuItem_SpecRelation
            // 
            this.menuItem_SpecRelation.Index = 9;
            this.menuItem_SpecRelation.Text = "Make Specification Relation";
            this.menuItem_SpecRelation.Visible = false;
            this.menuItem_SpecRelation.Click += new System.EventHandler(this.menuItem_MakeRelation_Click);
            // 
            // menuItem_ColorRelation
            // 
            this.menuItem_ColorRelation.Index = 10;
            this.menuItem_ColorRelation.Text = "Make Color Relation";
            this.menuItem_ColorRelation.Visible = false;
            this.menuItem_ColorRelation.Click += new System.EventHandler(this.menuItem_MakeRelation_Click);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.cmb_currency);
            this.pnl_head.Controls.Add(this.cmb_printType);
            this.pnl_head.Controls.Add(this.cmb_stockMM);
            this.pnl_head.Controls.Add(this.cmb_stockYY);
            this.pnl_head.Controls.Add(this.btn_RemakeQty);
            this.pnl_head.Controls.Add(this.txt_itemGroup);
            this.pnl_head.Controls.Add(this.cmb_itemGroup);
            this.pnl_head.Controls.Add(this.txt_itemName);
            this.pnl_head.Controls.Add(this.txt_itemCode);
            this.pnl_head.Controls.Add(this.lbl_itemgroup);
            this.pnl_head.Controls.Add(this.btn_groupSearch);
            this.pnl_head.Controls.Add(this.lbl_item);
            this.pnl_head.Controls.Add(this.txt_stockStatus);
            this.pnl_head.Controls.Add(this.lbl_stockStatus);
            this.pnl_head.Controls.Add(this.btn_closing);
            this.pnl_head.Controls.Add(this.lbl_currency);
            this.pnl_head.Controls.Add(this.lbl_printType);
            this.pnl_head.Controls.Add(this.cmb_wareHouse);
            this.pnl_head.Controls.Add(this.lbl_wareHouse);
            this.pnl_head.Controls.Add(this.lbl_headInfo);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_StockYm);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pictureBox1);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 108);
            this.pnl_head.TabIndex = 32;
            // 
            // cmb_currency
            // 
            this.cmb_currency.AddItemSeparator = ';';
            this.cmb_currency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_currency.Caption = "";
            this.cmb_currency.CaptionHeight = 17;
            this.cmb_currency.CaptionStyle = style1;
            this.cmb_currency.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_currency.ColumnCaptionHeight = 18;
            this.cmb_currency.ColumnFooterHeight = 18;
            this.cmb_currency.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_currency.ContentHeight = 16;
            this.cmb_currency.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_currency.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_currency.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_currency.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_currency.EditorHeight = 16;
            this.cmb_currency.EvenRowStyle = style2;
            this.cmb_currency.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_currency.FooterStyle = style3;
            this.cmb_currency.HeadingStyle = style4;
            this.cmb_currency.HighLightRowStyle = style5;
            this.cmb_currency.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_currency.Images"))));
            this.cmb_currency.ItemHeight = 15;
            this.cmb_currency.Location = new System.Drawing.Point(779, 55);
            this.cmb_currency.MatchEntryTimeout = ((long)(2000));
            this.cmb_currency.MaxDropDownItems = ((short)(5));
            this.cmb_currency.MaxLength = 32767;
            this.cmb_currency.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_currency.Name = "cmb_currency";
            this.cmb_currency.OddRowStyle = style6;
            this.cmb_currency.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_currency.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_currency.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_currency.SelectedStyle = style7;
            this.cmb_currency.Size = new System.Drawing.Size(210, 20);
            this.cmb_currency.Style = style8;
            this.cmb_currency.TabIndex = 672;
            this.cmb_currency.Visible = false;
            this.cmb_currency.PropBag = resources.GetString("cmb_currency.PropBag");
            // 
            // cmb_printType
            // 
            this.cmb_printType.AddItemSeparator = ';';
            this.cmb_printType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_printType.Caption = "";
            this.cmb_printType.CaptionHeight = 17;
            this.cmb_printType.CaptionStyle = style9;
            this.cmb_printType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_printType.ColumnCaptionHeight = 18;
            this.cmb_printType.ColumnFooterHeight = 18;
            this.cmb_printType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_printType.ContentHeight = 16;
            this.cmb_printType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_printType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_printType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_printType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_printType.EditorHeight = 16;
            this.cmb_printType.EvenRowStyle = style10;
            this.cmb_printType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_printType.FooterStyle = style11;
            this.cmb_printType.HeadingStyle = style12;
            this.cmb_printType.HighLightRowStyle = style13;
            this.cmb_printType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_printType.Images"))));
            this.cmb_printType.ItemHeight = 15;
            this.cmb_printType.Location = new System.Drawing.Point(779, 34);
            this.cmb_printType.MatchEntryTimeout = ((long)(2000));
            this.cmb_printType.MaxDropDownItems = ((short)(5));
            this.cmb_printType.MaxLength = 32767;
            this.cmb_printType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_printType.Name = "cmb_printType";
            this.cmb_printType.OddRowStyle = style14;
            this.cmb_printType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_printType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_printType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_printType.SelectedStyle = style15;
            this.cmb_printType.Size = new System.Drawing.Size(210, 20);
            this.cmb_printType.Style = style16;
            this.cmb_printType.TabIndex = 671;
            this.cmb_printType.Visible = false;
            this.cmb_printType.PropBag = resources.GetString("cmb_printType.PropBag");
            // 
            // cmb_stockMM
            // 
            this.cmb_stockMM.AddItemSeparator = ';';
            this.cmb_stockMM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_stockMM.Caption = "";
            this.cmb_stockMM.CaptionHeight = 17;
            this.cmb_stockMM.CaptionStyle = style17;
            this.cmb_stockMM.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_stockMM.ColumnCaptionHeight = 18;
            this.cmb_stockMM.ColumnFooterHeight = 18;
            this.cmb_stockMM.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_stockMM.ContentHeight = 16;
            this.cmb_stockMM.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_stockMM.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_stockMM.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_stockMM.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_stockMM.EditorHeight = 16;
            this.cmb_stockMM.EvenRowStyle = style18;
            this.cmb_stockMM.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_stockMM.FooterStyle = style19;
            this.cmb_stockMM.HeadingStyle = style20;
            this.cmb_stockMM.HighLightRowStyle = style21;
            this.cmb_stockMM.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_stockMM.Images"))));
            this.cmb_stockMM.ItemHeight = 15;
            this.cmb_stockMM.Location = new System.Drawing.Point(214, 55);
            this.cmb_stockMM.MatchEntryTimeout = ((long)(2000));
            this.cmb_stockMM.MaxDropDownItems = ((short)(5));
            this.cmb_stockMM.MaxLength = 32767;
            this.cmb_stockMM.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_stockMM.Name = "cmb_stockMM";
            this.cmb_stockMM.OddRowStyle = style22;
            this.cmb_stockMM.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_stockMM.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_stockMM.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_stockMM.SelectedStyle = style23;
            this.cmb_stockMM.Size = new System.Drawing.Size(105, 20);
            this.cmb_stockMM.Style = style24;
            this.cmb_stockMM.TabIndex = 670;
            this.cmb_stockMM.SelectedValueChanged += new System.EventHandler(this.cmb_stockMM_SelectedValueChanged);
            this.cmb_stockMM.PropBag = resources.GetString("cmb_stockMM.PropBag");
            // 
            // cmb_stockYY
            // 
            this.cmb_stockYY.AddItemSeparator = ';';
            this.cmb_stockYY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_stockYY.Caption = "";
            this.cmb_stockYY.CaptionHeight = 17;
            this.cmb_stockYY.CaptionStyle = style25;
            this.cmb_stockYY.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_stockYY.ColumnCaptionHeight = 18;
            this.cmb_stockYY.ColumnFooterHeight = 18;
            this.cmb_stockYY.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_stockYY.ContentHeight = 16;
            this.cmb_stockYY.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_stockYY.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_stockYY.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_stockYY.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_stockYY.EditorHeight = 16;
            this.cmb_stockYY.EvenRowStyle = style26;
            this.cmb_stockYY.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_stockYY.FooterStyle = style27;
            this.cmb_stockYY.HeadingStyle = style28;
            this.cmb_stockYY.HighLightRowStyle = style29;
            this.cmb_stockYY.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_stockYY.Images"))));
            this.cmb_stockYY.ItemHeight = 15;
            this.cmb_stockYY.Location = new System.Drawing.Point(109, 55);
            this.cmb_stockYY.MatchEntryTimeout = ((long)(2000));
            this.cmb_stockYY.MaxDropDownItems = ((short)(5));
            this.cmb_stockYY.MaxLength = 32767;
            this.cmb_stockYY.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_stockYY.Name = "cmb_stockYY";
            this.cmb_stockYY.OddRowStyle = style30;
            this.cmb_stockYY.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_stockYY.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_stockYY.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_stockYY.SelectedStyle = style31;
            this.cmb_stockYY.Size = new System.Drawing.Size(104, 20);
            this.cmb_stockYY.Style = style32;
            this.cmb_stockYY.TabIndex = 669;
            this.cmb_stockYY.SelectedValueChanged += new System.EventHandler(this.cmb_stockYY_SelectedValueChanged);
            this.cmb_stockYY.PropBag = resources.GetString("cmb_stockYY.PropBag");
            // 
            // btn_RemakeQty
            // 
            this.btn_RemakeQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RemakeQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_RemakeQty.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_RemakeQty.ImageIndex = 1;
            this.btn_RemakeQty.ImageList = this.img_Button;
            this.btn_RemakeQty.Location = new System.Drawing.Point(828, 80);
            this.btn_RemakeQty.Name = "btn_RemakeQty";
            this.btn_RemakeQty.Size = new System.Drawing.Size(80, 23);
            this.btn_RemakeQty.TabIndex = 444;
            this.btn_RemakeQty.Text = "Remake Qty.";
            this.btn_RemakeQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_RemakeQty.Visible = false;
            this.btn_RemakeQty.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_RemakeQty.Click += new System.EventHandler(this.btn_RemakeQty_Click);
            this.btn_RemakeQty.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_RemakeQty.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_RemakeQty.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.Location = new System.Drawing.Point(538, 33);
            this.txt_itemGroup.MaxLength = 10;
            this.txt_itemGroup.Name = "txt_itemGroup";
            this.txt_itemGroup.ReadOnly = true;
            this.txt_itemGroup.Size = new System.Drawing.Size(100, 21);
            this.txt_itemGroup.TabIndex = 442;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style33;
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
            this.cmb_itemGroup.EvenRowStyle = style34;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style35;
            this.cmb_itemGroup.HeadingStyle = style36;
            this.cmb_itemGroup.HighLightRowStyle = style37;
            this.cmb_itemGroup.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_itemGroup.Images"))));
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(437, 33);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style38;
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style39;
            this.cmb_itemGroup.Size = new System.Drawing.Size(100, 20);
            this.cmb_itemGroup.Style = style40;
            this.cmb_itemGroup.TabIndex = 441;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            // 
            // txt_itemName
            // 
            this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemName.Location = new System.Drawing.Point(497, 55);
            this.txt_itemName.MaxLength = 500;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(163, 21);
            this.txt_itemName.TabIndex = 443;
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCode.Location = new System.Drawing.Point(437, 55);
            this.txt_itemCode.MaxLength = 10;
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(59, 21);
            this.txt_itemCode.TabIndex = 439;
            // 
            // lbl_itemgroup
            // 
            this.lbl_itemgroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_itemgroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemgroup.ImageIndex = 0;
            this.lbl_itemgroup.ImageList = this.img_Label;
            this.lbl_itemgroup.Location = new System.Drawing.Point(336, 33);
            this.lbl_itemgroup.Name = "lbl_itemgroup";
            this.lbl_itemgroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemgroup.TabIndex = 437;
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
            this.btn_groupSearch.Location = new System.Drawing.Point(638, 33);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 440;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            this.btn_groupSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_groupSearch.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_groupSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(336, 55);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 438;
            this.lbl_item.Text = "Item";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_stockStatus
            // 
            this.txt_stockStatus.BackColor = System.Drawing.Color.White;
            this.txt_stockStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_stockStatus.Enabled = false;
            this.txt_stockStatus.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_stockStatus.Location = new System.Drawing.Point(437, 77);
            this.txt_stockStatus.MaxLength = 20;
            this.txt_stockStatus.Name = "txt_stockStatus";
            this.txt_stockStatus.Size = new System.Drawing.Size(223, 21);
            this.txt_stockStatus.TabIndex = 397;
            // 
            // lbl_stockStatus
            // 
            this.lbl_stockStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_stockStatus.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stockStatus.ImageIndex = 0;
            this.lbl_stockStatus.ImageList = this.img_Label;
            this.lbl_stockStatus.Location = new System.Drawing.Point(336, 77);
            this.lbl_stockStatus.Name = "lbl_stockStatus";
            this.lbl_stockStatus.Size = new System.Drawing.Size(100, 21);
            this.lbl_stockStatus.TabIndex = 396;
            this.lbl_stockStatus.Text = "Stock Status";
            this.lbl_stockStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_closing
            // 
            this.btn_closing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_closing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_closing.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_closing.ImageIndex = 1;
            this.btn_closing.ImageList = this.img_Button;
            this.btn_closing.Location = new System.Drawing.Point(909, 80);
            this.btn_closing.Name = "btn_closing";
            this.btn_closing.Size = new System.Drawing.Size(80, 23);
            this.btn_closing.TabIndex = 428;
            this.btn_closing.Text = "Closing";
            this.btn_closing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_closing.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_closing.Click += new System.EventHandler(this.btn_closing_Click);
            this.btn_closing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_closing.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_closing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // lbl_currency
            // 
            this.lbl_currency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_currency.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currency.ImageIndex = 0;
            this.lbl_currency.ImageList = this.img_Label;
            this.lbl_currency.Location = new System.Drawing.Point(678, 55);
            this.lbl_currency.Name = "lbl_currency";
            this.lbl_currency.Size = new System.Drawing.Size(100, 21);
            this.lbl_currency.TabIndex = 427;
            this.lbl_currency.Text = "Currency";
            this.lbl_currency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_currency.Visible = false;
            // 
            // lbl_printType
            // 
            this.lbl_printType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_printType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_printType.ImageIndex = 0;
            this.lbl_printType.ImageList = this.img_Label;
            this.lbl_printType.Location = new System.Drawing.Point(678, 33);
            this.lbl_printType.Name = "lbl_printType";
            this.lbl_printType.Size = new System.Drawing.Size(100, 21);
            this.lbl_printType.TabIndex = 425;
            this.lbl_printType.Text = "Print Type";
            this.lbl_printType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_printType.Visible = false;
            // 
            // cmb_wareHouse
            // 
            this.cmb_wareHouse.AddItemSeparator = ';';
            this.cmb_wareHouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_wareHouse.Caption = "";
            this.cmb_wareHouse.CaptionHeight = 17;
            this.cmb_wareHouse.CaptionStyle = style41;
            this.cmb_wareHouse.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_wareHouse.ColumnCaptionHeight = 18;
            this.cmb_wareHouse.ColumnFooterHeight = 18;
            this.cmb_wareHouse.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_wareHouse.ContentHeight = 16;
            this.cmb_wareHouse.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_wareHouse.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_wareHouse.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_wareHouse.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_wareHouse.EditorHeight = 16;
            this.cmb_wareHouse.EvenRowStyle = style42;
            this.cmb_wareHouse.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_wareHouse.FooterStyle = style43;
            this.cmb_wareHouse.HeadingStyle = style44;
            this.cmb_wareHouse.HighLightRowStyle = style45;
            this.cmb_wareHouse.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_wareHouse.Images"))));
            this.cmb_wareHouse.ItemHeight = 15;
            this.cmb_wareHouse.Location = new System.Drawing.Point(109, 77);
            this.cmb_wareHouse.MatchEntryTimeout = ((long)(2000));
            this.cmb_wareHouse.MaxDropDownItems = ((short)(5));
            this.cmb_wareHouse.MaxLength = 32767;
            this.cmb_wareHouse.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_wareHouse.Name = "cmb_wareHouse";
            this.cmb_wareHouse.OddRowStyle = style46;
            this.cmb_wareHouse.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_wareHouse.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_wareHouse.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_wareHouse.SelectedStyle = style47;
            this.cmb_wareHouse.Size = new System.Drawing.Size(210, 20);
            this.cmb_wareHouse.Style = style48;
            this.cmb_wareHouse.TabIndex = 422;
            this.cmb_wareHouse.SelectedValueChanged += new System.EventHandler(this.cmb_wareHouse_SelectedValueChanged);
            this.cmb_wareHouse.PropBag = resources.GetString("cmb_wareHouse.PropBag");
            // 
            // lbl_wareHouse
            // 
            this.lbl_wareHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_wareHouse.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wareHouse.ImageIndex = 1;
            this.lbl_wareHouse.ImageList = this.img_Label;
            this.lbl_wareHouse.Location = new System.Drawing.Point(8, 77);
            this.lbl_wareHouse.Name = "lbl_wareHouse";
            this.lbl_wareHouse.Size = new System.Drawing.Size(100, 21);
            this.lbl_wareHouse.TabIndex = 423;
            this.lbl_wareHouse.Text = "WareHouse";
            this.lbl_wareHouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_headInfo
            // 
            this.lbl_headInfo.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_headInfo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_headInfo.ForeColor = System.Drawing.Color.Navy;
            this.lbl_headInfo.Image = ((System.Drawing.Image)(resources.GetObject("lbl_headInfo.Image")));
            this.lbl_headInfo.Location = new System.Drawing.Point(0, 0);
            this.lbl_headInfo.Name = "lbl_headInfo";
            this.lbl_headInfo.Size = new System.Drawing.Size(231, 30);
            this.lbl_headInfo.TabIndex = 417;
            this.lbl_headInfo.Text = "       Stock Closing  Info";
            this.lbl_headInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 92);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // lbl_StockYm
            // 
            this.lbl_StockYm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_StockYm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockYm.ImageIndex = 1;
            this.lbl_StockYm.ImageList = this.img_Label;
            this.lbl_StockYm.Location = new System.Drawing.Point(8, 55);
            this.lbl_StockYm.Name = "lbl_StockYm";
            this.lbl_StockYm.Size = new System.Drawing.Size(100, 21);
            this.lbl_StockYm.TabIndex = 50;
            this.lbl_StockYm.Text = "Stock Date";
            this.lbl_StockYm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cmb_factory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory.EditorHeight = 16;
            this.cmb_factory.EvenRowStyle = style50;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmb_factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_factory.Style = style56;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pic_head7.Location = new System.Drawing.Point(899, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 67);
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
            this.pic_head5.Location = new System.Drawing.Point(0, 92);
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
            this.pic_head6.Location = new System.Drawing.Point(0, 16);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 81);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(112, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(968, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 18);
            this.pictureBox1.TabIndex = 407;
            this.pictureBox1.TabStop = false;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(12, 116);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(992, 434);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Tree);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_recover);
            this.panel1.Controls.Add(this.btn_Insert);
            this.panel1.Location = new System.Drawing.Point(12, 554);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 30);
            this.panel1.TabIndex = 173;
            // 
            // btn_Tree
            // 
            this.btn_Tree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Tree.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tree.ImageIndex = 13;
            this.btn_Tree.ImageList = this.image_List;
            this.btn_Tree.Location = new System.Drawing.Point(668, 3);
            this.btn_Tree.Name = "btn_Tree";
            this.btn_Tree.Size = new System.Drawing.Size(80, 24);
            this.btn_Tree.TabIndex = 372;
            this.btn_Tree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Tree.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Tree.Click += new System.EventHandler(this.btn_Tree_Click);
            this.btn_Tree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Tree.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Tree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_delete.ImageIndex = 5;
            this.btn_delete.ImageList = this.image_List;
            this.btn_delete.Location = new System.Drawing.Point(830, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(80, 24);
            this.btn_delete.TabIndex = 371;
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            this.btn_delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_delete.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_recover
            // 
            this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_recover.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recover.ImageIndex = 1;
            this.btn_recover.ImageList = this.image_List;
            this.btn_recover.Location = new System.Drawing.Point(911, 3);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(80, 24);
            this.btn_recover.TabIndex = 370;
            this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_recover.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
            this.btn_recover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_recover.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_recover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Insert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.ImageIndex = 9;
            this.btn_Insert.ImageList = this.image_List;
            this.btn_Insert.Location = new System.Drawing.Point(749, 3);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 24);
            this.btn_Insert.TabIndex = 369;
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insert.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            this.btn_Insert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Insert.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Insert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 11;
            this.menuItem4.Text = "-";
            // 
            // menuItem_MakeStock
            // 
            this.menuItem_MakeStock.Index = 12;
            this.menuItem_MakeStock.Text = "Make Stock";
            this.menuItem_MakeStock.Click += new System.EventHandler(this.menuItem_MakeStock_Click);
            // 
            // Form_BK_Stock_Closing
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BK_Stock_Closing";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_currency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_printType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_stockMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_stockYY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_wareHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion 
		
		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();		
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SaveProcess();
		}						
	
		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_ConfirmProcess();
		}

		private void btn_RemakeQty_Click(object sender, System.EventArgs e)
		{
			this.Tbtn_RemakeQtyProcess();
		}

		private void btn_closing_Click(object sender, System.EventArgs e)
		{
			this.Tbtn_ClosingProcess();
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess();
		}

 
 

		private void EnableControlCheckProcess()
		{
			try
			{ 
 
				string stock_status = "";
				string stock_status_desc = "";
  

				if(spd_main.ActiveSheet.RowCount == 0)
				{

					tbtn_Save.Enabled = true; 

					btn_RemakeQty.Enabled = true;
					btn_closing.Enabled = true; 
					
					spd_main.ActiveSheet.OperationMode = OperationMode.Normal;
					//spd_main.ContextMenu = cmenu_grid;

					menuItem_MovingWH.Enabled = false;
					menuItem_ValueChange.Enabled = false;
					menuItem_CBD.Enabled = false;
					menuItem_In.Enabled = false;
					menuItem_Out.Enabled = false;
					menuItem_ItemRelation.Enabled = false;
					menuItem_SpecRelation.Enabled = false;
					menuItem_ColorRelation.Enabled = false;



					btn_Tree.Enabled = true;
					btn_Insert.Enabled = true;
					btn_delete.Enabled = true;
					btn_recover.Enabled = true;
                    tbtn_Create.Enabled = false;

					stock_status_desc = ""; 

				}
				else
				{

					stock_status = spd_main.ActiveSheet.Cells[0, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_STATUS].Value.ToString();


					if(stock_status == "C")   // confirm
					{ 
						tbtn_Save.Enabled = false; 

						btn_RemakeQty.Enabled = false;
						btn_closing.Enabled = false;

						spd_main.ActiveSheet.OperationMode = OperationMode.ReadOnly;
						//spd_main.ContextMenu = null;

						menuItem_MovingWH.Enabled = false;
						menuItem_ValueChange.Enabled = false;
						menuItem_CBD.Enabled = false;
						menuItem_In.Enabled = true;
						menuItem_Out.Enabled = true;
						menuItem_ItemRelation.Enabled = false;
                        menuItem_SpecRelation.Enabled = false;
                        menuItem_ColorRelation.Enabled = false;



						btn_Tree.Enabled = false;
						btn_Insert.Enabled = false;
						btn_delete.Enabled = false;
						btn_recover.Enabled = false;
                        tbtn_Create.Enabled = false;

						stock_status_desc = "Confirm";
 

					}
					else
					{
						tbtn_Save.Enabled = true; 

						btn_RemakeQty.Enabled = true;
						btn_closing.Enabled = true; 
						
						spd_main.ActiveSheet.OperationMode = OperationMode.Normal;
						//spd_main.ContextMenu = cmenu_grid;

						menuItem_MovingWH.Enabled = true;
						menuItem_ValueChange.Enabled = true;
						menuItem_CBD.Enabled = true;
						menuItem_In.Enabled = true;
						menuItem_Out.Enabled = true;
						menuItem_ItemRelation.Enabled = true;
						menuItem_SpecRelation.Enabled = true;
						menuItem_ColorRelation.Enabled = true;



						btn_Tree.Enabled = true;
						btn_Insert.Enabled = true;
						btn_delete.Enabled = true;
						btn_recover.Enabled = true;

						stock_status_desc = "Save";

					}

				}
 
				spd_main.ActiveSheet.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors;
				spd_main.ActiveSheet.SelectionPolicy = FarPoint.Win.Spread.Model.SelectionPolicy.MultiRange;
				spd_main.ActiveSheet.SelectionUnit = FarPoint.Win.Spread.Model.SelectionUnit.Row; 


				txt_stockStatus.Text = stock_status_desc;


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "EnableControlCheckProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
 



		#endregion
	
		#region 그리드 이벤트 처리


        private void menuItem_MakeStock_Click(object sender, EventArgs e)
        {

            C1.Win.C1List.C1Combo[] cmb_array = { cmb_factory, cmb_stockYY, cmb_stockMM };
            bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);

            if (!essential_check) return;


            Stock.Pop_BK_Stock_Close_DS vpop
                = new Stock.Pop_BK_Stock_Close_DS(cmb_factory.SelectedValue.ToString(), cmb_stockYY.SelectedValue.ToString(), cmb_stockMM.SelectedValue.ToString(), ClassLib.ComVar.This_User);

            vpop.ShowDialog();
        }



		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{						
			Grid_EditModeOnProcess(spd_main) ;
		}		

		private void spd_main_EditModeOff(object sender, System.EventArgs e)
		{
			try
			{

				if(! _Make_After_Closing_Flag)
				{
					ClassLib.ComFunction.User_Message("You need [Closing], because remake in/out quantity.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

			
				int vRow = spd_main.ActiveSheet.ActiveRowIndex;

				if(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxRELATION_EXIST_YN].Value.ToString().Equals("Y") ) return; 


				int sel_col = spd_main.ActiveSheet.ActiveColumnIndex;
				int sel_row = spd_main.ActiveSheet.ActiveRowIndex;

				// adjust 수량 수정 시 stock 수량 재 계산
				if(sel_col == (int)ClassLib.TBSBK_STOCK_CLOSE.IxADJUST_QTY)
				{
					Update_StockQty(sel_row, sel_col);
				}

				if(sel_col == (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_QTY)
				{
					Update_AdjustQty(sel_row, sel_col);
				}
				 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "spd_main_EditModeOff", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}



		private void Update_StockQty(int arg_row, int arg_col)
		{

			// 수정 가능한 컬럼은 double 로 타입 수정됨. 따라서, double 를 다시 decimal 로 타입 변환 
			decimal adjust_qty = Convert.ToDecimal( spd_main.ActiveSheet.Cells[arg_row, arg_col].Value ) ;
				 
			decimal base_qty = (decimal)spd_main.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxBAES_QTY].Value;
			decimal in_qty = (decimal)spd_main.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxIN_QTY].Value;
			decimal out_qty = (decimal)spd_main.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxOUT_QTY].Value;
 
			spd_main.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_QTY].Value = base_qty + in_qty - out_qty + adjust_qty;


		}

		private void Update_AdjustQty(int arg_row, int arg_col)
		{

			// 수정 가능한 컬럼은 double 로 타입 수정됨. 따라서, double 를 다시 decimal 로 타입 변환 
			decimal stock_qty = Convert.ToDecimal( spd_main.ActiveSheet.Cells[arg_row, arg_col].Value ) ;
				 
			decimal base_qty = (decimal)spd_main.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxBAES_QTY].Value;
			decimal in_qty = (decimal)spd_main.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxIN_QTY].Value;
			decimal out_qty = (decimal)spd_main.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxOUT_QTY].Value;
 
			spd_main.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxADJUST_QTY].Value = stock_qty - ( base_qty + in_qty - out_qty );


		}


		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{			

			if(! _Make_After_Closing_Flag)
			{
				ClassLib.ComFunction.User_Message("You need [Closing], because remake in/out quantity.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			int vRow = spd_main.ActiveSheet.ActiveRowIndex;

			if(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxRELATION_EXIST_YN].Value.ToString().Equals("Y") ) return; 

			spd_main.Update_Row(img_Action); 

		}

		private void spd_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			//			if (e.Button == MouseButtons.Right)
			//				Grid_CellClickProcess(e);
		}

		#endregion

		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Form_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);
		}

		 

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			 
			if(cmb_factory.SelectedIndex == -1) return;


			DataTable vDt = null; 

			// WareHouse Combobox Setting
			vDt = FlexPurchase.ClassLib.ComFunction.SELECT_WAREHOUSE_LIST_USING(cmb_factory.SelectedValue.ToString() );
			COM.ComCtl.Set_ComboList(vDt, cmb_wareHouse, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Name);  
			//cmb_wareHouse.SelectedIndex	= 0;
			
			vDt.Dispose();



			spd_main.ClearAll(); 

//			cmb_stockYY.SelectedValue = System.DateTime.Today.Year.ToString();
//			cmb_stockMM.SelectedValue = System.DateTime.Today.Month.ToString().PadLeft(2,'0');
//			
//			cmb_wareHouse.SelectedIndex = -1;
//
//			cmb_itemGroup.SelectedIndex = -1;
//			txt_itemGroup.Text = "";
//			txt_itemCode.Text = "";
//			txt_itemName.Text = ""; 

			
			this.EnableControlCheckProcess();

						
			 
		}

		


		private void cmb_stockYY_SelectedValueChanged(object sender, System.EventArgs e)
		{ 

			spd_main.ClearAll();
 
//			cmb_wareHouse.SelectedIndex = -1;
//
//			cmb_itemGroup.SelectedIndex = -1;
//			txt_itemGroup.Text = "";
//			txt_itemCode.Text = "";
//			txt_itemName.Text = "";

			this.EnableControlCheckProcess();

		}


		private void cmb_stockMM_SelectedValueChanged(object sender, System.EventArgs e)
		{
			 

			spd_main.ClearAll(); 

//			cmb_wareHouse.SelectedIndex = -1;
//
//			cmb_itemGroup.SelectedIndex = -1;
//			txt_itemGroup.Text = "";
//			txt_itemCode.Text = "";
//			txt_itemName.Text = ""; 

			this.EnableControlCheckProcess();


		} 

		private void cmb_wareHouse_SelectedValueChanged(object sender, System.EventArgs e)
		{ 
		
			spd_main.ClearAll();
 
//			cmb_itemGroup.SelectedIndex = -1;
//			txt_itemGroup.Text = "";
//			txt_itemCode.Text = "";
//			txt_itemName.Text = "";

			this.EnableControlCheckProcess();

		}



		private string _itemGroupCode = " "; 

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

 

		#endregion  

		#region 메서드

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form init

            lbl_MainTitle.Text = "Stock Closing";
            this.Text = lbl_MainTitle.Text;
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			spd_main.Set_Spread_Comm("SBK_STOCK_CLOSE", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			
			// user define variable set
			spd_main.ActiveSheet = spd_main.ActiveSheet;


			// Grid Header Merge
			for (int vCol = 0 ; vCol < spd_main.ActiveSheet.ColumnCount ; vCol++)
			{
				if (spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.Equals(spd_main.ActiveSheet.ColumnHeader.Cells[2, vCol].Text))
				{
					spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].RowSpan = 2;
				}
				else
				{
					int    vCnt  = 0;
					for ( int j = vCol ; j < spd_main.ActiveSheet.ColumnCount ; j++)
					{
						if( vCnt > 0 &&  spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() != spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )
						{
							spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
							break;
						}
						else if ( spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() == spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )	
							vCnt++;
					}
					vCol = vCol + vCnt-1;
				}
			}






			DataTable vDt = null;


			// Factory combobox add items
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
			vDt.Dispose();
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
 

			 
			// Year ComboBox Add Items 
			vDt = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), ClassLib.ComVar.CxYear);
			ClassLib.ComCtl.Set_ComboList(vDt,cmb_stockYY, 2, 2, false, ClassLib.ComVar.ComboList_Visible.Code);  
			cmb_stockYY.SelectedValue = System.DateTime.Today.Year.ToString();
			


            //// StockMM add Items
            //cmb_stockMM.AddItemTitles("Code");
            //cmb_stockMM.ValueMember = "Code"; 

            //for (int i = 1; i <= 12; i++)
            //{
            //    cmb_stockMM.AddItem(i.ToString().PadLeft(2,'0'));
            //}

            //cmb_stockMM.MaxDropDownItems = 10;
            //cmb_stockMM.SelectedValue = System.DateTime.Today.Month.ToString().PadLeft(2,'0');


            DataTable month = new DataTable();
            month.Columns.Add(new DataColumn("Code", typeof(string)));
            month.Columns[0].ColumnName = "Code";

            DataRow month_row = null;

            for (int i = 1; i <= 12; i++)
            {
                month_row = month.NewRow();
                month_row[0] = i.ToString().PadLeft(2, '0');
                month.Rows.Add(month_row);
            }
            ClassLib.ComCtl.Set_ComboList(month, cmb_stockMM, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Code);
            cmb_stockMM.SelectedValue = System.DateTime.Today.Month.ToString().PadLeft(2, '0');



 

			//그룹타입 콤보쿼리 
			vDt = ClassLib.ComFunction.Select_GroupTypeCode();  
			ClassLib.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, false,  0, 130);  

   

			// currency set    cmb_currency
			vDt = ClassLib.ComVar.Select_Currency(COM.ComVar.This_Factory, ClassLib.ComVar.CxMonetaryUnit);
			COM.ComCtl.Set_ComboList(vDt, cmb_currency, 1, 2, false, 56,0);
			cmb_currency.SelectedIndex	= -1;
			  




//            // print type Set  cmb_printType
//            cmb_printType.AddItemTitles("Code;Name");
//            cmb_printType.ValueMember		= "Code";
//            cmb_printType.DisplayMember	= "Name";
//            cmb_printType.AddItem("A;ALL");
//            cmb_printType.AddItem("T;Material Stock By Class");
//            cmb_printType.AddItem("S;Material Stock By Factory");
//            cmb_printType.AddItem("D;Material Stock Detail");
////			cmb_printType.AddItem("W;Stock By Warehouse");
//            cmb_printType.SelectedValue = "T";  

//            cmb_printType.DropDownWidth		= 320;
//            cmb_printType.Splits[0].DisplayColumns["Code"].Width = 100;
//            cmb_printType.Splits[0].DisplayColumns["Name"].Width = 220-25;//스크롤 방지
//            cmb_printType.ExtendRightColumn = true; 
//            cmb_printType.CellTips = C1.Win.C1List.CellTipEnum.Anchored;


            DataTable print_type = new DataTable();
            print_type.Columns.Add(new DataColumn("Code", typeof(string)));
            print_type.Columns.Add(new DataColumn("Name", typeof(string)));
            print_type.Columns[0].ColumnName = "Code";
            print_type.Columns[1].ColumnName = "Name";

            DataRow print_type_row = null;

            print_type_row = print_type.NewRow();
            print_type_row[0] = "A";
            print_type_row[1] = "ALL";
            print_type.Rows.Add(print_type_row);

            print_type_row = print_type.NewRow();
            print_type_row[0] = "T";
            print_type_row[1] = "Material Stock By Class";
            print_type.Rows.Add(print_type_row);

            print_type_row = print_type.NewRow();
            print_type_row[0] = "S";
            print_type_row[1] = "Material Stock By Factory";
            print_type.Rows.Add(print_type_row);

            print_type_row = print_type.NewRow();
            print_type_row[0] = "D";
            print_type_row[1] = "Material Stock Detail";
            print_type.Rows.Add(print_type_row);

            ClassLib.ComCtl.Set_ComboList(print_type, cmb_printType, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name);
            cmb_printType.SelectedValue = "T";  


			
			// Disabled tbutton
 			tbtn_Delete.Enabled  = false;
//			tbtn_Confirm.Enabled = false;
//			tbtn_Create.Enabled  = false;
//			btn_closing.Enabled	 = false;

			 
			// grid set
			_cellTypes = new Hashtable();
			_cellData  = new Hashtable();

			for (int vCount = 1 ; vCount < spd_main.ActiveSheet.Columns.Count ; vCount++)
			{
				if (spd_main.ActiveSheet.Columns[vCount].CellType.ToString().Equals(ClassLib.ComVar.SSPComboBoxCell))
				{
					COM.SSPComboBoxCellType sspBox = (COM.SSPComboBoxCellType)spd_main.ActiveSheet.Columns[vCount].CellType; 
					_cellTypes.Add(vCount, sspBox.DataDisplay);
					_cellData.Add( vCount, sspBox.DataValue);
				}
			}
 

			// 자재 마감 여부 체크
			this.EnableControlCheckProcess();

            //미사용 메뉴
            menuItem3.Visible = false;
            menuItem_ItemRelation.Visible = false;
            menuItem_SpecRelation.Visible = false;
            menuItem_ColorRelation.Visible = false;
            

		}


 


		private void Tbtn_NewProcess()
		{
			try
			{
				spd_main.ClearAll(); 

				cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
				cmb_stockYY.SelectedValue = System.DateTime.Today.Year.ToString();
				cmb_stockMM.SelectedValue = System.DateTime.Today.Month.ToString().PadLeft(2,'0');
				
				cmb_wareHouse.SelectedIndex = -1;

				cmb_itemGroup.SelectedIndex = -1;
				txt_itemGroup.Text = "";
				txt_itemCode.Text = "";
				txt_itemName.Text = "";

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_NewProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}



		private void Tbtn_SearchProcess()
		{
			try
			{				
				
				this.Cursor = Cursors.WaitCursor;

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_stockYY, cmb_stockMM, cmb_wareHouse};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

				if(! essential_check) return;


//				if(cmb_factory.SelectedIndex == -1 
//					|| cmb_stockYY.SelectedIndex == -1 
//					|| cmb_stockMM.SelectedIndex == -1
//					|| cmb_wareHouse.SelectedIndex == -1) return;
// 

				string factory = cmb_factory.SelectedValue.ToString();
				string stock_ym = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString();
				string item_group = _itemGroupCode;
				string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_itemCode, " ");
				string item_name = ClassLib.ComFunction.Empty_TextBox(txt_itemName, " ");
				string warehouse = ClassLib.ComFunction.Empty_Combo(cmb_wareHouse, " ");


				DataTable vTemp = SELECT_SBK_STOCK_CLOSE(factory, stock_ym, item_group, item_cd, item_name, warehouse);
				spd_main.Display_Grid(vTemp);


				
				//-----------------------------------------------------------
				// relation 관계 적용된 행 표시
				for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
				{
					if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBK_STOCK_CLOSE.IxRELATION_EXIST_YN].Value.ToString().Equals("Y") )
					{

						for(int j = 0; j < spd_main.ActiveSheet.ColumnCount; j++)
						{
							if(spd_main.ActiveSheet.Columns[j].Locked)
							{ 
								spd_main.ActiveSheet.Cells[i, j].ForeColor = ClassLib.ComVar.Clr_Text_Red;
							}
						} // end for j
						
					}
					else
					{

						for(int j = 0; j < spd_main.ActiveSheet.ColumnCount; j++)
						{
							if(spd_main.ActiveSheet.Columns[j].Locked)
							{ 
								spd_main.ActiveSheet.Cells[i, j].ForeColor = Color.Black;
							}
						} // end for j


					}

				}
				//-----------------------------------------------------------




				if (spd_main_Sheet1.Rows.Count > 0)
				{ 

					this.EnableControlCheckProcess();

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this); 

					
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this); 
				}

 

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SearchProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}		


		private void Tbtn_SaveProcess()
		{

			try
			{			
				this.Cursor = Cursors.WaitCursor;

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_stockYY, cmb_stockMM, cmb_wareHouse};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

				if(! essential_check) return;


				if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to Save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
				{
					if(MyOraDB.Save_Spread("PKG_SBK_STOCK_CLOSE.SAVE_SBK_STOCK_CLOSE", spd_main))
					{ 
						spd_main.Refresh_Division();

						EnableControlCheckProcess();

						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
					}
				}

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

 

		}





		private FlexPurchase.Purchase.Pop_BP_Purchase_Wait _popWait = null;


		private void Tbtn_RemakeQtyProcess()
		{

			try
			{

				this.Cursor = Cursors.WaitCursor;

			



                Thread tRun = null;
                tRun = new Thread(new ThreadStart(RunRemakeInOutQty));

                if (tRun != null)
                {
                    tRun.Start();
                    _popWait = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
                    _popWait.Start();


                }



                tRun.Abort();
 



			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default; 

			}


		}



        public void RunRemakeInOutQty()
        {
            Invoke(new DelegateSetn(Run_Remake_InOut_Qty)); // 폼 스레드에 작업 넘김

        }



		// remake 하고, closing 한 경우 처리
		private bool _Make_After_Closing_Flag = true;

		private void Run_Remake_InOut_Qty()
		{

			this.Cursor = Cursors.WaitCursor;

			C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_stockYY, cmb_stockMM, cmb_wareHouse};   
			bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

			if(! essential_check) return;


//				if(cmb_factory.SelectedIndex == -1 
//					|| cmb_stockYY.SelectedIndex == -1 
//					|| cmb_stockMM.SelectedIndex == -1
//					|| cmb_wareHouse.SelectedIndex == -1) return;
//					

			if (DialogResult.No == ClassLib.ComFunction.User_Message("Do you want to Run?", "Run", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) return;

			string factory = cmb_factory.SelectedValue.ToString(); 
			string stock_ym = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString(); 
			

			string upd_user = ClassLib.ComVar.This_User;

 
			string stock_year = cmb_stockYY.SelectedValue.ToString();
			string stock_month = cmb_stockMM.SelectedValue.ToString(); 

			Pop_BK_Stock_Remake_InOut_Qty pop_form = new Pop_BK_Stock_Remake_InOut_Qty(stock_year, stock_month);
			pop_form.ShowDialog(); 


			if (COM.ComVar.Parameter_PopUp == null) return;
  

			string stock_from = COM.ComVar.Parameter_PopUp[0];
			string stock_to = COM.ComVar.Parameter_PopUp[1];  
 

			bool save_flag = Run_STOCK_RESEARCH(factory, stock_from, stock_to, upd_user);

			if(!save_flag)
			{ 
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);

			}
			else
			{ 

				_Make_After_Closing_Flag = false;
 

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);

			} 


			_popWait.Close(); 


		}


		private void Tbtn_ClosingProcess()
		{

			try
			{



                Thread tRun = null;
                tRun = new Thread(new ThreadStart(RunStockClosing));

                if (tRun != null)
                {
                    tRun.Start();
                    _popWait = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
                    _popWait.Start();


                }



                tRun.Abort();



			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default; 

			}

 
			
			 
		}




        public void RunStockClosing()
        {
            Invoke(new DelegateSetn(Run_Stock_Closing)); // 폼 스레드에 작업 넘김

        }





		/// <summary>
		/// Run_Stock_Closing : Stock Closing
		/// </summary>
		private void Run_Stock_Closing()
		{
  		
		
			bool save_flag = false;

			
			try
			{

				this.Cursor = Cursors.WaitCursor;

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_stockYY, cmb_stockMM, cmb_wareHouse};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

				if(! essential_check) 
				{
					_popWait.Close();
					return;
				}


				//				if(cmb_factory.SelectedIndex == -1 
				//					|| cmb_stockYY.SelectedIndex == -1 
				//					|| cmb_stockMM.SelectedIndex == -1
				//					|| cmb_wareHouse.SelectedIndex == -1) return;
				//					

				if (DialogResult.No == ClassLib.ComFunction.User_Message("Do you want to Run?", "Run", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) 
				{
					_popWait.Close();
					return;
				}


				string factory = cmb_factory.SelectedValue.ToString();
				string warehouse = ClassLib.ComFunction.Empty_Combo(cmb_wareHouse, " ");
				string stock_ym = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString(); 
				string upd_user = ClassLib.ComVar.This_User;

				save_flag = Insert_SBK_STOCK_CLOSE(factory, warehouse, stock_ym, upd_user);


				_popWait.Close(); 

				if(!save_flag)
				{ 
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);

				}
				else
				{

					_Make_After_Closing_Flag = true;

					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);

					//Tbtn_SearchProcess();

					

				} 
 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{



			}



		}

 
		private void Tbtn_ConfirmProcess()
		{

			try
			{

				this.Cursor = Cursors.WaitCursor;

			


                Thread tRun = null;
                tRun = new Thread(new ThreadStart(RunStockClosingConfirm));

                if (tRun != null)
                {
                    tRun.Start();
                    _popWait = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
                    _popWait.Start();


                }



                tRun.Abort();
 

 


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default; 

			}


				 
		}




        public void RunStockClosingConfirm()
        {
            Invoke(new DelegateSetn(Run_Stock_Closing_Confirm)); // 폼 스레드에 작업 넘김

        }




		/// <summary>
		/// Run_Stock_Closing_Confirm : Stock Closing Confirm
		/// </summary>
		private void Run_Stock_Closing_Confirm()
		{ 
			 
			this.Cursor = Cursors.WaitCursor;


			C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_stockYY, cmb_stockMM, cmb_wareHouse};   
			bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

			if(! essential_check) 
			{
				_popWait.Close(); 
				return;
			}


//				if(cmb_factory.SelectedIndex == -1 
//					|| cmb_stockYY.SelectedIndex == -1 
//					|| cmb_stockMM.SelectedIndex == -1
//					|| cmb_wareHouse.SelectedIndex == -1) return;


			if(! _Make_After_Closing_Flag)
			{
				ClassLib.ComFunction.User_Message("You need [Closing], because remake in/out quantity.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
				_popWait.Close();
				return;
			}

				


			// 수정 데이터 체크
			if(spd_main.ActiveSheet.Rows.Count > 0)
			{
				for (int i = 0  ; i < spd_main.ActiveSheet.Rows.Count ; i++)
				{
					if (spd_main.ActiveSheet.Cells[i, 0].Tag  != null)
					{
						if(MessageBox.Show(this, "Exist Modify Data, Do you want to continue ?","Confirm", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.No )
						{
							_popWait.Close();
							return;
						}
						else
						{
							break;
						}
					}

				}  // end for i

			} // end if
			




			string stock_status = spd_main.ActiveSheet.Cells[0, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_STATUS].Value.ToString();

			DialogResult result;
			string stock_status_new = "";

			if(stock_status == "C")
			{
				result = ClassLib.ComFunction.User_Message("Do you want to confirm cancel ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				stock_status_new = "S";
			}
			else
			{
				result = ClassLib.ComFunction.User_Message("Do you want to confirm ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				stock_status_new = "C";
			}

			if(result == DialogResult.No) 
			{
				_popWait.Close();
				return;
			}
				

			string factory = cmb_factory.SelectedValue.ToString();
			string warehouse = ClassLib.ComFunction.Empty_Combo(cmb_wareHouse, " ");
			string stock_ym = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString(); 
			string upd_user = ClassLib.ComVar.This_User;

			bool save_flag = Update_SBK_STOCK_CLOSE_STATUS(factory, warehouse, stock_ym, stock_status_new, upd_user);

			if(!save_flag)
			{ 

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);

			}
			else
			{

				for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
				{
					spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_STATUS].Value = stock_status_new;
				}

				spd_main.Recovery();

				//this.EnableControlCheckProcess();

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);

			} 


			this.EnableControlCheckProcess();

			_popWait.Close(); 
 

		}
 
 
		private void Tbtn_PrintProcess()
		{
			C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_stockYY, cmb_stockMM, cmb_wareHouse};   
			bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

			if(! essential_check) return;

			string factory = cmb_factory.SelectedValue.ToString();
			string stock_ym = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString();
			string warehouse = ClassLib.ComFunction.Empty_Combo(cmb_wareHouse, " ");
			string item_group = _itemGroupCode;
			string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_itemCode, " ");
			string item_name = ClassLib.ComFunction.Empty_TextBox(txt_itemName, " ");
			string warehouse_name = cmb_wareHouse.Columns[1].Text;
			string stock_status = txt_stockStatus.Text;

			string item_group_name = "";
				
			if(cmb_itemGroup.SelectedIndex != -1) 
			{
				item_group_name = cmb_itemGroup.Columns[1].Text + ", " + txt_itemGroup.Text;
			} 

			COM.ComVar.Parameter_PopUp = new string[] {factory, stock_ym, warehouse, item_group, item_cd, item_name, warehouse_name, stock_status, item_group_name};

            Pop_BK_Stock_Closing_Print printPop = new Pop_BK_Stock_Closing_Print();
			printPop.ShowDialog();
		}

		#endregion

		#region 아래 버튼 이벤트

		#region 버튼클릭시 이미지변경
 

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

		
		private void btn_Tree_Click(object sender, System.EventArgs e)
		{
			
			if(cmb_factory.SelectedIndex == -1 
				|| cmb_stockYY.SelectedIndex == -1 
				|| cmb_stockMM.SelectedIndex == -1
				|| cmb_wareHouse.SelectedIndex == -1) return;


			if(! _Make_After_Closing_Flag)
			{
				ClassLib.ComFunction.User_Message("You need [Closing], because remake in/out quantity.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			Show_Tree_Popup();
			
		}

		private void btn_Insert_Click(object sender, System.EventArgs e)
		{

			if(cmb_factory.SelectedIndex == -1 
				|| cmb_stockYY.SelectedIndex == -1 
				|| cmb_stockMM.SelectedIndex == -1
				|| cmb_wareHouse.SelectedIndex == -1) return;

			
			if(! _Make_After_Closing_Flag)
			{
				ClassLib.ComFunction.User_Message("You need [Closing], because remake in/out quantity.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			Show_Item_Popup();
			
		} 

		private void btn_delete_Click(object sender, System.EventArgs e)
		{

			if(cmb_factory.SelectedIndex == -1 
				|| cmb_stockYY.SelectedIndex == -1 
				|| cmb_stockMM.SelectedIndex == -1
				|| cmb_wareHouse.SelectedIndex == -1) return;


			if(! _Make_After_Closing_Flag)
			{
				ClassLib.ComFunction.User_Message("You need [Closing], because remake in/out quantity.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			spd_main.Delete_Row(img_Action);

		}


		private void btn_recover_Click(object sender, System.EventArgs e)
		{
			if(cmb_factory.SelectedIndex == -1 
				|| cmb_stockYY.SelectedIndex == -1 
				|| cmb_stockMM.SelectedIndex == -1
				|| cmb_wareHouse.SelectedIndex == -1) return;


			if(! _Make_After_Closing_Flag)
			{
				ClassLib.ComFunction.User_Message("You need [Closing], because remake in/out quantity.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			spd_main.Recovery();
		}

 
 

		/// <summary>
		/// Show_Tree_Popup : 데이터 입력하는 팝업을 Tree로 실행
		/// </summary>
		private void Show_Tree_Popup()
		{
			try
			{
 

				int style_col = 0;
				int item_col = (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_CD;
				int spec_col = (int)ClassLib.TBSBK_STOCK_CLOSE.IxSPEC_CD;
				int color_col = (int)ClassLib.TBSBK_STOCK_CLOSE.IxCOLOR_CD;

				int[] vChecks = new int[]{style_col, item_col, spec_col, color_col};
				ClassLib.ComVar.Parameter_PopUp = new string[]{ClassLib.ComFunction.Empty_Combo(cmb_factory, COM.ComVar.This_Factory), "P"};
				FlexPurchase.Purchase.Pop_BC_Yield_Info vPop = new FlexPurchase.Purchase.Pop_BC_Yield_Info(spd_main, vChecks);
				vPop._style = "";
				vPop.ShowDialog();


				if(ClassLib.ComVar.Parameter_PopUpTable == null) return;


				this.Cursor = Cursors.WaitCursor;


				string factory = cmb_factory.SelectedValue.ToString();
				string warehouse = ClassLib.ComFunction.Empty_Combo(cmb_wareHouse, " "); 
				string stock_ym = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString(); 


				// 1. 중복 여부 체크 추가 해서 재구성.
				// 2. 중북 아닌 리스트를 다시 그리드 i 인 항목에서 중복 체크 재 실시.
				bool save_flag = Etc_DataDuplicateCheck_1(factory, warehouse, stock_ym, ClassLib.ComVar.Parameter_PopUpTable);

				if(! save_flag) return;

				DataTable dt_ret = Etc_DataDuplicateCheck_2(factory, warehouse, stock_ym); 

				string exist_yn = "";
				string item_cd = "", item_name = "";
				string spec_cd = "", spec_name = "";
				string color_cd = "", color_name = "";

				string exist_list = "";

				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{

					exist_yn = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBT_STOCK_ITEM.IxEXIST_YN].ToString();

					item_cd = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBT_STOCK_ITEM.IxITEM_CD].ToString();
					item_name = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBT_STOCK_ITEM.IxITEM_NAME].ToString();
					spec_cd = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBT_STOCK_ITEM.IxSPEC_CD].ToString();
					spec_name = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBT_STOCK_ITEM.IxSPEC_NAME].ToString();
					color_cd = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBT_STOCK_ITEM.IxCOLOR_CD].ToString();
					color_name = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBT_STOCK_ITEM.IxCOLOR_NAME].ToString(); 


					if(exist_yn == "Y")
					{
						exist_list += "\r\n" 
							+ "Item : " + item_name + "/ "
							+ "spec : " + spec_name + "/ "
							+ "color : " + color_name;

						continue;
					}

					
					if(Etc_DataDuplicateCheck(item_cd, spec_cd, color_cd))
					{				 

						int row = spd_main.Add_Row(img_Action);
      

						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxFACTORY].Value = cmb_factory.SelectedValue; 
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxWH_CD].Value = cmb_wareHouse.SelectedValue; 
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxWH_NAME].Value = cmb_wareHouse.Columns[1].Text; 
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_YMD].Value = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString();

 
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_CD].Value 
							= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBT_STOCK_ITEM.IxITEM_CD].ToString();

						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_NAME].Value
							= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBT_STOCK_ITEM.IxITEM_NAME].ToString();

						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSPEC_CD].Value
							= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBT_STOCK_ITEM.IxSPEC_CD].ToString();

						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSPEC_NAME].Value
							= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBT_STOCK_ITEM.IxSPEC_NAME].ToString();

						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxCOLOR_CD].Value
							= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBT_STOCK_ITEM.IxCOLOR_CD].ToString();

						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxCOLOR_NAME].Value
							= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBT_STOCK_ITEM.IxCOLOR_NAME].ToString();

						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxBAES_QTY].Value = (decimal)0;
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxIN_QTY].Value = (decimal)0;
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxOUT_QTY].Value = (decimal)0;
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxADJUST_QTY].Value = (decimal)0;
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_QTY].Value = (decimal)0;


						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxMNG_UNIT].Value 
							= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBT_STOCK_ITEM.IxMNG_UNIT].ToString();

						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_STATUS].Value = "S";
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxRELATION_EXIST_YN].Value = "N";
 
						//top row 기능
						spd_main.Set_CellPosition(row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_NAME); 


					}
					else
					{

						exist_list += "\r\n" 
							+ "Item : " + dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBT_STOCK_ITEM.IxITEM_NAME].ToString() + "/ "
							+ "spec : " + dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBT_STOCK_ITEM.IxSPEC_NAME].ToString() + "/ "
							+ "color : " + dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBT_STOCK_ITEM.IxCOLOR_NAME].ToString();

					}


				}



				if(! exist_list.Trim().Equals("") )
				{
					string message = "Duplicate List" + "\r\n" + exist_list;

					ClassLib.ComFunction.User_Message(message, "Duplicate List", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}


	
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Tree_Popup", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}




		/// <summary>
		/// Show_Item_Popup : Item 기타 데이터 입력하는 팝업 실행 : Item/ Specification/ Color
		/// </summary>
		private void Show_Item_Popup()
		{
			try
			{
				FlexBase.MaterialBase.Pop_Item_List vPopup = new FlexBase.MaterialBase.Pop_Item_List();
				vPopup.ShowDialog(); 

				if(ClassLib.ComVar.Parameter_PopUp[0].Trim() != "")
				{
					string item_cd = ClassLib.ComVar.Parameter_PopUp[0];
					string spec_cd = ClassLib.ComVar.Parameter_PopUp[2];
					string color_cd = ClassLib.ComVar.Parameter_PopUp[4];


					//---------------------------------------------------------------------------------
					// 중복 체크 위해서 데이터 테이블 구성
					//---------------------------------------------------------------------------------
					ClassLib.ComVar.Parameter_PopUpTable = new DataTable();
					DataColumn[] dc = new DataColumn[10];

					dc[0]  = new DataColumn("item_cd",Type.GetType("System.String"));
					dc[1]  = new DataColumn("item_nm",Type.GetType("System.String"));
					dc[2]  = new DataColumn("spec_cd",Type.GetType("System.String"));
					dc[3]  = new DataColumn("spec_nm",Type.GetType("System.String"));
					dc[4]  = new DataColumn("color_cd",Type.GetType("System.String"));
					dc[5]  = new DataColumn("color_nm",Type.GetType("System.String"));
					dc[6]  = new DataColumn("unit",Type.GetType("System.String"));
					dc[7]  = new DataColumn("factory",Type.GetType("System.String"));
					dc[8]  = new DataColumn("style_cd",Type.GetType("System.String"));
					dc[9]  = new DataColumn("component_cd",Type.GetType("System.String"));

					ClassLib.ComVar.Parameter_PopUpTable.Columns.AddRange(dc);

					DataRow newRow =  ClassLib.ComVar.Parameter_PopUpTable.NewRow();
					newRow[0]  = item_cd;	 // item_cd
					newRow[1]  = "";		 // item_nm
					newRow[2]  = spec_cd;    // spec_cd
					newRow[3]  = "";		 // spec_nm
					newRow[4]  = color_cd;   // color_cd
					newRow[5]  = "";		 // color_nm
					newRow[6]  = "";		 // unit
					newRow[7]  = "";		 // factory
					newRow[8]  = "";	     // style_cd
					newRow[9]  = "";		 // component

					ClassLib.ComVar.Parameter_PopUpTable.Rows.Add(newRow);
					//---------------------------------------------------------------------------------


					string factory = cmb_factory.SelectedValue.ToString();
					string warehouse = ClassLib.ComFunction.Empty_Combo(cmb_wareHouse, " "); 
					string stock_ym = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString(); 


					// 1. 중복 여부 체크 추가 해서 재구성.
					// 2. 중북 아닌 리스트를 다시 그리드 i 인 항목에서 중복 체크 재 실시.
					bool save_flag = Etc_DataDuplicateCheck_1(factory, warehouse, stock_ym, ClassLib.ComVar.Parameter_PopUpTable);

					if(! save_flag) return;

					DataTable dt_ret = Etc_DataDuplicateCheck_2(factory, warehouse, stock_ym);
 

					string exist_yn = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBT_STOCK_ITEM.IxEXIST_YN].ToString();

					if(exist_yn == "Y") 
					{
						string message = "Duplicate List" + "\r\n" 
							+ "\r\n" 
							+ "Item : " + ClassLib.ComVar.Parameter_PopUp[1] + "/ "
							+ "spec : " + ClassLib.ComVar.Parameter_PopUp[3] + "/ "
							+ "color : " + ClassLib.ComVar.Parameter_PopUp[5]; 

						ClassLib.ComFunction.User_Message(message, "Duplicate List", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}


					if(Etc_DataDuplicateCheck(item_cd, spec_cd, color_cd))
					{				 

						int row = spd_main.Add_Row(img_Action) ;
     

						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxFACTORY].Value = cmb_factory.SelectedValue; 
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxWH_CD].Value = cmb_wareHouse.SelectedValue; 
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxWH_NAME].Value = cmb_wareHouse.Columns[1].Text; 
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_YMD].Value = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString();

 
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_CD].Value = ClassLib.ComVar.Parameter_PopUp[0];
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_NAME].Value = ClassLib.ComVar.Parameter_PopUp[1];
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSPEC_CD].Value = ClassLib.ComVar.Parameter_PopUp[2];
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSPEC_NAME].Value = ClassLib.ComVar.Parameter_PopUp[3];
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxCOLOR_CD].Value = ClassLib.ComVar.Parameter_PopUp[4];
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxCOLOR_NAME].Value = ClassLib.ComVar.Parameter_PopUp[5];
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxBAES_QTY].Value = (decimal)0;
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxIN_QTY].Value = (decimal)0;
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxOUT_QTY].Value = (decimal)0; 
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxADJUST_QTY].Value = (decimal)0;
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_QTY].Value = (decimal)0;
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxMNG_UNIT].Value = ClassLib.ComVar.Parameter_PopUp[6];
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_STATUS].Value = "S";
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxRELATION_EXIST_YN].Value = "N";
 
 

						//top row 기능
						spd_main.Set_CellPosition(row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_NAME); 


					}
					else
					{

						string message = "Duplicate List" + "\r\n" 
							+ "\r\n" 
							+ "Item : " + ClassLib.ComVar.Parameter_PopUp[1] + "/ "
							+ "spec : " + ClassLib.ComVar.Parameter_PopUp[3] + "/ "
							+ "color : " + ClassLib.ComVar.Parameter_PopUp[5]; 

						ClassLib.ComFunction.User_Message(message, "Duplicate List", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;

					}


				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private bool Etc_DataDuplicateCheck(string arg_item_cd, string arg_spec_cd, string arg_color_cd)
		{

			for ( int vRow = 0 ; vRow < spd_main.ActiveSheet.RowCount ; vRow++ )
			{

				spd_main.ActiveSheet.Cells[vRow, 0].Tag = (spd_main.ActiveSheet.Cells[vRow, 0].Tag == null) ? "" : spd_main.ActiveSheet.Cells[vRow, 0].Tag.ToString();

				if(spd_main.ActiveSheet.Cells[vRow, 0].Tag.ToString() != "I") continue;

				if( spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_CD].Text.Equals(arg_item_cd) && 
					spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSPEC_CD].Text.Equals(arg_spec_cd) &&
					spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxCOLOR_CD].Text.Equals(arg_color_cd)) 
				{
					//ClassLib.ComFunction.User_Message("The selected item is already exists.", "DataDuplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return false;
				}
			}

			return true;
  
		}



		private bool Etc_DataDuplicateCheck_1(string arg_factory, string arg_warehouse, string arg_stock_ym, DataTable arg_dt)
		{
			 

			try
			{
				
				DataSet ds_ret; 

				int col_ct = 8;    
				int para_ct = 0;  
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBK_STOCK_BASE.CHECK_DUPLICATE";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";   
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_WAREHOUSE";
				MyOraDB.Parameter_Name[3] = "ARG_STOCK_YMD";
				MyOraDB.Parameter_Name[4] = "ARG_ITEM_CD"; 
				MyOraDB.Parameter_Name[5] = "ARG_SPEC_CD";   
				MyOraDB.Parameter_Name[6] = "ARG_COLOR_CD";
				MyOraDB.Parameter_Name[7] = "ARG_UPD_USER"; 



				// 파라미터의 데이터 Type
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar; 
 


				// 파라미터 값에 저장할 배열
				// + 1 : Delete 쿼리 추가
				MyOraDB.Parameter_Values  = new string[col_ct * (arg_dt.Rows.Count + 1) ];  
				


				// 각 행의 변경값 Setting

				MyOraDB.Parameter_Values[para_ct++] = "D";
				MyOraDB.Parameter_Values[para_ct++] = arg_factory;
				MyOraDB.Parameter_Values[para_ct++] = arg_warehouse;
				MyOraDB.Parameter_Values[para_ct++] = arg_stock_ym;
				MyOraDB.Parameter_Values[para_ct++] = "";
				MyOraDB.Parameter_Values[para_ct++] = "";
				MyOraDB.Parameter_Values[para_ct++] = "";
				MyOraDB.Parameter_Values[para_ct++] = ""; 

				for(int i = 0 ; i < arg_dt.Rows.Count; i++)
				{ 

					MyOraDB.Parameter_Values[para_ct++] = "I";
					MyOraDB.Parameter_Values[para_ct++] = arg_factory;
					MyOraDB.Parameter_Values[para_ct++] = arg_warehouse;
					MyOraDB.Parameter_Values[para_ct++] = arg_stock_ym;
					MyOraDB.Parameter_Values[para_ct++] = arg_dt.Rows[i]["item_cd"].ToString();
					MyOraDB.Parameter_Values[para_ct++] = arg_dt.Rows[i]["spec_cd"].ToString();
					MyOraDB.Parameter_Values[para_ct++] = arg_dt.Rows[i]["color_cd"].ToString();
					MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User; 

				}
				  

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
			catch
			{
				return false;
			}
  

		}

		 
		private DataTable Etc_DataDuplicateCheck_2(string arg_factory, string arg_warehouse, string arg_stock_ym)
		{
			 

			try
			{
				
				DataSet ds_ret;  

				MyOraDB.ReDim_Parameter(4);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBK_STOCK_BASE.SELECT_SBT_TEMP_STOCK_ITEM";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_WAREHOUSE"; 
				MyOraDB.Parameter_Name[2] = "ARG_STOCK_YMD";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

				//04.DATA 정의

				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_warehouse; 
				MyOraDB.Parameter_Values[2] = arg_stock_ym;
				MyOraDB.Parameter_Values[3] = "";

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();
				if(ds_ret == null) return null ;

				return ds_ret.Tables[MyOraDB.Process_Name]; 

			}
			catch
			{
				return null;
			}
  

		}



		#endregion

		#region 팝업 메뉴 이벤트

		
		private void cmenu_grid_Popup(object sender, System.EventArgs e)
		{
            if (spd_main.ActiveSheet.RowCount <= spd_main.ActiveSheet.FrozenRowCount) return;

			CellRange[] vSelectionRange = spd_main.ActiveSheet.GetSelections(); 

			int sel_count = 0;

			for(int i = 0; i < vSelectionRange.Length; i++)
			{
				sel_count += vSelectionRange[i].RowCount;
			}






			if(!_Make_After_Closing_Flag)  
			{
				menuItem_MovingWH.Enabled = false;
				menuItem_ValueChange.Enabled = false;
				menuItem_CBD.Enabled = false;
			}
			else
			{
 
 
				int vCol = spd_main.ActiveSheet.ActiveColumnIndex;
				int vRow = spd_main.ActiveSheet.ActiveRowIndex;

				string stock_status = spd_main.ActiveSheet.Cells[0, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_STATUS].Value.ToString(); 

				if(stock_status != "C")   // confirm
				{ 
					if(sel_count > 1)	 
					{
						menuItem_MovingWH.Enabled = false; 
					}
					else
					{
						 
						menuItem_MovingWH.Enabled = true;  

					}
				}
						


				

				if (spd_main.ActiveSheet.OperationMode == OperationMode.ReadOnly || spd_main.ActiveSheet.Columns[vCol].Locked)
				{
					menuItem_ValueChange.Enabled = false;
					menuItem_CBD.Enabled = false;
				}
				else
				{ 

					menuItem_ValueChange.Enabled = true;
					menuItem_CBD.Enabled = true;
				 
				}


			} // end if(! _Make_After_Closing_Flag)


			if(sel_count > 1)	 
			{
				 
				menuItem_ItemRelation.Enabled = true;
				menuItem_SpecRelation.Enabled = false;
				menuItem_ColorRelation.Enabled = false;

			}
			else
			{
				 
				menuItem_ItemRelation.Enabled = true;
				menuItem_SpecRelation.Enabled = true;
				menuItem_ColorRelation.Enabled = true;
			}
						

			

		}



		private void menuItem_ValueChange_Click(object sender, System.EventArgs e)
		{
		 	
			int vRow = spd_main.ActiveSheet.ActiveRowIndex;
			int vCol = spd_main.ActiveSheet.ActiveColumnIndex;
  
			if (spd_main.ActiveSheet.OperationMode != OperationMode.ReadOnly && !spd_main.ActiveSheet.Columns[vCol].Locked)
			{

				// relation 에 의해서 합쳐진 데이터에 대해서는
				// old 코드에 대한 팝업 리스트 표시 후, 바로 디비 적용
				if(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxRELATION_EXIST_YN].Value.ToString().Equals("Y") )
				{
					ValueExchangeProcessing_Relation(vRow, vCol);
				}
				else
				{
					ValueExchangeProcessing(vCol);
				} 

			} 

		}


		private void menuItem_MovingWH_Click(object sender, System.EventArgs e)
		{
		

			try
			{ 

				int vRow = spd_main.ActiveSheet.ActiveRowIndex; 
				int vCol = spd_main.ActiveSheet.ActiveColumnIndex; 

				// relation 에 의해서 합쳐진 데이터에 대해서는
				// old 코드에 대한 팝업 리스트 표시 후, 바로 디비 적용
				if(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxRELATION_EXIST_YN].Value.ToString().Equals("Y") )
				{
					ValueExchangeProcessing_Relation(vRow, vCol);
				}
				else
				{
					
				    Moving_Warehouse(vRow);
				}  

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_Moving_WareHouse_Partial_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}




		private void menuItem_CBD_Click(object sender, System.EventArgs e)
		{


			try
			{

				int vRow = spd_main.ActiveSheet.ActiveRowIndex; 
				int vCol = spd_main.ActiveSheet.ActiveColumnIndex; 

				// relation 에 의해서 합쳐진 데이터에 대해서는
				// old 코드에 대한 팝업 리스트 표시 후, 바로 디비 적용
				if(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxRELATION_EXIST_YN].Value.ToString().Equals("Y") )
				{
					ValueExchangeProcessing_Relation(vRow, vCol);
				}
				else
				{ 
					Get_CBD();
				} 


				
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_CBD_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}
 

		private void ValueExchangeProcessing_Relation(int vRow, int vCol)
		{

			try
			{
				string factory = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxFACTORY].Value.ToString();
				string whcd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxWH_CD].Value.ToString();
				string stockymd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_YMD].Value.ToString();
				string itemcd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_CD].Value.ToString();
				string speccd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSPEC_CD].Value.ToString();
				string colorcd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxCOLOR_CD].Value.ToString();

				string tablehead_pgid = "SBK_STOCK_CLOSE";

				DataTable dt_ret = Select_SBK_STOCK_RELATION(factory, whcd, stockymd, itemcd, speccd, colorcd);

				Pop_BK_Material_Relation_Modify pop_form = new Pop_BK_Material_Relation_Modify(dt_ret, tablehead_pgid);
				pop_form.ShowDialog();


				//---------------------------------------------------------------
				// 데이터 수정된 후 그리드에 새로운 데이터 표시 

				if(ClassLib.ComVar.Parameter_PopUpTable == null || ClassLib.ComVar.Parameter_PopUpTable.Rows.Count == 0) return;

				for(int i = 1; i < spd_main.ActiveSheet.ColumnCount; i++)
				{
					if (spd_main.ActiveSheet.Columns[i].Locked) continue;

					spd_main.ActiveSheet.Cells[vRow, i].Value = ClassLib.ComVar.Parameter_PopUpTable.Rows[0].ItemArray[i]; 


					//--------------------------------------------------------------
					if(i == (int)ClassLib.TBSBK_STOCK_CLOSE.IxADJUST_QTY)
					{
						Update_StockQty(vRow, i);
					}
					if(i == (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_QTY)
					{
						Update_AdjustQty(vRow, i);
					}
					//--------------------------------------------------------------
 

				}

				//---------------------------------------------------------------
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "ValueExchangeProcessing_Relation", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}



		private void ValueExchangeProcessing(int vCol)
		{
			try
			{ 
				ClassLib.ComVar.Parameter_PopUp_Object  = null;
				ClassLib.ComVar.Parameter_PopUp_Object2 = null;
				ClassLib.ComVar.Parameter_PopUpTable	= null; 

				CellRange[] vSelectionRange = spd_main.ActiveSheet.GetSelections(); 

				if (vSelectionRange != null)
				{
					COM.ComVar.Parameter_PopUp		= new string[1];
					COM.ComVar.Parameter_PopUp[0]	= spd_main.ActiveSheet.ColumnHeader.Cells[2,vCol].Text;  
				
					if (_cellTypes.ContainsKey(vCol))  
					{
						ClassLib.ComVar.Parameter_PopUp_Object  = new object[]{_cellData[vCol]};
						ClassLib.ComVar.Parameter_PopUp_Object2 = new object[]{_cellTypes[vCol]};
					}
					FlexPurchase.Incoming.Pop_BI_Incoming_List_Changer pop_changer = new FlexPurchase.Incoming.Pop_BI_Incoming_List_Changer();
					pop_changer.ShowDialog();

					if (COM.ComVar.Parameter_PopUp != null)
						for (int i = 0 ; i < vSelectionRange.Length; i++)
						{
							int start_row = vSelectionRange[i].Row;
							int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

							for (int j = start_row ; j < end_row; j++)
							{
								spd_main.ActiveSheet.Cells[j, vCol].Value		= COM.ComVar.Parameter_PopUp[0];    // Set TextBox Text

								if (COM.ComVar.Parameter_PopUp.Length > 1)
									spd_main.ActiveSheet.Cells[j, vCol].Value = COM.ComVar.Parameter_PopUp[1];	// Set SSPComboBox Value
								
								spd_main.Update_Row(j, img_Action);


								//--------------------------------------------------------------
								if(vCol == (int)ClassLib.TBSBK_STOCK_CLOSE.IxADJUST_QTY)
								{
									Update_StockQty(j, vCol);
								}
								if(vCol == (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_QTY)
								{
									Update_AdjustQty(j, vCol);
								}
								//--------------------------------------------------------------
 

							}
						}		  

					pop_changer.Dispose();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_ValueExchange_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		

		private void Moving_Warehouse(int vRow)
		{ 

			try
			{ 
 
				string factory = cmb_factory.SelectedValue.ToString();
				string warehouse_old = ClassLib.ComFunction.Empty_Combo(cmb_wareHouse, " ");
				//				string base_qty_old = Convert.ToString(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxBAES_QTY].Value
				//														+ spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxIN_QTY].Value
				//														- spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxOUT_QTY].Value
				//														+ spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxADJUST_QTY].Value);

				string base_qty_old = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_QTY].Value.ToString();

				// PopUp -- Incoming WareHouse Select
				COM.ComVar.Parameter_PopUp = new string[3];
				COM.ComVar.Parameter_PopUp[0] = factory;
				COM.ComVar.Parameter_PopUp[1] = warehouse_old;
				COM.ComVar.Parameter_PopUp[2] = base_qty_old;


				Pop_BK_Moving_WareHouse pop_changer = new Pop_BK_Moving_WareHouse();
				pop_changer.ShowDialog(); 


				if (COM.ComVar.Parameter_PopUp == null) return;
  

				string wh_cd = COM.ComVar.Parameter_PopUp[0];
				string moving_qty = COM.ComVar.Parameter_PopUp[1]; 
					  


				
				string warehouse_new = wh_cd;
				string stock_ym = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_YMD].Value.ToString();
				string item_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_CD].Value.ToString();
				string spec_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSPEC_CD].Value.ToString();
				string color_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxCOLOR_CD].Value.ToString();
				string base_qty_new = moving_qty; 

				string[] parameter = new string[] { factory,
													  warehouse_old,
													  warehouse_new,
													  stock_ym,
													  item_cd,
													  spec_cd,
													  color_cd,
													  base_qty_new };

				bool save_flag = FlexPurchase.Stock.Form_BK_Stock_Base.Update_SBK_STOCK_BASE_WH(parameter);

    
				if(! save_flag)
				{

					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
					return;

				}
				else
				{ 

					// 기존 데이터 수량 변경
					decimal adjust_qty_new = decimal.Parse(moving_qty); // Moving Qty		
					decimal adjust_qty_old  = decimal.Parse(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxADJUST_QTY].Value.ToString() ); 
					decimal remain_qty = adjust_qty_old - adjust_qty_new; 

					//					if(remain_qty == 0)
					//					{
					//						spd_main.ActiveSheet.RemoveRows(vRow,1); 
					//					}
					//					else
					//					{
					//						spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxADJUST_QTY].Value = remain_qty; 
					//						Update_StockQty(vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxADJUST_QTY); 
					//					}


					spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxADJUST_QTY].Value = remain_qty; 
					Update_StockQty(vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxADJUST_QTY); 


					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);


				} 


				  

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_Moving_WareHouse_Partial_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}


		private void Get_CBD()
		{

			/*****************************************
				0 : FACTORY,	  		1 : PUR_USER,
				2 : CUST_CD,			3 : CUST_NAME,
				4 :	PK_UNIT_QTY,		5 : PUR_PRICE,
				6 :	PUR_CURRENCY, 		7 : OUTSIDE_PRICE,
				8 :	OUTSIDE_CURRENCY, 	9 : CBD_PRICE,
				10 : CBD_CURRENCY,		11 : SHIP_PRICE,
				12 : SHIP_CURRENCY, 	13 : CBM,
				14 : WEIGHT
				*****************************************/
			int[] keys = new int[]{ (int)ClassLib.TBSBK_STOCK_CLOSE.IxFACTORY,
									  -1,
									  (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_CD,
									  (int)ClassLib.TBSBK_STOCK_CLOSE.IxSPEC_CD,
									  (int)ClassLib.TBSBK_STOCK_CLOSE.IxCOLOR_CD };

			int[] values = new int[]{ 
										-1,												
										-1, //(int)ClassLib.TBSBK_STOCK_CLOSE.IxPUR_USER,
										-1, //(int)ClassLib.TBSBK_STOCK_CLOSE.IxCUST_CD,	
										-1, //(int)ClassLib.TBSBK_STOCK_CLOSE.IxVENDOR,
										-1, //(int)ClassLib.TBSBK_STOCK_CLOSE.IxPK_UNIT_QTY,
										(int)ClassLib.TBSBK_STOCK_CLOSE.IxPUR_PRICE,	
										(int)ClassLib.TBSBK_STOCK_CLOSE.IxPUR_CURRENCY,
										-1,												
										-1,
										(int)ClassLib.TBSBK_STOCK_CLOSE.IxCBD_PRICE,
										(int)ClassLib.TBSBK_STOCK_CLOSE.IxCBD_CURRENCY,
										(int)ClassLib.TBSBK_STOCK_CLOSE.IxSHIP_PRICE,	
										(int)ClassLib.TBSBK_STOCK_CLOSE.IxSHIP_CURRENCY,
										-1,												
										-1
									};

			FlexPurchase.Shipping.Pop_BC_CBD_Information vPop = new FlexPurchase.Shipping.Pop_BC_CBD_Information(spd_main, keys, values);
			vPop._style = "";
			vPop.ShowDialog(this);


		}



		private void Grid_EditModeOnProcess(COM.SSP arg_grid)
		{
			int vRow = arg_grid.Sheets[0].ActiveRowIndex ;
			int vCol = arg_grid.Sheets[0].ActiveColumnIndex ;
			
			if (arg_grid.Sheets[0].Cells[vRow, vCol].Value == null || arg_grid.Sheets[0].Columns[vCol].CellType == null)
				return;
			
			arg_grid.Buffer_CellData = arg_grid.Sheets[0].Cells[vRow, vCol].Value.ToString();
			string vTemp = arg_grid.Sheets[0].Columns[vCol].CellType.ToString() ;
			if (vTemp == "CheckBoxCellType" || vTemp == "SSPComboBoxCellType"  )
			{
				arg_grid.Buffer_CellData = "000" ;
				arg_grid.Update_Row(img_Action) ;
			}
		}



		private void menuItem_InOut_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_stockYY, cmb_stockMM, cmb_wareHouse};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;

				if(spd_main.ActiveSheet.RowCount == 0) return;


				MenuItem src = sender as MenuItem;
				string division = "";
				if(src.Equals(menuItem_In) )
				{
					division = "I";
				}
				else if(src.Equals(menuItem_Out) )
				{
					division = "O";
				}

				 
				string factory = cmb_factory.SelectedValue.ToString();
				string stock_ym = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString();  
				string warehouse = cmb_wareHouse.SelectedValue.ToString();  

				int vRow = spd_main.ActiveSheet.ActiveRowIndex;
				string item_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_CD].Value.ToString();
				string spec_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSPEC_CD].Value.ToString();
				string color_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxCOLOR_CD].Value.ToString(); 
				string item_name = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_NAME].Value.ToString();
				string spec_name = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSPEC_NAME].Value.ToString();
				string color_name = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxCOLOR_NAME].Value.ToString(); 
 

				string[] pop_parameter = new string[] { division, 
														  factory, 
														  stock_ym, 
														  warehouse,
														  item_cd, 
														  spec_cd, 
														  color_cd, 
														  item_name, 
														  spec_name, 
														  color_name };

				Pop_BK_InOut_Infomation pop_form = new Pop_BK_InOut_Infomation(pop_parameter);
				pop_form.ShowDialog();




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_InOut_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}
 


		private void menuItem_MakeRelation_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_stockYY, cmb_stockMM, cmb_wareHouse};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;

				if(spd_main.ActiveSheet.RowCount == 0) return;


				MenuItem src = sender as MenuItem;
				
				int vRow = spd_main.ActiveSheet.ActiveRowIndex;
				string factory = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxFACTORY].Value.ToString();
				
				string division = "";

				if(src.Equals(menuItem_ItemRelation) )
				{
					division = "1";
				}
				else if(src.Equals(menuItem_SpecRelation) )
				{
					division = "2";
				}
				else if(src.Equals(menuItem_ColorRelation) )
				{
					division = "3";
				}

				  
				if(src.Equals(menuItem_ItemRelation) )
				{
					


					CellRange[] vSelectionRange = spd_main.ActiveSheet.GetSelections(); 

					DataSet temp_DataSet = new System.Data.DataSet();
					DataRow newrow; 

					ClassLib.ComVar.Parameter_PopUpTable2 = temp_DataSet.Tables.Add("Item List");
					ClassLib.ComVar.Parameter_PopUpTable2.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
					ClassLib.ComVar.Parameter_PopUpTable2.Columns.Add(new DataColumn("Name", Type.GetType("System.String"))); 


					for (int i = 0 ; i < vSelectionRange.Length; i++)
					{
						int start_row = vSelectionRange[i].Row;
						int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

						for (int j = start_row ; j < end_row; j++)
						{
							newrow = ClassLib.ComVar.Parameter_PopUpTable2.NewRow(); 
							newrow[0] = spd_main.ActiveSheet.Cells[j, (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_CD].Value.ToString();
							newrow[1] = spd_main.ActiveSheet.Cells[j, (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_NAME].Value.ToString();  
							ClassLib.ComVar.Parameter_PopUpTable2.Rows.Add(newrow);
						}
					}		  



					Pop_BK_Material_Relation pop_form = new Pop_BK_Material_Relation(factory, division, ClassLib.ComVar.Parameter_PopUpTable2);
					pop_form.ShowDialog();

				}
				else 
				{

					
					string item_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_CD].Value.ToString();
					string spec_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSPEC_CD].Value.ToString();
					string color_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxCOLOR_CD].Value.ToString(); 
					string item_name = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_NAME].Value.ToString();
					string spec_name = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSPEC_NAME].Value.ToString();
					string color_name = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxCOLOR_NAME].Value.ToString(); 
					string unit = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxMNG_UNIT].Value.ToString(); 
 

					string[] pop_parameter = new string[] {factory, division, item_cd, spec_cd, color_cd, item_name, spec_name, color_name, unit};

					Pop_BK_Material_Relation pop_form = new Pop_BK_Material_Relation(pop_parameter);
					pop_form.ShowDialog();
					
 
				} 
				

				



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_InOut_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}

		
 


		#endregion

		#region DB Connect
 		



		/// <summary>
		/// SELECT_SBK_STOCK_CLOSE : 
		/// </summary>
		/// <returns>DataTable</returns>
		private DataTable SELECT_SBK_STOCK_CLOSE(string arg_factory, 
			string arg_stock_ymd, 
			string arg_item_group, 
			string arg_item_cd, 
			string arg_item_name, 
			string arg_warehouse)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBK_STOCK_CLOSE.SELECT_SBK_STOCK_CLOSE"; 

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STOCK_YMD";
			MyOraDB.Parameter_Name[2] = "ARG_ITEM_GROUP";
			MyOraDB.Parameter_Name[3] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[4] = "ARG_ITEM_NAME";
			MyOraDB.Parameter_Name[5] = "ARG_WAREHOUSE";
			MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_stock_ymd;
			MyOraDB.Parameter_Values[2] = arg_item_group;
			MyOraDB.Parameter_Values[3] = arg_item_cd;
			MyOraDB.Parameter_Values[4] = arg_item_name;
			MyOraDB.Parameter_Values[5] = arg_warehouse;
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


 

		/// <summary>
		/// Run_STOCK_RESEARCH : 
		/// </summary>
		/// <returns>DataTable</returns>
		private bool Run_STOCK_RESEARCH(string arg_factory, 
			string arg_stock_from, 
			string arg_stock_to, 
			string arg_upd_user)
		{

			try
			{
	 
				DataSet ds_ret; 

				int col_ct = 4;    
					 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBK_STOCK.RUN_STOCK_RESEARCH";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";   
				MyOraDB.Parameter_Name[1] = "ARG_STOCK_FROM"; 
				MyOraDB.Parameter_Name[2] = "ARG_STOCK_TO"; 
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER"; 


				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 

					 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_stock_from;
				MyOraDB.Parameter_Values[2] = arg_stock_to;
				MyOraDB.Parameter_Values[3] = arg_upd_user; 
	 
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
			catch
			{
				return false;
			}


		}


		/// <summary>
		/// Insert_SBK_STOCK_CLOSE : 
		/// </summary>
		/// <returns>DataTable</returns>
		private bool Insert_SBK_STOCK_CLOSE(string arg_factory, 
			string arg_warehouse, 
			string arg_stock_ym, 
			string arg_upd_user)
		{

			try
			{
 
				DataSet ds_ret; 

				int col_ct = 4;    
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBK_STOCK_CLOSE.INSERT_SBK_STOCK_CLOSE";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";   
				MyOraDB.Parameter_Name[1] = "ARG_WH_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_STOCK_YMD"; 
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER"; 


				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 

				 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_warehouse;
				MyOraDB.Parameter_Values[2] = arg_stock_ym;
				MyOraDB.Parameter_Values[3] = arg_upd_user; 
 
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
			catch
			{
				return false;
			}


		}


		/// <summary>
		/// Update_SBK_STOCK_CLOSE_STATUS : 
		/// </summary>
		/// <returns>DataTable</returns>
		private bool Update_SBK_STOCK_CLOSE_STATUS(string arg_factory, 
			string arg_warehouse, 
			string arg_stock_ym,
			string arg_stock_status_new,
			string arg_upd_user)
		{

			try
			{
 
				DataSet ds_ret; 

				int col_ct = 5;    
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBK_STOCK_CLOSE.UPDATE_SBK_STOCK_CLOSE_STATUS";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";   
				MyOraDB.Parameter_Name[1] = "ARG_WH_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_STOCK_YMD"; 
				MyOraDB.Parameter_Name[3] = "ARG_STOCK_STATUS";
				MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";  


				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 

				 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_warehouse;
				MyOraDB.Parameter_Values[2] = arg_stock_ym;
				MyOraDB.Parameter_Values[3] = arg_stock_status_new; 
				MyOraDB.Parameter_Values[4] = arg_upd_user; 
 
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
			catch
			{
				return false;
			}


		} 




		/// <summary>
		/// Select_SBK_STOCK : 
		/// </summary> 
		private DataTable Select_SBK_STOCK_RELATION(string arg_factory, 
			string arg_whcd, 
			string arg_stockymd, 
			string arg_itemcd, 
			string arg_speccd, 
			string arg_colorcd)
		{
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBK_STOCK_CLOSE.SELECT_SBK_STOCK_RELATION";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_WH_CD";
			MyOraDB.Parameter_Name[2] = "ARG_STOCK_YMD";
			MyOraDB.Parameter_Name[3] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[4] = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[5] = "ARG_COLOR_CD"; 
			MyOraDB.Parameter_Name[6] = "OUT_CURSOR"; 

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_whcd;
			MyOraDB.Parameter_Values[2] = arg_stockymd;
			MyOraDB.Parameter_Values[3] = arg_itemcd;
			MyOraDB.Parameter_Values[4] = arg_speccd;
			MyOraDB.Parameter_Values[5] = arg_colorcd; 
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			ds_ret = MyOraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null; 

			return ds_ret.Tables[MyOraDB.Process_Name];

		}


		#endregion																								 

    
		

		


	}
}

