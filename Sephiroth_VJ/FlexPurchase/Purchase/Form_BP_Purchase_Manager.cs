using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using FlexPurchase.Shipping;

namespace FlexPurchase.Purchase
{
	public class Form_BP_Purchase_Manager : COM.PCHWinForm.Form_Top
	{
		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.TextBox txt_styleCode;
		private C1.Win.C1List.C1Combo cmb_style;
		private System.Windows.Forms.Label lbl_style;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.Label lbl_shipNo;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_managerSeq;
		private System.Windows.Forms.TextBox txt_managerSeq;
		private C1.Win.C1List.C1Combo cmb_reqReason;
		private System.Windows.Forms.Label lbl_reqReason;
		private System.Windows.Forms.Label lbl_obsType;
		private C1.Win.C1List.C1Combo cmb_obsType;
		private System.Windows.Forms.Label btn_req;
		private System.Windows.Forms.Label btn_pur;
		private System.Windows.Forms.Label lbl_date;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.Label lbl_status;
		private C1.Win.C1List.C1Combo cmb_status;
		private C1.Win.C1List.C1Combo cmb_shipNo;
		private System.Windows.Forms.ContextMenu ctx_main;
		private System.Windows.Forms.MenuItem mnu_Data;
		private System.Windows.Forms.MenuItem mnu_Cbd;
		private C1.Win.C1List.C1Combo cmb_ubDivision;
		private System.Windows.Forms.Label lbl_UB;
		private System.Windows.Forms.MenuItem mnu_AllSelect;
		private C1.Win.C1List.C1Combo cmb_shipType;
		private System.Windows.Forms.Label lbl_shipType;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnu_header;
		private System.Windows.Forms.MenuItem mnu_detaile;
		private System.Windows.Forms.MenuItem mnu_all;
		private System.Windows.Forms.MenuItem mnu_treeview;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem mnu_RequestSelect;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB  = new COM.OraDB();
		private Pop_BP_Purchase_Wait _popWait = null;

		private bool _isAccessible = true;
		private bool _firstLoad    = true;
		private Hashtable _cellCombo = null;
		private const int validate_request = 10, validate_purchase = 20;

		private int _managerSeqCol		= (int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxMANAGER_SEQ;
		private int _custCdCol			= (int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxCUST_CD;
		private int _custNameCol		= (int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxCUST_NAME;
		private int _purUserCol			= (int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxPUR_USER;
		private int _purPriceCol		= (int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxPUR_PRICE;
		private System.Windows.Forms.MenuItem mnu_del;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem mnu_undel;
		private System.Windows.Forms.Label lbl_purUser;
		private C1.Win.C1List.C1Combo cmb_purUser;
		private System.Windows.Forms.Label btn_Shipping;
		private int _statusCol			= (int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxSTATUS;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem mnu_Shipping;

		private COM.ComFunction MyComFunction = new COM.ComFunction();

		#endregion

		#region 생성자 / 소멸자

		public Form_BP_Purchase_Manager()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BP_Purchase_Manager));
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
            C1.Win.C1List.Style style65 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style66 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style67 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style68 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style69 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style70 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style71 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style72 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.btn_Shipping = new System.Windows.Forms.Label();
            this.lbl_purUser = new System.Windows.Forms.Label();
            this.cmb_purUser = new C1.Win.C1List.C1Combo();
            this.cmb_shipNo = new C1.Win.C1List.C1Combo();
            this.txt_managerSeq = new System.Windows.Forms.TextBox();
            this.cmb_status = new C1.Win.C1List.C1Combo();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cmb_shipType = new C1.Win.C1List.C1Combo();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_shipType = new System.Windows.Forms.Label();
            this.btn_pur = new System.Windows.Forms.Label();
            this.btn_req = new System.Windows.Forms.Label();
            this.lbl_obsType = new System.Windows.Forms.Label();
            this.cmb_obsType = new C1.Win.C1List.C1Combo();
            this.cmb_reqReason = new C1.Win.C1List.C1Combo();
            this.lbl_reqReason = new System.Windows.Forms.Label();
            this.lbl_managerSeq = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.txt_styleCode = new System.Windows.Forms.TextBox();
            this.cmb_style = new C1.Win.C1List.C1Combo();
            this.cmb_ubDivision = new C1.Win.C1List.C1Combo();
            this.lbl_UB = new System.Windows.Forms.Label();
            this.lbl_style = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_shipNo = new System.Windows.Forms.Label();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.fgrid_main = new COM.FSP();
            this.ctx_main = new System.Windows.Forms.ContextMenu();
            this.mnu_AllSelect = new System.Windows.Forms.MenuItem();
            this.mnu_RequestSelect = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnu_treeview = new System.Windows.Forms.MenuItem();
            this.mnu_header = new System.Windows.Forms.MenuItem();
            this.mnu_detaile = new System.Windows.Forms.MenuItem();
            this.mnu_all = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnu_del = new System.Windows.Forms.MenuItem();
            this.mnu_undel = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnu_Data = new System.Windows.Forms.MenuItem();
            this.mnu_Cbd = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnu_Shipping = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ubDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.GridDefinition = "23.6111111111111:False:True;74.3055555555556:False:False;0.694444444444444:False:" +
                "True;\t0.393700787401575:False:True;98.4251968503937:False:False;0.39370078740157" +
                "5:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.btn_Shipping);
            this.pnl_head.Controls.Add(this.lbl_purUser);
            this.pnl_head.Controls.Add(this.cmb_purUser);
            this.pnl_head.Controls.Add(this.cmb_shipNo);
            this.pnl_head.Controls.Add(this.txt_managerSeq);
            this.pnl_head.Controls.Add(this.cmb_status);
            this.pnl_head.Controls.Add(this.lbl_status);
            this.pnl_head.Controls.Add(this.cmb_shipType);
            this.pnl_head.Controls.Add(this.dpick_from);
            this.pnl_head.Controls.Add(this.dpick_to);
            this.pnl_head.Controls.Add(this.label5);
            this.pnl_head.Controls.Add(this.lbl_date);
            this.pnl_head.Controls.Add(this.lbl_shipType);
            this.pnl_head.Controls.Add(this.btn_pur);
            this.pnl_head.Controls.Add(this.btn_req);
            this.pnl_head.Controls.Add(this.lbl_obsType);
            this.pnl_head.Controls.Add(this.cmb_obsType);
            this.pnl_head.Controls.Add(this.cmb_reqReason);
            this.pnl_head.Controls.Add(this.lbl_reqReason);
            this.pnl_head.Controls.Add(this.lbl_managerSeq);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.txt_styleCode);
            this.pnl_head.Controls.Add(this.cmb_style);
            this.pnl_head.Controls.Add(this.cmb_ubDivision);
            this.pnl_head.Controls.Add(this.lbl_UB);
            this.pnl_head.Controls.Add(this.lbl_style);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_shipNo);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 136);
            this.pnl_head.TabIndex = 1;
            // 
            // btn_Shipping
            // 
            this.btn_Shipping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Shipping.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Shipping.ImageIndex = 0;
            this.btn_Shipping.ImageList = this.img_Button;
            this.btn_Shipping.Location = new System.Drawing.Point(908, 106);
            this.btn_Shipping.Name = "btn_Shipping";
            this.btn_Shipping.Size = new System.Drawing.Size(80, 23);
            this.btn_Shipping.TabIndex = 674;
            this.btn_Shipping.Text = "Shipping";
            this.btn_Shipping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Shipping.Click += new System.EventHandler(this.btn_Shipping_Click);
            // 
            // lbl_purUser
            // 
            this.lbl_purUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_purUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purUser.ImageIndex = 0;
            this.lbl_purUser.ImageList = this.img_Label;
            this.lbl_purUser.Location = new System.Drawing.Point(337, 106);
            this.lbl_purUser.Name = "lbl_purUser";
            this.lbl_purUser.Size = new System.Drawing.Size(100, 21);
            this.lbl_purUser.TabIndex = 375;
            this.lbl_purUser.Text = "Purchase User";
            this.lbl_purUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_purUser.Visible = false;
            // 
            // cmb_purUser
            // 
            this.cmb_purUser.AddItemCols = 0;
            this.cmb_purUser.AddItemSeparator = ';';
            this.cmb_purUser.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_purUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_purUser.Caption = "";
            this.cmb_purUser.CaptionHeight = 17;
            this.cmb_purUser.CaptionStyle = style1;
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
            this.cmb_purUser.EvenRowStyle = style2;
            this.cmb_purUser.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_purUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_purUser.FooterStyle = style3;
            this.cmb_purUser.GapHeight = 2;
            this.cmb_purUser.HeadingStyle = style4;
            this.cmb_purUser.HighLightRowStyle = style5;
            this.cmb_purUser.ItemHeight = 15;
            this.cmb_purUser.Location = new System.Drawing.Point(438, 106);
            this.cmb_purUser.MatchEntryTimeout = ((long)(2000));
            this.cmb_purUser.MaxDropDownItems = ((short)(5));
            this.cmb_purUser.MaxLength = 32767;
            this.cmb_purUser.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_purUser.Name = "cmb_purUser";
            this.cmb_purUser.OddRowStyle = style6;
            this.cmb_purUser.PartialRightColumn = false;
            this.cmb_purUser.PropBag = resources.GetString("cmb_purUser.PropBag");
            this.cmb_purUser.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_purUser.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_purUser.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_purUser.SelectedStyle = style7;
            this.cmb_purUser.Size = new System.Drawing.Size(220, 20);
            this.cmb_purUser.Style = style8;
            this.cmb_purUser.TabIndex = 8;
            this.cmb_purUser.Visible = false;
            // 
            // cmb_shipNo
            // 
            this.cmb_shipNo.AddItemCols = 0;
            this.cmb_shipNo.AddItemSeparator = ';';
            this.cmb_shipNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipNo.Caption = "";
            this.cmb_shipNo.CaptionHeight = 17;
            this.cmb_shipNo.CaptionStyle = style9;
            this.cmb_shipNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_shipNo.ColumnCaptionHeight = 18;
            this.cmb_shipNo.ColumnFooterHeight = 18;
            this.cmb_shipNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_shipNo.ContentHeight = 16;
            this.cmb_shipNo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_shipNo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_shipNo.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_shipNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_shipNo.EditorHeight = 16;
            this.cmb_shipNo.EvenRowStyle = style10;
            this.cmb_shipNo.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_shipNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipNo.FooterStyle = style11;
            this.cmb_shipNo.GapHeight = 2;
            this.cmb_shipNo.HeadingStyle = style12;
            this.cmb_shipNo.HighLightRowStyle = style13;
            this.cmb_shipNo.ItemHeight = 15;
            this.cmb_shipNo.Location = new System.Drawing.Point(438, 62);
            this.cmb_shipNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipNo.MaxDropDownItems = ((short)(5));
            this.cmb_shipNo.MaxLength = 32767;
            this.cmb_shipNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipNo.Name = "cmb_shipNo";
            this.cmb_shipNo.OddRowStyle = style14;
            this.cmb_shipNo.PartialRightColumn = false;
            this.cmb_shipNo.PropBag = resources.GetString("cmb_shipNo.PropBag");
            this.cmb_shipNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipNo.SelectedStyle = style15;
            this.cmb_shipNo.Size = new System.Drawing.Size(220, 20);
            this.cmb_shipNo.Style = style16;
            this.cmb_shipNo.TabIndex = 541;
            // 
            // txt_managerSeq
            // 
            this.txt_managerSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_managerSeq.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_managerSeq.Location = new System.Drawing.Point(438, 40);
            this.txt_managerSeq.MaxLength = 13;
            this.txt_managerSeq.Name = "txt_managerSeq";
            this.txt_managerSeq.Size = new System.Drawing.Size(220, 21);
            this.txt_managerSeq.TabIndex = 2;
            // 
            // cmb_status
            // 
            this.cmb_status.AddItemCols = 0;
            this.cmb_status.AddItemSeparator = ';';
            this.cmb_status.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_status.Caption = "";
            this.cmb_status.CaptionHeight = 17;
            this.cmb_status.CaptionStyle = style17;
            this.cmb_status.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_status.ColumnCaptionHeight = 18;
            this.cmb_status.ColumnFooterHeight = 18;
            this.cmb_status.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_status.ContentHeight = 16;
            this.cmb_status.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_status.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_status.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_status.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_status.EditorHeight = 16;
            this.cmb_status.EvenRowStyle = style18;
            this.cmb_status.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_status.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FooterStyle = style19;
            this.cmb_status.GapHeight = 2;
            this.cmb_status.HeadingStyle = style20;
            this.cmb_status.HighLightRowStyle = style21;
            this.cmb_status.ItemHeight = 15;
            this.cmb_status.Location = new System.Drawing.Point(109, 106);
            this.cmb_status.MatchEntryTimeout = ((long)(2000));
            this.cmb_status.MaxDropDownItems = ((short)(5));
            this.cmb_status.MaxLength = 32767;
            this.cmb_status.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.OddRowStyle = style22;
            this.cmb_status.PartialRightColumn = false;
            this.cmb_status.PropBag = resources.GetString("cmb_status.PropBag");
            this.cmb_status.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_status.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_status.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_status.SelectedStyle = style23;
            this.cmb_status.Size = new System.Drawing.Size(220, 20);
            this.cmb_status.Style = style24;
            this.cmb_status.TabIndex = 394;
            this.cmb_status.SelectedValueChanged += new System.EventHandler(this.cmb_status_SelectedValueChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_status.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ImageIndex = 1;
            this.lbl_status.ImageList = this.img_Label;
            this.lbl_status.Location = new System.Drawing.Point(8, 106);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(100, 21);
            this.lbl_status.TabIndex = 393;
            this.lbl_status.Text = "Status";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_shipType
            // 
            this.cmb_shipType.AddItemCols = 0;
            this.cmb_shipType.AddItemSeparator = ';';
            this.cmb_shipType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipType.Caption = "";
            this.cmb_shipType.CaptionHeight = 17;
            this.cmb_shipType.CaptionStyle = style25;
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
            this.cmb_shipType.EvenRowStyle = style26;
            this.cmb_shipType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipType.FooterStyle = style27;
            this.cmb_shipType.GapHeight = 2;
            this.cmb_shipType.HeadingStyle = style28;
            this.cmb_shipType.HighLightRowStyle = style29;
            this.cmb_shipType.ItemHeight = 15;
            this.cmb_shipType.Location = new System.Drawing.Point(109, 62);
            this.cmb_shipType.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipType.MaxDropDownItems = ((short)(5));
            this.cmb_shipType.MaxLength = 32767;
            this.cmb_shipType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipType.Name = "cmb_shipType";
            this.cmb_shipType.OddRowStyle = style30;
            this.cmb_shipType.PartialRightColumn = false;
            this.cmb_shipType.PropBag = resources.GetString("cmb_shipType.PropBag");
            this.cmb_shipType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipType.SelectedStyle = style31;
            this.cmb_shipType.Size = new System.Drawing.Size(220, 20);
            this.cmb_shipType.Style = style32;
            this.cmb_shipType.TabIndex = 392;
            this.cmb_shipType.SelectedValueChanged += new System.EventHandler(this.cmb_division_SelectedValueChanged);
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(109, 84);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(100, 21);
            this.dpick_from.TabIndex = 389;
            this.dpick_from.CloseUp += new System.EventHandler(this.dpick_from_CloseUp);
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(230, 84);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(100, 21);
            this.dpick_to.TabIndex = 390;
            this.dpick_to.CloseUp += new System.EventHandler(this.dpick_to_CloseUp);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(211, 85);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 391;
            this.label5.Text = "~";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_date
            // 
            this.lbl_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ImageIndex = 1;
            this.lbl_date.ImageList = this.img_Label;
            this.lbl_date.Location = new System.Drawing.Point(8, 84);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(100, 21);
            this.lbl_date.TabIndex = 388;
            this.lbl_date.Text = "Date";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lbl_shipType.TabIndex = 387;
            this.lbl_shipType.Text = "Ship Type";
            this.lbl_shipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_pur
            // 
            this.btn_pur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_pur.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_pur.ImageIndex = 0;
            this.btn_pur.ImageList = this.img_Button;
            this.btn_pur.Location = new System.Drawing.Point(828, 106);
            this.btn_pur.Name = "btn_pur";
            this.btn_pur.Size = new System.Drawing.Size(80, 23);
            this.btn_pur.TabIndex = 386;
            this.btn_pur.Text = "Purchase";
            this.btn_pur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_pur.Click += new System.EventHandler(this.btn_pur_Click);
            this.btn_pur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_pur.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_req
            // 
            this.btn_req.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_req.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_req.ImageIndex = 0;
            this.btn_req.ImageList = this.img_Button;
            this.btn_req.Location = new System.Drawing.Point(748, 106);
            this.btn_req.Name = "btn_req";
            this.btn_req.Size = new System.Drawing.Size(80, 23);
            this.btn_req.TabIndex = 355;
            this.btn_req.Text = "Request";
            this.btn_req.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_req.Click += new System.EventHandler(this.btn_req_Click);
            this.btn_req.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_req.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // lbl_obsType
            // 
            this.lbl_obsType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_obsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obsType.ImageIndex = 0;
            this.lbl_obsType.ImageList = this.img_Label;
            this.lbl_obsType.Location = new System.Drawing.Point(666, 62);
            this.lbl_obsType.Name = "lbl_obsType";
            this.lbl_obsType.Size = new System.Drawing.Size(100, 21);
            this.lbl_obsType.TabIndex = 379;
            this.lbl_obsType.Text = "Order Type";
            this.lbl_obsType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_obsType
            // 
            this.cmb_obsType.AddItemCols = 0;
            this.cmb_obsType.AddItemSeparator = ';';
            this.cmb_obsType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_obsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_obsType.Caption = "";
            this.cmb_obsType.CaptionHeight = 17;
            this.cmb_obsType.CaptionStyle = style33;
            this.cmb_obsType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_obsType.ColumnCaptionHeight = 18;
            this.cmb_obsType.ColumnFooterHeight = 18;
            this.cmb_obsType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_obsType.ContentHeight = 16;
            this.cmb_obsType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_obsType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_obsType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_obsType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_obsType.EditorHeight = 16;
            this.cmb_obsType.EvenRowStyle = style34;
            this.cmb_obsType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_obsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_obsType.FooterStyle = style35;
            this.cmb_obsType.GapHeight = 2;
            this.cmb_obsType.HeadingStyle = style36;
            this.cmb_obsType.HighLightRowStyle = style37;
            this.cmb_obsType.ItemHeight = 15;
            this.cmb_obsType.Location = new System.Drawing.Point(767, 62);
            this.cmb_obsType.MatchEntryTimeout = ((long)(2000));
            this.cmb_obsType.MaxDropDownItems = ((short)(5));
            this.cmb_obsType.MaxLength = 32767;
            this.cmb_obsType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_obsType.Name = "cmb_obsType";
            this.cmb_obsType.OddRowStyle = style38;
            this.cmb_obsType.PartialRightColumn = false;
            this.cmb_obsType.PropBag = resources.GetString("cmb_obsType.PropBag");
            this.cmb_obsType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_obsType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_obsType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_obsType.SelectedStyle = style39;
            this.cmb_obsType.Size = new System.Drawing.Size(220, 20);
            this.cmb_obsType.Style = style40;
            this.cmb_obsType.TabIndex = 13;
            // 
            // cmb_reqReason
            // 
            this.cmb_reqReason.AddItemCols = 0;
            this.cmb_reqReason.AddItemSeparator = ';';
            this.cmb_reqReason.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_reqReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_reqReason.Caption = "";
            this.cmb_reqReason.CaptionHeight = 17;
            this.cmb_reqReason.CaptionStyle = style41;
            this.cmb_reqReason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_reqReason.ColumnCaptionHeight = 18;
            this.cmb_reqReason.ColumnFooterHeight = 18;
            this.cmb_reqReason.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_reqReason.ContentHeight = 16;
            this.cmb_reqReason.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_reqReason.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_reqReason.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_reqReason.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_reqReason.EditorHeight = 16;
            this.cmb_reqReason.EvenRowStyle = style42;
            this.cmb_reqReason.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_reqReason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reqReason.FooterStyle = style43;
            this.cmb_reqReason.GapHeight = 2;
            this.cmb_reqReason.HeadingStyle = style44;
            this.cmb_reqReason.HighLightRowStyle = style45;
            this.cmb_reqReason.ItemHeight = 15;
            this.cmb_reqReason.Location = new System.Drawing.Point(438, 84);
            this.cmb_reqReason.MatchEntryTimeout = ((long)(2000));
            this.cmb_reqReason.MaxDropDownItems = ((short)(5));
            this.cmb_reqReason.MaxLength = 32767;
            this.cmb_reqReason.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_reqReason.Name = "cmb_reqReason";
            this.cmb_reqReason.OddRowStyle = style46;
            this.cmb_reqReason.PartialRightColumn = false;
            this.cmb_reqReason.PropBag = resources.GetString("cmb_reqReason.PropBag");
            this.cmb_reqReason.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_reqReason.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_reqReason.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_reqReason.SelectedStyle = style47;
            this.cmb_reqReason.Size = new System.Drawing.Size(220, 20);
            this.cmb_reqReason.Style = style48;
            this.cmb_reqReason.TabIndex = 8;
            // 
            // lbl_reqReason
            // 
            this.lbl_reqReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqReason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqReason.ImageIndex = 0;
            this.lbl_reqReason.ImageList = this.img_Label;
            this.lbl_reqReason.Location = new System.Drawing.Point(337, 84);
            this.lbl_reqReason.Name = "lbl_reqReason";
            this.lbl_reqReason.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqReason.TabIndex = 375;
            this.lbl_reqReason.Text = "Request Reason";
            this.lbl_reqReason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_managerSeq
            // 
            this.lbl_managerSeq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_managerSeq.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_managerSeq.ImageIndex = 0;
            this.lbl_managerSeq.ImageList = this.img_Label;
            this.lbl_managerSeq.Location = new System.Drawing.Point(337, 40);
            this.lbl_managerSeq.Name = "lbl_managerSeq";
            this.lbl_managerSeq.Size = new System.Drawing.Size(100, 21);
            this.lbl_managerSeq.TabIndex = 366;
            this.lbl_managerSeq.Text = "Manager Seq";
            this.lbl_managerSeq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
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
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style51;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style52;
            this.cmb_factory.HighLightRowStyle = style53;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style54;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style55;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style56;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            // 
            // txt_styleCode
            // 
            this.txt_styleCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCode.Location = new System.Drawing.Point(767, 40);
            this.txt_styleCode.MaxLength = 10;
            this.txt_styleCode.Name = "txt_styleCode";
            this.txt_styleCode.Size = new System.Drawing.Size(79, 21);
            this.txt_styleCode.TabIndex = 11;
            this.txt_styleCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_styleCd_KeyUp);
            // 
            // cmb_style
            // 
            this.cmb_style.AddItemCols = 0;
            this.cmb_style.AddItemSeparator = ';';
            this.cmb_style.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_style.Caption = "";
            this.cmb_style.CaptionHeight = 17;
            this.cmb_style.CaptionStyle = style57;
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
            this.cmb_style.EvenRowStyle = style58;
            this.cmb_style.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style.FooterStyle = style59;
            this.cmb_style.GapHeight = 2;
            this.cmb_style.HeadingStyle = style60;
            this.cmb_style.HighLightRowStyle = style61;
            this.cmb_style.ItemHeight = 15;
            this.cmb_style.Location = new System.Drawing.Point(847, 40);
            this.cmb_style.MatchEntryTimeout = ((long)(2000));
            this.cmb_style.MaxDropDownItems = ((short)(5));
            this.cmb_style.MaxLength = 32767;
            this.cmb_style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_style.Name = "cmb_style";
            this.cmb_style.OddRowStyle = style62;
            this.cmb_style.PartialRightColumn = false;
            this.cmb_style.PropBag = resources.GetString("cmb_style.PropBag");
            this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_style.SelectedStyle = style63;
            this.cmb_style.Size = new System.Drawing.Size(140, 20);
            this.cmb_style.Style = style64;
            this.cmb_style.TabIndex = 12;
            this.cmb_style.SelectedValueChanged += new System.EventHandler(this.cmb_style_SelectedValueChanged);
            // 
            // cmb_ubDivision
            // 
            this.cmb_ubDivision.AddItemCols = 0;
            this.cmb_ubDivision.AddItemSeparator = ';';
            this.cmb_ubDivision.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_ubDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ubDivision.Caption = "";
            this.cmb_ubDivision.CaptionHeight = 17;
            this.cmb_ubDivision.CaptionStyle = style65;
            this.cmb_ubDivision.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_ubDivision.ColumnCaptionHeight = 18;
            this.cmb_ubDivision.ColumnFooterHeight = 18;
            this.cmb_ubDivision.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_ubDivision.ContentHeight = 16;
            this.cmb_ubDivision.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_ubDivision.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_ubDivision.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_ubDivision.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_ubDivision.EditorHeight = 16;
            this.cmb_ubDivision.EvenRowStyle = style66;
            this.cmb_ubDivision.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_ubDivision.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ubDivision.FooterStyle = style67;
            this.cmb_ubDivision.GapHeight = 2;
            this.cmb_ubDivision.HeadingStyle = style68;
            this.cmb_ubDivision.HighLightRowStyle = style69;
            this.cmb_ubDivision.ItemHeight = 15;
            this.cmb_ubDivision.Location = new System.Drawing.Point(767, 84);
            this.cmb_ubDivision.MatchEntryTimeout = ((long)(2000));
            this.cmb_ubDivision.MaxDropDownItems = ((short)(5));
            this.cmb_ubDivision.MaxLength = 32767;
            this.cmb_ubDivision.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ubDivision.Name = "cmb_ubDivision";
            this.cmb_ubDivision.OddRowStyle = style70;
            this.cmb_ubDivision.PartialRightColumn = false;
            this.cmb_ubDivision.PropBag = resources.GetString("cmb_ubDivision.PropBag");
            this.cmb_ubDivision.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ubDivision.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ubDivision.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ubDivision.SelectedStyle = style71;
            this.cmb_ubDivision.Size = new System.Drawing.Size(220, 20);
            this.cmb_ubDivision.Style = style72;
            this.cmb_ubDivision.TabIndex = 4;
            // 
            // lbl_UB
            // 
            this.lbl_UB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_UB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UB.ImageIndex = 0;
            this.lbl_UB.ImageList = this.img_Label;
            this.lbl_UB.Location = new System.Drawing.Point(666, 84);
            this.lbl_UB.Name = "lbl_UB";
            this.lbl_UB.Size = new System.Drawing.Size(100, 21);
            this.lbl_UB.TabIndex = 56;
            this.lbl_UB.Text = "U/B Division";
            this.lbl_UB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_style
            // 
            this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_style.ImageIndex = 0;
            this.lbl_style.ImageList = this.img_Label;
            this.lbl_style.Location = new System.Drawing.Point(666, 40);
            this.lbl_style.Name = "lbl_style";
            this.lbl_style.Size = new System.Drawing.Size(100, 21);
            this.lbl_style.TabIndex = 365;
            this.lbl_style.Text = "Style";
            this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 120);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // lbl_shipNo
            // 
            this.lbl_shipNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipNo.ImageIndex = 0;
            this.lbl_shipNo.ImageList = this.img_Label;
            this.lbl_shipNo.Location = new System.Drawing.Point(337, 62);
            this.lbl_shipNo.Name = "lbl_shipNo";
            this.lbl_shipNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipNo.TabIndex = 50;
            this.lbl_shipNo.Text = "MRP Ship No";
            this.lbl_shipNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 119);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(960, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 40);
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
            this.pic_head7.Size = new System.Drawing.Size(101, 95);
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 30);
            this.label2.TabIndex = 42;
            this.label2.Text = "      Purchase Manager";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(208, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(960, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
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
            this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
            this.pic_head6.Location = new System.Drawing.Point(0, 16);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 109);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(8, 140);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Size = new System.Drawing.Size(1000, 428);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 0;
            this.fgrid_main.Click += new System.EventHandler(this.fgrid_main_Click);
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            // 
            // ctx_main
            // 
            this.ctx_main.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_AllSelect,
            this.mnu_RequestSelect,
            this.menuItem5,
            this.mnu_treeview,
            this.menuItem1,
            this.mnu_del,
            this.mnu_undel,
            this.menuItem3,
            this.mnu_Data,
            this.mnu_Cbd,
            this.menuItem2,
            this.mnu_Shipping});
            // 
            // mnu_AllSelect
            // 
            this.mnu_AllSelect.Index = 0;
            this.mnu_AllSelect.Text = "All Select";
            this.mnu_AllSelect.Click += new System.EventHandler(this.mnu_AllSelect_Click);
            // 
            // mnu_RequestSelect
            // 
            this.mnu_RequestSelect.Index = 1;
            this.mnu_RequestSelect.Text = "Request Select";
            this.mnu_RequestSelect.Click += new System.EventHandler(this.mnu_RequestSelect_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.Text = "-";
            // 
            // mnu_treeview
            // 
            this.mnu_treeview.Index = 3;
            this.mnu_treeview.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_header,
            this.mnu_detaile,
            this.mnu_all});
            this.mnu_treeview.Text = "Tree View Option";
            // 
            // mnu_header
            // 
            this.mnu_header.Checked = true;
            this.mnu_header.Index = 0;
            this.mnu_header.RadioCheck = true;
            this.mnu_header.Text = "Header";
            this.mnu_header.Click += new System.EventHandler(this.mnu_header_Click);
            // 
            // mnu_detaile
            // 
            this.mnu_detaile.Index = 1;
            this.mnu_detaile.RadioCheck = true;
            this.mnu_detaile.Text = "Detaile";
            this.mnu_detaile.Click += new System.EventHandler(this.mnu_detaile_Click);
            // 
            // mnu_all
            // 
            this.mnu_all.Index = 2;
            this.mnu_all.RadioCheck = true;
            this.mnu_all.Text = "All";
            this.mnu_all.Click += new System.EventHandler(this.mnu_all_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 4;
            this.menuItem1.Text = "-";
            // 
            // mnu_del
            // 
            this.mnu_del.Index = 5;
            this.mnu_del.Text = "Delete Item";
            this.mnu_del.Click += new System.EventHandler(this.mnu_del_Click);
            // 
            // mnu_undel
            // 
            this.mnu_undel.Index = 6;
            this.mnu_undel.Text = "Undelete Item";
            this.mnu_undel.Click += new System.EventHandler(this.mnu_undel_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 7;
            this.menuItem3.Text = "-";
            // 
            // mnu_Data
            // 
            this.mnu_Data.Index = 8;
            this.mnu_Data.Text = "Value Change";
            this.mnu_Data.Click += new System.EventHandler(this.mnu_Data_Click);
            // 
            // mnu_Cbd
            // 
            this.mnu_Cbd.Index = 9;
            this.mnu_Cbd.Text = "CBD Information";
            this.mnu_Cbd.Click += new System.EventHandler(this.mnu_Cbd_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 10;
            this.menuItem2.Text = "-";
            // 
            // mnu_Shipping
            // 
            this.mnu_Shipping.Index = 11;
            this.mnu_Shipping.Text = "Shipping Date";
            this.mnu_Shipping.Click += new System.EventHandler(this.mnu_Shipping_Click);
            // 
            // Form_BP_Purchase_Manager
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BP_Purchase_Manager";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_BP_Purchase_Manager_Closing);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ubDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();
		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess();
		}

		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(30))
			{
				if (e.Button == MouseButtons.Right)
					ctx_main.Show(fgrid_main, new Point(e.X, e.Y));
			}
		}

		private void Grid_CellClickProcess()
		{
			int[] vSelectionRange = fgrid_main.Selections;
			int vCol = fgrid_main.Selection.c1;

			if (vSelectionRange.Length == 0)	return;

			COM.ComVar.Parameter_PopUp		= new string[1];
			COM.ComVar.Parameter_PopUp[0]	= fgrid_main[1, vCol].ToString();
	
			if (_cellCombo.ContainsKey(vCol))
				ClassLib.ComVar.Parameter_PopUp_Object = new object[]{_cellCombo[vCol]};

			Pop_BS_Shipping_List_Changer pop_changer = new Pop_BS_Shipping_List_Changer();
			pop_changer.ShowDialog();

			if (COM.ComVar.Parameter_PopUp != null)
				foreach (int i in vSelectionRange)
				{
					if (!fgrid_main[i, _statusCol].ToString().Equals(ClassLib.ComVar.PURCHASE))
					{
						if (COM.ComVar.Parameter_PopUp.Length > 1)
						{
							fgrid_main[i, _custNameCol] = COM.ComVar.Parameter_PopUp[0];
							fgrid_main[i, _custCdCol] = COM.ComVar.Parameter_PopUp[1];
						}
						else
						{
							fgrid_main[i, vCol] = COM.ComVar.Parameter_PopUp[0];
						}

						fgrid_main.Update_Row(i);
					}
				}

			pop_changer.Dispose();
		}

		private void Grid_CellClickProcess_Shipping()
		{
			int[] vSelectionRange = fgrid_main.Selections;
			//int vCol = fgrid_main.Selection.c1;
			
			int vCol = (int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxREQ_YMD;

			if (vSelectionRange.Length == 0)	return;

			COM.ComVar.Parameter_PopUp = new string[]{"Date", dpick_from.Text};

			Pop_BS_Shipping_List_Changer pop_changer = new Pop_BS_Shipping_List_Changer();
			pop_changer.ShowDialog();

			if (COM.ComVar.Parameter_PopUp != null)
				foreach (int i in vSelectionRange)
				{
					if (!fgrid_main[i, _statusCol].ToString().Equals(ClassLib.ComVar.PURCHASE))
					{
						if (COM.ComVar.Parameter_PopUp.Length > 1)
						{
							fgrid_main[i, _custNameCol] = COM.ComVar.Parameter_PopUp[0];
							fgrid_main[i, _custCdCol] = COM.ComVar.Parameter_PopUp[1];
						}
						else
						{
							fgrid_main[i, vCol] = COM.ComVar.Parameter_PopUp[0];
							fgrid_main[i, (int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxTRANSPORT_TYPE] = "10";
						}

						fgrid_main.Update_Row(i);
					}
				}

			pop_changer.Dispose();
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
				this.Tbtn_SearchProcess();
		}

		private void pop_Closed(object sender, EventArgs e)
		{
			this.Tbtn_SearchProcess();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Save))
			{
				if(ClassLib.ComFunction.User_Message("Do you want to save?","Save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )
					this.Tbtn_SaveProcess();
			}
		}	

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BP_Purchase_Manager") ;
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 16;
			string [] aHead =  new string[iCnt];	
			


			aHead[0]    = COM.ComFunction.Empty_Combo(cmb_factory, "");
			aHead[1]    = this.dpick_from.Text.Replace("-", "");
			aHead[2]    = this.dpick_to.Text.Replace("-", "");
			aHead[3]    = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			aHead[4]    = COM.ComFunction.Empty_Combo(cmb_status, "");
			aHead[5]    = this.txt_managerSeq.Text;
			aHead[6]    = COM.ComFunction.Empty_Combo(cmb_reqReason, "");
			aHead[7]    = COM.ComFunction.Empty_Combo(cmb_style, "").Replace("-", "");
			aHead[8]    = COM.ComFunction.Empty_Combo(cmb_shipNo, "");
			aHead[9]    = COM.ComFunction.Empty_Combo(cmb_ubDivision, "");			
			aHead[10]   = COM.ComFunction.Empty_Combo(cmb_obsType, "");
			aHead[11]	= cmb_shipType.GetItemText(cmb_shipType.SelectedIndex, 1);
			aHead[12]	= cmb_status.GetItemText(cmb_status.SelectedIndex, 1);
			aHead[13]	= cmb_reqReason.GetItemText(cmb_reqReason.SelectedIndex, 1);
			aHead[14]	= cmb_obsType.GetItemText(cmb_obsType.SelectedIndex, 1);
			aHead[15]	= cmb_reqReason.GetItemText(cmb_reqReason.SelectedIndex, 1);
			#endregion
			
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			
			FlexBase.Report.Form_RdViewer report = new FlexBase.Report.Form_RdViewer (mrd_Filename, Para);
			report.Show();		
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

		private void Form_BP_Purchase_Manager_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
			{
				string vCheck = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0).Clip;
				if(vCheck.IndexOf("I") > 0 || vCheck.IndexOf("U") > 0 || vCheck.IndexOf("D") > 0)
				{
					if(MessageBox.Show(this, "Exist Modify Data, Do you want to close?","Close", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.No )
						e.Cancel = true;
				}
			}
		}

		private void cmb_style_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Cmb_StyleSelectedValueChangedProcess();
		}

		private void Cmb_StyleSelectedValueChangedProcess()
		{
			try
			{
				if (_isAccessible)
				{
					txt_styleCode.Text		= cmb_style.SelectedValue.ToString();
					cmb_style.SelectedValue = txt_styleCode.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void txt_styleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				this.Txt_StyleCdKeyUpProcess();
		}

		#region 컨텍스트 메뉴

		private void mnu_AllSelect_Click(object sender, System.EventArgs e)
		{
			fgrid_main.SelectAll();
		}

		private void mnu_RequestSelect_Click(object sender, System.EventArgs e)
		{
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _statusCol]).Equals(ClassLib.ComVar.REQUEST))
				{
					fgrid_main.Rows[vRow].Selected = true;
				}
			}
		}

		private void mnu_del_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Search))
			{
				int[] vSels = fgrid_main.Selections;

				foreach (int vRow in vSels)
				{
					if(fgrid_main.Rows[vRow].AllowEditing)
					{
						if(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _statusCol]).Equals("REQUEST") || ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _statusCol]).Equals("RETURN"))
							fgrid_main.Delete_Row(vRow);
					}
				}
			}
		}

		private void mnu_undel_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Search))
			{
				if ((ClassLib.ComFunction.NullToBlank(fgrid_main[fgrid_main.Row, _statusCol]).Equals("REQUEST") || ClassLib.ComFunction.NullToBlank(fgrid_main[fgrid_main.Row, _statusCol]).Equals("RETURN")) &&
					ClassLib.ComFunction.NullToBlank(fgrid_main[fgrid_main.Row, 0]).Equals(ClassLib.ComVar.Delete))
					fgrid_main[fgrid_main.Row, 0] = "";
			}
		}

		private void mnu_Data_Click(object sender, System.EventArgs e)
		{
			Grid_CellClickProcess();
		}

		
		private void mnu_Shipping_Click(object sender, System.EventArgs e)
		{
			Grid_CellClickProcess_Shipping(); 

		}

		private void mnu_Cbd_Click(object sender, System.EventArgs e)
		{
			/*************************************
			0 : FACTORY,	  	1 : PUR_USER,
			2 : CUST_CD,		3 :	PK_UNIT_QTY, 
			4 : PUR_PRICE,		5 :	PUR_CURRENCY, 		 
			6 : OUTSIDE_PRICE,	7 :	OUTSIDE_CURRENCY, 
			8 : CBD_PRICE, 		9 :	CBD_CURRENCY, 
			10 : SHIP_PRICE,	11 : SHIP_CURRENCY, 
			12 : CBM, 			13 : WEIGHT
			**************************************/

			// 검색 조건
			int[] keys = new int[]{   -1,
									  (int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxOBS_ID,
									  (int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxCHECK,
									  (int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxITEM_CD,
									  (int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxSPEC_CD,
									  (int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxCOLOR_CD };

			// 검색 결과
			int[] values = new int[]{ 
										-1,														(int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxPUR_USER,
										(int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxCUST_CD,	    (int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxCUST_NAME,	  
										(int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxPK_UNIT_QTY,
										(int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxPUR_PRICE,		(int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxPUR_CURRENCY,
										-1,														-1,
										(int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxCBD_PRICE,		(int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxCBD_CURRENCY,
										(int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxSHIP_PRICE,	(int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxSHIP_CURRENCY,
										-1,											 			-1
									};

			Pop_BC_CBD_Information_3 vPop = new Pop_BC_CBD_Information_3(fgrid_main, keys, values);
			
			// 검색 조건
			vPop._factory = cmb_factory.SelectedValue.ToString();
			vPop._level = 3;
			
			vPop.ShowDialog(this);
		}

		private void mnu_header_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(1);
			mnu_header.Checked = true;
			mnu_detaile.Checked = false;
			mnu_all.Checked = false;
		}

		private void mnu_detaile_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(2);
			mnu_header.Checked = false;
			mnu_detaile.Checked = true;
			mnu_all.Checked = false;
		}

		private void mnu_all_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(3);
			mnu_header.Checked = false;
			mnu_detaile.Checked = false;
			mnu_all.Checked = true;
		}

		#endregion

		#region 검색조건

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			// clear
			if( !_firstLoad )
				ClearNotPk();

            Cmb_MRPShipNoSetting();
		}

		private void cmb_division_SelectedValueChanged(object sender, System.EventArgs e)
		{
			// clear
			if( !_firstLoad )
				ClearNotPk();
			
			if (cmb_shipType.SelectedValue.ToString().Equals("11"))
				cmb_reqReason.SelectedIndex = 0;
			else if (cmb_shipType.SelectedValue.ToString().Equals("99"))
				cmb_reqReason.SelectedIndex = 1;
			
		}

		private void dpick_from_CloseUp(object sender, System.EventArgs e)
		{
			// clear
			if( !_firstLoad )
				ClearNotPk();

			Cmb_MRPShipNoSetting();
			dpick_to.Value = dpick_from.Value;
		}
		
		private void dpick_to_CloseUp(object sender, System.EventArgs e)
		{
			// clear
			if( !_firstLoad )
				ClearNotPk();

			Cmb_MRPShipNoSetting();
		}

		private void cmb_status_SelectedValueChanged(object sender, System.EventArgs e)
		{
			// clear
			if( !_firstLoad )
				ClearNotPk();			
		}

		#endregion
	
		#region 입력이동

		private void Control_MoveNextByFocus(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.Control_MoveNextByFocus(sender, e.KeyChar);
		}

		#endregion

		#region 버튼효과

		private void btn_click_Effect_Plus(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_click_Effect_Minus(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;		
		}

		#endregion

		#endregion

		#region 공통 메서드

		private void ClearNotPk()
		{
			cmb_obsType.SelectedIndex		= 0;
			txt_managerSeq.Text				= "";
			txt_styleCode.Text				= "";
			cmb_ubDivision.SelectedIndex	= 0;

			cmb_style.ClearItems();

		}

		private void Grid_SetColor()
		{
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				// design setting
				switch (fgrid_main.Rows[vRow].Node.Level)
				{
					case 1:
						fgrid_main.GetCellRange(vRow, fgrid_main.Cols.Frozen, vRow, fgrid_main.Cols.Count - 1).Clear(ClearFlags.Content);
						fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						fgrid_main.Rows[vRow].AllowEditing = false;
						break;
					case 2:
						//fgrid_main.GetCellRange(vRow, _purPriceCol, vRow, fgrid_main.Cols.Count - 1).Clear(ClearFlags.Content);
						fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
						//fgrid_main.Rows[vRow].AllowEditing = false;
						break;
					case 3:
						fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
						if (fgrid_main[vRow, _statusCol].ToString().StartsWith("P"))
						{
							fgrid_main.Rows[vRow].StyleNew.ForeColor = ClassLib.ComVar.Clr_Proc1;
							fgrid_main.Rows[vRow].AllowEditing = false;
						}
						else if (fgrid_main[vRow, _statusCol].ToString().StartsWith("F"))
						{
							fgrid_main.Rows[vRow].StyleNew.ForeColor = ClassLib.ComVar.Clr_Complete;
							fgrid_main.Rows[vRow].AllowEditing = false;
						}
						break;
				}
			}
		}

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting
			ClassLib.ComFunction.Init_Form_Control(this);

            lbl_MainTitle.Text = "Purchase Manager";
            this.Text = "Purchase Manager";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			fgrid_main.Set_Grid("SBP_PURCHASE_MANAGER", "3", 3, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Rows[1].AllowMerging = true;
			fgrid_main.Rows[3].Visible = false;
			

			// user define variable set
			_firstLoad              = true;
			_cellCombo				= new Hashtable(fgrid_main.Cols.Count);

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
			vDt.Dispose() ;

			// ship type
			vDt = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBM10");
			COM.ComCtl.Set_ComboList(vDt, cmb_ubDivision, 1, 2, true);
			cmb_ubDivision.SelectedIndex = 1;
			vDt.Dispose();

			// cmb_reqReason
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBP11");
			COM.ComCtl.Set_ComboList(vDt, cmb_reqReason, 1, 2, false);
			cmb_reqReason.SelectedIndex = 0;
			vDt.Dispose();

			//	cmb_obsType
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SEM10");
			COM.ComCtl.Set_ComboList(vDt, cmb_obsType, 1, 2, true, 80, 140);
			cmb_obsType.SelectedIndex = 0;
			vDt.Dispose();

			//	cmb_division
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBM09");
			COM.ComCtl.Set_ComboList(vDt, cmb_shipType, 1, 2, true, 80, 140);
			cmb_shipType.SelectedIndex = 0;
			vDt.Dispose();

			//	cmb_status
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBP01");
			COM.ComCtl.Set_ComboList(vDt, cmb_status, 1, 2, true, 80, 140);
			cmb_status.SelectedIndex = 0;
			vDt.Dispose();

			// cmb_purUser
			vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory,"");
			ClassLib.ComCtl.Set_ComboList(vDt,cmb_purUser, 1, 2, true, 130, 90);
			cmb_purUser.SelectedIndex = 0;

			fgrid_main.Set_Action_Image(img_Action);

			for (int vCol = 1 ; vCol < fgrid_main.Cols.Count ; vCol++)
			{
				if (fgrid_main.Cols[vCol].AllowEditing)
				{
					if (fgrid_main.Cols[vCol].DataMap != null)
					{
						_cellCombo.Add(vCol, fgrid_main.GetDataSourceWithCode(vCol));
					}
				}
			}

			_firstLoad         = false;

			tbtn_Delete.Enabled = false;
			tbtn_Confirm.Enabled = false;
			tbtn_Create.Enabled = false;
		}

		private void Txt_StyleCdKeyUpProcess()
		{
			DataTable vDt = null;

			try
			{
				vDt = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_styleCode, " "));

				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				COM.ComCtl.Set_ComboList(vDt,cmb_style, 0, 1, true, 80, 140); 

				if (txt_styleCode.Text.Length == 9)
				{
					string vStyle = txt_styleCode.Text.Substring(0, 5) + txt_styleCode.Text.Substring(6);
					cmb_style.SelectedValue = vStyle;
				}
			}
			catch //(Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs_StyleCode", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (vDt != null) vDt.Dispose();
			}
		}

		private void Cmb_MRPShipNoSetting()
		{
			DataTable vDt = null;

			try
			{
				vDt = SELECT_SBP_REQ_NO_LIST();
				COM.ComCtl.Set_ComboList(vDt, cmb_shipNo, 0, 0, true, false, true);
				cmb_shipNo.SelectedIndex = 0;
			}
			catch //(Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs_StyleCode", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (vDt != null) vDt.Dispose();
			}
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

			if (fgrid_main.Rows.Fixed >= fgrid_main.Rows.Count && (arg_type == 20 || arg_type == ClassLib.ComVar.Validate_Save))
			{
				ClassLib.ComFunction.User_Message("Select Factory", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			// 부분별 체크 (Search, Save, Delete, Confirm, 10 : Request, 20 : Purchase)
			switch (arg_type)
			{
				case ClassLib.ComVar.Validate_Search:
					break;
				case ClassLib.ComVar.Validate_Save:
					break;
				case ClassLib.ComVar.Validate_Delete:
					break;
				case ClassLib.ComVar.Validate_Confirm:
					break;
				case validate_request:	// Request 버튼
					if (COM.ComFunction.Empty_Combo(cmb_factory, "").Trim().Equals(""))
					{
						ClassLib.ComFunction.User_Message("Select Ship Type", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					break;
				case validate_purchase:	// Purchase 버튼
					int vTemp = 0;

					// Level, Pur_User, Status
					int[] vSel = fgrid_main.Selections;

					//for(int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
					foreach (int vRow in vSel)
					{
						if (fgrid_main.Rows[vRow].Node.Level > 2)
						{
							string vErrMsg = "";
							int vCol = 0;

							if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _purUserCol]).Trim().Equals(""))
							{
								vErrMsg = "Exist Empty Data : Purchase User";
								vCol = _purUserCol;
							}
							
							if (!ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _statusCol]).StartsWith("R"))
							{
								vErrMsg = "The selected item status is not Request";
								vCol = _statusCol;
							}

							if (vErrMsg.Length > 0)
							{
								ClassLib.ComFunction.User_Message(vErrMsg, "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_main.Select(vRow, vCol);
								return false;
							}
							
							vTemp++;
						}
					}
					if ( vTemp == 0 )
					{
						ClassLib.ComFunction.User_Message("Selected data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}

					break;
				case 30:	// 마우스 오른쪽 버튼
					int vCurRow = fgrid_main.Row;
					int vCurCol = fgrid_main.Col;

					if (fgrid_main.Rows.Fixed >= fgrid_main.Rows.Count)
					{
						mnu_AllSelect.Enabled	= false;
						mnu_treeview.Enabled	= false;
						mnu_Data.Enabled		= false;
						mnu_Cbd.Enabled			= false;
					}
					else if (!fgrid_main.Cols[vCurCol].AllowEditing || !fgrid_main.Rows[vCurRow].AllowEditing)
					{
						mnu_AllSelect.Enabled	= true;
						mnu_treeview.Enabled	= true;
						mnu_Data.Enabled		= false;
						mnu_Cbd.Enabled			= true;
					}
					else
					{
						mnu_AllSelect.Enabled	= true;
						mnu_treeview.Enabled	= true;
						mnu_Data.Enabled		= true;
						mnu_Cbd.Enabled			= true;
					}

					break;
			}

			return true;
		}

		#region 툴바 메뉴 이벤트 처리

		private void Tbtn_NewProcess()
		{
			try
			{
				ClearNotPk();
				fgrid_main.ClearAll();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				DataTable vDt = SELECT_SBP_PURCHASE_LIST();

				if (vDt.Rows.Count > 0)
				{
					fgrid_main.ClearAll();
					fgrid_main.Tree.Show(mnu_header.Checked ? 1 : 2);
					fgrid_main.Tree.Column = 4;
					ClassLib.ComFunction.Display_FlexGrid_Tree(fgrid_main, vDt, 0);
					Grid_SetColor();

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else
				{
					Tbtn_NewProcess();
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

		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_SBP_PURCHASE_MANAGER(true))
				{
					fgrid_main.Refresh_Division();
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

		#endregion

		#region 그리드 이벤트 처리

		private void Grid_AfterEditProcess()
		{
			fgrid_main.Update_Row();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}

		

		#endregion

		#endregion
	
		#region DB Connect
 		
		/// <summary>
		/// PKG_SBP_PURCHASE_MANAGER : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_PURCHASE_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(12);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_PURCHASE_MANAGER.SELECT_SBP_PURCHASE_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_DATE_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_DATE_TO";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[4] = "ARG_STATUS";
			MyOraDB.Parameter_Name[5] = "ARG_MANAGER_SEQ";
			MyOraDB.Parameter_Name[6] = "ARG_REQ_REASON";
			MyOraDB.Parameter_Name[7] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[8] = "ARG_MRP_SHIP_NO";
			MyOraDB.Parameter_Name[9] = "ARG_STYLE_ITEM_DIV";
			MyOraDB.Parameter_Name[10] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[11] = "OUT_CURSOR";

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
			MyOraDB.Parameter_Type[11] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = this.dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[2] = this.dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_status, "");
			MyOraDB.Parameter_Values[5] = this.txt_managerSeq.Text;
			MyOraDB.Parameter_Values[6] = COM.ComFunction.Empty_Combo(cmb_reqReason, "");
			MyOraDB.Parameter_Values[7] = COM.ComFunction.Empty_Combo(cmb_style, "").Replace("-", "");
			MyOraDB.Parameter_Values[8] = COM.ComFunction.Empty_Combo(cmb_shipNo, "");
			MyOraDB.Parameter_Values[9] = COM.ComFunction.Empty_Combo(cmb_ubDivision, "");
			MyOraDB.Parameter_Values[10] = COM.ComFunction.Empty_Combo(cmb_obsType, "");
			MyOraDB.Parameter_Values[11] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBP_PURCHASE_MANAGER : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_REQ_NO_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_PURCHASE_MANAGER.SELECT_SBP_REQ_NO_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_DATE_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_DATE_TO";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[2] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBP_PURCHASE_MANAGER : 그리드 저장 ( 3번째 헤더가 S로 지정된 것만 저장 )
		/// </summary>
		public bool SAVE_SBP_PURCHASE_MANAGER(bool doExecute)
		{
			try
			{
				int vArrayLength = 0;

				for (int vCol = 1 ; vCol < fgrid_main.Cols.Count ; vCol++)
				{
					if (fgrid_main[3, vCol].ToString().Equals("S"))
						vArrayLength++;
				}

				MyOraDB.ReDim_Parameter(vArrayLength + 5);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_PURCHASE_MANAGER.SAVE_SBP_PURCHASE_MANAGER";

				//02.ARGURMENT 명
				int vTempIndex = 0;

				MyOraDB.Parameter_Name[vTempIndex] = "ARG_DIVISION";
				MyOraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				vTempIndex++;
				MyOraDB.Parameter_Name[vTempIndex] = "ARG_FACTORY";
				MyOraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				vTempIndex++;

				for (int i = 1 ; i < fgrid_main.Cols.Count ; i++)
				{
					if (fgrid_main[3, i].ToString().Equals("S"))
					{
						MyOraDB.Parameter_Name[vTempIndex] = "ARG_" + fgrid_main[0, i].ToString();
						MyOraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
						vTempIndex++;
					}
				}

				MyOraDB.Parameter_Name[vTempIndex] = "ARG_REQ_YMD";
				MyOraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				
				MyOraDB.Parameter_Name[vTempIndex+1] = "ARG_TRANSPORT_TYPE";
				MyOraDB.Parameter_Type[vTempIndex+1] = (int)OracleType.VarChar;

				MyOraDB.Parameter_Name[vTempIndex+2] = "ARG_UPD_USER";
				MyOraDB.Parameter_Type[vTempIndex+2] = (int)OracleType.VarChar;

				ArrayList vValues = new ArrayList();
				string vFactory = cmb_factory.SelectedValue.ToString();
				string vUpdUser = COM.ComVar.This_User;

				for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
				{
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 0]).Equals(""))
					{
						//vTempIndex = 0;

						vValues.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 0]));
						vValues.Add(vFactory);
						//vTempIndex++;

						for (int vCol = 1 ; vCol < fgrid_main.Cols.Count ; vCol++)
						{
							if (fgrid_main[3, vCol].ToString().Equals("S"))
							{
								vValues.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, vCol]));
								//vTempIndex++;
							}
						}

						vValues.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxREQ_YMD]).Replace("-",""));
						vValues.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBP_PURCHASE_MANAGER_3.IxTRANSPORT_TYPE]));
 						
						vValues.Add(vUpdUser);
						//vTempIndex++;
					}
				}

				MyOraDB.Parameter_Values = (string[])vValues.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(true);

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

		/// <summary>
		/// PKG_SBP_PURCHASE_MANAGER : Purchase
		/// </summary>
		public bool RUN_SBP_PURCHASE_ORDER()
		{
			try
			{
				MyOraDB.ReDim_Parameter(2);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_PURCHASE_MANAGER.RUN_SBP_PURCHASE_ORDER";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(false);

				return true;
			}
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// PKG_SBP_PURCHASE_MANAGER : 
		/// </summary>
		public bool RUN_SBP_MANAGER_PROCESS()
		{
			try
			{
				MyOraDB.ReDim_Parameter(3);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_PURCHASE_MANAGER.RUN_SBP_MANAGER_PROCESS";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_THIS_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
				MyOraDB.Parameter_Values[1] = cmb_factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[2] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);
				if (MyOraDB.Exe_Modify_Procedure() == null)
					return false;
				else
					return true;
			}
			catch 
			{
				return false;
			}
		}

		#endregion																								

		#region 버튼이벤트

		private void btn_Shipping_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				ShippingCreate();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "RunProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		
		private string _ShipYmd = "";
		private Pop_BP_Purchase_Wait _pop;

		private void ShippingCreate()
		{
			C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory};   
			bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null); 
			if(! essential_check) return; 

			if (MessageBox.Show(this, "Do you want to run Shipping Process?", "Run", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{	
				COM.ComVar.Parameter_PopUp = new string[]{"DateTimeCellType", dpick_to.Text};
				Pop_BP_Purchase_List_Changer pop_changer = new Pop_BP_Purchase_List_Changer();
				pop_changer.ShowDialog();

				if (COM.ComVar.Parameter_PopUp == null) return; 

				_ShipYmd = MyComFunction.ConvertDate2DbType(COM.ComVar.Parameter_PopUp[0]); 

				System.Threading.Thread thread_run = new System.Threading.Thread(new System.Threading.ThreadStart(Run));
				thread_run.Start();

				_pop = new Pop_BP_Purchase_Wait();
				_pop.Processing();
				_pop.Start();
			}
		}

		private void Run()
		{
			bool save_flag = false;

			try
			{	
				this.Cursor = Cursors.WaitCursor;  
				
				// 실행
				save_flag = RUN_SHIPPING();

				if(! save_flag)
				{
					throw new Exception("Shipping Create failed!!");
				}
				else
				{
					ClassLib.ComFunction.User_Message("Run process Complete!!", "Processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Run Process", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			finally
			{
				_pop.Close();
				this.Cursor = Cursors.Default;  
				System.Windows.Forms.Application.DoEvents();
			}		
		}

		/// <summary>
		/// RUN_SHIPPING : 소요량 계산
		/// </summary>
		/// <returns></returns>
		private bool RUN_SHIPPING()
		{
			try
			{
				MyOraDB.ReDim_Parameter(5);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_PURCHASE_MANAGER.RUN_SHIPPING_CREATE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_REQ_YMD";
				MyOraDB.Parameter_Name[3] = "ARG_TRANSPORT_TYPE";
				MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
				MyOraDB.Parameter_Values[2] = _ShipYmd;  
				MyOraDB.Parameter_Values[3] = "10";  
				MyOraDB.Parameter_Values[4] = COM.ComVar.This_User;

				//MyOraDB.Add_Modify_Parameter(false);
				//return true;

				MyOraDB.Add_Modify_Parameter(true);
				if (MyOraDB.Exe_Modify_Procedure() == null)
					return false;
				else
					return true;

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "RUN_LOCAL_USAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			} 
		}


		private void btn_req_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(validate_request))
			{
				if(MessageBox.Show(this, "Do you want to get data?","Get", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )
					RunProcessNew(validate_request);
			}
		}

		private void btn_pur_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(validate_purchase))
			{
				if(MessageBox.Show(this, "Do you want to Purchase data?","Purchase", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )
					RunProcessNew(validate_purchase);
			}
		}

		private void Btn_RequestProcess()
		{
			if (RUN_SBP_MANAGER_PROCESS())
			{
				//_popWait.Close();
			}
		}

		private void Btn_PurchaseProcess()
		{
			try
			{
				int[] vSel = fgrid_main.Selections;

				foreach (int vRow in vSel)
				{
					if (fgrid_main.Rows[vRow].Node.Level > 2)
					{
						fgrid_main[vRow, _statusCol] = "TRANSMIT";
						fgrid_main.Update_Row(vRow);
					}
				}

				if (this.SAVE_SBP_PURCHASE_MANAGER(false))
				{
					if (RUN_SBP_PURCHASE_ORDER())
					{
						if (MyOraDB.Exe_Modify_Procedure() != null)
						{
							foreach (int vRow in vSel)
							{
								fgrid_main[vRow, _statusCol] = "PURCHASE";
							}

							MessageBox.Show("Purchase Complete","Purchase", MessageBoxButtons.OK ,MessageBoxIcon.Information);
							fgrid_main.Refresh_Division();
							Grid_SetColor();
							return;
						}
					}
				}

				foreach (int vRow in vSel)
				{
					fgrid_main[vRow, _statusCol] = "REQUEST";					
				}
			
				fgrid_main.Refresh_Division();
			}
			catch
			{
			}
			finally
			{
				//_popWait.Close();
			}
		}

		private void RunProcess(int process)
		{
			Thread temp_thread = null;

			switch (process)
			{
				case validate_request:
					temp_thread = new Thread(new ThreadStart(Btn_RequestProcess));
                    break;
				case validate_purchase:
					temp_thread = new Thread(new ThreadStart(Btn_PurchaseProcess));
					break;
			}

			if (temp_thread != null)
			{
				temp_thread.Start();
				_popWait = new Pop_BP_Purchase_Wait();
				if (process == validate_request)
					_popWait.Closed += new EventHandler(pop_Closed);
				_popWait.Processing();
				_popWait.Start();
			}
		}

        private void RunProcessNew(int process)
        {
            Thread temp_thread = null;

            try
            {
                _popWait = new Pop_BP_Purchase_Wait();
                temp_thread = new Thread(_popWait.Start);
                temp_thread.Start();

                switch (process)
                {
                    case validate_request:
                        Btn_RequestProcess();
                        pop_Closed(null, null);
                        break;
                    case validate_purchase:
                        Btn_PurchaseProcess();
                        break;
                }                
            }
            catch {}
            finally
            {
                try
                {
                    temp_thread.Abort();
                }
                catch {}
            }
        }

		#endregion

		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
		
		}



	}
}

