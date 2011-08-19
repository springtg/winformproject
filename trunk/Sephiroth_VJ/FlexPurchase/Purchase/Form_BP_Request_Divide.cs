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

namespace FlexPurchase.Purchase
{
	public class Form_BP_Request_Divide : COM.PCHWinForm.Form_Top
	{
		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_main;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_reqYmd;
		private System.Windows.Forms.Label lbl_reqNo;
		private System.Windows.Forms.Label lbl_reqUser;
		private System.Windows.Forms.Label lbl_reqDept;
		private System.Windows.Forms.Label lbl_reqReason;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private C1.Win.C1List.C1Combo cmb_reqDept;
		private C1.Win.C1List.C1Combo cmb_reqNo;
		private C1.Win.C1List.C1Combo cmb_reqReason;
		private C1.Win.C1List.C1Combo cmb_reqUser;
		private System.Windows.Forms.Label lbl_transport;
		private System.Windows.Forms.Label lbl_useJobYn;
		private System.Windows.Forms.Label lbl_divide;
		private System.Windows.Forms.TextBox txt_styleCode;
		private C1.Win.C1List.C1Combo cmb_style;
		private System.Windows.Forms.Label lbl_style;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private System.Windows.Forms.TextBox txt_itemCode;
		private System.Windows.Forms.Label lbl_item;
		private C1.Win.C1List.C1Combo cmb_Transport;
		private C1.Win.C1List.C1Combo cmb_UseYN;
		private C1.Win.C1List.C1Combo cmb_UseDivision;
		private System.Windows.Forms.TextBox txt_itemName;
		private System.Windows.Forms.ContextMenu ctx_tail;
		private System.Windows.Forms.MenuItem mnu_AllSelect;
		private System.Windows.Forms.MenuItem mnu_Data;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.Label label1;
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
		private System.EventHandler   _cmbReqNoEventHandler   = null;
		private bool _practicable = true;
		private bool _firstLoad    = true;
		private const int _mnuUseDevide = 10, _contextMenu = 20, _valueTransport = 30;
		private const string _divide_mrp = "M", _divide_local = "L", _divide_notUsing = "N";
		private int _factoryCol     = (int)ClassLib.TBSBP_REQUEST_TAIL_2.IxFACTORY;
		private int _reqNoCol		= (int)ClassLib.TBSBP_REQUEST_TAIL_2.IxREQ_NO;
		private int _reqSeqCol      = (int)ClassLib.TBSBP_REQUEST_TAIL_2.IxREQ_SEQ;
		private int _styleCdCol		= (int)ClassLib.TBSBP_REQUEST_TAIL_2.IxSTYLE_CD;
		private int _modelNameCol	= (int)ClassLib.TBSBP_REQUEST_TAIL_2.IxMODEL_NAME;
		private int _reqQtyCol	    = (int)ClassLib.TBSBP_REQUEST_TAIL_2.IxREQ_QTY;
		private int _transportCol	= (int)ClassLib.TBSBP_REQUEST_TAIL_2.IxTRANSPORT_TYPE;
		private int _useDivideCol	= (int)ClassLib.TBSBP_REQUEST_TAIL_2.IxUSE_DIVIDE;
		private int _useJobYnCol	= (int)ClassLib.TBSBP_REQUEST_TAIL_2.IxUSE_JOB_YN;
		private int _reqReasonCol	= (int)ClassLib.TBSBP_REQUEST_TAIL_2.IxREQ_REASON;
		private string _itemGroupCode	= "";
		
		#endregion

		#region 생성자 / 소멸자

		public Form_BP_Request_Divide()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BP_Request_Divide));
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
            C1.Win.C1List.Style style73 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style74 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style75 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style76 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style77 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style78 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style79 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style80 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_head = new System.Windows.Forms.Panel();
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
            this.cmb_Transport = new C1.Win.C1List.C1Combo();
            this.lbl_transport = new System.Windows.Forms.Label();
            this.cmb_UseYN = new C1.Win.C1List.C1Combo();
            this.lbl_useJobYn = new System.Windows.Forms.Label();
            this.cmb_UseDivision = new C1.Win.C1List.C1Combo();
            this.lbl_divide = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.cmb_reqNo = new C1.Win.C1List.C1Combo();
            this.lbl_reqNo = new System.Windows.Forms.Label();
            this.cmb_reqReason = new C1.Win.C1List.C1Combo();
            this.cmb_reqDept = new C1.Win.C1List.C1Combo();
            this.cmb_reqUser = new C1.Win.C1List.C1Combo();
            this.lbl_reqReason = new System.Windows.Forms.Label();
            this.lbl_reqDept = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_reqUser = new System.Windows.Forms.Label();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.lbl_reqYmd = new System.Windows.Forms.Label();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
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
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Transport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_UseYN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_UseDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
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
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.pnl_main);
            this.c1Sizer1.GridDefinition = "23.4375:False:True;75.8680555555556:False:False;\t0.393700787401575:False:True;98." +
                "4251968503937:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.txt_itemName);
            this.pnl_head.Controls.Add(this.txt_itemCode);
            this.pnl_head.Controls.Add(this.lbl_item);
            this.pnl_head.Controls.Add(this.txt_itemGroup);
            this.pnl_head.Controls.Add(this.cmb_itemGroup);
            this.pnl_head.Controls.Add(this.btn_groupSearch);
            this.pnl_head.Controls.Add(this.label3);
            this.pnl_head.Controls.Add(this.txt_styleCode);
            this.pnl_head.Controls.Add(this.cmb_style);
            this.pnl_head.Controls.Add(this.lbl_style);
            this.pnl_head.Controls.Add(this.cmb_Transport);
            this.pnl_head.Controls.Add(this.lbl_transport);
            this.pnl_head.Controls.Add(this.cmb_UseYN);
            this.pnl_head.Controls.Add(this.lbl_useJobYn);
            this.pnl_head.Controls.Add(this.cmb_UseDivision);
            this.pnl_head.Controls.Add(this.lbl_divide);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.dpick_to);
            this.pnl_head.Controls.Add(this.cmb_reqNo);
            this.pnl_head.Controls.Add(this.lbl_reqNo);
            this.pnl_head.Controls.Add(this.cmb_reqReason);
            this.pnl_head.Controls.Add(this.cmb_reqDept);
            this.pnl_head.Controls.Add(this.cmb_reqUser);
            this.pnl_head.Controls.Add(this.lbl_reqReason);
            this.pnl_head.Controls.Add(this.lbl_reqDept);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_reqUser);
            this.pnl_head.Controls.Add(this.dpick_from);
            this.pnl_head.Controls.Add(this.lbl_reqYmd);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 135);
            this.pnl_head.TabIndex = 0;
            // 
            // txt_itemName
            // 
            this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemName.Location = new System.Drawing.Point(827, 106);
            this.txt_itemName.MaxLength = 10;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(149, 21);
            this.txt_itemName.TabIndex = 409;
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCode.Location = new System.Drawing.Point(767, 106);
            this.txt_itemCode.MaxLength = 10;
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(59, 21);
            this.txt_itemCode.TabIndex = 398;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(666, 106);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 400;
            this.lbl_item.Text = "Item";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.Location = new System.Drawing.Point(554, 106);
            this.txt_itemGroup.MaxLength = 10;
            this.txt_itemGroup.Name = "txt_itemGroup";
            this.txt_itemGroup.ReadOnly = true;
            this.txt_itemGroup.Size = new System.Drawing.Size(73, 21);
            this.txt_itemGroup.TabIndex = 408;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemCols = 0;
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
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
            this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style3;
            this.cmb_itemGroup.GapHeight = 2;
            this.cmb_itemGroup.HeadingStyle = style4;
            this.cmb_itemGroup.HighLightRowStyle = style5;
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(438, 106);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style6;
            this.cmb_itemGroup.PartialRightColumn = false;
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style7;
            this.cmb_itemGroup.Size = new System.Drawing.Size(115, 20);
            this.cmb_itemGroup.Style = style8;
            this.cmb_itemGroup.TabIndex = 407;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Enabled = false;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(627, 106);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 406;
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
            this.label3.Location = new System.Drawing.Point(337, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 405;
            this.label3.Text = "Item Group";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_styleCode
            // 
            this.txt_styleCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCode.Location = new System.Drawing.Point(109, 106);
            this.txt_styleCode.MaxLength = 10;
            this.txt_styleCode.Name = "txt_styleCode";
            this.txt_styleCode.Size = new System.Drawing.Size(79, 21);
            this.txt_styleCode.TabIndex = 398;
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
            this.cmb_style.CaptionStyle = style9;
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
            this.cmb_style.EvenRowStyle = style10;
            this.cmb_style.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style.FooterStyle = style11;
            this.cmb_style.GapHeight = 2;
            this.cmb_style.HeadingStyle = style12;
            this.cmb_style.HighLightRowStyle = style13;
            this.cmb_style.ItemHeight = 15;
            this.cmb_style.Location = new System.Drawing.Point(189, 106);
            this.cmb_style.MatchEntryTimeout = ((long)(2000));
            this.cmb_style.MaxDropDownItems = ((short)(5));
            this.cmb_style.MaxLength = 32767;
            this.cmb_style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_style.Name = "cmb_style";
            this.cmb_style.OddRowStyle = style14;
            this.cmb_style.PartialRightColumn = false;
            this.cmb_style.PropBag = resources.GetString("cmb_style.PropBag");
            this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_style.SelectedStyle = style15;
            this.cmb_style.Size = new System.Drawing.Size(130, 20);
            this.cmb_style.Style = style16;
            this.cmb_style.TabIndex = 399;
            this.cmb_style.SelectedValueChanged += new System.EventHandler(this.cmb_style_SelectedValueChanged);
            // 
            // lbl_style
            // 
            this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_style.ImageIndex = 0;
            this.lbl_style.ImageList = this.img_Label;
            this.lbl_style.Location = new System.Drawing.Point(8, 106);
            this.lbl_style.Name = "lbl_style";
            this.lbl_style.Size = new System.Drawing.Size(100, 21);
            this.lbl_style.TabIndex = 400;
            this.lbl_style.Text = "Style";
            this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Transport
            // 
            this.cmb_Transport.AddItemCols = 0;
            this.cmb_Transport.AddItemSeparator = ';';
            this.cmb_Transport.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Transport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Transport.Caption = "";
            this.cmb_Transport.CaptionHeight = 17;
            this.cmb_Transport.CaptionStyle = style17;
            this.cmb_Transport.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Transport.ColumnCaptionHeight = 18;
            this.cmb_Transport.ColumnFooterHeight = 18;
            this.cmb_Transport.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Transport.ContentHeight = 16;
            this.cmb_Transport.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Transport.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Transport.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Transport.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Transport.EditorHeight = 16;
            this.cmb_Transport.EvenRowStyle = style18;
            this.cmb_Transport.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Transport.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Transport.FooterStyle = style19;
            this.cmb_Transport.GapHeight = 2;
            this.cmb_Transport.HeadingStyle = style20;
            this.cmb_Transport.HighLightRowStyle = style21;
            this.cmb_Transport.ItemHeight = 15;
            this.cmb_Transport.Location = new System.Drawing.Point(438, 84);
            this.cmb_Transport.MatchEntryTimeout = ((long)(2000));
            this.cmb_Transport.MaxDropDownItems = ((short)(5));
            this.cmb_Transport.MaxLength = 32767;
            this.cmb_Transport.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Transport.Name = "cmb_Transport";
            this.cmb_Transport.OddRowStyle = style22;
            this.cmb_Transport.PartialRightColumn = false;
            this.cmb_Transport.PropBag = resources.GetString("cmb_Transport.PropBag");
            this.cmb_Transport.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Transport.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Transport.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Transport.SelectedStyle = style23;
            this.cmb_Transport.Size = new System.Drawing.Size(210, 20);
            this.cmb_Transport.Style = style24;
            this.cmb_Transport.TabIndex = 366;
            // 
            // lbl_transport
            // 
            this.lbl_transport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_transport.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transport.ImageIndex = 0;
            this.lbl_transport.ImageList = this.img_Label;
            this.lbl_transport.Location = new System.Drawing.Point(337, 84);
            this.lbl_transport.Name = "lbl_transport";
            this.lbl_transport.Size = new System.Drawing.Size(100, 21);
            this.lbl_transport.TabIndex = 355;
            this.lbl_transport.Text = "Transport";
            this.lbl_transport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_UseYN
            // 
            this.cmb_UseYN.AddItemCols = 0;
            this.cmb_UseYN.AddItemSeparator = ';';
            this.cmb_UseYN.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_UseYN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_UseYN.Caption = "";
            this.cmb_UseYN.CaptionHeight = 17;
            this.cmb_UseYN.CaptionStyle = style25;
            this.cmb_UseYN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_UseYN.ColumnCaptionHeight = 18;
            this.cmb_UseYN.ColumnFooterHeight = 18;
            this.cmb_UseYN.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_UseYN.ContentHeight = 16;
            this.cmb_UseYN.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_UseYN.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_UseYN.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_UseYN.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_UseYN.EditorHeight = 16;
            this.cmb_UseYN.EvenRowStyle = style26;
            this.cmb_UseYN.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_UseYN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UseYN.FooterStyle = style27;
            this.cmb_UseYN.GapHeight = 2;
            this.cmb_UseYN.HeadingStyle = style28;
            this.cmb_UseYN.HighLightRowStyle = style29;
            this.cmb_UseYN.ItemHeight = 15;
            this.cmb_UseYN.Location = new System.Drawing.Point(767, 84);
            this.cmb_UseYN.MatchEntryTimeout = ((long)(2000));
            this.cmb_UseYN.MaxDropDownItems = ((short)(5));
            this.cmb_UseYN.MaxLength = 32767;
            this.cmb_UseYN.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_UseYN.Name = "cmb_UseYN";
            this.cmb_UseYN.OddRowStyle = style30;
            this.cmb_UseYN.PartialRightColumn = false;
            this.cmb_UseYN.PropBag = resources.GetString("cmb_UseYN.PropBag");
            this.cmb_UseYN.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_UseYN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_UseYN.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_UseYN.SelectedStyle = style31;
            this.cmb_UseYN.Size = new System.Drawing.Size(210, 20);
            this.cmb_UseYN.Style = style32;
            this.cmb_UseYN.TabIndex = 366;
            // 
            // lbl_useJobYn
            // 
            this.lbl_useJobYn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_useJobYn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_useJobYn.ImageIndex = 0;
            this.lbl_useJobYn.ImageList = this.img_Label;
            this.lbl_useJobYn.Location = new System.Drawing.Point(666, 84);
            this.lbl_useJobYn.Name = "lbl_useJobYn";
            this.lbl_useJobYn.Size = new System.Drawing.Size(100, 21);
            this.lbl_useJobYn.TabIndex = 355;
            this.lbl_useJobYn.Text = "Use";
            this.lbl_useJobYn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_UseDivision
            // 
            this.cmb_UseDivision.AddItemCols = 0;
            this.cmb_UseDivision.AddItemSeparator = ';';
            this.cmb_UseDivision.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_UseDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_UseDivision.Caption = "";
            this.cmb_UseDivision.CaptionHeight = 17;
            this.cmb_UseDivision.CaptionStyle = style33;
            this.cmb_UseDivision.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_UseDivision.ColumnCaptionHeight = 18;
            this.cmb_UseDivision.ColumnFooterHeight = 18;
            this.cmb_UseDivision.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_UseDivision.ContentHeight = 16;
            this.cmb_UseDivision.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_UseDivision.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_UseDivision.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_UseDivision.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_UseDivision.EditorHeight = 16;
            this.cmb_UseDivision.EvenRowStyle = style34;
            this.cmb_UseDivision.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_UseDivision.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UseDivision.FooterStyle = style35;
            this.cmb_UseDivision.GapHeight = 2;
            this.cmb_UseDivision.HeadingStyle = style36;
            this.cmb_UseDivision.HighLightRowStyle = style37;
            this.cmb_UseDivision.ItemHeight = 15;
            this.cmb_UseDivision.Location = new System.Drawing.Point(109, 84);
            this.cmb_UseDivision.MatchEntryTimeout = ((long)(2000));
            this.cmb_UseDivision.MaxDropDownItems = ((short)(5));
            this.cmb_UseDivision.MaxLength = 32767;
            this.cmb_UseDivision.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_UseDivision.Name = "cmb_UseDivision";
            this.cmb_UseDivision.OddRowStyle = style38;
            this.cmb_UseDivision.PartialRightColumn = false;
            this.cmb_UseDivision.PropBag = resources.GetString("cmb_UseDivision.PropBag");
            this.cmb_UseDivision.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_UseDivision.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_UseDivision.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_UseDivision.SelectedStyle = style39;
            this.cmb_UseDivision.Size = new System.Drawing.Size(210, 20);
            this.cmb_UseDivision.Style = style40;
            this.cmb_UseDivision.TabIndex = 366;
            // 
            // lbl_divide
            // 
            this.lbl_divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_divide.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_divide.ImageIndex = 0;
            this.lbl_divide.ImageList = this.img_Label;
            this.lbl_divide.Location = new System.Drawing.Point(8, 84);
            this.lbl_divide.Name = "lbl_divide";
            this.lbl_divide.Size = new System.Drawing.Size(100, 21);
            this.lbl_divide.TabIndex = 355;
            this.lbl_divide.Text = "Divide";
            this.lbl_divide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(206, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 397;
            this.label1.Text = "~";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(225, 62);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dpick_to.Size = new System.Drawing.Size(95, 21);
            this.dpick_to.TabIndex = 373;
            this.dpick_to.CloseUp += new System.EventHandler(this.dpick_to_CloseUp);
            // 
            // cmb_reqNo
            // 
            this.cmb_reqNo.AddItemCols = 0;
            this.cmb_reqNo.AddItemSeparator = ';';
            this.cmb_reqNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_reqNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_reqNo.Caption = "";
            this.cmb_reqNo.CaptionHeight = 17;
            this.cmb_reqNo.CaptionStyle = style41;
            this.cmb_reqNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_reqNo.ColumnCaptionHeight = 18;
            this.cmb_reqNo.ColumnFooterHeight = 18;
            this.cmb_reqNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_reqNo.ContentHeight = 16;
            this.cmb_reqNo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_reqNo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_reqNo.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_reqNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_reqNo.EditorHeight = 16;
            this.cmb_reqNo.EvenRowStyle = style42;
            this.cmb_reqNo.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_reqNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reqNo.FooterStyle = style43;
            this.cmb_reqNo.GapHeight = 2;
            this.cmb_reqNo.HeadingStyle = style44;
            this.cmb_reqNo.HighLightRowStyle = style45;
            this.cmb_reqNo.ItemHeight = 15;
            this.cmb_reqNo.Location = new System.Drawing.Point(438, 40);
            this.cmb_reqNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_reqNo.MaxDropDownItems = ((short)(5));
            this.cmb_reqNo.MaxLength = 32767;
            this.cmb_reqNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_reqNo.Name = "cmb_reqNo";
            this.cmb_reqNo.OddRowStyle = style46;
            this.cmb_reqNo.PartialRightColumn = false;
            this.cmb_reqNo.PropBag = resources.GetString("cmb_reqNo.PropBag");
            this.cmb_reqNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_reqNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_reqNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_reqNo.SelectedStyle = style47;
            this.cmb_reqNo.Size = new System.Drawing.Size(210, 20);
            this.cmb_reqNo.Style = style48;
            this.cmb_reqNo.TabIndex = 5;
            this.cmb_reqNo.SelectedValueChanged += new System.EventHandler(this.cmb_reqNo_SelectedValueChanged);
            // 
            // lbl_reqNo
            // 
            this.lbl_reqNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqNo.ImageIndex = 0;
            this.lbl_reqNo.ImageList = this.img_Label;
            this.lbl_reqNo.Location = new System.Drawing.Point(337, 40);
            this.lbl_reqNo.Name = "lbl_reqNo";
            this.lbl_reqNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqNo.TabIndex = 50;
            this.lbl_reqNo.Text = "Request No";
            this.lbl_reqNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_reqReason
            // 
            this.cmb_reqReason.AddItemCols = 0;
            this.cmb_reqReason.AddItemSeparator = ';';
            this.cmb_reqReason.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_reqReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_reqReason.Caption = "";
            this.cmb_reqReason.CaptionHeight = 17;
            this.cmb_reqReason.CaptionStyle = style49;
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
            this.cmb_reqReason.EvenRowStyle = style50;
            this.cmb_reqReason.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_reqReason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reqReason.FooterStyle = style51;
            this.cmb_reqReason.GapHeight = 2;
            this.cmb_reqReason.HeadingStyle = style52;
            this.cmb_reqReason.HighLightRowStyle = style53;
            this.cmb_reqReason.ItemHeight = 15;
            this.cmb_reqReason.Location = new System.Drawing.Point(767, 40);
            this.cmb_reqReason.MatchEntryTimeout = ((long)(2000));
            this.cmb_reqReason.MaxDropDownItems = ((short)(5));
            this.cmb_reqReason.MaxLength = 32767;
            this.cmb_reqReason.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_reqReason.Name = "cmb_reqReason";
            this.cmb_reqReason.OddRowStyle = style54;
            this.cmb_reqReason.PartialRightColumn = false;
            this.cmb_reqReason.PropBag = resources.GetString("cmb_reqReason.PropBag");
            this.cmb_reqReason.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_reqReason.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_reqReason.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_reqReason.SelectedStyle = style55;
            this.cmb_reqReason.Size = new System.Drawing.Size(210, 20);
            this.cmb_reqReason.Style = style56;
            this.cmb_reqReason.TabIndex = 372;
            // 
            // cmb_reqDept
            // 
            this.cmb_reqDept.AddItemCols = 0;
            this.cmb_reqDept.AddItemSeparator = ';';
            this.cmb_reqDept.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_reqDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_reqDept.Caption = "";
            this.cmb_reqDept.CaptionHeight = 17;
            this.cmb_reqDept.CaptionStyle = style57;
            this.cmb_reqDept.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_reqDept.ColumnCaptionHeight = 18;
            this.cmb_reqDept.ColumnFooterHeight = 18;
            this.cmb_reqDept.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_reqDept.ContentHeight = 16;
            this.cmb_reqDept.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_reqDept.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_reqDept.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_reqDept.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_reqDept.EditorHeight = 16;
            this.cmb_reqDept.EvenRowStyle = style58;
            this.cmb_reqDept.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_reqDept.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reqDept.FooterStyle = style59;
            this.cmb_reqDept.GapHeight = 2;
            this.cmb_reqDept.HeadingStyle = style60;
            this.cmb_reqDept.HighLightRowStyle = style61;
            this.cmb_reqDept.ItemHeight = 15;
            this.cmb_reqDept.Location = new System.Drawing.Point(438, 62);
            this.cmb_reqDept.MatchEntryTimeout = ((long)(2000));
            this.cmb_reqDept.MaxDropDownItems = ((short)(5));
            this.cmb_reqDept.MaxLength = 32767;
            this.cmb_reqDept.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_reqDept.Name = "cmb_reqDept";
            this.cmb_reqDept.OddRowStyle = style62;
            this.cmb_reqDept.PartialRightColumn = false;
            this.cmb_reqDept.PropBag = resources.GetString("cmb_reqDept.PropBag");
            this.cmb_reqDept.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_reqDept.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_reqDept.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_reqDept.SelectedStyle = style63;
            this.cmb_reqDept.Size = new System.Drawing.Size(210, 20);
            this.cmb_reqDept.Style = style64;
            this.cmb_reqDept.TabIndex = 366;
            // 
            // cmb_reqUser
            // 
            this.cmb_reqUser.AddItemCols = 0;
            this.cmb_reqUser.AddItemSeparator = ';';
            this.cmb_reqUser.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_reqUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_reqUser.Caption = "";
            this.cmb_reqUser.CaptionHeight = 17;
            this.cmb_reqUser.CaptionStyle = style65;
            this.cmb_reqUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_reqUser.ColumnCaptionHeight = 18;
            this.cmb_reqUser.ColumnFooterHeight = 18;
            this.cmb_reqUser.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_reqUser.ContentHeight = 16;
            this.cmb_reqUser.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_reqUser.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_reqUser.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_reqUser.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_reqUser.EditorHeight = 16;
            this.cmb_reqUser.EvenRowStyle = style66;
            this.cmb_reqUser.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_reqUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reqUser.FooterStyle = style67;
            this.cmb_reqUser.GapHeight = 2;
            this.cmb_reqUser.HeadingStyle = style68;
            this.cmb_reqUser.HighLightRowStyle = style69;
            this.cmb_reqUser.ItemHeight = 15;
            this.cmb_reqUser.Location = new System.Drawing.Point(767, 62);
            this.cmb_reqUser.MatchEntryTimeout = ((long)(2000));
            this.cmb_reqUser.MaxDropDownItems = ((short)(5));
            this.cmb_reqUser.MaxLength = 32767;
            this.cmb_reqUser.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_reqUser.Name = "cmb_reqUser";
            this.cmb_reqUser.OddRowStyle = style70;
            this.cmb_reqUser.PartialRightColumn = false;
            this.cmb_reqUser.PropBag = resources.GetString("cmb_reqUser.PropBag");
            this.cmb_reqUser.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_reqUser.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_reqUser.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_reqUser.SelectedStyle = style71;
            this.cmb_reqUser.Size = new System.Drawing.Size(210, 20);
            this.cmb_reqUser.Style = style72;
            this.cmb_reqUser.TabIndex = 365;
            // 
            // lbl_reqReason
            // 
            this.lbl_reqReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqReason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqReason.ImageIndex = 0;
            this.lbl_reqReason.ImageList = this.img_Label;
            this.lbl_reqReason.Location = new System.Drawing.Point(666, 40);
            this.lbl_reqReason.Name = "lbl_reqReason";
            this.lbl_reqReason.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqReason.TabIndex = 359;
            this.lbl_reqReason.Text = "Request Reason";
            this.lbl_reqReason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_reqDept
            // 
            this.lbl_reqDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqDept.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqDept.ImageIndex = 0;
            this.lbl_reqDept.ImageList = this.img_Label;
            this.lbl_reqDept.Location = new System.Drawing.Point(337, 62);
            this.lbl_reqDept.Name = "lbl_reqDept";
            this.lbl_reqDept.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqDept.TabIndex = 355;
            this.lbl_reqDept.Text = "Request Dept";
            this.lbl_reqDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 119);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // lbl_reqUser
            // 
            this.lbl_reqUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqUser.ImageIndex = 0;
            this.lbl_reqUser.ImageList = this.img_Label;
            this.lbl_reqUser.Location = new System.Drawing.Point(666, 62);
            this.lbl_reqUser.Name = "lbl_reqUser";
            this.lbl_reqUser.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqUser.TabIndex = 50;
            this.lbl_reqUser.Text = "Request User";
            this.lbl_reqUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(109, 62);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dpick_from.Size = new System.Drawing.Size(95, 21);
            this.dpick_from.TabIndex = 2;
            this.dpick_from.CloseUp += new System.EventHandler(this.dpick_from_CloseUp);
            // 
            // lbl_reqYmd
            // 
            this.lbl_reqYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqYmd.ImageIndex = 1;
            this.lbl_reqYmd.ImageList = this.img_Label;
            this.lbl_reqYmd.Location = new System.Drawing.Point(8, 62);
            this.lbl_reqYmd.Name = "lbl_reqYmd";
            this.lbl_reqYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqYmd.TabIndex = 50;
            this.lbl_reqYmd.Text = "Request Date";
            this.lbl_reqYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 118);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(960, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style73;
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
            this.cmb_factory.EvenRowStyle = style74;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style75;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style76;
            this.cmb_factory.HighLightRowStyle = style77;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style78;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style79;
            this.cmb_factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_factory.Style = style80;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
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
            this.pic_head7.Size = new System.Drawing.Size(101, 94);
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
            this.label2.Text = "      Request Info";
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
            this.pic_head5.Location = new System.Drawing.Point(0, 119);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 108);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.White;
            this.pnl_main.Controls.Add(this.spd_main);
            this.pnl_main.Location = new System.Drawing.Point(8, 139);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1000, 437);
            this.pnl_main.TabIndex = 1;
            // 
            // spd_main
            // 
            this.spd_main.BackColor = System.Drawing.Color.Transparent;
            this.spd_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spd_main.Location = new System.Drawing.Point(0, 0);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(1000, 437);
            this.spd_main.TabIndex = 0;
            this.spd_main.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spd_main_KeyDown);
            this.spd_main.EditModeOn += new System.EventHandler(this.spd_main_EditModeOn);
            this.spd_main.EditModeOff += new System.EventHandler(this.spd_main_EditModeOff);
            this.spd_main.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellClick);
            this.spd_main.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_EditChange);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
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
            this.mnu_mrp.Text = "DS";
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
            // Form_BP_Request_Divide
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BP_Request_Divide";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_BP_Request_Closing);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Transport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_UseYN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_UseDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            this.pnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
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
			if (e.Column == _transportCol)
			{
				if (!Etc_ProvisoValidateCheck(_valueTransport))
				{
					_mainSheet.Cells[e.Row, e.Column].Text = spd_main.Buffer_CellData;
					return;
				}
			}

			spd_main.Update_Row(img_Action);
		}

		private void spd_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			if (!e.ColumnHeader && e.Button == MouseButtons.Right)
			{
				if (Etc_ProvisoValidateCheck(_contextMenu))
				{
					ctx_tail.Show(spd_main, new Point(e.X, e.Y));
				}
			}
		}

		private void spd_main_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (_mainSheet.ActiveColumn.Index == _modelNameCol)
			{
				if (_mainSheet.Cells[_mainSheet.ActiveRow.Index, _styleCdCol].Text.Equals("_________") || 
					_mainSheet.Cells[_mainSheet.ActiveRow.Index, _styleCdCol].Text.Equals("NONE") || 
					_mainSheet.Cells[_mainSheet.ActiveRow.Index, _styleCdCol].Text.Equals(""))
					_mainSheet.ActiveCell.Locked = false;
			}
		}

		private void spd_main_EditModeOff(object sender, System.EventArgs e)
		{
			if (_mainSheet.ActiveColumn.Index == _modelNameCol)
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
				if(ClassLib.ComFunction.User_Message("Do you want to save?","Save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )
					this.Tbtn_SaveProcess();
			}
		}


		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Confirm))
			{
				if(ClassLib.ComFunction.User_Message("Do you want to save?","Save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )
					this.Tbtn_ConfirmProcess();
			}
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BP_Request_Confirm") ;
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 21;
			string [] aHead =  new string[iCnt];	
			

			aHead[0]    = cmb_factory.SelectedValue.ToString();
			aHead[1]    = COM.ComFunction.Empty_Combo(cmb_reqNo, "");
			aHead[2]    = dpick_from.Text.Replace("-", "");
			aHead[3]    = dpick_to.Text.Replace("-", "");
			aHead[4]    = COM.ComFunction.Empty_Combo(cmb_reqReason, "");
			aHead[5]    = COM.ComFunction.Empty_Combo(cmb_reqDept, "");
			aHead[6]    = COM.ComFunction.Empty_Combo(cmb_reqUser, "").Replace("ALL", "");
			aHead[7]    = COM.ComFunction.Empty_Combo(cmb_UseDivision, "");
			aHead[8]    = COM.ComFunction.Empty_Combo(cmb_Transport, "");
			aHead[9]    = COM.ComFunction.Empty_Combo(cmb_UseYN, "");		
			aHead[10]   = COM.ComFunction.Empty_Combo(cmb_style, "");
			aHead[11]	=  _itemGroupCode;
			aHead[12]	= COM.ComFunction.Empty_TextBox(txt_itemCode, "");
			aHead[13]	= COM.ComFunction.Empty_TextBox(txt_itemName, "");
			aHead[14]	= cmb_UseDivision.GetItemText(cmb_UseDivision.SelectedIndex, 1);
			aHead[15]	= cmb_reqDept.GetItemText(cmb_reqDept.SelectedIndex, 1);
			aHead[16]	= cmb_Transport.GetItemText(cmb_Transport.SelectedIndex, 1);
			aHead[17]	= cmb_itemGroup.GetItemText(cmb_itemGroup.SelectedIndex, 1);
			aHead[18]	= cmb_reqReason.GetItemText(cmb_reqReason.SelectedIndex, 1);
			aHead[19]	= cmb_reqUser.GetItemText(cmb_reqUser.SelectedIndex, 1);
			aHead[20]	= cmb_UseYN.GetItemText(cmb_UseYN.SelectedIndex, 1);


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

		private void Form_BP_Request_Closing(object sender, System.ComponentModel.CancelEventArgs e)
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

		private void cmb_reqNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if( !_firstLoad )
			{
				// head clear, grid clear
				this.Cmb_ReqNoSelectedValueChangedProcess();
			}
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_ReqNoSettingProcess();
			spd_main.ClearAll();
		}

		private void dpick_from_CloseUp(object sender, System.EventArgs e)
		{
			dpick_to.Value = dpick_from.Value;
			this.Cmb_ReqNoSettingProcess();
			spd_main.ClearAll();
		}

		private void dpick_to_CloseUp(object sender, System.EventArgs e)
		{
			this.Cmb_ReqNoSettingProcess();
			spd_main.ClearAll();
		}

		private void cmb_itemGroup_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if ( cmb_itemGroup.SelectedIndex >= 1 )
			{
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
			this.txt_itemGroup.Text	= COM.ComVar.Parameter_PopUp[4];

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
		#endregion

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{			
			// form initialize
			ClassLib.ComFunction.Init_Form_Control(this);

            lbl_MainTitle.Text = "Confirm Requests";
            this.Text = "Confirm Requests";
            ClassLib.ComFunction.SetLangDic(this);

			// grid set
			spd_main.Set_Spread_Comm("SBP_REQUEST_TAIL", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			
			//입력부 setup
			Init_Combo();
			
			// user define variable set
			_mainSheet				= spd_main.ActiveSheet;
			_cmbReqNoEventHandler   = new System.EventHandler(this.cmb_reqNo_SelectedValueChanged);
			_firstLoad              = false;

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

				// cmb_reqReason
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBM07");
				COM.ComCtl.Set_ComboList(vDt, cmb_reqReason, 1, 2, true);
				cmb_reqReason.SelectedIndex = 0;
				vDt.Dispose();

				// cmb_reqUser
				vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory,"");
				ClassLib.ComCtl.Set_ComboList(vDt,cmb_reqUser, 1, 1, true, 0, 210);
				cmb_reqUser.SelectedIndex = 0;
				vDt.Dispose();

				// req dept set cmb_reqDept
				vDt = ClassLib.ComFunction.SELECT_CM_DEPT(COM.ComFunction.Empty_Combo(cmb_factory, ""), " ");
				COM.ComCtl.Set_ComboList(vDt, cmb_reqDept, 0, 1, true);
				cmb_reqDept.SelectedIndex = 0;
				vDt.Dispose();

				// cmb_divide
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxUseDivision);
				COM.ComCtl.Set_ComboList(vDt, cmb_UseDivision, 1, 2, true);
				cmb_UseDivision.SelectedIndex = 0;
				vDt.Dispose();

				// cmb_transport
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxOutgoingType);
				COM.ComCtl.Set_ComboList(vDt, cmb_Transport, 1, 2, true);
				cmb_Transport.SelectedIndex = 0;
				vDt.Dispose();

				// cmb_use_yn
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxUseYN);
				COM.ComCtl.Set_ComboList(vDt, cmb_UseYN, 1, 2, true);
				cmb_UseYN.SelectedIndex = 0;
				vDt.Dispose();

				// Item Group Combobox Setting
				vDt = FlexPurchase.ClassLib.ComFunction.Select_GroupTypeCode();
				COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, true, 45, 60);
				cmb_itemGroup.SelectedIndex = 0;
				vDt.Dispose();

				tbtn_Delete.Enabled = false;
				tbtn_Create.Enabled = false;
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

					DataTable vDt = this.SELECT_SBP_REQUEST_INFO();

					if (vDt.Rows.Count > 0)
					{
						spd_main.Display_Grid(vDt);
						ClassLib.ComFunction.MergeCell(spd_main, new int[]{_reqNoCol, _reqSeqCol});
						Grid_SetColor();

						spd_main.ActiveSheet.SetActiveCell(0, 1);
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
				switch (_mainSheet.Cells[vRow, _useDivideCol].Value.ToString())
				{
					case _divide_mrp:
						_mainSheet.Cells[vRow, 3, vRow, _mainSheet.ColumnCount - 1].BackColor = ClassLib.ComVar.RightBlue;
						break;
					case _divide_local:
						_mainSheet.Cells[vRow, 3, vRow, _mainSheet.ColumnCount - 1].BackColor = ClassLib.ComVar.RightYellow;
						break;
					case _divide_notUsing:
						_mainSheet.Cells[vRow, 3, vRow, _mainSheet.ColumnCount - 1].BackColor = ClassLib.ComVar.RightPink2;
						break;
					default :
						_mainSheet.Cells[vRow, 3, vRow, _mainSheet.ColumnCount - 1].BackColor = ClassLib.ComVar.Default;
						break;
				}

				if (ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, _useJobYnCol].Value).Substring(0, 1).Equals(ClassLib.ComVar.Yes))
				{
					_mainSheet.Rows[vRow].Locked = true;
					_mainSheet.Cells[vRow, 3, vRow, _mainSheet.ColumnCount - 1].ForeColor = Color.Gray;
				}
				else
				{
					_mainSheet.Rows[vRow].Locked = false;
				}
			}
		}

		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				if (SAVE_SBP_REQUEST_INFO())
				{
					if (MyOraDB.Exe_Modify_Procedure() != null)
					{
						spd_main.Refresh_Division();
						Grid_SetColor();
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
						ClassLib.ComFunction.User_Message("Save Complete", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Tbtn_ConfirmProcess()
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				if (!SAVE_SBP_REQUEST_INFO())
					return;

				if (!RUN_SBP_REQUEST_COMMIT())
					return;

				if (MyOraDB.Exe_Modify_Procedure() != null)
				{
					for (int vRow = 0 ; vRow < _mainSheet.RowCount ; vRow++)
					{
						if (_mainSheet.Cells[vRow, _useDivideCol].Value.ToString().Equals(_divide_mrp.ToString()))
						{
							if (ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, _useJobYnCol].Value).Substring(0, 1).Equals(ClassLib.ComVar.No))
							{
								_mainSheet.Cells[vRow, _useJobYnCol].Value = ClassLib.ComVar.Yes;
							}
						}
					}

					spd_main.Refresh_Division();
					Grid_SetColor();
					ClassLib.ComFunction.User_Message("Confirm Complete", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Cmb_ReqNoSettingProcess()
		{
			try
			{
				if (_practicable)
				{
					cmb_reqNo.SelectedValueChanged -= _cmbReqNoEventHandler;

					DataTable vDt = this.SELECT_SBP_REQUEST_NO_LIST();
					if(vDt.Rows.Count == 0)
					{
						cmb_reqNo.ClearItems();
					}
					COM.ComCtl.Set_ComboList(vDt, cmb_reqNo, 0, 0, true, false);
					cmb_reqNo.SelectedIndex = 0;
					vDt.Dispose();

					cmb_reqNo.SelectedValueChanged += _cmbReqNoEventHandler;
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Cmb_ReqNoSelectedValueChangedProcess()
		{
			try
			{
				if (cmb_reqNo.SelectedIndex < 1)
					Tbtn_SearchProcess(false);
				else
					Tbtn_SearchProcess(true);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private int Mnu_UseDevideProcess(string arg_devide)
		{
			CellRange[] vRanges = _mainSheet.GetSelections();

			foreach (CellRange vRange in vRanges)
			{
				for (int vRow = vRange.Row ; vRow < vRange.Row + vRange.RowCount ; vRow++)
				{
					if (ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, _useDivideCol].Value).Equals(_divide_mrp) && 
						ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, _useJobYnCol].Value).Equals(ClassLib.ComVar.Yes))
						continue;

					if (_mainSheet.Rows[vRow].Locked)
						continue;

					_mainSheet.Cells[vRow, _useDivideCol].Text = arg_devide;
					
					if (!arg_devide.Equals(_divide_mrp))
						_mainSheet.Cells[vRow, _transportCol].Value = "";

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
				COM.ComCtl.Set_ComboList(vDt, cmb_style, 0, 1, true, 80, 130); 
				string vStyle = txt_styleCode.Text.Replace("-", "");
				vStyle = vStyle.Substring(0, 6) + "-" + vStyle.Substring(6, 3);
				cmb_style.SelectedValue = vStyle.Trim();
			}
			catch {}
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

			if (_mainSheet.RowCount <= 0 && (arg_type == ClassLib.ComVar.Validate_Save || arg_type == ClassLib.ComVar.Validate_Confirm || arg_type == _mnuUseDevide || arg_type == _contextMenu))
			{
				ClassLib.ComFunction.User_Message("Not found request data", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (_mainSheet.GetSelections().Length <= 0 && (arg_type == _mnuUseDevide || arg_type == _contextMenu))
			{
				ClassLib.ComFunction.User_Message("Not found selected data", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			// 부분별 체크 (Search, Save, Delete, Confirm..)
			switch (arg_type)
			{
				case ClassLib.ComVar.Validate_Search:

					break;
				case ClassLib.ComVar.Validate_Save:					

					break;
				case ClassLib.ComVar.Validate_Delete:

					break;
				case ClassLib.ComVar.Validate_Confirm:
					for (int vRow = 0 ; vRow < _mainSheet.RowCount ; vRow++)
					{
						if (_mainSheet.Cells[vRow, _useDivideCol].Value.ToString().Equals(_divide_mrp.ToString()))
						{

							if (ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, _useJobYnCol].Value).Substring(0, 1).Equals(ClassLib.ComVar.No))
							{
								return true;
							}
						}

						if (_mainSheet.Cells[vRow, _useDivideCol].Value.ToString().Equals(_divide_local.ToString()))
						{

							if (ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, _useJobYnCol].Value).Substring(0, 1).Equals(ClassLib.ComVar.No))
							{
								return true;
							}
						}

					}

					ClassLib.ComFunction.User_Message("A transmitted data could not be found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return false;
				case _mnuUseDevide:

					break;
				case _contextMenu:
					if (_mainSheet.ActiveRow.Locked || _mainSheet.ActiveColumn.Locked)
					{
						mnu_Data.Enabled = false;
					}
					else
					{
						mnu_Data.Enabled = true;
					}

					break;
				case _valueTransport:
					CellRange[] vRanges = _mainSheet.GetSelections();
					foreach (CellRange vRange in vRanges)
					{
						for (int vRow = vRange.Row ; vRow < vRange.Row + vRange.RowCount ; vRow++)
						{
							if (ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, _useJobYnCol].Value).Substring(0, 1).Equals(ClassLib.ComVar.Yes))
							{
								_mainSheet.SetActiveCell(vRow, _transportCol);
								ClassLib.ComFunction.User_Message("Already Transmitted Data", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								return false;
							}

							if (!_mainSheet.Cells[vRow, _useDivideCol].Value.ToString().Equals(_divide_mrp.ToString()))
							{
								_mainSheet.SetActiveCell(vRow, _useDivideCol);
								ClassLib.ComFunction.User_Message("Included Local Or Not Using Data", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);								
								return false;
							}
						}
					}
					break;
			}

			return true;
		}

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
					if (vCol == _transportCol)
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

					Pop_BP_Purchase_List_Changer pop_changer = new Pop_BP_Purchase_List_Changer();
					pop_changer.ShowDialog();

					if (COM.ComVar.Parameter_PopUp != null)
					{
						if (vCol == _useDivideCol)
						{
							Mnu_UseDevideProcess(COM.ComVar.Parameter_PopUp[0]);
						}
						else
						{
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

		#endregion

		#region DB Connect

		public DataTable SELECT_CM_DEPT()
		{
 
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet ds_ret;
 
			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_CM_DEPT";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_DEPT";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
			
			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = "";
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}
		
		/// <summary>
		/// PKG_SBP_REQUEST_HEAD : 요청 번호 리스트 찾기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_req_ymd_from">요청일(From)</param>
		/// <param name="arg_req_ymd_to">요청일(To)</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_REQUEST_NO_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_REQUEST_DIVIDE.SELECT_SBP_REQUEST_NO_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";	
			MyOraDB.Parameter_Name[1] = "ARG_REQ_YMD_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_REQ_YMD_TO";
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
		/// PKG_SBP_REQUEST_DIVIDE : Request 정보 가져오기 ( MRP )
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_REQUEST_INFO()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(15);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_REQUEST_DIVIDE.SELECT_SBP_REQUEST_INFO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";
			MyOraDB.Parameter_Name[2] = "ARG_REQ_YMD_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_REQ_YMD_TO";
			MyOraDB.Parameter_Name[4] = "ARG_REQ_REASON";
			MyOraDB.Parameter_Name[5] = "ARG_REQ_DEPT";
			MyOraDB.Parameter_Name[6] = "ARG_REQ_USER";
			MyOraDB.Parameter_Name[7] = "ARG_USE_DIVISION";
			MyOraDB.Parameter_Name[8] = "ARG_TRANSPORT_TYPE";
			MyOraDB.Parameter_Name[9] = "ARG_USE_JOB_YN";
			MyOraDB.Parameter_Name[10] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[11] = "ARG_GROUP_CD";
			MyOraDB.Parameter_Name[12] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[13] = "ARG_ITEM_NAME";
			MyOraDB.Parameter_Name[14] = "OUT_CURSOR";

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
			MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[14] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_reqNo, "");
			MyOraDB.Parameter_Values[2] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_reqReason, "");
			MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_Combo(cmb_reqDept, "");
			MyOraDB.Parameter_Values[6] = COM.ComFunction.Empty_Combo(cmb_reqUser, "").Replace("ALL", "");
			MyOraDB.Parameter_Values[7] = COM.ComFunction.Empty_Combo(cmb_UseDivision, "");
			MyOraDB.Parameter_Values[8] = COM.ComFunction.Empty_Combo(cmb_Transport, "");
			MyOraDB.Parameter_Values[9] = COM.ComFunction.Empty_Combo(cmb_UseYN, "");
			MyOraDB.Parameter_Values[10] = COM.ComFunction.Empty_Combo(cmb_style, "");
			MyOraDB.Parameter_Values[11] = _itemGroupCode;
			MyOraDB.Parameter_Values[12] = COM.ComFunction.Empty_TextBox(txt_itemCode, "");
			MyOraDB.Parameter_Values[13] = COM.ComFunction.Empty_TextBox(txt_itemName, "");
			MyOraDB.Parameter_Values[14] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBP_REQUEST_DIVIDE : REQUEST 정보 분류 및 수정사항 저장하기
		/// </summary>
		public bool SAVE_SBP_REQUEST_INFO()
		{
			try
			{
				MyOraDB.ReDim_Parameter(8);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_REQUEST_DIVIDE.SAVE_SBP_REQUEST_INFO";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[2] = "ARG_REQ_SEQ";
				MyOraDB.Parameter_Name[3] = "ARG_REQ_QTY";
				MyOraDB.Parameter_Name[4] = "ARG_TRANSPORT_TYPE";
				MyOraDB.Parameter_Name[5] = "ARG_USE_DIVIDE";
				MyOraDB.Parameter_Name[6] = "ARG_REQ_REASON";
				MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;

				//04.DATA 정의
				ArrayList vList = new ArrayList();

				string vUpdUser = COM.ComVar.This_User;

				for (int vRow = 0 ; vRow < _mainSheet.RowCount ; vRow++)
				{
					if (!ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, 0].Tag).Equals(""))
					{
						vList.Add(_mainSheet.Cells[vRow, _factoryCol].Text);
						vList.Add(_mainSheet.Cells[vRow, _reqNoCol].Text);
						vList.Add(_mainSheet.Cells[vRow, _reqSeqCol].Text);
						vList.Add(_mainSheet.Cells[vRow, _reqQtyCol].Text.Replace(",", ""));
						vList.Add(_mainSheet.Cells[vRow, _transportCol].Value.ToString());
						vList.Add(_mainSheet.Cells[vRow, _useDivideCol].Value.ToString());
						vList.Add(_mainSheet.Cells[vRow, _reqReasonCol].Value.ToString());
						vList.Add(vUpdUser);
					}
				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(true);

				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		/// <summary>
		/// PKG_SBP_REQUEST_DIVIDE : MRP 데이터를 MRP 테이블로
		/// </summary>
		public bool RUN_SBP_REQUEST_COMMIT()
		{
			try
			{
				MyOraDB.ReDim_Parameter(3);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_REQUEST_DIVIDE.RUN_SBP_REQUEST_COMMIT";

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

				MyOraDB.Add_Modify_Parameter(false);
				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		#endregion

	}
}

