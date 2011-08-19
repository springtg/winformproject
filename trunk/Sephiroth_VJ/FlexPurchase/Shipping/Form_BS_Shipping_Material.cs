using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexPurchase.Shipping
{
	public class Form_BS_Shipping_Material : COM.PCHWinForm.Form_Top
	{

		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_main;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.TextBox txt_styleCd;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_styleCd;
		private C1.Win.C1List.C1Combo cmb_style;
		private C1.Win.C1List.C1Combo cmb_factory;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbl_gender;
		private System.Windows.Forms.TextBox txt_gender;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_presto;
		private C1.Win.C1List.C1Combo cmb_devision;
		private System.Windows.Forms.TextBox txt_presto_yn;
		private System.Windows.Forms.Label lbl_division;
		private System.Windows.Forms.ContextMenu ctx_main;
		private System.Windows.Forms.ImageList img_Type;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem mnu_allCheck;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnu_semi;
		private System.Windows.Forms.MenuItem mnu_comp;
		private System.Windows.Forms.MenuItem mnu_all;
		private System.Windows.Forms.Label btn_shipCheck;
		private System.Windows.Forms.Label btn_prodCheck;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MenuItem mnu_value;
		private System.Windows.Forms.MenuItem mnu_findData;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.CheckBox chk_CheckInOut;

		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private Pop_Finder finder = null;
		private int _fixedRow = 0;
		private Hashtable _Imgmap = new Hashtable();
		private Hashtable _ImgmapAction = new Hashtable();		
		private const string _TypeSG = "S", _TypeCmp = "C", _TypeMat = "M", _TypeJoint = "J";
		private int _IxImage_SG = 0, _IxImage_Cmp = 2, _IxImage_Mat = 3, _IxImage_Joint = 4;
        private string _DS_SHIPPING = "DS Shipping", _LLT = "LLT"; 
		private object[] _orgSData, _orgOData, _orgPData, _orgCData;

		// Shipping
		private int _shipYnCol			= (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxSHIP_YN;
		private int _purShipYnCol		= (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxPUR_SHIP_YN;

		// Production
		private int _prodYnCol			= (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxPROD_YN;
		private int _commonYnCol		= (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxCOMMON_YN;

		// Import
		private int _importYnCol		= (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxIMPORT_YN;

		// Local
		private int _localYnCol			= (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxLOCAL_YN;

		private int _prodSemiGoodCdCol	= (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxPROD_SEMI_GOOD_CD;
		private int _prodOpCdCol		= (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxPROD_OP_CD;
		private int _prodLossRateCol	= (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxPROD_LOSS_RATE;
		private const int _validate_shipCheck = 10, _validate_prodCheck = 20;
		public System.Windows.Forms.CheckBox chk_manual;



		private bool _Checkin_Cancel = false;

 

		#endregion

		#region 생성자 / 소멸자

		public Form_BS_Shipping_Material()
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BS_Shipping_Material));
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
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fgrid_main = new COM.FSP();
            this.ctx_main = new System.Windows.Forms.ContextMenu();
            this.mnu_findData = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnu_allCheck = new System.Windows.Forms.MenuItem();
            this.mnu_value = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnu_semi = new System.Windows.Forms.MenuItem();
            this.mnu_comp = new System.Windows.Forms.MenuItem();
            this.mnu_all = new System.Windows.Forms.MenuItem();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.chk_manual = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_CheckInOut = new System.Windows.Forms.CheckBox();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_shipCheck = new System.Windows.Forms.Label();
            this.btn_prodCheck = new System.Windows.Forms.Label();
            this.txt_presto_yn = new System.Windows.Forms.TextBox();
            this.lbl_presto = new System.Windows.Forms.Label();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_division = new System.Windows.Forms.Label();
            this.cmb_devision = new C1.Win.C1List.C1Combo();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.txt_styleCd = new System.Windows.Forms.TextBox();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_styleCd = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.cmb_style = new C1.Win.C1List.C1Combo();
            this.img_Type = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_head.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_devision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.pnl_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = "19.7916666666667:False:True;78.125:False:False;\t0.393700787401575:False:True;97.6" +
                "377952755905:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 29;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.pictureBox2);
            this.pnl_main.Controls.Add(this.label1);
            this.pnl_main.Controls.Add(this.pictureBox1);
            this.pnl_main.Controls.Add(this.fgrid_main);
            this.pnl_main.Location = new System.Drawing.Point(12, 122);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(992, 450);
            this.pnl_main.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(976, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 32);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 30);
            this.label1.TabIndex = 44;
            this.label1.Text = "      Material Info.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(208, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(952, 32);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ContextMenu = this.ctx_main;
            this.fgrid_main.Location = new System.Drawing.Point(0, 32);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Rows.DefaultSize = 19;
            this.fgrid_main.Size = new System.Drawing.Size(992, 415);
            this.fgrid_main.StyleInfo = resources.GetString("fgrid_main.StyleInfo");
            this.fgrid_main.TabIndex = 1;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
            this.fgrid_main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseMove);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            this.fgrid_main.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fgrid_main_KeyUp);
            // 
            // ctx_main
            // 
            this.ctx_main.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_findData,
            this.menuItem4,
            this.mnu_allCheck,
            this.mnu_value,
            this.menuItem2,
            this.menuItem1});
            // 
            // mnu_findData
            // 
            this.mnu_findData.Index = 0;
            this.mnu_findData.Text = "Find Data";
            this.mnu_findData.Click += new System.EventHandler(this.mnu_findData_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "-";
            // 
            // mnu_allCheck
            // 
            this.mnu_allCheck.Index = 2;
            this.mnu_allCheck.Text = "All Check";
            // 
            // mnu_value
            // 
            this.mnu_value.Index = 3;
            this.mnu_value.Text = "Value Change";
            this.mnu_value.Click += new System.EventHandler(this.mnu_value_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 4;
            this.menuItem2.Text = "-";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 5;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_semi,
            this.mnu_comp,
            this.mnu_all});
            this.menuItem1.Text = "Tree View Option";
            // 
            // mnu_semi
            // 
            this.mnu_semi.Index = 0;
            this.mnu_semi.Text = "Semi Good";
            this.mnu_semi.Click += new System.EventHandler(this.mnu_semi_Click);
            // 
            // mnu_comp
            // 
            this.mnu_comp.Index = 1;
            this.mnu_comp.Text = "Component";
            this.mnu_comp.Click += new System.EventHandler(this.mnu_comp_Click);
            // 
            // mnu_all
            // 
            this.mnu_all.Index = 2;
            this.mnu_all.Text = "All";
            this.mnu_all.Click += new System.EventHandler(this.mnu_all_Click);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.chk_manual);
            this.pnl_head.Controls.Add(this.groupBox2);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.groupBox1);
            this.pnl_head.Controls.Add(this.txt_presto_yn);
            this.pnl_head.Controls.Add(this.lbl_presto);
            this.pnl_head.Controls.Add(this.txt_gender);
            this.pnl_head.Controls.Add(this.lbl_gender);
            this.pnl_head.Controls.Add(this.lbl_division);
            this.pnl_head.Controls.Add(this.cmb_devision);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.txt_styleCd);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.lbl_styleCd);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.cmb_style);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(992, 114);
            this.pnl_head.TabIndex = 0;
            // 
            // chk_manual
            // 
            this.chk_manual.BackColor = System.Drawing.Color.Transparent;
            this.chk_manual.Location = new System.Drawing.Point(832, 88);
            this.chk_manual.Name = "chk_manual";
            this.chk_manual.Size = new System.Drawing.Size(152, 24);
            this.chk_manual.TabIndex = 364;
            this.chk_manual.Text = "start manual mode";
            this.chk_manual.UseVisualStyleBackColor = false;
            this.chk_manual.CheckedChanged += new System.EventHandler(this.chk_manual_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_CheckInOut);
            this.groupBox2.Location = new System.Drawing.Point(908, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(75, 51);
            this.groupBox2.TabIndex = 363;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check";
            // 
            // chk_CheckInOut
            // 
            this.chk_CheckInOut.BackColor = System.Drawing.Color.Transparent;
            this.chk_CheckInOut.Location = new System.Drawing.Point(6, 18);
            this.chk_CheckInOut.Name = "chk_CheckInOut";
            this.chk_CheckInOut.Size = new System.Drawing.Size(76, 24);
            this.chk_CheckInOut.TabIndex = 0;
            this.chk_CheckInOut.Text = "In/Out";
            this.chk_CheckInOut.UseVisualStyleBackColor = false;
            this.chk_CheckInOut.CheckedChanged += new System.EventHandler(this.chk_CheckInOut_CheckedChanged);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_shipCheck);
            this.groupBox1.Controls.Add(this.btn_prodCheck);
            this.groupBox1.Location = new System.Drawing.Point(728, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 51);
            this.groupBox1.TabIndex = 362;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Auto Check ";
            // 
            // btn_shipCheck
            // 
            this.btn_shipCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_shipCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_shipCheck.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_shipCheck.ImageIndex = 0;
            this.btn_shipCheck.ImageList = this.img_Button;
            this.btn_shipCheck.Location = new System.Drawing.Point(9, 20);
            this.btn_shipCheck.Name = "btn_shipCheck";
            this.btn_shipCheck.Size = new System.Drawing.Size(80, 23);
            this.btn_shipCheck.TabIndex = 361;
            this.btn_shipCheck.Text = "Shipping";
            this.btn_shipCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_shipCheck.Click += new System.EventHandler(this.btn_shipCheck_Click);
            // 
            // btn_prodCheck
            // 
            this.btn_prodCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_prodCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_prodCheck.Enabled = false;
            this.btn_prodCheck.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_prodCheck.ImageIndex = 0;
            this.btn_prodCheck.ImageList = this.img_Button;
            this.btn_prodCheck.Location = new System.Drawing.Point(90, 20);
            this.btn_prodCheck.Name = "btn_prodCheck";
            this.btn_prodCheck.Size = new System.Drawing.Size(80, 23);
            this.btn_prodCheck.TabIndex = 361;
            this.btn_prodCheck.Text = "Production";
            this.btn_prodCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_prodCheck.Click += new System.EventHandler(this.btn_prodCheck_Click);
            // 
            // txt_presto_yn
            // 
            this.txt_presto_yn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_presto_yn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_presto_yn.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_presto_yn.Location = new System.Drawing.Point(623, 62);
            this.txt_presto_yn.Name = "txt_presto_yn";
            this.txt_presto_yn.ReadOnly = true;
            this.txt_presto_yn.Size = new System.Drawing.Size(100, 21);
            this.txt_presto_yn.TabIndex = 5;
            // 
            // lbl_presto
            // 
            this.lbl_presto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_presto.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_presto.ImageIndex = 0;
            this.lbl_presto.ImageList = this.img_Label;
            this.lbl_presto.Location = new System.Drawing.Point(522, 62);
            this.lbl_presto.Name = "lbl_presto";
            this.lbl_presto.Size = new System.Drawing.Size(100, 21);
            this.lbl_presto.TabIndex = 50;
            this.lbl_presto.Text = "Presto";
            this.lbl_presto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_gender
            // 
            this.txt_gender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gender.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_gender.Location = new System.Drawing.Point(421, 62);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.ReadOnly = true;
            this.txt_gender.Size = new System.Drawing.Size(100, 21);
            this.txt_gender.TabIndex = 5;
            // 
            // lbl_gender
            // 
            this.lbl_gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.ImageIndex = 0;
            this.lbl_gender.ImageList = this.img_Label;
            this.lbl_gender.Location = new System.Drawing.Point(320, 62);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(100, 21);
            this.lbl_gender.TabIndex = 50;
            this.lbl_gender.Text = "Gender";
            this.lbl_gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_division
            // 
            this.lbl_division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_division.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_division.ImageIndex = 0;
            this.lbl_division.ImageList = this.img_Label;
            this.lbl_division.Location = new System.Drawing.Point(8, 62);
            this.lbl_division.Name = "lbl_division";
            this.lbl_division.Size = new System.Drawing.Size(100, 21);
            this.lbl_division.TabIndex = 50;
            this.lbl_division.Text = "Division";
            this.lbl_division.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_devision
            // 
            this.cmb_devision.AddItemSeparator = ';';
            this.cmb_devision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_devision.Caption = "";
            this.cmb_devision.CaptionHeight = 17;
            this.cmb_devision.CaptionStyle = style1;
            this.cmb_devision.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_devision.ColumnCaptionHeight = 18;
            this.cmb_devision.ColumnFooterHeight = 18;
            this.cmb_devision.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_devision.ContentHeight = 16;
            this.cmb_devision.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_devision.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_devision.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_devision.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_devision.EditorHeight = 16;
            this.cmb_devision.EvenRowStyle = style2;
            this.cmb_devision.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_devision.FooterStyle = style3;
            this.cmb_devision.HeadingStyle = style4;
            this.cmb_devision.HighLightRowStyle = style5;
            this.cmb_devision.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_devision.Images"))));
            this.cmb_devision.ItemHeight = 15;
            this.cmb_devision.Location = new System.Drawing.Point(109, 62);
            this.cmb_devision.MatchEntryTimeout = ((long)(2000));
            this.cmb_devision.MaxDropDownItems = ((short)(5));
            this.cmb_devision.MaxLength = 32767;
            this.cmb_devision.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_devision.Name = "cmb_devision";
            this.cmb_devision.OddRowStyle = style6;
            this.cmb_devision.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_devision.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_devision.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_devision.SelectedStyle = style7;
            this.cmb_devision.Size = new System.Drawing.Size(200, 20);
            this.cmb_devision.Style = style8;
            this.cmb_devision.TabIndex = 4;
            this.cmb_devision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_dev_KeyPress);
            this.cmb_devision.SelectedValueChanged += new System.EventHandler(this.cmb_devision_SelectedValueChanged);
            this.cmb_devision.PropBag = resources.GetString("cmb_devision.PropBag");
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
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style11;
            this.cmb_factory.HeadingStyle = style12;
            this.cmb_factory.HighLightRowStyle = style13;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style14;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style15;
            this.cmb_factory.Size = new System.Drawing.Size(200, 20);
            this.cmb_factory.Style = style16;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_factory_KeyPress);
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            // 
            // txt_styleCd
            // 
            this.txt_styleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCd.Location = new System.Drawing.Point(421, 40);
            this.txt_styleCd.MaxLength = 10;
            this.txt_styleCd.Name = "txt_styleCd";
            this.txt_styleCd.Size = new System.Drawing.Size(100, 21);
            this.txt_styleCd.TabIndex = 2;
            this.txt_styleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_styleCd_KeyUp);
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
            // lbl_styleCd
            // 
            this.lbl_styleCd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_styleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_styleCd.ImageIndex = 1;
            this.lbl_styleCd.ImageList = this.img_Label;
            this.lbl_styleCd.Location = new System.Drawing.Point(320, 40);
            this.lbl_styleCd.Name = "lbl_styleCd";
            this.lbl_styleCd.Size = new System.Drawing.Size(100, 21);
            this.lbl_styleCd.TabIndex = 50;
            this.lbl_styleCd.Text = "Style";
            this.lbl_styleCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label2.Text = "      Shipping Material Info";
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
            // cmb_style
            // 
            this.cmb_style.AddItemSeparator = ';';
            this.cmb_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_style.Caption = "";
            this.cmb_style.CaptionHeight = 17;
            this.cmb_style.CaptionStyle = style17;
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
            this.cmb_style.EvenRowStyle = style18;
            this.cmb_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style.FooterStyle = style19;
            this.cmb_style.HeadingStyle = style20;
            this.cmb_style.HighLightRowStyle = style21;
            this.cmb_style.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_style.Images"))));
            this.cmb_style.ItemHeight = 15;
            this.cmb_style.Location = new System.Drawing.Point(522, 40);
            this.cmb_style.MatchEntryTimeout = ((long)(2000));
            this.cmb_style.MaxDropDownItems = ((short)(5));
            this.cmb_style.MaxLength = 32767;
            this.cmb_style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_style.Name = "cmb_style";
            this.cmb_style.OddRowStyle = style22;
            this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_style.SelectedStyle = style23;
            this.cmb_style.Size = new System.Drawing.Size(201, 20);
            this.cmb_style.Style = style24;
            this.cmb_style.TabIndex = 3;
            this.cmb_style.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_style_KeyPress);
            this.cmb_style.SelectedValueChanged += new System.EventHandler(this.cmb_style_SelectedValueChanged);
            this.cmb_style.PropBag = resources.GetString("cmb_style.PropBag");
            // 
            // img_Type
            // 
            this.img_Type.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Type.ImageStream")));
            this.img_Type.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Type.Images.SetKeyName(0, "");
            this.img_Type.Images.SetKeyName(1, "");
            this.img_Type.Images.SetKeyName(2, "");
            this.img_Type.Images.SetKeyName(3, "");
            this.img_Type.Images.SetKeyName(4, "");
            this.img_Type.Images.SetKeyName(5, "");
            // 
            // Form_BS_Shipping_Material
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BS_Shipping_Material";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_BS_Shipping_Material_Closing);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_devision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess(e);
		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
            //if (cmb_devision.SelectedValue.ToString().Equals("Shipping") && chk_CheckInOut.Checked)
            //    fgrid_main.Select(e.Row, e.Col);

            this.Grid_BeforeEditProcess();
		}

        private void fgrid_main_MouseMove(object sender, MouseEventArgs e)
        {
            if (fgrid_main.MouseCol == _shipYnCol)
                fgrid_main.Select(fgrid_main.MouseRow, fgrid_main.MouseCol);
        }

		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (cmb_devision.SelectedValue.ToString().Equals(ClassLib.ComVar.Production))
				this.Grid_MouseUpProcess(e);
		}

		private void cmb_devision_SelectedValueChanged(object sender, System.EventArgs e)
		{
			fgrid_main.ClearAll();

			if (cmb_devision.SelectedValue.ToString().Equals(ClassLib.ComVar.Shipping) && chk_CheckInOut.Checked)
				btn_shipCheck.Enabled = true;
			else
				btn_shipCheck.Enabled = false;


			if (cmb_devision.SelectedValue.ToString().Equals(ClassLib.ComVar.Production) && chk_CheckInOut.Checked)
				btn_prodCheck.Enabled = true;
			else
				btn_prodCheck.Enabled = false;


		}

		private void fgrid_main_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
			{
				finder = new Pop_Finder(fgrid_main, 10, fgrid_main.Cols.Count - 1);
				finder.Show();
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
			this.Tbtn_SearchProcess();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            if (MessageBox.Show(this, "Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Save))
                {
                    this.Tbtn_SaveProcess();
                }
            }
		}			
		
		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Confirm))
            {
                SetPrintYield();
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

		private void Form_BS_Shipping_Material_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
			{
				string vTemp = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0).Clip.Replace("\r", "");

				if (vTemp.Length > 0)
					if (MessageBox.Show(this, "Exist modify data. Do you want close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						e.Cancel = true;
			}

			if(chk_CheckInOut.Checked) 
			{
				ClassLib.ComFunction.User_Message("Need Check Out.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
				e.Cancel = true;
			}
		}

		private void cmb_style_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_StyleSelectedValueChangedProcess();
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_FactorySelectedValueChangedProcess();
		}

		private void cmb_dev_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Tbtn_SearchProcess();
		}

		private void txt_styleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				this.Txt_StyleCdKeyUpProcess();
		}

		private void mnu_semi_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(1);
		}

		private void mnu_comp_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(2);
		}

		private void mnu_all_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(10);
		}

		private void btn_shipCheck_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_validate_shipCheck))
			{
				AutoShippingCheck();
			}
		}

		private void btn_prodCheck_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_validate_shipCheck))
			{
				AutoProdShippingCheck();
			}
		}

		private void mnu_findData_Click(object sender, System.EventArgs e)
		{
			if (fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
			{
				finder = new Pop_Finder(fgrid_main, 10, fgrid_main.Cols.Count - 1);
				finder.Show();
			}	
		}


		#region 입력이동

		private void cmb_factory_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == 13)
				txt_styleCd.Focus();
		}

		private void cmb_style_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == 13)
				cmb_devision.Focus();
		}

		private void cmb_dev_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == 13)
				txt_gender.Focus();
		}

		private void txt_gender_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
            ClassLib.ComFunction.KeyEnter_Tab(e);
		}		

		private void cmb_presto_yn_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyValue == 13)
				Tbtn_SearchProcess();
		}

		#endregion

		#region 버튼효과

		#endregion

		#endregion

		#region 공통 메서드

		// 그리드에 데이터 입력
		private void GridInsertData(int arg_row, object[] arg_items)
		{
			int vRow = arg_row + _fixedRow;
			
			for (int vCol = 1 ; vCol < fgrid_main.Cols.Count ; vCol++)
			{
				if (fgrid_main.Rows[vRow].Node.Level <= 2 && ( vCol >= _shipYnCol && vCol <= _localYnCol ))
					continue;

				fgrid_main[vRow, vCol] = arg_items[vCol - 1];
			}

			Display_Type_Image(vRow);
		}

        // 선택 모드에 따라 보여질 컬럼 설정
		private void GridSetWithDevision(string arg_dev)
		{
			switch (arg_dev)
			{
				case ClassLib.ComVar.Shipping:
					fgrid_main.Cols[_prodYnCol].Visible				= false;
					fgrid_main.Cols[_commonYnCol].Visible			= false;
					fgrid_main.Cols[_prodSemiGoodCdCol].Visible		= false;
					fgrid_main.Cols[_prodOpCdCol].Visible			= false;
					fgrid_main.Cols[_prodLossRateCol].Visible		= false;
					fgrid_main.Cols[_shipYnCol].Visible				= true;
					fgrid_main.Cols[_purShipYnCol].Visible			= true;
					fgrid_main.Cols[_importYnCol].Visible			= false;
					fgrid_main.Cols[_localYnCol].Visible			= false;
					break;
				case ClassLib.ComVar.Production:
					fgrid_main.Cols[_prodYnCol].Visible				= true;

					if(ClassLib.ComVar.This_Factory == "VJ")
					{
						fgrid_main.Cols[_commonYnCol].Visible = false;
					}
					else
					{
						fgrid_main.Cols[_commonYnCol].Visible = true;
					}

					fgrid_main.Cols[_prodSemiGoodCdCol].Visible		= true;
					fgrid_main.Cols[_prodOpCdCol].Visible			= true;
					fgrid_main.Cols[_prodLossRateCol].Visible		= true;
					fgrid_main.Cols[_shipYnCol].Visible				= false;
					fgrid_main.Cols[_purShipYnCol].Visible			= false;
					fgrid_main.Cols[_importYnCol].Visible			= false;
					fgrid_main.Cols[_localYnCol].Visible			= false;
					break;
				case ClassLib.ComVar.Import:
					fgrid_main.Cols[_prodYnCol].Visible				= false;
					fgrid_main.Cols[_commonYnCol].Visible			= false;
					fgrid_main.Cols[_prodSemiGoodCdCol].Visible		= false;
					fgrid_main.Cols[_prodOpCdCol].Visible			= false;
					fgrid_main.Cols[_prodLossRateCol].Visible		= false;
					fgrid_main.Cols[_shipYnCol].Visible				= false;
					fgrid_main.Cols[_purShipYnCol].Visible			= false;
					fgrid_main.Cols[_importYnCol].Visible			= true;
					fgrid_main.Cols[_localYnCol].Visible			= false;
					break;
				case ClassLib.ComVar.Local:
					fgrid_main.Cols[_prodYnCol].Visible				= false;
					fgrid_main.Cols[_commonYnCol].Visible			= false;
					fgrid_main.Cols[_prodSemiGoodCdCol].Visible		= false;
					fgrid_main.Cols[_prodOpCdCol].Visible			= false;
					fgrid_main.Cols[_prodLossRateCol].Visible		= false;
					fgrid_main.Cols[_shipYnCol].Visible				= false;
					fgrid_main.Cols[_purShipYnCol].Visible			= false;
					fgrid_main.Cols[_importYnCol].Visible			= false;
					fgrid_main.Cols[_localYnCol].Visible			= true;
					break;
			}
		}

        // 팝업으로부터 받은 데이터를 그리드에 입력
		private void GridSetData()
		{
			int vLevelCol = (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxLEVEL1;
			int vSemiCol  = (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxPROD_SEMI_GOOD_CD;
			int vProdCol  = (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxPROD_OP_CD;
			int vLossCol  = (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxPROD_LOSS_RATE;

			int vStartRow = fgrid_main.Selection.r1;
			int vEndRow   = fgrid_main.Selection.r2;

			for (int i = vStartRow ; i <= vEndRow ; i++)
			{
				if (fgrid_main[i, vLevelCol].Equals("1") || fgrid_main[i, vLevelCol].Equals("2"))				
					continue;

				fgrid_main[i, vSemiCol] = COM.ComVar.Parameter_PopUp[0];
				fgrid_main[i, vProdCol] = COM.ComVar.Parameter_PopUp[1];
				fgrid_main[i, vLossCol] = COM.ComVar.Parameter_PopUp[2];
				fgrid_main.Update_Row(i);
			}
		}

        // 최하위 레벨 이동
		private int GridGetLastChildIndex(int arg_row)
		{
			int vEndRow = arg_row;

			Node vEndNode = fgrid_main.Rows[arg_row].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.FirstChild);

			if (vEndNode != null)
				while (true)
				{
					vEndNode = fgrid_main.Rows[vEndRow].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.LastChild);
					if (vEndNode == null)
						break;

					vEndRow = vEndNode.Row.Index;
				}

			return vEndRow;
		}

        // 지정된 레벨까지 이동
		private int GridGetFirstParentIndex(int arg_row, int arg_level, bool arg_clear, int arg_clearRow1, int arg_clearRow2)
		{
			int vStartRow = arg_row;

			Node vStartNode = fgrid_main.Rows[arg_row].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent);

			if (vStartNode != null)
				while (true)
				{
					vStartNode = fgrid_main.Rows[vStartRow].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent);
					if (vStartNode == null || fgrid_main.Rows[vStartRow].Node.Level <= arg_level)
						break;					
						
					vStartRow = vStartNode.Row.Index;
					fgrid_main[vStartNode.Row.Index, arg_clearRow1]	= !arg_clear;
					fgrid_main[vStartNode.Row.Index, arg_clearRow2] = !arg_clear;
					fgrid_main.Update_Row(vStartRow);
				}

			return vStartRow;
		}

        // 선택 영역 유효성 체크		
		private bool GridSelectionBlockValidateCheck()
		{
			int vSeqCol   = (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxTEMPLATE_SEQ;
			int vStartRow = fgrid_main.Selection.r1;
			int vEndRow	  = fgrid_main.Selection.r2;

			for (int i = vStartRow ; i < vEndRow ; i++)
				if (!fgrid_main[i, vSeqCol].Equals(fgrid_main[i + 1, vSeqCol]))
					return false;
			
			return true;
		}


		// 선택 영역 보정 - block 단위
		private void GridSelectionBlockCorrection()
		{
			int vStartRow = fgrid_main.Selection.r1;
			int vEndRow = GridGetLastChildIndex(fgrid_main.Selection.r2);

			CellRange vRange = new CellRange();
			vRange.c1 = vRange.c2 = 1;
			vRange.r1 = vStartRow;
			vRange.r2 = vEndRow;

			fgrid_main.Select(vRange);
		}


//        // 선택 영역 보정 - row 단위
//		private void GridSelectionBlockCorrection()
//		{
//			int vStartRow = fgrid_main.Selection.r1;
//			int vEndRow = GridGetLastChildIndex(fgrid_main.Selection.r2);
//
//			CellRange vRange = new CellRange();
//			vRange.c1 = vRange.c2 = 1;
//			vRange.r1 = vStartRow;
//			vRange.r2 = vEndRow;
//
//			fgrid_main.Select(vRange);
//		}

        // 체크박트 컨트롤
		private void GridCheckBoxCorrection()
		{
            string vDev = cmb_devision.SelectedValue.ToString();
            
			switch (vDev)
			{
				case ClassLib.ComVar.Shipping:
					ShippingCheckBoxControl();
					break;
				case ClassLib.ComVar.Production:
					MaterialCheckBoxControl();
					break;
				case ClassLib.ComVar.Import:
					EtcCheckBoxControl(_importYnCol);
					break;
				case ClassLib.ComVar.Local:
					EtcCheckBoxControl(_localYnCol);
					break;
			}
		}

        // 체크박스 컨트롤 - shipping ( system support mode )
		private void ShippingCheckBoxControl()
		{
			int vRow = fgrid_main.Selection.r1;
			int vCol = fgrid_main.Selection.c1;
			int vSCol = (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxSHIP_YN;
			int vPCol = (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxPUR_SHIP_YN;
			int vOCol	  = (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxPROD_YN;

			if (vCol == _shipYnCol)
			{
				int vStartRow = GridGetFirstParentIndex(vRow, 3, true, vSCol, vPCol);

				Node vNode = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.FirstChild);
				if (vNode != null)
				{
					int vEndRow = GridGetLastChildIndex(vRow);

					fgrid_main[vRow, vPCol] = fgrid_main[vRow, vSCol];
					fgrid_main[vRow, vOCol] = fgrid_main[vRow, vSCol];
					fgrid_main[vRow, 0]	 = ClassLib.ComVar.Update;
					for (int i = vRow + 1 ; i <= vEndRow ; i++)
					{
						fgrid_main[i, vSCol] = false;
						fgrid_main[i, vPCol] = fgrid_main[vRow, vPCol];
						fgrid_main[i, vOCol] = false;
						fgrid_main[i, 0]	 = ClassLib.ComVar.Update;
					}
				}
				else
				{
					int vEnd = vRow;

					if (vRow != vStartRow)
					{
						Node vEndNode = fgrid_main.Rows[vStartRow].Node.GetNode(NodeTypeEnum.LastChild);
						vEnd = ( vEndNode == null) ? fgrid_main.Rows.Count - 1 : GridGetLastChildIndex(vStartRow);
					}

					for (int i = vStartRow ; i <= vEnd ; i++)
					{
						fgrid_main[i, vPCol] = fgrid_main[i, vSCol];
						fgrid_main[i, vOCol] = fgrid_main[i, vSCol];
						fgrid_main[i, 0] = ClassLib.ComVar.Update;
					}
				}
			}
			else if (chk_manual.Checked && vCol == _purShipYnCol)
			{
				Node vCurNode = fgrid_main.Rows[vRow].Node;
				Node vTempNode = vCurNode;
				bool vChk = false;
				do 
				{
					if ((bool)vTempNode.Row[_shipYnCol])
					{
						vChk = true;
						break;
					}
				} while ((vTempNode = vTempNode.GetNode(NodeTypeEnum.Parent)) != null && vTempNode.Level > 2);

				if (vChk)
				{
					if (vCurNode.Level == vTempNode.Level &&
						_TypeJoint.Equals(vCurNode.Row[(int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxTYPE_DIVISION].ToString()))
					{
						fgrid_main[vRow, vPCol] = true;
					}
					else if (vCurNode.Level > vTempNode.Level)
					{
						fgrid_main[vRow, vSCol] = _orgSData[vRow];
						fgrid_main[vRow, vOCol] = _orgOData[vRow];
					}
					else
					{
						fgrid_main[vRow, vSCol] = fgrid_main[vRow, vPCol];
						fgrid_main[vRow, vOCol] = fgrid_main[vRow, vPCol];
					}
				}
				else
				{
					if (vCurNode.GetNode(NodeTypeEnum.Parent).Level == 2 && 
						_TypeMat.Equals(vCurNode.Row[(int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxTYPE_DIVISION].ToString()))
					{
						fgrid_main[vRow, vSCol] = fgrid_main[vRow, vPCol];
						fgrid_main[vRow, vOCol] = fgrid_main[vRow, vPCol];
					}
					else
					{
						fgrid_main[vRow, vPCol] = false;
					}
				}

				fgrid_main[vRow, 0] = ClassLib.ComVar.Update;
			}
		}

        // 체크박트 컨트롤 - delivery
		private void MaterialCheckBoxControl()
		{
			int vRow	  = fgrid_main.Row;
			int vCol	  = fgrid_main.Col;
			int vOCol	  = (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxPROD_YN;
			int vCCol	  = (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxCOMMON_YN;

			if (vCol == vCCol)
			{
				if (!(bool)fgrid_main[vRow, vOCol])
				{
					fgrid_main[vRow, vCCol] = false;
				}
			}
			else
			{
				int vStartRow = GridGetFirstParentIndex(vRow, 3, true, vOCol, vCCol);

				Node vNode = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.FirstChild);
				if (vNode != null)
				{
					int vEndRow = GridGetLastChildIndex(vRow);

					for (int i = vRow + 1 ; i <= vEndRow ; i++)
					{
						fgrid_main[i, vOCol] = false;
						fgrid_main[i, vCCol] = false;
						fgrid_main.Update_Row(i);
					}
				}

				if(cmb_factory.SelectedValue.ToString() == "VJ")
				{
					fgrid_main[vRow, vCCol] = false;
				}
				else
				{
					fgrid_main[vRow, vCCol] = fgrid_main[vRow, vOCol];
				}

			}

			//fgrid_main.Update_Row(vRow);
			int sel_r1 = fgrid_main.Selection.r1;
			int sel_r2 = fgrid_main.Selection.r2;
			
			int start_row, end_row;
 
			start_row = (sel_r1 < sel_r2) ? sel_r1 : sel_r2;
			end_row = (sel_r1 < sel_r2) ? sel_r2 : sel_r1;

			for(int i = start_row; i <= end_row; i++)
			{
				if (fgrid_main[i, 0] == null)
				{
					fgrid_main[i, 0] = "U";
				}
				if (fgrid_main[i, 0].ToString() != "I")
				{
					fgrid_main[i, 0] = "U";
				}
			} 



		}

		// 체크박스 컨트롤 - Import, Local
		private void EtcCheckBoxControl(int arg_col)
		{
			int vRow = fgrid_main.Row;

			int vStartRow = GridGetFirstParentIndex(vRow, 3, true, arg_col, arg_col);

			Node vNode = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.FirstChild);
			if (vNode != null)
			{
				int vEndRow = GridGetLastChildIndex(vRow);

				for (int i = vRow + 1 ; i <= vEndRow ; i++)
				{
					fgrid_main[i, arg_col] = false;
					fgrid_main[i, 0]	= ClassLib.ComVar.Update;
				}
			}

			fgrid_main[vRow, 0]	= ClassLib.ComVar.Update;
		}


		/// <summary>
		/// Display_Type_Image : 이미지 표시
		/// </summary>
		/// <param name="arg_row"></param>
		private void Display_Type_Image(int arg_row) 
		{
			fgrid_main.GetCellRange(arg_row, 1, arg_row, fgrid_main.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;

			if(_Imgmap.ContainsKey(fgrid_main[arg_row, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxITEM].ToString() ) ) 
				return;

			switch(fgrid_main[arg_row, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxTYPE_DIVISION].ToString() )
			{ 		
				case _TypeSG:  
					fgrid_main.Rows[arg_row].AllowEditing = false;
					fgrid_main.GetCellRange(arg_row, 1, arg_row, fgrid_main.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
					_Imgmap.Add(fgrid_main[arg_row, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxITEM].ToString(), img_Type.Images[_IxImage_SG]); 
					break;

				case _TypeCmp:  
					fgrid_main.Rows[arg_row].AllowEditing = false;
					fgrid_main.GetCellRange(arg_row, 1, arg_row, fgrid_main.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
					_Imgmap.Add(fgrid_main[arg_row, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxITEM].ToString(), img_Type.Images[_IxImage_Cmp]); 
					break;

				case _TypeMat:
					_Imgmap.Add(fgrid_main[arg_row, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxITEM].ToString(), img_Type.Images[_IxImage_Mat]);
					break;
				
				case _TypeJoint:
					_Imgmap.Add(fgrid_main[arg_row, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxITEM].ToString(), img_Type.Images[_IxImage_Joint]);
					break;
			} // end switch
		}

		#endregion

		#region 이벤트 처리 메서드

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form init
            // ClassLib.ComFunction.Init_Form_Control(this);
            this.Text = "Shipping Material";
            lbl_MainTitle.Text = "Shipping Material";
            ClassLib.ComFunction.SetLangDic(this);
			// ClassLib.ComFunction.Init_MenuRole(this,lbl_MainTitle,new C1.Win.C1Command.C1Command[]{tbtn_Search, tbtn_Save, tbtn_Delete, tbtn_Print, tbtn_New, tbtn_Confirm}) ;
			
			// Grid setting
			fgrid_main.Set_Grid("SBC_YIELD_INFO", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action, true); 

			DataTable vDt = null;

			// Factory combobox add items
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
			vDt.Dispose();

			// obs type set
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBS11");
			COM.ComCtl.Set_ComboList(vDt, cmb_devision, 1, 2, false, false);
			cmb_devision.SelectedIndex = 0;
			vDt.Dispose();

			if (cmb_factory.SelectedValue.ToString().Equals("DS"))
				cmb_devision.SelectedValue = ClassLib.ComVar.Shipping;
			else
				cmb_devision.SelectedValue = ClassLib.ComVar.Production;

			// User define variable setting
			_fixedRow = fgrid_main.Rows.Fixed;

			// Disabled tbutton
			tbtn_Delete.Enabled  = false;
			tbtn_Confirm.Enabled = false;
			Control_Enable(false);
		}

		private void Tbtn_NewProcess()
		{
			try
			{
				txt_styleCd.Text		= "";
				txt_gender.Text			= "";
				fgrid_main.ClearAll();
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

				string vFactory = ClassLib.ComFunction.Empty_Combo(cmb_factory, COM.ComVar.This_Factory);
				string vStyleCd = ClassLib.ComFunction.Empty_Combo(cmb_style, "");
					   vStyleCd = vStyleCd.Replace("-", "");
				string vGender  = txt_gender.Text;
				string vDev		= ClassLib.ComFunction.Empty_Combo(cmb_devision, "");
				if (!vGender.Equals(""))
				{
					DataTable vDt = this.SELECT_SBC_YIELD_INFO_LIST(vFactory, vStyleCd, vGender, vDev);
					_Imgmap.Clear();

					if (vDt.Rows.Count > 0)
					{
						fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
						fgrid_main.Tree.Column = (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxITEM;
						fgrid_main.Cols[(int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxITEM].ImageAndText = true; 
						fgrid_main.Cols[(int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxITEM].ImageMap = _Imgmap; 
						
						for(int i = 0, idx = 0 ; i < vDt.Rows.Count ; i++)
						{
							int vRow = idx + _fixedRow;
						
							if (i != 0)
							{
								string vKey = fgrid_main[vRow - 1, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxKEY1].ToString();
								if (vKey.Equals(vDt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxKEY1 - 1].ToString()))
									continue;
							}

							fgrid_main.Rows.InsertNode(idx + _fixedRow , Convert.ToInt32(vDt.Rows[i].ItemArray[0]));
							GridInsertData(idx, vDt.Rows[i].ItemArray);

							idx++;
						}
					}
					else
						fgrid_main.ClearAll();

					GridSetWithDevision(vDev);

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
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

				if (MyOraDB.Save_FlexGird("PKG_SBS_SHIPPING_MATERIAL.SAVE_SBC_YIELD_INFO", fgrid_main))
				{
					fgrid_main.Refresh_Division();

					ClassLib.ComFunction.User_Message("Save Complete", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
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

		private void Txt_StyleCdKeyUpProcess()
		{
			DataTable vDt = null;

			try
			{
				vDt = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_styleCd, " ").Replace("-", ""));
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

		private void Cmb_StyleSelectedValueChangedProcess()
		{
			try
			{
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				txt_styleCd.Text	= cmb_style.SelectedValue.ToString();
				txt_gender.Text		= cmb_style.Columns[2].Text;
				txt_presto_yn.Text  = cmb_style.Columns[3].Text; 
				Tbtn_SearchProcess();
			}
			catch //(Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs_Style", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Cmb_FactorySelectedValueChangedProcess()
		{

			if (fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
			{
				fgrid_main.ClearAll();
			}


			// check in/out cancel 
			DataTable dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), ClassLib.ComVar.CxYieldCheckinCancel);

			if(dt_ret != null && dt_ret.Rows.Count > 0)
			{
				_Checkin_Cancel = (dt_ret.Rows[0].ItemArray[1].ToString().Trim().ToUpper().Equals("Y") ) ? true : false;
			}
			else
			{
				_Checkin_Cancel = false;
			}

			dt_ret.Dispose();




		}

		private void AutoShippingCheck()
		{
			try
			{
				string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, COM.ComVar.This_Factory);
				string vStyleCd = COM.ComFunction.Empty_Combo(cmb_style, "");
					
				Pop_BS_Shipping_Material_AutoCheck vPop = new Pop_BS_Shipping_Material_AutoCheck(fgrid_main, vFactory, vStyleCd);
				vPop.ShowDialog();
				//if (vPop.ShowDialog() == DialogResult.OK)
				//	ClassLib.ComFunction.User_Message("Auto Check Complete", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "AutoShippingCheck", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void AutoProdShippingCheck()
		{
			try
			{
			 		

				string factory = ClassLib.ComFunction.Empty_Combo(cmb_factory, ClassLib.ComVar.This_Factory);
				string style_cd = ClassLib.ComFunction.Empty_Combo(cmb_style, "").Replace("-", "");

				string semi_good_cd = "";
				string component_cd = "";
				string template_seq = ""; 
				string template_level = ""; 


				for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
				{
					string vType = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxTYPE_DIVISION]);
					 
					if(vType.Equals(_TypeSG) || vType.Equals(_TypeCmp) ) continue;

					semi_good_cd = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxSEMI_GOOD_CD]);
					component_cd = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxCOMPONENT_CD]);
					template_seq = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxTEMPLATE_SEQ]);
					template_level = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxTEMPLATE_LEVEL]);



					if(vType.Equals(_TypeJoint) )
					{

						DataTable vDt = DELIVERY_MATERIAL_AUTO_CHECK(factory, style_cd, semi_good_cd, component_cd, template_seq, template_level);

						if (vDt.Rows.Count > 0)
						{

							if (Convert.ToBoolean(ClassLib.ComFunction.NullCheck(vDt.Rows[0][0], "FALSE")))
							{
								fgrid_main[vRow, _prodYnCol] = true;  
							}
							else
							{
								fgrid_main[vRow, _prodYnCol] = false;
							} 

						} 
						 

					}
					else if(vType.Equals(_TypeMat) && ( Convert.ToInt32(template_level) <= 1 ) )   // only raw material
					{
						fgrid_main[vRow, _prodYnCol] = true; 
					}
					else if(vType.Equals(_TypeMat) && Convert.ToInt32(template_level) > 1)   // 임가공 구조 내의 raw material
					{

						// 상위 임가공 구조가 체크 되어 있으면 체크 해제
						// 상위 임가공 구조가 체크 되어 있지 않으면 체크 처리
						int parent_row = -1;

						//------------------------------------------------------------------------------------------------------------
						C1.Win.C1FlexGrid.Node vStartNode = fgrid_main.Rows[vRow].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent);

						if (vStartNode != null)
						{
							parent_row = vRow;

							while (true)
							{
								vStartNode = fgrid_main.Rows[parent_row].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent);
								if (vStartNode == null || fgrid_main.Rows[parent_row].Node.Level <= 3)
									break;					
						
								parent_row = vStartNode.Row.Index; 
							}
						}
  
						//------------------------------------------------------------------------------------------------------------

 
						if(Convert.ToBoolean(fgrid_main[parent_row, _prodYnCol].ToString() ) )
						{
							fgrid_main[vRow, _prodYnCol] = false;
						}
						else
						{
							fgrid_main[vRow, _prodYnCol] = true;  
						}

					}

					

					fgrid_main[vRow, _commonYnCol] = false;
					fgrid_main.Update_Row(vRow);
					fgrid_main.Select(vRow, _prodYnCol);  


//					DataTable vDt = DELIVERY_MATERIAL_AUTO_CHECK(factory, style_cd, semi_good_cd, component_cd, template_seq, template_level);
//
//					if (vDt.Rows.Count > 0)
//					{
//						if (Convert.ToBoolean(ClassLib.ComFunction.NullCheck(vDt.Rows[0][0], "FALSE")))
//						{
//							fgrid_main[vRow, _prodYnCol] = true; 
//						}
//						else
//						{
//							fgrid_main[vRow, _prodYnCol] = false;
//						}
//
//						
//						fgrid_main[vRow, _commonYnCol] = false;
//						fgrid_main.Select(vRow, _prodYnCol);  
//
//
//					}
					 
				}  // end for vRow



			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "AutoProdShippingCheck", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


 

		


		private void  SetPrintYield()
		{
			try
			{			 
				string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BS_Shipping_Material") ;
				string Para         = " ";

				#region 출력조건

				int  iCnt  = 4;
				string [] aHead =  new string[iCnt];	
				string vFactory = ClassLib.ComFunction.Empty_Combo(cmb_factory, COM.ComVar.This_Factory);
				string vStyleCd = ClassLib.ComFunction.Empty_Combo(cmb_style, "");
				vStyleCd = vStyleCd.Replace("-", "");
				string vGender  = txt_gender.Text;
				string vDev		= ClassLib.ComFunction.Empty_Combo(cmb_devision, "");

				aHead[0]    = vFactory ;
				aHead[1]    = vStyleCd;
				aHead[2]    = vGender;
				aHead[3]    = vDev;				

			
				#endregion
	
				Para = 	" /rp ";
				for (int i  = 1 ; i<= iCnt ; i++)
				{				
					Para = Para + "[" + aHead[i-1] + "] ";
				}
	
				FlexBase.Report.Form_RdViewer   report = new FlexBase.Report.Form_RdViewer ( mrd_Filename, Para);
				report.Show();	

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetPrintYield", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}


		private void mnu_value_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (!COM.ComFunction.Empty_Combo(cmb_devision, "").Equals(ClassLib.ComVar.Production))
					return;

				int[] vSelection = fgrid_main.Selections;
				int vCol = fgrid_main.Selection.c1;
				int vLossCol = (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxPROD_LOSS_RATE;
				int vSemiCol = (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxPROD_SEMI_GOOD_CD;

				string vFactory = cmb_factory.SelectedValue.ToString();
				string vStyleCd = txt_styleCd.Text.Replace("-", "");
				string vSemi = "", vLoss = "";

				foreach (int vRow in vSelection)
				{
					if (fgrid_main[vRow, vSemiCol] != null)
						vSemi = fgrid_main[vRow, vSemiCol].ToString();
					if (fgrid_main[vRow, vLossCol] != null)
						vLoss = fgrid_main[vRow, vLossCol].ToString();

					if (vSemi.Equals("") && vLoss.Equals(""))
						break;
				}

				COM.ComVar.Parameter_PopUp = new string[]{vFactory, vStyleCd, vSemi, vLoss};
				Pop_BS_Outgoing_Process pop_process = new Pop_BS_Outgoing_Process();
				pop_process.ShowDialog(this);
				if (pop_process.DialogResult == DialogResult.OK)
					GridSetData();

				pop_process.Dispose();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
		}

		#region 그리드 이벤트 처리

		private void Grid_MouseUpProcess(System.Windows.Forms.MouseEventArgs e)
		{

		}

		private void Grid_AfterEditProcess(C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			e.Cancel = true;

			fgrid_main[e.Row, 0] = "";

			if (fgrid_main.Rows[e.Row].Node.Level > 2 && (e.Col == _commonYnCol || e.Col == _shipYnCol || e.Col == _prodYnCol || e.Col == _purShipYnCol || e.Col == _importYnCol || e.Col == _localYnCol)) 
			{
				GridCheckBoxCorrection();
			}
			else if (e.Col == _commonYnCol || e.Col == _shipYnCol || e.Col == _prodYnCol || e.Col == _purShipYnCol || e.Col == _importYnCol || e.Col == _localYnCol)
			{
				fgrid_main[e.Row, e.Col] = false;
			}
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}

		#endregion

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

			if (cmb_style.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Style", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_factory.Focus();
				return false;
			}

			if (fgrid_main.Rows.Count <= fgrid_main.Rows.Fixed 
				&& (arg_type == ClassLib.ComVar.Validate_Save ||
				arg_type == _validate_shipCheck ||
				arg_type == _validate_prodCheck ))
			{
				ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
																																	 

			// 부분별 체크 (Search, Save, Delete, Confirm..)
			switch (arg_type)
			{
				case ClassLib.ComVar.Validate_Search:

					break;
				case ClassLib.ComVar.Validate_Save:
                    return CheckSaveValidation();
				case ClassLib.ComVar.Validate_Delete:

					break;
				case ClassLib.ComVar.Validate_Confirm:

					break;
				case _validate_shipCheck:

					break;
			}

			return true;
		}

        private bool CheckSaveValidation()
        {
            string sDiv = COM.ComFunction.Empty_Combo(cmb_devision, "");
            if (sDiv.Equals(ClassLib.ComVar.Shipping))
            {
                for (int iRow = fgrid_main.Rows.Fixed; iRow < fgrid_main.Rows.Count; iRow++)
                {
                    object oShipYN = fgrid_main[iRow, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxSHIP_YN];
                    object oPurYN = fgrid_main[iRow, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxPUR_SHIP_YN];
                    object oImport = fgrid_main[iRow, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxIMPORT_DIV];

                    bool bShipYN = oShipYN == null ? false : (bool)oShipYN;
                    bool bPurYN = oPurYN == null ? false : (bool)oPurYN;
                    string sImport = oImport == null ? "" : oImport.ToString();

                    if (sImport.Equals(_DS_SHIPPING))
                    {
                        if (!bShipYN || !bPurYN)
                        {
                            fgrid_main.Select(iRow, 0);
                            if (ClassLib.ComFunction.User_Message("Plase check shipping or purchasing", "Invalidate", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                            {
                                return false;
                            }
                        }
                    }
                    else if (sImport.Equals(_LLT))
                    {
                        if (bShipYN)
                        {
                            fgrid_main.Select(iRow, 0);
                            if (ClassLib.ComFunction.User_Message("Plase check shipping", "Invalidate", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SBS_SHIPPING_MATERIAL.SELECT_SBC_YIELD_INFO_LIST
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_style_cd">스타일코드</param>
		/// <param name="arg_gender">젠더</param>
		/// <param name="arg_dev">Dev</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBC_YIELD_INFO_LIST(string arg_factory, string arg_style_cd, string arg_gender, string arg_dev)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_MATERIAL.SELECT_SBC_YIELD_INFO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_GENDER";
			MyOraDB.Parameter_Name[3] = "ARG_DEV";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_style_cd;
			MyOraDB.Parameter_Values[2] = arg_gender;
			MyOraDB.Parameter_Values[3] = arg_dev;
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}



		/// <summary>
		/// DELIVERY_MATERIAL_AUTO_CHECK : AUTO CHECK
		/// </summary>
		private DataTable DELIVERY_MATERIAL_AUTO_CHECK(string arg_factory, 
			string arg_style_cd,
			string arg_semi_good_cd,
			string arg_component_cd,
			string arg_template_seq,
			string arg_template_level)
		{

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_MATERIAL.DELIVERY_MATERIAL_AUTO_CHECK";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD";
			MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
			MyOraDB.Parameter_Name[4] = "ARG_TEMPLATE_SEQ";
			MyOraDB.Parameter_Name[5] = "ARG_TEMPLATE_LEVEL";
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
			MyOraDB.Parameter_Values[1] = arg_style_cd;
			MyOraDB.Parameter_Values[2] = arg_semi_good_cd;
			MyOraDB.Parameter_Values[3] = arg_component_cd;
			MyOraDB.Parameter_Values[4] = arg_template_seq;
			MyOraDB.Parameter_Values[5] = arg_template_level;
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet vds_ret = MyOraDB.Exe_Select_Procedure();

			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		#endregion																								


		#region Check In / Out

		private void chk_CheckInOut_CheckedChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				if(cmb_factory.SelectedIndex == -1 || cmb_style.SelectedIndex == -1) 
				{
					chk_CheckInOut.Checked = false;
					return;
				}

				this.Cursor = Cursors.WaitCursor;

				if(chk_CheckInOut.Checked)
				{
					Run_Check_In(); 
				}
				else
				{ 
					Run_Check_Out();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "chk_CheckInOut_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		// 체크 아웃 실패 되었을때, 다시 체크 인 표시 해 주고, 이벤트 태우지 않기 위함
		private bool _CheckInFail = false;
		private bool _CheckOutFail = false;

		private string _CheckInSeq = "0";

		private void Run_Check_In()
		{
			if( _CheckOutFail ) return;

			string division = "I"; // In
			string factory = cmb_factory.SelectedValue.ToString();
			string stylecd = cmb_style.SelectedValue.ToString().Replace("-", "");
			string checkuser = ClassLib.ComVar.This_User;
			
			string remarks = "";

			string vDev = cmb_devision.SelectedValue.ToString();
            
			switch (vDev)
			{
				case ClassLib.ComVar.Shipping:
					remarks = "shipping material";
					break;
				case ClassLib.ComVar.Production:
					remarks = "delivery material";
					break;
				case ClassLib.ComVar.Import:
					remarks = "shipping material (import)";
					break;
				case ClassLib.ComVar.Local:
					remarks = "shipping material (local)";
					break;
			}


			#region Check in 2)
 
	
//			// 1) job factory Webservice 로 변경
//			// 2) job factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
//			// 3) user factory Webservice 로 변경
//			// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
//			// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
//			// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출
//			// 7) 5) 가 아닌 경우,job factory Webservice 로 변경  
//			// 8) job factory Checkin table insert 처리
//			// 9) user factory Webservice 로 변경
//			// 10) 8) 성공 시 user factory Checkin table insert 처리 
//			// 11) 10) 성공 시 최종 Checkin 성공
//	
//	
//			// 1) job factory Webservice 로 변경
//			string websvc_factory = ""; 
//			
//			if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
//			{
//				websvc_factory = factory;
//			}
//			else
//			{
//				websvc_factory = ClassLib.ComVar.DSFactory;
//			} 
//				
//			// 2) job factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
//			// 3) user factory Webservice 로 변경
//			DataTable dt_job = Scan_Check_InOut(factory, stylecd, checkuser, websvc_factory);
//			websvc_factory = ClassLib.ComVar.This_Factory;
//			
//
//			string job_checkin_seq = "";
//			string job_checkin_user = "";
//
//			if(dt_job == null)
//			{
//
//				Control_Enable(false); 
//			
//				_CheckInFail = true;
//	
//				string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error (Remote)"; 
//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
//				chk_CheckInOut.CheckState = CheckState.Unchecked; 
//	
//				return;
//
//
//			}
//			else
//			{
//				job_checkin_seq = dt_job.Rows[0].ItemArray[0].ToString();
//				job_checkin_user = dt_job.Rows[0].ItemArray[1].ToString(); 
//			}
//
//			
//
//			// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
//			DataTable dt_user = Scan_Check_InOut(factory, stylecd, checkuser, websvc_factory);  
//
//			string user_checkin_seq = "";
//			string user_checkin_user = "";
//
//			if(dt_user == null)
//			{
//
//				Control_Enable(false); 
//			
//				_CheckInFail = true;
//	
//				string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error"; 
//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
//				chk_CheckInOut.CheckState = CheckState.Unchecked; 
//	
//				return;
//
//
//			}
//			else
//			{
//				user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
//				user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString(); 
//			}
//
//
//
//			// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
//
//			//**********************************************//
//			//* 예기치 않은 경우의 checkin out 안되는 문제 *// 
//			//**********************************************//
// 
//			if( ! job_checkin_user.Trim().Equals("") &&  ! job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
//			{ 
//				
//				Control_Enable(false); 
//			
//				_CheckInFail = true;
//	
//				string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
//				string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + checkin_user; 
//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
//				chk_CheckInOut.CheckState = CheckState.Unchecked; 
//	
//				return;
//
//			} 
//
//
//			// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
//			string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq;
//			_CheckInSeq = checkinseq;
//
//
//			// 7) 5) 가 아닌 경우,job factory Webservice 로 변경
//			if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
//			{
//				websvc_factory = factory;
//			}
//			else
//			{
//				websvc_factory = ClassLib.ComVar.DSFactory;
//			} 
//
//			
//			// 8) job factory Checkin table insert 처리
//			// 9) user factory Webservice 로 변경
//			DataSet ds_job = Save_Check_InOut(division, factory, stylecd, checkinseq, checkuser, websvc_factory);
//			websvc_factory = ClassLib.ComVar.This_Factory; 
//
//
//			if(ds_job == null)
//			{
//
//				Control_Enable(false); 
//			
//				_CheckInFail = true;
//	
//				string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
//				string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error (Remote)"; 
//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
//				chk_CheckInOut.CheckState = CheckState.Unchecked; 
//	
//				return;
//
//			}
//			
//
//			
//			// 10) 8) 성공 시 user factory Checkin table insert 처리 
//			DataSet ds_user = Save_Check_InOut(division, factory, stylecd, checkinseq, checkuser, websvc_factory);
//
//			if(ds_user == null)
//			{
//
//				Control_Enable(false); 
//			
//				_CheckInFail = true;
//	
//				string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
//				string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error"; 
//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
//				chk_CheckInOut.CheckState = CheckState.Unchecked; 
//	
//				return;
//
//			}
//
//
//			// 11) 10) 성공 시 최종 Checkin 성공
//			Control_Enable(true); 
//		
//			_CheckInFail = false;
//			ClassLib.ComFunction.User_Message("Check In Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

			#endregion

			#region Check in : Line 이상있는 경우, Checkin Local만 시도
 
	 
			if(_Checkin_Cancel)   // local 만 체크
			{
				Run_Check_In_Local(division, factory, stylecd, checkuser, remarks);
			}
			else  // remote, local 모두 체크
			{
				Run_Check_In_RemoteLocal(division, factory, stylecd, checkuser, remarks);
			}



			#endregion



		}



		/// <summary>
		/// Run_Check_In_RemoteLocal : 정상적인 Checkin (remote, local 모두 체크)
		/// </summary>
		/// <param name="arg_division"></param>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <param name="arg_checkuser"></param>
		private bool Run_Check_In_RemoteLocal(string arg_division, string arg_factory, string arg_stylecd, string arg_checkuser, string arg_remarks)
		{
 
	
			// 1) job factory Webservice 로 변경
			// 2) job factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
			// 3) user factory Webservice 로 변경
			// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
			// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
			// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출
			// 7) 5) 가 아닌 경우,job factory Webservice 로 변경  
			// 8) job factory Checkin table insert 처리
			// 9) user factory Webservice 로 변경
			// 10) 8) 성공 시 user factory Checkin table insert 처리 
			// 11) 10) 성공 시 최종 Checkin 성공
	
	
			try
			{
				// 1) job factory Webservice 로 변경
				string websvc_factory = ""; 
			
				if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
				{
					websvc_factory = arg_factory;
				}
				else
				{
					websvc_factory = ClassLib.ComVar.DSFactory;
				} 
				
				// 2) job factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
				// 3) user factory Webservice 로 변경
				DataTable dt_job = Scan_Check_InOut(arg_factory, arg_stylecd, arg_checkuser, websvc_factory);
				websvc_factory = ClassLib.ComVar.This_Factory;
			

				string job_checkin_seq = "";
				string job_checkin_user = "";

				if(dt_job == null)
				{

					Control_Enable(false); 
			
					_CheckInFail = true;
	
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error (Remote)"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					chk_CheckInOut.CheckState = CheckState.Unchecked; 
	
					return false;


				}
				else
				{
					job_checkin_seq = dt_job.Rows[0].ItemArray[0].ToString();
					job_checkin_user = dt_job.Rows[0].ItemArray[1].ToString(); 
				} 
			 

				// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
				DataTable dt_user = Scan_Check_InOut(arg_factory, arg_stylecd, arg_checkuser, websvc_factory);  

				string user_checkin_seq = "";
				string user_checkin_user = "";

				if(dt_user == null)
				{

					Control_Enable(false); 
			
					_CheckInFail = true;
	
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					chk_CheckInOut.CheckState = CheckState.Unchecked; 
	
					return false;


				}
				else
				{
					user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
					user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString(); 
				}



				// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패 
 
				if( ! job_checkin_user.Trim().Equals("") &&  ! job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
				{ 
				
					Control_Enable(false); 
			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + checkin_user; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					chk_CheckInOut.CheckState = CheckState.Unchecked; 
	
					return false;

				} 


				// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
				string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq;
				_CheckInSeq = checkinseq;


				// 7) 5) 가 아닌 경우,job factory Webservice 로 변경
				if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
				{
					websvc_factory = arg_factory;
				}
				else
				{
					websvc_factory = ClassLib.ComVar.DSFactory;
				} 

			
				// 8) job factory Checkin table insert 처리
				// 9) user factory Webservice 로 변경
				DataSet ds_job = Save_Check_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);
				websvc_factory = ClassLib.ComVar.This_Factory; 


				if(ds_job == null)
				{

					Control_Enable(false); 
			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error (Remote)"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					chk_CheckInOut.CheckState = CheckState.Unchecked; 
	
					return false;

				}
			

			
				// 10) 8) 성공 시 user factory Checkin table insert 처리 
				DataSet ds_user = Save_Check_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);

				if(ds_user == null)
				{

					Control_Enable(false); 
			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					chk_CheckInOut.CheckState = CheckState.Unchecked; 
	
					return false;

				}


				// 11) 10) 성공 시 최종 Checkin 성공
				Control_Enable(true); 
		
				_CheckInFail = false;
				ClassLib.ComFunction.User_Message("Check In Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

				return true;
 
			}
			catch
			{
				return false;
			}



		}



		/// <summary>
		/// Run_Check_In_Local : Line 이상있는 경우, Checkin Local만 시도
		/// </summary>
		/// <param name="arg_division"></param>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <param name="arg_checkuser"></param>
		private bool Run_Check_In_Local(string arg_division, string arg_factory, string arg_stylecd, string arg_checkuser, string arg_remarks)
		{

			
	
			// 1) job factory Webservice 로 변경
			// 2) job factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
			// 3) user factory Webservice 로 변경
			// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
			// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
			// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출
			// 7) 5) 가 아닌 경우,job factory Webservice 로 변경  
			// 8) job factory Checkin table insert 처리
			// 9) user factory Webservice 로 변경
			// 10) 8) 성공 시 user factory Checkin table insert 처리 
			// 11) 10) 성공 시 최종 Checkin 성공
	
	 
				
			try
			{
				// 3) user factory Webservice 로 변경 
				string websvc_factory = ""; 
				websvc_factory = ClassLib.ComVar.This_Factory;
			

				string job_checkin_seq = "0";
				string job_checkin_user = ClassLib.ComVar.This_User.Trim();

			
			 

				// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
				DataTable dt_user = Scan_Check_InOut(arg_factory, arg_stylecd, arg_checkuser, websvc_factory);  

				string user_checkin_seq = "";
				string user_checkin_user = "";

				if(dt_user == null)
				{

					Control_Enable(false); 
			
					_CheckInFail = true;
	
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					chk_CheckInOut.CheckState = CheckState.Unchecked; 
	
					return false;


				}
				else
				{
					user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
					user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString(); 
				}




				// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패  

				job_checkin_user = user_checkin_user;
 
				if( ! job_checkin_user.Trim().Equals("") &&  ! job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
				{ 
				
					Control_Enable(false); 
			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + checkin_user; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					chk_CheckInOut.CheckState = CheckState.Unchecked; 
	
					return false;

				} 


				// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
				string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq;
				_CheckInSeq = checkinseq;

 
		 
				// 9) user factory Webservice 로 변경 
				websvc_factory = ClassLib.ComVar.This_Factory;  

			
				// 10) 8) 성공 시 user factory Checkin table insert 처리 
				DataSet ds_user = Save_Check_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);

				if(ds_user == null)
				{

					Control_Enable(false); 
			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					chk_CheckInOut.CheckState = CheckState.Unchecked; 
	
					return false;

				}


				// 11) 10) 성공 시 최종 Checkin 성공
				Control_Enable(true); 
		
				_CheckInFail = false;
				ClassLib.ComFunction.User_Message("Check In Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

				return true;

			}
			catch
			{
				return false;
			}
  


		}

 	
		private void Run_Check_Out()
		{
			if( _CheckInFail ) return;

			//-----------------------------------------------------------------------------------------------
			//저장되지 않은 데이터 있을 때 조회하면 경고 메시지 표시
			bool exist_modify = Check_NotSave_Data("Check Out");
			if(exist_modify) 
			{
				_CheckOutFail = true;

				chk_CheckInOut.CheckState = CheckState.Checked;

				return;
			}
			//-----------------------------------------------------------------------------------------------

			string division = "O"; // Out
			string factory = cmb_factory.SelectedValue.ToString();
			string stylecd = cmb_style.SelectedValue.ToString().Replace("-", "");
			string checkuser = ClassLib.ComVar.This_User;
			string remarks = "check out";

			string job_factory = ClassLib.ComVar.This_Factory; 
			DataSet ds_ret = Save_Check_InOut(division, factory, stylecd, _CheckInSeq, checkuser, remarks, job_factory);

			if(ds_ret == null)
			{
				Control_Enable(true);  

				_CheckOutFail = true;

				ClassLib.ComFunction.User_Message("Check Out Fail.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				Control_Enable(false); 

				_CheckOutFail = false;

				ClassLib.ComFunction.User_Message("Check Out Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}


		#region Check in 2)


		/// <summary>
		/// Scan_Check_InOut : 
		/// </summary>
		/// <param name="arg_division"></param>
		/// <param name="arg_factory"></param>
		/// <param name="arg_style_cd"></param>
		/// <param name="arg_checkuser"></param>
		/// <param name="arg_job_factory"></param>
		/// <returns></returns>
		public static DataTable Scan_Check_InOut(string arg_factory, 
			string arg_style_cd, 
			string arg_checkuser, 
			string arg_job_factory)
		{


			try
			{

				DataSet ds_ret;  
				COM.OraDB LMyOraDB = new COM.OraDB();


				ClassLib.ComFunction.Change_WebService_URL(arg_job_factory); 


 
				LMyOraDB.ReDim_Parameter(4); 
 
				LMyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN_SEQ.SELECT_SBC_YIELD_CHECKIN_MAIN";   
   
				LMyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				LMyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
				LMyOraDB.Parameter_Name[2] = "ARG_CHECKIN_USER";
				LMyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[3] = (int)OracleType.Cursor; 
			   
				LMyOraDB.Parameter_Values[0] = arg_factory;
				LMyOraDB.Parameter_Values[1] = arg_style_cd; 
				LMyOraDB.Parameter_Values[2] = arg_checkuser;
				LMyOraDB.Parameter_Values[3] = ""; 


				LMyOraDB.Add_Select_Parameter(true); 
				ds_ret = LMyOraDB.Exe_Select_Procedure(); 


				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);



				if(ds_ret == null) return null; 
				return ds_ret.Tables[LMyOraDB.Process_Name];

				// 컬럼 0 : Next Checkin Sequence
				// 컬럼 1 : Checkin User
 

			}
			catch
			{
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory); 
				return null; 
			}

		}



		/// <summary>
		/// Save_Check_InOut : 
		/// </summary>
		/// <param name="arg_division"></param>
		/// <param name="arg_factory"></param>
		/// <param name="arg_style_cd"></param>
		/// <param name="arg_checkinseq"></param>
		/// <param name="arg_checkinuser"></param>
		/// <param name="arg_remarks"></param>
		/// <param name="arg_job_factory"></param>
		/// <returns></returns>
		public static DataSet Save_Check_InOut(string arg_division, 
			string arg_factory, 
			string arg_style_cd, 
			string arg_checkinseq,
			string arg_checkinuser, 
			string arg_remarks,
			string arg_job_factory)
		{


			try
			{

				DataSet ds_ret;  
				COM.OraDB LMyOraDB = new COM.OraDB();
 

				ClassLib.ComFunction.Change_WebService_URL(arg_job_factory);  

 
				LMyOraDB.ReDim_Parameter(6); 
 
				if(arg_division == "I")
				{
					//LMyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN_SEQ.SAVE_SBC_YIELD_CHECKIN_MAIN";  
					LMyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN_SEQ.SAVE_SBC_YIELD_CHECKIN_MAIN_R";  
				}
				else if(arg_division == "O")
				{
					//LMyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN_SEQ.SAVE_SBC_YIELD_CHECKOUT_MAIN";  
					LMyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN_SEQ.SAVE_SBC_YIELD_CHECKOUT_MAIN_R";  
				}

  
				LMyOraDB.Parameter_Name[0] = "ARG_DIVISION"; 
				LMyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				LMyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
				LMyOraDB.Parameter_Name[3] = "ARG_CHECKIN_SEQ";
				LMyOraDB.Parameter_Name[4] = "ARG_CHECKIN_USER";
				LMyOraDB.Parameter_Name[5] = "ARG_REMARKS";
 
				LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			  
				LMyOraDB.Parameter_Values[0] = "SM";
				LMyOraDB.Parameter_Values[1] = arg_factory;
				LMyOraDB.Parameter_Values[2] = arg_style_cd; 
				LMyOraDB.Parameter_Values[3] = arg_checkinseq;
				LMyOraDB.Parameter_Values[4] = arg_checkinuser; 
				LMyOraDB.Parameter_Values[5] = arg_remarks; 


				LMyOraDB.Add_Modify_Parameter(true); 
				ds_ret = LMyOraDB.Exe_Modify_Procedure(); 


				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);



				if(ds_ret == null) return null; 
				return ds_ret;
 

			}
			catch
			{
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory); 
				return null; 
			}

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

		/// <summary>
		/// Control_Enable : Check In/Out 에 대한 콘트롤 권한 부여
		/// </summary>
		/// <param name="arg_enable"></param>
		private void Control_Enable(bool arg_enable)
		{
			fgrid_main.AllowEditing	= arg_enable;
			tbtn_Save.Enabled		= arg_enable;
			//chk_CheckInOut.Checked	= arg_enable;

			cmb_factory.Enabled		= !arg_enable;
			txt_styleCd.ReadOnly	= arg_enable;
			cmb_style.Enabled		= !arg_enable;
			cmb_devision.Enabled	= !arg_enable;
			
			if (cmb_devision.SelectedValue.ToString().Equals(ClassLib.ComVar.Shipping))
			{
				btn_shipCheck.Enabled = arg_enable;
			}
			else if(cmb_devision.SelectedValue.ToString().Equals(ClassLib.ComVar.Production))
			{
				btn_prodCheck.Enabled = arg_enable;
			}

			if(arg_enable)
			{				
				fgrid_main.ContextMenu = ctx_main; 
			}
			else
			{  
				fgrid_main.ContextMenu = null;  
			}

			if(ClassLib.ComVar.This_Factory == "VJ")
			{
				fgrid_main.Cols[_commonYnCol].Visible = false;
			}
		}

		#endregion 

		private void chk_manual_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chk_manual.Checked)
			{
				fgrid_main.Cols[_shipYnCol].AllowEditing = false;
				fgrid_main.Cols[_purShipYnCol].AllowEditing = true;

				_orgSData = new object[fgrid_main.Rows.Count];
				_orgOData = new object[fgrid_main.Rows.Count];
				_orgPData = new object[fgrid_main.Rows.Count];
				_orgCData = new object[fgrid_main.Rows.Count];

				for (int vRow = 0 ; vRow < fgrid_main.Rows.Count ; vRow++)
				{
					_orgSData[vRow] = fgrid_main[vRow, _shipYnCol];
					_orgOData[vRow] = fgrid_main[vRow, _prodYnCol];
					_orgPData[vRow] = fgrid_main[vRow, _purShipYnCol];
					_orgCData[vRow] = fgrid_main[vRow, _commonYnCol];
				}
			}
			else 
			{
				fgrid_main.Cols[_shipYnCol].AllowEditing = true;
				fgrid_main.Cols[_purShipYnCol].AllowEditing = false;
			}
		}

		#endregion

	}
}

