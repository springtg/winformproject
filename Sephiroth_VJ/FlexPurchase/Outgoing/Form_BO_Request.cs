using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;
using FlexPurchase.Incoming;
using FlexPurchase.Purchase;


namespace FlexPurchase.Outgoing
{
	public class Form_BO_Request : COM.PCHWinForm.Form_Top
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
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.Label lbl_reqUser;
		private System.Windows.Forms.Label lbl_reqDept;
		private System.Windows.Forms.Label lbl_rtaDate;
		private System.Windows.Forms.Label lbl_estDate;
		private System.Windows.Forms.Label lbl_reqReason;
		private System.Windows.Forms.Label lbl_remark;
		private System.Windows.Forms.Label lbl_offerNo;
		private COM.SSP spd_size;
		private FarPoint.Win.Spread.SheetView spd_size_Sheet1;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private C1.Win.C1List.C1Combo cmb_reqDept;
		private System.Windows.Forms.DateTimePicker dpick_reqYmd;
		private C1.Win.C1List.C1Combo cmb_reqNo;
		private System.Windows.Forms.DateTimePicker dpick_estYmd;
		private System.Windows.Forms.DateTimePicker dpick_rtaYmd;
		private C1.Win.C1List.C1Combo cmb_offerYn;
		private System.Windows.Forms.TextBox txt_offerNo;
		private System.Windows.Forms.TextBox txt_remark;
		private C1.Win.C1List.C1Combo cmb_reqReason;
		private C1.Win.C1List.C1Combo cmb_reqUser;
		private System.Windows.Forms.Label btn_searchOffer;
		private System.Windows.Forms.Label btn_searchReq;
		private System.Windows.Forms.Panel pnl_low;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label btn_Insert;
		private System.Windows.Forms.Label btn_delete;
		private System.Windows.Forms.Label btn_Tree;
		private System.Windows.Forms.TextBox txt_status;
		private System.Windows.Forms.ContextMenu ctx_tail;
		private System.Windows.Forms.MenuItem mnu_AllSelect;
		private System.Windows.Forms.MenuItem mnu_Data;
		private System.Windows.Forms.Label lbl_division;
		private C1.Win.C1List.C1Combo cmb_reqDivision;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.Label lbl_calcType;
		private C1.Win.C1List.C1Combo cmb_calcType;
		private System.Windows.Forms.Label btn_size;
		private System.Windows.Forms.Label lbl_stylecd;
		private System.Windows.Forms.TextBox txt_styleCd;
		private C1.Win.C1List.C1Combo cmb_style;
		private System.Windows.Forms.Label lbl_po;
		private System.Windows.Forms.TextBox txt_po;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private Hashtable _cellTypes = null;
		private Pop_BP_Purchase_Wait vWaitPop = null;
		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		private FarPoint.Win.Spread.SheetView _sizeSheet = null;
		private System.EventHandler   _cmbReqNoEventHandler   = null;
		private const int _validate_tree = 10, _validate_insert = 20;
		private bool _practicable = true, _doSearch = true, _existSize;
		private bool _firstLoad    = true;
		private int _startCol = 4;

		private int _seqCol			= (int)ClassLib.TBSBP_REQUEST_TAIL.IxSEQ;
		private int _factoryCol     = (int)ClassLib.TBSBP_REQUEST_TAIL.IxFACTORY;
		private int _reqNoCol		= (int)ClassLib.TBSBP_REQUEST_TAIL.IxREQ_NO;
		private int _offerYNCol		= (int)ClassLib.TBSBP_REQUEST_TAIL.IxOFFER_YN;
		private int _reqSeqCol      = (int)ClassLib.TBSBP_REQUEST_TAIL.IxREQ_SEQ;
		private int _itemCdCol		= (int)ClassLib.TBSBP_REQUEST_TAIL.IxITEM_CD;
		private int _itemNmCol		= (int)ClassLib.TBSBP_REQUEST_TAIL.IxITEM_NM;
		private int _specCdCol		= (int)ClassLib.TBSBP_REQUEST_TAIL.IxSPEC_CD;
		private int _specNmCol		= (int)ClassLib.TBSBP_REQUEST_TAIL.IxSPEC_NM;
		private int _colorCdCol		= (int)ClassLib.TBSBP_REQUEST_TAIL.IxCOLOR_CD;
		private int _colorNmCol		= (int)ClassLib.TBSBP_REQUEST_TAIL.IxCOLOR_NM;
		private int _unitNmCol		= (int)ClassLib.TBSBP_REQUEST_TAIL.IxUNIT_NM;
		private int _styleCdCol		= (int)ClassLib.TBSBP_REQUEST_TAIL.IxSTYLE_CD;
		private int _modelNameCol	= (int)ClassLib.TBSBP_REQUEST_TAIL.IxMODEL_NAME;
		private int _componentCdCol = (int)ClassLib.TBSBP_REQUEST_TAIL.IxCOMPONENT_CD;
		private int _reqQty		    = (int)ClassLib.TBSBP_REQUEST_TAIL.IxREQ_QTY;
		private int _pkQtyCol		= (int)ClassLib.TBSBP_REQUEST_TAIL.IxPK_QTY;
		private int _reqReasonCol	= (int)ClassLib.TBSBP_REQUEST_TAIL.IxREQ_REASON;
		private int _obsIdCol		= (int)ClassLib.TBSBP_REQUEST_TAIL.IxOBS_ID;
		private int _obsTypeCol		= (int)ClassLib.TBSBP_REQUEST_TAIL.IxOBS_TYPE;

		private int _rtaCol		= (int)ClassLib.TBSBP_REQUEST_TAIL.IxRTA_YMD;
		private int _ets1Col		= (int)ClassLib.TBSBP_REQUEST_TAIL.IxETS1_YMD;


 


		private string _sizeStartColumnLabel = "";
		private string _sizeEndColumnLabel   = "";
		private string _obsId = "", _obsType = "";

        private Thread tRun = null;
        delegate void DelegateSetn(); // 대리자 선언   


		#endregion
		private C1.Win.C1List.C1Combo cmb_line;
		private System.Windows.Forms.Label lbl_line;

		#region 생성자 / 소멸자

		public Form_BO_Request()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BO_Request));
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
            this.pnl_low = new System.Windows.Forms.Panel();
            this.btn_Tree = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Label();
            this.btn_recover = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Label();
            this.spd_size = new COM.SSP();
            this.spd_size_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.lbl_po = new System.Windows.Forms.Label();
            this.txt_po = new System.Windows.Forms.TextBox();
            this.lbl_stylecd = new System.Windows.Forms.Label();
            this.txt_styleCd = new System.Windows.Forms.TextBox();
            this.cmb_style = new C1.Win.C1List.C1Combo();
            this.btn_size = new System.Windows.Forms.Label();
            this.lbl_calcType = new System.Windows.Forms.Label();
            this.cmb_calcType = new C1.Win.C1List.C1Combo();
            this.dpick_estYmd = new System.Windows.Forms.DateTimePicker();
            this.lbl_estDate = new System.Windows.Forms.Label();
            this.cmb_reqDivision = new C1.Win.C1List.C1Combo();
            this.lbl_division = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.cmb_reqNo = new C1.Win.C1List.C1Combo();
            this.lbl_reqNo = new System.Windows.Forms.Label();
            this.btn_searchOffer = new System.Windows.Forms.Label();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.cmb_reqReason = new C1.Win.C1List.C1Combo();
            this.cmb_line = new C1.Win.C1List.C1Combo();
            this.txt_offerNo = new System.Windows.Forms.TextBox();
            this.cmb_offerYn = new C1.Win.C1List.C1Combo();
            this.dpick_rtaYmd = new System.Windows.Forms.DateTimePicker();
            this.cmb_reqDept = new C1.Win.C1List.C1Combo();
            this.cmb_reqUser = new C1.Win.C1List.C1Combo();
            this.lbl_offerNo = new System.Windows.Forms.Label();
            this.lbl_remark = new System.Windows.Forms.Label();
            this.lbl_reqReason = new System.Windows.Forms.Label();
            this.lbl_rtaDate = new System.Windows.Forms.Label();
            this.lbl_line = new System.Windows.Forms.Label();
            this.lbl_reqDept = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_reqUser = new System.Windows.Forms.Label();
            this.btn_searchReq = new System.Windows.Forms.Label();
            this.dpick_reqYmd = new System.Windows.Forms.DateTimePicker();
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
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_low.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_size_Sheet1)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_calcType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_offerYn)).BeginInit();
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
            // tbtn_Delete
            // 
            this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
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
            this.c1Sizer1.Controls.Add(this.pnl_low);
            this.c1Sizer1.Controls.Add(this.spd_size);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.pnl_main);
            this.c1Sizer1.GridDefinition = "31.25:False:True;10.2430555555556:False:True;50.3472222222222:False:False;6.07638" +
                "888888889:False:True;\t0.393700787401575:False:True;98.4251968503937:False:False;" +
                "0.393700787401575:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_low
            // 
            this.pnl_low.BackColor = System.Drawing.Color.Transparent;
            this.pnl_low.Controls.Add(this.btn_Tree);
            this.pnl_low.Controls.Add(this.btn_delete);
            this.pnl_low.Controls.Add(this.btn_recover);
            this.pnl_low.Controls.Add(this.btn_Insert);
            this.pnl_low.Location = new System.Drawing.Point(8, 541);
            this.pnl_low.Name = "pnl_low";
            this.pnl_low.Size = new System.Drawing.Size(1000, 35);
            this.pnl_low.TabIndex = 3;
            // 
            // btn_Tree
            // 
            this.btn_Tree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Tree.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tree.ImageIndex = 13;
            this.btn_Tree.ImageList = this.image_List;
            this.btn_Tree.Location = new System.Drawing.Point(677, 6);
            this.btn_Tree.Name = "btn_Tree";
            this.btn_Tree.Size = new System.Drawing.Size(80, 24);
            this.btn_Tree.TabIndex = 364;
            this.btn_Tree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Tree.Click += new System.EventHandler(this.btn_Tree_Click);
            this.btn_Tree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_tree_MouseDown);
            this.btn_Tree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_tree_MouseUp);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_delete.ImageIndex = 5;
            this.btn_delete.ImageList = this.image_List;
            this.btn_delete.Location = new System.Drawing.Point(839, 6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(80, 24);
            this.btn_delete.TabIndex = 363;
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            this.btn_delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_delete_MouseDown);
            this.btn_delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_delete_MouseUp);
            // 
            // btn_recover
            // 
            this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_recover.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recover.ImageIndex = 1;
            this.btn_recover.ImageList = this.image_List;
            this.btn_recover.Location = new System.Drawing.Point(920, 6);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(80, 24);
            this.btn_recover.TabIndex = 353;
            this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
            this.btn_recover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseDown);
            this.btn_recover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseUp);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Insert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.ImageIndex = 9;
            this.btn_Insert.ImageList = this.image_List;
            this.btn_Insert.Location = new System.Drawing.Point(758, 6);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 24);
            this.btn_Insert.TabIndex = 352;
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            this.btn_Insert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseDown);
            this.btn_Insert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseUp);
            // 
            // spd_size
            // 
            this.spd_size.Location = new System.Drawing.Point(8, 184);
            this.spd_size.Name = "spd_size";
            this.spd_size.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Cells;
            this.spd_size.Sheets.Add(this.spd_size_Sheet1);
            this.spd_size.Size = new System.Drawing.Size(1000, 59);
            this.spd_size.TabIndex = 2;
            this.spd_size.KeyUp += new System.Windows.Forms.KeyEventHandler(this.spd_size_KeyUp);
            // 
            // spd_size_Sheet1
            // 
            this.spd_size_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.ExtendedSelect;
            this.spd_size_Sheet1.SelectionPolicy = FarPoint.Win.Spread.Model.SelectionPolicy.MultiRange;
            this.spd_size_Sheet1.SelectionUnit = FarPoint.Win.Spread.Model.SelectionUnit.Row;
            this.spd_size_Sheet1.SheetName = "Sheet1";
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.lbl_po);
            this.pnl_head.Controls.Add(this.txt_po);
            this.pnl_head.Controls.Add(this.lbl_stylecd);
            this.pnl_head.Controls.Add(this.txt_styleCd);
            this.pnl_head.Controls.Add(this.cmb_style);
            this.pnl_head.Controls.Add(this.btn_size);
            this.pnl_head.Controls.Add(this.lbl_calcType);
            this.pnl_head.Controls.Add(this.cmb_calcType);
            this.pnl_head.Controls.Add(this.dpick_estYmd);
            this.pnl_head.Controls.Add(this.lbl_estDate);
            this.pnl_head.Controls.Add(this.cmb_reqDivision);
            this.pnl_head.Controls.Add(this.lbl_division);
            this.pnl_head.Controls.Add(this.txt_status);
            this.pnl_head.Controls.Add(this.cmb_reqNo);
            this.pnl_head.Controls.Add(this.lbl_reqNo);
            this.pnl_head.Controls.Add(this.btn_searchOffer);
            this.pnl_head.Controls.Add(this.txt_remark);
            this.pnl_head.Controls.Add(this.cmb_reqReason);
            this.pnl_head.Controls.Add(this.cmb_line);
            this.pnl_head.Controls.Add(this.txt_offerNo);
            this.pnl_head.Controls.Add(this.cmb_offerYn);
            this.pnl_head.Controls.Add(this.dpick_rtaYmd);
            this.pnl_head.Controls.Add(this.cmb_reqDept);
            this.pnl_head.Controls.Add(this.cmb_reqUser);
            this.pnl_head.Controls.Add(this.lbl_offerNo);
            this.pnl_head.Controls.Add(this.lbl_remark);
            this.pnl_head.Controls.Add(this.lbl_reqReason);
            this.pnl_head.Controls.Add(this.lbl_rtaDate);
            this.pnl_head.Controls.Add(this.lbl_line);
            this.pnl_head.Controls.Add(this.lbl_reqDept);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_status);
            this.pnl_head.Controls.Add(this.lbl_reqUser);
            this.pnl_head.Controls.Add(this.btn_searchReq);
            this.pnl_head.Controls.Add(this.dpick_reqYmd);
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
            this.pnl_head.Size = new System.Drawing.Size(1000, 180);
            this.pnl_head.TabIndex = 0;
            // 
            // lbl_po
            // 
            this.lbl_po.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_po.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_po.ImageIndex = 0;
            this.lbl_po.ImageList = this.img_Label;
            this.lbl_po.Location = new System.Drawing.Point(8, 128);
            this.lbl_po.Name = "lbl_po";
            this.lbl_po.Size = new System.Drawing.Size(100, 21);
            this.lbl_po.TabIndex = 425;
            this.lbl_po.Text = "PO";
            this.lbl_po.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_po
            // 
            this.txt_po.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_po.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_po.Location = new System.Drawing.Point(109, 128);
            this.txt_po.MaxLength = 8;
            this.txt_po.Name = "txt_po";
            this.txt_po.Size = new System.Drawing.Size(210, 21);
            this.txt_po.TabIndex = 426;
            // 
            // lbl_stylecd
            // 
            this.lbl_stylecd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_stylecd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stylecd.ImageIndex = 0;
            this.lbl_stylecd.ImageList = this.img_Label;
            this.lbl_stylecd.Location = new System.Drawing.Point(337, 128);
            this.lbl_stylecd.Name = "lbl_stylecd";
            this.lbl_stylecd.Size = new System.Drawing.Size(100, 21);
            this.lbl_stylecd.TabIndex = 425;
            this.lbl_stylecd.Text = "Style";
            this.lbl_stylecd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_styleCd
            // 
            this.txt_styleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCd.Location = new System.Drawing.Point(438, 128);
            this.txt_styleCd.MaxLength = 10;
            this.txt_styleCd.Name = "txt_styleCd";
            this.txt_styleCd.Size = new System.Drawing.Size(73, 21);
            this.txt_styleCd.TabIndex = 426;
            this.txt_styleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_styleCd_KeyUp);
            // 
            // cmb_style
            // 
            this.cmb_style.AddItemCols = 0;
            this.cmb_style.AddItemSeparator = ';';
            this.cmb_style.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_style.Caption = "";
            this.cmb_style.CaptionHeight = 17;
            this.cmb_style.CaptionStyle = style1;
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
            this.cmb_style.EvenRowStyle = style2;
            this.cmb_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style.FooterStyle = style3;
            this.cmb_style.GapHeight = 2;
            this.cmb_style.HeadingStyle = style4;
            this.cmb_style.HighLightRowStyle = style5;
            this.cmb_style.ItemHeight = 15;
            this.cmb_style.Location = new System.Drawing.Point(512, 128);
            this.cmb_style.MatchEntryTimeout = ((long)(2000));
            this.cmb_style.MaxDropDownItems = ((short)(5));
            this.cmb_style.MaxLength = 32767;
            this.cmb_style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_style.Name = "cmb_style";
            this.cmb_style.OddRowStyle = style6;
            this.cmb_style.PartialRightColumn = false;
            this.cmb_style.PropBag = resources.GetString("cmb_style.PropBag");
            this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_style.SelectedStyle = style7;
            this.cmb_style.Size = new System.Drawing.Size(136, 20);
            this.cmb_style.Style = style8;
            this.cmb_style.TabIndex = 427;
            this.cmb_style.SelectedValueChanged += new System.EventHandler(this.cmb_style_SelectedValueChanged);
            // 
            // btn_size
            // 
            this.btn_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_size.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_size.ImageIndex = 0;
            this.btn_size.ImageList = this.img_Button;
            this.btn_size.Location = new System.Drawing.Point(897, 150);
            this.btn_size.Name = "btn_size";
            this.btn_size.Size = new System.Drawing.Size(80, 23);
            this.btn_size.TabIndex = 404;
            this.btn_size.Text = "Get Size Info";
            this.btn_size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_size.Click += new System.EventHandler(this.btn_size_Click);
            this.btn_size.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_size_MouseDown);
            this.btn_size.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_size_MouseUp);
            // 
            // lbl_calcType
            // 
            this.lbl_calcType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_calcType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calcType.ImageIndex = 0;
            this.lbl_calcType.ImageList = this.img_Label;
            this.lbl_calcType.Location = new System.Drawing.Point(666, 128);
            this.lbl_calcType.Name = "lbl_calcType";
            this.lbl_calcType.Size = new System.Drawing.Size(100, 21);
            this.lbl_calcType.TabIndex = 359;
            this.lbl_calcType.Text = "Calculation";
            this.lbl_calcType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_calcType
            // 
            this.cmb_calcType.AddItemCols = 0;
            this.cmb_calcType.AddItemSeparator = ';';
            this.cmb_calcType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_calcType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_calcType.Caption = "";
            this.cmb_calcType.CaptionHeight = 17;
            this.cmb_calcType.CaptionStyle = style9;
            this.cmb_calcType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_calcType.ColumnCaptionHeight = 18;
            this.cmb_calcType.ColumnFooterHeight = 18;
            this.cmb_calcType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_calcType.ContentHeight = 16;
            this.cmb_calcType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_calcType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_calcType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_calcType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_calcType.EditorHeight = 16;
            this.cmb_calcType.EvenRowStyle = style10;
            this.cmb_calcType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_calcType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_calcType.FooterStyle = style11;
            this.cmb_calcType.GapHeight = 2;
            this.cmb_calcType.HeadingStyle = style12;
            this.cmb_calcType.HighLightRowStyle = style13;
            this.cmb_calcType.ItemHeight = 15;
            this.cmb_calcType.Location = new System.Drawing.Point(767, 128);
            this.cmb_calcType.MatchEntryTimeout = ((long)(2000));
            this.cmb_calcType.MaxDropDownItems = ((short)(5));
            this.cmb_calcType.MaxLength = 32767;
            this.cmb_calcType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_calcType.Name = "cmb_calcType";
            this.cmb_calcType.OddRowStyle = style14;
            this.cmb_calcType.PartialRightColumn = false;
            this.cmb_calcType.PropBag = resources.GetString("cmb_calcType.PropBag");
            this.cmb_calcType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_calcType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_calcType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_calcType.SelectedStyle = style15;
            this.cmb_calcType.Size = new System.Drawing.Size(210, 20);
            this.cmb_calcType.Style = style16;
            this.cmb_calcType.TabIndex = 372;
            // 
            // dpick_estYmd
            // 
            this.dpick_estYmd.CustomFormat = "";
            this.dpick_estYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_estYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_estYmd.Location = new System.Drawing.Point(438, 106);
            this.dpick_estYmd.Name = "dpick_estYmd";
            this.dpick_estYmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dpick_estYmd.Size = new System.Drawing.Size(212, 21);
            this.dpick_estYmd.TabIndex = 367;
            // 
            // lbl_estDate
            // 
            this.lbl_estDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_estDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estDate.ImageIndex = 0;
            this.lbl_estDate.ImageList = this.img_Label;
            this.lbl_estDate.Location = new System.Drawing.Point(337, 106);
            this.lbl_estDate.Name = "lbl_estDate";
            this.lbl_estDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_estDate.TabIndex = 358;
            this.lbl_estDate.Text = "ETS Date";
            this.lbl_estDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_reqDivision
            // 
            this.cmb_reqDivision.AddItemCols = 0;
            this.cmb_reqDivision.AddItemSeparator = ';';
            this.cmb_reqDivision.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_reqDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_reqDivision.Caption = "";
            this.cmb_reqDivision.CaptionHeight = 17;
            this.cmb_reqDivision.CaptionStyle = style17;
            this.cmb_reqDivision.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_reqDivision.ColumnCaptionHeight = 18;
            this.cmb_reqDivision.ColumnFooterHeight = 18;
            this.cmb_reqDivision.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_reqDivision.ContentHeight = 16;
            this.cmb_reqDivision.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_reqDivision.EditorBackColor = System.Drawing.SystemColors.Control;
            this.cmb_reqDivision.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_reqDivision.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_reqDivision.EditorHeight = 16;
            this.cmb_reqDivision.EvenRowStyle = style18;
            this.cmb_reqDivision.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_reqDivision.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reqDivision.FooterStyle = style19;
            this.cmb_reqDivision.GapHeight = 2;
            this.cmb_reqDivision.HeadingStyle = style20;
            this.cmb_reqDivision.HighLightRowStyle = style21;
            this.cmb_reqDivision.ItemHeight = 15;
            this.cmb_reqDivision.Location = new System.Drawing.Point(767, 62);
            this.cmb_reqDivision.MatchEntryTimeout = ((long)(2000));
            this.cmb_reqDivision.MaxDropDownItems = ((short)(5));
            this.cmb_reqDivision.MaxLength = 32767;
            this.cmb_reqDivision.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_reqDivision.Name = "cmb_reqDivision";
            this.cmb_reqDivision.OddRowStyle = style22;
            this.cmb_reqDivision.PartialRightColumn = false;
            this.cmb_reqDivision.PropBag = resources.GetString("cmb_reqDivision.PropBag");
            this.cmb_reqDivision.ReadOnly = true;
            this.cmb_reqDivision.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_reqDivision.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_reqDivision.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_reqDivision.SelectedStyle = style23;
            this.cmb_reqDivision.Size = new System.Drawing.Size(210, 20);
            this.cmb_reqDivision.Style = style24;
            this.cmb_reqDivision.TabIndex = 372;
            // 
            // lbl_division
            // 
            this.lbl_division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_division.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_division.ImageIndex = 0;
            this.lbl_division.ImageList = this.img_Label;
            this.lbl_division.Location = new System.Drawing.Point(666, 62);
            this.lbl_division.Name = "lbl_division";
            this.lbl_division.Size = new System.Drawing.Size(100, 21);
            this.lbl_division.TabIndex = 359;
            this.lbl_division.Text = "Division";
            this.lbl_division.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.SystemColors.Control;
            this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_status.Enabled = false;
            this.txt_status.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_status.Location = new System.Drawing.Point(767, 40);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(210, 21);
            this.txt_status.TabIndex = 377;
            // 
            // cmb_reqNo
            // 
            this.cmb_reqNo.AddItemCols = 0;
            this.cmb_reqNo.AddItemSeparator = ';';
            this.cmb_reqNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_reqNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_reqNo.Caption = "";
            this.cmb_reqNo.CaptionHeight = 17;
            this.cmb_reqNo.CaptionStyle = style25;
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
            this.cmb_reqNo.EvenRowStyle = style26;
            this.cmb_reqNo.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_reqNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reqNo.FooterStyle = style27;
            this.cmb_reqNo.GapHeight = 2;
            this.cmb_reqNo.HeadingStyle = style28;
            this.cmb_reqNo.HighLightRowStyle = style29;
            this.cmb_reqNo.ItemHeight = 15;
            this.cmb_reqNo.Location = new System.Drawing.Point(438, 40);
            this.cmb_reqNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_reqNo.MaxDropDownItems = ((short)(5));
            this.cmb_reqNo.MaxLength = 32767;
            this.cmb_reqNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_reqNo.Name = "cmb_reqNo";
            this.cmb_reqNo.OddRowStyle = style30;
            this.cmb_reqNo.PartialRightColumn = false;
            this.cmb_reqNo.PropBag = resources.GetString("cmb_reqNo.PropBag");
            this.cmb_reqNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_reqNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_reqNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_reqNo.SelectedStyle = style31;
            this.cmb_reqNo.Size = new System.Drawing.Size(188, 20);
            this.cmb_reqNo.Style = style32;
            this.cmb_reqNo.TabIndex = 5;
            this.cmb_reqNo.SelectedValueChanged += new System.EventHandler(this.cmb_reqNo_SelectedValueChanged);
            // 
            // lbl_reqNo
            // 
            this.lbl_reqNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqNo.ImageIndex = 1;
            this.lbl_reqNo.ImageList = this.img_Label;
            this.lbl_reqNo.Location = new System.Drawing.Point(337, 40);
            this.lbl_reqNo.Name = "lbl_reqNo";
            this.lbl_reqNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqNo.TabIndex = 50;
            this.lbl_reqNo.Text = "Request No";
            this.lbl_reqNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_searchOffer
            // 
            this.btn_searchOffer.Enabled = false;
            this.btn_searchOffer.ImageIndex = 27;
            this.btn_searchOffer.ImageList = this.img_SmallButton;
            this.btn_searchOffer.Location = new System.Drawing.Point(955, 106);
            this.btn_searchOffer.Name = "btn_searchOffer";
            this.btn_searchOffer.Size = new System.Drawing.Size(24, 21);
            this.btn_searchOffer.TabIndex = 375;
            this.btn_searchOffer.Tag = "Search";
            this.btn_searchOffer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_searchOffer.Click += new System.EventHandler(this.btn_searchOffer_Click);
            this.btn_searchOffer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_searchOffer_MouseDown);
            this.btn_searchOffer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_searchOffer_MouseUp);
            // 
            // txt_remark
            // 
            this.txt_remark.BackColor = System.Drawing.Color.White;
            this.txt_remark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_remark.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_remark.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_remark.Location = new System.Drawing.Point(109, 150);
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(540, 21);
            this.txt_remark.TabIndex = 373;
            // 
            // cmb_reqReason
            // 
            this.cmb_reqReason.AddItemCols = 0;
            this.cmb_reqReason.AddItemSeparator = ';';
            this.cmb_reqReason.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_reqReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_reqReason.Caption = "";
            this.cmb_reqReason.CaptionHeight = 17;
            this.cmb_reqReason.CaptionStyle = style33;
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
            this.cmb_reqReason.EvenRowStyle = style34;
            this.cmb_reqReason.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_reqReason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reqReason.FooterStyle = style35;
            this.cmb_reqReason.GapHeight = 2;
            this.cmb_reqReason.HeadingStyle = style36;
            this.cmb_reqReason.HighLightRowStyle = style37;
            this.cmb_reqReason.ItemHeight = 15;
            this.cmb_reqReason.Location = new System.Drawing.Point(767, 84);
            this.cmb_reqReason.MatchEntryTimeout = ((long)(2000));
            this.cmb_reqReason.MaxDropDownItems = ((short)(5));
            this.cmb_reqReason.MaxLength = 32767;
            this.cmb_reqReason.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_reqReason.Name = "cmb_reqReason";
            this.cmb_reqReason.OddRowStyle = style38;
            this.cmb_reqReason.PartialRightColumn = false;
            this.cmb_reqReason.PropBag = resources.GetString("cmb_reqReason.PropBag");
            this.cmb_reqReason.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_reqReason.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_reqReason.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_reqReason.SelectedStyle = style39;
            this.cmb_reqReason.Size = new System.Drawing.Size(210, 20);
            this.cmb_reqReason.Style = style40;
            this.cmb_reqReason.TabIndex = 372;
            // 
            // cmb_line
            // 
            this.cmb_line.AddItemCols = 0;
            this.cmb_line.AddItemSeparator = ';';
            this.cmb_line.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_line.Caption = "";
            this.cmb_line.CaptionHeight = 17;
            this.cmb_line.CaptionStyle = style41;
            this.cmb_line.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_line.ColumnCaptionHeight = 18;
            this.cmb_line.ColumnFooterHeight = 18;
            this.cmb_line.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_line.ContentHeight = 16;
            this.cmb_line.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_line.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_line.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_line.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_line.EditorHeight = 16;
            this.cmb_line.EvenRowStyle = style42;
            this.cmb_line.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_line.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_line.FooterStyle = style43;
            this.cmb_line.GapHeight = 2;
            this.cmb_line.HeadingStyle = style44;
            this.cmb_line.HighLightRowStyle = style45;
            this.cmb_line.ItemHeight = 15;
            this.cmb_line.Location = new System.Drawing.Point(438, 84);
            this.cmb_line.MatchEntryTimeout = ((long)(2000));
            this.cmb_line.MaxDropDownItems = ((short)(5));
            this.cmb_line.MaxLength = 32767;
            this.cmb_line.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_line.Name = "cmb_line";
            this.cmb_line.OddRowStyle = style46;
            this.cmb_line.PartialRightColumn = false;
            this.cmb_line.PropBag = resources.GetString("cmb_line.PropBag");
            this.cmb_line.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_line.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_line.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_line.SelectedStyle = style47;
            this.cmb_line.Size = new System.Drawing.Size(210, 20);
            this.cmb_line.Style = style48;
            this.cmb_line.TabIndex = 371;
            // 
            // txt_offerNo
            // 
            this.txt_offerNo.BackColor = System.Drawing.SystemColors.Control;
            this.txt_offerNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_offerNo.Enabled = false;
            this.txt_offerNo.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_offerNo.Location = new System.Drawing.Point(833, 106);
            this.txt_offerNo.Name = "txt_offerNo";
            this.txt_offerNo.ReadOnly = true;
            this.txt_offerNo.Size = new System.Drawing.Size(122, 21);
            this.txt_offerNo.TabIndex = 370;
            // 
            // cmb_offerYn
            // 
            this.cmb_offerYn.AddItemCols = 0;
            this.cmb_offerYn.AddItemSeparator = ';';
            this.cmb_offerYn.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_offerYn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_offerYn.Caption = "";
            this.cmb_offerYn.CaptionHeight = 17;
            this.cmb_offerYn.CaptionStyle = style49;
            this.cmb_offerYn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_offerYn.ColumnCaptionHeight = 18;
            this.cmb_offerYn.ColumnFooterHeight = 18;
            this.cmb_offerYn.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_offerYn.ContentHeight = 16;
            this.cmb_offerYn.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_offerYn.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_offerYn.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_offerYn.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_offerYn.EditorHeight = 16;
            this.cmb_offerYn.EvenRowStyle = style50;
            this.cmb_offerYn.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_offerYn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_offerYn.FooterStyle = style51;
            this.cmb_offerYn.GapHeight = 2;
            this.cmb_offerYn.HeadingStyle = style52;
            this.cmb_offerYn.HighLightRowStyle = style53;
            this.cmb_offerYn.ItemHeight = 15;
            this.cmb_offerYn.Location = new System.Drawing.Point(767, 106);
            this.cmb_offerYn.MatchEntryTimeout = ((long)(2000));
            this.cmb_offerYn.MaxDropDownItems = ((short)(5));
            this.cmb_offerYn.MaxLength = 32767;
            this.cmb_offerYn.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_offerYn.Name = "cmb_offerYn";
            this.cmb_offerYn.OddRowStyle = style54;
            this.cmb_offerYn.PartialRightColumn = false;
            this.cmb_offerYn.PropBag = resources.GetString("cmb_offerYn.PropBag");
            this.cmb_offerYn.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_offerYn.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_offerYn.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_offerYn.SelectedStyle = style55;
            this.cmb_offerYn.Size = new System.Drawing.Size(65, 20);
            this.cmb_offerYn.Style = style56;
            this.cmb_offerYn.TabIndex = 369;
            this.cmb_offerYn.SelectedValueChanged += new System.EventHandler(this.cmb_offerYn_SelectedValueChanged);
            // 
            // dpick_rtaYmd
            // 
            this.dpick_rtaYmd.CustomFormat = "";
            this.dpick_rtaYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_rtaYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_rtaYmd.Location = new System.Drawing.Point(109, 106);
            this.dpick_rtaYmd.Name = "dpick_rtaYmd";
            this.dpick_rtaYmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dpick_rtaYmd.Size = new System.Drawing.Size(212, 21);
            this.dpick_rtaYmd.TabIndex = 368;
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
            this.cmb_reqUser.Location = new System.Drawing.Point(109, 84);
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
            this.cmb_reqUser.SelectedValueChanged += new System.EventHandler(this.cmb_reqUser_SelectedValueChanged);
            // 
            // lbl_offerNo
            // 
            this.lbl_offerNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_offerNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_offerNo.ImageIndex = 0;
            this.lbl_offerNo.ImageList = this.img_Label;
            this.lbl_offerNo.Location = new System.Drawing.Point(666, 106);
            this.lbl_offerNo.Name = "lbl_offerNo";
            this.lbl_offerNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_offerNo.TabIndex = 362;
            this.lbl_offerNo.Text = "Offer No";
            this.lbl_offerNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_remark
            // 
            this.lbl_remark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_remark.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remark.ImageIndex = 0;
            this.lbl_remark.ImageList = this.img_Label;
            this.lbl_remark.Location = new System.Drawing.Point(8, 150);
            this.lbl_remark.Name = "lbl_remark";
            this.lbl_remark.Size = new System.Drawing.Size(100, 21);
            this.lbl_remark.TabIndex = 360;
            this.lbl_remark.Text = "Remark";
            this.lbl_remark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_reqReason
            // 
            this.lbl_reqReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqReason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqReason.ImageIndex = 0;
            this.lbl_reqReason.ImageList = this.img_Label;
            this.lbl_reqReason.Location = new System.Drawing.Point(666, 84);
            this.lbl_reqReason.Name = "lbl_reqReason";
            this.lbl_reqReason.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqReason.TabIndex = 359;
            this.lbl_reqReason.Text = "Request Reason";
            this.lbl_reqReason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_rtaDate
            // 
            this.lbl_rtaDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_rtaDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rtaDate.ImageIndex = 0;
            this.lbl_rtaDate.ImageList = this.img_Label;
            this.lbl_rtaDate.Location = new System.Drawing.Point(8, 106);
            this.lbl_rtaDate.Name = "lbl_rtaDate";
            this.lbl_rtaDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_rtaDate.TabIndex = 357;
            this.lbl_rtaDate.Text = "RTA Date";
            this.lbl_rtaDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_line
            // 
            this.lbl_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_line.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_line.ImageIndex = 0;
            this.lbl_line.ImageList = this.img_Label;
            this.lbl_line.Location = new System.Drawing.Point(337, 84);
            this.lbl_line.Name = "lbl_line";
            this.lbl_line.Size = new System.Drawing.Size(100, 21);
            this.lbl_line.TabIndex = 356;
            this.lbl_line.Text = "Line";
            this.lbl_line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pic_head3.Location = new System.Drawing.Point(984, 164);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // lbl_status
            // 
            this.lbl_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_status.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ImageIndex = 0;
            this.lbl_status.ImageList = this.img_Label;
            this.lbl_status.Location = new System.Drawing.Point(666, 40);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(100, 21);
            this.lbl_status.TabIndex = 50;
            this.lbl_status.Text = "Status";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_reqUser
            // 
            this.lbl_reqUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqUser.ImageIndex = 0;
            this.lbl_reqUser.ImageList = this.img_Label;
            this.lbl_reqUser.Location = new System.Drawing.Point(8, 84);
            this.lbl_reqUser.Name = "lbl_reqUser";
            this.lbl_reqUser.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqUser.TabIndex = 50;
            this.lbl_reqUser.Text = "Request User";
            this.lbl_reqUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_searchReq
            // 
            this.btn_searchReq.ImageIndex = 27;
            this.btn_searchReq.ImageList = this.img_SmallButton;
            this.btn_searchReq.Location = new System.Drawing.Point(626, 40);
            this.btn_searchReq.Name = "btn_searchReq";
            this.btn_searchReq.Size = new System.Drawing.Size(24, 21);
            this.btn_searchReq.TabIndex = 54;
            this.btn_searchReq.Tag = "Search";
            this.btn_searchReq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_searchReq.Click += new System.EventHandler(this.btn_searchReq_Click);
            this.btn_searchReq.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_searchReq_MouseDown);
            this.btn_searchReq.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_searchReq_MouseUp);
            // 
            // dpick_reqYmd
            // 
            this.dpick_reqYmd.CustomFormat = "";
            this.dpick_reqYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_reqYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_reqYmd.Location = new System.Drawing.Point(109, 62);
            this.dpick_reqYmd.Name = "dpick_reqYmd";
            this.dpick_reqYmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dpick_reqYmd.Size = new System.Drawing.Size(212, 21);
            this.dpick_reqYmd.TabIndex = 2;
            this.dpick_reqYmd.CloseUp += new System.EventHandler(this.dpick_reqYmd_CloseUp);
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
            this.pic_head4.Location = new System.Drawing.Point(136, 163);
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
            this.pic_head7.Size = new System.Drawing.Size(101, 139);
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
            this.label2.Text = "      Request";
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
            this.pic_head5.Location = new System.Drawing.Point(0, 164);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 153);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.White;
            this.pnl_main.Controls.Add(this.spd_main);
            this.pnl_main.Location = new System.Drawing.Point(8, 247);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1000, 290);
            this.pnl_main.TabIndex = 1;
            // 
            // spd_main
            // 
            this.spd_main.BackColor = System.Drawing.Color.Transparent;
            this.spd_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spd_main.Location = new System.Drawing.Point(0, 0);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(1000, 290);
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
            this.menuItem2});
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
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem4,
            this.menuItem5,
            this.menuItem6,
            this.menuItem7});
            this.menuItem2.Text = "Auto Calculation";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "Celling";
            this.menuItem3.Click += new System.EventHandler(this.mnu_ceiling_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "Rounding";
            this.menuItem4.Click += new System.EventHandler(this.mnu_roundUp_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.Text = "Truncate";
            this.menuItem5.Click += new System.EventHandler(this.mnu_truncate_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 3;
            this.menuItem6.Text = "-";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 4;
            this.menuItem7.Text = "PK Unit Qty";
            this.menuItem7.Click += new System.EventHandler(this.mnu_pk_Click);
            // 
            // Form_BO_Request
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BO_Request";
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
            this.pnl_low.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_size_Sheet1)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_calcType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_offerYn)).EndInit();
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
			spd_main.Update_Row(img_Action);
		}

		private void spd_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			if (!e.ColumnHeader && e.Button == MouseButtons.Right && !e.ColumnHeader)
				ctx_tail.Show(spd_main, new Point(e.X, e.Y));
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


		private void spd_size_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (cmb_reqNo.SelectedIndex == -1 && e.KeyData == Keys.Delete)
			{
				CellRange[] vRanges = _sizeSheet.GetSelections();

				foreach (CellRange vRange in vRanges)
				{
					for (int i = vRange.Column ; i < vRange.Column + vRange.ColumnCount ; i++)
					{
						if (i >= _sizeSheet.FrozenColumnCount)
							_sizeSheet.Cells[vRange.Row, i].Text = "";
					}
				}
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
		
		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Delete))
			{
				if (ClassLib.ComFunction.User_Message("Do you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					this.Tbtn_DeleteProcess();
			}
		}

		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Confirm))
			{
				if(ClassLib.ComFunction.User_Message("Do you want to confirm?","Confirm", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )
					this.Tbtn_ConfirmProcess();
			}
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BP_Request_purchasing");
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 2;
			string [] aHead =  new string[iCnt];	
			
			string[] vProviso = GetSearchProviso();

			aHead[0]    = vProviso[0];
			aHead[1]    = vProviso[1];
			
			
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
			// head clear, grid clear
			if( !_firstLoad )
				ClearNotPk();	

			this.Cmb_ReqNoSettingProcess();
			this.DepartmentComboSetting();
		}

		private void dpick_reqYmd_CloseUp(object sender, System.EventArgs e)
		{
			// head clear, grid clear
			if( !_firstLoad )
				ClearNotPk();
		
			this.Cmb_ReqNoSettingProcess();
		}


		private void cmb_reqUser_SelectedValueChanged(object sender, System.EventArgs e)
		{
			_doSearch = false;
			this.Cmb_ReqNoSettingProcess();
			spd_main.ClearAll();
			_doSearch = true;
		}

		private void cmb_offerYn_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_OfferYnSettingProcess();
		}
		
		private void btn_searchReq_Click(object sender, System.EventArgs e)
		{
			this.Btn_SearchReqClickProcess();
		}

		private void btn_searchOffer_Click(object sender, System.EventArgs e)
		{
			this.Btn_SearchOfferClickProcess();
		}

		private void btn_recover_Click(object sender, System.EventArgs e)
		{
			this.spd_main.Recovery();
		}

		private void btn_Insert_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_validate_insert))
			{
				Show_Item_Popup();
			}
		}

		private void btn_Tree_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_validate_tree))
			{
				Show_Tree_Popup();
			}
		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			this.Btn_DeleteProcess();
		}

		private void btn_size_Click(object sender, System.EventArgs e)
		{
			try
			{
				Pop_BP_Request_Size vPop = new Pop_BP_Request_Size();
				ClassLib.ComVar.Parameter_PopUp = new string[]{COM.ComFunction.Empty_Combo(cmb_factory, COM.ComVar.This_Factory), COM.ComFunction.Empty_Combo(cmb_style, "").Replace("-", "")};

				if (vPop.ShowDialog() == DialogResult.OK)
				{
					int i = 0;

					for ( ; i < ClassLib.ComVar.Parameter_PopUp.Length - 4 ; i++)
					{
						_sizeSheet.Cells[0, i + _sizeSheet.FrozenColumnCount].Text = ClassLib.ComVar.Parameter_PopUp[i];
					}

					_obsId = ClassLib.ComVar.Parameter_PopUp[i];
					_obsType = ClassLib.ComVar.Parameter_PopUp[i + 1];
					txt_po.Text = ClassLib.ComVar.Parameter_PopUp[i + 3];

					if (!ClassLib.ComVar.Parameter_PopUp[i + 2].Equals(""))
					{
						txt_styleCd.Text = ClassLib.ComVar.Parameter_PopUp[i + 2];
						Txt_StyleCdKeyUpProcess();
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Size", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void txt_styleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				Txt_StyleCdKeyUpProcess();
		}

		private void cmb_style_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Cmb_StyleSelectedValueChangedProcess();
		}

		private void Cmb_StyleSelectedValueChangedProcess()
		{
			try
			{
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				txt_styleCd.Text	= cmb_style.SelectedValue.ToString();
			}
			catch //(Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs_Style", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Txt_StyleCdKeyUpProcess()
		{
			DataTable vDt = null;

			try
			{
				vDt = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_styleCd, " ").Replace("-", ""));
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				ClassLib.ComFunction.Set_ComboList_5(vDt, cmb_style, 0, 1, 2, 3, 4, true, 100, 221); 
				vDt.Dispose();
				
				string vCode = txt_styleCd.Text;
				
				if (txt_styleCd.Text.Length == 9)
				{
					vCode = vCode.Substring(0, 6) + "-" + vCode.Substring(6, 3);
				}

				cmb_style.SelectedValue = vCode;
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

		private void mnu_ceiling_Click(object sender, System.EventArgs e)
		{
			Mnu_AutoCalculation(1);
		}

		private void mnu_roundUp_Click(object sender, System.EventArgs e)
		{
			Mnu_AutoCalculation(2);		
		}

		private void mnu_truncate_Click(object sender, System.EventArgs e)
		{
			Mnu_AutoCalculation(3);
		}

		private void mnu_pk_Click(object sender, System.EventArgs e)
		{
			Mnu_AutoCalculation(5);
		}

		#endregion

		#region 입력이동

		#endregion

		#region 버튼효과

		private void btn_searchReq_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_searchReq.ImageIndex = 26;
		}

		private void btn_searchOffer_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_searchOffer.ImageIndex = 26;
		}

		private void btn_searchReq_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_searchReq.ImageIndex = 27;
		}

		private void btn_searchOffer_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_searchOffer.ImageIndex = 27;
		}

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

		private void btn_size_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_size_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		#endregion

		#endregion

		#region 공통 메서드

		private void ClearNotPkInfo()
		{
			this.cmb_reqNo.SelectedValueChanged -= _cmbReqNoEventHandler;
			
			cmb_reqDept.SelectedIndex		= 0;
			cmb_line.SelectedIndex			= 0;
			cmb_reqReason.SelectedIndex     = 0;
			dpick_estYmd.Value				= System.DateTime.Now;
			txt_remark.Text					= "";
			txt_status.Text					= "";
			cmb_offerYn.SelectedIndex		= 1;
			txt_offerNo.Text                = "";
			txt_styleCd.Text				= "";
			cmb_style.SelectedIndex			= -1;
			txt_po.Text						= "";
			this.cmb_reqNo.SelectedValueChanged += _cmbReqNoEventHandler;
		}

		private string[] GetSearchProviso()
		{
			string[] vProviso = new string[13];
			vProviso[0]  = COM.ComFunction.Empty_Combo(cmb_factory, "");
			vProviso[1]  = COM.ComFunction.Empty_Combo(this.cmb_reqNo, "");
			vProviso[2]  = dpick_reqYmd.Text.Replace("-", "");
			vProviso[3]  = COM.ComFunction.Empty_Combo(this.cmb_reqUser, "");
			vProviso[4]  = COM.ComFunction.Empty_Combo(this.cmb_reqDept, "");
			vProviso[5]  = COM.ComFunction.Empty_Combo(this.cmb_line, "");
			vProviso[6]  = COM.ComFunction.Empty_Combo(this.cmb_reqReason, "");
			vProviso[7]  = dpick_rtaYmd.Text.Replace("-", "");
			vProviso[8]  = dpick_estYmd.Text.Replace("-", "");
			vProviso[9]  = txt_remark.Text.ToString();
			vProviso[10] = COM.ComFunction.Empty_TextBox(this.txt_status, "");
			vProviso[11] = COM.ComFunction.Empty_Combo(this.cmb_offerYn, "");
			vProviso[12] = txt_offerNo.Text.ToString();
		
			return vProviso;
		}

		private void SetHeadInfo(DataTable arg_dt)
		{
			this.cmb_reqNo.SelectedValueChanged -= _cmbReqNoEventHandler;
			cmb_reqNo.SelectedValue			= arg_dt.Rows[0].ItemArray[1];
			this.dpick_reqYmd.Value         = ClassLib.ComFunction.StringToDateTime(arg_dt.Rows[0].ItemArray[2].ToString());
			cmb_reqUser.SelectedValue       = arg_dt.Rows[0].ItemArray[3];
			cmb_reqDept.SelectedValue		= arg_dt.Rows[0].ItemArray[4];
			cmb_line.SelectedValue			= arg_dt.Rows[0].ItemArray[5];
			cmb_reqReason.SelectedValue     = arg_dt.Rows[0].ItemArray[6];
			this.dpick_rtaYmd.Value			= ClassLib.ComFunction.StringToDateTime(arg_dt.Rows[0].ItemArray[7].ToString());
			this.dpick_estYmd.Value			= ClassLib.ComFunction.StringToDateTime(arg_dt.Rows[0].ItemArray[8].ToString());
			txt_remark.Text					= arg_dt.Rows[0].ItemArray[9].ToString();
			txt_status.Text					= arg_dt.Rows[0].ItemArray[10].ToString();
			cmb_offerYn.SelectedValue		= arg_dt.Rows[0].ItemArray[11] == null || arg_dt.Rows[0].ItemArray[11].ToString() =="N"? "N" : "Y";
			txt_offerNo.Text                = arg_dt.Rows[0].ItemArray[12].ToString();
			txt_styleCd.Text				= arg_dt.Rows[0].ItemArray[14].ToString();
			txt_po.Text						= arg_dt.Rows[0].ItemArray[15].ToString();
			cmb_reqNo.SelectedValue			= arg_dt.Rows[0].ItemArray[1];

			Txt_StyleCdKeyUpProcess();

			if(txt_status.Text.ToString().Substring(0,1) == "C")
				_sizeSheet.Cells[0, _mainSheet.FrozenColumnCount, 0, _mainSheet.ColumnCount - 1].Locked = true;
			else
				_sizeSheet.Cells[0, _mainSheet.FrozenColumnCount, 0, _mainSheet.ColumnCount - 1].Locked = false;
			this.cmb_reqNo.SelectedValueChanged += _cmbReqNoEventHandler;
		}

		private void ClearHeadInfo()
		{
			this.cmb_reqNo.SelectedValueChanged -= _cmbReqNoEventHandler;
			cmb_reqNo.SelectedIndex			= -1;
			dpick_reqYmd.Value				= System.DateTime.Now;
			cmb_reqUser.ValueMember			= "Name";
			cmb_reqUser.SelectedValue		= COM.ComVar.This_User;
			cmb_reqDept.SelectedValue		= COM.ComVar.This_Dept;
			cmb_line.SelectedIndex			= 0;
			cmb_reqReason.SelectedIndex     = 0;
			dpick_rtaYmd.Value				= System.DateTime.Now;
			dpick_estYmd.Value				= System.DateTime.Now;
			txt_remark.Text					= "";
			txt_status.Text					= "";
			cmb_offerYn.SelectedIndex		= 1;
			txt_offerNo.Text                = "";
			txt_styleCd.Text				= "";
			cmb_style.SelectedIndex			= -1;
			txt_po.Text						= "";
			this.cmb_reqNo.SelectedValueChanged += _cmbReqNoEventHandler;
		}

		private void SearchHeadInfo()
		{
			string vFactory = cmb_factory.SelectedValue.ToString();
			string vReqNo   = cmb_reqNo.SelectedIndex == -1 ? "" : cmb_reqNo.SelectedValue.ToString();
			string vReqYmd  = this.dpick_reqYmd.Text.Replace("-", "");

			DataTable vDt = SELECT_SBP_REQUEST_HEAD(vFactory, vReqNo);
			
			if (vDt.Rows.Count > 0 && vDt.Rows.Count < 2)
				this.SetHeadInfo(vDt);
			else
				this.ClearHeadInfo();
			vDt.Dispose();
		}

		private void SearchTailInfo()
		{
			string[] vProviso = GetSearchProviso();
			int vColumnCount  = _mainSheet.Columns.Count - 1;

			// factory, req_no, req_ymd
			DataTable vDt = SELECT_SBP_REQUEST_TAIL_LIST(vProviso[0],  vProviso[1]);
			if (vDt.Rows.Count > 0)
			{
				spd_main.Display_Grid(vDt);

				if (_mainSheet.Rows.Count > 0)
				{
					for ( int i = 0; i < _mainSheet.Rows.Count; i++ )
					{
						_mainSheet.Cells[i, _seqCol].Value = i+1;
					}

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
				}
			}
			else
				spd_main.ClearAll();
			vDt.Dispose();
			Grid_SetColor();
		}

		private void Grid_SetColor()
		{
			if(_mainSheet.Rows.Count > 1 )
			{
				int vColumnCount = _mainSheet.Columns.Count - 1;

				for (int i = 0 ; i < _mainSheet.Rows.Count ; i++)
				{
					string vOfferYN	= _mainSheet.Cells[i, _offerYNCol].Text;

					if (vOfferYN.StartsWith("Y"))
						_mainSheet.Cells[i, 1, i, vColumnCount].BackColor = Color.FromArgb(229, 228, 242);
					else if (vOfferYN.StartsWith("N"))
						_mainSheet.Cells[i, 1, i, vColumnCount].BackColor = Color.FromArgb(240, 247, 255);
					else
						_mainSheet.Cells[i, 1, i, vColumnCount].BackColor = Color.FromArgb(255, 255, 255);
				}
			}
		}

		private void SearchSizeInfo()
		{
			// 배열구조  =  0 : arg_factory,  1 : arg_req_no	2 : arg_req_ymd 	3 : arg_req_user
			//				4 : arg_req_dept  5 : arg_use_dept  6 : arg_req_reqson  7 : arg_rta_ymd
			//				8 : arg_ets_ymd   9 : arg_remark    10: arg_status		11: arg_offer_yn
			//				12: arg_offer_no

			string[] vProviso = GetSearchProviso();
			bool vExistData   = false;

			DataTable vDt = SELECT_SBP_REQUEST_SIZE_LIST(vProviso[0],  vProviso[1]);

			if (vDt.Rows.Count > 0)
			{
				Display_Spread_CrossTabByHead(vDt, 0, 1, 2);
				vDt.Dispose();

				// view point move
				for (int col = _startCol ; col < _sizeSheet.Columns.Count ; col++)
				{
					for (int row = 0 ; row < _sizeSheet.Rows.Count ; row++)
						if (!_sizeSheet.Cells[row, col].Text.Equals(""))
							vExistData = true;
				
					if (vExistData)
					{
						spd_size.ShowColumn(0, col, FarPoint.Win.Spread.HorizontalPosition.Left);
						break;
					}
				}

				_sizeSheet.Cells[0, 2].Formula = "SUM(" + _sizeStartColumnLabel + "1:" + _sizeEndColumnLabel + "1)";
				_sizeSheet.Cells[0, 1, 0, 2].BackColor = ClassLib.ComVar.RightYellow;

 

			}
		}

		// display size
		private void Display_Spread_CrossTabByHead(DataTable arg_dt, int arg_titleIndex, int arg_headIndex, int arg_dataIndex)
		{
			try
			{
				int vStartCol = _sizeSheet.FrozenColumnCount;
				int vEndCol = _sizeSheet.Columns.Count;
				int vRow = 0;
				int vCol = 0;
				string vHead = "";
				string vData = "";
				string vColumnData = "";

				spd_size.ClearAll();
				_sizeSheet.Rows.Count = 1;

				for (int i = vStartCol ; i < vEndCol ; i++)
				{
					if (i < 10)
						vColumnData += "0";

					vColumnData += i + "[" + _sizeSheet.ColumnHeader.Cells[0, i].Text + "]";
				}

				if (vColumnData.Equals(""))
					new Exception("Not Found Column Label Data");

				for (int vCount = 0 ; vCount < arg_dt.Rows.Count ; vCount++)
				{
					vHead = "[" + arg_dt.Rows[vCount].ItemArray[arg_headIndex].ToString() + "]";
					vData = arg_dt.Rows[vCount].ItemArray[arg_dataIndex].ToString();
					
					vCol = Convert.ToInt32(vColumnData.Substring(vColumnData.IndexOf(vHead) - 2, 2));
					_sizeSheet.Cells[vRow, vCol].Text = vData;

					_sizeSheet.Cells[vRow, 1].Text = arg_dt.Rows[vCount].ItemArray[arg_titleIndex].ToString();
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Diplay_CrossTabByHead");
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
					if (Etc_DataDuplicateCheck())
					{				
						_practicable = false;

						int row = spd_main.Add_Row(img_Action) ;
						spd_main.ActiveSheet.Cells[row, (int)ClassLib.TBSBP_REQUEST_TAIL.IxFACTORY].Value = cmb_factory.SelectedValue;

						spd_main.ActiveSheet.Cells[row, _reqSeqCol].Value	 = 0;
						spd_main.ActiveSheet.Cells[row, _styleCdCol].Value	 = "NONE";
						spd_main.ActiveSheet.Cells[row, _itemCdCol].Value	 = ClassLib.ComVar.Parameter_PopUp[0];
						spd_main.ActiveSheet.Cells[row, _itemNmCol].Value	 = ClassLib.ComVar.Parameter_PopUp[1];
						spd_main.ActiveSheet.Cells[row, _specCdCol].Value	 = ClassLib.ComVar.Parameter_PopUp[2];
						spd_main.ActiveSheet.Cells[row, _specNmCol].Value	 = ClassLib.ComVar.Parameter_PopUp[3];
						spd_main.ActiveSheet.Cells[row, _colorCdCol].Value	 = ClassLib.ComVar.Parameter_PopUp[4];
						spd_main.ActiveSheet.Cells[row, _colorNmCol].Value	 = ClassLib.ComVar.Parameter_PopUp[5];
						spd_main.ActiveSheet.Cells[row, _unitNmCol].Value    = ClassLib.ComVar.Parameter_PopUp[6];
						spd_main.ActiveSheet.Cells[row, _reqQty].Value	     = 0;
						spd_main.ActiveSheet.Cells[row, _pkQtyCol].Value	 = ClassLib.ComVar.Parameter_PopUp[8];
						spd_main.ActiveSheet.Cells[row, _obsIdCol].Value	 = _obsId;
						spd_main.ActiveSheet.Cells[row, _obsTypeCol].Value	 = _obsType.Equals("") ? "FT" : _obsType;
						spd_main.ActiveSheet.Cells[row, _reqReasonCol].Value = COM.ComFunction.Empty_Combo(cmb_reqReason, "");
						spd_main.ActiveSheet.Cells[row, _seqCol].Value	 = spd_main.ActiveSheet.Rows.Count > 1 ? int.Parse(spd_main.ActiveSheet.Cells[row-1, _seqCol].Value.ToString()) + 1 : 1;

 
						spd_main.ActiveSheet.Cells[row, _rtaCol].Value       = Convert.ToDateTime( dpick_rtaYmd.Text.ToString() );   
						//spd_main.ActiveSheet.Cells[row, _ets1Col].Value      = Convert.ToDateTime( dpick_estYmd.Text.ToString() );

		

						_practicable = true;
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool Etc_DataDuplicateCheck()
		{
			for ( int vRow = 0 ; vRow < spd_main.ActiveSheet.RowCount ; vRow++ )
			{
				if( spd_main.ActiveSheet.Cells[vRow, _styleCdCol].Text.Replace("-", "").Equals("NONE") &&
					spd_main.ActiveSheet.Cells[vRow, _itemCdCol].Text.Equals(ClassLib.ComVar.Parameter_PopUp[0]) &&
					spd_main.ActiveSheet.Cells[vRow, _specCdCol].Text.Equals(ClassLib.ComVar.Parameter_PopUp[2]) &&
					spd_main.ActiveSheet.Cells[vRow, _colorCdCol].Text.Equals(ClassLib.ComVar.Parameter_PopUp[4])) 
				{
					ClassLib.ComFunction.User_Message("The selected item is already exists.", "DataDuplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return false;
				}
			}

			return true;
		}

		/// <summary>
		/// Show_Tree_Popup : 데이터 입력하는 팝업을 Tree로 실행
		/// </summary>
		private void Show_Tree_Popup()
		{
			try
			{
				int[] vChecks = new int[]{_styleCdCol, _itemCdCol, _specCdCol, _colorCdCol};
				ClassLib.ComVar.Parameter_PopUp = new string[]{COM.ComFunction.Empty_Combo(cmb_factory, COM.ComVar.This_Factory), "P"};
				Pop_BC_Yield_Info vPop = new Pop_BC_Yield_Info(spd_main, vChecks);
				vPop._style = COM.ComFunction.Empty_Combo(cmb_style, "").Replace("-", "");
				vPop.ShowDialog();

				if ( ClassLib.ComVar.Parameter_PopUpTable.Rows.Count > 0 && vPop.DialogResult == DialogResult.OK)
				{
                    //vWaitPop = new Pop_BP_Purchase_Wait();
                    //Thread vCalcThread = new Thread(new ThreadStart(vWaitPop.Start));
                    //vCalcThread.Start();
					Etc_SizeCalculation();
					
					if (!txt_styleCd.ReadOnly)
					{
						txt_styleCd.Text = vPop._style;
						Txt_StyleCdKeyUpProcess();
					}
				}

				if (!_existSize)
				{
					for (int i = 3 ; i < _sizeSheet.ColumnCount ; i++)
					{
						_sizeSheet.Cells[0, i].Text = "";
					}

					txt_styleCd.ReadOnly	= false;
					cmb_style.ReadOnly		= false;
					btn_size.Enabled		= true;
					_sizeSheet.Columns[3, _sizeSheet.Columns.Count - 1].Locked = false;
				}
				else
				{
					txt_styleCd.ReadOnly	= true;
					cmb_style.ReadOnly		= true;
					btn_size.Enabled		= false;
					_sizeSheet.Columns[3, _sizeSheet.Columns.Count - 1].Locked = true;
				}
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
				// spd_size 의 내용을 SBT_TEMP_SIZE 에 저장
				bool vBoolSize = SAVE_SBT_TEMP_SIZE();

				// pop_up   의 내용을 SBT_TEMP_ITEM 에 저장
				bool vBoolTemp = SAVE_SBT_TEMP_ITEM();

				if(vBoolSize == true && vBoolTemp == true)
				{
					if (MyOraDB.Exe_Modify_Procedure() != null)
					{
						// 소요량 조회하는 프로시져 호출
						DataTable vDt = SELECT_SBT_TEMP_ITEM(cmb_factory.SelectedValue.ToString(),  COM.ComVar.This_User);
						if (vDt.Rows.Count > 0)
						{
							string vReason = COM.ComFunction.Empty_Combo(cmb_reqReason, "");

							for(int i = 0 ; i < vDt.Rows.Count ; i++)
							{
								int row = spd_main.Add_Row(img_Action) ;
								spd_main.ActiveSheet.Cells[row, _factoryCol].Value		= cmb_factory.SelectedValue;
								spd_main.ActiveSheet.Cells[row, _reqSeqCol].Value		= 0;
								spd_main.ActiveSheet.Cells[row, _itemCdCol].Value		= vDt.Rows[i][0];
								spd_main.ActiveSheet.Cells[row, _itemNmCol].Value		= vDt.Rows[i][1];
								spd_main.ActiveSheet.Cells[row, _specCdCol].Value		= vDt.Rows[i][2];
								spd_main.ActiveSheet.Cells[row, _specNmCol].Value		= vDt.Rows[i][3];
								spd_main.ActiveSheet.Cells[row, _colorCdCol].Value		= vDt.Rows[i][4];
								spd_main.ActiveSheet.Cells[row, _colorNmCol].Value		= vDt.Rows[i][5];
								spd_main.ActiveSheet.Cells[row, _reqQty].Value			= _existSize ? vDt.Rows[i][6] : 0;
								spd_main.ActiveSheet.Cells[row, _styleCdCol].Value      = vDt.Rows[i][7];
								spd_main.ActiveSheet.Cells[row, _componentCdCol].Value  = vDt.Rows[i][8];
								spd_main.ActiveSheet.Cells[row, _componentCdCol + 1].Value  = vDt.Rows[i][12];
								spd_main.ActiveSheet.Cells[row, _unitNmCol].Value		= vDt.Rows[i][9];
								spd_main.ActiveSheet.Cells[row, _modelNameCol].Value	= vDt.Rows[i][10];
								spd_main.ActiveSheet.Cells[row, _pkQtyCol].Value		= vDt.Rows[i][11];
								spd_main.ActiveSheet.Cells[row, _seqCol].Value			= spd_main.ActiveSheet.Rows.Count > 1 ? int.Parse(spd_main.ActiveSheet.Cells[row-1, _seqCol].Value.ToString()) + 1 : 1;
								spd_main.ActiveSheet.Cells[row, _reqReasonCol].Value	= vReason;
								spd_main.ActiveSheet.Cells[row, _obsIdCol].Value		= _obsId;
								spd_main.ActiveSheet.Cells[row, _obsTypeCol].Value		= _obsType.Equals("") ? "FT" : _obsType;
 

								spd_main.ActiveSheet.Cells[row, _rtaCol].Value       = Convert.ToDateTime( dpick_rtaYmd.Text.ToString() );   
								//spd_main.ActiveSheet.Cells[row, _ets1Col].Value      = Convert.ToDateTime( dpick_estYmd.Text.ToString() );


							}
						}
						else
							vDt.Dispose();
					}
				}

				_practicable = true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				ClassLib.ComVar.Parameter_PopUpTable.Dispose();
				//vWaitPop.Close();
			}
		}

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{
			// form initialize
			ClassLib.ComFunction.Init_Form_Control(this);

            lbl_MainTitle.Text = "Request for Outgoing";
            this.Text = "Request for Outgoing";
            ClassLib.ComFunction.SetLangDic(this);

			// grid set
			spd_main.Set_Spread_Comm("SBP_REQUEST_TAIL", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			spd_size.Set_Spread_Comm("SBP_REQUEST_SIZE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			
			//입력부 setup
			Init_Combo();
			
			// user define variable set
			_mainSheet				= spd_main.ActiveSheet;
			_sizeSheet				= spd_size.ActiveSheet;
			_cmbReqNoEventHandler   = new System.EventHandler(this.cmb_reqNo_SelectedValueChanged);
			_firstLoad              = false;

			// grid set
			_sizeSheet.Columns[0, _sizeSheet.Columns.Count - 1].AllowAutoSort = false;
			_cellTypes = new Hashtable();
            
			spd_size.Display_Size_ColHead_Req(COM.ComVar.This_Factory, 50, _startCol);
			_sizeSheet.Rows.Count = 1;
			_sizeStartColumnLabel = _sizeSheet.Columns[_sizeSheet.FrozenColumnCount].Label;
			_sizeEndColumnLabel = _sizeSheet.Columns[_sizeSheet.Columns.Count - 1].Label;
			_sizeSheet.Cells[0, 2].Formula = "SUM(" + _sizeStartColumnLabel + "1:" + _sizeEndColumnLabel + "1)";
			_sizeSheet.Cells[0, 1, 0, 2].BackColor = ClassLib.ComVar.RightYellow;

			this.Cmb_ReqNoSettingProcess();

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
					int    vCnt  = 0;
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

				// offer yn set    cmb_offerYn
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBC00");
				COM.ComCtl.Set_ComboList(vDt, cmb_offerYn, 1, 2, false,40,50);
				cmb_offerYn.SelectedIndex = 1;

				// cmb_reqUser
				vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory,"");
				ClassLib.ComCtl.Set_ComboList(vDt,cmb_reqUser, 1, 1, false, 0, 200);
				cmb_reqUser.SelectedValue = COM.ComVar.This_User;

				// use dept set   cmb_useDept
				// vDt = SELECT_CM_DEPT(ClassLib.ComVar.This_Factory," ");
				// COM.ComCtl.Set_ComboList(vDt, cmb_useDept, 0, 1, false);
				// cmb_useDept.SelectedValue = COM.ComVar.This_Dept;

				// cmb_reqDivision
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBP06");
				COM.ComCtl.Set_ComboList(vDt, cmb_reqDivision, 1, 2, false);
				cmb_reqDivision.SelectedIndex = 1;

				// cmb_reqReason
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxReqReason);
				COM.ComCtl.Set_ComboList(vDt, cmb_reqReason, 1, 2, false);
				cmb_reqReason.SelectedIndex = 0;

				// cmb_calcType
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBP09");
				COM.ComCtl.Set_ComboList(vDt, cmb_calcType, 1, 2, false);
				cmb_calcType.SelectedIndex = 1;
				
				// factory set
				vDt = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, 40,125);
				cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
				vDt.Dispose();

				//DepartmentComboSetting();

				tbtn_Create.Enabled = false;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
		}

		private void DepartmentComboSetting()
		{
			// line
			DataTable vDt = FlexMRP.ClassLib.ComFunction.Select_Work_Line_List(cmb_factory.SelectedValue.ToString());
			COM.ComCtl.Set_ComboList(vDt, cmb_line, 0, 1, false);
			cmb_line.SelectedIndex = 0;
			vDt.Dispose();

			//	department
			DataTable vDt1 = FlexPurchase.ClassLib.ComFunction.Select_Opcd_List(COM.ComFunction.Empty_Combo(cmb_factory, ""));
			DataTable vDt2 = SELECT_CM_DEPT(ClassLib.ComVar.This_Factory," ");

			IEnumerator vEnum = vDt2.Rows.GetEnumerator();
			
			while (vEnum.MoveNext())
			{
				DataRow vRow = (DataRow)vEnum.Current;
				vDt1.Rows.Add(vRow.ItemArray);
			}

			COM.ComCtl.Set_ComboList(vDt1, cmb_reqDept, 0, 1, false);
			cmb_reqDept.SelectedValue = COM.ComVar.This_Dept;
			vDt1.Dispose();
			vDt2.Dispose();
		}

		private void ClearNotPk()
		{
			try
			{
				ClearNotPkInfo();
				spd_size.ClearAll();
				spd_size.ActiveSheet.RowCount = 1;
				_sizeSheet.Cells[0, 2].Formula = "SUM(" + _sizeStartColumnLabel + "1:" + _sizeEndColumnLabel + "1)";
				_sizeSheet.Cells[0, 1, 0, 2].BackColor = ClassLib.ComVar.RightYellow;
				spd_main.ClearAll();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "New_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Tbtn_NewProcess()
		{
			try
			{
				ClearHeadInfo();
				spd_size.ClearAll();
				spd_size.ActiveSheet.RowCount = 1;
				_sizeSheet.Cells[0, 2].Formula = "SUM(" + _sizeStartColumnLabel + "1:" + _sizeEndColumnLabel + "1)";
				_sizeSheet.Cells[0, 1, 0, 2].BackColor = ClassLib.ComVar.RightYellow;

				cmb_reqNo.SelectedIndex = -1;
				//spd_main.ClearAll();
				LockProgram = false;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "New_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Tbtn_SearchProcess(bool arg_bool)
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				if (arg_bool)
				{
					_practicable = false;
					_doSearch	 = false;

					this.SearchHeadInfo();
					this.SearchTailInfo();
					this.SearchSizeInfo();

					if (txt_status.Text.Equals(ClassLib.ComVar.Status_CONFIRM))
						this.LockProgram = true;
					else
						this.LockProgram = false;
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
				_practicable = true;
				_doSearch	 = true;
			}
		}

		private void Tbtn_SaveProcess()
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				string vReqNo			= "";
				string vSaveDivision	= "";
				bool vDataSetClear		= true;

				if (cmb_reqNo.SelectedIndex <= -1)
				{
					string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
					string vDocDivision = ClassLib.ComVar.REQUEST;
					string vDocType = COM.ComFunction.Empty_Combo(cmb_reqDivision, "");
					string vDate = dpick_reqYmd.Text.Replace("-", "");
					string vUser = COM.ComVar.This_User;

					DataTable vDt = ClassLib.ComFunction.SELECT_DOCUMENT_NO(vFactory, vDocDivision, vDocType, vDate, vUser);

					vReqNo = vDt.Rows[0].ItemArray[0].ToString();
					vSaveDivision = ClassLib.ComVar.Insert;

					// SIZE 저장 - 신규일때만 한번 저장 ( 이후 수정 불가 )
					if (!SAVE_SBP_REQUEST_SIZE(vSaveDivision, vReqNo, vDataSetClear))
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						return;
					}
				}
				else
				{
					vReqNo = cmb_reqNo.SelectedValue.ToString();
					vSaveDivision = ClassLib.ComVar.Update;
					vDataSetClear = false;
				}

				// HEAD 저장
				if (!SAVE_SBP_REQUEST_HEAD(vSaveDivision, vReqNo, !vDataSetClear))
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}

				// TAIL 저장
				for (int i = 0 ; i < _mainSheet.Rows.Count ; i++)
				{
					_mainSheet.Cells[i, _reqNoCol].Value = vReqNo;
				}
				
				if (!MyOraDB.Save_Spread_Ready("PKG_SBP_REQUEST_TAIL.SAVE_SBP_REQUEST_TAIL", spd_main, false))
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}
				
				// 저장 완료
				if (MyOraDB.Exe_Modify_Procedure() != null)
				{
					//_doSearch = false;
					Cmb_ReqNoSettingProcess();
					cmb_reqNo.SelectedValue = vReqNo;
					ClassLib.ComFunction.User_Message("Save Complete", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
					//spd_main.Refresh_Division();
					//Grid_SetColor();

					LockProgram = false;
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
					return;
				}
				
				ClassLib.ComFunction.User_Message("Save Fail", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				//_doSearch = true;
			}
		}

		private void Tbtn_DeleteProcess()
		{
			try
			{
				string vReqNo = COM.ComFunction.Empty_Combo(cmb_reqNo, "");
				SAVE_SBP_REQUEST_HEAD(ClassLib.ComVar.Delete, vReqNo, true);
				MyOraDB.Exe_Modify_Procedure();

				ClearHeadInfo();
				this.Cmb_ReqNoSettingProcess();
				ClearNotPk();
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

		private void Tbtn_ConfirmProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				string vReqNo			= cmb_reqNo.SelectedValue.ToString();
				string vSaveDivision	= ClassLib.ComVar.Update;;

				// HEAD 저장
				if (!SAVE_SBP_REQUEST_HEAD(vSaveDivision, vReqNo, true))
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}

				// TAIL 저장
				for (int i = 0 ; i < _mainSheet.Rows.Count ; i++)
				{
					_mainSheet.Cells[i, _reqNoCol].Value = vReqNo;
				}
				
				if (!MyOraDB.Save_Spread_Ready("PKG_SBP_REQUEST_TAIL.SAVE_SBP_REQUEST_TAIL", spd_main, false))
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}

				// Confirm
				if (!SAVE_SBP_REQUEST_CONFIRM())
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}
				
				// 저장 완료
				if (MyOraDB.Exe_Modify_Procedure() != null)
				{
					spd_main.Refresh_Division();
					txt_status.Text = ClassLib.ComVar.Status_CONFIRM;
					this.LockProgram = true;
					ClassLib.ComFunction.User_Message("Confirm Complete", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void Cmb_ReqNoSettingProcess()
		{
			try
			{
				if (_practicable)
				{
					cmb_reqNo.SelectedValueChanged -= _cmbReqNoEventHandler;

					DataTable vDt = this.SELECT_SBP_REQUEST_NO_LIST();
					COM.ComCtl.Set_ComboList(vDt, cmb_reqNo, 0, 0, false, false);
					cmb_reqNo.SelectedIndex = -1;
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
				if (_doSearch)
				{
					if (cmb_reqNo.SelectedIndex < 0)
						Tbtn_SearchProcess(false);
					else
						Tbtn_SearchProcess(true);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void  Cmb_OfferYnSettingProcess()
		{
			try
			{
				if(this.cmb_offerYn.SelectedValue.ToString() == "Y")
				{
					this.btn_searchOffer.Enabled = true;
				}
				else
				{
					this.txt_offerNo.Text    = "";
					this.btn_searchOffer.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		private void Btn_SearchReqClickProcess()
		{
			Pop_BP_Request pop_bp_request     = new Pop_BP_Request();
			
			COM.ComVar.Parameter_PopUp		= new string[1];
			COM.ComVar.Parameter_PopUp[0]	= cmb_factory.SelectedValue.ToString();


			if (pop_bp_request.ShowDialog() == DialogResult.OK)
			{
//				0 cmb_factory, 1 vReqNo,  2 vReqYmd, 3  vReqUse,  4  vReqDept, 5 vUseDept, 
//				6 vReqReason,  7 vRtaYmd, 8 vEstYmd, 9 vStatus,  10 vOfferYn, 11 vOfferNo

				_practicable = false;
				cmb_factory.SelectedValue	= COM.ComVar.Parameter_PopUp[0];
				dpick_reqYmd.Value			= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[2]);
				_practicable = true;

				cmb_reqUser.SelectedValue	= COM.ComVar.Parameter_PopUp[3];
				cmb_reqDept.SelectedValue	= COM.ComVar.Parameter_PopUp[4];
				cmb_line.SelectedValue		= COM.ComVar.Parameter_PopUp[5];
				cmb_reqReason.SelectedValue = COM.ComVar.Parameter_PopUp[6];
				dpick_rtaYmd.Value			= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[7]);
				dpick_estYmd.Value			= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[8]);
				txt_status.Text				= COM.ComVar.Parameter_PopUp[9];
				cmb_offerYn.SelectedValue	= COM.ComVar.Parameter_PopUp[10] == "" ? "N" : "Y";
				txt_offerNo.Text			= COM.ComVar.Parameter_PopUp[11];				
				
				Cmb_ReqNoSettingProcess();

				cmb_reqNo.SelectedValue		= COM.ComVar.Parameter_PopUp[1];

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}

			pop_bp_request.Dispose();
		}


		private void Btn_SearchOfferClickProcess()
		{
			if(this.cmb_reqNo.SelectedIndex > -1)
			{
				Pop_BP_Request_Offer pop_bp_request_offer     = new Pop_BP_Request_Offer();
			
				COM.ComVar.Parameter_PopUp		= new string[2];
				COM.ComVar.Parameter_PopUp[0]	= cmb_factory.SelectedValue.ToString();
				COM.ComVar.Parameter_PopUp[1]   = txt_offerNo.Text;


				if (pop_bp_request_offer.ShowDialog() == DialogResult.OK)
				{
					_practicable = false;
					cmb_factory.SelectedValue	= COM.ComVar.Parameter_PopUp[0];
					this.txt_offerNo.Text		= COM.ComVar.Parameter_PopUp[1];
					_practicable = true;
				}

				pop_bp_request_offer.Dispose();
			}
			else
			{
				ClassLib.ComFunction.User_Message("Select Request No");
			}
		}

		private void Btn_DeleteProcess()
		{
			spd_main.Delete_Row(img_Action);
		}

		#region 컨텍스트 메뉴

		private void Mnu_AutoCalculation(int arg_kind)
		{
			CellRange[] vSel = _mainSheet.GetSelections();

			foreach (CellRange vRange in vSel)
			{
				for (int vRow = vRange.Row ; vRow < vRange.Row + vRange.RowCount ; vRow++)
				{
					int vQty = Get_ConvertedNumber(vRow, arg_kind);
					if (vQty != -1)
					{
						_mainSheet.Cells[vRow, _reqQty].Value = vQty;
						spd_main.Update_Row(vRow, img_Action);
					}
				}
			}
		}

		private int Get_ConvertedNumber(int arg_row, int arg_kind)
		{
			int vResult = -1;
			double vAdviceQty = Convert.ToDouble(_mainSheet.Cells[arg_row, _reqQty].Value);

			switch (arg_kind)
			{
				case 1:
					vResult = (int)Math.Ceiling(vAdviceQty);
					break;
				case 2:
					vResult = (int)Math.Round(vAdviceQty);
					break;
				case 3:
					vResult = (int)vAdviceQty;
					break;
				case 4:
					vResult = (int)Math.Floor(vAdviceQty);
					break;
				case 5:
					int vPKQty = Convert.ToInt32(_mainSheet.Cells[arg_row, _pkQtyCol].Value);

					if ( vPKQty == 0 )	return -1;

					double vTemp = ((int)(vAdviceQty / vPKQty)) * vPKQty;

					vResult = (int)vTemp;

					if ( vTemp < vAdviceQty )
						vResult = (int)(vTemp + vPKQty);
					break;
			}

			return vResult;
		}

		#endregion

		#region 프로그램 속성

		private bool LockProgram
		{
			set
			{		
				tbtn_Save.Enabled		= !value;
				tbtn_Delete.Enabled		= !value;
				tbtn_Confirm.Enabled	= !value;

				btn_Tree.Enabled		= !value;
				btn_Insert.Enabled		= !value;
				btn_delete.Enabled		= !value;
				btn_recover.Enabled		= !value;

				if (cmb_reqNo.SelectedIndex > -1)
				{
					_sizeSheet.Columns[3, _sizeSheet.Columns.Count - 1].Locked = true;
					txt_styleCd.ReadOnly	= true;
					cmb_style.ReadOnly		= true;
					btn_size.Enabled		= false;
				}
				else
				{
					_sizeSheet.Columns[3, _sizeSheet.Columns.Count - 1].Locked = false;
					txt_styleCd.ReadOnly	= false;
					cmb_style.ReadOnly		= false;
					btn_size.Enabled		= true;
				}

				if (_mainSheet.RowCount > 0)
				{
					if (txt_status.Text.Equals(ClassLib.ComVar.Status_CONFIRM))
						_mainSheet.Rows[0, _mainSheet.RowCount - 1].Locked = true;
					else
						_mainSheet.Rows[0, _mainSheet.RowCount - 1].Locked = false;
				}
			}
		}

		#endregion

		#region Validate Check

		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			// 공통 체크
			if (cmb_factory.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Factory", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_factory.Focus();
				return false;
			}

			if (cmb_reqNo.SelectedIndex <= -1 && ( arg_type == ClassLib.ComVar.Validate_Search || arg_type == ClassLib.ComVar.Validate_Delete || arg_type == ClassLib.ComVar.Validate_Confirm) )
			{
				ClassLib.ComFunction.User_Message("Select Request No", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_reqNo.Focus();
				return false;
			}

			if (_mainSheet.RowCount <= 0 && (arg_type == ClassLib.ComVar.Validate_Save || arg_type == ClassLib.ComVar.Validate_Delete || arg_type == ClassLib.ComVar.Validate_Confirm))
			{
				ClassLib.ComFunction.User_Message("Empty Data", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			C1.Win.C1List.C1Combo[] vCombo = new C1.Win.C1List.C1Combo[]{cmb_reqUser, cmb_reqDept, cmb_reqReason};

			// 부분별 체크 (Search, Save, Delete, Confirm..)
			switch (arg_type)
			{
				case ClassLib.ComVar.Validate_Search:

					break;
				case ClassLib.ComVar.Validate_Save:	
					if (!FlexPurchase.ClassLib.ComFunction.Essentiality_check(vCombo, null))
						return false;
					break;
				case ClassLib.ComVar.Validate_Delete:

					break;
				case ClassLib.ComVar.Validate_Confirm:
					if (txt_status.Text.Equals(ClassLib.ComVar.Status_CONFIRM))
						return false;
					if (!FlexPurchase.ClassLib.ComFunction.Essentiality_check(vCombo, null))
						return false;
//					if (ClassLib.ComFunction.EmptyCellCheck_SSP(spd_main, 1, (int)ClassLib.TBSBP_REQUEST_TAIL.IxETS2_YMD - 1))
//						return false;
					if (ClassLib.ComFunction.EmptyCellCheck_SSP(spd_main, _reqReasonCol, _reqReasonCol))
						return false;
					for (int vRow = 0 ; vRow < _mainSheet.Rows.Count ; vRow++)
					{
						double vData = Convert.ToDouble(_mainSheet.Cells[vRow, _reqQty].Value);
						if (vData < 1)
						{
							ClassLib.ComFunction.User_Message("Exist Zero or Empty Data : " + vRow + " Row", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							spd_main.Set_CellPosition(vRow, _reqQty);
							return false;
						}
					}

					break;
				case _validate_tree :
					if (!FlexPurchase.ClassLib.ComFunction.Essentiality_check(vCombo, null))
						return false;

					string vTemp = _sizeSheet.Cells[0, 2].Text.Equals("") ? "0" : _sizeSheet.Cells[0, 2].Text;

					if( Convert.ToInt32(vTemp.Replace(",", "")) <= 0 )
					{
						for (int i = 3 ; i < _sizeSheet.ColumnCount ; i++)
						{
							_sizeSheet.Cells[0, i].Value = 1;
						}
						_existSize = false;
					}
					else
					{
						_existSize = true;
					}
					break;
				case _validate_insert :
					if (!FlexPurchase.ClassLib.ComFunction.Essentiality_check(vCombo, null))
						return false;
					break;
			}

			return true;
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

		public DataTable SELECT_CM_DEPT(string arg_factory, string arg_dept)
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
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_dept;
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}

 		
		/// <summary>
		/// PKG_SBS_SHIPPING_HEAD : 헤더 정보 찾기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_lot_no">Lot No</param>
		/// <param name="arg_ship_ymd">선적일</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBS_SHIPPING_HEAD_INFO(string arg_factory, string arg_lot_no, string arg_ship_ymd)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_HEAD.SELECT_SBS_SHIPPING_HEAD_INFO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_YMD";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_lot_no;
			MyOraDB.Parameter_Values[2] = arg_ship_ymd;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		
		/// <summary>
		/// PKG_SBP_REQUEST_HEAD : 요구 번호 리스트 찾기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_req_ymd">청구일</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_REQUEST_NO_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_REQUEST_HEAD.SELECT_SBP_REQUEST_NO_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";	
			MyOraDB.Parameter_Name[1] = "ARG_REQ_YMD";
			MyOraDB.Parameter_Name[2] = "ARG_REQ_USER";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");	
			MyOraDB.Parameter_Values[1] = dpick_reqYmd.Text.Replace("-", "");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_reqUser, "");
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBP_REQUEST_HEAD : 헤더 정보 찾기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_req_no">청구 번호</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_REQUEST_HEAD(string arg_factory, string arg_req_no)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_REQUEST_HEAD.SELECT_SBP_REQUEST_HEAD";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_req_no;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// PKG_SBP_REQUEST_HEAD : 헤더 정보 찾기
		/// </summary>
		/// <param name="vItemCd">item_cd</param>
		/// <param name="vSpecCd">spec_cd</param>
		/// <param name="vColorCd">color_cd</param>
		/// <param name="vFactory">factory</param>
		/// <param name="vStyle">style</param>
		/// SELECT_SBC_REQUEST_QTY(vItemCd, vSpecCd, vColorCd,vFactory,vStyle);

		/// <returns>DataTable</returns>
		public DataTable SELECT_SBC_REQUEST_QTY(string arg_factory, string arg_item_cd, string arg_spec_cd, string arg_color_cd,  string arg_style)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_REQUEST_SIZE.SELECT_SBC_REQUEST_QTY";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[2] = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[3] = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[4] = "ARG_STYLE";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_item_cd;
			MyOraDB.Parameter_Values[2] = arg_spec_cd;
			MyOraDB.Parameter_Values[3] = arg_color_cd;
			MyOraDB.Parameter_Values[4] = arg_style;
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}



		/// <summary>
		/// PKG_SBS_SHIPPING_TAIL : 자재별(리스트) 찾기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_ship_no">선적번호</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_REQUEST_TAIL_LIST(string arg_factory, string arg_req_no)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_REQUEST_TAIL.SELECT_SBP_REQUEST_TAIL_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_req_no;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBP_REQUEST_SIZE : 
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_req_no">청구번호</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_REQUEST_SIZE_LIST(string arg_factory, string arg_req_no)
		{
			// SELECT_SBS_SHIPPING_SIZE_LIST 참고
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_REQUEST_SIZE.SELECT_SBP_REQUEST_SIZE_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_REQ_NO";
			MyOraDB.Parameter_Name[2]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_req_no;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// PKG_SBT_TEMP_ITEM :  SELECT_SBT_TEMP_ITEM
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_req_no">청구번호</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBT_TEMP_ITEM(string arg_factory, string arg_action_user)
		{
			// SELECT_SBS_SHIPPING_SIZE_LIST 참고
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			if (cmb_calcType.SelectedIndex == 0)
			{
				MyOraDB.Process_Name = "PKG_SBT_TEMP_ITEM.SELECT_SBT_TEMP_ITEM";
			}
			else
			{
				MyOraDB.Process_Name = "PKG_SBT_TEMP_ITEM.SELECT_SBT_TEMP_ITEM_ORDER";
			}

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_ACTION_USER";
			MyOraDB.Parameter_Name[2]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_action_user;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// SAVE_SBP_REQUEST_HEAD : 헤더 정보 저장
		/// </summary>
		public bool SAVE_SBP_REQUEST_HEAD(string arg_division, string arg_reqNo, bool arg_clear)
		{
            try
            {
                MyOraDB.ReDim_Parameter(19);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SBP_REQUEST_HEAD.SAVE_SBP_REQUEST_HEAD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_REQ_NO";
                MyOraDB.Parameter_Name[3] = "ARG_REQ_YMD";
                MyOraDB.Parameter_Name[4] = "ARG_REQ_USER";
                MyOraDB.Parameter_Name[5] = "ARG_REQ_DEPT";
                MyOraDB.Parameter_Name[6] = "ARG_USE_DEPT";
                MyOraDB.Parameter_Name[7] = "ARG_REQ_DIVISION";
                MyOraDB.Parameter_Name[8] = "ARG_REQ_REASON";
                MyOraDB.Parameter_Name[9] = "ARG_RTA_YMD";
                MyOraDB.Parameter_Name[10] = "ARG_ETS_YMD";
                MyOraDB.Parameter_Name[11] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[12] = "ARG_STATUS";
                MyOraDB.Parameter_Name[13] = "ARG_OFFER_YN";
                MyOraDB.Parameter_Name[14] = "ARG_OFFER_NO";
                MyOraDB.Parameter_Name[15] = "ARG_PO_ID";
                MyOraDB.Parameter_Name[16] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[17] = "ARG_PO_TYPE";
                MyOraDB.Parameter_Name[18] = "ARG_UPD_USER";


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
                MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[17] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[18] = (int)OracleType.VarChar;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_division;
                MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_factory, "");
                MyOraDB.Parameter_Values[2] = arg_reqNo;
                MyOraDB.Parameter_Values[3] = dpick_reqYmd.Text.Replace("-", "");
                MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(this.cmb_reqUser, "");
                MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_Combo(this.cmb_reqDept, "");
                MyOraDB.Parameter_Values[6] = COM.ComFunction.Empty_Combo(this.cmb_line, "");
                MyOraDB.Parameter_Values[7] = COM.ComFunction.Empty_Combo(this.cmb_reqDivision, "");
                MyOraDB.Parameter_Values[8] = COM.ComFunction.Empty_Combo(this.cmb_reqReason, "");
                MyOraDB.Parameter_Values[9] = dpick_rtaYmd.Text.Replace("-", "");
                MyOraDB.Parameter_Values[10] = dpick_estYmd.Text.Replace("-", "");
                MyOraDB.Parameter_Values[11] = COM.ComFunction.Empty_TextBox(this.txt_remark, "");
                MyOraDB.Parameter_Values[12] = COM.ComFunction.Empty_TextBox(this.txt_status, "") == "" ? "S" : txt_status.Text.Substring(0, 1);
                MyOraDB.Parameter_Values[13] = COM.ComFunction.Empty_Combo(this.cmb_offerYn, "");
                MyOraDB.Parameter_Values[14] = COM.ComFunction.Empty_TextBox(this.txt_offerNo, "");
                MyOraDB.Parameter_Values[15] = COM.ComFunction.Empty_TextBox(this.txt_po, "");
                MyOraDB.Parameter_Values[16] = COM.ComFunction.Empty_Combo(this.cmb_style, "").Replace("-", "");
                MyOraDB.Parameter_Values[17] = "";
                MyOraDB.Parameter_Values[18] = COM.ComVar.This_User;

                MyOraDB.Add_Modify_Parameter(arg_clear);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SAVE_SBP_REQUEST_HEAD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
		}

		/// <summary>
		/// PKG_SBP_REQUEST_SIZE : SIZE 저장
		/// </summary>
		public bool SAVE_SBP_REQUEST_SIZE(string arg_division, string arg_reqNo, bool arg_clear)
		{
			try
			{
				MyOraDB.ReDim_Parameter(6);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_REQUEST_SIZE.SAVE_SBP_REQUEST_SIZE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[3] = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[4] = "ARG_CS_QTY";
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;

				//04.DATA 정의
				ArrayList vList = new ArrayList(_sizeSheet.ColumnCount);

				string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
				string vUpdUser = COM.ComVar.This_User;

				for (int vCol = _sizeSheet.FrozenColumnCount ; vCol < _sizeSheet.ColumnCount ; vCol++)
				{
					if (!_sizeSheet.Cells[0, vCol].Text.Equals(""))
					{
						vList.Add(arg_division);
						vList.Add(vFactory);
						vList.Add(arg_reqNo);
						vList.Add(_sizeSheet.ColumnHeader.Cells[0, vCol].Text);
						vList.Add(_sizeSheet.Cells[0, vCol].Text.Replace(",", ""));
						vList.Add(vUpdUser);
					}
				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));
				MyOraDB.Add_Modify_Parameter(arg_clear);

				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "SAVE_SBP_REQUEST_SIZE", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				return false;
			}
		}



		public bool SAVE_SBT_TEMP_ITEM()
		{
			try
			{
				MyOraDB.ReDim_Parameter(8);

				//01.PROCEDURE명
				MyOraDB.Process_Name    = "PKG_SBT_TEMP_ITEM.SAVE_SBT_TEMP_ITEM";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_ACTION_USER";
				MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
				MyOraDB.Parameter_Name[4] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[5] = "ARG_SPEC_CD";
				MyOraDB.Parameter_Name[6] = "ARG_COLOR_CD";
				MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;

				ArrayList vList = new ArrayList();

				//04.DATA 정의

				vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[0][7].ToString());
				vList.Add(COM.ComVar.This_User);
				vList.Add(ClassLib.ComVar.Delete);
				vList.Add("");
				vList.Add("");
				vList.Add("");
				vList.Add("");
				vList.Add("");

				for(int i = 0; i < ClassLib.ComVar.Parameter_PopUpTable.Rows.Count ; i++)
				{
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][7].ToString());
					vList.Add(COM.ComVar.This_User);
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][8].ToString());
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][9].ToString());
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][0].ToString());
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][2].ToString());
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][4].ToString());
					vList.Add(COM.ComVar.This_User);
				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(false);
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message, "SAVE_SBT_TEMP_ITEM", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				return false;
			}
		}

		/// <summary>
		/// PKG_SBT_TEMP_SIZE : size 정보 임시 테이블에 저장
		/// </summary>
		public bool SAVE_SBT_TEMP_SIZE()
		{
			try
			{
				MyOraDB.ReDim_Parameter(6);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBT_TEMP_SIZE.SAVE_SBT_TEMP_SIZE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[2] = "ARG_CS_QTY";
				MyOraDB.Parameter_Name[3] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[4] = "ARG_ACTION_USER";
				MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;

				//04.DATA 정의
				ArrayList vList = new ArrayList();

				string vFactory = cmb_factory.SelectedValue.ToString();
				string vUpdUser = COM.ComVar.This_User;
				string vStyleCode = ClassLib.ComVar.Parameter_PopUpTable.Rows[0][8].ToString();


				vList.Add(ClassLib.ComVar.Delete);
				vList.Add("");
				vList.Add("");
				vList.Add(vFactory);
				vList.Add(vUpdUser);
				vList.Add(vStyleCode);

				for (int vCol = _sizeSheet.FrozenColumnCount ; vCol < _sizeSheet.ColumnCount ; vCol++)
				{
					if (!_sizeSheet.Cells[0, vCol].Text.Equals(""))
					{
						vList.Add(ClassLib.ComVar.Insert);
						vList.Add(_sizeSheet.ColumnHeader.Cells[0, vCol].Text);
						vList.Add(_sizeSheet.Cells[0, vCol].Text.Replace(",", ""));
						vList.Add(vFactory);
						vList.Add(vUpdUser);
						vList.Add(vStyleCode);
					}															  
				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(true);
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show( ex.Message, "SAVE_SBT_TEMP_SIZE", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				return false;
			}
		}

		/// <summary>
		/// Tbtn_ConfirmProcess : request confirm
		/// </summary>
		public bool SAVE_SBP_REQUEST_CONFIRM()
		{
			try
			{
				MyOraDB.ReDim_Parameter(3);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_REQUEST_HEAD.SAVE_SBP_REQUEST_CONFIRM";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_reqNo, "");
				MyOraDB.Parameter_Values[2] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(false);

				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show( ex.Message, "SAVE_SBP_REQUEST_CONFIRM", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				return false;
			}
		}

		#endregion

	}
}
