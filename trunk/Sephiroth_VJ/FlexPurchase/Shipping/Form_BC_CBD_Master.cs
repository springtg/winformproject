using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;
using FlexPurchase.Incoming;

namespace FlexPurchase.Shipping
{
	public class Form_BC_CBD_Master : COM.PCHWinForm.Form_Top
	{
		#region 디자이너에서 생성한 변수
		
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.ContextMenu ctx_tail;
		private System.Windows.Forms.MenuItem mnu_AllSelect;
		private System.Windows.Forms.MenuItem mnu_Data;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnu_useDivide;
		private System.Windows.Forms.MenuItem mnu_mrp;
		private System.Windows.Forms.MenuItem mnu_local;
		private System.Windows.Forms.MenuItem mnu_notUse;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private Hashtable _cellTypes = null;
		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		private const int _mnuUseDevide = 10, _contextMenu = 20, _valueTransport = 30;
		private const string _divide_mrp = "M", _divide_local = "L", _divide_notUsing = "N";
		private int _factoryCol     = (int)ClassLib.TBSBC_CBD_MASTER.IxFACTORY;
		private int _styleCdCol		= (int)ClassLib.TBSBC_CBD_MASTER.IxSTYLE_CD;
		private int _itemCdCol      = (int)ClassLib.TBSBC_CBD_MASTER.IxITEM_CD;
		private int _itemNameCol     = (int)ClassLib.TBSBC_CBD_MASTER.IxITEM_NAME;
		private int _colorCdCol		= (int)ClassLib.TBSBC_CBD_MASTER.IxCOLOR_CD;
		private int _purUserCol		= (int)ClassLib.TBSBC_CBD_MASTER.IxPUR_USER;
		private int _unitCol	    = (int)ClassLib.TBSBC_CBD_MASTER.IxPK_UNIT_QTY;
		private int _purCurrencyCol	= (int)ClassLib.TBSBC_CBD_MASTER.IxPUR_CURRENCY;
		private int _purPriceCol	= (int)ClassLib.TBSBC_CBD_MASTER.IxPUR_PRICE;
		private int _custCdCol		= (int)ClassLib.TBSBC_CBD_MASTER.IxCUST_CD;
		private int _specCdCol		= (int)ClassLib.TBSBC_CBD_MASTER.IxSPEC_CD;
		private System.Windows.Forms.Panel pnl_main;
		private System.Windows.Forms.Panel pnl_BB;
		private System.Windows.Forms.Label btn_Insert;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label btn_Delete;
		private System.Windows.Forms.TextBox txt_itemName;
		private System.Windows.Forms.TextBox txt_itemCode;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_styleCode;
		private C1.Win.C1List.C1Combo cmb_style;
		private System.Windows.Forms.Label lbl_style;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Panel pal_head;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.Windows.Forms.Label btn_Tree;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1List.C1Combo cmb_purUser;
		private C1.Win.C1List.C1Combo cmb_OBSId;
		private System.Windows.Forms.Label btn_createCBD;
		private System.Windows.Forms.CheckBox chk_DPO;
		private System.Windows.Forms.TextBox txt_vendorCode;
		private C1.Win.C1List.C1Combo cmb_vendor;
		private System.Windows.Forms.Label lbl_vendor;
		
		private string _itemGroupCode	= "";
		
		#endregion

		#region 생성자 / 소멸자

		public Form_BC_CBD_Master()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BC_CBD_Master));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_BB = new System.Windows.Forms.Panel();
            this.btn_Tree = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Label();
            this.btn_recover = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Label();
            this.btn_createCBD = new System.Windows.Forms.Label();
            this.pal_head = new System.Windows.Forms.Panel();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.chk_DPO = new System.Windows.Forms.CheckBox();
            this.cmb_OBSId = new C1.Win.C1List.C1Combo();
            this.cmb_purUser = new C1.Win.C1List.C1Combo();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.txt_itemGroup = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_styleCode = new System.Windows.Forms.TextBox();
            this.cmb_style = new C1.Win.C1List.C1Combo();
            this.lbl_style = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctx_tail = new System.Windows.Forms.ContextMenu();
            this.mnu_AllSelect = new System.Windows.Forms.MenuItem();
            this.mnu_Data = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnu_useDivide = new System.Windows.Forms.MenuItem();
            this.mnu_mrp = new System.Windows.Forms.MenuItem();
            this.mnu_local = new System.Windows.Forms.MenuItem();
            this.mnu_notUse = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
            this.pnl_main.SuspendLayout();
            this.pnl_BB.SuspendLayout();
            this.pal_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OBSId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
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
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(664, 23);
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
            this.c1Sizer1.BackColor = System.Drawing.SystemColors.Window;
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.Controls.Add(this.pnl_main);
            this.c1Sizer1.Controls.Add(this.pal_head);
            this.c1Sizer1.GridDefinition = "17.8819444444444:False:True;73.7847222222222:False:False;6.94444444444444:False:T" +
                "rue;\t0.393700787401575:False:True;98.4251968503937:False:False;0.393700787401575" +
                ":False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // spd_main
            // 
            this.spd_main.Location = new System.Drawing.Point(8, 107);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(1000, 425);
            this.spd_main.TabIndex = 412;
            this.spd_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spd_main_MouseUp);
            this.spd_main.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spd_main_KeyDown);
            this.spd_main.EditModeOn += new System.EventHandler(this.spd_main_EditModeOn);
            this.spd_main.EditModeOff += new System.EventHandler(this.spd_main_EditModeOff);
            this.spd_main.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_EditChange);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.White;
            this.pnl_main.Controls.Add(this.pnl_BB);
            this.pnl_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.pnl_main.Location = new System.Drawing.Point(8, 536);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1008, 40);
            this.pnl_main.TabIndex = 1;
            // 
            // pnl_BB
            // 
            this.pnl_BB.Controls.Add(this.btn_Tree);
            this.pnl_BB.Controls.Add(this.btn_Insert);
            this.pnl_BB.Controls.Add(this.btn_recover);
            this.pnl_BB.Controls.Add(this.btn_Delete);
            this.pnl_BB.Controls.Add(this.btn_createCBD);
            this.pnl_BB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_BB.Location = new System.Drawing.Point(0, 8);
            this.pnl_BB.Name = "pnl_BB";
            this.pnl_BB.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnl_BB.Size = new System.Drawing.Size(1008, 32);
            this.pnl_BB.TabIndex = 46;
            // 
            // btn_Tree
            // 
            this.btn_Tree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Tree.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tree.ImageIndex = 13;
            this.btn_Tree.ImageList = this.image_List;
            this.btn_Tree.Location = new System.Drawing.Point(685, 4);
            this.btn_Tree.Name = "btn_Tree";
            this.btn_Tree.Size = new System.Drawing.Size(80, 24);
            this.btn_Tree.TabIndex = 536;
            this.btn_Tree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Tree.Click += new System.EventHandler(this.btn_Tree_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Insert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.ImageIndex = 9;
            this.btn_Insert.ImageList = this.image_List;
            this.btn_Insert.Location = new System.Drawing.Point(766, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 23);
            this.btn_Insert.TabIndex = 535;
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_recover
            // 
            this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_recover.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recover.ImageIndex = 1;
            this.btn_recover.ImageList = this.image_List;
            this.btn_recover.Location = new System.Drawing.Point(928, 4);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(80, 23);
            this.btn_recover.TabIndex = 534;
            this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Delete.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ImageIndex = 5;
            this.btn_Delete.ImageList = this.image_List;
            this.btn_Delete.Location = new System.Drawing.Point(847, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(80, 23);
            this.btn_Delete.TabIndex = 533;
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_createCBD
            // 
            this.btn_createCBD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_createCBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_createCBD.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createCBD.ImageIndex = 0;
            this.btn_createCBD.ImageList = this.img_Button;
            this.btn_createCBD.Location = new System.Drawing.Point(604, 4);
            this.btn_createCBD.Name = "btn_createCBD";
            this.btn_createCBD.Size = new System.Drawing.Size(80, 24);
            this.btn_createCBD.TabIndex = 536;
            this.btn_createCBD.Text = "CBD Create";
            this.btn_createCBD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_createCBD.Click += new System.EventHandler(this.btn_createCBD_Click);
            this.btn_createCBD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_createCBD_MouseDown);
            this.btn_createCBD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_createCBD_MouseUp);
            // 
            // pal_head
            // 
            this.pal_head.BackColor = System.Drawing.SystemColors.Window;
            this.pal_head.Controls.Add(this.txt_vendorCode);
            this.pal_head.Controls.Add(this.cmb_vendor);
            this.pal_head.Controls.Add(this.lbl_vendor);
            this.pal_head.Controls.Add(this.chk_DPO);
            this.pal_head.Controls.Add(this.cmb_OBSId);
            this.pal_head.Controls.Add(this.cmb_purUser);
            this.pal_head.Controls.Add(this.label1);
            this.pal_head.Controls.Add(this.txt_itemName);
            this.pal_head.Controls.Add(this.txt_itemCode);
            this.pal_head.Controls.Add(this.lbl_item);
            this.pal_head.Controls.Add(this.txt_itemGroup);
            this.pal_head.Controls.Add(this.cmb_itemGroup);
            this.pal_head.Controls.Add(this.btn_groupSearch);
            this.pal_head.Controls.Add(this.label3);
            this.pal_head.Controls.Add(this.txt_styleCode);
            this.pal_head.Controls.Add(this.cmb_style);
            this.pal_head.Controls.Add(this.lbl_style);
            this.pal_head.Controls.Add(this.cmb_factory);
            this.pal_head.Controls.Add(this.lbl_factory);
            this.pal_head.Controls.Add(this.pictureBox1);
            this.pal_head.Controls.Add(this.pictureBox2);
            this.pal_head.Controls.Add(this.pictureBox3);
            this.pal_head.Controls.Add(this.pictureBox4);
            this.pal_head.Controls.Add(this.label9);
            this.pal_head.Controls.Add(this.pictureBox5);
            this.pal_head.Controls.Add(this.pictureBox6);
            this.pal_head.Controls.Add(this.pictureBox7);
            this.pal_head.Controls.Add(this.label2);
            this.pal_head.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pal_head.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.pal_head.Location = new System.Drawing.Point(8, 0);
            this.pal_head.Name = "pal_head";
            this.pal_head.Size = new System.Drawing.Size(1000, 103);
            this.pal_head.TabIndex = 411;
            // 
            // txt_vendorCode
            // 
            this.txt_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendorCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_vendorCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_vendorCode.Location = new System.Drawing.Point(112, 78);
            this.txt_vendorCode.MaxLength = 10;
            this.txt_vendorCode.Name = "txt_vendorCode";
            this.txt_vendorCode.Size = new System.Drawing.Size(72, 21);
            this.txt_vendorCode.TabIndex = 424;
            this.txt_vendorCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_vendorCode_KeyUp);
            // 
            // cmb_vendor
            // 
            this.cmb_vendor.AddItemCols = 0;
            this.cmb_vendor.AddItemSeparator = ';';
            this.cmb_vendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_vendor.Caption = "";
            this.cmb_vendor.CaptionHeight = 17;
            this.cmb_vendor.CaptionStyle = style1;
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
            this.cmb_vendor.EvenRowStyle = style2;
            this.cmb_vendor.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.FooterStyle = style3;
            this.cmb_vendor.GapHeight = 2;
            this.cmb_vendor.HeadingStyle = style4;
            this.cmb_vendor.HighLightRowStyle = style5;
            this.cmb_vendor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_vendor.ItemHeight = 15;
            this.cmb_vendor.Location = new System.Drawing.Point(185, 78);
            this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_vendor.MaxDropDownItems = ((short)(5));
            this.cmb_vendor.MaxLength = 32767;
            this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.OddRowStyle = style6;
            this.cmb_vendor.PartialRightColumn = false;
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_vendor.SelectedStyle = style7;
            this.cmb_vendor.Size = new System.Drawing.Size(140, 20);
            this.cmb_vendor.Style = style8;
            this.cmb_vendor.TabIndex = 425;
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 0;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(16, 78);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 426;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chk_DPO
            // 
            this.chk_DPO.Location = new System.Drawing.Point(976, 36);
            this.chk_DPO.Name = "chk_DPO";
            this.chk_DPO.Size = new System.Drawing.Size(16, 16);
            this.chk_DPO.TabIndex = 423;
            this.chk_DPO.Text = "checkBox1";
            this.chk_DPO.CheckedChanged += new System.EventHandler(this.chk_DPO_CheckedChanged);
            // 
            // cmb_OBSId
            // 
            this.cmb_OBSId.AddItemCols = 0;
            this.cmb_OBSId.AddItemSeparator = ';';
            this.cmb_OBSId.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_OBSId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OBSId.Caption = "";
            this.cmb_OBSId.CaptionHeight = 17;
            this.cmb_OBSId.CaptionStyle = style9;
            this.cmb_OBSId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OBSId.ColumnCaptionHeight = 18;
            this.cmb_OBSId.ColumnFooterHeight = 18;
            this.cmb_OBSId.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OBSId.ContentHeight = 16;
            this.cmb_OBSId.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OBSId.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OBSId.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_OBSId.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OBSId.EditorHeight = 16;
            this.cmb_OBSId.EvenRowStyle = style10;
            this.cmb_OBSId.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_OBSId.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OBSId.FooterStyle = style11;
            this.cmb_OBSId.GapHeight = 2;
            this.cmb_OBSId.HeadingStyle = style12;
            this.cmb_OBSId.HighLightRowStyle = style13;
            this.cmb_OBSId.ItemHeight = 15;
            this.cmb_OBSId.Location = new System.Drawing.Point(774, 34);
            this.cmb_OBSId.MatchEntryTimeout = ((long)(2000));
            this.cmb_OBSId.MaxDropDownItems = ((short)(5));
            this.cmb_OBSId.MaxLength = 32767;
            this.cmb_OBSId.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OBSId.Name = "cmb_OBSId";
            this.cmb_OBSId.OddRowStyle = style14;
            this.cmb_OBSId.PartialRightColumn = false;
            this.cmb_OBSId.PropBag = resources.GetString("cmb_OBSId.PropBag");
            this.cmb_OBSId.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OBSId.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OBSId.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OBSId.SelectedStyle = style15;
            this.cmb_OBSId.Size = new System.Drawing.Size(194, 20);
            this.cmb_OBSId.Style = style16;
            this.cmb_OBSId.TabIndex = 422;
            this.cmb_OBSId.SelectedValueChanged += new System.EventHandler(this.cmb_OBSId_SelectedValueChanged);
            // 
            // cmb_purUser
            // 
            this.cmb_purUser.AddItemCols = 0;
            this.cmb_purUser.AddItemSeparator = ';';
            this.cmb_purUser.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_purUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_purUser.Caption = "";
            this.cmb_purUser.CaptionHeight = 17;
            this.cmb_purUser.CaptionStyle = style17;
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
            this.cmb_purUser.EvenRowStyle = style18;
            this.cmb_purUser.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_purUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_purUser.FooterStyle = style19;
            this.cmb_purUser.GapHeight = 2;
            this.cmb_purUser.HeadingStyle = style20;
            this.cmb_purUser.HighLightRowStyle = style21;
            this.cmb_purUser.ItemHeight = 15;
            this.cmb_purUser.Location = new System.Drawing.Point(774, 56);
            this.cmb_purUser.MatchEntryTimeout = ((long)(2000));
            this.cmb_purUser.MaxDropDownItems = ((short)(5));
            this.cmb_purUser.MaxLength = 32767;
            this.cmb_purUser.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_purUser.Name = "cmb_purUser";
            this.cmb_purUser.OddRowStyle = style22;
            this.cmb_purUser.PartialRightColumn = false;
            this.cmb_purUser.PropBag = resources.GetString("cmb_purUser.PropBag");
            this.cmb_purUser.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_purUser.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_purUser.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_purUser.SelectedStyle = style23;
            this.cmb_purUser.Size = new System.Drawing.Size(220, 20);
            this.cmb_purUser.Style = style24;
            this.cmb_purUser.TabIndex = 422;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(672, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 415;
            this.label1.Text = "User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_itemName
            // 
            this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_itemName.Location = new System.Drawing.Point(505, 56);
            this.txt_itemName.MaxLength = 10;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(149, 21);
            this.txt_itemName.TabIndex = 421;
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_itemCode.Location = new System.Drawing.Point(445, 56);
            this.txt_itemCode.MaxLength = 10;
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(59, 21);
            this.txt_itemCode.TabIndex = 413;
            this.txt_itemCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(344, 56);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 415;
            this.lbl_item.Text = "Item";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_itemGroup.Location = new System.Drawing.Point(228, 56);
            this.txt_itemGroup.MaxLength = 10;
            this.txt_itemGroup.Name = "txt_itemGroup";
            this.txt_itemGroup.ReadOnly = true;
            this.txt_itemGroup.Size = new System.Drawing.Size(73, 21);
            this.txt_itemGroup.TabIndex = 420;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemCols = 0;
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style25;
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
            this.cmb_itemGroup.EvenRowStyle = style26;
            this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style27;
            this.cmb_itemGroup.GapHeight = 2;
            this.cmb_itemGroup.HeadingStyle = style28;
            this.cmb_itemGroup.HighLightRowStyle = style29;
            this.cmb_itemGroup.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(112, 56);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style30;
            this.cmb_itemGroup.PartialRightColumn = false;
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style31;
            this.cmb_itemGroup.Size = new System.Drawing.Size(115, 20);
            this.cmb_itemGroup.Style = style32;
            this.cmb_itemGroup.TabIndex = 419;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Enabled = false;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(301, 56);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 418;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageIndex = 0;
            this.label3.ImageList = this.img_Label;
            this.label3.Location = new System.Drawing.Point(16, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 417;
            this.label3.Text = "Item Group";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_styleCode
            // 
            this.txt_styleCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_styleCode.Location = new System.Drawing.Point(445, 34);
            this.txt_styleCode.MaxLength = 10;
            this.txt_styleCode.Name = "txt_styleCode";
            this.txt_styleCode.Size = new System.Drawing.Size(79, 21);
            this.txt_styleCode.TabIndex = 412;
            this.txt_styleCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_styleCode_KeyUp);
            // 
            // cmb_style
            // 
            this.cmb_style.AddItemCols = 0;
            this.cmb_style.AddItemSeparator = ';';
            this.cmb_style.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_style.Caption = "";
            this.cmb_style.CaptionHeight = 17;
            this.cmb_style.CaptionStyle = style33;
            this.cmb_style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_style.ColumnCaptionHeight = 18;
            this.cmb_style.ColumnFooterHeight = 18;
            this.cmb_style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_style.ContentHeight = 16;
            this.cmb_style.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_style.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_style.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_style.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_style.EditorHeight = 16;
            this.cmb_style.EvenRowStyle = style34;
            this.cmb_style.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style.FooterStyle = style35;
            this.cmb_style.GapHeight = 2;
            this.cmb_style.HeadingStyle = style36;
            this.cmb_style.HighLightRowStyle = style37;
            this.cmb_style.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_style.ItemHeight = 15;
            this.cmb_style.Location = new System.Drawing.Point(525, 34);
            this.cmb_style.MatchEntryTimeout = ((long)(2000));
            this.cmb_style.MaxDropDownItems = ((short)(5));
            this.cmb_style.MaxLength = 32767;
            this.cmb_style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_style.Name = "cmb_style";
            this.cmb_style.OddRowStyle = style38;
            this.cmb_style.PartialRightColumn = false;
            this.cmb_style.PropBag = resources.GetString("cmb_style.PropBag");
            this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_style.SelectedStyle = style39;
            this.cmb_style.Size = new System.Drawing.Size(130, 20);
            this.cmb_style.Style = style40;
            this.cmb_style.TabIndex = 414;
            this.cmb_style.SelectedValueChanged += new System.EventHandler(this.cmb_style_SelectedValueChanged);
            // 
            // lbl_style
            // 
            this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_style.ImageIndex = 0;
            this.lbl_style.ImageList = this.img_Label;
            this.lbl_style.Location = new System.Drawing.Point(344, 34);
            this.lbl_style.Name = "lbl_style";
            this.lbl_style.Size = new System.Drawing.Size(100, 21);
            this.lbl_style.TabIndex = 416;
            this.lbl_style.Text = "Style";
            this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style41;
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
            this.cmb_factory.EvenRowStyle = style42;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style43;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style44;
            this.cmb_factory.HighLightRowStyle = style45;
            this.cmb_factory.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(112, 34);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style46;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style47;
            this.cmb_factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_factory.Style = style48;
            this.cmb_factory.TabIndex = 410;
            this.cmb_factory.TextChanged += new System.EventHandler(this.cmb_factory_TextChanged);
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(16, 34);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 411;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(984, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(136, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(960, 18);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(899, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 67);
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(984, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 32);
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 30);
            this.label9.TabIndex = 42;
            this.label9.Text = "      CBD Master";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(208, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(960, 32);
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 92);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(168, 20);
            this.pictureBox6.TabIndex = 43;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 16);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(168, 81);
            this.pictureBox7.TabIndex = 41;
            this.pictureBox7.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageIndex = 0;
            this.label2.ImageList = this.img_Label;
            this.label2.Location = new System.Drawing.Point(672, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 416;
            this.label2.Text = "DPO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctx_tail
            // 
            this.ctx_tail.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_AllSelect,
            this.mnu_Data,
            this.menuItem1,
            this.mnu_useDivide});
            // 
            // mnu_AllSelect
            // 
            this.mnu_AllSelect.Index = 0;
            this.mnu_AllSelect.Text = "All Select";
            this.mnu_AllSelect.Click += new System.EventHandler(this.mnu_AllSelect_Click);
            // 
            // mnu_Data
            // 
            this.mnu_Data.Index = 1;
            this.mnu_Data.Text = "Value Change";
            this.mnu_Data.Click += new System.EventHandler(this.mnu_Data_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "-";
            // 
            // mnu_useDivide
            // 
            this.mnu_useDivide.Index = 3;
            this.mnu_useDivide.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_mrp,
            this.mnu_local,
            this.mnu_notUse});
            this.mnu_useDivide.Text = "Use Divide";
            // 
            // mnu_mrp
            // 
            this.mnu_mrp.Index = 0;
            this.mnu_mrp.Text = "MRP";
            this.mnu_mrp.Click += new System.EventHandler(this.mnu_mrp_Click);
            // 
            // mnu_local
            // 
            this.mnu_local.Index = 1;
            this.mnu_local.Text = "Local";
            this.mnu_local.Click += new System.EventHandler(this.mnu_local_Click);
            // 
            // mnu_notUse
            // 
            this.mnu_notUse.Index = 2;
            this.mnu_notUse.Text = "Not Using";
            this.mnu_notUse.Click += new System.EventHandler(this.mnu_notUse_Click);
            // 
            // Form_BC_CBD_Master
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BC_CBD_Master";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_SBC_CBD_MASTER_Closing);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.pnl_main.ResumeLayout(false);
            this.pnl_BB.ResumeLayout(false);
            this.pal_head.ResumeLayout(false);
            this.pal_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OBSId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{						
			Grid_EditModeOnProcess(spd_main) ;
		}		
		
		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{			
			spd_main.Update_Row(img_Action);
		}

//		private void spd_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
//		{
//			if (Etc_ProvisoValidateCheck(_contextMenu))
//			{
//				if (!e.ColumnHeader && e.Button == MouseButtons.Right)
//				{
//					if (_mainSheet.Columns[e.Column].Locked)
//						mnu_Data.Enabled = false;
//					else
//						mnu_Data.Enabled = true;
//
//					ctx_tail.Show(spd_main, new Point(e.X, e.Y));
//				}
//			}
//		}

		private void spd_main_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (_mainSheet.ActiveColumn.Index == _purUserCol)
			{
				if (_mainSheet.Cells[_mainSheet.ActiveRow.Index, _styleCdCol].Text.Equals("_________") || 
					_mainSheet.Cells[_mainSheet.ActiveRow.Index, _styleCdCol].Text.Equals("None") || 
					_mainSheet.Cells[_mainSheet.ActiveRow.Index, _styleCdCol].Text.Equals(""))
					_mainSheet.ActiveCell.Locked = false;
			}
		}

		private void spd_main_EditModeOff(object sender, System.EventArgs e)
		{
			if (_mainSheet.ActiveColumn.Index == _purUserCol)
			{
				_mainSheet.ActiveCell.Locked = true;
			}
		}

		#endregion
		
		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();		
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Search))
				this.Tbtn_SearchProcess(true);
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Save))
			{
				if (MessageBox.Show(this, "Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					this.Tbtn_SaveProcess();
				}
			}
		}		
		
		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess();
		}

		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
//			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Confirm))
//			{
//				if(ClassLib.ComFunction.User_Message("Do you want to save?","Save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )
//					this.Tbtn_ConfirmProcess();
//			}
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

		private void Form_SBC_CBD_MASTER_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(_mainSheet.Rows.Count > 0)
			{
				for (int i = 0  ; i < _mainSheet.Rows.Count ; i++)
					if (_mainSheet.Cells[i, 0].Tag  != null)
					{
						if(MessageBox.Show(this, "Exist Modify Data, Do you want to close?","Close", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.No )
							e.Cancel = true;
						break;
					}
			}
		}

		private void cmb_itemGroup_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if ( cmb_itemGroup.SelectedIndex >= 1 )
			{
				txt_itemGroup.Text = "";
				_itemGroupCode = "";
				this.btn_groupSearch.Enabled = true;
			}
			else
			{
				txt_itemGroup.Text = "";
				_itemGroupCode = "";
				this.btn_groupSearch.Enabled = false;
			}
		}

		private void btn_groupSearch_Click(object sender, System.EventArgs e)
		{
			string vTyep = this.cmb_itemGroup.SelectedValue.ToString();
			FlexBase.MaterialBase.Pop_GroupSearchAll vPopup = new FlexBase.MaterialBase.Pop_GroupSearchAll(vTyep);

			vPopup.ShowDialog();
			
			_itemGroupCode			= COM.ComVar.Parameter_PopUp[3];
			this.txt_itemGroup.Text	= COM.ComVar.Parameter_PopUp[3];

			vPopup.Dispose();		
		}

		private void txt_styleCode_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				this.Txt_StyleCdKeyUpProcess();
		}

		private void cmb_style_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				txt_styleCode.Text = cmb_style.SelectedValue.ToString().Trim();
			}
			catch {}
		}
		
		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			// 공통 체크
			if (cmb_factory.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Factory", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_factory.Focus();
				return false;
			}
			
			return true;
			
		}
		

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			obs_Loading();
		}

		private void obs_Loading()
		{
			try
			{
				if(cmb_factory.SelectedIndex == -1) return;

				DataTable dt_ret; 
				
				// dpo set
				// division = 1 : dp, division = 2 : dpo
				dt_ret = ClassLib.ComVar.Select_DP_DPO_List(cmb_factory.SelectedValue.ToString(), "2");
				COM.ComCtl.Set_ComboList(dt_ret, cmb_OBSId, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 

				dt_ret.Dispose(); 

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		

		private void year_Loading()
		{
			try
			{
				if(cmb_factory.SelectedIndex == -1) return;

				DataTable dt_ret; 
				
				dt_ret = SELECT_SBC_YEAR(cmb_factory.SelectedValue.ToString());
				COM.ComCtl.Set_ComboList(dt_ret, cmb_OBSId, 0, 0, true, ClassLib.ComVar.ComboList_Visible.Name); 

				dt_ret.Dispose(); 

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		


		private void btn_createCBD_Click(object sender, System.EventArgs e)
		{
			ClassLib.ComVar.Parameter_PopUp = new string[] {
															   COM.ComFunction.Empty_Combo(cmb_factory, COM.ComVar.This_Factory), 
															   COM.ComFunction.Empty_Combo(cmb_OBSId, ""),
															   COM.ComFunction.Empty_TextBox(txt_styleCode, ""), 
			};

			Pop_BC_CBD_Master_Create pop = new Pop_BC_CBD_Master_Create();

			pop.ShowDialog();
		}


		#region 컨텍스트 메뉴

		private void mnu_AllSelect_Click(object sender, System.EventArgs e)
		{
			Mnu_AllSelectClickProcess();
		}

		private void mnu_Data_Click(object sender, System.EventArgs e)
		{
			this.Grid_CellClickProcess();
		}

		private void Mnu_AllSelectClickProcess()
		{
			_mainSheet.AddSelection(0, 1, _mainSheet.RowCount, _mainSheet.ColumnCount);
		}

		private void mnu_mrp_Click(object sender, System.EventArgs e)
		{
			Mnu_UseDevideProcess(_divide_mrp);
		}

		private void mnu_local_Click(object sender, System.EventArgs e)
		{
			Mnu_UseDevideProcess(_divide_local);
		}

		private void mnu_notUse_Click(object sender, System.EventArgs e)
		{
			Mnu_UseDevideProcess(_divide_notUsing);
		}

		#endregion

		#region 입력이동

		#endregion

		#region 버튼효과

		private void btn_insert_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 8;
		}

		private void btn_insert_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 9;
		}

		private void btn_delete_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 4;
		}

		private void btn_delete_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 5;
		}

		private void btn_cancel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		private void btn_cancel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_tree_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 12;
		}

		private void btn_tree_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 13;
		}

		private void btn_createCBD_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_createCBD_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		#endregion

		#endregion

		#region 공통 메서드

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form initialize
			ClassLib.ComFunction.Init_Form_Control(this);

            lbl_MainTitle.Text = "CBD Master";
            this.Text = "CBD Master";
            ClassLib.ComFunction.SetLangDic(this);

			// grid set
			spd_main.Set_Spread_Comm("SBC_CBD_MASTER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			
			//발주자 Setting
			Set_ManCharge_ComboList();
			

			//입력부 setup
			Init_Combo();
			
			// user define variable set
			_mainSheet				= spd_main.ActiveSheet;

			_cellTypes = new Hashtable();

			for (int vCount = 1 ; vCount < _mainSheet.Columns.Count ; vCount++)
				if (_mainSheet.Columns[vCount].CellType.ToString().Equals(ClassLib.ComVar.SSPComboBoxCell))
				{
					COM.SSPComboBoxCellType sspBox = (COM.SSPComboBoxCellType)_mainSheet.Columns[vCount].CellType; 
					_cellTypes.Add(vCount, sspBox.DataSourceWithCode);
				}

			for (int vCol = 0 ; vCol < _mainSheet.ColumnCount ; vCol++)
			{
				if (_mainSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim().Equals(_mainSheet.ColumnHeader.Cells[2, vCol].Text.ToString().Trim()))
				{
					_mainSheet.ColumnHeader.Cells[1, vCol].RowSpan = 2;
				}
				else
				{
					int vCnt  = 0;
					for ( int j = vCol ; j < _mainSheet.ColumnCount ; j++)
					{
						if( vCnt > 0 &&  _mainSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() != _mainSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )
						{
							_mainSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
							break;
						}
						else if ( _mainSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() == _mainSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )	
							vCnt++;
					}
					vCol = vCol + vCnt-1;
				}
			}
		}

		private void Init_Combo()
		{
			try
			{
				DataTable vDt;

				// factory set
				vDt = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, 40, 125);
				cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
				vDt.Dispose();
				
				// Item Group Combobox Setting
				vDt = FlexPurchase.ClassLib.ComFunction.Select_GroupTypeCode();
				COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, true, 45, 60);
				cmb_itemGroup.SelectedIndex = 0;
				vDt.Dispose();

				
				// cmb_purUser
				vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory,"");
				ClassLib.ComCtl.Set_ComboList(vDt,cmb_purUser, 1, 1, true, 0, 210);
				cmb_purUser.SelectedValue = COM.ComVar.This_User;

				tbtn_Delete.Enabled = false;
				tbtn_Create.Enabled = false;
				tbtn_Confirm.Enabled = false;
				//tbtn_Print.Enabled = false;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
		}

		private void Tbtn_NewProcess()
		{
			try
			{
				txt_styleCode.Text = "";
				txt_itemCode.Text = "";
				txt_itemName.Text = "";
				cmb_OBSId.SelectedIndex = -1;
				cmb_purUser.SelectedIndex = -1;
				spd_main.ClearAll();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "New_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Tbtn_SearchProcess(bool arg_doSearch)
		{
			try
			{
				if (arg_doSearch)
				{
					this.Cursor = Cursors.WaitCursor;

					DataTable vDt = this.SELECT_SBC_CBD_MASTER();
						
					if (vDt.Rows.Count > 0)
					{
						spd_main.Display_Grid(vDt);
						Grid_SetColor();
					}
					else
					{
						spd_main.ClearAll();
					}

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
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

		private void Grid_SetColor()
		{
			for (int vRow = 0 ; vRow < _mainSheet.RowCount ; vRow++)
			{
				switch (_mainSheet.Cells[vRow, _purUserCol].Value.ToString())
				{
					case _divide_mrp:
						_mainSheet.Cells[vRow, 1, vRow, _mainSheet.ColumnCount - 1].BackColor = ClassLib.ComVar.RightBlue;
						break;
					case _divide_local:
						_mainSheet.Cells[vRow, 1, vRow, _mainSheet.ColumnCount - 1].BackColor = ClassLib.ComVar.RightPink2;
						break;
					case _divide_notUsing:
						_mainSheet.Cells[vRow, 1, vRow, _mainSheet.ColumnCount - 1].BackColor = ClassLib.ComVar.RightYellow;
						break;
				}
			}
		}


		private void Tbtn_SaveProcess()
		{

			try
			{
				 
				if(MyOraDB.Save_Spread("PKG_SBC_CBD_MASTER.SAVE_SBC_CBD_MASTER", spd_main))
				{
					this.Tbtn_SearchProcess(true);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
		}
		
		private void Tbtn_PrintProcess()
		{
			string[] vParam = new string[] {   COM.ComFunction.Param_Combo(cmb_factory, "%"), 
											   COM.ComFunction.Param_Combo(cmb_style, " ").Replace(" ", "").Replace("-", ""), 
											   COM.ComFunction.Param_Combo(cmb_itemGroup, " ").Replace(" ", ""), 
											   txt_itemCode.Text, 
											   txt_itemName.Text,
											   COM.ComFunction.Param_Combo(cmb_OBSId, " ").Replace(" ", ""),  
											   COM.ComFunction.Param_Combo(cmb_purUser, " ").Replace(" ", ""),
											   COM.ComFunction.Param_Combo(cmb_vendor, " ").Replace(" ", "")
			};

			Pop_BC_CBD_Master_Print print = new Pop_BC_CBD_Master_Print("SBP12", vParam);
            print.ShowDialog();

			/*
			C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
			System.Windows.Forms.TextBox[] txt_array = {}; 

			string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BC_CBD_Master");

			string sPara  = " /rp ";
			sPara += "'" + COM.ComFunction.Param_Combo(cmb_factory, "%") +	"' ";
			sPara += "'" + COM.ComFunction.Param_Combo(cmb_style, " ").Replace(" ", "").Replace("-", "") +	"' ";
			sPara += "'" + COM.ComFunction.Param_Combo(cmb_itemGroup, " ").Replace(" ", "") +	"' ";
			sPara += "'" + txt_itemCode.Text +	"' ";
			sPara += "'" + txt_itemName.Text +	"' ";
			
			FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "Incoming Item Inspection sheet";
			MyReport.Show();			
			*/
			
		}

		private int Mnu_UseDevideProcess(string arg_devide)
		{
			CellRange[] vRanges = _mainSheet.GetSelections();

			foreach (CellRange vRange in vRanges)
			{
				for (int vRow = vRange.Row ; vRow < vRange.Row + vRange.RowCount ; vRow++)
				{
					_mainSheet.Cells[vRow, _purUserCol].Text = arg_devide;
					spd_main.Update_Row(vRow, img_Action);
				}
			}

			return -1;
		}

		private void Txt_StyleCdKeyUpProcess()
		{
			DataTable vDt = null;

			try
			{
				vDt = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_styleCode, " "));

				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				//COM.ComCtl.Set_ComboList(vDt, cmb_style, 0, 1, true, 80, 130); 
				ClassLib.ComFunction.Set_ComboList_5(vDt, cmb_style, 0, 1, 2, 3, 4, false, 80, 140); 
					
				string vStyle = txt_styleCode.Text.Replace("-", "");
				vStyle = vStyle.Substring(0, 6) + "-" + vStyle.Substring(6, 3);
				cmb_style.SelectedValue = vStyle.Trim();

			}
			catch(Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "Txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (vDt != null) vDt.Dispose();
			}
		}


		private void Show_Item_Popup()
		{
			try
			{


				if(chk_DPO.Checked == false && cmb_OBSId.SelectedIndex == -1)
				{

					ClassLib.ComFunction.User_Message("Select DPO", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					cmb_OBSId.Focus();
					return;


				}

				
				
				

				FlexBase.MaterialBase.Pop_Item_List vPopup = new FlexBase.MaterialBase.Pop_Item_List();
				vPopup.ShowDialog(); 


				if (ClassLib.ComVar.Parameter_PopUp[0].Trim() != "")
				{	
					
					int row = spd_main.Add_Row(img_Action);
			
				    spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxFACTORY].Value =  cmb_factory.SelectedValue;
					
					if ( _styleCdCol == (int)ClassLib.TBSBC_CBD_MASTER.IxSTYLE_CD)
					{
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxSTYLE_CD].Value =  "NONE";
					}
					
					spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxITEM_CD].Value = ClassLib.ComVar.Parameter_PopUp[0];
					spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxITEM_NAME].Value = ClassLib.ComVar.Parameter_PopUp[1];  // item name
					spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxSPEC_CD].Value = ClassLib.ComVar.Parameter_PopUp[2];
					spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxSPEC_NAME].Value = ClassLib.ComVar.Parameter_PopUp[3];
					spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxCOLOR_CD].Value = ClassLib.ComVar.Parameter_PopUp[4];
					spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxCOLOR_NAME].Value = ClassLib.ComVar.Parameter_PopUp[5];
					//spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxPUR_USER].Value = "";

					spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxPUR_USER].Value = ClassLib.ComFunction.Empty_Combo(cmb_purUser, "");





					// DPO 할당
					if(chk_DPO.Checked)
					{

						if(cmb_OBSId.SelectedIndex == -1 || cmb_OBSId.SelectedValue.ToString().Trim() == "")
						{
							spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxOBS_ID].Value = System.DateTime.Now.ToString("yyyyMM");
						}
						else
						{
							spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxOBS_ID].Value = cmb_OBSId.SelectedValue;
						}


					}
					else
					{
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxOBS_ID].Value = cmb_OBSId.SelectedValue;
					}






				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		private void Show_Tree_Popup()
		{
			try
			{   
				ClassLib.ComVar.Parameter_PopUp = new string[]{COM.ComFunction.Empty_Combo(cmb_factory, COM.ComVar.This_Factory), "C"};
				int[] vChecks = new int[]{_styleCdCol, _itemCdCol, _specCdCol, _colorCdCol};
				Purchase.Pop_BC_Yield_Info vPop = new Purchase.Pop_BC_Yield_Info(spd_main, vChecks);
				
				vPop.ShowDialog();
				
				if (ClassLib.ComVar.Parameter_PopUpTable.Rows.Count > 0)
				{
				
					for(int vIdx = 0 ; vIdx < ClassLib.ComVar.Parameter_PopUpTable.Rows.Count ; vIdx++)
					{
						int row = spd_main.Add_Row(img_Action);
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxFACTORY].Value =  cmb_factory.SelectedValue;

						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxITEM_CD].Value = ClassLib.ComVar.Parameter_PopUpTable.Rows[vIdx][0];
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxITEM_NAME].Value = ClassLib.ComVar.Parameter_PopUpTable.Rows[vIdx][1];  // item name
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxSPEC_CD].Value = ClassLib.ComVar.Parameter_PopUpTable.Rows[vIdx][2];
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxSPEC_NAME].Value = ClassLib.ComVar.Parameter_PopUpTable.Rows[vIdx][3];
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxCOLOR_CD].Value = ClassLib.ComVar.Parameter_PopUpTable.Rows[vIdx][4];
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxCOLOR_NAME].Value = ClassLib.ComVar.Parameter_PopUpTable.Rows[vIdx][5];
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxSTYLE_CD].Value = ClassLib.ComVar.Parameter_PopUpTable.Rows[vIdx][8];
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxSTYLE_NAME].Value = ClassLib.ComVar.Parameter_PopUpTable.Rows[vIdx][9];
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CBD_MASTER.IxPUR_USER].Value = "";
					}
				}	
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		
		/// <summary>
		/// 여러 행 선택 후 데이터 일괄 수정
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void spd_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{	

				Set_Update_SelectionRow(e);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "spd_main_MouseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}
	
		/// <summary>
		/// 여러 행 선택 후 데이터 일괄 수정 
		/// </summary>
		/// <param name="e"></param>
		private void Set_Update_SelectionRow(System.Windows.Forms.MouseEventArgs e)
		{

			// 마우스 오른쪽 이벤트에만 팝업창 실행
			if(! e.Button.Equals(MouseButtons.Right) ) return;

			if(spd_main.ActiveSheet.Rows.Count == 0) return;

			int sel_row = spd_main.ActiveSheet.ActiveRowIndex;
			int sel_col = spd_main.ActiveSheet.ActiveColumnIndex;

			//if(spd_main.ActiveSheet.Columns[sel_col].Locked) return;

			if(sel_col == (int)ClassLib.TBSBC_CBD_MASTER.IxCUST_CD ||
				sel_col == (int)ClassLib.TBSBC_CBD_MASTER.IxCUST_NAME  )
			{

				COM.ComVar.Parameter_PopUp = new string[] { ClassLib.ComVar.Vendor }; 

				FlexPurchase.Shipping.Pop_BS_Shipping_List_Changer pop_form = new FlexPurchase.Shipping.Pop_BS_Shipping_List_Changer();
				pop_form.ShowDialog();
 
				if(COM.ComVar.Parameter_PopUp == null) return;

				// 0: name
				// 1: code

			}
			else 
			{
				FarPoint.Win.Spread.Cell cell = spd_main.ActiveSheet.Cells[sel_row, sel_col];
			
				// 헤더 Description
				string column_desc = spd_main.ActiveSheet.ColumnHeader.Cells[1, sel_col].Text;


				FlexBase.MaterialBase.Pop_SelectionChange_SSP pop_form = new FlexBase.MaterialBase.Pop_SelectionChange_SSP(cell, column_desc);
				pop_form.ShowDialog();

				if(! pop_form._Close_Save) return;  

			}
 		
			//--------------------------------------------------------------------------------------
			// set update list
			//--------------------------------------------------------------------------------------
			CellRange[] selection_range = spd_main.ActiveSheet.GetSelections(); 
			int start_row = 0; 
			int end_row = 0;

			for (int i = 0 ; i < selection_range.Length; i++)
			{

				start_row = selection_range[i].Row;
				end_row = selection_range[i].Row + selection_range[i].RowCount;


				if(sel_col == (int)ClassLib.TBSBC_CBD_MASTER.IxCUST_CD ||
					sel_col == (int)ClassLib.TBSBC_CBD_MASTER.IxCUST_NAME)
				{

					for (int j = start_row ; j < end_row; j++)
					{
						spd_main.ActiveSheet.Cells[j, sel_col].Text = COM.ComVar.Parameter_PopUp[0];  //name 
						spd_main.ActiveSheet.Cells[j, sel_col - 1].Text = COM.ComVar.Parameter_PopUp[1];  //code

						spd_main.Update_Row(j, img_Action);
					}

				}
				else
				{

					for (int j = start_row ; j < end_row; j++)
					{
						spd_main.ActiveSheet.Cells[j, sel_col].Text = COM.ComVar.Parameter_PopUp[0];
						spd_main.Update_Row(j, img_Action);
					}


				}


				
			}	
	  
			//--------------------------------------------------------------------------------------

		}


		private void txt_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		/// <summary>
		/// Select_Item : Item Master 조회
		/// </summary>
		private void Select_Item()
		{
			try
			{
				DataTable dt_ret;

				this.Cursor = Cursors.WaitCursor;

				string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_itemCode, " ");
				string group_cd = ClassLib.ComFunction.Empty_Combo(cmb_itemGroup, " ");// + ClassLib.ComFunction.Empty_Combo(cmb_itemGroup, " ");
				string item_name = ClassLib.ComFunction.Empty_TextBox(txt_itemName, " ");
	
				dt_ret = Select_SBC_ITEM_COMMON(item_cd, group_cd, item_name, "Y");

				spd_main.Display_Grid(dt_ret);
				
				dt_ret.Dispose();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Select_Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
		
		/// <summary>
		/// Set_ManCharge_ComboList : 그리드에 공장별 담당자 리스트 세팅
		/// </summary>
		private void Set_ManCharge_ComboList()
		{

			DataTable dt_ret = ClassLib.ComFunction.Select_Man_Charge(ClassLib.ComVar.This_Factory ); 

			DataTable rtn_dt = new DataTable();
			DataRow dr;


			rtn_dt.Columns.Add("CODE", typeof(string) );
			rtn_dt.Columns.Add("NAME", typeof(string) ); 

			dr = rtn_dt.NewRow();
			dr["CODE"] = "";
			dr["NAME"] = "";
			rtn_dt.Rows.Add(dr);

			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
				dr = rtn_dt.NewRow();
				dr["CODE"] = dt_ret.Rows[i].ItemArray[1].ToString();
    			dr["NAME"] = dt_ret.Rows[i].ItemArray[1].ToString();

				rtn_dt.Rows.Add(dr);

			}


			COM.SSPComboBoxCellType cell_combo = new COM.SSPComboBoxCellType(rtn_dt, "NAME", "CODE", false);  

			spd_main.ActiveSheet.Columns[(int)ClassLib.TBSBC_CBD_MASTER.IxPUR_USER].CellType = cell_combo;

			dt_ret.Dispose();

		}

		#region 이벤트_하단버튼 클릭시

		private void btn_Insert_Click(object sender, System.EventArgs e)
		{ 
			//Insert_Row();
			Show_Item_Popup();
		}

		private void btn_Delete_Click(object sender, System.EventArgs e)
		{
			spd_main.Delete_Row(img_Action);	
		}


		private void btn_recover_Click(object sender, System.EventArgs e)
		{
			spd_main.Recovery();
		}

		private void btn_Tree_Click(object sender, System.EventArgs e)
		{
			Show_Tree_Popup();
		}

		private void chk_DPO_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chk_DPO.Checked)  
			{
				year_Loading();
			}
			else
			{
				obs_Loading();
			}

		}

		#endregion 
		

		#endregion
		
		#region 그리드 이벤트

		private void Grid_CellClickProcess()//FarPoint.Win.Spread.CellClickEventArgs e)
		{
			try
			{ 
				int vRow = spd_main.Sheets[0].ActiveRowIndex ;
				int vCol = spd_main.Sheets[0].ActiveColumnIndex ;

				CellRange[] vSelectionRange = _mainSheet.GetSelections(); 

				if (vSelectionRange != null)
				{
					if (vCol == _purUserCol)
					{
						if (!Etc_ProvisoValidateCheck(_valueTransport))
							return;
					}

					COM.ComVar.Parameter_PopUp		= new string[2];
					COM.ComVar.Parameter_PopUp[0]	= _mainSheet.GetCellType(vRow, vCol).ToString();
					COM.ComVar.Parameter_PopUp[1]	= _mainSheet.ColumnHeader.Cells[1,vCol].Text;

					if (_cellTypes.ContainsKey(vCol))
					{
						COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComVar.SSPComboBoxCell;
						ClassLib.ComVar.Parameter_PopUp_Object = new object[]{_cellTypes[vCol]};
					}

					FlexPurchase.Purchase.Pop_BP_Purchase_List_Changer pop_changer = new FlexPurchase.Purchase.Pop_BP_Purchase_List_Changer();
					pop_changer.ShowDialog();

					if (COM.ComVar.Parameter_PopUp != null)
						for (int i = 0 ; i < vSelectionRange.Length; i++)
						{
							int start_row = vSelectionRange[i].Row;
							int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

							for (int j = start_row ; j < end_row; j++)
							{
								if ( _mainSheet.GetCellType(vRow, vCol).ToString() == "DateTimeCellType")
									_mainSheet.Cells[j, vCol].Value = DateTime.Parse(COM.ComVar.Parameter_PopUp[0]);
								else
									_mainSheet.Cells[j, vCol].Value = COM.ComVar.Parameter_PopUp[0];

								spd_main.Update_Row(j, img_Action);
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
		
		private void Grid_EditModeOnProcess(COM.SSP arg_grid)
		{
			int vRow = spd_main.Sheets[0].ActiveRowIndex ;
			int vCol = spd_main.Sheets[0].ActiveColumnIndex ;
			
			if (spd_main.Sheets[0].Cells[vRow, vCol].Value == null || spd_main.Sheets[0].Columns[vCol].CellType == null)
				return;
			
			spd_main.Buffer_CellData = spd_main.Sheets[0].Cells[vRow, vCol].Value.ToString();
			string vTemp = spd_main.Sheets[0].Columns[vCol].CellType.ToString() ;
			if (vTemp == "CheckBoxCellType" || vTemp == "SSPComboBoxCellType"  )
			{
				spd_main.Buffer_CellData = "000" ;
				spd_main.Update_Row(img_Action) ;
			}
		}

		#endregion

		#region DB Connect

		public DataTable SELECT_SBC_CBD_MASTER()
		{
 
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet ds_ret;
 
			MyOraDB.ReDim_Parameter(9); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_CBD_MASTER.SELECT_SBC_CBD_MASTER";
			
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_GROUP_CD";
			MyOraDB.Parameter_Name[3] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[4] = "ARG_ITEM_NAME";
			MyOraDB.Parameter_Name[5] = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[6] = "ARG_PUR_USER";
			MyOraDB.Parameter_Name[7] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[8] = "OUT_CURSOR";
			
			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, " ");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_TextBox(txt_styleCode, " ").Replace("-", "");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_TextBox(txt_itemGroup, " ");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_TextBox(txt_itemCode, " ");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_TextBox(txt_itemName, " ");
			MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_Combo(cmb_OBSId, " ");
			MyOraDB.Parameter_Values[6] = COM.ComFunction.Empty_Combo(cmb_purUser, " ");
			MyOraDB.Parameter_Values[7] = COM.ComFunction.Empty_Combo(cmb_vendor, " ");
			MyOraDB.Parameter_Values[8] = " "; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}
		
		/// <summary>
		/// Select_SBC_ITEM_COMMON : Item LIST Combo
		/// </summary>
		/// <param name="arg_itemcd"></param>
		/// <param name="arg_groupcd"></param>
		/// <param name="arg_itemname1"></param>
		/// <param name="arg_useyn"></param>
		/// <returns></returns>
		public static DataTable Select_SBC_ITEM_COMMON(string arg_itemcd, string arg_groupcd, string arg_itemname1, string arg_useyn)
		{

			COM.OraDB OraDB = new COM.OraDB();

			DataSet ds_ret;
 
			OraDB.ReDim_Parameter(5); 

			OraDB.Process_Name = "PKG_SBC_ITEM.SELECT_SBC_ITEM_COMMON";

			OraDB.Parameter_Name[0] = "ARG_ITEM_CD";
			OraDB.Parameter_Name[1] = "ARG_GROUP_CD";
			OraDB.Parameter_Name[2] = "ARG_ITEM_NAME1";
			OraDB.Parameter_Name[3] = "ARG_USE_YN";
			OraDB.Parameter_Name[4] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = arg_itemcd; 
			OraDB.Parameter_Values[1] = arg_groupcd; 
			OraDB.Parameter_Values[2] = arg_itemname1; 
			OraDB.Parameter_Values[3] = arg_useyn; 
			OraDB.Parameter_Values[4] = ""; 


			OraDB.Add_Select_Parameter(true);

			ds_ret = OraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[OraDB.Process_Name];
		}


		/// <summary>
		/// SELECT_SBC_YEAR
		/// </summary>
		/// <returns></returns>
		public static DataTable SELECT_SBC_YEAR(string _factory)
		{

			COM.OraDB OraDB = new COM.OraDB();

			DataSet ds_ret;
 
			OraDB.ReDim_Parameter(2); 

			OraDB.Process_Name = "PKG_SBC_CBD_MASTER.SELECT_SBC_CBD_YEAR";

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = _factory;
			OraDB.Parameter_Values[1] = ""; 


			OraDB.Add_Select_Parameter(true);

			ds_ret = OraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[OraDB.Process_Name];
		}

		 
		#endregion

		private void txt_itemName_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void cmb_factory_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void txt_vendorCode_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.Txt_VendorCodeKeyUpProcess();
				ClassLib.ComFunction.Control_MoveNextByFocus(sender, e.KeyValue);
			}
		}

		private void Txt_VendorCodeKeyUpProcess()
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




		// 입고 마감 단가 등록 시, 지난 달은 수정 불가하도록 처리
		private void cmb_OBSId_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
			
				Event_cmb_OBSId_SelectedValueChanged();

			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}

		}



		// 입고 마감 단가 등록 시, 지난 달은 수정 불가하도록 처리
		private void Event_cmb_OBSId_SelectedValueChanged()
		{


			//입고 마감이 아니거나, ALL 선택으로 간주되어 자동 현재 month 로 세팅됨
			if(chk_DPO.Checked == false || cmb_OBSId.SelectedIndex == -1 || cmb_OBSId.SelectedValue.ToString().Trim() == "")
			{

				tbtn_Save.Enabled = true;

				btn_createCBD.Enabled = true;
				btn_Tree.Enabled = true;
				btn_Insert.Enabled = true;
				btn_Delete.Enabled = true;

				return;

			}




//			string now_date = System.DateTime.Now.ToString("yyyyMM");
//			string select_date = cmb_OBSId.SelectedValue.ToString().Replace("-", "");
//
//
//			// 수정 불가
//			if(Convert.ToInt32(now_date) - 1 > Convert.ToInt32(select_date))
//			{
//
//				tbtn_Save.Enabled = false;
//
//				btn_createCBD.Enabled = false;
//				btn_Tree.Enabled = false;
//				btn_Insert.Enabled = false;
//				btn_Delete.Enabled = false;
//				
//
//			}
//			else
//			{
//
//				tbtn_Save.Enabled = true;
//
//				btn_createCBD.Enabled = true;
//				btn_Tree.Enabled = true;
//				btn_Insert.Enabled = true;
//				btn_Delete.Enabled = true;
//
//
//			}


			



			string now_date = System.DateTime.Now.ToString("yyyyMM");
			string last_date = System.DateTime.Now.AddMonths(-1).ToString("yyyyMM");
			string select_date = cmb_OBSId.SelectedValue.ToString().Replace("-", "");

			// 전월 마감이 이루어 지지 않았을 것으로 예상되어지며, 일주일까지는 수정 가능 하도록 처리
			string standard_date = System.DateTime.Now.ToString("yyyyMM") + "15";  


			// 일주일 이전은 수정 가능, 이후 수정 불가
			if(Convert.ToInt32(System.DateTime.Now.ToString("yyyyMMdd")) <= Convert.ToInt32(standard_date))
			{

				
				// 바로 이전 달 만 수정 가능
				if(Convert.ToInt32(last_date) <= Convert.ToInt32(select_date) )
				{

				
					tbtn_Save.Enabled = true;

					btn_createCBD.Enabled = true;
					btn_Tree.Enabled = true;
					btn_Insert.Enabled = true;
					btn_Delete.Enabled = true;

				}
				else
				{

					
					tbtn_Save.Enabled = false;

					btn_createCBD.Enabled = false;
					btn_Tree.Enabled = false;
					btn_Insert.Enabled = false;
					btn_Delete.Enabled = false;



				} // end if(Convert.ToInt32(now_date) > Convert.ToInt32(select_date))





			}
			else
			{

				// 수정 불가
				if(Convert.ToInt32(now_date) > Convert.ToInt32(select_date))
				{

					tbtn_Save.Enabled = false;

					btn_createCBD.Enabled = false;
					btn_Tree.Enabled = false;
					btn_Insert.Enabled = false;
					btn_Delete.Enabled = false;
				

				}
				else
				{

					tbtn_Save.Enabled = true;

					btn_createCBD.Enabled = true;
					btn_Tree.Enabled = true;
					btn_Insert.Enabled = true;
					btn_Delete.Enabled = true;


				} // end if(Convert.ToInt32(now_date) > Convert.ToInt32(select_date))



			} // end if(Convert.ToInt32(System.DateTime.Now.ToString("yyyyMMdd")) <= Convert.ToInt32(standard_date))





		}







		
	}
}

