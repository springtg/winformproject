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

namespace FlexPurchase.Search
{
	public class Form_BW_Order_Analysis : COM.PCHWinForm.Form_Top
	{

		#region 디자이너에서 생성한 멤버

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView sheetView1;  
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory; 
		private System.Windows.Forms.Panel pnl_low;
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.Label lbl_Style; 
		private System.Windows.Forms.GroupBox gb_Result;
		private System.Windows.Forms.TextBox txt_Result;
		private C1.Win.C1List.C1Combo cmb_OBSId;
		private System.Windows.Forms.Label lbl_OBSId;
		private C1.Win.C1List.C1Combo cmb_OBSType;
		private System.Windows.Forms.Label lbl_OBSType; 

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 멤버
 
		private COM.OraDB MyOraDB = new COM.OraDB();
		private System.Windows.Forms.ContextMenu cmenu_Grid;
		private System.Windows.Forms.MenuItem menuItem_DisplaySize;
		private System.Windows.Forms.CheckBox chk_OA;
		private System.Windows.Forms.CheckBox chk_MPS;
		private System.Windows.Forms.CheckBox chk_GAC;
		private System.Windows.Forms.CheckBox chk_Order;
		private System.Windows.Forms.MenuItem menuItem_StyleLifeCycle;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.Label btn_GACScore;
		private COM.ComFunction MyComFunction = new COM.ComFunction();  

		#endregion

		#region 생성자 / 소멸자

		public Form_BW_Order_Analysis()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			Init_Form();
		}

		public Form_BW_Order_Analysis(string factory, string obs_id, string obs_type, string style_cd)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			Init_Form();

			cmb_Factory.SelectedValue = factory;
			cmb_OBSId.SelectedValue   = obs_id;
			cmb_OBSType.SelectedValue = obs_type;
			txt_StyleCd.Text          = style_cd; 
			Set_StyleCode(); 
			cmb_StyleCd.SelectedValue = style_cd;
			Search();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BW_Order_Analysis));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_low = new System.Windows.Forms.Panel();
            this.gb_Result = new System.Windows.Forms.GroupBox();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_OA = new System.Windows.Forms.CheckBox();
            this.chk_GAC = new System.Windows.Forms.CheckBox();
            this.chk_Order = new System.Windows.Forms.CheckBox();
            this.chk_MPS = new System.Windows.Forms.CheckBox();
            this.btn_GACScore = new System.Windows.Forms.Label();
            this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
            this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
            this.txt_StyleCd = new System.Windows.Forms.TextBox();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.cmb_OBSId = new C1.Win.C1List.C1Combo();
            this.lbl_OBSId = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.cmb_OBSType = new C1.Win.C1List.C1Combo();
            this.lbl_OBSType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.spd_main = new COM.SSP();
            this.cmenu_Grid = new System.Windows.Forms.ContextMenu();
            this.menuItem_DisplaySize = new System.Windows.Forms.MenuItem();
            this.menuItem_StyleLifeCycle = new System.Windows.Forms.MenuItem();
            this.sheetView1 = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_low.SuspendLayout();
            this.gb_Result.SuspendLayout();
            this.pnl_head.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OBSId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OBSType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetView1)).BeginInit();
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
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.pnl_low);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.GridDefinition = "15.7986111111111:False:True;70.4861111111111:True:False;12.3263888888889:False:Tr" +
                "ue;\t0.393700787401575:False:True;98.4251968503937:False:False;0.393700787401575:" +
                "False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_low
            // 
            this.pnl_low.BackColor = System.Drawing.Color.Transparent;
            this.pnl_low.Controls.Add(this.gb_Result);
            this.pnl_low.Location = new System.Drawing.Point(8, 505);
            this.pnl_low.Name = "pnl_low";
            this.pnl_low.Size = new System.Drawing.Size(1008, 71);
            this.pnl_low.TabIndex = 175;
            // 
            // gb_Result
            // 
            this.gb_Result.Controls.Add(this.txt_Result);
            this.gb_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Result.Location = new System.Drawing.Point(0, 0);
            this.gb_Result.Name = "gb_Result";
            this.gb_Result.Size = new System.Drawing.Size(1008, 71);
            this.gb_Result.TabIndex = 1;
            this.gb_Result.TabStop = false;
            this.gb_Result.Text = "Result";
            // 
            // txt_Result
            // 
            this.txt_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Result.Location = new System.Drawing.Point(8, 18);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(984, 48);
            this.txt_Result.TabIndex = 0;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.groupBox1);
            this.pnl_head.Controls.Add(this.cmb_StyleCd);
            this.pnl_head.Controls.Add(this.txt_StyleCd);
            this.pnl_head.Controls.Add(this.lbl_Style);
            this.pnl_head.Controls.Add(this.cmb_OBSId);
            this.pnl_head.Controls.Add(this.lbl_OBSId);
            this.pnl_head.Controls.Add(this.cmb_Factory);
            this.pnl_head.Controls.Add(this.cmb_OBSType);
            this.pnl_head.Controls.Add(this.lbl_OBSType);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.lbl_Factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 91);
            this.pnl_head.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chk_OA);
            this.groupBox1.Controls.Add(this.chk_GAC);
            this.groupBox1.Controls.Add(this.chk_Order);
            this.groupBox1.Controls.Add(this.chk_MPS);
            this.groupBox1.Controls.Add(this.btn_GACScore);
            this.groupBox1.Location = new System.Drawing.Point(728, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 64);
            this.groupBox1.TabIndex = 556;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // chk_OA
            // 
            this.chk_OA.Checked = true;
            this.chk_OA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_OA.Location = new System.Drawing.Point(8, 19);
            this.chk_OA.Name = "chk_OA";
            this.chk_OA.Size = new System.Drawing.Size(48, 17);
            this.chk_OA.TabIndex = 551;
            this.chk_OA.Text = "OA";
            this.chk_OA.CheckedChanged += new System.EventHandler(this.chk_OA_CheckedChanged);
            // 
            // chk_GAC
            // 
            this.chk_GAC.Checked = true;
            this.chk_GAC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_GAC.Location = new System.Drawing.Point(200, 19);
            this.chk_GAC.Name = "chk_GAC";
            this.chk_GAC.Size = new System.Drawing.Size(56, 17);
            this.chk_GAC.TabIndex = 553;
            this.chk_GAC.Text = "GAC";
            this.chk_GAC.CheckedChanged += new System.EventHandler(this.chk_GAC_CheckedChanged);
            // 
            // chk_Order
            // 
            this.chk_Order.Checked = true;
            this.chk_Order.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Order.Location = new System.Drawing.Point(64, 19);
            this.chk_Order.Name = "chk_Order";
            this.chk_Order.Size = new System.Drawing.Size(64, 17);
            this.chk_Order.TabIndex = 554;
            this.chk_Order.Text = "Order";
            this.chk_Order.CheckedChanged += new System.EventHandler(this.chk_Order_CheckedChanged);
            // 
            // chk_MPS
            // 
            this.chk_MPS.Checked = true;
            this.chk_MPS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_MPS.Location = new System.Drawing.Point(136, 19);
            this.chk_MPS.Name = "chk_MPS";
            this.chk_MPS.Size = new System.Drawing.Size(56, 17);
            this.chk_MPS.TabIndex = 552;
            this.chk_MPS.Text = "MPS";
            this.chk_MPS.CheckedChanged += new System.EventHandler(this.chk_MPS_CheckedChanged);
            // 
            // btn_GACScore
            // 
            this.btn_GACScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GACScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_GACScore.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GACScore.ImageIndex = 0;
            this.btn_GACScore.ImageList = this.img_LongButton;
            this.btn_GACScore.Location = new System.Drawing.Point(104, 42);
            this.btn_GACScore.Name = "btn_GACScore";
            this.btn_GACScore.Size = new System.Drawing.Size(150, 23);
            this.btn_GACScore.TabIndex = 555;
            this.btn_GACScore.Text = "GAC Score Process";
            this.btn_GACScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_GACScore.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_GACScore.Click += new System.EventHandler(this.btn_GACScore_Click);
            this.btn_GACScore.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_GACScore.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_GACScore.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // img_LongButton
            // 
            this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
            this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_LongButton.Images.SetKeyName(0, "");
            this.img_LongButton.Images.SetKeyName(1, "");
            // 
            // cmb_StyleCd
            // 
            this.cmb_StyleCd.AddItemSeparator = ';';
            this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_StyleCd.Caption = "";
            this.cmb_StyleCd.CaptionHeight = 17;
            this.cmb_StyleCd.CaptionStyle = style1;
            this.cmb_StyleCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_StyleCd.ColumnCaptionHeight = 18;
            this.cmb_StyleCd.ColumnFooterHeight = 18;
            this.cmb_StyleCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_StyleCd.ContentHeight = 17;
            this.cmb_StyleCd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_StyleCd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_StyleCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_StyleCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_StyleCd.EditorHeight = 17;
            this.cmb_StyleCd.EvenRowStyle = style2;
            this.cmb_StyleCd.FooterStyle = style3;
            this.cmb_StyleCd.HeadingStyle = style4;
            this.cmb_StyleCd.HighLightRowStyle = style5;
            this.cmb_StyleCd.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_StyleCd.Images"))));
            this.cmb_StyleCd.ItemHeight = 15;
            this.cmb_StyleCd.Location = new System.Drawing.Point(513, 62);
            this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
            this.cmb_StyleCd.MaxLength = 32767;
            this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_StyleCd.Name = "cmb_StyleCd";
            this.cmb_StyleCd.OddRowStyle = style6;
            this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.SelectedStyle = style7;
            this.cmb_StyleCd.Size = new System.Drawing.Size(134, 21);
            this.cmb_StyleCd.Style = style8;
            this.cmb_StyleCd.TabIndex = 549;
            this.cmb_StyleCd.SelectedValueChanged += new System.EventHandler(this.cmb_StyleCd_SelectedValueChanged);
            this.cmb_StyleCd.PropBag = resources.GetString("cmb_StyleCd.PropBag");
            // 
            // txt_StyleCd
            // 
            this.txt_StyleCd.BackColor = System.Drawing.Color.White;
            this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_StyleCd.Location = new System.Drawing.Point(437, 62);
            this.txt_StyleCd.MaxLength = 10;
            this.txt_StyleCd.Name = "txt_StyleCd";
            this.txt_StyleCd.Size = new System.Drawing.Size(75, 21);
            this.txt_StyleCd.TabIndex = 550;
            this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
            // 
            // lbl_Style
            // 
            this.lbl_Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Style.ImageIndex = 0;
            this.lbl_Style.ImageList = this.img_Label;
            this.lbl_Style.Location = new System.Drawing.Point(336, 62);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style.TabIndex = 546;
            this.lbl_Style.Text = "Style";
            this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_OBSId
            // 
            this.cmb_OBSId.AddItemSeparator = ';';
            this.cmb_OBSId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OBSId.Caption = "";
            this.cmb_OBSId.CaptionHeight = 17;
            this.cmb_OBSId.CaptionStyle = style9;
            this.cmb_OBSId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OBSId.ColumnCaptionHeight = 18;
            this.cmb_OBSId.ColumnFooterHeight = 18;
            this.cmb_OBSId.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OBSId.ContentHeight = 17;
            this.cmb_OBSId.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OBSId.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OBSId.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_OBSId.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OBSId.EditorHeight = 17;
            this.cmb_OBSId.EvenRowStyle = style10;
            this.cmb_OBSId.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OBSId.FooterStyle = style11;
            this.cmb_OBSId.HeadingStyle = style12;
            this.cmb_OBSId.HighLightRowStyle = style13;
            this.cmb_OBSId.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_OBSId.Images"))));
            this.cmb_OBSId.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_OBSId.ItemHeight = 15;
            this.cmb_OBSId.Location = new System.Drawing.Point(109, 62);
            this.cmb_OBSId.MatchEntryTimeout = ((long)(2000));
            this.cmb_OBSId.MaxDropDownItems = ((short)(5));
            this.cmb_OBSId.MaxLength = 32767;
            this.cmb_OBSId.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OBSId.Name = "cmb_OBSId";
            this.cmb_OBSId.OddRowStyle = style14;
            this.cmb_OBSId.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OBSId.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OBSId.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OBSId.SelectedStyle = style15;
            this.cmb_OBSId.Size = new System.Drawing.Size(210, 21);
            this.cmb_OBSId.Style = style16;
            this.cmb_OBSId.TabIndex = 543;
            this.cmb_OBSId.SelectedValueChanged += new System.EventHandler(this.cmb_OBSId_SelectedValueChanged);
            this.cmb_OBSId.PropBag = resources.GetString("cmb_OBSId.PropBag");
            // 
            // lbl_OBSId
            // 
            this.lbl_OBSId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OBSId.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OBSId.ImageIndex = 0;
            this.lbl_OBSId.ImageList = this.img_Label;
            this.lbl_OBSId.Location = new System.Drawing.Point(8, 62);
            this.lbl_OBSId.Name = "lbl_OBSId";
            this.lbl_OBSId.Size = new System.Drawing.Size(100, 21);
            this.lbl_OBSId.TabIndex = 544;
            this.lbl_OBSId.Text = "DPO";
            this.lbl_OBSId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style17;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 17;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 17;
            this.cmb_Factory.EvenRowStyle = style18;
            this.cmb_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style19;
            this.cmb_Factory.HeadingStyle = style20;
            this.cmb_Factory.HighLightRowStyle = style21;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style22;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style23;
            this.cmb_Factory.Size = new System.Drawing.Size(210, 21);
            this.cmb_Factory.Style = style24;
            this.cmb_Factory.TabIndex = 1;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // cmb_OBSType
            // 
            this.cmb_OBSType.AddItemSeparator = ';';
            this.cmb_OBSType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OBSType.Caption = "";
            this.cmb_OBSType.CaptionHeight = 17;
            this.cmb_OBSType.CaptionStyle = style25;
            this.cmb_OBSType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OBSType.ColumnCaptionHeight = 18;
            this.cmb_OBSType.ColumnFooterHeight = 18;
            this.cmb_OBSType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OBSType.ContentHeight = 17;
            this.cmb_OBSType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OBSType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OBSType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_OBSType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OBSType.EditorHeight = 17;
            this.cmb_OBSType.EvenRowStyle = style26;
            this.cmb_OBSType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OBSType.FooterStyle = style27;
            this.cmb_OBSType.HeadingStyle = style28;
            this.cmb_OBSType.HighLightRowStyle = style29;
            this.cmb_OBSType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_OBSType.Images"))));
            this.cmb_OBSType.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_OBSType.ItemHeight = 15;
            this.cmb_OBSType.Location = new System.Drawing.Point(437, 40);
            this.cmb_OBSType.MatchEntryTimeout = ((long)(2000));
            this.cmb_OBSType.MaxDropDownItems = ((short)(5));
            this.cmb_OBSType.MaxLength = 32767;
            this.cmb_OBSType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OBSType.Name = "cmb_OBSType";
            this.cmb_OBSType.OddRowStyle = style30;
            this.cmb_OBSType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OBSType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OBSType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OBSType.SelectedStyle = style31;
            this.cmb_OBSType.Size = new System.Drawing.Size(210, 21);
            this.cmb_OBSType.Style = style32;
            this.cmb_OBSType.TabIndex = 537;
            this.cmb_OBSType.SelectedValueChanged += new System.EventHandler(this.cmb_OBSType_SelectedValueChanged);
            this.cmb_OBSType.PropBag = resources.GetString("cmb_OBSType.PropBag");
            // 
            // lbl_OBSType
            // 
            this.lbl_OBSType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OBSType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OBSType.ImageIndex = 0;
            this.lbl_OBSType.ImageList = this.img_Label;
            this.lbl_OBSType.Location = new System.Drawing.Point(336, 40);
            this.lbl_OBSType.Name = "lbl_OBSType";
            this.lbl_OBSType.Size = new System.Drawing.Size(100, 21);
            this.lbl_OBSType.TabIndex = 538;
            this.lbl_OBSType.Text = "OBS Type";
            this.lbl_OBSType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label2.TabIndex = 393;
            this.label2.Text = "      Order Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 75);
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
            this.pic_head4.Size = new System.Drawing.Size(960, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Factory.ImageIndex = 0;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(8, 40);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 50;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(899, 30);
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
            this.pic_head5.Location = new System.Drawing.Point(0, 75);
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
            this.pic_head6.Location = new System.Drawing.Point(0, 0);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 73);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(160, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(920, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // spd_main
            // 
            this.spd_main.BackColor = System.Drawing.Color.Transparent;
            this.spd_main.ContextMenu = this.cmenu_Grid;
            this.spd_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spd_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.spd_main.Location = new System.Drawing.Point(8, 95);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.sheetView1);
            this.spd_main.Size = new System.Drawing.Size(1000, 406);
            this.spd_main.TabIndex = 174;
            // 
            // cmenu_Grid
            // 
            this.cmenu_Grid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_DisplaySize,
            this.menuItem_StyleLifeCycle});
            // 
            // menuItem_DisplaySize
            // 
            this.menuItem_DisplaySize.Index = 0;
            this.menuItem_DisplaySize.Text = "Display Size Information";
            this.menuItem_DisplaySize.Click += new System.EventHandler(this.menuItem_DisplaySize_Click);
            // 
            // menuItem_StyleLifeCycle
            // 
            this.menuItem_StyleLifeCycle.Index = 1;
            this.menuItem_StyleLifeCycle.Text = "Style Life Cycle";
            this.menuItem_StyleLifeCycle.Click += new System.EventHandler(this.menuItem_StyleLifeCycle_Click);
            // 
            // sheetView1
            // 
            this.sheetView1.SheetName = "Sheet1";
            // 
            // Form_BW_Order_Analysis
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BW_Order_Analysis";
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_low.ResumeLayout(false);
            this.gb_Result.ResumeLayout(false);
            this.gb_Result.PerformLayout();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OBSId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OBSType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetView1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion 

		#region 툴바 메뉴 이벤트 처리
		
		 
 
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			try
			{ 
				Clear(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				Search();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}


		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				Print();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Print_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		#endregion

		#region 컨트롤 이벤트 처리

		   
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		

			try
			{

				if(cmb_Factory.SelectedIndex == -1) return;

				DataTable dt_ret; 
				 
				// dpo set
				// division = 1 : dp, division = 2 : dpo
				dt_ret = ClassLib.ComVar.Select_DP_DPO_List(cmb_Factory.SelectedValue.ToString(), "2");
				COM.ComCtl.Set_ComboList(dt_ret, cmb_OBSId, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 

				// obs type set
				dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxOBSType);
				COM.ComCtl.Set_ComboList(dt_ret, cmb_OBSType, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 


				dt_ret.Dispose(); 
 


				spd_main.ClearAll();
				txt_Result.Text = "";



			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}	

		}
 


		private void cmb_OBSId_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				spd_main.ClearAll();
				txt_Result.Text = "";

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_OBSId_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void cmb_OBSType_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				spd_main.ClearAll();
				txt_Result.Text = "";

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_OBSType_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		 


		private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return; 
				Set_StyleCode(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void cmb_StyleCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return; 

				txt_StyleCd.Text = cmb_StyleCd.SelectedValue.ToString();   

				spd_main.ClearAll();
				txt_Result.Text = "";


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_StyleCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void menuItem_DisplaySize_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Display_Size();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_DisplaySize_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		private void menuItem_StyleLifeCycle_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Display_Style_Life_Cycle();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_StyleLifeCycle_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
 
 

		
		#region 버튼클릭시 이미지변경
 

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
			
		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 

		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
		}

		
 

		#endregion 

		private void btn_GACScore_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Display_GAC_Score_Process();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_GACScore_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		#endregion 

		#region 이벤트 처리 메서드

		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form set
			this.Text = "Order Life Cycle (1)";
            lbl_MainTitle.Text = "Order Life Cycle (1)";
            ClassLib.ComFunction.SetLangDic(this);

			// grid set
			spd_main.Set_Spread_Comm("SBW_ORDER_SEARCH", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 

			// Farpoint Spread Header Merge
			Mearge_GridHead();

			//combobox setting
			Init_Control(); 

			

		}


		/// <summary>
		/// Mearge_GridHead : Farpoint Spread Header Merge
		/// </summary>
		private void Mearge_GridHead()
		{
			
			try
			{

				for (int vCol = 0 ; vCol < spd_main.ActiveSheet.ColumnCount ; vCol++)
				{
					
					if (spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim().Equals(spd_main.ActiveSheet.ColumnHeader.Cells[2, vCol].Text.ToString().Trim()))
					{
						spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].RowSpan = 2;
					}
					else
					{
						int vCnt  = 0;
						
						for ( int j = vCol ; j <= spd_main.ActiveSheet.ColumnCount ; j++)
						{
							if(j == spd_main.ActiveSheet.ColumnCount)
							{
								spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
								vCol = j + 1;
								break;
							}
							else
							{
								if( vCnt > 0 &&  spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() != spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )
								{
									spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
									break;
								}
								else if ( spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() == spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )	
								{
									vCnt++;
								}
							} // end if(j == spd_main.ActiveSheet.ColumnCount - 1)

						}

						vCol = vCol + vCnt-1;
					}
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Mearge_GridHead", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

 

		/// <summary>
		/// Init_Control : combobox setting
		/// </summary>
		private void Init_Control()
		{
			DataTable dt_ret;


			// toolbar button disable setting
			tbtn_Delete.Enabled = false; 
			tbtn_Confirm.Enabled = false; 
			tbtn_Save.Enabled = false; 


			// factory set  
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
		  

			dt_ret.Dispose();  

		}




		/// <summary>
		/// Set_StyleCode : 스타일 콤보 세팅
		/// </summary>
		private void Set_StyleCode()
		{

			//if(e.KeyCode != Keys.Enter) return; 

			//-------------------------------------------------------------------------
			// 기타 콘트롤 초기화 
			cmb_StyleCd.SelectedIndex = -1;  
			//-------------------------------------------------------------------------

			DataTable dt_ret;
			
			if(txt_StyleCd.Text.Trim().Equals("") ) 
			{
				cmb_StyleCd.SelectedIndex = -1;
				cmb_StyleCd.DataSource = null;
				return;
			}

			dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ") ); 
				 
			//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
			ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_StyleCd, 0, 1, 2, 3, 4, false, 80, 200); 

			string stylecd = "";
			int exist_index = -1;

			stylecd = txt_StyleCd.Text.Trim();

			exist_index = txt_StyleCd.Text.IndexOf("-", 0);

			if(exist_index == -1 && stylecd.Length == 9)
			{
				stylecd = stylecd.Substring(0, 6) + "-" + stylecd.Substring(6, 3);
			}
 
			cmb_StyleCd.SelectedValue = stylecd;

			dt_ret.Dispose();

		}

		 
	
	
		/// <summary>
		/// Display_Size : 상세 사이즈 정보
		/// </summary>
		private void Display_Size()
		{
 
			if(spd_main.ActiveSheet.RowCount == 0) return; 

			int sel_row = spd_main.ActiveSheet.ActiveRowIndex; 
			string factory = spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH.IxFACTORY].Value.ToString();
			string style_cd = spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH.IxSTYLE_CD].Value.ToString().Replace("-", "");
			string lot_no = spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH.IxLOT_NO].Value.ToString();
			string lot_seq = spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH.IxLOT_SEQ].Value.ToString(); 

			Pop_BW_Order_Analysis_Size pop_form = new Pop_BW_Order_Analysis_Size(factory, style_cd, lot_no, lot_seq);
			pop_form.ShowDialog(); 


		}



		/// <summary>
		/// Display_Style_Life_Cycle : 
		/// </summary>
		private void Display_Style_Life_Cycle()
		{

			if(spd_main.ActiveSheet.RowCount == 0) return; 

			int sel_row = spd_main.ActiveSheet.ActiveRowIndex; 
			string factory = spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH.IxFACTORY].Value.ToString();
			string style_cd = spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH.IxSTYLE_CD].Value.ToString().Replace("-", "");
			string obs_id = spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH.IxOBS_ID].Value.ToString();
			string obs_type = spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH.IxOBS_TYPE].Value.ToString(); 

			Form_BW_Style_LifeCycle pop_form = new Form_BW_Style_LifeCycle(factory, style_cd, obs_id, obs_type);
			pop_form.ShowDialog(); 


		}


		/// <summary>
		/// Display_GAC_Score_Process : 
		/// </summary>
		private void Display_GAC_Score_Process()
		{

			C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_OBSId, cmb_OBSType}; 
			bool essential_check = essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
			if(! essential_check) return;
  
			string factory = cmb_Factory.SelectedValue.ToString();
			string obs_id = cmb_OBSId.SelectedValue.ToString();
			string obs_type = cmb_OBSType.SelectedValue.ToString();



			Pop_BW_Order_Analysis_GAC_Score_New pop_form = new Pop_BW_Order_Analysis_GAC_Score_New(factory, obs_type, obs_id);
			pop_form.ShowDialog(); 


		}



		#endregion

		#region 툴바 메뉴 이벤트 처리 메서드
		
		/// <summary>
		/// Clear : 화면 초기화
		/// </summary>
		private void Clear()
		{
			
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory; 
			cmb_OBSId.SelectedIndex = -1;
			cmb_OBSType.SelectedIndex = -1; 
		
			txt_StyleCd.Text = "";
			cmb_StyleCd.SelectedIndex = -1; 

			spd_main.ClearAll();
			txt_Result.Text = "";

		}



		/// <summary>
		/// Search : 조회
		/// </summary>
		private void Search()
		{ 

			C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_OBSId, cmb_OBSType}; 
			bool essential_check = essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
			if(! essential_check) return;


			string factory = cmb_Factory.SelectedValue.ToString();
			string obs_id = cmb_OBSId.SelectedValue.ToString();
			string obs_type = cmb_OBSType.SelectedValue.ToString();
			string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", ""); 
			
			
			string[] parameter = new string[] {factory, obs_id, obs_type, style_cd};

			DataTable dt_ret = SELECT_MNT_ORDER_MPS(parameter);  


			 			  
			
			if(dt_ret == null || dt_ret.Rows.Count == 0) 
			{
				spd_main.ClearAll(); 
				txt_Result.Text = "";
			}
			else
			{ 

				spd_main.Display_Grid(dt_ret);    
 

				// column merge 
				ClassLib.ComFunction.MergeCell(spd_main, new int[]{ (int)ClassLib.TBSBW_ORDER_SEARCH.IxMOD_CD,
																	  (int)ClassLib.TBSBW_ORDER_SEARCH.IxSTYLE_CD,
																	  (int)ClassLib.TBSBW_ORDER_SEARCH.IxGEN,
																	  (int)ClassLib.TBSBW_ORDER_SEARCH.IxPST_YN,
																	  (int)ClassLib.TBSBW_ORDER_SEARCH.IxPO_NO,
																	  (int)ClassLib.TBSBW_ORDER_SEARCH.IxCLOSE_YN,
																	  (int)ClassLib.TBSBW_ORDER_SEARCH.IxLOT_NO,
																	  (int)ClassLib.TBSBW_ORDER_SEARCH.IxLOT_SEQ,
																	  (int)ClassLib.TBSBW_ORDER_SEARCH.IxLOT_QTY,
																	  (int)ClassLib.TBSBW_ORDER_SEARCH.IxLINE_QTY } );
				   


				// LOT 총 수량 표시
				string now_factory = "";
				string now_lot_no = "";
				string now_lot_seq = ""; 


				int total_count = spd_main.ActiveSheet.RowCount;

				int prod_qty = 0;
				int total_qty = 0; 
				int current_count = 0;


				for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
				{ 

 
					// prod_qty != total_qty 수 result 표시 -----------------------------------------------------------------


					// LOT 총 수량 표시 -------------------------------------------------------------------------------------
					now_factory = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxFACTORY].Value.ToString();
					now_lot_no = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxLOT_NO].Value.ToString();
					now_lot_seq = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxLOT_SEQ].Value.ToString();

					if(now_lot_no.Trim().Equals("") && now_lot_seq.Trim().Equals("") ) continue;

					dt_ret = SELECT_MNT_LINE_QTY(now_factory, now_lot_no, now_lot_seq);

					if(dt_ret == null || dt_ret.Rows.Count == 0) continue;

					spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxLINE_QTY].Value 
						= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBW_ORDER_SEARCH_LINE.IxLINE_QTY - 1].ToString();
					// LOT 총 수량 표시 -------------------------------------------------------------------------------------

				}
				  

			 

				for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
				{ 


//					// balance1, balance2 +-5 이상이면 표시 -----------------------------------------------------------------
//					if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxBALANCE1].Value == null
//						|| spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxBALANCE1].Value.ToString() == "")
//					{
//						balance1 = 0;
//					}
//					else
//					{
//						balance1 = Convert.ToInt32(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxBALANCE1].Value.ToString() ); 
//					}
//
//					if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxBALANCE2].Value == null
//						|| spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxBALANCE2].Value.ToString() == "")
//					{
//						balance2 = 0;
//					}
//					else
//					{
//						balance2 = Convert.ToInt32(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxBALANCE2].Value.ToString() );
//					}
//						  
//
//					if(balance1 < -5 || balance1 > 5)
//					{
//						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxDEST2, i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxDAY_07].BackColor = ClassLib.ComVar.ClrSel_Yellow;
//					}
//
//					if(balance2 < -5 || balance2 > 5)
//					{
//						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxDEST2, i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxDAY_07].BackColor = ClassLib.ComVar.ClrSel_Yellow;
//					}
//
//					// balance1, balance2 +-5 이상이면 표시 -----------------------------------------------------------------


					// prod_qty != total_qty 수 result 표시 ----------------------------------------------------------------- 
					if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxPRD_QTY].Value == null
						|| spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxPRD_QTY].Value.ToString() == "")
					{
						prod_qty = 0;
					}
					else
					{
						prod_qty = Convert.ToInt32(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxPRD_QTY].Value.ToString() ); 
					}

					if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxORDER_QTY].Value == null
						|| spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxORDER_QTY].Value.ToString() == "")
					{
						total_qty = 0;
					}
					else
					{
						total_qty = Convert.ToInt32(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxORDER_QTY].Value.ToString() );
					}

					if(prod_qty != total_qty)
					{
						current_count++;

						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxPRD_QTY].BackColor = ClassLib.ComVar.ClrWarning_Back;
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH.IxORDER_QTY].BackColor = ClassLib.ComVar.ClrWarning_Back;


					}
 

				} // end for i 


				txt_Result.Text = "Total : " + total_count.ToString() + "\r\n"; 
				txt_Result.Text += "Production Quantity ≠ Total Quantity: " + current_count.ToString() + " (" + Convert.ToString( Math.Round(Convert.ToDouble(current_count) / total_count * 100, 0) ) + "%)"; 


			} // end if rowcount == 0
 

		}
 
	

		/// <summary>
		/// Print : 프린트
		/// </summary>
		private void Print()
		{


//			C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_SearchOption, cmb_From, cmb_To, cmb_LocalDivision};   
//			bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
//			if(! essential_check) return; 
//
//			string factory = cmb_Factory.SelectedValue.ToString();
//			string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "");
//			string from = cmb_From.SelectedValue.ToString();
//			string to = cmb_To.SelectedValue.ToString();
//			string import = ClassLib.ComFunction.Empty_Combo(cmb_LocalDivision, " ");  
//
//
//
//			Pop_BM_Print_Type vPop = new Pop_BM_Print_Type(ClassLib.ComVar.CxPurchaseTracking_PrintType);
//
//			string sPara = "";
//
//			sPara  = " /rp ";
//			sPara += "'" + factory  + "' ";
//			sPara += "'" + style_cd + "' ";
//			sPara += "'" + from     + "' ";
//			sPara += "'" + to		+ "' ";
//			sPara += "'" + import   + "' ";  
//
//
//
//			string sDir = "";
//			string report_text = ""; 
//
//			sDir = Application.StartupPath + @"\Report\MRP\Form_BW_Order_Analysis_DP.mrd";
//			report_text = "Local/LLT Monitoring By Style (DP)"; 
//
//			FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
//			MyReport.Text = report_text;
//			MyReport.Show();

			 


			  

		}



		#endregion  

		#region 체크박스

		private void chk_OA_CheckedChanged(object sender, System.EventArgs e)
		{
			
			for ( int i = (int)ClassLib.TBSBW_ORDER_SEARCH.IxOA_NU ; i <= (int)ClassLib.TBSBW_ORDER_SEARCH.IxPLAN_OAAPP_YMD; i++)
			{
				spd_main.ActiveSheet.ColumnHeader.Columns[i].Visible = chk_OA.Checked;
			}

		}

		private void chk_Order_CheckedChanged(object sender, System.EventArgs e)
		{
		
			for ( int i = (int)ClassLib.TBSBW_ORDER_SEARCH.IxORD_QTY ; i <= (int)ClassLib.TBSBW_ORDER_SEARCH.IxLOSS_QTY; i++)
			{
				spd_main.ActiveSheet.ColumnHeader.Columns[i].Visible = chk_Order.Checked;
			}

		}

		private void chk_MPS_CheckedChanged(object sender, System.EventArgs e)
		{
			for ( int i = (int)ClassLib.TBSBW_ORDER_SEARCH.IxPO_NO ; i <= (int)ClassLib.TBSBW_ORDER_SEARCH.IxLINE_QTY; i++)
			{
				spd_main.ActiveSheet.ColumnHeader.Columns[i].Visible = chk_MPS.Checked;
			}
		}

		private void chk_GAC_CheckedChanged(object sender, System.EventArgs e)
		{
			for ( int i = (int)ClassLib.TBSBW_ORDER_SEARCH.IxCGAC; i <= (int)ClassLib.TBSBW_ORDER_SEARCH.IxOGAC_MARGIN_TOTAL_RATE; i++)
			{
				spd_main.ActiveSheet.ColumnHeader.Columns[i].Visible = chk_GAC.Checked;
			}
		}


		#endregion
		
		#endregion

		#region DB Connect

	

		/// <summary>
		/// SELECT_MNT_ORDER_MPS : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		private DataTable SELECT_MNT_ORDER_MPS(string[] arg_parameter)
		{

			try 
			{

				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(5);   

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBW_MONITORING.SELECT_MNT_ORDER_MPS";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";  

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_parameter[2]; 
				MyOraDB.Parameter_Values[3] = arg_parameter[3];
				MyOraDB.Parameter_Values[4] = "";  

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();


				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_MNT_ORDER_MPS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}


		}


		/// <summary>
		/// SELECT_MNT_LINE_QTY : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		private DataTable SELECT_MNT_LINE_QTY(string arg_factory, string arg_lot_no, string arg_lot_seq)
		{

			try 
			{


				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(4);   

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBW_MONITORING.SELECT_MNT_LINE_QTY";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR"; 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_lot_no;
				MyOraDB.Parameter_Values[2] = arg_lot_seq; 
				MyOraDB.Parameter_Values[3] = "";  

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_MNT_LINE_QTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}


		}



		


 
		#endregion	 





		 


	}
}

