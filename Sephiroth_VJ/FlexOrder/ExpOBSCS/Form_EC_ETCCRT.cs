using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.Data;

namespace FlexOrder.ExpOBSCS
{
	public class  Form_EC_ETCCRT : COM.OrderWinForm.Form_Top
	{   
		#region 컨트롤 정의 및 리소스 정리
		private System.Windows.Forms.Panel pnl_main;
		public System.Windows.Forms.Panel pnl_search_detail;
		public System.Windows.Forms.Panel pnl_search_main;
		private System.Windows.Forms.Panel pnl_Search1_Image;
		private System.Windows.Forms.TextBox txt_Style;
		private System.Windows.Forms.Label lbl_Style;
		private C1.Win.C1List.C1Combo cmb_OBS_Type;
		private System.Windows.Forms.Label lbl_Factory;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_OBS_Type;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Panel pnl_1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel pnl_2;
		private System.Windows.Forms.Panel pnl_size;
		private System.Windows.Forms.GroupBox groupBox2;
		public COM.FSP fgrid_size;
		public System.Windows.Forms.Panel pnl_save_detail;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt_OBS_SEQ_NU;
		private System.Windows.Forms.TextBox txt_CHG_NU;
		private System.Windows.Forms.TextBox txt_OBS_NU;
		private System.Windows.Forms.TextBox txt_CSET_RSN;
		private System.Windows.Forms.DateTimePicker dpick_CSET_YMD;
		private System.Windows.Forms.DateTimePicker dpick_RST_YMD;
		private System.Windows.Forms.TextBox txt_Job_Div;
		private System.Windows.Forms.TextBox txt_TOT_Qty;
		private System.Windows.Forms.TextBox txt_Pst_yn;
		private System.Windows.Forms.TextBox txt_Gen;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel pnl_search_cs;
		private System.Windows.Forms.GroupBox gb_CS_N;
		private C1.Win.C1List.C1Combo cmb_Factory_i;
		private C1.Win.C1List.C1Combo cmb_Style_i;
		private C1.Win.C1List.C1Combo cmb_Region;
		public COM.FSP fgrid_CS_Y;
		private C1.Win.C1List.C1Combo cmb_OBS_Type_i;
		private C1.Win.C1List.C1Combo cmb_OBS_ID_i;
		private System.Windows.Forms.DateTimePicker dpick_Lasting;
		private System.Windows.Forms.Label lbl_Ogac;
		private System.Windows.Forms.DateTimePicker dpick_OGAC_YMD;
		private C1.Win.C1List.C1Combo cmb_OBS_ID;
		private System.Windows.Forms.Label lbl_Obs_Id;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox txt_Style_i;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem ctm_CSOBS_Req;
		private System.Windows.Forms.MenuItem ctm_CSOBS_Sel;
		private System.Windows.Forms.MenuItem ctm_CSOBS_HistSel;
		private System.Windows.Forms.MenuItem ctm_Bar_First;
		private C1.Win.C1List.C1Combo cmb_Dest;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbl_Year;
		private System.Windows.Forms.Label lbl_Season;
		private C1.Win.C1List.C1Combo cmb_Year;
		private C1.Win.C1List.C1Combo cmb_Season;
		private C1.Win.C1List.C1Combo cmb_Component;
		private System.Windows.Forms.Label lbl_UB;
		private System.ComponentModel.IContainer components = null;
	
		public Form_EC_ETCCRT()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EC_ETCCRT));
			this.pnl_main = new System.Windows.Forms.Panel();
			this.pnl_2 = new System.Windows.Forms.Panel();
			this.pnl_size = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.fgrid_size = new COM.FSP();
			this.pnl_save_detail = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmb_Year = new C1.Win.C1List.C1Combo();
			this.cmb_Season = new C1.Win.C1List.C1Combo();
			this.lbl_Year = new System.Windows.Forms.Label();
			this.lbl_Season = new System.Windows.Forms.Label();
			this.cmb_Dest = new C1.Win.C1List.C1Combo();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_Style_i = new System.Windows.Forms.TextBox();
			this.lbl_Ogac = new System.Windows.Forms.Label();
			this.dpick_OGAC_YMD = new System.Windows.Forms.DateTimePicker();
			this.cmb_Region = new C1.Win.C1List.C1Combo();
			this.dpick_Lasting = new System.Windows.Forms.DateTimePicker();
			this.cmb_OBS_ID_i = new C1.Win.C1List.C1Combo();
			this.cmb_OBS_Type_i = new C1.Win.C1List.C1Combo();
			this.cmb_Style_i = new C1.Win.C1List.C1Combo();
			this.cmb_Factory_i = new C1.Win.C1List.C1Combo();
			this.txt_OBS_SEQ_NU = new System.Windows.Forms.TextBox();
			this.txt_CHG_NU = new System.Windows.Forms.TextBox();
			this.txt_OBS_NU = new System.Windows.Forms.TextBox();
			this.txt_CSET_RSN = new System.Windows.Forms.TextBox();
			this.dpick_CSET_YMD = new System.Windows.Forms.DateTimePicker();
			this.dpick_RST_YMD = new System.Windows.Forms.DateTimePicker();
			this.txt_Job_Div = new System.Windows.Forms.TextBox();
			this.txt_TOT_Qty = new System.Windows.Forms.TextBox();
			this.txt_Pst_yn = new System.Windows.Forms.TextBox();
			this.txt_Gen = new System.Windows.Forms.TextBox();
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.pnl_1 = new System.Windows.Forms.Panel();
			this.pnl_search_detail = new System.Windows.Forms.Panel();
			this.pnl_search_cs = new System.Windows.Forms.Panel();
			this.gb_CS_N = new System.Windows.Forms.GroupBox();
			this.fgrid_CS_Y = new COM.FSP();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.ctm_CSOBS_Req = new System.Windows.Forms.MenuItem();
			this.ctm_Bar_First = new System.Windows.Forms.MenuItem();
			this.ctm_CSOBS_Sel = new System.Windows.Forms.MenuItem();
			this.ctm_CSOBS_HistSel = new System.Windows.Forms.MenuItem();
			this.pnl_search_main = new System.Windows.Forms.Panel();
			this.pnl_Search1_Image = new System.Windows.Forms.Panel();
			this.txt_Style = new System.Windows.Forms.TextBox();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.cmb_OBS_ID = new C1.Win.C1List.C1Combo();
			this.cmb_OBS_Type = new C1.Win.C1List.C1Combo();
			this.lbl_Obs_Id = new System.Windows.Forms.Label();
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
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.cmb_Component = new C1.Win.C1List.C1Combo();
			this.lbl_UB = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_main.SuspendLayout();
			this.pnl_2.SuspendLayout();
			this.pnl_size.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_size)).BeginInit();
			this.pnl_save_detail.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Year)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Dest)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Region)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID_i)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type_i)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Style_i)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_i)).BeginInit();
			this.pnl_1.SuspendLayout();
			this.pnl_search_detail.SuspendLayout();
			this.pnl_search_cs.SuspendLayout();
			this.gb_CS_N.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_CS_Y)).BeginInit();
			this.pnl_search_main.SuspendLayout();
			this.pnl_Search1_Image.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Component)).BeginInit();
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
			this.c1ToolBar1.Name = "c1ToolBar1";
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
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// pnl_main
			// 
			this.pnl_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_main.BackColor = System.Drawing.Color.White;
			this.pnl_main.Controls.Add(this.pnl_2);
			this.pnl_main.Controls.Add(this.splitter1);
			this.pnl_main.Controls.Add(this.pnl_1);
			this.pnl_main.Location = new System.Drawing.Point(0, 64);
			this.pnl_main.Name = "pnl_main";
			this.pnl_main.Size = new System.Drawing.Size(1016, 584);
			this.pnl_main.TabIndex = 45;
			// 
			// pnl_2
			// 
			this.pnl_2.Controls.Add(this.pnl_size);
			this.pnl_2.Controls.Add(this.pnl_save_detail);
			this.pnl_2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_2.DockPadding.Bottom = 8;
			this.pnl_2.DockPadding.Right = 8;
			this.pnl_2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_2.Location = new System.Drawing.Point(355, 0);
			this.pnl_2.Name = "pnl_2";
			this.pnl_2.Size = new System.Drawing.Size(661, 584);
			this.pnl_2.TabIndex = 47;
			// 
			// pnl_size
			// 
			this.pnl_size.Controls.Add(this.groupBox2);
			this.pnl_size.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_size.DockPadding.All = 8;
			this.pnl_size.Location = new System.Drawing.Point(0, 0);
			this.pnl_size.Name = "pnl_size";
			this.pnl_size.Size = new System.Drawing.Size(653, 184);
			this.pnl_size.TabIndex = 51;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.BackColor = System.Drawing.Color.White;
			this.groupBox2.Controls.Add(this.fgrid_size);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.ForeColor = System.Drawing.Color.Black;
			this.groupBox2.Location = new System.Drawing.Point(0, 75);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(640, 104);
			this.groupBox2.TabIndex = 136;
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
			this.fgrid_size.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_size.ForeColor = System.Drawing.Color.Black;
			this.fgrid_size.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_size.Location = new System.Drawing.Point(3, 18);
			this.fgrid_size.Name = "fgrid_size";
			this.fgrid_size.Rows.Count = 3;
			this.fgrid_size.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.fgrid_size.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_size.Size = new System.Drawing.Size(634, 83);
			this.fgrid_size.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_size.TabIndex = 36;
			this.fgrid_size.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_size_AfterEdit);
			// 
			// pnl_save_detail
			// 
			this.pnl_save_detail.BackColor = System.Drawing.Color.White;
			this.pnl_save_detail.Controls.Add(this.groupBox1);
			this.pnl_save_detail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_save_detail.DockPadding.Bottom = 8;
			this.pnl_save_detail.DockPadding.Left = 8;
			this.pnl_save_detail.DockPadding.Right = 8;
			this.pnl_save_detail.DockPadding.Top = 1;
			this.pnl_save_detail.Location = new System.Drawing.Point(0, 0);
			this.pnl_save_detail.Name = "pnl_save_detail";
			this.pnl_save_detail.Size = new System.Drawing.Size(653, 576);
			this.pnl_save_detail.TabIndex = 50;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.cmb_Year);
			this.groupBox1.Controls.Add(this.cmb_Season);
			this.groupBox1.Controls.Add(this.lbl_Year);
			this.groupBox1.Controls.Add(this.lbl_Season);
			this.groupBox1.Controls.Add(this.cmb_Dest);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txt_Style_i);
			this.groupBox1.Controls.Add(this.lbl_Ogac);
			this.groupBox1.Controls.Add(this.dpick_OGAC_YMD);
			this.groupBox1.Controls.Add(this.cmb_Region);
			this.groupBox1.Controls.Add(this.dpick_Lasting);
			this.groupBox1.Controls.Add(this.cmb_OBS_ID_i);
			this.groupBox1.Controls.Add(this.cmb_OBS_Type_i);
			this.groupBox1.Controls.Add(this.cmb_Style_i);
			this.groupBox1.Controls.Add(this.cmb_Factory_i);
			this.groupBox1.Controls.Add(this.txt_OBS_SEQ_NU);
			this.groupBox1.Controls.Add(this.txt_CHG_NU);
			this.groupBox1.Controls.Add(this.txt_OBS_NU);
			this.groupBox1.Controls.Add(this.txt_CSET_RSN);
			this.groupBox1.Controls.Add(this.dpick_CSET_YMD);
			this.groupBox1.Controls.Add(this.dpick_RST_YMD);
			this.groupBox1.Controls.Add(this.txt_Job_Div);
			this.groupBox1.Controls.Add(this.txt_TOT_Qty);
			this.groupBox1.Controls.Add(this.txt_Pst_yn);
			this.groupBox1.Controls.Add(this.txt_Gen);
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
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.lbl_UB);
			this.groupBox1.Controls.Add(this.cmb_Component);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(0, 135);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(637, 384);
			this.groupBox1.TabIndex = 134;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "§ Master Info.";
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
			this.cmb_Year.Location = new System.Drawing.Point(438, 157);
			this.cmb_Year.MatchEntryTimeout = ((long)(2000));
			this.cmb_Year.MaxDropDownItems = ((short)(5));
			this.cmb_Year.MaxLength = 32767;
			this.cmb_Year.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Year.Name = "cmb_Year";
			this.cmb_Year.PartialRightColumn = false;
			this.cmb_Year.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"ut><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Year.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Year.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Year.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Year.Size = new System.Drawing.Size(140, 20);
			this.cmb_Year.TabIndex = 223;
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
			this.cmb_Season.Location = new System.Drawing.Point(438, 135);
			this.cmb_Season.MatchEntryTimeout = ((long)(2000));
			this.cmb_Season.MaxDropDownItems = ((short)(5));
			this.cmb_Season.MaxLength = 32767;
			this.cmb_Season.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Season.Name = "cmb_Season";
			this.cmb_Season.PartialRightColumn = false;
			this.cmb_Season.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"ut><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Season.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Season.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Season.Size = new System.Drawing.Size(140, 20);
			this.cmb_Season.TabIndex = 222;
			// 
			// lbl_Year
			// 
			this.lbl_Year.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Year.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Year.ImageIndex = 1;
			this.lbl_Year.ImageList = this.img_Label;
			this.lbl_Year.Location = new System.Drawing.Point(336, 157);
			this.lbl_Year.Name = "lbl_Year";
			this.lbl_Year.Size = new System.Drawing.Size(100, 21);
			this.lbl_Year.TabIndex = 179;
			this.lbl_Year.Text = "Year";
			this.lbl_Year.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Season
			// 
			this.lbl_Season.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Season.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Season.ImageIndex = 1;
			this.lbl_Season.ImageList = this.img_Label;
			this.lbl_Season.Location = new System.Drawing.Point(336, 135);
			this.lbl_Season.Name = "lbl_Season";
			this.lbl_Season.Size = new System.Drawing.Size(100, 21);
			this.lbl_Season.TabIndex = 178;
			this.lbl_Season.Text = "Season";
			this.lbl_Season.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Dest
			// 
			this.cmb_Dest.AddItemCols = 0;
			this.cmb_Dest.AddItemSeparator = ';';
			this.cmb_Dest.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Dest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Dest.Caption = "";
			this.cmb_Dest.CaptionHeight = 17;
			this.cmb_Dest.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Dest.ColumnCaptionHeight = 18;
			this.cmb_Dest.ColumnFooterHeight = 18;
			this.cmb_Dest.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Dest.ContentHeight = 15;
			this.cmb_Dest.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Dest.EditorBackColor = System.Drawing.Color.White;
			this.cmb_Dest.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Dest.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Dest.EditorHeight = 15;
			this.cmb_Dest.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Dest.GapHeight = 2;
			this.cmb_Dest.ItemHeight = 15;
			this.cmb_Dest.Location = new System.Drawing.Point(109, 224);
			this.cmb_Dest.MatchEntryTimeout = ((long)(2000));
			this.cmb_Dest.MaxDropDownItems = ((short)(5));
			this.cmb_Dest.MaxLength = 32767;
			this.cmb_Dest.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Dest.Name = "cmb_Dest";
			this.cmb_Dest.PartialRightColumn = false;
			this.cmb_Dest.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Dest.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Dest.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Dest.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Dest.Size = new System.Drawing.Size(210, 19);
			this.cmb_Dest.TabIndex = 177;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label5.Font = new System.Drawing.Font("Verdana", 8F);
			this.label5.ImageIndex = 2;
			this.label5.ImageList = this.img_Label;
			this.label5.Location = new System.Drawing.Point(8, 224);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 21);
			this.label5.TabIndex = 176;
			this.label5.Text = "Destination";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Style_i
			// 
			this.txt_Style_i.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Style_i.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_i.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Style_i.Location = new System.Drawing.Point(109, 54);
			this.txt_Style_i.MaxLength = 100;
			this.txt_Style_i.Name = "txt_Style_i";
			this.txt_Style_i.Size = new System.Drawing.Size(105, 20);
			this.txt_Style_i.TabIndex = 175;
			this.txt_Style_i.Text = "";
			this.txt_Style_i.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Style_i_KeyDown);
			// 
			// lbl_Ogac
			// 
			this.lbl_Ogac.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Ogac.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Ogac.ImageIndex = 0;
			this.lbl_Ogac.ImageList = this.img_Label;
			this.lbl_Ogac.Location = new System.Drawing.Point(336, 178);
			this.lbl_Ogac.Name = "lbl_Ogac";
			this.lbl_Ogac.Size = new System.Drawing.Size(100, 21);
			this.lbl_Ogac.TabIndex = 173;
			this.lbl_Ogac.Text = "OGAC Date";
			this.lbl_Ogac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_OGAC_YMD
			// 
			this.dpick_OGAC_YMD.CustomFormat = "yyyy-MM-dd";
			this.dpick_OGAC_YMD.Font = new System.Drawing.Font("Verdana", 8F);
			this.dpick_OGAC_YMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_OGAC_YMD.Location = new System.Drawing.Point(437, 178);
			this.dpick_OGAC_YMD.Name = "dpick_OGAC_YMD";
			this.dpick_OGAC_YMD.Size = new System.Drawing.Size(142, 20);
			this.dpick_OGAC_YMD.TabIndex = 174;
			this.dpick_OGAC_YMD.ValueChanged += new System.EventHandler(this.dpick_OGAC_YMD_ValueChanged);
			// 
			// cmb_Region
			// 
			this.cmb_Region.AddItemCols = 0;
			this.cmb_Region.AddItemSeparator = ';';
			this.cmb_Region.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Region.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Region.Caption = "";
			this.cmb_Region.CaptionHeight = 17;
			this.cmb_Region.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Region.ColumnCaptionHeight = 18;
			this.cmb_Region.ColumnFooterHeight = 18;
			this.cmb_Region.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Region.ContentHeight = 15;
			this.cmb_Region.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Region.EditorBackColor = System.Drawing.Color.White;
			this.cmb_Region.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Region.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Region.EditorHeight = 15;
			this.cmb_Region.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Region.GapHeight = 2;
			this.cmb_Region.ItemHeight = 15;
			this.cmb_Region.Location = new System.Drawing.Point(109, 202);
			this.cmb_Region.MatchEntryTimeout = ((long)(2000));
			this.cmb_Region.MaxDropDownItems = ((short)(5));
			this.cmb_Region.MaxLength = 32767;
			this.cmb_Region.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Region.Name = "cmb_Region";
			this.cmb_Region.PartialRightColumn = false;
			this.cmb_Region.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Region.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Region.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Region.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Region.Size = new System.Drawing.Size(210, 19);
			this.cmb_Region.TabIndex = 172;
			// 
			// dpick_Lasting
			// 
			this.dpick_Lasting.CustomFormat = "yyyy-MM-dd";
			this.dpick_Lasting.Font = new System.Drawing.Font("Verdana", 8F);
			this.dpick_Lasting.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_Lasting.Location = new System.Drawing.Point(109, 179);
			this.dpick_Lasting.Name = "dpick_Lasting";
			this.dpick_Lasting.Size = new System.Drawing.Size(212, 20);
			this.dpick_Lasting.TabIndex = 171;
			this.dpick_Lasting.ValueChanged += new System.EventHandler(this.dpick_Lasting_ValueChanged);
			// 
			// cmb_OBS_ID_i
			// 
			this.cmb_OBS_ID_i.AddItemCols = 0;
			this.cmb_OBS_ID_i.AddItemSeparator = ';';
			this.cmb_OBS_ID_i.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_ID_i.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_ID_i.Caption = "";
			this.cmb_OBS_ID_i.CaptionHeight = 17;
			this.cmb_OBS_ID_i.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_ID_i.ColumnCaptionHeight = 18;
			this.cmb_OBS_ID_i.ColumnFooterHeight = 18;
			this.cmb_OBS_ID_i.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_ID_i.ContentHeight = 15;
			this.cmb_OBS_ID_i.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_ID_i.EditorBackColor = System.Drawing.Color.White;
			this.cmb_OBS_ID_i.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID_i.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_ID_i.EditorHeight = 15;
			this.cmb_OBS_ID_i.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID_i.GapHeight = 2;
			this.cmb_OBS_ID_i.ItemHeight = 15;
			this.cmb_OBS_ID_i.Location = new System.Drawing.Point(110, 158);
			this.cmb_OBS_ID_i.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_ID_i.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_ID_i.MaxLength = 32767;
			this.cmb_OBS_ID_i.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_ID_i.Name = "cmb_OBS_ID_i";
			this.cmb_OBS_ID_i.PartialRightColumn = false;
			this.cmb_OBS_ID_i.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_OBS_ID_i.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID_i.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_ID_i.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID_i.Size = new System.Drawing.Size(210, 19);
			this.cmb_OBS_ID_i.TabIndex = 170;
			// 
			// cmb_OBS_Type_i
			// 
			this.cmb_OBS_Type_i.AddItemCols = 0;
			this.cmb_OBS_Type_i.AddItemSeparator = ';';
			this.cmb_OBS_Type_i.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_Type_i.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_Type_i.Caption = "";
			this.cmb_OBS_Type_i.CaptionHeight = 17;
			this.cmb_OBS_Type_i.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_Type_i.ColumnCaptionHeight = 18;
			this.cmb_OBS_Type_i.ColumnFooterHeight = 18;
			this.cmb_OBS_Type_i.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_Type_i.ContentHeight = 15;
			this.cmb_OBS_Type_i.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_Type_i.EditorBackColor = System.Drawing.Color.White;
			this.cmb_OBS_Type_i.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_Type_i.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_Type_i.EditorHeight = 15;
			this.cmb_OBS_Type_i.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_Type_i.GapHeight = 2;
			this.cmb_OBS_Type_i.ItemHeight = 15;
			this.cmb_OBS_Type_i.Location = new System.Drawing.Point(110, 136);
			this.cmb_OBS_Type_i.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_Type_i.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_Type_i.MaxLength = 32767;
			this.cmb_OBS_Type_i.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_Type_i.Name = "cmb_OBS_Type_i";
			this.cmb_OBS_Type_i.PartialRightColumn = false;
			this.cmb_OBS_Type_i.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_OBS_Type_i.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type_i.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_Type_i.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type_i.Size = new System.Drawing.Size(210, 19);
			this.cmb_OBS_Type_i.TabIndex = 169;
			this.cmb_OBS_Type_i.TextChanged += new System.EventHandler(this.cmb_OBS_Type_i_TextChanged);
			// 
			// cmb_Style_i
			// 
			this.cmb_Style_i.AddItemCols = 0;
			this.cmb_Style_i.AddItemSeparator = ';';
			this.cmb_Style_i.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Style_i.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Style_i.Caption = "";
			this.cmb_Style_i.CaptionHeight = 17;
			this.cmb_Style_i.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Style_i.ColumnCaptionHeight = 18;
			this.cmb_Style_i.ColumnFooterHeight = 18;
			this.cmb_Style_i.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Style_i.ContentHeight = 16;
			this.cmb_Style_i.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Style_i.EditorBackColor = System.Drawing.Color.White;
			this.cmb_Style_i.EditorFont = new System.Drawing.Font("Verdana", 8.5F);
			this.cmb_Style_i.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Style_i.EditorHeight = 16;
			this.cmb_Style_i.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.cmb_Style_i.GapHeight = 2;
			this.cmb_Style_i.ItemHeight = 15;
			this.cmb_Style_i.Location = new System.Drawing.Point(214, 54);
			this.cmb_Style_i.MatchEntryTimeout = ((long)(2000));
			this.cmb_Style_i.MaxDropDownItems = ((short)(5));
			this.cmb_Style_i.MaxLength = 32767;
			this.cmb_Style_i.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Style_i.Name = "cmb_Style_i";
			this.cmb_Style_i.PartialRightColumn = false;
			this.cmb_Style_i.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.5pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight" +
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
				"ut><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Style_i.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Style_i.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Style_i.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Style_i.Size = new System.Drawing.Size(105, 20);
			this.cmb_Style_i.TabIndex = 168;
			this.cmb_Style_i.TextChanged += new System.EventHandler(this.cmb_Style_i_TextChanged);
			// 
			// cmb_Factory_i
			// 
			this.cmb_Factory_i.AddItemCols = 0;
			this.cmb_Factory_i.AddItemSeparator = ';';
			this.cmb_Factory_i.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory_i.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory_i.Caption = "";
			this.cmb_Factory_i.CaptionHeight = 17;
			this.cmb_Factory_i.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory_i.ColumnCaptionHeight = 18;
			this.cmb_Factory_i.ColumnFooterHeight = 18;
			this.cmb_Factory_i.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory_i.ContentHeight = 15;
			this.cmb_Factory_i.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory_i.EditorBackColor = System.Drawing.Color.White;
			this.cmb_Factory_i.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory_i.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory_i.EditorHeight = 15;
			this.cmb_Factory_i.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory_i.GapHeight = 2;
			this.cmb_Factory_i.ItemHeight = 15;
			this.cmb_Factory_i.Location = new System.Drawing.Point(109, 32);
			this.cmb_Factory_i.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory_i.MaxDropDownItems = ((short)(5));
			this.cmb_Factory_i.MaxLength = 32767;
			this.cmb_Factory_i.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory_i.Name = "cmb_Factory_i";
			this.cmb_Factory_i.PartialRightColumn = false;
			this.cmb_Factory_i.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Factory_i.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory_i.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory_i.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory_i.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory_i.TabIndex = 167;
			// 
			// txt_OBS_SEQ_NU
			// 
			this.txt_OBS_SEQ_NU.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_OBS_SEQ_NU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_SEQ_NU.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_SEQ_NU.Location = new System.Drawing.Point(437, 76);
			this.txt_OBS_SEQ_NU.MaxLength = 100;
			this.txt_OBS_SEQ_NU.Name = "txt_OBS_SEQ_NU";
			this.txt_OBS_SEQ_NU.ReadOnly = true;
			this.txt_OBS_SEQ_NU.Size = new System.Drawing.Size(140, 20);
			this.txt_OBS_SEQ_NU.TabIndex = 166;
			this.txt_OBS_SEQ_NU.Text = "";
			// 
			// txt_CHG_NU
			// 
			this.txt_CHG_NU.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_CHG_NU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_CHG_NU.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_CHG_NU.Location = new System.Drawing.Point(437, 98);
			this.txt_CHG_NU.MaxLength = 100;
			this.txt_CHG_NU.Name = "txt_CHG_NU";
			this.txt_CHG_NU.ReadOnly = true;
			this.txt_CHG_NU.Size = new System.Drawing.Size(140, 20);
			this.txt_CHG_NU.TabIndex = 165;
			this.txt_CHG_NU.Text = "";
			// 
			// txt_OBS_NU
			// 
			this.txt_OBS_NU.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_OBS_NU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_NU.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_NU.Location = new System.Drawing.Point(437, 54);
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
			this.txt_CSET_RSN.Location = new System.Drawing.Point(437, 243);
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
			this.dpick_CSET_YMD.Location = new System.Drawing.Point(437, 220);
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
			this.dpick_RST_YMD.Location = new System.Drawing.Point(437, 197);
			this.dpick_RST_YMD.Name = "dpick_RST_YMD";
			this.dpick_RST_YMD.Size = new System.Drawing.Size(142, 20);
			this.dpick_RST_YMD.TabIndex = 161;
			this.dpick_RST_YMD.ValueChanged += new System.EventHandler(this.dpick_RST_YMD_ValueChanged);
			// 
			// txt_Job_Div
			// 
			this.txt_Job_Div.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_Job_Div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Job_Div.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Job_Div.Location = new System.Drawing.Point(109, 246);
			this.txt_Job_Div.MaxLength = 100;
			this.txt_Job_Div.Name = "txt_Job_Div";
			this.txt_Job_Div.ReadOnly = true;
			this.txt_Job_Div.Size = new System.Drawing.Size(210, 20);
			this.txt_Job_Div.TabIndex = 160;
			this.txt_Job_Div.Text = "";
			// 
			// txt_TOT_Qty
			// 
			this.txt_TOT_Qty.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_TOT_Qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_TOT_Qty.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_TOT_Qty.Location = new System.Drawing.Point(109, 98);
			this.txt_TOT_Qty.MaxLength = 100;
			this.txt_TOT_Qty.Name = "txt_TOT_Qty";
			this.txt_TOT_Qty.Size = new System.Drawing.Size(210, 20);
			this.txt_TOT_Qty.TabIndex = 153;
			this.txt_TOT_Qty.Text = "0";
			this.txt_TOT_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txt_TOT_Qty.Leave += new System.EventHandler(this.txt_TOT_Qty_Leave);
			// 
			// txt_Pst_yn
			// 
			this.txt_Pst_yn.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_Pst_yn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Pst_yn.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Pst_yn.Location = new System.Drawing.Point(178, 76);
			this.txt_Pst_yn.MaxLength = 100;
			this.txt_Pst_yn.Name = "txt_Pst_yn";
			this.txt_Pst_yn.ReadOnly = true;
			this.txt_Pst_yn.Size = new System.Drawing.Size(141, 20);
			this.txt_Pst_yn.TabIndex = 152;
			this.txt_Pst_yn.Text = "";
			// 
			// txt_Gen
			// 
			this.txt_Gen.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_Gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Gen.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Gen.Location = new System.Drawing.Point(109, 76);
			this.txt_Gen.MaxLength = 100;
			this.txt_Gen.Name = "txt_Gen";
			this.txt_Gen.ReadOnly = true;
			this.txt_Gen.Size = new System.Drawing.Size(68, 20);
			this.txt_Gen.TabIndex = 151;
			this.txt_Gen.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label17.Font = new System.Drawing.Font("Verdana", 8F);
			this.label17.ImageIndex = 2;
			this.label17.ImageList = this.img_Label;
			this.label17.Location = new System.Drawing.Point(8, 98);
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
			this.label14.Location = new System.Drawing.Point(8, 76);
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
			this.label15.Location = new System.Drawing.Point(8, 54);
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
			this.label16.Location = new System.Drawing.Point(8, 32);
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
			this.label12.Location = new System.Drawing.Point(336, 242);
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
			this.label11.Location = new System.Drawing.Point(8, 136);
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
			this.label10.Location = new System.Drawing.Point(336, 220);
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
			this.label8.Location = new System.Drawing.Point(8, 158);
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
			this.label9.Location = new System.Drawing.Point(8, 202);
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
			this.label7.Location = new System.Drawing.Point(8, 180);
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
			this.label6.Location = new System.Drawing.Point(8, 246);
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
			this.label4.Location = new System.Drawing.Point(336, 98);
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
			this.label1.Location = new System.Drawing.Point(336, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 130;
			this.label1.Text = "OBS Seq No";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label2.Font = new System.Drawing.Font("Verdana", 8F);
			this.label2.ImageIndex = 0;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(336, 198);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 128;
			this.label2.Text = "RST Date";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Verdana", 8F);
			this.label3.ImageIndex = 1;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(336, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 129;
			this.label3.Text = "OBS No";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(352, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 584);
			this.splitter1.TabIndex = 45;
			this.splitter1.TabStop = false;
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
			this.pnl_1.Size = new System.Drawing.Size(352, 584);
			this.pnl_1.TabIndex = 44;
			// 
			// pnl_search_detail
			// 
			this.pnl_search_detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_search_detail.BackColor = System.Drawing.Color.White;
			this.pnl_search_detail.Controls.Add(this.pnl_search_cs);
			this.pnl_search_detail.DockPadding.Top = 1;
			this.pnl_search_detail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_search_detail.Location = new System.Drawing.Point(0, 154);
			this.pnl_search_detail.Name = "pnl_search_detail";
			this.pnl_search_detail.Size = new System.Drawing.Size(344, 422);
			this.pnl_search_detail.TabIndex = 40;
			// 
			// pnl_search_cs
			// 
			this.pnl_search_cs.Controls.Add(this.gb_CS_N);
			this.pnl_search_cs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_search_cs.DockPadding.Bottom = 8;
			this.pnl_search_cs.DockPadding.Left = 8;
			this.pnl_search_cs.DockPadding.Right = 8;
			this.pnl_search_cs.DockPadding.Top = 1;
			this.pnl_search_cs.Location = new System.Drawing.Point(0, 1);
			this.pnl_search_cs.Name = "pnl_search_cs";
			this.pnl_search_cs.Size = new System.Drawing.Size(344, 421);
			this.pnl_search_cs.TabIndex = 0;
			// 
			// gb_CS_N
			// 
			this.gb_CS_N.BackColor = System.Drawing.Color.White;
			this.gb_CS_N.Controls.Add(this.fgrid_CS_Y);
			this.gb_CS_N.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_CS_N.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gb_CS_N.ForeColor = System.Drawing.Color.Black;
			this.gb_CS_N.Location = new System.Drawing.Point(8, 1);
			this.gb_CS_N.Name = "gb_CS_N";
			this.gb_CS_N.Size = new System.Drawing.Size(328, 412);
			this.gb_CS_N.TabIndex = 136;
			this.gb_CS_N.TabStop = false;
			this.gb_CS_N.Text = "§ Target CS OBS";
			// 
			// fgrid_CS_Y
			// 
			this.fgrid_CS_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_CS_Y.AutoResize = false;
			this.fgrid_CS_Y.BackColor = System.Drawing.Color.White;
			this.fgrid_CS_Y.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_CS_Y.ColumnInfo = "2,1,0,0,0,95,Columns:";
			this.fgrid_CS_Y.ContextMenu = this.contextMenu1;
			this.fgrid_CS_Y.ForeColor = System.Drawing.Color.Black;
			this.fgrid_CS_Y.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_CS_Y.Location = new System.Drawing.Point(10, 28);
			this.fgrid_CS_Y.Name = "fgrid_CS_Y";
			this.fgrid_CS_Y.Rows.Count = 2;
			this.fgrid_CS_Y.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_CS_Y.Size = new System.Drawing.Size(304, 370);
			this.fgrid_CS_Y.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_CS_Y.TabIndex = 37;
			this.fgrid_CS_Y.DoubleClick += new System.EventHandler(this.fgrid_CS_Y_DoubleClick);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.ctm_CSOBS_Req,
																						 this.ctm_Bar_First,
																						 this.ctm_CSOBS_Sel,
																						 this.ctm_CSOBS_HistSel});
			// 
			// ctm_CSOBS_Req
			// 
			this.ctm_CSOBS_Req.Index = 0;
			this.ctm_CSOBS_Req.Text = "CS OBS Request";
			this.ctm_CSOBS_Req.Click += new System.EventHandler(this.ctm_CSOBS_Req_Click);
			// 
			// ctm_Bar_First
			// 
			this.ctm_Bar_First.Index = 1;
			this.ctm_Bar_First.Text = "-";
			// 
			// ctm_CSOBS_Sel
			// 
			this.ctm_CSOBS_Sel.Index = 2;
			this.ctm_CSOBS_Sel.Text = "CS OBS By Option";
			this.ctm_CSOBS_Sel.Click += new System.EventHandler(this.ctm_CSOBS_Sel_Click);
			// 
			// ctm_CSOBS_HistSel
			// 
			this.ctm_CSOBS_HistSel.Index = 3;
			this.ctm_CSOBS_HistSel.Text = "CS OBS History";
			this.ctm_CSOBS_HistSel.Click += new System.EventHandler(this.ctm_CSOBS_HistSel_Click);
			// 
			// pnl_search_main
			// 
			this.pnl_search_main.BackColor = System.Drawing.Color.White;
			this.pnl_search_main.Controls.Add(this.pnl_Search1_Image);
			this.pnl_search_main.DockPadding.All = 8;
			this.pnl_search_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_search_main.Location = new System.Drawing.Point(1, 1);
			this.pnl_search_main.Name = "pnl_search_main";
			this.pnl_search_main.Size = new System.Drawing.Size(344, 151);
			this.pnl_search_main.TabIndex = 39;
			// 
			// pnl_Search1_Image
			// 
			this.pnl_Search1_Image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_Search1_Image.Controls.Add(this.txt_Style);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Style);
			this.pnl_Search1_Image.Controls.Add(this.cmb_OBS_ID);
			this.pnl_Search1_Image.Controls.Add(this.cmb_OBS_Type);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Obs_Id);
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
			this.pnl_Search1_Image.Size = new System.Drawing.Size(328, 134);
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
			// cmb_OBS_ID
			// 
			this.cmb_OBS_ID.AddItemCols = 0;
			this.cmb_OBS_ID.AddItemSeparator = ';';
			this.cmb_OBS_ID.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_ID.Caption = "";
			this.cmb_OBS_ID.CaptionHeight = 17;
			this.cmb_OBS_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_ID.ColumnCaptionHeight = 18;
			this.cmb_OBS_ID.ColumnFooterHeight = 18;
			this.cmb_OBS_ID.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_ID.ContentHeight = 15;
			this.cmb_OBS_ID.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_ID.EditorBackColor = System.Drawing.Color.White;
			this.cmb_OBS_ID.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_ID.EditorHeight = 15;
			this.cmb_OBS_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID.GapHeight = 2;
			this.cmb_OBS_ID.ItemHeight = 15;
			this.cmb_OBS_ID.Location = new System.Drawing.Point(111, 80);
			this.cmb_OBS_ID.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_ID.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_ID.MaxLength = 32767;
			this.cmb_OBS_ID.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_ID.Name = "cmb_OBS_ID";
			this.cmb_OBS_ID.PartialRightColumn = false;
			this.cmb_OBS_ID.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_OBS_ID.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_ID.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID.Size = new System.Drawing.Size(210, 19);
			this.cmb_OBS_ID.TabIndex = 129;
			this.cmb_OBS_ID.TextChanged += new System.EventHandler(this.cmb_OBS_ID_TextChanged);
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_OBS_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type.Size = new System.Drawing.Size(210, 19);
			this.cmb_OBS_Type.TabIndex = 128;
			this.cmb_OBS_Type.TextChanged += new System.EventHandler(this.cmb_OBS_Type_TextChanged);
			// 
			// lbl_Obs_Id
			// 
			this.lbl_Obs_Id.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Obs_Id.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Obs_Id.ImageIndex = 1;
			this.lbl_Obs_Id.ImageList = this.img_Label;
			this.lbl_Obs_Id.Location = new System.Drawing.Point(10, 80);
			this.lbl_Obs_Id.Name = "lbl_Obs_Id";
			this.lbl_Obs_Id.Size = new System.Drawing.Size(100, 21);
			this.lbl_Obs_Id.TabIndex = 127;
			this.lbl_Obs_Id.Text = "OBS ID";
			this.lbl_Obs_Id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory.TabIndex = 126;
			this.cmb_Factory.TextChanged += new System.EventHandler(this.cmb_Factory_TextChanged);
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
			this.pictureBox5.Size = new System.Drawing.Size(19, 88);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.Color.Blue;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(238, 120);
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
			this.pictureBox3.Size = new System.Drawing.Size(32, 99);
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.Color.Blue;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 120);
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
			this.pictureBox9.Location = new System.Drawing.Point(72, 120);
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
			this.pictureBox4.Size = new System.Drawing.Size(280, 102);
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			// 
			// cmb_Component
			// 
			this.cmb_Component.AddItemCols = 0;
			this.cmb_Component.AddItemSeparator = ';';
			this.cmb_Component.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Component.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Component.Caption = "";
			this.cmb_Component.CaptionHeight = 17;
			this.cmb_Component.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Component.ColumnCaptionHeight = 18;
			this.cmb_Component.ColumnFooterHeight = 18;
			this.cmb_Component.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Component.ContentHeight = 15;
			this.cmb_Component.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Component.EditorBackColor = System.Drawing.Color.White;
			this.cmb_Component.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Component.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Component.EditorHeight = 15;
			this.cmb_Component.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Component.GapHeight = 2;
			this.cmb_Component.ItemHeight = 15;
			this.cmb_Component.Location = new System.Drawing.Point(109, 269);
			this.cmb_Component.MatchEntryTimeout = ((long)(2000));
			this.cmb_Component.MaxDropDownItems = ((short)(5));
			this.cmb_Component.MaxLength = 32767;
			this.cmb_Component.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Component.Name = "cmb_Component";
			this.cmb_Component.PartialRightColumn = false;
			this.cmb_Component.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Component.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Component.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Component.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Component.Size = new System.Drawing.Size(210, 19);
			this.cmb_Component.TabIndex = 179;
			// 
			// lbl_UB
			// 
			this.lbl_UB.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_UB.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_UB.ImageIndex = 2;
			this.lbl_UB.ImageList = this.img_Label;
			this.lbl_UB.Location = new System.Drawing.Point(8, 269);
			this.lbl_UB.Name = "lbl_UB";
			this.lbl_UB.Size = new System.Drawing.Size(100, 21);
			this.lbl_UB.TabIndex = 178;
			this.lbl_UB.Text = "Component Div";
			this.lbl_UB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Form_EC_ETCCRT
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_main);
			this.Font = new System.Drawing.Font("Verdana", 8F);
			this.Name = "Form_EC_ETCCRT";
			this.Load += new System.EventHandler(this.Form_EC_ETCCRT_Load);
			this.Controls.SetChildIndex(this.pnl_main, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_main.ResumeLayout(false);
			this.pnl_2.ResumeLayout(false);
			this.pnl_size.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_size)).EndInit();
			this.pnl_save_detail.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Year)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Dest)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Region)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID_i)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type_i)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Style_i)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_i)).EndInit();
			this.pnl_1.ResumeLayout(false);
			this.pnl_search_detail.ResumeLayout(false);
			this.pnl_search_cs.ResumeLayout(false);
			this.gb_CS_N.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_CS_Y)).EndInit();
			this.pnl_search_main.ResumeLayout(false);
			this.pnl_Search1_Image.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Component)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의

		private int _Rowfixed; 
		private string _Date_Flag;

		COM.OraDB MyOraDB = new COM.OraDB();  
		COM.ComFunction MyComFunction = new COM.ComFunction();
		private ClassLib.OraDB  MyClassLib = new ClassLib.OraDB();

		#endregion

		#region 멤버 메서드 
		private void Init_Form()
		{ 
			//Title
			this.Text = "ETC OBS ";
			this.lbl_MainTitle.Text = "Create ETC OBS"; 
			ClassLib.ComFunction.SetLangDic(this);


			DataTable dt_list; 
			DateTime CurDate = DateTime.Now;
			int i;

			#region 버튼 권한

			try
			{
				COM.OraDB btn_control = new COM.OraDB();
//				DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
//				tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
//				btn_control = null;

				//Button 활성화
				tbtn_Append.Enabled = false;    tbtn_Insert.Enabled = false;    tbtn_Print.Enabled = false;

			}
			catch
			{
			}

			#endregion
	
			#region 그리드
			// 그리드 설정(TBSEM_OBS_BP)
			fgrid_CS_Y.Set_Grid( "SEM_OBS_CS", "3", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);  
			_Rowfixed = fgrid_CS_Y.Rows.Fixed;	
			fgrid_CS_Y.Cols[(int)ClassLib.TBSEM_OBS_BP.IxBP_NO].Width = 70;
			fgrid_CS_Y.Font  = new Font("Verdana",8);


			dt_list = MyOraDB.Select_GridHead("SEM_OBS_CS","2");
			for(i = 0; i < dt_list.Rows.Count; i++)
			{
				fgrid_size[i, 0] = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSCM_TABLE.IxCOL_NAME-1].ToString();				
				fgrid_size[i, 1] = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSCM_TABLE.IxHEAD_DESC1-1].ToString();						
			}
			fgrid_size.GetCellRange(0,0,0,fgrid_size.Cols.Count-1).StyleNew.BackColor  =  ClassLib.ComVar.Clr_Head_Crimson;
			fgrid_size.GetCellRange(0,1,fgrid_size.Rows.Count-1,1).StyleNew.BackColor  =  ClassLib.ComVar.Clr_Head_Crimson;
			fgrid_size.Font = new Font("Verdana",8);
			fgrid_size.Cols.Fixed = 2;
			fgrid_size.Cols[0].Visible = false;		
			fgrid_size.AutoSizeCols(); 	
			#endregion

			
			//조회 콤보박스 설정
			///Factory
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			///OBS_Type
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxOBS_Type);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OBS_Type, 1, 2, false);  			
			cmb_OBS_Type.SelectedIndex = 0;

			// 입력 콤보박스 설정
			///Factory
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Factory_i, 0, 1); 
			cmb_Factory_i.SelectedValue = ClassLib.ComVar.This_Factory;

			///OBS_Type
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxOBS_Type);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OBS_Type_i, 1, 2, false);  			
			cmb_OBS_Type_i.SelectedIndex = 0;

			//Style
			dt_list = MyClassLib.Select_Style_Master(" ");
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Style_i, 0, 1);  	
			cmb_Style_i.SelectedIndex  = -1;

			//Region
			dt_list = MyClassLib.Select_Region(cmb_Factory.SelectedValue.ToString());
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Region, 0, 1);  	
			cmb_Region.SelectedIndex = 0;

			
			//Date
			dpick_CSET_YMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			string now  = System.DateTime.Now.ToString("yyyyMMdd");
			dpick_CSET_YMD.Text = MyComFunction.ConvertDate2Type(now);

			dpick_Lasting.CustomFormat = ClassLib.ComVar.This_SetedDateType;
		    now  = System.DateTime.Now.ToString("yyyyMMdd");
			dpick_Lasting.Text = MyComFunction.ConvertDate2Type(now);

			dpick_OGAC_YMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			now  = System.DateTime.Now.ToString("yyyyMMdd");
			dpick_OGAC_YMD.Text = MyComFunction.ConvertDate2Type(now);


			dpick_RST_YMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			now  = System.DateTime.Now.ToString("yyyyMMdd");
			dpick_RST_YMD.Text = MyComFunction.ConvertDate2Type(now);


			//Destination
			dt_list = MyClassLib.Select_Dest(cmb_Factory.SelectedValue.ToString());
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Dest, 0, 1);  	
			cmb_Region.SelectedIndex = 0;


			///component 
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxComponent);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Component, 1, 2, false);  			
			cmb_Component.SelectedIndex = 0;




			//Setting Season
			dt_list = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(),"SEM15");
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Season, 1, 2);
			//cmb_Season.SelectedValue = "SP";

			//Year
			ClassLib.ComFunction.Set_Year(cmb_Year);


			//txt_TOT_Qty.Enabled  = true;
			_Date_Flag = ClassLib.ComVar.Divflag_NEW;
			txt_Job_Div.Text  ="00";


			//ClassLib.ComFunction.Get_Values(this, dpick_CSET_YMD.Name);
			//ClassLib.ComFunction.Get_Values(this, dpick_OGAC_YMD.Name);
			//ClassLib.ComFunction.Get_Values(this, dpick_Lasting.Name);
			//ClassLib.ComFunction.Get_Values(this, dpick_RST_YMD.Name);
		}


		
		/// <summary>
		/// Check_Save : Check Save
		/// </summary>
		private bool Check_Save()
		{

			if (fgrid_CS_Y.Selection.r1 > fgrid_CS_Y.Rows.Fixed ) 
			{
			
		
				if (fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxSYMD].ToString()
					== System.DateTime.Now.ToString("yyyyMMdd")&&
					(fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxREQ_YN].ToString()  == "True"))
				{
					MessageBox.Show("Today,Order can not be changed.. Please Try it tomorrow!!",	
						"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning) ;
					return false;}
			}

			if(cmb_Factory_i.SelectedValue == null) 
			 {ClassLib.ComFunction.Data_Message("Factory Code", ClassLib.ComVar.MgsWrongInput ,this);  return false;}
			
			if(txt_Style_i.Text  == null)  
			{ClassLib.ComFunction.Data_Message("Style Code", ClassLib.ComVar.MgsWrongInput ,this);  return false;}

			if(cmb_Style_i.SelectedValue == null) 
			{ClassLib.ComFunction.Data_Message("Style Code", ClassLib.ComVar.MgsWrongInput ,this);  return false;}

			if(cmb_OBS_Type_i.SelectedValue == null) 
			{ClassLib.ComFunction.Data_Message("OBS Type", ClassLib.ComVar.MgsWrongInput ,this);  return false;}

			if(cmb_OBS_ID_i.Text == null) 
			{ClassLib.ComFunction.Data_Message("OBS ID", ClassLib.ComVar.MgsWrongInput ,this);  return false;}

			if(cmb_Region.Text == null)  
			{ClassLib.ComFunction.Data_Message("Region", ClassLib.ComVar.MgsWrongInput ,this);  return false;}

			if(cmb_Dest.Text == null)  
			{ClassLib.ComFunction.Data_Message("Destination", ClassLib.ComVar.MgsWrongInput ,this);  return false;}

			if(cmb_Season.SelectedIndex  == -1)  
			{ClassLib.ComFunction.Data_Message("Season", ClassLib.ComVar.MgsWrongInput ,this);  return false;}

			if(cmb_Year.SelectedIndex  == -1)  
			{ClassLib.ComFunction.Data_Message("Year", ClassLib.ComVar.MgsWrongInput ,this);  return false;}


			if (cmb_OBS_Type_i.SelectedValue.ToString()!= "CP") return true;
			if(cmb_Component.SelectedValue.ToString()   == "" )  
			{ClassLib.ComFunction.Data_Message("Component Division", ClassLib.ComVar.MgsWrongInput ,this);  return false;}




			return true;

		}


		/// <summary>
		/// Clear_CS_DPO_Infot : CS DPO Group Initial
		/// </summary>
		private void Clear_CS_DPO_Info()
		{
			fgrid_size.Cols.Count = 2;

            cmb_Factory_i.SelectedValue  = ClassLib.ComVar.This_Factory;
			txt_Style_i.Clear();
			cmb_Style_i.SelectedIndex = -1;
			txt_Gen.Clear();
			txt_Pst_yn.Clear();
			txt_TOT_Qty.Text  = Convert.ToString("0");

			cmb_OBS_Type_i.SelectedIndex = -1;
			cmb_OBS_ID_i.SelectedIndex = -1;
			dpick_Lasting.Text  =  DateTime.Now.ToString();
			cmb_Region.SelectedIndex = -1;
			cmb_Dest.SelectedIndex = -1;
			txt_Job_Div.Text  ="00";

			txt_OBS_NU.Clear();
			txt_OBS_SEQ_NU.Clear();
			txt_CHG_NU.Clear();

			dpick_CSET_YMD.Text = DateTime.Now.ToString();
			dpick_RST_YMD.Text  = DateTime.Now.ToString();
			txt_CSET_RSN.Text   ="";

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

			dt_list = MyClassLib.Select_Gen_Size(cmb_Factory_i.SelectedValue.ToString(),
				txt_Gen.Text.ToString(), txt_Pst_yn.Text.ToString());

			if (dt_list == null) return;

			arg_fgrid.Cols.Count   =  arg_fgrid.Cols.Count + dt_list.Rows.Count;
			for (int i = 0; i < dt_list.Rows.Count; i++)
			{
				arg_fgrid[iQty_Pos,col_fixed+i] =dt_list.Rows[i].ItemArray[0];
				arg_fgrid.Cols[col_fixed+i].Width = 50;
			}

			fgrid_size.GetCellRange(0,0,0,fgrid_size.Cols.Count-1).StyleNew.BackColor  =  ClassLib.ComVar.Clr_Head_Crimson;
			fgrid_size.GetCellRange(0,1,fgrid_size.Rows.Count-1,1).StyleNew.BackColor  =  ClassLib.ComVar.Clr_Head_Crimson;

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
				iPos =  1;     //GSSC Position
			else
				iPos =  2;     //Quantity Position
				 

 
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

				 
		}


		private void cmb_OBS_Type_TextChanged(object sender, System.EventArgs e)
		{   

			if(cmb_OBS_Type.SelectedIndex == -1) return;

			cmb_OBS_ID.ClearItems();
			ClassLib.ComFunction.Set_OBSID_CmbList(cmb_OBS_Type.SelectedValue.ToString(), cmb_OBS_ID);  

			cmb_OBS_Type_i.SelectedValue  = cmb_OBS_Type.SelectedValue.ToString();
		}

		private void fgrid_CS_Y_DoubleClick(object sender, System.EventArgs e)
		{
			
			DataTable dt_ret;

			if (fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxREQ_YN].ToString() == "True")
			{   
				if (fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxSYMD].ToString() 
					== System.DateTime.Now.ToString("yyyyMMdd") &&
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
			
			//txt_TOT_Qty.Enabled = false;
			 _Date_Flag           = ClassLib.ComVar.Divflag_CHG;

			cmb_Factory_i.SelectedValue  = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxFACTORY].ToString();
			txt_Style_i.Text   = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxSTYLE_CD].ToString();
			cmb_Style_i.SelectedValue  = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxSTYLE_CD].ToString();
			txt_Gen.Text       = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxGEN].ToString();
			txt_Pst_yn.Text    = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxPST_YN].ToString();
			txt_TOT_Qty.Text   = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxCS_QTY].ToString();

			cmb_OBS_Type_i.SelectedValue  = cmb_OBS_Type.SelectedValue.ToString();
			cmb_OBS_ID_i.Text    = cmb_OBS_ID.Text.ToString();
			dpick_Lasting.Text   = MyComFunction.ConvertDate2Type(fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxBP_NO ].ToString());
			cmb_Region.Text      = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxREGION].ToString();
			cmb_Dest.Text        = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxDEST].ToString();

			txt_OBS_NU.Text      = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxOBS_NU].ToString();
			txt_OBS_SEQ_NU.Text  = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxOBS_SEQ_NU].ToString();
			txt_CHG_NU.Text      = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxCHG_NU].ToString();

			dpick_CSET_YMD.Text  = MyComFunction.ConvertDate2Type(fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxCSETS_YMD].ToString());
			dpick_RST_YMD.Text   = MyComFunction.ConvertDate2Type(fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxRTS_YMD].ToString());
			txt_CSET_RSN.Text    = fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxCSETS_RSN].ToString();
			cmb_Component.SelectedValue     =  fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxUB_DIV].ToString();
			cmb_Season.SelectedValue     =  fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxSEASON].ToString();
			cmb_Year.SelectedValue      =  fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxYEAR].ToString();
			cmb_Component.SelectedValue     =  fgrid_CS_Y[fgrid_CS_Y.Selection.r1, (int)ClassLib.TBSEM_OBS_CS.IxUB_DIV].ToString();
		
			//Size Run Setting
			Sb_Set_Size(fgrid_size);
        
			//GSSC% Setting
			dt_ret = Select_Size_List();
			Display_Obs_Cs_Size(dt_ret, fgrid_size,"01");

			//CS OBS QTY Setting
			dt_ret  = Select_Obs_Cs_Size();
			Display_Obs_Cs_Size(dt_ret ,fgrid_size,"02");

		}

	

		private void cmb_Style_i_TextChanged(object sender, System.EventArgs e)
		{
			
			try
			{				

				DataTable dt_ret;

				//Clear_CS_DPO_Info();
				txt_Style_i.Text  = cmb_Style_i.SelectedValue.ToString();

				if (txt_Style_i.Text == null ) return;

				MyClassLib.Select_Gen_Pst(cmb_Style_i.SelectedValue.ToString());
				txt_Gen.Text    = ClassLib.ComVar.DivGen;
				txt_Pst_yn.Text = ClassLib.ComVar.DivPst;
			
				//GSSC 존재 유무 Setting


				//Size Run Setting
				Sb_Set_Size(fgrid_size);
        
				//GSSC% 조회 
				dt_ret = Select_Size_List();
				Display_Obs_Cs_Size(dt_ret, fgrid_size,"01");   //GSSC% Setting
				Display_Obs_Cs_Size(dt_ret, fgrid_size,"02");   //Quantity  % Setting 


			}
			catch 
			{
				//ClassLib.ComFunction.Data_Message(ClassLib.ComVar. ,this);
			}	

		}
	


		private void Sb_Sum(C1FlexGrid arg_fgrid)
		{ 
			int col_fixed = arg_fgrid.Cols.Fixed, iSum = 0;	

			iSum = 0 ;
			for (int i =col_fixed ; i < arg_fgrid.Cols.Count ; i++)
			{
				iSum = iSum + Convert.ToInt32(fgrid_size[2,i]);
			}

			txt_TOT_Qty.Text = Convert.ToString(iSum);
		}


		private void Display_fgrid_CS_Y(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1; 
 
			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
				arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = "";
			} 
			//arg_fgrid.AutoSizeCols();

			cmb_Season.SelectedIndex   = -1;
			cmb_Year.SelectedIndex     = -1;

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

			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = txt_OBS_NU.Text;
			MyOraDB.Parameter_Values[2] = txt_OBS_SEQ_NU.Text;
			MyOraDB.Parameter_Values[3] = txt_CHG_NU.Text;

			MyOraDB.Add_Modify_Parameter(true);	
			MyOraDB.Exe_Modify_Procedure();

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
			MyOraDB.Parameter_Values[0] = cmb_Factory_i.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = txt_Style_i.Text;
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name];

		}

		/// <summary>
		/// Select_Size_List : Style별 사이즈런 조회
		/// </summary>
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
			MyOraDB.Parameter_Values[2] = cmb_OBS_ID.Text;
			MyOraDB.Parameter_Values[3] = "00000000";
			MyOraDB.Parameter_Values[4] = txt_Job_Div.Text;
			MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_TextBox(txt_Style," ");
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
		}


		/// <summary>
		/// Select_Size_List : SEM_GSSC의 사이즈 비율로 Display
		/// </summary>
		private bool Save_SEM_OBS_CS()
		{

			DataSet ret;

			int col_ct = 27;	                        // 칼럼의 수 (헤드그리드컬럼수량 + 디테일그리드 수량(2) + (User, UPD_YMD) + Data_Flag(1))
			int Col_fixed = fgrid_size.Cols.Fixed;		// 그리드 고정열 값
			int save_ct = fgrid_size.Cols.Count-2;		// 저장 행 수

			int i;
			int para_ct = 0;				            // 파라미터 값의 저장 배열의 수
			int col;
			

			
			MyOraDB.ReDim_Parameter(col_ct);
			MyOraDB.Process_Name = "PKG_SEM_OBS_CS.SAVE_SEM_OBS_CS";


			// 파라미터 이름 설정	
			MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1]  = "ARG_DATA_FLAG";
			MyOraDB.Parameter_Name[2]  = "ARG_" + fgrid_CS_Y[0, (int)ClassLib.TBSEM_OBS_CS.IxFACTORY].ToString(); 
			MyOraDB.Parameter_Name[3]  = "ARG_" + fgrid_CS_Y[0, (int)ClassLib.TBSEM_OBS_CS.IxOBS_ID].ToString(); 
			MyOraDB.Parameter_Name[4]  = "ARG_" + fgrid_CS_Y[0, (int)ClassLib.TBSEM_OBS_CS.IxSTYLE_CD].ToString(); 
			MyOraDB.Parameter_Name[5]  = "ARG_" + fgrid_CS_Y[0, (int)ClassLib.TBSEM_OBS_CS.IxREGION].ToString(); 
			MyOraDB.Parameter_Name[6]  = "ARG_" + fgrid_CS_Y[0, (int)ClassLib.TBSEM_OBS_CS.IxDEST].ToString(); 
			MyOraDB.Parameter_Name[7]  = "ARG_" + fgrid_CS_Y[0, (int)ClassLib.TBSEM_OBS_CS.IxBP_NO].ToString(); 
			MyOraDB.Parameter_Name[8]  = "ARG_" + fgrid_CS_Y[0, (int)ClassLib.TBSEM_OBS_CS.IxCS_QTY].ToString(); 
			MyOraDB.Parameter_Name[9]  = "ARG_" + fgrid_CS_Y[0, (int)ClassLib.TBSEM_OBS_CS.IxOBS_NU].ToString(); 
			MyOraDB.Parameter_Name[10] = "ARG_" + fgrid_CS_Y[0, (int)ClassLib.TBSEM_OBS_CS.IxOBS_SEQ_NU].ToString(); 
			MyOraDB.Parameter_Name[11] = "ARG_" + fgrid_CS_Y[0, (int)ClassLib.TBSEM_OBS_CS.IxCHG_NU].ToString(); 
			MyOraDB.Parameter_Name[12] = "ARG_" + fgrid_CS_Y[0, (int)ClassLib.TBSEM_OBS_CS.IxJOB_DIV].ToString(); 
			MyOraDB.Parameter_Name[13] = "ARG_" + fgrid_CS_Y[0, (int)ClassLib.TBSEM_OBS_CS.IxOBS_TYPE].ToString(); 
			MyOraDB.Parameter_Name[14] = "ARG_" + fgrid_CS_Y[0, (int)ClassLib.TBSEM_OBS_CS.IxGEN].ToString(); 
			MyOraDB.Parameter_Name[15] = "ARG_" + fgrid_CS_Y[0, (int)ClassLib.TBSEM_OBS_CS.IxPST_YN].ToString(); 
			MyOraDB.Parameter_Name[16] = "ARG_" + fgrid_CS_Y[0, (int)ClassLib.TBSEM_OBS_CS.IxOGAC_YMD].ToString(); 
			MyOraDB.Parameter_Name[17] = "ARG_" + fgrid_CS_Y[0, (int)ClassLib.TBSEM_OBS_CS.IxRTS_YMD].ToString(); 
			MyOraDB.Parameter_Name[18] = "ARG_" + fgrid_CS_Y[0, (int)ClassLib.TBSEM_OBS_CS.IxCSETS_YMD].ToString(); 
			MyOraDB.Parameter_Name[19] = "ARG_" + fgrid_CS_Y[0, (int)ClassLib.TBSEM_OBS_CS.IxCSETS_RSN].ToString(); 
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
			for (i =2 ; i < fgrid_size.Cols.Count ; i++)
				MyOraDB.Parameter_Values  = new string[col_ct * (save_ct)];

			// 각 행의 값 Setting
			for(col = Col_fixed; col < fgrid_size.Cols.Count; col++)
			{
				if (fgrid_size[1, col] == null) return false;

				// 데이터값 설정
				if (col==Col_fixed)
					MyOraDB.Parameter_Values[para_ct+0]  = "H";
				else
					MyOraDB.Parameter_Values[para_ct+0]  = "B";

				MyOraDB.Parameter_Values[para_ct+1]  = _Date_Flag;
				MyOraDB.Parameter_Values[para_ct+2]  = cmb_Factory_i.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct+3]  = cmb_OBS_ID_i.Text;
				MyOraDB.Parameter_Values[para_ct+4]  = cmb_Style_i.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct+5]  = cmb_Region.Columns[1].Text;
				MyOraDB.Parameter_Values[para_ct+6]  = cmb_Dest.Columns[1].Text;
				MyOraDB.Parameter_Values[para_ct+7]  = Convert.ToDateTime(dpick_Lasting.Text).ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[para_ct+8]  = txt_TOT_Qty.Text;
				MyOraDB.Parameter_Values[para_ct+9]  = txt_OBS_NU.Text;
				MyOraDB.Parameter_Values[para_ct+10]  = txt_OBS_SEQ_NU.Text;
				MyOraDB.Parameter_Values[para_ct+11] = txt_CHG_NU.Text;
				MyOraDB.Parameter_Values[para_ct+12] = txt_Job_Div.Text;
				MyOraDB.Parameter_Values[para_ct+13] = cmb_OBS_Type_i.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct+14] = txt_Gen.Text;
				MyOraDB.Parameter_Values[para_ct+15] = txt_Pst_yn.Text;
				MyOraDB.Parameter_Values[para_ct+16] = Convert.ToDateTime(dpick_OGAC_YMD.Text).ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[para_ct+17] = Convert.ToDateTime(dpick_RST_YMD.Text).ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[para_ct+18] = Convert.ToDateTime(dpick_CSET_YMD.Text).ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[para_ct+19] = txt_CSET_RSN.Text;
				MyOraDB.Parameter_Values[para_ct+20] = fgrid_size[0,col].ToString();                        //SEM_OBS_CS_SIZE의 CS_SIZE 컬럼
				MyOraDB.Parameter_Values[para_ct+21] = fgrid_size[2,col].ToString();                        //SEM_OBS_CS_SIZE의 ORD_QTY 컬럼
				MyOraDB.Parameter_Values[para_ct+22] = cmb_Season.SelectedValue.ToString();                       //SEASON
				MyOraDB.Parameter_Values[para_ct+23] = cmb_Year.Columns[0].Text ;                         //SEASON_YEAR
				MyOraDB.Parameter_Values[para_ct+24] = ClassLib.ComVar.This_User;                           //UPD_USER
				MyOraDB.Parameter_Values[para_ct+25] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); //UPD_YMD
				MyOraDB.Parameter_Values[para_ct+26] = cmb_Component.SelectedValue.ToString();
				para_ct += col_ct;
			}
						
			MyOraDB.Add_Modify_Parameter(true);  // 파라미터 데이터를 DataSet에 추가

			ret =  MyOraDB.Exe_Modify_Procedure();	

			return true;
		
		
		}


		#endregion

		#region 이벤트 처리 

		#region 버튼 이벤트
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{				

				DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
				if(DialogResult.Yes != dr) return;

				if (Check_Save() != true)
					return;
				else
					Save_SEM_OBS_CS();

				tbtn_Search_Click(null, null);

			}
			catch
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave ,this);
			}			

		}

	
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				DataTable dt_ret;
				Clear_CS_DPO_Info();

				dt_ret = Select_CS_Data_List();

				fgrid_CS_Y.Rows.Count = _Rowfixed;

				if (dt_ret.Rows.Count == 0)
				{ ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch,this); return;}

				Display_fgrid_CS_Y(dt_ret, fgrid_CS_Y);  //tbtn_Save.Enabled = false;

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch,this);

			}
			catch 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch,this);
			}	
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			_Date_Flag           = ClassLib.ComVar.Divflag_NEW;
			//txt_TOT_Qty.Enabled  = true;

			fgrid_CS_Y.Rows.Count = _Rowfixed;
			fgrid_size.Cols.Count = 2;

			cmb_Factory.SelectedValue  = ClassLib.ComVar.This_Factory;
			cmb_OBS_Type.SelectedIndex = -1;
			cmb_OBS_ID.SelectedIndex = -1;

			Clear_CS_DPO_Info();

		}
		
		
		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{				
				DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete , this);
				if(DialogResult.Yes != dr) return;

				if ((fgrid_CS_Y[fgrid_CS_Y.Selection.r1 ,(int)ClassLib.TBSEM_OBS_CS.IxREQ_YN].ToString()  == "False") &&
					(fgrid_CS_Y[fgrid_CS_Y.Selection.r1 ,(int)ClassLib.TBSEM_OBS_CS.IxOA_NU_AFT].ToString() =="__________") &&
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

		#region  기타 이벤트
		private void fgrid_size_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			Sb_Sum(fgrid_size);
		}

		private void cmb_Factory_TextChanged(object sender, System.EventArgs e)
		{
			cmb_Factory_i.SelectedValue = cmb_Factory.SelectedValue.ToString();
		}

		private void cmb_OBS_Type_i_TextChanged(object sender, System.EventArgs e)
		{
			cmb_OBS_ID_i.ClearItems();
			if (cmb_OBS_Type_i.SelectedIndex != -1) 
				ClassLib.ComFunction.Set_OBSID_CmbList(cmb_OBS_Type_i.SelectedValue.ToString(), cmb_OBS_ID_i);  
		}

		private void cmb_OBS_ID_TextChanged(object sender, System.EventArgs e)
		{
			cmb_OBS_ID_i.Text  = cmb_OBS_ID.Text;
		}

		//		private void txt_Style_i_TextChanged(object sender, System.EventArgs e)
		//		{
		//			DataTable dt_list;
		//			//Style
		//			
		//			dt_list = MyClassLib.Select_Style_Master(ClassLib.ComFunction.Empty_TextBox(txt_Style_i, " "));
		//			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Style_i, 0, 1);  	

		//		}

		private void txt_Style_i_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			DataTable dt_list;
			
			if (e.KeyValue == 13)
			{
				dt_list = MyClassLib.Select_Style_Master(ClassLib.ComFunction.Empty_TextBox(txt_Style_i, " "));
				ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Style_i, 0, 1);  
			}

		}


		private void txt_TOT_Qty_Leave(object sender, System.EventArgs e)
		{
			int iTot_Qty = 0, col_fixed = fgrid_size.Cols.Fixed;
			
			fgrid_size.Rows[0].TextAlign = TextAlignEnum.CenterCenter;

			// Set List
			for(int i = col_fixed; i < fgrid_size.Cols.Count ; i++)
			{
				fgrid_size.Cols[i].Width = 50;

				if (i < fgrid_size.Cols.Count-1)
				{
					double dRate = Convert.ToDouble(fgrid_size[1, i])/100;
					int    iQty  = (int)Math.Floor(Convert.ToDouble(txt_TOT_Qty.Text)*dRate);				
					iTot_Qty += iQty;					
					fgrid_size[2, i] = iQty.ToString();
				}
				else
					fgrid_size[2, i] = Convert.ToString(Convert.ToInt32(txt_TOT_Qty.Text)-iTot_Qty);
			}
		}

		private void dpick_Lasting_ValueChanged(object sender, System.EventArgs e)
		{
			//ClassLib.ComFunction.Set_Values(this, dpick_Lasting.Name);
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

		
		private void ctm_CSOBS_Req_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBSCS.Form_EC_Req frm = new ExpOBSCS.Form_EC_Req();
			frm.Show();
		}

		private void ctm_CSOBS_Sel_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBS.Form_EO_SRCH frm = new ExpOBS.Form_EO_SRCH();  
			frm.Show();
		}

		private void ctm_CSOBS_HistSel_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpOBS.Form_EO_Hist frm = new ExpOBS.Form_EO_Hist();  
			frm.Show();
		}



		#endregion


		private void Form_EC_ETCCRT_Load(object sender, System.EventArgs e)
		{
		  Init_Form(); 
		}


	}
}


