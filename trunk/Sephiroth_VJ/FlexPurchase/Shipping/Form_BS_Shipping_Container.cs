using System;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FlexPurchase.Shipping
{
	/// <summary>
	/// Form_BB_Remainder에 대한 요약 설명입니다.
	/// </summary>
	public class Form_BS_Shipping_Container : COM.PCHWinForm.Pop_Large
	{
		#region 디자이너에서 생성한 변수

		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Panel pnl_main;
		private System.Windows.Forms.Panel pnl_btn;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label btn_delete;
		private System.Windows.Forms.Label btn_insert;
		private System.Windows.Forms.Label lbl_titleHead;
		private System.Windows.Forms.Label lbl_shipFact;
		private System.Windows.Forms.Label lbl_factYmd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head7;
		public System.Windows.Forms.StatusBar stbar;
		private System.Windows.Forms.StatusBarPanel info_bar;
		private System.Windows.Forms.StatusBarPanel formname_bar;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.DateTimePicker dt_shipYmdFr;
		private C1.Win.C1List.C1Combo cmb_shipFact;
		private System.Windows.Forms.DateTimePicker dt_shipYmdTo;
		private COM.SSP spd_main;

		#endregion

		#region 사용자 정의 멤버변수
		
		private COM.OraDB MyOraDB = new COM.OraDB();
		private FarPoint.Win.Spread.SheetView _mainSheet				 = null;
		private FarPoint.Win.Spread.CellType.ComboBoxCellType vComboType = null;
		private FarPoint.Win.Spread.CellType.TextCellType vTextType		 = null;
		private int _contNoCol   = (int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_NO;
		private System.Windows.Forms.ContextMenu ctx_contNo;
		private System.Windows.Forms.Menu.MenuItemCollection _contNo;
		private System.Windows.Forms.ListBox _shipFactList;
		private System.Windows.Forms.ListBox _contUnitList;

		#endregion
		private System.Windows.Forms.MenuItem ctx_Change;

		#region 생성자 / 소멸자

		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form_BS_Shipping_Container()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BS_Shipping_Container));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_btn = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Label();
            this.btn_recover = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.spd_main = new COM.SSP();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.ctx_Change = new System.Windows.Forms.MenuItem();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.dt_shipYmdFr = new System.Windows.Forms.DateTimePicker();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.lbl_titleHead = new System.Windows.Forms.Label();
            this.dt_shipYmdTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_factYmd = new System.Windows.Forms.Label();
            this.cmb_shipFact = new C1.Win.C1List.C1Combo();
            this.lbl_shipFact = new System.Windows.Forms.Label();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.stbar = new System.Windows.Forms.StatusBar();
            this.info_bar = new System.Windows.Forms.StatusBarPanel();
            this.formname_bar = new System.Windows.Forms.StatusBarPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_btn.SuspendLayout();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipFact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formname_bar)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.pnl_btn);
            this.c1Sizer1.Controls.Add(this.pnl_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = "14.9068322981366:False:True;75.1552795031056:False:False;6.62525879917184:False:T" +
                "rue;\t0.504413619167718:False:True;96.9735182849937:False:False;0.504413619167718" +
                ":False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(793, 483);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_btn
            // 
            this.pnl_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_btn.Controls.Add(this.btn_delete);
            this.pnl_btn.Controls.Add(this.btn_insert);
            this.pnl_btn.Controls.Add(this.btn_recover);
            this.pnl_btn.Location = new System.Drawing.Point(12, 447);
            this.pnl_btn.Name = "pnl_btn";
            this.pnl_btn.Size = new System.Drawing.Size(769, 32);
            this.pnl_btn.TabIndex = 2;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_delete.ImageIndex = 5;
            this.btn_delete.ImageList = this.image_List;
            this.btn_delete.Location = new System.Drawing.Point(606, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(80, 23);
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
            this.btn_insert.Location = new System.Drawing.Point(525, 4);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(80, 23);
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
            this.btn_recover.Location = new System.Drawing.Point(687, 4);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(80, 23);
            this.btn_recover.TabIndex = 359;
            this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_recover.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_recover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseDown);
            this.btn_recover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseUp);
            // 
            // pnl_main
            // 
            this.pnl_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_main.Controls.Add(this.spd_main);
            this.pnl_main.Location = new System.Drawing.Point(12, 80);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(769, 363);
            this.pnl_main.TabIndex = 1;
            // 
            // spd_main
            // 
            this.spd_main.ContextMenu = this.contextMenu1;
            this.spd_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spd_main.Location = new System.Drawing.Point(0, 0);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(769, 363);
            this.spd_main.TabIndex = 0;
            this.spd_main.EditModeOn += new System.EventHandler(this.spd_main_EditModeOn);
            this.spd_main.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_EditChange);
            this.spd_main.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellDoubleClick);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ctx_Change});
            // 
            // ctx_Change
            // 
            this.ctx_Change.Index = 0;
            this.ctx_Change.Text = "Container Change";
            this.ctx_Change.Click += new System.EventHandler(this.ctx_Change_Click);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // pnl_head
            // 
            this.pnl_head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.dt_shipYmdFr);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.lbl_titleHead);
            this.pnl_head.Controls.Add(this.dt_shipYmdTo);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.lbl_factYmd);
            this.pnl_head.Controls.Add(this.cmb_shipFact);
            this.pnl_head.Controls.Add(this.lbl_shipFact);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(769, 72);
            this.pnl_head.TabIndex = 0;
            // 
            // dt_shipYmdFr
            // 
            this.dt_shipYmdFr.CustomFormat = "";
            this.dt_shipYmdFr.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_shipYmdFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_shipYmdFr.Location = new System.Drawing.Point(431, 37);
            this.dt_shipYmdFr.Name = "dt_shipYmdFr";
            this.dt_shipYmdFr.Size = new System.Drawing.Size(100, 21);
            this.dt_shipYmdFr.TabIndex = 2;
            this.dt_shipYmdFr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dt_shipYmdFr_KeyPress);
            this.dt_shipYmdFr.CloseUp += new System.EventHandler(this.dt_shipYmdFr_CloseUp);
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(667, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 32);
            this.pic_head7.TabIndex = 207;
            this.pic_head7.TabStop = false;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(752, 52);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 206;
            this.pic_head3.TabStop = false;
            // 
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(752, 0);
            this.pic_head2.Name = "pic_head2";
            this.pic_head2.Size = new System.Drawing.Size(16, 32);
            this.pic_head2.TabIndex = 205;
            this.pic_head2.TabStop = false;
            // 
            // lbl_titleHead
            // 
            this.lbl_titleHead.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_titleHead.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_titleHead.ForeColor = System.Drawing.Color.Navy;
            this.lbl_titleHead.Image = ((System.Drawing.Image)(resources.GetObject("lbl_titleHead.Image")));
            this.lbl_titleHead.Location = new System.Drawing.Point(0, 0);
            this.lbl_titleHead.Name = "lbl_titleHead";
            this.lbl_titleHead.Size = new System.Drawing.Size(231, 30);
            this.lbl_titleHead.TabIndex = 42;
            this.lbl_titleHead.Text = "      Shipping Container Info.";
            this.lbl_titleHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dt_shipYmdTo
            // 
            this.dt_shipYmdTo.CustomFormat = "";
            this.dt_shipYmdTo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_shipYmdTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_shipYmdTo.Location = new System.Drawing.Point(550, 37);
            this.dt_shipYmdTo.Name = "dt_shipYmdTo";
            this.dt_shipYmdTo.Size = new System.Drawing.Size(100, 21);
            this.dt_shipYmdTo.TabIndex = 3;
            this.dt_shipYmdTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dt_shipYmdTo_KeyPress);
            this.dt_shipYmdTo.CloseUp += new System.EventHandler(this.dt_shipYmdTo_CloseUp);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(531, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 204;
            this.label1.Text = "~";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_factYmd
            // 
            this.lbl_factYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factYmd.ImageIndex = 1;
            this.lbl_factYmd.ImageList = this.img_Label;
            this.lbl_factYmd.Location = new System.Drawing.Point(330, 37);
            this.lbl_factYmd.Name = "lbl_factYmd";
            this.lbl_factYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_factYmd.TabIndex = 199;
            this.lbl_factYmd.Text = "Date";
            this.lbl_factYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_shipFact
            // 
            this.cmb_shipFact.AddItemCols = 0;
            this.cmb_shipFact.AddItemSeparator = ';';
            this.cmb_shipFact.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipFact.Caption = "";
            this.cmb_shipFact.CaptionHeight = 17;
            this.cmb_shipFact.CaptionStyle = style1;
            this.cmb_shipFact.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_shipFact.ColumnCaptionHeight = 18;
            this.cmb_shipFact.ColumnFooterHeight = 18;
            this.cmb_shipFact.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_shipFact.ContentHeight = 16;
            this.cmb_shipFact.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_shipFact.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_shipFact.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_shipFact.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_shipFact.EditorHeight = 16;
            this.cmb_shipFact.EvenRowStyle = style2;
            this.cmb_shipFact.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipFact.FooterStyle = style3;
            this.cmb_shipFact.GapHeight = 2;
            this.cmb_shipFact.HeadingStyle = style4;
            this.cmb_shipFact.HighLightRowStyle = style5;
            this.cmb_shipFact.ItemHeight = 15;
            this.cmb_shipFact.Location = new System.Drawing.Point(108, 37);
            this.cmb_shipFact.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipFact.MaxDropDownItems = ((short)(5));
            this.cmb_shipFact.MaxLength = 32767;
            this.cmb_shipFact.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipFact.Name = "cmb_shipFact";
            this.cmb_shipFact.OddRowStyle = style6;
            this.cmb_shipFact.PartialRightColumn = false;
            this.cmb_shipFact.PropBag = resources.GetString("cmb_shipFact.PropBag");
            this.cmb_shipFact.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipFact.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipFact.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipFact.SelectedStyle = style7;
            this.cmb_shipFact.Size = new System.Drawing.Size(220, 20);
            this.cmb_shipFact.Style = style8;
            this.cmb_shipFact.TabIndex = 1;
            this.cmb_shipFact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_shipFact_KeyPress);
            this.cmb_shipFact.SelectedValueChanged += new System.EventHandler(this.cmb_shipFact_SelectedValueChanged);
            // 
            // lbl_shipFact
            // 
            this.lbl_shipFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipFact.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipFact.ImageIndex = 1;
            this.lbl_shipFact.ImageList = this.img_Label;
            this.lbl_shipFact.Location = new System.Drawing.Point(7, 37);
            this.lbl_shipFact.Name = "lbl_shipFact";
            this.lbl_shipFact.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipFact.TabIndex = 198;
            this.lbl_shipFact.Text = "Factory";
            this.lbl_shipFact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(178, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(641, 30);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 52);
            this.pic_head5.Name = "pic_head5";
            this.pic_head5.Size = new System.Drawing.Size(144, 19);
            this.pic_head5.TabIndex = 43;
            this.pic_head5.TabStop = false;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(117, 51);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(641, 17);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // pic_head6
            // 
            this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
            this.pic_head6.Location = new System.Drawing.Point(0, 15);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(144, 42);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 544);
            this.stbar.Name = "stbar";
            this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.info_bar,
            this.formname_bar});
            this.stbar.ShowPanels = true;
            this.stbar.Size = new System.Drawing.Size(792, 22);
            this.stbar.TabIndex = 30;
            // 
            // info_bar
            // 
            this.info_bar.Name = "info_bar";
            this.info_bar.Width = 150;
            // 
            // formname_bar
            // 
            this.formname_bar.Name = "formname_bar";
            this.formname_bar.Width = 300;
            // 
            // Form_BS_Shipping_Container
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.stbar);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BS_Shipping_Container";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_BS_Shipping_Container_Closing);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_btn.ResumeLayout(false);
            this.pnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.pnl_head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipFact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formname_bar)).EndInit();
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
			this.Grid_EditChangeProcess();
		}

		private void spd_main_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			if (!e.ColumnHeader)
				Grid_CellDoubleClickProcess(e.Row);
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

		private void Form_BS_Shipping_Container_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			for (int vRow = spd_main.ActiveSheet.RowCount - 1 ; vRow >= 0 ; vRow--)
			{
				if (spd_main.ActiveSheet.Cells[vRow, 0].Tag != null)
				{
					if (MessageBox.Show(this, "Exist modify data. Do you want close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						e.Cancel = true;

					break;
				}
			}
		}

		private void dt_shipYmdFr_CloseUp(object sender, System.EventArgs e)
		{
			ClearAll();
			dt_shipYmdTo.Value = dt_shipYmdFr.Value;
		}

		private void btn_insert_Click(object sender, System.EventArgs e)
		{
			this.Btn_InsertProcess();
		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			if (MessageBox.Show(this, "Do you want to delete item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				this.Btn_DeleteProcess();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Btn_CancelProcess();
		}

		private void ctx_Insert_Click(object sender, System.EventArgs e)
		{
			Btn_InsertProcess();
		}

		private void ctx_Delete_Click(object sender, System.EventArgs e)
		{
			Btn_DeleteProcess();
		}

		private void ctx_Cancel_Click(object sender, System.EventArgs e)
		{
			Btn_CancelProcess();
		}

		private void ctx_Change_Click(object sender, System.EventArgs e)
		{
			Btn_ChangeProcess();
			this.Tbtn_SearchProcess();
		}

		private void cmb_shipFact_SelectedValueChanged(object sender, System.EventArgs e)
		{
			ClearAll();
		}

		private void dt_shipYmdTo_CloseUp(object sender, System.EventArgs e)
		{
			ClearAll();
		}
	
		#region 입력이동

		private void cmb_shipFact_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == 13)
				dt_shipYmdFr.Focus();
		}

		private void dt_shipYmdFr_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void dt_shipYmdTo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == 13)
				Tbtn_SearchProcess();
		}

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

		#endregion

		#endregion

		#region 공통 메서드

		private void ClearAll()
		{
			if (spd_main.ActiveSheet.Rows.Count > 0)
				spd_main.ClearAll();
		}

		// GridSet : Fore color setting
		private void GridSetInitGrid()
		{
			int vRowCount = spd_main.Sheets[0].Rows.Count;

			for (int i = vRowCount - 1 ; i >= 0 ; i--)
			{
				string vDiv = (spd_main.Sheets[0].Cells[i, 0].Tag == null) ? "" : spd_main.Sheets[0].Cells[i, 0].Tag.ToString();
				if (vDiv.Equals(ClassLib.ComVar.Delete))
				{
					spd_main.Sheets[0].Rows[i].Remove();
					vRowCount--;
				}
			}

			spd_main.Sheets[0].ClearRange(0, 0, vRowCount, 1, false);
		}

		// GridSet : Combo cell change
		private void GridSetComboCell(bool arg_isCombo, ListBox arg_list, int arg_row, int arg_col)
		{
			FarPoint.Win.Spread.CellType.ICellType vNewCellType = null;
			object vOldValue = _mainSheet.Cells[arg_row, arg_col].Value;

			if (arg_isCombo)
			{
				vComboType.ListControl = arg_list;
				vComboType.ListAlignment = FarPoint.Win.ListAlignment.Left;
				vNewCellType = vComboType;
			}
			else
				vNewCellType = vTextType;
			
			_mainSheet.Cells[arg_row, arg_col].CellType = vNewCellType;
			_mainSheet.Cells[arg_row, arg_col].Value = vOldValue;
		}

		private void GridSetData(int arg_row)
		{
			try
			{
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_YMD].Text	= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_YMD];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_FACT].Value	= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_FACT];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_SEQ].Value	= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_SEQ];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_NO].Value	= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_NO];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_UNIT].Value	= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_UNIT];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_DESC].Value	= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_DESC];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSEAL_NO].Value	= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSEAL_NO];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxOUT_YMD].Text	= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxOUT_YMD];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxRTA_YMD].Text	= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxRTA_YMD];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxREMARKS].Value	= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxREMARKS];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSEND_CHK].Value	= "";
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSEND_YMD].Value	= "";
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxUPD_USER].Value	= COM.ComVar.This_User;
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxUPD_YMD].Value	= "";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void GridGetData(int arg_row)
		{
			try
			{
				COM.ComVar.Parameter_PopUp[0]												= ClassLib.ComVar.Insert;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_YMD]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_YMD].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_FACT]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_FACT].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_SEQ]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_SEQ].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_NO]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_NO].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_UNIT]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_UNIT].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_DESC]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_DESC].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSEAL_NO]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSEAL_NO].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxOUT_YMD]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxOUT_YMD].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxRTA_YMD]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxRTA_YMD].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxREMARKS]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxREMARKS].Text;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
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
            // ClassLib.ComFunction.Init_Form_Control(this);
            this.Text = "Shipping Container";
            lbl_MainTitle.Text = "Shipping Container";
            ClassLib.ComFunction.SetLangDic(this);
			// ClassLib.ComFunction.Init_MenuRole(this,lbl_MainTitle,tbtn_Search ,tbtn_Save,tbtn_Print) ;
			
			// Grid Setting
			spd_main.Set_Spread_Comm("SBS_SHIP_CONTAINER", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			// Ship Factory Setting
			DataTable vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt,  cmb_shipFact,  0,  1,  false);
			cmb_shipFact.SelectedValue = ClassLib.ComVar.This_Factory;
			_shipFactList = ClassLib.ComFunction.CreateListBox(vDt, 0);
			vDt.Dispose();

			// Cont Unit ListBox Setting
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBC10");
			_contUnitList = ClassLib.ComFunction.CreateListBox(vDt, 1);
			vDt.Dispose();

			// User define variable setting
			_mainSheet = spd_main.Sheets[0];
			vComboType = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
			vTextType  = new FarPoint.Win.Spread.CellType.TextCellType();
			ctx_contNo = new ContextMenu();
			_contNo = ctx_contNo.MenuItems;

			// Disabled tbutton
			tbtn_Delete.Enabled  = false;
			tbtn_Conform.Enabled = false;
		}

		#region 툴바 메뉴 이벤트 처리
		
		private void Tbtn_NewProcess()
		{
			try
			{
				cmb_shipFact.SelectedValue	= ClassLib.ComVar.This_Factory;
				dt_shipYmdFr.Value			= System.DateTime.Now;
				dt_shipYmdTo.Value			= System.DateTime.Now;
				spd_main.ClearAll();
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

				string vShipFact	= cmb_shipFact.SelectedValue.ToString();
				string vShipYmdFr	= dt_shipYmdFr.Text.Replace("-", "");
				string vShipYmdTo	= dt_shipYmdTo.Text.Replace("-", "");
			
				DataTable vDt = SELECT_SBS_SHIP_CONT_LIST(vShipFact, vShipYmdFr, vShipYmdTo);
				spd_main.Display_Grid(vDt);

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
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

		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (MyOraDB.Save_Spread("PKG_SBS_SHIP_CONTAINER.SAVE_SBS_SHIP_CONT", spd_main))
					GridSetInitGrid();

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
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

		#region 컨트롤 이벤트 처리

		
		private void Btn_ChangeProcess()
		{
			 
			int vRow = _mainSheet.ActiveRowIndex;
			string _Ship_Ymd = _mainSheet.Cells[vRow, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_YMD].Text;
			string _Cont_No  = _mainSheet.Cells[vRow, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_NO].Text;

			COM.ComVar.Parameter_PopUp		= new string[]{ClassLib.ComFunction.Empty_Combo(cmb_shipFact, COM.ComVar.This_Factory), _Ship_Ymd, _Cont_No};

			Pop_BS_Shipping_Container_Change popup = new Pop_BS_Shipping_Container_Change();
			popup.ShowDialog();
			if (popup.DialogResult == DialogResult.OK)
			{
//				int vShipYmdCol  = (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_YMD;
//				int vShipFactCol = (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_FACT;
//
//				int vRow = spd_main.Add_Row(img_Action);
//				GridSetData(vRow);
//
//				_mainSheet.Cells[vRow, vShipYmdCol].Locked  = false;
//				_mainSheet.Cells[vRow, vShipFactCol].Locked = false;
//				spd_main.Set_CellPosition(vRow, 1);
			}
			popup.Dispose();
		}

		private void Btn_InsertProcess()
		{
			COM.ComVar.Parameter_PopUp		= new string[]{ClassLib.ComFunction.Empty_Combo(cmb_shipFact, COM.ComVar.This_Factory)};
			ClassLib.ComVar.Parameter_PopUp_Object = new object[]{spd_main, dt_shipYmdFr.Value};

			Pop_BS_Shipping_Container popup = new Pop_BS_Shipping_Container();
			popup.ShowDialog();
			if (popup.DialogResult == DialogResult.OK)
			{
				int vShipYmdCol  = (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_YMD;
				int vShipFactCol = (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_FACT;

				int vRow = spd_main.Add_Row(img_Action);
				GridSetData(vRow);

				_mainSheet.Cells[vRow, vShipYmdCol].Locked  = false;
				_mainSheet.Cells[vRow, vShipFactCol].Locked = false;
				spd_main.Set_CellPosition(vRow, 1);
			}
			popup.Dispose();
		}

		private void Btn_DeleteProcess()
		{
			spd_main.Delete_Row(img_Action);
		}

		private void Btn_CancelProcess()
		{
			spd_main.Recovery();
		}

		#endregion

		#region 그리드 이벤트 처리

		private void Grid_EditModeOnProcess(COM.SSP arg_grid)
		{
			int vRow = arg_grid.Sheets[0].ActiveRowIndex;
			int vCol = arg_grid.Sheets[0].ActiveColumnIndex;
			
			if (arg_grid.Sheets[0].Cells[vRow, vCol].Value == null || arg_grid.Sheets[0].Columns[vCol].CellType == null)
				return;
			
			arg_grid.Buffer_CellData = arg_grid.Sheets[0].Cells[vRow, vCol].Value.ToString();
			string vTemp = arg_grid.Sheets[0].Columns[vCol].CellType.ToString();
			if (vTemp == "CheckBoxCellType" )
			{
				arg_grid.Buffer_CellData = "000";
				arg_grid.Update_Row(img_Action);
			}
		}

		private void Grid_EditChangeProcess()
		{
			spd_main.Update_Row(img_Action);
//			int vRow = _mainSheet.ActiveRowIndex ;
//			int vCol = _mainSheet.ActiveColumnIndex ;
//
//			if (vCol == _contNoCol && _mainSheet.Cells[vRow, vCol].Text.IndexOf(" ") > 0)
//			{
//				DataTable vDt = this.SELECT_SBC_CONTAINER_LIST(_mainSheet.Cells[vRow, vCol].Text, "", "Y");
//
//				for(int i = 0 ; i < vDt.Rows.Count ; i++)
//					_contNo.Add(new MenuItem(vDt.Rows[i].ItemArray[0].ToString(), new EventHandler(Ctx_ClickProcess)));
//
//				ctx_contNo.Show(spd_main, new Point(200, 50));
//			}
		}

		private void Grid_CellDoubleClickProcess(int arg_row)
		{
			try
			{
				string vDiv = (spd_main.Sheets[0].Cells[arg_row, 0].Tag == null) ? "" : spd_main.Sheets[0].Cells[arg_row, 0].Tag.ToString();

				if (vDiv.Equals(ClassLib.ComVar.Insert))
				{
					COM.ComVar.Parameter_PopUp = new string[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxMaxCt + 1];
					this.GridGetData(arg_row);
				}
				else
				{
					COM.ComVar.Parameter_PopUp = new string[4];

					COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComVar.Update;
					COM.ComVar.Parameter_PopUp[1]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_YMD].Text.Replace("-", "");
					COM.ComVar.Parameter_PopUp[2]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_FACT].Text;
					COM.ComVar.Parameter_PopUp[3]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_SEQ].Text;
				}

				ClassLib.ComVar.Parameter_PopUp_Object = new object[]{spd_main};

				Pop_BS_Shipping_Container popup = new Pop_BS_Shipping_Container();
				popup.ShowDialog();
				if (popup.DialogResult == DialogResult.OK)
				{
					GridSetData(arg_row);
					if (!vDiv.Equals(ClassLib.ComVar.Insert))
						spd_main.Update_Row(arg_row, img_Action) ;
				} 
				popup.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
		}

//		private void Ctx_ClickProcess(object sender, System.EventArgs e)
//		{
//			int vRow = _mainSheet.ActiveRowIndex ;
//			int vCol = _mainSheet.ActiveColumnIndex ;
//
//			_mainSheet.Cells[vRow, vCol].Value = ((MenuItem)sender).Text;
//		}

		#endregion

		#region 정합성 체크

		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			// 공통 체크
			if (cmb_shipFact.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Factory", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_shipFact.Focus();
				return false;
			}

			// 부분별 체크 (Search, Save, Delete, Confirm..)
			switch (arg_type)
			{
				case ClassLib.ComVar.Validate_Search:

					break;
				case ClassLib.ComVar.Validate_Save:
					if (_mainSheet.RowCount <= 0)
					{
						ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					break;
				case ClassLib.ComVar.Validate_Delete:

					break;
				case ClassLib.ComVar.Validate_Confirm:

					break;
			}

			return true;
		}

		#endregion 

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// SELECT_SBS_SHIP_CONT_LIST
		/// </summary>
		/// <param name="arg_ship_fact">선적공장</param>
		/// <param name="arg_ship_ymd_fr">선적일(from)</param>
		/// <param name="arg_ship_ymd_to">선적일(to)</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBS_SHIP_CONT_LIST(string arg_ship_fact, string arg_ship_ymd_fr, string arg_ship_ymd_to)
		{
			DataSet vDs;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIP_CONTAINER.SELECT_SBS_SHIP_CONT_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_SHIP_FACT";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_YMD_FR";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_YMD_TO";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_ship_fact;
			MyOraDB.Parameter_Values[1] = arg_ship_ymd_fr;
			MyOraDB.Parameter_Values[2] = arg_ship_ymd_to;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vDs = MyOraDB.Exe_Select_Procedure();
			if(vDs == null) return null ;

			return vDs.Tables[MyOraDB.Process_Name];
		}
	
		/// <summary>
		/// PKG_SBC_CONTAINER : 
		/// </summary>
		/// <param name="arg_cont_no">컨테이너번호</param>
		/// <param name="arg_cont_unit">컨테이너유닛</param>
		/// <param name="arg_use_yn">사용여부</param>
		/// <returns>DataTable : 결과테이블</returns>
		public DataTable SELECT_SBC_CONTAINER_LIST(string arg_cont_no, string arg_cont_unit, string arg_use_yn)
		{
			DataSet vDs;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_CONTAINER.SELECT_SBC_CONTAINER_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_CONT_NO";
			MyOraDB.Parameter_Name[1] = "ARG_CONT_UNIT";
			MyOraDB.Parameter_Name[2] = "ARG_USE_YN";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_cont_no;
			MyOraDB.Parameter_Values[1] = arg_cont_unit;
			MyOraDB.Parameter_Values[2] = arg_use_yn;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vDs = MyOraDB.Exe_Select_Procedure();
			if(vDs == null) return null ;

			return vDs.Tables[MyOraDB.Process_Name];
		}

		#endregion																								

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BS_Shipping_Container") ;
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 3;
			string [] aHead =  new string[iCnt];	
			aHead[0]    = ClassLib.ComFunction.Empty_Combo(cmb_shipFact," ");
			aHead[1]    = ClassLib.ComFunction.Empty_String(dt_shipYmdFr.Text," ").Replace("-","");
			aHead[2]    = ClassLib.ComFunction.Empty_String(dt_shipYmdTo.Text ," ").Replace("-","");
			
			#endregion
	
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
	
			FlexBase.Report.Form_RdViewer   report = new FlexBase.Report.Form_RdViewer ( mrd_Filename, Para);
			report.Show();				
		}


	}
}
