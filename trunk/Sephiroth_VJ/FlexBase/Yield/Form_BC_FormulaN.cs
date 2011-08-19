using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;


namespace FlexBase.Yield
{
	public class Form_BC_FormulaN : COM.PCHWinForm.Form_Top
	{   
		#region 컨트롤 정의 및 리소스 정리
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_style;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_MM;
		public System.Windows.Forms.PictureBox picb_ML;
		private System.Windows.Forms.Label txt_Year1;
		private System.Windows.Forms.Label lBl_Season_CD1;
		private System.Windows.Forms.Label lbl_weight;
		private System.Windows.Forms.Label lbl_gender;
		private C1.Win.C1List.C1Combo cmb_Year;
		private C1.Win.C1List.C1Combo cmb_Season;
		private C1.Win.C1List.C1Combo cmb_Presto;
		private System.Windows.Forms.TextBox txt_Gen;
		private C1.Win.C1List.C1Combo cmb_Style;
		private System.Windows.Forms.TextBox txt_Style;
		private C1.Win.C1List.C1Combo cmb_Yield_Type;
		private System.Windows.Forms.ContextMenu cmenu_Pop;
		private System.Windows.Forms.MenuItem menu_Formula_Copy;
		private System.Windows.Forms.MenuItem menu_Formula_Register;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.Panel panel1;
		private COM.FSP fgrid_YieldValue;
		private System.Windows.Forms.ImageList img_Type;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rad_All;
		private System.Windows.Forms.RadioButton rad_Comp;
		private System.Windows.Forms.RadioButton rad_SG;
		public COM.FSP fgrid_Yield;
		private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Button btn_YieldCopy;
        //private System.Windows.Forms.Button btn_ViewHistory;
        //private System.Windows.Forms.Button btn_FormulaMuti;
        //private System.Windows.Forms.Button btn_BaseFormula;
		private System.Windows.Forms.MenuItem menu_Formula_Base;
		private System.Windows.Forms.MenuItem menu_Material_Change;
		public System.Windows.Forms.CheckBox chk_CheckInOut;
        private Panel panel2;
        private Panel panel3;
        private Button btn_Formula;
        private Button btn_YieldCopy;
        private Button btn_FormulaMuti;
        private Button btn_BaseFormula;
        private Button btn_Clear;
        //private System.Windows.Forms.Button btn_Clear;
		private System.ComponentModel.IContainer components = null;


		// to handle node dragging
		internal struct DRAG_INFO
		{
			public bool		dragging;	// currently dragging
			public bool		checkDrag;	// currently checking mouse to start dragging
			public int		row;		// index of row being dragged
			public Point	mouseDown;	// mouse down position
		}
 


		public Form_BC_FormulaN()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();


			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			Init_Form();


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BC_FormulaN));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Formula = new System.Windows.Forms.Button();
            this.btn_YieldCopy = new System.Windows.Forms.Button();
            this.btn_FormulaMuti = new System.Windows.Forms.Button();
            this.btn_BaseFormula = new System.Windows.Forms.Button();
            this.fgrid_Yield = new COM.FSP();
            this.cmenu_Pop = new System.Windows.Forms.ContextMenu();
            this.menu_Formula_Register = new System.Windows.Forms.MenuItem();
            this.menu_Formula_Base = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menu_Formula_Copy = new System.Windows.Forms.MenuItem();
            this.menu_Material_Change = new System.Windows.Forms.MenuItem();
            this.fgrid_YieldValue = new COM.FSP();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_CheckInOut = new System.Windows.Forms.CheckBox();
            this.rad_All = new System.Windows.Forms.RadioButton();
            this.rad_Comp = new System.Windows.Forms.RadioButton();
            this.rad_SG = new System.Windows.Forms.RadioButton();
            this.cmb_Presto = new C1.Win.C1List.C1Combo();
            this.txt_Gen = new System.Windows.Forms.TextBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.cmb_Yield_Type = new C1.Win.C1List.C1Combo();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.cmb_Year = new C1.Win.C1List.C1Combo();
            this.txt_Year1 = new System.Windows.Forms.Label();
            this.cmb_Season = new C1.Win.C1List.C1Combo();
            this.lBl_Season_CD1 = new System.Windows.Forms.Label();
            this.cmb_Style = new C1.Win.C1List.C1Combo();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.txt_Style = new System.Windows.Forms.TextBox();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_style = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.img_Type = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Yield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_YieldValue)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Presto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Yield_Type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.panel2);
            this.c1Sizer1.Controls.Add(this.fgrid_Yield);
            this.c1Sizer1.Controls.Add(this.fgrid_YieldValue);
            this.c1Sizer1.Controls.Add(this.pnl_Search);
            this.c1Sizer1.GridDefinition = resources.GetString("c1Sizer1.GridDefinition");
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 584);
            this.c1Sizer1.SplitterWidth = 0;
            this.c1Sizer1.TabIndex = 31;
            this.c1Sizer1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(10, 540);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 40);
            this.panel2.TabIndex = 169;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Clear);
            this.panel3.Controls.Add(this.btn_Formula);
            this.panel3.Controls.Add(this.btn_YieldCopy);
            this.panel3.Controls.Add(this.btn_FormulaMuti);
            this.panel3.Controls.Add(this.btn_BaseFormula);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(196, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 40);
            this.panel3.TabIndex = 0;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(287, 9);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 23);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Formula
            // 
            this.btn_Formula.Location = new System.Drawing.Point(393, 9);
            this.btn_Formula.Name = "btn_Formula";
            this.btn_Formula.Size = new System.Drawing.Size(100, 23);
            this.btn_Formula.TabIndex = 9;
            this.btn_Formula.Text = "Formula";
            this.btn_Formula.UseVisualStyleBackColor = true;
            this.btn_Formula.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_YieldCopy
            // 
            this.btn_YieldCopy.Location = new System.Drawing.Point(698, 9);
            this.btn_YieldCopy.Name = "btn_YieldCopy";
            this.btn_YieldCopy.Size = new System.Drawing.Size(100, 23);
            this.btn_YieldCopy.TabIndex = 7;
            this.btn_YieldCopy.Text = "Copy";
            this.btn_YieldCopy.UseVisualStyleBackColor = true;
            this.btn_YieldCopy.Click += new System.EventHandler(this.btn_YieldCopy_Click);
            // 
            // btn_FormulaMuti
            // 
            this.btn_FormulaMuti.Location = new System.Drawing.Point(597, 9);
            this.btn_FormulaMuti.Name = "btn_FormulaMuti";
            this.btn_FormulaMuti.Size = new System.Drawing.Size(100, 23);
            this.btn_FormulaMuti.TabIndex = 6;
            this.btn_FormulaMuti.Text = "Base Formula";
            this.btn_FormulaMuti.UseVisualStyleBackColor = true;
            this.btn_FormulaMuti.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_BaseFormula
            // 
            this.btn_BaseFormula.Location = new System.Drawing.Point(495, 9);
            this.btn_BaseFormula.Name = "btn_BaseFormula";
            this.btn_BaseFormula.Size = new System.Drawing.Size(100, 23);
            this.btn_BaseFormula.TabIndex = 5;
            this.btn_BaseFormula.Text = "Muti Change";
            this.btn_BaseFormula.UseVisualStyleBackColor = true;
            this.btn_BaseFormula.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // fgrid_Yield
            // 
            this.fgrid_Yield.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Yield.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Yield.ContextMenu = this.cmenu_Pop;
            this.fgrid_Yield.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Yield.Location = new System.Drawing.Point(10, 124);
            this.fgrid_Yield.Name = "fgrid_Yield";
            this.fgrid_Yield.Rows.DefaultSize = 19;
            this.fgrid_Yield.Size = new System.Drawing.Size(996, 356);
            this.fgrid_Yield.StyleInfo = resources.GetString("fgrid_Yield.StyleInfo");
            this.fgrid_Yield.TabIndex = 168;
            this.fgrid_Yield.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_Yield_MouseDown);
            this.fgrid_Yield.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_Yield_MouseUp);
            this.fgrid_Yield.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fgrid_Yield_MouseMove);
            this.fgrid_Yield.DoubleClick += new System.EventHandler(this.fgrid_Yield_DoubleClick);
            this.fgrid_Yield.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fgrid_Yield_KeyUp);
            // 
            // cmenu_Pop
            // 
            this.cmenu_Pop.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menu_Formula_Register,
            this.menu_Formula_Base,
            this.menuItem2,
            this.menu_Formula_Copy,
            this.menu_Material_Change});
            // 
            // menu_Formula_Register
            // 
            this.menu_Formula_Register.Index = 0;
            this.menu_Formula_Register.Text = "Formula Register";
            this.menu_Formula_Register.Click += new System.EventHandler(this.menu_Formula_Register_Click);
            // 
            // menu_Formula_Base
            // 
            this.menu_Formula_Base.Index = 1;
            this.menu_Formula_Base.Text = "Base Formula";
            this.menu_Formula_Base.Click += new System.EventHandler(this.menu_Formula_Base_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "-";
            // 
            // menu_Formula_Copy
            // 
            this.menu_Formula_Copy.Index = 3;
            this.menu_Formula_Copy.Text = "Formula Copy";
            this.menu_Formula_Copy.Click += new System.EventHandler(this.menu_Formula_Copy_Click);
            // 
            // menu_Material_Change
            // 
            this.menu_Material_Change.Index = 4;
            this.menu_Material_Change.Text = "Formula Muti Change";
            this.menu_Material_Change.Click += new System.EventHandler(this.menu_Material_Change_Click);
            // 
            // fgrid_YieldValue
            // 
            this.fgrid_YieldValue.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_YieldValue.Location = new System.Drawing.Point(10, 485);
            this.fgrid_YieldValue.Name = "fgrid_YieldValue";
            this.fgrid_YieldValue.Rows.Count = 2;
            this.fgrid_YieldValue.Rows.DefaultSize = 19;
            this.fgrid_YieldValue.Size = new System.Drawing.Size(996, 55);
            this.fgrid_YieldValue.StyleInfo = resources.GetString("fgrid_YieldValue.StyleInfo");
            this.fgrid_YieldValue.TabIndex = 167;
            this.fgrid_YieldValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fgrid_YieldValue_KeyDown);
            this.fgrid_YieldValue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_YieldValue_MouseUp);
            // 
            // pnl_Search
            // 
            this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Search.Controls.Add(this.pnl_SearchImage);
            this.pnl_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Search.Location = new System.Drawing.Point(4, 4);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Search.Size = new System.Drawing.Size(1008, 120);
            this.pnl_Search.TabIndex = 43;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.label1);
            this.pnl_SearchImage.Controls.Add(this.groupBox1);
            this.pnl_SearchImage.Controls.Add(this.cmb_Presto);
            this.pnl_SearchImage.Controls.Add(this.txt_Gen);
            this.pnl_SearchImage.Controls.Add(this.lbl_gender);
            this.pnl_SearchImage.Controls.Add(this.cmb_Yield_Type);
            this.pnl_SearchImage.Controls.Add(this.lbl_weight);
            this.pnl_SearchImage.Controls.Add(this.cmb_Year);
            this.pnl_SearchImage.Controls.Add(this.txt_Year1);
            this.pnl_SearchImage.Controls.Add(this.cmb_Season);
            this.pnl_SearchImage.Controls.Add(this.lBl_Season_CD1);
            this.pnl_SearchImage.Controls.Add(this.cmb_Style);
            this.pnl_SearchImage.Controls.Add(this.cmb_factory);
            this.pnl_SearchImage.Controls.Add(this.txt_Style);
            this.pnl_SearchImage.Controls.Add(this.lbl_factory);
            this.pnl_SearchImage.Controls.Add(this.lbl_style);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_MM);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(992, 104);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(529, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 544;
            this.label1.Text = "Presto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chk_CheckInOut);
            this.groupBox1.Controls.Add(this.rad_All);
            this.groupBox1.Controls.Add(this.rad_Comp);
            this.groupBox1.Controls.Add(this.rad_SG);
            this.groupBox1.Location = new System.Drawing.Point(807, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 67);
            this.groupBox1.TabIndex = 543;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tree Visible Depth";
            // 
            // chk_CheckInOut
            // 
            this.chk_CheckInOut.BackColor = System.Drawing.SystemColors.Window;
            this.chk_CheckInOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chk_CheckInOut.Font = new System.Drawing.Font("Verdana", 9F);
            this.chk_CheckInOut.Location = new System.Drawing.Point(8, 44);
            this.chk_CheckInOut.Name = "chk_CheckInOut";
            this.chk_CheckInOut.Size = new System.Drawing.Size(104, 20);
            this.chk_CheckInOut.TabIndex = 665;
            this.chk_CheckInOut.Text = "Check In/Out";
            this.chk_CheckInOut.UseVisualStyleBackColor = false;
            this.chk_CheckInOut.CheckedChanged += new System.EventHandler(this.chk_CheckInOut_CheckedChanged);
            // 
            // rad_All
            // 
            this.rad_All.Checked = true;
            this.rad_All.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rad_All.Location = new System.Drawing.Point(136, 24);
            this.rad_All.Name = "rad_All";
            this.rad_All.Size = new System.Drawing.Size(35, 16);
            this.rad_All.TabIndex = 36;
            this.rad_All.TabStop = true;
            this.rad_All.Tag = "-1";
            this.rad_All.Text = "All";
            this.rad_All.CheckedChanged += new System.EventHandler(this.rad_SG_CheckedChanged);
            // 
            // rad_Comp
            // 
            this.rad_Comp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rad_Comp.Location = new System.Drawing.Point(72, 24);
            this.rad_Comp.Name = "rad_Comp";
            this.rad_Comp.Size = new System.Drawing.Size(64, 16);
            this.rad_Comp.TabIndex = 35;
            this.rad_Comp.Tag = "2";
            this.rad_Comp.Text = "Comp";
            this.rad_Comp.CheckedChanged += new System.EventHandler(this.rad_SG_CheckedChanged);
            // 
            // rad_SG
            // 
            this.rad_SG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rad_SG.Location = new System.Drawing.Point(8, 24);
            this.rad_SG.Name = "rad_SG";
            this.rad_SG.Size = new System.Drawing.Size(64, 16);
            this.rad_SG.TabIndex = 34;
            this.rad_SG.Tag = "1";
            this.rad_SG.Text = "Semi";
            this.rad_SG.CheckedChanged += new System.EventHandler(this.rad_SG_CheckedChanged);
            // 
            // cmb_Presto
            // 
            this.cmb_Presto.AccessibleDescription = "";
            this.cmb_Presto.AccessibleName = "";
            this.cmb_Presto.AddItemSeparator = ';';
            this.cmb_Presto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Presto.Caption = "";
            this.cmb_Presto.CaptionHeight = 17;
            this.cmb_Presto.CaptionStyle = style1;
            this.cmb_Presto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Presto.ColumnCaptionHeight = 18;
            this.cmb_Presto.ColumnFooterHeight = 18;
            this.cmb_Presto.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Presto.ContentHeight = 17;
            this.cmb_Presto.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Presto.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Presto.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Presto.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Presto.EditorHeight = 17;
            this.cmb_Presto.EvenRowStyle = style2;
            this.cmb_Presto.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Presto.FooterStyle = style3;
            this.cmb_Presto.HeadingStyle = style4;
            this.cmb_Presto.HighLightRowStyle = style5;
            this.cmb_Presto.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Presto.Images"))));
            this.cmb_Presto.ItemHeight = 15;
            this.cmb_Presto.Location = new System.Drawing.Point(629, 54);
            this.cmb_Presto.MatchEntryTimeout = ((long)(2000));
            this.cmb_Presto.MaxDropDownItems = ((short)(5));
            this.cmb_Presto.MaxLength = 32767;
            this.cmb_Presto.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Presto.Name = "cmb_Presto";
            this.cmb_Presto.OddRowStyle = style6;
            this.cmb_Presto.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Presto.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Presto.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Presto.SelectedStyle = style7;
            this.cmb_Presto.Size = new System.Drawing.Size(74, 21);
            this.cmb_Presto.Style = style8;
            this.cmb_Presto.TabIndex = 541;
            this.cmb_Presto.PropBag = resources.GetString("cmb_Presto.PropBag");
            // 
            // txt_Gen
            // 
            this.txt_Gen.BackColor = System.Drawing.Color.White;
            this.txt_Gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Gen.Enabled = false;
            this.txt_Gen.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Gen.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Gen.Location = new System.Drawing.Point(453, 54);
            this.txt_Gen.MaxLength = 100;
            this.txt_Gen.Name = "txt_Gen";
            this.txt_Gen.ReadOnly = true;
            this.txt_Gen.Size = new System.Drawing.Size(74, 21);
            this.txt_Gen.TabIndex = 540;
            // 
            // lbl_gender
            // 
            this.lbl_gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_gender.ImageIndex = 0;
            this.lbl_gender.ImageList = this.img_Label;
            this.lbl_gender.Location = new System.Drawing.Point(352, 54);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(100, 21);
            this.lbl_gender.TabIndex = 542;
            this.lbl_gender.Text = "Gender";
            this.lbl_gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Yield_Type
            // 
            this.cmb_Yield_Type.AccessibleDescription = "";
            this.cmb_Yield_Type.AccessibleName = "";
            this.cmb_Yield_Type.AddItemSeparator = ';';
            this.cmb_Yield_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Yield_Type.Caption = "";
            this.cmb_Yield_Type.CaptionHeight = 17;
            this.cmb_Yield_Type.CaptionStyle = style9;
            this.cmb_Yield_Type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Yield_Type.ColumnCaptionHeight = 18;
            this.cmb_Yield_Type.ColumnFooterHeight = 18;
            this.cmb_Yield_Type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Yield_Type.ContentHeight = 17;
            this.cmb_Yield_Type.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_Yield_Type.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Yield_Type.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Yield_Type.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Yield_Type.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Yield_Type.EditorHeight = 17;
            this.cmb_Yield_Type.EvenRowStyle = style10;
            this.cmb_Yield_Type.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Yield_Type.FooterStyle = style11;
            this.cmb_Yield_Type.HeadingStyle = style12;
            this.cmb_Yield_Type.HighLightRowStyle = style13;
            this.cmb_Yield_Type.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Yield_Type.Images"))));
            this.cmb_Yield_Type.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_Yield_Type.ItemHeight = 15;
            this.cmb_Yield_Type.Location = new System.Drawing.Point(113, 54);
            this.cmb_Yield_Type.MatchEntryTimeout = ((long)(2000));
            this.cmb_Yield_Type.MaxDropDownItems = ((short)(5));
            this.cmb_Yield_Type.MaxLength = 32767;
            this.cmb_Yield_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Yield_Type.Name = "cmb_Yield_Type";
            this.cmb_Yield_Type.OddRowStyle = style14;
            this.cmb_Yield_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Yield_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Yield_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Yield_Type.SelectedStyle = style15;
            this.cmb_Yield_Type.Size = new System.Drawing.Size(220, 21);
            this.cmb_Yield_Type.Style = style16;
            this.cmb_Yield_Type.TabIndex = 539;
            this.cmb_Yield_Type.SelectedValueChanged += new System.EventHandler(this.cmb_Yield_Type_SelectedValueChanged);
            this.cmb_Yield_Type.PropBag = resources.GetString("cmb_Yield_Type.PropBag");
            // 
            // lbl_weight
            // 
            this.lbl_weight.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_weight.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_weight.ImageIndex = 0;
            this.lbl_weight.ImageList = this.img_Label;
            this.lbl_weight.Location = new System.Drawing.Point(13, 54);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(100, 21);
            this.lbl_weight.TabIndex = 538;
            this.lbl_weight.Text = "Value Type";
            this.lbl_weight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Year
            // 
            this.cmb_Year.AddItemSeparator = ';';
            this.cmb_Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Year.Caption = "";
            this.cmb_Year.CaptionHeight = 17;
            this.cmb_Year.CaptionStyle = style17;
            this.cmb_Year.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Year.ColumnCaptionHeight = 18;
            this.cmb_Year.ColumnFooterHeight = 18;
            this.cmb_Year.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Year.ContentHeight = 17;
            this.cmb_Year.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_Year.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Year.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Year.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Year.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Year.EditorHeight = 17;
            this.cmb_Year.EvenRowStyle = style18;
            this.cmb_Year.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Year.FooterStyle = style19;
            this.cmb_Year.HeadingStyle = style20;
            this.cmb_Year.HighLightRowStyle = style21;
            this.cmb_Year.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Year.Images"))));
            this.cmb_Year.ItemHeight = 15;
            this.cmb_Year.Location = new System.Drawing.Point(453, 76);
            this.cmb_Year.MatchEntryTimeout = ((long)(2000));
            this.cmb_Year.MaxDropDownItems = ((short)(5));
            this.cmb_Year.MaxLength = 32767;
            this.cmb_Year.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.OddRowStyle = style22;
            this.cmb_Year.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Year.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Year.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Year.SelectedStyle = style23;
            this.cmb_Year.Size = new System.Drawing.Size(251, 21);
            this.cmb_Year.Style = style24;
            this.cmb_Year.TabIndex = 535;
            this.cmb_Year.PropBag = resources.GetString("cmb_Year.PropBag");
            // 
            // txt_Year1
            // 
            this.txt_Year1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Year1.ImageIndex = 0;
            this.txt_Year1.ImageList = this.img_Label;
            this.txt_Year1.Location = new System.Drawing.Point(352, 76);
            this.txt_Year1.Name = "txt_Year1";
            this.txt_Year1.Size = new System.Drawing.Size(100, 21);
            this.txt_Year1.TabIndex = 537;
            this.txt_Year1.Text = "Year";
            this.txt_Year1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Season
            // 
            this.cmb_Season.AddItemSeparator = ';';
            this.cmb_Season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Season.Caption = "";
            this.cmb_Season.CaptionHeight = 17;
            this.cmb_Season.CaptionStyle = style25;
            this.cmb_Season.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Season.ColumnCaptionHeight = 18;
            this.cmb_Season.ColumnFooterHeight = 18;
            this.cmb_Season.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Season.ContentHeight = 17;
            this.cmb_Season.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Season.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Season.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Season.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Season.EditorHeight = 17;
            this.cmb_Season.EvenRowStyle = style26;
            this.cmb_Season.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Season.FooterStyle = style27;
            this.cmb_Season.HeadingStyle = style28;
            this.cmb_Season.HighLightRowStyle = style29;
            this.cmb_Season.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Season.Images"))));
            this.cmb_Season.ItemHeight = 15;
            this.cmb_Season.Location = new System.Drawing.Point(113, 76);
            this.cmb_Season.MatchEntryTimeout = ((long)(2000));
            this.cmb_Season.MaxDropDownItems = ((short)(5));
            this.cmb_Season.MaxLength = 32767;
            this.cmb_Season.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Season.Name = "cmb_Season";
            this.cmb_Season.OddRowStyle = style30;
            this.cmb_Season.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Season.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Season.SelectedStyle = style31;
            this.cmb_Season.Size = new System.Drawing.Size(220, 21);
            this.cmb_Season.Style = style32;
            this.cmb_Season.TabIndex = 536;
            this.cmb_Season.PropBag = resources.GetString("cmb_Season.PropBag");
            // 
            // lBl_Season_CD1
            // 
            this.lBl_Season_CD1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBl_Season_CD1.ImageIndex = 0;
            this.lBl_Season_CD1.ImageList = this.img_Label;
            this.lBl_Season_CD1.Location = new System.Drawing.Point(13, 76);
            this.lBl_Season_CD1.Name = "lBl_Season_CD1";
            this.lBl_Season_CD1.Size = new System.Drawing.Size(100, 21);
            this.lBl_Season_CD1.TabIndex = 534;
            this.lBl_Season_CD1.Text = "Season";
            this.lBl_Season_CD1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Style
            // 
            this.cmb_Style.AccessibleDescription = "";
            this.cmb_Style.AccessibleName = "";
            this.cmb_Style.AddItemSeparator = ';';
            this.cmb_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Style.Caption = "";
            this.cmb_Style.CaptionHeight = 17;
            this.cmb_Style.CaptionStyle = style33;
            this.cmb_Style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Style.ColumnCaptionHeight = 18;
            this.cmb_Style.ColumnFooterHeight = 18;
            this.cmb_Style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Style.ContentHeight = 17;
            this.cmb_Style.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Style.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Style.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Style.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Style.EditorHeight = 17;
            this.cmb_Style.EvenRowStyle = style34;
            this.cmb_Style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Style.FooterStyle = style35;
            this.cmb_Style.HeadingStyle = style36;
            this.cmb_Style.HighLightRowStyle = style37;
            this.cmb_Style.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Style.Images"))));
            this.cmb_Style.ItemHeight = 15;
            this.cmb_Style.Location = new System.Drawing.Point(528, 32);
            this.cmb_Style.MatchEntryTimeout = ((long)(2000));
            this.cmb_Style.MaxDropDownItems = ((short)(5));
            this.cmb_Style.MaxLength = 32767;
            this.cmb_Style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Style.Name = "cmb_Style";
            this.cmb_Style.OddRowStyle = style38;
            this.cmb_Style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Style.SelectedStyle = style39;
            this.cmb_Style.Size = new System.Drawing.Size(175, 21);
            this.cmb_Style.Style = style40;
            this.cmb_Style.TabIndex = 532;
            this.cmb_Style.SelectedValueChanged += new System.EventHandler(this.cmb_Style_SelectedValueChanged);
            this.cmb_Style.PropBag = resources.GetString("cmb_Style.PropBag");
            // 
            // cmb_factory
            // 
            this.cmb_factory.AccessibleDescription = "";
            this.cmb_factory.AccessibleName = "";
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style41;
            this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_factory.ColumnCaptionHeight = 18;
            this.cmb_factory.ColumnFooterHeight = 18;
            this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_factory.ContentHeight = 17;
            this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory.EditorHeight = 17;
            this.cmb_factory.EvenRowStyle = style42;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style43;
            this.cmb_factory.HeadingStyle = style44;
            this.cmb_factory.HighLightRowStyle = style45;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(113, 32);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style46;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style47;
            this.cmb_factory.Size = new System.Drawing.Size(220, 21);
            this.cmb_factory.Style = style48;
            this.cmb_factory.TabIndex = 31;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            // 
            // txt_Style
            // 
            this.txt_Style.BackColor = System.Drawing.Color.White;
            this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Style.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Style.Location = new System.Drawing.Point(453, 32);
            this.txt_Style.MaxLength = 100;
            this.txt_Style.Name = "txt_Style";
            this.txt_Style.Size = new System.Drawing.Size(74, 21);
            this.txt_Style.TabIndex = 531;
            this.txt_Style.TextChanged += new System.EventHandler(this.txt_Style_TextChanged);
            this.txt_Style.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Style_KeyUp);
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(13, 32);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 528;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_style
            // 
            this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_style.ImageIndex = 0;
            this.lbl_style.ImageList = this.img_Label;
            this.lbl_style.Location = new System.Drawing.Point(352, 32);
            this.lbl_style.Name = "lbl_style";
            this.lbl_style.Size = new System.Drawing.Size(100, 21);
            this.lbl_style.TabIndex = 527;
            this.lbl_style.Text = "Style Code";
            this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(891, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(101, 64);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(976, 0);
            this.picb_TR.Name = "picb_TR";
            this.picb_TR.Size = new System.Drawing.Size(16, 40);
            this.picb_TR.TabIndex = 21;
            this.picb_TR.TabStop = false;
            // 
            // picb_TM
            // 
            this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
            this.picb_TM.Location = new System.Drawing.Point(224, 0);
            this.picb_TM.Name = "picb_TM";
            this.picb_TM.Size = new System.Drawing.Size(768, 40);
            this.picb_TM.TabIndex = 0;
            this.picb_TM.TabStop = false;
            // 
            // lbl_SubTitle1
            // 
            this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
            this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle1.Name = "lbl_SubTitle1";
            this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle1.TabIndex = 28;
            this.lbl_SubTitle1.Text = "      Yield Info.";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(976, 89);
            this.picb_BR.Name = "picb_BR";
            this.picb_BR.Size = new System.Drawing.Size(16, 16);
            this.picb_BR.TabIndex = 23;
            this.picb_BR.TabStop = false;
            // 
            // picb_BM
            // 
            this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
            this.picb_BM.Location = new System.Drawing.Point(144, 88);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(832, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 89);
            this.picb_BL.Name = "picb_BL";
            this.picb_BL.Size = new System.Drawing.Size(168, 20);
            this.picb_BL.TabIndex = 22;
            this.picb_BL.TabStop = false;
            // 
            // picb_MM
            // 
            this.picb_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
            this.picb_MM.Location = new System.Drawing.Point(144, 32);
            this.picb_MM.Name = "picb_MM";
            this.picb_MM.Size = new System.Drawing.Size(824, 72);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // picb_ML
            // 
            this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
            this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
            this.picb_ML.Location = new System.Drawing.Point(0, 24);
            this.picb_ML.Name = "picb_ML";
            this.picb_ML.Size = new System.Drawing.Size(168, 71);
            this.picb_ML.TabIndex = 25;
            this.picb_ML.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
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
            // Form_BC_FormulaN
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BC_FormulaN";
            this.Load += new System.EventHandler(this.Form_BC_FormulaN_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_BC_FormulaN_Closing);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Yield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_YieldValue)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Presto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Yield_Type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수정의
		int  _Rowfixed  = 2,_PointShort = 6, _PointLong =11 ;

		string _Blank  = "None",_BlankText  = " ", _SendCheck  = " ",_BlankValue="0";  
		string _BaseStyle ="304880161";	
		DataTable _Dt_Size_Range; 
		bool  _Checkin_Cancel  = false;

		private COM.OraDB _MyOraDB = new COM.OraDB();

		private string _remark ="Yield Formula Reigister";


		#region 사이즈별 채산값 기본 설정
		int _Row_EYield, _Row_MYield, _Row_SpecCd, _Row_SpecName , _Row_YieldValue=  2, _MatStrRow=0, _MatEndRow;
		int _ColFixed = 2 ,_init  =  0;
		double _TotalMix  = 100 ;

		string _YieldTypeE_Desc = "Yield (E)";
		string _YieldTypeM_Desc = "Yield (M)";
		string _SpecCd_Desc		= "Spec. Cd";
		string _Spec_Desc  = "Spec.";	
		string _YieldType  = "E";
		string _YieldTypeE = "E";
		string _YieldTypeM = "M";
		string _Size_YN    = "N";
		string _Component  = "C";
		string _SemiGood   = "S";
		//string _Material   = "M";
		string _Base_Formula ="B";
		//string _Pigment_Formula ="P";
		string _Base_Flag ="0";
		string _Pigment_Flag ="1";
		string _Head = "H";
		string _Tail = "T";
		string _Material  ="M";
		string _Mcs ="";
		


		
		#endregion

		#region 칼라 설정
		private Color _Base_Color    = ClassLib.ComVar.ClrSel_Green;
		private Color _Pigment_Color = ClassLib.ComVar.ClrSel_Yellow;
		private Color _SizeColor1    = ClassLib.ComVar.ClrSel_Green;
		private Color _SizeColor2    = ClassLib.ComVar.ClrSel_Yellow;
		private Color _CurrentColor  =  ClassLib.ComVar.ClrSel_Green;
		#endregion

		#region  행 이미지 저장
		private Hashtable _Imgmap = new Hashtable();
		private Hashtable _ImgmapAction = new Hashtable();

		private const string _TypeSG = "S", _TypeCmp = "C", _TypeMat = "M", _TypeJoint = "J";

		private int _IxImage_SG = 1, _IxImage_Cmp = 2, _IxImage_Mat = 3, _IxImage_Joint = 4;
		private int _IxImage_Move = 5; 
 

		#endregion

		#region 마우스 드래그
		private DRAG_INFO _DragInfo; 
		private const int _DragTol = 5;	// mouse movement before dragging starts

		private const int _SGLevel = 1, _CmpLevel = 2;//	

		#endregion

		#endregion

		#region 멤버 메소드

		private void Init_Form()
		{
			//Title
			this.Text = "Formula Register";
			lbl_MainTitle.Text = "   Formula Register";
			ClassLib.ComFunction.SetLangDic(this);
 

			#region  그리드 설정			
			
			SetInit();

			fgrid_Yield.Cols[0].AllowEditing = false;
			fgrid_Yield.DragMode = DragModeEnum.Manual;//Automatic;
			fgrid_Yield.DropMode = DropModeEnum.Manual; 
			
			#endregion

		
			Control_Enable(false); 
			

		}


		


		// 체크 아웃 실패 되었을때, 다시 체크 인 표시 해 주고, 이벤트 태우지 않기 위함
		//private bool _FromCheckOut = false;

		private bool _CheckInFail = false;
		private bool _CheckOutFail = false;

		private string _CheckInSeq = "0";

		private void Run_Check_In()
		{
			

			
			if( _CheckOutFail ) return;
 

			string division = "I"; // In
			string factory = cmb_factory.SelectedValue.ToString();
			string stylecd = cmb_Style.SelectedValue.ToString().Replace("-", "");
			string checkuser = ClassLib.ComVar.This_User;
            string remarks = "formula register-" + checkuser;



			
			if(_Checkin_Cancel)   // local 만 체크
			{
				Run_Check_In_Local(division, factory, stylecd, checkuser, remarks);
			}
			else  // remote, local 모두 체크
			{
				Run_Check_In_RemoteLocal(division, factory, stylecd, checkuser, remarks);
			}


			



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

                if (dt_job == null)
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

                if (dt_user == null)  //miyoung.kim   dt_user != null
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
				DataSet ds_job = Save_Check_Formula_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);
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
				DataSet ds_user = Save_Check_Formula_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);

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
				DataSet ds_user = Save_Check_Formula_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);

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
				//_FromCheckOut = true;

				_CheckOutFail = true;

				chk_CheckInOut.CheckState = CheckState.Checked;

				return;
			}
			//-----------------------------------------------------------------------------------------------



			string division = "O"; // Out
			string factory = cmb_factory.SelectedValue.ToString();
			string stylecd = cmb_Style.SelectedValue.ToString().Replace("-", "");
			string checkuser = ClassLib.ComVar.This_User;
			string remarks = "check out";
 

			string job_factory = ClassLib.ComVar.This_Factory; 
			DataSet ds_ret = Save_Check_Formula_InOut(division, factory, stylecd, _CheckInSeq, checkuser, remarks, job_factory);


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



		private bool Check_Clear()
		{
			try
			{
				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

				int  iR1 = fgrid_Yield.Selection.r1;


				fgrid_Yield [iR1,0] ="D";

				//자재이면 원상복귀
				if (fgrid_Yield[ iR1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() != _Component )
				{
					fgrid_Yield [iR1,0] =" ";
					return false;
				}

					
				if (iR1 != fgrid_Yield.Rows.Count-1 )
				{
					//하단 자식이자재이면  원상복귀
					if (fgrid_Yield[ iR1+1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() == _Material)
					{
						fgrid_Yield [iR1,0] =" ";
						return false;
					}
			
				}

				this.Cursor = System.Windows.Forms.Cursors.Default;

				return true;

			}
			catch(Exception ex)
			{   
				ClassLib.ComFunction.User_Message(ex.Message, "Check_Clear", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
				
			}

		}


		/// <summary>
		/// Control_Enable : Check In/Out 에 대한 콘트롤 권한 부여
		/// </summary>
		/// <param name="arg_enable"></param>
		private void Control_Enable(bool arg_enable)
		{

			fgrid_Yield.AllowEditing = arg_enable;
			

			btn_Formula.Enabled     = arg_enable; 
			btn_YieldCopy.Enabled = arg_enable; 
			btn_BaseFormula.Enabled = arg_enable; 
			btn_FormulaMuti.Enabled = arg_enable;
           

			if(arg_enable)  //check되면
			{ 
                tbtn_Save.Enabled = arg_enable;
				tbtn_Delete.Enabled = arg_enable;

				btn_YieldCopy.Enabled = arg_enable; 
				btn_BaseFormula.Enabled = arg_enable; 
				btn_FormulaMuti.Enabled = arg_enable;
                btn_Formula.Enabled = arg_enable;


                btn_YieldCopy.Enabled = arg_enable;
                btn_Clear.Enabled = arg_enable;
                //btn_ViewHistory.Enabled = false;



				tbtn_Save.Enabled = arg_enable;  
				tbtn_Delete.Enabled = arg_enable;

                
				cmb_factory.Enabled = !arg_enable;
				txt_Style.Enabled = !arg_enable;
				cmb_Style.Enabled = !arg_enable;


				fgrid_Yield.ContextMenu = cmenu_Pop; 

				cmb_factory.EditorBackColor = Color.FromKnownColor(KnownColor.Control);
				cmb_Style.EditorBackColor = Color.FromKnownColor(KnownColor.Control); 
			}
			else
			{  

				tbtn_Save.Enabled = arg_enable;  
				tbtn_Delete.Enabled = arg_enable;  
				
				
				btn_YieldCopy.Enabled = arg_enable; 
				btn_BaseFormula.Enabled = arg_enable; 
				btn_FormulaMuti.Enabled = arg_enable;
                btn_Formula.Enabled = arg_enable;

                btn_YieldCopy.Enabled = arg_enable;
                btn_Clear.Enabled = arg_enable;
                //btn_ViewHistory.Enabled = false;

				
				cmb_factory.Enabled = !arg_enable;
				txt_Style.Enabled = !arg_enable;
				cmb_Style.Enabled = !arg_enable;


				fgrid_Yield.ContextMenu = null;  

				cmb_factory.EditorBackColor = Color.FromKnownColor(KnownColor.Window);
				cmb_Style.EditorBackColor = Color.FromKnownColor(KnownColor.Window); 
			}


            if (ClassLib.ComVar.This_Factory != "DS") cmb_factory.Enabled = false;
			cmb_factory.Focus();
			cmb_Style.Focus();

			
		

		
			


		}



		private void SetInit()
		{
			DataTable dt_list;
			// 공장코드
			dt_list = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_list, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

            if (ClassLib.ComVar.This_Factory != "DS")
                cmb_factory.Enabled = false;


			


			//year
			ClassLib.ComFunction.Set_Year(cmb_Year,ClassLib.ComVar.ConsAll);

			// season 
			dt_list =  ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSeason);
			COM.ComCtl.Set_ComboList(dt_list, cmb_Season , 1, 2,  false, false);
			cmb_Season.SelectedValue    = ClassLib.ComVar.ConsBaseSN;


			//gen
			ClassLib.ComFunction.Set_Yield_Type(cmb_Yield_Type,ClassLib.ComVar.ConsAll);
			cmb_Yield_Type.SelectedValue  = _YieldTypeM;

			// Style
			dt_list = ClassLib.ComFunction.Select_StyleList(" ");
			COM.ComCtl.Set_ComboList(dt_list, cmb_Style , 0, 1, false,70,150);

			//Presto_YN
			dt_list = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,ClassLib.ComVar.CxPst_yn);
			ClassLib.ComCtl.Set_ComboList(dt_list,cmb_Presto , 1, 2, false, false);
			cmb_Presto.SelectedValue  = ClassLib.ComVar.ConsY;
			cmb_Presto.Enabled  = false;

			_Row_YieldValue = fgrid_YieldValue.Rows.Fixed;
		
			fgrid_Yield.SelectionMode = SelectionModeEnum.Cell;  
			fgrid_Yield.AllowDragging = AllowDraggingEnum.None;

			dt_list.Dispose();

			SetClear();



		}


		private void SetClear()
		{

			//Seaon별 Formula관리 시점 까지 그냥 사용
			
			cmb_Year.SelectedValue ="2006";
			cmb_Season.SelectedValue ="SP";
			cmb_Yield_Type.SelectedValue  = _YieldTypeM;


			cmb_Style.Text		= "";
			cmb_Presto.Text		= "";

			txt_Style.Clear();
			txt_Gen.Clear();

			fgrid_Yield.Rows.Count  =  fgrid_Yield.Rows.Fixed;
			fgrid_Yield.Rows.Count  =  fgrid_YieldValue.Rows.Fixed;

			cmb_Year.Enabled  = false;
			cmb_Presto.Enabled  = false;
			cmb_Season.Enabled  = false;
			cmb_Yield_Type.Enabled  = false;


			btn_YieldCopy.Enabled = false; 
			btn_BaseFormula.Enabled = false; 
			btn_FormulaMuti.Enabled = false; 
 


			_YieldType =cmb_Yield_Type.SelectedValue.ToString();
			
			SetBaseInfo(_BaseStyle);

		}


		private void SetGridFlagClear()
		{
			
			for (int i = fgrid_Yield.Rows.Count-1 ; i> fgrid_Yield.Rows.Fixed ;--i)
			{  
				
				if ((fgrid_Yield[i,0].ToString() == "I") || (fgrid_Yield[i,0].ToString() == "U")) 
					fgrid_Yield[i,0] = ""; 

				else if (fgrid_Yield[i,0].ToString()  == "D")   
				{
					if (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD].ToString()  != _SemiGood)
						fgrid_Yield.Rows.Remove(i);   
					else
						fgrid_Yield[i,0] = "";	
				}
   
				else    fgrid_Yield[i,0] = "";
				
			}
			

		}


		
		/// <summary>
		/// Set_CellStyle_Number : number 형 셀타입 설정 (예 : 1,234,567.001)
		/// </summary>
		/// <param name="arg_col"></param>
		public void Set_CellStyle_Numberic(C1FlexGrid arg_fgrid,int arg_col)
		{ 
			CellStyle cellst = arg_fgrid.Styles.Add("NUMBER", arg_fgrid.Cols[arg_col].Style);

			cellst.DataType = typeof(double);
			cellst.Format = "#,##0.##########";  

			arg_fgrid.Cols[arg_col].Style = arg_fgrid.Styles["NUMBER"]; 
			arg_fgrid.Cols[arg_col].TextAlign =TextAlignEnum.RightCenter ;
		}



		
		private void SetBaseInfo(string arg_style)
		{


			if (cmb_Style.SelectedIndex   != -1) 
			{
				txt_Style.Text = cmb_Style.SelectedValue.ToString();			
			}

			ClassLib.ComFunction.Select_Gen_Pst(arg_style.Replace("-",""));
			txt_Gen.Text    = ClassLib.ComVar.DivGen;
			cmb_Presto.SelectedValue  = ClassLib.ComVar.DivPst;
					
					
			//상단 그리드
			fgrid_Yield.Set_Grid("SBC_FORMULAN_YIELD", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_Yield.Display_Size_ColHead(cmb_factory.SelectedValue.ToString(), arg_style ,100,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOL_ORDER+1); 
			for(int i =(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOL_ORDER; i < fgrid_Yield.Cols.Count; i++)
			{
				Set_CellStyle_Numberic(fgrid_Yield,i);
			}
 
			
			//하단 그리드
			Add_fgrid_YieldValue_Default_Row();			
			fgrid_YieldValue.Set_Grid("SBC_YIELD_VALUE", "3", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_YieldValue.SelectionMode = SelectionModeEnum.CellRange;	


			
			// i, d, u 이외에 drag 데이터(m)에 대한 기타 flag 값 추가
			_ImgmapAction = fgrid_Yield.Set_Action_Image(img_Action, true); 
			_ImgmapAction.Add("M", img_Type.Images[_IxImage_Move]); 


		}


		
		private int FindCompoentRow()
		{

			if (_Mcs.Length  != 10)
			{
				for (int i = _Rowfixed ; i<fgrid_Yield.Rows.Count   ;i++)
				{
					if (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_CD].ToString() !="")
						return i;
				}

			}
			else
			{
				return fgrid_Yield.Selection.r1;
			}

			return _Rowfixed; 

		}


		/// <summary>
		/// Check_NotSave_Data : 저장되지 않은 데이터 있을 때 조회하면 경고 메시지 표시
		/// </summary>
		private bool Check_NotSave_Data(string arg_part_message)
		{
			
			bool exist_modify = false;

			if (fgrid_Yield.Rows.Fixed < fgrid_Yield.Rows.Count)
			{
				
				string vTemp = fgrid_Yield.GetCellRange(fgrid_Yield.Rows.Fixed, 0, fgrid_Yield.Rows.Count - 1, 0).Clip.Replace("\r", "");
	
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
		 


		#region 채산값 입력 그리드 기본 Setting
		/// <summary>
		/// 채산값 입력 그리드 기본 행 추가 (E 채산, M 채산, Sepcification 행)
		/// </summary>
		private void Add_fgrid_YieldValue_Default_Row()
		{
			fgrid_YieldValue.Rows.InsertRange(fgrid_YieldValue.Rows.Fixed, 4);
			//fgrid_YieldValue.Rows.i(fgrid_YieldValue.Rows.Fixed, 4);
 

			_Row_EYield = fgrid_YieldValue.Rows.Fixed;
			_Row_MYield = fgrid_YieldValue.Rows.Fixed + 1;
			_Row_SpecCd = fgrid_YieldValue.Rows.Fixed + 2;
			_Row_SpecName = fgrid_YieldValue.Rows.Fixed + 3;


			fgrid_YieldValue[_Row_EYield, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxDESCRIPTION] = _YieldTypeE_Desc;
			fgrid_YieldValue[_Row_MYield, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxDESCRIPTION] = _YieldTypeM_Desc;
			fgrid_YieldValue[_Row_SpecCd, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxDESCRIPTION] = _SpecCd_Desc;
			fgrid_YieldValue[_Row_SpecName, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxDESCRIPTION] = _Spec_Desc;
 

			//fgrid_YieldValue.Cols[0].Visible = false;  
			fgrid_YieldValue.Cols.Fixed = _ColFixed;

			
			
			if(_YieldType == _YieldTypeE)
			{
				fgrid_YieldValue.Rows[_Row_EYield].Visible = true;
				fgrid_YieldValue.Rows[_Row_MYield].Visible = false;

				_Row_YieldValue = _Row_EYield;

			}
			else if(_YieldType == _YieldTypeM)
			{
				fgrid_YieldValue.Rows[_Row_EYield].Visible = false;
				fgrid_YieldValue.Rows[_Row_MYield].Visible = true;
				
				_Row_YieldValue = _Row_MYield;
			}
			fgrid_YieldValue.Rows[_Row_SpecCd].Visible = false;
			fgrid_YieldValue.Rows[_Row_SpecName ].Visible = false;


		}


		#endregion

		#region Size별 채산값
		///향후 UPPER랑 분리해서 간단하게 Pop창 만들기
		/// <summary>
		/// Show_Input_YieldValue_Popup : 채산값 입력 팝업 실행 
		/// 마우스 오른쪽 버튼 클릭 : 한 컬럼 선택해도 팝업 실행 가능
		/// 마우스 왼쪽 버튼 클릭 : 두개 이상의 컬럼 선택 시 팝업 실행 가능
		/// </summary>
		/// <param name="arg_mousebutton"></param>
		private void Show_Input_YieldValue_Popup(MouseButtons arg_mousebutton)
		{
			try
			{ 
				int c1 = fgrid_YieldValue.Selection.c1;
				int c2 = fgrid_YieldValue.Selection.c2;

				c1 = (c1 <c2) ? c1 : c2;
				c2 = (c1 < c2) ? c2 : c1;

				if(arg_mousebutton.Equals(MouseButtons.Left) )
				{
					if(c1 == c2) return;
				}

				#region 채산값 받아오기
				if(fgrid_Yield[fgrid_Yield.Selection.r1, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxITEM_CD].ToString() == "")
				{
					ClassLib.ComFunction.User_Message("Select Item", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if(fgrid_Yield[fgrid_Yield.Selection.r1, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxSPEC_CD].ToString() == "")
				{
					ClassLib.ComFunction.User_Message("Select Sepcification", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if(fgrid_Yield[fgrid_Yield.Selection.r1, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOLOR_CD].ToString() == "")
				{
					ClassLib.ComFunction.User_Message("Select Color", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				string yield_type = _YieldType;
				string cs_size_f = fgrid_YieldValue[1, c1].ToString();
				string cs_size_t = fgrid_YieldValue[1, c2].ToString();
				string yield_value = (fgrid_YieldValue[_Row_YieldValue, c1] == null) ? "0" : fgrid_YieldValue[_Row_YieldValue, c1].ToString();

				string size_yn = _Size_YN;
				string item_speccd = fgrid_Yield[fgrid_Yield.Selection.r1, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxSPEC_CD].ToString();
				string spec_div = fgrid_Yield[fgrid_Yield.Selection.r1,  (int)ClassLib.TBSBC_FORMULAN_YIELD.lxSPEC_CD].ToString().Substring(0,1);

				string spec_cd = fgrid_Yield[fgrid_Yield.Selection.r1,  (int)ClassLib.TBSBC_FORMULAN_YIELD.lxSPEC_CD].ToString();
 
				string[] pop_parameter = new string[] { yield_type, cs_size_f, cs_size_t, yield_value, _Size_YN, spec_div, spec_cd };

				FlexBase.Yield.Pop_Yield_Value pop_form = new Pop_Yield_Value(pop_parameter);
				pop_form.ShowDialog();

				string pop_yield_value = ClassLib.ComVar.Parameter_PopUp[0];
				string pop_spec_cd = ClassLib.ComVar.Parameter_PopUp[1];
				string pop_spec_name = ClassLib.ComVar.Parameter_PopUp[2];

				//cancel 했을 경우
				if(pop_yield_value == "") return;

				#endregion


				for(int i = c1; i <= c2; i++)
				{
					fgrid_YieldValue[_Row_YieldValue, i] = pop_yield_value;
					fgrid_YieldValue[_Row_SpecCd, i] = pop_spec_cd;
					fgrid_YieldValue[_Row_SpecName, i] = pop_spec_name; 
				}

				//Size Value재계산을 위한 위치 잡기 전역변수에 선언
				FindPositionCal(fgrid_Yield[fgrid_Yield.Selection.r1 , (int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD].ToString(),
					fgrid_Yield[fgrid_Yield.Selection.r1 , (int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_CD].ToString(),
					fgrid_Yield[fgrid_Yield.Selection.r1 , (int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_COLOR].ToString());
				
				//Color Setting..
				SetValueColor();


				//Size Value 재계산 (Mix에 따라서 )
				SetCalYIeldValue(_MatStrRow, _MatEndRow);

				//채산값만 SubTotal구하기.
				MakeTotalYieldValue(_MatStrRow-1, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA,
					(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMIX,
					(int)ClassLib.TBSBC_FORMULAN_YIELD.lxYIELD_M,  false , true, "U");

				

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Input_YieldValue_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		#endregion

		#region YIeld /Weight조회 모듈
		/// <summary>
		/// Display_CrossTab : CrossTab조회
		/// </summary>
		/// <param name="arg_dt">data table</param>
		/// <param name="arg_key_fr">key field from 칼럼번호</param>		
		/// <param name="arg_key_to">key field to 칼럼번호</param>
		/// <param name="arg_db_colorder_pos">db에서 column order 위치(0.1..) </param>		
		/// <param name="arg_db_value_pos">db의 채산값 위치 (0.1...)</param>		
		/// <param name="arg_grid_size_pos">그리드에서 사이즈런 시작 위치-1</param>
		/// db 데이타 가져올시 마지막에...:  채산값 + col위치		
		public  void Display_CrossTab(DataTable arg_dt,int arg_key_fr,int arg_key_to,int arg_db_colorder_pos,
			int arg_db_value_pos, int arg_grid_size_pos,  bool arg_tree)
		{
		 							
			string str_newkey = "" ;
			string str_oldkey = "" ;
			
			try 
			{	
				
				//ROW 초기화
				fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed ;  				

					

				//loop - DATA row
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{		
					str_newkey = "" ;
					
					//key field 생성
					for(int k = arg_key_fr; k <= arg_key_to; k++)
					{
						str_newkey = str_newkey + arg_dt.Rows[i].ItemArray[k].ToString() ;
					}					
															
					//loop -DATA column(마지막ROW는 제외)
					for(int j = 0; j < arg_dt.Columns.Count; j++)
					{							
						if(j <= arg_db_colorder_pos)
						{
							//key field가 변경시 새로운 row 생성
							if(str_newkey != str_oldkey && j == 0)
							{
								if(arg_tree)
								{	
									fgrid_Yield.Rows.InsertNode(fgrid_Yield.Rows.Count,int.Parse(arg_dt.Rows[i].ItemArray[j].ToString()));
								}
								else
								{
									fgrid_Yield.AddItem("",fgrid_Yield.Rows.Count);								
								}
							}
							
							// set division column
							fgrid_Yield[fgrid_Yield.Rows.Count-1, 0] = "";

							//칼럼이 크로스탭 항목일때:사이즈-1(28:그리드 상의사이즈런 -1 위치 ,  사이즈런 COL ORDER : 27
							if(j == arg_db_colorder_pos)
							{
							

								//칼럼헤드의 위치를 조회하여 데이타 디스플레이
								try
								{  
									if(int.Parse(arg_dt.Rows[i].ItemArray[arg_db_colorder_pos].ToString()) > 0)
									{
										fgrid_Yield[fgrid_Yield.Rows.Count-1, arg_grid_size_pos+ int.Parse(arg_dt.Rows[i].ItemArray[arg_db_colorder_pos].ToString())]
											= Math.Round(Convert.ToDouble(arg_dt.Rows[i].ItemArray[arg_db_value_pos].ToString()),_PointLong) ;
										
									}
								}
								catch
								{

								}
									
							}

							if(j <= arg_db_colorder_pos)
							{
								fgrid_Yield[fgrid_Yield.Rows.Count-1,j+1] = arg_dt.Rows[i].ItemArray[j] ;
							}
							//return ;					
						}
					}

					str_oldkey = str_newkey;	
					
				
				}		
	
				
				//				fgrid_Yield.Set_CellStyle_Number((int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA);	
				//				fgrid_Yield.Set_CellStyle_Number((int)ClassLib.TBSBC_FORMULAN_YIELD.lxMIX);	
				//				for (int k = arg_db_value_pos ; k <= fgrid_Yield.Cols.Count -1 ;k++)
				//				{
				//					fgrid_Yield.Set_CellStyle_Number(k);												 
				//				}

					
			}			
			
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_CrossTab",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
	
		}




		private void SetYield()
		{
			try
			{
				
				DataTable dt_ret;

				dt_ret = SelectYield();

				if (dt_ret.Rows.Count  == 0) 
				{ ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch); return;}

				fgrid_Yield.Rows.Count = _Rowfixed;
				fgrid_Yield.Tree.Column = (int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE;
			
                
				//Display_CrossTab(dt_ret,1,1,42,41,43, true);     
				int iGender     =  (int)ClassLib.TBSBC_FORMULAN_YIELD.lxGENDER;
				int iYieldStart =  (int)ClassLib.TBSBC_FORMULAN_YIELD.lxYIELD_M;
				int iColOrder   =  (int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOL_ORDER;

				Display_CrossTab(dt_ret,1,1,iYieldStart , iGender  ,iColOrder, true);


				#region 그림이미지
				_Imgmap.Clear();

				for(int i = fgrid_Yield.Rows.Fixed; i < fgrid_Yield.Rows.Count; i++)
				{
					Display_Type_Image(i);

					//칼라 Setting
					/*
					fgrid_Yield.GetCellRange(i,  iFormula_Div ).StyleNew.BackColor = 
						(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA_SEQ ].ToString() == _Formula)?_Base_Color:_Pigment_Color;
					*/

				}
  
				fgrid_Yield.Cols[(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ImageAndText = true; 
				fgrid_Yield.Cols[(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ImageMap     = _Imgmap;  

				#endregion
			

				SetYieldColor();    //2006.09.07 

			
				FindPositionTotal(_Rowfixed, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxMIX,
					(int)ClassLib.TBSBC_FORMULAN_YIELD.lxYIELD_M, true, true);


				SetFormulaWeight();


			

																										   

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetYield", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		
		/// <summary>
		/// SetValueColor:ValueColor 뿌리기
		/// </summary>
		/// <returns></returns>
		private void SetYieldColor()
		{					
	
			int  iStart  = 0; 
			string sOldValue ,sNewValue ;
			for (int  i  = _Rowfixed ; i< fgrid_Yield.Rows.Count; i++)
			{

				if (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString()  !=  _Material) continue;
				iStart = (int)ClassLib.TBSBC_FORMULAN_YIELD.lxYIELD_M;
				sOldValue  = sNewValue  = "";
				Color _CurrentColor = ClassLib.ComVar.ClrSel_Green;
				for (int  j =(int)ClassLib.TBSBC_FORMULAN_YIELD.lxYIELD_M ; j< fgrid_Yield.Cols.Count; j++)
				{
					sNewValue  =  fgrid_Yield [i,j].ToString();

					if (sOldValue == sNewValue) 

						fgrid_Yield.GetCellRange(i,iStart, i, j).StyleNew.BackColor = _CurrentColor;

					else
					{
						iStart = j;

						if(_CurrentColor.Equals(_SizeColor1) )
						{
							_CurrentColor = _SizeColor2;
						}
						else
						{
							_CurrentColor = _SizeColor1;
						}

						fgrid_Yield.GetCellRange(i,iStart, i , j).StyleNew.BackColor = _CurrentColor;
					}					
					
					sOldValue = sNewValue;

				}
			}

			fgrid_Yield.GetCellRange(_Rowfixed,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA , 
				fgrid_Yield.Rows.Count -1, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA).StyleNew.ForeColor  = ClassLib.ComVar.ClrFormulaEdit;

		}


		/// <summary>
		///  SetFormulaWeight: FormulaWeigt 뿌리기
		/// </summary>
		/// <returns></returns>
		private void SetFormulaWeight()
		{
			try
			{
			
				int iRow  = FindCompoentRow();
				
				DataTable dt_ret;

				dt_ret = SelectFormulaWeight(iRow);

				if (dt_ret.Rows.Count  == 0) 
				{ ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch); return;}

				DisPlayFormulaWeight(dt_ret);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetFormula", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		/// <summary>
		/// SetYieldWeight : 채산조회 및 Weight입력창 Setting...
		/// </summary>
		private void SetYieldWeight()
		{
			this.Cursor = Cursors.WaitCursor;
			fgrid_YieldValue.Display_Size_ColHead(cmb_factory.SelectedValue.ToString(), cmb_Style.SelectedValue.ToString(), 60, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START);			
			Add_fgrid_YieldValue_Default_Row();

			SetYield();
					
		}		

		#endregion

		#region  부분합 만들기,Size별 채산값 계산하기
		/// <summary>
		///  FindPositionTotal:SubTotal을 만들 위치 잡기
		/// </summary>
		/// <returns>arg_job_row     : 작업할 시작 위치 Row</returns> /// 
		/// <returns>arg_formula_col : Formula의 칼럼위치</returns>
		/// <returns>arg_mix_col     : Mix의 칼럼위치</returns>
		/// <returns>arg_start_size  : Size Run시작 위치</returns>
		/// <returns>arg_formula_flag  : formula/mix subtotal 재계산 유무</returns>
		/// <returns>arg_yield_flag     : yield value subtotal 재계산 유무</returns>
		private void  FindPositionTotal(int arg_job_row, int arg_formula_col, int arg_mix_col, int arg_start_size,
			bool arg_formula_flag, bool  arg_yield_flag)
		{


			for (int i =arg_job_row ; i < fgrid_Yield.Rows.Count ; i++)
			{
				if (fgrid_Yield[i, (int)ClassLib.TBSBC_FORMULAN_COPY.lxTYPE_DIVISION].ToString() == _Component)
				{
					int iLength = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxKEY].ToString().Length;					
					FindPositionCal(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxKEY].ToString().Substring(0,2),
						fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxKEY].ToString().Substring(8,5),
						fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxKEY].ToString().Substring(13,iLength-13));

					MakeTotalYieldValue(i, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA,
						(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMIX,
						(int)ClassLib.TBSBC_FORMULAN_YIELD.lxYIELD_M,  arg_formula_flag, arg_yield_flag," ");
				}

			}

		}

        
		/// <summary>
		///  MakeTotalYieldValue: Mix/Weight/Size별 Subtotal 만들기
		/// </summary>
		/// <returns>arg_subtotal_row: SubTotal Row 위치</returns>
		/// <returns>arg_formula_col : Formula의 칼럼위치</returns>
		/// <returns>arg_mix_col     : Mix의 칼럼위치</returns>
		/// <returns>arg_start_size  : Size Run시작 위치</returns>
		/// <returns>arg_start_size  : Size Run시작 위치</returns> 
		/// <returns>arg_formula_flag  : formula/mix subtotal 재계산 유무</returns>
		/// <returns>arg_yield_flag    : yield value subtotal 재계산 유무</returns>
		/// <returns>arg_job_flag     : 작업구분 설정</returns>
		private void MakeTotalYieldValue(int arg_subtotal_row, int arg_formula_col, int arg_mix_col, int arg_start_size,
			bool arg_formula_flag, bool  arg_yield_flag, string arg_job_flag )
		{

			#region 작업구분에 따른 Clear유무
			if  (arg_formula_flag ==true) 
			{
				fgrid_Yield[arg_subtotal_row,arg_formula_col] =0;
				fgrid_Yield[arg_subtotal_row,arg_mix_col] =0;
			}
			
			if  (arg_yield_flag ==true) 
			{
				for (int j = (int)ClassLib.TBSBC_FORMULAN_YIELD.lxYIELD_M ; j< fgrid_Yield.Cols.Count; j++)
				{ 
					fgrid_Yield[arg_subtotal_row,j] =0;
							
				}
			}
			#endregion


			for (int i =_MatStrRow; i <=_MatEndRow  ; i++)
			{

				if  (arg_formula_flag ==true) 
				{
					#region Formula 합
					fgrid_Yield[arg_subtotal_row,arg_formula_col] 
						=  ((fgrid_Yield[arg_subtotal_row,arg_formula_col]==null) || (fgrid_Yield[arg_subtotal_row,arg_formula_col].ToString()==""))?0: fgrid_Yield[arg_subtotal_row,arg_formula_col];

					fgrid_Yield[arg_subtotal_row,arg_formula_col] = Convert.ToString(Convert.ToDouble(fgrid_Yield[arg_subtotal_row,arg_formula_col].ToString()) +
						Convert.ToDouble(fgrid_Yield[i,arg_formula_col].ToString()));

					fgrid_Yield[arg_subtotal_row,arg_mix_col] = Convert.ToDouble(_TotalMix) ;

					#endregion

					#region Mix합 할당
					if (i == _MatEndRow)   
					{
						
						MakeCalMix(arg_subtotal_row,  arg_formula_col, arg_mix_col, _MatStrRow ,  _MatEndRow);

					}
					#endregion
				}
				
				if  (arg_yield_flag ==true) 
				{
					#region Size별 Yield Value합

					for (int j = (int)ClassLib.TBSBC_FORMULAN_YIELD.lxYIELD_M ; j< fgrid_Yield.Cols.Count; j++)
					{ 
						fgrid_Yield[arg_subtotal_row,j] = Math.Round((Convert.ToDouble(fgrid_Yield[arg_subtotal_row,j].ToString()) +
							Convert.ToDouble(fgrid_Yield[i,j].ToString())),_PointShort);
						
						
					}
					#endregion

				}

				fgrid_Yield[_MatStrRow-1,0]= arg_job_flag;
				fgrid_Yield[i,0]= arg_job_flag;
			}
		}


		/// <summary>
		///  MakeCalMix: Mix Rate계산하기
		/// </summary>
		/// <returns>arg_subtotal_row: SubTotal Row 위치</returns>
		/// <returns>arg_formula_col : Formula 의 칼럼위치</returns>/// 
		/// <returns>arg_mix_col     : Mix의 칼럼위치</returns>
		/// <returns>arg_srtmat_row  : 해당 Component의 첫번째 자재 Row</returns>
		/// <returns>arg_endmat_row  : 해당 Component의 마지막 자재 Row</returns>
		private void MakeCalMix( int arg_subtotal_row, int arg_formula_col  ,int arg_mix_col, int arg_srtmat_row, int arg_endmat_row)
		{
			double iSumMix  = 0;

			for (int i = arg_srtmat_row; i <=  arg_endmat_row ; i++)
			{
				if (i== arg_endmat_row)
				{
					fgrid_Yield[i,arg_mix_col]  = Convert.ToString(_TotalMix  - iSumMix) ;

				}
					
				fgrid_Yield[i,arg_mix_col] = Math.Round((Convert.ToDouble(fgrid_Yield[i, arg_formula_col].ToString()) /
					Convert.ToDouble(fgrid_Yield[arg_srtmat_row-1,arg_formula_col].ToString())*100),_PointShort);
				iSumMix  =  Math.Round(iSumMix  + Convert.ToDouble(fgrid_Yield[i,arg_mix_col]),_PointShort);
			
								
			}

		}
		

		/// <summary>
		///  FindPositionCal: Formula/ Mix/ Size Yield Value 재계산을 위한 위치 잡기
		/// </summary>
		private void FindPositionCal(string arg_semi_good,string arg_mcs, string arg_mcscolor)
		{
			string  sFlag = "N";
			_MatStrRow = _Rowfixed;    
			_MatEndRow = _Rowfixed;
			
			for  (int i = _Rowfixed  ;   i< fgrid_Yield.Rows.Count  ; i++)	
			{
				if ((fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD].ToString() ==arg_semi_good) &&
					(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_CD].ToString() ==arg_mcs) && 
					(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_COLOR].ToString()==arg_mcscolor))
				{
					if (sFlag =="N" )
					{
						_MatStrRow  =  i;
						_MatEndRow  =  i;
						sFlag  ="Y";

					}
					else
					{
						_MatEndRow  =  i;
					}
				}
			}


		}


		/// <summary>
		///  SetCalYIeldValue: Size별 Yield Value 계산하
		/// </summary>
		/// <returns>arg_srtmat_row  : 해당 Component의 첫번째 자재 Row</returns>
		/// <returns>arg_endmat_row  : 해당 Component의 마지막 자재 Row</returns>
		private void SetCalYIeldValue(int arg_matstr_row, int arg_matend_row)
		{
			
			if(fgrid_Yield[fgrid_Yield.Selection.r1, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxMIX] == null) return;

			int iCnt  =0;
			for (int i=_ColFixed ;  i<fgrid_YieldValue.Cols.Count ; i++)
			{ 
				iCnt++;
				int iColValue  =( (int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOL_ORDER   + iCnt );
				double iRemValue  =  Convert.ToDouble(fgrid_YieldValue[_Row_YieldValue , i].ToString())/1000;
				fgrid_Yield[arg_matend_row,iColValue ] =  iRemValue;

				for (int j = arg_matstr_row ;j<=arg_matend_row ; j++)
				{
					if (j !=  arg_matend_row) 
					{
						fgrid_Yield[j,iColValue ]  = Math.Round((Convert.ToDouble(fgrid_YieldValue[_Row_YieldValue , i])/1000 *
							Convert.ToDouble(fgrid_Yield[j,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMIX])/100),_PointLong );
					}
						
					double iMinus_Value  = (j==arg_matstr_row)?Convert.ToDouble(_BlankValue):Convert.ToDouble(fgrid_Yield[j-1,iColValue].ToString());	
						    
					fgrid_Yield[arg_matend_row,iColValue ] =Convert.ToDouble(fgrid_Yield[arg_matend_row,iColValue ].ToString()) - iMinus_Value;
			
				}
			}



			int iStart=_ColFixed , iEnd  =fgrid_YieldValue.Cols.Count ;

			//int r=  _Dt_Size_Range.Rows.Count ;
			
			for (int i  =0 ;  i< _Dt_Size_Range.Rows.Count  ;i++)
			{
				if(_CurrentColor.Equals(_SizeColor1) )
				{
					_CurrentColor = _SizeColor2;
				}
				else
				{
					_CurrentColor = _SizeColor1;
				}

				iStart= (i==0)?_ColFixed:Convert.ToInt16(_Dt_Size_Range.Rows[i-1].ItemArray[3])+_ColFixed+1;
				iEnd  = Convert.ToInt16(_Dt_Size_Range.Rows[i].ItemArray[3])+_ColFixed;
				fgrid_YieldValue.GetCellRange(_Row_YieldValue,iStart,  _Row_YieldValue, iEnd).StyleNew.BackColor = _CurrentColor;
				//MessageBox.Show("aaa");
			}
		}		
		


		/// <summary>
		/// View_Yield_History : History 조회
		/// </summary>
		private void View_Yield_History()
		{
			if(cmb_factory.SelectedIndex == -1 || cmb_Style.SelectedIndex == -1) return;
 
			//popup 창 파라미터 구성 
			string factory = cmb_factory.SelectedValue.ToString(); 
			string style_cd = cmb_Style.SelectedValue.ToString(); 
			string yield_type = cmb_Yield_Type.SelectedValue.ToString();
			   
			Pop_BC_Yield_History pop_form = new Pop_BC_Yield_History(factory, style_cd, yield_type);
			pop_form.MdiParent = ClassLib.ComVar.MDI_Parent;
			pop_form.Show();  
		}


		#endregion

		#region  Formula Register화면의 반환값 재 Setting
		
		/// <summary>
		/// SetYieldCopy : Formula Copy Pop
		/// </summary>
		private void SetFormulaCopy()
		{
			try
			{   
				if (CheckFormulaCopy()!= true)  return;

				COM.ComVar.Parameter_PopUp = new string[] 
						{
							cmb_factory.SelectedValue.ToString(),
							cmb_Year.SelectedValue.ToString(),
							cmb_Season.SelectedValue.ToString(),
							cmb_Style.SelectedValue.ToString()
						};
						 
				FlexBase.Yield.Pop_Formula_Copy  pop_Form = new Yield.Pop_Formula_Copy();
				pop_Form.ShowDialog();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetFormulaCopy", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}


		
		/// <summary>
		/// SetChangeMaterial : SetChangeMaterial
		/// </summary>
		private void SetChangeMaterial()
		{
							
			try
			{   
				if (cmb_Style.SelectedIndex   == -1 ) 
				{
					ClassLib.ComFunction.User_Message("Style Code Invalid", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;

				}

				COM.ComVar.Parameter_PopUp = new string[] 
									 {
										 cmb_factory.SelectedValue.ToString(),
										 cmb_Year.SelectedValue.ToString(),
										 cmb_Season.SelectedValue.ToString(),
										 txt_Style.Text
										 //							vMcsCode,
										 //							vMcsColor
									 };
						 
				FlexBase.Yield.Pop_FormulaMuti_Change  pop_Form = new Yield.Pop_FormulaMuti_Change();
				pop_Form.ShowDialog();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetChangeMaterial", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
						
		}



		/// <summary>
		/// SetYieldCopy : Formula Copy Pop
		/// </summary>
		private void SetVBaseFormula()
		{
			try
			{  

				COM.ComVar.Parameter_PopUp = new string[] 
						{
							cmb_factory.SelectedValue.ToString(),
							cmb_Year.SelectedValue.ToString(),
							cmb_Season.SelectedValue.ToString()
						};
						 
				FlexBase.Yield.Pop_Formula_Base_Register  pop_Form = new Yield.Pop_Formula_Base_Register();
				pop_Form.ShowDialog();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetVBaseFormula", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}


		/// <summary>
		/// SetPrintYield: SetPrintYield
		/// </summary>
		private void  SetPrintYield()
		{
			try
			{   
				//if (CheckFormulaCopy()!= true)  return;

				if (cmb_Style.SelectedIndex  ==- -1) return;

				COM.ComVar.Parameter_PopUp = new string[] 
						{
							cmb_factory.SelectedValue.ToString(),
							cmb_Style.SelectedValue.ToString().Replace("-",""),
							cmb_Style.Columns[1].Text,
							cmb_Presto.SelectedValue.ToString(),
							txt_Gen.Text
						};
						 
				FlexBase.Yield.Pop_Yield_Print  pop_Form = new Yield.Pop_Yield_Print();
				pop_Form.ShowDialog();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetPrintYield", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}


		#endregion

		#region Formula Register Popup관련 
		/// <summary>
		/// SetFormulaRegister: Formula Register Pop
		/// </summary>
		private void  SetFormulaRegister()
		{
			try
			{   
				if (CheckFormulaCopy()!= true)  return;

				string sSemi, sMcs, sMcsColor, sMcsName, sMcsColorName, sSeq ,sFormula ;
				int    iSemi, iR1,iMcs, iMcsColor, iMcsName, iMcsColorName, iSeq,iFormula ;

				#region Formula Pop
				iR1            = fgrid_Yield.Selection.r1;
				iSemi		   = (int)ClassLib.TBSBC_FORMULAN_YIELD.lxKEY;
				iMcs           = (int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_CD;
				iMcsColor      = (int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_COLOR;
				iMcsName       = (int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_NAME;
				iMcsColorName  = (int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_COLOR_NAME ;
				iSeq		   = (int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA_SEQ ;
				iFormula 	   = (int)ClassLib.TBSBC_FORMULAN_YIELD.lxTEMPLATE_LEVEL ;

				COM.ComVar.Parameter_PopUp = new string[] 
						{
							cmb_factory.SelectedValue.ToString(),
							cmb_Year.SelectedValue.ToString(),
							cmb_Season.SelectedValue.ToString(),
							cmb_Style.Columns[0].Text,
							cmb_Style.Columns[1].Text,
							sSemi        = (fgrid_Yield[iR1,iSemi]      ==  null)? "":fgrid_Yield[iR1,iSemi].ToString().Substring(0,2),       //Semi
							sMcs        = (fgrid_Yield[iR1,iMcs]        ==  null)? "":fgrid_Yield[iR1,iMcs].ToString(),          //mcs cd
							sMcsColor   = (fgrid_Yield[iR1,iMcsColor]   ==  null)?  "":fgrid_Yield[iR1,iMcsColor].ToString(),      //color cd
							sMcsName    = (fgrid_Yield[iR1,iMcsName]    ==  null)?  "":fgrid_Yield[iR1,iMcsName].ToString(),     //mcs name
							sMcsColorName = (fgrid_Yield[iR1,iMcsColorName] ==  null)?  "":fgrid_Yield[iR1,iMcsColorName].ToString(),  //mcs color name\
							sSeq	      = (fgrid_Yield[iR1,iSeq]      ==  null)?  "":fgrid_Yield[iR1,iSeq].ToString(),                     //Seq
							sFormula      = (fgrid_Yield[iR1,iFormula]  ==  null)?  "":fgrid_Yield[iR1,iFormula].ToString(),             //Formula Div
							cmb_Yield_Type.SelectedValue.ToString()
						};

				FlexBase.Yield.Pop_Formula_Register  pop_Form = new Yield.Pop_Formula_Register();
					 
				pop_Form.ShowDialog();

				#endregion

				#region 전달값 변수 재설정
				if(pop_Form._Dt_Formula  == null) return;
				if(pop_Form._Dt_Formula_Weight  == null) return;


				DataTable  dt_formula = pop_Form._Dt_Formula;
				DataTable  dt_formula_weight = pop_Form._Dt_Formula_Weight;
		

				pop_Form._Dt_Formula.Dispose();
				pop_Form._Dt_Formula_Weight.Dispose();
				
				ApplyBottom(dt_formula, dt_formula_weight);				
				#endregion
			

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetFormulaRegister", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}
		


		/// <summary>
		///  ApplyBottom: Formula 및 Weigt 뿌리기
		/// </summary>
		/// <returns>arg_dt_formula : Formula 정보 보관 DataTable</returns>
		/// <returns>arg_dt_formulaWeight : Formula Weight 정보 보관 DataTable</returns>
		private void ApplyBottom(DataTable arg_dt_formula,  DataTable  arg_dt_formulaWeight)
		{

			try
			{	
				if (arg_dt_formula.Rows.Count == 0 ) 
				{
					//ClassLib.ComFunction.User_Message("No Formula Data", "Material Count", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				//				if (arg_dt_formula.Rows.Count-_Rowfixed == 0 ) 
				//				{
				//					ClassLib.ComFunction.User_Message("No Formula Data", "Material Count", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//					return;
				//				}


				//Formula +Color가 중복될시 그리드상에 지우고 다시 Setting
				#region  Formula +Color
				//				int vMcsCode = 11;
				//				int vMcsColor =13; 
				//				FindPositionCal(arg_dt_formula.Rows[0][vMcsCode].ToString(), arg_dt_formula.Rows[0][vMcsColor].ToString());
				//				
				//				for(int i = _MatEndRow ; i >=_MatStrRow; i--)
				//				{
				//				  if (_MatEndRow == _Rowfixed) break;
				//
				//				  fgrid_Yield.Delete_Row(i);
				//
				//				}

				#endregion
			

				ApplyFormula(arg_dt_formula);
				ApplyFormula_Weight(arg_dt_formulaWeight);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "ApplyBottom", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	

	
		}

		/// <summary>
		///  ApplyFormula : Weigt 뿌리기
		/// </summary>
		/// <returns>arg_dt_formula : Formula 정보 보관 DataTable</returns>
		private void ApplyFormula(DataTable arg_dt_formula )
		{

			try
			{
			
				int iInputRow   =0 ;// iSelection =0;

				if (arg_dt_formula.Rows.Count == 0 ) return;
				
				int iR1  = fgrid_Yield.Selection.r1 ;
				FindPositionCal(fgrid_Yield[iR1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD].ToString(),
					fgrid_Yield[iR1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_CD].ToString(),
					fgrid_Yield[iR1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_COLOR].ToString());

				
				#region  추가할 위치 로우 잡기
				iInputRow  = fgrid_Yield.Selection.r1;
 
				if (_MatStrRow != _Rowfixed) 
				{
					for (int i =_MatEndRow; i >= _MatStrRow-1 ; i--)
						fgrid_Yield.Rows.Remove(i);
					iInputRow  =  _MatStrRow-1;
					

				}
				
				if (fgrid_Yield[fgrid_Yield.Selection.r1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() == _SemiGood) 
				{
				
					iInputRow  = fgrid_Yield.Selection.r1+1;
					

				}
				#endregion

				


				int  iSelection = 0; 
				for ( int i =0  ;  i <= arg_dt_formula.Rows.Count -1   ;i++)
				{
					int vLevel = Convert.ToInt32( arg_dt_formula.Rows[i].ItemArray[(int)ClassLib.TBSBC_FORMULAN_YIELD.lxLEVEL-1].ToString());
					fgrid_Yield.Rows.InsertNode(i + iInputRow , vLevel);           //node추가 

					for (int  j=0 ;j<arg_dt_formula.Columns.Count ;j++)            //자료 뿌리기
					{  					
						if (arg_dt_formula.Rows[i].ItemArray[j] == null)  break;
						if (j >  (int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE)  fgrid_Yield[iInputRow,j] ="";

						fgrid_Yield[i+ iInputRow,j+1] =  ClassLib.ComFunction.Empty_String(arg_dt_formula.Rows[i].ItemArray[j].ToString(),"");
					  
					}

					fgrid_Yield[i+ iInputRow,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPST_YN]    =  ClassLib.ComVar.DivPst;
					fgrid_Yield[i+ iInputRow,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxGENDER]    =  ClassLib.ComVar.DivGen;   
					fgrid_Yield[i+ iInputRow,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxYIELD_M]   =  _init;   
					fgrid_Yield[i+ iInputRow,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOL_ORDER] =  _init; 
					
					
					iSelection = i+ iInputRow;


					fgrid_Yield[i+ iInputRow,0] = "I";

				}


				#region 이미지 
				_Imgmap.Clear();
				for ( int i =0  ;  i <  fgrid_Yield.Rows.Count    ;i++)
				{
					Display_Type_Image(i);
				}			
				fgrid_Yield.Cols[(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ImageAndText = true; 
				fgrid_Yield.Cols[(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ImageMap     = _Imgmap;  			

				#endregion

				fgrid_Yield.Select(iSelection, 0, iSelection, fgrid_Yield.Cols.Count-1,true);


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "ApplyFormula", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	

		}



		/// <summary>
		///  ApplyFormula_Weight : Weigt 뿌리기
		/// </summary>
		/// <returns>formulaWeight : Formula  Weight 정보 보관 DataTable</returns>
		private void ApplyFormula_Weight( DataTable  arg_dt_formulaWeight)
		{

			try
			{
				if (arg_dt_formulaWeight.Rows.Count == 0 ) return;

				for (int i =0  ; i < arg_dt_formulaWeight.Rows.Count ; i++)
				{
					for (int  j =0  ;  j < arg_dt_formulaWeight.Columns.Count    ;j++)
					{
						fgrid_YieldValue[i +_Rowfixed , j+_ColFixed]  =  arg_dt_formulaWeight.Rows[i].ItemArray[j].ToString();

					}
				}

				#region Fomula/Mix 재계산	
		
				int iR1  = fgrid_Yield.Selection.r1 ;
				FindPositionCal(fgrid_Yield[iR1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD].ToString(),
					fgrid_Yield[iR1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_CD].ToString(),
					fgrid_Yield[iR1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_COLOR].ToString());

				MakeTotalYieldValue(_MatStrRow -1 , 
					(int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA,
					(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMIX,
					(int)ClassLib.TBSBC_FORMULAN_YIELD.lxYIELD_M,  true, false, "I");


				#endregion

				#region 채산값 재계산
				//채산값 재계산을 위한 위치 잡기 전역변수에 선언
				FindPositionCal(fgrid_Yield[iR1, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD].ToString(),
					fgrid_Yield[iR1, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_CD].ToString(),
					fgrid_Yield[iR1, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_COLOR].ToString());
				

							

				//채산값 재계산. 2006.09.07
				SetValueColor();


				
				//채산값 재계산 (Mix에 따라서 )
				SetCalYIeldValue(_MatStrRow, _MatEndRow);


				//채산값 SubTotal구하기.
				MakeTotalYieldValue(_MatStrRow-1, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA,
					(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMIX,
					(int)ClassLib.TBSBC_FORMULAN_YIELD.lxYIELD_M,  false , true,"I");

				#endregion

	

				SetYieldColor();





			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "ApplyFormula_Weight", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		/// <summary>
		///  DisPlayFormulaWeight: FormulaWeigt 뿌리기
		/// </summary>
		/// <returns></returns>
		private void DisPlayFormulaWeight(DataTable arg_dt)
		{
			//fgrid_YieldValue.Cols.Count  =_ColFixed;

			for (int  i=0 ;i<arg_dt.Rows.Count ;i++)
			{  					

				fgrid_YieldValue[_Row_EYield,_ColFixed+i]     =  ClassLib.ComFunction.Empty_String(arg_dt.Rows[i].ItemArray[1].ToString(),"");
				fgrid_YieldValue[_Row_MYield,_ColFixed+i]     =  ClassLib.ComFunction.Empty_String(arg_dt.Rows[i].ItemArray[2].ToString(),"");
				fgrid_YieldValue[_Row_SpecCd,_ColFixed+i]     =  _Blank;
				fgrid_YieldValue[_Row_SpecName,_ColFixed+i]   =  _Blank;
			}

			SetValueColor();

		}


		/// <summary>
		/// SetValueColor:ValueColor 뿌리기
		/// </summary>
		/// <returns></returns>
		private void SetValueColor()
		{
			MakeSizeRange();

			Color _CurrentColor = ClassLib.ComVar.ClrSel_Green;
	
			//
			int iStart=_ColFixed , iEnd  =fgrid_YieldValue.Cols.Count ;
			for (int i  =0 ;  i< _Dt_Size_Range.Rows.Count  ;i++)
			{
				if(_CurrentColor.Equals(_SizeColor1) )
				{
					_CurrentColor = _SizeColor2;
				}
				else
				{
					_CurrentColor = _SizeColor1;
				}

				iStart= (i==0)?_ColFixed:Convert.ToInt16(_Dt_Size_Range.Rows[i-1].ItemArray[3])+_ColFixed+1;
				iEnd  = Convert.ToInt16(_Dt_Size_Range.Rows[i].ItemArray[3])+_ColFixed;
				fgrid_YieldValue.GetCellRange(_Row_YieldValue,iStart,  _Row_YieldValue, iEnd).StyleNew.BackColor = _CurrentColor;
				//MessageBox.Show("aaa");
								
			} 
		}


		/// <summary>
		/// Display_Type_Image : 이미지 표시
		/// </summary>
		/// <param name="arg_row"></param>
		private void Display_Type_Image(int arg_row) 
		{

			if(_Imgmap.ContainsKey(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ToString() ) ) return;

			switch(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() )
					//switch(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ToString() )
			{ 		
				case _TypeSG:  
					fgrid_Yield.GetCellRange(arg_row, 1, arg_row, fgrid_Yield.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
					_Imgmap.Add(fgrid_Yield[arg_row,  (int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ToString(), img_Type.Images[_IxImage_SG]); 
					break;

				case _TypeCmp:  
					fgrid_Yield.GetCellRange(arg_row, 1, arg_row, fgrid_Yield.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrYield_SizeY;
					_Imgmap.Add(fgrid_Yield[arg_row,  (int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ToString(), img_Type.Images[_IxImage_Cmp]); 
					break;

				case _TypeMat:
					_Imgmap.Add(fgrid_Yield[arg_row,  (int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ToString(), img_Type.Images[_IxImage_Mat]);
					break;
				
				case _TypeJoint:
					_Imgmap.Add(fgrid_Yield[arg_row,  (int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ToString(), img_Type.Images[_IxImage_Joint]);
					break;
 
			} // end switch
		}

		

		#endregion

		#region 사전 Check

		/// <summary>
		/// CheckFormulaCopy : Formula Popup사전 Check
		/// </summary>
		private bool CheckFormulaCopy() 
		{

			try
			{

				if (cmb_factory.SelectedValue.ToString().Length == 0) 
				{
					ClassLib.ComFunction.User_Message("Factory Shoulb be selected..");
					return false; 
				}
				

				if (cmb_Year.SelectedValue.ToString().Length == 0) 
				{
					ClassLib.ComFunction.User_Message("Year Shoulb be selected..");
					return false; 				
				}


				if (cmb_Season.SelectedValue.ToString().Length == 0) 
				{
					ClassLib.ComFunction.User_Message("Season Shoulb be selected..");
					return false; 
				}


				if (cmb_Style.SelectedValue.ToString().Length == 0) 
				{
					ClassLib.ComFunction.User_Message("Style Shoulb be selected..");
					return false; 
				}
				
				return true;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "CheckFormulaCopy", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false; 
			}	
		}


		/// <summary>
		/// CheckDuplicateFormula : Formual Duplication  Check
		/// </summary>
		//		private bool CheckDuplicateFormula(DataTable arg_dt_table) 
		//		{
		//
		//			try
		//			{
		//    
		//				for (int i = _Rowfixed  ; i< fgrid_Yield.Rows.Count ;i++)
		//				{
		//					if ( (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxLEVEL].ToString() ==  _FormulaLevel) &&
		//						 (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ToString() 
		//						   == arg_dt_table.Rows[0].ItemArray[(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE-1].ToString()))
		//					{
		//						ClassLib.ComFunction.User_Message("Duplication Formula..");
		//						return false; 
		//					}					
		//
		//				}
		//
		//				return true;
		//
		//			}
		//			catch(Exception ex)
		//			{
		//				ClassLib.ComFunction.User_Message(ex.Message, "CheckDuplicateFormula", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//				return false; 
		//			}	
		//		}

		/// <summary>
		/// CheckSetYield : SetYield 사전 Check
		/// </summary>
		private bool CheckSetYield()
		{

			try
			{
				if (cmb_factory.SelectedValue.ToString().Length == 0) 
				{
					ClassLib.ComFunction.User_Message("Factory Shoulb be selected..");
					return false; 
				}
				

				if (cmb_Year.SelectedValue.ToString().Length == 0) 
				{
					ClassLib.ComFunction.User_Message("Year Shoulb be selected..");
					return false; 				
				}


				if (cmb_Season.SelectedValue.ToString().Length == 0) 
				{
					ClassLib.ComFunction.User_Message("Season Shoulb be selected..");
					return false; 
				}


				if (cmb_Style.SelectedValue.ToString().Length == 0) 
				{
					ClassLib.ComFunction.User_Message("Style Shoulb be selected..");
					return false; 
				}
				
				return true;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "CheckSetYield", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false; 
			}	

		}


		#endregion

		#region 저장 모듈

		//		private bool SaveYield()
		//		{
		//
		//
		//			MakeSizeRange();
		//
		//			bool make_flag = false;
		//
		//
		//			make_flag = SaveFormula(true); 
		//
		//			if(!make_flag)
		//			{
		//				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
		//				return false;
		//			}
		//			else
		//			{
		//				make_flag = SaveFormulaWeight(false);
		//
		//				if(!make_flag)
		//				{
		//					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
		//					return false;
		//				}
		//				else
		//				{
		//					make_flag = SaveChangeProcess(false); 
		//					//make_flag = true;
		//
		//					if(!make_flag)
		//					{
		//						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
		//						return false;
		//					}
		//					else
		//					{
		//
		//						make_flag = SaveYieldValue(false);
		//
		//						if(!make_flag)
		//						{
		//							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
		//							return false;
		//						}
		//						else
		//						{
		//							DataSet ds_ret;
		//
		//							ds_ret = _MyOraDB.Exe_Modify_Procedure();
		//
		//							if(ds_ret == null)  // error
		//							{
		//								ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
		//								return false;
		//							}
		//							else
		//							{
		//								//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
		//								ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
		//								return true;
		//							}// SaveYieldValue
		//						}//SaveYieldValue
		//					}//SaveChangeProcess
		//				}//SaveFormulaWeight
		//			}//SaveFormula
		//		}




		/// <summary>
		/// SaveClear : 채산 쓰레기 값 지우기 
		/// </summary>
		public void  SaveClear()
		{
			DataSet ds_ret;
									
			int  vCol =5;

			_MyOraDB.ReDim_Parameter(vCol); 

			_MyOraDB.Process_Name=  "PKG_SBC_FORMULA.SAVE_CLEAR_YIELD";
		
			int i=0;
			_MyOraDB.Parameter_Name[i++] = "ARG_FLAG";
			_MyOraDB.Parameter_Name[i++] = "ARG_FACTORY";
			_MyOraDB.Parameter_Name[i++] = "ARG_STYLE_CD";
			_MyOraDB.Parameter_Name[i++] = "ARG_SEMI_GOOD_CD";
			_MyOraDB.Parameter_Name[i++] = "ARG_COMPONENT_CD";
			

			for (int k=0 ; k< vCol; k++)
				_MyOraDB.Parameter_Type[k] = 1; 						



			_MyOraDB.Parameter_Values = new string[vCol ];

			int vCnt=0;
			int iR1  = fgrid_Yield.Selection.r1;

			_MyOraDB.Parameter_Values[vCnt++] =  " ";
			_MyOraDB.Parameter_Values[vCnt++] =  cmb_factory.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[vCnt++] =  cmb_Style.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[vCnt++] =  fgrid_Yield[iR1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxKEY].ToString().Substring(0,2);
			_MyOraDB.Parameter_Values[vCnt++] =  fgrid_Yield[iR1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxKEY].ToString().Substring(2,16);


			_MyOraDB.Add_Modify_Parameter(true);
			ds_ret  =  _MyOraDB.Exe_Modify_Procedure();	 



		}

	

		private bool SaveYield()
		{


			MakeSizeRange();

			bool make_flag = false;


			make_flag = SaveFormula(true);   

			if(!make_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				return false;
			}
			else
			{
				make_flag = SaveFormulaWeight(false);

				if(!make_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return false;
				}
				else
				{
					make_flag = SaveChangeProcess(false); 
					//make_flag = true;

					if(!make_flag)
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						return false;
					}
					else
					{

						make_flag = SaveYieldValue(false);

						if(!make_flag)
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
							return false;
						}
						else
						{
							DataSet ds_ret;

							ds_ret = _MyOraDB.Exe_Modify_Procedure();

							if(ds_ret == null)  // error
							{
								ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
								return false;
							}
							else
							{
								//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
								ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
								return true;
							}// SaveYieldValue
						}//SaveYieldValue
					}//SaveChangeProcess
				}//SaveFormulaWeight
			}//SaveFormula
		}

		private void MakeSizeRange()
		{
			int iCnt  = 3, iPos = 0;  string sOldValue ="";

			_Dt_Size_Range = new DataTable("Size");  
			//DataRow datarow;

			_Dt_Size_Range.Clear();

			for(int i = 0; i <= iCnt; i++)
				_Dt_Size_Range.Columns.Add(new DataColumn(i.ToString(), typeof(string)));

			DataRow datarow = null;

			for (int i=_ColFixed; i< fgrid_YieldValue.Cols.Count; i++)
			{ 
                if (fgrid_YieldValue[_Row_YieldValue, i] == null) return;

				if  (fgrid_YieldValue[_Row_YieldValue, i].ToString() != sOldValue)   //이전값이랑 다르면 신규 Row추가..
				{    
					datarow = _Dt_Size_Range.NewRow();

					datarow[0] = fgrid_YieldValue[_Rowfixed-1,i].ToString();        //From Size
					datarow[1] = fgrid_YieldValue[_Rowfixed-1,i].ToString();        //To Size
					datarow[2] = fgrid_YieldValue[_Row_YieldValue,i].ToString();    //Value
					datarow[3] = iPos;    //ColOrder

					sOldValue = fgrid_YieldValue[_Row_YieldValue,i].ToString();			 

					_Dt_Size_Range.Rows.Add(datarow);
				}	
				else
				{
					datarow[1] = fgrid_YieldValue[_Rowfixed-1,i].ToString();        //To Size
					datarow[3] = iPos;        //ColOrder
				}

				iPos++ ;	

			}

		}

		#endregion 

		#endregion

		#region DB 컨넥트

		
	
		public static DataSet Save_Check_Formula_InOut(string arg_division, 
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
					LMyOraDB.Process_Name = "PKG_SBC_FORMULA_CHECKIN_SEQ.SAVE_SBC_YIELD_CHECKIN";  
				}
				else if(arg_division == "O")
				{
					LMyOraDB.Process_Name = "PKG_SBC_FORMULA_CHECKIN_SEQ.SAVE_SBC_YIELD_CHECKOUT";  
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
			  
				LMyOraDB.Parameter_Values[0] = arg_division;
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
		/// SelectYield: Formula & Yield 조회
		/// </summary>
		/// <returns></returns>
		public DataTable SelectYield()
		{

			COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret; int iCnt;
			
			iCnt  =  5;
			MyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_FORMULA.SELECT_SBC_FORMULA_YIELD";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_FORMULA_YEAR";
			MyOraDB.Parameter_Name[2] = "ARG_SEASON_CD";
			MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_Year.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = cmb_Season.SelectedValue.ToString();
			MyOraDB.Parameter_Values[3] = cmb_Style.SelectedValue.ToString();
			MyOraDB.Parameter_Values[4] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}


		/// <summary>
		/// SelectFormulaWeight: FormulaWeigt 조회
		/// </summary>
		/// <returns></returns>
		public DataTable SelectFormulaWeight(int arg_row)
		{

			DataSet ds_ret; int iCnt;
		
			iCnt  =  7;
			_MyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			_MyOraDB.Process_Name = "PKG_SBC_FORMULA.SELECT_SBC_FORMULA_WEIGHT";

			//02.ARGURMENT명
			_MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			_MyOraDB.Parameter_Name[1] = "ARG_FORMULA_YEAR";
			_MyOraDB.Parameter_Name[2] = "ARG_SEASON_CD";
			_MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
			_MyOraDB.Parameter_Name[4] = "ARG_MCS_CD";
			_MyOraDB.Parameter_Name[5] = "ARG_MCS_COLOR_CD";
			_MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

			//03.DATA TYPE
			_MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;
			
			//04.DATA 정의  
			_MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[1] = cmb_Year.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[2] = cmb_Season.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[3] = cmb_Style.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[4] = fgrid_Yield[arg_row ,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_CD].ToString();
			_MyOraDB.Parameter_Values[5] = fgrid_Yield[arg_row ,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_COLOR].ToString();
			_MyOraDB.Parameter_Values[6] = ""; 

			_MyOraDB.Add_Select_Parameter(true);

			ds_ret = _MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
		
			return ds_ret.Tables[_MyOraDB.Process_Name]; 
		}


		/// <summary>
		/// SaveFormula: Formula저장
		/// </summary>
		/// <returns></returns>
		private bool SaveFormula(bool arg_clear)
		{   
			try
			{
				//DataSet ds_ret;
									    
				int  iCol =20;

				_MyOraDB.ReDim_Parameter(iCol); 

				_MyOraDB.Process_Name=  "PKG_SBC_FORMULA.SAVE_SBC_FORMULA";
			
				int i=0;
				_MyOraDB.Parameter_Name[i++] = "ARG_FLAG";  
				_MyOraDB.Parameter_Name[i++] = "ARG_DIVISION";  
				_MyOraDB.Parameter_Name[i++] = "ARG_FACTORY";     
				_MyOraDB.Parameter_Name[i++] = "ARG_SEQ";             
				_MyOraDB.Parameter_Name[i++] = "ARG_FORMULA_DIV";
  
				_MyOraDB.Parameter_Name[i++] = "ARG_ITEM_CD";     
				_MyOraDB.Parameter_Name[i++] = "ARG_COLOR_CD";     
				_MyOraDB.Parameter_Name[i++] = "ARG_SPEC_CD";      
				_MyOraDB.Parameter_Name[i++] = "ARG_FORMULA_YEAR"; 
				_MyOraDB.Parameter_Name[i++] = "ARG_SEASON_CD";    

				_MyOraDB.Parameter_Name[i++] = "ARG_STYLE_CD";     
				_MyOraDB.Parameter_Name[i++] = "ARG_MCS_CD";       
				_MyOraDB.Parameter_Name[i++] = "ARG_MCS_COLOR_CD"; 
				_MyOraDB.Parameter_Name[i++] = "ARG_FORMULA";      
				_MyOraDB.Parameter_Name[i++] = "ARG_MIX";          

				_MyOraDB.Parameter_Name[i++] = "ARG_REMARKS";      
				_MyOraDB.Parameter_Name[i++] = "ARG_SEND_CHK";     
				_MyOraDB.Parameter_Name[i++] = "ARG_SEND_YMD";     
				_MyOraDB.Parameter_Name[i++] = "ARG_UPD_USER";     
				_MyOraDB.Parameter_Name[i++] = "ARG_UPD_YMD"; 

				for (i = 0 ; i< iCol; i++)
					_MyOraDB.Parameter_Type[i] = 1; 						

				#region Value 
				int  iRow   = 0;
				for(i =  _Rowfixed; i < fgrid_Yield.Rows.Count; i++)
				{
					if ((fgrid_Yield[i,0] == null) || fgrid_Yield[i,0].ToString() == "" || fgrid_Yield[i,0].ToString() == " ")  continue;	
					if(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() == _Material)
					iRow ++;
				}

				_MyOraDB.Parameter_Values = new string[iCol * iRow];


				int iCnt=0;
				for(i =  _Rowfixed; i < fgrid_Yield.Rows.Count; i++)         //Component>자재별 생성
				{
					if ((fgrid_Yield[i,0] == null) || fgrid_Yield[i,0].ToString() == "" || fgrid_Yield[i,0].ToString() == " ")  continue;	
					if(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() != _Material) continue;

					_MyOraDB.Parameter_Values[iCnt++] =  fgrid_Yield[i,0].ToString();
					if(fgrid_Yield[i-1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION ].ToString() == _Component ) 
						_MyOraDB.Parameter_Values[iCnt++] =  _Head;
					else
						_MyOraDB.Parameter_Values[iCnt++] =  _Tail;

					_MyOraDB.Parameter_Values[iCnt++] =  cmb_factory.SelectedValue.ToString();
					_MyOraDB.Parameter_Values[iCnt++] =  ClassLib.ComFunction.Empty_String(fgrid_Yield[iRow,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA_SEQ].ToString()," ");
					_MyOraDB.Parameter_Values[iCnt++] =  fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTEMPLATE_LEVEL].ToString();

					_MyOraDB.Parameter_Values[iCnt++] =  fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxITEM_CD].ToString();
					_MyOraDB.Parameter_Values[iCnt++] =  fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOLOR_CD].ToString();
					_MyOraDB.Parameter_Values[iCnt++] =  fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSPEC_CD ].ToString();
					_MyOraDB.Parameter_Values[iCnt++] =  cmb_Year.SelectedValue.ToString ();
					_MyOraDB.Parameter_Values[iCnt++] =  cmb_Season.SelectedValue.ToString();

					_MyOraDB.Parameter_Values[iCnt++] =  cmb_Style.SelectedValue.ToString();
					_MyOraDB.Parameter_Values[iCnt++] =  fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_CD].ToString();
					_MyOraDB.Parameter_Values[iCnt++] =  fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_COLOR].ToString();
					_MyOraDB.Parameter_Values[iCnt++] =  fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA].ToString();
					_MyOraDB.Parameter_Values[iCnt++] =  fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMIX].ToString();

					_MyOraDB.Parameter_Values[iCnt++] =  _Blank;
					_MyOraDB.Parameter_Values[iCnt++] = _SendCheck;
					_MyOraDB.Parameter_Values[iCnt++] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
					_MyOraDB.Parameter_Values[iCnt++] = ClassLib.ComVar.This_User;	
					_MyOraDB.Parameter_Values[iCnt++] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
				
				}
			
				#endregion

				_MyOraDB.Add_Modify_Parameter(arg_clear); 			
				return true;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SaveFormula", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}		
		}
		



		/// <summary>
		/// SaveFormulaWeight: SaveFormulaWeight저장
		/// </summary>
		/// <returns></returns>
		private bool SaveFormulaWeight(bool arg_clear)
		{  
			try
            {
				//DataSet ds_ret;
										    
				int  iCol =19;

				_MyOraDB.ReDim_Parameter(iCol); 

				_MyOraDB.Process_Name=  "PKG_SBC_FORMULA.SAVE_SBC_FORMULA_WEIGHT";
				
				int i=0;
				_MyOraDB.Parameter_Name[i++] = "ARG_FLAG";        
				
				_MyOraDB.Parameter_Name[i++] = "ARG_DIVISION";    
				_MyOraDB.Parameter_Name[i++] = "ARG_FACTORY";     
				_MyOraDB.Parameter_Name[i++] = "ARG_SEQ"; 		      
				_MyOraDB.Parameter_Name[i++] = "ARG_CS_SIZE_FROM";

				_MyOraDB.Parameter_Name[i++] = "ARG_CS_SIZE_TO";  
				_MyOraDB.Parameter_Name[i++] = "ARG_FORMULA_YEAR";
				_MyOraDB.Parameter_Name[i++] = "ARG_SEASON_CD";   
				_MyOraDB.Parameter_Name[i++] = "ARG_STYLE_CD";    
				_MyOraDB.Parameter_Name[i++] = "ARG_MCS_CD"; 	    

				_MyOraDB.Parameter_Name[i++] = "ARG_MCS_COLOR_CD";
				_MyOraDB.Parameter_Name[i++] = "ARG_COMPONENT_CD";
				_MyOraDB.Parameter_Name[i++] = "ARG_E_WEIGHT";    
				_MyOraDB.Parameter_Name[i++] = "ARG_M_WEIGHT"; 	  
				_MyOraDB.Parameter_Name[i++] = "ARG_GENDER";      

				_MyOraDB.Parameter_Name[i++] = "ARG_PRESTO_YN";   
				_MyOraDB.Parameter_Name[i++] = "ARG_SEND_CHK";    
				_MyOraDB.Parameter_Name[i++] = "ARG_SEND_YMD"; 	  
				_MyOraDB.Parameter_Name[i++] = "ARG_UPD_USER";    
				//_MyOraDB.Parameter_Name[i++] = "ARG_UPD_YMD ";  

				for (i = 0 ; i< iCol; i++)
					_MyOraDB.Parameter_Type[i] = 1; 						

		
				#region Value 

				int  iRow   = 0;
				for(i =  _Rowfixed; i < fgrid_Yield.Rows.Count; i++)
				{
					if ((fgrid_Yield[i,0] == null) || fgrid_Yield[i,0].ToString() == "" || fgrid_Yield[i,0].ToString() == " ")  continue;	
					if(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() == _Component)
						iRow ++;
				}
				

				_MyOraDB.Parameter_Values = new string[iCol * iRow*_Dt_Size_Range.Rows.Count];
				int iCnt=0;


				for(i =  _Rowfixed ; i < fgrid_Yield.Rows.Count; i++)   //Component>Size Value별 생성
				{
					if ((fgrid_Yield[i,0] == null) || fgrid_Yield[i,0].ToString() == "" || fgrid_Yield[i,0].ToString() == " ")  continue;	
					if(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() != _Component) continue;

					iRow  = i+1;
					for (int j=0 ; j<_Dt_Size_Range.Rows.Count; j++)   
					{	
						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,0].ToString();

						_MyOraDB.Parameter_Values[iCnt++] = (j==0)?_Head:_Tail; 
						_MyOraDB.Parameter_Values[iCnt++] = cmb_factory.SelectedValue.ToString();
						_MyOraDB.Parameter_Values[iCnt++] =  ClassLib.ComFunction.Empty_String(fgrid_Yield[iRow,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA_SEQ].ToString()," ");
						_MyOraDB.Parameter_Values[iCnt++] = _Dt_Size_Range.Rows[j].ItemArray[0].ToString();
		
						_MyOraDB.Parameter_Values[iCnt++] = _Dt_Size_Range.Rows[j].ItemArray[1].ToString();
						_MyOraDB.Parameter_Values[iCnt++] = cmb_Year.SelectedValue.ToString ();
						_MyOraDB.Parameter_Values[iCnt++] = cmb_Season.SelectedValue.ToString();
						_MyOraDB.Parameter_Values[iCnt++] = cmb_Style.SelectedValue.ToString();
						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[iRow,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_CD].ToString();

						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[iRow,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_COLOR].ToString();
						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[iRow,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOMPONENT_CD].ToString();		
						_MyOraDB.Parameter_Values[iCnt++] = fgrid_YieldValue[_Row_EYield,_ColFixed + Convert.ToInt16(_Dt_Size_Range.Rows[j].ItemArray[3])].ToString();
						_MyOraDB.Parameter_Values[iCnt++] = fgrid_YieldValue[_Row_MYield,_ColFixed + Convert.ToInt16(_Dt_Size_Range.Rows[j].ItemArray[3])].ToString();
						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[iRow,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxGENDER].ToString();

						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[iRow,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPST_YN].ToString();
						_MyOraDB.Parameter_Values[iCnt++] = _SendCheck;
						_MyOraDB.Parameter_Values[iCnt++] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
						_MyOraDB.Parameter_Values[iCnt++] = ClassLib.ComVar.This_User;	
						//_MyOraDB.Parameter_Values[iCnt++] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
						

					}
					
				}
				

				#endregion

				_MyOraDB.Add_Modify_Parameter(arg_clear); 
				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SaveFormulaWeight", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

		}

		
		/// <summary>
		/// SaveChangeProcess : ChangeProcess
		/// </summary>
		private bool  SaveChangeProcess(bool arg_clear)
		{
            string  vCheck   = ClassLib.ComVar.ConsFalse ;
			try
			{
				//DataSet ds_ret;
				for (int k  = fgrid_Yield.Rows.Fixed   ; k < fgrid_Yield.Rows.Count   ;k++)
				{
					if (fgrid_Yield[k,0].ToString() == "M")
					{
						vCheck = ClassLib.ComVar.ConsTrue;
						continue;
					}
				}

				if (vCheck  ==  ClassLib.ComVar.ConsFalse) return true;
										    
				int  iCol =11;

				_MyOraDB.ReDim_Parameter(iCol); 
				_MyOraDB.Process_Name=  "PKG_SBC_FORMULA.SAVE_CHANGE_PROCESS";
				
				int i=0;
				_MyOraDB.Parameter_Name[i++] = "ARG_FLAG";          
				_MyOraDB.Parameter_Name[i++] = "ARG_FACTORY";  		 
				_MyOraDB.Parameter_Name[i++] = "ARG_STYLE_CD"; 		       
				_MyOraDB.Parameter_Name[i++] = "ARG_SEMI_GOOD_CD"; 	         
				_MyOraDB.Parameter_Name[i++] = "ARG_COMPONENT_CD";   
												
				_MyOraDB.Parameter_Name[i++] = "ARG_TEMPLATE_SEQ";           
				_MyOraDB.Parameter_Name[i++] = "ARG_TEMPLATE_LEVEL";         
				_MyOraDB.Parameter_Name[i++] = "ARG_ACTION_FLAG";        
				_MyOraDB.Parameter_Name[i++] = "ARG_HISTORY_REMARKS";     
				_MyOraDB.Parameter_Name[i++] = "ARG_UPD_YMD"; 		     
												
				_MyOraDB.Parameter_Name[i++] = "ARG_UPD_USER";     

				for ( i=0 ; i< iCol; i++)
					_MyOraDB.Parameter_Type[i] = 1; 						


				int  iRow   = 0;
				for(i =  _Rowfixed; i < fgrid_Yield.Rows.Count; i++)
				{
//					if ((fgrid_Yield[i,0].ToString() == "M") && 
//						(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() == _Material))
//					iRow ++;

					if ((fgrid_Yield[i,0] == null) || fgrid_Yield[i,0].ToString() == "" || fgrid_Yield[i,0].ToString() == " ")  continue;
					
					if (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() == _Material)
						iRow ++;
					
				}

				_MyOraDB.Parameter_Values = new string[iCol * iRow];

				#region Value

				int iCnt = 0; string  old_semi_good_cd =_BlankText;
				for(i =  _Rowfixed; i < fgrid_Yield.Rows.Count; i++)
				{
//					if (((fgrid_Yield[i,0].ToString() == "M") && 
//					(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() == _Material)) == false) continue;

					if ((fgrid_Yield[i,0] == null) || fgrid_Yield[i,0].ToString() == "" || fgrid_Yield[i,0].ToString() == " ")  continue;

					if (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() != _Material)  continue;

					_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,0].ToString();
					_MyOraDB.Parameter_Values[iCnt++] = cmb_factory.SelectedValue.ToString();
					_MyOraDB.Parameter_Values[iCnt++] = cmb_Style.SelectedValue.ToString();

					
					if (fgrid_Yield[i,0].ToString() == "M")
					{
						CellRange cr_n = fgrid_Yield.GetCellRange(i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD);  
						old_semi_good_cd = cr_n.UserData.ToString();
					}
					else
						old_semi_good_cd  =  fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD].ToString();

					_MyOraDB.Parameter_Values[iCnt++] = old_semi_good_cd;
					_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOMPONENT_CD].ToString();


					ClassLib.ComFunction.Empty_String(fgrid_Yield[iRow,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA_SEQ].ToString()," ");

					_MyOraDB.Parameter_Values[iCnt++] = ClassLib.ComFunction.Empty_String(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA_SEQ].ToString()," ");
					string sFormula_Div  = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTEMPLATE_LEVEL].ToString()==_Base_Formula)?_Base_Flag:_Pigment_Flag;
					_MyOraDB.Parameter_Values[iCnt++] = sFormula_Div;
					_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,0].ToString();
					_MyOraDB.Parameter_Values[iCnt++] = old_semi_good_cd +   //Semigood
														fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOMPONENT_CD].ToString() +   //Component
														fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA_SEQ].ToString()+
														fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTEMPLATE_LEVEL].ToString(); 	
					_MyOraDB.Parameter_Values[iCnt++] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

					_MyOraDB.Parameter_Values[iCnt++] = ClassLib.ComVar.This_User;	

				}
				

				#endregion

				_MyOraDB.Add_Modify_Parameter(arg_clear); 	

				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SaveChangeProces", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

//		
//		/// <summary>
//		/// SaveYieldValue : Yield Value 저장
//		/// </summary>
//		private bool SaveYieldValue(bool  arg_clear)
//		{
//			try
//			{
//				//DataSet ds_ret;
//										    
//				int  iCol =39;
//
//   
//
//				_MyOraDB.ReDim_Parameter(iCol); 
//				_MyOraDB.Process_Name=  "PKG_SBC_FORMULA.SAVE_SBC_YIELD_VALUE";
//				
//				int i=0;
//				
//				#region Parameter_Name
//				_MyOraDB.Parameter_Name[i++] = "ARG_FLAG"; 
//				_MyOraDB.Parameter_Name[i++] = "ARG_DIVISION"; 
//				_MyOraDB.Parameter_Name[i++] = "ARG_FACTORY";            
//
//				_MyOraDB.Parameter_Name[i++] = "ARG_STYLE_CD";              
//				_MyOraDB.Parameter_Name[i++] = "ARG_SEMI_GOOD_CD";  
//				_MyOraDB.Parameter_Name[i++] = "ARG_COMPONENT_CD";  
//        
//				_MyOraDB.Parameter_Name[i++] = "ARG_TEMPLATE_SEQ";          
//				_MyOraDB.Parameter_Name[i++] = "ARG_TEMPLATE_LEVEL";        
//				_MyOraDB.Parameter_Name[i++] = "ARG_CS_SIZE_FROM";      
//				
//				_MyOraDB.Parameter_Name[i++] = "ARG_CS_SIZE_TO";       
//				_MyOraDB.Parameter_Name[i++] = "ARG_ITEM_CD";         
//				_MyOraDB.Parameter_Name[i++] = "ARG_SPEC_CD";          
// 
//				_MyOraDB.Parameter_Name[i++] = "ARG_COLOR_CD";          
//				_MyOraDB.Parameter_Name[i++] = "ARG_STYLE_ITEM_DIV";         
//				_MyOraDB.Parameter_Name[i++] = "ARG_COMMON_YN"; 
//          
//				_MyOraDB.Parameter_Name[i++] = "ARG_SHIP_YN";  
//				_MyOraDB.Parameter_Name[i++] = "ARG_PUR_SHIP_YN";         
//				_MyOraDB.Parameter_Name[i++] = "ARG_PUR_IMPORT_YN";           
//
//				_MyOraDB.Parameter_Name[i++] = "ARG_PUR_LOCAL_YN";  
//				_MyOraDB.Parameter_Name[i++] = "ARG_PROD_YN";         
//				_MyOraDB.Parameter_Name[i++] = "ARG_PROD_OP_CD";    
//       
//				_MyOraDB.Parameter_Name[i++] = "ARG_PROD_SEMI_GOOD_CD";  
//				_MyOraDB.Parameter_Name[i++] = "ARG_OUISIDE_IN_YN";         
//				_MyOraDB.Parameter_Name[i++] = "ARG_OUTSIDE_OUT_YN";     
//      
//				_MyOraDB.Parameter_Name[i++] = "ARG_SHIP_LOSS_RATE";  
//				_MyOraDB.Parameter_Name[i++] = "ARG_PUR_LOSS_RATE";         
//				_MyOraDB.Parameter_Name[i++] = "ARG_PROD_LOSS_RATE";  
//         
//				_MyOraDB.Parameter_Name[i++] = "ARG_COMPONENT_SEQ";  
//				_MyOraDB.Parameter_Name[i++] = "ARG_YIELD_E";           
//				_MyOraDB.Parameter_Name[i++] = "ARG_YIELD_M";        
// 	  
//				_MyOraDB.Parameter_Name[i++] = "ARG_GENDER";          
//				_MyOraDB.Parameter_Name[i++] = "ARG_PRESTO_YN";   
//				_MyOraDB.Parameter_Name[i++] = "ARG_ACTION_FLAG";     
//     
//				_MyOraDB.Parameter_Name[i++] = "ARG_HISTORY_REMARKS";          
//				_MyOraDB.Parameter_Name[i++] = "ARG_SEND_CHK";          
//				_MyOraDB.Parameter_Name[i++] = "ARG_SEND_YMD";          
//
//				_MyOraDB.Parameter_Name[i++] = "ARG_UPD_FACTORY";       
//				_MyOraDB.Parameter_Name[i++] = "ARG_UPD_YMD";           
//				_MyOraDB.Parameter_Name[i++] = "ARG_UPD_USER"; 
//				
//
//			    #endregion 
//
//				for ( i=0 ; i< iCol; i++)
//					_MyOraDB.Parameter_Type[i] = 1; 						
//
//
//				int  iRow   = 0;
//				for(i =  _Rowfixed; i < fgrid_Yield.Rows.Count; i++)
//				{
//					if ((fgrid_Yield[i,0] == null) || fgrid_Yield[i,0].ToString() == "" || fgrid_Yield[i,0].ToString() == " ")  continue;					
//					if(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() == _Material)		
//					iRow ++;
//					
//				}
//
//				#region  Parameter_Values
//
//				_MyOraDB.Parameter_Values = new string[iCol * iRow * _Dt_Size_Range.Rows.Count];
//
//				#region Value
//
//				int iCnt=0,iSeq =0; string sHead=_Head;
//				for(i =  _Rowfixed; i < fgrid_Yield.Rows.Count; i++)
//				{
//					if ((fgrid_Yield[i,0] == null) || fgrid_Yield[i,0].ToString() == "" || fgrid_Yield[i,0].ToString() == " ")  continue;					
//					if(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() != _Material)	continue;
//			
//					iSeq ++;
//					for ( int  j=0 ; j<_Dt_Size_Range.Rows.Count; j++)
//					{	
//						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,0].ToString();
//						
//						if ((fgrid_Yield[i-1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() == _Component) &&
//							(j ==0))
//						{
//							sHead = _Head;
//							
//						}
//						else
//							sHead  = _Tail;
//
//						_MyOraDB.Parameter_Values[iCnt++] = sHead ;
//						_MyOraDB.Parameter_Values[iCnt++] = cmb_factory.SelectedValue.ToString();
//
//
//						_MyOraDB.Parameter_Values[iCnt++] = cmb_Style.SelectedValue.ToString();
//						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD].ToString();
//						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOMPONENT_CD].ToString();
//
//
//						_MyOraDB.Parameter_Values[iCnt++] = Convert.ToString(iSeq);
//						string sFormula_Div  = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTEMPLATE_LEVEL].ToString()==_Base_Formula)?_Base_Flag:_Pigment_Flag;
//						_MyOraDB.Parameter_Values[iCnt++] = sFormula_Div;
//						_MyOraDB.Parameter_Values[iCnt++] = _Dt_Size_Range.Rows[j].ItemArray[0].ToString();   
//
//
//						_MyOraDB.Parameter_Values[iCnt++] = _Dt_Size_Range.Rows[j].ItemArray[1].ToString();
//						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxITEM_CD].ToString();
//						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSPEC_CD].ToString();		
//
//
//						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOLOR_CD].ToString();	
//						_MyOraDB.Parameter_Values[iCnt++] =(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSTYLE_ITEM_DIV]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSTYLE_ITEM_DIV].ToString();
//						_MyOraDB.Parameter_Values[iCnt++] =(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOMMON_YN]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOMMON_YN].ToString();		
//
//
//						_MyOraDB.Parameter_Values[iCnt++] =(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSHIP_YN]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSHIP_YN].ToString();					
//						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPUR_SHIP_YN]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPUR_SHIP_YN].ToString();
//						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPUR_IMPORT_YN]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPUR_IMPORT_YN].ToString();
//
//
//						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPUR_LOCAL_YN]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPUR_LOCAL_YN].ToString();
//						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPROD_YN]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPROD_YN].ToString();
//						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPROD_OP_CD]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPROD_OP_CD].ToString();
//
//
//						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPROD_SEMI_GOOD_CD]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPROD_SEMI_GOOD_CD].ToString();	
//						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxOUISIDE_IN_YN]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxOUISIDE_IN_YN].ToString();
//						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxOUTSIDE_OUT_YN]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxOUTSIDE_OUT_YN].ToString();
//
//
//						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSHIP_LOSS_RATE]==null)?_BlankValue:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSHIP_LOSS_RATE].ToString();
//						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPUR_LOSS_RATE]==null)?_BlankValue :fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPUR_LOSS_RATE].ToString();
//						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPROD_LOSS_RATE]==null)?_BlankValue:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPROD_LOSS_RATE].ToString();
//
//
//						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOMPONENT_SEQ]==null)?_BlankValue:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOMPONENT_SEQ].ToString();
//						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOL_ORDER +
//																		Convert.ToInt16(_Dt_Size_Range.Rows[j].ItemArray[3])+1].ToString();
//						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOL_ORDER +
//																		Convert.ToInt16(_Dt_Size_Range.Rows[j].ItemArray[3])+1].ToString();
//
//						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxGENDER].ToString();
//						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPST_YN].ToString();
//						_MyOraDB.Parameter_Values[iCnt++] =(fgrid_Yield[i,0].ToString()  =="M")?fgrid_Yield[i,0].ToString() :_BlankText;
//
//						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD].ToString() +   //Semigood
//															fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOMPONENT_CD].ToString() +   //Component
//															Convert.ToString(iSeq) +														//Templete Seq
//															sFormula_Div; 																	//Templete Level
//						_MyOraDB.Parameter_Values[iCnt++] = _SendCheck;
//						_MyOraDB.Parameter_Values[iCnt++] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
//
//						_MyOraDB.Parameter_Values[iCnt++] = ClassLib.ComVar.This_Factory;
//						_MyOraDB.Parameter_Values[iCnt++] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
//						_MyOraDB.Parameter_Values[iCnt++] = ClassLib.ComVar.This_User;	
//					
//
//					}
//
//					#endregion 
//					
//				}
//				#endregion
//
//				_MyOraDB.Add_Modify_Parameter(arg_clear); 
//	
//				return true;
//
//			}
//			catch(Exception ex)
//			{
//				ClassLib.ComFunction.User_Message(ex.Message, "SaveYieldValue", MessageBoxButtons.OK, MessageBoxIcon.Error);
//				return false;
//			}
//		}



		
		/// <summary>
		/// SaveYieldValue : Yield Value 저장
		/// </summary>
		private bool SaveYieldValue(bool  arg_clear)
		{
			try
			{
				//DataSet ds_ret;
											
				int  iCol =40;

	

				_MyOraDB.ReDim_Parameter(iCol); 
				_MyOraDB.Process_Name=  "PKG_SBC_FORMULA.SAVE_SBC_YIELD_VALUE";
				
				int i=0;
				
				#region Parameter_Name
				_MyOraDB.Parameter_Name[i++] = "ARG_FLAG"; 
				_MyOraDB.Parameter_Name[i++] = "ARG_DIVISION"; 
				_MyOraDB.Parameter_Name[i++] = "ARG_FACTORY";            

				_MyOraDB.Parameter_Name[i++] = "ARG_STYLE_CD";              
				_MyOraDB.Parameter_Name[i++] = "ARG_SEMI_GOOD_CD";  
				_MyOraDB.Parameter_Name[i++] = "ARG_COMPONENT_CD";  
		
				_MyOraDB.Parameter_Name[i++] = "ARG_TEMPLATE_SEQ";          
				_MyOraDB.Parameter_Name[i++] = "ARG_TEMPLATE_LEVEL";  
				_MyOraDB.Parameter_Name[i++] = "ARG_FORMULA_SEQ";

				_MyOraDB.Parameter_Name[i++] = "ARG_CS_SIZE_FROM";      
				_MyOraDB.Parameter_Name[i++] = "ARG_CS_SIZE_TO";       
				_MyOraDB.Parameter_Name[i++] = "ARG_ITEM_CD";         
				_MyOraDB.Parameter_Name[i++] = "ARG_SPEC_CD";          
	
				_MyOraDB.Parameter_Name[i++] = "ARG_COLOR_CD";          
				_MyOraDB.Parameter_Name[i++] = "ARG_STYLE_ITEM_DIV";         
				_MyOraDB.Parameter_Name[i++] = "ARG_COMMON_YN"; 
		    
				_MyOraDB.Parameter_Name[i++] = "ARG_SHIP_YN";  
				_MyOraDB.Parameter_Name[i++] = "ARG_PUR_SHIP_YN";         
				_MyOraDB.Parameter_Name[i++] = "ARG_PUR_IMPORT_YN";           

				_MyOraDB.Parameter_Name[i++] = "ARG_PUR_LOCAL_YN";  
				_MyOraDB.Parameter_Name[i++] = "ARG_PROD_YN";         
				_MyOraDB.Parameter_Name[i++] = "ARG_PROD_OP_CD";    
		
				_MyOraDB.Parameter_Name[i++] = "ARG_PROD_SEMI_GOOD_CD";  
				_MyOraDB.Parameter_Name[i++] = "ARG_OUISIDE_IN_YN";         
				_MyOraDB.Parameter_Name[i++] = "ARG_OUTSIDE_OUT_YN";     
		
				_MyOraDB.Parameter_Name[i++] = "ARG_SHIP_LOSS_RATE";  
				_MyOraDB.Parameter_Name[i++] = "ARG_PUR_LOSS_RATE";         
				_MyOraDB.Parameter_Name[i++] = "ARG_PROD_LOSS_RATE";  
		    
				_MyOraDB.Parameter_Name[i++] = "ARG_COMPONENT_SEQ";  
				_MyOraDB.Parameter_Name[i++] = "ARG_YIELD_E";           
				_MyOraDB.Parameter_Name[i++] = "ARG_YIELD_M";        
		
				_MyOraDB.Parameter_Name[i++] = "ARG_GENDER";          
				_MyOraDB.Parameter_Name[i++] = "ARG_PRESTO_YN";   
				_MyOraDB.Parameter_Name[i++] = "ARG_ACTION_FLAG";     
		
				_MyOraDB.Parameter_Name[i++] = "ARG_HISTORY_REMARKS";          
				_MyOraDB.Parameter_Name[i++] = "ARG_SEND_CHK";          
				_MyOraDB.Parameter_Name[i++] = "ARG_SEND_YMD";          

				_MyOraDB.Parameter_Name[i++] = "ARG_UPD_FACTORY";       
				_MyOraDB.Parameter_Name[i++] = "ARG_UPD_YMD";           
				_MyOraDB.Parameter_Name[i++] = "ARG_UPD_USER"; 
				

				#endregion 

				for ( i=0 ; i< iCol; i++)
					_MyOraDB.Parameter_Type[i] = 1; 						


				int  iRow   = 0;
				for(i =  _Rowfixed; i < fgrid_Yield.Rows.Count; i++)
				{
					if ((fgrid_Yield[i,0] == null) || fgrid_Yield[i,0].ToString() == "" || fgrid_Yield[i,0].ToString() == " ")  continue;					
					if(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() == _Material)		
					iRow ++;
					
				}

				#region  Parameter_Values

				_MyOraDB.Parameter_Values = new string[iCol * iRow * _Dt_Size_Range.Rows.Count];

				#region Value

				int iCnt=0,iSeq =0; string sHead=_Head;
				for(i =  _Rowfixed; i < fgrid_Yield.Rows.Count; i++)
				{
					if ((fgrid_Yield[i,0] == null) || fgrid_Yield[i,0].ToString() == "" || fgrid_Yield[i,0].ToString() == " ")  continue;					
					if(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() != _Material)	continue;
			
					iSeq ++;
					for ( int  j=0 ; j<_Dt_Size_Range.Rows.Count; j++)
					{	
						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,0].ToString();
						
						if ((fgrid_Yield[i-1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION].ToString() == _Component) &&
							(j ==0))
						{
							sHead = _Head;
							
						}
						else
							sHead  = _Tail;

						_MyOraDB.Parameter_Values[iCnt++] = sHead ;
						_MyOraDB.Parameter_Values[iCnt++] = cmb_factory.SelectedValue.ToString();


						_MyOraDB.Parameter_Values[iCnt++] = cmb_Style.SelectedValue.ToString();
						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD].ToString();
						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOMPONENT_CD].ToString();


							
						_MyOraDB.Parameter_Values[iCnt++] = Convert.ToString(iSeq);
						string sFormula_Div  = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTEMPLATE_LEVEL].ToString()==_Base_Formula)?_Base_Flag:_Pigment_Flag;
						_MyOraDB.Parameter_Values[iCnt++] = sFormula_Div;
						if ((fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA_SEQ].ToString() =="") || 
							(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA_SEQ].ToString() ==_BlankText))
						{
							_MyOraDB.Parameter_Values[iCnt++] = _BlankValue;
						}
						else
						{
							_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA_SEQ].ToString();
						}


						_MyOraDB.Parameter_Values[iCnt++] = _Dt_Size_Range.Rows[j].ItemArray[0].ToString();   
						_MyOraDB.Parameter_Values[iCnt++] = _Dt_Size_Range.Rows[j].ItemArray[1].ToString();
						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxITEM_CD].ToString();
						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSPEC_CD].ToString();		


						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOLOR_CD].ToString();	
						_MyOraDB.Parameter_Values[iCnt++] =(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSTYLE_ITEM_DIV]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSTYLE_ITEM_DIV].ToString();
						_MyOraDB.Parameter_Values[iCnt++] =(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOMMON_YN]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOMMON_YN].ToString();		


						_MyOraDB.Parameter_Values[iCnt++] =(fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSHIP_YN]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSHIP_YN].ToString();					
						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPUR_SHIP_YN]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPUR_SHIP_YN].ToString();
						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPUR_IMPORT_YN]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPUR_IMPORT_YN].ToString();


						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPUR_LOCAL_YN]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPUR_LOCAL_YN].ToString();
						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPROD_YN]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPROD_YN].ToString();
						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPROD_OP_CD]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPROD_OP_CD].ToString();


						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPROD_SEMI_GOOD_CD]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPROD_SEMI_GOOD_CD].ToString();	
						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxOUISIDE_IN_YN]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxOUISIDE_IN_YN].ToString();
						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxOUTSIDE_OUT_YN]==null)?_BlankText:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxOUTSIDE_OUT_YN].ToString();


						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSHIP_LOSS_RATE]==null)?_BlankValue:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSHIP_LOSS_RATE].ToString();
						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPUR_LOSS_RATE]==null)?_BlankValue :fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPUR_LOSS_RATE].ToString();
						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPROD_LOSS_RATE]==null)?_BlankValue:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPROD_LOSS_RATE].ToString();


						_MyOraDB.Parameter_Values[iCnt++] = (fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOMPONENT_SEQ]==null)?_BlankValue:fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOMPONENT_SEQ].ToString();
						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOL_ORDER +
							Convert.ToInt16(_Dt_Size_Range.Rows[j].ItemArray[3])+1].ToString();
						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOL_ORDER +
							Convert.ToInt16(_Dt_Size_Range.Rows[j].ItemArray[3])+1].ToString();

						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxGENDER].ToString();
						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxPST_YN].ToString();
						_MyOraDB.Parameter_Values[iCnt++] =(fgrid_Yield[i,0].ToString()  =="M")?fgrid_Yield[i,0].ToString() :_BlankText;

						_MyOraDB.Parameter_Values[iCnt++] = fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD].ToString() +   //Semigood
							fgrid_Yield[i,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxCOMPONENT_CD].ToString() +   //Component
							Convert.ToString(iSeq) +														//Templete Seq
							sFormula_Div; 																	//Templete Level
						_MyOraDB.Parameter_Values[iCnt++] = _SendCheck;
						_MyOraDB.Parameter_Values[iCnt++] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

						_MyOraDB.Parameter_Values[iCnt++] = ClassLib.ComVar.This_Factory;
						_MyOraDB.Parameter_Values[iCnt++] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
						_MyOraDB.Parameter_Values[iCnt++] = ClassLib.ComVar.This_User;	
					


					}

					#endregion 
					
				}
				#endregion

				_MyOraDB.Add_Modify_Parameter(arg_clear); 
	
				return true;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SaveYieldValue", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}




		#endregion

		#region 이벤트처리

		#region 버튼이벤트
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			SetClear();
		}


		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{   
			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

			if  (CheckSetYield() != true) return;

			SetYield();

			ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave ,this);

			this.Cursor = System.Windows.Forms.Cursors.Default;
			
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{  
				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

				SaveYield();
				
				if  (CheckSetYield() == true) 
					SetGridFlagClear();
			    else
					ClassLib.ComFunction.User_Message("Error", "tbtn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);

				


				this.Cursor = System.Windows.Forms.Cursors.Default ;

				

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			} 

		}


       



		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			SetPrintYield();

		}



		#endregion

		#region  기타이벤트

		private void Form_BC_FormulaN_Load(object sender, System.EventArgs e)
		{
			Control_Enable(false); 
		}


		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			
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

		}


		private void chk_CheckInOut_CheckedChanged(object sender, System.EventArgs e)
		{
			
			try
			{

				if(cmb_factory.SelectedIndex == -1 || (txt_Style.Text.Length < 9))
				{
					chk_CheckInOut.Checked  = false;
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

	


		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{  
				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

				int  iR1 = fgrid_Yield.Selection.r1;

				FindPositionCal(fgrid_Yield[iR1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD].ToString(),
					fgrid_Yield[iR1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_CD].ToString(),
					fgrid_Yield[iR1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_COLOR].ToString());

				for (int i =_MatStrRow -1 ;  i<= _MatEndRow  ;i++)
				{
					fgrid_Yield [i,0] ="D";
				}

				this.Cursor = System.Windows.Forms.Cursors.Default;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			} 
		}


		private void btn_Clear_Click(object sender, System.EventArgs e)
		{
			try
			{  
				if( Check_Clear() != true) return;
				
				SaveClear();

				SetGridFlagClear();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			} 
		  
		}


		private void btn_BaseFormula_Click(object sender, System.EventArgs e)
		{
		    SetVBaseFormula();
		}



		private void btn_YieldCopy_Click(object sender, System.EventArgs e)
		{
			SetFormulaCopy();
		}



		private void btn_FormulaMuti_Click(object sender, System.EventArgs e)
		{
			SetChangeMaterial();
		}

	

        //private void btn_ViewHistory_Click(object sender, System.EventArgs e)
        //{
        //    try
        //    { 
        //        View_Yield_History();
        //    }
        //    catch(Exception ex)
        //    {
        //        ClassLib.ComFunction.User_Message(ex.Message, "btn_ViewHistory_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    } 
        //}


		private void fgrid_YieldValue_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{				
				Show_Input_YieldValue_Popup(e.Button);
				SetYieldColor();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_YieldValue_MouseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void fgrid_YieldValue_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
			if (e.Control)
			{
				switch (e.KeyCode)
				{
					case Keys.Insert:
					case Keys.C: // ** copy
						Clipboard.SetDataObject(fgrid_YieldValue.Clip);
						break;
					case Keys.X: // ** cut
						Clipboard.SetDataObject(fgrid_YieldValue.Clip);
						CellRange rg = fgrid_YieldValue.Selection;
						rg.Data = null;
						break;
					case Keys.V: // ** paste
						IDataObject data = Clipboard.GetDataObject();
						if (data.GetDataPresent(typeof(string)))
						{
							//fgrid_YieldValue.Select(fgrid_YieldValue.Row, fgrid_YieldValue.Col, fgrid_YieldValue.Rows.Count-1, fgrid_YieldValue.Cols.Count-1, false);

							fgrid_YieldValue.Select(_Row_YieldValue, fgrid_YieldValue.Col, _Row_YieldValue, fgrid_YieldValue.Cols.Count-1, false);
							fgrid_YieldValue.Clip = (string)data.GetData(typeof(string));
							fgrid_YieldValue.Select(_Row_YieldValue, fgrid_YieldValue.Col, false);
						}
						break;
				}
			}
		}

	

		
		private void txt_Style_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{

				if(e.KeyCode != Keys.Enter) return;
				  
				DataTable dt_list;

				dt_list = ClassLib.ComFunction.Select_StyleList(COM.ComFunction.Empty_TextBox(txt_Style, " "));//txt_style_cd.Text == "" ? " " : txt_style_cd.Text);
				COM.ComCtl.Set_ComboList(dt_list, cmb_Style, 0,1, false);
				cmb_Style.Splits[0].DisplayColumns["Code"].Width = 70;
				cmb_Style.Splits[0].DisplayColumns["Name"].Width = 150;
				dt_list.Dispose();

				cmb_Style.SelectedIndex   = -1; 
				SetBaseInfo(_BaseStyle);

				//***************************
				string stylecd = "";
				int exist_index = -1;

				stylecd = txt_Style.Text.Trim();

				exist_index = txt_Style.Text.IndexOf("-", 0);

				if(exist_index == -1 && stylecd.Length == 9)
				{
					stylecd = stylecd.Substring(0, 6) +  stylecd.Substring(6, 3);
				}
				cmb_Style.SelectedValue = stylecd;
				
			}
			catch(Exception)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "txt_Style_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
					
			} 
			
		}





		
		private void fgrid_Yield_DoubleClick(object sender, System.EventArgs e)
		{
			_Mcs = fgrid_Yield[fgrid_Yield.Selection.r1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_CD ].ToString()+ 
				fgrid_Yield[fgrid_Yield.Selection.r1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_COLOR].ToString();

			SetFormulaWeight();
			
		}


		private void fgrid_Yield_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if((e.KeyCode  !=Keys.Enter)  ||  (fgrid_Yield.Selection.c1 != (int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA)) return;
			
			#region Fomula/Mix 재계산		
			int iR1  = 0;
			//Formula 마지막에서 바꾸리 error처리
			iR1 = (fgrid_Yield[fgrid_Yield.Selection.r1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTEMPLATE_LEVEL].ToString()=="")?
				fgrid_Yield.Selection.r1-1:fgrid_Yield.Selection.r1;

			
			FindPositionCal(fgrid_Yield[iR1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD].ToString(),
							fgrid_Yield[iR1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_CD].ToString(),
							fgrid_Yield[iR1,(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_COLOR].ToString());

			MakeTotalYieldValue(_MatStrRow -1 , (int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA,
				(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMIX,
				(int)ClassLib.TBSBC_FORMULAN_YIELD.lxYIELD_M,  true, false,"U");
			#endregion

			#region 채산값 재계산

			//채산값 재계산을 위한 위치 잡기 전역변수에 선언
			FindPositionCal( fgrid_Yield[iR1 , (int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD].ToString(),
							 fgrid_Yield[iR1 , (int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_CD].ToString(),
						     fgrid_Yield[iR1 , (int)ClassLib.TBSBC_FORMULAN_YIELD.lxMCS_COLOR].ToString());
				
			//채산값 재계산 (Mix에 따라서 )
			SetCalYIeldValue(_MatStrRow, _MatEndRow);

			//채산값 SubTotal구하기.
			MakeTotalYieldValue(_MatStrRow-1, 
								(int)ClassLib.TBSBC_FORMULAN_YIELD.lxFORMULA,
								(int)ClassLib.TBSBC_FORMULAN_YIELD.lxMIX,
								(int)ClassLib.TBSBC_FORMULAN_YIELD.lxYIELD_M,  false , true,"U");

			#endregion

		}

		private void cmb_Yield_Type_SelectedValueChanged(object sender, System.EventArgs e)
		{
//			_YieldType =cmb_Yield_Type.SelectedValue.ToString();
//			 Add_fgrid_YieldValue_Default_Row();
		}


		private void rad_SG_CheckedChanged(object sender, System.EventArgs e)
		{
			
			try
			{
				RadioButton src = sender as RadioButton; 

				fgrid_Yield.Tree.Show(Convert.ToInt32(src.Tag.ToString() ) ); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void txt_Style_TextChanged(object sender, System.EventArgs e)
		{
			chk_CheckInOut.Checked   = false;
		}

		


		private void cmb_Style_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
                chk_CheckInOut.Checked   = false;

				if (cmb_Style.SelectedIndex == -1) return;
				
				this.Cursor = Cursors.WaitCursor;
				

				SetBaseInfo(cmb_Style.SelectedValue.ToString ());
				this.Cursor = Cursors.WaitCursor;

				SetYieldWeight();
				this.Cursor = Cursors.Default;
			}
			catch(Exception)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "txt_Style_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
					
			} 
		}



		private void Form_BC_FormulaN_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{

				#region 메모리 정리

				ClassLib.MemoryManagement.SetProcessWorkingSetSize(this.Handle, 0, 0);
				ClassLib.MemoryManagement.FlushMemory();

				#endregion


				bool exist_modify = Check_NotSave_Data("Close"); 
				if(exist_modify) e.Cancel = true;


				if(chk_CheckInOut.Checked) 
				{
					ClassLib.ComFunction.User_Message("Need Check Out.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
					e.Cancel = true;
				}



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Form_BC_FormulaN_Closing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		#endregion

	#endregion

		#region drag and drop 이벤트 (Move component)

		private void fgrid_Yield_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			_DragInfo.checkDrag = false;

			// left button, no shift: start tracking mouse to drag
			if (e.Button != MouseButtons.Left) return;

			if(fgrid_Yield.MouseRow <= fgrid_Yield.Rows.Fixed) return;


			// component 만 이동 가능
			if(Convert.ToInt32(fgrid_Yield[fgrid_Yield.MouseRow, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxLEVEL].ToString() ) != _CmpLevel) return;
			

			if (_DragInfo.dragging) return;
			if (fgrid_Yield.MouseRow < fgrid_Yield.Rows.Fixed) return;
			
			// save current row and mouse position
			_DragInfo.row = fgrid_Yield.Row;
			_DragInfo.mouseDown = new Point(e.X, e.Y);
            
			// start checking
			_DragInfo.checkDrag = true;


		}

		private void fgrid_Yield_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// if checking and the user moved past our tolerance, start dragging
			if (!_DragInfo.checkDrag || e.Button != MouseButtons.Left) return;
			if (Math.Abs(e.X - _DragInfo.mouseDown.X) + Math.Abs(e.Y - _DragInfo.mouseDown.Y) <= _DragTol) return;

			// update flags
			_DragInfo.dragging = true;
            
			// set cursor and highlight node
			// styles 
			 
			CellStyle cs = fgrid_Yield.Styles.Add("SourceNode");
			cs.BackColor = Color.Yellow;
			cs.Font = new Font(fgrid_Yield.Font, FontStyle.Bold); 
			fgrid_Yield.Cursor = Cursors.NoMove2D;
			fgrid_Yield.SetCellStyle(_DragInfo.row, fgrid_Yield.Selection.c1, cs);

			// check whether we can drop here
			Cursor c = (NoDropHere() ) ? Cursors.No : Cursors.NoMove2D;
			if (c != fgrid_Yield.Cursor) fgrid_Yield.Cursor = c;
		}

		private bool NoDropHere()
		{
			if (fgrid_Yield.MouseRow < fgrid_Yield.Rows.Fixed) return true;
			//if (fgrid_Yield.MouseCol < fgrid_Yield.Cols.Fixed) return true; 
			return false;
		} 

		private void fgrid_Yield_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{

			# region 반제 변경 구소스
//			// we're not checking until the mouse goes down again
//			_DragInfo.checkDrag = false;
//
//			// not dragging? we're done
//			if (!_DragInfo.dragging) return; 
//
//			// stop dragging
//			_DragInfo.dragging = false;
//			fgrid_Yield.SetCellStyle(_DragInfo.row, fgrid_Yield.Selection.c1, null);
//			fgrid_Yield.Cursor = Cursors.Default;
//		       
//			
//			// test whether the drop is allowed
//			if (NoDropHere()) return;
//
//			// semi good 일때만 가능
//			int k  = fgrid_Yield.MouseRow;
//			if(Convert.ToInt32(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxLEVEL].ToString() ) != _SGLevel) return;
//
//
//
//			// move node into new parent node
//			Node ndSrc = fgrid_Yield.Rows[_DragInfo.row].Node;
//			Node ndDst = fgrid_Yield.Rows[fgrid_Yield.Row].Node;
//
//			string old_semi_good_cd = fgrid_Yield[ndSrc.Row.Index, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxKEY].ToString().Substring(0,2);
//			string new_semi_good_cd = fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxKEY].ToString().Substring(0,2);
//
//			if( old_semi_good_cd  != new_semi_good_cd)
//			{
//				ndSrc.Move(NodeMoveEnum.ChildOf, ndDst);
//				ndSrc.Select();
//
//				Node node = null;
//				int end_row = -1;
//
//				if(ndSrc.Children == 0)
//				{ 
//					end_row = ndSrc.Row.Index;
//				}
//				else
//				{  
//					end_row = ndSrc.GetNode(NodeTypeEnum.LastChild).Row.SafeIndex;
//
//					while(true)
//					{
//						node = fgrid_Yield.Rows[end_row].Node;
//					
//						if(node.Children == 0) break;
//
//						end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;
//
//					} // end while 
//
//				} // end if
//
//
// 
//				for(int i = ndSrc.Row.Index; i <= end_row; i++)
//				{
//					//fgrid_Yield[i, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION] = _Material;
//					fgrid_Yield[i, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD]  = new_semi_good_cd;
//					fgrid_Yield[i, 0]  = "M";
// 
//					// userdata 값으로 옮기기 전 semi good cd 저장
//					// 전체 save 할 때, Flag = 'M' 인 경우,
//					// 이전 semi good cd 에 대한 데이터 Delete 문 구성하기 위함 
//					CellRange cr = fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD);
//					cr.UserData = old_semi_good_cd;
//
//
//				} 
//
//
//			}


			#endregion  

			// we're not checking until the mouse goes down again
			_DragInfo.checkDrag = false;

			// not dragging? we're done
			if (!_DragInfo.dragging) return; 

			// stop dragging
			_DragInfo.dragging = false;
			fgrid_Yield.SetCellStyle(_DragInfo.row, fgrid_Yield.Selection.c1, "");
			fgrid_Yield.Cursor = Cursors.Default;
				
			
			// test whether the drop is allowed
			if (NoDropHere()) return;

			// semi good 일때만 가능
			int k  = fgrid_Yield.MouseRow;
			if(Convert.ToInt32(fgrid_Yield[fgrid_Yield.MouseRow, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxLEVEL].ToString() ) != _SGLevel) return;



			// move node into new parent node
			Node ndSrc = fgrid_Yield.Rows[_DragInfo.row].Node;
			Node ndDst = fgrid_Yield.Rows[fgrid_Yield.MouseRow].Node;

			string old_semi_good_cd = fgrid_Yield[ndSrc.Row.Index, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxKEY].ToString().Substring(0,2);
			string new_semi_good_cd = fgrid_Yield[fgrid_Yield.MouseRow, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxKEY].ToString().Substring(0,2);

			if( old_semi_good_cd  != new_semi_good_cd)
			{
				ndSrc.Move(NodeMoveEnum.ChildOf, ndDst);
				ndSrc.Select();

				Node node = null;
				int end_row = -1;

				if(ndSrc.Children == 0)
				{ 
					end_row = ndSrc.Row.Index;
				}
				else
				{  
					end_row = ndSrc.GetNode(NodeTypeEnum.LastChild).Row.SafeIndex;

					while(true)
					{
						node = fgrid_Yield.Rows[end_row].Node;
					
						if(node.Children == 0) break;

						end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;

					} // end while 

				} // end if


	
				for(int i = ndSrc.Row.Index; i <= end_row; i++)
				{
					//fgrid_Yield[i, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxTYPE_DIVISION] = _Material;
					fgrid_Yield[i, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD]  = new_semi_good_cd;
					fgrid_Yield[i, 0]  = "M";
	
					// userdata 값으로 옮기기 전 semi good cd 저장
					// 전체 save 할 때, Flag = 'M' 인 경우,
					// 이전 semi good cd 에 대한 데이터 Delete 문 구성하기 위함 
					CellRange cr = fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxSEMI_GOOD_CD);
					cr.UserData = old_semi_good_cd;


				} 


			}
			
		}

		#endregion

		#region context 메뉴


		private void menu_Formula_Register_Click(object sender, System.EventArgs e)
		{
		   SetFormulaRegister();
		}
	

		private void menu_Formula_Base_Click(object sender, System.EventArgs e)
		{
			SetVBaseFormula();
		}

		private void menu_Formula_Copy_Click(object sender, System.EventArgs e)
		{
			SetFormulaCopy();
		}


		private void menu_Material_Change_Click(object sender, System.EventArgs e)
		{
			SetChangeMaterial();
		}



		#endregion

       
		


	}
}

