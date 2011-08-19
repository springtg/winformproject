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
	public class Form_BC_Container : COM.PCHWinForm.Pop_Large
	{
		#region 디자이너에서 생성한 변수

		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Panel pnl_main;
		private System.Windows.Forms.Panel pnl_btn;
		private System.Windows.Forms.Label btn_insert;
		private System.Windows.Forms.Label lbl_contNo;
		private System.Windows.Forms.Label lbl_contUnit;
		private System.Windows.Forms.TextBox txt_contNo;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private C1.Win.C1List.C1Combo cmb_contUnit;
		private System.Windows.Forms.Label lbl_useYN;
		private C1.Win.C1List.C1Combo cmb_useYN;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.Label lbl_headInfo;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head3;
		public System.Windows.Forms.StatusBar stbar;
		private System.Windows.Forms.StatusBarPanel info_bar;
		private System.Windows.Forms.StatusBarPanel formname_bar;
		private System.ComponentModel.Container components = null;

		#endregion

		#region 사용자 정의 멤버변수
		private int _useCol = (int)ClassLib.TBSBC_CONTAINER.IxUSE_YN;
		private const int _btnInsert = 10, _btnDelete = 20, _btnCancel = 30;
		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		private COM.OraDB MyOraDB = new COM.OraDB();
		#endregion

		#region 생성자 / 소멸자

		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>

		public Form_BC_Container()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BC_Container));
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
            this.pnl_btn = new System.Windows.Forms.Panel();
            this.btn_insert = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.lbl_headInfo = new System.Windows.Forms.Label();
            this.lbl_contUnit = new System.Windows.Forms.Label();
            this.lbl_useYN = new System.Windows.Forms.Label();
            this.cmb_useYN = new C1.Win.C1List.C1Combo();
            this.cmb_contUnit = new C1.Win.C1List.C1Combo();
            this.txt_contNo = new System.Windows.Forms.TextBox();
            this.lbl_contNo = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_useYN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_contUnit)).BeginInit();
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
            this.c1Sizer1.GridDefinition = "19.3415637860082:False:True;69.5473251028807:False:False;6.17283950617284:False:T" +
                "rue;0.823045267489712:False:True;\t0.50314465408805:False:True;96.9811320754717:F" +
                "alse:False;0.50314465408805:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(795, 486);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_btn
            // 
            this.pnl_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_btn.BackColor = System.Drawing.Color.Transparent;
            this.pnl_btn.Controls.Add(this.btn_insert);
            this.pnl_btn.Controls.Add(this.btn_cancel);
            this.pnl_btn.Location = new System.Drawing.Point(12, 444);
            this.pnl_btn.Name = "pnl_btn";
            this.pnl_btn.Size = new System.Drawing.Size(771, 38);
            this.pnl_btn.TabIndex = 2;
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_insert.ImageIndex = 9;
            this.btn_insert.ImageList = this.image_List;
            this.btn_insert.Location = new System.Drawing.Point(610, 6);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(80, 23);
            this.btn_insert.TabIndex = 360;
            this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            this.btn_insert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseDown);
            this.btn_insert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseUp);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ImageIndex = 1;
            this.btn_cancel.ImageList = this.image_List;
            this.btn_cancel.Location = new System.Drawing.Point(690, 6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 23);
            this.btn_cancel.TabIndex = 359;
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseDown);
            this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseUp);
            // 
            // pnl_main
            // 
            this.pnl_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_main.Controls.Add(this.spd_main);
            this.pnl_main.Location = new System.Drawing.Point(12, 102);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(771, 338);
            this.pnl_main.TabIndex = 1;
            // 
            // spd_main
            // 
            this.spd_main.BackColor = System.Drawing.SystemColors.Window;
            this.spd_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spd_main.Location = new System.Drawing.Point(0, 0);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(771, 338);
            this.spd_main.TabIndex = 0;
            this.spd_main.EditModeOn += new System.EventHandler(this.spd_main_EditModeOn);
            this.spd_main.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellClick);
            this.spd_main.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_EditChange);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.Models = ((FarPoint.Win.Spread.SheetView.DocumentModels)(resources.GetObject("spd_main_Sheet1.Models")));
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // pnl_head
            // 
            this.pnl_head.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.lbl_headInfo);
            this.pnl_head.Controls.Add(this.lbl_contUnit);
            this.pnl_head.Controls.Add(this.lbl_useYN);
            this.pnl_head.Controls.Add(this.cmb_useYN);
            this.pnl_head.Controls.Add(this.cmb_contUnit);
            this.pnl_head.Controls.Add(this.txt_contNo);
            this.pnl_head.Controls.Add(this.lbl_contNo);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(771, 94);
            this.pnl_head.TabIndex = 0;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(753, 73);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 202;
            this.pic_head3.TabStop = false;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(668, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 50);
            this.pic_head7.TabIndex = 201;
            this.pic_head7.TabStop = false;
            // 
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(753, 0);
            this.pic_head2.Name = "pic_head2";
            this.pic_head2.Size = new System.Drawing.Size(16, 32);
            this.pic_head2.TabIndex = 200;
            this.pic_head2.TabStop = false;
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
            this.lbl_headInfo.TabIndex = 42;
            this.lbl_headInfo.Text = "      Container Info.";
            this.lbl_headInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_contUnit
            // 
            this.lbl_contUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_contUnit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contUnit.ImageIndex = 0;
            this.lbl_contUnit.ImageList = this.img_Label;
            this.lbl_contUnit.Location = new System.Drawing.Point(331, 37);
            this.lbl_contUnit.Name = "lbl_contUnit";
            this.lbl_contUnit.Size = new System.Drawing.Size(100, 21);
            this.lbl_contUnit.TabIndex = 199;
            this.lbl_contUnit.Text = "Unit";
            this.lbl_contUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_useYN
            // 
            this.lbl_useYN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_useYN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_useYN.ImageIndex = 0;
            this.lbl_useYN.ImageList = this.img_Label;
            this.lbl_useYN.Location = new System.Drawing.Point(8, 58);
            this.lbl_useYN.Name = "lbl_useYN";
            this.lbl_useYN.Size = new System.Drawing.Size(100, 21);
            this.lbl_useYN.TabIndex = 199;
            this.lbl_useYN.Text = "Use";
            this.lbl_useYN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_useYN
            // 
            this.cmb_useYN.AddItemCols = 0;
            this.cmb_useYN.AddItemSeparator = ';';
            this.cmb_useYN.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_useYN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_useYN.Caption = "";
            this.cmb_useYN.CaptionHeight = 17;
            this.cmb_useYN.CaptionStyle = style1;
            this.cmb_useYN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_useYN.ColumnCaptionHeight = 18;
            this.cmb_useYN.ColumnFooterHeight = 18;
            this.cmb_useYN.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_useYN.ContentHeight = 16;
            this.cmb_useYN.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_useYN.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_useYN.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_useYN.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_useYN.EditorHeight = 16;
            this.cmb_useYN.EvenRowStyle = style2;
            this.cmb_useYN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_useYN.FooterStyle = style3;
            this.cmb_useYN.GapHeight = 2;
            this.cmb_useYN.HeadingStyle = style4;
            this.cmb_useYN.HighLightRowStyle = style5;
            this.cmb_useYN.ItemHeight = 15;
            this.cmb_useYN.Location = new System.Drawing.Point(109, 59);
            this.cmb_useYN.MatchEntryTimeout = ((long)(2000));
            this.cmb_useYN.MaxDropDownItems = ((short)(5));
            this.cmb_useYN.MaxLength = 32767;
            this.cmb_useYN.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_useYN.Name = "cmb_useYN";
            this.cmb_useYN.OddRowStyle = style6;
            this.cmb_useYN.PartialRightColumn = false;
            this.cmb_useYN.PropBag = resources.GetString("cmb_useYN.PropBag");
            this.cmb_useYN.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_useYN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_useYN.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_useYN.SelectedStyle = style7;
            this.cmb_useYN.Size = new System.Drawing.Size(220, 20);
            this.cmb_useYN.Style = style8;
            this.cmb_useYN.TabIndex = 3;
            this.cmb_useYN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_useYN_KeyPress);
            this.cmb_useYN.SelectedValueChanged += new System.EventHandler(this.cmb_useYN_SelectedValueChanged);
            // 
            // cmb_contUnit
            // 
            this.cmb_contUnit.AddItemCols = 0;
            this.cmb_contUnit.AddItemSeparator = ';';
            this.cmb_contUnit.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_contUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_contUnit.Caption = "";
            this.cmb_contUnit.CaptionHeight = 17;
            this.cmb_contUnit.CaptionStyle = style9;
            this.cmb_contUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_contUnit.ColumnCaptionHeight = 18;
            this.cmb_contUnit.ColumnFooterHeight = 18;
            this.cmb_contUnit.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_contUnit.ContentHeight = 16;
            this.cmb_contUnit.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_contUnit.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_contUnit.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_contUnit.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_contUnit.EditorHeight = 16;
            this.cmb_contUnit.EvenRowStyle = style10;
            this.cmb_contUnit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_contUnit.FooterStyle = style11;
            this.cmb_contUnit.GapHeight = 2;
            this.cmb_contUnit.HeadingStyle = style12;
            this.cmb_contUnit.HighLightRowStyle = style13;
            this.cmb_contUnit.ItemHeight = 15;
            this.cmb_contUnit.Location = new System.Drawing.Point(432, 37);
            this.cmb_contUnit.MatchEntryTimeout = ((long)(2000));
            this.cmb_contUnit.MaxDropDownItems = ((short)(5));
            this.cmb_contUnit.MaxLength = 32767;
            this.cmb_contUnit.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_contUnit.Name = "cmb_contUnit";
            this.cmb_contUnit.OddRowStyle = style14;
            this.cmb_contUnit.PartialRightColumn = false;
            this.cmb_contUnit.PropBag = resources.GetString("cmb_contUnit.PropBag");
            this.cmb_contUnit.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_contUnit.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_contUnit.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_contUnit.SelectedStyle = style15;
            this.cmb_contUnit.Size = new System.Drawing.Size(220, 20);
            this.cmb_contUnit.Style = style16;
            this.cmb_contUnit.TabIndex = 2;
            this.cmb_contUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_contUnit_KeyPress);
            this.cmb_contUnit.SelectedValueChanged += new System.EventHandler(this.cmb_contUnit_SelectedValueChanged);
            // 
            // txt_contNo
            // 
            this.txt_contNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contNo.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_contNo.Location = new System.Drawing.Point(109, 37);
            this.txt_contNo.MaxLength = 11;
            this.txt_contNo.Name = "txt_contNo";
            this.txt_contNo.Size = new System.Drawing.Size(220, 21);
            this.txt_contNo.TabIndex = 1;
            this.txt_contNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contNo_KeyPress);
            // 
            // lbl_contNo
            // 
            this.lbl_contNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_contNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contNo.ImageIndex = 0;
            this.lbl_contNo.ImageList = this.img_Label;
            this.lbl_contNo.Location = new System.Drawing.Point(8, 37);
            this.lbl_contNo.Name = "lbl_contNo";
            this.lbl_contNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_contNo.TabIndex = 198;
            this.lbl_contNo.Text = "Container";
            this.lbl_contNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(178, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(643, 30);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 73);
            this.pic_head5.Name = "pic_head5";
            this.pic_head5.Size = new System.Drawing.Size(144, 18);
            this.pic_head5.TabIndex = 43;
            this.pic_head5.TabStop = false;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(117, 72);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(642, 17);
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
            this.pic_head6.Size = new System.Drawing.Size(144, 62);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 546);
            this.stbar.Name = "stbar";
            this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.info_bar,
            this.formname_bar});
            this.stbar.ShowPanels = true;
            this.stbar.Size = new System.Drawing.Size(794, 22);
            this.stbar.TabIndex = 29;
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
            // Form_BC_Container
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.stbar);
            this.Controls.Add(this.c1Sizer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_BC_Container";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_BC_Container_Closing);
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
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_useYN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_contUnit)).EndInit();
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
			this.Grid_EditModeOnProcess(spd_main);
		}

		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{			
			spd_main.Update_Row(img_Action);
		}

		private void spd_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			if (e.ColumnHeader && e.Column == (int)ClassLib.TBSBC_CONTAINER.IxREMARKS)
				e.Cancel = true;
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
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Save))
			{
				if (MessageBox.Show(this, "Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					this.Tbtn_SaveProcess();
				}
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

		private void Form_BC_Container_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			for (int vRow = _mainSheet.RowCount - 1 ; vRow >= 0 ; vRow--)
			{
				if (_mainSheet.Cells[vRow, 0].Tag != null)
				{
					if (MessageBox.Show(this, "Exist modify data. Do you want close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						e.Cancel = true;

					break;
				}
			}
		}

		private void btn_insert_Click(object sender, System.EventArgs e)
		{
			this.Btn_InsertProcess();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Btn_CancelProcess();
		}

		private void cmb_contUnit_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.spd_main.ClearAll();		
		}

		private void cmb_useYN_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.spd_main.ClearAll();
		}
	
		#region 입력이동

		private void txt_contNo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == 13)
			{
				ClassLib.ComFunction.ValidateCheck(txt_contNo.Text, ClassLib.ComVar.SpecialCharacter);
				cmb_contUnit.Focus();
			}
		}

		private void cmb_contUnit_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == 13)
				cmb_useYN.Focus();
		}

		private void cmb_useYN_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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

		// GridSet : Remove row
		private void GridSetRemoveRow(bool arg_use)
		{
			int vRowCount = _mainSheet.Rows.Count;
			_mainSheet.Rows[0, vRowCount - 1].ForeColor = Color.Black;

			for (int i = vRowCount - 1 ; i >= 0 ; i--)
			{
				if (arg_use != (bool)_mainSheet.Cells[i, _useCol].Value)
					_mainSheet.Rows[i].Remove();
				else
					_mainSheet.Cells[i, _useCol].Value = arg_use;
			}
		}

		// GridSet : Fore color setting
		private void GridSetForeColor()
		{
			int vRowCount = _mainSheet.Rows.Count;
			_mainSheet.Rows[0, vRowCount - 1].ForeColor = Color.Black;

			for (int i = 0 ; i < vRowCount ; i++)
				if (!(bool)_mainSheet.Cells[i, _useCol].Value)
					_mainSheet.Rows[i].ForeColor = Color.Red;
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
            this.Text = "Container Master";
            lbl_MainTitle.Text = "Container Master";
            ClassLib.ComFunction.SetLangDic(this);
			// ClassLib.ComFunction.Init_MenuRole(this,lbl_MainTitle,tbtn_Search ,tbtn_Save,tbtn_Print) ;

			// Grid Setting
			spd_main.Set_Spread_Comm("SBC_CONTAINER", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			DataTable vDt = null;
            
			// Cont Unit Setting
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBC10");
			COM.ComCtl.Set_ComboList(vDt, cmb_contUnit, 0, 1, true, 100, 120);
			cmb_contUnit.SelectedIndex = 0;
			vDt.Dispose();

			// Use Y/N Setting
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBC00");
			COM.ComCtl.Set_ComboList(vDt, cmb_useYN, 1, 2, true);
			cmb_useYN.SelectedIndex = 0;
			vDt.Dispose();
			
            // User define variable setting
			_mainSheet = spd_main.Sheets[0];

			// Disabled tbutton
			tbtn_Delete.Enabled  = false;
			tbtn_Conform.Enabled = false;
			tbtn_Print.Enabled   = false;
		}		

		private void Tbtn_NewProcess()
		{
			try
			{
				spd_main.ClearAll();
				txt_contNo.Text				= "";
				cmb_contUnit.SelectedIndex  = 0;
				cmb_useYN.SelectedIndex		= 0;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				string vContNo	 = ClassLib.ComFunction.ValidateCheck(txt_contNo.Text);
				string vContUnit = cmb_contUnit.GetItemText(cmb_contUnit.SelectedIndex, 1).Replace("ALL", "");
				string vUseYN	 = cmb_useYN.GetItemText(cmb_useYN.SelectedIndex, 0);

				DataTable vTemp = this.SELECT_SBC_CONTAINER_LIST(vContNo, vContUnit, vUseYN);
				spd_main.Display_Grid(vTemp);

				if (_mainSheet.Rows.Count > 0)
				{
					if (vUseYN.Equals(" "))
						GridSetForeColor();
					else
						_mainSheet.Rows[0, _mainSheet.Rows.Count - 1].ForeColor = Color.Black;

					ClassLib.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSearch, this);
				}
				else
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
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

		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				
				int vContNo = (int)ClassLib.TBSBC_CONTAINER.IxCONT_NO;

				if (ClassLib.ComFunction.CheckCellData(spd_main, vContNo))
					return;

				DataTable vDt = null;
				int vCode = Check_Duplicate_DB(spd_main, ref vDt);

				if (vCode == 1)
				{
					if (!Convert.IsDBNull(vDt.Rows[0].ItemArray[0]))
					{
						ClassLib.ComFunction.User_Message("Duplicate MCS Name : [" 
							+ vDt.Rows[0].ItemArray[0].ToString().Trim() + "]", 
							"Save", MessageBoxButtons.OK, MessageBoxIcon.Error);

						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
						return;
					}
				}
			
				MyOraDB.Save_Spread("PKG_SBC_CONTAINER.SAVE_SBC_CONTAINER", spd_main);

				if (_mainSheet.Rows.Count > 0)
				{
					string vUseYN = cmb_useYN.GetItemText(cmb_useYN.SelectedIndex, 1);
					if (vUseYN.Equals("ALL"))
						GridSetForeColor();
					else
						GridSetRemoveRow(vUseYN.Equals("Yes"));
					_mainSheet.ClearRange(0, 0, _mainSheet.Rows.Count, 1, false);

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
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

		private void Btn_InsertProcess()
		{
			if (!ClassLib.ComFunction.CheckCellData(spd_main, (int)ClassLib.TBSBC_CONTAINER.IxCONT_NO))
			{
				int vNewRow = spd_main.Add_Row(img_Action);
				_mainSheet.Cells[vNewRow, (int)ClassLib.TBSBC_CONTAINER.IxCONT_NO].Locked = false;
				_mainSheet.Cells[vNewRow, (int)ClassLib.TBSBC_CONTAINER.IxCONT_UNIT].Text = "40FT";
				_mainSheet.Cells[vNewRow, (int)ClassLib.TBSBC_CONTAINER.IxUSE_YN].Value = true;
				_mainSheet.Rows[vNewRow].ForeColor = Color.Blue;
				spd_main.Set_CellPosition(vNewRow, 1);
			}
		}

		private void Btn_CancelProcess()
		{
			spd_main.Recovery();
		}

		private void Grid_EditModeOnProcess(COM.SSP arg_grid)
		{
			int vRow = arg_grid.Sheets[0].ActiveRowIndex;
			int vCol = arg_grid.Sheets[0].ActiveColumnIndex;
			
			if (arg_grid.Sheets[0].Cells[vRow, vCol].Value == null || arg_grid.Sheets[0].Columns[vCol].CellType == null)
				return;
			
			arg_grid.Buffer_CellData = arg_grid.Sheets[0].Cells[vRow, vCol].Value.ToString();
			string vTemp = arg_grid.Sheets[0].Columns[vCol].CellType.ToString();
			if (vTemp == "CheckBoxCellType" || vTemp == "SSPComboBoxCellType")
			{
				arg_grid.Buffer_CellData = "000";
				arg_grid.Update_Row(img_Action);
			}
		}

		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			// 공통 체크

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
				case _btnInsert:

					break;
				case _btnDelete:

					break;
				case _btnCancel:

					break;
			}

			return true;
		}
		
		#endregion

		#region DB Connect
 		
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

		/// <summary>
		/// Check_Duplicate_DB : 
		/// </summary>
		/// <param name="arg_grid"></param>
		/// <returns></returns>
		private int Check_Duplicate_DB(COM.SSP arg_grid, ref DataTable arg_dt)
		{
			try
			{
				DataSet ds_ret; 
				string cont_no = null;

				MyOraDB.ReDim_Parameter(2);
				MyOraDB.Process_Name = "PKG_SBC_CONTAINER.DUPLICATE_CHECK"; 
				
				MyOraDB.Parameter_Name[0] = "ARG_CONT_NO"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 
 
				for(int row = 0; row < arg_grid.ActiveSheet.Rows.Count; row++)
				{
					if(arg_grid.ActiveSheet.Cells[row, 0].Tag == null
						|| arg_grid.ActiveSheet.Cells[row, 0].Tag.ToString().Trim() != "I") continue; 

					cont_no += arg_grid.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_CONTAINER.IxCONT_NO].Value.ToString().Trim() + "|";
				}

				if (cont_no != null)
				{
					cont_no = cont_no.Remove(cont_no.LastIndexOf("|"), 1);
					cont_no = cont_no.Trim();

					MyOraDB.Parameter_Values[0] = cont_no;
					MyOraDB.Parameter_Values[1] = ""; 
				 
					MyOraDB.Add_Select_Parameter(true); 
					ds_ret = MyOraDB.Exe_Select_Procedure();

					if(ds_ret == null) return 3;
					arg_dt = ds_ret.Tables[MyOraDB.Process_Name];
					return 1;
				}

				return 2;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Check_Duplicate_DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return 3;
			} 
		}

		#endregion																								

	}
}
