using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using FlexPurchase.ClassLib;

namespace FlexPurchase.Shipping
{
	public class Form_BS_Shipping_Request : COM.PCHWinForm.Form_Top
	{
		#region 디자이너에서 사용할 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnl_btn;
		private System.Windows.Forms.ContextMenu ctx_tail;
		private System.Windows.Forms.Label btn_BCCancel;
		private System.Windows.Forms.Label btn_BCCreate;
		private System.Windows.Forms.Label btn_PKCreate;
		private System.Windows.Forms.Label btn_PKCancel;
		private System.Windows.Forms.MenuItem mnu_Select;
		private System.Windows.Forms.MenuItem mnu_Data;
		private System.Windows.Forms.MenuItem mnu_AllSelect;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label btn_delete;
		private System.Windows.Forms.Label btn_insert;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.TextBox txt_packing;
		private System.Windows.Forms.TextBox txt_remarks;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.Label lbl_packing;
		private System.Windows.Forms.TextBox txt_status;
		private System.Windows.Forms.Label btn_headSearch;
		private System.Windows.Forms.DateTimePicker dpick_shipYmd;
		private System.Windows.Forms.Label lbl_remarks;
		private System.Windows.Forms.Label lbl_shipYmd;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.Label lbl_shipNo;
		private C1.Win.C1List.C1Combo cmb_shipNo;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnu_merge;
		private System.Windows.Forms.MenuItem mnu_partial;
		private COM.FSP fgrid_shipping;
		private System.Windows.Forms.MenuItem mnu_rate;
		private System.Windows.Forms.MenuItem mnu_mergeCancel;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.Label btn_barcode;
		private System.Windows.Forms.Label btn_packing;

		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB	= new COM.OraDB();
		private bool _practicable	= false;
		private int _count			= 1;
		private int _nextSeq		= 1;
		private Hashtable _cellCombo = null;

		private int _packingNoCol		= (int)ClassLib.TBSBS_SHIPPING_REQUEST.IxPK_NO;
		private int _CTCol				= (int)ClassLib.TBSBS_SHIPPING_REQUEST.IxCT_QTY;
		private int _packingNoFromCol	= (int)ClassLib.TBSBS_SHIPPING_REQUEST.IxPK_NO_FROM;
		private int _packingNoToCol		= (int)ClassLib.TBSBS_SHIPPING_REQUEST.IxPK_NO_TO;
		private int _packingUnitQtyCol	= (int)ClassLib.TBSBS_SHIPPING_REQUEST.IxPK_UNIT_QTY;
		private int _statusCol			= (int)ClassLib.TBSBS_SHIPPING_REQUEST.IxSTATUS;
		private int _shipYNCol			= (int)ClassLib.TBSBS_SHIPPING_REQUEST.IxSHIP_YN;
		private int _shipQtyCol			= (int)ClassLib.TBSBS_SHIPPING_REQUEST.IxSHIP_QTY;
		private int _purPriceCol		= (int)ClassLib.TBSBS_SHIPPING_REQUEST.IxPUR_PRICE;
		private int _cbdPriceCol		= (int)ClassLib.TBSBS_SHIPPING_REQUEST.IxCBD_PRICE;
		private int _custCdCol			= (int)ClassLib.TBSBS_SHIPPING_REQUEST.IxCUST_CD;
		private int _remarksCol			= (int)ClassLib.TBSBS_SHIPPING_REQUEST.IxREMARKS;
		private int _requestReasonCol   = (int)ClassLib.TBSBS_SHIPPING_REQUEST.IxREQUEST_REASON;

	
        private string _save = "S", _packing = "P", _barcode = "B", _invoice = "I", _trade = "T";
        private const int _validate_createPK = 10, _validate_createBC = 20, _validate_trade = 40;
        private const int _validate_cancelPK = 50, _validate_cancelBC = 60;


		private System.Windows.Forms.Panel pnl_Search;
        private Label btn_invoice;
		private const int _validate_ContextMenu = 100;

		#endregion

		#region 생성자 / 소멸자

		public Form_BS_Shipping_Request()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BS_Shipping_Request));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.btn_invoice = new System.Windows.Forms.Label();
            this.btn_packing = new System.Windows.Forms.Label();
            this.btn_barcode = new System.Windows.Forms.Label();
            this.txt_packing = new System.Windows.Forms.TextBox();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_packing = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.btn_headSearch = new System.Windows.Forms.Label();
            this.dpick_shipYmd = new System.Windows.Forms.DateTimePicker();
            this.lbl_remarks = new System.Windows.Forms.Label();
            this.lbl_shipYmd = new System.Windows.Forms.Label();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.lbl_shipNo = new System.Windows.Forms.Label();
            this.cmb_shipNo = new C1.Win.C1List.C1Combo();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Label();
            this.btn_recover = new System.Windows.Forms.Label();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.fgrid_shipping = new COM.FSP();
            this.pnl_btn = new System.Windows.Forms.Panel();
            this.btn_BCCancel = new System.Windows.Forms.Label();
            this.btn_BCCreate = new System.Windows.Forms.Label();
            this.btn_PKCreate = new System.Windows.Forms.Label();
            this.btn_PKCancel = new System.Windows.Forms.Label();
            this.ctx_tail = new System.Windows.Forms.ContextMenu();
            this.mnu_AllSelect = new System.Windows.Forms.MenuItem();
            this.mnu_Select = new System.Windows.Forms.MenuItem();
            this.mnu_Data = new System.Windows.Forms.MenuItem();
            this.mnu_rate = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnu_merge = new System.Windows.Forms.MenuItem();
            this.mnu_mergeCancel = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnu_partial = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipNo)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_shipping)).BeginInit();
            this.pnl_btn.SuspendLayout();
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
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.panel2);
            this.c1Sizer1.Controls.Add(this.pnl_Search);
            this.c1Sizer1.Controls.Add(this.pnl_btn);
            this.c1Sizer1.GridDefinition = resources.GetString("c1Sizer1.GridDefinition");
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 584);
            this.c1Sizer1.TabIndex = 30;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.btn_invoice);
            this.pnl_head.Controls.Add(this.btn_packing);
            this.pnl_head.Controls.Add(this.btn_barcode);
            this.pnl_head.Controls.Add(this.txt_packing);
            this.pnl_head.Controls.Add(this.txt_remarks);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_status);
            this.pnl_head.Controls.Add(this.lbl_packing);
            this.pnl_head.Controls.Add(this.txt_status);
            this.pnl_head.Controls.Add(this.btn_headSearch);
            this.pnl_head.Controls.Add(this.dpick_shipYmd);
            this.pnl_head.Controls.Add(this.lbl_remarks);
            this.pnl_head.Controls.Add(this.lbl_shipYmd);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.lbl_shipNo);
            this.pnl_head.Controls.Add(this.cmb_shipNo);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(992, 114);
            this.pnl_head.TabIndex = 6;
            // 
            // btn_invoice
            // 
            this.btn_invoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_invoice.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_invoice.ImageIndex = 0;
            this.btn_invoice.ImageList = this.img_Button;
            this.btn_invoice.Location = new System.Drawing.Point(906, 84);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.Size = new System.Drawing.Size(80, 23);
            this.btn_invoice.TabIndex = 361;
            this.btn_invoice.Text = "Invoice";
            this.btn_invoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_invoice.Click += new System.EventHandler(this.btn_invoice_Click);
            // 
            // btn_packing
            // 
            this.btn_packing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_packing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_packing.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_packing.ImageIndex = 0;
            this.btn_packing.ImageList = this.img_Button;
            this.btn_packing.Location = new System.Drawing.Point(744, 84);
            this.btn_packing.Name = "btn_packing";
            this.btn_packing.Size = new System.Drawing.Size(80, 23);
            this.btn_packing.TabIndex = 360;
            this.btn_packing.Text = "P/K Create";
            this.btn_packing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_packing.Click += new System.EventHandler(this.btn_packing_Click);
            // 
            // btn_barcode
            // 
            this.btn_barcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_barcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_barcode.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_barcode.ImageIndex = 0;
            this.btn_barcode.ImageList = this.img_Button;
            this.btn_barcode.Location = new System.Drawing.Point(825, 84);
            this.btn_barcode.Name = "btn_barcode";
            this.btn_barcode.Size = new System.Drawing.Size(80, 23);
            this.btn_barcode.TabIndex = 360;
            this.btn_barcode.Text = "B/C Create";
            this.btn_barcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_barcode.Click += new System.EventHandler(this.btn_barcode_Click);
            // 
            // txt_packing
            // 
            this.txt_packing.BackColor = System.Drawing.SystemColors.Window;
            this.txt_packing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_packing.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_packing.Location = new System.Drawing.Point(432, 62);
            this.txt_packing.MaxLength = 4;
            this.txt_packing.Name = "txt_packing";
            this.txt_packing.Size = new System.Drawing.Size(220, 21);
            this.txt_packing.TabIndex = 359;
            // 
            // txt_remarks
            // 
            this.txt_remarks.BackColor = System.Drawing.Color.White;
            this.txt_remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_remarks.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_remarks.Location = new System.Drawing.Point(109, 84);
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(543, 21);
            this.txt_remarks.TabIndex = 12;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(976, 98);
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
            this.lbl_status.Location = new System.Drawing.Point(655, 40);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(100, 21);
            this.lbl_status.TabIndex = 50;
            this.lbl_status.Text = "Status";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_packing
            // 
            this.lbl_packing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_packing.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_packing.ImageIndex = 0;
            this.lbl_packing.ImageList = this.img_Label;
            this.lbl_packing.Location = new System.Drawing.Point(331, 62);
            this.lbl_packing.Name = "lbl_packing";
            this.lbl_packing.Size = new System.Drawing.Size(100, 21);
            this.lbl_packing.TabIndex = 50;
            this.lbl_packing.Text = "Packing";
            this.lbl_packing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_status.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_status.Location = new System.Drawing.Point(756, 40);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(220, 21);
            this.txt_status.TabIndex = 6;
            // 
            // btn_headSearch
            // 
            this.btn_headSearch.ImageIndex = 27;
            this.btn_headSearch.ImageList = this.img_SmallButton;
            this.btn_headSearch.Location = new System.Drawing.Point(629, 40);
            this.btn_headSearch.Name = "btn_headSearch";
            this.btn_headSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_headSearch.TabIndex = 54;
            this.btn_headSearch.Tag = "HeadSearch";
            this.btn_headSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_headSearch.Click += new System.EventHandler(this.btn_headSearch_Click);
            // 
            // dpick_shipYmd
            // 
            this.dpick_shipYmd.Checked = false;
            this.dpick_shipYmd.CustomFormat = "";
            this.dpick_shipYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_shipYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_shipYmd.Location = new System.Drawing.Point(109, 62);
            this.dpick_shipYmd.Name = "dpick_shipYmd";
            this.dpick_shipYmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dpick_shipYmd.Size = new System.Drawing.Size(222, 21);
            this.dpick_shipYmd.TabIndex = 2;
            this.dpick_shipYmd.CloseUp += new System.EventHandler(this.dpick_shipYmd_CloseUp);
            // 
            // lbl_remarks
            // 
            this.lbl_remarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_remarks.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remarks.ImageIndex = 0;
            this.lbl_remarks.ImageList = this.img_Label;
            this.lbl_remarks.Location = new System.Drawing.Point(8, 84);
            this.lbl_remarks.Name = "lbl_remarks";
            this.lbl_remarks.Size = new System.Drawing.Size(100, 21);
            this.lbl_remarks.TabIndex = 50;
            this.lbl_remarks.Text = "Remarks";
            this.lbl_remarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_shipYmd
            // 
            this.lbl_shipYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipYmd.ImageIndex = 1;
            this.lbl_shipYmd.ImageList = this.img_Label;
            this.lbl_shipYmd.Location = new System.Drawing.Point(8, 62);
            this.lbl_shipYmd.Name = "lbl_shipYmd";
            this.lbl_shipYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipYmd.TabIndex = 50;
            this.lbl_shipYmd.Text = "Ship Date";
            this.lbl_shipYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 97);
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
            this.cmb_factory.CaptionStyle = style1;
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
            this.cmb_factory.EvenRowStyle = style2;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style3;
            this.cmb_factory.HeadingStyle = style4;
            this.cmb_factory.HighLightRowStyle = style5;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style6;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style7;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style8;
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
            this.pic_head7.Location = new System.Drawing.Point(891, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 73);
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
            this.label2.Text = "      Shipping Info";
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
            this.pic_head1.Size = new System.Drawing.Size(952, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 98);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 87);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // lbl_shipNo
            // 
            this.lbl_shipNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipNo.ImageIndex = 1;
            this.lbl_shipNo.ImageList = this.img_Label;
            this.lbl_shipNo.Location = new System.Drawing.Point(331, 40);
            this.lbl_shipNo.Name = "lbl_shipNo";
            this.lbl_shipNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipNo.TabIndex = 50;
            this.lbl_shipNo.Text = "Ship No";
            this.lbl_shipNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_shipNo
            // 
            this.cmb_shipNo.AddItemSeparator = ';';
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
            this.cmb_shipNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipNo.FooterStyle = style11;
            this.cmb_shipNo.HeadingStyle = style12;
            this.cmb_shipNo.HighLightRowStyle = style13;
            this.cmb_shipNo.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_shipNo.Images"))));
            this.cmb_shipNo.ItemHeight = 15;
            this.cmb_shipNo.Location = new System.Drawing.Point(432, 40);
            this.cmb_shipNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipNo.MaxDropDownItems = ((short)(5));
            this.cmb_shipNo.MaxLength = 32767;
            this.cmb_shipNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipNo.Name = "cmb_shipNo";
            this.cmb_shipNo.OddRowStyle = style14;
            this.cmb_shipNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipNo.SelectedStyle = style15;
            this.cmb_shipNo.Size = new System.Drawing.Size(197, 20);
            this.cmb_shipNo.Style = style16;
            this.cmb_shipNo.TabIndex = 5;
            this.cmb_shipNo.TextChanged += new System.EventHandler(this.cmb_shipNo_SelectedValueChanged);
            this.cmb_shipNo.PropBag = resources.GetString("cmb_shipNo.PropBag");
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_insert);
            this.panel2.Controls.Add(this.btn_recover);
            this.panel2.Location = new System.Drawing.Point(12, 547);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 33);
            this.panel2.TabIndex = 5;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_delete.ImageIndex = 5;
            this.btn_delete.ImageList = this.image_List;
            this.btn_delete.Location = new System.Drawing.Point(831, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(80, 24);
            this.btn_delete.TabIndex = 361;
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            this.btn_delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_delete_MouseDown);
            this.btn_delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_delete_MouseUp);
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_insert.ImageIndex = 9;
            this.btn_insert.ImageList = this.image_List;
            this.btn_insert.Location = new System.Drawing.Point(750, 4);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(80, 24);
            this.btn_insert.TabIndex = 360;
            this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            this.btn_insert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseDown);
            this.btn_insert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseUp);
            // 
            // btn_recover
            // 
            this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_recover.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recover.ImageIndex = 1;
            this.btn_recover.ImageList = this.image_List;
            this.btn_recover.Location = new System.Drawing.Point(912, 4);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(80, 24);
            this.btn_recover.TabIndex = 359;
            this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
            this.btn_recover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_recover_MouseDown);
            this.btn_recover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_recover_MouseUp);
            // 
            // pnl_Search
            // 
            this.pnl_Search.Controls.Add(this.fgrid_shipping);
            this.pnl_Search.Location = new System.Drawing.Point(12, 153);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(992, 390);
            this.pnl_Search.TabIndex = 4;
            // 
            // fgrid_shipping
            // 
            this.fgrid_shipping.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_shipping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_shipping.Location = new System.Drawing.Point(0, 0);
            this.fgrid_shipping.Name = "fgrid_shipping";
            this.fgrid_shipping.Rows.DefaultSize = 19;
            this.fgrid_shipping.Size = new System.Drawing.Size(992, 390);
            this.fgrid_shipping.StyleInfo = resources.GetString("fgrid_shipping.StyleInfo");
            this.fgrid_shipping.TabIndex = 0;
            this.fgrid_shipping.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_shipping.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_shipping_MouseUp);
            this.fgrid_shipping.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            this.fgrid_shipping.DoubleClick += new System.EventHandler(this.fgrid_shipping_DoubleClick);
            // 
            // pnl_btn
            // 
            this.pnl_btn.Controls.Add(this.btn_BCCancel);
            this.pnl_btn.Controls.Add(this.btn_BCCreate);
            this.pnl_btn.Controls.Add(this.btn_PKCreate);
            this.pnl_btn.Controls.Add(this.btn_PKCancel);
            this.pnl_btn.Location = new System.Drawing.Point(12, 122);
            this.pnl_btn.Name = "pnl_btn";
            this.pnl_btn.Size = new System.Drawing.Size(992, 27);
            this.pnl_btn.TabIndex = 3;
            // 
            // btn_BCCancel
            // 
            this.btn_BCCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BCCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_BCCancel.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_BCCancel.ImageIndex = 0;
            this.btn_BCCancel.ImageList = this.img_Button;
            this.btn_BCCancel.Location = new System.Drawing.Point(912, 2);
            this.btn_BCCancel.Name = "btn_BCCancel";
            this.btn_BCCancel.Size = new System.Drawing.Size(80, 23);
            this.btn_BCCancel.TabIndex = 357;
            this.btn_BCCancel.Text = " BC Cancel";
            this.btn_BCCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BCCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_BCCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_BCCreate
            // 
            this.btn_BCCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BCCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_BCCreate.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_BCCreate.ImageIndex = 0;
            this.btn_BCCreate.ImageList = this.img_Button;
            this.btn_BCCreate.Location = new System.Drawing.Point(831, 2);
            this.btn_BCCreate.Name = "btn_BCCreate";
            this.btn_BCCreate.Size = new System.Drawing.Size(80, 23);
            this.btn_BCCreate.TabIndex = 356;
            this.btn_BCCreate.Text = " BC Create";
            this.btn_BCCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BCCreate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_BCCreate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_PKCreate
            // 
            this.btn_PKCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PKCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_PKCreate.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_PKCreate.ImageIndex = 0;
            this.btn_PKCreate.ImageList = this.img_Button;
            this.btn_PKCreate.Location = new System.Drawing.Point(669, 2);
            this.btn_PKCreate.Name = "btn_PKCreate";
            this.btn_PKCreate.Size = new System.Drawing.Size(80, 23);
            this.btn_PKCreate.TabIndex = 355;
            this.btn_PKCreate.Text = " PK Create";
            this.btn_PKCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PKCreate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_PKCreate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_PKCancel
            // 
            this.btn_PKCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PKCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_PKCancel.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_PKCancel.ImageIndex = 0;
            this.btn_PKCancel.ImageList = this.img_Button;
            this.btn_PKCancel.Location = new System.Drawing.Point(750, 2);
            this.btn_PKCancel.Name = "btn_PKCancel";
            this.btn_PKCancel.Size = new System.Drawing.Size(80, 23);
            this.btn_PKCancel.TabIndex = 356;
            this.btn_PKCancel.Text = " PK Cancel";
            this.btn_PKCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PKCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_PKCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // ctx_tail
            // 
            this.ctx_tail.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_AllSelect,
            this.mnu_Select,
            this.mnu_Data,
            this.mnu_rate,
            this.menuItem1,
            this.mnu_merge,
            this.mnu_mergeCancel,
            this.menuItem3,
            this.mnu_partial});
            // 
            // mnu_AllSelect
            // 
            this.mnu_AllSelect.Index = 0;
            this.mnu_AllSelect.Text = "All Select";
            this.mnu_AllSelect.Click += new System.EventHandler(this.mnu_AllSelect_Click);
            // 
            // mnu_Select
            // 
            this.mnu_Select.Index = 1;
            this.mnu_Select.Text = "-";
            this.mnu_Select.Click += new System.EventHandler(this.mnu_AllSelect_Click);
            // 
            // mnu_Data
            // 
            this.mnu_Data.Index = 2;
            this.mnu_Data.Text = "Value Change";
            this.mnu_Data.Click += new System.EventHandler(this.mnu_DataChange);
            // 
            // mnu_rate
            // 
            this.mnu_rate.Index = 3;
            this.mnu_rate.Text = "CBD Information";
            this.mnu_rate.Click += new System.EventHandler(this.mnu_rate_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 4;
            this.menuItem1.Text = "-";
            // 
            // mnu_merge
            // 
            this.mnu_merge.Index = 5;
            this.mnu_merge.Text = "Merge";
            this.mnu_merge.Click += new System.EventHandler(this.mnu_merge_Click);
            // 
            // mnu_mergeCancel
            // 
            this.mnu_mergeCancel.Index = 6;
            this.mnu_mergeCancel.Text = "Merge Cancel";
            this.mnu_mergeCancel.Click += new System.EventHandler(this.mnu_mergeCancel_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 7;
            this.menuItem3.Text = "-";
            // 
            // mnu_partial
            // 
            this.mnu_partial.Index = 8;
            this.mnu_partial.Text = "Partial";
            this.mnu_partial.Click += new System.EventHandler(this.mnu_partial_Click);
            // 
            // Form_BS_Shipping_Request
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BS_Shipping_Request";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_BS_Shipping_Request_Closing);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipNo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnl_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_shipping)).EndInit();
            this.pnl_btn.ResumeLayout(false);
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

		private void fgrid_shipping_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				if (Etc_ProvisoValidateCheck(_validate_ContextMenu))
				{
					ctx_tail.Show(fgrid_shipping, new Point(e.X, e.Y));
				}
			}
		}
		
		private void fgrid_shipping_DoubleClick(object sender, System.EventArgs e)
		{
			this.Grid_DoubleClickProcess();
		}

		private void mnu_AllSelect_Click(object sender, System.EventArgs e)
		{
			fgrid_shipping.Select(fgrid_shipping.Rows.Fixed, fgrid_shipping.MouseCol, fgrid_shipping.Rows.Count - 1, fgrid_shipping.MouseCol);
		}

		private void mnu_DataChange(object sender, System.EventArgs e)
		{
			this.Grid_CellClickProcess();
		}

		private void mnu_rate_Click(object sender, System.EventArgs e)
		{
			Mnu_RateProcess();		
		}

		private void mnu_merge_Click(object sender, System.EventArgs e)
		{
			Mnu_MergeProcess();
		}

		private void mnu_mergeCancel_Click(object sender, System.EventArgs e)
		{
			Mnu_MergeCancelProcess();
		}

		private void mnu_partial_Click(object sender, System.EventArgs e)
		{
			Mnu_PartialProcess();
		}

		#endregion
		
		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();
		}
		
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_validate_ContextMenu))
			{
				this.Tbtn_SearchProcess();
			}
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Save))
			{
				if (MessageBox.Show(this, "Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					this.Tbtn_SaveProcess();
			}
		}
		
		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Confirm))
			{
				if (MessageBox.Show(this, "Do you want to delete?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					string vShipNo = COM.ComFunction.Empty_Combo(cmb_shipNo, "");

					// head set
					if (!SAVE_SBS_SHIPPING_LIST_HEAD(ClassLib.ComVar.Delete, vShipNo))
					{
						return;
					}

					if (MyOraDB.Exe_Modify_Procedure() != null)
					{
						this.Tbtn_NewProcess();
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
						ClassLib.ComFunction.User_Message("Delete Complete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (!this.Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Search))
				return;	
		
			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BS_Shipping_Request");
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 3;
			string [] aHead =  new string[iCnt];
			
			aHead[0] = COM.ComVar.This_Factory;
			aHead[1] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			aHead[2] = COM.ComFunction.Empty_Combo(cmb_shipNo, "");
			
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

		private void Form_BS_Shipping_Request_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (fgrid_shipping.Rows.Fixed < fgrid_shipping.Rows.Count)
			{
				string vTemp = fgrid_shipping.GetCellRange(fgrid_shipping.Rows.Fixed, 0, fgrid_shipping.Rows.Count - 1, 0).Clip.Replace("\r", "");

				if (vTemp.Length > 0)
					if (MessageBox.Show(this, "Exist modify data. Do you want close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						e.Cancel = true;
			}
		}

		private void cmb_shipNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_ShipNoSelectedValueChangedProcess();
		}

		private void btn_insert_Click(object sender, System.EventArgs e)
		{
			Btn_InsertClickProcess();
		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			if (MessageBox.Show(this, "Do you want to delete item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				Btn_DeleteClickProcess();
		}

		private void btn_recover_Click(object sender, System.EventArgs e)
		{
			Btn_RecoverClickProcess();
		}

		#endregion

		#region 버튼 이벤트

		private void btn_packing_Click(object sender, System.EventArgs e)
		{
			if (txt_status.Text.Equals(ClassLib.ComVar.Save))
			{
				if (Etc_ProvisoValidateCheck(_validate_createPK))
					if (MessageBox.Show(this, "Do you want packing create?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						Btn_PackingCreateProcess();
					}
			}
			else if (txt_status.Text.Equals(ClassLib.ComVar.Packing))
			{
				if (Etc_ProvisoValidateCheck(_validate_cancelPK))
					if (MessageBox.Show(this, "Do you want to packing cancel?", "Packing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						Btn_PackingCancelProcess();
					}
			}
		}

		private void btn_barcode_Click(object sender, System.EventArgs e)
		{
			if (txt_status.Text.Equals(ClassLib.ComVar.Packing))
			{
				if (Etc_ProvisoValidateCheck(_validate_createBC))
					if (MessageBox.Show(this, "Do you want to make barcode?", "Barcode", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						Btn_BarcodeCreateProcess();
					}
			}
			else if (txt_status.Text.Equals(ClassLib.ComVar.Barcode))
			{
				if (Etc_ProvisoValidateCheck(_validate_cancelBC))
					if (MessageBox.Show(this, "Do you want to remove barcode?", "Barcode", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						Btn_BarcodeCancelProcess();
					}
			}
		}



        private void btn_invoice_Click(object sender, EventArgs e)
        {
            if (Etc_ProvisoValidateCheck(_validate_trade))   //miyoung.kim
            {
                if (MessageBox.Show(this, "Do you want to trade sc?", "Trade", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SALESCONTRACT_PROCESS("PKG_SBS_SHIPPING_LIST.INVOICE_TRANSMIT", cmb_factory.SelectedValue.ToString(), cmb_shipNo.SelectedValue.ToString());
                    tbtn_Search_Click(null, null);
                    ClassLib.ComFunction.User_Message("Complete Invoice Transmit");
                    CheckStatus();
                }
            }




        }




		// scan manager로 이동
		private void MoveToScanManager()
		{
			DialogResult vResult = MessageBox.Show(this, "Do you want move to scan manager?", "Move to scan manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (vResult == DialogResult.Yes)
			{
				Form_BS_Scan_InOut vScan = new Form_BS_Scan_InOut();
				vScan.MdiParent = this.MdiParent;
				vScan.RunProcess(dpick_shipYmd.Value, (int)ClassLib.ComVar.ShipTypeEnum.Request, cmb_shipNo.SelectedValue);
				this.Close();
			}
		}

		private void btn_headSearch_Click(object sender, System.EventArgs e)
		{
			this.Btn_HeadSearchClickProcess();
		}

		#region 검색조건 변경에 따른 이벤트

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			AllClear();
			this.Cmb_ShipNoSettingProcess();
		}

		private void dpick_shipYmd_CloseUp(object sender, System.EventArgs e)
		{
			AllClear();
			this.Cmb_ShipNoSettingProcess();
		}

		#endregion

		#region 입력이동

		private void cmb_factory_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				dpick_shipYmd.Focus();
		}

		private void dpick_shipYmd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void cmb_size_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				Tbtn_SearchProcess();
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

		private void btn_recover_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		private void btn_recover_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		#endregion

		#endregion

		#region 공통 메서드

		private void AllClear()
		{
			if (fgrid_shipping.Rows.Fixed < fgrid_shipping.Rows.Count)
				fgrid_shipping.ClearAll();
			ClearHeadInfo();
		}

		private void SetHeadInfo(DataTable arg_dt)
		{
			cmb_shipNo.SelectedValue = arg_dt.Rows[0].ItemArray[0];
			txt_status.Text			 = arg_dt.Rows[0].ItemArray[4].ToString();
			txt_packing.Text		 = arg_dt.Rows[0].ItemArray[11].ToString();
		}

		private void ClearHeadInfo()
		{
			cmb_shipNo.SelectedIndex = -1;
			txt_status.Text			 = "";
			txt_packing.Text		 = "";
		}

		private void SearchHeadInfo()
		{
			string vFactory = cmb_factory.SelectedValue.ToString();
			string vShipNo  = cmb_shipNo.SelectedValue.ToString();

			DataTable vDt = SELECT_SBS_SHIPPING_HEAD(vFactory, vShipNo);
			if (vDt.Rows.Count == 1)
				this.SetHeadInfo(vDt);
			else
				this.ClearHeadInfo();
			vDt.Dispose();
		}

		private void SearchTailInfo()
		{
			string vFactory = ClassLib.ComFunction.Empty_Combo(cmb_factory, " ");
			string vShipNo = ClassLib.ComFunction.Empty_Combo(cmb_shipNo, " ");

			DataTable vDt = SELECT_SBS_SHIPPING_TAIL_LIST(vFactory, vShipNo);
            vDt.Dispose();
			
			if (vDt.Rows.Count > 0)
			{
				ClassLib.ComFunction.Display_FlexGrid_Normal(fgrid_shipping, vDt);
				GridSetCellColor();
			}
			else
			{
				fgrid_shipping.ClearAll();
			}
		}

		private void GridSetCellColor()
		{
			string vShipYN	  = null;
			string vPackingString = txt_packing.Text;
			string vCurRemark = "", vNextRemark = "";
			int vIdx = 1;

			for (int i = fgrid_shipping.Rows.Fixed ; i < fgrid_shipping.Rows.Count ; i++)
			{
				vShipYN		= fgrid_shipping[i, (int)TBSBS_SHIPPING_REQUEST.IxSHIP_YN].ToString();
				C1.Win.C1FlexGrid.CellRange vCellRange = fgrid_shipping.GetCellRange(i, fgrid_shipping.Cols.Frozen, i, fgrid_shipping.Cols.Count - 1);

				if (vShipYN.Equals(ClassLib.ComVar.Yes))
					vCellRange.StyleNew.BackColor = ClassLib.ComVar.RightBlue;
				else if (vShipYN.Equals(ClassLib.ComVar.No))
					vCellRange.StyleNew.BackColor = ClassLib.ComVar.RightPink2;
				else
					vCellRange.StyleNew.BackColor = ClassLib.ComVar.Default;

				Color vColor = GetForeColor(i);
				if (vColor != Color.Empty)
					vCellRange.StyleNew.ForeColor = vColor;

				if (i != fgrid_shipping.Rows.Count - 1)
				{
					vCurRemark = fgrid_shipping[i, (int)TBSBS_SHIPPING_REQUEST.IxREMARKS].ToString();
					vCurRemark = vCurRemark.Substring(1, vCurRemark.Length - 2);
					vNextRemark = fgrid_shipping[i + 1, (int)TBSBS_SHIPPING_REQUEST.IxREMARKS].ToString();
					vNextRemark = vNextRemark.Substring(1, vNextRemark.Length - 2);

					if (vCurRemark.Equals(vNextRemark) && !vCurRemark.Equals(""))
					{
						fgrid_shipping.Rows[i].StyleNew.Border.Direction = BorderDirEnum.Vertical;
					}
				}

				fgrid_shipping[i, (int)TBSBS_SHIPPING_REQUEST.IxINDEX] = vIdx++;
			}
		}

		private Color GetForeColor(int arg_row)
		{
			Color vColor = Color.Empty;

			if (fgrid_shipping[arg_row, (int)TBSBS_SHIPPING_REQUEST.IxREMARKS].ToString().StartsWith("M"))
				vColor = Color.FromArgb(128, 0, 128);
			else if (fgrid_shipping[arg_row, (int)TBSBS_SHIPPING_REQUEST.IxREMARKS].ToString().StartsWith("P"))
				vColor = Color.FromArgb(0, 128, 0);

			return vColor;
		}

		public ArrayList EmptyProvisoCheck(string arg_proviso, ref int arg_Row, ref int arg_Col)
		{
			ArrayList vColumns	  = new ArrayList();
			string vPackingString = txt_packing.Text;
			string vPackingNo	  = "";
			int vCount = 1;

			// packing string check
			if (vPackingString.Equals(""))
				return null;

			// empty cell check
			for (int i = fgrid_shipping.Rows.Fixed ; i < fgrid_shipping.Rows.Count ; i++)
			{
				if (fgrid_shipping[i, (int)TBSBS_SHIPPING_REQUEST.IxSHIP_YN].ToString().Substring(0, 1).Equals(arg_proviso) && fgrid_shipping[i, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO].ToString().Equals(""))
				{
					if (ClassLib.ComFunction.NullCheck(fgrid_shipping[i, (int)TBSBS_SHIPPING_REQUEST.IxSHIP_QTY], "").Equals(""))
					{
						arg_Row = i;
						arg_Col = (int)TBSBS_SHIPPING_REQUEST.IxSHIP_QTY;
						break;
					}
					if (ClassLib.ComFunction.NullCheck(fgrid_shipping[i, (int)TBSBS_SHIPPING_REQUEST.IxPK_UNIT_QTY], "").Equals(""))
					{
						arg_Row = i;
						arg_Col = (int)TBSBS_SHIPPING_REQUEST.IxPK_UNIT_QTY;
						break;
					}
					vColumns.Add((object)i);
				}

				// get last count
				if (!fgrid_shipping[i, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO].ToString().Equals(""))
				{
					vPackingNo = fgrid_shipping[i, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO_TO].ToString();
					vCount = Convert.ToInt32(vPackingNo.Equals("") ? "1" : vPackingNo);
					_count = (vCount > _count) ? vCount : _count;
				}
			}

			return vColumns;
		}

        // 선적 취소시 호출
		private void ShippingCancel(int arg_row, int arg_col)
		{
			string vStatus = txt_status.Text;

			if (vStatus.Equals(ClassLib.ComVar.Packing))
			{
				if (arg_col == _shipYNCol)
				{
					if (fgrid_shipping[fgrid_shipping.Row, fgrid_shipping.Col].ToString().Equals("N"))
					{
						fgrid_shipping[arg_row, _packingNoCol] = "";
						fgrid_shipping[arg_row, _CTCol] = null;
						fgrid_shipping[arg_row, _packingNoFromCol] = "";
						fgrid_shipping[arg_row, _packingNoToCol] = "";
						fgrid_shipping[arg_row, _statusCol] = "Save";
					}
					else
					{
						Mnu_PackingCreate();
					}
				}
				else if (arg_col == _shipQtyCol || arg_col == _packingUnitQtyCol)
				{
					fgrid_shipping[arg_row, _packingNoCol] = "";
					fgrid_shipping[arg_row, _CTCol] = null;
					fgrid_shipping[arg_row, _packingNoFromCol] = "";
					fgrid_shipping[arg_row, _packingNoToCol] = "";

					Mnu_PackingCreate();
				}
			}
		}

		private int GetMaxSeq()
		{
			int vMaxSeq = 1;

			try
			{
				for (int i = fgrid_shipping.Rows.Fixed ; i < fgrid_shipping.Rows.Count ; i++)
				{
					if (vMaxSeq < Convert.ToInt32(fgrid_shipping[i, (int)TBSBS_SHIPPING_REQUEST.IxSHIP_SEQ]))
						vMaxSeq = Convert.ToInt32(fgrid_shipping[i, (int)TBSBS_SHIPPING_REQUEST.IxSHIP_SEQ]);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "GetMaxSeq", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return vMaxSeq;
		}

		private double NullToZero(object arg_num)
		{
			try
			{
				double vResult = 0;

				if (arg_num != null)
				{
					if (!arg_num.ToString().Equals(""))
					{
						vResult = Convert.ToDouble(arg_num);
					}
				}

				return vResult;
			}
			catch 
			{
				return 0;
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
			this.Text = "Shipping Request";
			lbl_MainTitle.Text = "Shipping Request";
			ClassLib.ComFunction.SetLangDic(this);

			// grid set
			fgrid_shipping.Set_Grid("SBS_SHIPPING_REQUEST", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_shipping.Set_Action_Image(img_Action);
			fgrid_shipping.Rows[1].AllowMerging = true;

			_practicable = true;

			// factory set
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar. This_Factory;
			vDt.Dispose();

			// Disabled tbutton
			tbtn_Confirm.Enabled = false;
			this.c1Sizer1.Grid.Rows[1].Size = 0;
			CheckStatus();

			// set grid cell type
			_cellCombo = new Hashtable(fgrid_shipping.Cols.Count);

			for (int vCol = 1 ; vCol < fgrid_shipping.Cols.Count ; vCol++)
			{
				if (fgrid_shipping.Cols[vCol].AllowEditing)
				{
					if (fgrid_shipping.Cols[vCol].DataMap != null)
					{
						_cellCombo.Add(vCol, fgrid_shipping.GetDataSourceWithCode(vCol));
					}
				}
			}


            btn_invoice.Visible = true;
		}

		#region 툴바 메뉴 이벤트

		private void Tbtn_NewProcess()
		{
			try
			{
				ClearHeadInfo();
				fgrid_shipping.ClearAll();
				btn_packing.Enabled = false;
				btn_barcode.Enabled = false;
				tbtn_Save.Enabled	= true;
				btn_insert.Enabled  = true;
				btn_delete.Enabled  = true;
				btn_recover.Enabled = true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "New_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (cmb_shipNo.SelectedIndex == -1)	return;

				SearchHeadInfo();
				SearchTailInfo();

				string vStatus = txt_status.Text.Substring(0, 1);

				CheckStatus();
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

		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
		
				if (fgrid_shipping.Rows.Fixed >= fgrid_shipping.Rows.Count) return;
		
				string vShipNo = "";
				string vDivision = "";

				if (cmb_shipNo.SelectedIndex == -1)
				{
					string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
					string vDocDivision = ClassLib.ComVar.SHIPPING;
					string vDocType = "88";
					string vDate = dpick_shipYmd.Value.ToString("yyyyMMdd");
					string vUser = COM.ComVar.This_User;

					DataTable vDt = ClassLib.ComFunction.SELECT_DOCUMENT_NO(vFactory, vDocDivision, vDocType, vDate, vUser);

					vShipNo = vDt.Rows[0].ItemArray[0].ToString();
					vDivision = ClassLib.ComVar.Insert;
					txt_status.Text = "Save";
				}
				else
				{
					vShipNo = cmb_shipNo.SelectedValue.ToString();
					vDivision = ClassLib.ComVar.Update;
				}

				if (vShipNo.Equals(""))
				{
					ClassLib.ComFunction.User_Message("Not create ship no!", "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// head set
				if (!SAVE_SBS_SHIPPING_LIST_HEAD(vDivision, vShipNo))
					return;

				// tail set
				ClassLib.ComFunction.SetData_FSP(fgrid_shipping, 
					fgrid_shipping.GetCellRange(fgrid_shipping.Rows.Fixed, (int)TBSBS_SHIPPING_REQUEST.IxSHIP_NO, fgrid_shipping.Rows.Count - 1, (int)TBSBS_SHIPPING_REQUEST.IxSHIP_NO),
					vShipNo);
				
				MyOraDB.Save_FlexGird_Ready("PKG_SBS_SHIPPING_REQUEST.SAVE_SBS_SHIPPING_LIST_TAIL_2", fgrid_shipping, false);

				if (MyOraDB.Exe_Modify_Procedure() != null)
				{
					Cmb_ShipNoSettingProcess();
					cmb_shipNo.SelectedValue = vShipNo;

					fgrid_shipping.Refresh_Division();
					GridSetCellColor();

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
					ClassLib.ComFunction.User_Message("Save Complete", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		#endregion

		#region 컨트롤 이벤트

		private void Cmb_ShipNoSettingProcess()
		{
			try
			{
				if (_practicable)
				{
					DataTable vDt = SELECT_SBS_SHIPPING_HEAD_SNO();
					COM.ComCtl.Set_ComboList(vDt, cmb_shipNo, 0, 0, false, false);
					vDt.Dispose();
				}
			}
			catch (Exception ex)
			{
                ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Cmb_ShipNoSelectedValueChangedProcess()
		{
			try
			{
				Tbtn_SearchProcess();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Btn_PackingCreateProcess()
		{
			try
			{
				fgrid_shipping.SelectAll();
				Mnu_PackingCreate();
				txt_status.Text = ClassLib.ComVar.Packing;
				Tbtn_SaveProcess();
				ClassLib.ComFunction.User_Message("Complete create packing", "Packing", MessageBoxButtons.OK, MessageBoxIcon.Information);
				CheckStatus();

				/*
				int vRow = -1, vCol = -1, vTemp = 0;
				double vShipQty = 0, vPackingUnitQty = 0;
				string vResultPackingNo = "";
				string vPackingString = txt_packing.Text;

				// validate check
				string vCharacter = ClassLib.ComFunction.ValidateCheck(vPackingString, ClassLib.ComVar.SpecialCharacter);
				if (vCharacter != null)
				{
					ClassLib.ComFunction.User_Message(vCharacter + " is unfit for use character", "Packing Character Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// empty cell check
				ArrayList vColumns = EmptyProvisoCheck("Y", ref vRow, ref vCol);
				if (vRow != -1)
				{
					ClassLib.ComFunction.User_Message(fgrid_shipping[1, vCol].ToString() + " is missing", "Empty Cell", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					fgrid_shipping.Select(vRow, vCol, true);
					return;
				}
				else if (vColumns == null)
				{
					ClassLib.ComFunction.User_Message("Packing string is missing", "Empty Packing String", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txt_packing.Focus();
					return;
				}


				// packing no set
				IEnumerator vEnum = vColumns.GetEnumerator();
				while (vEnum.MoveNext())
				{
					vRow			= (int)vEnum.Current;
					vPackingUnitQty = Convert.ToDouble(fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxPK_UNIT_QTY].ToString());
					vShipQty		= Convert.ToDouble(fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxSHIP_QTY].ToString());

					fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxCT_QTY] = vTemp = (int)Math.Ceiling(vShipQty / vPackingUnitQty);
					fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxSTATUS] = ClassLib.ComVar.Packing;

					if (vTemp == 1)
					{
						fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO_FROM] = _count;
						fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO_TO] = _count++;
						vResultPackingNo = vPackingString + fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO_FROM].ToString();
					}
					else
					{
						fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO_FROM] = _count;
						fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO_TO] = (_count = _count + vTemp) - 1;
						vResultPackingNo = vPackingString + fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO_FROM].ToString() + " ~ " + vPackingString + fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO_TO].ToString();
					}

					fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO] = vResultPackingNo;
					fgrid_shipping.Update_Row((int)vEnum.Current);
				}

				if (vColumns.Count > 0)
				{
					txt_status.Text = ClassLib.ComVar.Packing;
					ClassLib.ComFunction.User_Message("Complete create packing", "Packing", MessageBoxButtons.OK, MessageBoxIcon.Information);
					_count = 1;

					this.Tbtn_SaveProcess();
					CheckStatus();
				}
				*/
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Btn_PackingCreateClickProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Btn_PackingCancelProcess()
		{
			_count = fgrid_shipping.Rows.Fixed;

			while (_count < fgrid_shipping.Rows.Count)
			{
				if (!fgrid_shipping[_count, (int)TBSBS_SHIPPING_REQUEST.IxSTATUS].ToString().Equals(ClassLib.ComVar.Barcode))
				{
					fgrid_shipping[_count, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO]			= "";
					fgrid_shipping[_count, (int)TBSBS_SHIPPING_REQUEST.IxCT_QTY]		= null;
					fgrid_shipping[_count, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO_FROM]	= "";
					fgrid_shipping[_count, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO_TO]		= "";
					fgrid_shipping[_count, (int)TBSBS_SHIPPING_REQUEST.IxSTATUS]		= ClassLib.ComVar.Save;
					fgrid_shipping.Update_Row(_count);
				}
				_count++;
			}

			_count = 1;
			txt_packing.Text = "";
			txt_status.Text = ClassLib.ComVar.Save;
			this.Tbtn_SaveProcess();
			ClassLib.ComFunction.User_Message("Complete cancel packing", "Packing", MessageBoxButtons.OK, MessageBoxIcon.Information);
			CheckStatus();
		}

		private void Btn_BarcodeCreateProcess()
		{
			if (Etc_ProvisoValidateCheck(_validate_ContextMenu))
			{
				this.MAKE_BARCODE();
				txt_status.Text = ClassLib.ComVar.Barcode;
				this.Tbtn_SearchProcess();

				CheckStatus();
				ClassLib.ComFunction.User_Message("Complete create barcode", "Barcode Create", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void Btn_BarcodeCancelProcess()
		{
			if (Etc_ProvisoValidateCheck(_validate_ContextMenu))
			{
				DataTable vDt = this.CANCEL_BARCODE();

				if (vDt.Rows[0].ItemArray[0].ToString().StartsWith(_packing))
				{
					txt_status.Text = vDt.Rows[0].ItemArray[0].ToString();
					this.Tbtn_SearchProcess();
					CheckStatus();
					ClassLib.ComFunction.User_Message("Complete Cancel barcode", "Barcode Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					ClassLib.ComFunction.User_Message("Already incomed data : " + vDt.Rows[0].ItemArray[1].ToString(), "Barcode Cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}


		private void Btn_HeadSearchClickProcess()
		{
			Pop_BS_Shipping_List_Head vPopup = new Pop_BS_Shipping_List_Head();
			ClassLib.ComVar.Parameter_PopUp_Object		= new object[3];
			ClassLib.ComVar.Parameter_PopUp_Object[0]	= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			ClassLib.ComVar.Parameter_PopUp_Object[1]	= "88";
			ClassLib.ComVar.Parameter_PopUp_Object[2]	= dpick_shipYmd.Value;

			if (vPopup.ShowDialog() == DialogResult.OK)
			{
				_practicable = false;
				cmb_factory.SelectedValue		= COM.ComVar.Parameter_PopUp[0];
				dpick_shipYmd.Value				= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[1]);
				_practicable = true;
				Cmb_ShipNoSettingProcess();
				cmb_shipNo.SelectedValue		= COM.ComVar.Parameter_PopUp[6];
			}

			vPopup.Dispose();
		}

		#endregion

		#region 패킹 관련 함수들

		private void Mnu_PackingCreate()
		{
			int[] vSel = fgrid_shipping.Selections;
			int vFrom = 1, vTo = 1, vCt = 1;
			bool vFirst = true;

			foreach (int vRow in vSel)
			{
				if (!ClassLib.ComFunction.NullToBlank(fgrid_shipping[vRow, _CTCol]).Equals(""))
					continue;

				string vRemarks = ClassLib.ComFunction.NullToBlank(fgrid_shipping[vRow, _remarksCol]);

				if (vFirst)
				{
					// 패킹번호 가져오기
					DataTable vDt = SELECT_SBS_SHIPPING_NEXT_PK_NO();
					vFrom = Convert.ToInt32(vDt.Rows[0].ItemArray[0]);
					vFirst = false;
				}
				else
				{
					vFrom = GetLastPkNumber();
				}

				if (vRemarks.StartsWith(ClassLib.ComVar.Merge))		// merge
				{
					string vMerge = vRemarks.Substring(0, vRemarks.Length - 1);

					for (int i = vRow ; i < fgrid_shipping.Rows.Count ; i++)
					{
						string vCurMerge = ClassLib.ComFunction.NullToBlank(fgrid_shipping[i, _remarksCol]);

						if (vCurMerge.StartsWith(vMerge))
						{
							vCt = (int)Math.Ceiling(StringToDouble(fgrid_shipping[i, _shipQtyCol]) / StringToDouble(fgrid_shipping[i, _packingUnitQtyCol]));
							vTo = (vFrom + vCt) - 1;

							SetPackingInfo(i, vFrom, vTo, vCt);
						}
					}
				}
				else	// etc
				{
					vCt = (int)Math.Ceiling(StringToDouble(fgrid_shipping[vRow, _shipQtyCol]) / StringToDouble(fgrid_shipping[vRow, _packingUnitQtyCol]));
					vTo = (vFrom + vCt) - 1;

					SetPackingInfo(vRow, vFrom, vTo, vCt);
				}
			}
		}

		private int GetLastPkNumber()
		{
			int vResult = 0;

			for (int vRow = fgrid_shipping.Rows.Fixed ; vRow < fgrid_shipping.Rows.Count ; vRow++)
			{
				int vTo = StringToInteger(fgrid_shipping[vRow, _packingNoToCol]);
				
				if (vTo > vResult)
				{
					vResult = vTo;
				}
			}

			return vResult + 1;
		}

		private void SetPackingInfo(int arg_row, int arg_from, int arg_to, int arg_ct)
		{
			string vResultPackingNo = "";

			fgrid_shipping[arg_row, _CTCol] = arg_ct;
			fgrid_shipping[arg_row, _packingNoFromCol] = arg_from;
			fgrid_shipping[arg_row, _packingNoToCol] = arg_to;

			if (arg_from == arg_to)
				vResultPackingNo = txt_packing.Text + arg_from.ToString();
			else
				vResultPackingNo = txt_packing.Text + arg_from + " ~ " + txt_packing.Text + arg_to;

			fgrid_shipping[arg_row, _packingNoCol] = vResultPackingNo;
			fgrid_shipping[arg_row, _statusCol]	= ClassLib.ComVar.Packing;
			fgrid_shipping.Update_Row(arg_row);
		}

		private void Mnu_PackingCancel()
		{
			int[] vSel = fgrid_shipping.Selections;

			if (txt_status.Text.Equals(ClassLib.ComVar.Packing))
			{
				foreach (int vRow in vSel)
				{
					fgrid_shipping[vRow, _packingNoCol]			= "";
					fgrid_shipping[vRow, _CTCol]				= null;
					fgrid_shipping[vRow, _packingNoFromCol]		= "";
					fgrid_shipping[vRow, _packingNoToCol]		= "";
					fgrid_shipping[vRow, _statusCol]			= ClassLib.ComVar.Save;
					fgrid_shipping.Update_Row(_count);
				}
			}
		}

		private int StringToInteger(object obj)
		{
			if (obj == null)	return 0;
			if (obj.ToString().Trim().Equals(""))	return 0;
			
			return Convert.ToInt32(obj.ToString());
		}

		private double StringToDouble(object obj)
		{
			if (obj == null)	return 0;
			if (obj.ToString().Equals(""))	return 0;
			
			return Convert.ToDouble(obj.ToString());
		}


		#endregion

		#region 컨텍스트 메뉴

		private void Mnu_RateProcess()
		{
			try
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
				int[] keys = new int[]{ (int)TBSBS_SHIPPING_REQUEST.IxFACTORY,
										(int)TBSBS_SHIPPING_REQUEST.IxSTYLE_CD,
										(int)TBSBS_SHIPPING_REQUEST.IxITEM_CD,
										(int)TBSBS_SHIPPING_REQUEST.IxSPEC_CD,
										(int)TBSBS_SHIPPING_REQUEST.IxCOLOR_CD };

				int[] values = new int[]{ 
											-1,											(int)TBSBS_SHIPPING_REQUEST.IxPUR_USER,
											(int)TBSBS_SHIPPING_REQUEST.IxCUST_CD,		(int)TBSBS_SHIPPING_REQUEST.IxVENDOR,
											(int)TBSBS_SHIPPING_REQUEST.IxPK_UNIT_QTY,
											(int)TBSBS_SHIPPING_REQUEST.IxPUR_PRICE,	(int)TBSBS_SHIPPING_REQUEST.IxPUR_CURRENCY,
											-1,											-1,
											(int)TBSBS_SHIPPING_REQUEST.IxCBD_PRICE,	(int)TBSBS_SHIPPING_REQUEST.IxCBD_CURRENCY,
											-1,											-1,
											-1,											-1
										};

				Pop_BC_CBD_Information vPop = new Pop_BC_CBD_Information(fgrid_shipping, keys, values);
				vPop.ShowDialog(this);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "mnu_rate_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Mnu_MergeProcess()
		{
			try
			{
				int vR1 = fgrid_shipping.Selection.r1;
				int vR2 = fgrid_shipping.Selection.r2;
				int vSeq = int.MaxValue;

				for (int vRow = vR1 + 1 ; vRow <= vR2 ; vRow++)
				{
					int vTemp = StringToInteger(fgrid_shipping[vR1, (int)TBSBS_SHIPPING_REQUEST.IxSHIP_SEQ]);

					if (vSeq > vTemp)
						vSeq = vTemp;
				}

				fgrid_shipping[vR1, (int)TBSBS_SHIPPING_REQUEST.IxREMARKS] = ClassLib.ComVar.Merge + vSeq + 1;
				fgrid_shipping[vR1, (int)TBSBS_SHIPPING_REQUEST.IxATTRIBUTE] = ClassLib.ComVar.Merge + vSeq;
				fgrid_shipping.Update_Row(vR1);

				for (int vRow = vR1 + 1 ; vRow <= vR2 ; vRow++)
				{
					fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxREMARKS] = ClassLib.ComVar.Merge + vSeq + 2;
					fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxATTRIBUTE] = ClassLib.ComVar.Merge + vSeq;
					fgrid_shipping.Update_Row(vRow);

					if (txt_status.Text.Equals(ClassLib.ComVar.Packing))
					{
						fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO] = fgrid_shipping[vR1, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO];
						fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO_FROM] = fgrid_shipping[vR1, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO_FROM];
						fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO_TO] = fgrid_shipping[vR1, (int)TBSBS_SHIPPING_REQUEST.IxPK_NO_TO];
					}
					
					fgrid_shipping.Rows[vRow - 1].StyleNew.Border.Direction = BorderDirEnum.Vertical;
				}
			}
			catch (Exception ex)
			{
                ClassLib.ComFunction.User_Message(ex.Message, "Mnu_MergeProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Mnu_MergeCancelProcess()
		{
			for (int vRow = fgrid_shipping.Rows.Fixed ; vRow < fgrid_shipping.Rows.Count ; vRow++)
			{
				if (fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxREMARKS].ToString().StartsWith("M"))
				{
					fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxREMARKS] = "N" + fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxSHIP_SEQ] + "1";
					fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxATTRIBUTE] = "N" + fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxSHIP_SEQ];
					fgrid_shipping.Rows[vRow].StyleNew.Border.Direction = BorderDirEnum.Both;
					fgrid_shipping.Update_Row(vRow);
				}
			}

			Mnu_PackingCreate();
		}

		private void Mnu_PartialProcess()
		{
			try
			{
				int vRow = fgrid_shipping.Row;
				int vNewRowIndex = vRow + 1;
				string[] vData;
				string vSeq = fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxSHIP_SEQ].ToString();

				// 0 : item code, 1 : item name, 2 : spec code, 3 : spec name, 4 : color code, 5 : color name, 6 : unit
				string[] vParam = new string[]{
												  ClassLib.ComFunction.NullCheck(fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxITEM_CD], ""),
												  ClassLib.ComFunction.NullCheck(fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxITEM], ""),
												  ClassLib.ComFunction.NullCheck(fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxSPEC_CD], ""),
												  ClassLib.ComFunction.NullCheck(fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxSPEC], ""),
												  ClassLib.ComFunction.NullCheck(fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxCOLOR_CD], ""),
												  ClassLib.ComFunction.NullCheck(fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxCOLOR], ""),
												  ClassLib.ComFunction.NullCheck(fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxUNIT], "")
											  };
				
				COM.ComVar.Parameter_PopUp = vParam;

				Form vPop = new Pop_BS_Shipping_Request_Item_List();
				if (vPop.ShowDialog() == DialogResult.OK && ClassLib.ComVar.Parameter_PopUp_Object != null)
				{
					_nextSeq = GetMaxSeq() + 1;
					string vClip = fgrid_shipping.GetCellRange(vRow, 0, vRow, fgrid_shipping.Cols.Count - 1).Clip;
					fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxREMARKS] = ClassLib.ComVar.Partial + vSeq + 1;
					fgrid_shipping.Update_Row(vRow);

					ArrayList vResult = (ArrayList)ClassLib.ComVar.Parameter_PopUp_Object[0];
					IEnumerator vEnum = vResult.GetEnumerator();
					
					while(vEnum.MoveNext())
					{
						vData = (string[])vEnum.Current;
						C1.Win.C1FlexGrid.Row vNewRow = fgrid_shipping.AddItem(vClip, vNewRowIndex);
						fgrid_shipping.Rows[vNewRow.Index - 1].StyleNew.Border.Direction = BorderDirEnum.Vertical;
						vNewRow[(int)TBSBS_SHIPPING_REQUEST.IxSHIP_SEQ] = _nextSeq++;
						vNewRow[(int)TBSBS_SHIPPING_REQUEST.IxSPEC_CD]	= vData[0];
						vNewRow[(int)TBSBS_SHIPPING_REQUEST.IxSPEC]		= vData[1];
						vNewRow[(int)TBSBS_SHIPPING_REQUEST.IxPK_NO]	= "";
						vNewRow[(int)TBSBS_SHIPPING_REQUEST.IxPK_NO_TO]	= "";
						vNewRow[(int)TBSBS_SHIPPING_REQUEST.IxPK_NO_FROM]	= "";
						vNewRow[(int)TBSBS_SHIPPING_REQUEST.IxCT_QTY]	= "";
						vNewRow[(int)TBSBS_SHIPPING_REQUEST.IxREMARKS]	= ClassLib.ComVar.Partial + vSeq + 2;
						vNewRow[(int)TBSBS_SHIPPING_REQUEST.IxATTRIBUTE] = ClassLib.ComVar.Partial + vSeq;
						vNewRow[0] = ClassLib.ComVar.Insert;
						vNewRowIndex++;
					}

					fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxSHIP_YN] = ClassLib.ComVar.No;
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Mnu_PartialProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

		#region 하단버튼

		private void Btn_InsertClickProcess()
		{
			// 0 : item code, 1 : item name, 2 : spec code, 3 : spec name, 4 : color code, 5 : color name, 6 : unit
			FlexBase.MaterialBase.Pop_Item_List Pop_Item = new FlexBase.MaterialBase.Pop_Item_List();
			Pop_Item.ShowDialog();

			if (!COM.ComVar.Parameter_PopUp[0].Equals(""))
			{
				int vSeq = (fgrid_shipping.Rows.Fixed >= fgrid_shipping.Rows.Count) ? 1 : this.GetMaxSeq() + 1;

				int vRow = fgrid_shipping.Rows.Count;
				fgrid_shipping.Add_Row(vRow - 1);
				//fgrid_shipping.Rows[vRow].IsNode = true;
				//fgrid_shipping.Rows[vRow].Node.Level = 1;

				fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxSHIP_SEQ] = vSeq;

				fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxITEM_CD]		= COM.ComVar.Parameter_PopUp[0];
				fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxITEM]		= COM.ComVar.Parameter_PopUp[1];
				fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxSPEC_CD]		= COM.ComVar.Parameter_PopUp[2];
				fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxSPEC]		= COM.ComVar.Parameter_PopUp[3];
				fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxCOLOR_CD]	= COM.ComVar.Parameter_PopUp[4];
				fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxCOLOR]		= COM.ComVar.Parameter_PopUp[5];
				fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxUNIT]		= COM.ComVar.Parameter_PopUp[6];
				fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxFACTORY]		= cmb_factory.SelectedValue;
				fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxSHIP_YN]		= ClassLib.ComVar.Yes;
				fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxSTATUS]		= ClassLib.ComVar.Save;
				//fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxMERGE_TYPE]	= "N";
				fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxREMARKS]		= "N" + vSeq + "1";
				fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxATTRIBUTE]	= "N" + vSeq;
			}
		}

		private void Btn_DeleteClickProcess()
		{
			fgrid_shipping.Delete_Row();
		}

		private void Btn_RecoverClickProcess()
		{
			fgrid_shipping.Recover_Row();
		}

		#endregion

		#region Validate Check

		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			// 공통 체크
			if (fgrid_shipping.Rows.Count <= fgrid_shipping.Rows.Fixed 
				&& (arg_type == ClassLib.ComVar.Validate_Save ||
				arg_type == _validate_createPK || 
				arg_type == _validate_cancelPK || 
				arg_type == _validate_createBC ||
				arg_type == _validate_cancelBC ))
			{
				ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
																																	 
			if (cmb_factory.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Factory", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_factory.Focus();
				return false;
			}

			if (cmb_shipNo.SelectedIndex == -1 && arg_type != ClassLib.ComVar.Validate_Save)
			{
				ClassLib.ComFunction.User_Message("Select Shipping No", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_factory.Focus();
				return false;
			}

			// 부분별 체크 (Search, Save, Delete, Confirm..)
			switch (arg_type)
			{
				case ClassLib.ComVar.Validate_Search:

					break;
				case ClassLib.ComVar.Validate_Save:

					for(int i = fgrid_shipping.Rows.Fixed; i < fgrid_shipping.Rows.Count; i++)
					{
						if(fgrid_shipping[i, _requestReasonCol] == null || fgrid_shipping[i, _requestReasonCol].ToString().Trim() == "")
						{
							ClassLib.ComFunction.User_Message("Empty Data : " + "Request Reason", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							fgrid_shipping.Select(i, _requestReasonCol);
							return false;
						}

					}


					break;
				case ClassLib.ComVar.Validate_Delete:

					break;
				case ClassLib.ComVar.Validate_Confirm:
					if (!txt_status.Text.StartsWith(_save))
					{
						ClassLib.ComFunction.User_Message("Already create Barcode", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					break;
				case _validate_createPK:	// Btn_PackingCreateClickProcess() 에 세부 사항 체크 로직 있음
					if (fgrid_shipping.Rows.Fixed >= fgrid_shipping.Rows.Count)
					{
						ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					if (!txt_status.Text.StartsWith(_save))
					{
						ClassLib.ComFunction.User_Message("Current status is not Save", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					if (txt_packing.Text.Equals(""))
					{
						ClassLib.ComFunction.User_Message("Input Packing Characters", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						txt_packing.Focus();
						return false;
					}
					for (int vRow = fgrid_shipping.Rows.Fixed ; vRow < fgrid_shipping.Rows.Count ; vRow++)
					{
						if ((fgrid_shipping[vRow, _packingUnitQtyCol] == null || fgrid_shipping[vRow, _packingUnitQtyCol].ToString().Equals("0")) &&
							ClassLib.ComFunction.NullToBlank(fgrid_shipping[vRow, _shipYNCol]).StartsWith(ClassLib.ComVar.Yes))
						{
							ClassLib.ComFunction.User_Message("Can not divide by zero", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							fgrid_shipping.Select(vRow, _packingUnitQtyCol);
							return false;
						}
					}
					break;
				case _validate_cancelPK:
					if (!txt_status.Text.StartsWith(_packing))
					{
						ClassLib.ComFunction.User_Message("Current status is not Packing", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					break;
				case _validate_createBC:
					if (!txt_status.Text.StartsWith(_packing))
					{
						ClassLib.ComFunction.User_Message("Current status is not Packing", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					for (int vRow = fgrid_shipping.Rows.Fixed ; vRow < fgrid_shipping.Rows.Count ; vRow++)
					{
						if (ClassLib.ComFunction.NullToBlank(fgrid_shipping[vRow, _shipYNCol]).StartsWith("Y"))
						{
							double vShipQty = Convert.ToDouble(NullToZero(fgrid_shipping[vRow, _shipQtyCol]));
							double vPkQty = Convert.ToDouble(NullToZero(fgrid_shipping[vRow, _packingUnitQtyCol]));
							string vReason = ClassLib.ComFunction.NullToBlank(fgrid_shipping[vRow, (int)ClassLib.TBSBS_SHIPPING_REQUEST.IxREQUEST_REASON]);

							if (vShipQty <= 0)
							{
								ClassLib.ComFunction.User_Message("Exist Zero or Empty Data : " + "Shipping Qty", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_shipping.Select(vRow, _shipQtyCol);
								return false;
							}
							if (vPkQty <= 0)
							{
								ClassLib.ComFunction.User_Message("Exist Zero or Empty Data : " + "PK Unit Qty", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_shipping.Select(vRow, _packingUnitQtyCol);
								return false;
							}
							if (vReason.Equals(""))
							{
								ClassLib.ComFunction.User_Message("Exist Empty Data : " + "Request Reason", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_shipping.Select(vRow, (int)ClassLib.TBSBS_SHIPPING_REQUEST.IxREQUEST_REASON);
								return false;
							}
						}
					}

					if (fgrid_shipping.Rows.Fixed < fgrid_shipping.Rows.Count)
					{
						string vTemp = fgrid_shipping.GetCellRange(fgrid_shipping.Rows.Fixed, 0, fgrid_shipping.Rows.Count - 1, 0).Clip.Replace("\r", "");

						if (vTemp.Length > 0)
						{
							MessageBox.Show(this, "Exist modify data. Please save first", "Create Barcode", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return false;
						}
					}
					break;
				case _validate_cancelBC:
					if (!txt_status.Text.StartsWith(_barcode))
					{
						ClassLib.ComFunction.User_Message("Current status is not Barcode", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					break;
                case _validate_trade:
                    if (!(txt_status.Text.StartsWith(_invoice) || txt_status.Text.StartsWith(_barcode)))
                    {
                        ClassLib.ComFunction.User_Message("Current status is not Invoice", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    break;
				case _validate_ContextMenu:
					if (fgrid_shipping.Rows.Count > fgrid_shipping.Rows.Fixed)
					{
						if (fgrid_shipping.Selections.Length > 1 && !GridSelectionBlockValidCheck())
						{
							mnu_merge.Enabled = true;
							mnu_partial.Enabled = false;
						}
						else if (fgrid_shipping.Selections.Length == 1)
						{
							mnu_merge.Enabled = false;
							if (fgrid_shipping[fgrid_shipping.Row, (int)TBSBS_SHIPPING_REQUEST.IxREMARKS].ToString().StartsWith("N"))
								mnu_partial.Enabled = true;
							else
								mnu_partial.Enabled = false;
						}
						else
						{
							mnu_merge.Enabled = false;
							mnu_partial.Enabled = false;
						}

						if (fgrid_shipping.Cols[fgrid_shipping.Col].AllowEditing && fgrid_shipping.AllowEditing)
							mnu_Data.Enabled = true;
						else 
							mnu_Data.Enabled = false;

						return true;
					}
					return false;
			}
       

			return true;
		}

		#endregion

		#region 프로그램 속성

		private void CheckStatus()
		{
			bool vEnabled;

			if (txt_status.Text.Equals(ClassLib.ComVar.Save) || txt_status.Text.Equals(ClassLib.ComVar.Packing) || txt_status.Text.Equals(""))
				vEnabled = true;
			else
				vEnabled = false;

			tbtn_Save.Enabled		= vEnabled;

			btn_insert.Enabled		= vEnabled;
			btn_delete.Enabled		= vEnabled;
			btn_recover.Enabled		= vEnabled;

			switch (txt_status.Text)
			{
				case ClassLib.ComVar.Packing:
					btn_packing.Text = "P/K Cancel";
					btn_barcode.Text = "B/C Create";
					btn_packing.Enabled = true;
					btn_barcode.Enabled = true;
                    btn_invoice.Enabled = false;
					break;
				case ClassLib.ComVar.Barcode:
					btn_barcode.Text = "B/C Cancel";
					btn_barcode.Enabled = true;
					btn_packing.Enabled = false;
                    btn_invoice.Enabled = true;
					break;
				case ClassLib.ComVar.Save:
					btn_packing.Text = "P/K Create";
					btn_barcode.Text = "B/C Create";
					btn_packing.Enabled = true;
					btn_barcode.Enabled = false;
                    btn_invoice.Enabled = false;
					break;
                case "Invoice Transmit":
                    btn_packing.Text = "P/K Create";
                    btn_barcode.Text = "B/C Cancel";                    
                    btn_packing.Enabled = false;
                    btn_barcode.Enabled = false;
                    btn_invoice.Enabled = true;                    
                    break;
				case "":
					btn_packing.Text = "P/K Create";
					btn_barcode.Text = "B/C Create";
					btn_packing.Enabled = false;
					btn_barcode.Enabled = false;
                    btn_invoice.Enabled = false;  
					break;
				default:
					btn_packing.Text = "P/K Cancel";
					btn_barcode.Text = "B/C Cancel";
					btn_packing.Enabled = false;
					btn_barcode.Enabled = false;
                    btn_invoice.Enabled = false;  
					break;
			}
		}

		#endregion

		#endregion

		#region 그리드 이벤트

		// 선택영역 수정 팝업
		private void Grid_CellClickProcess()
		{
			int vCol = fgrid_shipping.Col;
			int[] vSelection = fgrid_shipping.Selections;

			COM.ComVar.Parameter_PopUp		= new string[1];
			COM.ComVar.Parameter_PopUp[0]	= fgrid_shipping[1, vCol].ToString();
	
			if (_cellCombo.ContainsKey(vCol))
				ClassLib.ComVar.Parameter_PopUp_Object = new object[]{_cellCombo[vCol]};

			Pop_BS_Shipping_List_Changer pop_changer = new Pop_BS_Shipping_List_Changer();
			pop_changer.ShowDialog();

			if (COM.ComVar.Parameter_PopUp != null)
				foreach (int i in vSelection)
				{
					if (fgrid_shipping[1, vCol].ToString().Equals("Vendor"))
					{
						fgrid_shipping[i, (int)TBSBS_SHIPPING_REQUEST.IxVENDOR] = COM.ComVar.Parameter_PopUp[0];
						fgrid_shipping[i, (int)TBSBS_SHIPPING_REQUEST.IxCUST_CD] = COM.ComVar.Parameter_PopUp[1];
					}
					else if (fgrid_shipping[1, vCol].ToString().Equals("Style"))
					{
						fgrid_shipping[i, (int)TBSBS_SHIPPING_REQUEST.IxSTYLE] = COM.ComVar.Parameter_PopUp[0];
						fgrid_shipping[i, (int)TBSBS_SHIPPING_REQUEST.IxSTYLE_CD] = COM.ComVar.Parameter_PopUp[1].Replace("-", "");
					}
					else if (fgrid_shipping.Col == (int)TBSBS_SHIPPING_REQUEST.IxSHIP_YN)
					{
						if (COM.ComVar.Parameter_PopUp[0].Equals(ClassLib.ComVar.No))
							ShippingCancel(i, fgrid_shipping.Col);
					}
					else
						fgrid_shipping[i, vCol] = COM.ComVar.Parameter_PopUp[0];

					fgrid_shipping.Update_Row(i);
				}

			pop_changer.Dispose();
		}

		/// <summary>
		/// 선택영역이 동일한 타입(merge type)인지 여부 검사
		/// 동일한 타입인 경우 : false , 그렇지 않은 경우 : true
		/// </summary>
		/// <returns>bool</returns>
		private bool GridSelectionBlockValidCheck()
		{
			C1.Win.C1FlexGrid.CellRange vSelectionRange = fgrid_shipping.Selection;
			string vCurType;
			bool vResult = false;

			for (int vRow = vSelectionRange.r1 ; vRow <= vSelectionRange.r2 ; vRow++)
			{
				vCurType = fgrid_shipping[vRow, (int)TBSBS_SHIPPING_REQUEST.IxREMARKS].ToString();

				if (!vCurType.StartsWith("N"))
				{
					vResult = true;
					break;
				}
			}

			return vResult;
		}

		private void Grid_AfterEditProcess()
		{
			string vStatus = txt_status.Text;

			if (fgrid_shipping.Col == _shipQtyCol)
				fgrid_shipping[fgrid_shipping.Row, (int)TBSBS_SHIPPING_REQUEST.IxPK_UNIT_QTY] = fgrid_shipping[fgrid_shipping.Row, (int)TBSBS_SHIPPING_REQUEST.IxSHIP_QTY];

			if (vStatus.Equals(ClassLib.ComVar.Packing) && (fgrid_shipping.Col == _shipYNCol || fgrid_shipping.Col == _packingUnitQtyCol || fgrid_shipping.Col == _shipQtyCol))
				ShippingCancel(fgrid_shipping.Row, fgrid_shipping.Col);
			else
				fgrid_shipping.Update_Row();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_shipping.Rows.Fixed > 0) && (fgrid_shipping.Row >= fgrid_shipping.Rows.Fixed))
				fgrid_shipping.Buffer_CellData = (fgrid_shipping[fgrid_shipping.Row, fgrid_shipping.Col] == null) ? "" : fgrid_shipping[fgrid_shipping.Row, fgrid_shipping.Col].ToString();
		}

		private void Grid_DoubleClickProcess()
		{
			try
			{
				if (!(fgrid_shipping.Col == (int)TBSBS_SHIPPING_REQUEST.IxSTYLE || fgrid_shipping.Col == (int)TBSBS_SHIPPING_REQUEST.IxSTYLE_CD)) return;

				fgrid_shipping.Select(fgrid_shipping.Row, (int)TBSBS_SHIPPING_REQUEST.IxMODEL);
				COM.ComVar.Parameter_PopUp = new string[]{"Style"};
				Form vPop = new Pop_BS_Shipping_List_Changer();
				vPop.ShowDialog();
				if (COM.ComVar.Parameter_PopUp != null)
				{
					fgrid_shipping[fgrid_shipping.Row, (int)TBSBS_SHIPPING_REQUEST.IxSTYLE] = COM.ComVar.Parameter_PopUp[0];
					fgrid_shipping[fgrid_shipping.Row, (int)TBSBS_SHIPPING_REQUEST.IxSTYLE_CD] = COM.ComVar.Parameter_PopUp[1].Replace("-", "");
				}
			}
			catch (Exception ex)
			{
				COM.ComFunction.User_Message(ex.Message, "Grid_DoubleClickProcess");
			}
		}

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SBS_SHIPPING_HEAD : 선적 번호 리스트 찾기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_ship_ymd">선적일</param>
		/// <param name="arg_devision">구분</param>
		/// <param name="arg_size">사이즈구분</param>
		/// <param name="arg_material_type">자재구분</param>
		/// <param name="arg_obs_type">OBS Type</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBS_SHIPPING_HEAD_SNO()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_HEAD.SELECT_SHIP_NO_REQUEST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_YMD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(cmb_factory, " ");
			MyOraDB.Parameter_Values[1] = this.dpick_shipYmd.Text.Replace("-", "");
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBS_SHIPPING_HEAD : 헤더 정보 찾기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_ship_no">선적번호</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBS_SHIPPING_HEAD(string arg_factory, string arg_ship_no)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_HEAD.SELECT_SBS_SHIPPING_HEAD";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_NO";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_ship_no;
			MyOraDB.Parameter_Values[2] = "";

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
		public DataTable SELECT_SBS_SHIPPING_TAIL_LIST(string arg_factory, string arg_ship_no)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_REQUEST.SELECT_SBS_SHIPPING_REQUEST_2";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_THIS_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_NO";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[1] = arg_factory;
			MyOraDB.Parameter_Values[2] = arg_ship_no;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBS_SHIPPING_REQUEST : 일별 증가된 패킹 번호 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBS_SHIPPING_NEXT_PK_NO()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_REQUEST.SELECT_SBS_SHIPPING_NEXT_PK_NO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_YMD";
			MyOraDB.Parameter_Name[2] = "ARG_PACKING";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = dpick_shipYmd.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_TextBox(txt_packing, "");
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBS_SHIPPING_REQUEST : 헤더 정보 저장
		/// </summary>
		public bool SAVE_SBS_SHIPPING_LIST_HEAD(string arg_division, string arg_shipNo)
		{
			try
			{
				MyOraDB.ReDim_Parameter(10);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBS_SHIPPING_REQUEST.SAVE_SBS_SHIPPING_LIST_HEAD";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_SHIP_NO";
				MyOraDB.Parameter_Name[3] = "ARG_SHIP_YMD";
				MyOraDB.Parameter_Name[4] = "ARG_PACKING";
				MyOraDB.Parameter_Name[5] = "ARG_PLAN_QTY";
				MyOraDB.Parameter_Name[6] = "ARG_SHIP_QTY";
				MyOraDB.Parameter_Name[7] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[8] = "ARG_STATUS";
				MyOraDB.Parameter_Name[9] = "ARG_UPD_USER";

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

				int vShipQty = 0;

				for (int i = fgrid_shipping.Rows.Fixed ; i < fgrid_shipping.Rows.Count ; i++)
				{
					vShipQty += Convert.ToInt32(fgrid_shipping[i, (int)TBSBS_SHIPPING_REQUEST.IxSHIP_QTY]);
				}

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_division;
				MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_Combo(cmb_factory, " ");
				MyOraDB.Parameter_Values[2] = arg_shipNo;
				MyOraDB.Parameter_Values[3] = this.dpick_shipYmd.Text.Replace("-", "");
				MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_TextBox(txt_packing, " ");
				MyOraDB.Parameter_Values[5] = vShipQty.ToString();
				MyOraDB.Parameter_Values[6] = vShipQty.ToString();
				MyOraDB.Parameter_Values[7] = ClassLib.ComFunction.Empty_TextBox(txt_remarks, " ");
				MyOraDB.Parameter_Values[8] = ClassLib.ComFunction.Empty_TextBox(txt_status, " ").Substring(0, 1);
				MyOraDB.Parameter_Values[9] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);
				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SAVE_SBS_SHIPPING_LIST_HEAD", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		/// <summary>
		/// MAKE_BARCODE : make barcode 
		/// </summary>
		public void MAKE_BARCODE()
		{
			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_REQUEST.MAKE_BARCODE_SHIPPING_REQUEST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_NO";
			MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipNo, "");
			MyOraDB.Parameter_Values[2] = COM.ComVar.This_User;

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
		}


        /// <summary>
        /// PKG_SBS_SHIPPING_LIST : 
        /// </summary>
        public void SALESCONTRACT_PROCESS(string arg_processName, string arg_factory, string arg_ship_no)
        {
            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = arg_processName;

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SHIP_NO";
            MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_ship_no;
            MyOraDB.Parameter_Values[2] = COM.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }




		/// <summary>
		/// PKG_SBS_SHIPPING_LIST : 
		/// </summary>
		public DataTable CANCEL_BARCODE()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST.CANCEL_BARCODE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_NO";
			MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipNo, "");
			MyOraDB.Parameter_Values[2] = COM.ComVar.This_User;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		#endregion

  

	}
}

