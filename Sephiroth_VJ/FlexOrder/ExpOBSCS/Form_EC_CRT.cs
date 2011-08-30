using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;

namespace FlexOrder.ExpOBSCS
{
	public class Form_EC_CRT : COM.OrderWinForm.Form_Top
	{
		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel pnl_main;
		private System.Windows.Forms.Panel pnl_1;
		private System.Windows.Forms.GroupBox gb_CS_N;
		public COM.FSP fgrid_CS_N;
		private System.Windows.Forms.GroupBox gb_CS_Y;
		public COM.FSP fgrid_CS_Y;
		private System.Windows.Forms.Splitter splitter2;
		public System.Windows.Forms.Panel pnl_search_main;
		private System.Windows.Forms.Panel pnl_2;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.Panel pnl_save_image;
		private System.Windows.Forms.Label lbl_BP_NO;
		private System.Windows.Forms.Label lbl_OBS_ID;
		private System.Windows.Forms.Panel pnl_Search1_Image;
		private System.Windows.Forms.GroupBox gb_option;
		private System.Windows.Forms.Label lbl_Factory;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.Panel pnl_search_detail;
		public System.Windows.Forms.Panel pnl_save_main;
		public System.Windows.Forms.Panel pnl_save_detail;
		private System.Windows.Forms.Splitter splitter3;
		public COM.FSP fgrid_size;
		private System.Windows.Forms.Label lbl_OBS_Type;
		private System.Windows.Forms.Label lbl_Region;
		private C1.Win.C1List.C1Combo cmb_Del_Month;
		private C1.Win.C1List.C1Combo cmb_OBS_Type;
		private System.Windows.Forms.Label lbl_TOT_Qty;
		private System.Windows.Forms.CheckBox chk_Del_Month;
		private System.Windows.Forms.CheckBox chk_Region;
		private System.Windows.Forms.CheckBox chk_BP_NO;
		private System.Windows.Forms.ImageList img_ShortButton;
		private System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.Label lbl_exp;
		private System.Windows.Forms.TextBox txt_OBS_ID1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txt_TOT_Qty_1;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.TextBox txt_Style_nm;
		private System.Windows.Forms.TextBox txt_Style_cd;
		private System.Windows.Forms.TextBox txt_Pst_yn;
		private System.Windows.Forms.TextBox txt_Gen;
		private System.Windows.Forms.TextBox txt_OBS_ID2;
		private System.Windows.Forms.TextBox txt_BP_NO1;
		private System.Windows.Forms.TextBox txt_OBS_ID;
		private System.Windows.Forms.TextBox txt_Region_nm1;
		private System.Windows.Forms.TextBox txt_Region1;
		private System.Windows.Forms.TextBox txt_BP_NO;
		private System.Windows.Forms.TextBox txt_Region_nm;
		private System.Windows.Forms.TextBox txt_Region;
		private System.Windows.Forms.TextBox txt_Job_Div;
		private System.Windows.Forms.DateTimePicker dpick_RST_YMD;
		private System.Windows.Forms.DateTimePicker dpick_CSET_YMD;
		private System.Windows.Forms.TextBox txt_CSET_RSN;
		private System.Windows.Forms.TextBox txt_OBS_NU;
		private System.Windows.Forms.TextBox txt_CHG_NU;
		private System.Windows.Forms.TextBox txt_OBS_SEQ_NU;
		private System.Windows.Forms.TextBox txt_Fact_nm;
		private System.Windows.Forms.TextBox txt_OBS_Type_nm;
		private System.Windows.Forms.TextBox txt_OBS_Type;
		private System.Windows.Forms.TextBox txt_TOT_Qty;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.TextBox txt_Style;
		private System.Windows.Forms.Label lbl_Del_Month;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem ctm_Request;
		private System.Windows.Forms.MenuItem ctm_OBS_Sel;
		private System.Windows.Forms.MenuItem ctm_OBS_HistSel;
		private System.Windows.Forms.Label lbl_RGAC;
		private System.Windows.Forms.DateTimePicker dpick_OGAC_YMD;
		private System.Windows.Forms.Label lbl_Ogac;
		private System.Windows.Forms.MenuItem ctm_GSSC_Information;
		private System.Windows.Forms.MenuItem ctm_Bar_First;
		private System.Windows.Forms.TextBox txt_Dest_nm;
		private System.Windows.Forms.TextBox txt_Dest;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_Year;
		private System.Windows.Forms.Label lbl_Season;
		private C1.Win.C1List.C1Combo cmb_Year;
		private C1.Win.C1List.C1Combo cmb_Season;
		private System.ComponentModel.IContainer components = null;

		public Form_EC_CRT()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EC_CRT));
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pnl_main = new System.Windows.Forms.Panel();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.pnl_2 = new System.Windows.Forms.Panel();
			this.pnl_save_detail = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_Dest_nm = new System.Windows.Forms.TextBox();
			this.txt_Dest = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_OBS_SEQ_NU = new System.Windows.Forms.TextBox();
			this.txt_CHG_NU = new System.Windows.Forms.TextBox();
			this.txt_OBS_NU = new System.Windows.Forms.TextBox();
			this.txt_CSET_RSN = new System.Windows.Forms.TextBox();
			this.dpick_CSET_YMD = new System.Windows.Forms.DateTimePicker();
			this.dpick_RST_YMD = new System.Windows.Forms.DateTimePicker();
			this.txt_Job_Div = new System.Windows.Forms.TextBox();
			this.txt_Region_nm = new System.Windows.Forms.TextBox();
			this.txt_Region = new System.Windows.Forms.TextBox();
			this.txt_BP_NO = new System.Windows.Forms.TextBox();
			this.txt_OBS_ID = new System.Windows.Forms.TextBox();
			this.txt_OBS_Type_nm = new System.Windows.Forms.TextBox();
			this.txt_OBS_Type = new System.Windows.Forms.TextBox();
			this.txt_TOT_Qty = new System.Windows.Forms.TextBox();
			this.txt_Pst_yn = new System.Windows.Forms.TextBox();
			this.txt_Gen = new System.Windows.Forms.TextBox();
			this.txt_Style_nm = new System.Windows.Forms.TextBox();
			this.txt_Style_cd = new System.Windows.Forms.TextBox();
			this.txt_Fact_nm = new System.Windows.Forms.TextBox();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_RGAC = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_Ogac = new System.Windows.Forms.Label();
			this.dpick_OGAC_YMD = new System.Windows.Forms.DateTimePicker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.fgrid_size = new COM.FSP();
			this.pnl_save_main = new System.Windows.Forms.Panel();
			this.pnl_save_image = new System.Windows.Forms.Panel();
			this.lbl_exp = new System.Windows.Forms.Label();
			this.txt_Region_nm1 = new System.Windows.Forms.TextBox();
			this.btn_Apply = new System.Windows.Forms.Label();
			this.img_ShortButton = new System.Windows.Forms.ImageList(this.components);
			this.txt_TOT_Qty_1 = new System.Windows.Forms.TextBox();
			this.lbl_TOT_Qty = new System.Windows.Forms.Label();
			this.txt_Region1 = new System.Windows.Forms.TextBox();
			this.txt_BP_NO1 = new System.Windows.Forms.TextBox();
			this.txt_OBS_ID2 = new System.Windows.Forms.TextBox();
			this.lbl_Region = new System.Windows.Forms.Label();
			this.lbl_BP_NO = new System.Windows.Forms.Label();
			this.lbl_OBS_ID = new System.Windows.Forms.Label();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.pnl_1 = new System.Windows.Forms.Panel();
			this.pnl_search_detail = new System.Windows.Forms.Panel();
			this.splitter3 = new System.Windows.Forms.Splitter();
			this.gb_CS_N = new System.Windows.Forms.GroupBox();
			this.fgrid_CS_N = new COM.FSP();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.ctm_Request = new System.Windows.Forms.MenuItem();
			this.ctm_GSSC_Information = new System.Windows.Forms.MenuItem();
			this.ctm_Bar_First = new System.Windows.Forms.MenuItem();
			this.ctm_OBS_Sel = new System.Windows.Forms.MenuItem();
			this.ctm_OBS_HistSel = new System.Windows.Forms.MenuItem();
			this.gb_CS_Y = new System.Windows.Forms.GroupBox();
			this.fgrid_CS_Y = new COM.FSP();
			this.pnl_search_main = new System.Windows.Forms.Panel();
			this.pnl_Search1_Image = new System.Windows.Forms.Panel();
			this.txt_Style = new System.Windows.Forms.TextBox();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.txt_OBS_ID1 = new System.Windows.Forms.TextBox();
			this.gb_option = new System.Windows.Forms.GroupBox();
			this.chk_Del_Month = new System.Windows.Forms.CheckBox();
			this.chk_Region = new System.Windows.Forms.CheckBox();
			this.chk_BP_NO = new System.Windows.Forms.CheckBox();
			this.cmb_Del_Month = new C1.Win.C1List.C1Combo();
			this.cmb_OBS_Type = new C1.Win.C1List.C1Combo();
			this.lbl_Del_Month = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_OBS_Type = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.lbl_Year = new System.Windows.Forms.Label();
			this.lbl_Season = new System.Windows.Forms.Label();
			this.cmb_Year = new C1.Win.C1List.C1Combo();
			this.cmb_Season = new C1.Win.C1List.C1Combo();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_main.SuspendLayout();
			this.pnl_2.SuspendLayout();
			this.pnl_save_detail.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_size)).BeginInit();
			this.pnl_save_main.SuspendLayout();
			this.pnl_save_image.SuspendLayout();
			this.pnl_1.SuspendLayout();
			this.pnl_search_detail.SuspendLayout();
			this.gb_CS_N.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_CS_N)).BeginInit();
			this.gb_CS_Y.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_CS_Y)).BeginInit();
			this.pnl_search_main.SuspendLayout();
			this.pnl_Search1_Image.SuspendLayout();
			this.gb_option.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Del_Month)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Year)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Menu
			// 
			this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.Location = new System.Drawing.Point(736, 3);
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.UIStrings.Content = new string[0];
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
			this.stbar.Location = new System.Drawing.Point(0, 632);
			this.stbar.Name = "stbar";
			this.stbar.Size = new System.Drawing.Size(1024, 22);
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.TabIndex = 0;
			this.splitter1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.TabIndex = 0;
			// 
			// pnl_main
			// 
			this.pnl_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_main.BackColor = System.Drawing.Color.White;
			this.pnl_main.Controls.Add(this.splitter2);
			this.pnl_main.Controls.Add(this.pnl_2);
			this.pnl_main.Controls.Add(this.pnl_1);
			this.pnl_main.Location = new System.Drawing.Point(0, 64);
			this.pnl_main.Name = "pnl_main";
			this.pnl_main.Size = new System.Drawing.Size(1024, 568);
			this.pnl_main.TabIndex = 44;
			// 
			// splitter2
			// 
			this.splitter2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.splitter2.Location = new System.Drawing.Point(408, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(4, 568);
			this.splitter2.TabIndex = 46;
			this.splitter2.TabStop = false;
			// 
			// pnl_2
			// 
			this.pnl_2.Controls.Add(this.pnl_save_detail);
			this.pnl_2.Controls.Add(this.pnl_save_main);
			this.pnl_2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_2.Location = new System.Drawing.Point(408, 0);
			this.pnl_2.Name = "pnl_2";
			this.pnl_2.Size = new System.Drawing.Size(616, 568);
			this.pnl_2.TabIndex = 45;
			// 
			// pnl_save_detail
			// 
			this.pnl_save_detail.BackColor = System.Drawing.Color.White;
			this.pnl_save_detail.Controls.Add(this.groupBox1);
			this.pnl_save_detail.Controls.Add(this.groupBox2);
			this.pnl_save_detail.DockPadding.Bottom = 8;
			this.pnl_save_detail.DockPadding.Left = 8;
			this.pnl_save_detail.DockPadding.Right = 8;
			this.pnl_save_detail.DockPadding.Top = 1;
			this.pnl_save_detail.Location = new System.Drawing.Point(16, 208);
			this.pnl_save_detail.Name = "pnl_save_detail";
			this.pnl_save_detail.Size = new System.Drawing.Size(600, 360);
			this.pnl_save_detail.TabIndex = 40;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.cmb_Year);
			this.groupBox1.Controls.Add(this.cmb_Season);
			this.groupBox1.Controls.Add(this.lbl_Year);
			this.groupBox1.Controls.Add(this.lbl_Season);
			this.groupBox1.Controls.Add(this.txt_Dest_nm);
			this.groupBox1.Controls.Add(this.txt_Dest);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txt_OBS_SEQ_NU);
			this.groupBox1.Controls.Add(this.txt_CHG_NU);
			this.groupBox1.Controls.Add(this.txt_OBS_NU);
			this.groupBox1.Controls.Add(this.txt_CSET_RSN);
			this.groupBox1.Controls.Add(this.dpick_CSET_YMD);
			this.groupBox1.Controls.Add(this.dpick_RST_YMD);
			this.groupBox1.Controls.Add(this.txt_Job_Div);
			this.groupBox1.Controls.Add(this.txt_Region_nm);
			this.groupBox1.Controls.Add(this.txt_Region);
			this.groupBox1.Controls.Add(this.txt_BP_NO);
			this.groupBox1.Controls.Add(this.txt_OBS_ID);
			this.groupBox1.Controls.Add(this.txt_OBS_Type_nm);
			this.groupBox1.Controls.Add(this.txt_OBS_Type);
			this.groupBox1.Controls.Add(this.txt_TOT_Qty);
			this.groupBox1.Controls.Add(this.txt_Pst_yn);
			this.groupBox1.Controls.Add(this.txt_Gen);
			this.groupBox1.Controls.Add(this.txt_Style_nm);
			this.groupBox1.Controls.Add(this.txt_Style_cd);
			this.groupBox1.Controls.Add(this.txt_Fact_nm);
			this.groupBox1.Controls.Add(this.txt_Factory);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lbl_RGAC);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.lbl_Ogac);
			this.groupBox1.Controls.Add(this.dpick_OGAC_YMD);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(8, 105);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(584, 247);
			this.groupBox1.TabIndex = 134;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "§ Master Info.";
			// 
			// txt_Dest_nm
			// 
			this.txt_Dest_nm.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Dest_nm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Dest_nm.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Dest_nm.Location = new System.Drawing.Point(178, 199);
			this.txt_Dest_nm.MaxLength = 100;
			this.txt_Dest_nm.Name = "txt_Dest_nm";
			this.txt_Dest_nm.ReadOnly = true;
			this.txt_Dest_nm.Size = new System.Drawing.Size(141, 20);
			this.txt_Dest_nm.TabIndex = 169;
			this.txt_Dest_nm.Text = "";
			// 
			// txt_Dest
			// 
			this.txt_Dest.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Dest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Dest.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Dest.Location = new System.Drawing.Point(109, 199);
			this.txt_Dest.MaxLength = 100;
			this.txt_Dest.Name = "txt_Dest";
			this.txt_Dest.ReadOnly = true;
			this.txt_Dest.Size = new System.Drawing.Size(68, 20);
			this.txt_Dest.TabIndex = 168;
			this.txt_Dest.Text = "";
			this.txt_Dest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label2.Font = new System.Drawing.Font("Verdana", 8F);
			this.label2.ImageIndex = 2;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(8, 199);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 167;
			this.label2.Text = "Dest";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_OBS_SEQ_NU
			// 
			this.txt_OBS_SEQ_NU.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OBS_SEQ_NU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_SEQ_NU.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_SEQ_NU.Location = new System.Drawing.Point(437, 62);
			this.txt_OBS_SEQ_NU.MaxLength = 100;
			this.txt_OBS_SEQ_NU.Name = "txt_OBS_SEQ_NU";
			this.txt_OBS_SEQ_NU.ReadOnly = true;
			this.txt_OBS_SEQ_NU.Size = new System.Drawing.Size(140, 20);
			this.txt_OBS_SEQ_NU.TabIndex = 166;
			this.txt_OBS_SEQ_NU.Text = "";
			// 
			// txt_CHG_NU
			// 
			this.txt_CHG_NU.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_CHG_NU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_CHG_NU.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_CHG_NU.Location = new System.Drawing.Point(437, 84);
			this.txt_CHG_NU.MaxLength = 100;
			this.txt_CHG_NU.Name = "txt_CHG_NU";
			this.txt_CHG_NU.ReadOnly = true;
			this.txt_CHG_NU.Size = new System.Drawing.Size(140, 20);
			this.txt_CHG_NU.TabIndex = 165;
			this.txt_CHG_NU.Text = "";
			// 
			// txt_OBS_NU
			// 
			this.txt_OBS_NU.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OBS_NU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_NU.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_NU.Location = new System.Drawing.Point(437, 40);
			this.txt_OBS_NU.MaxLength = 100;
			this.txt_OBS_NU.Name = "txt_OBS_NU";
			this.txt_OBS_NU.ReadOnly = true;
			this.txt_OBS_NU.Size = new System.Drawing.Size(140, 20);
			this.txt_OBS_NU.TabIndex = 164;
			this.txt_OBS_NU.Text = "";
			// 
			// txt_CSET_RSN
			// 
			this.txt_CSET_RSN.BackColor = System.Drawing.Color.White;
			this.txt_CSET_RSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_CSET_RSN.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_CSET_RSN.ForeColor = System.Drawing.Color.Blue;
			this.txt_CSET_RSN.Location = new System.Drawing.Point(437, 221);
			this.txt_CSET_RSN.MaxLength = 30;
			this.txt_CSET_RSN.Name = "txt_CSET_RSN";
			this.txt_CSET_RSN.Size = new System.Drawing.Size(140, 20);
			this.txt_CSET_RSN.TabIndex = 163;
			this.txt_CSET_RSN.Text = "";
			// 
			// dpick_CSET_YMD
			// 
			this.dpick_CSET_YMD.CustomFormat = "yyyy-MM-dd";
			this.dpick_CSET_YMD.Font = new System.Drawing.Font("Verdana", 8F);
			this.dpick_CSET_YMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_CSET_YMD.Location = new System.Drawing.Point(437, 199);
			this.dpick_CSET_YMD.Name = "dpick_CSET_YMD";
			this.dpick_CSET_YMD.Size = new System.Drawing.Size(142, 20);
			this.dpick_CSET_YMD.TabIndex = 162;
			this.dpick_CSET_YMD.ValueChanged += new System.EventHandler(this.dpick_CSET_YMD_ValueChanged);
			// 
			// dpick_RST_YMD
			// 
			this.dpick_RST_YMD.CustomFormat = "yyyy-MM-dd";
			this.dpick_RST_YMD.Font = new System.Drawing.Font("Verdana", 8F);
			this.dpick_RST_YMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_RST_YMD.Location = new System.Drawing.Point(437, 176);
			this.dpick_RST_YMD.Name = "dpick_RST_YMD";
			this.dpick_RST_YMD.Size = new System.Drawing.Size(142, 20);
			this.dpick_RST_YMD.TabIndex = 161;
			this.dpick_RST_YMD.ValueChanged += new System.EventHandler(this.dpick_RST_YMD_ValueChanged);
			// 
			// txt_Job_Div
			// 
			this.txt_Job_Div.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Job_Div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Job_Div.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Job_Div.Location = new System.Drawing.Point(109, 221);
			this.txt_Job_Div.MaxLength = 100;
			this.txt_Job_Div.Name = "txt_Job_Div";
			this.txt_Job_Div.ReadOnly = true;
			this.txt_Job_Div.Size = new System.Drawing.Size(210, 20);
			this.txt_Job_Div.TabIndex = 160;
			this.txt_Job_Div.Text = "";
			// 
			// txt_Region_nm
			// 
			this.txt_Region_nm.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Region_nm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Region_nm.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Region_nm.Location = new System.Drawing.Point(178, 176);
			this.txt_Region_nm.MaxLength = 100;
			this.txt_Region_nm.Name = "txt_Region_nm";
			this.txt_Region_nm.ReadOnly = true;
			this.txt_Region_nm.Size = new System.Drawing.Size(141, 20);
			this.txt_Region_nm.TabIndex = 159;
			this.txt_Region_nm.Text = "";
			// 
			// txt_Region
			// 
			this.txt_Region.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Region.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Region.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Region.Location = new System.Drawing.Point(109, 176);
			this.txt_Region.MaxLength = 100;
			this.txt_Region.Name = "txt_Region";
			this.txt_Region.ReadOnly = true;
			this.txt_Region.Size = new System.Drawing.Size(68, 20);
			this.txt_Region.TabIndex = 158;
			this.txt_Region.Text = "";
			this.txt_Region.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txt_BP_NO
			// 
			this.txt_BP_NO.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_BP_NO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_BP_NO.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_BP_NO.Location = new System.Drawing.Point(109, 155);
			this.txt_BP_NO.MaxLength = 100;
			this.txt_BP_NO.Name = "txt_BP_NO";
			this.txt_BP_NO.ReadOnly = true;
			this.txt_BP_NO.Size = new System.Drawing.Size(210, 20);
			this.txt_BP_NO.TabIndex = 157;
			this.txt_BP_NO.Text = "";
			// 
			// txt_OBS_ID
			// 
			this.txt_OBS_ID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OBS_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_ID.Location = new System.Drawing.Point(109, 133);
			this.txt_OBS_ID.MaxLength = 100;
			this.txt_OBS_ID.Name = "txt_OBS_ID";
			this.txt_OBS_ID.ReadOnly = true;
			this.txt_OBS_ID.Size = new System.Drawing.Size(210, 20);
			this.txt_OBS_ID.TabIndex = 156;
			this.txt_OBS_ID.Text = "";
			// 
			// txt_OBS_Type_nm
			// 
			this.txt_OBS_Type_nm.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OBS_Type_nm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_Type_nm.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_Type_nm.Location = new System.Drawing.Point(178, 111);
			this.txt_OBS_Type_nm.MaxLength = 100;
			this.txt_OBS_Type_nm.Name = "txt_OBS_Type_nm";
			this.txt_OBS_Type_nm.ReadOnly = true;
			this.txt_OBS_Type_nm.Size = new System.Drawing.Size(141, 20);
			this.txt_OBS_Type_nm.TabIndex = 155;
			this.txt_OBS_Type_nm.Text = "";
			// 
			// txt_OBS_Type
			// 
			this.txt_OBS_Type.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OBS_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_Type.Location = new System.Drawing.Point(109, 111);
			this.txt_OBS_Type.MaxLength = 100;
			this.txt_OBS_Type.Name = "txt_OBS_Type";
			this.txt_OBS_Type.ReadOnly = true;
			this.txt_OBS_Type.Size = new System.Drawing.Size(68, 20);
			this.txt_OBS_Type.TabIndex = 154;
			this.txt_OBS_Type.Text = "";
			this.txt_OBS_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txt_TOT_Qty
			// 
			this.txt_TOT_Qty.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_TOT_Qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_TOT_Qty.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_TOT_Qty.Location = new System.Drawing.Point(109, 84);
			this.txt_TOT_Qty.MaxLength = 100;
			this.txt_TOT_Qty.Name = "txt_TOT_Qty";
			this.txt_TOT_Qty.ReadOnly = true;
			this.txt_TOT_Qty.Size = new System.Drawing.Size(210, 20);
			this.txt_TOT_Qty.TabIndex = 153;
			this.txt_TOT_Qty.Text = "";
			this.txt_TOT_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txt_Pst_yn
			// 
			this.txt_Pst_yn.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Pst_yn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Pst_yn.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Pst_yn.Location = new System.Drawing.Point(178, 62);
			this.txt_Pst_yn.MaxLength = 100;
			this.txt_Pst_yn.Name = "txt_Pst_yn";
			this.txt_Pst_yn.ReadOnly = true;
			this.txt_Pst_yn.Size = new System.Drawing.Size(141, 20);
			this.txt_Pst_yn.TabIndex = 152;
			this.txt_Pst_yn.Text = "";
			this.txt_Pst_yn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txt_Gen
			// 
			this.txt_Gen.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Gen.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Gen.Location = new System.Drawing.Point(109, 62);
			this.txt_Gen.MaxLength = 100;
			this.txt_Gen.Name = "txt_Gen";
			this.txt_Gen.ReadOnly = true;
			this.txt_Gen.Size = new System.Drawing.Size(68, 20);
			this.txt_Gen.TabIndex = 151;
			this.txt_Gen.Text = "";
			this.txt_Gen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txt_Style_nm
			// 
			this.txt_Style_nm.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Style_nm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_nm.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Style_nm.Location = new System.Drawing.Point(178, 40);
			this.txt_Style_nm.MaxLength = 100;
			this.txt_Style_nm.Name = "txt_Style_nm";
			this.txt_Style_nm.ReadOnly = true;
			this.txt_Style_nm.Size = new System.Drawing.Size(141, 20);
			this.txt_Style_nm.TabIndex = 150;
			this.txt_Style_nm.Text = "";
			// 
			// txt_Style_cd
			// 
			this.txt_Style_cd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Style_cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_cd.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Style_cd.Location = new System.Drawing.Point(109, 40);
			this.txt_Style_cd.MaxLength = 100;
			this.txt_Style_cd.Name = "txt_Style_cd";
			this.txt_Style_cd.ReadOnly = true;
			this.txt_Style_cd.Size = new System.Drawing.Size(68, 20);
			this.txt_Style_cd.TabIndex = 149;
			this.txt_Style_cd.Text = "";
			this.txt_Style_cd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txt_Fact_nm
			// 
			this.txt_Fact_nm.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Fact_nm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Fact_nm.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Fact_nm.Location = new System.Drawing.Point(178, 16);
			this.txt_Fact_nm.MaxLength = 100;
			this.txt_Fact_nm.Name = "txt_Fact_nm";
			this.txt_Fact_nm.ReadOnly = true;
			this.txt_Fact_nm.Size = new System.Drawing.Size(141, 20);
			this.txt_Fact_nm.TabIndex = 148;
			this.txt_Fact_nm.Text = "";
			// 
			// txt_Factory
			// 
			this.txt_Factory.BackColor = System.Drawing.Color.White;
			this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Factory.Location = new System.Drawing.Point(109, 16);
			this.txt_Factory.MaxLength = 100;
			this.txt_Factory.Name = "txt_Factory";
			this.txt_Factory.ReadOnly = true;
			this.txt_Factory.Size = new System.Drawing.Size(68, 20);
			this.txt_Factory.TabIndex = 147;
			this.txt_Factory.Text = "";
			this.txt_Factory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label17.Font = new System.Drawing.Font("Verdana", 8F);
			this.label17.ImageIndex = 2;
			this.label17.ImageList = this.img_Label;
			this.label17.Location = new System.Drawing.Point(8, 84);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 21);
			this.label17.TabIndex = 143;
			this.label17.Text = "Order Q\'ty";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label14.Font = new System.Drawing.Font("Verdana", 8F);
			this.label14.ImageIndex = 2;
			this.label14.ImageList = this.img_Label;
			this.label14.Location = new System.Drawing.Point(8, 62);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 21);
			this.label14.TabIndex = 142;
			this.label14.Text = "Gender/Presto";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label15.Font = new System.Drawing.Font("Verdana", 8F);
			this.label15.ImageIndex = 2;
			this.label15.ImageList = this.img_Label;
			this.label15.Location = new System.Drawing.Point(8, 40);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 21);
			this.label15.TabIndex = 141;
			this.label15.Text = "Style";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label16.Font = new System.Drawing.Font("Verdana", 8F);
			this.label16.ImageIndex = 2;
			this.label16.ImageList = this.img_Label;
			this.label16.Location = new System.Drawing.Point(8, 16);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(100, 21);
			this.label16.TabIndex = 140;
			this.label16.Text = "Factory";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label12.Font = new System.Drawing.Font("Verdana", 8F);
			this.label12.ImageIndex = 0;
			this.label12.ImageList = this.img_Label;
			this.label12.Location = new System.Drawing.Point(336, 221);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 21);
			this.label12.TabIndex = 138;
			this.label12.Text = "CSet RSN";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label11.Font = new System.Drawing.Font("Verdana", 8F);
			this.label11.ImageIndex = 2;
			this.label11.ImageList = this.img_Label;
			this.label11.Location = new System.Drawing.Point(8, 111);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 21);
			this.label11.TabIndex = 137;
			this.label11.Text = "OBS Type";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label10.Font = new System.Drawing.Font("Verdana", 8F);
			this.label10.ImageIndex = 0;
			this.label10.ImageList = this.img_Label;
			this.label10.Location = new System.Drawing.Point(336, 199);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 21);
			this.label10.TabIndex = 136;
			this.label10.Text = "CSet Date";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label8.Font = new System.Drawing.Font("Verdana", 8F);
			this.label8.ImageIndex = 2;
			this.label8.ImageList = this.img_Label;
			this.label8.Location = new System.Drawing.Point(8, 133);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 21);
			this.label8.TabIndex = 135;
			this.label8.Text = "OBS ID";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label9.Font = new System.Drawing.Font("Verdana", 8F);
			this.label9.ImageIndex = 2;
			this.label9.ImageList = this.img_Label;
			this.label9.Location = new System.Drawing.Point(8, 176);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 21);
			this.label9.TabIndex = 134;
			this.label9.Text = "Region";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label7.Font = new System.Drawing.Font("Verdana", 8F);
			this.label7.ImageIndex = 2;
			this.label7.ImageList = this.img_Label;
			this.label7.Location = new System.Drawing.Point(8, 155);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 21);
			this.label7.TabIndex = 133;
			this.label7.Text = "Lasting Week";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label6.Font = new System.Drawing.Font("Verdana", 8F);
			this.label6.ImageIndex = 2;
			this.label6.ImageList = this.img_Label;
			this.label6.Location = new System.Drawing.Point(8, 221);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 21);
			this.label6.TabIndex = 132;
			this.label6.Text = "Job Div.";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label4.Font = new System.Drawing.Font("Verdana", 8F);
			this.label4.ImageIndex = 1;
			this.label4.ImageList = this.img_Label;
			this.label4.Location = new System.Drawing.Point(336, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 21);
			this.label4.TabIndex = 131;
			this.label4.Text = "Change No";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Verdana", 8F);
			this.label1.ImageIndex = 1;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(336, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 130;
			this.label1.Text = "OBS Seq No";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_RGAC
			// 
			this.lbl_RGAC.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_RGAC.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_RGAC.ImageIndex = 0;
			this.lbl_RGAC.ImageList = this.img_Label;
			this.lbl_RGAC.Location = new System.Drawing.Point(336, 176);
			this.lbl_RGAC.Name = "lbl_RGAC";
			this.lbl_RGAC.Size = new System.Drawing.Size(100, 21);
			this.lbl_RGAC.TabIndex = 128;
			this.lbl_RGAC.Text = "RGAC  Date";
			this.lbl_RGAC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Verdana", 8F);
			this.label3.ImageIndex = 1;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(336, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 129;
			this.label3.Text = "OBS No";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Ogac
			// 
			this.lbl_Ogac.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Ogac.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Ogac.ImageIndex = 0;
			this.lbl_Ogac.ImageList = this.img_Label;
			this.lbl_Ogac.Location = new System.Drawing.Point(336, 155);
			this.lbl_Ogac.Name = "lbl_Ogac";
			this.lbl_Ogac.Size = new System.Drawing.Size(100, 21);
			this.lbl_Ogac.TabIndex = 162;
			this.lbl_Ogac.Text = "OGAC Date";
			this.lbl_Ogac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_OGAC_YMD
			// 
			this.dpick_OGAC_YMD.CustomFormat = "yyyy-MM-dd";
			this.dpick_OGAC_YMD.Font = new System.Drawing.Font("Verdana", 8F);
			this.dpick_OGAC_YMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_OGAC_YMD.Location = new System.Drawing.Point(437, 155);
			this.dpick_OGAC_YMD.Name = "dpick_OGAC_YMD";
			this.dpick_OGAC_YMD.Size = new System.Drawing.Size(142, 20);
			this.dpick_OGAC_YMD.TabIndex = 163;
			this.dpick_OGAC_YMD.ValueChanged += new System.EventHandler(this.dpick_OGAC_YMD_ValueChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.White;
			this.groupBox2.Controls.Add(this.fgrid_size);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.ForeColor = System.Drawing.Color.Black;
			this.groupBox2.Location = new System.Drawing.Point(8, 1);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(584, 104);
			this.groupBox2.TabIndex = 133;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "§ By Size";
			// 
			// fgrid_size
			// 
			this.fgrid_size.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_size.AutoResize = false;
			this.fgrid_size.BackColor = System.Drawing.Color.White;
			this.fgrid_size.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_size.ColumnInfo = "3,1,0,0,0,95,Columns:";
			this.fgrid_size.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_size.ForeColor = System.Drawing.Color.Black;
			this.fgrid_size.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_size.Location = new System.Drawing.Point(3, 18);
			this.fgrid_size.Name = "fgrid_size";
			this.fgrid_size.Rows.Count = 3;
			this.fgrid_size.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.fgrid_size.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_size.Size = new System.Drawing.Size(578, 83);
			this.fgrid_size.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_size.TabIndex = 36;
			this.fgrid_size.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_size_AfterEdit);
			// 
			// pnl_save_main
			// 
			this.pnl_save_main.BackColor = System.Drawing.Color.White;
			this.pnl_save_main.Controls.Add(this.pnl_save_image);
			this.pnl_save_main.DockPadding.All = 8;
			this.pnl_save_main.Location = new System.Drawing.Point(16, 16);
			this.pnl_save_main.Name = "pnl_save_main";
			this.pnl_save_main.Size = new System.Drawing.Size(608, 184);
			this.pnl_save_main.TabIndex = 39;
			// 
			// pnl_save_image
			// 
			this.pnl_save_image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_save_image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_save_image.Controls.Add(this.lbl_exp);
			this.pnl_save_image.Controls.Add(this.txt_Region_nm1);
			this.pnl_save_image.Controls.Add(this.btn_Apply);
			this.pnl_save_image.Controls.Add(this.txt_TOT_Qty_1);
			this.pnl_save_image.Controls.Add(this.lbl_TOT_Qty);
			this.pnl_save_image.Controls.Add(this.txt_Region1);
			this.pnl_save_image.Controls.Add(this.txt_BP_NO1);
			this.pnl_save_image.Controls.Add(this.txt_OBS_ID2);
			this.pnl_save_image.Controls.Add(this.lbl_Region);
			this.pnl_save_image.Controls.Add(this.lbl_BP_NO);
			this.pnl_save_image.Controls.Add(this.lbl_OBS_ID);
			this.pnl_save_image.Controls.Add(this.pictureBox10);
			this.pnl_save_image.Controls.Add(this.pictureBox7);
			this.pnl_save_image.Controls.Add(this.label5);
			this.pnl_save_image.Controls.Add(this.pictureBox11);
			this.pnl_save_image.Controls.Add(this.pictureBox12);
			this.pnl_save_image.Controls.Add(this.pictureBox13);
			this.pnl_save_image.Controls.Add(this.pictureBox14);
			this.pnl_save_image.Controls.Add(this.pictureBox15);
			this.pnl_save_image.Controls.Add(this.pictureBox16);
			this.pnl_save_image.Location = new System.Drawing.Point(8, 8);
			this.pnl_save_image.Name = "pnl_save_image";
			this.pnl_save_image.Size = new System.Drawing.Size(592, 169);
			this.pnl_save_image.TabIndex = 126;
			// 
			// lbl_exp
			// 
			this.lbl_exp.AutoSize = true;
			this.lbl_exp.BackColor = System.Drawing.Color.White;
			this.lbl_exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbl_exp.ForeColor = System.Drawing.Color.Gray;
			this.lbl_exp.Location = new System.Drawing.Point(112, 141);
			this.lbl_exp.Name = "lbl_exp";
			this.lbl_exp.Size = new System.Drawing.Size(233, 18);
			this.lbl_exp.TabIndex = 147;
			this.lbl_exp.Text = "※ Max Q\'ty : (100 X 0.8) - 50  = 30";
			this.lbl_exp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Region_nm1
			// 
			this.txt_Region_nm1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Region_nm1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Region_nm1.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Region_nm1.Location = new System.Drawing.Point(180, 80);
			this.txt_Region_nm1.MaxLength = 100;
			this.txt_Region_nm1.Name = "txt_Region_nm1";
			this.txt_Region_nm1.ReadOnly = true;
			this.txt_Region_nm1.Size = new System.Drawing.Size(141, 20);
			this.txt_Region_nm1.TabIndex = 146;
			this.txt_Region_nm1.Text = "";
			// 
			// btn_Apply
			// 
			this.btn_Apply.Font = new System.Drawing.Font("Verdana", 8F);
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_ShortButton;
			this.btn_Apply.Location = new System.Drawing.Point(322, 111);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.TabIndex = 145;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			this.btn_Apply.MouseHover += new System.EventHandler(this.btn_Apply_MouseHover);
			this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_Apply_MouseLeave);
			// 
			// img_ShortButton
			// 
			this.img_ShortButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_ShortButton.ImageSize = new System.Drawing.Size(100, 23);
			this.img_ShortButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_ShortButton.ImageStream")));
			this.img_ShortButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// txt_TOT_Qty_1
			// 
			this.txt_TOT_Qty_1.BackColor = System.Drawing.Color.White;
			this.txt_TOT_Qty_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_TOT_Qty_1.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_TOT_Qty_1.ForeColor = System.Drawing.Color.Blue;
			this.txt_TOT_Qty_1.Location = new System.Drawing.Point(111, 112);
			this.txt_TOT_Qty_1.MaxLength = 100;
			this.txt_TOT_Qty_1.Name = "txt_TOT_Qty_1";
			this.txt_TOT_Qty_1.Size = new System.Drawing.Size(210, 20);
			this.txt_TOT_Qty_1.TabIndex = 144;
			this.txt_TOT_Qty_1.Text = "";
			this.txt_TOT_Qty_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbl_TOT_Qty
			// 
			this.lbl_TOT_Qty.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_TOT_Qty.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_TOT_Qty.ForeColor = System.Drawing.Color.SaddleBrown;
			this.lbl_TOT_Qty.ImageIndex = 1;
			this.lbl_TOT_Qty.ImageList = this.img_Label;
			this.lbl_TOT_Qty.Location = new System.Drawing.Point(10, 112);
			this.lbl_TOT_Qty.Name = "lbl_TOT_Qty";
			this.lbl_TOT_Qty.Size = new System.Drawing.Size(100, 21);
			this.lbl_TOT_Qty.TabIndex = 138;
			this.lbl_TOT_Qty.Text = "Total Q\'ty";
			this.lbl_TOT_Qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Region1
			// 
			this.txt_Region1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Region1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Region1.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Region1.Location = new System.Drawing.Point(111, 80);
			this.txt_Region1.MaxLength = 100;
			this.txt_Region1.Name = "txt_Region1";
			this.txt_Region1.ReadOnly = true;
			this.txt_Region1.Size = new System.Drawing.Size(68, 20);
			this.txt_Region1.TabIndex = 137;
			this.txt_Region1.Text = "";
			this.txt_Region1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txt_BP_NO1
			// 
			this.txt_BP_NO1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_BP_NO1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_BP_NO1.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_BP_NO1.Location = new System.Drawing.Point(111, 58);
			this.txt_BP_NO1.MaxLength = 100;
			this.txt_BP_NO1.Name = "txt_BP_NO1";
			this.txt_BP_NO1.ReadOnly = true;
			this.txt_BP_NO1.Size = new System.Drawing.Size(210, 20);
			this.txt_BP_NO1.TabIndex = 136;
			this.txt_BP_NO1.Text = "";
			// 
			// txt_OBS_ID2
			// 
			this.txt_OBS_ID2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OBS_ID2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_ID2.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_ID2.Location = new System.Drawing.Point(111, 36);
			this.txt_OBS_ID2.MaxLength = 100;
			this.txt_OBS_ID2.Name = "txt_OBS_ID2";
			this.txt_OBS_ID2.ReadOnly = true;
			this.txt_OBS_ID2.Size = new System.Drawing.Size(210, 20);
			this.txt_OBS_ID2.TabIndex = 135;
			this.txt_OBS_ID2.Text = "";
			// 
			// lbl_Region
			// 
			this.lbl_Region.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Region.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Region.ImageIndex = 2;
			this.lbl_Region.ImageList = this.img_Label;
			this.lbl_Region.Location = new System.Drawing.Point(10, 80);
			this.lbl_Region.Name = "lbl_Region";
			this.lbl_Region.Size = new System.Drawing.Size(100, 21);
			this.lbl_Region.TabIndex = 113;
			this.lbl_Region.Text = "Region";
			this.lbl_Region.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_BP_NO
			// 
			this.lbl_BP_NO.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_BP_NO.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_BP_NO.ImageIndex = 2;
			this.lbl_BP_NO.ImageList = this.img_Label;
			this.lbl_BP_NO.Location = new System.Drawing.Point(10, 58);
			this.lbl_BP_NO.Name = "lbl_BP_NO";
			this.lbl_BP_NO.Size = new System.Drawing.Size(100, 21);
			this.lbl_BP_NO.TabIndex = 110;
			this.lbl_BP_NO.Text = "Lasting Week";
			this.lbl_BP_NO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_OBS_ID
			// 
			this.lbl_OBS_ID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_ID.ImageIndex = 2;
			this.lbl_OBS_ID.ImageList = this.img_Label;
			this.lbl_OBS_ID.Location = new System.Drawing.Point(10, 36);
			this.lbl_OBS_ID.Name = "lbl_OBS_ID";
			this.lbl_OBS_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_ID.TabIndex = 109;
			this.lbl_OBS_ID.Text = "OBS ID";
			this.lbl_OBS_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(165, 0);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(416, 30);
			this.pictureBox10.TabIndex = 2;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(579, 0);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(13, 30);
			this.pictureBox7.TabIndex = 1;
			this.pictureBox7.TabStop = false;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.Highlight;
			this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(165, 30);
			this.label5.TabIndex = 0;
			this.label5.Text = "      CS DPO Info.";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox11.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(561, 30);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(31, 123);
			this.pictureBox11.TabIndex = 5;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.Color.Blue;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(567, 139);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(25, 30);
			this.pictureBox12.TabIndex = 8;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox13.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(0, 24);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(32, 134);
			this.pictureBox13.TabIndex = 3;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox14.BackColor = System.Drawing.Color.Blue;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(0, 139);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(72, 40);
			this.pictureBox14.TabIndex = 6;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox15.BackColor = System.Drawing.Color.Blue;
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(72, 139);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(504, 30);
			this.pictureBox15.TabIndex = 9;
			this.pictureBox15.TabStop = false;
			// 
			// pictureBox16
			// 
			this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox16.BackColor = System.Drawing.Color.Navy;
			this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
			this.pictureBox16.Location = new System.Drawing.Point(32, 24);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(544, 137);
			this.pictureBox16.TabIndex = 4;
			this.pictureBox16.TabStop = false;
			// 
			// pnl_1
			// 
			this.pnl_1.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_1.Controls.Add(this.pnl_search_detail);
			this.pnl_1.Controls.Add(this.pnl_search_main);
			this.pnl_1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnl_1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_1.Location = new System.Drawing.Point(0, 0);
			this.pnl_1.Name = "pnl_1";
			this.pnl_1.Size = new System.Drawing.Size(408, 568);
			this.pnl_1.TabIndex = 44;
			// 
			// pnl_search_detail
			// 
			this.pnl_search_detail.BackColor = System.Drawing.Color.White;
			this.pnl_search_detail.Controls.Add(this.splitter3);
			this.pnl_search_detail.Controls.Add(this.gb_CS_N);
			this.pnl_search_detail.Controls.Add(this.gb_CS_Y);
			this.pnl_search_detail.DockPadding.Bottom = 8;
			this.pnl_search_detail.DockPadding.Left = 8;
			this.pnl_search_detail.DockPadding.Right = 8;
			this.pnl_search_detail.DockPadding.Top = 1;
			this.pnl_search_detail.Location = new System.Drawing.Point(16, 232);
			this.pnl_search_detail.Name = "pnl_search_detail";
			this.pnl_search_detail.Size = new System.Drawing.Size(344, 336);
			this.pnl_search_detail.TabIndex = 39;
			// 
			// splitter3
			// 
			this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter3.Location = new System.Drawing.Point(8, 177);
			this.splitter3.Name = "splitter3";
			this.splitter3.Size = new System.Drawing.Size(328, 2);
			this.splitter3.TabIndex = 135;
			this.splitter3.TabStop = false;
			// 
			// gb_CS_N
			// 
			this.gb_CS_N.BackColor = System.Drawing.Color.White;
			this.gb_CS_N.Controls.Add(this.fgrid_CS_N);
			this.gb_CS_N.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_CS_N.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gb_CS_N.ForeColor = System.Drawing.Color.Black;
			this.gb_CS_N.Location = new System.Drawing.Point(8, 177);
			this.gb_CS_N.Name = "gb_CS_N";
			this.gb_CS_N.Size = new System.Drawing.Size(328, 151);
			this.gb_CS_N.TabIndex = 134;
			this.gb_CS_N.TabStop = false;
			this.gb_CS_N.Text = "§ Target CS OBS";
			// 
			// fgrid_CS_N
			// 
			this.fgrid_CS_N.AutoResize = false;
			this.fgrid_CS_N.BackColor = System.Drawing.Color.White;
			this.fgrid_CS_N.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_CS_N.ColumnInfo = "2,1,0,0,0,95,Columns:";
			this.fgrid_CS_N.ContextMenu = this.contextMenu1;
			this.fgrid_CS_N.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_CS_N.ForeColor = System.Drawing.Color.Black;
			this.fgrid_CS_N.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_CS_N.Location = new System.Drawing.Point(3, 18);
			this.fgrid_CS_N.Name = "fgrid_CS_N";
			this.fgrid_CS_N.Rows.Count = 2;
			this.fgrid_CS_N.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_CS_N.Size = new System.Drawing.Size(322, 130);
			this.fgrid_CS_N.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_CS_N.TabIndex = 37;
			this.fgrid_CS_N.DoubleClick += new System.EventHandler(this.fgrid_CS_N_DoubleClick);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.ctm_Request,
																						 this.ctm_GSSC_Information,
																						 this.ctm_Bar_First,
																						 this.ctm_OBS_Sel,
																						 this.ctm_OBS_HistSel});
			// 
			// ctm_Request
			// 
			this.ctm_Request.Index = 0;
			this.ctm_Request.Text = "CS OBS Request";
			this.ctm_Request.Click += new System.EventHandler(this.ctm_Request_Click);
			// 
			// ctm_GSSC_Information
			// 
			this.ctm_GSSC_Information.Index = 1;
			this.ctm_GSSC_Information.Text = "GSSC Information";
			this.ctm_GSSC_Information.Click += new System.EventHandler(this.ctm_GSSC_Information_Click);
			// 
			// ctm_Bar_First
			// 
			this.ctm_Bar_First.Index = 2;
			this.ctm_Bar_First.Text = "-";
			// 
			// ctm_OBS_Sel
			// 
			this.ctm_OBS_Sel.Index = 3;
			this.ctm_OBS_Sel.Text = "CS OBS By Option";
			this.ctm_OBS_Sel.Click += new System.EventHandler(this.ctm_OBS_Sel_Click);
			// 
			// ctm_OBS_HistSel
			// 
			this.ctm_OBS_HistSel.Index = 4;
			this.ctm_OBS_HistSel.Text = "CS OBS History";
			this.ctm_OBS_HistSel.Click += new System.EventHandler(this.ctm_OBS_HistSel_Click);
			// 
			// gb_CS_Y
			// 
			this.gb_CS_Y.BackColor = System.Drawing.Color.White;
			this.gb_CS_Y.Controls.Add(this.fgrid_CS_Y);
			this.gb_CS_Y.Dock = System.Windows.Forms.DockStyle.Top;
			this.gb_CS_Y.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gb_CS_Y.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gb_CS_Y.ForeColor = System.Drawing.Color.Black;
			this.gb_CS_Y.Location = new System.Drawing.Point(8, 1);
			this.gb_CS_Y.Name = "gb_CS_Y";
			this.gb_CS_Y.Size = new System.Drawing.Size(328, 176);
			this.gb_CS_Y.TabIndex = 133;
			this.gb_CS_Y.TabStop = false;
			this.gb_CS_Y.Text = "§ Completion CS OBS";
			// 
			// fgrid_CS_Y
			// 
			this.fgrid_CS_Y.AutoResize = false;
			this.fgrid_CS_Y.BackColor = System.Drawing.Color.White;
			this.fgrid_CS_Y.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_CS_Y.ColumnInfo = "2,1,0,0,0,95,Columns:";
			this.fgrid_CS_Y.ContextMenu = this.contextMenu1;
			this.fgrid_CS_Y.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_CS_Y.ForeColor = System.Drawing.Color.Black;
			this.fgrid_CS_Y.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_CS_Y.Location = new System.Drawing.Point(3, 18);
			this.fgrid_CS_Y.Name = "fgrid_CS_Y";
			this.fgrid_CS_Y.Rows.Count = 2;
			this.fgrid_CS_Y.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_CS_Y.Size = new System.Drawing.Size(322, 155);
			this.fgrid_CS_Y.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_CS_Y.TabIndex = 36;
			this.fgrid_CS_Y.Click += new System.EventHandler(this.fgrid_CS_Y_Click);
			this.fgrid_CS_Y.DoubleClick += new System.EventHandler(this.fgrid_CS_Y_DoubleClick);
			// 
			// pnl_search_main
			// 
			this.pnl_search_main.BackColor = System.Drawing.Color.White;
			this.pnl_search_main.Controls.Add(this.pnl_Search1_Image);
			this.pnl_search_main.DockPadding.All = 8;
			this.pnl_search_main.Location = new System.Drawing.Point(16, 24);
			this.pnl_search_main.Name = "pnl_search_main";
			this.pnl_search_main.Size = new System.Drawing.Size(344, 184);
			this.pnl_search_main.TabIndex = 38;
			// 
			// pnl_Search1_Image
			// 
			this.pnl_Search1_Image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_Search1_Image.Controls.Add(this.txt_Style);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Style);
			this.pnl_Search1_Image.Controls.Add(this.txt_OBS_ID1);
			this.pnl_Search1_Image.Controls.Add(this.gb_option);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Del_Month);
			this.pnl_Search1_Image.Controls.Add(this.cmb_OBS_Type);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Del_Month);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Factory);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Factory);
			this.pnl_Search1_Image.Controls.Add(this.lbl_OBS_Type);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox2);
			this.pnl_Search1_Image.Controls.Add(this.lbl_SubTitle1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox5);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox8);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox3);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox6);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox9);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox4);
			this.pnl_Search1_Image.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_Search1_Image.Location = new System.Drawing.Point(8, 8);
			this.pnl_Search1_Image.Name = "pnl_Search1_Image";
			this.pnl_Search1_Image.Size = new System.Drawing.Size(328, 169);
			this.pnl_Search1_Image.TabIndex = 126;
			// 
			// txt_Style
			// 
			this.txt_Style.BackColor = System.Drawing.Color.White;
			this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Style.Location = new System.Drawing.Point(111, 102);
			this.txt_Style.MaxLength = 100;
			this.txt_Style.Name = "txt_Style";
			this.txt_Style.Size = new System.Drawing.Size(210, 20);
			this.txt_Style.TabIndex = 138;
			this.txt_Style.Text = "";
			// 
			// lbl_Style
			// 
			this.lbl_Style.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Style.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(10, 102);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 137;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_OBS_ID1
			// 
			this.txt_OBS_ID1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OBS_ID1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_ID1.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_ID1.Location = new System.Drawing.Point(201, 80);
			this.txt_OBS_ID1.MaxLength = 100;
			this.txt_OBS_ID1.Name = "txt_OBS_ID1";
			this.txt_OBS_ID1.ReadOnly = true;
			this.txt_OBS_ID1.Size = new System.Drawing.Size(120, 20);
			this.txt_OBS_ID1.TabIndex = 136;
			this.txt_OBS_ID1.Text = "";
			// 
			// gb_option
			// 
			this.gb_option.BackColor = System.Drawing.Color.White;
			this.gb_option.Controls.Add(this.chk_Del_Month);
			this.gb_option.Controls.Add(this.chk_Region);
			this.gb_option.Controls.Add(this.chk_BP_NO);
			this.gb_option.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gb_option.Location = new System.Drawing.Point(10, 121);
			this.gb_option.Name = "gb_option";
			this.gb_option.Size = new System.Drawing.Size(312, 43);
			this.gb_option.TabIndex = 132;
			this.gb_option.TabStop = false;
			this.gb_option.Text = "Option";
			// 
			// chk_Del_Month
			// 
			this.chk_Del_Month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chk_Del_Month.Location = new System.Drawing.Point(10, 18);
			this.chk_Del_Month.Name = "chk_Del_Month";
			this.chk_Del_Month.Size = new System.Drawing.Size(120, 20);
			this.chk_Del_Month.TabIndex = 0;
			this.chk_Del_Month.Text = "Delivery Month";
			this.chk_Del_Month.Click += new System.EventHandler(this.chk_Del_Month_Click);
			// 
			// chk_Region
			// 
			this.chk_Region.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chk_Region.Font = new System.Drawing.Font("Verdana", 9F);
			this.chk_Region.Location = new System.Drawing.Point(242, 18);
			this.chk_Region.Name = "chk_Region";
			this.chk_Region.Size = new System.Drawing.Size(68, 20);
			this.chk_Region.TabIndex = 0;
			this.chk_Region.Text = "Region";
			// 
			// chk_BP_NO
			// 
			this.chk_BP_NO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chk_BP_NO.Location = new System.Drawing.Point(130, 18);
			this.chk_BP_NO.Name = "chk_BP_NO";
			this.chk_BP_NO.Size = new System.Drawing.Size(112, 20);
			this.chk_BP_NO.TabIndex = 0;
			this.chk_BP_NO.Text = "Lasting week";
			// 
			// cmb_Del_Month
			// 
			this.cmb_Del_Month.AddItemCols = 0;
			this.cmb_Del_Month.AddItemSeparator = ';';
			this.cmb_Del_Month.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Del_Month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Del_Month.Caption = "";
			this.cmb_Del_Month.CaptionHeight = 17;
			this.cmb_Del_Month.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Del_Month.ColumnCaptionHeight = 18;
			this.cmb_Del_Month.ColumnFooterHeight = 18;
			this.cmb_Del_Month.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Del_Month.ContentHeight = 15;
			this.cmb_Del_Month.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Del_Month.EditorBackColor = System.Drawing.Color.White;
			this.cmb_Del_Month.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Del_Month.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Del_Month.EditorHeight = 15;
			this.cmb_Del_Month.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Del_Month.GapHeight = 2;
			this.cmb_Del_Month.ItemHeight = 15;
			this.cmb_Del_Month.Location = new System.Drawing.Point(111, 80);
			this.cmb_Del_Month.MatchEntryTimeout = ((long)(2000));
			this.cmb_Del_Month.MaxDropDownItems = ((short)(5));
			this.cmb_Del_Month.MaxLength = 32767;
			this.cmb_Del_Month.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Del_Month.Name = "cmb_Del_Month";
			this.cmb_Del_Month.PartialRightColumn = false;
			this.cmb_Del_Month.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Del_Month.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Del_Month.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Del_Month.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Del_Month.Size = new System.Drawing.Size(89, 19);
			this.cmb_Del_Month.TabIndex = 129;
			this.cmb_Del_Month.TextChanged += new System.EventHandler(this.cmb_Del_Month_TextChanged);
			// 
			// cmb_OBS_Type
			// 
			this.cmb_OBS_Type.AddItemCols = 0;
			this.cmb_OBS_Type.AddItemSeparator = ';';
			this.cmb_OBS_Type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_Type.Caption = "";
			this.cmb_OBS_Type.CaptionHeight = 17;
			this.cmb_OBS_Type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_Type.ColumnCaptionHeight = 18;
			this.cmb_OBS_Type.ColumnFooterHeight = 18;
			this.cmb_OBS_Type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_Type.ContentHeight = 15;
			this.cmb_OBS_Type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_Type.EditorBackColor = System.Drawing.Color.White;
			this.cmb_OBS_Type.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_Type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_Type.EditorHeight = 15;
			this.cmb_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_Type.GapHeight = 2;
			this.cmb_OBS_Type.ItemHeight = 15;
			this.cmb_OBS_Type.Location = new System.Drawing.Point(111, 58);
			this.cmb_OBS_Type.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_Type.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_Type.MaxLength = 32767;
			this.cmb_OBS_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_Type.Name = "cmb_OBS_Type";
			this.cmb_OBS_Type.PartialRightColumn = false;
			this.cmb_OBS_Type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_OBS_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type.Size = new System.Drawing.Size(210, 19);
			this.cmb_OBS_Type.TabIndex = 128;
			// 
			// lbl_Del_Month
			// 
			this.lbl_Del_Month.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Del_Month.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Del_Month.ImageIndex = 1;
			this.lbl_Del_Month.ImageList = this.img_Label;
			this.lbl_Del_Month.Location = new System.Drawing.Point(10, 80);
			this.lbl_Del_Month.Name = "lbl_Del_Month";
			this.lbl_Del_Month.Size = new System.Drawing.Size(100, 21);
			this.lbl_Del_Month.TabIndex = 127;
			this.lbl_Del_Month.Text = "Delivery Month";
			this.lbl_Del_Month.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 124;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Factory
			// 
			this.cmb_Factory.AddItemCols = 0;
			this.cmb_Factory.AddItemSeparator = ';';
			this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory.Caption = "";
			this.cmb_Factory.CaptionHeight = 17;
			this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory.ColumnCaptionHeight = 18;
			this.cmb_Factory.ColumnFooterHeight = 18;
			this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory.ContentHeight = 15;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.Color.White;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 15;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(111, 36);
			this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory.MaxDropDownItems = ((short)(5));
			this.cmb_Factory.MaxLength = 32767;
			this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory.Name = "cmb_Factory";
			this.cmb_Factory.PartialRightColumn = false;
			this.cmb_Factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory.TabIndex = 126;
			// 
			// lbl_OBS_Type
			// 
			this.lbl_OBS_Type.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Type.ImageIndex = 1;
			this.lbl_OBS_Type.ImageList = this.img_Label;
			this.lbl_OBS_Type.Location = new System.Drawing.Point(10, 58);
			this.lbl_OBS_Type.Name = "lbl_OBS_Type";
			this.lbl_OBS_Type.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_Type.TabIndex = 125;
			this.lbl_OBS_Type.Text = "OBS Type";
			this.lbl_OBS_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(306, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(22, 32);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(168, -1);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(144, 32);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(172, 32);
			this.lbl_SubTitle1.TabIndex = 0;
			this.lbl_SubTitle1.Text = "      Delivery Info.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(309, 32);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(19, 123);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.Color.Blue;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(238, 155);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(90, 14);
			this.pictureBox8.TabIndex = 8;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(0, 24);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 134);
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.Color.Blue;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 155);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(80, 14);
			this.pictureBox6.TabIndex = 6;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox9.BackColor = System.Drawing.Color.Blue;
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(72, 155);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(240, 14);
			this.pictureBox9.TabIndex = 9;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.Color.Navy;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(32, 24);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(280, 137);
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			// 
			// lbl_Year
			// 
			this.lbl_Year.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Year.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Year.ImageIndex = 1;
			this.lbl_Year.ImageList = this.img_Label;
			this.lbl_Year.Location = new System.Drawing.Point(336, 133);
			this.lbl_Year.Name = "lbl_Year";
			this.lbl_Year.Size = new System.Drawing.Size(100, 21);
			this.lbl_Year.TabIndex = 171;
			this.lbl_Year.Text = "Year";
			this.lbl_Year.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Season
			// 
			this.lbl_Season.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Season.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Season.ImageIndex = 1;
			this.lbl_Season.ImageList = this.img_Label;
			this.lbl_Season.Location = new System.Drawing.Point(336, 111);
			this.lbl_Season.Name = "lbl_Season";
			this.lbl_Season.Size = new System.Drawing.Size(100, 21);
			this.lbl_Season.TabIndex = 170;
			this.lbl_Season.Text = "Season";
			this.lbl_Season.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Year
			// 
			this.cmb_Year.AddItemCols = 0;
			this.cmb_Year.AddItemSeparator = ';';
			this.cmb_Year.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Year.Caption = "";
			this.cmb_Year.CaptionHeight = 17;
			this.cmb_Year.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Year.ColumnCaptionHeight = 18;
			this.cmb_Year.ColumnFooterHeight = 18;
			this.cmb_Year.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Year.ContentHeight = 16;
			this.cmb_Year.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Year.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Year.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Year.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Year.EditorHeight = 16;
			this.cmb_Year.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Year.GapHeight = 2;
			this.cmb_Year.ItemHeight = 15;
			this.cmb_Year.Location = new System.Drawing.Point(437, 133);
			this.cmb_Year.MatchEntryTimeout = ((long)(2000));
			this.cmb_Year.MaxDropDownItems = ((short)(5));
			this.cmb_Year.MaxLength = 32767;
			this.cmb_Year.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Year.Name = "cmb_Year";
			this.cmb_Year.PartialRightColumn = false;
			this.cmb_Year.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight" +
				";}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:" +
				"True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:" +
				"Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1Lis" +
				"t.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHei" +
				"ght=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"" +
				"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScroll" +
				"Bar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me" +
				"=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Fo" +
				"oter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle pare" +
				"nt=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" " +
				"/><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me" +
				"=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Selecte" +
				"dStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1" +
				".Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><St" +
				"yle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style " +
				"parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style p" +
				"arent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style" +
				" parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style pare" +
				"nt=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedS" +
				"tyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layo" +
				"ut><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Year.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Year.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Year.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Year.Size = new System.Drawing.Size(140, 20);
			this.cmb_Year.TabIndex = 221;
			// 
			// cmb_Season
			// 
			this.cmb_Season.AddItemCols = 0;
			this.cmb_Season.AddItemSeparator = ';';
			this.cmb_Season.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Season.Caption = "";
			this.cmb_Season.CaptionHeight = 17;
			this.cmb_Season.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Season.ColumnCaptionHeight = 18;
			this.cmb_Season.ColumnFooterHeight = 18;
			this.cmb_Season.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Season.ContentHeight = 16;
			this.cmb_Season.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Season.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Season.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Season.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Season.EditorHeight = 16;
			this.cmb_Season.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Season.GapHeight = 2;
			this.cmb_Season.ItemHeight = 15;
			this.cmb_Season.Location = new System.Drawing.Point(437, 111);
			this.cmb_Season.MatchEntryTimeout = ((long)(2000));
			this.cmb_Season.MaxDropDownItems = ((short)(5));
			this.cmb_Season.MaxLength = 32767;
			this.cmb_Season.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Season.Name = "cmb_Season";
			this.cmb_Season.PartialRightColumn = false;
			this.cmb_Season.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight" +
				";}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:" +
				"Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8" +
				"{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1Lis" +
				"t.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHei" +
				"ght=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"" +
				"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScroll" +
				"Bar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me" +
				"=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Fo" +
				"oter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle pare" +
				"nt=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" " +
				"/><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me" +
				"=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Selecte" +
				"dStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1" +
				".Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><St" +
				"yle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style " +
				"parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style p" +
				"arent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style" +
				" parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style pare" +
				"nt=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedS" +
				"tyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layo" +
				"ut><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Season.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Season.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Season.Size = new System.Drawing.Size(140, 20);
			this.cmb_Season.TabIndex = 220;
			// 
			// Form_EC_CRT
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.ClientSize = new System.Drawing.Size(1024, 654);
			this.Controls.Add(this.pnl_main);
			this.Font = new System.Drawing.Font("Verdana", 8F);
			this.Name = "Form_EC_CRT";
			this.Text = "CS DPO Create";
			this.Load += new System.EventHandler(this.Form_EC_CRT_Load);
			this.Controls.SetChildIndex(this.pnl_main, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_main.ResumeLayout(false);
			this.pnl_2.ResumeLayout(false);
			this.pnl_save_detail.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_size)).EndInit();
			this.pnl_save_main.ResumeLayout(false);
			this.pnl_save_image.ResumeLayout(false);
			this.pnl_1.ResumeLayout(false);
			this.pnl_search_detail.ResumeLayout(false);
			this.gb_CS_N.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_CS_N)).EndInit();
			this.gb_CS_Y.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_CS_Y)).EndInit();
			this.pnl_search_main.ResumeLayout(false);
			this.pnl_Search1_Image.ResumeLayout(false);
			this.gb_option.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Del_Month)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Year)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의
   
		private int _Rowfixed; 
		private double _Percent; 
		private string _Date_Flag;

		
		COM.OraDB MyOraDB = new COM.OraDB();  
		private COM.ComFunction MyComFunction    = new COM.ComFunction();
		private ClassLib.OraDB  MyClassLib = new ClassLib.OraDB();
		


		#endregion 	

		#region 멤버 메서드 

		private void Init_Form()
		{ 
			DataTable dt_list; 
			DateTime CurDate = DateTime.Now;
			int i;
		
			//Title
			this.Text = "CS DPO";
			this.lbl_MainTitle.Text = "Create CS OBS"; 
			ClassLib.ComFunction.SetLangDic(this);

			#region 버튼 권한

			try
			{
//				COM.OraDB btn_control = new COM.OraDB();
//				DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
//				tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
//				btn_control = null;
//

				//Button 활성화
				tbtn_Append.Enabled = false;   tbtn_Insert.Enabled = false;  tbtn_Print.Enabled = false;

			}
			catch
			{
			}

			#endregion


			// panel 설정
			pnl_search_main.Dock   = DockStyle.Top;
			pnl_search_detail.Dock = DockStyle.Fill;
			pnl_save_main.Dock     = DockStyle.Top;
			pnl_save_detail.Dock   = DockStyle.Fill;
			
			#region 그리드
			//-Completion CS DPO Grid	(TBSEM_OBS_CS)		
			fgrid_CS_Y.Set_Grid( "SEM_OBS_CS", "3", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);  
			_Rowfixed = fgrid_CS_Y.Rows.Fixed;	
			fgrid_CS_Y.Cols[(int)ClassLib.TBSEM_OBS_BP.IxBP_NO].Width = 70;
			fgrid_CS_Y.Font  = new Font("Verdana",8);

			//-Target CS DPO Grid(TBSEM_OBS_BP)		
			fgrid_CS_N.Set_Grid( "SEM_OBS_CS", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);  
			_Rowfixed = fgrid_CS_N.Rows.Fixed;	
			fgrid_CS_N.Cols[(int)ClassLib.TBSEM_OBS_BP.IxBP_NO].Width = 70;
			fgrid_CS_N.Font  = new Font("Verdana",8);

			//-By Size Grid
			dt_list = MyOraDB.Select_GridHead("SEM_OBS_CS","2");
			for(i = 0; i < dt_list.Rows.Count; i++)
			{
				fgrid_size[i, 0] = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSCM_TABLE.IxCOL_NAME-1].ToString();		//Size
				fgrid_size[i, 1] = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSCM_TABLE.IxHEAD_DESC1-1].ToString();		//Rate				
			}

			fgrid_size.Cols.Fixed = 2; fgrid_size.Cols[0].Visible = false; fgrid_size.AutoSizeCols(); 	
			
			
			fgrid_size.GetCellRange(0,0,0,fgrid_size.Cols.Count-1).StyleNew.BackColor  =  ClassLib.ComVar.Clr_Head_Crimson;
			fgrid_size.GetCellRange(0,1,fgrid_size.Rows.Count-1,1).StyleNew.BackColor  =  ClassLib.ComVar.Clr_Head_Crimson;
			
			fgrid_size.Font  = new Font("Verdana",8);

			#endregion
			
			// 콤보박스 설정
			///Factory
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			///CS OBS Limited(%)
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxCO_Limite);
			_Percent = Convert.ToDouble(dt_list.Rows[0].ItemArray[1].ToString());
			
			///del_month
			cmb_Del_Month.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
			cmb_Del_Month.ClearItems();
			cmb_Del_Month.ExtendRightColumn = true;
			cmb_Del_Month.ColumnHeaders = false;
			for(i = -6; i <= 5; i++)
				cmb_Del_Month.AddItem( CurDate.AddMonths(i).ToString("yyyyMM") + "01" );
			cmb_Del_Month.MaxDropDownItems = Convert.ToInt16(cmb_Del_Month.ListCount);

			///OBS_Type
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxOBS_Type);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OBS_Type, 1, 2, false);  			
			cmb_OBS_Type.SelectedIndex = 0;

			//Date
			dpick_CSET_YMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			string now  = System.DateTime.Now.ToString("yyyyMMdd");
			dpick_CSET_YMD.Text =  MyComFunction.ConvertDate2Type(now);

			//Date
			dpick_OGAC_YMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			now  = System.DateTime.Now.ToString("yyyyMMdd");
			dpick_OGAC_YMD.Text = MyComFunction.ConvertDate2Type(now);

			//Date
			dpick_RST_YMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			now  = System.DateTime.Now.ToString("yyyyMMdd");
			dpick_RST_YMD.Text = MyComFunction.ConvertDate2Type(now);

			//Setting Season
			dt_list = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(),"SEM15");
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Season, 1, 2);
			//cmb_Season.SelectedValue = "SP";

			//Year
			ClassLib.ComFunction.Set_Year(cmb_Year);


			chk_Del_Month.Checked = true;

			lbl_exp.Text = "※ Max Q'ty : ";

			//ClassLib.ComFunction.Get_Values(this, dpick_CSET_YMD.Name);
			//ClassLib.ComFunction.Get_Values(this, dpick_OGAC_YMD.Name);
			//ClassLib.ComFunction.Get_Values(this, dpick_RST_YMD.Name);

		}

	
		
			
		/// <summary>
		/// Check_Save : Check Save
		/// </summary>
		private bool Check_Save()
		{
			
			if(cmb_Season.SelectedIndex  == -1)  
			{ClassLib.ComFunction.Data_Message("Season", ClassLib.ComVar.MgsWrongInput ,this);  return false;}

			if(cmb_Year.SelectedIndex   == -1)  
			{ClassLib.ComFunction.Data_Message("Year", ClassLib.ComVar.MgsWrongInput ,this);  return false;}



			return true;

		}

		private void SB_Pop_GSSC()
		{
            //FlexOrder.ExpLoad.POP_EL_GSSC  pop_form = new ExpLoad.POP_EL_GSSC();

            //COM.ComVar.Parameter_PopUp = new string[] 
            //{
            //    cmb_Factory.SelectedValue.ToString(),
            //    fgrid_CS_N[fgrid_CS_N.Selection.r1,(int)ClassLib.TBSEM_OBS_BP.IxSTYLE_CD].ToString()
            //};
            //pop_form.ShowDialog();
		}
		

		private void Sb_Sum(C1FlexGrid arg_fgrid)
		{ 
			int col_fixed = arg_fgrid.Cols.Fixed, iSum = 0;	

			iSum = 0 ;
			for (int i =col_fixed ; i < arg_fgrid.Cols.Count ; i++)
			{
				iSum = iSum + Convert.ToInt32(fgrid_size[2,i]);
			}

			txt_TOT_Qty_1.Text = Convert.ToString(iSum);
			txt_TOT_Qty.Text = Convert.ToString(iSum);
		}


		
		/// <summary>
		/// Sb_Set_Size : Size Run Setting
		/// </summary>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Sb_Set_Size(C1FlexGrid arg_fgrid)
		{  
			DataTable dt_list;

			int iQty_Pos = 0, col_fixed = arg_fgrid.Cols.Fixed;
			arg_fgrid.Rows[0].TextAlign = TextAlignEnum.CenterCenter;
			arg_fgrid.Cols.Count  = col_fixed;

			dt_list = MyClassLib.Select_Gen_Size(cmb_Factory.SelectedValue.ToString(),
					  txt_Gen.Text.ToString(), txt_Pst_yn.Text.ToString());

			if (dt_list == null) return;

			arg_fgrid.Cols.Count   =  arg_fgrid.Cols.Count + dt_list.Rows.Count;
			for (int i = 0; i < dt_list.Rows.Count; i++)
			{
				arg_fgrid[iQty_Pos,col_fixed+i] =dt_list.Rows[i].ItemArray[0];
				arg_fgrid.Cols[col_fixed+i].Width = 50;
			}
			
			arg_fgrid.GetCellRange(0,0,0,fgrid_size.Cols.Count-1).StyleNew.BackColor  =  ClassLib.ComVar.Clr_Head_Crimson;
			arg_fgrid.GetCellRange(0,1,fgrid_size.Rows.Count-1,1).StyleNew.BackColor  =  ClassLib.ComVar.Clr_Head_Crimson;

		}
		

		/// <summary>
		/// get_Job_Div : Option별 Job_Div (임시처리)
		/// </summary>
		private string get_Job_Div()
		{
			if (chk_Del_Month.Checked && !chk_BP_NO.Checked && !chk_Region.Checked) 
				return "01";
			else 
			if (chk_Del_Month.Checked &&  chk_BP_NO.Checked && !chk_Region.Checked) 
				return "02";
			else 
			if (chk_Del_Month.Checked && !chk_BP_NO.Checked &&  chk_Region.Checked) 
				return "03";
			else 
			if (chk_Del_Month.Checked &&  chk_BP_NO.Checked &&  chk_Region.Checked) 
				return "04";
			else
				return "__";
		}



		/// <summary>
		/// Display_fgrid_CS_N : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_fgrid_CS_N(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1; 
 
			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
				arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = "";

				if (arg_fgrid[i + arg_fgrid.Rows.Fixed, (int)ClassLib.TBSEM_OBS_BP.IxSTYLE_YN].ToString() == "False")
					arg_fgrid.GetCellRange(i+arg_fgrid.Rows.Fixed, 0, i+arg_fgrid.Rows.Fixed, arg_fgrid.Cols.Count-1).StyleNew.ForeColor = ClassLib.ComVar.ClrError;
				else
					if (arg_fgrid[i + arg_fgrid.Rows.Fixed, (int)ClassLib.TBSEM_OBS_BP.IxGEN_YN].ToString()   == "False")
					arg_fgrid.GetCellRange(i+arg_fgrid.Rows.Fixed, 0, i+arg_fgrid.Rows.Fixed, arg_fgrid.Cols.Count-1).StyleNew.ForeColor = ClassLib.ComVar.ClrError;
				else
					if (arg_fgrid[i + arg_fgrid.Rows.Fixed, (int)ClassLib.TBSEM_OBS_BP.IxPST_YN].ToString()   == "False")
					arg_fgrid.GetCellRange(i+arg_fgrid.Rows.Fixed, 0, i+arg_fgrid.Rows.Fixed, arg_fgrid.Cols.Count-1).StyleNew.ForeColor = ClassLib.ComVar.ClrError;	
				else
					if (arg_fgrid[i + arg_fgrid.Rows.Fixed, (int)ClassLib.TBSEM_OBS_BP.IxJOB_DIV].ToString()   == "__")
					arg_fgrid[i + arg_fgrid.Rows.Fixed, (int)ClassLib.TBSEM_OBS_BP.IxJOB_DIV] = get_Job_Div();
			} 
			arg_fgrid.AutoSizeCols();
			arg_fgrid.Cols[(int)ClassLib.TBSEM_OBS_BP.IxBP_NO].Width = 70;

			cmb_Season.SelectedIndex   = -1;
			cmb_Year.SelectedIndex     = -1;

		}



		
		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_fgrid_CS_Y(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1; 
 
			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
				arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = "";

				int BP_Qty = Convert.ToInt32(arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSEM_OBS_CS.lxBP_QTY]);
				int CS_Qty = Convert.ToInt32(arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSEM_OBS_CS.lxCS_TOT_QTY]);

				//if ( BP_Qty < CS_Qty )
		        //	arg_fgrid.GetCellRange(i+arg_fgrid.Rows.Fixed, 0, i+arg_fgrid.Rows.Fixed, arg_fgrid.Cols.Count-1).StyleNew.ForeColor = ClassLib.ComVar.Clrwarn;

				if (arg_fgrid[i + arg_fgrid.Rows.Fixed, (int)ClassLib.TBSEM_OBS_CS.IxREQ_YN].ToString() == "True")
					arg_fgrid.GetCellRange(i+arg_fgrid.Rows.Fixed,1, i+arg_fgrid.Rows.Fixed, arg_fgrid.Cols.Count-1).StyleNew.BackColor = ClassLib.ComVar.ClrComplete;
			} 
			arg_fgrid.AutoSizeCols();

			arg_fgrid.Cols[(int)ClassLib.TBSEM_OBS_CS.IxOBS_ID].Width   = fgrid_CS_N.Cols[(int)ClassLib.TBSEM_OBS_BP.IxDEL_MONTH].Width;
			arg_fgrid.Cols[(int)ClassLib.TBSEM_OBS_CS.IxSTYLE_CD].Width = fgrid_CS_N.Cols[(int)ClassLib.TBSEM_OBS_BP.IxSTYLE_CD].Width;
			arg_fgrid.Cols[(int)ClassLib.TBSEM_OBS_CS.IxREGION].Width   = fgrid_CS_N.Cols[(int)ClassLib.TBSEM_OBS_BP.IxREGION].Width;
			arg_fgrid.Cols[(int)ClassLib.TBSEM_OBS_CS.IxBP_NO].Width    = fgrid_CS_N.Cols[(int)ClassLib.TBSEM_OBS_BP.IxBP_NO].Width;
			arg_fgrid.Cols[(int)ClassLib.TBSEM_OBS_CS.IxCS_QTY].Width   = fgrid_CS_N.Cols[(int)ClassLib.TBSEM_OBS_BP.IxPRD_QTY].Width;

		}


		/// <summary>
		/// Display_Grid : GSSC%, 수량 그리드에 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_Obs_Cs_Size(DataTable arg_dt, C1FlexGrid arg_fgrid,  string arg_flag)
		{
			int col_fixed = arg_fgrid.Cols.Fixed;

			int iTot_Qty = 0, iPos = 0;
			arg_fgrid.Rows[0].TextAlign = TextAlignEnum.CenterCenter;

			if (arg_flag  == "01")
				iPos =  1;
			else
			    iPos =  2;
				 

 
			// 사이즈 있는것 
			for (int i = 0; i < arg_dt.Rows.Count; i++)
			{
				for(int j = col_fixed; j <arg_fgrid.Cols.Count; j++)
				{   
					
					if (arg_fgrid[0,j].ToString() == arg_dt.Rows[i].ItemArray[0].ToString()) 
					{ 
						arg_fgrid[iPos,j] = arg_dt.Rows[i].ItemArray[1];

						iTot_Qty= iTot_Qty+Convert.ToInt32(arg_dt.Rows[i].ItemArray[1]);
					}
				}
			}

			// 사이즈 없는것
			for(int j = col_fixed; j <arg_fgrid.Cols.Count; j++)
			{   
					
				if (arg_fgrid[iPos,j] == null) 
				{ 
					arg_fgrid[iPos,j] = 0;

				}
			}

			txt_TOT_Qty_1.Text  = Convert.ToString(iTot_Qty) ;
				 
		}

		
		/// <summary>
		/// Display_Grid : Size Data
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_Grid_Size(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{
			int iTot_Qty = 0;
			arg_fgrid.Cols.Count = arg_dt.Rows.Count+2;
			arg_fgrid.Rows[0].TextAlign = TextAlignEnum.CenterCenter;
 
			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_fgrid.Cols[i+2].Width = 50;
				for(int j=0; j<arg_fgrid.Rows.Count-1; j++)
					arg_fgrid[j, i+2] = arg_dt.Rows[i].ItemArray[j].ToString();

				if (i < arg_dt.Rows.Count-1)
				{
					double dRate = Convert.ToDouble(arg_dt.Rows[i].ItemArray[1].ToString())/100;
					int    iQty  = (int)Math.Floor(Convert.ToDouble(txt_TOT_Qty_1.Text)*dRate);				
					iTot_Qty += iQty;					
					arg_fgrid[2, i+2] = iQty.ToString();
				}
				else
					arg_fgrid[2, i+2] = Convert.ToString(Convert.ToInt32(txt_TOT_Qty_1.Text)-iTot_Qty);
			}

			arg_fgrid.GetCellRange(0,0,0,arg_fgrid.Cols.Count-1).StyleNew.BackColor    =  ClassLib.ComVar.Clr_Head_Crimson;
			arg_fgrid.GetCellRange(0,1,fgrid_size.Rows.Count-1,1).StyleNew.BackColor  =ClassLib.ComVar.Clr_Head_Crimson;

		}

		/// <summary>
		/// Clear_CS_DPO_Infot : CS DPO Group Initial
		/// </summary>
		private void Clear_CS_DPO_Info()
		{
			txt_OBS_ID2.Clear();
			txt_BP_NO1.Clear();
			txt_Region1.Clear();
			txt_Region_nm1.Clear();
			txt_TOT_Qty_1.Clear();
			lbl_exp.Text = "※ Max Q'ty : ";

			fgrid_size.Cols.Count = 2;

			txt_Factory.Clear();
			txt_Fact_nm.Clear();
			txt_Style_cd.Clear();
			txt_Style_nm.Clear();
			txt_Gen.Clear();
			txt_Pst_yn.Clear();
			txt_TOT_Qty.Clear();
			txt_OBS_Type.Clear();
			txt_OBS_Type_nm.Clear();
			txt_OBS_ID.Clear();
			txt_BP_NO.Clear();
			txt_Region.Clear();
			txt_Region_nm.Clear();
			txt_Job_Div.Clear();
			txt_OBS_NU.Clear();
			txt_OBS_SEQ_NU.Clear();
			txt_CHG_NU.Clear();

			dpick_CSET_YMD.Text = DateTime.Now.ToString();
			dpick_RST_YMD.Text  = DateTime.Now.ToString();
			//tbtn_Save.Enabled = false;
		}

		#endregion 	

		#region DB 컨트롤
		/// <summary>
		/// Delete_SEM_OBS_CS : CS OBS 삭제
		/// </summary>
		private void Delete_SEM_OBS_CS()
		{	
			int iParm;
									
			iParm = 4;
			MyOraDB.ReDim_Parameter(iParm); 

			//Package Name
			string sproc_name  = "PKG_SEM_OBS_CS.DELETE_SEM_OBS_CS";
			MyOraDB.Process_Name= sproc_name;
		
			//Parameter Name
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OBS_NU";
			MyOraDB.Parameter_Name[2] = "ARG_OBS_SEQ_NU";
			MyOraDB.Parameter_Name[3] = "ARG_CHG_NU";
		
			//Parameter Type
			for (int i =0 ; i< iParm; i++)
				MyOraDB.Parameter_Type[i] = 1; 

			MyOraDB.Parameter_Values[0] = txt_Factory.Text;
			MyOraDB.Parameter_Values[1] = txt_OBS_NU.Text;
			MyOraDB.Parameter_Values[2] = txt_OBS_SEQ_NU.Text;
			MyOraDB.Parameter_Values[3] = txt_CHG_NU.Text;

			MyOraDB.Add_Modify_Parameter(true);	
			MyOraDB.Exe_Modify_Procedure();

			}

		/// <summary>
		/// Select_BP_List : Build Plan 리스트 찾기 
		/// </summary>
		private DataTable Select_BP_Data_List()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_OBS_CS.SELECT_SEM_BP";

			MyOraDB.ReDim_Parameter(7); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_JOB_DIV";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_DEL_MONTH";
			MyOraDB.Parameter_Name[3] = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[4] = "ARG_LIMIT";
			MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = get_Job_Div();
			MyOraDB.Parameter_Values[1] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = cmb_Del_Month.Text;
			MyOraDB.Parameter_Values[3] = txt_OBS_ID1.Text;			
			MyOraDB.Parameter_Values[4] = _Percent.ToString();
			MyOraDB.Parameter_Values[5] = txt_Style.Text;
			MyOraDB.Parameter_Values[6] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
		}

		

		/// <summary>
		/// Select_CS_List : OBS CS 리스트 찾기
		/// </summary>
		private DataTable Select_CS_Data_List()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_OBS_CS.SELECT_SEM_OBS_CS";

			MyOraDB.ReDim_Parameter(7); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_OBS_ID";			
			MyOraDB.Parameter_Name[3] = "ARG_DEL_MONTH";			
			MyOraDB.Parameter_Name[4] = "ARG_JOB_DIV";			
			MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";			
			MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;			
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;			
			MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_OBS_Type.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = txt_OBS_ID1.Text;			
			MyOraDB.Parameter_Values[3] = cmb_Del_Month.Text;
			MyOraDB.Parameter_Values[4] = get_Job_Div();
			MyOraDB.Parameter_Values[5] = txt_Style.Text;
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
		}


		/// <summary>
		/// Select_Size_List : SEM_GSSC의 사이즈 비율로 Display
		/// </summary>
		private bool Save_SEM_OBS_CS(string arg_proc_name, C1FlexGrid arg_Hfgrid, C1FlexGrid arg_Dfgrid)
		{

			DataSet ret;

			int col_ct = 27;	                        // 칼럼의 수 (헤드그리드컬럼수량 + 디테일그리드 수량(2) + (User, UPD_YMD) + Data_Flag(1))
			int Col_fixed = arg_Dfgrid.Cols.Fixed;		// 그리드 고정열 값
			int save_ct = arg_Dfgrid.Cols.Count-2;		// 저장 행 수

			int i;
			int para_ct = 0;				            // 파라미터 값의 저장 배열의 수
			int col;
			

			
			MyOraDB.ReDim_Parameter(col_ct);
			MyOraDB.Process_Name = arg_proc_name;

			// 파라미터 이름 설정	
			MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1]  = "ARG_DATA_FLAG";
			MyOraDB.Parameter_Name[2]  = "ARG_" + arg_Hfgrid[0, (int)ClassLib.TBSEM_OBS_CS.IxFACTORY].ToString(); 
			MyOraDB.Parameter_Name[3]  = "ARG_" + arg_Hfgrid[0, (int)ClassLib.TBSEM_OBS_CS.IxOBS_ID].ToString(); 
			MyOraDB.Parameter_Name[4]  = "ARG_" + arg_Hfgrid[0, (int)ClassLib.TBSEM_OBS_CS.IxSTYLE_CD].ToString(); 
			MyOraDB.Parameter_Name[5]  = "ARG_" + arg_Hfgrid[0, (int)ClassLib.TBSEM_OBS_CS.IxREGION].ToString(); 
			MyOraDB.Parameter_Name[6]  = "ARG_" + arg_Hfgrid[0, (int)ClassLib.TBSEM_OBS_CS.IxDEST].ToString(); 
			MyOraDB.Parameter_Name[7]  = "ARG_" + arg_Hfgrid[0, (int)ClassLib.TBSEM_OBS_CS.IxBP_NO].ToString(); 
			MyOraDB.Parameter_Name[8]  = "ARG_" + arg_Hfgrid[0, (int)ClassLib.TBSEM_OBS_CS.IxCS_QTY].ToString(); 
			MyOraDB.Parameter_Name[9]  = "ARG_" + arg_Hfgrid[0, (int)ClassLib.TBSEM_OBS_CS.IxOBS_NU].ToString(); 
			MyOraDB.Parameter_Name[10]  = "ARG_" + arg_Hfgrid[0, (int)ClassLib.TBSEM_OBS_CS.IxOBS_SEQ_NU].ToString(); 
			MyOraDB.Parameter_Name[11] = "ARG_" + arg_Hfgrid[0, (int)ClassLib.TBSEM_OBS_CS.IxCHG_NU].ToString(); 
			MyOraDB.Parameter_Name[12] = "ARG_" + arg_Hfgrid[0, (int)ClassLib.TBSEM_OBS_CS.IxJOB_DIV].ToString(); 
			MyOraDB.Parameter_Name[13] = "ARG_" + arg_Hfgrid[0, (int)ClassLib.TBSEM_OBS_CS.IxOBS_TYPE].ToString(); 
			MyOraDB.Parameter_Name[14] = "ARG_" + arg_Hfgrid[0, (int)ClassLib.TBSEM_OBS_CS.IxGEN].ToString(); 
			MyOraDB.Parameter_Name[15] = "ARG_" + arg_Hfgrid[0, (int)ClassLib.TBSEM_OBS_CS.IxPST_YN].ToString(); 
			MyOraDB.Parameter_Name[16] = "ARG_" + arg_Hfgrid[0, (int)ClassLib.TBSEM_OBS_CS.IxOGAC_YMD].ToString(); 
			MyOraDB.Parameter_Name[17] = "ARG_" + arg_Hfgrid[0, (int)ClassLib.TBSEM_OBS_CS.IxRTS_YMD].ToString(); 
			MyOraDB.Parameter_Name[18] = "ARG_" + arg_Hfgrid[0, (int)ClassLib.TBSEM_OBS_CS.IxCSETS_YMD].ToString(); 
			MyOraDB.Parameter_Name[19] = "ARG_" + arg_Hfgrid[0, (int)ClassLib.TBSEM_OBS_CS.IxCSETS_RSN].ToString(); 
			MyOraDB.Parameter_Name[20] = "ARG_CS_SIZE";
			MyOraDB.Parameter_Name[21] = "ARG_ORD_QTY";
			MyOraDB.Parameter_Name[22] = "ARG_SEASON";
			MyOraDB.Parameter_Name[23] = "ARG_SEASON_YEAR";
			MyOraDB.Parameter_Name[24] = "ARG_UPD_USER";
			MyOraDB.Parameter_Name[25] = "ARG_UPD_YMD";
			MyOraDB.Parameter_Name[26] = "ARG_UB_DIV";



			// 파라미터의 데이터 Type
			for(i = 0; i < col_ct ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 

			// 파라미터 값에 저장할 배열
			for (i =2 ; i < arg_Dfgrid.Cols.Count ; i++)
				MyOraDB.Parameter_Values  = new string[col_ct * (save_ct)];

			// 각 행의 값 Setting
			for(col = Col_fixed; col < arg_Dfgrid.Cols.Count; col++)
			{
				if (arg_Dfgrid[1, col] == null) return false;

				// 데이터값 설정
				if (col==Col_fixed)
					MyOraDB.Parameter_Values[para_ct+0]  = "H";
				else
					MyOraDB.Parameter_Values[para_ct+0]  = "B";

				MyOraDB.Parameter_Values[para_ct+1]  = _Date_Flag;
				MyOraDB.Parameter_Values[para_ct+2]  = txt_Factory.Text;
				MyOraDB.Parameter_Values[para_ct+3]  = txt_OBS_ID.Text; 
				MyOraDB.Parameter_Values[para_ct+4]  = txt_Style_cd.Text; 
				MyOraDB.Parameter_Values[para_ct+5]  = txt_Region.Text; 
				MyOraDB.Parameter_Values[para_ct+6]  = txt_Dest.Text; 
				MyOraDB.Parameter_Values[para_ct+7]  = txt_BP_NO.Text; 
				MyOraDB.Parameter_Values[para_ct+8]  = txt_TOT_Qty.Text;
				MyOraDB.Parameter_Values[para_ct+9]  = txt_OBS_NU.Text;
				MyOraDB.Parameter_Values[para_ct+10]  = txt_OBS_SEQ_NU.Text;
				MyOraDB.Parameter_Values[para_ct+11] = txt_CHG_NU.Text;
				MyOraDB.Parameter_Values[para_ct+12] = txt_Job_Div.Text;
				MyOraDB.Parameter_Values[para_ct+13] = txt_OBS_Type.Text;
				MyOraDB.Parameter_Values[para_ct+14] = txt_Gen.Text;
				MyOraDB.Parameter_Values[para_ct+15] = txt_Pst_yn.Text;
				MyOraDB.Parameter_Values[para_ct+16] = Convert.ToDateTime(dpick_OGAC_YMD.Text).ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[para_ct+17] = Convert.ToDateTime(dpick_RST_YMD.Text).ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[para_ct+18] = Convert.ToDateTime(dpick_CSET_YMD.Text).ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[para_ct+19] = txt_CSET_RSN.Text;
				MyOraDB.Parameter_Values[para_ct+20] = arg_Dfgrid[0,col].ToString();                        //SEM_OBS_CS_SIZE의 CS_SIZE 컬럼
				MyOraDB.Parameter_Values[para_ct+21] = arg_Dfgrid[2,col].ToString();                        //SEM_OBS_CS_SIZE의 ORD_QTY 컬럼
				MyOraDB.Parameter_Values[para_ct+22] = cmb_Season.SelectedValue.ToString();                       //SEASON
				MyOraDB.Parameter_Values[para_ct+23] = cmb_Year.Columns[0].Text ;                         //SEASON_YEAR
				MyOraDB.Parameter_Values[para_ct+24] = ClassLib.ComVar.This_User;                           //UPD_USER
				MyOraDB.Parameter_Values[para_ct+25] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); //UPD_YMD
				MyOraDB.Parameter_Values[para_ct+26] = "";
				para_ct += col_ct;
				
			}
						
			MyOraDB.Add_Modify_Parameter(true);  // 파라미터 데이터를 DataSet에 추가

			ret =  MyOraDB.Exe_Modify_Procedure();	

			return true;

		}


		/// <summary>
		/// Select_Size_List : SEM_GSSC의 사이즈 비율로 Display
		/// </summary>
		private DataTable Select_Size_List()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_OBS_CS.SELECT_SEM_GSSC";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = txt_Style_cd.Text;
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name];

		}


		private DataTable Select_Obs_Cs_Size()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_OBS_CS.SELECT_OBS_CS_SIZE";

			MyOraDB.ReDim_Parameter(5); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OBS_NU";
			MyOraDB.Parameter_Name[2] = "ARG_OBS_SEQ_NU";
			MyOraDB.Parameter_Name[3] = "ARG_CHG_NU";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = txt_OBS_NU.Text;
			MyOraDB.Parameter_Values[2] = txt_OBS_SEQ_NU.Text;
			MyOraDB.Parameter_Values[3] = txt_CHG_NU.Text;
			MyOraDB.Parameter_Values[4] = ""; 

			MyOraDB.Add_Select_Parameter(true);

			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
		
			return ds_ret.Tables[process_name];
		}



		private DataTable Select_JOB_DIV()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_OBS_CS.SELECT_JOB_DIV";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";			
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = txt_OBS_ID1.Text;			
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
		}


		#endregion 

		#region 이벤트 처리  
			#region  버튼 이벤트
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_CS_Y.Rows.Count = _Rowfixed;
			fgrid_CS_N.Rows.Count = _Rowfixed;
			fgrid_size.Cols.Count = 2;

			cmb_Factory.SelectedValue  = ClassLib.ComVar.This_Factory;
			cmb_OBS_Type.SelectedIndex = 0;
			cmb_Del_Month.SelectedIndex = 5;
			txt_OBS_ID1.Clear();
			
			chk_Del_Month.Checked = true;
			chk_BP_NO.Checked     = false;
			chk_Region.Checked    = false;
		
			Clear_CS_DPO_Info();
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				DataTable dt_ret;
				Clear_CS_DPO_Info();

				//기존등록된(SEM_OBS_CS) 가DPO의 JOB_DIV Check(1OBS_NO : 1JOB_DIV)
				dt_ret = Select_JOB_DIV();		
				if ((dt_ret.Rows.Count != 0) && (dt_ret.Rows[0].ItemArray[0].ToString() != get_Job_Div()) )
				{
					MessageBox.Show("Job Division(Option) Error!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning) ;
					tbtn_New_Click(null, null);
					return;
				}

				//SEM_OBS_CS 정보를 읽어온다
				dt_ret = Select_CS_Data_List();
				Display_fgrid_CS_Y(dt_ret, fgrid_CS_Y);  //tbtn_Save.Enabled = false;

				//SEM_BP 정보를 읽어온다
				if (cmb_OBS_Type.SelectedValue.ToString() != "FT") return;
				dt_ret = Select_BP_Data_List();
				Display_fgrid_CS_N(dt_ret, fgrid_CS_N);

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch,this);


			}
			catch 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch,this);
			}							
		}

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			try
			{
				//해당오더의 Max Q'ty보다 적은 수량만 등록을 할수 있음
				int i = Convert.ToInt32(lbl_exp.Text.IndexOf("=", 0).ToString());
				string sTOT_Qty = lbl_exp.Text.Substring(i+1, lbl_exp.Text.Length-(i+1)).Trim();

				if ( Convert.ToInt32(txt_TOT_Qty_1.Text) > Convert.ToInt32(sTOT_Qty) )
				{
					MessageBox.Show("Total quantity("+txt_TOT_Qty_1.Text+") is over the max quantity("+sTOT_Qty+").",
                                    "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning) ;

					txt_TOT_Qty_1.Text = sTOT_Qty;
					return;
				}

				//SEM_BP 정보를 SEM_GSSC의 사이즈 비율로 Size run Display..
				DataTable dt_ret;

				dt_ret = Select_Size_List();

				Display_Grid_Size(dt_ret, fgrid_size);

				txt_TOT_Qty.Text = txt_TOT_Qty_1.Text;

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch,this);

				//tbtn_Save.Enabled = true;
			}
			catch
			{
				//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch,this);
			}			
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{				
				//btn_Apply_Click(null, null);  //혹시나 총 수량을 변경하고 APPLY 버튼을 클릭하지 않았을 경우 대비....^^;  -Park-
				DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
				if(DialogResult.Yes != dr) return;

				if ((txt_OBS_NU.Text != "") &&
					(fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxSYMD].ToString()
					== System.DateTime.Now.ToString("yyyyMMdd") &&
					(fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxREQ_YN].ToString()  == "True")))
				{
					MessageBox.Show("Today,Order can not be changed.. Please Try it tomorrow!!",	
									"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning) ;
					return;
				}


				if (Check_Save() != true)
					return;
				else
				{
					Save_SEM_OBS_CS("PKG_SEM_OBS_CS.SAVE_SEM_OBS_CS", fgrid_CS_Y, fgrid_size);	
					tbtn_Search_Click(null, null);
				}


				
			}
			catch 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave,this);
			}			
		}

		private void cmb_Del_Month_TextChanged(object sender, System.EventArgs e)
		{   
			if (cmb_Del_Month.SelectedIndex == 0)
			{
				txt_OBS_ID1.Clear();
			}
			else
			{
				txt_OBS_ID1.Text = ClassLib.ComFunction.Convert_ToDate(cmb_Del_Month.Text).AddMonths(-2).ToString("yyMM") + 
			 		               cmb_Del_Month.Text.Substring(4,2);						
			} 
		}
	
		
		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{				
				DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete , this);
				if(DialogResult.Yes != dr) return;

				if ((fgrid_CS_Y[fgrid_CS_Y.Selection.r1 ,(int)ClassLib.TBSEM_OBS_CS.IxREQ_YN].ToString()  == "False") &&								(fgrid_CS_Y[fgrid_CS_Y.Selection.r1 ,(int)ClassLib.TBSEM_OBS_CS.IxOA_NU_AFT].ToString() =="__________") &&
					(fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxOA_NU_BEF].ToString() =="__________") )
					Delete_SEM_OBS_CS();	
				else
					MessageBox.Show("This Order is impossible to delete",	"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning) ;

				tbtn_Search_Click(null, null);

			}
			catch 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotDelete,this);
			}	
		}

		#endregion 

			#region 기타 이벤트
		private void fgrid_size_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		   
			Sb_Sum(fgrid_size);

		}

		private void btn_Apply_MouseHover(object sender, System.EventArgs e)
		{
			btn_Apply.ImageIndex = 1;		
		}

		private void btn_Apply_MouseLeave(object sender, System.EventArgs e)
		{
			btn_Apply.ImageIndex = 0;				
		}

		private void chk_Del_Month_Click(object sender, System.EventArgs e)
		{
			chk_Del_Month.Checked = true;
		}

		private void fgrid_CS_N_DoubleClick(object sender, System.EventArgs e)
		{   
			
			if (cmb_OBS_Type.SelectedValue.ToString() !=  "FT")  return;

			if ( (fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxSTYLE_YN].ToString() == "False") ||
				 (fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxGEN_YN].ToString()   == "False") ||
				 (fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxPST_YN].ToString()   == "False")  )
			{
				MessageBox.Show("Not registered GSSC information!!",	"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning) ;				
				return;
			}

			Clear_CS_DPO_Info();

			txt_OBS_ID2.Text    = txt_OBS_ID1.Text;
			txt_BP_NO1.Text     = fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxBP_NO].ToString();
			txt_Region1.Text    = fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxREGION].ToString();
			txt_Region_nm1.Text = fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxREGION_NM].ToString();
			txt_TOT_Qty_1.Text  = fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxPRD_QTY].ToString();

			int iTotqty  = Convert.ToInt32(fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxTOT_QTY].ToString());			
			double d_per = _Percent * 0.01;

			// EX) ※ Max Q'ty : (100 X 0.8) - 50  = 30
			lbl_exp.Text = "※ Max Q'ty : (" + 
				           fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxTOT_QTY].ToString() + " X " +
				           d_per.ToString() + ") - " +
				           fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxCS_QTY].ToString() + " = " +
				           fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxPRD_QTY].ToString();			

			//Master Info. Display
			int cs_qty = Convert.ToInt32(fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxCS_QTY].ToString());
			if (cs_qty == 0)
				_Date_Flag           = ClassLib.ComVar.Divflag_NEW; // 
			else
				_Date_Flag           = ClassLib.ComVar.Divflag_ADD; // 

			txt_Factory.Text     = fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxFACTORY].ToString();
			txt_Fact_nm.Text     = cmb_Factory.Columns[1].Text;
			txt_Style_cd.Text    = fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxSTYLE_CD].ToString();
			txt_Style_nm.Text    = fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxSTYLE_NAME].ToString();
			txt_Gen.Text         = fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxGEN].ToString();
			txt_Pst_yn.Text      = fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxPRESTO].ToString();
			txt_TOT_Qty.Text     = fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxTOT_QTY].ToString();
			txt_OBS_Type.Text    = cmb_OBS_Type.SelectedValue.ToString();
			txt_OBS_Type_nm.Text = cmb_OBS_Type.Columns[1].Text;
			txt_OBS_ID.Text      = txt_OBS_ID2.Text;
			txt_BP_NO.Text       = txt_BP_NO1.Text;
			txt_Region.Text      = txt_Region1.Text;
			txt_Region_nm.Text   = txt_Region_nm1.Text;
			txt_Job_Div.Text     = fgrid_CS_N[fgrid_CS_N.Selection.r1, (int)ClassLib.TBSEM_OBS_BP.IxJOB_DIV].ToString(); 			

			btn_Apply_Click(null, null);

		}

		private void fgrid_CS_Y_DoubleClick(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			//Message  Display
			if (fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxREQ_YN].ToString() == "True")
			{   
				if (fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxSYMD].ToString()
					== System.DateTime.Now.ToString("yyyyMMdd")&&
					(fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxREQ_YN].ToString()  == "True"))
				{
					MessageBox.Show("Already requested order!! Please Try it tomorrow!!",	"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning) ;
					
				}
				else
				{
					MessageBox.Show("Change data.. Please You control this data by OA Process",	"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning) ;
				}
					
			}

			Clear_CS_DPO_Info();

			txt_OBS_ID2.Text    = txt_OBS_ID1.Text;
			txt_BP_NO1.Text     = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxBP_NO].ToString();
			txt_Region1.Text    = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxREGION].ToString();
			txt_Region_nm1.Text = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxREGION_NM].ToString();
			txt_TOT_Qty_1.Text  = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxCS_QTY].ToString();

			int iqty1  = Convert.ToInt32(fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.lxCS_TOT_QTY].ToString())-
				         Convert.ToInt32(fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxCS_QTY].ToString());

			double d_per = _Percent * 0.01;

			double iqty2 = Math.Floor(Convert.ToInt32(fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.lxBP_QTY].ToString()) * d_per) - iqty1;

			// ex) ※ Max Q'ty : (100 X 0.8) - 50  = 30
			lbl_exp.Text = "※ Max Q'ty : (" + 
			 	           fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.lxBP_QTY].ToString() + " X " +
				           d_per.ToString() + ") - " +
				           iqty1.ToString() + " = " + iqty2.ToString();

			//Master Info. Display
		    _Date_Flag           = ClassLib.ComVar.Divflag_CHG;
			txt_Factory.Text     = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxFACTORY].ToString();
			txt_Fact_nm.Text     = cmb_Factory.Columns[1].Text;
			txt_Style_cd.Text    = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxSTYLE_CD].ToString();
			txt_Style_nm.Text    = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxSTYLE_NM].ToString();
			txt_Gen.Text         = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxGEN].ToString();
			txt_Pst_yn.Text      = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxPST_YN].ToString();
			txt_TOT_Qty.Text     = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxCS_QTY].ToString();
			txt_OBS_Type.Text    = cmb_OBS_Type.SelectedValue.ToString();
			txt_OBS_Type_nm.Text = cmb_OBS_Type.Columns[1].Text;
			txt_OBS_ID.Text      = txt_OBS_ID2.Text;
			txt_BP_NO.Text       = txt_BP_NO1.Text;
			txt_Region.Text      = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxREGION].ToString();
			txt_Region_nm.Text   = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxREGION_NM].ToString();
			txt_Dest.Text        = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxDEST].ToString();
			txt_Dest_nm.Text     = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxDEST_NM].ToString();
			txt_Job_Div.Text     = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxJOB_DIV].ToString();

			txt_OBS_NU.Text      = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxOBS_NU].ToString();
			txt_OBS_SEQ_NU.Text  = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxOBS_SEQ_NU].ToString();
			txt_CHG_NU.Text      = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxCHG_NU].ToString();
			
			//Size Run Setting
			Sb_Set_Size(fgrid_size);
            
			//GSSC Setting
			dt_ret = Select_Size_List();
			Display_Obs_Cs_Size(dt_ret, fgrid_size,"01");

			//CS OBS Setting
			dt_ret  = Select_Obs_Cs_Size();
			Display_Obs_Cs_Size(dt_ret ,fgrid_size,"02");
			
			//First Position
			int iCol=2, iRow=2;
			for (int i =iCol  ; i<fgrid_size.Cols.Count ;i++)
			{ 
				if (fgrid_size[iRow,i].ToString() != "0")
				{
					fgrid_size.LeftCol = i; return;
				}
			   
			}


			txt_Style.Focus();

			ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch,this);

		}


		private void fgrid_CS_Y_Click(object sender, System.EventArgs e)
		{ 
			for (int i =_Rowfixed ; i<fgrid_CS_N.Rows.Count  ; i++)
			{   
				if (fgrid_CS_N[i,(int)ClassLib.TBSEM_OBS_BP.IxSTYLE_CD].ToString() 
					==fgrid_CS_Y[fgrid_CS_Y.Selection.r1,(int)ClassLib.TBSEM_OBS_CS.IxSTYLE_CD].ToString())
				{
					fgrid_CS_N.TopRow = i;
					fgrid_CS_N.Select(i, 0, i, fgrid_CS_N.Cols.Count-1, false);

					return;
				}
			}
		
		}
	
  


		private void dpick_OGAC_YMD_ValueChanged(object sender, System.EventArgs e)
		{
			//ClassLib.ComFunction.Set_Values(this, dpick_OGAC_YMD.Name);
		}

		private void dpick_RST_YMD_ValueChanged(object sender, System.EventArgs e)
		{
			//ClassLib.ComFunction.Set_Values(this, dpick_RST_YMD.Name);
		}

		private void dpick_CSET_YMD_ValueChanged(object sender, System.EventArgs e)
		{
			//ClassLib.ComFunction.Set_Values(this, dpick_CSET_YMD.Name);
		}

		#endregion

		#endregion 	

		#region 콘텍스트 메뉴
		private void ctm_Request_Click(object sender, System.EventArgs e)
		{

			FlexOrder.ExpOBSCS.Form_EC_Req frm = new ExpOBSCS.Form_EC_Req();
			frm.Show();

		}

		private void ctm_OBS_Sel_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBS.Form_EO_SRCH frm = new ExpOBS.Form_EO_SRCH();  
			frm.Show();
		}


		private void ctm_OBS_HistSel_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBS.Form_EO_Hist frm = new ExpOBS.Form_EO_Hist();  
			frm.Show();
		}

	
		private void ctm_GSSC_Information_Click(object sender, System.EventArgs e)
		{
			SB_Pop_GSSC();
		}
		#endregion

		private void Form_EC_CRT_Load(object sender, System.EventArgs e)
		{
			Init_Form(); 
		}


	}
}

