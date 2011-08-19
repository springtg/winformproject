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

namespace FlexPurchase.Shipping
{
	public class Form_BR_Report_MRP_To_SL : COM.PCHWinForm.Form_Top
	{
		#region 윈폼 멤버

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		public System.Windows.Forms.Panel pnl_head;
		private C1.Win.C1List.C1Combo cmb_shipType;
		private System.Windows.Forms.Label lbl_shipType;
		private System.Windows.Forms.Label lbl_style;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_shipFactory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.TextBox txt_styleCode;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.TextBox txt_styleCd;
		private C1.Win.C1List.C1Combo cmb_style;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label btn_mrpDS;
		private System.Windows.Forms.Label btn_purchase;
		private System.Windows.Forms.Label btn_shipping;
		private System.Windows.Forms.Label btn_all;
		private System.Windows.Forms.Label lbl_ymd;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.PictureBox pictureBox1;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private SheetView _mainSheet	= null;
		private FlexPurchase.Purchase.Pop_BP_Purchase_Wait _waitPop = null;
		private Thread _thread_GetData = null;

		private string _dslink = @"http://203.228.108.19/Sephiroth_WebSvc/OraPKG.asmx";
		private string _qdlink = @"http://119.119.119.16/Sephiroth_WebSvc/OraPKG.asmx";
		private string _vjlink = @"http://211.54.128.5/Sephiroth_WebSvc/OraPKG.asmx";
		private string _jjlink = @"http://203.228.108.23/Sephiroth_WebSvc/OraPKG.asmx";

		private const int _validate_BtnClick = 10;

		private string _type;
		private string[] _shipNoTitles;
		private int[] _shipNoWidth, _cols;
		private bool[] _shipNoVisible;
		private Color _headBack, _headFore;


		#endregion

		#region 생성자 / 소멸자

		public Form_BR_Report_MRP_To_SL()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BR_Report_MRP_To_SL));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_mrpDS = new System.Windows.Forms.Label();
            this.btn_purchase = new System.Windows.Forms.Label();
            this.btn_shipping = new System.Windows.Forms.Label();
            this.btn_all = new System.Windows.Forms.Label();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.lbl_ymd = new System.Windows.Forms.Label();
            this.lbl_shipFactory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.txt_styleCd = new System.Windows.Forms.TextBox();
            this.cmb_style = new C1.Win.C1List.C1Combo();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.cmb_shipType = new C1.Win.C1List.C1Combo();
            this.lbl_shipType = new System.Windows.Forms.Label();
            this.lbl_style = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.txt_styleCode = new System.Windows.Forms.TextBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.panel2);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = "15.7986111111111:False:True;75.3472222222222:False:False;4.6875:False:True;0.6944" +
                "44444444444:False:True;\t0.393700787401575:False:True;97.6377952755905:False:Fals" +
                "e;0.393700787401575:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_mrpDS);
            this.panel2.Controls.Add(this.btn_purchase);
            this.panel2.Controls.Add(this.btn_shipping);
            this.panel2.Controls.Add(this.btn_all);
            this.panel2.Location = new System.Drawing.Point(12, 537);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 27);
            this.panel2.TabIndex = 3;
            // 
            // btn_mrpDS
            // 
            this.btn_mrpDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mrpDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_mrpDS.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_mrpDS.ImageIndex = 0;
            this.btn_mrpDS.ImageList = this.img_Button;
            this.btn_mrpDS.Location = new System.Drawing.Point(669, 2);
            this.btn_mrpDS.Name = "btn_mrpDS";
            this.btn_mrpDS.Size = new System.Drawing.Size(80, 23);
            this.btn_mrpDS.TabIndex = 448;
            this.btn_mrpDS.Text = "DS MRP";
            this.btn_mrpDS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_mrpDS.Click += new System.EventHandler(this.btn_mrpDS_Click);
            this.btn_mrpDS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_mrpDS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_purchase
            // 
            this.btn_purchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_purchase.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_purchase.ImageIndex = 0;
            this.btn_purchase.ImageList = this.img_Button;
            this.btn_purchase.Location = new System.Drawing.Point(750, 2);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(80, 23);
            this.btn_purchase.TabIndex = 448;
            this.btn_purchase.Text = "Purchase";
            this.btn_purchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            this.btn_purchase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_purchase.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_shipping
            // 
            this.btn_shipping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shipping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_shipping.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_shipping.ImageIndex = 0;
            this.btn_shipping.ImageList = this.img_Button;
            this.btn_shipping.Location = new System.Drawing.Point(831, 2);
            this.btn_shipping.Name = "btn_shipping";
            this.btn_shipping.Size = new System.Drawing.Size(80, 23);
            this.btn_shipping.TabIndex = 448;
            this.btn_shipping.Text = "Shipping";
            this.btn_shipping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_shipping.Click += new System.EventHandler(this.btn_shipping_Click);
            this.btn_shipping.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_shipping.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_all
            // 
            this.btn_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_all.Enabled = false;
            this.btn_all.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_all.ImageIndex = 0;
            this.btn_all.ImageList = this.img_Button;
            this.btn_all.Location = new System.Drawing.Point(912, 2);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(80, 23);
            this.btn_all.TabIndex = 448;
            this.btn_all.Text = "All";
            this.btn_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            this.btn_all.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_all.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // spd_main
            // 
            this.spd_main.Location = new System.Drawing.Point(12, 99);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(992, 434);
            this.spd_main.TabIndex = 2;
            this.spd_main.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellClick);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.lbl_ymd);
            this.pnl_head.Controls.Add(this.lbl_shipFactory);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pictureBox1);
            this.pnl_head.Controls.Add(this.dpick_from);
            this.pnl_head.Controls.Add(this.dpick_to);
            this.pnl_head.Controls.Add(this.lblexcep_mark);
            this.pnl_head.Controls.Add(this.txt_styleCd);
            this.pnl_head.Controls.Add(this.cmb_style);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.cmb_shipType);
            this.pnl_head.Controls.Add(this.lbl_shipType);
            this.pnl_head.Controls.Add(this.lbl_style);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(992, 91);
            this.pnl_head.TabIndex = 1;
            // 
            // lbl_ymd
            // 
            this.lbl_ymd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ymd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ymd.ImageIndex = 1;
            this.lbl_ymd.ImageList = this.img_Label;
            this.lbl_ymd.Location = new System.Drawing.Point(8, 62);
            this.lbl_ymd.Name = "lbl_ymd";
            this.lbl_ymd.Size = new System.Drawing.Size(100, 19);
            this.lbl_ymd.TabIndex = 50;
            this.lbl_ymd.Text = "Ship Date";
            this.lbl_ymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_shipFactory
            // 
            this.lbl_shipFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipFactory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipFactory.ImageIndex = 1;
            this.lbl_shipFactory.ImageList = this.img_Label;
            this.lbl_shipFactory.Location = new System.Drawing.Point(8, 40);
            this.lbl_shipFactory.Name = "lbl_shipFactory";
            this.lbl_shipFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipFactory.TabIndex = 50;
            this.lbl_shipFactory.Text = "Factory";
            this.lbl_shipFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label2.Text = "      MRP Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 54);
            this.pictureBox1.TabIndex = 539;
            this.pictureBox1.TabStop = false;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(109, 62);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(100, 21);
            this.dpick_from.TabIndex = 536;
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(230, 62);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(100, 21);
            this.dpick_to.TabIndex = 537;
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(210, 62);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(16, 16);
            this.lblexcep_mark.TabIndex = 538;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_styleCd
            // 
            this.txt_styleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_styleCd.Location = new System.Drawing.Point(448, 62);
            this.txt_styleCd.MaxLength = 10;
            this.txt_styleCd.Name = "txt_styleCd";
            this.txt_styleCd.Size = new System.Drawing.Size(79, 21);
            this.txt_styleCd.TabIndex = 535;
            this.txt_styleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_styleCd_KeyUp);
            // 
            // cmb_style
            // 
            this.cmb_style.AccessibleDescription = "";
            this.cmb_style.AccessibleName = "";
            this.cmb_style.AddItemCols = 0;
            this.cmb_style.AddItemSeparator = ';';
            this.cmb_style.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_style.Caption = "";
            this.cmb_style.CaptionHeight = 17;
            this.cmb_style.CaptionStyle = style1;
            this.cmb_style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_style.ColumnCaptionHeight = 18;
            this.cmb_style.ColumnFooterHeight = 18;
            this.cmb_style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_style.ContentHeight = 17;
            this.cmb_style.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_style.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_style.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_style.EditorHeight = 17;
            this.cmb_style.EvenRowStyle = style2;
            this.cmb_style.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style.FooterStyle = style3;
            this.cmb_style.GapHeight = 2;
            this.cmb_style.HeadingStyle = style4;
            this.cmb_style.HighLightRowStyle = style5;
            this.cmb_style.ItemHeight = 15;
            this.cmb_style.Location = new System.Drawing.Point(528, 62);
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
            this.cmb_style.Size = new System.Drawing.Size(140, 21);
            this.cmb_style.Style = style8;
            this.cmb_style.TabIndex = 533;
            this.cmb_style.SelectedValueChanged += new System.EventHandler(this.cmb_style_TextChanged);
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style9;
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
            this.cmb_factory.EvenRowStyle = style10;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style11;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style12;
            this.cmb_factory.HighLightRowStyle = style13;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style14;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style15;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style16;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            // 
            // cmb_shipType
            // 
            this.cmb_shipType.AddItemCols = 0;
            this.cmb_shipType.AddItemSeparator = ';';
            this.cmb_shipType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipType.Caption = "";
            this.cmb_shipType.CaptionHeight = 17;
            this.cmb_shipType.CaptionStyle = style17;
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
            this.cmb_shipType.EvenRowStyle = style18;
            this.cmb_shipType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipType.FooterStyle = style19;
            this.cmb_shipType.GapHeight = 2;
            this.cmb_shipType.HeadingStyle = style20;
            this.cmb_shipType.HighLightRowStyle = style21;
            this.cmb_shipType.ItemHeight = 15;
            this.cmb_shipType.Location = new System.Drawing.Point(448, 40);
            this.cmb_shipType.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipType.MaxDropDownItems = ((short)(5));
            this.cmb_shipType.MaxLength = 32767;
            this.cmb_shipType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipType.Name = "cmb_shipType";
            this.cmb_shipType.OddRowStyle = style22;
            this.cmb_shipType.PartialRightColumn = false;
            this.cmb_shipType.PropBag = resources.GetString("cmb_shipType.PropBag");
            this.cmb_shipType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipType.SelectedStyle = style23;
            this.cmb_shipType.Size = new System.Drawing.Size(220, 20);
            this.cmb_shipType.Style = style24;
            this.cmb_shipType.TabIndex = 12;
            this.cmb_shipType.SelectedValueChanged += new System.EventHandler(this.cmb_shipType_SelectedValueChanged);
            // 
            // lbl_shipType
            // 
            this.lbl_shipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipType.ImageIndex = 1;
            this.lbl_shipType.ImageList = this.img_Label;
            this.lbl_shipType.Location = new System.Drawing.Point(344, 40);
            this.lbl_shipType.Name = "lbl_shipType";
            this.lbl_shipType.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipType.TabIndex = 56;
            this.lbl_shipType.Text = "Ship Type";
            this.lbl_shipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_style
            // 
            this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_style.ImageIndex = 0;
            this.lbl_style.ImageList = this.img_Label;
            this.lbl_style.Location = new System.Drawing.Point(344, 62);
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
            this.pic_head3.Location = new System.Drawing.Point(976, 75);
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
            this.pic_head4.Location = new System.Drawing.Point(136, 74);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(952, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(891, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 50);
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
            this.pic_head5.Location = new System.Drawing.Point(0, 75);
            this.pic_head5.Name = "pic_head5";
            this.pic_head5.Size = new System.Drawing.Size(168, 20);
            this.pic_head5.TabIndex = 43;
            this.pic_head5.TabStop = false;
            // 
            // txt_styleCode
            // 
            this.txt_styleCode.Location = new System.Drawing.Point(0, 0);
            this.txt_styleCode.Name = "txt_styleCode";
            this.txt_styleCode.Size = new System.Drawing.Size(100, 21);
            this.txt_styleCode.TabIndex = 0;
            // 
            // pic_head6
            // 
            this.pic_head6.Location = new System.Drawing.Point(0, 0);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(100, 50);
            this.pic_head6.TabIndex = 0;
            this.pic_head6.TabStop = false;
            // 
            // Form_BR_Report_MRP_To_SL
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BR_Report_MRP_To_SL";
            this.Load += new System.EventHandler(this.Form_BR_Report_MRP_To_SL_Load);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 컨트롤 이벤트

		private void Form_BR_Report_MRP_To_SL_Load(object sender, System.EventArgs e)
		{
			this.Init_Form();
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Init_HeaderFactory();
			spd_main.ClearAll();
		}

		private void cmb_shipType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			spd_main.ClearAll();
		}

		private void btn_mrpDS_Click(object sender, System.EventArgs e)
		{
			if (this.Validate_Check(_validate_BtnClick))
			{
				_cols = new int[]{ (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxDS_SHIPPING_SCHEDULE,
									 (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxDS_MRP_RECEIVE,
									 (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxDS_MRP_MODIFY };

				_type = "MRP";

				Thread_GetData();
			}
		}

		private void btn_purchase_Click(object sender, System.EventArgs e)
		{
			if (this.Validate_Check(_validate_BtnClick))
			{
				_cols = new int[]{ (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxDS_PURCHASE_MANAGER,
									 (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxDS_PURCHASE_ORDER_RECEIVE,
									 (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxDS_PURCHASE_ORDER_MODIFY };

				_type = "PURCHASE";

				Thread_GetData();
			}
		}

		private void btn_shipping_Click(object sender, System.EventArgs e)
		{
			if (this.Validate_Check(_validate_BtnClick))
			{
				_cols = new int[]{ (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxDS_SHIPPING_LIST_CREATE,
									 (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxDS_SHIPPING_LIST_MODIFY,
									 (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxDS_BAR_CODE };

				_type = "SHIPPING";
			
				Thread_GetData();
			}
		}

		private void btn_all_Click(object sender, System.EventArgs e)
		{
			if (this.Validate_Check(_validate_BtnClick))
			{
				_cols = new int[]{ (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxDS_SHIPPING_SCHEDULE,
									 (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxDS_MRP_RECEIVE,
									 (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxDS_MRP_MODIFY };
				_type = "ALL";

				Thread_GetData();
			}
		}

		private void spd_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			string vHead = _mainSheet.ColumnHeader.Cells[1, e.Column].Text;

			int vStart	= e.Column;
			int vEnd	= e.Column;

			for (int vCol = _mainSheet.FrozenColumnCount ; vCol < _mainSheet.ColumnCount ; vCol++)
			{
				if (_mainSheet.ColumnHeader.Cells[1, vCol].Text.Equals(vHead))
				{
					_mainSheet.ColumnHeader.Cells[1, vCol, 2, vCol].BackColor = ClassLib.ComVar.RightYellow;
					_mainSheet.ColumnHeader.Cells[1, vCol, 2, vCol].ForeColor = Color.Black;
				}
				else
				{
					_mainSheet.ColumnHeader.Cells[1, vCol, 2, vCol].BackColor = _headBack;
					_mainSheet.ColumnHeader.Cells[1, vCol, 2, vCol].ForeColor = _headFore;
				}
			}
		}


		#region 버튼 클릭 이벤트

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		#endregion

		#endregion

		#region 툴바 메뉴 이벤트

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			cmb_factory.SelectedValue = COM.ComVar.This_Factory;
            dpick_from.Value = DateTime.Now;
			dpick_to.Value = DateTime.Now;
			cmb_style.SelectedIndex = -1;
			spd_main.ClearAll();
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (this.Validate_Check(ClassLib.ComVar.Validate_Search))
			{
				Search_Data();
			}
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
		}

		#endregion

		#region 이벤트 처리 메서드

		#region 초기화

		private void Init_Form()
		{
			try
            {
				this.Text = "MRP Monitoring By Shipping List";
                lbl_MainTitle.Text = "MRP Monitoring By Shipping List";
                ClassLib.ComFunction.SetLangDic(this);

				spd_main.Set_Spread_Comm("SB_REPORT_MRP_TO_SL", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
				_mainSheet = spd_main.ActiveSheet;

				_shipNoTitles			= new string[]{"MRP Ship No", "Request Reason"};
				_shipNoWidth			= new int[]{	150,			60};
				_shipNoVisible			= new bool[]{true, true};

				tbtn_Save.Enabled		= false;
				tbtn_Delete.Enabled		= false;
				tbtn_Confirm.Enabled	= false;
				tbtn_Create.Enabled		= false;

				_headBack = _mainSheet.ColumnHeader.Cells[0, 0].BackColor;
				_headFore = _mainSheet.ColumnHeader.Cells[0, 0].ForeColor;

				Init_Combo();
				Init_Header();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void Init_Combo()
		{
			// factory set
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar. This_Factory;
			vDt.Dispose();

			// ship type set
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPShipType);
			COM.ComCtl.Set_ComboList(vDt, cmb_shipType, 1, 2, true);
			cmb_shipType.SelectedValue = (cmb_shipType.Tag == null) ? "11" : cmb_shipType.Tag;
			vDt.Dispose();
		}

		private void Init_Header()
		{
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

		private void Init_HeaderFactory()
		{
			string vFactory = cmb_factory.SelectedValue.ToString();

			vFactory = vFactory.Equals("DS") ? "" : vFactory + " ";

			int vCol1 = (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxMRP_RUN;
			int vCol2 = (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxMRP_MODIFY;
			int vCol3 = (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxMRP_SEND;

			_mainSheet.ColumnHeader.Cells[1, vCol1].Text = vFactory + "MRP";
			_mainSheet.ColumnHeader.Cells[1, vCol2].Text = vFactory + "MRP";
			_mainSheet.ColumnHeader.Cells[1, vCol3].Text = vFactory + "MRP";
		}

		#endregion

		#region 툴바 메뉴 이벤트 메서드

		private void Search_Data()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				COM.ComVar._WebSvc.Url = GetService(cmb_factory.SelectedValue.ToString());

				_waitPop = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
				Thread vSearchThread = new Thread(new ThreadStart(_waitPop.Start));
				vSearchThread.Start();

				DataTable vDt = this.SELECT_MRP_DATA();

				if (vDt.Rows.Count > 0)
				{
					spd_main.Display_Grid(vDt);
				}
				else
				{
					spd_main.ClearAll();
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				COM.ComVar._WebSvc.Url = GetService(COM.ComVar.This_Factory);
				_waitPop.Close();
			}
		}

		#endregion

		#region 컨트롤 이벤트 처리 메서드

		private void txt_styleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				this.Txt_StyleCdKeyUpProcess();
		}

		private void Txt_StyleCdKeyUpProcess()
		{
			DataTable vDt = null;

			try
			{
				vDt = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_styleCd, " "));
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				ClassLib.ComFunction.Set_ComboList_5(vDt, cmb_style, 0, 1, 2, 3, 4, true, 100, 221); 
				vDt.Dispose();
				
				if (txt_styleCd.Text.Length == 9)
				{
					string vCode = txt_styleCd.Text;
					vCode = vCode.Substring(0, 6) + "-" + vCode.Substring(6, 3);
					cmb_style.SelectedValue = vCode;
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

		private void cmb_style_TextChanged(object sender, System.EventArgs e)
		{
			if(cmb_style.SelectedIndex != 0)
			{
				txt_styleCd.Text = COM.ComFunction.Empty_Combo(cmb_style, "");
			}
		}

		private string GetService(string arg_factory)
		{
			try
			{
				string vServiceUrl = COM.ComVar._WebSvc.Url;

				switch (arg_factory)
				{
					case "DS":
						vServiceUrl = _dslink;
						break;
					case "QD":
						vServiceUrl = _qdlink;
						break;
					case "VJ":
						vServiceUrl = _vjlink;
						break;
					case "JJ":
						vServiceUrl = _jjlink;
						break;
				}

				return vServiceUrl;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Service", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return COM.ComVar._WebSvc.Url;
			}
		}

		private void Thread_GetData()
		{
			try
			{
				if (_thread_GetData != null)
				{
					if (_thread_GetData.IsAlive)
					{
						ClassLib.ComFunction.User_Message("Process Already Running", "Process", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
				}

				_thread_GetData = new Thread(new ThreadStart(this.Get_AfterMRPData));
				_thread_GetData.Start();
			}
			catch (Exception ex)
			{
				if (_thread_GetData != null)	_thread_GetData.Abort();
				ClassLib.ComFunction.User_Message(ex.Message, "Thread", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void Get_AfterMRPData()
		{
			try
			{
				string arg_type = (string)_type.Clone();
				int[] arg_cols = (int[])_cols.Clone();

				COM.ComVar._WebSvc.Url = GetService("DS");
				
				for (int vRow = 0 ; vRow < _mainSheet.RowCount ; vRow++)
				{
					int vIdx = 0;

					_mainSheet.ClearSelection();
					_mainSheet.AddSelection(vRow, 0, 1, _mainSheet.ColumnCount - 1);

					foreach (int arg_col in arg_cols)
					{
						_mainSheet.Cells[vRow, arg_col].Value = arg_type + " Loading..";
					}

					DataTable vDt = this.SELECT_AFTER_MRP_DATA(vRow, arg_type);

					if (vDt.Rows.Count > 0)
					{
						vIdx = 0;

						foreach (int arg_col in arg_cols)
						{
							string vDate = ClassLib.ComFunction.NullToBlank(vDt.Rows[0].ItemArray[vIdx]);
							_mainSheet.Cells[vRow, arg_col].Value = vDate;
							vIdx++;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "ETC Data Loaging", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				COM.ComVar._WebSvc.Url = GetService(COM.ComVar.This_Factory);
			}
		}

		#endregion

		#region 정합성 체크

		private bool Validate_Check(int arg_type)
		{
			// 공통 체크
			if (cmb_factory.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Factory", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_factory.Focus();
				return false;
			}

			if (cmb_shipType.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Ship Type", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_shipType.Focus();
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

					break;
				case _validate_BtnClick:
					if (_mainSheet.RowCount == 0)
					{
						ClassLib.ComFunction.User_Message("Data Not Found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}

					break;
			}

			return true;
		}

		#endregion

		#endregion

		#region DB Connect

		/// <summary>
		/// PKG_SBM_READY.SELECT_MRP_DATA : 해외 MRP 데이터 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_MRP_DATA()
		{
			try
			{
				DataSet vds_ret;

				MyOraDB.ReDim_Parameter(7);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_READY.SELECT_MRP_DATA";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_THIS_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[3] = "ARG_SHIP_YMD_FROM";
				MyOraDB.Parameter_Name[4] = "ARG_SHIP_YMD_TO";
				MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";
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
				MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
				MyOraDB.Parameter_Values[3] = dpick_from.Value.ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[4] = dpick_to.Value.ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_Combo(cmb_style, "").Replace("-", "");
				MyOraDB.Parameter_Values[6] = "";

				MyOraDB.Add_Select_Parameter(true);
				vds_ret = MyOraDB.Exe_Select_Procedure();
				if(vds_ret == null) return null ;

				return vds_ret.Tables[MyOraDB.Process_Name];
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "MRP Data Loaging", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}
		}

		/// <summary>
		/// PKG_SBM_READY.SELECT_AFTER_MRP_DATA : 한국 MRP 데이터 검색하기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_AFTER_MRP_DATA(int arg_row, string arg_division)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(10);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_READY.SELECT_AFTER_MRP_DATA";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1] = "ARG_THIS_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[4] = "ARG_MRP_SHIP_NO";
			MyOraDB.Parameter_Name[5] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[6] = "ARG_LOT_NO";
			MyOraDB.Parameter_Name[7] = "ARG_LOT_SEQ";
			MyOraDB.Parameter_Name[8] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[9] = "OUT_CURSOR";

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
			MyOraDB.Parameter_Type[9] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_division;
			MyOraDB.Parameter_Values[1] = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[arg_row, (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxFACTORY].Value);
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[arg_row, (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxSHIP_TYPE].Value);
			MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[arg_row, (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxMRP_SHIP_NO].Value);
			MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[arg_row, (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxOBS_TYPE].Value);
			MyOraDB.Parameter_Values[6] = ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[arg_row, (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxLOT_NO].Value);
			MyOraDB.Parameter_Values[7] = ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[arg_row, (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxLOT_SEQ].Value);
			MyOraDB.Parameter_Values[8] = ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[arg_row, (int)ClassLib.TBSB_REPORT_MRP_TO_SL.IxSTYLE_CD].Value);
			MyOraDB.Parameter_Values[9] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		#endregion
	}
}
